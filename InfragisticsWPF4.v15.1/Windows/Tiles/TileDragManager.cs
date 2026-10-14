using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.Tiles
{
	// Token: 0x020001CC RID: 460
	internal class TileDragManager
	{
		// Token: 0x06000FF7 RID: 4087 RVA: 0x00034A7C File Offset: 0x00032C7C
		internal TileDragManager(global::Infragistics.Windows.Tiles.TilesPanelBase panel, global::System.Windows.FrameworkElement tile, global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo, global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem, global::System.Windows.FrameworkElement dragElement, global::Infragistics.Windows.Tiles.AllowTileDragging allowTileDragging)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(panel);
			this._tile = tile;
			this._itemInfo = itemInfo;
			this._layoutItem = layoutItem;
			this._panel = panel;
			this._tileManager = panel.GetManager();
			this._dragElement = dragElement;
			this._allowTileDragging = allowTileDragging;
			panel.Unloaded += this.OnPanelUnloaded;
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x00034AE0 File Offset: 0x00032CE0
		internal global::Infragistics.Windows.Tiles.TilesPanelBase Panel
		{
			get
			{
				return this._panel;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00034AE8 File Offset: 0x00032CE8
		internal bool PanelWasUnloaded
		{
			get
			{
				return this._panelWasUnloaded;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x00034AF0 File Offset: 0x00032CF0
		internal global::Infragistics.Windows.Internal.TileManager TileManager
		{
			get
			{
				return this._tileManager;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x00034AF8 File Offset: 0x00032CF8
		internal global::System.Windows.FrameworkElement Tile
		{
			get
			{
				return this._tile;
			}
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00034B00 File Offset: 0x00032D00
		internal global::Infragistics.Windows.Tiles.TileDragManager.RectInfo GetLayoutAreaRect()
		{
			global::Infragistics.Windows.Tiles.TilesPanelBase panel = this.Panel;
			global::System.Windows.Rect rect = new global::System.Windows.Rect(panel.TileAreaSize);
			global::System.Windows.Thickness tileAreaPadding = panel.GetTileAreaPadding();
			rect.Offset(new global::System.Windows.Vector(tileAreaPadding.Left, tileAreaPadding.Top));
			return new global::Infragistics.Windows.Tiles.TileDragManager.RectInfo(this, rect, panel);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00034B4C File Offset: 0x00032D4C
		private global::Infragistics.Windows.Selection.ScrollSpeed CalcScrollSpeed(double distance)
		{
			double num = 200.0;
			int val = 0;
			int num2 = 6;
			return (global::Infragistics.Windows.Selection.ScrollSpeed)global::System.Math.Max(val, global::System.Math.Min(num2, (int)((double)num2 * (distance / num))));
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00034B7C File Offset: 0x00032D7C
		private void DragHelper(global::Infragistics.Windows.Tiles.TileDragManager.PointInfo mouseLoc, bool apply)
		{
			global::System.Windows.Point point;
			global::Infragistics.Windows.Tiles.TileDragManager.DropInfo dropInfo = this.DragHelper_GetDropInfoHelper(mouseLoc, out point);
			if (!this._dragIndicatorShown)
			{
				this._dragIndicatorWindow_OffsetFromMouse = ((this._dragElement != null) ? global::Infragistics.Windows.Utilities.EnsureInElementBounds(mouseLoc.GetPosition(this._dragElement), this._dragElement) : new global::System.Windows.Point(0.0, 0.0));
				if (this._dragElement.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
				{
					this._dragIndicatorWindow_OffsetFromMouse.X = this._dragElement.ActualWidth - this._dragIndicatorWindow_OffsetFromMouse.X;
				}
				dropInfo = this.DragHelper_GetDropInfoHelper(mouseLoc, out point);
				this.ShowDragIndicator(point);
			}
			if (this._dragIndicatorWindow != null)
			{
				this.PositionToolWindow(this._dragIndicatorWindow, point);
			}
			bool flag = dropInfo != null && dropInfo.IsDropNOOP;
			bool flag2 = dropInfo != null && dropInfo.IsDropValid;
			bool flag3 = dropInfo != null && dropInfo.IsDragAreaInvalid;
			if (flag3)
			{
				global::System.Windows.Input.Mouse.OverrideCursor = global::System.Windows.Input.Cursors.No;
			}
			else
			{
				global::System.Windows.Input.Mouse.OverrideCursor = null;
			}
			if (!flag && flag2)
			{
				global::Infragistics.Windows.Internal.TileManager.LayoutItem dropTargetItem = dropInfo.DropTargetItem;
				this._isSwapping = (this._allowTileDragging == global::Infragistics.Windows.Tiles.AllowTileDragging.Swap);
				if (!this._isSwapping && dropTargetItem != null && dropTargetItem.ItemInfo != null)
				{
					this._isSwapping = (dropTargetItem.ItemInfo.GetIsMaximized() != this._itemInfo.GetIsMaximized());
				}
				if ((apply && this._isSwapping) || (!apply && !this._isSwapping))
				{
					dropInfo.ApplyDrop();
					return;
				}
				if (!apply && dropTargetItem != null)
				{
					this.SetSwapTarget(dropTargetItem);
				}
			}
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00034CF0 File Offset: 0x00032EF0
		private global::Infragistics.Windows.Tiles.TileDragManager.DropInfo DragHelper_GetDropInfoHelper(global::Infragistics.Windows.Tiles.TileDragManager.PointInfo mouseLoc, out global::System.Windows.Point dragIndicatorLocation)
		{
			global::Infragistics.Windows.Tiles.TileDragManager.DropInfo dropInfo = null;
			bool flag = mouseLoc.IsInsideTilesPanel();
			dragIndicatorLocation = mouseLoc.GetPositionInScreen();
			dragIndicatorLocation.Offset(-this._dragIndicatorWindow_OffsetFromMouse.X, -this._dragIndicatorWindow_OffsetFromMouse.Y);
			global::System.Windows.Thickness tileAreaPadding = this._panel.GetTileAreaPadding();
			if (this._panel.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
			{
				tileAreaPadding.Left += this._layoutItem.TargetRect.Size.Width;
			}
			this._layoutItem.SetTargetRect(new global::System.Windows.Rect(global::System.Windows.Point.Add(this._panel.PointFromScreen(dragIndicatorLocation), new global::System.Windows.Vector(-tileAreaPadding.Left, -tileAreaPadding.Top)), this._layoutItem.TargetRect.Size), true);
			this._layoutItem.CurrentRect = this._layoutItem.TargetRect;
			global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItemFromPoint = this._tileManager.GetLayoutItemFromPoint(mouseLoc.GetPosition(this._panel), this._layoutItem);
			if (layoutItemFromPoint != null)
			{
				dropInfo = new global::Infragistics.Windows.Tiles.TileDragManager.DropInfo(this, layoutItemFromPoint, layoutItemFromPoint.Container == this._tile);
			}
			else
			{
				this.SetSwapTarget(null);
			}
			if (dropInfo == null && !flag)
			{
				dropInfo = new global::Infragistics.Windows.Tiles.TileDragManager.DropInfo(this, true);
			}
			return dropInfo;
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00034E2A File Offset: 0x0003302A
		internal void HideDragIndicator()
		{
			if (this._dragIndicatorWindow != null)
			{
				this._dragIndicatorWindow.Close();
				this._dragIndicatorShown = false;
			}
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00034E48 File Offset: 0x00033048
		internal void OnDragEnd(global::System.Windows.Input.MouseEventArgs mouseEventArgs, bool cancel)
		{
			this._panel.Unloaded -= this.OnPanelUnloaded;
			this.SetSwapTarget(null);
			this.OnDragEndHelper(mouseEventArgs, cancel);
			this._panel.OnEndDrag(this._tile);
			this._panel.InvalidateMeasure();
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00034E98 File Offset: 0x00033098
		private void OnDragEndHelper(global::System.Windows.Input.MouseEventArgs mouseEventArgs, bool cancel)
		{
			if (!cancel && !this._panelWasUnloaded)
			{
				global::Infragistics.Windows.Tiles.TileDragManager.PointInfo mouseLoc = new global::Infragistics.Windows.Tiles.TileDragManager.PointInfo(this, mouseEventArgs.GetPosition(this._panel), this._panel);
				this.DragHelper(mouseLoc, true);
			}
			global::System.Windows.Input.Mouse.OverrideCursor = null;
			this.HideDragIndicator();
			if (this._dragIndicatorWindow != null)
			{
				this._dragIndicatorWindow.Close();
				this._dragIndicatorWindow = null;
			}
			if (this._dropIndicatorWindow != null)
			{
				this._dropIndicatorWindow.Close();
				this._dropIndicatorWindow = null;
			}
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00034F14 File Offset: 0x00033114
		internal void OnMouseMove(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			if (this._panelWasUnloaded)
			{
				return;
			}
			global::Infragistics.Windows.Tiles.TileDragManager.PointInfo mouseLoc = new global::Infragistics.Windows.Tiles.TileDragManager.PointInfo(this, mouseEventArgs.GetPosition(this._panel), this._panel);
			this.DragHelper(mouseLoc, false);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00034F4B File Offset: 0x0003314B
		private void OnPanelUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this._panelWasUnloaded = true;
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00034F54 File Offset: 0x00033154
		private void PositionToolWindow(global::Infragistics.Windows.Controls.ToolWindow toolWindow, global::System.Windows.Point screenPoint)
		{
			global::System.Windows.Point relativePoint = global::Infragistics.Windows.Utilities.PointFromScreenSafe(this._panel, screenPoint);
			global::System.Windows.FrameworkElement owner = toolWindow.Owner ?? this._panel;
			relativePoint = global::Infragistics.Windows.Controls.ToolWindow.GetScreenPoint(owner, relativePoint, this._panel);
			toolWindow.Left = relativePoint.X;
			toolWindow.Top = relativePoint.Y;
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00034FA8 File Offset: 0x000331A8
		private void SetSwapTarget(global::Infragistics.Windows.Internal.TileManager.LayoutItem swapTarget)
		{
			if (swapTarget == this._lastSwapTarget)
			{
				return;
			}
			if (this._lastSwapTarget != null && this._lastSwapTarget.Container != null)
			{
				this._lastSwapTarget.Container.ClearValue(global::Infragistics.Windows.Tiles.TilesPanelBase.IsSwapTargetPropertyKey);
			}
			this._lastSwapTarget = swapTarget;
			if (this._lastSwapTarget != null)
			{
				this._canSwapTarget = this._panel.CanSwapContainers(this._layoutItem.Container as global::System.Windows.FrameworkElement, this._layoutItem.ItemInfo, this._lastSwapTarget.Container as global::System.Windows.FrameworkElement, this._lastSwapTarget.ItemInfo);
				if (this._canSwapTarget)
				{
					this._lastSwapTarget.Container.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.IsSwapTargetPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
			}
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00035064 File Offset: 0x00033264
		internal void ShowDragIndicator(global::System.Windows.Point dragIndicatorLocation)
		{
			this._dragIndicatorWindow = new global::Infragistics.Windows.Controls.ToolWindow();
			this._dragIndicatorWindow.ResizeMode = global::System.Windows.ResizeMode.NoResize;
			this._dragIndicatorWindow.UseOSNonClientArea = false;
			this._dragIndicatorWindow.FlowDirection = this._panel.FlowDirection;
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.ContentPresenter));
			frameworkElementFactory.Name = "PART_Content";
			global::System.Windows.Controls.ControlTemplate controlTemplate = new global::System.Windows.Controls.ControlTemplate(typeof(global::Infragistics.Windows.Controls.ToolWindow));
			controlTemplate.VisualTree = frameworkElementFactory;
			controlTemplate.Seal();
			this._dragIndicatorWindow.Template = controlTemplate;
			global::Infragistics.Windows.Tiles.TileDragIndicator tileDragIndicator = new global::Infragistics.Windows.Tiles.TileDragIndicator();
			this._dragIndicatorWindow.Content = tileDragIndicator;
			tileDragIndicator.SetValue(global::Infragistics.Windows.Tiles.TileDragIndicator.ContainerPropertyKey, this._tile);
			this._tile.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.IsDraggingPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
			this._tile.UpdateLayout();
			global::System.Windows.Size renderSize = this._tile.RenderSize;
			renderSize.Width += 0.5;
			renderSize.Height += 0.5;
			global::System.Windows.Media.Imaging.RenderTargetBitmap renderTargetBitmap = new global::System.Windows.Media.Imaging.RenderTargetBitmap((int)renderSize.Width, (int)renderSize.Height, 96.0, 96.0, global::System.Windows.Media.PixelFormats.Default);
			if (global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(this._tile) > 0)
			{
				renderTargetBitmap.Render((global::System.Windows.Media.Visual)global::System.Windows.Media.VisualTreeHelper.GetChild(this._tile, 0));
			}
			else
			{
				renderTargetBitmap.Render(this._tile);
			}
			renderTargetBitmap.Freeze();
			tileDragIndicator.Content = new global::System.Windows.Controls.Image
			{
				Source = renderTargetBitmap,
				Stretch = global::System.Windows.Media.Stretch.None,
				Width = renderSize.Width,
				Height = renderSize.Height
			};
			this.PositionToolWindow(this._dragIndicatorWindow, dragIndicatorLocation);
			this._dragIndicatorWindow.Show(this._panel, false);
			this._dragIndicatorShown = true;
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00035238 File Offset: 0x00033438
		internal void StartDrag(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			global::Infragistics.Windows.Tiles.TileDragManager.PointInfo mouseLoc = new global::Infragistics.Windows.Tiles.TileDragManager.PointInfo(this, mouseEventArgs.GetPosition(this._panel), this._panel);
			this.DragHelper(mouseLoc, false);
		}

		// Token: 0x0400086C RID: 2156
		private global::Infragistics.Windows.Internal.TileManager _tileManager;

		// Token: 0x0400086D RID: 2157
		private global::Infragistics.Windows.Internal.TileManager.LayoutItem _layoutItem;

		// Token: 0x0400086E RID: 2158
		private global::Infragistics.Windows.Tiles.TilesPanelBase _panel;

		// Token: 0x0400086F RID: 2159
		private global::System.Windows.FrameworkElement _tile;

		// Token: 0x04000870 RID: 2160
		private global::Infragistics.Windows.Tiles.ItemInfoBase _itemInfo;

		// Token: 0x04000871 RID: 2161
		private global::System.Windows.FrameworkElement _dragElement;

		// Token: 0x04000872 RID: 2162
		private global::Infragistics.Windows.Controls.ToolWindow _dragIndicatorWindow;

		// Token: 0x04000873 RID: 2163
		private global::System.Windows.Point _dragIndicatorWindow_OffsetFromMouse;

		// Token: 0x04000874 RID: 2164
		private global::Infragistics.Windows.Controls.ToolWindow _dropIndicatorWindow;

		// Token: 0x04000875 RID: 2165
		private global::Infragistics.Windows.Internal.TileManager.LayoutItem _lastSwapTarget;

		// Token: 0x04000876 RID: 2166
		private bool _canSwapTarget;

		// Token: 0x04000877 RID: 2167
		private bool _isSwapping;

		// Token: 0x04000878 RID: 2168
		private bool _panelWasUnloaded;

		// Token: 0x04000879 RID: 2169
		private bool _dragIndicatorShown;

		// Token: 0x0400087A RID: 2170
		private global::Infragistics.Windows.Tiles.AllowTileDragging _allowTileDragging;

		// Token: 0x020001CD RID: 461
		private class DropInfo
		{
			// Token: 0x06001009 RID: 4105 RVA: 0x00035266 File Offset: 0x00033466
			internal DropInfo(global::Infragistics.Windows.Tiles.TileDragManager dragManager, bool isDragAreaInvalid)
			{
				this._isDragAreaInvalid = isDragAreaInvalid;
				this.Initialize(dragManager, global::Infragistics.Windows.Controls.DropLocation.None, null, null);
			}

			// Token: 0x0600100A RID: 4106 RVA: 0x0003527F File Offset: 0x0003347F
			internal DropInfo(global::Infragistics.Windows.Tiles.TileDragManager dragManager, global::Infragistics.Windows.Internal.TileManager.LayoutItem dropTargetItem, bool isDropNOOP) : this(dragManager, new global::Infragistics.Windows.Tiles.TileDragManager.RectInfo(dragManager, dropTargetItem.TargetRect, dragManager.Panel), global::Infragistics.Windows.Controls.DropLocation.OverTarget, isDropNOOP)
			{
				this._isDragAreaInvalid = false;
				this._isDropValid = true;
				this._dropTargetItem = dropTargetItem;
			}

			// Token: 0x0600100B RID: 4107 RVA: 0x000352B1 File Offset: 0x000334B1
			internal DropInfo(global::Infragistics.Windows.Tiles.TileDragManager dragManager, global::Infragistics.Windows.Tiles.TileDragManager.RectInfo targetRect, global::Infragistics.Windows.Controls.DropLocation dropLocation, bool isDropNOOP)
			{
				this._dragManager = dragManager;
				this._dropTargetRect = targetRect;
				this._dropLocation = dropLocation;
				this._isDropNOOP = isDropNOOP;
			}

			// Token: 0x0600100C RID: 4108 RVA: 0x000352D8 File Offset: 0x000334D8
			internal bool ApplyDrop()
			{
				this.EnsureProcessed();
				return this._dropTargetItem != null && (!this._dragManager._isSwapping || this._dragManager._canSwapTarget) && this._dragManager._tileManager.MoveTileHelper(this._dragManager._layoutItem, this._dropTargetItem, true);
			}

			// Token: 0x0600100D RID: 4109 RVA: 0x00035333 File Offset: 0x00033533
			private void EnsureProcessed()
			{
				if (!this._isProcessed)
				{
					this.ProcessHelper();
					this._isProcessed = true;
				}
			}

			// Token: 0x0600100E RID: 4110 RVA: 0x0003534C File Offset: 0x0003354C
			internal static global::Infragistics.Windows.Controls.DropIndicator GetDropIndicator(global::Infragistics.Windows.Controls.ToolWindow indicatorWindow)
			{
				global::Infragistics.Windows.Controls.DropIndicator dropIndicator = (global::Infragistics.Windows.Controls.DropIndicator)global::Infragistics.Windows.Utilities.GetDescendantFromType(indicatorWindow, typeof(global::Infragistics.Windows.Controls.DropIndicator), true);
				if (dropIndicator == null)
				{
					dropIndicator = (indicatorWindow.Content as global::Infragistics.Windows.Controls.DropIndicator);
				}
				return dropIndicator;
			}

			// Token: 0x0600100F RID: 4111 RVA: 0x00035380 File Offset: 0x00033580
			private void Initialize(global::Infragistics.Windows.Tiles.TileDragManager dragManager, global::Infragistics.Windows.Controls.DropLocation dropLocation, global::Infragistics.Windows.Internal.TileManager.LayoutItem dropTargetItem, global::Infragistics.Windows.Tiles.TileDragManager.RectInfo dropTargetRect)
			{
				this._dragManager = dragManager;
				this._dropLocation = dropLocation;
				this._dropTargetItem = dropTargetItem;
				this._dropTargetRect = dropTargetRect;
			}

			// Token: 0x06001010 RID: 4112 RVA: 0x000353A0 File Offset: 0x000335A0
			internal bool InitializeDropIndicator(global::Infragistics.Windows.Controls.ToolWindow indicatorWindow)
			{
				global::Infragistics.Windows.Controls.DropIndicator dropIndicator = global::Infragistics.Windows.Tiles.TileDragManager.DropInfo.GetDropIndicator(indicatorWindow);
				if (this._dropTargetRect == null)
				{
					return false;
				}
				global::System.Windows.Rect rectInScreen = this._dropTargetRect.GetRectInScreen();
				if (dropIndicator != null)
				{
					dropIndicator.DropLocation = new global::Infragistics.Windows.Controls.DropLocation?(this._dropLocation);
					dropIndicator.DropTargetWidth = rectInScreen.Width;
					dropIndicator.DropTargetHeight = rectInScreen.Height;
					indicatorWindow.UpdateLayout();
					global::System.Windows.UIElement descendantFromName = global::Infragistics.Windows.Utilities.GetDescendantFromName(indicatorWindow, "PART_Offset");
					if (descendantFromName != null)
					{
						global::System.Windows.Point point = descendantFromName.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), indicatorWindow);
						rectInScreen.Offset(-point.X, -point.Y);
						global::System.Windows.FlowDirection flowDirection = this._dragManager.Panel.FlowDirection;
						if ((global::Infragistics.Windows.Controls.DropLocation.RightOfTarget == this._dropLocation && flowDirection == global::System.Windows.FlowDirection.LeftToRight) || (global::Infragistics.Windows.Controls.DropLocation.LeftOfTarget == this._dropLocation && flowDirection == global::System.Windows.FlowDirection.RightToLeft))
						{
							rectInScreen.Offset(rectInScreen.Width, 0.0);
						}
						else if (global::Infragistics.Windows.Controls.DropLocation.BelowTarget == this._dropLocation)
						{
							rectInScreen.Offset(0.0, rectInScreen.Height);
						}
					}
				}
				this._dragManager.PositionToolWindow(indicatorWindow, rectInScreen.Location);
				return true;
			}

			// Token: 0x06001011 RID: 4113 RVA: 0x000354C3 File Offset: 0x000336C3
			private void ProcessHelper()
			{
			}

			// Token: 0x17000336 RID: 822
			// (get) Token: 0x06001012 RID: 4114 RVA: 0x000354C5 File Offset: 0x000336C5
			internal global::Infragistics.Windows.Internal.TileManager.LayoutItem DropTargetItem
			{
				get
				{
					return this._dropTargetItem;
				}
			}

			// Token: 0x17000337 RID: 823
			// (get) Token: 0x06001013 RID: 4115 RVA: 0x000354CD File Offset: 0x000336CD
			internal bool IsDragAreaInvalid
			{
				get
				{
					return this._isDragAreaInvalid;
				}
			}

			// Token: 0x17000338 RID: 824
			// (get) Token: 0x06001014 RID: 4116 RVA: 0x000354D5 File Offset: 0x000336D5
			internal bool IsDropNOOP
			{
				get
				{
					this.EnsureProcessed();
					return this._isDropNOOP;
				}
			}

			// Token: 0x17000339 RID: 825
			// (get) Token: 0x06001015 RID: 4117 RVA: 0x000354E3 File Offset: 0x000336E3
			internal bool IsDropValid
			{
				get
				{
					this.EnsureProcessed();
					return this._isDropValid;
				}
			}

			// Token: 0x0400087B RID: 2171
			private global::Infragistics.Windows.Tiles.TileDragManager _dragManager;

			// Token: 0x0400087C RID: 2172
			private global::Infragistics.Windows.Internal.TileManager.LayoutItem _dropTargetItem;

			// Token: 0x0400087D RID: 2173
			private global::Infragistics.Windows.Controls.DropLocation _dropLocation;

			// Token: 0x0400087E RID: 2174
			private global::Infragistics.Windows.Tiles.TileDragManager.RectInfo _dropTargetRect;

			// Token: 0x0400087F RID: 2175
			private bool _isProcessed;

			// Token: 0x04000880 RID: 2176
			private bool _isDropValid;

			// Token: 0x04000881 RID: 2177
			private bool _isDropNOOP;

			// Token: 0x04000882 RID: 2178
			private bool _isDragAreaInvalid;
		}

		// Token: 0x020001CE RID: 462
		internal class RectInfo
		{
			// Token: 0x06001016 RID: 4118 RVA: 0x000354F1 File Offset: 0x000336F1
			internal RectInfo(global::Infragistics.Windows.Tiles.TileDragManager dragManager, global::System.Windows.Rect rect, global::System.Windows.FrameworkElement relativeTo)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(dragManager);
				this._dragManager = dragManager;
				this._rect = rect;
				this._relativeTo = relativeTo;
			}

			// Token: 0x06001017 RID: 4119 RVA: 0x00035514 File Offset: 0x00033714
			internal global::System.Windows.Rect GetRectInScreen()
			{
				return this.GetRect(null);
			}

			// Token: 0x06001018 RID: 4120 RVA: 0x0003551D File Offset: 0x0003371D
			internal global::System.Windows.Rect GetRect()
			{
				return this.GetRect(this._dragManager.Panel);
			}

			// Token: 0x06001019 RID: 4121 RVA: 0x00035530 File Offset: 0x00033730
			internal global::System.Windows.Rect GetRect(global::System.Windows.UIElement relativeTo)
			{
				global::System.Windows.Point point = global::Infragistics.Windows.Tiles.TileDragManager.PointInfo.TranslatePointHelper(this._rect.TopLeft, this._relativeTo, relativeTo);
				global::System.Windows.Point point2 = global::Infragistics.Windows.Tiles.TileDragManager.PointInfo.TranslatePointHelper(this._rect.BottomRight, this._relativeTo, relativeTo);
				return global::Infragistics.Windows.Utilities.RectFromPoints(point, point2);
			}

			// Token: 0x0600101A RID: 4122 RVA: 0x00035574 File Offset: 0x00033774
			internal bool Contains(global::Infragistics.Windows.Tiles.TileDragManager.PointInfo point)
			{
				global::System.Windows.Rect rect = this.GetRect();
				global::System.Windows.Point position = point.GetPosition();
				return rect.Contains(position);
			}

			// Token: 0x04000883 RID: 2179
			private global::Infragistics.Windows.Tiles.TileDragManager _dragManager;

			// Token: 0x04000884 RID: 2180
			private global::System.Windows.Rect _rect;

			// Token: 0x04000885 RID: 2181
			private global::System.Windows.FrameworkElement _relativeTo;
		}

		// Token: 0x020001CF RID: 463
		internal class PointInfo
		{
			// Token: 0x0600101B RID: 4123 RVA: 0x00035597 File Offset: 0x00033797
			internal PointInfo(global::Infragistics.Windows.Tiles.TileDragManager dragManager, global::System.Windows.Point point, global::System.Windows.FrameworkElement relativeTo)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(dragManager);
				this._dragManager = dragManager;
				this._point = point;
				this._relativeTo = relativeTo;
			}

			// Token: 0x0600101C RID: 4124 RVA: 0x000355BA File Offset: 0x000337BA
			internal global::System.Windows.Point GetPosition()
			{
				return this.GetPosition(this._dragManager.Panel);
			}

			// Token: 0x0600101D RID: 4125 RVA: 0x000355CD File Offset: 0x000337CD
			internal global::System.Windows.Point GetPositionInScreen()
			{
				return this.GetPosition(null);
			}

			// Token: 0x0600101E RID: 4126 RVA: 0x000355D6 File Offset: 0x000337D6
			internal global::System.Windows.Point GetPosition(global::System.Windows.UIElement relativeTo)
			{
				return global::Infragistics.Windows.Tiles.TileDragManager.PointInfo.TranslatePointHelper(this._point, this._relativeTo, relativeTo);
			}

			// Token: 0x0600101F RID: 4127 RVA: 0x000355EA File Offset: 0x000337EA
			internal static global::System.Windows.Point TranslatePointHelper(global::System.Windows.Point p, global::System.Windows.UIElement currentRelativeTo, global::System.Windows.UIElement relativeTo)
			{
				if (currentRelativeTo != relativeTo)
				{
					if (relativeTo == null)
					{
						p = global::Infragistics.Windows.Utilities.PointToScreenSafe(currentRelativeTo, p);
					}
					else if (currentRelativeTo != null)
					{
						p = currentRelativeTo.TranslatePoint(p, relativeTo);
					}
					else
					{
						p = global::Infragistics.Windows.Utilities.PointFromScreenSafe(relativeTo, p);
					}
				}
				return p;
			}

			// Token: 0x06001020 RID: 4128 RVA: 0x00035617 File Offset: 0x00033817
			internal bool IsInsideTilesPanel()
			{
				return global::Infragistics.Windows.Utilities.DoesElementContainPoint(this._dragManager.Panel, this.GetPosition());
			}

			// Token: 0x04000886 RID: 2182
			private global::Infragistics.Windows.Tiles.TileDragManager _dragManager;

			// Token: 0x04000887 RID: 2183
			private global::System.Windows.Point _point;

			// Token: 0x04000888 RID: 2184
			private global::System.Windows.FrameworkElement _relativeTo;
		}
	}
}
