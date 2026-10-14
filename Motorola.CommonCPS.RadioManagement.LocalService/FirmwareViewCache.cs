using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200009C RID: 156
	public class FirmwareViewCache : global::Motorola.CommonCPS.RadioManagement.LocalService.PackageViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>
	{
		// Token: 0x060003F2 RID: 1010 RVA: 0x00059678 File Offset: 0x00057878
		public FirmwareViewCache() : base(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Firmware, null)
		{
		}
	}
}
