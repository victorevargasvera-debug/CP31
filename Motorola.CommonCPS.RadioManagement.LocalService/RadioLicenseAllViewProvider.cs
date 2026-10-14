using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000071 RID: 113
	public class RadioLicenseAllViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>
	{
		// Token: 0x06000370 RID: 880 RVA: 0x000528F4 File Offset: 0x00050AF4
		public RadioLicenseAllViewProvider(global::System.Guid? groupUuid, int featureTp = 0)
		{
			this.a = groupUuid;
			this.b = featureTp;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00052918 File Offset: 0x00050B18
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)1098448896;
			switch (num)
			{
			default:
			{
				num = (short)737345536;
				short num2 = num;
				global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
				stopwatch.Start();
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> radioFeatures = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioFeatures(this.a, startIndex, length, this.b);
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> enumerator = radioFeatures.GetEnumerator();
				try
				{
					num = (short)229113861;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							num = (short)166849546;
							short num4 = num;
							num = (short)1438182410;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_8E;
							default:
							{
								num = (short)31916032;
								if (num != 0)
								{
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase radioLicenseBase;
								if (radioLicenseBase != null)
								{
									num = (short)1002962945;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							break;
						}
						case 1:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase radioLicenseBase;
							list.Add(radioLicenseBase);
							num = (short)473694211;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)1562050566;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1464205314;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary summary = enumerator.Current;
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase radioLicenseBase = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioLicenseService.ConvertLicenseSummaryToLicense(summary);
							num = (short)128581632;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_8E;
						case 6:
							goto IL_1CE;
						}
						goto IL_BB;
						IL_8E:
						switch (0)
						{
						case 0:
							IL_BB:
							goto IL_156;
						}
						continue;
						IL_156:
						num = (short)653590532;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1CE:;
				}
				finally
				{
					num = (short)563281921;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)56557570;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1744437249;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_22D;
							}
							continue;
						case 2:
							goto IL_263;
						}
						IL_22D:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1111031808;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_263:;
				}
				stopwatch.Stop();
				milliseconds = (int)stopwatch.ElapsedMilliseconds;
				return list;
			}
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00052BB8 File Offset: 0x00050DB8
		public int GetTotalCount()
		{
			short num = (short)1160823187;
			short num2 = num;
			num = (short)1881850259;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2082471936;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1150812161;
			if (num != 0)
			{
			}
			num = (short)801701888;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioFeatureCount(this.a, 0);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00052C74 File Offset: 0x00050E74
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase item)
		{
			short num = (short)425234640;
			short num2 = num;
			num = (short)81367248;
			switch (num2 == num)
			{
			default:
			{
				num = (short)357433344;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)660799489;
			if (num != 0)
			{
			}
			num = (short)1501429760;
			if (num != 0)
			{
			}
			item.Validator = null;
		}

		// Token: 0x0400009C RID: 156
		private global::System.Guid? a;

		// Token: 0x0400009D RID: 157
		private int b;
	}
}
