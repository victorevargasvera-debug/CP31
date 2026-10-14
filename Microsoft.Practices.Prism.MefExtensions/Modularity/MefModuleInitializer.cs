using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Globalization;
using System.Linq;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.MefExtensions.Properties;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism.MefExtensions.Modularity
{
	// Token: 0x02000008 RID: 8
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Modularity.IModuleInitializer))]
	public class MefModuleInitializer : global::Microsoft.Practices.Prism.Modularity.ModuleInitializer
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002920 File Offset: 0x00000B20
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002928 File Offset: 0x00000B28
		private global::System.ComponentModel.Composition.Hosting.AggregateCatalog aggregateCatalog { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002931 File Offset: 0x00000B31
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002939 File Offset: 0x00000B39
		[global::System.ComponentModel.Composition.ImportMany(AllowRecomposition = true)]
		private global::System.Collections.Generic.IEnumerable<global::System.Lazy<global::Microsoft.Practices.Prism.Modularity.IModule, global::Microsoft.Practices.Prism.MefExtensions.Modularity.IModuleExport>> ImportedModules { get; set; }

		// Token: 0x0600002F RID: 47 RVA: 0x00002942 File Offset: 0x00000B42
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MefModuleInitializer(global::Microsoft.Practices.ServiceLocation.IServiceLocator serviceLocator, global::Microsoft.Practices.Prism.Logging.ILoggerFacade loggerFacade, global::Microsoft.Practices.Prism.MefExtensions.Modularity.DownloadedPartCatalogCollection downloadedPartCatalogs, global::System.ComponentModel.Composition.Hosting.AggregateCatalog aggregateCatalog) : base(serviceLocator, loggerFacade)
		{
			if (downloadedPartCatalogs == null)
			{
				throw new global::System.ArgumentNullException("downloadedPartCatalogs");
			}
			if (aggregateCatalog == null)
			{
				throw new global::System.ArgumentNullException("aggregateCatalog");
			}
			this.downloadedPartCatalogs = downloadedPartCatalogs;
			this.aggregateCatalog = aggregateCatalog;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000029A0 File Offset: 0x00000BA0
		protected override global::Microsoft.Practices.Prism.Modularity.IModule CreateModule(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			global::System.ComponentModel.Composition.Primitives.ComposablePartCatalog item;
			if (this.downloadedPartCatalogs.TryGet(moduleInfo, out item))
			{
				if (!this.aggregateCatalog.Catalogs.Contains(item))
				{
					this.aggregateCatalog.Catalogs.Add(item);
				}
				this.downloadedPartCatalogs.Remove(moduleInfo);
			}
			if (this.ImportedModules != null && this.ImportedModules.Count<global::System.Lazy<global::Microsoft.Practices.Prism.Modularity.IModule, global::Microsoft.Practices.Prism.MefExtensions.Modularity.IModuleExport>>() != 0)
			{
				global::System.Lazy<global::Microsoft.Practices.Prism.Modularity.IModule, global::Microsoft.Practices.Prism.MefExtensions.Modularity.IModuleExport> lazy = this.ImportedModules.FirstOrDefault((global::System.Lazy<global::Microsoft.Practices.Prism.Modularity.IModule, global::Microsoft.Practices.Prism.MefExtensions.Modularity.IModuleExport> x) => x.Metadata.ModuleName == moduleInfo.ModuleName);
				if (lazy != null)
				{
					return lazy.Value;
				}
			}
			throw new global::Microsoft.Practices.Prism.Modularity.ModuleInitializeException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.FailedToGetType, new object[]
			{
				moduleInfo.ModuleType
			}));
		}

		// Token: 0x04000009 RID: 9
		private global::Microsoft.Practices.Prism.MefExtensions.Modularity.DownloadedPartCatalogCollection downloadedPartCatalogs;
	}
}
