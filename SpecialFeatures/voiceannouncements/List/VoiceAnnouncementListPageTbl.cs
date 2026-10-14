using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Navigation;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AcpUILib;
using ConstraintHelper;
using Infragistics.Windows.DataPresenter;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.List
{
	// Token: 0x02000031 RID: 49
	public class VoiceAnnouncementListPageTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06000685 RID: 1669 RVA: 0x000609E4 File Offset: 0x0005EBE4
		public VoiceAnnouncementListPageTbl()
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

		// Token: 0x06000686 RID: 1670 RVA: 0x00060A1C File Offset: 0x0005EC1C
		public override void SetDataContext()
		{
			for (;;)
			{
				IL_00:
				short num = (short)624820225;
				if (num != 0)
				{
				}
				num = (short)244645890;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_87;
					case 1:
					{
						num = (short)90636288;
						short num3 = num;
						base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2300);
						num = (short)1486225408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 3:
					{
						if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							goto IL_201;
						}
						num = (short)1921031420;
						short num4 = num;
						num = (short)586063100;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1861222400;
							if (num != 0)
							{
							}
							num = (short)1320222725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_87;
					case 5:
						goto IL_154;
					}
					IL_62:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)426770433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2300);
					num = (short)1213530116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_87:
					this.VoiceAnnouncementListDataPresenter.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
					this.RecNavToolbarPageVoiceAnnouncementTbl.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
					this.RecNavToolbarPageVoiceAnnouncementTbl.MyDataPresenter = this.VoiceAnnouncementListDataPresenter;
					base.MyBaseRecNavToolbar = this.RecNavToolbarPageVoiceAnnouncementTbl;
					num = (short)1743388675;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_154:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2300);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageVoiceAnnouncementTbl).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_201:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageVoiceAnnouncementTbl).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00060C38 File Offset: 0x0005EE38
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1347482143;
			short num2 = num;
			num = (short)449442335;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_110:
				base.OnLoaded(sender, e);
				object myRecordsetDataSource = this.RecNavToolbarPageVoiceAnnouncementTbl.MyRecordsetDataSource;
				this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				this.b = true;
				num = (short)368115715;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)855441408;
				if (num != 0)
				{
				}
				num = (short)1274347521;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)558432257;
					if (num != 0)
					{
					}
					num = (short)666238976;
					short num4 = num;
					this.RecNavToolbarPageVoiceAnnouncementTbl.SelectVAFileDialog = new global::System.Func<global::System.Windows.Controls.SelectionMode, global::System.Collections.Generic.List<string>>(this.a);
					global::AcpUI.AcpTextBoxFileBrowser.SelectVAFileDialog = new global::System.Func<global::System.Windows.Controls.SelectionMode, global::System.Collections.Generic.List<string>>(this.a);
					num = (short)739442692;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_81;
					}
					continue;
				case 2:
					goto IL_A1;
				case 3:
					if (global::ConstraintHelper.UtilityMack.bOpenFromRMC)
					{
						num = (short)1709047808;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					return;
				}
				IL_81:
				if (this.b)
				{
					return;
				}
				num = (short)65994754;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_A1:
			goto IL_110;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00060DE4 File Offset: 0x0005EFE4
		private global::System.Collections.Generic.List<string> a(global::System.Windows.Controls.SelectionMode A_0)
		{
			short num = (short)991756288;
			short num2 = num;
			num = (short)876625462;
			short num3 = num;
			num = (short)1702051382;
			global::SpecialFeatures.VoiceAnnouncements.List.CustomVASelectWindow customVASelectWindow;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)405602305;
				if (num != 0)
				{
				}
				num = (short)156041216;
				if (num != 0)
				{
				}
				customVASelectWindow = new global::SpecialFeatures.VoiceAnnouncements.List.CustomVASelectWindow();
				customVASelectWindow.VAFileListBoxSelectionMethod = A_0;
				bool flag = true;
				bool? flag2 = customVASelectWindow.ShowDialog();
				if (!(flag == flag2.GetValueOrDefault() & flag2 != null))
				{
					return null;
				}
				break;
			}
			}
			return customVASelectWindow.SelectedVAFiles;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00060EC0 File Offset: 0x0005F0C0
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1405288448;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			for (;;)
			{
				IL_33:
				int num3;
				switch (num3)
				{
				case 0:
					if (this.b)
					{
						num = (short)528416770;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					base.OnUnloaded(sender, e);
					this.b = false;
					this.RecNavToolbarPageVoiceAnnouncementTbl.SelectVAFileDialog = null;
					global::AcpUI.AcpTextBoxFileBrowser.SelectVAFileDialog = null;
					num = (short)236191745;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_45;
			}
			return;
			IL_45:
			this.RecNavToolbarPageVoiceAnnouncementTbl.DataContext = null;
			this.RecNavToolbarPageVoiceAnnouncementTbl.MyDataPresenter = null;
			num = (short)1373349592;
			short num4 = num;
			num = (short)1821943512;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_33;
			default:
			{
				num = (short)784007168;
				if (num != 0)
				{
				}
				num = (short)342491137;
				if (num != 0)
				{
				}
				num = (short)159186944;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00061010 File Offset: 0x0005F210
		internal void OnVoiceAnnouncementListFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)423428097;
			if (num != 0)
			{
			}
			num = (short)542064627;
			short num2 = num;
			num = (short)109658099;
			switch (num2 == num)
			{
			}
			num = (short)126353408;
			if (num != 0)
			{
			}
			num = (short)2130509824;
			short num3 = num;
			global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList a_ = (global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x000610E4 File Offset: 0x0005F2E4
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)598692344;
			short num2 = num;
			num = (short)367612408;
			switch (num2 == num)
			{
			}
			num = (short)110297088;
			if (num != 0)
			{
			}
			num = (short)864485377;
			if (num != 0)
			{
			}
			num = (short)1962344448;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00061198 File Offset: 0x0005F398
		private void OnMultiAddClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1086145930;
			short num2 = num;
			num = (short)674121098;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1A8:
				num = (short)1181220871;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)764346369;
				if (num != 0)
				{
				}
				num = (short)917372928;
				if (num != 0)
				{
				}
				num = (short)2016804864;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				global::AcpUI.AcpVoiceAnnRecNavToolBar acpVoiceAnnRecNavToolBar;
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_B8;
					}
					continue;
				case 1:
					return;
				case 2:
					goto IL_1AA;
				case 3:
					global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.voiceFiles = new string[acpVoiceAnnRecNavToolBar.VoiceAnnFiles.Length];
					num = (short)1467285508;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1AA;
				case 5:
					acpVoiceAnnRecNavToolBar = (A_0 as global::AcpUI.AcpVoiceAnnRecNavToolBar);
					global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.vaCount = 0;
					num = (short)661389318;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (acpVoiceAnnRecNavToolBar.VoiceAnnFiles != null)
					{
						num = (short)140050440;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					if (global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.voiceFiles == null)
					{
						num = (short)1236074499;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.voiceFiles = null;
					global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.voiceFiles = new string[acpVoiceAnnRecNavToolBar.VoiceAnnFiles.Length];
					num = (short)1356726274;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_1A8;
				}
				IL_B8:
				if (A_0 is global::AcpUI.AcpVoiceAnnRecNavToolBar)
				{
					num = (short)2036793344;
					short num4 = num;
					num = (short)658505733;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1AA:
				acpVoiceAnnRecNavToolBar.VoiceAnnFiles.CopyTo(global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet.voiceFiles, 0);
				num = (short)1538981889;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x000613B8 File Offset: 0x0005F5B8
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)239992832;
			short num2 = num;
			int num4;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_35:
					num = (short)537748150;
					short num3 = num;
					num = (short)708207286;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B3;
					default:
						num = (short)1594294272;
						if (num != 0)
						{
						}
						switch (num4)
						{
						case 0:
							if (this.a.CurrentItem == null)
							{
								num = (short)679149569;
								if (num != 0)
								{
								}
								num = (short)764936193;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_141;
						case 1:
							this.a.MoveCurrentToFirst();
							num = (short)1712259074;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_13F;
						}
						goto IL_94;
					}
				}
				IL_13F:
				IL_141:
				global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList a_ = (global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList)this.a.CurrentItem;
				this.a(a_);
				return;
			}
			}
			IL_94:
			object myRecordsetDataSource = this.RecNavToolbarPageVoiceAnnouncementTbl.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			IL_B3:
			num = (short)1328480256;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_35;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00061520 File Offset: 0x0005F720
		private void a(global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList A_0)
		{
			int a_ = 12;
			short num = (short)610631431;
			short num2 = num;
			num = (short)961969927;
			global::System.Windows.Navigation.NavigationService navigationService;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1173553152;
				short num3 = num;
				num = (short)129957889;
				if (num != 0)
				{
				}
				num = (short)310378496;
				if (num != 0)
				{
				}
				this.a.MoveCurrentTo(A_0);
				navigationService = base.NavigationService;
				if (A_0 == null)
				{
					navigationService.Navigate(new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8eﺖ\udb9c爵삠힢키햦첨\ud8aa隬\udeb0\udeb2어\ud8b6ힸ\udeba펼쮾鷀闂꫄껆꫈껊賌ꇎ뿐볒ꃔ맖뫘뻚냜뫞迠韢雤믦뿨蓪蓬賮铰닲鯴駶雸軺鏼鳾搀渂怄椆紈䜊搌簎攐伒䌔砖瀘砚砜帞传䴢䨤刦䜨䠪䠬䈮吰崲䄴笶倸䠺䤼ᄾ㥀≂⡄⭆", a_), global::System.UriKind.RelativeOrAbsolute));
					return;
				}
				break;
			}
			}
			navigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0006161C File Offset: 0x0005F81C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 14;
			short num = (short)1024983041;
			if (num != 0)
			{
			}
			num = (short)1607918647;
			short num2 = num;
			num = (short)25814071;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)495386624;
				short num3 = num;
				break;
			}
			}
			num = (short)152764416;
			if (num != 0)
			{
			}
			if (!this.c)
			{
				this.c = true;
				global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺐삒滛ﲜ욢쒤펦\udca8\ud9aa좬\udcae誰킲\udab4\udab6즸풺펼\udabe꿀럂뇆ꛈꋊ껌꫎냐뷒믔룖곘뗚뻜뫞賠蛢诤鏦髨쓪鯬胮飰郲郴零韸闺鋼諾漀怂怄樆氈攊礌挎砐怒愔㠖漘琚琜簞䐠䈢䬤䤦䘨帪䌬䰮吰帲倴夶䴸场吼䰾㕀㝂❄⭆杈㍊ⱌ≎㵐", a_), global::System.UriKind.Relative);
				global::System.Windows.Application.LoadComponent(this, resourceLocator);
				return;
			}
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x000616FC File Offset: 0x0005F8FC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)84934656;
			short num2 = num;
			num = (short)1423245312;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1978703798;
				short num4 = num;
				num = (short)1112776630;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_176;
				default:
					num = (short)87097344;
					if (num != 0)
					{
					}
					num = (short)1142161409;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_CE;
						}
						continue;
					case 1:
						num = (short)2098790402;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_164;
					}
					IL_CE:
					switch (connectionId)
					{
					case 1:
						goto IL_176;
					case 2:
						goto IL_111;
					case 3:
						goto IL_1A7;
					case 4:
						goto IL_104;
					case 5:
						goto IL_169;
					default:
						num = (short)1326186497;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
			}
			IL_104:
			this.VoiceAnnouncementListDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_111:
			this.RecNavToolbarPageVoiceAnnouncementTbl = (global::AcpUI.AcpVoiceAnnRecNavToolBar)target;
			this.RecNavToolbarPageVoiceAnnouncementTbl.ModeClick += this.OnModeClick;
			this.RecNavToolbarPageVoiceAnnouncementTbl.MultiAddClick += this.OnMultiAddClick;
			return;
			IL_164:
			goto IL_1A7;
			IL_169:
			this.Voice_FileName_A21220_col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_176:
			((global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListPageTbl)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListPageTbl)target).Unloaded += this.OnUnloaded;
			return;
			IL_1A7:
			this.c = true;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000618B8 File Offset: 0x0005FAB8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1067253760;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)278106436;
					short num3 = num;
					num = (short)318280004;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)262602752;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_79;
						}
						continue;
					}
					break;
				}
				case 1:
				{
					num = (short)917307392;
					short num4 = num;
					((global::AcpUI.AcpTextBoxFileBrowser)target).GotFocus += this.OnFieldNameDoubleClick;
					num = (short)698941442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_ED;
				}
				IL_79:
				if (connectionId != 3)
				{
					return;
				}
				num = (short)593625089;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_ED:
			num = (short)1165164545;
			if (num != 0)
			{
			}
		}

		// Token: 0x0400028E RID: 654
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x0400028F RID: 655
		private bool b;

		// Token: 0x04000290 RID: 656
		internal global::AcpUI.AcpVoiceAnnRecNavToolBar RecNavToolbarPageVoiceAnnouncementTbl;

		// Token: 0x04000291 RID: 657
		internal global::AcpUI.AcpXamDataPresenter VoiceAnnouncementListDataPresenter;

		// Token: 0x04000292 RID: 658
		internal global::Infragistics.Windows.DataPresenter.UnboundField Voice_FileName_A21220_col;

		// Token: 0x04000293 RID: 659
		private bool c;
	}
}
