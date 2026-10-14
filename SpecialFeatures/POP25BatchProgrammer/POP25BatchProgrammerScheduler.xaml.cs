using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using System.Xml.Serialization;
using AcpASKLib;
using ACPBrowser;
using AcpCommonLib;
using AcpSecurityLib;
using AcpUI.Common;
using AcpUtility;
using CommonResources;
using DevComponents.WpfEditors;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Clone_Configuration.Common;
using SSLAdminTool;
using SSLMangrComp;

namespace SpecialFeatures.POP25BatchProgrammer
{
	// Token: 0x020000A3 RID: 163
	public partial class POP25BatchProgrammerScheduler : Window, INotifyPropertyChanged
	{
		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x000D5C6C File Offset: 0x000D3E6C
		public List<PNServer> ARS_DataSource
		{
			get
			{
				short num = (short)1453314869;
				short num2 = num;
				num = (short)565105461;
				switch (num2 == num)
				{
				}
				num = (short)670367745;
				if (num != 0)
				{
				}
				num = (short)537395200;
				if (num != 0)
				{
				}
				num = (short)876150784;
				short num3 = num;
				return this.j;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x000D5D1C File Offset: 0x000D3F1C
		public ObservableCollection<POP25RadioInfo> DataSource
		{
			get
			{
				short num = (short)1151579832;
				short num2 = num;
				num = (short)1058059960;
				switch (num2 == num)
				{
				}
				num = (short)351404033;
				if (num != 0)
				{
				}
				num = (short)878444544;
				if (num != 0)
				{
				}
				num = (short)846200832;
				short num3 = num;
				return this.l;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x000D5DCC File Offset: 0x000D3FCC
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x000D5E7C File Offset: 0x000D407C
		public string ArsIpAddress
		{
			get
			{
				short num = (short)679604519;
				short num2 = num;
				num = (short)502067495;
				switch (num2 == num)
				{
				}
				num = (short)1270677504;
				if (num != 0)
				{
				}
				num = (short)291700737;
				if (num != 0)
				{
				}
				num = (short)1365508096;
				short num3 = num;
				return this.g;
			}
			set
			{
				short num = (short)352124261;
				short num2 = num;
				num = (short)597818725;
				switch (num2 == num)
				{
				}
				num = (short)455081985;
				if (num != 0)
				{
				}
				num = (short)1659895808;
				if (num != 0)
				{
				}
				num = (short)1565261824;
				short num3 = num;
				this.g = value;
			}
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x000D5F2C File Offset: 0x000D412C
		public POP25BatchProgrammerScheduler()
		{
			int a_ = 9;
			this.c = "";
			this.d = new SpecialFeaturesSettings();
			this.f = string.Empty;
			this.g = string.Empty;
			this.i = new DataStoreDecryptHandler(112, 2048);
			this.j = new List<PNServer>();
			this.k = new XmlSerializer(typeof(RadioList));
			this.l = new RadioList();
			base..ctor();
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
			this.chkboxStaticIpAddress.IsChecked = new bool?(false);
			this.chkboxWriteProtect.IsChecked = new bool?(false);
			this.autoRegServer.IsEnabled = false;
			this.txtbxNumRetries.Text = RptMgrErrorHandler.b("뺋", a_);
			this.txtboxRadioListFilePath.Text = this.e();
			this.b(this.c);
			this.a = new TimeSpan(0, 0, 0, 0, 0);
			this.CancelBatchSchedule = false;
			this.e = SecurityManager.GetSysKeysFromLoadedAndAttachedASKs();
			this.h = new byte[0];
			try
			{
				if (this.i.XStoreAvailable)
				{
					new List<PNServer>();
					foreach (PNServer pnserver in this.i.XStoreRead())
					{
						if (pnserver.RecType == RecordType.UNS)
						{
							this.j.Add(pnserver);
						}
					}
				}
				else
				{
					System.Windows.MessageBox.Show(AppResources.The_ARS_XML_file_is_not_available, AppResources.ARS_XML_File_Not_Found, MessageBoxButton.OK, MessageBoxImage.Exclamation);
				}
				goto IL_118;
			}
			catch (Exception)
			{
				System.Windows.MessageBox.Show(AppResources.There_was_problem_loading_ARS_XML_file, AppResources.ARS_XML_File_Not_Found, MessageBoxButton.OK, MessageBoxImage.Exclamation);
				goto IL_118;
			}
			goto IL_200;
			IL_118:
			base.DataContext = this;
			this.autoRegServer.ItemsSource = this.ARS_DataSource;
			this.c();
			if (!Thread.CurrentThread.CurrentCulture.Name.ToLower().StartsWith(RptMgrErrorHandler.b("ﲍ", a_)))
			{
				return;
			}
			IL_200:
			this.txtboxRadioListFilePath.FlowDirection = System.Windows.FlowDirection.LeftToRight;
			this.txtboxRadioListFilePath.TextAlignment = TextAlignment.Right;
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x000D6170 File Offset: 0x000D4370
		private void SchedulerWindow_Loaded(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1447559168;
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
				bool? isChecked;
				bool flag;
				string empty;
				for (;;)
				{
					IL_28:
					IEnumerator<SystemKeyData> enumerator;
					IEnumerator enumerator2;
					switch (num2)
					{
					case 0:
						this.autoRegServer.IsEnabled = true;
						num = (short)842006529;
						if (num != 0)
						{
						}
						num = (short)500498441;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						goto IL_36D;
					case 2:
						if (this.e != null)
						{
							num = (short)16252936;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_C7;
					case 3:
						goto IL_348;
					case 4:
						if (isChecked.GetValueOrDefault() == flag & isChecked != null)
						{
							num = (short)1798176768;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_F6;
					case 5:
						try
						{
							num = (short)1731854337;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)1906311174;
										num2 = (int)((IntPtr)num);
										continue;
									}
									num = (short)565379075;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3B5;
									}
									continue;
								case 2:
									this.chkboxWriteProtect.IsEnabled = true;
									num = (short)1756561413;
									num2 = (int)((IntPtr)num);
									continue;
								case 3:
									if (enumerator.Current.WriteProtectEnabled)
									{
										num = (short)168165378;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								case 4:
									goto IL_472;
								case 5:
									goto IL_416;
								case 6:
									num = (short)1152778244;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_41B:
								num = (short)81985536;
								num2 = (int)((IntPtr)num);
								continue;
								IL_3B5:
								goto IL_41B;
							}
							IL_416:
							IL_472:
							goto IL_C7;
						}
						finally
						{
							num = (short)1829699584;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)587575461;
									short num3 = num;
									num = (short)662352037;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_52B;
									default:
										num = (short)1256194048;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_4F4;
										}
										continue;
									}
									break;
								}
								case 1:
									enumerator.Dispose();
									num = (short)371261442;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									goto IL_52B;
								}
								IL_4F4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1925251073;
								num2 = (int)((IntPtr)num);
							}
							IL_52B:;
						}
						goto IL_52E;
					case 6:
						try
						{
							num = (short)488898561;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									PNServer pnserver;
									this.a(pnserver, ref empty);
									num = (short)1715863558;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_20F;
									}
									continue;
								case 2:
									num = (short)28901380;
									num2 = (int)((IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)377487362;
										num2 = (int)((IntPtr)num);
										continue;
									}
									PNServer pnserver = (PNServer)enumerator2.Current;
									num = (short)463011845;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 4:
									goto IL_2CE;
								case 5:
								{
									PNServer pnserver;
									if (pnserver.SecureConn)
									{
										num = (short)312410112;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_211:
								num = (short)1811742723;
								num2 = (int)((IntPtr)num);
								continue;
								IL_20F:
								goto IL_211;
							}
							IL_2CE:
							goto IL_134;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2F0;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_2DD:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)791216129;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_347;
								case 1:
									disposable.Dispose();
									num = (short)1382023170;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									goto IL_345;
								}
								goto IL_2F0;
							}
							IL_345:
							IL_347:
							goto EndFinally_14;
							IL_2F0:
							disposable = (enumerator2 as IDisposable);
							num = (short)1640038400;
							num2 = (int)((IntPtr)num);
							goto IL_2DD;
							EndFinally_14:;
						}
						goto IL_348;
						IL_134:
						num = (short)230031367;
						num2 = (int)((IntPtr)num);
						continue;
					case 7:
						if (empty != string.Empty)
						{
							num = (short)160694275;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_580;
					case 8:
						goto IL_52E;
					case 9:
						goto IL_F6;
					}
					goto IL_57;
					IL_C7:
					enumerator2 = this.autoRegServer.ItemsSource.GetEnumerator();
					num = (short)775815174;
					num2 = (int)((IntPtr)num);
					continue;
					IL_F6:
					num = (short)178192386;
					num2 = (int)((IntPtr)num);
					continue;
					IL_348:
					System.Windows.MessageBox.Show(this, empty, AppResources.Certificate_Warning);
					num = (short)1008009217;
					num2 = (int)((IntPtr)num);
					continue;
					IL_52E:
					num = (short)617414656;
					short num4 = num;
					enumerator = this.e.GetEnumerator();
					num = (short)84279301;
					num2 = (int)((IntPtr)num);
				}
				IL_36D:
				IL_580:
				this.a();
				return;
				IL_57:
				this.dtSchedulerDateTime.Value = new DateTime?(DateTime.Now);
				empty = string.Empty;
				isChecked = this.chkboxStaticIpAddress.IsChecked;
				flag = true;
				num = (short)1936850948;
				num2 = (int)((IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x000D6738 File Offset: 0x000D4938
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x000D67EC File Offset: 0x000D49EC
		internal string NumRetriePerFailedRadios
		{
			get
			{
				short num = (short)270467073;
				if (num != 0)
				{
				}
				num = (short)2099407545;
				short num2 = num;
				num = (short)280193721;
				switch (num2 == num)
				{
				}
				num = (short)2043412480;
				if (num != 0)
				{
				}
				num = (short)1426325504;
				short num3 = num;
				return this.txtbxNumRetries.Text;
			}
			set
			{
				short num = (short)823298693;
				short num2 = num;
				num = (short)163023493;
				switch (num2 == num)
				{
				}
				num = (short)493223936;
				if (num != 0)
				{
				}
				num = (short)2135752705;
				if (num != 0)
				{
				}
				num = (short)794230784;
				short num3 = num;
				this.txtbxNumRetries.Text = value;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x000D68A4 File Offset: 0x000D4AA4
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x000D6960 File Offset: 0x000D4B60
		internal bool WriteProtectRadios
		{
			get
			{
				short num = (short)1712563582;
				short num2 = num;
				num = (short)1154196862;
				switch (num2 == num)
				{
				}
				num = (short)884342785;
				if (num != 0)
				{
				}
				num = (short)1700528128;
				if (num != 0)
				{
				}
				num = (short)1023672320;
				short num3 = num;
				return this.chkboxWriteProtect.IsChecked.Value;
			}
			set
			{
				short num = (short)1857006016;
				short num2 = num;
				num = (short)892053952;
				switch (num2 == num)
				{
				}
				num = (short)915800065;
				if (num != 0)
				{
				}
				num = (short)1214578688;
				if (num != 0)
				{
				}
				num = (short)363855872;
				short num3 = num;
				this.chkboxWriteProtect.IsChecked = new bool?(value);
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x000D6AC8 File Offset: 0x000D4CC8
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x000D6A18 File Offset: 0x000D4C18
		internal bool CancelBatchSchedule
		{
			[CompilerGenerated]
			get
			{
				short num = (short)185470763;
				short num2 = num;
				num = (short)1664421675;
				switch (num2 == num)
				{
				}
				num = (short)671350785;
				if (num != 0)
				{
				}
				num = (short)738131968;
				if (num != 0)
				{
				}
				num = (short)394919936;
				short num3 = num;
				return this.m;
			}
			[CompilerGenerated]
			set
			{
				short num = (short)1788029675;
				short num2 = num;
				num = (short)1452485355;
				switch (num2 == num)
				{
				}
				num = (short)910426113;
				if (num != 0)
				{
				}
				num = (short)2055995392;
				if (num != 0)
				{
				}
				num = (short)1191051264;
				short num3 = num;
				this.m = value;
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000B3C RID: 2876 RVA: 0x000D6B74 File Offset: 0x000D4D74
		// (remove) Token: 0x06000B3D RID: 2877 RVA: 0x000D6CAC File Offset: 0x000D4EAC
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				PropertyChangedEventHandler propertyChangedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_B2;
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1916665858;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_B2;
					case 2:
						goto IL_129;
					}
					goto IL_1C;
					IL_B2:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.n, value2, propertyChangedEventHandler2);
					num2 = (short)2069495809;
					if (num2 != 0)
					{
					}
					num2 = (short)2122842113;
					num = (int)((IntPtr)num2);
				}
				IL_129:
				return;
				IL_1C:
				propertyChangedEventHandler = this.n;
				num2 = (short)726243828;
				short num3 = num2;
				num2 = (short)981768692;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num2 = (short)2146107392;
					if (num2 != 0)
					{
					}
					num2 = (short)2017525760;
					short num4 = num2;
					num2 = (short)519372800;
					int num = (int)((IntPtr)num2);
					goto IL_0A;
				}
				}
			}
			[CompilerGenerated]
			remove
			{
				short num = (short)870842369;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_31:
					int num2;
					PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num2)
					{
					case 0:
						goto IL_DA;
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num = (short)1076297730;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_DA;
					case 2:
						goto IL_12A;
					}
					goto IL_43;
					IL_DA:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.n, value2, propertyChangedEventHandler2);
					num = (short)1438253057;
					num2 = (int)((IntPtr)num);
				}
				IL_12A:
				return;
				IL_43:
				propertyChangedEventHandler = this.n;
				num = (short)2075656192;
				short num3 = num;
				num = (short)1612131796;
				short num4 = num;
				num = (short)445853140;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)109903872;
					if (num != 0)
					{
					}
					num = (short)752484352;
					int num2 = (int)((IntPtr)num);
					goto IL_31;
				}
				}
			}
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x000D6DE8 File Offset: 0x000D4FE8
		public void FireDataSourcePropertyChanged(string name)
		{
			short num = (short)2019491842;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.n(this, new PropertyChangedEventArgs(name));
					goto IL_8A;
				case 1:
				{
					num = (short)1701760025;
					short num3 = num;
					num = (short)930794521;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8A;
					default:
						goto IL_D7;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				num = (short)1847721985;
				if (num != 0)
				{
				}
				if (this.n != null)
				{
					num = (short)1070989312;
					num2 = (int)((IntPtr)num);
					continue;
				}
				return;
				IL_8A:
				num = (short)1365966849;
				num2 = (int)((IntPtr)num);
			}
			IL_D7:
			num = (short)1613955072;
			if (num != 0)
			{
			}
			num = (short)225574912;
			short num4 = num;
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x000D6F10 File Offset: 0x000D5110
		private string e()
		{
			int a_ = 13;
			short num = (short)1676476421;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.c = AppResources.Please_Select_A_Radio_List_Location;
					num = (short)615055362;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_1C2;
				case 2:
					goto IL_10B;
				case 3:
					if (!File.Exists(this.c))
					{
						num = (short)1074331648;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1C4;
				case 4:
				{
					num = (short)1371600602;
					short num3 = num;
					num = (short)282261210;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_130;
					default:
					{
						num = (short)2063007745;
						if (num != 0)
						{
						}
						num = (short)1767440384;
						if (num != 0)
						{
						}
						num = (short)617283584;
						short num4 = num;
						this.c = this.d.OTAP_BATCH_RADIO_LIST_LOCATION;
						num = (short)1803550721;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				}
				IL_46:
				if (File.Exists(this.d.OTAP_BATCH_RADIO_LIST_LOCATION))
				{
					num = (short)1061289988;
					num2 = (int)((IntPtr)num);
					continue;
				}
				this.c = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), RptMgrErrorHandler.b("\udd8f﶑秊ﾝﲟ풣\udea5쮩솫잭\udcaf쮱ﾻ톽궿꿁ꯃꣅ铇裉귋뫍돏뫑裓蓕맗뻙뗛뇝뿟껡跣闥鳧쓩铫菭鳯", a_));
				IL_130:
				num = (short)654966787;
				num2 = (int)((IntPtr)num);
			}
			IL_10B:
			IL_1C2:
			IL_1C4:
			return this.c;
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x000D70E8 File Offset: 0x000D52E8
		private void btnRadioListFilePathBrowse_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 1;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = this.c;
			openFileDialog.DefaultExt = RptMgrErrorHandler.b("ﲃ", a_);
			openFileDialog.Filter = AppResources.XML_Document_Filter;
			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				short num;
				for (;;)
				{
					num = (short)52101121;
					if (num != 0)
					{
					}
					num = (short)1944128170;
					short num2 = num;
					num = (short)24775338;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_A4;
					}
				}
				IL_A4:
				num = (short)630849536;
				short num3 = num;
				num = (short)1711734784;
				if (num != 0)
				{
				}
				this.txtboxRadioListFilePath.Text = openFileDialog.FileName;
				this.b(this.txtboxRadioListFilePath.Text);
				return;
			}
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x000D71FC File Offset: 0x000D53FC
		private void b(string A_0)
		{
			int a_ = 12;
			short num;
			try
			{
				num = (short)285868033;
				if (num != 0)
				{
				}
				FileStream fileStream = new FileStream(A_0, FileMode.Open, FileAccess.Read, FileShare.Read);
				this.l = (RadioList)this.k.Deserialize(fileStream);
				this.FireDataSourcePropertyChanged(RptMgrErrorHandler.b("쮎쒖ﲞ쒠", a_));
				fileStream.Close();
			}
			catch
			{
				if (!File.Exists(this.c))
				{
					num = (short)1541025527;
					short num2 = num;
					num = (short)78130935;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)202113024;
						if (num != 0)
						{
						}
						goto IL_E2;
					}
				}
				System.Windows.MessageBox.Show(AppResources.Please_Select_A_Valid_XML_File, AppResources.Invalid_XML_File, MessageBoxButton.OK, MessageBoxImage.Exclamation);
			}
			IL_E2:
			num = (short)2092761088;
			short num3 = num;
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x000D7328 File Offset: 0x000D5528
		private void d()
		{
			int num;
			short num2;
			bool? isChecked;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.j.Count > 0)
						{
							num2 = (short)463273987;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_1B5;
					case 1:
						num2 = (short)1029570560;
						num = (int)((IntPtr)num2);
						continue;
					case 2:
						goto IL_174;
					case 3:
						this.d.OTAP_ARS_IP_ADDRESS = ((PNServer)this.autoRegServer.SelectedItem).PNSName;
						num2 = (short)237502466;
						num = (int)((IntPtr)num2);
						continue;
					case 4:
					{
						num2 = (short)1025406028;
						short num3 = num2;
						num2 = (short)1732408396;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8B;
						case 1:
							break;
						default:
						{
							num2 = (short)394133504;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)336986112;
						if (num2 != 0)
						{
						}
						if (isChecked.Value)
						{
							num2 = (short)279642113;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_1B5;
					}
					}
					goto IL_24;
				}
				IL_174:
				IL_1B5:
				this.d.OTAP_BATCH_NUM_RETRIES_FOR_FAILED_RADIOS = this.txtbxNumRetries.Text;
				this.d.Save();
				return;
			}
			IL_24:
			num2 = (short)424083457;
			if (num2 != 0)
			{
			}
			this.d.OTAP_BATCH_RADIO_LIST_LOCATION = this.txtboxRadioListFilePath.Text;
			SpecialFeaturesSettings specialFeaturesSettings = this.d;
			isChecked = this.chkboxStaticIpAddress.IsChecked;
			specialFeaturesSettings.OTAP_BATCH_ENABLE_ARS_SERVER_IP_ADDRESS = isChecked.Value;
			isChecked = this.chkboxStaticIpAddress.IsChecked;
			IL_8B:
			num2 = (short)938344452;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x000D750C File Offset: 0x000D570C
		private void c()
		{
			short num2;
			try
			{
				this.chkboxStaticIpAddress.IsChecked = new bool?(this.d.OTAP_BATCH_ENABLE_ARS_SERVER_IP_ADDRESS);
				int num = -1;
				IEnumerator enumerator = ((IEnumerable)this.autoRegServer.Items).GetEnumerator();
				try
				{
					num2 = (short)1441660933;
					int num3 = (int)((IntPtr)num2);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_F9;
						case 1:
							goto IL_159;
						case 3:
							if (!enumerator.MoveNext())
							{
								num2 = (short)848560128;
								num3 = (int)((IntPtr)num2);
								continue;
							}
							num2 = (short)15859716;
							num3 = (int)((IntPtr)num2);
							continue;
						case 4:
						{
							PNServer pnserver = (PNServer)enumerator.Current;
							num++;
							if (!pnserver.PNSName.Equals(this.d.OTAP_ARS_IP_ADDRESS))
							{
								num2 = (short)1480458242;
								num3 = (int)((IntPtr)num2);
								continue;
							}
							goto IL_F9;
						}
						case 5:
							switch (0)
							{
							case 0:
								goto IL_6D;
							}
							continue;
						}
						IL_C0:
						num2 = (short)972750851;
						num3 = (int)((IntPtr)num2);
						continue;
						IL_6D:
						goto IL_C0;
						IL_F9:
						num2 = (short)1084486048;
						short num4 = num2;
						num2 = (short)2083058080;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6D;
						default:
							num2 = (short)632619008;
							if (num2 != 0)
							{
							}
							num2 = (short)1507000321;
							num3 = (int)((IntPtr)num2);
							break;
						}
					}
					IL_159:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_177;
					}
					int num3;
					IDisposable disposable;
					for (;;)
					{
						IL_165:
						switch (num3)
						{
						case 0:
							disposable.Dispose();
							num2 = (short)1551106049;
							num3 = (int)((IntPtr)num2);
							continue;
						case 1:
							goto IL_1C8;
						case 2:
							if (disposable != null)
							{
								num2 = (short)907870208;
								num3 = (int)((IntPtr)num2);
								continue;
							}
							goto IL_1CA;
						}
						goto IL_177;
					}
					IL_1C8:
					IL_1CA:
					goto EndFinally_8;
					IL_177:
					disposable = (enumerator as IDisposable);
					num2 = (short)1056899074;
					num3 = (int)((IntPtr)num2);
					goto IL_165;
					EndFinally_8:;
				}
				this.autoRegServer.SelectedIndex = num;
				this.txtbxNumRetries.Text = this.d.OTAP_BATCH_NUM_RETRIES_FOR_FAILED_RADIOS;
			}
			catch (Exception)
			{
			}
			num2 = (short)1847656449;
			if (num2 != 0)
			{
			}
			num2 = (short)1539768320;
			short num5 = num2;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x000D7790 File Offset: 0x000D5990
		private void btnStart_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 17;
			short num = (short)576192513;
			if (num != 0)
			{
			}
			num = (short)1611530240;
			switch (num)
			{
			default:
			{
				num = (short)811335708;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					bool? isChecked;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)903610372;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1605238792;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									goto IL_38B;
								case 2:
									this.WriteProtectRadios = true;
									num = (short)2045575169;
									num2 = (int)((IntPtr)num);
									continue;
								case 3:
								{
									IEnumerator<SystemKeyData> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)347144197;
										num2 = (int)((IntPtr)num);
										continue;
									}
									num = (short)540803078;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_24D;
									}
									continue;
								case 5:
									goto IL_390;
								case 6:
								{
									IEnumerator<SystemKeyData> enumerator;
									if (enumerator.Current.WriteProtectEnabled)
									{
										num = (short)288620544;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									goto IL_3A9;
								case 8:
								{
									num = (short)504134291;
									short num3 = num;
									num = (short)946174611;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1773142016;
										if (num != 0)
										{
										}
										if (System.Windows.MessageBox.Show(AppResources.Warning_One_Or_More_WPEd_Advanced_Key_Loaded, AppResources.Radio_Write_Protect_Warning, MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
										{
											num = (short)406847490;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_390;
									}
									break;
								}
								}
								IL_2E9:
								num = (short)616366083;
								num2 = (int)((IntPtr)num);
								continue;
								IL_24D:
								goto IL_2E9;
								IL_390:
								num = (short)1954480135;
								num2 = (int)((IntPtr)num);
							}
							IL_38B:
							IL_3A9:
							goto IL_4E3;
						}
						finally
						{
							num = (short)1525415938;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								IEnumerator<SystemKeyData> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1101594625;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									goto IL_417;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3E0;
									}
									continue;
								}
								IL_3E0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1388183552;
								num2 = (int)((IntPtr)num);
							}
							IL_417:;
						}
						goto IL_41A;
					case 1:
						if (!WiFiPasswordUtil.OpenValidateDlg(this))
						{
							num = (short)1200881677;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_982;
					case 2:
						num = (short)635371556;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						num = (short)2036858887;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
					{
						string empty;
						if (empty != string.Empty)
						{
							num = (short)1002700835;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					case 5:
					{
						string folderPath;
						string str;
						if (File.Exists(folderPath + str))
						{
							num = (short)198574090;
							num2 = (int)((IntPtr)num);
							continue;
						}
						bool flag = false;
						System.Windows.MessageBox.Show(AppResources.There_was_a_problem_with_reading_the_Diffy_Helman_Key_files_installed);
						num = (short)513867784;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 6:
					{
						string str = RptMgrErrorHandler.b("좓\udb95쾟캡얣瘟ﾫ톯욱햳\udcb7ힹ햻킽鲿迁ꯃ닅Ꟈ룉ꏋꋍ뇏郓돕뻗믙꧛닝铟싡꟣菥髧黩藫裭駯釱闳苵鷷꛹飻雽烿持瘃朅攇␉簋欍紏", a_);
						string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
						num = (short)1599209477;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 7:
					{
						string empty;
						if (this.a((PNServer)this.autoRegServer.SelectedItem, ref empty))
						{
							num = (short)302514210;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_13D;
					}
					case 8:
						goto IL_180;
					case 9:
						isChecked = this.chkboxStaticIpAddress.IsChecked;
						num = (short)1222967319;
						num2 = (int)((IntPtr)num);
						continue;
					case 10:
						try
						{
							string folderPath;
							string str;
							FileStream fileStream = new FileStream(folderPath + str, FileMode.Open, FileAccess.Read);
							this.h = new byte[fileStream.Length];
							fileStream.Read(this.h, 0, (int)fileStream.Length);
							fileStream.Close();
							goto IL_180;
						}
						catch
						{
							bool flag = false;
							System.Windows.MessageBox.Show(AppResources.There_was_a_problem_with_reading_the_Diffy_Helman_Key_file_valid);
							goto IL_180;
						}
						goto IL_78E;
					case 11:
						if (!this.WriteProtectRadios)
						{
							num = (short)458948632;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_4E3;
					case 12:
						goto IL_92A;
					case 13:
						goto IL_524;
					case 14:
						if (!this.a(this.g))
						{
							num = (short)256639013;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_64B;
					case 15:
					{
						DateTime? value = this.dtSchedulerDateTime.Value;
						num = (short)579862555;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 16:
						if (System.Windows.MessageBox.Show(AppResources.Warning_The_ARS_IP_Address_is_invalid, AppResources.Invalid_ARS_Server_IP_Address_Warning, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
						{
							num = (short)1757675542;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_64B;
					case 17:
						if (this.j.Count > 0)
						{
							num = (short)447414281;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_13D;
					case 18:
						if (isChecked.Value)
						{
							num = (short)980025369;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_64B;
					case 19:
					{
						bool flag = true;
						DateTime? value = this.dtSchedulerDateTime.Value;
						DateTime value2 = value.Value;
						string empty = string.Empty;
						isChecked = this.chkboxStaticIpAddress.IsChecked;
						num = (short)944570397;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 20:
						if (((PNServer)this.autoRegServer.SelectedItem).SecureConn)
						{
							num = (short)2061172742;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_13D;
					case 21:
						if (System.Windows.MessageBox.Show(AppResources.Warning_There_is_no_ARS_selected, AppResources.Invalid_ARS_Warning, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
						{
							num = (short)1274740766;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_5FF;
					case 22:
						return;
					case 23:
						if (isChecked.Value)
						{
							num = (short)1570308129;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_13D;
					case 24:
						num = (short)635633695;
						num2 = (int)((IntPtr)num);
						continue;
					case 25:
						num = (short)349110286;
						num2 = (int)((IntPtr)num);
						continue;
					case 26:
						goto IL_41A;
					case 27:
					{
						DateTime? value;
						if (value != null)
						{
							num = (short)1460994067;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_553;
					}
					case 28:
						switch (0)
						{
						case 0:
							goto IL_110;
						}
						continue;
					case 29:
						if (isChecked.Value)
						{
							num = (short)883163138;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_5FF;
					case 30:
						return;
					case 31:
						if (this.e != null)
						{
							num = (short)1110376480;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_4E3;
					case 32:
					{
						IEnumerator<SystemKeyData> enumerator = this.e.GetEnumerator();
						num = (short)1408303104;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 33:
						num = (short)1125253140;
						num2 = (int)((IntPtr)num);
						continue;
					case 34:
						goto IL_78E;
					case 35:
					{
						string empty;
						System.Windows.MessageBox.Show(this, empty, AppResources.Certificate_Warning);
						num = (short)691470348;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 36:
						if (this.autoRegServer.Items.Count <= 0)
						{
							num = (short)446562330;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_5FF;
					case 37:
						num = (short)851050512;
						num2 = (int)((IntPtr)num);
						continue;
					case 38:
					{
						bool flag;
						if (flag)
						{
							num = (short)1155858435;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_78E;
					}
					}
					IL_110:
					if (this.dgSelectedRadios.HasItems)
					{
						num = (short)546045967;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_A6F;
					IL_13D:
					num = (short)200015883;
					num2 = (int)((IntPtr)num);
					continue;
					IL_180:
					num = (short)1153499174;
					num2 = (int)((IntPtr)num);
					continue;
					IL_41A:
					num = (short)1589968917;
					num2 = (int)((IntPtr)num);
					continue;
					IL_4E3:
					this.d();
					num = (short)1429209089;
					num2 = (int)((IntPtr)num);
					continue;
					IL_5FF:
					isChecked = this.chkboxStaticIpAddress.IsChecked;
					num = (short)862322706;
					num2 = (int)((IntPtr)num);
					continue;
					IL_64B:
					num = (short)804257809;
					num2 = (int)((IntPtr)num);
					continue;
					IL_78E:
					num = (short)1035206660;
					num2 = (int)((IntPtr)num);
				}
				return;
				IL_524:
				num = (short)922025984;
				short num4 = num;
				return;
				IL_553:
				System.Windows.MessageBox.Show(AppResources.Please_Select_A_Time_To_Start_Batch_Programming);
				return;
				IL_92A:
				return;
				IL_982:
				this.dtSchedulerDateTime.IsEnabled = false;
				this.btnStart.IsEnabled = false;
				this.txtboxRadioListFilePath.IsEnabled = false;
				this.btnRadioListFilePathBrowse.IsEnabled = false;
				this.chkboxStaticIpAddress.IsEnabled = false;
				this.autoRegServer.IsEnabled = false;
				this.btnAdd.IsEnabled = false;
				this.btnAddAll.IsEnabled = false;
				this.btnRemove.IsEnabled = false;
				this.btnRemoveAll.IsEnabled = false;
				this.txtbxNumRetries.IsEnabled = false;
				this.chkboxWriteProtect.IsEnabled = false;
				this.b = new DispatcherTimer();
				this.a = TimeSpan.FromMilliseconds(5000.0);
				this.b.Interval = this.a;
				this.b.Tick += this.batchTimer_Tick;
				this.b.Start();
				AppInfoManager.StatusMsgReport.Clear();
				return;
				IL_A6F:
				System.Windows.MessageBox.Show(AppResources.No_Radios_Have_Been_Selected_For_Programming);
				return;
			}
			}
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x000D824C File Offset: 0x000D644C
		private void batchTimer_Tick(object A_0, EventArgs A_1)
		{
			int a_ = 19;
			short num = (short)1407975424;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)402784258;
				num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						POP25BatchProgrammerProgress pop25BatchProgrammerProgress;
						try
						{
							num = (short)515571714;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)592904195;
										num2 = (int)((IntPtr)num);
										continue;
									}
									POP25RadioInfo pop25RadioInfo = (POP25RadioInfo)enumerator.Current;
									int num3;
									num3++;
									POP25RadioInfo pop25RadioInfo2 = new POP25RadioInfo();
									pop25RadioInfo2.Radio_ID = pop25RadioInfo.Radio_ID;
									pop25RadioInfo2.Radio_IP = pop25RadioInfo.Radio_IP;
									pop25RadioInfo2.Status = "";
									pop25BatchProgrammerProgress.dgBatchProgrammingProgress.Items.Add(pop25RadioInfo2);
									pop25RadioInfo2.IndexInList = num3;
									num = (short)1776812032;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3B7;
									}
									continue;
								case 3:
									num = (short)129695748;
									num2 = (int)((IntPtr)num);
									continue;
								case 4:
									goto IL_48A;
								}
								IL_3B9:
								num = (short)1827340289;
								num2 = (int)((IntPtr)num);
								continue;
								IL_3B7:
								goto IL_3B9;
							}
							IL_48A:
							goto IL_1D6;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_4AC;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_499:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1779236865;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_505;
								case 1:
									disposable.Dispose();
									num = (short)321454082;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									goto IL_503;
								}
								goto IL_4AC;
							}
							IL_503:
							IL_505:
							goto EndFinally_7;
							IL_4AC:
							IEnumerator enumerator;
							disposable = (enumerator as IDisposable);
							num = (short)409075712;
							num2 = (int)((IntPtr)num);
							goto IL_499;
							EndFinally_7:;
						}
						return;
						IL_1D6:
						pop25BatchProgrammerProgress.Show();
						pop25BatchProgrammerProgress.Focus();
						pop25BatchProgrammerProgress.Hide();
						pop25BatchProgrammerProgress.ShowDialog();
						this.btnStart.IsEnabled = true;
						this.dtSchedulerDateTime.IsEnabled = true;
						this.txtboxRadioListFilePath.IsEnabled = true;
						this.btnRadioListFilePathBrowse.IsEnabled = true;
						this.chkboxStaticIpAddress.IsEnabled = true;
						this.autoRegServer.IsEnabled = this.d.OTAP_BATCH_ENABLE_ARS_SERVER_IP_ADDRESS;
						this.btnAdd.IsEnabled = true;
						this.btnAddAll.IsEnabled = true;
						this.btnRemove.IsEnabled = true;
						this.btnRemoveAll.IsEnabled = true;
						this.txtbxNumRetries.IsEnabled = true;
						this.chkboxWriteProtect.IsEnabled = true;
						num = (short)690880512;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_6F;
						}
						continue;
					case 3:
						if (!this.CancelBatchSchedule)
						{
							num = (short)708247558;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 4:
					{
						DateTime value;
						DateTime now;
						if (value.CompareTo(now) <= 0)
						{
							goto IL_35E;
						}
						return;
					}
					case 5:
						num = (short)520945667;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
					{
						num = (short)1379860480;
						short num4 = num;
						DateTime value = this.dtSchedulerDateTime.Value.Value;
						DateTime now = DateTime.Now;
						num = (short)615253901;
						short num5 = num;
						num = (short)1474430861;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_35E;
						default:
							num = (short)1363083264;
							if (num != 0)
							{
							}
							num = (short)1158676484;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
					{
						num = (short)1640169473;
						if (num != 0)
						{
						}
						this.b.Stop();
						POP25BatchProgrammerProgress pop25BatchProgrammerProgress = new POP25BatchProgrammerProgress();
						DateTime value;
						pop25BatchProgrammerProgress.dtProgressDateTime.Text = value.ToString(RptMgrErrorHandler.b("톕", a_), Thread.CurrentThread.CurrentCulture);
						pop25BatchProgrammerProgress.ARSServerEnabled = this.chkboxStaticIpAddress.IsChecked.Value;
						pop25BatchProgrammerProgress.txtboxArsServer.Text = this.f;
						pop25BatchProgrammerProgress.txtbxRetryCount.Text = this.NumRetriePerFailedRadios;
						pop25BatchProgrammerProgress.WriteProtectWriteProtectedRad = this.WriteProtectRadios;
						pop25BatchProgrammerProgress.TargetARS = (PNServer)this.autoRegServer.SelectedItem;
						pop25BatchProgrammerProgress.DhBuff = this.h;
						int num3 = -1;
						IEnumerator enumerator = ((IEnumerable)this.dgSelectedRadios.Items).GetEnumerator();
						num = (short)1123942401;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					IL_6F:
					if (this.b != null)
					{
						num = (short)1285095429;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
					IL_35E:
					num = (short)488636423;
					num2 = (int)((IntPtr)num);
				}
				return;
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x000D877C File Offset: 0x000D697C
		private void EnableArsServer_Checked(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)708202277;
			short num2 = num;
			num = (short)1714966309;
			switch (num2 == num)
			{
			}
			num = (short)1503199233;
			if (num != 0)
			{
			}
			num = (short)1054605312;
			short num3 = num;
			num = (short)1058865152;
			if (num != 0)
			{
			}
			this.d.OTAP_BATCH_ENABLE_ARS_SERVER_IP_ADDRESS = true;
			this.autoRegServer.IsEnabled = true;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x000D883C File Offset: 0x000D6A3C
		private void EnableArsServer_UnChecked(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1720980990;
			short num2 = num;
			num = (short)1581979134;
			switch (num2 == num)
			{
			}
			num = (short)1390018561;
			if (num != 0)
			{
			}
			num = (short)817823744;
			short num3 = num;
			num = (short)1980760064;
			if (num != 0)
			{
			}
			this.d.OTAP_BATCH_ENABLE_ARS_SERVER_IP_ADDRESS = false;
			this.autoRegServer.IsEnabled = false;
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x000D88FC File Offset: 0x000D6AFC
		private void btnCancel_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)2049772210;
			short num2 = num;
			num = (short)325847730;
			switch (num2 == num)
			{
			}
			num = (short)622788609;
			if (num != 0)
			{
			}
			num = (short)1066336256;
			short num3 = num;
			num = (short)2058747904;
			if (num != 0)
			{
			}
			this.CancelBatchSchedule = true;
			base.Close();
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x000D89B0 File Offset: 0x000D6BB0
		private void SchedulerWindowClosing(object A_0, CancelEventArgs A_1)
		{
			short num = (short)1454964737;
			if (num != 0)
			{
			}
			int num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
					{
						num = (short)1647872146;
						short num3 = num;
						num = (short)4950162;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4B;
						default:
							num = (short)1504378880;
							if (num != 0)
							{
							}
							if (!this.b())
							{
								num = (short)1855717377;
								num2 = (int)((IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 1:
						A_1.Cancel = true;
						num = (short)940048386;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
						goto IL_ED;
					}
					goto IL_44;
				}
				IL_ED:
				num = (short)1461846016;
				short num4 = num;
				return;
			}
			}
			IL_44:
			this.CancelBatchSchedule = true;
			IL_4B:
			num = (short)186187776;
			num2 = (int)((IntPtr)num);
			goto IL_32;
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x000D8AD8 File Offset: 0x000D6CD8
		private bool b()
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.b.IsEnabled)
					{
						num2 = (short)773062656;
						short num3 = num2;
						num2 = (short)1915355140;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_277;
				case 1:
					goto IL_8F;
				case 2:
					if (this.b != null)
					{
						num2 = (short)1570439173;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_277;
				case 3:
					if (System.Windows.MessageBox.Show(AppResources.Warning_A_Batch_Programming_Schedule_Has_Already_Setup, AppResources.Cancel_Batch_Programming_Schedule, MessageBoxButton.YesNo, MessageBoxImage.Exclamation) != MessageBoxResult.Yes)
					{
						num2 = (short)920059910;
						num = (int)((IntPtr)num2);
						continue;
					}
					this.btnStart.IsEnabled = true;
					this.dtSchedulerDateTime.IsEnabled = true;
					this.txtboxRadioListFilePath.IsEnabled = true;
					this.btnRadioListFilePathBrowse.IsEnabled = true;
					this.chkboxStaticIpAddress.IsEnabled = true;
					this.autoRegServer.IsEnabled = true;
					this.btnAdd.IsEnabled = true;
					this.btnAddAll.IsEnabled = true;
					this.btnRemove.IsEnabled = true;
					this.btnRemoveAll.IsEnabled = true;
					this.txtbxNumRetries.IsEnabled = true;
					this.chkboxWriteProtect.IsEnabled = true;
					result = false;
					goto IL_25E;
				case 4:
				{
					num2 = (short)1435334044;
					short num4 = num2;
					num2 = (short)1563522460;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_25E;
					default:
						num2 = (short)1340276736;
						if (num2 != 0)
						{
						}
						this.b.Stop();
						num2 = (short)1244528641;
						if (num2 != 0)
						{
						}
						num2 = (short)1918238723;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					num2 = (short)1531248640;
					num = (int)((IntPtr)num2);
					continue;
				case 6:
					result = false;
					this.b.Start();
					num2 = (short)261488641;
					num = (int)((IntPtr)num2);
					continue;
				case 7:
					goto IL_275;
				}
				goto IL_30;
				IL_25E:
				num2 = (short)1721630727;
				num = (int)((IntPtr)num2);
			}
			IL_8F:
			IL_275:
			IL_277:
			this.CancelBatchSchedule = false;
			return result;
			IL_30:
			result = true;
			num2 = (short)1176109058;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x000D8D64 File Offset: 0x000D6F64
		private bool a(POP25RadioInfo A_0, POP25RadioInfo A_1)
		{
			while (A_0.Radio_ID == A_1.Radio_ID)
			{
				short num = (short)1743582196;
				short num2 = num;
				num = (short)1222964212;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)547553281;
					if (num != 0)
					{
					}
					num = (short)1217593344;
					short num3 = num;
					num = (short)1649016832;
					if (num != 0)
					{
					}
					return A_0.Radio_IP == A_1.Radio_IP;
				}
				}
			}
			return false;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x000D8E38 File Offset: 0x000D7038
		private void btnAdd_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 18;
			short num = (short)459341824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)787939349;
				num2 = (int)((IntPtr)num);
				for (;;)
				{
					POP25RadioInfo pop25RadioInfo;
					System.Windows.Input.Cursor overrideCursor;
					IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						if (pop25RadioInfo.Radio_IP_Valid)
						{
							num = (short)1671168049;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_865;
					case 1:
						goto IL_279;
					case 2:
						num = (short)4653080;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						System.Windows.MessageBox.Show(AppResources.BP_Warning_Some_radios_require_the_presence_of_an_ARS_to_be_programmed, AppResources.Warning_Id, MessageBoxButton.OK, MessageBoxImage.Exclamation);
						num = (short)740163617;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
						if (string.IsNullOrEmpty(pop25RadioInfo.Radio_ID))
						{
							num = (short)187760686;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1EB;
					case 5:
					{
						if (this.dgAvailableRadio.SelectedItems.Count <= 0)
						{
							num = (short)1202978817;
							num2 = (int)((IntPtr)num);
							continue;
						}
						bool flag = false;
						pop25RadioInfo = (POP25RadioInfo)this.dgAvailableRadio.SelectedItems[0];
						num = (short)353697796;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1473445915;
						num2 = (int)((IntPtr)num);
						continue;
					case 7:
						num = (short)51904538;
						num2 = (int)((IntPtr)num);
						continue;
					case 8:
						num = (short)1365246000;
						num2 = (int)((IntPtr)num);
						continue;
					case 9:
						goto IL_316;
					case 10:
						goto IL_2BA;
					case 11:
						goto IL_1EB;
					case 12:
						goto IL_587;
					case 13:
						num = (short)1901002787;
						num2 = (int)((IntPtr)num);
						continue;
					case 14:
					{
						overrideCursor = Mouse.OverrideCursor;
						Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;
						string text = "";
						num = (short)2080833572;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 15:
						if (pop25RadioInfo.Radio_ID_Valid)
						{
							num = (short)2001076237;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_933;
					case 16:
						goto IL_316;
					case 17:
						if (System.Windows.MessageBox.Show(AppResources.You_Are_Trying_Select_An_Invalid_Radio, AppResources.Error_excalmatory_mark, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
						{
							num = (short)69730310;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_316;
					case 18:
						num = (short)659357711;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
						if (pop25RadioInfo.Radio_IP.Length <= 0)
						{
							num = (short)561053739;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_8F6;
					case 20:
						num = (short)1844183079;
						num2 = (int)((IntPtr)num);
						continue;
					case 21:
						switch (0)
						{
						case 0:
							goto IL_114;
						}
						continue;
					case 22:
						num = (short)1735852033;
						if (num != 0)
						{
						}
						if (System.Windows.MessageBox.Show(AppResources.You_Are_Trying_Select_An_Invalid_Radio, AppResources.Error_excalmatory_mark, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
						{
							num = (short)323944458;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_316;
					case 23:
						if (this.autoRegServer.Items.Count <= 0)
						{
							num = (short)2113011719;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_648;
					case 24:
					{
						if (this.autoRegServer.Items.Count > 0)
						{
							goto IL_8F6;
						}
						num = (short)2062777267;
						short num3 = num;
						num = (short)957447091;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2BA;
						default:
						{
							num = (short)140312576;
							short num4 = num;
							num = (short)1141899264;
							if (num != 0)
							{
							}
							num = (short)1518665736;
							num2 = (int)((IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 25:
						num = (short)1021313043;
						num2 = (int)((IntPtr)num);
						continue;
					case 26:
						if (pop25RadioInfo.Radio_ID.Length > 0)
						{
							num = (short)1177485332;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_648;
					case 27:
						goto IL_279;
					case 28:
					{
						string text = text + pop25RadioInfo.Radio_ID + RptMgrErrorHandler.b("龔", a_);
						this.dgAvailableRadio.SelectedItems.Remove(pop25RadioInfo);
						num = (short)1020526601;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 29:
						goto IL_316;
					case 30:
						if (!string.IsNullOrEmpty(pop25RadioInfo.Radio_IP))
						{
							num = (short)870055947;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)993722405;
						num2 = (int)((IntPtr)num);
						continue;
					case 31:
						num = (short)2104033280;
						num2 = (int)((IntPtr)num);
						continue;
					case 32:
						try
						{
							num = (short)1084030977;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									bool flag = true;
									this.dgAvailableRadio.SelectedItems.RemoveAt(0);
									num = (short)1907359747;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_443;
									}
									continue;
								case 2:
									num = (short)938999814;
									num2 = (int)((IntPtr)num);
									continue;
								case 3:
									goto IL_4EF;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1325662210;
										num2 = (int)((IntPtr)num);
										continue;
									}
									POP25RadioInfo a_2 = (POP25RadioInfo)enumerator.Current;
									num = (short)1419378693;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 5:
								{
									POP25RadioInfo a_2;
									if (this.a(pop25RadioInfo, a_2))
									{
										num = (short)933756928;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_50C;
								}
								IL_445:
								num = (short)1315176452;
								num2 = (int)((IntPtr)num);
								continue;
								IL_443:
								goto IL_445;
							}
							IL_4EF:
							IL_50C:
							goto IL_2D8;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_52E;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_51B:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)596377601;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_586;
								case 1:
									disposable.Dispose();
									num = (short)119013378;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									goto IL_584;
								}
								goto IL_52E;
							}
							IL_584:
							IL_586:
							goto EndFinally_26;
							IL_52E:
							disposable = (enumerator as IDisposable);
							num = (short)1478164480;
							num2 = (int)((IntPtr)num);
							goto IL_51B;
							EndFinally_26:;
						}
						goto IL_587;
						IL_2D8:
						num = (short)2054094895;
						num2 = (int)((IntPtr)num);
						continue;
					case 33:
						goto IL_363;
					case 34:
						return;
					case 35:
						if (pop25RadioInfo.Radio_IP_Valid)
						{
							num = (short)2053570562;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_933;
					case 36:
						goto IL_316;
					case 37:
						if (System.Windows.MessageBox.Show(AppResources.Empty_Entries_Not_Allowed_Please_Remove_Before_Continuing, AppResources.Error_excalmatory_mark, MessageBoxButton.OK, MessageBoxImage.Exclamation) != MessageBoxResult.OK)
						{
							num = (short)12582928;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_279;
					case 38:
						goto IL_279;
					case 39:
						if (pop25RadioInfo.Radio_IP.Length <= 0)
						{
							num = (short)1076625436;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_648;
					case 40:
						goto IL_316;
					case 41:
						if (this.dgSelectedRadios.HasItems)
						{
							num = (short)1013448716;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)2087649324;
						num2 = (int)((IntPtr)num);
						continue;
					case 42:
					{
						string text;
						if (text.Length > 0)
						{
							num = (short)611909635;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_363;
					}
					case 43:
					{
						string text = text + pop25RadioInfo.Radio_ID + RptMgrErrorHandler.b("龔", a_);
						this.dgAvailableRadio.SelectedItems.Remove(pop25RadioInfo);
						num = (short)1300627485;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 44:
						if (pop25RadioInfo.Radio_ID_Valid)
						{
							num = (short)2110652447;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_865;
					case 45:
						goto IL_316;
					case 46:
						num = (short)1233715230;
						num2 = (int)((IntPtr)num);
						continue;
					case 47:
					{
						bool flag;
						if (!flag)
						{
							num = (short)178061330;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_316;
					}
					case 48:
						if (pop25RadioInfo.Radio_ID.Length > 0)
						{
							num = (short)1250885657;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_8F6;
					case 49:
						num = (short)1416626199;
						num2 = (int)((IntPtr)num);
						continue;
					}
					IL_114:
					if (this.dgAvailableRadio.SelectedItems.Count > 0)
					{
						num = (short)545718286;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
					IL_1EB:
					num = (short)1700462633;
					num2 = (int)((IntPtr)num);
					continue;
					IL_279:
					num = (short)120193066;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2BA:
					num = (short)1020592166;
					num2 = (int)((IntPtr)num);
					continue;
					IL_316:
					num = (short)1555169285;
					num2 = (int)((IntPtr)num);
					continue;
					IL_363:
					Mouse.OverrideCursor = overrideCursor;
					num = (short)305856546;
					num2 = (int)((IntPtr)num);
					continue;
					IL_587:
					enumerator = ((IEnumerable)this.dgSelectedRadios.Items).GetEnumerator();
					num = (short)1334837280;
					num2 = (int)((IntPtr)num);
					continue;
					IL_648:
					this.dgSelectedRadios.Items.Add(pop25RadioInfo);
					this.DataSource.Remove(pop25RadioInfo);
					num = (short)922812456;
					num2 = (int)((IntPtr)num);
					continue;
					IL_865:
					num = (short)1732640785;
					num2 = (int)((IntPtr)num);
					continue;
					IL_8F6:
					this.dgSelectedRadios.Items.Add(pop25RadioInfo);
					this.DataSource.Remove(pop25RadioInfo);
					num = (short)64356397;
					num2 = (int)((IntPtr)num);
					continue;
					IL_933:
					num = (short)1389821974;
					num2 = (int)((IntPtr)num);
				}
				return;
			}
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x000D9928 File Offset: 0x000D7B28
		private void btnAddAll_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 18;
			short num = (short)1157693440;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_FF;
				}
				for (;;)
				{
					IL_30:
					POP25RadioInfo pop25RadioInfo;
					System.Windows.Input.Cursor overrideCursor;
					IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						num = (short)531824645;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						goto IL_612;
					case 2:
						goto IL_34F;
					case 3:
						if (pop25RadioInfo.Radio_ID_Valid)
						{
							num = (short)278265901;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_87E;
					case 4:
						num = (short)962658343;
						num2 = (int)((IntPtr)num);
						continue;
					case 5:
						if (this.autoRegServer.Items.Count <= 0)
						{
							num = (short)1107820582;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_6D1;
					case 6:
						if (string.IsNullOrEmpty(pop25RadioInfo.Radio_ID))
						{
							num = (short)1374879778;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1FA;
					case 7:
						if (!string.IsNullOrEmpty(pop25RadioInfo.Radio_IP))
						{
							num = (short)1537474592;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1594884133;
						num2 = (int)((IntPtr)num);
						continue;
					case 8:
						goto IL_34F;
					case 9:
						num = (short)1267269668;
						num2 = (int)((IntPtr)num);
						continue;
					case 10:
						if (this.dgAvailableRadio.SelectedItems.Count > 0)
						{
							num = (short)274268188;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 11:
						goto IL_2B2;
					case 12:
					{
						string text = text + pop25RadioInfo.Radio_ID + RptMgrErrorHandler.b("龔", a_);
						this.dgAvailableRadio.SelectedItems.Remove(pop25RadioInfo);
						num = (short)2012807211;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 13:
						goto IL_34F;
					case 14:
					{
						string text;
						if (text.Length > 0)
						{
							num = (short)35520554;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_39D;
					}
					case 15:
						goto IL_34F;
					case 16:
						goto IL_39D;
					case 17:
						goto IL_2B2;
					case 18:
						num = (short)1249640465;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
						num = (short)1714290718;
						num2 = (int)((IntPtr)num);
						continue;
					case 20:
						if (this.dgSelectedRadios.HasItems)
						{
							num = (short)482672641;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)487522307;
						num2 = (int)((IntPtr)num);
						continue;
					case 21:
						if (pop25RadioInfo.Radio_IP_Valid)
						{
							num = (short)671219712;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_87E;
					case 22:
					{
						num = (short)1231683584;
						short num3 = num;
						if (pop25RadioInfo.Radio_ID.Length > 0)
						{
							num = (short)406257688;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_6D1;
					}
					case 23:
						num = (short)1321730088;
						num2 = (int)((IntPtr)num);
						continue;
					case 24:
						num = (short)46465053;
						num2 = (int)((IntPtr)num);
						continue;
					case 25:
						if (System.Windows.MessageBox.Show(AppResources.You_Are_Trying_Select_An_Invalid_Radio, AppResources.Error_excalmatory_mark, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
						{
							num = (short)162660370;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_34F;
					case 26:
						if (System.Windows.MessageBox.Show(AppResources.You_Are_Trying_Select_An_Invalid_Radio, AppResources.Error_excalmatory_mark, MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
						{
							num = (short)636747807;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_34F;
					case 27:
						goto IL_34F;
					case 28:
					{
						overrideCursor = Mouse.OverrideCursor;
						Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;
						string text = "";
						num = (short)1211957261;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 29:
						if (pop25RadioInfo.Radio_IP.Length <= 0)
						{
							num = (short)1129578540;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_6D1;
					case 30:
						if (pop25RadioInfo.Radio_ID.Length > 0)
						{
							num = (short)646447139;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_90F;
					case 31:
						num = (short)265224233;
						num2 = (int)((IntPtr)num);
						continue;
					case 32:
						goto IL_1FA;
					case 33:
						if (pop25RadioInfo.Radio_IP.Length <= 0)
						{
							num = (short)1438449676;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_90F;
					case 34:
						num = (short)600571905;
						if (num != 0)
						{
						}
						num = (short)1882521607;
						num2 = (int)((IntPtr)num);
						continue;
					case 35:
						num = (short)1013448737;
						num2 = (int)((IntPtr)num);
						continue;
					case 36:
						if (pop25RadioInfo.Radio_ID_Valid)
						{
							num = (short)1459224599;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_94B;
					case 37:
						if (System.Windows.MessageBox.Show(AppResources.Empty_Entries_Not_Allowed_Please_Remove_Before_Continuing, AppResources.Error_excalmatory_mark, MessageBoxButton.OK, MessageBoxImage.Exclamation) != MessageBoxResult.OK)
						{
							num = (short)35979291;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2B2;
					case 38:
						num = (short)1059586070;
						num2 = (int)((IntPtr)num);
						continue;
					case 39:
						if (this.autoRegServer.Items.Count <= 0)
						{
							num = (short)1725431827;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_90F;
					case 40:
						if (pop25RadioInfo.Radio_IP_Valid)
						{
							num = (short)1669791748;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_94B;
					case 41:
						goto IL_2B2;
					case 42:
						System.Windows.MessageBox.Show(AppResources.BP_Warning_Some_radios_require_the_presence_of_an_ARS_to_be_programmed, AppResources.Warning_Id, MessageBoxButton.OK, MessageBoxImage.Exclamation);
						num = (short)1628700688;
						num2 = (int)((IntPtr)num);
						continue;
					case 43:
						goto IL_34F;
					case 44:
					{
						string text = text + pop25RadioInfo.Radio_ID + RptMgrErrorHandler.b("龔", a_);
						this.dgAvailableRadio.SelectedItems.Remove(pop25RadioInfo);
						num = (short)1169620994;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 45:
						num = (short)1038680085;
						num2 = (int)((IntPtr)num);
						continue;
					case 46:
						return;
					case 47:
						try
						{
							num = (short)576643112;
							short num4 = num;
							num = (short)1508237352;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)847183872;
								if (num != 0)
								{
								}
								num = (short)1093402626;
								num2 = (int)((IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									POP25RadioInfo a_2;
									if (this.a(pop25RadioInfo, a_2))
									{
										num = (short)1254752257;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									bool flag = true;
									this.dgAvailableRadio.SelectedItems.RemoveAt(0);
									num = (short)195231747;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4C9;
									}
									continue;
								case 3:
									goto IL_577;
								case 4:
									goto IL_595;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1631715334;
										num2 = (int)((IntPtr)num);
										continue;
									}
									POP25RadioInfo a_2 = (POP25RadioInfo)enumerator.Current;
									num = (short)1676869632;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1139736580;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_4CB:
								num = (short)1388707845;
								num2 = (int)((IntPtr)num);
								continue;
								IL_4C9:
								goto IL_4CB;
							}
							IL_577:
							IL_595:
							goto IL_313;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_5B7;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_5A4:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)668139521;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									goto IL_60F;
								case 2:
									if (disposable != null)
									{
										num = (short)346292224;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_611;
								}
								goto IL_5B7;
							}
							IL_60F:
							IL_611:
							goto EndFinally_26;
							IL_5B7:
							disposable = (enumerator as IDisposable);
							num = (short)44105730;
							num2 = (int)((IntPtr)num);
							goto IL_5A4;
							EndFinally_26:;
						}
						goto IL_612;
						IL_313:
						num = (short)300941360;
						num2 = (int)((IntPtr)num);
						continue;
					case 48:
					{
						bool flag;
						if (!flag)
						{
							num = (short)1387659273;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_34F;
					}
					case 49:
					{
						if (this.dgAvailableRadio.SelectedItems.Count <= 0)
						{
							num = (short)1758068747;
							num2 = (int)((IntPtr)num);
							continue;
						}
						bool flag = false;
						pop25RadioInfo = (POP25RadioInfo)this.dgAvailableRadio.SelectedItems[0];
						num = (short)1119682566;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					goto IL_FF;
					IL_1FA:
					num = (short)1539702804;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2B2:
					num = (short)1576337422;
					num2 = (int)((IntPtr)num);
					continue;
					IL_34F:
					num = (short)1373503537;
					num2 = (int)((IntPtr)num);
					continue;
					IL_39D:
					Mouse.OverrideCursor = overrideCursor;
					num = (short)1911685166;
					num2 = (int)((IntPtr)num);
					continue;
					IL_612:
					enumerator = ((IEnumerable)this.dgSelectedRadios.Items).GetEnumerator();
					num = (short)2085814319;
					num2 = (int)((IntPtr)num);
					continue;
					IL_6D1:
					this.dgSelectedRadios.Items.Add(pop25RadioInfo);
					this.DataSource.Remove(pop25RadioInfo);
					num = (short)2105868303;
					num2 = (int)((IntPtr)num);
					continue;
					IL_87E:
					num = (short)1774649370;
					num2 = (int)((IntPtr)num);
					continue;
					IL_90F:
					this.dgSelectedRadios.Items.Add(pop25RadioInfo);
					this.DataSource.Remove(pop25RadioInfo);
					num = (short)1509163016;
					num2 = (int)((IntPtr)num);
					continue;
					IL_94B:
					num = (short)154664985;
					num2 = (int)((IntPtr)num);
				}
				return;
				IL_FF:
				this.dgAvailableRadio.SelectAll();
				num = (short)826015754;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x000DA42C File Offset: 0x000D862C
		private void btnRemove_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1861156864;
			short num2 = num;
			num = (short)1210122241;
			int num3 = (int)((IntPtr)num);
			for (;;)
			{
				IL_49:
				switch (num3)
				{
				case 0:
					while (this.dgSelectedRadios.SelectedItems.Count > 0)
					{
						num = (short)959827632;
						short num4 = num;
						num = (short)907529904;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)99352576;
							if (num != 0)
							{
							}
							POP25RadioInfo pop25RadioInfo = (POP25RadioInfo)this.dgSelectedRadios.SelectedItems[0];
							this.dgSelectedRadios.Items.Remove(pop25RadioInfo);
							this.DataSource.Add(pop25RadioInfo);
							num = (short)1874984963;
							num3 = (int)((IntPtr)num);
							goto IL_49;
						}
						}
					}
					num = (short)24182786;
					num3 = (int)((IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					continue;
				case 2:
					return;
				case 3:
					goto IL_BD;
				case 4:
					goto IL_BD;
				case 5:
					num = (short)301268993;
					if (num != 0)
					{
					}
					num = (short)2144862212;
					num3 = (int)((IntPtr)num);
					continue;
				}
				IL_67:
				if (this.dgSelectedRadios.Items.Count > 0)
				{
					num = (short)378601477;
					num3 = (int)((IntPtr)num);
					continue;
				}
				break;
				IL_BD:
				num = (short)491257856;
				num3 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x000DA5F4 File Offset: 0x000D87F4
		private void btnRemoveAll_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)2024472576;
			short num2 = num;
			num = (short)1888157697;
			int num3 = (int)((IntPtr)num);
			for (;;)
			{
				IL_47:
				switch (num3)
				{
				case 0:
					while (this.dgSelectedRadios.Items.Count > 0)
					{
						num = (short)666407271;
						short num4 = num;
						num = (short)1397264743;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1347485696;
							if (num != 0)
							{
							}
							POP25RadioInfo pop25RadioInfo = (POP25RadioInfo)this.dgSelectedRadios.Items[0];
							this.dgSelectedRadios.Items.Remove(pop25RadioInfo);
							this.DataSource.Add(pop25RadioInfo);
							num = (short)1776615427;
							num3 = (int)((IntPtr)num);
							goto IL_47;
						}
						}
					}
					num = (short)2105016322;
					num3 = (int)((IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 2:
					return;
				case 3:
					goto IL_BD;
				case 4:
					goto IL_BD;
				case 5:
					num = (short)242745348;
					num3 = (int)((IntPtr)num);
					continue;
				}
				IL_65:
				num = (short)1655111681;
				if (num != 0)
				{
				}
				if (this.dgSelectedRadios.Items.Count > 0)
				{
					num = (short)1698168837;
					num3 = (int)((IntPtr)num);
					continue;
				}
				break;
				IL_BD:
				num = (short)1924333568;
				num3 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x000DA7C0 File Offset: 0x000D89C0
		private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)2029592472;
			short num2 = num;
			num = (short)1102192536;
			switch (num2 == num)
			{
			}
			num = (short)1680605184;
			short num3 = num;
			num = (short)603979777;
			if (num != 0)
			{
			}
			num = (short)1491664896;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x000DA870 File Offset: 0x000D8A70
		private void btnSchedulerHelp_Click(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 9;
			short num;
			try
			{
				num = (short)1812464107;
				short num2 = num;
				num = (short)458883563;
				switch (num2 == num)
				{
				}
				num = (short)1855062016;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(RptMgrErrorHandler.b("꾋ꢏ꒑ꊓ꒕겗ꦙ겛", a_));
			}
			catch (Exception)
			{
			}
			num = (short)716963841;
			if (num != 0)
			{
			}
			num = (short)819855360;
			short num3 = num;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x000DA950 File Offset: 0x000D8B50
		private void txtboxRadioListFilePath_SelectionChanged(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1584988160;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4A;
			}
			int num3;
			string text;
			for (;;)
			{
				IL_34:
				switch (num3)
				{
				case 0:
					goto IL_14A;
				case 1:
					if (File.Exists(text))
					{
						goto IL_132;
					}
					goto IL_14C;
				case 2:
					if (string.IsNullOrEmpty(text))
					{
						num = (short)1759510531;
						num3 = (int)((IntPtr)num);
						continue;
					}
					goto IL_100;
				case 3:
				{
					num = (short)136904705;
					if (num != 0)
					{
					}
					num = (short)812580218;
					short num4 = num;
					num = (short)910949754;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_132;
					default:
						num = (short)470876160;
						if (num != 0)
						{
						}
						num = (short)1884225537;
						num3 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_4A;
				IL_132:
				num = (short)259260416;
				num3 = (int)((IntPtr)num);
			}
			IL_100:
			this.b(this.txtboxRadioListFilePath.Text);
			return;
			IL_14A:
			goto IL_100;
			IL_14C:
			System.Windows.MessageBox.Show(AppResources.Please_Select_A_Valid_Radio_List_XML_file, AppResources.File_Does_Not_Exist, MessageBoxButton.OK, MessageBoxImage.Exclamation);
			return;
			IL_4A:
			text = this.txtboxRadioListFilePath.Text;
			num = (short)1498808322;
			num3 = (int)((IntPtr)num);
			goto IL_34;
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x000DAAC0 File Offset: 0x000D8CC0
		private bool a(string A_0)
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
				byte[] addressBytes;
				byte b;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (addressBytes[3] != 255)
						{
							num2 = (short)1894383646;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_1DA;
					case 1:
						if (addressBytes[1] != 0)
						{
							num2 = (short)215285791;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_1DA;
					case 2:
						goto IL_576;
					case 3:
						if (b != 127)
						{
							num2 = (short)1623326740;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_576;
					case 4:
						num2 = (short)482410535;
						num = (int)((IntPtr)num2);
						continue;
					case 5:
						if (addressBytes[3] != 0)
						{
							num2 = (short)2103443500;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_2FB;
					case 6:
						if (b == 0)
						{
							num2 = (short)201654274;
							num = (int)((IntPtr)num2);
							continue;
						}
						num2 = (short)1217003560;
						num = (int)((IntPtr)num2);
						continue;
					case 7:
						if (addressBytes[2] != 0)
						{
							num2 = (short)1184759855;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_594;
					case 8:
						goto IL_1DA;
					case 9:
						if (addressBytes[1] == 0)
						{
							num2 = (short)104136741;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_2BB;
					case 10:
						num2 = (short)1897267221;
						num = (int)((IntPtr)num2);
						continue;
					case 11:
						if (addressBytes[3] == 255)
						{
							num2 = (short)1850081304;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_6AA;
					case 12:
						goto IL_1F4;
					case 13:
						num2 = (short)273154076;
						num = (int)((IntPtr)num2);
						continue;
					case 14:
						if (addressBytes[2] == 255)
						{
							num2 = (short)1193869353;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_539;
					case 15:
						goto IL_6C1;
					case 16:
						if (addressBytes[3] == 255)
						{
							num2 = (short)398262314;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_6AA;
					case 17:
						if (b <= 223)
						{
							num2 = (short)869138459;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_576;
					case 18:
						num2 = (short)1952972801;
						num = (int)((IntPtr)num2);
						continue;
					case 19:
						num2 = (short)1913389102;
						num = (int)((IntPtr)num2);
						continue;
					case 20:
						num2 = (short)14221318;
						num = (int)((IntPtr)num2);
						continue;
					case 21:
						if (addressBytes[2] == 255)
						{
							num2 = (short)45482007;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_6AA;
					case 22:
						goto IL_5AE;
					case 23:
						num2 = (short)1708851211;
						num = (int)((IntPtr)num2);
						continue;
					case 24:
						goto IL_2FB;
					case 25:
						if (addressBytes[2] == 0)
						{
							num2 = (short)2041577476;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_6AA;
					case 26:
						num2 = (short)1718747152;
						num = (int)((IntPtr)num2);
						continue;
					case 27:
						num2 = (short)1437794307;
						num = (int)((IntPtr)num2);
						continue;
					case 28:
						if (addressBytes[1] == 0)
						{
							num2 = (short)1708916779;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_3D0;
					case 29:
						if (addressBytes[2] == 0)
						{
							num2 = (short)2043346978;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_2BB;
					case 30:
						goto IL_539;
					case 31:
						goto IL_23B;
					case 32:
						num2 = (short)1405222950;
						num = (int)((IntPtr)num2);
						continue;
					case 33:
						goto IL_315;
					case 34:
						num2 = (short)2047737861;
						num = (int)((IntPtr)num2);
						continue;
					case 35:
						goto IL_58F;
					case 36:
						if (addressBytes[3] != 0)
						{
							num2 = (short)607322138;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_594;
					case 37:
						num2 = (short)1096744989;
						num = (int)((IntPtr)num2);
						continue;
					case 38:
						if (b == 128)
						{
							num2 = (short)984023058;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_23B;
					case 39:
						if (addressBytes[3] == 0)
						{
							num2 = (short)1090387976;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_6AA;
					case 40:
						if (b >= 192)
						{
							num2 = (short)2103181331;
							num = (int)((IntPtr)num2);
							continue;
						}
						num2 = (short)1403519021;
						num = (int)((IntPtr)num2);
						continue;
					case 41:
						num2 = (short)1445068800;
						num = (int)((IntPtr)num2);
						continue;
					case 42:
						goto IL_594;
					case 43:
						num2 = (short)660799495;
						num = (int)((IntPtr)num2);
						continue;
					case 44:
						goto IL_2BB;
					case 45:
						if (b >= 128)
						{
							num2 = (short)622329888;
							num = (int)((IntPtr)num2);
							continue;
						}
						num2 = (short)1976958985;
						num = (int)((IntPtr)num2);
						continue;
					case 46:
						if (b == 192)
						{
							num2 = (short)1822752781;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_3D0;
					case 47:
						goto IL_3D0;
					case 48:
						if (addressBytes[1] == 255)
						{
							num2 = (short)1974534154;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_6AA;
					}
					goto IL_D4;
					IL_1DA:
					result = false;
					num2 = (short)323092492;
					num = (int)((IntPtr)num2);
					continue;
					IL_23B:
					num2 = (short)1326841870;
					num = (int)((IntPtr)num2);
					continue;
					IL_2BB:
					num2 = (short)771358768;
					num = (int)((IntPtr)num2);
					continue;
					IL_2FB:
					result = false;
					num2 = (short)122748961;
					num = (int)((IntPtr)num2);
					continue;
					IL_3D0:
					num2 = (short)2052259876;
					num = (int)((IntPtr)num2);
					continue;
					IL_539:
					num2 = (short)992411673;
					num = (int)((IntPtr)num2);
					continue;
					IL_576:
					result = false;
					num2 = (short)1029046307;
					num = (int)((IntPtr)num2);
					continue;
					IL_594:
					result = false;
					num2 = (short)1065811990;
					num = (int)((IntPtr)num2);
					continue;
					IL_6AA:
					num2 = (short)1667563535;
					num = (int)((IntPtr)num2);
				}
				IL_1F4:
				IL_315:
				IL_58F:
				IL_5AE:
				return result;
				IL_6C1:
				goto IL_6CB;
				IL_D4:
				addressBytes = IPAddress.Parse(A_0).GetAddressBytes();
				b = addressBytes[0];
				num2 = (short)1928003601;
				num = (int)((IntPtr)num2);
				goto IL_0A;
			}
			catch (Exception)
			{
				return false;
			}
			IL_6CB:
			num2 = (short)1786535586;
			short num3 = num2;
			num2 = (short)132538018;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num2 = (short)387710976;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)151060481;
			if (num2 != 0)
			{
			}
			num2 = (short)2067464192;
			if (num2 != 0)
			{
			}
			return true;
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x000DB258 File Offset: 0x000D9458
		private void txtbxNumRetries_TextChanged(object A_0, TextChangedEventArgs A_1)
		{
			int a_ = 6;
			short num = (short)1800798208;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1663688731;
					short num3 = num;
					num = (short)1752752155;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10C;
					default:
						num = (short)1529544704;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_86;
						}
						continue;
					}
					break;
				}
				case 1:
					num = (short)765394945;
					if (num != 0)
					{
					}
					this.txtbxNumRetries.Text = RptMgrErrorHandler.b("릈", a_);
					num = (short)2007040002;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					goto IL_10A;
				}
				IL_86:
				if (!(this.txtbxNumRetries.Text == ""))
				{
					break;
				}
				num = (short)1443233793;
				num2 = (int)((IntPtr)num);
			}
			IL_10A:
			IL_10C:
			num = (short)1062141952;
			short num4 = num;
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x000DB39C File Offset: 0x000D959C
		private bool a(PNServer A_0, ref string A_1)
		{
			int a_ = 1;
			short num = (short)821690368;
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
				bool result;
				RawData rawCertData;
				for (;;)
				{
					IL_30:
					TimeSpan timeSpan2;
					DateTime notAfter;
					X509Certificate2 x509Certificate2;
					switch (num2)
					{
					case 0:
					{
						TimeSpan timeSpan;
						if (timeSpan.Days < 31)
						{
							num = (short)1424818178;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_C1;
					}
					case 1:
						if (timeSpan2.Days < 31)
						{
							num = (short)299106312;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return result;
					case 2:
					{
						num = (short)1010775414;
						short num3 = num;
						num = (short)795948406;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_38E;
						default:
							num = (short)1381826560;
							if (num != 0)
							{
							}
							A_1 = A_1 + AppResources.The_following_ARS_Data_records_have_CA_certificates_that_are_about_to_expire.AcpStringFormat(new object[]
							{
								A_0.PNSName
							}) + RptMgrErrorHandler.b("躃", a_);
							num = (short)234291211;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						return result;
					case 4:
						goto IL_C1;
					case 5:
						result = true;
						A_1 = A_1 + AppResources.The_following_ARS_Data_records_have_CA_certificates_that_have_expired.AcpStringFormat(new object[]
						{
							A_0.PNSName
						}) + RptMgrErrorHandler.b("躃", a_);
						num = (short)218300420;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
					{
						if (notAfter.CompareTo(DateTime.Today) <= 0)
						{
							goto IL_38E;
						}
						X509Certificate2 x509Certificate;
						notAfter = x509Certificate.NotAfter;
						TimeSpan timeSpan = notAfter.Subtract(DateTime.Today);
						num = (short)1376714752;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 7:
						if (notAfter.CompareTo(DateTime.Today) <= 0)
						{
							num = (short)2105737226;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1E8;
					case 8:
					{
						num = (short)395575296;
						short num4 = num;
						A_1 = A_1 + AppResources.The_following_ARS_Data_records_have_Client_certificates_that_are_about_to_expire.AcpStringFormat(new object[]
						{
							A_0.PNSName
						}) + RptMgrErrorHandler.b("躃", a_);
						num = (short)2090008590;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 9:
					{
						if (rawCertData == null)
						{
							num = (short)108658691;
							num2 = (int)((IntPtr)num);
							continue;
						}
						X509Certificate2 x509Certificate = CertificateLoader.LoadCertificate(Convert.FromBase64String(rawCertData.mRawCACert));
						num = (short)1972764673;
						if (num != 0)
						{
						}
						num = (short)1555496972;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 10:
						result = true;
						A_1 = A_1 + AppResources.The_following_ARS_Data_records_have_Client_certificates_that_have_expired.AcpStringFormat(new object[]
						{
							A_0.PNSName
						}) + RptMgrErrorHandler.b("躃", a_);
						num = (short)1583742989;
						num2 = (int)((IntPtr)num);
						continue;
					case 11:
						goto IL_C1;
					case 12:
					{
						try
						{
							x509Certificate2 = CertificateLoader.LoadPfxCertificate(Convert.FromBase64String(rawCertData.mRawCliCert), rawCertData.mPassPhrase);
							goto IL_35C;
						}
						catch
						{
							x509Certificate2 = CertificateLoader.LoadCertificate(Convert.FromBase64String(rawCertData.mRawCliCert));
							goto IL_35C;
						}
						goto IL_1E8;
						IL_35C:
						X509Certificate2 x509Certificate;
						notAfter = x509Certificate.NotAfter;
						num = (short)1678704646;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 13:
						return result;
					case 14:
						return result;
					}
					goto IL_73;
					IL_C1:
					notAfter = x509Certificate2.NotAfter;
					num = (short)1539309575;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1E8:
					notAfter = x509Certificate2.NotAfter;
					timeSpan2 = notAfter.Subtract(DateTime.Today);
					num = (short)1751515137;
					num2 = (int)((IntPtr)num);
					continue;
					IL_38E:
					num = (short)702742533;
					num2 = (int)((IntPtr)num);
				}
				return result;
				IL_73:
				result = false;
				rawCertData = this.i.GetRawCertData(A_0.PNSName);
				num = (short)366411785;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x000DB800 File Offset: 0x000D9A00
		private void autoRegServer_SelectionChanged(object A_0, SelectionChangedEventArgs A_1)
		{
			short num = (short)438501376;
			short num2 = num;
			num = (short)216203265;
			if (num != 0)
			{
			}
			num = (short)344555238;
			short num3 = num;
			num = (short)192642790;
			switch (num3 == num)
			{
			}
			num = (short)1803681792;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x000DB8AC File Offset: 0x000D9AAC
		private void a()
		{
			short num = (short)879624192;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 1:
					goto IL_AD;
				case 2:
					for (;;)
					{
						num = (short)586743809;
						if (num != 0)
						{
						}
						this.f = ((PNServer)this.autoRegServer.SelectedItem).PNSName;
						this.g = ((PNServer)this.autoRegServer.SelectedItem).PNServerIP.ToString();
						num = (short)480706560;
						short num3 = num;
						num = (short)824109316;
						short num4 = num;
						num = (short)345827588;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_15B;
						}
					}
					IL_15B:
					num = (short)1749221376;
					if (num != 0)
					{
					}
					num = (short)476512260;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					goto IL_1BB;
				case 4:
					if (((PNServer)this.autoRegServer.SelectedItem).SecureConn)
					{
						num = (short)1687355395;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.txtboxConnectionType.Text = AppResources.Clear_Id;
					num = (short)263520257;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_38:
				if (this.j.Count <= 0)
				{
					break;
				}
				num = (short)1078853634;
				num2 = (int)((IntPtr)num);
			}
			IL_AD:
			return;
			IL_1BB:
			this.txtboxConnectionType.Text = AppResources.Secure_Id;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x000DBA7C File Offset: 0x000D9C7C
		private string a(IPAddress A_0)
		{
			short num = (short)981509666;
			short num2 = num;
			num = (short)879535650;
			string result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)320864256;
				short num3 = num;
				break;
			}
			}
			num = (short)1767440385;
			if (num != 0)
			{
			}
			num = (short)2035286016;
			if (num != 0)
			{
			}
			result = string.Empty;
			try
			{
				result = A_0.ToString();
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x040004C8 RID: 1224
		private TimeSpan a;

		// Token: 0x040004C9 RID: 1225
		private DispatcherTimer b;

		// Token: 0x040004CA RID: 1226
		private string c;

		// Token: 0x040004CB RID: 1227
		private SpecialFeaturesSettings d;

		// Token: 0x040004CC RID: 1228
		private Collection<SystemKeyData> e;

		// Token: 0x040004CD RID: 1229
		private string f;

		// Token: 0x040004CE RID: 1230
		private string g;

		// Token: 0x040004CF RID: 1231
		private byte[] h;

		// Token: 0x040004D0 RID: 1232
		private IDataStoreDecryptHandler i;

		// Token: 0x040004D1 RID: 1233
		private List<PNServer> j;

		// Token: 0x040004D2 RID: 1234
		private XmlSerializer k;

		// Token: 0x040004D3 RID: 1235
		private RadioList l;

		// Token: 0x040004D4 RID: 1236
		[CompilerGenerated]
		private bool m;

		// Token: 0x040004D5 RID: 1237
		[CompilerGenerated]
		private PropertyChangedEventHandler n;
	}
}
