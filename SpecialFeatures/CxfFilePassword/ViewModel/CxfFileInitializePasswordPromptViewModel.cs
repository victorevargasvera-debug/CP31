using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using ACPBrowser;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Utilities;

namespace SpecialFeatures.CxfFilePassword.ViewModel
{
	// Token: 0x0200014C RID: 332
	public class CxfFileInitializePasswordPromptViewModel : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x00179224 File Offset: 0x00177424
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x001792D4 File Offset: 0x001774D4
		public bool ShouldFocusPasswordField
		{
			get
			{
				short num = (short)75036153;
				short num2 = num;
				num = (short)1636038137;
				switch (num2 == num)
				{
				default:
				{
					num = (short)919994368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1567686657;
				if (num != 0)
				{
				}
				num = (short)1217855488;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				int a_ = 4;
				short num = (short)835566039;
				short num2 = num;
				num = (short)2063514071;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1196818432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)725417984;
				if (num != 0)
				{
				}
				num = (short)1970077697;
				if (num != 0)
				{
				}
				this.a = value;
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풆햒杖출ﺞ튠킢튤좦\udba8쾪욮풰\udfb2톴", a_));
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x001793A4 File Offset: 0x001775A4
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x00179454 File Offset: 0x00177654
		public string CxfFileName
		{
			get
			{
				short num = (short)1673581109;
				short num2 = num;
				num = (short)1109512757;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1690370048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)759496705;
				if (num != 0)
				{
				}
				num = (short)1925971968;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				int a_ = 3;
				short num = (short)269983918;
				short num2 = num;
				num = (short)618504366;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1824129024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2125856769;
				if (num != 0)
				{
				}
				num = (short)1992294400;
				if (num != 0)
				{
				}
				this.b = value;
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얅쪋ﲏ\uda93ﾙ", a_));
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x00179520 File Offset: 0x00177720
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x001795D0 File Offset: 0x001777D0
		public bool RemeberCxfFilePassword
		{
			get
			{
				short num = (short)1436169238;
				short num2 = num;
				num = (short)2017735702;
				switch (num2 == num)
				{
				default:
				{
					num = (short)275841024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)632094720;
				if (num != 0)
				{
				}
				num = (short)1343946753;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				int a_ = 7;
				short num = (short)1589128610;
				short num2 = num;
				num = (short)1172909474;
				switch (num2 == num)
				{
				default:
				{
					num = (short)945553408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1199505409;
				if (num != 0)
				{
				}
				num = (short)1764425728;
				if (num != 0)
				{
				}
				this.c = value;
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud889\udb97瀞\ud89d즟캡솣즧\ud9a9\udfab\ud9ad\udfaf삱킳", a_));
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x001796A0 File Offset: 0x001778A0
		// (set) Token: 0x060010E9 RID: 4329 RVA: 0x00179750 File Offset: 0x00177950
		public global::System.Windows.Visibility DataLostInfoVisibility
		{
			get
			{
				short num = (short)2116012679;
				short num2 = num;
				num = (short)1144048263;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1768292352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)243662849;
				if (num != 0)
				{
				}
				num = (short)564002816;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				int a_ = 11;
				short num = (short)307872522;
				short num2 = num;
				num = (short)1521795850;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1192755200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1369505793;
				if (num != 0)
				{
				}
				num = (short)1185808384;
				if (num != 0)
				{
				}
				this.d = value;
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪍\uda95힝캟쒡쮣솧\ud9a9얫청\ud9af\udeb1\uddb3습솷", a_));
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x00179820 File Offset: 0x00177A20
		// (set) Token: 0x060010EB RID: 4331 RVA: 0x001798CC File Offset: 0x00177ACC
		public global::System.Security.SecureString ProvidedPassword
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)934970148;
				short num2 = num;
				num = (short)1269334820;
				switch (num2 == num)
				{
				default:
				{
					num = (short)707330048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1307508737;
				if (num != 0)
				{
				}
				num = (short)1006239744;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)874412707;
				short num2 = num;
				num = (short)1045527203;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1594228736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)386596864;
				if (num != 0)
				{
				}
				num = (short)1507524609;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x0017997C File Offset: 0x00177B7C
		// (set) Token: 0x060010ED RID: 4333 RVA: 0x00179A2C File Offset: 0x00177C2C
		public global::System.Security.SecureString ConfirmProvidedPassword
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2002668274;
				short num2 = num;
				num = (short)149375730;
				switch (num2 == num)
				{
				default:
				{
					num = (short)963248128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1548812288;
				if (num != 0)
				{
				}
				num = (short)2016018433;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)891305398;
				short num2 = num;
				num = (short)1623276982;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1486749696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1919418369;
				if (num != 0)
				{
				}
				num = (short)868024320;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060010EE RID: 4334 RVA: 0x00179AE0 File Offset: 0x00177CE0
		// (set) Token: 0x060010EF RID: 4335 RVA: 0x00179B94 File Offset: 0x00177D94
		public bool IsCancelled
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2078128287;
				short num2 = num;
				num = (short)627423391;
				switch (num2 == num)
				{
				default:
				{
					num = (short)587005952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)346226689;
				if (num != 0)
				{
				}
				num = (short)1370423296;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)879746611;
				short num2 = num;
				num = (short)1585110579;
				switch (num2 == num)
				{
				default:
				{
					num = (short)646316032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)644874241;
				if (num != 0)
				{
				}
				num = (short)1035796480;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060010F0 RID: 4336 RVA: 0x00179C44 File Offset: 0x00177E44
		// (set) Token: 0x060010F1 RID: 4337 RVA: 0x00179CF0 File Offset: 0x00177EF0
		public global::System.Windows.Input.ICommand HelpCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2057550811;
				short num2 = num;
				num = (short)195476443;
				switch (num2 == num)
				{
				}
				num = (short)614334464;
				short num3 = num;
				num = (short)1822490624;
				if (num != 0)
				{
				}
				num = (short)197328897;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)717357057;
				if (num != 0)
				{
				}
				num = (short)1454858894;
				short num2 = num;
				num = (short)489317006;
				switch (num2 == num)
				{
				default:
				{
					num = (short)789053440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2077294592;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x00179DA0 File Offset: 0x00177FA0
		// (set) Token: 0x060010F3 RID: 4339 RVA: 0x00179E50 File Offset: 0x00178050
		public global::System.Windows.Input.ICommand CancelCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1322192625;
				short num2 = num;
				num = (short)1198722801;
				switch (num2 == num)
				{
				}
				num = (short)749404160;
				short num3 = num;
				num = (short)848297985;
				if (num != 0)
				{
				}
				num = (short)629866496;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2088920944;
				short num2 = num;
				num = (short)564422512;
				switch (num2 == num)
				{
				}
				num = (short)2010906624;
				short num3 = num;
				num = (short)673316865;
				if (num != 0)
				{
				}
				num = (short)2027487232;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x00179F00 File Offset: 0x00178100
		// (set) Token: 0x060010F5 RID: 4341 RVA: 0x00179FB0 File Offset: 0x001781B0
		public global::System.Windows.Input.ICommand OkCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1090049913;
				short num2 = num;
				num = (short)79943545;
				switch (num2 == num)
				{
				}
				num = (short)2015887360;
				short num3 = num;
				num = (short)757661697;
				if (num != 0)
				{
				}
				num = (short)903413760;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)149730020;
				short num2 = num;
				num = (short)1013691108;
				switch (num2 == num)
				{
				}
				num = (short)1574895616;
				short num3 = num;
				num = (short)841416705;
				if (num != 0)
				{
				}
				num = (short)291438592;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060010F6 RID: 4342 RVA: 0x0017A060 File Offset: 0x00178260
		// (remove) Token: 0x060010F7 RID: 4343 RVA: 0x0017A198 File Offset: 0x00178398
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
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
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							goto IL_110;
						}
						goto IL_62;
					}
					case 1:
						return;
					case 2:
						goto IL_62;
					}
					goto IL_1C;
					IL_62:
					num2 = (short)32136944;
					short num3 = num2;
					num2 = (short)178740976;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_110:
						num2 = (short)1580728321;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)1180696576;
						short num4 = num2;
						num2 = (short)446431232;
						if (num2 != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.k, value2, propertyChangedEventHandler2);
						num2 = (short)1154416640;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				num2 = (short)1342767105;
				if (num2 != 0)
				{
				}
				propertyChangedEventHandler = this.k;
				num2 = (short)1693450242;
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
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							goto IL_112;
						}
						goto IL_39;
					}
					case 1:
						return;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_39:
					num2 = (short)581195863;
					short num3 = num2;
					num2 = (short)1703958615;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_112:
						num2 = (short)1216348161;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)885850112;
						if (num2 != 0)
						{
						}
						num2 = (short)1484980224;
						short num4 = num2;
						num2 = (short)416153601;
						if (num2 != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.k, value2, propertyChangedEventHandler2);
						num2 = (short)964624384;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.k;
				num2 = (short)12320770;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060010F8 RID: 4344 RVA: 0x0017A2D4 File Offset: 0x001784D4
		// (remove) Token: 0x060010F9 RID: 4345 RVA: 0x0017A410 File Offset: 0x00178610
		internal event global::System.EventHandler OnClose
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
				global::System.EventHandler eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						global::System.EventHandler eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_111;
						}
						goto IL_5F;
					}
					case 1:
						return;
					case 2:
						goto IL_5F;
					}
					goto IL_1C;
					IL_5F:
					num2 = (short)177798030;
					short num3 = num2;
					num2 = (short)1238498190;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_111:
						num2 = (short)1312817153;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)1911488512;
						short num4 = num2;
						num2 = (short)1101398016;
						if (num2 != 0)
						{
						}
						global::System.EventHandler eventHandler2 = eventHandler;
						global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.l, value2, eventHandler2);
						num2 = (short)1394343936;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				num2 = (short)1980432385;
				if (num2 != 0)
				{
				}
				eventHandler = this.l;
				num2 = (short)2001338370;
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
				global::System.EventHandler eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						global::System.EventHandler eventHandler2;
						if (eventHandler == eventHandler2)
						{
							goto IL_10F;
						}
						goto IL_39;
					}
					case 1:
						return;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_39:
					num2 = (short)602811592;
					short num3 = num2;
					num2 = (short)352464072;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_10F:
						num2 = (short)360579073;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)833683457;
						if (num2 != 0)
						{
						}
						num2 = (short)2112487424;
						short num4 = num2;
						num2 = (short)1816395776;
						if (num2 != 0)
						{
						}
						global::System.EventHandler eventHandler2 = eventHandler;
						global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.l, value2, eventHandler2);
						num2 = (short)1408958464;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.l;
				num2 = (short)2003042306;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0000363A File Offset: 0x0000183A
		public CxfFileInitializePasswordPromptViewModel()
		{
			this.a();
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0017A548 File Offset: 0x00178748
		private void a()
		{
			short num = (short)308751707;
			short num2 = num;
			num = (short)679292251;
			switch (num2 == num)
			{
			}
			num = (short)1207107584;
			short num3 = num;
			num = (short)1423245313;
			if (num != 0)
			{
			}
			num = (short)1431764992;
			if (num != 0)
			{
			}
			this.HelpCommand = new global::SpecialFeatures.Utilities.RelayCommand(new global::System.Action<object>(this.c));
			this.CancelCommand = new global::SpecialFeatures.Utilities.RelayCommand(new global::System.Action<object>(this.b));
			this.OkCommand = new global::SpecialFeatures.Utilities.RelayCommand(new global::System.Action<object>(this.a));
			this.IsCancelled = true;
			this.ShouldFocusPasswordField = true;
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0017A648 File Offset: 0x00178848
		private void c(object A_0)
		{
			int a_ = 1;
			short num;
			try
			{
				num = (short)707133441;
				if (num != 0)
				{
				}
				num = (short)1534546768;
				short num2 = num;
				num = (short)1264931664;
				switch (num2 == num)
				{
				}
				num = (short)1809252352;
				if (num != 0)
				{
				}
				global::ACPBrowser.Utility.CloseHelpWindowIfOpen();
				global::ACPBrowser.Utility.DisplayCPSHelpDITA(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꞃ뺅몇뢉뾋몍꒑ꊓ", a_));
			}
			catch (global::System.Exception)
			{
			}
			num = (short)494927872;
			short num3 = num;
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x0017A728 File Offset: 0x00178928
		private void b(object A_0)
		{
			short num = (short)1898233041;
			short num2 = num;
			num = (short)1605614801;
			switch (num2 == num)
			{
			}
			num = (short)653197312;
			short num3 = num;
			num = (short)374276096;
			if (num != 0)
			{
			}
			num = (short)1176698881;
			if (num != 0)
			{
			}
			global::System.EventHandler eventHandler = this.l;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, new global::System.EventArgs());
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x0017A7EC File Offset: 0x001789EC
		private void a(object A_0)
		{
			short num = (short)1158865359;
			short num2 = num;
			num = (short)1047388623;
			switch (num2 == num)
			{
			}
			num = (short)1528823808;
			short num3 = num;
			num = (short)1002504193;
			if (num != 0)
			{
			}
			num = (short)1510211584;
			if (num != 0)
			{
			}
			this.IsCancelled = false;
			global::System.EventHandler eventHandler = this.l;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, new global::System.EventArgs());
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x0017A8B4 File Offset: 0x00178AB4
		private void a([global::System.Runtime.CompilerServices.CallerMemberName] string A_0 = null)
		{
			short num = (short)2122375313;
			short num2 = num;
			num = (short)1645469841;
			switch (num2 == num)
			{
			}
			num = (short)1005846528;
			short num3 = num;
			num = (short)1987575809;
			if (num != 0)
			{
			}
			num = (short)1779564544;
			if (num != 0)
			{
			}
			global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler = this.k;
			if (propertyChangedEventHandler == null)
			{
				return;
			}
			propertyChangedEventHandler(this, new global::System.ComponentModel.PropertyChangedEventArgs(A_0));
		}

		// Token: 0x0400091D RID: 2333
		private bool a;

		// Token: 0x0400091E RID: 2334
		private string b = string.Empty;

		// Token: 0x0400091F RID: 2335
		private bool c;

		// Token: 0x04000920 RID: 2336
		private global::System.Windows.Visibility d;

		// Token: 0x04000921 RID: 2337
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Security.SecureString e;

		// Token: 0x04000922 RID: 2338
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Security.SecureString f;

		// Token: 0x04000923 RID: 2339
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool g;

		// Token: 0x04000924 RID: 2340
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.Input.ICommand h;

		// Token: 0x04000925 RID: 2341
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.Input.ICommand i;

		// Token: 0x04000926 RID: 2342
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.Input.ICommand j;

		// Token: 0x04000927 RID: 2343
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler k;

		// Token: 0x04000928 RID: 2344
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler l;
	}
}
