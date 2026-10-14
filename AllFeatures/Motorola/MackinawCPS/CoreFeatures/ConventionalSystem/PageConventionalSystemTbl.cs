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

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x0200055A RID: 1370
	public class PageConventionalSystemTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600B75C RID: 46940 RVA: 0x00AA6864 File Offset: 0x00AA4A64
		public PageConventionalSystemTbl()
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

		// Token: 0x0600B75D RID: 46941 RVA: 0x00AA689C File Offset: 0x00AA4A9C
		public override void SetDataContext()
		{
			short num = (short)217055237;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1880489985;
					if (num != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1218314244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_204;
				case 1:
					goto IL_160;
				case 2:
				{
					num = (short)1547567104;
					short num3 = num;
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2053);
					num = (short)1456472067;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					num = (short)714959478;
					short num4 = num;
					num = (short)61434486;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_160;
					default:
						num = (short)646381568;
						if (num != 0)
						{
						}
						goto IL_89;
					}
					break;
				}
				case 4:
					goto IL_134;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				}
				IL_3C:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)128647170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2053);
				num = (short)1910505473;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_89:
				this.ConventionalSystemList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageConventionalSystem.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageConventionalSystem.MyDataPresenter = this.ConventionalSystemList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageConventionalSystem;
				num = (short)163512320;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_160:
				goto IL_89;
			}
			IL_134:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2053);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageConventionalSystem).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_204:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageConventionalSystem).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x0600B75E RID: 46942 RVA: 0x00AA6ABC File Offset: 0x00AA4CBC
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)714932226;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_109;
				case 1:
				{
					num = (short)367656961;
					if (num != 0)
					{
					}
					object myRecordsetDataSource = this.RecNavToolbarPageConventionalSystem.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					goto IL_F0;
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
				if (this.b)
				{
					break;
				}
				num = (short)542286761;
				short num3 = num;
				num = (short)126526377;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1043791872;
					if (num != 0)
					{
					}
					num = (short)1634664449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F0:
				num = (short)709099520;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_109:
			num = (short)1649213440;
			short num4 = num;
		}

		// Token: 0x0600B75F RID: 46943 RVA: 0x00AA6C00 File Offset: 0x00AA4E00
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
					goto IL_102;
				case 1:
				{
					base.OnUnloaded(sender, e);
					this.b = false;
					num2 = (short)1494155265;
					if (num2 != 0)
					{
					}
					num2 = (short)2085730691;
					short num3 = num2;
					num2 = (short)348699011;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_102;
					default:
						num2 = (short)1017970688;
						if (num2 != 0)
						{
						}
						num2 = (short)684589056;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (this.b)
					{
						num2 = (short)513277953;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			IL_102:
			num2 = (short)1927348224;
			short num4 = num2;
			return;
			IL_1C:
			this.RecNavToolbarPageConventionalSystem.DataContext = null;
			this.RecNavToolbarPageConventionalSystem.MyDataPresenter = null;
			num2 = (short)46137346;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B760 RID: 46944 RVA: 0x00AA6D3C File Offset: 0x00AA4F3C
		internal void OnConventionalSystemFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)83332147;
			short num2 = num;
			num = (short)264604723;
			switch (num2 == num)
			{
			default:
			{
				num = (short)710803456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1816199168;
			if (num != 0)
			{
			}
			num = (short)1203044353;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem a_ = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x0600B761 RID: 46945 RVA: 0x00AA6E14 File Offset: 0x00AA5014
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1063952770;
			short num2 = num;
			num = (short)1543741826;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1772814336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)502726656;
			if (num != 0)
			{
			}
			num = (short)2018705409;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600B762 RID: 46946 RVA: 0x00AA6EC4 File Offset: 0x00AA50C4
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
					goto IL_110;
				case 1:
				{
					this.a.MoveCurrentToFirst();
					num2 = (short)1907344668;
					short num3 = num2;
					num2 = (short)130991388;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_110;
					default:
						num2 = (short)59965440;
						if (num2 != 0)
						{
						}
						num2 = (short)913768448;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					num2 = (short)997130241;
					if (num2 != 0)
					{
					}
					if (this.a.CurrentItem == null)
					{
						num2 = (short)1253310465;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13A;
				}
				goto IL_1C;
			}
			IL_110:
			num2 = (short)782368768;
			short num4 = num2;
			IL_13A:
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem a_ = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_1C:
			object myRecordsetDataSource = this.RecNavToolbarPageConventionalSystem.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num2 = (short)1021771778;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B763 RID: 46947 RVA: 0x00AA7024 File Offset: 0x00AA5224
		private void a(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem A_0)
		{
			short num = (short)2107264453;
			short num2 = num;
			num = (short)1728662981;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1302855680;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)115671041;
			if (num != 0)
			{
			}
			num = (short)1586561024;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x0600B764 RID: 46948 RVA: 0x00AA70F4 File Offset: 0x00AA52F4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 17;
			if (this.c)
			{
				short num = (short)2071317104;
				short num2 = num;
				num = (short)1907477104;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B4;
				case 1:
					break;
				default:
				{
					num = (short)447479808;
					short num3 = num;
					break;
				}
				}
				num = (short)1854406657;
				if (num != 0)
				{
				}
				num = (short)975962112;
				if (num != 0)
				{
				}
				return;
			}
			IL_B4:
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("﷑闓뫕듗鳙맛뿝铟韡難菥鯧퇩迫臭鷯英鯳飵鷷铹裻퇽揿洁樃瀅洇搉砋服缏簑甓稕㴗⠙Ⱋ紝伟䰡䈣伥伧弩師伭䐯嬱嬳堵᜷夹医倽㘿❁⩃㉅ⅇ╉≋⽍㱏睑晓晕⭗⍙⽛⩝՟ཡ䭣եݧѩᩫ୭ṯٱᵳ᥵ᙷ᭹ၻൽ勵ﺉ뺏ﮕ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600B765 RID: 46949 RVA: 0x00AA71D8 File Offset: 0x00AA53D8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)128909318;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (connectionId != 2)
					{
						num = (short)964886533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_61;
				case 1:
				{
					num = (short)1012670413;
					short num3 = num;
					num = (short)413212621;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B4;
					default:
						goto IL_D0;
					}
					break;
				}
				case 2:
					if (connectionId != 89)
					{
						num = (short)1979580420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_149;
				case 3:
					num = (short)564854784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1B4;
				case 5:
					num = (short)645857282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				}
				IL_40:
				if (connectionId != 1)
				{
					num = (short)423690243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1B9;
				IL_1B4:
				num = (short)120193025;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_61:
			this.RecNavToolbarPageConventionalSystem = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageConventionalSystem.ModeClick += this.OnModeClick;
			return;
			IL_D0:
			num = (short)1107296256;
			if (num != 0)
			{
			}
			num = (short)661716993;
			if (num != 0)
			{
			}
			this.c = true;
			return;
			IL_149:
			num = (short)429850624;
			short num4 = num;
			this.ConventionalSystemList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1B9:
			((global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.PageConventionalSystemTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.PageConventionalSystemTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x0600B766 RID: 46950 RVA: 0x00AA73D8 File Offset: 0x00AA55D8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
			{
				short num = (short)595001344;
				short num2 = num;
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 4:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableTextBoxCustomDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableTextBoxCustomDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 23:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 24:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 25:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 26:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 27:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 28:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 29:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 30:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 31:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 32:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 33:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 34:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 35:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 36:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 37:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 38:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 39:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 40:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 41:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 42:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 43:
			{
				short num = (short)814396343;
				short num3 = num;
				num = (short)966177719;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1301217280;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 44:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 45:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 46:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 47:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 48:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 49:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 50:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 51:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 52:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
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
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 58:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 59:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 60:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
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
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 65:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 66:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 67:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 68:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 69:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 70:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 71:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 72:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 73:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
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
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 78:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 79:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 80:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 81:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 82:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 83:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 84:
				break;
			case 85:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 86:
			{
				short num = (short)125698049;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 87:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 88:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04005B0D RID: 23309
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04005B0E RID: 23310
		private bool b;

		// Token: 0x04005B0F RID: 23311
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageConventionalSystem;

		// Token: 0x04005B10 RID: 23312
		internal global::AcpUI.AcpXamDataPresenter ConventionalSystemList;

		// Token: 0x04005B11 RID: 23313
		private bool c;
	}
}
