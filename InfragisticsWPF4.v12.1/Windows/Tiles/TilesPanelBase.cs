using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Controls.Layouts.Primitives;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Scrolling;
using Infragistics.Windows.Selection;
using Infragistics.Windows.Virtualization;

namespace Infragistics.Windows.Tiles
{
	// Token: 0x020001BD RID: 445
	public abstract class TilesPanelBase : global::Infragistics.Windows.Virtualization.RecyclingItemsPanel, global::System.Windows.Controls.Primitives.IScrollInfo, global::Infragistics.Windows.Scrolling.IDeferredScrollPanel
	{
		// Token: 0x06000FF3 RID: 4083 RVA: 0x00039AA0 File Offset: 0x00037CA0
		protected TilesPanelBase() : base(true)
		{
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00039B00 File Offset: 0x00037D00
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this._bypassArrange)
			{
				this._arrangeCount = 0;
				this._measureCount = 0;
				this._bypassArrange = false;
				return finalSize;
			}
			bool flag = false;
			this._ignoreChildSizeChanges = true;
			if ((finalSize.Height > this._lastMeasureSize.Height && finalSize.Width > this._lastMeasureSize.Width) || (finalSize.Height > this._lastMeasureSize.Height && finalSize.Width > this._lastMeasureSize.Width))
			{
				if (finalSize != this._lastMeasureSizeAdjusted)
				{
					this._lastMeasureSizeAdjusted = finalSize;
					this.MeasureHelper(finalSize);
				}
			}
			else
			{
				this._lastMeasureSizeAdjusted = global::System.Windows.Size.Empty;
			}
			this._arrangeCount++;
			try
			{
				global::Infragistics.Windows.Internal.TileManager manager = this.GetManager();
				if (this._bypassArrangeVerification)
				{
					this._bypassArrangeVerification = false;
				}
				else
				{
					manager.VerifyArrangeSize();
					if (!base.IsMeasureValid)
					{
						this._bypassArrangeVerification = true;
						return finalSize;
					}
				}
				bool flag2;
				manager.OnArrange(out flag, out flag2);
				if (!flag2)
				{
					this._inViewItemsHaveChanged = true;
				}
			}
			finally
			{
				this._ignoreChildSizeChanges = false;
			}
			this._lastArrangeSize = finalSize;
			bool bypassAnimations = false;
			bool flag3 = this.ArrangeHelper(true, false, bypassAnimations);
			if (flag3)
			{
				if (!this.IsAnimationInProgress || this._repositionFactor > 0.5)
				{
					if (this._asynchAnimationStart == null)
					{
						this._asynchAnimationStart = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.Utilities.MethodDelegate(this.ProcessAnimationRestart));
					}
					else
					{
						this.ProcessAnimationRestart();
					}
				}
			}
			else if (!this.IsAnimationInProgress)
			{
				this.OnArrangeComplete();
			}
			return finalSize;
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00039C94 File Offset: 0x00037E94
		protected override void BringIndexIntoView(int index)
		{
			this.GetManager().BringIndexIntoView(index);
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00039CA4 File Offset: 0x00037EA4
		protected override global::System.Windows.Controls.UIElementCollection CreateUIElementCollection(global::System.Windows.FrameworkElement logicalParent)
		{
			global::Infragistics.Windows.Tiles.TilesPanelBase.TilesPanelUIElementCollection tilesPanelUIElementCollection = new global::Infragistics.Windows.Tiles.TilesPanelBase.TilesPanelUIElementCollection(this, this, logicalParent);
			tilesPanelUIElementCollection.CollectionChanged += this.OnCollectionChanged;
			return tilesPanelUIElementCollection;
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00039CCD File Offset: 0x00037ECD
		protected override bool GetCanCleanupItem(int itemIndex)
		{
			return !this.IsAnimationInProgress && this.GetCanCleanupItemHelper(itemIndex) && (itemIndex == 0 || this.GetCanCleanupItemHelper(itemIndex - 1));
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00039CF4 File Offset: 0x00037EF4
		private bool GetCanCleanupItemHelper(int itemIndex)
		{
			global::Infragistics.Windows.Internal.TileManager manager = this.GetManager();
			global::System.Collections.IList items = manager.Items;
			if (items == null)
			{
				return false;
			}
			if (itemIndex < 0 || itemIndex >= items.Count)
			{
				return false;
			}
			object obj = items[itemIndex];
			global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = manager.GetItemInfo(obj);
			if (itemInfo == null || itemInfo.GetIsMaximized())
			{
				return false;
			}
			global::System.Windows.FrameworkElement frameworkElement = base.ContainerFromIndex(itemIndex) as global::System.Windows.FrameworkElement;
			return obj != frameworkElement && (frameworkElement == null || (!frameworkElement.IsFocused && !frameworkElement.IsKeyboardFocusWithin && !frameworkElement.IsMouseCaptureWithin)) && !manager.IsContainerInArrangeCache(frameworkElement);
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00039D84 File Offset: 0x00037F84
		protected override global::System.Windows.Media.Geometry GetLayoutClip(global::System.Windows.Size layoutSlotSize)
		{
			global::System.Windows.Thickness tileAreaPadding = this.GetTileAreaPadding();
			if (tileAreaPadding.Bottom == 0.0 && tileAreaPadding.Top == 0.0 && tileAreaPadding.Left == 0.0 && tileAreaPadding.Right == 0.0)
			{
				this._tileAreaSize = layoutSlotSize;
				return base.GetLayoutClip(layoutSlotSize);
			}
			global::System.Windows.Rect rect = new global::System.Windows.Rect(layoutSlotSize);
			rect.X = tileAreaPadding.Left;
			rect.Y = tileAreaPadding.Top;
			rect.Width = global::System.Math.Max(rect.Width - (tileAreaPadding.Left + tileAreaPadding.Right), 0.0);
			rect.Height = global::System.Math.Max(rect.Height - (tileAreaPadding.Top + tileAreaPadding.Bottom), 0.0);
			this._tileAreaSize = rect.Size;
			global::System.Windows.Media.Geometry geometry = new global::System.Windows.Media.RectangleGeometry(rect);
			geometry.Freeze();
			return geometry;
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x00039E86 File Offset: 0x00038086
		protected override bool HasLogicalOrientation
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x00039E89 File Offset: 0x00038089
		protected override bool IsOkToCleanupUnusedGeneratedElements
		{
			get
			{
				return !this.IsAnimationInProgress && this._dragManager == null;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00039EA0 File Offset: 0x000380A0
		protected override global::System.Windows.Controls.Orientation LogicalOrientation
		{
			get
			{
				if (this.GetIsInMaximizedMode())
				{
					switch (this.GetMaximizedTileLocation())
					{
					case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Left:
					case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Right:
						return global::System.Windows.Controls.Orientation.Vertical;
					default:
						return global::System.Windows.Controls.Orientation.Horizontal;
					}
				}
				else
				{
					switch (this.GetTileLayoutOrder())
					{
					case global::Infragistics.Windows.Tiles.TileLayoutOrder.Horizontal:
					case global::Infragistics.Windows.Tiles.TileLayoutOrder.HorizontalVariable:
						return global::System.Windows.Controls.Orientation.Horizontal;
					default:
						return global::System.Windows.Controls.Orientation.Vertical;
					}
				}
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x00039EEE File Offset: 0x000380EE
		protected override int MaximumUnusedGeneratedItemsToKeep
		{
			get
			{
				return global::System.Math.Min(this.GetManager().CountOfItemsToBeArranged, 100);
			}
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00039F02 File Offset: 0x00038102
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			this._lastMeasureSize = availableSize;
			this._lastDesiredSize = this.MeasureHelper(availableSize);
			return this._lastDesiredSize;
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00039F20 File Offset: 0x00038120
		private global::System.Windows.Size MeasureHelper(global::System.Windows.Size availableSize)
		{
			this._tileAreaSize = availableSize;
			this._measureCount++;
			global::System.Windows.Controls.ItemsControl itemsControl = null;
			if (base.IsItemsHost)
			{
				itemsControl = global::System.Windows.Controls.ItemsControl.GetItemsOwner(this);
			}
			bool flag = false;
			if (itemsControl != null)
			{
				global::System.Windows.Size renderSize = itemsControl.RenderSize;
				if (renderSize != this._itemsControlLastRenderSize)
				{
					flag = true;
					this._itemsControlLastRenderSize = renderSize;
				}
			}
			if (!flag && global::System.DateTime.Now.Subtract(this._lastMeasureTimeStamp).TotalSeconds > 0.1)
			{
				flag = true;
			}
			if (!flag)
			{
				global::Infragistics.Windows.Tiles.TilesPanelBase.ScrollData scrollDataInfo = this.ScrollDataInfo;
				if (scrollDataInfo._offset != this._lastScrollOffset)
				{
					flag = true;
					this._lastScrollOffset = scrollDataInfo._offset;
				}
			}
			if (flag)
			{
				this._arrangeCount = 0;
				this._measureCount = 0;
				this._bypassArrange = false;
			}
			else if (this._arrangeCount > 20 && this._measureCount > 20)
			{
				this._bypassArrange = true;
			}
			this._lastMeasureTimeStamp = global::System.DateTime.Now;
			global::System.Windows.Thickness tileAreaPadding = this.GetTileAreaPadding();
			if ((tileAreaPadding.Bottom != 0.0 || tileAreaPadding.Top != 0.0) && !double.IsPositiveInfinity(this._tileAreaSize.Height))
			{
				this._tileAreaSize.Height = global::System.Math.Max(1.0, this._tileAreaSize.Height - (tileAreaPadding.Bottom + tileAreaPadding.Top));
			}
			if ((tileAreaPadding.Left != 0.0 || tileAreaPadding.Right != 0.0) && !double.IsPositiveInfinity(this._tileAreaSize.Width))
			{
				this._tileAreaSize.Width = global::System.Math.Max(1.0, this._tileAreaSize.Width - (tileAreaPadding.Left + tileAreaPadding.Right));
			}
			global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache generationCache = null;
			bool flag2 = true;
			while (flag2)
			{
				bool isInMaximizedMode = this.GetIsInMaximizedMode();
				global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache generationCache2;
				generationCache = (generationCache2 = new global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache(this, availableSize));
				try
				{
					generationCache.GenerateElements();
				}
				finally
				{
					if (generationCache2 != null)
					{
						((global::System.IDisposable)generationCache2).Dispose();
					}
				}
				flag2 = (generationCache._requiresAnotherLayoutPass || isInMaximizedMode != this.GetIsInMaximizedMode());
			}
			global::System.Windows.Size desiredSize = generationCache._desiredSize;
			if ((tileAreaPadding.Bottom != 0.0 || tileAreaPadding.Top != 0.0) && !double.IsPositiveInfinity(desiredSize.Height))
			{
				desiredSize.Height = global::System.Math.Max(1.0, desiredSize.Height - (tileAreaPadding.Bottom + tileAreaPadding.Top));
			}
			if ((tileAreaPadding.Left != 0.0 || tileAreaPadding.Right != 0.0) && !double.IsPositiveInfinity(desiredSize.Width))
			{
				desiredSize.Width = global::System.Math.Max(1.0, desiredSize.Width - (tileAreaPadding.Left + tileAreaPadding.Right));
			}
			return desiredSize;
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0003A214 File Offset: 0x00038414
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			if (this._ignoreChildSizeChanges)
			{
				this._childSizeChanged = true;
				return;
			}
			base.OnChildDesiredSizeChanged(child);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0003A22D File Offset: 0x0003842D
		protected override void OnItemsChanged(object sender, global::System.Windows.Controls.Primitives.ItemsChangedEventArgs args)
		{
			base.OnItemsChanged(sender, args);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0003A237 File Offset: 0x00038437
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnLostMouseCapture(e);
			if (this._dragManager != null)
			{
				this._dragManager.OnDragEnd(e, true);
				this._dragManager = null;
				e.Handled = true;
			}
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0003A264 File Offset: 0x00038464
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this._dragManager == null)
			{
				base.OnMouseLeftButtonUp(e);
				return;
			}
			global::Infragistics.Windows.Tiles.TileDragManager dragManager = this._dragManager;
			this._dragManager = null;
			base.ReleaseMouseCapture();
			dragManager.OnDragEnd(e, false);
			e.Handled = true;
			base.InvalidateArrange();
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0003A2AA File Offset: 0x000384AA
		internal void OnEndDrag(global::System.Windows.FrameworkElement container)
		{
			container.ClearValue(global::Infragistics.Windows.Tiles.TilesPanelBase.IsDraggingPropertyKey);
			this.OnTileDragEnd(container);
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0003A2BE File Offset: 0x000384BE
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._dragManager == null)
			{
				base.OnMouseMove(e);
				return;
			}
			this._dragManager.OnMouseMove(e);
			e.Handled = true;
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0003A2E3 File Offset: 0x000384E3
		protected override void OnNewElementRealized(global::System.Windows.UIElement element, int index)
		{
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0003A2E5 File Offset: 0x000384E5
		protected override void OnVisualChildrenChanged(global::System.Windows.DependencyObject visualAdded, global::System.Windows.DependencyObject visualRemoved)
		{
			base.OnVisualChildrenChanged(visualAdded, visualRemoved);
			if (visualRemoved != null)
			{
				this.GetManager().RemoveContainer(visualRemoved);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x0003A2FE File Offset: 0x000384FE
		protected override int TotalVisibleGeneratedItems
		{
			get
			{
				if (!base.IsItemsHost)
				{
					return 0;
				}
				return this.GetManager().CountOfItemsToBeArranged;
			}
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0003A315 File Offset: 0x00038515
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static int GetColumn(global::System.Windows.DependencyObject elem)
		{
			return (int)elem.GetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.ColumnProperty);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0003A327 File Offset: 0x00038527
		public static void SetColumn(global::System.Windows.DependencyObject elem, int value)
		{
			elem.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.ColumnProperty, value);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0003A33A File Offset: 0x0003853A
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static int GetColumnSpan(global::System.Windows.DependencyObject elem)
		{
			return (int)elem.GetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.ColumnSpanProperty);
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0003A34C File Offset: 0x0003854C
		public static void SetColumnSpan(global::System.Windows.DependencyObject elem, int value)
		{
			elem.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.ColumnSpanProperty, value);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0003A35F File Offset: 0x0003855F
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static float GetColumnWeight(global::System.Windows.DependencyObject d)
		{
			return (float)d.GetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.ColumnWeightProperty);
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0003A371 File Offset: 0x00038571
		public static void SetColumnWeight(global::System.Windows.DependencyObject d, float value)
		{
			d.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.ColumnWeightProperty, value);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0003A384 File Offset: 0x00038584
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static bool GetIsDragging(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.IsDraggingProperty);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0003A396 File Offset: 0x00038596
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static bool GetIsSwapTarget(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.IsSwapTargetProperty);
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0003A3A8 File Offset: 0x000385A8
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static int GetRow(global::System.Windows.DependencyObject elem)
		{
			return (int)elem.GetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.RowProperty);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0003A3BA File Offset: 0x000385BA
		public static void SetRow(global::System.Windows.DependencyObject elem, int value)
		{
			elem.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.RowProperty, value);
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0003A3CD File Offset: 0x000385CD
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static int GetRowSpan(global::System.Windows.DependencyObject elem)
		{
			return (int)elem.GetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.RowSpanProperty);
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0003A3DF File Offset: 0x000385DF
		public static void SetRowSpan(global::System.Windows.DependencyObject elem, int value)
		{
			elem.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.RowSpanProperty, value);
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0003A3F2 File Offset: 0x000385F2
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static float GetRowWeight(global::System.Windows.DependencyObject d)
		{
			return (float)d.GetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.RowWeightProperty);
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x0003A404 File Offset: 0x00038604
		public static void SetRowWeight(global::System.Windows.DependencyObject d, float value)
		{
			d.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.RowWeightProperty, value);
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x0003A417 File Offset: 0x00038617
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsAnimationInProgress
		{
			get
			{
				return this._activeAnimationCount > 0;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x0003A422 File Offset: 0x00038622
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x0003A42F File Offset: 0x0003862F
		protected int ScrollPosition
		{
			get
			{
				return this.GetManager().ScrollPosition;
			}
			set
			{
				this.GetManager().ScrollPosition = value;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x0003A43D File Offset: 0x0003863D
		protected int ScrollIndexOfFirstArrangedItem
		{
			get
			{
				return this.GetManager().ScrollIndexOfFirstArrangedItem;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x0003A44A File Offset: 0x0003864A
		protected int ScrollIndexOfLastArrangedItem
		{
			get
			{
				return this.GetManager().ScrollIndexOfLastArrangedItem;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x0003A457 File Offset: 0x00038657
		internal global::System.Windows.Size LastMeasureSize
		{
			get
			{
				return this._lastMeasureSize;
			}
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x0003A460 File Offset: 0x00038660
		private static void OnRepositionFactorChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Tiles.TilesPanelBase tilesPanelBase = target as global::Infragistics.Windows.Tiles.TilesPanelBase;
			tilesPanelBase._repositionFactor = (double)e.NewValue;
			if (tilesPanelBase._repositionClock != null && tilesPanelBase._repositionClock.CurrentState != global::System.Windows.Media.Animation.ClockState.Active)
			{
				return;
			}
			tilesPanelBase.OnFactorChanged();
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x0003A4A2 File Offset: 0x000386A2
		// (set) Token: 0x0600101F RID: 4127 RVA: 0x0003A4AA File Offset: 0x000386AA
		internal double RepositionFactor
		{
			get
			{
				return this._repositionFactor;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.RepositionFactorProperty, value);
			}
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0003A4C0 File Offset: 0x000386C0
		private static void OnResizeFactorChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Tiles.TilesPanelBase tilesPanelBase = target as global::Infragistics.Windows.Tiles.TilesPanelBase;
			tilesPanelBase._resizeFactor = (double)e.NewValue;
			if (tilesPanelBase._resizeClock != null && tilesPanelBase._resizeClock.CurrentState != global::System.Windows.Media.Animation.ClockState.Active)
			{
				return;
			}
			tilesPanelBase.OnFactorChanged();
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x0003A502 File Offset: 0x00038702
		// (set) Token: 0x06001022 RID: 4130 RVA: 0x0003A50A File Offset: 0x0003870A
		internal double ResizeFactor
		{
			get
			{
				return this._resizeFactor;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.ResizeFactorProperty, value);
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x0003A51D File Offset: 0x0003871D
		internal global::Infragistics.Windows.Tiles.TilesPanelBase.ScrollData ScrollDataInfo
		{
			get
			{
				if (this._scrollDataInfo == null)
				{
					this._scrollDataInfo = new global::Infragistics.Windows.Tiles.TilesPanelBase.ScrollData(this);
				}
				return this._scrollDataInfo;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x0003A539 File Offset: 0x00038739
		internal global::System.Windows.Size TileAreaSize
		{
			get
			{
				return this._tileAreaSize;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x0003A541 File Offset: 0x00038741
		private bool IsScrollClient
		{
			get
			{
				return this._scrollDataInfo != null && this._scrollDataInfo._scrollOwner != null;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x0003A560 File Offset: 0x00038760
		internal double MaxHorizontalOffset
		{
			get
			{
				return this.GetManager().ScrollMaxOffset.X;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x0003A580 File Offset: 0x00038780
		internal double MaxVerticalOffset
		{
			get
			{
				return this.GetManager().ScrollMaxOffset.Y;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x0003A5A0 File Offset: 0x000387A0
		private global::System.Windows.Controls.Orientation ScrollBarOrientation
		{
			get
			{
				if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					return global::System.Windows.Controls.Orientation.Vertical;
				}
				return global::System.Windows.Controls.Orientation.Horizontal;
			}
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0003A5AD File Offset: 0x000387AD
		public global::System.Windows.Rect GetInViewRect(global::System.Windows.DependencyObject container)
		{
			return this.GetManager().GetInViewRect(container);
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0003A5BC File Offset: 0x000387BC
		internal int FindSlotForNewlyRealizedRecordPresenter(int newItemIndex)
		{
			global::System.Collections.IList childElements = base.ChildElements;
			int count = childElements.Count;
			if (count == 0)
			{
				return 0;
			}
			global::System.Windows.Controls.Primitives.IItemContainerGenerator generator = this.GetGenerator();
			for (int i = 0; i < count; i++)
			{
				int num = generator.IndexFromGeneratorPosition(new global::System.Windows.Controls.Primitives.GeneratorPosition(i, 0));
				if (num >= newItemIndex)
				{
					return i;
				}
			}
			return count;
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0003A606 File Offset: 0x00038806
		internal global::System.Windows.Controls.Primitives.IItemContainerGenerator GetGenerator()
		{
			return base.ActiveItemContainerGenerator;
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0003A610 File Offset: 0x00038810
		internal global::System.Windows.Controls.Primitives.GeneratorPosition GetGeneratorPositionFromItemIndex(int itemIndex, out int childIndex)
		{
			global::System.Windows.Controls.Primitives.IItemContainerGenerator generator = this.GetGenerator();
			global::System.Windows.Controls.Primitives.GeneratorPosition result = (generator != null) ? generator.GeneratorPositionFromIndex(itemIndex) : new global::System.Windows.Controls.Primitives.GeneratorPosition(-1, itemIndex + 1);
			childIndex = ((result.Offset == 0) ? result.Index : (result.Index + 1));
			return result;
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0003A658 File Offset: 0x00038858
		protected internal double GetActualMinimizedAreaExtent()
		{
			return this.GetManager().MinimizedAreaActualExtent;
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0003A665 File Offset: 0x00038865
		protected global::Infragistics.Windows.Tiles.ItemInfoBase[] GetItemsInView()
		{
			return this.GetManager().GetItemsInView();
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0003A672 File Offset: 0x00038872
		protected object GetItemAtScrollIndex(int scrollIndex)
		{
			return this.GetManager().GetItemAtScrollIndex(scrollIndex);
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0003A680 File Offset: 0x00038880
		protected internal global::System.Windows.Rect GetMaximizedTileArea(bool clipToOverallTileArea)
		{
			return this.GetManager().GetMaximizedModeTileArea(global::Infragistics.Windows.Internal.TileManager.TileArea.MaximizedTiles, clipToOverallTileArea);
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0003A68F File Offset: 0x0003888F
		protected internal global::Infragistics.Windows.Tiles.ITileConstraints GetMaximizedTileAreaConstraints()
		{
			return this.GetManager().GetMaximizedModeTileAreaConstraints(global::Infragistics.Windows.Internal.TileManager.TileArea.MaximizedTiles);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0003A69D File Offset: 0x0003889D
		protected internal global::System.Windows.Rect GetMinimizedTileArea(bool clipToOverallTileArea)
		{
			return this.GetManager().GetMaximizedModeTileArea(global::Infragistics.Windows.Internal.TileManager.TileArea.MinimizedTiles, clipToOverallTileArea);
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x0003A6AC File Offset: 0x000388AC
		protected internal global::Infragistics.Windows.Tiles.ITileConstraints GetMinimizedTileAreaConstraints()
		{
			return this.GetManager().GetMaximizedModeTileAreaConstraints(global::Infragistics.Windows.Internal.TileManager.TileArea.MinimizedTiles);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0003A6BA File Offset: 0x000388BA
		protected double GetOffsetFromScrollPosition(int scrollPosition)
		{
			return this.GetManager().GetOffsetFromScrollPosition(scrollPosition);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x0003A6C8 File Offset: 0x000388C8
		protected int GetScrollPositionFromOffset(double offset)
		{
			return this.GetManager().GetScrollPositionFromOffset(offset);
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x0003A6D8 File Offset: 0x000388D8
		protected internal global::System.Windows.Rect GetTargetRectOfItem(object item)
		{
			global::Infragistics.Windows.Internal.TileManager manager = this.GetManager();
			global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = manager.GetLayoutItem(item);
			if (layoutItem == null || layoutItem.Container == null || !manager.IsContainerInArrangeCache(layoutItem.Container))
			{
				return global::System.Windows.Rect.Empty;
			}
			global::System.Windows.Rect targetRect = layoutItem.TargetRect;
			global::System.Windows.Thickness tileAreaPadding = this.GetTileAreaPadding();
			global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = layoutItem.ItemInfo;
			global::System.Windows.Vector vector;
			if (itemInfo != null && itemInfo.GetIsMaximized())
			{
				vector = manager.ArrangeOffsetForMaxmizedTiles;
			}
			else
			{
				vector = manager.ArrangeOffset;
			}
			global::System.Windows.Vector offsetVector = new global::System.Windows.Vector(tileAreaPadding.Left, tileAreaPadding.Top) + vector;
			return global::System.Windows.Rect.Offset(targetRect, offsetVector);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0003A76C File Offset: 0x0003896C
		protected global::System.Windows.Rect GetTargetRectOfContainer(global::System.Windows.DependencyObject container)
		{
			this.GetManager();
			object obj = base.ItemFromContainer(container);
			if (obj == null)
			{
				return global::System.Windows.Rect.Empty;
			}
			return this.GetTargetRectOfItem(obj);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0003A798 File Offset: 0x00038998
		protected internal global::System.Windows.Rect GetTileArea()
		{
			global::System.Windows.Rect result = new global::System.Windows.Rect(this.TileAreaSize);
			global::System.Windows.Thickness tileAreaPadding = this.GetTileAreaPadding();
			result.Offset(tileAreaPadding.Left, tileAreaPadding.Top);
			return result;
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0003A7CF File Offset: 0x000389CF
		protected int GetTotalColumnsDisplayed()
		{
			return this.GetManager().TotalColumnsDisplayed;
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0003A7DC File Offset: 0x000389DC
		protected int GetTotalRowsDisplayed()
		{
			return this.GetManager().TotalRowsDisplayed;
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0003A7E9 File Offset: 0x000389E9
		protected bool IsContainerInArrangeCache(global::System.Windows.DependencyObject container)
		{
			return (this._dragManager != null && this._dragManager.Tile == container) || this.GetManager().IsContainerInArrangeCache(container);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0003A810 File Offset: 0x00038A10
		protected internal bool MoveTile(global::System.Windows.FrameworkElement container, object item, global::System.Windows.Point point)
		{
			global::Infragistics.Windows.Internal.TileManager manager = this.GetManager();
			global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = manager.GetLayoutItem(item, container, false, false);
			if (layoutItem == null)
			{
				return false;
			}
			global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItemFromPoint = manager.GetLayoutItemFromPoint(point, layoutItem);
			return layoutItemFromPoint != null && manager.MoveTileHelper(layoutItem, layoutItemFromPoint, false);
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0003A84C File Offset: 0x00038A4C
		protected bool StartTileDrag(global::System.Windows.FrameworkElement container, object item, global::System.Windows.Input.MouseEventArgs e)
		{
			global::Infragistics.Windows.Internal.TileManager manager = this.GetManager();
			if (manager == null)
			{
				return false;
			}
			global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = manager.GetItemInfo(item);
			if (itemInfo == null)
			{
				return false;
			}
			global::Infragistics.Windows.Tiles.AllowTileDragging allowTileDragging = this.GetAllowTileDragging(container, itemInfo);
			if (allowTileDragging == global::Infragistics.Windows.Tiles.AllowTileDragging.No)
			{
				return false;
			}
			if (allowTileDragging == global::Infragistics.Windows.Tiles.AllowTileDragging.Slide && !this.GetIsInMaximizedMode() && this.GetTileLayoutOrder() == global::Infragistics.Windows.Tiles.TileLayoutOrder.UseExplicitRowColumnOnTile)
			{
				allowTileDragging = global::Infragistics.Windows.Tiles.AllowTileDragging.Swap;
			}
			base.CaptureMouse();
			global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = manager.GetLayoutItem(item, container, true, false);
			this._dragManager = new global::Infragistics.Windows.Tiles.TileDragManager(this, container, itemInfo, layoutItem, container, allowTileDragging);
			this._dragManager.StartDrag(e);
			if (layoutItem != null)
			{
				if (!container.IsMeasureValid)
				{
					container.Measure(layoutItem.TargetRect.Size);
				}
				container.Arrange(new global::System.Windows.Rect(new global::System.Windows.Point(-100000.0, -100000.0), layoutItem.TargetRect.Size));
			}
			else
			{
				container.Arrange(new global::System.Windows.Rect(new global::System.Windows.Point(-100000.0, -100000.0), container.DesiredSize));
			}
			container.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.IsDraggingPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
			this.OnTileDragStart(container);
			return true;
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0003A959 File Offset: 0x00038B59
		protected internal virtual bool CanSwapContainers(global::System.Windows.FrameworkElement dragItemContainer, global::Infragistics.Windows.Tiles.ItemInfoBase dragItemInfo, global::System.Windows.FrameworkElement swapTargetContainer, global::Infragistics.Windows.Tiles.ItemInfoBase swapTargetItemInfo)
		{
			return dragItemInfo.GetIsMaximized() == swapTargetItemInfo.GetIsMaximized();
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0003A96A File Offset: 0x00038B6A
		protected internal virtual global::Infragistics.Windows.Tiles.AllowTileDragging GetAllowTileDragging(global::System.Windows.FrameworkElement container, global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo)
		{
			return global::Infragistics.Windows.Tiles.AllowTileDragging.No;
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0003A96D File Offset: 0x00038B6D
		protected internal virtual bool GetCanDropContainer(global::System.Windows.FrameworkElement container, global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo, global::Infragistics.Windows.Tiles.TileState newState, int newLogicalIndex)
		{
			return true;
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0003A970 File Offset: 0x00038B70
		protected internal virtual global::Infragistics.Windows.Tiles.ITileConstraints GetContainerConstraints(global::System.Windows.DependencyObject container, global::Infragistics.Windows.Tiles.TileState state)
		{
			return null;
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x0003A973 File Offset: 0x00038B73
		protected internal virtual global::Infragistics.Windows.Tiles.TileState GetContainerState(global::System.Windows.DependencyObject container)
		{
			return global::Infragistics.Windows.Tiles.TileState.Normal;
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0003A976 File Offset: 0x00038B76
		protected internal virtual global::Infragistics.Windows.Tiles.ITileConstraints GetDefaultConstraints(global::Infragistics.Windows.Tiles.TileState state)
		{
			return null;
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0003A979 File Offset: 0x00038B79
		protected internal virtual global::System.Windows.Size GetDefaultMinimumItemSize()
		{
			return new global::System.Windows.Size(16.0, 12.0);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0003A992 File Offset: 0x00038B92
		protected internal virtual global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior GetExplicitLayoutTileSizeBehavior()
		{
			return global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior.SynchronizeTileWidthsAndHeights;
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0003A995 File Offset: 0x00038B95
		protected internal virtual double GetExplicitMinimizedAreaExtent()
		{
			return 0.0;
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0003A9A0 File Offset: 0x00038BA0
		protected internal virtual global::System.Windows.HorizontalAlignment GetHorizontalTileAreaAlignment()
		{
			return global::System.Windows.HorizontalAlignment.Left;
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x0003A9A3 File Offset: 0x00038BA3
		protected internal virtual double GetInterTileAreaSpacing()
		{
			return 0.0;
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0003A9AE File Offset: 0x00038BAE
		protected internal virtual double GetInterTileSpacing(bool vertical, global::Infragistics.Windows.Tiles.TileState state)
		{
			return 0.0;
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0003A9B9 File Offset: 0x00038BB9
		protected internal virtual bool GetIsInDeferredScrollingMode()
		{
			return false;
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0003A9BC File Offset: 0x00038BBC
		protected internal virtual bool GetIsInMaximizedMode()
		{
			return false;
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0003A9BF File Offset: 0x00038BBF
		protected internal virtual global::Infragistics.Windows.Internal.TileManager GetManager()
		{
			if (this._defaultManager == null)
			{
				this._defaultManager = new global::Infragistics.Windows.Internal.TileManager();
				this._defaultManager.InitializePanel(this);
			}
			return this._defaultManager;
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0003A9E6 File Offset: 0x00038BE6
		protected internal virtual global::Infragistics.Collections.ObservableCollectionExtended<object> GetMaximizedItems()
		{
			if (this._defaultMaximizedItems == null)
			{
				this._defaultMaximizedItems = new global::Infragistics.Collections.ObservableCollectionExtended<object>();
			}
			return this._defaultMaximizedItems;
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0003AA01 File Offset: 0x00038C01
		protected internal virtual int GetMaximizedItemLimit()
		{
			return 0;
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0003AA04 File Offset: 0x00038C04
		protected internal virtual global::Infragistics.Windows.Tiles.MaximizedTileLocation GetMaximizedTileLocation()
		{
			return global::Infragistics.Windows.Tiles.MaximizedTileLocation.Left;
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0003AA07 File Offset: 0x00038C07
		protected internal virtual global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder GetMaximizedTileLayoutOrder()
		{
			return global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder.VerticalWithLastTileFill;
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0003AA0A File Offset: 0x00038C0A
		protected internal virtual int GetMaxColumns()
		{
			return 0;
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0003AA0D File Offset: 0x00038C0D
		protected internal virtual int GetMaxRows()
		{
			return 0;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0003AA10 File Offset: 0x00038C10
		protected internal virtual int GetMinColumns()
		{
			return 1;
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0003AA13 File Offset: 0x00038C13
		protected internal virtual int GetMinRows()
		{
			return 1;
		}

		// Token: 0x06001055 RID: 4181
		protected abstract global::System.Windows.Media.Animation.DoubleAnimationBase GetRepositionAnimation();

		// Token: 0x06001056 RID: 4182 RVA: 0x0003AA16 File Offset: 0x00038C16
		protected internal virtual global::System.Windows.Media.Animation.DoubleAnimationBase GetResizeAnimation()
		{
			return null;
		}

		// Token: 0x06001057 RID: 4183
		protected internal abstract bool GetShouldAnimate();

		// Token: 0x06001058 RID: 4184 RVA: 0x0003AA19 File Offset: 0x00038C19
		protected internal virtual bool GetShowAllTiles()
		{
			return false;
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0003AA1C File Offset: 0x00038C1C
		protected internal virtual bool GetShowAllMinimizedTiles()
		{
			return false;
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0003AA1F File Offset: 0x00038C1F
		protected internal virtual bool GetSupportsDeferredScrolling(global::System.Windows.Controls.Orientation scrollBarOrientation, global::System.Windows.Controls.ScrollViewer scrollViewer)
		{
			return false;
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x0003AA24 File Offset: 0x00038C24
		public virtual global::System.Windows.Size? GetSynchronizedSize()
		{
			return null;
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0003AA3C File Offset: 0x00038C3C
		protected internal virtual global::System.Windows.Thickness GetTileAreaPadding()
		{
			return default(global::System.Windows.Thickness);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0003AA52 File Offset: 0x00038C52
		protected internal virtual global::Infragistics.Windows.Tiles.TileLayoutOrder GetTileLayoutOrder()
		{
			return global::Infragistics.Windows.Tiles.TileLayoutOrder.Vertical;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0003AA55 File Offset: 0x00038C55
		protected internal virtual global::System.Windows.VerticalAlignment GetVerticalTileAreaAlignment()
		{
			return global::System.Windows.VerticalAlignment.Top;
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0003AA58 File Offset: 0x00038C58
		protected virtual void OnAnimationEnded(global::System.Windows.DependencyObject container)
		{
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0003AA5A File Offset: 0x00038C5A
		protected internal virtual void OnContainersSwapped(global::System.Windows.FrameworkElement dragItemContainer, global::Infragistics.Windows.Tiles.ItemInfoBase dragItemInfo, global::System.Windows.FrameworkElement swapTargetContainer, global::Infragistics.Windows.Tiles.ItemInfoBase swapTargetItemInfo)
		{
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0003AA5C File Offset: 0x00038C5C
		protected internal virtual void OnDeferredScrollingStarted(global::System.Windows.Controls.Primitives.Thumb thumb, global::System.Windows.Controls.Orientation scrollBarOrientation)
		{
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0003AA5E File Offset: 0x00038C5E
		protected internal virtual void OnDeferredScrollingEnded(bool cancelled)
		{
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0003AA60 File Offset: 0x00038C60
		protected internal virtual void OnDeferredScrollOffsetChanged(double newDeferredScrollPosition)
		{
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0003AA62 File Offset: 0x00038C62
		protected virtual void OnItemsInViewChanged()
		{
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0003AA64 File Offset: 0x00038C64
		protected virtual void OnTileDragStart(global::System.Windows.FrameworkElement container)
		{
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0003AA66 File Offset: 0x00038C66
		protected virtual void OnTileDragEnd(global::System.Windows.FrameworkElement container)
		{
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0003AA68 File Offset: 0x00038C68
		protected virtual void UpdateTransform(global::System.Windows.DependencyObject container, global::System.Windows.Rect originalRect, global::System.Windows.Rect currentRect, global::System.Windows.Rect targetRect, global::System.Windows.Vector offset, double resizeFactor, bool calledFromArrange)
		{
			global::System.Windows.UIElement uielement = container as global::System.Windows.UIElement;
			if (uielement != null)
			{
				uielement.Arrange(global::System.Windows.Rect.Offset(currentRect, offset));
			}
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0003AA8D File Offset: 0x00038C8D
		protected internal virtual void VerifyMaximizedItems()
		{
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0003AA8F File Offset: 0x00038C8F
		private void AdjustHorizontalOffset(double adjustment)
		{
			this.SetHorizontalOffset(((global::System.Windows.Controls.Primitives.IScrollInfo)this).HorizontalOffset + adjustment);
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0003AA9F File Offset: 0x00038C9F
		private void AdjustVerticalOffset(double adjustment)
		{
			this.SetVerticalOffset(((global::System.Windows.Controls.Primitives.IScrollInfo)this).VerticalOffset + adjustment);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0003AAB0 File Offset: 0x00038CB0
		private bool ArrangeHelper(bool calledFromArrange, bool animationsEnded, bool bypassAnimations)
		{
			if (!calledFromArrange && !base.IsArrangeValid)
			{
				return false;
			}
			global::System.Windows.Thickness tileAreaPadding = this.GetTileAreaPadding();
			global::Infragistics.Windows.Internal.TileManager manager = this.GetManager();
			global::System.Windows.Vector vector = new global::System.Windows.Vector(tileAreaPadding.Left, tileAreaPadding.Top) + manager.ArrangeOffset;
			global::System.Windows.Vector vector2 = new global::System.Windows.Vector(tileAreaPadding.Left, tileAreaPadding.Top) + manager.ArrangeOffsetForMaxmizedTiles;
			global::System.Windows.Rect rect = new global::System.Windows.Rect(this._lastArrangeSize);
			rect.Offset(vector);
			rect.Width = global::System.Math.Max(rect.Width - (tileAreaPadding.Left + tileAreaPadding.Right), 0.0);
			rect.Height = global::System.Math.Max(rect.Height - (tileAreaPadding.Top + tileAreaPadding.Bottom), 0.0);
			rect.Width = global::System.Math.Max(rect.Width, this._tileAreaSize.Width);
			rect.Height = global::System.Math.Max(rect.Height, this._tileAreaSize.Height);
			global::System.Windows.Vector vector3 = new global::System.Windows.Vector(-100000.0, -100000.0);
			double num = this.RepositionFactor;
			double num2 = this.ResizeFactor;
			if (global::Infragistics.CoreUtilities.AreClose(num, 1.0))
			{
				num = 1.0;
			}
			if (global::Infragistics.CoreUtilities.AreClose(num2, 1.0))
			{
				num2 = 1.0;
			}
			global::System.Collections.IEnumerator itemsToBeArranged = this.GetManager().GetItemsToBeArranged();
			global::System.Collections.Generic.Stack<global::Infragistics.Windows.Internal.TileManager.LayoutItem> stack = null;
			global::System.Windows.FrameworkElement frameworkElement = (this._dragManager != null) ? this._dragManager.Tile : null;
			bool flag = !bypassAnimations && this.GetShouldAnimate();
			bool flag2 = animationsEnded || !flag;
			if (flag2)
			{
				if (this.GetIsInMaximizedMode())
				{
					if (this.GetShowAllMinimizedTiles())
					{
						flag2 = false;
					}
				}
				else if (this.GetShowAllTiles() || this.GetTileLayoutOrder() == global::Infragistics.Windows.Tiles.TileLayoutOrder.UseExplicitRowColumnOnTile)
				{
					flag2 = false;
				}
			}
			bool flag3 = false;
			bool flag4 = false;
			global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.LayoutItem> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.LayoutItem>();
			while (itemsToBeArranged.MoveNext())
			{
				object obj = itemsToBeArranged.Current;
				global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = obj as global::Infragistics.Windows.Internal.TileManager.LayoutItem;
				if (layoutItem != null)
				{
					list.Add(layoutItem);
				}
			}
			bool ignoreChildSizeChanges = this._ignoreChildSizeChanges;
			if (!ignoreChildSizeChanges)
			{
				this._childSizeChanged = false;
			}
			this._ignoreChildSizeChanges = true;
			try
			{
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem2 = list[i];
					if (layoutItem2 != null)
					{
						global::System.Windows.UIElement uielement = layoutItem2.Container as global::System.Windows.UIElement;
						if (uielement != frameworkElement)
						{
							global::System.Windows.Size size = layoutItem2.TargetRect.Size;
							if (uielement.Visibility == global::System.Windows.Visibility.Collapsed || size.Width < 1.0 || size.Height < 1.0)
							{
								if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
								{
									layoutItem2.CurrentRect = layoutItem2.TargetRect;
									if (!uielement.IsMeasureValid)
									{
										uielement.Measure(this._lastMeasureSize);
									}
									uielement.Arrange(new global::System.Windows.Rect(new global::System.Windows.Point(vector3.X, vector3.Y), uielement.DesiredSize));
								}
								if (stack == null)
								{
									stack = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.Internal.TileManager.LayoutItem>();
								}
								stack.Push(layoutItem2);
							}
							else
							{
								if (animationsEnded || !flag)
								{
									this.OnAnimationEnded(uielement);
								}
								if (flag && uielement != null)
								{
									bool isCurrentSameAsTarget = layoutItem2.IsCurrentSameAsTarget;
									if (!flag4)
									{
										flag4 = !isCurrentSameAsTarget;
									}
									if (!calledFromArrange && !isCurrentSameAsTarget)
									{
										global::System.Windows.Rect currentRect = layoutItem2.CurrentRect;
										global::System.Windows.Rect originalRect = layoutItem2.OriginalRect;
										global::System.Windows.Rect targetRect = layoutItem2.TargetRect;
										currentRect = originalRect;
										currentRect.X = global::Infragistics.Windows.Tiles.TilesPanelBase.ApplyFactor(originalRect.X, targetRect.X, num);
										currentRect.Y = global::Infragistics.Windows.Tiles.TilesPanelBase.ApplyFactor(originalRect.Y, targetRect.Y, num);
										if (layoutItem2.ShouldAnimateResize)
										{
											if (!flag3)
											{
												flag3 = true;
											}
											currentRect.Width = global::System.Math.Max(global::Infragistics.Windows.Tiles.TilesPanelBase.ApplyFactor(originalRect.Width, targetRect.Width, num2), 1.0);
											currentRect.Height = global::System.Math.Max(global::Infragistics.Windows.Tiles.TilesPanelBase.ApplyFactor(originalRect.Height, targetRect.Height, num2), 1.0);
										}
										else
										{
											currentRect.Size = targetRect.Size;
										}
										layoutItem2.CurrentRect = currentRect;
									}
								}
								else
								{
									layoutItem2.CurrentRect = layoutItem2.TargetRect;
								}
								global::System.Windows.Rect rect2 = global::System.Windows.Rect.Offset(layoutItem2.CurrentRect, vector);
								global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = layoutItem2.ItemInfo;
								bool flag5 = itemInfo != null && itemInfo.GetIsMaximized();
								global::System.Windows.Vector vector4 = flag5 ? vector2 : vector;
								bool flag6 = false;
								if (flag2 && !flag5)
								{
									flag6 = (!rect.IntersectsWith(rect2) && !rect.IntersectsWith(global::System.Windows.Rect.Offset(layoutItem2.TargetRect, vector)));
								}
								if (uielement == null || flag6)
								{
									if (stack == null)
									{
										stack = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.Internal.TileManager.LayoutItem>();
									}
									stack.Push(layoutItem2);
									vector4 = vector3;
									rect2 = layoutItem2.TargetRect;
									rect2 = global::System.Windows.Rect.Offset(rect2, vector4);
									layoutItem2.CurrentRect = layoutItem2.TargetRect;
								}
								if (uielement != null)
								{
									if (calledFromArrange || !uielement.IsArrangeValid)
									{
										uielement.Arrange(new global::System.Windows.Rect(layoutItem2.TargetRect.Size));
									}
									if (calledFromArrange)
									{
										layoutItem2.SetOriginalRect(layoutItem2.CurrentRect, true);
									}
									this.UpdateTransform(uielement, layoutItem2.OriginalRect, layoutItem2.CurrentRect, layoutItem2.TargetRect, vector4, num2, calledFromArrange);
								}
							}
						}
					}
				}
				if (stack != null)
				{
					while (stack.Count > 0)
					{
						manager.RemoveLayoutItem(stack.Pop());
					}
				}
			}
			finally
			{
				this._ignoreChildSizeChanges = ignoreChildSizeChanges;
				if (!ignoreChildSizeChanges && this._childSizeChanged)
				{
					this._childSizeChanged = false;
					base.InvalidateMeasure();
				}
			}
			return flag4;
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0003B05C File Offset: 0x0003925C
		private global::System.Windows.Media.Animation.AnimationClock AnimateDoubleProperty(global::System.Windows.DependencyProperty dp, global::System.Windows.Media.Animation.DoubleAnimationBase animation)
		{
			global::System.Windows.Media.Animation.AnimationClock animationClock = animation.CreateClock();
			this._activeAnimationCount++;
			animationClock.Completed += this.OnAnimationCompleted;
			base.ApplyAnimationClock(dp, animationClock);
			animationClock.Controller.Begin();
			base.SetValue(dp, 0.0);
			return animationClock;
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x0003B0BC File Offset: 0x000392BC
		private void AnimateRepositionAndResize()
		{
			if (!this.GetShouldAnimate())
			{
				return;
			}
			if (this._repositionClock != null)
			{
				this._repositionClock.Controller.Remove();
				this.UnhookAnimation(this._repositionClock);
			}
			if (this._resizeClock != null)
			{
				this._resizeClock.Controller.Remove();
				this.UnhookAnimation(this._resizeClock);
			}
			global::System.Windows.Media.Animation.DoubleAnimationBase doubleAnimationBase = this.GetRepositionAnimation();
			if (doubleAnimationBase != null)
			{
				this._repositionClock = this.AnimateDoubleProperty(global::Infragistics.Windows.Tiles.TilesPanelBase.RepositionFactorProperty, doubleAnimationBase);
			}
			doubleAnimationBase = this.GetResizeAnimation();
			if (doubleAnimationBase != null)
			{
				this._resizeClock = this.AnimateDoubleProperty(global::Infragistics.Windows.Tiles.TilesPanelBase.ResizeFactorProperty, doubleAnimationBase);
			}
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0003B152 File Offset: 0x00039352
		private static double ApplyFactor(double original, double target, double factor)
		{
			if (factor == 1.0)
			{
				return target;
			}
			return original + (target - original) * factor;
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0003B169 File Offset: 0x00039369
		private void OnAnimationCompleted(object sender, global::System.EventArgs e)
		{
			this.UnhookAnimation(sender as global::System.Windows.Media.Animation.AnimationClock);
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0003B177 File Offset: 0x00039377
		private void OnArrangeComplete()
		{
			if (this._inViewItemsHaveChanged)
			{
				this._inViewItemsHaveChanged = false;
				this.OnItemsInViewChanged();
			}
			base.TriggerCleanupOfUnusedGeneratedItems(true);
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0003B195 File Offset: 0x00039395
		private void OnCollectionChanged(object sender, global::System.EventArgs e)
		{
			if (base.IsItemsHost || !base.IsInitialized)
			{
				return;
			}
			this.GetManager().OnItemsChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0003B1BC File Offset: 0x000393BC
		private static void OnConstraintPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Media.Visual visual = d as global::System.Windows.Media.Visual;
			global::Infragistics.Windows.Tiles.TilesPanelBase tilesPanelBase = (visual != null) ? (global::System.Windows.Media.VisualTreeHelper.GetParent(visual) as global::Infragistics.Windows.Tiles.TilesPanelBase) : null;
			if (tilesPanelBase != null)
			{
				tilesPanelBase.InvalidateMeasure();
			}
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0003B1EC File Offset: 0x000393EC
		private void OnFactorChanged()
		{
			if (this._repositionFactor < 0.1 && this._resizeFactor < 0.1)
			{
				this.ProcessFactorChange();
				return;
			}
			if (this._processFactorChangePending == null)
			{
				this._processFactorChangePending = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.Utilities.MethodDelegate(this.ProcessFactorChange));
			}
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0003B249 File Offset: 0x00039449
		private void ProcessFactorChange()
		{
			this._processFactorChangePending = null;
			this.ArrangeHelper(false, false, false);
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0003B25C File Offset: 0x0003945C
		private void ProcessAllAnimationsEnded()
		{
			if (!this._isRestartingAnimations)
			{
				this.ArrangeHelper(false, true, false);
				this.OnArrangeComplete();
			}
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0003B278 File Offset: 0x00039478
		private void ProcessAnimationRestart()
		{
			this._asynchAnimationStart = null;
			if (this.IsAnimationInProgress)
			{
				this._isRestartingAnimations = true;
			}
			try
			{
				this.AnimateRepositionAndResize();
			}
			finally
			{
				this._isRestartingAnimations = false;
			}
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x0003B2BC File Offset: 0x000394BC
		private void SetHorizontalOffset(double offset)
		{
			if (this.IsScrollClient)
			{
				global::Infragistics.Windows.Internal.TileManager manager = this.GetManager();
				if (manager.ScrollTilesVertically)
				{
					offset = global::System.Math.Round(offset);
				}
				double num = global::System.Math.Max(global::System.Math.Min(manager.ScrollMaxOffset.X, offset), 0.0);
				if (this.ScrollDataInfo.IsInDeferredDrag)
				{
					this.ScrollDataInfo.DeferredDragOffset = num;
					this.OnDeferredScrollOffsetChanged(num);
					return;
				}
				if (num != this.ScrollDataInfo._offset.X)
				{
					global::System.Windows.Vector offset2 = this.ScrollDataInfo._offset;
					this.ScrollDataInfo._offset.X = num;
					manager.OnScrollOffsetChanged(this.ScrollDataInfo._offset, offset2);
					base.InvalidateMeasure();
				}
			}
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0003B378 File Offset: 0x00039578
		private void SetVerticalOffset(double offset)
		{
			if (this.IsScrollClient)
			{
				global::Infragistics.Windows.Internal.TileManager manager = this.GetManager();
				if (manager.ScrollTilesVertically)
				{
					offset = global::System.Math.Round(offset);
				}
				double num = global::System.Math.Max(global::System.Math.Min(manager.ScrollMaxOffset.Y, offset), 0.0);
				if (this.ScrollDataInfo.IsInDeferredDrag)
				{
					this.ScrollDataInfo.DeferredDragOffset = num;
					this.OnDeferredScrollOffsetChanged(num);
					return;
				}
				if (num != this.ScrollDataInfo._offset.Y)
				{
					global::System.Windows.Vector offset2 = this.ScrollDataInfo._offset;
					this.ScrollDataInfo._offset.Y = num;
					manager.OnScrollOffsetChanged(this.ScrollDataInfo._offset, offset2);
					base.InvalidateMeasure();
				}
			}
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0003B434 File Offset: 0x00039634
		private void UnhookAnimation(global::System.Windows.Media.Animation.AnimationClock clock)
		{
			if (clock == null)
			{
				return;
			}
			global::System.Windows.DependencyProperty dependencyProperty = null;
			if (clock == this._repositionClock)
			{
				dependencyProperty = global::Infragistics.Windows.Tiles.TilesPanelBase.RepositionFactorProperty;
				this._repositionClock = null;
			}
			else if (clock == this._resizeClock)
			{
				dependencyProperty = global::Infragistics.Windows.Tiles.TilesPanelBase.ResizeFactorProperty;
				this._resizeClock = null;
			}
			clock.Completed -= this.OnAnimationCompleted;
			if (dependencyProperty != null)
			{
				this._activeAnimationCount--;
				base.ClearValue(dependencyProperty);
				if (this._activeAnimationCount < 1)
				{
					this.ProcessAllAnimationsEnded();
				}
			}
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0003B4B0 File Offset: 0x000396B0
		private static bool ValidateColumnRow(object objVal)
		{
			int num = (int)objVal;
			return num >= 0 || num == -1;
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0003B4D0 File Offset: 0x000396D0
		private static bool ValidateColumnRowSpan(object objVal)
		{
			int num = (int)objVal;
			return num >= 1 || num == 0;
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0003B4F0 File Offset: 0x000396F0
		private static bool ValidateColumnRowWeight(object objVal)
		{
			float num = (float)objVal;
			return !float.IsNaN(num) && !float.IsInfinity(num) && num >= 0f;
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0003B524 File Offset: 0x00039724
		internal static bool ValidateMaximizedTileLimit(object objVal)
		{
			int num = (int)objVal;
			return num >= 0;
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x0003B53F File Offset: 0x0003973F
		// (set) Token: 0x0600107F RID: 4223 RVA: 0x0003B556 File Offset: 0x00039756
		bool global::System.Windows.Controls.Primitives.IScrollInfo.CanHorizontallyScroll
		{
			get
			{
				return this.IsScrollClient && this.ScrollDataInfo._canHorizontallyScroll;
			}
			set
			{
				if (this.IsScrollClient)
				{
					this.ScrollDataInfo._canHorizontallyScroll = value;
				}
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x0003B56C File Offset: 0x0003976C
		// (set) Token: 0x06001081 RID: 4225 RVA: 0x0003B583 File Offset: 0x00039783
		bool global::System.Windows.Controls.Primitives.IScrollInfo.CanVerticallyScroll
		{
			get
			{
				return this.IsScrollClient && this.ScrollDataInfo._canVerticallyScroll;
			}
			set
			{
				if (this.IsScrollClient)
				{
					this.ScrollDataInfo._canVerticallyScroll = value;
				}
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x0003B599 File Offset: 0x00039799
		double global::System.Windows.Controls.Primitives.IScrollInfo.ExtentHeight
		{
			get
			{
				if (!this.IsScrollClient)
				{
					return 0.0;
				}
				return this.ScrollDataInfo._extent.Height;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x0003B5BD File Offset: 0x000397BD
		double global::System.Windows.Controls.Primitives.IScrollInfo.ExtentWidth
		{
			get
			{
				if (!this.IsScrollClient)
				{
					return 0.0;
				}
				return this.ScrollDataInfo._extent.Width;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x0003B5E4 File Offset: 0x000397E4
		double global::System.Windows.Controls.Primitives.IScrollInfo.HorizontalOffset
		{
			get
			{
				double result = 0.0;
				if (this.IsScrollClient)
				{
					if (this.ScrollDataInfo.IsInDeferredDrag && this.ScrollBarOrientation == global::System.Windows.Controls.Orientation.Horizontal)
					{
						result = this.ScrollDataInfo.DeferredDragOffset;
					}
					else
					{
						result = this.ScrollDataInfo._offset.X;
					}
				}
				return result;
			}
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0003B638 File Offset: 0x00039838
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineDown()
		{
			this.AdjustVerticalOffset(this.GetManager().ScrollSmallChange.Y);
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x0003B660 File Offset: 0x00039860
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineLeft()
		{
			this.AdjustHorizontalOffset(-this.GetManager().ScrollSmallChange.X);
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0003B688 File Offset: 0x00039888
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineRight()
		{
			this.AdjustHorizontalOffset(this.GetManager().ScrollSmallChange.X);
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0003B6B0 File Offset: 0x000398B0
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineUp()
		{
			this.AdjustVerticalOffset(-this.GetManager().ScrollSmallChange.Y);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0003B6D7 File Offset: 0x000398D7
		global::System.Windows.Rect global::System.Windows.Controls.Primitives.IScrollInfo.MakeVisible(global::System.Windows.Media.Visual visual, global::System.Windows.Rect rectangle)
		{
			if (this.IsScrollClient)
			{
				return this.GetManager().MakeVisible(visual, rectangle);
			}
			return rectangle;
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0003B6F0 File Offset: 0x000398F0
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelDown()
		{
			this.AdjustVerticalOffset((double)global::System.Windows.SystemParameters.WheelScrollLines * this.GetManager().ScrollSmallChange.Y);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0003B720 File Offset: 0x00039920
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelLeft()
		{
			this.AdjustHorizontalOffset((double)(-(double)global::System.Windows.SystemParameters.WheelScrollLines) * this.GetManager().ScrollSmallChange.X);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0003B750 File Offset: 0x00039950
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelRight()
		{
			this.AdjustHorizontalOffset((double)global::System.Windows.SystemParameters.WheelScrollLines * this.GetManager().ScrollSmallChange.X);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0003B780 File Offset: 0x00039980
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelUp()
		{
			this.AdjustVerticalOffset((double)(-(double)global::System.Windows.SystemParameters.WheelScrollLines) * this.GetManager().ScrollSmallChange.Y);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x0003B7B0 File Offset: 0x000399B0
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageDown()
		{
			this.AdjustVerticalOffset(this.GetManager().ScrollLargeChange.Y);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0003B7D8 File Offset: 0x000399D8
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageLeft()
		{
			this.AdjustHorizontalOffset(-this.GetManager().ScrollLargeChange.X);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0003B800 File Offset: 0x00039A00
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageRight()
		{
			this.AdjustHorizontalOffset(this.GetManager().ScrollLargeChange.X);
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0003B828 File Offset: 0x00039A28
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageUp()
		{
			this.AdjustVerticalOffset(-this.GetManager().ScrollLargeChange.Y);
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x0003B84F File Offset: 0x00039A4F
		// (set) Token: 0x06001093 RID: 4243 RVA: 0x0003B866 File Offset: 0x00039A66
		global::System.Windows.Controls.ScrollViewer global::System.Windows.Controls.Primitives.IScrollInfo.ScrollOwner
		{
			get
			{
				if (!this.IsScrollClient)
				{
					return null;
				}
				return this.ScrollDataInfo._scrollOwner;
			}
			set
			{
				if (value != this.ScrollDataInfo._scrollOwner)
				{
					this.ScrollDataInfo._scrollOwner = value;
					base.InvalidateMeasure();
				}
			}
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0003B888 File Offset: 0x00039A88
		void global::System.Windows.Controls.Primitives.IScrollInfo.SetHorizontalOffset(double offset)
		{
			this.SetHorizontalOffset(offset);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0003B891 File Offset: 0x00039A91
		void global::System.Windows.Controls.Primitives.IScrollInfo.SetVerticalOffset(double offset)
		{
			this.SetVerticalOffset(offset);
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x0003B89C File Offset: 0x00039A9C
		double global::System.Windows.Controls.Primitives.IScrollInfo.VerticalOffset
		{
			get
			{
				double result = 0.0;
				if (this.IsScrollClient)
				{
					if (this.ScrollDataInfo.IsInDeferredDrag && this.ScrollBarOrientation == global::System.Windows.Controls.Orientation.Vertical)
					{
						result = this.ScrollDataInfo.DeferredDragOffset;
					}
					else
					{
						result = this.ScrollDataInfo._offset.Y;
					}
				}
				return result;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x0003B8F1 File Offset: 0x00039AF1
		double global::System.Windows.Controls.Primitives.IScrollInfo.ViewportHeight
		{
			get
			{
				if (!this.IsScrollClient)
				{
					return 0.0;
				}
				return this.ScrollDataInfo._viewport.Height;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x0003B915 File Offset: 0x00039B15
		double global::System.Windows.Controls.Primitives.IScrollInfo.ViewportWidth
		{
			get
			{
				if (!this.IsScrollClient)
				{
					return 0.0;
				}
				return this.ScrollDataInfo._viewport.Width;
			}
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0003B93C File Offset: 0x00039B3C
		void global::Infragistics.Windows.Scrolling.IDeferredScrollPanel.OnThumbDragComplete(bool cancelled)
		{
			if (this.ScrollDataInfo.IsInDeferredDrag)
			{
				this.ScrollDataInfo.IsInDeferredDrag = false;
				if (this.ScrollBarOrientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					this.SetHorizontalOffset(this.ScrollDataInfo.DeferredDragOffset);
				}
				else
				{
					this.SetVerticalOffset(this.ScrollDataInfo.DeferredDragOffset);
				}
				this.OnDeferredScrollingEnded(cancelled);
			}
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0003B998 File Offset: 0x00039B98
		void global::Infragistics.Windows.Scrolling.IDeferredScrollPanel.OnThumbDragStart(global::System.Windows.Controls.Primitives.Thumb thumb, global::System.Windows.Controls.Orientation scrollBarOrientation)
		{
			if (this.GetIsInDeferredScrollingMode())
			{
				this.ScrollDataInfo.IsInDeferredDrag = true;
				this.ScrollDataInfo.DeferredDragOffset = ((this.ScrollBarOrientation == global::System.Windows.Controls.Orientation.Horizontal) ? this.ScrollDataInfo._offset.X : this.ScrollDataInfo._offset.Y);
				this.OnDeferredScrollingStarted(thumb, scrollBarOrientation);
			}
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0003B9F6 File Offset: 0x00039BF6
		bool global::Infragistics.Windows.Scrolling.IDeferredScrollPanel.SupportsDeferredScrolling(global::System.Windows.Controls.Orientation scrollBarOrientation, global::System.Windows.Controls.ScrollViewer scrollViewer)
		{
			return this.GetSupportsDeferredScrolling(scrollBarOrientation, scrollViewer);
		}

		// Token: 0x04000825 RID: 2085
		private global::System.Windows.Media.Animation.AnimationClock _repositionClock;

		// Token: 0x04000826 RID: 2086
		private global::System.Windows.Media.Animation.AnimationClock _resizeClock;

		// Token: 0x04000827 RID: 2087
		private global::System.Windows.Size _lastMeasureSize;

		// Token: 0x04000828 RID: 2088
		private global::System.Windows.Size _lastArrangeSize;

		// Token: 0x04000829 RID: 2089
		private global::System.Windows.Size _lastDesiredSize;

		// Token: 0x0400082A RID: 2090
		private global::System.Windows.Size _lastMeasureSizeAdjusted = global::System.Windows.Size.Empty;

		// Token: 0x0400082B RID: 2091
		private global::System.Windows.Size _tileAreaSize;

		// Token: 0x0400082C RID: 2092
		private global::Infragistics.Windows.Internal.TileManager _defaultManager;

		// Token: 0x0400082D RID: 2093
		private global::Infragistics.Windows.Tiles.TileDragManager _dragManager;

		// Token: 0x0400082E RID: 2094
		private global::System.Windows.Threading.DispatcherOperation _asynchAnimationStart;

		// Token: 0x0400082F RID: 2095
		private int _activeAnimationCount;

		// Token: 0x04000830 RID: 2096
		private int _arrangeCount;

		// Token: 0x04000831 RID: 2097
		private int _measureCount;

		// Token: 0x04000832 RID: 2098
		private global::System.Windows.Vector _lastScrollOffset;

		// Token: 0x04000833 RID: 2099
		private global::System.DateTime _lastMeasureTimeStamp = global::System.DateTime.Now;

		// Token: 0x04000834 RID: 2100
		private global::System.Windows.Size _itemsControlLastRenderSize;

		// Token: 0x04000835 RID: 2101
		private bool _bypassArrangeVerification;

		// Token: 0x04000836 RID: 2102
		private bool _bypassArrange;

		// Token: 0x04000837 RID: 2103
		private bool _ignoreChildSizeChanges;

		// Token: 0x04000838 RID: 2104
		private bool _childSizeChanged;

		// Token: 0x04000839 RID: 2105
		private bool _inViewItemsHaveChanged;

		// Token: 0x0400083A RID: 2106
		private bool _isRestartingAnimations;

		// Token: 0x0400083B RID: 2107
		private double _repositionFactor = (double)global::Infragistics.Windows.Tiles.TilesPanelBase.RepositionFactorProperty.DefaultMetadata.DefaultValue;

		// Token: 0x0400083C RID: 2108
		private double _resizeFactor = (double)global::Infragistics.Windows.Tiles.TilesPanelBase.ResizeFactorProperty.DefaultMetadata.DefaultValue;

		// Token: 0x0400083D RID: 2109
		private global::Infragistics.Collections.ObservableCollectionExtended<object> _defaultMaximizedItems;

		// Token: 0x0400083E RID: 2110
		public static readonly global::System.Windows.DependencyProperty ColumnProperty = global::System.Windows.DependencyProperty.RegisterAttached("Column", typeof(int), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.OnConstraintPropertyChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.ValidateColumnRow));

		// Token: 0x0400083F RID: 2111
		public static readonly global::System.Windows.DependencyProperty ColumnSpanProperty = global::System.Windows.DependencyProperty.RegisterAttached("ColumnSpan", typeof(int), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(1, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.OnConstraintPropertyChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.ValidateColumnRowSpan));

		// Token: 0x04000840 RID: 2112
		public static readonly global::System.Windows.DependencyProperty ColumnWeightProperty = global::System.Windows.DependencyProperty.RegisterAttached("ColumnWeight", typeof(float), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(0f, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.OnConstraintPropertyChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.ValidateColumnRowWeight));

		// Token: 0x04000841 RID: 2113
		internal static readonly global::System.Windows.DependencyPropertyKey IsDraggingPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsDragging", typeof(bool), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000842 RID: 2114
		public static readonly global::System.Windows.DependencyProperty IsDraggingProperty = global::Infragistics.Windows.Tiles.TilesPanelBase.IsDraggingPropertyKey.DependencyProperty;

		// Token: 0x04000843 RID: 2115
		internal static readonly global::System.Windows.DependencyPropertyKey IsSwapTargetPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsSwapTarget", typeof(bool), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000844 RID: 2116
		public static readonly global::System.Windows.DependencyProperty IsSwapTargetProperty = global::Infragistics.Windows.Tiles.TilesPanelBase.IsSwapTargetPropertyKey.DependencyProperty;

		// Token: 0x04000845 RID: 2117
		public static readonly global::System.Windows.DependencyProperty RowProperty = global::System.Windows.DependencyProperty.RegisterAttached("Row", typeof(int), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.OnConstraintPropertyChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.ValidateColumnRow));

		// Token: 0x04000846 RID: 2118
		public static readonly global::System.Windows.DependencyProperty RowSpanProperty = global::System.Windows.DependencyProperty.RegisterAttached("RowSpan", typeof(int), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(1, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.OnConstraintPropertyChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.ValidateColumnRowSpan));

		// Token: 0x04000847 RID: 2119
		public static readonly global::System.Windows.DependencyProperty RowWeightProperty = global::System.Windows.DependencyProperty.RegisterAttached("RowWeight", typeof(float), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(0f, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.OnConstraintPropertyChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.ValidateColumnRowWeight));

		// Token: 0x04000848 RID: 2120
		internal static readonly global::System.Windows.DependencyProperty RepositionFactorProperty = global::System.Windows.DependencyProperty.Register("RepositionFactor", typeof(double), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(1.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.OnRepositionFactorChanged)));

		// Token: 0x04000849 RID: 2121
		internal static readonly global::System.Windows.DependencyProperty ResizeFactorProperty = global::System.Windows.DependencyProperty.Register("ResizeFactor", typeof(double), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(1.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.OnResizeFactorChanged)));

		// Token: 0x0400084A RID: 2122
		private global::Infragistics.Windows.Tiles.TilesPanelBase.ScrollData _scrollDataInfo;

		// Token: 0x0400084B RID: 2123
		private global::System.Windows.Threading.DispatcherOperation _processFactorChangePending;

		// Token: 0x020001BE RID: 446
		internal class GenerationCache : global::System.IDisposable
		{
			// Token: 0x0600109D RID: 4253 RVA: 0x0003BCBC File Offset: 0x00039EBC
			internal GenerationCache(global::Infragistics.Windows.Tiles.TilesPanelBase panel, global::System.Windows.Size constraint)
			{
				this._panel = panel;
				this._itemsControl = global::System.Windows.Controls.ItemsControl.GetItemsOwner(this._panel);
				this._manager = panel.GetManager();
				this._constraint = constraint;
				this._childElements = this._panel.ChildElements;
				this._childElementCount = this._childElements.Count;
				global::Infragistics.Windows.Selection.ScrollDirection scrollDirection = this._manager.BeginGeneration(this);
				this._panel.BeginGeneration(scrollDirection, this._itemsExpectedToBeGenerated);
				this._itemsExpectedToBeGenerated = null;
				this._generator = this._panel.GetGenerator();
			}

			// Token: 0x0600109E RID: 4254 RVA: 0x0003BD70 File Offset: 0x00039F70
			internal void GenerateElements()
			{
				this._manager.GenerateElements(this);
			}

			// Token: 0x0600109F RID: 4255 RVA: 0x0003BD80 File Offset: 0x00039F80
			internal global::System.Windows.UIElement GenerateElement(int indexToGen)
			{
				if (this._itemsControl == null)
				{
					return this._childElements[indexToGen] as global::System.Windows.UIElement;
				}
				if (this._currentGeneratorStart == null || this._currentGeneratorPositionIndex != indexToGen)
				{
					this.StartGenerator(indexToGen);
				}
				bool flag;
				global::System.Windows.UIElement uielement = this._generator.GenerateNext(out flag) as global::System.Windows.UIElement;
				this._currentGeneratorPositionIndex++;
				if (uielement == null)
				{
					return null;
				}
				if (flag)
				{
					if (this._nextChildElementIndex < 0)
					{
						this._nextChildElementIndex = this._panel.FindSlotForNewlyRealizedRecordPresenter(indexToGen);
					}
					if (this._nextChildElementIndex >= this._childElementCount)
					{
						this._panel.AddInternalChild(uielement);
					}
					else
					{
						this._panel.InsertInternalChild(this._nextChildElementIndex, uielement);
					}
					this._childElementCount++;
					this._generator.PrepareItemContainer(uielement);
				}
				if (this._nextChildElementIndex >= 0)
				{
					this._nextChildElementIndex++;
				}
				return uielement;
			}

			// Token: 0x060010A0 RID: 4256 RVA: 0x0003BE63 File Offset: 0x0003A063
			private void ReleaseGeneratorStart()
			{
				if (this._currentGeneratorStart != null)
				{
					this._currentGeneratorStart.Dispose();
					this._currentGeneratorStart = null;
				}
			}

			// Token: 0x060010A1 RID: 4257 RVA: 0x0003BE80 File Offset: 0x0003A080
			private void StartGenerator(int indexToGen)
			{
				this.ReleaseGeneratorStart();
				this._currentGeneratorPositionIndex = indexToGen;
				global::System.Windows.Controls.Primitives.GeneratorPosition generatorPositionFromItemIndex = this._panel.GetGeneratorPositionFromItemIndex(indexToGen, out this._nextChildElementIndex);
				this._currentGeneratorStart = this._generator.StartAt(generatorPositionFromItemIndex, global::System.Windows.Controls.Primitives.GeneratorDirection.Forward, true);
			}

			// Token: 0x060010A2 RID: 4258 RVA: 0x0003BEC1 File Offset: 0x0003A0C1
			public void Dispose()
			{
				this.ReleaseGeneratorStart();
				if (this._generator != null)
				{
					this._panel.EndGeneration();
				}
				this._desiredSize = this._manager.EndGeneration(this);
			}

			// Token: 0x0400084C RID: 2124
			internal global::Infragistics.Windows.Tiles.TilesPanelBase _panel;

			// Token: 0x0400084D RID: 2125
			private global::Infragistics.Windows.Internal.TileManager _manager;

			// Token: 0x0400084E RID: 2126
			private global::System.Collections.IList _childElements;

			// Token: 0x0400084F RID: 2127
			private int _childElementCount;

			// Token: 0x04000850 RID: 2128
			private global::System.Windows.Size _constraint;

			// Token: 0x04000851 RID: 2129
			private global::System.Windows.Size _measureConstraint = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);

			// Token: 0x04000852 RID: 2130
			private global::System.Windows.Controls.Primitives.IItemContainerGenerator _generator;

			// Token: 0x04000853 RID: 2131
			private global::System.IDisposable _currentGeneratorStart;

			// Token: 0x04000854 RID: 2132
			internal global::System.Collections.ArrayList _itemsExpectedToBeGenerated;

			// Token: 0x04000855 RID: 2133
			private int _currentGeneratorPositionIndex;

			// Token: 0x04000856 RID: 2134
			private int _nextChildElementIndex;

			// Token: 0x04000857 RID: 2135
			private global::System.Windows.Controls.ItemsControl _itemsControl;

			// Token: 0x04000858 RID: 2136
			internal global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _previousGridBagLayoutNormalModeOverall;

			// Token: 0x04000859 RID: 2137
			internal global::System.Collections.Generic.Dictionary<global::System.Windows.DependencyObject, global::Infragistics.Windows.Internal.TileManager.LayoutItem> _previousItemsToBeArrangedTempCache;

			// Token: 0x0400085A RID: 2138
			internal global::Infragistics.Windows.Helpers.HashSet _newItemsToBeArrangedTempCache;

			// Token: 0x0400085B RID: 2139
			internal global::System.Windows.Size _desiredSize;

			// Token: 0x0400085C RID: 2140
			internal bool _requiresAnotherLayoutPass;
		}

		// Token: 0x020001BF RID: 447
		internal class ScrollData
		{
			// Token: 0x060010A3 RID: 4259 RVA: 0x0003BEEE File Offset: 0x0003A0EE
			internal ScrollData(global::Infragistics.Windows.Tiles.TilesPanelBase panel)
			{
				this._panel = panel;
			}

			// Token: 0x060010A4 RID: 4260 RVA: 0x0003BF30 File Offset: 0x0003A130
			internal void Reset()
			{
				global::System.Windows.Vector offset = this._offset;
				this._offset = default(global::System.Windows.Vector);
				this._extent = default(global::System.Windows.Size);
				this._viewport = default(global::System.Windows.Size);
				this._panel.GetManager().OnScrollOffsetChanged(this._offset, offset);
			}

			// Token: 0x060010A5 RID: 4261 RVA: 0x0003BF80 File Offset: 0x0003A180
			internal void VerifyScrollData(global::System.Windows.Size viewPort, global::System.Windows.Size extent)
			{
				if (double.IsInfinity(viewPort.Width))
				{
					viewPort.Width = extent.Width;
				}
				if (double.IsInfinity(viewPort.Height))
				{
					viewPort.Height = extent.Height;
				}
				bool flag = (!global::Infragistics.Windows.Internal.TileManager.AreClose(this._viewport.Width, viewPort.Width) | !global::Infragistics.Windows.Internal.TileManager.AreClose(this._viewport.Height, viewPort.Height)) || !global::Infragistics.Windows.Internal.TileManager.AreClose(this._extent.Width, extent.Width) || !global::Infragistics.Windows.Internal.TileManager.AreClose(this._extent.Height, extent.Height);
				this._viewport = viewPort;
				this._extent = extent;
				global::System.Windows.Vector offset = this._offset;
				flag |= this.VerifyOffset();
				if (flag)
				{
					this._panel.GetManager().OnScrollOffsetChanged(this._offset, offset);
				}
				if (this._scrollOwner != null && flag)
				{
					this._oldOffset = this._offset;
					this._scrollOwner.InvalidateScrollInfo();
				}
			}

			// Token: 0x060010A6 RID: 4262 RVA: 0x0003C090 File Offset: 0x0003A290
			private bool VerifyOffset()
			{
				double x = global::System.Math.Max(global::System.Math.Min(this._offset.X, this._panel.MaxHorizontalOffset), 0.0);
				double y = global::System.Math.Max(global::System.Math.Min(this._offset.Y, this._panel.MaxVerticalOffset), 0.0);
				global::System.Windows.Vector oldOffset = this._oldOffset;
				this._offset = new global::System.Windows.Vector(x, y);
				return !global::Infragistics.Windows.Internal.TileManager.AreClose(this._offset.X, oldOffset.X) || !global::Infragistics.Windows.Internal.TileManager.AreClose(this._offset.Y, oldOffset.Y);
			}

			// Token: 0x170003AC RID: 940
			// (get) Token: 0x060010A7 RID: 4263 RVA: 0x0003C13A File Offset: 0x0003A33A
			// (set) Token: 0x060010A8 RID: 4264 RVA: 0x0003C142 File Offset: 0x0003A342
			internal double DeferredDragOffset
			{
				get
				{
					return this._deferredDragOffset;
				}
				set
				{
					this._deferredDragOffset = value;
				}
			}

			// Token: 0x170003AD RID: 941
			// (get) Token: 0x060010A9 RID: 4265 RVA: 0x0003C14B File Offset: 0x0003A34B
			// (set) Token: 0x060010AA RID: 4266 RVA: 0x0003C153 File Offset: 0x0003A353
			internal bool IsInDeferredDrag
			{
				get
				{
					return this._isInDeferredDrag;
				}
				set
				{
					this._isInDeferredDrag = value;
				}
			}

			// Token: 0x0400085D RID: 2141
			internal global::System.Windows.Controls.ScrollViewer _scrollOwner;

			// Token: 0x0400085E RID: 2142
			internal global::System.Windows.Size _extent = default(global::System.Windows.Size);

			// Token: 0x0400085F RID: 2143
			internal global::System.Windows.Size _viewport = default(global::System.Windows.Size);

			// Token: 0x04000860 RID: 2144
			internal global::System.Windows.Vector _offset = default(global::System.Windows.Vector);

			// Token: 0x04000861 RID: 2145
			internal global::System.Windows.Vector _oldOffset = default(global::System.Windows.Vector);

			// Token: 0x04000862 RID: 2146
			internal bool _canHorizontallyScroll;

			// Token: 0x04000863 RID: 2147
			internal bool _canVerticallyScroll;

			// Token: 0x04000864 RID: 2148
			private bool _isInDeferredDrag;

			// Token: 0x04000865 RID: 2149
			private double _deferredDragOffset;

			// Token: 0x04000866 RID: 2150
			private global::Infragistics.Windows.Tiles.TilesPanelBase _panel;
		}

		// Token: 0x020001C0 RID: 448
		protected class TilesPanelUIElementCollection : global::System.Windows.Controls.UIElementCollection
		{
			// Token: 0x060010AB RID: 4267 RVA: 0x0003C15C File Offset: 0x0003A35C
			public TilesPanelUIElementCollection(global::Infragistics.Windows.Tiles.TilesPanelBase tilesPanel, global::System.Windows.UIElement visualParent, global::System.Windows.FrameworkElement logicalParent) : base(visualParent, logicalParent)
			{
				this._tilesPanel = tilesPanel;
			}

			// Token: 0x060010AC RID: 4268 RVA: 0x0003C170 File Offset: 0x0003A370
			public override int Add(global::System.Windows.UIElement element)
			{
				int result = base.Add(element);
				this.RaiseCollectionChanged();
				return result;
			}

			// Token: 0x060010AD RID: 4269 RVA: 0x0003C18C File Offset: 0x0003A38C
			public override void Clear()
			{
				base.Clear();
				this.RaiseCollectionChanged();
			}

			// Token: 0x060010AE RID: 4270 RVA: 0x0003C19A File Offset: 0x0003A39A
			public override global::System.Collections.IEnumerator GetEnumerator()
			{
				return base.GetEnumerator();
			}

			// Token: 0x060010AF RID: 4271 RVA: 0x0003C1A2 File Offset: 0x0003A3A2
			public override void Insert(int index, global::System.Windows.UIElement element)
			{
				base.Insert(index, element);
				this.RaiseCollectionChanged();
			}

			// Token: 0x060010B0 RID: 4272 RVA: 0x0003C1B2 File Offset: 0x0003A3B2
			public override void Remove(global::System.Windows.UIElement element)
			{
				base.Remove(element);
				this.RaiseCollectionChanged();
			}

			// Token: 0x060010B1 RID: 4273 RVA: 0x0003C1C1 File Offset: 0x0003A3C1
			public override void RemoveAt(int index)
			{
				base.RemoveAt(index);
				this.RaiseCollectionChanged();
			}

			// Token: 0x060010B2 RID: 4274 RVA: 0x0003C1D0 File Offset: 0x0003A3D0
			public override void RemoveRange(int index, int count)
			{
				base.RemoveRange(index, count);
				this.RaiseCollectionChanged();
			}

			// Token: 0x170003AE RID: 942
			// (get) Token: 0x060010B3 RID: 4275 RVA: 0x0003C1E0 File Offset: 0x0003A3E0
			internal global::Infragistics.Windows.Tiles.TilesPanelBase TilesPanelBase
			{
				get
				{
					return this._tilesPanel;
				}
			}

			// Token: 0x14000023 RID: 35
			// (add) Token: 0x060010B4 RID: 4276 RVA: 0x0003C1E8 File Offset: 0x0003A3E8
			// (remove) Token: 0x060010B5 RID: 4277 RVA: 0x0003C220 File Offset: 0x0003A420
			internal event global::System.EventHandler<global::System.EventArgs> CollectionChanged;

			// Token: 0x060010B6 RID: 4278 RVA: 0x0003C255 File Offset: 0x0003A455
			private void RaiseCollectionChanged()
			{
				if (this._tilesPanel.IsItemsHost)
				{
					return;
				}
				if (this.CollectionChanged != null)
				{
					this.CollectionChanged(this, global::System.EventArgs.Empty);
				}
			}

			// Token: 0x04000867 RID: 2151
			private global::Infragistics.Windows.Tiles.TilesPanelBase _tilesPanel;
		}
	}
}
