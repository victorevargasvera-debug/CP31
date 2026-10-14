using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using ACPBrowser;
using AcpBusinessLayer;
using AcpCommonLib;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using SpecialFeatures.Clone_Configuration.Common;
using SpecialFeatures.Utilities;

namespace SpecialFeatures.CloneWiFi
{
	// Token: 0x02000199 RID: 409
	public class PageCloneWiFiViewModel : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x0600137C RID: 4988 RVA: 0x001C3AB4 File Offset: 0x001C1CB4
		public PageCloneWiFiViewModel(global::SpecialFeatures.CloneWiFi.PageCloneWiFiView view)
		{
			this.b = view;
			this.OKCommand = new global::SpecialFeatures.Utilities.RelayCommand(new global::System.Action<object>(this.c));
			this.CancelCommand = new global::SpecialFeatures.Utilities.RelayCommand(new global::System.Action<object>(this.b));
			this.HelpCommand = new global::SpecialFeatures.Utilities.RelayCommand(new global::System.Action<object>(this.a));
			this.b();
			this.a();
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x001C3B38 File Offset: 0x001C1D38
		// (set) Token: 0x0600137E RID: 4990 RVA: 0x001C3BE8 File Offset: 0x001C1DE8
		public global::System.Collections.ObjectModel.ObservableCollection<global::SpecialFeatures.CloneWiFi.WiFiRecord> ItemSource
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1539714561;
				short num2 = num;
				num = (short)447622657;
				switch (num2 == num)
				{
				default:
				{
					num = (short)993591296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1958346753;
				if (num != 0)
				{
				}
				num = (short)1403322368;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1760060383;
				short num2 = num;
				num = (short)1289511903;
				switch (num2 == num)
				{
				default:
				{
					num = (short)631701504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1941897216;
				if (num != 0)
				{
				}
				num = (short)846790657;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600137F RID: 4991 RVA: 0x001C3C9C File Offset: 0x001C1E9C
		// (remove) Token: 0x06001380 RID: 4992 RVA: 0x001C3DD4 File Offset: 0x001C1FD4
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
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)843120640;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_D6;
					case 2:
					{
						num2 = (short)673513473;
						if (num2 != 0)
						{
						}
						num2 = (short)316060932;
						short num3 = num2;
						num2 = (short)1984607492;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F3;
						default:
						{
							num2 = (short)925237248;
							if (num2 != 0)
							{
							}
							num2 = (short)1989083136;
							short num4 = num2;
							goto IL_D6;
						}
						}
						break;
					}
					}
					goto IL_1C;
					IL_F3:
					num2 = (short)44826625;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_D6:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.d, value2, propertyChangedEventHandler2);
					goto IL_F3;
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.d;
				num2 = (short)1992622082;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)320143361;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				int num2;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_32:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num = (short)399507456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D3;
					case 2:
					{
						num = (short)1029033310;
						short num3 = num;
						num = (short)893635934;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F0;
						default:
						{
							num = (short)862715904;
							if (num != 0)
							{
							}
							num = (short)722665472;
							short num4 = num;
							goto IL_D3;
						}
						}
						break;
					}
					}
					goto IL_44;
					IL_F0:
					num = (short)932184065;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D3:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.d, value2, propertyChangedEventHandler2);
					goto IL_F0;
				}
				return;
				IL_44:
				propertyChangedEventHandler = this.d;
				num = (short)2081619970;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x001C3F08 File Offset: 0x001C2108
		public void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			short num = (short)970391554;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_E9;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				num = (short)1250066597;
				short num3 = num;
				num = (short)1697022117;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_E9:
					this.d(this, e);
					num = (short)1301938176;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)2067726337;
					if (num != 0)
					{
					}
					num = (short)1949564928;
					if (num != 0)
					{
					}
					num = (short)308740096;
					short num4 = num;
					if (this.d == null)
					{
						return;
					}
					num = (short)128974849;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x001C4028 File Offset: 0x001C2228
		// (set) Token: 0x06001383 RID: 4995 RVA: 0x001C40D8 File Offset: 0x001C22D8
		public global::System.Windows.Input.ICommand OKCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1310785537;
				if (num != 0)
				{
				}
				num = (short)1776746496;
				short num2 = num;
				num = (short)1385039838;
				short num3 = num;
				num = (short)1125844958;
				switch (num3 == num)
				{
				}
				num = (short)23920640;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1086253954;
				short num2 = num;
				num = (short)2089675650;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1699151872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2036269057;
				if (num != 0)
				{
				}
				num = (short)1615396864;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x001C418C File Offset: 0x001C238C
		// (set) Token: 0x06001385 RID: 4997 RVA: 0x001C423C File Offset: 0x001C243C
		public global::System.Windows.Input.ICommand CancelCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)884670055;
				short num2 = num;
				num = (short)1226178151;
				switch (num2 == num)
				{
				default:
				{
					num = (short)668598272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1153040385;
				if (num != 0)
				{
				}
				num = (short)288096256;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)473810662;
				short num2 = num;
				num = (short)703776486;
				switch (num2 == num)
				{
				default:
				{
					num = (short)4259840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)888733697;
				if (num != 0)
				{
				}
				num = (short)579993600;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x001C42F0 File Offset: 0x001C24F0
		// (set) Token: 0x06001387 RID: 4999 RVA: 0x001C43A0 File Offset: 0x001C25A0
		public global::System.Windows.Input.ICommand HelpCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1715404801;
				if (num != 0)
				{
				}
				num = (short)1405353984;
				short num2 = num;
				num = (short)1646229769;
				short num3 = num;
				num = (short)1852406025;
				switch (num3 == num)
				{
				}
				num = (short)1909719040;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)505967790;
				short num2 = num;
				num = (short)969045166;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1505820672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1899495424;
				if (num != 0)
				{
				}
				num = (short)1071710209;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x001C4450 File Offset: 0x001C2650
		private void c(object A_0)
		{
			short num = (short)967835648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				bool flag;
				int num5;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						global::SpecialFeatures.CloneWiFi.WiFiRecord wiFiRecord;
						if (!wiFiRecord.PWD.IsValid)
						{
							num = (short)198639617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A6;
					}
					case 1:
						num = (short)442171393;
						if (num != 0)
						{
						}
						flag = false;
						num = (short)46923779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_231;
					case 3:
					{
						num = (short)144471675;
						short num3 = num;
						num = (short)806778491;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_277;
						default:
						{
							num = (short)618332160;
							short num4 = num;
							num = (short)651755520;
							if (num != 0)
							{
							}
							goto IL_A6;
						}
						}
						break;
					}
					case 4:
						if (flag)
						{
							num = (short)10158085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_277;
					case 5:
						goto IL_A1;
					case 6:
						num = (short)1943011332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						if (num5 >= this.ItemSource.Count)
						{
							num = (short)897777670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.CloneWiFi.WiFiRecord wiFiRecord = this.ItemSource[num5];
						wiFiRecord.PWD.IsValid = wiFiRecord.PWD.Content.Equals(this.a[num5].Value);
						num = (short)1938948096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_231;
					}
					goto IL_52;
					IL_A6:
					num5++;
					num = (short)1073152002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_231:
					num = (short)1536557063;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A1:
				this.b.LblCloneWiFiWarning.Visibility = global::System.Windows.Visibility.Hidden;
				((global::System.Windows.Window)this.b.Parent).DialogResult = new bool?(true);
				global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.RefreshSessionTimer();
				return;
				IL_277:
				this.b.LblCloneWiFiWarning.Visibility = global::System.Windows.Visibility.Visible;
				global::System.Windows.Input.Cursor overrideCursor = global::System.Windows.Input.Mouse.OverrideCursor;
				global::System.Windows.Input.Mouse.OverrideCursor = global::System.Windows.Input.Cursors.Wait;
				global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.WaitNextValidate();
				global::System.Windows.Input.Mouse.OverrideCursor = overrideCursor;
				return;
				IL_52:
				flag = true;
				num5 = 0;
				num = (short)173342728;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x001C4700 File Offset: 0x001C2900
		private void b(object A_0)
		{
			short num = (short)364440573;
			short num2 = num;
			num = (short)157936637;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1149042688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)406781953;
			if (num != 0)
			{
			}
			num = (short)202506240;
			if (num != 0)
			{
			}
			((global::System.Windows.Window)this.b.Parent).DialogResult = new bool?(false);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x001C47C4 File Offset: 0x001C29C4
		private void a(object A_0)
		{
			short num;
			try
			{
				num = (short)325809401;
				short num2 = num;
				num = (short)163476729;
				switch (num2 == num)
				{
				}
				num = (short)1536688128;
				if (num != 0)
				{
				}
				global::ACPBrowser.Utility.CloseHelpWindowIfOpen();
				global::ACPBrowser.Utility.DisplayCPSHelpDITA(null);
			}
			catch (global::System.Exception)
			{
			}
			num = (short)861143041;
			if (num != 0)
			{
			}
			num = (short)1384382464;
			short num3 = num;
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x001C4890 File Offset: 0x001C2A90
		private void b()
		{
			short num = (short)348782592;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4C;
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
				for (;;)
				{
					IL_29:
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset configuredNetworksListInnerRecset;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)500563976;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)452395014;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1831796736;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner;
									num = (short)562102276;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection configuredNetworksListInnerSection;
									if (configuredNetworksListInnerSection.DataWideWiFiNetworkSecurityType_42516 != 0)
									{
										num = (short)341114887;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
									if (configuredNetworksListInner != null)
									{
										num = (short)16384005;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection configuredNetworksListInnerSection = configuredNetworksListInner.ConfiguredNetworksListInnerSection;
									num = (short)720437251;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_2FB;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection configuredNetworksListInnerSection;
									global::SpecialFeatures.CloneWiFi.WiFiRecord item = new global::SpecialFeatures.CloneWiFi.WiFiRecord
									{
										SSID = configuredNetworksListInnerSection.DataWideWiFiNetworkSSID_42519.Value,
										PWD = new global::SpecialFeatures.CloneWiFi.WiFiPwd
										{
											Content = string.Empty,
											IsValid = true
										},
										FeatureName = dataWide.WIFI.FeatureSectionName
									};
									this.a.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(configuredNetworksListInnerSection.DataWideWiFiNetworkSSID_42519.Value, configuredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.UIValue));
									this.ItemSource.Add(item);
									num = (short)360972289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_171;
									}
									continue;
								}
								IL_1B8:
								num = (short)74579970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_171:
								goto IL_1B8;
							}
							IL_2FB:
							return;
						}
						finally
						{
							num = (short)529596418;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3BA;
								case 1:
									goto IL_399;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_334;
									}
									continue;
								}
								IL_334:
								num = (short)1067762825;
								short num3 = num;
								num = (short)788645001;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
								{
									IL_399:
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									enumerator.Dispose();
									num = (short)504823808;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
								default:
								{
									num = (short)1134297088;
									if (num != 0)
									{
									}
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (enumerator == null)
									{
										goto IL_3BC;
									}
									num = (short)1498284033;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
								}
							}
							IL_3BA:
							IL_3BC:;
						}
						goto IL_3BD;
					case 1:
						return;
					case 2:
						if (!dataWide.WIFI.DataWideWIFIEnable_42506.Value)
						{
							num = (short)1816199169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BD;
					case 3:
						goto IL_90;
					case 4:
						return;
					case 5:
					{
						if (configuredNetworksListInnerRecset == null)
						{
							num = (short)827981824;
							short num4 = num;
							num = (short)1240072196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = configuredNetworksListInnerRecset.GetEnumerator();
						num = (short)539492352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (dataWide == null)
						{
							num = (short)491585539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)935198722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4C;
					IL_3BD:
					configuredNetworksListInnerRecset = (dataWide.WIFI.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset);
					num = (short)745537541;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_90:
				num = (short)41353217;
				if (num != 0)
				{
				}
				return;
				IL_4C:
				dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
				num = (short)860880902;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x001C4CEC File Offset: 0x001C2EEC
		private void a()
		{
			short num = (short)1752498176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset dataModemTableInnerRecset;
					switch (num2)
					{
					case 0:
						num = (short)1712062465;
						if (num != 0)
						{
						}
						num = (short)1970208772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_151;
					case 2:
						if (dataWide != null)
						{
							num = (short)681312256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						if (dataModemTableInnerRecset == null)
						{
							num = (short)564133894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataModemTableInnerRecset.GetEnumerator();
						num = (short)61472773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (dataWide.ExternalDataModem.ModemConnectionType_43350 != 1)
						{
							num = (short)1890975744;
							short num3 = num;
							num = (short)455081985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39B;
					case 5:
						try
						{
							num = (short)403439618;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner dataModemTableInner;
								switch (num2)
								{
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)1263468547;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_23F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_199;
									}
									continue;
								case 3:
									num = (short)1321861126;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									num = (short)2008356996;
									short num4 = num;
									num = (short)1827936388;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_23F;
									default:
									{
										num = (short)1170669568;
										if (num != 0)
										{
										}
										global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection dataModemTableInnerSection = dataModemTableInner.DataModemTableInnerSection;
										global::SpecialFeatures.CloneWiFi.WiFiRecord item = new global::SpecialFeatures.CloneWiFi.WiFiRecord
										{
											SSID = dataModemTableInnerSection.DataWideExternalDataModemNetworkSsid_43358.Value,
											PWD = new global::SpecialFeatures.CloneWiFi.WiFiPwd
											{
												Content = string.Empty,
												IsValid = true
											},
											FeatureName = dataWide.ExternalDataModem.FeatureSectionName
										};
										this.a.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(dataModemTableInnerSection.DataWideExternalDataModemNetworkSsid_43358.Value, dataModemTableInnerSection.DataWideEncryptedNetworkPassword_43361.UIValue));
										this.ItemSource.Add(item);
										num = (short)1191510016;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 5:
									if (dataModemTableInner != null)
									{
										num = (short)518062084;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									goto IL_329;
								}
								goto IL_199;
								IL_23F:
								dataModemTableInner = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner);
								num = (short)1859649541;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2D1:
								num = (short)954400769;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_199:
								goto IL_2D1;
							}
							IL_329:
							return;
						}
						finally
						{
							num = (short)68157441;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)898957314;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_360;
									}
									continue;
								case 2:
									goto IL_398;
								}
								IL_360:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1217921024;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_398:;
						}
						goto IL_39B;
					case 6:
						return;
					}
					goto IL_4B;
					IL_39B:
					dataModemTableInnerRecset = (dataWide.ExternalDataModem.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset);
					num = (short)287637507;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_151:
				return;
				IL_4B:
				dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
				num = (short)1497759746;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x04000AA7 RID: 2727
		private readonly global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> a = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>();

		// Token: 0x04000AA8 RID: 2728
		private readonly global::SpecialFeatures.CloneWiFi.PageCloneWiFiView b;

		// Token: 0x04000AA9 RID: 2729
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.ObjectModel.ObservableCollection<global::SpecialFeatures.CloneWiFi.WiFiRecord> c = new global::System.Collections.ObjectModel.ObservableCollection<global::SpecialFeatures.CloneWiFi.WiFiRecord>();

		// Token: 0x04000AAA RID: 2730
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler d;

		// Token: 0x04000AAB RID: 2731
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.Input.ICommand e;

		// Token: 0x04000AAC RID: 2732
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.Input.ICommand f;

		// Token: 0x04000AAD RID: 2733
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.Input.ICommand g;
	}
}
