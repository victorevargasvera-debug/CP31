using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200041E RID: 1054
	public class ObjectSet<TEntity> : global::System.Data.Entity.Core.Objects.ObjectQuery<TEntity>, global::System.Data.Entity.Core.Objects.IObjectSet<TEntity>, global::System.Linq.IQueryable<TEntity>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable, global::System.Linq.IQueryable where TEntity : class
	{
		// Token: 0x060032B9 RID: 12985 RVA: 0x000A1961 File Offset: 0x0009FB61
		internal ObjectSet(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.ObjectContext context) : base(entitySet, context, global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly)
		{
			this._entitySet = entitySet;
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x060032BA RID: 12986 RVA: 0x000A1973 File Offset: 0x0009FB73
		public global::System.Data.Entity.Core.Metadata.Edm.EntitySet EntitySet
		{
			get
			{
				return this._entitySet;
			}
		}

		// Token: 0x060032BB RID: 12987 RVA: 0x000A197B File Offset: 0x0009FB7B
		public void AddObject(TEntity entity)
		{
			base.Context.AddObject(this.FullyQualifiedEntitySetName, entity);
		}

		// Token: 0x060032BC RID: 12988 RVA: 0x000A1994 File Offset: 0x0009FB94
		public void Attach(TEntity entity)
		{
			base.Context.AttachTo(this.FullyQualifiedEntitySetName, entity);
		}

		// Token: 0x060032BD RID: 12989 RVA: 0x000A19AD File Offset: 0x0009FBAD
		public void DeleteObject(TEntity entity)
		{
			base.Context.DeleteObject(entity, this.EntitySet);
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x000A19C6 File Offset: 0x0009FBC6
		public void Detach(TEntity entity)
		{
			base.Context.Detach(entity, this.EntitySet);
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x000A19DF File Offset: 0x0009FBDF
		public TEntity ApplyCurrentValues(TEntity currentEntity)
		{
			return base.Context.ApplyCurrentValues<TEntity>(this.FullyQualifiedEntitySetName, currentEntity);
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x000A19F3 File Offset: 0x0009FBF3
		public TEntity ApplyOriginalValues(TEntity originalEntity)
		{
			return base.Context.ApplyOriginalValues<TEntity>(this.FullyQualifiedEntitySetName, originalEntity);
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x000A1A07 File Offset: 0x0009FC07
		public TEntity CreateObject()
		{
			return base.Context.CreateObject<TEntity>();
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x000A1A14 File Offset: 0x0009FC14
		public T CreateObject<T>() where T : class, TEntity
		{
			return base.Context.CreateObject<T>();
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x060032C3 RID: 12995 RVA: 0x000A1A21 File Offset: 0x0009FC21
		private string FullyQualifiedEntitySetName
		{
			get
			{
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}", new object[]
				{
					this._entitySet.EntityContainer.Name,
					this._entitySet.Name
				});
			}
		}

		// Token: 0x04001090 RID: 4240
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet _entitySet;
	}
}
