using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004F0 RID: 1264
	public sealed class ReferentialConstraint : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem
	{
		// Token: 0x06003EE7 RID: 16103 RVA: 0x000D0630 File Offset: 0x000CE830
		public ReferentialConstraint(global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember fromRole, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember toRole, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> fromProperties, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> toProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember>(fromRole, "fromRole");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember>(toRole, "toRole");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>(fromProperties, "fromProperties");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>(toProperties, "toProperties");
			this._fromRole = fromRole;
			this._toRole = toRole;
			this._fromProperties = new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(new global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(fromProperties));
			this._toProperties = new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(new global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(toProperties));
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06003EE8 RID: 16104 RVA: 0x000D06A5 File Offset: 0x000CE8A5
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ReferentialConstraint;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06003EE9 RID: 16105 RVA: 0x000D06A9 File Offset: 0x000CE8A9
		internal override string Identity
		{
			get
			{
				return this.FromRole.Name + "_" + this.ToRole.Name;
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06003EEA RID: 16106 RVA: 0x000D06CB File Offset: 0x000CE8CB
		// (set) Token: 0x06003EEB RID: 16107 RVA: 0x000D06D3 File Offset: 0x000CE8D3
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipEndMember, false)]
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember FromRole
		{
			get
			{
				return this._fromRole;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._fromRole = value;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06003EEC RID: 16108 RVA: 0x000D06E2 File Offset: 0x000CE8E2
		// (set) Token: 0x06003EED RID: 16109 RVA: 0x000D06EA File Offset: 0x000CE8EA
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipEndMember, false)]
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember ToRole
		{
			get
			{
				return this._toRole;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._toRole = value;
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06003EEE RID: 16110 RVA: 0x000D06F9 File Offset: 0x000CE8F9
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember PrincipalEnd
		{
			get
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)this.FromRole;
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06003EEF RID: 16111 RVA: 0x000D0706 File Offset: 0x000CE906
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember DependentEnd
		{
			get
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)this.ToRole;
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06003EF0 RID: 16112 RVA: 0x000D0713 File Offset: 0x000CE913
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmProperty, true)]
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> FromProperties
		{
			get
			{
				if (!base.IsReadOnly && this._fromProperties.Count == 0)
				{
					this._fromRole.GetEntityType().KeyMembers.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmMember p)
					{
						this._fromProperties.Source.Add((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)p);
					});
				}
				return this._fromProperties;
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06003EF1 RID: 16113 RVA: 0x000D0751 File Offset: 0x000CE951
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmProperty, true)]
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> ToProperties
		{
			get
			{
				return this._toProperties;
			}
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x000D0759 File Offset: 0x000CE959
		public override string ToString()
		{
			return this.FromRole.Name + "_" + this.ToRole.Name;
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x000D077C File Offset: 0x000CE97C
		internal override void SetReadOnly()
		{
			if (!base.IsReadOnly)
			{
				this.FromProperties.Source.SetReadOnly();
				this.ToProperties.Source.SetReadOnly();
				base.SetReadOnly();
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember fromRole = this.FromRole;
				if (fromRole != null)
				{
					fromRole.SetReadOnly();
				}
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember toRole = this.ToRole;
				if (toRole != null)
				{
					toRole.SetReadOnly();
				}
			}
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x000D07DC File Offset: 0x000CE9DC
		internal string BuildConstraintExceptionMessage()
		{
			string name = this.FromProperties.First<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>().DeclaringType.Name;
			string name2 = this.ToProperties.First<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>().DeclaringType.Name;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
			for (int i = 0; i < this.FromProperties.Count; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(", ");
					stringBuilder2.Append(", ");
				}
				stringBuilder.Append(name).Append('.').Append(this.FromProperties[i]);
				stringBuilder2.Append(name2).Append('.').Append(this.ToProperties[i]);
			}
			return global::System.Data.Entity.Resources.Strings.RelationshipManager_InconsistentReferentialConstraintProperties(stringBuilder.ToString(), stringBuilder2.ToString());
		}

		// Token: 0x04001577 RID: 5495
		private global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember _fromRole;

		// Token: 0x04001578 RID: 5496
		private global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember _toRole;

		// Token: 0x04001579 RID: 5497
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> _fromProperties;

		// Token: 0x0400157A RID: 5498
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> _toProperties;
	}
}
