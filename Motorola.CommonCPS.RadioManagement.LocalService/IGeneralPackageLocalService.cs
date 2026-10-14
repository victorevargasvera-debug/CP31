using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200000A RID: 10
	public interface IGeneralPackageLocalService
	{
		// Token: 0x06000134 RID: 308
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage> GetGeneralPackages();

		// Token: 0x06000135 RID: 309
		global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage> ListGeneralPackages();
	}
}
