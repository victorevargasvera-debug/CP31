using System;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004A9 RID: 1193
	public abstract class EdmMember : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem, global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem
	{
		// Token: 0x06003AB3 RID: 15027 RVA: 0x000C0EF8 File Offset: 0x000BF0F8
		internal EdmMember()
		{
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x000C0F00 File Offset: 0x000BF100
		internal EdmMember(string name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage memberTypeUsage)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(memberTypeUsage, "memberTypeUsage");
			this._name = name;
			this._typeUsage = memberTypeUsage;
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06003AB5 RID: 15029 RVA: 0x000C0F2E File Offset: 0x000BF12E
		string global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem.Identity
		{
			get
			{
				return this.Identity;
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06003AB6 RID: 15030 RVA: 0x000C0F36 File Offset: 0x000BF136
		internal override string Identity
		{
			get
			{
				return this._identity ?? this.Name;
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06003AB7 RID: 15031 RVA: 0x000C0F48 File Offset: 0x000BF148
		// (set) Token: 0x06003AB8 RID: 15032 RVA: 0x000C0F50 File Offset: 0x000BF150
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
					if (this._declaringType != null)
					{
						if (this._declaringType.Members.Except(new global::System.Data.Entity.Core.Metadata.Edm.EdmMember[]
						{
							this
						}).Any((global::System.Data.Entity.Core.Metadata.Edm.EdmMember c) => string.Equals(this.Identity, c.Identity, global::System.StringComparison.Ordinal)))
						{
							this._identity = (from i in this._declaringType.Members
							select i.Identity).Uniquify(this.Identity);
						}
						this._declaringType.NotifyItemIdentityChanged(this, identity);
					}
				}
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06003AB9 RID: 15033 RVA: 0x000C1011 File Offset: 0x000BF211
		public virtual global::System.Data.Entity.Core.Metadata.Edm.StructuralType DeclaringType
		{
			get
			{
				return this._declaringType;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06003ABA RID: 15034 RVA: 0x000C1019 File Offset: 0x000BF219
		// (set) Token: 0x06003ABB RID: 15035 RVA: 0x000C1021 File Offset: 0x000BF221
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.TypeUsage, false)]
		public virtual global::System.Data.Entity.Core.Metadata.Edm.TypeUsage TypeUsage
		{
			get
			{
				return this._typeUsage;
			}
			protected set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(value, "value");
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._typeUsage = value;
			}
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x000C103C File Offset: 0x000BF23C
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x000C1044 File Offset: 0x000BF244
		internal override void SetReadOnly()
		{
			if (!base.IsReadOnly)
			{
				base.SetReadOnly();
				string identity = this._identity;
				this._identity = this.Name;
				if (this._declaringType != null && identity != null && !string.Equals(identity, this._identity, global::System.StringComparison.Ordinal))
				{
					this._declaringType.NotifyItemIdentityChanged(this, identity);
				}
			}
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x000C1099 File Offset: 0x000BF299
		internal void ChangeDeclaringTypeWithoutCollectionFixup(global::System.Data.Entity.Core.Metadata.Edm.StructuralType newDeclaringType)
		{
			this._declaringType = newDeclaringType;
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06003ABF RID: 15039 RVA: 0x000C10A4 File Offset: 0x000BF2A4
		public bool IsStoreGeneratedComputed
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				return this.TypeUsage.Facets.TryGetValue("StoreGeneratedPattern", false, out facet) && (global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern)facet.Value == global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Computed;
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06003AC0 RID: 15040 RVA: 0x000C10DC File Offset: 0x000BF2DC
		public bool IsStoreGeneratedIdentity
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				return this.TypeUsage.Facets.TryGetValue("StoreGeneratedPattern", false, out facet) && (global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern)facet.Value == global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Identity;
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06003AC1 RID: 15041 RVA: 0x000C1114 File Offset: 0x000BF314
		internal virtual bool IsPrimaryKeyColumn
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityTypeBase = this._declaringType as global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase;
				return entityTypeBase != null && entityTypeBase.KeyMembers.Contains(this);
			}
		}

		// Token: 0x0400142D RID: 5165
		private global::System.Data.Entity.Core.Metadata.Edm.StructuralType _declaringType;

		// Token: 0x0400142E RID: 5166
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _typeUsage;

		// Token: 0x0400142F RID: 5167
		private string _name;

		// Token: 0x04001430 RID: 5168
		private string _identity;
	}
}
