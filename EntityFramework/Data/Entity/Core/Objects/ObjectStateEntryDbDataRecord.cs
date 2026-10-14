using System;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000420 RID: 1056
	internal sealed class ObjectStateEntryDbDataRecord : global::System.Data.Common.DbDataRecord, global::System.Data.Entity.Core.IExtendedDataRecord, global::System.Data.IDataRecord
	{
		// Token: 0x060032F3 RID: 13043 RVA: 0x000A1B20 File Offset: 0x0009FD20
		internal ObjectStateEntryDbDataRecord(global::System.Data.Entity.Core.Objects.EntityEntry cacheEntry, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, object userObject)
		{
			global::System.Data.Entity.EntityState state = cacheEntry.State;
			if (state == global::System.Data.Entity.EntityState.Unchanged || state == global::System.Data.Entity.EntityState.Deleted || state == global::System.Data.Entity.EntityState.Modified)
			{
				this._cacheEntry = cacheEntry;
				this._userObject = userObject;
				this._metadata = metadata;
			}
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x000A1B5C File Offset: 0x0009FD5C
		internal ObjectStateEntryDbDataRecord(global::System.Data.Entity.Core.Objects.RelationshipEntry cacheEntry)
		{
			global::System.Data.Entity.EntityState state = cacheEntry.State;
			if (state == global::System.Data.Entity.EntityState.Unchanged || state == global::System.Data.Entity.EntityState.Deleted || state == global::System.Data.Entity.EntityState.Modified)
			{
				this._cacheEntry = cacheEntry;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x060032F5 RID: 13045 RVA: 0x000A1B8A File Offset: 0x0009FD8A
		public override int FieldCount
		{
			get
			{
				return this._cacheEntry.GetFieldCount(this._metadata);
			}
		}

		// Token: 0x170009DC RID: 2524
		public override object this[int ordinal]
		{
			get
			{
				return this.GetValue(ordinal);
			}
		}

		// Token: 0x170009DD RID: 2525
		public override object this[string name]
		{
			get
			{
				return this.GetValue(this.GetOrdinal(name));
			}
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x000A1BB5 File Offset: 0x0009FDB5
		public override bool GetBoolean(int ordinal)
		{
			return (bool)this.GetValue(ordinal);
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x000A1BC3 File Offset: 0x0009FDC3
		public override byte GetByte(int ordinal)
		{
			return (byte)this.GetValue(ordinal);
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x000A1BD4 File Offset: 0x0009FDD4
		public override long GetBytes(int ordinal, long dataIndex, byte[] buffer, int bufferIndex, int length)
		{
			byte[] array = (byte[])this.GetValue(ordinal);
			if (buffer == null)
			{
				return (long)array.Length;
			}
			int num = (int)dataIndex;
			int num2 = global::System.Math.Min(array.Length - num, length);
			if (num < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("dataIndex", global::System.Data.Entity.Resources.Strings.ADP_InvalidSourceBufferIndex(array.Length.ToString(global::System.Globalization.CultureInfo.InvariantCulture), ((long)num).ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
			if (bufferIndex < 0 || (bufferIndex > 0 && bufferIndex >= buffer.Length))
			{
				throw new global::System.ArgumentOutOfRangeException("bufferIndex", global::System.Data.Entity.Resources.Strings.ADP_InvalidDestinationBufferIndex(buffer.Length.ToString(global::System.Globalization.CultureInfo.InvariantCulture), bufferIndex.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
			if (0 < num2)
			{
				global::System.Array.Copy(array, dataIndex, buffer, (long)bufferIndex, (long)num2);
			}
			else
			{
				if (length < 0)
				{
					throw new global::System.IndexOutOfRangeException(global::System.Data.Entity.Resources.Strings.ADP_InvalidDataLength(((long)length).ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
				}
				num2 = 0;
			}
			return (long)num2;
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x000A1CAF File Offset: 0x0009FEAF
		public override char GetChar(int ordinal)
		{
			return (char)this.GetValue(ordinal);
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x000A1CC0 File Offset: 0x0009FEC0
		public override long GetChars(int ordinal, long dataIndex, char[] buffer, int bufferIndex, int length)
		{
			char[] array = (char[])this.GetValue(ordinal);
			if (buffer == null)
			{
				return (long)array.Length;
			}
			int num = (int)dataIndex;
			int num2 = global::System.Math.Min(array.Length - num, length);
			if (num < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("bufferIndex", global::System.Data.Entity.Resources.Strings.ADP_InvalidSourceBufferIndex(buffer.Length.ToString(global::System.Globalization.CultureInfo.InvariantCulture), ((long)bufferIndex).ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
			if (bufferIndex < 0 || (bufferIndex > 0 && bufferIndex >= buffer.Length))
			{
				throw new global::System.ArgumentOutOfRangeException("bufferIndex", global::System.Data.Entity.Resources.Strings.ADP_InvalidDestinationBufferIndex(buffer.Length.ToString(global::System.Globalization.CultureInfo.InvariantCulture), bufferIndex.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
			if (0 < num2)
			{
				global::System.Array.Copy(array, dataIndex, buffer, (long)bufferIndex, (long)num2);
			}
			else
			{
				if (length < 0)
				{
					throw new global::System.IndexOutOfRangeException(global::System.Data.Entity.Resources.Strings.ADP_InvalidDataLength(((long)length).ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
				}
				num2 = 0;
			}
			return (long)num2;
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x000A1D9C File Offset: 0x0009FF9C
		protected override global::System.Data.Common.DbDataReader GetDbDataReader(int ordinal)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x000A1DA3 File Offset: 0x0009FFA3
		public override string GetDataTypeName(int ordinal)
		{
			return this.GetFieldType(ordinal).Name;
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x000A1DB1 File Offset: 0x0009FFB1
		public override global::System.DateTime GetDateTime(int ordinal)
		{
			return (global::System.DateTime)this.GetValue(ordinal);
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x000A1DBF File Offset: 0x0009FFBF
		public override decimal GetDecimal(int ordinal)
		{
			return (decimal)this.GetValue(ordinal);
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x000A1DCD File Offset: 0x0009FFCD
		public override double GetDouble(int ordinal)
		{
			return (double)this.GetValue(ordinal);
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x000A1DDB File Offset: 0x0009FFDB
		public override global::System.Type GetFieldType(int ordinal)
		{
			return this._cacheEntry.GetFieldType(ordinal, this._metadata);
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x000A1DEF File Offset: 0x0009FFEF
		public override float GetFloat(int ordinal)
		{
			return (float)this.GetValue(ordinal);
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x000A1DFD File Offset: 0x0009FFFD
		public override global::System.Guid GetGuid(int ordinal)
		{
			return (global::System.Guid)this.GetValue(ordinal);
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x000A1E0B File Offset: 0x000A000B
		public override short GetInt16(int ordinal)
		{
			return (short)this.GetValue(ordinal);
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x000A1E19 File Offset: 0x000A0019
		public override int GetInt32(int ordinal)
		{
			return (int)this.GetValue(ordinal);
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x000A1E27 File Offset: 0x000A0027
		public override long GetInt64(int ordinal)
		{
			return (long)this.GetValue(ordinal);
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x000A1E35 File Offset: 0x000A0035
		public override string GetName(int ordinal)
		{
			return this._cacheEntry.GetCLayerName(ordinal, this._metadata);
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x000A1E49 File Offset: 0x000A0049
		public override int GetOrdinal(string name)
		{
			int ordinalforCLayerName = this._cacheEntry.GetOrdinalforCLayerName(name, this._metadata);
			if (ordinalforCLayerName == -1)
			{
				throw new global::System.ArgumentOutOfRangeException("name");
			}
			return ordinalforCLayerName;
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x000A1E6C File Offset: 0x000A006C
		public override string GetString(int ordinal)
		{
			return (string)this.GetValue(ordinal);
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x000A1E7A File Offset: 0x000A007A
		public override object GetValue(int ordinal)
		{
			if (this._cacheEntry.IsRelationship)
			{
				return (this._cacheEntry as global::System.Data.Entity.Core.Objects.RelationshipEntry).GetOriginalRelationValue(ordinal);
			}
			return (this._cacheEntry as global::System.Data.Entity.Core.Objects.EntityEntry).GetOriginalEntityValue(this._metadata, ordinal, this._userObject, global::System.Data.Entity.Core.Objects.ObjectStateValueRecord.OriginalReadonly);
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x000A1EBC File Offset: 0x000A00BC
		public override int GetValues(object[] values)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object[]>(values, "values");
			int num = global::System.Math.Min(values.Length, this.FieldCount);
			for (int i = 0; i < num; i++)
			{
				values[i] = this.GetValue(i);
			}
			return num;
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x000A1EFB File Offset: 0x000A00FB
		public override bool IsDBNull(int ordinal)
		{
			return this.GetValue(ordinal) == global::System.DBNull.Value;
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x0600330E RID: 13070 RVA: 0x000A1F0B File Offset: 0x000A010B
		public global::System.Data.Entity.Core.Common.DataRecordInfo DataRecordInfo
		{
			get
			{
				if (this._recordInfo == null)
				{
					this._recordInfo = this._cacheEntry.GetDataRecordInfo(this._metadata, this._userObject);
				}
				return this._recordInfo;
			}
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x000A1F38 File Offset: 0x000A0138
		public global::System.Data.Common.DbDataRecord GetDataRecord(int ordinal)
		{
			return (global::System.Data.Common.DbDataRecord)this.GetValue(ordinal);
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x000A1F46 File Offset: 0x000A0146
		public global::System.Data.Common.DbDataReader GetDataReader(int i)
		{
			return this.GetDbDataReader(i);
		}

		// Token: 0x04001094 RID: 4244
		private readonly global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata _metadata;

		// Token: 0x04001095 RID: 4245
		private readonly global::System.Data.Entity.Core.Objects.ObjectStateEntry _cacheEntry;

		// Token: 0x04001096 RID: 4246
		private readonly object _userObject;

		// Token: 0x04001097 RID: 4247
		private global::System.Data.Entity.Core.Common.DataRecordInfo _recordInfo;
	}
}
