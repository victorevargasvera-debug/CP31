using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E2 RID: 226
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class DataTableConverter : global::Newtonsoft.Json.JsonConverter
	{
		// Token: 0x06000C38 RID: 3128 RVA: 0x00030EEC File Offset: 0x0002F0EC
		public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			global::System.Data.DataTable dataTable = (global::System.Data.DataTable)value;
			global::Newtonsoft.Json.Serialization.DefaultContractResolver defaultContractResolver = serializer.ContractResolver as global::Newtonsoft.Json.Serialization.DefaultContractResolver;
			writer.WriteStartArray();
			foreach (object obj in dataTable.Rows)
			{
				global::System.Data.DataRow dataRow = (global::System.Data.DataRow)obj;
				writer.WriteStartObject();
				foreach (object obj2 in dataRow.Table.Columns)
				{
					global::System.Data.DataColumn dataColumn = (global::System.Data.DataColumn)obj2;
					object obj3 = dataRow[dataColumn];
					if (serializer.NullValueHandling != global::Newtonsoft.Json.NullValueHandling.Ignore || (obj3 != null && obj3 != global::System.DBNull.Value))
					{
						writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName(dataColumn.ColumnName) : dataColumn.ColumnName);
						serializer.Serialize(writer, obj3);
					}
				}
				writer.WriteEndObject();
			}
			writer.WriteEndArray();
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0003100C File Offset: 0x0002F20C
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.Null)
			{
				return null;
			}
			global::System.Data.DataTable dataTable = existingValue as global::System.Data.DataTable;
			if (dataTable == null)
			{
				dataTable = ((objectType == typeof(global::System.Data.DataTable)) ? new global::System.Data.DataTable() : ((global::System.Data.DataTable)global::System.Activator.CreateInstance(objectType)));
			}
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.PropertyName)
			{
				dataTable.TableName = (string)reader.Value;
				reader.ReadAndAssert();
				if (reader.TokenType == global::Newtonsoft.Json.JsonToken.Null)
				{
					return dataTable;
				}
			}
			if (reader.TokenType != global::Newtonsoft.Json.JsonToken.StartArray)
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected JSON token when reading DataTable. Expected StartArray, got {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType));
			}
			reader.ReadAndAssert();
			while (reader.TokenType != global::Newtonsoft.Json.JsonToken.EndArray)
			{
				global::Newtonsoft.Json.Converters.DataTableConverter.CreateRow(reader, dataTable, serializer);
				reader.ReadAndAssert();
			}
			return dataTable;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x000310CC File Offset: 0x0002F2CC
		private static void CreateRow(global::Newtonsoft.Json.JsonReader reader, global::System.Data.DataTable dt, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			global::System.Data.DataRow dataRow = dt.NewRow();
			reader.ReadAndAssert();
			while (reader.TokenType == global::Newtonsoft.Json.JsonToken.PropertyName)
			{
				string text = (string)reader.Value;
				reader.ReadAndAssert();
				global::System.Data.DataColumn dataColumn = dt.Columns[text];
				if (dataColumn == null)
				{
					global::System.Type columnDataType = global::Newtonsoft.Json.Converters.DataTableConverter.GetColumnDataType(reader);
					dataColumn = new global::System.Data.DataColumn(text, columnDataType);
					dt.Columns.Add(dataColumn);
				}
				if (dataColumn.DataType == typeof(global::System.Data.DataTable))
				{
					if (reader.TokenType == global::Newtonsoft.Json.JsonToken.StartArray)
					{
						reader.ReadAndAssert();
					}
					global::System.Data.DataTable dataTable = new global::System.Data.DataTable();
					while (reader.TokenType != global::Newtonsoft.Json.JsonToken.EndArray)
					{
						global::Newtonsoft.Json.Converters.DataTableConverter.CreateRow(reader, dataTable, serializer);
						reader.ReadAndAssert();
					}
					dataRow[text] = dataTable;
				}
				else if (dataColumn.DataType.IsArray && dataColumn.DataType != typeof(byte[]))
				{
					if (reader.TokenType == global::Newtonsoft.Json.JsonToken.StartArray)
					{
						reader.ReadAndAssert();
					}
					global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
					while (reader.TokenType != global::Newtonsoft.Json.JsonToken.EndArray)
					{
						list.Add(reader.Value);
						reader.ReadAndAssert();
					}
					global::System.Array array = global::System.Array.CreateInstance(dataColumn.DataType.GetElementType(), list.Count);
					((global::System.Collections.ICollection)list).CopyTo(array, 0);
					dataRow[text] = array;
				}
				else
				{
					object value = (reader.Value != null) ? (serializer.Deserialize(reader, dataColumn.DataType) ?? global::System.DBNull.Value) : global::System.DBNull.Value;
					dataRow[text] = value;
				}
				reader.ReadAndAssert();
			}
			dataRow.EndEdit();
			dt.Rows.Add(dataRow);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0003125C File Offset: 0x0002F45C
		private static global::System.Type GetColumnDataType(global::Newtonsoft.Json.JsonReader reader)
		{
			global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
			switch (tokenType)
			{
			case global::Newtonsoft.Json.JsonToken.StartArray:
				reader.ReadAndAssert();
				if (reader.TokenType == global::Newtonsoft.Json.JsonToken.StartObject)
				{
					return typeof(global::System.Data.DataTable);
				}
				return global::Newtonsoft.Json.Converters.DataTableConverter.GetColumnDataType(reader).MakeArrayType();
			case global::Newtonsoft.Json.JsonToken.Integer:
			case global::Newtonsoft.Json.JsonToken.Float:
			case global::Newtonsoft.Json.JsonToken.String:
			case global::Newtonsoft.Json.JsonToken.Boolean:
			case global::Newtonsoft.Json.JsonToken.Date:
			case global::Newtonsoft.Json.JsonToken.Bytes:
				return reader.ValueType;
			case global::Newtonsoft.Json.JsonToken.Null:
			case global::Newtonsoft.Json.JsonToken.Undefined:
			case global::Newtonsoft.Json.JsonToken.EndArray:
				return typeof(string);
			}
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected JSON token when reading DataTable: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, tokenType));
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0003130D File Offset: 0x0002F50D
		public override bool CanConvert(global::System.Type valueType)
		{
			return typeof(global::System.Data.DataTable).IsAssignableFrom(valueType);
		}
	}
}
