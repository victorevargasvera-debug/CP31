using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000013 RID: 19
	[DesignTimeVisible(false)]
	public partial class ColorsDialog : Window
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00014794 File Offset: 0x00012994
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0001484C File Offset: 0x00012A4C
		public Color CurrentColor
		{
			get
			{
				short num = (short)853346255;
				short num2 = num;
				num = (short)1928398799;
				switch (num2 == num)
				{
				}
				num = (short)398065665;
				if (num != 0)
				{
				}
				num = (short)263389184;
				if (num != 0)
				{
				}
				num = (short)418775040;
				short num3 = num;
				return (Color)base.GetValue(ColorsDialog.CurrentColorProperty);
			}
			set
			{
				short num = (short)1032220667;
				short num2 = num;
				num = (short)499609595;
				switch (num2 == num)
				{
				}
				num = (short)504168449;
				if (num != 0)
				{
				}
				num = (short)906231808;
				if (num != 0)
				{
				}
				num = (short)1694629888;
				short num3 = num;
				base.SetValue(ColorsDialog.CurrentColorProperty, value);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00014904 File Offset: 0x00012B04
		private static void b(DependencyObject A_0, DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1121779712;
			short num2 = num;
			num = (short)1728578731;
			short num3 = num;
			num = (short)910754987;
			ColorsDialog colorsDialog;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E8:
				colorsDialog.OnCurrentColorChanged((Color)A_1.OldValue, (Color)A_1.NewValue);
				num = (short)685441025;
				num4 = (int)((IntPtr)num);
				break;
			default:
				num = (short)1445789696;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				break;
			}
			for (;;)
			{
				IL_7C:
				switch (num4)
				{
				case 0:
					goto IL_E8;
				case 1:
					return;
				case 2:
					if (colorsDialog != null)
					{
						num = (short)1322975233;
						if (num != 0)
						{
						}
						num = (short)1410400256;
						num4 = (int)((IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_8E;
			}
			return;
			IL_8E:
			colorsDialog = (A_0 as ColorsDialog);
			num = (short)1800404994;
			num4 = (int)((IntPtr)num);
			goto IL_7C;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00014A34 File Offset: 0x00012C34
		protected virtual void OnCurrentColorChanged(Color oldValue, Color newValue)
		{
			short num;
			for (;;)
			{
				this.a = true;
				try
				{
					this.CurrentColorBrush = new SolidColorBrush(newValue);
					this.g.Value = new int?((int)newValue.R);
					this.h.Value = new int?((int)newValue.G);
					this.i.Value = new int?((int)newValue.B);
					this.k.SelectedColor = new Color?(newValue);
				}
				finally
				{
					this.a = false;
				}
				num = (short)953255608;
				short num2 = num;
				num = (short)1250985656;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A9;
				}
			}
			IL_A9:
			num = (short)476643329;
			if (num != 0)
			{
			}
			num = (short)1246822400;
			short num3 = num;
			num = (short)1609629696;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00014B64 File Offset: 0x00012D64
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00014C20 File Offset: 0x00012E20
		public Brush CurrentColorBrush
		{
			get
			{
				short num = (short)1575541004;
				short num2 = num;
				num = (short)491641100;
				switch (num2 == num)
				{
				}
				num = (short)700186625;
				if (num != 0)
				{
				}
				num = (short)596770816;
				if (num != 0)
				{
				}
				num = (short)37093376;
				short num3 = num;
				return (Brush)base.GetValue(ColorsDialog.CurrentColorBrushProperty);
			}
			internal set
			{
				short num = (short)1712914433;
				if (num != 0)
				{
				}
				num = (short)152579210;
				short num2 = num;
				num = (short)836250762;
				switch (num2 == num)
				{
				}
				num = (short)632356864;
				if (num != 0)
				{
				}
				num = (short)862060544;
				short num3 = num;
				base.SetValue(ColorsDialog.b, value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00014CD8 File Offset: 0x00012ED8
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00014D90 File Offset: 0x00012F90
		public Color? SelectedColor
		{
			get
			{
				short num = (short)1640196382;
				short num2 = num;
				num = (short)2062182686;
				switch (num2 == num)
				{
				}
				num = (short)576847872;
				if (num != 0)
				{
				}
				num = (short)1439956993;
				if (num != 0)
				{
				}
				num = (short)371720192;
				short num3 = num;
				return (Color?)base.GetValue(ColorsDialog.SelectedColorProperty);
			}
			set
			{
				short num = (short)1404867725;
				short num2 = num;
				num = (short)375231629;
				switch (num2 == num)
				{
				}
				num = (short)562626560;
				if (num != 0)
				{
				}
				num = (short)1789853697;
				if (num != 0)
				{
				}
				num = (short)2119368704;
				short num3 = num;
				base.SetValue(ColorsDialog.SelectedColorProperty, value);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00014E4C File Offset: 0x0001304C
		private static void a(DependencyObject A_0, DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1918566400;
			short num2 = num;
			num = (short)1189081548;
			short num3 = num;
			num = (short)1603400140;
			ColorsDialog colorsDialog;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_EC:
				colorsDialog.OnSelectedColorChanged((Color?)A_1.OldValue, (Color?)A_1.NewValue);
				num = (short)1674575873;
				num4 = (int)((IntPtr)num);
				break;
			default:
				num = (short)1189740544;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_B7;
				}
				break;
			}
			for (;;)
			{
				IL_7F:
				num = (short)1647771649;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					goto IL_EC;
				case 1:
					return;
				case 2:
					if (colorsDialog != null)
					{
						num = (short)752746496;
						num4 = (int)((IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_B7;
			}
			return;
			IL_B7:
			colorsDialog = (A_0 as ColorsDialog);
			num = (short)956825602;
			num4 = (int)((IntPtr)num);
			goto IL_7F;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00014F80 File Offset: 0x00013180
		protected virtual void OnSelectedColorChanged(Color? oldValue, Color? newValue)
		{
			if (newValue == null)
			{
				short num = (short)1253310465;
				if (num != 0)
				{
				}
				num = (short)1363530679;
				short num2 = num;
				num = (short)1417532343;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AB;
				case 1:
					break;
				default:
				{
					num = (short)503775232;
					short num3 = num;
					break;
				}
				}
				num = (short)1010958336;
				if (num != 0)
				{
				}
				IL_AB:
				this.SelectedColorBrush = null;
				this.g.Value = null;
				this.h.Value = null;
				this.i.Value = null;
				return;
			}
			this.SelectedColorBrush = new SolidColorBrush(newValue.Value);
			this.g.Value = new int?((int)newValue.Value.R);
			this.h.Value = new int?((int)newValue.Value.G);
			this.i.Value = new int?((int)newValue.Value.B);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000150EC File Offset: 0x000132EC
		// (set) Token: 0x06000108 RID: 264 RVA: 0x000151A8 File Offset: 0x000133A8
		public Brush SelectedColorBrush
		{
			get
			{
				short num = (short)1945268505;
				short num2 = num;
				num = (short)1660776729;
				switch (num2 == num)
				{
				}
				num = (short)1055522816;
				if (num != 0)
				{
				}
				num = (short)119013377;
				if (num != 0)
				{
				}
				num = (short)525729792;
				short num3 = num;
				return (Brush)base.GetValue(ColorsDialog.SelectedColorBrushProperty);
			}
			internal set
			{
				short num = (short)1481280547;
				short num2 = num;
				num = (short)647334947;
				switch (num2 == num)
				{
				}
				num = (short)176619520;
				if (num != 0)
				{
				}
				num = (short)460390401;
				if (num != 0)
				{
				}
				num = (short)2063138816;
				short num3 = num;
				base.SetValue(ColorsDialog.c, value);
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00015260 File Offset: 0x00013460
		public ColorsDialog()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00015279 File Offset: 0x00013479
		public void ColorComb_SelectedColorChanged(object sender, RoutedEventArgs e)
		{
			this.SelectedColor = this.f.SelectedColor;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0001528C File Offset: 0x0001348C
		public void ColorBlender1_SelectedColorChanged(object sender, RoutedEventArgs e)
		{
			this.SelectedColor = this.k.SelectedColor;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0001529F File Offset: 0x0001349F
		public void ColorContrast1_SelectedColorChanged(object sender, RoutedEventArgs e)
		{
			this.SelectedColor = this.j.SelectedColor;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000152B2 File Offset: 0x000134B2
		public void OkButton_Click(object sender, RoutedEventArgs e)
		{
			base.DialogResult = new bool?(true);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000152C0 File Offset: 0x000134C0
		public void CancelButton_Click(object sender, RoutedEventArgs e)
		{
			base.DialogResult = new bool?(false);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000152D0 File Offset: 0x000134D0
		public void RedInputValueChanged(object sender, RoutedEventArgs e)
		{
			if (this.a)
			{
				return;
			}
			IntegerInput integerInput = (IntegerInput)sender;
			if (this.SelectedColor == null && integerInput.Value == null)
			{
				return;
			}
			Color color = (this.SelectedColor != null) ? this.SelectedColor.Value : Color.FromArgb(byte.MaxValue, byte.MaxValue, (byte)((this.h.Value != null) ? this.h.Value.Value : 255), (byte)((this.i.Value != null) ? this.i.Value.Value : 255));
			int? value = integerInput.Value;
			int r = (int)color.R;
			if (!(value.GetValueOrDefault() == r & value != null))
			{
				this.SelectedColor = new Color?(Color.FromArgb(color.A, (byte)integerInput.Value.Value, color.G, color.B));
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000153F8 File Offset: 0x000135F8
		public void BlueInputValueChanged(object sender, RoutedEventArgs e)
		{
			if (this.a)
			{
				return;
			}
			IntegerInput integerInput = (IntegerInput)sender;
			if (this.SelectedColor == null && integerInput.Value == null)
			{
				return;
			}
			Color color = (this.SelectedColor != null) ? this.SelectedColor.Value : Color.FromArgb(byte.MaxValue, (byte)((this.g.Value != null) ? this.g.Value.Value : 255), (byte)((this.h.Value != null) ? this.h.Value.Value : 255), byte.MaxValue);
			int? value = integerInput.Value;
			int num = (int)color.B;
			if (!(value.GetValueOrDefault() == num & value != null))
			{
				this.SelectedColor = new Color?(Color.FromArgb(color.A, color.R, color.G, (byte)integerInput.Value.Value));
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00015520 File Offset: 0x00013720
		public void GreenInputValueChanged(object sender, RoutedEventArgs e)
		{
			if (this.a)
			{
				return;
			}
			IntegerInput integerInput = (IntegerInput)sender;
			if (this.SelectedColor == null && integerInput.Value == null)
			{
				return;
			}
			Color color = (this.SelectedColor != null) ? this.SelectedColor.Value : Color.FromArgb(byte.MaxValue, (byte)((this.g.Value != null) ? this.g.Value.Value : 255), byte.MaxValue, (byte)((this.i.Value != null) ? this.i.Value.Value : 255));
			int? value = integerInput.Value;
			int num = (int)color.G;
			if (!(value.GetValueOrDefault() == num & value != null))
			{
				this.SelectedColor = new Color?(Color.FromArgb(color.A, color.R, (byte)integerInput.Value.Value, color.B));
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0001572C File Offset: 0x0001392C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		internal Delegate a(Type A_0, string A_1)
		{
			short num = (short)259167293;
			short num2 = num;
			num = (short)1034589245;
			switch (num2 == num)
			{
			}
			num = (short)294453248;
			if (num != 0)
			{
			}
			num = (short)287965185;
			if (num != 0)
			{
			}
			num = (short)1002504192;
			short num3 = num;
			return Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000159B8 File Offset: 0x00013BB8
		// Note: this type is marked as 'beforefieldinit'.
		static ColorsDialog()
		{
			int a_ = 5;
			short num = (short)2140143617;
			if (num != 0)
			{
			}
			num = (short)249093556;
			short num2 = num;
			num = (short)2121326004;
			switch (num2 == num)
			{
			}
			num = (short)935919616;
			if (num != 0)
			{
			}
			num = (short)602865664;
			short num3 = num;
			ColorsDialog.CurrentColorProperty = DependencyProperty.Register(NumericYearInput.b("金ꇓꓕ꫗뿙닛ꫝꏟ跡裣觥髧", a_), typeof(Color), typeof(ColorsDialog), new UIPropertyMetadata(Colors.White, new PropertyChangedCallback(ColorsDialog.b)));
			ColorsDialog.b = DependencyProperty.RegisterReadOnly(NumericYearInput.b("金ꇓꓕ꫗뿙닛ꫝꏟ跡裣觥髧꣩黫鯭華髱", a_), typeof(Brush), typeof(ColorsDialog), new UIPropertyMetadata(null));
			ColorsDialog.CurrentColorBrushProperty = ColorsDialog.b.DependencyProperty;
			ColorsDialog.SelectedColorProperty = DependencyProperty.Register(NumericYearInput.b("臑뇓뫕뷗맙꣛믝蓟ꇡ诣諥蟧飩", a_), typeof(Color?), typeof(ColorsDialog), new UIPropertyMetadata(null, new PropertyChangedCallback(ColorsDialog.a)));
			ColorsDialog.c = DependencyProperty.RegisterReadOnly(NumericYearInput.b("臑뇓뫕뷗맙꣛믝蓟ꇡ诣諥蟧飩껫鳭藯臱鳳", a_), typeof(Brush), typeof(ColorsDialog), new UIPropertyMetadata(null));
			ColorsDialog.SelectedColorBrushProperty = ColorsDialog.c.DependencyProperty;
		}

		// Token: 0x04000041 RID: 65
		public static readonly DependencyProperty CurrentColorProperty;

		// Token: 0x04000042 RID: 66
		private bool a;

		// Token: 0x04000043 RID: 67
		private static readonly DependencyPropertyKey b;

		// Token: 0x04000044 RID: 68
		public static readonly DependencyProperty CurrentColorBrushProperty;

		// Token: 0x04000045 RID: 69
		public static readonly DependencyProperty SelectedColorProperty;

		// Token: 0x04000046 RID: 70
		private static readonly DependencyPropertyKey c;

		// Token: 0x04000047 RID: 71
		public static readonly DependencyProperty SelectedColorBrushProperty;
	}
}
