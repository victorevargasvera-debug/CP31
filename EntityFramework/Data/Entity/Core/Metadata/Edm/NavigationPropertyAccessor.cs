using System;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004E6 RID: 1254
	internal class NavigationPropertyAccessor
	{
		// Token: 0x06003E97 RID: 16023 RVA: 0x000CFA56 File Offset: 0x000CDC56
		public NavigationPropertyAccessor(string propertyName)
		{
			this._propertyName = propertyName;
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06003E98 RID: 16024 RVA: 0x000CFA65 File Offset: 0x000CDC65
		public bool HasProperty
		{
			get
			{
				return this._propertyName != null;
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06003E99 RID: 16025 RVA: 0x000CFA70 File Offset: 0x000CDC70
		public string PropertyName
		{
			get
			{
				return this._propertyName;
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06003E9A RID: 16026 RVA: 0x000CFA78 File Offset: 0x000CDC78
		// (set) Token: 0x06003E9B RID: 16027 RVA: 0x000CFA80 File Offset: 0x000CDC80
		public global::System.Func<object, object> ValueGetter
		{
			get
			{
				return this._memberGetter;
			}
			set
			{
				global::System.Threading.Interlocked.CompareExchange<global::System.Func<object, object>>(ref this._memberGetter, value, null);
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06003E9C RID: 16028 RVA: 0x000CFA90 File Offset: 0x000CDC90
		// (set) Token: 0x06003E9D RID: 16029 RVA: 0x000CFA98 File Offset: 0x000CDC98
		public global::System.Action<object, object> ValueSetter
		{
			get
			{
				return this._memberSetter;
			}
			set
			{
				global::System.Threading.Interlocked.CompareExchange<global::System.Action<object, object>>(ref this._memberSetter, value, null);
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06003E9E RID: 16030 RVA: 0x000CFAA8 File Offset: 0x000CDCA8
		// (set) Token: 0x06003E9F RID: 16031 RVA: 0x000CFAB0 File Offset: 0x000CDCB0
		public global::System.Action<object, object> CollectionAdd
		{
			get
			{
				return this._collectionAdd;
			}
			set
			{
				global::System.Threading.Interlocked.CompareExchange<global::System.Action<object, object>>(ref this._collectionAdd, value, null);
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06003EA0 RID: 16032 RVA: 0x000CFAC0 File Offset: 0x000CDCC0
		// (set) Token: 0x06003EA1 RID: 16033 RVA: 0x000CFAC8 File Offset: 0x000CDCC8
		public global::System.Func<object, object, bool> CollectionRemove
		{
			get
			{
				return this._collectionRemove;
			}
			set
			{
				global::System.Threading.Interlocked.CompareExchange<global::System.Func<object, object, bool>>(ref this._collectionRemove, value, null);
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06003EA2 RID: 16034 RVA: 0x000CFAD8 File Offset: 0x000CDCD8
		// (set) Token: 0x06003EA3 RID: 16035 RVA: 0x000CFAE0 File Offset: 0x000CDCE0
		public global::System.Func<object> CollectionCreate
		{
			get
			{
				return this._collectionCreate;
			}
			set
			{
				global::System.Threading.Interlocked.CompareExchange<global::System.Func<object>>(ref this._collectionCreate, value, null);
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06003EA4 RID: 16036 RVA: 0x000CFAF0 File Offset: 0x000CDCF0
		public static global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor NoNavigationProperty
		{
			get
			{
				return new global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor(null);
			}
		}

		// Token: 0x04001536 RID: 5430
		private global::System.Func<object, object> _memberGetter;

		// Token: 0x04001537 RID: 5431
		private global::System.Action<object, object> _memberSetter;

		// Token: 0x04001538 RID: 5432
		private global::System.Action<object, object> _collectionAdd;

		// Token: 0x04001539 RID: 5433
		private global::System.Func<object, object, bool> _collectionRemove;

		// Token: 0x0400153A RID: 5434
		private global::System.Func<object> _collectionCreate;

		// Token: 0x0400153B RID: 5435
		private readonly string _propertyName;
	}
}
