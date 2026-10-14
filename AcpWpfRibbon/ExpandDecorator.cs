using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200004F RID: 79
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ExpandDecorator : global::System.Windows.Controls.Control
	{
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0004D61C File Offset: 0x0004B81C
		// (set) Token: 0x0600039B RID: 923 RVA: 0x0004D6D4 File Offset: 0x0004B8D4
		public global::DevComponents.WpfRibbon.ePopupPlacement PopupPlacement
		{
			get
			{
				short num = (short)1824456705;
				if (num != 0)
				{
				}
				num = (short)505675776;
				short num2 = num;
				num = (short)1837767720;
				short num3 = num;
				num = (short)114433064;
				switch (num3 == num)
				{
				}
				num = (short)1317863424;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.ePopupPlacement)base.GetValue(global::DevComponents.WpfRibbon.ExpandDecorator.PopupPlacementProperty);
			}
			set
			{
				short num = (short)1207369728;
				short num2 = num;
				num = (short)758708847;
				short num3 = num;
				num = (short)2084502127;
				switch (num3 == num)
				{
				}
				num = (short)288423937;
				if (num != 0)
				{
				}
				num = (short)811532288;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ExpandDecorator.PopupPlacementProperty, value);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0004D78C File Offset: 0x0004B98C
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0004D848 File Offset: 0x0004BA48
		public double ExpanderWidth
		{
			get
			{
				short num = (short)1327431680;
				short num2 = num;
				num = (short)862191617;
				if (num != 0)
				{
				}
				num = (short)2011300667;
				short num3 = num;
				num = (short)1321141051;
				switch (num3 == num)
				{
				}
				num = (short)512950272;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfRibbon.ExpandDecorator.ExpanderWidthProperty);
			}
			set
			{
				short num = (short)1711538176;
				short num2 = num;
				num = (short)851879633;
				short num3 = num;
				num = (short)533046993;
				switch (num3 == num)
				{
				}
				num = (short)1499332609;
				if (num != 0)
				{
				}
				num = (short)802226176;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ExpandDecorator.ExpanderWidthProperty, value);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0004D904 File Offset: 0x0004BB04
		// (set) Token: 0x0600039F RID: 927 RVA: 0x0004D9C0 File Offset: 0x0004BBC0
		public double ExpanderHeight
		{
			get
			{
				short num = (short)1895563264;
				short num2 = num;
				num = (short)791672401;
				short num3 = num;
				num = (short)5305937;
				switch (num3 == num)
				{
				}
				num = (short)143917057;
				if (num != 0)
				{
				}
				num = (short)2080964608;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfRibbon.ExpandDecorator.ExpanderHeightProperty);
			}
			set
			{
				short num = (short)1142358016;
				short num2 = num;
				num = (short)172568550;
				short num3 = num;
				num = (short)708456422;
				switch (num3 == num)
				{
				}
				num = (short)1912078337;
				if (num != 0)
				{
				}
				num = (short)145424384;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ExpandDecorator.ExpanderHeightProperty, value);
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0004DA7C File Offset: 0x0004BC7C
		static ExpandDecorator()
		{
			int a_ = 18;
			short num = (short)395313152;
			short num2 = num;
			num = (short)1248969160;
			short num3 = num;
			num = (short)223396296;
			switch (num3 == num)
			{
			}
			num = (short)1979252736;
			if (num != 0)
			{
			}
			num = (short)1394278401;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.ExpandDecorator.PopupPlacementProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㩩ͫṭկɱ⑳᩵᥷᥹᥻፽", a_), typeof(global::DevComponents.WpfRibbon.ePopupPlacement), typeof(global::DevComponents.WpfRibbon.ExpandDecorator), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfRibbon.ePopupPlacement.Bottom));
			global::DevComponents.WpfRibbon.ExpandDecorator.ExpanderWidthProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⽩ᑫṭᅯᱱၳ፵੷⵹ᕻ᩽", a_), typeof(double), typeof(global::DevComponents.WpfRibbon.ExpandDecorator), new global::System.Windows.UIPropertyMetadata(5.0));
			global::DevComponents.WpfRibbon.ExpandDecorator.ExpanderHeightProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⽩ᑫṭᅯᱱၳ፵੷㉹᥻᝽", a_), typeof(double), typeof(global::DevComponents.WpfRibbon.ExpandDecorator), new global::System.Windows.UIPropertyMetadata(3.0));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.ExpandDecorator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.ExpandDecorator)));
		}

		// Token: 0x040001AA RID: 426
		public static readonly global::System.Windows.DependencyProperty PopupPlacementProperty;

		// Token: 0x040001AB RID: 427
		public static readonly global::System.Windows.DependencyProperty ExpanderWidthProperty;

		// Token: 0x040001AC RID: 428
		public static readonly global::System.Windows.DependencyProperty ExpanderHeightProperty;
	}
}
