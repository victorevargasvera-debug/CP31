using System;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Internal.Materialization;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Query.ResultAssembly
{
	// Token: 0x0200032A RID: 810
	internal sealed class BridgeDataRecord : global::System.Data.Common.DbDataRecord, global::System.Data.Entity.Core.IExtendedDataRecord, global::System.Data.IDataRecord
	{
		// Token: 0x060026AD RID: 9901 RVA: 0x0006E962 File Offset: 0x0006CB62
		internal BridgeDataRecord(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState> shaper, int depth)
		{
			this._shaper = shaper;
			this.Depth = depth;
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x0006E978 File Offset: 0x0006CB78
		internal void CloseExplicitly()
		{
			this.Close<object>(global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord.Status.ClosedExplicitly, new global::System.Func<object>(this.CloseNestedObjectImplicitly));
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x0006E990 File Offset: 0x0006CB90
		internal global::System.Threading.Tasks.Task CloseExplicitlyAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.Close<global::System.Threading.Tasks.Task>(global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord.Status.ClosedExplicitly, () => this.CloseNestedObjectImplicitlyAsync(cancellationToken));
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x0006E9C4 File Offset: 0x0006CBC4
		internal void CloseImplicitly()
		{
			this.Close<object>(global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord.Status.ClosedImplicitly, new global::System.Func<object>(this.CloseNestedObjectImplicitly));
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x0006E9DC File Offset: 0x0006CBDC
		internal global::System.Threading.Tasks.Task CloseImplicitlyAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.Close<global::System.Threading.Tasks.Task>(global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord.Status.ClosedImplicitly, () => this.CloseNestedObjectImplicitlyAsync(cancellationToken));
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x0006EA10 File Offset: 0x0006CC10
		private T Close<T>(global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord.Status status, global::System.Func<T> close)
		{
			this._status = status;
			this._source = null;
			return close();
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x0006EA28 File Offset: 0x0006CC28
		private object CloseNestedObjectImplicitly()
		{
			global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord currentNestedRecord = this._currentNestedRecord;
			if (currentNestedRecord != null)
			{
				this._currentNestedRecord = null;
				currentNestedRecord.CloseImplicitly();
			}
			global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataReader currentNestedReader = this._currentNestedReader;
			if (currentNestedReader != null)
			{
				this._currentNestedReader = null;
				currentNestedReader.CloseImplicitly();
			}
			return null;
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x0006EA64 File Offset: 0x0006CC64
		private async global::System.Threading.Tasks.Task CloseNestedObjectImplicitlyAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord currentNestedRecord = this._currentNestedRecord;
			if (currentNestedRecord != null)
			{
				this._currentNestedRecord = null;
				await currentNestedRecord.CloseImplicitlyAsync(cancellationToken).WithCurrentCulture();
			}
			global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataReader currentNestedReader = this._currentNestedReader;
			if (currentNestedReader != null)
			{
				this._currentNestedReader = null;
				await currentNestedReader.CloseImplicitlyAsync(cancellationToken).WithCurrentCulture();
			}
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x0006EAB1 File Offset: 0x0006CCB1
		internal void SetRecordSource(global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState newSource, bool hasData)
		{
			if (hasData)
			{
				this._source = newSource;
			}
			else
			{
				this._source = null;
			}
			this._status = global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord.Status.Open;
			this._lastColumnRead = -1;
			this._lastDataOffsetRead = -1L;
			this._lastOrdinalCheckedForNull = -1;
			this._lastValueCheckedForNull = null;
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x0006EAEA File Offset: 0x0006CCEA
		private void AssertReaderIsOpen()
		{
			if (this.IsExplicitlyClosed)
			{
				throw global::System.Data.Entity.Resources.Error.ADP_ClosedDataReaderError();
			}
			if (this.IsImplicitlyClosed)
			{
				throw global::System.Data.Entity.Resources.Error.ADP_ImplicitlyClosedDataReaderError();
			}
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x0006EB08 File Offset: 0x0006CD08
		private void AssertReaderIsOpenWithData()
		{
			this.AssertReaderIsOpen();
			if (!this.HasData)
			{
				throw global::System.Data.Entity.Resources.Error.ADP_NoData();
			}
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x0006EB20 File Offset: 0x0006CD20
		private void AssertSequentialAccess(int ordinal)
		{
			if (ordinal < 0 || ordinal >= this._source.ColumnCount)
			{
				throw new global::System.ArgumentOutOfRangeException("ordinal");
			}
			if (this._lastColumnRead >= ordinal)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_NonSequentialColumnAccess(ordinal.ToString(global::System.Globalization.CultureInfo.InvariantCulture), (this._lastColumnRead + 1).ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
			this._lastColumnRead = ordinal;
			this._lastDataOffsetRead = long.MaxValue;
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x0006EB98 File Offset: 0x0006CD98
		private void AssertSequentialAccess(int ordinal, long dataOffset, string methodName)
		{
			if (ordinal < 0 || ordinal >= this._source.ColumnCount)
			{
				throw new global::System.ArgumentOutOfRangeException("ordinal");
			}
			if (this._lastColumnRead > ordinal || (this._lastColumnRead == ordinal && this._lastDataOffsetRead == 9223372036854775807L))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_NonSequentialColumnAccess(ordinal.ToString(global::System.Globalization.CultureInfo.InvariantCulture), (this._lastColumnRead + 1).ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
			if (this._lastColumnRead == ordinal)
			{
				if (this._lastDataOffsetRead >= dataOffset)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_NonSequentialChunkAccess(dataOffset.ToString(global::System.Globalization.CultureInfo.InvariantCulture), (this._lastDataOffsetRead + 1L).ToString(global::System.Globalization.CultureInfo.InvariantCulture), methodName));
				}
			}
			else
			{
				this._lastColumnRead = ordinal;
				this._lastDataOffsetRead = -1L;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060026BA RID: 9914 RVA: 0x0006EC60 File Offset: 0x0006CE60
		internal bool HasData
		{
			get
			{
				return this._source != null;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x0006EC6B File Offset: 0x0006CE6B
		internal bool IsClosed
		{
			get
			{
				return this._status > global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord.Status.Open;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060026BC RID: 9916 RVA: 0x0006EC76 File Offset: 0x0006CE76
		internal bool IsExplicitlyClosed
		{
			get
			{
				return this._status == global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord.Status.ClosedExplicitly;
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060026BD RID: 9917 RVA: 0x0006EC81 File Offset: 0x0006CE81
		internal bool IsImplicitlyClosed
		{
			get
			{
				return this._status == global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord.Status.ClosedImplicitly;
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060026BE RID: 9918 RVA: 0x0006EC8C File Offset: 0x0006CE8C
		public global::System.Data.Entity.Core.Common.DataRecordInfo DataRecordInfo
		{
			get
			{
				this.AssertReaderIsOpen();
				return this._source.DataRecordInfo;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060026BF RID: 9919 RVA: 0x0006EC9F File Offset: 0x0006CE9F
		public override int FieldCount
		{
			get
			{
				this.AssertReaderIsOpen();
				return this._source.ColumnCount;
			}
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x0006ECB4 File Offset: 0x0006CEB4
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetTypeUsage(int ordinal)
		{
			if (ordinal < 0 || ordinal >= this._source.ColumnCount)
			{
				throw new global::System.ArgumentOutOfRangeException("ordinal");
			}
			global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState recordState = this._source.CurrentColumnValues[ordinal] as global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage result;
			if (recordState != null)
			{
				result = recordState.DataRecordInfo.RecordType;
			}
			else
			{
				result = this._source.GetTypeUsage(ordinal);
			}
			return result;
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x0006ED10 File Offset: 0x0006CF10
		public override string GetDataTypeName(int ordinal)
		{
			this.AssertReaderIsOpenWithData();
			return this.GetTypeUsage(ordinal).ToString();
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x0006ED24 File Offset: 0x0006CF24
		public override global::System.Type GetFieldType(int ordinal)
		{
			this.AssertReaderIsOpenWithData();
			return global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataReader.GetClrTypeFromTypeMetadata(this.GetTypeUsage(ordinal));
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x0006ED38 File Offset: 0x0006CF38
		public override string GetName(int ordinal)
		{
			this.AssertReaderIsOpen();
			return this._source.GetName(ordinal);
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x0006ED4C File Offset: 0x0006CF4C
		public override int GetOrdinal(string name)
		{
			this.AssertReaderIsOpen();
			return this._source.GetOrdinal(name);
		}

		// Token: 0x17000832 RID: 2098
		public override object this[int ordinal]
		{
			get
			{
				return this.GetValue(ordinal);
			}
		}

		// Token: 0x17000833 RID: 2099
		public override object this[string name]
		{
			get
			{
				return this.GetValue(this.GetOrdinal(name));
			}
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x0006ED78 File Offset: 0x0006CF78
		public override object GetValue(int ordinal)
		{
			this.AssertReaderIsOpenWithData();
			this.AssertSequentialAccess(ordinal);
			object result;
			if (ordinal == this._lastOrdinalCheckedForNull)
			{
				result = this._lastValueCheckedForNull;
			}
			else
			{
				this._lastOrdinalCheckedForNull = -1;
				this._lastValueCheckedForNull = null;
				this.CloseNestedObjectImplicitly();
				result = this._source.CurrentColumnValues[ordinal];
				if (this._source.IsNestedObject(ordinal))
				{
					result = this.GetNestedObjectValue(result);
				}
			}
			return result;
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x0006EDE0 File Offset: 0x0006CFE0
		private object GetNestedObjectValue(object result)
		{
			if (result != global::System.DBNull.Value)
			{
				global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState recordState = result as global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState;
				if (recordState != null)
				{
					if (recordState.IsNull)
					{
						result = global::System.DBNull.Value;
					}
					else
					{
						global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord bridgeDataRecord = new global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord(this._shaper, this.Depth + 1);
						bridgeDataRecord.SetRecordSource(recordState, true);
						result = bridgeDataRecord;
						this._currentNestedRecord = bridgeDataRecord;
						this._currentNestedReader = null;
					}
				}
				else
				{
					global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState> coordinator = result as global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>;
					if (coordinator != null)
					{
						global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataReader bridgeDataReader = new global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataReader(this._shaper, coordinator.TypedCoordinatorFactory, this.Depth + 1, null);
						result = bridgeDataReader;
						this._currentNestedRecord = null;
						this._currentNestedReader = bridgeDataReader;
					}
				}
			}
			return result;
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x0006EE7C File Offset: 0x0006D07C
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

		// Token: 0x060026CA RID: 9930 RVA: 0x0006EEBB File Offset: 0x0006D0BB
		public override bool GetBoolean(int ordinal)
		{
			return (bool)this.GetValue(ordinal);
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x0006EEC9 File Offset: 0x0006D0C9
		public override byte GetByte(int ordinal)
		{
			return (byte)this.GetValue(ordinal);
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x0006EED7 File Offset: 0x0006D0D7
		public override char GetChar(int ordinal)
		{
			return (char)this.GetValue(ordinal);
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x0006EEE5 File Offset: 0x0006D0E5
		public override global::System.DateTime GetDateTime(int ordinal)
		{
			return (global::System.DateTime)this.GetValue(ordinal);
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x0006EEF3 File Offset: 0x0006D0F3
		public override decimal GetDecimal(int ordinal)
		{
			return (decimal)this.GetValue(ordinal);
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x0006EF01 File Offset: 0x0006D101
		public override double GetDouble(int ordinal)
		{
			return (double)this.GetValue(ordinal);
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x0006EF0F File Offset: 0x0006D10F
		public override float GetFloat(int ordinal)
		{
			return (float)this.GetValue(ordinal);
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x0006EF1D File Offset: 0x0006D11D
		public override global::System.Guid GetGuid(int ordinal)
		{
			return (global::System.Guid)this.GetValue(ordinal);
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x0006EF2B File Offset: 0x0006D12B
		public override short GetInt16(int ordinal)
		{
			return (short)this.GetValue(ordinal);
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x0006EF39 File Offset: 0x0006D139
		public override int GetInt32(int ordinal)
		{
			return (int)this.GetValue(ordinal);
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x0006EF47 File Offset: 0x0006D147
		public override long GetInt64(int ordinal)
		{
			return (long)this.GetValue(ordinal);
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x0006EF55 File Offset: 0x0006D155
		public override string GetString(int ordinal)
		{
			return (string)this.GetValue(ordinal);
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x0006EF64 File Offset: 0x0006D164
		public override bool IsDBNull(int ordinal)
		{
			object value = this.GetValue(ordinal);
			this._lastColumnRead--;
			this._lastDataOffsetRead = -1L;
			this._lastValueCheckedForNull = value;
			this._lastOrdinalCheckedForNull = ordinal;
			return global::System.DBNull.Value == value;
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x0006EFA8 File Offset: 0x0006D1A8
		public override long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length)
		{
			this.AssertReaderIsOpenWithData();
			this.AssertSequentialAccess(ordinal, dataOffset, "GetBytes");
			long bytes = this._source.GetBytes(ordinal, dataOffset, buffer, bufferOffset, length);
			if (buffer != null)
			{
				this._lastDataOffsetRead = dataOffset + bytes - 1L;
			}
			return bytes;
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x0006EFEC File Offset: 0x0006D1EC
		public override long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length)
		{
			this.AssertReaderIsOpenWithData();
			this.AssertSequentialAccess(ordinal, dataOffset, "GetChars");
			long chars = this._source.GetChars(ordinal, dataOffset, buffer, bufferOffset, length);
			if (buffer != null)
			{
				this._lastDataOffsetRead = dataOffset + chars - 1L;
			}
			return chars;
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x0006F02F File Offset: 0x0006D22F
		protected override global::System.Data.Common.DbDataReader GetDbDataReader(int ordinal)
		{
			return (global::System.Data.Common.DbDataReader)this.GetValue(ordinal);
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x0006F03D File Offset: 0x0006D23D
		public global::System.Data.Common.DbDataRecord GetDataRecord(int ordinal)
		{
			return (global::System.Data.Common.DbDataRecord)this.GetValue(ordinal);
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x0006F04B File Offset: 0x0006D24B
		public global::System.Data.Common.DbDataReader GetDataReader(int ordinal)
		{
			return this.GetDbDataReader(ordinal);
		}

		// Token: 0x04000D7B RID: 3451
		internal readonly int Depth;

		// Token: 0x04000D7C RID: 3452
		private readonly global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState> _shaper;

		// Token: 0x04000D7D RID: 3453
		private global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState _source;

		// Token: 0x04000D7E RID: 3454
		private global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord.Status _status;

		// Token: 0x04000D7F RID: 3455
		private int _lastColumnRead;

		// Token: 0x04000D80 RID: 3456
		private long _lastDataOffsetRead;

		// Token: 0x04000D81 RID: 3457
		private int _lastOrdinalCheckedForNull;

		// Token: 0x04000D82 RID: 3458
		private object _lastValueCheckedForNull;

		// Token: 0x04000D83 RID: 3459
		private global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataReader _currentNestedReader;

		// Token: 0x04000D84 RID: 3460
		private global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord _currentNestedRecord;

		// Token: 0x020009CD RID: 2509
		private enum Status
		{
			// Token: 0x04002858 RID: 10328
			Open,
			// Token: 0x04002859 RID: 10329
			ClosedImplicitly,
			// Token: 0x0400285A RID: 10330
			ClosedExplicitly
		}
	}
}
