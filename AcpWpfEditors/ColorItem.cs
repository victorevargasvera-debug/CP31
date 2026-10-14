using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x0200000F RID: 15
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ColorItem : global::DevComponents.WpfEditors.SelectableControl
	{
		// Token: 0x060000CC RID: 204 RVA: 0x0001125C File Offset: 0x0000F45C
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.ColorItem colorItem;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					colorItem.OnColorChanged((global::System.Windows.Media.Color)A_1.OldValue, (global::System.Windows.Media.Color)A_1.NewValue);
					num2 = (short)1500070375;
					short num3 = num2;
					num2 = (short)2088387047;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)424804352;
						if (num2 != 0)
						{
						}
						num2 = (short)1647902721;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					if (colorItem != null)
					{
						num2 = (short)1597767680;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)148439041;
			if (num2 != 0)
			{
			}
			num2 = (short)2145452032;
			short num4 = num2;
			colorItem = (A_0 as global::DevComponents.WpfEditors.ColorItem);
			num2 = (short)1898119170;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00011398 File Offset: 0x0000F598
		protected virtual void OnColorChanged(global::System.Windows.Media.Color oldValue, global::System.Windows.Media.Color newValue)
		{
			short num = (short)792592385;
			if (num != 0)
			{
			}
			num = (short)2113610376;
			short num2 = num;
			num = (short)488907400;
			switch (num2 == num)
			{
			}
			num = (short)1520500736;
			short num3 = num;
			num = (short)1807024128;
			if (num != 0)
			{
			}
			base.Background = new global::System.Windows.Media.SolidColorBrush(newValue);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0001144C File Offset: 0x0000F64C
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00011504 File Offset: 0x0000F704
		public global::System.Windows.Media.Color Color
		{
			get
			{
				short num = (short)2102079002;
				short num2 = num;
				num = (short)953101850;
				switch (num2 == num)
				{
				}
				num = (short)707461121;
				if (num != 0)
				{
				}
				num = (short)1457651712;
				short num3 = num;
				num = (short)287768576;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Color)base.GetValue(global::DevComponents.WpfEditors.ColorItem.ColorProperty);
			}
			set
			{
				short num = (short)1677663252;
				short num2 = num;
				num = (short)1456413716;
				switch (num2 == num)
				{
				}
				num = (short)906297345;
				if (num != 0)
				{
				}
				num = (short)853999616;
				short num3 = num;
				num = (short)1845952512;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.ColorItem.ColorProperty, value);
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000115BC File Offset: 0x0000F7BC
		static ColorItem()
		{
			int a_ = 18;
			short num = (short)2000155443;
			short num2 = num;
			num = (short)138015539;
			switch (num2 == num)
			{
			}
			num = (short)583467008;
			if (num != 0)
			{
			}
			num = (short)54198272;
			short num3 = num;
			num = (short)1962541057;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.ColorItem.ColorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鳞軠迢諤闦", a_), typeof(global::System.Windows.Media.Color), typeof(global::DevComponents.WpfEditors.ColorItem), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Media.Colors.Transparent, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.ColorItem.a)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.ColorItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.ColorItem)));
		}

		// Token: 0x04000033 RID: 51
		public static readonly global::System.Windows.DependencyProperty ColorProperty;
	}
}
