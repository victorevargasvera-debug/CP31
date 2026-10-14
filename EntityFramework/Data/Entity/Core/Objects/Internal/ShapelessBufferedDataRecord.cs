using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000458 RID: 1112
	internal class ShapelessBufferedDataRecord : global::System.Data.Entity.Core.Objects.Internal.BufferedDataRecord
	{
		// Token: 0x06003676 RID: 13942 RVA: 0x000AFBDC File Offset: 0x000ADDDC
		protected ShapelessBufferedDataRecord()
		{
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x000AFBE4 File Offset: 0x000ADDE4
		internal static global::System.Data.Entity.Core.Objects.Internal.ShapelessBufferedDataRecord Initialize(string providerManifestToken, global::System.Data.Entity.Core.Common.DbProviderServices providerServices, global::System.Data.Common.DbDataReader reader)
		{
			global::System.Data.Entity.Core.Objects.Internal.ShapelessBufferedDataRecord shapelessBufferedDataRecord = new global::System.Data.Entity.Core.Objects.Internal.ShapelessBufferedDataRecord();
			shapelessBufferedDataRecord.ReadMetadata(providerManifestToken, providerServices, reader);
			int fieldCount = shapelessBufferedDataRecord.FieldCount;
			global::System.Collections.Generic.List<object[]> list = new global::System.Collections.Generic.List<object[]>();
			if (shapelessBufferedDataRecord._spatialDataReader != null)
			{
				while (reader.Read())
				{
					object[] array = new object[fieldCount];
					for (int i = 0; i < fieldCount; i++)
					{
						if (reader.IsDBNull(i))
						{
							array[i] = global::System.DBNull.Value;
						}
						else if (shapelessBufferedDataRecord._geographyColumns[i])
						{
							array[i] = shapelessBufferedDataRecord._spatialDataReader.GetGeography(i);
						}
						else if (shapelessBufferedDataRecord._geometryColumns[i])
						{
							array[i] = shapelessBufferedDataRecord._spatialDataReader.GetGeometry(i);
						}
						else
						{
							array[i] = reader.GetValue(i);
						}
					}
					list.Add(array);
				}
			}
			else
			{
				while (reader.Read())
				{
					object[] array2 = new object[fieldCount];
					reader.GetValues(array2);
					list.Add(array2);
				}
			}
			shapelessBufferedDataRecord._rowCount = list.Count;
			shapelessBufferedDataRecord._resultSet = list;
			return shapelessBufferedDataRecord;
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x000AFCD8 File Offset: 0x000ADED8
		internal static async global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.Internal.ShapelessBufferedDataRecord> InitializeAsync(string providerManifestToken, global::System.Data.Entity.Core.Common.DbProviderServices providerServices, global::System.Data.Common.DbDataReader reader, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Core.Objects.Internal.ShapelessBufferedDataRecord record = new global::System.Data.Entity.Core.Objects.Internal.ShapelessBufferedDataRecord();
			record.ReadMetadata(providerManifestToken, providerServices, reader);
			int fieldCount = record.FieldCount;
			global::System.Collections.Generic.List<object[]> resultSet = new global::System.Collections.Generic.List<object[]>();
			for (;;)
			{
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = reader.ReadAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
				if (!cultureAwaiter.IsCompleted)
				{
					await cultureAwaiter;
					cultureAwaiter = cultureAwaiter2;
					cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
				}
				if (!cultureAwaiter.GetResult())
				{
					break;
				}
				object[] row = new object[fieldCount];
				for (int i = 0; i < fieldCount; i++)
				{
					cultureAwaiter = reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (cultureAwaiter.GetResult())
					{
						row[i] = global::System.DBNull.Value;
					}
					else if (record._spatialDataReader != null && record._geographyColumns[i])
					{
						row[i] = await record._spatialDataReader.GetGeographyAsync(i, cancellationToken).WithCurrentCulture<global::System.Data.Entity.Spatial.DbGeography>();
					}
					else if (record._spatialDataReader != null && record._geometryColumns[i])
					{
						row[i] = await record._spatialDataReader.GetGeometryAsync(i, cancellationToken).WithCurrentCulture<global::System.Data.Entity.Spatial.DbGeometry>();
					}
					else
					{
						row[i] = await reader.GetFieldValueAsync<object>(i, cancellationToken).WithCurrentCulture<object>();
					}
				}
				resultSet.Add(row);
				row = null;
			}
			record._rowCount = resultSet.Count;
			record._resultSet = resultSet;
			return record;
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x000AFD38 File Offset: 0x000ADF38
		protected override void ReadMetadata(string providerManifestToken, global::System.Data.Entity.Core.Common.DbProviderServices providerServices, global::System.Data.Common.DbDataReader reader)
		{
			base.ReadMetadata(providerManifestToken, providerServices, reader);
			int fieldCount = base.FieldCount;
			bool flag = false;
			global::System.Data.Entity.Spatial.DbSpatialDataReader dbSpatialDataReader = null;
			if (fieldCount > 0)
			{
				dbSpatialDataReader = providerServices.GetSpatialDataReader(reader, providerManifestToken);
			}
			if (dbSpatialDataReader != null)
			{
				this._geographyColumns = new bool[fieldCount];
				this._geometryColumns = new bool[fieldCount];
				for (int i = 0; i < fieldCount; i++)
				{
					this._geographyColumns[i] = dbSpatialDataReader.IsGeographyColumn(i);
					this._geometryColumns[i] = dbSpatialDataReader.IsGeometryColumn(i);
					flag = (flag || this._geographyColumns[i] || this._geometryColumns[i]);
				}
			}
			this._spatialDataReader = (flag ? dbSpatialDataReader : null);
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x000AFDD1 File Offset: 0x000ADFD1
		public override bool GetBoolean(int ordinal)
		{
			return this.GetFieldValue<bool>(ordinal);
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x000AFDDA File Offset: 0x000ADFDA
		public override byte GetByte(int ordinal)
		{
			return this.GetFieldValue<byte>(ordinal);
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x000AFDE3 File Offset: 0x000ADFE3
		public override char GetChar(int ordinal)
		{
			return this.GetFieldValue<char>(ordinal);
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x000AFDEC File Offset: 0x000ADFEC
		public override global::System.DateTime GetDateTime(int ordinal)
		{
			return this.GetFieldValue<global::System.DateTime>(ordinal);
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x000AFDF5 File Offset: 0x000ADFF5
		public override decimal GetDecimal(int ordinal)
		{
			return this.GetFieldValue<decimal>(ordinal);
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x000AFDFE File Offset: 0x000ADFFE
		public override double GetDouble(int ordinal)
		{
			return this.GetFieldValue<double>(ordinal);
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x000AFE07 File Offset: 0x000AE007
		public override float GetFloat(int ordinal)
		{
			return this.GetFieldValue<float>(ordinal);
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x000AFE10 File Offset: 0x000AE010
		public override global::System.Guid GetGuid(int ordinal)
		{
			return this.GetFieldValue<global::System.Guid>(ordinal);
		}

		// Token: 0x06003682 RID: 13954 RVA: 0x000AFE19 File Offset: 0x000AE019
		public override short GetInt16(int ordinal)
		{
			return this.GetFieldValue<short>(ordinal);
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x000AFE22 File Offset: 0x000AE022
		public override int GetInt32(int ordinal)
		{
			return this.GetFieldValue<int>(ordinal);
		}

		// Token: 0x06003684 RID: 13956 RVA: 0x000AFE2B File Offset: 0x000AE02B
		public override long GetInt64(int ordinal)
		{
			return this.GetFieldValue<long>(ordinal);
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x000AFE34 File Offset: 0x000AE034
		public override string GetString(int ordinal)
		{
			return this.GetFieldValue<string>(ordinal);
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x000AFE3D File Offset: 0x000AE03D
		public override T GetFieldValue<T>(int ordinal)
		{
			return (T)((object)this._currentRow[ordinal]);
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x000AFE4C File Offset: 0x000AE04C
		public override global::System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			return global::System.Threading.Tasks.Task.FromResult<T>((T)((object)this._currentRow[ordinal]));
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x000AFE60 File Offset: 0x000AE060
		public override object GetValue(int ordinal)
		{
			return this.GetFieldValue<object>(ordinal);
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x000AFE6C File Offset: 0x000AE06C
		public override int GetValues(object[] values)
		{
			int num = global::System.Math.Min(values.Length, base.FieldCount);
			for (int i = 0; i < num; i++)
			{
				values[i] = this.GetValue(i);
			}
			return num;
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x000AFE9F File Offset: 0x000AE09F
		public override bool IsDBNull(int ordinal)
		{
			return this._currentRow.Length == 0 || global::System.DBNull.Value == this._currentRow[ordinal];
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x000AFEBB File Offset: 0x000AE0BB
		public override global::System.Threading.Tasks.Task<bool> IsDBNullAsync(int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			return global::System.Threading.Tasks.Task.FromResult<bool>(this.IsDBNull(ordinal));
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x000AFECC File Offset: 0x000AE0CC
		public override bool Read()
		{
			int num = this._currentRowNumber + 1;
			this._currentRowNumber = num;
			if (num < this._rowCount)
			{
				this._currentRow = this._resultSet[this._currentRowNumber];
				base.IsDataReady = true;
			}
			else
			{
				this._currentRow = null;
				base.IsDataReady = false;
			}
			return base.IsDataReady;
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x000AFF26 File Offset: 0x000AE126
		public override global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return global::System.Threading.Tasks.Task.FromResult<bool>(this.Read());
		}

		// Token: 0x040011AA RID: 4522
		private object[] _currentRow;

		// Token: 0x040011AB RID: 4523
		private global::System.Collections.Generic.List<object[]> _resultSet;

		// Token: 0x040011AC RID: 4524
		private global::System.Data.Entity.Spatial.DbSpatialDataReader _spatialDataReader;

		// Token: 0x040011AD RID: 4525
		private bool[] _geographyColumns;

		// Token: 0x040011AE RID: 4526
		private bool[] _geometryColumns;
	}
}
