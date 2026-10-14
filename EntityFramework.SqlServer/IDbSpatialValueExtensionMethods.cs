using System;
using System.Data.Entity.Spatial;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x02000008 RID: 8
	internal static class IDbSpatialValueExtensionMethods
	{
		// Token: 0x06000039 RID: 57 RVA: 0x0000251D File Offset: 0x0000071D
		internal static global::System.Data.Entity.SqlServer.IDbSpatialValue AsSpatialValue(this global::System.Data.Entity.Spatial.DbGeography geographyValue)
		{
			return new global::System.Data.Entity.SqlServer.DbGeographyAdapter(geographyValue);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002525 File Offset: 0x00000725
		internal static global::System.Data.Entity.SqlServer.IDbSpatialValue AsSpatialValue(this global::System.Data.Entity.Spatial.DbGeometry geometryValue)
		{
			return new global::System.Data.Entity.SqlServer.DbGeometryAdapter(geometryValue);
		}
	}
}
