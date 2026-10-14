using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Navigation;
using System.Xml;
using ACPBrowser;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AcpUtility;
using CommonResources;
using ConstraintHelper;
using MackinawCPS.HomeBase;
using MackinawCPS.Properties;
using Microsoft.Win32;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.Server.EntityModel;
using PreEmptive.SoS.Runtime;
using SpecialFeatures.RadioLanguagePack;

namespace MackinawCPS
{
	// Token: 0x02000036 RID: 54
	public partial class Options : PageFunction<string>, INotifyPropertyChanged
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00041464 File Offset: 0x0003F664
		internal Options(WindowMain parent)
		{
			int a_ = 18;
			this.initialLanguageSelection = string.Empty;
			this.reportLanguageSelection = string.Empty;
			this.initialSysKeysLocation = string.Empty;
			this.initialHomeScreenLogoPath = string.Empty;
			this.m_ARSAppInstallPath = string.Empty;
			this.m_AKAAppInstallPath = string.Empty;
			this.expanderlist = new Dictionary<string, AcpExpander>();
			base..ctor();
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
			this._parent = parent;
			this.parentWindowSettings = this._parent.settingsSavedOnAppExit;
			base.DataContext = this;
			if (Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
			{
				base.FlowDirection = System.Windows.FlowDirection.RightToLeft;
			}
			else
			{
				base.FlowDirection = System.Windows.FlowDirection.LeftToRight;
			}
			if (Thread.CurrentThread.CurrentCulture.Name.ToLower().StartsWith(FixedLengthStream.b("鏱蛳", a_)))
			{
				this.TxtDefKeyFileLocation.FlowDirection = System.Windows.FlowDirection.LeftToRight;
				this.TxtDefKeyFileLocation.TextAlignment = TextAlignment.Right;
				this.txtDefDVRSExportLocation.FlowDirection = System.Windows.FlowDirection.LeftToRight;
				this.txtDefDVRSExportLocation.TextAlignment = TextAlignment.Right;
			}
			this.SkipCloneExpressSysTypeCheck.IsChecked = new bool?(this.parentWindowSettings.BlockNewSysCheck);
			this.UploadLogToRemoteServerCheckBox.IsChecked = new bool?(this.parentWindowSettings.UploadToServer);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000415B8 File Offset: 0x0003F7B8
		private void OnLoad(object sender, RoutedEventArgs e)
		{
			int a_ = 0;
			short num = (short)1394081792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B5;
				}
				IEnumerator enumerator;
				AcpExpander acpExpander;
				for (;;)
				{
					IL_32:
					bool flag;
					bool flag2;
					switch (num2)
					{
					case 0:
						goto IL_301;
					case 1:
						if (!string.IsNullOrEmpty(this.parentWindowSettings.UserSelectedApplicationLanguage))
						{
							num = (short)1058340866;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_589;
					case 2:
						this.initialLanguageSelection = this.parentWindowSettings.UserSelectedApplicationLanguage;
						num = (short)1927282693;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						this.comboUpgradeRadioLanguageChoices.SelectedIndex = this.parentWindowSettings.UpgradeRadioLang;
						num = (short)879427599;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
						goto IL_681;
					case 5:
						goto IL_634;
					case 6:
						if (this.parentWindowSettings.UpgradeRadioLang > -1)
						{
							num = (short)176816154;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3AA;
					case 7:
						this.reportLanguageSelection = this.parentWindowSettings.UserSelectedReportsLanguage;
						num = (short)408682506;
						num2 = (int)((IntPtr)num);
						continue;
					case 8:
						goto IL_3CE;
					case 9:
					{
						num = (short)1728577536;
						short num3 = num;
						num = (short)676921360;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 10:
						goto IL_6F6;
					case 11:
					{
						CultureInfo cultureInfo = new CultureInfo(App.mainAssemblyCulture);
						this.reportLanguageChoices.SelectedItem = cultureInfo.NativeName;
						num = (short)2079981568;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 12:
						try
						{
							num = (short)492699649;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_50E;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_446;
									}
									continue;
								case 2:
									num = (short)714276864;
									num2 = (int)((IntPtr)num);
									continue;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)1760034818;
										num2 = (int)((IntPtr)num);
										continue;
									}
									acpExpander = (((UIElement)enumerator.Current) as AcpExpander);
									num = (short)271122438;
									num2 = (int)((IntPtr)num);
									continue;
								case 5:
									this.expanderlist.Add(acpExpander.Name, acpExpander);
									num = (short)1605369860;
									num2 = (int)((IntPtr)num);
									continue;
								case 6:
									if (acpExpander != null)
									{
										num = (short)1426128901;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								IL_4B6:
								num = (short)1705771011;
								num2 = (int)((IntPtr)num);
								continue;
								IL_446:
								goto IL_4B6;
							}
							IL_50E:
							goto IL_928;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_530;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_51D:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)272760833;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									goto IL_586;
								case 2:
									if (disposable != null)
									{
										num = (short)242679808;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_588;
								}
								goto IL_530;
							}
							IL_586:
							IL_588:
							goto EndFinally_27;
							IL_530:
							disposable = (enumerator as IDisposable);
							num = (short)558956546;
							num2 = (int)((IntPtr)num);
							goto IL_51D;
							EndFinally_27:;
						}
						goto IL_589;
						IL_928:
						this.ExpanderOptionsGeneral.Focus();
						num = (short)873332737;
						num2 = (int)((IntPtr)num);
						continue;
					case 13:
						try
						{
							num = (short)124715014;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									KeyValuePair<string, string> keyValuePair;
									if (keyValuePair.Value == this.reportLanguageSelection)
									{
										num = (short)2023882756;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)276168709;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
									goto IL_B08;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1978662913;
										num2 = (int)((IntPtr)num);
										continue;
									}
									KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)enumerator.Current;
									num = (short)37355520;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 4:
								{
									KeyValuePair<string, string> keyValuePair;
									this.reportLanguageChoices.SelectedItem = keyValuePair.Key;
									flag = true;
									num = (short)1917583362;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 5:
									goto IL_B25;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_A51;
									}
									continue;
								}
								IL_A53:
								num = (short)28704771;
								num2 = (int)((IntPtr)num);
								continue;
								IL_A51:
								goto IL_A53;
							}
							IL_B08:
							IL_B25:
							goto IL_245;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_B47;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_B34:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)2083127297;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									goto IL_B9C;
								case 2:
									if (disposable != null)
									{
										num = (short)2020016128;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_B9E;
								}
								goto IL_B47;
							}
							IL_B9C:
							IL_B9E:
							goto EndFinally_26;
							IL_B47:
							disposable = (enumerator as IDisposable);
							num = (short)626786306;
							num2 = (int)((IntPtr)num);
							goto IL_B34;
							EndFinally_26:;
						}
						goto IL_B9F;
					case 14:
						num = (short)466354177;
						if (num != 0)
						{
						}
						if (!AppResources.Culture.Name.Contains(FixedLengthStream.b("藟釡", a_)))
						{
							num = (short)1208025097;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2CC;
					case 15:
						goto IL_9DD;
					case 16:
						if (AppResources.Culture.Name.Contains(FixedLengthStream.b("臟郡", a_)))
						{
							num = (short)682033171;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.initialLanguageSelection = AppResources.Culture.Name;
						num = (short)620167197;
						num2 = (int)((IntPtr)num);
						continue;
					case 17:
						if (!flag)
						{
							num = (short)1633026059;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_301;
					case 18:
						goto IL_6F6;
					case 19:
						goto IL_2CC;
					case 20:
						if (!string.IsNullOrEmpty(this.parentWindowSettings.UserSelectedReportsLanguage))
						{
							num = (short)2112421895;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.reportLanguageSelection = FixedLengthStream.b("藟賡", a_);
						num = (short)1271660562;
						num2 = (int)((IntPtr)num);
						continue;
					case 21:
						this.reportLanguageChoices.SelectedIndex = 0;
						flag = true;
						num = (short)1425539100;
						num2 = (int)((IntPtr)num);
						continue;
					case 22:
					{
						CultureInfo cultureInfo2 = new CultureInfo(App.mainAssemblyCulture);
						this.comboLanguageChoices.SelectedItem = cultureInfo2.NativeName;
						num = (short)370933764;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 23:
						try
						{
							num = (short)1600192518;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1636696068;
										num2 = (int)((IntPtr)num);
										continue;
									}
									KeyValuePair<string, string> keyValuePair2 = (KeyValuePair<string, string>)enumerator.Current;
									num = (short)757923843;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 1:
								{
									num = (short)1105328200;
									short num4 = num;
									num = (short)63699016;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_869;
									default:
									{
										num = (short)1195245568;
										if (num != 0)
										{
										}
										KeyValuePair<string, string> keyValuePair2;
										this.comboLanguageChoices.SelectedItem = keyValuePair2.Key;
										flag2 = true;
										num = (short)306970626;
										num2 = (int)((IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 2:
									goto IL_869;
								case 3:
								{
									KeyValuePair<string, string> keyValuePair2;
									if (keyValuePair2.Value == this.initialLanguageSelection)
									{
										num = (short)341245953;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)663224325;
									num2 = (int)((IntPtr)num);
									continue;
								case 5:
									goto IL_886;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_762;
									}
									continue;
								}
								IL_7FF:
								num = (short)951255040;
								num2 = (int)((IntPtr)num);
								continue;
								IL_762:
								goto IL_7FF;
							}
							IL_869:
							IL_886:
							goto IL_103;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_8A8;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_895:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)2106654721;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									goto IL_8FD;
								case 2:
									if (disposable != null)
									{
										num = (short)552665088;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_8FF;
								}
								goto IL_8A8;
							}
							IL_8FD:
							IL_8FF:
							goto EndFinally_25;
							IL_8A8:
							disposable = (enumerator as IDisposable);
							num = (short)1526661122;
							num2 = (int)((IntPtr)num);
							goto IL_895;
							EndFinally_25:;
						}
						goto IL_900;
						IL_103:
						num = (short)871104537;
						num2 = (int)((IntPtr)num);
						continue;
					case 24:
						goto IL_634;
					case 25:
						if (this.reportLanguageSelection == FixedLengthStream.b("냟郡诣该飧黩", a_))
						{
							num = (short)2108030997;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_900;
					case 26:
						num = (short)1805713438;
						num2 = (int)((IntPtr)num);
						continue;
					case 27:
						if (!flag2)
						{
							num = (short)608043030;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_681;
					case 28:
						goto IL_245;
					case 29:
						goto IL_634;
					case 30:
						if (this.parentWindowSettings.UpgradeRadioLang < 3)
						{
							num = (short)836632579;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3AA;
					}
					goto IL_B5;
					IL_245:
					num = (short)1996488731;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2CC:
					this.initialLanguageSelection = AppResources.Culture.Name.Substring(0, 2);
					num = (short)434372632;
					num2 = (int)((IntPtr)num);
					continue;
					IL_301:
					this.initialLanguageSelection = (string)this.comboLanguageChoices.SelectedItem;
					this.initialSysKeysLocation = this._parent.defaultKeyFilesLocation;
					this.UpdateKeyFilesLocationCtrl();
					this.txtDefDVRSExportLocation.Text = this.setDefaultDVRSExportLocation();
					this.txtDefDVRSExportLocation.ToolTip = this.txtDefDVRSExportLocation.Text;
					this.initialHomeScreenLogoPath = Settings.Default.CustomBackgroudPath;
					num = (short)1064435718;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3AA:
					this.comboUpgradeRadioLanguageChoices.SelectedIndex = 0;
					num = (short)901185544;
					num2 = (int)((IntPtr)num);
					continue;
					IL_589:
					num = (short)1560543246;
					num2 = (int)((IntPtr)num);
					continue;
					IL_634:
					num = (short)133627924;
					num2 = (int)((IntPtr)num);
					continue;
					IL_681:
					num = (short)592838673;
					num2 = (int)((IntPtr)num);
					continue;
					IL_6F6:
					flag2 = false;
					flag = false;
					enumerator = ((IEnumerable)App.AdditionalCPSLanguages).GetEnumerator();
					num = (short)61603863;
					num2 = (int)((IntPtr)num);
					continue;
					IL_900:
					enumerator = ((IEnumerable)App.AdditionalCPSLanguages).GetEnumerator();
					num = (short)1035796493;
					num2 = (int)((IntPtr)num);
				}
				IL_3CE:
				IL_9DD:
				IL_B9F:
				this.comboLanguageChoices.SelectionChanged += new SelectionChangedEventHandler(this.comboLanguageChoices_SelectionChanged);
				return;
				IL_B5:
				this.comboLanguageChoices.SelectionChanged -= new SelectionChangedEventHandler(this.comboLanguageChoices_SelectionChanged);
				this.PopulateComboBox();
				acpExpander = null;
				enumerator = this.MyStackPanel.Children.GetEnumerator();
				num = (short)278265868;
				num2 = (int)((IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600013E RID: 318 RVA: 0x000421C8 File Offset: 0x000403C8
		public static Visibility IsAdditionalLanguageCountGTEOne
		{
			get
			{
				short num;
				if (App.AdditionalCPSLanguages.Count >= 1)
				{
					for (;;)
					{
						num = (short)1167185413;
						short num2 = num;
						num = (short)760010245;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							goto IL_6D;
						}
						break;
					}
					num = (short)2131296256;
					short num3 = num;
					IL_6D:
					num = (short)484048896;
					if (num != 0)
					{
					}
					return Visibility.Visible;
				}
				num = (short)840630273;
				if (num != 0)
				{
				}
				return Visibility.Collapsed;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00042284 File Offset: 0x00040484
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00042334 File Offset: 0x00040534
		public WindowMain MainFrame
		{
			get
			{
				short num = (short)1927806977;
				if (num != 0)
				{
				}
				num = (short)1870921728;
				short num2 = num;
				num = (short)1549669447;
				short num3 = num;
				num = (short)2044269639;
				switch (num3 == num)
				{
				}
				num = (short)726728704;
				if (num != 0)
				{
				}
				return this._parent;
			}
			set
			{
				int a_ = 11;
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				short num2;
				for (;;)
				{
					IL_13:
					int num;
					switch (num)
					{
					case 0:
						this.PropertyChanged(this, new PropertyChangedEventArgs(FixedLengthStream.b("ꛪ賬蛮鿰뗲蟴零铸黺", a_)));
						num2 = (short)753991681;
						num = (int)((IntPtr)num2);
						continue;
					case 1:
						goto IL_10B;
					case 2:
						goto IL_8C;
					}
					goto IL_25;
				}
				IL_8C:
				if (this.PropertyChanged != null)
				{
					goto IL_94;
				}
				IL_10B:
				num2 = (short)1408892928;
				short num3 = num2;
				return;
				IL_25:
				num2 = (short)1405461805;
				short num4 = num2;
				num2 = (short)2093131053;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_94:
					num2 = (short)135004161;
					if (num2 != 0)
					{
					}
					num2 = (short)2063859712;
					int num = (int)((IntPtr)num2);
					goto IL_13;
				}
				default:
				{
					num2 = (short)1226833920;
					if (num2 != 0)
					{
					}
					this._parent = value;
					num2 = (short)1093664770;
					int num = (int)((IntPtr)num2);
					goto IL_13;
				}
				}
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00042478 File Offset: 0x00040678
		private void HomeScreenButton_click(object sender, RoutedEventArgs e)
		{
			short num = (short)1194328065;
			if (num != 0)
			{
			}
			num = (short)1631059968;
			short num2 = num;
			num = (short)759828940;
			short num3 = num;
			num = (short)2096697804;
			switch (num3 == num)
			{
			}
			num = (short)875298816;
			if (num != 0)
			{
			}
			this._parent.OnAppCustomizeOpen(sender, e);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00042530 File Offset: 0x00040730
		private void HomeScreenRestoreDefault_click(object sender, RoutedEventArgs e)
		{
			short num = (short)705268921;
			short num2 = num;
			num = (short)1591184569;
			switch (num2 == num)
			{
			default:
			{
				num = (short)721289216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)896008193;
			if (num != 0)
			{
			}
			num = (short)946339840;
			if (num != 0)
			{
			}
			this._parent.OnAppRestoreToDefault(sender, e);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000425EC File Offset: 0x000407EC
		private void buttonOK_Click(object sender, RoutedEventArgs e)
		{
			int a_ = 18;
			short num = (short)1504772096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_10D;
				}
				bool flag;
				string text;
				string text2;
				for (;;)
				{
					IL_30:
					num = (short)334364672;
					short num3 = num;
					bool? isChecked;
					CultureInfo cultureInfo;
					string text3;
					switch (num2)
					{
					case 0:
						if (isChecked != null)
						{
							num = (short)1450639371;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_552;
					case 1:
						goto IL_3D5;
					case 2:
						goto IL_49F;
					case 3:
						if (this.initialSysKeysLocation != this._parent.defaultKeyFilesLocation)
						{
							num = (short)342228996;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1BB;
					case 4:
						num = (short)1004732448;
						num2 = (int)((IntPtr)num);
						continue;
					case 5:
						goto IL_24C;
					case 6:
						if (flag)
						{
							num = (short)2063138824;
							num2 = (int)((IntPtr)num);
							continue;
						}
						flag = true;
						num = (short)678821916;
						num2 = (int)((IntPtr)num);
						continue;
					case 7:
						if (text.Contains(cultureInfo.NativeName))
						{
							num = (short)1651179555;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.parentWindowSettings.SelectedHelpLanguage_RootDir = string.Format(FixedLengthStream.b("뫱釳髵裷臹쳻菽篿㌁礃紅㠇眉", a_), Path.DirectorySeparatorChar, App.AdditionalCPSLanguages[text]);
						this.parentWindowSettings.UserSelectedApplicationLanguage = App.AdditionalCPSLanguages[text];
						num = (short)683016217;
						num2 = (int)((IntPtr)num);
						continue;
					case 8:
						text2 += FixedLengthStream.b("", a_);
						num = (short)1392181253;
						num2 = (int)((IntPtr)num);
						continue;
					case 9:
						goto IL_329;
					case 10:
						goto IL_1BB;
					case 11:
					{
						isChecked = this.UploadLogToRemoteServerCheckBox.IsChecked;
						bool value = isChecked.Value;
						this.parentWindowSettings.UploadToServer = value;
						num = (short)745799686;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 12:
						text2 += FixedLengthStream.b("", a_);
						num = (short)1823080487;
						num2 = (int)((IntPtr)num);
						continue;
					case 13:
						num = (short)33161217;
						if (num != 0)
						{
						}
						if (this.initialLanguageSelection != AppResources.Culture.NativeName)
						{
							num = (short)483983383;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_49F;
					case 14:
						this._parent.defaultDVRSFileLocation = this.txtDefDVRSExportLocation.Text;
						this.parentWindowSettings.DVRS_Export_Default_Folder = this.txtDefDVRSExportLocation.Text;
						UtilityMack.DVRSExportPath = this.txtDefDVRSExportLocation.Text;
						num = (short)351272961;
						num2 = (int)((IntPtr)num);
						continue;
					case 15:
						goto IL_4E7;
					case 16:
						this.parentWindowSettings.UpgradeRadioLang = this.comboUpgradeRadioLanguageChoices.SelectedIndex;
						LanguagePackHelper.UpgradRadioLangSetting = this.comboUpgradeRadioLanguageChoices.SelectedIndex;
						num = (short)563740714;
						num2 = (int)((IntPtr)num);
						continue;
					case 17:
						if (this.parentWindowSettings.UpgradeRadioLang != this.comboUpgradeRadioLanguageChoices.SelectedIndex)
						{
							num = (short)1105788944;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_6CD;
					case 18:
						num = (short)2131689485;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
						goto IL_16C;
					case 20:
						goto IL_32E;
					case 21:
						goto IL_5D6;
					case 22:
					{
						num = (short)36465199;
						short num4 = num;
						num = (short)1499228719;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5D6;
						default:
							num = (short)993722368;
							if (num != 0)
							{
							}
							if (flag)
							{
								num = (short)2008547349;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_306;
						}
						break;
					}
					case 23:
						goto IL_89C;
					case 24:
						this.parentWindowSettings.BlockNewSysCheck = true;
						num = (short)1063518227;
						num2 = (int)((IntPtr)num);
						continue;
					case 25:
						goto IL_4E7;
					case 26:
						if (isChecked.Value)
						{
							num = (short)1929052184;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.parentWindowSettings.BlockNewSysCheck = false;
						num = (short)974651419;
						num2 = (int)((IntPtr)num);
						continue;
					case 27:
						goto IL_16C;
					case 28:
						goto IL_24C;
					case 29:
						goto IL_552;
					case 30:
						if (isChecked != null)
						{
							num = (short)817496101;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_16C;
					case 31:
						goto IL_306;
					case 32:
						if (flag)
						{
							num = (short)181075980;
							num2 = (int)((IntPtr)num);
							continue;
						}
						flag = true;
						num = (short)16187412;
						num2 = (int)((IntPtr)num);
						continue;
					case 33:
					{
						if (this.reportLanguageChoices.SelectedIndex == 0)
						{
							num = (short)1841823782;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.parentWindowSettings.ReportLangDia = false;
						string culture = (string)this.reportLanguageChoices.SelectedItem;
						this.parentWindowSettings.UserSelectedReportsLanguage = App.AdditionalCPSLanguages[culture];
						num = (short)1905000484;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 34:
						goto IL_79A;
					case 35:
						this.parentWindowSettings.SelectedHelpLanguage_RootDir = string.Format(FixedLengthStream.b("뫱釳髵裷臹쳻菽篿㌁礃紅㠇眉", a_), Path.DirectorySeparatorChar, text3);
						this.parentWindowSettings.UserSelectedApplicationLanguage = text3;
						num = (short)257425423;
						num2 = (int)((IntPtr)num);
						continue;
					case 36:
						goto IL_79A;
					case 37:
						isChecked = this.SkipCloneExpressSysTypeCheck.IsChecked;
						num = (short)289079322;
						num2 = (int)((IntPtr)num);
						continue;
					case 38:
						this.parentWindowSettings.ReportLangDia = true;
						this.parentWindowSettings.UserSelectedReportsLanguage = FixedLengthStream.b("ꋱ蛳駵闷諹裻", a_);
						num = (short)1639055394;
						num2 = (int)((IntPtr)num);
						continue;
					case 39:
						goto IL_32E;
					case 40:
						if (!(this.initialLanguageSelection != text))
						{
							num = (short)323551250;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_89C;
					case 41:
						if (this._parent.defaultDVRSFileLocation != this.txtDefDVRSExportLocation.Text)
						{
							num = (short)1784217614;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3D5;
					case 42:
						goto IL_6CD;
					}
					goto IL_10D;
					IL_16C:
					isChecked = this.UploadLogToRemoteServerCheckBox.IsChecked;
					num = (short)1723990016;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1BB:
					isChecked = this.SkipCloneExpressSysTypeCheck.IsChecked;
					num = (short)1020854302;
					num2 = (int)((IntPtr)num);
					continue;
					IL_24C:
					text2 += AppResources.APXCPS_Logging_Change_Notification;
					num = (short)1751908381;
					num2 = (int)((IntPtr)num);
					continue;
					IL_306:
					Settings.Default.Save();
					num = (short)686882825;
					num2 = (int)((IntPtr)num);
					continue;
					IL_32E:
					text2 += AppResources.System_Key_Files_Location_changes_will_go;
					num = (short)1296695306;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3D5:
					num = (short)92143619;
					num2 = (int)((IntPtr)num);
					continue;
					IL_49F:
					num = (short)1668022305;
					num2 = (int)((IntPtr)num);
					continue;
					IL_4E7:
					flag = true;
					text2 += AppResources.CPS_Language_changes_will_go_into;
					num = (short)995229698;
					num2 = (int)((IntPtr)num);
					continue;
					IL_552:
					num = (short)418709526;
					num2 = (int)((IntPtr)num);
					continue;
					IL_5D6:
					System.Windows.MessageBox.Show(text2, AppResources.CPS_Options, MessageBoxButton.OK, MessageBoxImage.Asterisk);
					num = (short)1080950815;
					num2 = (int)((IntPtr)num);
					continue;
					IL_6CD:
					num = (short)1381171241;
					num2 = (int)((IntPtr)num);
					continue;
					IL_79A:
					num = (short)1854668817;
					num2 = (int)((IntPtr)num);
					continue;
					IL_89C:
					cultureInfo = new CultureInfo(App.mainAssemblyCulture);
					text3 = FixedLengthStream.b("韱髳", a_);
					num = (short)1962868743;
					num2 = (int)((IntPtr)num);
				}
				IL_329:
				try
				{
					this.SaveUserConfig();
				}
				catch (Exception)
				{
				}
				((Window)base.Parent).Close();
				return;
				IL_10D:
				text2 = string.Empty;
				flag = false;
				text = (string)this.comboLanguageChoices.SelectedItem;
				num = (short)262012968;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00042F74 File Offset: 0x00041174
		private void buttonCancel_Click(object sender, RoutedEventArgs e)
		{
			short num = (short)691077129;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1B0;
				case 1:
					((PageCustomViewWelcome)this._parent.FrameCenterTop.Content).SetBackground(this.initialHomeScreenLogoPath);
					num = (short)1289617408;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
				{
					if (this._parent.FrameCenterTop.Content is PageWelcome)
					{
						num = (short)1406599178;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)547473478;
					short num3 = num;
					num = (short)1311688774;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_163;
					default:
						num = (short)367329280;
						if (num != 0)
						{
						}
						num = (short)998178824;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					num = (short)1026883585;
					if (num != 0)
					{
					}
					if (this.initialSysKeysLocation != this._parent.defaultKeyFilesLocation)
					{
						num = (short)693370880;
						short num4 = num;
						num = (short)1292173316;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2E8;
				case 4:
					this._parent.defaultKeyFilesLocation = this.initialSysKeysLocation;
					num = (short)978518027;
					num2 = (int)((IntPtr)num);
					continue;
				case 5:
					goto IL_1B0;
				case 6:
					goto IL_163;
				case 7:
					goto IL_1B0;
				case 8:
					if (this._parent.FrameCenterTop.Content is PageCustomViewWelcome)
					{
						num = (short)1468792833;
						num2 = (int)((IntPtr)num);
						continue;
					}
					Settings.Default.CustomBackgroudPath = this.initialHomeScreenLogoPath;
					Settings.Default.Save();
					num = (short)1366425605;
					num2 = (int)((IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 10:
					((PageWelcome)this._parent.FrameCenterTop.Content).SetBackground(this.initialHomeScreenLogoPath);
					num = (short)1397882887;
					num2 = (int)((IntPtr)num);
					continue;
				case 11:
					goto IL_15E;
				}
				IL_54:
				if (this.initialHomeScreenLogoPath != Settings.Default.CustomBackgroudPath)
				{
					num = (short)1590689798;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_1B0;
				IL_163:
				num = (short)597229570;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1B0:
				num = (short)1045823491;
				num2 = (int)((IntPtr)num);
			}
			IL_15E:
			IL_2E8:
			((Window)base.Parent).Close();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0004327C File Offset: 0x0004147C
		private void SaveUserConfig()
		{
			int a_ = 4;
			short num = (short)638517248;
			switch (num)
			{
			default:
			{
				num = (short)1213661191;
				int num2 = (int)((IntPtr)num);
				string text;
				XmlDocument xmlDocument;
				for (;;)
				{
					string text2;
					switch (num2)
					{
					case 0:
					{
						XmlNode xmlNode;
						if (xmlNode == null)
						{
							num = (short)1005846536;
							num2 = (int)((IntPtr)num);
							continue;
						}
						xmlNode.InnerText = this.parentWindowSettings.UserSelectedApplicationLanguage;
						num = (short)662568969;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 1:
						if (File.Exists(text))
						{
							num = (short)580583429;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_38C;
					case 2:
						Directory.CreateDirectory(text2);
						num = (short)910360580;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						goto IL_18C;
					case 4:
					{
						num = (short)1177164283;
						short num3 = num;
						num = (short)1670453755;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_33D;
						default:
							num = (short)1341521920;
							if (num != 0)
							{
							}
							goto IL_191;
						}
						break;
					}
					case 5:
					{
						xmlDocument = new XmlDocument();
						xmlDocument.Load(text);
						XmlNode xmlNode = xmlDocument.SelectSingleNode(FixedLengthStream.b("쯣藥蟧蓩諫蟭韯蟱蛳韵賷鏹鏻都⿿省眃挅稇変椋稍搏笑稓焕欗㔙儛缝䌟䤡䴣䠥䤧崩漫縭振ᰱ搳䐵圷䨹夻䰽㐿⭁⅃㕅晇᥉⥋㩍⑏㭑㩓ㅕ⭗留⽛㭝ᑟᙡൣࡥཧㅩⱫmᅯάᅳ䭵彷⽹ཻ᭽톁펑ﾛﾝ풟쮡쮣좥쮩슫즭얯펱펳펵龷鎻좽ꆿ껁뇃ꏅ", a_));
						num = (short)1580204032;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 6:
						goto IL_33D;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_74;
						}
						continue;
					case 8:
					{
						XmlNode xmlNode2 = xmlDocument.SelectSingleNode(FixedLengthStream.b("쯣藥蟧蓩諫蟭韯蟱蛳韵賷鏹鏻都⿿省眃挅稇変椋稍搏笑稓焕欗㔙儛缝䌟䤡䴣䠥䤧崩漫縭振ᰱ搳䐵圷䨹夻䰽㐿⭁⅃㕅晇᥉⥋㩍⑏㭑㩓ㅕ⭗", a_));
						XmlElement xmlElement = xmlDocument.CreateElement(FixedLengthStream.b("韣菥鳧黩藫胭韯", a_));
						xmlElement.SetAttribute(FixedLengthStream.b("諣蟥藧迩", a_), FixedLengthStream.b("뇣闥跧飩뿫语鳯韱音苵鷷黹뷻軽烿渁洃攅椇縉攋愍縏帑甓砕缗漙紛礝䔟", a_));
						xmlElement.SetAttribute(FixedLengthStream.b("韣菥髧菩跫苭駯裱釳럵请", a_), FixedLengthStream.b("럣鋥髧菩苫觭", a_));
						XmlElement xmlElement2 = xmlDocument.CreateElement(FixedLengthStream.b("鋣蟥蓧鿩觫", a_));
						xmlElement2.InnerText = this.parentWindowSettings.UserSelectedApplicationLanguage;
						xmlElement.AppendChild(xmlElement2);
						xmlNode2.AppendChild(xmlElement);
						num = (short)110493699;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 9:
						goto IL_229;
					}
					goto IL_74;
					IL_191:
					text = text2 + FixedLengthStream.b("룣鏥鯧迩黫迭胯英\udaf3闵韷铹髻韽柿", a_);
					num = (short)69861377;
					num2 = (int)((IntPtr)num);
					continue;
					IL_33D:
					if (!Directory.Exists(text2))
					{
						num = (short)435879937;
						if (num != 0)
						{
						}
						num = (short)1419444226;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_191;
					IL_74:
					string str = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + FixedLengthStream.b("룣ꯥ蟧黩菫鳭鿯黱闳꧵꯷闹郻诽瓿欁欃栅笇☉匋䜍縏焑", a_);
					text2 = string.Empty;
					text = string.Empty;
					string str2 = string.Empty;
					object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false);
					if (customAttributes.Length == 0)
					{
						str2 = string.Empty;
					}
					else
					{
						str2 = ((AssemblyInformationalVersionAttribute)customAttributes[0]).InformationalVersion.Substring(1, 2);
					}
					text2 = str + FixedLengthStream.b("룣", a_) + str2;
					num = (short)245563398;
					num2 = (int)((IntPtr)num);
				}
				IL_18C:
				IL_229:
				xmlDocument.Save(text);
				return;
				IL_38C:
				num = (short)556793856;
				short num4 = num;
				XmlDocument xmlDocument2 = new XmlDocument();
				XmlDeclaration newChild = xmlDocument2.CreateXmlDeclaration(FixedLengthStream.b("헣죥\ud8e7", a_), FixedLengthStream.b("釣鋥軧쟩퓫", a_), null);
				xmlDocument2.AppendChild(newChild);
				XmlNode xmlNode3 = xmlDocument2.CreateElement(FixedLengthStream.b("蟣觥蛧賩藫觭藯胱闳苵釷闹鋻", a_));
				XmlElement xmlElement3 = xmlDocument2.CreateElement(FixedLengthStream.b("釣闥跧飩뿫语蓯蛱鷳飵鿷觹", a_));
				XmlElement xmlElement4 = xmlDocument2.CreateElement(FixedLengthStream.b("ꧣ蟥诧臩藫胭釯藱럳꛵꯷퓹곻賽濿爁愃琅簇按椋納㸏䄑焓戕気猙爛礝匟", a_));
				XmlElement xmlElement5 = xmlDocument2.CreateElement(FixedLengthStream.b("韣菥鳧黩藫胭韯", a_));
				xmlElement5.SetAttribute(FixedLengthStream.b("諣蟥藧迩", a_), FixedLengthStream.b("뇣闥跧飩뿫语鳯韱音苵鷷黹뷻軽烿渁洃攅椇縉攋愍縏帑甓砕缗漙紛礝䔟", a_));
				xmlElement5.SetAttribute(FixedLengthStream.b("韣菥髧菩跫苭駯裱釳럵请", a_), FixedLengthStream.b("럣鋥髧菩苫觭", a_));
				XmlElement xmlElement6 = xmlDocument2.CreateElement(FixedLengthStream.b("鋣蟥蓧鿩觫", a_));
				xmlElement6.InnerText = this.parentWindowSettings.UserSelectedApplicationLanguage;
				xmlElement5.AppendChild(xmlElement6);
				xmlElement4.AppendChild(xmlElement5);
				xmlElement3.AppendChild(xmlElement4);
				xmlNode3.AppendChild(xmlElement3);
				xmlDocument2.AppendChild(xmlNode3);
				xmlDocument2.Save(text);
				return;
			}
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00043770 File Offset: 0x00041970
		private void PopulateComboBox()
		{
			short num = (short)208142336;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)780730378;
				num2 = (int)((IntPtr)num);
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_289;
					case 1:
					{
						IEnumerator enumerator = ((IEnumerable)App.AdditionalCPSLanguages).GetEnumerator();
						num = (short)1557331972;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 2:
						if ((this.reportLanguageChoices.Items[num3] as ComboBoxItem).Content.ToString().Contains(AppResources.Prompt_Id))
						{
							num = (short)1110835208;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)572325889;
						if (num != 0)
						{
						}
						num3++;
						num = (short)115146758;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1940809458;
						short num4 = num;
						num = (short)249652978;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_149;
						default:
							num = (short)553975808;
							if (num != 0)
							{
							}
							goto IL_176;
						}
						break;
					}
					case 4:
						try
						{
							num = (short)148897796;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)285409283;
									num2 = (int)((IntPtr)num);
									continue;
								case 2:
								{
									IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1243545600;
										num2 = (int)((IntPtr)num);
										continue;
									}
									KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)enumerator.Current;
									num = (short)165806086;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 3:
									goto IL_419;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_336;
									}
									continue;
								case 5:
								{
									KeyValuePair<string, string> keyValuePair;
									this.comboLanguageChoices.Items.Add(keyValuePair.Key);
									this.reportLanguageChoices.Items.Add(keyValuePair.Key);
									num = (short)1805254657;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 6:
								{
									KeyValuePair<string, string> keyValuePair;
									if (keyValuePair.Key != null)
									{
										num = (short)1584726021;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_338:
								num = (short)229638146;
								num2 = (int)((IntPtr)num);
								continue;
								IL_336:
								goto IL_338;
							}
							IL_419:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_43B;
							}
							IDisposable disposable;
							for (;;)
							{
								IL_428:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)233701378;
										num2 = (int)((IntPtr)num);
										continue;
									}
									goto IL_48F;
								case 1:
									goto IL_48D;
								case 2:
									disposable.Dispose();
									num = (short)990576641;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_43B;
							}
							IL_48D:
							IL_48F:
							goto EndFinally_10;
							IL_43B:
							IEnumerator enumerator;
							disposable = (enumerator as IDisposable);
							num = (short)825688064;
							num2 = (int)((IntPtr)num);
							goto IL_428;
							EndFinally_10:;
						}
						goto IL_490;
					case 5:
						goto IL_289;
					case 6:
						goto IL_176;
					case 7:
					{
						CultureInfo cultureInfo = new CultureInfo(App.mainAssemblyCulture);
						this.comboLanguageChoices.Items.Add(cultureInfo.NativeName);
						this.reportLanguageChoices.Items.Add(cultureInfo.NativeName);
						num = (short)819986443;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 8:
						goto IL_149;
					case 9:
						return;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_77;
						}
						continue;
					case 11:
						if (App.AdditionalCPSLanguages.Count > 0)
						{
							num = (short)796655617;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 12:
						if (num3 >= this.reportLanguageChoices.Items.Count)
						{
							num = (short)211615744;
							short num5 = num;
							num = (short)1328939008;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)617218050;
						num2 = (int)((IntPtr)num);
						continue;
					}
					IL_77:
					if (!VersionInfoHelper.IsDFlagExisted(DFlagType.DASTRO))
					{
						num = (short)1169162247;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_490;
					IL_149:
					int removeIndex = num3;
					num = (short)1414266885;
					num2 = (int)((IntPtr)num);
					continue;
					IL_176:
					num = (short)55902220;
					num2 = (int)((IntPtr)num);
					continue;
					IL_289:
					this.reportLanguageChoices.Items.RemoveAt(removeIndex);
					CultureInfo cultureInfo2 = new CultureInfo(App.mainAssemblyCulture);
					this.comboLanguageChoices.Items.Add(cultureInfo2.NativeName);
					this.reportLanguageChoices.Items.Add(cultureInfo2.NativeName);
					num = (short)2108882953;
					num2 = (int)((IntPtr)num);
					continue;
					IL_490:
					removeIndex = 0;
					num3 = 0;
					num = (short)1260912643;
					num2 = (int)((IntPtr)num);
				}
				return;
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00043C98 File Offset: 0x00041E98
		private void OnSetDefKeyFileLocation(object sender, RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			FolderBrowserDialog folderBrowserDialog;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					this.TxtDefKeyFileLocation.Text = folderBrowserDialog.SelectedPath;
					this.TxtDefKeyFileLocation.ToolTip = folderBrowserDialog.SelectedPath;
					this._parent.defaultKeyFilesLocation = folderBrowserDialog.SelectedPath;
					num2 = (short)1534132229;
					num = (int)((IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)931271617;
					short num3 = num2;
					num2 = (short)172102593;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F9;
					default:
						num2 = (short)1870921728;
						if (num2 != 0)
						{
						}
						folderBrowserDialog.SelectedPath = this._parent.defaultKeyFilesLocation;
						num2 = (short)1912471554;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
				{
					num2 = (short)1010106368;
					short num4 = num2;
					goto IL_F9;
				}
				case 3:
					if (Directory.Exists(this._parent.defaultKeyFilesLocation))
					{
						num2 = (short)1568931841;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_F9;
				case 4:
					if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
					{
						num2 = (short)310968320;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 5:
					goto IL_CD;
				}
				goto IL_28;
				IL_F9:
				folderBrowserDialog.Description = AppResources.Select_the_directory_that_contains_key_files;
				num2 = (short)1345847300;
				num = (int)((IntPtr)num2);
			}
			IL_CD:
			num2 = (short)624361473;
			if (num2 != 0)
			{
			}
			return;
			IL_28:
			folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = true;
			folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
			num2 = (short)1623654403;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00043E90 File Offset: 0x00042090
		private void UpdateKeyFilesLocationCtrl()
		{
			short num = (short)1428972106;
			short num2 = num;
			num = (short)131293770;
			switch (num2 == num)
			{
			}
			num = (short)448135168;
			if (num != 0)
			{
			}
			num = (short)1954676736;
			short num3 = num;
			num = (short)832897025;
			if (num != 0)
			{
			}
			this.TxtDefKeyFileLocation.Text = this._parent.defaultKeyFilesLocation;
			this.TxtDefKeyFileLocation.ToolTip = this._parent.defaultKeyFilesLocation;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00043F68 File Offset: 0x00042168
		private void F1HelpCommandCanExcute(object sender, CanExecuteRoutedEventArgs e)
		{
			short num = (short)468371385;
			short num2 = num;
			num = (short)1357891513;
			switch (num2 == num)
			{
			}
			num = (short)1696792577;
			if (num != 0)
			{
			}
			num = (short)1990328320;
			short num3 = num;
			num = (short)1968046080;
			if (num != 0)
			{
			}
			e.CanExecute = true;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00044018 File Offset: 0x00042218
		private void onHelpButton_Click(object sender, RoutedEventArgs e)
		{
			int a_ = 15;
			short num;
			try
			{
				num = (short)758763288;
				short num2 = num;
				num = (short)1639173912;
				switch (num2 == num)
				{
				}
				num = (short)1559363584;
				if (num != 0)
				{
				}
				ACPBrowser.Utility.CloseHelpWindowIfOpen();
				ACPBrowser.Utility.DisplayCPSHelpDITA(FixedLengthStream.b("쳮闰쫲鏴银鯸飺駼쟾", a_));
			}
			catch (Exception)
			{
			}
			num = (short)1832714240;
			short num3 = num;
			num = (short)1402208257;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000440F8 File Offset: 0x000422F8
		private void ButtonLaunchARSDataAdminApp_click(object sender, RoutedEventArgs e)
		{
			short num = (short)523450582;
			short num2 = num;
			num = (short)1908422870;
			Process process;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1659109376;
				short num3 = num;
				num = (short)722993153;
				if (num != 0)
				{
				}
				num = (short)808910848;
				if (num != 0)
				{
				}
				string arsappInstallPath = this.m_ARSAppInstallPath;
				process = new Process();
				process.StartInfo.FileName = arsappInstallPath;
				try
				{
					process.Start();
				}
				catch (Exception ex)
				{
					this.ButtonLaunchARSDataAdminApp.IsEnabled = false;
					AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AppResources.Failed_To_Launch_ARS_Data_Administrator.AcpStringFormat(new object[]
					{
						ex.Message.ToString()
					}));
				}
				break;
			}
			}
			process.Dispose();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00044214 File Offset: 0x00042414
		private void ButtonLaunchAKA_Click(object sender, RoutedEventArgs e)
		{
			short num = (short)320786592;
			short num2 = num;
			num = (short)139841696;
			Process process;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1402929152;
				short num3 = num;
				num = (short)1188757505;
				if (num != 0)
				{
				}
				num = (short)686292992;
				if (num != 0)
				{
				}
				string akaappInstallPath = this.m_AKAAppInstallPath;
				process = new Process();
				process.StartInfo.FileName = akaappInstallPath;
				try
				{
					process.Start();
				}
				catch (Exception ex)
				{
					this.ButtonLaunchAKA.IsEnabled = false;
					AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, AppResources.Failed_To_Launch_Advanced_Keys_Administrator.AcpStringFormat(new object[]
					{
						ex.Message.ToString()
					}));
				}
				break;
			}
			}
			process.Dispose();
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00044330 File Offset: 0x00042530
		public bool IsAdminButtonVisible
		{
			get
			{
				short num = (short)703712343;
				short num2 = num;
				num = (short)1293864023;
				switch (num2 == num)
				{
				}
				num = (short)56295425;
				if (num != 0)
				{
				}
				num = (short)623771648;
				short num3 = num;
				num = (short)713949184;
				if (num != 0)
				{
				}
				return this.IsUserAdmin();
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600014E RID: 334 RVA: 0x000443E0 File Offset: 0x000425E0
		public bool IsAKAAdminLauncherVisible
		{
			get
			{
				while (this.IsAKAAdminAppInstalled)
				{
					short num = (short)815923201;
					if (num != 0)
					{
					}
					num = (short)689635328;
					short num2 = num;
					num = (short)1511263603;
					short num3 = num;
					num = (short)737873267;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)249692160;
						if (num != 0)
						{
						}
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00044498 File Offset: 0x00042698
		public bool IsLauageButtonVisible
		{
			get
			{
				short num = (short)1539775638;
				short num2 = num;
				num = (short)1056513174;
				switch (num2 == num)
				{
				}
				num = (short)1331560449;
				if (num != 0)
				{
				}
				num = (short)1633091584;
				short num3 = num;
				num = (short)1913454592;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00044544 File Offset: 0x00042744
		public bool IsARSAdminLauncherVisible
		{
			get
			{
				while (this.IsARSAdminAppInstalled)
				{
					short num = (short)1034472590;
					short num2 = num;
					num = (short)1674693774;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num = (short)52887552;
						short num3 = num;
						break;
					}
					}
					num = (short)1884422145;
					if (num != 0)
					{
					}
					num = (short)165937152;
					if (num != 0)
					{
					}
					return true;
				}
				return false;
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000445FC File Offset: 0x000427FC
		private bool IsUserAdmin()
		{
			short num = (short)764546308;
			short num2 = num;
			num = (short)1804209412;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2051276800;
				short num3 = num;
				num = (short)1599864832;
				if (num != 0)
				{
				}
				num = (short)1973223425;
				if (num != 0)
				{
				}
				result = true;
				try
				{
					num = (short)1677328385;
					int num4 = (int)((IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_115;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_D1;
							}
							continue;
						case 2:
							result = false;
							num = (short)1580597248;
							num4 = (int)((IntPtr)num);
							continue;
						case 3:
							goto IL_129;
						}
						IL_D1:
						if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
						{
							num = (short)1327890434;
							num4 = (int)((IntPtr)num);
							continue;
						}
						IL_115:
						num = (short)237830147;
						num4 = (int)((IntPtr)num);
					}
					IL_129:;
				}
				catch (Exception)
				{
					result = false;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0004474C File Offset: 0x0004294C
		private bool SearchARSApplication(RegistryKey key)
		{
			int a_ = 10;
			short num = (short)396099584;
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
				Func<string, RegistryKey> <>9__0;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)517079043;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								RegistryKey registryKey;
								switch (num2)
								{
								case 0:
								{
									string text;
									if (text != null)
									{
										num = (short)1342832647;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									string text;
									if (text.Contains(FixedLengthStream.b("ꯩ뻫뷭탯뛱闳苵駷\udaf9뷻髽淿欁樃漅笇縉縋漍搏紑易㘕夗標氛爝䤟䄡䔣別䄧䔩䈫", a_)))
									{
										num = (short)1376258;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_325;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_22E;
									}
									continue;
								case 4:
									goto IL_3CB;
								case 5:
								{
									IEnumerator<RegistryKey> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1205796872;
										num2 = (int)((IntPtr)num);
										continue;
									}
									registryKey = enumerator.Current;
									string text = registryKey.GetValue(FixedLengthStream.b("뫩跫髭飯", a_)) as string;
									num = (short)363921408;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 6:
									goto IL_280;
								case 7:
									num = (short)193789953;
									num2 = (int)((IntPtr)num);
									continue;
								case 8:
								{
									num = (short)983792947;
									short num3 = num;
									num = (short)1520008499;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_325;
									default:
										num = (short)1574436864;
										if (num != 0)
										{
										}
										num = (short)978255876;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_22E;
								IL_325:
								this.m_ARSAppInstallPath = registryKey.GetValue(FixedLengthStream.b("뫩跫髭飯", a_), string.Empty).ToString() + FixedLengthStream.b("맩뿫ꋭ뇯雱駳鿵雷껹鏻釽泿Ⰱ愃縅洇", a_);
								num = (short)454623238;
								num2 = (int)((IntPtr)num);
								continue;
								IL_32A:
								num = (short)304349189;
								num2 = (int)((IntPtr)num);
								continue;
								IL_22E:
								goto IL_32A;
							}
							IL_280:
							IL_3CB:
							goto IL_10C;
						}
						finally
						{
							num = (short)1869742081;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								IEnumerator<RegistryKey> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1991639042;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_402;
									}
									continue;
								case 2:
									goto IL_439;
								}
								IL_402:
								if (enumerator == null)
								{
									break;
								}
								num = (short)267059200;
								num2 = (int)((IntPtr)num);
							}
							IL_439:;
						}
						return false;
						IL_10C:
						num = (short)582418433;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
					{
						if (string.IsNullOrEmpty(this.m_ARSAppInstallPath))
						{
							num = (short)1838415876;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)647299072;
						short num4 = num;
						num = (short)1830420487;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 2:
						if (key != null)
						{
							num = (short)1356070917;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return false;
					case 3:
						return false;
					case 4:
						goto IL_149;
					case 5:
						num = (short)1704067078;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
					{
						IEnumerable<string> subKeyNames = key.GetSubKeyNames();
						Func<string, RegistryKey> selector;
						if ((selector = <>9__0) == null)
						{
							selector = (<>9__0 = delegate(string keyName)
							{
								short num5 = (short)796196864;
								short num6 = num5;
								num5 = (short)693606779;
								short num7 = num5;
								num5 = (short)1195022715;
								switch (num7 == num5)
								{
								}
								num5 = (short)853868545;
								if (num5 != 0)
								{
								}
								num5 = (short)1265565696;
								if (num5 != 0)
								{
								}
								return key.OpenSubKey(keyName);
							});
						}
						IEnumerator<RegistryKey> enumerator = subKeyNames.Select(selector).GetEnumerator();
						num = (short)1442709504;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 7:
						if (!File.Exists(this.m_ARSAppInstallPath))
						{
							num = (short)362348545;
							if (num != 0)
							{
							}
							num = (short)630521859;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_57;
				}
				return true;
				IL_149:
				return false;
				IL_57:
				num = (short)964558850;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00044BB4 File Offset: 0x00042DB4
		internal bool IsARSAdminAppInstalled
		{
			get
			{
				int a_ = 9;
				short num = (short)498335745;
				if (num != 0)
				{
				}
				num = (short)1009451008;
				switch (num)
				{
				default:
				{
					num = (short)290324480;
					short num2 = num;
					bool flag = true;
					try
					{
						num = (short)1564540932;
						int num3 = (int)((IntPtr)num);
						for (;;)
						{
							RegistryKey registryKey;
							RegistryKey registryKey8;
							switch (num3)
							{
							case 0:
								registryKey = null;
								goto IL_1B9;
							case 1:
								registryKey = null;
								goto IL_1B9;
							case 2:
								goto IL_4D8;
							case 3:
								registryKey = null;
								goto IL_1B9;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_BC;
								}
								continue;
							case 5:
								registryKey = null;
								goto IL_1B9;
							case 6:
								try
								{
									switch (0)
									{
									case 0:
										goto IL_209;
									}
									for (;;)
									{
										IL_1DE:
										RegistryKey registryKey6;
										RegistryKey registryKey7;
										switch (num3)
										{
										case 0:
										{
											RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(FixedLengthStream.b("뫨ꓪ꯬믮꛰닲ꟴ닶", a_));
											if (registryKey2 == null)
											{
												num = (short)315293703;
												num3 = (int)((IntPtr)num);
												continue;
											}
											RegistryKey registryKey3 = registryKey2.OpenSubKey(FixedLengthStream.b("ꓨ苪軬鷮黰胲髴釶跸", a_));
											if (registryKey3 == null)
											{
												num = (short)1028194305;
												num3 = (int)((IntPtr)num);
												continue;
											}
											RegistryKey registryKey4 = registryKey3.OpenSubKey(FixedLengthStream.b("뻨苪菬诮黰蓲蛴", a_));
											if (registryKey4 == null)
											{
												num = (short)1013645314;
												num3 = (int)((IntPtr)num);
												continue;
											}
											RegistryKey registryKey5 = registryKey4.OpenSubKey(FixedLengthStream.b("ꫨ黪鿬鷮铰鷲致ꇶ鳸觺軼雾渀洂", a_));
											if (registryKey5 == null)
											{
												num = (short)270270469;
												num3 = (int)((IntPtr)num);
												continue;
											}
											registryKey6 = registryKey5.OpenSubKey(FixedLengthStream.b("꣨鯪鷬쿮ꇰ鋲致鿶諸", a_));
											goto IL_351;
										}
										case 1:
											registryKey6 = null;
											goto IL_351;
										case 2:
											registryKey6 = null;
											goto IL_351;
										case 3:
											if (!flag)
											{
												num = (short)1963458566;
												num3 = (int)((IntPtr)num);
												continue;
											}
											goto IL_436;
										case 4:
											goto IL_450;
										case 5:
											registryKey6 = null;
											goto IL_351;
										case 6:
											num = (short)424935424;
											num3 = (int)((IntPtr)num);
											continue;
										case 7:
											registryKey6 = null;
											goto IL_351;
										case 8:
											try
											{
												flag = this.SearchARSApplication(registryKey7);
											}
											finally
											{
												num = (short)768475137;
												num3 = (int)((IntPtr)num);
												for (;;)
												{
													switch (num3)
													{
													case 0:
													{
														((IDisposable)registryKey7).Dispose();
														num = (short)1969412365;
														short num4 = num;
														num = (short)986306829;
														switch ((num4 == num) ? 1 : 0)
														{
														case 0:
														case 2:
															goto IL_435;
														default:
															num = (short)580517888;
															if (num != 0)
															{
															}
															num = (short)614662146;
															num3 = (int)((IntPtr)num);
															continue;
														}
														break;
													}
													case 1:
														switch (0)
														{
														case 0:
															goto IL_3AB;
														}
														continue;
													case 2:
														goto IL_433;
													}
													IL_3AB:
													if (registryKey7 == null)
													{
														break;
													}
													num = (short)1418067968;
													num3 = (int)((IntPtr)num);
												}
												IL_433:
												IL_435:;
											}
											goto IL_436;
										}
										goto IL_209;
										IL_351:
										registryKey7 = registryKey6;
										num = (short)376897544;
										num3 = (int)((IntPtr)num);
										continue;
										IL_436:
										num = (short)1474953220;
										num3 = (int)((IntPtr)num);
									}
									IL_450:
									goto IL_4BF;
									IL_209:
									flag = this.SearchARSApplication(registryKey8);
									num = (short)92930051;
									num3 = (int)((IntPtr)num);
									goto IL_1DE;
								}
								finally
								{
									num = (short)1786773505;
									num3 = (int)((IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											((IDisposable)registryKey8).Dispose();
											num = (short)225640450;
											num3 = (int)((IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_484;
											}
											continue;
										case 2:
											goto IL_4BC;
										}
										IL_484:
										if (registryKey8 == null)
										{
											break;
										}
										num = (short)960823296;
										num3 = (int)((IntPtr)num);
									}
									IL_4BC:;
								}
								IL_4BF:
								num = (short)1547829250;
								num3 = (int)((IntPtr)num);
								continue;
							}
							IL_BC:
							RegistryKey registryKey9 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(FixedLengthStream.b("뫨ꓪ꯬믮꛰닲ꟴ닶", a_));
							if (registryKey9 == null)
							{
								num = (short)1621295107;
								num3 = (int)((IntPtr)num);
								continue;
							}
							RegistryKey registryKey10 = registryKey9.OpenSubKey(FixedLengthStream.b("ꓨ苪軬鷮黰胲髴釶跸", a_));
							if (registryKey10 == null)
							{
								num = (short)143261701;
								num3 = (int)((IntPtr)num);
								continue;
							}
							RegistryKey registryKey11 = registryKey10.OpenSubKey(FixedLengthStream.b("뻨苪菬诮黰蓲蛴", a_));
							if (registryKey11 == null)
							{
								num = (short)1265434624;
								num3 = (int)((IntPtr)num);
								continue;
							}
							RegistryKey registryKey12 = registryKey11.OpenSubKey(FixedLengthStream.b("ꫨ黪鿬鷮铰鷲致ꇶ鳸觺軼雾渀洂", a_));
							if (registryKey12 == null)
							{
								num = (short)135331841;
								num3 = (int)((IntPtr)num);
								continue;
							}
							registryKey = registryKey12.OpenSubKey(FixedLengthStream.b("꣨鯪鷬쿮ꇰ鋲致鿶諸", a_));
							IL_1B9:
							registryKey8 = registryKey;
							num = (short)1743650822;
							num3 = (int)((IntPtr)num);
						}
						IL_4D8:;
					}
					catch (Exception ex)
					{
						Trace.WriteLine(FixedLengthStream.b("ꃨ飪곬뷮ꋰ닲釴髶郸闺볼迾焀䨂欄理紈樊愌挎琐眒㔔挖焘椚砜栞Ġ䈢䬤ܦ䰨匪丬䨮䄰䜲尴堶圸᜺ᴼ娾㍀ㅂ⩄㕆獈歊", a_) + ex.Message);
						flag = false;
					}
					return flag;
				}
				}
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0004510C File Offset: 0x0004330C
		private bool SearchAKSApplication(RegistryKey key)
		{
			int a_ = 15;
			short num = (short)2084503552;
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
				Func<string, RegistryKey> <>9__0;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1429209091;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								RegistryKey registryKey;
								switch (num2)
								{
								case 0:
								{
									string text;
									if (text != null)
									{
										num = (short)1490812935;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									string text;
									if (text.Contains(FixedLengthStream.b("껮闰藲铴駶髸黺駼\udffe䨀昂簄理⤈䨊椌戎砐紒簔搖洘椚簜欞丠儢", a_)))
									{
										num = (short)536018946;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_328;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_231;
									}
									continue;
								case 4:
									goto IL_3CE;
								case 5:
								{
									IEnumerator<RegistryKey> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1930297352;
										num2 = (int)((IntPtr)num);
										continue;
									}
									registryKey = enumerator.Current;
									string text = registryKey.GetValue(FixedLengthStream.b("뿮郰蟲鷴", a_)) as string;
									num = (short)1802043392;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 6:
									goto IL_282;
								case 7:
									num = (short)663617537;
									num2 = (int)((IntPtr)num);
									continue;
								case 8:
								{
									num = (short)995858171;
									short num3 = num;
									num = (short)1956615931;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_328;
									default:
										num = (short)559808512;
										if (num != 0)
										{
										}
										num = (short)943194116;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_231;
								IL_328:
								this.m_AKAAppInstallPath = registryKey.GetValue(FixedLengthStream.b("뿮郰蟲鷴", a_), string.Empty).ToString() + FixedLengthStream.b("껮ꋰ룲듴鏶铸鋺鏼꯾渀氂椄⤆氈猊栌", a_);
								num = (short)743899142;
								num2 = (int)((IntPtr)num);
								continue;
								IL_32D:
								num = (short)1636302853;
								num2 = (int)((IntPtr)num);
								continue;
								IL_231:
								goto IL_32D;
							}
							IL_282:
							IL_3CE:
							goto IL_136;
						}
						finally
						{
							num = (short)980877313;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								IEnumerator<RegistryKey> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1802174466;
									num2 = (int)((IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_406;
									}
									continue;
								case 2:
									goto IL_43B;
								}
								IL_406:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1647443968;
								num2 = (int)((IntPtr)num);
							}
							IL_43B:;
						}
						return false;
						IL_136:
						num = (short)696778753;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						if (string.IsNullOrEmpty(this.m_AKAAppInstallPath))
						{
							num = (short)1454768132;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1412300807;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
						if (key != null)
						{
							num = (short)1016135685;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return false;
					case 3:
						goto IL_1E4;
					case 4:
						goto IL_175;
					case 5:
						num = (short)1948057606;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
					{
						IEnumerable<string> subKeyNames = key.GetSubKeyNames();
						Func<string, RegistryKey> selector;
						if ((selector = <>9__0) == null)
						{
							selector = (<>9__0 = delegate(string keyName)
							{
								short num5 = (short)898929635;
								short num6 = num5;
								num5 = (short)1659737059;
								switch (num6 == num5)
								{
								}
								num5 = (short)790691840;
								if (num5 != 0)
								{
								}
								num5 = (short)654114817;
								if (num5 != 0)
								{
								}
								num5 = (short)775815168;
								short num7 = num5;
								return key.OpenSubKey(keyName);
							});
						}
						IEnumerator<RegistryKey> enumerator = subKeyNames.Select(selector).GetEnumerator();
						num = (short)262602752;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 7:
						if (!File.Exists(this.m_AKAAppInstallPath))
						{
							num = (short)521011203;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_57;
				}
				return true;
				IL_175:
				return false;
				IL_1E4:
				num = (short)1895170048;
				short num4 = num;
				return false;
				IL_57:
				num = (short)1373634561;
				if (num != 0)
				{
				}
				num = (short)2109079554;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00045578 File Offset: 0x00043778
		internal bool IsAKAAdminAppInstalled
		{
			get
			{
				int a_ = 12;
				short num = (short)1850310652;
				short num2 = num;
				num = (short)1548451836;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)839122945;
					if (num != 0)
					{
					}
					num = (short)170262528;
					if (num != 0)
					{
					}
					num = (short)1172176896;
					switch (num)
					{
					}
					break;
				}
				num = (short)56098816;
				short num3 = num;
				bool flag = true;
				try
				{
					num = (short)1434976257;
					int num4 = (int)((IntPtr)num);
					for (;;)
					{
						RegistryKey registryKey7;
						RegistryKey registryKey8;
						switch (num4)
						{
						case 0:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_250;
								}
								for (;;)
								{
									IL_225:
									RegistryKey registryKey;
									RegistryKey registryKey2;
									switch (num4)
									{
									case 0:
										try
										{
											flag = this.SearchAKSApplication(registryKey);
										}
										finally
										{
											num = (short)1301807104;
											num4 = (int)((IntPtr)num);
											for (;;)
											{
												switch (num4)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_3F4;
													}
													continue;
												case 1:
													((IDisposable)registryKey).Dispose();
													num = (short)8257538;
													num4 = (int)((IntPtr)num);
													continue;
												case 2:
													goto IL_42B;
												}
												IL_3F4:
												if (registryKey == null)
												{
													break;
												}
												num = (short)908853249;
												num4 = (int)((IntPtr)num);
											}
											IL_42B:;
										}
										goto IL_42E;
									case 1:
										num = (short)1128398852;
										num4 = (int)((IntPtr)num);
										continue;
									case 2:
										registryKey2 = null;
										goto IL_399;
									case 3:
										if (!flag)
										{
											num = (short)1919811585;
											num4 = (int)((IntPtr)num);
											continue;
										}
										goto IL_42E;
									case 4:
									{
										RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(FixedLengthStream.b("뿫ꇭ뛯꛱ꏳ럵꫷뿹", a_));
										if (registryKey3 == null)
										{
											num = (short)171442181;
											num4 = (int)((IntPtr)num);
											continue;
										}
										RegistryKey registryKey4 = registryKey3.OpenSubKey(FixedLengthStream.b("ꇫ蟭鏯胱鯳藵韷鳹裻", a_));
										if (registryKey4 == null)
										{
											num = (short)835846150;
											num4 = (int)((IntPtr)num);
											continue;
										}
										RegistryKey registryKey5 = registryKey4.OpenSubKey(FixedLengthStream.b("믫蟭黯雱鯳臵请", a_));
										if (registryKey5 == null)
										{
											num = (short)1131085826;
											num4 = (int)((IntPtr)num);
											continue;
										}
										RegistryKey registryKey6 = registryKey5.OpenSubKey(FixedLengthStream.b("꿫鯭苯胱釳飵賷곹駻賽珿欁欃栅", a_));
										if (registryKey6 == null)
										{
											num = (short)240451592;
											num4 = (int)((IntPtr)num);
											continue;
										}
										registryKey2 = registryKey6.OpenSubKey(FixedLengthStream.b("귫黭胯틱ꓳ韵賷鋹迻", a_));
										goto IL_399;
									}
									case 5:
										registryKey2 = null;
										goto IL_399;
									case 6:
										registryKey2 = null;
										goto IL_399;
									case 7:
										goto IL_446;
									case 8:
										registryKey2 = null;
										goto IL_399;
									}
									goto IL_250;
									IL_399:
									registryKey = registryKey2;
									num = (short)196608000;
									num4 = (int)((IntPtr)num);
									continue;
									IL_42E:
									num = (short)1364656135;
									num4 = (int)((IntPtr)num);
								}
								IL_446:
								goto IL_4B2;
								IL_250:
								flag = this.SearchAKSApplication(registryKey7);
								num = (short)506134531;
								num4 = (int)((IntPtr)num);
								goto IL_225;
							}
							finally
							{
								num = (short)190119936;
								num4 = (int)((IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_47A;
										}
										continue;
									case 1:
										((IDisposable)registryKey7).Dispose();
										num = (short)1362427906;
										num4 = (int)((IntPtr)num);
										continue;
									case 2:
										goto IL_4AF;
									}
									IL_47A:
									if (registryKey7 == null)
									{
										break;
									}
									num = (short)1030422529;
									num4 = (int)((IntPtr)num);
								}
								IL_4AF:;
							}
							IL_4B2:
							num = (short)1675100165;
							num4 = (int)((IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_108;
							}
							continue;
						case 2:
							registryKey8 = null;
							goto IL_200;
						case 3:
							registryKey8 = null;
							goto IL_200;
						case 4:
							registryKey8 = null;
							goto IL_200;
						case 5:
							goto IL_4CA;
						case 6:
							registryKey8 = null;
							goto IL_200;
						}
						IL_108:
						RegistryKey registryKey9 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(FixedLengthStream.b("뿫ꇭ뛯꛱ꏳ럵꫷뿹", a_));
						if (registryKey9 == null)
						{
							num = (short)1119617026;
							num4 = (int)((IntPtr)num);
							continue;
						}
						RegistryKey registryKey10 = registryKey9.OpenSubKey(FixedLengthStream.b("ꇫ蟭鏯胱鯳藵韷鳹裻", a_));
						if (registryKey10 == null)
						{
							num = (short)1788936195;
							num4 = (int)((IntPtr)num);
							continue;
						}
						RegistryKey registryKey11 = registryKey10.OpenSubKey(FixedLengthStream.b("믫蟭黯雱鯳臵请", a_));
						if (registryKey11 == null)
						{
							num = (short)985071620;
							num4 = (int)((IntPtr)num);
							continue;
						}
						RegistryKey registryKey12 = registryKey11.OpenSubKey(FixedLengthStream.b("꿫鯭苯胱釳飵賷곹駻賽珿欁欃栅", a_));
						if (registryKey12 == null)
						{
							num = (short)186515462;
							num4 = (int)((IntPtr)num);
							continue;
						}
						registryKey8 = registryKey12.OpenSubKey(FixedLengthStream.b("귫黭胯틱ꓳ韵賷鋹迻", a_));
						IL_200:
						registryKey7 = registryKey8;
						num = (short)1602945024;
						num4 = (int)((IntPtr)num);
					}
					IL_4CA:;
				}
				catch (Exception ex)
				{
					Trace.WriteLine(FixedLengthStream.b("ꗫ鷭뇯맱뗳럵鳷韹闻都䇿爁球伅昇礉砋漍簏縑焓爕㠗渙琛氝䔟唡У䜥䘧਩䤫嘭匯圱䐳䈵儷唹刻ሽ怿❁㙃㑅❇㡉癋湍", a_) + ex.Message);
					flag = false;
				}
				return flag;
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00045AC4 File Offset: 0x00043CC4
		private string setDefaultDVRSExportLocation()
		{
			switch (0)
			{
			case 0:
				goto IL_54;
			}
			short num;
			int num3;
			string text;
			for (;;)
			{
				IL_0A:
				num = (short)1690894336;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					if (this.txtDefDVRSExportLocation.Visibility != Visibility.Visible)
					{
						return text;
					}
					num = (short)1210056705;
					if (num != 0)
					{
					}
					num = (short)1510084387;
					short num4 = num;
					num = (short)837947171;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)898826240;
						if (num != 0)
						{
						}
						num = (short)1392246789;
						num3 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (!Directory.Exists(text))
					{
						num = (short)549126146;
						num3 = (int)((IntPtr)num);
						continue;
					}
					return text;
				case 2:
					num = (short)1582104576;
					num3 = (int)((IntPtr)num);
					continue;
				case 3:
					return text;
				case 4:
					if (this.txtDefDVRSExportLocation.IsEnabled)
					{
						num = (short)2102132742;
						num3 = (int)((IntPtr)num);
						continue;
					}
					return text;
				case 5:
					num = (short)486866948;
					num3 = (int)((IntPtr)num);
					continue;
				case 6:
				{
					string message = string.Format(AppResources.The_DVRS_Location_Does_Not_Exist_Or_Is_Not_Reachable, text);
					AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Warning, message);
					num = (short)1602224131;
					num3 = (int)((IntPtr)num);
					continue;
				}
				}
				goto IL_54;
			}
			return text;
			IL_54:
			text = "";
			text = this._parent.defaultDVRSFileLocation;
			num = (short)1144193025;
			num3 = (int)((IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00045CA0 File Offset: 0x00043EA0
		private void OnUpdateDefDVRSExportLocation(object sender, RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			FolderBrowserDialog folderBrowserDialog;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (Directory.Exists(this.txtDefDVRSExportLocation.Text))
					{
						num2 = (short)2119696385;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_9B;
				case 1:
				{
					folderBrowserDialog.SelectedPath = this.txtDefDVRSExportLocation.Text;
					num2 = (short)1155727360;
					short num3 = num2;
					num2 = (short)2046754819;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 2:
					num2 = (short)516685825;
					if (num2 != 0)
					{
					}
					if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
					{
						num2 = (short)1233715204;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 3:
					IL_1A2:
					goto IL_9B;
				case 4:
					goto IL_14C;
				}
				goto IL_24;
				IL_9B:
				num2 = (short)1618370643;
				short num4 = num2;
				num2 = (short)1298686035;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1A2;
				default:
					num2 = (short)476577792;
					if (num2 != 0)
					{
					}
					folderBrowserDialog.Description = AppResources.Select_DVRS_Export_Storage_Location;
					num2 = (short)1865809922;
					num = (int)((IntPtr)num2);
					break;
				}
			}
			IL_14C:
			this.txtDefDVRSExportLocation.Text = folderBrowserDialog.SelectedPath;
			this.txtDefDVRSExportLocation.ToolTip = folderBrowserDialog.SelectedPath;
			return;
			IL_24:
			folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = true;
			folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
			num2 = (short)1076494336;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00045E54 File Offset: 0x00044054
		private void comboLanguageChoices_SelectionChanged(object sender, RoutedEventArgs e)
		{
			short num = (short)1978466304;
			short num2 = num;
			num = (short)86081195;
			short num3 = num;
			num = (short)534478507;
			switch (num3 == num)
			{
			}
			num = (short)333643777;
			if (num != 0)
			{
			}
			num = (short)176160768;
			if (num != 0)
			{
			}
			this.reportLanguageChoices.SelectedIndex = 0;
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000159 RID: 345 RVA: 0x00045F08 File Offset: 0x00044108
		// (remove) Token: 0x0600015A RID: 346 RVA: 0x0004603C File Offset: 0x0004423C
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
				short num2;
				PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_3B;
					case 1:
					{
						num2 = (short)415825920;
						short num3 = num2;
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1604911106;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_3B;
					}
					case 2:
						goto IL_B1;
					}
					goto IL_1C;
					IL_3B:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = (short)796262401;
					num = (int)((IntPtr)num2);
				}
				IL_B1:
				num2 = (short)1782134525;
				short num4 = num2;
				num2 = (short)884487933;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num2 = (short)1039007745;
					if (num2 != 0)
					{
					}
					num2 = (short)1252917248;
					if (num2 != 0)
					{
					}
					break;
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)1103495168;
				num = (int)((IntPtr)num2);
				goto IL_0A;
			}
			[CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						num2 = (short)916717569;
						if (num2 != 0)
						{
						}
						goto IL_62;
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)843776002;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_62;
					case 2:
						goto IL_DD;
					}
					goto IL_1C;
					IL_62:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = (short)467533824;
					short num3 = num2;
					num2 = (short)992018433;
					num = (int)((IntPtr)num2);
				}
				IL_DD:
				num2 = (short)171519342;
				short num4 = num2;
				num2 = (short)1312566638;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num2 = (short)1962737664;
					if (num2 != 0)
					{
					}
					break;
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)1830748160;
				num = (int)((IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00046174 File Offset: 0x00044374
		private void HLinkOptionsClick(object sender, RoutedEventArgs e)
		{
			short num = (short)296943617;
			if (num != 0)
			{
			}
			num = (short)2142160851;
			short num2 = num;
			num = (short)1683802067;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)856752128;
				short num3 = num;
				num = (short)1802502144;
				if (num != 0)
				{
				}
				string key = (string)((Hyperlink)sender).Tag;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_CE;
					}
					int num4;
					AcpExpander acpExpander;
					for (;;)
					{
						IL_B8:
						switch (num4)
						{
						case 0:
							if (!acpExpander.IsExpanded)
							{
								num = (short)2033516545;
								num4 = (int)((IntPtr)num);
								continue;
							}
							goto IL_12B;
						case 1:
							acpExpander.IsExpanded = true;
							num = (short)1805516803;
							num4 = (int)((IntPtr)num);
							continue;
						case 2:
							goto IL_150;
						case 3:
							goto IL_12B;
						}
						goto IL_CE;
						IL_12B:
						acpExpander.BringIntoView();
						acpExpander.Focus();
						num = (short)1432748034;
						num4 = (int)((IntPtr)num);
					}
					IL_150:
					break;
					IL_CE:
					acpExpander = this.expanderlist[key];
					num = (short)1449328640;
					num4 = (int)((IntPtr)num);
					goto IL_B8;
				}
				catch (Exception)
				{
				}
				break;
			}
			}
		}

		// Token: 0x040000E2 RID: 226
		private WindowMain _parent;

		// Token: 0x040000E3 RID: 227
		private string initialLanguageSelection;

		// Token: 0x040000E4 RID: 228
		private string reportLanguageSelection;

		// Token: 0x040000E5 RID: 229
		private string initialSysKeysLocation;

		// Token: 0x040000E6 RID: 230
		private string initialHomeScreenLogoPath;

		// Token: 0x040000E7 RID: 231
		private Settings parentWindowSettings;

		// Token: 0x040000E8 RID: 232
		private string m_ARSAppInstallPath;

		// Token: 0x040000E9 RID: 233
		private string m_AKAAppInstallPath;

		// Token: 0x040000EA RID: 234
		private const string SSLAdminTool = "SSLAdminTool.exe";

		// Token: 0x040000EB RID: 235
		private const string ASKAdminTool = "ASKAdminTool.exe";

		// Token: 0x040000EC RID: 236
		private Dictionary<string, AcpExpander> expanderlist;

		// Token: 0x0400010F RID: 271
		[NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
