using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x020000A3 RID: 163
	public class SystemRadioInfoViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo>
	{
		// Token: 0x060003FF RID: 1023 RVA: 0x00059ED8 File Offset: 0x000580D8
		public SystemRadioInfoViewProvider(global::System.Guid? groupId)
		{
			this.a = groupId;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00059EF4 File Offset: 0x000580F4
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num;
			for (;;)
			{
				num = (short)1058537473;
				if (num != 0)
				{
				}
				num = (short)696582144;
				switch (num)
				{
				default:
				{
					num = (short)1064773920;
					short num2 = num;
					num = (short)1620519200;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_7B;
					}
					break;
				}
				}
			}
			IL_7B:
			num = (short)1936195584;
			short num3 = num;
			num = (short)875954176;
			if (num != 0)
			{
			}
			global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
			stopwatch.Start();
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXSystemRadioInfoSummary> list = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListSystemRadioInfos(this.a, startIndex, length);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo> list2 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo>();
			using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXSystemRadioInfoSummary>.Enumerator enumerator = list.GetEnumerator())
			{
				num = (short)932118531;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1413742596;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo item = enumerator.Current.ToUiModel();
						list2.Add(item);
						num = (short)1806368769;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_19F;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_122;
						}
						continue;
					case 4:
						num = (short)1978793986;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_150:
					num = (short)1825177600;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_122:
					goto IL_150;
				}
				IL_19F:;
			}
			stopwatch.Stop();
			milliseconds = (int)stopwatch.ElapsedMilliseconds;
			return list2;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0005A0D0 File Offset: 0x000582D0
		public int GetTotalCount()
		{
			short num = (short)1262258580;
			short num2 = num;
			num = (short)1698924948;
			switch (num2 == num)
			{
			}
			num = (short)134545408;
			short num3 = num;
			num = (short)949420033;
			if (num != 0)
			{
			}
			num = (short)1232011264;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetSystemRadioInfosCount(this.a);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0005A188 File Offset: 0x00058388
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo info)
		{
			short num = (short)1573103116;
			short num2 = num;
			num = (short)1177069068;
			switch (num2 == num)
			{
			}
			num = (short)1186725888;
			short num3 = num;
			num = (short)539492352;
			if (num != 0)
			{
			}
			num = (short)1052639233;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000CD RID: 205
		private global::System.Guid? a;
	}
}
