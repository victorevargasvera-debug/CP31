using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using ACPBrowser;
using AcpCommonLib;
using AcpUI.Common;
using AcpUtility;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Programming.UI;
using SSLAdminTool;
using SSLMangrComp;
using SSLMangrComp.Packets;

namespace SpecialFeatures.Programming
{
	// Token: 0x02000085 RID: 133
	public class OTAPProgrammingWindow : global::System.Windows.Window, global::System.ComponentModel.INotifyPropertyChanged, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000A46 RID: 2630 RVA: 0x000BCCE0 File Offset: 0x000BAEE0
		// (remove) Token: 0x06000A47 RID: 2631 RVA: 0x000BCE14 File Offset: 0x000BB014
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
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1728708610;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_D5;
					case 1:
						goto IL_D5;
					case 2:
						return;
					}
					break;
					IL_D5:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.d, value2, propertyChangedEventHandler2);
					num2 = (short)1215496192;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1C:
				num2 = (short)722206721;
				if (num2 != 0)
				{
				}
				num2 = (short)818937856;
				short num3 = num2;
				num2 = (short)2058976918;
				short num4 = num2;
				num2 = (short)1549696662;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num2 = (short)579600384;
					if (num2 != 0)
					{
					}
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler = this.d;
					num2 = (short)590675969;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
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
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1978662914;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_B1;
					case 1:
						goto IL_B1;
					case 2:
						return;
					}
					break;
					IL_B1:
					num2 = (short)1438384129;
					if (num2 != 0)
					{
					}
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.d, value2, propertyChangedEventHandler2);
					num2 = (short)1840447488;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1C:
				num2 = (short)1068901413;
				short num3 = num2;
				num2 = (short)1904354341;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num2 = (short)2090532864;
					short num4 = num2;
					break;
				}
				}
				num2 = (short)491847680;
				if (num2 != 0)
				{
				}
				propertyChangedEventHandler = this.d;
				num2 = (short)11075585;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x000BCF4C File Offset: 0x000BB14C
		public global::System.Collections.Generic.List<global::SSLAdminTool.PNServer> ARS_DataSource
		{
			get
			{
				short num = (short)1038348887;
				short num2 = num;
				num = (short)1237185111;
				switch (num2 == num)
				{
				}
				num = (short)137428993;
				if (num != 0)
				{
				}
				num = (short)768999424;
				short num3 = num;
				num = (short)415498240;
				if (num != 0)
				{
				}
				return this.l;
			}
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x000BCFFC File Offset: 0x000BB1FC
		private OTAPProgrammingWindow()
		{
			int a_ = 4;
			this.i = new global::SpecialFeatures.SpecialFeaturesSettings();
			this.j = string.Empty;
			this.l = new global::System.Collections.Generic.List<global::SSLAdminTool.PNServer>();
			this.m = global::SSLMangrComp.Packets.SubscriptionType.Unreliable;
			base..ctor();
			this.InitializeComponent();
			global::AcpUI.Common.Utility.SetDirection(this);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string text = this.TimeOutTextbox.Text;
			stringBuilder.Insert(0, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("늆", a_), this.TimeOutTextbox.MaxLength);
			this.TimeOutTextbox.Text = stringBuilder.ToString();
			this.TimeOutTextbox.Measure(new global::System.Windows.Size(1000.0, 1000.0));
			global::System.Windows.Size desiredSize = this.TimeOutTextbox.DesiredSize;
			this.TimeOutTextbox.MinWidth = desiredSize.Width;
			this.TimeOutTextbox.MinHeight = desiredSize.Height;
			this.TimeOutTextbox.Text = text;
			stringBuilder.Remove(0, stringBuilder.Length);
			text = this.RadioID.Text;
			stringBuilder.Insert(0, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("늆", a_), this.RadioID.MaxLength);
			this.RadioID.Text = stringBuilder.ToString();
			this.RadioID.Measure(new global::System.Windows.Size(1000.0, 1000.0));
			desiredSize = this.RadioID.DesiredSize;
			this.RadioID.MinWidth = desiredSize.Width;
			this.RadioID.MinHeight = desiredSize.Height;
			this.RadioID.Text = text;
			this.b = new global::System.Windows.Threading.DispatcherTimer();
			this.b.Interval = new global::System.TimeSpan(0, 0, 0, 1, 0);
			this.b.Tick += this.TimerClock_Tick;
			base.DataContext = this;
			this.e = false;
			this.g = null;
			this.k = new global::SSLAdminTool.DataStoreDecryptHandler(112, 2048);
			try
			{
				if (this.k.XStoreAvailable)
				{
					this.l = this.k.XStoreRead();
					if (this.l != null)
					{
						foreach (global::SSLAdminTool.PNServer pnserver in this.l.ToList<global::SSLAdminTool.PNServer>())
						{
							if (pnserver.RecType != global::SSLAdminTool.RecordType.UNS)
							{
								this.l.Remove(pnserver);
							}
						}
					}
				}
				else
				{
					global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.The_ARS_XML_file_is_not_available, global::CommonResources.AppResources.ARS_XML_File_Not_Found, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation);
				}
			}
			catch (global::System.Exception)
			{
				global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.There_was_a_problem_loading_the_ARS_XML_file, global::CommonResources.AppResources.ARS_XML_File_Not_Found, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation);
			}
			this.autoRegServer.ItemsSource = this.ARS_DataSource;
			this.a();
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x000BD2D8 File Offset: 0x000BB4D8
		public global::SpecialFeatures.Programming.OTAPProgrammingParameters OTAPProgrammingLastState
		{
			get
			{
				short num = (short)1666084065;
				short num2 = num;
				num = (short)538012897;
				switch (num2 == num)
				{
				}
				num = (short)568590336;
				if (num != 0)
				{
				}
				num = (short)448528384;
				short num3 = num;
				num = (short)599130113;
				if (num != 0)
				{
				}
				return new global::SpecialFeatures.Programming.OTAPProgrammingParameters(this.ArsIpAddress, this.RadioIpAddress, this.RadioID.Text, this.RadioIpAddress, this.TimeOutTextbox.Text, this.useRadioIDCheckBox.IsChecked, this.InactivityTimerTextbox.Text);
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x000BD3C4 File Offset: 0x000BB5C4
		public global::SpecialFeatures.Programming.OTAPPrescenceResult PrescenceResult
		{
			get
			{
				short num = (short)198770689;
				if (num != 0)
				{
				}
				num = (short)1138159506;
				short num2 = num;
				num = (short)2122313618;
				switch (num2 == num)
				{
				}
				num = (short)1518927872;
				short num3 = num;
				num = (short)215416832;
				if (num != 0)
				{
				}
				return this.g;
			}
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x000BD470 File Offset: 0x000BB670
		public OTAPProgrammingWindow(global::SpecialFeatures.Programming.ProgrammingOperation operation) : this()
		{
			global::AcpUI.Common.Utility.SetDirection(this);
			this.a = operation;
			if (operation == global::SpecialFeatures.Programming.ProgrammingOperation.PROGRAMMING_OPERATION_READ)
			{
				this.operationLabel.Content = global::CommonResources.AppResources.POP25_Access_Radio;
				this.btnOperation.Content = global::CommonResources.AppResources.Access_Radio;
				return;
			}
			this.operationLabel.Content = global::CommonResources.AppResources.POP25_Access_Radio;
			this.btnOperation.Content = global::CommonResources.AppResources.Access_Radio;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x000BD4D8 File Offset: 0x000BB6D8
		public OTAPProgrammingWindow(global::SpecialFeatures.Programming.ProgrammingOperation operation, global::SpecialFeatures.Programming.OTAPProgrammingParameters userParameters)
		{
			int a_ = 7;
			this..ctor(operation);
			global::AcpUI.Common.Utility.SetDirection(this);
			if (userParameters != null)
			{
				try
				{
					this.RadioID.Text = userParameters._EnteredRadioID;
					this.RadioIpAddress = userParameters._RadioIPAddressFromServer;
					this.TimeOutTextbox.Text = userParameters._ArsServerTimeout;
					this.useRadioIDCheckBox.IsChecked = userParameters._UseARSServer;
					this.InactivityTimerTextbox.Text = userParameters._SessionInactiveTimer;
				}
				catch (global::System.Exception)
				{
					this.RadioIpAddress = "";
					this.RadioID.Text = "";
					this.RadioIpAddress = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("몉ꊋ뺍뺏ꊑ몓ꚕ", a_);
					this.TimeOutTextbox.Text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾉", a_);
					this.useRadioIDCheckBox.IsChecked = new bool?(true);
					this.InactivityTimerTextbox.Text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("릉", a_);
				}
			}
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x000BD5DC File Offset: 0x000BB7DC
		protected override void OnInitialized(global::System.EventArgs e)
		{
			short num = (short)1791924006;
			short num2 = num;
			num = (short)872126246;
			switch (num2 == num)
			{
			}
			num = (short)1315962881;
			if (num != 0)
			{
			}
			num = (short)1006567424;
			short num3 = num;
			num = (short)1077215232;
			if (num != 0)
			{
			}
			base.OnInitialized(e);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x000BD68C File Offset: 0x000BB88C
		private void b(string A_0)
		{
			short num = (short)174784513;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1827799040;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_78;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 2:
				{
					num = (short)841940993;
					if (num != 0)
					{
					}
					num = (short)130531810;
					short num4 = num;
					num = (short)898613730;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_78;
					default:
						goto IL_FF;
					}
					break;
				}
				}
				IL_59:
				if (this.d != null)
				{
					num = (short)1156710400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_78:
				this.d(this, new global::System.ComponentModel.PropertyChangedEventArgs(A_0));
				num = (short)42991618;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FF:
			num = (short)1333264384;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x000BD7B0 File Offset: 0x000BB9B0
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x000BD860 File Offset: 0x000BBA60
		public int RunningTime
		{
			get
			{
				short num = (short)2013182475;
				short num2 = num;
				num = (short)1129429515;
				switch (num2 == num)
				{
				}
				num = (short)536608768;
				if (num != 0)
				{
				}
				num = (short)80740352;
				short num3 = num;
				num = (short)1671233537;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				int a_ = 5;
				short num = (short)1734692165;
				short num2 = num;
				num = (short)556485957;
				switch (num2 == num)
				{
				}
				num = (short)1972174849;
				if (num != 0)
				{
				}
				num = (short)876347392;
				short num3 = num;
				num = (short)1037172736;
				if (num != 0)
				{
				}
				this.c = value;
				this.b(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda87ﾉ憐ﲑ슕鍊", a_));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x000BD930 File Offset: 0x000BBB30
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x000BD9DC File Offset: 0x000BBBDC
		public string ArsIpAddress
		{
			get
			{
				short num = (short)2017662926;
				short num2 = num;
				num = (short)851187662;
				switch (num2 == num)
				{
				}
				num = (short)1866268672;
				if (num != 0)
				{
				}
				num = (short)822673408;
				short num3 = num;
				num = (short)1386020865;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)131091563;
				short num2 = num;
				num = (short)190073963;
				switch (num2 == num)
				{
				}
				num = (short)307363841;
				if (num != 0)
				{
				}
				num = (short)1566441472;
				short num3 = num;
				num = (short)1066663936;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x000BDA90 File Offset: 0x000BBC90
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x000BDB44 File Offset: 0x000BBD44
		public string RadioIpAddress
		{
			get
			{
				short num = (short)791590332;
				short num2 = num;
				num = (short)921941436;
				switch (num2 == num)
				{
				}
				num = (short)1675165697;
				if (num != 0)
				{
				}
				num = (short)213516288;
				short num3 = num;
				num = (short)2059403264;
				if (num != 0)
				{
				}
				return this.RadioIPAddressTextBox.sIP_Address;
			}
			set
			{
				short num = (short)814136244;
				short num2 = num;
				num = (short)917027764;
				switch (num2 == num)
				{
				}
				num = (short)1498546177;
				if (num != 0)
				{
				}
				num = (short)1418985472;
				short num3 = num;
				num = (short)1270022144;
				if (num != 0)
				{
				}
				this.RadioIPAddressTextBox.sIP_Address = value;
			}
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x000BDBFC File Offset: 0x000BBDFC
		private void onOTAPProgrammingWindowLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1352597504;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8C;
				}
				string empty;
				global::System.Collections.IEnumerator enumerator;
				for (;;)
				{
					IL_27:
					num = (short)1351745537;
					if (num != 0)
					{
					}
					num = (short)2027356160;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_2D5;
					case 1:
						if (empty != string.Empty)
						{
							num = (short)1250623488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FD;
					case 2:
						try
						{
							num = (short)772800517;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)75169798;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::SSLAdminTool.PNServer pnserver;
									if (pnserver.SecureConn)
									{
										num = (short)1725366276;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)34406400;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)752950058;
									short num4 = num;
									num = (short)1294342954;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_11C;
									default:
									{
										num = (short)1340997632;
										if (num != 0)
										{
										}
										global::SSLAdminTool.PNServer pnserver = (global::SSLAdminTool.PNServer)enumerator.Current;
										num = (short)1997406209;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 4:
								{
									global::SSLAdminTool.PNServer pnserver;
									this.a(pnserver, ref empty);
									num = (short)1460273154;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_11C;
								case 6:
									goto IL_25C;
								}
								goto IL_149;
								IL_11C:
								switch (0)
								{
								case 0:
									IL_149:
									goto IL_1E1;
								}
								continue;
								IL_1E1:
								num = (short)1378418691;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_25C:
							goto IL_BE;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_27E;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_26B:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)1841299458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)11337728;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D4;
								case 2:
									goto IL_2D2;
								}
								goto IL_27E;
							}
							IL_2D2:
							IL_2D4:
							goto EndFinally_7;
							IL_27E:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)173867009;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_26B;
							EndFinally_7:;
						}
						goto IL_2D5;
						IL_BE:
						num = (short)1772027905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_2FB;
					}
					goto IL_8C;
					IL_2D5:
					global::System.Windows.MessageBox.Show(this, empty, global::CommonResources.AppResources.Certificate_Warning);
					num = (short)953548803;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2FB:
				IL_2FD:
				this.c();
				return;
				IL_8C:
				empty = string.Empty;
				enumerator = this.autoRegServer.ItemsSource.GetEnumerator();
				num = (short)2088566786;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x000BDF28 File Offset: 0x000BC128
		protected override void OnClosing(global::System.ComponentModel.CancelEventArgs e)
		{
			short num = (short)1677131777;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)910688256;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_7B;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 2:
				{
					num = (short)1250230273;
					if (num != 0)
					{
					}
					num = (short)712828093;
					short num4 = num;
					num = (short)1125049533;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7B;
					default:
						goto IL_F7;
					}
					break;
				}
				}
				IL_5C:
				if (this.e)
				{
					num = (short)1953431552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_10F;
				IL_7B:
				e.Cancel = true;
				num = (short)1549271042;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F7:
			num = (short)22478848;
			if (num != 0)
			{
			}
			IL_10F:
			base.OnClosing(e);
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x000BE04C File Offset: 0x000BC24C
		private void btnGetIPOnly_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 13;
			short num = (short)912850944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_80;
				}
				bool flag;
				string empty;
				byte[] array;
				for (;;)
				{
					IL_31:
					int timeout;
					switch (num2)
					{
					case 0:
						goto IL_538;
					case 1:
						goto IL_172;
					case 2:
						goto IL_28B;
					case 3:
						num = (short)1185546252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						string str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첏\udf91ﮓ솟ﺡﮧ춫\udaad톯킳\udbb5톷풹꾿뛁ꯃ듅Ꟈꛉ귋铏럑닓럕귗뛙꣛ﻝꏟ蟡難鋥臧賩藫跭釯蛱釳ꫵ鳷鋹賻鿽狿持椃⠅砇漉愋", a_);
						string folderPath = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
						num = (short)362807303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (this.d())
						{
							num = (short)1175126024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						if (((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).SecureConn)
						{
							num = (short)431751172;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28B;
					case 7:
					{
						string str;
						string folderPath;
						if (global::System.IO.File.Exists(folderPath + str))
						{
							num = (short)64618510;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						string there_was_a_problem_with_reading_the_Diffy_Helman_Key_files_installed = global::CommonResources.AppResources.There_was_a_problem_with_reading_the_Diffy_Helman_Key_files_installed;
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, there_was_a_problem_with_reading_the_Diffy_Helman_Key_files_installed);
						num = (short)735838208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						try
						{
							timeout = global::System.Convert.ToInt32(this.TimeOutTextbox.Text);
							goto IL_493;
						}
						catch (global::System.Exception)
						{
							goto IL_493;
						}
						goto IL_3D0;
						IL_493:
						num = (short)1705574406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						global::System.Windows.MessageBox.Show(this, empty, global::CommonResources.AppResources.Certificate_Warning);
						num = (short)1223360522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_41B;
					case 11:
						goto IL_177;
					case 12:
						if (this.a((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem, ref empty))
						{
							goto IL_26E;
						}
						goto IL_3D0;
					case 13:
					{
						num = (short)1629976498;
						short num3 = num;
						num = (short)1245345714;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26E;
						default:
							num = (short)534315009;
							if (num != 0)
							{
							}
							num = (short)690946048;
							if (num != 0)
							{
							}
							if (this.l.Count <= 0)
							{
								num = (short)1094516736;
								short num4 = num;
								num = (short)1026424833;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							timeout = 8;
							this.b();
							num = (short)1298202629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 14:
						try
						{
							string str;
							string folderPath;
							global::System.IO.FileStream fileStream = new global::System.IO.FileStream(folderPath + str, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
							array = new byte[fileStream.Length];
							fileStream.Read(array, 0, (int)fileStream.Length);
							fileStream.Close();
						}
						catch
						{
							flag = false;
							string there_was_a_problem_with_reading_the_Diffy_Helman_Key_file_valid = global::CommonResources.AppResources.There_was_a_problem_with_reading_the_Diffy_Helman_Key_file_valid;
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, there_was_a_problem_with_reading_the_Diffy_Helman_Key_file_valid);
						}
						goto IL_538;
					case 15:
						goto IL_3AF;
					case 16:
						if (empty != string.Empty)
						{
							num = (short)964231177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 17:
						if (flag)
						{
							num = (short)1887502339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_177;
					}
					goto IL_80;
					IL_177:
					num = (short)587137040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26E:
					num = (short)170393611;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28B:
					this.h = new global::SpecialFeatures.Programming.ARSGetIPAddressWorker(this.ArsIpAddress, ((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).PortNum, ((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).PortNum, ((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).CipherSuite, this.m, ((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).SecureConn, ((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).CACert, ((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).ClientCert, ((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).PassWordPhrase, timeout, array);
					this.h.GetIPAddressCompletedEvent += this.a;
					this.RunningTime = 0;
					this.b.IsEnabled = true;
					this.f = true;
					this.h.GetIPAddressAsync(this.RadioID.Text, null);
					this.btnOperation.IsEnabled = false;
					this.btnGetIPOnly.IsEnabled = false;
					num = (short)277348367;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D0:
					this.m = global::SSLMangrComp.Packets.SubscriptionType.Secure;
					num = (short)94765058;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_538:
					num = (short)712835089;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_172:
				global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Warning_There_is_no_ARS_selected, global::CommonResources.AppResources.ARS_XML_File_Not_Found, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation);
				return;
				IL_3AF:
				return;
				IL_41B:
				return;
				IL_80:
				flag = true;
				array = new byte[0];
				this.m = global::SSLMangrComp.Packets.SubscriptionType.Unreliable;
				empty = string.Empty;
				num = (short)742195213;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x000BE5EC File Offset: 0x000BC7EC
		private bool a(string A_0)
		{
			short num = (short)166946201;
			short num2 = num;
			num = (short)1501652377;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)1672478720;
				short num3 = num;
				break;
			}
			}
			num = (short)1899692032;
			if (num != 0)
			{
			}
			result = true;
			try
			{
				num = (short)792133653;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						byte[] addressBytes;
						if (addressBytes[1] == 0)
						{
							num = (short)3080234;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_389;
					}
					case 1:
						num = (short)1625227273;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						byte[] addressBytes;
						if (addressBytes[0] <= 191)
						{
							num = (short)1048510504;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AB;
					}
					case 3:
					{
						byte[] addressBytes;
						if (addressBytes[0] >= 224)
						{
							num = (short)1261043753;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_412;
					}
					case 4:
						goto IL_783;
					case 5:
					{
						byte[] addressBytes;
						if (addressBytes[3] == 255)
						{
							num = (short)2119761957;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_783;
					}
					case 6:
						num = (short)1929641989;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1458110466;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						byte[] addressBytes;
						if (addressBytes[2] == 255)
						{
							num = (short)1517813804;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AB;
					}
					case 9:
					{
						byte[] addressBytes;
						if (addressBytes[2] == 255)
						{
							num = (short)1465647127;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_741;
					}
					case 10:
					{
						byte[] addressBytes;
						if (addressBytes[0] <= 239)
						{
							num = (short)1587806256;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_412;
					}
					case 11:
						num = (short)801177601;
						if (num != 0)
						{
						}
						num = (short)973275150;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						result = false;
						num = (short)1407057924;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)842203155;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						byte[] addressBytes;
						if (addressBytes[3] == 0)
						{
							num = (short)1323892748;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_389;
					}
					case 15:
					{
						byte[] addressBytes;
						if (addressBytes[0] <= 127)
						{
							num = (short)1751253030;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_741;
					}
					case 16:
						num = (short)2108620800;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						byte[] addressBytes;
						if (addressBytes[2] == 0)
						{
							num = (short)2144731147;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_389;
					}
					case 18:
					{
						byte[] addressBytes;
						if (addressBytes[3] == 255)
						{
							num = (short)1807876116;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_741;
					}
					case 19:
					{
						byte[] addressBytes;
						if (addressBytes[0] <= 255)
						{
							num = (short)1866465310;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EC;
					}
					case 20:
						result = false;
						num = (short)1693581339;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						switch (0)
						{
						case 0:
							goto IL_166;
						}
						continue;
					case 22:
					{
						byte[] addressBytes = global::System.Net.IPAddress.Parse(A_0).GetAddressBytes();
						num = (short)1175650328;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						num = (short)1254948882;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						byte[] addressBytes;
						if (addressBytes[0] >= 240)
						{
							num = (short)2104229901;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EC;
					}
					case 25:
						num = (short)1554251791;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						byte[] addressBytes;
						if (addressBytes[0] >= 128)
						{
							num = (short)999358471;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AB;
					}
					case 27:
						goto IL_783;
					case 28:
						goto IL_783;
					case 29:
					{
						byte[] addressBytes;
						if (addressBytes[0] > 0)
						{
							num = (short)1617166361;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_741;
					}
					case 30:
						result = false;
						num = (short)1970339889;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_783;
					case 32:
						result = false;
						num = (short)303366172;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
					{
						byte[] addressBytes;
						if (addressBytes[1] == 255)
						{
							num = (short)1502085121;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_741;
					}
					case 34:
					{
						byte[] addressBytes;
						if (addressBytes[0] == 0)
						{
							num = (short)640942096;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_389;
					}
					case 35:
					{
						byte[] addressBytes;
						if (addressBytes[0] >= 192)
						{
							num = (short)661651502;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_783;
					}
					case 36:
					{
						byte[] addressBytes;
						if (addressBytes[0] <= 223)
						{
							num = (short)719716358;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_783;
					}
					case 37:
						result = false;
						num = (short)966000671;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)931332129;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						goto IL_79B;
					case 40:
						num = (short)1094582280;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						num = (short)2063007754;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						num = (short)2023161873;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						goto IL_783;
					case 44:
						num = (short)1137836077;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
					{
						byte[] addressBytes;
						if (addressBytes[3] == 255)
						{
							num = (short)1053229088;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AB;
					}
					case 46:
						num = (short)744226852;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_783;
					case 48:
						result = false;
						num = (short)404815919;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						goto IL_783;
					}
					IL_166:
					if (!string.IsNullOrEmpty(A_0))
					{
						num = (short)1912602646;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = false;
					num = (short)531693611;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AB:
					num = (short)482476067;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EC:
					num = (short)957480963;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_389:
					num = (short)467533853;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_412:
					num = (short)308936738;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_741:
					num = (short)1971257370;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_783:
					num = (short)1436155943;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_79B:;
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x000BEDB8 File Offset: 0x000BCFB8
		private bool d()
		{
			int a_ = 12;
			short num = (short)1779433472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9F;
				}
				bool? isChecked;
				bool flag;
				bool flag2;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						num = (short)116064281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (isChecked.GetValueOrDefault() == flag & isChecked != null)
						{
							num = (short)1858535445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5BA;
					case 2:
						if (!this.a(this.ArsIpAddress))
						{
							num = (short)195297295;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_149;
					case 3:
						if (!string.IsNullOrEmpty(this.ArsIpAddress))
						{
							num = (short)254869512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_149;
					case 4:
						num = (short)1157169162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						flag2 = false;
						global::System.Windows.MessageBox.Show(this, global::CommonResources.AppResources.Enter_Valid_IP_For_Radio, global::CommonResources.AppResources.Invalid_Radio_IP_Address, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Hand);
						num = (short)1859321876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)585564171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (flag2)
						{
							num = (short)1618280454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_826;
					case 8:
						num = (short)375521282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1415643137;
						if (num != 0)
						{
						}
						num = (short)564789260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (this.RadioID.Text != null)
						{
							num = (short)1068236800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 11:
						if (this.TimeOutTextbox.Text != null)
						{
							num = (short)1126760464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_826;
					case 12:
						if (!this.a(this.RadioIpAddress))
						{
							num = (short)2424832;
							short num3 = num;
							num = (short)1528889349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 13:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_767;
							}
							int num4;
							for (;;)
							{
								IL_748:
								switch (num2)
								{
								case 0:
									if (num4 > 16777211)
									{
										num = (short)1158283265;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_801;
								case 1:
									goto IL_7E4;
								case 2:
									goto IL_801;
								case 3:
									goto IL_819;
								case 4:
									num = (short)1749286912;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (num4 >= 1)
									{
										num = (short)582746116;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7E4;
								}
								goto IL_767;
								IL_7E4:
								flag2 = false;
								num = (short)1892745218;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_801:
								num = (short)238551043;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_819:
							return flag2;
							IL_767:
							num4 = global::System.Convert.ToInt32(this.RadioID.Text);
							num = (short)1572929541;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_748;
						}
						catch (global::System.Exception)
						{
							return false;
						}
						goto IL_826;
					case 14:
						if (flag2)
						{
							num = (short)19202072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_633;
					case 15:
						flag2 = false;
						global::System.Windows.MessageBox.Show(this, global::CommonResources.AppResources.Enter_Valid_IP_For_Auto_Registration_Server, global::CommonResources.AppResources.Invalid_IP_Address, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Hand);
						num = (short)1288634386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)268173335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						try
						{
							num = (short)1675493379;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									this.TimeOutTextbox.Text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("몎", a_);
									num = (short)558432257;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_322;
								case 2:
									goto IL_33A;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_2C8;
									}
									continue;
								}
								IL_2C8:
								if (global::System.Convert.ToInt32(this.TimeOutTextbox.Text) < 5)
								{
									num = (short)435748864;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_322:
								num = (short)96731138;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_33A:
							goto IL_826;
						}
						catch (global::System.Exception)
						{
							flag2 = false;
							goto IL_826;
						}
						goto Block_7;
					case 18:
						goto IL_149;
					case 19:
						if (flag2)
						{
							num = (short)2035220484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 20:
						return flag2;
					case 21:
						num = (short)613941251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (!string.IsNullOrEmpty(this.RadioIpAddress))
						{
							num = (short)1861025801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 23:
						if (this.TimeOutTextbox.Text.Length > 0)
						{
							num = (short)1367080977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_826;
					case 24:
						goto IL_347;
					case 25:
						if (this.RadioID.Text.Length > 0)
						{
							num = (short)1176633357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					}
					goto IL_9F;
					IL_149:
					num = (short)46137358;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5BA:
					num = (short)968622102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_7:
					try
					{
						IL_347:
						num = (short)384237574;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (this.RadioID.Text.Length > 0)
								{
									num = (short)339214338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4B2;
							case 1:
							{
								int num5;
								if (num5 > 16777211)
								{
									num = (short)904265732;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_51B;
							}
							case 2:
							{
								int num5 = global::System.Convert.ToInt32(this.RadioID.Text);
								num = (short)1360986121;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_534;
							case 4:
								goto IL_404;
							case 5:
								num = (short)1360592897;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_399;
								}
								continue;
							case 7:
								goto IL_51B;
							case 8:
								goto IL_51B;
							case 9:
							{
								int num5;
								if (num5 >= 1)
								{
									num = (short)1206190085;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_404;
							}
							case 10:
								num = (short)893583360;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_399:
							if (this.RadioID.Text != null)
							{
								num = (short)1517289482;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4B2;
							IL_404:
							flag2 = false;
							num = (short)157483015;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_4B2:
							num = (short)461469944;
							short num6 = num;
							num = (short)1565358328;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_534;
							default:
								num = (short)1551695872;
								if (num != 0)
								{
								}
								flag2 = false;
								num = (short)1228341256;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_51B:
							num = (short)595591171;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_534:
						goto IL_633;
					}
					catch (global::System.Exception)
					{
						flag2 = false;
						goto IL_633;
					}
					finally
					{
						num = (short)582090754;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								global::System.Windows.MessageBox.Show(this, global::CommonResources.AppResources.Enter_Valid_Radio_Device_ID, global::CommonResources.AppResources.Invalid_Device_ID, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Hand);
								num = (short)1464139777;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_5B7;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_573;
								}
								continue;
							}
							IL_573:
							if (flag2)
							{
								break;
							}
							num = (short)1542062080;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_5B7:;
					}
					goto IL_5BA;
					IL_633:
					num = (short)1502150663;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_826:
					num = (short)1640693779;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag2;
				IL_9F:
				flag2 = true;
				isChecked = this.useRadioIDCheckBox.IsChecked;
				flag = true;
				num = (short)1095827457;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x000BF6D4 File Offset: 0x000BD8D4
		private void OTAPProgrammingWindow_MouseLeftButtonDown(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
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
					goto IL_F7;
				case 1:
					return;
				case 2:
				{
					if (A_1.ChangedButton != global::System.Windows.Input.MouseButton.Left)
					{
						return;
					}
					num2 = (short)1946690817;
					short num3 = num2;
					num2 = (short)1978868993;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F7;
					default:
					{
						num2 = (short)233046016;
						short num4 = num2;
						num2 = (short)131072000;
						if (num2 != 0)
						{
						}
						num2 = (short)1057423361;
						if (num2 != 0)
						{
						}
						num2 = (short)1951596544;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
				IL_F7:
				base.OnMouseLeftButtonDown(A_1);
				base.DragMove();
				num2 = (short)1627193345;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			global::AcpUI.Common.Utility.SetDirection(this);
			num2 = (short)32964610;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x000BF800 File Offset: 0x000BDA00
		private void btnOperation_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 16;
			short num = (short)1808007168;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				bool? isChecked;
				bool flag;
				byte[] array;
				bool flag2;
				string empty;
				int timeout;
				for (;;)
				{
					IL_30:
					string folderPath;
					string str;
					switch (num2)
					{
					case 0:
						if (isChecked.GetValueOrDefault() == flag & isChecked != null)
						{
							num = (short)443219986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1692991492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						try
						{
							global::System.IO.FileStream fileStream = new global::System.IO.FileStream(folderPath + str, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
							array = new byte[fileStream.Length];
							fileStream.Read(array, 0, (int)fileStream.Length);
							fileStream.Close();
							goto IL_136;
						}
						catch
						{
							flag2 = false;
							string there_was_a_problem_with_reading_the_Diffy_Helman_Key_file_valid = global::CommonResources.AppResources.There_was_a_problem_with_reading_the_Diffy_Helman_Key_file_valid;
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, there_was_a_problem_with_reading_the_Diffy_Helman_Key_file_valid);
							goto IL_136;
						}
						goto IL_5D0;
					case 2:
						if (empty != string.Empty)
						{
							num = (short)1123090435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						global::System.Windows.MessageBox.Show(this, empty, global::CommonResources.AppResources.Certificate_Warning);
						num = (short)1847984150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this.a(this.RadioIpAddress))
						{
							num = (short)178585616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.The_IP_Address_is_invalid, global::CommonResources.AppResources.Invalid_IP_Address, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Hand);
						num = (short)1978466323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)1226980285;
						short num3 = num;
						num = (short)1192836029;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_571;
						default:
							num = (short)1416822784;
							if (num != 0)
							{
							}
							if (this.l.Count <= 0)
							{
								num = (short)1874460680;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.f = false;
							num = (short)1500119055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						timeout = 8;
						num = (short)923729927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						try
						{
							timeout = global::System.Convert.ToInt32(this.TimeOutTextbox.Text);
							goto IL_4FD;
						}
						catch (global::System.Exception)
						{
							goto IL_4FD;
						}
						goto IL_190;
						IL_4FD:
						num = (short)77922316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_4D8;
					case 9:
						goto IL_136;
					case 10:
						goto IL_571;
					case 11:
						if (flag2)
						{
							num = (short)832503829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F5;
					case 12:
					{
						num = (short)1998651392;
						short num4 = num;
						if (((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).SecureConn)
						{
							num = (short)850460682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_190;
					}
					case 13:
						goto IL_5F0;
					case 14:
						goto IL_5F5;
					case 15:
						if (this.d())
						{
							num = (short)1657077766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						goto IL_38A;
					case 17:
					{
						if (global::System.IO.File.Exists(folderPath + str))
						{
							num = (short)1735524353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag2 = false;
						string there_was_a_problem_with_reading_the_Diffy_Helman_Key_files_installed = global::CommonResources.AppResources.There_was_a_problem_with_reading_the_Diffy_Helman_Key_files_installed;
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, there_was_a_problem_with_reading_the_Diffy_Helman_Key_files_installed);
						num = (short)726466569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						num = (short)858128389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_3BB;
					case 20:
						if (this.a((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem, ref empty))
						{
							num = (short)251396110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D0;
					case 21:
						num = (short)1607008276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_131;
					}
					goto IL_93;
					IL_136:
					num = (short)490143755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_571:
					str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾒\ud894춠슢捻ﮨ캮얰튲펶풸튺펼賀곂뇄꣆믈꓊ꇌ껎韒냔뇖룘껚뇜ꯞ쇠ꃢ胤闦鷨苪诬蛮鋰鋲致鋶ꗸ鿺闼迾怀焂搄樆✈笊栌戎", a_);
					folderPath = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
					num = (short)1204879361;
					if (num != 0)
					{
					}
					num = (short)259063825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D0:
					this.m = global::SSLMangrComp.Packets.SubscriptionType.Secure;
					num = (short)1973551117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F5:
					num = (short)1444675586;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_131:
				return;
				IL_190:
				this.h = new global::SpecialFeatures.Programming.ARSGetIPAddressWorker(this.ArsIpAddress, ((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).PortNum, ((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).PortNum, ((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).CipherSuite, this.m, ((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).SecureConn, ((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).CACert, ((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).ClientCert, ((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).PassWordPhrase, timeout, array);
				this.h.GetIPAddressCompletedEvent += this.a;
				this.RunningTime = 0;
				this.b.IsEnabled = true;
				this.e = true;
				this.btnOperation.IsEnabled = false;
				this.btnGetIPOnly.IsEnabled = false;
				this.h.GetIPAddressAsync(this.RadioID.Text, null);
				return;
				IL_38A:
				this.g = new global::SpecialFeatures.Programming.OTAPPrescenceResult(global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_USER_ENTERED, "", this.RadioIpAddress, "");
				base.DialogResult = new bool?(true);
				return;
				IL_3BB:
				return;
				IL_4D8:
				global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Warning_There_is_no_ARS_selected, global::CommonResources.AppResources.ARS_XML_File_Not_Found, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation);
				return;
				IL_5F0:
				goto IL_190;
				IL_93:
				flag2 = true;
				array = new byte[0];
				this.m = global::SSLMangrComp.Packets.SubscriptionType.Unreliable;
				empty = string.Empty;
				this.b();
				isChecked = this.useRadioIDCheckBox.IsChecked;
				flag = true;
				num = (short)1985609728;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x000BFECC File Offset: 0x000BE0CC
		private void a(global::SpecialFeatures.Programming.OTAPPrescenceResult A_0, object A_1)
		{
			int a_ = 13;
			short num = (short)437387269;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_8A;
				case 1:
					if (this.h != null)
					{
						num = (short)1870725131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B5;
				case 2:
					goto IL_26C;
				case 3:
					this.RadioIpAddress = A_0.DeviceIPAddress;
					num = (short)266076172;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, A_0.NetworkError);
					num = (short)1660551178;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 6:
				{
					num = (short)239468544;
					short num3 = num;
					num = (short)1525822504;
					short num4 = num;
					num = (short)583218216;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12F;
					default:
						num = (short)96010240;
						if (num != 0)
						{
						}
						this.g = A_0;
						base.DialogResult = new bool?(true);
						num = (short)1033306121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					if (!this.f)
					{
						num = (short)1223098374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B5;
				case 8:
					if (A_0.DevicePrescence == global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_PRESENT)
					{
						num = (short)1647050755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.RadioIpAddress = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꂏ벑꒓뢕ꢗ뒙겛", a_);
					num = (short)1355218946;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_12F;
				case 10:
					return;
				case 11:
					this.h.GetIPAddressCompletedEvent -= this.a;
					num = (short)2058027016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_26C;
				case 13:
					if (A_0.NetworkError != string.Empty)
					{
						num = (short)948699140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_65:
				if (!base.Dispatcher.CheckAccess())
				{
					num = (short)1025376256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.e = false;
				this.b.IsEnabled = false;
				num = (short)110886913;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B5:
				this.btnGetIPOnly.IsEnabled = true;
				this.btnOperation.IsEnabled = true;
				this.h = null;
				num = (short)506134541;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_12F:
				goto IL_1B5;
				IL_26C:
				num = (short)1096941575;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_8A:
			num = (short)1286930433;
			if (num != 0)
			{
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::SpecialFeatures.Programming.ARSGetIPAddressCompleted(this.a), A_0, new object[]
			{
				A_1
			});
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x000C0234 File Offset: 0x000BE434
		private void TimerClock_Tick(object A_0, global::System.EventArgs A_1)
		{
			short num;
			for (;;)
			{
				num = (short)1441857536;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)987955200;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					}
					case 1:
						goto IL_9F;
					case 2:
						this.RunningTime++;
						num = (short)1972699137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_59:
					if (!this.b.IsEnabled)
					{
						break;
					}
					num = (short)1446576130;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A1:
				num = (short)1875153800;
				short num4 = num;
				num = (short)1870107528;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_D6;
				}
				IL_9F:
				goto IL_A1;
			}
			IL_D6:
			num = (short)119996417;
			if (num != 0)
			{
			}
			num = (short)520617984;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x000C0358 File Offset: 0x000BE558
		private void F1HelpCommandCanExcute(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)361824256;
			short num2 = num;
			num = (short)43861961;
			short num3 = num;
			num = (short)224348105;
			switch (num3 == num)
			{
			}
			num = (short)1821900801;
			if (num != 0)
			{
			}
			num = (short)1568473088;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x000C040C File Offset: 0x000BE60C
		private void btnHelp_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num;
			try
			{
				num = (short)1060390027;
				short num2 = num;
				num = (short)567231627;
				switch (num2 == num)
				{
				}
				num = (short)201195520;
				if (num != 0)
				{
				}
				global::ACPBrowser.Utility.CloseHelpWindowIfOpen();
				global::ACPBrowser.Utility.DisplayCPSHelpDITA(null);
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1162739713;
			if (num != 0)
			{
			}
			num = (short)544014336;
			short num3 = num;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x000C04D4 File Offset: 0x000BE6D4
		private void useRadioIDCheckBox_Checked(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num;
			for (;;)
			{
				num = (short)1732247552;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1194590208;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					}
					case 1:
						goto IL_D4;
					case 2:
						num = (short)1228996609;
						if (num != 0)
						{
						}
						this.lblRadioIPOutput.Content = global::CommonResources.AppResources.Received_Radio_IP_Address;
						this.btnGetIPOnly.IsEnabled = true;
						num = (short)102498305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5A:
					if (this.lblRadioIPOutput == null)
					{
						break;
					}
					num = (short)89456642;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D6:
				num = (short)871668431;
				short num4 = num;
				num = (short)1181063887;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_10B;
				}
				IL_D4:
				goto IL_D6;
			}
			IL_10B:
			num = (short)501874688;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x000C0604 File Offset: 0x000BE804
		private void useRadioIDCheckBox_Unchecked(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num;
			for (;;)
			{
				num = (short)1517617152;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1448280064;
						short num3 = num;
						num = (short)1152581633;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					}
					case 1:
						goto IL_CF;
					case 2:
						this.lblRadioIPOutput.Content = global::CommonResources.AppResources.Enter_The_Radio_IP_s_Address;
						this.btnGetIPOnly.IsEnabled = false;
						num = (short)462225409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_80:
					if (this.lblRadioIPOutput == null)
					{
						break;
					}
					num = (short)985661442;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D1:
				num = (short)648723683;
				short num4 = num;
				num = (short)642694371;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_107;
				}
				IL_CF:
				goto IL_D1;
			}
			IL_107:
			num = (short)497745920;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x000C0730 File Offset: 0x000BE930
		private void btnCancel_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2091843584;
			short num2 = num;
			num = (short)1623900968;
			short num3 = num;
			num = (short)56804136;
			switch (num3 == num)
			{
			}
			num = (short)244776961;
			if (num != 0)
			{
			}
			num = (short)1673396224;
			if (num != 0)
			{
			}
			base.DialogResult = new bool?(false);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x000C07E4 File Offset: 0x000BE9E4
		private void ARSIPAddressTextBox_LostFocus(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1390804992;
			short num2 = num;
			num = (short)782771421;
			short num3 = num;
			num = (short)305472733;
			switch (num3 == num)
			{
			}
			num = (short)1333198848;
			if (num != 0)
			{
			}
			num = (short)252510209;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x000C0890 File Offset: 0x000BEA90
		private void ARSIPAddressTextBox_GotFocus(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1966342144;
			short num2 = num;
			num = (short)1359741432;
			short num3 = num;
			num = (short)141689336;
			switch (num3 == num)
			{
			}
			num = (short)693501952;
			if (num != 0)
			{
			}
			num = (short)2086141953;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x000C0938 File Offset: 0x000BEB38
		private bool a(global::SSLAdminTool.PNServer A_0, ref string A_1)
		{
			int a_ = 7;
			short num = (short)106823680;
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
				global::SSLAdminTool.RawData rawCertData;
				bool result;
				for (;;)
				{
					IL_30:
					global::System.DateTime notAfter;
					global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate;
					global::System.TimeSpan timeSpan2;
					switch (num2)
					{
					case 0:
						return false;
					case 1:
					{
						global::System.TimeSpan timeSpan;
						if (timeSpan.Days < 31)
						{
							num = (short)1429733388;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C0;
					}
					case 2:
						goto IL_3D1;
					case 3:
						goto IL_C0;
					case 4:
						if (notAfter.CompareTo(global::System.DateTime.Today) <= 0)
						{
							num = (short)716898314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C9;
					case 5:
					{
						try
						{
							x509Certificate = global::SSLMangrComp.CertificateLoader.LoadPfxCertificate(global::System.Convert.FromBase64String(rawCertData.mRawCliCert), rawCertData.mPassPhrase);
							goto IL_336;
						}
						catch
						{
							x509Certificate = global::SSLMangrComp.CertificateLoader.LoadCertificate(global::System.Convert.FromBase64String(rawCertData.mRawCliCert));
							goto IL_336;
						}
						goto IL_1C9;
						IL_336:
						global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate2;
						notAfter = x509Certificate2.NotAfter;
						num = (short)1558970375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						if (rawCertData == null)
						{
							num = (short)1645346816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate2 = global::SSLMangrComp.CertificateLoader.LoadCertificate(global::System.Convert.FromBase64String(rawCertData.mRawCACert));
						num = (short)2135162885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						if (notAfter.CompareTo(global::System.DateTime.Today) <= 0)
						{
							num = (short)1992097805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate2;
						notAfter = x509Certificate2.NotAfter;
						global::System.TimeSpan timeSpan = notAfter.Subtract(global::System.DateTime.Today);
						num = (short)1900740608;
						short num3 = num;
						num = (short)901840897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_C0;
					case 9:
						if (timeSpan2.Days < 31)
						{
							num = (short)2082799630;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 10:
						goto IL_10D;
					case 11:
					{
						num = (short)1402663214;
						short num4 = num;
						num = (short)98496814;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10D;
						default:
							goto IL_31C;
						}
						break;
					}
					case 12:
						A_1 = A_1 + global::CommonResources.AppResources.The_following_ARS_Data_records_have_CA_certificates_that_are_about_to_expire.AcpStringFormat(new object[]
						{
							A_0.PNSName
						}) + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("肉", a_);
						num = (short)1058668552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						result = true;
						A_1 = A_1 + global::CommonResources.AppResources.The_following_ARS_Data_records_have_CA_certificates_that_have_expired.AcpStringFormat(new object[]
						{
							A_0.PNSName
						}) + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("肉", a_);
						num = (short)2080505859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						A_1 = A_1 + global::CommonResources.AppResources.The_following_ARS_Data_records_have_Client_certificates_that_are_about_to_expire.AcpStringFormat(new object[]
						{
							A_0.PNSName
						}) + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("肉", a_);
						num = (short)1220608011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_73;
					IL_C0:
					notAfter = x509Certificate.NotAfter;
					num = (short)1283588100;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10D:
					result = true;
					A_1 = A_1 + global::CommonResources.AppResources.The_following_ARS_Data_records_have_Client_certificates_that_have_expired.AcpStringFormat(new object[]
					{
						A_0.PNSName
					}) + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("肉", a_);
					num = (short)1378418690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C9:
					notAfter = x509Certificate.NotAfter;
					timeSpan2 = notAfter.Subtract(global::System.DateTime.Today);
					num = (short)1406664713;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_31C:
				num = (short)308674560;
				if (num != 0)
				{
				}
				return result;
				IL_3D1:
				num = (short)948633601;
				if (num != 0)
				{
				}
				return result;
				IL_73:
				result = false;
				rawCertData = this.k.GetRawCertData(A_0.PNSName);
				num = (short)516620294;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x000C0DA0 File Offset: 0x000BEFA0
		private void autoRegServer_SelectionChanged(object A_0, global::System.Windows.Controls.SelectionChangedEventArgs A_1)
		{
			short num = (short)1519321088;
			short num2 = num;
			num = (short)753333709;
			short num3 = num;
			num = (short)1055651277;
			switch (num3 == num)
			{
			}
			num = (short)829685761;
			if (num != 0)
			{
			}
			num = (short)851116032;
			if (num != 0)
			{
			}
			this.c();
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x000C0E50 File Offset: 0x000BF050
		private void c()
		{
			short num = (short)336461824;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)496344437;
				short num3 = num;
				num = (short)2052824437;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1A8;
				default:
					num = (short)934346752;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_86;
						}
						continue;
					case 1:
						goto IL_1A8;
					case 2:
						this.j = ((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).PNServerIP.ToString();
						num = (short)622919683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).SecureConn)
						{
							num = (short)539099137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.txtboxConnectionType.Text = global::CommonResources.AppResources.Clear_Id;
						num = (short)1383858176;
						short num4 = num;
						num = (short)1007484932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_12B;
					}
					IL_86:
					if (this.l.Count <= 0)
					{
						return;
					}
					num = (short)1424949249;
					if (num != 0)
					{
					}
					num = (short)2015297538;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_12B:
			return;
			IL_1A8:
			this.txtboxConnectionType.Text = global::CommonResources.AppResources.Secure_Id;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x000C1008 File Offset: 0x000BF208
		private void b()
		{
			switch (0)
			{
			case 0:
				goto IL_6D;
			}
			short num;
			int num3;
			bool? isChecked;
			for (;;)
			{
				IL_0A:
				num = (short)1631406015;
				short num2 = num;
				num = (short)1078478783;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)391839744;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_EC;
					case 1:
					{
						num = (short)1481375744;
						short num4 = num;
						this.i.OTAP_ARS_IP_ADDRESS = ((global::SSLAdminTool.PNServer)this.autoRegServer.SelectedItem).PNSName;
						num = (short)1607073796;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1189412867;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this.l.Count > 0)
						{
							num = (short)1792147457;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6;
					case 4:
						goto IL_149;
					}
					goto IL_6D;
				}
				IL_EC:
				if (!isChecked.Value)
				{
					break;
				}
				num = (short)1736245250;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_149:
			IL_1B6:
			this.i.Save();
			return;
			IL_6D:
			num = (short)795082753;
			if (num != 0)
			{
			}
			this.i.OTAP_CPS_SESSION_INACTIVITY_TIMER = this.InactivityTimerTextbox.Text;
			global::SpecialFeatures.SpecialFeaturesSettings specialFeaturesSettings = this.i;
			isChecked = this.useRadioIDCheckBox.IsChecked;
			specialFeaturesSettings.OTAP_ARS_IP_CHKBOX = isChecked.Value;
			isChecked = this.useRadioIDCheckBox.IsChecked;
			num = (short)1029963776;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x000C11D8 File Offset: 0x000BF3D8
		private void a()
		{
			short num2;
			try
			{
				int num;
				for (;;)
				{
					this.InactivityTimerTextbox.Text = this.i.OTAP_CPS_SESSION_INACTIVITY_TIMER;
					this.useRadioIDCheckBox.IsChecked = new bool?(this.i.OTAP_ARS_IP_CHKBOX);
					num = -1;
					global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)this.autoRegServer.Items).GetEnumerator();
					try
					{
						num2 = (short)643170305;
						int num3 = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num2 = (short)484507652;
									num3 = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)584581123;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_83;
								}
								continue;
							case 2:
								goto IL_126;
							case 3:
							{
								global::SSLAdminTool.PNServer pnserver = (global::SSLAdminTool.PNServer)enumerator.Current;
								num++;
								if (!pnserver.PNSName.Equals(this.i.OTAP_ARS_IP_ADDRESS))
								{
									num2 = (short)1626406917;
									num3 = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_10F;
							}
							case 4:
								goto IL_10F;
							}
							IL_D6:
							num2 = (short)485359616;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
							IL_83:
							goto IL_D6;
							IL_10F:
							num2 = (short)2096562178;
							num3 = (int)((global::System.IntPtr)num2);
						}
						IL_126:;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_144;
						}
						int num3;
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_132:
							switch (num3)
							{
							case 0:
								if (disposable != null)
								{
									num2 = (short)1092747266;
									num3 = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_195;
							case 1:
								goto IL_193;
							case 2:
								disposable.Dispose();
								num2 = (short)587923457;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_144;
						}
						IL_193:
						IL_195:
						goto EndFinally_7;
						IL_144:
						disposable = (enumerator as global::System.IDisposable);
						num2 = (short)667156480;
						num3 = (int)((global::System.IntPtr)num2);
						goto IL_132;
						EndFinally_7:;
					}
					num2 = (short)619665259;
					short num4 = num2;
					num2 = (short)1933006699;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_1CC;
					}
				}
				IL_1CC:
				num2 = (short)552140800;
				if (num2 != 0)
				{
				}
				this.autoRegServer.SelectedIndex = num;
			}
			catch (global::System.Exception)
			{
			}
			num2 = (short)790429697;
			if (num2 != 0)
			{
			}
			num2 = (short)1884225536;
			short num5 = num2;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x000C145C File Offset: 0x000BF65C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 14;
			short num;
			for (;;)
			{
				num = (short)1900937216;
				short num2 = num;
				if (this.n)
				{
					break;
				}
				num = (short)1281450271;
				short num3 = num;
				num = (short)1600807199;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_72;
				}
			}
			return;
			IL_72:
			num = (short)337903616;
			if (num != 0)
			{
			}
			num = (short)1428619265;
			if (num != 0)
			{
			}
			this.n = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺐삒滛ﲜ욢쒤펦\udca8\ud9aa좬\udcae誰킲\udab4\udab6즸풺펼\udabe꿀럂럆믈꓊꫌뷎냐뻒룔뻖럘볚냞闠苢闤죦蛨鿪賬鿮臰臲髴郶诸髺郼鋾栀洂戄瀆怈攊椌怎昐㴒洔瘖琘眚", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x000C153C File Offset: 0x000BF73C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		internal global::System.Delegate _CreateDelegate(global::System.Type delegateType, string handler)
		{
			short num = (short)632029184;
			short num2 = num;
			num = (short)202118513;
			short num3 = num;
			num = (short)367859057;
			switch (num3 == num)
			{
			}
			num = (short)2127888385;
			if (num != 0)
			{
			}
			num = (short)1325400064;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(delegateType, this, handler);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x000C15F0 File Offset: 0x000BF7F0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1186398208;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					goto IL_242;
				case 2:
					num = (short)1783693313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_342;
				case 2:
					goto IL_15C;
				case 3:
					goto IL_2AA;
				case 4:
					goto IL_114;
				case 5:
					goto IL_1C9;
				case 6:
					goto IL_26F;
				case 7:
					goto IL_2B7;
				case 8:
					goto IL_21E;
				case 9:
					goto IL_328;
				case 10:
					goto IL_2F5;
				case 11:
					goto IL_35A;
				case 12:
					goto IL_1BC;
				case 13:
					goto IL_107;
				case 14:
					goto IL_335;
				case 15:
					goto IL_2E8;
				case 16:
					goto IL_B1;
				case 17:
					goto IL_18B;
				case 18:
					goto IL_367;
				case 19:
					goto IL_2DB;
				case 20:
					goto IL_138;
				case 21:
					goto IL_1D6;
				case 22:
					goto IL_198;
				case 23:
					goto IL_1FA;
				default:
					num = (short)1879572482;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_B1:
			num = (short)1679837619;
			short num3 = num;
			num = (short)2054572467;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1BC:
				this.lblRadioID = (global::System.Windows.Controls.Label)target;
				return;
			default:
				num = (short)1556742144;
				if (num != 0)
				{
				}
				this.lblInactivityTimer = (global::System.Windows.Controls.Label)target;
				return;
			}
			IL_107:
			this.RadioID = (global::SpecialFeatures.Programming.UI.IPTextBox)target;
			return;
			IL_114:
			this.operationLabel = (global::System.Windows.Controls.Label)target;
			this.operationLabel.MouseDown += this.OTAPProgrammingWindow_MouseLeftButtonDown;
			return;
			IL_138:
			this.btnGetIPOnly = (global::System.Windows.Controls.Button)target;
			this.btnGetIPOnly.Click += this.btnGetIPOnly_Click;
			return;
			IL_15C:
			((global::System.Windows.Input.CommandBinding)target).Executed += new global::System.Windows.Input.ExecutedRoutedEventHandler(this.btnHelp_Click);
			((global::System.Windows.Input.CommandBinding)target).CanExecute += this.F1HelpCommandCanExcute;
			return;
			IL_18B:
			this.InactivityTimerTextbox = (global::SpecialFeatures.Programming.UI.IPTextBox)target;
			return;
			IL_198:
			this.btnCancel = (global::System.Windows.Controls.Button)target;
			this.btnCancel.Click += this.btnCancel_Click;
			return;
			IL_1C9:
			this.GrpbxOTAPParameters = (global::System.Windows.Controls.GroupBox)target;
			return;
			IL_1D6:
			this.btnOperation = (global::System.Windows.Controls.Button)target;
			this.btnOperation.Click += this.btnOperation_Click;
			return;
			IL_1FA:
			this.btnHelp = (global::System.Windows.Controls.Button)target;
			this.btnHelp.Click += this.btnHelp_Click;
			return;
			IL_21E:
			this.lbArsConnectionType = (global::System.Windows.Controls.Label)target;
			return;
			IL_242:
			num = (short)1261895680;
			short num4 = num;
			this.n = true;
			return;
			IL_26F:
			this.useRadioIDCheckBox = (global::System.Windows.Controls.CheckBox)target;
			this.useRadioIDCheckBox.Checked += this.useRadioIDCheckBox_Checked;
			this.useRadioIDCheckBox.Unchecked += this.useRadioIDCheckBox_Unchecked;
			return;
			IL_2AA:
			this.ProgrammingPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_2B7:
			this.autoRegServer = (global::System.Windows.Controls.ComboBox)target;
			this.autoRegServer.SelectionChanged += this.autoRegServer_SelectionChanged;
			return;
			IL_2DB:
			this.txtTimeElapsed = (global::System.Windows.Controls.TextBox)target;
			return;
			IL_2E8:
			this.RadioIPAddressTextBox = (global::SpecialFeatures.Programming.UI.SPF_UI_IPAddressV4_Control)target;
			return;
			IL_2F5:
			num = (short)1462894593;
			if (num != 0)
			{
			}
			this.lblTimeout = (global::System.Windows.Controls.Label)target;
			return;
			IL_328:
			this.txtboxConnectionType = (global::System.Windows.Controls.TextBox)target;
			return;
			IL_335:
			this.lblRadioIPOutput = (global::System.Windows.Controls.Label)target;
			return;
			IL_342:
			((global::SpecialFeatures.Programming.OTAPProgrammingWindow)target).Loaded += this.onOTAPProgrammingWindowLoaded;
			return;
			IL_35A:
			this.TimeOutTextbox = (global::SpecialFeatures.Programming.UI.IPTextBox)target;
			return;
			IL_367:
			this.lblTimeElapsed = (global::System.Windows.Controls.Label)target;
		}

		// Token: 0x04000404 RID: 1028
		private global::SpecialFeatures.Programming.ProgrammingOperation a;

		// Token: 0x04000405 RID: 1029
		private global::System.Windows.Threading.DispatcherTimer b;

		// Token: 0x04000406 RID: 1030
		private int c;

		// Token: 0x04000407 RID: 1031
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler d;

		// Token: 0x04000408 RID: 1032
		private bool e;

		// Token: 0x04000409 RID: 1033
		private bool f;

		// Token: 0x0400040A RID: 1034
		private global::SpecialFeatures.Programming.OTAPPrescenceResult g;

		// Token: 0x0400040B RID: 1035
		private global::SpecialFeatures.Programming.ARSGetIPAddressWorker h;

		// Token: 0x0400040C RID: 1036
		private global::SpecialFeatures.SpecialFeaturesSettings i;

		// Token: 0x0400040D RID: 1037
		private string j;

		// Token: 0x0400040E RID: 1038
		private global::SSLAdminTool.IDataStoreDecryptHandler k;

		// Token: 0x0400040F RID: 1039
		private global::System.Collections.Generic.List<global::SSLAdminTool.PNServer> l;

		// Token: 0x04000410 RID: 1040
		private global::SSLMangrComp.Packets.SubscriptionType m;

		// Token: 0x04000411 RID: 1041
		internal global::System.Windows.Controls.StackPanel ProgrammingPanel;

		// Token: 0x04000412 RID: 1042
		internal global::System.Windows.Controls.Label operationLabel;

		// Token: 0x04000413 RID: 1043
		internal global::System.Windows.Controls.GroupBox GrpbxOTAPParameters;

		// Token: 0x04000414 RID: 1044
		internal global::System.Windows.Controls.CheckBox useRadioIDCheckBox;

		// Token: 0x04000415 RID: 1045
		internal global::System.Windows.Controls.ComboBox autoRegServer;

		// Token: 0x04000416 RID: 1046
		internal global::System.Windows.Controls.Label lbArsConnectionType;

		// Token: 0x04000417 RID: 1047
		internal global::System.Windows.Controls.TextBox txtboxConnectionType;

		// Token: 0x04000418 RID: 1048
		internal global::System.Windows.Controls.Label lblTimeout;

		// Token: 0x04000419 RID: 1049
		internal global::SpecialFeatures.Programming.UI.IPTextBox TimeOutTextbox;

		// Token: 0x0400041A RID: 1050
		internal global::System.Windows.Controls.Label lblRadioID;

		// Token: 0x0400041B RID: 1051
		internal global::SpecialFeatures.Programming.UI.IPTextBox RadioID;

		// Token: 0x0400041C RID: 1052
		internal global::System.Windows.Controls.Label lblRadioIPOutput;

		// Token: 0x0400041D RID: 1053
		internal global::SpecialFeatures.Programming.UI.SPF_UI_IPAddressV4_Control RadioIPAddressTextBox;

		// Token: 0x0400041E RID: 1054
		internal global::System.Windows.Controls.Label lblInactivityTimer;

		// Token: 0x0400041F RID: 1055
		internal global::SpecialFeatures.Programming.UI.IPTextBox InactivityTimerTextbox;

		// Token: 0x04000420 RID: 1056
		internal global::System.Windows.Controls.Label lblTimeElapsed;

		// Token: 0x04000421 RID: 1057
		internal global::System.Windows.Controls.TextBox txtTimeElapsed;

		// Token: 0x04000422 RID: 1058
		internal global::System.Windows.Controls.Button btnGetIPOnly;

		// Token: 0x04000423 RID: 1059
		internal global::System.Windows.Controls.Button btnOperation;

		// Token: 0x04000424 RID: 1060
		internal global::System.Windows.Controls.Button btnCancel;

		// Token: 0x04000425 RID: 1061
		internal global::System.Windows.Controls.Button btnHelp;

		// Token: 0x04000426 RID: 1062
		private bool n;
	}
}
