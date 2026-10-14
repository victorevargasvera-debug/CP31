using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Tiles
{
	// Token: 0x0200019E RID: 414
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class TileDragIndicator : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06000E34 RID: 3636 RVA: 0x0002F574 File Offset: 0x0002D774
		static TileDragIndicator()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Tiles.TileDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Tiles.TileDragIndicator)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Tiles.TileDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x0002F602 File Offset: 0x0002D802
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.FrameworkElement Container
		{
			get
			{
				return (global::System.Windows.FrameworkElement)base.GetValue(global::Infragistics.Windows.Tiles.TileDragIndicator.ContainerProperty);
			}
		}

		// Token: 0x0400072E RID: 1838
		internal static readonly global::System.Windows.DependencyPropertyKey ContainerPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Container", typeof(global::System.Windows.FrameworkElement), typeof(global::Infragistics.Windows.Tiles.TileDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400072F RID: 1839
		public static readonly global::System.Windows.DependencyProperty ContainerProperty = global::Infragistics.Windows.Tiles.TileDragIndicator.ContainerPropertyKey.DependencyProperty;
	}
}
