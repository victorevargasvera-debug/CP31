using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Spatial
{
	// Token: 0x020006FA RID: 1786
	public static class SpatialEdmFunctions
	{
		// Token: 0x060053F0 RID: 21488 RVA: 0x0012CDEC File Offset: 0x0012AFEC
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression wellKnownText)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(wellKnownText, "wellKnownText");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				wellKnownText
			});
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x0012CE0E File Offset: 0x0012B00E
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression wellKnownText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(wellKnownText, "wellKnownText");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				wellKnownText,
				coordinateSystemId
			});
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x0012CE40 File Offset: 0x0012B040
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryPointFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression pointWellKnownText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(pointWellKnownText, "pointWellKnownText");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryPointFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				pointWellKnownText,
				coordinateSystemId
			});
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x0012CE72 File Offset: 0x0012B072
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryLineFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression lineWellKnownText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(lineWellKnownText, "lineWellKnownText");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryLineFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				lineWellKnownText,
				coordinateSystemId
			});
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x0012CEA4 File Offset: 0x0012B0A4
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryPolygonFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression polygonWellKnownText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(polygonWellKnownText, "polygonWellKnownText");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryPolygonFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				polygonWellKnownText,
				coordinateSystemId
			});
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x0012CED6 File Offset: 0x0012B0D6
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryMultiPointFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression multiPointWellKnownText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(multiPointWellKnownText, "multiPointWellKnownText");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryMultiPointFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				multiPointWellKnownText,
				coordinateSystemId
			});
		}

		// Token: 0x060053F6 RID: 21494 RVA: 0x0012CF08 File Offset: 0x0012B108
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryMultiLineFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression multiLineWellKnownText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(multiLineWellKnownText, "multiLineWellKnownText");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryMultiLineFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				multiLineWellKnownText,
				coordinateSystemId
			});
		}

		// Token: 0x060053F7 RID: 21495 RVA: 0x0012CF3A File Offset: 0x0012B13A
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryMultiPolygonFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression multiPolygonWellKnownText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(multiPolygonWellKnownText, "multiPolygonWellKnownText");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryMultiPolygonFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				multiPolygonWellKnownText,
				coordinateSystemId
			});
		}

		// Token: 0x060053F8 RID: 21496 RVA: 0x0012CF6C File Offset: 0x0012B16C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryCollectionFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryCollectionWellKnownText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryCollectionWellKnownText, "geometryCollectionWellKnownText");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryCollectionFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryCollectionWellKnownText,
				coordinateSystemId
			});
		}

		// Token: 0x060053F9 RID: 21497 RVA: 0x0012CF9E File Offset: 0x0012B19E
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression wellKnownBinaryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(wellKnownBinaryValue, "wellKnownBinaryValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				wellKnownBinaryValue
			});
		}

		// Token: 0x060053FA RID: 21498 RVA: 0x0012CFC0 File Offset: 0x0012B1C0
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression wellKnownBinaryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(wellKnownBinaryValue, "wellKnownBinaryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				wellKnownBinaryValue,
				coordinateSystemId
			});
		}

		// Token: 0x060053FB RID: 21499 RVA: 0x0012CFF2 File Offset: 0x0012B1F2
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryPointFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression pointWellKnownBinaryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(pointWellKnownBinaryValue, "pointWellKnownBinaryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryPointFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				pointWellKnownBinaryValue,
				coordinateSystemId
			});
		}

		// Token: 0x060053FC RID: 21500 RVA: 0x0012D024 File Offset: 0x0012B224
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryLineFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression lineWellKnownBinaryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(lineWellKnownBinaryValue, "lineWellKnownBinaryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryLineFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				lineWellKnownBinaryValue,
				coordinateSystemId
			});
		}

		// Token: 0x060053FD RID: 21501 RVA: 0x0012D056 File Offset: 0x0012B256
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryPolygonFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression polygonWellKnownBinaryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(polygonWellKnownBinaryValue, "polygonWellKnownBinaryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryPolygonFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				polygonWellKnownBinaryValue,
				coordinateSystemId
			});
		}

		// Token: 0x060053FE RID: 21502 RVA: 0x0012D088 File Offset: 0x0012B288
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryMultiPointFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression multiPointWellKnownBinaryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(multiPointWellKnownBinaryValue, "multiPointWellKnownBinaryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryMultiPointFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				multiPointWellKnownBinaryValue,
				coordinateSystemId
			});
		}

		// Token: 0x060053FF RID: 21503 RVA: 0x0012D0BA File Offset: 0x0012B2BA
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryMultiLineFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression multiLineWellKnownBinaryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(multiLineWellKnownBinaryValue, "multiLineWellKnownBinaryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryMultiLineFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				multiLineWellKnownBinaryValue,
				coordinateSystemId
			});
		}

		// Token: 0x06005400 RID: 21504 RVA: 0x0012D0EC File Offset: 0x0012B2EC
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryMultiPolygonFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression multiPolygonWellKnownBinaryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(multiPolygonWellKnownBinaryValue, "multiPolygonWellKnownBinaryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryMultiPolygonFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				multiPolygonWellKnownBinaryValue,
				coordinateSystemId
			});
		}

		// Token: 0x06005401 RID: 21505 RVA: 0x0012D11E File Offset: 0x0012B31E
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryCollectionFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryCollectionWellKnownBinaryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryCollectionWellKnownBinaryValue, "geometryCollectionWellKnownBinaryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryCollectionFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryCollectionWellKnownBinaryValue,
				coordinateSystemId
			});
		}

		// Token: 0x06005402 RID: 21506 RVA: 0x0012D150 File Offset: 0x0012B350
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryFromGml(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryMarkup)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryMarkup, "geometryMarkup");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryFromGml", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryMarkup
			});
		}

		// Token: 0x06005403 RID: 21507 RVA: 0x0012D172 File Offset: 0x0012B372
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeometryFromGml(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryMarkup, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryMarkup, "geometryMarkup");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeometryFromGml", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryMarkup,
				coordinateSystemId
			});
		}

		// Token: 0x06005404 RID: 21508 RVA: 0x0012D1A4 File Offset: 0x0012B3A4
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression wellKnownText)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(wellKnownText, "wellKnownText");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				wellKnownText
			});
		}

		// Token: 0x06005405 RID: 21509 RVA: 0x0012D1C6 File Offset: 0x0012B3C6
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression wellKnownText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(wellKnownText, "wellKnownText");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				wellKnownText,
				coordinateSystemId
			});
		}

		// Token: 0x06005406 RID: 21510 RVA: 0x0012D1F8 File Offset: 0x0012B3F8
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyPointFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression pointWellKnownText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(pointWellKnownText, "pointWellKnownText");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyPointFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				pointWellKnownText,
				coordinateSystemId
			});
		}

		// Token: 0x06005407 RID: 21511 RVA: 0x0012D22A File Offset: 0x0012B42A
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyLineFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression lineWellKnownText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(lineWellKnownText, "lineWellKnownText");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyLineFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				lineWellKnownText,
				coordinateSystemId
			});
		}

		// Token: 0x06005408 RID: 21512 RVA: 0x0012D25C File Offset: 0x0012B45C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyPolygonFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression polygonWellKnownText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(polygonWellKnownText, "polygonWellKnownText");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyPolygonFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				polygonWellKnownText,
				coordinateSystemId
			});
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x0012D28E File Offset: 0x0012B48E
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyMultiPointFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression multiPointWellKnownText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(multiPointWellKnownText, "multiPointWellKnownText");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyMultiPointFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				multiPointWellKnownText,
				coordinateSystemId
			});
		}

		// Token: 0x0600540A RID: 21514 RVA: 0x0012D2C0 File Offset: 0x0012B4C0
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyMultiLineFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression multiLineWellKnownText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(multiLineWellKnownText, "multiLineWellKnownText");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyMultiLineFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				multiLineWellKnownText,
				coordinateSystemId
			});
		}

		// Token: 0x0600540B RID: 21515 RVA: 0x0012D2F2 File Offset: 0x0012B4F2
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyMultiPolygonFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression multiPolygonWellKnownText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(multiPolygonWellKnownText, "multiPolygonWellKnownText");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyMultiPolygonFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				multiPolygonWellKnownText,
				coordinateSystemId
			});
		}

		// Token: 0x0600540C RID: 21516 RVA: 0x0012D324 File Offset: 0x0012B524
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyCollectionFromText(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geographyCollectionWellKnownText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geographyCollectionWellKnownText, "geographyCollectionWellKnownText");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyCollectionFromText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geographyCollectionWellKnownText,
				coordinateSystemId
			});
		}

		// Token: 0x0600540D RID: 21517 RVA: 0x0012D356 File Offset: 0x0012B556
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression wellKnownBinaryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(wellKnownBinaryValue, "wellKnownBinaryValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				wellKnownBinaryValue
			});
		}

		// Token: 0x0600540E RID: 21518 RVA: 0x0012D378 File Offset: 0x0012B578
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression wellKnownBinaryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(wellKnownBinaryValue, "wellKnownBinaryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				wellKnownBinaryValue,
				coordinateSystemId
			});
		}

		// Token: 0x0600540F RID: 21519 RVA: 0x0012D3AA File Offset: 0x0012B5AA
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyPointFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression pointWellKnownBinaryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(pointWellKnownBinaryValue, "pointWellKnownBinaryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyPointFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				pointWellKnownBinaryValue,
				coordinateSystemId
			});
		}

		// Token: 0x06005410 RID: 21520 RVA: 0x0012D3DC File Offset: 0x0012B5DC
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyLineFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression lineWellKnownBinaryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(lineWellKnownBinaryValue, "lineWellKnownBinaryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyLineFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				lineWellKnownBinaryValue,
				coordinateSystemId
			});
		}

		// Token: 0x06005411 RID: 21521 RVA: 0x0012D40E File Offset: 0x0012B60E
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyPolygonFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression polygonWellKnownBinaryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(polygonWellKnownBinaryValue, "polygonWellKnownBinaryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyPolygonFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				polygonWellKnownBinaryValue,
				coordinateSystemId
			});
		}

		// Token: 0x06005412 RID: 21522 RVA: 0x0012D440 File Offset: 0x0012B640
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyMultiPointFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression multiPointWellKnownBinaryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(multiPointWellKnownBinaryValue, "multiPointWellKnownBinaryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyMultiPointFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				multiPointWellKnownBinaryValue,
				coordinateSystemId
			});
		}

		// Token: 0x06005413 RID: 21523 RVA: 0x0012D472 File Offset: 0x0012B672
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyMultiLineFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression multiLineWellKnownBinaryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(multiLineWellKnownBinaryValue, "multiLineWellKnownBinaryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyMultiLineFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				multiLineWellKnownBinaryValue,
				coordinateSystemId
			});
		}

		// Token: 0x06005414 RID: 21524 RVA: 0x0012D4A4 File Offset: 0x0012B6A4
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyMultiPolygonFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression multiPolygonWellKnownBinaryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(multiPolygonWellKnownBinaryValue, "multiPolygonWellKnownBinaryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyMultiPolygonFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				multiPolygonWellKnownBinaryValue,
				coordinateSystemId
			});
		}

		// Token: 0x06005415 RID: 21525 RVA: 0x0012D4D6 File Offset: 0x0012B6D6
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyCollectionFromBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geographyCollectionWellKnownBinaryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geographyCollectionWellKnownBinaryValue, "geographyCollectionWellKnownBinaryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyCollectionFromBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geographyCollectionWellKnownBinaryValue,
				coordinateSystemId
			});
		}

		// Token: 0x06005416 RID: 21526 RVA: 0x0012D508 File Offset: 0x0012B708
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyFromGml(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geographyMarkup)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geographyMarkup, "geographyMarkup");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyFromGml", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geographyMarkup
			});
		}

		// Token: 0x06005417 RID: 21527 RVA: 0x0012D52A File Offset: 0x0012B72A
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GeographyFromGml(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geographyMarkup, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression coordinateSystemId)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geographyMarkup, "geographyMarkup");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(coordinateSystemId, "coordinateSystemId");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GeographyFromGml", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geographyMarkup,
				coordinateSystemId
			});
		}

		// Token: 0x06005418 RID: 21528 RVA: 0x0012D55C File Offset: 0x0012B75C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression CoordinateSystemId(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("CoordinateSystemId", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue
			});
		}

		// Token: 0x06005419 RID: 21529 RVA: 0x0012D57E File Offset: 0x0012B77E
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialTypeName(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialTypeName", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue
			});
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x0012D5A0 File Offset: 0x0012B7A0
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialDimension(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialDimension", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue
			});
		}

		// Token: 0x0600541B RID: 21531 RVA: 0x0012D5C2 File Offset: 0x0012B7C2
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialEnvelope(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue, "geometryValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialEnvelope", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue
			});
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x0012D5E4 File Offset: 0x0012B7E4
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression AsBinary(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("AsBinary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue
			});
		}

		// Token: 0x0600541D RID: 21533 RVA: 0x0012D606 File Offset: 0x0012B806
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression AsGml(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("AsGml", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue
			});
		}

		// Token: 0x0600541E RID: 21534 RVA: 0x0012D628 File Offset: 0x0012B828
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression AsText(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("AsText", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue
			});
		}

		// Token: 0x0600541F RID: 21535 RVA: 0x0012D64A File Offset: 0x0012B84A
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression IsEmptySpatial(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("IsEmptySpatial", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue
			});
		}

		// Token: 0x06005420 RID: 21536 RVA: 0x0012D66C File Offset: 0x0012B86C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression IsSimpleGeometry(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue, "geometryValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("IsSimpleGeometry", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue
			});
		}

		// Token: 0x06005421 RID: 21537 RVA: 0x0012D68E File Offset: 0x0012B88E
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialBoundary(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue, "geometryValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialBoundary", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue
			});
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x0012D6B0 File Offset: 0x0012B8B0
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression IsValidGeometry(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue, "geometryValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("IsValidGeometry", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue
			});
		}

		// Token: 0x06005423 RID: 21539 RVA: 0x0012D6D2 File Offset: 0x0012B8D2
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialEquals(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue1, "spatialValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue2, "spatialValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialEquals", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue1,
				spatialValue2
			});
		}

		// Token: 0x06005424 RID: 21540 RVA: 0x0012D704 File Offset: 0x0012B904
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialDisjoint(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue1, "spatialValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue2, "spatialValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialDisjoint", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue1,
				spatialValue2
			});
		}

		// Token: 0x06005425 RID: 21541 RVA: 0x0012D736 File Offset: 0x0012B936
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialIntersects(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue1, "spatialValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue2, "spatialValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialIntersects", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue1,
				spatialValue2
			});
		}

		// Token: 0x06005426 RID: 21542 RVA: 0x0012D768 File Offset: 0x0012B968
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialTouches(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue1, "geometryValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue2, "geometryValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialTouches", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue1,
				geometryValue2
			});
		}

		// Token: 0x06005427 RID: 21543 RVA: 0x0012D79A File Offset: 0x0012B99A
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialCrosses(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue1, "geometryValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue2, "geometryValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialCrosses", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue1,
				geometryValue2
			});
		}

		// Token: 0x06005428 RID: 21544 RVA: 0x0012D7CC File Offset: 0x0012B9CC
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialWithin(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue1, "geometryValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue2, "geometryValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialWithin", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue1,
				geometryValue2
			});
		}

		// Token: 0x06005429 RID: 21545 RVA: 0x0012D7FE File Offset: 0x0012B9FE
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialContains(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue1, "geometryValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue2, "geometryValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialContains", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue1,
				geometryValue2
			});
		}

		// Token: 0x0600542A RID: 21546 RVA: 0x0012D830 File Offset: 0x0012BA30
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialOverlaps(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue1, "geometryValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue2, "geometryValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialOverlaps", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue1,
				geometryValue2
			});
		}

		// Token: 0x0600542B RID: 21547 RVA: 0x0012D864 File Offset: 0x0012BA64
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialRelate(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue2, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression intersectionPatternMatrix)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue1, "geometryValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue2, "geometryValue2");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(intersectionPatternMatrix, "intersectionPatternMatrix");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialRelate", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue1,
				geometryValue2,
				intersectionPatternMatrix
			});
		}

		// Token: 0x0600542C RID: 21548 RVA: 0x0012D8B1 File Offset: 0x0012BAB1
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialBuffer(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression distance)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(distance, "distance");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialBuffer", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue,
				distance
			});
		}

		// Token: 0x0600542D RID: 21549 RVA: 0x0012D8E3 File Offset: 0x0012BAE3
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Distance(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue1, "spatialValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue2, "spatialValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Distance", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue1,
				spatialValue2
			});
		}

		// Token: 0x0600542E RID: 21550 RVA: 0x0012D915 File Offset: 0x0012BB15
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialConvexHull(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue, "geometryValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialConvexHull", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue
			});
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x0012D937 File Offset: 0x0012BB37
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialIntersection(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue1, "spatialValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue2, "spatialValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialIntersection", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue1,
				spatialValue2
			});
		}

		// Token: 0x06005430 RID: 21552 RVA: 0x0012D969 File Offset: 0x0012BB69
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialUnion(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue1, "spatialValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue2, "spatialValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialUnion", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue1,
				spatialValue2
			});
		}

		// Token: 0x06005431 RID: 21553 RVA: 0x0012D99B File Offset: 0x0012BB9B
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialDifference(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue1, "spatialValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue2, "spatialValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialDifference", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue1,
				spatialValue2
			});
		}

		// Token: 0x06005432 RID: 21554 RVA: 0x0012D9CD File Offset: 0x0012BBCD
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialSymmetricDifference(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue1, "spatialValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue2, "spatialValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialSymmetricDifference", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue1,
				spatialValue2
			});
		}

		// Token: 0x06005433 RID: 21555 RVA: 0x0012D9FF File Offset: 0x0012BBFF
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialElementCount(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialElementCount", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue
			});
		}

		// Token: 0x06005434 RID: 21556 RVA: 0x0012DA21 File Offset: 0x0012BC21
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialElementAt(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression indexValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(indexValue, "indexValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialElementAt", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue,
				indexValue
			});
		}

		// Token: 0x06005435 RID: 21557 RVA: 0x0012DA53 File Offset: 0x0012BC53
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression XCoordinate(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue, "geometryValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("XCoordinate", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue
			});
		}

		// Token: 0x06005436 RID: 21558 RVA: 0x0012DA75 File Offset: 0x0012BC75
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression YCoordinate(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue, "geometryValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("YCoordinate", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue
			});
		}

		// Token: 0x06005437 RID: 21559 RVA: 0x0012DA97 File Offset: 0x0012BC97
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Elevation(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Elevation", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue
			});
		}

		// Token: 0x06005438 RID: 21560 RVA: 0x0012DAB9 File Offset: 0x0012BCB9
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Measure(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Measure", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue
			});
		}

		// Token: 0x06005439 RID: 21561 RVA: 0x0012DADB File Offset: 0x0012BCDB
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Latitude(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geographyValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geographyValue, "geographyValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Latitude", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geographyValue
			});
		}

		// Token: 0x0600543A RID: 21562 RVA: 0x0012DAFD File Offset: 0x0012BCFD
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Longitude(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geographyValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geographyValue, "geographyValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Longitude", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geographyValue
			});
		}

		// Token: 0x0600543B RID: 21563 RVA: 0x0012DB1F File Offset: 0x0012BD1F
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression SpatialLength(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("SpatialLength", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue
			});
		}

		// Token: 0x0600543C RID: 21564 RVA: 0x0012DB41 File Offset: 0x0012BD41
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression StartPoint(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("StartPoint", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue
			});
		}

		// Token: 0x0600543D RID: 21565 RVA: 0x0012DB63 File Offset: 0x0012BD63
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression EndPoint(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("EndPoint", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue
			});
		}

		// Token: 0x0600543E RID: 21566 RVA: 0x0012DB85 File Offset: 0x0012BD85
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression IsClosedSpatial(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("IsClosedSpatial", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue
			});
		}

		// Token: 0x0600543F RID: 21567 RVA: 0x0012DBA7 File Offset: 0x0012BDA7
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression IsRing(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue, "geometryValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("IsRing", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue
			});
		}

		// Token: 0x06005440 RID: 21568 RVA: 0x0012DBC9 File Offset: 0x0012BDC9
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression PointCount(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("PointCount", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue
			});
		}

		// Token: 0x06005441 RID: 21569 RVA: 0x0012DBEB File Offset: 0x0012BDEB
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression PointAt(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression indexValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(indexValue, "indexValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("PointAt", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue,
				indexValue
			});
		}

		// Token: 0x06005442 RID: 21570 RVA: 0x0012DC1D File Offset: 0x0012BE1D
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Area(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression spatialValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(spatialValue, "spatialValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Area", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				spatialValue
			});
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x0012DC3F File Offset: 0x0012BE3F
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Centroid(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue, "geometryValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Centroid", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue
			});
		}

		// Token: 0x06005444 RID: 21572 RVA: 0x0012DC61 File Offset: 0x0012BE61
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression PointOnSurface(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue, "geometryValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("PointOnSurface", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue
			});
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x0012DC83 File Offset: 0x0012BE83
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression ExteriorRing(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue, "geometryValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("ExteriorRing", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue
			});
		}

		// Token: 0x06005446 RID: 21574 RVA: 0x0012DCA5 File Offset: 0x0012BEA5
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression InteriorRingCount(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue, "geometryValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("InteriorRingCount", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue
			});
		}

		// Token: 0x06005447 RID: 21575 RVA: 0x0012DCC7 File Offset: 0x0012BEC7
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression InteriorRingAt(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression geometryValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression indexValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(geometryValue, "geometryValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(indexValue, "indexValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("InteriorRingAt", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				geometryValue,
				indexValue
			});
		}
	}
}
