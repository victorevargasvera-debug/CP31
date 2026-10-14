using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Threading;
using ACPBrowser;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.StatusMessage;
using AcpCommonLib.UndoRedo;
using AcpUI;
using AcpUILib;
using CommonResources;
using Infragistics.Windows.DataPresenter;
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
using SpecialFeatures.RadioLanguagePack;
using SpecialFeatures.Security;

namespace SpecialFeatures.CloneExpress
{
	// Token: 0x0200019C RID: 412
	public class PageCloneExpress : global::AcpUI.AcpPageFeature, global::AcpUILib.IAcpPageFeature, global::System.ComponentModel.INotifyPropertyChanged, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x001C60D8 File Offset: 0x001C42D8
		// (set) Token: 0x060013A0 RID: 5024 RVA: 0x001C6188 File Offset: 0x001C4388
		public string SerNum
		{
			get
			{
				short num = (short)2075262976;
				short num2 = num;
				num = (short)1095190896;
				short num3 = num;
				num = (short)347556208;
				switch (num3 == num)
				{
				}
				num = (short)782499841;
				if (num != 0)
				{
				}
				num = (short)1630208000;
				if (num != 0)
				{
				}
				return this.o;
			}
			set
			{
				int a_ = 4;
				short num = (short)2011561985;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						this.o = value.ToUpper();
						this.FirePropertyChanged(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풆力쎌搜ﲐ", a_));
						num = (short)359861948;
						short num3 = num;
						num = (short)1351356092;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1583677440;
							if (num != 0)
							{
							}
							num = (short)673775617;
							if (num != 0)
							{
							}
							num = (short)697827330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 2:
						return;
					}
					IL_39:
					num = (short)413401088;
					short num4 = num;
					if (!(this.o != value))
					{
						break;
					}
					num = (short)470286336;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060013A1 RID: 5025 RVA: 0x001C62D0 File Offset: 0x001C44D0
		// (remove) Token: 0x060013A2 RID: 5026 RVA: 0x001C640C File Offset: 0x001C460C
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
							num2 = (short)14221313;
							if (num2 != 0)
							{
							}
							num2 = (short)1814888450;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_B1;
					case 1:
						goto IL_B1;
					case 2:
						goto IL_12B;
					}
					goto IL_1C;
					IL_B1:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.p, value2, propertyChangedEventHandler2);
					num2 = (short)264175616;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_12B:
				return;
				IL_1C:
				num2 = (short)1676298016;
				short num3 = num2;
				num2 = (short)508184352;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num2 = (short)252248064;
					short num4 = num2;
					num2 = (short)1389494272;
					if (num2 != 0)
					{
					}
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler = this.p;
					num2 = (short)347013121;
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
							num2 = (short)901775362;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_D7;
					case 1:
						goto IL_D7;
					case 2:
						goto IL_127;
					}
					goto IL_1C;
					IL_D7:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.p, value2, propertyChangedEventHandler2);
					num2 = (short)499515392;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_127:
				return;
				IL_1C:
				num2 = (short)1953169409;
				if (num2 != 0)
				{
				}
				num2 = (short)910760378;
				short num3 = num2;
				num2 = (short)1106188730;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num2 = (short)514457600;
					short num4 = num2;
					break;
				}
				}
				num2 = (short)1541537792;
				if (num2 != 0)
				{
				}
				propertyChangedEventHandler = this.p;
				num2 = (short)1301086209;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x001C6544 File Offset: 0x001C4744
		public void FirePropertyChanged(string name)
		{
			short num = (short)95748097;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)282722304;
				short num3 = num;
				switch (num2)
				{
				case 0:
				{
					this.p(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
					num = (short)1626521528;
					short num4 = num;
					num = (short)739753912;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)634519552;
						if (num != 0)
						{
						}
						num = (short)948174850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					num = (short)941948929;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_81;
					}
					continue;
				case 2:
					return;
				}
				IL_81:
				if (this.p == null)
				{
					break;
				}
				num = (short)1304428544;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00003815 File Offset: 0x00001A15
		public PageCloneExpress()
		{
			this.InitializeComponent();
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x001C666C File Offset: 0x001C486C
		public override void SetDataContext()
		{
			short num = (short)962789376;
			short num2 = num;
			num = (short)280712905;
			short num3 = num;
			num = (short)1586190025;
			switch (num3 == num)
			{
			}
			num = (short)1135149056;
			if (num != 0)
			{
			}
			num = (short)1681195009;
			if (num != 0)
			{
			}
			this.ExpSerialNumber.DataContext = this;
			this.TrunkingIDDataPresenter.DataSource = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2064);
			this.CnvSysIDDataPresenter.DataSource = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2053);
			this.ExpIndAstroOtarRadioIDList.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2021);
			this.IndAstroOtardRadioIDDataPresenter.DataSource = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2055);
			this.DataProfilesDataPresenter.DataSource = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2054);
			this.ExpDataWide.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066];
			global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = (global::AcpCommonLib.IAcpFeatureSection)this.ExpDataWide.DataContext;
			this.ExpUserInfo.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2045);
			this.ExpBluetooth.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10630];
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x001C6810 File Offset: 0x001C4A10
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)688783363;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)26542081;
				if (num != 0)
				{
				}
				num = (short)966283558;
				short num3 = num;
				num = (short)584536358;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)715522048;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						if (!base.IsKeyboardFocusWithin)
						{
							num = (short)1824587785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_E7;
					case 2:
						return;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_BF;
						}
						continue;
					case 4:
						this.l = ((global::System.Windows.Interop.HwndSource)global::System.Windows.PresentationSource.FromVisual(this)).Handle;
						num = (short)1586233354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (base.Parent is global::System.Windows.Window)
						{
							num = (short)498270212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14F;
					case 6:
						num = (short)233701381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!this.a)
						{
							num = (short)805175304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E7;
					case 8:
						this.ExpSerialNumber.DataContext = this;
						this.TrunkingIDDataPresenter.DataContext = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2064);
						this.a(this.TrunkingIDDataPresenter.DataContext);
						this.CnvSysIDDataPresenter.DataContext = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2053);
						this.a(this.CnvSysIDDataPresenter.DataContext);
						this.ExpIndAstroOtarRadioIDList.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2021);
						this.a(this.ExpIndAstroOtarRadioIDList.DataContext);
						this.IndAstroOtardRadioIDDataPresenter.DataContext = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2055);
						this.a(this.IndAstroOtardRadioIDDataPresenter.DataContext);
						this.DataProfilesDataPresenter.DataContext = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2054);
						this.a(this.DataProfilesDataPresenter.DataContext);
						this.ExpDataWide.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066];
						this.a(this.ExpDataWide.DataContext);
						this.ExpUserInfo.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2045);
						this.a(this.ExpUserInfo.DataContext);
						this.ExpBluetooth.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10630];
						this.a(this.ExpBluetooth.DataContext);
						this.progressBar2.Value = 0.0;
						global::SpecialFeatures.Comms.Comms.displayOTAP += this.CloneW_DisplayOTAP;
						this.a = true;
						this.k = global::SpecialFeatures.Security.RadioAccessValidator.CacheCodeplugSecurityFields(out this.d, out this.e, out this.f, out this.g, out this.h, out this.j, out this.i);
						num = (short)2108620801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						num = (short)793903104;
						short num4 = num;
						global::System.Windows.Input.Keyboard.Focus(this);
						num = (short)591462402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_14F;
					}
					IL_BF:
					if (base.Parent != null)
					{
						num = (short)444923910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_14F:
					this.b = new global::SpecialFeatures.Clone_Configuration.Common.RadioEjectTimer();
					this.b.Tick += this.OnRadioEjectTimeOut;
					num = (short)1491927047;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E7:
				num = (short)1997602816;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x001C6C58 File Offset: 0x001C4E58
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
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
				switch (num)
				{
				case 0:
					global::SpecialFeatures.Security.RadioAccessValidator.RestoreCachedCodeplugSecurityFields(this.d, this.e, this.f, this.g, this.h, this.j, this.i);
					num2 = (short)1182793730;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (this.k)
					{
						num2 = (short)180420608;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_163;
				case 2:
					goto IL_161;
				}
				goto IL_1C;
			}
			IL_161:
			goto IL_163;
			IL_1C:
			num2 = (short)287550339;
			short num3 = num2;
			num2 = (short)277064579;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_163:
				this.b.Tick -= this.OnRadioEjectTimeOut;
				return;
			default:
			{
				num2 = (short)1048576;
				short num4 = num2;
				num2 = (short)1964244993;
				if (num2 != 0)
				{
				}
				num2 = (short)525664256;
				if (num2 != 0)
				{
				}
				global::SpecialFeatures.Comms.Comms.displayOTAP -= this.CloneW_DisplayOTAP;
				this.CloneButton.IsEnabled = true;
				global::SpecialFeatures.Clone_Configuration.Common.Win32APIs.EnableCloseMenuItem(this.l, true);
				num2 = (short)1806303233;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x001C6DE0 File Offset: 0x001C4FE0
		internal void OnCloneExpressClone(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1862233365;
			short num2 = num;
			num = (short)212036885;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1649016833;
				if (num != 0)
				{
				}
				num = (short)749142016;
				if (num != 0)
				{
				}
				num = (short)2128674816;
				short num3 = num;
				bool status = false;
				global::AcpCommonLib.AppInfoManager.StatusMsgReport.Clear();
				if (global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.OpenValidateDlg((global::System.Windows.Window)base.Parent))
				{
					this.CloneButton.IsEnabled = false;
					global::SpecialFeatures.Clone_Configuration.Common.Win32APIs.EnableCloseMenuItem(this.l, false);
					new global::Motorola.MackinawCPS.CoreFeatures.PackExec.PackUnpackExecutor().PrePackHandler();
					new global::System.Threading.Thread(delegate()
					{
						int a_ = 19;
						short num4 = (short)1381564416;
						int num5 = (int)num4;
						switch (num5)
						{
						default:
						{
							switch (0)
							{
							case 0:
								goto IL_94;
							}
							global::SpecialFeatures.Comms.Clone clone;
							for (;;)
							{
								IL_31:
								switch (num5)
								{
								case 0:
									if (status)
									{
										num4 = (short)756940816;
										num5 = (int)((global::System.IntPtr)num4);
										continue;
									}
									goto IL_399;
								case 1:
									goto IL_3FC;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
									if (global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.ContainsField(radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsername_A9169))
									{
										num4 = (short)1745092613;
										num5 = (int)((global::System.IntPtr)num4);
										continue;
									}
									goto IL_54B;
								}
								case 3:
									num4 = (short)1756364817;
									num5 = (int)((global::System.IntPtr)num4);
									continue;
								case 4:
									goto IL_1F4;
								case 5:
									this.CallMainUiProcess(0.0, global::CommonResources.AppResources.Soft_ID_Username_In_Radio_Causes_Invalid);
									num4 = (short)294977555;
									num5 = (int)((global::System.IntPtr)num4);
									continue;
								case 6:
									if (global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.HasFields)
									{
										num4 = (short)2138308619;
										num5 = (int)((global::System.IntPtr)num4);
										continue;
									}
									num4 = (short)2134704142;
									num5 = (int)((global::System.IntPtr)num4);
									continue;
								case 7:
									goto IL_57C;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
									if (radioWideRecset.Count >= 1)
									{
										num4 = (short)1079574549;
										num5 = (int)((global::System.IntPtr)num4);
										continue;
									}
									goto IL_1F4;
								}
								case 9:
									if (!status)
									{
										num4 = (short)658374657;
										num5 = (int)((global::System.IntPtr)num4);
										continue;
									}
									num4 = (short)2040135692;
									num5 = (int)((global::System.IntPtr)num4);
									continue;
								case 10:
									goto IL_442;
								case 11:
								{
									num4 = (short)1827864576;
									short num6 = num4;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset = global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = null;
									num4 = (short)1689780232;
									num5 = (int)((global::System.IntPtr)num4);
									continue;
								}
								case 12:
									if (status)
									{
										num4 = (short)1762656257;
										if (num4 != 0)
										{
										}
										num4 = (short)518586390;
										num5 = (int)((global::System.IntPtr)num4);
										continue;
									}
									return;
								case 13:
									num4 = (short)509476866;
									num5 = (int)((global::System.IntPtr)num4);
									continue;
								case 14:
									try
									{
										status = clone.CloneRadio(true, global::SpecialFeatures.Comms.CloneParameters.CloneWriteType, global::SpecialFeatures.Comms.CloneParameters.LastCloneOTAPUserState, this.Parent as global::System.Windows.Window, false);
										goto IL_399;
									}
									catch (global::System.Exception ex)
									{
										if (ex.Message == global::CommonResources.AppResources.Codeplug_Exceeds_Size_Limit_On_Write)
										{
											num4 = (short)1412451015;
											short num7 = num4;
											num4 = (short)427248327;
											switch ((num7 == num4) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
												num4 = (short)1175584768;
												if (num4 != 0)
												{
												}
												status = false;
												break;
											}
										}
										goto IL_399;
									}
									goto IL_1E1;
								case 15:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
									if (radioWide != null)
									{
										num4 = (short)1301610499;
										num5 = (int)((global::System.IntPtr)num4);
										continue;
									}
									goto IL_54B;
								}
								case 16:
									num4 = (short)7208966;
									num5 = (int)((global::System.IntPtr)num4);
									continue;
								case 17:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
									if (radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsername_A9169 != null)
									{
										num4 = (short)2031419412;
										num5 = (int)((global::System.IntPtr)num4);
										continue;
									}
									goto IL_54B;
								}
								case 18:
									if (1 == global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.Count)
									{
										num4 = (short)131465229;
										num5 = (int)((global::System.IntPtr)num4);
										continue;
									}
									goto IL_54B;
								case 19:
									goto IL_34D;
								case 20:
									num4 = (short)1942290450;
									num5 = (int)((global::System.IntPtr)num4);
									continue;
								case 21:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = radioWideRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
									num4 = (short)1681522692;
									num5 = (int)((global::System.IntPtr)num4);
									continue;
								}
								case 22:
								{
									byte[] bytes = global::System.Convert.FromBase64String(clone.GetRadioParams().SerialNumber);
									this.n = global::System.Text.Encoding.ASCII.GetString(bytes);
									num4 = (short)409796618;
									num5 = (int)((global::System.IntPtr)num4);
									continue;
								}
								}
								goto IL_94;
								IL_1F4:
								num4 = (short)1550516239;
								num5 = (int)((global::System.IntPtr)num4);
								continue;
								IL_399:
								this.CallMainFinish(status);
								global::SpecialFeatures.Comms.Comms.updateStatus -= this.CallMainUiProcess;
								num4 = (short)1443299337;
								num5 = (int)((global::System.IntPtr)num4);
								continue;
								IL_54B:
								this.CallMainUiProcess(0.0, global::CommonResources.AppResources.Codeplug_has_Invalid_fields_Please_correct_them_and_try_again);
								num4 = (short)86573063;
								num5 = (int)((global::System.IntPtr)num4);
							}
							IL_1E1:
							this.CallMainFinish(false);
							clone.ForceClose();
							return;
							IL_34D:
							goto IL_1E1;
							IL_3FC:
							clone.ForceClose();
							return;
							IL_442:
							return;
							IL_57C:
							goto IL_1E1;
							IL_94:
							clone = new global::SpecialFeatures.Comms.Clone();
							global::SpecialFeatures.Comms.Comms.updateStatus += this.CallMainUiProcess;
							global::SpecialFeatures.Comms.RadioIdInfo radioIdInfo = clone.ReadRadioIds(global::SpecialFeatures.Comms.CloneParameters.CloneWriteType, 0, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꞕꆗꢙ늛꾝隟骡誣鞥骧銩芫龭", a_), false, false);
							status = (bool)this.Dispatcher.Invoke(new global::SpecialFeatures.CloneExpress.PageCloneExpress.MainThreadUpdateRadioIds(this.a), new object[]
							{
								radioIdInfo
							});
							num4 = (short)1070202880;
							num5 = (int)((global::System.IntPtr)num4);
							goto IL_31;
						}
						}
					}).Start();
					return;
				}
				break;
			}
			}
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x001C6EF8 File Offset: 0x001C50F8
		private void F1HelpCommandCanExcute(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)2051617357;
			short num2 = num;
			num = (short)976761421;
			switch (num2 == num)
			{
			}
			num = (short)1162805249;
			if (num != 0)
			{
			}
			num = (short)980811776;
			short num3 = num;
			num = (short)198770688;
			if (num != 0)
			{
			}
			A_1.CanExecute = true;
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x001C6FA8 File Offset: 0x001C51A8
		private void buttonHelp_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 13;
			short num;
			try
			{
				num = (short)785437657;
				short num2 = num;
				num = (short)1556141017;
				switch (num2 == num)
				{
				}
				num = (short)431882240;
				if (num != 0)
				{
				}
				global::ACPBrowser.Utility.CloseHelpWindowIfOpen();
				global::ACPBrowser.Utility.DisplayCPSHelpDITA(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뎏ꊓꂕ꾗ꦙ꒛ꚝ颟", a_));
			}
			catch (global::System.Exception)
			{
			}
			num = (short)397606913;
			if (num != 0)
			{
			}
			num = (short)1214054400;
			short num3 = num;
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x001C7088 File Offset: 0x001C5288
		private bool a(global::SpecialFeatures.Comms.RadioIdInfo A_0)
		{
			int a_ = 4;
			short num = (short)620953600;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_127;
				}
				bool result;
				bool flag4;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				for (;;)
				{
					IL_30:
					string strB;
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset secureWideRecset;
					global::SpecialFeatures.Comms.DataProfIP dataProfIP;
					global::SpecialFeatures.Comms.DataProfIP[] dataProfIps;
					int num7;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
					int num8;
					switch (num2)
					{
					case 0:
					{
						if (strB == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎆ﾊ\ud88e", a_))
						{
							num = (short)1913585701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset).GetEnumerator();
						num = (short)754253844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)1603272709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = secureKMFProfileRecset.GetEnumerator();
						num = (short)1895366703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_1A27;
					case 4:
						if (A_0.CnvSysIds != null)
						{
							num = (short)1012072455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D4B;
					case 5:
					{
						int num3;
						if (num3 != -1)
						{
							num = (short)1244463123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15FC;
					}
					case 6:
						if (secureWideRecset != null)
						{
							num = (short)163840001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15FC;
					case 7:
					{
						result = true;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset = global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset;
						num = (short)960167950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						num = (short)649265152;
						short num4 = num;
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
						dataWide.General.DataWideGeneralBTDUNSUIPAddress_A41120.SetValue(dataProfIP.BTSubIP.Address);
						num = (short)621871122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						try
						{
							num = (short)314834945;
							num2 = (int)((global::System.IntPtr)num);
							bool result2;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (global::SpecialFeatures.Comms.CloneParameters.BlockNewSystemCheck)
									{
										num = (short)367198210;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_10DC;
									}
									continue;
								case 2:
									this.ProgText.Content = global::CommonResources.AppResources.Warning_System_Type_Not_Match_While_Clone_Express;
									result2 = false;
									num = (short)1327562760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1101856772;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
									bool flag = false;
									string referenceKey = trunkingSystem.ReferenceKey;
									global::System.Collections.Generic.Dictionary<string, int[]>.Enumerator enumerator2 = A_0.TrkSysIds.GetEnumerator();
									num = (short)84475909;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)709099526;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									try
									{
										num = (short)1557397505;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_11E2;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_11DD;
												}
												continue;
											case 2:
												try
												{
													switch (0)
													{
													case 0:
														goto IL_1336;
													}
													bool flag2;
													for (;;)
													{
														IL_131F:
														switch (num2)
														{
														case 0:
															goto IL_13D3;
														case 1:
															goto IL_13BA;
														case 2:
															if (flag2)
															{
																num = (short)147521539;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_13BA;
														case 3:
															global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
															num = (short)40960001;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_1336;
														IL_13BA:
														num = (short)1497563136;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_13D3:
													goto IL_1151;
													IL_1336:
													global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
													trunkingSystem.General.TrkSysGeneralUnitID_A12651.DisableASKRangeValidation = true;
													flag2 = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
													global::System.Collections.Generic.KeyValuePair<string, int[]> keyValuePair;
													trunkingSystem.General.TrkSysGeneralUnitID_A12651.Value = keyValuePair.Value[1];
													num = (short)1645543426;
													num2 = (int)((global::System.IntPtr)num);
													goto IL_131F;
												}
												catch
												{
													goto IL_1151;
												}
												finally
												{
													global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
													trunkingSystem.General.TrkSysGeneralUnitID_A12651.DisableASKRangeValidation = false;
												}
												break;
											case 3:
											{
												global::System.Collections.Generic.Dictionary<string, int[]>.Enumerator enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1315635204;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.KeyValuePair<string, int[]> keyValuePair = enumerator2.Current;
												string strB2 = keyValuePair.Key;
												int num5 = keyValuePair.Key.IndexOf('\0');
												num = (short)1453916167;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												num = (short)215089158;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
											{
												bool flag = true;
												num = (short)291766274;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												goto IL_1448;
											case 7:
											{
												int num5;
												if (num5 > 0)
												{
													num = (short)421920777;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_11E2;
											}
											case 8:
											{
												string referenceKey;
												string strB2;
												if (referenceKey.CompareTo(strB2) == 0)
												{
													num = (short)681050117;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 9:
											{
												global::System.Collections.Generic.KeyValuePair<string, int[]> keyValuePair;
												int num5;
												string strB2 = keyValuePair.Key.Substring(0, num5);
												num = (short)359438285;
												short num6 = num;
												num = (short)931370957;
												switch ((num6 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													continue;
												default:
													num = (short)1870266368;
													if (num != 0)
													{
													}
													num = (short)1863516160;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											goto IL_11DD;
											IL_11E2:
											num = (short)462028808;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_13F1:
											num = (short)1229455363;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_11DD:
											goto IL_13F1;
										}
										IL_1448:
										goto IL_1151;
									}
									finally
									{
										global::System.Collections.Generic.Dictionary<string, int[]>.Enumerator enumerator2;
										((global::System.IDisposable)enumerator2).Dispose();
									}
									goto IL_145B;
									IL_1151:
									num = (short)1487470599;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_14EE;
								case 7:
								{
									bool flag;
									if (!flag)
									{
										num = (short)1164574729;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_1109;
								case 9:
									goto IL_145B;
								}
								goto IL_10DC;
								IL_145B:
								num = (short)1510146048;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1497:
								num = (short)1180172291;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10DC:
								goto IL_1497;
							}
							IL_1109:
							return result2;
							IL_14EE:
							goto IL_1660;
						}
						finally
						{
							num = (short)2076704769;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_155F;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1526;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)768081920;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1526:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2085486594;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_155F:;
						}
						goto IL_1562;
					case 10:
					{
						int num3 = -1;
						result = true;
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset = global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset;
						num = (short)1106182192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						bool radInfoLabtoolH37G50Smartnet_A8184Value;
						bool radInfoLabtoolH38G51Smartzone_A8185Value;
						if (radInfoLabtoolH37G50Smartnet_A8184Value || radInfoLabtoolH38G51Smartzone_A8185Value)
						{
							num = (short)248578079;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C98;
					}
					case 12:
						goto IL_C98;
					case 13:
					{
						result = true;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						A_0.RadioAlias = this.a(A_0.RadioAlias);
						radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioAlias_A8829.SetValue(A_0.RadioAlias);
						num = (short)123338778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
						if (conventionalSystemRecset != null)
						{
							num = (short)940965927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D4B;
					}
					case 15:
						goto IL_16E1;
					case 16:
						goto IL_194E;
					case 17:
						result = true;
						dataProfIps = A_0.DataProfIps;
						num7 = 0;
						num = (short)1516961808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_BBC;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = secureWideRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
						bool flag3 = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
						int num3;
						secureWide.ASTROOTAR.SecWideASTROOTARIndividualASTROOTARRadioID_A8284.Value = num3;
						num = (short)1914306615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						try
						{
							num = (short)1102643200;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1A8A;
									}
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									dataProfiles.General.DataProfilesGeneralBTDUNPeerIPAddress_A41127.SetValue(dataProfIP.BTPeerIP.Address);
									num = (short)1631911938;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_1C80;
								case 3:
									if (dataProfIP.BTPeerIP != null)
									{
										num = (short)652214273;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1CC0;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (!dataProfiles.General.DataProfGeneralAutoGenerateIPAddress_A19320.Value)
									{
										num = (short)820641800;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_1C85;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)142278667;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current;
									num = (short)1593704460;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									dataProfiles.General.DataProfilesGeneralBTDUNSUIPAddress_A41126.SetValue(dataProfIP.BTSubIP.Address);
									num = (short)1364656133;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									dataProfiles.General.DataProfGeneralSubscriberIPAddress_A21157.SetValue(dataProfIP.SubIP.Address);
									dataProfiles.General.DataProfGeneralMobileComputerIPAddress_A8523.SetValue(dataProfIP.PeerIP.Address);
									dataProfiles.General.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.SetValue(dataProfIP.SubAirInterfaceIP.Address);
									num = (short)679804941;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)56754180;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_1CD8;
								case 11:
									goto IL_1CC0;
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.ReferenceKey.CompareTo(strB) == 0)
									{
										num = (short)35848201;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									if (dataProfIP.BTSubIP != null)
									{
										num = (short)2021654535;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1C85;
								}
								IL_1B21:
								num = (short)882049030;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A8A:
								goto IL_1B21;
								IL_1C85:
								num = (short)585629699;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1CC0:
								num = (short)2103836682;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1C80:
							IL_1CD8:
							goto IL_163D;
						}
						finally
						{
							num = (short)1235615744;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1D11;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)676200450;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1D48;
								}
								IL_1D11:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1361051649;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1D48:;
						}
						goto IL_1D4B;
						IL_163D:
						num7++;
						num = (short)112263193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						result = true;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide2 = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						A_0.BluetoothFriendlyName = this.a(A_0.BluetoothFriendlyName);
						radioWide2.Bluetooth.RadWideBluetoothFriendlyName_A41181.SetValue(A_0.BluetoothFriendlyName);
						num = (short)911540239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						if (A_0.BluetoothFriendlyName != null)
						{
							num = (short)230621205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16E1;
					case 23:
						goto IL_1888;
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide3 = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						string value = this.a(A_0.SoftIds[0]);
						radioWide3.UserInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsername_A9169.SetValue(value);
						global::SpecialFeatures.Clone_Configuration.Common.PINPasswordUtil.UpdatePINPasswordFromRadio(A_0);
						if (A_0.SoftIds[3] != null)
						{
							value = this.a(A_0.SoftIds[3]);
						}
						else
						{
							value = "";
						}
						radioWide3.UserInformationAndPasswords.RadWideUserInformationandUserLoginUnitID_41306.SetValue(value);
						num = (short)683081756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_194E;
					case 26:
						goto IL_16A1;
					case 27:
						goto IL_198A;
					case 28:
						goto IL_B50;
					case 29:
						if (num7 >= dataProfIps.Length)
						{
							num = (short)705822747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_102E;
					case 30:
						num = (short)13369345;
						if (num != 0)
						{
						}
						if (A_0.DataProfIps != null)
						{
							num = (short)1412759569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 31:
						flag4 = true;
						num = (short)340918284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = trunkingSystemRecset.GetEnumerator();
						num = (short)1724973065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						result = true;
						num = (short)1600847896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (A_0.SerialNumber != null)
						{
							num = (short)4522020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1888;
					case 35:
						strB = dataProfIP.DataProfName.Substring(0, num8);
						num = (short)1114439723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)995229741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028) as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
						dataWide.General.DataWideGeneralPeerIPAddress1_A8524.SetValue(dataProfIP.PeerIP.Address);
						dataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.SetValue(dataProfIP.SubIP.Address);
						num = (short)150863930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
						if (num8 > 0)
						{
							num = (short)730660899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31B;
					case 39:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalSystemRecset.GetEnumerator();
						num = (short)1033109548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						goto IL_15FC;
					case 41:
						goto IL_B00;
					case 42:
						if (A_0.SoftIds != null)
						{
							num = (short)1078132769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B50;
					case 43:
						goto IL_31B;
					case 44:
						try
						{
							num = (short)1642987523;
							num2 = (int)((global::System.IntPtr)num);
							bool result2;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_A07;
								case 1:
									num = (short)1490419717;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									try
									{
										num = (short)1836515328;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.KeyValuePair<string, int[]> keyValuePair2;
											global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
											bool flag6;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_59E;
												}
												continue;
											case 1:
											{
												int num9;
												string strB3 = keyValuePair2.Key.Substring(0, num9);
												num = (short)1887764500;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
											{
												string cnvSysGeneralSystemType_A13262_UIValue = conventionalSystem.General.CnvSysGeneralSystemType_A13262_UIValue;
												bool flag5 = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
												num = (short)544407569;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												if (keyValuePair2.Value[0] == 3)
												{
													num = (short)1990197264;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_7B1;
											case 4:
												goto IL_607;
											case 5:
											{
												string cnvSysGeneralSystemType_A13262_UIValue;
												if (cnvSysGeneralSystemType_A13262_UIValue == global::CommonResources.AppResources.QCII_ID)
												{
													num = (short)681902107;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_7B1;
											}
											case 6:
												num = (short)1296629790;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
												goto IL_7B1;
											case 8:
												goto IL_9F7;
											case 9:
												goto IL_64D;
											case 10:
												if (keyValuePair2.Value[0] == 1)
												{
													num = (short)1216086038;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_6C9;
											case 11:
											{
												global::System.Collections.Generic.Dictionary<string, int[]>.Enumerator enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1425080348;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												keyValuePair2 = enumerator2.Current;
												string strB3 = keyValuePair2.Key;
												int num9 = keyValuePair2.Key.IndexOf('\0');
												num = (short)763559950;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 12:
											{
												string strB3;
												string referenceKey2;
												if (referenceKey2.CompareTo(strB3) == 0)
												{
													num = (short)332267522;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 13:
											{
												string cnvSysGeneralSystemType_A13262_UIValue;
												if (cnvSysGeneralSystemType_A13262_UIValue == global::CommonResources.AppResources.MDC_Id)
												{
													num = (short)1211170845;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_6C9;
											}
											case 14:
											{
												int num9;
												if (num9 > 0)
												{
													num = (short)279117825;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_76C;
											}
											case 15:
											{
												bool flag5;
												if (flag5)
												{
													num = (short)2086207514;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_9DF;
											}
											case 16:
												flag6 = true;
												num = (short)681902098;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 17:
											{
												string cnvSysGeneralSystemType_A13262_UIValue;
												if (cnvSysGeneralSystemType_A13262_UIValue == global::CommonResources.AppResources.ASTRO_Id)
												{
													num = (short)208863251;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_5A3;
											}
											case 18:
												goto IL_7B1;
											case 19:
												num = (short)1425145880;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 20:
												goto IL_76C;
											case 21:
												goto IL_5A3;
											case 22:
												conventionalSystem.General.CnvSysGeneralMDCPrimaryID_A8744.Value = keyValuePair2.Value[1];
												flag6 = true;
												num = (short)270204935;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 23:
											{
												string cnvSysGeneralSystemType_A13262_UIValue;
												if (cnvSysGeneralSystemType_A13262_UIValue == global::CommonResources.AppResources.DVRS_Id)
												{
													num = (short)251330566;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_89E;
											}
											case 24:
												if (keyValuePair2.Value[0] != 0)
												{
													num = (short)459341845;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_64D;
											case 25:
												goto IL_7B1;
											case 26:
												global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
												num = (short)1827274756;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 27:
												num = (short)353370115;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 28:
												goto IL_9DF;
											case 29:
												num = (short)1529610250;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 30:
												if (keyValuePair2.Value[0] == 2)
												{
													num = (short)1947467785;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_89E;
											}
											goto IL_59E;
											IL_5A3:
											num = (short)364511255;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_64D:
											conventionalSystem.General.CnvSysGeneralIndividualID_A8287.Value = keyValuePair2.Value[1];
											flag6 = true;
											num = (short)1082261529;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_6C9:
											num = (short)1611399173;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_76C:
											num = (short)899088396;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_7B1:
											num = (short)526057487;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_89E:
											num = (short)543621133;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_965:
											num = (short)1983774731;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_59E:
											goto IL_965;
											IL_9DF:
											num = (short)1671299080;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_607:
										IL_9F7:
										goto IL_A39;
									}
									finally
									{
										global::System.Collections.Generic.Dictionary<string, int[]>.Enumerator enumerator2;
										((global::System.IDisposable)enumerator2).Dispose();
									}
									goto IL_A07;
									IL_A39:
									num = (short)1318846471;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_43A;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)343801862;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)enumerator.Current;
									bool flag6 = false;
									string referenceKey2 = conventionalSystem.ReferenceKey;
									global::System.Collections.Generic.Dictionary<string, int[]>.Enumerator enumerator2 = A_0.CnvSysIds.GetEnumerator();
									num = (short)1826095106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									if (global::SpecialFeatures.Comms.CloneParameters.BlockNewSystemCheck)
									{
										num = (short)1600061440;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									num = (short)1901658120;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									bool flag6;
									if (!flag6)
									{
										num = (short)2016477185;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_A8D;
								case 9:
									goto IL_A34;
								}
								IL_43F:
								num = (short)647364612;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_43A:
								goto IL_43F;
								IL_A07:
								this.ProgText.Content = global::CommonResources.AppResources.Warning_System_Type_Not_Match_While_Clone_Express;
								result2 = false;
								num = (short)863043593;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A34:
							return result2;
							IL_A8D:
							goto IL_1D4B;
						}
						finally
						{
							num = (short)572391424;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_AC6;
									}
									continue;
								case 1:
									goto IL_AFD;
								case 2:
									enumerator.Dispose();
									num = (short)1817837569;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_AC6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1095434242;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_AFD:;
						}
						goto IL_B00;
					case 45:
						if (A_0.SerialNumber.Trim().Length > 0)
						{
							num = (short)1799225398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1888;
					case 46:
						if (trunkingSystemRecset != null)
						{
							num = (short)947126304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1660;
					case 47:
						try
						{
							num = (short)1305018369;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								global::System.Collections.Generic.Dictionary<string, int>.Enumerator enumerator3;
								global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
								string referenceKey3;
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)1548484610;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F5F;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_D18;
									}
									continue;
								case 2:
									num = (short)483786755;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_FB9;
								case 4:
									try
									{
										num = (short)1294860292;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_F2F;
											case 1:
											{
												global::System.Collections.Generic.KeyValuePair<string, int> keyValuePair3;
												int num3 = keyValuePair3.Value;
												num = (short)1206517760;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												goto IL_F4C;
											case 3:
											{
												if (!enumerator3.MoveNext())
												{
													num = (short)976158725;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.KeyValuePair<string, int> keyValuePair3 = enumerator3.Current;
												string key = keyValuePair3.Key;
												num = (short)1582497802;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												switch (0)
												{
												case 0:
													goto IL_DAE;
												}
												continue;
											case 5:
												goto IL_F34;
											case 6:
												if (!secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597.Value)
												{
													num = (short)1524957185;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_F34;
											case 7:
												global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
												num = (short)784007179;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
											{
												bool flag7 = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
												global::System.Collections.Generic.KeyValuePair<string, int> keyValuePair3;
												secureKMFProfile.ASTROOTARInformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Value = keyValuePair3.Value;
												if (flag7)
												{
													num = (short)1716060167;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_DB3;
											}
											case 9:
												num = (short)235405320;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 10:
											{
												string key;
												if (referenceKey3.Equals(key.TrimEnd(new char[1])))
												{
													num = (short)575078409;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 11:
												goto IL_DB3;
											}
											goto IL_DAE;
											IL_DB3:
											num = (short)1118765062;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_E4B:
											num = (short)1472528387;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_DAE:
											goto IL_E4B;
											IL_F34:
											num = (short)1371668482;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_F2F:
										IL_F4C:
										break;
									}
									finally
									{
										((global::System.IDisposable)enumerator3).Dispose();
									}
									goto IL_F5F;
								}
								IL_D1D:
								num = (short)2070347776;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D18:
								goto IL_D1D;
								IL_F5F:
								secureKMFProfile = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
								referenceKey3 = secureKMFProfile.ReferenceKey;
								enumerator3 = A_0.AstroOtarRadioIds.GetEnumerator();
								num = (short)960364548;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FB9:
							goto IL_1581;
						}
						finally
						{
							num = (short)1835859968;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_FF1;
									}
									continue;
								case 1:
									goto IL_102B;
								case 2:
									enumerator.Dispose();
									num = (short)1728446465;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_FF1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)464715778;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_102B:;
						}
						goto IL_102E;
					case 48:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
						if (secureKMFProfileRecset != null)
						{
							num = (short)985464834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1581;
					}
					case 49:
						goto IL_1562;
					case 50:
						if (dataProfIP.BTPeerIP != null)
						{
							num = (short)219349043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 51:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
						dataWide.General.DataWideGeneralBTDUNPeerIPAddress_A41123.SetValue(dataProfIP.BTPeerIP.Address);
						num = (short)588578819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
					{
						bool radInfoLabtoolH37G50Smartnet_A8184Value = radioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184Value;
						bool radInfoLabtoolH38G51Smartzone_A8185Value = radioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185Value;
						num = (short)1869021195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
						if (radioInformation != null)
						{
							num = (short)325648436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C98;
					case 54:
						this.SerNum = A_0.SerialNumber;
						num = (short)81920023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
					{
						bool flag3;
						if (flag3)
						{
							num = (short)1835270193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15FC;
					}
					case 56:
						if (A_0.AstroOtarRadioIds != null)
						{
							num = (short)798490634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15FC;
					case 57:
						if (A_0.TrkSysIds != null && flag4)
						{
							num = (short)2122842153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1660;
					case 58:
						if (dataProfIP.BTSubIP != null)
						{
							num = (short)185663496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BBC;
					case 59:
						if (A_0.RadioAlias != null)
						{
							num = (short)175898637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16A1;
					}
					goto IL_127;
					IL_31B:
					num = (short)1635713024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B00:
					result = true;
					trunkingSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset);
					num = (short)2030895150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B50:
					num = (short)1385103419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BBC:
					num = (short)1525284914;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C98:
					num = (short)1366687778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_102E:
					dataProfIP = dataProfIps[num7];
					strB = dataProfIP.DataProfName;
					num8 = dataProfIP.DataProfName.IndexOf('\0');
					num = (short)596115494;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1562:
					global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
					num = (short)1001848872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1581:
					secureWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2021) as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset);
					num = (short)1105199110;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15FC:
					num = (short)889454634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1660:
					num = (short)46333956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16A1:
					num = (short)233766934;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16E1:
					num = (short)2135818270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1888:
					num = (short)1984692281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_194E:
					num = (short)1928527901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D4B:
					num = (short)942342200;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_198A:
				IL_1A27:
				return result;
				IL_127:
				result = false;
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				flag4 = false;
				num = (short)1050673205;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x001C8F84 File Offset: 0x001C7184
		private void a(object A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpConstraints acpConstraints;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)595722241;
					if (num2 != 0)
					{
					}
					goto IL_A2;
				case 1:
					if (acpConstraints != null)
					{
						goto IL_3B;
					}
					goto IL_A2;
				case 2:
					acpConstraints.CalculateApplicability();
					acpConstraints.CalculateEditability(true);
					acpConstraints.CalculateVisibility(true);
					num2 = (short)7340032;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
				IL_3B:
				num2 = (short)1326579714;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_A2:
				num2 = (short)65957030;
				short num3 = num2;
				num2 = (short)161311910;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3B;
				default:
					goto IL_D7;
				}
			}
			IL_D7:
			num2 = (short)1415446528;
			if (num2 != 0)
			{
			}
			num2 = (short)1131020288;
			short num4 = num2;
			return;
			IL_1C:
			acpConstraints = (A_0 as global::AcpCommonLib.IAcpConstraints);
			num2 = (short)2004549633;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x001C90A8 File Offset: 0x001C72A8
		private string a(string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1776418817;
					if (num2 != 0)
					{
					}
					A_0 = A_0.Substring(0, num3);
					num2 = (short)1442709505;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)2003828736;
					short num4 = num2;
					goto IL_131;
				}
				case 2:
					goto IL_131;
				case 3:
					if (num3 == 0)
					{
						num2 = (short)1850671108;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1362690053;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					A_0 = "";
					num2 = (short)1710620674;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (num3 > 0)
					{
						goto IL_F5;
					}
					goto IL_131;
				}
				goto IL_28;
				IL_F5:
				num2 = (short)1801846784;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_131:
				num2 = (short)1489857209;
				short num5 = num2;
				num2 = (short)1276209849;
				switch ((num5 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_F5;
				default:
					goto IL_165;
				}
			}
			IL_165:
			num2 = (short)862388224;
			if (num2 != 0)
			{
			}
			return A_0;
			IL_28:
			num3 = A_0.IndexOf('\0');
			num2 = (short)1748107267;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x001C9230 File Offset: 0x001C7430
		internal void CallMainUiProcess(double n, string stat)
		{
			short num = (short)1520728028;
			short num2 = num;
			num = (short)422213596;
			switch (num2 == num)
			{
			}
			num = (short)639303681;
			if (num != 0)
			{
			}
			num = (short)1469120512;
			if (num != 0)
			{
			}
			num = (short)51052544;
			short num3 = num;
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::SpecialFeatures.CloneExpress.PageCloneExpress.UpdateProgress(this.CloneRadio_updateStatus), n, new object[]
			{
				stat
			});
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x001C9300 File Offset: 0x001C7500
		internal void CloneRadio_updateStatus(double n, string stat)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_C9;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (stat == global::CommonResources.AppResources.Read_Radio_Verification_Start)
					{
						num2 = (short)1357185027;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1858928664;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_837;
				case 2:
					goto IL_7F2;
				case 3:
					goto IL_5D3;
				case 4:
					goto IL_8D7;
				case 5:
					if (stat == global::CommonResources.AppResources.Radio_Erase_in_Progress_please_wait)
					{
						num2 = (short)312148004;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1834483753;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_173;
				case 7:
					goto IL_121;
				case 8:
					goto IL_20D;
				case 9:
					if (stat == global::CommonResources.AppResources.Read_Radio_Info_Complete)
					{
						num2 = (short)525402120;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)493748237;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_58F;
				case 11:
					if (stat == global::CommonResources.AppResources.LP_Cannot_Determine_Host_Version)
					{
						num2 = (short)1675886618;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1901461518;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
				{
					num2 = (short)1046724351;
					short num3 = num2;
					num2 = (short)551730943;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3BE;
					default:
						goto IL_78D;
					}
					break;
				}
				case 13:
					if (stat == global::CommonResources.AppResources.ReadRadio_Calling_End_Read_Radio)
					{
						goto IL_3BE;
					}
					num2 = (short)1231159338;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (stat == global::CommonResources.AppResources.LP_Radio_display_Language_Not_Supported_By_this_radio)
					{
						num2 = (short)2139881474;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8DC;
				case 15:
					num2 = (short)1367867393;
					if (num2 != 0)
					{
					}
					if (stat == global::CommonResources.AppResources.WriteRadio_Close_Port)
					{
						num2 = (short)1150746643;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)635174917;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_334;
				case 17:
					if (!string.IsNullOrEmpty(global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.warningOTAPMessage))
					{
						num2 = (short)255524902;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_887;
				case 18:
					if (stat == global::CommonResources.AppResources.Reading_radio_codeplug_)
					{
						num2 = (short)1756889098;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1568735271;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					goto IL_6B7;
				case 20:
					goto IL_4EC;
				case 21:
					if (this.m)
					{
						num2 = (short)931463174;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1263861777;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					num2 = (short)506920981;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					if (stat == global::CommonResources.AppResources.Open_Port_Complete)
					{
						num2 = (short)1575354380;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1509359647;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					if (stat == global::CommonResources.AppResources.Read_Radio_Verification_Complete)
					{
						num2 = (short)74907678;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)470876192;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (stat == global::CommonResources.AppResources.Opening_Port)
					{
						num2 = (short)832307207;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1440219159;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					goto IL_299;
				case 27:
					if (stat == global::CommonResources.AppResources.Writing_radio_codeplug_completed)
					{
						num2 = (short)743637014;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)54853661;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					goto IL_752;
				case 29:
					if (stat == global::CommonResources.AppResources.WriteRadio_eject_radio)
					{
						num2 = (short)906231842;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)668205099;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					goto IL_381;
				case 31:
					if (stat == global::CommonResources.AppResources.Read_Radio_Info)
					{
						num2 = (short)1437794332;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)216662025;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					if (stat == global::CommonResources.AppResources.Writing_radio_codeplug)
					{
						num2 = (short)1511784485;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1754923048;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
					goto IL_52A;
				case 34:
					goto IL_253;
				case 35:
					goto IL_3D5;
				case 36:
					goto IL_1C9;
				case 37:
					goto IL_6FC;
				case 38:
					goto IL_4A7;
				case 39:
					if (stat == global::CommonResources.AppResources.ReadRadio_Reading_codeplug_from_radio)
					{
						num2 = (short)2134179860;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)859832320;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 40:
					if (stat == global::CommonResources.AppResources.WriteRadio_Writing_codeplug_to_radio)
					{
						num2 = (short)1314324481;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1564475419;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 41:
					if (stat == global::CommonResources.AppResources.Password_validation_failed)
					{
						num2 = (short)449839120;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)609812491;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 42:
					if (stat == global::CommonResources.AppResources.Reading_radio_codeplug_completed)
					{
						num2 = (short)486670369;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)737083410;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
					if (stat == global::CommonResources.AppResources.WaitForRadioEject_Id)
					{
						num2 = (short)389152772;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)635240463;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_C9;
				IL_3BE:
				num2 = (short)1757216803;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_121:
			this.ProgText.Content = global::CommonResources.AppResources.Opening_Connection_To_Radio;
			return;
			IL_173:
			this.ProgText.Content = global::CommonResources.AppResources.Write_radio_complete_LP_Radio_display_Lng_Not_Supported_By_this_radio;
			return;
			IL_1C9:
			this.ProgText.Content = global::CommonResources.AppResources.Radio_Erasing_please_wait;
			return;
			IL_20D:
			this.ProgText.Content = global::CommonResources.AppResources.Read_radio_info_complete_;
			return;
			IL_253:
			this.ProgText.Content = global::CommonResources.AppResources.Write_radio_releasing_radio;
			return;
			IL_299:
			this.ProgText.Content = global::CommonResources.AppResources.LP_Cannot_Determine_Host_Version;
			return;
			IL_334:
			this.ProgText.Content = global::CommonResources.AppResources.Password_validation_failed_suspension;
			return;
			IL_381:
			this.ProgText.Content = global::CommonResources.AppResources.Read_Radio_Verification_Complete;
			return;
			IL_3D5:
			this.ProgText.Content = global::CommonResources.AppResources.Read_radio_codeplug_complete;
			return;
			IL_4A7:
			this.ProgText.Content = global::CommonResources.AppResources.Write_Complete + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꚅ", a_) + global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.warningOTAPMessage;
			return;
			IL_4EC:
			this.ProgText.Content = global::CommonResources.AppResources.Begin_read_codeplug;
			return;
			IL_52A:
			this.ProgText.Content = global::CommonResources.AppResources.Read_Radio_Info;
			return;
			IL_58F:
			num2 = (short)828833792;
			short num4 = num2;
			this.ProgText.Content = global::CommonResources.AppResources.Read_Radio_Info;
			return;
			IL_5D3:
			this.ProgText.Content = global::CommonResources.AppResources.Read_Radio_Verification_Start_;
			return;
			IL_6B7:
			this.ProgText.Content = global::CommonResources.AppResources.Write_radio_release_complete;
			return;
			IL_6FC:
			this.ProgText.Content = global::CommonResources.AppResources.Write_to_radio_in_progress;
			return;
			IL_752:
			this.ProgText.Content = global::CommonResources.AppResources.Read_radio_info_start_;
			return;
			IL_78D:
			num2 = (short)1608777728;
			if (num2 != 0)
			{
			}
			this.ProgText.Content = global::CommonResources.AppResources.Connecting_opened_to_radio;
			return;
			IL_7F2:
			this.m = true;
			return;
			IL_837:
			this.ProgText.Content = global::CommonResources.AppResources.Begin_write_to_radio;
			return;
			IL_887:
			this.ProgText.Content = global::CommonResources.AppResources.Write_to_radio_complete;
			return;
			IL_8D7:
			this.b.StartTimer();
			this.c = true;
			return;
			IL_8DC:
			this.ProgText.Content = stat;
			return;
			IL_C9:
			int num5 = (int)(n * 100.0);
			this.progressBar2.Value = (double)num5;
			num2 = (short)1029505049;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x001C9BF8 File Offset: 0x001C7DF8
		internal void CallMainFinish(bool status)
		{
			short num = (short)34275328;
			short num2 = num;
			num = (short)794187636;
			short num3 = num;
			num = (short)138303348;
			switch (num3 == num)
			{
			}
			num = (short)139526145;
			if (num != 0)
			{
			}
			num = (short)259653632;
			if (num != 0)
			{
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::SpecialFeatures.CloneExpress.PageCloneExpress.MainFinish(this.CloneFinished), status);
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x001C9CC4 File Offset: 0x001C7EC4
		internal void CloneFinished(bool status)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					global::SpecialFeatures.Clone_Configuration.Common.DVRSXmlUtil.ExportDVRSAfterClone(this.n);
					num2 = (short)1449590786;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					this.ExpSerialNumber.Visibility = global::System.Windows.Visibility.Visible;
					this.ExpSerialNumber.IsExpanded = true;
					this.ExpTrkSysIDList.Visibility = global::System.Windows.Visibility.Visible;
					this.ExpTrkSysIDList.IsExpanded = true;
					this.ExpCnvSysIDList.Visibility = global::System.Windows.Visibility.Visible;
					this.ExpCnvSysIDList.IsExpanded = true;
					this.ExpIndAstroOtarRadioIDList.Visibility = global::System.Windows.Visibility.Visible;
					this.ExpIndAstroOtarRadioIDList.IsExpanded = true;
					this.ExpDataWide.Visibility = global::System.Windows.Visibility.Visible;
					this.ExpDataWide.IsExpanded = true;
					this.ExpDataProfileList.Visibility = global::System.Windows.Visibility.Visible;
					this.ExpDataProfileList.IsExpanded = true;
					this.ExpUserInfo.Visibility = global::System.Windows.Visibility.Visible;
					this.ExpUserInfo.IsExpanded = true;
					this.ExpBluetooth.Visibility = global::System.Windows.Visibility.Visible;
					this.ExpBluetooth.IsExpanded = true;
					num2 = (short)1641218056;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_1E1;
				case 3:
					goto IL_30C;
				case 4:
				{
					num2 = (short)643432449;
					if (num2 != 0)
					{
					}
					if (status)
					{
						num2 = (short)355860481;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::AcpCommonLib.StatusMessage.StatusMessagesManager statusMsgReport = global::AcpCommonLib.AppInfoManager.StatusMsgReport;
					num2 = (short)1724907525;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
				{
					global::AcpCommonLib.StatusMessage.StatusMessagesManager statusMsgReport;
					if (!statusMsgReport.ContainsField(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8c朗杖랖쪘ﺚ삠쾢薤\udca8욪쾬쪮쎰鎲살잶\uddb8\udaba즼\udabeꗀ", a_)))
					{
						num2 = (short)1439629322;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12F;
				}
				case 6:
					if (status)
					{
						num2 = (short)192675840;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
				{
					num2 = (short)1557200896;
					short num3 = num2;
					global::SpecialFeatures.Security.RadioAccessValidator.RestoreCachedCodeplugSecurityFields(this.d, this.e, this.f, this.g, this.h, this.j, this.i);
					num2 = (short)1637089283;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					goto IL_12F;
				case 9:
					if (this.k)
					{
						num2 = (short)1290665991;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_30C;
				case 10:
				{
					global::AcpCommonLib.StatusMessage.StatusMessagesManager statusMsgReport;
					statusMsgReport.ContainsField(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8c朗杖랖쪘ﺚ삠쾢薤\udca8욪쾬쪮쎰鎲살잶\uddb8\udaba즼\udabeꗂ꓄껆ꗈ껊꧌", a_));
					num2 = (short)621477899;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 11:
					goto IL_12F;
				}
				goto IL_49;
				IL_12F:
				num2 = (short)1003683849;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_30C:
				this.CloneButton.IsEnabled = true;
				global::SpecialFeatures.Clone_Configuration.Common.Win32APIs.EnableCloseMenuItem(this.l, true);
				this.c = false;
				this.b.Stop();
				num2 = (short)1421017094;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1E1:
			num2 = (short)1512339671;
			short num4 = num2;
			num2 = (short)777746647;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_49:
				this.m = false;
				global::SpecialFeatures.RadioLanguagePack.LanguagePackHelper.warningOTAPMessage = string.Empty;
				num2 = (short)236650500;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
				num2 = (short)871235584;
				if (num2 != 0)
				{
				}
				break;
			}
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x001CA070 File Offset: 0x001C8270
		internal void CloneW_DisplayOTAP(global::SpecialFeatures.Programming.ProgrammingOperation ProgOp, global::SpecialFeatures.Programming.OTAPProgrammingParameters LastCommsOTAPUserState, global::SpecialFeatures.Comms.Comms.RadioOTAPObject RadioObject)
		{
			short num = (short)494927872;
			short num2 = num;
			num = (short)2078713411;
			short num3 = num;
			num = (short)890283587;
			switch (num3 == num)
			{
			}
			num = (short)1255079936;
			if (num != 0)
			{
			}
			num = (short)831062017;
			if (num != 0)
			{
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::SpecialFeatures.CloneExpress.PageCloneExpress.MainUIDisplayOTAP(this.DisplayOTAP), ProgOp, new object[]
			{
				LastCommsOTAPUserState,
				RadioObject
			});
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x001CA148 File Offset: 0x001C8348
		internal void DisplayOTAP(global::SpecialFeatures.Programming.ProgrammingOperation ProgOp, global::SpecialFeatures.Programming.OTAPProgrammingParameters LastCommsOTAPUserState, global::SpecialFeatures.Comms.Comms.RadioOTAPObject RadioObject)
		{
			int a_ = 19;
			short num = (short)855506944;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1E;
				case 1:
				{
					num = (short)872284161;
					if (num != 0)
					{
					}
					global::SpecialFeatures.Programming.OTAPProgrammingWindow otapprogrammingWindow = new global::SpecialFeatures.Programming.OTAPProgrammingWindow(ProgOp, LastCommsOTAPUserState);
					global::System.Windows.Window mainWindow = global::System.Windows.Application.Current.MainWindow;
					otapprogrammingWindow.Owner = mainWindow;
					bool? otapDialogResult = otapprogrammingWindow.ShowDialog();
					RadioObject(otapDialogResult, otapprogrammingWindow.OTAPProgrammingLastState, otapprogrammingWindow.PrescenceResult);
					global::System.Threading.Semaphore.OpenExisting(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud995첗\udb99첛\uda9d즟톡풣쪥즧펩ﮫ쾭\ud9af욱", a_)).Release(1);
					num = (short)729350144;
					short num3 = num;
					num = (short)1446117378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return;
				}
				goto IL_3A;
				IL_1E:
				switch (0)
				{
				case 0:
				{
					IL_3A:
					if ((bool)global::System.Windows.Application.Current.Properties[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햕ﾝ캟욡쾥욧쾩ﺭ", a_)])
					{
						return;
					}
					num = (short)59005433;
					short num4 = num;
					num = (short)1349474809;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E;
					default:
						num = (short)1054015488;
						if (num != 0)
						{
						}
						num = (short)703266817;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x001CA2D8 File Offset: 0x001C84D8
		internal void CloneW_DisplayRadioQuery(global::SpecialFeatures.Comms.Comms.RadioRtn RadioRtn)
		{
			short num = (short)658440192;
			short num2 = num;
			num = (short)1358481385;
			short num3 = num;
			num = (short)474990569;
			switch (num3 == num)
			{
			}
			num = (short)1062207489;
			if (num != 0)
			{
			}
			num = (short)456982528;
			if (num != 0)
			{
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::SpecialFeatures.CloneExpress.PageCloneExpress.WriteRadioQuery(this.DisplayRadioQuery), RadioRtn);
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x001CA39C File Offset: 0x001C859C
		internal void DisplayRadioQuery(global::SpecialFeatures.Comms.Comms.RadioRtn RadioRtn)
		{
			int a_ = 10;
			short num = (short)1448017920;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1D;
				case 1:
				{
					global::System.Windows.MessageBoxResult radioRtn = global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Warning_You_are_about_to_write_protect_the_attached_radio, global::CommonResources.AppResources.Radio_Write_Protect_Warning, global::System.Windows.MessageBoxButton.OKCancel, global::System.Windows.MessageBoxImage.Exclamation);
					RadioRtn(radioRtn);
					global::System.Threading.Semaphore.OpenExisting(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8c朗杖삖爵욢톤", a_)).Release(1);
					num = (short)246349824;
					short num3 = num;
					num = (short)1034682370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return;
				}
				goto IL_39;
				IL_1D:
				switch (0)
				{
				case 0:
				{
					IL_39:
					num = (short)275906561;
					if (num != 0)
					{
					}
					if ((bool)global::System.Windows.Application.Current.Properties[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캌ﲐﺒ練ﶘ힚쒠", a_)])
					{
						return;
					}
					num = (short)190344698;
					short num4 = num;
					num = (short)263876090;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
						num = (short)276496384;
						if (num != 0)
						{
						}
						num = (short)1212153857;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x001CA50C File Offset: 0x001C870C
		private void OnRadioEjectTimeOut(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)990642176;
			int num2 = (int)((global::System.IntPtr)num);
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
				{
					if (!this.c)
					{
						return;
					}
					num = (short)1032783723;
					short num3 = num;
					num = (short)1581254507;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1162084353;
						if (num != 0)
						{
						}
						num = (short)415563776;
						if (num != 0)
						{
						}
						num = (short)154009604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					num = (short)307494913;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					global::SpecialFeatures.Clone_Configuration.Common.Win32APIs.EnableCloseMenuItem(this.l, true);
					this.b.Stop();
					num = (short)235405315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_38:
				num = (short)839581696;
				short num4 = num;
				if (this.b == null)
				{
					break;
				}
				num = (short)126353410;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x001CA680 File Offset: 0x001C8880
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 3;
			short num;
			for (;;)
			{
				num = (short)2106982400;
				short num2 = num;
				if (!this.q)
				{
					goto IL_AE;
				}
				num = (short)702422791;
				short num3 = num;
				num = (short)1345593095;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_72;
				}
			}
			IL_72:
			num = (short)1895563265;
			if (num != 0)
			{
			}
			num = (short)251854848;
			if (num != 0)
			{
			}
			return;
			IL_AE:
			this.q = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꦅ\udb87憎憐킕ﶗﮙ튟잡힣鶥쮧얩솫\udead\udfaf\udcb1톳\ud8b5첷閹\udfbb튽꾿곁ꇃ難韛꿋ꇍ뻏듑뷓뇕귗꣙뷛ꫝ觟跡諣짥诧蛩菫胭闯ퟱ웳웵鷷苹賻賽旿焁眃⤅砇欉欋欍猏縑笓砕紗缙搛渝刟䜡圣唥ا利䴫䌭尯", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x001CA760 File Offset: 0x001C8960
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)372113410;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)279314432;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)1213005825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1F0;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				}
				IL_5B:
				switch (connectionId)
				{
				case 1:
					goto IL_2F9;
				case 2:
					goto IL_378;
				case 3:
					goto IL_43C;
				case 4:
					goto IL_36B;
				case 5:
					goto IL_171;
				case 6:
					goto IL_40B;
				case 7:
					goto IL_202;
				case 8:
					goto IL_1F5;
				case 9:
					goto IL_157;
				case 10:
					goto IL_281;
				case 11:
					goto IL_1A5;
				case 12:
					goto IL_2A8;
				case 13:
					goto IL_226;
				case 14:
					goto IL_29B;
				case 15:
					goto IL_274;
				case 16:
					goto IL_2B5;
				case 17:
					goto IL_3FE;
				case 18:
					goto IL_24D;
				case 19:
					goto IL_1CC;
				case 20:
					goto IL_25A;
				case 21:
					goto IL_337;
				case 22:
					goto IL_351;
				case 23:
					goto IL_497;
				case 24:
					goto IL_32A;
				case 25:
					goto IL_2EC;
				case 26:
					goto IL_198;
				case 27:
					goto IL_14A;
				case 28:
					goto IL_449;
				case 29:
					goto IL_463;
				case 30:
					goto IL_267;
				case 31:
					goto IL_48A;
				case 32:
					goto IL_17E;
				case 33:
					goto IL_13D;
				case 34:
					goto IL_456;
				case 35:
					goto IL_47D;
				case 36:
					goto IL_240;
				case 37:
					goto IL_344;
				case 38:
					goto IL_28E;
				case 39:
					goto IL_164;
				case 40:
					goto IL_42F;
				case 41:
					goto IL_1B2;
				case 42:
					goto IL_233;
				case 43:
					goto IL_18B;
				case 44:
					goto IL_35E;
				case 45:
					goto IL_3F1;
				case 46:
					goto IL_1BF;
				case 47:
					goto IL_470;
				default:
					num = (short)1656094720;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_13D:
			this.ExpDataProfileList = (global::AcpUI.AcpExpander)target;
			return;
			IL_14A:
			this.PeerIPAddress1 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_157:
			this.SerialNumberName = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_164:
			this.LblUserInfoPINPassword = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_171:
			this.ExpCloneExp = (global::AcpUI.AcpExpander)target;
			return;
			IL_17E:
			this.DataWideGeneralBTPeerIPAddress = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_18B:
			this.LblRadioAlias = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_198:
			this.DataWideGeneralSubscriberIPAddress1 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1A5:
			this.ExpTrkSysIDList = (global::AcpUI.AcpExpander)target;
			return;
			IL_1B2:
			this.LblUserInfoUserLoginUnitID = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1BF:
			this.BluetoothFriendlyName = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1CC:
			this.LblSecWideASTROOTARIndividualASTROOTARRadioID = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1F0:
			this.q = true;
			return;
			IL_1F5:
			this.ExpSerialNumber = (global::AcpUI.AcpExpander)target;
			return;
			IL_202:
			this.HelpButton = (global::System.Windows.Controls.Button)target;
			this.HelpButton.Click += this.buttonHelp_Click;
			return;
			IL_226:
			this.TrkSysName_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_233:
			this.RadWideUserInformationandPasswordsUserLoginUnitID = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_240:
			this.ExpUserInfo = (global::AcpUI.AcpExpander)target;
			return;
			IL_24D:
			this.ExpIndAstroOtarRadioIDList = (global::AcpUI.AcpExpander)target;
			return;
			IL_25A:
			this.SecWideASTROOTARIndividualASTROOTARRadioID = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_267:
			this.DataWideGeneralBTSubscriberIPAddress = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_274:
			this.UnitID_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_281:
			this.RadInfoGeneralSerialNumber = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_28E:
			this.RadWideUserInformationandPasswordsSoftIDUsername = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_29B:
			this.TrkSysID_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2A8:
			this.TrunkingIDDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_2B5:
			num = (short)1568669697;
			if (num != 0)
			{
			}
			this.ExpCnvSysIDList = (global::AcpUI.AcpExpander)target;
			return;
			IL_2EC:
			this.SubscriberIPAddress1 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_2F9:
			((global::SpecialFeatures.CloneExpress.PageCloneExpress)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.CloneExpress.PageCloneExpress)target).Unloaded += this.OnUnloaded;
			return;
			IL_32A:
			this.ExpDataWide = (global::AcpUI.AcpExpander)target;
			return;
			IL_337:
			this.IndAstroOtardRadioIDDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_344:
			this.SoftIDUsername = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_351:
			this.SecureKMFProfile_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_35E:
			this.RadWideUserInformationandPasswordsRadioAlias = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_36B:
			this.progressBar2 = (global::System.Windows.Controls.ProgressBar)target;
			return;
			IL_378:
			num = (short)954569187;
			short num4 = num;
			num = (short)865636835;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_24D;
			default:
				num = (short)614989824;
				if (num != 0)
				{
				}
				((global::System.Windows.Input.CommandBinding)target).Executed += new global::System.Windows.Input.ExecutedRoutedEventHandler(this.buttonHelp_Click);
				((global::System.Windows.Input.CommandBinding)target).CanExecute += this.F1HelpCommandCanExcute;
				return;
			}
			IL_3F1:
			this.ExpBluetooth = (global::AcpUI.AcpExpander)target;
			return;
			IL_3FE:
			this.CnvSysIDDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_40B:
			this.CloneButton = (global::System.Windows.Controls.Button)target;
			this.CloneButton.Click += this.OnCloneExpressClone;
			return;
			IL_42F:
			this.RadWideUserInformationandPasswordsPINPassword = (global::AcpUI.AcpPasswordEyeBox)target;
			return;
			IL_43C:
			this.ProgText = (global::AcpUI.AcpLabel)target;
			return;
			IL_449:
			this.DataWideGeneralPeerIPAddress1 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_456:
			this.DataProfilesDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_463:
			this.BTSubscriberIPAddress = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_470:
			this.RadWideBluetoothFriendlyName = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_47D:
			this.DataProfileName_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_48A:
			this.BTPeerIPAddress = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_497:
			this.IndAstroOtarRadioID_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
		}

		// Token: 0x04000AB5 RID: 2741
		private bool a;

		// Token: 0x04000AB6 RID: 2742
		private global::SpecialFeatures.Clone_Configuration.Common.RadioEjectTimer b;

		// Token: 0x04000AB7 RID: 2743
		private bool c;

		// Token: 0x04000AB8 RID: 2744
		private bool d;

		// Token: 0x04000AB9 RID: 2745
		private bool e;

		// Token: 0x04000ABA RID: 2746
		private int f;

		// Token: 0x04000ABB RID: 2747
		private int g;

		// Token: 0x04000ABC RID: 2748
		private int h;

		// Token: 0x04000ABD RID: 2749
		private int i;

		// Token: 0x04000ABE RID: 2750
		private global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset j;

		// Token: 0x04000ABF RID: 2751
		private bool k;

		// Token: 0x04000AC0 RID: 2752
		private global::System.IntPtr l = global::System.IntPtr.Zero;

		// Token: 0x04000AC1 RID: 2753
		private bool m;

		// Token: 0x04000AC2 RID: 2754
		public string LPKString;

		// Token: 0x04000AC3 RID: 2755
		private string n = "";

		// Token: 0x04000AC4 RID: 2756
		private string o;

		// Token: 0x04000AC5 RID: 2757
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler p;

		// Token: 0x04000AC6 RID: 2758
		internal global::AcpUI.AcpLabel ProgText;

		// Token: 0x04000AC7 RID: 2759
		internal global::System.Windows.Controls.ProgressBar progressBar2;

		// Token: 0x04000AC8 RID: 2760
		internal global::AcpUI.AcpExpander ExpCloneExp;

		// Token: 0x04000AC9 RID: 2761
		internal global::System.Windows.Controls.Button CloneButton;

		// Token: 0x04000ACA RID: 2762
		internal global::System.Windows.Controls.Button HelpButton;

		// Token: 0x04000ACB RID: 2763
		internal global::AcpUI.AcpExpander ExpSerialNumber;

		// Token: 0x04000ACC RID: 2764
		internal global::AcpUI.AcpViewOnlyCtrl SerialNumberName;

		// Token: 0x04000ACD RID: 2765
		internal global::AcpUI.AcpViewOnlyCtrl RadInfoGeneralSerialNumber;

		// Token: 0x04000ACE RID: 2766
		internal global::AcpUI.AcpExpander ExpTrkSysIDList;

		// Token: 0x04000ACF RID: 2767
		internal global::AcpUI.AcpXamDataPresenter TrunkingIDDataPresenter;

		// Token: 0x04000AD0 RID: 2768
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysName_Col;

		// Token: 0x04000AD1 RID: 2769
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysID_Col;

		// Token: 0x04000AD2 RID: 2770
		internal global::Infragistics.Windows.DataPresenter.UnboundField UnitID_Col;

		// Token: 0x04000AD3 RID: 2771
		internal global::AcpUI.AcpExpander ExpCnvSysIDList;

		// Token: 0x04000AD4 RID: 2772
		internal global::AcpUI.AcpXamDataPresenter CnvSysIDDataPresenter;

		// Token: 0x04000AD5 RID: 2773
		internal global::AcpUI.AcpExpander ExpIndAstroOtarRadioIDList;

		// Token: 0x04000AD6 RID: 2774
		internal global::AcpUI.AcpViewOnlyCtrl LblSecWideASTROOTARIndividualASTROOTARRadioID;

		// Token: 0x04000AD7 RID: 2775
		internal global::AcpUI.AcpViewOnlyCtrl SecWideASTROOTARIndividualASTROOTARRadioID;

		// Token: 0x04000AD8 RID: 2776
		internal global::AcpUI.AcpXamDataPresenter IndAstroOtardRadioIDDataPresenter;

		// Token: 0x04000AD9 RID: 2777
		internal global::Infragistics.Windows.DataPresenter.UnboundField SecureKMFProfile_Col;

		// Token: 0x04000ADA RID: 2778
		internal global::Infragistics.Windows.DataPresenter.UnboundField IndAstroOtarRadioID_Col;

		// Token: 0x04000ADB RID: 2779
		internal global::AcpUI.AcpExpander ExpDataWide;

		// Token: 0x04000ADC RID: 2780
		internal global::AcpUI.AcpViewOnlyCtrl SubscriberIPAddress1;

		// Token: 0x04000ADD RID: 2781
		internal global::AcpUI.AcpViewOnlyCtrl DataWideGeneralSubscriberIPAddress1;

		// Token: 0x04000ADE RID: 2782
		internal global::AcpUI.AcpViewOnlyCtrl PeerIPAddress1;

		// Token: 0x04000ADF RID: 2783
		internal global::AcpUI.AcpViewOnlyCtrl DataWideGeneralPeerIPAddress1;

		// Token: 0x04000AE0 RID: 2784
		internal global::AcpUI.AcpViewOnlyCtrl BTSubscriberIPAddress;

		// Token: 0x04000AE1 RID: 2785
		internal global::AcpUI.AcpViewOnlyCtrl DataWideGeneralBTSubscriberIPAddress;

		// Token: 0x04000AE2 RID: 2786
		internal global::AcpUI.AcpViewOnlyCtrl BTPeerIPAddress;

		// Token: 0x04000AE3 RID: 2787
		internal global::AcpUI.AcpViewOnlyCtrl DataWideGeneralBTPeerIPAddress;

		// Token: 0x04000AE4 RID: 2788
		internal global::AcpUI.AcpExpander ExpDataProfileList;

		// Token: 0x04000AE5 RID: 2789
		internal global::AcpUI.AcpXamDataPresenter DataProfilesDataPresenter;

		// Token: 0x04000AE6 RID: 2790
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataProfileName_Col;

		// Token: 0x04000AE7 RID: 2791
		internal global::AcpUI.AcpExpander ExpUserInfo;

		// Token: 0x04000AE8 RID: 2792
		internal global::AcpUI.AcpViewOnlyCtrl SoftIDUsername;

		// Token: 0x04000AE9 RID: 2793
		internal global::AcpUI.AcpViewOnlyCtrl RadWideUserInformationandPasswordsSoftIDUsername;

		// Token: 0x04000AEA RID: 2794
		internal global::AcpUI.AcpViewOnlyCtrl LblUserInfoPINPassword;

		// Token: 0x04000AEB RID: 2795
		internal global::AcpUI.AcpPasswordEyeBox RadWideUserInformationandPasswordsPINPassword;

		// Token: 0x04000AEC RID: 2796
		internal global::AcpUI.AcpViewOnlyCtrl LblUserInfoUserLoginUnitID;

		// Token: 0x04000AED RID: 2797
		internal global::AcpUI.AcpViewOnlyCtrl RadWideUserInformationandPasswordsUserLoginUnitID;

		// Token: 0x04000AEE RID: 2798
		internal global::AcpUI.AcpViewOnlyCtrl LblRadioAlias;

		// Token: 0x04000AEF RID: 2799
		internal global::AcpUI.AcpViewOnlyCtrl RadWideUserInformationandPasswordsRadioAlias;

		// Token: 0x04000AF0 RID: 2800
		internal global::AcpUI.AcpExpander ExpBluetooth;

		// Token: 0x04000AF1 RID: 2801
		internal global::AcpUI.AcpViewOnlyCtrl BluetoothFriendlyName;

		// Token: 0x04000AF2 RID: 2802
		internal global::AcpUI.AcpViewOnlyCtrl RadWideBluetoothFriendlyName;

		// Token: 0x04000AF3 RID: 2803
		private bool q;

		// Token: 0x0200019D RID: 413
		// (Invoke) Token: 0x060013BA RID: 5050
		public delegate void MainUIDisplayOTAP(global::SpecialFeatures.Programming.ProgrammingOperation ProgOp, global::SpecialFeatures.Programming.OTAPProgrammingParameters LastCommsOTAPUserState, global::SpecialFeatures.Comms.Comms.RadioOTAPObject radioObject);

		// Token: 0x0200019E RID: 414
		// (Invoke) Token: 0x060013BE RID: 5054
		private delegate void UpdateProgress(double n, string stat);

		// Token: 0x0200019F RID: 415
		// (Invoke) Token: 0x060013C2 RID: 5058
		private delegate void MainFinish(bool status);

		// Token: 0x020001A0 RID: 416
		// (Invoke) Token: 0x060013C6 RID: 5062
		public delegate void WriteRadioQuery(global::SpecialFeatures.Comms.Comms.RadioRtn info);

		// Token: 0x020001A1 RID: 417
		// (Invoke) Token: 0x060013CA RID: 5066
		private delegate bool MainThreadUpdateRadioIds(global::SpecialFeatures.Comms.RadioIdInfo TempRadioIds);
	}
}
