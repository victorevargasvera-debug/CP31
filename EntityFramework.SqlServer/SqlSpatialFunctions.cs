using System;
using System.Data.Entity.Spatial;
using System.Data.Entity.SqlServer.Resources;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x02000014 RID: 20
	public static class SqlSpatialFunctions
	{
		// Token: 0x06000189 RID: 393 RVA: 0x0000929F File Offset: 0x0000749F
		[global::System.Data.Entity.DbFunction("SqlServer", "POINTGEOGRAPHY")]
		public static global::System.Data.Entity.Spatial.DbGeography PointGeography(double? latitude, double? longitude, int? spatialReferenceId)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000092AB File Offset: 0x000074AB
		[global::System.Data.Entity.DbFunction("SqlServer", "ASTEXTZM")]
		public static string AsTextZM(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000092B7 File Offset: 0x000074B7
		[global::System.Data.Entity.DbFunction("SqlServer", "BUFFERWITHTOLERANCE")]
		public static global::System.Data.Entity.Spatial.DbGeography BufferWithTolerance(global::System.Data.Entity.Spatial.DbGeography geographyValue, double? distance, double? tolerance, bool? relative)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000092C3 File Offset: 0x000074C3
		[global::System.Data.Entity.DbFunction("SqlServer", "ENVELOPEANGLE")]
		public static double? EnvelopeAngle(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000092CF File Offset: 0x000074CF
		[global::System.Data.Entity.DbFunction("SqlServer", "ENVELOPECENTER")]
		public static global::System.Data.Entity.Spatial.DbGeography EnvelopeCenter(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000092DB File Offset: 0x000074DB
		[global::System.Data.Entity.DbFunction("SqlServer", "FILTER")]
		public static bool? Filter(global::System.Data.Entity.Spatial.DbGeography geographyValue, global::System.Data.Entity.Spatial.DbGeography geographyOther)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000092E7 File Offset: 0x000074E7
		[global::System.Data.Entity.DbFunction("SqlServer", "INSTANCEOF")]
		public static bool? InstanceOf(global::System.Data.Entity.Spatial.DbGeography geographyValue, string geometryTypeName)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000092F3 File Offset: 0x000074F3
		[global::System.Data.Entity.DbFunction("SqlServer", "NUMRINGS")]
		public static int? NumRings(global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000092FF File Offset: 0x000074FF
		[global::System.Data.Entity.DbFunction("SqlServer", "REDUCE")]
		public static global::System.Data.Entity.Spatial.DbGeography Reduce(global::System.Data.Entity.Spatial.DbGeography geographyValue, double? tolerance)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000930B File Offset: 0x0000750B
		[global::System.Data.Entity.DbFunction("SqlServer", "RINGN")]
		public static global::System.Data.Entity.Spatial.DbGeography RingN(global::System.Data.Entity.Spatial.DbGeography geographyValue, int? index)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00009317 File Offset: 0x00007517
		[global::System.Data.Entity.DbFunction("SqlServer", "POINTGEOMETRY")]
		public static global::System.Data.Entity.Spatial.DbGeometry PointGeometry(double? xCoordinate, double? yCoordinate, int? spatialReferenceId)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00009323 File Offset: 0x00007523
		[global::System.Data.Entity.DbFunction("SqlServer", "ASTEXTZM")]
		public static string AsTextZM(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000932F File Offset: 0x0000752F
		[global::System.Data.Entity.DbFunction("SqlServer", "BUFFERWITHTOLERANCE")]
		public static global::System.Data.Entity.Spatial.DbGeometry BufferWithTolerance(global::System.Data.Entity.Spatial.DbGeometry geometryValue, double? distance, double? tolerance, bool? relative)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000933B File Offset: 0x0000753B
		[global::System.Data.Entity.DbFunction("SqlServer", "INSTANCEOF")]
		public static bool? InstanceOf(global::System.Data.Entity.Spatial.DbGeometry geometryValue, string geometryTypeName)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00009347 File Offset: 0x00007547
		[global::System.Data.Entity.DbFunction("SqlServer", "FILTER")]
		public static bool? Filter(global::System.Data.Entity.Spatial.DbGeometry geometryValue, global::System.Data.Entity.Spatial.DbGeometry geometryOther)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00009353 File Offset: 0x00007553
		[global::System.Data.Entity.DbFunction("SqlServer", "MAKEVALID")]
		public static global::System.Data.Entity.Spatial.DbGeometry MakeValid(global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000935F File Offset: 0x0000755F
		[global::System.Data.Entity.DbFunction("SqlServer", "REDUCE")]
		public static global::System.Data.Entity.Spatial.DbGeometry Reduce(global::System.Data.Entity.Spatial.DbGeometry geometryValue, double? tolerance)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}
	}
}
