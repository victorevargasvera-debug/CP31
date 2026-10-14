using System;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000015 RID: 21
	public interface IASTROFirmwarePackageService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IPackageManagementService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x060000C8 RID: 200
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.EntityModel.Package> LoadAvailablePackages(string model, string maxVer, bool isFreon, bool isEqual = true, string codeplugVersion = null);
	}
}
