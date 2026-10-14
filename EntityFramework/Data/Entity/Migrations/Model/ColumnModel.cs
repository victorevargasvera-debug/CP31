using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Reflection;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000B0 RID: 176
	public class ColumnModel : global::System.Data.Entity.Migrations.Model.PropertyModel
	{
		// Token: 0x06000F1F RID: 3871 RVA: 0x0001EF3E File Offset: 0x0001D13E
		public ColumnModel(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type) : this(type, null)
		{
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0001EF48 File Offset: 0x0001D148
		public ColumnModel(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage) : base(type, typeUsage)
		{
			this._clrType = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(type).ClrEquivalentType;
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x0001EF6E File Offset: 0x0001D16E
		public virtual global::System.Type ClrType
		{
			get
			{
				return this._clrType;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x0001EF78 File Offset: 0x0001D178
		public virtual object ClrDefaultValue
		{
			get
			{
				if (this._clrType.IsValueType())
				{
					return global::System.Activator.CreateInstance(this._clrType);
				}
				if (this._clrType == typeof(string))
				{
					return string.Empty;
				}
				if (this._clrType == typeof(global::System.Data.Entity.Spatial.DbGeography))
				{
					return global::System.Data.Entity.Spatial.DbGeography.FromText("POINT(0 0)");
				}
				if (this._clrType == typeof(global::System.Data.Entity.Spatial.DbGeometry))
				{
					return global::System.Data.Entity.Spatial.DbGeometry.FromText("POINT(0 0)");
				}
				return new byte[0];
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x0001F005 File Offset: 0x0001D205
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x0001F00D File Offset: 0x0001D20D
		public virtual bool? IsNullable { get; set; }

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x0001F016 File Offset: 0x0001D216
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x0001F01E File Offset: 0x0001D21E
		public virtual bool IsIdentity { get; set; }

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x0001F027 File Offset: 0x0001D227
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x0001F02F File Offset: 0x0001D22F
		public virtual bool IsTimestamp { get; set; }

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x0001F038 File Offset: 0x0001D238
		// (set) Token: 0x06000F2A RID: 3882 RVA: 0x0001F040 File Offset: 0x0001D240
		public global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> Annotations
		{
			get
			{
				return this._annotations;
			}
			set
			{
				this._annotations = (value ?? new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues>());
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x0001F052 File Offset: 0x0001D252
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x0001F05A File Offset: 0x0001D25A
		internal global::System.Reflection.PropertyInfo ApiPropertyInfo
		{
			get
			{
				return this._apiPropertyInfo;
			}
			set
			{
				this._apiPropertyInfo = value;
			}
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x0001F064 File Offset: 0x0001D264
		public bool IsNarrowerThan(global::System.Data.Entity.Migrations.Model.ColumnModel column, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.ColumnModel>(column, "column");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.DbProviderManifest>(providerManifest, "providerManifest");
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage storeType = providerManifest.GetStoreType(base.TypeUsage);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage storeType2 = providerManifest.GetStoreType(column.TypeUsage);
			return global::System.Data.Entity.Migrations.Model.ColumnModel._typeSize[this.Type] < global::System.Data.Entity.Migrations.Model.ColumnModel._typeSize[column.Type] || (!(this.IsUnicode ?? true) && (column.IsUnicode ?? true)) || (!(this.IsNullable ?? true) && (column.IsNullable ?? true)) || global::System.Data.Entity.Migrations.Model.ColumnModel.IsNarrowerThan(storeType, storeType2);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0001F140 File Offset: 0x0001D340
		private static bool IsNarrowerThan(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage other)
		{
			foreach (string identity in new string[]
			{
				"MaxLength",
				"Precision",
				"Scale"
			})
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet2;
				if (typeUsage.Facets.TryGetValue(identity, true, out facet) && other.Facets.TryGetValue(facet.Name, true, out facet2) && facet.Value != facet2.Value)
				{
					int num = global::System.Convert.ToInt32(facet.Value, global::System.Globalization.CultureInfo.InvariantCulture);
					int num2 = global::System.Convert.ToInt32(facet2.Value, global::System.Globalization.CultureInfo.InvariantCulture);
					if (num < num2)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x0001F1E0 File Offset: 0x0001D3E0
		internal override global::System.Data.Entity.Core.Metadata.Edm.FacetValues ToFacetValues()
		{
			global::System.Data.Entity.Core.Metadata.Edm.FacetValues facetValues = base.ToFacetValues();
			if (this.IsNullable != null)
			{
				facetValues.Nullable = new bool?(this.IsNullable.Value);
			}
			if (this.IsIdentity)
			{
				facetValues.StoreGeneratedPattern = new global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern?(global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Identity);
			}
			return facetValues;
		}

		// Token: 0x0400084D RID: 2125
		private readonly global::System.Type _clrType;

		// Token: 0x0400084E RID: 2126
		private global::System.Reflection.PropertyInfo _apiPropertyInfo;

		// Token: 0x0400084F RID: 2127
		private global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> _annotations = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues>();

		// Token: 0x04000853 RID: 2131
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind, int> _typeSize = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind, int>
		{
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean,
				1
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte,
				1
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime,
				8
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset,
				10
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal,
				17
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double,
				53
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid,
				16
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16,
				2
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32,
				4
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64,
				8
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte,
				1
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single,
				4
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time,
				5
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPoint,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryLineString,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPolygon,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPoint,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiLineString,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPolygon,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryCollection,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPoint,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyLineString,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPolygon,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPoint,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiLineString,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPolygon,
				int.MaxValue
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyCollection,
				int.MaxValue
			}
		};
	}
}
