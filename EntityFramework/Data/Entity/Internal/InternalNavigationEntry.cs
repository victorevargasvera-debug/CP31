using System;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Resources;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000108 RID: 264
	internal abstract class InternalNavigationEntry : global::System.Data.Entity.Internal.InternalMemberEntry
	{
		// Token: 0x060012DB RID: 4827 RVA: 0x000308F9 File Offset: 0x0002EAF9
		protected InternalNavigationEntry(global::System.Data.Entity.Internal.InternalEntityEntry internalEntityEntry, global::System.Data.Entity.Internal.NavigationEntryMetadata navigationMetadata) : base(internalEntityEntry, navigationMetadata)
		{
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00030903 File Offset: 0x0002EB03
		public virtual void Load()
		{
			this.ValidateNotDetached("Load");
			this._relatedEnd.Load();
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0003091B File Offset: 0x0002EB1B
		public virtual global::System.Threading.Tasks.Task LoadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			this.ValidateNotDetached("LoadAsync");
			return this._relatedEnd.LoadAsync(cancellationToken);
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x00030934 File Offset: 0x0002EB34
		// (set) Token: 0x060012DF RID: 4831 RVA: 0x0003094C File Offset: 0x0002EB4C
		public virtual bool IsLoaded
		{
			get
			{
				this.ValidateNotDetached("IsLoaded");
				return this._relatedEnd.IsLoaded;
			}
			set
			{
				this.ValidateNotDetached("IsLoaded");
				this._relatedEnd.IsLoaded = value;
			}
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00030965 File Offset: 0x0002EB65
		public virtual global::System.Linq.IQueryable Query()
		{
			this.ValidateNotDetached("Query");
			return (global::System.Linq.IQueryable)this._relatedEnd.CreateSourceQuery();
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x00030982 File Offset: 0x0002EB82
		protected global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd RelatedEnd
		{
			get
			{
				if (this._relatedEnd == null && !this.InternalEntityEntry.IsDetached)
				{
					this._relatedEnd = this.InternalEntityEntry.GetRelatedEnd(this.Name);
				}
				return this._relatedEnd;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x000309B6 File Offset: 0x0002EBB6
		public override object CurrentValue
		{
			get
			{
				if (this.Getter == null)
				{
					this.ValidateNotDetached("CurrentValue");
					return this.GetNavigationPropertyFromRelatedEnd(this.InternalEntityEntry.Entity);
				}
				return this.Getter(this.InternalEntityEntry.Entity);
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x000309F3 File Offset: 0x0002EBF3
		protected global::System.Func<object, object> Getter
		{
			get
			{
				if (!this._triedToGetGetter)
				{
					global::System.Data.Entity.Internal.DbHelpers.GetPropertyGetters(this.InternalEntityEntry.EntityType).TryGetValue(this.Name, out this._getter);
					this._triedToGetGetter = true;
				}
				return this._getter;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x00030A2C File Offset: 0x0002EC2C
		protected global::System.Action<object, object> Setter
		{
			get
			{
				if (!this._triedToGetSetter)
				{
					global::System.Data.Entity.Internal.DbHelpers.GetPropertySetters(this.InternalEntityEntry.EntityType).TryGetValue(this.Name, out this._setter);
					this._triedToGetSetter = true;
				}
				return this._setter;
			}
		}

		// Token: 0x060012E5 RID: 4837
		protected abstract object GetNavigationPropertyFromRelatedEnd(object entity);

		// Token: 0x060012E6 RID: 4838 RVA: 0x00030A68 File Offset: 0x0002EC68
		private void ValidateNotDetached(string method)
		{
			if (this._relatedEnd == null)
			{
				if (this.InternalEntityEntry.IsDetached)
				{
					throw global::System.Data.Entity.Resources.Error.DbPropertyEntry_NotSupportedForDetached(method, this.Name, this.InternalEntityEntry.EntityType.Name);
				}
				this._relatedEnd = this.InternalEntityEntry.GetRelatedEnd(this.Name);
			}
		}

		// Token: 0x04000933 RID: 2355
		private global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd _relatedEnd;

		// Token: 0x04000934 RID: 2356
		private global::System.Func<object, object> _getter;

		// Token: 0x04000935 RID: 2357
		private bool _triedToGetGetter;

		// Token: 0x04000936 RID: 2358
		private global::System.Action<object, object> _setter;

		// Token: 0x04000937 RID: 2359
		private bool _triedToGetSetter;
	}
}
