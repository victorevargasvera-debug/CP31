using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000EE RID: 238
	internal class CodeFirstCachedMetadataWorkspace : global::System.Data.Entity.Internal.ICachedMetadataWorkspace
	{
		// Token: 0x06001203 RID: 4611 RVA: 0x0002DC3E File Offset: 0x0002BE3E
		private CodeFirstCachedMetadataWorkspace(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace, global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> assemblies, global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo, string defaultContainerName)
		{
			this._metadataWorkspace = metadataWorkspace;
			this._assemblies = assemblies;
			this._providerInfo = providerInfo;
			this._defaultContainerName = defaultContainerName;
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0002DC64 File Offset: 0x0002BE64
		public global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace GetMetadataWorkspace(global::System.Data.Common.DbConnection connection)
		{
			string providerInvariantName = connection.GetProviderInvariantName();
			if (!string.Equals(this._providerInfo.ProviderInvariantName, providerInvariantName, global::System.StringComparison.Ordinal))
			{
				throw global::System.Data.Entity.Resources.Error.CodeFirstCachedMetadataWorkspace_SameModelDifferentProvidersNotSupported();
			}
			return this._metadataWorkspace;
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x0002DC98 File Offset: 0x0002BE98
		public string DefaultContainerName
		{
			get
			{
				return this._defaultContainerName;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x0002DCA0 File Offset: 0x0002BEA0
		public global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> Assemblies
		{
			get
			{
				return this._assemblies;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x0002DCA8 File Offset: 0x0002BEA8
		public global::System.Data.Entity.Infrastructure.DbProviderInfo ProviderInfo
		{
			get
			{
				return this._providerInfo;
			}
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0002DCB0 File Offset: 0x0002BEB0
		public static global::System.Data.Entity.Internal.CodeFirstCachedMetadataWorkspace Create(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmModel model = databaseMapping.Model;
			return new global::System.Data.Entity.Internal.CodeFirstCachedMetadataWorkspace(databaseMapping.ToMetadataWorkspace(), (from t in model.GetClrTypes()
			select t.Assembly()).Distinct<global::System.Reflection.Assembly>().ToArray<global::System.Reflection.Assembly>(), databaseMapping.ProviderInfo, model.Container.Name);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0002DD14 File Offset: 0x0002BF14
		public static global::System.Data.Entity.Internal.CodeFirstCachedMetadataWorkspace Create(global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection mappingItemCollection, global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection = mappingItemCollection.EdmItemCollection;
			global::System.Collections.Generic.IEnumerable<global::System.Type> first = from et in edmItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityType>()
			select et.GetClrType();
			global::System.Collections.Generic.IEnumerable<global::System.Type> second = from ct in edmItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>()
			select ct.GetClrType();
			return new global::System.Data.Entity.Internal.CodeFirstCachedMetadataWorkspace(mappingItemCollection.Workspace, (from t in first.Union(second)
			select t.Assembly()).Distinct<global::System.Reflection.Assembly>().ToArray<global::System.Reflection.Assembly>(), providerInfo, edmItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>().Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>().Name);
		}

		// Token: 0x040008FA RID: 2298
		private readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace _metadataWorkspace;

		// Token: 0x040008FB RID: 2299
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> _assemblies;

		// Token: 0x040008FC RID: 2300
		private readonly global::System.Data.Entity.Infrastructure.DbProviderInfo _providerInfo;

		// Token: 0x040008FD RID: 2301
		private readonly string _defaultContainerName;
	}
}
