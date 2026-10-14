using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000041 RID: 65
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class TabDragPreview : global::System.Windows.Controls.Control
	{
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x0005DA5C File Offset: 0x0005BC5C
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x0005DB18 File Offset: 0x0005BD18
		public global::DevComponents.WpfEditors.SuperTabItem DragTab
		{
			get
			{
				short num = (short)829543696;
				short num2 = num;
				num = (short)1346622736;
				switch (num2 == num)
				{
				}
				num = (short)1912733697;
				if (num != 0)
				{
				}
				num = (short)678887424;
				if (num != 0)
				{
				}
				num = (short)1822556160;
				short num3 = num;
				return (global::DevComponents.WpfEditors.SuperTabItem)base.GetValue(global::DevComponents.WpfEditors.TabDragPreview.DragTabProperty);
			}
			set
			{
				short num = (short)816157546;
				short num2 = num;
				num = (short)1827836778;
				switch (num2 == num)
				{
				}
				num = (short)1458765824;
				if (num != 0)
				{
				}
				num = (short)556793857;
				if (num != 0)
				{
				}
				num = (short)1170866176;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.TabDragPreview.DragTabProperty, value);
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0005DBCC File Offset: 0x0005BDCC
		static TabDragPreview()
		{
			int a_ = 13;
			short num = (short)1107307980;
			short num2 = num;
			num = (short)1019817420;
			switch (num2 == num)
			{
			}
			num = (short)343080961;
			if (num != 0)
			{
			}
			num = (short)233177088;
			if (num != 0)
			{
			}
			num = (short)1508114432;
			short num3 = num;
			global::DevComponents.WpfEditors.TabDragPreview.DragTabProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("黙껛뿝蟟뛡藣蓥", a_), typeof(global::DevComponents.WpfEditors.SuperTabItem), typeof(global::DevComponents.WpfEditors.TabDragPreview), new global::System.Windows.UIPropertyMetadata(null));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.TabDragPreview), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.TabDragPreview)));
		}

		// Token: 0x0400023F RID: 575
		public static readonly global::System.Windows.DependencyProperty DragTabProperty;
	}
}
