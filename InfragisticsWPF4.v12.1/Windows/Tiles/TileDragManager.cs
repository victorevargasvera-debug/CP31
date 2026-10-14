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
	// Token: 0x0200019F RID: 415
	internal class TileDragManager
	{
		// Token: 0x06000E37 RID: 3639 RVA: 0x0002F614 File Offset: 0x0002D814
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

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x0002F678 File Offset: 0x0002D878
		internal global::Infragistics.Windows.Tiles.TilesPanelBase Panel
		{
			get
			{
				return this._panel;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x0002F680 File Offset: 0x0002D880
		internal bool PanelWasUnloaded
		{
			get
			{
				return this._panelWasUnloaded;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x0002F688 File Offset: 0x0002D888
		internal global::Infragistics.Windows.Internal.TileManager TileManager
		{
			get
			{
				return this._tileManager;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x0002F690 File Offset: 0x0002D890
		internal global::System.Windows.FrameworkElement Tile
		{
			get
			{
				return this._tile;
			}
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0002F698 File Offset: 0x0002D898
		internal global::Infragistics.Windows.Tiles.TileDragManager.RectInfo GetLayoutAreaRect()
		{
			global::Infragistics.Windows.Tiles.TilesPanelBase panel = this.Panel;
			global::System.Windows.Rect rect = new global::System.Windows.Rect(panel.TileAreaSize);
			global::System.Windows.Thickness tileAreaPadding = panel.GetTileAreaPadding();
			rect.Offset(new global::System.Windows.Vector(tileAreaPadding.Left, tileAreaPadding.Top));
			return new global::Infragistics.Windows.Tiles.TileDragManager.RectInfo(this, rect, panel);
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x0002F6E4 File Offset: 0x0002D8E4
		private global::Infragistics.Windows.Selection.ScrollSpeed CalcScrollSpeed(double distance)
		{
			double num = 200.0;
			int val = 0;
			int num2 = 6;
			return (global::Infragistics.Windows.Selection.ScrollSpeed)global::System.Math.Max(val, global::System.Math.Min(num2, (int)((double)num2 * (distance / num))));
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0002F714 File Offset: 0x0002D914
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

		// Token: 0x06000E3F RID: 3647 RVA: 0x0002F888 File Offset: 0x0002DA88
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

		// Token: 0x06000E40 RID: 3648 RVA: 0x0002F9C2 File Offset: 0x0002DBC2
		internal void HideDragIndicator()
		{
			if (this._dragIndicatorWindow != null)
			{
				this._dragIndicatorWindow.Close();
				this._dragIndicatorShown = false;
			}
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0002F9E0 File Offset: 0x0002DBE0
		internal void OnDragEnd(global::System.Windows.Input.MouseEventArgs mouseEventArgs, bool cancel)
		{
			this._panel.Unloaded -= this.OnPanelUnloaded;
			this.SetSwapTarget(null);
			this.OnDragEndHelper(mouseEventArgs, cancel);
			this._panel.OnEndDrag(this._tile);
			this._panel.InvalidateMeasure();
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0002FA30 File Offset: 0x0002DC30
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

		// Token: 0x06000E43 RID: 3651 RVA: 0x0002FAAC File Offset: 0x0002DCAC
		internal void OnMouseMove(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			if (this._panelWasUnloaded)
			{
				return;
			}
			global::Infragistics.Windows.Tiles.TileDragManager.PointInfo mouseLoc = new global::Infragistics.Windows.Tiles.TileDragManager.PointInfo(this, mouseEventArgs.GetPosition(this._panel), this._panel);
			this.DragHelper(mouseLoc, false);
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0002FAE3 File Offset: 0x0002DCE3
		private void OnPanelUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this._panelWasUnloaded = true;
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0002FAEC File Offset: 0x0002DCEC
		private void PositionToolWindow(global::Infragistics.Windows.Controls.ToolWindow toolWindow, global::System.Windows.Point screenPoint)
		{
			global::System.Windows.Point relativePoint = global::Infragistics.Windows.Utilities.PointFromScreenSafe(this._panel, screenPoint);
			global::System.Windows.FrameworkElement owner = toolWindow.Owner ?? this._panel;
			relativePoint = global::Infragistics.Windows.Controls.ToolWindow.GetScreenPoint(owner, relativePoint, this._panel);
			toolWindow.Left = relativePoint.X;
			toolWindow.Top = relativePoint.Y;
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0002FB40 File Offset: 0x0002DD40
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

		// Token: 0x06000E47 RID: 3655 RVA: 0x0002FBFC File Offset: 0x0002DDFC
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

		// Token: 0x06000E48 RID: 3656 RVA: 0x0002FDD0 File Offset: 0x0002DFD0
		internal void StartDrag(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			global::Infragistics.Windows.Tiles.TileDragManager.PointInfo mouseLoc = new global::Infragistics.Windows.Tiles.TileDragManager.PointInfo(this, mouseEventArgs.GetPosition(this._panel), this._panel);
			this.DragHelper(mouseLoc, false);
		}

		// Token: 0x04000730 RID: 1840
		private global::Infragistics.Windows.Internal.TileManager _tileManager;

		// Token: 0x04000731 RID: 1841
		private global::Infragistics.Windows.Internal.TileManager.LayoutItem _layoutItem;

		// Token: 0x04000732 RID: 1842
		private global::Infragistics.Windows.Tiles.TilesPanelBase _panel;

		// Token: 0x04000733 RID: 1843
		private global::System.Windows.FrameworkElement _tile;

		// Token: 0x04000734 RID: 1844
		private global::Infragistics.Windows.Tiles.ItemInfoBase _itemInfo;

		// Token: 0x04000735 RID: 1845
		private global::System.Windows.FrameworkElement _dragElement;

		// Token: 0x04000736 RID: 1846
		private global::Infragistics.Windows.Controls.ToolWindow _dragIndicatorWindow;

		// Token: 0x04000737 RID: 1847
		private global::System.Windows.Point _dragIndicatorWindow_OffsetFromMouse;

		// Token: 0x04000738 RID: 1848
		private global::Infragistics.Windows.Controls.ToolWindow _dropIndicatorWindow;

		// Token: 0x04000739 RID: 1849
		private global::Infragistics.Windows.Internal.TileManager.LayoutItem _lastSwapTarget;

		// Token: 0x0400073A RID: 1850
		private bool _canSwapTarget;

		// Token: 0x0400073B RID: 1851
		private bool _isSwapping;

		// Token: 0x0400073C RID: 1852
		private bool _panelWasUnloaded;

		// Token: 0x0400073D RID: 1853
		private bool _dragIndicatorShown;

		// Token: 0x0400073E RID: 1854
		private global::Infragistics.Windows.Tiles.AllowTileDragging _allowTileDragging;

		// Token: 0x020001A0 RID: 416
		private class DropInfo
		{
			// Token: 0x06000E49 RID: 3657 RVA: 0x0002FDFE File Offset: 0x0002DFFE
			internal DropInfo(global::Infragistics.Windows.Tiles.TileDragManager dragManager, bool isDragAreaInvalid)
			{
				this._isDragAreaInvalid = isDragAreaInvalid;
				this.Initialize(dragManager, global::Infragistics.Windows.Controls.DropLocation.None, null, null);
			}

			// Token: 0x06000E4A RID: 3658 RVA: 0x0002FE17 File Offset: 0x0002E017
			internal DropInfo(global::Infragistics.Windows.Tiles.TileDragManager dragManager, global::Infragistics.Windows.Internal.TileManager.LayoutItem dropTargetItem, bool isDropNOOP) : this(dragManager, new global::Infragistics.Windows.Tiles.TileDragManager.RectInfo(dragManager, dropTargetItem.TargetRect, dragManager.Panel), global::Infragistics.Windows.Controls.DropLocation.OverTarget, isDropNOOP)
			{
				this._isDragAreaInvalid = false;
				this._isDropValid = true;
				this._dropTargetItem = dropTargetItem;
			}

			// Token: 0x06000E4B RID: 3659 RVA: 0x0002FE49 File Offset: 0x0002E049
			internal DropInfo(global::Infragistics.Windows.Tiles.TileDragManager dragManager, global::Infragistics.Windows.Tiles.TileDragManager.RectInfo targetRect, global::Infragistics.Windows.Controls.DropLocation dropLocation, bool isDropNOOP)
			{
				this._dragManager = dragManager;
				this._dropTargetRect = targetRect;
				this._dropLocation = dropLocation;
				this._isDropNOOP = isDropNOOP;
			}

			// Token: 0x06000E4C RID: 3660 RVA: 0x0002FE70 File Offset: 0x0002E070
			internal bool ApplyDrop()
			{
				this.EnsureProcessed();
				return this._dropTargetItem != null && (!this._dragManager._isSwapping || this._dragManager._canSwapTarget) && this._dragManager._tileManager.MoveTileHelper(this._dragManager._layoutItem, this._dropTargetItem, true);
			}

			// Token: 0x06000E4D RID: 3661 RVA: 0x0002FECB File Offset: 0x0002E0CB
			private void EnsureProcessed()
			{
				if (!this._isProcessed)
				{
					this.ProcessHelper();
					this._isProcessed = true;
				}
			}

			// Token: 0x06000E4E RID: 3662 RVA: 0x0002FEE4 File Offset: 0x0002E0E4
			internal static global::Infragistics.Windows.Controls.DropIndicator GetDropIndicator(global::Infragistics.Windows.Controls.ToolWindow indicatorWindow)
			{
				global::Infragistics.Windows.Controls.DropIndicator dropIndicator = (global::Infragistics.Windows.Controls.DropIndicator)global::Infragistics.Windows.Utilities.GetDescendantFromType(indicatorWindow, typeof(global::Infragistics.Windows.Controls.DropIndicator), true);
				if (dropIndicator == null)
				{
					dropIndicator = (indicatorWindow.Content as global::Infragistics.Windows.Controls.DropIndicator);
				}
				return dropIndicator;
			}

			// Token: 0x06000E4F RID: 3663 RVA: 0x0002FF18 File Offset: 0x0002E118
			private void Initialize(global::Infragistics.Windows.Tiles.TileDragManager dragManager, global::Infragistics.Windows.Controls.DropLocation dropLocation, global::Infragistics.Windows.Internal.TileManager.LayoutItem dropTargetItem, global::Infragistics.Windows.Tiles.TileDragManager.RectInfo dropTargetRect)
			{
				this._dragManager = dragManager;
				this._dropLocation = dropLocation;
				this._dropTargetItem = dropTargetItem;
				this._dropTargetRect = dropTargetRect;
			}

			// Token: 0x06000E50 RID: 3664 RVA: 0x0002FF38 File Offset: 0x0002E138
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

			// Token: 0x06000E51 RID: 3665 RVA: 0x0003005B File Offset: 0x0002E25B
			private void ProcessHelper()
			{
			}

			// Token: 0x170002C7 RID: 711
			// (get) Token: 0x06000E52 RID: 3666 RVA: 0x0003005D File Offset: 0x0002E25D
			internal global::Infragistics.Windows.Internal.TileManager.LayoutItem DropTargetItem
			{
				get
				{
					return this._dropTargetItem;
				}
			}

			// Token: 0x170002C8 RID: 712
			// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00030065 File Offset: 0x0002E265
			internal bool IsDragAreaInvalid
			{
				get
				{
					return this._isDragAreaInvalid;
				}
			}

			// Token: 0x170002C9 RID: 713
			// (get) Token: 0x06000E54 RID: 3668 RVA: 0x0003006D File Offset: 0x0002E26D
			internal bool IsDropNOOP
			{
				get
				{
					this.EnsureProcessed();
					return this._isDropNOOP;
				}
			}

			// Token: 0x170002CA RID: 714
			// (get) Token: 0x06000E55 RID: 3669 RVA: 0x0003007B File Offset: 0x0002E27B
			internal bool IsDropValid
			{
				get
				{
					this.EnsureProcessed();
					return this._isDropValid;
				}
			}

			// Token: 0x0400073F RID: 1855
			private global::Infragistics.Windows.Tiles.TileDragManager _dragManager;

			// Token: 0x04000740 RID: 1856
			private global::Infragistics.Windows.Internal.TileManager.LayoutItem _dropTargetItem;

			// Token: 0x04000741 RID: 1857
			private global::Infragistics.Windows.Controls.DropLocation _dropLocation;

			// Token: 0x04000742 RID: 1858
			private global::Infragistics.Windows.Tiles.TileDragManager.RectInfo _dropTargetRect;

			// Token: 0x04000743 RID: 1859
			private bool _isProcessed;

			// Token: 0x04000744 RID: 1860
			private bool _isDropValid;

			// Token: 0x04000745 RID: 1861
			private bool _isDropNOOP;

			// Token: 0x04000746 RID: 1862
			private bool _isDragAreaInvalid;
		}

		// Token: 0x020001A1 RID: 417
		internal class RectInfo
		{
			// Token: 0x06000E56 RID: 3670 RVA: 0x00030089 File Offset: 0x0002E289
			internal RectInfo(global::Infragistics.Windows.Tiles.TileDragManager dragManager, global::System.Windows.Rect rect, global::System.Windows.FrameworkElement relativeTo)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(dragManager);
				this._dragManager = dragManager;
				this._rect = rect;
				this._relativeTo = relativeTo;
			}

			// Token: 0x06000E57 RID: 3671 RVA: 0x000300AC File Offset: 0x0002E2AC
			internal global::System.Windows.Rect GetRectInScreen()
			{
				return this.GetRect(null);
			}

			// Token: 0x06000E58 RID: 3672 RVA: 0x000300B5 File Offset: 0x0002E2B5
			internal global::System.Windows.Rect GetRect()
			{
				return this.GetRect(this._dragManager.Panel);
			}

			// Token: 0x06000E59 RID: 3673 RVA: 0x000300C8 File Offset: 0x0002E2C8
			internal global::System.Windows.Rect GetRect(global::System.Windows.UIElement relativeTo)
			{
				global::System.Windows.Point point = global::Infragistics.Windows.Tiles.TileDragManager.PointInfo.TranslatePointHelper(this._rect.TopLeft, this._relativeTo, relativeTo);
				global::System.Windows.Point point2 = global::Infragistics.Windows.Tiles.TileDragManager.PointInfo.TranslatePointHelper(this._rect.BottomRight, this._relativeTo, relativeTo);
				return global::Infragistics.Windows.Utilities.RectFromPoints(point, point2);
			}

			// Token: 0x06000E5A RID: 3674 RVA: 0x0003010C File Offset: 0x0002E30C
			internal bool Contains(global::Infragistics.Windows.Tiles.TileDragManager.PointInfo point)
			{
				global::System.Windows.Rect rect = this.GetRect();
				global::System.Windows.Point position = point.GetPosition();
				return rect.Contains(position);
			}

			// Token: 0x04000747 RID: 1863
			private global::Infragistics.Windows.Tiles.TileDragManager _dragManager;

			// Token: 0x04000748 RID: 1864
			private global::System.Windows.Rect _rect;

			// Token: 0x04000749 RID: 1865
			private global::System.Windows.FrameworkElement _relativeTo;
		}

		// Token: 0x020001A2 RID: 418
		internal class PointInfo
		{
			// Token: 0x06000E5B RID: 3675 RVA: 0x0003012F File Offset: 0x0002E32F
			internal PointInfo(global::Infragistics.Windows.Tiles.TileDragManager dragManager, global::System.Windows.Point point, global::System.Windows.FrameworkElement relativeTo)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(dragManager);
				this._dragManager = dragManager;
				this._point = point;
				this._relativeTo = relativeTo;
			}

			// Token: 0x06000E5C RID: 3676 RVA: 0x00030152 File Offset: 0x0002E352
			internal global::System.Windows.Point GetPosition()
			{
				return this.GetPosition(this._dragManager.Panel);
			}

			// Token: 0x06000E5D RID: 3677 RVA: 0x00030165 File Offset: 0x0002E365
			internal global::System.Windows.Point GetPositionInScreen()
			{
				return this.GetPosition(null);
			}

			// Token: 0x06000E5E RID: 3678 RVA: 0x0003016E File Offset: 0x0002E36E
			internal global::System.Windows.Point GetPosition(global::System.Windows.UIElement relativeTo)
			{
				return global::Infragistics.Windows.Tiles.TileDragManager.PointInfo.TranslatePointHelper(this._point, this._relativeTo, relativeTo);
			}

			// Token: 0x06000E5F RID: 3679 RVA: 0x00030182 File Offset: 0x0002E382
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

			// Token: 0x06000E60 RID: 3680 RVA: 0x000301AF File Offset: 0x0002E3AF
			internal bool IsInsideTilesPanel()
			{
				return global::Infragistics.Windows.Utilities.DoesElementContainPoint(this._dragManager.Panel, this.GetPosition());
			}

			// Token: 0x0400074A RID: 1866
			private global::Infragistics.Windows.Tiles.TileDragManager _dragManager;

			// Token: 0x0400074B RID: 1867
			private global::System.Windows.Point _point;

			// Token: 0x0400074C RID: 1868
			private global::System.Windows.FrameworkElement _relativeTo;
		}
	}
}
