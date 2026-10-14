using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000038 RID: 56
	public class ModuleManager : global::Microsoft.Practices.Prism.Modularity.IModuleManager, global::System.IDisposable
	{
		// Token: 0x06000124 RID: 292 RVA: 0x000049F0 File Offset: 0x00002BF0
		public ModuleManager(global::Microsoft.Practices.Prism.Modularity.IModuleInitializer moduleInitializer, global::Microsoft.Practices.Prism.Modularity.IModuleCatalog moduleCatalog, global::Microsoft.Practices.Prism.Logging.ILoggerFacade loggerFacade)
		{
			if (moduleInitializer == null)
			{
				throw new global::System.ArgumentNullException("moduleInitializer");
			}
			if (moduleCatalog == null)
			{
				throw new global::System.ArgumentNullException("moduleCatalog");
			}
			if (loggerFacade == null)
			{
				throw new global::System.ArgumentNullException("loggerFacade");
			}
			this.moduleInitializer = moduleInitializer;
			this.moduleCatalog = moduleCatalog;
			this.loggerFacade = loggerFacade;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00004A4D File Offset: 0x00002C4D
		protected global::Microsoft.Practices.Prism.Modularity.IModuleCatalog ModuleCatalog
		{
			get
			{
				return this.moduleCatalog;
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000126 RID: 294 RVA: 0x00004A58 File Offset: 0x00002C58
		// (remove) Token: 0x06000127 RID: 295 RVA: 0x00004A90 File Offset: 0x00002C90
		public event global::System.EventHandler<global::Microsoft.Practices.Prism.Modularity.ModuleDownloadProgressChangedEventArgs> ModuleDownloadProgressChanged;

		// Token: 0x06000128 RID: 296 RVA: 0x00004AC5 File Offset: 0x00002CC5
		private void RaiseModuleDownloadProgressChanged(global::Microsoft.Practices.Prism.Modularity.ModuleDownloadProgressChangedEventArgs e)
		{
			if (this.ModuleDownloadProgressChanged != null)
			{
				this.ModuleDownloadProgressChanged(this, e);
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000129 RID: 297 RVA: 0x00004ADC File Offset: 0x00002CDC
		// (remove) Token: 0x0600012A RID: 298 RVA: 0x00004B14 File Offset: 0x00002D14
		public event global::System.EventHandler<global::Microsoft.Practices.Prism.Modularity.LoadModuleCompletedEventArgs> LoadModuleCompleted;

		// Token: 0x0600012B RID: 299 RVA: 0x00004B49 File Offset: 0x00002D49
		private void RaiseLoadModuleCompleted(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo, global::System.Exception error)
		{
			this.RaiseLoadModuleCompleted(new global::Microsoft.Practices.Prism.Modularity.LoadModuleCompletedEventArgs(moduleInfo, error));
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00004B58 File Offset: 0x00002D58
		private void RaiseLoadModuleCompleted(global::Microsoft.Practices.Prism.Modularity.LoadModuleCompletedEventArgs e)
		{
			if (this.LoadModuleCompleted != null)
			{
				this.LoadModuleCompleted(this, e);
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00004B6F File Offset: 0x00002D6F
		public void Run()
		{
			this.moduleCatalog.Initialize();
			this.LoadModulesWhenAvailable();
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00004BA0 File Offset: 0x00002DA0
		public void LoadModule(string moduleName)
		{
			global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> enumerable = from m in this.moduleCatalog.Modules
			where m.ModuleName == moduleName
			select m;
			if (enumerable == null || enumerable.Count<global::Microsoft.Practices.Prism.Modularity.ModuleInfo>() != 1)
			{
				throw new global::Microsoft.Practices.Prism.Modularity.ModuleNotFoundException(moduleName, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.ModuleNotFound, new object[]
				{
					moduleName
				}));
			}
			global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> moduleInfos = this.moduleCatalog.CompleteListWithDependencies(enumerable);
			this.LoadModuleTypes(moduleInfos);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00004C24 File Offset: 0x00002E24
		protected virtual bool ModuleNeedsRetrieval(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			if (moduleInfo == null)
			{
				throw new global::System.ArgumentNullException("moduleInfo");
			}
			if (moduleInfo.State == global::Microsoft.Practices.Prism.Modularity.ModuleState.NotStarted)
			{
				bool flag = global::System.Type.GetType(moduleInfo.ModuleType) != null;
				if (flag)
				{
					moduleInfo.State = global::Microsoft.Practices.Prism.Modularity.ModuleState.ReadyForInitialization;
				}
				return !flag;
			}
			return false;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004C74 File Offset: 0x00002E74
		private void LoadModulesWhenAvailable()
		{
			global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> modules = from m in this.moduleCatalog.Modules
			where m.InitializationMode == global::Microsoft.Practices.Prism.Modularity.InitializationMode.WhenAvailable
			select m;
			global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> enumerable = this.moduleCatalog.CompleteListWithDependencies(modules);
			if (enumerable != null)
			{
				this.LoadModuleTypes(enumerable);
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004CC8 File Offset: 0x00002EC8
		private void LoadModuleTypes(global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> moduleInfos)
		{
			if (moduleInfos == null)
			{
				return;
			}
			foreach (global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo in moduleInfos)
			{
				if (moduleInfo.State == global::Microsoft.Practices.Prism.Modularity.ModuleState.NotStarted)
				{
					if (this.ModuleNeedsRetrieval(moduleInfo))
					{
						this.BeginRetrievingModule(moduleInfo);
					}
					else
					{
						moduleInfo.State = global::Microsoft.Practices.Prism.Modularity.ModuleState.ReadyForInitialization;
					}
				}
			}
			this.LoadModulesThatAreReadyForLoad();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004D40 File Offset: 0x00002F40
		protected void LoadModulesThatAreReadyForLoad()
		{
			bool flag = true;
			while (flag)
			{
				flag = false;
				global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> enumerable = from m in this.moduleCatalog.Modules
				where m.State == global::Microsoft.Practices.Prism.Modularity.ModuleState.ReadyForInitialization
				select m;
				foreach (global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo in enumerable)
				{
					if (moduleInfo.State != global::Microsoft.Practices.Prism.Modularity.ModuleState.Initialized && this.AreDependenciesLoaded(moduleInfo))
					{
						moduleInfo.State = global::Microsoft.Practices.Prism.Modularity.ModuleState.Initializing;
						this.InitializeModule(moduleInfo);
						flag = true;
						break;
					}
				}
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004DDC File Offset: 0x00002FDC
		private void BeginRetrievingModule(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			global::Microsoft.Practices.Prism.Modularity.IModuleTypeLoader typeLoaderForModule = this.GetTypeLoaderForModule(moduleInfo);
			moduleInfo.State = global::Microsoft.Practices.Prism.Modularity.ModuleState.LoadingTypes;
			if (!this.subscribedToModuleTypeLoaders.Contains(typeLoaderForModule))
			{
				typeLoaderForModule.ModuleDownloadProgressChanged += this.IModuleTypeLoader_ModuleDownloadProgressChanged;
				typeLoaderForModule.LoadModuleCompleted += this.IModuleTypeLoader_LoadModuleCompleted;
				this.subscribedToModuleTypeLoaders.Add(typeLoaderForModule);
			}
			typeLoaderForModule.LoadModuleType(moduleInfo);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00004E40 File Offset: 0x00003040
		private void IModuleTypeLoader_ModuleDownloadProgressChanged(object sender, global::Microsoft.Practices.Prism.Modularity.ModuleDownloadProgressChangedEventArgs e)
		{
			this.RaiseModuleDownloadProgressChanged(e);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00004E4C File Offset: 0x0000304C
		private void IModuleTypeLoader_LoadModuleCompleted(object sender, global::Microsoft.Practices.Prism.Modularity.LoadModuleCompletedEventArgs e)
		{
			if (e.Error == null)
			{
				if (e.ModuleInfo.State != global::Microsoft.Practices.Prism.Modularity.ModuleState.Initializing && e.ModuleInfo.State != global::Microsoft.Practices.Prism.Modularity.ModuleState.Initialized)
				{
					e.ModuleInfo.State = global::Microsoft.Practices.Prism.Modularity.ModuleState.ReadyForInitialization;
				}
				this.LoadModulesThatAreReadyForLoad();
				return;
			}
			this.RaiseLoadModuleCompleted(e);
			if (!e.IsErrorHandled)
			{
				this.HandleModuleTypeLoadingError(e.ModuleInfo, e.Error);
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00004EB4 File Offset: 0x000030B4
		protected virtual void HandleModuleTypeLoadingError(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo, global::System.Exception exception)
		{
			if (moduleInfo == null)
			{
				throw new global::System.ArgumentNullException("moduleInfo");
			}
			global::Microsoft.Practices.Prism.Modularity.ModuleTypeLoadingException ex = exception as global::Microsoft.Practices.Prism.Modularity.ModuleTypeLoadingException;
			if (ex == null)
			{
				ex = new global::Microsoft.Practices.Prism.Modularity.ModuleTypeLoadingException(moduleInfo.ModuleName, exception.Message, exception);
			}
			this.loggerFacade.Log(ex.Message, global::Microsoft.Practices.Prism.Logging.Category.Exception, global::Microsoft.Practices.Prism.Logging.Priority.High);
			throw ex;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004F10 File Offset: 0x00003110
		private bool AreDependenciesLoaded(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> dependentModules = this.moduleCatalog.GetDependentModules(moduleInfo);
			if (dependentModules == null)
			{
				return true;
			}
			int num = dependentModules.Count((global::Microsoft.Practices.Prism.Modularity.ModuleInfo requiredModule) => requiredModule.State != global::Microsoft.Practices.Prism.Modularity.ModuleState.Initialized);
			return num == 0;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00004F58 File Offset: 0x00003158
		private global::Microsoft.Practices.Prism.Modularity.IModuleTypeLoader GetTypeLoaderForModule(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			foreach (global::Microsoft.Practices.Prism.Modularity.IModuleTypeLoader moduleTypeLoader in this.ModuleTypeLoaders)
			{
				if (moduleTypeLoader.CanLoadModuleType(moduleInfo))
				{
					return moduleTypeLoader;
				}
			}
			throw new global::Microsoft.Practices.Prism.Modularity.ModuleTypeLoaderNotFoundException(moduleInfo.ModuleName, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.NoRetrieverCanRetrieveModule, new object[]
			{
				moduleInfo.ModuleName
			}), null);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00004FDC File Offset: 0x000031DC
		private void InitializeModule(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			if (moduleInfo.State == global::Microsoft.Practices.Prism.Modularity.ModuleState.Initializing)
			{
				this.moduleInitializer.Initialize(moduleInfo);
				moduleInfo.State = global::Microsoft.Practices.Prism.Modularity.ModuleState.Initialized;
				this.RaiseLoadModuleCompleted(moduleInfo, null);
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00005002 File Offset: 0x00003202
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005014 File Offset: 0x00003214
		protected virtual void Dispose(bool disposing)
		{
			foreach (global::Microsoft.Practices.Prism.Modularity.IModuleTypeLoader moduleTypeLoader in this.ModuleTypeLoaders)
			{
				global::System.IDisposable disposable = moduleTypeLoader as global::System.IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000506C File Offset: 0x0000326C
		// (set) Token: 0x0600013D RID: 317 RVA: 0x0000509F File Offset: 0x0000329F
		public virtual global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.IModuleTypeLoader> ModuleTypeLoaders
		{
			get
			{
				if (this.typeLoaders == null)
				{
					this.typeLoaders = new global::System.Collections.Generic.List<global::Microsoft.Practices.Prism.Modularity.IModuleTypeLoader>
					{
						new global::Microsoft.Practices.Prism.Modularity.FileModuleTypeLoader()
					};
				}
				return this.typeLoaders;
			}
			set
			{
				this.typeLoaders = value;
			}
		}

		// Token: 0x04000051 RID: 81
		private readonly global::Microsoft.Practices.Prism.Modularity.IModuleInitializer moduleInitializer;

		// Token: 0x04000052 RID: 82
		private readonly global::Microsoft.Practices.Prism.Modularity.IModuleCatalog moduleCatalog;

		// Token: 0x04000053 RID: 83
		private readonly global::Microsoft.Practices.Prism.Logging.ILoggerFacade loggerFacade;

		// Token: 0x04000054 RID: 84
		private global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.IModuleTypeLoader> typeLoaders;

		// Token: 0x04000055 RID: 85
		private global::System.Collections.Generic.HashSet<global::Microsoft.Practices.Prism.Modularity.IModuleTypeLoader> subscribedToModuleTypeLoaders = new global::System.Collections.Generic.HashSet<global::Microsoft.Practices.Prism.Modularity.IModuleTypeLoader>();
	}
}
