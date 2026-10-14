using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000069 RID: 105
	internal class g : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x0600035D RID: 861 RVA: 0x00051ACC File Offset: 0x0004FCCC
		public g(global::System.Guid A_0, global::System.Guid A_1) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.g.a(A_0), new global::Motorola.CommonCPS.RadioManagement.LocalService.g.b(A_1), 500)
		{
		}

		// Token: 0x0200006A RID: 106
		public class a : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
		{
			// Token: 0x0600035E RID: 862 RVA: 0x00051AF0 File Offset: 0x0004FCF0
			public a(global::System.Guid A_0)
			{
				this.a = A_0;
			}

			// Token: 0x0600035F RID: 863 RVA: 0x00051B0C File Offset: 0x0004FD0C
			public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> FetchRange(int startIndex, int length, out int milliseconds)
			{
				short num;
				for (;;)
				{
					num = (short)641007617;
					if (num != 0)
					{
					}
					num = (short)1763573760;
					short num2 = num;
					num = (short)548208640;
					switch (num)
					{
					default:
					{
						num = (short)569744225;
						short num3 = num;
						num = (short)258055009;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_A2;
						}
						break;
					}
					}
				}
				IL_A2:
				num = (short)1295843328;
				if (num != 0)
				{
				}
				global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
				milliseconds = 0;
				stopwatch.Start();
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> radioListUsingConfigWithWorkingCodeplug = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioListUsingConfigWithWorkingCodeplug(this.a, startIndex, length);
				stopwatch.Stop();
				milliseconds += (int)stopwatch.ElapsedMilliseconds;
				stopwatch.Restart();
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary>.Enumerator enumerator = radioListUsingConfigWithWorkingCodeplug.GetEnumerator())
				{
					num = (short)1381957635;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
							num = (short)934281220;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1248133121;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = enumerator.Current.ToUiModel(false);
							list.Add(item);
							num = (short)1978007552;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_13A;
							}
							continue;
						case 4:
							goto IL_1B7;
						}
						IL_168:
						num = (short)827457538;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_13A:
						goto IL_168;
					}
					IL_1B7:;
				}
				stopwatch.Stop();
				milliseconds += (int)stopwatch.ElapsedMilliseconds;
				return list;
			}

			// Token: 0x06000360 RID: 864 RVA: 0x00051D04 File Offset: 0x0004FF04
			public int GetTotalCount()
			{
				short num = (short)298565805;
				short num2 = num;
				num = (short)795132077;
				switch (num2 == num)
				{
				default:
				{
					num = (short)354942976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)184745985;
				if (num != 0)
				{
				}
				num = (short)795934720;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadiosCountUsingConfigWithWorkingCodeplug(this.a);
			}

			// Token: 0x06000361 RID: 865 RVA: 0x00051DC0 File Offset: 0x0004FFC0
			public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item)
			{
				short num = (short)1470385173;
				short num2 = num;
				num = (short)1625902101;
				switch (num2 == num)
				{
				default:
				{
					num = (short)394919936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1245185;
				if (num != 0)
				{
				}
				num = (short)914227200;
				if (num != 0)
				{
				}
				item.a();
			}

			// Token: 0x04000098 RID: 152
			private global::System.Guid a;
		}

		// Token: 0x0200006B RID: 107
		public class b : global::Motorola.CommonCPS.RadioManagement.ViewCache.IFilter<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
		{
			// Token: 0x06000362 RID: 866 RVA: 0x00051E70 File Offset: 0x00050070
			public b(global::System.Guid A_0)
			{
				this.a = A_0;
			}

			// Token: 0x06000363 RID: 867 RVA: 0x00051E98 File Offset: 0x00050098
			public bool IsFilterOut(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item)
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				short num;
				int num2;
				global::System.Guid? id;
				for (;;)
				{
					IL_0A:
					num = (short)1476591617;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						if (id == null)
						{
							num = (short)880607235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_143;
					case 1:
						goto IL_B7;
					case 2:
						if (id == null)
						{
							num = (short)1932328960;
							short num3 = num;
							num = (short)913440769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)101908480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return true;
					}
					goto IL_47;
				}
				IL_B7:
				num = (short)970831482;
				short num4 = num;
				num = (short)143373946;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				default:
					num = (short)1237385216;
					if (num != 0)
					{
					}
					return false;
				}
				IL_143:
				global::System.Guid b;
				return id.GetValueOrDefault() == b;
				IL_47:
				id = item.ID;
				b = this.a;
				num = (short)769064962;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}

			// Token: 0x04000099 RID: 153
			private global::System.Guid a = global::System.Guid.Empty;
		}
	}
}
