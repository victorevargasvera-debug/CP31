using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000073 RID: 115
	public class RadioLicenseFeatureSubViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>
	{
		// Token: 0x06000377 RID: 887 RVA: 0x000531B4 File Offset: 0x000513B4
		public RadioLicenseFeatureSubViewProvider(global::System.Guid? groupID, int fid, int ftype = 0)
		{
			this.a = groupID;
			this.b = fid;
			this.c = ftype;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000531DC File Offset: 0x000513DC
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)1164359620;
			short num2 = num;
			num = (short)1474934724;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B7;
			case 1:
				break;
			default:
			{
				num = (short)99876864;
				short num3 = num;
				break;
			}
			}
			num = (short)129695745;
			if (num != 0)
			{
			}
			num = (short)1659961344;
			if (num != 0)
			{
			}
			num = (short)1804337152;
			switch (num)
			{
			default:
			{
				IL_B7:
				global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
				stopwatch.Start();
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> radioFeatureDetailsByFeature = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioFeatureDetailsByFeature(this.a, startIndex, length, this.b, this.c);
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary>.Enumerator enumerator = radioFeatureDetailsByFeature.GetEnumerator())
				{
					num = (short)1296039940;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase radioLicenseBase;
							if (radioLicenseBase != null)
							{
								num = (short)289210370;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_1F8;
						case 2:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase radioLicenseBase;
							list.Add(radioLicenseBase);
							num = (short)288620550;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)727187457;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_134;
							}
							continue;
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)871890947;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary summary = enumerator.Current;
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase radioLicenseBase = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioLicenseService.ConvertLicenseSummaryToLicense(summary);
							num = (short)1007878144;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_181:
						num = (short)1390673925;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_134:
						goto IL_181;
					}
					IL_1F8:;
				}
				stopwatch.Stop();
				milliseconds = (int)stopwatch.ElapsedMilliseconds;
				return list;
			}
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00053420 File Offset: 0x00051620
		public int GetTotalCount()
		{
			short num = (short)906362881;
			if (num != 0)
			{
			}
			num = (short)1687027712;
			short num2 = num;
			num = (short)252040861;
			short num3 = num;
			num = (short)1738266269;
			switch (num3 == num)
			{
			}
			num = (short)801505280;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioFeatureDetailsByFeatureCount(this.a, this.b, this.c);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000534EC File Offset: 0x000516EC
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase item)
		{
			short num = (short)1097001619;
			short num2 = num;
			num = (short)1063709331;
			switch (num2 == num)
			{
			default:
			{
				num = (short)625475584;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1120862209;
			if (num != 0)
			{
			}
			num = (short)1005780992;
			if (num != 0)
			{
			}
			item.Validator = null;
		}

		// Token: 0x040000A0 RID: 160
		private global::System.Guid? a;

		// Token: 0x040000A1 RID: 161
		private int b;

		// Token: 0x040000A2 RID: 162
		private int c;
	}
}
