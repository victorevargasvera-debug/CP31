using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000039 RID: 57
	public class UDPRadioProfile : global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile, global::System.IDisposable
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000188F0 File Offset: 0x00016AF0
		// (set) Token: 0x0600015B RID: 347 RVA: 0x000189A0 File Offset: 0x00016BA0
		public string UniqueIndendifier
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2001445588;
				short num2 = num;
				num = (short)1361421012;
				switch (num2 == num)
				{
				}
				num = (short)591659008;
				short num3 = num;
				num = (short)1894645761;
				if (num != 0)
				{
				}
				num = (short)390332416;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1615418948;
				short num2 = num;
				num = (short)2032490052;
				switch (num2 == num)
				{
				}
				num = (short)1416298496;
				short num3 = num;
				num = (short)2031747072;
				if (num != 0)
				{
				}
				num = (short)1244463105;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00018A54 File Offset: 0x00016C54
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00018B04 File Offset: 0x00016D04
		public string PasswordId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)290127873;
				if (num != 0)
				{
				}
				num = (short)1761377860;
				short num2 = num;
				num = (short)1486257732;
				switch (num2 == num)
				{
				default:
				{
					num = (short)750845952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)35127296;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)80139989;
				short num2 = num;
				num = (short)1739183829;
				switch (num2 == num)
				{
				}
				num = (short)694222848;
				short num3 = num;
				num = (short)2046099457;
				if (num != 0)
				{
				}
				num = (short)1678573568;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00018BB4 File Offset: 0x00016DB4
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00018C60 File Offset: 0x00016E60
		public string Password
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1177681921;
				if (num != 0)
				{
				}
				num = (short)1886984200;
				short num2 = num;
				num = (short)1592858632;
				switch (num2 == num)
				{
				default:
				{
					num = (short)701628416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2046689280;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1761807729;
				short num2 = num;
				num = (short)691932529;
				switch (num2 == num)
				{
				}
				num = (short)190840832;
				short num3 = num;
				num = (short)1768816641;
				if (num != 0)
				{
				}
				num = (short)2124283904;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00018D10 File Offset: 0x00016F10
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00018DC0 File Offset: 0x00016FC0
		public string DomainName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1076612996;
				short num2 = num;
				num = (short)1812844420;
				switch (num2 == num)
				{
				}
				num = (short)794689536;
				short num3 = num;
				num = (short)1622933505;
				if (num != 0)
				{
				}
				num = (short)127074304;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)935827623;
				short num2 = num;
				num = (short)125540519;
				switch (num2 == num)
				{
				}
				num = (short)1449459712;
				short num3 = num;
				num = (short)1876361217;
				if (num != 0)
				{
				}
				num = (short)1219821568;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00018E74 File Offset: 0x00017074
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00018F20 File Offset: 0x00017120
		public global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceConnectionMode DeviceConnectionMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)514820076;
				short num2 = num;
				num = (short)1639745516;
				switch (num2 == num)
				{
				}
				num = (short)272629760;
				short num3 = num;
				num = (short)407240705;
				if (num != 0)
				{
				}
				num = (short)1862991872;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)255144347;
				short num2 = num;
				num = (short)133640603;
				switch (num2 == num)
				{
				}
				num = (short)551616512;
				short num3 = num;
				num = (short)199688193;
				if (num != 0)
				{
				}
				num = (short)1727070208;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00018FD4 File Offset: 0x000171D4
		public override string RadioIdString
		{
			get
			{
				short num = (short)1333689679;
				short num2 = num;
				num = (short)461012303;
				switch (num2 == num)
				{
				}
				num = (short)1909981184;
				short num3 = num;
				num = (short)1676935169;
				if (num != 0)
				{
				}
				num = (short)799801344;
				if (num != 0)
				{
				}
				return this.UniqueIndendifier;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00019084 File Offset: 0x00017284
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00019134 File Offset: 0x00017334
		public global::Motorola.Common.Communication.DeviceDiscovery.UDPDetectorBase HostDetector
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1213136897;
				if (num != 0)
				{
				}
				num = (short)487124979;
				short num2 = num;
				num = (short)1108668403;
				switch (num2 == num)
				{
				default:
				{
					num = (short)989265920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)159186944;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2033723202;
				short num2 = num;
				num = (short)559425346;
				switch (num2 == num)
				{
				}
				num = (short)437649408;
				short num3 = num;
				num = (short)2049703936;
				if (num != 0)
				{
				}
				num = (short)1569259521;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000167 RID: 359 RVA: 0x000191E4 File Offset: 0x000173E4
		// (remove) Token: 0x06000168 RID: 360 RVA: 0x0001931C File Offset: 0x0001751C
		public event global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.detachDeviceEventHandler detach
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
				global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.detachDeviceEventHandler detachDeviceEventHandler;
				for (;;)
				{
					IL_0A:
					global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.detachDeviceEventHandler detachDeviceEventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						num2 = (short)719716352;
						short num3 = num2;
						num2 = (short)1250445499;
						short num4 = num2;
						num2 = (short)1354582203;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_60;
						default:
							num2 = (short)1882914816;
							if (num2 != 0)
							{
							}
							if (detachDeviceEventHandler == detachDeviceEventHandler2)
							{
								num2 = (short)524091392;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_62;
						}
						break;
					}
					case 2:
						goto IL_60;
					}
					goto IL_1C;
					IL_62:
					detachDeviceEventHandler2 = detachDeviceEventHandler;
					global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.detachDeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.detachDeviceEventHandler)global::System.Delegate.Combine(detachDeviceEventHandler2, value);
					detachDeviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.detachDeviceEventHandler>(ref this.h, value2, detachDeviceEventHandler2);
					num2 = (short)1926692865;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_60:
					goto IL_62;
				}
				return;
				IL_1C:
				num2 = (short)1962541057;
				if (num2 != 0)
				{
				}
				detachDeviceEventHandler = this.h;
				num2 = (short)769654786;
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
				global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.detachDeviceEventHandler detachDeviceEventHandler;
				for (;;)
				{
					IL_0A:
					global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.detachDeviceEventHandler detachDeviceEventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						num2 = (short)83298290;
						short num3 = num2;
						num2 = (short)989005810;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_37;
						case 1:
							break;
						default:
						{
							num2 = (short)1570635776;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)1378222081;
						if (num2 != 0)
						{
						}
						num2 = (short)584450048;
						if (num2 != 0)
						{
						}
						if (detachDeviceEventHandler == detachDeviceEventHandler2)
						{
							num2 = (short)877461504;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					}
					case 2:
						goto IL_37;
					}
					goto IL_1C;
					IL_39:
					detachDeviceEventHandler2 = detachDeviceEventHandler;
					global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.detachDeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.detachDeviceEventHandler)global::System.Delegate.Remove(detachDeviceEventHandler2, value);
					detachDeviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.detachDeviceEventHandler>(ref this.h, value2, detachDeviceEventHandler2);
					num2 = (short)1356464129;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_37:
					goto IL_39;
				}
				return;
				IL_1C:
				detachDeviceEventHandler = this.h;
				num2 = (short)1146683394;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00019450 File Offset: 0x00017650
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00019504 File Offset: 0x00017704
		public global::System.Timers.Timer TimeToLive
		{
			get
			{
				short num = (short)1520994100;
				short num2 = num;
				num = (short)2042398516;
				switch (num2 == num)
				{
				}
				num = (short)1806303232;
				short num3 = num;
				num = (short)831782913;
				if (num != 0)
				{
				}
				num = (short)1373437952;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)859518079;
				short num2 = num;
				num = (short)477312127;
				switch (num2 == num)
				{
				}
				num = (short)103153664;
				short num3 = num;
				num = (short)278003712;
				if (num != 0)
				{
				}
				num = (short)854065153;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000195B4 File Offset: 0x000177B4
		public void StartTimer()
		{
			short num = (short)911635345;
			short num2 = num;
			num = (short)1242198929;
			switch (num2 == num)
			{
			}
			num = (short)487522304;
			short num3 = num;
			num = (short)56557569;
			if (num != 0)
			{
			}
			num = (short)1074921472;
			if (num != 0)
			{
			}
			this.g.Elapsed += this.a;
			this.g.Start();
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0001967C File Offset: 0x0001787C
		private void a(object A_0, global::System.Timers.ElapsedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)1216413696;
					short num3 = num2;
					num2 = (short)1418747304;
					short num4 = num2;
					num2 = (short)1279942056;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B;
					default:
						num2 = (short)510263296;
						if (num2 != 0)
						{
						}
						this.h(this, null);
						num2 = (short)130285568;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_3B;
				}
				goto IL_1C;
				IL_3B:
				num2 = (short)1483014145;
				if (num2 != 0)
				{
				}
				if (this.h == null)
				{
					break;
				}
				num2 = (short)145752065;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			this.g.Stop();
			num2 = (short)717488130;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000197A8 File Offset: 0x000179A8
		public void Dispose()
		{
			short num = (short)1946468360;
			short num2 = num;
			num = (short)802275336;
			switch (num2 == num)
			{
			}
			num = (short)1332871168;
			short num3 = num;
			num = (short)849412097;
			if (num != 0)
			{
			}
			num = (short)454361088;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00019860 File Offset: 0x00017A60
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)2100297730;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)584873632;
					short num3 = num;
					num = (short)272529056;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1758330880;
						if (num != 0)
						{
						}
						break;
					}
					this.g.Close();
					num = (short)459210752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					num = (short)15138816;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				}
				}
				IL_5C:
				if (!disposing)
				{
					break;
				}
				num = (short)922222593;
				if (num != 0)
				{
				}
				num = (short)164233217;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000199A4 File Offset: 0x00017BA4
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1633113605 + A_1) + (global::System.IntPtr)91 + (global::System.IntPtr)50 + (global::System.IntPtr)84 + (global::System.IntPtr)63 + (global::System.IntPtr)25);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}

		// Token: 0x040000C3 RID: 195
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x040000C4 RID: 196
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x040000C5 RID: 197
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x040000C6 RID: 198
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d;

		// Token: 0x040000C7 RID: 199
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceConnectionMode e;

		// Token: 0x040000C8 RID: 200
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceDiscovery.UDPDetectorBase f;

		// Token: 0x040000C9 RID: 201
		private global::System.Timers.Timer g = new global::System.Timers.Timer(120000.0);

		// Token: 0x040000CA RID: 202
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.detachDeviceEventHandler h;

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000172 RID: 370
		public delegate void detachDeviceEventHandler(object sender, global::System.EventArgs e);
	}
}
