using System;
using System.Runtime.CompilerServices;
using System.Threading;
using SSLMangrComp.ConnectionLayer;
using SSLMangrComp.Packets;

namespace SSLMangrComp
{
	// Token: 0x02000020 RID: 32
	public sealed class PresenceInfo
	{
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060000C9 RID: 201 RVA: 0x0000C690 File Offset: 0x0000A890
		// (remove) Token: 0x060000CA RID: 202 RVA: 0x0000C7C4 File Offset: 0x0000A9C4
		public event global::SSLMangrComp.PresenceInfo_CallBack PresenceCallBack
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::SSLMangrComp.PresenceInfo_CallBack presenceInfo_CallBack;
				for (;;)
				{
					IL_0A:
					global::SSLMangrComp.PresenceInfo_CallBack presenceInfo_CallBack2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_3A;
					case 2:
					{
						num2 = (short)983290576;
						short num3 = num2;
						num2 = (short)372626128;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)414908416;
							if (num2 != 0)
							{
							}
							if (presenceInfo_CallBack != presenceInfo_CallBack2)
							{
								goto IL_3A;
							}
							break;
						}
						num2 = (short)667942913;
						if (num2 != 0)
						{
						}
						num2 = (short)170786816;
						short num4 = num2;
						num2 = (short)1874264064;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_1C;
					IL_3A:
					presenceInfo_CallBack2 = presenceInfo_CallBack;
					global::SSLMangrComp.PresenceInfo_CallBack value2 = (global::SSLMangrComp.PresenceInfo_CallBack)global::System.Delegate.Combine(presenceInfo_CallBack2, value);
					presenceInfo_CallBack = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.PresenceInfo_CallBack>(ref this.b, value2, presenceInfo_CallBack2);
					num2 = (short)1540620290;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				presenceInfo_CallBack = this.b;
				num2 = (short)610861057;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::SSLMangrComp.PresenceInfo_CallBack presenceInfo_CallBack;
				for (;;)
				{
					IL_0A:
					global::SSLMangrComp.PresenceInfo_CallBack presenceInfo_CallBack2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_39;
					case 2:
					{
						num2 = (short)1970297776;
						short num3 = num2;
						num2 = (short)1847221168;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)597098496;
							if (num2 != 0)
							{
							}
							if (presenceInfo_CallBack != presenceInfo_CallBack2)
							{
								goto IL_39;
							}
							break;
						}
						num2 = (short)537788417;
						if (num2 != 0)
						{
						}
						num2 = (short)2121334784;
						short num4 = num2;
						num2 = (short)1057226752;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_1C;
					IL_39:
					presenceInfo_CallBack2 = presenceInfo_CallBack;
					global::SSLMangrComp.PresenceInfo_CallBack value2 = (global::SSLMangrComp.PresenceInfo_CallBack)global::System.Delegate.Remove(presenceInfo_CallBack2, value);
					presenceInfo_CallBack = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.PresenceInfo_CallBack>(ref this.b, value2, presenceInfo_CallBack2);
					num2 = (short)776601602;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				presenceInfo_CallBack = this.b;
				num2 = (short)441253889;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000C8F8 File Offset: 0x0000AAF8
		public PresenceInfo()
		{
			this.PresenceCallBack += this.CallPresenceInfoCallback;
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000C920 File Offset: 0x0000AB20
		public static global::SSLMangrComp.PresenceInfo Instance
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)364483473;
				short num2 = num;
				num = (short)1314034577;
				switch (num2 == num)
				{
				}
				num = (short)392036353;
				if (num != 0)
				{
				}
				num = (short)1839595520;
				short num3 = num;
				num = (short)2085093376;
				if (num != 0)
				{
				}
				return global::SSLMangrComp.PresenceInfo.c;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000C9CC File Offset: 0x0000ABCC
		public void SendPresenceInfo(global::SSLMangrComp.PresenceInfo_CallBack cb)
		{
			short num = (short)788594689;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 2:
				{
					for (;;)
					{
						this.a = cb;
						num = (short)300279079;
						short num3 = num;
						num = (short)2082006311;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_B3;
						}
					}
					IL_B3:
					num = (short)1305935872;
					if (num != 0)
					{
					}
					num = (short)2012217344;
					short num4 = num;
					num = (short)1360330752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_32:
				num = (short)630390785;
				if (num != 0)
				{
				}
				if (cb == null)
				{
					break;
				}
				num = (short)1122107394;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000CAE8 File Offset: 0x0000ACE8
		public void ResetPresenceNotification()
		{
			short num = (short)1116439386;
			short num2 = num;
			num = (short)1453163354;
			switch (num2 == num)
			{
			}
			num = (short)1078132737;
			if (num != 0)
			{
			}
			num = (short)1764032512;
			short num3 = num;
			num = (short)822476800;
			if (num != 0)
			{
			}
			global::SSLMangrComp.PresenceNotification presenceNotification = new global::SSLMangrComp.PresenceNotification();
			presenceNotification.DeviceId = string.Empty;
			presenceNotification.EntityType = string.Empty;
			presenceNotification.EventValue = global::SSLMangrComp.RequestEvent.Unknown;
			presenceNotification.IPAddr = string.Empty;
			presenceNotification.PresenceState = global::SSLMangrComp.PresenceState.Unknown;
			presenceNotification.SubscriptionState = string.Empty;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000CBD4 File Offset: 0x0000ADD4
		public global::SSLMangrComp.PresenceNotification SendPresenceNotification(global::SSLMangrComp.Packets.PacketBase packet)
		{
			int a_ = 18;
			short num = (short)762773504;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_CD;
				}
				global::SSLMangrComp.PresenceNotification presenceNotification;
				for (;;)
				{
					IL_32:
					int num3;
					switch (num2)
					{
					case 0:
					{
						string text;
						if (!(text == global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("Ճ㉅㱇㡉╋ⱍ╏♑ㅓ繕ࡗ⡙㥛ⵝ՟ౡݣͥ䅧", a_)))
						{
							num = (short)39583766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1263796228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						string[,] allParameters = packet.GetAllParameters();
						num3 = 0;
						num = (short)937230356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						string text;
						if (!(text == global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("Ń⡅㱇⍉㡋㝍", a_)))
						{
							num = (short)2064121886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[,] allParameters;
						presenceNotification.DeviceId = allParameters[num3, 1];
						num = (short)594739229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_271;
					case 4:
					{
						string[,] allParameters;
						if (allParameters[num3, 1] == global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("瑃", a_))
						{
							num = (short)736624675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)859832332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_271;
					case 6:
					{
						string text;
						if (!(text == global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("Ńぅⵇ⑉㡋", a_)))
						{
							num = (short)1309147157;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)962723867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1423376395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_271;
					case 9:
						num = (short)1385955329;
						if (num != 0)
						{
						}
						goto IL_3AE;
					case 10:
					{
						string text;
						if (!(text == global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("ᝃ㍅⩇㥉⽋㱍㥏≑⁓㽕㝗㑙籛൝ᑟ͡ၣͥ", a_)))
						{
							num = (short)189792263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[,] allParameters;
						presenceNotification.SubscriptionState = allParameters[num3, 1];
						num = (short)183435272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						string text;
						if (!(text == global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("Ń⡅㱇⍉㡋㝍灏ّⵓ♕㵗", a_)))
						{
							num = (short)83361809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[,] allParameters;
						presenceNotification.EntityType = allParameters[num3, 1];
						num = (short)699334684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						string[,] allParameters;
						if (allParameters[num3, 1] == global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("畃", a_))
						{
							num = (short)386072602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						presenceNotification.PresenceState = global::SSLMangrComp.PresenceState.Absent;
						num = (short)1562378256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						string[,] allParameters;
						if (num3 < allParameters.Length / 2)
						{
							string text = allParameters[num3, 0];
							num = (short)1416757258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1926177193;
						short num4 = num;
						num = (short)1035936169;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_712;
						default:
							num = (short)987693056;
							if (num != 0)
							{
							}
							num = (short)1607335972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 14:
						goto IL_271;
					case 15:
						goto IL_712;
					case 16:
					{
						num = (short)405340160;
						short num5 = num;
						goto IL_271;
					}
					case 17:
						num = (short)734003202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_271;
					case 19:
					{
						string text;
						if (!(text == global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("Ճ㉅㱇㡉╋ⱍ╏♑ㅓ繕ᅗਖ਼⩛橝䥟", a_)))
						{
							num = (short)52428833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[,] allParameters;
						presenceNotification.IPAddr = allParameters[num3, 1];
						num = (short)443023385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_3AE;
					case 21:
						num = (short)819068928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)2126446597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						presenceNotification.EventValue = global::SSLMangrComp.RequestEvent.Presence;
						num = (short)740229151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						string[,] allParameters;
						if (allParameters[num3, 1] == global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("ᑃ㑅ⵇ㥉⥋⁍㍏㝑", a_))
						{
							num = (short)281346071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						presenceNotification.EventValue = global::SSLMangrComp.RequestEvent.Absence;
						num = (short)2110586883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_271;
					case 26:
						presenceNotification.PresenceState = global::SSLMangrComp.PresenceState.Present;
						num = (short)712769554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
					{
						string[,] allParameters;
						if (allParameters[num3, 1] == global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("Ճ╅⍇", a_))
						{
							num = (short)1208811552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)595787800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						goto IL_271;
					case 29:
						goto IL_271;
					case 30:
						num = (short)553713683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_271;
					case 32:
						presenceNotification.EventValue = global::SSLMangrComp.RequestEvent.Ack;
						num = (short)1720123406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)2084241414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (packet != null)
						{
							num = (short)1283850241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return presenceNotification;
					case 35:
						presenceNotification.PresenceState = global::SSLMangrComp.PresenceState.Unknown;
						num = (short)1127809039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						return presenceNotification;
					}
					goto IL_CD;
					IL_271:
					num3++;
					num = (short)1476853769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_712:
					goto IL_271;
					IL_3AE:
					num = (short)195756045;
					num2 = (int)((global::System.IntPtr)num);
				}
				return presenceNotification;
				IL_CD:
				presenceNotification = new global::SSLMangrComp.PresenceNotification();
				num = (short)1103953954;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000D2FC File Offset: 0x0000B4FC
		public void CallPresenceInfoCallback(ref global::SSLMangrComp.PresenceNotification pn)
		{
			short num = (short)1732182017;
			if (num != 0)
			{
			}
			num = (short)1334956328;
			short num2 = num;
			num = (short)354079016;
			switch (num2 == num)
			{
			}
			num = (short)838664192;
			short num3 = num;
			num = (short)251133952;
			if (num != 0)
			{
			}
			global::SSLMangrComp.PresenceInfo_CallBack presenceInfo_CallBack = this.a;
			if (presenceInfo_CallBack == null)
			{
				return;
			}
			presenceInfo_CallBack(ref pn);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000D3BC File Offset: 0x0000B5BC
		// Note: this type is marked as 'beforefieldinit'.
		static PresenceInfo()
		{
			short num = (short)727809098;
			short num2 = num;
			num = (short)375749706;
			switch (num2 == num)
			{
			}
			num = (short)1147469825;
			if (num != 0)
			{
			}
			num = (short)1980956672;
			short num3 = num;
			num = (short)1648492544;
			if (num != 0)
			{
			}
			global::SSLMangrComp.PresenceInfo.c = new global::SSLMangrComp.PresenceInfo();
		}

		// Token: 0x04000072 RID: 114
		private global::SSLMangrComp.PresenceInfo_CallBack a;

		// Token: 0x04000073 RID: 115
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.PresenceInfo_CallBack b;

		// Token: 0x04000074 RID: 116
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static readonly global::SSLMangrComp.PresenceInfo c;
	}
}
