using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Controls.Layouts.Primitives;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Selection;
using Infragistics.Windows.Tiles;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001AB RID: 427
	public class TileManager : global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer
	{
		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x000303D7 File Offset: 0x0002E5D7
		public global::Infragistics.Windows.Tiles.TilesPanelBase Panel
		{
			get
			{
				return this._panel;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x000303DF File Offset: 0x0002E5DF
		internal global::System.Windows.Vector ArrangeOffset
		{
			get
			{
				return this._arrangeOffset;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x000303E7 File Offset: 0x0002E5E7
		internal global::System.Windows.Vector ArrangeOffsetForMaxmizedTiles
		{
			get
			{
				return this._arrangeOffsetForMaxmizedTiles;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x000303EF File Offset: 0x0002E5EF
		internal int CountOfItemsToBeArranged
		{
			get
			{
				return this._itemsToBeArranged.Count;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x000303FC File Offset: 0x0002E5FC
		internal int ScrollIndexOfFirstArrangedItem
		{
			get
			{
				return this._scrollPosition;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00030404 File Offset: 0x0002E604
		internal global::System.Collections.IList Items
		{
			get
			{
				if (this._itemsControl != null)
				{
					return this._itemsControl.Items;
				}
				return this._panel.Children;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x00030425 File Offset: 0x0002E625
		internal double MinimizedAreaActualExtent
		{
			get
			{
				return this._minimizedAreaActualExtent;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x0003042D File Offset: 0x0002E62D
		internal int ScrollIndexOfLastArrangedItem
		{
			get
			{
				return this._scrollPositionOfLastArrangedItem;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x00030435 File Offset: 0x0002E635
		internal global::System.Windows.Vector ScrollLargeChange
		{
			get
			{
				return this._scrollLargeChange;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x0003043D File Offset: 0x0002E63D
		internal global::System.Windows.Vector ScrollMaxOffset
		{
			get
			{
				return this._scrollMaxOffset;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x00030445 File Offset: 0x0002E645
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x00030450 File Offset: 0x0002E650
		internal int ScrollPosition
		{
			get
			{
				return this._scrollPosition;
			}
			set
			{
				if (value != this._scrollPosition)
				{
					double offsetFromScrollPosition = this.GetOffsetFromScrollPosition(value);
					global::Infragistics.Windows.Tiles.TilesPanelBase.ScrollData scrollDataInfo = this.Panel.ScrollDataInfo;
					if (this._scrollTilesHorizontally)
					{
						scrollDataInfo._offset = new global::System.Windows.Vector(offsetFromScrollPosition, scrollDataInfo._offset.Y);
					}
					else
					{
						scrollDataInfo._offset = new global::System.Windows.Vector(scrollDataInfo._offset.X, offsetFromScrollPosition);
					}
					scrollDataInfo.VerifyScrollData(scrollDataInfo._viewport, scrollDataInfo._extent);
					this.Panel.InvalidateMeasure();
				}
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x000304CF File Offset: 0x0002E6CF
		internal global::System.Windows.Vector ScrollSmallChange
		{
			get
			{
				return this._scrollSmallChange;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x000304D7 File Offset: 0x0002E6D7
		internal bool ScrollTilesHorizontally
		{
			get
			{
				return this._scrollTilesHorizontally;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x000304DF File Offset: 0x0002E6DF
		internal bool ScrollTilesVertically
		{
			get
			{
				return this._scrollTilesVertically;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x000304E7 File Offset: 0x0002E6E7
		internal global::Infragistics.Windows.Internal.TileManager.ScrollManagerSparseArray SparseArray
		{
			get
			{
				return this._sparseArray;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x000304EF File Offset: 0x0002E6EF
		internal int TotalColumnsDisplayed
		{
			get
			{
				return this._totalColumnsDisplayed;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x000304F7 File Offset: 0x0002E6F7
		internal int TotalRowsDisplayed
		{
			get
			{
				return this._totalRowsDisplayed;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x000304FF File Offset: 0x0002E6FF
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager GridBagLayoutNormal
		{
			get
			{
				if (this._gridBagLayoutNormal == null)
				{
					this._gridBagLayoutNormal = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager();
				}
				return this._gridBagLayoutNormal;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0003051A File Offset: 0x0002E71A
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager GridBagLayoutNormalModeOverall
		{
			get
			{
				if (this._gridBagLayoutNormalModeOverall == null)
				{
					this._gridBagLayoutNormalModeOverall = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager();
				}
				return this._gridBagLayoutNormalModeOverall;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x00030535 File Offset: 0x0002E735
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager GridBagLayoutMaximized
		{
			get
			{
				if (this._gridBagLayoutMaximized == null)
				{
					this._gridBagLayoutMaximized = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager();
					this._gridBagLayoutMaximized.ExpandToFitHeight = true;
					this._gridBagLayoutMaximized.ExpandToFitWidth = true;
				}
				return this._gridBagLayoutMaximized;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x00030568 File Offset: 0x0002E768
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager GridBagLayoutMinimized
		{
			get
			{
				if (this._gridBagLayoutMinimized == null)
				{
					this._gridBagLayoutMinimized = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager();
				}
				return this._gridBagLayoutMinimized;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x00030584 File Offset: 0x0002E784
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager GridBagLayoutMaximizedModeOverall
		{
			get
			{
				if (this._gridBagLayoutMaximizedModeOverall == null)
				{
					this._gridBagLayoutMaximizedModeOverall = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager();
					this._gridBagLayoutMaximizedModeOverall.ExpandToFitHeight = true;
					this._gridBagLayoutMaximizedModeOverall.ExpandToFitWidth = true;
					this._gridBagLayoutMaximizedModeOverall.LayoutItems.Add(this.MaximizedTileArea, this.MaximizedTileArea);
					this._gridBagLayoutMaximizedModeOverall.LayoutItems.Add(this.MinimizedTileArea, this.MinimizedTileArea);
				}
				return this._gridBagLayoutMaximizedModeOverall;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x000305FC File Offset: 0x0002E7FC
		internal bool IsMaximizedAreaLeftOrRight
		{
			get
			{
				switch (this._maximizedTileLocation)
				{
				case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Left:
				case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Right:
					return true;
				default:
					return false;
				}
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x00030625 File Offset: 0x0002E825
		private global::Infragistics.Windows.Internal.TileManager.TileAreaLayoutItem MaximizedTileArea
		{
			get
			{
				if (this._maximizedTileArea == null)
				{
					this._maximizedTileArea = new global::Infragistics.Windows.Internal.TileManager.TileAreaLayoutItem(this, global::Infragistics.Windows.Internal.TileManager.TileArea.MaximizedTiles);
				}
				return this._maximizedTileArea;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x00030642 File Offset: 0x0002E842
		private global::Infragistics.Windows.Internal.TileManager.TileAreaLayoutItem MinimizedTileArea
		{
			get
			{
				if (this._minimizedTileArea == null)
				{
					this._minimizedTileArea = new global::Infragistics.Windows.Internal.TileManager.TileAreaLayoutItem(this, global::Infragistics.Windows.Internal.TileManager.TileArea.MinimizedTiles);
				}
				return this._minimizedTileArea;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x0003065F File Offset: 0x0002E85F
		private int NormalModeItemsPerRowColumn
		{
			get
			{
				return this._normalModeItemsPerRowColumn;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x00030667 File Offset: 0x0002E867
		private global::Infragistics.Windows.Tiles.ITileConstraints LastElementDefaultConstraints
		{
			get
			{
				return this._lastElementDefaultConstraints;
			}
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0003066F File Offset: 0x0002E86F
		public global::Infragistics.Windows.Tiles.ItemInfoBase GetItemInfo(object item)
		{
			return this.GetItemInfo(item, true, -1);
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0003067C File Offset: 0x0002E87C
		public global::Infragistics.Windows.Tiles.ItemInfoBase GetItemInfo(object item, bool createIfNotFound, int originalItemIndex)
		{
			global::Infragistics.Windows.Tiles.ItemInfoBase itemInfoBase;
			if (!this._itemInfoMap.TryGetValue(item, out itemInfoBase))
			{
				if (!createIfNotFound)
				{
					return null;
				}
				this.VerifyItemSlot(item, ref originalItemIndex);
				itemInfoBase = this.CreateItemInfo(item, originalItemIndex);
				this._itemInfoMap.Add(item, itemInfoBase);
			}
			return itemInfoBase;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x000306C0 File Offset: 0x0002E8C0
		public void SortItems(global::System.Collections.Generic.IComparer<global::Infragistics.Windows.Tiles.ItemInfoBase> comparer)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(comparer, "comparer");
			this.EnsureItemArrayIsAllocated();
			int count = this.Items.Count;
			if (count < 2)
			{
				return;
			}
			for (int i = 0; i < count; i++)
			{
				this.GetItem(i, false);
			}
			this.SparseArray.SortGeneric<global::Infragistics.Windows.Tiles.ItemInfoBase>(comparer);
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00030710 File Offset: 0x0002E910
		protected virtual global::Infragistics.Windows.Tiles.ItemInfoBase CreateItemInfo(object item, int index)
		{
			return new global::Infragistics.Windows.Tiles.ItemInfoBase(this, item, index);
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0003071A File Offset: 0x0002E91A
		internal static bool AreClose(double value1, double value2)
		{
			return value1 == value2 || global::System.Math.Abs(value1 - value2) < 1E-10;
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00030738 File Offset: 0x0002E938
		internal global::Infragistics.Windows.Selection.ScrollDirection BeginGeneration(global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache)
		{
			this._genCache = genCache;
			this._itemsInView.Clear();
			this._wasLastScrollableItemGened = false;
			this._defaultMinimunItemSize = this._panel.GetDefaultMinimumItemSize();
			bool isInMaximizedMode = this._isInMaximizedMode;
			this._isInMaximizedMode = this._panel.GetIsInMaximizedMode();
			global::System.Windows.Vector arrangeOffset = this._arrangeOffset;
			global::System.Windows.Vector arrangeOffsetForMaxmizedTiles = this._arrangeOffsetForMaxmizedTiles;
			if (this._isInMaximizedMode != isInMaximizedMode)
			{
				this._arrangeOffset = default(global::System.Windows.Vector);
				this._arrangeOffsetForMaxmizedTiles = default(global::System.Windows.Vector);
			}
			if (this._lastItemLocations != null)
			{
				int count = this._lastItemLocations.Count;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.Internal.TileManager.ItemRowColumnSizeInfo itemRowColumnSizeInfo = this._lastItemLocations[i];
					bool wasMaximized = itemRowColumnSizeInfo.WasMaximized;
					global::System.Windows.Vector offset = itemRowColumnSizeInfo.VerifyMaximizeState(arrangeOffset, arrangeOffsetForMaxmizedTiles);
					bool wasMaximized2 = itemRowColumnSizeInfo.WasMaximized;
					if (offset.X != 0.0 || offset.Y != 0.0 || wasMaximized != wasMaximized2)
					{
						global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = this.GetLayoutItem(itemRowColumnSizeInfo.Info.Item);
						if (layoutItem != null)
						{
							layoutItem.OffsetAllRects(offset);
							if (wasMaximized && !wasMaximized2 && layoutItem.Container != null)
							{
								layoutItem.Container.ClearValue(global::System.Windows.Controls.Panel.ZIndexProperty);
							}
						}
					}
				}
			}
			if (this._isInMaximizedMode)
			{
				this._maximizedTileLocation = this._panel.GetMaximizedTileLocation();
				this._maximizedTileLayoutOrder = this._panel.GetMaximizedTileLayoutOrder();
				this._explicitMinimizedAreaExtent = this._panel.GetExplicitMinimizedAreaExtent();
			}
			else
			{
				this._tileLayoutOrder = this._panel.GetTileLayoutOrder();
				this._explicitTileSizeBehavior = this._panel.GetExplicitLayoutTileSizeBehavior();
				this._synchronizedSize = this._panel.GetSynchronizedSize();
				if (this._synchronizedSize != null)
				{
					global::System.Windows.Size value = this._synchronizedSize.Value;
					if (double.IsNaN(value.Width) || double.IsInfinity(value.Width))
					{
						value.Width = 0.0;
					}
					if (double.IsNaN(value.Height) || double.IsInfinity(value.Height))
					{
						value.Height = 0.0;
					}
					this._synchronizedSize = new global::System.Windows.Size?(value);
				}
			}
			this.EnsureItemArrayIsAllocated();
			this.CreateExpectedItemsList(genCache);
			genCache._previousItemsToBeArrangedTempCache = new global::System.Collections.Generic.Dictionary<global::System.Windows.DependencyObject, global::Infragistics.Windows.Internal.TileManager.LayoutItem>();
			foreach (object obj in this._itemsToBeArranged)
			{
				global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem2 = (global::Infragistics.Windows.Internal.TileManager.LayoutItem)obj;
				global::System.Windows.DependencyObject container = layoutItem2.Container;
				if (container != null)
				{
					genCache._previousItemsToBeArrangedTempCache.Add(container, layoutItem2);
				}
			}
			genCache._newItemsToBeArrangedTempCache = new global::Infragistics.Windows.Helpers.HashSet();
			if (this._gridBagLayoutNormal != null)
			{
				this._gridBagLayoutNormal.LayoutItems.Clear();
			}
			if (this._gridBagLayoutNormalModeOverall != null)
			{
				genCache._previousGridBagLayoutNormalModeOverall = this._gridBagLayoutNormalModeOverall;
				this._gridBagLayoutNormalModeOverall = null;
			}
			if (this._gridBagLayoutMaximized != null)
			{
				this._gridBagLayoutMaximized.LayoutItems.Clear();
			}
			if (this._gridBagLayoutMinimized != null)
			{
				this._gridBagLayoutMinimized.LayoutItems.Clear();
			}
			if (this._scrollPosition < this._lastScrollPosition)
			{
				return global::Infragistics.Windows.Selection.ScrollDirection.Decrement;
			}
			return global::Infragistics.Windows.Selection.ScrollDirection.Increment;
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00030A70 File Offset: 0x0002EC70
		internal void BringIndexIntoView(int index)
		{
			global::System.Collections.IList items = this.Items;
			if (index < 0 || index >= items.Count)
			{
				throw new global::System.ArgumentOutOfRangeException("index");
			}
			object obj = items[index];
			if (obj == null)
			{
				return;
			}
			global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = this.GetItemInfo(obj, true, index);
			if (itemInfo == null)
			{
				return;
			}
			if (itemInfo.GetIsClosed())
			{
				return;
			}
			global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = this.GetLayoutItem(obj, null, false, false);
			if (layoutItem != null)
			{
				new global::System.Windows.Rect(this._panel.TileAreaSize);
				if (this._itemsInView.Contains(itemInfo))
				{
					global::System.Windows.FrameworkElement frameworkElement = layoutItem.Container as global::System.Windows.FrameworkElement;
					if (frameworkElement != null)
					{
						this.MakeVisible(frameworkElement, global::System.Windows.Rect.Empty);
						return;
					}
				}
			}
			if (itemInfo.OccupiesScrollPosition && (this._scrollTilesVertically || this._scrollTilesHorizontally))
			{
				double offsetFromScrollPosition = this.GetOffsetFromScrollPosition(itemInfo.ScrollPosition);
				if (this._scrollTilesHorizontally)
				{
					((global::System.Windows.Controls.Primitives.IScrollInfo)this._panel).SetHorizontalOffset(offsetFromScrollPosition);
				}
				else if (this._scrollTilesVertically)
				{
					((global::System.Windows.Controls.Primitives.IScrollInfo)this._panel).SetVerticalOffset(offsetFromScrollPosition);
				}
				this._panel.Measure(this._panel.LastMeasureSize);
			}
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00030B74 File Offset: 0x0002ED74
		internal global::System.Windows.Size EndGeneration(global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache)
		{
			if (this._synchLastScrollPosOperation == null && (this._lastScrollPosition != this._scrollPosition || this._lastScrollLogicalOffset != this._scrollLogicalOffset))
			{
				this._synchLastScrollPosOperation = this._panel.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.Utilities.MethodDelegate(this.SynchLastScrollPosition));
			}
			bool flag;
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager overallGridBagLayout = this.GetOverallGridBagLayout(out flag);
			this._minimizedAreaActualExtent = 0.0;
			global::System.Windows.Rect rect;
			overallGridBagLayout.LayoutContainer(this, overallGridBagLayout, out rect);
			global::System.Windows.Size lastMeasureSize = this._panel.LastMeasureSize;
			if (double.IsInfinity(lastMeasureSize.Height))
			{
				double height = this._panel.DesiredSize.Height;
				if (height > 0.0)
				{
					lastMeasureSize.Height = height;
				}
			}
			if (double.IsInfinity(lastMeasureSize.Width))
			{
				double width = this._panel.DesiredSize.Width;
				if (width > 0.0)
				{
					lastMeasureSize.Width = width;
				}
			}
			global::System.Windows.Rect rect2 = new global::System.Windows.Rect(lastMeasureSize);
			double? num = null;
			if (this._lastScrollPosition != this._scrollPosition && this._lastItemLocations != null)
			{
				bool flag2 = false;
				int count = this._lastItemLocations.Count;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.Internal.TileManager.ItemRowColumnSizeInfo itemRowColumnSizeInfo = this._lastItemLocations[i];
					global::Infragistics.Windows.Tiles.ItemInfoBase info = itemRowColumnSizeInfo.Info;
					if (info != null && !info.GetIsMaximized())
					{
						global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = this.GetLayoutItem(info.Item);
						if (layoutItem != null)
						{
							if (this._itemsToBeArranged.Exists(layoutItem))
							{
								int num2 = this._itemsInView.IndexOf(info);
								if (num2 >= 0)
								{
									if (!flag2)
									{
										global::System.Windows.Rect targetRect = itemRowColumnSizeInfo.TargetRect;
										global::System.Windows.Rect targetRect2 = layoutItem.TargetRect;
										if (flag)
										{
											num = new double?(targetRect.Top - targetRect2.Top);
										}
										else
										{
											num = new double?(targetRect.Left - targetRect2.Left);
										}
										if (global::Infragistics.CoreUtilities.AreClose(num.Value, 0.0))
										{
											num = null;
										}
										flag2 = true;
									}
								}
								else
								{
									layoutItem.SetTargetRect(itemRowColumnSizeInfo.TargetRect, false);
								}
							}
							else
							{
								layoutItem.SetTargetRect(itemRowColumnSizeInfo.TargetRect, false);
							}
							if (layoutItem.CurrentRectInternal != null)
							{
								layoutItem.SetOriginalRect(layoutItem.CurrentRectInternal.Value, false);
							}
							else
							{
								layoutItem.SetOriginalRect(itemRowColumnSizeInfo.TargetRect, false);
							}
						}
					}
				}
				if (num == null && !flag2)
				{
					if (flag)
					{
						if (!double.IsInfinity(lastMeasureSize.Height))
						{
							if (this._lastScrollPosition < this._scrollPosition)
							{
								num = new double?(lastMeasureSize.Height);
							}
							else
							{
								num = new double?(-lastMeasureSize.Height);
							}
						}
					}
					else if (!double.IsInfinity(lastMeasureSize.Width))
					{
						if (this._lastScrollPosition < this._scrollPosition)
						{
							num = new double?(lastMeasureSize.Width);
						}
						else
						{
							num = new double?(-lastMeasureSize.Width);
						}
					}
				}
			}
			if (num != null)
			{
				foreach (object obj in genCache._newItemsToBeArrangedTempCache)
				{
					global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem2 = (global::Infragistics.Windows.Internal.TileManager.LayoutItem)obj;
					global::System.Windows.Rect targetRect3 = layoutItem2.TargetRect;
					if (targetRect3.Width == 0.0 && targetRect3.Height == 0.0)
					{
						targetRect3 = new global::System.Windows.Rect(-10000.0, -10000.0, 100.0, 100.0);
						layoutItem2.SetTargetRect(targetRect3, false);
					}
					if (flag)
					{
						targetRect3.Offset(0.0, num.Value);
					}
					else
					{
						targetRect3.Offset(num.Value, 0.0);
					}
					layoutItem2.SetOriginalRect(targetRect3, false);
				}
			}
			foreach (global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem3 in genCache._previousItemsToBeArrangedTempCache.Values)
			{
				global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = this.GetItemInfo(layoutItem3.Item);
				global::System.Windows.Rect targetRect4 = layoutItem3.TargetRect;
				if (targetRect4.Width == 0.0)
				{
					if (this._itemsToBeArranged.Exists(layoutItem3))
					{
						this._itemsToBeArranged.Remove(layoutItem3);
					}
					int num3 = this._itemsInView.IndexOf(itemInfo);
					if (num3 >= 0)
					{
						this._itemsInView.RemoveAt(num3);
					}
				}
				else
				{
					if (num != null)
					{
						if (flag)
						{
							targetRect4.Offset(0.0, -num.Value);
						}
						else
						{
							targetRect4.Offset(-num.Value, 0.0);
						}
						layoutItem3.SetTargetRect(targetRect4, true);
						double num4 = (double)((num.Value > 0.0) ? 1 : -1);
						while (targetRect4.IntersectsWith(rect2))
						{
							if (flag)
							{
								targetRect4.Offset(0.0, -num4);
							}
							else
							{
								targetRect4.Offset(-num4, 0.0);
							}
							layoutItem3.SetTargetRect(targetRect4, true);
						}
					}
					if (targetRect4.IntersectsWith(rect2))
					{
						if (itemInfo != null && itemInfo.ScrollPosition < this._scrollPosition)
						{
							if (flag)
							{
								if (!double.IsInfinity(lastMeasureSize.Height))
								{
									targetRect4.Y = -global::System.Math.Min(global::System.Math.Abs(targetRect4.Bottom), lastMeasureSize.Height) - 1.0;
								}
							}
							else if (!double.IsInfinity(lastMeasureSize.Width))
							{
								targetRect4.X = -global::System.Math.Min(global::System.Math.Abs(targetRect4.Right), lastMeasureSize.Width) - 1.0;
							}
						}
						else if (flag)
						{
							if (!double.IsInfinity(lastMeasureSize.Height))
							{
								targetRect4.Y = global::System.Math.Max(global::System.Math.Abs(targetRect4.Y), 0.0) + lastMeasureSize.Height + 1.0;
							}
						}
						else if (!double.IsInfinity(lastMeasureSize.Width))
						{
							targetRect4.X = global::System.Math.Max(global::System.Math.Abs(targetRect4.X), 0.0) + lastMeasureSize.Width + 1.0;
						}
						if (targetRect4.IntersectsWith(rect2))
						{
							if (flag)
							{
								if (!double.IsInfinity(lastMeasureSize.Width))
								{
									if (targetRect4.X > rect2.Width / 2.0)
									{
										targetRect4.X = rect2.Right + 1.0;
									}
									else
									{
										targetRect4.X = -(targetRect4.Width + 1.0);
									}
								}
							}
							else if (!double.IsInfinity(lastMeasureSize.Height))
							{
								if (targetRect4.Y > rect2.Height / 2.0)
								{
									targetRect4.Y = rect2.Bottom + 1.0;
								}
								else
								{
									targetRect4.Y = -(targetRect4.Height + 1.0);
								}
							}
						}
						layoutItem3.SetTargetRect(targetRect4, true);
					}
				}
			}
			global::System.Collections.IList childElements = this._panel.ChildElements;
			int num5 = childElements.Count;
			if (num5 > this._itemsToBeArranged.Count)
			{
				for (int j = num5 - 1; j >= 0; j--)
				{
					global::System.Windows.UIElement uielement = childElements[j] as global::System.Windows.UIElement;
					if (uielement == null || uielement.Visibility == global::System.Windows.Visibility.Collapsed)
					{
						num5--;
					}
					else
					{
						global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem4 = this.GetLayoutItem(null, uielement, false, false);
						if (layoutItem4 != null && !this._itemsToBeArranged.Exists(layoutItem4))
						{
							this.AddItemToBeArranged(layoutItem4);
							if (num5 <= this._itemsToBeArranged.Count)
							{
								break;
							}
						}
					}
				}
			}
			global::System.Windows.Size size = rect.Size;
			global::System.Windows.Size tileAreaSize = this._panel.TileAreaSize;
			if (overallGridBagLayout.ExpandToFitHeight && !double.IsPositiveInfinity(tileAreaSize.Height))
			{
				size.Height = global::System.Math.Max(size.Height, tileAreaSize.Height);
			}
			if (overallGridBagLayout.ExpandToFitWidth && !double.IsPositiveInfinity(tileAreaSize.Width))
			{
				size.Width = global::System.Math.Max(size.Width, tileAreaSize.Width);
			}
			global::System.Windows.Size size2 = size;
			if (!double.IsPositiveInfinity(tileAreaSize.Height))
			{
				size2.Height = global::System.Math.Max(size2.Height, tileAreaSize.Height);
			}
			if (!double.IsPositiveInfinity(tileAreaSize.Width))
			{
				size2.Width = global::System.Math.Max(size2.Width, tileAreaSize.Width);
			}
			this._lastMeasureDesiredSize = size2;
			bool flag3 = this.UpdateScrollingInfo(overallGridBagLayout, size2, flag, false);
			if (flag3)
			{
				genCache._requiresAnotherLayoutPass = true;
			}
			this._lastElement = null;
			this._lastElementConstraints = null;
			this._lastElementDefaultConstraints = null;
			this._lastElementState = null;
			this._genCache = null;
			if (this._isInMaximizedMode && this._lastShowAllTiles)
			{
				switch (this._maximizedTileLocation)
				{
				case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Left:
				case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Right:
					size.Height = global::System.Math.Min(size.Height, this._panel.LastMeasureSize.Height);
					break;
				case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Top:
				case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Bottom:
					size.Width = global::System.Math.Min(size.Width, this._panel.LastMeasureSize.Width);
					break;
				}
			}
			return size;
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x0003151C File Offset: 0x0002F71C
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager GetOverallGridBagLayout(out bool isScrollingVertically)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutManager;
			if (this._isInMaximizedMode)
			{
				gridBagLayoutManager = this.GridBagLayoutMaximizedModeOverall;
				gridBagLayoutManager.InvalidateLayout();
				isScrollingVertically = this.IsMaximizedAreaLeftOrRight;
			}
			else
			{
				switch (this._tileLayoutOrder)
				{
				default:
					gridBagLayoutManager = this.GridBagLayoutNormal;
					break;
				case global::Infragistics.Windows.Tiles.TileLayoutOrder.VerticalVariable:
				case global::Infragistics.Windows.Tiles.TileLayoutOrder.HorizontalVariable:
					gridBagLayoutManager = this.GridBagLayoutNormalModeOverall;
					break;
				case global::Infragistics.Windows.Tiles.TileLayoutOrder.UseExplicitRowColumnOnTile:
					if (this._explicitTileSizeBehavior == global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior.SynchronizeTileWidthsAndHeights)
					{
						gridBagLayoutManager = this.GridBagLayoutNormal;
					}
					else
					{
						gridBagLayoutManager = this.GridBagLayoutNormalModeOverall;
					}
					break;
				}
				switch (this._tileLayoutOrder)
				{
				case global::Infragistics.Windows.Tiles.TileLayoutOrder.Horizontal:
				case global::Infragistics.Windows.Tiles.TileLayoutOrder.HorizontalVariable:
					isScrollingVertically = true;
					break;
				default:
					isScrollingVertically = false;
					break;
				}
			}
			return gridBagLayoutManager;
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x000315B8 File Offset: 0x0002F7B8
		internal void GenerateElements(global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache)
		{
			global::System.Windows.Rect rect = new global::System.Windows.Rect(this._panel.TileAreaSize);
			foreach (global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem in genCache._previousItemsToBeArrangedTempCache.Values)
			{
				global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = this.GetItemInfo(layoutItem.Item);
				if (itemInfo != null)
				{
					global::System.Windows.UIElement uielement = layoutItem.Container as global::System.Windows.UIElement;
					if (uielement != null && uielement.Visibility != global::System.Windows.Visibility.Collapsed && itemInfo.Index >= 0)
					{
						global::System.Windows.Rect rect2;
						if (layoutItem.CurrentRectInternal != null)
						{
							rect2 = layoutItem.CurrentRectInternal.Value;
							layoutItem.SetOriginalRect(rect2, false);
						}
						else
						{
							rect2 = layoutItem.TargetRect;
						}
						if (rect.IntersectsWith(rect2) || rect.IntersectsWith(layoutItem.TargetRect))
						{
							genCache.GenerateElement(itemInfo.Index);
						}
					}
				}
			}
			this._totalColumnsDisplayed = 0;
			this._totalRowsDisplayed = 0;
			if (this._isInMaximizedMode)
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutMaximizedModeOverall = this.GridBagLayoutMaximizedModeOverall;
				switch (this._maximizedTileLocation)
				{
				case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Top:
				case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Bottom:
					gridBagLayoutMaximizedModeOverall.InterItemSpacingHorizontal = 0.0;
					gridBagLayoutMaximizedModeOverall.InterItemSpacingVertical = this._panel.GetInterTileAreaSpacing();
					goto IL_164;
				}
				gridBagLayoutMaximizedModeOverall.InterItemSpacingHorizontal = this._panel.GetInterTileAreaSpacing();
				gridBagLayoutMaximizedModeOverall.InterItemSpacingVertical = 0.0;
				IL_164:
				this.GenerateMaximizedElements(genCache);
				this._wasLastScrollableItemGened = false;
				this.GenerateMinimizedElements(genCache);
				return;
			}
			this.GenerateNormalElements(genCache);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00031758 File Offset: 0x0002F958
		internal int GetCurrentColumn(global::Infragistics.Windows.Tiles.ItemInfoBase info)
		{
			return this.GetCurrenRowColumnHelper(info, true);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00031762 File Offset: 0x0002F962
		internal int GetCurrentRow(global::Infragistics.Windows.Tiles.ItemInfoBase info)
		{
			return this.GetCurrenRowColumnHelper(info, false);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0003176C File Offset: 0x0002F96C
		internal global::System.Windows.Rect GetInViewRect(global::System.Windows.DependencyObject container)
		{
			if (this._panel == null)
			{
				return global::System.Windows.Rect.Empty;
			}
			object key;
			if (!this._containerToItemMap.TryGetValue(container, out key))
			{
				return global::System.Windows.Rect.Empty;
			}
			global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem;
			if (!this._layoutItemMap.TryGetValue(key, out layoutItem))
			{
				return global::System.Windows.Rect.Empty;
			}
			global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = layoutItem.ItemInfo;
			if (itemInfo == null || !this._itemsInView.Contains(itemInfo))
			{
				return global::System.Windows.Rect.Empty;
			}
			global::System.Windows.Rect targetRect = layoutItem.TargetRect;
			global::System.Windows.Rect rect = new global::System.Windows.Rect(this._panel.TileAreaSize);
			global::System.Windows.Vector offsetVector;
			if (itemInfo.GetIsMaximized())
			{
				offsetVector = this.ArrangeOffsetForMaxmizedTiles;
			}
			else
			{
				offsetVector = this.ArrangeOffset;
			}
			targetRect.Offset(offsetVector);
			global::System.Windows.Rect result = global::System.Windows.Rect.Intersect(rect, targetRect);
			if (result.IsEmpty)
			{
				return result;
			}
			result.Offset(-targetRect.Left, -targetRect.Top);
			return result;
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0003183C File Offset: 0x0002FA3C
		internal object GetItem(int index, bool useRearrangedOrder)
		{
			if (useRearrangedOrder && index < this._sparseArray.Count)
			{
				global::Infragistics.Windows.Tiles.ItemInfoBase itemInfoBase = (global::Infragistics.Windows.Tiles.ItemInfoBase)this._sparseArray[index];
				if (itemInfoBase != null)
				{
					return itemInfoBase.Item;
				}
			}
			object obj = this.Items[index];
			this.EnsureItemArrayIsAllocated();
			if (this._itemsInOriginalOrder[index] == null)
			{
				this._itemsInOriginalOrder[index] = obj;
			}
			global::Infragistics.Windows.Tiles.ItemInfoBase itemInfoBase2 = (global::Infragistics.Windows.Tiles.ItemInfoBase)this._sparseArray[index];
			if (itemInfoBase2 == null)
			{
				itemInfoBase2 = this.GetItemInfo(obj);
				this._sparseArray[index] = itemInfoBase2;
			}
			if (useRearrangedOrder && itemInfoBase2 != null)
			{
				return itemInfoBase2.Item;
			}
			return obj;
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x000318E0 File Offset: 0x0002FAE0
		internal global::Infragistics.Windows.Tiles.ItemInfoBase GetItemAtScrollIndex(int scrollindex)
		{
			if (scrollindex < this._sparseArray.ScrollCount)
			{
				global::Infragistics.Windows.Tiles.ItemInfoBase itemAtScrollIndex = this._sparseArray.GetItemAtScrollIndex(scrollindex);
				if (itemAtScrollIndex != null)
				{
					return itemAtScrollIndex;
				}
			}
			int count = this.Items.Count;
			for (int i = scrollindex; i < count; i++)
			{
				object item = this.GetItem(i, true);
				if (item != null)
				{
					global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = this.GetItemInfo(item);
					if (this._sparseArray.GetScrollIndexOfItem(itemInfo) == scrollindex)
					{
						return itemInfo;
					}
				}
			}
			return null;
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0003194E File Offset: 0x0002FB4E
		internal global::Infragistics.Windows.Tiles.ItemInfoBase[] GetItemsInView()
		{
			return this._itemsInView.ToArray();
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0003195B File Offset: 0x0002FB5B
		internal global::System.Collections.IEnumerator GetItemsToBeArranged()
		{
			return this._itemsToBeArranged.GetEnumerator();
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00031968 File Offset: 0x0002FB68
		internal global::Infragistics.Windows.Internal.TileManager.LayoutItem GetLayoutItem(object item)
		{
			return this.GetLayoutItem(item, null, false, false);
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00031974 File Offset: 0x0002FB74
		internal global::Infragistics.Windows.Internal.TileManager.LayoutItem GetLayoutItem(object item, global::System.Windows.DependencyObject container, bool createIfNotFound, bool clearDimensions)
		{
			if (container == null)
			{
				container = this._panel.ContainerFromItem(item);
				if (container == null)
				{
					return null;
				}
			}
			if (container != null)
			{
				object obj;
				if (this._containerToItemMap.TryGetValue(container, out obj))
				{
					if (!object.Equals(obj, item))
					{
						if (item != null)
						{
							this._containerToItemMap[container] = item;
							global::Infragistics.Windows.Internal.TileManager.LayoutItem item2;
							if (this._layoutItemMap.TryGetValue(obj, out item2))
							{
								this._itemsToBeArranged.Remove(item2);
								if (this._genCache != null && this._genCache._previousItemsToBeArrangedTempCache.ContainsKey(container))
								{
									this._genCache._previousItemsToBeArrangedTempCache.Remove(container);
								}
							}
						}
						else
						{
							item = obj;
						}
					}
				}
				else if (item != null)
				{
					this._containerToItemMap.Add(container, item);
				}
			}
			global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem;
			if (!this._layoutItemMap.TryGetValue(item, out layoutItem))
			{
				if (!createIfNotFound)
				{
					return null;
				}
				layoutItem = new global::Infragistics.Windows.Internal.TileManager.LayoutItem(container, item, this);
				this._layoutItemMap.Add(item, layoutItem);
				this.RemoveDuplicateContainerRefs(layoutItem);
			}
			else if (container != null)
			{
				global::System.Windows.DependencyObject container2 = layoutItem.Container;
				layoutItem.InitializeContainer(container, clearDimensions);
				if (container != container2)
				{
					this.RemoveDuplicateContainerRefs(layoutItem);
				}
			}
			return layoutItem;
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00031A7C File Offset: 0x0002FC7C
		internal global::Infragistics.Windows.Internal.TileManager.LayoutItem GetLayoutItemFromPoint(global::System.Windows.Point ptRelativeToPanel, global::Infragistics.Windows.Internal.TileManager.LayoutItem bypassItem)
		{
			global::System.Windows.Thickness tileAreaPadding = this._panel.GetTileAreaPadding();
			ptRelativeToPanel.Offset(-tileAreaPadding.Left, -tileAreaPadding.Top);
			foreach (object obj in this._itemsToBeArranged)
			{
				global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = (global::Infragistics.Windows.Internal.TileManager.LayoutItem)obj;
				if (layoutItem != bypassItem && layoutItem.TargetRect.Contains(ptRelativeToPanel))
				{
					return layoutItem;
				}
			}
			return null;
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00031B14 File Offset: 0x0002FD14
		internal global::System.Collections.IEnumerator GetLayoutItemsToBeAnimated()
		{
			if (this._itemsToBeArranged == null || this._itemsToBeArranged.Count == 0)
			{
				return null;
			}
			return this._itemsToBeArranged.GetEnumerator();
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00031B38 File Offset: 0x0002FD38
		internal int GetLogicalIndexOfItem(object item, bool returnScrollPosition)
		{
			global::System.Collections.IList items = this.Items;
			global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = this.GetItemInfo(item);
			if (itemInfo == null)
			{
				return -1;
			}
			int num = this._sparseArray.IndexOf(itemInfo);
			if (num < 0)
			{
				this.EnsureItemArrayIsAllocated();
				int count = items.Count;
				int i = 0;
				while (i < count)
				{
					if (object.Equals(item, this.GetItem(i, true)))
					{
						if (returnScrollPosition)
						{
							return this._sparseArray.GetScrollIndexOfItem(itemInfo);
						}
						return i;
					}
					else
					{
						i++;
					}
				}
				return -1;
			}
			if (returnScrollPosition)
			{
				return this._sparseArray.GetScrollIndexOfItem(itemInfo);
			}
			return num;
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00031BC0 File Offset: 0x0002FDC0
		internal global::System.Windows.Rect GetMaximizedModeTileArea(global::Infragistics.Windows.Internal.TileManager.TileArea area, bool clipInsideTileArea)
		{
			if (this._panel == null)
			{
				return global::System.Windows.Rect.Empty;
			}
			global::System.Windows.Rect tileArea = this._panel.GetTileArea();
			if (this._isInMaximizedMode)
			{
				global::Infragistics.Windows.Internal.TileManager.TileAreaLayoutItem tileAreaLayoutItem = this.GetTileAreaLayoutItem(area);
				if (tileAreaLayoutItem != null)
				{
					global::System.Windows.Rect rect = tileAreaLayoutItem.Rect;
					rect.Offset(tileArea.Left, tileArea.Top);
					if (area == global::Infragistics.Windows.Internal.TileManager.TileArea.MaximizedTiles)
					{
						rect.Offset(this.ArrangeOffsetForMaxmizedTiles);
					}
					else
					{
						rect.Offset(this.ArrangeOffset);
					}
					if (clipInsideTileArea)
					{
						return global::System.Windows.Rect.Intersect(rect, tileArea);
					}
					return rect;
				}
			}
			return tileArea;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00031C43 File Offset: 0x0002FE43
		internal global::Infragistics.Windows.Tiles.ITileConstraints GetMaximizedModeTileAreaConstraints(global::Infragistics.Windows.Internal.TileManager.TileArea area)
		{
			if (this._isInMaximizedMode)
			{
				return this.GetTileAreaLayoutItem(area);
			}
			return null;
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00031C58 File Offset: 0x0002FE58
		internal double GetOffsetFromScrollPosition(int scrollPosition)
		{
			if (scrollPosition == 0)
			{
				return 0.0;
			}
			if (this._panel == null)
			{
				return 0.0;
			}
			int scrollCount = this._sparseArray.ScrollCount;
			if (this._isInMaximizedMode)
			{
				return (double)global::System.Math.Min(scrollPosition, global::System.Math.Max(scrollCount - 1, 0));
			}
			if (this._panel.GetShowAllTiles())
			{
				return 0.0;
			}
			switch (this._tileLayoutOrder)
			{
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.Vertical:
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.Horizontal:
			{
				int num = global::System.Math.Max(this.NormalModeItemsPerRowColumn, 1);
				return global::System.Math.Floor((double)global::System.Math.Min(this.SparseArray.ScrollCount - 1, scrollPosition) / (double)num);
			}
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.VerticalVariable:
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.HorizontalVariable:
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutNormalModeOverall = this.GridBagLayoutNormalModeOverall;
				int count = gridBagLayoutNormalModeOverall.LayoutItems.Count;
				if (count <= 0)
				{
					return 0.0;
				}
				if (scrollPosition >= this._scrollPosition && scrollPosition <= this._scrollPositionOfLastArrangedItem)
				{
					for (int i = 0; i < count; i++)
					{
						global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem tileRowColumnLayoutItem = gridBagLayoutNormalModeOverall.LayoutItems[i] as global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem;
						if (scrollPosition >= tileRowColumnLayoutItem.GetFirstScrollPosition() && scrollPosition <= tileRowColumnLayoutItem.GetLastScrollPosition())
						{
							return (double)tileRowColumnLayoutItem.ScrollOffset;
						}
					}
				}
				double num2 = global::System.Math.Max(this._variableAvgItemsPerRowColumn, 1.0);
				if (scrollPosition > this._scrollPositionOfLastArrangedItem)
				{
					return (double)((int)global::System.Math.Min((double)this._scrollLogicalOffsetOfLastArrangedItem + (double)(scrollPosition - this._scrollPositionOfLastArrangedItem) / num2, (double)this._variableTotalRowColmuns));
				}
				return (double)((int)global::System.Math.Max((double)this._scrollLogicalOffset - (double)(this._scrollPosition - scrollPosition) / num2, 0.0));
			}
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.UseExplicitRowColumnOnTile:
				return 0.0;
			default:
				return 0.0;
			}
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00031E00 File Offset: 0x00030000
		internal void GetResizeRange(global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo, out double maxDeltaLeft, out double maxDeltaRight, out double maxDeltaTop, out double maxDeltaBottom)
		{
			global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = this.GetLayoutItem(itemInfo.Item);
			if (layoutItem != null)
			{
				global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem2;
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager containingGridBagLayoutManager = this.GetContainingGridBagLayoutManager(layoutItem, out layoutItem2);
				if (containingGridBagLayoutManager != null)
				{
					object containerContext = (layoutItem2 != null) ? layoutItem2 : containingGridBagLayoutManager;
					containingGridBagLayoutManager.GetResizeRange(this, containerContext, layoutItem, out maxDeltaLeft, out maxDeltaRight, out maxDeltaTop, out maxDeltaBottom);
					return;
				}
			}
			maxDeltaLeft = 0.0;
			maxDeltaRight = 0.0;
			maxDeltaTop = 0.0;
			maxDeltaBottom = 0.0;
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00031E70 File Offset: 0x00030070
		internal int GetScrollPositionFromOffset(double offset)
		{
			if ((int)offset == 0)
			{
				return 0;
			}
			if (this._panel == null)
			{
				return 0;
			}
			int scrollCount = this._sparseArray.ScrollCount;
			if (this._isInMaximizedMode)
			{
				return global::System.Math.Min((int)offset, global::System.Math.Max(scrollCount - 1, 0));
			}
			if (this._panel.GetShowAllTiles())
			{
				return 0;
			}
			offset = global::System.Math.Floor(offset);
			switch (this._tileLayoutOrder)
			{
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.Vertical:
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.Horizontal:
			{
				int num = global::System.Math.Max(this.NormalModeItemsPerRowColumn, 1);
				return global::System.Math.Min(global::System.Math.Max(this.SparseArray.ScrollCount - 1, 0), num * (int)offset);
			}
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.VerticalVariable:
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.HorizontalVariable:
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutNormalModeOverall = this.GridBagLayoutNormalModeOverall;
				int count = gridBagLayoutNormalModeOverall.LayoutItems.Count;
				if (count <= 0)
				{
					return 0;
				}
				if ((int)offset >= this._scrollLogicalOffset && (int)offset < this._scrollLogicalOffset + count)
				{
					global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem tileRowColumnLayoutItem = gridBagLayoutNormalModeOverall.LayoutItems[(int)offset - this._scrollLogicalOffset] as global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem;
					return tileRowColumnLayoutItem.GetFirstScrollPosition();
				}
				double num2 = global::System.Math.Max(this._variableAvgItemsPerRowColumn, 1.0);
				if (this._scrollLogicalOffsetOfLastArrangedItem < (int)offset)
				{
					return (int)global::System.Math.Min((double)(this.SparseArray.ScrollCount - 1), (double)this._scrollPosition + (offset - (double)this._scrollLogicalOffset) * num2);
				}
				return (int)global::System.Math.Max((double)this._scrollPosition - ((double)this._scrollLogicalOffset - offset) * num2, 0.0);
			}
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.UseExplicitRowColumnOnTile:
				return 0;
			default:
				return 0;
			}
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00031FE0 File Offset: 0x000301E0
		internal global::Infragistics.Windows.Internal.TileManager.LayoutItem InitializeLayoutItem(global::System.Windows.DependencyObject container, object item, global::System.Windows.Controls.Dock enterFromSide)
		{
			global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = this.GetLayoutItem(item, container, true, true);
			layoutItem.EnterFromSide = enterFromSide;
			layoutItem.SetDimensions(null);
			return layoutItem;
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00032008 File Offset: 0x00030208
		protected internal void InitializePanel(global::Infragistics.Windows.Tiles.TilesPanelBase panel)
		{
			this._itemsToBeArranged.Clear();
			this._itemsInView.Clear();
			this._lastItemLocations = null;
			this._containerToItemMap.Clear();
			this._layoutItemMap.Clear();
			if (this._itemsControl != null)
			{
				((global::System.Collections.Specialized.INotifyCollectionChanged)this._itemsControl.Items).CollectionChanged -= this.OnItemsCollectionChanged;
			}
			this._panel = panel;
			this._itemsControl = ((this._panel != null && this._panel.IsItemsHost) ? global::System.Windows.Controls.ItemsControl.GetItemsOwner(this._panel) : null);
			if (this._itemsControl != null)
			{
				((global::System.Collections.Specialized.INotifyCollectionChanged)this._itemsControl.Items).CollectionChanged += this.OnItemsCollectionChanged;
			}
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x000320C0 File Offset: 0x000302C0
		internal bool IsContainerInArrangeCache(global::System.Windows.DependencyObject container)
		{
			object key;
			global::Infragistics.Windows.Internal.TileManager.LayoutItem item;
			return this._containerToItemMap.TryGetValue(container, out key) && this._layoutItemMap.TryGetValue(key, out item) && this._itemsToBeArranged.Exists(item);
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x000320FD File Offset: 0x000302FD
		internal bool IsItemInView(global::Infragistics.Windows.Tiles.ItemInfoBase item)
		{
			return this._itemsInView.Contains(item);
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x0003210C File Offset: 0x0003030C
		internal global::System.Windows.Rect MakeVisible(global::System.Windows.Media.Visual visual, global::System.Windows.Rect rectangle)
		{
			if (this._panel == null)
			{
				return global::System.Windows.Rect.Empty;
			}
			global::System.Windows.UIElement uielement = visual as global::System.Windows.UIElement;
			if (rectangle.IsEmpty && uielement != null)
			{
				rectangle = new global::System.Windows.Rect(uielement.RenderSize);
			}
			global::System.Windows.DependencyObject dependencyObject = visual;
			global::System.Windows.DependencyObject dependencyObject2 = visual;
			while (dependencyObject2 != null && dependencyObject2 != this._panel)
			{
				dependencyObject = dependencyObject2;
				dependencyObject2 = global::Infragistics.Windows.Utilities.GetParent(dependencyObject);
			}
			global::System.Windows.FrameworkElement frameworkElement = dependencyObject as global::System.Windows.FrameworkElement;
			if (dependencyObject2 == null || frameworkElement == null)
			{
				return global::System.Windows.Rect.Empty;
			}
			global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = this.GetLayoutItem(null, dependencyObject, false, false);
			if (layoutItem == null)
			{
				global::System.Windows.Controls.ContentControl contentControl = frameworkElement as global::System.Windows.Controls.ContentControl;
				if (contentControl != null)
				{
					layoutItem = this.GetLayoutItem(contentControl.Content, null, true, false);
				}
			}
			if (layoutItem == null)
			{
				return global::System.Windows.Rect.Empty;
			}
			global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = layoutItem.ItemInfo;
			if (itemInfo == null)
			{
				return global::System.Windows.Rect.Empty;
			}
			global::System.Windows.Vector offset = this._panel.ScrollDataInfo._offset;
			global::System.Windows.Point point = uielement.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), this._panel);
			global::System.Windows.Rect rect = global::System.Windows.Rect.Offset(rectangle, point.X, point.Y);
			global::System.Windows.Rect rect2 = new global::System.Windows.Rect(this._panel.TileAreaSize);
			global::System.Windows.Rect targetRect;
			if (frameworkElement.IsVisible && this._itemsInView.Contains(itemInfo))
			{
				targetRect = layoutItem.TargetRect;
				if (rect2.Contains(targetRect))
				{
					return rectangle;
				}
				if (rect2.Contains(rect))
				{
					return rectangle;
				}
				if (this._panel.IsAnimationInProgress)
				{
					global::System.Windows.Rect? currentRectInternal = layoutItem.CurrentRectInternal;
					if (currentRectInternal != null)
					{
						rect.X += layoutItem.TargetRect.X - currentRectInternal.Value.X;
						rect.Y += layoutItem.TargetRect.Y - currentRectInternal.Value.Y;
					}
				}
			}
			targetRect = layoutItem.TargetRect;
			bool flag = this.MakeVisiblePixelScrollingHelper(rect, rect2, targetRect, offset);
			if ((this._scrollTilesVertically || this._scrollTilesHorizontally) && itemInfo.OccupiesScrollPosition)
			{
				int scrollPosition = itemInfo.ScrollPosition;
				double offsetFromScrollPosition = this.GetOffsetFromScrollPosition(scrollPosition);
				int num = 0;
				foreach (global::Infragistics.Windows.Tiles.ItemInfoBase itemInfoBase in this._itemsInView)
				{
					if (itemInfoBase.OccupiesScrollPosition)
					{
						num++;
					}
				}
				global::Infragistics.Windows.Selection.ScrollDirection scrollDirection;
				int scrollPosition2;
				if (scrollPosition < this._scrollPosition)
				{
					scrollDirection = global::Infragistics.Windows.Selection.ScrollDirection.Decrement;
					scrollPosition2 = scrollPosition;
				}
				else
				{
					scrollDirection = global::Infragistics.Windows.Selection.ScrollDirection.Increment;
					scrollPosition2 = global::System.Math.Max(this._scrollPosition + 1, scrollPosition - num);
				}
				double offsetFromScrollPosition2 = this.GetOffsetFromScrollPosition(scrollPosition2);
				global::Infragistics.Windows.Tiles.TilesPanelBase.ScrollData scrollDataInfo = this._panel.ScrollDataInfo;
				if (this._scrollTilesVertically)
				{
					scrollDataInfo._offset.Y = offsetFromScrollPosition2;
				}
				else
				{
					scrollDataInfo._offset.X = offsetFromScrollPosition2;
				}
				flag = true;
				scrollDataInfo.VerifyScrollData(scrollDataInfo._viewport, scrollDataInfo._extent);
				if (scrollDirection == global::Infragistics.Windows.Selection.ScrollDirection.Increment)
				{
					this._panel.Measure(this._panel.LastMeasureSize);
					targetRect = layoutItem.TargetRect;
					double num2 = -1.0;
					while ((double)this._scrollLogicalOffset != offsetFromScrollPosition && (double)this._scrollLogicalOffset != num2 && (targetRect.Width == 0.0 || !global::Infragistics.Windows.Utilities.IsContainedBy(rect2, targetRect, this._scrollTilesHorizontally)))
					{
						num2 = (double)this._scrollLogicalOffset;
						if (this._scrollTilesVertically)
						{
							((global::System.Windows.Controls.Primitives.IScrollInfo)this.Panel).LineDown();
						}
						else
						{
							((global::System.Windows.Controls.Primitives.IScrollInfo)this.Panel).LineRight();
						}
						this._panel.Measure(this._panel.LastMeasureSize);
						targetRect = layoutItem.TargetRect;
					}
				}
			}
			targetRect = layoutItem.TargetRect;
			if (this.MakeVisiblePixelScrollingHelper(rect, rect2, targetRect, offset) || flag)
			{
				this._panel.InvalidateMeasure();
				this._panel.InvalidateArrange();
				return rectangle;
			}
			return global::System.Windows.Rect.Empty;
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x000324F0 File Offset: 0x000306F0
		private bool MakeVisiblePixelScrollingHelper(global::System.Windows.Rect rectangle, global::System.Windows.Rect panelRect, global::System.Windows.Rect liRect, global::System.Windows.Vector originalScrollOffset)
		{
			if (liRect.Width == 0.0 || liRect.Height == 0.0)
			{
				return false;
			}
			global::Infragistics.Windows.Tiles.TilesPanelBase.ScrollData scrollDataInfo = this._panel.ScrollDataInfo;
			bool result = false;
			if (!this._scrollTilesHorizontally && !global::Infragistics.Windows.Utilities.IsContainedBy(panelRect, rectangle, true))
			{
				if (panelRect.Left > rectangle.Left)
				{
					scrollDataInfo._offset.X = global::System.Math.Max(originalScrollOffset.X + rectangle.Left, 0.0);
				}
				else
				{
					scrollDataInfo._offset.X = global::System.Math.Max(originalScrollOffset.X + rectangle.Right - scrollDataInfo._viewport.Width, 0.0);
				}
				this._panel.InvalidateMeasure();
				result = true;
			}
			if (!this._scrollTilesVertically && !global::Infragistics.Windows.Utilities.IsContainedBy(panelRect, rectangle, false))
			{
				if (panelRect.Top > rectangle.Top)
				{
					scrollDataInfo._offset.Y = global::System.Math.Max(originalScrollOffset.Y + rectangle.Top, 0.0);
				}
				else
				{
					scrollDataInfo._offset.Y = global::System.Math.Max(originalScrollOffset.Y + rectangle.Bottom - scrollDataInfo._viewport.Height, 0.0);
				}
				this._panel.InvalidateMeasure();
				result = true;
			}
			scrollDataInfo.VerifyScrollData(scrollDataInfo._viewport, scrollDataInfo._extent);
			return result;
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00032664 File Offset: 0x00030864
		internal bool MoveTileHelper(global::Infragistics.Windows.Internal.TileManager.LayoutItem sourceItem, global::Infragistics.Windows.Internal.TileManager.LayoutItem targetItem, bool calledFromDragManager)
		{
			if (this._panel == null)
			{
				return false;
			}
			if (sourceItem == null || targetItem == null || sourceItem == targetItem || !(sourceItem.Container is global::System.Windows.FrameworkElement) || !(targetItem.Container is global::System.Windows.FrameworkElement))
			{
				return false;
			}
			global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = sourceItem.ItemInfo;
			global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo2 = targetItem.ItemInfo;
			if (itemInfo == null || itemInfo2 == null)
			{
				return false;
			}
			global::System.Windows.FrameworkElement frameworkElement = sourceItem.Container as global::System.Windows.FrameworkElement;
			global::System.Windows.FrameworkElement frameworkElement2 = targetItem.Container as global::System.Windows.FrameworkElement;
			if (frameworkElement == null || frameworkElement2 == null)
			{
				return false;
			}
			global::Infragistics.Windows.Tiles.AllowTileDragging allowTileDragging = this._panel.GetAllowTileDragging(frameworkElement, itemInfo);
			if (allowTileDragging == global::Infragistics.Windows.Tiles.AllowTileDragging.No)
			{
				return false;
			}
			bool flag = allowTileDragging == global::Infragistics.Windows.Tiles.AllowTileDragging.Swap;
			if (!flag)
			{
				flag = (itemInfo.GetIsMaximized() != itemInfo2.GetIsMaximized());
			}
			if (flag && !calledFromDragManager && !this._panel.CanSwapContainers(frameworkElement, itemInfo, frameworkElement2, itemInfo2))
			{
				return false;
			}
			if (itemInfo.GetIsMaximized() && itemInfo2.GetIsMaximized())
			{
				global::Infragistics.Collections.ObservableCollectionExtended<object> maximizedItems = this._panel.GetMaximizedItems();
				int num = maximizedItems.IndexOf(itemInfo.Item);
				int num2 = maximizedItems.IndexOf(itemInfo2.Item);
				if (num == num2)
				{
					return false;
				}
				maximizedItems.BeginUpdate();
				try
				{
					if (allowTileDragging == global::Infragistics.Windows.Tiles.AllowTileDragging.Swap)
					{
						if (num < num2)
						{
							maximizedItems.RemoveAt(num);
							maximizedItems.RemoveAt(num2 - 1);
							maximizedItems.Insert(num, itemInfo2.Item);
							maximizedItems.Insert(num2, itemInfo.Item);
						}
						else
						{
							maximizedItems.RemoveAt(num2);
							maximizedItems.RemoveAt(num - 1);
							maximizedItems.Insert(num2, itemInfo.Item);
							maximizedItems.Insert(num, itemInfo2.Item);
						}
					}
					else
					{
						maximizedItems.RemoveAt(num);
						maximizedItems.Insert(num2, itemInfo.Item);
					}
				}
				finally
				{
					maximizedItems.EndUpdate();
				}
				if (flag)
				{
					this._panel.OnContainersSwapped(frameworkElement, itemInfo, frameworkElement2, itemInfo2);
				}
				this._panel.InvalidateMeasure();
				return true;
			}
			else
			{
				if (itemInfo.GetIsMaximized() || itemInfo2.GetIsMaximized())
				{
					this._panel.OnContainersSwapped(frameworkElement, itemInfo, frameworkElement2, itemInfo2);
					this._panel.InvalidateMeasure();
					return true;
				}
				if (!this._isInMaximizedMode && this._tileLayoutOrder == global::Infragistics.Windows.Tiles.TileLayoutOrder.UseExplicitRowColumnOnTile)
				{
					int column = global::Infragistics.Windows.Tiles.TilesPanelBase.GetColumn(targetItem.Container);
					int columnSpan = global::Infragistics.Windows.Tiles.TilesPanelBase.GetColumnSpan(targetItem.Container);
					int row = global::Infragistics.Windows.Tiles.TilesPanelBase.GetRow(targetItem.Container);
					int rowSpan = global::Infragistics.Windows.Tiles.TilesPanelBase.GetRowSpan(targetItem.Container);
					int column2 = global::Infragistics.Windows.Tiles.TilesPanelBase.GetColumn(sourceItem.Container);
					int columnSpan2 = global::Infragistics.Windows.Tiles.TilesPanelBase.GetColumnSpan(sourceItem.Container);
					int row2 = global::Infragistics.Windows.Tiles.TilesPanelBase.GetRow(sourceItem.Container);
					int rowSpan2 = global::Infragistics.Windows.Tiles.TilesPanelBase.GetRowSpan(sourceItem.Container);
					global::Infragistics.Windows.Tiles.TilesPanelBase.SetColumn(targetItem.Container, column2);
					global::Infragistics.Windows.Tiles.TilesPanelBase.SetColumnSpan(targetItem.Container, columnSpan2);
					global::Infragistics.Windows.Tiles.TilesPanelBase.SetRow(targetItem.Container, row2);
					global::Infragistics.Windows.Tiles.TilesPanelBase.SetRowSpan(targetItem.Container, rowSpan2);
					global::Infragistics.Windows.Tiles.TilesPanelBase.SetColumn(sourceItem.Container, column);
					global::Infragistics.Windows.Tiles.TilesPanelBase.SetColumnSpan(sourceItem.Container, columnSpan);
					global::Infragistics.Windows.Tiles.TilesPanelBase.SetRow(sourceItem.Container, row);
					global::Infragistics.Windows.Tiles.TilesPanelBase.SetRowSpan(sourceItem.Container, rowSpan);
					this._panel.InvalidateMeasure();
					this._panel.OnContainersSwapped(frameworkElement, itemInfo, frameworkElement2, itemInfo2);
					return true;
				}
				int logicalIndex = itemInfo.LogicalIndex;
				if (logicalIndex < 0)
				{
					return false;
				}
				int logicalIndex2 = itemInfo2.LogicalIndex;
				if (logicalIndex2 < 0 || logicalIndex2 == logicalIndex)
				{
					return false;
				}
				global::Infragistics.Windows.Internal.TileManager.ScrollManagerSparseArray sparseArray = this.SparseArray;
				if (allowTileDragging == global::Infragistics.Windows.Tiles.AllowTileDragging.Swap)
				{
					if (logicalIndex < logicalIndex2)
					{
						sparseArray.RemoveAt(logicalIndex);
						sparseArray.RemoveAt(logicalIndex2 - 1);
						sparseArray.Insert(logicalIndex, itemInfo2);
						sparseArray.Insert(logicalIndex2, itemInfo);
					}
					else
					{
						sparseArray.RemoveAt(logicalIndex2);
						sparseArray.RemoveAt(logicalIndex - 1);
						sparseArray.Insert(logicalIndex2, itemInfo);
						sparseArray.Insert(logicalIndex, itemInfo2);
					}
				}
				else
				{
					sparseArray.RemoveAt(logicalIndex);
					sparseArray.Insert(logicalIndex2, itemInfo);
				}
				if (flag)
				{
					this._panel.OnContainersSwapped(frameworkElement, itemInfo, frameworkElement2, itemInfo2);
				}
				this._panel.InvalidateMeasure();
				return true;
			}
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00032A28 File Offset: 0x00030C28
		internal void OnArrange(out bool itemLocationsAreaTheSame, out bool inViewItemsAreTheSame)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.ItemRowColumnSizeInfo> itemRowColumnSnapshot = this.GetItemRowColumnSnapshot();
			itemLocationsAreaTheSame = true;
			int count = itemRowColumnSnapshot.Count;
			if (this._lastItemLocations == null)
			{
				itemLocationsAreaTheSame = true;
				inViewItemsAreTheSame = (itemRowColumnSnapshot.Count == 0);
			}
			else if (this._lastItemLocations.Count != count)
			{
				itemLocationsAreaTheSame = false;
				inViewItemsAreTheSame = false;
			}
			else
			{
				inViewItemsAreTheSame = true;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.Internal.TileManager.ItemRowColumnSizeInfo itemRowColumnSizeInfo = itemRowColumnSnapshot[i];
					global::Infragistics.Windows.Internal.TileManager.ItemRowColumnSizeInfo itemRowColumnSizeInfo2 = this._lastItemLocations[i];
					if (itemRowColumnSizeInfo.Info != itemRowColumnSizeInfo2.Info)
					{
						inViewItemsAreTheSame = false;
						itemLocationsAreaTheSame = false;
						break;
					}
					if (itemRowColumnSizeInfo.Row != itemRowColumnSizeInfo2.Row || itemRowColumnSizeInfo.Column != itemRowColumnSizeInfo2.Column || itemRowColumnSizeInfo.PreferredSize != itemRowColumnSizeInfo2.PreferredSize)
					{
						itemLocationsAreaTheSame = false;
						break;
					}
				}
			}
			if (this._lastItemLocations == null || !itemLocationsAreaTheSame)
			{
				this._lastItemLocations = itemRowColumnSnapshot;
			}
			global::System.Windows.HorizontalAlignment horizontalTileAreaAlignment = this._panel.GetHorizontalTileAreaAlignment();
			global::System.Windows.VerticalAlignment verticalTileAreaAlignment = this._panel.GetVerticalTileAreaAlignment();
			if (horizontalTileAreaAlignment != this._lastHorizontalTileAreaAlignment || verticalTileAreaAlignment != this._lastVerticalTileAreaAlignment)
			{
				itemLocationsAreaTheSame = false;
				this._lastHorizontalTileAreaAlignment = horizontalTileAreaAlignment;
				this._lastVerticalTileAreaAlignment = verticalTileAreaAlignment;
			}
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00032B40 File Offset: 0x00030D40
		internal void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._itemsInOriginalOrder == null)
			{
				return;
			}
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
			{
				int newStartingIndex = e.NewStartingIndex;
				int count = e.NewItems.Count;
				for (int i = 0; i < count; i++)
				{
					object obj = e.NewItems[i];
					int index = newStartingIndex + i;
					this._itemsInOriginalOrder.Insert(index, obj);
					global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = this.GetItemInfo(obj);
					this._sparseArray.Insert(index, itemInfo);
				}
				return;
			}
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
			{
				this._panel.VerifyMaximizedItems();
				int num;
				global::System.Collections.IList list;
				if (e.NewItems != null)
				{
					num = e.NewStartingIndex;
					list = e.NewItems;
				}
				else
				{
					num = e.OldStartingIndex;
					list = e.OldItems;
				}
				int count2 = list.Count;
				int num2 = num + count2 - 1;
				if (num2 >= this._itemsInOriginalOrder.Count)
				{
					this.ProcessResetNotification();
					return;
				}
				this.RemoveRangeHelper(num, list);
				return;
			}
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
			{
				this._panel.VerifyMaximizedItems();
				int count3 = e.NewItems.Count;
				int newStartingIndex2 = e.NewStartingIndex;
				for (int j = 0; j <= count3; j++)
				{
					object item = e.NewItems[j];
					object item2 = e.OldItems[j];
					global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo2 = this.GetItemInfo(item2);
					if (itemInfo2 != null)
					{
						int num3 = this._sparseArray.IndexOf(itemInfo2);
						if (num3 >= 0)
						{
							this._sparseArray[num3] = this.GetItemInfo(item);
						}
					}
				}
				this.RemoveRangeHelper(e.NewStartingIndex, e.OldItems);
				this._itemsInOriginalOrder.InsertRange(e.NewStartingIndex, e.NewItems);
				return;
			}
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
			{
				global::System.Collections.IList list2;
				if (e.NewItems != null)
				{
					list2 = e.NewItems;
				}
				else
				{
					list2 = e.OldItems;
				}
				int count4 = list2.Count;
				if (e.NewStartingIndex + count4 >= this._itemsInOriginalOrder.Count || e.OldStartingIndex + count4 >= this._itemsInOriginalOrder.Count)
				{
					this.ProcessResetNotification();
					return;
				}
				object[] array = new object[count4];
				for (int k = 0; k < array.Length; k++)
				{
					array[k] = this._itemsInOriginalOrder[k + e.OldStartingIndex];
				}
				this._itemsInOriginalOrder.RemoveRange(e.OldStartingIndex, list2.Count);
				this._itemsInOriginalOrder.InsertRange(e.NewStartingIndex, array);
				if (this._sparseArray[global::System.Math.Min(e.NewStartingIndex, e.OldStartingIndex)] != null)
				{
					this._sparseArray.Clear();
					this._sparseArray.Expand(this._itemsInOriginalOrder.Count);
					return;
				}
				break;
			}
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				this.ProcessResetNotification();
				break;
			default:
				return;
			}
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00032DE8 File Offset: 0x00030FE8
		internal void OnScrollOffsetChanged(global::System.Windows.Vector newOffset, global::System.Windows.Vector oldOffset)
		{
			int scrollPosition = this._scrollPosition;
			if (!this._scrollTilesHorizontally && !this._scrollTilesVertically)
			{
				this._scrollLogicalOffset = 0;
				this._arrangeOffset.X = -newOffset.X;
				this._arrangeOffset.Y = -newOffset.Y;
			}
			else
			{
				if (this._scrollTilesHorizontally)
				{
					this._scrollPosition = this.GetScrollPositionFromOffset((double)((int)newOffset.X));
					this._scrollLogicalOffset = (int)newOffset.X;
					this._arrangeOffset.X = 0.0;
				}
				else
				{
					this._arrangeOffset.X = -newOffset.X;
				}
				if (this._scrollTilesVertically)
				{
					this._scrollPosition = this.GetScrollPositionFromOffset((double)((int)newOffset.Y));
					this._scrollLogicalOffset = (int)newOffset.Y;
					this._arrangeOffset.Y = 0.0;
				}
				else
				{
					this._arrangeOffset.Y = -newOffset.Y;
				}
			}
			this._arrangeOffsetForMaxmizedTiles = this._arrangeOffset;
			if (this._isInMaximizedMode)
			{
				switch (this._maximizedTileLocation)
				{
				case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Left:
				case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Right:
					this._arrangeOffsetForMaxmizedTiles.Y = 0.0;
					break;
				default:
					this._arrangeOffsetForMaxmizedTiles.X = 0.0;
					break;
				}
			}
			if (scrollPosition != this._scrollPosition)
			{
				this._panel.InvalidateMeasure();
			}
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00032F54 File Offset: 0x00031154
		internal void OnItemResized(global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo, double deltaX, double deltaY)
		{
			if (global::Infragistics.CoreUtilities.AreClose(deltaX, 0.0))
			{
				deltaX = 0.0;
			}
			if (global::Infragistics.CoreUtilities.AreClose(deltaY, 0.0))
			{
				deltaY = 0.0;
			}
			bool flag = false;
			if (this._isInMaximizedMode)
			{
				switch (this._maximizedTileLayoutOrder)
				{
				case global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder.HorizontalWithLastTileFill:
				case global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder.Horizontal:
					flag = true;
					break;
				}
			}
			else
			{
				switch (this._tileLayoutOrder)
				{
				case global::Infragistics.Windows.Tiles.TileLayoutOrder.Horizontal:
				case global::Infragistics.Windows.Tiles.TileLayoutOrder.HorizontalVariable:
				case global::Infragistics.Windows.Tiles.TileLayoutOrder.UseExplicitRowColumnOnTile:
					flag = true;
					break;
				}
			}
			if (deltaX != 0.0 && flag)
			{
				if (this.ItemResizeHelper(itemInfo, deltaX, 0.0))
				{
					this._panel.InvalidateMeasure();
					if (deltaY != 0.0)
					{
						this._panel.UpdateLayout();
					}
				}
				deltaX = 0.0;
			}
			if (deltaY != 0.0 && this.ItemResizeHelper(itemInfo, 0.0, deltaY))
			{
				this._panel.InvalidateMeasure();
				if (deltaX != 0.0)
				{
					this._panel.UpdateLayout();
				}
			}
			if (deltaX != 0.0 && this.ItemResizeHelper(itemInfo, deltaX, 0.0))
			{
				this._panel.InvalidateMeasure();
			}
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0003309C File Offset: 0x0003129C
		internal void RemoveContainer(global::System.Windows.DependencyObject container)
		{
			if (container != null && this._containerToItemMap.ContainsKey(container))
			{
				object key = this._containerToItemMap[container];
				this._containerToItemMap.Remove(container);
				if (this._layoutItemMap.ContainsKey(key))
				{
					global::Infragistics.Windows.Internal.TileManager.LayoutItem li = this._layoutItemMap[key];
					this.RemoveLayoutItem(li);
				}
			}
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000330F8 File Offset: 0x000312F8
		internal void RemoveLayoutItem(global::Infragistics.Windows.Internal.TileManager.LayoutItem li)
		{
			global::System.Windows.DependencyObject container = li.Container;
			object item = li.Item;
			if (container != null && this._containerToItemMap.ContainsKey(container))
			{
				this._containerToItemMap.Remove(container);
			}
			if (this._itemsToBeArranged.Exists(li))
			{
				this._itemsToBeArranged.Remove(li);
			}
			else if (container != null)
			{
				foreach (object obj in this._itemsToBeArranged)
				{
					global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = (global::Infragistics.Windows.Internal.TileManager.LayoutItem)obj;
					if (layoutItem.Container == container)
					{
						this._itemsToBeArranged.Remove(layoutItem);
						break;
					}
				}
			}
			if (item != null && this._layoutItemMap.ContainsKey(item))
			{
				this._layoutItemMap.Remove(item);
			}
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x000331D0 File Offset: 0x000313D0
		internal void SnapshotItemRects()
		{
			foreach (object obj in this._itemsToBeArranged)
			{
				global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = (global::Infragistics.Windows.Internal.TileManager.LayoutItem)obj;
				layoutItem.SnapshotCurrentRect();
			}
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00033228 File Offset: 0x00031428
		internal void VerifyArrangeSize()
		{
			bool isScrollingTilesVertically;
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager overallGridBagLayout = this.GetOverallGridBagLayout(out isScrollingTilesVertically);
			bool flag = this.UpdateScrollingInfo(overallGridBagLayout, this._lastMeasureDesiredSize, isScrollingTilesVertically, true);
			if (flag)
			{
				this._panel.InvalidateMeasure();
				this._panel.InvalidateArrange();
			}
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00033267 File Offset: 0x00031467
		private void AddItemToBeArranged(global::Infragistics.Windows.Internal.TileManager.LayoutItem li)
		{
			this.RemoveDuplicateContainerRefs(li);
			this._itemsToBeArranged.Add(li);
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x0003327C File Offset: 0x0003147C
		private bool CalculateTileScrollExtents(bool checkIfScrolledTooFar, ref global::System.Windows.Size extent, ref global::System.Windows.Size viewport)
		{
			int num = 1;
			int num2 = 1;
			int num3 = 0;
			int num4 = 0;
			int num5 = 1;
			global::System.Windows.Size tileAreaSize = this._panel.TileAreaSize;
			double panelExtent = this._scrollTilesVertically ? tileAreaSize.Height : tileAreaSize.Width;
			bool flag = false;
			if (this._isInMaximizedMode)
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagManager = this.MinimizedTileArea.GridBagManager;
				num4 = this._sparseArray.ScrollCount;
				num5 = global::System.Math.Max(1, gridBagManager.LayoutItems.Count);
				num = 1;
				num2 = num5;
				if (gridBagManager.LayoutItems.Count < 1)
				{
					num3 = 0;
				}
				else
				{
					global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = (global::Infragistics.Windows.Internal.TileManager.LayoutItem)gridBagManager.LayoutItems[gridBagManager.LayoutItems.Count - 1];
					this._scrollPositionOfLastArrangedItem = layoutItem.ItemInfo.ScrollPosition;
					this._scrollLogicalOffsetOfLastArrangedItem = this._scrollPositionOfLastArrangedItem;
					num3 = global::System.Math.Max(num4 - num5, 0);
					if (num4 > 0 && num3 > 0 && gridBagManager.LayoutItems.Count > 1 && this._scrollLogicalOffset > 0)
					{
						global::Infragistics.Windows.Internal.TileManager.LayoutItem liFirst = gridBagManager.LayoutItems[0] as global::Infragistics.Windows.Internal.TileManager.LayoutItem;
						flag = this.AdjustMaxOffset(ref num3, ref num4, ref num5, panelExtent, gridBagManager, liFirst, layoutItem, !checkIfScrolledTooFar);
					}
					if (!flag && this._scrollPositionOfLastArrangedItem >= num4 - 1 && num5 > num4 + 1)
					{
						bool flag2;
						switch (this._maximizedTileLocation)
						{
						default:
							flag2 = (layoutItem.TargetRect.Bottom <= this._panel.TileAreaSize.Height + 1.0);
							break;
						case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Top:
						case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Bottom:
							flag2 = (layoutItem.TargetRect.Right <= this._panel.TileAreaSize.Width + 1.0);
							break;
						}
						if (flag2)
						{
							num5++;
							num2 = num5;
						}
					}
				}
			}
			else
			{
				switch (this._tileLayoutOrder)
				{
				case global::Infragistics.Windows.Tiles.TileLayoutOrder.Vertical:
				case global::Infragistics.Windows.Tiles.TileLayoutOrder.Horizontal:
				{
					num4 = global::System.Math.Max((this._sparseArray.ScrollCount + this._normalModeItemsPerRowColumn - 1) / global::System.Math.Max(this._normalModeItemsPerRowColumn, 1), 0);
					num5 = global::System.Math.Max(1, this._normalModeRowColumnsInView);
					if (num5 < num4 || this._scrollPosition > 0 || this._normalModeRowColumnsInViewActual > this._normalModeRowColumnsInView)
					{
						num5 = global::System.Math.Min(2, global::System.Math.Max(1, this._normalModeRowColumnsInView - 1));
					}
					num = 1;
					num2 = this._normalModeRowColumnsInView;
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutNormal = this.GridBagLayoutNormal;
					int count = gridBagLayoutNormal.LayoutItems.Count;
					if (count == 0)
					{
						this._scrollPositionOfLastArrangedItem = 0;
					}
					else
					{
						global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem2 = (global::Infragistics.Windows.Internal.TileManager.LayoutItem)gridBagLayoutNormal.LayoutItems[count - 1];
						this._scrollPositionOfLastArrangedItem = layoutItem2.ItemInfo.ScrollPosition;
					}
					this._scrollLogicalOffsetOfLastArrangedItem = this._scrollPositionOfLastArrangedItem;
					if (this._normalModeRowColumnsInView < 1)
					{
						num3 = 0;
					}
					else
					{
						num3 = global::System.Math.Max(num4 - num5, 0);
						if (num4 > 0 && count > 1)
						{
							int num6 = this._scrollLogicalOffset * this._normalModeItemsPerRowColumn;
							if (num6 != this._scrollPosition && this._normalModeItemsPerRowColumn > 0)
							{
								if (this._lastNormalModeItemsPerRowColumn > this._normalModeItemsPerRowColumn)
								{
									this._scrollLogicalOffset = this._scrollPosition / this._normalModeItemsPerRowColumn;
								}
								else
								{
									this._scrollLogicalOffset = (this._scrollPosition + 1) / this._normalModeItemsPerRowColumn;
								}
								this._scrollPosition = this._scrollLogicalOffset * this._normalModeItemsPerRowColumn;
								flag = true;
							}
							else if (this._normalModeRowColumnsInView > 1)
							{
								global::Infragistics.Windows.Internal.TileManager.LayoutItem liFirst2 = gridBagLayoutNormal.LayoutItems[0] as global::Infragistics.Windows.Internal.TileManager.LayoutItem;
								global::Infragistics.Windows.Internal.TileManager.LayoutItem liLast = gridBagLayoutNormal.LayoutItems[count - 1] as global::Infragistics.Windows.Internal.TileManager.LayoutItem;
								bool flag3 = !checkIfScrolledTooFar;
								if (!flag3 && this._normalModeRowColumnsInViewActual == this._normalModeRowColumnsInView)
								{
									int num7;
									if (this._scrollTilesHorizontally)
									{
										num7 = this._panel.GetMaxColumns();
									}
									else
									{
										num7 = this._panel.GetMaxRows();
									}
									if (num7 > 0)
									{
										flag3 = (this._normalModeRowColumnsInViewActual >= num7);
									}
								}
								flag = this.AdjustMaxOffset(ref num3, ref num4, ref num5, panelExtent, gridBagLayoutNormal, liFirst2, liLast, flag3);
							}
						}
					}
					break;
				}
				case global::Infragistics.Windows.Tiles.TileLayoutOrder.VerticalVariable:
				case global::Infragistics.Windows.Tiles.TileLayoutOrder.HorizontalVariable:
				{
					num4 = 0;
					num5 = 1;
					num = 1;
					num2 = 1;
					num3 = 0;
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutNormalModeOverall = this.GridBagLayoutNormalModeOverall;
					if (gridBagLayoutNormalModeOverall.LayoutItems.Count == 0)
					{
						if (this._scrollLogicalOffset > 0)
						{
							flag = true;
						}
						this._scrollPosition = 0;
						this._scrollPositionOfLastArrangedItem = 0;
						this._scrollLogicalOffset = 0;
						this._scrollLogicalOffsetOfLastArrangedItem = 0;
						this._scrollPosition = 0;
						this._variableAvgItemsPerRowColumn = 1.0;
						this._variableTotalRowColmuns = 0;
					}
					else
					{
						int num8;
						if (this._tileLayoutOrder == global::Infragistics.Windows.Tiles.TileLayoutOrder.VerticalVariable)
						{
							num8 = this._totalColumnsDisplayed;
						}
						else
						{
							num8 = this._totalRowsDisplayed;
						}
						global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem tileRowColumnLayoutItem = gridBagLayoutNormalModeOverall.LayoutItems[0] as global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem;
						global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem tileRowColumnLayoutItem2 = gridBagLayoutNormalModeOverall.LayoutItems[num8 - 1] as global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem;
						this._scrollLogicalOffset = tileRowColumnLayoutItem.ScrollOffset;
						this._scrollPositionOfLastArrangedItem = tileRowColumnLayoutItem2.GetLastScrollPosition();
						this._scrollLogicalOffsetOfLastArrangedItem = tileRowColumnLayoutItem2.ScrollOffset;
						this._variableAvgItemsPerRowColumn = global::System.Math.Max((double)(this._scrollPositionOfLastArrangedItem + 1) / (double)global::System.Math.Max(this._scrollLogicalOffsetOfLastArrangedItem + 1, 1), 1.0);
						int scrollCount = this._sparseArray.ScrollCount;
						if (this._scrollPositionOfLastArrangedItem >= scrollCount - 1)
						{
							this._variableTotalRowColmuns = this._scrollLogicalOffsetOfLastArrangedItem + 1;
							if (this._scrollLogicalOffset == 0)
							{
								num4 = 1;
								num5 = 1;
							}
							else
							{
								num4 = this._variableTotalRowColmuns;
								num5 = global::System.Math.Max(num8, 1);
							}
						}
						else
						{
							this._variableTotalRowColmuns = global::System.Math.Max((int)global::System.Math.Ceiling((double)scrollCount / this._variableAvgItemsPerRowColumn), this._scrollLogicalOffsetOfLastArrangedItem + 1);
							num4 = this._variableTotalRowColmuns;
							num5 = global::System.Math.Max(num8, 1);
						}
						num2 = global::System.Math.Max(num8, 1);
						num3 = global::System.Math.Max(num4 - num5, 0);
					}
					break;
				}
				}
			}
			if (this._scrollTilesHorizontally)
			{
				this._scrollSmallChange.X = (double)num;
				this._scrollLargeChange.X = (double)num2;
				this._scrollMaxOffset.X = (double)num3;
				extent.Width = (double)num4;
				viewport.Width = (double)num5;
			}
			else
			{
				this._scrollSmallChange.Y = (double)num;
				this._scrollLargeChange.Y = (double)num2;
				this._scrollMaxOffset.Y = (double)num3;
				extent.Height = (double)num4;
				viewport.Height = (double)num5;
			}
			return flag;
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x000338B4 File Offset: 0x00031AB4
		private bool AdjustMaxOffset(ref int maxOffset, ref int extentValue, ref int viewportValue, double panelExtent, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gbm, global::Infragistics.Windows.Internal.TileManager.LayoutItem liFirst, global::Infragistics.Windows.Internal.TileManager.LayoutItem liLast, bool bypassScrolledTooFarCheck)
		{
			double num = this._scrollTilesVertically ? liFirst.TargetRect.Top : liFirst.TargetRect.Left;
			double num2 = this._scrollTilesVertically ? liLast.TargetRect.Bottom : liLast.TargetRect.Right;
			if (!this._scrollTilesVertically)
			{
				double width = liLast.TargetRect.Width;
			}
			else
			{
				double height = liLast.TargetRect.Height;
			}
			double num3 = num + panelExtent - num2;
			if (this._scrollTilesHorizontally)
			{
				double interItemSpacingHorizontal = gbm.InterItemSpacingHorizontal;
			}
			else
			{
				double interItemSpacingHorizontal2 = gbm.InterItemSpacingHorizontal;
			}
			bool flag = false;
			bool result = false;
			if (flag)
			{
				if (this._scrollLogicalOffset == 0)
				{
					extentValue = 0;
					viewportValue = 1;
					maxOffset = 0;
				}
				else
				{
					maxOffset = this._scrollLogicalOffset - 1;
					result = true;
				}
			}
			else if (num3 < 0.0 && !bypassScrolledTooFarCheck && this._scrollLogicalOffset >= maxOffset)
			{
				int num4 = maxOffset;
				maxOffset = global::System.Math.Min(this.SparseArray.ScrollCount - 1, this._scrollLogicalOffset + 1);
				int num5 = maxOffset - num4;
				viewportValue -= num5;
				if (viewportValue < 1)
				{
					extentValue += 1 - viewportValue;
					viewportValue = 1;
				}
			}
			else
			{
				maxOffset = global::System.Math.Max(this._scrollLogicalOffset, maxOffset);
			}
			return result;
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x000339FC File Offset: 0x00031BFC
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection CalculateAutoLayoutHelper(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gbl, global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache, global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> enumerator, bool autoFitAllItems, global::System.Windows.Size constraint, int minRows, int minCols, int maxRows, int maxCols, global::System.Windows.Controls.Orientation orientation)
		{
			global::System.Windows.Controls.Orientation? constraintedOrientation = null;
			if (this._gridBagLayoutMaximized == gbl)
			{
				switch (this._maximizedTileLocation)
				{
				case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Left:
				case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Right:
					constraintedOrientation = new global::System.Windows.Controls.Orientation?(global::System.Windows.Controls.Orientation.Horizontal);
					break;
				case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Top:
				case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Bottom:
					constraintedOrientation = new global::System.Windows.Controls.Orientation?(global::System.Windows.Controls.Orientation.Vertical);
					break;
				}
			}
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection gridBagLayoutItemDimensionsCollection = gbl.CalculateAutoLayout(enumerator, orientation, autoFitAllItems, constraint, minRows, minCols, maxRows, maxCols, constraintedOrientation);
			this.ProcessDimensionsCollection(gbl, genCache, gridBagLayoutItemDimensionsCollection);
			return gridBagLayoutItemDimensionsCollection;
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00033A70 File Offset: 0x00031C70
		private void CreateExpectedItemsList(global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache)
		{
			if (this._itemsToBeArranged == null || this._itemsToBeArranged.Count < 1 || this._panel.ItemContainerGenerationModeResolved != global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
			{
				return;
			}
			bool flag;
			if (this._isInMaximizedMode)
			{
				flag = this._panel.GetShowAllMinimizedTiles();
			}
			else
			{
				flag = (this._tileLayoutOrder == global::Infragistics.Windows.Tiles.TileLayoutOrder.UseExplicitRowColumnOnTile || this._panel.GetShowAllTiles());
			}
			if (flag)
			{
				genCache._itemsExpectedToBeGenerated = new global::System.Collections.ArrayList(this.Items);
				return;
			}
			global::System.Collections.IList list = null;
			if (this._isInMaximizedMode)
			{
				list = this._panel.GetMaximizedItems();
			}
			if (this._panel.GetShouldAnimate())
			{
				genCache._itemsExpectedToBeGenerated = new global::System.Collections.ArrayList(this._itemsToBeArranged.Count);
				if (list != null)
				{
					genCache._itemsExpectedToBeGenerated.AddRange(list);
				}
				foreach (object obj in this._itemsToBeArranged)
				{
					global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = (global::Infragistics.Windows.Internal.TileManager.LayoutItem)obj;
					global::System.Windows.DependencyObject container = layoutItem.Container;
					if (container != null)
					{
						object item = layoutItem.Item;
						if (item != null)
						{
							genCache._itemsExpectedToBeGenerated.Add(item);
						}
					}
				}
				return;
			}
			int num = this.IsMaximizedAreaLeftOrRight ? ((int)this._panel.ScrollDataInfo._viewport.Height) : ((int)this._panel.ScrollDataInfo._viewport.Width);
			int num2;
			if (this._isInMaximizedMode)
			{
				num2 = global::System.Math.Max(1, num);
			}
			else
			{
				int num3;
				switch (this._tileLayoutOrder)
				{
				case global::Infragistics.Windows.Tiles.TileLayoutOrder.VerticalVariable:
				case global::Infragistics.Windows.Tiles.TileLayoutOrder.HorizontalVariable:
					num3 = (int)global::System.Math.Ceiling(this._variableAvgItemsPerRowColumn);
					goto IL_198;
				}
				num3 = this._normalModeItemsPerRowColumn;
				IL_198:
				num2 = 1 + num * num3;
			}
			genCache._itemsExpectedToBeGenerated = new global::System.Collections.ArrayList(num2 + ((list != null) ? list.Count : 0));
			if (list != null)
			{
				genCache._itemsExpectedToBeGenerated.AddRange(list);
			}
			for (int i = 0; i < num2; i++)
			{
				int num4 = this._scrollPosition + i;
				if (num4 >= this._sparseArray.ScrollCount)
				{
					return;
				}
				object itemAtScrollIndex = this.GetItemAtScrollIndex(num4);
				if (itemAtScrollIndex != null)
				{
					genCache._itemsExpectedToBeGenerated.Add(itemAtScrollIndex);
				}
			}
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00033CA0 File Offset: 0x00031EA0
		private void EnsureItemArrayIsAllocated()
		{
			if (this._itemsInOriginalOrder == null)
			{
				int count = this.Items.Count;
				this._itemsInOriginalOrder = new global::System.Collections.ArrayList(count + 10);
				this.ExpandCachedItemArrays(count);
			}
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00033CD8 File Offset: 0x00031ED8
		private void ExpandCachedItemArrays(int newCount)
		{
			if (this._itemsInOriginalOrder == null)
			{
				return;
			}
			for (int i = this._itemsInOriginalOrder.Count; i < newCount; i++)
			{
				this._itemsInOriginalOrder.Add(null);
			}
			this._sparseArray.Expand(newCount);
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00033D20 File Offset: 0x00031F20
		private void GenerateMaximizedElements(global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutMaximized = this.GridBagLayoutMaximized;
			gridBagLayoutMaximized.InterItemSpacingHorizontal = this._panel.GetInterTileSpacing(false, global::Infragistics.Windows.Tiles.TileState.Maximized);
			gridBagLayoutMaximized.InterItemSpacingVertical = this._panel.GetInterTileSpacing(true, global::Infragistics.Windows.Tiles.TileState.Maximized);
			bool flag = false;
			bool flag2 = false;
			int maxRows = 0;
			int maxCols = 0;
			global::System.Windows.Controls.Orientation orientation = global::System.Windows.Controls.Orientation.Horizontal;
			switch (this._maximizedTileLayoutOrder)
			{
			case global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder.VerticalWithLastTileFill:
				flag = true;
				orientation = global::System.Windows.Controls.Orientation.Vertical;
				break;
			case global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder.Vertical:
				orientation = global::System.Windows.Controls.Orientation.Vertical;
				break;
			case global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder.HorizontalWithLastTileFill:
				flag2 = true;
				break;
			case global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder.SingleColumn:
				maxCols = 1;
				orientation = global::System.Windows.Controls.Orientation.Vertical;
				break;
			case global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder.SingleRow:
				maxRows = 1;
				break;
			}
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection gridBagLayoutItemDimensionsCollection = this.CalculateAutoLayoutHelper(gridBagLayoutMaximized, genCache, new global::Infragistics.Windows.Internal.TileManager.LayoutItemGeneratorEnumerator(this, genCache, true, 0, orientation, global::Infragistics.Windows.Selection.ScrollDirection.Increment), true, this._panel.TileAreaSize, 1, 1, maxRows, maxCols, orientation);
			this._maximizedTileArea.InitializeCachedSizes(gridBagLayoutItemDimensionsCollection);
			this._totalMaximizedColumns = gridBagLayoutItemDimensionsCollection.ColumnDims.Length - 1;
			this._totalMaximizedRows = gridBagLayoutItemDimensionsCollection.RowDims.Length - 1;
			this._totalColumnsDisplayed = this._totalMaximizedColumns;
			this._totalRowsDisplayed = this._totalMaximizedRows;
			int count = gridBagLayoutMaximized.LayoutItems.Count;
			if (count > 0)
			{
				if (flag2)
				{
					((global::Infragistics.Windows.Internal.TileManager.LayoutItem)gridBagLayoutMaximized.LayoutItems[count - 1]).SetFillAvailableColumns(true);
					return;
				}
				if (flag)
				{
					((global::Infragistics.Windows.Internal.TileManager.LayoutItem)gridBagLayoutMaximized.LayoutItems[count - 1]).SetFillAvailableRows(true);
				}
			}
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00033E68 File Offset: 0x00032068
		private void GenerateMinimizedElements(global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutMinimized = this.GridBagLayoutMinimized;
			gridBagLayoutMinimized.InterItemSpacingHorizontal = this._panel.GetInterTileSpacing(false, global::Infragistics.Windows.Tiles.TileState.Minimized);
			gridBagLayoutMinimized.InterItemSpacingVertical = this._panel.GetInterTileSpacing(true, global::Infragistics.Windows.Tiles.TileState.Minimized);
			bool showAllMinimizedTiles = this._panel.GetShowAllMinimizedTiles();
			if (showAllMinimizedTiles != this._lastShowAllTiles)
			{
				this._lastShowAllTiles = showAllMinimizedTiles;
				if (showAllMinimizedTiles)
				{
					this._scrollPosition = 0;
					this._scrollLogicalOffset = 0;
				}
			}
			gridBagLayoutMinimized.ShrinkToFitHeight = null;
			gridBagLayoutMinimized.ShrinkToFitWidth = null;
			int maxRows;
			int maxCols;
			global::System.Windows.Controls.Orientation orientation;
			switch (this._maximizedTileLocation)
			{
			case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Left:
			case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Right:
				maxRows = 0;
				maxCols = 1;
				orientation = global::System.Windows.Controls.Orientation.Horizontal;
				if (showAllMinimizedTiles)
				{
					gridBagLayoutMinimized.ShrinkToFitHeight = new bool?(true);
				}
				gridBagLayoutMinimized.ShrinkToFitWidth = new bool?(true);
				goto IL_E7;
			}
			maxRows = 1;
			maxCols = 0;
			orientation = global::System.Windows.Controls.Orientation.Vertical;
			if (showAllMinimizedTiles)
			{
				gridBagLayoutMinimized.ShrinkToFitWidth = new bool?(true);
			}
			gridBagLayoutMinimized.ShrinkToFitHeight = new bool?(true);
			IL_E7:
			gridBagLayoutMinimized.HorizontalContentAlignment = this._panel.GetHorizontalTileAreaAlignment();
			gridBagLayoutMinimized.VerticalContentAlignment = this._panel.GetVerticalTileAreaAlignment();
			gridBagLayoutMinimized.ExpandToFitWidth = (gridBagLayoutMinimized.HorizontalContentAlignment == global::System.Windows.HorizontalAlignment.Stretch);
			gridBagLayoutMinimized.ExpandToFitHeight = (gridBagLayoutMinimized.VerticalContentAlignment == global::System.Windows.VerticalAlignment.Stretch);
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection gridBagLayoutItemDimensionsCollection = this.CalculateAutoLayoutHelper(gridBagLayoutMinimized, genCache, new global::Infragistics.Windows.Internal.TileManager.LayoutItemGeneratorEnumerator(this, genCache, false, this._scrollPosition, orientation, global::Infragistics.Windows.Selection.ScrollDirection.Increment), showAllMinimizedTiles, this._panel.TileAreaSize, 1, 1, maxRows, maxCols, orientation);
			this._minimizedTileArea.InitializeCachedSizes(gridBagLayoutItemDimensionsCollection);
			switch (this._maximizedTileLocation)
			{
			case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Left:
			case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Right:
				this._totalColumnsDisplayed++;
				this._totalRowsDisplayed = global::System.Math.Max(gridBagLayoutItemDimensionsCollection.RowDims.Length - 1, this._totalMaximizedRows);
				return;
			}
			this._totalRowsDisplayed++;
			this._totalColumnsDisplayed = global::System.Math.Max(gridBagLayoutItemDimensionsCollection.ColumnDims.Length - 1, this._totalMaximizedColumns);
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00034050 File Offset: 0x00032250
		private void GenerateNormalElements(global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache)
		{
			global::System.Windows.Controls.Orientation orientation;
			switch (this._tileLayoutOrder)
			{
			default:
				orientation = global::System.Windows.Controls.Orientation.Vertical;
				break;
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.VerticalVariable:
				this.GenerateNormalVariableElements(genCache, false);
				return;
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.Horizontal:
				orientation = global::System.Windows.Controls.Orientation.Horizontal;
				break;
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.HorizontalVariable:
				this.GenerateNormalVariableElements(genCache, true);
				return;
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.UseExplicitRowColumnOnTile:
				this.GenerateNormalExplicitElements(genCache);
				return;
			}
			this._lastNormalModeItemsPerRowColumn = this._normalModeItemsPerRowColumn;
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutNormal = this.GridBagLayoutNormal;
			gridBagLayoutNormal.InterItemSpacingHorizontal = this._panel.GetInterTileSpacing(false, global::Infragistics.Windows.Tiles.TileState.Normal);
			gridBagLayoutNormal.InterItemSpacingVertical = this._panel.GetInterTileSpacing(true, global::Infragistics.Windows.Tiles.TileState.Normal);
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection gridBagLayoutItemDimensionsCollection = null;
			bool showAllTiles = this._panel.GetShowAllTiles();
			if (showAllTiles != this._lastShowAllTiles)
			{
				this._lastShowAllTiles = showAllTiles;
				if (showAllTiles)
				{
					this._scrollPosition = 0;
					this._scrollLogicalOffset = 0;
				}
			}
			if (showAllTiles)
			{
				gridBagLayoutNormal.ShrinkToFitHeight = new bool?(true);
				gridBagLayoutNormal.ShrinkToFitWidth = new bool?(true);
			}
			else
			{
				gridBagLayoutNormal.ShrinkToFitHeight = null;
				gridBagLayoutNormal.ShrinkToFitWidth = null;
			}
			gridBagLayoutNormal.HorizontalContentAlignment = this._panel.GetHorizontalTileAreaAlignment();
			gridBagLayoutNormal.VerticalContentAlignment = this._panel.GetVerticalTileAreaAlignment();
			gridBagLayoutNormal.ExpandToFitWidth = (gridBagLayoutNormal.HorizontalContentAlignment == global::System.Windows.HorizontalAlignment.Stretch);
			gridBagLayoutNormal.ExpandToFitHeight = (gridBagLayoutNormal.VerticalContentAlignment == global::System.Windows.VerticalAlignment.Stretch);
			gridBagLayoutNormal.LayoutMode = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutMode.Standard;
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection gridBagLayoutItemDimensionsCollection2 = this.CalculateAutoLayoutHelper(gridBagLayoutNormal, genCache, new global::Infragistics.Windows.Internal.TileManager.LayoutItemGeneratorEnumerator(this, genCache, false, this._scrollPosition, orientation, global::Infragistics.Windows.Selection.ScrollDirection.Increment), showAllTiles, this._panel.TileAreaSize, this._panel.GetMinRows(), this._panel.GetMinColumns(), this._panel.GetMaxRows(), this._panel.GetMaxColumns(), orientation);
			if (orientation == global::System.Windows.Controls.Orientation.Vertical)
			{
				this._normalModeRowColumnsInViewActual = gridBagLayoutItemDimensionsCollection2.ColumnDims.Length - 1;
				this._normalModeItemsPerRowColumnActual = gridBagLayoutItemDimensionsCollection2.RowDims.Length - 1;
			}
			else
			{
				this._normalModeRowColumnsInViewActual = gridBagLayoutItemDimensionsCollection2.RowDims.Length - 1;
				this._normalModeItemsPerRowColumnActual = gridBagLayoutItemDimensionsCollection2.ColumnDims.Length - 1;
			}
			if (gridBagLayoutItemDimensionsCollection == null)
			{
				gridBagLayoutItemDimensionsCollection = gridBagLayoutItemDimensionsCollection2;
			}
			int num = gridBagLayoutItemDimensionsCollection.ColumnDims.Length;
			int num2 = gridBagLayoutItemDimensionsCollection.RowDims.Length;
			this._totalColumnsDisplayed = num - 1;
			this._totalRowsDisplayed = num2 - 1;
			int normalModeItemsPerRowColumn;
			int num3;
			if (orientation == global::System.Windows.Controls.Orientation.Vertical)
			{
				normalModeItemsPerRowColumn = this._totalRowsDisplayed;
				num3 = this._totalColumnsDisplayed;
				if (!gridBagLayoutNormal.ExpandToFitWidth && num3 > 1 && gridBagLayoutItemDimensionsCollection.ColumnDims[num - 1] > this._panel.TileAreaSize.Width)
				{
					num3--;
				}
			}
			else
			{
				normalModeItemsPerRowColumn = this._totalColumnsDisplayed;
				num3 = this._totalRowsDisplayed;
				if (!gridBagLayoutNormal.ExpandToFitHeight && num3 > 1 && gridBagLayoutItemDimensionsCollection.RowDims[num2 - 1] > this._panel.TileAreaSize.Height)
				{
					num3--;
				}
			}
			if (this._scrollLogicalOffset == 0 || !this._wasLastScrollableItemGened || this._normalModeRowColumnsInView < 1 || this._normalModeItemsPerRowColumn < 1)
			{
				this._normalModeItemsPerRowColumn = normalModeItemsPerRowColumn;
				this._normalModeRowColumnsInView = num3;
				if (this._lastNormalModeItemsPerRowColumn < 1)
				{
					this._lastNormalModeItemsPerRowColumn = this._normalModeItemsPerRowColumn;
					return;
				}
			}
			else if (num3 > this._normalModeRowColumnsInView)
			{
				this._normalModeRowColumnsInView = num3 - 1;
			}
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00034344 File Offset: 0x00032544
		private void GenerateNormalExplicitElements(global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache)
		{
			bool flag = false;
			switch (this._explicitTileSizeBehavior)
			{
			case global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior.SynchronizeTileWidthsAcrossRows:
			case global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior.SynchronizeTileHeightsAcrossColumns:
				flag = true;
				break;
			}
			double interTileSpacing = this._panel.GetInterTileSpacing(false, global::Infragistics.Windows.Tiles.TileState.Normal);
			double interTileSpacing2 = this._panel.GetInterTileSpacing(true, global::Infragistics.Windows.Tiles.TileState.Normal);
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutManager;
			if (flag)
			{
				gridBagLayoutManager = this.GridBagLayoutNormalModeOverall;
			}
			else
			{
				gridBagLayoutManager = this.GridBagLayoutNormal;
			}
			gridBagLayoutManager.InterItemSpacingHorizontal = interTileSpacing;
			gridBagLayoutManager.InterItemSpacingVertical = interTileSpacing2;
			gridBagLayoutManager.HorizontalContentAlignment = this._panel.GetHorizontalTileAreaAlignment();
			gridBagLayoutManager.VerticalContentAlignment = this._panel.GetVerticalTileAreaAlignment();
			gridBagLayoutManager.ExpandToFitWidth = (gridBagLayoutManager.HorizontalContentAlignment == global::System.Windows.HorizontalAlignment.Stretch);
			gridBagLayoutManager.ExpandToFitHeight = (gridBagLayoutManager.VerticalContentAlignment == global::System.Windows.VerticalAlignment.Stretch);
			gridBagLayoutManager.LayoutMode = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutMode.Uniform;
			global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection layoutItems = gridBagLayoutManager.LayoutItems;
			global::System.Collections.IList items = this.Items;
			int count = items.Count;
			global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint> list = null;
			global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem> list2 = null;
			if (flag)
			{
				list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint>(count);
				list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem>();
				if (genCache._previousGridBagLayoutNormalModeOverall != null)
				{
					global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection layoutItems2 = genCache._previousGridBagLayoutNormalModeOverall.LayoutItems;
					for (int i = 0; i < layoutItems2.Count; i++)
					{
						global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem explicitRowColumnLayoutItem = layoutItems2[i] as global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem;
						if (explicitRowColumnLayoutItem != null)
						{
							list2.Add(explicitRowColumnLayoutItem);
						}
					}
				}
			}
			layoutItems.Clear();
			for (int j = 0; j < count; j++)
			{
				global::System.Windows.DependencyObject dependencyObject = genCache.GenerateElement(j);
				global::System.Windows.UIElement uielement = dependencyObject as global::System.Windows.UIElement;
				if (dependencyObject != null && (uielement == null || uielement.Visibility != global::System.Windows.Visibility.Collapsed))
				{
					object item = this.GetItem(j, false);
					global::System.Windows.Controls.Dock enterFromSide = global::System.Windows.Controls.Dock.Right;
					global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = this.InitializeLayoutItem(dependencyObject, item, enterFromSide);
					this.AddItemToBeArranged(layoutItem);
					this._itemsInView.Add(layoutItem.ItemInfo);
					global::Infragistics.Windows.Internal.TileManager.UpdateGenCacheOnItemAdded(genCache, layoutItem);
					if (flag)
					{
						list.Add(layoutItem);
					}
					else
					{
						layoutItems.Add(layoutItem, layoutItem);
					}
					global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gridBagConstraint = layoutItem;
					this._totalColumnsDisplayed = global::System.Math.Max(gridBagConstraint.Column + gridBagConstraint.ColumnSpan, this._totalColumnsDisplayed);
					this._totalRowsDisplayed = global::System.Math.Max(gridBagConstraint.Row + gridBagConstraint.RowSpan, this._totalRowsDisplayed);
				}
			}
			if (!flag || list.Count == 0)
			{
				return;
			}
			if (list.Count > 1)
			{
				list.Sort(new global::Infragistics.Windows.Internal.TileManager.ExplicitLayoutItemComparer(this._explicitTileSizeBehavior));
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnSection> list3 = new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnSection>();
			int num = 0;
			int num2 = -1;
			foreach (global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gridBagConstraint2 in list)
			{
				int num3;
				int num4;
				if (this._explicitTileSizeBehavior == global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior.SynchronizeTileHeightsAcrossColumns)
				{
					num3 = gridBagConstraint2.Row;
					num4 = gridBagConstraint2.RowSpan;
				}
				else
				{
					num3 = gridBagConstraint2.Column;
					num4 = gridBagConstraint2.ColumnSpan;
				}
				int num5 = num3 + num4 - 1;
				global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnSection explicitRowColumnSection = null;
				if (num3 <= num2)
				{
					for (int k = num - 1; k >= 0; k--)
					{
						if (list3[k].Intersects(num3, num5))
						{
							explicitRowColumnSection = list3[k];
							explicitRowColumnSection.Add(gridBagConstraint2, num3, num5);
							break;
						}
					}
				}
				if (explicitRowColumnSection == null)
				{
					list3.Add(new global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnSection
					{
						_endRowCol = num5,
						_startRowCol = num3,
						_span = num4,
						_items = 
						{
							gridBagConstraint2
						}
					});
					num++;
				}
				num2 = global::System.Math.Max(num2, num5);
			}
			int num6 = list2.Count;
			foreach (global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnSection section in list3)
			{
				global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem explicitRowColumnLayoutItem2 = null;
				for (int l = 0; l < num6; l++)
				{
					if (list2[l].isEquivalent(section))
					{
						explicitRowColumnLayoutItem2 = list2[l];
						list2.RemoveAt(l);
						num6--;
						break;
					}
				}
				if (explicitRowColumnLayoutItem2 == null)
				{
					explicitRowColumnLayoutItem2 = new global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem(this, section);
				}
				else
				{
					explicitRowColumnLayoutItem2.GridBagManager.InvalidateLayout();
				}
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagManager = explicitRowColumnLayoutItem2.GridBagManager;
				gridBagManager.InterItemSpacingHorizontal = interTileSpacing;
				gridBagManager.InterItemSpacingVertical = interTileSpacing2;
				gridBagManager.HorizontalContentAlignment = gridBagLayoutManager.HorizontalContentAlignment;
				gridBagManager.VerticalContentAlignment = gridBagLayoutManager.VerticalContentAlignment;
				gridBagManager.ExpandToFitWidth = (gridBagLayoutManager.HorizontalContentAlignment == global::System.Windows.HorizontalAlignment.Stretch);
				gridBagManager.ExpandToFitHeight = (gridBagLayoutManager.VerticalContentAlignment == global::System.Windows.VerticalAlignment.Stretch);
				gridBagManager.LayoutMode = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutMode.Uniform;
				explicitRowColumnLayoutItem2.CalculateminMaxPreffered();
				layoutItems.Add(explicitRowColumnLayoutItem2, explicitRowColumnLayoutItem2);
			}
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x000347B0 File Offset: 0x000329B0
		private void GenerateNormalVariableElements(global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache, bool createRows)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutNormalModeOverall = this.GridBagLayoutNormalModeOverall;
			gridBagLayoutNormalModeOverall.HorizontalContentAlignment = this._panel.GetHorizontalTileAreaAlignment();
			gridBagLayoutNormalModeOverall.VerticalContentAlignment = this._panel.GetVerticalTileAreaAlignment();
			gridBagLayoutNormalModeOverall.ExpandToFitWidth = (gridBagLayoutNormalModeOverall.HorizontalContentAlignment == global::System.Windows.HorizontalAlignment.Stretch);
			gridBagLayoutNormalModeOverall.ExpandToFitHeight = (gridBagLayoutNormalModeOverall.VerticalContentAlignment == global::System.Windows.VerticalAlignment.Stretch);
			gridBagLayoutNormalModeOverall.LayoutMode = global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager.GridBagLayoutMode.Standard;
			bool showAllTiles = this._panel.GetShowAllTiles();
			if (showAllTiles)
			{
				gridBagLayoutNormalModeOverall.ShrinkToFitHeight = new bool?(true);
				gridBagLayoutNormalModeOverall.ShrinkToFitWidth = new bool?(true);
			}
			else
			{
				gridBagLayoutNormalModeOverall.ShrinkToFitHeight = new bool?(false);
				gridBagLayoutNormalModeOverall.ShrinkToFitWidth = new bool?(false);
				if (this._scrollLogicalOffset > 0)
				{
					global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection layoutItemsCollection = (genCache._previousGridBagLayoutNormalModeOverall != null) ? genCache._previousGridBagLayoutNormalModeOverall.LayoutItems : null;
					if (layoutItemsCollection != null)
					{
						int count = layoutItemsCollection.Count;
					}
					if (layoutItemsCollection != null && layoutItemsCollection.Count > 0)
					{
						global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem tileRowColumnLayoutItem = (global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem)layoutItemsCollection[0];
						global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem tileRowColumnLayoutItem2 = (global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem)layoutItemsCollection[layoutItemsCollection.Count - 1];
						if (tileRowColumnLayoutItem.FirstChildLayoutItem == null)
						{
							genCache._previousGridBagLayoutNormalModeOverall = null;
						}
						else if (this._scrollLogicalOffset >= tileRowColumnLayoutItem.ScrollOffset && this._scrollLogicalOffset <= tileRowColumnLayoutItem2.ScrollOffset)
						{
							global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem tileRowColumnLayoutItem3 = (global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem)layoutItemsCollection[this._scrollLogicalOffset - tileRowColumnLayoutItem.ScrollOffset];
							this._scrollPosition = tileRowColumnLayoutItem3.GetFirstScrollPosition();
						}
						else
						{
							int num;
							if (this._scrollLogicalOffset < tileRowColumnLayoutItem.ScrollOffset)
							{
								num = tileRowColumnLayoutItem.ScrollOffset - this._scrollLogicalOffset;
							}
							else
							{
								num = this._scrollLogicalOffset - tileRowColumnLayoutItem2.ScrollOffset;
							}
							double num2 = (double)num * this._variableAvgItemsPerRowColumn;
							if (num2 <= global::System.Math.Max(this._variableAvgItemsPerRowColumn * (double)(layoutItemsCollection.Count + 1), 20.0))
							{
								int num3;
								int num4;
								global::Infragistics.Windows.Selection.ScrollDirection scrollDirection;
								int num5;
								if (this._scrollLogicalOffset < tileRowColumnLayoutItem.ScrollOffset)
								{
									num3 = tileRowColumnLayoutItem.ScrollOffset;
									num4 = -1;
									scrollDirection = global::Infragistics.Windows.Selection.ScrollDirection.Decrement;
									num5 = tileRowColumnLayoutItem.GetFirstScrollPosition();
								}
								else
								{
									num3 = tileRowColumnLayoutItem2.ScrollOffset;
									num4 = 1;
									scrollDirection = global::Infragistics.Windows.Selection.ScrollDirection.Increment;
									num5 = tileRowColumnLayoutItem2.GetLastScrollPosition();
								}
								int num6 = num5;
								bool flag = false;
								while (num3 != this._scrollLogicalOffset && num3 > 0 && num5 > 0 && num5 < this._sparseArray.ScrollCount)
								{
									num3 += num4;
									num5 += num4;
									flag = true;
									global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection gridBagLayoutItemDimensionsCollection = gridBagLayoutNormalModeOverall.CalculateAutoLayout(new global::Infragistics.Windows.Internal.TileManager.TileRowColumnGeneratorEnumerator(this, genCache, createRows, num5, num3, scrollDirection), createRows ? global::System.Windows.Controls.Orientation.Vertical : global::System.Windows.Controls.Orientation.Horizontal, false, this._panel.TileAreaSize, 1, 1, 1, 1, null);
									this._wasLastScrollableItemGened = false;
									global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem tileRowColumnLayoutItem4 = null;
									foreach (object obj in ((global::System.Collections.IEnumerable)gridBagLayoutItemDimensionsCollection))
									{
										global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem tileRowColumnLayoutItem5 = (global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem)obj;
										tileRowColumnLayoutItem4 = tileRowColumnLayoutItem5;
									}
									if (tileRowColumnLayoutItem4 == null)
									{
										break;
									}
									if (scrollDirection == global::Infragistics.Windows.Selection.ScrollDirection.Decrement)
									{
										num5 = tileRowColumnLayoutItem4.LastScrollPositionGenerated;
									}
									if (num5 == num6)
									{
										if (scrollDirection == global::Infragistics.Windows.Selection.ScrollDirection.Increment)
										{
											num5++;
										}
										else
										{
											num5--;
										}
									}
									num6 = num5;
								}
								if (!flag)
								{
									num5 += num4;
									num3 += num4;
								}
								if (num5 < 0)
								{
									num5 = 0;
								}
								num5 = global::System.Math.Min(num5, this._sparseArray.ScrollCount - 1);
								if (num5 == 0)
								{
									num3 = 0;
								}
								this._scrollPosition = num5;
								this._scrollLogicalOffset = num3;
							}
						}
					}
				}
			}
			gridBagLayoutNormalModeOverall.InterItemSpacingHorizontal = this._panel.GetInterTileSpacing(false, global::Infragistics.Windows.Tiles.TileState.Normal);
			gridBagLayoutNormalModeOverall.InterItemSpacingVertical = this._panel.GetInterTileSpacing(true, global::Infragistics.Windows.Tiles.TileState.Normal);
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection gridBagLayoutItemDimensionsCollection2 = this.CalculateAutoLayoutHelper(gridBagLayoutNormalModeOverall, genCache, new global::Infragistics.Windows.Internal.TileManager.TileRowColumnGeneratorEnumerator(this, genCache, createRows, this._scrollPosition, this._scrollLogicalOffset, global::Infragistics.Windows.Selection.ScrollDirection.Increment), showAllTiles, this._panel.TileAreaSize, createRows ? this._panel.GetMinRows() : 1, createRows ? 1 : this._panel.GetMinColumns(), createRows ? this._panel.GetMaxRows() : 1, createRows ? 1 : this._panel.GetMaxColumns(), createRows ? global::System.Windows.Controls.Orientation.Horizontal : global::System.Windows.Controls.Orientation.Vertical);
			if (createRows)
			{
				this._totalRowsDisplayed = gridBagLayoutItemDimensionsCollection2.RowDims.Length - 1;
				if (this._totalRowsDisplayed > 1)
				{
					double num7 = gridBagLayoutItemDimensionsCollection2.RowDims[this._totalRowsDisplayed];
					if (num7 > this._panel.TileAreaSize.Height)
					{
						this._totalRowsDisplayed--;
						return;
					}
				}
			}
			else
			{
				this._totalColumnsDisplayed = gridBagLayoutItemDimensionsCollection2.ColumnDims.Length - 1;
				if (this._totalColumnsDisplayed > 1)
				{
					double num8 = gridBagLayoutItemDimensionsCollection2.ColumnDims[this._totalColumnsDisplayed];
					if (num8 > this._panel.TileAreaSize.Width)
					{
						this._totalColumnsDisplayed--;
					}
				}
			}
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00034C38 File Offset: 0x00032E38
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager GetContainingGridBagLayoutManager(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem, out global::Infragistics.Controls.Layouts.Primitives.ILayoutItem sectionContainer)
		{
			sectionContainer = null;
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutManager = null;
			if (this._isInMaximizedMode)
			{
				gridBagLayoutManager = this.GridBagLayoutMaximizedModeOverall;
				if (gridBagLayoutManager == null || !(layoutItem is global::Infragistics.Windows.Internal.TileManager.LayoutItem))
				{
					goto IL_19A;
				}
				using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)gridBagLayoutManager.LayoutItems).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem2 = enumerator.Current;
						global::Infragistics.Windows.Internal.TileManager.TileAreaLayoutItem tileAreaLayoutItem = (global::Infragistics.Windows.Internal.TileManager.TileAreaLayoutItem)layoutItem2;
						if (tileAreaLayoutItem != null && tileAreaLayoutItem.GridBagManager.LayoutItems.Contains(layoutItem))
						{
							return tileAreaLayoutItem.GridBagManager;
						}
					}
					goto IL_19A;
				}
			}
			switch (this._tileLayoutOrder)
			{
			default:
				gridBagLayoutManager = this.GridBagLayoutNormal;
				goto IL_19A;
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.VerticalVariable:
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.HorizontalVariable:
				break;
			case global::Infragistics.Windows.Tiles.TileLayoutOrder.UseExplicitRowColumnOnTile:
				if (this._explicitTileSizeBehavior == global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior.SynchronizeTileWidthsAndHeights)
				{
					gridBagLayoutManager = this.GridBagLayoutNormal;
					goto IL_19A;
				}
				gridBagLayoutManager = this.GridBagLayoutNormalModeOverall;
				if (gridBagLayoutManager == null || !(layoutItem is global::Infragistics.Windows.Internal.TileManager.LayoutItem))
				{
					goto IL_19A;
				}
				using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> enumerator2 = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)gridBagLayoutManager.LayoutItems).GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem3 = enumerator2.Current;
						global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem explicitRowColumnLayoutItem = (global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem)layoutItem3;
						if (explicitRowColumnLayoutItem != null && explicitRowColumnLayoutItem.GridBagManager.LayoutItems.Contains(layoutItem))
						{
							sectionContainer = explicitRowColumnLayoutItem;
							return explicitRowColumnLayoutItem.GridBagManager;
						}
					}
					goto IL_19A;
				}
				break;
			}
			gridBagLayoutManager = this.GridBagLayoutNormalModeOverall;
			if (gridBagLayoutManager != null && layoutItem is global::Infragistics.Windows.Internal.TileManager.LayoutItem)
			{
				foreach (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem4 in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)gridBagLayoutManager.LayoutItems))
				{
					global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem tileRowColumnLayoutItem = (global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem)layoutItem4;
					if (tileRowColumnLayoutItem != null && tileRowColumnLayoutItem.GridBagManager.LayoutItems.Contains(layoutItem))
					{
						sectionContainer = tileRowColumnLayoutItem;
						return tileRowColumnLayoutItem.GridBagManager;
					}
				}
			}
			IL_19A:
			if (gridBagLayoutManager != null && gridBagLayoutManager.LayoutItems.Contains(layoutItem))
			{
				return gridBagLayoutManager;
			}
			return null;
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00034E20 File Offset: 0x00033020
		private int GetCurrenRowColumnHelper(global::Infragistics.Windows.Tiles.ItemInfoBase info, bool isColumn)
		{
			global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = this.GetLayoutItem(info.Item);
			if (layoutItem == null)
			{
				return -1;
			}
			if (this._isInMaximizedMode)
			{
				if (info.GetIsMaximized())
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutMaximized = this.GridBagLayoutMaximized;
					int rowColumnSlot = this.GetRowColumnSlot(isColumn, layoutItem, gridBagLayoutMaximized);
					if (rowColumnSlot < 1)
					{
						return -1;
					}
					switch (this._maximizedTileLocation)
					{
					case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Right:
						if (isColumn)
						{
							return rowColumnSlot + 1;
						}
						break;
					case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Bottom:
						if (!isColumn)
						{
							return rowColumnSlot + 1;
						}
						break;
					}
					return rowColumnSlot;
				}
				else
				{
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutMinimized = this.GridBagLayoutMinimized;
					int num = gridBagLayoutMinimized.LayoutItems.IndexOf(layoutItem);
					if (num < 1)
					{
						return -1;
					}
					switch (this._maximizedTileLocation)
					{
					case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Left:
						if (isColumn)
						{
							num += this._totalMaximizedColumns;
						}
						break;
					case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Right:
						if (isColumn)
						{
							return 0;
						}
						break;
					case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Top:
						if (!isColumn)
						{
							num += this._totalMaximizedRows;
						}
						break;
					case global::Infragistics.Windows.Tiles.MaximizedTileLocation.Bottom:
						if (!isColumn)
						{
							return 0;
						}
						break;
					}
					return num;
				}
			}
			else if (this._tileLayoutOrder == global::Infragistics.Windows.Tiles.TileLayoutOrder.UseExplicitRowColumnOnTile)
			{
				if (!isColumn)
				{
					return info.GetCurrentRow();
				}
				return info.GetCurrentColumn();
			}
			else
			{
				global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem2;
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager containingGridBagLayoutManager = this.GetContainingGridBagLayoutManager(layoutItem, out layoutItem2);
				if (containingGridBagLayoutManager == null)
				{
					return -1;
				}
				containingGridBagLayoutManager.GetLayoutItemDimensions(this, containingGridBagLayoutManager);
				global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem tileRowColumnLayoutItem = layoutItem2 as global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem;
				if (tileRowColumnLayoutItem != null)
				{
					switch (this._tileLayoutOrder)
					{
					case global::Infragistics.Windows.Tiles.TileLayoutOrder.VerticalVariable:
						if (isColumn)
						{
							return this.GetRowColumnSlot(isColumn, tileRowColumnLayoutItem, this.GridBagLayoutNormalModeOverall);
						}
						break;
					case global::Infragistics.Windows.Tiles.TileLayoutOrder.HorizontalVariable:
						if (!isColumn)
						{
							return this.GetRowColumnSlot(isColumn, tileRowColumnLayoutItem, this.GridBagLayoutNormalModeOverall);
						}
						break;
					}
				}
				return this.GetRowColumnSlot(isColumn, layoutItem, containingGridBagLayoutManager);
			}
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00034F98 File Offset: 0x00033198
		private global::Infragistics.Windows.Tiles.ITileConstraints GetItemConstraints(global::System.Windows.DependencyObject element)
		{
			if (this._lastElement != element)
			{
				this._lastElement = element;
				global::Infragistics.Windows.Tiles.TileState containerState = this._panel.GetContainerState(element);
				if (this._lastElementState == null || containerState != this._lastElementState.Value)
				{
					this._lastElementState = new global::Infragistics.Windows.Tiles.TileState?(containerState);
					this._lastElementDefaultConstraints = this._panel.GetDefaultConstraints(containerState);
				}
				this._lastElementConstraints = this._panel.GetContainerConstraints(element, containerState);
			}
			return this._lastElementConstraints;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00035014 File Offset: 0x00033214
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.ItemRowColumnSizeInfo> GetItemRowColumnSnapshot()
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.ItemRowColumnSizeInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.ItemRowColumnSizeInfo>();
			if (this._isInMaximizedMode)
			{
				this.GetItemRowColumnSnapshotHelper(list, this.GridBagLayoutMaximized.LayoutItems, null, null);
				this.GetItemRowColumnSnapshotHelper(list, this.GridBagLayoutMinimized.LayoutItems, null, null);
			}
			else
			{
				switch (this._tileLayoutOrder)
				{
				default:
					this.GetItemRowColumnSnapshotHelper(list, this.GridBagLayoutNormal.LayoutItems, null, null);
					break;
				case global::Infragistics.Windows.Tiles.TileLayoutOrder.VerticalVariable:
				case global::Infragistics.Windows.Tiles.TileLayoutOrder.HorizontalVariable:
				{
					global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection layoutItems = this.GridBagLayoutNormalModeOverall.LayoutItems;
					int count = layoutItems.Count;
					int? explicitRow = null;
					int? explicitColumn = null;
					bool flag = this._tileLayoutOrder == global::Infragistics.Windows.Tiles.TileLayoutOrder.VerticalVariable;
					for (int i = 0; i < count; i++)
					{
						global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem tileRowColumnLayoutItem = layoutItems[i] as global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem;
						if (tileRowColumnLayoutItem == null)
						{
							break;
						}
						if (flag)
						{
							explicitColumn = new int?(i);
						}
						else
						{
							explicitRow = new int?(i);
						}
						this.GetItemRowColumnSnapshotHelper(list, tileRowColumnLayoutItem.GridBagManager.LayoutItems, explicitRow, explicitColumn);
					}
					break;
				}
				}
			}
			return list;
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00035148 File Offset: 0x00033348
		private void GetItemRowColumnSnapshotHelper(global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.ItemRowColumnSizeInfo> list, global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection layoutItems, int? explicitRow, int? explicitColumn)
		{
			int count = layoutItems.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = (global::Infragistics.Windows.Internal.TileManager.LayoutItem)layoutItems[i];
				if (layoutItem == null)
				{
					return;
				}
				global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gridBagConstraint = layoutItem;
				list.Add(new global::Infragistics.Windows.Internal.TileManager.ItemRowColumnSizeInfo(layoutItem.ItemInfo, (explicitRow != null) ? explicitRow.Value : gridBagConstraint.Row, (explicitColumn != null) ? explicitColumn.Value : gridBagConstraint.Column, layoutItem.TargetRect, layoutItem.PreferredSizeCache));
			}
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x000351C8 File Offset: 0x000333C8
		private object GetRowColumnProperty(global::System.Windows.DependencyObject element, global::System.Windows.DependencyProperty property)
		{
			this.GetItemConstraints(element);
			global::Infragistics.Windows.Tiles.TileState tileState;
			if (this._lastElementState != null)
			{
				tileState = this._lastElementState.Value;
			}
			else
			{
				tileState = global::Infragistics.Windows.Tiles.TileState.Normal;
			}
			bool flag = false;
			switch (tileState)
			{
			case global::Infragistics.Windows.Tiles.TileState.Normal:
				return element.GetValue(property);
			case global::Infragistics.Windows.Tiles.TileState.Maximized:
				flag = true;
				break;
			}
			bool isMaximizedAreaLeftOrRight = this.IsMaximizedAreaLeftOrRight;
			string name;
			if ((name = property.Name) != null)
			{
				if (!(name == "Column"))
				{
					if (!(name == "ColumnSpan"))
					{
						if (name == "ColumnWeight")
						{
							return 0f;
						}
						if (!(name == "Row"))
						{
							if (!(name == "RowSpan"))
							{
								if (name == "RowWeight")
								{
									if (isMaximizedAreaLeftOrRight && tileState == global::Infragistics.Windows.Tiles.TileState.MinimizedExpanded)
									{
										return 1f;
									}
									return 0f;
								}
							}
							else
							{
								if (flag)
								{
									return (this._maximizedTileLayoutOrder == global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder.SingleRow) ? 1 : 0;
								}
								return isMaximizedAreaLeftOrRight ? 0 : 1;
							}
						}
						else
						{
							if (flag)
							{
								return (this._maximizedTileLayoutOrder == global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder.SingleRow) ? 0 : -1;
							}
							return isMaximizedAreaLeftOrRight ? -1 : 0;
						}
					}
					else
					{
						if (flag)
						{
							return (this._maximizedTileLayoutOrder == global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder.SingleColumn) ? 1 : 0;
						}
						return isMaximizedAreaLeftOrRight ? 1 : 0;
					}
				}
				else
				{
					if (flag)
					{
						return (this._maximizedTileLayoutOrder == global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder.SingleColumn) ? 0 : -1;
					}
					return isMaximizedAreaLeftOrRight ? 0 : -1;
				}
			}
			return null;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00035344 File Offset: 0x00033544
		private int GetRowColumnSlot(bool isColumn, global::Infragistics.Controls.Layouts.Primitives.ILayoutItem li, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gbm)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection layoutItemDimensions = gbm.GetLayoutItemDimensions(this, gbm);
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions gridBagLayoutItemDimensions = layoutItemDimensions[li];
			if (gridBagLayoutItemDimensions == null)
			{
				return -1;
			}
			if (isColumn)
			{
				return gridBagLayoutItemDimensions.Column;
			}
			return gridBagLayoutItemDimensions.Row;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00035378 File Offset: 0x00033578
		private global::Infragistics.Windows.Internal.TileManager.TileAreaLayoutItem GetTileAreaLayoutItem(global::Infragistics.Windows.Internal.TileManager.TileArea area)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutMaximizedModeOverall = this.GridBagLayoutMaximizedModeOverall;
			int count = gridBagLayoutMaximizedModeOverall.LayoutItems.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.Internal.TileManager.TileAreaLayoutItem tileAreaLayoutItem = gridBagLayoutMaximizedModeOverall.LayoutItems[i] as global::Infragistics.Windows.Internal.TileManager.TileAreaLayoutItem;
				if (tileAreaLayoutItem != null && tileAreaLayoutItem.Area == area)
				{
					return tileAreaLayoutItem;
				}
			}
			return null;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x000353C8 File Offset: 0x000335C8
		private bool ItemResizeHelper(global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo, double deltaX, double deltaY)
		{
			global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = this.GetLayoutItem(itemInfo.Item);
			if (layoutItem == null)
			{
				return false;
			}
			if (!this._isInMaximizedMode && (this._tileLayoutOrder == global::Infragistics.Windows.Tiles.TileLayoutOrder.Horizontal || this._tileLayoutOrder == global::Infragistics.Windows.Tiles.TileLayoutOrder.Vertical))
			{
				global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo2 = layoutItem.ItemInfo;
				if (itemInfo2 != null)
				{
					global::System.Windows.Size size = layoutItem.TargetRect.Size;
					size.Width = global::System.Math.Max(1.0, size.Width + deltaX);
					size.Height = global::System.Math.Max(1.0, size.Height + deltaY);
					global::Infragistics.Windows.Internal.TileManager.UpdatePreferredSizeOverride(size, deltaX, deltaY, layoutItem, itemInfo2);
					return true;
				}
				return false;
			}
			else
			{
				global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem2;
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager containingGridBagLayoutManager = this.GetContainingGridBagLayoutManager(layoutItem, out layoutItem2);
				if (containingGridBagLayoutManager == null)
				{
					return false;
				}
				object containerContext = (layoutItem2 != null) ? layoutItem2 : containingGridBagLayoutManager;
				bool expandToFitWidth = containingGridBagLayoutManager.ExpandToFitWidth;
				bool expandToFitHeight = containingGridBagLayoutManager.ExpandToFitHeight;
				bool? shrinkToFitWidth = containingGridBagLayoutManager.ShrinkToFitWidth;
				bool? shrinkToFitHeight = containingGridBagLayoutManager.ShrinkToFitHeight;
				bool autoFitWidth = containingGridBagLayoutManager.HorizontalContentAlignment == global::System.Windows.HorizontalAlignment.Stretch;
				bool autoFitHeight = containingGridBagLayoutManager.VerticalContentAlignment == global::System.Windows.VerticalAlignment.Stretch;
				global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem explicitRowColumnLayoutItem = layoutItem2 as global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem;
				if (explicitRowColumnLayoutItem != null)
				{
					double deltaX2 = 0.0;
					double deltaY2 = 0.0;
					if (this._explicitTileSizeBehavior == global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior.SynchronizeTileWidthsAcrossRows)
					{
						autoFitWidth = false;
						containingGridBagLayoutManager.ExpandToFitWidth = false;
						containingGridBagLayoutManager.ShrinkToFitWidth = new bool?(false);
						deltaX2 = deltaX;
					}
					else
					{
						autoFitHeight = false;
						containingGridBagLayoutManager.ExpandToFitHeight = false;
						containingGridBagLayoutManager.ShrinkToFitHeight = new bool?(false);
						deltaY2 = deltaY;
					}
					global::Infragistics.Windows.Internal.TileManager.SetPreferredSizeOverrideToTargetSize(deltaX2, deltaY2, explicitRowColumnLayoutItem);
				}
				global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> dictionary = containingGridBagLayoutManager.ResizeItem(this, containerContext, layoutItem, deltaX, deltaY, autoFitWidth, autoFitHeight);
				containingGridBagLayoutManager.ExpandToFitWidth = expandToFitWidth;
				containingGridBagLayoutManager.ExpandToFitHeight = expandToFitHeight;
				containingGridBagLayoutManager.ShrinkToFitWidth = shrinkToFitWidth;
				containingGridBagLayoutManager.ShrinkToFitHeight = shrinkToFitHeight;
				int count = dictionary.Count;
				foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> keyValuePair in dictionary)
				{
					global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem3 = keyValuePair.Key as global::Infragistics.Windows.Internal.TileManager.LayoutItem;
					if (layoutItem3 != null)
					{
						global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo3 = layoutItem3.ItemInfo;
						if (itemInfo3 != null)
						{
							double deltaX3 = deltaX;
							double deltaY3 = deltaY;
							if (layoutItem3 != layoutItem)
							{
								if (this._tileLayoutOrder == global::Infragistics.Windows.Tiles.TileLayoutOrder.HorizontalVariable)
								{
									deltaY3 = 0.0;
								}
								else if (this._tileLayoutOrder == global::Infragistics.Windows.Tiles.TileLayoutOrder.VerticalVariable)
								{
									deltaX3 = 0.0;
								}
							}
							global::Infragistics.Windows.Internal.TileManager.UpdatePreferredSizeOverride(keyValuePair.Value, deltaX3, deltaY3, layoutItem3, itemInfo3);
						}
					}
				}
				if (explicitRowColumnLayoutItem != null)
				{
					bool flag;
					if (this._explicitTileSizeBehavior == global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior.SynchronizeTileWidthsAcrossRows)
					{
						flag = (deltaX != 0.0 && explicitRowColumnLayoutItem.GridBagManager.HorizontalContentAlignment == global::System.Windows.HorizontalAlignment.Stretch);
					}
					else
					{
						flag = (deltaY != 0.0 && explicitRowColumnLayoutItem.GridBagManager.VerticalContentAlignment == global::System.Windows.VerticalAlignment.Stretch);
					}
					if (flag)
					{
						double num = 0.0;
						double num2 = 0.0;
						if (this._explicitTileSizeBehavior == global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior.SynchronizeTileWidthsAcrossRows)
						{
							num = deltaX;
						}
						else
						{
							num2 = deltaY;
						}
						global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutNormalModeOverall = this.GridBagLayoutNormalModeOverall;
						global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> dictionary2 = gridBagLayoutNormalModeOverall.ResizeItem(this, gridBagLayoutNormalModeOverall, explicitRowColumnLayoutItem, num, num2, containingGridBagLayoutManager.HorizontalContentAlignment == global::System.Windows.HorizontalAlignment.Stretch, containingGridBagLayoutManager.VerticalContentAlignment == global::System.Windows.VerticalAlignment.Stretch);
						int count2 = dictionary2.Count;
						foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> keyValuePair2 in dictionary2)
						{
							global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem explicitRowColumnLayoutItem2 = keyValuePair2.Key as global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem;
							if (explicitRowColumnLayoutItem2 != null && explicitRowColumnLayoutItem2 != explicitRowColumnLayoutItem)
							{
								explicitRowColumnLayoutItem2.Rect = new global::System.Windows.Rect(explicitRowColumnLayoutItem2.Rect.Location, keyValuePair2.Value);
								global::Infragistics.Windows.Internal.TileManager.SetPreferredSizeOverrideToTargetSize(num, num2, explicitRowColumnLayoutItem2);
								explicitRowColumnLayoutItem2.GridBagManager.InvalidateLayout();
								explicitRowColumnLayoutItem2.CalculateminMaxPreffered();
							}
						}
						foreach (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem4 in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)explicitRowColumnLayoutItem.GridBagManager.LayoutItems))
						{
							global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem5 = layoutItem4 as global::Infragistics.Windows.Internal.TileManager.LayoutItem;
							if (layoutItem5 != null)
							{
								layoutItem5.DirtyPreferredSizeCache();
							}
						}
						explicitRowColumnLayoutItem.GridBagManager.InvalidateLayout();
						explicitRowColumnLayoutItem.CalculateminMaxPreffered();
					}
				}
				return count > 0;
			}
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x000357C8 File Offset: 0x000339C8
		private void OnItemsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._itemsControl == null)
			{
				return;
			}
			if (this != this._panel.GetManager())
			{
				((global::System.Collections.Specialized.INotifyCollectionChanged)this._itemsControl.Items).CollectionChanged -= this.OnItemsCollectionChanged;
				this._itemsControl = null;
				return;
			}
			this.OnItemsChanged(e);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00035818 File Offset: 0x00033A18
		private void ProcessDimensionsCollection(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gbl, global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection dimsCollection)
		{
			foreach (object obj in ((global::System.Collections.IEnumerable)dimsCollection))
			{
				global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem = (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)obj;
				global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem2 = layoutItem as global::Infragistics.Windows.Internal.TileManager.LayoutItem;
				if (layoutItem2 != null)
				{
					layoutItem2.SetDimensions(dimsCollection[layoutItem2]);
					this.AddItemToBeArranged(layoutItem2);
					this._itemsInView.Add(layoutItem2.ItemInfo);
					global::Infragistics.Windows.Internal.TileManager.UpdateGenCacheOnItemAdded(genCache, layoutItem2);
					if (layoutItem2.ItemInfo.GetIsMaximized() && layoutItem2.Container != null)
					{
						layoutItem2.Container.SetValue(global::System.Windows.Controls.Panel.ZIndexProperty, 1000);
					}
				}
				else
				{
					global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem tileRowColumnLayoutItem = layoutItem as global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem;
					if (tileRowColumnLayoutItem != null)
					{
						tileRowColumnLayoutItem.ProcessGeneratedElements(genCache);
					}
				}
				gbl.LayoutItems.Add(layoutItem, layoutItem);
			}
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x000358F4 File Offset: 0x00033AF4
		private void ProcessResetNotification()
		{
			this._panel.VerifyMaximizedItems();
			try
			{
				if (this._itemsInOriginalOrder != null)
				{
					new global::System.Collections.ArrayList(this._itemsInOriginalOrder.Count);
					global::System.Collections.IList items = this.Items;
					int count = items.Count;
					int count2 = this._itemsInOriginalOrder.Count;
					if (this._sparseArray.Count != count2)
					{
						this._sparseArray.Clear();
						this._sparseArray.Expand(count);
						this._itemsInOriginalOrder = null;
					}
					else
					{
						bool flag = true;
						int num = 0;
						for (int i = count2 - 1; i >= 0; i--)
						{
							object obj = this._itemsInOriginalOrder[i];
							if (obj != null)
							{
								num++;
								if (i >= count || obj != items[i])
								{
									flag = false;
									break;
								}
							}
						}
						if (num == 0 || !flag)
						{
							this._itemsInOriginalOrder = null;
							this._sparseArray.Clear();
						}
						else if (count < count2)
						{
							for (int j = count; j < count2; j++)
							{
								object obj2 = this._itemsInOriginalOrder[j];
								if (obj2 != null)
								{
									global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = this.GetItemInfo(obj2, false, -1);
									if (itemInfo != null)
									{
										this._sparseArray.Remove(itemInfo);
									}
								}
							}
							this._itemsInOriginalOrder.RemoveRange(count, count2 - count);
							int count3 = this._sparseArray.Count;
							if (count3 > count)
							{
								this._sparseArray.RemoveRange(count, count3 - count);
							}
						}
						else if (count > count2)
						{
							this.ExpandCachedItemArrays(count);
						}
					}
				}
			}
			finally
			{
				global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
				foreach (global::System.Collections.Generic.KeyValuePair<object, global::Infragistics.Windows.Tiles.ItemInfoBase> keyValuePair in ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<object, global::Infragistics.Windows.Tiles.ItemInfoBase>>)this._itemInfoMap))
				{
					if (keyValuePair.Value.Index < 0)
					{
						arrayList.Add(keyValuePair.Key);
					}
				}
				int count4 = arrayList.Count;
				for (int k = 0; k < count4; k++)
				{
					this.RemoveItemFromMaps(arrayList[k]);
				}
			}
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00035B14 File Offset: 0x00033D14
		private void RemoveDuplicateContainerRefs(global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem)
		{
			global::System.Windows.DependencyObject container = layoutItem.Container;
			if (container == null)
			{
				return;
			}
			if (this._genCache != null)
			{
				global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem2;
				if (this._genCache._previousItemsToBeArrangedTempCache.TryGetValue(container, out layoutItem2) && layoutItem2 != layoutItem)
				{
					if (this._itemsToBeArranged.Exists(layoutItem2))
					{
						this._itemsToBeArranged.Remove(layoutItem2);
					}
					this._genCache._previousItemsToBeArrangedTempCache.Remove(container);
				}
				return;
			}
			foreach (object obj in this._itemsToBeArranged)
			{
				global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem3 = (global::Infragistics.Windows.Internal.TileManager.LayoutItem)obj;
				if (layoutItem3 != layoutItem && layoutItem3.Container == container)
				{
					this._itemsToBeArranged.Remove(layoutItem3);
					break;
				}
			}
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00035BE0 File Offset: 0x00033DE0
		private void RemoveItemFromMaps(object item)
		{
			global::Infragistics.Windows.Tiles.ItemInfoBase value;
			if (this._itemInfoMap.TryGetValue(item, out value))
			{
				this._itemInfoMap.Remove(item);
				this._sparseArray.Remove(value);
			}
			else if (this._sparseArray.Count > 0)
			{
				this._sparseArray.RemoveAt(this._sparseArray.Count - 1);
			}
			if (this._layoutItemMap.ContainsKey(item))
			{
				global::Infragistics.Windows.Internal.TileManager.LayoutItem li = this._layoutItemMap[item];
				this.RemoveLayoutItem(li);
			}
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00035C60 File Offset: 0x00033E60
		private void RemoveRangeHelper(int startIndex, global::System.Collections.IList list)
		{
			int count = list.Count;
			this._itemsInOriginalOrder.RemoveRange(startIndex, count);
			for (int i = 0; i < count; i++)
			{
				object item = list[i];
				this.RemoveItemFromMaps(item);
			}
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00035C9C File Offset: 0x00033E9C
		private static void SetPreferredSizeOverrideToTargetSize(double deltaX, double deltaY, global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem siblingSection)
		{
			if (deltaX == 0.0 && deltaY == 0.0)
			{
				return;
			}
			foreach (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)siblingSection.GridBagManager.LayoutItems))
			{
				global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem2 = layoutItem as global::Infragistics.Windows.Internal.TileManager.LayoutItem;
				if (layoutItem2 != null)
				{
					global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = layoutItem2.ItemInfo;
					if (itemInfo != null)
					{
						global::Infragistics.Windows.Internal.TileManager.UpdatePreferredSizeOverride(layoutItem2.TargetRect.Size, deltaX, deltaY, layoutItem2, itemInfo);
					}
				}
			}
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00035D2C File Offset: 0x00033F2C
		private void SynchLastScrollPosition()
		{
			this._synchLastScrollPosOperation = null;
			this._lastScrollPosition = this._scrollPosition;
			this._lastScrollLogicalOffset = this._scrollLogicalOffset;
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00035D4D File Offset: 0x00033F4D
		private static void UpdateGenCacheOnItemAdded(global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache, global::Infragistics.Windows.Internal.TileManager.LayoutItem li)
		{
			if (genCache._previousItemsToBeArrangedTempCache.ContainsKey(li.Container))
			{
				genCache._previousItemsToBeArrangedTempCache.Remove(li.Container);
				return;
			}
			genCache._newItemsToBeArrangedTempCache.Add(li);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00035D84 File Offset: 0x00033F84
		private static void UpdatePreferredSizeOverride(global::System.Windows.Size targetSize, double deltaX, double deltaY, global::Infragistics.Windows.Internal.TileManager.LayoutItem li, global::Infragistics.Windows.Tiles.ItemInfoBase liInfo)
		{
			global::System.Windows.Size? preferredSizeOverride = liInfo.PreferredSizeOverride;
			global::System.Windows.Size value = default(global::System.Windows.Size);
			if (deltaX != 0.0)
			{
				value.Width = global::System.Math.Max(targetSize.Width - 0.5, 0.0);
			}
			else if (preferredSizeOverride != null)
			{
				value.Width = preferredSizeOverride.Value.Width;
			}
			if (deltaY != 0.0)
			{
				value.Height = global::System.Math.Max(targetSize.Height - 0.5, 0.0);
			}
			else if (preferredSizeOverride != null)
			{
				value.Height = preferredSizeOverride.Value.Height;
			}
			liInfo.PreferredSizeOverride = new global::System.Windows.Size?(value);
			li.DirtyPreferredSizeCache();
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00035E5C File Offset: 0x0003405C
		private bool UpdateScrollingInfo(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gbl, global::System.Windows.Size preferredSize, bool isScrollingTilesVertically, bool checkIfScrolledTooFar)
		{
			this._scrollTilesVertically = false;
			this._scrollTilesHorizontally = false;
			bool flag;
			bool flag2;
			if (this._isInMaximizedMode)
			{
				flag = true;
				flag2 = this._panel.GetShowAllMinimizedTiles();
			}
			else
			{
				flag = this._panel.GetShowAllTiles();
				flag2 = (flag || this._tileLayoutOrder == global::Infragistics.Windows.Tiles.TileLayoutOrder.UseExplicitRowColumnOnTile);
			}
			if (!flag2)
			{
				this._scrollTilesHorizontally = !isScrollingTilesVertically;
				this._scrollTilesVertically = isScrollingTilesVertically;
			}
			else
			{
				this._scrollPositionOfLastArrangedItem = this._sparseArray.ScrollCount - 1;
			}
			global::System.Windows.Size size;
			if (flag)
			{
				size = gbl.CalculateMinimumSize(this, gbl);
			}
			else
			{
				size = preferredSize;
			}
			global::System.Windows.Size extent = default(global::System.Windows.Size);
			global::System.Windows.Size viewPort = new global::System.Windows.Size(1.0, 1.0);
			global::System.Windows.Size tileAreaSize = this._panel.TileAreaSize;
			bool flag3 = false;
			if (this._scrollTilesHorizontally)
			{
				flag3 = this.CalculateTileScrollExtents(checkIfScrolledTooFar, ref extent, ref viewPort);
			}
			else
			{
				this._scrollSmallChange.X = 10.0;
				this._scrollLargeChange.X = global::System.Math.Max(tileAreaSize.Width - 10.0, 10.0);
				extent.Width = size.Width;
				viewPort.Width = tileAreaSize.Width;
				this._scrollMaxOffset.X = global::System.Math.Max(extent.Width - viewPort.Width, 0.0);
			}
			if (this._scrollTilesVertically)
			{
				flag3 = this.CalculateTileScrollExtents(checkIfScrolledTooFar, ref extent, ref viewPort);
			}
			else
			{
				this._scrollSmallChange.Y = 10.0;
				this._scrollLargeChange.Y = global::System.Math.Max(tileAreaSize.Height - 10.0, 10.0);
				extent.Height = size.Height;
				viewPort.Height = tileAreaSize.Height;
				this._scrollMaxOffset.Y = global::System.Math.Max(extent.Height - viewPort.Height, 0.0);
			}
			if (flag3 || !checkIfScrolledTooFar)
			{
				global::Infragistics.Windows.Tiles.TilesPanelBase.ScrollData scrollDataInfo = this._panel.ScrollDataInfo;
				if (this._scrollMaxOffset.X == 0.0)
				{
					viewPort.Width = 1.0;
					extent.Width = 1.0;
				}
				if (this._scrollMaxOffset.Y == 0.0)
				{
					viewPort.Height = 1.0;
					extent.Height = 1.0;
				}
				if (this._scrollTilesVertically)
				{
					scrollDataInfo._offset.Y = (double)this._scrollLogicalOffset;
				}
				else if (this._scrollTilesHorizontally)
				{
					scrollDataInfo._offset.X = (double)this._scrollLogicalOffset;
				}
				scrollDataInfo.VerifyScrollData(viewPort, extent);
			}
			return flag3;
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0003611C File Offset: 0x0003431C
		private bool VerifyItemSlot(object item, ref int originalItemIndex)
		{
			if (originalItemIndex < 0)
			{
				originalItemIndex = this.Items.IndexOf(item);
				if (originalItemIndex < 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0003613C File Offset: 0x0003433C
		global::System.Windows.Rect global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer.GetBounds(object containerContext)
		{
			if (containerContext == this._gridBagLayoutMaximized)
			{
				return this.MaximizedTileArea.Rect;
			}
			if (containerContext == this._gridBagLayoutMinimized)
			{
				return this.MinimizedTileArea.Rect;
			}
			global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem tileRowColumnLayoutItem = containerContext as global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem;
			if (tileRowColumnLayoutItem != null)
			{
				return tileRowColumnLayoutItem.Rect;
			}
			global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem explicitRowColumnLayoutItem = containerContext as global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem;
			if (explicitRowColumnLayoutItem != null)
			{
				return explicitRowColumnLayoutItem.Rect;
			}
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagLayoutManager = containerContext as global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager;
			global::System.Windows.Size tileAreaSize = this._panel.TileAreaSize;
			if (gridBagLayoutManager != null)
			{
				if (double.IsPositiveInfinity(tileAreaSize.Width) || double.IsPositiveInfinity(tileAreaSize.Height))
				{
					global::System.Windows.Size size = gridBagLayoutManager.CalculatePreferredSize(this, gridBagLayoutManager);
					if (double.IsPositiveInfinity(tileAreaSize.Width))
					{
						tileAreaSize.Width = size.Width;
					}
					if (double.IsPositiveInfinity(tileAreaSize.Height))
					{
						tileAreaSize.Height = size.Height;
					}
				}
				global::System.Windows.Size size2 = gridBagLayoutManager.CalculateMinimumSize(this, gridBagLayoutManager);
				tileAreaSize.Width = global::System.Math.Max(tileAreaSize.Width, size2.Width);
				tileAreaSize.Height = global::System.Math.Max(tileAreaSize.Height, size2.Height);
			}
			return new global::System.Windows.Rect(tileAreaSize);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00036250 File Offset: 0x00034450
		void global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer.PositionItem(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, global::System.Windows.Rect rect, object containerContext)
		{
			if (containerContext == this._gridBagLayoutMaximizedModeOverall)
			{
				global::Infragistics.Windows.Internal.TileManager.TileAreaLayoutItem tileAreaLayoutItem = item as global::Infragistics.Windows.Internal.TileManager.TileAreaLayoutItem;
				if (tileAreaLayoutItem != null)
				{
					tileAreaLayoutItem.Rect = rect;
				}
				return;
			}
			if (containerContext != this._gridBagLayoutNormalModeOverall)
			{
				global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = item as global::Infragistics.Windows.Internal.TileManager.LayoutItem;
				if (layoutItem != null)
				{
					layoutItem.SetTargetRect(rect, true);
				}
				return;
			}
			global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem explicitRowColumnLayoutItem = item as global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem;
			if (explicitRowColumnLayoutItem != null)
			{
				explicitRowColumnLayoutItem.Rect = rect;
				return;
			}
			global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem tileRowColumnLayoutItem = item as global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem;
			if (tileRowColumnLayoutItem != null)
			{
				tileRowColumnLayoutItem.Rect = rect;
			}
		}

		// Token: 0x04000771 RID: 1905
		private const int NON_TILE_SCROLL_SMALL_CHANGE = 10;

		// Token: 0x04000772 RID: 1906
		private global::Infragistics.Windows.Tiles.TilesPanelBase _panel;

		// Token: 0x04000773 RID: 1907
		private global::System.Windows.Controls.ItemsControl _itemsControl;

		// Token: 0x04000774 RID: 1908
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _gridBagLayoutNormal;

		// Token: 0x04000775 RID: 1909
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _gridBagLayoutMaximized;

		// Token: 0x04000776 RID: 1910
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _gridBagLayoutMinimized;

		// Token: 0x04000777 RID: 1911
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _gridBagLayoutMaximizedModeOverall;

		// Token: 0x04000778 RID: 1912
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _gridBagLayoutNormalModeOverall;

		// Token: 0x04000779 RID: 1913
		private global::Infragistics.Windows.Internal.TileManager.TileAreaLayoutItem _maximizedTileArea;

		// Token: 0x0400077A RID: 1914
		private global::Infragistics.Windows.Internal.TileManager.TileAreaLayoutItem _minimizedTileArea;

		// Token: 0x0400077B RID: 1915
		private global::System.Collections.ArrayList _itemsInOriginalOrder;

		// Token: 0x0400077C RID: 1916
		private global::System.Windows.DependencyObject _lastElement;

		// Token: 0x0400077D RID: 1917
		private global::Infragistics.Windows.Tiles.ITileConstraints _lastElementConstraints;

		// Token: 0x0400077E RID: 1918
		private global::Infragistics.Windows.Tiles.ITileConstraints _lastElementDefaultConstraints;

		// Token: 0x0400077F RID: 1919
		private global::Infragistics.Windows.Tiles.TileState? _lastElementState;

		// Token: 0x04000780 RID: 1920
		private global::Infragistics.Windows.Tiles.MaximizedTileLocation _maximizedTileLocation;

		// Token: 0x04000781 RID: 1921
		private global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder _maximizedTileLayoutOrder;

		// Token: 0x04000782 RID: 1922
		private global::Infragistics.Windows.Tiles.TileLayoutOrder _tileLayoutOrder;

		// Token: 0x04000783 RID: 1923
		private global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior _explicitTileSizeBehavior;

		// Token: 0x04000784 RID: 1924
		private global::System.Windows.Size? _synchronizedSize;

		// Token: 0x04000785 RID: 1925
		private global::System.Windows.HorizontalAlignment _lastHorizontalTileAreaAlignment;

		// Token: 0x04000786 RID: 1926
		private global::System.Windows.VerticalAlignment _lastVerticalTileAreaAlignment;

		// Token: 0x04000787 RID: 1927
		private double _explicitMinimizedAreaExtent;

		// Token: 0x04000788 RID: 1928
		private bool _isInMaximizedMode;

		// Token: 0x04000789 RID: 1929
		private bool _lastShowAllTiles;

		// Token: 0x0400078A RID: 1930
		private bool _wasLastScrollableItemGened;

		// Token: 0x0400078B RID: 1931
		private int _scrollPosition;

		// Token: 0x0400078C RID: 1932
		private int _scrollPositionOfLastArrangedItem;

		// Token: 0x0400078D RID: 1933
		private int _scrollLogicalOffset;

		// Token: 0x0400078E RID: 1934
		private int _scrollLogicalOffsetOfLastArrangedItem;

		// Token: 0x0400078F RID: 1935
		private int _lastScrollPosition;

		// Token: 0x04000790 RID: 1936
		private int _lastScrollLogicalOffset;

		// Token: 0x04000791 RID: 1937
		private int _lastNormalModeItemsPerRowColumn;

		// Token: 0x04000792 RID: 1938
		private int _normalModeItemsPerRowColumn;

		// Token: 0x04000793 RID: 1939
		private int _normalModeItemsPerRowColumnActual;

		// Token: 0x04000794 RID: 1940
		private int _normalModeRowColumnsInView;

		// Token: 0x04000795 RID: 1941
		private int _normalModeRowColumnsInViewActual;

		// Token: 0x04000796 RID: 1942
		private int _totalMaximizedColumns;

		// Token: 0x04000797 RID: 1943
		private int _totalMaximizedRows;

		// Token: 0x04000798 RID: 1944
		private int _variableTotalRowColmuns;

		// Token: 0x04000799 RID: 1945
		private double _variableAvgItemsPerRowColumn;

		// Token: 0x0400079A RID: 1946
		private int _totalColumnsDisplayed;

		// Token: 0x0400079B RID: 1947
		private int _totalRowsDisplayed;

		// Token: 0x0400079C RID: 1948
		private bool _scrollTilesVertically;

		// Token: 0x0400079D RID: 1949
		private bool _scrollTilesHorizontally;

		// Token: 0x0400079E RID: 1950
		private global::System.Windows.Vector _scrollSmallChange = default(global::System.Windows.Vector);

		// Token: 0x0400079F RID: 1951
		private global::System.Windows.Vector _scrollLargeChange = default(global::System.Windows.Vector);

		// Token: 0x040007A0 RID: 1952
		private global::System.Windows.Vector _scrollMaxOffset = default(global::System.Windows.Vector);

		// Token: 0x040007A1 RID: 1953
		private global::System.Windows.Vector _arrangeOffset = default(global::System.Windows.Vector);

		// Token: 0x040007A2 RID: 1954
		private global::System.Windows.Vector _arrangeOffsetForMaxmizedTiles = default(global::System.Windows.Vector);

		// Token: 0x040007A3 RID: 1955
		private double _minimizedAreaActualExtent;

		// Token: 0x040007A4 RID: 1956
		private global::System.Windows.Size _defaultMinimunItemSize;

		// Token: 0x040007A5 RID: 1957
		private global::System.Windows.Size _lastMeasureDesiredSize;

		// Token: 0x040007A6 RID: 1958
		private global::System.Windows.Threading.DispatcherOperation _synchLastScrollPosOperation;

		// Token: 0x040007A7 RID: 1959
		private global::Infragistics.Collections.WeakDictionary<global::System.Windows.DependencyObject, object> _containerToItemMap = new global::Infragistics.Collections.WeakDictionary<global::System.Windows.DependencyObject, object>(true, false);

		// Token: 0x040007A8 RID: 1960
		private global::Infragistics.Collections.WeakDictionary<object, global::Infragistics.Windows.Internal.TileManager.LayoutItem> _layoutItemMap = new global::Infragistics.Collections.WeakDictionary<object, global::Infragistics.Windows.Internal.TileManager.LayoutItem>(true, false);

		// Token: 0x040007A9 RID: 1961
		private global::Infragistics.Collections.WeakDictionary<object, global::Infragistics.Windows.Tiles.ItemInfoBase> _itemInfoMap = new global::Infragistics.Collections.WeakDictionary<object, global::Infragistics.Windows.Tiles.ItemInfoBase>(true, false);

		// Token: 0x040007AA RID: 1962
		private global::Infragistics.Windows.Helpers.HashSet _itemsToBeArranged = new global::Infragistics.Windows.Helpers.HashSet();

		// Token: 0x040007AB RID: 1963
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Tiles.ItemInfoBase> _itemsInView = new global::System.Collections.Generic.List<global::Infragistics.Windows.Tiles.ItemInfoBase>();

		// Token: 0x040007AC RID: 1964
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.ItemRowColumnSizeInfo> _lastItemLocations;

		// Token: 0x040007AD RID: 1965
		private global::Infragistics.Windows.Internal.TileManager.ScrollManagerSparseArray _sparseArray = new global::Infragistics.Windows.Internal.TileManager.ScrollManagerSparseArray();

		// Token: 0x040007AE RID: 1966
		private global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache _genCache;

		// Token: 0x020001AC RID: 428
		private class ItemRowColumnSizeInfo
		{
			// Token: 0x06000EED RID: 3821 RVA: 0x0003634F File Offset: 0x0003454F
			internal ItemRowColumnSizeInfo(global::Infragistics.Windows.Tiles.ItemInfoBase info, int row, int column, global::System.Windows.Rect targetRect, global::System.Windows.Size preferredSize)
			{
				this._info = info;
				this._row = row;
				this._column = column;
				this._targetRect = targetRect;
				this._preferredSize = preferredSize;
				this._wasMaximized = info.GetIsMaximized();
			}

			// Token: 0x170002F8 RID: 760
			// (get) Token: 0x06000EEE RID: 3822 RVA: 0x00036388 File Offset: 0x00034588
			internal int Column
			{
				get
				{
					return this._column;
				}
			}

			// Token: 0x170002F9 RID: 761
			// (get) Token: 0x06000EEF RID: 3823 RVA: 0x00036390 File Offset: 0x00034590
			internal global::Infragistics.Windows.Tiles.ItemInfoBase Info
			{
				get
				{
					return this._info;
				}
			}

			// Token: 0x170002FA RID: 762
			// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x00036398 File Offset: 0x00034598
			internal int Row
			{
				get
				{
					return this._row;
				}
			}

			// Token: 0x170002FB RID: 763
			// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x000363A0 File Offset: 0x000345A0
			internal global::System.Windows.Size PreferredSize
			{
				get
				{
					return this._preferredSize;
				}
			}

			// Token: 0x170002FC RID: 764
			// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x000363A8 File Offset: 0x000345A8
			internal global::System.Windows.Rect TargetRect
			{
				get
				{
					return this._targetRect;
				}
			}

			// Token: 0x170002FD RID: 765
			// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x000363B0 File Offset: 0x000345B0
			internal bool WasMaximized
			{
				get
				{
					return this._wasMaximized;
				}
			}

			// Token: 0x06000EF4 RID: 3828 RVA: 0x000363B8 File Offset: 0x000345B8
			internal global::System.Windows.Vector VerifyMaximizeState(global::System.Windows.Vector offset, global::System.Windows.Vector offsetForMaxmizedTiles)
			{
				bool isMaximized = this._info.GetIsMaximized();
				if (this._wasMaximized != isMaximized)
				{
					global::System.Windows.Vector vector;
					if (this._wasMaximized)
					{
						vector = offsetForMaxmizedTiles - offset;
					}
					else
					{
						vector = offset - offsetForMaxmizedTiles;
					}
					this._targetRect.Offset(vector);
					this._wasMaximized = isMaximized;
					return vector;
				}
				return default(global::System.Windows.Vector);
			}

			// Token: 0x040007AF RID: 1967
			private global::Infragistics.Windows.Tiles.ItemInfoBase _info;

			// Token: 0x040007B0 RID: 1968
			private int _row;

			// Token: 0x040007B1 RID: 1969
			private int _column;

			// Token: 0x040007B2 RID: 1970
			private global::System.Windows.Rect _targetRect;

			// Token: 0x040007B3 RID: 1971
			private global::System.Windows.Size _preferredSize;

			// Token: 0x040007B4 RID: 1972
			private bool _wasMaximized;
		}

		// Token: 0x020001AD RID: 429
		private class LayoutItemGeneratorEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06000EF5 RID: 3829 RVA: 0x00036414 File Offset: 0x00034614
			internal LayoutItemGeneratorEnumerator(global::Infragistics.Windows.Internal.TileManager manager, global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache, bool enumerateMaximizedTiles, int startIndex, global::System.Windows.Controls.Orientation orientation, global::Infragistics.Windows.Selection.ScrollDirection direction)
			{
				this._manager = manager;
				this._panel = manager._panel;
				this._genCache = genCache;
				this._enumerateMaximizedTiles = enumerateMaximizedTiles;
				this._items = this._manager.Items;
				this._scrollCount = this._manager.SparseArray.ScrollCount;
				this._maximizedItems = this._panel.GetMaximizedItems();
				this._countMaxmized = this._maximizedItems.Count;
				this._startIndex = startIndex;
				this._orientation = orientation;
				this._direction = direction;
				this.Reset();
			}

			// Token: 0x06000EF6 RID: 3830 RVA: 0x000364B7 File Offset: 0x000346B7
			private void EnsureNotEndReached()
			{
				if (this._isEndReached)
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_1"));
				}
			}

			// Token: 0x06000EF7 RID: 3831 RVA: 0x000364D4 File Offset: 0x000346D4
			private int GetNextIndexToGen()
			{
				global::Infragistics.Windows.Tiles.ItemInfoBase itemInfoBase;
				if (this._enumerateMaximizedTiles)
				{
					if (this._countMaxmized > 0)
					{
						if (this._currentLogicalIndex < -1)
						{
							this._currentLogicalIndex = 0;
						}
						while (this._currentLogicalIndex < this._countMaxmized)
						{
							object item = this._maximizedItems[this._currentLogicalIndex];
							this._currentLogicalIndex++;
							itemInfoBase = this._manager.GetItemInfo(item);
							if (!itemInfoBase.GetIsClosed())
							{
								return itemInfoBase.Index;
							}
						}
					}
					return -1;
				}
				if (this._currentLogicalIndex < -1)
				{
					this._currentLogicalIndex = this._startIndex;
				}
				if (this._currentLogicalIndex < 0 || this._currentLogicalIndex >= this._scrollCount)
				{
					return -1;
				}
				if (this._currentLogicalIndex >= this._scrollCount)
				{
					return -1;
				}
				itemInfoBase = this._manager.GetItemAtScrollIndex(this._currentLogicalIndex);
				if (this._direction == global::Infragistics.Windows.Selection.ScrollDirection.Increment)
				{
					this._currentLogicalIndex++;
				}
				else
				{
					this._currentLogicalIndex--;
				}
				if (itemInfoBase == null)
				{
					return -1;
				}
				return itemInfoBase.Index;
			}

			// Token: 0x170002FE RID: 766
			// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x000365D1 File Offset: 0x000347D1
			public global::Infragistics.Controls.Layouts.Primitives.ILayoutItem Current
			{
				get
				{
					this.EnsureNotEndReached();
					if (this._currentItem == null)
					{
						throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_2"));
					}
					return this._currentItem;
				}
			}

			// Token: 0x06000EF9 RID: 3833 RVA: 0x000365F7 File Offset: 0x000347F7
			public void Dispose()
			{
			}

			// Token: 0x170002FF RID: 767
			// (get) Token: 0x06000EFA RID: 3834 RVA: 0x000365F9 File Offset: 0x000347F9
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06000EFB RID: 3835 RVA: 0x00036604 File Offset: 0x00034804
			public bool MoveNext()
			{
				this.EnsureNotEndReached();
				for (int i = this.GetNextIndexToGen(); i >= 0; i = this.GetNextIndexToGen())
				{
					object item = this._items[i];
					global::System.Windows.DependencyObject dependencyObject = this._genCache.GenerateElement(i);
					global::System.Windows.UIElement uielement = dependencyObject as global::System.Windows.UIElement;
					if (dependencyObject != null && (uielement == null || uielement.Visibility != global::System.Windows.Visibility.Collapsed))
					{
						global::System.Windows.Controls.Dock enterFromSide;
						if (i < this._manager._lastScrollPosition)
						{
							enterFromSide = ((this._orientation == global::System.Windows.Controls.Orientation.Vertical) ? global::System.Windows.Controls.Dock.Left : global::System.Windows.Controls.Dock.Top);
						}
						else
						{
							enterFromSide = ((this._orientation == global::System.Windows.Controls.Orientation.Vertical) ? global::System.Windows.Controls.Dock.Right : global::System.Windows.Controls.Dock.Bottom);
						}
						this._currentItem = this._manager.InitializeLayoutItem(dependencyObject, item, enterFromSide);
						return true;
					}
				}
				this._isEndReached = true;
				this._currentItem = null;
				if (!this._enumerateMaximizedTiles)
				{
					this._manager._wasLastScrollableItemGened = true;
				}
				return false;
			}

			// Token: 0x06000EFC RID: 3836 RVA: 0x000366C8 File Offset: 0x000348C8
			public void Reset()
			{
				this._isEndReached = false;
				this._currentLogicalIndex = -2;
				this._currentItem = null;
			}

			// Token: 0x040007B5 RID: 1973
			private global::Infragistics.Windows.Internal.TileManager _manager;

			// Token: 0x040007B6 RID: 1974
			private global::Infragistics.Windows.Tiles.TilesPanelBase _panel;

			// Token: 0x040007B7 RID: 1975
			private global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache _genCache;

			// Token: 0x040007B8 RID: 1976
			private int _countMaxmized;

			// Token: 0x040007B9 RID: 1977
			private int _scrollCount;

			// Token: 0x040007BA RID: 1978
			private int _currentLogicalIndex = -2;

			// Token: 0x040007BB RID: 1979
			private int _startIndex;

			// Token: 0x040007BC RID: 1980
			private bool _isEndReached;

			// Token: 0x040007BD RID: 1981
			private bool _enumerateMaximizedTiles;

			// Token: 0x040007BE RID: 1982
			private global::System.Collections.IList _items;

			// Token: 0x040007BF RID: 1983
			private global::System.Collections.IList _maximizedItems;

			// Token: 0x040007C0 RID: 1984
			private global::Infragistics.Controls.Layouts.Primitives.ILayoutItem _currentItem;

			// Token: 0x040007C1 RID: 1985
			private global::System.Windows.Controls.Orientation _orientation;

			// Token: 0x040007C2 RID: 1986
			private global::Infragistics.Windows.Selection.ScrollDirection _direction;
		}

		// Token: 0x020001AE RID: 430
		internal enum TileArea
		{
			// Token: 0x040007C4 RID: 1988
			MaximizedTiles,
			// Token: 0x040007C5 RID: 1989
			MinimizedTiles
		}

		// Token: 0x020001AF RID: 431
		internal class LayoutItem : global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint, global::Infragistics.Windows.Tiles.ITileConstraints
		{
			// Token: 0x06000EFD RID: 3837 RVA: 0x000366E0 File Offset: 0x000348E0
			internal LayoutItem(global::System.Windows.DependencyObject container, object item, global::Infragistics.Windows.Internal.TileManager manager)
			{
				this._manager = manager;
				this._item = item;
				this.InitializeContainer(container, true);
			}

			// Token: 0x17000300 RID: 768
			// (get) Token: 0x06000EFE RID: 3838 RVA: 0x000366FE File Offset: 0x000348FE
			internal global::System.Windows.DependencyObject Container
			{
				get
				{
					return this._container;
				}
			}

			// Token: 0x17000301 RID: 769
			// (get) Token: 0x06000EFF RID: 3839 RVA: 0x00036706 File Offset: 0x00034906
			internal global::System.Windows.Rect? CurrentRectInternal
			{
				get
				{
					return this._currentRect;
				}
			}

			// Token: 0x17000302 RID: 770
			// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00036710 File Offset: 0x00034910
			// (set) Token: 0x06000F01 RID: 3841 RVA: 0x000367B0 File Offset: 0x000349B0
			internal global::System.Windows.Rect CurrentRect
			{
				get
				{
					if (this._currentRect != null)
					{
						return this._currentRect.Value;
					}
					global::System.Windows.Rect targetRect = this._targetRect;
					switch (this._enterFromSide)
					{
					case global::System.Windows.Controls.Dock.Left:
						targetRect.X = -targetRect.Width;
						break;
					case global::System.Windows.Controls.Dock.Top:
						targetRect.Y = -targetRect.Height;
						break;
					case global::System.Windows.Controls.Dock.Right:
						targetRect.X = this._manager._panel.ActualWidth;
						break;
					case global::System.Windows.Controls.Dock.Bottom:
						targetRect.Y = this._manager._panel.ActualHeight;
						break;
					}
					return targetRect;
				}
				set
				{
					if (this._currentRect != value)
					{
						this._currentRect = new global::System.Windows.Rect?(value);
						if (this.IsCurrentSameAsTarget)
						{
							this._originalRect = this._targetRect;
							this._lastAtRestTileState = this._manager._panel.GetContainerState(this._element);
						}
					}
				}
			}

			// Token: 0x17000303 RID: 771
			// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0003681D File Offset: 0x00034A1D
			// (set) Token: 0x06000F03 RID: 3843 RVA: 0x00036825 File Offset: 0x00034A25
			internal global::System.Windows.Controls.Dock EnterFromSide
			{
				get
				{
					return this._enterFromSide;
				}
				set
				{
					this._enterFromSide = value;
				}
			}

			// Token: 0x17000304 RID: 772
			// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0003682E File Offset: 0x00034A2E
			internal bool IsCurrentSameAsTarget
			{
				get
				{
					return this._currentRect != null && this._currentRect.Value == this._targetRect;
				}
			}

			// Token: 0x17000305 RID: 773
			// (get) Token: 0x06000F05 RID: 3845 RVA: 0x00036855 File Offset: 0x00034A55
			internal object Item
			{
				get
				{
					return this._item;
				}
			}

			// Token: 0x17000306 RID: 774
			// (get) Token: 0x06000F06 RID: 3846 RVA: 0x0003685D File Offset: 0x00034A5D
			internal global::Infragistics.Windows.Tiles.ItemInfoBase ItemInfo
			{
				get
				{
					return this._manager.GetItemInfo(this._item, false, -1);
				}
			}

			// Token: 0x17000307 RID: 775
			// (get) Token: 0x06000F07 RID: 3847 RVA: 0x00036872 File Offset: 0x00034A72
			internal global::System.Windows.Rect OriginalRect
			{
				get
				{
					return this._originalRect;
				}
			}

			// Token: 0x17000308 RID: 776
			// (get) Token: 0x06000F08 RID: 3848 RVA: 0x0003687A File Offset: 0x00034A7A
			internal global::System.Windows.Size PreferredSizeCache
			{
				get
				{
					return this._preferredSizeCache;
				}
			}

			// Token: 0x17000309 RID: 777
			// (get) Token: 0x06000F09 RID: 3849 RVA: 0x00036884 File Offset: 0x00034A84
			internal bool ShouldAnimateResize
			{
				get
				{
					global::Infragistics.Windows.Tiles.TileState containerState = this._manager._panel.GetContainerState(this._container);
					return this._lastAtRestTileState != containerState;
				}
			}

			// Token: 0x1700030A RID: 778
			// (get) Token: 0x06000F0A RID: 3850 RVA: 0x000368B4 File Offset: 0x00034AB4
			internal global::System.Windows.Rect TargetRect
			{
				get
				{
					return this._targetRect;
				}
			}

			// Token: 0x06000F0B RID: 3851 RVA: 0x000368BC File Offset: 0x00034ABC
			internal void DirtyPreferredSizeCache()
			{
				this._preferredSizeCache = global::System.Windows.Size.Empty;
			}

			// Token: 0x06000F0C RID: 3852 RVA: 0x000368CC File Offset: 0x00034ACC
			private void EnsureMeasure()
			{
				if (this._element != null)
				{
					global::System.Windows.Size preferredSizeHelper = this.GetPreferredSizeHelper(true);
					bool flag = !this._element.IsMeasureValid;
					global::System.Windows.Size size = (this._manager._panel != null) ? this._manager._panel.LastMeasureSize : new global::System.Windows.Size(1000.0, 1000.0);
					if (!flag)
					{
						flag = ((preferredSizeHelper != this._lastMeasureSize && size != this._lastMeasureSize) || this._desiredSizeCache.IsEmpty);
					}
					if (flag)
					{
						if (this._manager._panel != null)
						{
							global::System.Windows.Size availableSize = size;
							if (size == this._lastMeasureSize)
							{
								availableSize.Width += (double)(global::System.DateTime.Now.Millisecond + 1) / 1000.0;
							}
							this._lastMeasureSize = size;
							this._element.Measure(availableSize);
							this._desiredSizeCache = this._element.DesiredSize;
							return;
						}
					}
					else if (size == this._lastMeasureSize)
					{
						this._desiredSizeCache = this._element.DesiredSize;
					}
				}
			}

			// Token: 0x06000F0D RID: 3853 RVA: 0x000369F0 File Offset: 0x00034BF0
			internal global::System.Windows.Size GetPreferredSizeHelper(bool calledFromEnsureMeasure)
			{
				global::System.Windows.Size nonSynchronizedPreferredSize = this.GetNonSynchronizedPreferredSize(calledFromEnsureMeasure);
				if (this._manager._panel != null && !this._manager._isInMaximizedMode)
				{
					global::System.Windows.Size? size = null;
					size = this._manager._synchronizedSize;
					if (size != null)
					{
						bool flag = false;
						bool flag2 = false;
						switch (this._manager._tileLayoutOrder)
						{
						case global::Infragistics.Windows.Tiles.TileLayoutOrder.Vertical:
						case global::Infragistics.Windows.Tiles.TileLayoutOrder.Horizontal:
							flag = true;
							flag2 = true;
							break;
						case global::Infragistics.Windows.Tiles.TileLayoutOrder.VerticalVariable:
							flag = true;
							break;
						case global::Infragistics.Windows.Tiles.TileLayoutOrder.HorizontalVariable:
							flag2 = true;
							break;
						}
						if (flag && size.Value.Width > 0.0)
						{
							nonSynchronizedPreferredSize.Width = size.Value.Width;
						}
						if (flag2 && size.Value.Height > 0.0)
						{
							nonSynchronizedPreferredSize.Height = size.Value.Height;
						}
					}
				}
				return nonSynchronizedPreferredSize;
			}

			// Token: 0x06000F0E RID: 3854 RVA: 0x00036AE8 File Offset: 0x00034CE8
			private global::System.Windows.Size GetNonSynchronizedPreferredSize(bool calledFromEnsureMeasure)
			{
				global::System.Windows.Size? size = null;
				double num = double.NaN;
				double num2 = double.NaN;
				if (this._manager._panel == null || this._manager._panel.GetContainerState(this._container) == global::Infragistics.Windows.Tiles.TileState.Normal)
				{
					global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = this.ItemInfo;
					if (itemInfo != null)
					{
						size = itemInfo.PreferredSizeOverride;
						if (size != null)
						{
							if (size.Value.Width > 0.0 && size.Value.Height > 0.0)
							{
								return size.Value;
							}
							if (size.Value.Width > 0.0)
							{
								num = size.Value.Width;
							}
							if (size.Value.Height > 0.0)
							{
								num2 = size.Value.Height;
							}
						}
					}
				}
				global::Infragistics.Windows.Tiles.ITileConstraints tileConstraints = this._manager.GetItemConstraints(this._container);
				if (tileConstraints != null)
				{
					if (double.IsNaN(num))
					{
						num = tileConstraints.PreferredWidth;
					}
					if (double.IsNaN(num2))
					{
						num2 = tileConstraints.PreferredHeight;
					}
				}
				tileConstraints = this._manager.LastElementDefaultConstraints;
				if (tileConstraints != null)
				{
					if (double.IsNaN(num))
					{
						num = tileConstraints.PreferredWidth;
					}
					if (double.IsNaN(num2))
					{
						num2 = tileConstraints.PreferredHeight;
					}
				}
				if (this._element != null && !calledFromEnsureMeasure)
				{
					if (double.IsNaN(num))
					{
						this.EnsureMeasure();
						num = this._desiredSizeCache.Width;
					}
					if (double.IsNaN(num2))
					{
						this.EnsureMeasure();
						num2 = this._desiredSizeCache.Height;
					}
				}
				return new global::System.Windows.Size(num, num2);
			}

			// Token: 0x06000F0F RID: 3855 RVA: 0x00036CA8 File Offset: 0x00034EA8
			internal void InitializeContainer(global::System.Windows.DependencyObject container, bool clearDimensions)
			{
				if (clearDimensions || container != this._container)
				{
					this._preferredSizeCache = global::System.Windows.Size.Empty;
					this._desiredSizeCache = global::System.Windows.Size.Empty;
					this._dimensions = null;
					this._fillAvailableRows = false;
					this._fillAvailableColumns = false;
				}
				if (container == this._container)
				{
					return;
				}
				this._container = container;
				this._element = (container as global::System.Windows.UIElement);
			}

			// Token: 0x06000F10 RID: 3856 RVA: 0x00036D0C File Offset: 0x00034F0C
			internal void OffsetAllRects(global::System.Windows.Vector offset)
			{
				this._targetRect.Offset(offset);
				this._originalRect.Offset(offset);
				if (this._currentRect != null)
				{
					this._currentRect = new global::System.Windows.Rect?(global::System.Windows.Rect.Offset(this._currentRect.Value, offset));
				}
			}

			// Token: 0x06000F11 RID: 3857 RVA: 0x00036D5A File Offset: 0x00034F5A
			internal void SetDimensions(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions dimensions)
			{
				this._fillAvailableRows = false;
				this._fillAvailableColumns = false;
				this._dimensions = dimensions;
			}

			// Token: 0x06000F12 RID: 3858 RVA: 0x00036D71 File Offset: 0x00034F71
			internal void SetFillAvailableColumns(bool fillAvailableColumns)
			{
				this._fillAvailableColumns = fillAvailableColumns;
			}

			// Token: 0x06000F13 RID: 3859 RVA: 0x00036D7A File Offset: 0x00034F7A
			internal void SetFillAvailableRows(bool fillAvailableRows)
			{
				this._fillAvailableRows = fillAvailableRows;
			}

			// Token: 0x06000F14 RID: 3860 RVA: 0x00036D84 File Offset: 0x00034F84
			internal void SetTargetRect(global::System.Windows.Rect rect, bool measureElement)
			{
				this._targetRect = rect;
				if (this._element != null && measureElement)
				{
					bool flag = false;
					bool flag2 = false;
					global::System.Windows.Size size = rect.Size;
					global::System.Windows.Size desiredSize = this._element.DesiredSize;
					if (global::Infragistics.CoreUtilities.GreaterThan(desiredSize.Height, size.Height) || global::Infragistics.CoreUtilities.GreaterThan(desiredSize.Width, size.Width))
					{
						flag = true;
					}
					else if (global::Infragistics.CoreUtilities.LessThan(this._lastMeasureSize.Width, size.Width) || global::Infragistics.CoreUtilities.LessThan(this._lastMeasureSize.Height, size.Height))
					{
						flag = true;
						flag2 = true;
					}
					if (flag)
					{
						this._lastMeasureSize = size;
						this._element.Measure(size);
						if (flag2)
						{
							this._desiredSizeCache = this._element.DesiredSize;
						}
					}
				}
			}

			// Token: 0x06000F15 RID: 3861 RVA: 0x00036E4F File Offset: 0x0003504F
			internal void SetOriginalRect(global::System.Windows.Rect rect, bool calledFromArrange)
			{
				this._originalRect = rect;
				if (!calledFromArrange)
				{
					this._currentRect = new global::System.Windows.Rect?(rect);
				}
			}

			// Token: 0x06000F16 RID: 3862 RVA: 0x00036E67 File Offset: 0x00035067
			internal void SnapshotCurrentRect()
			{
				if (this._currentRect != null)
				{
					this._originalRect = this._currentRect.Value;
				}
			}

			// Token: 0x1700030B RID: 779
			// (get) Token: 0x06000F17 RID: 3863 RVA: 0x00036E88 File Offset: 0x00035088
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MaximumSize
			{
				get
				{
					double num = double.PositiveInfinity;
					double num2 = double.PositiveInfinity;
					global::Infragistics.Windows.Tiles.ITileConstraints tileConstraints = this._manager.GetItemConstraints(this._container);
					if (tileConstraints != null)
					{
						num = tileConstraints.MaxWidth;
						num2 = tileConstraints.MaxHeight;
					}
					tileConstraints = this._manager.LastElementDefaultConstraints;
					if (tileConstraints != null)
					{
						if (double.IsPositiveInfinity(num))
						{
							num = tileConstraints.MaxWidth;
						}
						if (double.IsPositiveInfinity(num2))
						{
							num2 = tileConstraints.MaxHeight;
						}
					}
					num = global::System.Math.Min(num, (double)this._container.GetValue(global::System.Windows.FrameworkElement.MaxWidthProperty));
					num2 = global::System.Math.Min(num2, (double)this._container.GetValue(global::System.Windows.FrameworkElement.MaxHeightProperty));
					return new global::System.Windows.Size(num, num2);
				}
			}

			// Token: 0x1700030C RID: 780
			// (get) Token: 0x06000F18 RID: 3864 RVA: 0x00036F38 File Offset: 0x00035138
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MinimumSize
			{
				get
				{
					double num = 0.0;
					double num2 = 0.0;
					global::Infragistics.Windows.Tiles.ITileConstraints tileConstraints = this._manager.GetItemConstraints(this._container);
					if (tileConstraints != null)
					{
						num = tileConstraints.MinWidth;
						num2 = tileConstraints.MinHeight;
					}
					tileConstraints = this._manager.LastElementDefaultConstraints;
					if (tileConstraints != null)
					{
						if (num == 0.0)
						{
							num = tileConstraints.MinWidth;
						}
						if (num2 == 0.0)
						{
							num2 = tileConstraints.MinHeight;
						}
					}
					num = global::System.Math.Max(num, (double)this._container.GetValue(global::System.Windows.FrameworkElement.MinWidthProperty));
					num2 = global::System.Math.Max(num2, (double)this._container.GetValue(global::System.Windows.FrameworkElement.MinHeightProperty));
					if (num == 0.0)
					{
						num = this._manager._defaultMinimunItemSize.Width;
					}
					if (num2 == 0.0)
					{
						num2 = this._manager._defaultMinimunItemSize.Height;
					}
					return new global::System.Windows.Size(num, num2);
				}
			}

			// Token: 0x1700030D RID: 781
			// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0003702A File Offset: 0x0003522A
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.PreferredSize
			{
				get
				{
					if (this._preferredSizeCache.IsEmpty)
					{
						this._preferredSizeCache = this.GetPreferredSizeHelper(false);
					}
					return this._preferredSizeCache;
				}
			}

			// Token: 0x1700030E RID: 782
			// (get) Token: 0x06000F1A RID: 3866 RVA: 0x0003704C File Offset: 0x0003524C
			global::System.Windows.Visibility global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.Visibility
			{
				get
				{
					if (this._element == null)
					{
						return global::System.Windows.Visibility.Visible;
					}
					return this._element.Visibility;
				}
			}

			// Token: 0x1700030F RID: 783
			// (get) Token: 0x06000F1B RID: 3867 RVA: 0x00037063 File Offset: 0x00035263
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Column
			{
				get
				{
					if (this._dimensions != null)
					{
						return this._dimensions.Column;
					}
					return (int)this._manager.GetRowColumnProperty(this._container, global::Infragistics.Windows.Tiles.TilesPanelBase.ColumnProperty);
				}
			}

			// Token: 0x17000310 RID: 784
			// (get) Token: 0x06000F1C RID: 3868 RVA: 0x00037094 File Offset: 0x00035294
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
			{
				get
				{
					if (this._dimensions == null)
					{
						return (int)this._manager.GetRowColumnProperty(this._container, global::Infragistics.Windows.Tiles.TilesPanelBase.ColumnSpanProperty);
					}
					if (this._fillAvailableColumns)
					{
						return 0;
					}
					return this._dimensions.ColumnSpan;
				}
			}

			// Token: 0x17000311 RID: 785
			// (get) Token: 0x06000F1D RID: 3869 RVA: 0x000370CF File Offset: 0x000352CF
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
			{
				get
				{
					return (float)this._manager.GetRowColumnProperty(this._container, global::Infragistics.Windows.Tiles.TilesPanelBase.ColumnWeightProperty);
				}
			}

			// Token: 0x17000312 RID: 786
			// (get) Token: 0x06000F1E RID: 3870 RVA: 0x000370EC File Offset: 0x000352EC
			global::System.Windows.HorizontalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.HorizontalAlignment
			{
				get
				{
					global::System.Windows.HorizontalAlignment? horizontalAlignment = null;
					global::Infragistics.Windows.Tiles.ITileConstraints tileConstraints = this._manager.GetItemConstraints(this._container);
					if (tileConstraints != null)
					{
						horizontalAlignment = tileConstraints.HorizontalAlignment;
						if (horizontalAlignment != null)
						{
							return horizontalAlignment.Value;
						}
					}
					tileConstraints = this._manager.LastElementDefaultConstraints;
					if (tileConstraints != null)
					{
						horizontalAlignment = tileConstraints.HorizontalAlignment;
					}
					if (horizontalAlignment != null)
					{
						return horizontalAlignment.Value;
					}
					return (global::System.Windows.HorizontalAlignment)this._container.GetValue(global::System.Windows.FrameworkElement.HorizontalAlignmentProperty);
				}
			}

			// Token: 0x17000313 RID: 787
			// (get) Token: 0x06000F1F RID: 3871 RVA: 0x0003716C File Offset: 0x0003536C
			global::System.Windows.Thickness global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Margin
			{
				get
				{
					global::System.Windows.Thickness? thickness = null;
					global::Infragistics.Windows.Tiles.ITileConstraints tileConstraints = this._manager.GetItemConstraints(this._container);
					if (tileConstraints != null)
					{
						thickness = tileConstraints.Margin;
						if (thickness != null)
						{
							return thickness.Value;
						}
					}
					tileConstraints = this._manager.LastElementDefaultConstraints;
					if (tileConstraints != null)
					{
						thickness = tileConstraints.Margin;
					}
					if (thickness != null)
					{
						return thickness.Value;
					}
					return default(global::System.Windows.Thickness);
				}
			}

			// Token: 0x17000314 RID: 788
			// (get) Token: 0x06000F20 RID: 3872 RVA: 0x000371DE File Offset: 0x000353DE
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Row
			{
				get
				{
					if (this._dimensions != null)
					{
						return this._dimensions.Row;
					}
					return (int)this._manager.GetRowColumnProperty(this._container, global::Infragistics.Windows.Tiles.TilesPanelBase.RowProperty);
				}
			}

			// Token: 0x17000315 RID: 789
			// (get) Token: 0x06000F21 RID: 3873 RVA: 0x0003720F File Offset: 0x0003540F
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
			{
				get
				{
					if (this._dimensions == null)
					{
						return (int)this._manager.GetRowColumnProperty(this._container, global::Infragistics.Windows.Tiles.TilesPanelBase.RowSpanProperty);
					}
					if (this._fillAvailableRows)
					{
						return 0;
					}
					return this._dimensions.RowSpan;
				}
			}

			// Token: 0x17000316 RID: 790
			// (get) Token: 0x06000F22 RID: 3874 RVA: 0x0003724A File Offset: 0x0003544A
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
			{
				get
				{
					return (float)this._manager.GetRowColumnProperty(this._container, global::Infragistics.Windows.Tiles.TilesPanelBase.RowWeightProperty);
				}
			}

			// Token: 0x17000317 RID: 791
			// (get) Token: 0x06000F23 RID: 3875 RVA: 0x00037268 File Offset: 0x00035468
			global::System.Windows.VerticalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.VerticalAlignment
			{
				get
				{
					global::System.Windows.VerticalAlignment? verticalAlignment = null;
					global::Infragistics.Windows.Tiles.ITileConstraints tileConstraints = this._manager.GetItemConstraints(this._container);
					if (tileConstraints != null)
					{
						verticalAlignment = tileConstraints.VerticalAlignment;
						if (verticalAlignment != null)
						{
							return verticalAlignment.Value;
						}
					}
					tileConstraints = this._manager.LastElementDefaultConstraints;
					if (tileConstraints != null)
					{
						verticalAlignment = tileConstraints.VerticalAlignment;
					}
					if (verticalAlignment != null)
					{
						return verticalAlignment.Value;
					}
					return (global::System.Windows.VerticalAlignment)this._container.GetValue(global::System.Windows.FrameworkElement.VerticalAlignmentProperty);
				}
			}

			// Token: 0x17000318 RID: 792
			// (get) Token: 0x06000F24 RID: 3876 RVA: 0x000372E6 File Offset: 0x000354E6
			global::System.Windows.HorizontalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.HorizontalAlignment
			{
				get
				{
					return new global::System.Windows.HorizontalAlignment?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).HorizontalAlignment);
				}
			}

			// Token: 0x17000319 RID: 793
			// (get) Token: 0x06000F25 RID: 3877 RVA: 0x000372F3 File Offset: 0x000354F3
			global::System.Windows.Thickness? global::Infragistics.Windows.Tiles.ITileConstraints.Margin
			{
				get
				{
					return new global::System.Windows.Thickness?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).Margin);
				}
			}

			// Token: 0x1700031A RID: 794
			// (get) Token: 0x06000F26 RID: 3878 RVA: 0x00037300 File Offset: 0x00035500
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MaximumSize.Height;
				}
			}

			// Token: 0x1700031B RID: 795
			// (get) Token: 0x06000F27 RID: 3879 RVA: 0x0003731C File Offset: 0x0003551C
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MaximumSize.Width;
				}
			}

			// Token: 0x1700031C RID: 796
			// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00037338 File Offset: 0x00035538
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MinimumSize.Height;
				}
			}

			// Token: 0x1700031D RID: 797
			// (get) Token: 0x06000F29 RID: 3881 RVA: 0x00037354 File Offset: 0x00035554
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MinimumSize.Width;
				}
			}

			// Token: 0x1700031E RID: 798
			// (get) Token: 0x06000F2A RID: 3882 RVA: 0x00037370 File Offset: 0x00035570
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).PreferredSize.Height;
				}
			}

			// Token: 0x1700031F RID: 799
			// (get) Token: 0x06000F2B RID: 3883 RVA: 0x0003738C File Offset: 0x0003558C
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).PreferredSize.Width;
				}
			}

			// Token: 0x17000320 RID: 800
			// (get) Token: 0x06000F2C RID: 3884 RVA: 0x000373A7 File Offset: 0x000355A7
			global::System.Windows.VerticalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.VerticalAlignment
			{
				get
				{
					return new global::System.Windows.VerticalAlignment?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).VerticalAlignment);
				}
			}

			// Token: 0x040007C6 RID: 1990
			private global::System.Windows.DependencyObject _container;

			// Token: 0x040007C7 RID: 1991
			private global::System.Windows.UIElement _element;

			// Token: 0x040007C8 RID: 1992
			private object _item;

			// Token: 0x040007C9 RID: 1993
			private global::Infragistics.Windows.Internal.TileManager _manager;

			// Token: 0x040007CA RID: 1994
			private global::System.Windows.Rect? _currentRect;

			// Token: 0x040007CB RID: 1995
			private global::System.Windows.Rect _targetRect;

			// Token: 0x040007CC RID: 1996
			private global::System.Windows.Rect _originalRect;

			// Token: 0x040007CD RID: 1997
			private global::System.Windows.Controls.Dock _enterFromSide;

			// Token: 0x040007CE RID: 1998
			private global::Infragistics.Windows.Tiles.TileState _lastAtRestTileState;

			// Token: 0x040007CF RID: 1999
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions _dimensions;

			// Token: 0x040007D0 RID: 2000
			private bool _fillAvailableRows;

			// Token: 0x040007D1 RID: 2001
			private bool _fillAvailableColumns;

			// Token: 0x040007D2 RID: 2002
			private global::System.Windows.Size _preferredSizeCache;

			// Token: 0x040007D3 RID: 2003
			private global::System.Windows.Size _desiredSizeCache;

			// Token: 0x040007D4 RID: 2004
			private global::System.Windows.Size _lastMeasureSize;
		}

		// Token: 0x020001B0 RID: 432
		private class ExplicitItemConstraintWrapper : global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint
		{
			// Token: 0x06000F2D RID: 3885 RVA: 0x000373B4 File Offset: 0x000355B4
			internal ExplicitItemConstraintWrapper(global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem containerItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint sourceConstraint)
			{
				this._containerItem = containerItem;
				this._sourceConstraint = sourceConstraint;
			}

			// Token: 0x17000321 RID: 801
			// (get) Token: 0x06000F2E RID: 3886 RVA: 0x000373CA File Offset: 0x000355CA
			public int Column
			{
				get
				{
					return this._sourceConstraint.Column + this._containerItem.ColumnOffset;
				}
			}

			// Token: 0x17000322 RID: 802
			// (get) Token: 0x06000F2F RID: 3887 RVA: 0x000373E3 File Offset: 0x000355E3
			public int ColumnSpan
			{
				get
				{
					return this._sourceConstraint.ColumnSpan;
				}
			}

			// Token: 0x17000323 RID: 803
			// (get) Token: 0x06000F30 RID: 3888 RVA: 0x000373F0 File Offset: 0x000355F0
			public float ColumnWeight
			{
				get
				{
					return this._sourceConstraint.ColumnWeight;
				}
			}

			// Token: 0x17000324 RID: 804
			// (get) Token: 0x06000F31 RID: 3889 RVA: 0x000373FD File Offset: 0x000355FD
			public global::System.Windows.HorizontalAlignment HorizontalAlignment
			{
				get
				{
					return this._sourceConstraint.HorizontalAlignment;
				}
			}

			// Token: 0x17000325 RID: 805
			// (get) Token: 0x06000F32 RID: 3890 RVA: 0x0003740A File Offset: 0x0003560A
			public global::System.Windows.Thickness Margin
			{
				get
				{
					return this._sourceConstraint.Margin;
				}
			}

			// Token: 0x17000326 RID: 806
			// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00037417 File Offset: 0x00035617
			public int Row
			{
				get
				{
					return this._sourceConstraint.Row + this._containerItem.RowOffset;
				}
			}

			// Token: 0x17000327 RID: 807
			// (get) Token: 0x06000F34 RID: 3892 RVA: 0x00037430 File Offset: 0x00035630
			public int RowSpan
			{
				get
				{
					return this._sourceConstraint.RowSpan;
				}
			}

			// Token: 0x17000328 RID: 808
			// (get) Token: 0x06000F35 RID: 3893 RVA: 0x0003743D File Offset: 0x0003563D
			public float RowWeight
			{
				get
				{
					return this._sourceConstraint.RowWeight;
				}
			}

			// Token: 0x17000329 RID: 809
			// (get) Token: 0x06000F36 RID: 3894 RVA: 0x0003744A File Offset: 0x0003564A
			public global::System.Windows.VerticalAlignment VerticalAlignment
			{
				get
				{
					return this._sourceConstraint.VerticalAlignment;
				}
			}

			// Token: 0x040007D5 RID: 2005
			private global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem _containerItem;

			// Token: 0x040007D6 RID: 2006
			private global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint _sourceConstraint;
		}

		// Token: 0x020001B1 RID: 433
		private class ExplicitLayoutItemComparer : global::System.Collections.Generic.Comparer<global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint>
		{
			// Token: 0x06000F37 RID: 3895 RVA: 0x00037457 File Offset: 0x00035657
			internal ExplicitLayoutItemComparer(global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior behavior)
			{
				this._behavior = behavior;
			}

			// Token: 0x06000F38 RID: 3896 RVA: 0x00037468 File Offset: 0x00035668
			public override int Compare(global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint x, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint y)
			{
				if (x == y)
				{
					return 0;
				}
				if (x == null)
				{
					return -1;
				}
				if (y == null)
				{
					return 1;
				}
				int num;
				int num2;
				if (this._behavior == global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior.SynchronizeTileHeightsAcrossColumns)
				{
					num = x.RowSpan;
					num2 = y.RowSpan;
				}
				else
				{
					num = x.ColumnSpan;
					num2 = y.ColumnSpan;
				}
				if (num != num2)
				{
					if (num >= num2)
					{
						return -1;
					}
					return 1;
				}
				else
				{
					int num3;
					int num4;
					if (this._behavior == global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior.SynchronizeTileHeightsAcrossColumns)
					{
						num3 = x.Row;
						num4 = y.Row;
					}
					else
					{
						num3 = x.Column;
						num4 = y.Column;
					}
					if (num3 < num4)
					{
						return -1;
					}
					if (num3 > num4)
					{
						return 1;
					}
					return 0;
				}
			}

			// Token: 0x040007D7 RID: 2007
			private global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior _behavior;
		}

		// Token: 0x020001B2 RID: 434
		internal class ExplicitRowColumnLayoutItem : global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint, global::Infragistics.Windows.Tiles.ITileConstraints
		{
			// Token: 0x06000F39 RID: 3897 RVA: 0x000374EC File Offset: 0x000356EC
			internal ExplicitRowColumnLayoutItem(global::Infragistics.Windows.Internal.TileManager manager, global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnSection section)
			{
				this._manager = manager;
				if (this._manager._explicitTileSizeBehavior == global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior.SynchronizeTileHeightsAcrossColumns)
				{
					this._column = 0;
					this._columnSpan = 1;
					this._row = section._startRowCol;
					this._rowSpan = section._span;
					this._rowOffset = -this._row;
				}
				else
				{
					this._column = section._startRowCol;
					this._columnSpan = section._span;
					this._columnOffset = -this._column;
					this._row = 0;
					this._rowSpan = 1;
				}
				global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection layoutItems = this._gridBagManager.LayoutItems;
				foreach (global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gridBagConstraint in section._items)
				{
					layoutItems.Add((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)gridBagConstraint, new global::Infragistics.Windows.Internal.TileManager.ExplicitItemConstraintWrapper(this, gridBagConstraint));
				}
			}

			// Token: 0x1700032A RID: 810
			// (get) Token: 0x06000F3A RID: 3898 RVA: 0x00037604 File Offset: 0x00035804
			internal int ColumnOffset
			{
				get
				{
					return this._columnOffset;
				}
			}

			// Token: 0x1700032B RID: 811
			// (get) Token: 0x06000F3B RID: 3899 RVA: 0x0003760C File Offset: 0x0003580C
			internal global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager GridBagManager
			{
				get
				{
					return this._gridBagManager;
				}
			}

			// Token: 0x1700032C RID: 812
			// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00037614 File Offset: 0x00035814
			// (set) Token: 0x06000F3D RID: 3901 RVA: 0x0003761C File Offset: 0x0003581C
			internal global::System.Windows.Rect Rect
			{
				get
				{
					return this._rect;
				}
				set
				{
					this._rect = value;
					this._gridBagManager.LayoutContainer(this._manager, this);
				}
			}

			// Token: 0x1700032D RID: 813
			// (get) Token: 0x06000F3E RID: 3902 RVA: 0x00037637 File Offset: 0x00035837
			internal int RowOffset
			{
				get
				{
					return this._rowOffset;
				}
			}

			// Token: 0x06000F3F RID: 3903 RVA: 0x00037640 File Offset: 0x00035840
			internal void CalculateminMaxPreffered()
			{
				this._minSize = this._gridBagManager.CalculateMinimumSize(this._manager, this._gridBagManager);
				this._maxSize = this._gridBagManager.CalculateMaximumSize(this._manager, this._gridBagManager);
				this._preferredSize = this._gridBagManager.CalculatePreferredSize(this._manager, this._gridBagManager);
				if (this._manager._explicitTileSizeBehavior == global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior.SynchronizeTileHeightsAcrossColumns)
				{
					this._columnWeight = 0f;
					this._rowWeight = global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem.SumWeights(this._gridBagManager.RowWeights, this._row + this._rowOffset, this._rowSpan);
					return;
				}
				this._columnWeight = global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem.SumWeights(this._gridBagManager.ColumnWeights, this._column + this._columnOffset, this._columnSpan);
				this._rowWeight = 0f;
			}

			// Token: 0x06000F40 RID: 3904 RVA: 0x0003771C File Offset: 0x0003591C
			internal bool isEquivalent(global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnSection section)
			{
				if (this._manager._explicitTileSizeBehavior == global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior.SynchronizeTileHeightsAcrossColumns)
				{
					if (this._row != section._startRowCol || this._rowSpan != section._span)
					{
						return false;
					}
				}
				else if (this._column != section._startRowCol || this._columnSpan != section._span)
				{
					return false;
				}
				global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection layoutItems = this._gridBagManager.LayoutItems;
				int count = section._items.Count;
				if (count != layoutItems.Count)
				{
					return false;
				}
				for (int i = 0; i < count; i++)
				{
					if (section._items[i] != layoutItems[i])
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x06000F41 RID: 3905 RVA: 0x000377BC File Offset: 0x000359BC
			private static float SumWeights(float[] weights, int index, int span)
			{
				int num = index + span - 1;
				int num2 = weights.Length;
				if (num >= num2)
				{
					num = num2 - 1;
				}
				float num3 = 0f;
				for (int i = index; i < num; i++)
				{
					num3 += weights[i];
				}
				return num3;
			}

			// Token: 0x1700032E RID: 814
			// (get) Token: 0x06000F42 RID: 3906 RVA: 0x000377FB File Offset: 0x000359FB
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MaximumSize
			{
				get
				{
					return this._maxSize;
				}
			}

			// Token: 0x1700032F RID: 815
			// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00037803 File Offset: 0x00035A03
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MinimumSize
			{
				get
				{
					return this._minSize;
				}
			}

			// Token: 0x17000330 RID: 816
			// (get) Token: 0x06000F44 RID: 3908 RVA: 0x0003780B File Offset: 0x00035A0B
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.PreferredSize
			{
				get
				{
					return this._preferredSize;
				}
			}

			// Token: 0x17000331 RID: 817
			// (get) Token: 0x06000F45 RID: 3909 RVA: 0x00037813 File Offset: 0x00035A13
			global::System.Windows.Visibility global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.Visibility
			{
				get
				{
					return global::System.Windows.Visibility.Visible;
				}
			}

			// Token: 0x17000332 RID: 818
			// (get) Token: 0x06000F46 RID: 3910 RVA: 0x00037816 File Offset: 0x00035A16
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Column
			{
				get
				{
					return this._column;
				}
			}

			// Token: 0x17000333 RID: 819
			// (get) Token: 0x06000F47 RID: 3911 RVA: 0x0003781E File Offset: 0x00035A1E
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
			{
				get
				{
					return this._columnSpan;
				}
			}

			// Token: 0x17000334 RID: 820
			// (get) Token: 0x06000F48 RID: 3912 RVA: 0x00037826 File Offset: 0x00035A26
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
			{
				get
				{
					return this._columnWeight;
				}
			}

			// Token: 0x17000335 RID: 821
			// (get) Token: 0x06000F49 RID: 3913 RVA: 0x0003782E File Offset: 0x00035A2E
			global::System.Windows.HorizontalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.HorizontalAlignment
			{
				get
				{
					return global::System.Windows.HorizontalAlignment.Stretch;
				}
			}

			// Token: 0x17000336 RID: 822
			// (get) Token: 0x06000F4A RID: 3914 RVA: 0x00037834 File Offset: 0x00035A34
			global::System.Windows.Thickness global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Margin
			{
				get
				{
					return default(global::System.Windows.Thickness);
				}
			}

			// Token: 0x17000337 RID: 823
			// (get) Token: 0x06000F4B RID: 3915 RVA: 0x0003784A File Offset: 0x00035A4A
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Row
			{
				get
				{
					return this._row;
				}
			}

			// Token: 0x17000338 RID: 824
			// (get) Token: 0x06000F4C RID: 3916 RVA: 0x00037852 File Offset: 0x00035A52
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
			{
				get
				{
					return this._rowSpan;
				}
			}

			// Token: 0x17000339 RID: 825
			// (get) Token: 0x06000F4D RID: 3917 RVA: 0x0003785A File Offset: 0x00035A5A
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
			{
				get
				{
					return this._rowWeight;
				}
			}

			// Token: 0x1700033A RID: 826
			// (get) Token: 0x06000F4E RID: 3918 RVA: 0x00037862 File Offset: 0x00035A62
			global::System.Windows.VerticalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.VerticalAlignment
			{
				get
				{
					return global::System.Windows.VerticalAlignment.Stretch;
				}
			}

			// Token: 0x1700033B RID: 827
			// (get) Token: 0x06000F4F RID: 3919 RVA: 0x00037865 File Offset: 0x00035A65
			global::System.Windows.HorizontalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.HorizontalAlignment
			{
				get
				{
					return new global::System.Windows.HorizontalAlignment?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).HorizontalAlignment);
				}
			}

			// Token: 0x1700033C RID: 828
			// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00037872 File Offset: 0x00035A72
			global::System.Windows.Thickness? global::Infragistics.Windows.Tiles.ITileConstraints.Margin
			{
				get
				{
					return new global::System.Windows.Thickness?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).Margin);
				}
			}

			// Token: 0x1700033D RID: 829
			// (get) Token: 0x06000F51 RID: 3921 RVA: 0x00037880 File Offset: 0x00035A80
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MaximumSize.Height;
				}
			}

			// Token: 0x1700033E RID: 830
			// (get) Token: 0x06000F52 RID: 3922 RVA: 0x0003789C File Offset: 0x00035A9C
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MaximumSize.Width;
				}
			}

			// Token: 0x1700033F RID: 831
			// (get) Token: 0x06000F53 RID: 3923 RVA: 0x000378B8 File Offset: 0x00035AB8
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MinimumSize.Height;
				}
			}

			// Token: 0x17000340 RID: 832
			// (get) Token: 0x06000F54 RID: 3924 RVA: 0x000378D4 File Offset: 0x00035AD4
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MinimumSize.Width;
				}
			}

			// Token: 0x17000341 RID: 833
			// (get) Token: 0x06000F55 RID: 3925 RVA: 0x000378F0 File Offset: 0x00035AF0
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).PreferredSize.Height;
				}
			}

			// Token: 0x17000342 RID: 834
			// (get) Token: 0x06000F56 RID: 3926 RVA: 0x0003790C File Offset: 0x00035B0C
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).PreferredSize.Width;
				}
			}

			// Token: 0x17000343 RID: 835
			// (get) Token: 0x06000F57 RID: 3927 RVA: 0x00037927 File Offset: 0x00035B27
			global::System.Windows.VerticalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.VerticalAlignment
			{
				get
				{
					return new global::System.Windows.VerticalAlignment?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).VerticalAlignment);
				}
			}

			// Token: 0x040007D8 RID: 2008
			private global::Infragistics.Windows.Internal.TileManager _manager;

			// Token: 0x040007D9 RID: 2009
			private int _column;

			// Token: 0x040007DA RID: 2010
			private int _columnOffset;

			// Token: 0x040007DB RID: 2011
			private int _columnSpan;

			// Token: 0x040007DC RID: 2012
			private float _columnWeight;

			// Token: 0x040007DD RID: 2013
			private int _row;

			// Token: 0x040007DE RID: 2014
			private int _rowOffset;

			// Token: 0x040007DF RID: 2015
			private int _rowSpan;

			// Token: 0x040007E0 RID: 2016
			private float _rowWeight;

			// Token: 0x040007E1 RID: 2017
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _gridBagManager = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager();

			// Token: 0x040007E2 RID: 2018
			private global::System.Windows.Rect _rect;

			// Token: 0x040007E3 RID: 2019
			private global::System.Windows.Size _preferredSize;

			// Token: 0x040007E4 RID: 2020
			private global::System.Windows.Size _minSize;

			// Token: 0x040007E5 RID: 2021
			private global::System.Windows.Size _maxSize = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);
		}

		// Token: 0x020001B3 RID: 435
		internal class ExplicitRowColumnSection
		{
			// Token: 0x06000F58 RID: 3928 RVA: 0x00037934 File Offset: 0x00035B34
			internal bool Intersects(int start, int end)
			{
				return end >= this._startRowCol && start <= this._endRowCol;
			}

			// Token: 0x06000F59 RID: 3929 RVA: 0x00037950 File Offset: 0x00035B50
			internal void Add(global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint item, int start, int end)
			{
				this._startRowCol = global::System.Math.Min(start, this._startRowCol);
				this._endRowCol = global::System.Math.Max(end, this._endRowCol);
				this._span = this._endRowCol + 1 - this._startRowCol;
				this._items.Add(item);
			}

			// Token: 0x040007E6 RID: 2022
			internal int _endRowCol;

			// Token: 0x040007E7 RID: 2023
			internal int _startRowCol;

			// Token: 0x040007E8 RID: 2024
			internal int _span = 1;

			// Token: 0x040007E9 RID: 2025
			internal global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint> _items = new global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint>();
		}

		// Token: 0x020001B4 RID: 436
		internal class TileAreaLayoutItem : global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint, global::Infragistics.Windows.Tiles.ITileConstraints
		{
			// Token: 0x06000F5B RID: 3931 RVA: 0x000379BC File Offset: 0x00035BBC
			internal TileAreaLayoutItem(global::Infragistics.Windows.Internal.TileManager manager, global::Infragistics.Windows.Internal.TileManager.TileArea area)
			{
				this._manager = manager;
				this._area = area;
			}

			// Token: 0x17000344 RID: 836
			// (get) Token: 0x06000F5C RID: 3932 RVA: 0x000379D2 File Offset: 0x00035BD2
			internal global::Infragistics.Windows.Internal.TileManager.TileArea Area
			{
				get
				{
					return this._area;
				}
			}

			// Token: 0x17000345 RID: 837
			// (get) Token: 0x06000F5D RID: 3933 RVA: 0x000379DA File Offset: 0x00035BDA
			internal global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager GridBagManager
			{
				get
				{
					if (this._area == global::Infragistics.Windows.Internal.TileManager.TileArea.MaximizedTiles)
					{
						return this._manager.GridBagLayoutMaximized;
					}
					return this._manager.GridBagLayoutMinimized;
				}
			}

			// Token: 0x17000346 RID: 838
			// (get) Token: 0x06000F5E RID: 3934 RVA: 0x000379FB File Offset: 0x00035BFB
			// (set) Token: 0x06000F5F RID: 3935 RVA: 0x00037A04 File Offset: 0x00035C04
			internal global::System.Windows.Rect Rect
			{
				get
				{
					return this._rect;
				}
				set
				{
					this._rect = value;
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagManager = this.GridBagManager;
					gridBagManager.LayoutContainer(this._manager, gridBagManager);
					bool isMaximizedAreaLeftOrRight = this._manager.IsMaximizedAreaLeftOrRight;
					global::System.Windows.Size tileAreaSize = this._manager._panel.TileAreaSize;
					double value2;
					double value3;
					if (isMaximizedAreaLeftOrRight)
					{
						value2 = this._rect.Height;
						this._rect.Height = global::System.Math.Max(global::System.Math.Min(tileAreaSize.Height, this._rect.Height), this._minSizeContents.Height);
						if (this._area == global::Infragistics.Windows.Internal.TileManager.TileArea.MaximizedTiles)
						{
							if (double.IsPositiveInfinity(tileAreaSize.Height))
							{
								this._rect.Height = this._rect.Height + global::System.Math.Max(this._rect.Y, 0.0);
								this._rect.Y = 0.0;
							}
							else
							{
								this._rect.Y = 0.0;
								this._rect.Height = tileAreaSize.Height;
							}
						}
						value3 = this._rect.Height;
						if (this._area == global::Infragistics.Windows.Internal.TileManager.TileArea.MinimizedTiles)
						{
							this._manager._minimizedAreaActualExtent = this._rect.Width;
						}
					}
					else
					{
						value2 = this._rect.Width;
						this._rect.Width = global::System.Math.Max(global::System.Math.Min(tileAreaSize.Width, this._rect.Width), this._minSizeContents.Width);
						if (this._area == global::Infragistics.Windows.Internal.TileManager.TileArea.MaximizedTiles)
						{
							if (double.IsPositiveInfinity(tileAreaSize.Width))
							{
								this._rect.Width = this._rect.Width + global::System.Math.Max(this._rect.X, 0.0);
								this._rect.X = 0.0;
							}
							else
							{
								this._rect.X = 0.0;
								this._rect.Width = tileAreaSize.Width;
							}
						}
						value3 = this._rect.Width;
						if (this._area == global::Infragistics.Windows.Internal.TileManager.TileArea.MinimizedTiles)
						{
							this._manager._minimizedAreaActualExtent = this._rect.Height;
						}
					}
					if (!global::Infragistics.CoreUtilities.AreClose(value2, value3))
					{
						gridBagManager.LayoutContainer(this._manager, gridBagManager);
					}
				}
			}

			// Token: 0x06000F60 RID: 3936 RVA: 0x00037C3C File Offset: 0x00035E3C
			internal void InitializeCachedSizes(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection dims)
			{
				this._minSizeContents = dims.MinimumSize;
				this._maxSizeContents = dims.MaximumSize;
				this._minSizeArea = this._minSizeContents;
				if (this._area == global::Infragistics.Windows.Internal.TileManager.TileArea.MaximizedTiles)
				{
					this._maxSizeArea = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);
				}
				else
				{
					this._maxSizeArea = this._maxSizeContents;
				}
				this._preferredSize = dims.PreferredSize;
				bool isMaximizedAreaLeftOrRight = this._manager.IsMaximizedAreaLeftOrRight;
				if (this._area == global::Infragistics.Windows.Internal.TileManager.TileArea.MinimizedTiles && this._manager._explicitMinimizedAreaExtent > 0.0 && !double.IsPositiveInfinity(this._manager._explicitMinimizedAreaExtent))
				{
					if (isMaximizedAreaLeftOrRight)
					{
						this._minSizeArea.Width = global::System.Math.Max(this._minSizeArea.Width, this._manager._explicitMinimizedAreaExtent);
						this._maxSizeArea.Width = this._minSizeArea.Width;
					}
					else
					{
						this._minSizeArea.Height = global::System.Math.Max(this._minSizeArea.Height, this._manager._explicitMinimizedAreaExtent);
						this._maxSizeArea.Height = this._minSizeArea.Height;
					}
				}
				global::System.Windows.Size tileAreaSize = this._manager._panel.TileAreaSize;
				if (isMaximizedAreaLeftOrRight)
				{
					if (!double.IsPositiveInfinity(tileAreaSize.Height))
					{
						this._preferredSize.Height = tileAreaSize.Height;
						return;
					}
				}
				else if (!double.IsPositiveInfinity(tileAreaSize.Width))
				{
					this._preferredSize.Width = tileAreaSize.Width;
				}
			}

			// Token: 0x17000347 RID: 839
			// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00037DC1 File Offset: 0x00035FC1
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MaximumSize
			{
				get
				{
					return this._maxSizeArea;
				}
			}

			// Token: 0x17000348 RID: 840
			// (get) Token: 0x06000F62 RID: 3938 RVA: 0x00037DC9 File Offset: 0x00035FC9
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MinimumSize
			{
				get
				{
					return this._minSizeArea;
				}
			}

			// Token: 0x17000349 RID: 841
			// (get) Token: 0x06000F63 RID: 3939 RVA: 0x00037DD1 File Offset: 0x00035FD1
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.PreferredSize
			{
				get
				{
					return this._preferredSize;
				}
			}

			// Token: 0x1700034A RID: 842
			// (get) Token: 0x06000F64 RID: 3940 RVA: 0x00037DD9 File Offset: 0x00035FD9
			global::System.Windows.Visibility global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.Visibility
			{
				get
				{
					return global::System.Windows.Visibility.Visible;
				}
			}

			// Token: 0x1700034B RID: 843
			// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00037DDC File Offset: 0x00035FDC
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Column
			{
				get
				{
					if (this._area == global::Infragistics.Windows.Internal.TileManager.TileArea.MaximizedTiles)
					{
						if (this._manager._maximizedTileLocation == global::Infragistics.Windows.Tiles.MaximizedTileLocation.Right)
						{
							return 1;
						}
						return 0;
					}
					else
					{
						if (this._manager._maximizedTileLocation == global::Infragistics.Windows.Tiles.MaximizedTileLocation.Left)
						{
							return 1;
						}
						return 0;
					}
				}
			}

			// Token: 0x1700034C RID: 844
			// (get) Token: 0x06000F66 RID: 3942 RVA: 0x00037E09 File Offset: 0x00036009
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x1700034D RID: 845
			// (get) Token: 0x06000F67 RID: 3943 RVA: 0x00037E0C File Offset: 0x0003600C
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
			{
				get
				{
					if (this._area == global::Infragistics.Windows.Internal.TileManager.TileArea.MaximizedTiles)
					{
						return 1f;
					}
					return 0f;
				}
			}

			// Token: 0x1700034E RID: 846
			// (get) Token: 0x06000F68 RID: 3944 RVA: 0x00037E21 File Offset: 0x00036021
			global::System.Windows.HorizontalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.HorizontalAlignment
			{
				get
				{
					if (this._area == global::Infragistics.Windows.Internal.TileManager.TileArea.MinimizedTiles && this._manager._panel != null && !this._manager.IsMaximizedAreaLeftOrRight)
					{
						return this._manager._panel.GetHorizontalTileAreaAlignment();
					}
					return global::System.Windows.HorizontalAlignment.Stretch;
				}
			}

			// Token: 0x1700034F RID: 847
			// (get) Token: 0x06000F69 RID: 3945 RVA: 0x00037E58 File Offset: 0x00036058
			global::System.Windows.Thickness global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Margin
			{
				get
				{
					return default(global::System.Windows.Thickness);
				}
			}

			// Token: 0x17000350 RID: 848
			// (get) Token: 0x06000F6A RID: 3946 RVA: 0x00037E6E File Offset: 0x0003606E
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Row
			{
				get
				{
					if (this._area == global::Infragistics.Windows.Internal.TileManager.TileArea.MaximizedTiles)
					{
						if (this._manager._maximizedTileLocation == global::Infragistics.Windows.Tiles.MaximizedTileLocation.Bottom)
						{
							return 1;
						}
						return 0;
					}
					else
					{
						if (this._manager._maximizedTileLocation == global::Infragistics.Windows.Tiles.MaximizedTileLocation.Top)
						{
							return 1;
						}
						return 0;
					}
				}
			}

			// Token: 0x17000351 RID: 849
			// (get) Token: 0x06000F6B RID: 3947 RVA: 0x00037E9B File Offset: 0x0003609B
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x17000352 RID: 850
			// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00037E9E File Offset: 0x0003609E
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
			{
				get
				{
					if (this._area == global::Infragistics.Windows.Internal.TileManager.TileArea.MaximizedTiles)
					{
						return 1f;
					}
					return 0f;
				}
			}

			// Token: 0x17000353 RID: 851
			// (get) Token: 0x06000F6D RID: 3949 RVA: 0x00037EB3 File Offset: 0x000360B3
			global::System.Windows.VerticalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.VerticalAlignment
			{
				get
				{
					if (this._area == global::Infragistics.Windows.Internal.TileManager.TileArea.MinimizedTiles && this._manager._panel != null && this._manager.IsMaximizedAreaLeftOrRight)
					{
						return this._manager._panel.GetVerticalTileAreaAlignment();
					}
					return global::System.Windows.VerticalAlignment.Stretch;
				}
			}

			// Token: 0x17000354 RID: 852
			// (get) Token: 0x06000F6E RID: 3950 RVA: 0x00037EEA File Offset: 0x000360EA
			global::System.Windows.HorizontalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.HorizontalAlignment
			{
				get
				{
					return new global::System.Windows.HorizontalAlignment?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).HorizontalAlignment);
				}
			}

			// Token: 0x17000355 RID: 853
			// (get) Token: 0x06000F6F RID: 3951 RVA: 0x00037EF7 File Offset: 0x000360F7
			global::System.Windows.Thickness? global::Infragistics.Windows.Tiles.ITileConstraints.Margin
			{
				get
				{
					return new global::System.Windows.Thickness?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).Margin);
				}
			}

			// Token: 0x17000356 RID: 854
			// (get) Token: 0x06000F70 RID: 3952 RVA: 0x00037F04 File Offset: 0x00036104
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxHeight
			{
				get
				{
					return this._maxSizeContents.Height;
				}
			}

			// Token: 0x17000357 RID: 855
			// (get) Token: 0x06000F71 RID: 3953 RVA: 0x00037F11 File Offset: 0x00036111
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxWidth
			{
				get
				{
					return this._maxSizeContents.Width;
				}
			}

			// Token: 0x17000358 RID: 856
			// (get) Token: 0x06000F72 RID: 3954 RVA: 0x00037F1E File Offset: 0x0003611E
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinHeight
			{
				get
				{
					return this._minSizeContents.Height;
				}
			}

			// Token: 0x17000359 RID: 857
			// (get) Token: 0x06000F73 RID: 3955 RVA: 0x00037F2B File Offset: 0x0003612B
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinWidth
			{
				get
				{
					return this._minSizeContents.Width;
				}
			}

			// Token: 0x1700035A RID: 858
			// (get) Token: 0x06000F74 RID: 3956 RVA: 0x00037F38 File Offset: 0x00036138
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredHeight
			{
				get
				{
					return this._preferredSize.Height;
				}
			}

			// Token: 0x1700035B RID: 859
			// (get) Token: 0x06000F75 RID: 3957 RVA: 0x00037F45 File Offset: 0x00036145
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredWidth
			{
				get
				{
					return this._preferredSize.Width;
				}
			}

			// Token: 0x1700035C RID: 860
			// (get) Token: 0x06000F76 RID: 3958 RVA: 0x00037F52 File Offset: 0x00036152
			global::System.Windows.VerticalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.VerticalAlignment
			{
				get
				{
					return new global::System.Windows.VerticalAlignment?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).VerticalAlignment);
				}
			}

			// Token: 0x040007EA RID: 2026
			private global::Infragistics.Windows.Internal.TileManager _manager;

			// Token: 0x040007EB RID: 2027
			private global::Infragistics.Windows.Internal.TileManager.TileArea _area;

			// Token: 0x040007EC RID: 2028
			private global::System.Windows.Rect _rect;

			// Token: 0x040007ED RID: 2029
			private global::System.Windows.Size _minSizeContents;

			// Token: 0x040007EE RID: 2030
			private global::System.Windows.Size _maxSizeContents;

			// Token: 0x040007EF RID: 2031
			private global::System.Windows.Size _minSizeArea;

			// Token: 0x040007F0 RID: 2032
			private global::System.Windows.Size _maxSizeArea;

			// Token: 0x040007F1 RID: 2033
			private global::System.Windows.Size _preferredSize;
		}

		// Token: 0x020001B5 RID: 437
		internal class TileRowColumnLayoutItem : global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint, global::Infragistics.Windows.Tiles.ITileConstraints
		{
			// Token: 0x06000F77 RID: 3959 RVA: 0x00037F60 File Offset: 0x00036160
			internal TileRowColumnLayoutItem(global::Infragistics.Windows.Internal.TileManager manager, bool isTileRow, int rowColumnIndex, int scrollOffset)
			{
				this._manager = manager;
				this._isTileRow = isTileRow;
				this._rowColumnIndex = rowColumnIndex;
				this._scrollOffset = scrollOffset;
			}

			// Token: 0x1700035D RID: 861
			// (get) Token: 0x06000F78 RID: 3960 RVA: 0x00037FB8 File Offset: 0x000361B8
			internal global::Infragistics.Windows.Internal.TileManager.LayoutItem FirstChildLayoutItem
			{
				get
				{
					if (this._gridBagManager.LayoutItems.Count < 1)
					{
						return null;
					}
					return (global::Infragistics.Windows.Internal.TileManager.LayoutItem)this._gridBagManager.LayoutItems[0];
				}
			}

			// Token: 0x1700035E RID: 862
			// (get) Token: 0x06000F79 RID: 3961 RVA: 0x00037FE5 File Offset: 0x000361E5
			internal global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager GridBagManager
			{
				get
				{
					return this._gridBagManager;
				}
			}

			// Token: 0x1700035F RID: 863
			// (get) Token: 0x06000F7A RID: 3962 RVA: 0x00037FED File Offset: 0x000361ED
			internal global::Infragistics.Windows.Internal.TileManager.LayoutItem LastChildLayoutItem
			{
				get
				{
					if (this._gridBagManager.LayoutItems.Count < 1)
					{
						return null;
					}
					return (global::Infragistics.Windows.Internal.TileManager.LayoutItem)this._gridBagManager.LayoutItems[this._gridBagManager.LayoutItems.Count - 1];
				}
			}

			// Token: 0x17000360 RID: 864
			// (get) Token: 0x06000F7B RID: 3963 RVA: 0x0003802B File Offset: 0x0003622B
			internal int LastScrollPositionGenerated
			{
				get
				{
					return this._lastScrollPositionGenerated;
				}
			}

			// Token: 0x17000361 RID: 865
			// (get) Token: 0x06000F7C RID: 3964 RVA: 0x00038033 File Offset: 0x00036233
			// (set) Token: 0x06000F7D RID: 3965 RVA: 0x0003803C File Offset: 0x0003623C
			internal global::System.Windows.Rect Rect
			{
				get
				{
					return this._rect;
				}
				set
				{
					this._rect = value;
					global::System.Windows.Size tileAreaSize = this._manager._panel.TileAreaSize;
					if (this._isTileRow)
					{
						if (this._manager._panel.GetHorizontalTileAreaAlignment() == global::System.Windows.HorizontalAlignment.Stretch)
						{
							this._rect.Width = global::System.Math.Max(tileAreaSize.Width, this._rect.Width);
						}
					}
					else if (this._manager._panel.GetVerticalTileAreaAlignment() == global::System.Windows.VerticalAlignment.Stretch)
					{
						this._rect.Height = global::System.Math.Max(tileAreaSize.Height, this._rect.Height);
					}
					this._gridBagManager.LayoutContainer(this._manager, this);
				}
			}

			// Token: 0x17000362 RID: 866
			// (get) Token: 0x06000F7E RID: 3966 RVA: 0x000380E7 File Offset: 0x000362E7
			internal int ScrollOffset
			{
				get
				{
					return this._scrollOffset;
				}
			}

			// Token: 0x06000F7F RID: 3967 RVA: 0x000380F0 File Offset: 0x000362F0
			internal int CalculateAutoLayoutHelper(global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache, global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> enumerator, bool autoFitAllItems, global::System.Windows.Size constraint, int minRows, int minCols, int maxRows, int maxCols, global::System.Windows.Controls.Orientation orientation, global::Infragistics.Windows.Selection.ScrollDirection direction, out global::System.Windows.Size preferredSize)
			{
				this._childDimensionsCollection = this.GridBagManager.CalculateAutoLayout(enumerator, orientation, false, constraint, minRows, minCols, maxRows, maxCols, null);
				if (orientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					this._manager._totalRowsDisplayed = global::System.Math.Max(this._childDimensionsCollection.RowDims.Length - 1, this._manager._totalRowsDisplayed);
				}
				else
				{
					this._manager._totalColumnsDisplayed = global::System.Math.Max(this._childDimensionsCollection.ColumnDims.Length - 1, this._manager._totalColumnsDisplayed);
				}
				global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = null;
				foreach (object obj in ((global::System.Collections.IEnumerable)this._childDimensionsCollection))
				{
					global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem2 = (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)obj;
					layoutItem = (layoutItem2 as global::Infragistics.Windows.Internal.TileManager.LayoutItem);
				}
				if (layoutItem != null)
				{
					global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = this._manager.GetItemInfo(layoutItem.Item);
					if (itemInfo != null)
					{
						this._lastScrollPositionGenerated = itemInfo.ScrollPosition;
					}
				}
				preferredSize = this._childDimensionsCollection.PreferredSize;
				this._preferredSize = preferredSize;
				return this._lastScrollPositionGenerated;
			}

			// Token: 0x06000F80 RID: 3968 RVA: 0x00038220 File Offset: 0x00036420
			internal int GetFirstScrollPosition()
			{
				for (int i = 0; i < this._gridBagManager.LayoutItems.Count; i++)
				{
					global::Infragistics.Windows.Tiles.ItemInfoBase itemInfo = ((global::Infragistics.Windows.Internal.TileManager.LayoutItem)this._gridBagManager.LayoutItems[i]).ItemInfo;
					if (itemInfo != null)
					{
						int scrollPosition = itemInfo.ScrollPosition;
						if (scrollPosition >= 0)
						{
							return scrollPosition;
						}
					}
				}
				return -1;
			}

			// Token: 0x06000F81 RID: 3969 RVA: 0x00038278 File Offset: 0x00036478
			internal int GetLastScrollPosition()
			{
				for (int i = this._gridBagManager.LayoutItems.Count - 1; i >= 0; i--)
				{
					int scrollPosition = ((global::Infragistics.Windows.Internal.TileManager.LayoutItem)this._gridBagManager.LayoutItems[i]).ItemInfo.ScrollPosition;
					if (scrollPosition >= 0)
					{
						return scrollPosition;
					}
				}
				return -1;
			}

			// Token: 0x06000F82 RID: 3970 RVA: 0x000382CC File Offset: 0x000364CC
			internal void ProcessGeneratedElements(global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache)
			{
				if (this._childDimensionsCollection != null)
				{
					this._manager.ProcessDimensionsCollection(this._gridBagManager, genCache, this._childDimensionsCollection);
					this._preferredSize = this._childDimensionsCollection.PreferredSize;
					this._minSize = this._childDimensionsCollection.MinimumSize;
					this._maxSize = this._childDimensionsCollection.MaximumSize;
					this._childDimensionsCollection = null;
				}
			}

			// Token: 0x17000363 RID: 867
			// (get) Token: 0x06000F83 RID: 3971 RVA: 0x00038333 File Offset: 0x00036533
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MaximumSize
			{
				get
				{
					return this._maxSize;
				}
			}

			// Token: 0x17000364 RID: 868
			// (get) Token: 0x06000F84 RID: 3972 RVA: 0x0003833B File Offset: 0x0003653B
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MinimumSize
			{
				get
				{
					return this._minSize;
				}
			}

			// Token: 0x17000365 RID: 869
			// (get) Token: 0x06000F85 RID: 3973 RVA: 0x00038343 File Offset: 0x00036543
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.PreferredSize
			{
				get
				{
					return this._preferredSize;
				}
			}

			// Token: 0x17000366 RID: 870
			// (get) Token: 0x06000F86 RID: 3974 RVA: 0x0003834B File Offset: 0x0003654B
			global::System.Windows.Visibility global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.Visibility
			{
				get
				{
					return global::System.Windows.Visibility.Visible;
				}
			}

			// Token: 0x17000367 RID: 871
			// (get) Token: 0x06000F87 RID: 3975 RVA: 0x0003834E File Offset: 0x0003654E
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Column
			{
				get
				{
					if (!this._isTileRow)
					{
						return this._rowColumnIndex;
					}
					return 0;
				}
			}

			// Token: 0x17000368 RID: 872
			// (get) Token: 0x06000F88 RID: 3976 RVA: 0x00038360 File Offset: 0x00036560
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x17000369 RID: 873
			// (get) Token: 0x06000F89 RID: 3977 RVA: 0x00038363 File Offset: 0x00036563
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
			{
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700036A RID: 874
			// (get) Token: 0x06000F8A RID: 3978 RVA: 0x0003836A File Offset: 0x0003656A
			global::System.Windows.HorizontalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.HorizontalAlignment
			{
				get
				{
					return global::System.Windows.HorizontalAlignment.Stretch;
				}
			}

			// Token: 0x1700036B RID: 875
			// (get) Token: 0x06000F8B RID: 3979 RVA: 0x00038370 File Offset: 0x00036570
			global::System.Windows.Thickness global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Margin
			{
				get
				{
					return default(global::System.Windows.Thickness);
				}
			}

			// Token: 0x1700036C RID: 876
			// (get) Token: 0x06000F8C RID: 3980 RVA: 0x00038386 File Offset: 0x00036586
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Row
			{
				get
				{
					if (!this._isTileRow)
					{
						return 0;
					}
					return this._rowColumnIndex;
				}
			}

			// Token: 0x1700036D RID: 877
			// (get) Token: 0x06000F8D RID: 3981 RVA: 0x00038398 File Offset: 0x00036598
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x1700036E RID: 878
			// (get) Token: 0x06000F8E RID: 3982 RVA: 0x0003839B File Offset: 0x0003659B
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
			{
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700036F RID: 879
			// (get) Token: 0x06000F8F RID: 3983 RVA: 0x000383A2 File Offset: 0x000365A2
			global::System.Windows.VerticalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.VerticalAlignment
			{
				get
				{
					return global::System.Windows.VerticalAlignment.Stretch;
				}
			}

			// Token: 0x17000370 RID: 880
			// (get) Token: 0x06000F90 RID: 3984 RVA: 0x000383A5 File Offset: 0x000365A5
			global::System.Windows.HorizontalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.HorizontalAlignment
			{
				get
				{
					return new global::System.Windows.HorizontalAlignment?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).HorizontalAlignment);
				}
			}

			// Token: 0x17000371 RID: 881
			// (get) Token: 0x06000F91 RID: 3985 RVA: 0x000383B2 File Offset: 0x000365B2
			global::System.Windows.Thickness? global::Infragistics.Windows.Tiles.ITileConstraints.Margin
			{
				get
				{
					return new global::System.Windows.Thickness?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).Margin);
				}
			}

			// Token: 0x17000372 RID: 882
			// (get) Token: 0x06000F92 RID: 3986 RVA: 0x000383C0 File Offset: 0x000365C0
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MaximumSize.Height;
				}
			}

			// Token: 0x17000373 RID: 883
			// (get) Token: 0x06000F93 RID: 3987 RVA: 0x000383DC File Offset: 0x000365DC
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MaximumSize.Width;
				}
			}

			// Token: 0x17000374 RID: 884
			// (get) Token: 0x06000F94 RID: 3988 RVA: 0x000383F8 File Offset: 0x000365F8
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MinimumSize.Height;
				}
			}

			// Token: 0x17000375 RID: 885
			// (get) Token: 0x06000F95 RID: 3989 RVA: 0x00038414 File Offset: 0x00036614
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MinimumSize.Width;
				}
			}

			// Token: 0x17000376 RID: 886
			// (get) Token: 0x06000F96 RID: 3990 RVA: 0x00038430 File Offset: 0x00036630
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).PreferredSize.Height;
				}
			}

			// Token: 0x17000377 RID: 887
			// (get) Token: 0x06000F97 RID: 3991 RVA: 0x0003844C File Offset: 0x0003664C
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).PreferredSize.Width;
				}
			}

			// Token: 0x17000378 RID: 888
			// (get) Token: 0x06000F98 RID: 3992 RVA: 0x00038467 File Offset: 0x00036667
			global::System.Windows.VerticalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.VerticalAlignment
			{
				get
				{
					return new global::System.Windows.VerticalAlignment?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).VerticalAlignment);
				}
			}

			// Token: 0x040007F2 RID: 2034
			private global::Infragistics.Windows.Internal.TileManager _manager;

			// Token: 0x040007F3 RID: 2035
			private int _rowColumnIndex;

			// Token: 0x040007F4 RID: 2036
			private int _scrollOffset;

			// Token: 0x040007F5 RID: 2037
			private int _lastScrollPositionGenerated;

			// Token: 0x040007F6 RID: 2038
			private bool _isTileRow;

			// Token: 0x040007F7 RID: 2039
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _gridBagManager = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager();

			// Token: 0x040007F8 RID: 2040
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection _childDimensionsCollection;

			// Token: 0x040007F9 RID: 2041
			private global::System.Windows.Rect _rect;

			// Token: 0x040007FA RID: 2042
			private global::System.Windows.Size _preferredSize;

			// Token: 0x040007FB RID: 2043
			private global::System.Windows.Size _minSize;

			// Token: 0x040007FC RID: 2044
			private global::System.Windows.Size _maxSize = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);
		}

		// Token: 0x020001B6 RID: 438
		private class TileRowColumnGeneratorEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06000F99 RID: 3993 RVA: 0x00038474 File Offset: 0x00036674
			internal TileRowColumnGeneratorEnumerator(global::Infragistics.Windows.Internal.TileManager manager, global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache, bool enumerateRows, int startIndex, int scrollOffset, global::Infragistics.Windows.Selection.ScrollDirection direction)
			{
				this._manager = manager;
				this._panel = manager._panel;
				this._genCache = genCache;
				this._enumerateRows = enumerateRows;
				this._scrollCount = this._manager.SparseArray.ScrollCount;
				this._startIndex = startIndex;
				this._currentScrollOffset = scrollOffset;
				this._direction = direction;
				if (enumerateRows)
				{
					this._maxElementsToGenerate = this._panel.GetMaxColumns();
				}
				else
				{
					this._maxElementsToGenerate = this._panel.GetMaxRows();
				}
				this.Reset();
			}

			// Token: 0x06000F9A RID: 3994 RVA: 0x0003851D File Offset: 0x0003671D
			private void EnsureNotEndReached()
			{
				if (this._isEndReached)
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_1"));
				}
			}

			// Token: 0x06000F9B RID: 3995 RVA: 0x00038538 File Offset: 0x00036738
			private int GetNextIndexToGen()
			{
				if (this._extentRemaining <= 0.0)
				{
					return -1;
				}
				if (this._currentScrollPosition < -1)
				{
					this._currentScrollPosition = this._startIndex;
				}
				if (this._currentScrollPosition < 0 || this._currentScrollPosition >= this._scrollCount)
				{
					return -1;
				}
				global::Infragistics.Windows.Tiles.ItemInfoBase itemAtScrollIndex = this._manager.GetItemAtScrollIndex(this._currentScrollPosition);
				if (itemAtScrollIndex != null)
				{
					return itemAtScrollIndex.Index;
				}
				return -1;
			}

			// Token: 0x17000379 RID: 889
			// (get) Token: 0x06000F9C RID: 3996 RVA: 0x000385A3 File Offset: 0x000367A3
			public global::Infragistics.Controls.Layouts.Primitives.ILayoutItem Current
			{
				get
				{
					this.EnsureNotEndReached();
					if (this._currentTileRowColumn == null)
					{
						throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_2"));
					}
					return this._currentTileRowColumn;
				}
			}

			// Token: 0x06000F9D RID: 3997 RVA: 0x000385C9 File Offset: 0x000367C9
			public void Dispose()
			{
			}

			// Token: 0x1700037A RID: 890
			// (get) Token: 0x06000F9E RID: 3998 RVA: 0x000385CB File Offset: 0x000367CB
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06000F9F RID: 3999 RVA: 0x000385D4 File Offset: 0x000367D4
			public bool MoveNext()
			{
				this.EnsureNotEndReached();
				int nextIndexToGen = this.GetNextIndexToGen();
				if (nextIndexToGen >= 0)
				{
					this._currentRowColumnIndex++;
					if (this._currentRowColumnIndex >= this._tileRowColumns.Count)
					{
						this._currentTileRowColumn = new global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem(this._manager, this._enumerateRows, this._currentRowColumnIndex, this._currentScrollOffset);
						if (this._direction == global::Infragistics.Windows.Selection.ScrollDirection.Increment)
						{
							this._currentScrollOffset++;
						}
						else
						{
							this._currentScrollOffset = global::System.Math.Max(this._currentScrollOffset - 1, 0);
						}
						global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager gridBagManager = this._currentTileRowColumn.GridBagManager;
						gridBagManager.InterItemSpacingHorizontal = this._panel.GetInterTileSpacing(false, global::Infragistics.Windows.Tiles.TileState.Normal);
						gridBagManager.InterItemSpacingVertical = this._panel.GetInterTileSpacing(true, global::Infragistics.Windows.Tiles.TileState.Normal);
						gridBagManager.HorizontalContentAlignment = this._panel.GetHorizontalTileAreaAlignment();
						gridBagManager.VerticalContentAlignment = this._panel.GetVerticalTileAreaAlignment();
						gridBagManager.ExpandToFitHeight = (gridBagManager.VerticalContentAlignment == global::System.Windows.VerticalAlignment.Stretch);
						gridBagManager.ExpandToFitWidth = (gridBagManager.HorizontalContentAlignment == global::System.Windows.HorizontalAlignment.Stretch);
						gridBagManager.ShrinkToFitHeight = new bool?(true);
						gridBagManager.ShrinkToFitWidth = new bool?(true);
						global::System.Windows.Controls.Orientation orientation = this._enumerateRows ? global::System.Windows.Controls.Orientation.Horizontal : global::System.Windows.Controls.Orientation.Vertical;
						global::System.Windows.Size size;
						this._currentScrollPosition = this._currentTileRowColumn.CalculateAutoLayoutHelper(this._genCache, new global::Infragistics.Windows.Internal.TileManager.LayoutItemGeneratorEnumerator(this._manager, this._genCache, false, this._currentScrollPosition, orientation, this._direction), false, this._panel.TileAreaSize, 0, 0, this._enumerateRows ? 1 : this._maxElementsToGenerate, this._enumerateRows ? this._maxElementsToGenerate : 1, orientation, this._direction, out size);
						if (this._enumerateRows)
						{
							this._extentRemaining -= size.Height;
						}
						else
						{
							this._extentRemaining -= size.Width;
						}
						if (this._currentScrollPosition >= 0)
						{
							this._tileRowColumns.Add(this._currentTileRowColumn);
						}
						else
						{
							this._currentTileRowColumn = null;
						}
						if (this._direction == global::Infragistics.Windows.Selection.ScrollDirection.Increment)
						{
							this._currentScrollPosition++;
						}
						else
						{
							this._currentScrollPosition--;
						}
					}
					else
					{
						this._currentTileRowColumn = this._tileRowColumns[this._currentRowColumnIndex];
					}
					if (this._currentTileRowColumn != null)
					{
						return true;
					}
				}
				this._isEndReached = true;
				this._currentTileRowColumn = null;
				return false;
			}

			// Token: 0x06000FA0 RID: 4000 RVA: 0x0003881C File Offset: 0x00036A1C
			public void Reset()
			{
				this._isEndReached = false;
				this._currentScrollPosition = -2;
				this._currentRowColumnIndex = -1;
				this._currentTileRowColumn = null;
				if (this._enumerateRows)
				{
					this._extentRemaining = this._panel.TileAreaSize.Height;
					return;
				}
				this._extentRemaining = this._panel.TileAreaSize.Width;
			}

			// Token: 0x040007FD RID: 2045
			private global::Infragistics.Windows.Internal.TileManager _manager;

			// Token: 0x040007FE RID: 2046
			private global::Infragistics.Windows.Tiles.TilesPanelBase _panel;

			// Token: 0x040007FF RID: 2047
			private global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache _genCache;

			// Token: 0x04000800 RID: 2048
			private int _scrollCount;

			// Token: 0x04000801 RID: 2049
			private int _currentScrollPosition = -2;

			// Token: 0x04000802 RID: 2050
			private int _currentScrollOffset;

			// Token: 0x04000803 RID: 2051
			private int _currentRowColumnIndex = -1;

			// Token: 0x04000804 RID: 2052
			private int _startIndex;

			// Token: 0x04000805 RID: 2053
			private double _extentRemaining;

			// Token: 0x04000806 RID: 2054
			private bool _isEndReached;

			// Token: 0x04000807 RID: 2055
			private bool _enumerateRows;

			// Token: 0x04000808 RID: 2056
			private global::Infragistics.Windows.Selection.ScrollDirection _direction;

			// Token: 0x04000809 RID: 2057
			private global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem _currentTileRowColumn;

			// Token: 0x0400080A RID: 2058
			private global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem> _tileRowColumns = new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem>();

			// Token: 0x0400080B RID: 2059
			private int _maxElementsToGenerate;
		}

		// Token: 0x020001B7 RID: 439
		internal class ScrollManagerSparseArray : global::Infragistics.Collections.SparseArray
		{
			// Token: 0x06000FA1 RID: 4001 RVA: 0x00038881 File Offset: 0x00036A81
			internal ScrollManagerSparseArray() : base(20, 1f, true, true)
			{
			}

			// Token: 0x1700037B RID: 891
			// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00038892 File Offset: 0x00036A92
			internal int ScrollCount
			{
				get
				{
					return base.GetScrollCount();
				}
			}

			// Token: 0x06000FA3 RID: 4003 RVA: 0x0003889A File Offset: 0x00036A9A
			internal global::Infragistics.Windows.Tiles.ItemInfoBase GetItemAtScrollIndex(int index)
			{
				return (global::Infragistics.Windows.Tiles.ItemInfoBase)base.GetItemAtScrollIndex(index, null);
			}

			// Token: 0x06000FA4 RID: 4004 RVA: 0x000388A9 File Offset: 0x00036AA9
			internal int GetScrollIndexOfItem(global::Infragistics.Windows.Tiles.ItemInfoBase item)
			{
				return base.GetScrollIndexOf(item);
			}

			// Token: 0x06000FA5 RID: 4005 RVA: 0x000388B2 File Offset: 0x00036AB2
			internal void InvalidateScrollCounts()
			{
				base.DirtyScrollCountInfo();
			}

			// Token: 0x06000FA6 RID: 4006 RVA: 0x000388BA File Offset: 0x00036ABA
			internal void InvalidateItem(global::Infragistics.Windows.Tiles.ItemInfoBase arrayItem)
			{
				base.NotifyItemScrollCountChanged(arrayItem);
			}
		}
	}
}
