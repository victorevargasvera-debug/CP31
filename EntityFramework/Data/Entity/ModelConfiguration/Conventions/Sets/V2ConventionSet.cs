using System;
using System.Collections.Generic;

namespace System.Data.Entity.ModelConfiguration.Conventions.Sets
{
	// Token: 0x020001BC RID: 444
	internal static class V2ConventionSet
	{
		// Token: 0x060017B0 RID: 6064 RVA: 0x0003F58C File Offset: 0x0003D78C
		static V2ConventionSet()
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> list = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention>(global::System.Data.Entity.ModelConfiguration.Conventions.Sets.V1ConventionSet.Conventions.StoreModelConventions);
			int index = list.FindIndex((global::System.Data.Entity.ModelConfiguration.Conventions.IConvention c) => c.GetType() == typeof(global::System.Data.Entity.ModelConfiguration.Conventions.ColumnOrderingConvention));
			list[index] = new global::System.Data.Entity.ModelConfiguration.Conventions.ColumnOrderingConventionStrict();
			global::System.Data.Entity.ModelConfiguration.Conventions.Sets.V2ConventionSet._conventions = new global::System.Data.Entity.ModelConfiguration.Conventions.Sets.ConventionSet(global::System.Data.Entity.ModelConfiguration.Conventions.Sets.V1ConventionSet.Conventions.ConfigurationConventions, global::System.Data.Entity.ModelConfiguration.Conventions.Sets.V1ConventionSet.Conventions.ConceptualModelConventions, global::System.Data.Entity.ModelConfiguration.Conventions.Sets.V1ConventionSet.Conventions.ConceptualToStoreMappingConventions, list);
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x0003F5F5 File Offset: 0x0003D7F5
		public static global::System.Data.Entity.ModelConfiguration.Conventions.Sets.ConventionSet Conventions
		{
			get
			{
				return global::System.Data.Entity.ModelConfiguration.Conventions.Sets.V2ConventionSet._conventions;
			}
		}

		// Token: 0x04000A41 RID: 2625
		private static readonly global::System.Data.Entity.ModelConfiguration.Conventions.Sets.ConventionSet _conventions;
	}
}
