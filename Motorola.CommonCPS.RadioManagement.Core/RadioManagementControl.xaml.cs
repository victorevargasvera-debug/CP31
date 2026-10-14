using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using Infragistics.Windows.DockManager;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Common;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.Radio;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Core
{
	// Token: 0x02000009 RID: 9
	[Export]
	public partial class RadioManagementControl : System.Windows.Controls.UserControl
	{
		// Token: 0x0600006F RID: 111 RVA: 0x0000B714 File Offset: 0x00009914
		private void b()
		{
			short num = (short)634716161;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EE;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					System.Windows.Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
					num = (short)1248002048;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_31:
				if (RuntimeInfo.ModeIdentifier != ModeIdentifier.Template)
				{
					return;
				}
				num = (short)1109196800;
				short num3 = num;
				num = (short)56621961;
				short num4 = num;
				num = (short)1820654473;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)361168896;
					if (num != 0)
					{
					}
					num = (short)541720578;
					num2 = (int)((IntPtr)num);
					break;
				}
			}
			IL_EE:
			num = (short)620101633;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000B83C File Offset: 0x00009A3C
		static RadioManagementControl()
		{
			short num = (short)820379649;
			if (num != 0)
			{
			}
			num = (short)344329647;
			short num2 = num;
			num = (short)1001000367;
			switch (num2 == num)
			{
			}
			num = (short)1241251840;
			if (num != 0)
			{
			}
			num = (short)809369600;
			short num3 = num;
			EventManager.RegisterClassHandler(typeof(PaneTabItem), UIElement.PreviewMouseLeftButtonDownEvent, new MouseButtonEventHandler(RadioManagementControl.a));
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000B904 File Offset: 0x00009B04
		[ImportingConstructor]
		public RadioManagementControl(IEventAggregator eventAggregator, IRegionManager regionManager, RadioManagementControlViewModel controlViewModel)
		{
			int a_ = 6;
			base..ctor();
			this.b();
			System.Windows.Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary
			{
				Source = new Uri(RadioManagementControlViewModel.q("뚘횚캠톢쪤쮦좨薪삮\udcb0\udeb2\udab4\ud9b6視醾鏀ꋂꇄ껆ꛈ蛊곌ꇎ냐듒냔뫖볘뗚꧜ꋠ賢诤鏦鯨蓪臬鳮쫰郲髴髶觸铺鏼髾漀眂⨄吆紈爊愌樎成㴒洔瘖琘眚", a_), UriKind.Relative)
			});
			this.eventAggregator = eventAggregator;
			this.regionManager = regionManager;
			base.DataContext = controlViewModel;
			this.InitializeComponent();
			ILocalService localService = LocalServiceProxy.GetInstance().LocalService;
			if (!RuntimeInfo.IsConnected)
			{
				if (RuntimeInfo.ProductFamily == ProductFamily.AMP)
				{
					SplashScreenHelper.ShowStatus(Motorola.CommonCPS.ResourceRepository.Resources.RN_Loading_Connecting_Agency);
				}
				else
				{
					SplashScreenHelper.ShowStatus(Motorola.CommonCPS.ResourceRepository.Resources.RMC_Loading_Connecting_Server);
				}
				if (RuntimeInfo.AuthenticationMethodType.Equals(AuthenticationMethod.UserName.ToString()))
				{
					RuntimeInfo.ConnectionFailureReason = ConnectionFailureReasonID.UserNameFirstTimeLogin;
				}
				else if (RuntimeInfo.AuthenticationMethodType.Equals(AuthenticationMethod.JwtToken.ToString()))
				{
					RuntimeInfo.ConnectionFailureReason = ConnectionFailureReasonID.JwtTokenCredentialFirstTimeLogin;
				}
				else
				{
					if (!RuntimeInfo.AuthenticationMethodType.Equals(AuthenticationMethod.Windows.ToString()))
					{
						throw new Exception(RadioManagementControlViewModel.q("힘뾞튠횢햤힦욨\ud9aa\ud9ac쪮햰鎲풴슶춸펺\ud8bc톾뗀ꫂꏄ껆꫈꫊만ꛎ뻐뷒뫖볘꿚뗜냞藠췢", a_));
					}
					localService.Connect(false);
				}
				controlViewModel.HandleConnectResults();
			}
			SplashScreenHelper.Show();
			if (RuntimeInfo.ProductFamily == ProductFamily.AMP)
			{
				SplashScreenHelper.ShowStatus(Motorola.CommonCPS.ResourceRepository.Resources.RN_Loading_Initializing_Client_Components);
			}
			else
			{
				SplashScreenHelper.ShowStatus(Motorola.CommonCPS.ResourceRepository.Resources.RMC_Loading_Initializing_RMC_Components);
			}
			base.SizeChanged += this.a;
			eventAggregator.GetEvent<ActivateDockedPaneRequestedEvent>().Subscribe(new Action<DockPanelNames>(this.b));
			eventAggregator.GetEvent<ActiveMainModuleChangedEvent>().Subscribe(new Action<string>(this.b));
			eventAggregator.GetEvent<ActiveViewChangedEvent>().Subscribe(new Action<Dictionary<string, string>>(this.a));
			eventAggregator.GetEvent<NavigateToViewChangedEvent>().Subscribe(new Action<string>(this.a));
			eventAggregator.GetEvent<CloseDockedPaneRequestedEvent>().Subscribe(new Action<DockPanelNames>(this.a));
			eventAggregator.GetEvent<CloseRadioManagementRequestedEvent>().Subscribe(new Action<object>(this.b));
			eventAggregator.GetEvent<EndGrouplistEditModeRequestedEvent>().Subscribe(new Action<object>(this.a));
			eventAggregator.GetEvent<RenameGroupRequestedEvent>().Subscribe(new Action<Group>(this.a));
			eventAggregator.GetEvent<ShowHelpInConfigViewRequestedEvent>().Subscribe(new Action<string>(this.d));
			eventAggregator.GetEvent<OutputPaneItemChangedEvent>().Subscribe(new Action<KeyValuePair<DockPanelNames, int>>(this.a));
			eventAggregator.GetEvent<PopupPaneNewItemAddedEvent>().Subscribe(new Action<DockPanelNames>(this.b));
			eventAggregator.GetEvent<OutputPaneBackgroundWorkEvent>().Subscribe(new Action<KeyValuePair<DockPanelNames, OutputPaneBackgroundWorkStatus>>(this.a));
			eventAggregator.GetEvent<UpdateActivedHelpURLRequestedEvent>().Subscribe(new Action<string>(this.c));
			this.tvwTasks.DataContext = new TasksViewModel(eventAggregator, ServiceProxy.GetInstance().CommandHandler);
			this.cpnResources.DataContext = new ResourceGroupViewModel(eventAggregator);
			FlowDirectionHelper.SetUIFlowDirection(this);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000BBF0 File Offset: 0x00009DF0
		private void a(KeyValuePair<DockPanelNames, OutputPaneBackgroundWorkStatus> A_0)
		{
			short num = (short)315784407;
			short num2 = num;
			num = (short)1984199895;
			switch (num2 == num)
			{
			}
			num = (short)14352385;
			if (num != 0)
			{
			}
			num = (short)347996160;
			short num3 = num;
			num = (short)102563840;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000BC98 File Offset: 0x00009E98
		private void a(object A_0, RoutedPropertyChangedEventArgs<ContentPane> A_1)
		{
			int a_ = 12;
			short num = (short)731381760;
			int num2 = (int)((IntPtr)num);
			ContentPane newValue;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_7F;
					}
					continue;
				case 1:
					if (!(newValue.Name == RadioManagementControlViewModel.q("ﲞ토춢욦\udba8얪쒬솮횰ﺲ킴쒶쪸\udaba\udabc\udabe닀", a_)))
					{
						num = (short)269418515;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_275;
				case 2:
					goto IL_270;
				case 3:
					newValue.Header = Motorola.CommonCPS.ResourceRepository.Resources.RMC_RMControl_CompareResults;
					newValue.Tag = null;
					num = (short)399900681;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
					newValue.Header = Motorola.CommonCPS.ResourceRepository.Resources.RMC_RMControl_SpellCheckResults;
					newValue.Tag = null;
					goto IL_434;
				case 5:
					if (newValue.Name == RadioManagementControlViewModel.q("ﲞ토춢슦\udda8ﲪ첬\uddae\udfb0\udab2\udbb4킶\udeba캼첾ꃀ꓂ꃄ듆", a_))
					{
						num = (short)2016739336;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 6:
					if (newValue.Name == RadioManagementControlViewModel.q("ﲞ토춢좦쒨\udbaa첬\uddae풰킴쒶첸ힺ즼첾", a_))
					{
						num = (short)1109196801;
						if (num != 0)
						{
						}
						num = (short)1164771331;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_B6;
				case 7:
					goto IL_B6;
				case 8:
					goto IL_275;
				case 9:
					goto IL_B6;
				case 10:
					if (newValue.Name == RadioManagementControlViewModel.q("ﲞ토춢슦\udda8ﶪ첬쎮\ud8b0ힲ풴쎶킸풺펼꓀냂냄ꯆ뷈룊", a_))
					{
						num = (short)2134179842;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1934229505;
					num2 = (int)((IntPtr)num);
					continue;
				case 11:
					goto IL_B6;
				case 12:
					if (!(newValue.Name == RadioManagementControlViewModel.q("ﲞ토춢욦얨슪즬캮얰\udab2\udab4\ud9b6\udeba캼쪾귀럂뛄", a_)))
					{
						num = (short)1636892687;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_A3;
				case 13:
					if (newValue.Name == RadioManagementControlViewModel.q("ﲞ토춢힦첨잪솬\ud9b0횲횴\udcb6\udeba캼쪾귀럂뛄", a_))
					{
						num = (short)809828356;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)140443654;
					num2 = (int)((IntPtr)num);
					continue;
				case 14:
				{
					newValue.Header = Motorola.CommonCPS.ResourceRepository.Resources.RMC_RMControl_Tasks;
					newValue.Tag = null;
					num = (short)867727785;
					short num3 = num;
					num = (short)1227782569;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_434;
					default:
						num = (short)1874067456;
						if (num != 0)
						{
						}
						num = (short)796393479;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 15:
					num = (short)519045130;
					num2 = (int)((IntPtr)num);
					continue;
				case 16:
					return;
				case 17:
					if (newValue.Name == RadioManagementControlViewModel.q("ﲞ토춢욦\udaa8삪\udeac", a_))
					{
						num = (short)2085289998;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)627441677;
					num2 = (int)((IntPtr)num);
					continue;
				case 18:
				{
					num = (short)1959264256;
					short num4 = num;
					newValue = A_1.NewValue;
					num = (short)4784145;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 19:
					num = (short)700841989;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_7F:
				if (A_1.NewValue != null)
				{
					num = (short)1295384594;
					num2 = (int)((IntPtr)num);
					continue;
				}
				return;
				IL_B6:
				num = (short)1615593484;
				num2 = (int)((IntPtr)num);
				continue;
				IL_275:
				newValue.Header = Motorola.CommonCPS.ResourceRepository.Resources.RMC_RMControl_WarningMessages;
				newValue.Tag = null;
				num = (short)58195984;
				num2 = (int)((IntPtr)num);
				continue;
				IL_434:
				num = (short)52166667;
				num2 = (int)((IntPtr)num);
			}
			IL_A3:
			newValue.Header = Motorola.CommonCPS.ResourceRepository.Resources.RMC_RMControl_ValidationResults;
			newValue.Tag = null;
			return;
			IL_270:
			goto IL_A3;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000C0F8 File Offset: 0x0000A2F8
		public bool AutoUpdateWhenStartUp()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					result = (base.DataContext as RadioManagementControlViewModel).incompatibilityHandlerHelper.DetectAndHandleIncompatibility();
					num2 = (short)116326402;
					num = (int)((IntPtr)num2);
					continue;
				case 1:
					goto IL_7D;
				case 2:
					goto IL_F4;
				}
				goto IL_1C;
			}
			IL_F4:
			num2 = (short)1846738945;
			if (num2 != 0)
			{
			}
			return result;
			IL_1C:
			num2 = (short)482513083;
			short num3 = num2;
			num2 = (short)1097633979;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_7D:
				num2 = (short)135135232;
				short num4 = num2;
				if (RuntimeInfo.ConnectionFailureReason == ConnectionFailureReasonID.ServiceNotCompatibleWithClientVersion)
				{
					num2 = (short)922484736;
					int num = (int)((IntPtr)num2);
					goto IL_0A;
				}
				break;
			}
			default:
			{
				num2 = (short)515637248;
				if (num2 != 0)
				{
				}
				result = false;
				num2 = (short)1900478465;
				int num = (int)((IntPtr)num2);
				goto IL_0A;
			}
			}
			return result;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000C224 File Offset: 0x0000A424
		public void HandleConnectResults()
		{
			short num = (short)2043461322;
			short num2 = num;
			num = (short)1101053642;
			switch (num2 == num)
			{
			}
			num = (short)2095054849;
			if (num != 0)
			{
			}
			num = (short)1574305792;
			short num3 = num;
			num = (short)97779712;
			if (num != 0)
			{
			}
			(base.DataContext as RadioManagementControlViewModel).HandleConnectResults();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000C2DC File Offset: 0x0000A4DC
		public void Refresh()
		{
			int a_ = 4;
			short num = (short)939655170;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E8;
				case 1:
					num = (short)938344451;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
					goto IL_12C;
				}
				IL_3D:
				num = (short)532938752;
				short num3 = num;
				num = (short)405507238;
				short num4 = num;
				num = (short)1016171686;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1838743552;
					if (num != 0)
					{
					}
					if (!RuntimeInfo.IsHostedDeployment)
					{
						num = (short)1388380161;
						num2 = (int)((IntPtr)num);
					}
					else
					{
						num = (short)521404416;
						num2 = (int)((IntPtr)num);
					}
					break;
				}
			}
			IL_E8:
			num = (short)1955266561;
			if (num != 0)
			{
			}
			string text = RuntimeInfo.AgencyName;
			goto IL_138;
			IL_12C:
			text = UserConfig.Settings.ServerAddress;
			IL_138:
			string text2 = text;
			InteractionFactory.GetInstance().ReportStatus(Motorola.CommonCPS.ResourceRepository.Resources.RMC_Status_Connection + RadioManagementControlViewModel.q("랖", a_) + text2.ToUpper(CultureInfo.InvariantCulture));
			InteractionFactory.GetInstance().Redirect(null);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000C45C File Offset: 0x0000A65C
		public bool OnShuttingDown()
		{
			RadioManagementControlViewModel radioManagementControlViewModel = base.DataContext as RadioManagementControlViewModel;
			if (radioManagementControlViewModel != null)
			{
				short num;
				for (;;)
				{
					num = (short)1194196992;
					short num2 = num;
					num = (short)907739137;
					if (num != 0)
					{
					}
					num = (short)627868508;
					short num3 = num;
					num = (short)1079542620;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_97;
					}
				}
				IL_97:
				num = (short)303955968;
				if (num != 0)
				{
				}
				return radioManagementControlViewModel.OnClosingWindow();
			}
			return false;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000C520 File Offset: 0x0000A720
		private void a(KeyValuePair<DockPanelNames, int> A_0)
		{
			int a_ = 18;
			short num = (short)1785921536;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				int value;
				Dictionary<DockPanelNames, KeyValuePair<ContentPane, string>> dictionary;
				DockPanelNames key;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_30:
						switch (num2)
						{
						case 0:
							if (value == -1)
							{
								num = (short)1625030656;
								short num3 = num;
								num = (short)1914437635;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_218;
						case 1:
							goto IL_A6;
						case 2:
							if (value == 0)
							{
								num = (short)89784321;
								num2 = (int)((IntPtr)num);
								continue;
							}
							num = (short)277807104;
							num2 = (int)((IntPtr)num);
							continue;
						case 3:
							goto IL_1DA;
						}
						goto IL_47;
					}
					IL_A6:
					num = (short)1203003249;
					short num4 = num;
					num = (short)1449811825;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_74;
					default:
						num = (short)571211776;
						if (num != 0)
						{
						}
						num = (short)1885732865;
						if (num != 0)
						{
						}
						dictionary[key].Key.Header = dictionary[key].Value;
						dictionary[key].Key.Tag = null;
						return;
					}
					IL_1DA:
					dictionary[key].Key.Header = dictionary[key].Value + RadioManagementControlViewModel.q("趤趦肨", a_);
					dictionary[key].Key.Tag = RadioManagementControlViewModel.q("펦첨욪잮킰\uddb2튴튶\uddb8", a_);
					return;
					IL_218:
					dictionary[key].Key.Header = dictionary[key].Value + RadioManagementControlViewModel.q("趤", a_) + value.ToString(CultureInfo.CurrentCulture) + RadioManagementControlViewModel.q("辤躦", a_);
					dictionary[key].Key.Tag = RadioManagementControlViewModel.q("펦첨욪잮킰\uddb2튴튶\uddb8", a_);
					return;
				}
				}
				IL_47:
				dictionary = new Dictionary<DockPanelNames, KeyValuePair<ContentPane, string>>();
				dictionary.Add(DockPanelNames.TaskView, new KeyValuePair<ContentPane, string>(this.cpnTasks, Motorola.CommonCPS.ResourceRepository.Resources.RMC_RMControl_Tasks));
				key = A_0.Key;
				value = A_0.Value;
				IL_74:
				num = (short)634257410;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000C7B8 File Offset: 0x0000A9B8
		private void d(string A_0)
		{
			int a_ = 17;
			string helpFilePath;
			for (;;)
			{
				IL_09:
				short num = (short)1656881152;
				short num2 = num;
				num = (short)1031143427;
				int num3 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						if (!string.IsNullOrEmpty(helpFilePath))
						{
							num = (short)416284676;
							num3 = (int)((IntPtr)num);
							continue;
						}
						goto IL_8F;
					case 1:
						helpFilePath = LocalServiceProxy.GetInstance().LocalService.GetHelpFilePath(A_0);
						num = (short)820183040;
						num3 = (int)((IntPtr)num);
						continue;
					case 2:
						goto IL_129;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_6B;
						}
						continue;
					case 4:
					{
						num = (short)587137025;
						if (num != 0)
						{
						}
						num = (short)316681667;
						short num4 = num;
						num = (short)1215573443;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num = (short)1030553600;
							if (num != 0)
							{
							}
							Uri url = new Uri(helpFilePath + RadioManagementControlViewModel.q("鮣풥춧캩얫\udcad햯톱삳讵\udeb7\udbb9킻춽ꖿ", a_));
							this.helpView.Navigate(url);
							num = (short)1401028610;
							num3 = (int)((IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					IL_6B:
					if (string.IsNullOrEmpty(A_0))
					{
						goto IL_1A6;
					}
					num = (short)1391329281;
					num3 = (int)((IntPtr)num);
				}
			}
			IL_8F:
			(base.DataContext as RadioManagementControlViewModel).ActivedFieldUrl = helpFilePath;
			return;
			IL_129:
			goto IL_8F;
			IL_1A6:
			(base.DataContext as RadioManagementControlViewModel).ActivedFieldUrl = null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000C97C File Offset: 0x0000AB7C
		private void c(string A_0)
		{
			if (!string.IsNullOrEmpty(A_0))
			{
				short num;
				for (;;)
				{
					num = (short)1747451904;
					short num2 = num;
					num = (short)1069442315;
					short num3 = num;
					num = (short)1738695947;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6C;
					}
				}
				IL_6C:
				num = (short)1399652353;
				if (num != 0)
				{
				}
				num = (short)498728960;
				if (num != 0)
				{
				}
				string helpFilePath = LocalServiceProxy.GetInstance().LocalService.GetHelpFilePath(A_0);
				(base.DataContext as RadioManagementControlViewModel).ActivedFieldUrl = helpFilePath;
				return;
			}
			(base.DataContext as RadioManagementControlViewModel).ActivedFieldUrl = null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000CA68 File Offset: 0x0000AC68
		private void b(DockPanelNames A_0)
		{
			short num = (short)1177157635;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!this.cpnTasks.IsActivePane)
					{
						num = (short)1103429632;
						short num3 = num;
						num = (short)1962475524;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 4:
				{
					this.cpnTasks.Activate();
					num = (short)1889751027;
					short num4 = num;
					num = (short)1569476595;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_59;
					default:
						num = (short)938803201;
						if (num != 0)
						{
						}
						num = (short)618201088;
						if (num != 0)
						{
						}
						num = (short)1599143938;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_39;
				IL_59:
				num = (short)656670721;
				num2 = (int)((IntPtr)num);
				continue;
				IL_39:
				switch (A_0)
				{
				case DockPanelNames.SetInvaildsView:
				case DockPanelNames.SetWarningsView:
				case DockPanelNames.SetSearchView:
				case DockPanelNames.SpellCheckView:
				case DockPanelNames.QueryEditorView:
					return;
				case DockPanelNames.TaskView:
					num = (short)1579941888;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_59;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000CBEC File Offset: 0x0000ADEC
		private void b(string A_0)
		{
			int a_ = 19;
			short num = (short)1671102489;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				Visibility visibility;
				uint num3;
				switch (num2)
				{
				case 0:
					visibility = Visibility.Visible;
					goto IL_8D7;
				case 1:
				{
					if (num3 != 2313466252U)
					{
						num = (short)1742733366;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)853827904;
					short num4 = num;
					num = (short)1825268032;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_745;
					default:
						num = (short)614793216;
						if (num != 0)
						{
						}
						num = (short)1501888522;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					num = (short)431226884;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					if (num3 != 3687800990U)
					{
						num = (short)748945432;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)2049769533;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
					if (num3 != 1450572116U)
					{
						num = (short)1228603456;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1792147495;
					num2 = (int)((IntPtr)num);
					continue;
				case 5:
					num = (short)628949042;
					num2 = (int)((IntPtr)num);
					continue;
				case 6:
					num = (short)1083244609;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					num = (short)1639645210;
					num2 = (int)((IntPtr)num);
					continue;
				case 8:
					goto IL_3A6;
				case 9:
					num = (short)956825667;
					num2 = (int)((IntPtr)num);
					continue;
				case 10:
					if (!(A_0 == RadioManagementControlViewModel.q("솧\ud8a9솫\ud9ad톯삱톳", a_)))
					{
						num = (short)684785719;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_870;
				case 11:
					if (!(A_0 == RadioManagementControlViewModel.q("잧좩", a_)))
					{
						num = (short)3997705;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3A6;
				case 12:
					if (num3 != 1121529980U)
					{
						num = (short)446955522;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1031012363;
					num2 = (int)((IntPtr)num);
					continue;
				case 13:
					goto IL_3A6;
				case 14:
					num = (short)2108358707;
					num2 = (int)((IntPtr)num);
					continue;
				case 15:
					goto IL_3A6;
				case 16:
					if (num3 != 3361029697U)
					{
						num = (short)549912605;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)620429350;
					num2 = (int)((IntPtr)num);
					continue;
				case 17:
					if (num3 <= 2495482549U)
					{
						num = (short)1267466302;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)603193367;
					num2 = (int)((IntPtr)num);
					continue;
				case 18:
					num = (short)221511736;
					num2 = (int)((IntPtr)num);
					continue;
				case 19:
					goto IL_3A6;
				case 20:
					num = (short)1887698945;
					num2 = (int)((IntPtr)num);
					continue;
				case 21:
					goto IL_3A6;
				case 22:
					num = (short)2058485761;
					if (num != 0)
					{
					}
					goto IL_3A6;
				case 23:
					if (num3 <= 3687800990U)
					{
						num = (short)1071120450;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1808007200;
					num2 = (int)((IntPtr)num);
					continue;
				case 24:
					num = (short)410910742;
					num2 = (int)((IntPtr)num);
					continue;
				case 25:
					switch (0)
					{
					case 0:
						goto IL_14F;
					}
					continue;
				case 26:
					goto IL_3A6;
				case 27:
					if (num3 != 2036726955U)
					{
						num = (short)1209860116;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1317863494;
					num2 = (int)((IntPtr)num);
					continue;
				case 28:
					if (!(A_0 == RadioManagementControlViewModel.q("즧쒩쮫\udbad톯햱톳\ud9b7\ud9b9ힻ", a_)))
					{
						num = (short)368050190;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_870;
				case 29:
					num = (short)1941372931;
					num2 = (int)((IntPtr)num);
					continue;
				case 30:
					num = (short)493944851;
					num2 = (int)((IntPtr)num);
					continue;
				case 31:
					if (this.cpnHelpView.Visibility != Visibility.Visible)
					{
						num = (short)1916272698;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_BA9;
				case 32:
					if (num3 != 3724606214U)
					{
						num = (short)513998888;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1648492572;
					num2 = (int)((IntPtr)num);
					continue;
				case 33:
					num = (short)1068564495;
					num2 = (int)((IntPtr)num);
					continue;
				case 34:
					goto IL_3A6;
				case 35:
					goto IL_3A6;
				case 36:
					num = (short)1887830065;
					num2 = (int)((IntPtr)num);
					continue;
				case 37:
					goto IL_3A6;
				case 38:
					if (!(A_0 == RadioManagementControlViewModel.q("ﮧﺩﺫ펱삳ힵ좹펻\ud8bdꦿ껁ꇃ", a_)))
					{
						num = (short)560791600;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.cpnASTRODataProfileGroups.Visibility = Visibility.Visible;
					num = (short)1108344869;
					num2 = (int)((IntPtr)num);
					continue;
				case 39:
					if (!(A_0 == RadioManagementControlViewModel.q("즧캩얫솭", a_)))
					{
						num = (short)1242103871;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.cpnRadioGroups.Visibility = Visibility.Visible;
					num = (short)557252621;
					num2 = (int)((IntPtr)num);
					continue;
				case 40:
					num = (short)2044264491;
					num2 = (int)((IntPtr)num);
					continue;
				case 41:
					if (num3 != 2495482549U)
					{
						num = (short)1776418823;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1727397934;
					num2 = (int)((IntPtr)num);
					continue;
				case 42:
					num = (short)1516568576;
					num2 = (int)((IntPtr)num);
					continue;
				case 43:
					if (num3 != 3776259653U)
					{
						num = (short)1165557778;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)652804149;
					num2 = (int)((IntPtr)num);
					continue;
				case 44:
					goto IL_B8B;
				case 45:
					visibility = Visibility.Collapsed;
					goto IL_8D7;
				case 46:
					if (!(A_0 == RadioManagementControlViewModel.q("즫\udcad쒯\udbb1튳\udfb5\udbb7\udbb9좻\udbbd뎿", a_)))
					{
						num = (short)1555562526;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_870;
				case 47:
					goto IL_3A6;
				case 48:
				{
					num = (short)1668939776;
					short num5 = num;
					num = (short)1981284387;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 49:
					goto IL_3A6;
				case 50:
					goto IL_3A6;
				case 51:
					goto IL_3A6;
				case 52:
					if (!(A_0 == RadioManagementControlViewModel.q("ﮧﺩﺫﾯ욱햳쒵좹펻\ud8bdꦿ껁ꇃ", a_)))
					{
						num = (short)458752068;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.cpnASTROOtarProfileGroups.Visibility = Visibility.Visible;
					num = (short)1706295365;
					num2 = (int)((IntPtr)num);
					continue;
				case 53:
					if (!(A_0 == RadioManagementControlViewModel.q("ﮧﺩﺫ쮱잳습\uddb7ힹ", a_)))
					{
						num = (short)1776025633;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.cpnASTROSystemGroups.Visibility = Visibility.Visible;
					num = (short)484638777;
					num2 = (int)((IntPtr)num);
					continue;
				case 54:
					num = (short)110034985;
					num2 = (int)((IntPtr)num);
					continue;
				case 55:
					num = (short)968163336;
					num2 = (int)((IntPtr)num);
					continue;
				case 56:
					if (num3 != 4104333365U)
					{
						num = (short)91226118;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)916979764;
					num2 = (int)((IntPtr)num);
					continue;
				case 57:
					goto IL_3A6;
				case 58:
					(base.DataContext as RadioManagementControlViewModel).ActivedFieldUrl = string.Empty;
					num = (short)892338220;
					num2 = (int)((IntPtr)num);
					continue;
				case 59:
					if (num3 <= 1450572116U)
					{
						num = (short)815595591;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1731395611;
					num2 = (int)((IntPtr)num);
					continue;
				case 60:
					goto IL_3A6;
				case 61:
					if (!(A_0 == RadioManagementControlViewModel.q("잧쎩쾫쮭\udcb1\udab3\ud9b5춷풹\udfbb\udbbd궿ꟁ꫃닅", a_)))
					{
						num = (short)1253376005;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_870;
				case 62:
					num = (short)1712717883;
					num2 = (int)((IntPtr)num);
					continue;
				case 63:
					num = (short)392298543;
					num2 = (int)((IntPtr)num);
					continue;
				case 64:
					goto IL_745;
				case 65:
					goto IL_3A6;
				case 66:
					num = (short)2068840464;
					num2 = (int)((IntPtr)num);
					continue;
				case 67:
					goto IL_3A6;
				case 68:
					num = (short)96796693;
					num2 = (int)((IntPtr)num);
					continue;
				case 69:
					goto IL_3A6;
				case 70:
					if (!(A_0 == RadioManagementControlViewModel.q("ﺧﾫ\ud9af\udeb1톳억", a_)))
					{
						num = (short)1986134052;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_870;
				case 71:
					num = (short)984088588;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_14F:
				if (!(A_0 == string.Empty))
				{
					num = (short)1609039914;
					num2 = (int)((IntPtr)num);
					continue;
				}
				num = (short)1701707821;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3A6:
				num = (short)1487863839;
				num2 = (int)((IntPtr)num);
				continue;
				IL_745:
				num = (short)1378091042;
				num2 = (int)((IntPtr)num);
				continue;
				IL_870:
				this.cpnResources.Visibility = Visibility.Visible;
				num = (short)706543676;
				num2 = (int)((IntPtr)num);
				continue;
				IL_8D7:
				Visibility visibility2 = visibility;
				this.ctcNavigation.Visibility = visibility2;
				this.cpnASTROSystemGroups.Visibility = Visibility.Collapsed;
				this.cpnASTRODataProfileGroups.Visibility = Visibility.Collapsed;
				this.cpnASTROOtarProfileGroups.Visibility = Visibility.Collapsed;
				this.cpnRadioGroups.Visibility = Visibility.Collapsed;
				this.cpnResources.Visibility = Visibility.Collapsed;
				this.cpnHelpView.Visibility = Visibility.Collapsed;
				num3 = j.a(A_0);
				num = (short)1607139345;
				num2 = (int)((IntPtr)num);
			}
			IL_B8B:
			IL_BA9:
			this.ctcStatus.Focus();
			this.a();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000D7B4 File Offset: 0x0000B9B4
		private void a(Dictionary<string, string> A_0)
		{
			short num = (short)1994683245;
			short num2 = num;
			num = (short)1005876077;
			switch (num2 == num)
			{
			}
			num = (short)722272257;
			if (num != 0)
			{
			}
			num = (short)1192558592;
			if (num != 0)
			{
			}
			num = (short)1402994688;
			short num3 = num;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000D860 File Offset: 0x0000BA60
		private void a()
		{
			short num = (short)1467638250;
			short num2 = num;
			num = (short)1799447018;
			switch (num2 == num)
			{
			}
			num = (short)1936982017;
			if (num != 0)
			{
			}
			num = (short)143851520;
			if (num != 0)
			{
			}
			num = (short)275513344;
			short num3 = num;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000D908 File Offset: 0x0000BB08
		private void a(string A_0)
		{
			int a_ = 19;
			short num = (short)1393623042;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1DA;
				case 1:
					num = (short)621740036;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 3:
					goto IL_82;
				case 4:
					if (A_0.StartsWith(RadioManagementControlViewModel.q("즫\udead\udfaf삱삳억펹\ud9bb즽", a_), StringComparison.Ordinal))
					{
						num = (short)977993728;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.cpnRadioGroups.Visibility = Visibility.Visible;
					num = (short)678035463;
					num2 = (int)((IntPtr)num);
					continue;
				case 5:
					if (!string.IsNullOrEmpty(A_0))
					{
						num = (short)2062483464;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1DF;
				case 6:
					if (!A_0.StartsWith(RadioManagementControlViewModel.q("즫\udaad톯\udbb1\ud8b3억펹\ud9bb즽", a_), StringComparison.Ordinal))
					{
						num = (short)688848897;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_84;
				case 7:
					goto IL_1DF;
				case 8:
					num = (short)1865351169;
					if (num != 0)
					{
					}
					num = (short)579993606;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_51;
				IL_6E:
				num = (short)5636099;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1DF:
				num = (short)602467907;
				short num3 = num;
				num = (short)109768259;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_6E;
				default:
					goto IL_215;
				}
				IL_51:
				if (RuntimeInfo.ActiveMainModule != RadioManagementControlViewModel.q("즧캩얫솭", a_))
				{
					goto IL_6E;
				}
				num = (short)278200325;
				num2 = (int)((IntPtr)num);
			}
			IL_82:
			num = (short)901316608;
			short num4 = num;
			return;
			IL_84:
			this.cpnRadioGroups.Visibility = Visibility.Collapsed;
			return;
			IL_1DA:
			goto IL_84;
			IL_215:
			num = (short)186384384;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000DB40 File Offset: 0x0000BD40
		private void a(DockPanelNames A_0)
		{
			short num = (short)1523925268;
			short num2 = num;
			num = (short)324485396;
			switch (num2 == num)
			{
			}
			num = (short)468123648;
			if (num != 0)
			{
			}
			num = (short)27394049;
			if (num != 0)
			{
			}
			num = (short)681377792;
			short num3 = num;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000DBE8 File Offset: 0x0000BDE8
		private void a(object A_0, PropertyChangedEventArgs A_1)
		{
			short num = (short)1843462145;
			if (num != 0)
			{
			}
			num = (short)611501688;
			short num2 = num;
			num = (short)1814414968;
			switch (num2 == num)
			{
			}
			num = (short)739180544;
			if (num != 0)
			{
			}
			num = (short)820510720;
			short num3 = num;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000DC90 File Offset: 0x0000BE90
		private void b(object A_0)
		{
			short num = (short)1775310106;
			short num2 = num;
			num = (short)991892762;
			switch (num2 == num)
			{
			}
			num = (short)1240793089;
			if (num != 0)
			{
			}
			num = (short)1822752768;
			if (num != 0)
			{
			}
			num = (short)1806106624;
			short num3 = num;
			Window window = base.Parent as Window;
			if (window == null)
			{
				return;
			}
			window.Close();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000DD4C File Offset: 0x0000BF4C
		private void a(object A_0)
		{
			short num = (short)153327182;
			short num2 = num;
			num = (short)1388811854;
			switch (num2 == num)
			{
			}
			num = (short)1972305921;
			if (num != 0)
			{
			}
			num = (short)401276928;
			if (num != 0)
			{
			}
			num = (short)1564737536;
			short num3 = num;
			this.gvwGroups.EndEditMode();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000DE04 File Offset: 0x0000C004
		private void a(Group A_0)
		{
			short num = (short)1744135722;
			short num2 = num;
			num = (short)834037290;
			switch (num2 == num)
			{
			}
			num = (short)55967745;
			if (num != 0)
			{
			}
			num = (short)1075183616;
			if (num != 0)
			{
			}
			num = (short)205914112;
			short num3 = num;
			this.gvwGroups.PrepareRename(A_0);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000DEB8 File Offset: 0x0000C0B8
		private void a(object A_0, KeyboardFocusChangedEventArgs A_1)
		{
			short num = (short)1268458125;
			short num2 = num;
			num = (short)258744973;
			switch (num2 == num)
			{
			}
			num = (short)131334144;
			if (num != 0)
			{
			}
			num = (short)428867585;
			if (num != 0)
			{
			}
			num = (short)7471104;
			short num3 = num;
			this.ctcStatus.Focus();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000DF6C File Offset: 0x0000C16C
		private void a(object A_0, SizeChangedEventArgs A_1)
		{
			short num = (short)983425164;
			short num2 = num;
			num = (short)81715340;
			switch (num2 == num)
			{
			}
			num = (short)1789132801;
			if (num != 0)
			{
			}
			num = (short)748552192;
			if (num != 0)
			{
			}
			num = (short)1335230464;
			short num3 = num;
			this.ctcStatus.Focus();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000E020 File Offset: 0x0000C220
		private static void a(object A_0, MouseButtonEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_65;
			}
			short num;
			int num3;
			PaneTabItem paneTabItem;
			for (;;)
			{
				IL_0A:
				num = (short)833683456;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					ContentPane pane = paneTabItem.Pane;
					num = (short)1104216073;
					num3 = (int)((IntPtr)num);
					continue;
				}
				case 1:
				{
					ContentPane pane;
					if (pane != XamDockManager.GetDockManager(pane).CurrentFlyoutPane)
					{
						num = (short)1363673090;
						num3 = (int)((IntPtr)num);
						continue;
					}
					pane.ExecuteCommand(ContentPaneCommands.FlyIn);
					num = (short)1944059912;
					num3 = (int)((IntPtr)num);
					continue;
				}
				case 2:
				{
					num = (short)184192343;
					short num4 = num;
					num = (short)315133271;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18F;
					default:
					{
						num = (short)1449918464;
						if (num != 0)
						{
						}
						num = (short)895746049;
						if (num != 0)
						{
						}
						ContentPane pane;
						pane.ExecuteCommand(ContentPaneCommands.Flyout);
						pane.Activate();
						num = (short)2012282887;
						num3 = (int)((IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					num = (short)1492320257;
					num3 = (int)((IntPtr)num);
					continue;
				case 4:
					if (paneTabItem != null)
					{
						num = (short)252248064;
						num3 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 5:
				{
					ContentPane pane;
					if (!pane.IsPinned)
					{
						goto IL_18F;
					}
					return;
				}
				case 6:
					num = (short)1424752645;
					num3 = (int)((IntPtr)num);
					continue;
				case 7:
					goto IL_148;
				case 8:
					goto IL_148;
				case 9:
				{
					ContentPane pane;
					if (pane != null)
					{
						num = (short)493813766;
						num3 = (int)((IntPtr)num);
						continue;
					}
					return;
				}
				case 10:
					return;
				}
				goto IL_65;
				IL_148:
				A_1.Handled = true;
				num = (short)1251737610;
				num3 = (int)((IntPtr)num);
				continue;
				IL_18F:
				num = (short)988217347;
				num3 = (int)((IntPtr)num);
			}
			return;
			IL_65:
			paneTabItem = (A_0 as PaneTabItem);
			num = (short)176095236;
			num3 = (int)((IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0400001E RID: 30
		private IEventAggregator eventAggregator;

		// Token: 0x0400001F RID: 31
		private IRegionManager regionManager;

		// Token: 0x04000020 RID: 32
		private string lastActivePane;

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x0600008B RID: 139
		private delegate void a();
	}
}
