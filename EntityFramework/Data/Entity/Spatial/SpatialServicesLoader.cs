using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;

namespace System.Data.Entity.Spatial
{
	// Token: 0x02000099 RID: 153
	internal class SpatialServicesLoader
	{
		// Token: 0x06000671 RID: 1649 RVA: 0x00011EF3 File Offset: 0x000100F3
		public SpatialServicesLoader(global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver)
		{
			this._resolver = resolver;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00011F04 File Offset: 0x00010104
		public virtual global::System.Data.Entity.Spatial.DbSpatialServices LoadDefaultServices()
		{
			global::System.Data.Entity.Spatial.DbSpatialServices service = this._resolver.GetService<global::System.Data.Entity.Spatial.DbSpatialServices>();
			if (service != null)
			{
				return service;
			}
			service = this._resolver.GetService(new global::System.Data.Entity.Infrastructure.DbProviderInfo("System.Data.SqlClient", "2012"));
			if (service != null && service.NativeTypesAvailable)
			{
				return service;
			}
			return global::System.Data.Entity.Spatial.DefaultSpatialServices.Instance;
		}

		// Token: 0x0400012B RID: 299
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver _resolver;
	}
}
