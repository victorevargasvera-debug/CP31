using System;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Spatial
{
	// Token: 0x02000097 RID: 151
	[global::System.Serializable]
	internal sealed class DefaultSpatialServices : global::System.Data.Entity.Spatial.DbSpatialServices
	{
		// Token: 0x060005EF RID: 1519 RVA: 0x000116C0 File Offset: 0x0000F8C0
		private DefaultSpatialServices()
		{
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000116C8 File Offset: 0x0000F8C8
		private static global::System.Exception SpatialServicesUnavailable()
		{
			return new global::System.NotImplementedException(global::System.Data.Entity.Resources.Strings.SpatialProviderNotUsable);
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000116D4 File Offset: 0x0000F8D4
		private static global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues CheckProviderValue(object providerValue)
		{
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues readOnlySpatialValues = providerValue as global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues;
			if (readOnlySpatialValues == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Spatial_ProviderValueNotCompatibleWithSpatialServices, "providerValue");
			}
			return readOnlySpatialValues;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x000116F0 File Offset: 0x0000F8F0
		private static global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues CheckCompatible(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			if (geographyValue != null)
			{
				global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues readOnlySpatialValues = geographyValue.ProviderValue as global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues;
				if (readOnlySpatialValues != null)
				{
					return readOnlySpatialValues;
				}
			}
			throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Spatial_GeographyValueNotCompatibleWithSpatialServices, "geographyValue");
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00011720 File Offset: 0x0000F920
		private static global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues CheckCompatible(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			if (geometryValue != null)
			{
				global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues readOnlySpatialValues = geometryValue.ProviderValue as global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues;
				if (readOnlySpatialValues != null)
				{
					return readOnlySpatialValues;
				}
			}
			throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Spatial_GeometryValueNotCompatibleWithSpatialServices, "geometryValue");
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00011750 File Offset: 0x0000F950
		public override global::System.Data.Entity.Spatial.DbGeography GeographyFromProviderValue(object providerValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(providerValue, "providerValue");
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues providerValue2 = global::System.Data.Entity.Spatial.DefaultSpatialServices.CheckProviderValue(providerValue);
			return global::System.Data.Entity.Spatial.DbSpatialServices.CreateGeography(this, providerValue2);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00011777 File Offset: 0x0000F977
		public override object CreateProviderValue(global::System.Data.Entity.Spatial.DbGeographyWellKnownValue wellKnownValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeographyWellKnownValue>(wellKnownValue, "wellKnownValue");
			return new global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues(wellKnownValue.CoordinateSystemId, wellKnownValue.WellKnownText, wellKnownValue.WellKnownBinary, null);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x000117A0 File Offset: 0x0000F9A0
		public override global::System.Data.Entity.Spatial.DbGeographyWellKnownValue CreateWellKnownValue(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues readOnlySpatialValues = global::System.Data.Entity.Spatial.DefaultSpatialServices.CheckCompatible(geographyValue);
			return new global::System.Data.Entity.Spatial.DbGeographyWellKnownValue
			{
				CoordinateSystemId = readOnlySpatialValues.CoordinateSystemId,
				WellKnownBinary = readOnlySpatialValues.CloneBinary(),
				WellKnownText = readOnlySpatialValues.Text
			};
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x000117EC File Offset: 0x0000F9EC
		public override global::System.Data.Entity.Spatial.DbGeography GeographyFromBinary(byte[] geographyBinary)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(geographyBinary, "geographyBinary");
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues providerValue = new global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues(global::System.Data.Entity.Spatial.DbGeography.DefaultCoordinateSystemId, null, geographyBinary, null);
			return global::System.Data.Entity.Spatial.DbSpatialServices.CreateGeography(this, providerValue);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0001181C File Offset: 0x0000FA1C
		public override global::System.Data.Entity.Spatial.DbGeography GeographyFromBinary(byte[] geographyBinary, int spatialReferenceSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(geographyBinary, "geographyBinary");
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues providerValue = new global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues(spatialReferenceSystemId, null, geographyBinary, null);
			return global::System.Data.Entity.Spatial.DbSpatialServices.CreateGeography(this, providerValue);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00011846 File Offset: 0x0000FA46
		public override global::System.Data.Entity.Spatial.DbGeography GeographyLineFromBinary(byte[] geographyBinary, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0001184D File Offset: 0x0000FA4D
		public override global::System.Data.Entity.Spatial.DbGeography GeographyPointFromBinary(byte[] geographyBinary, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00011854 File Offset: 0x0000FA54
		public override global::System.Data.Entity.Spatial.DbGeography GeographyPolygonFromBinary(byte[] geographyBinary, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0001185B File Offset: 0x0000FA5B
		public override global::System.Data.Entity.Spatial.DbGeography GeographyMultiLineFromBinary(byte[] geographyBinary, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00011862 File Offset: 0x0000FA62
		public override global::System.Data.Entity.Spatial.DbGeography GeographyMultiPointFromBinary(byte[] geographyBinary, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00011869 File Offset: 0x0000FA69
		public override global::System.Data.Entity.Spatial.DbGeography GeographyMultiPolygonFromBinary(byte[] geographyBinary, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00011870 File Offset: 0x0000FA70
		public override global::System.Data.Entity.Spatial.DbGeography GeographyCollectionFromBinary(byte[] geographyBinary, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00011878 File Offset: 0x0000FA78
		public override global::System.Data.Entity.Spatial.DbGeography GeographyFromText(string geographyText)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(geographyText, "geographyText");
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues providerValue = new global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues(global::System.Data.Entity.Spatial.DbGeography.DefaultCoordinateSystemId, geographyText, null, null);
			return global::System.Data.Entity.Spatial.DbSpatialServices.CreateGeography(this, providerValue);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x000118A8 File Offset: 0x0000FAA8
		public override global::System.Data.Entity.Spatial.DbGeography GeographyFromText(string geographyText, int spatialReferenceSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(geographyText, "geographyText");
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues providerValue = new global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues(spatialReferenceSystemId, geographyText, null, null);
			return global::System.Data.Entity.Spatial.DbSpatialServices.CreateGeography(this, providerValue);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x000118D2 File Offset: 0x0000FAD2
		public override global::System.Data.Entity.Spatial.DbGeography GeographyLineFromText(string geographyText, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x000118D9 File Offset: 0x0000FAD9
		public override global::System.Data.Entity.Spatial.DbGeography GeographyPointFromText(string geographyText, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x000118E0 File Offset: 0x0000FAE0
		public override global::System.Data.Entity.Spatial.DbGeography GeographyPolygonFromText(string geographyText, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x000118E7 File Offset: 0x0000FAE7
		public override global::System.Data.Entity.Spatial.DbGeography GeographyMultiLineFromText(string geographyText, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000118EE File Offset: 0x0000FAEE
		public override global::System.Data.Entity.Spatial.DbGeography GeographyMultiPointFromText(string geographyText, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000118F5 File Offset: 0x0000FAF5
		public override global::System.Data.Entity.Spatial.DbGeography GeographyMultiPolygonFromText(string multiPolygonKnownText, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000118FC File Offset: 0x0000FAFC
		public override global::System.Data.Entity.Spatial.DbGeography GeographyCollectionFromText(string geographyText, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00011904 File Offset: 0x0000FB04
		public override global::System.Data.Entity.Spatial.DbGeography GeographyFromGml(string geographyMarkup)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(geographyMarkup, "geographyMarkup");
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues providerValue = new global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues(global::System.Data.Entity.Spatial.DbGeography.DefaultCoordinateSystemId, null, null, geographyMarkup);
			return global::System.Data.Entity.Spatial.DbSpatialServices.CreateGeography(this, providerValue);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00011934 File Offset: 0x0000FB34
		public override global::System.Data.Entity.Spatial.DbGeography GeographyFromGml(string geographyMarkup, int spatialReferenceSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(geographyMarkup, "geographyMarkup");
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues providerValue = new global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues(spatialReferenceSystemId, null, null, geographyMarkup);
			return global::System.Data.Entity.Spatial.DbSpatialServices.CreateGeography(this, providerValue);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0001195E File Offset: 0x0000FB5E
		public override int GetCoordinateSystemId(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			return global::System.Data.Entity.Spatial.DefaultSpatialServices.CheckCompatible(geographyValue).CoordinateSystemId;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00011977 File Offset: 0x0000FB77
		public override int GetDimension(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0001197E File Offset: 0x0000FB7E
		public override string GetSpatialTypeName(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00011985 File Offset: 0x0000FB85
		public override bool GetIsEmpty(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0001198C File Offset: 0x0000FB8C
		public override string AsText(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			return global::System.Data.Entity.Spatial.DefaultSpatialServices.CheckCompatible(geographyValue).Text;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000119A5 File Offset: 0x0000FBA5
		public override byte[] AsBinary(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			return global::System.Data.Entity.Spatial.DefaultSpatialServices.CheckCompatible(geographyValue).CloneBinary();
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000119BE File Offset: 0x0000FBBE
		public override string AsGml(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			return global::System.Data.Entity.Spatial.DefaultSpatialServices.CheckCompatible(geographyValue).GML;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000119D7 File Offset: 0x0000FBD7
		public override bool SpatialEquals(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000119DE File Offset: 0x0000FBDE
		public override bool Disjoint(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x000119E5 File Offset: 0x0000FBE5
		public override bool Intersects(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x000119EC File Offset: 0x0000FBEC
		public override global::System.Data.Entity.Spatial.DbGeography Buffer(global::System.Data.Entity.Spatial.DbGeography geographyValue, double distance)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000119F3 File Offset: 0x0000FBF3
		public override double Distance(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000119FA File Offset: 0x0000FBFA
		public override global::System.Data.Entity.Spatial.DbGeography Intersection(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00011A01 File Offset: 0x0000FC01
		public override global::System.Data.Entity.Spatial.DbGeography Union(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00011A08 File Offset: 0x0000FC08
		public override global::System.Data.Entity.Spatial.DbGeography Difference(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00011A0F File Offset: 0x0000FC0F
		public override global::System.Data.Entity.Spatial.DbGeography SymmetricDifference(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00011A16 File Offset: 0x0000FC16
		public override int? GetElementCount(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00011A1D File Offset: 0x0000FC1D
		public override global::System.Data.Entity.Spatial.DbGeography ElementAt(global::System.Data.Entity.Spatial.DbGeography geographyValue, int index)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00011A24 File Offset: 0x0000FC24
		public override double? GetLatitude(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00011A2B File Offset: 0x0000FC2B
		public override double? GetLongitude(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00011A32 File Offset: 0x0000FC32
		public override double? GetElevation(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00011A39 File Offset: 0x0000FC39
		public override double? GetMeasure(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00011A40 File Offset: 0x0000FC40
		public override double? GetLength(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00011A47 File Offset: 0x0000FC47
		public override global::System.Data.Entity.Spatial.DbGeography GetEndPoint(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00011A4E File Offset: 0x0000FC4E
		public override global::System.Data.Entity.Spatial.DbGeography GetStartPoint(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00011A55 File Offset: 0x0000FC55
		public override bool? GetIsClosed(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00011A5C File Offset: 0x0000FC5C
		public override int? GetPointCount(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00011A63 File Offset: 0x0000FC63
		public override global::System.Data.Entity.Spatial.DbGeography PointAt(global::System.Data.Entity.Spatial.DbGeography geographyValue, int index)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00011A6A File Offset: 0x0000FC6A
		public override double? GetArea(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00011A71 File Offset: 0x0000FC71
		public override object CreateProviderValue(global::System.Data.Entity.Spatial.DbGeometryWellKnownValue wellKnownValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometryWellKnownValue>(wellKnownValue, "wellKnownValue");
			return new global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues(wellKnownValue.CoordinateSystemId, wellKnownValue.WellKnownText, wellKnownValue.WellKnownBinary, null);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00011A98 File Offset: 0x0000FC98
		public override global::System.Data.Entity.Spatial.DbGeometryWellKnownValue CreateWellKnownValue(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues readOnlySpatialValues = global::System.Data.Entity.Spatial.DefaultSpatialServices.CheckCompatible(geometryValue);
			return new global::System.Data.Entity.Spatial.DbGeometryWellKnownValue
			{
				CoordinateSystemId = readOnlySpatialValues.CoordinateSystemId,
				WellKnownBinary = readOnlySpatialValues.CloneBinary(),
				WellKnownText = readOnlySpatialValues.Text
			};
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00011AE4 File Offset: 0x0000FCE4
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryFromProviderValue(object providerValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(providerValue, "providerValue");
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues providerValue2 = global::System.Data.Entity.Spatial.DefaultSpatialServices.CheckProviderValue(providerValue);
			return global::System.Data.Entity.Spatial.DbSpatialServices.CreateGeometry(this, providerValue2);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00011B0C File Offset: 0x0000FD0C
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryFromBinary(byte[] geometryBinary)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(geometryBinary, "geometryBinary");
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues providerValue = new global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues(global::System.Data.Entity.Spatial.DbGeometry.DefaultCoordinateSystemId, null, geometryBinary, null);
			return global::System.Data.Entity.Spatial.DbSpatialServices.CreateGeometry(this, providerValue);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00011B3C File Offset: 0x0000FD3C
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryFromBinary(byte[] geometryBinary, int spatialReferenceSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<byte[]>(geometryBinary, "geometryBinary");
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues providerValue = new global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues(spatialReferenceSystemId, null, geometryBinary, null);
			return global::System.Data.Entity.Spatial.DbSpatialServices.CreateGeometry(this, providerValue);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00011B66 File Offset: 0x0000FD66
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryLineFromBinary(byte[] geometryBinary, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00011B6D File Offset: 0x0000FD6D
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryPointFromBinary(byte[] geometryBinary, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00011B74 File Offset: 0x0000FD74
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryPolygonFromBinary(byte[] geometryBinary, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00011B7B File Offset: 0x0000FD7B
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryMultiLineFromBinary(byte[] geometryBinary, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00011B82 File Offset: 0x0000FD82
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryMultiPointFromBinary(byte[] geometryBinary, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00011B89 File Offset: 0x0000FD89
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryMultiPolygonFromBinary(byte[] geometryBinary, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00011B90 File Offset: 0x0000FD90
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryCollectionFromBinary(byte[] geometryBinary, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00011B98 File Offset: 0x0000FD98
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryFromText(string geometryText)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(geometryText, "geometryText");
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues providerValue = new global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues(global::System.Data.Entity.Spatial.DbGeometry.DefaultCoordinateSystemId, geometryText, null, null);
			return global::System.Data.Entity.Spatial.DbSpatialServices.CreateGeometry(this, providerValue);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryFromText(string geometryText, int spatialReferenceSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(geometryText, "geometryText");
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues providerValue = new global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues(spatialReferenceSystemId, geometryText, null, null);
			return global::System.Data.Entity.Spatial.DbSpatialServices.CreateGeometry(this, providerValue);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00011BF2 File Offset: 0x0000FDF2
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryLineFromText(string geometryText, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00011BF9 File Offset: 0x0000FDF9
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryPointFromText(string geometryText, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00011C00 File Offset: 0x0000FE00
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryPolygonFromText(string geometryText, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00011C07 File Offset: 0x0000FE07
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryMultiLineFromText(string geometryText, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00011C0E File Offset: 0x0000FE0E
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryMultiPointFromText(string geometryText, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00011C15 File Offset: 0x0000FE15
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryMultiPolygonFromText(string geometryText, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00011C1C File Offset: 0x0000FE1C
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryCollectionFromText(string geometryText, int spatialReferenceSystemId)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00011C24 File Offset: 0x0000FE24
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryFromGml(string geometryMarkup)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(geometryMarkup, "geometryMarkup");
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues providerValue = new global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues(global::System.Data.Entity.Spatial.DbGeometry.DefaultCoordinateSystemId, null, null, geometryMarkup);
			return global::System.Data.Entity.Spatial.DbSpatialServices.CreateGeometry(this, providerValue);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00011C54 File Offset: 0x0000FE54
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryFromGml(string geometryMarkup, int spatialReferenceSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(geometryMarkup, "geometryMarkup");
			global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues providerValue = new global::System.Data.Entity.Spatial.DefaultSpatialServices.ReadOnlySpatialValues(spatialReferenceSystemId, null, null, geometryMarkup);
			return global::System.Data.Entity.Spatial.DbSpatialServices.CreateGeometry(this, providerValue);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00011C7E File Offset: 0x0000FE7E
		public override int GetCoordinateSystemId(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			return global::System.Data.Entity.Spatial.DefaultSpatialServices.CheckCompatible(geometryValue).CoordinateSystemId;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00011C97 File Offset: 0x0000FE97
		public override global::System.Data.Entity.Spatial.DbGeometry GetBoundary(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00011C9E File Offset: 0x0000FE9E
		public override int GetDimension(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00011CA5 File Offset: 0x0000FEA5
		public override global::System.Data.Entity.Spatial.DbGeometry GetEnvelope(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00011CAC File Offset: 0x0000FEAC
		public override string GetSpatialTypeName(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00011CB3 File Offset: 0x0000FEB3
		public override bool GetIsEmpty(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00011CBA File Offset: 0x0000FEBA
		public override bool GetIsSimple(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00011CC1 File Offset: 0x0000FEC1
		public override bool GetIsValid(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00011CC8 File Offset: 0x0000FEC8
		public override string AsText(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			return global::System.Data.Entity.Spatial.DefaultSpatialServices.CheckCompatible(geometryValue).Text;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00011CE1 File Offset: 0x0000FEE1
		public override byte[] AsBinary(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			return global::System.Data.Entity.Spatial.DefaultSpatialServices.CheckCompatible(geometryValue).CloneBinary();
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00011CFA File Offset: 0x0000FEFA
		public override string AsGml(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			return global::System.Data.Entity.Spatial.DefaultSpatialServices.CheckCompatible(geometryValue).GML;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00011D13 File Offset: 0x0000FF13
		public override bool SpatialEquals(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00011D1A File Offset: 0x0000FF1A
		public override bool Disjoint(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00011D21 File Offset: 0x0000FF21
		public override bool Intersects(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00011D28 File Offset: 0x0000FF28
		public override bool Touches(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00011D2F File Offset: 0x0000FF2F
		public override bool Crosses(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00011D36 File Offset: 0x0000FF36
		public override bool Within(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00011D3D File Offset: 0x0000FF3D
		public override bool Contains(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00011D44 File Offset: 0x0000FF44
		public override bool Overlaps(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00011D4B File Offset: 0x0000FF4B
		public override bool Relate(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry, string matrix)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00011D52 File Offset: 0x0000FF52
		public override global::System.Data.Entity.Spatial.DbGeometry Buffer(global::System.Data.Entity.Spatial.DbGeometry geometryValue, double distance)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00011D59 File Offset: 0x0000FF59
		public override double Distance(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00011D60 File Offset: 0x0000FF60
		public override global::System.Data.Entity.Spatial.DbGeometry GetConvexHull(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00011D67 File Offset: 0x0000FF67
		public override global::System.Data.Entity.Spatial.DbGeometry Intersection(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00011D6E File Offset: 0x0000FF6E
		public override global::System.Data.Entity.Spatial.DbGeometry Union(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00011D75 File Offset: 0x0000FF75
		public override global::System.Data.Entity.Spatial.DbGeometry Difference(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00011D7C File Offset: 0x0000FF7C
		public override global::System.Data.Entity.Spatial.DbGeometry SymmetricDifference(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00011D83 File Offset: 0x0000FF83
		public override int? GetElementCount(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00011D8A File Offset: 0x0000FF8A
		public override global::System.Data.Entity.Spatial.DbGeometry ElementAt(global::System.Data.Entity.Spatial.DbGeometry geometryValue, int index)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00011D91 File Offset: 0x0000FF91
		public override double? GetXCoordinate(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00011D98 File Offset: 0x0000FF98
		public override double? GetYCoordinate(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00011D9F File Offset: 0x0000FF9F
		public override double? GetElevation(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00011DA6 File Offset: 0x0000FFA6
		public override double? GetMeasure(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00011DAD File Offset: 0x0000FFAD
		public override double? GetLength(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00011DB4 File Offset: 0x0000FFB4
		public override global::System.Data.Entity.Spatial.DbGeometry GetEndPoint(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00011DBB File Offset: 0x0000FFBB
		public override global::System.Data.Entity.Spatial.DbGeometry GetStartPoint(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00011DC2 File Offset: 0x0000FFC2
		public override bool? GetIsClosed(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00011DC9 File Offset: 0x0000FFC9
		public override bool? GetIsRing(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00011DD0 File Offset: 0x0000FFD0
		public override int? GetPointCount(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00011DD7 File Offset: 0x0000FFD7
		public override global::System.Data.Entity.Spatial.DbGeometry PointAt(global::System.Data.Entity.Spatial.DbGeometry geometryValue, int index)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00011DDE File Offset: 0x0000FFDE
		public override double? GetArea(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00011DE5 File Offset: 0x0000FFE5
		public override global::System.Data.Entity.Spatial.DbGeometry GetCentroid(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00011DEC File Offset: 0x0000FFEC
		public override global::System.Data.Entity.Spatial.DbGeometry GetPointOnSurface(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00011DF3 File Offset: 0x0000FFF3
		public override global::System.Data.Entity.Spatial.DbGeometry GetExteriorRing(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00011DFA File Offset: 0x0000FFFA
		public override int? GetInteriorRingCount(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00011E01 File Offset: 0x00010001
		public override global::System.Data.Entity.Spatial.DbGeometry InteriorRingAt(global::System.Data.Entity.Spatial.DbGeometry geometryValue, int index)
		{
			throw global::System.Data.Entity.Spatial.DefaultSpatialServices.SpatialServicesUnavailable();
		}

		// Token: 0x0400012A RID: 298
		internal static readonly global::System.Data.Entity.Spatial.DefaultSpatialServices Instance = new global::System.Data.Entity.Spatial.DefaultSpatialServices();

		// Token: 0x02000730 RID: 1840
		[global::System.Serializable]
		private sealed class ReadOnlySpatialValues
		{
			// Token: 0x0600557C RID: 21884 RVA: 0x001313E0 File Offset: 0x0012F5E0
			internal ReadOnlySpatialValues(int spatialRefSysId, string textValue, byte[] binaryValue, string gmlValue)
			{
				this.srid = spatialRefSysId;
				this.wkb = ((binaryValue == null) ? null : ((byte[])binaryValue.Clone()));
				this.wkt = textValue;
				this.gml = gmlValue;
			}

			// Token: 0x1700101C RID: 4124
			// (get) Token: 0x0600557D RID: 21885 RVA: 0x00131415 File Offset: 0x0012F615
			internal int CoordinateSystemId
			{
				get
				{
					return this.srid;
				}
			}

			// Token: 0x0600557E RID: 21886 RVA: 0x0013141D File Offset: 0x0012F61D
			internal byte[] CloneBinary()
			{
				if (this.wkb != null)
				{
					return (byte[])this.wkb.Clone();
				}
				return null;
			}

			// Token: 0x1700101D RID: 4125
			// (get) Token: 0x0600557F RID: 21887 RVA: 0x00131439 File Offset: 0x0012F639
			internal string Text
			{
				get
				{
					return this.wkt;
				}
			}

			// Token: 0x1700101E RID: 4126
			// (get) Token: 0x06005580 RID: 21888 RVA: 0x00131441 File Offset: 0x0012F641
			internal string GML
			{
				get
				{
					return this.gml;
				}
			}

			// Token: 0x04001EA8 RID: 7848
			private readonly int srid;

			// Token: 0x04001EA9 RID: 7849
			private readonly byte[] wkb;

			// Token: 0x04001EAA RID: 7850
			private readonly string wkt;

			// Token: 0x04001EAB RID: 7851
			private readonly string gml;
		}
	}
}
