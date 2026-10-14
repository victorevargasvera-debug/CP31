using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using Infragistics.AutomationPeers;
using Infragistics.Themes;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls
{
	// Token: 0x0200002B RID: 43
	[global::System.Windows.StyleTypedProperty(Property = "VerticalScaleBottomStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentControl))]
	[global::System.Windows.StyleTypedProperty(Property = "VerticalScrollTopStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentControl))]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamZoombar", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV | global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB)]
	[global::System.Windows.TemplatePart(Name = "HorizontalThumbElement", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "HorizontalScaleLeftElement", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.StyleTypedProperty(Property = "VerticalThumbStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentControl))]
	[global::System.Windows.TemplatePart(Name = "VerticalScrollbarElement", Type = typeof(global::System.Windows.Controls.Grid))]
	[global::System.Windows.StyleTypedProperty(Property = "VerticalScaleTopStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentControl))]
	[global::System.Windows.StyleTypedProperty(Property = "VerticalScrollBottomStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentControl))]
	[global::System.Windows.TemplatePart(Name = "VerticalTrackElement", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.StyleTypedProperty(Property = "HorizontalScrollRightStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentControl))]
	[global::System.Windows.TemplatePart(Name = "HorizontalPreviewElement", Type = typeof(global::System.Windows.Controls.Panel))]
	[global::System.Windows.TemplatePart(Name = "HorizontalScrollbarElement", Type = typeof(global::System.Windows.Controls.Grid))]
	[global::System.Windows.TemplatePart(Name = "HorizontalTrackElement", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "HorizontalScrollLeftElement", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "HorizontalScrollRightElement", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "HorizontalScaleRightElement", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "VerticalRootCanvasElement", Type = typeof(global::System.Windows.Controls.Canvas))]
	[global::System.Windows.TemplatePart(Name = "VerticalPreviewElement", Type = typeof(global::System.Windows.Controls.Panel))]
	[global::System.Windows.TemplatePart(Name = "HorizontalRootCanvasElement", Type = typeof(global::System.Windows.Controls.Canvas))]
	[global::System.Windows.TemplatePart(Name = "VerticalScrollTopElement", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "VerticalScrollBottomElement", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "VerticalThumbElement", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "VerticalScaleTopElement", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "VerticalScaleBottomElement", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.StyleTypedProperty(Property = "HorizontalScaleLeftStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentControl))]
	[global::System.Windows.StyleTypedProperty(Property = "HorizontalScaleRightStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentControl))]
	[global::System.Windows.StyleTypedProperty(Property = "HorizontalThumbStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentControl))]
	[global::System.Windows.StyleTypedProperty(Property = "HorizontalScrollLeftStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentControl))]
	public class XamZoombar : global::Infragistics.InteractiveControl
	{
		// Token: 0x0600022B RID: 555 RVA: 0x0000A788 File Offset: 0x00008988
		static XamZoombar()
		{
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Controls.XamZoombar));
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000ABA4 File Offset: 0x00008DA4
		public XamZoombar()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.XamZoombar);
			base.SetBinding(global::Infragistics.Controls.XamZoombar.NewStyleProperty, new global::System.Windows.Data.Binding("Style")
			{
				Source = this
			});
			this.horizontalThumbNode = new global::Infragistics.Controls.HorizontalThumbNode();
			base.VisualElements.Add(this.horizontalThumbNode);
			this.verticalThumbNode = new global::Infragistics.Controls.VerticalThumbNode();
			base.VisualElements.Add(this.verticalThumbNode);
			this.Timer = new global::System.Windows.Threading.DispatcherTimer();
			this.Timer.Tick += this.timer_Tick;
			this.Timer.Interval = global::System.TimeSpan.FromMilliseconds(250.0);
			this.ActualMinimum = 0.0;
			this.ActualMaximum = 1.0;
			base.MouseDownTools.Add(new global::Infragistics.Controls.TrackbarTool(this));
			base.MouseDownTools.Add(new global::Infragistics.Controls.ResizingTool(this));
			base.MouseDownTools.Add(new global::Infragistics.Controls.DraggingTool(this));
			this.horizontalVisualElements = new global::System.Collections.Generic.List<global::Infragistics.VisualElement>();
			this.verticalVisualElements = new global::System.Collections.Generic.List<global::Infragistics.VisualElement>();
			this.Initialize = true;
			this.Range = new global::Infragistics.Controls.Range();
			this.TempRange = new global::Infragistics.Controls.Range();
			this.TempRange.Zoombar = this;
			this.TempRange.Initialize = true;
			base.SizeChanged += this.XamZoombar_SizeChanged;
			base.LayoutUpdated += this.XamZoombar_LayoutUpdated;
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.XamZoombar), this);
			base.SetBinding(global::Infragistics.Controls.XamZoombar.VisibilityProxyProperty, new global::System.Windows.Data.Binding("Visibility")
			{
				Source = this
			});
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000AD49 File Offset: 0x00008F49
		private void OnVisibilityChanged(global::System.Windows.Visibility oldValue, global::System.Windows.Visibility newValue)
		{
			this.UpdateThumb();
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600022E RID: 558 RVA: 0x0000AD54 File Offset: 0x00008F54
		// (remove) Token: 0x0600022F RID: 559 RVA: 0x0000AD8C File Offset: 0x00008F8C
		public event global::System.EventHandler<global::Infragistics.Controls.ZoomChangedEventArgs> ZoomChanged;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000230 RID: 560 RVA: 0x0000ADC4 File Offset: 0x00008FC4
		// (remove) Token: 0x06000231 RID: 561 RVA: 0x0000ADFC File Offset: 0x00008FFC
		public event global::System.EventHandler<global::Infragistics.Controls.ZoomChangeEventArgs> ZoomChanging;

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000AE34 File Offset: 0x00009034
		public global::System.Windows.Size PreviewContentSize
		{
			get
			{
				global::System.Windows.Controls.Panel panel;
				if (this.Orientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					panel = this.horizontalPreviewPanel;
				}
				else
				{
					panel = this.verticalPreviewPanel;
				}
				double actualWidth = panel.ActualWidth;
				double actualHeight = panel.ActualHeight;
				return new global::System.Windows.Size(actualWidth, actualHeight);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000AE6E File Offset: 0x0000906E
		// (set) Token: 0x06000234 RID: 564 RVA: 0x0000AE7B File Offset: 0x0000907B
		public object HorizontalPreviewContent
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.XamZoombar.HorizontalPreviewContentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.HorizontalPreviewContentProperty, value);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000AE89 File Offset: 0x00009089
		// (set) Token: 0x06000236 RID: 566 RVA: 0x0000AE96 File Offset: 0x00009096
		public object VerticalPreviewContent
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.XamZoombar.VerticalPreviewContentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.VerticalPreviewContentProperty, value);
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000AEA4 File Offset: 0x000090A4
		private global::System.Collections.IEnumerator LogicalChildrenInternal()
		{
			if (this._logicalChildrenInternal == null)
			{
				this._logicalChildrenInternal = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>
				{
					this.VerticalPreviewContent as global::System.Windows.FrameworkElement,
					this.HorizontalPreviewContent as global::System.Windows.FrameworkElement
				};
			}
			return this._logicalChildrenInternal.GetEnumerator();
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000AEF8 File Offset: 0x000090F8
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				if (this.VerticalPreviewContent != null | this.HorizontalPreviewContent != null)
				{
					return this.LogicalChildrenInternal();
				}
				return base.LogicalChildren;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000AF22 File Offset: 0x00009122
		// (set) Token: 0x0600023A RID: 570 RVA: 0x0000AF34 File Offset: 0x00009134
		public global::System.Windows.Style HorizontalScaleLeftStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.XamZoombar.HorizontalScaleLeftStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.HorizontalScaleLeftStyleProperty, value);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000AF42 File Offset: 0x00009142
		// (set) Token: 0x0600023C RID: 572 RVA: 0x0000AF54 File Offset: 0x00009154
		public global::System.Windows.Style HorizontalScaleRightStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.XamZoombar.HorizontalScaleRightStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.HorizontalScaleRightStyleProperty, value);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0000AF62 File Offset: 0x00009162
		// (set) Token: 0x0600023E RID: 574 RVA: 0x0000AF74 File Offset: 0x00009174
		public global::System.Windows.Style HorizontalThumbStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.XamZoombar.HorizontalThumbStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.HorizontalThumbStyleProperty, value);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0000AF82 File Offset: 0x00009182
		// (set) Token: 0x06000240 RID: 576 RVA: 0x0000AF94 File Offset: 0x00009194
		public global::System.Windows.Style HorizontalScrollLeftStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.XamZoombar.HorizontalScrollLeftStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.HorizontalScrollLeftStyleProperty, value);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000241 RID: 577 RVA: 0x0000AFA2 File Offset: 0x000091A2
		// (set) Token: 0x06000242 RID: 578 RVA: 0x0000AFB4 File Offset: 0x000091B4
		public global::System.Windows.Style HorizontalScrollRightStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.XamZoombar.HorizontalScrollRightStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.HorizontalScrollRightStyleProperty, value);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0000AFC2 File Offset: 0x000091C2
		// (set) Token: 0x06000244 RID: 580 RVA: 0x0000AFD4 File Offset: 0x000091D4
		public global::System.Windows.Style VerticalScaleTopStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.XamZoombar.VerticalScaleTopStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.VerticalScaleTopStyleProperty, value);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000AFE2 File Offset: 0x000091E2
		// (set) Token: 0x06000246 RID: 582 RVA: 0x0000AFF4 File Offset: 0x000091F4
		public global::System.Windows.Style VerticalScaleBottomStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.XamZoombar.VerticalScaleBottomStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.VerticalScaleBottomStyleProperty, value);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0000B002 File Offset: 0x00009202
		// (set) Token: 0x06000248 RID: 584 RVA: 0x0000B014 File Offset: 0x00009214
		public global::System.Windows.Style VerticalThumbStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.XamZoombar.VerticalThumbStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.VerticalThumbStyleProperty, value);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000B022 File Offset: 0x00009222
		// (set) Token: 0x0600024A RID: 586 RVA: 0x0000B034 File Offset: 0x00009234
		public global::System.Windows.Style VerticalScrollTopStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.XamZoombar.VerticalScrollTopStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.VerticalScrollTopStyleProperty, value);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000B042 File Offset: 0x00009242
		// (set) Token: 0x0600024C RID: 588 RVA: 0x0000B054 File Offset: 0x00009254
		public global::System.Windows.Style VerticalScrollBottomStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.XamZoombar.VerticalScrollBottomStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.VerticalScrollBottomStyleProperty, value);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000B062 File Offset: 0x00009262
		// (set) Token: 0x0600024E RID: 590 RVA: 0x0000B06A File Offset: 0x0000926A
		public double ActualMinimum
		{
			get
			{
				return this._actualMinimum;
			}
			private set
			{
				this._actualMinimum = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000B073 File Offset: 0x00009273
		// (set) Token: 0x06000250 RID: 592 RVA: 0x0000B085 File Offset: 0x00009285
		public double Minimum
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.XamZoombar.MinimumProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.MinimumProperty, value);
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000B098 File Offset: 0x00009298
		private static void OnMinimumChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.XamZoombar xamZoombar = d as global::Infragistics.Controls.XamZoombar;
			xamZoombar.OnMinimumChanged((double)e.OldValue, (double)e.NewValue);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000B0CA File Offset: 0x000092CA
		protected virtual void OnMinimumChanged(double oldValue, double newValue)
		{
			this.ActualMinimum = newValue;
			if (this.ActualMaximum < this.ActualMinimum)
			{
				this.ActualMaximum = this.ActualMinimum;
				return;
			}
			this.UpdateThumb();
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000B0F4 File Offset: 0x000092F4
		// (set) Token: 0x06000254 RID: 596 RVA: 0x0000B0FC File Offset: 0x000092FC
		public double ActualMaximum
		{
			get
			{
				return this._actualMaximum;
			}
			private set
			{
				this._actualMaximum = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000B105 File Offset: 0x00009305
		// (set) Token: 0x06000256 RID: 598 RVA: 0x0000B117 File Offset: 0x00009317
		public double Maximum
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.XamZoombar.MaximumProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.MaximumProperty, value);
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000B12C File Offset: 0x0000932C
		private static void OnMaximumChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.XamZoombar xamZoombar = d as global::Infragistics.Controls.XamZoombar;
			xamZoombar.OnMaximumChanged((double)e.OldValue, (double)e.NewValue);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000B15E File Offset: 0x0000935E
		protected virtual void OnMaximumChanged(double oldValue, double newValue)
		{
			this.ActualMaximum = newValue;
			if (this.ActualMinimum > this.ActualMaximum)
			{
				this.ActualMinimum = this.ActualMaximum;
				return;
			}
			this.UpdateThumb();
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000B188 File Offset: 0x00009388
		// (set) Token: 0x0600025A RID: 602 RVA: 0x0000B19A File Offset: 0x0000939A
		public global::Infragistics.Controls.Range Range
		{
			get
			{
				return (global::Infragistics.Controls.Range)base.GetValue(global::Infragistics.Controls.XamZoombar.RangeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.RangeProperty, value);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000B1A8 File Offset: 0x000093A8
		private static void OnRangeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.XamZoombar xamZoombar = d as global::Infragistics.Controls.XamZoombar;
			xamZoombar.OnRangeChanged((global::Infragistics.Controls.Range)e.OldValue, (global::Infragistics.Controls.Range)e.NewValue);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000B1DA File Offset: 0x000093DA
		internal void ChangeRange(global::Infragistics.Controls.Range oldRange, global::Infragistics.Controls.Range newRange)
		{
			this.OnRangeChanged(oldRange, newRange);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000B1E4 File Offset: 0x000093E4
		protected virtual void OnRangeChanged(global::Infragistics.Controls.Range oldRange, global::Infragistics.Controls.Range newRange)
		{
			if (newRange == null)
			{
				return;
			}
			newRange.Zoombar = this;
			this.UpdateThumb();
			if (this.ZoomCanceled)
			{
				this.ZoomCanceled = false;
				return;
			}
			if (!this.Initialize)
			{
				global::Infragistics.Controls.ZoomChangeEventArgs zoomChangeEventArgs = new global::Infragistics.Controls.ZoomChangeEventArgs(newRange);
				this.OnZoomChanging(zoomChangeEventArgs);
				if (zoomChangeEventArgs.Cancel)
				{
					this.ZoomCanceled = true;
					this.Range = oldRange;
					return;
				}
			}
			global::Infragistics.Controls.ZoomChangedEventArgs e = new global::Infragistics.Controls.ZoomChangedEventArgs(newRange);
			this.OnZoomChanged(e);
			this.ZoomCanceled = false;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000B254 File Offset: 0x00009454
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0000B25C File Offset: 0x0000945C
		private bool ZoomCanceled
		{
			get
			{
				return this._zoomCanceled;
			}
			set
			{
				this._zoomCanceled = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000B265 File Offset: 0x00009465
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0000B277 File Offset: 0x00009477
		public double SmallChange
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.XamZoombar.SmallChangeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.SmallChangeProperty, value);
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000B28A File Offset: 0x0000948A
		private static void OnSmallChangeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamZoombar)d).OnSmallChangeChanged((double)e.OldValue, (double)e.NewValue);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000B2AF File Offset: 0x000094AF
		protected virtual void OnSmallChangeChanged(double oldValue, double newValue)
		{
			if (!global::Infragistics.Controls.XamZoombar.IsValidChange(newValue))
			{
				throw new global::System.ArgumentException("Zoombar_InvalidChangeValue", global::Infragistics.Controls.XamZoombar.SmallChangeProperty.ToString());
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0000B2CE File Offset: 0x000094CE
		// (set) Token: 0x06000265 RID: 613 RVA: 0x0000B2E0 File Offset: 0x000094E0
		public double LargeChange
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.XamZoombar.LargeChangeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.LargeChangeProperty, value);
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000B2F3 File Offset: 0x000094F3
		private static void OnLargeChangeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamZoombar)d).OnLargeChangeChanged((double)e.OldValue, (double)e.NewValue);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000B318 File Offset: 0x00009518
		protected virtual void OnLargeChangeChanged(double oldValue, double newValue)
		{
			if (!global::Infragistics.Controls.XamZoombar.IsValidChange(newValue))
			{
				throw new global::System.ArgumentException("Zoombar_InvalidChangeValue", global::Infragistics.Controls.XamZoombar.LargeChangeProperty.ToString());
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000B337 File Offset: 0x00009537
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0000B349 File Offset: 0x00009549
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Controls.XamZoombar.OrientationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.OrientationProperty, value);
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000B35C File Offset: 0x0000955C
		private static void OnOrientationChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamZoombar)d).OnOrientationChanged((global::System.Windows.Controls.Orientation)e.OldValue, (global::System.Windows.Controls.Orientation)e.NewValue);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000B384 File Offset: 0x00009584
		protected virtual void OnOrientationChanged(global::System.Windows.Controls.Orientation oldValue, global::System.Windows.Controls.Orientation newValue)
		{
			if (this.Initialize)
			{
				return;
			}
			if (this.verticalRootCanvas == null || this.horizontalRootCanvas == null)
			{
				return;
			}
			if (this.Orientation == global::System.Windows.Controls.Orientation.Horizontal)
			{
				this.verticalRootCanvas.Visibility = global::System.Windows.Visibility.Collapsed;
				this.SetClipMode(this.verticalRootCanvas, true);
				this.SetClipMode(this.horizontalRootCanvas, false);
				this.horizontalRootCanvas.Visibility = global::System.Windows.Visibility.Visible;
				this.SetHorizontalVisualElements();
			}
			else
			{
				this.horizontalRootCanvas.Visibility = global::System.Windows.Visibility.Collapsed;
				this.SetClipMode(this.horizontalRootCanvas, true);
				this.SetClipMode(this.verticalRootCanvas, false);
				this.verticalRootCanvas.Visibility = global::System.Windows.Visibility.Visible;
				this.SetVerticalVisualElements();
			}
			this.UpdateThumb();
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000B42C File Offset: 0x0000962C
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this.horizontalThumbNode != null)
			{
				this.horizontalThumbNode.ClearChildren();
			}
			if (this.verticalThumbNode != null)
			{
				this.verticalThumbNode.ClearChildren();
			}
			this.InitHorionatalTemplate();
			this.InitVerticalTemplate();
			if (this.Orientation == global::System.Windows.Controls.Orientation.Horizontal)
			{
				this.SetClipMode(this.verticalRootCanvas, true);
				this.SetHorizontalVisualElements();
				return;
			}
			this.SetClipMode(this.horizontalRootCanvas, true);
			this.SetVerticalVisualElements();
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000B4A0 File Offset: 0x000096A0
		private void SetClipMode(global::System.Windows.FrameworkElement ele, bool clip)
		{
			if (ele != null)
			{
				ele.ClipToBounds = clip;
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000B4AC File Offset: 0x000096AC
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			if (!e.Handled)
			{
				e.Handled = true;
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000B4C4 File Offset: 0x000096C4
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			if (!e.Handled)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000B4DC File Offset: 0x000096DC
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
			{
				switch (e.Key)
				{
				case global::System.Windows.Input.Key.Up:
					this.MoveTo(this.ActualMinimum, true);
					return;
				case global::System.Windows.Input.Key.Right:
					break;
				case global::System.Windows.Input.Key.Down:
					this.MoveTo(this.ActualMaximum, true);
					return;
				default:
					return;
				}
			}
			else
			{
				switch (e.Key)
				{
				case global::System.Windows.Input.Key.Left:
					this.MoveTo(this.ActualMinimum, true);
					return;
				case global::System.Windows.Input.Key.Up:
					break;
				case global::System.Windows.Input.Key.Right:
					this.MoveTo(this.ActualMaximum, true);
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000B56C File Offset: 0x0000976C
		protected override void OnKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyUp(e);
			switch (e.Key)
			{
			case global::System.Windows.Input.Key.Left:
			case global::System.Windows.Input.Key.Up:
			case global::System.Windows.Input.Key.Right:
			case global::System.Windows.Input.Key.Down:
				this.StopMove();
				return;
			default:
				return;
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000B5A8 File Offset: 0x000097A8
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size size = base.MeasureOverride(availableSize);
			if (double.IsInfinity(availableSize.Width))
			{
				availableSize.Width = size.Width;
			}
			if (double.IsInfinity(availableSize.Height))
			{
				availableSize.Height = size.Height;
			}
			return availableSize;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000B5F8 File Offset: 0x000097F8
		public override string ToString()
		{
			if (this.Range != null)
			{
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0} Minimum:{1} Maximum:{2} Range.Minimum:{3} Range.Maximum:{4}", new object[]
				{
					base.ToString(),
					this.ActualMinimum,
					this.ActualMaximum,
					this.Range.Minimum,
					this.Range.Maximum
				});
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0} Minimum:{1} Maximum:{2} Range.Minimum:{3} Range.Maximum:{4}", new object[]
			{
				base.ToString(),
				this.ActualMinimum,
				this.ActualMaximum,
				this.ActualMinimum,
				this.ActualMaximum
			});
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000B6C8 File Offset: 0x000098C8
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.XamZoombarAutomationPeer(this);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000B6D0 File Offset: 0x000098D0
		protected virtual void OnZoomChanged(global::Infragistics.Controls.ZoomChangedEventArgs e)
		{
			if (this.ZoomChanged != null)
			{
				this.ZoomChanged(this, e);
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000B6E7 File Offset: 0x000098E7
		protected virtual void OnZoomChanging(global::Infragistics.Controls.ZoomChangeEventArgs e)
		{
			if (this.ZoomChanging != null)
			{
				this.ZoomChanging(this, e);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000B6FE File Offset: 0x000098FE
		// (set) Token: 0x06000278 RID: 632 RVA: 0x0000B710 File Offset: 0x00009910
		private global::System.Windows.Style NewStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.XamZoombar.NewStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamZoombar.NewStyleProperty, value);
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000B71E File Offset: 0x0000991E
		private static void OnNewStyleChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamZoombar)d).OnNewStyleChanged((global::System.Windows.Style)e.OldValue, (global::System.Windows.Style)e.NewValue);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000B744 File Offset: 0x00009944
		private void OnNewStyleChanged(global::System.Windows.Style oldValue, global::System.Windows.Style newValue)
		{
			if (this.horizontalPreviewPanel != null && this.horizontalPreviewPanel.Children.Count > 0)
			{
				global::System.Windows.Controls.ContentPresenter contentPresenter = this.horizontalPreviewPanel.Children[0] as global::System.Windows.Controls.ContentPresenter;
				if (contentPresenter != null && contentPresenter.Content != null)
				{
					contentPresenter.Content = null;
				}
			}
			if (this.verticalPreviewPanel != null && this.verticalPreviewPanel.Children.Count > 0)
			{
				global::System.Windows.Controls.ContentPresenter contentPresenter2 = this.verticalPreviewPanel.Children[0] as global::System.Windows.Controls.ContentPresenter;
				if (contentPresenter2 != null && contentPresenter2.Content != null)
				{
					contentPresenter2.Content = null;
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0000B7D9 File Offset: 0x000099D9
		// (set) Token: 0x0600027C RID: 636 RVA: 0x0000B7E1 File Offset: 0x000099E1
		internal bool IsSizeChanged
		{
			get
			{
				return this._isSizeChanged;
			}
			set
			{
				this._isSizeChanged = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0000B7EA File Offset: 0x000099EA
		// (set) Token: 0x0600027E RID: 638 RVA: 0x0000B7F2 File Offset: 0x000099F2
		internal global::Infragistics.Controls.Range TempRange
		{
			get
			{
				return this._tempRange;
			}
			set
			{
				this._tempRange = value;
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000B7FC File Offset: 0x000099FC
		internal double CalculateMinScale()
		{
			double result;
			if (this.Orientation == global::System.Windows.Controls.Orientation.Horizontal)
			{
				if (this.ScrollAreaWidth <= 0.0)
				{
					result = 1.0;
				}
				else
				{
					result = (this.LeftScaleWidth + this.RightScaleWidth) / this.ScrollAreaWidth;
				}
			}
			else if (this.ScrollAreaHeight <= 0.0)
			{
				result = 1.0;
			}
			else
			{
				result = (this.TopScaleHeight + this.BottomScaleHeight) / this.ScrollAreaHeight;
			}
			return result;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000B878 File Offset: 0x00009A78
		internal double CalculateValue(global::System.Windows.Point pt)
		{
			double num3;
			if (this.Orientation == global::System.Windows.Controls.Orientation.Horizontal)
			{
				double num = pt.X - this.LeftOffset;
				double num2 = this.ScrollAreaWidth;
				if (num2 <= 0.0)
				{
					if (num == 0.0)
					{
						num3 = 0.0;
					}
					else
					{
						num3 = 1.0;
					}
				}
				else
				{
					num3 = num / num2;
				}
			}
			else
			{
				double num4 = pt.Y - this.TopOffset;
				double num5 = this.ScrollAreaHeight;
				if (num5 <= 0.0)
				{
					if (num4 == 0.0)
					{
						num3 = 0.0;
					}
					else
					{
						num3 = 1.0;
					}
				}
				else
				{
					num3 = num4 / num5;
				}
			}
			double num6 = this.ActualMaximum - this.ActualMinimum;
			return this.ActualMinimum + num6 * num3;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000B944 File Offset: 0x00009B44
		internal void RaiseZoomChangingEvent()
		{
			global::Infragistics.Controls.ZoomChangeEventArgs zoomChangeEventArgs = new global::Infragistics.Controls.ZoomChangeEventArgs(this.TempRange);
			this.OnZoomChanging(zoomChangeEventArgs);
			if (zoomChangeEventArgs.Cancel)
			{
				global::Infragistics.Controls.ICancelableTool cancelableTool = base.CurrentTool as global::Infragistics.Controls.ICancelableTool;
				if (cancelableTool != null)
				{
					cancelableTool.IsCanceled = true;
					cancelableTool.StopTool();
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0000B988 File Offset: 0x00009B88
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0000B990 File Offset: 0x00009B90
		internal double LeftScrollWidth
		{
			get
			{
				return this.leftScrollWidth;
			}
			set
			{
				this.leftScrollWidth = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000B999 File Offset: 0x00009B99
		// (set) Token: 0x06000285 RID: 645 RVA: 0x0000B9A1 File Offset: 0x00009BA1
		internal double RightScrollWidth
		{
			get
			{
				return this.rightScrollWidth;
			}
			set
			{
				this.rightScrollWidth = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000B9AA File Offset: 0x00009BAA
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0000B9B2 File Offset: 0x00009BB2
		internal double LeftScaleWidth
		{
			get
			{
				return this.leftScaleWidth;
			}
			set
			{
				this.leftScaleWidth = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000B9BB File Offset: 0x00009BBB
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0000B9C3 File Offset: 0x00009BC3
		internal double RightScaleWidth
		{
			get
			{
				return this.rightScaleWidth;
			}
			set
			{
				this.rightScaleWidth = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000B9CC File Offset: 0x00009BCC
		// (set) Token: 0x0600028B RID: 651 RVA: 0x0000B9D4 File Offset: 0x00009BD4
		internal double ScrollAreaWidth
		{
			get
			{
				return this.scrollAreaWidth;
			}
			set
			{
				this.scrollAreaWidth = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000B9DD File Offset: 0x00009BDD
		internal double LeftOffset
		{
			get
			{
				return this.LeftScrollWidth;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0000B9E5 File Offset: 0x00009BE5
		internal double RightOffset
		{
			get
			{
				return this.RightScrollWidth;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000B9ED File Offset: 0x00009BED
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0000B9F5 File Offset: 0x00009BF5
		internal double TopScrollHeight
		{
			get
			{
				return this.topScrollHeight;
			}
			set
			{
				this.topScrollHeight = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0000B9FE File Offset: 0x00009BFE
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0000BA06 File Offset: 0x00009C06
		internal double BottomScrollHeight
		{
			get
			{
				return this.bottomScrollHeight;
			}
			set
			{
				this.bottomScrollHeight = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000BA0F File Offset: 0x00009C0F
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0000BA17 File Offset: 0x00009C17
		internal double TopScaleHeight
		{
			get
			{
				return this.topScaleHeight;
			}
			set
			{
				this.topScaleHeight = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000BA20 File Offset: 0x00009C20
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0000BA28 File Offset: 0x00009C28
		internal double BottomScaleHeight
		{
			get
			{
				return this.bottomScaleHeight;
			}
			set
			{
				this.bottomScaleHeight = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000BA31 File Offset: 0x00009C31
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0000BA39 File Offset: 0x00009C39
		internal double ScrollAreaHeight
		{
			get
			{
				return this.scrollAreaHeight;
			}
			set
			{
				this.scrollAreaHeight = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000BA42 File Offset: 0x00009C42
		internal double TopOffset
		{
			get
			{
				return this.TopScrollHeight;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0000BA4A File Offset: 0x00009C4A
		internal double BottomOffset
		{
			get
			{
				return this.BottomScrollHeight;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000BA52 File Offset: 0x00009C52
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0000BA5A File Offset: 0x00009C5A
		private bool IsMoved { get; set; }

		// Token: 0x0600029C RID: 668 RVA: 0x0000BA63 File Offset: 0x00009C63
		private void SizeUpdated()
		{
			this.Initialize = false;
			if (base.ActualWidth == 0.0 || base.ActualHeight == 0.0)
			{
				return;
			}
			this.UpdateElementPositions();
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000BA95 File Offset: 0x00009C95
		private static bool IsValidChange(double value)
		{
			return global::Infragistics.Controls.XamZoombar.IsValidDoubleValue(value) && value >= 0.0;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000BAB0 File Offset: 0x00009CB0
		private static bool IsValidDoubleValue(double value)
		{
			return !double.IsNaN(value) && !double.IsInfinity(value);
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0000BAC5 File Offset: 0x00009CC5
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x0000BACD File Offset: 0x00009CCD
		private bool Initialize
		{
			get
			{
				return this._initialize;
			}
			set
			{
				this._initialize = value;
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		private void InitHorionatalTemplate()
		{
			if (this.horizontalRootCanvas != null)
			{
				this.horizontalRootCanvas.SizeChanged -= this.HorizontalRootCanvas_SizeChanged;
				this.horizontalRootCanvas.Children.Clear();
			}
			this.horizontalRootCanvas = (base.GetTemplateChild("HorizontalRootCanvasElement") as global::System.Windows.Controls.Canvas);
			if (this.horizontalRootCanvas != null)
			{
				this.horizontalRootCanvas.SizeChanged += this.HorizontalRootCanvas_SizeChanged;
			}
			if (this.horizontalPreviewPanel != null)
			{
				this.horizontalPreviewPanel.Children.Clear();
			}
			this.horizontalPreviewPanel = (base.GetTemplateChild("HorizontalPreviewElement") as global::System.Windows.Controls.Panel);
			this.horizontalScrollbarElement = (base.GetTemplateChild("HorizontalScrollbarElement") as global::System.Windows.Controls.Grid);
			global::System.Windows.FrameworkElement frameworkElement = base.GetTemplateChild("HorizontalTrackElement") as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				this.horizontalTrackShape = new global::Infragistics.Controls.TrackShape(frameworkElement);
				this.horizontalVisualElements.Add(this.horizontalTrackShape);
			}
			this.horizontalScrollLeftElement = (base.GetTemplateChild("HorizontalScrollLeftElement") as global::System.Windows.FrameworkElement);
			if (this.horizontalScrollLeftElement != null)
			{
				this.horizontalScrollLeftShape = new global::Infragistics.Controls.ScrollShape(this.horizontalScrollLeftElement);
				this.horizontalVisualElements.Add(this.horizontalScrollLeftShape);
			}
			this.horizontalScrollRightElement = (base.GetTemplateChild("HorizontalScrollRightElement") as global::System.Windows.FrameworkElement);
			if (this.horizontalScrollRightElement != null)
			{
				this.horizontalScrollRightShape = new global::Infragistics.Controls.ScrollShape(this.horizontalScrollRightElement);
				this.horizontalVisualElements.Add(this.horizontalScrollRightShape);
			}
			global::System.Windows.FrameworkElement frameworkElement2 = base.GetTemplateChild("HorizontalThumbElement") as global::System.Windows.FrameworkElement;
			if (frameworkElement2 != null)
			{
				this.horizontalThumbShape = new global::Infragistics.ShapeElement();
				this.horizontalThumbShape.FrameworkElements.Add(frameworkElement2);
			}
			global::System.Windows.FrameworkElement frameworkElement3 = base.GetTemplateChild("HorizontalScaleLeftElement") as global::System.Windows.FrameworkElement;
			if (frameworkElement3 != null)
			{
				this.horizontalScaleLeftShape = new global::Infragistics.ShapeElement();
				this.horizontalScaleLeftShape.FrameworkElements.Add(frameworkElement3);
			}
			global::System.Windows.FrameworkElement frameworkElement4 = base.GetTemplateChild("HorizontalScaleRightElement") as global::System.Windows.FrameworkElement;
			if (frameworkElement4 != null)
			{
				this.horizontalScaleRightShape = new global::Infragistics.ShapeElement();
				this.horizontalScaleRightShape.FrameworkElements.Add(frameworkElement4);
			}
			this.horizontalThumbNode = this.CreateHorizontalThumbNode();
			this.horizontalVisualElements.Add(this.horizontalThumbNode);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000BCEC File Offset: 0x00009EEC
		private void InitVerticalTemplate()
		{
			if (this.verticalRootCanvas != null)
			{
				this.verticalRootCanvas.SizeChanged -= this.VerticalRootCanvas_SizeChanged;
				this.verticalRootCanvas.Children.Clear();
			}
			this.verticalRootCanvas = (base.GetTemplateChild("VerticalRootCanvasElement") as global::System.Windows.Controls.Canvas);
			if (this.verticalRootCanvas != null)
			{
				this.verticalRootCanvas.SizeChanged += this.VerticalRootCanvas_SizeChanged;
			}
			if (this.verticalPreviewPanel != null)
			{
				this.verticalPreviewPanel.Children.Clear();
			}
			this.verticalPreviewPanel = (base.GetTemplateChild("VerticalPreviewElement") as global::System.Windows.Controls.Panel);
			this.verticalScrollbarElement = (base.GetTemplateChild("VerticalScrollbarElement") as global::System.Windows.Controls.Grid);
			global::System.Windows.FrameworkElement frameworkElement = base.GetTemplateChild("VerticalTrackElement") as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				this.verticalTrackShape = new global::Infragistics.Controls.TrackShape(frameworkElement);
				this.verticalVisualElements.Add(this.verticalTrackShape);
			}
			this.verticalScrollTopElement = (base.GetTemplateChild("VerticalScrollTopElement") as global::System.Windows.FrameworkElement);
			if (this.verticalScrollTopElement != null)
			{
				this.verticalScrollTopShape = new global::Infragistics.Controls.ScrollShape(this.verticalScrollTopElement);
				this.verticalVisualElements.Add(this.verticalScrollTopShape);
			}
			this.verticalScrollBottomElement = (base.GetTemplateChild("VerticalScrollBottomElement") as global::System.Windows.FrameworkElement);
			if (this.verticalScrollBottomElement != null)
			{
				this.verticalScrollBottomShape = new global::Infragistics.Controls.ScrollShape(this.verticalScrollBottomElement);
				this.verticalVisualElements.Add(this.verticalScrollBottomShape);
			}
			global::System.Windows.FrameworkElement frameworkElement2 = base.GetTemplateChild("VerticalThumbElement") as global::System.Windows.FrameworkElement;
			if (frameworkElement2 != null)
			{
				this.verticalThumbShape = new global::Infragistics.ShapeElement();
				this.verticalThumbShape.FrameworkElements.Add(frameworkElement2);
			}
			global::System.Windows.FrameworkElement frameworkElement3 = base.GetTemplateChild("VerticalScaleTopElement") as global::System.Windows.FrameworkElement;
			if (frameworkElement3 != null)
			{
				this.verticalScaleTopShape = new global::Infragistics.ShapeElement();
				this.verticalScaleTopShape.FrameworkElements.Add(frameworkElement3);
			}
			global::System.Windows.FrameworkElement frameworkElement4 = base.GetTemplateChild("VerticalScaleBottomElement") as global::System.Windows.FrameworkElement;
			if (frameworkElement4 != null)
			{
				this.verticalScaleBottomShape = new global::Infragistics.ShapeElement();
				this.verticalScaleBottomShape.FrameworkElements.Add(frameworkElement4);
			}
			this.verticalThumbNode = this.CreateVerticalThumbNode();
			this.verticalVisualElements.Add(this.verticalThumbNode);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000BF00 File Offset: 0x0000A100
		private void RemoveVisualElements()
		{
			if (this.Initialize)
			{
				return;
			}
			if (this.Canvas != null)
			{
				for (int i = base.VisualElements.Count - 1; i >= 0; i--)
				{
					base.VisualElements.RemoveAt(i);
				}
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000BF44 File Offset: 0x0000A144
		private void SetHorizontalVisualElements()
		{
			this.RemoveVisualElements();
			this.Canvas = this.horizontalRootCanvas;
			foreach (global::Infragistics.VisualElement item in this.horizontalVisualElements)
			{
				base.VisualElements.Add(item);
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000BFB0 File Offset: 0x0000A1B0
		private void SetVerticalVisualElements()
		{
			this.RemoveVisualElements();
			this.Canvas = this.verticalRootCanvas;
			foreach (global::Infragistics.VisualElement item in this.verticalVisualElements)
			{
				base.VisualElements.Add(item);
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000C01C File Offset: 0x0000A21C
		private void HorizontalRootCanvas_SizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			if (base.ActualWidth > 0.0 && base.ActualHeight > 0.0)
			{
				this.horizontalScrollbarElement.Width = base.ActualWidth;
				this.horizontalScrollbarElement.Height = base.ActualHeight;
			}
			this.UpdateElementPositions();
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000C074 File Offset: 0x0000A274
		private void VerticalRootCanvas_SizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			if (base.ActualWidth > 0.0 && base.ActualHeight > 0.0)
			{
				this.verticalScrollbarElement.Width = base.ActualWidth;
				this.verticalScrollbarElement.Height = base.ActualHeight;
			}
			this.UpdateElementPositions();
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000C0CB File Offset: 0x0000A2CB
		private void XamZoombar_SizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			this.IsSizeChanged = true;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000C0D4 File Offset: 0x0000A2D4
		private void XamZoombar_LayoutUpdated(object sender, global::System.EventArgs e)
		{
			if (!this.IsSizeChanged)
			{
				return;
			}
			this.SizeUpdated();
			this.IsSizeChanged = false;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000C0EC File Offset: 0x0000A2EC
		private void HorizontalPreviewPanel_Unloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this.horizontalPreviewPanel != null && this.horizontalPreviewPanel.Children.Count > 0)
			{
				global::System.Windows.Controls.ContentPresenter contentPresenter = this.horizontalPreviewPanel.Children[0] as global::System.Windows.Controls.ContentPresenter;
				if (contentPresenter != null && contentPresenter.Content != null)
				{
					contentPresenter.Content = null;
				}
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000C140 File Offset: 0x0000A340
		private void VerticalPreviewPanel_Unloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this.verticalPreviewPanel != null && this.verticalPreviewPanel.Children.Count > 0)
			{
				global::System.Windows.Controls.ContentPresenter contentPresenter = this.verticalPreviewPanel.Children[0] as global::System.Windows.Controls.ContentPresenter;
				if (contentPresenter != null && contentPresenter.Content != null)
				{
					contentPresenter.Content = null;
				}
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000C194 File Offset: 0x0000A394
		private void UpdateElementPositions()
		{
			if (base.ActualWidth == 0.0 || base.ActualHeight == 0.0)
			{
				return;
			}
			if (this.Orientation == global::System.Windows.Controls.Orientation.Horizontal)
			{
				this.UpdateVerticalLayout();
				if (this.verticalRootCanvas != null)
				{
					this.verticalRootCanvas.Visibility = global::System.Windows.Visibility.Collapsed;
					this.horizontalRootCanvas.Visibility = global::System.Windows.Visibility.Visible;
					this.horizontalRootCanvas.UpdateLayout();
				}
				this.UpdateHorizontalLayout();
			}
			else
			{
				this.UpdateHorizontalLayout();
				if (this.horizontalRootCanvas != null)
				{
					this.horizontalRootCanvas.Visibility = global::System.Windows.Visibility.Collapsed;
					this.verticalRootCanvas.Visibility = global::System.Windows.Visibility.Visible;
					this.verticalRootCanvas.UpdateLayout();
				}
				this.UpdateVerticalLayout();
			}
			this.UpdateThumb();
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000C244 File Offset: 0x0000A444
		private void UpdateHorizontalLayout()
		{
			if (this.horizontalRootCanvas == null)
			{
				return;
			}
			this.LeftScrollWidth = this.horizontalScrollLeftShape.FrameworkElement.ActualWidth;
			this.RightScrollWidth = this.horizontalScrollRightShape.FrameworkElement.ActualWidth;
			global::System.Windows.Size size = new global::System.Windows.Size(base.ActualWidth, base.ActualHeight);
			double num = global::System.Math.Max(size.Width, this.LeftOffset + this.RightOffset);
			this.LeftScaleWidth = this.horizontalScaleLeftShape.Width;
			this.RightScaleWidth = this.horizontalScaleRightShape.Width;
			double leftOffset = this.LeftOffset;
			double rightOffset = this.RightOffset;
			this.ScrollAreaWidth = num - leftOffset - rightOffset;
			double x = num / 2.0 - this.horizontalThumbShape.Width / 2.0;
			double width = this.horizontalThumbShape.Width;
			this.horizontalThumbNode.Bounds = new global::System.Windows.Rect(x, 0.0, width, size.Height);
			this.horizontalScrollLeftShape.MoveLeft = true;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000C350 File Offset: 0x0000A550
		private void UpdateVerticalLayout()
		{
			if (this.verticalRootCanvas == null)
			{
				return;
			}
			this.TopScrollHeight = this.verticalScrollTopShape.FrameworkElement.ActualHeight;
			this.BottomScrollHeight = this.verticalScrollBottomShape.FrameworkElement.ActualHeight;
			global::System.Windows.Size size = new global::System.Windows.Size(base.ActualWidth, base.ActualHeight);
			double num = global::System.Math.Max(size.Height, this.TopOffset + this.BottomOffset);
			this.TopScaleHeight = this.verticalScaleTopShape.Height;
			this.BottomScaleHeight = this.verticalScaleBottomShape.Height;
			double topOffset = this.TopOffset;
			double bottomOffset = this.BottomOffset;
			this.ScrollAreaHeight = num - topOffset - bottomOffset;
			double y = num / 2.0 - this.verticalThumbShape.Height / 2.0;
			double height = this.verticalThumbShape.Height;
			this.verticalThumbNode.Bounds = new global::System.Windows.Rect(0.0, y, size.Width, height);
			this.verticalScrollTopShape.MoveLeft = true;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000C45C File Offset: 0x0000A65C
		private global::Infragistics.Controls.HorizontalThumbNode CreateHorizontalThumbNode()
		{
			if (this.horizontalThumbShape != null)
			{
				this.horizontalThumbNode.Children.Add(this.horizontalThumbShape);
				this.horizontalThumbNode.ThumbBackground = this.horizontalThumbShape;
			}
			if (this.horizontalScaleLeftShape != null)
			{
				this.horizontalThumbNode.Children.Add(this.horizontalScaleLeftShape);
				this.horizontalThumbNode.ScaleLeftElement = this.horizontalScaleLeftShape;
			}
			if (this.horizontalScaleRightShape != null)
			{
				this.horizontalThumbNode.Children.Add(this.horizontalScaleRightShape);
				this.horizontalThumbNode.ScaleRightElement = this.horizontalScaleRightShape;
			}
			return this.horizontalThumbNode;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000C4FC File Offset: 0x0000A6FC
		private global::Infragistics.Controls.VerticalThumbNode CreateVerticalThumbNode()
		{
			if (this.verticalThumbShape != null)
			{
				this.verticalThumbNode.Children.Add(this.verticalThumbShape);
				this.verticalThumbNode.ThumbBackground = this.verticalThumbShape;
			}
			if (this.verticalScaleTopShape != null)
			{
				this.verticalThumbNode.Children.Add(this.verticalScaleTopShape);
				this.verticalThumbNode.ScaleTopElement = this.verticalScaleTopShape;
			}
			if (this.verticalScaleBottomShape != null)
			{
				this.verticalThumbNode.Children.Add(this.verticalScaleBottomShape);
				this.verticalThumbNode.ScaleBottomElement = this.verticalScaleBottomShape;
			}
			return this.verticalThumbNode;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000C59C File Offset: 0x0000A79C
		internal void UpdateThumb()
		{
			if (this.Initialize || this.Range == null)
			{
				return;
			}
			this.UpdateThumb(this.Range);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000C5BB File Offset: 0x0000A7BB
		internal void UpdateTempThumb()
		{
			this.UpdateThumb(this.TempRange);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000C5CC File Offset: 0x0000A7CC
		private void UpdateThumb(global::Infragistics.Controls.Range range)
		{
			if (this.Initialize)
			{
				return;
			}
			if (this.Orientation == global::System.Windows.Controls.Orientation.Horizontal)
			{
				global::System.Windows.Rect bounds = this.horizontalThumbNode.Bounds;
				bounds.Width = global::System.Math.Max(0.0, this.ScrollAreaWidth * range.Scale);
				double num = this.ScrollAreaWidth - bounds.Width;
				bounds.X = this.LeftOffset + num * range.Scroll;
				bounds = this.CalculatePossibleBounds(bounds);
				this.horizontalThumbNode.Bounds = bounds;
				return;
			}
			global::System.Windows.Rect bounds2 = this.verticalThumbNode.Bounds;
			bounds2.Height = global::System.Math.Max(0.0, this.ScrollAreaHeight * range.Scale);
			double num2 = this.ScrollAreaHeight - bounds2.Height;
			bounds2.Y = this.TopOffset + num2 * range.Scroll;
			bounds2 = this.CalculatePossibleBounds(bounds2);
			this.verticalThumbNode.Bounds = bounds2;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000C6BC File Offset: 0x0000A8BC
		private global::System.Windows.Rect CalculatePossibleBounds(global::System.Windows.Rect bounds)
		{
			if (this.Orientation == global::System.Windows.Controls.Orientation.Horizontal)
			{
				double leftOffset = this.LeftOffset;
				double num = base.ActualWidth - this.RightOffset;
				double num2 = global::System.Math.Max(0.0, num - leftOffset);
				if (bounds.Width > num2)
				{
					bounds.Width = num2;
				}
				double num3 = this.LeftScaleWidth + this.RightScaleWidth;
				if (bounds.Width < num3)
				{
					bounds.X -= (num3 - bounds.Width) / 2.0;
					bounds.Width = num3;
				}
				if (bounds.Right > num)
				{
					bounds.X = num - bounds.Width;
				}
				if (bounds.X < leftOffset)
				{
					bounds.X = leftOffset;
				}
			}
			else
			{
				double topOffset = this.TopOffset;
				double num4 = base.ActualHeight - this.BottomOffset;
				double num5 = global::System.Math.Max(0.0, num4 - topOffset);
				if (bounds.Height > num5)
				{
					bounds.Height = num5;
				}
				double num6 = this.TopScaleHeight + this.BottomScaleHeight;
				if (bounds.Height < num6)
				{
					bounds.Y -= (num6 - bounds.Height) / 2.0;
					bounds.Height = num6;
				}
				if (bounds.Bottom > num4)
				{
					bounds.Y = num4 - bounds.Height;
				}
				if (bounds.Y < topOffset)
				{
					bounds.Y = topOffset;
				}
			}
			return bounds;
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000C838 File Offset: 0x0000AA38
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x0000C840 File Offset: 0x0000AA40
		private global::System.Windows.Threading.DispatcherTimer Timer
		{
			get
			{
				return this._timer;
			}
			set
			{
				this._timer = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000C849 File Offset: 0x0000AA49
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x0000C851 File Offset: 0x0000AA51
		private double NewValue
		{
			get
			{
				return this._newValue;
			}
			set
			{
				this._newValue = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000C85A File Offset: 0x0000AA5A
		// (set) Token: 0x060002BA RID: 698 RVA: 0x0000C862 File Offset: 0x0000AA62
		private bool IsSmallChange
		{
			get
			{
				return this._isSmallChange;
			}
			set
			{
				this._isSmallChange = value;
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000C86B File Offset: 0x0000AA6B
		internal void MoveTo(double newValue, bool isSmallChange)
		{
			this.IsMoved = false;
			this.NewValue = newValue;
			this.IsSmallChange = isSmallChange;
			this.Timer.Start();
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000C88D File Offset: 0x0000AA8D
		internal void StopMove()
		{
			this.Timer.Stop();
			if (!this.IsMoved)
			{
				this.DoMove();
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000C8A8 File Offset: 0x0000AAA8
		private void timer_Tick(object sender, global::System.EventArgs e)
		{
			this.DoMove();
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000C8B0 File Offset: 0x0000AAB0
		private void DoMove()
		{
			this.IsMoved = true;
			double num = (this.Range.Minimum + this.Range.Maximum) / 2.0;
			double num2 = this.IsSmallChange ? this.SmallChange : this.LargeChange;
			if (num == this.NewValue)
			{
				this.StopMove();
				return;
			}
			global::Infragistics.Controls.Range range = new global::Infragistics.Controls.Range();
			range.Initialize = true;
			range.Minimum = this.Range.Minimum - num2;
			range.Maximum = this.Range.Maximum - num2;
			range.Initialize = false;
			if (this.NewValue >= num)
			{
				range.Initialize = true;
				range.Minimum = this.Range.Minimum + num2;
				range.Maximum = this.Range.Maximum + num2;
				range.Initialize = false;
				if (this.NewValue > num)
				{
					if (range.Maximum > this.ActualMaximum)
					{
						double num3 = range.Maximum - this.ActualMaximum;
						range.Initialize = true;
						range.Minimum -= num3;
						range.Maximum = this.ActualMaximum;
						range.Initialize = false;
						this.Range = range;
						this.StopMove();
						return;
					}
					if (this.NewValue < num + num2)
					{
						this.Range = range;
						this.StopMove();
						return;
					}
					this.Range = range;
				}
				return;
			}
			if (range.Minimum < this.ActualMinimum)
			{
				double num4 = this.ActualMinimum - range.Minimum;
				range.Initialize = true;
				range.Minimum = this.ActualMinimum;
				range.Maximum += num4;
				range.Initialize = false;
				this.Range = range;
				this.StopMove();
				return;
			}
			if (this.NewValue > num - num2)
			{
				this.Range = range;
				this.StopMove();
				return;
			}
			this.Range = range;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000CA74 File Offset: 0x0000AC74
		public static void RegisterResources(string name, global::System.Reflection.Assembly assembly)
		{
			global::SR.AddResource(name, assembly);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000CA7D File Offset: 0x0000AC7D
		public static void UnregisterResources(string name)
		{
			global::SR.RemoveResource(name);
		}

		// Token: 0x040000A4 RID: 164
		private const string HorizontalRootCanvasElementName = "HorizontalRootCanvasElement";

		// Token: 0x040000A5 RID: 165
		private const string HorizontalPreviewElementName = "HorizontalPreviewElement";

		// Token: 0x040000A6 RID: 166
		private const string HorizontalScrollbarElementName = "HorizontalScrollbarElement";

		// Token: 0x040000A7 RID: 167
		private const string HorizontalTrackElementName = "HorizontalTrackElement";

		// Token: 0x040000A8 RID: 168
		private const string HorizontalScrollLeftElementName = "HorizontalScrollLeftElement";

		// Token: 0x040000A9 RID: 169
		private const string HorizontalScrollRightElementName = "HorizontalScrollRightElement";

		// Token: 0x040000AA RID: 170
		private const string HorizontalThumbElementName = "HorizontalThumbElement";

		// Token: 0x040000AB RID: 171
		private const string HorizontalScaleLeftElementName = "HorizontalScaleLeftElement";

		// Token: 0x040000AC RID: 172
		private const string HorizontalScaleRightElementName = "HorizontalScaleRightElement";

		// Token: 0x040000AD RID: 173
		private const string VerticalRootCanvasElementName = "VerticalRootCanvasElement";

		// Token: 0x040000AE RID: 174
		private const string VerticalPreviewElementName = "VerticalPreviewElement";

		// Token: 0x040000AF RID: 175
		private const string VerticalScrollbarElementName = "VerticalScrollbarElement";

		// Token: 0x040000B0 RID: 176
		private const string VerticalTrackElementName = "VerticalTrackElement";

		// Token: 0x040000B1 RID: 177
		private const string VerticalScrollTopElementName = "VerticalScrollTopElement";

		// Token: 0x040000B2 RID: 178
		private const string VerticalScrollBottomElementName = "VerticalScrollBottomElement";

		// Token: 0x040000B3 RID: 179
		private const string VerticalThumbElementName = "VerticalThumbElement";

		// Token: 0x040000B4 RID: 180
		private const string VerticalScaleTopElementName = "VerticalScaleTopElement";

		// Token: 0x040000B5 RID: 181
		private const string VerticalScaleBottomElementName = "VerticalScaleBottomElement";

		// Token: 0x040000B6 RID: 182
		private const string FormatString = "{0} Minimum:{1} Maximum:{2} Range.Minimum:{3} Range.Maximum:{4}";

		// Token: 0x040000B7 RID: 183
		protected const string VisibilityProxyPropertyName = "VisibilityProxy";

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Controls.Canvas horizontalRootCanvas;

		// Token: 0x040000B9 RID: 185
		private global::Infragistics.ShapeElement horizontalThumbShape;

		// Token: 0x040000BA RID: 186
		private global::Infragistics.ShapeElement horizontalScaleLeftShape;

		// Token: 0x040000BB RID: 187
		private global::Infragistics.ShapeElement horizontalScaleRightShape;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.FrameworkElement horizontalScrollLeftElement;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.FrameworkElement horizontalScrollRightElement;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Controls.Grid horizontalScrollbarElement;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Controls.Panel horizontalPreviewPanel;

		// Token: 0x040000C0 RID: 192
		private global::Infragistics.Controls.ScrollShape horizontalScrollLeftShape;

		// Token: 0x040000C1 RID: 193
		private global::Infragistics.Controls.ScrollShape horizontalScrollRightShape;

		// Token: 0x040000C2 RID: 194
		private global::Infragistics.Controls.HorizontalThumbNode horizontalThumbNode;

		// Token: 0x040000C3 RID: 195
		private global::Infragistics.Controls.TrackShape horizontalTrackShape;

		// Token: 0x040000C4 RID: 196
		private global::System.Collections.Generic.List<global::Infragistics.VisualElement> horizontalVisualElements;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Controls.Canvas verticalRootCanvas;

		// Token: 0x040000C6 RID: 198
		private global::Infragistics.ShapeElement verticalThumbShape;

		// Token: 0x040000C7 RID: 199
		private global::Infragistics.ShapeElement verticalScaleTopShape;

		// Token: 0x040000C8 RID: 200
		private global::Infragistics.ShapeElement verticalScaleBottomShape;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.FrameworkElement verticalScrollTopElement;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.FrameworkElement verticalScrollBottomElement;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Controls.Grid verticalScrollbarElement;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Controls.Panel verticalPreviewPanel;

		// Token: 0x040000CD RID: 205
		private global::Infragistics.Controls.ScrollShape verticalScrollTopShape;

		// Token: 0x040000CE RID: 206
		private global::Infragistics.Controls.ScrollShape verticalScrollBottomShape;

		// Token: 0x040000CF RID: 207
		private global::Infragistics.Controls.VerticalThumbNode verticalThumbNode;

		// Token: 0x040000D0 RID: 208
		private global::Infragistics.Controls.TrackShape verticalTrackShape;

		// Token: 0x040000D1 RID: 209
		private global::System.Collections.Generic.List<global::Infragistics.VisualElement> verticalVisualElements;

		// Token: 0x040000D2 RID: 210
		private static readonly global::System.Windows.DependencyProperty VisibilityProxyProperty = global::System.Windows.DependencyProperty.Register("VisibilityProxy", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.XamZoombar), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Visible, delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamZoombar)sender).OnVisibilityChanged((global::System.Windows.Visibility)e.OldValue, (global::System.Windows.Visibility)e.NewValue);
		}));

		// Token: 0x040000D5 RID: 213
		public static readonly global::System.Windows.DependencyProperty HorizontalPreviewContentProperty = global::System.Windows.DependencyProperty.Register("HorizontalPreviewContent", typeof(object), typeof(global::Infragistics.Controls.XamZoombar), new global::System.Windows.PropertyMetadata(null, delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.OldValue != null)
			{
				((global::Infragistics.Controls.XamZoombar)sender).RemoveLogicalChild(e.OldValue);
			}
			if (e.NewValue != null)
			{
				((global::Infragistics.Controls.XamZoombar)sender).AddLogicalChild(e.NewValue);
			}
		}));

		// Token: 0x040000D6 RID: 214
		public static readonly global::System.Windows.DependencyProperty VerticalPreviewContentProperty = global::System.Windows.DependencyProperty.Register("VerticalPreviewContent", typeof(object), typeof(global::Infragistics.Controls.XamZoombar), new global::System.Windows.PropertyMetadata(null, delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.OldValue != null)
			{
				((global::Infragistics.Controls.XamZoombar)sender).RemoveLogicalChild(e.OldValue);
			}
			if (e.NewValue != null)
			{
				((global::Infragistics.Controls.XamZoombar)sender).AddLogicalChild(e.NewValue);
			}
		}));

		// Token: 0x040000D7 RID: 215
		private global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> _logicalChildrenInternal;

		// Token: 0x040000D8 RID: 216
		public static readonly global::System.Windows.DependencyProperty HorizontalScaleLeftStyleProperty = global::System.Windows.DependencyProperty.Register("HorizontalScaleLeftStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.XamZoombar), null);

		// Token: 0x040000D9 RID: 217
		public static readonly global::System.Windows.DependencyProperty HorizontalScaleRightStyleProperty = global::System.Windows.DependencyProperty.Register("HorizontalScaleRightStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.XamZoombar), null);

		// Token: 0x040000DA RID: 218
		public static readonly global::System.Windows.DependencyProperty HorizontalThumbStyleProperty = global::System.Windows.DependencyProperty.Register("HorizontalThumbStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.XamZoombar), null);

		// Token: 0x040000DB RID: 219
		public static readonly global::System.Windows.DependencyProperty HorizontalScrollLeftStyleProperty = global::System.Windows.DependencyProperty.Register("HorizontalScrollLeftStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.XamZoombar), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x040000DC RID: 220
		public static readonly global::System.Windows.DependencyProperty HorizontalScrollRightStyleProperty = global::System.Windows.DependencyProperty.Register("HorizontalScrollRightStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.XamZoombar), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x040000DD RID: 221
		public static readonly global::System.Windows.DependencyProperty VerticalScaleTopStyleProperty = global::System.Windows.DependencyProperty.Register("VerticalScaleTopStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.XamZoombar), null);

		// Token: 0x040000DE RID: 222
		public static readonly global::System.Windows.DependencyProperty VerticalScaleBottomStyleProperty = global::System.Windows.DependencyProperty.Register("VerticalScaleBottomStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.XamZoombar), null);

		// Token: 0x040000DF RID: 223
		public static readonly global::System.Windows.DependencyProperty VerticalThumbStyleProperty = global::System.Windows.DependencyProperty.Register("VerticalThumbStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.XamZoombar), null);

		// Token: 0x040000E0 RID: 224
		public static readonly global::System.Windows.DependencyProperty VerticalScrollTopStyleProperty = global::System.Windows.DependencyProperty.Register("VerticalScrollTopStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.XamZoombar), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x040000E1 RID: 225
		public static readonly global::System.Windows.DependencyProperty VerticalScrollBottomStyleProperty = global::System.Windows.DependencyProperty.Register("VerticalScrollBottomStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.XamZoombar), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x040000E2 RID: 226
		private double _actualMinimum;

		// Token: 0x040000E3 RID: 227
		public static readonly global::System.Windows.DependencyProperty MinimumProperty = global::System.Windows.DependencyProperty.Register("Minimum", typeof(double), typeof(global::Infragistics.Controls.XamZoombar), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.XamZoombar.OnMinimumChanged)));

		// Token: 0x040000E4 RID: 228
		private double _actualMaximum;

		// Token: 0x040000E5 RID: 229
		public static readonly global::System.Windows.DependencyProperty MaximumProperty = global::System.Windows.DependencyProperty.Register("Maximum", typeof(double), typeof(global::Infragistics.Controls.XamZoombar), new global::System.Windows.PropertyMetadata(1.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.XamZoombar.OnMaximumChanged)));

		// Token: 0x040000E6 RID: 230
		public static readonly global::System.Windows.DependencyProperty RangeProperty = global::System.Windows.DependencyProperty.Register("Range", typeof(global::Infragistics.Controls.Range), typeof(global::Infragistics.Controls.XamZoombar), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.XamZoombar.OnRangeChanged)));

		// Token: 0x040000E7 RID: 231
		private bool _zoomCanceled;

		// Token: 0x040000E8 RID: 232
		public static readonly global::System.Windows.DependencyProperty SmallChangeProperty = global::System.Windows.DependencyProperty.Register("SmallChange", typeof(double), typeof(global::Infragistics.Controls.XamZoombar), new global::System.Windows.PropertyMetadata(0.1, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.XamZoombar.OnSmallChangeChanged)));

		// Token: 0x040000E9 RID: 233
		public static readonly global::System.Windows.DependencyProperty LargeChangeProperty = global::System.Windows.DependencyProperty.Register("LargeChange", typeof(double), typeof(global::Infragistics.Controls.XamZoombar), new global::System.Windows.PropertyMetadata(0.2, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.XamZoombar.OnLargeChangeChanged)));

		// Token: 0x040000EA RID: 234
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Controls.XamZoombar), new global::System.Windows.PropertyMetadata(global::System.Windows.Controls.Orientation.Horizontal, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.XamZoombar.OnOrientationChanged)));

		// Token: 0x040000EB RID: 235
		private static readonly global::System.Windows.DependencyProperty NewStyleProperty = global::System.Windows.DependencyProperty.Register("NewStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.XamZoombar), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.XamZoombar.OnNewStyleChanged)));

		// Token: 0x040000EC RID: 236
		private bool _isSizeChanged;

		// Token: 0x040000ED RID: 237
		private global::Infragistics.Controls.Range _tempRange;

		// Token: 0x040000EE RID: 238
		private double leftScrollWidth;

		// Token: 0x040000EF RID: 239
		private double rightScrollWidth;

		// Token: 0x040000F0 RID: 240
		private double leftScaleWidth;

		// Token: 0x040000F1 RID: 241
		private double rightScaleWidth;

		// Token: 0x040000F2 RID: 242
		private double scrollAreaWidth;

		// Token: 0x040000F3 RID: 243
		private double topScrollHeight;

		// Token: 0x040000F4 RID: 244
		private double bottomScrollHeight;

		// Token: 0x040000F5 RID: 245
		private double topScaleHeight;

		// Token: 0x040000F6 RID: 246
		private double bottomScaleHeight;

		// Token: 0x040000F7 RID: 247
		private double scrollAreaHeight;

		// Token: 0x040000F8 RID: 248
		private bool _initialize;

		// Token: 0x040000F9 RID: 249
		private global::System.Windows.Threading.DispatcherTimer _timer;

		// Token: 0x040000FA RID: 250
		private double _newValue;

		// Token: 0x040000FB RID: 251
		private bool _isSmallChange;
	}
}
