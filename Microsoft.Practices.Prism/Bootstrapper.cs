using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.Regions.Behaviors;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism
{
	// Token: 0x02000002 RID: 2
	public abstract class Bootstrapper
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
		protected global::Microsoft.Practices.Prism.Logging.ILoggerFacade Logger { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000020E1 File Offset: 0x000002E1
		// (set) Token: 0x06000004 RID: 4 RVA: 0x000020E9 File Offset: 0x000002E9
		protected global::Microsoft.Practices.Prism.Modularity.IModuleCatalog ModuleCatalog { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020F2 File Offset: 0x000002F2
		// (set) Token: 0x06000006 RID: 6 RVA: 0x000020FA File Offset: 0x000002FA
		protected global::System.Windows.DependencyObject Shell { get; set; }

		// Token: 0x06000007 RID: 7 RVA: 0x00002103 File Offset: 0x00000303
		protected virtual global::Microsoft.Practices.Prism.Logging.ILoggerFacade CreateLogger()
		{
			return new global::Microsoft.Practices.Prism.Logging.TextLogger();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000210A File Offset: 0x0000030A
		public void Run()
		{
			this.Run(true);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002113 File Offset: 0x00000313
		protected virtual global::Microsoft.Practices.Prism.Modularity.IModuleCatalog CreateModuleCatalog()
		{
			return new global::Microsoft.Practices.Prism.Modularity.ModuleCatalog();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000211A File Offset: 0x0000031A
		protected virtual void ConfigureModuleCatalog()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000211C File Offset: 0x0000031C
		protected virtual void RegisterFrameworkExceptionTypes()
		{
			global::Microsoft.Practices.Prism.ExceptionExtensions.RegisterFrameworkExceptionType(typeof(global::Microsoft.Practices.ServiceLocation.ActivationException));
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002130 File Offset: 0x00000330
		protected virtual void InitializeModules()
		{
			global::Microsoft.Practices.Prism.Modularity.IModuleManager instance = global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Modularity.IModuleManager>();
			instance.Run();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002150 File Offset: 0x00000350
		protected virtual global::Microsoft.Practices.Prism.Regions.RegionAdapterMappings ConfigureRegionAdapterMappings()
		{
			global::Microsoft.Practices.Prism.Regions.RegionAdapterMappings instance = global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Regions.RegionAdapterMappings>();
			if (instance != null)
			{
				instance.RegisterMapping(typeof(global::System.Windows.Controls.Primitives.Selector), global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Regions.SelectorRegionAdapter>());
				instance.RegisterMapping(typeof(global::System.Windows.Controls.ItemsControl), global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Regions.ItemsControlRegionAdapter>());
				instance.RegisterMapping(typeof(global::System.Windows.Controls.ContentControl), global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Regions.ContentControlRegionAdapter>());
			}
			return instance;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021BC File Offset: 0x000003BC
		protected virtual global::Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory ConfigureDefaultRegionBehaviors()
		{
			global::Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory instance = global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory>();
			if (instance != null)
			{
				instance.AddIfMissing("AutoPopulate", typeof(global::Microsoft.Practices.Prism.Regions.Behaviors.AutoPopulateRegionBehavior));
				instance.AddIfMissing("ContextToDependencyObject", typeof(global::Microsoft.Practices.Prism.Regions.Behaviors.BindRegionContextToDependencyObjectBehavior));
				instance.AddIfMissing("ActiveAware", typeof(global::Microsoft.Practices.Prism.Regions.Behaviors.RegionActiveAwareBehavior));
				instance.AddIfMissing(global::Microsoft.Practices.Prism.Regions.Behaviors.SyncRegionContextWithHostBehavior.BehaviorKey, typeof(global::Microsoft.Practices.Prism.Regions.Behaviors.SyncRegionContextWithHostBehavior));
				instance.AddIfMissing(global::Microsoft.Practices.Prism.Regions.Behaviors.RegionManagerRegistrationBehavior.BehaviorKey, typeof(global::Microsoft.Practices.Prism.Regions.Behaviors.RegionManagerRegistrationBehavior));
				instance.AddIfMissing("RegionMemberLifetimeBehavior", typeof(global::Microsoft.Practices.Prism.Regions.Behaviors.RegionMemberLifetimeBehavior));
				instance.AddIfMissing("ClearChildViews", typeof(global::Microsoft.Practices.Prism.Regions.Behaviors.ClearChildViewsRegionBehavior));
			}
			return instance;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000226E File Offset: 0x0000046E
		protected virtual void InitializeShell()
		{
		}

		// Token: 0x06000010 RID: 16
		public abstract void Run(bool runWithDefaultConfiguration);

		// Token: 0x06000011 RID: 17
		protected abstract global::System.Windows.DependencyObject CreateShell();

		// Token: 0x06000012 RID: 18
		protected abstract void ConfigureServiceLocator();
	}
}
