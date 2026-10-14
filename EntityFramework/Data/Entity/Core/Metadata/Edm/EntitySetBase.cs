using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004BA RID: 1210
	public abstract class EntitySetBase : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem, global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem
	{
		// Token: 0x06003BE9 RID: 15337 RVA: 0x000C5E79 File Offset: 0x000C4079
		internal EntitySetBase()
		{
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x000C5E84 File Offset: 0x000C4084
		internal EntitySetBase(string name, string schema, string table, string definingQuery, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase>(entityType, "entityType");
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this._name = name;
			this._schema = schema;
			this._table = table;
			this._definingQuery = definingQuery;
			this.ElementType = entityType;
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06003BEB RID: 15339 RVA: 0x000C5ED5 File Offset: 0x000C40D5
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySetBase;
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06003BEC RID: 15340 RVA: 0x000C5ED8 File Offset: 0x000C40D8
		string global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem.Identity
		{
			get
			{
				return this.Identity;
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06003BED RID: 15341 RVA: 0x000C5EE0 File Offset: 0x000C40E0
		internal override string Identity
		{
			get
			{
				return this.Name;
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06003BEE RID: 15342 RVA: 0x000C5EE8 File Offset: 0x000C40E8
		// (set) Token: 0x06003BEF RID: 15343 RVA: 0x000C5EF0 File Offset: 0x000C40F0
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, false)]
		public string DefiningQuery
		{
			get
			{
				return this._definingQuery;
			}
			internal set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._definingQuery = value;
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06003BF0 RID: 15344 RVA: 0x000C5F0B File Offset: 0x000C410B
		// (set) Token: 0x06003BF1 RID: 15345 RVA: 0x000C5F14 File Offset: 0x000C4114
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, false)]
		public virtual string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				if (!string.Equals(this._name, value, global::System.StringComparison.Ordinal))
				{
					string identity = this.Identity;
					this._name = value;
					if (this._entityContainer != null)
					{
						this._entityContainer.NotifyItemIdentityChanged(this, identity);
					}
				}
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06003BF2 RID: 15346 RVA: 0x000C5F65 File Offset: 0x000C4165
		public virtual global::System.Data.Entity.Core.Metadata.Edm.EntityContainer EntityContainer
		{
			get
			{
				return this._entityContainer;
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06003BF3 RID: 15347 RVA: 0x000C5F6D File Offset: 0x000C416D
		// (set) Token: 0x06003BF4 RID: 15348 RVA: 0x000C5F75 File Offset: 0x000C4175
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityTypeBase, false)]
		public global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase ElementType
		{
			get
			{
				return this._elementType;
			}
			internal set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase>(value, "value");
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._elementType = value;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06003BF5 RID: 15349 RVA: 0x000C5F90 File Offset: 0x000C4190
		// (set) Token: 0x06003BF6 RID: 15350 RVA: 0x000C5F98 File Offset: 0x000C4198
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, false)]
		public string Table
		{
			get
			{
				return this._table;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._table = value;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06003BF7 RID: 15351 RVA: 0x000C5FA7 File Offset: 0x000C41A7
		// (set) Token: 0x06003BF8 RID: 15352 RVA: 0x000C5FAF File Offset: 0x000C41AF
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, false)]
		public string Schema
		{
			get
			{
				return this._schema;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._schema = value;
			}
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x000C5FBE File Offset: 0x000C41BE
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x000C5FC8 File Offset: 0x000C41C8
		internal override void SetReadOnly()
		{
			if (!base.IsReadOnly)
			{
				base.SetReadOnly();
				global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase elementType = this.ElementType;
				if (elementType != null)
				{
					elementType.SetReadOnly();
				}
			}
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x000C5FF3 File Offset: 0x000C41F3
		internal void ChangeEntityContainerWithoutCollectionFixup(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer newEntityContainer)
		{
			this._entityContainer = newEntityContainer;
		}

		// Token: 0x040014A1 RID: 5281
		private global::System.Data.Entity.Core.Metadata.Edm.EntityContainer _entityContainer;

		// Token: 0x040014A2 RID: 5282
		private string _name;

		// Token: 0x040014A3 RID: 5283
		private global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase _elementType;

		// Token: 0x040014A4 RID: 5284
		private string _table;

		// Token: 0x040014A5 RID: 5285
		private string _schema;

		// Token: 0x040014A6 RID: 5286
		private string _definingQuery;
	}
}
