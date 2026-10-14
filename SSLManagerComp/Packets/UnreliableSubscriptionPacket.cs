using System;
using System.IO;
using SSLMangrComp.ConnectionLayer;

namespace SSLMangrComp.Packets
{
	// Token: 0x02000030 RID: 48
	public class UnreliableSubscriptionPacket : global::SSLMangrComp.Packets.SubscriptionPacket
	{
		// Token: 0x06000117 RID: 279 RVA: 0x00010DA8 File Offset: 0x0000EFA8
		public UnreliableSubscriptionPacket(ushort dialogID, int Expiry, global::SSLMangrComp.Packets.EntitiesTypes entitiesType, string entitieValues, string events)
		{
			base.MessageID = 1;
			base.DialogID = dialogID;
			this.Expiry = Expiry;
			this.EntitiesType = entitiesType;
			this.EntitiesValue = entitieValues;
			this.EventsValue = events;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		public override byte[] getData()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::System.IO.MemoryStream memoryStream;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)891852680;
					short num3 = num2;
					num2 = (short)1149605768;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)179044352;
						short num4 = num2;
						num2 = (short)1176174592;
						if (num2 != 0)
						{
						}
						if (this.Expiry < 0)
						{
							goto IL_141;
						}
						break;
					}
					}
					num2 = (short)115343362;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_13F;
				case 2:
					num2 = (short)525205505;
					if (num2 != 0)
					{
					}
					base.EncodeTLV(memoryStream, 1, global::System.BitConverter.GetBytes(this.Expiry));
					num2 = (short)119144449;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_13F:
			IL_141:
			base.EncodeTLV(memoryStream, (byte)this.EntitiesType, this.EntitiesValue);
			base.EncodeTLV(memoryStream, 2, this.EventsValue);
			return memoryStream.ToArray();
			IL_1C:
			memoryStream = new global::System.IO.MemoryStream();
			memoryStream.WriteByte(base.MessageID);
			memoryStream.Write(global::System.BitConverter.GetBytes(base.DialogID), 0, 2);
			num2 = (short)671744000;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00010F60 File Offset: 0x0000F160
		public override string getPacketDescription()
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType packetSubscriptionType;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					switch (packetSubscriptionType)
					{
					case global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.Subscription:
						goto IL_152;
					case global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.RefreshSubscription:
					{
						num2 = (short)109969408;
						short num3 = num2;
						num2 = (short)843710465;
						if (num2 != 0)
						{
						}
						num2 = (short)1798171180;
						short num4 = num2;
						num2 = (short)903932460;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6B;
						default:
							goto IL_106;
						}
						break;
					}
					case global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.CancelSubscription:
						goto IL_70;
					case global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.OneTimeSubscription:
						goto IL_143;
					default:
						num2 = (short)1826881538;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 1:
					goto IL_141;
				case 2:
					goto IL_6B;
				}
				goto IL_25;
				IL_6B:
				num2 = (short)1684275201;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_70:
			return global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("昲嬴䔶尸场吼帾⍀⽂⁄杆ੈ⩊⍌ⱎ㑐㽒畔іⱘ㥚⹜㱞፠੢ᕤ፦hѪͬ佮㱰ᙲٴѶᡸᱺ᡼", a_);
			IL_106:
			num2 = (short)1617297408;
			if (num2 != 0)
			{
			}
			return global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("昲嬴䔶尸场吼帾⍀⽂⁄杆ᭈ⹊⭌㵎㑐⁒㵔睖੘⹚㽜ⱞɠᅢ౤ᝦᵨɪɬŮ兰㹲ၴѶ੸᩺᩼᩾", a_);
			IL_141:
			return global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("昲嬴尶圸吺䨼儾", a_);
			IL_143:
			return global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("昲嬴䔶尸场吼帾⍀⽂⁄杆و╊⡌扎Ր㩒㡔㉖祘࡚⡜㵞በbᝤ๦ᥨὪѬnὰ卲㡴ቶ੸ࡺᱼ᡾", a_);
			IL_152:
			return global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("昲嬴䔶尸场吼帾⍀⽂⁄杆ᩈ㹊⽌㱎㉐⅒㱔❖ⵘ㉚㉜ㅞ䅠⹢dᑦᩨ੪੬੮", a_);
			IL_25:
			packetSubscriptionType = this.PacketSubscriptionType;
			num2 = (short)65011712;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000110DC File Offset: 0x0000F2DC
		public override string[,] GetAllParameters()
		{
			int a_ = 5;
			short num = (short)1096220672;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_57;
				}
				global::SSLMangrComp.Packets.EntitiesTypes entitiesType;
				string[,] array;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_2B3;
					case 1:
						goto IL_1B3;
					case 2:
						goto IL_204;
					case 3:
						goto IL_1D1;
					case 4:
						switch (entitiesType)
						{
						case global::SSLMangrComp.Packets.EntitiesTypes.DeviceID:
						{
							array[3, 1] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("猶尸䴺吼尾⑀捂ౄ͆", a_);
							num = (short)1409171767;
							short num3 = num;
							num = (short)323895607;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2B5;
							default:
								num = (short)1146945536;
								if (num != 0)
								{
								}
								num = (short)1448607750;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case global::SSLMangrComp.Packets.EntitiesTypes.DeviceName:
							array[3, 1] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("猶尸䴺吼尾⑀捂ୄ♆⑈⹊", a_);
							num = (short)124715009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::SSLMangrComp.Packets.EntitiesTypes.UserName:
							array[3, 1] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("戶䨸帺似Ἶཀ≂⡄≆", a_);
							num = (short)1755578368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::SSLMangrComp.Packets.EntitiesTypes.IPv4:
							array[3, 1] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("縶椸䴺़Ἶ@❂⅄㕆ⱈ㡊㹌", a_);
							num = (short)1823997959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case (global::SSLMangrComp.Packets.EntitiesTypes)14:
							goto IL_2B5;
						case global::SSLMangrComp.Packets.EntitiesTypes.TalkGroupID:
							array[3, 1] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("挶堸场嘼砾㍀ⱂい㝆楈Ɋौ", a_);
							num = (short)2085879810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1543634949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 5:
						num = (short)450822147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_283;
					case 7:
						goto IL_180;
					}
					goto IL_57;
				}
				IL_180:
				IL_1B3:
				IL_1D1:
				IL_204:
				IL_283:
				IL_2B3:
				IL_2B5:
				num = (short)962330624;
				short num4 = num;
				num = (short)55902209;
				if (num != 0)
				{
				}
				array[4, 0] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("父圸伺吼䬾⡀♂㙄杆Ὀ⩊⅌㩎㑐⁒", a_);
				array[4, 1] = this.EntitiesValue;
				array[5, 0] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("父伸帺匼䬾㉀", a_);
				array[5, 1] = this.EventsValue;
				return array;
				IL_57:
				array = new string[6, 2];
				array[0, 0] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("稶尸䠺丼帾♀♂敄ๆൈ", a_);
				array[0, 1] = base.MessageID.ToString();
				array[1, 0] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("猶倸娺儼倾♀捂ౄ͆", a_);
				array[1, 1] = base.DialogID.ToString();
				array[2, 0] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("父䄸䬺吼䴾㡀捂浄㑆ⱈ⡊≌ⅎ㕐⁒籔", a_);
				array[2, 1] = this.Expiry.ToString();
				array[3, 0] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("父圸伺吼䬾⡀♂㙄杆㵈㉊㵌⩎", a_);
				entitiesType = this.EntitiesType;
				num = (short)2019098628;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00011438 File Offset: 0x0000F638
		public override global::SSLMangrComp.Packets.SubscriptionPacket CreateRefreshSubscription(int newExpiry)
		{
			short num = (short)1745395533;
			short num2 = num;
			num = (short)1302110029;
			switch (num2 == num)
			{
			}
			num = (short)958988289;
			if (num != 0)
			{
			}
			num = (short)1941962752;
			if (num != 0)
			{
			}
			num = (short)913047552;
			short num3 = num;
			return new global::SSLMangrComp.Packets.UnreliableSubscriptionPacket(base.DialogID, newExpiry, this.EntitiesType, this.EntitiesValue, this.EntitiesValue)
			{
				Type = base.Type,
				PacketSubscriptionType = global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.RefreshSubscription
			};
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00011514 File Offset: 0x0000F714
		public override global::SSLMangrComp.Packets.SubscriptionPacket CreateCancelSubscription()
		{
			short num = (short)1445199873;
			if (num != 0)
			{
			}
			num = (short)1562632966;
			short num2 = num;
			num = (short)2127291142;
			switch (num2 == num)
			{
			}
			num = (short)1474363392;
			if (num != 0)
			{
			}
			num = (short)1635778560;
			short num3 = num;
			return new global::SSLMangrComp.Packets.UnreliableSubscriptionPacket(base.DialogID, 0, this.EntitiesType, this.EntitiesValue, this.EntitiesValue)
			{
				Type = base.Type,
				PacketSubscriptionType = global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.CancelSubscription
			};
		}
	}
}
