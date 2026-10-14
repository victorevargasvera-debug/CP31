using System;
using System.IO;
using SSLMangrComp.ConnectionLayer;

namespace SSLMangrComp.Packets
{
	// Token: 0x0200002B RID: 43
	public class ReliableSubscriptionPacket : global::SSLMangrComp.Packets.SubscriptionPacket
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00010428 File Offset: 0x0000E628
		public ReliableSubscriptionPacket(ushort dialogId, int tcpPort, int expiry, global::SSLMangrComp.Packets.EntitiesTypes entitiesType, string entitieValues, string events)
		{
			base.MessageID = 3;
			base.DialogID = dialogId;
			this.a = tcpPort;
			this.Expiry = expiry;
			this.EntitiesType = entitiesType;
			this.EntitiesValue = entitieValues;
			this.EventsValue = events;
			if (expiry <= 0)
			{
				this.PacketSubscriptionType = global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.OneTimeSubscription;
				return;
			}
			this.PacketSubscriptionType = global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.Subscription;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00010484 File Offset: 0x0000E684
		public override byte[] getData()
		{
			short num = (short)1817951523;
			short num2 = num;
			num = (short)786939171;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2059993088;
				if (num != 0)
				{
				}
				num = (short)838533120;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_B9;
				}
				break;
			}
			}
			int num4;
			global::System.IO.MemoryStream memoryStream;
			for (;;)
			{
				IL_7F:
				num = (short)1201930241;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					base.EncodeTLV(memoryStream, 1, global::System.BitConverter.GetBytes(this.Expiry));
					num = (short)1143930882;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.Expiry >= 0)
					{
						num = (short)558694400;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_143;
				case 2:
					goto IL_141;
				}
				goto IL_B9;
			}
			IL_141:
			IL_143:
			base.EncodeTLV(memoryStream, 6, global::System.BitConverter.GetBytes(this.a));
			base.EncodeTLV(memoryStream, (byte)this.EntitiesType, this.EntitiesValue);
			base.EncodeTLV(memoryStream, 2, this.EventsValue);
			return memoryStream.ToArray();
			IL_B9:
			memoryStream = new global::System.IO.MemoryStream();
			memoryStream.WriteByte(base.MessageID);
			memoryStream.Write(global::System.BitConverter.GetBytes(base.DialogID), 0, 2);
			num = (short)1719730177;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7F;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00010610 File Offset: 0x0000E810
		public override string getPacketDescription()
		{
			int a_ = 17;
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
						goto IL_154;
					case global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.RefreshSubscription:
					{
						num2 = (short)1666449703;
						short num3 = num2;
						num2 = (short)141033767;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_92;
						default:
							goto IL_108;
						}
						break;
					}
					case global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.CancelSubscription:
						goto IL_97;
					case global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.OneTimeSubscription:
						goto IL_145;
					default:
						num2 = (short)447021057;
						if (num2 != 0)
						{
						}
						num2 = (short)1682964482;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 1:
					goto IL_143;
				case 2:
					goto IL_92;
				}
				goto IL_25;
				IL_92:
				num2 = (short)2129264641;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_97:
			num2 = (short)907870208;
			short num4 = num2;
			return global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("ᅂ⁄⭆⁈⩊⽌⍎㑐獒ᙔ㙖㝘㡚㡜㍞䅠ぢၤզᩨࡪὬٮŰݲᱴᡶ᝸孺ぼ᩾", a_);
			IL_108:
			num2 = (short)173735936;
			if (num2 != 0)
			{
			}
			return global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("ᅂ⁄⭆⁈⩊⽌⍎㑐獒ݔ㉖㽘⥚㡜ⱞॠ䍢㙤ቦ୨ᡪ๬ᵮᡰͲŴṶᙸᕺ嵼㉾", a_);
			IL_143:
			return global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("ᙂ⭄ⱆ❈⑊㩌ⅎ", a_);
			IL_145:
			return global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("ᅂ⁄⭆⁈⩊⽌⍎㑐獒ᩔ㥖㱘癚ड़㙞ౠ٢䕤㑦ᱨ४Ṭ౮ͰᩲմͶၸᑺ፼彾첀", a_);
			IL_154:
			return global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("ᅂ⁄⭆⁈⩊⽌⍎㑐獒ٔ≖㭘⡚㹜ⵞࡠ።ᅤ๦٨ժ䵬≮ᑰrٴᙶṸṺ", a_);
			IL_25:
			packetSubscriptionType = this.PacketSubscriptionType;
			num2 = (short)1691484160;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00010790 File Offset: 0x0000E990
		public override string[,] GetAllParameters()
		{
			int a_ = 7;
			short num = (short)799801344;
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
						goto IL_307;
					case 1:
						goto IL_1E1;
					case 2:
						goto IL_231;
					case 3:
						goto IL_1FE;
					case 4:
						switch (entitiesType)
						{
						case global::SSLMangrComp.Packets.EntitiesTypes.DeviceID:
						{
							array[4, 1] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("紸帺䬼嘾≀♂敄ๆൈ", a_);
							num = (short)996056320;
							short num3 = num;
							num = (short)1452317952;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_332;
							default:
								num = (short)1425604609;
								if (num != 0)
								{
								}
								num = (short)355729408;
								if (num != 0)
								{
								}
								num = (short)1398603782;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case global::SSLMangrComp.Packets.EntitiesTypes.DeviceName:
							array[4, 1] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("紸帺䬼嘾≀♂敄ॆ⡈♊⡌", a_);
							num = (short)1959788545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::SSLMangrComp.Packets.EntitiesTypes.UserName:
							array[4, 1] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("永䠺堼䴾慀ൂ⑄⩆ⱈ", a_);
							num = (short)1707868160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::SSLMangrComp.Packets.EntitiesTypes.IPv4:
							array[4, 1] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("瀸欺䬼ା慀ɂ⅄⍆㭈⹊㹌㱎", a_);
							num = (short)821231623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case (global::SSLMangrComp.Packets.EntitiesTypes)14:
							goto IL_332;
						case global::SSLMangrComp.Packets.EntitiesTypes.TalkGroupID:
							array[4, 1] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("洸娺儼吾ـㅂ⩄㉆㥈歊ь୎", a_);
							num = (short)1628700674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)771358725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 5:
						num = (short)1387331587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_2D6;
					case 7:
						goto IL_1AE;
					}
					goto IL_57;
				}
				IL_1AE:
				IL_1E1:
				IL_1FE:
				IL_231:
				IL_2D6:
				goto IL_332;
				IL_307:
				num = (short)1619394560;
				short num4 = num;
				IL_332:
				array[5, 0] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("簸唺䤼嘾㕀⩂⁄㑆楈ᵊⱌ⍎⑐㙒♔", a_);
				array[5, 1] = this.EntitiesValue;
				array[6, 0] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("簸䴺堼儾㕀あ", a_);
				array[6, 1] = this.EventsValue;
				return array;
				IL_57:
				array = new string[7, 2];
				array[0, 0] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("琸帺丼䰾⁀⑂⁄杆Hཊ", a_);
				array[0, 1] = base.MessageID.ToString();
				array[1, 0] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("紸刺尼匾⹀⑂敄ๆൈ", a_);
				array[1, 1] = base.DialogID.ToString();
				array[2, 0] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("洸砺洼Ἶᅀⱂ㝄㍆楈Պ㡌≎㍐㙒❔", a_);
				array[2, 1] = this.a.ToString();
				array[3, 0] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("簸䌺䴼嘾㍀㩂敄潆㩈⹊⹌⁎㽐㝒♔繖", a_);
				array[3, 1] = this.Expiry.ToString();
				array[4, 0] = global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("簸唺䤼嘾㕀⩂⁄㑆楈㽊㑌㽎㑐", a_);
				entitiesType = this.EntitiesType;
				num = (short)393216004;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00010B18 File Offset: 0x0000ED18
		public override global::SSLMangrComp.Packets.SubscriptionPacket CreateRefreshSubscription(int newExpiry)
		{
			short num = (short)595067316;
			short num2 = num;
			num = (short)642384308;
			switch (num2 == num)
			{
			}
			num = (short)1306984449;
			if (num != 0)
			{
			}
			num = (short)33161216;
			if (num != 0)
			{
			}
			num = (short)1750794240;
			short num3 = num;
			return new global::SSLMangrComp.Packets.ReliableSubscriptionPacket(base.DialogID, this.a, newExpiry, this.EntitiesType, this.EntitiesValue, this.EntitiesValue)
			{
				Type = base.Type,
				PacketSubscriptionType = global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.RefreshSubscription
			};
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00010BF8 File Offset: 0x0000EDF8
		public override global::SSLMangrComp.Packets.SubscriptionPacket CreateCancelSubscription()
		{
			short num = (short)1975382375;
			short num2 = num;
			num = (short)853471591;
			switch (num2 == num)
			{
			}
			num = (short)104267777;
			if (num != 0)
			{
			}
			num = (short)1347682304;
			if (num != 0)
			{
			}
			num = (short)1568735232;
			short num3 = num;
			return new global::SSLMangrComp.Packets.ReliableSubscriptionPacket(base.DialogID, this.a, 0, this.EntitiesType, this.EntitiesValue, this.EventsValue)
			{
				Type = base.Type,
				PacketSubscriptionType = global::SSLMangrComp.Packets.SubscriptionPacket.SubscribtionType.CancelSubscription
			};
		}

		// Token: 0x0400009B RID: 155
		private readonly int a;
	}
}
