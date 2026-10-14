using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.EntityClient
{
	// Token: 0x020005DF RID: 1503
	public class EntityDataReader : global::System.Data.Common.DbDataReader, global::System.Data.Entity.Core.IExtendedDataRecord, global::System.Data.IDataRecord
	{
		// Token: 0x06004947 RID: 18759 RVA: 0x00103A43 File Offset: 0x00101C43
		internal EntityDataReader(global::System.Data.Entity.Core.EntityClient.EntityCommand command, global::System.Data.Common.DbDataReader storeDataReader, global::System.Data.CommandBehavior behavior)
		{
			this._command = command;
			this._storeDataReader = storeDataReader;
			this._storeExtendedDataRecord = (storeDataReader as global::System.Data.Entity.Core.IExtendedDataRecord);
			this._behavior = behavior;
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x00103A6C File Offset: 0x00101C6C
		internal EntityDataReader()
		{
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06004949 RID: 18761 RVA: 0x00103A74 File Offset: 0x00101C74
		public override int Depth
		{
			get
			{
				return this._storeDataReader.Depth;
			}
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x0600494A RID: 18762 RVA: 0x00103A81 File Offset: 0x00101C81
		public override int FieldCount
		{
			get
			{
				return this._storeDataReader.FieldCount;
			}
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x0600494B RID: 18763 RVA: 0x00103A8E File Offset: 0x00101C8E
		public override bool HasRows
		{
			get
			{
				return this._storeDataReader.HasRows;
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x0600494C RID: 18764 RVA: 0x00103A9B File Offset: 0x00101C9B
		public override bool IsClosed
		{
			get
			{
				return this._storeDataReader.IsClosed;
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x0600494D RID: 18765 RVA: 0x00103AA8 File Offset: 0x00101CA8
		public override int RecordsAffected
		{
			get
			{
				return this._storeDataReader.RecordsAffected;
			}
		}

		// Token: 0x17000E79 RID: 3705
		public override object this[int ordinal]
		{
			get
			{
				return this._storeDataReader[ordinal];
			}
		}

		// Token: 0x17000E7A RID: 3706
		public override object this[string name]
		{
			get
			{
				global::System.Data.Entity.Utilities.Check.NotNull<string>(name, "name");
				return this._storeDataReader[name];
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06004950 RID: 18768 RVA: 0x00103ADD File Offset: 0x00101CDD
		public override int VisibleFieldCount
		{
			get
			{
				return this._storeDataReader.VisibleFieldCount;
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06004951 RID: 18769 RVA: 0x00103AEA File Offset: 0x00101CEA
		public global::System.Data.Entity.Core.Common.DataRecordInfo DataRecordInfo
		{
			get
			{
				if (this._storeExtendedDataRecord == null)
				{
					return null;
				}
				return this._storeExtendedDataRecord.DataRecordInfo;
			}
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x00103B04 File Offset: 0x00101D04
		public override void Close()
		{
			if (this._command != null)
			{
				this._storeDataReader.Close();
				this._command.NotifyDataReaderClosing();
				if ((this._behavior & global::System.Data.CommandBehavior.CloseConnection) == global::System.Data.CommandBehavior.CloseConnection)
				{
					this._command.Connection.Close();
				}
				this._command = null;
			}
		}

		// Token: 0x06004953 RID: 18771 RVA: 0x00103B53 File Offset: 0x00101D53
		protected override void Dispose(bool disposing)
		{
			if (!this._disposed && disposing)
			{
				this._storeDataReader.Dispose();
			}
			this._disposed = true;
			base.Dispose(disposing);
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x00103B79 File Offset: 0x00101D79
		public override bool GetBoolean(int ordinal)
		{
			return this._storeDataReader.GetBoolean(ordinal);
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x00103B87 File Offset: 0x00101D87
		public override byte GetByte(int ordinal)
		{
			return this._storeDataReader.GetByte(ordinal);
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x00103B95 File Offset: 0x00101D95
		public override long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length)
		{
			return this._storeDataReader.GetBytes(ordinal, dataOffset, buffer, bufferOffset, length);
		}

		// Token: 0x06004957 RID: 18775 RVA: 0x00103BA9 File Offset: 0x00101DA9
		public override char GetChar(int ordinal)
		{
			return this._storeDataReader.GetChar(ordinal);
		}

		// Token: 0x06004958 RID: 18776 RVA: 0x00103BB7 File Offset: 0x00101DB7
		public override long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length)
		{
			return this._storeDataReader.GetChars(ordinal, dataOffset, buffer, bufferOffset, length);
		}

		// Token: 0x06004959 RID: 18777 RVA: 0x00103BCB File Offset: 0x00101DCB
		public override string GetDataTypeName(int ordinal)
		{
			return this._storeDataReader.GetDataTypeName(ordinal);
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x00103BD9 File Offset: 0x00101DD9
		public override global::System.DateTime GetDateTime(int ordinal)
		{
			return this._storeDataReader.GetDateTime(ordinal);
		}

		// Token: 0x0600495B RID: 18779 RVA: 0x00103BE7 File Offset: 0x00101DE7
		protected override global::System.Data.Common.DbDataReader GetDbDataReader(int ordinal)
		{
			return this._storeDataReader.GetData(ordinal);
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x00103BF5 File Offset: 0x00101DF5
		public override decimal GetDecimal(int ordinal)
		{
			return this._storeDataReader.GetDecimal(ordinal);
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x00103C03 File Offset: 0x00101E03
		public override double GetDouble(int ordinal)
		{
			return this._storeDataReader.GetDouble(ordinal);
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x00103C11 File Offset: 0x00101E11
		public override global::System.Type GetFieldType(int ordinal)
		{
			return this._storeDataReader.GetFieldType(ordinal);
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x00103C1F File Offset: 0x00101E1F
		public override float GetFloat(int ordinal)
		{
			return this._storeDataReader.GetFloat(ordinal);
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x00103C2D File Offset: 0x00101E2D
		public override global::System.Guid GetGuid(int ordinal)
		{
			return this._storeDataReader.GetGuid(ordinal);
		}

		// Token: 0x06004961 RID: 18785 RVA: 0x00103C3B File Offset: 0x00101E3B
		public override short GetInt16(int ordinal)
		{
			return this._storeDataReader.GetInt16(ordinal);
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x00103C49 File Offset: 0x00101E49
		public override int GetInt32(int ordinal)
		{
			return this._storeDataReader.GetInt32(ordinal);
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x00103C57 File Offset: 0x00101E57
		public override long GetInt64(int ordinal)
		{
			return this._storeDataReader.GetInt64(ordinal);
		}

		// Token: 0x06004964 RID: 18788 RVA: 0x00103C65 File Offset: 0x00101E65
		public override string GetName(int ordinal)
		{
			return this._storeDataReader.GetName(ordinal);
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x00103C73 File Offset: 0x00101E73
		public override int GetOrdinal(string name)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(name, "name");
			return this._storeDataReader.GetOrdinal(name);
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x00103C8D File Offset: 0x00101E8D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::System.Type GetProviderSpecificFieldType(int ordinal)
		{
			return this._storeDataReader.GetProviderSpecificFieldType(ordinal);
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x00103C9B File Offset: 0x00101E9B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override object GetProviderSpecificValue(int ordinal)
		{
			return this._storeDataReader.GetProviderSpecificValue(ordinal);
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x00103CA9 File Offset: 0x00101EA9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetProviderSpecificValues(object[] values)
		{
			return this._storeDataReader.GetProviderSpecificValues(values);
		}

		// Token: 0x06004969 RID: 18793 RVA: 0x00103CB7 File Offset: 0x00101EB7
		public override global::System.Data.DataTable GetSchemaTable()
		{
			return this._storeDataReader.GetSchemaTable();
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x00103CC4 File Offset: 0x00101EC4
		public override string GetString(int ordinal)
		{
			return this._storeDataReader.GetString(ordinal);
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x00103CD2 File Offset: 0x00101ED2
		public override object GetValue(int ordinal)
		{
			return this._storeDataReader.GetValue(ordinal);
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x00103CE0 File Offset: 0x00101EE0
		public override int GetValues(object[] values)
		{
			return this._storeDataReader.GetValues(values);
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x00103CEE File Offset: 0x00101EEE
		public override bool IsDBNull(int ordinal)
		{
			return this._storeDataReader.IsDBNull(ordinal);
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x00103CFC File Offset: 0x00101EFC
		public override bool NextResult()
		{
			bool result;
			try
			{
				result = this._storeDataReader.NextResult();
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.EntityClient_StoreReaderFailed, innerException);
			}
			return result;
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x00103D38 File Offset: 0x00101F38
		public override async global::System.Threading.Tasks.Task<bool> NextResultAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			bool result;
			try
			{
				result = await this._storeDataReader.NextResultAsync(cancellationToken).WithCurrentCulture<bool>();
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.EntityClient_StoreReaderFailed, innerException);
			}
			return result;
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x00103D85 File Offset: 0x00101F85
		public override bool Read()
		{
			return this._storeDataReader.Read();
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x00103D92 File Offset: 0x00101F92
		public override global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			return this._storeDataReader.ReadAsync(cancellationToken);
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x00103DA7 File Offset: 0x00101FA7
		public override global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._storeDataReader.GetEnumerator();
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x00103DB4 File Offset: 0x00101FB4
		public global::System.Data.Common.DbDataRecord GetDataRecord(int i)
		{
			if (this._storeExtendedDataRecord == null)
			{
				throw new global::System.ArgumentOutOfRangeException("i");
			}
			return this._storeExtendedDataRecord.GetDataRecord(i);
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x00103DD5 File Offset: 0x00101FD5
		public global::System.Data.Common.DbDataReader GetDataReader(int i)
		{
			return this.GetDbDataReader(i);
		}

		// Token: 0x040019EF RID: 6639
		private global::System.Data.Entity.Core.EntityClient.EntityCommand _command;

		// Token: 0x040019F0 RID: 6640
		private readonly global::System.Data.CommandBehavior _behavior;

		// Token: 0x040019F1 RID: 6641
		private readonly global::System.Data.Common.DbDataReader _storeDataReader;

		// Token: 0x040019F2 RID: 6642
		private readonly global::System.Data.Entity.Core.IExtendedDataRecord _storeExtendedDataRecord;

		// Token: 0x040019F3 RID: 6643
		private bool _disposed;
	}
}
