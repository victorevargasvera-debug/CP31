using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200017A RID: 378
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GridViewPanelFlat : global::Infragistics.Windows.DataPresenter.GridViewPanel
	{
		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060017C3 RID: 6083 RVA: 0x0006C458 File Offset: 0x0006A658
		// (set) Token: 0x060017C4 RID: 6084 RVA: 0x0006C465 File Offset: 0x0006A665
		internal override int EffectiveScrollPosition
		{
			get
			{
				return base.ViewPanelInfo.OverallScrollPosition;
			}
			set
			{
				base.ViewPanelInfo.OverallScrollPosition = value;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060017C5 RID: 6085 RVA: 0x0006C474 File Offset: 0x0006A674
		internal override global::Infragistics.Windows.DataPresenter.Record FirstScrollableRecord
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection records = this.Records;
				if (records == null)
				{
					return null;
				}
				int countOfNonHeaderRecords = records.CountOfNonHeaderRecords;
				if (countOfNonHeaderRecords == 0)
				{
					return null;
				}
				int countOfFixedRecordsOnTop = records.CountOfFixedRecordsOnTop;
				int countOfFixedRecordsOnBottom = records.CountOfFixedRecordsOnBottom;
				if (this._offsetWithinListForScrollableRecords < countOfNonHeaderRecords - (countOfFixedRecordsOnTop + countOfFixedRecordsOnBottom))
				{
					return records.GetRecordAtScrollPosition(this.EffectiveScrollPosition);
				}
				if (this._offsetWithinListForTopFixedRecords >= countOfFixedRecordsOnTop)
				{
					return records[this._offsetWithinListForTopFixedRecords];
				}
				if (this._offsetWithinListForBottomFixedRecords < countOfFixedRecordsOnBottom)
				{
					return records[this._offsetWithinListForBottomFixedRecords + countOfNonHeaderRecords - countOfFixedRecordsOnTop];
				}
				return null;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x0006C4F2 File Offset: 0x0006A6F2
		public override bool IsRootPanel
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x0006C4F5 File Offset: 0x0006A6F5
		internal override bool IsRootPanelInInfiniteContainer
		{
			get
			{
				return this._isInInfiniteContainer;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x0006C4FD File Offset: 0x0006A6FD
		public override global::Infragistics.Windows.DataPresenter.GridViewPanel RootPanel
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x0006C500 File Offset: 0x0006A700
		internal override int RootPanelTopFixedOffset
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection records = this.Records;
				if (records != null)
				{
					return records.CountOfFixedRecordsOnTop;
				}
				return 0;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x0006C51F File Offset: 0x0006A71F
		internal override int ScrollPositionOfLastVisibleRecord
		{
			get
			{
				return this._scrollPositionOfLastVisibleRecord;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x0006C528 File Offset: 0x0006A728
		protected override int TotalVisibleGeneratedItems
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection records = this.Records;
				if (records == null)
				{
					return 0;
				}
				return global::System.Math.Min(base.TotalItems - 1, this._scrollableElementsGenerated + records.CountOfFixedRecordsOnTop + records.CountOfFixedRecordsOnBottom - (this._offsetWithinListForTopFixedRecords + this._offsetWithinListForBottomFixedRecords));
			}
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x0006C570 File Offset: 0x0006A770
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			base.ArrangeOverride(finalSize);
			if (base.ViewSettings == null)
			{
				return finalSize;
			}
			bool flag = this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical;
			global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData scrollingData = base.ScrollingData;
			global::System.Windows.Vector offset = scrollingData._offset;
			if (flag)
			{
				offset.X = global::System.Math.Max(global::System.Math.Min(offset.X, scrollingData._extent.Width - scrollingData._viewport.Width), 0.0);
			}
			else
			{
				offset.Y = global::System.Math.Max(global::System.Math.Min(offset.Y, scrollingData._extent.Height - scrollingData._viewport.Height), 0.0);
			}
			if (offset != scrollingData._offset)
			{
				this.VerifyScrollData(scrollingData._extent, scrollingData._viewport, offset, scrollingData._availableScrollSize);
			}
			global::System.Windows.Rect rect = new global::System.Windows.Rect(finalSize);
			double extentUsedByLastItem = 0.0;
			global::System.Windows.Rect rect2 = default(global::System.Windows.Rect);
			global::System.Windows.Rect rect3 = global::System.Windows.Rect.Empty;
			double num = 0.0;
			global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection records = this.Records;
			if (records == null)
			{
				return finalSize;
			}
			int num2 = this._topFixedElementsGenerated + this._bottomFixedElementsGenerated + this._scrollableElementsGenerated;
			int num3 = num2 + this._headerElementsGenerated;
			int countOfNonHeaderRecords = records.CountOfNonHeaderRecords;
			int countOfFixedRecordsOnBottom = records.CountOfFixedRecordsOnBottom;
			if (num3 == 0)
			{
				return finalSize;
			}
			double num4;
			if (flag)
			{
				rect.X = -1.0 * base.ScrollingData._offset.X;
				num4 = finalSize.Height;
			}
			else
			{
				rect.Y = -1.0 * base.ScrollingData._offset.Y;
				num4 = finalSize.Width;
			}
			global::System.Collections.IList childElements = base.ChildElements;
			int count = childElements.Count;
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Record, global::System.Windows.UIElement> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Record, global::System.Windows.UIElement>();
			global::System.Collections.Generic.Dictionary<global::System.Windows.UIElement, global::Infragistics.Windows.DataPresenter.RecordPresenter> dictionary2 = new global::System.Collections.Generic.Dictionary<global::System.Windows.UIElement, global::Infragistics.Windows.DataPresenter.RecordPresenter>();
			int count2 = this._generatedElements.Count;
			for (int i = 0; i < count2; i++)
			{
				global::System.Windows.UIElement uielement = this._generatedElements[i];
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(uielement);
				dictionary2[uielement] = recordPresenterFromContainer;
				if (recordPresenterFromContainer != null)
				{
					global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = recordPresenterFromContainer.Record as global::Infragistics.Windows.DataPresenter.HeaderRecord;
					if (headerRecord != null)
					{
						global::Infragistics.Windows.DataPresenter.Record attachedToRecord = headerRecord.AttachedToRecord;
						if (attachedToRecord != null)
						{
							dictionary[attachedToRecord] = uielement;
						}
					}
				}
			}
			global::System.Collections.Generic.Stack<global::System.Windows.UIElement> stack = null;
			global::Infragistics.Windows.DataPresenter.Record record = null;
			int num5 = global::System.Math.Max(0, count2 - (this._topFixedElementsGenerated + this._bottomFixedElementsGenerated + this._headerElementsGenerated));
			int num6 = 0;
			for (int j = 0; j < count2; j++)
			{
				global::System.Windows.UIElement uielement2 = this._generatedElements[j];
				double num7 = double.PositiveInfinity;
				if (j == 0 && num2 == 0 && this._headerElementsGenerated > 0)
				{
					extentUsedByLastItem = this.ArrangeHelper(uielement2, null, flag, false, extentUsedByLastItem, double.PositiveInfinity, finalSize, ref rect, ref num);
					num6++;
				}
				else if (this._topFixedElementsGenerated > 0 && j >= 0 && j < this._topFixedElementsGenerated)
				{
					double num8;
					if (j == 0)
					{
						num8 = 0.0;
					}
					else if (flag)
					{
						num8 = rect.Bottom;
					}
					else
					{
						num8 = rect.Right;
					}
					num7 = num4 - (num8 + this._extentUsedByFixedRecordsOnBottom);
					extentUsedByLastItem = this.ArrangeHelper(uielement2, dictionary, flag, false, extentUsedByLastItem, num7, finalSize, ref rect, ref num);
					num6++;
				}
				else if (num5 > 0)
				{
					num5--;
					if (record == null)
					{
						global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer2 = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(uielement2);
						if (recordPresenterFromContainer2 != null)
						{
							record = recordPresenterFromContainer2.Record;
						}
					}
					if (num5 == 0 && j > 0)
					{
						num7 = num4 - this._extentUsedByFixedRecordsOnBottom;
						if (flag)
						{
							num7 -= rect.Bottom;
						}
						else
						{
							num7 -= rect.Right;
						}
					}
					extentUsedByLastItem = this.ArrangeHelper(uielement2, dictionary, flag, false, extentUsedByLastItem, num7, finalSize, ref rect, ref num);
					num6++;
				}
				else if (j < num2)
				{
					if (num6 == 0 && dictionary.Count > 0)
					{
						global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer3 = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(uielement2);
						global::System.Windows.UIElement visualChildElement;
						if (recordPresenterFromContainer3 != null && dictionary.TryGetValue(recordPresenterFromContainer3.Record, out visualChildElement))
						{
							dictionary.Remove(recordPresenterFromContainer3.Record);
							extentUsedByLastItem = this.ArrangeHelper(visualChildElement, null, flag, false, extentUsedByLastItem, double.PositiveInfinity, finalSize, ref rect, ref num);
							num6++;
						}
					}
					if (stack == null)
					{
						stack = new global::System.Collections.Generic.Stack<global::System.Windows.UIElement>();
					}
					stack.Push(uielement2);
				}
				rect2.Union(rect);
			}
			foreach (global::System.Windows.UIElement uielement3 in dictionary.Values)
			{
				global::System.Windows.Rect finalRect = new global::System.Windows.Rect(new global::System.Windows.Point(-10000.0, -10000.0), uielement3.DesiredSize);
				uielement3.Arrange(finalRect);
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			bool flag2 = dataPresenter != null && dataPresenter.RecordContainerGenerationMode == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.PreLoad;
			for (int k = 0; k < count; k++)
			{
				global::System.Windows.UIElement uielement4 = childElements[k] as global::System.Windows.UIElement;
				if (!dictionary2.ContainsKey(uielement4))
				{
					global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer4 = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(uielement4);
					if (recordPresenterFromContainer4 != null)
					{
						if (flag2 && !recordPresenterFromContainer4.IsLoaded)
						{
							recordPresenterFromContainer4.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
							global::System.Windows.Point location = flag ? new global::System.Windows.Point(0.0, -10000.0) : new global::System.Windows.Point(-10000.0, 0.0);
							recordPresenterFromContainer4.Arrange(new global::System.Windows.Rect(location, recordPresenterFromContainer4.DesiredSize));
							goto IL_5B9;
						}
						bool isHidingRecord = base.IsHidingRecord;
						base.IsHidingRecord = true;
						try
						{
							recordPresenterFromContainer4.IsArrangedInView = false;
							recordPresenterFromContainer4.TreatAsCollapsed = true;
							recordPresenterFromContainer4.InternalClip = null;
							goto IL_5B9;
						}
						finally
						{
							base.IsHidingRecord = isHidingRecord;
						}
					}
					global::System.Windows.Size desiredSize = uielement4.DesiredSize;
					uielement4.Arrange(new global::System.Windows.Rect(new global::System.Windows.Point(-10000.0 * finalSize.Width, -10000.0 * finalSize.Height), desiredSize));
				}
				IL_5B9:
				rect2.Union(rect);
			}
			if (stack != null)
			{
				global::System.Windows.Point location2;
				if (flag)
				{
					location2 = new global::System.Windows.Point(0.0, finalSize.Height);
				}
				else
				{
					location2 = new global::System.Windows.Point(finalSize.Width, 0.0);
				}
				if (flag)
				{
					location2.X = -1.0 * base.ScrollingData._offset.X;
				}
				else
				{
					location2.Y = -1.0 * base.ScrollingData._offset.Y;
				}
				num = 0.0;
				global::System.Windows.Rect rect4 = new global::System.Windows.Rect(location2, finalSize);
				extentUsedByLastItem = 0.0;
				while (stack.Count > 0)
				{
					global::System.Windows.UIElement visualChildElement2 = stack.Pop();
					extentUsedByLastItem = this.ArrangeHelper(visualChildElement2, dictionary, flag, true, extentUsedByLastItem, double.PositiveInfinity, finalSize, ref rect4, ref num);
					num6++;
					if (rect3.IsEmpty)
					{
						rect3 = rect4;
					}
					else
					{
						rect3.Union(rect4);
					}
					rect2.Union(rect4);
				}
			}
			if (this._recordsInViewChanged)
			{
				this._recordsInViewChanged = false;
				global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = base.ViewPanelInfo;
				if (viewPanelInfo != null)
				{
					viewPanelInfo.OnRecordsInViewChanged();
				}
			}
			base.OnArrangeComplete();
			return finalSize;
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x0006CC94 File Offset: 0x0006AE94
		internal override bool EnsureRecordIsVisible(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record == null)
			{
				throw new global::System.ArgumentNullException("record");
			}
			if (!base.CanRecordsBeScrolled)
			{
				return false;
			}
			if (base.ViewSettings == null)
			{
				return false;
			}
			if (record.VisibilityResolved == global::System.Windows.Visibility.Collapsed)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = record.ParentCollection.ViewableRecords;
			if (viewableRecords != null)
			{
				int count = viewableRecords.Count;
			}
			global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection records = this.Records;
			if (records.HasPendingNotifications)
			{
				base.InvalidateMeasure();
				base.UpdateLayout();
			}
			if (record.ParentDataRecord == null && record.IsFixed)
			{
				if (record.IsOnTopWhenFixed)
				{
					if (this._offsetWithinListForTopFixedRecords == 0)
					{
						return true;
					}
				}
				else if (this._offsetWithinListForBottomFixedRecords == 0)
				{
					return true;
				}
			}
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = base.ViewPanelInfo;
			if (viewPanelInfo == null)
			{
				return false;
			}
			if (record.ParentRecord != null && !record.ParentRecord.IsExpanded)
			{
				if (!viewPanelInfo.IsOkToScroll())
				{
					return false;
				}
				record.ParentRecord.IsExpanded = true;
				base.UpdateLayout();
			}
			if (this.IsRecordInView(record, false))
			{
				return true;
			}
			if (!viewPanelInfo.IsOkToScroll())
			{
				return false;
			}
			int scrollPositionOfRecord = records.GetScrollPositionOfRecord(record);
			if (scrollPositionOfRecord < 0)
			{
				return true;
			}
			int effectiveScrollPosition = this.EffectiveScrollPosition;
			if (scrollPositionOfRecord <= effectiveScrollPosition)
			{
				this.SetScrollPositionToRecord(record);
				base.InvalidateMeasure();
				base.UpdateLayout();
				return true;
			}
			int i = global::System.Math.Max(scrollPositionOfRecord - this._scrollableElementsFullyInView, effectiveScrollPosition + 1);
			int num = -1;
			while (i > effectiveScrollPosition)
			{
				this.SetScrollPosition(i);
				base.InvalidateMeasure();
				base.UpdateLayout();
				if (this.IsRecordInView(record, false))
				{
					return true;
				}
				scrollPositionOfRecord = records.GetScrollPositionOfRecord(record);
				int effectiveScrollPosition2 = this.EffectiveScrollPosition;
				if (effectiveScrollPosition2 >= scrollPositionOfRecord || num == effectiveScrollPosition2)
				{
					break;
				}
				num = effectiveScrollPosition2;
				i++;
			}
			return false;
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x0006CE1C File Offset: 0x0006B01C
		protected override bool GetCanCleanupItem(int itemIndex)
		{
			global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = base.RecordListControl;
			int count = recordListControl.Items.Count;
			if (itemIndex < 0 || itemIndex >= count)
			{
				return true;
			}
			global::Infragistics.Windows.DataPresenter.Record record = recordListControl.Items[itemIndex] as global::Infragistics.Windows.DataPresenter.Record;
			return record == null || (!record.IsFixed && !record.IsSpecialRecord && !this.IsRecordInView(record, true));
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x0006CE7C File Offset: 0x0006B07C
		internal override int GetScrollOffsetFromRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection records = this.Records;
			if (records == null)
			{
				return base.GetScrollOffsetFromRecord(record);
			}
			return records.GetScrollPositionOfRecord(record);
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x0006CEA4 File Offset: 0x0006B0A4
		internal override global::Infragistics.Windows.DataPresenter.Record GetTopRecordFromScrollOffset(int scrollOffset)
		{
			global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection records = this.Records;
			if (records == null)
			{
				return base.GetTopRecordFromScrollOffset(scrollOffset);
			}
			return records.GetRecordAtScrollPosition(scrollOffset);
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x0006CECC File Offset: 0x0006B0CC
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::Infragistics.Windows.DataPresenter.GridViewSettingsBase viewSettings = base.ViewSettings;
			if (viewSettings == null)
			{
				return new global::System.Windows.Size(1.0, 1.0);
			}
			global::System.Windows.Size size = availableSize;
			bool flag = this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical;
			if (this._isVertical != flag)
			{
				this._isVertical = flag;
				this._averageExtentPerRecord = 0.0;
				this._elementsUsedInAverageCalc = 0;
				base.GetGenerator().RemoveAll();
				base.RemoveAllDeactivatedContainers();
			}
			this._isInInfiniteContainer = false;
			if (double.IsInfinity(availableSize.Width))
			{
				this._widthInInfiniteContainer = this.WidthInfiniteContainersResolved;
				if (!flag)
				{
					this._isInInfiniteContainer = true;
				}
			}
			else
			{
				this._widthInInfiniteContainer = 0.0;
			}
			if (double.IsInfinity(availableSize.Height))
			{
				this._heightInInfiniteContainer = this.HeightInfiniteContainersResolved;
				if (flag)
				{
					this._isInInfiniteContainer = true;
				}
			}
			else
			{
				this._heightInInfiniteContainer = 0.0;
			}
			double width = double.IsInfinity(availableSize.Width) ? this.WidthInfiniteContainersResolved : availableSize.Width;
			double height = double.IsInfinity(availableSize.Height) ? this.HeightInfiniteContainersResolved : availableSize.Height;
			global::System.Windows.Size constraint = new global::System.Windows.Size(width, height);
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = base.ViewPanelInfo;
			global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection records = this.Records;
			if (records == null)
			{
				return new global::System.Windows.Size(1.0, 1.0);
			}
			int count = records.Count;
			int num = (base.RecordListControl != null && base.RecordListControl.HasItems) ? base.RecordListControl.Items.Count : 0;
			if (num > 0)
			{
				global::Infragistics.Windows.DataPresenter.Record record = records[0];
				num = records.Count;
			}
			global::System.Windows.Size size2 = default(global::System.Windows.Size);
			bool flag2 = true;
			bool flag3 = true;
			int offsetWithinListForTopFixedRecords = this._offsetWithinListForTopFixedRecords;
			int offsetWithinListForBottomFixedRecords = this._offsetWithinListForBottomFixedRecords;
			int offsetWithinListForScrollableRecords = this._offsetWithinListForScrollableRecords;
			int scrollableElementsInView = this._scrollableElementsInView;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			global::Infragistics.Windows.Selection.ScrollDirection scrollDirection = global::Infragistics.Windows.Selection.ScrollDirection.Increment;
			bool flag4 = false;
			bool flag5 = false;
			global::Infragistics.Windows.DataPresenter.Record record2 = null;
			double num7 = 0.0;
			int num8 = 0;
			bool flag6 = false;
			global::Infragistics.Windows.DataPresenter.GridViewPanelFlat.GenerationCache generationCache = null;
			this._isInMeasure = true;
			double horizontalScrollBarHeight = global::System.Windows.SystemParameters.HorizontalScrollBarHeight;
			while (!flag4)
			{
				if (!flag5)
				{
					num2 = records.CountOfNonHeaderRecords;
					num3 = records.CountOfFixedRecordsOnTop;
					num4 = records.CountOfFixedRecordsOnBottom;
					num5 = num2 - (num4 + num3);
					num6 = this.EffectiveScrollPosition;
					if (num > 0)
					{
						global::Infragistics.Windows.DataPresenter.Record record3 = this.GetTopRecordFromScrollOffset(num6);
						if (record3 != null && num6 == this._lastOverallScrollPosition && num6 > 0 && base.DataPresenter != null && base.DataPresenter.ScrollBehaviorOnListChange == global::Infragistics.Windows.DataPresenter.ScrollBehaviorOnListChange.Default && record3 != this._lastRecordAtOverallScrollPosition && this._lastRecordAtOverallScrollPosition != null && this._lastRecordAtOverallScrollPosition.IsStillValid)
						{
							int scrollOffsetFromRecord = this.GetScrollOffsetFromRecord(this._lastRecordAtOverallScrollPosition);
							if (scrollOffsetFromRecord != -1 && scrollOffsetFromRecord != this._lastOverallScrollPosition)
							{
								record3 = this._lastRecordAtOverallScrollPosition;
								num6 = scrollOffsetFromRecord;
								viewPanelInfo.OverallScrollPosition = num6;
							}
						}
						this._lastRecordAtOverallScrollPosition = record3;
					}
					scrollDirection = ((num6 < this._lastMeasureScrollPosition) ? global::Infragistics.Windows.Selection.ScrollDirection.Decrement : global::Infragistics.Windows.Selection.ScrollDirection.Increment);
					this._lastMeasureScrollPosition = num6;
					num8 = num6;
				}
				global::Infragistics.Windows.DataPresenter.GridViewPanelFlat.GenerationCache generationCache2;
				generationCache = (generationCache2 = new global::Infragistics.Windows.DataPresenter.GridViewPanelFlat.GenerationCache(this, flag, constraint, num8, scrollDirection));
				try
				{
					flag4 = generationCache.GenerateAllRecords();
					num7 = generationCache._extentRemaining;
					num8 = generationCache._currentScrollPosition;
					this._averageExtentPerRecord = generationCache._averageExtentPerRecord;
					this._elementsUsedInAverageCalc = generationCache._elementsUsedInAverageCalc;
				}
				finally
				{
					if (generationCache2 != null)
					{
						((global::System.IDisposable)generationCache2).Dispose();
					}
				}
				if (!flag4)
				{
					flag6 = false;
					flag5 = false;
					this._isLastScrollableRecordFullyInView = false;
				}
				else
				{
					if (!flag5)
					{
						flag5 = true;
						this._isLastScrollableRecordFullyInView = false;
						record2 = generationCache._highestScrollableRecordFullyInView;
						if (num7 > 0.0 && !viewSettings.AllowLastRecordScrollToTop)
						{
							if (record2 != null)
							{
								this._isLastScrollableRecordFullyInView = true;
							}
							if (num8 > 0)
							{
								flag4 = false;
								num8 = global::System.Math.Max(num8 - (int)global::System.Math.Max(num7 / (2.0 * global::System.Math.Max(15.0, this._averageExtentPerRecord)), 1.0), 0);
								scrollDirection = global::Infragistics.Windows.Selection.ScrollDirection.Decrement;
								continue;
							}
						}
					}
					else
					{
						if (record2 != null && record2 != generationCache._highestScrollableRecordFullyInView && num8 < records.CountOfNonHeaderRecords - 1 && generationCache._scrollableElementsFullyInView >= 0)
						{
							flag6 = true;
							flag4 = false;
							num8 = global::System.Math.Min(records.CountOfNonHeaderRecords - 1, num8 + 1);
							scrollDirection = global::Infragistics.Windows.Selection.ScrollDirection.Increment;
							continue;
						}
						if (!global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(0.0, num7))
						{
							if (num7 > 0.0)
							{
								if (num7 > horizontalScrollBarHeight && !flag6 && num8 > 0)
								{
									flag4 = false;
									num8 = global::System.Math.Max(num8 - (int)global::System.Math.Max(num7 / (2.0 * global::System.Math.Max(15.0, this._averageExtentPerRecord)), 1.0), 0);
									scrollDirection = global::Infragistics.Windows.Selection.ScrollDirection.Decrement;
									continue;
								}
							}
							else if (num8 < records.CountOfNonHeaderRecords - 1)
							{
								flag6 = true;
								flag4 = false;
								num8 = global::System.Math.Min(records.CountOfNonHeaderRecords - 1, num8 + 1);
								scrollDirection = global::Infragistics.Windows.Selection.ScrollDirection.Increment;
								continue;
							}
						}
					}
					if (num8 == 0)
					{
						this.EffectiveScrollPosition = 0;
					}
					else if (num8 < this.EffectiveScrollPosition - 1)
					{
						this.EffectiveScrollPosition = num8 + 1;
					}
					num6 = this.EffectiveScrollPosition;
					this._bottomFixedElementsGenerated = generationCache._bottomFixedElementsGenerated;
					this._headerElementsGenerated = generationCache._headerElementsGenerated;
					this._topFixedElementsGenerated = generationCache._topFixedElementsGenerated;
					this._scrollableElementsGenerated = generationCache._scrollableElementsGenerated;
					this._scrollableElementsFullyInView = generationCache._scrollableElementsFullyInView;
					this._scrollableElementsInView = generationCache._scrollableElementsInView;
					this._extentUsedByScrollableRecords = generationCache._extentScrollable;
					this._extentUsedByFixedRecordsOnBottom = generationCache._extentBottomFixed;
					this._extentUsedByFixedRecordsOnTop = generationCache._extentTopFixed;
					this._generatedElements = generationCache._generatedElements;
					if (this._generatedElements != null)
					{
						this._generatedElements.TrimExcess();
					}
					if (generationCache._highestScrollableRecordFullyInView != null)
					{
						this._scrollPositionOfLastVisibleRecord = viewPanelInfo.GetOverallScrollPositionForRecord(generationCache._highestScrollableRecordFullyInView);
					}
					else if (generationCache._highestScrollableRecordInView != null)
					{
						this._scrollPositionOfLastVisibleRecord = viewPanelInfo.GetOverallScrollPositionForRecord(generationCache._highestScrollableRecordInView);
					}
					else
					{
						this._scrollPositionOfLastVisibleRecord = num8;
					}
				}
			}
			this._desiredHeightMap.Clear();
			if (this._generatedElements != null)
			{
				foreach (global::System.Windows.UIElement uielement in this._generatedElements)
				{
					this._desiredHeightMap.Add(uielement, uielement.DesiredSize.Height);
				}
			}
			if (offsetWithinListForTopFixedRecords != this._offsetWithinListForTopFixedRecords || offsetWithinListForBottomFixedRecords != this._offsetWithinListForBottomFixedRecords || offsetWithinListForScrollableRecords != this._offsetWithinListForScrollableRecords || scrollableElementsInView != this._scrollableElementsInView)
			{
				this._recordsInViewChanged = true;
			}
			this._lastOrientationWasVertical = flag;
			if (flag)
			{
				size2.Width = generationCache._extentNonPrimary;
			}
			else
			{
				size2.Height = generationCache._extentNonPrimary;
			}
			if (base.IsScrolling)
			{
				global::System.Windows.Vector offset = base.ScrollingData._offset;
				global::System.Windows.Size size3 = availableSize;
				global::System.Windows.Size extent = size2;
				int num9 = global::System.Math.Max(1, this._scrollableElementsFullyInView);
				bool flag7;
				if (flag)
				{
					flag7 = (size2.Height > constraint.Height);
				}
				else
				{
					flag7 = (size2.Width > constraint.Width);
				}
				if (flag)
				{
					size2.Height = global::System.Math.Min(size2.Height, constraint.Height);
				}
				else
				{
					size2.Width = global::System.Math.Min(size2.Width, constraint.Width);
				}
				if (!flag3)
				{
					num5 = num2 - (num3 + num4);
					num5 += num4;
					num9 += num4 - this._offsetWithinListForBottomFixedRecords;
					if (!flag2)
					{
						num5 += num3;
						num9 += num3 - this._offsetWithinListForTopFixedRecords;
					}
				}
				if (num5 > num9 || (flag3 && (flag7 || num8 > 0)))
				{
					num5 = num2 - (num3 + num4);
					if (num5 == num9)
					{
						num9--;
					}
				}
				num9 = global::System.Math.Max(1, num9);
				int num10 = global::System.Math.Max(1, num5);
				int overallScrollCount = viewPanelInfo.OverallScrollCount;
				if (overallScrollCount > num10)
				{
					num10 = global::System.Math.Max(num10, global::System.Math.Min(overallScrollCount, overallScrollCount + num10 - num2));
				}
				if (flag)
				{
					size3.Height = (double)num9;
					extent.Height = (double)num10;
					offset.Y = (double)num8;
					size3.Width = global::System.Math.Min(size3.Width, extent.Width);
				}
				else
				{
					size3.Width = (double)num9;
					extent.Width = (double)num10;
					offset.X = (double)num8;
					size3.Height = global::System.Math.Min(size3.Height, extent.Height);
				}
				double num11 = flag ? base.ScrollingData._offset.Y : base.ScrollingData._offset.X;
				if ((double)num10 <= (double)num9 + num11 && num7 == 0.0 && record2 != null)
				{
					this._isLastScrollableRecordFullyInView = true;
				}
				global::System.Windows.Size availableScrollSize = size3;
				double num12 = generationCache._extentBottomFixed;
				if (generationCache._extentTopFixed > 0.0)
				{
					num12 += generationCache._extentTopFixed;
				}
				else
				{
					num12 += generationCache._extentRootHeader;
				}
				double num13 = global::System.Math.Max(generationCache._extentOverall - num12, 1.0);
				if (flag)
				{
					availableScrollSize.Height = num13;
				}
				else
				{
					availableScrollSize.Width = num13;
				}
				this.VerifyScrollData(extent, size3, offset, availableScrollSize);
				if (this._isInInfiniteContainer)
				{
					if (flag && offset.X > 0.0001)
					{
						size2.Width = global::System.Math.Max(this._widthInInfiniteContainer, size2.Width);
					}
					this._widthInInfiniteContainer = size2.Width;
				}
				if (this._heightInInfiniteContainer > 1.0)
				{
					if (offset.Y > 0.0001)
					{
						size2.Height = global::System.Math.Max(this._heightInInfiniteContainer, size2.Height);
					}
					this._heightInInfiniteContainer = size2.Height;
				}
			}
			this.SetBoundaryRecordFlags();
			size2.Width = global::System.Math.Max(size2.Width, 1.0);
			size2.Height = global::System.Math.Max(size2.Height, 1.0);
			double num14 = this._extentUsedByFixedRecordsOnTop + this._extentUsedByFixedRecordsOnBottom + this._extentUsedByScrollableRecords;
			if (flag)
			{
				if (!double.IsInfinity(size.Height) && num6 > 0)
				{
					size2.Height = size.Height;
				}
				else
				{
					size2.Height = num14;
				}
				if (!double.IsInfinity(size.Height))
				{
					size2.Height = global::System.Math.Min(size2.Height, size.Height);
				}
			}
			else
			{
				if (!double.IsInfinity(size.Width) && num6 > 0)
				{
					size2.Width = size.Width;
				}
				else
				{
					size2.Width = num14;
				}
				if (!double.IsInfinity(size.Width))
				{
					size2.Width = global::System.Math.Min(size2.Width, size.Width);
				}
			}
			this._isInMeasure = false;
			return size2;
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x0006D988 File Offset: 0x0006BB88
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			if (child.Visibility == global::System.Windows.Visibility.Collapsed)
			{
				return;
			}
			double num;
			if (this._desiredHeightMap.TryGetValue(child, out num) && child.DesiredSize.Height == num)
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(child);
				if (recordPresenterFromContainer != null)
				{
					if (recordPresenterFromContainer is global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter)
					{
						return;
					}
					if (recordPresenterFromContainer is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter && this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
					{
						return;
					}
				}
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (this._isInMeasure || (dataPresenter != null && dataPresenter.IsSynchronousControl))
			{
				base.OnChildDesiredSizeChanged(child);
				return;
			}
			if (!base.IsHidingRecord && child.Visibility != global::System.Windows.Visibility.Collapsed)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.InvalidateMeasureAsynch(this);
			}
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x0006DA20 File Offset: 0x0006BC20
		protected override void OnClearChildren()
		{
			if (this._generatedElements != null)
			{
				int num = (this._generatedElements.Count + 1) * 2 / 3;
				if (this._elementsUsedInAverageCalc > num)
				{
					this._elementsUsedInAverageCalc = global::System.Math.Max(2, num);
				}
			}
			base.OnClearChildren();
			this._bottomFixedElementsGenerated = 0;
			this._extentUsedByFixedRecordsOnBottom = 0.0;
			this._extentUsedByFixedRecordsOnTop = 0.0;
			this._extentUsedByScrollableRecords = 0.0;
			this._headerElementsGenerated = 0;
			this._isLastScrollableRecordFullyInView = false;
			this._lastMeasureScrollPosition = 0;
			this._lastOverallScrollPosition = 0;
			this._lastRecordAtOverallScrollPosition = null;
			this._offsetWithinListForBottomFixedRecords = 0;
			this._offsetWithinListForScrollableRecords = 0;
			this._offsetWithinListForTopFixedRecords = 0;
			this._scrollableElementsGenerated = 0;
			this._scrollPositionOfLastVisibleRecord = 0;
			this._topFixedElementsGenerated = 0;
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x0006DAE4 File Offset: 0x0006BCE4
		internal override void OnDeferredRecordScrollStart()
		{
			global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection records = this.Records;
			if (records != null && records.HasPendingNotifications)
			{
				base.InvalidateMeasure();
				base.UpdateLayout();
			}
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x0006DB0F File Offset: 0x0006BD0F
		protected override void OnItemsChanged(object sender, global::System.Windows.Controls.Primitives.ItemsChangedEventArgs args)
		{
			base.OnItemsChanged(sender, args);
			this._recordsInViewChanged = true;
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x0006DB20 File Offset: 0x0006BD20
		protected override void OnVisualChildrenChanged(global::System.Windows.DependencyObject visualAdded, global::System.Windows.DependencyObject visualRemoved)
		{
			global::System.Windows.UIElement uielement = visualRemoved as global::System.Windows.UIElement;
			if (uielement != null)
			{
				this._desiredHeightMap.Remove(uielement);
			}
			base.OnVisualChildrenChanged(visualAdded, visualRemoved);
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x0006DB4C File Offset: 0x0006BD4C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("GridViewPanelFlat: ");
			if (base.DataPresenter != null)
			{
				stringBuilder.Append(base.DataPresenter);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x0006DB86 File Offset: 0x0006BD86
		internal override void SetBoundaryRecordFlags()
		{
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x0006DB88 File Offset: 0x0006BD88
		internal override void SetOffsetInternal(double newOffset, double oldOffset, bool isSettingVerticalOffset)
		{
			try
			{
				global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData scrollingData = base.ScrollingData;
				bool flag = this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical;
				bool flag2 = flag == isSettingVerticalOffset;
				if (!flag2)
				{
					newOffset = global::System.Math.Round(newOffset, 0, global::System.MidpointRounding.AwayFromZero);
				}
				double num;
				if (flag2)
				{
					num = 1.0;
				}
				else if (isSettingVerticalOffset)
				{
					num = scrollingData._viewport.Height;
				}
				else
				{
					num = scrollingData._viewport.Width;
				}
				double num2;
				if (isSettingVerticalOffset)
				{
					num2 = global::System.Math.Min(global::System.Math.Max(newOffset, 0.0), scrollingData._extent.Height - num);
				}
				else
				{
					num2 = global::System.Math.Min(global::System.Math.Max(newOffset, 0.0), scrollingData._extent.Width - num);
				}
				if (num2 < 0.0)
				{
					num2 = 0.0;
				}
				if (flag2 && !base.CanRecordsBeScrolled)
				{
					num2 = 0.0;
				}
				if (num2 != oldOffset)
				{
					if (!flag2 || num2 <= oldOffset || !this._isLastScrollableRecordFullyInView || scrollingData._isInDeferredDrag)
					{
						global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = base.ViewPanelInfo;
						if (viewPanelInfo != null)
						{
							if (viewPanelInfo.IsOkToScroll())
							{
								global::Infragistics.Windows.DataPresenter.Record record = null;
								if (flag2)
								{
									bool flag3 = !scrollingData._isInDeferredDrag || scrollingData._scrollTip != null;
									if (flag3)
									{
										record = this.GetTopRecordFromScrollOffset((int)num2);
									}
									if (scrollingData._isInDeferredDrag)
									{
										scrollingData.InitializeScrollTip(record);
										scrollingData._deferredDragOffset = num2;
										return;
									}
									if (num2 == (double)viewPanelInfo.OverallScrollPosition)
									{
										return;
									}
									this._recordsInViewChanged = true;
								}
								if (record != null)
								{
									global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection records = this.Records;
									if (records == null)
									{
										return;
									}
									num2 = global::System.Math.Max(global::System.Math.Min(num2, (double)(viewPanelInfo.OverallScrollCount - (1 + records.CountOfFixedRecordsOnTop + records.CountOfFixedRecordsOnBottom))), 0.0);
								}
								if (isSettingVerticalOffset)
								{
									if (scrollingData._offset.Y != num2)
									{
										scrollingData._hasOffsetChanged = true;
										scrollingData._offset.Y = num2;
									}
								}
								else if (scrollingData._offset.X != num2)
								{
									scrollingData._hasOffsetChanged = true;
									scrollingData._offset.X = num2;
								}
								if (record != null)
								{
									this._lastRecordAtOverallScrollPosition = record;
									this._lastOverallScrollPosition = (int)num2;
									viewPanelInfo.OverallScrollPosition = this._lastOverallScrollPosition;
								}
								base.VerifyFixedFieldInfo();
								base.OnScrollInfoChange();
								base.InvalidateMeasure();
							}
						}
					}
				}
			}
			finally
			{
				base.SetOffsetTriggeredByPageBack = false;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x0006DDE8 File Offset: 0x0006BFE8
		private global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection Records
		{
			get
			{
				return base.RecordListControl.ItemsSource as global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection;
			}
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x0006DDFC File Offset: 0x0006BFFC
		private double ArrangeHelper(global::System.Windows.UIElement visualChildElement, global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Record, global::System.Windows.UIElement> headerRecordMap, bool orientationIsVertical, bool isReverseLayoutForBottomFixed, double extentUsedByLastItem, double clipExtent, global::System.Windows.Size arrangeSize, ref global::System.Windows.Rect arrangeRect, ref double recordIndent)
		{
			bool flag = !double.IsInfinity(clipExtent);
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(visualChildElement);
			global::System.Windows.UIElement uielement = null;
			double num = recordIndent;
			recordIndent = 0.0;
			global::Infragistics.Windows.DataPresenter.Record record = null;
			if (recordPresenterFromContainer != null)
			{
				recordPresenterFromContainer.TreatAsCollapsed = false;
				if (recordPresenterFromContainer.ShouldDisplayRecordContent)
				{
					recordPresenterFromContainer.IsArrangedInView = true;
				}
				global::Infragistics.Windows.DataPresenter.Record record2 = recordPresenterFromContainer.Record;
				if (record2 != null)
				{
					record = record2;
					global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = record2 as global::Infragistics.Windows.DataPresenter.HeaderRecord;
					recordIndent = this.GetRecordIndent(record2);
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = null;
					if (headerRecord == null)
					{
						if (headerRecordMap != null && headerRecordMap.TryGetValue(record2, out uielement))
						{
							headerRecordMap.Remove(record2);
						}
						else
						{
							dataRecord = record2.ParentDataRecord;
							record = dataRecord;
						}
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.Record attachedToRecord = headerRecord.AttachedToRecord;
						if (attachedToRecord != null)
						{
							dataRecord = attachedToRecord.ParentDataRecord;
							if (headerRecordMap != null)
							{
								headerRecordMap.Remove(attachedToRecord);
							}
						}
					}
					if (dataRecord != null && this.DoesRecordHaveHeaderAndChildrenBeforeIt(dataRecord, dataRecord.FieldLayout.HeaderPlacementResolved))
					{
						bool flag2 = false;
						if (dataRecord.FieldLayout.ChildRecordsDisplayOrderResolved == global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.BeforeParent)
						{
							flag2 = true;
						}
						else if (dataRecord.FieldLayout.HeaderPlacementResolved != global::Infragistics.Windows.DataPresenter.HeaderPlacement.OnRecordBreak)
						{
							int visibleIndex = dataRecord.VisibleIndex;
							if (dataRecord.FieldLayout.HasGroupBySortFields && dataRecord.FieldLayout.HeaderPlacementInGroupByResolved == global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.OnTopOnly)
							{
								global::Infragistics.Windows.DataPresenter.GroupByRecord topLevelGroup = dataRecord.TopLevelGroup;
								if (topLevelGroup != null)
								{
									visibleIndex = topLevelGroup.VisibleIndex;
								}
							}
							if (visibleIndex != 0)
							{
								flag2 = true;
							}
						}
						if (flag2 && headerRecordMap != null && headerRecordMap.TryGetValue(dataRecord, out uielement))
						{
							headerRecordMap.Remove(dataRecord);
						}
					}
				}
			}
			bool flag3 = record is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord && record.AreChildrenAfterParent;
			if (record is global::Infragistics.Windows.DataPresenter.GroupByRecord && record.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout)
			{
				flag3 = true;
			}
			if (isReverseLayoutForBottomFixed)
			{
				flag3 = !flag3;
			}
			if (uielement != null && !flag3)
			{
				extentUsedByLastItem = this.ArrangeHelper(uielement, headerRecordMap, orientationIsVertical, isReverseLayoutForBottomFixed, extentUsedByLastItem, clipExtent, arrangeSize, ref arrangeRect, ref num);
				if (flag)
				{
					clipExtent -= extentUsedByLastItem;
				}
			}
			double num2 = recordIndent - num;
			if (orientationIsVertical)
			{
				arrangeRect.X += num2;
				arrangeRect.Height = visualChildElement.DesiredSize.Height;
				arrangeRect.Width = global::System.Math.Max(arrangeSize.Width - recordIndent, visualChildElement.DesiredSize.Width);
				if (isReverseLayoutForBottomFixed)
				{
					arrangeRect.Y -= arrangeRect.Height;
				}
				else
				{
					arrangeRect.Y += extentUsedByLastItem;
				}
				extentUsedByLastItem = arrangeRect.Height;
				if (global::Infragistics.Windows.Utilities.DoubleIsZero(arrangeRect.Y))
				{
					arrangeRect.Y = 0.0;
				}
			}
			else
			{
				arrangeRect.Y += num2;
				arrangeRect.Width = visualChildElement.DesiredSize.Width;
				arrangeRect.Height = global::System.Math.Max(arrangeSize.Height - recordIndent, visualChildElement.DesiredSize.Height);
				if (isReverseLayoutForBottomFixed)
				{
					arrangeRect.X -= arrangeRect.Width;
				}
				else
				{
					arrangeRect.X += extentUsedByLastItem;
				}
				extentUsedByLastItem = arrangeRect.Width;
				if (global::Infragistics.Windows.Utilities.DoubleIsZero(arrangeRect.X))
				{
					arrangeRect.X = 0.0;
				}
			}
			global::Infragistics.Windows.DataPresenter.GridViewPanel.SetRecordPresenterClip(orientationIsVertical, extentUsedByLastItem, clipExtent, arrangeRect, flag, recordPresenterFromContainer);
			visualChildElement.Arrange(arrangeRect);
			if (uielement != null && flag3)
			{
				num = recordIndent;
				global::System.Windows.Rect rect = arrangeRect;
				extentUsedByLastItem = this.ArrangeHelper(uielement, headerRecordMap, orientationIsVertical, isReverseLayoutForBottomFixed, extentUsedByLastItem, clipExtent, arrangeSize, ref arrangeRect, ref num);
				if (orientationIsVertical)
				{
					arrangeRect.X = rect.X;
				}
				else
				{
					arrangeRect.Y = rect.Y;
				}
			}
			return extentUsedByLastItem;
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x0006E188 File Offset: 0x0006C388
		internal bool DoesRecordHaveHeaderAndChildrenBeforeIt(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.HeaderPlacement headerPlacement)
		{
			return this.DoesRecordHaveHeaderAndChildrenBeforeIt(record, headerPlacement, null);
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x0006E1A8 File Offset: 0x0006C3A8
		internal virtual bool DoesRecordHaveHeaderAndChildrenBeforeIt(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.HeaderPlacement headerPlacement, int? visibleIndex)
		{
			if (!record.AreChildrenAfterParent && record.IsExpanded && record.HasVisibleChildren)
			{
				if (headerPlacement == global::Infragistics.Windows.DataPresenter.HeaderPlacement.OnRecordBreak)
				{
					return true;
				}
				if (visibleIndex == null)
				{
					visibleIndex = new int?(record.VisibleIndex);
				}
				if (visibleIndex.Value == 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x0006E1F5 File Offset: 0x0006C3F5
		internal virtual double GetRecordIndent(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record == null)
			{
				return 0.0;
			}
			return record.CalculateFlatViewIndent();
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x0006E20C File Offset: 0x0006C40C
		private bool IsRecordInView(global::Infragistics.Windows.DataPresenter.Record record, bool allowPartiallyInView)
		{
			if (this._generatedElements == null)
			{
				return false;
			}
			global::System.Windows.UIElement uielement = null;
			foreach (global::System.Windows.UIElement uielement2 in this._generatedElements)
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(uielement2);
				if (recordPresenterFromContainer != null && recordPresenterFromContainer.Record == record)
				{
					uielement = uielement2;
					break;
				}
			}
			if (uielement == null)
			{
				return false;
			}
			global::System.Windows.Size desiredSize = uielement.DesiredSize;
			global::System.Windows.Controls.ScrollContentPresenter scrollContentPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::System.Windows.Controls.ScrollContentPresenter), true, base.DataPresenter) as global::System.Windows.Controls.ScrollContentPresenter;
			global::System.Windows.FrameworkElement frameworkElement = (scrollContentPresenter != null) ? scrollContentPresenter : this;
			double num = 0.0;
			double num2 = this._isVertical ? frameworkElement.ActualHeight : frameworkElement.ActualWidth;
			double num3;
			if (record.IsFixed && record.ParentRecord == null)
			{
				if (record.IsOnTopWhenFixed)
				{
					num3 = this._extentUsedByFixedRecordsOnTop;
				}
				else
				{
					num = num2 - this._extentUsedByFixedRecordsOnBottom;
					num3 = num2;
				}
			}
			else
			{
				num = this._extentUsedByFixedRecordsOnTop;
				num3 = num2 - this._extentUsedByFixedRecordsOnBottom;
			}
			global::System.Windows.Point point = uielement.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), this);
			global::System.Windows.Point point2 = uielement.TranslatePoint(new global::System.Windows.Point(desiredSize.Width, desiredSize.Height), this);
			double num4 = this._isVertical ? point.Y : point.X;
			double num5 = this._isVertical ? point2.Y : point2.X;
			if (allowPartiallyInView)
			{
				return num5 >= num || num4 <= num3;
			}
			return num4 >= num && num5 <= num3;
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x0006E3C0 File Offset: 0x0006C5C0
		private void SetScrollPosition(int newScrollPos)
		{
			if (this._isVertical)
			{
				base.SetVerticalOffset((double)newScrollPos);
				return;
			}
			base.SetHorizontalOffset((double)newScrollPos);
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x0006E3DC File Offset: 0x0006C5DC
		private void SetScrollPositionToRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			int scrollPositionOfRecord = this.Records.GetScrollPositionOfRecord(record);
			this.SetScrollPosition(global::System.Math.Max(0, scrollPositionOfRecord));
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0006E404 File Offset: 0x0006C604
		private void VerifyScrollData(global::System.Windows.Size extent, global::System.Windows.Size viewport, global::System.Windows.Vector offset, global::System.Windows.Size availableScrollSize)
		{
			global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData scrollingData = base.ScrollingData;
			scrollingData._availableScrollSize = availableScrollSize;
			if (this._recordsInViewChanged || scrollingData._hasOffsetChanged || scrollingData._extent != extent || scrollingData._viewport != viewport || scrollingData._offset != offset || scrollingData._isLastRecordInView != this._isLastScrollableRecordFullyInView)
			{
				scrollingData._hasOffsetChanged = false;
				bool flag = this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical;
				scrollingData._isLastRecordInView = this._isLastScrollableRecordFullyInView;
				scrollingData._extent = extent;
				scrollingData._viewport = viewport;
				scrollingData._offset = offset;
				scrollingData._viewportForScrollbar = viewport;
				scrollingData._extentForScrollbar = extent;
				double num;
				double num2;
				double num3;
				double num4;
				if (flag)
				{
					num = offset.Y;
					num2 = viewport.Height;
					num3 = extent.Height;
					num4 = availableScrollSize.Height;
				}
				else
				{
					num = offset.X;
					num2 = viewport.Width;
					num3 = extent.Width;
					num4 = availableScrollSize.Width;
				}
				scrollingData._averageHeightOfRecords = this._averageExtentPerRecord;
				if (num == 0.0)
				{
					scrollingData._highestRecordDisplayed = num2;
				}
				else
				{
					double num5 = num + num2 - 1.0;
					if (num5 > scrollingData._highestRecordDisplayed)
					{
						scrollingData._highestRecordDisplayed = num5;
					}
				}
				if (scrollingData._averageHeightOfRecords < 1.0)
				{
					scrollingData._averageHeightOfRecords = 1.0;
				}
				double num6 = global::System.Math.Max(global::System.Math.Ceiling(num4 / scrollingData._averageHeightOfRecords), 1.0);
				global::Infragistics.Windows.DataPresenter.GridViewSettingsBase viewSettings = base.ViewSettings;
				bool flag2 = viewSettings != null && viewSettings.AllowLastRecordScrollToTop;
				double num7 = num6;
				double num8 = flag ? scrollingData._extentForScrollbar.Height : scrollingData._extentForScrollbar.Width;
				double num9 = flag ? scrollingData._offset.Y : scrollingData._offset.X;
				double num10 = flag ? offset.Y : offset.X;
				if (flag2)
				{
					this._isLastScrollableRecordFullyInView = (num >= num3 - 1.0);
					if (num6 < num3)
					{
						num8 = global::System.Math.Max(num3 + num6 - 1.0, 0.0);
					}
					else
					{
						num8 = global::System.Math.Max(num3 + num3 - 1.0, 0.0);
					}
					if (num9 > 0.0)
					{
						num8 = global::System.Math.Max(num8, num7 + num9);
					}
				}
				else
				{
					if (num6 < num3)
					{
						num8 += global::System.Math.Min(global::System.Math.Min(1.0, num3 - num6), global::System.Math.Max(num6 - 1.0, 0.0));
					}
					if (this._isLastScrollableRecordFullyInView)
					{
						num8 = global::System.Math.Max(global::System.Math.Ceiling(global::System.Math.Max(num6, num7)) + num9, 1.0);
						num7 = global::System.Math.Max(num8 - num9, 1.0);
					}
					else if (num10 == 0.0 && num7 >= num8)
					{
						num7 = global::System.Math.Max(num8 - 1.0, 1.0);
					}
					else
					{
						num8 = global::System.Math.Max(1.0 + num10 + num7, num8);
					}
				}
				if (flag)
				{
					scrollingData._viewportForScrollbar.Height = num7;
					scrollingData._extentForScrollbar.Height = num8;
				}
				else
				{
					scrollingData._viewportForScrollbar.Width = num7;
					scrollingData._extentForScrollbar.Width = num8;
				}
				if (!base.CanRecordsBeScrolled)
				{
					if (flag)
					{
						if (base.DesiredSize.Height > 0.0)
						{
							scrollingData._offset.Y = 0.0;
							scrollingData._extent.Height = 1.0;
							scrollingData._extentForScrollbar.Height = 1.0;
							scrollingData._viewport.Height = 2.0;
							scrollingData._viewportForScrollbar.Height = 2.0;
						}
					}
					else if (base.DesiredSize.Width > 0.0)
					{
						scrollingData._offset.X = 0.0;
						scrollingData._extent.Width = 1.0;
						scrollingData._extentForScrollbar.Width = 1.0;
						scrollingData._viewport.Width = 2.0;
						scrollingData._viewportForScrollbar.Width = 2.0;
					}
				}
				base.VerifyFixedFieldInfo();
				base.OnScrollInfoChange();
			}
		}

		// Token: 0x0400097B RID: 2427
		private int _scrollPositionOfLastVisibleRecord;

		// Token: 0x0400097C RID: 2428
		private bool _isInInfiniteContainer;

		// Token: 0x0400097D RID: 2429
		private bool _recordsInViewChanged;

		// Token: 0x0400097E RID: 2430
		private bool _isInMeasure;

		// Token: 0x0400097F RID: 2431
		private int _bottomFixedElementsGenerated;

		// Token: 0x04000980 RID: 2432
		private int _headerElementsGenerated;

		// Token: 0x04000981 RID: 2433
		private int _scrollableElementsGenerated;

		// Token: 0x04000982 RID: 2434
		private int _scrollableElementsFullyInView;

		// Token: 0x04000983 RID: 2435
		private int _scrollableElementsInView;

		// Token: 0x04000984 RID: 2436
		private int _topFixedElementsGenerated;

		// Token: 0x04000985 RID: 2437
		private bool _lastOrientationWasVertical = true;

		// Token: 0x04000986 RID: 2438
		private int _lastOverallScrollPosition;

		// Token: 0x04000987 RID: 2439
		private int _lastMeasureScrollPosition;

		// Token: 0x04000988 RID: 2440
		private global::Infragistics.Windows.DataPresenter.Record _lastRecordAtOverallScrollPosition;

		// Token: 0x04000989 RID: 2441
		private double _extentUsedByFixedRecordsOnTop;

		// Token: 0x0400098A RID: 2442
		private double _extentUsedByFixedRecordsOnBottom;

		// Token: 0x0400098B RID: 2443
		private double _extentUsedByScrollableRecords;

		// Token: 0x0400098C RID: 2444
		private double _widthInInfiniteContainer;

		// Token: 0x0400098D RID: 2445
		private double _heightInInfiniteContainer;

		// Token: 0x0400098E RID: 2446
		private int _offsetWithinListForTopFixedRecords;

		// Token: 0x0400098F RID: 2447
		private int _offsetWithinListForBottomFixedRecords;

		// Token: 0x04000990 RID: 2448
		private int _offsetWithinListForScrollableRecords;

		// Token: 0x04000991 RID: 2449
		private double _averageExtentPerRecord;

		// Token: 0x04000992 RID: 2450
		private int _elementsUsedInAverageCalc;

		// Token: 0x04000993 RID: 2451
		private bool _isLastScrollableRecordFullyInView;

		// Token: 0x04000994 RID: 2452
		private bool _isVertical = true;

		// Token: 0x04000995 RID: 2453
		private global::System.Collections.Generic.Dictionary<global::System.Windows.UIElement, double> _desiredHeightMap = new global::System.Collections.Generic.Dictionary<global::System.Windows.UIElement, double>();

		// Token: 0x04000996 RID: 2454
		private global::System.Collections.Generic.List<global::System.Windows.UIElement> _generatedElements;

		// Token: 0x0200017B RID: 379
		internal class GenerationCache : global::System.IDisposable
		{
			// Token: 0x060017E4 RID: 6116 RVA: 0x0006E8A8 File Offset: 0x0006CAA8
			internal GenerationCache(global::Infragistics.Windows.DataPresenter.GridViewPanelFlat panel, bool isVertical, global::System.Windows.Size constraint, int overallScrollPosition, global::Infragistics.Windows.Selection.ScrollDirection scrollDirection)
			{
				this._panel = panel;
				this._records = panel.Records;
				this._isVertical = isVertical;
				this._constraint = constraint;
				this._currentScrollPosition = overallScrollPosition;
				this._dataPresenter = this._panel.DataPresenter;
				this._childElements = this._panel.ChildElements;
				this._childElementCount = this._childElements.Count;
				this._averageExtentPerRecord = this._panel._averageExtentPerRecord;
				this._elementsUsedInAverageCalc = this._panel._elementsUsedInAverageCalc;
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = panel.DataPresenter.CurrentViewInternal;
				this._isTreeView = (this._dataPresenter != null && this._dataPresenter.IsTreeView);
				if (this._isVertical)
				{
					this._measureConstraintAutoFit = new global::System.Windows.Size(double.PositiveInfinity, constraint.Height);
					this._extentOverall = constraint.Height;
				}
				else
				{
					this._measureConstraintAutoFit = new global::System.Windows.Size(constraint.Width, double.PositiveInfinity);
					this._extentOverall = constraint.Width;
				}
				if (double.IsInfinity(this._extentOverall))
				{
					this._extentOverall = double.MaxValue;
					this._currentScrollPosition = 0;
				}
				int val = global::System.Math.Max(0, this._records.CountOfNonHeaderRecords - (this._records.CountOfFixedRecordsOnTop + overallScrollPosition));
				this._estimatedRecordsToLayout = global::System.Math.Min(val, (int)global::System.Math.Max(this._extentOverall / global::System.Math.Max(15.0, this._averageExtentPerRecord), 2.0));
				this._extentRemaining = this._extentOverall;
				global::System.Collections.IEnumerable recordsExpectedToBeGenerated = this.GetRecordsExpectedToBeGenerated(scrollDirection);
				this._records.BeginMeasure(this);
				if (!this.IsResetPending)
				{
					this._panel.BeginGeneration(scrollDirection, recordsExpectedToBeGenerated);
					this._generator = this._panel.GetGenerator();
					this._fieldLayoutHeaderMap = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Windows.UIElement>();
					this._generatedElements = new global::System.Collections.Generic.List<global::System.Windows.UIElement>(global::System.Math.Max(100, this._estimatedRecordsToLayout * 2));
					int countOfFixedRecordsOnBottom = this._records.CountOfFixedRecordsOnBottom;
					if (countOfFixedRecordsOnBottom > 0)
					{
						this._generatedBottomFixedElements = new global::System.Collections.Generic.List<global::System.Windows.UIElement>(countOfFixedRecordsOnBottom + 1);
					}
				}
			}

			// Token: 0x1700063A RID: 1594
			// (get) Token: 0x060017E5 RID: 6117 RVA: 0x0006EADD File Offset: 0x0006CCDD
			internal bool IsResetPending
			{
				get
				{
					if (this._records.HasPendingNotifications)
					{
						this._isResetPending = true;
					}
					return this._isResetPending;
				}
			}

			// Token: 0x060017E6 RID: 6118 RVA: 0x0006EAFC File Offset: 0x0006CCFC
			internal bool GenerateAllRecords()
			{
				if (this.IsResetPending)
				{
					return false;
				}
				bool flag = this.GenerateTopFixedRecords();
				if (flag)
				{
					flag = this.GenerateBottomFixedRecords();
				}
				if (flag)
				{
					flag = this.GenerateScrollableRecords();
				}
				if (flag && this._lastHeaderFieldLayout == null && this._firstBottomFixedRecord != null)
				{
					this.GenerateHeader(this._firstBottomFixedRecord.FieldLayout, this._firstBottomFixedRecord);
				}
				if (this._recordsNeedingHeaders != null)
				{
					if (this._recordsNeedingHeaders.Count > 0 && this._headersWhichHaveElementsGenerated != null)
					{
						for (int i = 0; i < this._headersWhichHaveElementsGenerated.Count; i++)
						{
							global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = this._headersWhichHaveElementsGenerated[i];
							if (headerRecord.AttachedToRecord != null)
							{
								this._recordsNeedingHeaders.Remove(headerRecord.AttachedToRecord);
							}
						}
					}
					if (this._recordsNeedingHeaders.Count > 0)
					{
						foreach (global::Infragistics.Windows.DataPresenter.Record record in this._recordsNeedingHeaders.Keys)
						{
							this.GenerateHeader(record.FieldLayout, record);
						}
					}
				}
				if (this._generatedBottomFixedElements != null)
				{
					this._generatedElements.AddRange(this._generatedBottomFixedElements);
				}
				if (this._generatedHeaderElements != null)
				{
					this._generatedElements.AddRange(this._generatedHeaderElements);
				}
				return flag && !this.IsResetPending;
			}

			// Token: 0x060017E7 RID: 6119 RVA: 0x0006EC58 File Offset: 0x0006CE58
			private void CacheCurrentRecordSettings(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.FieldLayout fl)
			{
				this._currentVrc = record.ParentCollection.ViewableRecords;
				this._currentRecordManager = this._currentVrc.RecordManager;
				this._currentFieldLayout = fl;
				this._currentHeaderPlacement = fl.HeaderPlacementResolved;
				this._currentLabelLocation = fl.LabelLocationResolved;
				this._currentFieldLayoutHasGroups = fl.HasGroupBySortFields;
				this._currentRecordNestingDepth = record.NestingDepth;
				if (this._currentFieldLayoutHasGroups)
				{
					this._currentHeaderPlacementInGroupBy = fl.HeaderPlacementInGroupByResolved;
				}
			}

			// Token: 0x060017E8 RID: 6120 RVA: 0x0006ECD4 File Offset: 0x0006CED4
			private bool GenerateBottomFixedRecords()
			{
				this._currentPhase = global::Infragistics.Windows.DataPresenter.GridViewPanelFlat.GenerationCache.RecordGenerationPhase.BottomFixed;
				this._recordsToGenerate = this._records.CountOfFixedRecordsOnBottom;
				if (this._recordsToGenerate > 0)
				{
					this._nextIndexToGen = this._records.CountOfNonHeaderRecords - this._recordsToGenerate;
					this.GenerateRecordsHelper();
				}
				return !this.IsResetPending;
			}

			// Token: 0x060017E9 RID: 6121 RVA: 0x0006ED2C File Offset: 0x0006CF2C
			private global::System.Windows.UIElement GenerateHeader(global::Infragistics.Windows.DataPresenter.FieldLayout fl, global::Infragistics.Windows.DataPresenter.Record attachedToRecord)
			{
				if (fl == null || this.IsResetPending || fl.LabelLocationResolved != global::Infragistics.Windows.DataPresenter.LabelLocation.SeparateHeader)
				{
					return null;
				}
				if (this._isTreeView && this._generatedHeaderElements != null && this._generatedHeaderElements.Count == 1)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord;
				int nextHeaderRecord = this._records.GetNextHeaderRecord(fl, out headerRecord);
				if (headerRecord == null || nextHeaderRecord < 0)
				{
					return null;
				}
				headerRecord.AttachedToRecord = attachedToRecord;
				if (attachedToRecord != null)
				{
					headerRecord.AttachedNestingDepth = attachedToRecord.NestingDepth;
				}
				int nextIndexToGen = this._nextIndexToGen;
				global::System.Windows.UIElement result;
				try
				{
					this._nextIndexToGen = nextHeaderRecord;
					global::System.Windows.UIElement uielement = this.GenerateNextElement(true);
					if (uielement != null)
					{
						if (!this._generatingAncestorHeaders)
						{
							if (this._generatedHeaderElements == null)
							{
								this._generatedHeaderElements = new global::System.Collections.Generic.List<global::System.Windows.UIElement>();
							}
							this._generatedHeaderElements.Add(uielement);
						}
						this._fieldLayoutHeaderMap[fl] = uielement;
						if (attachedToRecord != null)
						{
							if (global::Infragistics.Windows.DataPresenter.GridViewPanelFlat.GenerationCache.IsHeaderOnTopOfGroupBys(attachedToRecord))
							{
								if (this._headersOnTopOfGroupBys == null)
								{
									this._headersOnTopOfGroupBys = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordManager, global::Infragistics.Windows.DataPresenter.FieldLayout>();
								}
								this._headersOnTopOfGroupBys[this._currentRecordManager] = fl;
							}
							if (this._extentRootHeader < 1.0 && attachedToRecord.ParentDataRecord == null)
							{
								this._extentRootHeader = (this._isVertical ? uielement.DesiredSize.Height : uielement.DesiredSize.Width);
							}
						}
						headerRecord.AttachedToRecordPrevious = attachedToRecord;
					}
					result = uielement;
				}
				finally
				{
					this._nextIndexToGen = nextIndexToGen;
				}
				return result;
			}

			// Token: 0x060017EA RID: 6122 RVA: 0x0006EE8C File Offset: 0x0006D08C
			private global::System.Windows.UIElement GenerateNextElement(bool isHeader)
			{
				if (this._currentGeneratorStart == null || this._currentGeneratorPositionIndex != this._nextIndexToGen)
				{
					this.StartGenerator();
				}
				bool flag;
				global::System.Windows.UIElement uielement = this._generator.GenerateNext(out flag) as global::System.Windows.UIElement;
				int nextIndexToGen = this._nextIndexToGen;
				this._currentGeneratorPositionIndex++;
				this._nextIndexToGen++;
				if (uielement == null)
				{
					return null;
				}
				if (flag)
				{
					if (this._nextChildElementIndex < 0)
					{
						this._nextChildElementIndex = this._panel.FindSlotForNewlyRealizedRecordPresenter(nextIndexToGen);
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
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(uielement);
				if (recordPresenterFromContainer != null)
				{
					global::Infragistics.Windows.DataPresenter.Record record = recordPresenterFromContainer.Record;
					if (record == null || record.VisibilityResolved == global::System.Windows.Visibility.Collapsed)
					{
						return uielement;
					}
					bool flag2 = recordPresenterFromContainer.Orientation == global::System.Windows.Controls.Orientation.Vertical;
					global::Infragistics.Windows.DataPresenter.FieldLayout currentFieldLayout = this._currentFieldLayout;
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = record.FieldLayout;
					if (currentFieldLayout == null || !isHeader)
					{
						this.CacheCurrentRecordSettings(record, fieldLayout);
					}
					if (!flag && record.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.SummaryRecord)
					{
						global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter.BumpVersion(recordPresenterFromContainer);
					}
					if (isHeader && !flag)
					{
						global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = record as global::Infragistics.Windows.DataPresenter.HeaderRecord;
						if (headerRecord != null)
						{
							global::System.Windows.Visibility expansionIndicatorVisibility = headerRecord.ExpansionIndicatorVisibility;
						}
						if (headerRecord != null && headerRecord.AttachedToRecord != headerRecord.AttachedToRecordPrevious)
						{
							global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter.BumpVersion(recordPresenterFromContainer);
							global::System.Windows.FrameworkElement headerContentSite = recordPresenterFromContainer.GetHeaderContentSite();
							if (headerContentSite != null)
							{
								global::Infragistics.Windows.DataPresenter.HeaderLabelArea headerLabelArea = global::Infragistics.Windows.Utilities.GetDescendantFromType(headerContentSite, typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea), true) as global::Infragistics.Windows.DataPresenter.HeaderLabelArea;
								if (headerLabelArea != null)
								{
									global::System.Windows.Controls.DockPanel dockPanel = global::Infragistics.Windows.Utilities.GetParent(headerLabelArea) as global::System.Windows.Controls.DockPanel;
									if (dockPanel != null)
									{
										global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter.BumpVersion(dockPanel);
									}
									else
									{
										global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter.BumpVersion(headerLabelArea);
									}
								}
							}
						}
					}
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = null;
					if (!isHeader && this._currentPhase != global::Infragistics.Windows.DataPresenter.GridViewPanelFlat.GenerationCache.RecordGenerationPhase.BottomFixed && this._currentLabelLocation == global::Infragistics.Windows.DataPresenter.LabelLocation.SeparateHeader)
					{
						global::Infragistics.Windows.DataPresenter.RecordType recordType = record.RecordType;
						switch (recordType)
						{
						case global::Infragistics.Windows.DataPresenter.RecordType.SummaryRecord:
						case global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord:
						{
							global::Infragistics.Windows.DataPresenter.RecordType recordType2 = recordType;
							if (this._currentRecordManager != null && this._currentRecordManager.HasGroups)
							{
								recordType2 = this._currentRecordManager.Groups[0].RecordType;
							}
							switch (recordType2)
							{
							case global::Infragistics.Windows.DataPresenter.RecordType.GroupByField:
							case global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout:
								if (recordType != global::Infragistics.Windows.DataPresenter.RecordType.SummaryRecord || record.NestingDepthOfGroupByRcds != fieldLayout.SortedFields.CountOfGroupByFields)
								{
									recordType = global::Infragistics.Windows.DataPresenter.RecordType.GroupByField;
								}
								break;
							case global::Infragistics.Windows.DataPresenter.RecordType.SummaryRecord:
							case global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord:
								if (record.FieldLayout.ChildRecordsDisplayOrderResolved == global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.BeforeParentHeadersAttached && record.VisibleIndex == 0)
								{
									global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = record.ParentCollection.ViewableRecords;
									if (viewableRecords != null && viewableRecords.CountOfFixedRecordsOnTop == 0 && viewableRecords.RecordCollectionSparseArray.VisibleCount > 0)
									{
										global::Infragistics.Windows.DataPresenter.Record itemAtVisibleIndex = viewableRecords.RecordCollectionSparseArray.GetItemAtVisibleIndex(0);
										if (this._panel.DoesRecordHaveHeaderAndChildrenBeforeIt(itemAtVisibleIndex, this._currentHeaderPlacement, new int?(0)) && this.ShouldShowHeaderOnFirstRecordInIsland(fieldLayout, this._currentRecordManager, this._currentHeaderPlacementInGroupBy, this._currentFieldLayoutHasGroups))
										{
											fieldLayout2 = fieldLayout;
										}
									}
								}
								break;
							}
							break;
						}
						}
						switch (recordType)
						{
						case global::Infragistics.Windows.DataPresenter.RecordType.DataRecord:
						case global::Infragistics.Windows.DataPresenter.RecordType.SummaryRecord:
						case global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord:
							if (this._lastHeaderFieldLayout == null || this._previousRecord == null || (this._previousRecord is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord && this._previousRecord == record.ParentRecord))
							{
								fieldLayout2 = fieldLayout;
							}
							else if (this._panel.DoesRecordHaveHeaderAndChildrenBeforeIt(record, this._currentHeaderPlacement) && this.ShouldShowHeaderOnFirstRecordInIsland(fieldLayout, this._currentRecordManager, this._currentHeaderPlacementInGroupBy, this._currentFieldLayoutHasGroups))
							{
								fieldLayout2 = fieldLayout;
							}
							else if (this._previousRecord.NestingDepth < record.NestingDepth)
							{
								if (this.ShouldShowHeaderOnFirstRecordInIsland(fieldLayout, this._currentRecordManager, this._currentHeaderPlacementInGroupBy, this._currentFieldLayoutHasGroups))
								{
									fieldLayout2 = fieldLayout;
								}
							}
							else if (this._previousRecord.FieldLayout != fieldLayout && this._previousRecord.NestingDepth == record.NestingDepth)
							{
								fieldLayout2 = fieldLayout;
							}
							else if (this._currentHeaderPlacement == global::Infragistics.Windows.DataPresenter.HeaderPlacement.OnRecordBreak && this._previousRecord.ParentRecord != record.ParentRecord)
							{
								fieldLayout2 = fieldLayout;
							}
							break;
						case global::Infragistics.Windows.DataPresenter.RecordType.GroupByField:
						{
							global::Infragistics.Windows.DataPresenter.Record parentRecord = record.ParentRecord;
							if ((this._currentHeaderPlacementInGroupBy == global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.OnTopOnly || record.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord || record.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.SummaryRecord) && (this._lastHeaderFieldLayout == null || this._lastHeaderVrc != this._currentVrc || parentRecord == null || parentRecord.RecordType != global::Infragistics.Windows.DataPresenter.RecordType.GroupByField) && (this._lastHeaderFieldLayout != this._currentFieldLayout || this._lastHeaderVrc != this._currentVrc) && !this.IsGroupByHeaderAlreadyDisplayed(fieldLayout))
							{
								fieldLayout2 = fieldLayout;
							}
							break;
						}
						case global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout:
						{
							global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = record as global::Infragistics.Windows.DataPresenter.GroupByRecord;
							if (groupByRecord != null && groupByRecord.IsExpanded && groupByRecord.ScrollCountInternal == 1)
							{
								fieldLayout2 = groupByRecord.FieldLayout;
							}
							break;
						}
						case global::Infragistics.Windows.DataPresenter.RecordType.ExpandableFieldRecord:
						{
							global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = record as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
							if (expandableFieldRecord != null && expandableFieldRecord.IsExpanded)
							{
								global::Infragistics.Windows.DataPresenter.RecordManager childRecordManagerIfNeeded = expandableFieldRecord.ChildRecordManagerIfNeeded;
								if (childRecordManagerIfNeeded != null)
								{
									global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords2 = childRecordManagerIfNeeded.ViewableRecords;
									if (viewableRecords2 != null && viewableRecords2.Count == 0 && childRecordManagerIfNeeded.Unsorted.Count > 0)
									{
										fieldLayout2 = childRecordManagerIfNeeded.Unsorted[0].FieldLayout;
									}
								}
							}
							break;
						}
						}
					}
					if (!isHeader)
					{
						this._previousRecord = record;
					}
					if (fieldLayout2 != null && !this.IsResetPending)
					{
						this._lastHeaderFieldLayout = fieldLayout2;
						this._lastHeaderVrc = this._currentVrc;
						if (this.GenerateHeader(fieldLayout2, record) != null)
						{
							fieldLayout2 = null;
						}
						else if (this._isTreeView)
						{
							fieldLayout2 = null;
						}
					}
					else
					{
						fieldLayout2 = null;
					}
					if (!isHeader)
					{
						for (global::Infragistics.Windows.DataPresenter.Record parentRecord2 = record.ParentRecord; parentRecord2 != null; parentRecord2 = parentRecord2.ParentRecord)
						{
							if (parentRecord2 is global::Infragistics.Windows.DataPresenter.DataRecord && this._panel.DoesRecordHaveHeaderAndChildrenBeforeIt(parentRecord2, parentRecord2.FieldLayout.HeaderPlacementResolved) && this.ShouldShowHeaderOnFirstRecordInIsland(parentRecord2.FieldLayout, parentRecord2.RecordManager, parentRecord2.FieldLayout.HeaderPlacementInGroupByResolved, parentRecord2.FieldLayout.HasGroupBySortFields))
							{
								if (this._recordsNeedingHeaders == null)
								{
									this._recordsNeedingHeaders = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Record, object>();
								}
								this._recordsNeedingHeaders[parentRecord2] = null;
							}
						}
					}
					recordPresenterFromContainer.InitializeHeaderContent(isHeader || fieldLayout2 != null);
					recordPresenterFromContainer.TreatAsCollapsed = false;
					recordPresenterFromContainer.IsArrangedInView = true;
					recordPresenterFromContainer.IsActiveHeaderRecord = isHeader;
					recordPresenterFromContainer.InitializeRecordContentVisibility(!isHeader);
					recordPresenterFromContainer.InitializeExpandableRecordContentVisibility(!isHeader);
					recordPresenterFromContainer.InitializeGroupByRecordContentVisibility(!isHeader);
					if (!(recordPresenterFromContainer is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter))
					{
						recordPresenterFromContainer.InitializeNestedContent(null);
					}
					if (!flag && !isHeader)
					{
						recordPresenterFromContainer.InitializeIsAlternate(true);
					}
					if (!isHeader && this._currentPhase != global::Infragistics.Windows.DataPresenter.GridViewPanelFlat.GenerationCache.RecordGenerationPhase.BottomFixed)
					{
						this._highestScrollPosition = global::System.Math.Max(this._highestScrollPosition, recordPresenterFromContainer.Record.OverallScrollPosition);
					}
					if (!flag && flag2 != this._isVertical)
					{
						uielement.InvalidateMeasure();
					}
					bool flag3 = fieldLayout != null && (this._isVertical ? fieldLayout.IsAutoFitWidth : fieldLayout.IsAutoFitHeight);
					if (flag3)
					{
						uielement.Measure(this._measureConstraintAutoFit);
					}
					else
					{
						uielement.Measure(this._measureConstraint);
					}
					global::System.Windows.Size desiredSize = uielement.DesiredSize;
					double num = (record != null) ? record.LastLayoutExtent : 0.0;
					double num2;
					if (this._isVertical)
					{
						num = ((num == 0.0) ? desiredSize.Height : num);
						num2 = desiredSize.Width;
					}
					else
					{
						num = ((num == 0.0) ? desiredSize.Width : num);
						num2 = desiredSize.Height;
					}
					num2 += this._panel.GetRecordIndent(record);
					this._extentNonPrimary = global::System.Math.Max(num2, this._extentNonPrimary);
					double extentRemaining = this._extentRemaining;
					this._extentRemaining -= num;
					switch (this._currentPhase)
					{
					case global::Infragistics.Windows.DataPresenter.GridViewPanelFlat.GenerationCache.RecordGenerationPhase.TopFixed:
						this._extentTopFixed += num;
						if (!isHeader)
						{
							this._topFixedElementsGenerated++;
							this._generatedElements.Add(uielement);
						}
						break;
					case global::Infragistics.Windows.DataPresenter.GridViewPanelFlat.GenerationCache.RecordGenerationPhase.BottomFixed:
						this._extentBottomFixed += num;
						if (!isHeader)
						{
							this._bottomFixedElementsGenerated++;
							this._generatedBottomFixedElements.Add(uielement);
							if (this._firstBottomFixedRecord == null)
							{
								this._firstBottomFixedRecord = record;
							}
						}
						break;
					case global::Infragistics.Windows.DataPresenter.GridViewPanelFlat.GenerationCache.RecordGenerationPhase.Scrollable:
						this._extentScrollable += num;
						if (!isHeader)
						{
							this._highestScrollableRecordInView = record;
							if (this._extentRemaining >= 0.0 || global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(0.0, this._extentRemaining))
							{
								this._highestScrollableRecordFullyInView = record;
								this._scrollableElementsFullyInView++;
							}
							if (extentRemaining > 0.0)
							{
								this._scrollableElementsInView++;
							}
						}
						if (this._generatingAncestorHeaders || !isHeader)
						{
							this._scrollableElementsGenerated++;
							this._generatedElements.Add(uielement);
						}
						break;
					}
					if (isHeader)
					{
						if (!this._generatingAncestorHeaders)
						{
							this._headerElementsGenerated++;
						}
						global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord2 = record as global::Infragistics.Windows.DataPresenter.HeaderRecord;
						if (headerRecord2 != null)
						{
							if (this._headersWhichHaveElementsGenerated == null)
							{
								this._headersWhichHaveElementsGenerated = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.HeaderRecord>();
							}
							this._headersWhichHaveElementsGenerated.Add(headerRecord2);
						}
					}
					else
					{
						double num3 = this._averageExtentPerRecord * (double)this._elementsUsedInAverageCalc;
						if (flag)
						{
							this._elementsUsedInAverageCalc++;
						}
						else if (this._elementsUsedInAverageCalc < 1)
						{
							this._elementsUsedInAverageCalc = 1;
						}
						else
						{
							num3 -= this._averageExtentPerRecord;
						}
						this._averageExtentPerRecord = (num + num3) / (double)this._elementsUsedInAverageCalc;
					}
				}
				this._extentRemaining = global::System.Math.Max(this._extentRemaining, 0.0);
				return uielement;
			}

			// Token: 0x060017EB RID: 6123 RVA: 0x0006F838 File Offset: 0x0006DA38
			private void GenerateHeadersForAncestorDataRecords(global::Infragistics.Windows.DataPresenter.Record record)
			{
				if (this._isTreeView)
				{
					return;
				}
				int nextIndexToGen = this._nextIndexToGen;
				global::Infragistics.Windows.DataPresenter.DataRecord parentDataRecord = record.ParentDataRecord;
				global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.Record> stack = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.Record>();
				while (parentDataRecord != null)
				{
					if (this._fieldLayoutHeaderMap.ContainsKey(parentDataRecord.FieldLayout))
					{
						break;
					}
					if (parentDataRecord.AreChildrenAfterParent)
					{
						stack.Push(parentDataRecord);
					}
					else if (parentDataRecord.FieldLayout.HeaderPlacementResolved == global::Infragistics.Windows.DataPresenter.HeaderPlacement.OnTopOnly)
					{
						global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = parentDataRecord.ParentCollection.ViewableRecords;
						int num;
						if (viewableRecords != null)
						{
							num = viewableRecords.RecordCollectionSparseArray.GetVisibleIndexOf(parentDataRecord);
						}
						else
						{
							num = parentDataRecord.VisibleIndex;
						}
						if (num != 0)
						{
							global::Infragistics.Windows.DataPresenter.Record record2 = parentDataRecord.ParentCollection.ViewableRecords[0];
							stack.Push(record2 ?? parentDataRecord);
						}
					}
					parentDataRecord = parentDataRecord.ParentDataRecord;
				}
				try
				{
					this._generatingAncestorHeaders = true;
					while (stack.Count > 0)
					{
						global::Infragistics.Windows.DataPresenter.Record record3 = stack.Pop();
						global::System.Windows.UIElement uielement = this.GenerateHeader(record3.FieldLayout, record3);
						if (uielement != null)
						{
							this._lastHeaderFieldLayout = record3.FieldLayout;
							this._lastHeaderVrc = record3.ParentCollection.ViewableRecords;
						}
					}
				}
				finally
				{
					this._generatingAncestorHeaders = false;
					this._nextIndexToGen = nextIndexToGen;
				}
			}

			// Token: 0x060017EC RID: 6124 RVA: 0x0006F964 File Offset: 0x0006DB64
			private void GenerateRecordsHelper()
			{
				this._previousRecord = null;
				while (this._recordsToGenerate > 0 && this._extentRemaining > 0.0)
				{
					global::System.Windows.UIElement uielement = this.GenerateNextElement(false);
					this._recordsToGenerate--;
					if (this.IsResetPending)
					{
						break;
					}
					if (uielement == null)
					{
						return;
					}
				}
			}

			// Token: 0x060017ED RID: 6125 RVA: 0x0006F9B8 File Offset: 0x0006DBB8
			private bool GenerateScrollableRecords()
			{
				this._currentPhase = global::Infragistics.Windows.DataPresenter.GridViewPanelFlat.GenerationCache.RecordGenerationPhase.Scrollable;
				this._recordsToGenerate = this._records.CountOfNonHeaderRecords - (this._records.CountOfFixedRecordsOnTop + this._records.CountOfFixedRecordsOnBottom);
				if (this._recordsToGenerate < 1)
				{
					return true;
				}
				global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator recordsInViewGenerator = this._records.GetRecordsInViewGenerator(this._currentScrollPosition);
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> prefixRecords = recordsInViewGenerator.PrefixRecords;
				int num = (prefixRecords != null) ? prefixRecords.Count : 0;
				int num2 = 0;
				while (num2 < num && this._recordsToGenerate > 0 && this._extentRemaining > 0.0)
				{
					global::Infragistics.Windows.DataPresenter.Record record = prefixRecords[num2];
					num2++;
					this._nextIndexToGen = this._records.IndexOf(record);
					if (this._nextIndexToGen >= 0)
					{
						this.GenerateHeadersForAncestorDataRecords(record);
						global::System.Windows.UIElement uielement = this.GenerateNextElement(false);
						this._recordsToGenerate--;
						if (this.IsResetPending || uielement == null)
						{
							break;
						}
					}
				}
				if (this._recordsToGenerate < 1 || this.IsResetPending)
				{
					return !this.IsResetPending;
				}
				global::Infragistics.Windows.DataPresenter.Record firstRecord = recordsInViewGenerator.FirstRecord;
				if (firstRecord == null)
				{
					return !this.IsResetPending;
				}
				this._nextIndexToGen = this._records.IndexOf(firstRecord);
				int nextIndexToGen = this._nextIndexToGen;
				if (this._nextIndexToGen < 0)
				{
					return !this.IsResetPending;
				}
				this.GenerateHeadersForAncestorDataRecords(firstRecord);
				this.GenerateNextElement(false);
				this._recordsToGenerate--;
				if (this._recordsToGenerate < 1 || this.IsResetPending)
				{
					return !this.IsResetPending;
				}
				while (this._recordsToGenerate > 0 && this._extentRemaining > 0.0)
				{
					global::Infragistics.Windows.DataPresenter.Record successiveRecord = recordsInViewGenerator.GetSuccessiveRecord();
					if (successiveRecord == null)
					{
						break;
					}
					this._nextIndexToGen = this._records.IndexOf(successiveRecord);
					if (this.IsResetPending || this._nextIndexToGen <= nextIndexToGen)
					{
						break;
					}
					nextIndexToGen = this._nextIndexToGen;
					global::System.Windows.UIElement uielement2 = this.GenerateNextElement(false);
					this._recordsToGenerate--;
					if (this.IsResetPending || uielement2 == null)
					{
						break;
					}
				}
				return !this.IsResetPending;
			}

			// Token: 0x060017EE RID: 6126 RVA: 0x0006FBB4 File Offset: 0x0006DDB4
			private bool GenerateTopFixedRecords()
			{
				this._currentPhase = global::Infragistics.Windows.DataPresenter.GridViewPanelFlat.GenerationCache.RecordGenerationPhase.TopFixed;
				this._nextIndexToGen = 0;
				this._recordsToGenerate = this._records.CountOfFixedRecordsOnTop;
				if (this._recordsToGenerate > 0)
				{
					this.GenerateRecordsHelper();
				}
				else if (this._records.CountOfNonHeaderRecords == 0 && this._dataPresenter.DataSource != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._dataPresenter.RecordManager.FieldLayout;
					if (fieldLayout != null && fieldLayout.LabelLocationResolved == global::Infragistics.Windows.DataPresenter.LabelLocation.SeparateHeader)
					{
						this.GenerateHeader(fieldLayout, null);
					}
				}
				return !this.IsResetPending;
			}

			// Token: 0x060017EF RID: 6127 RVA: 0x0006FC3C File Offset: 0x0006DE3C
			private global::System.Collections.IEnumerable GetRecordsExpectedToBeGenerated(global::Infragistics.Windows.Selection.ScrollDirection scrollDirection)
			{
				int countOfFixedRecordsOnTop = this._records.CountOfFixedRecordsOnTop;
				int countOfFixedRecordsOnBottom = this._records.CountOfFixedRecordsOnBottom;
				int countOfNonHeaderRecords = this._records.CountOfNonHeaderRecords;
				int countOfHeaderRecords = this._records.CountOfHeaderRecords;
				if (this.IsResetPending)
				{
					return null;
				}
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
				int num = (this._panel._generatedElements != null) ? this._panel._generatedElements.Count : 0;
				for (int i = num - 1; i >= 0; i--)
				{
					global::System.Windows.UIElement uielement = this._panel._generatedElements[i];
					if (uielement != null && uielement.Visibility != global::System.Windows.Visibility.Collapsed)
					{
						global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(uielement);
						global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = (recordPresenterFromContainer != null) ? (recordPresenterFromContainer.Record as global::Infragistics.Windows.DataPresenter.HeaderRecord) : null;
						if (headerRecord == null)
						{
							break;
						}
						if (this._records.Contains(headerRecord))
						{
							list.Add(headerRecord);
						}
					}
				}
				int num2 = countOfNonHeaderRecords - (countOfFixedRecordsOnTop + countOfFixedRecordsOnBottom);
				int num3 = (scrollDirection == global::Infragistics.Windows.Selection.ScrollDirection.Increment) ? 10 : -1;
				num2 = global::System.Math.Max(global::System.Math.Min(num2 - this._currentScrollPosition, this._estimatedRecordsToLayout + num3 - (countOfFixedRecordsOnTop + countOfFixedRecordsOnBottom)), 0);
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>(countOfFixedRecordsOnTop + countOfFixedRecordsOnBottom + num2 + list.Count);
				for (int j = 0; j < countOfFixedRecordsOnTop; j++)
				{
					list2.Add(this._records[j]);
					if (this.IsResetPending)
					{
						return null;
					}
				}
				for (int k = 0; k < countOfFixedRecordsOnBottom; k++)
				{
					list2.Add(this._records[countOfNonHeaderRecords - (k + 1)]);
					if (this.IsResetPending)
					{
						return null;
					}
				}
				for (int l = 0; l < num2; l++)
				{
					list2.Add(this._records[this._currentScrollPosition + l + countOfFixedRecordsOnTop]);
					if (this.IsResetPending)
					{
						return null;
					}
				}
				if (list.Count > 0)
				{
					list2.AddRange(list);
				}
				return list2;
			}

			// Token: 0x060017F0 RID: 6128 RVA: 0x0006FE0C File Offset: 0x0006E00C
			private bool IsGroupByHeaderAlreadyDisplayed(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
			{
				return this.IsGroupByHeaderAlreadyDisplayed(fl, this._currentRecordManager);
			}

			// Token: 0x060017F1 RID: 6129 RVA: 0x0006FE1C File Offset: 0x0006E01C
			private bool IsGroupByHeaderAlreadyDisplayed(global::Infragistics.Windows.DataPresenter.FieldLayout fl, global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
			{
				if (this._headersOnTopOfGroupBys == null)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = null;
				this._headersOnTopOfGroupBys.TryGetValue(recordManager, out fieldLayout);
				return fieldLayout == fl;
			}

			// Token: 0x060017F2 RID: 6130 RVA: 0x0006FE48 File Offset: 0x0006E048
			private static bool IsHeaderOnTopOfGroupBys(global::Infragistics.Windows.DataPresenter.Record attachedToRecord)
			{
				global::Infragistics.Windows.DataPresenter.RecordType recordType = attachedToRecord.RecordType;
				if (recordType == global::Infragistics.Windows.DataPresenter.RecordType.GroupByField)
				{
					return true;
				}
				if (attachedToRecord is global::Infragistics.Windows.DataPresenter.DataRecord && attachedToRecord.ParentRecord is global::Infragistics.Windows.DataPresenter.GroupByRecord)
				{
					return true;
				}
				if (attachedToRecord is global::Infragistics.Windows.DataPresenter.FilterRecord && attachedToRecord.ParentCollection.RecordsType == global::Infragistics.Windows.DataPresenter.RecordType.GroupByField)
				{
					return true;
				}
				if (attachedToRecord is global::Infragistics.Windows.DataPresenter.SummaryRecord)
				{
					switch (attachedToRecord.ParentCollection.RecordsType)
					{
					case global::Infragistics.Windows.DataPresenter.RecordType.DataRecord:
						return attachedToRecord.FieldLayout.HasGroupBySortFields;
					case global::Infragistics.Windows.DataPresenter.RecordType.GroupByField:
						return true;
					}
				}
				return false;
			}

			// Token: 0x060017F3 RID: 6131 RVA: 0x0006FEC4 File Offset: 0x0006E0C4
			private void ReleaseGeneratorStart()
			{
				if (this._currentGeneratorStart != null)
				{
					this._currentGeneratorStart.Dispose();
					this._currentGeneratorStart = null;
				}
			}

			// Token: 0x060017F4 RID: 6132 RVA: 0x0006FEE0 File Offset: 0x0006E0E0
			private bool ShouldShowHeaderOnFirstRecordInIsland(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.RecordManager recordManager, global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy headerPlacementInGroupBy, bool fieldLayoutHasGroups)
			{
				return !fieldLayoutHasGroups || headerPlacementInGroupBy == global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.WithDataRecords || !this.IsGroupByHeaderAlreadyDisplayed(fieldLayout, recordManager);
			}

			// Token: 0x060017F5 RID: 6133 RVA: 0x0006FEFC File Offset: 0x0006E0FC
			private void StartGenerator()
			{
				this.ReleaseGeneratorStart();
				this._currentGeneratorPositionIndex = this._nextIndexToGen;
				global::System.Windows.Controls.Primitives.GeneratorPosition generatorPositionFromItemIndex = this._panel.GetGeneratorPositionFromItemIndex(this._nextIndexToGen, out this._nextChildElementIndex);
				this._currentGeneratorStart = this._generator.StartAt(generatorPositionFromItemIndex, global::System.Windows.Controls.Primitives.GeneratorDirection.Forward, true);
				this._nextChildElementIndex = -1;
			}

			// Token: 0x060017F6 RID: 6134 RVA: 0x0006FF4E File Offset: 0x0006E14E
			public void Dispose()
			{
				this.ReleaseGeneratorStart();
				if (this._generator != null)
				{
					this._panel.EndGeneration();
				}
				this._records.EndMeasure();
			}

			// Token: 0x04000997 RID: 2455
			internal global::Infragistics.Windows.DataPresenter.GridViewPanelFlat _panel;

			// Token: 0x04000998 RID: 2456
			private global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection _records;

			// Token: 0x04000999 RID: 2457
			private global::System.Collections.IList _childElements;

			// Token: 0x0400099A RID: 2458
			private int _childElementCount;

			// Token: 0x0400099B RID: 2459
			private global::Infragistics.Windows.DataPresenter.FieldLayout _currentFieldLayout;

			// Token: 0x0400099C RID: 2460
			private global::Infragistics.Windows.DataPresenter.ViewableRecordCollection _currentVrc;

			// Token: 0x0400099D RID: 2461
			private global::Infragistics.Windows.DataPresenter.RecordManager _currentRecordManager;

			// Token: 0x0400099E RID: 2462
			private global::Infragistics.Windows.DataPresenter.FieldLayout _lastHeaderFieldLayout;

			// Token: 0x0400099F RID: 2463
			private global::Infragistics.Windows.DataPresenter.ViewableRecordCollection _lastHeaderVrc;

			// Token: 0x040009A0 RID: 2464
			private int _currentRecordNestingDepth;

			// Token: 0x040009A1 RID: 2465
			private bool _currentFieldLayoutHasGroups;

			// Token: 0x040009A2 RID: 2466
			private global::Infragistics.Windows.DataPresenter.LabelLocation _currentLabelLocation;

			// Token: 0x040009A3 RID: 2467
			private global::Infragistics.Windows.DataPresenter.HeaderPlacement _currentHeaderPlacement;

			// Token: 0x040009A4 RID: 2468
			private global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy _currentHeaderPlacementInGroupBy;

			// Token: 0x040009A5 RID: 2469
			private global::Infragistics.Windows.DataPresenter.Record _previousRecord;

			// Token: 0x040009A6 RID: 2470
			internal global::Infragistics.Windows.DataPresenter.Record _highestScrollableRecordFullyInView;

			// Token: 0x040009A7 RID: 2471
			internal global::Infragistics.Windows.DataPresenter.Record _highestScrollableRecordInView;

			// Token: 0x040009A8 RID: 2472
			internal global::Infragistics.Windows.DataPresenter.Record _firstBottomFixedRecord;

			// Token: 0x040009A9 RID: 2473
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

			// Token: 0x040009AA RID: 2474
			private bool _isVertical;

			// Token: 0x040009AB RID: 2475
			private global::Infragistics.Windows.DataPresenter.GridViewPanelFlat.GenerationCache.RecordGenerationPhase _currentPhase;

			// Token: 0x040009AC RID: 2476
			private global::System.Windows.Size _constraint;

			// Token: 0x040009AD RID: 2477
			private global::System.Windows.Size _measureConstraint = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);

			// Token: 0x040009AE RID: 2478
			private global::System.Windows.Size _measureConstraintAutoFit;

			// Token: 0x040009AF RID: 2479
			private global::System.Windows.Controls.Primitives.IItemContainerGenerator _generator;

			// Token: 0x040009B0 RID: 2480
			internal double _extentOverall;

			// Token: 0x040009B1 RID: 2481
			internal double _extentRemaining;

			// Token: 0x040009B2 RID: 2482
			internal double _extentTopFixed;

			// Token: 0x040009B3 RID: 2483
			internal double _extentBottomFixed;

			// Token: 0x040009B4 RID: 2484
			internal double _extentScrollable;

			// Token: 0x040009B5 RID: 2485
			internal double _extentNonPrimary;

			// Token: 0x040009B6 RID: 2486
			internal double _extentRootHeader;

			// Token: 0x040009B7 RID: 2487
			internal int _currentScrollPosition;

			// Token: 0x040009B8 RID: 2488
			private global::System.IDisposable _currentGeneratorStart;

			// Token: 0x040009B9 RID: 2489
			private int _currentGeneratorPositionIndex;

			// Token: 0x040009BA RID: 2490
			internal int _bottomFixedElementsGenerated;

			// Token: 0x040009BB RID: 2491
			internal int _headerElementsGenerated;

			// Token: 0x040009BC RID: 2492
			internal int _scrollableElementsFullyInView;

			// Token: 0x040009BD RID: 2493
			internal int _scrollableElementsInView;

			// Token: 0x040009BE RID: 2494
			internal int _scrollableElementsGenerated;

			// Token: 0x040009BF RID: 2495
			internal int _topFixedElementsGenerated;

			// Token: 0x040009C0 RID: 2496
			private int _nextIndexToGen;

			// Token: 0x040009C1 RID: 2497
			private int _nextChildElementIndex;

			// Token: 0x040009C2 RID: 2498
			private int _highestScrollPosition;

			// Token: 0x040009C3 RID: 2499
			private int _recordsToGenerate;

			// Token: 0x040009C4 RID: 2500
			private bool _isResetPending;

			// Token: 0x040009C5 RID: 2501
			internal int _estimatedRecordsToLayout;

			// Token: 0x040009C6 RID: 2502
			internal double _averageExtentPerRecord;

			// Token: 0x040009C7 RID: 2503
			internal int _elementsUsedInAverageCalc;

			// Token: 0x040009C8 RID: 2504
			internal global::System.Collections.Generic.List<global::System.Windows.UIElement> _generatedElements;

			// Token: 0x040009C9 RID: 2505
			private global::System.Collections.Generic.List<global::System.Windows.UIElement> _generatedBottomFixedElements;

			// Token: 0x040009CA RID: 2506
			private global::System.Collections.Generic.List<global::System.Windows.UIElement> _generatedHeaderElements;

			// Token: 0x040009CB RID: 2507
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Windows.UIElement> _fieldLayoutHeaderMap;

			// Token: 0x040009CC RID: 2508
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordManager, global::Infragistics.Windows.DataPresenter.FieldLayout> _headersOnTopOfGroupBys;

			// Token: 0x040009CD RID: 2509
			private bool _generatingAncestorHeaders;

			// Token: 0x040009CE RID: 2510
			private bool _isTreeView;

			// Token: 0x040009CF RID: 2511
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.HeaderRecord> _headersWhichHaveElementsGenerated;

			// Token: 0x040009D0 RID: 2512
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Record, object> _recordsNeedingHeaders;

			// Token: 0x0200017C RID: 380
			private enum RecordGenerationPhase
			{
				// Token: 0x040009D2 RID: 2514
				NotStarted,
				// Token: 0x040009D3 RID: 2515
				TopFixed,
				// Token: 0x040009D4 RID: 2516
				BottomFixed,
				// Token: 0x040009D5 RID: 2517
				Scrollable
			}
		}
	}
}
