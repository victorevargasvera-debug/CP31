using System;
using System.Collections.Generic;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200002A RID: 42
	internal class ASTROLicenseService : global::Motorola.CommonCPS.RadioManagement.SharedServices.LicenseService
	{
		// Token: 0x06000520 RID: 1312 RVA: 0x00031EDC File Offset: 0x000300DC
		public ASTROLicenseService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor) : base(serverAccessor)
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00031EF0 File Offset: 0x000300F0
		public override global::System.Collections.Generic.KeyValuePair<string, string> GetRadioMgmtFeatureName(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region)
		{
			int a_ = 10;
			short num = (short)230296035;
			short num2 = num;
			num = (short)353634787;
			switch (num2 == num)
			{
			}
			num = (short)286392321;
			if (num != 0)
			{
			}
			num = (short)1770913792;
			if (num != 0)
			{
			}
			num = (short)28835840;
			short num3 = num;
			string key = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﶬﲮﲸ諭鏀鳂韄諆", a_);
			string @string = global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﮨﶪﶮ", a_));
			return new global::System.Collections.Generic.KeyValuePair<string, string>(key, @string);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00031FCC File Offset: 0x000301CC
		protected override bool IsValidProduct(string productName)
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					result = true;
					num2 = (short)391315456;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (productName.Equals(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﾫ節ﶱ鎿蟁雃郅跇飉鏋鳍鷏", a_)))
					{
						num2 = (short)2078554410;
						short num3 = num2;
						num2 = (short)454768938;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						case 1:
							break;
						default:
						{
							num2 = (short)1046151168;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)1296302080;
						if (num2 != 0)
						{
						}
						num2 = (short)1184628737;
						if (num2 != 0)
						{
						}
						num2 = (short)215941121;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_25;
			}
			return result;
			IL_25:
			result = false;
			num2 = (short)1189806082;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
