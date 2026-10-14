using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004EC RID: 1260
	public class PrimitiveType : global::System.Data.Entity.Core.Metadata.Edm.SimpleType
	{
		// Token: 0x06003ECA RID: 16074 RVA: 0x000D029F File Offset: 0x000CE49F
		internal PrimitiveType()
		{
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x000D02A7 File Offset: 0x000CE4A7
		internal PrimitiveType(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType baseType, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest) : base(name, namespaceName, dataSpace)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(baseType, "baseType");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.DbProviderManifest>(providerManifest, "providerManifest");
			this.BaseType = baseType;
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.Initialize(this, baseType.PrimitiveTypeKind, providerManifest);
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x000D02E3 File Offset: 0x000CE4E3
		internal PrimitiveType(global::System.Type clrType, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType baseType, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest) : this(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(clrType, "clrType").Name, clrType.NestingNamespace(), global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace, baseType, providerManifest)
		{
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06003ECD RID: 16077 RVA: 0x000D0304 File Offset: 0x000CE504
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType;
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06003ECE RID: 16078 RVA: 0x000D0308 File Offset: 0x000CE508
		internal override global::System.Type ClrType
		{
			get
			{
				return this.ClrEquivalentType;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06003ECF RID: 16079 RVA: 0x000D0310 File Offset: 0x000CE510
		// (set) Token: 0x06003ED0 RID: 16080 RVA: 0x000D0318 File Offset: 0x000CE518
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveTypeKind, false)]
		public virtual global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind PrimitiveTypeKind
		{
			get
			{
				return this._primitiveTypeKind;
			}
			internal set
			{
				this._primitiveTypeKind = value;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06003ED1 RID: 16081 RVA: 0x000D0321 File Offset: 0x000CE521
		// (set) Token: 0x06003ED2 RID: 16082 RVA: 0x000D0329 File Offset: 0x000CE529
		internal global::System.Data.Entity.Core.Common.DbProviderManifest ProviderManifest
		{
			get
			{
				return this._providerManifest;
			}
			set
			{
				this._providerManifest = value;
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06003ED3 RID: 16083 RVA: 0x000D0332 File Offset: 0x000CE532
		public virtual global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription> FacetDescriptions
		{
			get
			{
				return this.ProviderManifest.GetFacetDescriptions(this);
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06003ED4 RID: 16084 RVA: 0x000D0340 File Offset: 0x000CE540
		public global::System.Type ClrEquivalentType
		{
			get
			{
				switch (this.PrimitiveTypeKind)
				{
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary:
					return typeof(byte[]);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean:
					return typeof(bool);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte:
					return typeof(byte);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime:
					return typeof(global::System.DateTime);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal:
					return typeof(decimal);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double:
					return typeof(double);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid:
					return typeof(global::System.Guid);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single:
					return typeof(float);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte:
					return typeof(sbyte);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16:
					return typeof(short);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32:
					return typeof(int);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64:
					return typeof(long);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String:
					return typeof(string);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time:
					return typeof(global::System.TimeSpan);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset:
					return typeof(global::System.DateTimeOffset);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPoint:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryLineString:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPolygon:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPoint:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiLineString:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPolygon:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryCollection:
					return typeof(global::System.Data.Entity.Spatial.DbGeometry);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPoint:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyLineString:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPolygon:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPoint:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiLineString:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPolygon:
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyCollection:
					return typeof(global::System.Data.Entity.Spatial.DbGeography);
				case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId:
					return typeof(global::System.Data.Entity.Hierarchy.HierarchyId);
				default:
					return null;
				}
			}
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x000D04A6 File Offset: 0x000CE6A6
		internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription> GetAssociatedFacetDescriptions()
		{
			return base.GetAssociatedFacetDescriptions().Concat(this.FacetDescriptions);
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x000D04B9 File Offset: 0x000CE6B9
		internal static void Initialize(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			primitiveType._primitiveTypeKind = primitiveTypeKind;
			primitiveType._providerManifest = providerManifest;
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x000D04C9 File Offset: 0x000CE6C9
		public global::System.Data.Entity.Core.Metadata.Edm.EdmType GetEdmPrimitiveType()
		{
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(this.PrimitiveTypeKind);
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x000D04DB File Offset: 0x000CE6DB
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> GetEdmPrimitiveTypes()
		{
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetStoreTypes();
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x000D04E7 File Offset: 0x000CE6E7
		public static global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(primitiveTypeKind);
		}

		// Token: 0x04001550 RID: 5456
		private global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind _primitiveTypeKind;

		// Token: 0x04001551 RID: 5457
		private global::System.Data.Entity.Core.Common.DbProviderManifest _providerManifest;
	}
}
