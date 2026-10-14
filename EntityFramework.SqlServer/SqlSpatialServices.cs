using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Data.Entity.SqlServer.Resources;
using System.Data.Entity.SqlServer.Utilities;
using System.Reflection;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x02000015 RID: 21
	[global::System.Serializable]
	public class SqlSpatialServices : global::System.Data.Entity.Spatial.DbSpatialServices
	{
		// Token: 0x0600019A RID: 410 RVA: 0x0000936B File Offset: 0x0000756B
		internal SqlSpatialServices()
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00009373 File Offset: 0x00007573
		internal SqlSpatialServices(global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader loader)
		{
			this._loader = loader;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00009382 File Offset: 0x00007582
		public override bool NativeTypesAvailable
		{
			get
			{
				return (this._loader ?? global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader.DefaultInstance).TryGetSqlTypesAssembly() != null;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000939C File Offset: 0x0000759C
		private static bool TryGetSpatialServiceFromAssembly(global::System.Reflection.Assembly assembly, out global::System.Data.Entity.SqlServer.SqlSpatialServices services)
		{
			if (global::System.Data.Entity.SqlServer.SqlSpatialServices._otherSpatialServices == null || !global::System.Data.Entity.SqlServer.SqlSpatialServices._otherSpatialServices.TryGetValue(assembly.FullName, out services))
			{
				global::System.Data.Entity.SqlServer.SqlSpatialServices instance = global::System.Data.Entity.SqlServer.SqlSpatialServices.Instance;
				lock (instance)
				{
					if (global::System.Data.Entity.SqlServer.SqlSpatialServices._otherSpatialServices == null || !global::System.Data.Entity.SqlServer.SqlSpatialServices._otherSpatialServices.TryGetValue(assembly.FullName, out services))
					{
						global::System.Data.Entity.SqlServer.SqlTypesAssembly assembly2;
						if (global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader.DefaultInstance.TryGetSqlTypesAssembly(assembly, out assembly2))
						{
							if (global::System.Data.Entity.SqlServer.SqlSpatialServices._otherSpatialServices == null)
							{
								global::System.Data.Entity.SqlServer.SqlSpatialServices._otherSpatialServices = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlSpatialServices>(1);
							}
							services = new global::System.Data.Entity.SqlServer.SqlSpatialServices(new global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader(assembly2));
							global::System.Data.Entity.SqlServer.SqlSpatialServices._otherSpatialServices.Add(assembly.FullName, services);
						}
						else
						{
							services = null;
						}
					}
				}
			}
			return services != null;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00009454 File Offset: 0x00007654
		internal global::System.Data.Entity.SqlServer.SqlTypesAssembly SqlTypes
		{
			get
			{
				return (this._loader ?? global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader.DefaultInstance).GetSqlTypesAssembly();
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000946C File Offset: 0x0000766C
		public override object CreateProviderValue(global::System.Data.Entity.Spatial.DbGeographyWellKnownValue wellKnownValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeographyWellKnownValue>(wellKnownValue, "wellKnownValue");
			object result;
			if (wellKnownValue.WellKnownText != null)
			{
				result = this.SqlTypes.SqlTypesGeographyFromText(wellKnownValue.WellKnownText, wellKnownValue.CoordinateSystemId);
			}
			else
			{
				if (wellKnownValue.WellKnownBinary == null)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.Spatial_WellKnownGeographyValueNotValid, "wellKnownValue");
				}
				result = this.SqlTypes.SqlTypesGeographyFromBinary(wellKnownValue.WellKnownBinary, wellKnownValue.CoordinateSystemId);
			}
			return result;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000094DC File Offset: 0x000076DC
		public override global::System.Data.Entity.Spatial.DbGeography GeographyFromProviderValue(object providerValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<object>(providerValue, "providerValue");
			object obj = this.NormalizeProviderValue(providerValue, this.SqlTypes.SqlGeographyType);
			if (!this.SqlTypes.IsSqlGeographyNull(obj))
			{
				return global::System.Data.Entity.Spatial.DbSpatialServices.CreateGeography(this, obj);
			}
			return null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00009520 File Offset: 0x00007720
		private object NormalizeProviderValue(object providerValue, global::System.Type expectedSpatialType)
		{
			global::System.Type type = providerValue.GetType();
			if (type != expectedSpatialType)
			{
				global::System.Data.Entity.SqlServer.SqlSpatialServices sqlSpatialServices;
				if (global::System.Data.Entity.SqlServer.SqlSpatialServices.TryGetSpatialServiceFromAssembly(providerValue.GetType().Assembly(), out sqlSpatialServices))
				{
					if (expectedSpatialType == this.SqlTypes.SqlGeographyType)
					{
						if (type == sqlSpatialServices.SqlTypes.SqlGeographyType)
						{
							return this.ConvertToSqlValue(sqlSpatialServices.GeographyFromProviderValue(providerValue), "providerValue");
						}
					}
					else if (type == sqlSpatialServices.SqlTypes.SqlGeometryType)
					{
						return this.ConvertToSqlValue(sqlSpatialServices.GeometryFromProviderValue(providerValue), "providerValue");
					}
				}
				throw new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlSpatialServices_ProviderValueNotSqlType(expectedSpatialType.AssemblyQualifiedName), "providerValue");
			}
			return providerValue;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000095CC File Offset: 0x000077CC
		public override global::System.Data.Entity.Spatial.DbGeographyWellKnownValue CreateWellKnownValue(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			return global::System.Data.Entity.SqlServer.SqlSpatialServices.CreateWellKnownValue<global::System.Data.Entity.Spatial.DbGeographyWellKnownValue>(geographyValue.AsSpatialValue(), () => new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlSpatialservices_CouldNotCreateWellKnownGeographyValueNoSrid, "geographyValue"), () => new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlSpatialservices_CouldNotCreateWellKnownGeographyValueNoWkbOrWkt, "geographyValue"), (int coordinateSystemId, byte[] wkb, string wkt) => new global::System.Data.Entity.Spatial.DbGeographyWellKnownValue
			{
				CoordinateSystemId = coordinateSystemId,
				WellKnownBinary = wkb,
				WellKnownText = wkt
			});
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00009650 File Offset: 0x00007850
		public override object CreateProviderValue(global::System.Data.Entity.Spatial.DbGeometryWellKnownValue wellKnownValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometryWellKnownValue>(wellKnownValue, "wellKnownValue");
			object result;
			if (wellKnownValue.WellKnownText != null)
			{
				result = this.SqlTypes.SqlTypesGeometryFromText(wellKnownValue.WellKnownText, wellKnownValue.CoordinateSystemId);
			}
			else
			{
				if (wellKnownValue.WellKnownBinary == null)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.Spatial_WellKnownGeometryValueNotValid, "wellKnownValue");
				}
				result = this.SqlTypes.SqlTypesGeometryFromBinary(wellKnownValue.WellKnownBinary, wellKnownValue.CoordinateSystemId);
			}
			return result;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000096C0 File Offset: 0x000078C0
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryFromProviderValue(object providerValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<object>(providerValue, "providerValue");
			object obj = this.NormalizeProviderValue(providerValue, this.SqlTypes.SqlGeometryType);
			if (!this.SqlTypes.IsSqlGeometryNull(obj))
			{
				return global::System.Data.Entity.Spatial.DbSpatialServices.CreateGeometry(this, obj);
			}
			return null;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00009704 File Offset: 0x00007904
		public override global::System.Data.Entity.Spatial.DbGeometryWellKnownValue CreateWellKnownValue(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			return global::System.Data.Entity.SqlServer.SqlSpatialServices.CreateWellKnownValue<global::System.Data.Entity.Spatial.DbGeometryWellKnownValue>(geometryValue.AsSpatialValue(), () => new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlSpatialservices_CouldNotCreateWellKnownGeometryValueNoSrid, "geometryValue"), () => new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlSpatialservices_CouldNotCreateWellKnownGeometryValueNoWkbOrWkt, "geometryValue"), (int coordinateSystemId, byte[] wkb, string wkt) => new global::System.Data.Entity.Spatial.DbGeometryWellKnownValue
			{
				CoordinateSystemId = coordinateSystemId,
				WellKnownBinary = wkb,
				WellKnownText = wkt
			});
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00009788 File Offset: 0x00007988
		private static TValue CreateWellKnownValue<TValue>(global::System.Data.Entity.SqlServer.IDbSpatialValue spatialValue, global::System.Func<global::System.Exception> onMissingcoordinateSystemId, global::System.Func<global::System.Exception> onMissingWkbAndWkt, global::System.Func<int, byte[], string, TValue> onValidValue)
		{
			int? coordinateSystemId = spatialValue.CoordinateSystemId;
			if (coordinateSystemId == null)
			{
				throw onMissingcoordinateSystemId();
			}
			string wellKnownText = spatialValue.WellKnownText;
			if (wellKnownText != null)
			{
				return onValidValue(coordinateSystemId.Value, null, wellKnownText);
			}
			byte[] wellKnownBinary = spatialValue.WellKnownBinary;
			if (wellKnownBinary != null)
			{
				return onValidValue(coordinateSystemId.Value, wellKnownBinary, null);
			}
			throw onMissingWkbAndWkt();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000097E6 File Offset: 0x000079E6
		public override string AsTextIncludingElevationAndMeasure(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			return this.SqlTypes.GeographyAsTextZM(geographyValue);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00009800 File Offset: 0x00007A00
		public override string AsTextIncludingElevationAndMeasure(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			return this.SqlTypes.GeometryAsTextZM(geometryValue);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000981A File Offset: 0x00007A1A
		private object ConvertToSqlValue(global::System.Data.Entity.Spatial.DbGeography geographyValue, string argumentName)
		{
			if (geographyValue == null)
			{
				return null;
			}
			return this.SqlTypes.ConvertToSqlTypesGeography(geographyValue);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000982D File Offset: 0x00007A2D
		private object ConvertToSqlValue(global::System.Data.Entity.Spatial.DbGeometry geometryValue, string argumentName)
		{
			if (geometryValue == null)
			{
				return null;
			}
			return this.SqlTypes.ConvertToSqlTypesGeometry(geometryValue);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00009840 File Offset: 0x00007A40
		private object ConvertToSqlBytes(byte[] binaryValue, string argumentName)
		{
			if (binaryValue == null)
			{
				return null;
			}
			return this.SqlTypes.SqlBytesFromByteArray(binaryValue);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00009853 File Offset: 0x00007A53
		private object ConvertToSqlChars(string stringValue, string argumentName)
		{
			if (stringValue == null)
			{
				return null;
			}
			return this.SqlTypes.SqlCharsFromString(stringValue);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00009866 File Offset: 0x00007A66
		private object ConvertToSqlString(string stringValue, string argumentName)
		{
			if (stringValue == null)
			{
				return null;
			}
			return this.SqlTypes.SqlStringFromString(stringValue);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00009879 File Offset: 0x00007A79
		private object ConvertToSqlXml(string stringValue, string argumentName)
		{
			if (stringValue == null)
			{
				return null;
			}
			return this.SqlTypes.SqlXmlFromString(stringValue);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000988C File Offset: 0x00007A8C
		private bool ConvertSqlBooleanToBoolean(object sqlBoolean)
		{
			return this.SqlTypes.SqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000989A File Offset: 0x00007A9A
		private bool? ConvertSqlBooleanToNullableBoolean(object sqlBoolean)
		{
			return this.SqlTypes.SqlBooleanToNullableBoolean(sqlBoolean);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000098A8 File Offset: 0x00007AA8
		private byte[] ConvertSqlBytesToBinary(object sqlBytes)
		{
			return this.SqlTypes.SqlBytesToByteArray(sqlBytes);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000098B6 File Offset: 0x00007AB6
		private string ConvertSqlCharsToString(object sqlCharsValue)
		{
			return this.SqlTypes.SqlCharsToString(sqlCharsValue);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000098C4 File Offset: 0x00007AC4
		private string ConvertSqlStringToString(object sqlCharsValue)
		{
			return this.SqlTypes.SqlStringToString(sqlCharsValue);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000098D2 File Offset: 0x00007AD2
		private double ConvertSqlDoubleToDouble(object sqlDoubleValue)
		{
			return this.SqlTypes.SqlDoubleToDouble(sqlDoubleValue);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000098E0 File Offset: 0x00007AE0
		private double? ConvertSqlDoubleToNullableDouble(object sqlDoubleValue)
		{
			return this.SqlTypes.SqlDoubleToNullableDouble(sqlDoubleValue);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000098EE File Offset: 0x00007AEE
		private int ConvertSqlInt32ToInt(object sqlInt32Value)
		{
			return this.SqlTypes.SqlInt32ToInt(sqlInt32Value);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000098FC File Offset: 0x00007AFC
		private int? ConvertSqlInt32ToNullableInt(object sqlInt32Value)
		{
			return this.SqlTypes.SqlInt32ToNullableInt(sqlInt32Value);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000990A File Offset: 0x00007B0A
		private string ConvertSqlXmlToString(object sqlXmlValue)
		{
			return this.SqlTypes.SqlXmlToString(sqlXmlValue);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00009918 File Offset: 0x00007B18
		public override global::System.Data.Entity.Spatial.DbGeography GeographyFromText(string wellKnownText)
		{
			object obj = this.ConvertToSqlString(wellKnownText, "wellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeographyParse.Value.Invoke(null, new object[]
			{
				obj
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000995C File Offset: 0x00007B5C
		public override global::System.Data.Entity.Spatial.DbGeography GeographyFromText(string wellKnownText, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlChars(wellKnownText, "wellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeographyStGeomFromText.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000099A8 File Offset: 0x00007BA8
		public override global::System.Data.Entity.Spatial.DbGeography GeographyPointFromText(string pointWellKnownText, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlChars(pointWellKnownText, "pointWellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeographyStPointFromText.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000099F4 File Offset: 0x00007BF4
		public override global::System.Data.Entity.Spatial.DbGeography GeographyLineFromText(string lineWellKnownText, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlChars(lineWellKnownText, "lineWellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeographyStLineFromText.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00009A40 File Offset: 0x00007C40
		public override global::System.Data.Entity.Spatial.DbGeography GeographyPolygonFromText(string polygonWellKnownText, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlChars(polygonWellKnownText, "polygonWellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeographyStPolyFromText.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00009A8C File Offset: 0x00007C8C
		public override global::System.Data.Entity.Spatial.DbGeography GeographyMultiPointFromText(string multiPointWellKnownText, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlChars(multiPointWellKnownText, "multiPointWellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeographyStmPointFromText.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00009AD8 File Offset: 0x00007CD8
		public override global::System.Data.Entity.Spatial.DbGeography GeographyMultiLineFromText(string multiLineWellKnownText, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlChars(multiLineWellKnownText, "multiLineWellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeographyStmLineFromText.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00009B24 File Offset: 0x00007D24
		public override global::System.Data.Entity.Spatial.DbGeography GeographyMultiPolygonFromText(string multiPolygonKnownText, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlChars(multiPolygonKnownText, "multiPolygonWellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeographyStmPolyFromText.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00009B70 File Offset: 0x00007D70
		public override global::System.Data.Entity.Spatial.DbGeography GeographyCollectionFromText(string geographyCollectionWellKnownText, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlChars(geographyCollectionWellKnownText, "geographyCollectionWellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeographyStGeomCollFromText.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00009BBC File Offset: 0x00007DBC
		public override global::System.Data.Entity.Spatial.DbGeography GeographyFromBinary(byte[] wellKnownBinary, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlBytes(wellKnownBinary, "wellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeographyStGeomFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00009C08 File Offset: 0x00007E08
		public override global::System.Data.Entity.Spatial.DbGeography GeographyFromBinary(byte[] wellKnownBinary)
		{
			object obj = this.ConvertToSqlBytes(wellKnownBinary, "wellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeographyStGeomFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				4326
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00009C58 File Offset: 0x00007E58
		public override global::System.Data.Entity.Spatial.DbGeography GeographyPointFromBinary(byte[] pointWellKnownBinary, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlBytes(pointWellKnownBinary, "pointWellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeographyStPointFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00009CA4 File Offset: 0x00007EA4
		public override global::System.Data.Entity.Spatial.DbGeography GeographyLineFromBinary(byte[] lineWellKnownBinary, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlBytes(lineWellKnownBinary, "lineWellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeographyStLineFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00009CF0 File Offset: 0x00007EF0
		public override global::System.Data.Entity.Spatial.DbGeography GeographyPolygonFromBinary(byte[] polygonWellKnownBinary, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlBytes(polygonWellKnownBinary, "polygonWellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeographyStPolyFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00009D3C File Offset: 0x00007F3C
		public override global::System.Data.Entity.Spatial.DbGeography GeographyMultiPointFromBinary(byte[] multiPointWellKnownBinary, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlBytes(multiPointWellKnownBinary, "multiPointWellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeographyStmPointFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00009D88 File Offset: 0x00007F88
		public override global::System.Data.Entity.Spatial.DbGeography GeographyMultiLineFromBinary(byte[] multiLineWellKnownBinary, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlBytes(multiLineWellKnownBinary, "multiLineWellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeographyStmLineFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00009DD4 File Offset: 0x00007FD4
		public override global::System.Data.Entity.Spatial.DbGeography GeographyMultiPolygonFromBinary(byte[] multiPolygonWellKnownBinary, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlBytes(multiPolygonWellKnownBinary, "multiPolygonWellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeographyStmPolyFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00009E20 File Offset: 0x00008020
		public override global::System.Data.Entity.Spatial.DbGeography GeographyCollectionFromBinary(byte[] geographyCollectionWellKnownBinary, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlBytes(geographyCollectionWellKnownBinary, "geographyCollectionWellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeographyStGeomCollFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00009E6C File Offset: 0x0000806C
		public override global::System.Data.Entity.Spatial.DbGeography GeographyFromGml(string geographyMarkup)
		{
			object obj = this.ConvertToSqlXml(geographyMarkup, "geographyMarkup");
			object providerValue = this.SqlTypes.SmiSqlGeographyGeomFromGml.Value.Invoke(null, new object[]
			{
				obj,
				4326
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00009EBC File Offset: 0x000080BC
		public override global::System.Data.Entity.Spatial.DbGeography GeographyFromGml(string geographyMarkup, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlXml(geographyMarkup, "geographyMarkup");
			object providerValue = this.SqlTypes.SmiSqlGeographyGeomFromGml.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00009F08 File Offset: 0x00008108
		public override int GetCoordinateSystemId(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object value = this.SqlTypes.IpiSqlGeographyStSrid.Value.GetValue(obj, null);
			return this.ConvertSqlInt32ToInt(value);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00009F50 File Offset: 0x00008150
		public override string GetSpatialTypeName(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object sqlCharsValue = this.SqlTypes.ImiSqlGeographyStGeometryType.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlStringToString(sqlCharsValue);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00009F9C File Offset: 0x0000819C
		public override int GetDimension(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object sqlInt32Value = this.SqlTypes.ImiSqlGeographyStDimension.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlInt32ToInt(sqlInt32Value);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00009FE8 File Offset: 0x000081E8
		public override byte[] AsBinary(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object sqlBytes = this.SqlTypes.ImiSqlGeographyStAsBinary.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlBytesToBinary(sqlBytes);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000A034 File Offset: 0x00008234
		public override string AsGml(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object sqlXmlValue = this.SqlTypes.ImiSqlGeographyAsGml.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlXmlToString(sqlXmlValue);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000A080 File Offset: 0x00008280
		public override string AsText(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object sqlCharsValue = this.SqlTypes.ImiSqlGeographyStAsText.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlCharsToString(sqlCharsValue);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000A0CC File Offset: 0x000082CC
		public override bool GetIsEmpty(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object sqlBoolean = this.SqlTypes.ImiSqlGeographyStIsEmpty.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000A118 File Offset: 0x00008318
		public override bool SpatialEquals(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object obj2 = this.ConvertToSqlValue(otherGeography, "otherGeography");
			object sqlBoolean = this.SqlTypes.ImiSqlGeographyStEquals.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.ConvertSqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000A174 File Offset: 0x00008374
		public override bool Disjoint(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object obj2 = this.ConvertToSqlValue(otherGeography, "otherGeography");
			object sqlBoolean = this.SqlTypes.ImiSqlGeographyStDisjoint.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.ConvertSqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000A1D0 File Offset: 0x000083D0
		public override bool Intersects(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object obj2 = this.ConvertToSqlValue(otherGeography, "otherGeography");
			object sqlBoolean = this.SqlTypes.ImiSqlGeographyStIntersects.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.ConvertSqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000A22C File Offset: 0x0000842C
		public override global::System.Data.Entity.Spatial.DbGeography Buffer(global::System.Data.Entity.Spatial.DbGeography geographyValue, double distance)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object providerValue = this.SqlTypes.ImiSqlGeographyStBuffer.Value.Invoke(obj, new object[]
			{
				distance
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000A280 File Offset: 0x00008480
		public override double Distance(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object obj2 = this.ConvertToSqlValue(otherGeography, "otherGeography");
			object sqlDoubleValue = this.SqlTypes.ImiSqlGeographyStDistance.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.ConvertSqlDoubleToDouble(sqlDoubleValue);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000A2DC File Offset: 0x000084DC
		public override global::System.Data.Entity.Spatial.DbGeography Intersection(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object obj2 = this.ConvertToSqlValue(otherGeography, "otherGeography");
			object providerValue = this.SqlTypes.ImiSqlGeographyStIntersection.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000A338 File Offset: 0x00008538
		public override global::System.Data.Entity.Spatial.DbGeography Union(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object obj2 = this.ConvertToSqlValue(otherGeography, "otherGeography");
			object providerValue = this.SqlTypes.ImiSqlGeographyStUnion.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000A394 File Offset: 0x00008594
		public override global::System.Data.Entity.Spatial.DbGeography Difference(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object obj2 = this.ConvertToSqlValue(otherGeography, "otherGeography");
			object providerValue = this.SqlTypes.ImiSqlGeographyStDifference.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000A3F0 File Offset: 0x000085F0
		public override global::System.Data.Entity.Spatial.DbGeography SymmetricDifference(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography otherGeography)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object obj2 = this.ConvertToSqlValue(otherGeography, "otherGeography");
			object providerValue = this.SqlTypes.ImiSqlGeographyStSymDifference.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000A44C File Offset: 0x0000864C
		public override int? GetElementCount(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object sqlInt32Value = this.SqlTypes.ImiSqlGeographyStNumGeometries.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlInt32ToNullableInt(sqlInt32Value);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000A498 File Offset: 0x00008698
		public override global::System.Data.Entity.Spatial.DbGeography ElementAt(global::System.Data.Entity.Spatial.DbGeography geographyValue, int index)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object providerValue = this.SqlTypes.ImiSqlGeographyStGeometryN.Value.Invoke(obj, new object[]
			{
				index
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000A4EC File Offset: 0x000086EC
		public override double? GetLatitude(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object value = this.SqlTypes.IpiSqlGeographyLat.Value.GetValue(obj, null);
			return this.ConvertSqlDoubleToNullableDouble(value);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000A534 File Offset: 0x00008734
		public override double? GetLongitude(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object value = this.SqlTypes.IpiSqlGeographyLong.Value.GetValue(obj, null);
			return this.ConvertSqlDoubleToNullableDouble(value);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000A57C File Offset: 0x0000877C
		public override double? GetElevation(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object value = this.SqlTypes.IpiSqlGeographyZ.Value.GetValue(obj, null);
			return this.ConvertSqlDoubleToNullableDouble(value);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000A5C4 File Offset: 0x000087C4
		public override double? GetMeasure(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object value = this.SqlTypes.IpiSqlGeographyM.Value.GetValue(obj, null);
			return this.ConvertSqlDoubleToNullableDouble(value);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000A60C File Offset: 0x0000880C
		public override double? GetLength(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object sqlDoubleValue = this.SqlTypes.ImiSqlGeographyStLength.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlDoubleToNullableDouble(sqlDoubleValue);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000A658 File Offset: 0x00008858
		public override global::System.Data.Entity.Spatial.DbGeography GetStartPoint(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object providerValue = this.SqlTypes.ImiSqlGeographyStStartPoint.Value.Invoke(obj, new object[0]);
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000A6A4 File Offset: 0x000088A4
		public override global::System.Data.Entity.Spatial.DbGeography GetEndPoint(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object providerValue = this.SqlTypes.ImiSqlGeographyStEndPoint.Value.Invoke(obj, new object[0]);
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000A6F0 File Offset: 0x000088F0
		public override bool? GetIsClosed(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object sqlBoolean = this.SqlTypes.ImiSqlGeographyStIsClosed.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlBooleanToNullableBoolean(sqlBoolean);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000A73C File Offset: 0x0000893C
		public override int? GetPointCount(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object sqlInt32Value = this.SqlTypes.ImiSqlGeographyStNumPoints.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlInt32ToNullableInt(sqlInt32Value);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000A788 File Offset: 0x00008988
		public override global::System.Data.Entity.Spatial.DbGeography PointAt(global::System.Data.Entity.Spatial.DbGeography geographyValue, int index)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object providerValue = this.SqlTypes.ImiSqlGeographyStPointN.Value.Invoke(obj, new object[]
			{
				index
			});
			return this.GeographyFromProviderValue(providerValue);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000A7DC File Offset: 0x000089DC
		public override double? GetArea(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeography>(geographyValue, "geographyValue");
			object obj = this.ConvertToSqlValue(geographyValue, "geographyValue");
			object sqlDoubleValue = this.SqlTypes.ImiSqlGeographyStArea.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlDoubleToNullableDouble(sqlDoubleValue);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000A828 File Offset: 0x00008A28
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryFromText(string wellKnownText)
		{
			object obj = this.ConvertToSqlString(wellKnownText, "wellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeometryParse.Value.Invoke(null, new object[]
			{
				obj
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000A86C File Offset: 0x00008A6C
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryFromText(string wellKnownText, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlChars(wellKnownText, "wellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeometryStGeomFromText.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000A8B8 File Offset: 0x00008AB8
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryPointFromText(string pointWellKnownText, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlChars(pointWellKnownText, "pointWellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeometryStPointFromText.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000A904 File Offset: 0x00008B04
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryLineFromText(string lineWellKnownText, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlChars(lineWellKnownText, "lineWellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeometryStLineFromText.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000A950 File Offset: 0x00008B50
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryPolygonFromText(string polygonWellKnownText, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlChars(polygonWellKnownText, "polygonWellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeometryStPolyFromText.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000A99C File Offset: 0x00008B9C
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryMultiPointFromText(string multiPointWellKnownText, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlChars(multiPointWellKnownText, "multiPointWellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeometryStmPointFromText.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000A9E8 File Offset: 0x00008BE8
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryMultiLineFromText(string multiLineWellKnownText, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlChars(multiLineWellKnownText, "multiLineWellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeometryStmLineFromText.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000AA34 File Offset: 0x00008C34
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryMultiPolygonFromText(string multiPolygonKnownText, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlChars(multiPolygonKnownText, "multiPolygonKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeometryStmPolyFromText.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000AA80 File Offset: 0x00008C80
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryCollectionFromText(string geometryCollectionWellKnownText, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlChars(geometryCollectionWellKnownText, "geometryCollectionWellKnownText");
			object providerValue = this.SqlTypes.SmiSqlGeometryStGeomCollFromText.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000AACC File Offset: 0x00008CCC
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryFromBinary(byte[] wellKnownBinary)
		{
			object obj = this.ConvertToSqlBytes(wellKnownBinary, "wellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeometryStGeomFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				0
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000AB18 File Offset: 0x00008D18
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryFromBinary(byte[] wellKnownBinary, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlBytes(wellKnownBinary, "wellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeometryStGeomFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000AB64 File Offset: 0x00008D64
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryPointFromBinary(byte[] pointWellKnownBinary, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlBytes(pointWellKnownBinary, "pointWellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeometryStPointFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000ABB0 File Offset: 0x00008DB0
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryLineFromBinary(byte[] lineWellKnownBinary, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlBytes(lineWellKnownBinary, "lineWellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeometryStLineFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000ABFC File Offset: 0x00008DFC
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryPolygonFromBinary(byte[] polygonWellKnownBinary, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlBytes(polygonWellKnownBinary, "polygonWellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeometryStPolyFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000AC48 File Offset: 0x00008E48
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryMultiPointFromBinary(byte[] multiPointWellKnownBinary, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlBytes(multiPointWellKnownBinary, "multiPointWellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeometryStmPointFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000AC94 File Offset: 0x00008E94
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryMultiLineFromBinary(byte[] multiLineWellKnownBinary, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlBytes(multiLineWellKnownBinary, "multiLineWellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeometryStmLineFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000ACE0 File Offset: 0x00008EE0
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryMultiPolygonFromBinary(byte[] multiPolygonWellKnownBinary, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlBytes(multiPolygonWellKnownBinary, "multiPolygonWellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeometryStmPolyFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000AD2C File Offset: 0x00008F2C
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryCollectionFromBinary(byte[] geometryCollectionWellKnownBinary, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlBytes(geometryCollectionWellKnownBinary, "geometryCollectionWellKnownBinary");
			object providerValue = this.SqlTypes.SmiSqlGeometryStGeomCollFromWkb.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000AD78 File Offset: 0x00008F78
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryFromGml(string geometryMarkup)
		{
			object obj = this.ConvertToSqlXml(geometryMarkup, "geometryMarkup");
			object providerValue = this.SqlTypes.SmiSqlGeometryGeomFromGml.Value.Invoke(null, new object[]
			{
				obj,
				0
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000ADC4 File Offset: 0x00008FC4
		public override global::System.Data.Entity.Spatial.DbGeometry GeometryFromGml(string geometryMarkup, int coordinateSystemId)
		{
			object obj = this.ConvertToSqlXml(geometryMarkup, "geometryMarkup");
			object providerValue = this.SqlTypes.SmiSqlGeometryGeomFromGml.Value.Invoke(null, new object[]
			{
				obj,
				coordinateSystemId
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000AE10 File Offset: 0x00009010
		public override int GetCoordinateSystemId(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object value = this.SqlTypes.IpiSqlGeometryStSrid.Value.GetValue(obj, null);
			return this.ConvertSqlInt32ToInt(value);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000AE58 File Offset: 0x00009058
		public override string GetSpatialTypeName(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object sqlCharsValue = this.SqlTypes.ImiSqlGeometryStGeometryType.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlStringToString(sqlCharsValue);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000AEA4 File Offset: 0x000090A4
		public override int GetDimension(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object sqlInt32Value = this.SqlTypes.ImiSqlGeometryStDimension.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlInt32ToInt(sqlInt32Value);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000AEF0 File Offset: 0x000090F0
		public override global::System.Data.Entity.Spatial.DbGeometry GetEnvelope(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object providerValue = this.SqlTypes.ImiSqlGeometryStEnvelope.Value.Invoke(obj, new object[0]);
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000AF3C File Offset: 0x0000913C
		public override byte[] AsBinary(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object sqlBytes = this.SqlTypes.ImiSqlGeometryStAsBinary.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlBytesToBinary(sqlBytes);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000AF88 File Offset: 0x00009188
		public override string AsGml(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object sqlXmlValue = this.SqlTypes.ImiSqlGeometryAsGml.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlXmlToString(sqlXmlValue);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000AFD4 File Offset: 0x000091D4
		public override string AsText(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object sqlCharsValue = this.SqlTypes.ImiSqlGeometryStAsText.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlCharsToString(sqlCharsValue);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000B020 File Offset: 0x00009220
		public override bool GetIsEmpty(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object sqlBoolean = this.SqlTypes.ImiSqlGeometryStIsEmpty.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000B06C File Offset: 0x0000926C
		public override bool GetIsSimple(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object sqlBoolean = this.SqlTypes.ImiSqlGeometryStIsSimple.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000B0B8 File Offset: 0x000092B8
		public override global::System.Data.Entity.Spatial.DbGeometry GetBoundary(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object providerValue = this.SqlTypes.ImiSqlGeometryStBoundary.Value.Invoke(obj, new object[0]);
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000B104 File Offset: 0x00009304
		public override bool GetIsValid(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object sqlBoolean = this.SqlTypes.ImiSqlGeometryStIsValid.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000B150 File Offset: 0x00009350
		public override bool SpatialEquals(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object obj2 = this.ConvertToSqlValue(otherGeometry, "otherGeometry");
			object sqlBoolean = this.SqlTypes.ImiSqlGeometryStEquals.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.ConvertSqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000B1AC File Offset: 0x000093AC
		public override bool Disjoint(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object obj2 = this.ConvertToSqlValue(otherGeometry, "otherGeometry");
			object sqlBoolean = this.SqlTypes.ImiSqlGeometryStDisjoint.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.ConvertSqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000B208 File Offset: 0x00009408
		public override bool Intersects(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object obj2 = this.ConvertToSqlValue(otherGeometry, "otherGeometry");
			object sqlBoolean = this.SqlTypes.ImiSqlGeometryStIntersects.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.ConvertSqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000B264 File Offset: 0x00009464
		public override bool Touches(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object obj2 = this.ConvertToSqlValue(otherGeometry, "otherGeometry");
			object sqlBoolean = this.SqlTypes.ImiSqlGeometryStTouches.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.ConvertSqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000B2C0 File Offset: 0x000094C0
		public override bool Crosses(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object obj2 = this.ConvertToSqlValue(otherGeometry, "otherGeometry");
			object sqlBoolean = this.SqlTypes.ImiSqlGeometryStCrosses.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.ConvertSqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000B31C File Offset: 0x0000951C
		public override bool Within(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object obj2 = this.ConvertToSqlValue(otherGeometry, "otherGeometry");
			object sqlBoolean = this.SqlTypes.ImiSqlGeometryStWithin.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.ConvertSqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000B378 File Offset: 0x00009578
		public override bool Contains(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object obj2 = this.ConvertToSqlValue(otherGeometry, "otherGeometry");
			object sqlBoolean = this.SqlTypes.ImiSqlGeometryStContains.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.ConvertSqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000B3D4 File Offset: 0x000095D4
		public override bool Overlaps(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object obj2 = this.ConvertToSqlValue(otherGeometry, "otherGeometry");
			object sqlBoolean = this.SqlTypes.ImiSqlGeometryStOverlaps.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.ConvertSqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000B430 File Offset: 0x00009630
		public override bool Relate(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry, string matrix)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object obj2 = this.ConvertToSqlValue(otherGeometry, "otherGeometry");
			object sqlBoolean = this.SqlTypes.ImiSqlGeometryStRelate.Value.Invoke(obj, new object[]
			{
				obj2,
				matrix
			});
			return this.ConvertSqlBooleanToBoolean(sqlBoolean);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000B490 File Offset: 0x00009690
		public override global::System.Data.Entity.Spatial.DbGeometry Buffer(global::System.Data.Entity.Spatial.DbGeometry geometryValue, double distance)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object providerValue = this.SqlTypes.ImiSqlGeometryStBuffer.Value.Invoke(obj, new object[]
			{
				distance
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000B4E4 File Offset: 0x000096E4
		public override double Distance(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object obj2 = this.ConvertToSqlValue(otherGeometry, "otherGeometry");
			object sqlDoubleValue = this.SqlTypes.ImiSqlGeometryStDistance.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.ConvertSqlDoubleToDouble(sqlDoubleValue);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000B540 File Offset: 0x00009740
		public override global::System.Data.Entity.Spatial.DbGeometry GetConvexHull(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object providerValue = this.SqlTypes.ImiSqlGeometryStConvexHull.Value.Invoke(obj, new object[0]);
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000B58C File Offset: 0x0000978C
		public override global::System.Data.Entity.Spatial.DbGeometry Intersection(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object obj2 = this.ConvertToSqlValue(otherGeometry, "otherGeometry");
			object providerValue = this.SqlTypes.ImiSqlGeometryStIntersection.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000B5E8 File Offset: 0x000097E8
		public override global::System.Data.Entity.Spatial.DbGeometry Union(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object obj2 = this.ConvertToSqlValue(otherGeometry, "otherGeometry");
			object providerValue = this.SqlTypes.ImiSqlGeometryStUnion.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000B644 File Offset: 0x00009844
		public override global::System.Data.Entity.Spatial.DbGeometry Difference(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object obj2 = this.ConvertToSqlValue(otherGeometry, "otherGeometry");
			object providerValue = this.SqlTypes.ImiSqlGeometryStDifference.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000B6A0 File Offset: 0x000098A0
		public override global::System.Data.Entity.Spatial.DbGeometry SymmetricDifference(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry otherGeometry)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object obj2 = this.ConvertToSqlValue(otherGeometry, "otherGeometry");
			object providerValue = this.SqlTypes.ImiSqlGeometryStSymDifference.Value.Invoke(obj, new object[]
			{
				obj2
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000B6FC File Offset: 0x000098FC
		public override int? GetElementCount(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object sqlInt32Value = this.SqlTypes.ImiSqlGeometryStNumGeometries.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlInt32ToNullableInt(sqlInt32Value);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000B748 File Offset: 0x00009948
		public override global::System.Data.Entity.Spatial.DbGeometry ElementAt(global::System.Data.Entity.Spatial.DbGeometry geometryValue, int index)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object providerValue = this.SqlTypes.ImiSqlGeometryStGeometryN.Value.Invoke(obj, new object[]
			{
				index
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000B79C File Offset: 0x0000999C
		public override double? GetXCoordinate(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object value = this.SqlTypes.IpiSqlGeometryStx.Value.GetValue(obj, null);
			return this.ConvertSqlDoubleToNullableDouble(value);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000B7E4 File Offset: 0x000099E4
		public override double? GetYCoordinate(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object value = this.SqlTypes.IpiSqlGeometrySty.Value.GetValue(obj, null);
			return this.ConvertSqlDoubleToNullableDouble(value);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000B82C File Offset: 0x00009A2C
		public override double? GetElevation(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object value = this.SqlTypes.IpiSqlGeometryZ.Value.GetValue(obj, null);
			return this.ConvertSqlDoubleToNullableDouble(value);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000B874 File Offset: 0x00009A74
		public override double? GetMeasure(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object value = this.SqlTypes.IpiSqlGeometryM.Value.GetValue(obj, null);
			return this.ConvertSqlDoubleToNullableDouble(value);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000B8BC File Offset: 0x00009ABC
		public override double? GetLength(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object sqlDoubleValue = this.SqlTypes.ImiSqlGeometryStLength.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlDoubleToNullableDouble(sqlDoubleValue);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000B908 File Offset: 0x00009B08
		public override global::System.Data.Entity.Spatial.DbGeometry GetStartPoint(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object providerValue = this.SqlTypes.ImiSqlGeometryStStartPoint.Value.Invoke(obj, new object[0]);
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000B954 File Offset: 0x00009B54
		public override global::System.Data.Entity.Spatial.DbGeometry GetEndPoint(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object providerValue = this.SqlTypes.ImiSqlGeometryStEndPoint.Value.Invoke(obj, new object[0]);
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		public override bool? GetIsClosed(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object sqlBoolean = this.SqlTypes.ImiSqlGeometryStIsClosed.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlBooleanToNullableBoolean(sqlBoolean);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000B9EC File Offset: 0x00009BEC
		public override bool? GetIsRing(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object sqlBoolean = this.SqlTypes.ImiSqlGeometryStIsRing.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlBooleanToNullableBoolean(sqlBoolean);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000BA38 File Offset: 0x00009C38
		public override int? GetPointCount(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object sqlInt32Value = this.SqlTypes.ImiSqlGeometryStNumPoints.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlInt32ToNullableInt(sqlInt32Value);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000BA84 File Offset: 0x00009C84
		public override global::System.Data.Entity.Spatial.DbGeometry PointAt(global::System.Data.Entity.Spatial.DbGeometry geometryValue, int index)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object providerValue = this.SqlTypes.ImiSqlGeometryStPointN.Value.Invoke(obj, new object[]
			{
				index
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		public override double? GetArea(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object sqlDoubleValue = this.SqlTypes.ImiSqlGeometryStArea.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlDoubleToNullableDouble(sqlDoubleValue);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000BB24 File Offset: 0x00009D24
		public override global::System.Data.Entity.Spatial.DbGeometry GetCentroid(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object providerValue = this.SqlTypes.ImiSqlGeometryStCentroid.Value.Invoke(obj, new object[0]);
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000BB70 File Offset: 0x00009D70
		public override global::System.Data.Entity.Spatial.DbGeometry GetPointOnSurface(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object providerValue = this.SqlTypes.ImiSqlGeometryStPointOnSurface.Value.Invoke(obj, new object[0]);
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000BBBC File Offset: 0x00009DBC
		public override global::System.Data.Entity.Spatial.DbGeometry GetExteriorRing(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object providerValue = this.SqlTypes.ImiSqlGeometryStExteriorRing.Value.Invoke(obj, new object[0]);
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000BC08 File Offset: 0x00009E08
		public override int? GetInteriorRingCount(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object sqlInt32Value = this.SqlTypes.ImiSqlGeometryStNumInteriorRing.Value.Invoke(obj, new object[0]);
			return this.ConvertSqlInt32ToNullableInt(sqlInt32Value);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000BC54 File Offset: 0x00009E54
		public override global::System.Data.Entity.Spatial.DbGeometry InteriorRingAt(global::System.Data.Entity.Spatial.DbGeometry geometryValue, int index)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbGeometry>(geometryValue, "geometryValue");
			object obj = this.ConvertToSqlValue(geometryValue, "geometryValue");
			object providerValue = this.SqlTypes.ImiSqlGeometryStInteriorRingN.Value.Invoke(obj, new object[]
			{
				index
			});
			return this.GeometryFromProviderValue(providerValue);
		}

		// Token: 0x0400002E RID: 46
		internal static readonly global::System.Data.Entity.SqlServer.SqlSpatialServices Instance = new global::System.Data.Entity.SqlServer.SqlSpatialServices();

		// Token: 0x0400002F RID: 47
		private static global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlSpatialServices> _otherSpatialServices;

		// Token: 0x04000030 RID: 48
		[global::System.NonSerialized]
		private readonly global::System.Data.Entity.SqlServer.SqlTypesAssemblyLoader _loader;
	}
}
