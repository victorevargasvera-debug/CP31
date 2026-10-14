using System;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Data.Entity.Spatial
{
	// Token: 0x02000091 RID: 145
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class DbGeography
	{
		// Token: 0x060004D4 RID: 1236 RVA: 0x00010A22 File Offset: 0x0000EC22
		internal DbGeography()
		{
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00010A2A File Offset: 0x0000EC2A
		internal DbGeography(global::System.Data.Entity.Spatial.DbSpatialServices spatialServices, object spatialProviderValue)
		{
			this._spatialProvider = spatialServices;
			this._providerValue = spatialProviderValue;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00010A40 File Offset: 0x0000EC40
		public static int DefaultCoordinateSystemId
		{
			get
			{
				return 4326;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00010A47 File Offset: 0x0000EC47
		public object ProviderValue
		{
			get
			{
				return this._providerValue;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00010A4F File Offset: 0x0000EC4F
		public virtual global::System.Data.Entity.Spatial.DbSpatialServices Provider
		{
			get
			{
				return this._spatialProvider;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00010A57 File Offset: 0x0000EC57
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00010A68 File Offset: 0x0000EC68
		[global::System.Runtime.Serialization.DataMember(Name = "Geography")]
		public global::System.Data.Entity.Spatial.DbGeographyWellKnownValue WellKnownValue
		{
			get
			{
				return this._spatialProvider.CreateWellKnownValue(this);
			}
			set
			{
				if (this._spatialProvider != null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Spatial_WellKnownValueSerializationPropertyNotDirectlySettable);
				}
				global::System.Data.Entity.Spatial.DbSpatialServices @default = global::System.Data.Entity.Spatial.DbSpatialServices.Default;
				this._providerValue = @default.CreateProviderValue(value);
				this._spatialProvider = @default;
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00010AA2 File Offset: 0x0000ECA2
		public static global::System.Data.Entity.Spatial.DbGeography FromBinary(byte[] wellKnownBinary)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(wellKnownBinary, "wellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyFromBinary(wellKnownBinary);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00010ABB File Offset: 0x0000ECBB
		public static global::System.Data.Entity.Spatial.DbGeography FromBinary(byte[] wellKnownBinary, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(wellKnownBinary, "wellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyFromBinary(wellKnownBinary, coordinateSystemId);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00010AD5 File Offset: 0x0000ECD5
		public static global::System.Data.Entity.Spatial.DbGeography LineFromBinary(byte[] lineWellKnownBinary, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(lineWellKnownBinary, "lineWellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyLineFromBinary(lineWellKnownBinary, coordinateSystemId);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00010AEF File Offset: 0x0000ECEF
		public static global::System.Data.Entity.Spatial.DbGeography PointFromBinary(byte[] pointWellKnownBinary, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(pointWellKnownBinary, "pointWellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyPointFromBinary(pointWellKnownBinary, coordinateSystemId);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00010B09 File Offset: 0x0000ED09
		public static global::System.Data.Entity.Spatial.DbGeography PolygonFromBinary(byte[] polygonWellKnownBinary, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(polygonWellKnownBinary, "polygonWellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyPolygonFromBinary(polygonWellKnownBinary, coordinateSystemId);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00010B23 File Offset: 0x0000ED23
		public static global::System.Data.Entity.Spatial.DbGeography MultiLineFromBinary(byte[] multiLineWellKnownBinary, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(multiLineWellKnownBinary, "multiLineWellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyMultiLineFromBinary(multiLineWellKnownBinary, coordinateSystemId);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00010B3D File Offset: 0x0000ED3D
		public static global::System.Data.Entity.Spatial.DbGeography MultiPointFromBinary(byte[] multiPointWellKnownBinary, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(multiPointWellKnownBinary, "multiPointWellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyMultiPointFromBinary(multiPointWellKnownBinary, coordinateSystemId);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00010B57 File Offset: 0x0000ED57
		public static global::System.Data.Entity.Spatial.DbGeography MultiPolygonFromBinary(byte[] multiPolygonWellKnownBinary, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(multiPolygonWellKnownBinary, "multiPolygonWellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyMultiPolygonFromBinary(multiPolygonWellKnownBinary, coordinateSystemId);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00010B71 File Offset: 0x0000ED71
		public static global::System.Data.Entity.Spatial.DbGeography GeographyCollectionFromBinary(byte[] geographyCollectionWellKnownBinary, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(geographyCollectionWellKnownBinary, "geographyCollectionWellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyCollectionFromBinary(geographyCollectionWellKnownBinary, coordinateSystemId);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00010B8B File Offset: 0x0000ED8B
		public static global::System.Data.Entity.Spatial.DbGeography FromGml(string geographyMarkup)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(geographyMarkup, "geographyMarkup");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyFromGml(geographyMarkup);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00010BA4 File Offset: 0x0000EDA4
		public static global::System.Data.Entity.Spatial.DbGeography FromGml(string geographyMarkup, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(geographyMarkup, "geographyMarkup");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyFromGml(geographyMarkup, coordinateSystemId);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00010BBE File Offset: 0x0000EDBE
		public static global::System.Data.Entity.Spatial.DbGeography FromText(string wellKnownText)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(wellKnownText, "wellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyFromText(wellKnownText);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00010BD7 File Offset: 0x0000EDD7
		public static global::System.Data.Entity.Spatial.DbGeography FromText(string wellKnownText, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(wellKnownText, "wellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyFromText(wellKnownText, coordinateSystemId);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00010BF1 File Offset: 0x0000EDF1
		public static global::System.Data.Entity.Spatial.DbGeography LineFromText(string lineWellKnownText, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(lineWellKnownText, "lineWellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyLineFromText(lineWellKnownText, coordinateSystemId);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00010C0B File Offset: 0x0000EE0B
		public static global::System.Data.Entity.Spatial.DbGeography PointFromText(string pointWellKnownText, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(pointWellKnownText, "pointWellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyPointFromText(pointWellKnownText, coordinateSystemId);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00010C25 File Offset: 0x0000EE25
		public static global::System.Data.Entity.Spatial.DbGeography PolygonFromText(string polygonWellKnownText, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(polygonWellKnownText, "polygonWellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyPolygonFromText(polygonWellKnownText, coordinateSystemId);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public static global::System.Data.Entity.Spatial.DbGeography MultiLineFromText(string multiLineWellKnownText, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(multiLineWellKnownText, "multiLineWellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyMultiLineFromText(multiLineWellKnownText, coordinateSystemId);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00010C59 File Offset: 0x0000EE59
		public static global::System.Data.Entity.Spatial.DbGeography MultiPointFromText(string multiPointWellKnownText, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(multiPointWellKnownText, "multiPointWellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyMultiPointFromText(multiPointWellKnownText, coordinateSystemId);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00010C73 File Offset: 0x0000EE73
		public static global::System.Data.Entity.Spatial.DbGeography MultiPolygonFromText(string multiPolygonWellKnownText, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(multiPolygonWellKnownText, "multiPolygonWellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyMultiPolygonFromText(multiPolygonWellKnownText, coordinateSystemId);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00010C8D File Offset: 0x0000EE8D
		public static global::System.Data.Entity.Spatial.DbGeography GeographyCollectionFromText(string geographyCollectionWellKnownText, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(geographyCollectionWellKnownText, "geographyCollectionWellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeographyCollectionFromText(geographyCollectionWellKnownText, coordinateSystemId);
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00010CA7 File Offset: 0x0000EEA7
		public int CoordinateSystemId
		{
			get
			{
				return this._spatialProvider.GetCoordinateSystemId(this);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00010CB5 File Offset: 0x0000EEB5
		public int Dimension
		{
			get
			{
				return this._spatialProvider.GetDimension(this);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00010CC3 File Offset: 0x0000EEC3
		public string SpatialTypeName
		{
			get
			{
				return this._spatialProvider.GetSpatialTypeName(this);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00010CD1 File Offset: 0x0000EED1
		public bool IsEmpty
		{
			get
			{
				return this._spatialProvider.GetIsEmpty(this);
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00010CDF File Offset: 0x0000EEDF
		public virtual string AsText()
		{
			return this._spatialProvider.AsText(this);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00010CED File Offset: 0x0000EEED
		internal string AsTextIncludingElevationAndMeasure()
		{
			return this._spatialProvider.AsTextIncludingElevationAndMeasure(this);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00010CFB File Offset: 0x0000EEFB
		public byte[] AsBinary()
		{
			return this._spatialProvider.AsBinary(this);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00010D09 File Offset: 0x0000EF09
		public string AsGml()
		{
			return this._spatialProvider.AsGml(this);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00010D17 File Offset: 0x0000EF17
		public bool SpatialEquals(global::System.Data.Entity.Spatial.DbGeography other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(other, "other");
			return this._spatialProvider.SpatialEquals(this, other);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00010D32 File Offset: 0x0000EF32
		public bool Disjoint(global::System.Data.Entity.Spatial.DbGeography other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(other, "other");
			return this._spatialProvider.Disjoint(this, other);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00010D4D File Offset: 0x0000EF4D
		public bool Intersects(global::System.Data.Entity.Spatial.DbGeography other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(other, "other");
			return this._spatialProvider.Intersects(this, other);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00010D68 File Offset: 0x0000EF68
		public global::System.Data.Entity.Spatial.DbGeography Buffer(double? distance)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<double>(distance, "distance");
			return this._spatialProvider.Buffer(this, distance.Value);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00010D89 File Offset: 0x0000EF89
		public double? Distance(global::System.Data.Entity.Spatial.DbGeography other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(other, "other");
			return new double?(this._spatialProvider.Distance(this, other));
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00010DA9 File Offset: 0x0000EFA9
		public global::System.Data.Entity.Spatial.DbGeography Intersection(global::System.Data.Entity.Spatial.DbGeography other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(other, "other");
			return this._spatialProvider.Intersection(this, other);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		public global::System.Data.Entity.Spatial.DbGeography Union(global::System.Data.Entity.Spatial.DbGeography other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(other, "other");
			return this._spatialProvider.Union(this, other);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00010DDF File Offset: 0x0000EFDF
		public global::System.Data.Entity.Spatial.DbGeography Difference(global::System.Data.Entity.Spatial.DbGeography other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(other, "other");
			return this._spatialProvider.Difference(this, other);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00010DFA File Offset: 0x0000EFFA
		public global::System.Data.Entity.Spatial.DbGeography SymmetricDifference(global::System.Data.Entity.Spatial.DbGeography other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(other, "other");
			return this._spatialProvider.SymmetricDifference(this, other);
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00010E15 File Offset: 0x0000F015
		public int? ElementCount
		{
			get
			{
				return this._spatialProvider.GetElementCount(this);
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00010E23 File Offset: 0x0000F023
		public global::System.Data.Entity.Spatial.DbGeography ElementAt(int index)
		{
			return this._spatialProvider.ElementAt(this, index);
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00010E32 File Offset: 0x0000F032
		public double? Latitude
		{
			get
			{
				return this._spatialProvider.GetLatitude(this);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00010E40 File Offset: 0x0000F040
		public double? Longitude
		{
			get
			{
				return this._spatialProvider.GetLongitude(this);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x00010E4E File Offset: 0x0000F04E
		public double? Elevation
		{
			get
			{
				return this._spatialProvider.GetElevation(this);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00010E5C File Offset: 0x0000F05C
		public double? Measure
		{
			get
			{
				return this._spatialProvider.GetMeasure(this);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00010E6A File Offset: 0x0000F06A
		public double? Length
		{
			get
			{
				return this._spatialProvider.GetLength(this);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00010E78 File Offset: 0x0000F078
		public global::System.Data.Entity.Spatial.DbGeography StartPoint
		{
			get
			{
				return this._spatialProvider.GetStartPoint(this);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00010E86 File Offset: 0x0000F086
		public global::System.Data.Entity.Spatial.DbGeography EndPoint
		{
			get
			{
				return this._spatialProvider.GetEndPoint(this);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00010E94 File Offset: 0x0000F094
		public bool? IsClosed
		{
			get
			{
				return this._spatialProvider.GetIsClosed(this);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00010EA2 File Offset: 0x0000F0A2
		public int? PointCount
		{
			get
			{
				return this._spatialProvider.GetPointCount(this);
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00010EB0 File Offset: 0x0000F0B0
		public global::System.Data.Entity.Spatial.DbGeography PointAt(int index)
		{
			return this._spatialProvider.PointAt(this, index);
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00010EBF File Offset: 0x0000F0BF
		public double? Area
		{
			get
			{
				return this._spatialProvider.GetArea(this);
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00010ECD File Offset: 0x0000F0CD
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "SRID={1};{0}", new object[]
			{
				this.WellKnownValue.WellKnownText ?? base.ToString(),
				this.CoordinateSystemId
			});
		}

		// Token: 0x0400011F RID: 287
		private global::System.Data.Entity.Spatial.DbSpatialServices _spatialProvider;

		// Token: 0x04000120 RID: 288
		private object _providerValue;
	}
}
