using System;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Spatial;
using System.Data.Entity.SqlServer.Utilities;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x02000017 RID: 23
	internal class SqlTypesAssembly
	{
		// Token: 0x0600022F RID: 559 RVA: 0x0000BEE4 File Offset: 0x0000A0E4
		public SqlTypesAssembly()
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000BEEC File Offset: 0x0000A0EC
		public SqlTypesAssembly(global::System.Reflection.Assembly sqlSpatialAssembly)
		{
			global::System.Type type = sqlSpatialAssembly.GetType("Microsoft.SqlServer.Types.SqlHierarchyId", true);
			global::System.Type type2 = sqlSpatialAssembly.GetType("Microsoft.SqlServer.Types.SqlGeography", true);
			global::System.Type type3 = sqlSpatialAssembly.GetType("Microsoft.SqlServer.Types.SqlGeometry", true);
			this.SqlHierarchyIdType = type;
			this.sqlHierarchyIdParse = global::System.Data.Entity.SqlServer.SqlTypesAssembly.CreateStaticConstructorDelegateHierarchyId<string>(type, "Parse");
			this.SqlGeographyType = type2;
			this.sqlGeographyFromWKTString = global::System.Data.Entity.SqlServer.SqlTypesAssembly.CreateStaticConstructorDelegate<string>(type2, "STGeomFromText");
			this.sqlGeographyFromWKBByteArray = global::System.Data.Entity.SqlServer.SqlTypesAssembly.CreateStaticConstructorDelegate<byte[]>(type2, "STGeomFromWKB");
			this.sqlGeographyFromGMLReader = global::System.Data.Entity.SqlServer.SqlTypesAssembly.CreateStaticConstructorDelegate<global::System.Xml.XmlReader>(type2, "GeomFromGml");
			this.SqlGeometryType = type3;
			this.sqlGeometryFromWKTString = global::System.Data.Entity.SqlServer.SqlTypesAssembly.CreateStaticConstructorDelegate<string>(type3, "STGeomFromText");
			this.sqlGeometryFromWKBByteArray = global::System.Data.Entity.SqlServer.SqlTypesAssembly.CreateStaticConstructorDelegate<byte[]>(type3, "STGeomFromWKB");
			this.sqlGeometryFromGMLReader = global::System.Data.Entity.SqlServer.SqlTypesAssembly.CreateStaticConstructorDelegate<global::System.Xml.XmlReader>(type3, "GeomFromGml");
			global::System.Reflection.MethodInfo publicInstanceMethod = this.SqlGeometryType.GetPublicInstanceMethod("STAsText", new global::System.Type[0]);
			this.SqlCharsType = publicInstanceMethod.ReturnType;
			this.SqlStringType = this.SqlCharsType.Assembly().GetType("System.Data.SqlTypes.SqlString", true);
			this.SqlBooleanType = this.SqlCharsType.Assembly().GetType("System.Data.SqlTypes.SqlBoolean", true);
			this.SqlBytesType = this.SqlCharsType.Assembly().GetType("System.Data.SqlTypes.SqlBytes", true);
			this.SqlDoubleType = this.SqlCharsType.Assembly().GetType("System.Data.SqlTypes.SqlDouble", true);
			this.SqlInt32Type = this.SqlCharsType.Assembly().GetType("System.Data.SqlTypes.SqlInt32", true);
			this.SqlXmlType = this.SqlCharsType.Assembly().GetType("System.Data.SqlTypes.SqlXml", true);
			this.sqlBytesFromByteArray = global::System.Data.Entity.SqlServer.Expressions.Lambda<byte[], object>("binaryValue", (global::System.Linq.Expressions.ParameterExpression bytesVal) => global::System.Data.Entity.SqlServer.SqlTypesAssembly.BuildConvertToSqlBytes(bytesVal, this.SqlBytesType)).Compile();
			this.sqlStringFromString = global::System.Data.Entity.SqlServer.Expressions.Lambda<string, object>("stringValue", (global::System.Linq.Expressions.ParameterExpression stringVal) => global::System.Data.Entity.SqlServer.SqlTypesAssembly.BuildConvertToSqlString(stringVal, this.SqlStringType)).Compile();
			this.sqlCharsFromString = global::System.Data.Entity.SqlServer.Expressions.Lambda<string, object>("stringValue", (global::System.Linq.Expressions.ParameterExpression stringVal) => global::System.Data.Entity.SqlServer.SqlTypesAssembly.BuildConvertToSqlChars(stringVal, this.SqlCharsType)).Compile();
			this.sqlXmlFromXmlReader = global::System.Data.Entity.SqlServer.Expressions.Lambda<global::System.Xml.XmlReader, object>("readerVaue", (global::System.Linq.Expressions.ParameterExpression readerVal) => global::System.Data.Entity.SqlServer.SqlTypesAssembly.BuildConvertToSqlXml(readerVal, this.SqlXmlType)).Compile();
			this.sqlBooleanToBoolean = global::System.Data.Entity.SqlServer.Expressions.Lambda<object, bool>("sqlBooleanValue", (global::System.Linq.Expressions.ParameterExpression sqlBoolVal) => sqlBoolVal.ConvertTo(this.SqlBooleanType).ConvertTo<bool>()).Compile();
			this.sqlBooleanToNullableBoolean = global::System.Data.Entity.SqlServer.Expressions.Lambda<object, bool?>("sqlBooleanValue", (global::System.Linq.Expressions.ParameterExpression sqlBoolVal) => sqlBoolVal.ConvertTo(this.SqlBooleanType).Property("IsNull").IfTrueThen(global::System.Data.Entity.SqlServer.Expressions.Null<bool?>()).Else(sqlBoolVal.ConvertTo(this.SqlBooleanType).ConvertTo<bool>().ConvertTo<bool?>())).Compile();
			this.sqlBytesToByteArray = global::System.Data.Entity.SqlServer.Expressions.Lambda<object, byte[]>("sqlBytesValue", (global::System.Linq.Expressions.ParameterExpression sqlBytesVal) => sqlBytesVal.ConvertTo(this.SqlBytesType).Property("Value")).Compile();
			this.sqlCharsToString = global::System.Data.Entity.SqlServer.Expressions.Lambda<object, string>("sqlCharsValue", (global::System.Linq.Expressions.ParameterExpression sqlCharsVal) => sqlCharsVal.ConvertTo(this.SqlCharsType).Call("ToSqlString").Property("Value")).Compile();
			this.sqlStringToString = global::System.Data.Entity.SqlServer.Expressions.Lambda<object, string>("sqlStringValue", (global::System.Linq.Expressions.ParameterExpression sqlStringVal) => sqlStringVal.ConvertTo(this.SqlStringType).Property("Value")).Compile();
			this.sqlDoubleToDouble = global::System.Data.Entity.SqlServer.Expressions.Lambda<object, double>("sqlDoubleValue", (global::System.Linq.Expressions.ParameterExpression sqlDoubleVal) => sqlDoubleVal.ConvertTo(this.SqlDoubleType).ConvertTo<double>()).Compile();
			this.sqlDoubleToNullableDouble = global::System.Data.Entity.SqlServer.Expressions.Lambda<object, double?>("sqlDoubleValue", (global::System.Linq.Expressions.ParameterExpression sqlDoubleVal) => sqlDoubleVal.ConvertTo(this.SqlDoubleType).Property("IsNull").IfTrueThen(global::System.Data.Entity.SqlServer.Expressions.Null<double?>()).Else(sqlDoubleVal.ConvertTo(this.SqlDoubleType).ConvertTo<double>().ConvertTo<double?>())).Compile();
			this.sqlInt32ToInt = global::System.Data.Entity.SqlServer.Expressions.Lambda<object, int>("sqlInt32Value", (global::System.Linq.Expressions.ParameterExpression sqlInt32Val) => sqlInt32Val.ConvertTo(this.SqlInt32Type).ConvertTo<int>()).Compile();
			this.sqlInt32ToNullableInt = global::System.Data.Entity.SqlServer.Expressions.Lambda<object, int?>("sqlInt32Value", (global::System.Linq.Expressions.ParameterExpression sqlInt32Val) => sqlInt32Val.ConvertTo(this.SqlInt32Type).Property("IsNull").IfTrueThen(global::System.Data.Entity.SqlServer.Expressions.Null<int?>()).Else(sqlInt32Val.ConvertTo(this.SqlInt32Type).ConvertTo<int>().ConvertTo<int?>())).Compile();
			this.sqlXmlToString = global::System.Data.Entity.SqlServer.Expressions.Lambda<object, string>("sqlXmlValue", (global::System.Linq.Expressions.ParameterExpression sqlXmlVal) => sqlXmlVal.ConvertTo(this.SqlXmlType).Property("Value")).Compile();
			this.isSqlGeographyNull = global::System.Data.Entity.SqlServer.Expressions.Lambda<object, bool>("sqlGeographyValue", (global::System.Linq.Expressions.ParameterExpression sqlGeographyValue) => sqlGeographyValue.ConvertTo(this.SqlGeographyType).Property("IsNull")).Compile();
			this.isSqlGeometryNull = global::System.Data.Entity.SqlServer.Expressions.Lambda<object, bool>("sqlGeometryValue", (global::System.Linq.Expressions.ParameterExpression sqlGeometryValue) => sqlGeometryValue.ConvertTo(this.SqlGeometryType).Property("IsNull")).Compile();
			this.geographyAsTextZMAsSqlChars = global::System.Data.Entity.SqlServer.Expressions.Lambda<object, object>("sqlGeographyValue", (global::System.Linq.Expressions.ParameterExpression sqlGeographyValue) => sqlGeographyValue.ConvertTo(this.SqlGeographyType).Call("AsTextZM")).Compile();
			this.geometryAsTextZMAsSqlChars = global::System.Data.Entity.SqlServer.Expressions.Lambda<object, object>("sqlGeometryValue", (global::System.Linq.Expressions.ParameterExpression sqlGeometryValue) => sqlGeometryValue.ConvertTo(this.SqlGeometryType).Call("AsTextZM")).Compile();
			this._smiSqlGeographyParse = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("Parse", new global::System.Type[]
			{
				this.SqlStringType
			}), true);
			this._smiSqlGeographyStGeomFromText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("STGeomFromText", new global::System.Type[]
			{
				this.SqlCharsType,
				typeof(int)
			}), true);
			this._smiSqlGeographyStPointFromText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("STPointFromText", new global::System.Type[]
			{
				this.SqlCharsType,
				typeof(int)
			}), true);
			this._smiSqlGeographyStLineFromText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("STLineFromText", new global::System.Type[]
			{
				this.SqlCharsType,
				typeof(int)
			}), true);
			this._smiSqlGeographyStPolyFromText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("STPolyFromText", new global::System.Type[]
			{
				this.SqlCharsType,
				typeof(int)
			}), true);
			this._smiSqlGeographyStmPointFromText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("STMPointFromText", new global::System.Type[]
			{
				this.SqlCharsType,
				typeof(int)
			}), true);
			this._smiSqlGeographyStmLineFromText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("STMLineFromText", new global::System.Type[]
			{
				this.SqlCharsType,
				typeof(int)
			}), true);
			this._smiSqlGeographyStmPolyFromText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("STMPolyFromText", new global::System.Type[]
			{
				this.SqlCharsType,
				typeof(int)
			}), true);
			this._smiSqlGeographyStGeomCollFromText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("STGeomCollFromText", new global::System.Type[]
			{
				this.SqlCharsType,
				typeof(int)
			}), true);
			this._smiSqlGeographyStGeomFromWkb = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("STGeomFromWKB", new global::System.Type[]
			{
				this.SqlBytesType,
				typeof(int)
			}), true);
			this._smiSqlGeographyStPointFromWkb = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("STPointFromWKB", new global::System.Type[]
			{
				this.SqlBytesType,
				typeof(int)
			}), true);
			this._smiSqlGeographyStLineFromWkb = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("STLineFromWKB", new global::System.Type[]
			{
				this.SqlBytesType,
				typeof(int)
			}), true);
			this._smiSqlGeographyStPolyFromWkb = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("STPolyFromWKB", new global::System.Type[]
			{
				this.SqlBytesType,
				typeof(int)
			}), true);
			this._smiSqlGeographyStmPointFromWkb = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("STMPointFromWKB", new global::System.Type[]
			{
				this.SqlBytesType,
				typeof(int)
			}), true);
			this._smiSqlGeographyStmLineFromWkb = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("STMLineFromWKB", new global::System.Type[]
			{
				this.SqlBytesType,
				typeof(int)
			}), true);
			this._smiSqlGeographyStmPolyFromWkb = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("STMPolyFromWKB", new global::System.Type[]
			{
				this.SqlBytesType,
				typeof(int)
			}), true);
			this._smiSqlGeographyStGeomCollFromWkb = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("STGeomCollFromWKB", new global::System.Type[]
			{
				this.SqlBytesType,
				typeof(int)
			}), true);
			this._smiSqlGeographyGeomFromGml = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyStaticMethod("GeomFromGml", new global::System.Type[]
			{
				this.SqlXmlType,
				typeof(int)
			}), true);
			this._ipiSqlGeographyStSrid = new global::System.Lazy<global::System.Reflection.PropertyInfo>(() => this.FindSqlGeographyProperty("STSrid"), true);
			this._imiSqlGeographyStGeometryType = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STGeometryType", new global::System.Type[0]), true);
			this._imiSqlGeographyStDimension = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STDimension", new global::System.Type[0]), true);
			this._imiSqlGeographyStAsBinary = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STAsBinary", new global::System.Type[0]), true);
			this._imiSqlGeographyAsGml = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("AsGml", new global::System.Type[0]), true);
			this._imiSqlGeographyStAsText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STAsText", new global::System.Type[0]), true);
			this._imiSqlGeographyStIsEmpty = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STIsEmpty", new global::System.Type[0]), true);
			this._imiSqlGeographyStEquals = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STEquals", new global::System.Type[]
			{
				this.SqlGeographyType
			}), true);
			this._imiSqlGeographyStDisjoint = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STDisjoint", new global::System.Type[]
			{
				this.SqlGeographyType
			}), true);
			this._imiSqlGeographyStIntersects = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STIntersects", new global::System.Type[]
			{
				this.SqlGeographyType
			}), true);
			this._imiSqlGeographyStBuffer = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STBuffer", new global::System.Type[]
			{
				typeof(double)
			}), true);
			this._imiSqlGeographyStDistance = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STDistance", new global::System.Type[]
			{
				this.SqlGeographyType
			}), true);
			this._imiSqlGeographyStIntersection = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STIntersection", new global::System.Type[]
			{
				this.SqlGeographyType
			}), true);
			this._imiSqlGeographyStUnion = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STUnion", new global::System.Type[]
			{
				this.SqlGeographyType
			}), true);
			this._imiSqlGeographyStDifference = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STDifference", new global::System.Type[]
			{
				this.SqlGeographyType
			}), true);
			this._imiSqlGeographyStSymDifference = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STSymDifference", new global::System.Type[]
			{
				this.SqlGeographyType
			}), true);
			this._imiSqlGeographyStNumGeometries = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STNumGeometries", new global::System.Type[0]), true);
			this._imiSqlGeographyStGeometryN = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STGeometryN", new global::System.Type[]
			{
				typeof(int)
			}), true);
			this._ipiSqlGeographyLat = new global::System.Lazy<global::System.Reflection.PropertyInfo>(() => this.FindSqlGeographyProperty("Lat"), true);
			this._ipiSqlGeographyLong = new global::System.Lazy<global::System.Reflection.PropertyInfo>(() => this.FindSqlGeographyProperty("Long"), true);
			this._ipiSqlGeographyZ = new global::System.Lazy<global::System.Reflection.PropertyInfo>(() => this.FindSqlGeographyProperty("Z"), true);
			this._ipiSqlGeographyM = new global::System.Lazy<global::System.Reflection.PropertyInfo>(() => this.FindSqlGeographyProperty("M"), true);
			this._imiSqlGeographyStLength = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STLength", new global::System.Type[0]), true);
			this._imiSqlGeographyStStartPoint = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STStartPoint", new global::System.Type[0]), true);
			this._imiSqlGeographyStEndPoint = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STEndPoint", new global::System.Type[0]), true);
			this._imiSqlGeographyStIsClosed = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STIsClosed", new global::System.Type[0]), true);
			this._imiSqlGeographyStNumPoints = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STNumPoints", new global::System.Type[0]), true);
			this._imiSqlGeographyStPointN = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STPointN", new global::System.Type[]
			{
				typeof(int)
			}), true);
			this._imiSqlGeographyStArea = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeographyMethod("STArea", new global::System.Type[0]), true);
			this._smiSqlGeometryParse = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("Parse", new global::System.Type[]
			{
				this.SqlStringType
			}), true);
			this._smiSqlGeometryStGeomFromText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("STGeomFromText", new global::System.Type[]
			{
				this.SqlCharsType,
				typeof(int)
			}), true);
			this._smiSqlGeometryStPointFromText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("STPointFromText", new global::System.Type[]
			{
				this.SqlCharsType,
				typeof(int)
			}), true);
			this._smiSqlGeometryStLineFromText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("STLineFromText", new global::System.Type[]
			{
				this.SqlCharsType,
				typeof(int)
			}), true);
			this._smiSqlGeometryStPolyFromText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("STPolyFromText", new global::System.Type[]
			{
				this.SqlCharsType,
				typeof(int)
			}), true);
			this._smiSqlGeometryStmPointFromText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("STMPointFromText", new global::System.Type[]
			{
				this.SqlCharsType,
				typeof(int)
			}), true);
			this._smiSqlGeometryStmLineFromText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("STMLineFromText", new global::System.Type[]
			{
				this.SqlCharsType,
				typeof(int)
			}), true);
			this._smiSqlGeometryStmPolyFromText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("STMPolyFromText", new global::System.Type[]
			{
				this.SqlCharsType,
				typeof(int)
			}), true);
			this._smiSqlGeometryStGeomCollFromText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("STGeomCollFromText", new global::System.Type[]
			{
				this.SqlCharsType,
				typeof(int)
			}), true);
			this._smiSqlGeometryStGeomFromWkb = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("STGeomFromWKB", new global::System.Type[]
			{
				this.SqlBytesType,
				typeof(int)
			}), true);
			this._smiSqlGeometryStPointFromWkb = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("STPointFromWKB", new global::System.Type[]
			{
				this.SqlBytesType,
				typeof(int)
			}), true);
			this._smiSqlGeometryStLineFromWkb = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("STLineFromWKB", new global::System.Type[]
			{
				this.SqlBytesType,
				typeof(int)
			}), true);
			this._smiSqlGeometryStPolyFromWkb = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("STPolyFromWKB", new global::System.Type[]
			{
				this.SqlBytesType,
				typeof(int)
			}), true);
			this._smiSqlGeometryStmPointFromWkb = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("STMPointFromWKB", new global::System.Type[]
			{
				this.SqlBytesType,
				typeof(int)
			}), true);
			this._smiSqlGeometryStmLineFromWkb = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("STMLineFromWKB", new global::System.Type[]
			{
				this.SqlBytesType,
				typeof(int)
			}), true);
			this._smiSqlGeometryStmPolyFromWkb = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("STMPolyFromWKB", new global::System.Type[]
			{
				this.SqlBytesType,
				typeof(int)
			}), true);
			this._smiSqlGeometryStGeomCollFromWkb = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("STGeomCollFromWKB", new global::System.Type[]
			{
				this.SqlBytesType,
				typeof(int)
			}), true);
			this._smiSqlGeometryGeomFromGml = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryStaticMethod("GeomFromGml", new global::System.Type[]
			{
				this.SqlXmlType,
				typeof(int)
			}), true);
			this._ipiSqlGeometryStSrid = new global::System.Lazy<global::System.Reflection.PropertyInfo>(() => this.FindSqlGeometryProperty("STSrid"), true);
			this._imiSqlGeometryStGeometryType = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STGeometryType", new global::System.Type[0]), true);
			this._imiSqlGeometryStDimension = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STDimension", new global::System.Type[0]), true);
			this._imiSqlGeometryStEnvelope = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STEnvelope", new global::System.Type[0]), true);
			this._imiSqlGeometryStAsBinary = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STAsBinary", new global::System.Type[0]), true);
			this._imiSqlGeometryAsGml = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("AsGml", new global::System.Type[0]), true);
			this._imiSqlGeometryStAsText = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STAsText", new global::System.Type[0]), true);
			this._imiSqlGeometryStIsEmpty = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STIsEmpty", new global::System.Type[0]), true);
			this._imiSqlGeometryStIsSimple = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STIsSimple", new global::System.Type[0]), true);
			this._imiSqlGeometryStBoundary = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STBoundary", new global::System.Type[0]), true);
			this._imiSqlGeometryStIsValid = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STIsValid", new global::System.Type[0]), true);
			this._imiSqlGeometryStEquals = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STEquals", new global::System.Type[]
			{
				this.SqlGeometryType
			}), true);
			this._imiSqlGeometryStDisjoint = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STDisjoint", new global::System.Type[]
			{
				this.SqlGeometryType
			}), true);
			this._imiSqlGeometryStIntersects = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STIntersects", new global::System.Type[]
			{
				this.SqlGeometryType
			}), true);
			this._imiSqlGeometryStTouches = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STTouches", new global::System.Type[]
			{
				this.SqlGeometryType
			}), true);
			this._imiSqlGeometryStCrosses = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STCrosses", new global::System.Type[]
			{
				this.SqlGeometryType
			}), true);
			this._imiSqlGeometryStWithin = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STWithin", new global::System.Type[]
			{
				this.SqlGeometryType
			}), true);
			this._imiSqlGeometryStContains = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STContains", new global::System.Type[]
			{
				this.SqlGeometryType
			}), true);
			this._imiSqlGeometryStOverlaps = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STOverlaps", new global::System.Type[]
			{
				this.SqlGeometryType
			}), true);
			this._imiSqlGeometryStRelate = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STRelate", new global::System.Type[]
			{
				this.SqlGeometryType,
				typeof(string)
			}), true);
			this._imiSqlGeometryStBuffer = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STBuffer", new global::System.Type[]
			{
				typeof(double)
			}), true);
			this._imiSqlGeometryStDistance = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STDistance", new global::System.Type[]
			{
				this.SqlGeometryType
			}), true);
			this._imiSqlGeometryStConvexHull = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STConvexHull", new global::System.Type[0]), true);
			this._imiSqlGeometryStIntersection = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STIntersection", new global::System.Type[]
			{
				this.SqlGeometryType
			}), true);
			this._imiSqlGeometryStUnion = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STUnion", new global::System.Type[]
			{
				this.SqlGeometryType
			}), true);
			this._imiSqlGeometryStDifference = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STDifference", new global::System.Type[]
			{
				this.SqlGeometryType
			}), true);
			this._imiSqlGeometryStSymDifference = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STSymDifference", new global::System.Type[]
			{
				this.SqlGeometryType
			}), true);
			this._imiSqlGeometryStNumGeometries = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STNumGeometries", new global::System.Type[0]), true);
			this._imiSqlGeometryStGeometryN = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STGeometryN", new global::System.Type[]
			{
				typeof(int)
			}), true);
			this._ipiSqlGeometryStx = new global::System.Lazy<global::System.Reflection.PropertyInfo>(() => this.FindSqlGeometryProperty("STX"), true);
			this._ipiSqlGeometrySty = new global::System.Lazy<global::System.Reflection.PropertyInfo>(() => this.FindSqlGeometryProperty("STY"), true);
			this._ipiSqlGeometryZ = new global::System.Lazy<global::System.Reflection.PropertyInfo>(() => this.FindSqlGeometryProperty("Z"), true);
			this._ipiSqlGeometryM = new global::System.Lazy<global::System.Reflection.PropertyInfo>(() => this.FindSqlGeometryProperty("M"), true);
			this._imiSqlGeometryStLength = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STLength", new global::System.Type[0]), true);
			this._imiSqlGeometryStStartPoint = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STStartPoint", new global::System.Type[0]), true);
			this._imiSqlGeometryStEndPoint = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STEndPoint", new global::System.Type[0]), true);
			this._imiSqlGeometryStIsClosed = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STIsClosed", new global::System.Type[0]), true);
			this._imiSqlGeometryStIsRing = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STIsRing", new global::System.Type[0]), true);
			this._imiSqlGeometryStNumPoints = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STNumPoints", new global::System.Type[0]), true);
			this._imiSqlGeometryStPointN = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STPointN", new global::System.Type[]
			{
				typeof(int)
			}), true);
			this._imiSqlGeometryStArea = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STArea", new global::System.Type[0]), true);
			this._imiSqlGeometryStCentroid = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STCentroid", new global::System.Type[0]), true);
			this._imiSqlGeometryStPointOnSurface = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STPointOnSurface", new global::System.Type[0]), true);
			this._imiSqlGeometryStExteriorRing = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STExteriorRing", new global::System.Type[0]), true);
			this._imiSqlGeometryStNumInteriorRing = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STNumInteriorRing", new global::System.Type[0]), true);
			this._imiSqlGeometryStInteriorRingN = new global::System.Lazy<global::System.Reflection.MethodInfo>(() => this.FindSqlGeometryMethod("STInteriorRingN", new global::System.Type[]
			{
				typeof(int)
			}), true);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0000CD37 File Offset: 0x0000AF37
		// (set) Token: 0x06000232 RID: 562 RVA: 0x0000CD3F File Offset: 0x0000AF3F
		internal global::System.Type SqlBooleanType { get; private set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000CD48 File Offset: 0x0000AF48
		// (set) Token: 0x06000234 RID: 564 RVA: 0x0000CD50 File Offset: 0x0000AF50
		internal global::System.Type SqlBytesType { get; private set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000CD59 File Offset: 0x0000AF59
		// (set) Token: 0x06000236 RID: 566 RVA: 0x0000CD61 File Offset: 0x0000AF61
		internal global::System.Type SqlCharsType { get; private set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000CD6A File Offset: 0x0000AF6A
		// (set) Token: 0x06000238 RID: 568 RVA: 0x0000CD72 File Offset: 0x0000AF72
		internal global::System.Type SqlStringType { get; private set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000CD7B File Offset: 0x0000AF7B
		// (set) Token: 0x0600023A RID: 570 RVA: 0x0000CD83 File Offset: 0x0000AF83
		internal global::System.Type SqlDoubleType { get; private set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000CD8C File Offset: 0x0000AF8C
		// (set) Token: 0x0600023C RID: 572 RVA: 0x0000CD94 File Offset: 0x0000AF94
		internal global::System.Type SqlInt32Type { get; private set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0000CD9D File Offset: 0x0000AF9D
		// (set) Token: 0x0600023E RID: 574 RVA: 0x0000CDA5 File Offset: 0x0000AFA5
		internal global::System.Type SqlXmlType { get; private set; }

		// Token: 0x0600023F RID: 575 RVA: 0x0000CDAE File Offset: 0x0000AFAE
		internal bool SqlBooleanToBoolean(object sqlBooleanValue)
		{
			return this.sqlBooleanToBoolean(sqlBooleanValue);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000CDBC File Offset: 0x0000AFBC
		internal bool? SqlBooleanToNullableBoolean(object sqlBooleanValue)
		{
			if (this.sqlBooleanToBoolean == null)
			{
				return null;
			}
			return this.sqlBooleanToNullableBoolean(sqlBooleanValue);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000CDE7 File Offset: 0x0000AFE7
		internal object SqlBytesFromByteArray(byte[] binaryValue)
		{
			return this.sqlBytesFromByteArray(binaryValue);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000CDF5 File Offset: 0x0000AFF5
		internal byte[] SqlBytesToByteArray(object sqlBytesValue)
		{
			if (sqlBytesValue == null)
			{
				return null;
			}
			return this.sqlBytesToByteArray(sqlBytesValue);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000CE08 File Offset: 0x0000B008
		internal object SqlStringFromString(string stringValue)
		{
			return this.sqlStringFromString(stringValue);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000CE16 File Offset: 0x0000B016
		internal object SqlCharsFromString(string stringValue)
		{
			return this.sqlCharsFromString(stringValue);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000CE24 File Offset: 0x0000B024
		internal string SqlCharsToString(object sqlCharsValue)
		{
			if (sqlCharsValue == null)
			{
				return null;
			}
			return this.sqlCharsToString(sqlCharsValue);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000CE37 File Offset: 0x0000B037
		internal string SqlStringToString(object sqlStringValue)
		{
			if (sqlStringValue == null)
			{
				return null;
			}
			return this.sqlStringToString(sqlStringValue);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000CE4A File Offset: 0x0000B04A
		internal double SqlDoubleToDouble(object sqlDoubleValue)
		{
			return this.sqlDoubleToDouble(sqlDoubleValue);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000CE58 File Offset: 0x0000B058
		internal double? SqlDoubleToNullableDouble(object sqlDoubleValue)
		{
			if (sqlDoubleValue == null)
			{
				return null;
			}
			return this.sqlDoubleToNullableDouble(sqlDoubleValue);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000CE7E File Offset: 0x0000B07E
		internal int SqlInt32ToInt(object sqlInt32Value)
		{
			return this.sqlInt32ToInt(sqlInt32Value);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000CE8C File Offset: 0x0000B08C
		internal int? SqlInt32ToNullableInt(object sqlInt32Value)
		{
			if (sqlInt32Value == null)
			{
				return null;
			}
			return this.sqlInt32ToNullableInt(sqlInt32Value);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000CEB4 File Offset: 0x0000B0B4
		internal object SqlXmlFromString(string stringValue)
		{
			global::System.Xml.XmlReader arg = global::System.Data.Entity.SqlServer.SqlTypesAssembly.XmlReaderFromString(stringValue);
			return this.sqlXmlFromXmlReader(arg);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000CED4 File Offset: 0x0000B0D4
		internal string SqlXmlToString(object sqlXmlValue)
		{
			if (sqlXmlValue == null)
			{
				return null;
			}
			return this.sqlXmlToString(sqlXmlValue);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000CEE7 File Offset: 0x0000B0E7
		internal bool IsSqlGeographyNull(object sqlGeographyValue)
		{
			return sqlGeographyValue == null || this.isSqlGeographyNull(sqlGeographyValue);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000CEFA File Offset: 0x0000B0FA
		internal bool IsSqlGeometryNull(object sqlGeometryValue)
		{
			return sqlGeometryValue == null || this.isSqlGeometryNull(sqlGeometryValue);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000CF10 File Offset: 0x0000B110
		internal string GeographyAsTextZM(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			if (geographyValue == null)
			{
				return null;
			}
			object arg = this.ConvertToSqlTypesGeography(geographyValue);
			object sqlCharsValue = this.geographyAsTextZMAsSqlChars(arg);
			return this.SqlCharsToString(sqlCharsValue);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000CF40 File Offset: 0x0000B140
		internal string GeometryAsTextZM(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			if (geometryValue == null)
			{
				return null;
			}
			object arg = this.ConvertToSqlTypesGeometry(geometryValue);
			object sqlCharsValue = this.geometryAsTextZMAsSqlChars(arg);
			return this.SqlCharsToString(sqlCharsValue);
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000CF6E File Offset: 0x0000B16E
		// (set) Token: 0x06000252 RID: 594 RVA: 0x0000CF76 File Offset: 0x0000B176
		internal global::System.Type SqlHierarchyIdType { get; private set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000CF7F File Offset: 0x0000B17F
		// (set) Token: 0x06000254 RID: 596 RVA: 0x0000CF87 File Offset: 0x0000B187
		internal global::System.Type SqlGeographyType { get; private set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000CF90 File Offset: 0x0000B190
		// (set) Token: 0x06000256 RID: 598 RVA: 0x0000CF98 File Offset: 0x0000B198
		internal global::System.Type SqlGeometryType { get; private set; }

		// Token: 0x06000257 RID: 599 RVA: 0x0000CFA1 File Offset: 0x0000B1A1
		internal object ConvertToSqlTypesHierarchyId(global::System.Data.Entity.Hierarchy.HierarchyId hierarchyIdValue)
		{
			return this.GetSqlTypesHierarchyIdValue(hierarchyIdValue.ToString());
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000CFAF File Offset: 0x0000B1AF
		internal object ConvertToSqlTypesGeography(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			return this.GetSqlTypesSpatialValue(geographyValue.AsSpatialValue(), this.SqlGeographyType);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000CFC3 File Offset: 0x0000B1C3
		internal object SqlTypesGeographyFromBinary(byte[] wellKnownBinary, int srid)
		{
			return this.sqlGeographyFromWKBByteArray(wellKnownBinary, srid);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000CFD2 File Offset: 0x0000B1D2
		internal object SqlTypesGeographyFromText(string wellKnownText, int srid)
		{
			return this.sqlGeographyFromWKTString(wellKnownText, srid);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000CFE1 File Offset: 0x0000B1E1
		internal object ConvertToSqlTypesGeometry(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			return this.GetSqlTypesSpatialValue(geometryValue.AsSpatialValue(), this.SqlGeometryType);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000CFF5 File Offset: 0x0000B1F5
		internal object SqlTypesGeometryFromBinary(byte[] wellKnownBinary, int srid)
		{
			return this.sqlGeometryFromWKBByteArray(wellKnownBinary, srid);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000D004 File Offset: 0x0000B204
		internal object SqlTypesGeometryFromText(string wellKnownText, int srid)
		{
			return this.sqlGeometryFromWKTString(wellKnownText, srid);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000D013 File Offset: 0x0000B213
		private object GetSqlTypesHierarchyIdValue(string hierarchyIdValue)
		{
			return this.sqlHierarchyIdParse(hierarchyIdValue);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000D024 File Offset: 0x0000B224
		private object GetSqlTypesSpatialValue(global::System.Data.Entity.SqlServer.IDbSpatialValue spatialValue, global::System.Type requiredProviderValueType)
		{
			object providerValue = spatialValue.ProviderValue;
			if (providerValue != null && providerValue.GetType() == requiredProviderValueType)
			{
				return providerValue;
			}
			int? coordinateSystemId = spatialValue.CoordinateSystemId;
			if (coordinateSystemId != null)
			{
				byte[] wellKnownBinary = spatialValue.WellKnownBinary;
				if (wellKnownBinary != null)
				{
					if (!spatialValue.IsGeography)
					{
						return this.sqlGeometryFromWKBByteArray(wellKnownBinary, coordinateSystemId.Value);
					}
					return this.sqlGeographyFromWKBByteArray(wellKnownBinary, coordinateSystemId.Value);
				}
				else
				{
					string wellKnownText = spatialValue.WellKnownText;
					if (wellKnownText != null)
					{
						if (!spatialValue.IsGeography)
						{
							return this.sqlGeometryFromWKTString(wellKnownText, coordinateSystemId.Value);
						}
						return this.sqlGeographyFromWKTString(wellKnownText, coordinateSystemId.Value);
					}
					else
					{
						string gmlString = spatialValue.GmlString;
						if (gmlString != null)
						{
							global::System.Xml.XmlReader arg = global::System.Data.Entity.SqlServer.SqlTypesAssembly.XmlReaderFromString(gmlString);
							if (!spatialValue.IsGeography)
							{
								return this.sqlGeometryFromGMLReader(arg, coordinateSystemId.Value);
							}
							return this.sqlGeographyFromGMLReader(arg, coordinateSystemId.Value);
						}
					}
				}
			}
			throw spatialValue.NotSqlCompatible();
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000D11F File Offset: 0x0000B31F
		private static global::System.Xml.XmlReader XmlReaderFromString(string stringValue)
		{
			return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(stringValue));
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000D12C File Offset: 0x0000B32C
		private static global::System.Func<TArg, object> CreateStaticConstructorDelegateHierarchyId<TArg>(global::System.Type hierarchyIdType, string methodName)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(TArg));
			global::System.Reflection.MethodInfo method = hierarchyIdType.GetMethod(methodName, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
			global::System.Linq.Expressions.Expression expression = global::System.Data.Entity.SqlServer.SqlTypesAssembly.BuildSqlString(parameterExpression, method.GetParameters()[0].ParameterType);
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TArg, object>>(global::System.Linq.Expressions.Expression.Convert(global::System.Linq.Expressions.Expression.Call(null, method, new global::System.Linq.Expressions.Expression[]
			{
				expression
			}), typeof(object)), new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			}).Compile();
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000D19C File Offset: 0x0000B39C
		private static global::System.Func<TArg, int, object> CreateStaticConstructorDelegate<TArg>(global::System.Type spatialType, string methodName)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(TArg));
			global::System.Linq.Expressions.ParameterExpression parameterExpression2 = global::System.Linq.Expressions.Expression.Parameter(typeof(int));
			global::System.Reflection.MethodInfo onlyDeclaredMethod = spatialType.GetOnlyDeclaredMethod(methodName);
			global::System.Linq.Expressions.Expression arg = global::System.Data.Entity.SqlServer.SqlTypesAssembly.BuildConvertToSqlType(parameterExpression, onlyDeclaredMethod.GetParameters()[0].ParameterType);
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TArg, int, object>>(global::System.Linq.Expressions.Expression.Call(null, onlyDeclaredMethod, arg, parameterExpression2), new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			}).Compile();
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000D208 File Offset: 0x0000B408
		private static global::System.Linq.Expressions.Expression BuildConvertToSqlType(global::System.Linq.Expressions.Expression toConvert, global::System.Type convertTo)
		{
			if (toConvert.Type == typeof(byte[]))
			{
				return global::System.Data.Entity.SqlServer.SqlTypesAssembly.BuildConvertToSqlBytes(toConvert, convertTo);
			}
			if (toConvert.Type == typeof(string))
			{
				if (convertTo.Name == "SqlString")
				{
					return global::System.Data.Entity.SqlServer.SqlTypesAssembly.BuildConvertToSqlString(toConvert, convertTo);
				}
				return global::System.Data.Entity.SqlServer.SqlTypesAssembly.BuildConvertToSqlChars(toConvert, convertTo);
			}
			else
			{
				if (toConvert.Type == typeof(global::System.Xml.XmlReader))
				{
					return global::System.Data.Entity.SqlServer.SqlTypesAssembly.BuildConvertToSqlXml(toConvert, convertTo);
				}
				return toConvert;
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000D28D File Offset: 0x0000B48D
		private static global::System.Linq.Expressions.Expression BuildConvertToSqlBytes(global::System.Linq.Expressions.Expression toConvert, global::System.Type sqlBytesType)
		{
			return global::System.Linq.Expressions.Expression.New(sqlBytesType.GetDeclaredConstructor(new global::System.Type[]
			{
				toConvert.Type
			}), new global::System.Linq.Expressions.Expression[]
			{
				toConvert
			});
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000D2B4 File Offset: 0x0000B4B4
		private static global::System.Linq.Expressions.Expression BuildConvertToSqlChars(global::System.Linq.Expressions.Expression toConvert, global::System.Type sqlCharsType)
		{
			global::System.Type type = sqlCharsType.Assembly().GetType("System.Data.SqlTypes.SqlString", true);
			global::System.Reflection.ConstructorInfo declaredConstructor = sqlCharsType.GetDeclaredConstructor(new global::System.Type[]
			{
				type
			});
			global::System.Reflection.ConstructorInfo declaredConstructor2 = type.GetDeclaredConstructor(new global::System.Type[]
			{
				typeof(string)
			});
			return global::System.Linq.Expressions.Expression.New(declaredConstructor, new global::System.Linq.Expressions.Expression[]
			{
				global::System.Linq.Expressions.Expression.New(declaredConstructor2, new global::System.Linq.Expressions.Expression[]
				{
					toConvert
				})
			});
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000D31D File Offset: 0x0000B51D
		private static global::System.Linq.Expressions.Expression BuildSqlString(global::System.Linq.Expressions.Expression toConvert, global::System.Type sqlStringType)
		{
			return global::System.Linq.Expressions.Expression.New(sqlStringType.GetConstructor(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public, null, new global::System.Type[]
			{
				typeof(string)
			}, null), new global::System.Linq.Expressions.Expression[]
			{
				toConvert
			});
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000D34B File Offset: 0x0000B54B
		private static global::System.Linq.Expressions.Expression BuildConvertToSqlString(global::System.Linq.Expressions.Expression toConvert, global::System.Type sqlStringType)
		{
			return global::System.Linq.Expressions.Expression.Convert(global::System.Linq.Expressions.Expression.New(sqlStringType.GetDeclaredConstructor(new global::System.Type[]
			{
				typeof(string)
			}), new global::System.Linq.Expressions.Expression[]
			{
				toConvert
			}), typeof(object));
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000D384 File Offset: 0x0000B584
		private static global::System.Linq.Expressions.Expression BuildConvertToSqlXml(global::System.Linq.Expressions.Expression toConvert, global::System.Type sqlXmlType)
		{
			return global::System.Linq.Expressions.Expression.New(sqlXmlType.GetDeclaredConstructor(new global::System.Type[]
			{
				toConvert.Type
			}), new global::System.Linq.Expressions.Expression[]
			{
				toConvert
			});
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000D3AA File Offset: 0x0000B5AA
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyParse
		{
			get
			{
				return this._smiSqlGeographyParse;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000D3B2 File Offset: 0x0000B5B2
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyStGeomFromText
		{
			get
			{
				return this._smiSqlGeographyStGeomFromText;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000D3BA File Offset: 0x0000B5BA
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyStPointFromText
		{
			get
			{
				return this._smiSqlGeographyStPointFromText;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000D3C2 File Offset: 0x0000B5C2
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyStLineFromText
		{
			get
			{
				return this._smiSqlGeographyStLineFromText;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000D3CA File Offset: 0x0000B5CA
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyStPolyFromText
		{
			get
			{
				return this._smiSqlGeographyStPolyFromText;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0000D3D2 File Offset: 0x0000B5D2
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyStmPointFromText
		{
			get
			{
				return this._smiSqlGeographyStmPointFromText;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000D3DA File Offset: 0x0000B5DA
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyStmLineFromText
		{
			get
			{
				return this._smiSqlGeographyStmLineFromText;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000D3E2 File Offset: 0x0000B5E2
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyStmPolyFromText
		{
			get
			{
				return this._smiSqlGeographyStmPolyFromText;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0000D3EA File Offset: 0x0000B5EA
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyStGeomCollFromText
		{
			get
			{
				return this._smiSqlGeographyStGeomCollFromText;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000D3F2 File Offset: 0x0000B5F2
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyStGeomFromWkb
		{
			get
			{
				return this._smiSqlGeographyStGeomFromWkb;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000D3FA File Offset: 0x0000B5FA
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyStPointFromWkb
		{
			get
			{
				return this._smiSqlGeographyStPointFromWkb;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0000D402 File Offset: 0x0000B602
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyStLineFromWkb
		{
			get
			{
				return this._smiSqlGeographyStLineFromWkb;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0000D40A File Offset: 0x0000B60A
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyStPolyFromWkb
		{
			get
			{
				return this._smiSqlGeographyStPolyFromWkb;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0000D412 File Offset: 0x0000B612
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyStmPointFromWkb
		{
			get
			{
				return this._smiSqlGeographyStmPointFromWkb;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000D41A File Offset: 0x0000B61A
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyStmLineFromWkb
		{
			get
			{
				return this._smiSqlGeographyStmLineFromWkb;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0000D422 File Offset: 0x0000B622
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyStmPolyFromWkb
		{
			get
			{
				return this._smiSqlGeographyStmPolyFromWkb;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0000D42A File Offset: 0x0000B62A
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyStGeomCollFromWkb
		{
			get
			{
				return this._smiSqlGeographyStGeomCollFromWkb;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0000D432 File Offset: 0x0000B632
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeographyGeomFromGml
		{
			get
			{
				return this._smiSqlGeographyGeomFromGml;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0000D43A File Offset: 0x0000B63A
		public global::System.Lazy<global::System.Reflection.PropertyInfo> IpiSqlGeographyStSrid
		{
			get
			{
				return this._ipiSqlGeographyStSrid;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0000D442 File Offset: 0x0000B642
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStGeometryType
		{
			get
			{
				return this._imiSqlGeographyStGeometryType;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0000D44A File Offset: 0x0000B64A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStDimension
		{
			get
			{
				return this._imiSqlGeographyStDimension;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000D452 File Offset: 0x0000B652
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStAsBinary
		{
			get
			{
				return this._imiSqlGeographyStAsBinary;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0000D45A File Offset: 0x0000B65A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyAsGml
		{
			get
			{
				return this._imiSqlGeographyAsGml;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0000D462 File Offset: 0x0000B662
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStAsText
		{
			get
			{
				return this._imiSqlGeographyStAsText;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0000D46A File Offset: 0x0000B66A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStIsEmpty
		{
			get
			{
				return this._imiSqlGeographyStIsEmpty;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0000D472 File Offset: 0x0000B672
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStEquals
		{
			get
			{
				return this._imiSqlGeographyStEquals;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0000D47A File Offset: 0x0000B67A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStDisjoint
		{
			get
			{
				return this._imiSqlGeographyStDisjoint;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000D482 File Offset: 0x0000B682
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStIntersects
		{
			get
			{
				return this._imiSqlGeographyStIntersects;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000D48A File Offset: 0x0000B68A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStBuffer
		{
			get
			{
				return this._imiSqlGeographyStBuffer;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000D492 File Offset: 0x0000B692
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStDistance
		{
			get
			{
				return this._imiSqlGeographyStDistance;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000D49A File Offset: 0x0000B69A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStIntersection
		{
			get
			{
				return this._imiSqlGeographyStIntersection;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000D4A2 File Offset: 0x0000B6A2
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStUnion
		{
			get
			{
				return this._imiSqlGeographyStUnion;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0000D4AA File Offset: 0x0000B6AA
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStDifference
		{
			get
			{
				return this._imiSqlGeographyStDifference;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000D4B2 File Offset: 0x0000B6B2
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStSymDifference
		{
			get
			{
				return this._imiSqlGeographyStSymDifference;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0000D4BA File Offset: 0x0000B6BA
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStNumGeometries
		{
			get
			{
				return this._imiSqlGeographyStNumGeometries;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000D4C2 File Offset: 0x0000B6C2
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStGeometryN
		{
			get
			{
				return this._imiSqlGeographyStGeometryN;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0000D4CA File Offset: 0x0000B6CA
		public global::System.Lazy<global::System.Reflection.PropertyInfo> IpiSqlGeographyLat
		{
			get
			{
				return this._ipiSqlGeographyLat;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000D4D2 File Offset: 0x0000B6D2
		public global::System.Lazy<global::System.Reflection.PropertyInfo> IpiSqlGeographyLong
		{
			get
			{
				return this._ipiSqlGeographyLong;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0000D4DA File Offset: 0x0000B6DA
		public global::System.Lazy<global::System.Reflection.PropertyInfo> IpiSqlGeographyZ
		{
			get
			{
				return this._ipiSqlGeographyZ;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0000D4E2 File Offset: 0x0000B6E2
		public global::System.Lazy<global::System.Reflection.PropertyInfo> IpiSqlGeographyM
		{
			get
			{
				return this._ipiSqlGeographyM;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0000D4EA File Offset: 0x0000B6EA
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStLength
		{
			get
			{
				return this._imiSqlGeographyStLength;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000D4F2 File Offset: 0x0000B6F2
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStStartPoint
		{
			get
			{
				return this._imiSqlGeographyStStartPoint;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000D4FA File Offset: 0x0000B6FA
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStEndPoint
		{
			get
			{
				return this._imiSqlGeographyStEndPoint;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000D502 File Offset: 0x0000B702
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStIsClosed
		{
			get
			{
				return this._imiSqlGeographyStIsClosed;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000D50A File Offset: 0x0000B70A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStNumPoints
		{
			get
			{
				return this._imiSqlGeographyStNumPoints;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000D512 File Offset: 0x0000B712
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStPointN
		{
			get
			{
				return this._imiSqlGeographyStPointN;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0000D51A File Offset: 0x0000B71A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeographyStArea
		{
			get
			{
				return this._imiSqlGeographyStArea;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000D522 File Offset: 0x0000B722
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryParse
		{
			get
			{
				return this._smiSqlGeometryParse;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0000D52A File Offset: 0x0000B72A
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryStGeomFromText
		{
			get
			{
				return this._smiSqlGeometryStGeomFromText;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000D532 File Offset: 0x0000B732
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryStPointFromText
		{
			get
			{
				return this._smiSqlGeometryStPointFromText;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0000D53A File Offset: 0x0000B73A
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryStLineFromText
		{
			get
			{
				return this._smiSqlGeometryStLineFromText;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000D542 File Offset: 0x0000B742
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryStPolyFromText
		{
			get
			{
				return this._smiSqlGeometryStPolyFromText;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0000D54A File Offset: 0x0000B74A
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryStmPointFromText
		{
			get
			{
				return this._smiSqlGeometryStmPointFromText;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000D552 File Offset: 0x0000B752
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryStmLineFromText
		{
			get
			{
				return this._smiSqlGeometryStmLineFromText;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0000D55A File Offset: 0x0000B75A
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryStmPolyFromText
		{
			get
			{
				return this._smiSqlGeometryStmPolyFromText;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000D562 File Offset: 0x0000B762
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryStGeomCollFromText
		{
			get
			{
				return this._smiSqlGeometryStGeomCollFromText;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000D56A File Offset: 0x0000B76A
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryStGeomFromWkb
		{
			get
			{
				return this._smiSqlGeometryStGeomFromWkb;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000D572 File Offset: 0x0000B772
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryStPointFromWkb
		{
			get
			{
				return this._smiSqlGeometryStPointFromWkb;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000D57A File Offset: 0x0000B77A
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryStLineFromWkb
		{
			get
			{
				return this._smiSqlGeometryStLineFromWkb;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000D582 File Offset: 0x0000B782
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryStPolyFromWkb
		{
			get
			{
				return this._smiSqlGeometryStPolyFromWkb;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000D58A File Offset: 0x0000B78A
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryStmPointFromWkb
		{
			get
			{
				return this._smiSqlGeometryStmPointFromWkb;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000D592 File Offset: 0x0000B792
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryStmLineFromWkb
		{
			get
			{
				return this._smiSqlGeometryStmLineFromWkb;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000D59A File Offset: 0x0000B79A
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryStmPolyFromWkb
		{
			get
			{
				return this._smiSqlGeometryStmPolyFromWkb;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000D5A2 File Offset: 0x0000B7A2
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryStGeomCollFromWkb
		{
			get
			{
				return this._smiSqlGeometryStGeomCollFromWkb;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000D5AA File Offset: 0x0000B7AA
		public global::System.Lazy<global::System.Reflection.MethodInfo> SmiSqlGeometryGeomFromGml
		{
			get
			{
				return this._smiSqlGeometryGeomFromGml;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000D5B2 File Offset: 0x0000B7B2
		public global::System.Lazy<global::System.Reflection.PropertyInfo> IpiSqlGeometryStSrid
		{
			get
			{
				return this._ipiSqlGeometryStSrid;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000D5BA File Offset: 0x0000B7BA
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStGeometryType
		{
			get
			{
				return this._imiSqlGeometryStGeometryType;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000D5C2 File Offset: 0x0000B7C2
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStDimension
		{
			get
			{
				return this._imiSqlGeometryStDimension;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0000D5CA File Offset: 0x0000B7CA
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStEnvelope
		{
			get
			{
				return this._imiSqlGeometryStEnvelope;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0000D5D2 File Offset: 0x0000B7D2
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStAsBinary
		{
			get
			{
				return this._imiSqlGeometryStAsBinary;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0000D5DA File Offset: 0x0000B7DA
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryAsGml
		{
			get
			{
				return this._imiSqlGeometryAsGml;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000D5E2 File Offset: 0x0000B7E2
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStAsText
		{
			get
			{
				return this._imiSqlGeometryStAsText;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0000D5EA File Offset: 0x0000B7EA
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStIsEmpty
		{
			get
			{
				return this._imiSqlGeometryStIsEmpty;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000D5F2 File Offset: 0x0000B7F2
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStIsSimple
		{
			get
			{
				return this._imiSqlGeometryStIsSimple;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000D5FA File Offset: 0x0000B7FA
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStBoundary
		{
			get
			{
				return this._imiSqlGeometryStBoundary;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000D602 File Offset: 0x0000B802
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStIsValid
		{
			get
			{
				return this._imiSqlGeometryStIsValid;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000D60A File Offset: 0x0000B80A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStEquals
		{
			get
			{
				return this._imiSqlGeometryStEquals;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0000D612 File Offset: 0x0000B812
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStDisjoint
		{
			get
			{
				return this._imiSqlGeometryStDisjoint;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000D61A File Offset: 0x0000B81A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStIntersects
		{
			get
			{
				return this._imiSqlGeometryStIntersects;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000D622 File Offset: 0x0000B822
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStTouches
		{
			get
			{
				return this._imiSqlGeometryStTouches;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000D62A File Offset: 0x0000B82A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStCrosses
		{
			get
			{
				return this._imiSqlGeometryStCrosses;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000D632 File Offset: 0x0000B832
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStWithin
		{
			get
			{
				return this._imiSqlGeometryStWithin;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000D63A File Offset: 0x0000B83A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStContains
		{
			get
			{
				return this._imiSqlGeometryStContains;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000D642 File Offset: 0x0000B842
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStOverlaps
		{
			get
			{
				return this._imiSqlGeometryStOverlaps;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000D64A File Offset: 0x0000B84A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStRelate
		{
			get
			{
				return this._imiSqlGeometryStRelate;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000D652 File Offset: 0x0000B852
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStBuffer
		{
			get
			{
				return this._imiSqlGeometryStBuffer;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0000D65A File Offset: 0x0000B85A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStDistance
		{
			get
			{
				return this._imiSqlGeometryStDistance;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000D662 File Offset: 0x0000B862
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStConvexHull
		{
			get
			{
				return this._imiSqlGeometryStConvexHull;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000D66A File Offset: 0x0000B86A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStIntersection
		{
			get
			{
				return this._imiSqlGeometryStIntersection;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000D672 File Offset: 0x0000B872
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStUnion
		{
			get
			{
				return this._imiSqlGeometryStUnion;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000D67A File Offset: 0x0000B87A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStDifference
		{
			get
			{
				return this._imiSqlGeometryStDifference;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000D682 File Offset: 0x0000B882
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStSymDifference
		{
			get
			{
				return this._imiSqlGeometryStSymDifference;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000D68A File Offset: 0x0000B88A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStNumGeometries
		{
			get
			{
				return this._imiSqlGeometryStNumGeometries;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000D692 File Offset: 0x0000B892
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStGeometryN
		{
			get
			{
				return this._imiSqlGeometryStGeometryN;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0000D69A File Offset: 0x0000B89A
		public global::System.Lazy<global::System.Reflection.PropertyInfo> IpiSqlGeometryStx
		{
			get
			{
				return this._ipiSqlGeometryStx;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000D6A2 File Offset: 0x0000B8A2
		public global::System.Lazy<global::System.Reflection.PropertyInfo> IpiSqlGeometrySty
		{
			get
			{
				return this._ipiSqlGeometrySty;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000D6AA File Offset: 0x0000B8AA
		public global::System.Lazy<global::System.Reflection.PropertyInfo> IpiSqlGeometryZ
		{
			get
			{
				return this._ipiSqlGeometryZ;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000D6B2 File Offset: 0x0000B8B2
		public global::System.Lazy<global::System.Reflection.PropertyInfo> IpiSqlGeometryM
		{
			get
			{
				return this._ipiSqlGeometryM;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0000D6BA File Offset: 0x0000B8BA
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStLength
		{
			get
			{
				return this._imiSqlGeometryStLength;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0000D6C2 File Offset: 0x0000B8C2
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStStartPoint
		{
			get
			{
				return this._imiSqlGeometryStStartPoint;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000D6CA File Offset: 0x0000B8CA
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStEndPoint
		{
			get
			{
				return this._imiSqlGeometryStEndPoint;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0000D6D2 File Offset: 0x0000B8D2
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStIsClosed
		{
			get
			{
				return this._imiSqlGeometryStIsClosed;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0000D6DA File Offset: 0x0000B8DA
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStIsRing
		{
			get
			{
				return this._imiSqlGeometryStIsRing;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000D6E2 File Offset: 0x0000B8E2
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStNumPoints
		{
			get
			{
				return this._imiSqlGeometryStNumPoints;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000D6EA File Offset: 0x0000B8EA
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStPointN
		{
			get
			{
				return this._imiSqlGeometryStPointN;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000D6F2 File Offset: 0x0000B8F2
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStArea
		{
			get
			{
				return this._imiSqlGeometryStArea;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000D6FA File Offset: 0x0000B8FA
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStCentroid
		{
			get
			{
				return this._imiSqlGeometryStCentroid;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000D702 File Offset: 0x0000B902
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStPointOnSurface
		{
			get
			{
				return this._imiSqlGeometryStPointOnSurface;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000D70A File Offset: 0x0000B90A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStExteriorRing
		{
			get
			{
				return this._imiSqlGeometryStExteriorRing;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000D712 File Offset: 0x0000B912
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStNumInteriorRing
		{
			get
			{
				return this._imiSqlGeometryStNumInteriorRing;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000D71A File Offset: 0x0000B91A
		public global::System.Lazy<global::System.Reflection.MethodInfo> ImiSqlGeometryStInteriorRingN
		{
			get
			{
				return this._imiSqlGeometryStInteriorRingN;
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000D722 File Offset: 0x0000B922
		private global::System.Reflection.MethodInfo FindSqlGeographyMethod(string methodName, params global::System.Type[] argTypes)
		{
			return this.SqlGeographyType.GetDeclaredMethod(methodName, argTypes);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000D731 File Offset: 0x0000B931
		private global::System.Reflection.MethodInfo FindSqlGeographyStaticMethod(string methodName, params global::System.Type[] argTypes)
		{
			return this.SqlGeographyType.GetDeclaredMethod(methodName, argTypes);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000D740 File Offset: 0x0000B940
		private global::System.Reflection.PropertyInfo FindSqlGeographyProperty(string propertyName)
		{
			return this.SqlGeographyType.GetRuntimeProperty(propertyName);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000D74E File Offset: 0x0000B94E
		private global::System.Reflection.MethodInfo FindSqlGeometryStaticMethod(string methodName, params global::System.Type[] argTypes)
		{
			return this.SqlGeometryType.GetDeclaredMethod(methodName, argTypes);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000D75D File Offset: 0x0000B95D
		private global::System.Reflection.MethodInfo FindSqlGeometryMethod(string methodName, params global::System.Type[] argTypes)
		{
			return this.SqlGeometryType.GetDeclaredMethod(methodName, argTypes);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000D76C File Offset: 0x0000B96C
		private global::System.Reflection.PropertyInfo FindSqlGeometryProperty(string propertyName)
		{
			return this.SqlGeometryType.GetRuntimeProperty(propertyName);
		}

		// Token: 0x04000038 RID: 56
		private readonly global::System.Func<object, bool> sqlBooleanToBoolean;

		// Token: 0x04000039 RID: 57
		private readonly global::System.Func<object, bool?> sqlBooleanToNullableBoolean;

		// Token: 0x0400003A RID: 58
		private readonly global::System.Func<byte[], object> sqlBytesFromByteArray;

		// Token: 0x0400003B RID: 59
		private readonly global::System.Func<object, byte[]> sqlBytesToByteArray;

		// Token: 0x0400003C RID: 60
		private readonly global::System.Func<string, object> sqlStringFromString;

		// Token: 0x0400003D RID: 61
		private readonly global::System.Func<string, object> sqlCharsFromString;

		// Token: 0x0400003E RID: 62
		private readonly global::System.Func<object, string> sqlCharsToString;

		// Token: 0x0400003F RID: 63
		private readonly global::System.Func<object, string> sqlStringToString;

		// Token: 0x04000040 RID: 64
		private readonly global::System.Func<object, double> sqlDoubleToDouble;

		// Token: 0x04000041 RID: 65
		private readonly global::System.Func<object, double?> sqlDoubleToNullableDouble;

		// Token: 0x04000042 RID: 66
		private readonly global::System.Func<object, int> sqlInt32ToInt;

		// Token: 0x04000043 RID: 67
		private readonly global::System.Func<object, int?> sqlInt32ToNullableInt;

		// Token: 0x04000044 RID: 68
		private readonly global::System.Func<global::System.Xml.XmlReader, object> sqlXmlFromXmlReader;

		// Token: 0x04000045 RID: 69
		private readonly global::System.Func<object, string> sqlXmlToString;

		// Token: 0x04000046 RID: 70
		private readonly global::System.Func<object, bool> isSqlGeographyNull;

		// Token: 0x04000047 RID: 71
		private readonly global::System.Func<object, bool> isSqlGeometryNull;

		// Token: 0x04000048 RID: 72
		private readonly global::System.Func<object, object> geographyAsTextZMAsSqlChars;

		// Token: 0x04000049 RID: 73
		private readonly global::System.Func<object, object> geometryAsTextZMAsSqlChars;

		// Token: 0x0400004D RID: 77
		private readonly global::System.Func<string, object> sqlHierarchyIdParse;

		// Token: 0x0400004E RID: 78
		private readonly global::System.Func<string, int, object> sqlGeographyFromWKTString;

		// Token: 0x0400004F RID: 79
		private readonly global::System.Func<byte[], int, object> sqlGeographyFromWKBByteArray;

		// Token: 0x04000050 RID: 80
		private readonly global::System.Func<global::System.Xml.XmlReader, int, object> sqlGeographyFromGMLReader;

		// Token: 0x04000051 RID: 81
		private readonly global::System.Func<string, int, object> sqlGeometryFromWKTString;

		// Token: 0x04000052 RID: 82
		private readonly global::System.Func<byte[], int, object> sqlGeometryFromWKBByteArray;

		// Token: 0x04000053 RID: 83
		private readonly global::System.Func<global::System.Xml.XmlReader, int, object> sqlGeometryFromGMLReader;

		// Token: 0x04000054 RID: 84
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyParse;

		// Token: 0x04000055 RID: 85
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyStGeomFromText;

		// Token: 0x04000056 RID: 86
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyStPointFromText;

		// Token: 0x04000057 RID: 87
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyStLineFromText;

		// Token: 0x04000058 RID: 88
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyStPolyFromText;

		// Token: 0x04000059 RID: 89
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyStmPointFromText;

		// Token: 0x0400005A RID: 90
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyStmLineFromText;

		// Token: 0x0400005B RID: 91
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyStmPolyFromText;

		// Token: 0x0400005C RID: 92
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyStGeomCollFromText;

		// Token: 0x0400005D RID: 93
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyStGeomFromWkb;

		// Token: 0x0400005E RID: 94
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyStPointFromWkb;

		// Token: 0x0400005F RID: 95
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyStLineFromWkb;

		// Token: 0x04000060 RID: 96
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyStPolyFromWkb;

		// Token: 0x04000061 RID: 97
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyStmPointFromWkb;

		// Token: 0x04000062 RID: 98
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyStmLineFromWkb;

		// Token: 0x04000063 RID: 99
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyStmPolyFromWkb;

		// Token: 0x04000064 RID: 100
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyStGeomCollFromWkb;

		// Token: 0x04000065 RID: 101
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeographyGeomFromGml;

		// Token: 0x04000066 RID: 102
		private readonly global::System.Lazy<global::System.Reflection.PropertyInfo> _ipiSqlGeographyStSrid;

		// Token: 0x04000067 RID: 103
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStGeometryType;

		// Token: 0x04000068 RID: 104
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStDimension;

		// Token: 0x04000069 RID: 105
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStAsBinary;

		// Token: 0x0400006A RID: 106
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyAsGml;

		// Token: 0x0400006B RID: 107
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStAsText;

		// Token: 0x0400006C RID: 108
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStIsEmpty;

		// Token: 0x0400006D RID: 109
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStEquals;

		// Token: 0x0400006E RID: 110
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStDisjoint;

		// Token: 0x0400006F RID: 111
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStIntersects;

		// Token: 0x04000070 RID: 112
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStBuffer;

		// Token: 0x04000071 RID: 113
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStDistance;

		// Token: 0x04000072 RID: 114
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStIntersection;

		// Token: 0x04000073 RID: 115
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStUnion;

		// Token: 0x04000074 RID: 116
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStDifference;

		// Token: 0x04000075 RID: 117
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStSymDifference;

		// Token: 0x04000076 RID: 118
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStNumGeometries;

		// Token: 0x04000077 RID: 119
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStGeometryN;

		// Token: 0x04000078 RID: 120
		private readonly global::System.Lazy<global::System.Reflection.PropertyInfo> _ipiSqlGeographyLat;

		// Token: 0x04000079 RID: 121
		private readonly global::System.Lazy<global::System.Reflection.PropertyInfo> _ipiSqlGeographyLong;

		// Token: 0x0400007A RID: 122
		private readonly global::System.Lazy<global::System.Reflection.PropertyInfo> _ipiSqlGeographyZ;

		// Token: 0x0400007B RID: 123
		private readonly global::System.Lazy<global::System.Reflection.PropertyInfo> _ipiSqlGeographyM;

		// Token: 0x0400007C RID: 124
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStLength;

		// Token: 0x0400007D RID: 125
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStStartPoint;

		// Token: 0x0400007E RID: 126
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStEndPoint;

		// Token: 0x0400007F RID: 127
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStIsClosed;

		// Token: 0x04000080 RID: 128
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStNumPoints;

		// Token: 0x04000081 RID: 129
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStPointN;

		// Token: 0x04000082 RID: 130
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeographyStArea;

		// Token: 0x04000083 RID: 131
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryParse;

		// Token: 0x04000084 RID: 132
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryStGeomFromText;

		// Token: 0x04000085 RID: 133
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryStPointFromText;

		// Token: 0x04000086 RID: 134
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryStLineFromText;

		// Token: 0x04000087 RID: 135
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryStPolyFromText;

		// Token: 0x04000088 RID: 136
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryStmPointFromText;

		// Token: 0x04000089 RID: 137
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryStmLineFromText;

		// Token: 0x0400008A RID: 138
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryStmPolyFromText;

		// Token: 0x0400008B RID: 139
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryStGeomCollFromText;

		// Token: 0x0400008C RID: 140
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryStGeomFromWkb;

		// Token: 0x0400008D RID: 141
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryStPointFromWkb;

		// Token: 0x0400008E RID: 142
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryStLineFromWkb;

		// Token: 0x0400008F RID: 143
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryStPolyFromWkb;

		// Token: 0x04000090 RID: 144
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryStmPointFromWkb;

		// Token: 0x04000091 RID: 145
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryStmLineFromWkb;

		// Token: 0x04000092 RID: 146
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryStmPolyFromWkb;

		// Token: 0x04000093 RID: 147
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryStGeomCollFromWkb;

		// Token: 0x04000094 RID: 148
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _smiSqlGeometryGeomFromGml;

		// Token: 0x04000095 RID: 149
		private readonly global::System.Lazy<global::System.Reflection.PropertyInfo> _ipiSqlGeometryStSrid;

		// Token: 0x04000096 RID: 150
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStGeometryType;

		// Token: 0x04000097 RID: 151
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStDimension;

		// Token: 0x04000098 RID: 152
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStEnvelope;

		// Token: 0x04000099 RID: 153
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStAsBinary;

		// Token: 0x0400009A RID: 154
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryAsGml;

		// Token: 0x0400009B RID: 155
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStAsText;

		// Token: 0x0400009C RID: 156
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStIsEmpty;

		// Token: 0x0400009D RID: 157
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStIsSimple;

		// Token: 0x0400009E RID: 158
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStBoundary;

		// Token: 0x0400009F RID: 159
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStIsValid;

		// Token: 0x040000A0 RID: 160
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStEquals;

		// Token: 0x040000A1 RID: 161
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStDisjoint;

		// Token: 0x040000A2 RID: 162
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStIntersects;

		// Token: 0x040000A3 RID: 163
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStTouches;

		// Token: 0x040000A4 RID: 164
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStCrosses;

		// Token: 0x040000A5 RID: 165
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStWithin;

		// Token: 0x040000A6 RID: 166
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStContains;

		// Token: 0x040000A7 RID: 167
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStOverlaps;

		// Token: 0x040000A8 RID: 168
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStRelate;

		// Token: 0x040000A9 RID: 169
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStBuffer;

		// Token: 0x040000AA RID: 170
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStDistance;

		// Token: 0x040000AB RID: 171
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStConvexHull;

		// Token: 0x040000AC RID: 172
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStIntersection;

		// Token: 0x040000AD RID: 173
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStUnion;

		// Token: 0x040000AE RID: 174
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStDifference;

		// Token: 0x040000AF RID: 175
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStSymDifference;

		// Token: 0x040000B0 RID: 176
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStNumGeometries;

		// Token: 0x040000B1 RID: 177
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStGeometryN;

		// Token: 0x040000B2 RID: 178
		private readonly global::System.Lazy<global::System.Reflection.PropertyInfo> _ipiSqlGeometryStx;

		// Token: 0x040000B3 RID: 179
		private readonly global::System.Lazy<global::System.Reflection.PropertyInfo> _ipiSqlGeometrySty;

		// Token: 0x040000B4 RID: 180
		private readonly global::System.Lazy<global::System.Reflection.PropertyInfo> _ipiSqlGeometryZ;

		// Token: 0x040000B5 RID: 181
		private readonly global::System.Lazy<global::System.Reflection.PropertyInfo> _ipiSqlGeometryM;

		// Token: 0x040000B6 RID: 182
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStLength;

		// Token: 0x040000B7 RID: 183
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStStartPoint;

		// Token: 0x040000B8 RID: 184
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStEndPoint;

		// Token: 0x040000B9 RID: 185
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStIsClosed;

		// Token: 0x040000BA RID: 186
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStIsRing;

		// Token: 0x040000BB RID: 187
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStNumPoints;

		// Token: 0x040000BC RID: 188
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStPointN;

		// Token: 0x040000BD RID: 189
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStArea;

		// Token: 0x040000BE RID: 190
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStCentroid;

		// Token: 0x040000BF RID: 191
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStPointOnSurface;

		// Token: 0x040000C0 RID: 192
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStExteriorRing;

		// Token: 0x040000C1 RID: 193
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStNumInteriorRing;

		// Token: 0x040000C2 RID: 194
		private readonly global::System.Lazy<global::System.Reflection.MethodInfo> _imiSqlGeometryStInteriorRingN;
	}
}
