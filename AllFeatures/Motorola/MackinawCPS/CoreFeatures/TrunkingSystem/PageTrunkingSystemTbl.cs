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

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x020000AB RID: 171
	public class PageTrunkingSystemTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600153F RID: 5439 RVA: 0x00144104 File Offset: 0x00142304
		public PageTrunkingSystemTbl()
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

		// Token: 0x06001540 RID: 5440 RVA: 0x0014413C File Offset: 0x0014233C
		public override void SetDataContext()
		{
			short num = (short)2023489538;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2064);
					num = (short)2004549633;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_62;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						goto IL_202;
					}
					num = (short)104703173;
					short num3 = num;
					num = (short)477930693;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)672792577;
						if (num != 0)
						{
						}
						num = (short)2070675456;
						if (num != 0)
						{
						}
						num = (short)1868890116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_156;
				case 5:
					goto IL_62;
				}
				IL_3D:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1623195648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2064);
				num = (short)1384972293;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_62:
				this.TrunkingSystemList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageTrunkingSystem.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageTrunkingSystem.MyDataPresenter = this.TrunkingSystemList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageTrunkingSystem;
				num = (short)1692139523;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_156:
			num = (short)1437270016;
			short num4 = num;
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2064);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageTrunkingSystem).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_202:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageTrunkingSystem).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00144358 File Offset: 0x00142558
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2144010240;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)544145409;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 1:
				{
					object myRecordsetDataSource = this.RecNavToolbarPageTrunkingSystem.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)826474498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_EC;
				}
				IL_5A:
				num = (short)1890254848;
				short num3 = num;
				if (!this.b)
				{
					num = (short)1352400897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_EC:
				num = (short)1696571524;
				short num4 = num;
				num = (short)512270468;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_5A;
				default:
					goto IL_121;
				}
			}
			IL_121:
			num = (short)218431488;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0014449C File Offset: 0x0014269C
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
				{
					num2 = (short)517867079;
					short num3 = num2;
					num2 = (short)1958413895;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)921829376;
						if (num2 != 0)
						{
						}
						if (this.b)
						{
							num2 = (short)1191772161;
							if (num2 != 0)
							{
							}
							num2 = (short)851574785;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
				{
					num2 = (short)285278208;
					short num4 = num2;
					base.OnUnloaded(sender, e);
					this.b = false;
					num2 = (short)308412418;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			this.RecNavToolbarPageTrunkingSystem.DataContext = null;
			this.RecNavToolbarPageTrunkingSystem.MyDataPresenter = null;
			num2 = (short)702283776;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x001445DC File Offset: 0x001427DC
		internal void OnTrunkingSystemFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)710161210;
			short num2 = num;
			num = (short)660353850;
			switch (num2 == num)
			{
			default:
			{
				num = (short)829947904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1634992129;
			if (num != 0)
			{
			}
			num = (short)261292032;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem a_ = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x001446B0 File Offset: 0x001428B0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)945348622;
			short num2 = num;
			num = (short)58056718;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1136525312;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1758134273;
			if (num != 0)
			{
			}
			num = (short)753532928;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x00144760 File Offset: 0x00142960
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
				{
					num2 = (short)1506177204;
					short num3 = num2;
					num2 = (short)1575514292;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_139;
					default:
						num2 = (short)1296302080;
						if (num2 != 0)
						{
						}
						if (this.a.CurrentItem == null)
						{
							num2 = (short)517144577;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_139;
					}
					break;
				}
				case 1:
				{
					num2 = (short)2048393217;
					if (num2 != 0)
					{
					}
					num2 = (short)976224256;
					short num4 = num2;
					this.a.MoveCurrentToFirst();
					num2 = (short)1535508482;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_137;
				}
				goto IL_1C;
			}
			IL_137:
			IL_139:
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem a_ = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_1C:
			object myRecordsetDataSource = this.RecNavToolbarPageTrunkingSystem.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num2 = (short)90374144;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x001448C0 File Offset: 0x00142AC0
		private void a(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem A_0)
		{
			short num = (short)310563695;
			short num2 = num;
			num = (short)1985270639;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1760559104;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)976879617;
			if (num != 0)
			{
			}
			num = (short)258211840;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00144990 File Offset: 0x00142B90
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 6;
			short num = (short)1858142712;
			short num2 = num;
			num = (short)220529144;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)646840320;
				short num3 = num;
				num = (short)1181220864;
				if (num != 0)
				{
				}
				if (this.c)
				{
					num = (short)853540865;
					if (num != 0)
					{
					}
					return;
				}
				break;
			}
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("裈ꟊꇌ觎듐닒ꇔꋖꯘ뻚껜苠賢裤韦蛨藪裬臮藰\udcf2致藶賸闺雼雾漀搂\u2004㔆㤈栊戌愎眐稒爔或欘稚検瘞丠䴢ਤ匦嬨帪䌬䐮堰崲刴ሶସ଺丼䘾㉀㝂⁄⩆晈㽊㽌㩎㽐㡒㱔㥖㹘⡚⑜ⱞᕠ٢ࡤ፦୨ݪ䍬ᝮၰṲᥴ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00144A70 File Offset: 0x00142C70
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)993263619;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E3;
				case 1:
					num = (short)1032192000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_E8;
				case 3:
				{
					num = (short)2144727358;
					short num3 = num;
					num = (short)1357639998;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E8;
					default:
						num = (short)1402142720;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_8D;
						}
						continue;
					}
					break;
				}
				case 4:
					if (connectionId != 105)
					{
						num = (short)2108620801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_144;
				case 5:
					if (connectionId != 2)
					{
						num = (short)1853554694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AA;
				case 6:
				{
					num = (short)1700462593;
					if (num != 0)
					{
					}
					num = (short)1471414272;
					short num4 = num;
					num = (short)255262724;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_8D:
				if (connectionId != 1)
				{
					num = (short)2117795842;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1B2;
				IL_E8:
				num = (short)2075262981;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AA:
			this.RecNavToolbarPageTrunkingSystem = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageTrunkingSystem.ModeClick += this.OnModeClick;
			return;
			IL_E3:
			this.c = true;
			return;
			IL_144:
			this.TrunkingSystemList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1B2:
			((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.PageTrunkingSystemTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.PageTrunkingSystemTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00144C68 File Offset: 0x00142E68
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
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
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
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 23:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 24:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 25:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 26:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
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
			{
				short num = (short)1019472378;
				short num2 = num;
				num = (short)992274938;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1818230784;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 31:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 32:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 33:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 34:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 35:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 36:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 37:
			{
				short num = (short)716963841;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 38:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 39:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 40:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 41:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
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
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 48:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 49:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 50:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 51:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 52:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
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
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
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
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 63:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 64:
				break;
			case 65:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 66:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 67:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 68:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 69:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 70:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 71:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 72:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 73:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 74:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 75:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 76:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
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
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 81:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 82:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 83:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 84:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 85:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 86:
			{
				short num = (short)1382875136;
				short num3 = num;
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 87:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 88:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 89:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 90:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 91:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 92:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 93:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 94:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 95:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 96:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 97:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
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
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 103:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 104:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000853 RID: 2131
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04000854 RID: 2132
		private bool b;

		// Token: 0x04000855 RID: 2133
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageTrunkingSystem;

		// Token: 0x04000856 RID: 2134
		internal global::AcpUI.AcpXamDataPresenter TrunkingSystemList;

		// Token: 0x04000857 RID: 2135
		private bool c;
	}
}
