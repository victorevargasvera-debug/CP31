using System;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000281 RID: 641
	public class DbConnectionInterceptionContext : global::System.Data.Entity.Infrastructure.Interception.MutableInterceptionContext
	{
		// Token: 0x06002054 RID: 8276 RVA: 0x0005AED9 File Offset: 0x000590D9
		public DbConnectionInterceptionContext()
		{
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x0005AEE1 File Offset: 0x000590E1
		public DbConnectionInterceptionContext(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext copyFrom) : base(copyFrom)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(copyFrom, "copyFrom");
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x0005AEF6 File Offset: 0x000590F6
		public new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext AsAsync()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext)base.AsAsync();
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x0005AF03 File Offset: 0x00059103
		public new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext WithDbContext(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext)base.WithDbContext(context);
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x0005AF1D File Offset: 0x0005911D
		public new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext WithObjectContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext)base.WithObjectContext(context);
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x0005AF37 File Offset: 0x00059137
		protected override global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext Clone()
		{
			return new global::System.Data.Entity.Infrastructure.Interception.DbConnectionInterceptionContext(this);
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x0005AF3F File Offset: 0x0005913F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x0005AF47 File Offset: 0x00059147
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x0005AF50 File Offset: 0x00059150
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x0005AF58 File Offset: 0x00059158
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
