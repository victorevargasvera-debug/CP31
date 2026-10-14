using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200021A RID: 538
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ToolWindowResizeElement : global::System.Windows.Controls.Border
	{
		// Token: 0x0600157F RID: 5503 RVA: 0x000522DC File Offset: 0x000504DC
		static ToolWindowResizeElement()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowResizeElement), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowResizeElement)));
			global::System.Windows.Controls.Border.BorderBrushProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowResizeElement), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Media.Brushes.Transparent));
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x000523F4 File Offset: 0x000505F4
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

		// Token: 0x06001582 RID: 5506 RVA: 0x00052494 File Offset: 0x00050694
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

		// Token: 0x06001583 RID: 5507 RVA: 0x00052688 File Offset: 0x00050888
		private static void OnBorderLocationChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowResizeElement toolWindowResizeElement = (global::Infragistics.Windows.Controls.ToolWindowResizeElement)d;
			toolWindowResizeElement.InitializeBorderThickness();
			toolWindowResizeElement.InitializeCornerRadius();
			toolWindowResizeElement.InitializeAlignments();
			toolWindowResizeElement.InitializeMargins();
			toolWindowResizeElement.InitializeCursor();
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x000526BA File Offset: 0x000508BA
		// (set) Token: 0x06001585 RID: 5509 RVA: 0x000526CC File Offset: 0x000508CC
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

		// Token: 0x06001586 RID: 5510 RVA: 0x000526E0 File Offset: 0x000508E0
		private static void OnWindowBorderThicknessChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowResizeElement toolWindowResizeElement = (global::Infragistics.Windows.Controls.ToolWindowResizeElement)d;
			toolWindowResizeElement.InitializeBorderThickness();
			toolWindowResizeElement.InitializeMargins();
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x00052700 File Offset: 0x00050900
		private global::System.Windows.Thickness WindowBorderThickness
		{
			get
			{
				return (global::System.Windows.Thickness)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowResizeElement.WindowBorderThicknessProperty);
			}
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00052714 File Offset: 0x00050914
		private static void OnWindowCornerRadiusChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowResizeElement toolWindowResizeElement = (global::Infragistics.Windows.Controls.ToolWindowResizeElement)d;
			toolWindowResizeElement.InitializeCornerRadius();
			toolWindowResizeElement.InitializeMargins();
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x00052734 File Offset: 0x00050934
		private global::System.Windows.CornerRadius WindowCornerRadius
		{
			get
			{
				return (global::System.Windows.CornerRadius)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowResizeElement.WindowCornerRadiusProperty);
			}
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00052746 File Offset: 0x00050946
		private void InitializeAlignments()
		{
			this.InitializeHorizontalAlignment();
			this.InitializeVerticalAlignment();
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00052754 File Offset: 0x00050954
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

		// Token: 0x0600158C RID: 5516 RVA: 0x000527CC File Offset: 0x000509CC
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

		// Token: 0x0600158D RID: 5517 RVA: 0x0005282C File Offset: 0x00050A2C
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

		// Token: 0x0600158E RID: 5518 RVA: 0x00052888 File Offset: 0x00050A88
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

		// Token: 0x0600158F RID: 5519 RVA: 0x000529DC File Offset: 0x00050BDC
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

		// Token: 0x06001590 RID: 5520 RVA: 0x00052B80 File Offset: 0x00050D80
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

		// Token: 0x04000AA6 RID: 2726
		public static readonly global::System.Windows.DependencyProperty BorderLocationProperty = global::System.Windows.DependencyProperty.Register("BorderLocation", typeof(global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation), typeof(global::Infragistics.Windows.Controls.ToolWindowResizeElement), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Top, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowResizeElement.OnBorderLocationChanged)));

		// Token: 0x04000AA7 RID: 2727
		private static readonly global::System.Windows.DependencyProperty WindowBorderThicknessProperty = global::System.Windows.DependencyProperty.Register("WindowBorderThickness", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Windows.Controls.ToolWindowResizeElement), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness), new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowResizeElement.OnWindowBorderThicknessChanged)));

		// Token: 0x04000AA8 RID: 2728
		private static readonly global::System.Windows.DependencyProperty WindowCornerRadiusProperty = global::System.Windows.DependencyProperty.Register("WindowCornerRadius", typeof(global::System.Windows.CornerRadius), typeof(global::Infragistics.Windows.Controls.ToolWindowResizeElement), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.CornerRadius), new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowResizeElement.OnWindowCornerRadiusChanged)));
	}
}
