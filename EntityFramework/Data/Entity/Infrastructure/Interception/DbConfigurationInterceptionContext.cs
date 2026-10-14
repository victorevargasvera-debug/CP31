using System;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x0200027F RID: 639
	public class DbConfigurationInterceptionContext : global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext
	{
		// Token: 0x06002037 RID: 8247 RVA: 0x0005A688 File Offset: 0x00058888
		public DbConfigurationInterceptionContext()
		{
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x0005A690 File Offset: 0x00058890
		public DbConfigurationInterceptionContext(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext copyFrom) : base(copyFrom)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(copyFrom, "copyFrom");
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x0005A6A5 File Offset: 0x000588A5
		protected override global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext Clone()
		{
			return new global::System.Data.Entity.Infrastructure.Interception.DbConfigurationInterceptionContext(this);
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x0005A6AD File Offset: 0x000588AD
		public new global::System.Data.Entity.Infrastructure.Interception.DbConfigurationInterceptionContext WithDbContext(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbConfigurationInterceptionContext)base.WithDbContext(context);
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x0005A6C7 File Offset: 0x000588C7
		public new global::System.Data.Entity.Infrastructure.Interception.DbConfigurationInterceptionContext WithObjectContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbConfigurationInterceptionContext)base.WithObjectContext(context);
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x0005A6E1 File Offset: 0x000588E1
		public new global::System.Data.Entity.Infrastructure.Interception.DbConfigurationInterceptionContext AsAsync()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.DbConfigurationInterceptionContext)base.AsAsync();
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x0005A6EE File Offset: 0x000588EE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0005A6F6 File Offset: 0x000588F6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x0005A6FF File Offset: 0x000588FF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x0005A707 File Offset: 0x00058907
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
