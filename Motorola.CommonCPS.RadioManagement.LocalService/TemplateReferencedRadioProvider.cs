using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000094 RID: 148
	public class TemplateReferencedRadioProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption>
	{
		// Token: 0x060003D8 RID: 984 RVA: 0x000580E4 File Offset: 0x000562E4
		public TemplateReferencedRadioProvider(global::System.Guid templateUuid)
		{
			this.a = templateUuid;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00058100 File Offset: 0x00056300
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)416612352;
			switch (num)
			{
			default:
			{
				global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
				milliseconds = 0;
				stopwatch.Start();
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio> referencedRadioList = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetReferencedRadioList(this.a, startIndex, length, false);
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio>.Enumerator enumerator = referencedRadioList.GetEnumerator())
				{
					num = (short)2107047938;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)1560281091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							num = (short)324594876;
							short num3 = num;
							num = (short)203680956;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_181;
							default:
							{
								num = (short)1724317696;
								if (num != 0)
								{
								}
								if (!enumerator.MoveNext())
								{
									num = (short)525729792;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.Radio radio = enumerator.Current;
								list.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption
								{
									SerialNumber = radio.SerialNumber,
									Option = true,
									InnerRadio = radio.ToUiModel(true)
								});
								num = (short)1063583748;
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
								goto IL_89;
							}
							continue;
						case 3:
							goto IL_181;
						}
						IL_DE:
						num = (short)1005846529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_89:
						goto IL_DE;
					}
					IL_181:;
				}
				num = (short)808189953;
				if (num != 0)
				{
				}
				num = (short)312410112;
				short num4 = num;
				stopwatch.Stop();
				milliseconds = (int)stopwatch.ElapsedMilliseconds;
				return list;
			}
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0005831C File Offset: 0x0005651C
		public int GetTotalCount()
		{
			short num = (short)1316118534;
			short num2 = num;
			num = (short)2036359174;
			switch (num2 == num)
			{
			}
			num = (short)1419247616;
			if (num != 0)
			{
			}
			num = (short)1483538432;
			short num3 = num;
			num = (short)2045378561;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetReferencedRadiosCount(new global::System.Collections.Generic.List<global::System.Guid>
			{
				this.a
			}, false, true);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x000583E8 File Offset: 0x000565E8
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption item)
		{
			short num = (short)1220438821;
			short num2 = num;
			num = (short)887778085;
			switch (num2 == num)
			{
			}
			num = (short)850132993;
			if (num != 0)
			{
			}
			num = (short)175898624;
			short num3 = num;
			num = (short)1100808192;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000C1 RID: 193
		private global::System.Guid a;
	}
}
