using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AcpUILib;
using AllFeatures;
using Infragistics.Windows.DataPresenter;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles
{
	// Token: 0x02000496 RID: 1174
	public class PageConventionalEmergencyProfilesTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06009ABF RID: 39615 RVA: 0x009103EC File Offset: 0x0090E5EC
		public PageConventionalEmergencyProfilesTbl()
		{
			try
			{
				this.InitializeComponent();
				global::AcpUI.Common.Utility.SetDirection(this);
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06009AC0 RID: 39616 RVA: 0x00910424 File Offset: 0x0090E624
		public override void SetDataContext()
		{
			short num;
			for (;;)
			{
				num = (short)1272709122;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_10F;
					case 1:
						goto IL_8B;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 3:
						base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2075);
						num = (short)1890844676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_8B;
					case 5:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)160825344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_205;
					}
					IL_3D:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)2078670849;
						if (num != 0)
						{
						}
						num = (short)592707587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2075);
					num = (short)1661206529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8B:
					this.ConventionalEmergencyProfilesList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
					this.RecNavToolbarPageConventionalEmergencyProfiles.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
					this.RecNavToolbarPageConventionalEmergencyProfiles.MyDataPresenter = this.ConventionalEmergencyProfilesList;
					base.MyBaseRecNavToolbar = this.RecNavToolbarPageConventionalEmergencyProfiles;
					num = (short)220790789;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10F:
				num = (short)1244588034;
				short num3 = num;
				num = (short)1247799298;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_144;
				}
			}
			IL_144:
			num = (short)151191552;
			if (num != 0)
			{
			}
			num = (short)1387724800;
			short num4 = num;
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2075);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageConventionalEmergencyProfiles).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_205:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageConventionalEmergencyProfiles).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06009AC1 RID: 39617 RVA: 0x00910644 File Offset: 0x0090E844
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1787691008;
			short num2 = num;
			num = (short)1382809600;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					object myRecordsetDataSource = this.RecNavToolbarPageConventionalEmergencyProfiles.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)227758317;
					short num4 = num;
					num = (short)2073972973;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)757465088;
						if (num != 0)
						{
						}
						num = (short)548798465;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_59:
				num = (short)1781006337;
				if (num != 0)
				{
				}
				if (this.b)
				{
					break;
				}
				num = (short)1713111042;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06009AC2 RID: 39618 RVA: 0x00910784 File Offset: 0x0090E984
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
					num2 = (short)1331757057;
					if (num2 != 0)
					{
					}
					if (this.b)
					{
						num2 = (short)299827202;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E4;
				case 1:
				{
					num2 = (short)885325824;
					short num3 = num2;
					goto IL_E4;
				}
				case 2:
					base.OnUnloaded(sender, e);
					this.b = false;
					goto IL_A2;
				}
				goto IL_1C;
				IL_A2:
				num2 = (short)488046593;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_E4:
				num2 = (short)1286731291;
				short num4 = num2;
				num2 = (short)779154971;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A2;
				default:
					goto IL_118;
				}
			}
			IL_118:
			num2 = (short)2034630656;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			this.RecNavToolbarPageConventionalEmergencyProfiles.DataContext = null;
			this.RecNavToolbarPageConventionalEmergencyProfiles.MyDataPresenter = null;
			num2 = (short)1398603776;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06009AC3 RID: 39619 RVA: 0x009108C0 File Offset: 0x0090EAC0
		internal void OnConventionalEmergencyProfilesFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1514875523;
			short num2 = num;
			num = (short)957098627;
			switch (num2 == num)
			{
			default:
			{
				num = (short)147849216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1466368000;
			if (num != 0)
			{
			}
			num = (short)2137260033;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles a_ = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06009AC4 RID: 39620 RVA: 0x00910994 File Offset: 0x0090EB94
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1014227711;
			short num2 = num;
			num = (short)2064442111;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1865416704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1983447041;
			if (num != 0)
			{
			}
			num = (short)1507131392;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06009AC5 RID: 39621 RVA: 0x00910A44 File Offset: 0x0090EC44
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
					if (this.a.CurrentItem == null)
					{
						num2 = (short)1769603074;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_98;
				case 1:
					goto IL_98;
				case 2:
					this.a.MoveCurrentToFirst();
					goto IL_7E;
				}
				goto IL_1C;
				IL_7E:
				num2 = (short)731709441;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_98:
				num2 = (short)1485897728;
				short num3 = num2;
				num2 = (short)1987837953;
				if (num2 != 0)
				{
				}
				num2 = (short)1516767401;
				short num4 = num2;
				num2 = (short)939198633;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_7E;
				default:
					goto IL_11E;
				}
			}
			IL_11E:
			num2 = (short)1181024256;
			if (num2 != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles a_ = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_1C:
			object myRecordsetDataSource = this.RecNavToolbarPageConventionalEmergencyProfiles.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num2 = (short)1303773184;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06009AC6 RID: 39622 RVA: 0x00910B9C File Offset: 0x0090ED9C
		private void a(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles A_0)
		{
			short num = (short)1834782597;
			short num2 = num;
			num = (short)1377472389;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1580859392;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)948568065;
			if (num != 0)
			{
			}
			num = (short)1158217728;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06009AC7 RID: 39623 RVA: 0x00910C6C File Offset: 0x0090EE6C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 1;
			while (this.c)
			{
				short num = (short)705503317;
				short num2 = num;
				num = (short)1048059989;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)583204864;
					if (num != 0)
					{
					}
					num = (short)1121452033;
					if (num != 0)
					{
					}
					num = (short)1870594048;
					short num3 = num;
					return;
				}
				}
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("藃꫅꓇賉꧋꿍꓏ꟑꛓ돕ꯗ뿛뇝跟鋡诣裥跧蓩飫쇭闯鿱釳蓵鿷鿹鋻鷽秿✁㘃㘅欇攉戋栍礏甑愓搕礗渙甛焝丟ഡ䜣䤥䘧尩䤫䀭䐯嬱嬳堵夷嘹᤻ఽ瀿❁⥃⍅㩇ⵉ⥋⁍㍏⭑煓摕桗⩙⹛ㅝٟୡࡣͥ᭧䕩ཫŭṯѱᅳᡵ౷፹፻ၽﺏ瀞첟잡힣튥쪧용芫횭톯\udfb1\ud8b3", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06009AC8 RID: 39624 RVA: 0x00910D50 File Offset: 0x0090EF50
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2069037059;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_83;
				case 1:
					num = (short)1165885442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (connectionId != 29)
					{
						num = (short)651755520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_144;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 4:
					num = (short)1064042501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					if (connectionId == 2)
					{
						goto IL_5F;
					}
					num = (short)626972068;
					short num3 = num;
					num = (short)1338037668;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_83;
					default:
						num = (short)1774977025;
						if (num != 0)
						{
						}
						num = (short)1934622720;
						if (num != 0)
						{
						}
						num = (short)1203437569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					goto IL_97;
				}
				IL_41:
				if (connectionId != 1)
				{
					num = (short)1380450308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_18A;
				IL_83:
				num = (short)2033319942;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5F:
			this.RecNavToolbarPageConventionalEmergencyProfiles = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageConventionalEmergencyProfiles.ModeClick += this.OnModeClick;
			return;
			IL_97:
			this.c = true;
			return;
			IL_144:
			this.ConventionalEmergencyProfilesList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_18A:
			num = (short)1278476288;
			short num4 = num;
			((global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.PageConventionalEmergencyProfilesTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.PageConventionalEmergencyProfilesTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x06009AC9 RID: 39625 RVA: 0x00910F4C File Offset: 0x0090F14C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
			{
				short num = (short)1858011136;
				short num2 = num;
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 11:
			{
				short num = (short)1626472449;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 12:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
			{
				short num = (short)381612988;
				short num3 = num;
				num = (short)1684337596;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1029111808;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 14:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				break;
			case 18:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 23:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 24:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 25:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 26:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 27:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 28:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04004CC5 RID: 19653
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04004CC6 RID: 19654
		private bool b;

		// Token: 0x04004CC7 RID: 19655
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageConventionalEmergencyProfiles;

		// Token: 0x04004CC8 RID: 19656
		internal global::AcpUI.AcpXamDataPresenter ConventionalEmergencyProfilesList;

		// Token: 0x04004CC9 RID: 19657
		private bool c;
	}
}
