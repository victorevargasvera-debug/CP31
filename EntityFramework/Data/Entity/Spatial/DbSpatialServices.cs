using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Spatial
{
	// Token: 0x02000096 RID: 150
	[global::System.Serializable]
	public abstract class DbSpatialServices
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00011644 File Offset: 0x0000F844
		public static global::System.Data.Entity.Spatial.DbSpatialServices Default
		{
			get
			{
				return global::System.Data.Entity.Spatial.DbSpatialServices._defaultServices.Value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00011650 File Offset: 0x0000F850
		public virtual bool NativeTypesAvailable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00011653 File Offset: 0x0000F853
		protected static global::System.Data.Entity.Spatial.DbGeography CreateGeography(global::System.Data.Entity.Spatial.DbSpatialServices spatialServices, object providerValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbSpatialServices>(spatialServices, "spatialServices");
			global::System.Data.Entity.Utilities.Check.NotNull<object>(providerValue, "providerValue");
			return new global::System.Data.Entity.Spatial.DbGeography(spatialServices, providerValue);
		}

		// Token: 0x06000571 RID: 1393
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyFromProviderValue(object providerValue);

		// Token: 0x06000572 RID: 1394
		public abstract object CreateProviderValue(global::System.Data.Entity.Spatial.DbGeographyWellKnownValue wellKnownValue);

		// Token: 0x06000573 RID: 1395
		public abstract global::System.Data.Entity.Spatial.DbGeographyWellKnownValue CreateWellKnownValue(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x06000574 RID: 1396
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyFromBinary(byte[] wellKnownBinary);

		// Token: 0x06000575 RID: 1397
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyFromBinary(byte[] wellKnownBinary, int coordinateSystemId);

		// Token: 0x06000576 RID: 1398
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyLineFromBinary(byte[] lineWellKnownBinary, int coordinateSystemId);

		// Token: 0x06000577 RID: 1399
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyPointFromBinary(byte[] pointWellKnownBinary, int coordinateSystemId);

		// Token: 0x06000578 RID: 1400
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyPolygonFromBinary(byte[] polygonWellKnownBinary, int coordinateSystemId);

		// Token: 0x06000579 RID: 1401
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyMultiLineFromBinary(byte[] multiLineWellKnownBinary, int coordinateSystemId);

		// Token: 0x0600057A RID: 1402
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyMultiPointFromBinary(byte[] multiPointWellKnownBinary, int coordinateSystemId);

		// Token: 0x0600057B RID: 1403
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyMultiPolygonFromBinary(byte[] multiPolygonWellKnownBinary, int coordinateSystemId);

		// Token: 0x0600057C RID: 1404
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyCollectionFromBinary(byte[] geographyCollectionWellKnownBinary, int coordinateSystemId);

		// Token: 0x0600057D RID: 1405
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyFromText(string wellKnownText);

		// Token: 0x0600057E RID: 1406
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyFromText(string wellKnownText, int coordinateSystemId);

		// Token: 0x0600057F RID: 1407
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyLineFromText(string lineWellKnownText, int coordinateSystemId);

		// Token: 0x06000580 RID: 1408
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyPointFromText(string pointWellKnownText, int coordinateSystemId);

		// Token: 0x06000581 RID: 1409
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyPolygonFromText(string polygonWellKnownText, int coordinateSystemId);

		// Token: 0x06000582 RID: 1410
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyMultiLineFromText(string multiLineWellKnownText, int coordinateSystemId);

		// Token: 0x06000583 RID: 1411
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyMultiPointFromText(string multiPointWellKnownText, int coordinateSystemId);

		// Token: 0x06000584 RID: 1412
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyMultiPolygonFromText(string multiPolygonKnownText, int coordinateSystemId);

		// Token: 0x06000585 RID: 1413
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyCollectionFromText(string geographyCollectionWellKnownText, int coordinateSystemId);

		// Token: 0x06000586 RID: 1414
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyFromGml(string geographyMarkup);

		// Token: 0x06000587 RID: 1415
		public abstract global::System.Data.Entity.Spatial.DbGeography GeographyFromGml(string geographyMarkup, int coordinateSystemId);

		// Token: 0x06000588 RID: 1416
		public abstract int GetCoordinateSystemId(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x06000589 RID: 1417
		public abstract int GetDimension(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x0600058A RID: 1418
		public abstract string GetSpatialTypeName(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x0600058B RID: 1419
		public abstract bool GetIsEmpty(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x0600058C RID: 1420
		public abstract string AsText(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x0600058D RID: 1421 RVA: 0x00011674 File Offset: 0x0000F874
		public virtual string AsTextIncludingElevationAndMeasure(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			return null;
		}

		// Token: 0x0600058E RID: 1422
		public abstract byte[] AsBinary(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x0600058F RID: 1423
		public abstract string AsGml(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x06000590 RID: 1424
		public abstract bool SpatialEquals(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography);

		// Token: 0x06000591 RID: 1425
		public abstract bool Disjoint(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography);

		// Token: 0x06000592 RID: 1426
		public abstract bool Intersects(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography);

		// Token: 0x06000593 RID: 1427
		public abstract global::System.Data.Entity.Spatial.DbGeography Buffer(global::System.Data.Entity.Spatial.DbGeography geographyValue, double distance);

		// Token: 0x06000594 RID: 1428
		public abstract double Distance(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography);

		// Token: 0x06000595 RID: 1429
		public abstract global::System.Data.Entity.Spatial.DbGeography Intersection(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography);

		// Token: 0x06000596 RID: 1430
		public abstract global::System.Data.Entity.Spatial.DbGeography Union(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography);

		// Token: 0x06000597 RID: 1431
		public abstract global::System.Data.Entity.Spatial.DbGeography Difference(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography);

		// Token: 0x06000598 RID: 1432
		public abstract global::System.Data.Entity.Spatial.DbGeography SymmetricDifference(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography);

		// Token: 0x06000599 RID: 1433
		public abstract int? GetElementCount(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x0600059A RID: 1434
		public abstract global::System.Data.Entity.Spatial.DbGeography ElementAt(global::System.Data.Entity.Spatial.DbGeography geographyValue, int index);

		// Token: 0x0600059B RID: 1435
		public abstract double? GetLatitude(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x0600059C RID: 1436
		public abstract double? GetLongitude(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x0600059D RID: 1437
		public abstract double? GetElevation(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x0600059E RID: 1438
		public abstract double? GetMeasure(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x0600059F RID: 1439
		public abstract double? GetLength(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x060005A0 RID: 1440
		public abstract global::System.Data.Entity.Spatial.DbGeography GetStartPoint(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x060005A1 RID: 1441
		public abstract global::System.Data.Entity.Spatial.DbGeography GetEndPoint(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x060005A2 RID: 1442
		public abstract bool? GetIsClosed(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x060005A3 RID: 1443
		public abstract int? GetPointCount(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x060005A4 RID: 1444
		public abstract global::System.Data.Entity.Spatial.DbGeography PointAt(global::System.Data.Entity.Spatial.DbGeography geographyValue, int index);

		// Token: 0x060005A5 RID: 1445
		public abstract double? GetArea(global::System.Data.Entity.Spatial.DbGeography geographyValue);

		// Token: 0x060005A6 RID: 1446 RVA: 0x00011677 File Offset: 0x0000F877
		protected static global::System.Data.Entity.Spatial.DbGeometry CreateGeometry(global::System.Data.Entity.Spatial.DbSpatialServices spatialServices, object providerValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbSpatialServices>(spatialServices, "spatialServices");
			global::System.Data.Entity.Utilities.Check.NotNull<object>(providerValue, "providerValue");
			return new global::System.Data.Entity.Spatial.DbGeometry(spatialServices, providerValue);
		}

		// Token: 0x060005A7 RID: 1447
		public abstract object CreateProviderValue(global::System.Data.Entity.Spatial.DbGeometryWellKnownValue wellKnownValue);

		// Token: 0x060005A8 RID: 1448
		public abstract global::System.Data.Entity.Spatial.DbGeometryWellKnownValue CreateWellKnownValue(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005A9 RID: 1449
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryFromProviderValue(object providerValue);

		// Token: 0x060005AA RID: 1450
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryFromBinary(byte[] wellKnownBinary);

		// Token: 0x060005AB RID: 1451
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryFromBinary(byte[] wellKnownBinary, int coordinateSystemId);

		// Token: 0x060005AC RID: 1452
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryLineFromBinary(byte[] lineWellKnownBinary, int coordinateSystemId);

		// Token: 0x060005AD RID: 1453
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryPointFromBinary(byte[] pointWellKnownBinary, int coordinateSystemId);

		// Token: 0x060005AE RID: 1454
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryPolygonFromBinary(byte[] polygonWellKnownBinary, int coordinateSystemId);

		// Token: 0x060005AF RID: 1455
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryMultiLineFromBinary(byte[] multiLineWellKnownBinary, int coordinateSystemId);

		// Token: 0x060005B0 RID: 1456
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryMultiPointFromBinary(byte[] multiPointWellKnownBinary, int coordinateSystemId);

		// Token: 0x060005B1 RID: 1457
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryMultiPolygonFromBinary(byte[] multiPolygonWellKnownBinary, int coordinateSystemId);

		// Token: 0x060005B2 RID: 1458
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryCollectionFromBinary(byte[] geometryCollectionWellKnownBinary, int coordinateSystemId);

		// Token: 0x060005B3 RID: 1459
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryFromText(string wellKnownText);

		// Token: 0x060005B4 RID: 1460
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryFromText(string wellKnownText, int coordinateSystemId);

		// Token: 0x060005B5 RID: 1461
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryLineFromText(string lineWellKnownText, int coordinateSystemId);

		// Token: 0x060005B6 RID: 1462
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryPointFromText(string pointWellKnownText, int coordinateSystemId);

		// Token: 0x060005B7 RID: 1463
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryPolygonFromText(string polygonWellKnownText, int coordinateSystemId);

		// Token: 0x060005B8 RID: 1464
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryMultiLineFromText(string multiLineWellKnownText, int coordinateSystemId);

		// Token: 0x060005B9 RID: 1465
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryMultiPointFromText(string multiPointWellKnownText, int coordinateSystemId);

		// Token: 0x060005BA RID: 1466
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryMultiPolygonFromText(string multiPolygonKnownText, int coordinateSystemId);

		// Token: 0x060005BB RID: 1467
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryCollectionFromText(string geometryCollectionWellKnownText, int coordinateSystemId);

		// Token: 0x060005BC RID: 1468
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryFromGml(string geometryMarkup);

		// Token: 0x060005BD RID: 1469
		public abstract global::System.Data.Entity.Spatial.DbGeometry GeometryFromGml(string geometryMarkup, int coordinateSystemId);

		// Token: 0x060005BE RID: 1470
		public abstract int GetCoordinateSystemId(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005BF RID: 1471
		public abstract global::System.Data.Entity.Spatial.DbGeometry GetBoundary(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005C0 RID: 1472
		public abstract int GetDimension(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005C1 RID: 1473
		public abstract global::System.Data.Entity.Spatial.DbGeometry GetEnvelope(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005C2 RID: 1474
		public abstract string GetSpatialTypeName(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005C3 RID: 1475
		public abstract bool GetIsEmpty(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005C4 RID: 1476
		public abstract bool GetIsSimple(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005C5 RID: 1477
		public abstract bool GetIsValid(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005C6 RID: 1478
		public abstract string AsText(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005C7 RID: 1479 RVA: 0x00011698 File Offset: 0x0000F898
		public virtual string AsTextIncludingElevationAndMeasure(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			return null;
		}

		// Token: 0x060005C8 RID: 1480
		public abstract byte[] AsBinary(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005C9 RID: 1481
		public abstract string AsGml(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005CA RID: 1482
		public abstract bool SpatialEquals(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry);

		// Token: 0x060005CB RID: 1483
		public abstract bool Disjoint(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry);

		// Token: 0x060005CC RID: 1484
		public abstract bool Intersects(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry);

		// Token: 0x060005CD RID: 1485
		public abstract bool Touches(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry);

		// Token: 0x060005CE RID: 1486
		public abstract bool Crosses(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry);

		// Token: 0x060005CF RID: 1487
		public abstract bool Within(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry);

		// Token: 0x060005D0 RID: 1488
		public abstract bool Contains(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry);

		// Token: 0x060005D1 RID: 1489
		public abstract bool Overlaps(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry);

		// Token: 0x060005D2 RID: 1490
		public abstract bool Relate(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry, string matrix);

		// Token: 0x060005D3 RID: 1491
		public abstract global::System.Data.Entity.Spatial.DbGeometry Buffer(global::System.Data.Entity.Spatial.DbGeometry geometryValue, double distance);

		// Token: 0x060005D4 RID: 1492
		public abstract double Distance(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry);

		// Token: 0x060005D5 RID: 1493
		public abstract global::System.Data.Entity.Spatial.DbGeometry GetConvexHull(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005D6 RID: 1494
		public abstract global::System.Data.Entity.Spatial.DbGeometry Intersection(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry);

		// Token: 0x060005D7 RID: 1495
		public abstract global::System.Data.Entity.Spatial.DbGeometry Union(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry);

		// Token: 0x060005D8 RID: 1496
		public abstract global::System.Data.Entity.Spatial.DbGeometry Difference(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry);

		// Token: 0x060005D9 RID: 1497
		public abstract global::System.Data.Entity.Spatial.DbGeometry SymmetricDifference(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry);

		// Token: 0x060005DA RID: 1498
		public abstract int? GetElementCount(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005DB RID: 1499
		public abstract global::System.Data.Entity.Spatial.DbGeometry ElementAt(global::System.Data.Entity.Spatial.DbGeometry geometryValue, int index);

		// Token: 0x060005DC RID: 1500
		public abstract double? GetXCoordinate(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005DD RID: 1501
		public abstract double? GetYCoordinate(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005DE RID: 1502
		public abstract double? GetElevation(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005DF RID: 1503
		public abstract double? GetMeasure(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005E0 RID: 1504
		public abstract double? GetLength(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005E1 RID: 1505
		public abstract global::System.Data.Entity.Spatial.DbGeometry GetStartPoint(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005E2 RID: 1506
		public abstract global::System.Data.Entity.Spatial.DbGeometry GetEndPoint(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005E3 RID: 1507
		public abstract bool? GetIsClosed(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005E4 RID: 1508
		public abstract bool? GetIsRing(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005E5 RID: 1509
		public abstract int? GetPointCount(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005E6 RID: 1510
		public abstract global::System.Data.Entity.Spatial.DbGeometry PointAt(global::System.Data.Entity.Spatial.DbGeometry geometryValue, int index);

		// Token: 0x060005E7 RID: 1511
		public abstract double? GetArea(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005E8 RID: 1512
		public abstract global::System.Data.Entity.Spatial.DbGeometry GetCentroid(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005E9 RID: 1513
		public abstract global::System.Data.Entity.Spatial.DbGeometry GetPointOnSurface(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005EA RID: 1514
		public abstract global::System.Data.Entity.Spatial.DbGeometry GetExteriorRing(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005EB RID: 1515
		public abstract int? GetInteriorRingCount(global::System.Data.Entity.Spatial.DbGeometry geometryValue);

		// Token: 0x060005EC RID: 1516
		public abstract global::System.Data.Entity.Spatial.DbGeometry InteriorRingAt(global::System.Data.Entity.Spatial.DbGeometry geometryValue, int index);

		// Token: 0x04000129 RID: 297
		private static readonly global::System.Lazy<global::System.Data.Entity.Spatial.DbSpatialServices> _defaultServices = new global::System.Lazy<global::System.Data.Entity.Spatial.DbSpatialServices>(() => new global::System.Data.Entity.Spatial.SpatialServicesLoader(global::System.Data.Entity.DbConfiguration.DependencyResolver).LoadDefaultServices(), true);
	}
}
