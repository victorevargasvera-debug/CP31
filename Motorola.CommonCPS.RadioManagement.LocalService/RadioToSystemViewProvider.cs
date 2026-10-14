using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200009F RID: 159
	public class RadioToSystemViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>
	{
		// Token: 0x060003F5 RID: 1013 RVA: 0x000596C8 File Offset: 0x000578C8
		public RadioToSystemViewProvider(global::System.Guid radioUuid)
		{
			this.a = radioUuid;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000596E4 File Offset: 0x000578E4
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)1258291200;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> list;
				global::System.Diagnostics.Stopwatch stopwatch;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_18B;
					case 1:
					{
						num = (short)911348398;
						short num3 = num;
						num = (short)983175854;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1FA;
						default:
							num = (short)26279936;
							if (num != 0)
							{
							}
							if (startIndex == 0)
							{
								num = (short)748814336;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_235;
						}
						break;
					}
					case 2:
						try
						{
							num = (short)1931542531;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1576796164;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem item = enumerator.Current.ToUiModel(false);
									list.Add(item);
									num = (short)1986723841;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_17B;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_FD;
									}
									continue;
								case 4:
									num = (short)1429405698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_12C:
								num = (short)109379584;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FD:
								goto IL_12C;
							}
							IL_17B:
							goto IL_1FA;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_18B;
					}
					goto IL_3A;
					IL_18B:
					stopwatch = new global::System.Diagnostics.Stopwatch();
					stopwatch.Start();
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary> list2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListSystemsByRadio(this.a);
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>();
					enumerator = list2.GetEnumerator();
					num = (short)1357053953;
					if (num != 0)
					{
					}
					num = (short)596312066;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1FA:
				num = (short)2084634624;
				short num4 = num;
				stopwatch.Stop();
				milliseconds = (int)stopwatch.ElapsedMilliseconds;
				return list;
				IL_235:
				return new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>();
				IL_3A:
				milliseconds = 0;
				num = (short)960430081;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0005993C File Offset: 0x00057B3C
		public int GetTotalCount()
		{
			short num = (short)867434497;
			if (num != 0)
			{
			}
			num = (short)1577206839;
			short num2 = num;
			num = (short)2029208631;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1731854336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)98762752;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetSystemCountByRadio(this.a);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000599FC File Offset: 0x00057BFC
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem item)
		{
			short num = (short)374793339;
			short num2 = num;
			num = (short)2013324411;
			switch (num2 == num)
			{
			}
			num = (short)1520566272;
			short num3 = num;
			num = (short)403046401;
			if (num != 0)
			{
			}
			num = (short)1984167936;
			if (num != 0)
			{
			}
			item.a();
		}

		// Token: 0x040000CB RID: 203
		private global::System.Guid a;
	}
}
