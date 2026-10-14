using System;
using System.Collections.ObjectModel;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.RMServerContract.DataQueryObjects;

namespace Motorola.CommonCPS.RadioManagement.Services.Package
{
	// Token: 0x02000009 RID: 9
	internal class AstroAmpFirmwarePackageService : global::Motorola.CommonCPS.RadioManagement.SharedServices.PackageManagementServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IAstroAmpFirmwarePackageService
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00003754 File Offset: 0x00001954
		public AstroAmpFirmwarePackageService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioFeatureOperation radioFeatureOperation) : base(serverAccessor)
		{
			this.a = radioFeatureOperation;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003770 File Offset: 0x00001970
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.EntityModel.Package> LoadAvailablePackages(string firmwareVersion, string targetModel, string bpSoftwareVersion, bool multipleFirmwareVersionsSelected, string maxSupportedCodeplugVersion, bool includeEqualPackageVersion)
		{
			short num = (short)1434517504;
			short num2 = num;
			num = (short)1037264382;
			short num3 = num;
			num = (short)2140628478;
			switch (num3 == num)
			{
			}
			num = (short)1673265153;
			if (num != 0)
			{
			}
			num = (short)648478720;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.RMServerContract.DataQueryObjects.AstroAmpFirmwareQuery query = new global::Motorola.CommonCPS.Server.RMServerContract.DataQueryObjects.AstroAmpFirmwareQuery
			{
				ExcludeDifferentialPackages = multipleFirmwareVersionsSelected,
				TargetModel = targetModel,
				PackageVersion = firmwareVersion,
				IncludeEqualPackageVersion = includeEqualPackageVersion,
				BPSoftwareVersion = bpSoftwareVersion
			};
			return new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.EntityModel.Package>(base.ServerAccessor.GetAstroAmpFirmwares(query).Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware x)
			{
				int a_ = 19;
				short num4 = (short)1271857152;
				short num5 = num4;
				num4 = (short)1258356737;
				if (num4 != 0)
				{
				}
				num4 = (short)59985487;
				short num6 = num4;
				num4 = (short)1382043215;
				switch (num6 == num4)
				{
				}
				num4 = (short)1862991872;
				if (num4 != 0)
				{
				}
				return this.a.CheckAstroUpgradeFWIsSupported(x.MaxCodeplugVersion ?? global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("鲫麭麯花蒳颵袷誹費", a_), maxSupportedCodeplugVersion);
			}).ToList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware>());
		}

		// Token: 0x04000011 RID: 17
		private readonly global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioFeatureOperation a;
	}
}
