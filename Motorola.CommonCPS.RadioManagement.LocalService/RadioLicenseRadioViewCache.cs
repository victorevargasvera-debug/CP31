using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000079 RID: 121
	public class RadioLicenseRadioViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase>
	{
		// Token: 0x0600038B RID: 907 RVA: 0x00054468 File Offset: 0x00052668
		public RadioLicenseRadioViewCache(global::System.Guid? groupUuid, int featureType = 0) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioLicenseRadioViewCache.RadioLicenseRadioViewProvider(groupUuid, featureType), null, 500)
		{
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00054488 File Offset: 0x00052688
		public RadioLicenseRadioViewCache(global::System.Guid? groupUuid, int featureType, global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase> provider) : base(provider, null, 500)
		{
		}

		// Token: 0x0200007A RID: 122
		public class RadioLicenseRadioViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase>
		{
			// Token: 0x0600038D RID: 909 RVA: 0x000544A4 File Offset: 0x000526A4
			public RadioLicenseRadioViewProvider(global::System.Guid? groupUuid, int ftype)
			{
				this.a = groupUuid;
				this.b = ftype;
			}

			// Token: 0x0600038E RID: 910 RVA: 0x000544C8 File Offset: 0x000526C8
			public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase> FetchRange(int startIndex, int length, out int milliseconds)
			{
				short num = (short)1126333322;
				short num2 = num;
				num = (short)836926346;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B8;
				case 1:
					break;
				default:
				{
					num = (short)1419116544;
					short num3 = num;
					break;
				}
				}
				num = (short)1496186880;
				if (num != 0)
				{
				}
				num = (short)962723841;
				if (num != 0)
				{
				}
				num = (short)1483538432;
				switch (num)
				{
				default:
				{
					IL_B8:
					global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
					stopwatch.Start();
					global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> enumerable = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListRadioFeatureSummaryByRadio(this.a, startIndex, length, this.b);
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase>();
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> enumerator = enumerable.GetEnumerator();
					try
					{
						num = (short)1640169476;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase radioLicenseRadioViewBase;
								if (radioLicenseRadioViewBase != null)
								{
									num = (short)1014562818;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_1F5;
							case 2:
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase radioLicenseRadioViewBase;
								list.Add(radioLicenseRadioViewBase);
								num = (short)491716614;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								num = (short)225837057;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_130;
								}
								continue;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1463156739;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary summary = enumerator.Current;
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase radioLicenseRadioViewBase = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioLicenseService.ConvertLicenseSummaryToLicenseRadioViewBase(summary);
								num = (short)1571880960;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_17C:
							num = (short)1615462405;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_130:
							goto IL_17C;
						}
						IL_1F5:;
					}
					finally
					{
						num = (short)786432000;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_22A;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1324810242;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_261;
							}
							IL_22A:
							if (enumerator == null)
							{
								break;
							}
							num = (short)723976193;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_261:;
					}
					stopwatch.Stop();
					milliseconds = (int)stopwatch.ElapsedMilliseconds;
					return list;
				}
				}
			}

			// Token: 0x0600038F RID: 911 RVA: 0x00054768 File Offset: 0x00052968
			public int GetTotalCount()
			{
				short num = (short)1948573962;
				short num2 = num;
				num = (short)541319434;
				switch (num2 == num)
				{
				}
				num = (short)249233408;
				if (num != 0)
				{
				}
				num = (short)1400307712;
				short num3 = num;
				num = (short)239468545;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioFeatureSummaryByRadioCount(this.a, this.b);
			}

			// Token: 0x06000390 RID: 912 RVA: 0x00054828 File Offset: 0x00052A28
			public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase item)
			{
				short num = (short)346095617;
				if (num != 0)
				{
				}
				num = (short)530412410;
				short num2 = num;
				num = (short)994734970;
				switch (num2 == num)
				{
				}
				num = (short)771227648;
				short num3 = num;
				num = (short)1902772224;
				if (num != 0)
				{
				}
				item.Validator = null;
			}

			// Token: 0x040000AB RID: 171
			private global::System.Guid? a;

			// Token: 0x040000AC RID: 172
			private int b;
		}
	}
}
