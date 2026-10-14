using System;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000282 RID: 642
	public class DbConnectionInterceptionContext<TResult> : global::System.Data.Entity.Infrastructure.Interception.MutableInterceptionContext<TResult>
	{
		// Token: 0x0600205E RID: 8286 RVA: 0x0005AF60 File Offset: 0x00059160
		public DbConnectionInterceptionContext()
		{
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x0005AF68 File Offset: 0x00059168
		public DbConnectionInterceptionContext(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext copyFrom) : base(copyFrom)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(copyFrom, "copyFrom");
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x0005AF7D File Offset: 0x0005917D
		public new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<TResult> AsAsync()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<TResult>)base.AsAsync();
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x0005AF8A File Offset: 0x0005918A
		public new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<TResult> WithDbContext(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<TResult>)base.WithDbContext(context);
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x0005AFA4 File Offset: 0x000591A4
		public new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<TResult> WithObjectContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<TResult>)base.WithObjectContext(context);
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x0005AFBE File Offset: 0x000591BE
		protected override global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext Clone()
		{
			return new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext<TResult>(this);
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x0005AFC6 File Offset: 0x000591C6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x0005AFCE File Offset: 0x000591CE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x0005AFD7 File Offset: 0x000591D7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x0005AFDF File Offset: 0x000591DF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
