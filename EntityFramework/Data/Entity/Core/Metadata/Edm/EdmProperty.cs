using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Reflection;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004B1 RID: 1201
	public class EdmProperty : global::System.Data.Entity.Core.Metadata.Edm.EdmMember
	{
		// Token: 0x06003B07 RID: 15111 RVA: 0x000C22D0 File Offset: 0x000C04D0
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty CreatePrimitive(string name, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(primitiveType, "primitiveType");
			return global::System.Data.Entity.Core.Metadata.Edm.EdmProperty.CreateProperty(name, primitiveType);
		}

		// Token: 0x06003B08 RID: 15112 RVA: 0x000C22F1 File Offset: 0x000C04F1
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty CreateEnum(string name, global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EnumType>(enumType, "enumType");
			return global::System.Data.Entity.Core.Metadata.Edm.EdmProperty.CreateProperty(name, enumType);
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x000C2312 File Offset: 0x000C0512
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty CreateComplex(string name, global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(complexType, "complexType");
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = global::System.Data.Entity.Core.Metadata.Edm.EdmProperty.CreateProperty(name, complexType);
			edmProperty.Nullable = false;
			return edmProperty;
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x000C233C File Offset: 0x000C053C
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty Create(string name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(typeUsage, "typeUsage");
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = typeUsage.EdmType;
			if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(edmType) && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(edmType) && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(edmType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EdmProperty_InvalidPropertyType(edmType.FullName));
			}
			return new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(name, typeUsage);
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x000C2398 File Offset: 0x000C0598
		private static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty CreateProperty(string name, global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues());
			return new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(name, typeUsage);
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x000C23B8 File Offset: 0x000C05B8
		internal EdmProperty(string name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage) : base(name, typeUsage)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(typeUsage, "typeUsage");
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x000C23DA File Offset: 0x000C05DA
		internal EdmProperty(string name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage, global::System.Reflection.PropertyInfo propertyInfo, global::System.Type entityDeclaringType) : this(name, typeUsage)
		{
			this._propertyInfo = propertyInfo;
			this._entityDeclaringType = entityDeclaringType;
		}

		// Token: 0x06003B0E RID: 15118 RVA: 0x000C23F3 File Offset: 0x000C05F3
		internal EdmProperty(string name) : this(name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String)))
		{
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06003B0F RID: 15119 RVA: 0x000C2408 File Offset: 0x000C0608
		internal global::System.Reflection.PropertyInfo PropertyInfo
		{
			get
			{
				return this._propertyInfo;
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06003B10 RID: 15120 RVA: 0x000C2410 File Offset: 0x000C0610
		internal global::System.Type EntityDeclaringType
		{
			get
			{
				return this._entityDeclaringType;
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06003B11 RID: 15121 RVA: 0x000C2418 File Offset: 0x000C0618
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmProperty;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06003B12 RID: 15122 RVA: 0x000C241C File Offset: 0x000C061C
		// (set) Token: 0x06003B13 RID: 15123 RVA: 0x000C243D File Offset: 0x000C063D
		public bool Nullable
		{
			get
			{
				return (bool)this.TypeUsage.Facets["Nullable"].Value;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this.TypeUsage = this.TypeUsage.ShallowCopy(new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
				{
					Nullable = new bool?(value)
				});
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06003B14 RID: 15124 RVA: 0x000C246C File Offset: 0x000C066C
		public string TypeName
		{
			get
			{
				return this.TypeUsage.EdmType.Name;
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06003B15 RID: 15125 RVA: 0x000C247E File Offset: 0x000C067E
		// (set) Token: 0x06003B16 RID: 15126 RVA: 0x000C249A File Offset: 0x000C069A
		public object DefaultValue
		{
			get
			{
				return this.TypeUsage.Facets["DefaultValue"].Value;
			}
			internal set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this.TypeUsage = this.TypeUsage.ShallowCopy(new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
				{
					DefaultValue = value
				});
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06003B17 RID: 15127 RVA: 0x000C24BF File Offset: 0x000C06BF
		// (set) Token: 0x06003B18 RID: 15128 RVA: 0x000C24C7 File Offset: 0x000C06C7
		internal global::System.Func<object, object> ValueGetter
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

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06003B19 RID: 15129 RVA: 0x000C24D7 File Offset: 0x000C06D7
		// (set) Token: 0x06003B1A RID: 15130 RVA: 0x000C24DF File Offset: 0x000C06DF
		internal global::System.Action<object, object> ValueSetter
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

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06003B1B RID: 15131 RVA: 0x000C24F0 File Offset: 0x000C06F0
		internal bool IsKeyMember
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = this.DeclaringType as global::System.Data.Entity.Core.Metadata.Edm.EntityType;
				return entityType != null && entityType.KeyMembers.Contains(this);
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06003B1C RID: 15132 RVA: 0x000C251A File Offset: 0x000C071A
		public bool IsCollectionType
		{
			get
			{
				return this.TypeUsage.EdmType is global::System.Data.Entity.Core.Metadata.Edm.CollectionType;
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06003B1D RID: 15133 RVA: 0x000C252F File Offset: 0x000C072F
		public bool IsComplexType
		{
			get
			{
				return this.TypeUsage.EdmType is global::System.Data.Entity.Core.Metadata.Edm.ComplexType;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06003B1E RID: 15134 RVA: 0x000C2544 File Offset: 0x000C0744
		public bool IsPrimitiveType
		{
			get
			{
				return this.TypeUsage.EdmType is global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType;
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06003B1F RID: 15135 RVA: 0x000C2559 File Offset: 0x000C0759
		public bool IsEnumType
		{
			get
			{
				return this.TypeUsage.EdmType is global::System.Data.Entity.Core.Metadata.Edm.EnumType;
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06003B20 RID: 15136 RVA: 0x000C256E File Offset: 0x000C076E
		public bool IsUnderlyingPrimitiveType
		{
			get
			{
				return this.IsPrimitiveType || this.IsEnumType;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06003B21 RID: 15137 RVA: 0x000C2580 File Offset: 0x000C0780
		public global::System.Data.Entity.Core.Metadata.Edm.ComplexType ComplexType
		{
			get
			{
				return this.TypeUsage.EdmType as global::System.Data.Entity.Core.Metadata.Edm.ComplexType;
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06003B22 RID: 15138 RVA: 0x000C2592 File Offset: 0x000C0792
		// (set) Token: 0x06003B23 RID: 15139 RVA: 0x000C25A4 File Offset: 0x000C07A4
		public global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType PrimitiveType
		{
			get
			{
				return this.TypeUsage.EdmType as global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType;
			}
			internal set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(value, "value");
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern storeGeneratedPattern = this.StoreGeneratedPattern;
				global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode concurrencyMode = this.ConcurrencyMode;
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.Facet> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.Facet>();
				foreach (global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facetDescription in value.GetAssociatedFacetDescriptions())
				{
					global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
					if (this.TypeUsage.Facets.TryGetValue(facetDescription.FacetName, false, out facet) && ((facet.Value == null && facet.Description.DefaultValue != null) || (facet.Value != null && !facet.Value.Equals(facet.Description.DefaultValue))))
					{
						list.Add(facet);
					}
				}
				this.TypeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(value, global::System.Data.Entity.Core.Metadata.Edm.FacetValues.Create(list));
				if (storeGeneratedPattern != global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.None)
				{
					this.StoreGeneratedPattern = storeGeneratedPattern;
				}
				if (concurrencyMode != global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.None)
				{
					this.ConcurrencyMode = concurrencyMode;
				}
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06003B24 RID: 15140 RVA: 0x000C2698 File Offset: 0x000C0898
		public global::System.Data.Entity.Core.Metadata.Edm.EnumType EnumType
		{
			get
			{
				return this.TypeUsage.EdmType as global::System.Data.Entity.Core.Metadata.Edm.EnumType;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06003B25 RID: 15141 RVA: 0x000C26AA File Offset: 0x000C08AA
		public global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType UnderlyingPrimitiveType
		{
			get
			{
				if (!this.IsUnderlyingPrimitiveType)
				{
					return null;
				}
				if (!this.IsEnumType)
				{
					return this.PrimitiveType;
				}
				return this.EnumType.UnderlyingType;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06003B26 RID: 15142 RVA: 0x000C26D0 File Offset: 0x000C08D0
		// (set) Token: 0x06003B27 RID: 15143 RVA: 0x000C26D8 File Offset: 0x000C08D8
		public global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode ConcurrencyMode
		{
			get
			{
				return global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetConcurrencyMode(this);
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this.TypeUsage = this.TypeUsage.ShallowCopy(new global::System.Data.Entity.Core.Metadata.Edm.Facet[]
				{
					global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConcurrencyModeFacet, value)
				});
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06003B28 RID: 15144 RVA: 0x000C270A File Offset: 0x000C090A
		// (set) Token: 0x06003B29 RID: 15145 RVA: 0x000C2712 File Offset: 0x000C0912
		public global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern StoreGeneratedPattern
		{
			get
			{
				return global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetStoreGeneratedPattern(this);
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this.TypeUsage = this.TypeUsage.ShallowCopy(new global::System.Data.Entity.Core.Metadata.Edm.Facet[]
				{
					global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(global::System.Data.Entity.Core.Metadata.Edm.Converter.StoreGeneratedPatternFacet, value)
				});
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06003B2A RID: 15146 RVA: 0x000C2744 File Offset: 0x000C0944
		// (set) Token: 0x06003B2B RID: 15147 RVA: 0x000C2778 File Offset: 0x000C0978
		public global::System.Data.Entity.Core.Metadata.Edm.CollectionKind CollectionKind
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				if (!this.TypeUsage.Facets.TryGetValue("CollectionKind", false, out facet))
				{
					return global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None;
				}
				return (global::System.Data.Entity.Core.Metadata.Edm.CollectionKind)facet.Value;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this.TypeUsage = this.TypeUsage.ShallowCopy(new global::System.Data.Entity.Core.Metadata.Edm.Facet[]
				{
					global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.CollectionKindFacetDescription, value)
				});
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06003B2C RID: 15148 RVA: 0x000C27AC File Offset: 0x000C09AC
		public bool IsMaxLengthConstant
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				return this.TypeUsage.Facets.TryGetValue("MaxLength", false, out facet) && facet.Description.IsConstant;
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06003B2D RID: 15149 RVA: 0x000C27E0 File Offset: 0x000C09E0
		// (set) Token: 0x06003B2E RID: 15150 RVA: 0x000C2824 File Offset: 0x000C0A24
		public int? MaxLength
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				if (!this.TypeUsage.Facets.TryGetValue("MaxLength", false, out facet))
				{
					return null;
				}
				return facet.Value as int?;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				int? maxLength = this.MaxLength;
				int? num = value;
				if (!(maxLength.GetValueOrDefault() == num.GetValueOrDefault() & maxLength != null == (num != null)))
				{
					this.TypeUsage = this.TypeUsage.ShallowCopy(new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
					{
						MaxLength = value
					});
				}
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06003B2F RID: 15151 RVA: 0x000C2888 File Offset: 0x000C0A88
		// (set) Token: 0x06003B30 RID: 15152 RVA: 0x000C28B7 File Offset: 0x000C0AB7
		public bool IsMaxLength
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				return this.TypeUsage.Facets.TryGetValue("MaxLength", false, out facet) && facet.IsUnbounded;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				if (value)
				{
					this.TypeUsage = this.TypeUsage.ShallowCopy(new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
					{
						MaxLength = global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.UnboundedValue
					});
				}
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06003B31 RID: 15153 RVA: 0x000C28E8 File Offset: 0x000C0AE8
		public bool IsFixedLengthConstant
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				return this.TypeUsage.Facets.TryGetValue("FixedLength", false, out facet) && facet.Description.IsConstant;
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06003B32 RID: 15154 RVA: 0x000C291C File Offset: 0x000C0B1C
		// (set) Token: 0x06003B33 RID: 15155 RVA: 0x000C2960 File Offset: 0x000C0B60
		public bool? IsFixedLength
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				if (!this.TypeUsage.Facets.TryGetValue("FixedLength", false, out facet))
				{
					return null;
				}
				return facet.Value as bool?;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				bool? isFixedLength = this.IsFixedLength;
				bool? flag = value;
				if (!(isFixedLength.GetValueOrDefault() == flag.GetValueOrDefault() & isFixedLength != null == (flag != null)))
				{
					this.TypeUsage = this.TypeUsage.ShallowCopy(new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
					{
						FixedLength = value
					});
				}
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06003B34 RID: 15156 RVA: 0x000C29C4 File Offset: 0x000C0BC4
		public bool IsUnicodeConstant
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				return this.TypeUsage.Facets.TryGetValue("Unicode", false, out facet) && facet.Description.IsConstant;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06003B35 RID: 15157 RVA: 0x000C29F8 File Offset: 0x000C0BF8
		// (set) Token: 0x06003B36 RID: 15158 RVA: 0x000C2A3C File Offset: 0x000C0C3C
		public bool? IsUnicode
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				if (!this.TypeUsage.Facets.TryGetValue("Unicode", false, out facet))
				{
					return null;
				}
				return facet.Value as bool?;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				bool? isUnicode = this.IsUnicode;
				bool? flag = value;
				if (!(isUnicode.GetValueOrDefault() == flag.GetValueOrDefault() & isUnicode != null == (flag != null)))
				{
					this.TypeUsage = this.TypeUsage.ShallowCopy(new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
					{
						Unicode = value
					});
				}
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06003B37 RID: 15159 RVA: 0x000C2AA0 File Offset: 0x000C0CA0
		public bool IsPrecisionConstant
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				return this.TypeUsage.Facets.TryGetValue("Precision", false, out facet) && facet.Description.IsConstant;
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06003B38 RID: 15160 RVA: 0x000C2AD4 File Offset: 0x000C0CD4
		// (set) Token: 0x06003B39 RID: 15161 RVA: 0x000C2B18 File Offset: 0x000C0D18
		public byte? Precision
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				if (!this.TypeUsage.Facets.TryGetValue("Precision", false, out facet))
				{
					return null;
				}
				return facet.Value as byte?;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				byte? b = this.Precision;
				int? num = (b != null) ? new int?((int)b.GetValueOrDefault()) : null;
				b = value;
				int? num2 = (b != null) ? new int?((int)b.GetValueOrDefault()) : null;
				if (!(num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null)))
				{
					this.TypeUsage = this.TypeUsage.ShallowCopy(new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
					{
						Precision = value
					});
				}
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06003B3A RID: 15162 RVA: 0x000C2BBC File Offset: 0x000C0DBC
		public bool IsScaleConstant
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				return this.TypeUsage.Facets.TryGetValue("Scale", false, out facet) && facet.Description.IsConstant;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06003B3B RID: 15163 RVA: 0x000C2BF0 File Offset: 0x000C0DF0
		// (set) Token: 0x06003B3C RID: 15164 RVA: 0x000C2C34 File Offset: 0x000C0E34
		public byte? Scale
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				if (!this.TypeUsage.Facets.TryGetValue("Scale", false, out facet))
				{
					return null;
				}
				return facet.Value as byte?;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				byte? b = this.Scale;
				int? num = (b != null) ? new int?((int)b.GetValueOrDefault()) : null;
				b = value;
				int? num2 = (b != null) ? new int?((int)b.GetValueOrDefault()) : null;
				if (!(num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null)))
				{
					this.TypeUsage = this.TypeUsage.ShallowCopy(new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
					{
						Scale = value
					});
				}
			}
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x000C2CD7 File Offset: 0x000C0ED7
		public void SetMetadataProperties(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty>>(metadataProperties, "metadataProperties");
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			base.AddMetadataProperties(metadataProperties);
		}

		// Token: 0x04001476 RID: 5238
		private readonly global::System.Reflection.PropertyInfo _propertyInfo;

		// Token: 0x04001477 RID: 5239
		private readonly global::System.Type _entityDeclaringType;

		// Token: 0x04001478 RID: 5240
		private global::System.Func<object, object> _memberGetter;

		// Token: 0x04001479 RID: 5241
		private global::System.Action<object, object> _memberSetter;
	}
}
