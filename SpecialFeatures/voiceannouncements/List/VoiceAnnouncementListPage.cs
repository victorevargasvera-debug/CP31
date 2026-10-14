using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AcpUILib;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.List
{
	// Token: 0x0200002D RID: 45
	public class VoiceAnnouncementListPage : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600065F RID: 1631 RVA: 0x0005CD88 File Offset: 0x0005AF88
		public VoiceAnnouncementListPage()
		{
			try
			{
				this.InitializeComponent();
			}
			catch (global::System.Exception)
			{
			}
			global::AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0005CDC0 File Offset: 0x0005AFC0
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1983905792;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpUI.AcpExpander acpExpander;
				global::System.Collections.IEnumerator enumerator;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 1:
					goto IL_261;
				case 2:
					try
					{
						num = (short)1676017665;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (acpExpander != null)
								{
									num = (short)2123300870;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_99;
								}
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num = (short)1265565701;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)1379205121;
								if (num != 0)
								{
								}
								num = (short)1317994496;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_17E;
							case 5:
								num = (short)1473118211;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								base.Expanders.Add(acpExpander);
								num = (short)791085060;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_104:
							num = (short)1342570498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_99:
							goto IL_104;
						}
						IL_17E:
						goto IL_222;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_19F;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_18D:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)1226964994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1F1;
							case 1:
								goto IL_1EF;
							case 2:
								disposable.Dispose();
								num = (short)1654652929;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19F;
						}
						IL_1EF:
						IL_1F1:
						goto EndFinally_7;
						IL_19F:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)2126839808;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_18D;
						EndFinally_7:;
					}
					goto IL_1F2;
					IL_222:
					this.MyStackPanel.Children[0].Focus();
					base.OnLoaded(sender, e);
					this.a = true;
					num = (short)485097473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1F2;
				}
				IL_35:
				if (!this.a)
				{
					num = (short)1446707203;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_261:
				num = (short)1001954869;
				short num3 = num;
				num = (short)926850613;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_35;
				default:
					goto IL_297;
				}
				IL_1F2:
				acpExpander = null;
				enumerator = this.MyStackPanel.Children.GetEnumerator();
				num = (short)85721090;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_297:
			num = (short)1411645440;
			if (num != 0)
			{
			}
			num = (short)703594496;
			short num4 = num;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0005D0C0 File Offset: 0x0005B2C0
		private global::System.Collections.Generic.List<string> a(global::System.Windows.Controls.SelectionMode A_0)
		{
			short num = (short)1555234817;
			if (num != 0)
			{
			}
			num = (short)1450477721;
			short num2 = num;
			num = (short)2017495193;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1209925632;
				if (num != 0)
				{
				}
				num = (short)543948800;
				short num3 = num;
				global::SpecialFeatures.VoiceAnnouncements.List.CustomVASelectWindow customVASelectWindow = new global::SpecialFeatures.VoiceAnnouncements.List.CustomVASelectWindow();
				customVASelectWindow.VAFileListBoxSelectionMethod = A_0;
				global::System.Windows.Window mainWindow = global::System.Windows.Application.Current.MainWindow;
				customVASelectWindow.Owner = mainWindow;
				bool flag = true;
				bool? flag2 = customVASelectWindow.ShowDialog();
				if (flag == flag2.GetValueOrDefault() & flag2 != null)
				{
					return customVASelectWindow.SelectedVAFiles;
				}
				break;
			}
			}
			return null;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0005D1AC File Offset: 0x0005B3AC
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.a)
						{
							num2 = (short)941228034;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
						goto IL_E6;
					case 2:
						base.OnUnloaded(sender, e);
						this.a = false;
						num2 = (short)1482424321;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_E6:
				num2 = (short)264853670;
				short num3 = num2;
				num2 = (short)2117359782;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_5B;
				default:
					num2 = (short)173080576;
					if (num2 != 0)
					{
					}
					break;
				}
				return;
			}
			}
			IL_1C:
			num2 = (short)1180893185;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarPageVoiceAnnouncementList.DataContext = null;
			this.RecNavToolbarPageVoiceAnnouncementList.MyDataPresenter = null;
			IL_5B:
			num2 = (short)679870464;
			short num4 = num2;
			num2 = (short)22806528;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0005D2F0 File Offset: 0x0005B4F0
		public override void SetDataContext()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1357687279;
					short num3 = num2;
					num2 = (short)1166518767;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1BB;
					default:
						num2 = (short)2132475904;
						if (num2 != 0)
						{
						}
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num2 = (short)145031170;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2300);
						num2 = (short)1826816003;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_E1;
				case 2:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2300);
					num2 = (short)1821442049;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_E1;
				case 4:
					goto IL_15B;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)775946240;
						short num4 = num2;
						num2 = (short)972423172;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20A;
				}
				goto IL_28;
				IL_E1:
				this.RecNavToolbarPageVoiceAnnouncementList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num2 = (short)541982725;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_15B:
			IL_1BB:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2300);
			this.CompGrpBoxExpanderVoiceAnnouncementGeneralPseudo0.DataContext = feature;
			this.RecNavToolbarPageVoiceAnnouncementList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageVoiceAnnouncementList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageVoiceAnnouncementList).SyncDataSources();
			return;
			IL_20A:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageVoiceAnnouncementList).MySecondaryRecordsetDataSource = null;
			return;
			IL_28:
			base.MyBaseRecNavToolbar = this.RecNavToolbarPageVoiceAnnouncementList;
			num2 = (short)1299054593;
			if (num2 != 0)
			{
			}
			num2 = (short)1222508544;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0005D514 File Offset: 0x0005B714
		private void OnMultiAddClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)527630338;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpUI.AcpVoiceAnnRecNavToolBar acpVoiceAnnRecNavToolBar;
				switch (num2)
				{
				case 0:
					if (acpVoiceAnnRecNavToolBar.VoiceAnnFiles != null)
					{
						goto IL_14F;
					}
					return;
				case 1:
					goto IL_168;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 3:
					acpVoiceAnnRecNavToolBar = (A_0 as global::AcpUI.AcpVoiceAnnRecNavToolBar);
					global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.vaCount = 0;
					num = (short)596049920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1138530479;
					short num3 = num;
					num = (short)141793455;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14F;
					default:
						num = (short)706936832;
						if (num != 0)
						{
						}
						num = (short)1953497094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.voiceFiles = new string[acpVoiceAnnRecNavToolBar.VoiceAnnFiles.Length];
					num = (short)801177608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.voiceFiles == null)
					{
						num = (short)1443495941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.voiceFiles = null;
					global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.voiceFiles = new string[acpVoiceAnnRecNavToolBar.VoiceAnnFiles.Length];
					num = (short)679936001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					return;
				case 8:
					num = (short)1397555201;
					if (num != 0)
					{
					}
					goto IL_168;
				}
				IL_49:
				if (A_0 is global::AcpUI.AcpVoiceAnnRecNavToolBar)
				{
					num = (short)199622656;
					short num4 = num;
					num = (short)130547715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_14F:
				num = (short)1427439620;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_168:
				acpVoiceAnnRecNavToolBar.VoiceAnnFiles.CopyTo(global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.voiceFiles, 0);
				num = (short)1917059079;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0005D740 File Offset: 0x0005B940
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 18;
			short num = (short)1358430209;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
				switch (num2)
				{
				case 0:
					num = (short)491126788;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 2:
				{
					num = (short)1443364864;
					short num3 = num;
					if (myRecordsetDataSource != null)
					{
						num = (short)740163585;
						if (num != 0)
						{
						}
						num = (short)793378821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
					myRecordsetDataSource = this.RecNavToolbarPageVoiceAnnouncementList.MyRecordsetDataSource;
					num = (short)2080768002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잔滛햚ﲜ첢쪤쮦쮨쪪\udfacﾮ킰풲킴횸튺\udebc\udabe胀귂ꯄ꣆볈ꗊ껌꫎볐뛒믔ꏖ闘닚껜ꯞ", a_))
					{
						num = (short)998834179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					goto IL_6E;
				case 6:
				{
					num = (short)333211215;
					short num4 = num;
					num = (short)1867408975;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6E;
					default:
						goto IL_D0;
					}
					break;
				}
				}
				IL_4A:
				if (A_0 is global::AcpUI.AcpRecNavToolbar)
				{
					num = (short)1973944320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_6E:
				base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
				num = (short)999686150;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D0:
			num = (short)1500250112;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0005D924 File Offset: 0x0005BB24
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1202978816;
			short num2 = num;
			num = (short)1803091969;
			if (num != 0)
			{
			}
			num = (short)1539360447;
			short num3 = num;
			num = (short)2115421887;
			switch (num3 == num)
			{
			}
			num = (short)1837957120;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0005D9D0 File Offset: 0x0005BBD0
		private void a(object A_0)
		{
			short num = (short)937099264;
			short num2 = num;
			num = (short)452311527;
			short num3 = num;
			num = (short)1377024487;
			switch (num3 == num)
			{
			}
			num = (short)1769734144;
			if (num != 0)
			{
			}
			num = (short)2147155969;
			if (num != 0)
			{
			}
			global::AcpCommonLib.ApplicationMode appMode = global::AcpCommonLib.AppInfoManager.AppMode;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0005DA7C File Offset: 0x0005BC7C
		private void HLinkVoiceAnnouncementClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1462960128;
			short num2 = num;
			num = (short)27660393;
			short num3 = num;
			num = (short)129306729;
			switch (num3 == num)
			{
			}
			num = (short)109314049;
			if (num != 0)
			{
			}
			num = (short)1894252544;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0005DB2C File Offset: 0x0005BD2C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 2;
			short num = (short)182523975;
			short num2 = num;
			num = (short)1684412487;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)98304000;
				if (num != 0)
				{
				}
				num = (short)1456144385;
				if (num != 0)
				{
				}
				num = (short)1315045376;
				short num3 = num;
				if (this.b)
				{
					return;
				}
				break;
			}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꪄ풆麗ﾒ펔쒠킢麤쒦욨욪\uddac삮\udfb0횲\udbb4쎶隸춺튼횾ꋀꛂ꓄꧆ꟈ꓊료ꇎ닐뛒룔닖럘꿚껜韠賢賤蓦賨諪菬臮黰蛲鯴银鳸雺飼釾甀漂氄理紈␊笌怎砐瀒瀔瘖眘甚爜樞传䀢䀤䨦䰨䔪夬䌮堰䀲䄴ᤶ䄸娺值匾", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0005DC0C File Offset: 0x0005BE0C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)595984384;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					goto IL_244;
				case 2:
					num = (short)546766849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_D9;
				case 2:
					goto IL_131;
				case 3:
					goto IL_BF;
				case 4:
					goto IL_249;
				case 5:
					goto IL_220;
				case 6:
					goto IL_26D;
				case 7:
					goto IL_124;
				case 8:
					goto IL_B2;
				case 9:
					goto IL_27A;
				case 10:
					goto IL_10A;
				case 11:
					goto IL_8E;
				case 12:
					goto IL_1D3;
				case 13:
					goto IL_CC;
				case 14:
					goto IL_1C6;
				case 15:
					goto IL_117;
				default:
					num = (short)1550188546;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_8E:
			this.LblVoiceFileName_A21220 = (global::AcpUI.AcpLabel)target;
			this.LblVoiceFileName_A21220.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B2:
			this.GrpBoxExpanderVoiceAnnouncementListGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_BF:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_CC:
			this.CompGrpBoxExpanderVoiceAnnouncementGeneralPseudo0 = (global::System.Windows.Controls.Grid)target;
			return;
			IL_D9:
			((global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListPage)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListPage)target).Unloaded += this.OnUnloaded;
			return;
			IL_10A:
			this.CVBtnVoiceFileName_A21220 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_117:
			this.VoiceFileName_A21220Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_124:
			this.ExpanderVoiceAnnouncementGeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_131:
			num = (short)1909038483;
			short num3 = num;
			num = (short)1727700371;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_CC;
			default:
				num = (short)1279721473;
				if (num != 0)
				{
				}
				num = (short)982384640;
				if (num != 0)
				{
				}
				this.RecNavToolbarPageVoiceAnnouncementList = (global::AcpUI.AcpParentRecNavToolbar)target;
				this.RecNavToolbarPageVoiceAnnouncementList.ModeClick += this.OnModeClick;
				return;
			}
			IL_1C6:
			this.CpyBtnVoiceFileName_A21220 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1D3:
			num = (short)500891648;
			short num4 = num;
			this.VoiceFileName_A21220 = (global::AcpUI.AcpTextBoxFileBrowser)target;
			this.VoiceFileName_A21220.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_220:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_244:
			this.b = true;
			return;
			IL_249:
			this.HLinkVoiceAnnouncementGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkVoiceAnnouncementGeneral.Click += this.HLinkVoiceAnnouncementClick;
			return;
			IL_26D:
			this.ExpanderVoiceAnnouncementGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_27A:
			this.StdGrpBoxExpanderVoiceAnnouncementGeneralPseudo0 = (global::System.Windows.Controls.Grid)target;
		}

		// Token: 0x04000278 RID: 632
		private bool a;

		// Token: 0x04000279 RID: 633
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageVoiceAnnouncementList;

		// Token: 0x0400027A RID: 634
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x0400027B RID: 635
		internal global::System.Windows.Documents.Hyperlink HLinkVoiceAnnouncementGeneral;

		// Token: 0x0400027C RID: 636
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x0400027D RID: 637
		internal global::AcpUI.AcpExpander ExpanderVoiceAnnouncementGeneral;

		// Token: 0x0400027E RID: 638
		internal global::System.Windows.Controls.Grid ExpanderVoiceAnnouncementGeneralGrid;

		// Token: 0x0400027F RID: 639
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderVoiceAnnouncementListGeneralPseudo0;

		// Token: 0x04000280 RID: 640
		internal global::System.Windows.Controls.Grid StdGrpBoxExpanderVoiceAnnouncementGeneralPseudo0;

		// Token: 0x04000281 RID: 641
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnVoiceFileName_A21220;

		// Token: 0x04000282 RID: 642
		internal global::AcpUI.AcpLabel LblVoiceFileName_A21220;

		// Token: 0x04000283 RID: 643
		internal global::AcpUI.AcpTextBoxFileBrowser VoiceFileName_A21220;

		// Token: 0x04000284 RID: 644
		internal global::System.Windows.Controls.Grid CompGrpBoxExpanderVoiceAnnouncementGeneralPseudo0;

		// Token: 0x04000285 RID: 645
		internal global::AcpUI.AcpCopyButton CpyBtnVoiceFileName_A21220;

		// Token: 0x04000286 RID: 646
		internal global::AcpUI.AcpViewOnlyCtrl VoiceFileName_A21220Comp;

		// Token: 0x04000287 RID: 647
		private bool b;
	}
}
