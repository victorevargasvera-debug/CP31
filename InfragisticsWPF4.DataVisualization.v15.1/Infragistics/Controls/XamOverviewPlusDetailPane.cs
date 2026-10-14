using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using Infragistics.Themes;

namespace Infragistics.Controls
{
	// Token: 0x0200005B RID: 91
	[global::System.Windows.TemplateVisualState(Name = "ZoomDisabled", GroupName = "ZoomableStates")]
	[global::System.Windows.TemplatePart(Name = "ContentPresenter", Type = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.TemplateVisualState(Name = "Full", GroupName = "SizeStates")]
	[global::System.Windows.TemplateVisualState(Name = "ZoomEnabled", GroupName = "ZoomableStates")]
	[global::System.Windows.StyleTypedProperty(Property = "PreviewStyle", StyleTargetType = typeof(global::System.Windows.Shapes.Path))]
	[global::System.Windows.StyleTypedProperty(Property = "WindowStyle", StyleTargetType = typeof(global::System.Windows.Shapes.Path))]
	[global::System.Windows.TemplateVisualState(Name = "Minimal", GroupName = "SizeStates")]
	public class XamOverviewPlusDetailPane : global::System.Windows.Controls.Control, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00013380 File Offset: 0x00011580
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00013388 File Offset: 0x00011588
		internal global::Infragistics.Controls.XamOverviewPlusDetailPaneView View { get; set; }

		// Token: 0x060004DB RID: 1243 RVA: 0x0001363C File Offset: 0x0001183C
		static XamOverviewPlusDetailPane()
		{
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane));
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00013CA4 File Offset: 0x00011EA4
		public XamOverviewPlusDetailPane()
		{
			this.View = new global::Infragistics.Controls.XamOverviewPlusDetailPaneView(this);
			this.View.OnInit();
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane);
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060004DD RID: 1245 RVA: 0x00013CD4 File Offset: 0x00011ED4
		// (remove) Token: 0x060004DE RID: 1246 RVA: 0x00013D0C File Offset: 0x00011F0C
		public event global::System.EventHandler<global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Rect>> WindowChanging;

