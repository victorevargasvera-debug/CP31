using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.EntitySql;
using System.Data.Entity.Core.Common.QueryCache;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.EntityClient.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.EntityClient
{
	// Token: 0x020005DC RID: 1500
	public class EntityCommand : global::System.Data.Common.DbCommand
	{
		// Token: 0x060048BF RID: 18623 RVA: 0x00101E2D File Offset: 0x0010002D
		public EntityCommand() : this(new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext())
		{
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x00101E3A File Offset: 0x0010003A
		internal EntityCommand(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext) : this(interceptionContext, new global::System.Data.Entity.Core.EntityClient.EntityCommand.EntityDataReaderFactory())
		{
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x00101E48 File Offset: 0x00100048
		internal EntityCommand(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext, global::System.Data.Entity.Core.EntityClient.EntityCommand.EntityDataReaderFactory factory)
		{
			this._designTimeVisible = true;
			this._commandType = global::System.Data.CommandType.Text;
			this._updatedRowSource = global::System.Data.UpdateRowSource.Both;
			this._parameters = new global::System.Data.Entity.Core.EntityClient.EntityParameterCollection();
			this._interceptionContext = interceptionContext;
			this._enableQueryPlanCaching = true;
			this._entityDataReaderFactory = (factory ?? new global::System.Data.Entity.Core.EntityClient.EntityCommand.EntityDataReaderFactory());
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x00101E99 File Offset: 0x00100099
		public EntityCommand(string statement) : this(statement, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext(), new global::System.Data.Entity.Core.EntityClient.EntityCommand.EntityDataReaderFactory())
		{
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x00101EAC File Offset: 0x001000AC
		internal EntityCommand(string statement, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext context, global::System.Data.Entity.Core.EntityClient.EntityCommand.EntityDataReaderFactory factory) : this(context, factory)
		{
			this._esqlCommandText = statement;
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x00101EBD File Offset: 0x001000BD
		public EntityCommand(string statement, global::System.Data.Entity.Core.EntityClient.EntityConnection connection, global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver) : this(statement, connection)
		{
			this._dependencyResolver = resolver;
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x00101ECE File Offset: 0x001000CE
		public EntityCommand(string statement, global::System.Data.Entity.Core.EntityClient.EntityConnection connection) : this(statement, connection, new global::System.Data.Entity.Core.EntityClient.EntityCommand.EntityDataReaderFactory())
		{
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x00101EDD File Offset: 0x001000DD
		internal EntityCommand(string statement, global::System.Data.Entity.Core.EntityClient.EntityConnection connection, global::System.Data.Entity.Core.EntityClient.EntityCommand.EntityDataReaderFactory factory) : this(statement, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext(), factory)
		{
			this._connection = connection;
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x00101EF3 File Offset: 0x001000F3
		public EntityCommand(string statement, global::System.Data.Entity.Core.EntityClient.EntityConnection connection, global::System.Data.Entity.Core.EntityClient.EntityTransaction transaction) : this(statement, connection, transaction, new global::System.Data.Entity.Core.EntityClient.EntityCommand.EntityDataReaderFactory())
		{
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x00101F03 File Offset: 0x00100103
		internal EntityCommand(string statement, global::System.Data.Entity.Core.EntityClient.EntityConnection connection, global::System.Data.Entity.Core.EntityClient.EntityTransaction transaction, global::System.Data.Entity.Core.EntityClient.EntityCommand.EntityDataReaderFactory factory) : this(statement, connection, factory)
		{
			this._transaction = transaction;
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x00101F18 File Offset: 0x00100118
		internal EntityCommand(global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition commandDefinition, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext context, global::System.Data.Entity.Core.EntityClient.EntityCommand.EntityDataReaderFactory factory = null) : this(context, factory)
		{
			this._commandDefinition = commandDefinition;
			this._parameters = new global::System.Data.Entity.Core.EntityClient.EntityParameterCollection();
			foreach (global::System.Data.Entity.Core.EntityClient.EntityParameter entityParameter in commandDefinition.Parameters)
			{
				this._parameters.Add(entityParameter.Clone());
			}
			this._parameters.ResetIsDirty();
			this._isCommandDefinitionBased = true;
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x00101F9C File Offset: 0x0010019C
		internal EntityCommand(global::System.Data.Entity.Core.EntityClient.EntityConnection connection, global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition entityCommandDefinition, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext context, global::System.Data.Entity.Core.EntityClient.EntityCommand.EntityDataReaderFactory factory = null) : this(entityCommandDefinition, context, factory)
		{
			this._connection = connection;
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x060048CB RID: 18635 RVA: 0x00101FAF File Offset: 0x001001AF
		internal virtual global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext InterceptionContext
		{
			get
			{
				return this._interceptionContext;
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x060048CC RID: 18636 RVA: 0x00101FB7 File Offset: 0x001001B7
		// (set) Token: 0x060048CD RID: 18637 RVA: 0x00101FBF File Offset: 0x001001BF
		public new virtual global::System.Data.Entity.Core.EntityClient.EntityConnection Connection
		{
			get
			{
				return this._connection;
			}
			set
			{
				this.ThrowIfDataReaderIsOpen();
				if (this._connection != value)
				{
					if (this._connection != null)
					{
						this.Unprepare();
					}
					this._connection = value;
					this._transaction = null;
				}
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x060048CE RID: 18638 RVA: 0x00101FEC File Offset: 0x001001EC
		// (set) Token: 0x060048CF RID: 18639 RVA: 0x00101FF4 File Offset: 0x001001F4
		protected override global::System.Data.Common.DbConnection DbConnection
		{
			get
			{
				return this.Connection;
			}
			set
			{
				this.Connection = (global::System.Data.Entity.Core.EntityClient.EntityConnection)value;
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x060048D0 RID: 18640 RVA: 0x00102002 File Offset: 0x00100202
		// (set) Token: 0x060048D1 RID: 18641 RVA: 0x00102026 File Offset: 0x00100226
		public override string CommandText
		{
			get
			{
				if (this._commandTreeSetByUser != null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_CannotGetCommandText);
				}
				return this._esqlCommandText ?? "";
			}
			set
			{
				this.ThrowIfDataReaderIsOpen();
				if (this._commandTreeSetByUser != null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_CannotSetCommandText);
				}
				if (this._esqlCommandText != value)
				{
					this._esqlCommandText = value;
					this.Unprepare();
					this._isCommandDefinitionBased = false;
				}
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x060048D2 RID: 18642 RVA: 0x00102063 File Offset: 0x00100263
		// (set) Token: 0x060048D3 RID: 18643 RVA: 0x00102084 File Offset: 0x00100284
		public virtual global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree CommandTree
		{
			get
			{
				if (!string.IsNullOrEmpty(this._esqlCommandText))
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_CannotGetCommandTree);
				}
				return this._commandTreeSetByUser;
			}
			set
			{
				this.ThrowIfDataReaderIsOpen();
				if (!string.IsNullOrEmpty(this._esqlCommandText))
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_CannotSetCommandTree);
				}
				if (global::System.Data.CommandType.Text != this.CommandType)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_InternalProviderError(1026));
				}
				if (this._commandTreeSetByUser != value)
				{
					this._commandTreeSetByUser = value;
					this.Unprepare();
					this._isCommandDefinitionBased = false;
				}
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x060048D4 RID: 18644 RVA: 0x001020EC File Offset: 0x001002EC
		// (set) Token: 0x060048D5 RID: 18645 RVA: 0x00102143 File Offset: 0x00100343
		public override int CommandTimeout
		{
			get
			{
				if (this._commandTimeout != null)
				{
					return this._commandTimeout.Value;
				}
				if (this._connection != null && this._connection.StoreProviderFactory != null)
				{
					global::System.Data.Common.DbCommand dbCommand = this._connection.StoreProviderFactory.CreateCommand();
					if (dbCommand != null)
					{
						return dbCommand.CommandTimeout;
					}
				}
				return 0;
			}
			set
			{
				this.ThrowIfDataReaderIsOpen();
				this._commandTimeout = new int?(value);
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x060048D6 RID: 18646 RVA: 0x00102157 File Offset: 0x00100357
		// (set) Token: 0x060048D7 RID: 18647 RVA: 0x0010215F File Offset: 0x0010035F
		public override global::System.Data.CommandType CommandType
		{
			get
			{
				return this._commandType;
			}
			set
			{
				this.ThrowIfDataReaderIsOpen();
				if (value != global::System.Data.CommandType.Text && value != global::System.Data.CommandType.StoredProcedure)
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.EntityClient_UnsupportedCommandType);
				}
				this._commandType = value;
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x060048D8 RID: 18648 RVA: 0x00102181 File Offset: 0x00100381
		public new virtual global::System.Data.Entity.Core.EntityClient.EntityParameterCollection Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x060048D9 RID: 18649 RVA: 0x00102189 File Offset: 0x00100389
		protected override global::System.Data.Common.DbParameterCollection DbParameterCollection
		{
			get
			{
				return this.Parameters;
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x060048DA RID: 18650 RVA: 0x00102191 File Offset: 0x00100391
		// (set) Token: 0x060048DB RID: 18651 RVA: 0x00102199 File Offset: 0x00100399
		public new virtual global::System.Data.Entity.Core.EntityClient.EntityTransaction Transaction
		{
			get
			{
				return this._transaction;
			}
			set
			{
				this.ThrowIfDataReaderIsOpen();
				this._transaction = value;
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x060048DC RID: 18652 RVA: 0x001021A8 File Offset: 0x001003A8
		// (set) Token: 0x060048DD RID: 18653 RVA: 0x001021B0 File Offset: 0x001003B0
		protected override global::System.Data.Common.DbTransaction DbTransaction
		{
			get
			{
				return this.Transaction;
			}
			set
			{
				this.Transaction = (global::System.Data.Entity.Core.EntityClient.EntityTransaction)value;
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x060048DE RID: 18654 RVA: 0x001021BE File Offset: 0x001003BE
		// (set) Token: 0x060048DF RID: 18655 RVA: 0x001021C6 File Offset: 0x001003C6
		public override global::System.Data.UpdateRowSource UpdatedRowSource
		{
			get
			{
				return this._updatedRowSource;
			}
			set
			{
				this.ThrowIfDataReaderIsOpen();
				this._updatedRowSource = value;
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x060048E0 RID: 18656 RVA: 0x001021D5 File Offset: 0x001003D5
		// (set) Token: 0x060048E1 RID: 18657 RVA: 0x001021DD File Offset: 0x001003DD
		public override bool DesignTimeVisible
		{
			get
			{
				return this._designTimeVisible;
			}
			set
			{
				this.ThrowIfDataReaderIsOpen();
				this._designTimeVisible = value;
				global::System.ComponentModel.TypeDescriptor.Refresh(this);
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x060048E2 RID: 18658 RVA: 0x001021F2 File Offset: 0x001003F2
		// (set) Token: 0x060048E3 RID: 18659 RVA: 0x001021FA File Offset: 0x001003FA
		public virtual bool EnablePlanCaching
		{
			get
			{
				return this._enableQueryPlanCaching;
			}
			set
			{
				this.ThrowIfDataReaderIsOpen();
				this._enableQueryPlanCaching = value;
			}
		}

		// Token: 0x060048E4 RID: 18660 RVA: 0x00102209 File Offset: 0x00100409
		public override void Cancel()
		{
		}

		// Token: 0x060048E5 RID: 18661 RVA: 0x0010220B File Offset: 0x0010040B
		public new virtual global::System.Data.Entity.Core.EntityClient.EntityParameter CreateParameter()
		{
			return new global::System.Data.Entity.Core.EntityClient.EntityParameter();
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x00102212 File Offset: 0x00100412
		protected override global::System.Data.Common.DbParameter CreateDbParameter()
		{
			return this.CreateParameter();
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x0010221A File Offset: 0x0010041A
		public new virtual global::System.Data.Entity.Core.EntityClient.EntityDataReader ExecuteReader()
		{
			return this.ExecuteReader(global::System.Data.CommandBehavior.Default);
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x00102224 File Offset: 0x00100424
		public new virtual global::System.Data.Entity.Core.EntityClient.EntityDataReader ExecuteReader(global::System.Data.CommandBehavior behavior)
		{
			this.Prepare();
			global::System.Data.Entity.Core.EntityClient.EntityDataReader entityDataReader = this._entityDataReaderFactory.CreateEntityDataReader(this, this._commandDefinition.Execute(this, behavior), behavior);
			this._dataReader = entityDataReader;
			return entityDataReader;
		}

		// Token: 0x060048E9 RID: 18665 RVA: 0x0010225A File Offset: 0x0010045A
		public new virtual global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.EntityClient.EntityDataReader> ExecuteReaderAsync()
		{
			return this.ExecuteReaderAsync(global::System.Data.CommandBehavior.Default, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x00102268 File Offset: 0x00100468
		public new virtual global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.EntityClient.EntityDataReader> ExecuteReaderAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.ExecuteReaderAsync(global::System.Data.CommandBehavior.Default, cancellationToken);
		}

		// Token: 0x060048EB RID: 18667 RVA: 0x00102272 File Offset: 0x00100472
		public new virtual global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.EntityClient.EntityDataReader> ExecuteReaderAsync(global::System.Data.CommandBehavior behavior)
		{
			return this.ExecuteReaderAsync(behavior, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060048EC RID: 18668 RVA: 0x00102280 File Offset: 0x00100480
		public new virtual async global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.EntityClient.EntityDataReader> ExecuteReaderAsync(global::System.Data.CommandBehavior behavior, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			this.Prepare();
			global::System.Data.Common.DbDataReader storeDataReader = await this._commandDefinition.ExecuteAsync(this, behavior, cancellationToken).WithCurrentCulture<global::System.Data.Common.DbDataReader>();
			global::System.Data.Entity.Core.EntityClient.EntityDataReader entityDataReader = this._entityDataReaderFactory.CreateEntityDataReader(this, storeDataReader, behavior);
			this._dataReader = entityDataReader;
			return entityDataReader;
		}

		// Token: 0x060048ED RID: 18669 RVA: 0x001022D5 File Offset: 0x001004D5
		protected override global::System.Data.Common.DbDataReader ExecuteDbDataReader(global::System.Data.CommandBehavior behavior)
		{
			return this.ExecuteReader(behavior);
		}

		// Token: 0x060048EE RID: 18670 RVA: 0x001022E0 File Offset: 0x001004E0
		protected override async global::System.Threading.Tasks.Task<global::System.Data.Common.DbDataReader> ExecuteDbDataReaderAsync(global::System.Data.CommandBehavior behavior, global::System.Threading.CancellationToken cancellationToken)
		{
			return await this.ExecuteReaderAsync(behavior, cancellationToken).WithCurrentCulture<global::System.Data.Entity.Core.EntityClient.EntityDataReader>();
		}

		// Token: 0x060048EF RID: 18671 RVA: 0x00102338 File Offset: 0x00100538
		public override int ExecuteNonQuery()
		{
			int recordsAffected;
			using (global::System.Data.Entity.Core.EntityClient.EntityDataReader entityDataReader = this.ExecuteReader(global::System.Data.CommandBehavior.SequentialAccess))
			{
				global::System.Data.Entity.Core.Common.Utils.CommandHelper.ConsumeReader(entityDataReader);
				recordsAffected = entityDataReader.RecordsAffected;
			}
			return recordsAffected;
		}

		// Token: 0x060048F0 RID: 18672 RVA: 0x00102378 File Offset: 0x00100578
		public override async global::System.Threading.Tasks.Task<int> ExecuteNonQueryAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Core.EntityClient.EntityDataReader entityDataReader = await this.ExecuteReaderAsync(global::System.Data.CommandBehavior.SequentialAccess, cancellationToken).WithCurrentCulture<global::System.Data.Entity.Core.EntityClient.EntityDataReader>();
			int recordsAffected;
			using (global::System.Data.Entity.Core.EntityClient.EntityDataReader reader = entityDataReader)
			{
				await global::System.Data.Entity.Core.Common.Utils.CommandHelper.ConsumeReaderAsync(reader, cancellationToken).WithCurrentCulture();
				recordsAffected = reader.RecordsAffected;
			}
			return recordsAffected;
		}

		// Token: 0x060048F1 RID: 18673 RVA: 0x001023C8 File Offset: 0x001005C8
		public override object ExecuteScalar()
		{
			object result;
			using (global::System.Data.Entity.Core.EntityClient.EntityDataReader entityDataReader = this.ExecuteReader(global::System.Data.CommandBehavior.SequentialAccess))
			{
				object obj = entityDataReader.Read() ? entityDataReader.GetValue(0) : null;
				global::System.Data.Entity.Core.Common.Utils.CommandHelper.ConsumeReader(entityDataReader);
				result = obj;
			}
			return result;
		}

		// Token: 0x060048F2 RID: 18674 RVA: 0x00102414 File Offset: 0x00100614
		internal virtual void Unprepare()
		{
			this._commandDefinition = null;
			this._preparedCommandTree = null;
			this._parameters.ResetIsDirty();
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x0010242F File Offset: 0x0010062F
		public override void Prepare()
		{
			this.ThrowIfDataReaderIsOpen();
			this.CheckIfReadyToPrepare();
			this.InnerPrepare();
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x00102443 File Offset: 0x00100643
		private void InnerPrepare()
		{
			if (this._parameters.IsDirty)
			{
				this.Unprepare();
			}
			this._commandDefinition = this.GetCommandDefinition();
		}

		// Token: 0x060048F5 RID: 18677 RVA: 0x00102464 File Offset: 0x00100664
		private global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree MakeCommandTree()
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree result = null;
			if (this._commandTreeSetByUser != null)
			{
				result = this._commandTreeSetByUser;
			}
			else if (global::System.Data.CommandType.Text == this.CommandType)
			{
				if (!string.IsNullOrEmpty(this._esqlCommandText))
				{
					global::System.Data.Entity.Core.Metadata.Edm.Perspective perspective = new global::System.Data.Entity.Core.Metadata.Edm.ModelPerspective(this._connection.GetMetadataWorkspace());
					global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> parameterTypeUsage = this.GetParameterTypeUsage();
					result = global::System.Data.Entity.Core.Common.EntitySql.CqlQuery.Compile(this._esqlCommandText, perspective, null, from paramInfo in parameterTypeUsage
					select paramInfo.Value.Parameter(paramInfo.Key)).CommandTree;
				}
				else
				{
					if (this._isCommandDefinitionBased)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_CannotReprepareCommandDefinitionBasedCommand);
					}
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_NoCommandText);
				}
			}
			else if (global::System.Data.CommandType.StoredProcedure == this.CommandType)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> parameterTypeUsage2 = this.GetParameterTypeUsage();
				global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = this.DetermineFunctionImport();
				result = new global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionCommandTree(this.Connection.GetMetadataWorkspace(), global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, edmFunction, null, parameterTypeUsage2);
			}
			return result;
		}

		// Token: 0x060048F6 RID: 18678 RVA: 0x0010253C File Offset: 0x0010073C
		private global::System.Data.Entity.Core.Metadata.Edm.EdmFunction DetermineFunctionImport()
		{
			if (string.IsNullOrEmpty(this.CommandText) || string.IsNullOrEmpty(this.CommandText.Trim()))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_FunctionImportEmptyCommandText);
			}
			string defaultContainerName = null;
			string containerName;
			string functionImportName;
			global::System.Data.Entity.Core.Common.Utils.CommandHelper.ParseFunctionImportCommandText(this.CommandText, defaultContainerName, out containerName, out functionImportName);
			return global::System.Data.Entity.Core.Common.Utils.CommandHelper.FindFunctionImport(this._connection.GetMetadataWorkspace(), containerName, functionImportName);
		}

		// Token: 0x060048F7 RID: 18679 RVA: 0x00102598 File Offset: 0x00100798
		internal virtual global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition GetCommandDefinition()
		{
			global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition entityCommandDefinition = this._commandDefinition;
			if (entityCommandDefinition == null)
			{
				if (!this.TryGetEntityCommandDefinitionFromQueryCache(out entityCommandDefinition))
				{
					entityCommandDefinition = this.CreateCommandDefinition();
				}
				this._commandDefinition = entityCommandDefinition;
			}
			return entityCommandDefinition;
		}

		// Token: 0x060048F8 RID: 18680 RVA: 0x001025C8 File Offset: 0x001007C8
		internal virtual global::System.Data.Entity.Core.EntityClient.EntityTransaction ValidateAndGetEntityTransaction()
		{
			if (this.Transaction != null && this.Transaction != this.Connection.CurrentTransaction)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_InvalidTransactionForCommand);
			}
			return this.Connection.CurrentTransaction;
		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x001025FC File Offset: 0x001007FC
		[global::System.ComponentModel.Browsable(false)]
		public virtual string ToTraceString()
		{
			this.CheckConnectionPresent();
			this.InnerPrepare();
			global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition commandDefinition = this._commandDefinition;
			if (commandDefinition != null)
			{
				return commandDefinition.ToTraceString();
			}
			return string.Empty;
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x0010262C File Offset: 0x0010082C
		private bool TryGetEntityCommandDefinitionFromQueryCache(out global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition entityCommandDefinition)
		{
			entityCommandDefinition = null;
			if (!this._enableQueryPlanCaching || string.IsNullOrEmpty(this._esqlCommandText))
			{
				return false;
			}
			global::System.Data.Entity.Core.Common.QueryCache.EntityClientCacheKey entityClientCacheKey = new global::System.Data.Entity.Core.Common.QueryCache.EntityClientCacheKey(this);
			global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager queryCacheManager = this._connection.GetMetadataWorkspace().GetQueryCacheManager();
			if (!queryCacheManager.TryCacheLookup<global::System.Data.Entity.Core.Common.QueryCache.EntityClientCacheKey, global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition>(entityClientCacheKey, out entityCommandDefinition))
			{
				entityCommandDefinition = this.CreateCommandDefinition();
				global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry queryCacheEntry = null;
				if (queryCacheManager.TryLookupAndAdd(new global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry(entityClientCacheKey, entityCommandDefinition), out queryCacheEntry))
				{
					entityCommandDefinition = (global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition)queryCacheEntry.GetTarget();
				}
			}
			return true;
		}

		// Token: 0x060048FB RID: 18683 RVA: 0x001026A0 File Offset: 0x001008A0
		private global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition CreateCommandDefinition()
		{
			if (this._preparedCommandTree == null)
			{
				this._preparedCommandTree = this.MakeCommandTree();
			}
			if (!this._preparedCommandTree.MetadataWorkspace.IsMetadataWorkspaceCSCompatible(this.Connection.GetMetadataWorkspace()))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_CommandTreeMetadataIncompatible);
			}
			return global::System.Data.Entity.Core.EntityClient.Internal.EntityProviderServices.CreateCommandDefinition(this._connection.StoreProviderFactory, this._preparedCommandTree, this._interceptionContext, this._dependencyResolver);
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x0010270B File Offset: 0x0010090B
		private void CheckConnectionPresent()
		{
			if (this._connection == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_NoConnectionForCommand);
			}
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x00102720 File Offset: 0x00100920
		private void CheckIfReadyToPrepare()
		{
			this.CheckConnectionPresent();
			if (this._connection.StoreProviderFactory == null || this._connection.StoreConnection == null)
			{
				throw global::System.Data.Entity.Resources.Error.EntityClient_ConnectionStringNeededBeforeOperation();
			}
			if (this._connection.State == global::System.Data.ConnectionState.Closed || this._connection.State == global::System.Data.ConnectionState.Broken)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_ExecutingOnClosedConnection((this._connection.State == global::System.Data.ConnectionState.Closed) ? global::System.Data.Entity.Resources.Strings.EntityClient_ConnectionStateClosed : global::System.Data.Entity.Resources.Strings.EntityClient_ConnectionStateBroken));
			}
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x00102793 File Offset: 0x00100993
		private void ThrowIfDataReaderIsOpen()
		{
			if (this._dataReader != null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_DataReaderIsStillOpen);
			}
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x001027A8 File Offset: 0x001009A8
		internal virtual global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> GetParameterTypeUsage()
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(this._parameters.Count);
			foreach (object obj in this._parameters)
			{
				global::System.Data.Entity.Core.EntityClient.EntityParameter entityParameter = (global::System.Data.Entity.Core.EntityClient.EntityParameter)obj;
				string parameterName = entityParameter.ParameterName;
				if (string.IsNullOrEmpty(parameterName))
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_EmptyParameterName);
				}
				if (this.CommandType == global::System.Data.CommandType.Text && entityParameter.Direction != global::System.Data.ParameterDirection.Input)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_InvalidParameterDirection(entityParameter.ParameterName));
				}
				if (entityParameter.EdmType == null && entityParameter.DbType == global::System.Data.DbType.Object && (entityParameter.Value == null || entityParameter.Value is global::System.DBNull))
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_UnknownParameterType(parameterName));
				}
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = entityParameter.GetTypeUsage();
				try
				{
					dictionary.Add(parameterName, typeUsage);
				}
				catch (global::System.ArgumentException innerException)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_DuplicateParameterNames(entityParameter.ParameterName), innerException);
				}
			}
			return dictionary;
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x001028BC File Offset: 0x00100ABC
		internal virtual void NotifyDataReaderClosing()
		{
			this._dataReader = null;
			if (this._storeProviderCommand != null)
			{
				global::System.Data.Entity.Core.Common.Utils.CommandHelper.SetEntityParameterValues(this, this._storeProviderCommand, this._connection);
				this._storeProviderCommand = null;
			}
			if (this.IsNotNullOnDataReaderClosingEvent())
			{
				this.InvokeOnDataReaderClosingEvent(this, new global::System.EventArgs());
			}
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x001028FA File Offset: 0x00100AFA
		internal virtual void SetStoreProviderCommand(global::System.Data.Common.DbCommand storeProviderCommand)
		{
			this._storeProviderCommand = storeProviderCommand;
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x00102903 File Offset: 0x00100B03
		internal virtual bool IsNotNullOnDataReaderClosingEvent()
		{
			return this.OnDataReaderClosing != null;
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x0010290E File Offset: 0x00100B0E
		internal virtual void InvokeOnDataReaderClosingEvent(global::System.Data.Entity.Core.EntityClient.EntityCommand sender, global::System.EventArgs e)
		{
			this.OnDataReaderClosing(sender, e);
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06004904 RID: 18692 RVA: 0x00102920 File Offset: 0x00100B20
		// (remove) Token: 0x06004905 RID: 18693 RVA: 0x00102958 File Offset: 0x00100B58
		internal event global::System.EventHandler OnDataReaderClosing;

		// Token: 0x040019C1 RID: 6593
		private bool _designTimeVisible;

		// Token: 0x040019C2 RID: 6594
		private string _esqlCommandText;

		// Token: 0x040019C3 RID: 6595
		private global::System.Data.Entity.Core.EntityClient.EntityConnection _connection;

		// Token: 0x040019C4 RID: 6596
		private global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree _preparedCommandTree;

		// Token: 0x040019C5 RID: 6597
		private readonly global::System.Data.Entity.Core.EntityClient.EntityParameterCollection _parameters;

		// Token: 0x040019C6 RID: 6598
		private int? _commandTimeout;

		// Token: 0x040019C7 RID: 6599
		private global::System.Data.CommandType _commandType;

		// Token: 0x040019C8 RID: 6600
		private global::System.Data.Entity.Core.EntityClient.EntityTransaction _transaction;

		// Token: 0x040019C9 RID: 6601
		private global::System.Data.UpdateRowSource _updatedRowSource;

		// Token: 0x040019CA RID: 6602
		private global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition _commandDefinition;

		// Token: 0x040019CB RID: 6603
		private bool _isCommandDefinitionBased;

		// Token: 0x040019CC RID: 6604
		private global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree _commandTreeSetByUser;

		// Token: 0x040019CD RID: 6605
		private global::System.Data.Common.DbDataReader _dataReader;

		// Token: 0x040019CE RID: 6606
		private bool _enableQueryPlanCaching;

		// Token: 0x040019CF RID: 6607
		private global::System.Data.Common.DbCommand _storeProviderCommand;

		// Token: 0x040019D0 RID: 6608
		private readonly global::System.Data.Entity.Core.EntityClient.EntityCommand.EntityDataReaderFactory _entityDataReaderFactory;

		// Token: 0x040019D1 RID: 6609
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver _dependencyResolver;

		// Token: 0x040019D2 RID: 6610
		private readonly global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext _interceptionContext;

		// Token: 0x02000C1E RID: 3102
		internal class EntityDataReaderFactory
		{
			// Token: 0x060069D8 RID: 27096 RVA: 0x001695DF File Offset: 0x001677DF
			internal virtual global::System.Data.Entity.Core.EntityClient.EntityDataReader CreateEntityDataReader(global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand, global::System.Data.Common.DbDataReader storeDataReader, global::System.Data.CommandBehavior behavior)
			{
				return new global::System.Data.Entity.Core.EntityClient.EntityDataReader(entityCommand, storeDataReader, behavior);
			}
		}
	}
}
