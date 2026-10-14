using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001A3 RID: 419
	internal interface IDbMappingConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x06001764 RID: 5988
		void Apply(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping);
	}
}
