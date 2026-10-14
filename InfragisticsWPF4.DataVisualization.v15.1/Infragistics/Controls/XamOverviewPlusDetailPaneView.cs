using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Infragistics.Controls
{
	// Token: 0x0200005C RID: 92
	internal class XamOverviewPlusDetailPaneView
	{
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x0001503B File Offset: 0x0001323B
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x00015043 File Offset: 0x00013243
		protected global::Infragistics.Controls.XamOverviewPlusDetailPane Model { get; set; }

		// Token: 0x0600055B RID: 1371 RVA: 0x0001504C File Offset: 0x0001324C
		public XamOverviewPlusDetailPaneView(global::Infragistics.Controls.XamOverviewPlusDetailPane model)
		{
			this.Model = model;
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x0001505B File Offset: 0x0001325B
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x00015063 File Offset: 0x00013263
		private global::System.Windows.FrameworkElement RootElement { get; set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x0001506C File Offset: 0x0001326C
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x00015074 File Offset: 0x00013274
		public global::System.Windows.Controls.Canvas PreviewCanvas
		{
			get
			{
				return this._previewCanvas;
			}
			private set
			{
				this._previewCanvas = value;
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0001508C File Offset: 0x0001328C
		public virtual void OnInit()
		{
			this.RootCanvas = new global::System.Windows.Controls.Canvas
			{
				IsHitTestVisible = false
			};
			this.RootCanvas.SizeChanged += delegate(object o, global::System.Windows.SizeChangedEventArgs e)
			{
				this.Model.OnContainerSizeChanged();
			};
			this.PreviewCanvas = new global::System.Windows.Controls.Canvas();
			this.RootCanvas.Children.Add(this.PreviewCanvas);
			this.WorldPath = new global::System.Windows.Shapes.Path
			{
				IsHitTestVisible = true,
				Data = new global::System.Windows.Media.RectangleGeometry()
			};
			this.WorldPath.SetBinding(global::System.Windows.FrameworkElement.StyleProperty, new global::System.Windows.Data.Binding("WorldStyle")
			{
				Source = this.Model
			});
			this.RootCanvas.Children.Add(this.WorldPath);
			this.WindowPath = new global::System.Windows.Shapes.Path
			{
				IsHitTestVisible = false,
				Data = new global::System.Windows.Media.GeometryGroup(),
				Clip = new global::System.Windows.Media.RectangleGeometry()
			};
			this.WindowPath.SetBinding(global::System.Windows.FrameworkElement.StyleProperty, new global::System.Windows.Data.Binding("WindowStyle")
			{
				Source = this.Model
			});
			(this.WindowPath.Data as global::System.Windows.Media.GeometryGroup).Children.Add(new global::System.Windows.Media.RectangleGeometry());
			(this.WindowPath.Data as global::System.Windows.Media.GeometryGroup).Children.Add(new global::System.Windows.Media.RectangleGeometry());
			this.RootCanvas.Children.Add(this.WindowPath);
			this.PreviewPath = new global::System.Windows.Shapes.Path
			{
				IsHitTestVisible = false,
				Data = new global::System.Windows.Media.GeometryGroup(),
				Clip = new global::System.Windows.Media.RectangleGeometry()
			};
			this.PreviewPath.SetBinding(global::System.Windows.FrameworkElement.StyleProperty, new global::System.Windows.Data.Binding("PreviewStyle")
			{
				Source = this.Model
			});
			(this.PreviewPath.Data as global::System.Windows.Media.GeometryGroup).Children.Add(new global::System.Windows.Media.RectangleGeometry());
			(this.PreviewPath.Data as global::System.Windows.Media.GeometryGroup).Children.Add(new global::System.Windows.Media.RectangleGeometry());
			this.RootCanvas.Children.Add(this.PreviewPath);
			this.Model.SetBinding(global::Infragistics.Controls.XamOverviewPlusDetailPane.InnerHorizontalAlignmentProperty, new global::System.Windows.Data.Binding("HorizontalAlignment")
			{
				Source = this.Model
			});
			this.Model.SetBinding(global::Infragistics.Controls.XamOverviewPlusDetailPane.InnerVerticalAlignmentProperty, new global::System.Windows.Data.Binding("VerticalAlignment")
			{
				Source = this.Model
			});
			this.Model.MouseEnter += this.Model_MouseEnter;
			this.Model.MouseLeave += this.Model_MouseLeave;
			this.Model.MouseLeftButtonDown += this.Model_MouseLeftButtonDown;
			this.Model.MouseMove += this.Model_MouseMove;
			this.Model.MouseLeftButtonUp += this.Model_MouseLeftButtonUp;
			this.Model.MouseWheel += this.Model_MouseWheel;
			this.Model.KeyDown += this.Model_KeyDown;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00015399 File Offset: 0x00013599
		private void Model_MouseWheel(object sender, global::System.Windows.Input.MouseWheelEventArgs e)
		{
			e.Handled = true;
			this.Model.OnMouseWheel((double)e.Delta / 1200.0);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x000153C0 File Offset: 0x000135C0
		private void Model_MouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.Point position = e.GetPosition(this.RootCanvas);
			e.Handled = this.Model.OnMouseLeftButtonUp(position);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000153EC File Offset: 0x000135EC
		private void Model_MouseMove(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			global::System.Windows.Point position = e.GetPosition(this.RootCanvas);
			this.Model.OnMouseMove(position, true, false);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00015414 File Offset: 0x00013614
		private void Model_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			e.Handled = true;
			global::System.Windows.Point position = e.GetPosition(this.RootCanvas);
			this.Model.OnMouseLeftButtonDown(position);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00015441 File Offset: 0x00013641
		private void Model_KeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			e.Handled = this.Model.OnKeyDown(e.Key);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0001545A File Offset: 0x0001365A
		private void Model_MouseLeave(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			this.Model.OnMouseLeave();
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00015467 File Offset: 0x00013667
		private void Model_MouseEnter(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			this.Model.OnMouseEnter();
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00015474 File Offset: 0x00013674
		internal void GoToFullState()
		{
			global::System.Windows.VisualStateManager.GoToState(this.Model, "Full", false);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00015488 File Offset: 0x00013688
		internal void GoToMinimalState()
		{
			global::System.Windows.VisualStateManager.GoToState(this.Model, "Minimal", false);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0001549C File Offset: 0x0001369C
		internal void GoToZoomEnabledState()
		{
			global::System.Windows.VisualStateManager.GoToState(this.Model, "ZoomEnabled", false);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000154B0 File Offset: 0x000136B0
		internal void GoToZoomDisabledState()
		{
			global::System.Windows.VisualStateManager.GoToState(this.Model, "ZoomDisabled", false);
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x000154C4 File Offset: 0x000136C4
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x000154CC File Offset: 0x000136CC
		private global::System.Windows.Controls.Canvas RootCanvas { get; set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x000154D5 File Offset: 0x000136D5
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x000154DD File Offset: 0x000136DD
		private global::System.Windows.Controls.ContentPresenter ContentPresenter
		{
			get
			{
				return this._contentPresenter;
			}
			set
			{
				if (this._contentPresenter != value)
				{
					if (this._contentPresenter != null)
					{
						this._contentPresenter.Content = null;
					}
					this._contentPresenter = value;
					if (this._contentPresenter != null)
					{
						this._contentPresenter.Content = this.RootCanvas;
					}
				}
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0001551C File Offset: 0x0001371C
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00015524 File Offset: 0x00013724
		private global::System.Windows.Controls.Primitives.ButtonBase ButtonZoomIn { get; set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0001552D File Offset: 0x0001372D
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x00015535 File Offset: 0x00013735
		private global::System.Windows.Controls.Primitives.ButtonBase ButtonZoomTo100 { get; set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x0001553E File Offset: 0x0001373E
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x00015546 File Offset: 0x00013746
		private global::System.Windows.Controls.Primitives.ButtonBase ButtonScaleToFit { get; set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0001554F File Offset: 0x0001374F
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x00015557 File Offset: 0x00013757
		private global::System.Windows.Controls.Primitives.ButtonBase ButtonZoomOut { get; set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x00015560 File Offset: 0x00013760
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x00015568 File Offset: 0x00013768
		private global::System.Windows.Controls.Panel ButtonsGrid { get; set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x00015571 File Offset: 0x00013771
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x00015579 File Offset: 0x00013779
		private global::System.Windows.Controls.Primitives.ToggleButton ButtonCursor { get; set; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x00015582 File Offset: 0x00013782
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x0001558A File Offset: 0x0001378A
		private global::System.Windows.Controls.Primitives.ToggleButton ButtonDragPan { get; set; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00015593 File Offset: 0x00013793
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x0001559B File Offset: 0x0001379B
		private global::System.Windows.Controls.Primitives.ToggleButton ButtonDragZoom { get; set; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x000155A4 File Offset: 0x000137A4
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x000155AC File Offset: 0x000137AC
		private global::System.Windows.Shapes.Path WorldPath { get; set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x000155B5 File Offset: 0x000137B5
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x000155BD File Offset: 0x000137BD
		private global::System.Windows.Shapes.Path WindowPath { get; set; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x000155C6 File Offset: 0x000137C6
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x000155CE File Offset: 0x000137CE
		private global::System.Windows.Shapes.Path PreviewPath { get; set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x000155D7 File Offset: 0x000137D7
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x000155DF File Offset: 0x000137DF
		private global::System.Windows.Controls.Slider SliderZoomLevel { get; set; }

		// Token: 0x06000588 RID: 1416 RVA: 0x000155E8 File Offset: 0x000137E8
		public virtual void OnTemplateProvided()
		{
			this.ContentPresenter = (this.Model.FetchChildByName("ContentPresenter") as global::System.Windows.Controls.ContentPresenter);
			if (this.ButtonZoomIn != null)
			{
				this.ButtonZoomIn.Click -= this.ButtonZoomIn_Click;
			}
			this.ButtonZoomIn = (this.Model.FetchChildByName("ZoomIn") as global::System.Windows.Controls.Primitives.ButtonBase);
			if (this.ButtonZoomIn != null)
			{
				this.ButtonZoomIn.Click += this.ButtonZoomIn_Click;
			}
			if (this.ButtonZoomOut != null)
			{
				this.ButtonZoomOut.Click -= this.ButtonZoomOut_Click;
			}
			this.ButtonZoomOut = (this.Model.FetchChildByName("ZoomOut") as global::System.Windows.Controls.Primitives.ButtonBase);
			if (this.ButtonZoomOut != null)
			{
				this.ButtonZoomOut.Click += this.ButtonZoomOut_Click;
			}
			if (this.ButtonZoomTo100 != null)
			{
				this.ButtonZoomTo100.Click -= this.ButtonZoomTo100_Click;
			}
			this.ButtonZoomTo100 = (this.Model.FetchChildByName("ZoomTo100") as global::System.Windows.Controls.Primitives.ButtonBase);
			if (this.ButtonZoomTo100 != null)
			{
				this.ButtonZoomTo100.Click += this.ButtonZoomTo100_Click;
			}
			if (this.ButtonScaleToFit != null)
			{
				this.ButtonScaleToFit.Click -= this.ButtonScaleToFit_Click;
			}
			this.ButtonScaleToFit = (this.Model.FetchChildByName("ScaleToFit") as global::System.Windows.Controls.Primitives.ButtonBase);
			if (this.ButtonScaleToFit != null)
			{
				this.ButtonScaleToFit.Click += this.ButtonScaleToFit_Click;
			}
			this.SliderZoomLevel = (this.Model.FetchChildByName("ZoomLevel") as global::System.Windows.Controls.Slider);
			this.RootElement = (this.Model.FetchChildByName("Root") as global::System.Windows.FrameworkElement);
			if (this.ButtonCursor != null)
			{
				this.ButtonCursor.Click -= this.ButtonCursor_Click;
			}
			this.ButtonCursor = (this.Model.FetchChildByName("ButtonCursor") as global::System.Windows.Controls.Primitives.ToggleButton);
			if (this.ButtonCursor != null)
			{
				this.ButtonCursor.Click += this.ButtonCursor_Click;
			}
			if (this.ButtonDragPan != null)
			{
				this.ButtonDragPan.Click -= this.ButtonDragPan_Click;
			}
			this.ButtonDragPan = (this.Model.FetchChildByName("DragPan") as global::System.Windows.Controls.Primitives.ToggleButton);
			if (this.ButtonDragPan != null)
			{
				this.ButtonDragPan.Click += this.ButtonDragPan_Click;
			}
			if (this.ButtonDragZoom != null)
			{
				this.ButtonDragZoom.Click -= this.ButtonDragZoom_Click;
			}
			this.ButtonDragZoom = (this.Model.FetchChildByName("DragZoom") as global::System.Windows.Controls.Primitives.ToggleButton);
			if (this.ButtonDragZoom != null)
			{
				this.ButtonDragZoom.Click += this.ButtonDragZoom_Click;
			}
			this.ButtonsGrid = (this.Model.FetchChildByName("ButtonsGrid") as global::System.Windows.Controls.Panel);
			this.SetSurfaceBindings();
			this.UpdateInteractionButtonStates(this._activeInteractionState);
			this.Model.Refresh(false);
			this.SetRenderOrigin();
			if (this.Model.ShrinkToThumbnail)
			{
				global::System.Windows.VisualStateManager.GoToState(this.Model, "Minimal", false);
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00015913 File Offset: 0x00013B13
		private void ButtonCursor_Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this.ButtonsGrid.Visibility == global::System.Windows.Visibility.Visible)
			{
				this.ButtonsGrid.Visibility = global::System.Windows.Visibility.Collapsed;
				return;
			}
			this.ButtonsGrid.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0001593C File Offset: 0x00013B3C
		private void ButtonDragZoom_Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.ButtonDragPan.IsChecked = new bool?(this.ButtonDragZoom.IsChecked == false);
			this.Model.OnDefaultInteraction(global::Infragistics.Controls.InteractionState.DragZoom);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00015984 File Offset: 0x00013B84
		private void ButtonDragPan_Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.ButtonDragZoom.IsChecked = new bool?(this.ButtonDragPan.IsChecked == false);
			this.Model.OnDefaultInteraction(global::Infragistics.Controls.InteractionState.DragPan);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x000159CC File Offset: 0x00013BCC
		private void ButtonScaleToFit_Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.Model.OnScaleToFit();
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x000159D9 File Offset: 0x00013BD9
		private void ButtonZoomTo100_Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.Model.OnZoomTo100();
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x000159E6 File Offset: 0x00013BE6
		private void ButtonZoomOut_Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this.SliderZoomLevel != null)
			{
				this.SliderZoomLevel.Value -= this.SliderZoomLevel.SmallChange;
			}
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00015A0D File Offset: 0x00013C0D
		private void ButtonZoomIn_Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this.SliderZoomLevel != null)
			{
				this.SliderZoomLevel.Value += this.SliderZoomLevel.SmallChange;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00015A34 File Offset: 0x00013C34
		public global::System.Windows.Rect Viewport
		{
			get
			{
				if (this.RootCanvas.ActualWidth * this.RootCanvas.ActualHeight <= 0.0)
				{
					return global::System.Windows.Rect.Empty;
				}
				return new global::System.Windows.Rect(0.0, 0.0, this.RootCanvas.ActualWidth, this.RootCanvas.ActualHeight);
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00015A98 File Offset: 0x00013C98
		internal void SetRenderOrigin()
		{
			if (this.RootElement == null)
			{
				return;
			}
			global::System.Windows.Point renderTransformOrigin = new global::System.Windows.Point(0.0, 0.0);
			switch (this.Model.HorizontalAlignment)
			{
			case global::System.Windows.HorizontalAlignment.Left:
				goto IL_64;
			case global::System.Windows.HorizontalAlignment.Right:
				renderTransformOrigin.X = 1.0;
				goto IL_64;
			}
			renderTransformOrigin.X = 0.5;
			IL_64:
			switch (this.Model.VerticalAlignment)
			{
			case global::System.Windows.VerticalAlignment.Top:
				goto IL_A6;
			case global::System.Windows.VerticalAlignment.Bottom:
				renderTransformOrigin.Y = 1.0;
				goto IL_A6;
			}
			renderTransformOrigin.Y = 0.5;
			IL_A6:
			this.RootElement.RenderTransformOrigin = renderTransformOrigin;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00015B57 File Offset: 0x00013D57
		internal void UpdateWorldRect(global::System.Windows.Rect world)
		{
			(this.WorldPath.Data as global::System.Windows.Media.RectangleGeometry).Rect = world;
			this.WorldPath.Visibility = (world.IsEmpty ? global::System.Windows.Visibility.Collapsed : global::System.Windows.Visibility.Visible);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00015B88 File Offset: 0x00013D88
		internal void UpdateWindowPath(global::System.Windows.Rect world, global::System.Windows.Rect window)
		{
			(this.WindowPath.Clip as global::System.Windows.Media.RectangleGeometry).Rect = world;
			((this.WindowPath.Data as global::System.Windows.Media.GeometryGroup).Children[0] as global::System.Windows.Media.RectangleGeometry).Rect = global::Infragistics.RectUtil.InflateBy(world, new global::System.Windows.Thickness(2.0));
			((this.WindowPath.Data as global::System.Windows.Media.GeometryGroup).Children[1] as global::System.Windows.Media.RectangleGeometry).Rect = window;
			this.WindowPath.Visibility = (window.IsEmpty ? global::System.Windows.Visibility.Collapsed : global::System.Windows.Visibility.Visible);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00015C24 File Offset: 0x00013E24
		internal void UpdatePreviewPath(global::System.Windows.Rect world, global::System.Windows.Rect preview)
		{
			(this.PreviewPath.Clip as global::System.Windows.Media.RectangleGeometry).Rect = world;
			((this.PreviewPath.Data as global::System.Windows.Media.GeometryGroup).Children[0] as global::System.Windows.Media.RectangleGeometry).Rect = global::Infragistics.RectUtil.InflateBy(world, new global::System.Windows.Thickness(2.0));
			((this.PreviewPath.Data as global::System.Windows.Media.GeometryGroup).Children[1] as global::System.Windows.Media.RectangleGeometry).Rect = preview;
			this.PreviewPath.Visibility = (preview.IsEmpty ? global::System.Windows.Visibility.Collapsed : global::System.Windows.Visibility.Visible);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00015CC0 File Offset: 0x00013EC0
		internal void UpdateInteractionButtonStates(global::Infragistics.Controls.InteractionState activeState)
		{
			this._activeInteractionState = activeState;
			if (this.ButtonDragPan != null)
			{
				this.ButtonDragPan.IsChecked = new bool?(activeState == global::Infragistics.Controls.InteractionState.DragPan);
			}
			if (this.ButtonDragZoom != null)
			{
				this.ButtonDragZoom.IsChecked = new bool?(activeState == global::Infragistics.Controls.InteractionState.DragZoom);
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00015D0C File Offset: 0x00013F0C
		internal void SetSurfaceBindings()
		{
			if (this.Model.SurfaceViewer == null || this.SliderZoomLevel == null)
			{
				return;
			}
			this.SliderZoomLevel.DataContext = this.Model.SurfaceViewer;
			this.SliderZoomLevel.SetBinding(global::System.Windows.Controls.Primitives.RangeBase.ValueProperty, new global::System.Windows.Data.Binding("ZoomLevel")
			{
				Mode = global::System.Windows.Data.BindingMode.TwoWay
			});
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00015D69 File Offset: 0x00013F69
		internal bool IsReady()
		{
			return this.SliderZoomLevel != null;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00015D77 File Offset: 0x00013F77
		internal double GetSliderValue()
		{
			return this.SliderZoomLevel.Value;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00015D84 File Offset: 0x00013F84
		internal void SetSliderMin(double minimum)
		{
			this.SliderZoomLevel.Minimum = minimum;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00015D92 File Offset: 0x00013F92
		internal void SetSliderMax(double maximum)
		{
			this.SliderZoomLevel.Maximum = maximum;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00015DA0 File Offset: 0x00013FA0
		internal void CancelMouseOperations()
		{
			this.Model.ReleaseMouseCapture();
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00015DAD File Offset: 0x00013FAD
		internal bool CaptureMouse()
		{
			return this.Model.CaptureMouse();
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00015DBC File Offset: 0x00013FBC
		internal void PositionPreview(global::System.Windows.Rect world)
		{
			bool flag = false;
			global::System.Windows.Size oldValue = new global::System.Windows.Size(this.PreviewCanvas.Width, this.PreviewCanvas.Height);
			if (global::System.Math.Round(this.PreviewCanvas.Width) != global::System.Math.Round(world.Width))
			{
				flag = true;
				this.PreviewCanvas.Width = world.Width;
			}
			if (global::System.Math.Round(this.PreviewCanvas.Height) != global::System.Math.Round(world.Height))
			{
				flag = true;
				this.PreviewCanvas.Height = world.Height;
			}
			global::System.Windows.Controls.Canvas.SetLeft(this.PreviewCanvas, world.X);
			global::System.Windows.Controls.Canvas.SetTop(this.PreviewCanvas, world.Y);
			if (flag)
			{
				global::System.Windows.Size newValue = new global::System.Windows.Size(this.PreviewCanvas.Width, this.PreviewCanvas.Height);
				this.Model.OnThumbnailSizeChanged(new global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Size>("ThumbnailSize", oldValue, newValue));
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00015EA7 File Offset: 0x000140A7
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x00015EAF File Offset: 0x000140AF
		public bool UseDeltaZoom { get; set; }

		// Token: 0x04000239 RID: 569
		private global::Infragistics.Controls.InteractionState _activeInteractionState;

		// Token: 0x0400023A RID: 570
		private global::System.Windows.Controls.Canvas _previewCanvas;

		// Token: 0x0400023B RID: 571
		private global::System.Windows.Controls.ContentPresenter _contentPresenter;
	}
}
