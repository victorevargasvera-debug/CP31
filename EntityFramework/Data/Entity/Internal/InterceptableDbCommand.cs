using System;
using System.Collections;
using System.Data.Common;
using System.Data.Entity.Infrastructure.Interception;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Internal
{
	// Token: 0x0200011B RID: 283
	internal sealed class InterceptableDbCommand : global::System.Data.Common.DbCommand
	{
		// Token: 0x0600137A RID: 4986 RVA: 0x00031C2A File Offset: 0x0002FE2A
		public InterceptableDbCommand(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext context, global::System.Data.Entity.Infrastructure.Interception.DbDispatchers dispatchers = null)
		{
			global::System.GC.SuppressFinalize(this);
			this._command = command;
			this._interceptionContext = context;
			this._dispatchers = (dispatchers ?? global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch);
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x00031C56 File Offset: 0x0002FE56
		public global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext InterceptionContext
		{
			get
			{
				return this._interceptionContext;
			}
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00031C5E File Offset: 0x0002FE5E
		public override void Prepare()
		{
			this._command.Prepare();
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x00031C6B File Offset: 0x0002FE6B
		// (set) Token: 0x0600137E RID: 4990 RVA: 0x00031C78 File Offset: 0x0002FE78
		public override string CommandText
		{
			get
			{
				return this._command.CommandText;
			}
			set
			{
				this._command.CommandText = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x00031C86 File Offset: 0x0002FE86
		// (set) Token: 0x06001380 RID: 4992 RVA: 0x00031C93 File Offset: 0x0002FE93
		public override int CommandTimeout
		{
			get
			{
				return this._command.CommandTimeout;
			}
			set
			{
				this._command.CommandTimeout = value;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x00031CA1 File Offset: 0x0002FEA1
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x00031CAE File Offset: 0x0002FEAE
		public override global::System.Data.CommandType CommandType
		{
			get
			{
				return this._command.CommandType;
			}
			set
			{
				this._command.CommandType = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x00031CBC File Offset: 0x0002FEBC
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x00031CC9 File Offset: 0x0002FEC9
		public override global::System.Data.UpdateRowSource UpdatedRowSource
		{
			get
			{
				return this._command.UpdatedRowSource;
			}
			set
			{
				this._command.UpdatedRowSource = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x00031CD7 File Offset: 0x0002FED7
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x00031CE4 File Offset: 0x0002FEE4
		protected override global::System.Data.Common.DbConnection DbConnection
		{
			get
			{
				return this._command.Connection;
			}
			set
			{
				this._command.Connection = value;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x00031CF2 File Offset: 0x0002FEF2
		protected override global::System.Data.Common.DbParameterCollection DbParameterCollection
		{
			get
			{
				return this._command.Parameters;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x00031CFF File Offset: 0x0002FEFF
		// (set) Token: 0x06001389 RID: 5001 RVA: 0x00031D0C File Offset: 0x0002FF0C
		protected override global::System.Data.Common.DbTransaction DbTransaction
		{
			get
			{
				return this._command.Transaction;
			}
			set
			{
				this._command.Transaction = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x00031D1A File Offset: 0x0002FF1A
		// (set) Token: 0x0600138B RID: 5003 RVA: 0x00031D27 File Offset: 0x0002FF27
		public override bool DesignTimeVisible
		{
			get
			{
				return this._command.DesignTimeVisible;
			}
			set
			{
				this._command.DesignTimeVisible = value;
			}
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00031D35 File Offset: 0x0002FF35
		public override void Cancel()
		{
			this._command.Cancel();
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00031D42 File Offset: 0x0002FF42
		protected override global::System.Data.Common.DbParameter CreateDbParameter()
		{
			return this._command.CreateParameter();
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00031D50 File Offset: 0x0002FF50
		public override int ExecuteNonQuery()
		{
			if (!this._dispatchers.CancelableCommand.Executing(this._command, this._interceptionContext))
			{
				return 1;
			}
			return this._dispatchers.Command.NonQuery(this._command, new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext(this._interceptionContext));
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00031DA0 File Offset: 0x0002FFA0
		public override object ExecuteScalar()
		{
			if (!this._dispatchers.CancelableCommand.Executing(this._command, this._interceptionContext))
			{
				return null;
			}
			return this._dispatchers.Command.Scalar(this._command, new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext(this._interceptionContext));
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00031DF0 File Offset: 0x0002FFF0
		protected override global::System.Data.Common.DbDataReader ExecuteDbDataReader(global::System.Data.CommandBehavior behavior)
		{
			if (!this._dispatchers.CancelableCommand.Executing(this._command, this._interceptionContext))
			{
				return new global::System.Data.Entity.Internal.InterceptableDbCommand.NullDataReader();
			}
			global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext dbCommandInterceptionContext = new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext(this._interceptionContext);
			if (behavior != global::System.Data.CommandBehavior.Default)
			{
				dbCommandInterceptionContext = dbCommandInterceptionContext.WithCommandBehavior(behavior);
			}
			return this._dispatchers.Command.Reader(this._command, dbCommandInterceptionContext);
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00031E50 File Offset: 0x00030050
		public override global::System.Threading.Tasks.Task<int> ExecuteNonQueryAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			if (!this._dispatchers.CancelableCommand.Executing(this._command, this._interceptionContext))
			{
				return new global::System.Threading.Tasks.Task<int>(() => 1);
			}
			return this._dispatchers.Command.NonQueryAsync(this._command, new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext(this._interceptionContext), cancellationToken);
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00031ECC File Offset: 0x000300CC
		public override global::System.Threading.Tasks.Task<object> ExecuteScalarAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			if (!this._dispatchers.CancelableCommand.Executing(this._command, this._interceptionContext))
			{
				return new global::System.Threading.Tasks.Task<object>(() => null);
			}
			return this._dispatchers.Command.ScalarAsync(this._command, new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext(this._interceptionContext), cancellationToken);
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00031F48 File Offset: 0x00030148
		protected override global::System.Threading.Tasks.Task<global::System.Data.Common.DbDataReader> ExecuteDbDataReaderAsync(global::System.Data.CommandBehavior behavior, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			if (!this._dispatchers.CancelableCommand.Executing(this._command, this._interceptionContext))
			{
				return new global::System.Threading.Tasks.Task<global::System.Data.Common.DbDataReader>(() => new global::System.Data.Entity.Internal.InterceptableDbCommand.NullDataReader());
			}
			global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext dbCommandInterceptionContext = new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext(this._interceptionContext);
			if (behavior != global::System.Data.CommandBehavior.Default)
			{
				dbCommandInterceptionContext = dbCommandInterceptionContext.WithCommandBehavior(behavior);
			}
			return this._dispatchers.Command.ReaderAsync(this._command, dbCommandInterceptionContext, cancellationToken);
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00031FCE File Offset: 0x000301CE
		protected override void Dispose(bool disposing)
		{
			if (disposing && this._command != null)
			{
				this._command.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x04000955 RID: 2389
		private readonly global::System.Data.Common.DbCommand _command;

		// Token: 0x04000956 RID: 2390
		private readonly global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext _interceptionContext;

		// Token: 0x04000957 RID: 2391
		private readonly global::System.Data.Entity.Infrastructure.Interception.DbDispatchers _dispatchers;

		// Token: 0x020007FE RID: 2046
		private class NullDataReader : global::System.Data.Common.DbDataReader
		{
			// Token: 0x0600594B RID: 22859 RVA: 0x00139BEA File Offset: 0x00137DEA
			public override void Close()
			{
			}

			// Token: 0x0600594C RID: 22860 RVA: 0x00139BEC File Offset: 0x00137DEC
			public override bool NextResult()
			{
				int resultCount = this._resultCount;
				this._resultCount = resultCount + 1;
				return resultCount == 0;
			}

			// Token: 0x0600594D RID: 22861 RVA: 0x00139C10 File Offset: 0x00137E10
			public override bool Read()
			{
				int readCount = this._readCount;
				this._readCount = readCount + 1;
				return readCount == 0;
			}

			// Token: 0x17001060 RID: 4192
			// (get) Token: 0x0600594E RID: 22862 RVA: 0x00139C31 File Offset: 0x00137E31
			public override bool IsClosed
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17001061 RID: 4193
			// (get) Token: 0x0600594F RID: 22863 RVA: 0x00139C34 File Offset: 0x00137E34
			public override int FieldCount
			{
				get
				{
					return 0;
				}
			}

			// Token: 0x06005950 RID: 22864 RVA: 0x00139C37 File Offset: 0x00137E37
			public override int GetOrdinal(string name)
			{
				return -1;
			}

			// Token: 0x06005951 RID: 22865 RVA: 0x00139C3A File Offset: 0x00137E3A
			public override object GetValue(int ordinal)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x06005952 RID: 22866 RVA: 0x00139C41 File Offset: 0x00137E41
			public override global::System.Data.DataTable GetSchemaTable()
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x17001062 RID: 4194
			// (get) Token: 0x06005953 RID: 22867 RVA: 0x00139C48 File Offset: 0x00137E48
			public override int Depth
			{
				get
				{
					throw new global::System.NotImplementedException();
				}
			}

			// Token: 0x17001063 RID: 4195
			// (get) Token: 0x06005954 RID: 22868 RVA: 0x00139C4F File Offset: 0x00137E4F
			public override int RecordsAffected
			{
				get
				{
					return 0;
				}
			}

			// Token: 0x06005955 RID: 22869 RVA: 0x00139C52 File Offset: 0x00137E52
			public override bool GetBoolean(int ordinal)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x06005956 RID: 22870 RVA: 0x00139C59 File Offset: 0x00137E59
			public override byte GetByte(int ordinal)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x06005957 RID: 22871 RVA: 0x00139C60 File Offset: 0x00137E60
			public override long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x06005958 RID: 22872 RVA: 0x00139C67 File Offset: 0x00137E67
			public override char GetChar(int ordinal)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x06005959 RID: 22873 RVA: 0x00139C6E File Offset: 0x00137E6E
			public override long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x0600595A RID: 22874 RVA: 0x00139C75 File Offset: 0x00137E75
			public override global::System.Guid GetGuid(int ordinal)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x0600595B RID: 22875 RVA: 0x00139C7C File Offset: 0x00137E7C
			public override short GetInt16(int ordinal)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x0600595C RID: 22876 RVA: 0x00139C83 File Offset: 0x00137E83
			public override int GetInt32(int ordinal)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x0600595D RID: 22877 RVA: 0x00139C8A File Offset: 0x00137E8A
			public override long GetInt64(int ordinal)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x0600595E RID: 22878 RVA: 0x00139C91 File Offset: 0x00137E91
			public override global::System.DateTime GetDateTime(int ordinal)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x0600595F RID: 22879 RVA: 0x00139C98 File Offset: 0x00137E98
			public override string GetString(int ordinal)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x06005960 RID: 22880 RVA: 0x00139C9F File Offset: 0x00137E9F
			public override decimal GetDecimal(int ordinal)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x06005961 RID: 22881 RVA: 0x00139CA6 File Offset: 0x00137EA6
			public override double GetDouble(int ordinal)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x06005962 RID: 22882 RVA: 0x00139CAD File Offset: 0x00137EAD
			public override float GetFloat(int ordinal)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x06005963 RID: 22883 RVA: 0x00139CB4 File Offset: 0x00137EB4
			public override string GetName(int ordinal)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x06005964 RID: 22884 RVA: 0x00139CBB File Offset: 0x00137EBB
			public override int GetValues(object[] values)
			{
				return 0;
			}

			// Token: 0x06005965 RID: 22885 RVA: 0x00139CBE File Offset: 0x00137EBE
			public override bool IsDBNull(int ordinal)
			{
				return true;
			}

			// Token: 0x17001064 RID: 4196
			public override object this[int ordinal]
			{
				get
				{
					throw new global::System.NotImplementedException();
				}
			}

			// Token: 0x17001065 RID: 4197
			public override object this[string name]
			{
				get
				{
					throw new global::System.NotImplementedException();
				}
			}

			// Token: 0x17001066 RID: 4198
			// (get) Token: 0x06005968 RID: 22888 RVA: 0x00139CCF File Offset: 0x00137ECF
			public override bool HasRows
			{
				get
				{
					throw new global::System.NotImplementedException();
				}
			}

			// Token: 0x06005969 RID: 22889 RVA: 0x00139CD6 File Offset: 0x00137ED6
			public override string GetDataTypeName(int ordinal)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x0600596A RID: 22890 RVA: 0x00139CDD File Offset: 0x00137EDD
			public override global::System.Type GetFieldType(int ordinal)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x0600596B RID: 22891 RVA: 0x00139CE4 File Offset: 0x00137EE4
			public override global::System.Collections.IEnumerator GetEnumerator()
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x040021F6 RID: 8694
			private int _resultCount;

			// Token: 0x040021F7 RID: 8695
			private int _readCount;
		}
	}
}
