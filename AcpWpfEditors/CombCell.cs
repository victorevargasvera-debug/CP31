using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000014 RID: 20
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CombCell : global::DevComponents.WpfEditors.SelectableControl
	{
		// Token: 0x06000116 RID: 278 RVA: 0x00015B6C File Offset: 0x00013D6C
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1681063936;
			short num2 = num;
			num = (short)674762625;
			short num3 = num;
			num = (short)1449136001;
			global::DevComponents.WpfEditors.CombCell combCell;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_EA:
				combCell.OnColorChanged((global::System.Windows.Media.Color)A_1.OldValue, (global::System.Windows.Media.Color)A_1.NewValue);
				num = (short)986382337;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1911357440;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_91;
				}
				break;
			}
			for (;;)
			{
				IL_7F:
				switch (num4)
				{
				case 0:
					goto IL_EA;
				case 1:
					return;
				case 2:
					if (combCell != null)
					{
						num = (short)1284243456;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_91;
			}
			return;
			IL_91:
			num = (short)1146748929;
			if (num != 0)
			{
			}
			combCell = (A_0 as global::DevComponents.WpfEditors.CombCell);
			num = (short)2031812610;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7F;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00015C9C File Offset: 0x00013E9C
		protected virtual void OnColorChanged(global::System.Windows.Media.Color oldValue, global::System.Windows.Media.Color newValue)
		{
			short num = (short)639618208;
			short num2 = num;
			num = (short)698666144;
			switch (num2 == num)
			{
			}
			num = (short)2120155137;
			if (num != 0)
			{
			}
			num = (short)1595998208;
			if (num != 0)
			{
			}
			num = (short)776142848;
			short num3 = num;
			base.Background = new global::System.Windows.Media.SolidColorBrush(newValue);
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00015D54 File Offset: 0x00013F54
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00015E10 File Offset: 0x00014010
		public global::System.Windows.Media.Color Color
		{
			get
			{
				short num = (short)19787913;
				short num2 = num;
				num = (short)1393029257;
				switch (num2 == num)
				{
				}
				num = (short)1111687169;
				if (num != 0)
				{
				}
				num = (short)1014169600;
				if (num != 0)
				{
				}
				num = (short)2055667712;
				short num3 = num;
				return (global::System.Windows.Media.Color)base.GetValue(global::DevComponents.WpfEditors.CombCell.ColorProperty);
			}
			set
			{
				short num = (short)2001862657;
				if (num != 0)
				{
				}
				num = (short)723132034;
				short num2 = num;
				num = (short)7937666;
				switch (num2 == num)
				{
				}
				num = (short)2006188032;
				if (num != 0)
				{
				}
				num = (short)562757632;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.CombCell.ColorProperty, value);
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00015EC8 File Offset: 0x000140C8
		static CombCell()
		{
			int a_ = 14;
			short num = (short)1450105086;
			short num2 = num;
			num = (short)207214846;
			switch (num2 == num)
			{
			}
			num = (short)1631846400;
			if (num != 0)
			{
			}
			num = (short)1647050753;
			if (num != 0)
			{
			}
			num = (short)752877568;
			short num3 = num;
			global::DevComponents.WpfEditors.CombCell.ColorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("飚닜돞軠釢", a_), typeof(global::System.Windows.Media.Color), typeof(global::DevComponents.WpfEditors.CombCell), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Media.Colors.Black, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.CombCell.a)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.CombCell), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.CombCell)));
		}

		// Token: 0x04000051 RID: 81
		public static readonly global::System.Windows.DependencyProperty ColorProperty;
	}
}
