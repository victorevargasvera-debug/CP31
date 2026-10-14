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

namespace SpecialFeatures.SystemCertificates.List
{
	// Token: 0x020001AF RID: 431
	public class SystemCertificateListPageTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600145D RID: 5213 RVA: 0x001D53F8 File Offset: 0x001D35F8
		public SystemCertificateListPageTbl()
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

		// Token: 0x0600145E RID: 5214 RVA: 0x001D5430 File Offset: 0x001D3630
		public override void SetDataContext()
		{
			short num = (short)2112787764;
			short num2 = num;
			num = (short)642880820;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_16F:
				num = (short)457179138;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)606994432;
				if (num != 0)
				{
				}
				num = (short)1119354880;
				short num4 = num;
				num = (short)1698299905;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_15A;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_B3;
					}
					continue;
				case 2:
					num = (short)411697153;
					if (num != 0)
					{
					}
					goto IL_D8;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1123221504;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_207;
				case 4:
					goto IL_D8;
				case 5:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4228);
					num = (short)389545988;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B3:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1270022149;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_15F;
				IL_D8:
				this.SystemCertificateListDataPresenter.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageSystemCertificateTbl.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageSystemCertificateTbl.MyDataPresenter = this.SystemCertificateListDataPresenter;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageSystemCertificateTbl;
				num = (short)1253244931;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_15A:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4228);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageSystemCertificateTbl).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_15F:
			base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4228);
			goto IL_16F;
			IL_207:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageSystemCertificateTbl).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x001D5650 File Offset: 0x001D3850
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)768933888;
			short num2 = num;
			num = (short)1474494465;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 2:
					if (global::ConstraintHelper.UtilityMack.bOpenFromRMC)
					{
						goto IL_185;
					}
					return;
				case 3:
					this.RecNavToolbarPageSystemCertificateTbl.SelectVAFileDialog = new global::System.Func<global::System.Windows.Controls.SelectionMode, global::System.Collections.Generic.List<string>>(this.a);
					global::AcpUI.AcpTextBoxFileBrowser.SelectVAFileDialog = new global::System.Func<global::System.Windows.Controls.SelectionMode, global::System.Collections.Generic.List<string>>(this.a);
					num = (short)1350303744;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					base.OnLoaded(sender, e);
					object myRecordsetDataSource = this.RecNavToolbarPageSystemCertificateTbl.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					this.b = true;
					num = (short)834899240;
					short num4 = num;
					num = (short)2061864232;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_185;
					default:
						num = (short)1369767936;
						if (num != 0)
						{
						}
						num = (short)716046338;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_63:
				num = (short)638779393;
				if (num != 0)
				{
				}
				if (!this.b)
				{
					num = (short)1622474756;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_185:
				num = (short)50724867;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x001D5800 File Offset: 0x001D3A00
		private global::System.Collections.Generic.List<string> a(global::System.Windows.Controls.SelectionMode A_0)
		{
			global::SpecialFeatures.SystemCertificates.List.CustomSelectWindow customSelectWindow = new global::SpecialFeatures.SystemCertificates.List.CustomSelectWindow();
			customSelectWindow.CertFileListBoxSelectionMethod = A_0;
			bool flag = true;
			bool? flag2 = customSelectWindow.ShowDialog();
			if (flag == flag2.GetValueOrDefault() & flag2 != null)
			{
				short num;
				for (;;)
				{
					num = (short)444618151;
					short num2 = num;
					num = (short)604329383;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_61;
					}
				}
				IL_61:
				num = (short)1519058945;
				if (num != 0)
				{
				}
				num = (short)1421410304;
				if (num != 0)
				{
				}
				num = (short)939851776;
				short num3 = num;
				return customSelectWindow.SelectedCertFiles;
			}
			return null;
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x001D58DC File Offset: 0x001D3ADC
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
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
					num2 = (short)1322844161;
					if (num2 != 0)
					{
					}
					goto IL_F6;
				case 1:
					base.OnUnloaded(sender, e);
					this.b = false;
					this.RecNavToolbarPageSystemCertificateTbl.SelectVAFileDialog = null;
					global::AcpUI.AcpTextBoxFileBrowser.SelectVAFileDialog = null;
					goto IL_B5;
				case 2:
					if (this.b)
					{
						num2 = (short)87621633;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F6;
				}
				goto IL_1C;
				IL_B5:
				num2 = (short)1738473472;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_F6:
				num2 = (short)976473953;
				short num3 = num2;
				num2 = (short)1789251425;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B5;
				default:
					goto IL_12B;
				}
			}
			IL_12B:
			num2 = (short)759365632;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			num2 = (short)1420820480;
			short num4 = num2;
			this.RecNavToolbarPageSystemCertificateTbl.DataContext = null;
			this.RecNavToolbarPageSystemCertificateTbl.MyDataPresenter = null;
			num2 = (short)107347970;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x001D5A2C File Offset: 0x001D3C2C
		internal void OnVoiceAnnouncementListFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2046247333;
			short num2 = num;
			num = (short)1988772261;
			switch (num2 == num)
			{
			}
			num = (short)770703360;
			if (num != 0)
			{
			}
			num = (short)229703680;
			short num3 = num;
			num = (short)1452736513;
			if (num != 0)
			{
			}
			global::SpecialFeatures.SystemCertificates.List.SystemCertificateList a_ = (global::SpecialFeatures.SystemCertificates.List.SystemCertificateList)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x001D5B00 File Offset: 0x001D3D00
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)108616361;
			short num2 = num;
			num = (short)638671529;
			switch (num2 == num)
			{
			}
			num = (short)2102067201;
			if (num != 0)
			{
			}
			num = (short)1324613632;
			short num3 = num;
			num = (short)845021184;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x001D5BB0 File Offset: 0x001D3DB0
		private void OnMultiAddClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2117599240;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpUI.AcpVoiceAnnRecNavToolBar acpVoiceAnnRecNavToolBar;
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet.systemCertificateFiles == null)
					{
						num = (short)1759379462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet.systemCertificateFiles = null;
					global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet.systemCertificateFiles = new string[acpVoiceAnnRecNavToolBar.VoiceAnnFiles.Length];
					num = (short)27525122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1B2;
				case 3:
					acpVoiceAnnRecNavToolBar = (A_0 as global::AcpUI.AcpVoiceAnnRecNavToolBar);
					global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet.systemCertificateCount = 0;
					num = (short)1567358980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (acpVoiceAnnRecNavToolBar.VoiceAnnFiles != null)
					{
						num = (short)1092485127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					goto IL_1B2;
				case 6:
					global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet.systemCertificateFiles = new string[acpVoiceAnnRecNavToolBar.VoiceAnnFiles.Length];
					num = (short)454361093;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)352976897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)273874945;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_71;
					}
					continue;
				}
				IL_71:
				if (!(A_0 is global::AcpUI.AcpVoiceAnnRecNavToolBar))
				{
					break;
				}
				num = (short)1693817956;
				short num3 = num;
				num = (short)421502052;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)636157952;
					short num4 = num;
					num = (short)696844288;
					if (num != 0)
					{
					}
					num = (short)253493251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_1B2:
				acpVoiceAnnRecNavToolBar.VoiceAnnFiles.CopyTo(global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet.systemCertificateFiles, 0);
				num = (short)603455488;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x001D5DDC File Offset: 0x001D3FDC
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
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
					goto IL_EB;
				case 1:
					this.a.MoveCurrentToFirst();
					goto IL_AB;
				case 2:
					if (this.a.CurrentItem == null)
					{
						num2 = (short)1231486977;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EB;
				}
				goto IL_1C;
				IL_AB:
				num2 = (short)1488715777;
				if (num2 != 0)
				{
				}
				num2 = (short)86704128;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_EB:
				num2 = (short)323286536;
				short num3 = num2;
				num2 = (short)895219208;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AB;
				default:
					goto IL_11F;
				}
			}
			IL_11F:
			num2 = (short)1655832576;
			if (num2 != 0)
			{
			}
			global::SpecialFeatures.SystemCertificates.List.SystemCertificateList a_ = (global::SpecialFeatures.SystemCertificates.List.SystemCertificateList)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_1C:
			num2 = (short)1069809664;
			short num4 = num2;
			object myRecordsetDataSource = this.RecNavToolbarPageSystemCertificateTbl.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num2 = (short)1146552322;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x001D5F38 File Offset: 0x001D4138
		private void a(global::SpecialFeatures.SystemCertificates.List.SystemCertificateList A_0)
		{
			int a_ = 16;
			this.a.MoveCurrentTo(A_0);
			global::System.Windows.Navigation.NavigationService navigationService = base.NavigationService;
			if (A_0 != null)
			{
				short num = (short)235314723;
				short num2 = num;
				num = (short)1828757027;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)288030721;
					if (num != 0)
					{
					}
					num = (short)131727360;
					if (num != 0)
					{
					}
					num = (short)1063059456;
					short num3 = num;
					navigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
					return;
				}
				}
			}
			navigationService.Navigate(new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삒滛ﲜ욢쒤펦\udca8\ud9aa좬\udcae誰\udab4\udab6즸풺펼\udabe꿀럂駄蓆곈맊만ꛎ럐뫒뛔뛖귘뻚郜뻞迠苢苤苦蓨軪菬鯮귰ꃲ賴蓶跸黺郼볾搀焂焄渆漈戊渌渎攐瘒夔縖樘漚䄜䰞堠倢儤䈦䐨株䠬崮䔰娲匴帶娸娺䤼娾ീ⩂㙄㍆杈㍊ⱌ≎㵐", a_), global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x001D6034 File Offset: 0x001D4234
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 8;
			if (this.c)
			{
				short num = (short)1780295837;
				short num2 = num;
				num = (short)923805853;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1111949313;
					if (num != 0)
					{
					}
					num = (short)578224128;
					if (num != 0)
					{
					}
					num = (short)2133786624;
					short num3 = num;
					return;
				}
				}
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꒊ\ude8cﾎﲔ\udd9aﺞ햠횢힤슦\udaa8邪캬삮\udcb0쎲\udab4\ud9b6\udcb8햺즼邾ꋀꛂ럄돆ꃈ귊꓌곎냐꟒냔뫖룘뗚볜룞蓠転胤触鷨쓪黬雮苰蟲郴髶髸黺迼课栀攂氄搆栈缊栌挎砐怒愔㠖樘戚渜欞䐠丢䘤䈦嬨弪䐬䤮堰倲吴䌶尸场吼䰾㕀㝂❄⭆杈㍊ⱌ≎㵐", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x001D6118 File Offset: 0x001D4318
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1415380994;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F5;
				case 1:
					num = (short)330629120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)1901264896;
				short num3 = num;
				switch (connectionId)
				{
				case 1:
				{
					num = (short)1619852523;
					short num4 = num;
					num = (short)513080555;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_162;
					}
					break;
				}
				case 2:
					goto IL_A2;
				case 3:
				case 4:
					goto IL_1B6;
				case 5:
					goto IL_1A9;
				case 6:
					goto IL_95;
				case 7:
					goto IL_FA;
				default:
					num = (short)352190465;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_95:
			this.System_Certificate_Name_col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_A2:
			this.RecNavToolbarPageSystemCertificateTbl = (global::AcpUI.AcpVoiceAnnRecNavToolBar)target;
			this.RecNavToolbarPageSystemCertificateTbl.ModeClick += this.OnModeClick;
			this.RecNavToolbarPageSystemCertificateTbl.MultiAddClick += this.OnMultiAddClick;
			return;
			IL_F5:
			goto IL_1B6;
			IL_FA:
			num = (short)869466113;
			if (num != 0)
			{
			}
			this.System_Certificate_FileName_A43634_col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_162:
			num = (short)319422464;
			if (num != 0)
			{
			}
			((global::SpecialFeatures.SystemCertificates.List.SystemCertificateListPageTbl)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.SystemCertificates.List.SystemCertificateListPageTbl)target).Unloaded += this.OnUnloaded;
			return;
			IL_1A9:
			this.SystemCertificateListDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1B6:
			this.c = true;
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x001D62E4 File Offset: 0x001D44E4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1747451907;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1026555904;
					short num3 = num;
					switch (num2)
					{
					case 0:
						num = (short)1104281602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
					{
						if (connectionId == 4)
						{
							goto IL_140;
						}
						num = (short)886039364;
						short num4 = num;
						num = (short)762897220;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1333002241;
							if (num != 0)
							{
							}
							num = (short)1698234368;
							if (num != 0)
							{
							}
							num = (short)173604865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					}
					IL_60:
					if (connectionId == 3)
					{
						goto IL_7A;
					}
					num = (short)946470912;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_7A:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_140:
			((global::AcpUI.AcpTextBoxFileBrowser)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000B27 RID: 2855
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04000B28 RID: 2856
		private bool b;

		// Token: 0x04000B29 RID: 2857
		internal global::AcpUI.AcpVoiceAnnRecNavToolBar RecNavToolbarPageSystemCertificateTbl;

		// Token: 0x04000B2A RID: 2858
		internal global::AcpUI.AcpXamDataPresenter SystemCertificateListDataPresenter;

		// Token: 0x04000B2B RID: 2859
		internal global::Infragistics.Windows.DataPresenter.UnboundField System_Certificate_Name_col;

		// Token: 0x04000B2C RID: 2860
		internal global::Infragistics.Windows.DataPresenter.UnboundField System_Certificate_FileName_A43634_col;

		// Token: 0x04000B2D RID: 2861
		private bool c;
	}
}
