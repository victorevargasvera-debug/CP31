using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Reflection;

namespace Microsoft.Practices.Prism.MefExtensions
{
	// Token: 0x02000002 RID: 2
	public static class DefaultPrismServiceRegistrar
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		public static global::System.ComponentModel.Composition.Hosting.AggregateCatalog RegisterRequiredPrismServicesIfMissing(global::System.ComponentModel.Composition.Hosting.AggregateCatalog aggregateCatalog)
		{
			if (aggregateCatalog == null)
			{
				throw new global::System.ArgumentNullException("aggregateCatalog");
			}
			global::System.Collections.Generic.IEnumerable<global::System.ComponentModel.Composition.Primitives.ComposablePartDefinition> requiredPrismPartsToRegister = global::Microsoft.Practices.Prism.MefExtensions.DefaultPrismServiceRegistrar.GetRequiredPrismPartsToRegister(aggregateCatalog);
			global::Microsoft.Practices.Prism.MefExtensions.PrismDefaultsCatalog item = new global::Microsoft.Practices.Prism.MefExtensions.PrismDefaultsCatalog(requiredPrismPartsToRegister);
			aggregateCatalog.Catalogs.Add(item);
			return aggregateCatalog;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002108 File Offset: 0x00000308
		private static global::System.Collections.Generic.IEnumerable<global::System.ComponentModel.Composition.Primitives.ComposablePartDefinition> GetRequiredPrismPartsToRegister(global::System.ComponentModel.Composition.Hosting.AggregateCatalog aggregateCatalog)
		{
			global::System.Collections.Generic.List<global::System.ComponentModel.Composition.Primitives.ComposablePartDefinition> list = new global::System.Collections.Generic.List<global::System.ComponentModel.Composition.Primitives.ComposablePartDefinition>();
			global::System.ComponentModel.Composition.Primitives.ComposablePartCatalog defaultComposablePartCatalog = global::Microsoft.Practices.Prism.MefExtensions.DefaultPrismServiceRegistrar.GetDefaultComposablePartCatalog();
			foreach (global::System.ComponentModel.Composition.Primitives.ComposablePartDefinition composablePartDefinition in defaultComposablePartCatalog.Parts)
			{
				foreach (global::System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition in composablePartDefinition.ExportDefinitions)
				{
					bool flag = false;
					foreach (global::System.ComponentModel.Composition.Primitives.ComposablePartDefinition composablePartDefinition2 in aggregateCatalog.Parts)
					{
						foreach (global::System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition2 in composablePartDefinition2.ExportDefinitions)
						{
							if (string.Compare(exportDefinition2.ContractName, exportDefinition.ContractName, global::System.StringComparison.Ordinal) == 0)
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag && !list.Contains(composablePartDefinition))
					{
						list.Add(composablePartDefinition);
					}
				}
			}
			return list;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002250 File Offset: 0x00000450
		private static global::System.ComponentModel.Composition.Primitives.ComposablePartCatalog GetDefaultComposablePartCatalog()
		{
			return new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(global::System.Reflection.Assembly.GetAssembly(typeof(global::Microsoft.Practices.Prism.MefExtensions.MefBootstrapper)));
		}
	}
}
