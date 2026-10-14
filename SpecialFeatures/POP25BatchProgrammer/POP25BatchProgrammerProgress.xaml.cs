using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using ACPBrowser;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpUI;
using AcpUI.Common;
using AcpUtility;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.PackExec;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Clone_Configuration.Common;
using SpecialFeatures.Comms;
using SpecialFeatures.Programming;
using SpecialFeatures.Security;
using SSLAdminTool;
using SSLMangrComp.Packets;

namespace SpecialFeatures.POP25BatchProgrammer
{
	// Token: 0x02000092 RID: 146
	public partial class POP25BatchProgrammerProgress : Window
	{
		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x000C7690 File Offset: 0x000C5890
		public ObservableCollection<POP25RadioInfo> DataSource
		{
			get
			{
				short num = (short)90096998;
				short num2 = num;
				num = (short)138331494;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2015821824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)285868032;
				if (num != 0)
				{
				}
				num = (short)1445789697;
				if (num != 0)
				{
				}
				return this.u;
			}
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x000C7740 File Offset: 0x000C5940
		public POP25BatchProgrammerProgress()
		{
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
			base.DataContext = this;
			this.CancelBatchProgramming = false;
			this.BatchProgrammingInProgress = false;
			this.BatchProgrammingComplete = false;
			this.g = true;
			this.t = new byte[0];
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x000C7898 File Offset: 0x000C5A98
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x000C77E8 File Offset: 0x000C59E8
		internal double PbStatusval
		{
			get
			{
				short num = (short)122541352;
				short num2 = num;
				num = (short)518116648;
				switch (num2 == num)
				{
				}
				num = (short)1334116352;
				if (num != 0)
				{
				}
				num = (short)1146093569;
				if (num != 0)
				{
				}
				num = (short)1167523840;
				short num3 = num;
				return this.e;
			}
			set
			{
				short num = (short)1461279999;
				short num2 = num;
				num = (short)1940806911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2009923584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1686437888;
				if (num != 0)
				{
				}
				num = (short)1122697217;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x000C79F8 File Offset: 0x000C5BF8
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x000C7948 File Offset: 0x000C5B48
		internal bool ARSServerEnabled
		{
			get
			{
				short num = (short)876186053;
				short num2 = num;
				num = (short)455641541;
				switch (num2 == num)
				{
				}
				num = (short)1278279681;
				if (num != 0)
				{
				}
				num = (short)1380057088;
				if (num != 0)
				{
				}
				num = (short)85655552;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)675151873;
				if (num != 0)
				{
				}
				num = (short)641081919;
				short num2 = num;
				num = (short)1731207743;
				switch (num2 == num)
				{
				}
				num = (short)735248384;
				if (num != 0)
				{
				}
				num = (short)774766592;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x000C7B60 File Offset: 0x000C5D60
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x000C7AAC File Offset: 0x000C5CAC
		internal string CurrentRadioIpAddress
		{
			get
			{
				short num = (short)1995571201;
				if (num != 0)
				{
				}
				num = (short)1163278613;
				short num2 = num;
				num = (short)119879957;
				switch (num2 == num)
				{
				}
				num = (short)1588133888;
				if (num != 0)
				{
				}
				num = (short)1735393280;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)985822737;
				short num2 = num;
				num = (short)1266382353;
				switch (num2 == num)
				{
				}
				num = (short)558628865;
				if (num != 0)
				{
				}
				num = (short)32505856;
				if (num != 0)
				{
				}
				num = (short)1839071232;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x000C7CC0 File Offset: 0x000C5EC0
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x000C7C10 File Offset: 0x000C5E10
		internal string CurrentRadioID
		{
			get
			{
				short num = (short)1156055041;
				if (num != 0)
				{
				}
				num = (short)630406821;
				short num2 = num;
				num = (short)362036901;
				switch (num2 == num)
				{
				}
				num = (short)1818755072;
				if (num != 0)
				{
				}
				num = (short)19398656;
				short num3 = num;
				return this.d;
			}
			set
			{
				short num = (short)590151681;
				if (num != 0)
				{
				}
				num = (short)1086299111;
				short num2 = num;
				num = (short)1986763751;
				switch (num2 == num)
				{
				}
				num = (short)251658240;
				if (num != 0)
				{
				}
				num = (short)1642528768;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x000C7E28 File Offset: 0x000C6028
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x000C7D74 File Offset: 0x000C5F74
		public string ARSIpAddress
		{
			[CompilerGenerated]
			get
			{
				short num = (short)1836372015;
				short num2 = num;
				num = (short)1066848303;
				switch (num2 == num)
				{
				}
				num = (short)400031745;
				if (num != 0)
				{
				}
				num = (short)954531840;
				if (num != 0)
				{
				}
				num = (short)1480392704;
				short num3 = num;
				return this.x;
			}
			[CompilerGenerated]
			set
			{
				short num = (short)1834880138;
				short num2 = num;
				num = (short)64294026;
				switch (num2 == num)
				{
				}
				num = (short)1048379393;
				if (num != 0)
				{
				}
				num = (short)1492516864;
				if (num != 0)
				{
				}
				num = (short)1743060992;
				short num3 = num;
				this.x = value;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x000C7ED8 File Offset: 0x000C60D8
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x000C7F88 File Offset: 0x000C6188
		internal bool WriteProtectWriteProtectedRad
		{
			get
			{
				short num = (short)1460628015;
				short num2 = num;
				num = (short)927492655;
				switch (num2 == num)
				{
				}
				num = (short)2066481153;
				if (num != 0)
				{
				}
				num = (short)386203648;
				if (num != 0)
				{
				}
				num = (short)1803157504;
				short num3 = num;
				return this.f;
			}
			set
			{
				short num = (short)1488125953;
				if (num != 0)
				{
				}
				num = (short)1140821232;
				short num2 = num;
				num = (short)1499630832;
				switch (num2 == num)
				{
				}
				num = (short)521863168;
				if (num != 0)
				{
				}
				num = (short)180617216;
				short num3 = num;
				this.f = value;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x000C8038 File Offset: 0x000C6238
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x000C80F4 File Offset: 0x000C62F4
		public int RetryCount
		{
			get
			{
				short num = (short)1357100159;
				short num2 = num;
				num = (short)1966257279;
				switch (num2 == num)
				{
				}
				num = (short)915275776;
				if (num != 0)
				{
				}
				num = (short)858587137;
				if (num != 0)
				{
				}
				num = (short)1331101696;
				short num3 = num;
				int result = 0;
				int.TryParse(this.txtbxRetryCount.Text, out result);
				return result;
			}
			set
			{
				int a_ = 3;
				short num;
				try
				{
					num = (short)1538752517;
					short num2 = num;
					num = (short)188645381;
					switch (num2 == num)
					{
					}
					num = (short)1245184;
					if (num != 0)
					{
					}
					this.txtbxRetryCount.Text = Convert.ToString(value);
				}
				catch (Exception)
				{
					this.txtbxRetryCount.Text = RptMgrErrorHandler.b("뚅", a_);
				}
				num = (short)745078785;
				if (num != 0)
				{
				}
				num = (short)1382481920;
				short num3 = num;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x000C81E4 File Offset: 0x000C63E4
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x000C8294 File Offset: 0x000C6494
		internal int CurRetry
		{
			get
			{
				short num = (short)1956290974;
				short num2 = num;
				num = (short)272540062;
				switch (num2 == num)
				{
				}
				num = (short)1143078913;
				if (num != 0)
				{
				}
				num = (short)578682880;
				if (num != 0)
				{
				}
				num = (short)1222901760;
				short num3 = num;
				return this.h;
			}
			set
			{
				short num = (short)60293121;
				if (num != 0)
				{
				}
				num = (short)2095597147;
				short num2 = num;
				num = (short)2014856795;
				switch (num2 == num)
				{
				}
				num = (short)189399040;
				if (num != 0)
				{
				}
				num = (short)203554816;
				short num3 = num;
				this.h = value;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x000C83F4 File Offset: 0x000C65F4
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x000C8344 File Offset: 0x000C6544
		internal bool CancelBatchProgramming
		{
			[CompilerGenerated]
			get
			{
				short num = (short)477236067;
				short num2 = num;
				num = (short)567610211;
				switch (num2 == num)
				{
				}
				num = (short)823787521;
				if (num != 0)
				{
				}
				num = (short)564199424;
				if (num != 0)
				{
				}
				num = (short)77135872;
				short num3 = num;
				return this.y;
			}
			[CompilerGenerated]
			set
			{
				short num = (short)393861236;
				short num2 = num;
				num = (short)825284724;
				switch (num2 == num)
				{
				}
				num = (short)479985665;
				if (num != 0)
				{
				}
				num = (short)621412352;
				if (num != 0)
				{
				}
				num = (short)1155137536;
				short num3 = num;
				this.y = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x000C855C File Offset: 0x000C675C
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x000C84A8 File Offset: 0x000C66A8
		internal bool BatchProgrammingInProgress
		{
			[CompilerGenerated]
			get
			{
				short num = (short)520814593;
				if (num != 0)
				{
				}
				num = (short)604587017;
				short num2 = num;
				num = (short)2028160009;
				switch (num2 == num)
				{
				}
				num = (short)1565065216;
				if (num != 0)
				{
				}
				num = (short)1879703552;
				short num3 = num;
				return this.z;
			}
			[CompilerGenerated]
			set
			{
				short num = (short)112216457;
				short num2 = num;
				num = (short)1602898313;
				switch (num2 == num)
				{
				}
				num = (short)263258113;
				if (num != 0)
				{
				}
				num = (short)973668352;
				if (num != 0)
				{
				}
				num = (short)2045050880;
				short num3 = num;
				this.z = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x000C86BC File Offset: 0x000C68BC
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x000C860C File Offset: 0x000C680C
		internal bool BatchProgrammingComplete
		{
			[CompilerGenerated]
			get
			{
				short num = (short)1051287309;
				short num2 = num;
				num = (short)1469669133;
				switch (num2 == num)
				{
				}
				num = (short)1053949952;
				if (num != 0)
				{
				}
				num = (short)790560769;
				if (num != 0)
				{
				}
				num = (short)2026897408;
				short num3 = num;
				return this.aa;
			}
			[CompilerGenerated]
			set
			{
				short num = (short)335216641;
				if (num != 0)
				{
				}
				num = (short)394385126;
				short num2 = num;
				num = (short)2017056486;
				switch (num2 == num)
				{
				}
				num = (short)1482686464;
				if (num != 0)
				{
				}
				num = (short)1957036032;
				short num3 = num;
				this.aa = value;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x000C876C File Offset: 0x000C696C
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x000C881C File Offset: 0x000C6A1C
		internal PNServer TargetARS
		{
			get
			{
				short num = (short)1209073665;
				if (num != 0)
				{
				}
				num = (short)1310803833;
				short num2 = num;
				num = (short)617760633;
				switch (num2 == num)
				{
				}
				num = (short)1808400384;
				if (num != 0)
				{
				}
				num = (short)485949440;
				short num3 = num;
				return this.s;
			}
			set
			{
				short num = (short)789115127;
				short num2 = num;
				num = (short)1156509943;
				switch (num2 == num)
				{
				}
				num = (short)379256833;
				if (num != 0)
				{
				}
				num = (short)1594425344;
				if (num != 0)
				{
				}
				num = (short)481755136;
				short num3 = num;
				this.s = value;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x000C88D0 File Offset: 0x000C6AD0
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x000C897C File Offset: 0x000C6B7C
		internal byte[] DhBuff
		{
			get
			{
				short num = (short)134536832;
				short num2 = num;
				num = (short)902356608;
				switch (num2 == num)
				{
				}
				num = (short)195100672;
				if (num != 0)
				{
				}
				num = (short)1771175936;
				short num3 = num;
				num = (short)1070268417;
				if (num != 0)
				{
				}
				return this.t;
			}
			set
			{
				short num = (short)1192951809;
				if (num != 0)
				{
				}
				num = (short)1677027356;
				short num2 = num;
				num = (short)1566402588;
				switch (num2 == num)
				{
				}
				num = (short)1482424320;
				short num3 = num;
				num = (short)1981808640;
				if (num != 0)
				{
				}
				this.t = value;
			}
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x000C8A30 File Offset: 0x000C6C30
		internal void OnLoaded(object sender, RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				IEnumerator enumerator;
				switch (num)
				{
				case 0:
					goto IL_3AB;
				case 1:
				{
					num2 = (short)1399535257;
					short num3 = num2;
					num2 = (short)665073305;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1768357888;
						if (num2 != 0)
						{
						}
						if (this.TargetARS != null)
						{
							num2 = (short)1719402497;
							if (num2 != 0)
							{
							}
							num2 = (short)999817218;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_3AB;
					}
					break;
				}
				case 2:
					this.txtboxArsServer.Text = this.TargetARS.PNSName;
					this.ARSIpAddress = this.TargetARS.PNServerIP.ToString();
					num2 = (short)1932263424;
					num = (int)((IntPtr)num2);
					continue;
				case 3:
					try
					{
						num2 = (short)308019209;
						num = (int)((IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 1:
								if (!this.ARSServerEnabled)
								{
									num2 = (short)353173510;
									num = (int)((IntPtr)num2);
									continue;
								}
								break;
							case 2:
							{
								POP25RadioInfo pop25RadioInfo;
								pop25RadioInfo.Radio_IP_ARS_Check = false;
								num2 = (short)1245642760;
								num = (int)((IntPtr)num2);
								continue;
							}
							case 3:
								num2 = (short)1702363146;
								num = (int)((IntPtr)num2);
								continue;
							case 4:
								if (this.ARSServerEnabled)
								{
									num2 = (short)742129671;
									num = (int)((IntPtr)num2);
									continue;
								}
								goto IL_2E1;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)1152581635;
									num = (int)((IntPtr)num2);
									continue;
								}
								POP25RadioInfo pop25RadioInfo = (POP25RadioInfo)enumerator.Current;
								num2 = (short)1160708100;
								num = (int)((IntPtr)num2);
								continue;
							}
							case 6:
							{
								POP25RadioInfo pop25RadioInfo;
								pop25RadioInfo.Radio_ID_Check = false;
								num2 = (short)1564082176;
								num = (int)((IntPtr)num2);
								continue;
							}
							case 7:
								num2 = (short)900988939;
								num = (int)((IntPtr)num2);
								continue;
							case 9:
								switch (0)
								{
								case 0:
									goto IL_1D7;
								}
								continue;
							case 10:
								goto IL_337;
							case 11:
							{
								POP25RadioInfo pop25RadioInfo;
								if (pop25RadioInfo.Radio_ID != "")
								{
									num2 = (short)1495400450;
									num = (int)((IntPtr)num2);
									continue;
								}
								goto IL_2E1;
							}
							}
							IL_23F:
							num2 = (short)382926853;
							num = (int)((IntPtr)num2);
							continue;
							IL_1D7:
							goto IL_23F;
							IL_2E1:
							num2 = (short)699400193;
							num = (int)((IntPtr)num2);
						}
						IL_337:
						goto IL_41E;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_358;
						}
						IDisposable disposable;
						for (;;)
						{
							IL_346:
							switch (num)
							{
							case 0:
								if (disposable != null)
								{
									num2 = (short)1588133890;
									num = (int)((IntPtr)num2);
									continue;
								}
								goto IL_3AA;
							case 1:
								goto IL_3A8;
							case 2:
								disposable.Dispose();
								num2 = (short)1605566465;
								num = (int)((IntPtr)num2);
								continue;
							}
							goto IL_358;
						}
						IL_3A8:
						IL_3AA:
						goto EndFinally_9;
						IL_358:
						disposable = (enumerator as IDisposable);
						num2 = (short)442040320;
						num = (int)((IntPtr)num2);
						goto IL_346;
						EndFinally_9:;
					}
					goto IL_3AB;
				}
				goto IL_20;
				IL_3AB:
				enumerator = ((IEnumerable)this.dgBatchProgrammingProgress.Items).GetEnumerator();
				num2 = (short)61472771;
				num = (int)((IntPtr)num2);
			}
			IL_41E:
			this.r = RadioAccessValidator.CacheCodeplugSecurityFields(out this.k, out this.l, out this.m, out this.n, out this.o, out this.q, out this.p);
			return;
			IL_20:
			num2 = (short)1143668736;
			short num4 = num2;
			this.a = new DispatcherTimer();
			this.a.Interval = TimeSpan.FromMilliseconds(5000.0);
			this.a.Tick += this.batchCloneTimer_Tick;
			this.a.Start();
			this.pbBatchProgrammingProgress.Value = 0.0;
			this.pbOverallBatchProgrammingProgress.Value = 0.0;
			this.btnBatchProgrammingClose.IsEnabled = false;
			this.btnSaveToFile.IsEnabled = false;
			num2 = (short)1270480897;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x000C8EAC File Offset: 0x000C70AC
		internal void OnUnLoaded(object sender, RoutedEventArgs e)
		{
			short num = (short)2077622273;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				IEnumerator enumerator;
				switch (num2)
				{
				case 0:
				{
					num = (short)901709825;
					if (num != 0)
					{
					}
					num = (short)229507072;
					short num3 = num;
					goto IL_185;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					RadioAccessValidator.RestoreCachedCodeplugSecurityFields(this.k, this.l, this.m, this.n, this.o, this.q, this.p);
					num = (short)353566720;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
				{
					num = (short)639613397;
					short num4 = num;
					num = (short)2050275797;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3F;
					default:
						num = (short)1670184960;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1271529474;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)758054915;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_91;
									}
									continue;
								case 3:
									goto IL_110;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)808779776;
										num2 = (int)((IntPtr)num);
										continue;
									}
									POP25RadioInfo pop25RadioInfo = (POP25RadioInfo)enumerator.Current;
									pop25RadioInfo.Radio_IP_ARS_Check = true;
									pop25RadioInfo.Radio_ID_Check = true;
									num = (short)1554513921;
									num2 = (int)((IntPtr)num);
									continue;
								}
								}
								IL_C2:
								num = (short)171376644;
								num2 = (int)((IntPtr)num);
								continue;
								IL_91:
								goto IL_C2;
							}
							IL_110:
							goto IL_29E;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_131;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_11F:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)860618754;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_184;
								case 1:
									goto IL_182;
								case 2:
									disposable.Dispose();
									num = (short)2106785793;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_131;
							}
							IL_182:
							IL_184:
							goto EndFinally_5;
							IL_131:
							disposable = (enumerator as IDisposable);
							num = (short)1427308544;
							num2 = (int)((IntPtr)num);
							goto IL_11F;
							EndFinally_5:;
						}
						goto IL_185;
					}
					break;
				}
				}
				goto IL_34;
				IL_3F:
				num = (short)2040463362;
				num2 = (int)((IntPtr)num);
				continue;
				IL_34:
				if (this.r)
				{
					goto IL_3F;
				}
				IL_185:
				enumerator = ((IEnumerable)this.dgBatchProgrammingProgress.Items).GetEnumerator();
				num = (short)2051866627;
				num2 = (int)((IntPtr)num);
			}
			IL_29E:
			this.v.Clear();
			this.w.Clear();
			this.dgBatchProgrammingProgress.Items.Clear();
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x000C9190 File Offset: 0x000C7390
		private void batchCloneTimer_Tick(object A_0, EventArgs A_1)
		{
			short num = (short)2054946816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1976369156;
				num2 = (int)((IntPtr)num);
				for (;;)
				{
					IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)1794048000;
						short num3 = num;
						num = (short)1744366490;
						short num4 = num;
						num = (short)572189594;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C4;
						default:
							num = (short)336199680;
							if (num != 0)
							{
							}
							try
							{
								num = (short)480772098;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)991363076;
											num2 = (int)((IntPtr)num);
											continue;
										}
										POP25RadioInfo item = (POP25RadioInfo)enumerator.Current;
										this.w.Add(item);
										num = (short)891158528;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_105;
										}
										continue;
									case 3:
										goto IL_183;
									case 4:
										num = (short)139853827;
										num2 = (int)((IntPtr)num);
										continue;
									}
									IL_107:
									num = (short)623837185;
									num2 = (int)((IntPtr)num);
									continue;
									IL_105:
									goto IL_107;
								}
								IL_183:
								goto IL_86;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_1A5;
								}
								IDisposable disposable;
								for (;;)
								{
									IL_192:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)403636226;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_1F9;
									case 1:
										goto IL_1F7;
									case 2:
										disposable.Dispose();
										num = (short)1218052097;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_1A5;
								}
								IL_1F7:
								IL_1F9:
								goto EndFinally_7;
								IL_1A5:
								disposable = (enumerator as IDisposable);
								num = (short)312541184;
								num2 = (int)((IntPtr)num);
								goto IL_192;
								EndFinally_7:;
							}
							goto IL_1FA;
							IL_86:
							num = (short)248578051;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_1FA;
					case 3:
						if (this.w.Count > 0)
						{
							num = (short)541196293;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					case 5:
						goto IL_C4;
					case 6:
						goto IL_2E2;
					}
					IL_61:
					if (this.a != null)
					{
						num = (short)112066562;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2E2;
					IL_1FA:
					this.a.Stop();
					num = (short)620953606;
					num2 = (int)((IntPtr)num);
					continue;
					IL_C4:
					num = (short)225837057;
					if (num != 0)
					{
					}
					this.totItems = (double)this.dgBatchProgrammingProgress.Items.Count;
					POP25RadioInfo pop25RadioInfo = this.w[0];
					this.dgBatchProgrammingProgress.SelectedItem = this.dgBatchProgrammingProgress.Items[pop25RadioInfo.IndexInList];
					this.dgBatchProgrammingProgress.ScrollIntoView(this.dgBatchProgrammingProgress.Items[pop25RadioInfo.IndexInList]);
					pop25RadioInfo.Status = AppResources.In_Progress;
					this.CloneRadioUsingRadioIdOrRadioIp(pop25RadioInfo);
					num = (short)363528192;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2E2:
					enumerator = ((IEnumerable)this.dgBatchProgrammingProgress.Items).GetEnumerator();
					num = (short)474087425;
					num2 = (int)((IntPtr)num);
				}
				return;
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x000C9534 File Offset: 0x000C7734
		private bool a(POP25RadioInfo A_0)
		{
			int a_ = 13;
			short num = (short)461635584;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B0;
				}
				string text;
				bool flag;
				int num5;
				bool flag2;
				string text2;
				for (;;)
				{
					IL_31:
					SubscriptionType mode;
					switch (num2)
					{
					case 0:
					{
						num = (short)1693057024;
						short num3 = num;
						num = (short)2090467334;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 1:
					{
						int num4;
						if (int.TryParse(this.i.OTAP_CPS_SESSION_INACTIVITY_TIMER, out num4))
						{
							num = (short)587202560;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_4AB;
					}
					case 2:
						goto IL_3DC;
					case 3:
					{
						ARSGetPOP25BatchIPAddress arsgetPOP25BatchIPAddress;
						if (arsgetPOP25BatchIPAddress.ARSResult.DevicePrescence == OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_TIMEOUT)
						{
							num = (short)1171193875;
							num2 = (int)((IntPtr)num);
							continue;
						}
						text = AppResources.Radio_CurrentRadioID_CurrentRadioIpAddress_Radio_presence_is_unknown_on_the_ARS.AcpStringFormat(new object[]
						{
							this.CurrentRadioID,
							this.CurrentRadioIpAddress
						});
						A_0.Status = AppResources.FAILED_All_UpperCase_Id;
						num = (short)828047385;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 4:
						if (flag)
						{
							num = (short)1411710996;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_6FE;
					case 5:
						text = AppResources.Radio_CurrentRadioID_CurrentRadioIpAddress_Radio_presence_is_absent_on_the_ARS.AcpStringFormat(new object[]
						{
							this.CurrentRadioID,
							this.CurrentRadioIpAddress
						});
						A_0.Status = AppResources.FAILED_All_UpperCase_Id;
						num = (short)1503657986;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
					{
						int num4;
						if (num4 == 0)
						{
							num = (short)852754456;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_4AB;
					}
					case 7:
					{
						ARSGetPOP25BatchIPAddress arsgetPOP25BatchIPAddress;
						if (arsgetPOP25BatchIPAddress.ARSResult.DevicePrescence == OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_ABSENT)
						{
							num = (short)225312773;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_102;
					}
					case 8:
					{
						ARSGetPOP25BatchIPAddress arsgetPOP25BatchIPAddress;
						if (arsgetPOP25BatchIPAddress.ARSResult.DevicePrescence == OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_PRESENT)
						{
							num = (short)1956839440;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)440401927;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 9:
						goto IL_3DC;
					case 10:
					{
						ARSGetPOP25BatchIPAddress arsgetPOP25BatchIPAddress;
						if (arsgetPOP25BatchIPAddress.ARSResult.NetworkError != null)
						{
							num = (short)318242845;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_6FE;
					}
					case 11:
						goto IL_378;
					case 12:
						if (num5 > 0)
						{
							num = (short)351993877;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_422;
					case 13:
					{
						int num4 = 8;
						num = (short)1172635649;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 14:
						num = (short)423755788;
						num2 = (int)((IntPtr)num);
						continue;
					case 15:
						try
						{
							int num4;
							this.i.OTAP_CPS_SESSION_INACTIVITY_TIMER = Convert.ToString(num4);
							this.i.Save();
							goto IL_4AB;
						}
						catch
						{
							goto IL_4AB;
						}
						goto IL_559;
					case 16:
					{
						ARSGetPOP25BatchIPAddress arsgetPOP25BatchIPAddress;
						this.CurrentRadioIpAddress = arsgetPOP25BatchIPAddress.ARSResult.DeviceIPAddress;
						this.CurrentRadioID = A_0.Radio_ID;
						flag2 = true;
						num = (short)2018639881;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 17:
						mode = SubscriptionType.Secure;
						num = (short)1110835222;
						num2 = (int)((IntPtr)num);
						continue;
					case 18:
						if (num5 <= 16777211)
						{
							num = (short)1386414093;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_422;
					case 19:
						text = AppResources.Radio_CurrentRadioID_CurrentRadioIpAddress_Radio_look_up_has_timed_out_on_the_ARS.AcpStringFormat(new object[]
						{
							this.CurrentRadioID,
							this.CurrentRadioIpAddress
						});
						A_0.Status = AppResources.FAILED_All_UpperCase_Id;
						num = (short)1120927767;
						num2 = (int)((IntPtr)num);
						continue;
					case 20:
					{
						ARSGetPOP25BatchIPAddress arsgetPOP25BatchIPAddress = new ARSGetPOP25BatchIPAddress(this.TargetARS.PNServerIP.ToString(), this.TargetARS.PortNum, this.TargetARS.PortNum, this.TargetARS.CipherSuite, mode, num5, this.TargetARS.SecureConn, this.TargetARS.CACert, this.TargetARS.ClientCert, this.TargetARS.PassWordPhrase, this.DhBuff);
						arsgetPOP25BatchIPAddress.GetIPAddressFromARS();
						num = (short)1994784776;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 21:
						goto IL_559;
					case 22:
						goto IL_37D;
					case 23:
						goto IL_3DC;
					case 24:
					{
						int num4 = 8;
						num = (short)2139488271;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 25:
						goto IL_3DC;
					case 26:
						goto IL_4A6;
					case 27:
						if (int.TryParse(A_0.Radio_ID, out num5))
						{
							num = (short)1435762702;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_422;
					case 28:
						if (this.TargetARS.SecureConn)
						{
							num = (short)2046361617;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_37D;
					case 29:
					{
						ARSGetPOP25BatchIPAddress arsgetPOP25BatchIPAddress;
						text2 = arsgetPOP25BatchIPAddress.ARSResult.NetworkError;
						num = (short)177799179;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					goto IL_B0;
					IL_102:
					num = (short)1275920387;
					num2 = (int)((IntPtr)num);
					continue;
					IL_559:
					num = (short)717684737;
					if (num != 0)
					{
					}
					num = (short)2078192266;
					short num6 = num;
					num = (short)1403630218;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_102;
					default:
						num = (short)1734541312;
						if (num != 0)
						{
						}
						num = (short)843579410;
						num2 = (int)((IntPtr)num);
						continue;
					}
					IL_37D:
					num = (short)1407909892;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3DC:
					num = (short)991887370;
					num2 = (int)((IntPtr)num);
					continue;
					IL_422:
					text = string.Concat(new string[]
					{
						AppResources.Radio_Colon,
						RptMgrErrorHandler.b("낏", a_),
						this.CurrentRadioID,
						RptMgrErrorHandler.b("뾏", a_),
						this.CurrentRadioIpAddress,
						RptMgrErrorHandler.b("낏늑릓뮕뢗몙", a_),
						AppResources.Invalid_Radio_ID
					});
					A_0.Status = AppResources.FAILED_All_UpperCase_Id;
					num = (short)1307770906;
					num2 = (int)((IntPtr)num);
					continue;
					IL_4AB:
					mode = SubscriptionType.Unreliable;
					num = (short)1054933020;
					num2 = (int)((IntPtr)num);
				}
				IL_378:
				IL_4A6:
				IL_6FE:
				base.Dispatcher.BeginInvoke(new POP25BatchProgrammerProgress.RadioPresent(this.ProcessRadio), new object[]
				{
					A_0,
					flag2,
					text,
					text2
				});
				return flag2;
				IL_B0:
				flag2 = false;
				flag = true;
				text = null;
				text2 = null;
				num5 = 0;
				num = (short)294780955;
				num2 = (int)((IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x000C9C84 File Offset: 0x000C7E84
		private void btnBack_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)344512067;
			short num2 = num;
			num = (short)2078529091;
			switch (num2 == num)
			{
			}
			num = (short)844431361;
			if (num != 0)
			{
			}
			num = (short)520617984;
			short num3 = num;
			num = (short)1585643520;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x000C9D30 File Offset: 0x000C7F30
		private void btnCancel_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)943718401;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_13B;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
					num = (short)622395395;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					if (System.Windows.MessageBox.Show(AppResources.Warning_Batch_Programming_Is_Currently_Running_Do_You_Want_Cancel, AppResources.Cancel_Batch_Programming, MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
					{
						goto IL_122;
					}
					return;
				}
				IL_35:
				num = (short)2136445181;
				short num3 = num;
				num = (short)400134397;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_122:
					num = (short)1517813760;
					num2 = (int)((IntPtr)num);
					break;
				default:
					num = (short)1802174465;
					if (num != 0)
					{
					}
					num = (short)1793654784;
					if (num != 0)
					{
					}
					if (!this.BatchProgrammingInProgress)
					{
						return;
					}
					num = (short)880607234;
					num2 = (int)((IntPtr)num);
					break;
				}
			}
			IL_13B:
			num = (short)534315008;
			short num4 = num;
			this.CancelBatchProgramming = true;
			this.btnBatchProgrammingCancel.IsEnabled = false;
			System.Windows.MessageBox.Show(AppResources.Batch_Programming_Will_Cancelled_After_Current_Radio_Programmed, AppResources.Warning_Id, MessageBoxButton.OK, MessageBoxImage.Exclamation);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x000C9EA8 File Offset: 0x000C80A8
		private void btnClose_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)719267874;
			short num2 = num;
			num = (short)2146052130;
			switch (num2 == num)
			{
			}
			num = (short)1963393024;
			if (num != 0)
			{
			}
			num = (short)1484587008;
			short num3 = num;
			num = (short)448397313;
			if (num != 0)
			{
			}
			base.Close();
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x000C9F58 File Offset: 0x000C8158
		private void ProgressWindowClosing(object A_0, CancelEventArgs A_1)
		{
			short num = (short)905510913;
			if (num != 0)
			{
			}
			num = (short)1200357379;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1245642753;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					if (System.Windows.MessageBox.Show(AppResources.Warning_Batch_Programming_Is_Currently_Running_Do_You_Want_Cancel, AppResources.Cancel_Batch_Programming, MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
					{
						goto IL_116;
					}
					goto IL_86;
				case 2:
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 4:
				{
					num = (short)220108465;
					short num3 = num;
					num = (short)1656788657;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_116;
					default:
					{
						num = (short)934936576;
						if (num != 0)
						{
						}
						num = (short)474611712;
						short num4 = num;
						this.CancelBatchProgramming = true;
						this.btnBatchProgrammingCancel.IsEnabled = false;
						System.Windows.MessageBox.Show(AppResources.Batch_Programming_Cancelled_After_The_Current_Radio_Programmed, AppResources.Warning_Id, MessageBoxButton.OK, MessageBoxImage.Exclamation);
						num = (short)788856837;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 5:
					goto IL_86;
				}
				IL_64:
				if (this.BatchProgrammingInProgress)
				{
					num = (short)237371392;
					num2 = (int)((IntPtr)num);
					continue;
				}
				break;
				IL_86:
				A_1.Cancel = true;
				num = (short)1032650754;
				num2 = (int)((IntPtr)num);
				continue;
				IL_116:
				num = (short)1913782276;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x000CA110 File Offset: 0x000C8310
		private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1319421185;
			short num2 = num;
			num = (short)1109837057;
			switch (num2 == num)
			{
			}
			num = (short)1682178048;
			if (num != 0)
			{
			}
			num = (short)110100480;
			short num3 = num;
			num = (short)850526209;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x000CA1C0 File Offset: 0x000C83C0
		private void btnProgressWndHelp_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 15;
			short num;
			try
			{
				num = (short)2091571661;
				short num2 = num;
				num = (short)1256053197;
				switch (num2 == num)
				{
				}
				num = (short)289275904;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(RptMgrErrorHandler.b("놑ꖕꪗꦝ쎟閡", a_));
			}
			catch (Exception)
			{
			}
			num = (short)1262944257;
			if (num != 0)
			{
			}
			num = (short)580648960;
			short num3 = num;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x000CA2A0 File Offset: 0x000C84A0
		private void btnSaveAs_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_5D;
			}
			int num;
			short num2;
			SaveFileDialog saveFileDialog;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_407;
				case 1:
				{
					string text;
					if (!string.IsNullOrEmpty(text))
					{
						num2 = (short)392953859;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
				{
					string text;
					if (File.Exists(text))
					{
						num2 = (short)1290469376;
						short num3 = num2;
						num2 = (short)1864302608;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_482;
				}
				case 3:
					goto IL_35A;
				case 4:
					if (System.Windows.MessageBox.Show(AppResources.File_You_Save_Is_Readonly, AppResources.Error_Saving_The_Log_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
					{
						num2 = (short)291897358;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 5:
					num2 = (short)906166281;
					num = (int)((IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1368588296;
					num = (int)((IntPtr)num2);
					continue;
				case 7:
				{
					string text;
					if (File.Exists(text))
					{
						num2 = (short)1096089606;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_464;
				}
				case 8:
				{
					string text;
					if ((File.GetAttributes(text) & FileAttributes.Hidden) == FileAttributes.Hidden)
					{
						num2 = (short)1484259333;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_464;
				}
				case 9:
					if (System.Windows.MessageBox.Show(AppResources.File_You_Save_Is_Hidden, AppResources.Error_Saving_The_Log_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
					{
						num2 = (short)1775632384;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 10:
					num2 = (short)1285095428;
					num = (int)((IntPtr)num2);
					continue;
				case 11:
				{
					string text;
					if ((File.GetAttributes(text) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
					{
						num2 = (short)1665400842;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_482;
				}
				case 12:
				{
					string text = saveFileDialog.FileName;
					num2 = (short)1181941761;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 13:
					try
					{
						num2 = (short)739573763;
						num = (int)((IntPtr)num2);
						for (;;)
						{
							string text;
							StreamWriter streamWriter;
							switch (num)
							{
							case 0:
								try
								{
									streamWriter.Write(this.txtBoxProgressStatus.Text);
									streamWriter.Flush();
								}
								finally
								{
									num2 = (short)1012989953;
									num = (int)((IntPtr)num2);
									for (;;)
									{
										switch (num)
										{
										case 0:
											goto IL_2F9;
										case 1:
										{
											num2 = (short)1942244285;
											short num4 = num2;
											num2 = (short)1678658493;
											switch ((num4 == num2) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_2DC;
											default:
												num2 = (short)303169536;
												if (num2 != 0)
												{
												}
												switch (0)
												{
												case 0:
													goto IL_2C5;
												}
												continue;
											}
											break;
										}
										case 2:
											goto IL_2DC;
										}
										IL_2C5:
										if (streamWriter != null)
										{
											num2 = (short)523436034;
											num = (int)((IntPtr)num2);
											continue;
										}
										break;
										IL_2DC:
										((IDisposable)streamWriter).Dispose();
										num2 = (short)301858816;
										num = (int)((IntPtr)num2);
									}
									IL_2F9:;
								}
								num2 = (short)890372097;
								num = (int)((IntPtr)num2);
								continue;
							case 1:
								goto IL_313;
							case 2:
								text += RptMgrErrorHandler.b("궂", a_);
								num2 = (short)281083908;
								num = (int)((IntPtr)num2);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_1B7;
								}
								continue;
							case 4:
								goto IL_20E;
							}
							IL_1B7:
							if (!text.EndsWith(RptMgrErrorHandler.b("궂", a_)))
							{
								num2 = (short)324272130;
								num = (int)((IntPtr)num2);
								continue;
							}
							IL_20E:
							streamWriter = new StreamWriter(text);
							num2 = (short)1740046336;
							num = (int)((IntPtr)num2);
						}
						IL_313:
						return;
					}
					catch (Exception ex)
					{
						if (System.Windows.MessageBox.Show(ex.Message, AppResources.Error_Saving_The_Log_File, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
						{
							string text;
							AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AppResources.Error_Saving_The_Log_File + RptMgrErrorHandler.b("ꎂ", a_) + text);
						}
						return;
					}
					goto IL_35A;
				case 14:
					goto IL_507;
				case 15:
					if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
					{
						num2 = (short)1952907265;
						if (num2 != 0)
						{
						}
						num2 = (short)163512332;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 16:
					num2 = (short)1706098699;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_5D;
				IL_35A:
				num2 = (short)2096693250;
				num = (int)((IntPtr)num2);
				continue;
				IL_464:
				num2 = (short)1715208205;
				num = (int)((IntPtr)num2);
				continue;
				IL_482:
				num2 = (short)392757255;
				num = (int)((IntPtr)num2);
			}
			IL_407:
			AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AppResources.File_You_Save_Is_Hidden);
			return;
			IL_507:
			AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AppResources.File_You_Save_Is_Readonly);
			return;
			IL_5D:
			saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = RptMgrErrorHandler.b("캂力쾒풔\udd9aﲜ좠쾢\udca4令\udeb0\udeb2\ud8b4\ud8b6ힸﾼ\udebe뗀ꃂ귄鯆", a_);
			saveFileDialog.Filter = AppResources.Batch_Programming_Log_Filter;
			num2 = (short)1325334543;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x000CA7F0 File Offset: 0x000C89F0
		private void batProgressResultExpander_Expanded(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1363335812;
			short num2 = num;
			num = (short)148494980;
			switch (num2 == num)
			{
			}
			num = (short)2080309249;
			if (num != 0)
			{
			}
			num = (short)1500774400;
			short num3 = num;
			num = (short)738131968;
			if (num != 0)
			{
			}
			this.This.Height = 745.0;
			this.txtBoxProgressStatus.Visibility = Visibility.Visible;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x000CA8B8 File Offset: 0x000C8AB8
		private void batProgressResultExpander_Collapsed(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)47268857;
			short num2 = num;
			num = (short)558711801;
			switch (num2 == num)
			{
			}
			num = (short)1388576769;
			if (num != 0)
			{
			}
			num = (short)1146355712;
			short num3 = num;
			num = (short)331415552;
			if (num != 0)
			{
			}
			this.This.Height = 530.0;
			this.txtBoxProgressStatus.Visibility = Visibility.Collapsed;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x000CA984 File Offset: 0x000C8B84
		private bool b(string A_0)
		{
			short num2;
			bool result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_D4;
				}
				int num;
				byte b;
				byte[] addressBytes;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (b == 192)
						{
							num2 = (short)163577866;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_3F5;
					case 1:
						if (addressBytes[2] != 0)
						{
							num2 = (short)1379139604;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_5FE;
					case 2:
						if (b >= 128)
						{
							num2 = (short)800915479;
							num = (int)((IntPtr)num2);
							continue;
						}
						num2 = (short)2086404127;
						num = (int)((IntPtr)num2);
						continue;
					case 3:
						num2 = (short)69795841;
						if (num2 != 0)
						{
						}
						if (b != 127)
						{
							num2 = (short)1937506352;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_5DE;
					case 4:
						num2 = (short)124649508;
						num = (int)((IntPtr)num2);
						continue;
					case 5:
						if (b == 0)
						{
							num2 = (short)826736658;
							num = (int)((IntPtr)num2);
							continue;
						}
						num2 = (short)1051459593;
						num = (int)((IntPtr)num2);
						continue;
					case 6:
						num2 = (short)593625114;
						num = (int)((IntPtr)num2);
						continue;
					case 7:
						if (addressBytes[2] == 255)
						{
							num2 = (short)1849098244;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_559;
					case 8:
						if (b <= 223)
						{
							num2 = (short)215482381;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_5DE;
					case 9:
						if (b >= 192)
						{
							num2 = (short)698548245;
							num = (int)((IntPtr)num2);
							continue;
						}
						num2 = (short)1579155458;
						num = (int)((IntPtr)num2);
						continue;
					case 10:
						num2 = (short)1893466159;
						num = (int)((IntPtr)num2);
						continue;
					case 11:
						if (b == 128)
						{
							num2 = (short)1591672838;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_23A;
					case 12:
						num2 = (short)640876588;
						num = (int)((IntPtr)num2);
						continue;
					case 13:
						num2 = (short)91226115;
						num = (int)((IntPtr)num2);
						continue;
					case 14:
						if (addressBytes[3] == 0)
						{
							num2 = (short)1801977875;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_712;
					case 15:
						goto IL_2F7;
					case 16:
						if (addressBytes[3] == 255)
						{
							num2 = (short)963706912;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_712;
					case 17:
						goto IL_5F9;
					case 18:
						goto IL_5DE;
					case 19:
						goto IL_1DB;
					case 20:
						goto IL_3F5;
					case 21:
						num2 = (short)1624506368;
						num = (int)((IntPtr)num2);
						continue;
					case 22:
						goto IL_559;
					case 23:
						num2 = (short)1076559883;
						num = (int)((IntPtr)num2);
						continue;
					case 24:
						if (addressBytes[2] == 0)
						{
							num2 = (short)1472135180;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_2B5;
					case 25:
						if (addressBytes[2] == 0)
						{
							num2 = (short)397082665;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_712;
					case 26:
						if (addressBytes[1] != 0)
						{
							num2 = (short)1383530526;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_1DB;
					case 27:
						goto IL_2B5;
					case 28:
						num2 = (short)203096088;
						num = (int)((IntPtr)num2);
						continue;
					case 29:
						num2 = (short)406847533;
						num = (int)((IntPtr)num2);
						continue;
					case 30:
						goto IL_23A;
					case 31:
						if (addressBytes[1] == 0)
						{
							num2 = (short)210239516;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_2B5;
					case 32:
						goto IL_5FE;
					case 33:
						if (addressBytes[1] == 255)
						{
							num2 = (short)1077149730;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_712;
					case 34:
						num2 = (short)346488872;
						num = (int)((IntPtr)num2);
						continue;
					case 35:
						num2 = (short)806748161;
						num = (int)((IntPtr)num2);
						continue;
					case 36:
						if (addressBytes[3] != 255)
						{
							num2 = (short)1951006742;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_1DB;
					case 37:
						num2 = (short)460062736;
						num = (int)((IntPtr)num2);
						continue;
					case 38:
						goto IL_617;
					case 39:
						goto IL_1F5;
					case 40:
						if (addressBytes[2] == 255)
						{
							goto IL_21E;
						}
						goto IL_712;
					case 41:
						num2 = (short)688914446;
						num = (int)((IntPtr)num2);
						continue;
					case 42:
						goto IL_729;
					case 43:
						goto IL_310;
					case 44:
						if (addressBytes[3] != 0)
						{
							num2 = (short)1377370139;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_2F7;
					case 45:
						if (addressBytes[3] == 255)
						{
							num2 = (short)984743951;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_712;
					case 46:
						if (addressBytes[3] != 0)
						{
							num2 = (short)1392967717;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_5FE;
					case 47:
						if (addressBytes[1] == 0)
						{
							num2 = (short)87359523;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_3F5;
					case 48:
						num2 = (short)2139947013;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_D4;
					IL_1DB:
					result = false;
					num2 = (short)1720385575;
					num = (int)((IntPtr)num2);
					continue;
					IL_21E:
					num2 = (short)1015873565;
					num = (int)((IntPtr)num2);
					continue;
					IL_559:
					num2 = (short)639211062;
					short num3 = num2;
					num2 = (short)832869942;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_21E;
					default:
						num2 = (short)2000289792;
						if (num2 != 0)
						{
						}
						num2 = (short)1515454489;
						num = (int)((IntPtr)num2);
						continue;
					}
					IL_23A:
					num2 = (short)1402142727;
					num = (int)((IntPtr)num2);
					continue;
					IL_2B5:
					num2 = (short)784924705;
					num = (int)((IntPtr)num2);
					continue;
					IL_2F7:
					result = false;
					num2 = (short)1707671595;
					num = (int)((IntPtr)num2);
					continue;
					IL_3F5:
					num2 = (short)1464139822;
					num = (int)((IntPtr)num2);
					continue;
					IL_5DE:
					result = false;
					num2 = (short)1898315793;
					num = (int)((IntPtr)num2);
					continue;
					IL_5FE:
					result = false;
					num2 = (short)1180041254;
					num = (int)((IntPtr)num2);
					continue;
					IL_712:
					num2 = (short)1710358570;
					num = (int)((IntPtr)num2);
				}
				IL_1F5:
				IL_310:
				IL_5F9:
				IL_617:
				goto IL_732;
				IL_729:
				return true;
				IL_D4:
				addressBytes = IPAddress.Parse(A_0).GetAddressBytes();
				b = addressBytes[0];
				num2 = (short)1544486920;
				num = (int)((IntPtr)num2);
				goto IL_0A;
			}
			catch (Exception)
			{
				result = false;
				goto IL_732;
			}
			return true;
			IL_732:
			num2 = (short)372834304;
			short num4 = num2;
			return result;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x000CB10C File Offset: 0x000C930C
		internal void CloneRadioUsingRadioIdOrRadioIp(POP25RadioInfo radio)
		{
			int a_ = 17;
			short num = (short)1504509952;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				string statusMsg;
				bool bContinueClone;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						num = (short)550567939;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
					{
						if (this.b(radio.Radio_IP))
						{
							num = (short)449314827;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1366032384;
						short num3 = num;
						statusMsg = string.Concat(new string[]
						{
							AppResources.Radio_Colon,
							RptMgrErrorHandler.b("뒓", a_),
							radio.Radio_ID,
							RptMgrErrorHandler.b("뮓", a_),
							radio.Radio_IP,
							RptMgrErrorHandler.b("뒓뚕떗랙벛뺝", a_),
							AppResources.Invalid_Radio_IP_Address
						});
						radio.Status = AppResources.FAILED_All_UpperCase_Id;
						num = (short)466419720;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 2:
						num = (short)35848201;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						if (this.b(this.ARSIpAddress))
						{
							num = (short)2001731588;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_11C;
					case 4:
						num = (short)1251934222;
						num2 = (int)((IntPtr)num);
						continue;
					case 5:
						num = (short)1330839553;
						if (num != 0)
						{
						}
						if (!this.CancelBatchProgramming)
						{
							num = (short)1778253830;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_41B;
					case 6:
						this.BatchProgrammingInProgress = true;
						AppInfoManager.StatusMsgReport.Clear();
						AcpUI.Common.Utility.SaveFieldWithFocus();
						num = (short)94699527;
						num2 = (int)((IntPtr)num);
						continue;
					case 7:
						if (this.ARSServerEnabled)
						{
							num = (short)1074790400;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_11C;
					case 8:
						goto IL_27B;
					case 9:
						goto IL_39A;
					case 10:
					{
						num = (short)965317143;
						short num4 = num;
						num = (short)2126221847;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_39A;
						default:
							num = (short)531496960;
							if (num != 0)
							{
							}
							bContinueClone = true;
							num = (short)1896153101;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
						bContinueClone = true;
						num = (short)1431437324;
						num2 = (int)((IntPtr)num);
						continue;
					case 12:
						goto IL_2EF;
					case 13:
						goto IL_31D;
					case 14:
						if (radio.Radio_ID == "")
						{
							num = (short)1467875330;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_36B;
					}
					goto IL_73;
					IL_11C:
					num = (short)824442881;
					num2 = (int)((IntPtr)num);
					continue;
					IL_39A:
					if (!this.b(radio.Radio_IP))
					{
						break;
					}
					num = (short)152043530;
					num2 = (int)((IntPtr)num);
				}
				IL_167:
				this.ProcessRadio(radio, bContinueClone, statusMsg, null);
				return;
				IL_27B:
				IL_2EF:
				this.ProcessRadio(radio, bContinueClone, statusMsg, null);
				return;
				IL_31D:
				goto IL_167;
				IL_36B:
				new Thread(delegate()
				{
					short num5 = (short)2034499584;
					short num6 = num5;
					num5 = (short)188350465;
					if (num5 != 0)
					{
					}
					num5 = (short)1327562226;
					short num7 = num5;
					num5 = (short)1140588018;
					switch (num7 == num5)
					{
					}
					num5 = (short)1225981952;
					if (num5 != 0)
					{
					}
					this.a(radio);
				}).Start();
				return;
				IL_41B:
				this.BatchProgrammingComplete = true;
				this.BatchProgrammingInProgress = false;
				this.btnBatchProgrammingClose.IsEnabled = true;
				this.btnSaveToFile.IsEnabled = true;
				radio.Status = AppResources.Cancelled_Id;
				statusMsg = AppResources.User_Action_Batch_Programming_Cancelled;
				this.txtBoxProgressStatus.AppendText(string.Concat(new string[]
				{
					RptMgrErrorHandler.b("馓鲕", a_),
					DateTime.Now.ToString(),
					RptMgrErrorHandler.b("뒓뮕떗몙", a_),
					AppResources.User_Action_Batch_Programming_Cancelled,
					Environment.NewLine
				}));
				this.txtBoxProgressStatus.ScrollToEnd();
				this.ProcessRadio(radio, bContinueClone, statusMsg, null);
				return;
				IL_73:
				statusMsg = null;
				bContinueClone = false;
				this.WriteToLogCurrentPass();
				this.CurrentRadioIpAddress = radio.Radio_IP;
				this.CurrentRadioID = radio.Radio_ID;
				num = (short)1876295685;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x000CB5E4 File Offset: 0x000C97E4
		internal void ProcessRadio(POP25RadioInfo radio, bool bContinueClone, string statusMsg, string networkError)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					this.ProgText.Text = networkError.AcpStringFormat(new object[]
					{
						this.CurrentRadioID,
						this.CurrentRadioIpAddress
					});
					AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, networkError);
					this.WriteToLog_Failure();
					num2 = (short)153026562;
					num = (int)((IntPtr)num2);
					continue;
				case 1:
					if (bContinueClone)
					{
						num2 = (short)1986265099;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_37C;
				case 2:
					goto IL_265;
				case 3:
					goto IL_7E;
				case 4:
					this.ProgText.Text = statusMsg.AcpStringFormat(new object[]
					{
						this.CurrentRadioID,
						this.CurrentRadioIpAddress
					});
					this.WriteToLog_Failure();
					num2 = (short)1823408138;
					num = (int)((IntPtr)num2);
					continue;
				case 5:
					if (networkError != null)
					{
						num2 = (short)816971776;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_265;
				case 6:
					radio.Radio_IP = radio.Radio_IP + RptMgrErrorHandler.b("ꖄ꾆", a_) + this.CurrentRadioIpAddress + RptMgrErrorHandler.b("겄", a_);
					num2 = (short)2121203721;
					num = (int)((IntPtr)num2);
					continue;
				case 7:
					if (!radio.Radio_IP.Contains(RptMgrErrorHandler.b("ꖄ꾆", a_) + this.CurrentRadioIpAddress + RptMgrErrorHandler.b("겄", a_)))
					{
						num2 = (short)1147404289;
						if (num2 != 0)
						{
						}
						num2 = (short)1836515334;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_22A;
				case 8:
				{
					num2 = (short)435033659;
					short num3 = num2;
					num2 = (short)1180374587;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7E;
					case 1:
						break;
					default:
					{
						num2 = (short)876216320;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)1311113216;
					if (num2 != 0)
					{
					}
					num2 = (short)329908231;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 9:
					goto IL_22A;
				case 10:
					goto IL_181;
				case 11:
					goto IL_260;
				case 12:
					if (this.CurrentRadioIpAddress != radio.Radio_IP && bContinueClone)
					{
						num2 = (short)1705639944;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_22A;
				}
				goto IL_4D;
				IL_7E:
				if (!bContinueClone)
				{
					num2 = (short)890634244;
					num = (int)((IntPtr)num2);
					continue;
				}
				IL_181:
				num2 = (short)1921318917;
				num = (int)((IntPtr)num2);
				continue;
				IL_22A:
				num2 = (short)1972109313;
				num = (int)((IntPtr)num2);
				continue;
				IL_265:
				num2 = (short)1019019276;
				num = (int)((IntPtr)num2);
			}
			IL_260:
			new PackUnpackExecutor().PrePackHandler();
			int status_int;
			int status;
			new Thread(delegate()
			{
				switch (0)
				{
				case 0:
					goto IL_3C;
				}
				int num5;
				short num6;
				Clone clone;
				for (;;)
				{
					IL_0A:
					switch (num5)
					{
					case 0:
						num6 = (short)1855193097;
						num5 = (int)((IntPtr)num6);
						continue;
					case 1:
					{
						if (status_int == 1)
						{
							num6 = (short)1478033408;
							num5 = (int)((IntPtr)num6);
							continue;
						}
						num6 = (short)1701875119;
						short num7 = num6;
						num6 = (short)126061999;
						switch ((num7 == num6) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B9;
						default:
							num6 = (short)2028601344;
							if (num6 != 0)
							{
							}
							num6 = (short)878772228;
							num5 = (int)((IntPtr)num6);
							continue;
						}
						break;
					}
					case 2:
						goto IL_1B4;
					case 3:
						goto IL_2F1;
					case 4:
						if (status_int == -1)
						{
							num6 = (short)92995590;
							num5 = (int)((IntPtr)num6);
							continue;
						}
						num6 = (short)1847984129;
						if (num6 != 0)
						{
						}
						status = 0;
						num6 = (short)768933893;
						num5 = (int)((IntPtr)num6);
						continue;
					case 5:
						goto IL_25F;
					case 6:
						Comms.DispalyUpdateStatusChanged(0.0, AppResources.Warning_System_Type_Not_Match_While_Batch_Clone);
						status = -1;
						num6 = (short)232062979;
						num5 = (int)((IntPtr)num6);
						continue;
					case 7:
						goto IL_1F4;
					case 8:
						goto IL_1B4;
					case 9:
						if (clone.CloneRadio(true, CloneParameters.CloneWriteType, CloneParameters.LastCloneOTAPUserState, this, this.g))
						{
							num6 = (short)1878065162;
							num5 = (int)((IntPtr)num6);
							continue;
						}
						status = 0;
						num6 = (short)1175846920;
						num5 = (int)((IntPtr)num6);
						continue;
					case 10:
						goto IL_2B9;
					}
					goto IL_3C;
					IL_1B4:
					byte[] bytes = Convert.FromBase64String(clone.GetRadioParams().SerialNumber);
					this.j = Encoding.ASCII.GetString(bytes);
					num6 = (short)336723975;
					num5 = (int)((IntPtr)num6);
					continue;
					IL_2B9:
					status = 1;
					num6 = (short)793182210;
					num5 = (int)((IntPtr)num6);
				}
				IL_1F4:
				IL_25F:
				IL_2F1:
				this.CallMainFinish(status);
				Comms.updateStatus -= this.a;
				return;
				IL_3C:
				clone = new Clone();
				Comms.updateStatus += this.a;
				RadioIdInfo radioIdInfo = clone.ReadRadioIds(CloneParameters.CloneWriteType, 8, this.CurrentRadioIpAddress, this.WriteProtectWriteProtectedRad, this.g);
				status_int = (int)this.Dispatcher.Invoke(new POP25BatchProgrammerProgress.MainThreadUpdateRadioIds(this.SaveRadioIds), new object[]
				{
					radioIdInfo
				});
				num6 = (short)685768704;
				short num8 = num6;
				num6 = (short)1204879361;
				num5 = (int)((IntPtr)num6);
				goto IL_0A;
			}).Start();
			return;
			IL_37C:
			this.CloneFinished(0);
			return;
			IL_4D:
			status = 0;
			status_int = 0;
			num2 = (short)97189891;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x000CB974 File Offset: 0x000C9B74
		internal int SaveRadioIds(RadioIdInfo tempRadioIds)
		{
			int a_ = 13;
			short num = (short)2088894464;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_125;
				}
				int result;
				bool flag2;
				RadioInformation radioInformation;
				for (;;)
				{
					IL_32:
					ConventionalSystemRecset conventionalSystemRecset;
					SecureWideRecset secureWideRecset;
					RadioWide radioWide;
					bool radInfoLabtoolH37G50Smartnet_A8184Value;
					bool radInfoLabtoolH38G51Smartzone_A8185Value;
					DataProfilesRecset dataProfilesRecset;
					IEnumerator<FeatureNode> enumerator;
					int num6;
					switch (num2)
					{
					case 0:
						if (conventionalSystemRecset != null)
						{
							num = (short)1379467267;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1A8B;
					case 1:
						goto IL_BC5;
					case 2:
					{
						result = 1;
						TrunkingSystemRecset trunkingSystemRecset = FeatureManager.GetFeature(2064) as TrunkingSystemRecset;
						num = (short)1119748141;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 3:
						goto IL_11D0;
					case 4:
					{
						SecureWide secureWide = secureWideRecset[0] as SecureWide;
						bool flag = UndoManager.StopUndoRedo();
						int num3;
						secureWide.ASTROOTAR.SecWideASTROOTARIndividualASTROOTARRadioID_A8284.Value = num3;
						num = (short)1387266092;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)1857093632;
						short num4 = num;
						int num3;
						if (num3 != -1)
						{
							num = (short)1051131908;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_12BE;
					}
					case 6:
						if (tempRadioIds.SoftIds != null)
						{
							num = (short)774242361;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1BF1;
					case 7:
						num = (short)1367605253;
						num2 = (int)((IntPtr)num);
						continue;
					case 8:
						if (radioWide != null)
						{
							num = (short)959578166;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_11F7;
					case 9:
						goto IL_30C;
					case 10:
						goto IL_12BE;
					case 11:
						result = 1;
						conventionalSystemRecset = (FeatureManager.GetFeature(2053) as ConventionalSystemRecset);
						num = (short)420544512;
						num2 = (int)((IntPtr)num);
						continue;
					case 12:
					{
						string strB;
						if (strB == RptMgrErrorHandler.b("풏쾗ﮝ", a_))
						{
							num = (short)224722994;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_19E7;
					}
					case 13:
					{
						DataWide dataWide;
						DataProfIP dataProfIP;
						dataWide.General.DataWideGeneralBTDUNPeerIPAddress_A41123.SetValue(dataProfIP.BTPeerIP.Address);
						num = (short)1865154583;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 14:
						if (radInfoLabtoolH37G50Smartnet_A8184Value || radInfoLabtoolH38G51Smartzone_A8185Value)
						{
							num = (short)333185040;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_126B;
					case 15:
						goto IL_126B;
					case 16:
						flag2 = true;
						num = (short)2107572239;
						num2 = (int)((IntPtr)num);
						continue;
					case 17:
						if (dataProfilesRecset != null)
						{
							num = (short)1759051819;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1B57;
					case 18:
						if (tempRadioIds.DataProfIps != null)
						{
							num = (short)1400045615;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return result;
					case 19:
					{
						SecureKMFProfileRecset secureKMFProfileRecset;
						if (secureKMFProfileRecset != null)
						{
							num = (short)213647415;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1ACC;
					}
					case 20:
						if (tempRadioIds.CnvSysIds != null)
						{
							num = (short)1904410635;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1A8B;
					case 21:
						num = (short)189726721;
						if (num != 0)
						{
						}
						UndoManager.StartUndoRedo();
						num = (short)1017184266;
						num2 = (int)((IntPtr)num);
						continue;
					case 22:
						if (tempRadioIds.AstroOtarRadioIds != null)
						{
							num = (short)392364078;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_12BE;
					case 23:
						goto IL_1B52;
					case 24:
						goto IL_225;
					case 25:
						try
						{
							num = (short)370737157;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_F18;
								case 1:
								{
									DataProfIP dataProfIP;
									if (dataProfIP.BTSubIP != null)
									{
										num = (short)1306918915;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_F18;
								}
								case 2:
								{
									DataProfIP dataProfIP;
									if (dataProfIP.BTPeerIP != null)
									{
										num = (short)202244100;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_1147;
								}
								case 3:
								{
									DataProfIP dataProfIP;
									DataProfiles dataProfiles;
									dataProfiles.General.DataProfilesGeneralBTDUNSUIPAddress_A41126.SetValue(dataProfIP.BTSubIP.Address);
									num = (short)614203392;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 4:
								{
									DataProfIP dataProfIP;
									DataProfiles dataProfiles;
									dataProfiles.General.DataProfilesGeneralBTDUNPeerIPAddress_A41127.SetValue(dataProfIP.BTPeerIP.Address);
									num = (short)771358728;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_F13;
									}
									continue;
								case 6:
									goto IL_1147;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)851968006;
										num2 = (int)((IntPtr)num);
										continue;
									}
									DataProfiles dataProfiles = (DataProfiles)enumerator.Current;
									num = (short)851443722;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 8:
									goto IL_1142;
								case 9:
								{
									DataProfiles dataProfiles;
									if (!dataProfiles.General.DataProfGeneralAutoGenerateIPAddress_A19320.Value)
									{
										num = (short)2107179019;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
								{
									string strB;
									DataProfiles dataProfiles;
									if (dataProfiles.ReferenceKey.CompareTo(strB) == 0)
									{
										num = (short)1368522764;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
								{
									DataProfIP dataProfIP;
									DataProfiles dataProfiles;
									dataProfiles.General.DataProfGeneralSubscriberIPAddress_A21157.SetValue(dataProfIP.SubIP.Address);
									dataProfiles.General.DataProfGeneralMobileComputerIPAddress_A8523.SetValue(dataProfIP.PeerIP.Address);
									dataProfiles.General.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.SetValue(dataProfIP.SubAirInterfaceIP.Address);
									num = (short)66519041;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 12:
									num = (short)132907017;
									num2 = (int)((IntPtr)num);
									continue;
								case 13:
									goto IL_115F;
								}
								goto IL_F13;
								IL_F18:
								num = (short)189136898;
								num2 = (int)((IntPtr)num);
								continue;
								IL_1074:
								num = (short)1444020231;
								num2 = (int)((IntPtr)num);
								continue;
								IL_F13:
								goto IL_1074;
								IL_1147:
								num = (short)588644365;
								num2 = (int)((IntPtr)num);
							}
							IL_1142:
							IL_115F:
							goto IL_1B57;
						}
						finally
						{
							num = (short)1484980224;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1196;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)273350658;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									goto IL_11CD;
								}
								IL_1196:
								if (enumerator == null)
								{
									break;
								}
								num = (short)921305089;
								num2 = (int)((IntPtr)num);
							}
							IL_11CD:;
						}
						goto IL_11D0;
					case 26:
					{
						result = 1;
						RadioWide radioWide2 = (FeatureManager.GetFeature(2045) as RadioWideRecset)[0] as RadioWide;
						tempRadioIds.BluetoothFriendlyName = this.a(tempRadioIds.BluetoothFriendlyName);
						radioWide2.Bluetooth.RadWideBluetoothFriendlyName_A41181.SetValue(tempRadioIds.BluetoothFriendlyName);
						num = (short)102367263;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 27:
						if (tempRadioIds.RadioAlias != null)
						{
							num = (short)274071584;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_11F7;
					case 28:
					{
						int num5;
						if (num5 > 0)
						{
							num = (short)2076639284;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_30C;
					}
					case 29:
						goto IL_69A;
					case 30:
					{
						RadioWide radioWide3 = (FeatureManager.GetFeature(2045) as RadioWideRecset)[0] as RadioWide;
						string value = this.a(tempRadioIds.SoftIds[0]);
						radioWide3.UserInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsername_A9169.SetValue(value);
						PINPasswordUtil.UpdatePINPasswordFromRadio(tempRadioIds);
						if (tempRadioIds.SoftIds[3] != null)
						{
							value = this.a(tempRadioIds.SoftIds[3]);
						}
						else
						{
							value = "";
						}
						radioWide3.UserInformationAndPasswords.RadWideUserInformationandUserLoginUnitID_41306.SetValue(value);
						num = (short)115998778;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 31:
						goto IL_266;
					case 32:
						goto IL_B04;
					case 33:
						if (tempRadioIds.BluetoothFriendlyName != null)
						{
							num = (short)1519845402;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_266;
					case 34:
					{
						DataWide dataWide;
						DataProfIP dataProfIP;
						dataWide.General.DataWideGeneralBTDUNSUIPAddress_A41120.SetValue(dataProfIP.BTSubIP.Address);
						num = (short)170262529;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 35:
						goto IL_225;
					case 36:
						try
						{
							num = (short)611385347;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								Dictionary<string, int>.Enumerator enumerator2;
								string referenceKey;
								SecureKMFProfile secureKMFProfile;
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)682295300;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_57C;
											case 1:
												goto IL_564;
											case 2:
											{
												if (!enumerator2.MoveNext())
												{
													num = (short)882114561;
													num2 = (int)((IntPtr)num);
													continue;
												}
												KeyValuePair<string, int> keyValuePair = enumerator2.Current;
												string key = keyValuePair.Key;
												num = (short)943456259;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 3:
											{
												string key;
												if (referenceKey.Equals(key.TrimEnd(new char[1])))
												{
													num = (short)900923398;
													num2 = (int)((IntPtr)num);
													continue;
												}
												break;
											}
											case 4:
												switch (0)
												{
												case 0:
													goto IL_43B;
												}
												continue;
											case 5:
											{
												KeyValuePair<string, int> keyValuePair;
												int num3 = keyValuePair.Value;
												num = (short)1751908360;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 6:
											{
												KeyValuePair<string, int> keyValuePair;
												secureKMFProfile.ASTROOTARInformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.SetValue(keyValuePair.Value);
												num = (short)2127495175;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 7:
												if (!secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597.Value)
												{
													num = (short)1042481157;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_564;
											case 8:
												goto IL_4FE;
											}
											IL_49B:
											num = (short)1367998466;
											num2 = (int)((IntPtr)num);
											continue;
											IL_43B:
											goto IL_49B;
											IL_564:
											num = (short)476708864;
											num2 = (int)((IntPtr)num);
										}
										IL_4FE:
										IL_57C:
										break;
									}
									finally
									{
										((IDisposable)enumerator2).Dispose();
									}
									goto IL_58C;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)1920598020;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_58C;
								case 2:
									goto IL_627;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_3EB;
									}
									continue;
								case 4:
									num = (short)2001141762;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_3EB;
								IL_58C:
								secureKMFProfile = (SecureKMFProfile)enumerator.Current;
								referenceKey = secureKMFProfile.ReferenceKey;
								enumerator2 = tempRadioIds.AstroOtarRadioIds.GetEnumerator();
								num = (short)1406795776;
								num2 = (int)((IntPtr)num);
								continue;
								IL_5CE:
								num = (short)473825281;
								num2 = (int)((IntPtr)num);
								continue;
								IL_3EB:
								goto IL_5CE;
							}
							IL_627:
							goto IL_1ACC;
						}
						finally
						{
							num = (short)715587585;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_697;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_65F;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)725417984;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_65F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)203685890;
								num2 = (int)((IntPtr)num);
							}
							IL_697:;
						}
						goto IL_69A;
					case 37:
					{
						DataProfIP[] dataProfIps;
						if (num6 >= dataProfIps.Length)
						{
							num = (short)1923416113;
							num2 = (int)((IntPtr)num);
							continue;
						}
						DataProfIP dataProfIP = dataProfIps[num6];
						string strB = dataProfIP.DataProfName;
						int num5 = dataProfIP.DataProfName.IndexOf('\0');
						num = (short)1665007644;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 38:
						if (secureWideRecset != null)
						{
							num = (short)1821376519;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_12BE;
					case 39:
						if (tempRadioIds.TrkSysIds != null && flag2)
						{
							num = (short)419233794;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_D0D;
					case 40:
					{
						DataProfIP dataProfIP;
						if (dataProfIP.BTPeerIP != null)
						{
							num = (short)498073613;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return result;
					}
					case 41:
						try
						{
							num = (short)1018298369;
							num2 = (int)((IntPtr)num);
							int result2;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (CloneParameters.BlockNewSystemCheck)
									{
										num = (short)1311571971;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_134E;
									}
									continue;
								case 2:
									goto IL_13DD;
								case 3:
									result2 = -1;
									num = (short)557187074;
									num2 = (int)((IntPtr)num);
									continue;
								case 4:
									try
									{
										num = (short)679149587;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											KeyValuePair<string, int[]> keyValuePair2;
											bool flag3;
											ConventionalSystem conventionalSystem;
											switch (num2)
											{
											case 0:
											{
												string referenceKey2;
												string strB2;
												if (referenceKey2.CompareTo(strB2) == 0)
												{
													num = (short)626982924;
													num2 = (int)((IntPtr)num);
													continue;
												}
												break;
											}
											case 1:
												goto IL_17E3;
											case 2:
											{
												Dictionary<string, int[]>.Enumerator enumerator3;
												if (!enumerator3.MoveNext())
												{
													num = (short)216465415;
													num2 = (int)((IntPtr)num);
													continue;
												}
												keyValuePair2 = enumerator3.Current;
												string strB2 = keyValuePair2.Key;
												int num7 = keyValuePair2.Key.IndexOf('\0');
												num = (short)1507983376;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 3:
												num = (short)847773705;
												num2 = (int)((IntPtr)num);
												continue;
											case 4:
												flag3 = true;
												num = (short)1442512897;
												num2 = (int)((IntPtr)num);
												continue;
											case 5:
												goto IL_165C;
											case 6:
											{
												string cnvSysGeneralSystemType_A13262_UIValue;
												if (cnvSysGeneralSystemType_A13262_UIValue == AppResources.DVRS_Id)
												{
													num = (short)976551939;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_182A;
											}
											case 7:
												goto IL_18AC;
											case 8:
												goto IL_1568;
											case 9:
												if (keyValuePair2.Value[0] == 2)
												{
													num = (short)1117519880;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_182A;
											case 10:
												if (keyValuePair2.Value[0] == 3)
												{
													num = (short)302579716;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_18AC;
											case 11:
												conventionalSystem.General.CnvSysGeneralMDCPrimaryID_A8744.SetValue(keyValuePair2.Value[1]);
												flag3 = true;
												goto IL_188F;
											case 12:
											{
												string cnvSysGeneralSystemType_A13262_UIValue = conventionalSystem.General.CnvSysGeneralSystemType_A13262_UIValue;
												num = (short)327614481;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 13:
												num = (short)1601175574;
												num2 = (int)((IntPtr)num);
												continue;
											case 14:
											{
												string cnvSysGeneralSystemType_A13262_UIValue;
												if (cnvSysGeneralSystemType_A13262_UIValue == AppResources.QCII_ID)
												{
													num = (short)1965948953;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_18AC;
											}
											case 15:
											{
												int num7;
												string strB2 = keyValuePair2.Key.Substring(0, num7);
												num = (short)1301676053;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 16:
											{
												int num7;
												if (num7 > 0)
												{
													num = (short)1154678799;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_1742;
											}
											case 17:
											{
												string cnvSysGeneralSystemType_A13262_UIValue;
												if (cnvSysGeneralSystemType_A13262_UIValue == AppResources.ASTRO_Id)
												{
													num = (short)449445901;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_165C;
											}
											case 18:
											{
												string cnvSysGeneralSystemType_A13262_UIValue;
												if (cnvSysGeneralSystemType_A13262_UIValue == AppResources.MDC_Id)
												{
													num = (short)1950089236;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_15A3;
											}
											case 19:
												switch (0)
												{
												case 0:
													goto IL_1479;
												}
												continue;
											case 20:
												num = (short)1987182618;
												num2 = (int)((IntPtr)num);
												continue;
											case 21:
												goto IL_1742;
											case 22:
												if (keyValuePair2.Value[0] != 0)
												{
													num = (short)1912209413;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_1568;
											case 23:
												goto IL_159E;
											case 24:
												goto IL_18A7;
											case 25:
												num = (short)1497235466;
												num2 = (int)((IntPtr)num);
												continue;
											case 26:
												if (keyValuePair2.Value[0] == 1)
												{
													num = (short)242941963;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_15A3;
											case 27:
												goto IL_18C4;
											}
											goto IL_1479;
											IL_1568:
											conventionalSystem.General.CnvSysGeneralIndividualID_A8287.SetValue(keyValuePair2.Value[1]);
											flag3 = true;
											num = (short)1052573719;
											num2 = (int)((IntPtr)num);
											continue;
											IL_15A3:
											num = (short)849543182;
											num2 = (int)((IntPtr)num);
											continue;
											IL_165C:
											num = (short)1891183925;
											short num8 = num;
											num = (short)338636085;
											switch ((num8 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												IL_188F:
												num = (short)19398680;
												num2 = (int)((IntPtr)num);
												continue;
											default:
												num = (short)745078784;
												if (num != 0)
												{
												}
												num = (short)1293090822;
												num2 = (int)((IntPtr)num);
												continue;
											}
											IL_1742:
											num = (short)1492647936;
											num2 = (int)((IntPtr)num);
											continue;
											IL_1786:
											num = (short)1397489666;
											num2 = (int)((IntPtr)num);
											continue;
											IL_1479:
											goto IL_1786;
											IL_182A:
											num = (short)783548434;
											num2 = (int)((IntPtr)num);
											continue;
											IL_18AC:
											num = (short)1276641307;
											num2 = (int)((IntPtr)num);
										}
										IL_159E:
										IL_17E3:
										IL_18A7:
										IL_18C4:
										goto IL_1353;
									}
									finally
									{
										Dictionary<string, int[]>.Enumerator enumerator3;
										((IDisposable)enumerator3).Dispose();
									}
									break;
									IL_1353:
									num = (short)228065285;
									num2 = (int)((IntPtr)num);
									continue;
								case 5:
								{
									bool flag3;
									if (!flag3)
									{
										num = (short)4784135;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)891093000;
										num2 = (int)((IntPtr)num);
										continue;
									}
									ConventionalSystem conventionalSystem = (ConventionalSystem)enumerator.Current;
									bool flag3 = false;
									string referenceKey2 = conventionalSystem.ReferenceKey;
									Dictionary<string, int[]>.Enumerator enumerator3 = tempRadioIds.CnvSysIds.GetEnumerator();
									num = (short)1230241796;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 7:
									num = (short)2032664576;
									num2 = (int)((IntPtr)num);
									continue;
								case 8:
									num = (short)881524745;
									num2 = (int)((IntPtr)num);
									continue;
								case 9:
									goto IL_1973;
								}
								IL_18D7:
								num = (short)469172230;
								num2 = (int)((IntPtr)num);
								continue;
								IL_134E:
								goto IL_18D7;
							}
							IL_13DD:
							return result2;
							IL_1973:
							goto IL_1A8B;
						}
						finally
						{
							num = (short)1935736832;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_19AB;
									}
									continue;
								case 1:
									goto IL_19E4;
								case 2:
									enumerator.Dispose();
									num = (short)140836865;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_19AB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2139947010;
								num2 = (int)((IntPtr)num);
							}
							IL_19E4:;
						}
						goto IL_19E7;
					case 42:
					{
						DataProfIP dataProfIP;
						if (dataProfIP.BTSubIP != null)
						{
							num = (short)338427938;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_BC5;
					}
					case 43:
						enumerator = dataProfilesRecset.GetEnumerator();
						num = (short)400162841;
						num2 = (int)((IntPtr)num);
						continue;
					case 44:
					{
						bool flag;
						if (flag)
						{
							num = (short)564854805;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_12BE;
					}
					case 45:
					{
						TrunkingSystemRecset trunkingSystemRecset;
						if (trunkingSystemRecset != null)
						{
							num = (short)1853030453;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_D0D;
					}
					case 46:
					{
						int num3 = -1;
						result = 1;
						SecureKMFProfileRecset secureKMFProfileRecset = FeatureManager.GetFeature(2055) as SecureKMFProfileRecset;
						num = (short)770375699;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 47:
					{
						result = 1;
						DataProfIP[] dataProfIps = tempRadioIds.DataProfIps;
						num6 = 0;
						num = (short)521273379;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 48:
						if (radioInformation != null)
						{
							num = (short)1242431517;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_126B;
					case 49:
						return result;
					case 50:
					{
						DataWide dataWide = (FeatureManager.GetFeature(2028) as DataWideRecset)[0] as DataWide;
						DataProfIP dataProfIP;
						dataWide.General.DataWideGeneralPeerIPAddress1_A8524.SetValue(dataProfIP.PeerIP.Address);
						dataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.SetValue(dataProfIP.SubIP.Address);
						num = (short)1960837162;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 51:
						try
						{
							num = (short)888799237;
							num2 = (int)((IntPtr)num);
							int result2;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_9A6;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1404567561;
										num2 = (int)((IntPtr)num);
										continue;
									}
									TrunkingSystem trunkingSystem = (TrunkingSystem)enumerator.Current;
									bool flag4 = false;
									string referenceKey3 = trunkingSystem.ReferenceKey;
									Dictionary<string, int[]>.Enumerator enumerator3 = tempRadioIds.TrkSysIds.GetEnumerator();
									num = (short)1619591176;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 2:
									goto IL_A93;
								case 3:
								{
									bool flag4;
									if (!flag4)
									{
										num = (short)1172111367;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_9C2;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_794;
									}
									continue;
								case 6:
									if (CloneParameters.BlockNewSystemCheck)
									{
										num = (short)1047724032;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								case 7:
									num = (short)1474494470;
									num2 = (int)((IntPtr)num);
									continue;
								case 8:
									try
									{
										num = (short)424738820;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											Dictionary<string, int[]>.Enumerator enumerator3;
											KeyValuePair<string, int[]> keyValuePair3;
											int num9;
											string strB3;
											switch (num2)
											{
											case 0:
												goto IL_993;
											case 1:
												strB3 = keyValuePair3.Key.Substring(0, num9);
												num = (short)1009713160;
												num2 = (int)((IntPtr)num);
												continue;
											case 2:
												if (num9 > 0)
												{
													num = (short)1279328257;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_828;
											case 3:
												if (!enumerator3.MoveNext())
												{
													num = (short)1052770310;
													num2 = (int)((IntPtr)num);
													continue;
												}
												goto IL_8B0;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_823;
												}
												continue;
											case 5:
												try
												{
													bool flag4 = true;
													TrunkingSystem trunkingSystem;
													trunkingSystem.General.TrkSysGeneralUnitID_A12651.DisableASKRangeValidation = true;
													trunkingSystem.General.TrkSysGeneralUnitID_A12651.Value = keyValuePair3.Value[1];
													goto IL_A40;
												}
												catch (Exception)
												{
													goto IL_A40;
												}
												finally
												{
													TrunkingSystem trunkingSystem;
													trunkingSystem.General.TrkSysGeneralUnitID_A12651.DisableASKRangeValidation = false;
												}
												goto IL_8B0;
											case 6:
												num = (short)1359216640;
												num2 = (int)((IntPtr)num);
												continue;
											case 7:
											{
												string referenceKey3;
												if (referenceKey3.CompareTo(strB3) == 0)
												{
													num = (short)1213399045;
													num2 = (int)((IntPtr)num);
													continue;
												}
												break;
											}
											case 8:
												goto IL_828;
											}
											goto IL_823;
											IL_828:
											num = (short)385024007;
											num2 = (int)((IntPtr)num);
											continue;
											IL_8B0:
											keyValuePair3 = enumerator3.Current;
											strB3 = keyValuePair3.Key;
											num9 = keyValuePair3.Key.IndexOf('\0');
											num = (short)537329666;
											num2 = (int)((IntPtr)num);
											continue;
											IL_93B:
											num = (short)511246339;
											num2 = (int)((IntPtr)num);
											continue;
											IL_823:
											goto IL_93B;
										}
										IL_993:
										goto IL_A40;
									}
									finally
									{
										Dictionary<string, int[]>.Enumerator enumerator3;
										((IDisposable)enumerator3).Dispose();
									}
									goto IL_9A6;
									IL_A40:
									num = (short)232062979;
									num2 = (int)((IntPtr)num);
									continue;
								case 9:
									num = (short)931397634;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_794;
								IL_9A6:
								result2 = -1;
								num = (short)447152132;
								num2 = (int)((IntPtr)num);
								continue;
								IL_A01:
								num = (short)472449025;
								num2 = (int)((IntPtr)num);
								continue;
								IL_794:
								goto IL_A01;
							}
							IL_9C2:
							return result2;
							IL_A93:
							goto IL_D0D;
						}
						finally
						{
							num = (short)389939201;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_B01;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_ACA;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1842806784;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_ACA:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1519648770;
								num2 = (int)((IntPtr)num);
							}
							IL_B01:;
						}
						goto IL_B04;
					case 52:
					{
						DataProfIP dataProfIP;
						int num5;
						string strB = dataProfIP.DataProfName.Substring(0, num5);
						num = (short)2142830601;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 53:
					{
						TrunkingSystemRecset trunkingSystemRecset;
						enumerator = trunkingSystemRecset.GetEnumerator();
						num = (short)809566259;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 54:
						radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioAlias_A8829.SetValue(tempRadioIds.RadioAlias);
						num = (short)2003763256;
						num2 = (int)((IntPtr)num);
						continue;
					case 55:
					{
						SecureKMFProfileRecset secureKMFProfileRecset;
						enumerator = secureKMFProfileRecset.GetEnumerator();
						num = (short)1411383332;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 56:
						goto IL_11F7;
					case 57:
						result = 1;
						num = (short)2100953118;
						num2 = (int)((IntPtr)num);
						continue;
					case 58:
						goto IL_1BF1;
					}
					goto IL_125;
					IL_225:
					num = (short)186974245;
					num2 = (int)((IntPtr)num);
					continue;
					IL_266:
					num = (short)616038418;
					num2 = (int)((IntPtr)num);
					continue;
					IL_30C:
					num = (short)10027020;
					num2 = (int)((IntPtr)num);
					continue;
					IL_69A:
					radInfoLabtoolH37G50Smartnet_A8184Value = radioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184Value;
					radInfoLabtoolH38G51Smartzone_A8185Value = radioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185Value;
					num = (short)278331406;
					num2 = (int)((IntPtr)num);
					continue;
					IL_B04:
					result = 1;
					radioWide = ((FeatureManager.GetFeature(2045) as RadioWideRecset)[0] as RadioWide);
					tempRadioIds.RadioAlias = this.a(tempRadioIds.RadioAlias);
					num = (short)192806920;
					num2 = (int)((IntPtr)num);
					continue;
					IL_BC5:
					num = (short)1166147624;
					num2 = (int)((IntPtr)num);
					continue;
					IL_D0D:
					num = (short)2121007124;
					num2 = (int)((IntPtr)num);
					continue;
					IL_11D0:
					enumerator = conventionalSystemRecset.GetEnumerator();
					num = (short)285343785;
					num2 = (int)((IntPtr)num);
					continue;
					IL_11F7:
					num = (short)1253769249;
					num2 = (int)((IntPtr)num);
					continue;
					IL_126B:
					num = (short)1002831911;
					num2 = (int)((IntPtr)num);
					continue;
					IL_12BE:
					num = (short)280952838;
					num2 = (int)((IntPtr)num);
					continue;
					IL_19E7:
					dataProfilesRecset = (FeatureManager.GetFeature(2054) as DataProfilesRecset);
					num = (short)1174011921;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1A8B:
					num = (short)277741590;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1ACC:
					secureWideRecset = (FeatureManager.GetFeature(2021) as SecureWideRecset);
					num = (short)646119462;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1B57:
					num6++;
					num = (short)722993176;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1BF1:
					num = (short)1601044507;
					num2 = (int)((IntPtr)num);
				}
				return result;
				IL_1B52:
				return result;
				IL_125:
				result = 0;
				radioInformation = (FeatureManager.GetFeature(2049)[0] as RadioInformation);
				flag2 = false;
				num = (short)321257520;
				num2 = (int)((IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x000CD694 File Offset: 0x000CB894
		private string a(string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			short num3;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					return A_0;
				case 1:
				{
					int num2;
					if (num2 > 0)
					{
						num3 = (short)1034616836;
						num = (int)((IntPtr)num3);
						continue;
					}
					return A_0;
				}
				case 2:
					return A_0;
				case 3:
				{
					int num2;
					if (num2 == 0)
					{
						num3 = (short)1154154501;
						num = (int)((IntPtr)num3);
						continue;
					}
					num3 = (short)970194945;
					num = (int)((IntPtr)num3);
					continue;
				}
				case 4:
				{
					int num2;
					A_0 = A_0.Substring(0, num2);
					num3 = (short)1638400000;
					num = (int)((IntPtr)num3);
					continue;
				}
				case 5:
					A_0 = "";
					num3 = (short)1351811074;
					num = (int)((IntPtr)num3);
					continue;
				}
				goto IL_28;
			}
			return A_0;
			IL_28:
			num3 = (short)1307836416;
			short num4 = num3;
			num3 = (short)2131886081;
			if (num3 != 0)
			{
			}
			num3 = (short)122466468;
			short num5 = num3;
			num3 = (short)1126281380;
			switch ((num5 == num3) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num3 = (short)1268449280;
				if (num3 != 0)
				{
				}
				int num2 = A_0.IndexOf('\0');
				num3 = (short)1274216451;
				int num = (int)((IntPtr)num3);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x000CD81C File Offset: 0x000CBA1C
		private void a(double A_0, string A_1)
		{
			short num = (short)10799705;
			short num2 = num;
			num = (short)1308871257;
			switch (num2 == num)
			{
			}
			num = (short)1550843904;
			short num3 = num;
			num = (short)1106968576;
			if (num != 0)
			{
			}
			num = (short)1188495361;
			if (num != 0)
			{
			}
			base.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new POP25BatchProgrammerProgress.UpdateProgress(this.Radio_updateStatus), A_0, new object[]
			{
				A_1
			});
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x000CD8F4 File Offset: 0x000CBAF4
		internal void WriteToLogCurrentPass()
		{
			int a_ = 12;
			short num;
			try
			{
				num = (short)969630260;
				short num2 = num;
				num = (short)1916690996;
				switch (num2 == num)
				{
				}
				num = (short)903217152;
				if (num != 0)
				{
				}
				this.txtBoxProgressStatus.AppendText(RptMgrErrorHandler.b("芎鮐", a_) + AppResources.PASS_Id + (this.CurRetry + 1).ToString() + RptMgrErrorHandler.b("꾎벐뺒떔", a_));
				this.txtBoxProgressStatus.ScrollToEnd();
			}
			catch (Exception)
			{
				System.Windows.MessageBox.Show(AppResources.Cannot_Log_Status_Any_Further, AppResources.Log_File_Error, MessageBoxButton.OK, MessageBoxImage.Exclamation);
			}
			num = (short)1313865729;
			if (num != 0)
			{
			}
			num = (short)961150976;
			short num3 = num;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x000CDA1C File Offset: 0x000CBC1C
		internal void WriteToLog_Initial()
		{
			int a_ = 13;
			short num;
			try
			{
				num = (short)354274930;
				short num2 = num;
				num = (short)1110036082;
				switch (num2 == num)
				{
				}
				num = (short)1197539328;
				if (num != 0)
				{
				}
				this.txtBoxProgressStatus.AppendText(string.Concat(new string[]
				{
					RptMgrErrorHandler.b("骏", a_),
					DateTime.Now.ToString(),
					RptMgrErrorHandler.b("낏뾑릓뚕", a_),
					this.ProgText.Text,
					Environment.NewLine
				}));
				this.txtBoxProgressStatus.ScrollToEnd();
			}
			catch (Exception)
			{
				System.Windows.MessageBox.Show(AppResources.Cannot_Log_Status_Any_Further, AppResources.Log_File_Error, MessageBoxButton.OK, MessageBoxImage.Exclamation);
			}
			num = (short)1474232321;
			if (num != 0)
			{
			}
			num = (short)327155712;
			short num3 = num;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x000CDB60 File Offset: 0x000CBD60
		internal void WriteToLog_Cont()
		{
			int a_ = 8;
			short num;
			try
			{
				num = (short)634660285;
				short num2 = num;
				num = (short)1469457853;
				switch (num2 == num)
				{
				}
				num = (short)1441136640;
				if (num != 0)
				{
				}
				this.txtBoxProgressStatus.AppendText(DateTime.Now.ToString() + RptMgrErrorHandler.b("ꮊꂌꊎ놐", a_) + this.ProgText.Text + Environment.NewLine);
				this.txtBoxProgressStatus.ScrollToEnd();
			}
			catch (Exception)
			{
				System.Windows.MessageBox.Show(AppResources.Cannot_Log_Status_Any_Further, AppResources.Log_File_Error, MessageBoxButton.OK, MessageBoxImage.Exclamation);
			}
			num = (short)232980481;
			if (num != 0)
			{
			}
			num = (short)533397504;
			short num3 = num;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x000CDC84 File Offset: 0x000CBE84
		internal void WriteToLog_Success()
		{
			int a_ = 7;
			short num;
			try
			{
				num = (short)1952645121;
				if (num != 0)
				{
				}
				num = (short)1058099799;
				short num2 = num;
				num = (short)116675159;
				switch (num2 == num)
				{
				}
				num = (short)856489984;
				if (num != 0)
				{
				}
				this.txtBoxProgressStatus.AppendText(DateTime.Now.ToString() + RptMgrErrorHandler.b("ꪉꆋꎍ낏", a_) + this.ProgText.Text + Environment.NewLine);
				this.txtBoxProgressStatus.AppendText(RptMgrErrorHandler.b("ꂉꚋ꒍몏뢑뺓법늗낙뚛뒝誟袡躣貥袧", a_) + AppResources.SUCCESS_All_Uppercase_Id + RptMgrErrorHandler.b("ꪉꚋ꒍몏뢑뺓법늗낙뚛뒝誟袡躣貥芧", a_) + Environment.NewLine);
				this.txtBoxProgressStatus.ScrollToEnd();
			}
			catch (Exception)
			{
				System.Windows.MessageBox.Show(AppResources.Cannot_Log_Status_Any_Further, AppResources.Log_File_Error, MessageBoxButton.OK, MessageBoxImage.Exclamation);
			}
			num = (short)1703542784;
			short num3 = num;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x000CDDD8 File Offset: 0x000CBFD8
		internal void WriteToLog_Failure()
		{
			int a_ = 16;
			short num;
			try
			{
				num = (short)969646108;
				short num2 = num;
				num = (short)1951375388;
				switch (num2 == num)
				{
				}
				num = (short)1417478144;
				if (num != 0)
				{
				}
				this.txtBoxProgressStatus.AppendText(DateTime.Now.ToString() + RptMgrErrorHandler.b("뎒뢔몖릘", a_) + this.ProgText.Text + Environment.NewLine);
				this.txtBoxProgressStatus.AppendText(RptMgrErrorHandler.b("릒뾔붖뎘놚랜떞讠覢辤趦莨膪螬薮醰", a_) + AppResources.FAILED_All_UpperCase_Id + RptMgrErrorHandler.b("뎒뾔붖뎘놚랜떞讠覢辤趦莨膪螬薮鮰", a_) + Environment.NewLine);
				this.txtBoxProgressStatus.ScrollToEnd();
			}
			catch (Exception)
			{
				System.Windows.MessageBox.Show(AppResources.Cannot_Log_Status_Any_Further, AppResources.Log_File_Error, MessageBoxButton.OK, MessageBoxImage.Exclamation);
			}
			num = (short)1713569793;
			if (num != 0)
			{
			}
			num = (short)154599424;
			short num3 = num;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x000CDF2C File Offset: 0x000CC12C
		internal void Radio_updateStatus(double n, string stat)
		{
			int a_ = 7;
			short num = (short)169279513;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_BEF;
				case 1:
					if (AppResources.ReadRadio_Reading_codeplug_from_radio == stat)
					{
						num = (short)1167654924;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1968701458;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					if (AppResources.ReadRadio_Calling_End_Read_Radio == stat)
					{
						num = (short)825294853;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1003356174;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					goto IL_13B5;
				case 4:
					goto IL_DA1;
				case 5:
					goto IL_1292;
				case 6:
					goto IL_124E;
				case 7:
				{
					num = (short)155101104;
					short num3 = num;
					num = (short)1762305968;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_78C;
					default:
						goto IL_1433;
					}
					break;
				}
				case 8:
					goto IL_B26;
				case 9:
					goto IL_CA5;
				case 10:
					if (AppResources.Unpack_failure_during_read == stat)
					{
						num = (short)1540554782;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1017118771;
					num2 = (int)((IntPtr)num);
					continue;
				case 11:
					goto IL_B21;
				case 12:
					goto IL_A73;
				case 13:
					goto IL_328;
				case 14:
					if (AppResources.Reading_radio_codeplug_completed == stat)
					{
						num = (short)1758134287;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)337641528;
					num2 = (int)((IntPtr)num);
					continue;
				case 15:
					goto IL_22C;
				case 16:
					goto IL_53F;
				case 17:
					goto IL_12FC;
				case 18:
					if (AppResources.Read_Radio_Verification_Start == stat)
					{
						num = (short)1934491698;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)383975453;
					num2 = (int)((IntPtr)num);
					continue;
				case 19:
					if (AppResources.Read_Radio_Info_Complete == stat)
					{
						num = (short)22937632;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)2027618306;
					num2 = (int)((IntPtr)num);
					continue;
				case 20:
					goto IL_EC6;
				case 21:
					if (AppResources.Read_Radio_Info == stat)
					{
						num = (short)363200516;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)512360467;
					num2 = (int)((IntPtr)num);
					continue;
				case 22:
					goto IL_13F8;
				case 23:
					if (AppResources.Open_Port_Complete == stat)
					{
						num = (short)1759641622;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)392626197;
					num2 = (int)((IntPtr)num);
					continue;
				case 24:
					if (AppResources.LP_Begin_Language_Pack_Update == stat)
					{
						num = (short)1852244016;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1212219420;
					num2 = (int)((IntPtr)num);
					continue;
				case 25:
					switch (0)
					{
					case 0:
						goto IL_112;
					}
					continue;
				case 26:
					goto IL_78C;
				case 27:
					goto IL_D5B;
				case 28:
					if (stat.Contains(AppResources.A_recommended_radio_language_is_available))
					{
						num = (short)1360330793;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1435435052;
					num2 = (int)((IntPtr)num);
					continue;
				case 29:
					if (AppResources.Read_Radio_Verification_ == stat)
					{
						num = (short)1757741076;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)726990874;
					num2 = (int)((IntPtr)num);
					continue;
				case 30:
					goto IL_1004;
				case 31:
					if (AppResources.Radio_Serial_Number_update_failed == stat)
					{
						num = (short)1750138886;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)397738030;
					num2 = (int)((IntPtr)num);
					continue;
				case 32:
					goto IL_F0C;
				case 33:
					if (AppResources.Read_Radio_Verification_Fail == stat)
					{
						num = (short)1828978704;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1768423434;
					num2 = (int)((IntPtr)num);
					continue;
				case 34:
				{
					num = (short)214237184;
					short num4 = num;
					if (AppResources.Opening_Port == stat)
					{
						num = (short)293404725;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)247463959;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 35:
					goto IL_44B;
				case 36:
					goto IL_6FD;
				case 37:
					goto IL_7B5;
				case 38:
					if (AppResources.Radio_Serial_Number_updated == stat)
					{
						num = (short)1571684365;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)57147423;
					num2 = (int)((IntPtr)num);
					continue;
				case 39:
					if (stat.Contains(AppResources.Warning_System_Type_Not_Match_While_Batch_Clone))
					{
						num = (short)429785095;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_159A;
				case 40:
					if (stat.Contains(AppResources.LP_Radio_display_Language_Not_Supported_By_this_radio))
					{
						num = (short)508952623;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1272447015;
					num2 = (int)((IntPtr)num);
					continue;
				case 41:
					goto IL_271;
				case 42:
					goto IL_1E7;
				case 43:
					if (AppResources.WriteRadio_Close_Port == stat)
					{
						num = (short)1483735057;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1733820471;
					num2 = (int)((IntPtr)num);
					continue;
				case 44:
					if (stat.Contains(AppResources.To_update_radio_language_please_write_via_USB))
					{
						num = (short)1500774427;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)172228660;
					num2 = (int)((IntPtr)num);
					continue;
				case 45:
					if (AppResources.WriteRadio_Writing_codeplug_to_radio == stat)
					{
						num = (short)1212874763;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)21233718;
					num2 = (int)((IntPtr)num);
					continue;
				case 46:
					if (AppResources.Password_validation_failed == stat)
					{
						num = (short)1771896841;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)2016673816;
					num2 = (int)((IntPtr)num);
					continue;
				case 47:
					goto IL_1129;
				case 48:
					goto IL_F4F;
				case 49:
					stat = string.Empty;
					num = (short)1511260168;
					num2 = (int)((IntPtr)num);
					continue;
				case 50:
					goto IL_8DA;
				case 51:
					if (AppResources.Writing_radio_codeplug == stat)
					{
						num = (short)93257728;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)547684397;
					num2 = (int)((IntPtr)num);
					continue;
				case 52:
					if (stat.Contains(AppResources.Radio_is_Missing_one_or_more_files_to_support_radio_language))
					{
						num = (short)65208356;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)2120286248;
					num2 = (int)((IntPtr)num);
					continue;
				case 53:
					goto IL_BAA;
				case 54:
					if (AppResources.Writing_radio_codeplug_completed == stat)
					{
						num = (short)532873258;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)407502849;
					if (num != 0)
					{
					}
					num = (short)966787115;
					num2 = (int)((IntPtr)num);
					continue;
				case 55:
					if (AppResources.Radio_Erase_in_Progress_please_wait == stat)
					{
						num = (short)1654718467;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)2041315366;
					num2 = (int)((IntPtr)num);
					continue;
				case 56:
					if (AppResources.Reading_radio_codeplug_ == stat)
					{
						num = (short)352256035;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)141295617;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_112:
				if (stat == null)
				{
					num = (short)394592305;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_B26;
				IL_78C:
				if (AppResources.Read_Radio_Verification_Complete == stat)
				{
					num = (short)1528561701;
					num2 = (int)((IntPtr)num);
					continue;
				}
				num = (short)1032323105;
				num2 = (int)((IntPtr)num);
				continue;
				IL_B26:
				int num5 = (int)(n * 100.0);
				this.pbBatchProgrammingProgress.Value = (double)num5;
				num = (short)688914466;
				num2 = (int)((IntPtr)num);
			}
			IL_1E7:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Write_to_radio_complete
			});
			this.WriteToLog_Success();
			return;
			IL_22C:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Reading_radio_codeplug_
			});
			this.WriteToLog_Cont();
			return;
			IL_271:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				stat
			});
			this.WriteToLog_Cont();
			return;
			IL_328:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Radio_Serial_Number_updated
			});
			this.WriteToLog_Cont();
			return;
			IL_44B:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Read_Radio_Info_
			});
			this.WriteToLog_Cont();
			return;
			IL_53F:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Read_Radio_Verification_Failure
			});
			this.WriteToLog_Failure();
			return;
			IL_6FD:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				stat
			});
			this.WriteToLog_Cont();
			return;
			IL_7B5:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Read_Radio_Verification_Complete
			});
			this.WriteToLog_Cont();
			return;
			IL_8DA:
			this.ProgText.Text = string.Concat(new string[]
			{
				RptMgrErrorHandler.b("\ud889憐﶑꺓뚕", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Read_Radio_Verification_Start_
			});
			this.WriteToLog_Cont();
			return;
			IL_A73:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Begin_read_codeplug
			});
			this.WriteToLog_Cont();
			return;
			IL_B21:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Begin_write_to_radio
			});
			this.WriteToLog_Cont();
			return;
			IL_BAA:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Opening_Connection_To_Radio
			});
			this.WriteToLog_Initial();
			return;
			IL_BEF:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Write_to_radio_in_progress
			});
			this.WriteToLog_Cont();
			return;
			IL_CA5:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Password_validation_failed
			});
			this.WriteToLog_Failure();
			return;
			IL_D5B:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				stat
			});
			this.WriteToLog_Cont();
			return;
			IL_DA1:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Read_radio_info_start_
			});
			this.WriteToLog_Cont();
			return;
			IL_EC6:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Read_Radio_Verification_
			});
			this.WriteToLog_Cont();
			return;
			IL_F0C:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Read_radio_info_complete_
			});
			this.WriteToLog_Cont();
			return;
			IL_F4F:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.LP_Checking_Radio_Language_Settings
			});
			this.WriteToLog_Cont();
			return;
			IL_1004:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Read_radio_unpack_failure
			});
			this.WriteToLog_Failure();
			return;
			IL_1129:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				stat
			});
			this.WriteToLog_Cont();
			return;
			IL_124E:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Radio_Serial_Number_update_failed
			});
			this.WriteToLog_Failure();
			return;
			IL_1292:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Read_radio_codeplug_complete
			});
			this.WriteToLog_Cont();
			return;
			IL_12FC:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Write_radio_release_complete
			});
			this.WriteToLog_Cont();
			return;
			IL_13B5:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Radio_Erasing_please_wait
			});
			this.WriteToLog_Cont();
			return;
			IL_13F8:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.Connecting_opened_to_radio
			});
			this.WriteToLog_Cont();
			return;
			IL_1433:
			num = (short)269680640;
			if (num != 0)
			{
			}
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				stat
			});
			this.WriteToLog_Cont();
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉ겋ꎍ붏늑뒓", a_),
				AppResources.No_Need_Retry_Batch_Programming
			});
			this.WriteToLog_Failure();
			return;
			IL_159A:
			this.ProgText.Text = string.Concat(new string[]
			{
				AppResources.Radio_Colon,
				RptMgrErrorHandler.b("ꪉ", a_),
				this.CurrentRadioID,
				RptMgrErrorHandler.b("ꖉ", a_),
				this.CurrentRadioIpAddress,
				RptMgrErrorHandler.b("ꪉꆋꎍ낏", a_),
				stat
			});
			this.WriteToLog_Failure();
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x000CF540 File Offset: 0x000CD740
		internal void CallMainFinish(int status)
		{
			short num = (short)695267926;
			short num2 = num;
			num = (short)1732112982;
			switch (num2 == num)
			{
			}
			num = (short)111673344;
			if (num != 0)
			{
			}
			num = (short)1671495680;
			short num3 = num;
			num = (short)1627979777;
			if (num != 0)
			{
			}
			base.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new POP25BatchProgrammerProgress.MainFinish(this.CloneFinished), status);
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x000CF60C File Offset: 0x000CD80C
		internal void CloneFinished(int status)
		{
			int a_ = 6;
			short num = (short)1850146816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_187;
				}
				POP25RadioInfo pop25RadioInfo3;
				for (;;)
				{
					IL_30:
					double num3;
					switch (num2)
					{
					case 0:
						num = (short)211156993;
						if (num != 0)
						{
						}
						this.pbOverallBatchProgrammingProgress.Value = num3 * 100.0;
						num = (short)1499267119;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						goto IL_A26;
					case 2:
						if (this.w.Count == 1)
						{
							num = (short)1927020604;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_E71;
					case 3:
						goto IL_E71;
					case 4:
					{
						this.w.RemoveAt(0);
						POP25RadioInfo pop25RadioInfo = this.w[0];
						this.dgBatchProgrammingProgress.SelectedItem = this.dgBatchProgrammingProgress.Items[pop25RadioInfo.IndexInList];
						this.dgBatchProgrammingProgress.ScrollIntoView(this.dgBatchProgrammingProgress.Items[pop25RadioInfo.IndexInList]);
						pop25RadioInfo.Status = AppResources.In_Progress;
						this.CloneRadioUsingRadioIdOrRadioIp(pop25RadioInfo);
						num = (short)1152385036;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 5:
						if (status == 1)
						{
							num = (short)911015951;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_119D;
					case 6:
						goto IL_80C;
					case 7:
						goto IL_BD0;
					case 8:
						if (status == 1)
						{
							num = (short)1908408350;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)20971561;
						num2 = (int)((IntPtr)num);
						continue;
					case 9:
					{
						POP25RadioInfo pop25RadioInfo2 = this.w[0];
						this.dgBatchProgrammingProgress.SelectedItem = this.dgBatchProgrammingProgress.Items[pop25RadioInfo2.IndexInList];
						this.dgBatchProgrammingProgress.ScrollIntoView(this.dgBatchProgrammingProgress.Items[pop25RadioInfo2.IndexInList]);
						pop25RadioInfo2.Status = AppResources.In_Progress;
						this.CloneRadioUsingRadioIdOrRadioIp(pop25RadioInfo2);
						num = (short)1583349798;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 10:
						num = (short)928710700;
						num2 = (int)((IntPtr)num);
						continue;
					case 11:
						goto IL_119D;
					case 12:
						goto IL_F7E;
					case 13:
						if (this.w.Count > 1)
						{
							num = (short)979697668;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)271908926;
						num2 = (int)((IntPtr)num);
						continue;
					case 14:
						try
						{
							num = (short)546308097;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								num = (short)603243134;
								short num4 = num;
								num = (short)940950142;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1860829184;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
									{
										IEnumerator<POP25RadioInfo> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)425066498;
											num2 = (int)((IntPtr)num);
											continue;
										}
										POP25RadioInfo item = enumerator.Current;
										this.w.Add(item);
										num = (short)370278403;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 1:
										goto IL_CC5;
									case 2:
										num = (short)1203044356;
										num2 = (int)((IntPtr)num);
										continue;
									case 4:
										goto IL_DBD;
									}
									goto IL_D36;
								}
								IL_CC5:
								switch (0)
								{
								case 0:
									IL_D36:
									goto IL_D68;
								}
								continue;
								IL_D68:
								num = (short)1594097664;
								num2 = (int)((IntPtr)num);
							}
							IL_DBD:
							goto IL_444;
						}
						finally
						{
							num = (short)1907163137;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								IEnumerator<POP25RadioInfo> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1412104194;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_DF4;
									}
									continue;
								case 2:
									goto IL_E2C;
								}
								IL_DF4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1618477056;
								num2 = (int)((IntPtr)num);
							}
							IL_E2C:;
						}
						goto IL_E2F;
						IL_444:
						this.totItems = (double)this.dgBatchProgrammingProgress.Items.Count;
						this.v.Clear();
						num = (short)973078601;
						num2 = (int)((IntPtr)num);
						continue;
					case 15:
					{
						int num5 = DVRSXmlUtil.ExportDVRSAfterClone(this.j);
						num = (short)259457091;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 16:
						if (this.v.Count > 0)
						{
							num = (short)462094414;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_391;
					case 17:
						num = (short)648413230;
						num2 = (int)((IntPtr)num);
						continue;
					case 18:
						num = (short)723451978;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
						this.v.Add(this.w.ElementAt(0));
						num = (short)462290983;
						num2 = (int)((IntPtr)num);
						continue;
					case 20:
						pop25RadioInfo3 = this.w[0];
						num = (short)1559560244;
						num2 = (int)((IntPtr)num);
						continue;
					case 21:
						if (this.w.Count > 0)
						{
							num = (short)1965096980;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_9BF;
					case 22:
						goto IL_F7E;
					case 23:
						if (!this.BatchProgrammingComplete)
						{
							num = (short)932315154;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_BD0;
					case 24:
						num = (short)2136604728;
						num2 = (int)((IntPtr)num);
						continue;
					case 25:
						num = (short)1151336464;
						num2 = (int)((IntPtr)num);
						continue;
					case 26:
						this.ProgText.Text = AppResources.User_Action_Batch_Programming_Cancelled;
						this.txtBoxProgressStatus.AppendText(string.Concat(new string[]
						{
							RptMgrErrorHandler.b("蒈膊", a_),
							DateTime.Now.ToString(),
							RptMgrErrorHandler.b("ꦈꚊꂌ꾎", a_),
							AppResources.User_Action_Batch_Programming_Cancelled,
							Environment.NewLine
						}));
						this.txtBoxProgressStatus.ScrollToEnd();
						num = (short)1178861602;
						num2 = (int)((IntPtr)num);
						continue;
					case 27:
						num = (short)605290545;
						num2 = (int)((IntPtr)num);
						continue;
					case 28:
						if (this.CurRetry == 0)
						{
							num = (short)1565065226;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_6C9;
					case 29:
						if (this.RetryCount > 0)
						{
							num = (short)1181024275;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_A26;
					case 30:
						num = (short)1937702991;
						num2 = (int)((IntPtr)num);
						continue;
					case 31:
						if (this.r)
						{
							num = (short)273481799;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3D2;
					case 32:
						if (this.CurRetry == 0)
						{
							num = (short)872611904;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_C7B;
					case 33:
						num = (short)274923592;
						num2 = (int)((IntPtr)num);
						continue;
					case 34:
						return;
					case 35:
						goto IL_E71;
					case 36:
						goto IL_80C;
					case 37:
						num = (short)799146060;
						num2 = (int)((IntPtr)num);
						continue;
					case 38:
						goto IL_391;
					case 39:
						goto IL_A26;
					case 40:
						goto IL_E2F;
					case 41:
						if (status == -1)
						{
							num = (short)942473253;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1890058268;
						num2 = (int)((IntPtr)num);
						continue;
					case 42:
						this.pbOverallBatchProgrammingProgress.Value = num3 * 100.0;
						num = (short)1274085379;
						num2 = (int)((IntPtr)num);
						continue;
					case 43:
						if (this.RetryCount == 0)
						{
							num = (short)166330438;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_E71;
					case 44:
						if (this.RetryCount == 0)
						{
							num = (short)1129381930;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_6C9;
					case 45:
						goto IL_59B;
					case 46:
						if (this.CancelBatchProgramming)
						{
							num = (short)937361434;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 47:
						goto IL_59B;
					case 48:
						if (this.CurRetry == 0)
						{
							num = (short)1731461144;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_8BE;
					case 49:
						if (!this.CancelBatchProgramming)
						{
							num = (short)32571417;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_391;
					case 50:
						if (this.v.Count <= 0)
						{
							num = (short)1296171063;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_F7E;
					case 51:
						if (this.RetryCount != 0)
						{
							num = (short)531890244;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_59B;
					case 52:
						goto IL_9BF;
					case 53:
					{
						num = (short)1531445248;
						short num6 = num;
						this.ProgText.Text = string.Concat(new string[]
						{
							AppResources.Radio_Colon,
							RptMgrErrorHandler.b("ꦈ", a_),
							this.CurrentRadioID,
							RptMgrErrorHandler.b("Ꚉ", a_),
							this.CurrentRadioIpAddress,
							RptMgrErrorHandler.b("ꦈꮊꂌꊎ놐뎒", a_),
							AppResources.Export_DVRS_MSU_Data_Failed_Error_Writing_File
						});
						this.WriteToLog_Cont();
						num = (short)1521942539;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 54:
						this.pbOverallBatchProgrammingProgress.Value = num3 * 100.0;
						num = (short)461111302;
						num2 = (int)((IntPtr)num);
						continue;
					case 55:
						this.BatchProgrammingComplete = true;
						num = (short)18874390;
						num2 = (int)((IntPtr)num);
						continue;
					case 56:
						if (this.RetryCount != 0)
						{
							num = (short)1753546832;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_80C;
					case 57:
						if (this.w.Count == 0)
						{
							num = (short)2072707155;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_391;
					case 58:
						num = (short)1420230699;
						num2 = (int)((IntPtr)num);
						continue;
					case 59:
						if (this.RetryCount > 0)
						{
							num = (short)897712155;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_391;
					case 60:
						this.pbOverallBatchProgrammingProgress.Value = 100.0;
						num = (short)2136014883;
						num2 = (int)((IntPtr)num);
						continue;
					case 61:
						this.w.RemoveAt(0);
						num = (short)828964914;
						num2 = (int)((IntPtr)num);
						continue;
					case 62:
						if (this.w.Count == 1)
						{
							num = (short)1290469437;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_F7E;
					case 63:
						goto IL_3D2;
					case 64:
						num = (short)4456499;
						num2 = (int)((IntPtr)num);
						continue;
					case 65:
						this.ProgText.Text = string.Concat(new string[]
						{
							AppResources.Radio_Colon,
							RptMgrErrorHandler.b("ꦈ", a_),
							this.CurrentRadioID,
							RptMgrErrorHandler.b("Ꚉ", a_),
							this.CurrentRadioIpAddress,
							RptMgrErrorHandler.b("ꦈꮊꂌꊎ놐뎒", a_),
							AppResources.Export_DVRS_MSU_Data_Completed
						});
						this.WriteToLog_Cont();
						num = (short)1583874117;
						num2 = (int)((IntPtr)num);
						continue;
					case 66:
						if (this.RetryCount == 0)
						{
							num = (short)1081212928;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_B4F;
					case 67:
					{
						int num5;
						if (num5 == 1)
						{
							num = (short)1842479169;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)221184077;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 68:
						goto IL_C7B;
					case 69:
						goto IL_119D;
					case 70:
						num = (short)1699479554;
						num2 = (int)((IntPtr)num);
						continue;
					case 71:
						RadioAccessValidator.RestoreCachedCodeplugSecurityFields(this.k, this.l, this.m, this.n, this.o, this.q, this.p);
						num = (short)894697535;
						num2 = (int)((IntPtr)num);
						continue;
					case 72:
						if (this.RetryCount == 0)
						{
							num = (short)9568310;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_8F4;
					case 73:
						if (this.w.Count > 0)
						{
							num = (short)900530185;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_391;
					case 74:
						if (this.CancelBatchProgramming)
						{
							num = (short)1566441479;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 75:
						if (!this.BatchProgrammingComplete)
						{
							num = (short)337182737;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 76:
						if (this.CurRetry == 0)
						{
							num = (short)461766689;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_8F4;
					case 77:
					{
						int num5;
						if (num5 == 0)
						{
							num = (short)240386101;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_119D;
					}
					case 78:
					{
						this.BatchProgrammingComplete = false;
						int num7 = this.RetryCount;
						this.RetryCount = num7 - 1;
						num7 = this.CurRetry;
						this.CurRetry = num7 + 1;
						IEnumerator<POP25RadioInfo> enumerator = this.v.GetEnumerator();
						num = (short)300548110;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 79:
						if (this.CurRetry == 0)
						{
							num = (short)465043496;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_B4F;
					case 80:
						goto IL_8BE;
					case 81:
						if (this.CurRetry > 0)
						{
							num = (short)1656553530;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_E71;
					case 82:
						goto IL_A26;
					case 83:
						num = (short)633208891;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_187;
					IL_391:
					num = (short)1179975703;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3D2:
					num = (short)507641861;
					num2 = (int)((IntPtr)num);
					continue;
					IL_59B:
					pop25RadioInfo3.Status = AppResources.SUCCESS_All_Uppercase_Id;
					num = (short)1938292818;
					num2 = (int)((IntPtr)num);
					continue;
					IL_6C9:
					num = (short)1082720337;
					num2 = (int)((IntPtr)num);
					continue;
					IL_80C:
					pop25RadioInfo3.Status = AppResources.FAILED_All_UpperCase_Id;
					num = (short)501743617;
					num2 = (int)((IntPtr)num);
					continue;
					IL_8BE:
					double num8;
					this.pbOverallBatchProgrammingProgress.Value = this.pbOverallBatchProgrammingProgress.Value + num8;
					num = (short)804651044;
					num2 = (int)((IntPtr)num);
					continue;
					IL_8F4:
					num = (short)50724912;
					num2 = (int)((IntPtr)num);
					continue;
					IL_9BF:
					num3 = ((double)pop25RadioInfo3.IndexInList + 1.0) / this.totItems;
					num8 = 100.0 / this.totItems;
					num = (short)1000931336;
					num2 = (int)((IntPtr)num);
					continue;
					IL_A26:
					num = (short)2132803615;
					num2 = (int)((IntPtr)num);
					continue;
					IL_B4F:
					num = (short)296091680;
					num2 = (int)((IntPtr)num);
					continue;
					IL_BD0:
					this.btnBatchProgrammingClose.IsEnabled = true;
					this.btnSaveToFile.IsEnabled = true;
					this.btnBatchProgrammingCancel.IsEnabled = false;
					this.BatchProgrammingInProgress = false;
					num = (short)1260519499;
					num2 = (int)((IntPtr)num);
					continue;
					IL_C7B:
					this.pbOverallBatchProgrammingProgress.Value = this.pbOverallBatchProgrammingProgress.Value + num8;
					num = (short)1098842157;
					num2 = (int)((IntPtr)num);
					continue;
					IL_E2F:
					num = (short)1245118530;
					num2 = (int)((IntPtr)num);
					continue;
					IL_E71:
					pop25RadioInfo3.Status = AppResources.FAILED_All_UpperCase_Id;
					num = (short)2107047965;
					num2 = (int)((IntPtr)num);
					continue;
					IL_F7E:
					num = (short)2096824377;
					num2 = (int)((IntPtr)num);
					continue;
					IL_119D:
					num = (short)738852877;
					num2 = (int)((IntPtr)num);
				}
				return;
				IL_187:
				pop25RadioInfo3 = new POP25RadioInfo();
				num = (short)374997013;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x04000467 RID: 1127
		private DispatcherTimer a;

		// Token: 0x04000468 RID: 1128
		private bool b;

		// Token: 0x04000469 RID: 1129
		private string c = "";

		// Token: 0x0400046A RID: 1130
		private string d = "";

		// Token: 0x0400046B RID: 1131
		private double e;

		// Token: 0x0400046C RID: 1132
		private bool f;

		// Token: 0x0400046D RID: 1133
		private bool g;

		// Token: 0x0400046E RID: 1134
		public double totItems;

		// Token: 0x0400046F RID: 1135
		private int h;

		// Token: 0x04000470 RID: 1136
		public const int RADIO_ID_MAX = 16777211;

		// Token: 0x04000471 RID: 1137
		private SpecialFeaturesSettings i = new SpecialFeaturesSettings();

		// Token: 0x04000472 RID: 1138
		private string j = "";

		// Token: 0x04000473 RID: 1139
		private bool k;

		// Token: 0x04000474 RID: 1140
		private bool l;

		// Token: 0x04000475 RID: 1141
		private int m;

		// Token: 0x04000476 RID: 1142
		private int n;

		// Token: 0x04000477 RID: 1143
		private int o;

		// Token: 0x04000478 RID: 1144
		private int p;

		// Token: 0x04000479 RID: 1145
		private ASKProgrammingHistoryInnerRecset q;

		// Token: 0x0400047A RID: 1146
		private bool r;

		// Token: 0x0400047B RID: 1147
		private PNServer s = new PNServer();

		// Token: 0x0400047C RID: 1148
		private byte[] t;

		// Token: 0x0400047D RID: 1149
		private ObservableCollection<POP25RadioInfo> u = new ObservableCollection<POP25RadioInfo>();

		// Token: 0x0400047E RID: 1150
		private ObservableCollection<POP25RadioInfo> v = new ObservableCollection<POP25RadioInfo>();

		// Token: 0x0400047F RID: 1151
		private ObservableCollection<POP25RadioInfo> w = new ObservableCollection<POP25RadioInfo>();

		// Token: 0x04000480 RID: 1152
		[CompilerGenerated]
		private string x;

		// Token: 0x04000481 RID: 1153
		[CompilerGenerated]
		private bool y;

		// Token: 0x04000482 RID: 1154
		[CompilerGenerated]
		private bool z;

		// Token: 0x04000483 RID: 1155
		[CompilerGenerated]
		private bool aa;

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x06000AE5 RID: 2789
		public delegate void UpdateProgress(double n, string stat);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x06000AE9 RID: 2793
		private delegate void MainFinish(int status);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x06000AED RID: 2797
		public delegate void WriteRadioQuery(Comms.RadioRtn info);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06000AF1 RID: 2801
		private delegate int MainThreadUpdateRadioIds(RadioIdInfo tempRadioIds);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x06000AF5 RID: 2805
		private delegate void UpdateRadioOverallProgressBarDelegate(DependencyProperty dp, object val);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x06000AF9 RID: 2809
		private delegate void RadioPresent(POP25RadioInfo currentRadio, bool bPresenceReturn, string statusMsg, string networkError);
	}
}
