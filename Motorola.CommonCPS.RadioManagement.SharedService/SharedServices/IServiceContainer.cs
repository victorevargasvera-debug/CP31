using System;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000012 RID: 18
	public interface IServiceContainer
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000098 RID: 152
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IDataProviderService DataProviderService { get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000099 RID: 153
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IGroupService GroupService { get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600009A RID: 154
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IDBMigrationService DbMigrationService { get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009B RID: 155
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IPackageManagementService PackageManagementService { get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009C RID: 156
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceService RadioService { get; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009D RID: 157
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioDetailService RadioDetailService { get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009E RID: 158
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService TemplateService { get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009F RID: 159
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase ValidationService { get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A0 RID: 160
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRODataProfileService AstroDataProfileService { get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A1 RID: 161
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROSystemService AstroSystemService { get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A2 RID: 162
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROOTARProfileService AstroOTARProfileService { get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A3 RID: 163
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioLicenseService RadioLicenseService { get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A4 RID: 164
		global::Motorola.CommonCPS.RadioManagement.SharedServices.ILicenseService AppLicenseService { get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000A5 RID: 165
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IManageRadioLicenseService ManageRadioLicenseService { get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000A6 RID: 166
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceOperation DeviceOperation { get; }

		// Token: 0x060000A7 RID: 167
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IPackageManagementService GetPackageManagementService(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None);
	}
}
