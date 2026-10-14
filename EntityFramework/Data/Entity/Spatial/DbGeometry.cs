using System;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Data.Entity.Spatial
{
	// Token: 0x02000093 RID: 147
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class DbGeometry
	{
		// Token: 0x06000515 RID: 1301 RVA: 0x00010F45 File Offset: 0x0000F145
		internal DbGeometry()
		{
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00010F4D File Offset: 0x0000F14D
		internal DbGeometry(global::System.Data.Entity.Spatial.DbSpatialServices spatialServices, object spatialProviderValue)
		{
			this._spatialProvider = spatialServices;
			this._providerValue = spatialProviderValue;
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00010F63 File Offset: 0x0000F163
		public static int DefaultCoordinateSystemId
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00010F66 File Offset: 0x0000F166
		public object ProviderValue
		{
			get
			{
				return this._providerValue;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00010F6E File Offset: 0x0000F16E
		public virtual global::System.Data.Entity.Spatial.DbSpatialServices Provider
		{
			get
			{
				return this._spatialProvider;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00010F76 File Offset: 0x0000F176
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00010F84 File Offset: 0x0000F184
		[global::System.Runtime.Serialization.DataMember(Name = "Geometry")]
		public global::System.Data.Entity.Spatial.DbGeometryWellKnownValue WellKnownValue
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

		// Token: 0x0600051C RID: 1308 RVA: 0x00010FBE File Offset: 0x0000F1BE
		public static global::System.Data.Entity.Spatial.DbGeometry FromBinary(byte[] wellKnownBinary)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(wellKnownBinary, "wellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryFromBinary(wellKnownBinary);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00010FD7 File Offset: 0x0000F1D7
		public static global::System.Data.Entity.Spatial.DbGeometry FromBinary(byte[] wellKnownBinary, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(wellKnownBinary, "wellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryFromBinary(wellKnownBinary, coordinateSystemId);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00010FF1 File Offset: 0x0000F1F1
		public static global::System.Data.Entity.Spatial.DbGeometry LineFromBinary(byte[] lineWellKnownBinary, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(lineWellKnownBinary, "lineWellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryLineFromBinary(lineWellKnownBinary, coordinateSystemId);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0001100B File Offset: 0x0000F20B
		public static global::System.Data.Entity.Spatial.DbGeometry PointFromBinary(byte[] pointWellKnownBinary, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(pointWellKnownBinary, "pointWellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryPointFromBinary(pointWellKnownBinary, coordinateSystemId);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00011025 File Offset: 0x0000F225
		public static global::System.Data.Entity.Spatial.DbGeometry PolygonFromBinary(byte[] polygonWellKnownBinary, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(polygonWellKnownBinary, "polygonWellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryPolygonFromBinary(polygonWellKnownBinary, coordinateSystemId);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0001103F File Offset: 0x0000F23F
		public static global::System.Data.Entity.Spatial.DbGeometry MultiLineFromBinary(byte[] multiLineWellKnownBinary, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(multiLineWellKnownBinary, "multiLineWellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryMultiLineFromBinary(multiLineWellKnownBinary, coordinateSystemId);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00011059 File Offset: 0x0000F259
		public static global::System.Data.Entity.Spatial.DbGeometry MultiPointFromBinary(byte[] multiPointWellKnownBinary, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(multiPointWellKnownBinary, "multiPointWellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryMultiPointFromBinary(multiPointWellKnownBinary, coordinateSystemId);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00011073 File Offset: 0x0000F273
		public static global::System.Data.Entity.Spatial.DbGeometry MultiPolygonFromBinary(byte[] multiPolygonWellKnownBinary, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(multiPolygonWellKnownBinary, "multiPolygonWellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryMultiPolygonFromBinary(multiPolygonWellKnownBinary, coordinateSystemId);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0001108D File Offset: 0x0000F28D
		public static global::System.Data.Entity.Spatial.DbGeometry GeometryCollectionFromBinary(byte[] geometryCollectionWellKnownBinary, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(geometryCollectionWellKnownBinary, "geometryCollectionWellKnownBinary");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryCollectionFromBinary(geometryCollectionWellKnownBinary, coordinateSystemId);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000110A7 File Offset: 0x0000F2A7
		public static global::System.Data.Entity.Spatial.DbGeometry FromGml(string geometryMarkup)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(geometryMarkup, "geometryMarkup");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryFromGml(geometryMarkup);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000110C0 File Offset: 0x0000F2C0
		public static global::System.Data.Entity.Spatial.DbGeometry FromGml(string geometryMarkup, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(geometryMarkup, "geometryMarkup");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryFromGml(geometryMarkup, coordinateSystemId);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x000110DA File Offset: 0x0000F2DA
		public static global::System.Data.Entity.Spatial.DbGeometry FromText(string wellKnownText)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(wellKnownText, "wellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryFromText(wellKnownText);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x000110F3 File Offset: 0x0000F2F3
		public static global::System.Data.Entity.Spatial.DbGeometry FromText(string wellKnownText, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(wellKnownText, "wellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryFromText(wellKnownText, coordinateSystemId);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0001110D File Offset: 0x0000F30D
		public static global::System.Data.Entity.Spatial.DbGeometry LineFromText(string lineWellKnownText, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(lineWellKnownText, "lineWellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryLineFromText(lineWellKnownText, coordinateSystemId);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00011127 File Offset: 0x0000F327
		public static global::System.Data.Entity.Spatial.DbGeometry PointFromText(string pointWellKnownText, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(pointWellKnownText, "pointWellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryPointFromText(pointWellKnownText, coordinateSystemId);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00011141 File Offset: 0x0000F341
		public static global::System.Data.Entity.Spatial.DbGeometry PolygonFromText(string polygonWellKnownText, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(polygonWellKnownText, "polygonWellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryPolygonFromText(polygonWellKnownText, coordinateSystemId);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0001115B File Offset: 0x0000F35B
		public static global::System.Data.Entity.Spatial.DbGeometry MultiLineFromText(string multiLineWellKnownText, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(multiLineWellKnownText, "multiLineWellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryMultiLineFromText(multiLineWellKnownText, coordinateSystemId);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00011175 File Offset: 0x0000F375
		public static global::System.Data.Entity.Spatial.DbGeometry MultiPointFromText(string multiPointWellKnownText, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(multiPointWellKnownText, "multiPointWellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryMultiPointFromText(multiPointWellKnownText, coordinateSystemId);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0001118F File Offset: 0x0000F38F
		public static global::System.Data.Entity.Spatial.DbGeometry MultiPolygonFromText(string multiPolygonWellKnownText, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(multiPolygonWellKnownText, "multiPolygonWellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryMultiPolygonFromText(multiPolygonWellKnownText, coordinateSystemId);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x000111A9 File Offset: 0x0000F3A9
		public static global::System.Data.Entity.Spatial.DbGeometry GeometryCollectionFromText(string geometryCollectionWellKnownText, int coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(geometryCollectionWellKnownText, "geometryCollectionWellKnownText");
			return global::System.Data.Entity.Spatial.DbSpatialServices.Default.GeometryCollectionFromText(geometryCollectionWellKnownText, coordinateSystemId);
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x000111C3 File Offset: 0x0000F3C3
		public int CoordinateSystemId
		{
			get
			{
				return this._spatialProvider.GetCoordinateSystemId(this);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x000111D1 File Offset: 0x0000F3D1
		public global::System.Data.Entity.Spatial.DbGeometry Boundary
		{
			get
			{
				return this._spatialProvider.GetBoundary(this);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x000111DF File Offset: 0x0000F3DF
		public int Dimension
		{
			get
			{
				return this._spatialProvider.GetDimension(this);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x000111ED File Offset: 0x0000F3ED
		public global::System.Data.Entity.Spatial.DbGeometry Envelope
		{
			get
			{
				return this._spatialProvider.GetEnvelope(this);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x000111FB File Offset: 0x0000F3FB
		public string SpatialTypeName
		{
			get
			{
				return this._spatialProvider.GetSpatialTypeName(this);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00011209 File Offset: 0x0000F409
		public bool IsEmpty
		{
			get
			{
				return this._spatialProvider.GetIsEmpty(this);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00011217 File Offset: 0x0000F417
		public bool IsSimple
		{
			get
			{
				return this._spatialProvider.GetIsSimple(this);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00011225 File Offset: 0x0000F425
		public bool IsValid
		{
			get
			{
				return this._spatialProvider.GetIsValid(this);
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00011233 File Offset: 0x0000F433
		public virtual string AsText()
		{
			return this._spatialProvider.AsText(this);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00011241 File Offset: 0x0000F441
		internal string AsTextIncludingElevationAndMeasure()
		{
			return this._spatialProvider.AsTextIncludingElevationAndMeasure(this);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0001124F File Offset: 0x0000F44F
		public byte[] AsBinary()
		{
			return this._spatialProvider.AsBinary(this);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0001125D File Offset: 0x0000F45D
		public string AsGml()
		{
			return this._spatialProvider.AsGml(this);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0001126B File Offset: 0x0000F46B
		public bool SpatialEquals(global::System.Data.Entity.Spatial.DbGeometry other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(other, "other");
			return this._spatialProvider.SpatialEquals(this, other);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00011286 File Offset: 0x0000F486
		public bool Disjoint(global::System.Data.Entity.Spatial.DbGeometry other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(other, "other");
			return this._spatialProvider.Disjoint(this, other);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000112A1 File Offset: 0x0000F4A1
		public bool Intersects(global::System.Data.Entity.Spatial.DbGeometry other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(other, "other");
			return this._spatialProvider.Intersects(this, other);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000112BC File Offset: 0x0000F4BC
		public bool Touches(global::System.Data.Entity.Spatial.DbGeometry other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(other, "other");
			return this._spatialProvider.Touches(this, other);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000112D7 File Offset: 0x0000F4D7
		public bool Crosses(global::System.Data.Entity.Spatial.DbGeometry other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(other, "other");
			return this._spatialProvider.Crosses(this, other);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000112F2 File Offset: 0x0000F4F2
		public bool Within(global::System.Data.Entity.Spatial.DbGeometry other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(other, "other");
			return this._spatialProvider.Within(this, other);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0001130D File Offset: 0x0000F50D
		public bool Contains(global::System.Data.Entity.Spatial.DbGeometry other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(other, "other");
			return this._spatialProvider.Contains(this, other);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00011328 File Offset: 0x0000F528
		public bool Overlaps(global::System.Data.Entity.Spatial.DbGeometry other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(other, "other");
			return this._spatialProvider.Overlaps(this, other);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00011343 File Offset: 0x0000F543
		public bool Relate(global::System.Data.Entity.Spatial.DbGeometry other, string matrix)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(other, "other");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(matrix, "matrix");
			return this._spatialProvider.Relate(this, other, matrix);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0001136B File Offset: 0x0000F56B
		public global::System.Data.Entity.Spatial.DbGeometry Buffer(double? distance)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<double>(distance, "distance");
			return this._spatialProvider.Buffer(this, distance.Value);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0001138C File Offset: 0x0000F58C
		public double? Distance(global::System.Data.Entity.Spatial.DbGeometry other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(other, "other");
			return new double?(this._spatialProvider.Distance(this, other));
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x000113AC File Offset: 0x0000F5AC
		public global::System.Data.Entity.Spatial.DbGeometry ConvexHull
		{
			get
			{
				return this._spatialProvider.GetConvexHull(this);
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000113BA File Offset: 0x0000F5BA
		public global::System.Data.Entity.Spatial.DbGeometry Intersection(global::System.Data.Entity.Spatial.DbGeometry other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(other, "other");
			return this._spatialProvider.Intersection(this, other);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000113D5 File Offset: 0x0000F5D5
		public global::System.Data.Entity.Spatial.DbGeometry Union(global::System.Data.Entity.Spatial.DbGeometry other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(other, "other");
			return this._spatialProvider.Union(this, other);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x000113F0 File Offset: 0x0000F5F0
		public global::System.Data.Entity.Spatial.DbGeometry Difference(global::System.Data.Entity.Spatial.DbGeometry other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(other, "other");
			return this._spatialProvider.Difference(this, other);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0001140B File Offset: 0x0000F60B
		public global::System.Data.Entity.Spatial.DbGeometry SymmetricDifference(global::System.Data.Entity.Spatial.DbGeometry other)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(other, "other");
			return this._spatialProvider.SymmetricDifference(this, other);
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00011426 File Offset: 0x0000F626
		public int? ElementCount
		{
			get
			{
				return this._spatialProvider.GetElementCount(this);
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00011434 File Offset: 0x0000F634
		public global::System.Data.Entity.Spatial.DbGeometry ElementAt(int index)
		{
			return this._spatialProvider.ElementAt(this, index);
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00011443 File Offset: 0x0000F643
		public double? XCoordinate
		{
			get
			{
				return this._spatialProvider.GetXCoordinate(this);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00011451 File Offset: 0x0000F651
		public double? YCoordinate
		{
			get
			{
				return this._spatialProvider.GetYCoordinate(this);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x0001145F File Offset: 0x0000F65F
		public double? Elevation
		{
			get
			{
				return this._spatialProvider.GetElevation(this);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0001146D File Offset: 0x0000F66D
		public double? Measure
		{
			get
			{
				return this._spatialProvider.GetMeasure(this);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x0001147B File Offset: 0x0000F67B
		public double? Length
		{
			get
			{
				return this._spatialProvider.GetLength(this);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00011489 File Offset: 0x0000F689
		public global::System.Data.Entity.Spatial.DbGeometry StartPoint
		{
			get
			{
				return this._spatialProvider.GetStartPoint(this);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00011497 File Offset: 0x0000F697
		public global::System.Data.Entity.Spatial.DbGeometry EndPoint
		{
			get
			{
				return this._spatialProvider.GetEndPoint(this);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x000114A5 File Offset: 0x0000F6A5
		public bool? IsClosed
		{
			get
			{
				return this._spatialProvider.GetIsClosed(this);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x000114B3 File Offset: 0x0000F6B3
		public bool? IsRing
		{
			get
			{
				return this._spatialProvider.GetIsRing(this);
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x000114C1 File Offset: 0x0000F6C1
		public int? PointCount
		{
			get
			{
				return this._spatialProvider.GetPointCount(this);
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x000114CF File Offset: 0x0000F6CF
		public global::System.Data.Entity.Spatial.DbGeometry PointAt(int index)
		{
			return this._spatialProvider.PointAt(this, index);
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x000114DE File Offset: 0x0000F6DE
		public double? Area
		{
			get
			{
				return this._spatialProvider.GetArea(this);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x000114EC File Offset: 0x0000F6EC
		public global::System.Data.Entity.Spatial.DbGeometry Centroid
		{
			get
			{
				return this._spatialProvider.GetCentroid(this);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x000114FA File Offset: 0x0000F6FA
		public global::System.Data.Entity.Spatial.DbGeometry PointOnSurface
		{
			get
			{
				return this._spatialProvider.GetPointOnSurface(this);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x00011508 File Offset: 0x0000F708
		public global::System.Data.Entity.Spatial.DbGeometry ExteriorRing
		{
			get
			{
				return this._spatialProvider.GetExteriorRing(this);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00011516 File Offset: 0x0000F716
		public int? InteriorRingCount
		{
			get
			{
				return this._spatialProvider.GetInteriorRingCount(this);
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00011524 File Offset: 0x0000F724
		public global::System.Data.Entity.Spatial.DbGeometry InteriorRingAt(int index)
		{
			return this._spatialProvider.InteriorRingAt(this, index);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00011533 File Offset: 0x0000F733
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "SRID={1};{0}", new object[]
			{
				this.WellKnownValue.WellKnownText ?? base.ToString(),
				this.CoordinateSystemId
			});
		}

		// Token: 0x04000124 RID: 292
		private global::System.Data.Entity.Spatial.DbSpatialServices _spatialProvider;

		// Token: 0x04000125 RID: 293
		private object _providerValue;
	}
}
