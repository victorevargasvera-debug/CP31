using System;
using System.Collections.Generic;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x0200002E RID: 46
	public class IshTypeIdTracker
	{
		// Token: 0x06000196 RID: 406 RVA: 0x00023BE0 File Offset: 0x00021DE0
		internal IshTypeIdTracker()
		{
			this.a = new global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.IshTypeIdTracker.a>();
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00023C00 File Offset: 0x00021E00
		public void Add(global::Motorola.Acp.PackUnpack.Ish.IshType ishType, int startId)
		{
			short num = (short)409272320;
			short num2 = num;
			num = (short)491871514;
			short num3 = num;
			num = (short)406215962;
			switch (num3 == num)
			{
			}
			num = (short)1981022208;
			if (num != 0)
			{
			}
			num = (short)1285685249;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.IshTypeIdTracker.a value = new global::Motorola.Acp.PackUnpack.Ish.IshTypeIdTracker.a(ishType, startId);
			this.a.Add(ishType.Value, value);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00023CC4 File Offset: 0x00021EC4
		internal bool a(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			int a_ = 7;
			short num = (short)106692608;
			short num2 = num;
			num = (short)242941953;
			if (num != 0)
			{
			}
			num = (short)154647049;
			short num3 = num;
			num = (short)957987337;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1104347136;
				if (num != 0)
				{
				}
				if (A_0 == null)
				{
					throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펟쪡\udfa5\ud8a7쾩", a_));
				}
				break;
			}
			return this.a.ContainsKey(A_0.Value);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00023DA0 File Offset: 0x00021FA0
		internal bool b(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			int a_ = 10;
			short num = (short)1162608640;
			short num2 = num;
			num = (short)1840052128;
			short num3 = num;
			num = (short)1949824928;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1990393857;
				if (num != 0)
				{
				}
				num = (short)1850015744;
				if (num != 0)
				{
				}
				if (A_0 == null)
				{
					throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("좠킢춤킨\udbaa좬", a_));
				}
				break;
			}
			return this.a.Remove(A_0.Value);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00023E7C File Offset: 0x0002207C
		internal int c(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			int a_ = 7;
			short num = (short)1997930497;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Acp.PackUnpack.Ish.IshTypeIdTracker.a a;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5D;
				case 1:
					goto IL_1D;
				case 2:
					goto IL_1A6;
				case 3:
					a = this.a[A_0.Value];
					num = (short)713621508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_B5;
				case 5:
				{
					num = (short)1963568312;
					short num3 = num;
					num = (short)1300343992;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
						num = (short)1507065857;
						if (num != 0)
						{
						}
						num = (short)2022375424;
						if (num != 0)
						{
						}
						if (this.a.ContainsKey(A_0.Value))
						{
							num = (short)102236163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a = new global::Motorola.Acp.PackUnpack.Ish.IshTypeIdTracker.a(A_0, 0);
						num = (short)700252162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_45;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_45:
					if (A_0 == null)
					{
						num = (short)241500160;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)388956165;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_5D:
			num = (short)1272840192;
			short num4 = num;
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펟쪡\udfa5\ud8a7쾩", a_));
			IL_B5:
			IL_1A6:
			return a.b();
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00024038 File Offset: 0x00022238
		internal int d(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			int a_ = 19;
			short num = (short)265682944;
			short num2 = num;
			num = (short)1038430443;
			short num3 = num;
			num = (short)19017963;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)312737793;
				if (num != 0)
				{
				}
				num = (short)2088763392;
				if (num != 0)
				{
				}
				if (A_0 == null)
				{
					throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쎩\udfab욭쮱쒳펵", a_));
				}
				break;
			}
			return this.a[A_0.Value].c();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00024118 File Offset: 0x00022318
		internal int e(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			int a_ = 12;
			short num = (short)1436680192;
			short num2 = num;
			num = (short)10278879;
			short num3 = num;
			num = (short)1174722527;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)517406720;
				if (num != 0)
				{
				}
				if (A_0 == null)
				{
					num = (short)477626369;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪢횤쾦ﶨ튪\uddac쪮", a_));
				}
				break;
			}
			return this.a[A_0.Value].d();
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000241FC File Offset: 0x000223FC
		internal int a(global::Motorola.Acp.PackUnpack.Ish.IshType A_0, int A_1)
		{
			int a_ = 16;
			short num = (short)348651520;
			short num2 = num;
			num = (short)2085910214;
			short num3 = num;
			num = (short)479426246;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1439498240;
				if (num != 0)
				{
				}
				if (A_0 == null)
				{
					num = (short)1642528769;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("캦\udaa8쎪怜횮솰횲", a_));
				}
				break;
			}
			return this.a[A_0.Value].a(A_1);
		}

		// Token: 0x04000089 RID: 137
		private global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.IshTypeIdTracker.a> a;

		// Token: 0x0200002F RID: 47
		private class a
		{
			// Token: 0x0600019E RID: 414 RVA: 0x000242E0 File Offset: 0x000224E0
			internal a(global::Motorola.Acp.PackUnpack.Ish.IshType A_0, int A_1)
			{
				int a_ = 16;
				base..ctor();
				if (A_0 == null)
				{
					throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("캦\udaa8쎪怜횮솰횲", a_));
				}
				if (A_1 < 0)
				{
					throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("풦\udda8쪪\udfac\udbaeힲ", a_));
				}
				this.a = A_0;
				this.b = A_1;
				this.c = A_1;
			}

			// Token: 0x0600019F RID: 415 RVA: 0x00024344 File Offset: 0x00022544
			internal global::Motorola.Acp.PackUnpack.Ish.IshType a()
			{
				short num = (short)841285632;
				short num2 = num;
				num = (short)918010628;
				short num3 = num;
				num = (short)1877195524;
				switch (num3 == num)
				{
				}
				num = (short)1801781249;
				if (num != 0)
				{
				}
				num = (short)846069760;
				if (num != 0)
				{
				}
				return this.a;
			}

			// Token: 0x060001A0 RID: 416 RVA: 0x000243F0 File Offset: 0x000225F0
			internal int b()
			{
				short num = (short)2073559040;
				short num2 = num;
				num = (short)1815640587;
				short num3 = num;
				num = (short)1197046283;
				switch (num3 == num)
				{
				}
				num = (short)658046977;
				if (num != 0)
				{
				}
				num = (short)1563951104;
				if (num != 0)
				{
				}
				return this.b;
			}

			// Token: 0x060001A1 RID: 417 RVA: 0x0002449C File Offset: 0x0002269C
			internal int c()
			{
				short num = (short)1401159680;
				short num2 = num;
				num = (short)2039545857;
				if (num != 0)
				{
				}
				num = (short)1196062573;
				short num3 = num;
				num = (short)1274574701;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)10878976;
					if (num != 0)
					{
					}
					if (this.a.IsSingleInstance)
					{
						throw new global::System.InvalidOperationException();
					}
					break;
				}
				int num4 = this.c;
				this.c = num4 + 1;
				return num4;
			}

			// Token: 0x060001A2 RID: 418 RVA: 0x0002456C File Offset: 0x0002276C
			internal int d()
			{
				short num = (short)288948224;
				short num2 = num;
				num = (short)245037460;
				short num3 = num;
				num = (short)2138765716;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1552547841;
					if (num != 0)
					{
					}
					num = (short)1500905472;
					if (num != 0)
					{
					}
					if (this.a.IsSingleInstance)
					{
						throw new global::System.InvalidOperationException();
					}
					break;
				}
				return this.c;
			}

			// Token: 0x060001A3 RID: 419 RVA: 0x00024630 File Offset: 0x00022830
			internal int a(int A_0)
			{
				int a_ = 9;
				short num = (short)702676992;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)780982432;
						short num3 = num;
						num = (short)602462368;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_DE;
						default:
							num = (short)1654390784;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_89;
							}
							continue;
						}
						break;
					}
					case 1:
						goto IL_11E;
					case 2:
						goto IL_AB;
					case 3:
						if (A_0 < 0)
						{
							goto IL_DE;
						}
						goto IL_151;
					}
					IL_89:
					if (this.a.IsSingleInstance)
					{
						num = (short)2093809666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1878589443;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DE:
					num = (short)1228013568;
					short num4 = num;
					num = (short)158990337;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AB:
				throw new global::System.InvalidOperationException();
				IL_11E:
				num = (short)1283784705;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첟춡쮣춥즧슩즫쾭풯", a_));
				IL_151:
				return this.b + A_0;
			}

			// Token: 0x0400008A RID: 138
			private global::Motorola.Acp.PackUnpack.Ish.IshType a;

			// Token: 0x0400008B RID: 139
			private int b;

			// Token: 0x0400008C RID: 140
			private int c;
		}
	}
}
