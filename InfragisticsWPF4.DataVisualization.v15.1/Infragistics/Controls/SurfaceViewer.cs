using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Infragistics.Controls
{
	// Token: 0x0200005A RID: 90
	[global::System.Windows.TemplatePart(Name = "Overlay", Type = typeof(global::System.Windows.Controls.Canvas))]
	[global::System.Windows.TemplatePart(Name = "Thumbnail", Type = typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane))]
	[global::System.Windows.TemplatePart(Name = "ContentPresenter", Type = typeof(global::System.Windows.Controls.Canvas))]
	public abstract class SurfaceViewer : global::System.Windows.Controls.ContentControl, global::Infragistics.Controls.IOverviewPlusDetailControl, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000474 RID: 1140 RVA: 0x00011698 File Offset: 0x0000F898
		protected SurfaceViewer()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.SurfaceViewer);
			(this.PreviewPath.Data as global::System.Windows.Media.GeometryGroup).Children.Add(new global::System.Windows.Media.RectangleGeometry());
			(this.PreviewPath.Data as global::System.Windows.Media.GeometryGroup).Children.Add(new global::System.Windows.Media.RectangleGeometry());
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000475 RID: 1141 RVA: 0x00011760 File Offset: 0x0000F960
		// (remove) Token: 0x06000476 RID: 1142 RVA: 0x00011798 File Offset: 0x0000F998
		public event global::Infragistics.RectChangedEventHandler DragRectChanging;

		// Token: 0x06000477 RID: 1143 RVA: 0x000117D0 File Offset: 0x0000F9D0
		protected virtual void OnDragRectChanging(global::Infragistics.RectChangedEventArgs e)
		{
			if (this.DragRectChanging != null)
			{
				this.DragRectChanging(this, e);
			}
			if (this.WorldToViewport(e.NewRect).GetArea() > 16.0)
			{
				this.PreviewRect = this.Adjust(e.NewRect, global::Infragistics.Controls.AdjustmentPriority.Best);
				return;
			}
			this.PreviewRect = global::System.Windows.Rect.Empty;
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000478 RID: 1144 RVA: 0x00011830 File Offset: 0x0000FA30
		// (remove) Token: 0x06000479 RID: 1145 RVA: 0x00011868 File Offset: 0x0000FA68
		public event global::Infragistics.RectChangedEventHandler DragRectChanged;

		// Token: 0x0600047A RID: 1146 RVA: 0x000118A0 File Offset: 0x0000FAA0
		protected virtual void OnDragRectChanged(global::Infragistics.RectChangedEventArgs e)
		{
			if (this.DragRectChanged != null)
			{
				this.DragRectChanged(this, e);
			}
			this.PreviewRect = global::System.Windows.Rect.Empty;
			if (this.WorldToViewport(e.NewRect).GetArea() > 16.0)
			{
				this.WindowRect = this.Adjust(e.NewRect, global::Infragistics.Controls.AdjustmentPriority.Best);
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600047B RID: 1147 RVA: 0x000118FC File Offset: 0x0000FAFC
		// (remove) Token: 0x0600047C RID: 1148 RVA: 0x00011934 File Offset: 0x0000FB34
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600047D RID: 1149 RVA: 0x00011969 File Offset: 0x0000FB69
		protected virtual void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, e);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00011980 File Offset: 0x0000FB80
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00011992 File Offset: 0x0000FB92
		public global::System.Windows.Media.Brush DragStroke
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.SurfaceViewer.DragStrokeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.SurfaceViewer.DragStrokeProperty, value);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x000119A0 File Offset: 0x0000FBA0
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x000119B2 File Offset: 0x0000FBB2
		public double DragStrokeThickness
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.SurfaceViewer.DragStrokeThicknessProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.SurfaceViewer.DragStrokeThicknessProperty, value);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x000119C5 File Offset: 0x0000FBC5
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x000119D7 File Offset: 0x0000FBD7
		public global::System.Windows.Media.DoubleCollection DragStrokeDashArray
		{
			get
			{
				return (global::System.Windows.Media.DoubleCollection)base.GetValue(global::Infragistics.Controls.SurfaceViewer.DragStrokeDashArrayProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.SurfaceViewer.DragStrokeDashArrayProperty, value);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x000119E5 File Offset: 0x0000FBE5
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x000119F7 File Offset: 0x0000FBF7
		public global::System.Windows.Media.Brush PreviewBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.SurfaceViewer.PreviewBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.SurfaceViewer.PreviewBrushProperty, value);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00011A05 File Offset: 0x0000FC05
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00011A20 File Offset: 0x0000FC20
		public global::Infragistics.Controls.NavigationSettings NavigationSettings
		{
			get
			{
				if (this._navigationSettings == null)
				{
					this._navigationSettings = new global::Infragistics.Controls.NavigationSettings();
				}
				return this._navigationSettings;
			}
			set
			{
				if (value != this._navigationSettings)
				{
					this.OnPropertyUpdated("NavigationSettings", this._navigationSettings, value);
					this._navigationSettings = value;
				}
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00011A44 File Offset: 0x0000FC44
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00011A56 File Offset: 0x0000FC56
		public double MinimumZoomLevel
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.SurfaceViewer.MinimumZoomLevelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.SurfaceViewer.MinimumZoomLevelProperty, value);
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00011A69 File Offset: 0x0000FC69
		private static void OnMinimumZoomLevelChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.SurfaceViewer)d).OnMinimumZoomLevelChanged((double)e.OldValue, (double)e.NewValue);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00011A8E File Offset: 0x0000FC8E
		protected virtual void OnMinimumZoomLevelChanged(double oldValue, double newValue)
		{
			this.OnPropertyUpdated("MinimumZoomLevel", oldValue, newValue);
			this.ZoomLevel = this.ZoomLevel;
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00011AB3 File Offset: 0x0000FCB3
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x00011AC5 File Offset: 0x0000FCC5
		public double MaximumZoomLevel
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.SurfaceViewer.MaximumZoomLevelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.SurfaceViewer.MaximumZoomLevelProperty, value);
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00011AD8 File Offset: 0x0000FCD8
		private static void OnMaximumZoomLevelChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.SurfaceViewer)d).OnMaximumZoomLevelChanged((double)e.OldValue, (double)e.NewValue);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00011AFD File Offset: 0x0000FCFD
		protected virtual void OnMaximumZoomLevelChanged(double oldValue, double newValue)
		{
			this.OnPropertyUpdated("MaximumZoomLevel", oldValue, newValue);
			this.ZoomLevel = this.ZoomLevel;
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00011B22 File Offset: 0x0000FD22
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x00011B34 File Offset: 0x0000FD34
		public global::System.Windows.Rect WorldRect
		{
			get
			{
				return (global::System.Windows.Rect)base.GetValue(global::Infragistics.Controls.SurfaceViewer.WorldRectProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.SurfaceViewer.WorldRectProperty, value);
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00011B47 File Offset: 0x0000FD47
		private static void OnWorldRectChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.SurfaceViewer)d).OnWorldRectChanged((global::System.Windows.Rect)e.OldValue, (global::System.Windows.Rect)e.NewValue);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00011B6C File Offset: 0x0000FD6C
		protected virtual void OnWorldRectChanged(global::System.Windows.Rect oldValue, global::System.Windows.Rect newValue)
		{
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("WorldRect"));
			this.UpdateNavigators();
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00011B84 File Offset: 0x0000FD84
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00011B96 File Offset: 0x0000FD96
		public global::System.Windows.Rect WindowRect
		{
			get
			{
				return (global::System.Windows.Rect)base.GetValue(global::Infragistics.Controls.SurfaceViewer.WindowRectProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.SurfaceViewer.WindowRectProperty, value);
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00011BA9 File Offset: 0x0000FDA9
		private static void OnWindowRectChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.SurfaceViewer)d).OnWindowRectChanged((global::System.Windows.Rect)e.OldValue, (global::System.Windows.Rect)e.NewValue);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00011BD0 File Offset: 0x0000FDD0
		protected virtual void OnWindowRectChanged(global::System.Windows.Rect oldValue, global::System.Windows.Rect newValue)
		{
			if (newValue.IsEmpty)
			{
				return;
			}
			double num = 1.0;
			if (!oldValue.IsEmpty)
			{
				num = this.ViewportRect.Width / oldValue.Width;
			}
			double num2 = this.ViewportRect.Width / newValue.Width;
			if (num != num2 || this.ZoomLevelDisplayText == null)
			{
				this.OnPropertyUpdated("ZoomLevel", num, num2);
			}
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("WindowRect"));
			this.UpdateNavigators();
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00011C61 File Offset: 0x0000FE61
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00011C73 File Offset: 0x0000FE73
		public global::System.Windows.Rect PreviewRect
		{
			get
			{
				return (global::System.Windows.Rect)base.GetValue(global::Infragistics.Controls.SurfaceViewer.PreviewRectProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.SurfaceViewer.PreviewRectProperty, value);
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00011C86 File Offset: 0x0000FE86
		private static void OnPreviewRectChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.SurfaceViewer)d).OnPreviewRectChanged((global::System.Windows.Rect)e.OldValue, (global::System.Windows.Rect)e.NewValue);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00011CAC File Offset: 0x0000FEAC
		protected virtual void OnPreviewRectChanged(global::System.Windows.Rect oldValue, global::System.Windows.Rect newValue)
		{
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("PreviewRect"));
			this.PreviewPath.Visibility = (this.PreviewRect.IsEmpty ? global::System.Windows.Visibility.Collapsed : global::System.Windows.Visibility.Visible);
			this.UpdateNavigators();
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00011CEE File Offset: 0x0000FEEE
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00011CF8 File Offset: 0x0000FEF8
		public global::System.Windows.Rect ViewportRect
		{
			get
			{
				return this._viewportRect;
			}
			private set
			{
				if (this.ViewportRect != value)
				{
					global::System.Windows.Rect viewportRect = this.ViewportRect;
					this._viewportRect = value;
					this.OnViewportRectChanged(viewportRect, this.ViewportRect);
				}
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00011D30 File Offset: 0x0000FF30
		protected virtual void OnViewportRectChanged(global::System.Windows.Rect oldValue, global::System.Windows.Rect newValue)
		{
			if (!newValue.IsEmpty)
			{
				if (!oldValue.IsEmpty && !this.WindowRect.IsEmpty)
				{
					double num = global::System.Math.Min(oldValue.Width / this.WindowRect.Width, oldValue.Height / this.WindowRect.Height);
					double num2 = global::System.Math.Min(newValue.Width / this.WindowRect.Width, newValue.Height / this.WindowRect.Height);
					double num3 = num2 / num;
					global::System.Windows.Rect windowRect = this.WindowRect;
					windowRect.Width *= num3;
					windowRect.Height *= num3;
					this.WindowRect = windowRect;
					if (this.OverviewPlusDetailPane != null)
					{
						this.OverviewPlusDetailPane.Window = windowRect;
					}
				}
				((this.PreviewPath.Data as global::System.Windows.Media.GeometryGroup).Children[0] as global::System.Windows.Media.RectangleGeometry).Rect = newValue;
				(this.Overlay.Clip as global::System.Windows.Media.RectangleGeometry).Rect = newValue;
			}
			this.UpdateNavigators();
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00011E57 File Offset: 0x00010057
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00011E69 File Offset: 0x00010069
		public global::System.Windows.Style OverviewPlusDetailPaneStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.SurfaceViewer.OverviewPlusDetailPaneStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.SurfaceViewer.OverviewPlusDetailPaneStyleProperty, value);
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00011E77 File Offset: 0x00010077
		private static void OnOverviewPlusDetailPaneStyleChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.SurfaceViewer)d).OnOverviewPlusDetailPaneStyleChanged((global::System.Windows.Style)e.OldValue, (global::System.Windows.Style)e.NewValue);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00011E9C File Offset: 0x0001009C
		protected virtual void OnOverviewPlusDetailPaneStyleChanged(global::System.Windows.Style oldValue, global::System.Windows.Style newValue)
		{
			if (this.OverviewPlusDetailPane != null)
			{
				if (newValue != null)
				{
					this.OverviewPlusDetailPane.Style = newValue;
					return;
				}
				this.OverviewPlusDetailPane.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00011EC6 File Offset: 0x000100C6
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00011ED8 File Offset: 0x000100D8
		public global::System.Windows.HorizontalAlignment HorizontalOverviewPlusDetailPaneAlignment
		{
			get
			{
				return (global::System.Windows.HorizontalAlignment)base.GetValue(global::Infragistics.Controls.SurfaceViewer.HorizontalOverviewPlusDetailPaneAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.SurfaceViewer.HorizontalOverviewPlusDetailPaneAlignmentProperty, value);
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00011EEB File Offset: 0x000100EB
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00011EFD File Offset: 0x000100FD
		public global::System.Windows.VerticalAlignment VerticalOverviewPlusDetailPaneAlignment
		{
			get
			{
				return (global::System.Windows.VerticalAlignment)base.GetValue(global::Infragistics.Controls.SurfaceViewer.VerticalOverviewPlusDetailPaneAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.SurfaceViewer.VerticalOverviewPlusDetailPaneAlignmentProperty, value);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00011F10 File Offset: 0x00010110
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00011F22 File Offset: 0x00010122
		public global::System.Windows.Visibility OverviewPlusDetailPaneVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.SurfaceViewer.OverviewPlusDetailPaneVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.SurfaceViewer.OverviewPlusDetailPaneVisibilityProperty, value);
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00011F38 File Offset: 0x00010138
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00011FE4 File Offset: 0x000101E4
		public double ZoomLevel
		{
			get
			{
				if (!double.IsNaN(this._initialZoomLevel))
				{
					return this._initialZoomLevel;
				}
				if (this.WindowRect.IsEmpty || this.ViewportRect.IsEmpty)
				{
					return 1.0;
				}
				double num = global::System.Math.Min(this.ViewportRect.Width / this.WindowRect.Width, this.ViewportRect.Height / this.WindowRect.Height);
				if (double.IsNaN(num) || double.IsInfinity(num))
				{
					num = 1.0;
				}
				return num;
			}
			set
			{
				if (this.ViewportRect.IsEmpty || this.WorldRect.IsEmpty)
				{
					this._initialZoomLevel = value;
					return;
				}
				this._initialZoomLevel = double.NaN;
				double zoomLevel = this.ZoomLevel;
				double num = this.ClampZoomLevel(value);
				double num2 = zoomLevel / num;
				global::System.Windows.Point point = this.ViewportToWorld(new global::System.Windows.Point(this.ViewportRect.Width / 2.0, this.ViewportRect.Height / 2.0));
				double num3 = num2 * (this.WindowRect.Left - point.X) + point.X;
				double num4 = num2 * (this.WindowRect.Bottom - point.Y) + point.Y;
				double num5 = num2 * (this.WindowRect.Right - point.X) + point.X;
				double num6 = num2 * (this.WindowRect.Top - point.Y) + point.Y;
				this.WindowRect = new global::System.Windows.Rect(num3, num6, num5 - num3, num4 - num6);
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00012120 File Offset: 0x00010320
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00012128 File Offset: 0x00010328
		public global::Infragistics.Controls.XamOverviewPlusDetailPane OverviewPlusDetailPane { get; internal set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00012131 File Offset: 0x00010331
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x0001213C File Offset: 0x0001033C
		public string ZoomLevelDisplayText
		{
			get
			{
				return this._zoomLevelDisplayText;
			}
			set
			{
				bool flag = this.ZoomLevelDisplayText != value;
				if (flag)
				{
					object zoomLevelDisplayText = this.ZoomLevelDisplayText;
					this._zoomLevelDisplayText = value;
					this.OnPropertyUpdated("ZoomLevelDisplayText", zoomLevelDisplayText, value);
				}
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00012174 File Offset: 0x00010374
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x0001217C File Offset: 0x0001037C
		private global::System.Windows.Point Anchor { get; set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00012185 File Offset: 0x00010385
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x0001218D File Offset: 0x0001038D
		private bool IsDragging { get; set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00012196 File Offset: 0x00010396
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x0001219E File Offset: 0x0001039E
		private bool IsPanning { get; set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x000121A7 File Offset: 0x000103A7
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x000121AF File Offset: 0x000103AF
		internal global::System.Windows.Controls.ContentPresenter ContentPresenter { get; private set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x000121B8 File Offset: 0x000103B8
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x000121C0 File Offset: 0x000103C0
		internal global::System.Windows.Controls.Canvas Overlay { get; private set; }

		// Token: 0x060004B9 RID: 1209 RVA: 0x000121CC File Offset: 0x000103CC
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this.OverviewPlusDetailPane != null)
			{
				this.OverviewPlusDetailPane.WindowChanging -= this.thumbnail_WindowRectChanging;
				this.OverviewPlusDetailPane.WindowChanged -= this.thumbnail_WindowRectChanged;
			}
			this.OverviewPlusDetailPane = (base.GetTemplateChild("Thumbnail") as global::Infragistics.Controls.XamOverviewPlusDetailPane);
			if (this.OverviewPlusDetailPane != null)
			{
				this.OverviewPlusDetailPane.SurfaceViewer = this;
				this.OverviewPlusDetailPane.WindowChanging += this.thumbnail_WindowRectChanging;
				this.OverviewPlusDetailPane.WindowChanged += this.thumbnail_WindowRectChanged;
				if (this.OverviewPlusDetailPaneStyle != null)
				{
					this.OverviewPlusDetailPane.Style = this.OverviewPlusDetailPaneStyle;
				}
			}
			if (this.ContentPresenter != null)
			{
				this.ContentPresenter.SizeChanged -= this.ContentPresenter_SizeChanged;
			}
			this.ContentPresenter = (base.GetTemplateChild("ContentPresenter") as global::System.Windows.Controls.ContentPresenter);
			if (this.ContentPresenter != null)
			{
				this.ContentPresenter.SizeChanged += this.ContentPresenter_SizeChanged;
			}
			if (this.Overlay != null)
			{
				this.Overlay.Children.Remove(this.PreviewPath);
				this.Overlay.Children.Remove(this.DragPath);
			}
			this.Overlay = (base.GetTemplateChild("Overlay") as global::System.Windows.Controls.Canvas);
			if (this.Overlay != null)
			{
				this.Overlay.Clip = new global::System.Windows.Media.RectangleGeometry();
				this.Overlay.Children.Add(this.PreviewPath);
				this.Overlay.Children.Add(this.DragPath);
			}
			this.DragPath.SetBinding(global::System.Windows.Shapes.Shape.StrokeProperty, new global::System.Windows.Data.Binding("DragStroke")
			{
				Source = this
			});
			this.DragPath.SetBinding(global::System.Windows.Shapes.Shape.StrokeThicknessProperty, new global::System.Windows.Data.Binding("DragStrokeThickness")
			{
				Source = this
			});
			this.DragPath.SetBinding(global::System.Windows.Shapes.Shape.StrokeDashArrayProperty, new global::System.Windows.Data.Binding("DragStrokeDashArray")
			{
				Source = this
			});
			this.PreviewPath.SetBinding(global::System.Windows.Shapes.Shape.FillProperty, new global::System.Windows.Data.Binding("PreviewBrush")
			{
				Source = this
			});
			this.ViewportRect = ((this.ContentPresenter != null && this.ContentPresenter.ActualWidth > 0.0 && this.ContentPresenter.ActualHeight > 0.0) ? new global::System.Windows.Rect(0.0, 0.0, this.ContentPresenter.ActualWidth, this.ContentPresenter.ActualHeight) : global::System.Windows.Rect.Empty);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00012468 File Offset: 0x00010668
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			if (!this.CanStartNavigation(e))
			{
				return;
			}
			base.Focus();
			global::System.Windows.Point position = e.GetPosition(this.Overlay);
			if (!this.ViewportRect.Contains(position))
			{
				return;
			}
			bool flag = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Control) != global::System.Windows.Input.ModifierKeys.None;
			if (flag)
			{
				if (this.NavigationSettings.AllowZoom && this.NavigationSettings.AllowPan)
				{
					this.IsDragging = base.CaptureMouse();
				}
			}
			else if (this.NavigationSettings.AllowPan)
			{
				this.IsPanning = base.CaptureMouse();
			}
			if (this.IsDragging)
			{
				this.Anchor = this.ViewportToWorld(position);
				global::System.Windows.Rect rect = new global::System.Windows.Rect(this.Anchor, this.ViewportToWorld(e.GetPosition(this.Overlay)));
				(this.DragPath.Data as global::System.Windows.Media.RectangleGeometry).Rect = this.WorldToViewport(rect);
				this.DragPath.Visibility = global::System.Windows.Visibility.Visible;
				this.OnDragRectChanging(new global::Infragistics.RectChangedEventArgs(rect, rect));
				e.Handled = true;
				return;
			}
			if (this.IsPanning)
			{
				this.Anchor = position;
				base.Cursor = global::System.Windows.Input.Cursors.Hand;
				e.Handled = true;
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00012590 File Offset: 0x00010790
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this.IsDragging)
			{
				global::System.Windows.Rect rect = new global::System.Windows.Rect(this.Anchor, this.ViewportToWorld(e.GetPosition(this.Overlay)));
				(this.DragPath.Data as global::System.Windows.Media.RectangleGeometry).Rect = this.WorldToViewport(rect);
				this.OnDragRectChanging(new global::Infragistics.RectChangedEventArgs(rect, rect));
			}
			else if (this.IsPanning)
			{
				global::System.Windows.Point position = e.GetPosition(this.Overlay);
				double num = this.Anchor.X - position.X;
				double num2 = this.Anchor.Y - position.Y;
				double zoomLevel = this.ZoomLevel;
				num /= zoomLevel;
				num2 /= zoomLevel;
				if (this.WindowRect != global::System.Windows.Rect.Empty)
				{
					global::System.Windows.Rect windowRect = this.WindowRect;
					windowRect.X += num;
					windowRect.Y += num2;
					this.WindowRect = windowRect;
				}
				this.Anchor = position;
			}
			base.OnMouseMove(e);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0001269C File Offset: 0x0001089C
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.IsDragging)
			{
				global::System.Windows.Rect rect = new global::System.Windows.Rect(this.Anchor, this.ViewportToWorld(e.GetPosition(this.Overlay)));
				base.ReleaseMouseCapture();
				this.DragPath.Visibility = global::System.Windows.Visibility.Collapsed;
				this.IsDragging = false;
				this.OnDragRectChanged(new global::Infragistics.RectChangedEventArgs(rect, rect));
				e.Handled = true;
			}
			else if (this.IsPanning)
			{
				base.Cursor = global::System.Windows.Input.Cursors.Arrow;
				this.IsPanning = false;
				base.ReleaseMouseCapture();
				e.Handled = true;
			}
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00012730 File Offset: 0x00010930
		protected override void OnMouseWheel(global::System.Windows.Input.MouseWheelEventArgs e)
		{
			base.OnMouseWheel(e);
			if (this.NavigationSettings.AllowZoom)
			{
				double num = 1.0 + global::System.Math.Min(0.5, global::System.Math.Max(-0.5, (double)e.Delta / 1200.0));
				this.ZoomLevel *= num;
				e.Handled = true;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0001279E File Offset: 0x0001099E
		private global::System.Windows.Input.ModifierKeys CurrentModifiers
		{
			get
			{
				return global::System.Windows.Input.Keyboard.Modifiers;
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000127A8 File Offset: 0x000109A8
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			global::System.Windows.Input.Key key = e.Key;
			bool flag = (this.CurrentModifiers & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control;
			global::System.Windows.Input.Key key2 = e.Key;
			if (key2 != global::System.Windows.Input.Key.Escape)
			{
				switch (key2)
				{
				case global::System.Windows.Input.Key.Add:
					if (flag && this.NavigationSettings.AllowZoom)
					{
						this.ZoomIn();
						e.Handled = true;
						return;
					}
					break;
				case global::System.Windows.Input.Key.Separator:
					break;
				case global::System.Windows.Input.Key.Subtract:
					if (flag && this.NavigationSettings.AllowZoom)
					{
						this.ZoomOut();
						e.Handled = true;
					}
					break;
				default:
					return;
				}
			}
			else if (this.IsDragging)
			{
				base.ReleaseMouseCapture();
				this.OnDragRectChanged(new global::Infragistics.RectChangedEventArgs(global::System.Windows.Rect.Empty, global::System.Windows.Rect.Empty));
				this.DragPath.Visibility = global::System.Windows.Visibility.Collapsed;
				this.IsDragging = false;
				e.Handled = true;
				return;
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0001286A File Offset: 0x00010A6A
		public virtual void RenderPreview()
		{
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0001286C File Offset: 0x00010A6C
		public global::System.Windows.Rect Adjust(global::System.Windows.Rect rect)
		{
			return this.Adjust(rect, global::Infragistics.Controls.AdjustmentPriority.Biggest);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00012878 File Offset: 0x00010A78
		public void ScaleToFit()
		{
			global::System.Windows.Rect viewportRect = this.ViewportRect;
			if (viewportRect.IsEmpty || this.WorldRect.IsEmpty)
			{
				return;
			}
			global::System.Windows.Rect worldRect = this.WorldRect;
			double x = 0.0;
			double y = 0.0;
			double width;
			if (worldRect.Width >= viewportRect.Width)
			{
				width = worldRect.Width;
			}
			else
			{
				width = viewportRect.Width;
				x = (worldRect.Width - width) / 2.0;
			}
			double height;
			if (worldRect.Height >= viewportRect.Height)
			{
				height = worldRect.Height;
			}
			else
			{
				height = viewportRect.Height;
				y = (worldRect.Height - height) / 2.0;
			}
			global::System.Windows.Rect rect = new global::System.Windows.Rect(x, y, width, height);
			this.WindowRect = this.Adjust(rect, global::Infragistics.Controls.AdjustmentPriority.Worst);
			if (!double.IsNaN(this._initialZoomLevel))
			{
				this.ZoomLevel = this._initialZoomLevel;
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00012967 File Offset: 0x00010B67
		public void ZoomTo100()
		{
			this.ScaleToFit();
			this.ZoomLevel = 1.0;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0001297E File Offset: 0x00010B7E
		public void ZoomIn()
		{
			this.ZoomLevel *= 1.1;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00012996 File Offset: 0x00010B96
		public void ZoomOut()
		{
			this.ZoomLevel *= 0.9;
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x000129AE File Offset: 0x00010BAE
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x000129B6 File Offset: 0x00010BB6
		public global::Infragistics.Controls.InteractionState DefaultInteraction { get; set; }

		// Token: 0x060004C8 RID: 1224 RVA: 0x000129C0 File Offset: 0x00010BC0
		internal global::System.Windows.Rect Adjust(global::System.Windows.Rect rect, global::Infragistics.Controls.AdjustmentPriority adjustmentPriority)
		{
			global::System.Windows.Rect viewportRect = this.ViewportRect;
			if (!viewportRect.IsEmpty)
			{
				double num = rect.Left + 0.5 * rect.Width;
				double num2 = rect.Top + 0.5 * rect.Height;
				double num3 = rect.Width;
				double num4 = rect.Height;
				switch (adjustmentPriority)
				{
				case global::Infragistics.Controls.AdjustmentPriority.Biggest:
					return this.Adjust(rect, (rect.Width > rect.Height) ? global::Infragistics.Controls.AdjustmentPriority.Width : global::Infragistics.Controls.AdjustmentPriority.Height);
				case global::Infragistics.Controls.AdjustmentPriority.Smallest:
					return this.Adjust(rect, (rect.Width > rect.Height) ? global::Infragistics.Controls.AdjustmentPriority.Height : global::Infragistics.Controls.AdjustmentPriority.Width);
				case global::Infragistics.Controls.AdjustmentPriority.Width:
					num4 = num3 * viewportRect.Height / viewportRect.Width;
					rect.Height = num4;
					break;
				case global::Infragistics.Controls.AdjustmentPriority.Height:
					num3 = num4 * viewportRect.Width / viewportRect.Height;
					break;
				case global::Infragistics.Controls.AdjustmentPriority.Best:
					return this.Adjust(rect, (viewportRect.Width * num4 / (viewportRect.Height * num3) > 1.0) ? global::Infragistics.Controls.AdjustmentPriority.Width : global::Infragistics.Controls.AdjustmentPriority.Height);
				case global::Infragistics.Controls.AdjustmentPriority.Worst:
					return this.Adjust(rect, (viewportRect.Width * num4 / (viewportRect.Height * num3) > 1.0) ? global::Infragistics.Controls.AdjustmentPriority.Height : global::Infragistics.Controls.AdjustmentPriority.Width);
				}
				rect = new global::System.Windows.Rect(num - 0.5 * num3, num2 - 0.5 * num4, num3, num4);
			}
			return this.FitRectInZoom(rect);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00012B3C File Offset: 0x00010D3C
		internal global::System.Windows.Point ViewportToWorld(global::System.Windows.Point point)
		{
			global::System.Windows.Rect viewportRect = this.ViewportRect;
			global::System.Windows.Rect windowRect = this.WindowRect;
			if (viewportRect.IsEmpty || windowRect.IsEmpty)
			{
				return new global::System.Windows.Point(double.NaN, double.NaN);
			}
			double x = windowRect.Left + windowRect.Width * (point.X - viewportRect.Left) / viewportRect.Width;
			double y = windowRect.Top + windowRect.Height * (point.Y - viewportRect.Top) / viewportRect.Height;
			return new global::System.Windows.Point(x, y);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00012BD8 File Offset: 0x00010DD8
		internal global::System.Windows.Rect WorldToViewport(global::System.Windows.Rect rect)
		{
			global::System.Windows.Rect viewportRect = this.ViewportRect;
			global::System.Windows.Rect windowRect = this.WindowRect;
			if (viewportRect.IsEmpty || windowRect.IsEmpty || rect.IsEmpty)
			{
				return global::System.Windows.Rect.Empty;
			}
			double num = viewportRect.Left + viewportRect.Width * (rect.Left - windowRect.Left) / windowRect.Width;
			double num2 = viewportRect.Top + viewportRect.Height * (rect.Top - windowRect.Top) / windowRect.Height;
			double num3 = viewportRect.Left + viewportRect.Width * (rect.Right - windowRect.Left) / windowRect.Width;
			double num4 = viewportRect.Top + viewportRect.Height * (rect.Bottom - windowRect.Top) / windowRect.Height;
			return new global::System.Windows.Rect(num, num2, num3 - num, num4 - num2);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00012CC8 File Offset: 0x00010EC8
		protected virtual void OnPropertyUpdated(string propertyName, object oldValue, object newValue)
		{
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			if (propertyName != null)
			{
				if (!(propertyName == "ZoomLevel"))
				{
					return;
				}
				this.UpdateZoomLevelDisplayText();
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00012CFA File Offset: 0x00010EFA
		protected virtual bool CanStartNavigation(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			return true;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00012D00 File Offset: 0x00010F00
		private void UpdateNavigators()
		{
			if (this.OverviewPlusDetailPane != null)
			{
				this.OverviewPlusDetailPane.World = this.WorldRect;
				this.OverviewPlusDetailPane.Window = this.WindowRect;
				this.OverviewPlusDetailPane.Preview = this.PreviewRect;
			}
			((this.PreviewPath.Data as global::System.Windows.Media.GeometryGroup).Children[1] as global::System.Windows.Media.RectangleGeometry).Rect = this.WorldToViewport(this.PreviewRect);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00012D7C File Offset: 0x00010F7C
		private double ClampZoomLevel(double scale)
		{
			if (!double.IsNaN(this.MinimumZoomLevel))
			{
				scale = global::System.Math.Max(this.MinimumZoomLevel, scale);
			}
			if (!double.IsNaN(this.MaximumZoomLevel))
			{
				scale = global::System.Math.Min(this.MaximumZoomLevel, scale);
			}
			scale = global::System.Math.Max(scale, 1E-05);
			return scale;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00012DD4 File Offset: 0x00010FD4
		private global::System.Windows.Rect FitRectInZoom(global::System.Windows.Rect rect)
		{
			double num = this.ViewportRect.Width / rect.Width;
			double num2 = this.ClampZoomLevel(num);
			if (num == num2)
			{
				return rect;
			}
			double num3 = num / num2;
			global::System.Windows.Point point = new global::System.Windows.Point(rect.X + rect.Width / 2.0, rect.Y + rect.Height / 2.0);
			double num4 = num3 * (rect.Left - point.X) + point.X;
			double num5 = num3 * (rect.Bottom - point.Y) + point.Y;
			double num6 = num3 * (rect.Right - point.X) + point.X;
			double num7 = num3 * (rect.Top - point.Y) + point.Y;
			rect = new global::System.Windows.Rect(num4, num7, num6 - num4, num5 - num7);
			return rect;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00012EC8 File Offset: 0x000110C8
		private void ContentPresenter_SizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			global::System.Windows.Rect rect = (this.ContentPresenter != null && this.ContentPresenter.ActualWidth > 0.0 && this.ContentPresenter.ActualHeight > 0.0) ? new global::System.Windows.Rect(0.0, 0.0, this.ContentPresenter.ActualWidth, this.ContentPresenter.ActualHeight) : global::System.Windows.Rect.Empty;
			if (this.ViewportRect != rect)
			{
				this.ViewportRect = rect;
			}
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00012F53 File Offset: 0x00011153
		private void thumbnail_WindowRectChanging(object sender, global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Rect> e)
		{
			this.WindowRect = this.Adjust(e.NewValue);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00012F67 File Offset: 0x00011167
		private void thumbnail_WindowRectChanged(object sender, global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Rect> e)
		{
			this.WindowRect = this.Adjust(e.NewValue);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00012F7C File Offset: 0x0001117C
		private void UpdateZoomLevelDisplayText()
		{
			this.ZoomLevelDisplayText = global::System.Math.Round(100.0 * this.ZoomLevel).ToString();
		}

		// Token: 0x040001B4 RID: 436
		private const double MinScale = 1E-05;

		// Token: 0x040001B5 RID: 437
		private const double ScaleChange = 0.1;

		// Token: 0x040001B6 RID: 438
		private const string ContentPresenterName = "ContentPresenter";

		// Token: 0x040001B7 RID: 439
		private const string OverlayName = "Overlay";

		// Token: 0x040001B8 RID: 440
		private const string ThumbnailName = "Thumbnail";

		// Token: 0x040001B9 RID: 441
		private const string DragStrokePropertyName = "DragStroke";

		// Token: 0x040001BA RID: 442
		private const string DragStrokeThicknessPropertyName = "DragStrokeThickness";

		// Token: 0x040001BB RID: 443
		private const string DragStrokeDashArrayPropertyName = "DragStrokeDashArray";

		// Token: 0x040001BC RID: 444
		private const string PreviewBrushPropertyName = "PreviewBrush";

		// Token: 0x040001BD RID: 445
		private const string MinimumZoomLevelPropertyName = "MinimumZoomLevel";

		// Token: 0x040001BE RID: 446
		private const string MaximumZoomLevelPropertyName = "MaximumZoomLevel";

		// Token: 0x040001BF RID: 447
		private const string WorldRectPropertyName = "WorldRect";

		// Token: 0x040001C0 RID: 448
		private const string WindowRectPropertyName = "WindowRect";

		// Token: 0x040001C1 RID: 449
		private const string PreviewRectPropertyName = "PreviewRect";

		// Token: 0x040001C2 RID: 450
		private const string ViewportRectPropertyName = "ViewportRect";

		// Token: 0x040001C3 RID: 451
		private const string ZoomLevelPropertyName = "ZoomLevel";

		// Token: 0x040001C4 RID: 452
		private const string ZoomLevelDisplayTextPropertyName = "ZoomLevelDisplayText";

		// Token: 0x040001C5 RID: 453
		private readonly global::System.Windows.Shapes.Path PreviewPath = new global::System.Windows.Shapes.Path
		{
			Data = new global::System.Windows.Media.GeometryGroup(),
			IsHitTestVisible = false,
			Visibility = global::System.Windows.Visibility.Collapsed
		};

		// Token: 0x040001C6 RID: 454
		private readonly global::System.Windows.Shapes.Path DragPath = new global::System.Windows.Shapes.Path
		{
			Data = new global::System.Windows.Media.RectangleGeometry(),
			IsHitTestVisible = false,
			Visibility = global::System.Windows.Visibility.Collapsed
		};

		// Token: 0x040001CA RID: 458
		public static readonly global::System.Windows.DependencyProperty DragStrokeProperty = global::System.Windows.DependencyProperty.Register("DragStroke", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.SurfaceViewer), new global::System.Windows.PropertyMetadata(new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Black), delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(sender as global::Infragistics.Controls.SurfaceViewer).OnPropertyUpdated("DragStroke", e.OldValue, e.NewValue);
		}));

		// Token: 0x040001CB RID: 459
		public static readonly global::System.Windows.DependencyProperty DragStrokeThicknessProperty = global::System.Windows.DependencyProperty.Register("DragStrokeThickness", typeof(double), typeof(global::Infragistics.Controls.SurfaceViewer), new global::System.Windows.PropertyMetadata(1.0, delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(sender as global::Infragistics.Controls.SurfaceViewer).OnPropertyUpdated("DragStrokeThickness", e.OldValue, e.NewValue);
		}));

		// Token: 0x040001CC RID: 460
		public static readonly global::System.Windows.DependencyProperty DragStrokeDashArrayProperty = global::System.Windows.DependencyProperty.Register("DragStrokeDashArray", typeof(global::System.Windows.Media.DoubleCollection), typeof(global::Infragistics.Controls.SurfaceViewer), new global::System.Windows.PropertyMetadata(delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(sender as global::Infragistics.Controls.SurfaceViewer).OnPropertyUpdated("DragStrokeDashArray", e.OldValue, e.NewValue);
		}));

		// Token: 0x040001CD RID: 461
		public static readonly global::System.Windows.DependencyProperty PreviewBrushProperty = global::System.Windows.DependencyProperty.Register("PreviewBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.SurfaceViewer), new global::System.Windows.PropertyMetadata(new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Color.FromArgb(128, 128, 128, 128)), delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(sender as global::Infragistics.Controls.SurfaceViewer).OnPropertyUpdated("PreviewBrush", e.OldValue, e.NewValue);
		}));

		// Token: 0x040001CE RID: 462
		private global::Infragistics.Controls.NavigationSettings _navigationSettings;

		// Token: 0x040001CF RID: 463
		public static readonly global::System.Windows.DependencyProperty MinimumZoomLevelProperty = global::System.Windows.DependencyProperty.Register("MinimumZoomLevel", typeof(double), typeof(global::Infragistics.Controls.SurfaceViewer), new global::System.Windows.PropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.SurfaceViewer.OnMinimumZoomLevelChanged)));

		// Token: 0x040001D0 RID: 464
		public static readonly global::System.Windows.DependencyProperty MaximumZoomLevelProperty = global::System.Windows.DependencyProperty.Register("MaximumZoomLevel", typeof(double), typeof(global::Infragistics.Controls.SurfaceViewer), new global::System.Windows.PropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.SurfaceViewer.OnMaximumZoomLevelChanged)));

		// Token: 0x040001D1 RID: 465
		public static readonly global::System.Windows.DependencyProperty WorldRectProperty = global::System.Windows.DependencyProperty.Register("WorldRect", typeof(global::System.Windows.Rect), typeof(global::Infragistics.Controls.SurfaceViewer), new global::System.Windows.PropertyMetadata(global::System.Windows.Rect.Empty, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.SurfaceViewer.OnWorldRectChanged)));

		// Token: 0x040001D2 RID: 466
		public static readonly global::System.Windows.DependencyProperty WindowRectProperty = global::System.Windows.DependencyProperty.Register("WindowRect", typeof(global::System.Windows.Rect), typeof(global::Infragistics.Controls.SurfaceViewer), new global::System.Windows.PropertyMetadata(global::System.Windows.Rect.Empty, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.SurfaceViewer.OnWindowRectChanged)));

		// Token: 0x040001D3 RID: 467
		public static readonly global::System.Windows.DependencyProperty PreviewRectProperty = global::System.Windows.DependencyProperty.Register("PreviewRect", typeof(global::System.Windows.Rect), typeof(global::Infragistics.Controls.SurfaceViewer), new global::System.Windows.PropertyMetadata(global::System.Windows.Rect.Empty, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.SurfaceViewer.OnPreviewRectChanged)));

		// Token: 0x040001D4 RID: 468
		private global::System.Windows.Rect _viewportRect = global::System.Windows.Rect.Empty;

		// Token: 0x040001D5 RID: 469
		public static readonly global::System.Windows.DependencyProperty OverviewPlusDetailPaneStyleProperty = global::System.Windows.DependencyProperty.Register("OverviewPlusDetailPaneStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.SurfaceViewer), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.SurfaceViewer.OnOverviewPlusDetailPaneStyleChanged)));

		// Token: 0x040001D6 RID: 470
		public static readonly global::System.Windows.DependencyProperty HorizontalOverviewPlusDetailPaneAlignmentProperty = global::System.Windows.DependencyProperty.Register("HorizontalOverviewPlusDetailPaneAlignment", typeof(global::System.Windows.HorizontalAlignment), typeof(global::Infragistics.Controls.SurfaceViewer), new global::System.Windows.PropertyMetadata(global::System.Windows.HorizontalAlignment.Right));

		// Token: 0x040001D7 RID: 471
		public static readonly global::System.Windows.DependencyProperty VerticalOverviewPlusDetailPaneAlignmentProperty = global::System.Windows.DependencyProperty.Register("VerticalOverviewPlusDetailPaneAlignment", typeof(global::System.Windows.VerticalAlignment), typeof(global::Infragistics.Controls.SurfaceViewer), new global::System.Windows.PropertyMetadata(global::System.Windows.VerticalAlignment.Bottom));

		// Token: 0x040001D8 RID: 472
		public static readonly global::System.Windows.DependencyProperty OverviewPlusDetailPaneVisibilityProperty = global::System.Windows.DependencyProperty.Register("OverviewPlusDetailPaneVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.SurfaceViewer), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Visible));

		// Token: 0x040001D9 RID: 473
		private double _initialZoomLevel = double.NaN;

		// Token: 0x040001DA RID: 474
		private string _zoomLevelDisplayText;
	}
}
