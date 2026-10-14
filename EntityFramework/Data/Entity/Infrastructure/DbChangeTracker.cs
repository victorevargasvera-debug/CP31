using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Internal;
using System.Linq;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200021C RID: 540
	public class DbChangeTracker
	{
		// Token: 0x06001C5C RID: 7260 RVA: 0x00050740 File Offset: 0x0004E940
		internal DbChangeTracker(global::System.Data.Entity.Internal.InternalContext internalContext)
		{
			this._internalContext = internalContext;
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x0005074F File Offset: 0x0004E94F
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Infrastructure.DbEntityEntry> Entries()
		{
			return from e in this._internalContext.GetStateEntries()
			select new global::System.Data.Entity.Infrastructure.DbEntityEntry(new global::System.Data.Entity.Internal.InternalEntityEntry(this._internalContext, e));
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x0005076D File Offset: 0x0004E96D
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity>> Entries<TEntity>() where TEntity : class
		{
			return from e in this._internalContext.GetStateEntries<TEntity>()
			select new global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity>(new global::System.Data.Entity.Internal.InternalEntityEntry(this._internalContext, e));
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x0005078B File Offset: 0x0004E98B
		public bool HasChanges()
		{
			this._internalContext.DetectChanges(false);
			return this._internalContext.ObjectContext.ObjectStateManager.HasChanges();
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x000507AE File Offset: 0x0004E9AE
		public void DetectChanges()
		{
			this._internalContext.DetectChanges(true);
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x000507BC File Offset: 0x0004E9BC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x000507C4 File Offset: 0x0004E9C4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x000507CD File Offset: 0x0004E9CD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x000507D5 File Offset: 0x0004E9D5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000AF2 RID: 2802
		private readonly global::System.Data.Entity.Internal.InternalContext _internalContext;
	}
}
