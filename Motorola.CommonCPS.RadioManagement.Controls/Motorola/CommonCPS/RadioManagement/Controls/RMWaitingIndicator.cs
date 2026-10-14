using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000F3 RID: 243
	public class RMWaitingIndicator : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x0006BD88 File Offset: 0x00069F88
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x0006BE44 File Offset: 0x0006A044
		public global::System.Windows.Visibility PercentVisibility
		{
			get
			{
				short num = (short)508510989;
				short num2 = num;
				num = (short)1593328397;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1761673216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)703070209;
				if (num != 0)
				{
				}
				num = (short)1030422528;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator.PercentVisibilityProperty);
			}
			set
			{
				short num = (short)1059742470;
				short num2 = num;
				num = (short)1350394630;
				switch (num2 == num)
				{
				default:
				{
					num = (short)117833728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)657522689;
				if (num != 0)
				{
				}
				num = (short)587005952;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator.PercentVisibilityProperty, value);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0006BEFC File Offset: 0x0006A0FC
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x0006BFB8 File Offset: 0x0006A1B8
		public int Progress
		{
			get
			{
				short num = (short)984120676;
				short num2 = num;
				num = (short)1435467108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1933180928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)465764353;
				if (num != 0)
				{
				}
				num = (short)1759379456;
				if (num != 0)
				{
				}
				return (int)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator.ProgressProperty);
			}
			set
			{
				short num = (short)1288743899;
				short num2 = num;
				num = (short)858106843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)837353472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1955135489;
				if (num != 0)
				{
				}
				num = (short)2067988480;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator.ProgressProperty, value);
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0006C078 File Offset: 0x0006A278
		private static void OnProgressChanged(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator rmwaitingIndicator;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					rmwaitingIndicator.PercentsTextBox.Text = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ꮚ몞", a_), global::System.Convert.ToInt32(A_1.NewValue, global::System.Globalization.CultureInfo.CurrentCulture));
					goto IL_135;
				case 1:
					return;
				case 2:
				{
					if (rmwaitingIndicator == null)
					{
						return;
					}
					num2 = (short)1585293425;
					short num3 = num2;
					num2 = (short)1408346225;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_135;
					default:
						num2 = (short)2142568449;
						if (num2 != 0)
						{
						}
						num2 = (short)1588461568;
						if (num2 != 0)
						{
						}
						num2 = (short)2005008384;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_25;
				IL_135:
				num2 = (short)309919745;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_25:
			num2 = (short)908722176;
			short num4 = num2;
			rmwaitingIndicator = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator);
			num2 = (short)1555365890;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0006C1D4 File Offset: 0x0006A3D4
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x0006C28C File Offset: 0x0006A48C
		public global::System.Windows.Media.Brush ProgressBrush
		{
			get
			{
				short num = (short)192745568;
				short num2 = num;
				num = (short)468258912;
				switch (num2 == num)
				{
				}
				num = (short)1139539969;
				if (num != 0)
				{
				}
				num = (short)1001193472;
				if (num != 0)
				{
				}
				num = (short)899940352;
				short num3 = num;
				return (global::System.Windows.Media.Brush)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator.ProgressBrushProperty);
			}
			set
			{
				short num = (short)1158413742;
				short num2 = num;
				num = (short)772668846;
				switch (num2 == num)
				{
				}
				num = (short)1923481601;
				if (num != 0)
				{
				}
				num = (short)493158400;
				if (num != 0)
				{
				}
				num = (short)391970816;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator.ProgressBrushProperty, value);
			}
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0006C344 File Offset: 0x0006A544
		public RMWaitingIndicator()
		{
			this.InitializeComponent();
			this._dispatcherTimer = new global::System.Windows.Threading.DispatcherTimer(global::System.Windows.Threading.DispatcherPriority.Send);
			this._dispatcherTimer.Tick += this.dispatcherTimer_Tick;
			this._dispatcherTimer.Interval = new global::System.TimeSpan(0, 0, 0, 0, 100);
			base.Loaded += this.OnLoaded;
			base.IsVisibleChanged += this.a;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0006C3BC File Offset: 0x0006A5BC
		private void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)158203912;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				bool flag2;
				switch (num2)
				{
				case 0:
					goto IL_146;
				case 1:
					goto IL_182;
				case 2:
					return;
				case 3:
					IL_17D:
					num = (short)1889206278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (flag)
					{
						num = (short)1597505539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_182;
				case 5:
					if (!flag && flag2)
					{
						num = (short)1681719296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)381091844;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (!flag2)
					{
						num = (short)1906966535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_182;
				case 7:
					this._dispatcherTimer.Stop();
					num = (short)1366294529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				}
				IL_48:
				if (this._dispatcherTimer == null)
				{
					num = (short)263979010;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1096679424;
				short num3 = num;
				flag = (bool)A_1.OldValue;
				flag2 = (bool)A_1.NewValue;
				num = (short)104398853;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_182:
				num = (short)417651866;
				short num4 = num;
				num = (short)1347411098;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_17D;
				default:
					goto IL_1B9;
				}
			}
			return;
			IL_146:
			this._dispatcherTimer.Start();
			return;
			IL_1B9:
			num = (short)587464705;
			if (num != 0)
			{
			}
			num = (short)1383596032;
			if (num != 0)
			{
			}
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0006C5C0 File Offset: 0x0006A7C0
		private void OnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1715473914;
			short num2 = num;
			num = (short)2090208762;
			switch (num2 == num)
			{
			}
			num = (short)586350593;
			if (num != 0)
			{
			}
			num = (short)282853376;
			if (num != 0)
			{
			}
			num = (short)622788608;
			short num3 = num;
			this._loaded = true;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0006C670 File Offset: 0x0006A870
		private void dispatcherTimer_Tick(object A_0, global::System.EventArgs A_1)
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
					this.SpinnerRotate.Angle = 0.0;
					goto IL_103;
				case 1:
					return;
				case 2:
				{
					if ((int)this.SpinnerRotate.Angle != 360)
					{
						return;
					}
					num2 = (short)755492397;
					short num3 = num2;
					num2 = (short)1434248749;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_103;
					default:
						num2 = (short)44957696;
						if (num2 != 0)
						{
						}
						num2 = (short)551419904;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
				IL_103:
				num2 = (short)1959526401;
				if (num2 != 0)
				{
				}
				num2 = (short)1322909697;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			num2 = (short)1648164864;
			short num4 = num2;
			this.SpinnerRotate.Angle += 30.0;
			num2 = (short)2007302146;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0006C7C0 File Offset: 0x0006A9C0
		private void PercentsTextBox_TextChanged(object A_0, global::System.Windows.Controls.TextChangedEventArgs A_1)
		{
			if (!this._loaded)
			{
				short num = (short)802947072;
				short num2 = num;
				num = (short)1920104298;
				short num3 = num;
				num = (short)1375631210;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)65273857;
					if (num != 0)
					{
					}
					num = (short)1187119104;
					if (num != 0)
					{
					}
					return;
				}
			}
			global::System.Windows.Controls.Canvas.SetLeft(this.PercentsTextBox, (this.RotationCanvas.ActualHeight - this.PercentsTextBox.ActualWidth) / 2.0);
			global::System.Windows.Controls.Canvas.SetTop(this.PercentsTextBox, (this.RotationCanvas.ActualHeight - this.PercentsTextBox.ActualHeight) / 2.0);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0006C8D4 File Offset: 0x0006AAD4
		public void Stop()
		{
			short num = (short)745373693;
			short num2 = num;
			num = (short)513966077;
			switch (num2 == num)
			{
			}
			num = (short)908722177;
			if (num != 0)
			{
			}
			num = (short)1062666240;
			if (num != 0)
			{
			}
			num = (short)1140391936;
			short num3 = num;
			this._dispatcherTimer.Stop();
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0006C988 File Offset: 0x0006AB88
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 6;
			if (this._contentLoaded)
			{
				short num = (short)1523712000;
				short num2 = num;
				num = (short)639651630;
				short num3 = num;
				num = (short)2003914542;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)239730689;
					if (num != 0)
					{
					}
					num = (short)549519360;
					if (num != 0)
					{
					}
					return;
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("놝춡킣즥\udaa7얩삫쾭麯\udbb3\udbb5햷햹튻ﶽ邿釁铅꧇껉ꗋꇍ鷏돑뫓럕뿗뿙뇛믝軟雡쫣ꗥ蟧蓩飫鳭鿯黱蟳췵鯷闹釻軽濿氁愃栅簇┉礋納甏怑眓礕瘗渙減焝䰟儡ଣ吥䔧崩䴫䜭䐯嬱娳儵儷吹堻圽⌿⍁ぃ⥅㩇摉㑋⽍㵏㹑", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0006CA6C File Offset: 0x0006AC6C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1560281090;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)139132929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_D2;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				num = (short)169279489;
				if (num != 0)
				{
				}
				switch (connectionId)
				{
				case 1:
					goto IL_E1;
				case 2:
					goto IL_96;
				case 3:
					goto IL_89;
				case 4:
					goto IL_D4;
				default:
					num = (short)212008960;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_89:
			this.RotationCanvas = (global::System.Windows.Controls.Canvas)target;
			return;
			IL_96:
			this.PercentsTextBox = (global::System.Windows.Controls.TextBox)target;
			this.PercentsTextBox.TextChanged += this.PercentsTextBox_TextChanged;
			return;
			IL_D2:
			num = (short)407293773;
			short num3 = num;
			num = (short)958648141;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_96;
			case 1:
				break;
			default:
			{
				num = (short)1184694272;
				short num4 = num;
				break;
			}
			}
			num = (short)440795136;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			return;
			IL_D4:
			this.SpinnerRotate = (global::System.Windows.Media.RotateTransform)target;
			return;
			IL_E1:
			this.RmWaitingIndicator = (global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator)target;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0006CBE4 File Offset: 0x0006ADE4
		// Note: this type is marked as 'beforefieldinit'.
		static RMWaitingIndicator()
		{
			int a_ = 15;
			short num = (short)187656811;
			short num2 = num;
			num = (short)185231979;
			switch (num2 == num)
			{
			}
			num = (short)1230176257;
			if (num != 0)
			{
			}
			num = (short)1959198720;
			if (num != 0)
			{
			}
			num = (short)723910656;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator.PercentVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첨\ud9aa캬쪮\udfb0잲\udeb6쪸튺\udfbc횾귀ꫂ뇄뻆", a_), typeof(global::System.Windows.Visibility), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator.ProgressProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udba8쒪쪬\uddae풰삲운", a_), typeof(int), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator), new global::System.Windows.UIPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator.OnProgressChanged)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator.ProgressBrushProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udba8쒪쪬\uddae풰삲운쮸캺캼ힾ", a_), typeof(global::System.Windows.Media.Brush), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Media.Brushes.Gray));
		}

		// Token: 0x04000306 RID: 774
		public static readonly global::System.Windows.DependencyProperty PercentVisibilityProperty;

		// Token: 0x04000307 RID: 775
		public static readonly global::System.Windows.DependencyProperty ProgressProperty;

		// Token: 0x04000308 RID: 776
		public static readonly global::System.Windows.DependencyProperty ProgressBrushProperty;

		// Token: 0x04000309 RID: 777
		private const string PercentsText = "{0}%";

		// Token: 0x0400030A RID: 778
		private readonly global::System.Windows.Threading.DispatcherTimer _dispatcherTimer;

		// Token: 0x0400030B RID: 779
		private bool _loaded;

		// Token: 0x0400030C RID: 780
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator RmWaitingIndicator;

		// Token: 0x0400030D RID: 781
		internal global::System.Windows.Controls.TextBox PercentsTextBox;

		// Token: 0x0400030E RID: 782
		internal global::System.Windows.Controls.Canvas RotationCanvas;

		// Token: 0x0400030F RID: 783
		internal global::System.Windows.Media.RotateTransform SpinnerRotate;

		// Token: 0x04000310 RID: 784
		private bool _contentLoaded;
	}
}
