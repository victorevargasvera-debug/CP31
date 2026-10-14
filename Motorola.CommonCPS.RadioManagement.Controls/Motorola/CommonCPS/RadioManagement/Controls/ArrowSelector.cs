using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000FB RID: 251
	public class ArrowSelector : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000703 RID: 1795 RVA: 0x00070928 File Offset: 0x0006EB28
		public ArrowSelector()
		{
			this.InitializeComponent();
			this.tb.Click += this.Click;
			this.list.SelectionChanged += this.Select;
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00070970 File Offset: 0x0006EB70
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00070A2C File Offset: 0x0006EC2C
		public global::System.Collections.Generic.IEnumerable<string> Choices
		{
			get
			{
				short num = (short)1637801982;
				short num2 = num;
				num = (short)941416446;
				switch (num2 == num)
				{
				}
				num = (short)1187708928;
				short num3 = num;
				num = (short)1856307201;
				if (num != 0)
				{
				}
				num = (short)1130692608;
				if (num != 0)
				{
				}
				return (global::System.Collections.Generic.IEnumerable<string>)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector.ChoicesProperty);
			}
			set
			{
				short num = (short)1540096001;
				if (num != 0)
				{
				}
				num = (short)749261424;
				short num2 = num;
				num = (short)1014747760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)199163904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)845086720;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector.ChoicesProperty, value);
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00070AE4 File Offset: 0x0006ECE4
		private static void SetChoices(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num;
			if (A_1.NewValue == null)
			{
				num = (short)1231692233;
				short num2 = num;
				num = (short)291578313;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)49938433;
					if (num != 0)
					{
					}
					num = (short)320339968;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)1791164416;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector arrowSelector = (global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector)A_0;
			arrowSelector.list.ItemsSource = (global::System.Collections.Generic.IEnumerable<string>)A_1.NewValue;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00070BB8 File Offset: 0x0006EDB8
		private void Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1319477485;
			short num2 = num;
			num = (short)8298733;
			switch (num2 == num)
			{
			}
			num = (short)1250623488;
			short num3 = num;
			num = (short)46923777;
			if (num != 0)
			{
			}
			num = (short)736034816;
			if (num != 0)
			{
			}
			this.popup.IsOpen = true;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00070C70 File Offset: 0x0006EE70
		private void PopupLostFocus(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1436529928;
			short num2 = num;
			num = (short)415806728;
			switch (num2 == num)
			{
			}
			num = (short)1798438912;
			short num3 = num;
			num = (short)385155073;
			if (num != 0)
			{
			}
			num = (short)79101952;
			if (num != 0)
			{
			}
			this.popup.IsOpen = false;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00070D28 File Offset: 0x0006EF28
		private bool a(double A_0, double A_1, double A_2)
		{
			short num = (short)93519874;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)920125440;
					short num3 = num;
					num = (short)1098186753;
					if (num != 0)
					{
					}
					num = (short)1686568963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_122;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_36;
					}
					continue;
				case 3:
					if (A_0 <= A_2)
					{
						num = (short)444727297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_36:
				num = (short)289797342;
				short num4 = num;
				num = (short)1234498782;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				default:
					num = (short)1610678272;
					if (num != 0)
					{
					}
					if (A_0 < A_1)
					{
						return false;
					}
					num = (short)850001920;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return true;
			IL_122:
			return true;
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00070E5C File Offset: 0x0006F05C
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x00070F18 File Offset: 0x0006F118
		public global::System.Windows.Input.ICommand Command
		{
			get
			{
				short num = (short)1985158693;
				short num2 = num;
				num = (short)899882533;
				switch (num2 == num)
				{
				}
				num = (short)103874560;
				short num3 = num;
				num = (short)266534913;
				if (num != 0)
				{
				}
				num = (short)834535424;
				if (num != 0)
				{
				}
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector.CommandProperty);
			}
			set
			{
				short num = (short)5538437;
				short num2 = num;
				num = (short)959283845;
				switch (num2 == num)
				{
				}
				num = (short)93519872;
				short num3 = num;
				num = (short)790233089;
				if (num != 0)
				{
				}
				num = (short)628031488;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector.CommandProperty, value);
			}
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00070FCC File Offset: 0x0006F1CC
		private static void SetCommand(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1714094081;
			if (num != 0)
			{
			}
			num = (short)446210365;
			short num2 = num;
			num = (short)9740605;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1193869312;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)165347328;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00071074 File Offset: 0x0006F274
		private void Select(object A_0, global::System.Windows.Controls.SelectionChangedEventArgs A_1)
		{
			short num = (short)1993932801;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1253625855;
				short num3 = num;
				num = (short)892850175;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2135162880;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_F8;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					case 2:
						this.Command.Execute((A_0 as global::System.Windows.Controls.ListBox).SelectedItem.ToString());
						num = (short)2094071808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_7B:
				num = (short)1912406016;
				short num4 = num;
				if (this.Command == null)
				{
					break;
				}
				num = (short)1831075842;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F8:
			num = (short)2105278465;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000711A4 File Offset: 0x0006F3A4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 16;
			short num;
			if (this._contentLoaded)
			{
				num = (short)1097334785;
				if (num != 0)
				{
				}
				num = (short)2030528284;
				short num2 = num;
				num = (short)1637836572;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1831010304;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)2105671680;
			short num3 = num;
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("螧쎫\udaad\udfaf삱\udbb3\udab5\ud9b7钹ﾻ톽궿꿁ꯃꣅ诇髉鿋苏돑냓뿕럗韙뷛냝臟藡臣该跧蓩飫샭돯鷱髳苵諷闹郻跽㯿愁欃欅砇攉戋欍縏昑㬓挕欗缙減紝伟䰡倣吥䜧䘩弫ĭ儯䀱䘳夵伷䤹夻刽┿⅁ぃ⥅㩇摉㑋⽍㵏㹑", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00071284 File Offset: 0x0006F484
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1360986113;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_12D;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					num = (short)1336737792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				num = (short)1232539190;
				short num3 = num;
				num = (short)1174015542;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_FA;
				default:
					num = (short)1123614720;
					if (num != 0)
					{
					}
					num = (short)432865281;
					if (num != 0)
					{
					}
					switch (connectionId)
					{
					case 1:
						goto IL_107;
					case 2:
						goto IL_FA;
					case 3:
						goto IL_12F;
					default:
					{
						num = (short)43778048;
						short num4 = num;
						num = (short)2079916034;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
					break;
				}
			}
			IL_FA:
			this.popup = (global::System.Windows.Controls.Primitives.Popup)target;
			return;
			IL_107:
			this.tb = (global::System.Windows.Controls.Button)target;
			return;
			IL_12D:
			this._contentLoaded = true;
			return;
			IL_12F:
			this.list = (global::System.Windows.Controls.ListBox)target;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x000713D4 File Offset: 0x0006F5D4
		// Note: this type is marked as 'beforefieldinit'.
		static ArrowSelector()
		{
			int a_ = 2;
			short num = (short)1094930084;
			short num2 = num;
			num = (short)1978814116;
			switch (num2 == num)
			{
			}
			num = (short)1627979776;
			short num3 = num;
			num = (short)1539440641;
			if (num != 0)
			{
			}
			num = (short)1175060480;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector.ChoicesProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud999즟송솣향", a_), typeof(global::System.Collections.Generic.IEnumerable<string>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector.SetChoices)));
			global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector.CommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud999춟쎡쪣슥", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.ArrowSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x0400033F RID: 831
		public static readonly global::System.Windows.DependencyProperty ChoicesProperty;

		// Token: 0x04000340 RID: 832
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x04000341 RID: 833
		internal global::System.Windows.Controls.Button tb;

		// Token: 0x04000342 RID: 834
		internal global::System.Windows.Controls.Primitives.Popup popup;

		// Token: 0x04000343 RID: 835
		internal global::System.Windows.Controls.ListBox list;

		// Token: 0x04000344 RID: 836
		private bool _contentLoaded;
	}
}
