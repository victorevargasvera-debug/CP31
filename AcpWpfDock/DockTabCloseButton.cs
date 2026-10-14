using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using DevComponents.WpfDock.Converters;

namespace DevComponents.WpfDock
{
	// Token: 0x02000021 RID: 33
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DockTabCloseButton : global::System.Windows.Controls.Button
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0002B794 File Offset: 0x00029994
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0002B850 File Offset: 0x00029A50
		public bool IsActive
		{
			get
			{
				short num = (short)1381500691;
				short num2 = num;
				num = (short)470419219;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1598685184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)402587649;
				if (num != 0)
				{
				}
				num = (short)648609792;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockTabCloseButton.IsActiveProperty);
			}
			set
			{
				short num = (short)492775103;
				short num2 = num;
				num = (short)1765091007;
				switch (num2 == num)
				{
				default:
				{
					num = (short)183828480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1254096897;
				if (num != 0)
				{
				}
				num = (short)158334976;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockTabCloseButton.IsActiveProperty, value);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0002B90C File Offset: 0x00029B0C
		static DockTabCloseButton()
		{
			int a_ = 4;
			short num = (short)1874146158;
			short num2 = num;
			num = (short)1361785710;
			switch (num2 == num)
			{
			default:
			{
				num = (short)729743360;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1530593281;
			if (num != 0)
			{
			}
			num = (short)1189019648;
			if (num != 0)
			{
			}
			global::DevComponents.WpfDock.DockTabCloseButton.IsActiveProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("諂뛄蛆꫈뿊꓌많듐", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockTabCloseButton), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfDock.DockTabCloseButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfDock.DockTabCloseButton)));
		}

		// Token: 0x040000DA RID: 218
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty;
	}
}
