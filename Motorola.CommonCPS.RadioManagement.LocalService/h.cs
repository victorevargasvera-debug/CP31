using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200007D RID: 125
	internal class h : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x06000398 RID: 920 RVA: 0x00054DD8 File Offset: 0x00052FD8
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)61014016;
			switch (num)
			{
			default:
			{
				num = (short)117309440;
				short num2 = num;
				num = (short)54460417;
				if (num != 0)
				{
				}
				global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
				stopwatch.Start();
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> list = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListCandidateMVORadioSummary(startIndex, length);
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list2 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary>.Enumerator enumerator = list.GetEnumerator())
				{
					num = (short)1846411268;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)908001283;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (!enumerator.MoveNext())
							{
								num = (short)211681280;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D1;
						case 3:
							goto IL_1A0;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_CF;
							}
							continue;
						}
						goto IL_CF;
						IL_D1:
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = enumerator.Current.ToUiModel(true);
						list2.Add(item);
						num = (short)71041026;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_FD:
						num = (short)388090838;
						short num4 = num;
						num = (short)1031916502;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D1;
						default:
							num = (short)1261830144;
							if (num != 0)
							{
							}
							num = (short)1862402049;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_CF:
						goto IL_FD;
					}
					IL_1A0:;
				}
				stopwatch.Stop();
				milliseconds = (int)stopwatch.ElapsedMilliseconds;
				return list2;
			}
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00054FC4 File Offset: 0x000531C4
		public int GetTotalCount()
		{
			short num = (short)1869850218;
			short num2 = num;
			num = (short)2103682666;
			switch (num2 == num)
			{
			}
			num = (short)2128347137;
			if (num != 0)
			{
			}
			num = (short)1019019264;
			short num3 = num;
			num = (short)2041249792;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetCandidateMVORadioSummaryCount();
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00055078 File Offset: 0x00053278
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item)
		{
			short num = (short)325648385;
			if (num != 0)
			{
			}
			num = (short)349283120;
			short num2 = num;
			num = (short)1099604784;
			switch (num2 == num)
			{
			}
			num = (short)9109504;
			short num3 = num;
			num = (short)1941766144;
			if (num != 0)
			{
			}
		}
	}
}
