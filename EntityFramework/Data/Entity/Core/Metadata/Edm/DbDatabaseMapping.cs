using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x0200049E RID: 1182
	internal class DbDatabaseMapping
	{
		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06003A3B RID: 14907 RVA: 0x000BFB85 File Offset: 0x000BDD85
		// (set) Token: 0x06003A3C RID: 14908 RVA: 0x000BFB8D File Offset: 0x000BDD8D
		public global::System.Data.Entity.Core.Metadata.Edm.EdmModel Model { get; set; }

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06003A3D RID: 14909 RVA: 0x000BFB96 File Offset: 0x000BDD96
		// (set) Token: 0x06003A3E RID: 14910 RVA: 0x000BFB9E File Offset: 0x000BDD9E
		public global::System.Data.Entity.Core.Metadata.Edm.EdmModel Database { get; set; }

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06003A3F RID: 14911 RVA: 0x000BFBA7 File Offset: 0x000BDDA7
		public global::System.Data.Entity.Infrastructure.DbProviderInfo ProviderInfo
		{
			get
			{
				return this.Database.ProviderInfo;
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06003A40 RID: 14912 RVA: 0x000BFBB4 File Offset: 0x000BDDB4
		public global::System.Data.Entity.Core.Common.DbProviderManifest ProviderManifest
		{
			get
			{
				return this.Database.ProviderManifest;
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06003A41 RID: 14913 RVA: 0x000BFBC1 File Offset: 0x000BDDC1
		internal global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.EntityContainerMapping> EntityContainerMappings
		{
			get
			{
				return this._entityContainerMappings;
			}
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x000BFBC9 File Offset: 0x000BDDC9
		internal void AddEntityContainerMapping(global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>(entityContainerMapping, "entityContainerMapping");
			this._entityContainerMappings.Add(entityContainerMapping);
		}

		// Token: 0x04001371 RID: 4977
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityContainerMapping> _entityContainerMappings = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>();
	}
}
