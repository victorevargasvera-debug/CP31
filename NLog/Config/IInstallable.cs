using System;

namespace NLog.Config
{
	// Token: 0x02000162 RID: 354
	public interface IInstallable
	{
		// Token: 0x06000F6D RID: 3949
		void Install(global::NLog.Config.InstallationContext installationContext);

		// Token: 0x06000F6E RID: 3950
		void Uninstall(global::NLog.Config.InstallationContext installationContext);

		// Token: 0x06000F6F RID: 3951
		bool? IsInstalled(global::NLog.Config.InstallationContext installationContext);
	}
}
