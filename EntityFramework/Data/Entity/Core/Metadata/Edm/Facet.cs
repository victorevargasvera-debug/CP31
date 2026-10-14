using System;
using System.Data.Entity.Utilities;
using System.Diagnostics;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004C1 RID: 1217
	[global::System.Diagnostics.DebuggerDisplay("{Name,nq}={Value}")]
	public class Facet : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem
	{
		// Token: 0x06003C3F RID: 15423 RVA: 0x000C6B83 File Offset: 0x000C4D83
		internal Facet()
		{
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x000C6B8B File Offset: 0x000C4D8B
		private Facet(global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facetDescription, object value) : base(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.Readonly)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(facetDescription, "facetDescription");
			this._facetDescription = facetDescription;
			this._value = value;
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x000C6BAE File Offset: 0x000C4DAE
		internal static global::System.Data.Entity.Core.Metadata.Edm.Facet Create(global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facetDescription, object value)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(facetDescription, value, false);
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x000C6BB8 File Offset: 0x000C4DB8
		internal static global::System.Data.Entity.Core.Metadata.Edm.Facet Create(global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facetDescription, object value, bool bypassKnownValues)
		{
			if (!bypassKnownValues)
			{
				if (value == null)
				{
					return facetDescription.NullValueFacet;
				}
				if (object.Equals(facetDescription.DefaultValue, value))
				{
					return facetDescription.DefaultValueFacet;
				}
				if (facetDescription.FacetType.Identity == "Edm.Boolean")
				{
					bool value2 = (bool)value;
					return facetDescription.GetBooleanFacet(value2);
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet = new global::System.Data.Entity.Core.Metadata.Edm.Facet(facetDescription, value);
			if (value != null && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsUnboundedFacetValue(facet) && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsVariableFacetValue(facet) && facet.FacetType.ClrType != null)
			{
				value.GetType();
			}
			return facet;
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06003C43 RID: 15427 RVA: 0x000C6C43 File Offset: 0x000C4E43
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.Facet;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06003C44 RID: 15428 RVA: 0x000C6C47 File Offset: 0x000C4E47
		public global::System.Data.Entity.Core.Metadata.Edm.FacetDescription Description
		{
			get
			{
				return this._facetDescription;
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06003C45 RID: 15429 RVA: 0x000C6C4F File Offset: 0x000C4E4F
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, false)]
		public virtual string Name
		{
			get
			{
				return this._facetDescription.FacetName;
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06003C46 RID: 15430 RVA: 0x000C6C5C File Offset: 0x000C4E5C
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmType, false)]
		public global::System.Data.Entity.Core.Metadata.Edm.EdmType FacetType
		{
			get
			{
				return this._facetDescription.FacetType;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06003C47 RID: 15431 RVA: 0x000C6C69 File Offset: 0x000C4E69
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(typeof(object), false)]
		public virtual object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06003C48 RID: 15432 RVA: 0x000C6C71 File Offset: 0x000C4E71
		internal override string Identity
		{
			get
			{
				return this._facetDescription.FacetName;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06003C49 RID: 15433 RVA: 0x000C6C7E File Offset: 0x000C4E7E
		public bool IsUnbounded
		{
			get
			{
				return this.Value == global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.UnboundedValue;
			}
		}

		// Token: 0x06003C4A RID: 15434 RVA: 0x000C6C8D File Offset: 0x000C4E8D
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x040014B7 RID: 5303
		private readonly global::System.Data.Entity.Core.Metadata.Edm.FacetDescription _facetDescription;

		// Token: 0x040014B8 RID: 5304
		private readonly object _value;
	}
}
