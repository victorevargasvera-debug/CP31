using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000023 RID: 35
	public abstract class GeneralPackageLoaclService : global::Motorola.CommonCPS.RadioManagement.LocalService.IGeneralPackageLocalService
	{
		// Token: 0x06000185 RID: 389 RVA: 0x0001A4F4 File Offset: 0x000186F4
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage> GetGeneralPackages()
		{
			short num = (short)575804409;
			short num2 = num;
			num = (short)404034553;
			switch (num2 == num)
			{
			}
			num = (short)211746816;
			short num3 = num;
			num = (short)508362752;
			if (num != 0)
			{
			}
			num = (short)417792001;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.GeneralPackageViewCache();
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0001A5A4 File Offset: 0x000187A4
		public virtual global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage> ListGeneralPackages()
		{
			short num = (short)740592367;
			short num2 = num;
			num = (short)671124207;
			switch (num2 == num)
			{
			}
			num = (short)468582400;
			short num3 = num;
			num = (short)546897920;
			if (num != 0)
			{
			}
			num = (short)24444929;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.ListGeneralPackages(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.GeneralPackage, null).ToGeneralUIPakcage<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary>();
		}
	}
}
