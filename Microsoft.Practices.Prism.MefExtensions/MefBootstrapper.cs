using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.MefExtensions.Properties;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism.MefExtensions
{
	// Token: 0x02000004 RID: 4
	public abstract class MefBootstrapper : global::Microsoft.Practices.Prism.Bootstrapper
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000226E File Offset: 0x0000046E
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002276 File Offset: 0x00000476
		protected global::System.ComponentModel.Composition.Hosting.AggregateCatalog AggregateCatalog { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000227F File Offset: 0x0000047F
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002287 File Offset: 0x00000487
		protected global::System.ComponentModel.Composition.Hosting.CompositionContainer Container { get; set; }

		// Token: 0x06000009 RID: 9 RVA: 0x00002290 File Offset: 0x00000490
		public override void Run(bool runWithDefaultConfiguration)
		{
			base.Logger = this.CreateLogger();
			if (base.Logger == null)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.NullLoggerFacadeException);
			}
			base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.LoggerWasCreatedSuccessfully, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
			base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.CreatingModuleCatalog, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
			base.ModuleCatalog = this.CreateModuleCatalog();
			if (base.ModuleCatalog == null)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.NullModuleCatalogException);
			}
			base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.ConfiguringModuleCatalog, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
			this.ConfigureModuleCatalog();
			base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.CreatingCatalogForMEF, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
			this.AggregateCatalog = this.CreateAggregateCatalog();
			base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.ConfiguringCatalogForMEF, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
			this.ConfigureAggregateCatalog();
			this.RegisterDefaultTypesIfMissing();
			base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.CreatingMefContainer, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
			this.Container = this.CreateContainer();
			if (this.Container == null)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.NullCompositionContainerException);
			}
			base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.ConfiguringMefContainer, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
			this.ConfigureContainer();
			base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.ConfiguringServiceLocatorSingleton, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
			this.ConfigureServiceLocator();
			base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.ConfiguringRegionAdapters, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
			this.ConfigureRegionAdapterMappings();
			base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.ConfiguringDefaultRegionBehaviors, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
			this.ConfigureDefaultRegionBehaviors();
			base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.RegisteringFrameworkExceptionTypes, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
			this.RegisterFrameworkExceptionTypes();
			base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.CreatingShell, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
			base.Shell = this.CreateShell();
			if (base.Shell != null)
			{
				base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.SettingTheRegionManager, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
				global::Microsoft.Practices.Prism.Regions.RegionManager.SetRegionManager(base.Shell, this.Container.GetExportedValue<global::Microsoft.Practices.Prism.Regions.IRegionManager>());
				base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.UpdatingRegions, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
				global::Microsoft.Practices.Prism.Regions.RegionManager.UpdateRegions();
				base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.InitializingShell, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
				this.InitializeShell();
			}
			global::System.Collections.Generic.IEnumerable<global::System.Lazy<object, object>> exports = this.Container.GetExports(typeof(global::Microsoft.Practices.Prism.Modularity.IModuleManager), null, null);
			if (exports != null && exports.Count<global::System.Lazy<object, object>>() > 0)
			{
				base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.InitializingModules, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
				this.InitializeModules();
			}
			base.Logger.Log(global::Microsoft.Practices.Prism.MefExtensions.Properties.Resources.BootstrapperSequenceCompleted, global::Microsoft.Practices.Prism.Logging.Category.Debug, global::Microsoft.Practices.Prism.Logging.Priority.Low);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000024C9 File Offset: 0x000006C9
		protected virtual global::System.ComponentModel.Composition.Hosting.AggregateCatalog CreateAggregateCatalog()
		{
			return new global::System.ComponentModel.Composition.Hosting.AggregateCatalog();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000024D0 File Offset: 0x000006D0
		protected virtual void ConfigureAggregateCatalog()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000024D4 File Offset: 0x000006D4
		protected virtual global::System.ComponentModel.Composition.Hosting.CompositionContainer CreateContainer()
		{
			return new global::System.ComponentModel.Composition.Hosting.CompositionContainer(this.AggregateCatalog, new global::System.ComponentModel.Composition.Hosting.ExportProvider[0]);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000024F4 File Offset: 0x000006F4
		protected virtual void ConfigureContainer()
		{
			this.RegisterBootstrapperProvidedTypes();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000024FC File Offset: 0x000006FC
		public virtual void RegisterDefaultTypesIfMissing()
		{
			this.AggregateCatalog = global::Microsoft.Practices.Prism.MefExtensions.DefaultPrismServiceRegistrar.RegisterRequiredPrismServicesIfMissing(this.AggregateCatalog);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002510 File Offset: 0x00000710
		protected virtual void RegisterBootstrapperProvidedTypes()
		{
			this.Container.ComposeExportedValue(base.Logger);
			this.Container.ComposeExportedValue(base.ModuleCatalog);
			this.Container.ComposeExportedValue(new global::Microsoft.Practices.Prism.MefExtensions.MefServiceLocatorAdapter(this.Container));
			this.Container.ComposeExportedValue(this.AggregateCatalog);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002578 File Offset: 0x00000778
		protected override void ConfigureServiceLocator()
		{
			global::Microsoft.Practices.ServiceLocation.IServiceLocator serviceLocator = this.Container.GetExportedValue<global::Microsoft.Practices.ServiceLocation.IServiceLocator>();
			global::Microsoft.Practices.ServiceLocation.ServiceLocator.SetLocatorProvider(() => serviceLocator);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000025B0 File Offset: 0x000007B0
		protected override void InitializeShell()
		{
			this.Container.ComposeParts(new object[]
			{
				base.Shell
			});
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000025DC File Offset: 0x000007DC
		protected override void InitializeModules()
		{
			global::Microsoft.Practices.Prism.Modularity.IModuleManager exportedValue = this.Container.GetExportedValue<global::Microsoft.Practices.Prism.Modularity.IModuleManager>();
			exportedValue.Run();
		}
	}
}
