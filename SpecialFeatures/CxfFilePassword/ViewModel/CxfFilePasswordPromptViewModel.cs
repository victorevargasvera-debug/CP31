using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Input;
using ACPBrowser;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Utilities;

namespace SpecialFeatures.CxfFilePassword.ViewModel
{
	// Token: 0x0200014D RID: 333
	public class CxfFilePasswordPromptViewModel : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x0017A978 File Offset: 0x00178B78
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x0017AA28 File Offset: 0x00178C28
		public bool ShouldFocusPasswordField
		{
			get
			{
				short num = (short)180407077;
				short num2 = num;
				num = (short)1104792357;
				switch (num2 == num)
				{
				}
				num = (short)1902968832;
				short num3 = num;
				num = (short)2059272193;
				if (num != 0)
				{
				}
				num = (short)1314521088;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				int a_ = 1;
				short num = (short)143064940;
				short num2 = num;
				num = (short)325123948;
				switch (num2 == num)
				{
				}
				num = (short)783482880;
				short num3 = num;
				num = (short)1349517312;
				if (num != 0)
				{
				}
				num = (short)979632129;
				if (num != 0)
				{
				}
				this.a = value;
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힃ﾉ횏﶑쪙ﶛ펟햡쮣풥첧얫쮭\udcaf횱", a_));
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x0017AAF4 File Offset: 0x00178CF4
		// (set) Token: 0x06001103 RID: 4355 RVA: 0x0017ABA4 File Offset: 0x00178DA4
		public string CxfFileName
		{
			get
			{
				short num = (short)684630765;
				short num2 = num;
				num = (short)1924899565;
				switch (num2 == num)
				{
				}
				num = (short)497942528;
				short num3 = num;
				num = (short)1688141824;
				if (num != 0)
				{
				}
				num = (short)1675952129;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				int a_ = 15;
				short num = (short)615525628;
				short num2 = num;
				num = (short)493235452;
				switch (num2 == num)
				{
				}
				num = (short)1850867712;
				short num3 = num;
				num = (short)2056126465;
				if (num != 0)
				{
				}
				num = (short)37027840;
				if (num != 0)
				{
				}
				this.b = value;
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톑\ude97ﮝ쎡즣쎥", a_));
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x0017AC74 File Offset: 0x00178E74
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x0017AD24 File Offset: 0x00178F24
		public bool RemeberCxfFilePassword
		{
			get
			{
				short num = (short)1717852182;
				short num2 = num;
				num = (short)703813654;
				switch (num2 == num)
				{
				}
				num = (short)1802305536;
				short num3 = num;
				num = (short)146735104;
				if (num != 0)
				{
				}
				num = (short)466157569;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				int a_ = 3;
				short num = (short)1353383937;
				if (num != 0)
				{
				}
				num = (short)1022814624;
				short num2 = num;
				num = (short)622061984;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1155858432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2136342528;
				if (num != 0)
				{
				}
				this.c = value;
				this.a(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풅힓ﺗ\udc99얟얣향\udba7\udda9쎫\udcad풯", a_));
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x0017ADF0 File Offset: 0x00178FF0
		// (set) Token: 0x06001107 RID: 4359 RVA: 0x0017AE9C File Offset: 0x0017909C
		public global::System.Security.SecureString ProvidedPassword
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)862174016;
				short num2 = num;
				num = (short)1785903936;
				switch (num2 == num)
				{
				}
				num = (short)1221591040;
				short num3 = num;
				num = (short)155648001;
				if (num != 0)
				{
				}
				num = (short)276692992;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1658245011;
				short num2 = num;
				num = (short)297193363;
				switch (num2 == num)
				{
				}
				num = (short)1998389248;
				short num3 = num;
				num = (short)511115264;
				if (num != 0)
				{
				}
				num = (short)347668481;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x0017AF4C File Offset: 0x0017914C
		// (set) Token: 0x06001109 RID: 4361 RVA: 0x0017AFFC File Offset: 0x001791FC
		public bool IsCancelled
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1645740033;
				if (num != 0)
				{
				}
				num = (short)696739336;
				short num2 = num;
				num = (short)1404790280;
				switch (num2 == num)
				{
				default:
				{
					num = (short)783613952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)341966848;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)339948631;
				short num2 = num;
				num = (short)60372055;
				switch (num2 == num)
				{
				}
				num = (short)910491648;
				short num3 = num;
				num = (short)1079312385;
				if (num != 0)
				{
				}
				num = (short)141492224;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x0017B0AC File Offset: 0x001792AC
		// (set) Token: 0x0600110B RID: 4363 RVA: 0x0017B15C File Offset: 0x0017935C
		public global::System.Windows.Input.ICommand HelpCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1850567158;
				short num2 = num;
				num = (short)1871669750;
				switch (num2 == num)
				{
				}
				num = (short)13303808;
				short num3 = num;
				num = (short)524484609;
				if (num != 0)
				{
				}
				num = (short)1831010304;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)672697827;
				short num2 = num;
				num = (short)872713699;
				switch (num2 == num)
				{
				}
				num = (short)1497300992;
				short num3 = num;
				num = (short)618659840;
				if (num != 0)
				{
				}
				num = (short)461570049;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x0017B20C File Offset: 0x0017940C
		// (set) Token: 0x0600110D RID: 4365 RVA: 0x0017B2BC File Offset: 0x001794BC
		public global::System.Windows.Input.ICommand CancelCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1346293595;
				short num2 = num;
				num = (short)638898011;
				switch (num2 == num)
				{
				}
				num = (short)1437073408;
				short num3 = num;
				num = (short)750583808;
				if (num != 0)
				{
				}
				num = (short)1387528193;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)741546976;
				short num2 = num;
				num = (short)1487805408;
				switch (num2 == num)
				{
				}
				num = (short)912130048;
				short num3 = num;
				num = (short)557449216;
				if (num != 0)
				{
				}
				num = (short)942800897;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x0017B370 File Offset: 0x00179570
		// (set) Token: 0x0600110F RID: 4367 RVA: 0x0017B420 File Offset: 0x00179620
		public global::System.Windows.Input.ICommand OkCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)498059113;
				short num2 = num;
				num = (short)322094953;
				switch (num2 == num)
				{
				}
				num = (short)194248704;
				short num3 = num;
				num = (short)1127088129;
				if (num != 0)
				{
				}
				num = (short)1829371904;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)316643408;
				short num2 = num;
				num = (short)1540462672;
				switch (num2 == num)
				{
				}
				num = (short)1243348992;
				short num3 = num;
				num = (short)1868103681;
				if (num != 0)
				{
				}
				num = (short)1652948992;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06001110 RID: 4368 RVA: 0x0017B4D0 File Offset: 0x001796D0
		// (remove) Token: 0x06001111 RID: 4369 RVA: 0x0017B60C File Offset: 0x0017980C
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
							goto IL_113;
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
					num2 = (short)862317152;
					short num3 = num2;
					num2 = (short)1378937440;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_113:
						num2 = (short)1811873793;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)301727745;
						if (num2 != 0)
						{
						}
						num2 = (short)1819410432;
						short num4 = num2;
						num2 = (short)1278279680;
						if (num2 != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.i, value2, propertyChangedEventHandler2);
						num2 = (short)1715994624;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.i;
				num2 = (short)1664811010;
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
							goto IL_110;
						}
						goto IL_61;
					}
					case 1:
						return;
					case 2:
						goto IL_61;
					}
					goto IL_1C;
					IL_61:
					num2 = (short)1499106742;
					short num3 = num2;
					num2 = (short)321293750;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_110:
						num2 = (short)1586298881;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)2103574528;
						short num4 = num2;
						num2 = (short)793837568;
						if (num2 != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.i, value2, propertyChangedEventHandler2);
						num2 = (short)2072379392;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				num2 = (short)411828225;
				if (num2 != 0)
				{
				}
				propertyChangedEventHandler = this.i;
				num2 = (short)302645250;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06001112 RID: 4370 RVA: 0x0017B744 File Offset: 0x00179944
		// (remove) Token: 0x06001113 RID: 4371 RVA: 0x0017B87C File Offset: 0x00179A7C
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
							goto IL_110;
						}
						goto IL_60;
					}
					case 1:
						return;
					case 2:
						goto IL_60;
					}
					goto IL_1C;
					IL_60:
					num2 = (short)796937612;
					short num3 = num2;
					num2 = (short)731532684;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_110:
						num2 = (short)1807220737;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)583532544;
						short num4 = num2;
						num2 = (short)924057600;
						if (num2 != 0)
						{
						}
						global::System.EventHandler eventHandler2 = eventHandler;
						global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.j, value2, eventHandler2);
						num2 = (short)929759232;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.j;
				num2 = (short)1588199425;
				if (num2 != 0)
				{
				}
				num2 = (short)1500905474;
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
					num2 = (short)382476908;
					short num3 = num2;
					num2 = (short)442770028;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_10F:
						num2 = (short)1470300161;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
					{
						num2 = (short)697696256;
						if (num2 != 0)
						{
						}
						num2 = (short)1737621504;
						short num4 = num2;
						num2 = (short)530513921;
						if (num2 != 0)
						{
						}
						global::System.EventHandler eventHandler2 = eventHandler;
						global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.j, value2, eventHandler2);
						num2 = (short)650510336;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.j;
				num2 = (short)150667266;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00003653 File Offset: 0x00001853
		public CxfFilePasswordPromptViewModel()
		{
			this.a();
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0017B9B4 File Offset: 0x00179BB4
		private void a()
		{
			short num = (short)983260438;
			short num2 = num;
			num = (short)665410838;
			switch (num2 == num)
			{
			}
			num = (short)2061107200;
			short num3 = num;
			num = (short)1276575745;
			if (num != 0)
			{
			}
			num = (short)869466112;
			if (num != 0)
			{
			}
			this.HelpCommand = new global::SpecialFeatures.Utilities.RelayCommand(new global::System.Action<object>(this.c));
			this.CancelCommand = new global::SpecialFeatures.Utilities.RelayCommand(new global::System.Action<object>(this.b));
			this.OkCommand = new global::SpecialFeatures.Utilities.RelayCommand(new global::System.Action<object>(this.a));
			this.IsCancelled = true;
			this.ShouldFocusPasswordField = true;
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0017BAB0 File Offset: 0x00179CB0
		private void c(object A_0)
		{
			int a_ = 14;
			short num;
			try
			{
				num = (short)93064764;
				short num2 = num;
				num = (short)1725369916;
				switch (num2 == num)
				{
				}
				num = (short)1493630976;
				if (num != 0)
				{
				}
				global::ACPBrowser.Utility.CloseHelpWindowIfOpen();
				global::ACPBrowser.Utility.DisplayCPSHelpDITA(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("느ꮒꞔꖖꪘ꾚ﮜꦞ鞠", a_));
			}
			catch (global::System.Exception)
			{
			}
			num = (short)720830465;
			if (num != 0)
			{
			}
			num = (short)304480256;
			short num3 = num;
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0017BB94 File Offset: 0x00179D94
		private void b(object A_0)
		{
			short num = (short)1329679998;
			short num2 = num;
			num = (short)1063210622;
			switch (num2 == num)
			{
			}
			num = (short)1464401920;
			short num3 = num;
			num = (short)2047606785;
			if (num != 0)
			{
			}
			num = (short)67174400;
			if (num != 0)
			{
			}
			global::System.EventHandler eventHandler = this.j;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, new global::System.EventArgs());
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0017BC58 File Offset: 0x00179E58
		private void a(object A_0)
		{
			short num = (short)875684435;
			short num2 = num;
			num = (short)808313427;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1922760704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1821507585;
			if (num != 0)
			{
			}
			num = (short)1576271872;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.PasswordBox passwordBox = A_0 as global::System.Windows.Controls.PasswordBox;
			global::System.Security.SecureString a_;
			if ((a_ = ((passwordBox != null) ? passwordBox.SecurePassword : null)) == null)
			{
				a_ = null;
			}
			this.ProvidedPassword = a_;
			this.IsCancelled = false;
			global::System.EventHandler eventHandler = this.j;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, new global::System.EventArgs());
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0017BD48 File Offset: 0x00179F48
		private void a([global::System.Runtime.CompilerServices.CallerMemberName] string A_0 = null)
		{
			short num = (short)1809529530;
			short num2 = num;
			num = (short)1575303866;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1109721088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1248526336;
			if (num != 0)
			{
			}
			num = (short)1292828673;
			if (num != 0)
			{
			}
			global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler = this.i;
			if (propertyChangedEventHandler == null)
			{
				return;
			}
			propertyChangedEventHandler(this, new global::System.ComponentModel.PropertyChangedEventArgs(A_0));
		}

		// Token: 0x04000929 RID: 2345
		private bool a;

		// Token: 0x0400092A RID: 2346
		private string b = string.Empty;

		// Token: 0x0400092B RID: 2347
		private bool c;

		// Token: 0x0400092C RID: 2348
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Security.SecureString d;

		// Token: 0x0400092D RID: 2349
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool e;

		// Token: 0x0400092E RID: 2350
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.Input.ICommand f;

		// Token: 0x0400092F RID: 2351
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.Input.ICommand g;

		// Token: 0x04000930 RID: 2352
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.Input.ICommand h;

		// Token: 0x04000931 RID: 2353
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler i;

		// Token: 0x04000932 RID: 2354
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler j;
	}
}
