using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000286 RID: 646
	public class DbInterceptionContext
	{
		// Token: 0x06002085 RID: 8325 RVA: 0x0005B2A1 File Offset: 0x000594A1
		public DbInterceptionContext()
		{
			this._dbContexts = new global::System.Collections.Generic.List<global::System.Data.Entity.DbContext>();
			this._objectContexts = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.ObjectContext>();
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x0005B2C0 File Offset: 0x000594C0
		protected DbInterceptionContext(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext copyFrom)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext>(copyFrom, "copyFrom");
			this._dbContexts = (from c in copyFrom.DbContexts
			where c.InternalContext == null || !c.InternalContext.IsDisposed
			select c).ToList<global::System.Data.Entity.DbContext>();
			this._objectContexts = (from c in copyFrom.ObjectContexts
			where !c.IsDisposed
			select c).ToList<global::System.Data.Entity.Core.Objects.ObjectContext>();
			this._isAsync = copyFrom._isAsync;
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x0005B358 File Offset: 0x00059558
		private DbInterceptionContext(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext> copyFrom)
		{
			this._dbContexts = (from c in copyFrom.SelectMany((global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext c) => c.DbContexts).Distinct<global::System.Data.Entity.DbContext>()
			where !c.InternalContext.IsDisposed
			select c).ToList<global::System.Data.Entity.DbContext>();
			this._objectContexts = (from c in copyFrom.SelectMany((global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext c) => c.ObjectContexts).Distinct<global::System.Data.Entity.Core.Objects.ObjectContext>()
			where !c.IsDisposed
			select c).ToList<global::System.Data.Entity.Core.Objects.ObjectContext>();
			this._isAsync = copyFrom.Any((global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext c) => c.IsAsync);
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x0005B448 File Offset: 0x00059648
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.DbContext> DbContexts
		{
			get
			{
				return this._dbContexts;
			}
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x0005B450 File Offset: 0x00059650
		public global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext WithDbContext(global::System.Data.Entity.DbContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext dbInterceptionContext = this.Clone();
			if (!dbInterceptionContext._dbContexts.Contains(context, global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer.Default))
			{
				dbInterceptionContext._dbContexts.Add(context);
			}
			return dbInterceptionContext;
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x0005B490 File Offset: 0x00059690
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ObjectContext> ObjectContexts
		{
			get
			{
				return this._objectContexts;
			}
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x0005B498 File Offset: 0x00059698
		public global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext WithObjectContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(context, "context");
			global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext dbInterceptionContext = this.Clone();
			if (!dbInterceptionContext._objectContexts.Contains(context, global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer.Default))
			{
				dbInterceptionContext._objectContexts.Add(context);
			}
			return dbInterceptionContext;
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600208C RID: 8332 RVA: 0x0005B4D8 File Offset: 0x000596D8
		public bool IsAsync
		{
			get
			{
				return this._isAsync;
			}
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x0005B4E0 File Offset: 0x000596E0
		public global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext AsAsync()
		{
			global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext dbInterceptionContext = this.Clone();
			dbInterceptionContext._isAsync = true;
			return dbInterceptionContext;
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x0005B4EF File Offset: 0x000596EF
		protected virtual global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext Clone()
		{
			return new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext(this);
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x0005B4F7 File Offset: 0x000596F7
		internal static global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext Combine(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext> interceptionContexts)
		{
			return new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext(interceptionContexts);
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x0005B4FF File Offset: 0x000596FF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x0005B507 File Offset: 0x00059707
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x0005B510 File Offset: 0x00059710
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x0005B518 File Offset: 0x00059718
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B84 RID: 2948
		private readonly global::System.Collections.Generic.IList<global::System.Data.Entity.DbContext> _dbContexts;

		// Token: 0x04000B85 RID: 2949
		private readonly global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Objects.ObjectContext> _objectContexts;

		// Token: 0x04000B86 RID: 2950
		private bool _isAsync;
	}
}
