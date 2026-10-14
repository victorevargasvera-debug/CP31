using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000053 RID: 83
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ColorInputDropDownButton : global::DevComponents.WpfEditors.Primitives.EditorPopupButton
	{
		// Token: 0x1400001B RID: 27
		// (add) Token: 0x0600050E RID: 1294 RVA: 0x00066BF4 File Offset: 0x00064DF4
		// (remove) Token: 0x0600050F RID: 1295 RVA: 0x00066CA8 File Offset: 0x00064EA8
		public event global::System.Windows.RoutedEventHandler SelectedColorChanged
		{
			add
			{
				short num = (short)2039187335;
				short num2 = num;
				num = (short)333219719;
				switch (num2 == num)
				{
				}
				num = (short)1956642817;
				if (num != 0)
				{
				}
				num = (short)1113522176;
				if (num != 0)
				{
				}
				num = (short)1669595136;
				short num3 = num;
				base.AddHandler(global::DevComponents.WpfEditors.Primitives.ColorInputDropDownButton.SelectedColorChangedEvent, value);
			}
			remove
			{
				short num = (short)1829476606;
				short num2 = num;
				num = (short)1204984062;
				switch (num2 == num)
				{
				}
				num = (short)1728905216;
				if (num != 0)
				{
				}
				num = (short)1352925185;
				if (num != 0)
				{
				}
				num = (short)114294784;
				short num3 = num;
				base.RemoveHandler(global::DevComponents.WpfEditors.Primitives.ColorInputDropDownButton.SelectedColorChangedEvent, value);
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00066D60 File Offset: 0x00064F60
		protected virtual void OnSelectedColorChanged()
		{
			short num = (short)1761144391;
			short num2 = num;
			num = (short)2047340103;
			switch (num2 == num)
			{
			}
			num = (short)900792320;
			if (num != 0)
			{
			}
			num = (short)2142896129;
			if (num != 0)
			{
			}
			num = (short)1836843008;
			short num3 = num;
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.Primitives.ColorInputDropDownButton.SelectedColorChangedEvent);
			base.RaiseEvent(e);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00066E1C File Offset: 0x0006501C
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_8D;
			}
			short num;
			int num4;
			global::DevComponents.WpfEditors.Primitives.ColorInputDropDownButton colorInputDropDownButton;
			for (;;)
			{
				IL_0A:
				num = (short)23344780;
				short num2 = num;
				num = (short)359544460;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)1034223616;
					if (num != 0)
					{
					}
					num = (short)732561408;
					short num3 = num;
					switch (num4)
					{
					case 0:
						colorInputDropDownButton.OnSelectedColorChanged((global::System.Windows.Media.Color?)A_1.OldValue, (global::System.Windows.Media.Color?)A_1.NewValue);
						num = (short)457441282;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)938475521;
						if (num != 0)
						{
						}
						if (colorInputDropDownButton != null)
						{
							num = (short)593690624;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					}
					goto IL_8D;
				}
				}
			}
			return;
			IL_8D:
			colorInputDropDownButton = (A_0 as global::DevComponents.WpfEditors.Primitives.ColorInputDropDownButton);
			num = (short)178847745;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00066F54 File Offset: 0x00065154
		protected virtual void OnSelectedColorChanged(global::System.Windows.Media.Color? oldValue, global::System.Windows.Media.Color? newValue)
		{
			switch (0)
			{
			case 0:
				goto IL_91;
			}
			short num;
			int num4;
			for (;;)
			{
				IL_0A:
				num = (short)499435107;
				short num2 = num;
				num = (short)274515555;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)2015887360;
					if (num != 0)
					{
					}
					num = (short)571408384;
					short num3 = num;
					switch (num4)
					{
					case 0:
						num = (short)1002569729;
						if (num != 0)
						{
						}
						this.a.SelectedColor = newValue;
						num = (short)146735106;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (this.a != null)
						{
							num = (short)140640256;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					}
					goto IL_91;
				}
				}
			}
			return;
			IL_91:
			this.OnSelectedColorChanged();
			num = (short)781320193;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x0006707C File Offset: 0x0006527C
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x00067134 File Offset: 0x00065334
		public global::System.Windows.Media.Color? SelectedColor
		{
			get
			{
				short num = (short)156383594;
				short num2 = num;
				num = (short)1290484074;
				switch (num2 == num)
				{
				}
				num = (short)1999503360;
				if (num != 0)
				{
				}
				num = (short)612040705;
				if (num != 0)
				{
				}
				num = (short)567017472;
				short num3 = num;
				return (global::System.Windows.Media.Color?)base.GetValue(global::DevComponents.WpfEditors.Primitives.ColorInputDropDownButton.SelectedColorProperty);
			}
			set
			{
				short num = (short)1344591995;
				short num2 = num;
				num = (short)2088556667;
				switch (num2 == num)
				{
				}
				num = (short)1246035969;
				if (num != 0)
				{
				}
				num = (short)302514176;
				if (num != 0)
				{
				}
				num = (short)1244397568;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.Primitives.ColorInputDropDownButton.SelectedColorProperty, value);
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000671F0 File Offset: 0x000653F0
		static ColorInputDropDownButton()
		{
			int a_ = 1;
			short num = (short)1530658817;
			if (num != 0)
			{
			}
			num = (short)1030506359;
			short num2 = num;
			num = (short)328746871;
			switch (num2 == num)
			{
			}
			num = (short)1571487744;
			if (num != 0)
			{
			}
			num = (short)516816896;
			short num3 = num;
			global::DevComponents.WpfEditors.Primitives.ColorInputDropDownButton.SelectedColorChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷍뗏뻑뇓뗕곗뿙룛鷝迟軡诣铥ꯧ苩跫胭韯韱郳", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.Primitives.ColorInputDropDownButton));
			global::DevComponents.WpfEditors.Primitives.ColorInputDropDownButton.SelectedColorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷍뗏뻑뇓뗕곗뿙룛鷝迟軡诣铥", a_), typeof(global::System.Windows.Media.Color?), typeof(global::DevComponents.WpfEditors.Primitives.ColorInputDropDownButton), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.ColorInputDropDownButton.a)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.Primitives.ColorInputDropDownButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.Primitives.ColorInputDropDownButton)));
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00067330 File Offset: 0x00065530
		public override void OnApplyTemplate()
		{
			int a_ = 19;
			short num = (short)942931972;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_FF;
				case 1:
					if (this.a != null)
					{
						num = (short)554827781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F8;
				case 2:
					goto IL_AF;
				case 3:
					goto IL_FA;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_47;
					}
					continue;
				case 5:
				{
					num = (short)1288896513;
					if (num != 0)
					{
					}
					num = (short)703463424;
					short num3 = num;
					this.a.IsKeyboardFocusWithinChanged += this.a;
					this.a.SelectedColorChanged += this.a;
					num = (short)1610350595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_47:
				num = (short)1129039129;
				short num4 = num;
				num = (short)1022739737;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AF:
					this.a.IsKeyboardFocusWithinChanged -= this.a;
					this.a.SelectedColorChanged -= this.a;
					num = (short)1896153088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)1334509568;
					if (num != 0)
					{
					}
					if (this.a != null)
					{
						num = (short)185073666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_FF:
				this.a = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("냟ꏡ뛣닥럧ꧩ菫苭鿯胱ꟳ鏵铷鿹鿻諽濿瀁", a_)) as global::DevComponents.WpfEditors.ColorItemSelector);
				num = (short)1368522753;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FA:
			IL_1F8:
			base.OnApplyTemplate();
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0006753C File Offset: 0x0006573C
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1422393345;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1120665601;
					if (num != 0)
					{
					}
					this.SelectedColor = this.a.SelectedColor;
					num = (short)1209204738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_15;
				case 2:
				{
					num = (short)11795118;
					short num3 = num;
					num = (short)1793850030;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						goto IL_108;
					}
					break;
				}
				}
				goto IL_31;
				IL_15:
				switch (0)
				{
				case 0:
				{
					IL_31:
					if (A_1.Source != this.a)
					{
						return;
					}
					num = (short)1369899008;
					short num4 = num;
					num = (short)435224576;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_108:
			num = (short)1087504384;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00067668 File Offset: 0x00065868
		private void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1233453059;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.ClosePopup();
					num = (short)914292737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					num = (short)1199898628;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 4:
					if (base.IsPopupOpen)
					{
						num = (short)1979842560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				for (;;)
				{
					IL_39:
					num = (short)979107840;
					short num3 = num;
					if (this.a.IsKeyboardFocusWithin)
					{
						return;
					}
					num = (short)2138230902;
					short num4 = num;
					num = (short)2024067190;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_A6;
					}
				}
				IL_A6:
				num = (short)1174929408;
				if (num != 0)
				{
				}
				num = (short)288227329;
				if (num != 0)
				{
				}
				num = (short)1110310914;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x000677CC File Offset: 0x000659CC
		protected override void AfterPopupOpen()
		{
			short num = (short)2078539777;
			if (num != 0)
			{
			}
			num = (short)765853697;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.a.Focus();
					num = (short)521797634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_3D;
				case 2:
				{
					num = (short)182128236;
					short num3 = num;
					num = (short)1746669164;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D;
					default:
						goto IL_F8;
					}
					break;
				}
				}
				goto IL_59;
				IL_3D:
				switch (0)
				{
				case 0:
				{
					IL_59:
					num = (short)1657274368;
					short num4 = num;
					if (this.a == null)
					{
						goto IL_110;
					}
					num = (short)29753344;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_F8:
			num = (short)1773207552;
			if (num != 0)
			{
			}
			IL_110:
			base.AfterPopupOpen();
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000678F0 File Offset: 0x00065AF0
		protected override void OnPopupClosed()
		{
			short num = (short)966030541;
			short num2 = num;
			num = (short)1213494477;
			switch (num2 == num)
			{
			}
			num = (short)1665466369;
			if (num != 0)
			{
			}
			num = (short)1703280640;
			if (num != 0)
			{
			}
			num = (short)1152909312;
			short num3 = num;
			this.a(true);
			base.OnPopupClosed();
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000679A4 File Offset: 0x00065BA4
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1127182553;
			short num2 = num;
			num = (short)1505587417;
			switch (num2 == num)
			{
			}
			num = (short)1372717057;
			if (num != 0)
			{
			}
			num = (short)1228931072;
			if (num != 0)
			{
			}
			num = (short)1520828416;
			short num3 = num;
			this.a(false);
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00067A5C File Offset: 0x00065C5C
		private void a(bool A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::System.Windows.FrameworkElement frameworkElement;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_1A8;
				case 1:
					goto IL_E5;
				case 2:
					goto IL_117;
				case 3:
					if (frameworkElement == null)
					{
						num2 = (short)949878786;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1232470020;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (frameworkElement is global::DevComponents.WpfEditors.Primitives.EditorGroup)
					{
						num2 = (short)1409744901;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					frameworkElement = (frameworkElement.Parent as global::System.Windows.FrameworkElement);
					num2 = (short)1180041217;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					num2 = (short)1601649678;
					short num3 = num2;
					num2 = (short)256326670;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)2067333120;
						if (num2 != 0)
						{
						}
						num2 = (short)139788295;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					goto IL_E5;
				case 7:
					if (!((global::DevComponents.WpfEditors.Primitives.EditorGroup)frameworkElement).IsKeyboardFocusWithin || A_0)
					{
						num2 = (short)1714421760;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AD;
				}
				goto IL_30;
				IL_E5:
				num2 = (short)177405955;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_117:
			goto IL_1AD;
			IL_1A8:
			((global::DevComponents.WpfEditors.Primitives.EditorGroup)frameworkElement).FocusFirstInput();
			return;
			IL_1AD:
			num2 = (short)2029060096;
			short num4 = num2;
			return;
			IL_30:
			num2 = (short)1685323777;
			if (num2 != 0)
			{
			}
			frameworkElement = (base.Parent as global::System.Windows.FrameworkElement);
			num2 = (short)186580998;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400026E RID: 622
		public static readonly global::System.Windows.DependencyProperty SelectedColorProperty;

		// Token: 0x0400026F RID: 623
		private global::DevComponents.WpfEditors.ColorItemSelector a;
	}
}
