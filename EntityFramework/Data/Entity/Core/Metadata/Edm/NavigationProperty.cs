using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004E5 RID: 1253
	public sealed class NavigationProperty : global::System.Data.Entity.Core.Metadata.Edm.EdmMember
	{
		// Token: 0x06003E89 RID: 16009 RVA: 0x000CF867 File Offset: 0x000CDA67
		internal NavigationProperty(string name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage) : base(name, typeUsage)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(typeUsage, "typeUsage");
			this._accessor = new global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor(name);
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06003E8A RID: 16010 RVA: 0x000CF895 File Offset: 0x000CDA95
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.NavigationProperty;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06003E8B RID: 16011 RVA: 0x000CF899 File Offset: 0x000CDA99
		// (set) Token: 0x06003E8C RID: 16012 RVA: 0x000CF8A1 File Offset: 0x000CDAA1
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipType, false)]
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipType RelationshipType { get; internal set; }

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06003E8D RID: 16013 RVA: 0x000CF8AA File Offset: 0x000CDAAA
		// (set) Token: 0x06003E8E RID: 16014 RVA: 0x000CF8B2 File Offset: 0x000CDAB2
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipEndMember, false)]
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember ToEndMember { get; internal set; }

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06003E8F RID: 16015 RVA: 0x000CF8BB File Offset: 0x000CDABB
		// (set) Token: 0x06003E90 RID: 16016 RVA: 0x000CF8C3 File Offset: 0x000CDAC3
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipEndMember, false)]
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember FromEndMember { get; internal set; }

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06003E91 RID: 16017 RVA: 0x000CF8CC File Offset: 0x000CDACC
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationType Association
		{
			get
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.AssociationType)this.RelationshipType;
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06003E92 RID: 16018 RVA: 0x000CF8D9 File Offset: 0x000CDAD9
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember ResultEnd
		{
			get
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)this.ToEndMember;
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06003E93 RID: 16019 RVA: 0x000CF8E6 File Offset: 0x000CDAE6
		internal global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor Accessor
		{
			get
			{
				return this._accessor;
			}
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x000CF8F0 File Offset: 0x000CDAF0
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> GetDependentProperties()
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = (global::System.Data.Entity.Core.Metadata.Edm.AssociationType)this.RelationshipType;
			if (associationType.ReferentialConstraints.Count > 0)
			{
				global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = associationType.ReferentialConstraints[0];
				if (referentialConstraint.ToRole.EdmEquals(this.FromEndMember))
				{
					global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> keyMembers = referentialConstraint.FromRole.GetEntityType().KeyMembers;
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(keyMembers.Count);
					for (int i = 0; i < keyMembers.Count; i++)
					{
						list.Add(referentialConstraint.ToProperties[referentialConstraint.FromProperties.IndexOf((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)keyMembers[i])]);
					}
					return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(list);
				}
			}
			return global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x000CF9A4 File Offset: 0x000CDBA4
		internal override void SetReadOnly()
		{
			if (!base.IsReadOnly && this.ToEndMember != null && this.ToEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One)
			{
				this.TypeUsage = this.TypeUsage.ShallowCopy(new global::System.Data.Entity.Core.Metadata.Edm.Facet[]
				{
					global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.NullableFacetDescription, false)
				});
			}
			base.SetReadOnly();
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x000CFA00 File Offset: 0x000CDC00
		public static global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty Create(string name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage, global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relationshipType, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember from, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember to, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(typeUsage, "typeUsage");
			global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = new global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty(name, typeUsage);
			navigationProperty.RelationshipType = relationshipType;
			navigationProperty.FromEndMember = from;
			navigationProperty.ToEndMember = to;
			if (metadataProperties != null)
			{
				navigationProperty.AddMetadataProperties(metadataProperties);
			}
			navigationProperty.SetReadOnly();
			return navigationProperty;
		}

		// Token: 0x04001530 RID: 5424
		internal const string RelationshipTypeNamePropertyName = "RelationshipType";

		// Token: 0x04001531 RID: 5425
		internal const string ToEndMemberNamePropertyName = "ToEndMember";

		// Token: 0x04001532 RID: 5426
		private readonly global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor _accessor;
	}
}
