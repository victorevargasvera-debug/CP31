using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000097 RID: 151
	internal class l : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x00058A28 File Offset: 0x00056C28
		public l(bool? A_0)
		{
			this.a = A_0;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00058A44 File Offset: 0x00056C44
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)1371734016;
			switch (num)
			{
			default:
			{
				global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
				stopwatch.Start();
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary> list = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListJbcSummarys(this.a, startIndex, length);
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> list2 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary>.Enumerator enumerator = list.GetEnumerator())
				{
					num = (short)555155458;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)933625859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							num = (short)646895212;
							short num3 = num;
							num = (short)912578156;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_17D;
							default:
							{
								num = (short)103612417;
								if (num != 0)
								{
								}
								num = (short)1364656128;
								if (num != 0)
								{
								}
								if (!enumerator.MoveNext())
								{
									num = (short)803471360;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer item = enumerator.Current.ToUiModel();
								list2.Add(item);
								num = (short)1470889988;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_85;
							}
							continue;
						case 3:
							goto IL_17D;
						}
						IL_B3:
						num = (short)997261313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_85:
						goto IL_B3;
					}
					IL_17D:;
				}
				num = (short)366804992;
				short num4 = num;
				stopwatch.Stop();
				milliseconds = (int)stopwatch.ElapsedMilliseconds;
				return list2;
			}
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00058C34 File Offset: 0x00056E34
		public int GetTotalCount()
		{
			short num = (short)1249980237;
			short num2 = num;
			num = (short)1286680397;
			switch (num2 == num)
			{
			}
			num = (short)1807613952;
			if (num != 0)
			{
			}
			num = (short)1153105920;
			short num3 = num;
			num = (short)1114963969;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetJbcCount(this.a);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00058CF0 File Offset: 0x00056EF0
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer item)
		{
			short num = (short)1350124482;
			short num2 = num;
			num = (short)771900354;
			switch (num2 == num)
			{
			}
			num = (short)947060737;
			if (num != 0)
			{
			}
			num = (short)444923904;
			short num3 = num;
			num = (short)1948516352;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000C6 RID: 198
		private bool? a;
	}
}
