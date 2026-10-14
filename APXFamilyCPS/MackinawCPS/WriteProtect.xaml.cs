using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Navigation;
using System.Windows.Threading;
using AcpASKLib;
using ACPBrowser;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpSecurityLib;
using AcpUI;
using AcpUI.Common;
using CommonResources;
using MackinawCPS.Properties;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using PreEmptive.SoS.Runtime;
using SpecialFeatures.Comms;
using SpecialFeatures.Security;

namespace MackinawCPS
{
	// Token: 0x02000063 RID: 99
	public partial class WriteProtect : PageFunction<string>, INotifyPropertyChanged
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x000D70E0 File Offset: 0x000D52E0
		internal WriteProtect(WindowMain parent, Collection<SystemKeyData> loadedAndAttachedASKs, bool openFromRMC = false, ObservableCollection<ASTRORadio> devices = null, ObservableCollection<bool> isOwnerSystemIDSupported = null)
		{
			int a_ = 2;
			this.initialLanguageSelection = string.Empty;
			this.attachedASKs = new ObservableCollection<SystemKeyData>();
			this.attachedKeys = new Collection<SystemKeyData>();
			this.keysFromRadio = new Collection<SystemKeyData>();
			this.sysKeyDataFromRadio = new SystemKeyData(KeySource.HARDWARE, FixedLengthStream.b("틡", a_), 0, KeyType.NONE, false, false, null);
			this.accessReadWriteDevice = (WindowMain)Application.Current.MainWindow;
			this.expanderlist = new Dictionary<string, AcpExpander>();
			base..ctor();
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
			this._parent = parent;
			this.parentWindowSettings = this._parent.settingsSavedOnAppExit;
			base.DataContext = this;
			this.openFromRMC = openFromRMC;
			this.devices = devices;
			this.isOwnerSystemIDSupported = isOwnerSystemIDSupported;
			if (this.openFromRMC)
			{
				base.Title = AppResources.Set_Radio;
				this.label1.Content = "";
				this.ribbonBarQueryRadio.Opacity = 0.0;
				ColumnDefinition value = new ColumnDefinition();
				this.MyGrid.ColumnDefinitions.Add(value);
				this.ribbonBarUpdateRadio.SetValue(Grid.ColumnProperty, 0);
				this.buttonExit.SetValue(Grid.ColumnProperty, 2);
				this.buttonExit.Width = 125.0;
				this.buttonHelp.SetValue(Grid.ColumnProperty, 4);
				this.buttonHelp.Width = 125.0;
			}
			this.accessReadWriteDevice.readRadioComplete += this.accessReadWriteDevice_readRadioComplete;
			AccessRecord systemAccessLevel = SecurityManager.GetSystemAccessLevel(1, KeyType.ADVANCED_SYSTEM_KEY);
			SystemKeyData item = new SystemKeyData(KeySource.HARDWARE, FixedLengthStream.b("틡", a_), 0, KeyType.NONE, false, false, null);
			SystemKeyData item2 = new SystemKeyData(KeySource.HARDWARE, FixedLengthStream.b("틡", a_), 1, KeyType.ADVANCED_SYSTEM_KEY, false, false, systemAccessLevel);
			SystemKeyData item3 = new SystemKeyData(KeySource.HARDWARE, FixedLengthStream.b("틡", a_), 0, KeyType.ADVANCED_WACN_KEY, false, false, null);
			this.attachedKeys = loadedAndAttachedASKs;
			using (IEnumerator<SystemKeyData> enumerator = loadedAndAttachedASKs.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					SystemKeyData systemKeyData = enumerator.Current;
					if (systemKeyData.Type == KeyType.ADVANCED_SYSTEM_KEY && systemKeyData.SystemID == 1)
					{
						this.attachedKeys.Remove(systemKeyData);
						break;
					}
				}
				goto IL_D0;
			}
			goto IL_2FA;
			IL_D0:
			this.attachedASKs.Insert(0, item3);
			this.attachedASKs.Insert(0, item2);
			this.attachedASKs.Insert(0, item);
			using (IEnumerator<SystemKeyData> enumerator = this.attachedKeys.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					SystemKeyData item4 = enumerator.Current;
					this.attachedASKs.Add(item4);
				}
				goto IL_18E;
			}
			goto IL_29D;
			IL_18E:
			if (!Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
			{
				goto IL_2FA;
			}
			IL_29D:
			base.FlowDirection = FlowDirection.RightToLeft;
			return;
			IL_2FA:
			base.FlowDirection = FlowDirection.LeftToRight;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000D740C File Offset: 0x000D560C
		private void OnLoad(object sender, RoutedEventArgs e)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			IEnumerator enumerator;
			AcpExpander acpExpander;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_168;
				case 1:
					try
					{
						num2 = (short)1437204483;
						num = (int)((IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num2 = (short)2031484934;
									num = (int)((IntPtr)num2);
									continue;
								}
								acpExpander = (((UIElement)enumerator.Current) as AcpExpander);
								num2 = (short)959774724;
								num = (int)((IntPtr)num2);
								continue;
							case 1:
								goto IL_26A;
							case 2:
								this.expanderlist.Add(acpExpander.Name, acpExpander);
								num2 = (short)1195048965;
								num = (int)((IntPtr)num2);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_1AD;
								}
								continue;
							case 4:
								if (acpExpander != null)
								{
									num2 = (short)158203906;
									num = (int)((IntPtr)num2);
									continue;
								}
								break;
							case 6:
								num2 = (short)939458561;
								num = (int)((IntPtr)num2);
								continue;
							}
							IL_1AF:
							num2 = (short)372834304;
							num = (int)((IntPtr)num2);
							continue;
							IL_1AD:
							goto IL_1AF;
						}
						IL_26A:
						goto IL_DA;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_28B;
						}
						IDisposable disposable;
						for (;;)
						{
							IL_279:
							switch (num)
							{
							case 0:
								goto IL_32B;
							case 1:
							{
								num2 = (short)683227059;
								short num3 = num2;
								num2 = (short)1948334003;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num2 = (short)1473511424;
									if (num2 != 0)
									{
									}
									disposable.Dispose();
									num2 = (short)176685056;
									num = (int)((IntPtr)num2);
									continue;
								}
								break;
							}
							case 2:
								if (disposable != null)
								{
									num2 = (short)406323201;
									num = (int)((IntPtr)num2);
									continue;
								}
								goto IL_32D;
							}
							goto IL_28B;
						}
						IL_32B:
						IL_32D:
						goto EndFinally_8;
						IL_28B:
						disposable = (enumerator as IDisposable);
						num2 = (short)652541954;
						num = (int)((IntPtr)num2);
						goto IL_279;
						EndFinally_8:;
					}
					goto IL_32E;
					IL_DA:
					this.ExpanderGeneral.Focus();
					this.SelectedKeyType.SelectedValue = AppResources.None_Id;
					this.comboDlgOwnerSystemIDChoices.SelectedValue = this.attachedASKs[0];
					this.boolDlgWriteProtect.IsEnabled = false;
					this.ribbonBarUpdateRadio.IsEnabled = false;
					num2 = (short)570818562;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
					if (!string.IsNullOrEmpty(this.parentWindowSettings.UserSelectedApplicationLanguage))
					{
						num2 = (short)2139815936;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1160970244;
					num = (int)((IntPtr)num2);
					continue;
				case 3:
					goto IL_D5;
				case 4:
					if (AppResources.Culture.Name.Contains(FixedLengthStream.b("胤铦", a_)))
					{
						num2 = (short)83558400;
						short num4 = num2;
						num2 = (short)1321467907;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_358;
				}
				goto IL_2D;
			}
			IL_D5:
			goto IL_32E;
			IL_168:
			this.initialLanguageSelection = this.parentWindowSettings.UserSelectedApplicationLanguage;
			return;
			IL_32E:
			this.initialLanguageSelection = AppResources.Culture.Name.Substring(0, 2);
			return;
			IL_358:
			num2 = (short)465567745;
			if (num2 != 0)
			{
			}
			this.initialLanguageSelection = AppResources.Culture.Name;
			return;
			IL_2D:
			acpExpander = null;
			enumerator = this.MyStackPanel.Children.GetEnumerator();
			num2 = (short)1345650689;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x000D77C8 File Offset: 0x000D59C8
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x000D7878 File Offset: 0x000D5A78
		public ObservableCollection<SystemKeyData> AttachedSystemKeys
		{
			get
			{
				short num = (short)147764815;
				short num2 = num;
				num = (short)222672463;
				switch (num2 == num)
				{
				}
				num = (short)2139422721;
				if (num != 0)
				{
				}
				num = (short)682622976;
				if (num != 0)
				{
				}
				num = (short)120455168;
				short num3 = num;
				return this.attachedASKs;
			}
			set
			{
				short num = (short)1983471537;
				short num2 = num;
				num = (short)1578721201;
				switch (num2 == num)
				{
				}
				num = (short)1762328577;
				if (num != 0)
				{
				}
				num = (short)372441088;
				if (num != 0)
				{
				}
				num = (short)1138950144;
				short num3 = num;
				this.attachedASKs = value;
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000457 RID: 1111 RVA: 0x000D792C File Offset: 0x000D5B2C
		// (remove) Token: 0x06000458 RID: 1112 RVA: 0x000D7A64 File Offset: 0x000D5C64
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
				int num;
				PropertyChangedEventHandler propertyChangedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1520697344;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_88;
					case 2:
					{
						num2 = (short)1422065664;
						short num3 = num2;
						goto IL_88;
					}
					}
					goto IL_1C;
					IL_88:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = (short)1536511716;
					short num4 = num2;
					num2 = (short)1189236452;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C;
					default:
						num2 = (short)2137260032;
						if (num2 != 0)
						{
						}
						num2 = (short)127336449;
						num = (int)((IntPtr)num2);
						break;
					}
				}
				return;
				IL_1C:
				num2 = (short)1595408385;
				if (num2 != 0)
				{
				}
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)931790850;
				num = (int)((IntPtr)num2);
				goto IL_0A;
			}
			[CompilerGenerated]
			remove
			{
				short num;
				for (;;)
				{
					num = (short)1768161280;
					short num2 = num;
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					PropertyChangedEventHandler propertyChangedEventHandler;
					for (;;)
					{
						IL_32:
						int num3;
						PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
							goto IL_FC;
						case 1:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)13565952;
								num3 = (int)((IntPtr)num);
								continue;
							}
							goto IL_AC;
						case 2:
							goto IL_AC;
						}
						break;
						IL_AC:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
						num = (short)712507393;
						num3 = (int)((IntPtr)num);
					}
					IL_44:
					propertyChangedEventHandler = this.PropertyChanged;
					num = (short)1796453594;
					short num4 = num;
					num = (short)100971738;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)320667648;
						if (num != 0)
						{
						}
						num = (short)416874498;
						int num3 = (int)((IntPtr)num);
						goto IL_32;
					}
					}
				}
				IL_FC:
				num = (short)638451713;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000D7B98 File Offset: 0x000D5D98
		internal void FireDataSourcePropertyChanged(string systemKeyData)
		{
			for (;;)
			{
				IL_00:
				short num = (short)164823040;
				short num2 = num;
				num = (short)27131906;
				int num3 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return;
					case 1:
					{
						this.PropertyChanged(this, new PropertyChangedEventArgs(systemKeyData));
						num = (short)1321517869;
						short num4 = num;
						num = (short)1050198829;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1327235072;
							if (num != 0)
							{
							}
							num = (short)2098135040;
							num3 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						num = (short)1586364417;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					}
					IL_81:
					if (this.PropertyChanged == null)
					{
						return;
					}
					num = (short)244842497;
					num3 = (int)((IntPtr)num);
				}
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000D7CC0 File Offset: 0x000D5EC0
		private void buttonQuery_Click(object sender, RoutedEventArgs e)
		{
			int a_ = 9;
			short num = (short)1721171968;
			switch (num)
			{
			default:
			{
				num = (short)1842085888;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_70;
						}
						continue;
					case 1:
						if (this.attachedKeys != null)
						{
							num = (short)468385799;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_91;
					case 2:
						goto IL_91;
					case 3:
						this.keysFromRadio.Clear();
						num = (short)1972699141;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
					{
						num = (short)1620180992;
						short num3 = num;
						num = (short)1280901121;
						if (num != 0)
						{
						}
						if (this.keysFromRadio != null)
						{
							num = (short)1571160067;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_9B2;
					}
					case 5:
						goto IL_9B2;
					case 6:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_1FA;
							}
							AccessRecord systemAccessLevel;
							for (;;)
							{
								IL_187:
								IEnumerator<SystemKeyData> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_7DA;
								case 1:
									num = (short)373293068;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									num = (short)1321205781;
									num2 = (int)((IntPtr)num);
									continue;
								case 3:
									this.getRadioDataForQueryRadioOperationFromRMC();
									num = (short)1305346056;
									num2 = (int)((IntPtr)num);
									continue;
								case 4:
									if (this.attachedASKs != null)
									{
										num = (short)1499594774;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_471;
								case 5:
									this.accessReadWriteDevice.progressPage.Hide();
									this.accessReadWriteDevice.progressPage.Close();
									num = (short)1977417728;
									num2 = (int)((IntPtr)num);
									continue;
								case 6:
									goto IL_6C9;
								case 7:
									goto IL_502;
								case 8:
									goto IL_8B8;
								case 9:
									if (this.attachedKeys != null)
									{
										num = (short)423034882;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_3AD;
								case 10:
									goto IL_37D;
								case 11:
									num = (short)1518993431;
									num2 = (int)((IntPtr)num);
									continue;
								case 12:
									if (this.openFromRMC)
									{
										num = (short)534249475;
										num2 = (int)((IntPtr)num);
										continue;
									}
									this.readTransportValue = this.accessReadWriteDevice.ReadWriteTransport;
									this.accessReadWriteDevice.ReadWriteTransport = 0;
									AppInfoManager.StatusMsgReport.Clear();
									this.accessReadWriteDevice.ReadWriteInProgress = true;
									num = (short)1299120143;
									num2 = (int)((IntPtr)num);
									continue;
								case 13:
									if (AppInfoManager.AppView == DifferentiatedUserViewType.Custom)
									{
										num = (short)898105354;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_6C9;
								case 14:
									try
									{
										num = (short)1095958532;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 1:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)265289731;
													num2 = (int)((IntPtr)num);
													continue;
												}
												SystemKeyData item = enumerator.Current;
												this.attachedASKs.Add(item);
												num = (short)1390673920;
												num2 = (int)((IntPtr)num);
												continue;
											}
											case 2:
												goto IL_309;
											case 3:
												num = (short)1235812354;
												num2 = (int)((IntPtr)num);
												continue;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_28B;
												}
												continue;
											}
											IL_2BA:
											num = (short)1012137985;
											num2 = (int)((IntPtr)num);
											continue;
											IL_28B:
											goto IL_2BA;
										}
										IL_309:
										goto IL_4C2;
									}
									finally
									{
										num = (short)564592642;
										num2 = (int)((IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_37A;
											case 1:
												enumerator.Dispose();
												num = (short)1319829504;
												num2 = (int)((IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_342;
												}
												continue;
											}
											IL_342:
											if (enumerator == null)
											{
												break;
											}
											num = (short)439746561;
											num2 = (int)((IntPtr)num);
										}
										IL_37A:;
									}
									goto IL_37D;
									IL_4C2:
									num = (short)1223753747;
									num2 = (int)((IntPtr)num);
									continue;
								case 15:
									if (!this.accessReadWriteDevice.progressPage.bCommSuccess)
									{
										num = (short)960757765;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_7DA;
								case 16:
									goto IL_8B8;
								case 17:
									goto IL_8D0;
								case 18:
									if (!(bool)Application.Current.Properties[FixedLengthStream.b("ꫨ蓪胬苮郰鷲釴믶郸闺飼볾儀倂", a_)])
									{
										num = (short)892993561;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_502;
								case 19:
									if (this.attachedASKs != null)
									{
										num = (short)324861963;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_8B8;
								case 20:
									goto IL_471;
								case 21:
									if (this.attachedKeys.Count > 0)
									{
										num = (short)402325528;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_3AD;
								case 22:
									this.attachedASKs.Clear();
									num = (short)2086600724;
									num2 = (int)((IntPtr)num);
									continue;
								case 23:
									if (this.attachedASKs.Count > 0)
									{
										num = (short)668925953;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_8B8;
								case 24:
								{
									SystemKeyData item2 = new SystemKeyData(KeySource.HARDWARE, FixedLengthStream.b("\ud9e8", a_), 0, KeyType.NONE, false, false, null);
									SystemKeyData item3 = new SystemKeyData(KeySource.HARDWARE, FixedLengthStream.b("\ud9e8", a_), 1, KeyType.ADVANCED_SYSTEM_KEY, false, false, systemAccessLevel);
									SystemKeyData item4 = new SystemKeyData(KeySource.HARDWARE, FixedLengthStream.b("\ud9e8", a_), 0, KeyType.ADVANCED_WACN_KEY, false, false, null);
									this.attachedKeys.Insert(0, item4);
									this.attachedKeys.Insert(0, item3);
									this.attachedKeys.Insert(0, item2);
									num = (short)1411973124;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 25:
									this.accessReadWriteDevice.progressPage.Show();
									num = (short)14680071;
									num2 = (int)((IntPtr)num);
									continue;
								case 26:
									goto IL_8B8;
								}
								goto IL_1FA;
								IL_37D:
								this.accessReadWriteDevice.SavedCurrentViewType = DifferentiatedUserViewType.Custom;
								AppInfoManager.AppView = DifferentiatedUserViewType.Full;
								num = (short)1014038534;
								num2 = (int)((IntPtr)num);
								continue;
								IL_3AD:
								this.UpdateControls(string.Empty, AppResources.Advanced_key_not_loaded_and_attached, true);
								this.queryRadioBtnWasClicked = false;
								num = (short)1330511898;
								num2 = (int)((IntPtr)num);
								continue;
								IL_471:
								enumerator = this.attachedKeys.GetEnumerator();
								num = (short)464650254;
								num2 = (int)((IntPtr)num);
								continue;
								IL_502:
								num = (short)989724685;
								num2 = (int)((IntPtr)num);
								continue;
								IL_6C9:
								this.accessReadWriteDevice.DocumentOperations.InitDocument();
								((App)Application.Current).TheDocument.FileNew();
								UndoManager.StopUndoRedo();
								UndoManager.Reset();
								ConstraintManager.Suspend();
								this.accessReadWriteDevice.bgReadWorker = new BackgroundWorker();
								this.accessReadWriteDevice.bgReadWorker.DoWork += delegate(object s, DoWorkEventArgs arg)
								{
									short num5 = (short)1280901120;
									short num6 = num5;
									num5 = (short)636157953;
									if (num5 != 0)
									{
									}
									num5 = (short)1184896637;
									short num7 = num5;
									num5 = (short)1851725437;
									switch (num7 == num5)
									{
									}
									num5 = (short)45023232;
									if (num5 != 0)
									{
									}
									this.accessReadWriteDevice.LaunchReadRadio((int)arg.Argument);
								};
								this.accessReadWriteDevice.bgReadWorker.RunWorkerAsync(0);
								num = (short)383516688;
								num2 = (int)((IntPtr)num);
								continue;
								IL_7DA:
								num = (short)421480730;
								short num4 = num;
								num = (short)158091546;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_6C9;
								default:
									num = (short)927924224;
									if (num != 0)
									{
									}
									this.accessReadWriteDevice.progressPage = new ProgressUpdate();
									this.accessReadWriteDevice.progressPage.ClearStatus();
									this.accessReadWriteDevice.progressPage.Title = AppResources.Read_Radio;
									num = (short)2115960850;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_8B8:
								num = (short)2104623121;
								num2 = (int)((IntPtr)num);
							}
							IL_8D0:
							return;
							IL_1FA:
							this.attachedKeys = SecurityManager.GetSysKeysFromLoadedAndAttachedASKs();
							systemAccessLevel = SecurityManager.GetSystemAccessLevel(1, KeyType.ADVANCED_SYSTEM_KEY);
							num = (short)530120713;
							num2 = (int)((IntPtr)num);
							goto IL_187;
						}
						catch
						{
							this.UpdateControls(string.Empty, AppResources.Query_radio_data_failed, true);
							this.queryRadioBtnWasClicked = false;
							return;
						}
						finally
						{
							num = (short)1222967300;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)507641857;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									if (!this.openFromRMC)
									{
										num = (short)1712717827;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_9B1;
								case 2:
									goto IL_9AF;
								case 3:
									this.accessReadWriteDevice.OnAppMenuClose(null, null);
									num = (short)1208025090;
									num2 = (int)((IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_92F;
									}
									continue;
								}
								IL_92F:
								if (!this.accessReadWriteDevice.CpgOpenFlag)
								{
									break;
								}
								num = (short)1559953408;
								num2 = (int)((IntPtr)num);
							}
							IL_9AF:
							IL_9B1:;
						}
						goto IL_9B2;
					case 7:
						this.attachedKeys.Clear();
						num = (short)191889410;
						num2 = (int)((IntPtr)num);
						continue;
					case 8:
						return;
					}
					IL_70:
					if (WriteProtect.readInProgress)
					{
						num = (short)942800904;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.UpdateControls(string.Empty, string.Empty, false);
					this.queryRadioBtnWasClicked = true;
					num = (short)539688964;
					num2 = (int)((IntPtr)num);
					continue;
					IL_91:
					num = (short)142540806;
					num2 = (int)((IntPtr)num);
					continue;
					IL_9B2:
					num = (short)1231355905;
					num2 = (int)((IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000D8734 File Offset: 0x000D6934
		private void buttonExit_Click(object sender, RoutedEventArgs e)
		{
			short num = (short)425844297;
			short num2 = num;
			num = (short)1100078665;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1398013952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)95485953;
			if (num != 0)
			{
			}
			num = (short)1324417024;
			if (num != 0)
			{
			}
			((Window)base.Parent).Close();
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x000D87F0 File Offset: 0x000D69F0
		private void buttonUpdate_Click(object sender, RoutedEventArgs e)
		{
			int a_ = 1;
			short num = (short)67502080;
			switch (num)
			{
			default:
			{
				num = (short)760545286;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					num = (short)1998829610;
					short num3 = num;
					num = (short)1772468266;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2074738688;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							if (!this.openFromRMC)
							{
								num = (short)2024013829;
								num2 = (int)((IntPtr)num);
								continue;
							}
							this.UpdateControls(string.Empty, string.Empty, false);
							num = (short)1858469889;
							num2 = (int)((IntPtr)num);
							continue;
						case 1:
							goto IL_D7;
						case 2:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_1D1;
								}
								for (;;)
								{
									IL_16E:
									switch (num2)
									{
									case 0:
										goto IL_83C;
									case 1:
										goto IL_824;
									case 2:
										num = (short)1126694928;
										num2 = (int)((IntPtr)num);
										continue;
									case 3:
										num = (short)1029242890;
										num2 = (int)((IntPtr)num);
										continue;
									case 4:
										this.writeDataForUpdateRadioDataOperationFromRMC();
										num = (short)1731526676;
										num2 = (int)((IntPtr)num);
										continue;
									case 5:
										if (this.attachedKeys != null)
										{
											num = (short)1603862530;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_313;
									case 6:
										this.accessReadWriteDevice.SavedCurrentViewType = DifferentiatedUserViewType.Custom;
										AppInfoManager.AppView = DifferentiatedUserViewType.Full;
										num = (short)161349653;
										num2 = (int)((IntPtr)num);
										continue;
									case 7:
										goto IL_24B;
									case 8:
										goto IL_69E;
									case 9:
									{
										bool flag;
										if (flag)
										{
											num = (short)5439491;
											num2 = (int)((IntPtr)num);
											continue;
										}
										this.UpdateControls(string.Empty, AppResources.Key_check_for_owner_system_ID, true);
										this.updateRadioDataBtnWasClicked = false;
										num = (short)1795948563;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 10:
										if (this.openFromRMC)
										{
											num = (short)143917060;
											num2 = (int)((IntPtr)num);
											continue;
										}
										this.readTransportValue = this.accessReadWriteDevice.ReadWriteTransport;
										this.accessReadWriteDevice.ReadWriteTransport = 0;
										AppInfoManager.StatusMsgReport.Clear();
										this.accessReadWriteDevice.ReadWriteInProgress = true;
										num = (short)858521618;
										num2 = (int)((IntPtr)num);
										continue;
									case 11:
										try
										{
											num = (short)1711734788;
											num2 = (int)((IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_521;
												case 1:
													num = (short)1474756608;
													num2 = (int)((IntPtr)num);
													continue;
												case 3:
												{
													IEnumerator<SystemKeyData> enumerator;
													if (!enumerator.MoveNext())
													{
														num = (short)1811152897;
														num2 = (int)((IntPtr)num);
														continue;
													}
													SystemKeyData systemKeyData = enumerator.Current;
													num = (short)1723072518;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 4:
													switch (0)
													{
													case 0:
														goto IL_3FE;
													}
													continue;
												case 5:
												{
													bool flag = true;
													num = (short)1444413442;
													num2 = (int)((IntPtr)num);
													continue;
												}
												case 6:
												{
													SystemKeyData systemKeyData;
													if (systemKeyData.SystemID == ((SystemKeyData)this.comboDlgOwnerSystemIDChoices.SelectedItem).SystemID)
													{
														num = (short)1332215816;
														num2 = (int)((IntPtr)num);
														continue;
													}
													break;
												}
												case 7:
												{
													SystemKeyData systemKeyData;
													if (systemKeyData.Type == ((SystemKeyData)this.comboDlgOwnerSystemIDChoices.SelectedItem).Type)
													{
														num = (short)106954757;
														num2 = (int)((IntPtr)num);
														continue;
													}
													break;
												}
												case 8:
													num = (short)166068231;
													num2 = (int)((IntPtr)num);
													continue;
												}
												IL_400:
												num = (short)645201923;
												num2 = (int)((IntPtr)num);
												continue;
												IL_3FE:
												goto IL_400;
											}
											IL_521:;
										}
										finally
										{
											num = (short)1539637248;
											num2 = (int)((IntPtr)num);
											for (;;)
											{
												IEnumerator<SystemKeyData> enumerator;
												switch (num2)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_555;
													}
													continue;
												case 1:
													goto IL_58B;
												case 2:
													enumerator.Dispose();
													num = (short)556597249;
													num2 = (int)((IntPtr)num);
													continue;
												}
												IL_555:
												if (enumerator == null)
												{
													break;
												}
												num = (short)81068034;
												num2 = (int)((IntPtr)num);
											}
											IL_58B:;
										}
										num = (short)26476553;
										num2 = (int)((IntPtr)num);
										continue;
									case 12:
										if (AppInfoManager.AppView == DifferentiatedUserViewType.Custom)
										{
											num = (short)1778974726;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_608;
									case 13:
										if (!(bool)Application.Current.Properties[FixedLengthStream.b("ꋠ賢裤諦裨藪觬ꏮ飰鷲郴듶꧸꣺", a_)])
										{
											num = (short)1047265302;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_69E;
									case 14:
										this.accessReadWriteDevice.progressPage.Hide();
										this.accessReadWriteDevice.progressPage.Close();
										num = (short)665255943;
										num2 = (int)((IntPtr)num);
										continue;
									case 15:
									{
										bool flag = false;
										IEnumerator<SystemKeyData> enumerator = this.attachedKeys.GetEnumerator();
										num = (short)1925054475;
										num2 = (int)((IntPtr)num);
										continue;
									}
									case 16:
										if (this.attachedKeys.Count > 0)
										{
											num = (short)786366479;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_313;
									case 17:
										goto IL_824;
									case 18:
										if (!this.accessReadWriteDevice.progressPage.bCommSuccess)
										{
											num = (short)975634446;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_24B;
									case 19:
										goto IL_824;
									case 20:
										goto IL_824;
									case 21:
										goto IL_608;
									case 22:
										this.accessReadWriteDevice.progressPage.Show();
										num = (short)1542586376;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_1D1;
									IL_24B:
									this.accessReadWriteDevice.progressPage = new ProgressUpdate();
									this.accessReadWriteDevice.progressPage.ClearStatus();
									this.accessReadWriteDevice.progressPage.Title = AppResources.Read_Radio;
									num = (short)1757806605;
									num2 = (int)((IntPtr)num);
									continue;
									IL_313:
									this.UpdateControls(string.Empty, AppResources.Advanced_key_not_loaded_and_attached, true);
									this.updateRadioDataBtnWasClicked = false;
									num = (short)461701137;
									num2 = (int)((IntPtr)num);
									continue;
									IL_608:
									this.accessReadWriteDevice.DocumentOperations.InitDocument();
									((App)Application.Current).TheDocument.FileNew();
									UndoManager.StopUndoRedo();
									UndoManager.Reset();
									ConstraintManager.Suspend();
									this.accessReadWriteDevice.bgReadWorker = new BackgroundWorker();
									this.accessReadWriteDevice.bgReadWorker.DoWork += delegate(object s, DoWorkEventArgs arg)
									{
										short num5 = (short)1665269760;
										short num6 = num5;
										num5 = (short)612753824;
										short num7 = num5;
										num5 = (short)212001184;
										switch (num7 == num5)
										{
										}
										num5 = (short)2119106561;
										if (num5 != 0)
										{
										}
										num5 = (short)304939008;
										if (num5 != 0)
										{
										}
										this.accessReadWriteDevice.LaunchReadRadio((int)arg.Argument);
									};
									this.accessReadWriteDevice.bgReadWorker.RunWorkerAsync(0);
									num = (short)1644888065;
									num2 = (int)((IntPtr)num);
									continue;
									IL_69E:
									num = (short)1806565388;
									num2 = (int)((IntPtr)num);
									continue;
									IL_824:
									num = (short)1757347840;
									num2 = (int)((IntPtr)num);
								}
								IL_83C:
								return;
								IL_1D1:
								this.attachedKeys = SecurityManager.GetSysKeysFromLoadedAndAttachedASKs();
								AccessRecord systemAccessLevel = SecurityManager.GetSystemAccessLevel(1, KeyType.ADVANCED_SYSTEM_KEY);
								SystemKeyData item = new SystemKeyData(KeySource.HARDWARE, FixedLengthStream.b("퇠", a_), 1, KeyType.ADVANCED_SYSTEM_KEY, false, false, systemAccessLevel);
								this.attachedKeys.Add(item);
								num = (short)345964549;
								num2 = (int)((IntPtr)num);
								goto IL_16E;
							}
							catch
							{
								this.UpdateControls(string.Empty, AppResources.Update_radio_data_failed, true);
								this.updateRadioDataBtnWasClicked = false;
								return;
							}
							finally
							{
								num = (short)1482883072;
								num2 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_89B;
										}
										continue;
									case 1:
										if (!this.openFromRMC)
										{
											num = (short)2096496643;
											num2 = (int)((IntPtr)num);
											continue;
										}
										goto IL_91B;
									case 2:
										num = (short)181141505;
										num2 = (int)((IntPtr)num);
										continue;
									case 3:
										this.accessReadWriteDevice.OnAppMenuClose(null, null);
										num = (short)2074542084;
										num2 = (int)((IntPtr)num);
										continue;
									case 4:
										goto IL_8E2;
									}
									IL_89B:
									if (!this.accessReadWriteDevice.CpgOpenFlag)
									{
										break;
									}
									num = (short)306446338;
									num2 = (int)((IntPtr)num);
								}
								IL_8E2:
								IL_91B:;
							}
							goto IL_91C;
						case 3:
							goto IL_996;
						case 4:
							return;
						case 5:
							goto IL_91C;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_B2;
							}
							continue;
						}
						IL_B2:
						if (WriteProtect.readInProgress)
						{
							num = (short)1201209348;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1334050816;
						num2 = (int)((IntPtr)num);
						continue;
						IL_91C:
						num = (short)861601792;
						short num4 = num;
						this.UpdateControls(AppResources.ID_UPDATING, AppResources.ID_DONOTDISCONNECT, false);
						num = (short)614006785;
						if (num != 0)
						{
						}
						num = (short)1418592259;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					IL_D7:
					this.updateRadioDataBtnWasClicked = true;
					num = (short)1356333058;
					num2 = (int)((IntPtr)num);
					continue;
					IL_996:
					goto IL_D7;
				}
				return;
			}
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000D91E4 File Offset: 0x000D73E4
		private void F1HelpCommandCanExcute(object sender, CanExecuteRoutedEventArgs e)
		{
			short num = (short)502595584;
			short num2 = num;
			num = (short)91312016;
			short num3 = num;
			num = (short)1414811536;
			switch (num3 == num)
			{
			}
			num = (short)120717313;
			if (num != 0)
			{
			}
			num = (short)1735131136;
			if (num != 0)
			{
			}
			e.CanExecute = true;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000D9298 File Offset: 0x000D7498
		private void onHelpButton_Click(object sender, RoutedEventArgs e)
		{
			int a_ = 9;
			short num;
			try
			{
				num = (short)752569525;
				short num2 = num;
				num = (short)2115325109;
				switch (num2 == num)
				{
				}
				num = (short)1765998592;
				if (num != 0)
				{
				}
				num = (short)150274049;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(FixedLengthStream.b("쫨틪\ud8ec\udfee闰郲쇴컶鷸", a_));
			}
			catch (Exception)
			{
			}
			num = (short)1959854080;
			short num3 = num;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000D937C File Offset: 0x000D757C
		private void SelectedKeyType_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_79;
			}
			int num;
			short num2;
			string a;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!this.queryRadioBtnWasClicked)
					{
						num2 = (short)268697618;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_BF;
				case 1:
					if (a == AppResources.Adv_System_Key_Column_Header_ID)
					{
						num2 = (short)74842132;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1293221898;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
					if (!this.accessReadWriteDevice.CpgOpenFlag)
					{
						num2 = (short)31522833;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_BF;
				case 3:
					goto IL_343;
				case 4:
					if (a == AppResources.Adv_System_Key_Column_Header_ID)
					{
						num2 = (short)552861718;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_4FA;
				case 5:
					num2 = (short)54460422;
					num = (int)((IntPtr)num2);
					continue;
				case 6:
					if (!this.queryRadioBtnWasClicked)
					{
						num2 = (short)188743689;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_343;
				case 7:
					num2 = (short)499253249;
					if (num2 != 0)
					{
					}
					this.comboDlgOwnerSystemIDChoices.SelectedValue = this.attachedASKs[2];
					num2 = (short)937295895;
					num = (int)((IntPtr)num2);
					continue;
				case 8:
				{
					if (!(a == AppResources.None_Id))
					{
						num2 = (short)1764491265;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)360247615;
					short num3 = num2;
					num2 = (short)2143351103;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_420;
					default:
						num2 = (short)930414592;
						if (num2 != 0)
						{
						}
						num2 = (short)1985347600;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 9:
					this.attachedASKs.Remove(this.sysKeyDataFromRadio);
					this.keysFromRadio.Remove(this.sysKeyDataFromRadio);
					this.FireDataSourcePropertyChanged(FixedLengthStream.b("꿭蓯蛱闳闵郷鿹飻귽秿焁瀃挅攇䄉椋眍挏", a_));
					num2 = (short)1576927235;
					num = (int)((IntPtr)num2);
					continue;
				case 10:
					if (a == AppResources.Adv_WACN_Key_Column_Header_ID)
					{
						num2 = (short)1311440903;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_48E;
				case 11:
					goto IL_48E;
				case 12:
					if (this.SelectedKeyType.SelectedValue != null)
					{
						num2 = (short)1546453006;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_1CE;
				case 13:
					goto IL_420;
				case 14:
					a = this.SelectedKeyType.SelectedValue.ToString();
					num2 = (short)324599821;
					num = (int)((IntPtr)num2);
					continue;
				case 15:
					goto IL_48E;
				case 16:
					this.comboDlgOwnerSystemIDChoices.SelectedValue = this.attachedASKs[0];
					num2 = (short)1788805131;
					num = (int)((IntPtr)num2);
					continue;
				case 17:
				{
					num2 = (short)933560320;
					short num4 = num2;
					num2 = (short)9830400;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 18:
					this.attachedASKs.Remove(this.sysKeyDataFromRadio);
					this.keysFromRadio.Remove(this.sysKeyDataFromRadio);
					this.FireDataSourcePropertyChanged(FixedLengthStream.b("꿭蓯蛱闳闵郷鿹飻귽秿焁瀃挅攇䄉椋眍挏", a_));
					num2 = (short)347275285;
					num = (int)((IntPtr)num2);
					continue;
				case 19:
					if (!this.accessReadWriteDevice.CpgOpenFlag)
					{
						num2 = (short)1538785285;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_343;
				case 20:
					this.comboDlgOwnerSystemIDChoices.SelectedValue = this.attachedASKs[1];
					num2 = (short)1367408655;
					num = (int)((IntPtr)num2);
					continue;
				case 21:
					goto IL_BF;
				case 22:
					goto IL_383;
				case 23:
					goto IL_48E;
				}
				goto IL_79;
				IL_BF:
				num2 = (short)177405971;
				num = (int)((IntPtr)num2);
				continue;
				IL_1CE:
				num2 = (short)2062417928;
				num = (int)((IntPtr)num2);
				continue;
				IL_420:
				goto IL_1CE;
				IL_343:
				num2 = (short)403374084;
				num = (int)((IntPtr)num2);
				continue;
				IL_48E:
				num2 = (short)1155727362;
				num = (int)((IntPtr)num2);
			}
			IL_383:
			this.boolDlgWriteProtect.IsEnabled = false;
			this.ribbonBarUpdateRadio.IsEnabled = true;
			return;
			IL_4FA:
			this.boolDlgWriteProtect.IsEnabled = false;
			this.ribbonBarUpdateRadio.IsEnabled = false;
			return;
			IL_79:
			a = "";
			num2 = (short)1169293324;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000D989C File Offset: 0x000D7A9C
		private void OwnerSystemID_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			short num = (short)1295450116;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_253;
				case 1:
					if (((SystemKeyData)this.comboDlgOwnerSystemIDChoices.SelectedValue).SystemID == 1)
					{
						num = (short)718340102;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_126;
				case 2:
					if (((SystemKeyData)this.comboDlgOwnerSystemIDChoices.SelectedValue).SystemID == 0)
					{
						num = (short)1779826688;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1160314881;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					num = (short)2052849671;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 5:
					this.boolDlgWriteProtect.Value = false;
					num = (short)1949827080;
					num2 = (int)((IntPtr)num);
					continue;
				case 6:
				{
					num = (short)772145152;
					short num3 = num;
					num = (short)1068166122;
					short num4 = num;
					num = (short)1934748650;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_80;
					default:
						goto IL_1D9;
					}
					break;
				}
				case 7:
					if (!this.queryRadioBtnWasClicked)
					{
						num = (short)1234436101;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_208;
				case 8:
					goto IL_208;
				}
				goto IL_49;
				IL_80:
				num = (short)597950467;
				num2 = (int)((IntPtr)num);
				continue;
				IL_49:
				num = (short)308740097;
				if (num != 0)
				{
				}
				if (this.comboDlgOwnerSystemIDChoices.SelectedValue != null)
				{
					goto IL_80;
				}
				goto IL_258;
				IL_208:
				num = (short)1665138690;
				num2 = (int)((IntPtr)num);
			}
			IL_126:
			this.boolDlgWriteProtect.IsEnabled = true;
			this.ribbonBarUpdateRadio.IsEnabled = true;
			return;
			IL_1D9:
			num = (short)1273626624;
			if (num != 0)
			{
			}
			this.boolDlgWriteProtect.IsEnabled = false;
			this.ribbonBarUpdateRadio.IsEnabled = true;
			return;
			IL_253:
			this.boolDlgWriteProtect.IsEnabled = false;
			this.ribbonBarUpdateRadio.IsEnabled = false;
			return;
			IL_258:
			this.boolDlgWriteProtect.IsEnabled = false;
			this.ribbonBarUpdateRadio.IsEnabled = false;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000D9B1C File Offset: 0x000D7D1C
		private void accessReadWriteDevice_readRadioComplete(bool status)
		{
			short num = (short)918224896;
			short num2 = num;
			num = (short)1332181812;
			short num3 = num;
			num = (short)236092212;
			switch (num3 == num)
			{
			}
			num = (short)1770127360;
			if (num != 0)
			{
			}
			num = (short)1219952641;
			if (num != 0)
			{
			}
			base.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new WindowMain.ReadRadioCompleted(this.getRadioDataForQueryRadioOperation), status);
			base.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new WindowMain.ReadRadioCompleted(this.writeDataForUpdateRadioDataOperation), status);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000D9C04 File Offset: 0x000D7E04
		private void getRadioDataForQueryRadioOperation(bool status)
		{
			int a_ = 10;
			short num = (short)1769275392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				string strFooterMessage = string.Empty;
				if (this.queryRadioBtnWasClicked)
				{
					num = (short)1231880192;
					short num3 = num;
					try
					{
						num = (short)384630805;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							bool flag;
							SystemKeyData systemKeyData;
							int selectedIndex;
							IEnumerator enumerator;
							RadioInformation radioInformation;
							IEnumerator<SystemKeyData> enumerator2;
							switch (num2)
							{
							case 0:
							{
								num = (short)1056948559;
								short num4 = num;
								num = (short)1752547663;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_6A5;
								default:
								{
									num = (short)477102080;
									if (num != 0)
									{
									}
									string uivalue;
									if (uivalue == AcgResources.ID_ADVANCEDWACNKEY)
									{
										num = (short)1998127130;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_6D2;
								}
								}
								break;
							}
							case 1:
								goto IL_6A5;
							case 2:
								goto IL_6D2;
							case 3:
								if (!flag)
								{
									num = (short)328728586;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)727187460;
								num2 = (int)((IntPtr)num);
								continue;
							case 4:
								if (systemKeyData.Type == KeyType.ADVANCED_SYSTEM_KEY)
								{
									num = (short)664076311;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)434438156;
								num2 = (int)((IntPtr)num);
								continue;
							case 5:
								goto IL_B40;
							case 6:
							{
								string uivalue;
								if (uivalue == AcgResources.ID_ADVANCEDSYSTEMKEY)
								{
									num = (short)1718943753;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)99352576;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 7:
								goto IL_30D;
							case 8:
								goto IL_30D;
							case 9:
							{
								RadioWide radioWide;
								int id = radioWide.General.RadWideGeneralOwnerSystemID_A37153Value;
								this.sysKeyDataFromRadio = new SystemKeyData(KeySource.HARDWARE, FixedLengthStream.b("\udae9", a_), id, KeyType.ADVANCED_SYSTEM_KEY, false, false, null);
								num = (short)774176787;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 10:
								this.attachedASKs.Add(this.sysKeyDataFromRadio);
								this.keysFromRadio.Add(this.sysKeyDataFromRadio);
								this.FireDataSourcePropertyChanged(FixedLengthStream.b("ꯩ飫髭釯釱鳳鏵鳷꧹藻跽瓿朁椃䴅洇猉缋", a_));
								num = (short)1418657812;
								num2 = (int)((IntPtr)num);
								continue;
							case 11:
								try
								{
									num = (short)1790312455;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_612;
										case 1:
										{
											SystemKeyData systemKeyData2;
											selectedIndex = this.comboDlgOwnerSystemIDChoices.Items.IndexOf(systemKeyData2);
											num = (short)1872429060;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 2:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)2068840453;
												num2 = (int)((IntPtr)num);
												continue;
											}
											SystemKeyData systemKeyData2 = (SystemKeyData)enumerator.Current;
											num = (short)1229783043;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 3:
										{
											SystemKeyData systemKeyData2;
											if (systemKeyData2.SystemID == systemKeyData.SystemID)
											{
												num = (short)445317128;
												num2 = (int)((IntPtr)num);
												continue;
											}
											break;
										}
										case 5:
											num = (short)481820672;
											num2 = (int)((IntPtr)num);
											continue;
										case 6:
										{
											SystemKeyData systemKeyData2;
											if (systemKeyData2.Type == systemKeyData.Type)
											{
												num = (short)1031274497;
												num2 = (int)((IntPtr)num);
												continue;
											}
											break;
										}
										case 7:
											switch (0)
											{
											case 0:
												goto IL_4FB;
											}
											continue;
										case 8:
											num = (short)85327878;
											num2 = (int)((IntPtr)num);
											continue;
										}
										IL_548:
										num = (short)1361772546;
										num2 = (int)((IntPtr)num);
										continue;
										IL_4FB:
										goto IL_548;
									}
									IL_612:
									goto IL_AEA;
								}
								finally
								{
									switch (0)
									{
									case 0:
										goto IL_634;
									}
									IDisposable disposable;
									for (;;)
									{
										IL_621:
										switch (num2)
										{
										case 0:
											disposable.Dispose();
											num = (short)1630797825;
											num2 = (int)((IntPtr)num);
											continue;
										case 1:
											goto IL_68A;
										case 2:
											if (disposable != null)
											{
												num = (short)758054912;
												num2 = (int)((IntPtr)num);
												continue;
											}
											goto IL_68C;
										}
										goto IL_634;
									}
									IL_68A:
									IL_68C:
									goto EndFinally_31;
									IL_634:
									disposable = (enumerator as IDisposable);
									num = (short)1779302402;
									num2 = (int)((IntPtr)num);
									goto IL_621;
									EndFinally_31:;
								}
								goto IL_68D;
								IL_AEA:
								this.comboDlgOwnerSystemIDChoices.SelectedIndex = selectedIndex;
								num = (short)1925316632;
								num2 = (int)((IntPtr)num);
								continue;
							case 12:
								if (systemKeyData.Type == KeyType.ADVANCED_WACN_KEY)
								{
									num = (short)1305346066;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_455;
							case 13:
								goto IL_B40;
							case 14:
								goto IL_455;
							case 15:
								goto IL_68D;
							case 16:
								if (this.sysKeyDataFromRadio.Type == KeyType.ADVANCED_WACN_KEY)
								{
									num = (short)1621884959;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_30D;
							case 17:
								this.SelectedKeyType.SelectedValue = AppResources.Adv_System_Key_Column_Header_ID;
								num = (short)2050490375;
								num2 = (int)((IntPtr)num);
								continue;
							case 18:
								this.SelectedKeyType.SelectedValue = AppResources.Adv_WACN_Key_Column_Header_ID;
								num = (short)1807024142;
								num2 = (int)((IntPtr)num);
								continue;
							case 19:
								goto IL_6D2;
							case 20:
								if (this.sysKeyDataFromRadio.Type == KeyType.ADVANCED_SYSTEM_KEY)
								{
									num = (short)578682897;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)1724842000;
								num2 = (int)((IntPtr)num);
								continue;
							case 21:
								switch (0)
								{
								case 0:
									goto IL_115;
								}
								continue;
							case 22:
							{
								string radInfoGeneralModelNumber_A8539Value;
								string radInfoFLASHportFLASHcode_A8132Value;
								if (!RadioOperationValidator.IsRadioConvOnly(radInfoGeneralModelNumber_A8539Value, radInfoFLASHportFLASHcode_A8132Value, false))
								{
									num = (short)811597839;
									num2 = (int)((IntPtr)num);
									continue;
								}
								strFooterMessage = AppResources.Cnv_check_for_owner_system_ID;
								num = (short)1266810893;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 23:
								num = (short)751042561;
								if (num != 0)
								{
								}
								this.SelectedKeyType.SelectedValue = AppResources.Adv_System_Key_Column_Header_ID;
								num = (short)260046878;
								num2 = (int)((IntPtr)num);
								continue;
							case 24:
								goto IL_B40;
							case 25:
							{
								RadioWide radioWide;
								this.boolDlgWriteProtect.IsChecked = new bool?(radioWide.Depot.AdvancedExternalMicOnlyValue && radioWide.General.RadWideGeneralASKRequired_A37152Value);
								num = (short)1932132358;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 26:
							{
								RadioWide radioWide;
								int id = radioWide.General.RadWideGeneralOwnerWACNID_A38656Value;
								this.sysKeyDataFromRadio = new SystemKeyData(KeySource.HARDWARE, FixedLengthStream.b("\udae9", a_), id, KeyType.ADVANCED_WACN_KEY, false, false, null);
								num = (short)516947970;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 27:
							{
								this.accessReadWriteDevice.ReadWriteTransport = this.readTransportValue;
								radioInformation = (FeatureManager.GetFeature(2049)[0] as RadioInformation);
								string radInfoGeneralModelNumber_A8539Value = radioInformation.General.RadInfoGeneralModelNumber_A8539Value;
								string radInfoFLASHportFLASHcode_A8132Value = radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132Value;
								num = (short)1801584662;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 28:
							{
								RadioWide radioWide = FeatureManager.GetFeature(2045)[0] as RadioWide;
								string uivalue = radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663.UIValue;
								num = (short)1847394329;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 29:
								goto IL_B5A;
							case 30:
								goto IL_455;
							case 31:
								this.SelectedKeyType.SelectedValue = AppResources.Adv_WACN_Key_Column_Header_ID;
								num = (short)1498218504;
								num2 = (int)((IntPtr)num);
								continue;
							case 32:
								goto IL_B40;
							case 33:
								goto IL_B40;
							case 34:
								try
								{
									num = (short)697565191;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_29B;
										case 1:
											goto IL_282;
										case 2:
											goto IL_282;
										case 3:
										{
											SystemKeyData systemKeyData3;
											if (systemKeyData3.SystemIDHex == this.sysKeyDataFromRadio.SystemIDHex)
											{
												num = (short)1791033352;
												num2 = (int)((IntPtr)num);
												continue;
											}
											break;
										}
										case 4:
											num = (short)840040451;
											num2 = (int)((IntPtr)num);
											continue;
										case 5:
										{
											SystemKeyData systemKeyData3;
											if (systemKeyData3.Type == this.sysKeyDataFromRadio.Type)
											{
												num = (short)440401924;
												num2 = (int)((IntPtr)num);
												continue;
											}
											break;
										}
										case 6:
										{
											if (!enumerator2.MoveNext())
											{
												num = (short)1929379841;
												num2 = (int)((IntPtr)num);
												continue;
											}
											SystemKeyData systemKeyData3 = enumerator2.Current;
											num = (short)584581125;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 7:
											switch (0)
											{
											case 0:
												goto IL_182;
											}
											continue;
										case 8:
										{
											flag = true;
											SystemKeyData systemKeyData3;
											systemKeyData = systemKeyData3;
											num = (short)1608777730;
											num2 = (int)((IntPtr)num);
											continue;
										}
										}
										IL_246:
										num = (short)1751515142;
										num2 = (int)((IntPtr)num);
										continue;
										IL_182:
										goto IL_246;
										IL_282:
										num = (short)772079616;
										num2 = (int)((IntPtr)num);
									}
									IL_29B:
									goto IL_720;
								}
								finally
								{
									num = (short)818282498;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											enumerator2.Dispose();
											num = (short)1791950849;
											num2 = (int)((IntPtr)num);
											continue;
										case 1:
											goto IL_30A;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_2D2;
											}
											continue;
										}
										IL_2D2:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)894828544;
										num2 = (int)((IntPtr)num);
									}
									IL_30A:;
								}
								goto IL_30D;
								IL_720:
								num = (short)965672963;
								num2 = (int)((IntPtr)num);
								continue;
							}
							IL_115:
							if (status)
							{
								num = (short)1306460187;
								num2 = (int)((IntPtr)num);
								continue;
							}
							strFooterMessage = AppResources.Query_radio_data_failed;
							num = (short)1352859653;
							num2 = (int)((IntPtr)num);
							continue;
							IL_30D:
							this.comboDlgOwnerSystemIDChoices.SelectedIndex = this.comboDlgOwnerSystemIDChoices.Items.Count - 1;
							num = (short)985137185;
							num2 = (int)((IntPtr)num);
							continue;
							IL_455:
							selectedIndex = -1;
							enumerator = ((IEnumerable)this.comboDlgOwnerSystemIDChoices.Items).GetEnumerator();
							num = (short)422707211;
							num2 = (int)((IntPtr)num);
							continue;
							IL_68D:
							num = (short)911147009;
							num2 = (int)((IntPtr)num);
							continue;
							IL_6A5:
							if (radioInformation.Labtool.RadInfoLabtoolQA01648ASKEnable_A37150Value)
							{
								num = (short)167444508;
								num2 = (int)((IntPtr)num);
								continue;
							}
							strFooterMessage = AppResources.Legacy_check_for_owner_system_ID;
							num = (short)1354956832;
							num2 = (int)((IntPtr)num);
							continue;
							IL_6D2:
							flag = false;
							systemKeyData = new SystemKeyData(KeySource.HARDWARE, FixedLengthStream.b("\udae9", a_), 0, KeyType.NONE, false, false, null);
							enumerator2 = this.attachedASKs.GetEnumerator();
							num = (short)1165230114;
							num2 = (int)((IntPtr)num);
							continue;
							IL_B40:
							num = (short)1146748957;
							num2 = (int)((IntPtr)num);
						}
						IL_B5A:;
					}
					catch
					{
						strFooterMessage = AppResources.Query_radio_data_failed;
					}
					finally
					{
						num = (short)1467809794;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								this.accessReadWriteDevice.OnAppMenuClose(null, null);
								num = (short)1677656065;
								num2 = (int)((IntPtr)num);
								continue;
							case 1:
								goto IL_BE5;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_B9D;
								}
								continue;
							}
							IL_B9D:
							if (!this.accessReadWriteDevice.CpgOpenFlag)
							{
								break;
							}
							num = (short)1913257984;
							num2 = (int)((IntPtr)num);
						}
						IL_BE5:
						this.UpdateControls(string.Empty, strFooterMessage, true);
						this.queryRadioBtnWasClicked = false;
					}
				}
				return;
			}
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000DA874 File Offset: 0x000D8A74
		private void getRadioDataForQueryRadioOperationFromRMC()
		{
			int a_ = 8;
			short num = (short)1553661952;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)113115136;
				short num3 = num;
				string strFooterMessage = string.Empty;
				ASTRORadio astroradio = null;
				APXCodeplug apxcodeplug = null;
				if (this.queryRadioBtnWasClicked)
				{
					try
					{
						switch (0)
						{
						case 0:
							goto IL_FA;
						}
						for (;;)
						{
							IL_73:
							SystemKeyData systemKeyData;
							IEnumerator<SystemKeyData> enumerator;
							bool flag;
							int selectedIndex;
							IEnumerator enumerator2;
							switch (num2)
							{
							case 0:
								goto IL_AB6;
							case 1:
								if (systemKeyData.Type == KeyType.ADVANCED_SYSTEM_KEY)
								{
									num = (short)1923612692;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)1501495298;
								num2 = (int)((IntPtr)num);
								continue;
							case 2:
								if (systemKeyData.Type == KeyType.ADVANCED_WACN_KEY)
								{
									num = (short)1392443408;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_19A;
							case 3:
								goto IL_666;
							case 4:
							{
								string a = string.Empty;
								Radio radioByDeviceUuid = ServerAccessor.GetInstance(true, false).GetRadioByDeviceUuid(astroradio.DeviceUuid, true);
								apxcodeplug = (ServerAccessor.GetInstance(true, false).GetCodeplug(radioByDeviceUuid.WorkingCodeplugUuid.Value) as APXCodeplug);
								int? num4 = apxcodeplug.OwnerAdvKeyType;
								int num5 = 0;
								num = (short)103481356;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 5:
								goto IL_AB6;
							case 6:
								goto IL_19A;
							case 7:
								if (this.sysKeyDataFromRadio.Type == KeyType.ADVANCED_SYSTEM_KEY)
								{
									num = (short)378339359;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)983051;
								num2 = (int)((IntPtr)num);
								continue;
							case 8:
								goto IL_ACE;
							case 9:
								goto IL_1CC;
							case 10:
							{
								int? num4 = apxcodeplug.OwnerWacnId;
								int value = num4.Value;
								this.sysKeyDataFromRadio = new SystemKeyData(KeySource.HARDWARE, FixedLengthStream.b("\ud8e7", a_), value, KeyType.ADVANCED_WACN_KEY, false, false, null);
								num = (short)240648195;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 11:
								if (this.sysKeyDataFromRadio.Type == KeyType.ADVANCED_WACN_KEY)
								{
									num = (short)1318780954;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_995;
							case 12:
							{
								int? num4;
								int num5;
								if (num4.GetValueOrDefault() == num5 & num4 != null)
								{
									num = (short)527761421;
									num2 = (int)((IntPtr)num);
									continue;
								}
								string a = AcgResources.ID_ADVANCEDWACNKEY;
								num = (short)802488329;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 13:
							{
								string a = AcgResources.ID_ADVANCEDSYSTEMKEY;
								num = (short)1544093720;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 14:
								goto IL_AB6;
							case 15:
								goto IL_666;
							case 16:
								goto IL_881;
							case 17:
								goto IL_19A;
							case 18:
								goto IL_995;
							case 19:
								try
								{
									num = (short)1881079812;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											SystemKeyData systemKeyData2;
											if (systemKeyData2.SystemIDHex == this.sysKeyDataFromRadio.SystemIDHex)
											{
												num = (short)197263362;
												num2 = (int)((IntPtr)num);
												continue;
											}
											break;
										}
										case 1:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)2146566147;
												num2 = (int)((IntPtr)num);
												continue;
											}
											SystemKeyData systemKeyData2 = enumerator.Current;
											num = (short)595197960;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 2:
										{
											flag = true;
											SystemKeyData systemKeyData2;
											systemKeyData = systemKeyData2;
											num = (short)2009661446;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 3:
											goto IL_7F5;
										case 4:
											switch (0)
											{
											case 0:
												goto IL_6FA;
											}
											continue;
										case 5:
											num = (short)1370095616;
											num2 = (int)((IntPtr)num);
											continue;
										case 6:
											goto IL_7F5;
										case 7:
											goto IL_80D;
										case 8:
										{
											SystemKeyData systemKeyData2;
											if (systemKeyData2.Type == this.sysKeyDataFromRadio.Type)
											{
												num = (short)1482555397;
												num2 = (int)((IntPtr)num);
												continue;
											}
											break;
										}
										}
										IL_766:
										num = (short)1572601857;
										num2 = (int)((IntPtr)num);
										continue;
										IL_6FA:
										goto IL_766;
										IL_7F5:
										num = (short)764149767;
										num2 = (int)((IntPtr)num);
									}
									IL_80D:
									goto IL_546;
								}
								finally
								{
									num = (short)1516896256;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_845;
											}
											continue;
										case 1:
											enumerator.Dispose();
											num = (short)1445986306;
											num2 = (int)((IntPtr)num);
											continue;
										case 2:
											goto IL_87E;
										}
										IL_845:
										if (enumerator == null)
										{
											break;
										}
										num = (short)743440385;
										num2 = (int)((IntPtr)num);
									}
									IL_87E:;
								}
								goto IL_881;
								IL_546:
								num = (short)1872691222;
								num2 = (int)((IntPtr)num);
								continue;
							case 20:
								this.SelectedKeyType.SelectedValue = AppResources.Adv_System_Key_Column_Header_ID;
								num = (short)1174994950;
								num2 = (int)((IntPtr)num);
								continue;
							case 21:
								if (!RadioOperationValidator.IsRadioConvOnly(astroradio.ModelNumber, astroradio.AstroPurchasedFlashCode, false))
								{
									num = (short)90898436;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_523;
							case 22:
								if (!flag)
								{
									num = (short)2029649945;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)608239617;
								num2 = (int)((IntPtr)num);
								continue;
							case 23:
							{
								string a;
								if (a == AcgResources.ID_ADVANCEDSYSTEMKEY)
								{
									num = (short)1553006620;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)1486618651;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 24:
								goto IL_1CC;
							case 25:
								this.attachedASKs.Add(this.sysKeyDataFromRadio);
								this.keysFromRadio.Add(this.sysKeyDataFromRadio);
								this.FireDataSourcePropertyChanged(FixedLengthStream.b("ꧧ黩飫迭鏯髱釳鋵꯷菹迻諽旿漁伃挅焇礉", a_));
								num = (short)654508039;
								num2 = (int)((IntPtr)num);
								continue;
							case 26:
								this.SelectedKeyType.SelectedValue = AppResources.Adv_WACN_Key_Column_Header_ID;
								num = (short)725483538;
								num2 = (int)((IntPtr)num);
								continue;
							case 27:
							{
								string a;
								if (a == AcgResources.ID_ADVANCEDWACNKEY)
								{
									num = (short)1711210506;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_666;
							}
							case 28:
							{
								num = (short)1664617310;
								short num6 = num;
								num = (short)908528478;
								switch ((num6 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_995;
								default:
								{
									num = (short)1870987264;
									if (num != 0)
									{
									}
									int? num4 = apxcodeplug.HomeSystemId;
									int value = num4.Value;
									this.sysKeyDataFromRadio = new SystemKeyData(KeySource.HARDWARE, FixedLengthStream.b("\ud8e7", a_), value, KeyType.ADVANCED_SYSTEM_KEY, false, false, null);
									num = (short)530513935;
									num2 = (int)((IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 29:
								try
								{
									num = (short)1648754692;
									num2 = (int)((IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											SystemKeyData systemKeyData3;
											if (systemKeyData3.SystemID == systemKeyData.SystemID)
											{
												num = (short)2012938242;
												num2 = (int)((IntPtr)num);
												continue;
											}
											break;
										}
										case 1:
										{
											SystemKeyData systemKeyData3;
											if (systemKeyData3.Type == systemKeyData.Type)
											{
												num = (short)1439891459;
												num2 = (int)((IntPtr)num);
												continue;
											}
											break;
										}
										case 2:
											num = (short)1573126145;
											num2 = (int)((IntPtr)num);
											continue;
										case 3:
										{
											SystemKeyData systemKeyData3;
											selectedIndex = this.comboDlgOwnerSystemIDChoices.Items.IndexOf(systemKeyData3);
											num = (short)2123169798;
											num2 = (int)((IntPtr)num);
											continue;
										}
										case 4:
											switch (0)
											{
											case 0:
												goto IL_384;
											}
											continue;
										case 5:
											num = (short)961544199;
											num2 = (int)((IntPtr)num);
											continue;
										case 7:
											goto IL_4A6;
										case 8:
										{
											if (!enumerator2.MoveNext())
											{
												num = (short)1094975493;
												num2 = (int)((IntPtr)num);
												continue;
											}
											SystemKeyData systemKeyData3 = (SystemKeyData)enumerator2.Current;
											num = (short)112132096;
											num2 = (int)((IntPtr)num);
											continue;
										}
										}
										IL_44D:
										num = (short)1298399240;
										num2 = (int)((IntPtr)num);
										continue;
										IL_384:
										goto IL_44D;
									}
									IL_4A6:
									goto IL_9F4;
								}
								finally
								{
									switch (0)
									{
									case 0:
										goto IL_4C8;
									}
									IDisposable disposable;
									for (;;)
									{
										IL_4B5:
										switch (num2)
										{
										case 0:
											if (disposable != null)
											{
												num = (short)1075511297;
												num2 = (int)((IntPtr)num);
												continue;
											}
											goto IL_522;
										case 1:
											disposable.Dispose();
											num = (short)996278274;
											num2 = (int)((IntPtr)num);
											continue;
										case 2:
											goto IL_520;
										}
										goto IL_4C8;
									}
									IL_520:
									IL_522:
									goto EndFinally_27;
									IL_4C8:
									disposable = (enumerator2 as IDisposable);
									num = (short)1630339072;
									num2 = (int)((IntPtr)num);
									goto IL_4B5;
									EndFinally_27:;
								}
								goto IL_523;
								IL_9F4:
								this.comboDlgOwnerSystemIDChoices.SelectedIndex = selectedIndex;
								num = (short)1464008709;
								num2 = (int)((IntPtr)num);
								continue;
							case 30:
								goto IL_995;
							case 31:
								this.SelectedKeyType.SelectedValue = AppResources.Adv_System_Key_Column_Header_ID;
								num = (short)1528299550;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_FA;
							IL_19A:
							selectedIndex = -1;
							enumerator2 = ((IEnumerable)this.comboDlgOwnerSystemIDChoices.Items).GetEnumerator();
							num = (short)691535901;
							num2 = (int)((IntPtr)num);
							continue;
							IL_1CC:
							this.boolDlgWriteProtect.IsChecked = apxcodeplug.DisableWriteProtect;
							num = (short)1195835415;
							num2 = (int)((IntPtr)num);
							continue;
							IL_523:
							strFooterMessage = AppResources.Cnv_check_for_owner_system_ID;
							num = (short)834338816;
							num2 = (int)((IntPtr)num);
							continue;
							IL_666:
							flag = false;
							systemKeyData = new SystemKeyData(KeySource.HARDWARE, FixedLengthStream.b("\ud8e7", a_), 0, KeyType.NONE, false, false, null);
							enumerator = this.attachedASKs.GetEnumerator();
							num = (short)1233911827;
							num2 = (int)((IntPtr)num);
							continue;
							IL_881:
							this.SelectedKeyType.SelectedValue = AppResources.Adv_WACN_Key_Column_Header_ID;
							num = (short)1890713617;
							num2 = (int)((IntPtr)num);
							continue;
							IL_995:
							this.comboDlgOwnerSystemIDChoices.SelectedIndex = this.comboDlgOwnerSystemIDChoices.Items.Count - 1;
							num = (short)1665859598;
							num2 = (int)((IntPtr)num);
							continue;
							IL_AB6:
							num = (short)2061828104;
							num2 = (int)((IntPtr)num);
						}
						IL_ACE:
						goto IL_B09;
						IL_FA:
						astroradio = this.devices[0];
						num = (short)846266389;
						num2 = (int)((IntPtr)num);
						goto IL_73;
					}
					catch (Exception ex)
					{
						strFooterMessage = AppResources.Query_Radio_Failed + FixedLengthStream.b("죧쫩", a_) + ex.Message;
					}
					finally
					{
						this.UpdateControls(string.Empty, strFooterMessage, true);
						this.queryRadioBtnWasClicked = false;
					}
				}
				IL_B09:
				num = (short)256180225;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x000DB414 File Offset: 0x000D9614
		private void writeDataForUpdateRadioDataOperation(bool status)
		{
			int a_ = 18;
			short num = (short)712245248;
			switch (num)
			{
			default:
			{
				string strFooterMessage = string.Empty;
				bool flag = false;
				if (this.updateRadioDataBtnWasClicked)
				{
					num = (short)468385792;
					short num2 = num;
					try
					{
						num = (short)359202824;
						int num3 = (int)((IntPtr)num);
						int nTxPort;
						for (;;)
						{
							RadioWide radioWide;
							bool? isChecked;
							switch (num3)
							{
							case 0:
							{
								AcpField<bool> advancedExternalMicOnly = radioWide.Depot.AdvancedExternalMicOnly;
								isChecked = this.boolDlgWriteProtect.IsChecked;
								advancedExternalMicOnly.SetValue(isChecked.Value);
								num = (short)1318453270;
								num3 = (int)((IntPtr)num);
								continue;
							}
							case 1:
								goto IL_7F2;
							case 2:
							{
								RadioInformation radioInformation;
								if (radioInformation.Labtool.RadInfoLabtoolQA01648ASKEnable_A37150Value)
								{
									num = (short)305790982;
									num3 = (int)((IntPtr)num);
									continue;
								}
								strFooterMessage = AppResources.Legacy_check_for_owner_system_ID;
								flag = true;
								num = (short)1676607522;
								num3 = (int)((IntPtr)num);
								continue;
							}
							case 3:
							{
								KeyType radWideGeneralOwnerAdvancedKeyType_A38663Value;
								if (radWideGeneralOwnerAdvancedKeyType_A38663Value == KeyType.ADVANCED_WACN_KEY)
								{
									num = (short)1837629470;
									num3 = (int)((IntPtr)num);
									continue;
								}
								goto IL_2FC;
							}
							case 4:
								this.accessReadWriteDevice.bgWriteWorker = new BackgroundWorker();
								this.accessReadWriteDevice.bgWriteWorker.RunWorkerCompleted += this.bgWriteWorker_RunWorkerCompleted;
								nTxPort = this.accessReadWriteDevice.ReadWriteTransport;
								this.accessReadWriteDevice.bgWriteWorker.DoWork += delegate(object s, DoWorkEventArgs arg)
								{
									short num5 = (short)822804480;
									short num6 = num5;
									num5 = (short)1087247061;
									short num7 = num5;
									num5 = (short)1405752021;
									switch (num7 == num5)
									{
									}
									num5 = (short)1224671233;
									if (num5 != 0)
									{
									}
									num5 = (short)636092416;
									if (num5 != 0)
									{
									}
									Thread.Sleep(10000);
									this.accessReadWriteDevice.LaunchWriteRadio(nTxPort, true);
								};
								this.accessReadWriteDevice.bgWriteWorker.RunWorkerAsync(0);
								num = (short)2359327;
								num3 = (int)((IntPtr)num);
								continue;
							case 5:
								goto IL_83F;
							case 6:
							{
								num = (short)251194128;
								short num4 = num;
								num = (short)207547152;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)125435904;
									if (num != 0)
									{
									}
									break;
								}
								radioWide = (FeatureManager.GetFeature(2045)[0] as RadioWide);
								SystemKeyData systemKeyData = new SystemKeyData(KeySource.HARDWARE, FixedLengthStream.b("싱", a_), 0, KeyType.NONE, false, false, null);
								KeyType radWideGeneralOwnerAdvancedKeyType_A38663Value = (KeyType)radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663Value;
								int homeSysId = 0;
								num = (short)968687645;
								num3 = (int)((IntPtr)num);
								continue;
							}
							case 7:
							{
								int homeSysId = radioWide.General.RadWideGeneralOwnerSystemID_A37153Value;
								num = (short)466419724;
								num3 = (int)((IntPtr)num);
								continue;
							}
							case 8:
								switch (0)
								{
								case 0:
									goto IL_130;
								}
								continue;
							case 9:
								radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663.SetValue(0);
								radioWide.General.RadWideGeneralOwnerSystemID_A37153.SetValue(((SystemKeyData)this.comboDlgOwnerSystemIDChoices.SelectedValue).SystemID);
								num = (short)181403649;
								num3 = (int)((IntPtr)num);
								continue;
							case 10:
								if (this.SelectedKeyType.SelectedValue.ToString() == AppResources.Adv_WACN_Key_Column_Header_ID)
								{
									num = (short)1660092441;
									num3 = (int)((IntPtr)num);
									continue;
								}
								goto IL_7F2;
							case 11:
								goto IL_2FC;
							case 12:
								goto IL_2FC;
							case 13:
								goto IL_7F2;
							case 14:
								if (isChecked.Value)
								{
									num = (short)1649999872;
									num3 = (int)((IntPtr)num);
									continue;
								}
								goto IL_52E;
							case 15:
							{
								SystemKeyData systemKeyData;
								if (systemKeyData.AccessLevelType != KeyAccessLevelType.UNLM_ACC)
								{
									num = (short)1326448658;
									num3 = (int)((IntPtr)num);
									continue;
								}
								goto IL_392;
							}
							case 16:
								goto IL_83F;
							case 17:
								if (this.SelectedKeyType.SelectedValue.ToString() == AppResources.Adv_System_Key_Column_Header_ID)
								{
									num = (short)638713865;
									num3 = (int)((IntPtr)num);
									continue;
								}
								num = (short)1214185482;
								num3 = (int)((IntPtr)num);
								continue;
							case 18:
								num = (short)337313818;
								num3 = (int)((IntPtr)num);
								continue;
							case 19:
							{
								string radInfoGeneralModelNumber_A8539Value;
								string radInfoFLASHportFLASHcode_A8132Value;
								if (!RadioOperationValidator.IsRadioConvOnly(radInfoGeneralModelNumber_A8539Value, radInfoFLASHportFLASHcode_A8132Value, false))
								{
									num = (short)374407204;
									num3 = (int)((IntPtr)num);
									continue;
								}
								strFooterMessage = AppResources.Cnv_check_for_owner_system_ID;
								flag = true;
								num = (short)1565917189;
								num3 = (int)((IntPtr)num);
								continue;
							}
							case 20:
								goto IL_392;
							case 21:
								goto IL_858;
							case 22:
								goto IL_52E;
							case 23:
								goto IL_83F;
							case 24:
								isChecked = this.boolDlgWriteProtect.IsChecked;
								num = (short)1322582030;
								num3 = (int)((IntPtr)num);
								continue;
							case 25:
								radioWide.General.RadWideGeneralOwnerAdvancedKeyType_A38663.SetValue(1);
								radioWide.General.RadWideGeneralOwnerWACNID_A38656.SetValue(((SystemKeyData)this.comboDlgOwnerSystemIDChoices.SelectedValue).SystemID);
								num = (short)1309540365;
								num3 = (int)((IntPtr)num);
								continue;
							case 26:
							{
								SystemKeyData systemKeyData;
								if (systemKeyData.AccessLevelType == KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
								{
									num = (short)1819672596;
									num3 = (int)((IntPtr)num);
									continue;
								}
								strFooterMessage = AppResources.Unlimited_key_check_for_radio_owner_system_ID;
								flag = true;
								num = (short)872808464;
								num3 = (int)((IntPtr)num);
								continue;
							}
							case 27:
								if (this.accessReadWriteDevice.SaveCodeplug())
								{
									num = (short)1742077956;
									num3 = (int)((IntPtr)num);
									continue;
								}
								goto IL_83F;
							case 28:
								goto IL_83F;
							case 29:
							{
								KeyType radWideGeneralOwnerAdvancedKeyType_A38663Value;
								if (radWideGeneralOwnerAdvancedKeyType_A38663Value == KeyType.ADVANCED_SYSTEM_KEY)
								{
									num = (short)319553543;
									num3 = (int)((IntPtr)num);
									continue;
								}
								num = (short)1036255235;
								num3 = (int)((IntPtr)num);
								continue;
							}
							case 30:
							{
								int homeSysId = radioWide.General.RadWideGeneralOwnerWACNID_A38656Value;
								num = (short)411566091;
								num3 = (int)((IntPtr)num);
								continue;
							}
							case 31:
								goto IL_83F;
							case 32:
								if (!radioWide.Depot.AdvancedExternalMicOnly.Value)
								{
									num = (short)1235353624;
									num3 = (int)((IntPtr)num);
									continue;
								}
								goto IL_52E;
							case 33:
							{
								KeyType radWideGeneralOwnerAdvancedKeyType_A38663Value;
								SystemKeyData systemKeyData;
								int homeSysId;
								if (RadioAccessValidatorBase.CheckIfOwnerASKIsAttached(homeSysId, radWideGeneralOwnerAdvancedKeyType_A38663Value, this.attachedKeys, out systemKeyData))
								{
									num = (short)1241776163;
									num3 = (int)((IntPtr)num);
									continue;
								}
								strFooterMessage = AppResources.Unlimited_key_check_for_radio_owner_system_ID;
								flag = true;
								num = (short)1237188636;
								num3 = (int)((IntPtr)num);
								continue;
							}
							case 34:
								goto IL_83F;
							case 35:
								num = (short)666107919;
								num3 = (int)((IntPtr)num);
								continue;
							case 36:
								num = (short)1035599874;
								num3 = (int)((IntPtr)num);
								continue;
							case 37:
							{
								this.accessReadWriteDevice.ReadWriteTransport = this.readTransportValue;
								RadioInformation radioInformation = FeatureManager.GetFeature(2049)[0] as RadioInformation;
								string radInfoGeneralModelNumber_A8539Value = radioInformation.General.RadInfoGeneralModelNumber_A8539Value;
								string radInfoFLASHportFLASHcode_A8132Value = radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132Value;
								num = (short)2144993299;
								num3 = (int)((IntPtr)num);
								continue;
							}
							}
							IL_130:
							if (status)
							{
								num = (short)2074673189;
								num3 = (int)((IntPtr)num);
								continue;
							}
							strFooterMessage = AppResources.Update_radio_data_failed;
							flag = true;
							num = (short)444858391;
							num3 = (int)((IntPtr)num);
							continue;
							IL_2FC:
							num = (short)1847001121;
							num3 = (int)((IntPtr)num);
							continue;
							IL_392:
							num = (short)476512273;
							num3 = (int)((IntPtr)num);
							continue;
							IL_52E:
							AcpField<bool> radWideGeneralASKRequired_A = radioWide.General.RadWideGeneralASKRequired_A37152;
							isChecked = this.boolDlgWriteProtect.IsChecked;
							radWideGeneralASKRequired_A.SetValue(isChecked.Value);
							num = (short)923271195;
							num3 = (int)((IntPtr)num);
							continue;
							IL_7F2:
							num = (short)671612960;
							num3 = (int)((IntPtr)num);
							continue;
							IL_83F:
							num = (short)465240085;
							num3 = (int)((IntPtr)num);
						}
						IL_858:;
					}
					catch
					{
						strFooterMessage = AppResources.Update_radio_data_failed;
						flag = true;
					}
					finally
					{
						num = (short)1500184581;
						int num3 = (int)((IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_92A;
							case 1:
								goto IL_950;
							case 2:
								this.accessReadWriteDevice.OnAppMenuClose(null, null);
								num = (short)1487273984;
								num3 = (int)((IntPtr)num);
								continue;
							case 3:
								num = (short)354549764;
								num3 = (int)((IntPtr)num);
								continue;
							case 4:
								if (this.accessReadWriteDevice.CpgOpenFlag)
								{
									num = (short)1540423682;
									num3 = (int)((IntPtr)num);
									continue;
								}
								goto IL_92A;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_8AA;
								}
								continue;
							}
							IL_8AA:
							if (flag)
							{
								num = (short)44564483;
								num3 = (int)((IntPtr)num);
								continue;
							}
							goto IL_978;
							IL_92A:
							this.UpdateControls(string.Empty, strFooterMessage, true);
							num = (short)954204161;
							num3 = (int)((IntPtr)num);
						}
						IL_950:
						num = (short)628555777;
						if (num != 0)
						{
						}
						IL_978:
						this.updateRadioDataBtnWasClicked = false;
					}
				}
				return;
			}
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x000DBDD8 File Offset: 0x000D9FD8
		private void writeDataForUpdateRadioDataOperationFromRMC()
		{
			int a_ = 16;
			short num = (short)131661824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)652148737;
				if (num != 0)
				{
				}
				num = (short)453115904;
				short num3 = num;
				string strFooterMessage = string.Empty;
				bool flag = false;
				ASTRORadio astroradio = null;
				APXCodeplug apxcodeplug = null;
				if (this.updateRadioDataBtnWasClicked)
				{
					try
					{
						switch (0)
						{
						case 0:
							goto IL_12B;
						}
						int num5;
						for (;;)
						{
							IL_9C:
							bool? flag2;
							switch (num2)
							{
							case 0:
							{
								KeyType value;
								if (value == KeyType.ADVANCED_WACN_KEY)
								{
									num = (short)423886870;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_279;
							}
							case 1:
								goto IL_2EA;
							case 2:
							{
								KeyType value;
								int homeSysId;
								SystemKeyData systemKeyData;
								if (RadioAccessValidatorBase.CheckIfOwnerASKIsAttached(homeSysId, value, this.attachedKeys, out systemKeyData))
								{
									num = (short)2021457923;
									num2 = (int)((IntPtr)num);
									continue;
								}
								strFooterMessage = AppResources.Unlimited_key_check_for_radio_owner_system_ID;
								flag = true;
								num = (short)1679032346;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 3:
								num = (short)115867662;
								num2 = (int)((IntPtr)num);
								continue;
							case 4:
							{
								int homeSysId = apxcodeplug.HomeSystemId.Value;
								num = (short)545325068;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 5:
								apxcodeplug.OwnerAdvKeyType = new int?(0);
								apxcodeplug.HomeSystemId = new int?(((SystemKeyData)this.comboDlgOwnerSystemIDChoices.SelectedValue).SystemID);
								num = (short)1159004167;
								num2 = (int)((IntPtr)num);
								continue;
							case 6:
								goto IL_2EA;
							case 7:
								goto IL_5FD;
							case 8:
								goto IL_20A;
							case 9:
							{
								KeyType value;
								if (value == KeyType.ADVANCED_SYSTEM_KEY)
								{
									num = (short)2082340868;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)565116928;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 10:
								if (!flag2.Value)
								{
									num = (short)1565261852;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_6ED;
							case 11:
								if (this.SelectedKeyType.SelectedValue.ToString() == AppResources.Adv_WACN_Key_Column_Header_ID)
								{
									num = (short)75235351;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_5FD;
							case 12:
								goto IL_279;
							case 13:
								goto IL_333;
							case 14:
							{
								SystemKeyData systemKeyData;
								if (systemKeyData.AccessLevelType != KeyAccessLevelType.UNLM_ACC)
								{
									num = (short)44105755;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_333;
							}
							case 15:
								if (this.SelectedKeyType.SelectedValue.ToString() == AppResources.Adv_System_Key_Column_Header_ID)
								{
									num = (short)1810497541;
									num2 = (int)((IntPtr)num);
									continue;
								}
								num = (short)407175179;
								num2 = (int)((IntPtr)num);
								continue;
							case 16:
								goto IL_20A;
							case 17:
								goto IL_75A;
							case 18:
								goto IL_5FD;
							case 19:
							{
								APXCodeplug apxcodeplug2 = apxcodeplug;
								flag2 = this.boolDlgWriteProtect.IsChecked;
								apxcodeplug2.DisableWriteProtect = new bool?(flag2.Value);
								num = (short)361889817;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 20:
								if (!RadioOperationValidator.IsRadioConvOnly(astroradio.ModelNumber, astroradio.AstroPurchasedFlashCode, false))
								{
									num = (short)321126432;
									num2 = (int)((IntPtr)num);
									continue;
								}
								strFooterMessage = AppResources.Cnv_check_for_owner_system_ID;
								flag = true;
								num = (short)297664541;
								num2 = (int)((IntPtr)num);
								continue;
							case 21:
								if (flag2.Value)
								{
									num = (short)989331475;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_6ED;
							case 22:
							{
								num = (short)940526583;
								short num4 = num;
								num = (short)2062896119;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_19B;
								default:
								{
									num = (short)1426784256;
									if (num != 0)
									{
									}
									int homeSysId = apxcodeplug.OwnerWacnId.Value;
									num = (short)1009319969;
									num2 = (int)((IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 23:
								apxcodeplug.OwnerAdvKeyType = new int?(1);
								apxcodeplug.OwnerWacnId = new int?(((SystemKeyData)this.comboDlgOwnerSystemIDChoices.SelectedValue).SystemID);
								num = (short)249888786;
								num2 = (int)((IntPtr)num);
								continue;
							case 24:
								num = (short)265224209;
								num2 = (int)((IntPtr)num);
								continue;
							case 25:
								goto IL_6ED;
							case 26:
								goto IL_19B;
							case 27:
								num = (short)947519518;
								num2 = (int)((IntPtr)num);
								continue;
							case 28:
								flag2 = this.boolDlgWriteProtect.IsChecked;
								num = (short)532873237;
								num2 = (int)((IntPtr)num);
								continue;
							case 29:
								goto IL_20A;
							case 30:
							{
								SystemKeyData systemKeyData;
								if (systemKeyData.AccessLevelType == KeyAccessLevelType.UNLM_ACC_WITHOUT_WP)
								{
									num = (short)741474317;
									num2 = (int)((IntPtr)num);
									continue;
								}
								strFooterMessage = AppResources.Unlimited_key_check_for_radio_owner_system_ID;
								flag = true;
								num = (short)30605328;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 31:
								if (num5 >= this.devices.Count)
								{
									num = (short)561905688;
									num2 = (int)((IntPtr)num);
									continue;
								}
								astroradio = this.devices[num5];
								num = (short)1534525460;
								num2 = (int)((IntPtr)num);
								continue;
							case 32:
							{
								SystemKeyData systemKeyData = new SystemKeyData(KeySource.HARDWARE, FixedLengthStream.b("샯", a_), 0, KeyType.NONE, false, false, null);
								Radio radioByDeviceUuid = ServerAccessor.GetInstance(true, false).GetRadioByDeviceUuid(astroradio.DeviceUuid, true);
								apxcodeplug = (ServerAccessor.GetInstance(true, false).GetCodeplug(radioByDeviceUuid.WorkingCodeplugUuid.Value) as APXCodeplug);
								KeyType value = (KeyType)apxcodeplug.OwnerAdvKeyType.Value;
								int homeSysId = 0;
								num = (short)608632841;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 33:
								goto IL_279;
							}
							goto IL_12B;
							IL_20A:
							num5++;
							num = (short)111280129;
							num2 = (int)((IntPtr)num);
							continue;
							IL_19B:
							goto IL_20A;
							IL_279:
							num = (short)1431699458;
							num2 = (int)((IntPtr)num);
							continue;
							IL_2EA:
							num = (short)325058591;
							num2 = (int)((IntPtr)num);
							continue;
							IL_333:
							num = (short)1707868175;
							num2 = (int)((IntPtr)num);
							continue;
							IL_5FD:
							flag2 = apxcodeplug.DisableWriteProtect;
							num = (short)382926858;
							num2 = (int)((IntPtr)num);
							continue;
							IL_6ED:
							APXCodeplug apxcodeplug3 = apxcodeplug;
							flag2 = this.boolDlgWriteProtect.IsChecked;
							apxcodeplug3.AskRequired = new bool?(flag2.Value);
							ASTRORadio astroradio2 = astroradio;
							flag2 = apxcodeplug.AskRequired;
							astroradio2.AskRequired = flag2.Value;
							num = (short)1434714120;
							num2 = (int)((IntPtr)num);
						}
						IL_75A:
						return;
						IL_12B:
						num5 = 0;
						num = (short)1058537478;
						num2 = (int)((IntPtr)num);
						goto IL_9C;
					}
					catch (Exception ex)
					{
						strFooterMessage = AppResources.Update_Radio_Failed + FixedLengthStream.b("탯틱", a_) + ex.Message;
						flag = true;
					}
					finally
					{
						num = (short)133365762;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								strFooterMessage = AppResources.Changes_Saved;
								astroradio.ChangeIndicator = 1;
								astroradio.RadioStatus = RadioStatus.Modified;
								num = (short)1334050817;
								num2 = (int)((IntPtr)num);
								continue;
							case 1:
								goto IL_7FE;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_7BA;
								}
								continue;
							}
							IL_7BA:
							if (flag)
							{
								break;
							}
							num = (short)213712896;
							num2 = (int)((IntPtr)num);
						}
						IL_7FE:
						this.UpdateControls(string.Empty, strFooterMessage, true);
						this.updateRadioDataBtnWasClicked = false;
					}
				}
				return;
			}
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000DC630 File Offset: 0x000DA830
		private void bgWriteWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			short num = (short)401342465;
			if (num != 0)
			{
			}
			num = (short)237043714;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)751278193;
					short num3 = num;
					num = (short)470718577;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1649934336;
						if (num != 0)
						{
						}
						this.accessReadWriteDevice.OnAppMenuClose(null, null);
						num = (short)18481153;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_EB;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				}
				IL_56:
				if (!this.accessReadWriteDevice.CpgOpenFlag)
				{
					goto IL_115;
				}
				num = (short)643170304;
				num2 = (int)((IntPtr)num);
			}
			IL_EB:
			num = (short)344784896;
			short num4 = num;
			IL_115:
			this.UpdateControls(string.Empty, string.Empty, true);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000DC764 File Offset: 0x000DA964
		private void UpdateControls(string strLblMessage, string strFooterMessage, bool bEnable)
		{
			short num = (short)103135608;
			short num2 = num;
			num = (short)1969797496;
			switch (num2 == num)
			{
			}
			num = (short)473104384;
			short num3 = num;
			num = (short)1068171265;
			if (num != 0)
			{
			}
			num = (short)2078408704;
			if (num != 0)
			{
			}
			this.ribbonBarQueryRadio.IsEnabled = bEnable;
			this.ribbonBarUpdateRadio.IsEnabled = bEnable;
			this.buttonExit.IsEnabled = bEnable;
			WriteProtect.readInProgress = !bEnable;
			this.acplblWarning.Content = strLblMessage;
			this.TxtBlkOutput.Text = strFooterMessage;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000DC850 File Offset: 0x000DAA50
		private void HLinkGeneralClick(object sender, RoutedEventArgs e)
		{
			short num = (short)1144782848;
			short num2 = num;
			string key = (string)((Hyperlink)sender).Tag;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				AcpExpander acpExpander;
				for (;;)
				{
					IL_45:
					int num3;
					switch (num3)
					{
					case 0:
						goto IL_10E;
					case 1:
						goto IL_132;
					case 2:
						acpExpander.IsExpanded = true;
						num = (short)606011392;
						num3 = (int)((IntPtr)num);
						continue;
					case 3:
						if (!acpExpander.IsExpanded)
						{
							num = (short)316342274;
							num3 = (int)((IntPtr)num);
							continue;
						}
						goto IL_10E;
					}
					goto IL_5B;
					IL_10E:
					acpExpander.BringIntoView();
					acpExpander.Focus();
					num = (short)997392385;
					num3 = (int)((IntPtr)num);
				}
				IL_132:
				goto IL_137;
				IL_5B:
				acpExpander = this.expanderlist[key];
				num = (short)1532148549;
				short num4 = num;
				num = (short)1535556421;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_45;
				default:
				{
					num = (short)45744128;
					if (num != 0)
					{
					}
					num = (short)369623043;
					int num3 = (int)((IntPtr)num);
					goto IL_45;
				}
				}
			}
			catch (Exception)
			{
			}
			IL_137:
			num = (short)620036097;
			if (num != 0)
			{
			}
		}

		// Token: 0x040002AC RID: 684
		private WindowMain _parent;

		// Token: 0x040002AD RID: 685
		private string initialLanguageSelection;

		// Token: 0x040002AE RID: 686
		private MackinawCPS.Properties.Settings parentWindowSettings;

		// Token: 0x040002AF RID: 687
		protected RadioSecurityData radSecData;

		// Token: 0x040002B0 RID: 688
		private ObservableCollection<SystemKeyData> attachedASKs;

		// Token: 0x040002B1 RID: 689
		private Collection<SystemKeyData> attachedKeys;

		// Token: 0x040002B2 RID: 690
		private Collection<SystemKeyData> keysFromRadio;

		// Token: 0x040002B3 RID: 691
		private SystemKeyData sysKeyDataFromRadio;

		// Token: 0x040002B4 RID: 692
		private WindowMain accessReadWriteDevice;

		// Token: 0x040002B5 RID: 693
		public static bool readInProgress;

		// Token: 0x040002B6 RID: 694
		private bool queryRadioBtnWasClicked;

		// Token: 0x040002B7 RID: 695
		private bool updateRadioDataBtnWasClicked;

		// Token: 0x040002B8 RID: 696
		private int readTransportValue;

		// Token: 0x040002B9 RID: 697
		private Dictionary<string, AcpExpander> expanderlist;

		// Token: 0x040002BA RID: 698
		private bool openFromRMC;

		// Token: 0x040002BB RID: 699
		private ObservableCollection<bool> isOwnerSystemIDSupported;

		// Token: 0x040002BC RID: 700
		private ObservableCollection<ASTRORadio> devices;

		// Token: 0x040002D2 RID: 722
		[NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
