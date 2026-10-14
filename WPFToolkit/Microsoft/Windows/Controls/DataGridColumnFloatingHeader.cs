using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.Windows.Controls.Primitives;
using MS.Internal;

namespace Microsoft.Windows.Controls
{
	// Token: 0x0200007E RID: 126
	[global::System.Windows.TemplatePart(Name = "PART_VisualBrushCanvas", Type = typeof(global::System.Windows.Controls.Canvas))]
	internal class DataGridColumnFloatingHeader : global::System.Windows.Controls.Control
	{
		// Token: 0x060008CF RID: 2255 RVA: 0x00027B30 File Offset: 0x00025D30
		static DataGridColumnFloatingHeader()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader)));
			global::System.Windows.FrameworkElement.WidthProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader.OnWidthChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader.OnCoerceWidth)));
			global::System.Windows.FrameworkElement.HeightProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader.OnHeightChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader.OnCoerceHeight)));
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00027BC4 File Offset: 0x00025DC4
		private static void OnWidthChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader dataGridColumnFloatingHeader = (global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader)d;
			double num = (double)e.NewValue;
			if (dataGridColumnFloatingHeader._visualBrushCanvas != null && !global::MS.Internal.DoubleUtil.IsNaN(num))
			{
				global::System.Windows.Media.VisualBrush visualBrush = dataGridColumnFloatingHeader._visualBrushCanvas.Background as global::System.Windows.Media.VisualBrush;
				if (visualBrush != null)
				{
					global::System.Windows.Rect viewbox = visualBrush.Viewbox;
					visualBrush.Viewbox = new global::System.Windows.Rect(viewbox.X, viewbox.Y, num - dataGridColumnFloatingHeader.GetVisualCanvasMarginX(), viewbox.Height);
				}
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00027C38 File Offset: 0x00025E38
		private static object OnCoerceWidth(global::System.Windows.DependencyObject d, object baseValue)
		{
			double value = (double)baseValue;
			global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader dataGridColumnFloatingHeader = (global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader)d;
			if (dataGridColumnFloatingHeader._referenceHeader != null && global::MS.Internal.DoubleUtil.IsNaN(value))
			{
				return dataGridColumnFloatingHeader._referenceHeader.ActualWidth + dataGridColumnFloatingHeader.GetVisualCanvasMarginX();
			}
			return baseValue;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00027C7C File Offset: 0x00025E7C
		private static void OnHeightChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader dataGridColumnFloatingHeader = (global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader)d;
			double num = (double)e.NewValue;
			if (dataGridColumnFloatingHeader._visualBrushCanvas != null && !global::MS.Internal.DoubleUtil.IsNaN(num))
			{
				global::System.Windows.Media.VisualBrush visualBrush = dataGridColumnFloatingHeader._visualBrushCanvas.Background as global::System.Windows.Media.VisualBrush;
				if (visualBrush != null)
				{
					global::System.Windows.Rect viewbox = visualBrush.Viewbox;
					visualBrush.Viewbox = new global::System.Windows.Rect(viewbox.X, viewbox.Y, viewbox.Width, num - dataGridColumnFloatingHeader.GetVisualCanvasMarginY());
				}
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00027CF0 File Offset: 0x00025EF0
		private static object OnCoerceHeight(global::System.Windows.DependencyObject d, object baseValue)
		{
			double value = (double)baseValue;
			global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader dataGridColumnFloatingHeader = (global::Microsoft.Windows.Controls.DataGridColumnFloatingHeader)d;
			if (dataGridColumnFloatingHeader._referenceHeader != null && global::MS.Internal.DoubleUtil.IsNaN(value))
			{
				return dataGridColumnFloatingHeader._referenceHeader.ActualHeight + dataGridColumnFloatingHeader.GetVisualCanvasMarginY();
			}
			return baseValue;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00027D34 File Offset: 0x00025F34
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._visualBrushCanvas = (base.GetTemplateChild("PART_VisualBrushCanvas") as global::System.Windows.Controls.Canvas);
			this.UpdateVisualBrush();
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00027D58 File Offset: 0x00025F58
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x00027D60 File Offset: 0x00025F60
		internal global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader ReferenceHeader
		{
			get
			{
				return this._referenceHeader;
			}
			set
			{
				this._referenceHeader = value;
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00027D6C File Offset: 0x00025F6C
		private void UpdateVisualBrush()
		{
			if (this._referenceHeader != null && this._visualBrushCanvas != null)
			{
				global::System.Windows.Media.VisualBrush visualBrush = new global::System.Windows.Media.VisualBrush(this._referenceHeader);
				visualBrush.ViewboxUnits = global::System.Windows.Media.BrushMappingMode.Absolute;
				double num = base.Width;
				if (global::MS.Internal.DoubleUtil.IsNaN(num))
				{
					num = this._referenceHeader.ActualWidth;
				}
				else
				{
					num -= this.GetVisualCanvasMarginX();
				}
				double num2 = base.Height;
				if (global::MS.Internal.DoubleUtil.IsNaN(num2))
				{
					num2 = this._referenceHeader.ActualHeight;
				}
				else
				{
					num2 -= this.GetVisualCanvasMarginY();
				}
				global::System.Windows.Vector offset = global::System.Windows.Media.VisualTreeHelper.GetOffset(this._referenceHeader);
				visualBrush.Viewbox = new global::System.Windows.Rect(offset.X, offset.Y, num, num2);
				this._visualBrushCanvas.Background = visualBrush;
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00027E21 File Offset: 0x00026021
		internal void ClearHeader()
		{
			this._referenceHeader = null;
			if (this._visualBrushCanvas != null)
			{
				this._visualBrushCanvas.Background = null;
			}
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00027E40 File Offset: 0x00026040
		private double GetVisualCanvasMarginX()
		{
			double num = 0.0;
			if (this._visualBrushCanvas != null)
			{
				global::System.Windows.Thickness margin = this._visualBrushCanvas.Margin;
				num += margin.Left;
				num += margin.Right;
			}
			return num;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00027E80 File Offset: 0x00026080
		private double GetVisualCanvasMarginY()
		{
			double num = 0.0;
			if (this._visualBrushCanvas != null)
			{
				global::System.Windows.Thickness margin = this._visualBrushCanvas.Margin;
				num += margin.Top;
				num += margin.Bottom;
			}
			return num;
		}

		// Token: 0x040002B9 RID: 697
		private const string VisualBrushCanvasTemplateName = "PART_VisualBrushCanvas";

		// Token: 0x040002BA RID: 698
		private global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader _referenceHeader;

		// Token: 0x040002BB RID: 699
		private global::System.Windows.Controls.Canvas _visualBrushCanvas;
	}
}
