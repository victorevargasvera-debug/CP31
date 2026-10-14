using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Reflection;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000116 RID: 278
	internal interface ICachedMetadataWorkspace
	{
		// Token: 0x06001361 RID: 4961
		global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace GetMetadataWorkspace(global::System.Data.Common.DbConnection storeConnection);

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001362 RID: 4962
		global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> Assemblies { get; }

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001363 RID: 4963
		string DefaultContainerName { get; }

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001364 RID: 4964
		global::System.Data.Entity.Infrastructure.DbProviderInfo ProviderInfo { get; }
	}
}
