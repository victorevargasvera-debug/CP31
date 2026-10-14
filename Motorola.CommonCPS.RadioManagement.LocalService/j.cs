using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000090 RID: 144
	internal class j : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x060003CF RID: 975 RVA: 0x00057A78 File Offset: 0x00055C78
		public j(global::System.Guid A_0) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.j.a(A_0), null, 500)
		{
		}

		// Token: 0x02000091 RID: 145
		public class a : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
		{
			// Token: 0x060003D0 RID: 976 RVA: 0x00057A98 File Offset: 0x00055C98
			public a(global::System.Guid A_0)
			{
				this.a = A_0;
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x00057AB4 File Offset: 0x00055CB4
			public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> FetchRange(int startIndex, int length, out int milliseconds)
			{
				int a_ = 0;
				short num = (short)1072627712;
				switch (num)
				{
				default:
				{
					global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
					stopwatch.Start();
					global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer2;
					global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer = automaticPerformanceMeasurer2 = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.StartNewAutomatic(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ViewLoad, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䠙紛稝䤟䴡圣إ崧天䔫䀭圯ሱ眳夵嘷尹唻夽㔿ぁ╃㉅ⅇ╉≋", a_)), null);
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> result;
					try
					{
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer3 = automaticPerformanceMeasurer.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("崙礛樝\u001f瀡䔣䈥䄧䔩弫", a_));
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> radioListUsingConfig;
						try
						{
							num = (short)527171585;
							if (num != 0)
							{
							}
							radioListUsingConfig = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioListUsingConfig(this.a, startIndex, length);
							goto IL_20F;
						}
						finally
						{
							num = (short)1791950849;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_119;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_E1;
									}
									continue;
								case 2:
									automaticPerformanceMeasurer3.Dispose();
									num = (short)1904345088;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_E1:
								if (automaticPerformanceMeasurer3 == null)
								{
									break;
								}
								num = (short)1419706370;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_119:;
						}
						try
						{
							IL_11C:
							result = radioListUsingConfig.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(global::Motorola.CommonCPS.RadioManagement.LocalService.j.a.<>c.<>9.a)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
							goto IL_294;
						}
						finally
						{
							num = (short)258146305;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_20C;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_183;
									}
									continue;
								case 2:
									automaticPerformanceMeasurer3.Dispose();
									num = (short)249888768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_183:
								if (automaticPerformanceMeasurer3 == null)
								{
									break;
								}
								num = (short)631845740;
								short num3 = num;
								num = (short)1698247532;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_20C;
								default:
									num = (short)853868544;
									if (num != 0)
									{
									}
									num = (short)532348930;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_20C:;
						}
						IL_20F:
						automaticPerformanceMeasurer3 = automaticPerformanceMeasurer.StartAutomaticSubMeasurer(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("夙猛瀝嘟䜡嘣別ࠧ帩䌫อ支笱ᐳ嬵圷帹夻刽", a_));
						goto IL_11C;
					}
					finally
					{
						num = (short)260243457;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_291;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_25C;
								}
								continue;
							case 2:
								automaticPerformanceMeasurer2.Dispose();
								num = (short)1127088128;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_25C:
							if (automaticPerformanceMeasurer2 == null)
							{
								break;
							}
							num = (short)339214338;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_291:;
					}
					IL_294:
					num = (short)2049376256;
					short num4 = num;
					stopwatch.Stop();
					milliseconds = (int)stopwatch.ElapsedMilliseconds;
					return result;
				}
				}
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x00057DDC File Offset: 0x00055FDC
			public int GetTotalCount()
			{
				short num = (short)1777344349;
				short num2 = num;
				num = (short)473833309;
				switch (num2 == num)
				{
				}
				num = (short)1981546496;
				if (num != 0)
				{
				}
				num = (short)1093468160;
				short num3 = num;
				num = (short)1901068289;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadiosCountUsingConfig(this.a);
			}

			// Token: 0x060003D3 RID: 979 RVA: 0x00057E9C File Offset: 0x0005609C
			public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item)
			{
				short num = (short)68358019;
				short num2 = num;
				num = (short)758976387;
				switch (num2 == num)
				{
				}
				num = (short)1903165440;
				if (num != 0)
				{
				}
				num = (short)1369309184;
				short num3 = num;
				num = (short)1315373057;
				if (num != 0)
				{
				}
				item.a();
			}

			// Token: 0x040000BE RID: 190
			private global::System.Guid a;
		}
	}
}
