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
	// Token: 0x020001DB RID: 475
	[global::System.Windows.TemplateVisualState(Name = "Top", GroupName = "LocationStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Bottom", GroupName = "LocationStates")]
	public sealed class PopupResizerBar : global::System.Windows.Controls.Control
	{
		// Token: 0x060011A8 RID: 4520 RVA: 0x0003F91C File Offset: 0x0003DB1C
		static PopupResizerBar()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.PopupResizerBar), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.PopupResizerBar)));
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0003F9AB File Offset: 0x0003DBAB
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0003F9C6 File Offset: 0x0003DBC6
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.PopupResizerBarAutomationPeer(this);
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0003F9CE File Offset: 0x0003DBCE
		protected override void OnMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseDown(e);
			if (base.IsMouseCaptureWithin)
			{
				e.Handled = true;
			}
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0003F9E6 File Offset: 0x0003DBE6
		protected override void OnMouseUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseUp(e);
			if (base.IsMouseCaptureWithin)
			{
				e.Handled = true;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x0003F9FE File Offset: 0x0003DBFE
		// (set) Token: 0x060011AE RID: 4526 RVA: 0x0003FA10 File Offset: 0x0003DC10
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

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x0003FA23 File Offset: 0x0003DC23
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x0003FA35 File Offset: 0x0003DC35
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

		// Token: 0x060011B1 RID: 4529 RVA: 0x0003FA48 File Offset: 0x0003DC48
		internal global::System.Windows.Controls.Primitives.Thumb GetThumb()
		{
			return base.GetTemplateChild("PART_Thumb") as global::System.Windows.Controls.Primitives.Thumb;
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0003FA5C File Offset: 0x0003DC5C
		internal void PerformMove(double x, double y)
		{
			global::System.Windows.Point point = global::Infragistics.Windows.Utilities.PointFromScreenSafe(this, new global::System.Windows.Point(x, y));
			global::Infragistics.Windows.Controls.PopupResizerDecorator popupResizerDecorator = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.Controls.PopupResizerDecorator), true) as global::Infragistics.Windows.Controls.PopupResizerDecorator;
			if (popupResizerDecorator != null)
			{
				popupResizerDecorator.PerformMove(point.X, point.Y);
			}
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0003FAA8 File Offset: 0x0003DCA8
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

		// Token: 0x060011B4 RID: 4532 RVA: 0x0003FAE8 File Offset: 0x0003DCE8
		private static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.PopupResizerBar popupResizerBar = target as global::Infragistics.Windows.Controls.PopupResizerBar;
			popupResizerBar.UpdateVisualStates();
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x0003FB02 File Offset: 0x0003DD02
		private void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0003FB0B File Offset: 0x0003DD0B
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

		// Token: 0x0400092C RID: 2348
		private bool _hasVisualStateGroups;

		// Token: 0x0400092D RID: 2349
		public static readonly global::System.Windows.DependencyProperty ResizeModeProperty = global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizeModeProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.PopupResizerBar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.PopupResizeMode.VerticalOnly));

		// Token: 0x0400092E RID: 2350
		public static readonly global::System.Windows.DependencyProperty LocationProperty = global::System.Windows.DependencyProperty.Register("Location", typeof(global::Infragistics.Windows.Controls.PopupResizerBarLocation), typeof(global::Infragistics.Windows.Controls.PopupResizerBar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.PopupResizerBarLocation.Bottom, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PopupResizerBar.OnVisualStatePropertyChanged)));
	}
}
