using System;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP.States
{
	// Token: 0x0200002B RID: 43
	internal class e : global::Motorola.Common.Communication.RUDP.States.f
	{
		// Token: 0x060001B4 RID: 436 RVA: 0x0001B5F0 File Offset: 0x000197F0
		public static global::Motorola.Common.Communication.RUDP.States.a b()
		{
			short num = (short)860422144;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)934871041;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				case 1:
					goto IL_10E;
				case 2:
				{
					num = (short)811752168;
					short num3 = num;
					num = (short)1895258856;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1860632576;
						if (num != 0)
						{
						}
						num = (short)52101120;
						short num4 = num;
						global::Motorola.Common.Communication.RUDP.States.e.a = new global::Motorola.Common.Communication.RUDP.States.e();
						break;
					}
					}
					num = (short)1017708545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_57:
				if (global::Motorola.Common.Communication.RUDP.States.e.a != null)
				{
					break;
				}
				num = (short)1641086978;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10E:
			return global::Motorola.Common.Communication.RUDP.States.e.a;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0001B714 File Offset: 0x00019914
		private e()
		{
			base.b(global::Motorola.Common.Communication.RUDP.RUDPSockState.OPEN);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0001B730 File Offset: 0x00019930
		public override void l(global::Motorola.Common.Communication.RUDP.b A_0)
		{
			short num = (short)729892905;
			short num2 = num;
			num = (short)955271209;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)94633984;
				short num3 = num;
				num = (short)1518272512;
				if (num != 0)
				{
				}
				num = (short)1634861057;
				if (num != 0)
				{
				}
				global::System.Threading.Thread.Sleep(1000);
				global::Motorola.Common.Communication.RUDP.i i = global::Motorola.Common.Communication.RUDP.k.a(A_0);
				if (A_0.o(i) == (int)i.f)
				{
					A_0.m(global::Motorola.Common.Communication.RUDP.States.c.b());
					return;
				}
				break;
			}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_SendIsNotCompleted);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0001B814 File Offset: 0x00019A14
		public override int j(global::Motorola.Common.Communication.RUDP.b A_0, global::Motorola.Common.Communication.RUDP.i A_1)
		{
			short num = (short)1398538240;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					goto IL_13C;
				case 2:
				{
					num = (short)107948549;
					short num3 = num;
					num = (short)192489989;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1521418240;
						if (num != 0)
						{
						}
						num = (short)1269694465;
						if (num != 0)
						{
						}
						num = (short)1707278336;
						short num4 = num;
						A_1.i.d(A_0.ae());
						A_1.i.ao(A_0.af());
						ushort num5 = A_0.ae();
						A_0.o(num5 + 1);
						break;
					}
					}
					num = (short)286457857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_30:
				if (A_1.b != global::Motorola.Common.Communication.RUDP.f.d)
				{
					break;
				}
				num = (short)700383234;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_13C:
			return A_0.o(A_1);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0001B968 File Offset: 0x00019B68
		public override void k(global::Motorola.Common.Communication.RUDP.b A_0, global::Motorola.Common.Communication.RUDP.i A_1)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_A5;
			}
			int num;
			global::Motorola.Common.Communication.RUDP.f f;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (f != global::Motorola.Common.Communication.RUDP.f.d)
					{
						num2 = (short)323092513;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DE;
				case 1:
				{
					if (f != global::Motorola.Common.Communication.RUDP.f.g)
					{
						num2 = (short)1011089429;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1402503574;
					short num3 = num2;
					num2 = (short)116621718;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_23D;
					default:
						num2 = (short)2044329984;
						if (num2 != 0)
						{
						}
						num2 = (short)433258497;
						if (num2 != 0)
						{
						}
						num2 = (short)1079050256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (f != global::Motorola.Common.Communication.RUDP.f.f)
					{
						num2 = (short)173801478;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AA;
				case 3:
					num2 = (short)1937702927;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (f != global::Motorola.Common.Communication.RUDP.f.h)
					{
						num2 = (short)206962720;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DE;
				case 5:
					goto IL_2DE;
				case 6:
					num2 = (short)1838088201;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1143472130;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (f != global::Motorola.Common.Communication.RUDP.f.e)
					{
						num2 = (short)993722399;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DE;
				case 9:
					if (f != global::Motorola.Common.Communication.RUDP.f.g)
					{
						num2 = (short)827064323;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AA;
				case 10:
					if (f != global::Motorola.Common.Communication.RUDP.f.g)
					{
						num2 = (short)911015964;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DE;
				case 11:
					if (f != global::Motorola.Common.Communication.RUDP.f.f)
					{
						num2 = (short)1527513113;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DE;
				case 12:
					A_0.q(A_1.i.az());
					A_0.q(A_1);
					global::Motorola.Common.Communication.RUDP.b.m(A_1);
					num2 = (short)139526163;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (f == global::Motorola.Common.Communication.RUDP.f.i)
					{
						num2 = (short)1702690821;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)803274775;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (f != global::Motorola.Common.Communication.RUDP.f.d)
					{
						num2 = (short)1067057159;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AA;
				case 15:
					if (f != global::Motorola.Common.Communication.RUDP.f.h)
					{
						num2 = (short)302120980;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AA;
				case 16:
					goto IL_46C;
				case 17:
					return;
				case 18:
					goto IL_337;
				case 19:
					goto IL_5A3;
				case 20:
					goto IL_23D;
				case 21:
					if (f == global::Motorola.Common.Communication.RUDP.f.d)
					{
						num2 = (short)1537146910;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5A3;
				case 22:
					goto IL_1AA;
				case 23:
				{
					num2 = (short)1896939520;
					short num4 = num2;
					if (f != global::Motorola.Common.Communication.RUDP.f.c)
					{
						num2 = (short)481755163;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 24:
					if (f == global::Motorola.Common.Communication.RUDP.f.i)
					{
						num2 = (short)229572630;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 25:
					num2 = (short)1855717386;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					if (A_1.i.az() > A_0.af())
					{
						num2 = (short)1715273740;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_123;
				case 27:
					num2 = (short)450953234;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					num2 = (short)2039676932;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					if (f != global::Motorola.Common.Communication.RUDP.f.f)
					{
						num2 = (short)1196621858;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_33C;
				case 30:
					num2 = (short)1383464986;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					num2 = (short)1917321216;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					num2 = (short)967901197;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
					num2 = (short)1522335755;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					num2 = (short)519897089;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_A5;
				IL_1AA:
				A_0.at();
				num2 = (short)985661457;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_23D:
				num2 = (short)1922629656;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2DE:
				num2 = (short)347602973;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5A3:
				num2 = (short)161284110;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_123:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("挰嘲嘴制倸䴺堼Ἶ㕀⭂⁄杆ⵈ㹊㵌⍎㡐げ㑔⍖㱘㽚絜ⵞѠᝢᝤ٦ݨᡪlٮɰrᱴᡶ᝸孺ർṾ떈붌떎즐ꮔ뮖릘쒠춢솤螦膮", a_), new object[]
			{
				A_1.i.az()
			});
			A_0.s(A_1);
			A_0.ao().l++;
			return;
			IL_337:
			return;
			IL_33C:
			A_0.m(global::Motorola.Common.Communication.RUDP.States.c.b());
			A_0.au();
			return;
			IL_46C:
			goto IL_33C;
			IL_A5:
			f = A_1.b;
			num2 = (short)1719336968;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x040000DC RID: 220
		private static global::Motorola.Common.Communication.RUDP.States.a a;
	}
}
