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

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x0200057E RID: 1406
	public class PageConventionalPersonalityTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600C22A RID: 49706 RVA: 0x00B5F064 File Offset: 0x00B5D264
		public PageConventionalPersonalityTbl()
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

		// Token: 0x0600C22B RID: 49707 RVA: 0x00B5F09C File Offset: 0x00B5D29C
		public override void SetDataContext()
		{
			short num = (short)21757955;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1784348673;
						if (num != 0)
						{
						}
						num = (short)885260293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_205;
				case 1:
					goto IL_1DE;
				case 2:
				{
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2059);
					num = (short)1723230449;
					short num3 = num;
					num = (short)1783392497;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1DE;
					default:
						num = (short)640811008;
						if (num != 0)
						{
						}
						num = (short)1288437761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
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
					goto IL_88;
				case 5:
					goto IL_133;
				}
				IL_3C:
				num = (short)707723264;
				short num4 = num;
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1899692034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2059);
				num = (short)132579332;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_88:
				this.ConventionalPersonalityList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageConventionalPersonality.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageConventionalPersonality.MyDataPresenter = this.ConventionalPersonalityList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageConventionalPersonality;
				num = (short)524156928;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1DE:
				goto IL_88;
			}
			IL_133:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2059);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageConventionalPersonality).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_205:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageConventionalPersonality).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x0600C22C RID: 49708 RVA: 0x00B5F2BC File Offset: 0x00B5D4BC
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)890896384;
			short num2 = num;
			num = (short)406721845;
			short num3 = num;
			num = (short)475600181;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D5:
				num = (short)186580994;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1677000704;
				if (num != 0)
				{
				}
				num = (short)1567490048;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A4;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					object myRecordsetDataSource = this.RecNavToolbarPageConventionalPersonality.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)730136577;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				break;
			}
			IL_A4:
			num = (short)1032323073;
			if (num != 0)
			{
			}
			if (!this.b)
			{
				goto IL_D5;
			}
		}

		// Token: 0x0600C22D RID: 49709 RVA: 0x00B5F3FC File Offset: 0x00B5D5FC
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1130610367;
			short num2 = num;
			num = (short)48217791;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1310588929;
				if (num != 0)
				{
				}
				num = (short)929103872;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8C;
				}
				break;
			}
			int num3;
			for (;;)
			{
				IL_7A:
				switch (num3)
				{
				case 0:
					if (this.b)
					{
						num = (short)2137718786;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
				{
					num = (short)478740480;
					short num4 = num;
					base.OnUnloaded(sender, e);
					this.b = false;
					num = (short)1451163649;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_8C;
			}
			return;
			IL_8C:
			this.RecNavToolbarPageConventionalPersonality.DataContext = null;
			this.RecNavToolbarPageConventionalPersonality.MyDataPresenter = null;
			num = (short)166461440;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7A;
		}

		// Token: 0x0600C22E RID: 49710 RVA: 0x00B5F534 File Offset: 0x00B5D734
		internal void OnConventionalPersonalityFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)434279442;
			short num2 = num;
			num = (short)1478464530;
			switch (num2 == num)
			{
			default:
			{
				num = (short)902823936;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)889520129;
			if (num != 0)
			{
			}
			num = (short)161218560;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality a_ = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x0600C22F RID: 49711 RVA: 0x00B5F60C File Offset: 0x00B5D80C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)735191035;
			short num2 = num;
			num = (short)1382424571;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1553793024;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)879558657;
			if (num != 0)
			{
			}
			num = (short)1077346304;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600C230 RID: 49712 RVA: 0x00B5F6B8 File Offset: 0x00B5D8B8
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)43606403;
			short num2 = num;
			num = (short)1386701187;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1486422016;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8D;
				}
				break;
			}
			int num3;
			for (;;)
			{
				IL_53:
				num = (short)1305280513;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					if (this.a.CurrentItem == null)
					{
						num = (short)1150746626;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_134;
				case 1:
					goto IL_132;
				case 2:
				{
					num = (short)1515061248;
					short num4 = num;
					this.a.MoveCurrentToFirst();
					num = (short)1021313025;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_8D;
			}
			IL_132:
			IL_134:
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality a_ = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_8D:
			object myRecordsetDataSource = this.RecNavToolbarPageConventionalPersonality.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num = (short)142802944;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_53;
		}

		// Token: 0x0600C231 RID: 49713 RVA: 0x00B5F814 File Offset: 0x00B5DA14
		private void a(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality A_0)
		{
			short num = (short)654315730;
			short num2 = num;
			num = (short)2066682066;
			switch (num2 == num)
			{
			default:
			{
				num = (short)97386496;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)3997697;
			if (num != 0)
			{
			}
			num = (short)1630994432;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x0600C232 RID: 49714 RVA: 0x00B5F8E0 File Offset: 0x00B5DAE0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 11;
			while (this.c)
			{
				short num = (short)1540043477;
				short num2 = num;
				num = (short)346632917;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)288227328;
					short num3 = num;
					num = (short)1751056384;
					if (num != 0)
					{
					}
					num = (short)261292033;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("迍볏뻑鋓돕맗껙꧛곝藟釡\udfe3藥蟧蟩鳫臭黯韱髳苵ퟷ駹鏻都盿朁樃爅愇攉戋漍簏㜑☓☕笗甙爛砝䤟䔡儣吥䤧帩䔫䄭帯ᴱ圳夵嘷䰹夻倽㐿⭁⭃⡅⥇♉楋籍恏≑ㅓ⑕⭗㕙㉛㽝౟ୡၣὥ䝧३ͫmٯ᝱ᩳɵᅷᕹቻώﮇﲏﮑ낝\ud89f쎡즣쪥", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600C233 RID: 49715 RVA: 0x00B5F9C0 File Offset: 0x00B5DBC0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1225195520;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 1:
					goto IL_EE;
				case 2:
					num = (short)1628635137;
					if (num != 0)
					{
					}
					num = (short)137297921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)2028601349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)931725318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					if (connectionId != 130)
					{
						num = (short)216989698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1874577192;
					short num3 = num;
					num = (short)1015269160;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_15F;
					}
					break;
				}
				case 6:
					if (connectionId != 2)
					{
						num = (short)1746468867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_89;
				}
				IL_40:
				if (connectionId == 1)
				{
					goto IL_1BE;
				}
				num = (short)1998979072;
				short num4 = num;
				num = (short)922025988;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_89:
			this.RecNavToolbarPageConventionalPersonality = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageConventionalPersonality.ModeClick += this.OnModeClick;
			return;
			IL_EE:
			this.c = true;
			return;
			IL_15F:
			num = (short)188219392;
			if (num != 0)
			{
			}
			this.ConventionalPersonalityList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1BE:
			((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.PageConventionalPersonalityTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.PageConventionalPersonalityTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x0600C234 RID: 49716 RVA: 0x00B5FBC4 File Offset: 0x00B5DDC4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
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
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
			{
				short num = (short)1307547615;
				short num2 = num;
				num = (short)362321887;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1932722177;
					if (num != 0)
					{
					}
					num = (short)645398528;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 16:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
				break;
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
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 27:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 28:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 29:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 30:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 31:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 32:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 33:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 34:
				((global::AcpUI.AcpTableTextBoxCustomDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 35:
				((global::AcpUI.AcpTableTextBoxCustomDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 36:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 37:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 38:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 39:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 40:
				((global::AcpUI.AcpTableTextBoxCustomDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 41:
				((global::AcpUI.AcpTableTextBoxCustomDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 42:
				((global::AcpUI.AcpTableTextBoxCustomDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 43:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 44:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 45:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 46:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 47:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 48:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 49:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 50:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 51:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 52:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 53:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 54:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 55:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 56:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 57:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 58:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 59:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 60:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 61:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 62:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 63:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 64:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
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
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 69:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 70:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 71:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 72:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 73:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 74:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 75:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 76:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 77:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 78:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 79:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 80:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 81:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 82:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 83:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 84:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 85:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 86:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 87:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 88:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 89:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 90:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 91:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 92:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 93:
			{
				short num = (short)1653342208;
				short num3 = num;
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 94:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 95:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 96:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 97:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 98:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 99:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 100:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 101:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 102:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 103:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 104:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 105:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 106:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 107:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 108:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 109:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 110:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 111:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 112:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 113:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 114:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 115:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 116:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 117:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 118:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 119:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 120:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 121:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 122:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 123:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 124:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 125:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 126:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 127:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 128:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 129:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040060AA RID: 24746
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x040060AB RID: 24747
		private bool b;

		// Token: 0x040060AC RID: 24748
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageConventionalPersonality;

		// Token: 0x040060AD RID: 24749
		internal global::AcpUI.AcpXamDataPresenter ConventionalPersonalityList;

		// Token: 0x040060AE RID: 24750
		private bool c;
	}
}
