using System;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Spatial
{
	// Token: 0x02000095 RID: 149
	public abstract class DbSpatialDataReader
	{
		// Token: 0x06000567 RID: 1383
		public abstract global::System.Data.Entity.Spatial.DbGeography GetGeography(int ordinal);

		// Token: 0x06000568 RID: 1384 RVA: 0x000115AC File Offset: 0x0000F7AC
		public virtual global::System.Threading.Tasks.Task<global::System.Data.Entity.Spatial.DbGeography> GetGeographyAsync(int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return global::System.Data.Entity.Utilities.TaskHelper.FromCancellation<global::System.Data.Entity.Spatial.DbGeography>();
			}
			global::System.Threading.Tasks.Task<global::System.Data.Entity.Spatial.DbGeography> result;
			try
			{
				result = global::System.Threading.Tasks.Task.FromResult<global::System.Data.Entity.Spatial.DbGeography>(this.GetGeography(ordinal));
			}
			catch (global::System.Exception ex)
			{
				result = global::System.Data.Entity.Utilities.TaskHelper.FromException<global::System.Data.Entity.Spatial.DbGeography>(ex);
			}
			return result;
		}

		// Token: 0x06000569 RID: 1385
		public abstract global::System.Data.Entity.Spatial.DbGeometry GetGeometry(int ordinal);

		// Token: 0x0600056A RID: 1386 RVA: 0x000115F4 File Offset: 0x0000F7F4
		public virtual global::System.Threading.Tasks.Task<global::System.Data.Entity.Spatial.DbGeometry> GetGeometryAsync(int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return global::System.Data.Entity.Utilities.TaskHelper.FromCancellation<global::System.Data.Entity.Spatial.DbGeometry>();
			}
			global::System.Threading.Tasks.Task<global::System.Data.Entity.Spatial.DbGeometry> result;
			try
			{
				result = global::System.Threading.Tasks.Task.FromResult<global::System.Data.Entity.Spatial.DbGeometry>(this.GetGeometry(ordinal));
			}
			catch (global::System.Exception ex)
			{
				result = global::System.Data.Entity.Utilities.TaskHelper.FromException<global::System.Data.Entity.Spatial.DbGeometry>(ex);
			}
			return result;
		}

		// Token: 0x0600056B RID: 1387
		public abstract bool IsGeographyColumn(int ordinal);

		// Token: 0x0600056C RID: 1388
		public abstract bool IsGeometryColumn(int ordinal);
	}
}
