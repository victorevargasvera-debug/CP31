using System;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000283 RID: 643
	public class DbConnectionPropertyInterceptionContext<TValue> : global::System.Data.Entity.Infrastructure.Interception.PropertyInterceptionContext<TValue>
	{
		// Token: 0x06002068 RID: 8296 RVA: 0x0005AFE7 File Offset: 0x000591E7
		public DbConnectionPropertyInterceptionContext()
		{
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x0005AFEF File Offset: 0x000591EF
		public DbConnectionPropertyInterceptionContext(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext copyFrom) : base(copyFrom)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(copyFrom, "copyFrom");
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x0005B004 File Offset: 0x00059204
		public new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<TValue> WithValue(TValue value)
		{
			return (global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<TValue>)base.WithValue(value);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x0005B012 File Offset: 0x00059212
		protected override global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext Clone()
		{
			return new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<TValue>(this);
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x0005B01A File Offset: 0x0005921A
		public new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<TValue> AsAsync()
		{
			return (global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<TValue>)base.AsAsync();
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x0005B027 File Offset: 0x00059227
		public new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<TValue> WithDbContext(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<TValue>)base.WithDbContext(context);
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x0005B041 File Offset: 0x00059241
		public new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<TValue> WithObjectContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			return (global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<TValue>)base.WithObjectContext(context);
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x0005B05B File Offset: 0x0005925B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x0005B063 File Offset: 0x00059263
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x0005B06C File Offset: 0x0005926C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x0005B074 File Offset: 0x00059274
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
