using System;
using SSLMangrComp.ConnectionLayer;

namespace SSLMangrComp.Packets
{
	// Token: 0x02000025 RID: 37
	public class KeepAlive : global::SSLMangrComp.Packets.PacketBase
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000DBFC File Offset: 0x0000BDFC
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0000DCB8 File Offset: 0x0000BEB8
		public global::SSLMangrComp.Packets.KeepAliveType T
		{
			get
			{
				short num = (short)1476965092;
				short num2 = num;
				num = (short)719434468;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1080492032;
					if (num != 0)
					{
					}
					if (base.MessageID != 10)
					{
						num = (short)1069416448;
						short num3 = num;
						return global::SSLMangrComp.Packets.KeepAliveType.Ack;
					}
					break;
				}
				num = (short)1251278849;
				if (num != 0)
				{
				}
				return global::SSLMangrComp.Packets.KeepAliveType.Request;
			}
			set
			{
				short num = (short)975275851;
				short num2 = num;
				num = (short)1614382923;
				switch (num2 == num)
				{
				}
				num = (short)1501102081;
				if (num != 0)
				{
				}
				num = (short)601423872;
				short num3 = num;
				num = (short)2071396352;
				if (num != 0)
				{
				}
				base.MessageID = ((value == global::SSLMangrComp.Packets.KeepAliveType.Request) ? 10 : 11);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000DD78 File Offset: 0x0000BF78
		public override byte[] getData()
		{
			short num = (short)461611174;
			short num2 = num;
			num = (short)1358667942;
			switch (num2 == num)
			{
			}
			num = (short)447217665;
			if (num != 0)
			{
			}
			num = (short)1208090624;
			short num3 = num;
			num = (short)1610940416;
			if (num != 0)
			{
			}
			return new byte[]
			{
				base.MessageID,
				(byte)(base.DialogID % 256),
				(byte)((base.DialogID - base.DialogID % 256) / 256)
			};
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000DE5C File Offset: 0x0000C05C
		public override string getPacketDescription()
		{
			int a_ = 2;
			short num = (short)860243538;
			short num2 = num;
			num = (short)132400722;
			switch (num2 == num)
			{
			}
			num = (short)1960509441;
			if (num != 0)
			{
			}
			num = (short)237305856;
			short num3 = num;
			num = (short)1697316864;
			if (num != 0)
			{
			}
			return global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("缳匵崷䨹紻刽⤿㑁⅃晅", a_) + this.T.ToString();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000DF38 File Offset: 0x0000C138
		public override string[,] GetAllParameters()
		{
			int a_ = 15;
			short num = (short)138972793;
			short num2 = num;
			num = (short)46501497;
			switch (num2 == num)
			{
			}
			num = (short)1674706945;
			if (num != 0)
			{
			}
			num = (short)34471936;
			short num3 = num;
			num = (short)8912896;
			if (num != 0)
			{
			}
			string[,] array = new string[3, 2];
			int num4 = 0;
			array[num4, 0] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("ీ♂㙄㑆⡈ⱊ⡌潎ᡐᝒ", a_);
			array[num4++, 1] = base.MessageID.ToString();
			array[num4, 0] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("Հ⩂⑄⭆♈ⱊ浌َᕐ", a_);
			array[num4++, 1] = ((uint)base.DialogID).ToString();
			array[num4, 0] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("ᕀ㩂㕄≆", a_);
			array[num4++, 1] = this.T.ToString();
			return array;
		}
	}
}
