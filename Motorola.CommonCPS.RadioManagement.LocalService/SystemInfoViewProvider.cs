using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x020000A1 RID: 161
	public class SystemInfoViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo>
	{
		// Token: 0x060003FA RID: 1018 RVA: 0x00059ACC File Offset: 0x00057CCC
		public SystemInfoViewProvider(global::System.Guid? groupId)
		{
			this.a = groupId;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00059AE8 File Offset: 0x00057CE8
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)196608000;
			switch (num)
			{
			default:
			{
				num = (short)1016070144;
				short num2 = num;
				num = (short)753664001;
				if (num != 0)
				{
				}
				global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
				stopwatch.Start();
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary> enumerable = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListAPXRadioSystems(this.a, startIndex, length);
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListAllRadioSystems(this.a, startIndex, length).Distinct<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary>();
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary> enumerator = enumerable.GetEnumerator();
				try
				{
					num = (short)116523011;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1128726532;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo item = enumerator.Current.ToUiModel();
							list.Add(item);
							num = (short)668865218;
							short num4 = num;
							num = (short)1050546882;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1A8;
							default:
								num = (short)1920335872;
								if (num != 0)
								{
								}
								num = (short)751828993;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_1C2;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_F0;
							}
							continue;
						case 4:
							goto IL_1A8;
						}
						IL_16B:
						num = (short)1847328768;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_F0:
						goto IL_16B;
						IL_1A8:
						num = (short)1257373698;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1C2:;
				}
				finally
				{
					num = (short)1236664321;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)416677890;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1F6;
							}
							continue;
						case 2:
							goto IL_22C;
						}
						IL_1F6:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1900216320;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_22C:;
				}
				stopwatch.Stop();
				milliseconds = (int)stopwatch.ElapsedMilliseconds;
				return list;
			}
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00059D50 File Offset: 0x00057F50
		public int GetTotalCount()
		{
			short num = (short)603626290;
			short num2 = num;
			num = (short)136616754;
			switch (num2 == num)
			{
			}
			num = (short)1349320704;
			short num3 = num;
			num = (short)547815425;
			if (num != 0)
			{
			}
			num = (short)1126301696;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetAPXRadioSystemsCount(this.a);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00059E0C File Offset: 0x0005800C
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo item)
		{
			short num = (short)698028329;
			short num2 = num;
			num = (short)1482232105;
			switch (num2 == num)
			{
			}
			num = (short)10747904;
			short num3 = num;
			num = (short)1749680129;
			if (num != 0)
			{
			}
			num = (short)377749504;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000CC RID: 204
		private global::System.Guid? a;
	}
}
