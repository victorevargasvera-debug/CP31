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
	// Token: 0x020001EB RID: 491
	public abstract class TilesPanelBase : global::Infragistics.Windows.Virtualization.RecyclingItemsPanel, global::System.Windows.Controls.Primitives.IScrollInfo, global::Infragistics.Windows.Scrolling.IDeferredScrollPanel
	{
		// Token: 0x060011C0 RID: 4544 RVA: 0x0003F098 File Offset: 0x0003D298
		protected TilesPanelBase() : base(true)
		{
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0003F0F8 File Offset: 0x0003D2F8
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

		// Token: 0x060011C2 RID: 4546 RVA: 0x0003F28C File Offset: 0x0003D48C
		protected override void BringIndexIntoView(int index)
		{
			this.GetManager().BringIndexIntoView(index);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0003F29C File Offset: 0x0003D49C
		protected override global::System.Windows.Controls.UIElementCollection CreateUIElementCollection(global::System.Windows.FrameworkElement logicalParent)
		{
			global::Infragistics.Windows.Tiles.TilesPanelBase.TilesPanelUIElementCollection tilesPanelUIElementCollection = new global::Infragistics.Windows.Tiles.TilesPanelBase.TilesPanelUIElementCollection(this, this, logicalParent);
			tilesPanelUIElementCollection.CollectionChanged += this.OnCollectionChanged;
			return tilesPanelUIElementCollection;
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0003F2C5 File Offset: 0x0003D4C5
		protected override bool GetCanCleanupItem(int itemIndex)
		{
			return !this.IsAnimationInProgress && this.GetCanCleanupItemHelper(itemIndex) && (itemIndex == 0 || this.GetCanCleanupItemHelper(itemIndex - 1));
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0003F2EC File Offset: 0x0003D4EC
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

		// Token: 0x060011C6 RID: 4550 RVA: 0x0003F37C File Offset: 0x0003D57C
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

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x060011C7 RID: 4551 RVA: 0x0003F47E File Offset: 0x0003D67E
		protected override bool HasLogicalOrientation
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x0003F481 File Offset: 0x0003D681
		protected override bool IsOkToCleanupUnusedGeneratedElements
		{
			get
			{
				return !this.IsAnimationInProgress && this._dragManager == null;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x0003F498 File Offset: 0x0003D698
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

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x0003F4E6 File Offset: 0x0003D6E6
		protected override int MaximumUnusedGeneratedItemsToKeep
		{
			get
			{
				return global::System.Math.Min(this.GetManager().CountOfItemsToBeArranged, 100);
			}
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0003F4FA File Offset: 0x0003D6FA
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			this.ClearMeasureBypassedMap();
			this._isInMeasure = true;
			this._lastMeasureSize = availableSize;
			this._lastDesiredSize = this.MeasureHelper(availableSize);
			this._isInMeasure = false;
			return this._lastDesiredSize;
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x0003F52C File Offset: 0x0003D72C
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

		// Token: 0x060011CD RID: 4557 RVA: 0x0003F820 File Offset: 0x0003DA20
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			if (this._ignoreChildSizeChanges)
			{
				this._childSizeChanged = true;
				return;
			}
			global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem;
			if (!this._isInMeasure && this._measureBypassedMap != null && this._measureBypassedMap.Count > 0 && this._measureBypassedMap.TryGetValue(child, out layoutItem) && layoutItem.Container == child)
			{
				layoutItem.OnAsyncDesiredSizeChange();
			}
			base.OnChildDesiredSizeChanged(child);
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0003F881 File Offset: 0x0003DA81
		protected override void OnItemsChanged(object sender, global::System.Windows.Controls.Primitives.ItemsChangedEventArgs args)
		{
			base.OnItemsChanged(sender, args);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0003F88B File Offset: 0x0003DA8B
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

		// Token: 0x060011D0 RID: 4560 RVA: 0x0003F8B8 File Offset: 0x0003DAB8
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

		// Token: 0x060011D1 RID: 4561 RVA: 0x0003F8FE File Offset: 0x0003DAFE
		internal void OnEndDrag(global::System.Windows.FrameworkElement container)
		{
			container.ClearValue(global::Infragistics.Windows.Tiles.TilesPanelBase.IsDraggingPropertyKey);
			this.OnTileDragEnd(container);
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x0003F912 File Offset: 0x0003DB12
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

		// Token: 0x060011D3 RID: 4563 RVA: 0x0003F937 File Offset: 0x0003DB37
		protected override void OnNewElementRealized(global::System.Windows.UIElement element, int index)
		{
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0003F939 File Offset: 0x0003DB39
		protected override void OnVisualChildrenChanged(global::System.Windows.DependencyObject visualAdded, global::System.Windows.DependencyObject visualRemoved)
		{
			base.OnVisualChildrenChanged(visualAdded, visualRemoved);
			if (visualRemoved != null)
			{
				this.GetManager().RemoveContainer(visualRemoved);
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x0003F952 File Offset: 0x0003DB52
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

		// Token: 0x060011D6 RID: 4566 RVA: 0x0003F969 File Offset: 0x0003DB69
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static int GetColumn(global::System.Windows.DependencyObject elem)
		{
			return (int)elem.GetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.ColumnProperty);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0003F97B File Offset: 0x0003DB7B
		public static void SetColumn(global::System.Windows.DependencyObject elem, int value)
		{
			elem.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.ColumnProperty, value);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0003F98E File Offset: 0x0003DB8E
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static int GetColumnSpan(global::System.Windows.DependencyObject elem)
		{
			return (int)elem.GetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.ColumnSpanProperty);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x0003F9A0 File Offset: 0x0003DBA0
		public static void SetColumnSpan(global::System.Windows.DependencyObject elem, int value)
		{
			elem.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.ColumnSpanProperty, value);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0003F9B3 File Offset: 0x0003DBB3
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static float GetColumnWeight(global::System.Windows.DependencyObject d)
		{
			return (float)d.GetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.ColumnWeightProperty);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0003F9C5 File Offset: 0x0003DBC5
		public static void SetColumnWeight(global::System.Windows.DependencyObject d, float value)
		{
			d.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.ColumnWeightProperty, value);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x0003F9D8 File Offset: 0x0003DBD8
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static bool GetIsDragging(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.IsDraggingProperty);
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x0003F9EA File Offset: 0x0003DBEA
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static bool GetIsSwapTarget(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.IsSwapTargetProperty);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0003F9FC File Offset: 0x0003DBFC
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static int GetRow(global::System.Windows.DependencyObject elem)
		{
			return (int)elem.GetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.RowProperty);
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0003FA0E File Offset: 0x0003DC0E
		public static void SetRow(global::System.Windows.DependencyObject elem, int value)
		{
			elem.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.RowProperty, value);
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x0003FA21 File Offset: 0x0003DC21
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static int GetRowSpan(global::System.Windows.DependencyObject elem)
		{
			return (int)elem.GetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.RowSpanProperty);
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x0003FA33 File Offset: 0x0003DC33
		public static void SetRowSpan(global::System.Windows.DependencyObject elem, int value)
		{
			elem.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.RowSpanProperty, value);
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x0003FA46 File Offset: 0x0003DC46
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static float GetRowWeight(global::System.Windows.DependencyObject d)
		{
			return (float)d.GetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.RowWeightProperty);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0003FA58 File Offset: 0x0003DC58
		public static void SetRowWeight(global::System.Windows.DependencyObject d, float value)
		{
			d.SetValue(global::Infragistics.Windows.Tiles.TilesPanelBase.RowWeightProperty, value);
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x0003FA6B File Offset: 0x0003DC6B
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsAnimationInProgress
		{
			get
			{
				return this._activeAnimationCount > 0;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x0003FA76 File Offset: 0x0003DC76
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x0003FA83 File Offset: 0x0003DC83
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

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x0003FA91 File Offset: 0x0003DC91
		protected int ScrollIndexOfFirstArrangedItem
		{
			get
			{
				return this.GetManager().ScrollIndexOfFirstArrangedItem;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x0003FA9E File Offset: 0x0003DC9E
		protected int ScrollIndexOfLastArrangedItem
		{
			get
			{
				return this.GetManager().ScrollIndexOfLastArrangedItem;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x0003FAAB File Offset: 0x0003DCAB
		internal global::System.Windows.Size LastMeasureSize
		{
			get
			{
				return this._lastMeasureSize;
			}
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x0003FAB4 File Offset: 0x0003DCB4
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

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x0003FAF6 File Offset: 0x0003DCF6
		// (set) Token: 0x060011EC RID: 4588 RVA: 0x0003FAFE File Offset: 0x0003DCFE
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

		// Token: 0x060011ED RID: 4589 RVA: 0x0003FB14 File Offset: 0x0003DD14
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

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x0003FB56 File Offset: 0x0003DD56
		// (set) Token: 0x060011EF RID: 4591 RVA: 0x0003FB5E File Offset: 0x0003DD5E
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

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x0003FB71 File Offset: 0x0003DD71
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

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x0003FB8D File Offset: 0x0003DD8D
		internal global::System.Windows.Size TileAreaSize
		{
			get
			{
				return this._tileAreaSize;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x0003FB95 File Offset: 0x0003DD95
		private bool IsScrollClient
		{
			get
			{
				return this._scrollDataInfo != null && this._scrollDataInfo._scrollOwner != null;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x0003FBB4 File Offset: 0x0003DDB4
		internal double MaxHorizontalOffset
		{
			get
			{
				return this.GetManager().ScrollMaxOffset.X;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x0003FBD4 File Offset: 0x0003DDD4
		internal double MaxVerticalOffset
		{
			get
			{
				return this.GetManager().ScrollMaxOffset.Y;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x0003FBF4 File Offset: 0x0003DDF4
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

		// Token: 0x060011F6 RID: 4598 RVA: 0x0003FC01 File Offset: 0x0003DE01
		public global::System.Windows.Rect GetInViewRect(global::System.Windows.DependencyObject container)
		{
			return this.GetManager().GetInViewRect(container);
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0003FC10 File Offset: 0x0003DE10
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

		// Token: 0x060011F8 RID: 4600 RVA: 0x0003FC5A File Offset: 0x0003DE5A
		internal global::System.Windows.Controls.Primitives.IItemContainerGenerator GetGenerator()
		{
			return base.ActiveItemContainerGenerator;
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x0003FC64 File Offset: 0x0003DE64
		internal global::System.Windows.Controls.Primitives.GeneratorPosition GetGeneratorPositionFromItemIndex(int itemIndex, out int childIndex)
		{
			global::System.Windows.Controls.Primitives.IItemContainerGenerator generator = this.GetGenerator();
			global::System.Windows.Controls.Primitives.GeneratorPosition result = (generator != null) ? generator.GeneratorPositionFromIndex(itemIndex) : new global::System.Windows.Controls.Primitives.GeneratorPosition(-1, itemIndex + 1);
			childIndex = ((result.Offset == 0) ? result.Index : (result.Index + 1));
			return result;
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0003FCAC File Offset: 0x0003DEAC
		internal void OnChildMeasureBypassed(global::Infragistics.Windows.Internal.TileManager.LayoutItem item)
		{
			if (!this._isInMeasure)
			{
				return;
			}
			global::System.Windows.UIElement uielement = item.Container as global::System.Windows.UIElement;
			if (uielement != null)
			{
				if (this._measureBypassedMap == null)
				{
					this._measureBypassedMap = new global::System.Collections.Generic.Dictionary<global::System.Windows.UIElement, global::Infragistics.Windows.Internal.TileManager.LayoutItem>();
				}
				if (this._measureBypassedMap.Count == 0)
				{
					base.LayoutUpdated -= this.OnLayoutUpdated;
					base.LayoutUpdated += this.OnLayoutUpdated;
				}
				this._measureBypassedMap[uielement] = item;
			}
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0003FD22 File Offset: 0x0003DF22
		protected internal double GetActualMinimizedAreaExtent()
		{
			return this.GetManager().MinimizedAreaActualExtent;
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0003FD2F File Offset: 0x0003DF2F
		protected global::Infragistics.Windows.Tiles.ItemInfoBase[] GetItemsInView()
		{
			return this.GetManager().GetItemsInView();
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0003FD3C File Offset: 0x0003DF3C
		protected object GetItemAtScrollIndex(int scrollIndex)
		{
			return this.GetManager().GetItemAtScrollIndex(scrollIndex);
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0003FD4A File Offset: 0x0003DF4A
		protected internal global::System.Windows.Rect GetMaximizedTileArea(bool clipToOverallTileArea)
		{
			return this.GetManager().GetMaximizedModeTileArea(global::Infragistics.Windows.Internal.TileManager.TileArea.MaximizedTiles, clipToOverallTileArea);
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0003FD59 File Offset: 0x0003DF59
		protected internal global::Infragistics.Windows.Tiles.ITileConstraints GetMaximizedTileAreaConstraints()
		{
			return this.GetManager().GetMaximizedModeTileAreaConstraints(global::Infragistics.Windows.Internal.TileManager.TileArea.MaximizedTiles);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0003FD67 File Offset: 0x0003DF67
		protected internal global::System.Windows.Rect GetMinimizedTileArea(bool clipToOverallTileArea)
		{
			return this.GetManager().GetMaximizedModeTileArea(global::Infragistics.Windows.Internal.TileManager.TileArea.MinimizedTiles, clipToOverallTileArea);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0003FD76 File Offset: 0x0003DF76
		protected internal global::Infragistics.Windows.Tiles.ITileConstraints GetMinimizedTileAreaConstraints()
		{
			return this.GetManager().GetMaximizedModeTileAreaConstraints(global::Infragistics.Windows.Internal.TileManager.TileArea.MinimizedTiles);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0003FD84 File Offset: 0x0003DF84
		protected double GetOffsetFromScrollPosition(int scrollPosition)
		{
			return this.GetManager().GetOffsetFromScrollPosition(scrollPosition);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0003FD92 File Offset: 0x0003DF92
		protected int GetScrollPositionFromOffset(double offset)
		{
			return this.GetManager().GetScrollPositionFromOffset(offset);
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0003FDA0 File Offset: 0x0003DFA0
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

		// Token: 0x06001205 RID: 4613 RVA: 0x0003FE34 File Offset: 0x0003E034
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

		// Token: 0x06001206 RID: 4614 RVA: 0x0003FE60 File Offset: 0x0003E060
		protected internal global::System.Windows.Rect GetTileArea()
		{
			global::System.Windows.Rect result = new global::System.Windows.Rect(this.TileAreaSize);
			global::System.Windows.Thickness tileAreaPadding = this.GetTileAreaPadding();
			result.Offset(tileAreaPadding.Left, tileAreaPadding.Top);
			return result;
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0003FE97 File Offset: 0x0003E097
		protected int GetTotalColumnsDisplayed()
		{
			return this.GetManager().TotalColumnsDisplayed;
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0003FEA4 File Offset: 0x0003E0A4
		protected int GetTotalRowsDisplayed()
		{
			return this.GetManager().TotalRowsDisplayed;
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0003FEB1 File Offset: 0x0003E0B1
		protected bool IsContainerInArrangeCache(global::System.Windows.DependencyObject container)
		{
			return (this._dragManager != null && this._dragManager.Tile == container) || this.GetManager().IsContainerInArrangeCache(container);
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0003FED8 File Offset: 0x0003E0D8
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

		// Token: 0x0600120B RID: 4619 RVA: 0x0003FF14 File Offset: 0x0003E114
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

		// Token: 0x0600120C RID: 4620 RVA: 0x00040021 File Offset: 0x0003E221
		protected internal virtual bool CanSwapContainers(global::System.Windows.FrameworkElement dragItemContainer, global::Infragistics.Windows.Tiles.ItemInfoBase dragItemInfo, global::System.Windows.FrameworkElement swapTargetContainer, global::Infragistics.Windows.Tiles.ItemInfoBase swapTargetItemInfo)
		{
			return dragItemInfo.GetIsMaximized() == swapTargetItemInfo.GetIsMaximized();
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00040032 File Offset: 0x0003E232
		protected internal virtual global::Infragistics.Windows.Tiles.AllowTileDragging GetAllowTileDragging(global::System.Windows.FrameworkElement container, global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo)
		{
			return global::Infragistics.Windows.Tiles.AllowTileDragging.No;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x00040035 File Offset: 0x0003E235
		protected internal virtual bool GetCanDropContainer(global::System.Windows.FrameworkElement container, global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo, global::Infragistics.Windows.Tiles.TileState newState, int newLogicalIndex)
		{
			return true;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x00040038 File Offset: 0x0003E238
		protected internal virtual global::Infragistics.Windows.Tiles.ITileConstraints GetContainerConstraints(global::System.Windows.DependencyObject container, global::Infragistics.Windows.Tiles.TileState state)
		{
			return null;
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x0004003B File Offset: 0x0003E23B
		protected internal virtual global::Infragistics.Windows.Tiles.TileState GetContainerState(global::System.Windows.DependencyObject container)
		{
			return global::Infragistics.Windows.Tiles.TileState.Normal;
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0004003E File Offset: 0x0003E23E
		protected internal virtual global::Infragistics.Windows.Tiles.ITileConstraints GetDefaultConstraints(global::Infragistics.Windows.Tiles.TileState state)
		{
			return null;
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00040041 File Offset: 0x0003E241
		protected internal virtual global::System.Windows.Size GetDefaultMinimumItemSize()
		{
			return new global::System.Windows.Size(16.0, 12.0);
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0004005A File Offset: 0x0003E25A
		protected internal virtual global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior GetExplicitLayoutTileSizeBehavior()
		{
			return global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior.SynchronizeTileWidthsAndHeights;
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0004005D File Offset: 0x0003E25D
		protected internal virtual double GetExplicitMinimizedAreaExtent()
		{
			return 0.0;
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x00040068 File Offset: 0x0003E268
		protected internal virtual global::System.Windows.HorizontalAlignment GetHorizontalTileAreaAlignment()
		{
			return global::System.Windows.HorizontalAlignment.Left;
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0004006B File Offset: 0x0003E26B
		protected internal virtual double GetInterTileAreaSpacing()
		{
			return 0.0;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00040076 File Offset: 0x0003E276
		protected internal virtual double GetInterTileSpacing(bool vertical, global::Infragistics.Windows.Tiles.TileState state)
		{
			return 0.0;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00040081 File Offset: 0x0003E281
		protected internal virtual bool GetIsInDeferredScrollingMode()
		{
			return false;
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00040084 File Offset: 0x0003E284
		protected internal virtual bool GetIsInMaximizedMode()
		{
			return false;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00040087 File Offset: 0x0003E287
		protected internal virtual global::Infragistics.Windows.Internal.TileManager GetManager()
		{
			if (this._defaultManager == null)
			{
				this._defaultManager = new global::Infragistics.Windows.Internal.TileManager();
				this._defaultManager.InitializePanel(this);
			}
			return this._defaultManager;
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x000400AE File Offset: 0x0003E2AE
		protected internal virtual global::Infragistics.Collections.ObservableCollectionExtended<object> GetMaximizedItems()
		{
			if (this._defaultMaximizedItems == null)
			{
				this._defaultMaximizedItems = new global::Infragistics.Collections.ObservableCollectionExtended<object>();
			}
			return this._defaultMaximizedItems;
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x000400C9 File Offset: 0x0003E2C9
		protected internal virtual int GetMaximizedItemLimit()
		{
			return 0;
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x000400CC File Offset: 0x0003E2CC
		protected internal virtual global::Infragistics.Windows.Tiles.MaximizedTileLocation GetMaximizedTileLocation()
		{
			return global::Infragistics.Windows.Tiles.MaximizedTileLocation.Left;
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x000400CF File Offset: 0x0003E2CF
		protected internal virtual global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder GetMaximizedTileLayoutOrder()
		{
			return global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder.VerticalWithLastTileFill;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x000400D2 File Offset: 0x0003E2D2
		protected internal virtual int GetMaxColumns()
		{
			return 0;
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x000400D5 File Offset: 0x0003E2D5
		protected internal virtual int GetMaxRows()
		{
			return 0;
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x000400D8 File Offset: 0x0003E2D8
		protected internal virtual int GetMinColumns()
		{
			return 1;
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x000400DB File Offset: 0x0003E2DB
		protected internal virtual int GetMinRows()
		{
			return 1;
		}

		// Token: 0x06001223 RID: 4643
		protected abstract global::System.Windows.Media.Animation.DoubleAnimationBase GetRepositionAnimation();

		// Token: 0x06001224 RID: 4644 RVA: 0x000400DE File Offset: 0x0003E2DE
		protected internal virtual global::System.Windows.Media.Animation.DoubleAnimationBase GetResizeAnimation()
		{
			return null;
		}

		// Token: 0x06001225 RID: 4645
		protected internal abstract bool GetShouldAnimate();

		// Token: 0x06001226 RID: 4646 RVA: 0x000400E1 File Offset: 0x0003E2E1
		protected internal virtual bool GetShowAllTiles()
		{
			return false;
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x000400E4 File Offset: 0x0003E2E4
		protected internal virtual bool GetShowAllMinimizedTiles()
		{
			return false;
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x000400E7 File Offset: 0x0003E2E7
		protected internal virtual bool GetSupportsDeferredScrolling(global::System.Windows.Controls.Orientation scrollBarOrientation, global::System.Windows.Controls.ScrollViewer scrollViewer)
		{
			return false;
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x000400EC File Offset: 0x0003E2EC
		public virtual global::System.Windows.Size? GetSynchronizedSize()
		{
			return null;
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00040104 File Offset: 0x0003E304
		protected internal virtual global::System.Windows.Thickness GetTileAreaPadding()
		{
			return default(global::System.Windows.Thickness);
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0004011A File Offset: 0x0003E31A
		protected internal virtual global::Infragistics.Windows.Tiles.TileLayoutOrder GetTileLayoutOrder()
		{
			return global::Infragistics.Windows.Tiles.TileLayoutOrder.Vertical;
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0004011D File Offset: 0x0003E31D
		protected internal virtual global::System.Windows.VerticalAlignment GetVerticalTileAreaAlignment()
		{
			return global::System.Windows.VerticalAlignment.Top;
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00040120 File Offset: 0x0003E320
		protected virtual void OnAnimationEnded(global::System.Windows.DependencyObject container)
		{
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00040122 File Offset: 0x0003E322
		protected internal virtual void OnContainersSwapped(global::System.Windows.FrameworkElement dragItemContainer, global::Infragistics.Windows.Tiles.ItemInfoBase dragItemInfo, global::System.Windows.FrameworkElement swapTargetContainer, global::Infragistics.Windows.Tiles.ItemInfoBase swapTargetItemInfo)
		{
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00040124 File Offset: 0x0003E324
		protected internal virtual void OnDeferredScrollingStarted(global::System.Windows.Controls.Primitives.Thumb thumb, global::System.Windows.Controls.Orientation scrollBarOrientation)
		{
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00040126 File Offset: 0x0003E326
		protected internal virtual void OnDeferredScrollingEnded(bool cancelled)
		{
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00040128 File Offset: 0x0003E328
		protected internal virtual void OnDeferredScrollOffsetChanged(double newDeferredScrollPosition)
		{
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0004012A File Offset: 0x0003E32A
		protected virtual void OnItemsInViewChanged()
		{
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0004012C File Offset: 0x0003E32C
		protected virtual void OnTileDragStart(global::System.Windows.FrameworkElement container)
		{
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0004012E File Offset: 0x0003E32E
		protected virtual void OnTileDragEnd(global::System.Windows.FrameworkElement container)
		{
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00040130 File Offset: 0x0003E330
		protected virtual void UpdateTransform(global::System.Windows.DependencyObject container, global::System.Windows.Rect originalRect, global::System.Windows.Rect currentRect, global::System.Windows.Rect targetRect, global::System.Windows.Vector offset, double resizeFactor, bool calledFromArrange)
		{
			global::System.Windows.UIElement uielement = container as global::System.Windows.UIElement;
			if (uielement != null)
			{
				uielement.Arrange(global::System.Windows.Rect.Offset(currentRect, offset));
			}
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00040155 File Offset: 0x0003E355
		protected internal virtual void VerifyMaximizedItems()
		{
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00040157 File Offset: 0x0003E357
		private void AdjustHorizontalOffset(double adjustment)
		{
			this.SetHorizontalOffset(((global::System.Windows.Controls.Primitives.IScrollInfo)this).HorizontalOffset + adjustment);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00040167 File Offset: 0x0003E367
		private void AdjustVerticalOffset(double adjustment)
		{
			this.SetVerticalOffset(((global::System.Windows.Controls.Primitives.IScrollInfo)this).VerticalOffset + adjustment);
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00040178 File Offset: 0x0003E378
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

		// Token: 0x0600123A RID: 4666 RVA: 0x00040724 File Offset: 0x0003E924
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

		// Token: 0x0600123B RID: 4667 RVA: 0x00040784 File Offset: 0x0003E984
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

		// Token: 0x0600123C RID: 4668 RVA: 0x0004081A File Offset: 0x0003EA1A
		private static double ApplyFactor(double original, double target, double factor)
		{
			if (factor == 1.0)
			{
				return target;
			}
			return original + (target - original) * factor;
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x00040831 File Offset: 0x0003EA31
		private void ClearMeasureBypassedMap()
		{
			if (this._measureBypassedMap != null)
			{
				this._measureBypassedMap.Clear();
				base.LayoutUpdated -= this.OnLayoutUpdated;
			}
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00040858 File Offset: 0x0003EA58
		private void OnAnimationCompleted(object sender, global::System.EventArgs e)
		{
			this.UnhookAnimation(sender as global::System.Windows.Media.Animation.AnimationClock);
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00040866 File Offset: 0x0003EA66
		private void OnArrangeComplete()
		{
			if (this._inViewItemsHaveChanged)
			{
				this._inViewItemsHaveChanged = false;
				this.OnItemsInViewChanged();
			}
			base.TriggerCleanupOfUnusedGeneratedItems(true);
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00040884 File Offset: 0x0003EA84
		private void OnCollectionChanged(object sender, global::System.EventArgs e)
		{
			if (base.IsItemsHost || !base.IsInitialized)
			{
				return;
			}
			this.GetManager().OnItemsChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x000408A8 File Offset: 0x0003EAA8
		private static void OnConstraintPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Media.Visual visual = d as global::System.Windows.Media.Visual;
			global::Infragistics.Windows.Tiles.TilesPanelBase tilesPanelBase = (visual != null) ? (global::System.Windows.Media.VisualTreeHelper.GetParent(visual) as global::Infragistics.Windows.Tiles.TilesPanelBase) : null;
			if (tilesPanelBase != null)
			{
				tilesPanelBase.InvalidateMeasure();
			}
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x000408D8 File Offset: 0x0003EAD8
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

		// Token: 0x06001243 RID: 4675 RVA: 0x0004093D File Offset: 0x0003EB3D
		private void OnLayoutUpdated(object sender, global::System.EventArgs e)
		{
			base.LayoutUpdated -= this.OnLayoutUpdated;
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::System.Action(delegate()
			{
				this.ClearMeasureBypassedMap();
			}));
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x0004096A File Offset: 0x0003EB6A
		private void ProcessFactorChange()
		{
			this._processFactorChangePending = null;
			this.ArrangeHelper(false, false, false);
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x0004097D File Offset: 0x0003EB7D
		private void ProcessAllAnimationsEnded()
		{
			if (!this._isRestartingAnimations)
			{
				this.ArrangeHelper(false, true, false);
				this.OnArrangeComplete();
			}
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00040998 File Offset: 0x0003EB98
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

		// Token: 0x06001247 RID: 4679 RVA: 0x000409DC File Offset: 0x0003EBDC
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

		// Token: 0x06001248 RID: 4680 RVA: 0x00040A98 File Offset: 0x0003EC98
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

		// Token: 0x06001249 RID: 4681 RVA: 0x00040B54 File Offset: 0x0003ED54
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

		// Token: 0x0600124A RID: 4682 RVA: 0x00040BD0 File Offset: 0x0003EDD0
		private static bool ValidateColumnRow(object objVal)
		{
			int num = (int)objVal;
			return num >= 0 || num == -1;
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00040BF0 File Offset: 0x0003EDF0
		private static bool ValidateColumnRowSpan(object objVal)
		{
			int num = (int)objVal;
			return num >= 1 || num == 0;
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00040C10 File Offset: 0x0003EE10
		private static bool ValidateColumnRowWeight(object objVal)
		{
			float num = (float)objVal;
			return !float.IsNaN(num) && !float.IsInfinity(num) && num >= 0f;
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00040C44 File Offset: 0x0003EE44
		internal static bool ValidateMaximizedTileLimit(object objVal)
		{
			int num = (int)objVal;
			return num >= 0;
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00040C5F File Offset: 0x0003EE5F
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x00040C76 File Offset: 0x0003EE76
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

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x00040C8C File Offset: 0x0003EE8C
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x00040CA3 File Offset: 0x0003EEA3
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

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00040CB9 File Offset: 0x0003EEB9
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

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x00040CDD File Offset: 0x0003EEDD
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

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x00040D04 File Offset: 0x0003EF04
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

		// Token: 0x06001255 RID: 4693 RVA: 0x00040D58 File Offset: 0x0003EF58
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineDown()
		{
			this.AdjustVerticalOffset(this.GetManager().ScrollSmallChange.Y);
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00040D80 File Offset: 0x0003EF80
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineLeft()
		{
			this.AdjustHorizontalOffset(-this.GetManager().ScrollSmallChange.X);
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00040DA8 File Offset: 0x0003EFA8
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineRight()
		{
			this.AdjustHorizontalOffset(this.GetManager().ScrollSmallChange.X);
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00040DD0 File Offset: 0x0003EFD0
		void global::System.Windows.Controls.Primitives.IScrollInfo.LineUp()
		{
			this.AdjustVerticalOffset(-this.GetManager().ScrollSmallChange.Y);
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00040DF7 File Offset: 0x0003EFF7
		global::System.Windows.Rect global::System.Windows.Controls.Primitives.IScrollInfo.MakeVisible(global::System.Windows.Media.Visual visual, global::System.Windows.Rect rectangle)
		{
			if (this.IsScrollClient)
			{
				return this.GetManager().MakeVisible(visual, rectangle);
			}
			return rectangle;
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00040E10 File Offset: 0x0003F010
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelDown()
		{
			this.AdjustVerticalOffset((double)global::System.Windows.SystemParameters.WheelScrollLines * this.GetManager().ScrollSmallChange.Y);
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00040E40 File Offset: 0x0003F040
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelLeft()
		{
			this.AdjustHorizontalOffset((double)(-(double)global::System.Windows.SystemParameters.WheelScrollLines) * this.GetManager().ScrollSmallChange.X);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00040E70 File Offset: 0x0003F070
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelRight()
		{
			this.AdjustHorizontalOffset((double)global::System.Windows.SystemParameters.WheelScrollLines * this.GetManager().ScrollSmallChange.X);
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00040EA0 File Offset: 0x0003F0A0
		void global::System.Windows.Controls.Primitives.IScrollInfo.MouseWheelUp()
		{
			this.AdjustVerticalOffset((double)(-(double)global::System.Windows.SystemParameters.WheelScrollLines) * this.GetManager().ScrollSmallChange.Y);
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00040ED0 File Offset: 0x0003F0D0
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageDown()
		{
			this.AdjustVerticalOffset(this.GetManager().ScrollLargeChange.Y);
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00040EF8 File Offset: 0x0003F0F8
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageLeft()
		{
			this.AdjustHorizontalOffset(-this.GetManager().ScrollLargeChange.X);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00040F20 File Offset: 0x0003F120
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageRight()
		{
			this.AdjustHorizontalOffset(this.GetManager().ScrollLargeChange.X);
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00040F48 File Offset: 0x0003F148
		void global::System.Windows.Controls.Primitives.IScrollInfo.PageUp()
		{
			this.AdjustVerticalOffset(-this.GetManager().ScrollLargeChange.Y);
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x00040F6F File Offset: 0x0003F16F
		// (set) Token: 0x06001263 RID: 4707 RVA: 0x00040F86 File Offset: 0x0003F186
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

		// Token: 0x06001264 RID: 4708 RVA: 0x00040FA8 File Offset: 0x0003F1A8
		void global::System.Windows.Controls.Primitives.IScrollInfo.SetHorizontalOffset(double offset)
		{
			this.SetHorizontalOffset(offset);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00040FB1 File Offset: 0x0003F1B1
		void global::System.Windows.Controls.Primitives.IScrollInfo.SetVerticalOffset(double offset)
		{
			this.SetVerticalOffset(offset);
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x00040FBC File Offset: 0x0003F1BC
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

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x00041011 File Offset: 0x0003F211
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

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x00041035 File Offset: 0x0003F235
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

		// Token: 0x06001269 RID: 4713 RVA: 0x0004105C File Offset: 0x0003F25C
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

		// Token: 0x0600126A RID: 4714 RVA: 0x000410B8 File Offset: 0x0003F2B8
		void global::Infragistics.Windows.Scrolling.IDeferredScrollPanel.OnThumbDragStart(global::System.Windows.Controls.Primitives.Thumb thumb, global::System.Windows.Controls.Orientation scrollBarOrientation)
		{
			if (this.GetIsInDeferredScrollingMode())
			{
				this.ScrollDataInfo.IsInDeferredDrag = true;
				this.ScrollDataInfo.DeferredDragOffset = ((this.ScrollBarOrientation == global::System.Windows.Controls.Orientation.Horizontal) ? this.ScrollDataInfo._offset.X : this.ScrollDataInfo._offset.Y);
				this.OnDeferredScrollingStarted(thumb, scrollBarOrientation);
			}
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00041116 File Offset: 0x0003F316
		bool global::Infragistics.Windows.Scrolling.IDeferredScrollPanel.SupportsDeferredScrolling(global::System.Windows.Controls.Orientation scrollBarOrientation, global::System.Windows.Controls.ScrollViewer scrollViewer)
		{
			return this.GetSupportsDeferredScrolling(scrollBarOrientation, scrollViewer);
		}

		// Token: 0x04000964 RID: 2404
		private global::System.Windows.Media.Animation.AnimationClock _repositionClock;

		// Token: 0x04000965 RID: 2405
		private global::System.Windows.Media.Animation.AnimationClock _resizeClock;

		// Token: 0x04000966 RID: 2406
		private global::System.Windows.Size _lastMeasureSize;

		// Token: 0x04000967 RID: 2407
		private global::System.Windows.Size _lastArrangeSize;

		// Token: 0x04000968 RID: 2408
		private global::System.Windows.Size _lastDesiredSize;

		// Token: 0x04000969 RID: 2409
		private global::System.Windows.Size _lastMeasureSizeAdjusted = global::System.Windows.Size.Empty;

		// Token: 0x0400096A RID: 2410
		private global::System.Windows.Size _tileAreaSize;

		// Token: 0x0400096B RID: 2411
		private global::Infragistics.Windows.Internal.TileManager _defaultManager;

		// Token: 0x0400096C RID: 2412
		private global::Infragistics.Windows.Tiles.TileDragManager _dragManager;

		// Token: 0x0400096D RID: 2413
		private global::System.Windows.Threading.DispatcherOperation _asynchAnimationStart;

		// Token: 0x0400096E RID: 2414
		private int _activeAnimationCount;

		// Token: 0x0400096F RID: 2415
		private int _arrangeCount;

		// Token: 0x04000970 RID: 2416
		private int _measureCount;

		// Token: 0x04000971 RID: 2417
		private global::System.Windows.Vector _lastScrollOffset;

		// Token: 0x04000972 RID: 2418
		private global::System.DateTime _lastMeasureTimeStamp = global::System.DateTime.Now;

		// Token: 0x04000973 RID: 2419
		private global::System.Windows.Size _itemsControlLastRenderSize;

		// Token: 0x04000974 RID: 2420
		private bool _bypassArrangeVerification;

		// Token: 0x04000975 RID: 2421
		private bool _bypassArrange;

		// Token: 0x04000976 RID: 2422
		private bool _ignoreChildSizeChanges;

		// Token: 0x04000977 RID: 2423
		private bool _childSizeChanged;

		// Token: 0x04000978 RID: 2424
		private bool _inViewItemsHaveChanged;

		// Token: 0x04000979 RID: 2425
		private bool _isRestartingAnimations;

		// Token: 0x0400097A RID: 2426
		private double _repositionFactor = (double)global::Infragistics.Windows.Tiles.TilesPanelBase.RepositionFactorProperty.DefaultMetadata.DefaultValue;

		// Token: 0x0400097B RID: 2427
		private double _resizeFactor = (double)global::Infragistics.Windows.Tiles.TilesPanelBase.ResizeFactorProperty.DefaultMetadata.DefaultValue;

		// Token: 0x0400097C RID: 2428
		private global::System.Collections.Generic.Dictionary<global::System.Windows.UIElement, global::Infragistics.Windows.Internal.TileManager.LayoutItem> _measureBypassedMap;

		// Token: 0x0400097D RID: 2429
		internal bool _isInMeasure;

		// Token: 0x0400097E RID: 2430
		private global::Infragistics.Collections.ObservableCollectionExtended<object> _defaultMaximizedItems;

		// Token: 0x0400097F RID: 2431
		public static readonly global::System.Windows.DependencyProperty ColumnProperty = global::System.Windows.DependencyProperty.RegisterAttached("Column", typeof(int), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.OnConstraintPropertyChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.ValidateColumnRow));

		// Token: 0x04000980 RID: 2432
		public static readonly global::System.Windows.DependencyProperty ColumnSpanProperty = global::System.Windows.DependencyProperty.RegisterAttached("ColumnSpan", typeof(int), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(1, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.OnConstraintPropertyChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.ValidateColumnRowSpan));

		// Token: 0x04000981 RID: 2433
		public static readonly global::System.Windows.DependencyProperty ColumnWeightProperty = global::System.Windows.DependencyProperty.RegisterAttached("ColumnWeight", typeof(float), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(0f, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.OnConstraintPropertyChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.ValidateColumnRowWeight));

		// Token: 0x04000982 RID: 2434
		internal static readonly global::System.Windows.DependencyPropertyKey IsDraggingPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsDragging", typeof(bool), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000983 RID: 2435
		public static readonly global::System.Windows.DependencyProperty IsDraggingProperty = global::Infragistics.Windows.Tiles.TilesPanelBase.IsDraggingPropertyKey.DependencyProperty;

		// Token: 0x04000984 RID: 2436
		internal static readonly global::System.Windows.DependencyPropertyKey IsSwapTargetPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsSwapTarget", typeof(bool), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000985 RID: 2437
		public static readonly global::System.Windows.DependencyProperty IsSwapTargetProperty = global::Infragistics.Windows.Tiles.TilesPanelBase.IsSwapTargetPropertyKey.DependencyProperty;

		// Token: 0x04000986 RID: 2438
		public static readonly global::System.Windows.DependencyProperty RowProperty = global::System.Windows.DependencyProperty.RegisterAttached("Row", typeof(int), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.OnConstraintPropertyChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.ValidateColumnRow));

		// Token: 0x04000987 RID: 2439
		public static readonly global::System.Windows.DependencyProperty RowSpanProperty = global::System.Windows.DependencyProperty.RegisterAttached("RowSpan", typeof(int), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(1, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.OnConstraintPropertyChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.ValidateColumnRowSpan));

		// Token: 0x04000988 RID: 2440
		public static readonly global::System.Windows.DependencyProperty RowWeightProperty = global::System.Windows.DependencyProperty.RegisterAttached("RowWeight", typeof(float), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(0f, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.OnConstraintPropertyChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.ValidateColumnRowWeight));

		// Token: 0x04000989 RID: 2441
		internal static readonly global::System.Windows.DependencyProperty RepositionFactorProperty = global::System.Windows.DependencyProperty.Register("RepositionFactor", typeof(double), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(1.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.OnRepositionFactorChanged)));

		// Token: 0x0400098A RID: 2442
		internal static readonly global::System.Windows.DependencyProperty ResizeFactorProperty = global::System.Windows.DependencyProperty.Register("ResizeFactor", typeof(double), typeof(global::Infragistics.Windows.Tiles.TilesPanelBase), new global::System.Windows.FrameworkPropertyMetadata(1.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Tiles.TilesPanelBase.OnResizeFactorChanged)));

		// Token: 0x0400098B RID: 2443
		private global::Infragistics.Windows.Tiles.TilesPanelBase.ScrollData _scrollDataInfo;

		// Token: 0x0400098C RID: 2444
		private global::System.Windows.Threading.DispatcherOperation _processFactorChangePending;

		// Token: 0x020001EC RID: 492
		internal class GenerationCache : global::System.IDisposable
		{
			// Token: 0x0600126E RID: 4718 RVA: 0x000413DC File Offset: 0x0003F5DC
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

			// Token: 0x0600126F RID: 4719 RVA: 0x00041490 File Offset: 0x0003F690
			internal void GenerateElements()
			{
				this._manager.GenerateElements(this);
			}

			// Token: 0x06001270 RID: 4720 RVA: 0x000414A0 File Offset: 0x0003F6A0
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

			// Token: 0x06001271 RID: 4721 RVA: 0x00041583 File Offset: 0x0003F783
			private void ReleaseGeneratorStart()
			{
				if (this._currentGeneratorStart != null)
				{
					this._currentGeneratorStart.Dispose();
					this._currentGeneratorStart = null;
				}
			}

			// Token: 0x06001272 RID: 4722 RVA: 0x000415A0 File Offset: 0x0003F7A0
			private void StartGenerator(int indexToGen)
			{
				this.ReleaseGeneratorStart();
				this._currentGeneratorPositionIndex = indexToGen;
				global::System.Windows.Controls.Primitives.GeneratorPosition generatorPositionFromItemIndex = this._panel.GetGeneratorPositionFromItemIndex(indexToGen, out this._nextChildElementIndex);
				this._currentGeneratorStart = this._generator.StartAt(generatorPositionFromItemIndex, global::System.Windows.Controls.Primitives.GeneratorDirection.Forward, true);
			}

			// Token: 0x06001273 RID: 4723 RVA: 0x000415E1 File Offset: 0x0003F7E1
			public void Dispose()
			{
				this.ReleaseGeneratorStart();
				if (this._generator != null)
				{
					this._panel.EndGeneration();
				}
				this._desiredSize = this._manager.EndGeneration(this);
			}

			// Token: 0x0400098D RID: 2445
			internal global::Infragistics.Windows.Tiles.TilesPanelBase _panel;

			// Token: 0x0400098E RID: 2446
			private global::Infragistics.Windows.Internal.TileManager _manager;

			// Token: 0x0400098F RID: 2447
			private global::System.Collections.IList _childElements;

			// Token: 0x04000990 RID: 2448
			private int _childElementCount;

			// Token: 0x04000991 RID: 2449
			private global::System.Windows.Size _constraint;

			// Token: 0x04000992 RID: 2450
			private global::System.Windows.Size _measureConstraint = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);

			// Token: 0x04000993 RID: 2451
			private global::System.Windows.Controls.Primitives.IItemContainerGenerator _generator;

			// Token: 0x04000994 RID: 2452
			private global::System.IDisposable _currentGeneratorStart;

			// Token: 0x04000995 RID: 2453
			internal global::System.Collections.ArrayList _itemsExpectedToBeGenerated;

			// Token: 0x04000996 RID: 2454
			private int _currentGeneratorPositionIndex;

			// Token: 0x04000997 RID: 2455
			private int _nextChildElementIndex;

			// Token: 0x04000998 RID: 2456
			private global::System.Windows.Controls.ItemsControl _itemsControl;

			// Token: 0x04000999 RID: 2457
			internal global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _previousGridBagLayoutNormalModeOverall;

			// Token: 0x0400099A RID: 2458
			internal global::System.Collections.Generic.Dictionary<global::System.Windows.DependencyObject, global::Infragistics.Windows.Internal.TileManager.LayoutItem> _previousItemsToBeArrangedTempCache;

			// Token: 0x0400099B RID: 2459
			internal global::Infragistics.Windows.Helpers.HashSet _newItemsToBeArrangedTempCache;

			// Token: 0x0400099C RID: 2460
			internal global::System.Windows.Size _desiredSize;

			// Token: 0x0400099D RID: 2461
			internal bool _requiresAnotherLayoutPass;
		}

		// Token: 0x020001ED RID: 493
		internal class ScrollData
		{
			// Token: 0x06001274 RID: 4724 RVA: 0x0004160E File Offset: 0x0003F80E
			internal ScrollData(global::Infragistics.Windows.Tiles.TilesPanelBase panel)
			{
				this._panel = panel;
			}

			// Token: 0x06001275 RID: 4725 RVA: 0x00041650 File Offset: 0x0003F850
			internal void Reset()
			{
				global::System.Windows.Vector offset = this._offset;
				this._offset = default(global::System.Windows.Vector);
				this._extent = default(global::System.Windows.Size);
				this._viewport = default(global::System.Windows.Size);
				this._panel.GetManager().OnScrollOffsetChanged(this._offset, offset);
			}

			// Token: 0x06001276 RID: 4726 RVA: 0x000416A0 File Offset: 0x0003F8A0
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

			// Token: 0x06001277 RID: 4727 RVA: 0x000417B0 File Offset: 0x0003F9B0
			private bool VerifyOffset()
			{
				double x = global::System.Math.Max(global::System.Math.Min(this._offset.X, this._panel.MaxHorizontalOffset), 0.0);
				double y = global::System.Math.Max(global::System.Math.Min(this._offset.Y, this._panel.MaxVerticalOffset), 0.0);
				global::System.Windows.Vector oldOffset = this._oldOffset;
				this._offset = new global::System.Windows.Vector(x, y);
				return !global::Infragistics.Windows.Internal.TileManager.AreClose(this._offset.X, oldOffset.X) || !global::Infragistics.Windows.Internal.TileManager.AreClose(this._offset.Y, oldOffset.Y);
			}

			// Token: 0x1700041D RID: 1053
			// (get) Token: 0x06001278 RID: 4728 RVA: 0x0004185A File Offset: 0x0003FA5A
			// (set) Token: 0x06001279 RID: 4729 RVA: 0x00041862 File Offset: 0x0003FA62
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

			// Token: 0x1700041E RID: 1054
			// (get) Token: 0x0600127A RID: 4730 RVA: 0x0004186B File Offset: 0x0003FA6B
			// (set) Token: 0x0600127B RID: 4731 RVA: 0x00041873 File Offset: 0x0003FA73
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

			// Token: 0x0400099E RID: 2462
			internal global::System.Windows.Controls.ScrollViewer _scrollOwner;

			// Token: 0x0400099F RID: 2463
			internal global::System.Windows.Size _extent = default(global::System.Windows.Size);

			// Token: 0x040009A0 RID: 2464
			internal global::System.Windows.Size _viewport = default(global::System.Windows.Size);

			// Token: 0x040009A1 RID: 2465
			internal global::System.Windows.Vector _offset = default(global::System.Windows.Vector);

			// Token: 0x040009A2 RID: 2466
			internal global::System.Windows.Vector _oldOffset = default(global::System.Windows.Vector);

			// Token: 0x040009A3 RID: 2467
			internal bool _canHorizontallyScroll;

			// Token: 0x040009A4 RID: 2468
			internal bool _canVerticallyScroll;

			// Token: 0x040009A5 RID: 2469
			private bool _isInDeferredDrag;

			// Token: 0x040009A6 RID: 2470
			private double _deferredDragOffset;

			// Token: 0x040009A7 RID: 2471
			private global::Infragistics.Windows.Tiles.TilesPanelBase _panel;
		}

		// Token: 0x020001EE RID: 494
		protected class TilesPanelUIElementCollection : global::System.Windows.Controls.UIElementCollection
		{
			// Token: 0x0600127C RID: 4732 RVA: 0x0004187C File Offset: 0x0003FA7C
			public TilesPanelUIElementCollection(global::Infragistics.Windows.Tiles.TilesPanelBase tilesPanel, global::System.Windows.UIElement visualParent, global::System.Windows.FrameworkElement logicalParent) : base(visualParent, logicalParent)
			{
				this._tilesPanel = tilesPanel;
			}

			// Token: 0x0600127D RID: 4733 RVA: 0x00041890 File Offset: 0x0003FA90
			public override int Add(global::System.Windows.UIElement element)
			{
				int result = base.Add(element);
				this.RaiseCollectionChanged();
				return result;
			}

			// Token: 0x0600127E RID: 4734 RVA: 0x000418AC File Offset: 0x0003FAAC
			public override void Clear()
			{
				base.Clear();
				this.RaiseCollectionChanged();
			}

			// Token: 0x0600127F RID: 4735 RVA: 0x000418BA File Offset: 0x0003FABA
			public override global::System.Collections.IEnumerator GetEnumerator()
			{
				return base.GetEnumerator();
			}

			// Token: 0x06001280 RID: 4736 RVA: 0x000418C2 File Offset: 0x0003FAC2
			public override void Insert(int index, global::System.Windows.UIElement element)
			{
				base.Insert(index, element);
				this.RaiseCollectionChanged();
			}

			// Token: 0x06001281 RID: 4737 RVA: 0x000418D2 File Offset: 0x0003FAD2
			public override void Remove(global::System.Windows.UIElement element)
			{
				base.Remove(element);
				this.RaiseCollectionChanged();
			}

			// Token: 0x06001282 RID: 4738 RVA: 0x000418E1 File Offset: 0x0003FAE1
			public override void RemoveAt(int index)
			{
				base.RemoveAt(index);
				this.RaiseCollectionChanged();
			}

			// Token: 0x06001283 RID: 4739 RVA: 0x000418F0 File Offset: 0x0003FAF0
			public override void RemoveRange(int index, int count)
			{
				base.RemoveRange(index, count);
				this.RaiseCollectionChanged();
			}

			// Token: 0x1700041F RID: 1055
			// (get) Token: 0x06001284 RID: 4740 RVA: 0x00041900 File Offset: 0x0003FB00
			internal global::Infragistics.Windows.Tiles.TilesPanelBase TilesPanelBase
			{
				get
				{
					return this._tilesPanel;
				}
			}

			// Token: 0x14000025 RID: 37
			// (add) Token: 0x06001285 RID: 4741 RVA: 0x00041908 File Offset: 0x0003FB08
			// (remove) Token: 0x06001286 RID: 4742 RVA: 0x00041940 File Offset: 0x0003FB40
			internal event global::System.EventHandler<global::System.EventArgs> CollectionChanged;

			// Token: 0x06001287 RID: 4743 RVA: 0x00041975 File Offset: 0x0003FB75
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

			// Token: 0x040009A8 RID: 2472
			private global::Infragistics.Windows.Tiles.TilesPanelBase _tilesPanel;
		}
	}
}
