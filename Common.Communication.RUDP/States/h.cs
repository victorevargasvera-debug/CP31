using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP.States
{
	// Token: 0x0200002D RID: 45
	internal class h : global::Motorola.Common.Communication.RUDP.States.f
	{
		// Token: 0x060001BA RID: 442 RVA: 0x0001BF70 File Offset: 0x0001A170
		public static global::Motorola.Common.Communication.RUDP.States.a b()
		{
			short num = (short)598671362;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_10F;
				case 1:
				{
					num = (short)640221185;
					if (num != 0)
					{
					}
					num = (short)839886565;
					short num3 = num;
					num = (short)2086512357;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A;
					case 1:
						break;
					default:
					{
						num = (short)1590820864;
						short num4 = num;
						break;
					}
					}
					num = (short)1015480320;
					if (num != 0)
					{
					}
					global::Motorola.Common.Communication.RUDP.States.h.b = new global::Motorola.Common.Communication.RUDP.States.h();
					num = (short)56754176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				goto IL_30;
				IL_3A:
				num = (short)1765474305;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30:
				if (global::Motorola.Common.Communication.RUDP.States.h.b == null)
				{
					goto IL_3A;
				}
				break;
			}
			IL_10F:
			return global::Motorola.Common.Communication.RUDP.States.h.b;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0001C094 File Offset: 0x0001A294
		private h()
		{
			base.b(global::Motorola.Common.Communication.RUDP.RUDPSockState.SYN_SENT);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0001C0B0 File Offset: 0x0001A2B0
		public override void k(global::Motorola.Common.Communication.RUDP.b A_0, global::Motorola.Common.Communication.RUDP.i A_1)
		{
			int a_ = 9;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				int num;
				global::Motorola.Common.Communication.RUDP.f f;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						num2 = (short)754843663;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						IL_30B:
						goto IL_40E;
					case 2:
						num2 = (short)1587675156;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
					{
						global::Motorola.Common.Communication.RUDP.i i;
						if (A_0.t(i) != (int)i.f)
						{
							num2 = (short)995819528;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						A_0.m(global::Motorola.Common.Communication.RUDP.States.b.b());
						A_0.ap().e(global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ConnectFail);
						num2 = (short)621608961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
						if (f == global::Motorola.Common.Communication.RUDP.f.e)
						{
							num2 = (short)409272333;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_212;
					case 5:
						if (f == global::Motorola.Common.Communication.RUDP.f.g)
						{
							num2 = (short)1177616394;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)817889284;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						A_0.n(-1);
						num2 = (short)664731665;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						goto IL_40E;
					case 8:
						goto IL_20D;
					case 9:
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("縬䨮䌰䔲倴䔶ᤸ䤺堼夾㑀あ⁄杆㵈⍊⡌潎㉐㱒㭔㥖㱘㡚⥜㙞๠ൢ䑤", a_), global::System.Array.Empty<object>());
						A_0.m(global::Motorola.Common.Communication.RUDP.States.b.b());
						A_0.ap().e(global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ServerRefusedConnection);
						num2 = (short)298975248;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 10:
						num2 = (short)1805647891;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 11:
					{
						global::Motorola.Common.Communication.RUDP.i i = global::Motorola.Common.Communication.RUDP.k.a(A_0);
						i.i.d(A_1.i.a0() + 1);
						i.i.ao(global::Motorola.Common.Communication.RUDP.c.a);
						num2 = (short)1751777283;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 12:
						goto IL_472;
					case 13:
						num2 = (short)1426718738;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 14:
						if (f == global::Motorola.Common.Communication.RUDP.f.c)
						{
							num2 = (short)76808192;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_34A;
					case 15:
						if (A_1.i.a0() == A_0.ac())
						{
							num2 = (short)459866114;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_34A;
					case 16:
						goto IL_40E;
					case 17:
						goto IL_28A;
					case 18:
						if (A_1.i.a0() != A_0.ac())
						{
							num2 = (short)46137355;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_212;
					case 19:
						if (A_1.i.a0() == A_0.ac())
						{
							num2 = (short)51314697;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F6;
					case 20:
						if (A_0.ag() >= 1)
						{
							num2 = (short)1411645446;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_28A;
					}
					goto IL_6D;
					IL_28A:
					A_0.p(A_1.i.az());
					A_0.q(A_1.i.az());
					global::Motorola.Common.Communication.RUDP.States.h.b(A_0, A_1);
					this.p(A_0);
					A_1.h = true;
					num2 = (short)449314823;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_34A:
					num2 = (short)1191706629;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_40E:
					num2 = (short)1575910900;
					short num3 = num2;
					num2 = (short)1450737140;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_30B;
					default:
						num2 = (short)335478784;
						if (num2 != 0)
						{
						}
						num2 = (short)1071513612;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				IL_F6:
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("缬種田挲༴᜶欸帺帼娾⡀㕂⁄⍆楈᥊Ṍ᭎煐⍒㑔㑖㉘㹚⥜罞ݠౢᝤ䝦ᵨͪ࡬佮ѰᵲṴ᥶ᙸ౺፼彾튀춂름ﲆ릈뎌꺎", a_), new object[]
				{
					A_1.i.a0()
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_ResetByRemotePeer);
				IL_20D:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_SendIsNotCompleted);
				IL_212:
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("缬種田挲༴᜶永唺嘼儾⹀㑂⭄杆㥈⩊⹌⑎㑐❒瑔", a_), global::System.Array.Empty<object>());
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_UnexpectedPacketReceived);
				IL_472:
				goto IL_4DA;
				IL_6D:
				f = A_1.b;
				num2 = (short)1773142030;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch (global::System.Exception)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("缬種田挲༴᜶稸吺匼儾⑀⁂ㅄ⹆♈╊浌⥎ぐ㩒㥔㉖㵘穚", a_), global::System.Array.Empty<object>());
				try
				{
					A_0.m(global::Motorola.Common.Communication.RUDP.States.b.b());
					A_0.ap().e(global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ConnectFail);
				}
				catch
				{
				}
				num2 = (short)2138963969;
				if (num2 != 0)
				{
				}
				throw;
			}
			IL_4DA:
			num2 = (short)1001586688;
			short num4 = num2;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0001C5F8 File Offset: 0x0001A7F8
		public override void p(global::Motorola.Common.Communication.RUDP.b A_0)
		{
			short num;
			for (;;)
			{
				global::Motorola.Common.Communication.RUDP.i i = global::Motorola.Common.Communication.RUDP.k.a(A_0, null);
				if (A_0.t(i) != (int)i.f)
				{
					break;
				}
				num = (short)344195072;
				short num2 = num;
				num = (short)287012872;
				short num3 = num;
				num = (short)1197635592;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_83;
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_SendIsNotCompleted);
			IL_83:
			num = (short)2128936961;
			if (num != 0)
			{
			}
			num = (short)744685568;
			if (num != 0)
			{
			}
			A_0.m(global::Motorola.Common.Communication.RUDP.States.e.b());
			A_0.ap().f(global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0001C6DC File Offset: 0x0001A8DC
		public override int j(global::Motorola.Common.Communication.RUDP.b A_0, global::Motorola.Common.Communication.RUDP.i A_1)
		{
			int a_ = 12;
			short num = (short)420478977;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_13A;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
				{
					num = (short)551774553;
					short num3 = num;
					num = (short)1357080921;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13F;
					case 1:
						break;
					default:
					{
						num = (short)379125760;
						short num4 = num;
						break;
					}
					}
					num = (short)1384775680;
					if (num != 0)
					{
					}
					if (A_1.i.aw())
					{
						num = (short)1762983936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13F;
				}
				case 3:
					num = (short)1859452929;
					if (num != 0)
					{
					}
					num = (short)1366818818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3D:
				if (A_1.i.av())
				{
					break;
				}
				num = (short)128057347;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_87:
			return A_0.o(A_1);
			IL_13A:
			goto IL_87;
			IL_13F:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("戯朱瀳昵ȷᨹ栻䰽㤿扁ぃ⥅桇㥉⥋⁍㑏牑⁓㹕㵗穙㉛ㅝ๟佡╣╥⍧ᙩ㹫㵭⑯乱ཱི䙵䉷ɹŻ䁽ꁿ揄낏ﮑ望뚕쮗쎙튛솝蒧誩욫\udbad쎯욱钳튵쪷햹첻麽ꦿ뛁", a_), new object[]
			{
				A_1.i.az()
			});
			return 0;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0001C85C File Offset: 0x0001AA5C
		public override void l(global::Motorola.Common.Communication.RUDP.b A_0)
		{
			int a_ = 8;
			short num = (short)526152025;
			short num2 = num;
			num = (short)1494053209;
			switch (num2 == num)
			{
			}
			num = (short)1031405569;
			if (num != 0)
			{
			}
			num = (short)1185939456;
			if (num != 0)
			{
			}
			num = (short)1901133824;
			short num3 = num;
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("縫笭琯戱ำᘵ縷嬹唻刽┿♁摃㉅❇橉⑋⽍㹏㙑❓㹕㥗ㅙ㥛牝䁟١ൣᕥ୧թɫmᕯᅱsήᙷᵹ剻偽깿", a_), global::System.Array.Empty<object>());
			A_0.m(global::Motorola.Common.Communication.RUDP.States.b.b());
			A_0.aq().f(global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0001C940 File Offset: 0x0001AB40
		private static void b(global::Motorola.Common.Communication.RUDP.b A_0, global::Motorola.Common.Communication.RUDP.i A_1)
		{
			int a_ = 9;
			short num = (short)483065872;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)629055805;
					short num3 = num;
					num = (short)1347854653;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B1;
					default:
					{
						num = (short)1318060032;
						if (num != 0)
						{
						}
						num = (short)1708064768;
						short num4 = num;
						if (A_0.an().CloseWaitTimeout < (int)A_1.k.@as().aw() * global::Motorola.Common.Communication.RUDP.c.w)
						{
							num = (short)498663432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					break;
				}
				case 1:
					num = (short)1902182401;
					if (num != 0)
					{
					}
					num = (short)124125186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (A_0.an().NegotiationAlgorithm == 3)
					{
						num = (short)365756419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)829816836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)149815313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (A_0.an().NegotiationAlgorithm == 2)
					{
						num = (short)1269497871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					return;
				case 6:
					goto IL_B1;
				case 7:
					if (A_0.an().InactivityTimeout < (int)A_1.k.@as().av() * global::Motorola.Common.Communication.RUDP.c.w)
					{
						num = (short)1138688010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24C;
				case 8:
					goto IL_316;
				case 9:
					goto IL_4D6;
				case 10:
					A_0.an().InactivityTimeout = (int)A_1.k.@as().av() * global::Motorola.Common.Communication.RUDP.c.w;
					num = (short)434044948;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("缬種田挲༴᜶洸区堼Ἶ㉀♂㝄ㅆⱈ㥊浌㵎㑐❒⁔╖㝘筚⥜㝞Ѡ䍢Ť๦ཨ൪࡬ᵮᑰᵲŴ坶㑸⡺⹼Ѿ놀ﺂꖄﾊ꾎ﮒ랖滛爵쾠힢\udea4隦풨薪", a_), new object[]
					{
						A_1.k.ar().av(),
						A_0.an().SynNegociateParameters.maximal_fragment_size
					});
					num = (short)1891827734;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					A_0.an().MaxTimeBetweenRetries = (int)A_1.k.@as().au() * global::Motorola.Common.Communication.RUDP.c.w;
					A_0.an().TimeBetweenRetries = (int)A_1.k.@as().@as() * global::Motorola.Common.Communication.RUDP.c.w;
					num = (short)1239416841;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					A_0.an().MaxNumberofRetries = (int)A_1.k.@as().ar();
					num = (short)16515086;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_3F2;
				case 15:
					A_0.an().MaxNumberofRetries = (int)A_1.k.@as().ar();
					A_0.an().MaxTimeBetweenRetries = (int)A_1.k.@as().au() * global::Motorola.Common.Communication.RUDP.c.w;
					A_0.an().TimeBetweenRetries = (int)A_1.k.@as().@as() * global::Motorola.Common.Communication.RUDP.c.w;
					A_0.an().InactivityTimeout = (int)A_1.k.@as().av() * global::Motorola.Common.Communication.RUDP.c.w;
					A_0.an().CloseWaitTimeout = (int)A_1.k.@as().aw() * global::Motorola.Common.Communication.RUDP.c.w;
					A_0.an().RetryCurveShape = (float)A_1.k.@as().at();
					num = (short)874315781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					switch (0)
					{
					case 0:
						goto IL_8A;
					}
					continue;
				case 17:
					if (A_0.an().MaxNumberofRetries < (int)A_1.k.@as().ar())
					{
						num = (short)1682964493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F2;
				case 18:
					if (A_0.an().TimeBetweenRetries < (int)A_1.k.@as().@as() * global::Motorola.Common.Communication.RUDP.c.w)
					{
						num = (short)924712972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4D6;
				case 19:
					if (A_1.k.@as() != null)
					{
						num = (short)1324482561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 20:
					goto IL_24C;
				case 21:
					if (A_0.an().SynNegociateParameters.maximal_fragment_size != (int)A_1.k.ar().av())
					{
						num = (short)1146880011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_153;
				case 22:
					goto IL_153;
				}
				IL_8A:
				if (A_1.k.ar() != null)
				{
					num = (short)2096824326;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_153;
				IL_B1:
				num = (short)1595867157;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_153:
				num = (short)1250361363;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_24C:
				num = (short)1669857280;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3F2:
				num = (short)971243538;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4D6:
				num = (short)325976071;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_316:
			A_0.an().CloseWaitTimeout = (int)A_1.k.@as().aw() * global::Motorola.Common.Communication.RUDP.c.w;
		}

		// Token: 0x040000DD RID: 221
		private static global::Motorola.Common.Communication.RUDP.States.a b;
	}
}