		// Token: 0x060004DF RID: 1247 RVA: 0x00013D41 File Offset: 0x00011F41
		protected virtual void OnWindowChanging(global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Rect> e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			if (this.Immediate)
			{
				this.Window = e.NewValue;
			}
			if (this.WindowChanging != null)
			{
				this.WindowChanging(this, e);
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060004E0 RID: 1248 RVA: 0x00013D7C File Offset: 0x00011F7C
		// (remove) Token: 0x060004E1 RID: 1249 RVA: 0x00013DB4 File Offset: 0x00011FB4
		public event global::System.EventHandler<global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Rect>> WindowChanged;

		// Token: 0x060004E2 RID: 1250 RVA: 0x00013DE9 File Offset: 0x00011FE9
		protected internal virtual void OnWindowChanged(global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Rect> a)
		{
			if (this.WindowChanged != null)
			{
				this.WindowChanged(this, a);
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060004E3 RID: 1251 RVA: 0x00013E00 File Offset: 0x00012000
		// (remove) Token: 0x060004E4 RID: 1252 RVA: 0x00013E38 File Offset: 0x00012038
		public event global::System.EventHandler<global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Size>> ThumbnailSizeChanged;

		// Token: 0x060004E5 RID: 1253 RVA: 0x00013E6D File Offset: 0x0001206D
		protected internal virtual void OnThumbnailSizeChanged(global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Size> e)
		{
			if (this.ThumbnailSizeChanged != null)
			{
				this.ThumbnailSizeChanged(this, e);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00013E84 File Offset: 0x00012084
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00013E96 File Offset: 0x00012096
		public bool Immediate
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ImmediateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ImmediateProperty, value);
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00013EA9 File Offset: 0x000120A9
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00013EBB File Offset: 0x000120BB
		public global::System.Windows.Rect World
		{
			get
			{
				return (global::System.Windows.Rect)base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.WorldProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.WorldProperty, value);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00013ECE File Offset: 0x000120CE
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00013EE0 File Offset: 0x000120E0
		public global::System.Windows.Style WorldStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.WorldStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.WorldStyleProperty, value);
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00013EEE File Offset: 0x000120EE
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00013F00 File Offset: 0x00012100
		public global::System.Windows.Rect Window
		{
			get
			{
				return (global::System.Windows.Rect)base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.WindowProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.WindowProperty, value);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00013F13 File Offset: 0x00012113
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00013F25 File Offset: 0x00012125
		public global::System.Windows.Style WindowStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.WindowStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.WindowStyleProperty, value);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00013F33 File Offset: 0x00012133
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00013F45 File Offset: 0x00012145
		public global::System.Windows.Rect Preview
		{
			get
			{
				return (global::System.Windows.Rect)base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.PreviewProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.PreviewProperty, value);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00013F58 File Offset: 0x00012158
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00013F6A File Offset: 0x0001216A
		public global::System.Windows.Style PreviewStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.PreviewStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.PreviewStyleProperty, value);
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00013F78 File Offset: 0x00012178
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00013F8A File Offset: 0x0001218A
		public bool ShrinkToThumbnail
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ShrinkToThumbnailProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ShrinkToThumbnailProperty, value);
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00013F9D File Offset: 0x0001219D
		private static void OnShrinkToThumbnailChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamOverviewPlusDetailPane)d).OnShrinkToThumbnailChanged((bool)e.OldValue, (bool)e.NewValue);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00013FC2 File Offset: 0x000121C2
		protected virtual void OnShrinkToThumbnailChanged(bool oldValue, bool newValue)
		{
			if (newValue)
			{
				this.GoToState(global::Infragistics.Controls.OverviewPlusDetailPaneMode.Minimal);
				return;
			}
			this.GoToState(global::Infragistics.Controls.OverviewPlusDetailPaneMode.Compact);
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00013FD6 File Offset: 0x000121D6
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00013FE8 File Offset: 0x000121E8
		public global::Infragistics.Controls.OverviewPlusDetailPaneMode Mode
		{
			get
			{
				return (global::Infragistics.Controls.OverviewPlusDetailPaneMode)base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ModeProperty, value);
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00013FFB File Offset: 0x000121FB
		private static void OnModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamOverviewPlusDetailPane)d).OnModeChanged((global::Infragistics.Controls.OverviewPlusDetailPaneMode)e.OldValue, (global::Infragistics.Controls.OverviewPlusDetailPaneMode)e.NewValue);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00014020 File Offset: 0x00012220
		protected virtual void OnModeChanged(global::Infragistics.Controls.OverviewPlusDetailPaneMode oldValue, global::Infragistics.Controls.OverviewPlusDetailPaneMode newValue)
		{
			this.GoToState(newValue);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001402C File Offset: 0x0001222C
		internal void GoToState(global::Infragistics.Controls.OverviewPlusDetailPaneMode mode)
		{
			switch (mode)
			{
			case global::Infragistics.Controls.OverviewPlusDetailPaneMode.Minimal:
				this.View.GoToMinimalState();
				this.View.GoToZoomDisabledState();
				return;
			case global::Infragistics.Controls.OverviewPlusDetailPaneMode.Full:
				this.View.GoToFullState();
				if (this.IsZoomable)
				{
					this.View.GoToZoomEnabledState();
					return;
				}
				this.View.GoToZoomDisabledState();
				return;
			case global::Infragistics.Controls.OverviewPlusDetailPaneMode.Compact:
				this.View.GoToMinimalState();
				if (this.IsZoomable)
				{
					this.View.GoToZoomEnabledState();
					return;
				}
				this.View.GoToZoomDisabledState();
				return;
			default:
				return;
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x000140BA File Offset: 0x000122BA
		private void UpdateVisualState()
		{
			if (this.ShrinkToThumbnail)
			{
				this.GoToState(global::Infragistics.Controls.OverviewPlusDetailPaneMode.Minimal);
				return;
			}
			this.GoToState(global::Infragistics.Controls.OverviewPlusDetailPaneMode.Compact);
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x000140D3 File Offset: 0x000122D3
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x000140DC File Offset: 0x000122DC
		public global::Infragistics.Controls.IOverviewPlusDetailControl SurfaceViewer
		{
			get
			{
				return this._surfaceViewer;
			}
			internal set
			{
				if (this._surfaceViewer != null)
				{
					global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = this._surfaceViewer as global::System.ComponentModel.INotifyPropertyChanged;
					if (notifyPropertyChanged != null)
					{
						notifyPropertyChanged.PropertyChanged -= this.SurfaceViewer_PropertyChanged;
					}
				}
				this._surfaceViewer = value;
				if (this._surfaceViewer != null)
				{
					global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged2 = this._surfaceViewer as global::System.ComponentModel.INotifyPropertyChanged;
					if (notifyPropertyChanged2 != null)
					{
						notifyPropertyChanged2.PropertyChanged += this.SurfaceViewer_PropertyChanged;
					}
				}
				this.View.SetSurfaceBindings();
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00014150 File Offset: 0x00012350
		private void SurfaceViewer_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (!(propertyName == "DefaultInteraction"))
				{
					return;
				}
				this.View.UpdateInteractionButtonStates(this._surfaceViewer.DefaultInteraction);
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x0001418B File Offset: 0x0001238B
		public global::System.Windows.Controls.Canvas PreviewCanvas
		{
			get
			{
				return this.View.PreviewCanvas;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00014198 File Offset: 0x00012398
		public global::System.Windows.Rect PreviewViewportdRect
		{
			get
			{
				global::System.Windows.Rect rect = this.WorldToCanvas(this.World);
				return new global::System.Windows.Rect(0.0, 0.0, rect.Width, rect.Height);
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x000141D7 File Offset: 0x000123D7
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x000141E9 File Offset: 0x000123E9
		public global::System.Windows.Visibility ZoomTo100ButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ZoomTo100ButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ZoomTo100ButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x000141FC File Offset: 0x000123FC
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x0001420E File Offset: 0x0001240E
		public global::System.Windows.Visibility ScaleToFitButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ScaleToFitButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ScaleToFitButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00014221 File Offset: 0x00012421
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00014233 File Offset: 0x00012433
		public global::System.Windows.Visibility InteractionStatesToolVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.InteractionStatesToolVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.InteractionStatesToolVisibilityProperty, value);
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00014246 File Offset: 0x00012446
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x00014253 File Offset: 0x00012453
		public object DragPanButtonToolTip
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.DragPanButtonToolTipProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.DragPanButtonToolTipProperty, value);
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00014261 File Offset: 0x00012461
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x0001426E File Offset: 0x0001246E
		public object DragZoomButtonToolTip
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.DragZoomButtonToolTipProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.DragZoomButtonToolTipProperty, value);
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0001427C File Offset: 0x0001247C
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00014289 File Offset: 0x00012489
		public object ZoomInButtonToolTip
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ZoomInButtonToolTipProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ZoomInButtonToolTipProperty, value);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00014297 File Offset: 0x00012497
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x000142A4 File Offset: 0x000124A4
		public object ZoomOutButtonToolTip
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ZoomOutButtonToolTipProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ZoomOutButtonToolTipProperty, value);
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x000142B2 File Offset: 0x000124B2
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x000142BF File Offset: 0x000124BF
		public object ZoomTo100ButtonToolTip
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ZoomTo100ButtonToolTipProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ZoomTo100ButtonToolTipProperty, value);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x000142CD File Offset: 0x000124CD
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x000142DA File Offset: 0x000124DA
		public object ScaleToFitButtonToolTip
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ScaleToFitButtonToolTipProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ScaleToFitButtonToolTipProperty, value);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x000142E8 File Offset: 0x000124E8
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x000142F5 File Offset: 0x000124F5
		public object DefaultInteractionButtonToolTip
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.DefaultInteractionButtonToolTipProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.DefaultInteractionButtonToolTipProperty, value);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00014303 File Offset: 0x00012503
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00014315 File Offset: 0x00012515
		public double ZoomLevelLargeChange
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ZoomLevelLargeChangeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.ZoomLevelLargeChangeProperty, value);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00014328 File Offset: 0x00012528
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x0001433A File Offset: 0x0001253A
		private global::System.Windows.HorizontalAlignment InnerHorizontalAlignment
		{
			get
			{
				return (global::System.Windows.HorizontalAlignment)base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.InnerHorizontalAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.InnerHorizontalAlignmentProperty, value);
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0001434D File Offset: 0x0001254D
		private static void OnInnerHorizontalAlignmentChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamOverviewPlusDetailPane)d).OnInnerHorizontalAlignmentChanged((global::System.Windows.HorizontalAlignment)e.OldValue, (global::System.Windows.HorizontalAlignment)e.NewValue);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00014372 File Offset: 0x00012572
		private void OnInnerHorizontalAlignmentChanged(global::System.Windows.HorizontalAlignment oldValue, global::System.Windows.HorizontalAlignment newValue)
		{
			this.SetRenderOrigin();
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0001437A File Offset: 0x0001257A
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x0001438C File Offset: 0x0001258C
		private global::System.Windows.VerticalAlignment InnerVerticalAlignment
		{
			get
			{
				return (global::System.Windows.VerticalAlignment)base.GetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.InnerVerticalAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamOverviewPlusDetailPane.InnerVerticalAlignmentProperty, value);
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0001439F File Offset: 0x0001259F
		private static void OnInnerVerticalAlignmentChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamOverviewPlusDetailPane)d).OnInnerVerticalAlignmentChanged((global::System.Windows.VerticalAlignment)e.OldValue, (global::System.Windows.VerticalAlignment)e.NewValue);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x000143C4 File Offset: 0x000125C4
		private void OnInnerVerticalAlignmentChanged(global::System.Windows.VerticalAlignment oldValue, global::System.Windows.VerticalAlignment newValue)
		{
			this.SetRenderOrigin();
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x000143CC File Offset: 0x000125CC
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x000143D4 File Offset: 0x000125D4
		public bool IsZoomable
		{
			get
			{
				return this._isZoomable;
			}
			set
			{
				this._isZoomable = value;
				this.UpdateVisualState();
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x000143E3 File Offset: 0x000125E3
		public global::System.Windows.Rect Viewport
		{
			get
			{
				return this.View.Viewport;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x000143F0 File Offset: 0x000125F0
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x000143F8 File Offset: 0x000125F8
		private bool RefreshPending { get; set; }

		// Token: 0x06000526 RID: 1318 RVA: 0x00014401 File Offset: 0x00012601
		internal global::System.Windows.DependencyObject FetchChildByName(string name)
		{
			return base.GetTemplateChild(name);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0001440A File Offset: 0x0001260A
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.View.OnTemplateProvided();
			this.UpdateVisualState();
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00014424 File Offset: 0x00012624
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			base.MeasureOverride(availableSize);
			return this.GetDesiredSize(availableSize);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00014444 File Offset: 0x00012644
		internal global::System.Windows.Size GetDesiredSize(global::System.Windows.Size availableSize)
		{
			double num = availableSize.Width;
			double num2 = availableSize.Height;
			double num3 = (!this.World.IsEmpty) ? (this.World.Width / this.World.Height) : 1.0;
			if (double.IsInfinity(num2))
			{
				if (double.IsInfinity(num))
				{
					num = 128.0;
				}
				num2 = num / num3;
			}
			else if (double.IsInfinity(num))
			{
				num = num2 * num3;
			}
			return new global::System.Windows.Size(num, num2);
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x000144CF File Offset: 0x000126CF
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x000144D7 File Offset: 0x000126D7
		private bool IsPanning { get; set; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x000144E0 File Offset: 0x000126E0
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x000144E8 File Offset: 0x000126E8
		private global::System.Windows.Point Anchor { get; set; }

		// Token: 0x0600052E RID: 1326 RVA: 0x000144F1 File Offset: 0x000126F1
		internal void OnMouseEnter()
		{
			if (this.ShrinkToThumbnail)
			{
				this.GoToState(global::Infragistics.Controls.OverviewPlusDetailPaneMode.Full);
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00014502 File Offset: 0x00012702
		internal void OnMouseLeave()
		{
			if (this.ShrinkToThumbnail)
			{
				this.GoToState(global::Infragistics.Controls.OverviewPlusDetailPaneMode.Minimal);
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00014514 File Offset: 0x00012714
		internal bool OnKeyDown(global::System.Windows.Input.Key key)
		{
			if (key == global::System.Windows.Input.Key.Escape && this.IsPanning)
			{
				this.View.CancelMouseOperations();
				this.IsPanning = false;
				this.Preview = global::System.Windows.Rect.Empty;
				return true;
			}
			return false;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00014550 File Offset: 0x00012750
		internal void OnMouseLeftButtonDown(global::System.Windows.Point p)
		{
			if (!this._pinching)
			{
				this._ignoreContactUp = false;
			}
			this._lastPosition = p;
			if (!this.WorldToCanvas(this.World).Contains(p))
			{
				return;
			}
			global::System.Windows.Rect newValue = (!((!this.Viewport.IsEmpty) ? this.World : global::System.Windows.Rect.Empty).IsEmpty) ? this.Window : global::System.Windows.Rect.Empty;
			this.Anchor = this.CanvasToWorld(p);
			if (!newValue.IsEmpty && this.View.CaptureMouse())
			{
				this.IsPanning = true;
				newValue = new global::System.Windows.Rect(this.Anchor.X - 0.5 * newValue.Width, this.Anchor.Y - 0.5 * newValue.Height, newValue.Width, newValue.Height);
				this.OnWindowChanging(new global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Rect>("Window", this.Window, newValue));
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0001465C File Offset: 0x0001285C
		internal void OnMouseMove(global::System.Windows.Point p, bool onMouseMove, bool isFinger)
		{
			if (double.IsNaN(this.Anchor.X) || double.IsNaN(this.Anchor.Y))
			{
				this.Anchor = this.CanvasToWorld(p);
			}
			double num = 2.0;
			if (isFinger)
			{
				num = 10.0;
			}
			bool flag = false;
			global::System.Windows.Point point = this.WorldPointToCanvas(this.Anchor);
			global::System.Windows.Rect rect = new global::System.Windows.Rect(point, p);
			if (rect.Width > num && rect.Height > num)
			{
				flag = true;
			}
			if (!this._pinching && flag)
			{
				this._ignoreContactUp = false;
			}
			this._lastPosition = p;
			global::System.Windows.Rect newValue = (!((!this.Viewport.IsEmpty) ? this.World : global::System.Windows.Rect.Empty).IsEmpty) ? this.Window : global::System.Windows.Rect.Empty;
			if (this.IsPanning)
			{
				global::System.Windows.Point point2 = this.CanvasToWorld(p);
				newValue = new global::System.Windows.Rect(point2.X - 0.5 * newValue.Width, point2.Y - 0.5 * newValue.Height, newValue.Width, newValue.Height);
				this.OnWindowChanging(new global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Rect>("Window", this.Window, newValue));
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000147A8 File Offset: 0x000129A8
		internal bool OnMouseLeftButtonUp(global::System.Windows.Point p)
		{
			this._lastPosition = p;
			global::System.Windows.Rect newValue = (!((!this.Viewport.IsEmpty) ? this.World : global::System.Windows.Rect.Empty).IsEmpty) ? this.Window : global::System.Windows.Rect.Empty;
			if (this.IsPanning && !this._ignoreContactUp)
			{
				this.View.CancelMouseOperations();
				this.IsPanning = false;
				global::System.Windows.Point point = this.CanvasToWorld(p);
				newValue = new global::System.Windows.Rect(point.X - 0.5 * newValue.Width, point.Y - 0.5 * newValue.Height, newValue.Width, newValue.Height);
				this.OnWindowChanged(new global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Rect>("Window", this.Window, newValue));
				return true;
			}
			return false;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00014880 File Offset: 0x00012A80
		internal bool OnMouseWheel(double delta)
		{
			global::System.Windows.Point center = this.Window.GetCenter();
			double num = 1.0 - global::Infragistics.MathUtil.Clamp(delta, -0.5, 0.5);
			double num2 = center.X - num * (center.X - this.Window.Left);
			double num3 = center.Y + num * (this.Window.Bottom - center.Y);
			double num4 = center.X + num * (this.Window.Right - center.X);
			double num5 = center.Y - num * (center.Y - this.Window.Top);
			global::System.Windows.Rect newValue = new global::System.Windows.Rect(num2, num5, num4 - num2, num3 - num5);
			this.OnWindowChanged(new global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Rect>("Window", this.Window, newValue));
			return true;
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000535 RID: 1333 RVA: 0x00014974 File Offset: 0x00012B74
		// (remove) Token: 0x06000536 RID: 1334 RVA: 0x000149AC File Offset: 0x00012BAC
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000537 RID: 1335 RVA: 0x000149E1 File Offset: 0x00012BE1
		protected virtual void OnPropertyUpdated(string propertyName, object oldValue, object newValue)
		{
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000149F0 File Offset: 0x00012BF0
		protected virtual void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, e);
			}
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (propertyName == "World")
				{
					base.UpdateLayout();
					this.Refresh(false);
					return;
				}
				if (propertyName == "Window")
				{
					this.Refresh(false);
					return;
				}
				if (!(propertyName == "Preview"))
				{
					return;
				}
				this.Refresh(false);
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00014A61 File Offset: 0x00012C61
		private void SetRenderOrigin()
		{
			this.View.SetRenderOrigin();
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00014A70 File Offset: 0x00012C70
		private global::System.Windows.Point CanvasToWorld(global::System.Windows.Point point)
		{
			global::System.Windows.Rect viewport = this.Viewport;
			global::System.Windows.Rect rect = (!viewport.IsEmpty) ? this.World : global::System.Windows.Rect.Empty;
			if (!rect.IsEmpty)
			{
				double num = (viewport.Width / viewport.Height > rect.Width / rect.Height) ? (viewport.Height / rect.Height) : (viewport.Width / rect.Width);
				double num2 = 0.5 * (viewport.Left + viewport.Right - (rect.Left + rect.Right) * num);
				double num3 = 0.5 * (viewport.Top + viewport.Bottom - (rect.Top + rect.Bottom) * num);
				return new global::System.Windows.Point((point.X - num2) / num, (point.Y - num3) / num);
			}
			return new global::System.Windows.Point(double.NaN, double.NaN);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00014B78 File Offset: 0x00012D78
		private global::System.Windows.Point WorldPointToCanvas(global::System.Windows.Point pt)
		{
			global::System.Windows.Rect viewport = this.Viewport;
			global::System.Windows.Rect rect = (!viewport.IsEmpty) ? this.World : global::System.Windows.Rect.Empty;
			if (!rect.IsEmpty)
			{
				double num = (viewport.Width / viewport.Height > rect.Width / rect.Height) ? (viewport.Height / rect.Height) : (viewport.Width / rect.Width);
				double num2 = 0.5 * (viewport.Left + viewport.Right - (rect.Left + rect.Right) * num);
				double num3 = 0.5 * (viewport.Top + viewport.Bottom - (rect.Top + rect.Bottom) * num);
				return new global::System.Windows.Point(pt.X * num + num2, pt.Y * num + num3);
			}
			return new global::System.Windows.Point(double.NaN, double.NaN);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00014C80 File Offset: 0x00012E80
		private global::System.Windows.Rect WorldToCanvas(global::System.Windows.Rect rect)
		{
			global::System.Windows.Rect viewport = this.Viewport;
			global::System.Windows.Rect rect2 = (!viewport.IsEmpty) ? this.World : global::System.Windows.Rect.Empty;
			if (!rect2.IsEmpty && !rect.IsEmpty)
			{
				double num = (viewport.Width / viewport.Height > rect2.Width / rect2.Height) ? (viewport.Height / rect2.Height) : (viewport.Width / rect2.Width);
				double num2 = 0.5 * (viewport.Left + viewport.Right - (rect2.Left + rect2.Right) * num);
				double num3 = 0.5 * (viewport.Top + viewport.Bottom - (rect2.Top + rect2.Bottom) * num);
				return new global::System.Windows.Rect(rect.Left * num + num2, rect.Top * num + num3, rect.Width * num, rect.Height * num);
			}
			return global::System.Windows.Rect.Empty;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00014D94 File Offset: 0x00012F94
		internal void Refresh(bool immediate)
		{
			this.UpdateSliderRanges();
			if (!immediate)
			{
				if (base.ActualWidth == 0.0 || base.ActualHeight == 0.0)
				{
					return;
				}
				if (!this.RefreshPending)
				{
					this.RefreshPending = true;
					base.Dispatcher.BeginInvoke(new global::System.Action<bool>(this.Refresh), new object[]
					{
						true
					});
				}
				return;
			}
			else
			{
				this.RefreshPending = false;
				global::System.Windows.Rect world = this.WorldToCanvas(this.World);
				global::System.Windows.Rect window = this.WorldToCanvas(this.Window);
				global::System.Windows.Rect preview = this.WorldToCanvas(this.Preview);
				if (base.Visibility != global::System.Windows.Visibility.Visible || world.IsEmpty || double.IsNaN(world.X) || double.IsNaN(world.Y))
				{
					this.RefreshPending = false;
					return;
				}
				this.View.UpdateWorldRect(world);
				this.View.PositionPreview(world);
				this.View.UpdateWindowPath(world, window);
				this.View.UpdatePreviewPath(world, preview);
				if (this.SurfaceViewer != null)
				{
					this.SurfaceViewer.RenderPreview();
				}
				return;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x00014EAE File Offset: 0x000130AE
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00014EB6 File Offset: 0x000130B6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public bool UpdatingSliderRanges { get; private set; }

		// Token: 0x06000540 RID: 1344 RVA: 0x00014EC0 File Offset: 0x000130C0
		private void UpdateSliderRanges()
		{
			if (base.Visibility != global::System.Windows.Visibility.Visible || this.SurfaceViewer == null || !this.View.IsReady())
			{
				return;
			}
			global::System.Windows.Rect viewportRect = this.SurfaceViewer.ViewportRect;
			global::System.Windows.Rect worldRect = this.SurfaceViewer.WorldRect;
			if (viewportRect.IsEmpty || worldRect.IsEmpty)
			{
				return;
			}
			this.UpdatingSliderRanges = true;
			double sliderValue = this.View.GetSliderValue();
			double num = this.SurfaceViewer.MinimumZoomLevel;
			double num2 = this.SurfaceViewer.MaximumZoomLevel;
			if (double.IsNaN(num))
			{
				num = global::System.Math.Min(viewportRect.Width / worldRect.Width, viewportRect.Height / worldRect.Height);
				num = global::System.Math.Min(num, 0.5);
				num = global::System.Math.Min(num, sliderValue);
			}
			if (double.IsNaN(num2))
			{
				num2 = 2.0;
				num2 = global::System.Math.Max(num2, sliderValue);
			}
			this.View.SetSliderMin(num);
			this.View.SetSliderMax(num2);
			this.UpdatingSliderRanges = false;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00014FC4 File Offset: 0x000131C4
		internal void OnDefaultInteraction(global::Infragistics.Controls.InteractionState state)
		{
			if (this.SurfaceViewer != null)
			{
				this.SurfaceViewer.DefaultInteraction = state;
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00014FDA File Offset: 0x000131DA
		internal void OnScaleToFit()
		{
			if (this.SurfaceViewer != null)
			{
				this.SurfaceViewer.ScaleToFit();
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00014FEF File Offset: 0x000131EF
		internal void OnZoomTo100()
		{
			if (this.SurfaceViewer != null)
			{
				this.SurfaceViewer.ZoomTo100();
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00015004 File Offset: 0x00013204
		internal void OnContainerSizeChanged()
		{
			this.Refresh(false);
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0001500D File Offset: 0x0001320D
		internal bool Pinching
		{
			get
			{
				return this._pinching;
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00015015 File Offset: 0x00013215
		internal void OnGestureCompleted(global::System.Windows.Point pt)
		{
			this._pinching = false;
			this.Anchor = new global::System.Windows.Point(double.NaN, double.NaN);
		}

		// Token: 0x040001E6 RID: 486
		private const double MaxZoom = 2.0;

		// Token: 0x040001E7 RID: 487
		internal const string SizeStates = "SizeStates";

		// Token: 0x040001E8 RID: 488
		internal const string StateFull = "Full";

		// Token: 0x040001E9 RID: 489
		internal const string StateMinimal = "Minimal";

		// Token: 0x040001EA RID: 490
		internal const string ZoomableStates = "ZoomableStates";

		// Token: 0x040001EB RID: 491
		internal const string StateZoomEnabled = "ZoomEnabled";

		// Token: 0x040001EC RID: 492
		internal const string StateZoomDisabled = "ZoomDisabled";

		// Token: 0x040001ED RID: 493
		internal const string RootElementName = "Root";

		// Token: 0x040001EE RID: 494
		internal const string ContentPresenterElementName = "ContentPresenter";

		// Token: 0x040001EF RID: 495
		internal const string ZoomOutName = "ZoomOut";

		// Token: 0x040001F0 RID: 496
		internal const string ZoomLevelName = "ZoomLevel";

		// Token: 0x040001F1 RID: 497
		internal const string ZoomInName = "ZoomIn";

		// Token: 0x040001F2 RID: 498
		internal const string ZoomTo100Name = "ZoomTo100";

		// Token: 0x040001F3 RID: 499
		internal const string ScaleToFitName = "ScaleToFit";

		// Token: 0x040001F4 RID: 500
		internal const string ButtonCursorName = "ButtonCursor";

		// Token: 0x040001F5 RID: 501
		internal const string DragPanName = "DragPan";

		// Token: 0x040001F6 RID: 502
		internal const string DragZoomName = "DragZoom";

		// Token: 0x040001F7 RID: 503
		internal const string ButtonsGridName = "ButtonsGrid";

		// Token: 0x040001F8 RID: 504
		private const string ImmediatePropertyName = "Immediate";

		// Token: 0x040001F9 RID: 505
		private const string WorldPropertyName = "World";

		// Token: 0x040001FA RID: 506
		internal const string WorldStylePropertyName = "WorldStyle";

		// Token: 0x040001FB RID: 507
		private const string WindowPropertyName = "Window";

		// Token: 0x040001FC RID: 508
		internal const string WindowStylePropertyName = "WindowStyle";

		// Token: 0x040001FD RID: 509
		private const string PreviewPropertyName = "Preview";

		// Token: 0x040001FE RID: 510
		internal const string PreviewStylePropertyName = "PreviewStyle";

		// Token: 0x040001FF RID: 511
		private const string DefaultInteractionButtonToolTipPropertyName = "DefaultInteractionButtonToolTip";

		// Token: 0x04000200 RID: 512
		private const string ZoomLevelLargeChangePropertyName = "ZoomLevelLargeChange";

		// Token: 0x04000201 RID: 513
		private const double DRAG_DISTANCE = 10.0;

		// Token: 0x04000202 RID: 514
		private const double DRAG_DISTANCE_NEAR = 2.0;

		// Token: 0x04000206 RID: 518
		public static readonly global::System.Windows.DependencyProperty ImmediateProperty = global::System.Windows.DependencyProperty.Register("Immediate", typeof(bool), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(true, delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(sender as global::Infragistics.Controls.XamOverviewPlusDetailPane).OnPropertyChanged(new global::Infragistics.Controls.PropertyChangedEventArgs<bool>("Immediate", (bool)e.OldValue, (bool)e.NewValue));
		}));

		// Token: 0x04000207 RID: 519
		public static readonly global::System.Windows.DependencyProperty WorldProperty = global::System.Windows.DependencyProperty.Register("World", typeof(global::System.Windows.Rect), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(global::System.Windows.Rect.Empty, delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(sender as global::Infragistics.Controls.XamOverviewPlusDetailPane).OnPropertyChanged(new global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Rect>("World", (global::System.Windows.Rect)e.OldValue, (global::System.Windows.Rect)e.NewValue));
		}));

		// Token: 0x04000208 RID: 520
		public static readonly global::System.Windows.DependencyProperty WorldStyleProperty = global::System.Windows.DependencyProperty.Register("WorldStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(sender as global::Infragistics.Controls.XamOverviewPlusDetailPane).OnPropertyChanged(new global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Style>("WorldStyle", e.OldValue as global::System.Windows.Style, e.NewValue as global::System.Windows.Style));
		}));

		// Token: 0x04000209 RID: 521
		public static readonly global::System.Windows.DependencyProperty WindowProperty = global::System.Windows.DependencyProperty.Register("Window", typeof(global::System.Windows.Rect), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(global::System.Windows.Rect.Empty, delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(sender as global::Infragistics.Controls.XamOverviewPlusDetailPane).OnPropertyChanged(new global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Rect>("Window", (global::System.Windows.Rect)e.OldValue, (global::System.Windows.Rect)e.NewValue));
		}));

		// Token: 0x0400020A RID: 522
		public static readonly global::System.Windows.DependencyProperty WindowStyleProperty = global::System.Windows.DependencyProperty.Register("WindowStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(sender as global::Infragistics.Controls.XamOverviewPlusDetailPane).OnPropertyChanged(new global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Style>("WindowStyle", e.OldValue as global::System.Windows.Style, e.NewValue as global::System.Windows.Style));
		}));

		// Token: 0x0400020B RID: 523
		public static readonly global::System.Windows.DependencyProperty PreviewProperty = global::System.Windows.DependencyProperty.Register("Preview", typeof(global::System.Windows.Rect), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(global::System.Windows.Rect.Empty, delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(sender as global::Infragistics.Controls.XamOverviewPlusDetailPane).OnPropertyChanged(new global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Rect>("Preview", (global::System.Windows.Rect)e.OldValue, (global::System.Windows.Rect)e.NewValue));
		}));

		// Token: 0x0400020C RID: 524
		public static readonly global::System.Windows.DependencyProperty PreviewStyleProperty = global::System.Windows.DependencyProperty.Register("PreviewStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(sender as global::Infragistics.Controls.XamOverviewPlusDetailPane).OnPropertyChanged(new global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Style>("PreviewStyle", e.OldValue as global::System.Windows.Style, e.NewValue as global::System.Windows.Style));
		}));

		// Token: 0x0400020D RID: 525
		public static readonly global::System.Windows.DependencyProperty ShrinkToThumbnailProperty = global::System.Windows.DependencyProperty.Register("ShrinkToThumbnail", typeof(bool), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.XamOverviewPlusDetailPane.OnShrinkToThumbnailChanged)));

		// Token: 0x0400020E RID: 526
		public static readonly global::System.Windows.DependencyProperty ModeProperty = global::System.Windows.DependencyProperty.Register("Mode", typeof(global::Infragistics.Controls.OverviewPlusDetailPaneMode), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.OverviewPlusDetailPaneMode.Minimal, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.XamOverviewPlusDetailPane.OnModeChanged)));

		// Token: 0x0400020F RID: 527
		private global::Infragistics.Controls.IOverviewPlusDetailControl _surfaceViewer;

		// Token: 0x04000210 RID: 528
		public static readonly global::System.Windows.DependencyProperty ZoomTo100ButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("ZoomTo100ButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Visible, delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamOverviewPlusDetailPane)o).OnPropertyUpdated("ZoomTo100ButtonVisibility", e.OldValue, e.NewValue);
		}));

		// Token: 0x04000211 RID: 529
		public static readonly global::System.Windows.DependencyProperty ScaleToFitButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("ScaleToFitButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Visible, delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamOverviewPlusDetailPane)o).OnPropertyUpdated("ScaleToFitButtonVisibility", e.OldValue, e.NewValue);
		}));

		// Token: 0x04000212 RID: 530
		public static readonly global::System.Windows.DependencyProperty InteractionStatesToolVisibilityProperty = global::System.Windows.DependencyProperty.Register("InteractionStatesToolVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Visible, delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamOverviewPlusDetailPane)o).OnPropertyUpdated("InteractionStatesToolVisibility", e.OldValue, e.NewValue);
		}));

		// Token: 0x04000213 RID: 531
		public static readonly global::System.Windows.DependencyProperty DragPanButtonToolTipProperty = global::System.Windows.DependencyProperty.Register("DragPanButtonToolTip", typeof(object), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(global::SR.GetString("OPD_DragPan"), delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamOverviewPlusDetailPane)o).OnPropertyUpdated("DragPanButtonToolTip", e.OldValue, e.NewValue);
		}));

		// Token: 0x04000214 RID: 532
		public static readonly global::System.Windows.DependencyProperty DragZoomButtonToolTipProperty = global::System.Windows.DependencyProperty.Register("DragZoomButtonToolTip", typeof(object), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(global::SR.GetString("OPD_DragZoom"), delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamOverviewPlusDetailPane)o).OnPropertyUpdated("DragZoomButtonToolTip", e.OldValue, e.NewValue);
		}));

		// Token: 0x04000215 RID: 533
		public static readonly global::System.Windows.DependencyProperty ZoomInButtonToolTipProperty = global::System.Windows.DependencyProperty.Register("ZoomInButtonToolTip", typeof(object), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(global::SR.GetString("OPD_ZoomIn"), delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamOverviewPlusDetailPane)o).OnPropertyUpdated("ZoomInButtonToolTip", e.OldValue, e.NewValue);
		}));

		// Token: 0x04000216 RID: 534
		public static readonly global::System.Windows.DependencyProperty ZoomOutButtonToolTipProperty = global::System.Windows.DependencyProperty.Register("ZoomOutButtonToolTip", typeof(object), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(global::SR.GetString("OPD_ZoomOut"), delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamOverviewPlusDetailPane)o).OnPropertyUpdated("ZoomOutButtonToolTip", e.OldValue, e.NewValue);
		}));

		// Token: 0x04000217 RID: 535
		public static readonly global::System.Windows.DependencyProperty ZoomTo100ButtonToolTipProperty = global::System.Windows.DependencyProperty.Register("ZoomTo100ButtonToolTip", typeof(object), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(global::SR.GetString("OPD_ZoomTo100"), delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamOverviewPlusDetailPane)o).OnPropertyUpdated("ZoomTo100ButtonToolTip", e.OldValue, e.NewValue);
		}));

		// Token: 0x04000218 RID: 536
		public static readonly global::System.Windows.DependencyProperty ScaleToFitButtonToolTipProperty = global::System.Windows.DependencyProperty.Register("ScaleToFitButtonToolTip", typeof(object), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(global::SR.GetString("OPD_ScaleToFit"), delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamOverviewPlusDetailPane)o).OnPropertyUpdated("ScaleToFitButtonToolTip", e.OldValue, e.NewValue);
		}));

		// Token: 0x04000219 RID: 537
		public static readonly global::System.Windows.DependencyProperty DefaultInteractionButtonToolTipProperty = global::System.Windows.DependencyProperty.Register("DefaultInteractionButtonToolTip", typeof(object), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(global::SR.GetString("OPD_DefaultInteraction"), delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamOverviewPlusDetailPane)o).OnPropertyUpdated("DefaultInteractionButtonToolTip", e.OldValue, e.NewValue);
		}));

		// Token: 0x0400021A RID: 538
		public static readonly global::System.Windows.DependencyProperty ZoomLevelLargeChangeProperty = global::System.Windows.DependencyProperty.Register("ZoomLevelLargeChange", typeof(double), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(1.0, delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.XamOverviewPlusDetailPane)o).OnPropertyUpdated("ZoomLevelLargeChange", e.OldValue, e.NewValue);
		}));

		// Token: 0x0400021B RID: 539
		internal static readonly global::System.Windows.DependencyProperty InnerHorizontalAlignmentProperty = global::System.Windows.DependencyProperty.Register("InnerHorizontalAlignment", typeof(global::System.Windows.HorizontalAlignment), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(global::System.Windows.HorizontalAlignment.Stretch, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.XamOverviewPlusDetailPane.OnInnerHorizontalAlignmentChanged)));

		// Token: 0x0400021C RID: 540
		internal static readonly global::System.Windows.DependencyProperty InnerVerticalAlignmentProperty = global::System.Windows.DependencyProperty.Register("InnerVerticalAlignment", typeof(global::System.Windows.VerticalAlignment), typeof(global::Infragistics.Controls.XamOverviewPlusDetailPane), new global::System.Windows.PropertyMetadata(global::System.Windows.VerticalAlignment.Stretch, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.XamOverviewPlusDetailPane.OnInnerVerticalAlignmentChanged)));

		// Token: 0x0400021D RID: 541
		private bool _isZoomable;

		// Token: 0x0400021E RID: 542
		private global::System.Windows.Point _lastPosition;

		// Token: 0x0400021F RID: 543
		private bool _ignoreContactUp;

		// Token: 0x04000221 RID: 545
		private bool _pinching;
	}
}
