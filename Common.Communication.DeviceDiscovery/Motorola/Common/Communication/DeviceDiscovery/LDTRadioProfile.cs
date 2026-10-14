using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000029 RID: 41
	public class LDTRadioProfile : global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile, global::System.IDisposable
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00010978 File Offset: 0x0000EB78
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00010A28 File Offset: 0x0000EC28
		public string IMEI
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)425460649;
				short num2 = num;
				num = (short)178586537;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1329397760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1035534337;
				if (num != 0)
				{
				}
				num = (short)1988362240;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1540021919;
				short num2 = num;
				num = (short)1547755167;
				switch (num2 == num)
				{
				default:
				{
					num = (short)935723008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1850867712;
				if (num != 0)
				{
				}
				num = (short)1096613889;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00010B88 File Offset: 0x0000ED88
		public string PasswordId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1510277121;
				if (num != 0)
				{
				}
				num = (short)258801664;
				short num2 = num;
				num = (short)1875452746;
				short num3 = num;
				num = (short)81273674;
				switch (num3 == num)
				{
				}
				num = (short)2094596096;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)129749261;
				short num2 = num;
				num = (short)2009321741;
				switch (num2 == num)
				{
				default:
				{
					num = (short)243793920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)963051520;
				if (num != 0)
				{
				}
				num = (short)1889271809;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00010C3C File Offset: 0x0000EE3C
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00010CF0 File Offset: 0x0000EEF0
		public string Password
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)15032796;
				short num2 = num;
				num = (short)98722268;
				switch (num2 == num)
				{
				default:
				{
					num = (short)335085568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)109641729;
				if (num != 0)
				{
				}
				num = (short)794951680;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1373372417;
				if (num != 0)
				{
				}
				num = (short)1577844736;
				short num2 = num;
				num = (short)1031800303;
				short num3 = num;
				num = (short)371394031;
				switch (num3 == num)
				{
				}
				num = (short)714473472;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00010DA4 File Offset: 0x0000EFA4
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00010E54 File Offset: 0x0000F054
		public string DomainName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2056139487;
				short num2 = num;
				num = (short)1215115999;
				switch (num2 == num)
				{
				default:
				{
					num = (short)769916928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)499777537;
				if (num != 0)
				{
				}
				num = (short)347537408;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)719485816;
				short num2 = num;
				num = (short)1661959032;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1395785728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1003552769;
				if (num != 0)
				{
				}
				num = (short)6029312;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00010F08 File Offset: 0x0000F108
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00010FB8 File Offset: 0x0000F1B8
		public global::Motorola.Common.Communication.CommonUtil.ProductFamily ProductFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1437733954;
				short num2 = num;
				num = (short)1739330626;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1799159808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)706805760;
				if (num != 0)
				{
				}
				num = (short)1047920641;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1590143435;
				short num2 = num;
				num = (short)1171368395;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1332150272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2131820544;
				if (num != 0)
				{
				}
				num = (short)303890433;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00011068 File Offset: 0x0000F268
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00011114 File Offset: 0x0000F314
		public bool TlsPsk
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)213860557;
				short num2 = num;
				num = (short)713965773;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1997799424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1142030337;
				if (num != 0)
				{
				}
				num = (short)1442709504;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)907739137;
				if (num != 0)
				{
				}
				num = (short)1699545088;
				short num2 = num;
				num = (short)1758531935;
				short num3 = num;
				num = (short)693506399;
				switch (num3 == num)
				{
				}
				num = (short)127270912;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000DF RID: 223 RVA: 0x000111C8 File Offset: 0x0000F3C8
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00011278 File Offset: 0x0000F478
		public global::Motorola.Common.Communication.DeviceDiscovery.LDTConnectMode ConnectMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1953345235;
				short num2 = num;
				num = (short)464694995;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1398079488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)925696001;
				if (num != 0)
				{
				}
				num = (short)1564737536;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)419909231;
				short num2 = num;
				num = (short)851857007;
				switch (num2 == num)
				{
				default:
				{
					num = (short)707788800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)277348353;
				if (num != 0)
				{
				}
				num = (short)1658388480;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060000E1 RID: 225 RVA: 0x00011328 File Offset: 0x0000F528
		// (remove) Token: 0x060000E2 RID: 226 RVA: 0x00011460 File Offset: 0x0000F660
		public event global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile.detachDeviceEventHandler detach
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)1228919735;
				short num2 = num;
				num = (short)1745671095;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_82:
					goto IL_84;
				default:
					num = (short)111476736;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					break;
				}
				int num3;
				global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile.detachDeviceEventHandler detachDeviceEventHandler;
				global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile.detachDeviceEventHandler detachDeviceEventHandler2;
				for (;;)
				{
					IL_54:
					switch (num3)
					{
					case 0:
						goto IL_82;
					case 1:
						num = (short)1544224769;
						if (num != 0)
						{
						}
						if (detachDeviceEventHandler == detachDeviceEventHandler2)
						{
							num = (short)1056899074;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_84;
					case 2:
						return;
					}
					goto IL_66;
				}
				return;
				IL_66:
				detachDeviceEventHandler = this.k;
				num = (short)1237057536;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
				IL_84:
				num = (short)1949171712;
				short num4 = num;
				detachDeviceEventHandler2 = detachDeviceEventHandler;
				global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile.detachDeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile.detachDeviceEventHandler)global::System.Delegate.Combine(detachDeviceEventHandler2, value);
				detachDeviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile.detachDeviceEventHandler>(ref this.k, value2, detachDeviceEventHandler2);
				num = (short)1306853377;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)929103873;
				if (num != 0)
				{
				}
				num = (short)2075399729;
				short num2 = num;
				num = (short)1849562673;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_A7:
					num = (short)465240064;
					short num3 = num;
					goto IL_D2;
				}
				default:
					num = (short)1014693888;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8C;
					}
					break;
				}
				int num4;
				global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile.detachDeviceEventHandler detachDeviceEventHandler;
				global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile.detachDeviceEventHandler detachDeviceEventHandler2;
				for (;;)
				{
					IL_7A:
					switch (num4)
					{
					case 0:
						goto IL_A7;
					case 1:
						if (detachDeviceEventHandler == detachDeviceEventHandler2)
						{
							num = (short)857079810;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2;
					case 2:
						return;
					}
					goto IL_8C;
				}
				return;
				IL_8C:
				detachDeviceEventHandler = this.k;
				num = (short)895156224;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_7A;
				IL_D2:
				detachDeviceEventHandler2 = detachDeviceEventHandler;
				global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile.detachDeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile.detachDeviceEventHandler)global::System.Delegate.Remove(detachDeviceEventHandler2, value);
				detachDeviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile.detachDeviceEventHandler>(ref this.k, value2, detachDeviceEventHandler2);
				num = (short)937033729;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_7A;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00011594 File Offset: 0x0000F794
		public override string RadioIdString
		{
			get
			{
				short num = (short)607715329;
				if (num != 0)
				{
				}
				num = (short)255393792;
				short num2 = num;
				num = (short)370074510;
				short num3 = num;
				num = (short)1694425998;
				switch (num3 == num)
				{
				}
				num = (short)1566048256;
				if (num != 0)
				{
				}
				return this.IMEI;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00011644 File Offset: 0x0000F844
		public string AstroRadioIdString
		{
			get
			{
				short num = (short)1607860225;
				if (num != 0)
				{
				}
				num = (short)589889536;
				short num2 = num;
				num = (short)450621218;
				short num3 = num;
				num = (short)438628130;
				switch (num3 == num)
				{
				}
				num = (short)1966211072;
				if (num != 0)
				{
				}
				return this.RadioIdString;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000116F4 File Offset: 0x0000F8F4
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x000117A8 File Offset: 0x0000F9A8
		public global::System.Timers.Timer TimeToLive
		{
			get
			{
				short num = (short)1282735786;
				short num2 = num;
				num = (short)1961295530;
				switch (num2 == num)
				{
				default:
				{
					num = (short)830210048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1633681409;
				if (num != 0)
				{
				}
				num = (short)1494810624;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)1052637768;
				short num2 = num;
				num = (short)872413768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)937623552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1390477313;
				if (num != 0)
				{
				}
				num = (short)1905328128;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00011858 File Offset: 0x0000FA58
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00011904 File Offset: 0x0000FB04
		public uint TTL
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)733609676;
				short num2 = num;
				num = (short)1090780876;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1382612992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1671168001;
				if (num != 0)
				{
				}
				num = (short)952958976;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)902288385;
				short num2 = num;
				num = (short)1774769153;
				switch (num2 == num)
				{
				default:
				{
					num = (short)597622784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1774059520;
				if (num != 0)
				{
				}
				num = (short)1277624321;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000119B4 File Offset: 0x0000FBB4
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00011A64 File Offset: 0x0000FC64
		public long LastRenewSeconds
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1365180417;
				if (num != 0)
				{
				}
				num = (short)56426496;
				short num2 = num;
				num = (short)1349379323;
				short num3 = num;
				num = (short)504227067;
				switch (num3 == num)
				{
				}
				num = (short)462094336;
				if (num != 0)
				{
				}
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1330206245;
				short num2 = num;
				num = (short)2087015973;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1286275072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)657588224;
				if (num != 0)
				{
				}
				num = (short)2064777217;
				if (num != 0)
				{
				}
				this.m = value;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00011B14 File Offset: 0x0000FD14
		public void StartTimer()
		{
			short num = (short)1202833664;
			short num2 = num;
			num = (short)2086848768;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1187840000;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1590165505;
			if (num != 0)
			{
			}
			num = (short)1217527808;
			if (num != 0)
			{
			}
			this.LastRenewSeconds = this.a(global::System.DateTime.Now);
			this.b = global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus.Attached;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00011BD4 File Offset: 0x0000FDD4
		public void StopTimer()
		{
			short num = (short)817364993;
			if (num != 0)
			{
			}
			num = (short)890577869;
			short num2 = num;
			num = (short)1532371917;
			switch (num2 == num)
			{
			}
			num = (short)2128543744;
			if (num != 0)
			{
			}
			num = (short)1997864960;
			short num3 = num;
			this.LastRenewSeconds = -1L;
			this.b = global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus.Detached;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00011C8C File Offset: 0x0000FE8C
		private long a(global::System.DateTime A_0)
		{
			short num = (short)1314350349;
			short num2 = num;
			num = (short)331244813;
			switch (num2 == num)
			{
			}
			num = (short)437518337;
			if (num != 0)
			{
			}
			num = (short)124256256;
			if (num != 0)
			{
			}
			num = (short)347078656;
			short num3 = num;
			return (long)new global::System.TimeSpan(A_0.Ticks).TotalSeconds;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00011D48 File Offset: 0x0000FF48
		private void a(object A_0, global::System.Timers.ElapsedEventArgs A_1)
		{
			int a_ = 0;
			short num;
			try
			{
				num = (short)993853445;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1E2;
					case 1:
						this.j.Stop();
						this.b = global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus.Detached;
						num = (short)139853832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1E2;
					case 3:
						goto IL_1FA;
					case 4:
					{
						num = (short)1790926054;
						short num3 = num;
						num = (short)1658543334;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_76;
						default:
							num = (short)2059927552;
							if (num != 0)
							{
							}
							if (this.b == global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus.Detaching)
							{
								num = (short)691011585;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("樾⽀♂㵄㝆ⱈ⡊㥌⩎㕐獒ご╖⭘㑚⽜罞๠ൢ䕤ၦh൪Ѭ佮ᕰᙲʹṶ᩸Ṻ嵼᭾ꖊ", a_), global::System.Array.Empty<object>());
							num = (short)383909890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_55;
						}
						continue;
					case 6:
						goto IL_76;
					case 7:
						goto IL_1E2;
					case 8:
						if (this.k != null)
						{
							num = (short)572850182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E2;
					case 9:
						this.b = global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus.Detaching;
						global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.b(base.IPAddress);
						num = (short)616628224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_55:
					if (this.b == global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus.Attached)
					{
						num = (short)1696268297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2097283076;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_76:
					this.k(this, null);
					num = (short)2055602183;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E2:
					num = (short)1597571075;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1FA:;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("䬾⡀⹂⁄ፆ♈݊⑌㥎㑐౒ၔ⽖⥘㉚⽜㩞ՠ奢䕤", a_) + ex.Message, global::System.Array.Empty<object>());
			}
			num = (short)724500481;
			if (num != 0)
			{
			}
			num = (short)623837184;
			short num4 = num;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00011FE8 File Offset: 0x000101E8
		internal bool a()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			long num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return true;
				case 1:
					goto IL_F2;
				case 2:
					this.b = global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus.Detaching;
					global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.b(base.IPAddress);
					num2 = (short)1189085184;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (this.b == global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus.Attached)
					{
						num2 = (short)1341521922;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A4;
				case 4:
				{
					num2 = (short)1973213235;
					short num3 = num2;
					num2 = (short)1522849843;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D9;
					default:
						num2 = (short)1338114048;
						if (num2 != 0)
						{
						}
						num2 = (short)1856372737;
						if (num2 != 0)
						{
						}
						num2 = (short)805306371;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					if (num4 - this.LastRenewSeconds > (long)((ulong)(this.TTL + this.TTL / 2U)))
					{
						goto IL_D9;
					}
					return true;
				case 6:
					if (num4 - this.LastRenewSeconds > (long)((ulong)this.TTL))
					{
						num2 = (short)562364420;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A4;
				}
				goto IL_2C;
				IL_A4:
				num2 = (short)1053753349;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_D9:
				num2 = (short)311820289;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F2:
			this.StopTimer();
			return false;
			IL_2C:
			num4 = this.a(global::System.DateTime.Now);
			num2 = (short)1751121920;
			short num5 = num2;
			num2 = (short)2006319110;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000121D4 File Offset: 0x000103D4
		public void SetIPAddress(string address)
		{
			short num = (short)528951967;
			short num2 = num;
			num = (short)189278879;
			switch (num2 == num)
			{
			}
			num = (short)434307073;
			if (num != 0)
			{
			}
			num = (short)1442185216;
			if (num != 0)
			{
			}
			num = (short)986578944;
			short num3 = num;
			base.IPAddress = address;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00012284 File Offset: 0x00010484
		public void Dispose()
		{
			short num = (short)2032498972;
			short num2 = num;
			num = (short)1340766492;
			switch (num2 == num)
			{
			}
			num = (short)953221121;
			if (num != 0)
			{
			}
			num = (short)533266432;
			if (num != 0)
			{
			}
			num = (short)32374784;
			short num3 = num;
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0001233C File Offset: 0x0001053C
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)288882690;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)291077399;
					short num3 = num;
					num = (short)801930519;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)267583488;
						short num4 = num;
						num = (short)1250164736;
						if (num != 0)
						{
						}
						num = (short)1340145665;
						if (num != 0)
						{
						}
						this.j.Close();
						num = (short)1813774337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (!disposing)
				{
					break;
				}
				num = (short)1315700736;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04000082 RID: 130
		internal const long a = -1L;

		// Token: 0x04000083 RID: 131
		private global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus b;

		// Token: 0x04000084 RID: 132
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x04000085 RID: 133
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d;

		// Token: 0x04000086 RID: 134
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string e;

		// Token: 0x04000087 RID: 135
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string f;

		// Token: 0x04000088 RID: 136
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonUtil.ProductFamily g;

		// Token: 0x04000089 RID: 137
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool h;

		// Token: 0x0400008A RID: 138
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceDiscovery.LDTConnectMode i;

		// Token: 0x0400008B RID: 139
		private global::System.Timers.Timer j = new global::System.Timers.Timer(120000.0);

		// Token: 0x0400008C RID: 140
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile.detachDeviceEventHandler k;

		// Token: 0x0400008D RID: 141
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private uint l;

		// Token: 0x0400008E RID: 142
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private long m;

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x0600010E RID: 270
		public delegate void detachDeviceEventHandler(object sender, global::System.EventArgs e);
	}
}
