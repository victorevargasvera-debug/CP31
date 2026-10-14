using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Navigation;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AcpUILib;
using Infragistics.Windows.DataPresenter;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.DVRSFiles.List
{
	// Token: 0x02000132 RID: 306
	public class DVRSFileListPageTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600101C RID: 4124 RVA: 0x00166F18 File Offset: 0x00165118
		public DVRSFileListPageTbl()
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

		// Token: 0x0600101D RID: 4125 RVA: 0x00166F50 File Offset: 0x00165150
		public override void SetDataContext()
		{
			short num = (short)1416036355;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_8B;
				case 1:
					goto IL_8B;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						goto IL_F6;
					}
					goto IL_207;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 4:
					goto IL_10E;
				case 5:
				{
					num = (short)193331201;
					if (num != 0)
					{
					}
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4234);
					num = (short)281335302;
					short num3 = num;
					num = (short)1668404742;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F6;
					default:
						num = (short)560267264;
						if (num != 0)
						{
						}
						num = (short)38731777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_3D:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1553989637;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4234);
				num = (short)1159266304;
				short num4 = num;
				num = (short)1152516096;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8B:
				this.DVRSFileListDataPresenter.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageDVRSFileTbl.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageDVRSFileTbl.MyDataPresenter = this.DVRSFileListDataPresenter;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageDVRSFileTbl;
				num = (short)801439746;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F6:
				num = (short)1306525700;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10E:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4234);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageDVRSFileTbl).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_207:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageDVRSFileTbl).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00167170 File Offset: 0x00165370
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1222246402;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)1271988224;
					short num3 = num;
					base.OnLoaded(sender, e);
					object myRecordsetDataSource = this.RecNavToolbarPageDVRSFileTbl.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					this.b = true;
					num = (short)306708481;
					if (num != 0)
					{
					}
					num = (short)149430440;
					short num4 = num;
					num = (short)1679827112;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)170459136;
						if (num != 0)
						{
						}
						num = (short)1417150464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (this.b)
				{
					break;
				}
				num = (short)1846607873;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x001672B4 File Offset: 0x001654B4
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_42;
			}
			short num;
			int num2;
			for (;;)
			{
				IL_0A:
				num = (short)691273729;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_114;
				case 1:
					for (;;)
					{
						base.OnUnloaded(sender, e);
						this.b = false;
						this.RecNavToolbarPageDVRSFileTbl.SelectVAFileDialog = null;
						global::AcpUI.AcpTextBoxFileBrowser.SelectVAFileDialog = null;
						num = (short)926780175;
						short num3 = num;
						num = (short)1718979343;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_E7;
						}
					}
					IL_E7:
					num = (short)663158784;
					if (num != 0)
					{
					}
					num = (short)2009858048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (this.b)
					{
						num = (short)803536897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_116;
				}
				goto IL_42;
			}
			IL_114:
			IL_116:
			num = (short)1485111296;
			short num4 = num;
			return;
			IL_42:
			this.RecNavToolbarPageDVRSFileTbl.DataContext = null;
			this.RecNavToolbarPageDVRSFileTbl.MyDataPresenter = null;
			num = (short)1591476226;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00167404 File Offset: 0x00165604
		internal void OnVoiceAnnouncementListFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)544143545;
			short num2 = num;
			num = (short)516421817;
			switch (num2 == num)
			{
			}
			num = (short)1936982016;
			short num3 = num;
			num = (short)1525219328;
			if (num != 0)
			{
			}
			num = (short)1783037953;
			if (num != 0)
			{
			}
			global::SpecialFeatures.DVRSFiles.List.DVRSFileList a_ = (global::SpecialFeatures.DVRSFiles.List.DVRSFileList)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x001674D8 File Offset: 0x001656D8
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1188369050;
			short num2 = num;
			num = (short)1721373338;
			switch (num2 == num)
			{
			}
			num = (short)1494679552;
			short num3 = num;
			num = (short)119668736;
			if (num != 0)
			{
			}
			num = (short)587530241;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00167588 File Offset: 0x00165788
		private void OnMultiAddClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2139717883;
			short num2 = num;
			num = (short)1132560635;
			switch (num2 == num)
			{
			}
			num = (short)1817968640;
			short num3 = num;
			num = (short)1036713985;
			if (num != 0)
			{
			}
			num = (short)599719936;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00167634 File Offset: 0x00165834
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)735379457;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num2;
			for (;;)
			{
				IL_32:
				switch (num2)
				{
				case 0:
					goto IL_10C;
				case 1:
					for (;;)
					{
						this.a.MoveCurrentToFirst();
						num = (short)1209172517;
						short num3 = num;
						num = (short)1114669605;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_DF;
						}
					}
					IL_DF:
					num = (short)504692736;
					if (num != 0)
					{
					}
					num = (short)1212743680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (this.a.CurrentItem == null)
					{
						num = (short)1048379393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10E;
				}
				goto IL_44;
			}
			IL_10C:
			IL_10E:
			num = (short)277020672;
			short num4 = num;
			global::SpecialFeatures.DVRSFiles.List.DVRSFileList a_ = (global::SpecialFeatures.DVRSFiles.List.DVRSFileList)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_44:
			object myRecordsetDataSource = this.RecNavToolbarPageDVRSFileTbl.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num = (short)1058406402;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00167790 File Offset: 0x00165990
		private void a(global::SpecialFeatures.DVRSFiles.List.DVRSFileList A_0)
		{
			int a_ = 2;
			global::System.Windows.Navigation.NavigationService navigationService;
			short num;
			for (;;)
			{
				this.a.MoveCurrentTo(A_0);
				navigationService = base.NavigationService;
				if (A_0 != null)
				{
					break;
				}
				num = (short)1633432565;
				short num2 = num;
				num = (short)465449973;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6B;
				}
			}
			navigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
			return;
			IL_6B:
			num = (short)2103574529;
			if (num != 0)
			{
			}
			num = (short)1009451008;
			short num3 = num;
			num = (short)1731788800;
			if (num != 0)
			{
			}
			navigationService.Navigate(new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횄﶐햒爵튠颢좦쒨\udbaa슬솮풰\uddb2솴ﶸ蟀ꫂ꧄ꋆ뫈韊觌駎菐胒鏔뻖뗘뻚釜뛞鋠韢매ꏦ뿨맪뻬ꧮ飰鿲郴믶郸裺觼퇾礀戂栄欆", a_), global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00167888 File Offset: 0x00165A88
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 14;
			while (!this.c)
			{
				short num = (short)1007734890;
				short num2 = num;
				num = (short)919720042;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1458634753;
					if (num != 0)
					{
					}
					num = (short)1711800320;
					short num3 = num;
					num = (short)1305739264;
					if (num != 0)
					{
					}
					this.c = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺐삒滛ﲜ욢쒤펦\udca8\ud9aa좬\udcae誰킲\udab4\udab6즸풺펼\udabe꿀럂ꏆ뿈맊뻌꧎룐뿒냔ꓖ뿚ꯜ귞鋠藢賤详賨蟪蓬鳮藰\udcf2釴臶诸裺鯼雾洀昂椄渆稈缊礌洎紐㴒洔瘖琘眚", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0016796C File Offset: 0x00165B6C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)457113602;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14C;
				case 1:
				{
					num = (short)1319865883;
					short num3 = num;
					num = (short)1980730907;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1410072576;
						if (num != 0)
						{
						}
						num = (short)27197440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
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
				switch (connectionId)
				{
				case 1:
					goto IL_15B;
				case 2:
					goto IL_73;
				case 3:
					goto IL_18C;
				case 4:
					goto IL_66;
				case 5:
					goto IL_14E;
				default:
					num = (short)41680897;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_66:
			this.DVRSFileListDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_73:
			num = (short)965017600;
			short num4 = num;
			num = (short)1478754305;
			if (num != 0)
			{
			}
			this.RecNavToolbarPageDVRSFileTbl = (global::AcpUI.AcpVoiceAnnRecNavToolBar)target;
			this.RecNavToolbarPageDVRSFileTbl.ModeClick += this.OnModeClick;
			return;
			IL_14C:
			goto IL_18C;
			IL_14E:
			this.DVRS_FileName_A43736_col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_15B:
			((global::SpecialFeatures.DVRSFiles.List.DVRSFileListPageTbl)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.DVRSFiles.List.DVRSFileListPageTbl)target).Unloaded += this.OnUnloaded;
			return;
			IL_18C:
			this.c = true;
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00167B0C File Offset: 0x00165D0C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)374603778;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F2;
				case 1:
				{
					num = (short)1520173056;
					short num3 = num;
					((global::AcpUI.AcpTextBoxFileBrowser)target).GotFocus += this.OnFieldNameDoubleClick;
					num = (short)1444903826;
					short num4 = num;
					num = (short)50559890;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1961820160;
						if (num != 0)
						{
						}
						num = (short)719519744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				}
				IL_32:
				if (connectionId != 3)
				{
					return;
				}
				num = (short)477757441;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F2:
			num = (short)166330369;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000845 RID: 2117
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04000846 RID: 2118
		private bool b;

		// Token: 0x04000847 RID: 2119
		internal global::AcpUI.AcpVoiceAnnRecNavToolBar RecNavToolbarPageDVRSFileTbl;

		// Token: 0x04000848 RID: 2120
		internal global::AcpUI.AcpXamDataPresenter DVRSFileListDataPresenter;

		// Token: 0x04000849 RID: 2121
		internal global::Infragistics.Windows.DataPresenter.UnboundField DVRS_FileName_A43736_col;

		// Token: 0x0400084A RID: 2122
		private bool c;
	}
}
