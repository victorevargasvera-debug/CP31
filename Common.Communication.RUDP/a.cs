using System;
using System.Net;
using System.Net.Sockets;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000003 RID: 3
	internal class a
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public a()
		{
			int a_ = 7;
			base..ctor();
			try
			{
				this.a = new global::System.Net.Sockets.Socket(global::System.Net.Sockets.AddressFamily.InterNetwork, global::System.Net.Sockets.SocketType.Dgram, global::System.Net.Sockets.ProtocolType.Udp);
				this.a.DontFragment = true;
				this.a.SetSocketOption(global::System.Net.Sockets.SocketOptionLevel.Socket, global::System.Net.Sockets.SocketOptionName.ReceiveBuffer, (int)global::Motorola.Common.Communication.RUDP.c.j);
				this.a.SetSocketOption(global::System.Net.Sockets.SocketOptionLevel.Socket, global::System.Net.Sockets.SocketOptionName.SendBuffer, (int)global::Motorola.Common.Communication.RUDP.c.i);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("礪砬欮愰ጲ瘴䔶尸娺䤼嘾⹀ⵂ敄ņ⡈≊⅌⩎㕐楒畔ⱖ楘♚", a_), new object[]
				{
					ex.Message
				});
				this.a.Close();
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_RawSocketCreationFailed);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021DC File Offset: 0x000003DC
		public int a(byte[] A_0, int A_1, int A_2, global::System.Net.Sockets.SocketFlags A_3, global::System.Net.EndPoint A_4)
		{
			int a_ = 18;
			short num = (short)1945528288;
			short num2 = num;
			num = (short)539650016;
			int result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)890437633;
				if (num != 0)
				{
				}
				num = (short)452853760;
				if (num != 0)
				{
				}
				num = (short)480444416;
				short num3 = num;
				result = -1;
				try
				{
					result = this.a.SendTo(A_0, A_1, A_2, A_3, A_4);
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("搵洷縹氻ḽᐿ㩁摃ͅ㩇㡉⍋㱍橏牑", a_) + ex.Message, global::System.Array.Empty<object>());
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022E8 File Offset: 0x000004E8
		public int a(byte[] A_0, int A_1, int A_2, global::System.Net.Sockets.SocketFlags A_3, ref global::System.Net.EndPoint A_4)
		{
			int a_ = 19;
			short num = (short)691406913;
			short num2 = num;
			num = (short)986384449;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1187250177;
				if (num != 0)
				{
				}
				num = (short)1950810112;
				if (num != 0)
				{
				}
				num = (short)356581376;
				short num3 = num;
				num4 = -1;
				try
				{
					num4 = this.a.ReceiveFrom(A_0, A_1, A_2, A_3, ref A_4);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("收永缺洼Ἶፀ㭂罄杆Ո⹊⍌牎⩐捒⡔", a_), new object[]
					{
						num4
					});
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("收永缺洼Ἶፀ㭂敄Ɇ㭈㥊≌㵎歐獒", a_) + ex.Message, global::System.Array.Empty<object>());
				}
				break;
			}
			}
			return num4;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002418 File Offset: 0x00000618
		public global::System.IAsyncResult a(byte[] A_0, int A_1, int A_2, global::System.Net.Sockets.SocketFlags A_3, ref global::System.Net.EndPoint A_4, global::System.AsyncCallback A_5, object A_6)
		{
			int a_ = 12;
			short num = (short)1678501520;
			short num2 = num;
			num = (short)281339536;
			global::System.IAsyncResult result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1796014080;
				if (num != 0)
				{
				}
				num = (short)1651703809;
				if (num != 0)
				{
				}
				num = (short)1541865472;
				short num3 = num;
				result = null;
				try
				{
					result = this.a.BeginReceiveFrom(A_0, A_1, A_2, A_3, ref A_4, A_5, A_6);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("戯朱瀳昵ᠷ笹伻䜽⸿⅁摃ᑅぇ灉汋ᵍ⑏㍑♓≕癗瑙牛", a_), global::System.Array.Empty<object>());
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("戯朱瀳昵ᠷ笹伻䜽⸿⅁摃ᕅ㱇⭉㹋㩍灏Qⱓ癕ᵗ⡙⹛ㅝ቟塡䑣", a_) + ex.Message, global::System.Array.Empty<object>());
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002540 File Offset: 0x00000740
		public int a(global::System.IAsyncResult A_0, ref global::System.Net.EndPoint A_1)
		{
			int a_ = 1;
			short num = (short)637051744;
			short num2 = num;
			num = (short)1112384352;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1267990529;
				if (num != 0)
				{
				}
				num = (short)679346176;
				if (num != 0)
				{
				}
				num = (short)1399324672;
				short num3 = num;
				num4 = 0;
				try
				{
					num4 = this.a.EndReceiveFrom(A_0, ref A_1);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("眤爦洨笪ബ渮䈰䨲嬴吶ᤸ縺匼嬾慀ᅂ㵄絆楈❊⡌ⅎ煐湒畔ⱖ楘♚", a_), new object[]
					{
						num4
					});
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("眤爦洨笪ബ渮䈰䨲嬴吶ᤸ縺匼嬾慀ᅂ㵄杆ై㥊㽌⁎⍐楒畔", a_) + ex.Message, global::System.Array.Empty<object>());
				}
				break;
			}
			}
			return num4;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000266C File Offset: 0x0000086C
		public void a()
		{
			short num = (short)967770112;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_15;
				case 1:
				{
					num = (short)604058953;
					short num3 = num;
					num = (short)821179721;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)521207809;
						if (num != 0)
						{
						}
						num = (short)32178176;
						if (num != 0)
						{
						}
						this.a.Close();
						this.a.Dispose();
						this.a = null;
						num = (short)955973634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_F9;
				}
				goto IL_31;
				IL_15:
				switch (0)
				{
				case 0:
					IL_31:
					if (this.a == null)
					{
						goto IL_FB;
					}
					num = (short)257687553;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_F9:
			IL_FB:
			num = (short)1066336256;
			short num4 = num;
		}

		// Token: 0x04000003 RID: 3
		private global::System.Net.Sockets.Socket a;
	}
}
