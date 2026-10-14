using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Tiles
{
	// Token: 0x020001CB RID: 459
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class TileDragIndicator : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06000FF4 RID: 4084 RVA: 0x000349DC File Offset: 0x00032BDC
		static TileDragIndicator()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Tiles.TileDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Tiles.TileDragIndicator)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Tiles.TileDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x00034A6A File Offset: 0x00032C6A
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.FrameworkElement Container
		{
			get
			{
				return (global::System.Windows.FrameworkElement)base.GetValue(global::Infragistics.Windows.Tiles.TileDragIndicator.ContainerProperty);
			}
		}

		// Token: 0x0400086A RID: 2154
		internal static readonly global::System.Windows.DependencyPropertyKey ContainerPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Container", typeof(global::System.Windows.FrameworkElement), typeof(global::Infragistics.Windows.Tiles.TileDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400086B RID: 2155
		public static readonly global::System.Windows.DependencyProperty ContainerProperty = global::Infragistics.Windows.Tiles.TileDragIndicator.ContainerPropertyKey.DependencyProperty;
	}
}
