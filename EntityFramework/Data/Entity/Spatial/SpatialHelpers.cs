using System;
using System.Data.Common;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Spatial
{
	// Token: 0x02000098 RID: 152
	internal static class SpatialHelpers
	{
		// Token: 0x0600066E RID: 1646 RVA: 0x00011E14 File Offset: 0x00010014
		internal static object GetSpatialValue(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Common.DbDataReader reader, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage columnType, int columnOrdinal)
		{
			global::System.Data.Entity.Spatial.DbSpatialDataReader dbSpatialDataReader = global::System.Data.Entity.Spatial.SpatialHelpers.CreateSpatialDataReader(workspace, reader);
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeographicType((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)columnType.EdmType))
			{
				return dbSpatialDataReader.GetGeography(columnOrdinal);
			}
			return dbSpatialDataReader.GetGeometry(columnOrdinal);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00011E4C File Offset: 0x0001004C
		internal static async global::System.Threading.Tasks.Task<object> GetSpatialValueAsync(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Common.DbDataReader reader, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage columnType, int columnOrdinal, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Spatial.DbSpatialDataReader dbSpatialDataReader = global::System.Data.Entity.Spatial.SpatialHelpers.CreateSpatialDataReader(workspace, reader);
			object result;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeographicType((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)columnType.EdmType))
			{
				result = await dbSpatialDataReader.GetGeographyAsync(columnOrdinal, cancellationToken).WithCurrentCulture<global::System.Data.Entity.Spatial.DbGeography>();
			}
			else
			{
				result = await dbSpatialDataReader.GetGeometryAsync(columnOrdinal, cancellationToken).WithCurrentCulture<global::System.Data.Entity.Spatial.DbGeometry>();
			}
			return result;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00011EB4 File Offset: 0x000100B4
		internal static global::System.Data.Entity.Spatial.DbSpatialDataReader CreateSpatialDataReader(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Common.DbDataReader reader)
		{
			global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection = (global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)workspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
			global::System.Data.Entity.Spatial.DbSpatialDataReader spatialDataReader = storeItemCollection.ProviderFactory.GetProviderServices().GetSpatialDataReader(reader, storeItemCollection.ProviderManifestToken);
			if (spatialDataReader == null)
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.ProviderDidNotReturnSpatialServices);
			}
			return spatialDataReader;
		}
	}
}
