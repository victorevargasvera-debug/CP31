using System;
using System.Net;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000013 RID: 19
	public static class Utilities
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00009360 File Offset: 0x00007560
		public static global::System.Net.IPAddress GetIPAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			int a_ = 10;
			short num = (short)1818624005;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14A;
				case 1:
					goto IL_2EA;
				case 2:
					goto IL_215;
				case 3:
				{
					if (string.IsNullOrEmpty(deviceInfo.ConnectionInfo.UniqueAddress))
					{
						num = (short)970457099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)429064192;
					short num3 = num;
					num = (short)1188954127;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("୞ॠᅢ੤ၦhժ੬佮㡰ᵲʹᙶᕸቺ᥼㙾톀슂ﮈﺌﲎ놐횒ﲘ캠춢龤螦쒪쎬솮풰킲솴\udeb6횸햺톾Ꟁ곂ꇆꛈ맊믎말뫒ꛔꯘ뫚맜뛞軠쏢賤铦짨藪飬菮鷰\uddf2헴ꗶ飸鿺铼郾℀倂怄甆怈樊愌䄎搐縒眔爖欘ℚ㴜", a_) + deviceInfo.SerialNumber + global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("罞㍠ɢŤ๦٨䭪⑬⭮䭰卲", a_) + deviceInfo.RadioID, global::System.Array.Empty<object>());
					num = (short)1056505856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_7D;
					}
					continue;
				case 6:
					goto IL_F1;
				case 7:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("୞ॠᅢ੤ၦhժ੬佮㡰ᵲʹᙶᕸቺ᥼㙾톀슂ﮈﺌﲎ놐횒ﲘ캠춢龤螦令쪪\udfac\udcae풰ힲ閴ﺶ鮺ﲼ\udbbeꗀ뇂ꃄ듆뫈ꯌ뷎뻐뻒苖럘닚곜꫞蓠ꋢ臤菦鯨軪黬鳮퇰髲蛴ퟶ郸闺诼黾洀樂愄✆漈搊缌⼎攐笒簔搖㤘椚簜笞䠠䰢ତܦ笨䨪䤬䘮帰ጲ昴制䬸刺尼匾ཀ㙂⡄╆ⱈ㥊睌潎", a_) + deviceInfo.SerialNumber + global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("罞㍠ɢŤ๦٨䭪⑬⭮䭰卲", a_) + deviceInfo.RadioID, global::System.Array.Empty<object>());
					num = (short)447479810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (deviceInfo.ConnectionInfo == null)
					{
						num = (short)1985413124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1549467651;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1270808593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_3E1;
				case 11:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("୞ॠᅢ੤ၦhժ੬佮㡰ᵲʹᙶᕸቺ᥼㙾톀슂ﮈﺌﲎ놐횒ﲘ캠춢龤螦ﲨ얪쒬\udeae쒰횲펶\uddb8즺\ud8bc첾닀계꧆裊ꋌꇎ뿐뛒뛔ꏖ냘듚돜雞迠藢諤쟦迨蓪鿬쿮藰鯲鳴蓶\ud9f8觺鳼鯾栀氂┄渆稈⬊挌税紐缒㬔㜖䬘稚礜瘞丠̢瘤䈦嬨䈪䰬䌮缰䘲場唶尸䤺ܼἾ", a_) + deviceInfo.SerialNumber + global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("罞㍠ɢŤ๦٨䭪⑬⭮䭰卲", a_) + deviceInfo.RadioID, global::System.Array.Empty<object>());
					num = (short)1421606918;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("୞ॠᅢ੤ၦhժ੬佮㡰ᵲʹᙶᕸቺ᥼㙾톀슂ﮈﺌﲎ놐횒ﲘ캠춢龤螦캪\udbac욮튰횲ﲴ\ud9b6\udfb8풺鶼\ud9be껀뇂돆ꇈꋊ뻌ꏐ닒뇔뻖뛘ﯚ드곞쇠跢郤详藨엪췬뫮鿰鋲韴鯶鳸\udbfa觼郾℀焂怄猆笈戊栌礎琐㌒簔猖簘甚検瘞䜠䨢䘤䘦崨䈪䈬䄮ᄰ唲娴䔶ᤸ䤺尼嬾⡀ⱂ敄♆㩈歊ⱌ潎⍐㙒♔≖㕘⽚獜", a_), global::System.Array.Empty<object>());
					num = (short)1672151041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)1787232272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (deviceInfo.ConnectionInfo != null)
					{
						num = (short)1025835021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E1;
				case 15:
				{
					global::System.Net.IPAddress result;
					if (!global::System.Net.IPAddress.TryParse(deviceInfo.ConnectionInfo.UniqueAddress, out result))
					{
						num = (short)2067922951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AF;
				}
				case 16:
					if (!string.IsNullOrEmpty(deviceInfo.ConnectionInfo.UniqueAddress))
					{
						num = (short)1861943305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E1;
				case 17:
				{
					global::System.Net.IPAddress result;
					if (!global::System.Net.IPAddress.TryParse(deviceInfo.ConnectionInfo.UniqueAddress, out result))
					{
						num = (short)245956618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				case 18:
				{
					num = (short)1310069378;
					short num4 = num;
					num = (short)440406658;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1598029824;
						if (num != 0)
						{
						}
						if (deviceInfo == null)
						{
							num = (short)1878130700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					num = (short)1477312520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 19:
					num = (short)960299022;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7D:
				if (deviceInfo != null)
				{
					num = (short)629997587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3E1:
				num = (short)1108410386;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F1:
			goto IL_2AF;
			IL_14A:
			num = (short)1719861249;
			if (num != 0)
			{
			}
			IL_215:
			IL_2AF:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidIPAddress);
			IL_2EA:
			goto IL_2AF;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000097D8 File Offset: 0x000079D8
		public static int GetFxPPort(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)660078592;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num3;
			int result;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					num = (short)280100865;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI)
					{
						num = (short)660733955;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
					num = (short)1325400065;
					if (num != 0)
					{
					}
					result = 0;
					num = (short)1855651842;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1221459973;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (deviceInfo.ConnectionInfo != null)
					{
						num = (short)2111045632;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 6:
				{
					num = (short)1958632549;
					short num4 = num;
					num = (short)1262181477;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1959919616;
						if (num != 0)
						{
						}
						if (deviceInfo != null)
						{
							num = (short)1604517892;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					break;
				}
				}
				goto IL_55;
			}
			return result;
			IL_55:
			result = 4070;
			num = (short)308543494;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000998C File Offset: 0x00007B8C
		public static int GetPort(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			int result;
			for (;;)
			{
				IL_00:
				short num = (short)182845449;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (deviceInfo.ConnectionInfo != null)
						{
							num = (short)767819777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 8002;
					case 1:
						num = (short)823525384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1903558660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return result;
					case 4:
						if (deviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI)
						{
							num = (short)1093402629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 8002;
					case 5:
						num = (short)236388358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						num = (short)433455104;
						short num3 = num;
						if (int.TryParse(deviceInfo.ConnectionInfo.Location, out result))
						{
							num = (short)897056771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 8002;
					}
					case 7:
						num = (short)634716160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!string.IsNullOrEmpty(deviceInfo.ConnectionInfo.Location))
						{
							num = (short)839843842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 8002;
					case 9:
						num = (short)1304690689;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_73;
						}
						continue;
					}
					IL_73:
					if (deviceInfo == null)
					{
						return 8002;
					}
					num = (short)1881050768;
					short num4 = num;
					num = (short)526487184;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)427229184;
						if (num != 0)
						{
						}
						num = (short)531759111;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			return result;
		}
	}
}
