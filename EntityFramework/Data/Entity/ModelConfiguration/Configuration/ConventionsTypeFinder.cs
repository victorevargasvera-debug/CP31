using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001C8 RID: 456
	internal class ConventionsTypeFinder
	{
		// Token: 0x06001815 RID: 6165 RVA: 0x000408DF File Offset: 0x0003EADF
		public ConventionsTypeFinder() : this(new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter(), new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeActivator())
		{
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x000408F1 File Offset: 0x0003EAF1
		public ConventionsTypeFinder(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter conventionsTypeFilter, global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeActivator conventionsTypeActivator)
		{
			this._conventionsTypeFilter = conventionsTypeFilter;
			this._conventionsTypeActivator = conventionsTypeActivator;
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00040908 File Offset: 0x0003EB08
		public void AddConventions(global::System.Collections.Generic.IEnumerable<global::System.Type> types, global::System.Action<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention> addFunction)
		{
			foreach (global::System.Type conventionType in types)
			{
				if (this._conventionsTypeFilter.IsConvention(conventionType))
				{
					addFunction(this._conventionsTypeActivator.Activate(conventionType));
				}
			}
		}

		// Token: 0x04000A4F RID: 2639
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeFilter _conventionsTypeFilter;

		// Token: 0x04000A50 RID: 2640
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsTypeActivator _conventionsTypeActivator;
	}
}
