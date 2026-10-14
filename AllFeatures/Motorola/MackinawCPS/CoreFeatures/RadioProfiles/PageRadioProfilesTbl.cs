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

namespace Motorola.MackinawCPS.CoreFeatures.RadioProfiles
{
	// Token: 0x02000217 RID: 535
	public class PageRadioProfilesTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600603F RID: 24639 RVA: 0x0056872C File Offset: 0x0056692C
		public PageRadioProfilesTbl()
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

		// Token: 0x06006040 RID: 24640 RVA: 0x00568764 File Offset: 0x00566964
		public override void SetDataContext()
		{
			short num = (short)1772224517;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)685938530;
				short num3 = num;
				num = (short)755144546;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D9;
				case 1:
					break;
				default:
				{
					num = (short)495648768;
					short num4 = num;
					break;
				}
				}
				num = (short)2133590016;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_D9;
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)852361219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_208;
				case 2:
					goto IL_D9;
				case 3:
					goto IL_184;
				case 4:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2077);
					num = (short)1747517442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_B1;
					}
					continue;
				}
				IL_B1:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)204406788;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2077);
				num = (short)244187136;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D9:
				num = (short)864419841;
				if (num != 0)
				{
				}
				this.RadioProfilesList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageRadioProfiles.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageRadioProfiles.MyDataPresenter = this.RadioProfilesList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageRadioProfiles;
				num = (short)318308353;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_184:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2077);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageRadioProfiles).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_208:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageRadioProfiles).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06006041 RID: 24641 RVA: 0x00568988 File Offset: 0x00566B88
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1093664770;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1394409472;
					short num3 = num;
					num = (short)2062841477;
					short num4 = num;
					num = (short)61240965;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)415694848;
						if (num != 0)
						{
						}
						break;
					}
					object myRecordsetDataSource = this.RecNavToolbarPageRadioProfiles.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)887291905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					return;
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
				num = (short)624951297;
				if (num != 0)
				{
				}
				num = (short)550895616;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06006042 RID: 24642 RVA: 0x00568ACC File Offset: 0x00566CCC
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1892228819;
						short num3 = num2;
						num2 = (short)592977619;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_34;
						default:
						{
							num2 = (short)2095775744;
							if (num2 != 0)
							{
							}
							num2 = (short)1355022336;
							short num4 = num2;
							num2 = (short)306905089;
							if (num2 != 0)
							{
							}
							base.OnUnloaded(sender, e);
							this.b = false;
							num2 = (short)615448577;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						if (this.b)
						{
							num2 = (short)734527488;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					goto IL_1C;
				}
				return;
			}
			IL_1C:
			this.RecNavToolbarPageRadioProfiles.DataContext = null;
			this.RecNavToolbarPageRadioProfiles.MyDataPresenter = null;
			IL_34:
			num2 = (short)1286799362;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06006043 RID: 24643 RVA: 0x00568C0C File Offset: 0x00566E0C
		internal void OnRadioProfilesFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)126256903;
			short num2 = num;
			num = (short)7177991;
			switch (num2 == num)
			{
			}
			num = (short)1345585153;
			if (num != 0)
			{
			}
			num = (short)1181745152;
			short num3 = num;
			num = (short)1037828096;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles a_ = (global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06006044 RID: 24644 RVA: 0x00568CE0 File Offset: 0x00566EE0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1123682268;
			short num2 = num;
			num = (short)1655506908;
			switch (num2 == num)
			{
			}
			num = (short)1355153408;
			if (num != 0)
			{
			}
			num = (short)1788149760;
			short num3 = num;
			num = (short)1336934401;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06006045 RID: 24645 RVA: 0x00568D8C File Offset: 0x00566F8C
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1369092191;
						short num3 = num2;
						num2 = (short)1342615647;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3B;
						default:
						{
							num2 = (short)1193476097;
							if (num2 != 0)
							{
							}
							num2 = (short)967114752;
							short num4 = num2;
							num2 = (short)1550778368;
							if (num2 != 0)
							{
							}
							this.a.MoveCurrentToFirst();
							num2 = (short)1157038081;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						goto IL_139;
					case 2:
						if (this.a.CurrentItem == null)
						{
							num2 = (short)1397948416;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_13B;
					}
					goto IL_1C;
				}
				IL_139:
				IL_13B:
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles a_ = (global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles)this.a.CurrentItem;
				this.a(a_);
				return;
			}
			}
			IL_1C:
			object myRecordsetDataSource = this.RecNavToolbarPageRadioProfiles.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			IL_3B:
			num2 = (short)1877475330;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06006046 RID: 24646 RVA: 0x00568EEC File Offset: 0x005670EC
		private void a(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles A_0)
		{
			short num = (short)1849988496;
			short num2 = num;
			num = (short)117544336;
			switch (num2 == num)
			{
			}
			num = (short)91947009;
			if (num != 0)
			{
			}
			num = (short)883425280;
			short num3 = num;
			num = (short)837287936;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x00568FBC File Offset: 0x005671BC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 6;
			if (this.c)
			{
				short num;
				for (;;)
				{
					num = (short)1383003309;
					short num2 = num;
					num = (short)1659958445;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_4B;
					}
				}
				IL_4B:
				num = (short)376832000;
				if (num != 0)
				{
				}
				num = (short)1321074689;
				if (num != 0)
				{
				}
				num = (short)2105999360;
				short num3 = num;
				return;
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("裈ꟊꇌ觎듐닒ꇔꋖꯘ뻚껜苠賢裤韦蛨藪裬臮藰\udcf2蟴零鷸鋺鋼\udafe㌀㌂怄甆済搊挌怎簐稒瘔搖㰘⤚ⴜ簞丠䴢䌤並丨帪弬丮䔰娲娴夶ᘸ䤺尼嬾⡀ⱂ恄畆祈㭊㽌⁎㝐㩒㥔㉖⩘瑚⽜㹞ՠ੢੤ᝦ᭨Ѫ୬ٮᵰᙲٴͶ᭸᝺卼ݾ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06006048 RID: 24648 RVA: 0x005690A0 File Offset: 0x005672A0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)163840003;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1246625792;
				short num3 = num;
				switch (num2)
				{
				case 0:
				{
					num = (short)1978574371;
					short num4 = num;
					num = (short)277390883;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_86;
					default:
						num = (short)738000897;
						if (num != 0)
						{
						}
						num = (short)1806696448;
						if (num != 0)
						{
						}
						if (connectionId != 96)
						{
							num = (short)61603846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF;
					}
					break;
				}
				case 1:
					goto IL_86;
				case 2:
					if (connectionId != 2)
					{
						num = (short)1545732101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_88;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_6B;
					}
					continue;
				case 4:
					goto IL_C4;
				case 5:
					num = (short)583270400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)911736836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6B:
				if (connectionId != 1)
				{
					num = (short)329711617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1BD;
				IL_86:
				num = (short)1666121730;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_88:
			this.RecNavToolbarPageRadioProfiles = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageRadioProfiles.ModeClick += this.OnModeClick;
			return;
			IL_C4:
			this.c = true;
			return;
			IL_FF:
			this.RadioProfilesList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1BD:
			((global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.PageRadioProfilesTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.PageRadioProfilesTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x06006049 RID: 24649 RVA: 0x005692A4 File Offset: 0x005674A4
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
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
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
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
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
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
			{
				short num = (short)526778369;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 23:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 24:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 25:
				break;
			case 26:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 27:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 28:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 29:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 30:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 31:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 32:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 33:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 34:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 35:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 36:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 37:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 38:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 39:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 40:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 41:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 42:
			{
				short num = (short)2034171904;
				short num2 = num;
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 43:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 44:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 45:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 46:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
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
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 51:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 52:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 53:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 54:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 55:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
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
			{
				short num = (short)2133018502;
				short num3 = num;
				num = (short)458311558;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1150222336;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 64:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 65:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 66:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 67:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 68:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 69:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 70:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 71:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 72:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 73:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 74:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 75:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 76:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 77:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 78:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 79:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
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
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
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
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 91:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 92:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 93:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 94:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 95:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040025FE RID: 9726
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x040025FF RID: 9727
		private bool b;

		// Token: 0x04002600 RID: 9728
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageRadioProfiles;

		// Token: 0x04002601 RID: 9729
		internal global::AcpUI.AcpXamDataPresenter RadioProfilesList;

		// Token: 0x04002602 RID: 9730
		private bool c;
	}
}
