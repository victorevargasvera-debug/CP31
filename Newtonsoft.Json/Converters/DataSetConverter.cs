using System;
using System.Data;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E1 RID: 225
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class DataSetConverter : global::Newtonsoft.Json.JsonConverter
	{
		// Token: 0x06000C34 RID: 3124 RVA: 0x00030D88 File Offset: 0x0002EF88
		public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			global::System.Data.DataSet dataSet = (global::System.Data.DataSet)value;
			global::Newtonsoft.Json.Serialization.DefaultContractResolver defaultContractResolver = serializer.ContractResolver as global::Newtonsoft.Json.Serialization.DefaultContractResolver;
			global::Newtonsoft.Json.Converters.DataTableConverter dataTableConverter = new global::Newtonsoft.Json.Converters.DataTableConverter();
			writer.WriteStartObject();
			foreach (object obj in dataSet.Tables)
			{
				global::System.Data.DataTable dataTable = (global::System.Data.DataTable)obj;
				writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName(dataTable.TableName) : dataTable.TableName);
				dataTableConverter.WriteJson(writer, dataTable, serializer);
			}
			writer.WriteEndObject();
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00030E30 File Offset: 0x0002F030
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.Null)
			{
				return null;
			}
			global::System.Data.DataSet dataSet = (objectType == typeof(global::System.Data.DataSet)) ? new global::System.Data.DataSet() : ((global::System.Data.DataSet)global::System.Activator.CreateInstance(objectType));
			global::Newtonsoft.Json.Converters.DataTableConverter dataTableConverter = new global::Newtonsoft.Json.Converters.DataTableConverter();
			reader.ReadAndAssert();
			while (reader.TokenType == global::Newtonsoft.Json.JsonToken.PropertyName)
			{
				global::System.Data.DataTable dataTable = dataSet.Tables[(string)reader.Value];
				bool flag = dataTable != null;
				dataTable = (global::System.Data.DataTable)dataTableConverter.ReadJson(reader, typeof(global::System.Data.DataTable), dataTable, serializer);
				if (!flag)
				{
					dataSet.Tables.Add(dataTable);
				}
				reader.ReadAndAssert();
			}
			return dataSet;
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00030ECF File Offset: 0x0002F0CF
		public override bool CanConvert(global::System.Type valueType)
		{
			return typeof(global::System.Data.DataSet).IsAssignableFrom(valueType);
		}
	}
}
