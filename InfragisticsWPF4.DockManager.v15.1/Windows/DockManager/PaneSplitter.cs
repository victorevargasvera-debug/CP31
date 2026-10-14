using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Collections;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DockManager.Dragging;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000085 RID: 133
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public abstract class PaneSplitter : global::System.Windows.Controls.Primitives.Thumb
	{
		// Token: 0x060004CA RID: 1226 RVA: 0x0001A4B8 File Offset: 0x000186B8
		static PaneSplitter()
		{
			global::Infragistics.Windows.DockManager.PaneSplitter._defaultHorzCursor = (global::Infragistics.Windows.DockManager.DockManagerUtilities.LoadCursor(typeof(global::Infragistics.Windows.DockManager.PaneSplitter), "ResourceSets/Cursors/horizontalSplitter.cur") ?? global::System.Windows.Input.Cursors.SizeNS);
			global::Infragistics.Windows.DockManager.PaneSplitter._defaultVertCursor = (global::Infragistics.Windows.DockManager.DockManagerUtilities.LoadCursor(typeof(global::Infragistics.Windows.DockManager.PaneSplitter), "ResourceSets/Cursors/verticalSplitter.cur") ?? global::System.Windows.Input.Cursors.SizeWE);
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneSplitter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DockManager.PaneSplitter)));
			global::Infragistics.Windows.DockManager.ThumbDragService.CancelThumbDragOnEscapeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneSplitter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.PaneSplitter), global::System.Windows.Controls.Primitives.Thumb.DragDeltaEvent, new global::System.Windows.Controls.Primitives.DragDeltaEventHandler(global::Infragistics.Windows.DockManager.PaneSplitter.OnDragDelta));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.PaneSplitter), global::System.Windows.Controls.Primitives.Thumb.DragCompletedEvent, new global::System.Windows.Controls.Primitives.DragCompletedEventHandler(global::Infragistics.Windows.DockManager.PaneSplitter.OnDragCompleted));
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0001A6B0 File Offset: 0x000188B0
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				if (this._previewWindow != null)
				{
					return new global::Infragistics.Collections.SingleItemEnumerator(this._previewWindow);
				}
				return global::Infragistics.Collections.EmptyEnumerator.Instance;
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0001A6CC File Offset: 0x000188CC
		protected override void OnDraggingChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnDraggingChanged(e);
			if (base.IsDragging && this.ShowsPreview)
			{
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
				if (dockManager != null && dockManager.ShowSplitterInPopup)
				{
					this._previewWindow = new global::Infragistics.Windows.Controls.ToolWindow();
					this._previewWindow.UseOSNonClientArea = false;
					this._previewWindow.ResizeMode = global::System.Windows.ResizeMode.NoResize;
					this._previewWindow.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.DockManagerPropertyKey, dockManager);
					this._previewWindow.Template = global::Infragistics.Windows.DockManager.Dragging.DragManager.GetIndicatorToolWindowTemplate(dockManager);
					this._previewWindow.VerticalAlignmentMode = global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment;
					this._previewWindow.HorizontalAlignmentMode = global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment;
					if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
					{
						this._previewWindow.VerticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
						this._previewWindow.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Center;
						this._previewWindow.SetBinding(global::System.Windows.FrameworkElement.WidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.ActualWidthProperty, global::System.Windows.Data.BindingMode.OneWay, this));
					}
					else
					{
						this._previewWindow.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
						this._previewWindow.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
						this._previewWindow.SetBinding(global::System.Windows.FrameworkElement.HeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.ActualHeightProperty, global::System.Windows.Data.BindingMode.OneWay, this));
					}
					this._previewWindow.Content = this.CreatePreviewControl();
					base.AddLogicalChild(this._previewWindow);
					return;
				}
				if (this._adorner == null)
				{
					global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this);
					if (adornerLayer != null)
					{
						this._adorner = new global::Infragistics.Windows.DockManager.PaneSplitter.SplitterPreviewAdorner(this);
						adornerLayer.Add(this._adorner);
						return;
					}
				}
			}
			else
			{
				if (this._adorner != null)
				{
					global::System.Windows.Documents.AdornerLayer adornerLayer2 = global::System.Windows.Media.VisualTreeHelper.GetParent(this._adorner) as global::System.Windows.Documents.AdornerLayer;
					if (adornerLayer2 != null)
					{
						adornerLayer2.Remove(this._adorner);
					}
					this._adorner = null;
				}
				if (this._previewWindow != null)
				{
					global::Infragistics.Windows.Controls.ToolWindow previewWindow = this._previewWindow;
					this._previewWindow = null;
					previewWindow.Close();
					base.RemoveLogicalChild(this._previewWindow);
				}
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x0001A880 File Offset: 0x00018A80
		public static global::System.Windows.Input.Cursor HorizontalSplitterCursor
		{
			get
			{
				return global::Infragistics.Windows.DockManager.PaneSplitter._defaultHorzCursor;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x0001A887 File Offset: 0x00018A87
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x0001A899 File Offset: 0x00018A99
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DockManager.PaneSplitter.OrientationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.PaneSplitter.OrientationProperty, value);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0001A8AC File Offset: 0x00018AAC
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x0001A8BE File Offset: 0x00018ABE
		[global::System.ComponentModel.Bindable(true)]
		internal bool ShowsPreview
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.PaneSplitter.ShowsPreviewProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.PaneSplitter.ShowsPreviewProperty, value);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060004D2 RID: 1234
		public abstract global::Infragistics.Windows.DockManager.PaneSplitterType SplitterType { get; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x0001A8D1 File Offset: 0x00018AD1
		public static global::System.Windows.Input.Cursor VerticalSplitterCursor
		{
			get
			{
				return global::Infragistics.Windows.DockManager.PaneSplitter._defaultVertCursor;
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0001A8D8 File Offset: 0x00018AD8
		private static void OnElementBeforeSplitterChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneSplitter paneSplitter = d as global::Infragistics.Windows.DockManager.PaneSplitter;
			global::System.Windows.FrameworkElement frameworkElement = e.NewValue as global::System.Windows.FrameworkElement;
			global::System.Windows.FrameworkElement frameworkElement2 = e.OldValue as global::System.Windows.FrameworkElement;
			if (frameworkElement2 != null)
			{
				frameworkElement2.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
			}
			if (frameworkElement == null)
			{
				global::System.Windows.Data.BindingOperations.ClearBinding(paneSplitter, global::System.Windows.UIElement.VisibilityProperty);
				return;
			}
			paneSplitter.SetBinding(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(paneSplitter.ElementBeforeVisibilityProperty, global::System.Windows.Data.BindingMode.OneWay, e.NewValue));
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0001A942 File Offset: 0x00018B42
		internal virtual global::System.Windows.DependencyProperty ElementBeforeVisibilityProperty
		{
			get
			{
				return global::System.Windows.UIElement.VisibilityProperty;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0001A949 File Offset: 0x00018B49
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x0001A95B File Offset: 0x00018B5B
		internal global::System.Windows.FrameworkElement ElementBeforeSplitter
		{
			get
			{
				return (global::System.Windows.FrameworkElement)base.GetValue(global::Infragistics.Windows.DockManager.PaneSplitter.ElementBeforeSplitterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.PaneSplitter.ElementBeforeSplitterProperty, value);
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0001A969 File Offset: 0x00018B69
		internal static global::Infragistics.Windows.DockManager.PaneSplitter GetSplitter(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DockManager.PaneSplitter)d.GetValue(global::Infragistics.Windows.DockManager.PaneSplitter.SplitterProperty);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0001A97B File Offset: 0x00018B7B
		internal static global::System.Windows.Visibility GetSplitterVisibility(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.Visibility)d.GetValue(global::Infragistics.Windows.DockManager.PaneSplitter.SplitterVisibilityProperty);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0001A990 File Offset: 0x00018B90
		internal void PerformMove(double x, double y)
		{
			global::System.Windows.Point point = global::Infragistics.Windows.Utilities.PointToScreenSafe(this, default(global::System.Windows.Point));
			double delta = (this.Orientation == global::System.Windows.Controls.Orientation.Vertical) ? (x - point.X) : (y - point.Y);
			this.ProcessDragDelta(delta, true);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0001A9D3 File Offset: 0x00018BD3
		protected virtual double ConstrainDelta(double delta)
		{
			return delta;
		}

		// Token: 0x060004DC RID: 1244
		protected abstract void ProcessDelta(double delta, bool isComplete);

		// Token: 0x060004DD RID: 1245 RVA: 0x0001A9D8 File Offset: 0x00018BD8
		private global::System.Windows.Controls.Control CreatePreviewControl()
		{
			global::System.Windows.Controls.Control control = new global::System.Windows.Controls.Control();
			control.SetResourceReference(global::System.Windows.FrameworkElement.StyleProperty, global::Infragistics.Windows.DockManager.PaneSplitter.PreviewStyleKey);
			control.IsEnabled = false;
			control.SetValue(global::Infragistics.Windows.DockManager.PaneSplitter.OrientationProperty, this.Orientation);
			return control;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0001AA1C File Offset: 0x00018C1C
		private static void OnDragCompleted(object sender, global::System.Windows.Controls.Primitives.DragCompletedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneSplitter paneSplitter = sender as global::Infragistics.Windows.DockManager.PaneSplitter;
			if (!e.Canceled)
			{
				bool flag = paneSplitter.Orientation == global::System.Windows.Controls.Orientation.Vertical;
				double num = (paneSplitter.FlowDirection == global::System.Windows.FlowDirection.RightToLeft) ? paneSplitter._lastDelta : (flag ? e.HorizontalChange : e.VerticalChange);
				global::System.Windows.Media.Matrix deviceMatrix = global::Infragistics.Windows.Utilities.GetDeviceMatrix(false, paneSplitter);
				double value = flag ? deviceMatrix.M22 : deviceMatrix.M11;
				if (!global::Infragistics.CoreUtilities.AreClose(1.0, value))
				{
					num = paneSplitter._lastDelta;
				}
				if (!double.IsNaN(num))
				{
					paneSplitter.ProcessDragDelta(num, true);
				}
			}
			paneSplitter._lastReferencePoint = null;
			paneSplitter._lastDelta = double.NaN;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0001AAC8 File Offset: 0x00018CC8
		private static void OnDragDelta(object sender, global::System.Windows.Controls.Primitives.DragDeltaEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneSplitter paneSplitter = sender as global::Infragistics.Windows.DockManager.PaneSplitter;
			bool flag = paneSplitter.Orientation == global::System.Windows.Controls.Orientation.Vertical;
			paneSplitter.ProcessDragDelta(flag ? e.HorizontalChange : e.VerticalChange, false);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0001AB00 File Offset: 0x00018D00
		private void ProcessDragDelta(double delta, bool isComplete)
		{
			bool showsPreview = this.ShowsPreview;
			global::System.Windows.Point point = global::Infragistics.Windows.Utilities.PointFromScreenSafe(this, default(global::System.Windows.Point));
			double lastDelta = this._lastDelta;
			this._lastDelta = delta;
			if (isComplete || !this.ShowsPreview)
			{
				if (this._lastReferencePoint != null && this._lastReferencePoint == point)
				{
					delta -= lastDelta;
				}
				this._lastReferencePoint = new global::System.Windows.Point?(point);
			}
			if (!showsPreview && isComplete)
			{
				delta = 0.0;
			}
			double num = delta;
			delta = this.ConstrainDelta(delta);
			this._lastDelta -= num - delta;
			if (!isComplete && showsPreview)
			{
				bool flag = this.Orientation == global::System.Windows.Controls.Orientation.Vertical;
				if (this._adorner != null)
				{
					if (flag)
					{
						this._adorner.OffsetX = delta;
					}
					else
					{
						this._adorner.OffsetY = delta;
					}
				}
				if (this._previewWindow != null)
				{
					if (flag)
					{
						this._previewWindow.HorizontalAlignmentOffset = delta;
					}
					else
					{
						this._previewWindow.VerticalAlignmentOffset = delta;
					}
					if (!this._previewWindow.IsVisible)
					{
						this._previewWindow.Show(this, false, true);
						return;
					}
				}
			}
			else
			{
				this.ProcessDelta(delta, isComplete);
			}
		}

		// Token: 0x0400031B RID: 795
		private static readonly global::System.Windows.Input.Cursor _defaultHorzCursor;

		// Token: 0x0400031C RID: 796
		private static readonly global::System.Windows.Input.Cursor _defaultVertCursor;

		// Token: 0x0400031D RID: 797
		private global::Infragistics.Windows.DockManager.PaneSplitter.SplitterPreviewAdorner _adorner;

		// Token: 0x0400031E RID: 798
		private global::System.Windows.Point? _lastReferencePoint = null;

		// Token: 0x0400031F RID: 799
		private double _lastDelta = double.NaN;

		// Token: 0x04000320 RID: 800
		private global::Infragistics.Windows.Controls.ToolWindow _previewWindow;

		// Token: 0x04000321 RID: 801
		public static readonly global::System.Windows.ResourceKey PreviewStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.PaneSplitter), "PreviewStyleKey");

		// Token: 0x04000322 RID: 802
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DockManager.PaneSplitter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.OrientationVerticalBox));

		// Token: 0x04000323 RID: 803
		internal static readonly global::System.Windows.DependencyProperty ShowsPreviewProperty = global::System.Windows.DependencyProperty.Register("ShowsPreview", typeof(bool), typeof(global::Infragistics.Windows.DockManager.PaneSplitter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x04000324 RID: 804
		internal static readonly global::System.Windows.DependencyProperty ElementBeforeSplitterProperty = global::System.Windows.DependencyProperty.Register("ElementBeforeSplitter", typeof(global::System.Windows.FrameworkElement), typeof(global::Infragistics.Windows.DockManager.PaneSplitter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.PaneSplitter.OnElementBeforeSplitterChanged)));

		// Token: 0x04000325 RID: 805
		internal static readonly global::System.Windows.DependencyPropertyKey SplitterPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("Splitter", typeof(global::Infragistics.Windows.DockManager.PaneSplitter), typeof(global::Infragistics.Windows.DockManager.PaneSplitter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000326 RID: 806
		internal static readonly global::System.Windows.DependencyProperty SplitterProperty = global::Infragistics.Windows.DockManager.PaneSplitter.SplitterPropertyKey.DependencyProperty;

		// Token: 0x04000327 RID: 807
		internal static readonly global::System.Windows.DependencyPropertyKey SplitterVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("SplitterVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DockManager.PaneSplitter), new global::System.Windows.FrameworkPropertyMetadata((global::System.Windows.Visibility)global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x04000328 RID: 808
		internal static readonly global::System.Windows.DependencyProperty SplitterVisibilityProperty = global::Infragistics.Windows.DockManager.PaneSplitter.SplitterVisibilityPropertyKey.DependencyProperty;

		// Token: 0x02000086 RID: 134
		private class SplitterPreviewAdorner : global::System.Windows.Documents.Adorner
		{
			// Token: 0x060004E1 RID: 1249 RVA: 0x0001AC30 File Offset: 0x00018E30
			public SplitterPreviewAdorner(global::Infragistics.Windows.DockManager.PaneSplitter splitter) : base(splitter)
			{
				global::System.Windows.Controls.Control child = splitter.CreatePreviewControl();
				this._element = new global::System.Windows.Controls.Decorator
				{
					Child = child
				};
				this._transform = new global::System.Windows.Media.TranslateTransform();
				this._element.RenderTransform = this._transform;
				base.AddVisualChild(this._element);
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0001AC87 File Offset: 0x00018E87
			// (set) Token: 0x060004E3 RID: 1251 RVA: 0x0001AC94 File Offset: 0x00018E94
			public double OffsetX
			{
				get
				{
					return this._transform.X;
				}
				set
				{
					this._transform.X = value;
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0001ACA2 File Offset: 0x00018EA2
			// (set) Token: 0x060004E5 RID: 1253 RVA: 0x0001ACAF File Offset: 0x00018EAF
			public double OffsetY
			{
				get
				{
					return this._transform.Y;
				}
				set
				{
					this._transform.Y = value;
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0001ACBD File Offset: 0x00018EBD
			protected override int VisualChildrenCount
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x060004E7 RID: 1255 RVA: 0x0001ACC0 File Offset: 0x00018EC0
			protected override global::System.Windows.Media.Visual GetVisualChild(int index)
			{
				if (index == 0)
				{
					return this._element;
				}
				return base.GetVisualChild(index);
			}

			// Token: 0x060004E8 RID: 1256 RVA: 0x0001ACD3 File Offset: 0x00018ED3
			protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
			{
				this._element.Arrange(new global::System.Windows.Rect(finalSize));
				return finalSize;
			}

			// Token: 0x04000329 RID: 809
			private global::System.Windows.UIElement _element;

			// Token: 0x0400032A RID: 810
			private global::System.Windows.Media.TranslateTransform _transform;
		}
	}
}
