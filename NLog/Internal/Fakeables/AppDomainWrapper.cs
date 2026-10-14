using System;
using System.Collections.Generic;
using System.Reflection;
using NLog.Common;

namespace NLog.Internal.Fakeables
{
	// Token: 0x02000147 RID: 327
	public class AppDomainWrapper : global::NLog.Internal.Fakeables.IAppDomain
	{
		// Token: 0x06000EA3 RID: 3747 RVA: 0x00025830 File Offset: 0x00023A30
		public AppDomainWrapper(global::System.AppDomain appDomain)
		{
			this._currentAppDomain = appDomain;
			try
			{
				this.BaseDirectory = global::NLog.Internal.Fakeables.AppDomainWrapper.LookupBaseDirectory(appDomain);
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "AppDomain.BaseDirectory Failed");
				this.BaseDirectory = string.Empty;
			}
			try
			{
				this.ConfigurationFile = global::NLog.Internal.Fakeables.AppDomainWrapper.LookupConfigurationFile(appDomain);
			}
			catch (global::System.Exception ex2)
			{
				global::NLog.Common.InternalLogger.Warn(ex2, "AppDomain.SetupInformation.ConfigurationFile Failed");
				this.ConfigurationFile = string.Empty;
			}
			try
			{
				this.PrivateBinPath = global::NLog.Internal.Fakeables.AppDomainWrapper.LookupPrivateBinPath(appDomain);
			}
			catch (global::System.Exception ex3)
			{
				global::NLog.Common.InternalLogger.Warn(ex3, "AppDomain.SetupInformation.PrivateBinPath Failed");
				this.PrivateBinPath = global::NLog.Internal.ArrayHelper.Empty<string>();
			}
			this.FriendlyName = appDomain.FriendlyName;
			this.Id = appDomain.Id;
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x000258FC File Offset: 0x00023AFC
		private static string LookupBaseDirectory(global::System.AppDomain appDomain)
		{
			return appDomain.BaseDirectory;
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00025904 File Offset: 0x00023B04
		private static string LookupConfigurationFile(global::System.AppDomain appDomain)
		{
			return appDomain.SetupInformation.ConfigurationFile;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00025914 File Offset: 0x00023B14
		private static string[] LookupPrivateBinPath(global::System.AppDomain appDomain)
		{
			string privateBinPath = appDomain.SetupInformation.PrivateBinPath;
			if (!string.IsNullOrEmpty(privateBinPath))
			{
				return privateBinPath.Split(new char[]
				{
					';'
				}, global::System.StringSplitOptions.RemoveEmptyEntries);
			}
			return global::NLog.Internal.ArrayHelper.Empty<string>();
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x0002594D File Offset: 0x00023B4D
		public static global::NLog.Internal.Fakeables.AppDomainWrapper CurrentDomain
		{
			get
			{
				return new global::NLog.Internal.Fakeables.AppDomainWrapper(global::System.AppDomain.CurrentDomain);
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x00025959 File Offset: 0x00023B59
		// (set) Token: 0x06000EA9 RID: 3753 RVA: 0x00025961 File Offset: 0x00023B61
		public string BaseDirectory { get; private set; }

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0002596A File Offset: 0x00023B6A
		// (set) Token: 0x06000EAB RID: 3755 RVA: 0x00025972 File Offset: 0x00023B72
		public string ConfigurationFile { get; private set; }

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0002597B File Offset: 0x00023B7B
		// (set) Token: 0x06000EAD RID: 3757 RVA: 0x00025983 File Offset: 0x00023B83
		public global::System.Collections.Generic.IEnumerable<string> PrivateBinPath { get; private set; }

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x0002598C File Offset: 0x00023B8C
		// (set) Token: 0x06000EAF RID: 3759 RVA: 0x00025994 File Offset: 0x00023B94
		public string FriendlyName { get; private set; }

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x0002599D File Offset: 0x00023B9D
		// (set) Token: 0x06000EB1 RID: 3761 RVA: 0x000259A5 File Offset: 0x00023BA5
		public int Id { get; private set; }

		// Token: 0x06000EB2 RID: 3762 RVA: 0x000259AE File Offset: 0x00023BAE
		public global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> GetAssemblies()
		{
			if (this._currentAppDomain != null)
			{
				return this._currentAppDomain.GetAssemblies();
			}
			return global::NLog.Internal.ArrayHelper.Empty<global::System.Reflection.Assembly>();
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000EB3 RID: 3763 RVA: 0x000259C9 File Offset: 0x00023BC9
		// (remove) Token: 0x06000EB4 RID: 3764 RVA: 0x000259F9 File Offset: 0x00023BF9
		public event global::System.EventHandler<global::System.EventArgs> ProcessExit
		{
			add
			{
				if (this.processExitEvent == null && this._currentAppDomain != null)
				{
					this._currentAppDomain.ProcessExit += this.OnProcessExit;
				}
				this.processExitEvent += value;
			}
			remove
			{
				this.processExitEvent -= value;
				if (this.processExitEvent == null && this._currentAppDomain != null)
				{
					this._currentAppDomain.ProcessExit -= this.OnProcessExit;
				}
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000EB5 RID: 3765 RVA: 0x00025A2C File Offset: 0x00023C2C
		// (remove) Token: 0x06000EB6 RID: 3766 RVA: 0x00025A64 File Offset: 0x00023C64
		private event global::System.EventHandler<global::System.EventArgs> processExitEvent;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000EB7 RID: 3767 RVA: 0x00025A99 File Offset: 0x00023C99
		// (remove) Token: 0x06000EB8 RID: 3768 RVA: 0x00025AC9 File Offset: 0x00023CC9
		public event global::System.EventHandler<global::System.EventArgs> DomainUnload
		{
			add
			{
				if (this.domainUnloadEvent == null && this._currentAppDomain != null)
				{
					this._currentAppDomain.DomainUnload += this.OnDomainUnload;
				}
				this.domainUnloadEvent += value;
			}
			remove
			{
				this.domainUnloadEvent -= value;
				if (this.domainUnloadEvent == null && this._currentAppDomain != null)
				{
					this._currentAppDomain.DomainUnload -= this.OnDomainUnload;
				}
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000EB9 RID: 3769 RVA: 0x00025AFC File Offset: 0x00023CFC
		// (remove) Token: 0x06000EBA RID: 3770 RVA: 0x00025B34 File Offset: 0x00023D34
		private event global::System.EventHandler<global::System.EventArgs> domainUnloadEvent;

		// Token: 0x06000EBB RID: 3771 RVA: 0x00025B6C File Offset: 0x00023D6C
		private void OnDomainUnload(object sender, global::System.EventArgs e)
		{
			global::System.EventHandler<global::System.EventArgs> eventHandler = this.domainUnloadEvent;
			if (eventHandler != null)
			{
				eventHandler(sender, e);
			}
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00025B8C File Offset: 0x00023D8C
		private void OnProcessExit(object sender, global::System.EventArgs eventArgs)
		{
			global::System.EventHandler<global::System.EventArgs> eventHandler = this.processExitEvent;
			if (eventHandler != null)
			{
				eventHandler(sender, eventArgs);
			}
		}

		// Token: 0x0400040C RID: 1036
		private readonly global::System.AppDomain _currentAppDomain;
	}
}
