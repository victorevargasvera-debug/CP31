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

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x020004F7 RID: 1271
	public class PageDataProfilesTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600AA8B RID: 43659 RVA: 0x009F0E70 File Offset: 0x009EF070
		public PageDataProfilesTbl()
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

		// Token: 0x0600AA8C RID: 43660 RVA: 0x009F0EA8 File Offset: 0x009EF0A8
		public override void SetDataContext()
		{
			short num = (short)2018705408;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 1:
				{
					num = (short)492699648;
					short num3 = num;
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1109065730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_203;
				}
				case 2:
					goto IL_132;
				case 3:
					goto IL_87;
				case 4:
				{
					num = (short)1581580289;
					if (num != 0)
					{
					}
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2054);
					num = (short)689208979;
					short num4 = num;
					num = (short)178880147;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D0;
					default:
						num = (short)650969088;
						if (num != 0)
						{
						}
						num = (short)844103683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					goto IL_87;
				}
				IL_3C:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)872546308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2054);
				num = (short)1336999941;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D0:
				num = (short)1602355201;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_87:
				this.DataProfilesList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageDataProfiles.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageDataProfiles.MyDataPresenter = this.DataProfilesList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageDataProfiles;
				goto IL_D0;
			}
			IL_132:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2054);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageDataProfiles).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_203:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageDataProfiles).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x0600AA8D RID: 43661 RVA: 0x009F10C4 File Offset: 0x009EF2C4
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			for (;;)
			{
				num = (short)2059927553;
				if (num != 0)
				{
				}
				num = (short)1364590593;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						object myRecordsetDataSource = this.RecNavToolbarPageDataProfiles.MyRecordsetDataSource;
						this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						base.OnLoaded(sender, e);
						this.b = true;
						num = (short)630128642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 2:
						goto IL_E6;
					}
					IL_59:
					if (this.b)
					{
						return;
					}
					num = (short)1756626944;
					short num3 = num;
					num = (short)1633812480;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E6:
				num = (short)907381661;
				short num4 = num;
				num = (short)724208541;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_11A;
				}
			}
			IL_11A:
			num = (short)105185280;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AA8E RID: 43662 RVA: 0x009F1204 File Offset: 0x009EF404
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						base.OnUnloaded(sender, e);
						this.b = false;
						num2 = (short)2046492674;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						if (this.b)
						{
							num2 = (short)1047855104;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_E9;
					case 2:
						goto IL_E7;
					}
					goto IL_1C;
				}
				IL_E9:
				num2 = (short)528363138;
				short num3 = num2;
				num2 = (short)1669082754;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_11E;
				}
				IL_E7:
				goto IL_E9;
				IL_1C:
				this.RecNavToolbarPageDataProfiles.DataContext = null;
				this.RecNavToolbarPageDataProfiles.MyDataPresenter = null;
				num2 = (short)802684928;
				short num4 = num2;
				num2 = (short)333053953;
				if (num2 != 0)
				{
				}
				num2 = (short)907411457;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_11E:
			num2 = (short)1792344064;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x0600AA8F RID: 43663 RVA: 0x009F1348 File Offset: 0x009EF548
		internal void OnDataProfilesFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)879655181;
			short num2 = num;
			num = (short)1287289101;
			switch (num2 == num)
			{
			}
			num = (short)1896153088;
			short num3 = num;
			num = (short)1777401856;
			if (num != 0)
			{
			}
			num = (short)232259585;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles a_ = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x0600AA90 RID: 43664 RVA: 0x009F141C File Offset: 0x009EF61C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)448167476;
			short num2 = num;
			num = (short)1777040948;
			switch (num2 == num)
			{
			}
			num = (short)263061504;
			short num3 = num;
			num = (short)395902977;
			if (num != 0)
			{
			}
			num = (short)1998979072;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600AA91 RID: 43665 RVA: 0x009F14CC File Offset: 0x009EF6CC
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						this.a.MoveCurrentToFirst();
						num2 = (short)298647554;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						if (this.a.CurrentItem == null)
						{
							num2 = (short)1411121152;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_C8;
					case 2:
						goto IL_C6;
					}
					goto IL_1C;
				}
				IL_C8:
				num2 = (short)670583070;
				short num3 = num2;
				num2 = (short)1485195550;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_100;
				}
				IL_C6:
				goto IL_C8;
				IL_1C:
				object myRecordsetDataSource = this.RecNavToolbarPageDataProfiles.MyRecordsetDataSource;
				this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				num2 = (short)1410793472;
				short num4 = num2;
				num2 = (short)1734672385;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_100:
			num2 = (short)1336737793;
			if (num2 != 0)
			{
			}
			num2 = (short)2052653056;
			if (num2 != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles a_ = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)this.a.CurrentItem;
			this.a(a_);
		}

		// Token: 0x0600AA92 RID: 43666 RVA: 0x009F162C File Offset: 0x009EF82C
		private void a(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles A_0)
		{
			short num = (short)2133734911;
			short num2 = num;
			num = (short)758855167;
			switch (num2 == num)
			{
			}
			num = (short)609943552;
			short num3 = num;
			num = (short)118226945;
			if (num != 0)
			{
			}
			num = (short)779943936;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x0600AA93 RID: 43667 RVA: 0x009F16FC File Offset: 0x009EF8FC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 14;
			short num = (short)69664768;
			short num2 = num;
			if (this.c)
			{
				num = (short)2056393137;
				short num3 = num;
				num = (short)199430577;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)310968320;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)760479745;
			if (num != 0)
			{
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("郐뿒맔釖볘뫚꧜꫞鏠蛢雤\udce6諨蓪胬鿮黰鷲郴駶跸퓺駼黾甀戂\u2004㔆㤈栊戌愎眐稒爔或欘稚検瘞丠䴢ਤ䌦䠨弪䰬ਮ̰̲䔴䔶嘸崺吼匾⑀あ橄⍆⡈㽊ⱌ㽎⍐㱒㍔㹖㕘㹚⹜⭞͠ར䭤ὦࡨ٪Ŭ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600AA94 RID: 43668 RVA: 0x009F17DC File Offset: 0x009EF9DC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1712717824;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 1:
					if (connectionId != 2)
					{
						num = (short)931397638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AD;
				case 2:
					goto IL_112;
				case 3:
				{
					num = (short)686882816;
					short num3 = num;
					num = (short)1152712706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (connectionId != 72)
					{
						goto IL_178;
					}
					goto IL_14F;
				case 5:
					num = (short)807862273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1839398916;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_41:
				num = (short)853212936;
				short num4 = num;
				num = (short)2066022152;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_178:
					num = (short)892141571;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1801781248;
					if (num != 0)
					{
					}
					if (connectionId == 1)
					{
						goto IL_195;
					}
					num = (short)1769078789;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_AD:
			this.RecNavToolbarPageDataProfiles = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageDataProfiles.ModeClick += this.OnModeClick;
			return;
			IL_112:
			num = (short)372113409;
			if (num != 0)
			{
			}
			this.c = true;
			return;
			IL_14F:
			this.DataProfilesList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_195:
			((global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.PageDataProfilesTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.PageDataProfilesTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x0600AA95 RID: 43669 RVA: 0x009F19E0 File Offset: 0x009EFBE0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
			{
				short num = (short)1299823422;
				short num2 = num;
				num = (short)1566358334;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1815543809;
					if (num != 0)
					{
					}
					num = (short)106758144;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 5:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
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
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
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
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 25:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 26:
			{
				short num = (short)732233728;
				short num3 = num;
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 27:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 28:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 29:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 30:
				break;
			case 31:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 32:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 33:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 34:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 35:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 36:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 37:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 38:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 39:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 40:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 41:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 42:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 43:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 44:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 45:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 46:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 47:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 48:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 49:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 50:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 51:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 52:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 53:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 54:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 55:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 56:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 57:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 58:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 59:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 60:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 61:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 62:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 63:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 64:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 65:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 66:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 67:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 68:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 69:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 70:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 71:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x0400535D RID: 21341
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x0400535E RID: 21342
		private bool b;

		// Token: 0x0400535F RID: 21343
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageDataProfiles;

		// Token: 0x04005360 RID: 21344
		internal global::AcpUI.AcpXamDataPresenter DataProfilesList;

		// Token: 0x04005361 RID: 21345
		private bool c;
	}
}
