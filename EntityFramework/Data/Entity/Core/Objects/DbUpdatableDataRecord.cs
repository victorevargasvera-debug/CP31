using System;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000405 RID: 1029
	public abstract class DbUpdatableDataRecord : global::System.Data.Common.DbDataRecord, global::System.Data.Entity.Core.IExtendedDataRecord, global::System.Data.IDataRecord
	{
		// Token: 0x06002FF4 RID: 12276 RVA: 0x00096AA7 File Offset: 0x00094CA7
		internal DbUpdatableDataRecord(global::System.Data.Entity.Core.Objects.ObjectStateEntry cacheEntry, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, object userObject)
		{
			this._cacheEntry = cacheEntry;
			this._userObject = userObject;
			this._metadata = metadata;
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x00096AC4 File Offset: 0x00094CC4
		internal DbUpdatableDataRecord(global::System.Data.Entity.Core.Objects.ObjectStateEntry cacheEntry) : this(cacheEntry, null, null)
		{
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06002FF6 RID: 12278 RVA: 0x00096ACF File Offset: 0x00094CCF
		public override int FieldCount
		{
			get
			{
				return this._cacheEntry.GetFieldCount(this._metadata);
			}
		}

		// Token: 0x17000970 RID: 2416
		public override object this[int i]
		{
			get
			{
				return this.GetValue(i);
			}
		}

		// Token: 0x17000971 RID: 2417
		public override object this[string name]
		{
			get
			{
				return this.GetValue(this.GetOrdinal(name));
			}
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x00096AFA File Offset: 0x00094CFA
		public override bool GetBoolean(int i)
		{
			return (bool)this.GetValue(i);
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x00096B08 File Offset: 0x00094D08
		public override byte GetByte(int i)
		{
			return (byte)this.GetValue(i);
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x00096B18 File Offset: 0x00094D18
		public override long GetBytes(int i, long dataIndex, byte[] buffer, int bufferIndex, int length)
		{
			byte[] array = (byte[])this.GetValue(i);
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

		// Token: 0x06002FFC RID: 12284 RVA: 0x00096BF3 File Offset: 0x00094DF3
		public override char GetChar(int i)
		{
			return (char)this.GetValue(i);
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x00096C04 File Offset: 0x00094E04
		public override long GetChars(int i, long dataIndex, char[] buffer, int bufferIndex, int length)
		{
			char[] array = (char[])this.GetValue(i);
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

		// Token: 0x06002FFE RID: 12286 RVA: 0x00096CDF File Offset: 0x00094EDF
		global::System.Data.IDataReader global::System.Data.IDataRecord.GetData(int ordinal)
		{
			return this.GetDbDataReader(ordinal);
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x00096CE8 File Offset: 0x00094EE8
		protected override global::System.Data.Common.DbDataReader GetDbDataReader(int i)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x00096CEF File Offset: 0x00094EEF
		public override string GetDataTypeName(int i)
		{
			return this.GetFieldType(i).Name;
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x00096CFD File Offset: 0x00094EFD
		public override global::System.DateTime GetDateTime(int i)
		{
			return (global::System.DateTime)this.GetValue(i);
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x00096D0B File Offset: 0x00094F0B
		public override decimal GetDecimal(int i)
		{
			return (decimal)this.GetValue(i);
		}

		// Token: 0x06003003 RID: 12291 RVA: 0x00096D19 File Offset: 0x00094F19
		public override double GetDouble(int i)
		{
			return (double)this.GetValue(i);
		}

		// Token: 0x06003004 RID: 12292 RVA: 0x00096D27 File Offset: 0x00094F27
		public override global::System.Type GetFieldType(int i)
		{
			return this._cacheEntry.GetFieldType(i, this._metadata);
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x00096D3B File Offset: 0x00094F3B
		public override float GetFloat(int i)
		{
			return (float)this.GetValue(i);
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x00096D49 File Offset: 0x00094F49
		public override global::System.Guid GetGuid(int i)
		{
			return (global::System.Guid)this.GetValue(i);
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x00096D57 File Offset: 0x00094F57
		public override short GetInt16(int i)
		{
			return (short)this.GetValue(i);
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x00096D65 File Offset: 0x00094F65
		public override int GetInt32(int i)
		{
			return (int)this.GetValue(i);
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x00096D73 File Offset: 0x00094F73
		public override long GetInt64(int i)
		{
			return (long)this.GetValue(i);
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x00096D81 File Offset: 0x00094F81
		public override string GetName(int i)
		{
			return this._cacheEntry.GetCLayerName(i, this._metadata);
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x00096D95 File Offset: 0x00094F95
		public override int GetOrdinal(string name)
		{
			int ordinalforCLayerName = this._cacheEntry.GetOrdinalforCLayerName(name, this._metadata);
			if (ordinalforCLayerName == -1)
			{
				throw new global::System.ArgumentOutOfRangeException("name");
			}
			return ordinalforCLayerName;
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x00096DB8 File Offset: 0x00094FB8
		public override string GetString(int i)
		{
			return (string)this.GetValue(i);
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x00096DC6 File Offset: 0x00094FC6
		public override object GetValue(int i)
		{
			return this.GetRecordValue(i);
		}

		// Token: 0x0600300E RID: 12302
		protected abstract object GetRecordValue(int ordinal);

		// Token: 0x0600300F RID: 12303 RVA: 0x00096DD0 File Offset: 0x00094FD0
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

		// Token: 0x06003010 RID: 12304 RVA: 0x00096E0F File Offset: 0x0009500F
		public override bool IsDBNull(int i)
		{
			return this.GetValue(i) == global::System.DBNull.Value;
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x00096E1F File Offset: 0x0009501F
		public void SetBoolean(int ordinal, bool value)
		{
			this.SetValue(ordinal, value);
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x00096E2E File Offset: 0x0009502E
		public void SetByte(int ordinal, byte value)
		{
			this.SetValue(ordinal, value);
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x00096E3D File Offset: 0x0009503D
		public void SetChar(int ordinal, char value)
		{
			this.SetValue(ordinal, value);
		}

		// Token: 0x06003014 RID: 12308 RVA: 0x00096E4C File Offset: 0x0009504C
		public void SetDataRecord(int ordinal, global::System.Data.IDataRecord value)
		{
			this.SetValue(ordinal, value);
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x00096E56 File Offset: 0x00095056
		public void SetDateTime(int ordinal, global::System.DateTime value)
		{
			this.SetValue(ordinal, value);
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x00096E65 File Offset: 0x00095065
		public void SetDecimal(int ordinal, decimal value)
		{
			this.SetValue(ordinal, value);
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x00096E74 File Offset: 0x00095074
		public void SetDouble(int ordinal, double value)
		{
			this.SetValue(ordinal, value);
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x00096E83 File Offset: 0x00095083
		public void SetFloat(int ordinal, float value)
		{
			this.SetValue(ordinal, value);
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x00096E92 File Offset: 0x00095092
		public void SetGuid(int ordinal, global::System.Guid value)
		{
			this.SetValue(ordinal, value);
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x00096EA1 File Offset: 0x000950A1
		public void SetInt16(int ordinal, short value)
		{
			this.SetValue(ordinal, value);
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x00096EB0 File Offset: 0x000950B0
		public void SetInt32(int ordinal, int value)
		{
			this.SetValue(ordinal, value);
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x00096EBF File Offset: 0x000950BF
		public void SetInt64(int ordinal, long value)
		{
			this.SetValue(ordinal, value);
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x00096ECE File Offset: 0x000950CE
		public void SetString(int ordinal, string value)
		{
			this.SetValue(ordinal, value);
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x00096ED8 File Offset: 0x000950D8
		public void SetValue(int ordinal, object value)
		{
			this.SetRecordValue(ordinal, value);
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x00096EE4 File Offset: 0x000950E4
		public int SetValues(params object[] values)
		{
			int num = global::System.Math.Min(values.Length, this.FieldCount);
			for (int i = 0; i < num; i++)
			{
				this.SetRecordValue(i, values[i]);
			}
			return num;
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x00096F17 File Offset: 0x00095117
		public void SetDBNull(int ordinal)
		{
			this.SetRecordValue(ordinal, global::System.DBNull.Value);
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06003021 RID: 12321 RVA: 0x00096F25 File Offset: 0x00095125
		public virtual global::System.Data.Entity.Core.Common.DataRecordInfo DataRecordInfo
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

		// Token: 0x06003022 RID: 12322 RVA: 0x00096F52 File Offset: 0x00095152
		public global::System.Data.Common.DbDataRecord GetDataRecord(int i)
		{
			return (global::System.Data.Common.DbDataRecord)this.GetValue(i);
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x00096F60 File Offset: 0x00095160
		public global::System.Data.Common.DbDataReader GetDataReader(int i)
		{
			return this.GetDbDataReader(i);
		}

		// Token: 0x06003024 RID: 12324
		protected abstract void SetRecordValue(int ordinal, object value);

		// Token: 0x0400101F RID: 4127
		internal readonly global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata _metadata;

		// Token: 0x04001020 RID: 4128
		internal readonly global::System.Data.Entity.Core.Objects.ObjectStateEntry _cacheEntry;

		// Token: 0x04001021 RID: 4129
		internal readonly object _userObject;

		// Token: 0x04001022 RID: 4130
		internal global::System.Data.Entity.Core.Common.DataRecordInfo _recordInfo;
	}
}
