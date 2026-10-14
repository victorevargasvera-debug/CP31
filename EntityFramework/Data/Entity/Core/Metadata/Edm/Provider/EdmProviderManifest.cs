using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm.Provider
{
	// Token: 0x0200051A RID: 1306
	internal class EdmProviderManifest : global::System.Data.Entity.Core.Common.DbProviderManifest
	{
		// Token: 0x0600406D RID: 16493 RVA: 0x000D6C0E File Offset: 0x000D4E0E
		private EdmProviderManifest()
		{
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x0600406E RID: 16494 RVA: 0x000D6C16 File Offset: 0x000D4E16
		internal static global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest Instance
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest._instance;
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x0600406F RID: 16495 RVA: 0x000D6C1D File Offset: 0x000D4E1D
		public override string NamespaceName
		{
			get
			{
				return "Edm";
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06004070 RID: 16496 RVA: 0x000D6C24 File Offset: 0x000D4E24
		internal virtual string Token
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x000D6C2B File Offset: 0x000D4E2B
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> GetStoreFunctions()
		{
			this.InitializeCanonicalFunctions();
			return this._functions;
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x000D6C3C File Offset: 0x000D4E3C
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription> GetFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			this.InitializeFacetDescriptions();
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription> result = null;
			if (this._facetDescriptions.TryGetValue(type as global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType, out result))
			{
				return result;
			}
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.EmptyFacetDescriptionEnumerable;
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x000D6C6D File Offset: 0x000D4E6D
		public global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			this.InitializePrimitiveTypes();
			return this._primitiveTypes[(int)primitiveTypeKind];
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x000D6C84 File Offset: 0x000D4E84
		private void InitializePrimitiveTypes()
		{
			if (this._primitiveTypes != null)
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType[] array = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType[32];
			array[0] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[1] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[2] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[3] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[4] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[5] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[7] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[6] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[31] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[9] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[10] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[11] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[8] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[12] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[13] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[14] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[15] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[17] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[18] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[19] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[20] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[21] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[22] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[23] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[16] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[24] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[25] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[26] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[27] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[28] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[29] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			array[30] = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType();
			this.InitializePrimitiveType(array[0], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary, "Binary", typeof(byte[]));
			this.InitializePrimitiveType(array[1], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, "Boolean", typeof(bool));
			this.InitializePrimitiveType(array[2], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte, "Byte", typeof(byte));
			this.InitializePrimitiveType(array[3], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime, "DateTime", typeof(global::System.DateTime));
			this.InitializePrimitiveType(array[4], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal, "Decimal", typeof(decimal));
			this.InitializePrimitiveType(array[5], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double, "Double", typeof(double));
			this.InitializePrimitiveType(array[7], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single, "Single", typeof(float));
			this.InitializePrimitiveType(array[6], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid, "Guid", typeof(global::System.Guid));
			this.InitializePrimitiveType(array[31], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, "HierarchyId", typeof(global::System.Data.Entity.Hierarchy.HierarchyId));
			this.InitializePrimitiveType(array[9], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16, "Int16", typeof(short));
			this.InitializePrimitiveType(array[10], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "Int32", typeof(int));
			this.InitializePrimitiveType(array[11], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64, "Int64", typeof(long));
			this.InitializePrimitiveType(array[8], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte, "SByte", typeof(sbyte));
			this.InitializePrimitiveType(array[12], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "String", typeof(string));
			this.InitializePrimitiveType(array[13], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time, "Time", typeof(global::System.TimeSpan));
			this.InitializePrimitiveType(array[14], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset, "DateTimeOffset", typeof(global::System.DateTimeOffset));
			this.InitializePrimitiveType(array[16], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography, "Geography", typeof(global::System.Data.Entity.Spatial.DbGeography));
			this.InitializePrimitiveType(array[24], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPoint, "GeographyPoint", typeof(global::System.Data.Entity.Spatial.DbGeography));
			this.InitializePrimitiveType(array[25], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyLineString, "GeographyLineString", typeof(global::System.Data.Entity.Spatial.DbGeography));
			this.InitializePrimitiveType(array[26], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPolygon, "GeographyPolygon", typeof(global::System.Data.Entity.Spatial.DbGeography));
			this.InitializePrimitiveType(array[27], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPoint, "GeographyMultiPoint", typeof(global::System.Data.Entity.Spatial.DbGeography));
			this.InitializePrimitiveType(array[28], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiLineString, "GeographyMultiLineString", typeof(global::System.Data.Entity.Spatial.DbGeography));
			this.InitializePrimitiveType(array[29], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPolygon, "GeographyMultiPolygon", typeof(global::System.Data.Entity.Spatial.DbGeography));
			this.InitializePrimitiveType(array[30], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyCollection, "GeographyCollection", typeof(global::System.Data.Entity.Spatial.DbGeography));
			this.InitializePrimitiveType(array[15], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry, "Geometry", typeof(global::System.Data.Entity.Spatial.DbGeometry));
			this.InitializePrimitiveType(array[17], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPoint, "GeometryPoint", typeof(global::System.Data.Entity.Spatial.DbGeometry));
			this.InitializePrimitiveType(array[18], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryLineString, "GeometryLineString", typeof(global::System.Data.Entity.Spatial.DbGeometry));
			this.InitializePrimitiveType(array[19], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPolygon, "GeometryPolygon", typeof(global::System.Data.Entity.Spatial.DbGeometry));
			this.InitializePrimitiveType(array[20], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPoint, "GeometryMultiPoint", typeof(global::System.Data.Entity.Spatial.DbGeometry));
			this.InitializePrimitiveType(array[21], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiLineString, "GeometryMultiLineString", typeof(global::System.Data.Entity.Spatial.DbGeometry));
			this.InitializePrimitiveType(array[22], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPolygon, "GeometryMultiPolygon", typeof(global::System.Data.Entity.Spatial.DbGeometry));
			this.InitializePrimitiveType(array[23], global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryCollection, "GeometryCollection", typeof(global::System.Data.Entity.Spatial.DbGeometry));
			foreach (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType in array)
			{
				primitiveType.ProviderManifest = this;
				primitiveType.SetReadOnly();
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> value = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(array);
			global::System.Threading.Interlocked.CompareExchange<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>>(ref this._primitiveTypes, value, null);
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x000D713B File Offset: 0x000D533B
		private void InitializePrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind, string name, global::System.Type clrType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType.Initialize(primitiveType, name, "Edm", global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, true, null);
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.Initialize(primitiveType, primitiveTypeKind, this);
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x000D7154 File Offset: 0x000D5354
		private void InitializeFacetDescriptions()
		{
			if (this._facetDescriptions != null)
			{
				return;
			}
			this.InitializePrimitiveTypes();
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>>();
			global::System.Data.Entity.Core.Metadata.Edm.FacetDescription[] initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String);
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType key = this._primitiveTypes[12];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary);
			key = this._primitiveTypes[0];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime);
			key = this._primitiveTypes[3];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time);
			key = this._primitiveTypes[13];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset);
			key = this._primitiveTypes[14];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal);
			key = this._primitiveTypes[4];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography);
			key = this._primitiveTypes[16];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPoint);
			key = this._primitiveTypes[24];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyLineString);
			key = this._primitiveTypes[25];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPolygon);
			key = this._primitiveTypes[26];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPoint);
			key = this._primitiveTypes[27];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiLineString);
			key = this._primitiveTypes[28];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPolygon);
			key = this._primitiveTypes[29];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyCollection);
			key = this._primitiveTypes[30];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry);
			key = this._primitiveTypes[15];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPoint);
			key = this._primitiveTypes[17];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryLineString);
			key = this._primitiveTypes[18];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPolygon);
			key = this._primitiveTypes[19];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPoint);
			key = this._primitiveTypes[20];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiLineString);
			key = this._primitiveTypes[21];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPolygon);
			key = this._primitiveTypes[22];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			initialFacetDescriptions = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryCollection);
			key = this._primitiveTypes[23];
			dictionary.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(initialFacetDescriptions));
			global::System.Threading.Interlocked.CompareExchange<global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>>>(ref this._facetDescriptions, dictionary, null);
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x000D7480 File Offset: 0x000D5680
		internal static global::System.Data.Entity.Core.Metadata.Edm.FacetDescription[] GetInitialFacetDescriptions(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			switch (primitiveTypeKind)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary:
				return new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription[]
				{
					new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("MaxLength", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32), new int?(0), new int?(int.MaxValue), null),
					new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("FixedLength", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean), null, null, null)
				};
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime:
				return new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription[]
				{
					new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("Precision", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte), new int?(0), new int?(255), null)
				};
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal:
				return new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription[]
				{
					new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("Precision", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte), new int?(1), new int?(255), null),
					new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("Scale", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte), new int?(0), new int?(255), null)
				};
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String:
				return new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription[]
				{
					new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("MaxLength", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32), new int?(0), new int?(int.MaxValue), null),
					new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("Unicode", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean), null, null, null),
					new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("FixedLength", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean), null, null, null)
				};
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time:
				return new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription[]
				{
					new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("Precision", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte), new int?(0), new int?(255), global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.DefaultDateTimePrecisionFacetValue)
				};
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset:
				return new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription[]
				{
					new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("Precision", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte), new int?(0), new int?(255), global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.DefaultDateTimePrecisionFacetValue)
				};
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPoint:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryLineString:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPolygon:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPoint:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiLineString:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPolygon:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryCollection:
				return new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription[]
				{
					new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("SRID", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32), new int?(0), new int?(int.MaxValue), global::System.Data.Entity.Spatial.DbGeometry.DefaultCoordinateSystemId),
					new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("IsStrict", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean), null, null, true)
				};
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPoint:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyLineString:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPolygon:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPoint:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiLineString:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPolygon:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyCollection:
				return new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription[]
				{
					new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("SRID", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32), new int?(0), new int?(int.MaxValue), global::System.Data.Entity.Spatial.DbGeography.DefaultCoordinateSystemId),
					new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("IsStrict", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean), null, null, true)
				};
			}
			return null;
		}

		// Token: 0x06004078 RID: 16504 RVA: 0x000D77C8 File Offset: 0x000D59C8
		private void InitializeCanonicalFunctions()
		{
			if (this._functions != null)
			{
				return;
			}
			this.InitializePrimitiveTypes();
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder functions = new global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder(this._primitiveTypes);
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[] typeKinds = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset
			};
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddAggregate("Max", type);
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddAggregate("Min", type);
			});
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[] typeKinds2 = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64
			};
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds2, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddAggregate("Avg", type);
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds2, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddAggregate("Sum", type);
			});
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[] typeKinds3 = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64
			};
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds3, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddAggregate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double, "StDev", type);
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds3, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddAggregate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double, "StDevP", type);
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds3, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddAggregate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double, "Var", type);
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds3, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddAggregate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double, "VarP", type);
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForAllBasePrimitiveTypes(delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddAggregate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "Count", type);
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForAllBasePrimitiveTypes(delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddAggregate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64, "BigCount", type);
			});
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "Trim", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "stringArgument");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "RTrim", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "stringArgument");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "LTrim", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "stringArgument");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "Concat", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "string1", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "string2");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "Length", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "stringArgument");
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[] typeKinds4 = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte
			};
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds4, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "Substring", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "stringArgument", type, "start", type, "length");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds4, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "Left", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "stringArgument", type, "length");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds4, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "Right", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "stringArgument", type, "length");
			});
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "Replace", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "stringArgument", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "toReplace", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "replacement");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "IndexOf", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "searchString", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "stringToFind");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "ToUpper", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "stringArgument");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "ToLower", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "stringArgument");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "Reverse", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "stringArgument");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, "Contains", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "searchedString", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "searchedForString");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, "StartsWith", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "stringArgument", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "prefix");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, "EndsWith", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "stringArgument", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "suffix");
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[] typeKinds5 = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime
			};
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds5, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "Year", type, "dateValue");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds5, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "Month", type, "dateValue");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds5, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "Day", type, "dateValue");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds5, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "DayOfYear", type, "dateValue");
			});
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[] typeKinds6 = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time
			};
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds6, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "Hour", type, "timeValue");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds6, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "Minute", type, "timeValue");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds6, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "Second", type, "timeValue");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds6, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "Millisecond", type, "timeValue");
			});
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime, "CurrentDateTime");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset, "CurrentDateTimeOffset");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "GetTotalOffsetMinutes", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset, "dateTimeOffsetArgument");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime, "LocalDateTime", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset, "dateTimeOffsetArgument");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime, "UtcDateTime", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset, "dateTimeOffsetArgument");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime, "CurrentUtcDateTime");
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds5, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "TruncateTime", type, "dateValue");
			});
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime, "CreateDateTime", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "year", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "month", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "day", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "hour", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "minute", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double, "second");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset, "CreateDateTimeOffset", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "year", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "month", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "day", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "hour", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "minute", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double, "second", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "timeZoneOffset");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time, "CreateTime", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "hour", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "minute", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double, "second");
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds5, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "AddYears", type, "dateValue", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "addValue");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds5, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "AddMonths", type, "dateValue", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "addValue");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds5, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "AddDays", type, "dateValue", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "addValue");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds6, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "AddHours", type, "timeValue", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "addValue");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds6, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "AddMinutes", type, "timeValue", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "addValue");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds6, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "AddSeconds", type, "timeValue", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "addValue");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds6, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "AddMilliseconds", type, "timeValue", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "addValue");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds6, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "AddMicroseconds", type, "timeValue", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "addValue");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds6, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "AddNanoseconds", type, "timeValue", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "addValue");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds5, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "DiffYears", type, "dateValue1", type, "dateValue2");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds5, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "DiffMonths", type, "dateValue1", type, "dateValue2");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds5, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "DiffDays", type, "dateValue1", type, "dateValue2");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds6, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "DiffHours", type, "timeValue1", type, "timeValue2");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds6, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "DiffMinutes", type, "timeValue1", type, "timeValue2");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds6, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "DiffSeconds", type, "timeValue1", type, "timeValue2");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds6, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "DiffMilliseconds", type, "timeValue1", type, "timeValue2");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds6, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "DiffMicroseconds", type, "timeValue1", type, "timeValue2");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds6, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "DiffNanoseconds", type, "timeValue1", type, "timeValue2");
			});
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[] typeKinds7 = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal
			};
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds7, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "Round", type, "value");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds7, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "Floor", type, "value");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds7, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "Ceiling", type, "value");
			});
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[] typeKinds8 = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal
			};
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds8, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "Round", type, "value", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "digits");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds8, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "Truncate", type, "value", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "digits");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single
			}, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "Abs", type, "value");
			});
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[] array = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64
			};
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[] array2 = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64
			};
			foreach (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind in array)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument2TypeKind in array2)
				{
					functions.AddFunction(primitiveTypeKind, "Power", primitiveTypeKind, "baseArgument", argument2TypeKind, "exponent");
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[] typeKinds9 = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte
			};
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds9, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "BitwiseAnd", type, "value1", type, "value2");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds9, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "BitwiseOr", type, "value1", type, "value2");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds9, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "BitwiseXor", type, "value1", type, "value2");
			});
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder.ForTypes(typeKinds9, delegate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
			{
				functions.AddFunction(type, "BitwiseNot", type, "value");
			});
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid, "NewGuid");
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestSpatialFunctions.AddFunctions(functions);
			global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestHierarchyIdFunctions.AddFunctions(functions);
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> value = functions.ToFunctionCollection();
			global::System.Threading.Interlocked.CompareExchange<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>>(ref this._functions, value, null);
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x000D7F6E File Offset: 0x000D616E
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> GetPromotionTypes(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType)
		{
			this.InitializePromotableTypes();
			return this._promotionTypes[(int)primitiveType.PrimitiveTypeKind];
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x000D7F84 File Offset: 0x000D6184
		private void InitializePromotableTypes()
		{
			if (this._promotionTypes != null)
			{
				return;
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>[] array = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>[32];
			for (int i = 0; i < 32; i++)
			{
				array[i] = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType[]
				{
					this._primitiveTypes[i]
				});
			}
			array[2] = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType[]
			{
				this._primitiveTypes[2],
				this._primitiveTypes[9],
				this._primitiveTypes[10],
				this._primitiveTypes[11],
				this._primitiveTypes[4],
				this._primitiveTypes[7],
				this._primitiveTypes[5]
			});
			array[9] = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType[]
			{
				this._primitiveTypes[9],
				this._primitiveTypes[10],
				this._primitiveTypes[11],
				this._primitiveTypes[4],
				this._primitiveTypes[7],
				this._primitiveTypes[5]
			});
			array[10] = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType[]
			{
				this._primitiveTypes[10],
				this._primitiveTypes[11],
				this._primitiveTypes[4],
				this._primitiveTypes[7],
				this._primitiveTypes[5]
			});
			array[11] = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType[]
			{
				this._primitiveTypes[11],
				this._primitiveTypes[4],
				this._primitiveTypes[7],
				this._primitiveTypes[5]
			});
			array[7] = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType[]
			{
				this._primitiveTypes[7],
				this._primitiveTypes[5]
			});
			this.InitializeSpatialPromotionGroup(array, new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPoint,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyLineString,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPolygon,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPoint,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiLineString,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPolygon,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyCollection
			}, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography);
			this.InitializeSpatialPromotionGroup(array, new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPoint,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryLineString,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPolygon,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPoint,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiLineString,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPolygon,
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryCollection
			}, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry);
			global::System.Threading.Interlocked.CompareExchange<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>[]>(ref this._promotionTypes, array, null);
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x000D81C8 File Offset: 0x000D63C8
		private void InitializeSpatialPromotionGroup(global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>[] promotionTypes, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[] promotableKinds, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind baseKind)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind in promotableKinds)
			{
				promotionTypes[(int)primitiveTypeKind] = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType[]
				{
					this._primitiveTypes[(int)primitiveTypeKind],
					this._primitiveTypes[(int)baseKind]
				});
			}
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x000D8215 File Offset: 0x000D6415
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest._canonicalModelTypes == null)
			{
				this.InitializeCanonicalModelTypes();
			}
			return global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest._canonicalModelTypes[(int)primitiveTypeKind];
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x000D822C File Offset: 0x000D642C
		private void InitializeCanonicalModelTypes()
		{
			this.InitializePrimitiveTypes();
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[] array = new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[32];
			for (int i = 0; i < 32; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(this._primitiveTypes[i]);
				array[i] = typeUsage;
			}
			global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]>(ref global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest._canonicalModelTypes, array, null);
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x000D8277 File Offset: 0x000D6477
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> GetStoreTypes()
		{
			this.InitializePrimitiveTypes();
			return this._primitiveTypes;
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x000D8285 File Offset: 0x000D6485
		public override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetEdmType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage storeType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(storeType, "storeType");
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x000D8298 File Offset: 0x000D6498
		public override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetStoreType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage edmType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(edmType, "edmType");
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x000D82AC File Offset: 0x000D64AC
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ForgetScalarConstraints(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = type.EdmType as global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType;
			if (primitiveType != null)
			{
				return this.GetCanonicalModelTypeUsage(primitiveType.PrimitiveTypeKind);
			}
			return type;
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x000D82D6 File Offset: 0x000D64D6
		protected override global::System.Xml.XmlReader GetDbInformation(string informationType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0400166D RID: 5741
		internal const string ConcurrencyModeFacetName = "ConcurrencyMode";

		// Token: 0x0400166E RID: 5742
		internal const string StoreGeneratedPatternFacetName = "StoreGeneratedPattern";

		// Token: 0x0400166F RID: 5743
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>> _facetDescriptions;

		// Token: 0x04001670 RID: 5744
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> _primitiveTypes;

		// Token: 0x04001671 RID: 5745
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> _functions;

		// Token: 0x04001672 RID: 5746
		private static readonly global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest _instance = new global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest();

		// Token: 0x04001673 RID: 5747
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>[] _promotionTypes;

		// Token: 0x04001674 RID: 5748
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[] _canonicalModelTypes;

		// Token: 0x04001675 RID: 5749
		internal const byte MaximumDecimalPrecision = 255;

		// Token: 0x04001676 RID: 5750
		internal const byte MaximumDateTimePrecision = 255;
	}
}
