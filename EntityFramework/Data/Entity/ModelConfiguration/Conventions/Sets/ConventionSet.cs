using System;
using System.Collections.Generic;

namespace System.Data.Entity.ModelConfiguration.Conventions.Sets
{
	// Token: 0x020001BA RID: 442
	internal class ConventionSet
	{
		// Token: 0x060017A4 RID: 6052 RVA: 0x0003F376 File Offset: 0x0003D576
		public ConventionSet()
		{
			this.ConfigurationConventions = new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[0];
			this.ConceptualModelConventions = new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[0];
			this.ConceptualToStoreMappingConventions = new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[0];
			this.StoreModelConventions = new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[0];
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x0003F3AE File Offset: 0x0003D5AE
		public ConventionSet(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> configurationConventions, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> entityModelConventions, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> dbMappingConventions, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> dbModelConventions)
		{
			this.ConfigurationConventions = configurationConventions;
			this.ConceptualModelConventions = entityModelConventions;
			this.ConceptualToStoreMappingConventions = dbMappingConventions;
			this.StoreModelConventions = dbModelConventions;
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x0003F3D3 File Offset: 0x0003D5D3
		// (set) Token: 0x060017A7 RID: 6055 RVA: 0x0003F3DB File Offset: 0x0003D5DB
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> ConfigurationConventions { get; private set; }

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x0003F3E4 File Offset: 0x0003D5E4
		// (set) Token: 0x060017A9 RID: 6057 RVA: 0x0003F3EC File Offset: 0x0003D5EC
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> ConceptualModelConventions { get; private set; }

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x0003F3F5 File Offset: 0x0003D5F5
		// (set) Token: 0x060017AB RID: 6059 RVA: 0x0003F3FD File Offset: 0x0003D5FD
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> ConceptualToStoreMappingConventions { get; private set; }

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x0003F406 File Offset: 0x0003D606
		// (set) Token: 0x060017AD RID: 6061 RVA: 0x0003F40E File Offset: 0x0003D60E
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> StoreModelConventions { get; private set; }
	}
}
