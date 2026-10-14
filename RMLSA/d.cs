using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter
{
	// Token: 0x02000006 RID: 6
	internal abstract class d : global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.c
	{
		// Token: 0x0600001A RID: 26 RVA: 0x0000313C File Offset: 0x0000133C
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> a(global::Motorola.CommonCPS.Server.EntityModel.EntitlementList A_0, string A_1)
		{
			short num = (short)1234239489;
			if (num != 0)
			{
			}
			num = (short)1374627312;
			short num2 = num;
			num = (short)2039555568;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B8;
			case 1:
				break;
			default:
			{
				num = (short)2131099648;
				short num3 = num;
				break;
			}
			}
			num = (short)701825024;
			if (num != 0)
			{
			}
			num = (short)905969664;
			switch (num)
			{
			default:
			{
				IL_B8:
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem>.Enumerator enumerator = A_0.entitlementItems.GetEnumerator())
				{
					num = (short)828964865;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
							switch (0)
							{
							case 0:
								goto IL_107;
							}
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)503119875;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem a_ = enumerator.Current;
							global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense license = this.b(a_);
							global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense radioEntitledLicense = this.a(a_, A_1);
							radioEntitledLicense.License = license;
							list.Add(radioEntitledLicense);
							num = (short)1170538496;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)2030370820;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_1A0;
						}
						IL_14B:
						num = (short)1938489346;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_107:
						goto IL_14B;
					}
					IL_1A0:;
				}
				return list;
			}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000330C File Offset: 0x0000150C
		public virtual global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense c(global::Motorola.CommonCPS.Server.EntityModel.FeatureList A_0, global::Motorola.CommonCPS.Server.EntityModel.FeatureItem A_1)
		{
			short num = (short)213254145;
			if (num != 0)
			{
			}
			num = (short)563478528;
			short num2 = num;
			num = (short)1429813855;
			short num3 = num;
			num = (short)97401439;
			switch (num3 == num)
			{
			}
			num = (short)1931345920;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem a_ = this.a(A_0, A_1);
			return this.b(a_);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000033C8 File Offset: 0x000015C8
		private global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem a(global::Motorola.CommonCPS.Server.EntityModel.FeatureList A_0, global::Motorola.CommonCPS.Server.EntityModel.FeatureItem A_1)
		{
			short num = (short)55145859;
			short num2 = num;
			num = (short)1739224451;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2046033920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1750007808;
			if (num != 0)
			{
			}
			num = (short)2119303169;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem(null, null, A_1.isPermanent, A_1.featureName, A_1.featureVersion, 0, 0, A_0.modelNumber, A_0.currentFlashCode, A_0.newFlashCode, false, A_1.notice);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000034A4 File Offset: 0x000016A4
		private global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense a(global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem A_0, string A_1)
		{
			short num = (short)1212809217;
			if (num != 0)
			{
			}
			num = (short)149422080;
			short num2 = num;
			num = (short)1925874188;
			short num3 = num;
			num = (short)746291724;
			switch (num3 == num)
			{
			}
			num = (short)2016411648;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense
			{
				EID = A_1,
				TotalLicenseCount = A_0.totalCount,
				AvailableLicenseCount = A_0.availableCount
			};
		}

		// Token: 0x0600001E RID: 30
		protected abstract global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense b(global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem A_0);
	}
}
