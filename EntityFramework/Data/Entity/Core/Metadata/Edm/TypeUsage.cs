using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000501 RID: 1281
	[global::System.Diagnostics.DebuggerDisplay("EdmType={EdmType}, Facets.Count={Facets.Count}")]
	public class TypeUsage : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem
	{
		// Token: 0x06003F89 RID: 16265 RVA: 0x000D27B5 File Offset: 0x000D09B5
		internal TypeUsage()
		{
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x000D27BD File Offset: 0x000D09BD
		private TypeUsage(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType) : base(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.Readonly)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(edmType, "edmType");
			this._edmType = edmType;
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x000D27DC File Offset: 0x000D09DC
		private TypeUsage(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.Facet> facets) : this(edmType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.Facet> metadataCollection = global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.Facet>.Wrap(facets.ToList<global::System.Data.Entity.Core.Metadata.Edm.Facet>());
			metadataCollection.SetReadOnly();
			this._facets = metadataCollection.AsReadOnlyMetadataCollection();
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x000D280F File Offset: 0x000D0A0F
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Create(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage(edmType);
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x000D2817 File Offset: 0x000D0A17
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Create(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Data.Entity.Core.Metadata.Edm.FacetValues values)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage(edmType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.GetDefaultFacetDescriptionsAndOverrideFacetValues(edmType, values));
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x000D2826 File Offset: 0x000D0A26
		public static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Create(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.Facet> facets)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage(edmType, facets);
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x000D282F File Offset: 0x000D0A2F
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ShallowCopy(global::System.Data.Entity.Core.Metadata.Edm.FacetValues facetValues)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(this._edmType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.OverrideFacetValues(this.Facets, facetValues));
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x000D2848 File Offset: 0x000D0A48
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ShallowCopy(params global::System.Data.Entity.Core.Metadata.Edm.Facet[] facetValues)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(this._edmType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.OverrideFacetValues(this.Facets, facetValues));
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x000D2861 File Offset: 0x000D0A61
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.Facet> OverrideFacetValues(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.Facet> facets, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.Facet> facetValues)
		{
			return facets.Except(facetValues, (global::System.Data.Entity.Core.Metadata.Edm.Facet f1, global::System.Data.Entity.Core.Metadata.Edm.Facet f2) => f1.EdmEquals(f2)).Union(facetValues);
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x000D288F File Offset: 0x000D0A8F
		public static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateDefaultTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(edmType, "edmType");
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType);
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x000D28A4 File Offset: 0x000D0AA4
		public static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateStringTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType, bool isUnicode, bool isFixedLength, int maxLength)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(primitiveType, "primitiveType");
			if (primitiveType.PrimitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.NotStringTypeForTypeUsage);
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.ValidateMaxLength(maxLength);
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(primitiveType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
			{
				MaxLength = new int?(maxLength),
				Unicode = new bool?(isUnicode),
				FixedLength = new bool?(isFixedLength)
			});
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x000D2918 File Offset: 0x000D0B18
		public static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateStringTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType, bool isUnicode, bool isFixedLength)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(primitiveType, "primitiveType");
			if (primitiveType.PrimitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.NotStringTypeForTypeUsage);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(primitiveType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
			{
				MaxLength = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.DefaultMaxLengthFacetValue,
				Unicode = new bool?(isUnicode),
				FixedLength = new bool?(isFixedLength)
			});
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x000D2984 File Offset: 0x000D0B84
		public static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateBinaryTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType, bool isFixedLength, int maxLength)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(primitiveType, "primitiveType");
			if (primitiveType.PrimitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.NotBinaryTypeForTypeUsage);
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.ValidateMaxLength(maxLength);
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(primitiveType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
			{
				MaxLength = new int?(maxLength),
				FixedLength = new bool?(isFixedLength)
			});
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x000D29E4 File Offset: 0x000D0BE4
		public static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateBinaryTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType, bool isFixedLength)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(primitiveType, "primitiveType");
			if (primitiveType.PrimitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.NotBinaryTypeForTypeUsage);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(primitiveType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
			{
				MaxLength = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.DefaultMaxLengthFacetValue,
				FixedLength = new bool?(isFixedLength)
			});
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x000D2A3C File Offset: 0x000D0C3C
		public static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateDateTimeTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType, byte? precision)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(primitiveType, "primitiveType");
			if (primitiveType.PrimitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.NotDateTimeTypeForTypeUsage);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(primitiveType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
			{
				Precision = precision
			});
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x000D2A75 File Offset: 0x000D0C75
		public static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateDateTimeOffsetTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType, byte? precision)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(primitiveType, "primitiveType");
			if (primitiveType.PrimitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.NotDateTimeOffsetTypeForTypeUsage);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(primitiveType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
			{
				Precision = precision
			});
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x000D2AAF File Offset: 0x000D0CAF
		public static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateTimeTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType, byte? precision)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(primitiveType, "primitiveType");
			if (primitiveType.PrimitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.NotTimeTypeForTypeUsage);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(primitiveType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
			{
				Precision = precision
			});
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x000D2AEC File Offset: 0x000D0CEC
		public static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateDecimalTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType, byte precision, byte scale)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(primitiveType, "primitiveType");
			if (primitiveType.PrimitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.NotDecimalTypeForTypeUsage);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(primitiveType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
			{
				Precision = new byte?(precision),
				Scale = new byte?(scale)
			});
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x000D2B48 File Offset: 0x000D0D48
		public static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateDecimalTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(primitiveType, "primitiveType");
			if (primitiveType.PrimitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.NotDecimalTypeForTypeUsage);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(primitiveType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
			{
				Precision = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.DefaultPrecisionFacetValue,
				Scale = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.DefaultScaleFacetValue
			});
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06003F9C RID: 16284 RVA: 0x000D2BA0 File Offset: 0x000D0DA0
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.TypeUsage;
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06003F9D RID: 16285 RVA: 0x000D2BA4 File Offset: 0x000D0DA4
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmType, false)]
		public virtual global::System.Data.Entity.Core.Metadata.Edm.EdmType EdmType
		{
			get
			{
				return this._edmType;
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06003F9E RID: 16286 RVA: 0x000D2BAC File Offset: 0x000D0DAC
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.Facet, true)]
		public virtual global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.Facet> Facets
		{
			get
			{
				if (this._facets == null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.Facet> metadataCollection = new global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.Facet>(this.GetFacets());
					metadataCollection.SetReadOnly();
					global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.Facet>>(ref this._facets, metadataCollection.AsReadOnlyMetadataCollection(), null);
				}
				return this._facets;
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06003F9F RID: 16287 RVA: 0x000D2BF0 File Offset: 0x000D0DF0
		public global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ModelTypeUsage
		{
			get
			{
				if (this._modelTypeUsage == null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = this.EdmType;
					if (edmType.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace || edmType.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace)
					{
						return this;
					}
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
					if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRowType(edmType))
					{
						global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)edmType;
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[] array = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[rowType.Properties.Count];
						for (int i = 0; i < array.Length; i++)
						{
							global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = rowType.Properties[i];
							global::System.Data.Entity.Core.Metadata.Edm.TypeUsage modelTypeUsage = edmProperty.TypeUsage.ModelTypeUsage;
							array[i] = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(edmProperty.Name, modelTypeUsage);
						}
						typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.RowType(array, rowType.InitializerMetadata), this.Facets);
					}
					else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsCollectionType(edmType))
					{
						typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)edmType).TypeUsage.ModelTypeUsage), this.Facets);
					}
					else if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(edmType))
					{
						typeUsage = ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)edmType).ProviderManifest.GetEdmType(this);
						if (typeUsage == null)
						{
							throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.Mapping_ProviderReturnsNullType(this.ToString()));
						}
						if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNullable(this))
						{
							typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(typeUsage.EdmType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.OverrideFacetValues(typeUsage.Facets, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
							{
								Nullable = new bool?(false)
							}));
						}
					}
					else
					{
						if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityTypeBase(edmType) && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(edmType))
						{
							return null;
						}
						typeUsage = this;
					}
					global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(ref this._modelTypeUsage, typeUsage, null);
				}
				return this._modelTypeUsage;
			}
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x000D2D5A File Offset: 0x000D0F5A
		public bool IsSubtypeOf(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			return this.EdmType != null && typeUsage != null && this.EdmType.IsSubtypeOf(typeUsage.EdmType);
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x000D2D7A File Offset: 0x000D0F7A
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.Facet> GetFacets()
		{
			return from facetDescription in this._edmType.GetAssociatedFacetDescriptions()
			select facetDescription.DefaultValueFacet;
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x000D2DAB File Offset: 0x000D0FAB
		internal override void SetReadOnly()
		{
			base.SetReadOnly();
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06003FA3 RID: 16291 RVA: 0x000D2DB4 File Offset: 0x000D0FB4
		internal override string Identity
		{
			get
			{
				if (this.Facets.Count == 0)
				{
					return this.EdmType.Identity;
				}
				if (this._identity == null)
				{
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(128);
					this.BuildIdentity(stringBuilder);
					string value = stringBuilder.ToString();
					global::System.Threading.Interlocked.CompareExchange<string>(ref this._identity, value, null);
				}
				return this._identity;
			}
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x000D2E10 File Offset: 0x000D1010
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.Facet> GetDefaultFacetDescriptionsAndOverrideFacetValues(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Data.Entity.Core.Metadata.Edm.FacetValues values)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.OverrideFacetValues<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(type.GetAssociatedFacetDescriptions(), (global::System.Data.Entity.Core.Metadata.Edm.FacetDescription fd) => fd, (global::System.Data.Entity.Core.Metadata.Edm.FacetDescription fd) => fd.DefaultValueFacet, values);
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x000D2E68 File Offset: 0x000D1068
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.Facet> OverrideFacetValues(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.Facet> facets, global::System.Data.Entity.Core.Metadata.Edm.FacetValues values)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.OverrideFacetValues<global::System.Data.Entity.Core.Metadata.Edm.Facet>(facets, (global::System.Data.Entity.Core.Metadata.Edm.Facet f) => f.Description, (global::System.Data.Entity.Core.Metadata.Edm.Facet f) => f, values);
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x000D2EBA File Offset: 0x000D10BA
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.Facet> OverrideFacetValues<T>(global::System.Collections.Generic.IEnumerable<T> facetThings, global::System.Func<T, global::System.Data.Entity.Core.Metadata.Edm.FacetDescription> getDescription, global::System.Func<T, global::System.Data.Entity.Core.Metadata.Edm.Facet> getFacet, global::System.Data.Entity.Core.Metadata.Edm.FacetValues values)
		{
			foreach (T arg in facetThings)
			{
				global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facetDescription = getDescription(arg);
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				if (!facetDescription.IsConstant && values.TryGetFacet(facetDescription, out facet))
				{
					yield return facet;
				}
				else
				{
					yield return getFacet(arg);
				}
			}
			global::System.Collections.Generic.IEnumerator<T> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x000D2EE0 File Offset: 0x000D10E0
		internal override void BuildIdentity(global::System.Text.StringBuilder builder)
		{
			if (this._identity != null)
			{
				builder.Append(this._identity);
				return;
			}
			builder.Append(this.EdmType.Identity);
			builder.Append("(");
			bool flag = true;
			for (int i = 0; i < this.Facets.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet = this.Facets[i];
				if (0 <= global::System.Array.BinarySearch<string>(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage._identityFacets, facet.Name, global::System.StringComparer.Ordinal))
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						builder.Append(",");
					}
					builder.Append(facet.Name);
					builder.Append("=");
					builder.Append(facet.Value ?? string.Empty);
				}
			}
			builder.Append(")");
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x000D2FAC File Offset: 0x000D11AC
		public override string ToString()
		{
			return this.EdmType.ToString();
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x000D2FBC File Offset: 0x000D11BC
		internal override bool EdmEquals(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
		{
			if (this == item)
			{
				return true;
			}
			if (item == null || global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.TypeUsage != item.BuiltInTypeKind)
			{
				return false;
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = (global::System.Data.Entity.Core.Metadata.Edm.TypeUsage)item;
			if (!this.EdmType.EdmEquals(typeUsage.EdmType))
			{
				return false;
			}
			if (this._facets == null && typeUsage._facets == null)
			{
				return true;
			}
			if (this.Facets.Count != typeUsage.Facets.Count)
			{
				return false;
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.Facet facet in this.Facets)
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet2;
				if (!typeUsage.Facets.TryGetValue(facet.Name, false, out facet2))
				{
					return false;
				}
				if (!object.Equals(facet.Value, facet2.Value))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x000D309C File Offset: 0x000D129C
		private static void ValidateMaxLength(int maxLength)
		{
			if (maxLength <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException("maxLength", global::System.Data.Entity.Resources.Strings.InvalidMaxLengthSize);
			}
		}

		// Token: 0x04001598 RID: 5528
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _modelTypeUsage;

		// Token: 0x04001599 RID: 5529
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmType _edmType;

		// Token: 0x0400159A RID: 5530
		private global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.Facet> _facets;

		// Token: 0x0400159B RID: 5531
		private string _identity;

		// Token: 0x0400159C RID: 5532
		private static readonly string[] _identityFacets = new string[]
		{
			"DefaultValue",
			"FixedLength",
			"MaxLength",
			"Nullable",
			"Precision",
			"Scale",
			"Unicode",
			"SRID"
		};

		// Token: 0x0400159D RID: 5533
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.Unbounded DefaultMaxLengthFacetValue = global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.UnboundedValue;

		// Token: 0x0400159E RID: 5534
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.Unbounded DefaultPrecisionFacetValue = global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.UnboundedValue;

		// Token: 0x0400159F RID: 5535
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.Unbounded DefaultScaleFacetValue = global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.UnboundedValue;

		// Token: 0x040015A0 RID: 5536
		internal const bool DefaultUnicodeFacetValue = true;

		// Token: 0x040015A1 RID: 5537
		internal const bool DefaultFixedLengthFacetValue = false;

		// Token: 0x040015A2 RID: 5538
		internal static readonly byte? DefaultDateTimePrecisionFacetValue = null;
	}
}
