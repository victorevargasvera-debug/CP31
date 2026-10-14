using System;
using System.Globalization;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Properties;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000044 RID: 68
	public class ModuleInitializer : global::Microsoft.Practices.Prism.Modularity.IModuleInitializer
	{
		// Token: 0x060001BF RID: 447 RVA: 0x00006304 File Offset: 0x00004504
		public ModuleInitializer(global::Microsoft.Practices.ServiceLocation.IServiceLocator serviceLocator, global::Microsoft.Practices.Prism.Logging.ILoggerFacade loggerFacade)
		{
			if (serviceLocator == null)
			{
				throw new global::System.ArgumentNullException("serviceLocator");
			}
			if (loggerFacade == null)
			{
				throw new global::System.ArgumentNullException("loggerFacade");
			}
			this.serviceLocator = serviceLocator;
			this.loggerFacade = loggerFacade;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00006338 File Offset: 0x00004538
		public void Initialize(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			if (moduleInfo == null)
			{
				throw new global::System.ArgumentNullException("moduleInfo");
			}
			global::Microsoft.Practices.Prism.Modularity.IModule module = null;
			try
			{
				module = this.CreateModule(moduleInfo);
				module.Initialize();
			}
			catch (global::System.Exception exception)
			{
				this.HandleModuleInitializationError(moduleInfo, (module != null) ? module.GetType().Assembly.FullName : null, exception);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00006398 File Offset: 0x00004598
		public virtual void HandleModuleInitializationError(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo, string assemblyName, global::System.Exception exception)
		{
			if (moduleInfo == null)
			{
				throw new global::System.ArgumentNullException("moduleInfo");
			}
			if (exception == null)
			{
				throw new global::System.ArgumentNullException("exception");
			}
			global::System.Exception ex;
			if (exception is global::Microsoft.Practices.Prism.Modularity.ModuleInitializeException)
			{
				ex = exception;
			}
			else if (!string.IsNullOrEmpty(assemblyName))
			{
				ex = new global::Microsoft.Practices.Prism.Modularity.ModuleInitializeException(moduleInfo.ModuleName, assemblyName, exception.Message, exception);
			}
			else
			{
				ex = new global::Microsoft.Practices.Prism.Modularity.ModuleInitializeException(moduleInfo.ModuleName, exception.Message, exception);
			}
			this.loggerFacade.Log(ex.ToString(), global::Microsoft.Practices.Prism.Logging.Category.Exception, global::Microsoft.Practices.Prism.Logging.Priority.High);
			throw ex;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00006412 File Offset: 0x00004612
		protected virtual global::Microsoft.Practices.Prism.Modularity.IModule CreateModule(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			if (moduleInfo == null)
			{
				throw new global::System.ArgumentNullException("moduleInfo");
			}
			return this.CreateModule(moduleInfo.ModuleType);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00006430 File Offset: 0x00004630
		protected virtual global::Microsoft.Practices.Prism.Modularity.IModule CreateModule(string typeName)
		{
			global::System.Type type = global::System.Type.GetType(typeName);
			if (type == null)
			{
				throw new global::Microsoft.Practices.Prism.Modularity.ModuleInitializeException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.FailedToGetType, new object[]
				{
					typeName
				}));
			}
			return (global::Microsoft.Practices.Prism.Modularity.IModule)this.serviceLocator.GetInstance(type);
		}

		// Token: 0x0400006E RID: 110
		private readonly global::Microsoft.Practices.ServiceLocation.IServiceLocator serviceLocator;

		// Token: 0x0400006F RID: 111
		private readonly global::Microsoft.Practices.Prism.Logging.ILoggerFacade loggerFacade;
	}
}
