using System;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200000B RID: 11
	public interface IAstroAmpFirmwarePackageService
	{
		// Token: 0x06000034 RID: 52
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.EntityModel.Package> LoadAvailablePackages(string firmwareVersion, string targetModel, string bpSoftwareVersion, bool multipleFirmwareVersionsSelected, string maxSupportedCodeplugVersion, bool includeEqualPackageVersion);
	}
}
