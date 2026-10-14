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
	// Token: 0x020001D8 RID: 472
	public class TileManager : global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer
	{
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x0003583F File Offset: 0x00033A3F
		public global::Infragistics.Windows.Tiles.TilesPanelBase Panel
		{
			get
			{
				return this._panel;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x00035847 File Offset: 0x00033A47
		internal global::System.Windows.Vector ArrangeOffset
		{
			get
			{
				return this._arrangeOffset;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x0003584F File Offset: 0x00033A4F
		internal global::System.Windows.Vector ArrangeOffsetForMaxmizedTiles
		{
			get
			{
				return this._arrangeOffsetForMaxmizedTiles;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x00035857 File Offset: 0x00033A57
		internal int CountOfItemsToBeArranged
		{
			get
			{
				return this._itemsToBeArranged.Count;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x00035864 File Offset: 0x00033A64
		internal int ScrollIndexOfFirstArrangedItem
		{
			get
			{
				return this._scrollPosition;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x0003586C File Offset: 0x00033A6C
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

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x0003588D File Offset: 0x00033A8D
		internal double MinimizedAreaActualExtent
		{
			get
			{
				return this._minimizedAreaActualExtent;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x00035895 File Offset: 0x00033A95
		internal int ScrollIndexOfLastArrangedItem
		{
			get
			{
				return this._scrollPositionOfLastArrangedItem;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x0003589D File Offset: 0x00033A9D
		internal global::System.Windows.Vector ScrollLargeChange
		{
			get
			{
				return this._scrollLargeChange;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x000358A5 File Offset: 0x00033AA5
		internal global::System.Windows.Vector ScrollMaxOffset
		{
			get
			{
				return this._scrollMaxOffset;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x000358AD File Offset: 0x00033AAD
		// (set) Token: 0x0600104E RID: 4174 RVA: 0x000358B8 File Offset: 0x00033AB8
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

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x00035937 File Offset: 0x00033B37
		internal global::System.Windows.Vector ScrollSmallChange
		{
			get
			{
				return this._scrollSmallChange;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x0003593F File Offset: 0x00033B3F
		internal bool ScrollTilesHorizontally
		{
			get
			{
				return this._scrollTilesHorizontally;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x00035947 File Offset: 0x00033B47
		internal bool ScrollTilesVertically
		{
			get
			{
				return this._scrollTilesVertically;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x0003594F File Offset: 0x00033B4F
		internal global::Infragistics.Windows.Internal.TileManager.ScrollManagerSparseArray SparseArray
		{
			get
			{
				return this._sparseArray;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001053 RID: 4179 RVA: 0x00035957 File Offset: 0x00033B57
		internal int TotalColumnsDisplayed
		{
			get
			{
				return this._totalColumnsDisplayed;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x0003595F File Offset: 0x00033B5F
		internal int TotalRowsDisplayed
		{
			get
			{
				return this._totalRowsDisplayed;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x00035967 File Offset: 0x00033B67
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

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x00035982 File Offset: 0x00033B82
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

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x0003599D File Offset: 0x00033B9D
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

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x000359D0 File Offset: 0x00033BD0
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

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x000359EC File Offset: 0x00033BEC
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

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x00035A64 File Offset: 0x00033C64
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

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x00035A8D File Offset: 0x00033C8D
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

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x00035AAA File Offset: 0x00033CAA
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

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x00035AC7 File Offset: 0x00033CC7
		private int NormalModeItemsPerRowColumn
		{
			get
			{
				return this._normalModeItemsPerRowColumn;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x00035ACF File Offset: 0x00033CCF
		private global::Infragistics.Windows.Tiles.ITileConstraints LastElementDefaultConstraints
		{
			get
			{
				return this._lastElementDefaultConstraints;
			}
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00035AD7 File Offset: 0x00033CD7
		public global::Infragistics.Windows.Tiles.ItemInfoBase GetItemInfo(object item)
		{
			return this.GetItemInfo(item, true, -1);
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00035AE4 File Offset: 0x00033CE4
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

		// Token: 0x06001061 RID: 4193 RVA: 0x00035B28 File Offset: 0x00033D28
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

		// Token: 0x06001062 RID: 4194 RVA: 0x00035B78 File Offset: 0x00033D78
		protected virtual global::Infragistics.Windows.Tiles.ItemInfoBase CreateItemInfo(object item, int index)
		{
			return new global::Infragistics.Windows.Tiles.ItemInfoBase(this, item, index);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00035B82 File Offset: 0x00033D82
		internal static bool AreClose(double value1, double value2)
		{
			return value1 == value2 || global::System.Math.Abs(value1 - value2) < 1E-10;
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00035BA0 File Offset: 0x00033DA0
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

		// Token: 0x06001065 RID: 4197 RVA: 0x00035ED8 File Offset: 0x000340D8
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

		// Token: 0x06001066 RID: 4198 RVA: 0x00035FDC File Offset: 0x000341DC
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

		// Token: 0x06001067 RID: 4199 RVA: 0x00036984 File Offset: 0x00034B84
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

		// Token: 0x06001068 RID: 4200 RVA: 0x00036A20 File Offset: 0x00034C20
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

		// Token: 0x06001069 RID: 4201 RVA: 0x00036BC0 File Offset: 0x00034DC0
		internal int GetCurrentColumn(global::Infragistics.Windows.Tiles.ItemInfoBase info)
		{
			return this.GetCurrenRowColumnHelper(info, true);
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00036BCA File Offset: 0x00034DCA
		internal int GetCurrentRow(global::Infragistics.Windows.Tiles.ItemInfoBase info)
		{
			return this.GetCurrenRowColumnHelper(info, false);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00036BD4 File Offset: 0x00034DD4
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

		// Token: 0x0600106C RID: 4204 RVA: 0x00036CA4 File Offset: 0x00034EA4
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

		// Token: 0x0600106D RID: 4205 RVA: 0x00036D48 File Offset: 0x00034F48
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

		// Token: 0x0600106E RID: 4206 RVA: 0x00036DB6 File Offset: 0x00034FB6
		internal global::Infragistics.Windows.Tiles.ItemInfoBase[] GetItemsInView()
		{
			return this._itemsInView.ToArray();
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x00036DC3 File Offset: 0x00034FC3
		internal global::System.Collections.IEnumerator GetItemsToBeArranged()
		{
			return this._itemsToBeArranged.GetEnumerator();
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00036DD0 File Offset: 0x00034FD0
		internal global::Infragistics.Windows.Internal.TileManager.LayoutItem GetLayoutItem(object item)
		{
			return this.GetLayoutItem(item, null, false, false);
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00036DDC File Offset: 0x00034FDC
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

		// Token: 0x06001072 RID: 4210 RVA: 0x00036EE4 File Offset: 0x000350E4
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

		// Token: 0x06001073 RID: 4211 RVA: 0x00036F7C File Offset: 0x0003517C
		internal global::System.Collections.IEnumerator GetLayoutItemsToBeAnimated()
		{
			if (this._itemsToBeArranged == null || this._itemsToBeArranged.Count == 0)
			{
				return null;
			}
			return this._itemsToBeArranged.GetEnumerator();
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00036FA0 File Offset: 0x000351A0
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

		// Token: 0x06001075 RID: 4213 RVA: 0x00037028 File Offset: 0x00035228
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

		// Token: 0x06001076 RID: 4214 RVA: 0x000370AB File Offset: 0x000352AB
		internal global::Infragistics.Windows.Tiles.ITileConstraints GetMaximizedModeTileAreaConstraints(global::Infragistics.Windows.Internal.TileManager.TileArea area)
		{
			if (this._isInMaximizedMode)
			{
				return this.GetTileAreaLayoutItem(area);
			}
			return null;
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x000370C0 File Offset: 0x000352C0
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

		// Token: 0x06001078 RID: 4216 RVA: 0x00037268 File Offset: 0x00035468
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

		// Token: 0x06001079 RID: 4217 RVA: 0x000372D8 File Offset: 0x000354D8
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

		// Token: 0x0600107A RID: 4218 RVA: 0x00037448 File Offset: 0x00035648
		internal global::Infragistics.Windows.Internal.TileManager.LayoutItem InitializeLayoutItem(global::System.Windows.DependencyObject container, object item, global::System.Windows.Controls.Dock enterFromSide)
		{
			global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = this.GetLayoutItem(item, container, true, true);
			layoutItem.EnterFromSide = enterFromSide;
			layoutItem.SetDimensions(null);
			return layoutItem;
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00037470 File Offset: 0x00035670
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

		// Token: 0x0600107C RID: 4220 RVA: 0x00037528 File Offset: 0x00035728
		internal bool IsContainerInArrangeCache(global::System.Windows.DependencyObject container)
		{
			object key;
			global::Infragistics.Windows.Internal.TileManager.LayoutItem item;
			return this._containerToItemMap.TryGetValue(container, out key) && this._layoutItemMap.TryGetValue(key, out item) && this._itemsToBeArranged.Exists(item);
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00037565 File Offset: 0x00035765
		internal bool IsItemInView(global::Infragistics.Windows.Tiles.ItemInfoBase item)
		{
			return this._itemsInView.Contains(item);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00037574 File Offset: 0x00035774
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

		// Token: 0x0600107F RID: 4223 RVA: 0x00037958 File Offset: 0x00035B58
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

		// Token: 0x06001080 RID: 4224 RVA: 0x00037ACC File Offset: 0x00035CCC
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

		// Token: 0x06001081 RID: 4225 RVA: 0x00037E90 File Offset: 0x00036090
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

		// Token: 0x06001082 RID: 4226 RVA: 0x00037FA8 File Offset: 0x000361A8
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

		// Token: 0x06001083 RID: 4227 RVA: 0x00038250 File Offset: 0x00036450
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

		// Token: 0x06001084 RID: 4228 RVA: 0x000383BC File Offset: 0x000365BC
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

		// Token: 0x06001085 RID: 4229 RVA: 0x00038504 File Offset: 0x00036704
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

		// Token: 0x06001086 RID: 4230 RVA: 0x00038560 File Offset: 0x00036760
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

		// Token: 0x06001087 RID: 4231 RVA: 0x00038638 File Offset: 0x00036838
		internal void SnapshotItemRects()
		{
			foreach (object obj in this._itemsToBeArranged)
			{
				global::Infragistics.Windows.Internal.TileManager.LayoutItem layoutItem = (global::Infragistics.Windows.Internal.TileManager.LayoutItem)obj;
				layoutItem.SnapshotCurrentRect();
			}
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00038690 File Offset: 0x00036890
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

		// Token: 0x06001089 RID: 4233 RVA: 0x000386CF File Offset: 0x000368CF
		private void AddItemToBeArranged(global::Infragistics.Windows.Internal.TileManager.LayoutItem li)
		{
			this.RemoveDuplicateContainerRefs(li);
			this._itemsToBeArranged.Add(li);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x000386E4 File Offset: 0x000368E4
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

		// Token: 0x0600108B RID: 4235 RVA: 0x00038D1C File Offset: 0x00036F1C
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

		// Token: 0x0600108C RID: 4236 RVA: 0x00038E64 File Offset: 0x00037064
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

		// Token: 0x0600108D RID: 4237 RVA: 0x00038ED8 File Offset: 0x000370D8
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

		// Token: 0x0600108E RID: 4238 RVA: 0x00039108 File Offset: 0x00037308
		private void EnsureItemArrayIsAllocated()
		{
			if (this._itemsInOriginalOrder == null)
			{
				int count = this.Items.Count;
				this._itemsInOriginalOrder = new global::System.Collections.ArrayList(count + 10);
				this.ExpandCachedItemArrays(count);
			}
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x00039140 File Offset: 0x00037340
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

		// Token: 0x06001090 RID: 4240 RVA: 0x00039188 File Offset: 0x00037388
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

		// Token: 0x06001091 RID: 4241 RVA: 0x000392D0 File Offset: 0x000374D0
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

		// Token: 0x06001092 RID: 4242 RVA: 0x000394B8 File Offset: 0x000376B8
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

		// Token: 0x06001093 RID: 4243 RVA: 0x000397AC File Offset: 0x000379AC
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

		// Token: 0x06001094 RID: 4244 RVA: 0x00039C18 File Offset: 0x00037E18
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

		// Token: 0x06001095 RID: 4245 RVA: 0x0003A0A0 File Offset: 0x000382A0
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

		// Token: 0x06001096 RID: 4246 RVA: 0x0003A288 File Offset: 0x00038488
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

		// Token: 0x06001097 RID: 4247 RVA: 0x0003A400 File Offset: 0x00038600
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

		// Token: 0x06001098 RID: 4248 RVA: 0x0003A47C File Offset: 0x0003867C
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

		// Token: 0x06001099 RID: 4249 RVA: 0x0003A5B0 File Offset: 0x000387B0
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

		// Token: 0x0600109A RID: 4250 RVA: 0x0003A630 File Offset: 0x00038830
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

		// Token: 0x0600109B RID: 4251 RVA: 0x0003A7AC File Offset: 0x000389AC
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

		// Token: 0x0600109C RID: 4252 RVA: 0x0003A7E0 File Offset: 0x000389E0
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

		// Token: 0x0600109D RID: 4253 RVA: 0x0003A844 File Offset: 0x00038A44
		private void InvalidatePanelMeasure()
		{
			if (this._panel != null)
			{
				if (this._panel._isInMeasure)
				{
					this._panel.Dispatcher.BeginInvoke(new global::System.Action(delegate()
					{
						if (this._panel != null)
						{
							this._panel.InvalidateMeasure();
						}
					}), global::System.Windows.Threading.DispatcherPriority.Send, new object[0]);
					return;
				}
				this._panel.InvalidateMeasure();
			}
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0003A8A0 File Offset: 0x00038AA0
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

		// Token: 0x0600109F RID: 4255 RVA: 0x0003ACA0 File Offset: 0x00038EA0
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

		// Token: 0x060010A0 RID: 4256 RVA: 0x0003ACF0 File Offset: 0x00038EF0
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

		// Token: 0x060010A1 RID: 4257 RVA: 0x0003ADCC File Offset: 0x00038FCC
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
						this.InvalidatePanelMeasure();
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
							this.InvalidatePanelMeasure();
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

		// Token: 0x060010A2 RID: 4258 RVA: 0x0003AFF8 File Offset: 0x000391F8
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

		// Token: 0x060010A3 RID: 4259 RVA: 0x0003B0C4 File Offset: 0x000392C4
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

		// Token: 0x060010A4 RID: 4260 RVA: 0x0003B144 File Offset: 0x00039344
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

		// Token: 0x060010A5 RID: 4261 RVA: 0x0003B180 File Offset: 0x00039380
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

		// Token: 0x060010A6 RID: 4262 RVA: 0x0003B210 File Offset: 0x00039410
		private void SynchLastScrollPosition()
		{
			this._synchLastScrollPosOperation = null;
			this._lastScrollPosition = this._scrollPosition;
			this._lastScrollLogicalOffset = this._scrollLogicalOffset;
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0003B231 File Offset: 0x00039431
		private static void UpdateGenCacheOnItemAdded(global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache genCache, global::Infragistics.Windows.Internal.TileManager.LayoutItem li)
		{
			if (genCache._previousItemsToBeArrangedTempCache.ContainsKey(li.Container))
			{
				genCache._previousItemsToBeArrangedTempCache.Remove(li.Container);
				return;
			}
			genCache._newItemsToBeArrangedTempCache.Add(li);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0003B268 File Offset: 0x00039468
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

		// Token: 0x060010A9 RID: 4265 RVA: 0x0003B340 File Offset: 0x00039540
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

		// Token: 0x060010AA RID: 4266 RVA: 0x0003B600 File Offset: 0x00039800
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

		// Token: 0x060010AB RID: 4267 RVA: 0x0003B620 File Offset: 0x00039820
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

		// Token: 0x060010AC RID: 4268 RVA: 0x0003B734 File Offset: 0x00039934
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

		// Token: 0x040008AD RID: 2221
		private const int NON_TILE_SCROLL_SMALL_CHANGE = 10;

		// Token: 0x040008AE RID: 2222
		private global::Infragistics.Windows.Tiles.TilesPanelBase _panel;

		// Token: 0x040008AF RID: 2223
		private global::System.Windows.Controls.ItemsControl _itemsControl;

		// Token: 0x040008B0 RID: 2224
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _gridBagLayoutNormal;

		// Token: 0x040008B1 RID: 2225
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _gridBagLayoutMaximized;

		// Token: 0x040008B2 RID: 2226
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _gridBagLayoutMinimized;

		// Token: 0x040008B3 RID: 2227
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _gridBagLayoutMaximizedModeOverall;

		// Token: 0x040008B4 RID: 2228
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _gridBagLayoutNormalModeOverall;

		// Token: 0x040008B5 RID: 2229
		private global::Infragistics.Windows.Internal.TileManager.TileAreaLayoutItem _maximizedTileArea;

		// Token: 0x040008B6 RID: 2230
		private global::Infragistics.Windows.Internal.TileManager.TileAreaLayoutItem _minimizedTileArea;

		// Token: 0x040008B7 RID: 2231
		private global::System.Collections.ArrayList _itemsInOriginalOrder;

		// Token: 0x040008B8 RID: 2232
		private global::System.Windows.DependencyObject _lastElement;

		// Token: 0x040008B9 RID: 2233
		private global::Infragistics.Windows.Tiles.ITileConstraints _lastElementConstraints;

		// Token: 0x040008BA RID: 2234
		private global::Infragistics.Windows.Tiles.ITileConstraints _lastElementDefaultConstraints;

		// Token: 0x040008BB RID: 2235
		private global::Infragistics.Windows.Tiles.TileState? _lastElementState;

		// Token: 0x040008BC RID: 2236
		private global::Infragistics.Windows.Tiles.MaximizedTileLocation _maximizedTileLocation;

		// Token: 0x040008BD RID: 2237
		private global::Infragistics.Windows.Tiles.MaximizedTileLayoutOrder _maximizedTileLayoutOrder;

		// Token: 0x040008BE RID: 2238
		private global::Infragistics.Windows.Tiles.TileLayoutOrder _tileLayoutOrder;

		// Token: 0x040008BF RID: 2239
		private global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior _explicitTileSizeBehavior;

		// Token: 0x040008C0 RID: 2240
		private global::System.Windows.Size? _synchronizedSize;

		// Token: 0x040008C1 RID: 2241
		private global::System.Windows.HorizontalAlignment _lastHorizontalTileAreaAlignment;

		// Token: 0x040008C2 RID: 2242
		private global::System.Windows.VerticalAlignment _lastVerticalTileAreaAlignment;

		// Token: 0x040008C3 RID: 2243
		private double _explicitMinimizedAreaExtent;

		// Token: 0x040008C4 RID: 2244
		private bool _isInMaximizedMode;

		// Token: 0x040008C5 RID: 2245
		private bool _lastShowAllTiles;

		// Token: 0x040008C6 RID: 2246
		private bool _wasLastScrollableItemGened;

		// Token: 0x040008C7 RID: 2247
		private int _scrollPosition;

		// Token: 0x040008C8 RID: 2248
		private int _scrollPositionOfLastArrangedItem;

		// Token: 0x040008C9 RID: 2249
		private int _scrollLogicalOffset;

		// Token: 0x040008CA RID: 2250
		private int _scrollLogicalOffsetOfLastArrangedItem;

		// Token: 0x040008CB RID: 2251
		private int _lastScrollPosition;

		// Token: 0x040008CC RID: 2252
		private int _lastScrollLogicalOffset;

		// Token: 0x040008CD RID: 2253
		private int _lastNormalModeItemsPerRowColumn;

		// Token: 0x040008CE RID: 2254
		private int _normalModeItemsPerRowColumn;

		// Token: 0x040008CF RID: 2255
		private int _normalModeItemsPerRowColumnActual;

		// Token: 0x040008D0 RID: 2256
		private int _normalModeRowColumnsInView;

		// Token: 0x040008D1 RID: 2257
		private int _normalModeRowColumnsInViewActual;

		// Token: 0x040008D2 RID: 2258
		private int _totalMaximizedColumns;

		// Token: 0x040008D3 RID: 2259
		private int _totalMaximizedRows;

		// Token: 0x040008D4 RID: 2260
		private int _variableTotalRowColmuns;

		// Token: 0x040008D5 RID: 2261
		private double _variableAvgItemsPerRowColumn;

		// Token: 0x040008D6 RID: 2262
		private int _totalColumnsDisplayed;

		// Token: 0x040008D7 RID: 2263
		private int _totalRowsDisplayed;

		// Token: 0x040008D8 RID: 2264
		private bool _scrollTilesVertically;

		// Token: 0x040008D9 RID: 2265
		private bool _scrollTilesHorizontally;

		// Token: 0x040008DA RID: 2266
		private global::System.Windows.Vector _scrollSmallChange = default(global::System.Windows.Vector);

		// Token: 0x040008DB RID: 2267
		private global::System.Windows.Vector _scrollLargeChange = default(global::System.Windows.Vector);

		// Token: 0x040008DC RID: 2268
		private global::System.Windows.Vector _scrollMaxOffset = default(global::System.Windows.Vector);

		// Token: 0x040008DD RID: 2269
		private global::System.Windows.Vector _arrangeOffset = default(global::System.Windows.Vector);

		// Token: 0x040008DE RID: 2270
		private global::System.Windows.Vector _arrangeOffsetForMaxmizedTiles = default(global::System.Windows.Vector);

		// Token: 0x040008DF RID: 2271
		private double _minimizedAreaActualExtent;

		// Token: 0x040008E0 RID: 2272
		private global::System.Windows.Size _defaultMinimunItemSize;

		// Token: 0x040008E1 RID: 2273
		private global::System.Windows.Size _lastMeasureDesiredSize;

		// Token: 0x040008E2 RID: 2274
		private global::System.Windows.Threading.DispatcherOperation _synchLastScrollPosOperation;

		// Token: 0x040008E3 RID: 2275
		private global::Infragistics.Windows.Internal.TileManager.ContainerToItemMapWrapper _containerToItemMap = new global::Infragistics.Windows.Internal.TileManager.ContainerToItemMapWrapper();

		// Token: 0x040008E4 RID: 2276
		private global::Infragistics.Collections.WeakDictionary<object, global::Infragistics.Windows.Internal.TileManager.LayoutItem> _layoutItemMap = new global::Infragistics.Collections.WeakDictionary<object, global::Infragistics.Windows.Internal.TileManager.LayoutItem>(true, false);

		// Token: 0x040008E5 RID: 2277
		private global::Infragistics.Collections.WeakDictionary<object, global::Infragistics.Windows.Tiles.ItemInfoBase> _itemInfoMap = new global::Infragistics.Collections.WeakDictionary<object, global::Infragistics.Windows.Tiles.ItemInfoBase>(true, false);

		// Token: 0x040008E6 RID: 2278
		private global::Infragistics.Windows.Helpers.HashSet _itemsToBeArranged = new global::Infragistics.Windows.Helpers.HashSet();

		// Token: 0x040008E7 RID: 2279
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Tiles.ItemInfoBase> _itemsInView = new global::System.Collections.Generic.List<global::Infragistics.Windows.Tiles.ItemInfoBase>();

		// Token: 0x040008E8 RID: 2280
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.ItemRowColumnSizeInfo> _lastItemLocations;

		// Token: 0x040008E9 RID: 2281
		private global::Infragistics.Windows.Internal.TileManager.ScrollManagerSparseArray _sparseArray = new global::Infragistics.Windows.Internal.TileManager.ScrollManagerSparseArray();

		// Token: 0x040008EA RID: 2282
		private global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache _genCache;

		// Token: 0x020001D9 RID: 473
		private class ItemRowColumnSizeInfo
		{
			// Token: 0x060010AF RID: 4271 RVA: 0x0003B831 File Offset: 0x00039A31
			internal ItemRowColumnSizeInfo(global::Infragistics.Windows.Tiles.ItemInfoBase info, int row, int column, global::System.Windows.Rect targetRect, global::System.Windows.Size preferredSize)
			{
				this._info = info;
				this._row = row;
				this._column = column;
				this._targetRect = targetRect;
				this._preferredSize = preferredSize;
				this._wasMaximized = info.GetIsMaximized();
			}

			// Token: 0x17000367 RID: 871
			// (get) Token: 0x060010B0 RID: 4272 RVA: 0x0003B86A File Offset: 0x00039A6A
			internal int Column
			{
				get
				{
					return this._column;
				}
			}

			// Token: 0x17000368 RID: 872
			// (get) Token: 0x060010B1 RID: 4273 RVA: 0x0003B872 File Offset: 0x00039A72
			internal global::Infragistics.Windows.Tiles.ItemInfoBase Info
			{
				get
				{
					return this._info;
				}
			}

			// Token: 0x17000369 RID: 873
			// (get) Token: 0x060010B2 RID: 4274 RVA: 0x0003B87A File Offset: 0x00039A7A
			internal int Row
			{
				get
				{
					return this._row;
				}
			}

			// Token: 0x1700036A RID: 874
			// (get) Token: 0x060010B3 RID: 4275 RVA: 0x0003B882 File Offset: 0x00039A82
			internal global::System.Windows.Size PreferredSize
			{
				get
				{
					return this._preferredSize;
				}
			}

			// Token: 0x1700036B RID: 875
			// (get) Token: 0x060010B4 RID: 4276 RVA: 0x0003B88A File Offset: 0x00039A8A
			internal global::System.Windows.Rect TargetRect
			{
				get
				{
					return this._targetRect;
				}
			}

			// Token: 0x1700036C RID: 876
			// (get) Token: 0x060010B5 RID: 4277 RVA: 0x0003B892 File Offset: 0x00039A92
			internal bool WasMaximized
			{
				get
				{
					return this._wasMaximized;
				}
			}

			// Token: 0x060010B6 RID: 4278 RVA: 0x0003B89C File Offset: 0x00039A9C
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

			// Token: 0x040008EB RID: 2283
			private global::Infragistics.Windows.Tiles.ItemInfoBase _info;

			// Token: 0x040008EC RID: 2284
			private int _row;

			// Token: 0x040008ED RID: 2285
			private int _column;

			// Token: 0x040008EE RID: 2286
			private global::System.Windows.Rect _targetRect;

			// Token: 0x040008EF RID: 2287
			private global::System.Windows.Size _preferredSize;

			// Token: 0x040008F0 RID: 2288
			private bool _wasMaximized;
		}

		// Token: 0x020001DA RID: 474
		private class LayoutItemGeneratorEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x060010B7 RID: 4279 RVA: 0x0003B8F8 File Offset: 0x00039AF8
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

			// Token: 0x060010B8 RID: 4280 RVA: 0x0003B99B File Offset: 0x00039B9B
			private void EnsureNotEndReached()
			{
				if (this._isEndReached)
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_1"));
				}
			}

			// Token: 0x060010B9 RID: 4281 RVA: 0x0003B9B8 File Offset: 0x00039BB8
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

			// Token: 0x1700036D RID: 877
			// (get) Token: 0x060010BA RID: 4282 RVA: 0x0003BAB5 File Offset: 0x00039CB5
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

			// Token: 0x060010BB RID: 4283 RVA: 0x0003BADB File Offset: 0x00039CDB
			public void Dispose()
			{
			}

			// Token: 0x1700036E RID: 878
			// (get) Token: 0x060010BC RID: 4284 RVA: 0x0003BADD File Offset: 0x00039CDD
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060010BD RID: 4285 RVA: 0x0003BAE8 File Offset: 0x00039CE8
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

			// Token: 0x060010BE RID: 4286 RVA: 0x0003BBAC File Offset: 0x00039DAC
			public void Reset()
			{
				this._isEndReached = false;
				this._currentLogicalIndex = -2;
				this._currentItem = null;
			}

			// Token: 0x040008F1 RID: 2289
			private global::Infragistics.Windows.Internal.TileManager _manager;

			// Token: 0x040008F2 RID: 2290
			private global::Infragistics.Windows.Tiles.TilesPanelBase _panel;

			// Token: 0x040008F3 RID: 2291
			private global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache _genCache;

			// Token: 0x040008F4 RID: 2292
			private int _countMaxmized;

			// Token: 0x040008F5 RID: 2293
			private int _scrollCount;

			// Token: 0x040008F6 RID: 2294
			private int _currentLogicalIndex = -2;

			// Token: 0x040008F7 RID: 2295
			private int _startIndex;

			// Token: 0x040008F8 RID: 2296
			private bool _isEndReached;

			// Token: 0x040008F9 RID: 2297
			private bool _enumerateMaximizedTiles;

			// Token: 0x040008FA RID: 2298
			private global::System.Collections.IList _items;

			// Token: 0x040008FB RID: 2299
			private global::System.Collections.IList _maximizedItems;

			// Token: 0x040008FC RID: 2300
			private global::Infragistics.Controls.Layouts.Primitives.ILayoutItem _currentItem;

			// Token: 0x040008FD RID: 2301
			private global::System.Windows.Controls.Orientation _orientation;

			// Token: 0x040008FE RID: 2302
			private global::Infragistics.Windows.Selection.ScrollDirection _direction;
		}

		// Token: 0x020001DB RID: 475
		internal enum TileArea
		{
			// Token: 0x04000900 RID: 2304
			MaximizedTiles,
			// Token: 0x04000901 RID: 2305
			MinimizedTiles
		}

		// Token: 0x020001DC RID: 476
		internal class LayoutItem : global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint, global::Infragistics.Windows.Tiles.ITileConstraints
		{
			// Token: 0x060010BF RID: 4287 RVA: 0x0003BBC4 File Offset: 0x00039DC4
			internal LayoutItem(global::System.Windows.DependencyObject container, object item, global::Infragistics.Windows.Internal.TileManager manager)
			{
				this._manager = manager;
				this._item = item;
				this.InitializeContainer(container, true);
			}

			// Token: 0x1700036F RID: 879
			// (get) Token: 0x060010C0 RID: 4288 RVA: 0x0003BBE2 File Offset: 0x00039DE2
			internal bool AlwaysMeasureContainer
			{
				get
				{
					return this._asyncDesiredSizeChangeCount > 3;
				}
			}

			// Token: 0x17000370 RID: 880
			// (get) Token: 0x060010C1 RID: 4289 RVA: 0x0003BBED File Offset: 0x00039DED
			internal global::System.Windows.DependencyObject Container
			{
				get
				{
					return this._container;
				}
			}

			// Token: 0x17000371 RID: 881
			// (get) Token: 0x060010C2 RID: 4290 RVA: 0x0003BBF5 File Offset: 0x00039DF5
			internal global::System.Windows.Rect? CurrentRectInternal
			{
				get
				{
					return this._currentRect;
				}
			}

			// Token: 0x17000372 RID: 882
			// (get) Token: 0x060010C3 RID: 4291 RVA: 0x0003BC00 File Offset: 0x00039E00
			// (set) Token: 0x060010C4 RID: 4292 RVA: 0x0003BCA0 File Offset: 0x00039EA0
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

			// Token: 0x17000373 RID: 883
			// (get) Token: 0x060010C5 RID: 4293 RVA: 0x0003BD0D File Offset: 0x00039F0D
			// (set) Token: 0x060010C6 RID: 4294 RVA: 0x0003BD15 File Offset: 0x00039F15
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

			// Token: 0x17000374 RID: 884
			// (get) Token: 0x060010C7 RID: 4295 RVA: 0x0003BD1E File Offset: 0x00039F1E
			internal bool IsCurrentSameAsTarget
			{
				get
				{
					return this._currentRect != null && this._currentRect.Value == this._targetRect;
				}
			}

			// Token: 0x17000375 RID: 885
			// (get) Token: 0x060010C8 RID: 4296 RVA: 0x0003BD45 File Offset: 0x00039F45
			internal object Item
			{
				get
				{
					return this._item;
				}
			}

			// Token: 0x17000376 RID: 886
			// (get) Token: 0x060010C9 RID: 4297 RVA: 0x0003BD4D File Offset: 0x00039F4D
			internal global::Infragistics.Windows.Tiles.ItemInfoBase ItemInfo
			{
				get
				{
					return this._manager.GetItemInfo(this._item, false, -1);
				}
			}

			// Token: 0x17000377 RID: 887
			// (get) Token: 0x060010CA RID: 4298 RVA: 0x0003BD62 File Offset: 0x00039F62
			internal global::System.Windows.Rect OriginalRect
			{
				get
				{
					return this._originalRect;
				}
			}

			// Token: 0x17000378 RID: 888
			// (get) Token: 0x060010CB RID: 4299 RVA: 0x0003BD6A File Offset: 0x00039F6A
			internal global::System.Windows.Size PreferredSizeCache
			{
				get
				{
					return this._preferredSizeCache;
				}
			}

			// Token: 0x17000379 RID: 889
			// (get) Token: 0x060010CC RID: 4300 RVA: 0x0003BD74 File Offset: 0x00039F74
			internal bool ShouldAnimateResize
			{
				get
				{
					global::Infragistics.Windows.Tiles.TileState containerState = this._manager._panel.GetContainerState(this._container);
					return this._lastAtRestTileState != containerState;
				}
			}

			// Token: 0x1700037A RID: 890
			// (get) Token: 0x060010CD RID: 4301 RVA: 0x0003BDA4 File Offset: 0x00039FA4
			internal global::System.Windows.Rect TargetRect
			{
				get
				{
					return this._targetRect;
				}
			}

			// Token: 0x060010CE RID: 4302 RVA: 0x0003BDAC File Offset: 0x00039FAC
			internal void DirtyPreferredSizeCache()
			{
				this._preferredSizeCache = global::System.Windows.Size.Empty;
			}

			// Token: 0x060010CF RID: 4303 RVA: 0x0003BDBC File Offset: 0x00039FBC
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

			// Token: 0x060010D0 RID: 4304 RVA: 0x0003BEE0 File Offset: 0x0003A0E0
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

			// Token: 0x060010D1 RID: 4305 RVA: 0x0003BFD8 File Offset: 0x0003A1D8
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

			// Token: 0x060010D2 RID: 4306 RVA: 0x0003C198 File Offset: 0x0003A398
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

			// Token: 0x060010D3 RID: 4307 RVA: 0x0003C1FC File Offset: 0x0003A3FC
			internal void OffsetAllRects(global::System.Windows.Vector offset)
			{
				this._targetRect.Offset(offset);
				this._originalRect.Offset(offset);
				if (this._currentRect != null)
				{
					this._currentRect = new global::System.Windows.Rect?(global::System.Windows.Rect.Offset(this._currentRect.Value, offset));
				}
			}

			// Token: 0x060010D4 RID: 4308 RVA: 0x0003C24A File Offset: 0x0003A44A
			internal void OnAsyncDesiredSizeChange()
			{
				this._asyncDesiredSizeChangeCount++;
			}

			// Token: 0x060010D5 RID: 4309 RVA: 0x0003C25A File Offset: 0x0003A45A
			internal void SetDimensions(global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions dimensions)
			{
				this._fillAvailableRows = false;
				this._fillAvailableColumns = false;
				this._dimensions = dimensions;
			}

			// Token: 0x060010D6 RID: 4310 RVA: 0x0003C271 File Offset: 0x0003A471
			internal void SetFillAvailableColumns(bool fillAvailableColumns)
			{
				this._fillAvailableColumns = fillAvailableColumns;
			}

			// Token: 0x060010D7 RID: 4311 RVA: 0x0003C27A File Offset: 0x0003A47A
			internal void SetFillAvailableRows(bool fillAvailableRows)
			{
				this._fillAvailableRows = fillAvailableRows;
			}

			// Token: 0x060010D8 RID: 4312 RVA: 0x0003C284 File Offset: 0x0003A484
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
					if (this.AlwaysMeasureContainer)
					{
						flag = true;
					}
					else if (!flag)
					{
						this._manager._panel.OnChildMeasureBypassed(this);
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

			// Token: 0x060010D9 RID: 4313 RVA: 0x0003C36F File Offset: 0x0003A56F
			internal void SetOriginalRect(global::System.Windows.Rect rect, bool calledFromArrange)
			{
				this._originalRect = rect;
				if (!calledFromArrange)
				{
					this._currentRect = new global::System.Windows.Rect?(rect);
				}
			}

			// Token: 0x060010DA RID: 4314 RVA: 0x0003C387 File Offset: 0x0003A587
			internal void SnapshotCurrentRect()
			{
				if (this._currentRect != null)
				{
					this._originalRect = this._currentRect.Value;
				}
			}

			// Token: 0x1700037B RID: 891
			// (get) Token: 0x060010DB RID: 4315 RVA: 0x0003C3A8 File Offset: 0x0003A5A8
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

			// Token: 0x1700037C RID: 892
			// (get) Token: 0x060010DC RID: 4316 RVA: 0x0003C458 File Offset: 0x0003A658
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

			// Token: 0x1700037D RID: 893
			// (get) Token: 0x060010DD RID: 4317 RVA: 0x0003C54A File Offset: 0x0003A74A
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

			// Token: 0x1700037E RID: 894
			// (get) Token: 0x060010DE RID: 4318 RVA: 0x0003C56C File Offset: 0x0003A76C
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

			// Token: 0x1700037F RID: 895
			// (get) Token: 0x060010DF RID: 4319 RVA: 0x0003C583 File Offset: 0x0003A783
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

			// Token: 0x17000380 RID: 896
			// (get) Token: 0x060010E0 RID: 4320 RVA: 0x0003C5B4 File Offset: 0x0003A7B4
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

			// Token: 0x17000381 RID: 897
			// (get) Token: 0x060010E1 RID: 4321 RVA: 0x0003C5EF File Offset: 0x0003A7EF
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
			{
				get
				{
					return (float)this._manager.GetRowColumnProperty(this._container, global::Infragistics.Windows.Tiles.TilesPanelBase.ColumnWeightProperty);
				}
			}

			// Token: 0x17000382 RID: 898
			// (get) Token: 0x060010E2 RID: 4322 RVA: 0x0003C60C File Offset: 0x0003A80C
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

			// Token: 0x17000383 RID: 899
			// (get) Token: 0x060010E3 RID: 4323 RVA: 0x0003C68C File Offset: 0x0003A88C
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

			// Token: 0x17000384 RID: 900
			// (get) Token: 0x060010E4 RID: 4324 RVA: 0x0003C6FE File Offset: 0x0003A8FE
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

			// Token: 0x17000385 RID: 901
			// (get) Token: 0x060010E5 RID: 4325 RVA: 0x0003C72F File Offset: 0x0003A92F
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

			// Token: 0x17000386 RID: 902
			// (get) Token: 0x060010E6 RID: 4326 RVA: 0x0003C76A File Offset: 0x0003A96A
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
			{
				get
				{
					return (float)this._manager.GetRowColumnProperty(this._container, global::Infragistics.Windows.Tiles.TilesPanelBase.RowWeightProperty);
				}
			}

			// Token: 0x17000387 RID: 903
			// (get) Token: 0x060010E7 RID: 4327 RVA: 0x0003C788 File Offset: 0x0003A988
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

			// Token: 0x17000388 RID: 904
			// (get) Token: 0x060010E8 RID: 4328 RVA: 0x0003C806 File Offset: 0x0003AA06
			global::System.Windows.HorizontalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.HorizontalAlignment
			{
				get
				{
					return new global::System.Windows.HorizontalAlignment?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).HorizontalAlignment);
				}
			}

			// Token: 0x17000389 RID: 905
			// (get) Token: 0x060010E9 RID: 4329 RVA: 0x0003C813 File Offset: 0x0003AA13
			global::System.Windows.Thickness? global::Infragistics.Windows.Tiles.ITileConstraints.Margin
			{
				get
				{
					return new global::System.Windows.Thickness?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).Margin);
				}
			}

			// Token: 0x1700038A RID: 906
			// (get) Token: 0x060010EA RID: 4330 RVA: 0x0003C820 File Offset: 0x0003AA20
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MaximumSize.Height;
				}
			}

			// Token: 0x1700038B RID: 907
			// (get) Token: 0x060010EB RID: 4331 RVA: 0x0003C83C File Offset: 0x0003AA3C
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MaximumSize.Width;
				}
			}

			// Token: 0x1700038C RID: 908
			// (get) Token: 0x060010EC RID: 4332 RVA: 0x0003C858 File Offset: 0x0003AA58
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MinimumSize.Height;
				}
			}

			// Token: 0x1700038D RID: 909
			// (get) Token: 0x060010ED RID: 4333 RVA: 0x0003C874 File Offset: 0x0003AA74
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MinimumSize.Width;
				}
			}

			// Token: 0x1700038E RID: 910
			// (get) Token: 0x060010EE RID: 4334 RVA: 0x0003C890 File Offset: 0x0003AA90
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).PreferredSize.Height;
				}
			}

			// Token: 0x1700038F RID: 911
			// (get) Token: 0x060010EF RID: 4335 RVA: 0x0003C8AC File Offset: 0x0003AAAC
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).PreferredSize.Width;
				}
			}

			// Token: 0x17000390 RID: 912
			// (get) Token: 0x060010F0 RID: 4336 RVA: 0x0003C8C7 File Offset: 0x0003AAC7
			global::System.Windows.VerticalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.VerticalAlignment
			{
				get
				{
					return new global::System.Windows.VerticalAlignment?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).VerticalAlignment);
				}
			}

			// Token: 0x04000902 RID: 2306
			private global::System.Windows.DependencyObject _container;

			// Token: 0x04000903 RID: 2307
			private global::System.Windows.UIElement _element;

			// Token: 0x04000904 RID: 2308
			private object _item;

			// Token: 0x04000905 RID: 2309
			private global::Infragistics.Windows.Internal.TileManager _manager;

			// Token: 0x04000906 RID: 2310
			private global::System.Windows.Rect? _currentRect;

			// Token: 0x04000907 RID: 2311
			private global::System.Windows.Rect _targetRect;

			// Token: 0x04000908 RID: 2312
			private global::System.Windows.Rect _originalRect;

			// Token: 0x04000909 RID: 2313
			private global::System.Windows.Controls.Dock _enterFromSide;

			// Token: 0x0400090A RID: 2314
			private global::Infragistics.Windows.Tiles.TileState _lastAtRestTileState;

			// Token: 0x0400090B RID: 2315
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions _dimensions;

			// Token: 0x0400090C RID: 2316
			private bool _fillAvailableRows;

			// Token: 0x0400090D RID: 2317
			private bool _fillAvailableColumns;

			// Token: 0x0400090E RID: 2318
			private int _asyncDesiredSizeChangeCount;

			// Token: 0x0400090F RID: 2319
			private global::System.Windows.Size _preferredSizeCache;

			// Token: 0x04000910 RID: 2320
			private global::System.Windows.Size _desiredSizeCache;

			// Token: 0x04000911 RID: 2321
			private global::System.Windows.Size _lastMeasureSize;
		}

		// Token: 0x020001DD RID: 477
		private class ExplicitItemConstraintWrapper : global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint
		{
			// Token: 0x060010F1 RID: 4337 RVA: 0x0003C8D4 File Offset: 0x0003AAD4
			internal ExplicitItemConstraintWrapper(global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem containerItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint sourceConstraint)
			{
				this._containerItem = containerItem;
				this._sourceConstraint = sourceConstraint;
			}

			// Token: 0x17000391 RID: 913
			// (get) Token: 0x060010F2 RID: 4338 RVA: 0x0003C8EA File Offset: 0x0003AAEA
			public int Column
			{
				get
				{
					return this._sourceConstraint.Column + this._containerItem.ColumnOffset;
				}
			}

			// Token: 0x17000392 RID: 914
			// (get) Token: 0x060010F3 RID: 4339 RVA: 0x0003C903 File Offset: 0x0003AB03
			public int ColumnSpan
			{
				get
				{
					return this._sourceConstraint.ColumnSpan;
				}
			}

			// Token: 0x17000393 RID: 915
			// (get) Token: 0x060010F4 RID: 4340 RVA: 0x0003C910 File Offset: 0x0003AB10
			public float ColumnWeight
			{
				get
				{
					return this._sourceConstraint.ColumnWeight;
				}
			}

			// Token: 0x17000394 RID: 916
			// (get) Token: 0x060010F5 RID: 4341 RVA: 0x0003C91D File Offset: 0x0003AB1D
			public global::System.Windows.HorizontalAlignment HorizontalAlignment
			{
				get
				{
					return this._sourceConstraint.HorizontalAlignment;
				}
			}

			// Token: 0x17000395 RID: 917
			// (get) Token: 0x060010F6 RID: 4342 RVA: 0x0003C92A File Offset: 0x0003AB2A
			public global::System.Windows.Thickness Margin
			{
				get
				{
					return this._sourceConstraint.Margin;
				}
			}

			// Token: 0x17000396 RID: 918
			// (get) Token: 0x060010F7 RID: 4343 RVA: 0x0003C937 File Offset: 0x0003AB37
			public int Row
			{
				get
				{
					return this._sourceConstraint.Row + this._containerItem.RowOffset;
				}
			}

			// Token: 0x17000397 RID: 919
			// (get) Token: 0x060010F8 RID: 4344 RVA: 0x0003C950 File Offset: 0x0003AB50
			public int RowSpan
			{
				get
				{
					return this._sourceConstraint.RowSpan;
				}
			}

			// Token: 0x17000398 RID: 920
			// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0003C95D File Offset: 0x0003AB5D
			public float RowWeight
			{
				get
				{
					return this._sourceConstraint.RowWeight;
				}
			}

			// Token: 0x17000399 RID: 921
			// (get) Token: 0x060010FA RID: 4346 RVA: 0x0003C96A File Offset: 0x0003AB6A
			public global::System.Windows.VerticalAlignment VerticalAlignment
			{
				get
				{
					return this._sourceConstraint.VerticalAlignment;
				}
			}

			// Token: 0x04000912 RID: 2322
			private global::Infragistics.Windows.Internal.TileManager.ExplicitRowColumnLayoutItem _containerItem;

			// Token: 0x04000913 RID: 2323
			private global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint _sourceConstraint;
		}

		// Token: 0x020001DE RID: 478
		private class ExplicitLayoutItemComparer : global::System.Collections.Generic.Comparer<global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint>
		{
			// Token: 0x060010FB RID: 4347 RVA: 0x0003C977 File Offset: 0x0003AB77
			internal ExplicitLayoutItemComparer(global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior behavior)
			{
				this._behavior = behavior;
			}

			// Token: 0x060010FC RID: 4348 RVA: 0x0003C988 File Offset: 0x0003AB88
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

			// Token: 0x04000914 RID: 2324
			private global::Infragistics.Windows.Tiles.ExplicitLayoutTileSizeBehavior _behavior;
		}

		// Token: 0x020001DF RID: 479
		internal class ExplicitRowColumnLayoutItem : global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint, global::Infragistics.Windows.Tiles.ITileConstraints
		{
			// Token: 0x060010FD RID: 4349 RVA: 0x0003CA0C File Offset: 0x0003AC0C
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

			// Token: 0x1700039A RID: 922
			// (get) Token: 0x060010FE RID: 4350 RVA: 0x0003CB24 File Offset: 0x0003AD24
			internal int ColumnOffset
			{
				get
				{
					return this._columnOffset;
				}
			}

			// Token: 0x1700039B RID: 923
			// (get) Token: 0x060010FF RID: 4351 RVA: 0x0003CB2C File Offset: 0x0003AD2C
			internal global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager GridBagManager
			{
				get
				{
					return this._gridBagManager;
				}
			}

			// Token: 0x1700039C RID: 924
			// (get) Token: 0x06001100 RID: 4352 RVA: 0x0003CB34 File Offset: 0x0003AD34
			// (set) Token: 0x06001101 RID: 4353 RVA: 0x0003CB3C File Offset: 0x0003AD3C
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

			// Token: 0x1700039D RID: 925
			// (get) Token: 0x06001102 RID: 4354 RVA: 0x0003CB57 File Offset: 0x0003AD57
			internal int RowOffset
			{
				get
				{
					return this._rowOffset;
				}
			}

			// Token: 0x06001103 RID: 4355 RVA: 0x0003CB60 File Offset: 0x0003AD60
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

			// Token: 0x06001104 RID: 4356 RVA: 0x0003CC3C File Offset: 0x0003AE3C
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

			// Token: 0x06001105 RID: 4357 RVA: 0x0003CCDC File Offset: 0x0003AEDC
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

			// Token: 0x1700039E RID: 926
			// (get) Token: 0x06001106 RID: 4358 RVA: 0x0003CD1B File Offset: 0x0003AF1B
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MaximumSize
			{
				get
				{
					return this._maxSize;
				}
			}

			// Token: 0x1700039F RID: 927
			// (get) Token: 0x06001107 RID: 4359 RVA: 0x0003CD23 File Offset: 0x0003AF23
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MinimumSize
			{
				get
				{
					return this._minSize;
				}
			}

			// Token: 0x170003A0 RID: 928
			// (get) Token: 0x06001108 RID: 4360 RVA: 0x0003CD2B File Offset: 0x0003AF2B
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.PreferredSize
			{
				get
				{
					return this._preferredSize;
				}
			}

			// Token: 0x170003A1 RID: 929
			// (get) Token: 0x06001109 RID: 4361 RVA: 0x0003CD33 File Offset: 0x0003AF33
			global::System.Windows.Visibility global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.Visibility
			{
				get
				{
					return global::System.Windows.Visibility.Visible;
				}
			}

			// Token: 0x170003A2 RID: 930
			// (get) Token: 0x0600110A RID: 4362 RVA: 0x0003CD36 File Offset: 0x0003AF36
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Column
			{
				get
				{
					return this._column;
				}
			}

			// Token: 0x170003A3 RID: 931
			// (get) Token: 0x0600110B RID: 4363 RVA: 0x0003CD3E File Offset: 0x0003AF3E
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
			{
				get
				{
					return this._columnSpan;
				}
			}

			// Token: 0x170003A4 RID: 932
			// (get) Token: 0x0600110C RID: 4364 RVA: 0x0003CD46 File Offset: 0x0003AF46
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
			{
				get
				{
					return this._columnWeight;
				}
			}

			// Token: 0x170003A5 RID: 933
			// (get) Token: 0x0600110D RID: 4365 RVA: 0x0003CD4E File Offset: 0x0003AF4E
			global::System.Windows.HorizontalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.HorizontalAlignment
			{
				get
				{
					return global::System.Windows.HorizontalAlignment.Stretch;
				}
			}

			// Token: 0x170003A6 RID: 934
			// (get) Token: 0x0600110E RID: 4366 RVA: 0x0003CD54 File Offset: 0x0003AF54
			global::System.Windows.Thickness global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Margin
			{
				get
				{
					return default(global::System.Windows.Thickness);
				}
			}

			// Token: 0x170003A7 RID: 935
			// (get) Token: 0x0600110F RID: 4367 RVA: 0x0003CD6A File Offset: 0x0003AF6A
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Row
			{
				get
				{
					return this._row;
				}
			}

			// Token: 0x170003A8 RID: 936
			// (get) Token: 0x06001110 RID: 4368 RVA: 0x0003CD72 File Offset: 0x0003AF72
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
			{
				get
				{
					return this._rowSpan;
				}
			}

			// Token: 0x170003A9 RID: 937
			// (get) Token: 0x06001111 RID: 4369 RVA: 0x0003CD7A File Offset: 0x0003AF7A
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
			{
				get
				{
					return this._rowWeight;
				}
			}

			// Token: 0x170003AA RID: 938
			// (get) Token: 0x06001112 RID: 4370 RVA: 0x0003CD82 File Offset: 0x0003AF82
			global::System.Windows.VerticalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.VerticalAlignment
			{
				get
				{
					return global::System.Windows.VerticalAlignment.Stretch;
				}
			}

			// Token: 0x170003AB RID: 939
			// (get) Token: 0x06001113 RID: 4371 RVA: 0x0003CD85 File Offset: 0x0003AF85
			global::System.Windows.HorizontalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.HorizontalAlignment
			{
				get
				{
					return new global::System.Windows.HorizontalAlignment?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).HorizontalAlignment);
				}
			}

			// Token: 0x170003AC RID: 940
			// (get) Token: 0x06001114 RID: 4372 RVA: 0x0003CD92 File Offset: 0x0003AF92
			global::System.Windows.Thickness? global::Infragistics.Windows.Tiles.ITileConstraints.Margin
			{
				get
				{
					return new global::System.Windows.Thickness?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).Margin);
				}
			}

			// Token: 0x170003AD RID: 941
			// (get) Token: 0x06001115 RID: 4373 RVA: 0x0003CDA0 File Offset: 0x0003AFA0
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MaximumSize.Height;
				}
			}

			// Token: 0x170003AE RID: 942
			// (get) Token: 0x06001116 RID: 4374 RVA: 0x0003CDBC File Offset: 0x0003AFBC
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MaximumSize.Width;
				}
			}

			// Token: 0x170003AF RID: 943
			// (get) Token: 0x06001117 RID: 4375 RVA: 0x0003CDD8 File Offset: 0x0003AFD8
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MinimumSize.Height;
				}
			}

			// Token: 0x170003B0 RID: 944
			// (get) Token: 0x06001118 RID: 4376 RVA: 0x0003CDF4 File Offset: 0x0003AFF4
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MinimumSize.Width;
				}
			}

			// Token: 0x170003B1 RID: 945
			// (get) Token: 0x06001119 RID: 4377 RVA: 0x0003CE10 File Offset: 0x0003B010
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).PreferredSize.Height;
				}
			}

			// Token: 0x170003B2 RID: 946
			// (get) Token: 0x0600111A RID: 4378 RVA: 0x0003CE2C File Offset: 0x0003B02C
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).PreferredSize.Width;
				}
			}

			// Token: 0x170003B3 RID: 947
			// (get) Token: 0x0600111B RID: 4379 RVA: 0x0003CE47 File Offset: 0x0003B047
			global::System.Windows.VerticalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.VerticalAlignment
			{
				get
				{
					return new global::System.Windows.VerticalAlignment?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).VerticalAlignment);
				}
			}

			// Token: 0x04000915 RID: 2325
			private global::Infragistics.Windows.Internal.TileManager _manager;

			// Token: 0x04000916 RID: 2326
			private int _column;

			// Token: 0x04000917 RID: 2327
			private int _columnOffset;

			// Token: 0x04000918 RID: 2328
			private int _columnSpan;

			// Token: 0x04000919 RID: 2329
			private float _columnWeight;

			// Token: 0x0400091A RID: 2330
			private int _row;

			// Token: 0x0400091B RID: 2331
			private int _rowOffset;

			// Token: 0x0400091C RID: 2332
			private int _rowSpan;

			// Token: 0x0400091D RID: 2333
			private float _rowWeight;

			// Token: 0x0400091E RID: 2334
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _gridBagManager = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager();

			// Token: 0x0400091F RID: 2335
			private global::System.Windows.Rect _rect;

			// Token: 0x04000920 RID: 2336
			private global::System.Windows.Size _preferredSize;

			// Token: 0x04000921 RID: 2337
			private global::System.Windows.Size _minSize;

			// Token: 0x04000922 RID: 2338
			private global::System.Windows.Size _maxSize = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);
		}

		// Token: 0x020001E0 RID: 480
		internal class ExplicitRowColumnSection
		{
			// Token: 0x0600111C RID: 4380 RVA: 0x0003CE54 File Offset: 0x0003B054
			internal bool Intersects(int start, int end)
			{
				return end >= this._startRowCol && start <= this._endRowCol;
			}

			// Token: 0x0600111D RID: 4381 RVA: 0x0003CE70 File Offset: 0x0003B070
			internal void Add(global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint item, int start, int end)
			{
				this._startRowCol = global::System.Math.Min(start, this._startRowCol);
				this._endRowCol = global::System.Math.Max(end, this._endRowCol);
				this._span = this._endRowCol + 1 - this._startRowCol;
				this._items.Add(item);
			}

			// Token: 0x04000923 RID: 2339
			internal int _endRowCol;

			// Token: 0x04000924 RID: 2340
			internal int _startRowCol;

			// Token: 0x04000925 RID: 2341
			internal int _span = 1;

			// Token: 0x04000926 RID: 2342
			internal global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint> _items = new global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint>();
		}

		// Token: 0x020001E1 RID: 481
		internal class TileAreaLayoutItem : global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint, global::Infragistics.Windows.Tiles.ITileConstraints
		{
			// Token: 0x0600111F RID: 4383 RVA: 0x0003CEDC File Offset: 0x0003B0DC
			internal TileAreaLayoutItem(global::Infragistics.Windows.Internal.TileManager manager, global::Infragistics.Windows.Internal.TileManager.TileArea area)
			{
				this._manager = manager;
				this._area = area;
			}

			// Token: 0x170003B4 RID: 948
			// (get) Token: 0x06001120 RID: 4384 RVA: 0x0003CEF2 File Offset: 0x0003B0F2
			internal global::Infragistics.Windows.Internal.TileManager.TileArea Area
			{
				get
				{
					return this._area;
				}
			}

			// Token: 0x170003B5 RID: 949
			// (get) Token: 0x06001121 RID: 4385 RVA: 0x0003CEFA File Offset: 0x0003B0FA
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

			// Token: 0x170003B6 RID: 950
			// (get) Token: 0x06001122 RID: 4386 RVA: 0x0003CF1B File Offset: 0x0003B11B
			// (set) Token: 0x06001123 RID: 4387 RVA: 0x0003CF24 File Offset: 0x0003B124
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

			// Token: 0x06001124 RID: 4388 RVA: 0x0003D15C File Offset: 0x0003B35C
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

			// Token: 0x170003B7 RID: 951
			// (get) Token: 0x06001125 RID: 4389 RVA: 0x0003D2E1 File Offset: 0x0003B4E1
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MaximumSize
			{
				get
				{
					return this._maxSizeArea;
				}
			}

			// Token: 0x170003B8 RID: 952
			// (get) Token: 0x06001126 RID: 4390 RVA: 0x0003D2E9 File Offset: 0x0003B4E9
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MinimumSize
			{
				get
				{
					return this._minSizeArea;
				}
			}

			// Token: 0x170003B9 RID: 953
			// (get) Token: 0x06001127 RID: 4391 RVA: 0x0003D2F1 File Offset: 0x0003B4F1
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.PreferredSize
			{
				get
				{
					return this._preferredSize;
				}
			}

			// Token: 0x170003BA RID: 954
			// (get) Token: 0x06001128 RID: 4392 RVA: 0x0003D2F9 File Offset: 0x0003B4F9
			global::System.Windows.Visibility global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.Visibility
			{
				get
				{
					return global::System.Windows.Visibility.Visible;
				}
			}

			// Token: 0x170003BB RID: 955
			// (get) Token: 0x06001129 RID: 4393 RVA: 0x0003D2FC File Offset: 0x0003B4FC
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

			// Token: 0x170003BC RID: 956
			// (get) Token: 0x0600112A RID: 4394 RVA: 0x0003D329 File Offset: 0x0003B529
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x170003BD RID: 957
			// (get) Token: 0x0600112B RID: 4395 RVA: 0x0003D32C File Offset: 0x0003B52C
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

			// Token: 0x170003BE RID: 958
			// (get) Token: 0x0600112C RID: 4396 RVA: 0x0003D341 File Offset: 0x0003B541
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

			// Token: 0x170003BF RID: 959
			// (get) Token: 0x0600112D RID: 4397 RVA: 0x0003D378 File Offset: 0x0003B578
			global::System.Windows.Thickness global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Margin
			{
				get
				{
					return default(global::System.Windows.Thickness);
				}
			}

			// Token: 0x170003C0 RID: 960
			// (get) Token: 0x0600112E RID: 4398 RVA: 0x0003D38E File Offset: 0x0003B58E
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

			// Token: 0x170003C1 RID: 961
			// (get) Token: 0x0600112F RID: 4399 RVA: 0x0003D3BB File Offset: 0x0003B5BB
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x170003C2 RID: 962
			// (get) Token: 0x06001130 RID: 4400 RVA: 0x0003D3BE File Offset: 0x0003B5BE
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

			// Token: 0x170003C3 RID: 963
			// (get) Token: 0x06001131 RID: 4401 RVA: 0x0003D3D3 File Offset: 0x0003B5D3
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

			// Token: 0x170003C4 RID: 964
			// (get) Token: 0x06001132 RID: 4402 RVA: 0x0003D40A File Offset: 0x0003B60A
			global::System.Windows.HorizontalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.HorizontalAlignment
			{
				get
				{
					return new global::System.Windows.HorizontalAlignment?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).HorizontalAlignment);
				}
			}

			// Token: 0x170003C5 RID: 965
			// (get) Token: 0x06001133 RID: 4403 RVA: 0x0003D417 File Offset: 0x0003B617
			global::System.Windows.Thickness? global::Infragistics.Windows.Tiles.ITileConstraints.Margin
			{
				get
				{
					return new global::System.Windows.Thickness?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).Margin);
				}
			}

			// Token: 0x170003C6 RID: 966
			// (get) Token: 0x06001134 RID: 4404 RVA: 0x0003D424 File Offset: 0x0003B624
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxHeight
			{
				get
				{
					return this._maxSizeContents.Height;
				}
			}

			// Token: 0x170003C7 RID: 967
			// (get) Token: 0x06001135 RID: 4405 RVA: 0x0003D431 File Offset: 0x0003B631
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxWidth
			{
				get
				{
					return this._maxSizeContents.Width;
				}
			}

			// Token: 0x170003C8 RID: 968
			// (get) Token: 0x06001136 RID: 4406 RVA: 0x0003D43E File Offset: 0x0003B63E
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinHeight
			{
				get
				{
					return this._minSizeContents.Height;
				}
			}

			// Token: 0x170003C9 RID: 969
			// (get) Token: 0x06001137 RID: 4407 RVA: 0x0003D44B File Offset: 0x0003B64B
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinWidth
			{
				get
				{
					return this._minSizeContents.Width;
				}
			}

			// Token: 0x170003CA RID: 970
			// (get) Token: 0x06001138 RID: 4408 RVA: 0x0003D458 File Offset: 0x0003B658
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredHeight
			{
				get
				{
					return this._preferredSize.Height;
				}
			}

			// Token: 0x170003CB RID: 971
			// (get) Token: 0x06001139 RID: 4409 RVA: 0x0003D465 File Offset: 0x0003B665
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredWidth
			{
				get
				{
					return this._preferredSize.Width;
				}
			}

			// Token: 0x170003CC RID: 972
			// (get) Token: 0x0600113A RID: 4410 RVA: 0x0003D472 File Offset: 0x0003B672
			global::System.Windows.VerticalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.VerticalAlignment
			{
				get
				{
					return new global::System.Windows.VerticalAlignment?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).VerticalAlignment);
				}
			}

			// Token: 0x04000927 RID: 2343
			private global::Infragistics.Windows.Internal.TileManager _manager;

			// Token: 0x04000928 RID: 2344
			private global::Infragistics.Windows.Internal.TileManager.TileArea _area;

			// Token: 0x04000929 RID: 2345
			private global::System.Windows.Rect _rect;

			// Token: 0x0400092A RID: 2346
			private global::System.Windows.Size _minSizeContents;

			// Token: 0x0400092B RID: 2347
			private global::System.Windows.Size _maxSizeContents;

			// Token: 0x0400092C RID: 2348
			private global::System.Windows.Size _minSizeArea;

			// Token: 0x0400092D RID: 2349
			private global::System.Windows.Size _maxSizeArea;

			// Token: 0x0400092E RID: 2350
			private global::System.Windows.Size _preferredSize;
		}

		// Token: 0x020001E2 RID: 482
		internal class TileRowColumnLayoutItem : global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint, global::Infragistics.Windows.Tiles.ITileConstraints
		{
			// Token: 0x0600113B RID: 4411 RVA: 0x0003D480 File Offset: 0x0003B680
			internal TileRowColumnLayoutItem(global::Infragistics.Windows.Internal.TileManager manager, bool isTileRow, int rowColumnIndex, int scrollOffset)
			{
				this._manager = manager;
				this._isTileRow = isTileRow;
				this._rowColumnIndex = rowColumnIndex;
				this._scrollOffset = scrollOffset;
			}

			// Token: 0x170003CD RID: 973
			// (get) Token: 0x0600113C RID: 4412 RVA: 0x0003D4D8 File Offset: 0x0003B6D8
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

			// Token: 0x170003CE RID: 974
			// (get) Token: 0x0600113D RID: 4413 RVA: 0x0003D505 File Offset: 0x0003B705
			internal global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager GridBagManager
			{
				get
				{
					return this._gridBagManager;
				}
			}

			// Token: 0x170003CF RID: 975
			// (get) Token: 0x0600113E RID: 4414 RVA: 0x0003D50D File Offset: 0x0003B70D
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

			// Token: 0x170003D0 RID: 976
			// (get) Token: 0x0600113F RID: 4415 RVA: 0x0003D54B File Offset: 0x0003B74B
			internal int LastScrollPositionGenerated
			{
				get
				{
					return this._lastScrollPositionGenerated;
				}
			}

			// Token: 0x170003D1 RID: 977
			// (get) Token: 0x06001140 RID: 4416 RVA: 0x0003D553 File Offset: 0x0003B753
			// (set) Token: 0x06001141 RID: 4417 RVA: 0x0003D55C File Offset: 0x0003B75C
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

			// Token: 0x170003D2 RID: 978
			// (get) Token: 0x06001142 RID: 4418 RVA: 0x0003D607 File Offset: 0x0003B807
			internal int ScrollOffset
			{
				get
				{
					return this._scrollOffset;
				}
			}

			// Token: 0x06001143 RID: 4419 RVA: 0x0003D610 File Offset: 0x0003B810
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

			// Token: 0x06001144 RID: 4420 RVA: 0x0003D740 File Offset: 0x0003B940
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

			// Token: 0x06001145 RID: 4421 RVA: 0x0003D798 File Offset: 0x0003B998
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

			// Token: 0x06001146 RID: 4422 RVA: 0x0003D7EC File Offset: 0x0003B9EC
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

			// Token: 0x170003D3 RID: 979
			// (get) Token: 0x06001147 RID: 4423 RVA: 0x0003D853 File Offset: 0x0003BA53
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MaximumSize
			{
				get
				{
					return this._maxSize;
				}
			}

			// Token: 0x170003D4 RID: 980
			// (get) Token: 0x06001148 RID: 4424 RVA: 0x0003D85B File Offset: 0x0003BA5B
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MinimumSize
			{
				get
				{
					return this._minSize;
				}
			}

			// Token: 0x170003D5 RID: 981
			// (get) Token: 0x06001149 RID: 4425 RVA: 0x0003D863 File Offset: 0x0003BA63
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.PreferredSize
			{
				get
				{
					return this._preferredSize;
				}
			}

			// Token: 0x170003D6 RID: 982
			// (get) Token: 0x0600114A RID: 4426 RVA: 0x0003D86B File Offset: 0x0003BA6B
			global::System.Windows.Visibility global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.Visibility
			{
				get
				{
					return global::System.Windows.Visibility.Visible;
				}
			}

			// Token: 0x170003D7 RID: 983
			// (get) Token: 0x0600114B RID: 4427 RVA: 0x0003D86E File Offset: 0x0003BA6E
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

			// Token: 0x170003D8 RID: 984
			// (get) Token: 0x0600114C RID: 4428 RVA: 0x0003D880 File Offset: 0x0003BA80
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x170003D9 RID: 985
			// (get) Token: 0x0600114D RID: 4429 RVA: 0x0003D883 File Offset: 0x0003BA83
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
			{
				get
				{
					return 0f;
				}
			}

			// Token: 0x170003DA RID: 986
			// (get) Token: 0x0600114E RID: 4430 RVA: 0x0003D88A File Offset: 0x0003BA8A
			global::System.Windows.HorizontalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.HorizontalAlignment
			{
				get
				{
					return global::System.Windows.HorizontalAlignment.Stretch;
				}
			}

			// Token: 0x170003DB RID: 987
			// (get) Token: 0x0600114F RID: 4431 RVA: 0x0003D890 File Offset: 0x0003BA90
			global::System.Windows.Thickness global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Margin
			{
				get
				{
					return default(global::System.Windows.Thickness);
				}
			}

			// Token: 0x170003DC RID: 988
			// (get) Token: 0x06001150 RID: 4432 RVA: 0x0003D8A6 File Offset: 0x0003BAA6
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

			// Token: 0x170003DD RID: 989
			// (get) Token: 0x06001151 RID: 4433 RVA: 0x0003D8B8 File Offset: 0x0003BAB8
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x170003DE RID: 990
			// (get) Token: 0x06001152 RID: 4434 RVA: 0x0003D8BB File Offset: 0x0003BABB
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
			{
				get
				{
					return 0f;
				}
			}

			// Token: 0x170003DF RID: 991
			// (get) Token: 0x06001153 RID: 4435 RVA: 0x0003D8C2 File Offset: 0x0003BAC2
			global::System.Windows.VerticalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.VerticalAlignment
			{
				get
				{
					return global::System.Windows.VerticalAlignment.Stretch;
				}
			}

			// Token: 0x170003E0 RID: 992
			// (get) Token: 0x06001154 RID: 4436 RVA: 0x0003D8C5 File Offset: 0x0003BAC5
			global::System.Windows.HorizontalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.HorizontalAlignment
			{
				get
				{
					return new global::System.Windows.HorizontalAlignment?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).HorizontalAlignment);
				}
			}

			// Token: 0x170003E1 RID: 993
			// (get) Token: 0x06001155 RID: 4437 RVA: 0x0003D8D2 File Offset: 0x0003BAD2
			global::System.Windows.Thickness? global::Infragistics.Windows.Tiles.ITileConstraints.Margin
			{
				get
				{
					return new global::System.Windows.Thickness?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).Margin);
				}
			}

			// Token: 0x170003E2 RID: 994
			// (get) Token: 0x06001156 RID: 4438 RVA: 0x0003D8E0 File Offset: 0x0003BAE0
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MaximumSize.Height;
				}
			}

			// Token: 0x170003E3 RID: 995
			// (get) Token: 0x06001157 RID: 4439 RVA: 0x0003D8FC File Offset: 0x0003BAFC
			double global::Infragistics.Windows.Tiles.ITileConstraints.MaxWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MaximumSize.Width;
				}
			}

			// Token: 0x170003E4 RID: 996
			// (get) Token: 0x06001158 RID: 4440 RVA: 0x0003D918 File Offset: 0x0003BB18
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MinimumSize.Height;
				}
			}

			// Token: 0x170003E5 RID: 997
			// (get) Token: 0x06001159 RID: 4441 RVA: 0x0003D934 File Offset: 0x0003BB34
			double global::Infragistics.Windows.Tiles.ITileConstraints.MinWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).MinimumSize.Width;
				}
			}

			// Token: 0x170003E6 RID: 998
			// (get) Token: 0x0600115A RID: 4442 RVA: 0x0003D950 File Offset: 0x0003BB50
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredHeight
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).PreferredSize.Height;
				}
			}

			// Token: 0x170003E7 RID: 999
			// (get) Token: 0x0600115B RID: 4443 RVA: 0x0003D96C File Offset: 0x0003BB6C
			double global::Infragistics.Windows.Tiles.ITileConstraints.PreferredWidth
			{
				get
				{
					return ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)this).PreferredSize.Width;
				}
			}

			// Token: 0x170003E8 RID: 1000
			// (get) Token: 0x0600115C RID: 4444 RVA: 0x0003D987 File Offset: 0x0003BB87
			global::System.Windows.VerticalAlignment? global::Infragistics.Windows.Tiles.ITileConstraints.VerticalAlignment
			{
				get
				{
					return new global::System.Windows.VerticalAlignment?(((global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)this).VerticalAlignment);
				}
			}

			// Token: 0x0400092F RID: 2351
			private global::Infragistics.Windows.Internal.TileManager _manager;

			// Token: 0x04000930 RID: 2352
			private int _rowColumnIndex;

			// Token: 0x04000931 RID: 2353
			private int _scrollOffset;

			// Token: 0x04000932 RID: 2354
			private int _lastScrollPositionGenerated;

			// Token: 0x04000933 RID: 2355
			private bool _isTileRow;

			// Token: 0x04000934 RID: 2356
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager _gridBagManager = new global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager();

			// Token: 0x04000935 RID: 2357
			private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection _childDimensionsCollection;

			// Token: 0x04000936 RID: 2358
			private global::System.Windows.Rect _rect;

			// Token: 0x04000937 RID: 2359
			private global::System.Windows.Size _preferredSize;

			// Token: 0x04000938 RID: 2360
			private global::System.Windows.Size _minSize;

			// Token: 0x04000939 RID: 2361
			private global::System.Windows.Size _maxSize = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);
		}

		// Token: 0x020001E3 RID: 483
		private class TileRowColumnGeneratorEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x0600115D RID: 4445 RVA: 0x0003D994 File Offset: 0x0003BB94
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

			// Token: 0x0600115E RID: 4446 RVA: 0x0003DA3D File Offset: 0x0003BC3D
			private void EnsureNotEndReached()
			{
				if (this._isEndReached)
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_1"));
				}
			}

			// Token: 0x0600115F RID: 4447 RVA: 0x0003DA58 File Offset: 0x0003BC58
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

			// Token: 0x170003E9 RID: 1001
			// (get) Token: 0x06001160 RID: 4448 RVA: 0x0003DAC3 File Offset: 0x0003BCC3
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

			// Token: 0x06001161 RID: 4449 RVA: 0x0003DAE9 File Offset: 0x0003BCE9
			public void Dispose()
			{
			}

			// Token: 0x170003EA RID: 1002
			// (get) Token: 0x06001162 RID: 4450 RVA: 0x0003DAEB File Offset: 0x0003BCEB
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06001163 RID: 4451 RVA: 0x0003DAF4 File Offset: 0x0003BCF4
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

			// Token: 0x06001164 RID: 4452 RVA: 0x0003DD3C File Offset: 0x0003BF3C
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

			// Token: 0x0400093A RID: 2362
			private global::Infragistics.Windows.Internal.TileManager _manager;

			// Token: 0x0400093B RID: 2363
			private global::Infragistics.Windows.Tiles.TilesPanelBase _panel;

			// Token: 0x0400093C RID: 2364
			private global::Infragistics.Windows.Tiles.TilesPanelBase.GenerationCache _genCache;

			// Token: 0x0400093D RID: 2365
			private int _scrollCount;

			// Token: 0x0400093E RID: 2366
			private int _currentScrollPosition = -2;

			// Token: 0x0400093F RID: 2367
			private int _currentScrollOffset;

			// Token: 0x04000940 RID: 2368
			private int _currentRowColumnIndex = -1;

			// Token: 0x04000941 RID: 2369
			private int _startIndex;

			// Token: 0x04000942 RID: 2370
			private double _extentRemaining;

			// Token: 0x04000943 RID: 2371
			private bool _isEndReached;

			// Token: 0x04000944 RID: 2372
			private bool _enumerateRows;

			// Token: 0x04000945 RID: 2373
			private global::Infragistics.Windows.Selection.ScrollDirection _direction;

			// Token: 0x04000946 RID: 2374
			private global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem _currentTileRowColumn;

			// Token: 0x04000947 RID: 2375
			private global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem> _tileRowColumns = new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TileManager.TileRowColumnLayoutItem>();

			// Token: 0x04000948 RID: 2376
			private int _maxElementsToGenerate;
		}

		// Token: 0x020001E4 RID: 484
		internal class ScrollManagerSparseArray : global::Infragistics.Collections.SparseArray
		{
			// Token: 0x06001165 RID: 4453 RVA: 0x0003DDA1 File Offset: 0x0003BFA1
			internal ScrollManagerSparseArray() : base(20, 1f, true, true)
			{
			}

			// Token: 0x170003EB RID: 1003
			// (get) Token: 0x06001166 RID: 4454 RVA: 0x0003DDB2 File Offset: 0x0003BFB2
			internal int ScrollCount
			{
				get
				{
					return base.GetScrollCount();
				}
			}

			// Token: 0x06001167 RID: 4455 RVA: 0x0003DDBA File Offset: 0x0003BFBA
			internal global::Infragistics.Windows.Tiles.ItemInfoBase GetItemAtScrollIndex(int index)
			{
				return (global::Infragistics.Windows.Tiles.ItemInfoBase)base.GetItemAtScrollIndex(index, null);
			}

			// Token: 0x06001168 RID: 4456 RVA: 0x0003DDC9 File Offset: 0x0003BFC9
			internal int GetScrollIndexOfItem(global::Infragistics.Windows.Tiles.ItemInfoBase item)
			{
				return base.GetScrollIndexOf(item);
			}

			// Token: 0x06001169 RID: 4457 RVA: 0x0003DDD2 File Offset: 0x0003BFD2
			internal void InvalidateScrollCounts()
			{
				base.DirtyScrollCountInfo();
			}

			// Token: 0x0600116A RID: 4458 RVA: 0x0003DDDA File Offset: 0x0003BFDA
			internal void InvalidateItem(global::Infragistics.Windows.Tiles.ItemInfoBase arrayItem)
			{
				base.NotifyItemScrollCountChanged(arrayItem);
			}
		}

		// Token: 0x020001E5 RID: 485
		private class ContainerToItemMapWrapper
		{
			// Token: 0x0600116B RID: 4459 RVA: 0x0003DDE3 File Offset: 0x0003BFE3
			internal void Add(global::System.Windows.DependencyObject container, object item)
			{
				this._map.Add(container, object.ReferenceEquals(container, item) ? global::Infragistics.Windows.Internal.TileManager.ContainerToItemMapWrapper.ItemIsContainerMarker : item);
			}

			// Token: 0x0600116C RID: 4460 RVA: 0x0003DE02 File Offset: 0x0003C002
			internal void Clear()
			{
				this._map.Clear();
			}

			// Token: 0x0600116D RID: 4461 RVA: 0x0003DE0F File Offset: 0x0003C00F
			internal bool ContainsKey(global::System.Windows.DependencyObject container)
			{
				return this._map.ContainsKey(container);
			}

			// Token: 0x170003EC RID: 1004
			internal object this[global::System.Windows.DependencyObject container]
			{
				get
				{
					object obj = this._map[container];
					if (object.ReferenceEquals(obj, global::Infragistics.Windows.Internal.TileManager.ContainerToItemMapWrapper.ItemIsContainerMarker))
					{
						return container;
					}
					return obj;
				}
				set
				{
					this._map[container] = (object.ReferenceEquals(container, value) ? global::Infragistics.Windows.Internal.TileManager.ContainerToItemMapWrapper.ItemIsContainerMarker : value);
				}
			}

			// Token: 0x06001170 RID: 4464 RVA: 0x0003DE69 File Offset: 0x0003C069
			internal bool Remove(global::System.Windows.DependencyObject container)
			{
				return this._map.Remove(container);
			}

			// Token: 0x06001171 RID: 4465 RVA: 0x0003DE77 File Offset: 0x0003C077
			internal bool TryGetValue(global::System.Windows.DependencyObject container, out object item)
			{
				if (!this._map.TryGetValue(container, out item))
				{
					return false;
				}
				if (object.ReferenceEquals(item, global::Infragistics.Windows.Internal.TileManager.ContainerToItemMapWrapper.ItemIsContainerMarker))
				{
					item = container;
				}
				return true;
			}

			// Token: 0x04000949 RID: 2377
			private static object ItemIsContainerMarker = new object();

			// Token: 0x0400094A RID: 2378
			private global::Infragistics.Collections.WeakDictionary<global::System.Windows.DependencyObject, object> _map = new global::Infragistics.Collections.WeakDictionary<global::System.Windows.DependencyObject, object>(true, false);
		}
	}
}
