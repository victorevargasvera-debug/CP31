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

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000D3 RID: 211
	public class PageTrunkingPersonalityTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06001E44 RID: 7748 RVA: 0x001E1BB4 File Offset: 0x001DFDB4
		public PageTrunkingPersonalityTbl()
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

		// Token: 0x06001E45 RID: 7749 RVA: 0x001E1BEC File Offset: 0x001DFDEC
		public override void SetDataContext()
		{
			short num = (short)1008861187;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2072);
					num = (short)1539309572;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_60;
				case 2:
				{
					num = (short)2114772645;
					short num3 = num;
					num = (short)235200165;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1927610368;
						if (num != 0)
						{
						}
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)1183842309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D9;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
					goto IL_60;
				case 5:
					goto IL_12D;
				}
				IL_3C:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)2124218368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2072);
				num = (short)38862849;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_60:
				this.TrunkingPersonalityList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageTrunkingPersonality.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageTrunkingPersonality.MyDataPresenter = this.TrunkingPersonalityList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageTrunkingPersonality;
				num = (short)1960837122;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_12D:
			num = (short)700514304;
			short num4 = num;
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2072);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageTrunkingPersonality).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_1D9:
			num = (short)1658912769;
			if (num != 0)
			{
			}
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageTrunkingPersonality).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x001E1E08 File Offset: 0x001E0008
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)567934977;
			if (num != 0)
			{
			}
			num = (short)558759937;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B9;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				case 2:
				{
					object myRecordsetDataSource = this.RecNavToolbarPageTrunkingPersonality.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)622854144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_57:
				if (this.b)
				{
					return;
				}
				num = (short)1786511362;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B9:
			num = (short)2129594055;
			short num3 = num;
			num = (short)1648821959;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)978518016;
				if (num != 0)
				{
				}
				num = (short)1878392832;
				short num4 = num;
				break;
			}
			}
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x001E1F48 File Offset: 0x001E0148
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
					goto IL_100;
				case 1:
					if (this.b)
					{
						num2 = (short)1309474818;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)1758724097;
					if (num2 != 0)
					{
					}
					base.OnUnloaded(sender, e);
					this.b = false;
					num2 = (short)1593665516;
					short num3 = num2;
					num2 = (short)647522284;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_100;
					default:
						num2 = (short)1343684608;
						if (num2 != 0)
						{
						}
						num2 = (short)2095054848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			IL_100:
			num2 = (short)383320064;
			short num4 = num2;
			return;
			IL_1C:
			this.RecNavToolbarPageTrunkingPersonality.DataContext = null;
			this.RecNavToolbarPageTrunkingPersonality.MyDataPresenter = null;
			num2 = (short)1976238081;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x001E2084 File Offset: 0x001E0284
		internal void OnTrunkingPersonalityFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1224409089;
			if (num != 0)
			{
			}
			num = (short)875948396;
			short num2 = num;
			num = (short)942795116;
			switch (num2 == num)
			{
			}
			num = (short)765657088;
			short num3 = num;
			num = (short)638844928;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality a_ = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x001E2158 File Offset: 0x001E0358
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)523632641;
			if (num != 0)
			{
			}
			num = (short)1276208549;
			short num2 = num;
			num = (short)1858037157;
			switch (num2 == num)
			{
			}
			num = (short)386727936;
			short num3 = num;
			num = (short)529137664;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x001E2208 File Offset: 0x001E0408
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
					goto IL_10A;
				case 1:
					if (this.a.CurrentItem == null)
					{
						num2 = (short)1830223874;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_138;
				case 2:
				{
					this.a.MoveCurrentToFirst();
					num2 = (short)89784321;
					if (num2 != 0)
					{
					}
					num2 = (short)709797777;
					short num3 = num2;
					num2 = (short)522299281;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10A;
					default:
						num2 = (short)349962240;
						if (num2 != 0)
						{
						}
						num2 = (short)1145700352;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			IL_10A:
			num2 = (short)2050949120;
			short num4 = num2;
			IL_138:
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality a_ = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_1C:
			object myRecordsetDataSource = this.RecNavToolbarPageTrunkingPersonality.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num2 = (short)735182849;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x001E2368 File Offset: 0x001E0568
		private void a(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality A_0)
		{
			short num = (short)1766081226;
			short num2 = num;
			num = (short)1677279946;
			switch (num2 == num)
			{
			}
			num = (short)1321992193;
			if (num != 0)
			{
			}
			num = (short)499646464;
			short num3 = num;
			num = (short)1497563136;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x001E2438 File Offset: 0x001E0638
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 5;
			if (this.c)
			{
				short num = (short)1115881473;
				if (num != 0)
				{
				}
				num = (short)1671344754;
				short num2 = num;
				num = (short)2009772658;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)694222848;
					if (num != 0)
					{
					}
					num = (short)1265303552;
					short num3 = num;
					return;
				}
				}
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("觇ꛉꃋ裍뗏돑ꃓꏕ꫗뿙꿛菟跡解雥蟧蓩觫胭蓯\uddf1胳蓵跷铹韻韽滿攁℃㐅㠇椉挋怍瘏笑猓挕樗笙栛眝伟䰡ଣ別娧弩䈫䔭夯就匳ጵ਷ਹ䰻嬽㈿ㅁ⭃⡅⥇♉╋㩍⥏絑⁓⑕ⵗ㑙㝛㝝๟աᑣͥᩧᥩͫmᅯṱᵳɵŷ๹ṻች깿嬨", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x001E251C File Offset: 0x001E071C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)745209861;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (connectionId != 69)
					{
						num = (short)528285700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16E;
				case 1:
					num = (short)1404829699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1610547200;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (connectionId != 2)
					{
						num = (short)977207298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F9;
				case 4:
					num = (short)861405190;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 6:
					goto IL_134;
				}
				IL_40:
				if (connectionId == 1)
				{
					goto IL_1B5;
				}
				num = (short)134730896;
				short num3 = num;
				num = (short)158192784;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1B5;
				case 1:
					break;
				default:
				{
					num = (short)339804160;
					short num4 = num;
					break;
				}
				}
				num = (short)2077687809;
				if (num != 0)
				{
				}
				num = (short)247595008;
				if (num != 0)
				{
				}
				num = (short)952238081;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F9:
			this.RecNavToolbarPageTrunkingPersonality = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageTrunkingPersonality.ModeClick += this.OnModeClick;
			return;
			IL_134:
			this.c = true;
			return;
			IL_16E:
			this.TrunkingPersonalityList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1B5:
			((global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PageTrunkingPersonalityTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PageTrunkingPersonalityTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x001E2718 File Offset: 0x001E0918
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
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
				break;
			case 6:
				((global::AcpUI.AcpTableTextBoxDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableTextBoxDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 23:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 24:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 25:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 26:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 27:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 28:
				((global::AcpUI.AcpTableTextBoxCustomDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 29:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 30:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 31:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 32:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 33:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 34:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 35:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 36:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 37:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 38:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 39:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 40:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 41:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 42:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 43:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 44:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 45:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 46:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 47:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 48:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 49:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 50:
			{
				short num = (short)1529937921;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 51:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 52:
			{
				short num = (short)672333824;
				short num2 = num;
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 53:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 54:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 55:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 56:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 57:
			{
				short num = (short)327932116;
				short num3 = num;
				num = (short)1274468564;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)734658560;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 58:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 59:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 60:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 61:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 62:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 63:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 64:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
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
			default:
				return;
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000B77 RID: 2935
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04000B78 RID: 2936
		private bool b;

		// Token: 0x04000B79 RID: 2937
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageTrunkingPersonality;

		// Token: 0x04000B7A RID: 2938
		internal global::AcpUI.AcpXamDataPresenter TrunkingPersonalityList;

		// Token: 0x04000B7B RID: 2939
		private bool c;
	}
}
