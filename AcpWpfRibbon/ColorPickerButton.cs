using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000024 RID: 36
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ColorPickerButton : global::DevComponents.WpfRibbon.ButtonDropDown
	{
		// Token: 0x060002A9 RID: 681 RVA: 0x0003D180 File Offset: 0x0003B380
		private static void OnSelectedColorChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfRibbon.ColorPickerButton colorPickerButton;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (colorPickerButton != null)
					{
						num2 = (short)1270218752;
						short num3 = num2;
						num2 = (short)1423441921;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)1608065136;
					short num4 = num2;
					num2 = (short)1216356464;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)421199872;
						if (num2 != 0)
						{
						}
						colorPickerButton.OnSelectedColorChanged((global::System.Windows.Media.Color?)e.OldValue, (global::System.Windows.Media.Color?)e.NewValue);
						num2 = (short)1691353090;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)1463681025;
			if (num2 != 0)
			{
			}
			colorPickerButton = (o as global::DevComponents.WpfRibbon.ColorPickerButton);
			num2 = (short)2046885888;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0003D2B8 File Offset: 0x0003B4B8
		protected virtual void OnSelectedColorChanged(global::System.Windows.Media.Color? oldValue, global::System.Windows.Media.Color? newValue)
		{
			short num = (short)520880129;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1821966337;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)642620915;
					short num3 = num;
					num = (short)414096883;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A8;
					default:
					{
						num = (short)1961426944;
						if (num != 0)
						{
						}
						num = (short)1837694976;
						short num4 = num;
						goto IL_89;
					}
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					continue;
				case 2:
					if (base.IsPopupOpen)
					{
						num = (short)1599143941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A8;
				case 3:
					goto IL_89;
				case 4:
					this.SelectedColorBrush = null;
					num = (short)152043520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					base.IsPopupOpen = false;
					num = (short)1807876102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_1A6;
				}
				IL_69:
				if (newValue == null)
				{
					num = (short)621346820;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.SelectedColorBrush = new global::System.Windows.Media.SolidColorBrush(newValue.Value);
				num = (short)1767899139;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_89:
				num = (short)1047330818;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1A6:
			IL_1A8:
			global::DevComponents.WpfRibbon.ButtonDropDown.ExecuteCommand(this);
			this.OnSelectedColorChanged();
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0003D47C File Offset: 0x0003B67C
		// (set) Token: 0x060002AC RID: 684 RVA: 0x0003D534 File Offset: 0x0003B734
		public global::System.Windows.Media.Color? SelectedColor
		{
			get
			{
				short num = (short)418277845;
				short num2 = num;
				num = (short)1134455253;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2025586688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2146893824;
				if (num != 0)
				{
				}
				num = (short)1281818625;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Color?)base.GetValue(global::DevComponents.WpfRibbon.ColorPickerButton.SelectedColorProperty);
			}
			set
			{
				short num = (short)629866497;
				if (num != 0)
				{
				}
				num = (short)405274624;
				short num2 = num;
				num = (short)215204336;
				short num3 = num;
				num = (short)1354744304;
				switch (num3 == num)
				{
				}
				num = (short)851050496;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ColorPickerButton.SelectedColorProperty, value);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060002AD RID: 685 RVA: 0x0003D5F0 File Offset: 0x0003B7F0
		// (remove) Token: 0x060002AE RID: 686 RVA: 0x0003D6A4 File Offset: 0x0003B8A4
		public event global::System.Windows.RoutedEventHandler SelectedColorChanged
		{
			add
			{
				short num = (short)862523124;
				short num2 = num;
				num = (short)579079924;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1872363520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)366084097;
				if (num != 0)
				{
				}
				num = (short)1645346816;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.ColorPickerButton.SelectedColorChangedEvent, value);
			}
			remove
			{
				short num = (short)1452809029;
				short num2 = num;
				num = (short)1261640517;
				switch (num2 == num)
				{
				default:
				{
					num = (short)368640000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)527237120;
				if (num != 0)
				{
				}
				num = (short)1256718337;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.ColorPickerButton.SelectedColorChangedEvent, value);
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0003D75C File Offset: 0x0003B95C
		protected virtual void OnSelectedColorChanged()
		{
			short num = (short)105631955;
			short num2 = num;
			num = (short)1131466963;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1576140800;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1347289089;
			if (num != 0)
			{
			}
			num = (short)569638912;
			if (num != 0)
			{
			}
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.ColorPickerButton.SelectedColorChangedEvent);
			base.RaiseEvent(e);
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0003D814 File Offset: 0x0003BA14
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x0003D8CC File Offset: 0x0003BACC
		public global::System.Windows.Media.Brush SelectedColorBrush
		{
			get
			{
				short num = (short)75431937;
				if (num != 0)
				{
				}
				num = (short)1517551616;
				short num2 = num;
				num = (short)1118803492;
				short num3 = num;
				num = (short)1087215140;
				switch (num3 == num)
				{
				}
				num = (short)1536229376;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.ColorPickerButton.SelectedColorBrushProperty);
			}
			internal set
			{
				short num = (short)1304887297;
				if (num != 0)
				{
				}
				num = (short)2113601536;
				short num2 = num;
				num = (short)2085021993;
				short num3 = num;
				num = (short)491579689;
				switch (num3 == num)
				{
				}
				num = (short)750911488;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ColorPickerButton.SelectedColorBrushPropertyKey, value);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0003D980 File Offset: 0x0003BB80
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x0003DA38 File Offset: 0x0003BC38
		public double ColorSwatchWidth
		{
			get
			{
				short num = (short)439130377;
				short num2 = num;
				num = (short)1427544329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)881197056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2146762753;
				if (num != 0)
				{
				}
				num = (short)144506880;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfRibbon.ColorPickerButton.ColorSwatchWidthProperty);
			}
			set
			{
				short num = (short)216931290;
				short num2 = num;
				num = (short)771693530;
				switch (num2 == num)
				{
				default:
				{
					num = (short)406781952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1373306881;
				if (num != 0)
				{
				}
				num = (short)161021952;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ColorPickerButton.ColorSwatchWidthProperty, value);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0003DAF4 File Offset: 0x0003BCF4
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x0003DBB0 File Offset: 0x0003BDB0
		public double ColorSwatchHeight
		{
			get
			{
				short num = (short)1126432769;
				if (num != 0)
				{
				}
				num = (short)1355939840;
				short num2 = num;
				num = (short)179278232;
				short num3 = num;
				num = (short)1596363160;
				switch (num3 == num)
				{
				}
				num = (short)1131282432;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfRibbon.ColorPickerButton.ColorSwatchHeightProperty);
			}
			set
			{
				short num = (short)2104961625;
				short num2 = num;
				num = (short)369437273;
				switch (num2 == num)
				{
				default:
				{
					num = (short)777322496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1007943681;
				if (num != 0)
				{
				}
				num = (short)1998716928;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ColorPickerButton.ColorSwatchHeightProperty, value);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0003DC6C File Offset: 0x0003BE6C
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x0003DD28 File Offset: 0x0003BF28
		public global::DevComponents.WpfRibbon.eButtonImagePosition ColorSwatchPosition
		{
			get
			{
				short num = (short)953965569;
				short num2 = num;
				num = (short)911105025;
				switch (num2 == num)
				{
				default:
				{
					num = (short)591659008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2752513;
				if (num != 0)
				{
				}
				num = (short)946274304;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eButtonImagePosition)base.GetValue(global::DevComponents.WpfRibbon.ColorPickerButton.ColorSwatchPositionProperty);
			}
			set
			{
				short num = (short)52913303;
				short num2 = num;
				num = (short)888366231;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2035875840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1358954497;
				if (num != 0)
				{
				}
				num = (short)496828416;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ColorPickerButton.ColorSwatchPositionProperty, value);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0003DDE0 File Offset: 0x0003BFE0
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0003DE9C File Offset: 0x0003C09C
		public bool ColorSwatchBorder
		{
			get
			{
				short num = (short)943704311;
				short num2 = num;
				num = (short)590268663;
				switch (num2 == num)
				{
				default:
				{
					num = (short)140509184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1464860672;
				if (num != 0)
				{
				}
				num = (short)979632129;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ColorPickerButton.ColorSwatchBorderProperty);
			}
			set
			{
				short num = (short)1222683731;
				short num2 = num;
				num = (short)656976979;
				switch (num2 == num)
				{
				default:
				{
					num = (short)907149312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1418461184;
				if (num != 0)
				{
				}
				num = (short)1557528577;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ColorPickerButton.ColorSwatchBorderProperty, value);
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0003DF58 File Offset: 0x0003C158
		static ColorPickerButton()
		{
			int a_ = 17;
			short num = (short)1237789447;
			short num2 = num;
			num = (short)2092641031;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1056440320;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1643315201;
			if (num != 0)
			{
			}
			num = (short)1585381376;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.ColorPickerButton.SelectedColorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㩨๪Ŭ੮ተݲၴ፶㩸ᑺᅼၾ", a_), typeof(global::System.Windows.Media.Color?), typeof(global::DevComponents.WpfRibbon.ColorPickerButton), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ColorPickerButton.OnSelectedColorChanged)));
			global::DevComponents.WpfRibbon.ColorPickerButton.SelectedColorChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㩨๪Ŭ੮ተݲၴ፶㩸ᑺᅼၾ삂", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfRibbon.ColorPickerButton));
			global::DevComponents.WpfRibbon.ColorPickerButton.SelectedColorBrushPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㩨๪Ŭ੮ተݲၴ፶㩸ᑺᅼၾ솂愈", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.ColorPickerButton), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfRibbon.ColorPickerButton.SelectedColorBrushProperty = global::DevComponents.WpfRibbon.ColorPickerButton.SelectedColorBrushPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.ColorPickerButton.ColorSwatchWidthProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⩨ѪŬnͰ⁲ɴᙶ൸᡺ᕼ⡾", a_), typeof(double), typeof(global::DevComponents.WpfRibbon.ColorPickerButton), new global::System.Windows.UIPropertyMetadata(14.0));
			global::DevComponents.WpfRibbon.ColorPickerButton.ColorSwatchHeightProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⩨ѪŬnͰ⁲ɴᙶ൸᡺ᕼ㝾ﶈ", a_), typeof(double), typeof(global::DevComponents.WpfRibbon.ColorPickerButton), new global::System.Windows.UIPropertyMetadata(14.0));
			global::DevComponents.WpfRibbon.ColorPickerButton.ColorSwatchPositionProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⩨ѪŬnͰ⁲ɴᙶ൸᡺ᕼ⽾", a_), typeof(global::DevComponents.WpfRibbon.eButtonImagePosition), typeof(global::DevComponents.WpfRibbon.ColorPickerButton), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfRibbon.eButtonImagePosition.Left));
			global::DevComponents.WpfRibbon.ColorPickerButton.ColorSwatchBorderProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⩨ѪŬnͰ⁲ɴᙶ൸᡺ᕼ㵾ﮈ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ColorPickerButton), new global::System.Windows.UIPropertyMetadata(true));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.ColorPickerButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.ColorPickerButton)));
		}

		// Token: 0x040000E4 RID: 228
		public static readonly global::System.Windows.DependencyProperty SelectedColorProperty;

		// Token: 0x040000E6 RID: 230
		private static readonly global::System.Windows.DependencyPropertyKey SelectedColorBrushPropertyKey;

		// Token: 0x040000E7 RID: 231
		public static readonly global::System.Windows.DependencyProperty SelectedColorBrushProperty;

		// Token: 0x040000E8 RID: 232
		public static readonly global::System.Windows.DependencyProperty ColorSwatchWidthProperty;

		// Token: 0x040000E9 RID: 233
		public static readonly global::System.Windows.DependencyProperty ColorSwatchHeightProperty;

		// Token: 0x040000EA RID: 234
		public static readonly global::System.Windows.DependencyProperty ColorSwatchPositionProperty;

		// Token: 0x040000EB RID: 235
		public static readonly global::System.Windows.DependencyProperty ColorSwatchBorderProperty;
	}
}
