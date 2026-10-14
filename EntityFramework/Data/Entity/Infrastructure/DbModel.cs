using System;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Internal;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Linq;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200022B RID: 555
	public class DbModel : global::System.Data.Entity.Core.Metadata.Edm.IEdmModelAdapter
	{
		// Token: 0x06001D31 RID: 7473 RVA: 0x00052257 File Offset: 0x00050457
		internal DbModel(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.DbModelBuilder modelBuilder)
		{
			this._databaseMapping = databaseMapping;
			this._cachedModelBuilder = modelBuilder;
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x0005226D File Offset: 0x0005046D
		internal DbModel(global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			this._databaseMapping = new global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping().Initialize(global::System.Data.Entity.Core.Metadata.Edm.EdmModel.CreateConceptualModel(3.0), global::System.Data.Entity.Core.Metadata.Edm.EdmModel.CreateStoreModel(providerInfo, providerManifest, 3.0));
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x000522A3 File Offset: 0x000504A3
		internal DbModel(global::System.Data.Entity.Core.Metadata.Edm.EdmModel conceptualModel, global::System.Data.Entity.Core.Metadata.Edm.EdmModel storeModel)
		{
			this._databaseMapping = new global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping
			{
				Model = conceptualModel,
				Database = storeModel
			};
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x000522C4 File Offset: 0x000504C4
		public global::System.Data.Entity.Infrastructure.DbProviderInfo ProviderInfo
		{
			get
			{
				return this.StoreModel.ProviderInfo;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x000522D1 File Offset: 0x000504D1
		public global::System.Data.Entity.Core.Common.DbProviderManifest ProviderManifest
		{
			get
			{
				return this.StoreModel.ProviderManifest;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x000522DE File Offset: 0x000504DE
		public global::System.Data.Entity.Core.Metadata.Edm.EdmModel ConceptualModel
		{
			get
			{
				return this._databaseMapping.Model;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x000522EB File Offset: 0x000504EB
		public global::System.Data.Entity.Core.Metadata.Edm.EdmModel StoreModel
		{
			get
			{
				return this._databaseMapping.Database;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x000522F8 File Offset: 0x000504F8
		public global::System.Data.Entity.Core.Mapping.EntityContainerMapping ConceptualToStoreMapping
		{
			get
			{
				return this._databaseMapping.EntityContainerMappings.SingleOrDefault<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>();
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x0005230A File Offset: 0x0005050A
		internal global::System.Data.Entity.DbModelBuilder CachedModelBuilder
		{
			get
			{
				return this._cachedModelBuilder;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x00052312 File Offset: 0x00050512
		internal global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping DatabaseMapping
		{
			get
			{
				return this._databaseMapping;
			}
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x0005231A File Offset: 0x0005051A
		public global::System.Data.Entity.Infrastructure.DbCompiledModel Compile()
		{
			return new global::System.Data.Entity.Infrastructure.DbCompiledModel(global::System.Data.Entity.Internal.CodeFirstCachedMetadataWorkspace.Create(this.DatabaseMapping), this.CachedModelBuilder);
		}

		// Token: 0x04000B1C RID: 2844
		private readonly global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping _databaseMapping;

		// Token: 0x04000B1D RID: 2845
		private readonly global::System.Data.Entity.DbModelBuilder _cachedModelBuilder;
	}
}
