using System;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000279 RID: 633
	public class DbCommandInterceptionContext : global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext
	{
		// Token: 0x06001FEE RID: 8174 RVA: 0x0005A253 File Offset: 0x00058453
		public DbCommandInterceptionContext()
		{
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x0005A25C File Offset: 0x0005845C
		public DbCommandInterceptionContext(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext copyFrom) : base(copyFrom)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(copyFrom, "copyFrom");
			global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext dbCommandInterceptionContext = copyFrom as global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext;
			if (dbCommandInterceptionContext != null)
			{
				this._commandBehavior = dbCommandInterceptionContext._commandBehavior;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001FF0 RID: 8176 RVA: 0x0005A292 File Offset: 0x00058492
		public global::System.Data.CommandBehavior CommandBehavior
		{
			get
			{
				return this._commandBehavior;
			}
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x0005A29A File Offset: 0x0005849A
		public global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext WithCommandBehavior(global::System.Data.CommandBehavior commandBehavior)
		{
			global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext dbCommandInterceptionContext = this.TypedClone();
			dbCommandInterceptionContext._commandBehavior = commandBehavior;
			return dbCommandInterceptionContext;
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x0005A2A9 File Offset: 0x000584A9
		private global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext TypedClone()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext)this.Clone();
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x0005A2B6 File Offset: 0x000584B6
		protected override global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext Clone()
		{
			return new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext(this);
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x0005A2BE File Offset: 0x000584BE
		public new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext WithDbContext(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext)base.WithDbContext(context);
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x0005A2D8 File Offset: 0x000584D8
		public new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext WithObjectContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext)base.WithObjectContext(context);
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x0005A2F2 File Offset: 0x000584F2
		public new global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext AsAsync()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext)base.AsAsync();
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x0005A2FF File Offset: 0x000584FF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0005A307 File Offset: 0x00058507
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x0005A310 File Offset: 0x00058510
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0005A318 File Offset: 0x00058518
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B76 RID: 2934
		private global::System.Data.CommandBehavior _commandBehavior;
	}
}
