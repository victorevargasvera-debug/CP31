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

namespace Motorola.MackinawCPS.CoreFeatures.DVRSProfiles
{
	// Token: 0x020004B6 RID: 1206
	public class PageDVRSProfilesTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06009E62 RID: 40546 RVA: 0x0093E544 File Offset: 0x0093C744
		public PageDVRSProfilesTbl()
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

		// Token: 0x06009E63 RID: 40547 RVA: 0x0093E57C File Offset: 0x0093C77C
		public override void SetDataContext()
		{
			short num = (short)1738604547;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)893583361;
				if (num != 0)
				{
				}
				num = (short)346161152;
				short num3 = num;
				switch (num2)
				{
				case 0:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4143);
					num = (short)1655832581;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_138;
				case 2:
					goto IL_B4;
				case 3:
					goto IL_14;
				case 4:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1264386049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20A;
				case 5:
					goto IL_B4;
				}
				goto IL_8D;
				IL_14:
				switch (0)
				{
				case 0:
					IL_8D:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)73990144;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)169662003;
						short num4 = num;
						num = (short)1676793395;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
							num = (short)794230784;
							if (num != 0)
							{
							}
							base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4143);
							num = (short)912982018;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					break;
				}
				continue;
				IL_B4:
				this.DVRSProfilesList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageDVRSProfiles.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageDVRSProfiles.MyDataPresenter = this.DVRSProfilesList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageDVRSProfiles;
				num = (short)1285160964;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_138:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4143);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageDVRSProfiles).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_20A:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageDVRSProfiles).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06009E64 RID: 40548 RVA: 0x0093E7A0 File Offset: 0x0093C9A0
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			for (;;)
			{
				num = (short)1363935232;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 1:
					{
						num = (short)1715601408;
						short num3 = num;
						object myRecordsetDataSource = this.RecNavToolbarPageDVRSProfiles.MyRecordsetDataSource;
						this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						base.OnLoaded(sender, e);
						this.b = true;
						num = (short)1864105985;
						if (num != 0)
						{
						}
						num = (short)1083637762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_E6;
					}
					IL_31:
					if (this.b)
					{
						break;
					}
					num = (short)581369857;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E8:
				num = (short)55475712;
				short num4 = num;
				num = (short)95780352;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_11D;
				}
				IL_E6:
				goto IL_E8;
			}
			IL_11D:
			num = (short)1169424384;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009E65 RID: 40549 RVA: 0x0093E8E0 File Offset: 0x0093CAE0
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)394133504;
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
						num = (short)768933889;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_106;
				case 2:
					return;
				}
				goto IL_45;
			}
			return;
			IL_45:
			num = (short)1848919508;
			short num4 = num;
			num = (short)1886012884;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_106:
				base.OnUnloaded(sender, e);
				this.b = false;
				num = (short)628555778;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			default:
			{
				num = (short)1844445185;
				if (num != 0)
				{
				}
				num = (short)23396352;
				if (num != 0)
				{
				}
				this.RecNavToolbarPageDVRSProfiles.DataContext = null;
				this.RecNavToolbarPageDVRSProfiles.MyDataPresenter = null;
				num = (short)177995776;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			}
		}

		// Token: 0x06009E66 RID: 40550 RVA: 0x0093EA20 File Offset: 0x0093CC20
		internal void OnDVRSProfilesFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)899874817;
			if (num != 0)
			{
			}
			num = (short)1095106997;
			short num2 = num;
			num = (short)630522293;
			switch (num2 == num)
			{
			}
			num = (short)934281216;
			short num3 = num;
			num = (short)1910767616;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles a_ = (global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06009E67 RID: 40551 RVA: 0x0093EAF8 File Offset: 0x0093CCF8
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)276964167;
			short num2 = num;
			num = (short)814162759;
			switch (num2 == num)
			{
			}
			num = (short)333316097;
			if (num != 0)
			{
			}
			num = (short)19202048;
			short num3 = num;
			num = (short)1973813248;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06009E68 RID: 40552 RVA: 0x0093EBA8 File Offset: 0x0093CDA8
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1627258880;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_47;
			}
			for (;;)
			{
				IL_35:
				int num3;
				switch (num3)
				{
				case 0:
					if (this.a.CurrentItem == null)
					{
						num = (short)292487169;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13F;
				case 1:
					goto IL_116;
				case 2:
					goto IL_13D;
				}
				goto IL_47;
			}
			IL_13D:
			IL_13F:
			global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles a_ = (global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_47:
			num = (short)1970775388;
			short num4 = num;
			num = (short)84125020;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_116:
				this.a.MoveCurrentToFirst();
				num = (short)888602626;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_35;
			}
			default:
			{
				num = (short)835125249;
				if (num != 0)
				{
				}
				num = (short)1252130816;
				if (num != 0)
				{
				}
				object myRecordsetDataSource = this.RecNavToolbarPageDVRSProfiles.MyRecordsetDataSource;
				this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				num = (short)1691090944;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_35;
			}
			}
		}

		// Token: 0x06009E69 RID: 40553 RVA: 0x0093ED0C File Offset: 0x0093CF0C
		private void a(global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles A_0)
		{
			short num = (short)849150345;
			short num2 = num;
			num = (short)30409097;
			switch (num2 == num)
			{
			}
			num = (short)1692598273;
			if (num != 0)
			{
			}
			num = (short)33816576;
			short num3 = num;
			num = (short)1744830464;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06009E6A RID: 40554 RVA: 0x0093EDDC File Offset: 0x0093CFDC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 4;
			short num;
			while (this.c)
			{
				num = (short)1967436431;
				short num2 = num;
				num = (short)757641871;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1479147520;
					short num3 = num;
					num = (short)8650752;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			num = (short)971767809;
			if (num != 0)
			{
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("蛆ꗈꟊ诌꫎냐꟒ꃔꗖ볘꣚볞軠転闤裦蟨軪菬鯮\udef0韲菴藶諸\udefa쿼쿾戀氂欄愆怈氊砌紎瀐朒簔砖眘㐚礜椞匠倢$ᔦᤨ嬪弬䀮地娲头制䨸ᐺ夼䤾㍀あ㕄㕆♈ⵊ⑌⍎㑐⁒⅔㕖㕘畚╜㹞ౠར", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06009E6B RID: 40555 RVA: 0x0093EEBC File Offset: 0x0093D0BC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)825491460;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_119;
				case 1:
					num = (short)735641603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)2128347141;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_E1;
				case 4:
				{
					num = (short)716686193;
					short num3 = num;
					num = (short)987612017;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_119;
					default:
						num = (short)339935232;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_8B;
						}
						continue;
					}
					break;
				}
				case 5:
					if (connectionId != 2)
					{
						num = (short)113770496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A8;
				case 6:
					if (connectionId != 16)
					{
						num = (short)1676410881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_144;
				}
				IL_8B:
				if (connectionId != 1)
				{
					num = (short)1272512514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1B2;
				IL_119:
				num = (short)647036928;
				short num4 = num;
				num = (short)1510670342;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A8:
			this.RecNavToolbarPageDVRSProfiles = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageDVRSProfiles.ModeClick += this.OnModeClick;
			return;
			IL_E1:
			this.c = true;
			return;
			IL_144:
			num = (short)310640641;
			if (num != 0)
			{
			}
			this.DVRSProfilesList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1B2:
			((global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.PageDVRSProfilesTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.PageDVRSProfilesTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x06009E6C RID: 40556 RVA: 0x0093F0B4 File Offset: 0x0093D2B4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1520742045;
			short num2 = num;
			num = (short)576958109;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B5;
			case 1:
				break;
			default:
			{
				num = (short)623312896;
				short num3 = num;
				break;
			}
			}
			num = (short)33095680;
			if (num != 0)
			{
			}
			switch (connectionId)
			{
			case 3:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				num = (short)775880705;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				IL_B5:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
		}

		// Token: 0x04004DB8 RID: 19896
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04004DB9 RID: 19897
		private bool b;

		// Token: 0x04004DBA RID: 19898
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageDVRSProfiles;

		// Token: 0x04004DBB RID: 19899
		internal global::AcpUI.AcpXamDataPresenter DVRSProfilesList;

		// Token: 0x04004DBC RID: 19900
		private bool c;
	}
}
