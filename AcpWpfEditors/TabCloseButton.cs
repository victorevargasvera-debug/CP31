using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000040 RID: 64
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class TabCloseButton : global::System.Windows.Controls.Button
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x0005D7C4 File Offset: 0x0005B9C4
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x0005D880 File Offset: 0x0005BA80
		public bool IsActive
		{
			get
			{
				short num = (short)792395777;
				if (num != 0)
				{
				}
				num = (short)2121317065;
				short num2 = num;
				num = (short)83802825;
				switch (num2 == num)
				{
				}
				num = (short)1950351360;
				if (num != 0)
				{
				}
				num = (short)473038848;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.TabCloseButton.IsActiveProperty);
			}
			set
			{
				short num = (short)1243603959;
				short num2 = num;
				num = (short)1194583031;
				switch (num2 == num)
				{
				}
				num = (short)1555103745;
				if (num != 0)
				{
				}
				num = (short)999424000;
				if (num != 0)
				{
				}
				num = (short)1549795328;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.TabCloseButton.IsActiveProperty, value);
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0005D93C File Offset: 0x0005BB3C
		static TabCloseButton()
		{
			int a_ = 4;
			short num = (short)1687486465;
			if (num != 0)
			{
			}
			num = (short)349433842;
			short num2 = num;
			num = (short)703655922;
			switch (num2 == num)
			{
			}
			num = (short)1220149248;
			if (num != 0)
			{
			}
			num = (short)1479213056;
			short num3 = num;
			global::DevComponents.WpfEditors.TabCloseButton.IsActiveProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("飐ꃒ铔듖귘닚ꯜ뫞", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.TabCloseButton), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.TabCloseButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.TabCloseButton)));
		}

		// Token: 0x0400023E RID: 574
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty;
	}
}
