using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200009A RID: 154
	internal class m : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>
	{
		// Token: 0x060003ED RID: 1005 RVA: 0x00059250 File Offset: 0x00057450
		public m(global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary A_0)
		{
			this.a = A_0;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0005926C File Offset: 0x0005746C
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase> FetchRange(int startIndex, int length, out int milliseconds)
		{
			int a_ = 8;
			short num = (short)1726087168;
			switch (num)
			{
			default:
			{
				global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
				stopwatch.Start();
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>();
				global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.StartNewAutomatic(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ViewLoad, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("校䬣䐥嬧", a_)), null);
				try
				{
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity>.Enumerator enumerator = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListJobSummary(this.a.Uuid, startIndex, length).GetEnumerator())
					{
						num = (short)728760322;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)356319235;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)115212288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase item = enumerator.Current.ToUiModel();
								list.Add(item);
								num = (short)1016463364;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_B1;
								}
								continue;
							case 3:
								goto IL_12F;
							}
							IL_E0:
							num = (short)466026497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B1:
							goto IL_E0;
						}
						IL_12F:;
					}
				}
				finally
				{
					num = (short)1260978177;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1FC;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_175;
							}
							continue;
						case 2:
							automaticPerformanceMeasurer.Dispose();
							num = (short)134348800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_175:
						if (automaticPerformanceMeasurer == null)
						{
							break;
						}
						num = (short)886231393;
						short num3 = num;
						num = (short)1360515425;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1FC;
						default:
							num = (short)945881088;
							if (num != 0)
							{
							}
							num = (short)42663938;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_1FC:;
				}
				num = (short)664731649;
				if (num != 0)
				{
				}
				num = (short)1589903360;
				short num4 = num;
				stopwatch.Stop();
				milliseconds = (int)stopwatch.ElapsedMilliseconds;
				return list;
			}
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000594F4 File Offset: 0x000576F4
		public int GetTotalCount()
		{
			short num = (short)893161076;
			short num2 = num;
			num = (short)1475055220;
			switch (num2 == num)
			{
			}
			num = (short)522452993;
			if (num != 0)
			{
			}
			num = (short)455147520;
			short num3 = num;
			num = (short)1175322624;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetJobCount(this.a.Uuid);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000595B8 File Offset: 0x000577B8
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase item)
		{
			short num = (short)1482404753;
			short num2 = num;
			num = (short)717927313;
			switch (num2 == num)
			{
			}
			num = (short)1083768833;
			if (num != 0)
			{
			}
			num = (short)1821769728;
			short num3 = num;
			num = (short)575012864;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000CA RID: 202
		private global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary a;
	}
}
