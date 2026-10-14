using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200024D RID: 589
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ToolWindowResizeElement : global::System.Windows.Controls.Border
	{
		// Token: 0x0600177D RID: 6013 RVA: 0x00058CA0 File Offset: 0x00056EA0
		static ToolWindowResizeElement()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowResizeElement), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowResizeElement)));
			global::System.Windows.Controls.Border.BorderBrushProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowResizeElement), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Media.Brushes.Transparent));
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00058DB8 File Offset: 0x00056FB8
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (base.TemplatedParent ?? global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.Controls.ToolWindow), true)) as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow != null)
			{
				base.SetBinding(global::Infragistics.Windows.Controls.ToolWindowResizeElement.WindowBorderThicknessProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Controls.Control.BorderThicknessProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				base.SetBinding(global::Infragistics.Windows.Controls.ToolWindowResizeElement.WindowCornerRadiusProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Controls.Border.CornerRadiusProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
			}
			else
			{
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.ToolWindowResizeElement.WindowBorderThicknessProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.ToolWindowResizeElement.WindowCornerRadiusProperty);
			}
			this.InitializeAlignments();
			this.InitializeBorderThickness();
			this.InitializeCornerRadius();
			this.InitializeCursor();
			this.InitializeMargins();
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00058E58 File Offset: 0x00057058
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			switch (this.BorderLocation)
			{
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopLeft:
				result.Width = global::System.Math.Max(result.Width, global::System.Math.Max(base.BorderThickness.Left, base.CornerRadius.TopLeft));
				result.Height = global::System.Math.Max(result.Height, global::System.Math.Max(base.BorderThickness.Top, base.CornerRadius.TopLeft));
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopRight:
				result.Width = global::System.Math.Max(result.Width, global::System.Math.Max(base.BorderThickness.Right, base.CornerRadius.TopRight));
				result.Height = global::System.Math.Max(result.Height, global::System.Math.Max(base.BorderThickness.Top, base.CornerRadius.TopRight));
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomLeft:
				result.Width = global::System.Math.Max(result.Width, global::System.Math.Max(base.BorderThickness.Left, base.CornerRadius.BottomLeft));
				result.Height = global::System.Math.Max(result.Height, global::System.Math.Max(base.BorderThickness.Bottom, base.CornerRadius.BottomLeft));
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomRight:
				result.Width = global::System.Math.Max(result.Width, global::System.Math.Max(base.BorderThickness.Right, base.CornerRadius.BottomRight));
				result.Height = global::System.Math.Max(result.Height, global::System.Math.Max(base.BorderThickness.Bottom, base.CornerRadius.BottomRight));
				break;
			}
			return result;
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x0005904C File Offset: 0x0005724C
		private static void OnBorderLocationChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowResizeElement toolWindowResizeElement = (global::Infragistics.Windows.Controls.ToolWindowResizeElement)d;
			toolWindowResizeElement.InitializeBorderThickness();
			toolWindowResizeElement.InitializeCornerRadius();
			toolWindowResizeElement.InitializeAlignments();
			toolWindowResizeElement.InitializeMargins();
			toolWindowResizeElement.InitializeCursor();
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x0005907E File Offset: 0x0005727E
		// (set) Token: 0x06001783 RID: 6019 RVA: 0x00059090 File Offset: 0x00057290
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation BorderLocation
		{
			get
			{
				return (global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowResizeElement.BorderLocationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindowResizeElement.BorderLocationProperty, value);
			}
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x000590A4 File Offset: 0x000572A4
		private static void OnWindowBorderThicknessChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowResizeElement toolWindowResizeElement = (global::Infragistics.Windows.Controls.ToolWindowResizeElement)d;
			toolWindowResizeElement.InitializeBorderThickness();
			toolWindowResizeElement.InitializeMargins();
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x000590C4 File Offset: 0x000572C4
		private global::System.Windows.Thickness WindowBorderThickness
		{
			get
			{
				return (global::System.Windows.Thickness)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowResizeElement.WindowBorderThicknessProperty);
			}
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x000590D8 File Offset: 0x000572D8
		private static void OnWindowCornerRadiusChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowResizeElement toolWindowResizeElement = (global::Infragistics.Windows.Controls.ToolWindowResizeElement)d;
			toolWindowResizeElement.InitializeCornerRadius();
			toolWindowResizeElement.InitializeMargins();
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x000590F8 File Offset: 0x000572F8
		private global::System.Windows.CornerRadius WindowCornerRadius
		{
			get
			{
				return (global::System.Windows.CornerRadius)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowResizeElement.WindowCornerRadiusProperty);
			}
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x0005910A File Offset: 0x0005730A
		private void InitializeAlignments()
		{
			this.InitializeHorizontalAlignment();
			this.InitializeVerticalAlignment();
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00059118 File Offset: 0x00057318
		private void InitializeCursor()
		{
			global::System.Windows.Input.Cursor value = null;
			switch (this.BorderLocation)
			{
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Left:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Right:
				value = global::System.Windows.Input.Cursors.SizeWE;
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Top:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Bottom:
				value = global::System.Windows.Input.Cursors.SizeNS;
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopLeft:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomRight:
				value = global::System.Windows.Input.Cursors.SizeNWSE;
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopRight:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomLeft:
				value = global::System.Windows.Input.Cursors.SizeNESW;
				break;
			}
			base.SetValue(global::System.Windows.FrameworkElement.CursorProperty, value);
			base.SetValue(global::System.Windows.FrameworkElement.ForceCursorProperty, global::Infragistics.KnownBoxes.TrueBox);
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00059190 File Offset: 0x00057390
		private void InitializeHorizontalAlignment()
		{
			object value;
			switch (this.BorderLocation)
			{
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Left:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopLeft:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomLeft:
				value = global::Infragistics.KnownBoxes.HorizontalAlignmentLeftBox;
				goto IL_45;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Right:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopRight:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomRight:
				value = global::Infragistics.KnownBoxes.HorizontalAlignmentRightBox;
				goto IL_45;
			}
			value = global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox;
			IL_45:
			base.SetValue(global::System.Windows.FrameworkElement.HorizontalAlignmentProperty, value);
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x000591F0 File Offset: 0x000573F0
		private void InitializeVerticalAlignment()
		{
			object value;
			switch (this.BorderLocation)
			{
			default:
				value = global::Infragistics.KnownBoxes.VerticalAlignmentStretchBox;
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Top:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopLeft:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopRight:
				value = global::Infragistics.KnownBoxes.VerticalAlignmentTopBox;
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Bottom:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomLeft:
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomRight:
				value = global::Infragistics.KnownBoxes.VerticalAlignmentBottomBox;
				break;
			}
			base.SetValue(global::System.Windows.FrameworkElement.VerticalAlignmentProperty, value);
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0005924C File Offset: 0x0005744C
		private void InitializeMargins()
		{
			global::System.Windows.Thickness windowBorderThickness = this.WindowBorderThickness;
			global::System.Windows.CornerRadius windowCornerRadius = this.WindowCornerRadius;
			global::System.Windows.Thickness margin;
			switch (this.BorderLocation)
			{
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Left:
				margin = new global::System.Windows.Thickness(0.0, global::System.Math.Max(windowBorderThickness.Top, windowCornerRadius.TopLeft), 0.0, global::System.Math.Max(windowBorderThickness.Bottom, windowCornerRadius.BottomLeft));
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Top:
				margin = new global::System.Windows.Thickness(global::System.Math.Max(windowBorderThickness.Left, windowCornerRadius.TopLeft), 0.0, global::System.Math.Max(windowBorderThickness.Right, windowCornerRadius.TopRight), 0.0);
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Right:
				margin = new global::System.Windows.Thickness(0.0, global::System.Math.Max(windowBorderThickness.Top, windowCornerRadius.TopRight), 0.0, global::System.Math.Max(windowBorderThickness.Bottom, windowCornerRadius.BottomRight));
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Bottom:
				margin = new global::System.Windows.Thickness(global::System.Math.Max(windowBorderThickness.Left, windowCornerRadius.BottomLeft), 0.0, global::System.Math.Max(windowBorderThickness.Right, windowCornerRadius.BottomRight), 0.0);
				break;
			default:
				margin = default(global::System.Windows.Thickness);
				break;
			}
			base.Margin = margin;
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x000593A0 File Offset: 0x000575A0
		private void InitializeBorderThickness()
		{
			global::System.Windows.Thickness windowBorderThickness = this.WindowBorderThickness;
			switch (this.BorderLocation)
			{
			default:
				windowBorderThickness = new global::System.Windows.Thickness(windowBorderThickness.Left, 0.0, 0.0, 0.0);
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Top:
				windowBorderThickness = new global::System.Windows.Thickness(0.0, windowBorderThickness.Top, 0.0, 0.0);
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Right:
				windowBorderThickness = new global::System.Windows.Thickness(0.0, 0.0, windowBorderThickness.Right, 0.0);
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Bottom:
				windowBorderThickness = new global::System.Windows.Thickness(0.0, 0.0, 0.0, windowBorderThickness.Bottom);
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopLeft:
				windowBorderThickness = new global::System.Windows.Thickness(windowBorderThickness.Left, windowBorderThickness.Top, 0.0, 0.0);
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopRight:
				windowBorderThickness = new global::System.Windows.Thickness(0.0, windowBorderThickness.Top, windowBorderThickness.Right, 0.0);
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomLeft:
				windowBorderThickness = new global::System.Windows.Thickness(windowBorderThickness.Left, 0.0, 0.0, windowBorderThickness.Bottom);
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomRight:
				windowBorderThickness = new global::System.Windows.Thickness(0.0, 0.0, windowBorderThickness.Right, windowBorderThickness.Bottom);
				break;
			}
			base.BorderThickness = windowBorderThickness;
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00059544 File Offset: 0x00057744
		private void InitializeCornerRadius()
		{
			global::System.Windows.CornerRadius cornerRadius = this.WindowCornerRadius;
			switch (this.BorderLocation)
			{
			default:
				cornerRadius = default(global::System.Windows.CornerRadius);
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopLeft:
				cornerRadius = new global::System.Windows.CornerRadius(cornerRadius.TopLeft, 0.0, 0.0, 0.0);
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopRight:
				cornerRadius = new global::System.Windows.CornerRadius(0.0, cornerRadius.TopRight, 0.0, 0.0);
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomLeft:
				cornerRadius = new global::System.Windows.CornerRadius(0.0, 0.0, 0.0, cornerRadius.BottomLeft);
				break;
			case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomRight:
				cornerRadius = new global::System.Windows.CornerRadius(0.0, 0.0, cornerRadius.BottomRight, 0.0);
				break;
			}
			base.CornerRadius = cornerRadius;
		}

		// Token: 0x04000C08 RID: 3080
		public static readonly global::System.Windows.DependencyProperty BorderLocationProperty = global::System.Windows.DependencyProperty.Register("BorderLocation", typeof(global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation), typeof(global::Infragistics.Windows.Controls.ToolWindowResizeElement), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Top, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowResizeElement.OnBorderLocationChanged)));

		// Token: 0x04000C09 RID: 3081
		private static readonly global::System.Windows.DependencyProperty WindowBorderThicknessProperty = global::System.Windows.DependencyProperty.Register("WindowBorderThickness", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Windows.Controls.ToolWindowResizeElement), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness), new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowResizeElement.OnWindowBorderThicknessChanged)));

		// Token: 0x04000C0A RID: 3082
		private static readonly global::System.Windows.DependencyProperty WindowCornerRadiusProperty = global::System.Windows.DependencyProperty.Register("WindowCornerRadius", typeof(global::System.Windows.CornerRadius), typeof(global::Infragistics.Windows.Controls.ToolWindowResizeElement), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.CornerRadius), new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowResizeElement.OnWindowCornerRadiusChanged)));
	}
}
