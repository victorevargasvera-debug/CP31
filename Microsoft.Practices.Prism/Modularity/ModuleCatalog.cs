using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Resources;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x0200003A RID: 58
	[global::System.Windows.Markup.ContentProperty("Items")]
	public class ModuleCatalog : global::Microsoft.Practices.Prism.Modularity.IModuleCatalog
	{
		// Token: 0x06000148 RID: 328 RVA: 0x000050E9 File Offset: 0x000032E9
		public ModuleCatalog()
		{
			this.items = new global::Microsoft.Practices.Prism.Modularity.ModuleCatalog.ModuleCatalogItemCollection();
			this.items.CollectionChanged += this.ItemsCollectionChanged;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00005114 File Offset: 0x00003314
		public ModuleCatalog(global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> modules) : this()
		{
			if (modules == null)
			{
				throw new global::System.ArgumentNullException("modules");
			}
			foreach (global::Microsoft.Practices.Prism.Modularity.ModuleInfo item in modules)
			{
				this.Items.Add(item);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00005178 File Offset: 0x00003378
		public global::System.Collections.ObjectModel.Collection<global::Microsoft.Practices.Prism.Modularity.IModuleCatalogItem> Items
		{
			get
			{
				return this.items;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00005183 File Offset: 0x00003383
		public virtual global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> Modules
		{
			get
			{
				return this.GrouplessModules.Union(this.Groups.SelectMany((global::Microsoft.Practices.Prism.Modularity.ModuleInfoGroup g) => g));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000051B8 File Offset: 0x000033B8
		public global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfoGroup> Groups
		{
			get
			{
				return this.Items.OfType<global::Microsoft.Practices.Prism.Modularity.ModuleInfoGroup>();
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000051C5 File Offset: 0x000033C5
		// (set) Token: 0x0600014E RID: 334 RVA: 0x000051CD File Offset: 0x000033CD
		protected bool Validated { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600014F RID: 335 RVA: 0x000051D6 File Offset: 0x000033D6
		protected global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> GrouplessModules
		{
			get
			{
				return this.Items.OfType<global::Microsoft.Practices.Prism.Modularity.ModuleInfo>();
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000051E3 File Offset: 0x000033E3
		public static global::Microsoft.Practices.Prism.Modularity.ModuleCatalog CreateFromXaml(global::System.IO.Stream xamlStream)
		{
			if (xamlStream == null)
			{
				throw new global::System.ArgumentNullException("xamlStream");
			}
			return global::System.Windows.Markup.XamlReader.Load(xamlStream) as global::Microsoft.Practices.Prism.Modularity.ModuleCatalog;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00005200 File Offset: 0x00003400
		public static global::Microsoft.Practices.Prism.Modularity.ModuleCatalog CreateFromXaml(global::System.Uri builderResourceUri)
		{
			global::System.Windows.Resources.StreamResourceInfo resourceStream = global::System.Windows.Application.GetResourceStream(builderResourceUri);
			if (resourceStream != null && resourceStream.Stream != null)
			{
				return global::Microsoft.Practices.Prism.Modularity.ModuleCatalog.CreateFromXaml(resourceStream.Stream);
			}
			return null;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000522C File Offset: 0x0000342C
		public void Load()
		{
			this.isLoaded = true;
			this.InnerLoad();
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000523B File Offset: 0x0000343B
		public virtual global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> GetDependentModules(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			this.EnsureCatalogValidated();
			return this.GetDependentModulesInner(moduleInfo);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000524C File Offset: 0x0000344C
		public virtual global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> CompleteListWithDependencies(global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> modules)
		{
			if (modules == null)
			{
				throw new global::System.ArgumentNullException("modules");
			}
			this.EnsureCatalogValidated();
			global::System.Collections.Generic.List<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> list = new global::System.Collections.Generic.List<global::Microsoft.Practices.Prism.Modularity.ModuleInfo>();
			global::System.Collections.Generic.List<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> list2 = modules.ToList<global::Microsoft.Practices.Prism.Modularity.ModuleInfo>();
			while (list2.Count > 0)
			{
				global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo = list2[0];
				foreach (global::Microsoft.Practices.Prism.Modularity.ModuleInfo item in this.GetDependentModules(moduleInfo))
				{
					if (!list.Contains(item) && !list2.Contains(item))
					{
						list2.Add(item);
					}
				}
				list2.RemoveAt(0);
				list.Add(moduleInfo);
			}
			return this.Sort(list);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00005300 File Offset: 0x00003500
		public virtual void Validate()
		{
			this.ValidateUniqueModules();
			this.ValidateDependencyGraph();
			this.ValidateCrossGroupDependencies();
			this.ValidateDependenciesInitializationMode();
			this.Validated = true;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00005321 File Offset: 0x00003521
		public virtual void AddModule(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			this.Items.Add(moduleInfo);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000532F File Offset: 0x0000352F
		public global::Microsoft.Practices.Prism.Modularity.ModuleCatalog AddModule(global::System.Type moduleType, params string[] dependsOn)
		{
			return this.AddModule(moduleType, global::Microsoft.Practices.Prism.Modularity.InitializationMode.WhenAvailable, dependsOn);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000533A File Offset: 0x0000353A
		public global::Microsoft.Practices.Prism.Modularity.ModuleCatalog AddModule(global::System.Type moduleType, global::Microsoft.Practices.Prism.Modularity.InitializationMode initializationMode, params string[] dependsOn)
		{
			if (moduleType == null)
			{
				throw new global::System.ArgumentNullException("moduleType");
			}
			return this.AddModule(moduleType.Name, moduleType.AssemblyQualifiedName, initializationMode, dependsOn);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00005364 File Offset: 0x00003564
		public global::Microsoft.Practices.Prism.Modularity.ModuleCatalog AddModule(string moduleName, string moduleType, params string[] dependsOn)
		{
			return this.AddModule(moduleName, moduleType, global::Microsoft.Practices.Prism.Modularity.InitializationMode.WhenAvailable, dependsOn);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00005370 File Offset: 0x00003570
		public global::Microsoft.Practices.Prism.Modularity.ModuleCatalog AddModule(string moduleName, string moduleType, global::Microsoft.Practices.Prism.Modularity.InitializationMode initializationMode, params string[] dependsOn)
		{
			return this.AddModule(moduleName, moduleType, null, initializationMode, dependsOn);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00005380 File Offset: 0x00003580
		public global::Microsoft.Practices.Prism.Modularity.ModuleCatalog AddModule(string moduleName, string moduleType, string refValue, global::Microsoft.Practices.Prism.Modularity.InitializationMode initializationMode, params string[] dependsOn)
		{
			if (moduleName == null)
			{
				throw new global::System.ArgumentNullException("moduleName");
			}
			if (moduleType == null)
			{
				throw new global::System.ArgumentNullException("moduleType");
			}
			global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo = new global::Microsoft.Practices.Prism.Modularity.ModuleInfo(moduleName, moduleType);
			moduleInfo.DependsOn.AddRange(dependsOn);
			moduleInfo.InitializationMode = initializationMode;
			moduleInfo.Ref = refValue;
			this.Items.Add(moduleInfo);
			return this;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000053DB File Offset: 0x000035DB
		public virtual void Initialize()
		{
			if (!this.isLoaded)
			{
				this.Load();
			}
			this.Validate();
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000053F4 File Offset: 0x000035F4
		public virtual global::Microsoft.Practices.Prism.Modularity.ModuleCatalog AddGroup(global::Microsoft.Practices.Prism.Modularity.InitializationMode initializationMode, string refValue, params global::Microsoft.Practices.Prism.Modularity.ModuleInfo[] moduleInfos)
		{
			if (moduleInfos == null)
			{
				throw new global::System.ArgumentNullException("moduleInfos");
			}
			global::Microsoft.Practices.Prism.Modularity.ModuleInfoGroup moduleInfoGroup = new global::Microsoft.Practices.Prism.Modularity.ModuleInfoGroup();
			moduleInfoGroup.InitializationMode = initializationMode;
			moduleInfoGroup.Ref = refValue;
			foreach (global::Microsoft.Practices.Prism.Modularity.ModuleInfo item in moduleInfos)
			{
				moduleInfoGroup.Add(item);
			}
			this.items.Add(moduleInfoGroup);
			return this;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000544C File Offset: 0x0000364C
		protected static string[] SolveDependencies(global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> modules)
		{
			if (modules == null)
			{
				throw new global::System.ArgumentNullException("modules");
			}
			global::Microsoft.Practices.Prism.Modularity.ModuleDependencySolver moduleDependencySolver = new global::Microsoft.Practices.Prism.Modularity.ModuleDependencySolver();
			foreach (global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo in modules)
			{
				moduleDependencySolver.AddModule(moduleInfo.ModuleName);
				if (moduleInfo.DependsOn != null)
				{
					foreach (string dependentModule in moduleInfo.DependsOn)
					{
						moduleDependencySolver.AddDependency(moduleInfo.ModuleName, dependentModule);
					}
				}
			}
			if (moduleDependencySolver.ModuleCount > 0)
			{
				return moduleDependencySolver.Solve();
			}
			return new string[0];
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000551C File Offset: 0x0000371C
		protected static void ValidateDependencies(global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> modules)
		{
			if (modules == null)
			{
				throw new global::System.ArgumentNullException("modules");
			}
			global::System.Collections.Generic.List<string> second = (from m in modules
			select m.ModuleName).ToList<string>();
			foreach (global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo in modules)
			{
				if (moduleInfo.DependsOn != null && moduleInfo.DependsOn.Except(second).Any<string>())
				{
					throw new global::Microsoft.Practices.Prism.Modularity.ModularityException(moduleInfo.ModuleName, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.ModuleDependenciesNotMetInGroup, new object[]
					{
						moduleInfo.ModuleName
					}));
				}
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000055DC File Offset: 0x000037DC
		protected virtual void InnerLoad()
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000057CC File Offset: 0x000039CC
		protected virtual global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> Sort(global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> modules)
		{
			foreach (string moduleName in global::Microsoft.Practices.Prism.Modularity.ModuleCatalog.SolveDependencies(modules))
			{
				yield return modules.First((global::Microsoft.Practices.Prism.Modularity.ModuleInfo m) => m.ModuleName == moduleName);
			}
			yield break;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00005854 File Offset: 0x00003A54
		protected virtual void ValidateUniqueModules()
		{
			global::System.Collections.Generic.List<string> moduleNames = (from m in this.Modules
			select m.ModuleName).ToList<string>();
			string text = moduleNames.FirstOrDefault((string m) => moduleNames.Count((string m2) => m2 == m) > 1);
			if (text != null)
			{
				throw new global::Microsoft.Practices.Prism.Modularity.DuplicateModuleException(text, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.DuplicatedModule, new object[]
				{
					text
				}));
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000058D7 File Offset: 0x00003AD7
		protected virtual void ValidateDependencyGraph()
		{
			global::Microsoft.Practices.Prism.Modularity.ModuleCatalog.SolveDependencies(this.Modules);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000058E8 File Offset: 0x00003AE8
		protected virtual void ValidateCrossGroupDependencies()
		{
			global::Microsoft.Practices.Prism.Modularity.ModuleCatalog.ValidateDependencies(this.GrouplessModules);
			foreach (global::Microsoft.Practices.Prism.Modularity.ModuleInfoGroup second in this.Groups)
			{
				global::Microsoft.Practices.Prism.Modularity.ModuleCatalog.ValidateDependencies(this.GrouplessModules.Union(second));
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000598C File Offset: 0x00003B8C
		protected virtual void ValidateDependenciesInitializationMode()
		{
			global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo = this.Modules.FirstOrDefault(delegate(global::Microsoft.Practices.Prism.Modularity.ModuleInfo m)
			{
				if (m.InitializationMode == global::Microsoft.Practices.Prism.Modularity.InitializationMode.WhenAvailable)
				{
					return this.GetDependentModulesInner(m).Any((global::Microsoft.Practices.Prism.Modularity.ModuleInfo dependency) => dependency.InitializationMode == global::Microsoft.Practices.Prism.Modularity.InitializationMode.OnDemand);
				}
				return false;
			});
			if (moduleInfo != null)
			{
				throw new global::Microsoft.Practices.Prism.Modularity.ModularityException(moduleInfo.ModuleName, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.StartupModuleDependsOnAnOnDemandModule, new object[]
				{
					moduleInfo.ModuleName
				}));
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00005A00 File Offset: 0x00003C00
		protected virtual global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> GetDependentModulesInner(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			return from dependantModule in this.Modules
			where moduleInfo.DependsOn.Contains(dependantModule.ModuleName)
			select dependantModule;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00005A31 File Offset: 0x00003C31
		protected virtual void EnsureCatalogValidated()
		{
			if (!this.Validated)
			{
				this.Validate();
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00005A41 File Offset: 0x00003C41
		private void ItemsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this.Validated)
			{
				this.EnsureCatalogValidated();
			}
		}

		// Token: 0x0400005D RID: 93
		private readonly global::Microsoft.Practices.Prism.Modularity.ModuleCatalog.ModuleCatalogItemCollection items;

		// Token: 0x0400005E RID: 94
		private bool isLoaded;

		// Token: 0x0200003B RID: 59
		private class ModuleCatalogItemCollection : global::System.Collections.ObjectModel.Collection<global::Microsoft.Practices.Prism.Modularity.IModuleCatalogItem>, global::System.Collections.Specialized.INotifyCollectionChanged
		{
			// Token: 0x1400000D RID: 13
			// (add) Token: 0x0600016E RID: 366 RVA: 0x00005A54 File Offset: 0x00003C54
			// (remove) Token: 0x0600016F RID: 367 RVA: 0x00005A8C File Offset: 0x00003C8C
			public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

			// Token: 0x06000170 RID: 368 RVA: 0x00005AC1 File Offset: 0x00003CC1
			protected override void InsertItem(int index, global::Microsoft.Practices.Prism.Modularity.IModuleCatalogItem item)
			{
				base.InsertItem(index, item);
				this.OnNotifyCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, item, index));
			}

			// Token: 0x06000171 RID: 369 RVA: 0x00005AD9 File Offset: 0x00003CD9
			protected void OnNotifyCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs eventArgs)
			{
				if (this.CollectionChanged != null)
				{
					this.CollectionChanged(this, eventArgs);
				}
			}
		}
	}
}
