using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using Infragistics.Windows.Automation.Peers;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000209 RID: 521
	[global::System.Windows.TemplateVisualState(Name = "Top", GroupName = "LocationStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Bottom", GroupName = "LocationStates")]
	public sealed class PopupResizerBar : global::System.Windows.Controls.Control
	{
		// Token: 0x0600137C RID: 4988 RVA: 0x000451C4 File Offset: 0x000433C4
		static PopupResizerBar()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.PopupResizerBar), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.PopupResizerBar)));
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x00045253 File Offset: 0x00043453
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0004526E File Offset: 0x0004346E
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.PopupResizerBarAutomationPeer(this);
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00045276 File Offset: 0x00043476
		protected override void OnMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseDown(e);
			if (base.IsMouseCaptureWithin)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0004528E File Offset: 0x0004348E
		protected override void OnMouseUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseUp(e);
			if (base.IsMouseCaptureWithin)
			{
				e.Handled = true;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x000452A6 File Offset: 0x000434A6
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x000452B8 File Offset: 0x000434B8
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.PopupResizeMode ResizeMode
		{
			get
			{
				return (global::Infragistics.Windows.Controls.PopupResizeMode)base.GetValue(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizeModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizeModeProperty, value);
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x000452CB File Offset: 0x000434CB
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x000452DD File Offset: 0x000434DD
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.PopupResizerBarLocation Location
		{
			get
			{
				return (global::Infragistics.Windows.Controls.PopupResizerBarLocation)base.GetValue(global::Infragistics.Windows.Controls.PopupResizerBar.LocationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.PopupResizerBar.LocationProperty, value);
			}
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x000452F0 File Offset: 0x000434F0
		internal global::System.Windows.Controls.Primitives.Thumb GetThumb()
		{
			return base.GetTemplateChild("PART_Thumb") as global::System.Windows.Controls.Primitives.Thumb;
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00045304 File Offset: 0x00043504
		internal void PerformMove(double x, double y)
		{
			global::System.Windows.Point point = global::Infragistics.Windows.Utilities.PointFromScreenSafe(this, new global::System.Windows.Point(x, y));
			global::Infragistics.Windows.Controls.PopupResizerDecorator popupResizerDecorator = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.Controls.PopupResizerDecorator), true) as global::Infragistics.Windows.Controls.PopupResizerDecorator;
			if (popupResizerDecorator != null)
			{
				popupResizerDecorator.PerformMove(point.X, point.Y);
			}
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00045350 File Offset: 0x00043550
		private void SetVisualState(bool useTransitions)
		{
			switch (this.Location)
			{
			case global::Infragistics.Windows.Controls.PopupResizerBarLocation.Top:
				global::System.Windows.VisualStateManager.GoToState(this, "Top", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Bottom", useTransitions);
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00045390 File Offset: 0x00043590
		private static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.PopupResizerBar popupResizerBar = target as global::Infragistics.Windows.Controls.PopupResizerBar;
			popupResizerBar.UpdateVisualStates();
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x000453AA File Offset: 0x000435AA
		private void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x000453B3 File Offset: 0x000435B3
		private void UpdateVisualStates(bool useTransitions)
		{
			if (!this._hasVisualStateGroups)
			{
				return;
			}
			if (!base.IsLoaded)
			{
				useTransitions = false;
			}
			this.SetVisualState(useTransitions);
		}

		// Token: 0x04000A70 RID: 2672
		private bool _hasVisualStateGroups;

		// Token: 0x04000A71 RID: 2673
		public static readonly global::System.Windows.DependencyProperty ResizeModeProperty = global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizeModeProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.PopupResizerBar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.PopupResizeMode.VerticalOnly));

		// Token: 0x04000A72 RID: 2674
		public static readonly global::System.Windows.DependencyProperty LocationProperty = global::System.Windows.DependencyProperty.Register("Location", typeof(global::Infragistics.Windows.Controls.PopupResizerBarLocation), typeof(global::Infragistics.Windows.Controls.PopupResizerBar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.PopupResizerBarLocation.Bottom, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PopupResizerBar.OnVisualStatePropertyChanged)));
	}
}
