using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000EF RID: 239
	internal sealed class CommandTracer : global::System.Data.Entity.Infrastructure.Interception.ICancelableDbCommandInterceptor, global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor, global::System.Data.Entity.Infrastructure.Interception.IDbCommandTreeInterceptor, global::System.Data.Entity.Infrastructure.Interception.ICancelableEntityConnectionInterceptor, global::System.IDisposable
	{
		// Token: 0x0600120A RID: 4618 RVA: 0x0002DDCF File Offset: 0x0002BFCF
		public CommandTracer(global::System.Data.Entity.DbContext context) : this(context, global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch)
		{
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0002DDDD File Offset: 0x0002BFDD
		internal CommandTracer(global::System.Data.Entity.DbContext context, global::System.Data.Entity.Infrastructure.Interception.DbDispatchers dispatchers)
		{
			this._context = context;
			this._dispatchers = dispatchers;
			this._dispatchers.AddInterceptor(this);
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x0002DE15 File Offset: 0x0002C015
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Common.DbCommand> DbCommands
		{
			get
			{
				return this._commands;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x0002DE1D File Offset: 0x0002C01D
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree> CommandTrees
		{
			get
			{
				return this._commandTrees;
			}
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0002DE25 File Offset: 0x0002C025
		public bool CommandExecuting(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			if (interceptionContext.DbContexts.Contains(this._context, new global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.DbContext, bool>(object.ReferenceEquals)))
			{
				this._commands.Add(command);
				return false;
			}
			return true;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0002DE55 File Offset: 0x0002C055
		public void TreeCreated(global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeInterceptionContext interceptionContext)
		{
			if (interceptionContext.DbContexts.Contains(this._context, new global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.DbContext, bool>(object.ReferenceEquals)))
			{
				this._commandTrees.Add(interceptionContext.Result);
			}
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x0002DE87 File Offset: 0x0002C087
		public bool ConnectionOpening(global::System.Data.Entity.Core.EntityClient.EntityConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			return !interceptionContext.DbContexts.Contains(this._context, new global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.DbContext, bool>(object.ReferenceEquals));
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0002DEA9 File Offset: 0x0002C0A9
		void global::System.IDisposable.Dispose()
		{
			this._dispatchers.RemoveInterceptor(this);
		}

		// Token: 0x040008FE RID: 2302
		private readonly global::System.Collections.Generic.List<global::System.Data.Common.DbCommand> _commands = new global::System.Collections.Generic.List<global::System.Data.Common.DbCommand>();

		// Token: 0x040008FF RID: 2303
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree> _commandTrees = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree>();

		// Token: 0x04000900 RID: 2304
		private readonly global::System.Data.Entity.DbContext _context;

		// Token: 0x04000901 RID: 2305
		private readonly global::System.Data.Entity.Infrastructure.Interception.DbDispatchers _dispatchers;
	}
}
