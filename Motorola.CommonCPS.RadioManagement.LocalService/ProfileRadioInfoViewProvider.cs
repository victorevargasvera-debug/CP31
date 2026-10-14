using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000089 RID: 137
	public class ProfileRadioInfoViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo>
	{
		// Token: 0x060003BF RID: 959 RVA: 0x00056DFC File Offset: 0x00054FFC
		public ProfileRadioInfoViewProvider(global::System.Guid? groupId)
		{
			this.a = groupId;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00056E18 File Offset: 0x00055018
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)347963446;
			short num2 = num;
			num = (short)772046902;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_20C;
			case 1:
				break;
			default:
			{
				num = (short)1984495616;
				short num3 = num;
				break;
			}
			}
			num = (short)1339359233;
			if (num != 0)
			{
			}
			num = (short)1550319616;
			if (num != 0)
			{
			}
			num = (short)2111569920;
			global::System.Diagnostics.Stopwatch stopwatch;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo> list;
			switch (num)
			{
			default:
			{
				stopwatch = new global::System.Diagnostics.Stopwatch();
				stopwatch.Start();
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.ProfileRadioInfoSummary> enumerable = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListProfileRadioInfo(this.a, startIndex, length);
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.ProfileRadioInfoSummary> enumerator = enumerable.GetEnumerator();
				try
				{
					num = (short)702152705;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_19E;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_124;
							}
							continue;
						case 3:
							num = (short)676265984;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)9895939;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo item = enumerator.Current.ToUiModel();
							list.Add(item);
							num = (short)1174405122;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_150:
						num = (short)1706164228;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_124:
						goto IL_150;
					}
					IL_19E:;
				}
				finally
				{
					num = (short)1615003648;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1D2;
							}
							continue;
						case 1:
							goto IL_209;
						case 2:
							enumerator.Dispose();
							num = (short)602734593;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1D2:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1349058562;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_209:;
				}
				break;
			}
			}
			IL_20C:
			stopwatch.Stop();
			milliseconds = (int)stopwatch.ElapsedMilliseconds;
			return list;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00057054 File Offset: 0x00055254
		public int GetTotalCount()
		{
			short num = (short)491323393;
			if (num != 0)
			{
			}
			num = (short)1051181952;
			short num2 = num;
			num = (short)505660288;
			switch (num2 == num)
			{
			}
			num = (short)1586561024;
			if (num != 0)
			{
			}
			num = (short)535887872;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetProfileRadioInfoCount(this.a);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00057110 File Offset: 0x00055310
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo info)
		{
			short num = (short)151147471;
			short num2 = num;
			num = (short)366171087;
			switch (num2 == num)
			{
			}
			num = (short)815005697;
			if (num != 0)
			{
			}
			num = (short)1754333184;
			if (num != 0)
			{
			}
			num = (short)1095761920;
			short num3 = num;
		}

		// Token: 0x040000BA RID: 186
		private global::System.Guid? a;
	}
}
