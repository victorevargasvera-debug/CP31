using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000EE RID: 238
	public class RMPasswordFieldEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060006AA RID: 1706 RVA: 0x0006AE74 File Offset: 0x00069074
		public RMPasswordFieldEditor()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x0006AE90 File Offset: 0x00069090
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x0006AF4C File Offset: 0x0006914C
		public string Mask
		{
			get
			{
				short num = (short)459699493;
				short num2 = num;
				num = (short)745829669;
				switch (num2 == num)
				{
				default:
				{
					num = (short)64618496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)463142913;
				if (num != 0)
				{
				}
				num = (short)677773312;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor.MaskProperty);
			}
			set
			{
				short num = (short)1553178775;
				short num2 = num;
				num = (short)1247060119;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1778188288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)731906049;
				if (num != 0)
				{
				}
				num = (short)1637679104;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor.MaskProperty, value);
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0006B000 File Offset: 0x00069200
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x0006B0B8 File Offset: 0x000692B8
		public bool IsShowingEyeButton
		{
			get
			{
				short num = (short)2129857096;
				short num2 = num;
				num = (short)203164232;
				switch (num2 == num)
				{
				default:
				{
					num = (short)366804992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)288423936;
				if (num != 0)
				{
				}
				num = (short)567410689;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor.IsShowingEyeButtonProperty);
			}
			set
			{
				short num = (short)61590714;
				short num2 = num;
				num = (short)1130941626;
				switch (num2 == num)
				{
				default:
				{
					num = (short)33423360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)956563457;
				if (num != 0)
				{
				}
				num = (short)2050883584;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor.IsShowingEyeButtonProperty, value);
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x0006B174 File Offset: 0x00069374
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x0006B22C File Offset: 0x0006942C
		public bool IsEditorOnly
		{
			get
			{
				short num = (short)1154511712;
				short num2 = num;
				num = (short)48526176;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1980104704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1252982785;
				if (num != 0)
				{
				}
				num = (short)2003697664;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor.IsEditorOnlyProperty);
			}
			set
			{
				short num = (short)742317745;
				short num2 = num;
				num = (short)1346887345;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1418526720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)715653121;
				if (num != 0)
				{
				}
				num = (short)1604386816;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor.IsEditorOnlyProperty, value);
			}
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0006B2EC File Offset: 0x000694EC
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num;
			for (;;)
			{
				num = (short)594935809;
				if (num != 0)
				{
				}
				if (!(bool)A_1.NewValue)
				{
					num = (short)483903086;
					short num2 = num;
					num = (short)620873326;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_94;
					}
					break;
				}
				goto IL_AD;
			}
			num = (short)675217408;
			short num3 = num;
			IL_94:
			num = (short)1023279104;
			if (num != 0)
			{
			}
			return;
			IL_AD:
			global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor rmpasswordFieldEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor)A_0;
			rmpasswordFieldEditor.grdMain.ColumnDefinitions[0].Width = new global::System.Windows.GridLength(0.0);
			rmpasswordFieldEditor.grdMain.ColumnDefinitions[1].Width = new global::System.Windows.GridLength(0.0);
			rmpasswordFieldEditor.grdMain.ColumnDefinitions[3].Width = global::System.Windows.GridLength.Auto;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0006B410 File Offset: 0x00069610
		private void btnLock_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2050373475;
			short num2 = num;
			num = (short)2028943203;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1775960064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1561395200;
			if (num != 0)
			{
			}
			num = (short)132775937;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMButton rmbutton = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMButton;
			rmbutton.Tag = !(bool)rmbutton.Tag;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0006B4D8 File Offset: 0x000696D8
		public override void SetFocus()
		{
			short num = (short)549881095;
			short num2 = num;
			num = (short)172328199;
			switch (num2 == num)
			{
			default:
			{
				num = (short)807337984;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2114781184;
			if (num != 0)
			{
			}
			num = (short)344981505;
			if (num != 0)
			{
			}
			this.msiPassword.Focus();
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0006B588 File Offset: 0x00069788
		public override void SetCellValuePresenterMode()
		{
			short num = (short)868003147;
			short num2 = num;
			num = (short)1201909067;
			switch (num2 == num)
			{
			default:
			{
				num = (short)705232896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)635174912;
			if (num != 0)
			{
			}
			num = (short)922746881;
			if (num != 0)
			{
			}
			this.msiPassword.BorderBrush = global::System.Windows.Media.Brushes.Transparent;
			this.msiPassword.Background = global::System.Windows.Media.Brushes.Transparent;
			this.msiPassword.IsHideBorder = true;
			this.borderfreeze.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0006B668 File Offset: 0x00069868
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 6;
			while (this._contentLoaded)
			{
				short num = (short)1622310498;
				short num2 = num;
				num = (short)1788378722;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)978452480;
					short num3 = num;
					num = (short)163512320;
					if (num != 0)
					{
					}
					num = (short)455671809;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("놝춡킣즥\udaa7얩삫쾭麯\udbb3\udbb5햷햹튻ﶽ邿釁铅꧇껉ꗋꇍ鷏돑뫓럕뿗뿙뇛믝軟雡쫣ꗥ蟧蓩飫鳭鿯黱蟳췵鯷闹釻軽濿氁愃栅簇┉礋納甏怑眓礕瘗渙減焝䰟儡ଣ䀥䄧伩䀫䨭唯嘱崳䈵圷䠹伻ᄽ㈿⽁㑃❅㭇㥉㭋⅍≏㙑㉓㽕㵗㙙㡛㭝џୡၣ॥ᩧ䑩ᑫ཭ᵯṱ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0006B74C File Offset: 0x0006994C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1437872539;
			short num2 = num;
			num = (short)1437741467;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1462173696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1639972864;
			if (num != 0)
			{
			}
			num = (short)651558913;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0006B7FC File Offset: 0x000699FC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)230752256;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					num = (short)857079810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_14E;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_F6;
				case 2:
					goto IL_15D;
				case 3:
					goto IL_BF;
				case 4:
					goto IL_69;
				case 5:
					goto IL_150;
				case 6:
					goto IL_103;
				default:
					num = (short)1727332353;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_69:
			num = (short)594806346;
			short num3 = num;
			num = (short)782304842;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_BF:
				num = (short)1638072320;
				short num4 = num;
				this.borderInvalid = (global::System.Windows.Controls.Border)target;
				return;
			}
			default:
				num = (short)632029184;
				if (num != 0)
				{
				}
				this.msiPassword = (global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox)target;
				return;
			}
			IL_F6:
			this.fedPassword = (global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor)target;
			return;
			IL_103:
			num = (short)1840840705;
			if (num != 0)
			{
			}
			this.btnLock = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_14E:
			this._contentLoaded = true;
			return;
			IL_150:
			this.borderfreeze = (global::System.Windows.Controls.Border)target;
			return;
			IL_15D:
			this.grdMain = (global::System.Windows.Controls.Grid)target;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0006B97C File Offset: 0x00069B7C
		// Note: this type is marked as 'beforefieldinit'.
		static RMPasswordFieldEditor()
		{
			int a_ = 6;
			short num = (short)906289393;
			short num2 = num;
			num = (short)1218371825;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2083586048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)521863169;
			if (num != 0)
			{
			}
			num = (short)1423835136;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor.MaskProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("펝솟톡쾣", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쎟쪡얣풥銧馩麫钭肯龱足閷\uddbb鎽몿黁럃ￏ뗓믕꣗ﯝ쿟죡쯣웥쟧뛩쇫쇭\udbef\uddf1\udbf3\ud9f5藷", a_)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor.IsShowingEyeButtonProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("힝펟첣즥\udfa7쎩슫즭쮱톳춷캹좻톽꺿", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor.IsEditorOnlyProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("힝펟삣쾥\udca7얩\udeab\udeaf\udeb1춳", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor.a)));
		}

		// Token: 0x040002F8 RID: 760
		public static readonly global::System.Windows.DependencyProperty MaskProperty;

		// Token: 0x040002F9 RID: 761
		public static readonly global::System.Windows.DependencyProperty IsShowingEyeButtonProperty;

		// Token: 0x040002FA RID: 762
		public static readonly global::System.Windows.DependencyProperty IsEditorOnlyProperty;

		// Token: 0x040002FB RID: 763
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordFieldEditor fedPassword;

		// Token: 0x040002FC RID: 764
		internal global::System.Windows.Controls.Grid grdMain;

		// Token: 0x040002FD RID: 765
		internal global::System.Windows.Controls.Border borderInvalid;

		// Token: 0x040002FE RID: 766
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMPasswordBox msiPassword;

		// Token: 0x040002FF RID: 767
		internal global::System.Windows.Controls.Border borderfreeze;

		// Token: 0x04000300 RID: 768
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnLock;

		// Token: 0x04000301 RID: 769
		private bool _contentLoaded;
	}
}
