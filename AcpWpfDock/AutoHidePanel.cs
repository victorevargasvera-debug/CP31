using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using DevComponents.WpfDock.Converters;

namespace DevComponents.WpfDock
{
	// Token: 0x02000003 RID: 3
	[global::System.Windows.TemplatePart(Name = "PART_PanelBorder", Type = typeof(global::System.Windows.Controls.Decorator))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class AutoHidePanel : global::System.Windows.Controls.ItemsControl
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		static AutoHidePanel()
		{
			int a_ = 17;
			short num = (short)1222246400;
			short num2 = num;
			num = (short)996842593;
			short num3 = num;
			num = (short)667982945;
			switch (num3 == num)
			{
			}
			num = (short)302645249;
			if (num != 0)
			{
			}
			num = (short)1591541760;
			if (num != 0)
			{
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfDock.AutoHidePanel), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfDock.AutoHidePanel)));
			global::DevComponents.WpfDock.AutoHidePanel.a = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("蓏돑뛓駕꫗동맛냝铟菡郣迥蟧蓩", a_), typeof(global::System.Windows.Controls.Orientation), typeof(global::DevComponents.WpfDock.AutoHidePanel), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Horizontal));
			global::DevComponents.WpfDock.AutoHidePanel.TabOrientationProperty = global::DevComponents.WpfDock.AutoHidePanel.a.DependencyProperty;
			global::DevComponents.WpfDock.AutoHidePanel.IsBeginGroupProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("駏ꇑ雓돕뿗동닛駝鋟跡釣雥", a_), typeof(bool), typeof(global::DevComponents.WpfDock.AutoHidePanel), new global::System.Windows.PropertyMetadata(false));
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002270 File Offset: 0x00000470
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002328 File Offset: 0x00000528
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Controls.Orientation TabOrientation
		{
			get
			{
				short num = (short)1943076864;
				short num2 = num;
				num = (short)2055460362;
				short num3 = num;
				num = (short)1208210954;
				switch (num3 == num)
				{
				}
				num = (short)459145216;
				if (num != 0)
				{
				}
				num = (short)1109458945;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::DevComponents.WpfDock.AutoHidePanel.TabOrientationProperty);
			}
			internal set
			{
				short num = (short)226099200;
				short num2 = num;
				num = (short)980104009;
				short num3 = num;
				num = (short)197604169;
				switch (num3 == num)
				{
				}
				num = (short)301662208;
				if (num != 0)
				{
				}
				num = (short)1163001857;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.AutoHidePanel.a, value);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000023E0 File Offset: 0x000005E0
		public static bool GetIsBeginGroup(global::System.Windows.UIElement element)
		{
			int a_ = 18;
			short num;
			while (element == null)
			{
				num = (short)1900459889;
				short num2 = num;
				num = (short)1907865457;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)211812352;
					if (num != 0)
					{
					}
					num = (short)651821057;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("듐뿒냔뫖볘뗚꧜", a_));
				}
			}
			num = (short)1173356544;
			short num3 = num;
			return (bool)element.GetValue(global::DevComponents.WpfDock.AutoHidePanel.IsBeginGroupProperty);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000024C0 File Offset: 0x000006C0
		public static void SetIsBeginGroup(global::System.Windows.UIElement element, bool doc)
		{
			int a_ = 15;
			short num;
			while (element == null)
			{
				num = (short)400180672;
				short num2 = num;
				num = (short)98584000;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)249495553;
					if (num != 0)
					{
					}
					num = (short)1287258112;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("ꯍ볏럑맓돕뛗껙", a_));
				}
			}
			num = (short)250478592;
			short num3 = num;
			element.SetValue(global::DevComponents.WpfDock.AutoHidePanel.IsBeginGroupProperty, doc);
		}

		// Token: 0x04000003 RID: 3
		public static readonly global::System.Windows.DependencyProperty TabOrientationProperty;

		// Token: 0x04000004 RID: 4
		private static readonly global::System.Windows.DependencyPropertyKey a;

		// Token: 0x04000005 RID: 5
		public static readonly global::System.Windows.DependencyProperty IsBeginGroupProperty;
	}
}
