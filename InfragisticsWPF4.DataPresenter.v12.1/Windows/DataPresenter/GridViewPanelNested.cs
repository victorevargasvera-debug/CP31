using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Threading;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200015D RID: 349
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public sealed class GridViewPanelNested : global::Infragistics.Windows.DataPresenter.GridViewPanel
	{
		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x00056A80 File Offset: 0x00054C80
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x00056AB8 File Offset: 0x00054CB8
		internal override int EffectiveScrollPosition
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.GridViewPanelNested gridViewPanelNested = this.RootPanel as global::Infragistics.Windows.DataPresenter.GridViewPanelNested;
				if (gridViewPanelNested == null)
				{
					return 0;
				}
				if (gridViewPanelNested._useScrollPositionCandidate)
				{
					return gridViewPanelNested._scrollPositionCandidate;
				}
				return base.ViewPanelInfo.OverallScrollPosition;
			}
			set
			{
				global::Infragistics.Windows.DataPresenter.GridViewPanelNested gridViewPanelNested = this.RootPanel as global::Infragistics.Windows.DataPresenter.GridViewPanelNested;
				if (gridViewPanelNested == null)
				{
					return;
				}
				if (gridViewPanelNested._useScrollPositionCandidate)
				{
					gridViewPanelNested._scrollPositionCandidate = value;
					base.DataPresenter.BumpRecordsInViewVersion();
					return;
				}
				base.ViewPanelInfo.OverallScrollPosition = value;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x00056AFC File Offset: 0x00054CFC
		internal override global::Infragistics.Windows.DataPresenter.Record FirstScrollableRecord
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
				if (viewableRecords == null)
				{
					return null;
				}
				int count = viewableRecords.Count;
				if (count == 0)
				{
					return null;
				}
				int countOfFixedRecordsOnTop = viewableRecords.CountOfFixedRecordsOnTop;
				int countOfFixedRecordsOnBottom = viewableRecords.CountOfFixedRecordsOnBottom;
				if (this._offsetWithinListForScrollableRecords < count - (countOfFixedRecordsOnTop + countOfFixedRecordsOnBottom))
				{
					global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = base.ViewPanelInfo;
					if (viewPanelInfo != null)
					{
						int overallScrollPosition = viewPanelInfo.OverallScrollPosition;
						if (overallScrollPosition >= countOfFixedRecordsOnTop)
						{
							return viewPanelInfo.GetRecordAtOverallScrollPosition(overallScrollPosition);
						}
					}
					return viewableRecords[countOfFixedRecordsOnTop + this._offsetWithinListForScrollableRecords];
				}
				if (this._offsetWithinListForTopFixedRecords >= countOfFixedRecordsOnTop)
				{
					return viewableRecords[this._offsetWithinListForTopFixedRecords];
				}
				if (this._offsetWithinListForBottomFixedRecords < countOfFixedRecordsOnBottom)
				{
					return viewableRecords[this._offsetWithinListForBottomFixedRecords + count - countOfFixedRecordsOnTop];
				}
				return null;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x00056BA0 File Offset: 0x00054DA0
		public override bool IsRootPanel
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
				if (dataPresenter != null)
				{
					global::System.Windows.Controls.Panel currentPanel = dataPresenter.CurrentPanel;
					if (currentPanel != null)
					{
						return this == currentPanel;
					}
				}
				global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = base.RecordListControl;
				return recordListControl.ItemsSource == recordListControl.DataPresenter.RecordManager.ViewableRecords;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x00056BE5 File Offset: 0x00054DE5
		internal override bool IsRootPanelInInfiniteContainer
		{
			get
			{
				return this._isRootPanelInInfiniteContainer;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x00056BED File Offset: 0x00054DED
		public override global::Infragistics.Windows.DataPresenter.GridViewPanel RootPanel
		{
			get
			{
				if (this.IsRootPanel)
				{
					return this;
				}
				if (this._rootPanel == this)
				{
					this._rootPanel = null;
				}
				if (this._rootPanel == null)
				{
					this._rootPanel = (base.DataPresenter.CurrentPanel as global::Infragistics.Windows.DataPresenter.GridViewPanelNested);
				}
				return this._rootPanel;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x00056C30 File Offset: 0x00054E30
		internal override int RootPanelTopFixedOffset
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.GridViewPanelNested gridViewPanelNested = this.RootPanel as global::Infragistics.Windows.DataPresenter.GridViewPanelNested;
				if (gridViewPanelNested != null && gridViewPanelNested._offsetWithinListForTopFixedRecords == 0)
				{
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = gridViewPanelNested.ViewableRecords;
					if (viewableRecords != null)
					{
						return viewableRecords.CountOfFixedRecordsOnTop;
					}
				}
				return 0;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x00056C66 File Offset: 0x00054E66
		internal override int ScrollPositionOfLastVisibleRecord
		{
			get
			{
				return this._scrollPositionOfLastVisibleRecord;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x00056C70 File Offset: 0x00054E70
		protected override int TotalVisibleGeneratedItems
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
				if (viewableRecords == null)
				{
					return 0;
				}
				return global::System.Math.Min(base.TotalItems - 1, this._numberOfScrollableRecordsToLayout + viewableRecords.CountOfFixedRecordsOnTop + viewableRecords.CountOfFixedRecordsOnBottom - (this._offsetWithinListForTopFixedRecords + this._offsetWithinListForBottomFixedRecords));
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00056CB8 File Offset: 0x00054EB8
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			base.ArrangeOverride(finalSize);
			global::Infragistics.Windows.DataPresenter.GridViewSettings viewSettings = base.ViewSettings;
			if (viewSettings == null)
			{
				return finalSize;
			}
			bool flag = viewSettings.Orientation == global::System.Windows.Controls.Orientation.Vertical;
			global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData scrollingData = base.ScrollingData;
			if (scrollingData != null && this._cachedScrollDataFromMeasure != null && this.IsRootPanel)
			{
				global::System.Windows.Vector offset = scrollingData._offset;
				global::System.Windows.Vector vector = offset;
				global::System.Windows.Size viewport = this._cachedScrollDataFromMeasure._viewport;
				if (flag)
				{
					vector.X = global::System.Math.Min(offset.X, finalSize.Width - viewport.Width);
				}
				else
				{
					vector.Y = global::System.Math.Min(offset.Y, finalSize.Height - viewport.Height);
				}
				if (vector != offset)
				{
					if (this._gridViewPanelAdorner != null)
					{
						this._gridViewPanelAdorner.InitializeOffset(flag ? (-vector.X) : (-vector.Y));
					}
					scrollingData._offset = vector;
					base.OnScrollInfoChange();
					base.VerifyFixedFieldInfo();
				}
			}
			global::System.Windows.Rect rect = new global::System.Windows.Rect(finalSize);
			double extentUsedByLastItem = 0.0;
			global::System.Windows.Rect rect2 = default(global::System.Windows.Rect);
			global::System.Windows.Rect rect3 = global::System.Windows.Rect.Empty;
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
			if (viewableRecords == null)
			{
				return finalSize;
			}
			int countOfFixedRecordsOnTop = viewableRecords.CountOfFixedRecordsOnTop;
			int countOfFixedRecordsOnBottom = viewableRecords.CountOfFixedRecordsOnBottom;
			int count = viewableRecords.Count;
			int num = global::System.Math.Max(0, countOfFixedRecordsOnTop - this._offsetWithinListForTopFixedRecords);
			int num2 = global::System.Math.Max(0, countOfFixedRecordsOnBottom - this._offsetWithinListForBottomFixedRecords);
			double num3;
			if (flag)
			{
				rect.X = -1.0 * base.ScrollingData._offset.X;
				rect.Y = this._extentUsedByHeaderRecords;
				num3 = finalSize.Height;
			}
			else
			{
				rect.X = this._extentUsedByHeaderRecords;
				rect.Y = -1.0 * base.ScrollingData._offset.Y;
				num3 = finalSize.Width;
			}
			global::System.Collections.IList childElements = base.ChildElements;
			int count2 = childElements.Count;
			global::System.Collections.Generic.Stack<global::System.Windows.UIElement> stack = null;
			int num4 = 0;
			global::Infragistics.Windows.DataPresenter.Record record = null;
			bool isRootPanel = this.IsRootPanel;
			for (int i = 0; i < count2; i++)
			{
				global::System.Windows.UIElement uielement = childElements[i] as global::System.Windows.UIElement;
				int generatedIndexFromChildIndex = base.GetGeneratedIndexFromChildIndex(i);
				double num5 = double.PositiveInfinity;
				if (num > 0 && generatedIndexFromChildIndex >= this._firstVisualTopFixedItemIndex && generatedIndexFromChildIndex < this._firstVisualTopFixedItemIndex + num)
				{
					if (isRootPanel)
					{
						double num6;
						if (num4 == 0)
						{
							num6 = this._extentUsedByHeaderRecords;
						}
						else if (flag)
						{
							num6 = rect.Bottom;
						}
						else
						{
							num6 = rect.Right;
						}
						num5 = num3 - (num6 + this._extentUsedByFixedRecordsOnBottom);
					}
					extentUsedByLastItem = this.ArrangeHelper(uielement, flag, false, extentUsedByLastItem, num5, finalSize, ref rect);
					num4++;
				}
				else if (generatedIndexFromChildIndex >= this._firstVisualScrollableItemIndex && generatedIndexFromChildIndex < this._firstVisualScrollableItemIndex + this._numberOfScrollableRecordsToLayout)
				{
					if (record == null)
					{
						global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(uielement);
						if (recordPresenterFromContainer != null)
						{
							record = recordPresenterFromContainer.Record;
						}
					}
					if (isRootPanel && num4 > 0)
					{
						num5 = num3 - this._extentUsedByFixedRecordsOnBottom;
						if (flag)
						{
							num5 -= rect.Bottom;
						}
						else
						{
							num5 -= rect.Right;
						}
					}
					extentUsedByLastItem = this.ArrangeHelper(uielement, flag, false, extentUsedByLastItem, num5, finalSize, ref rect);
					num4++;
				}
				else if (generatedIndexFromChildIndex >= this._firstVisualBottomFixedItemIndex && generatedIndexFromChildIndex < this._firstVisualBottomFixedItemIndex + num2)
				{
					if (stack == null)
					{
						stack = new global::System.Collections.Generic.Stack<global::System.Windows.UIElement>();
					}
					stack.Push(uielement);
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer2 = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(uielement);
					if (recordPresenterFromContainer2 != null)
					{
						bool isHidingRecord = base.IsHidingRecord;
						base.IsHidingRecord = true;
						try
						{
							recordPresenterFromContainer2.IsArrangedInView = false;
							recordPresenterFromContainer2.TreatAsCollapsed = true;
							goto IL_3B2;
						}
						finally
						{
							base.IsHidingRecord = isHidingRecord;
						}
					}
					global::System.Windows.Size desiredSize = uielement.DesiredSize;
					uielement.Arrange(new global::System.Windows.Rect(new global::System.Windows.Point(-10000.0 * finalSize.Width, -10000.0 * finalSize.Height), desiredSize));
				}
				IL_3B2:
				rect2.Union(rect);
			}
			if (stack != null)
			{
				global::System.Windows.Point location;
				if (flag)
				{
					location = new global::System.Windows.Point(0.0, finalSize.Height);
				}
				else
				{
					location = new global::System.Windows.Point(finalSize.Width, 0.0);
				}
				if (flag)
				{
					location.X = -1.0 * base.ScrollingData._offset.X;
				}
				else
				{
					location.Y = -1.0 * base.ScrollingData._offset.Y;
				}
				global::System.Windows.Rect rect4 = new global::System.Windows.Rect(location, finalSize);
				extentUsedByLastItem = 0.0;
				while (stack.Count > 0)
				{
					global::System.Windows.UIElement visualChildElement = stack.Pop();
					extentUsedByLastItem = this.ArrangeHelper(visualChildElement, flag, true, extentUsedByLastItem, double.PositiveInfinity, finalSize, ref rect4);
					num4++;
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
			if (isRootPanel && this._cachedScrollDataFromMeasure != null && count2 > 0)
			{
				global::System.Windows.Size size = finalSize;
				if (!rect3.IsEmpty)
				{
					size.Height = global::System.Math.Max(rect3.Top, 0.0);
				}
				bool flag2 = this.VerifyScrollPositionOfLastVisibleRecord(size);
				if (!this._useScrollPositionCandidate)
				{
					int scrollPositionOfLastVisibleRecord = this._scrollPositionOfLastVisibleRecord;
					int effectiveScrollPosition = this.EffectiveScrollPosition;
					if (flag2)
					{
						int num7;
						if (countOfFixedRecordsOnBottom > 0)
						{
							num7 = viewableRecords[count - (1 + num2)].OverallScrollPosition;
						}
						else
						{
							num7 = base.ViewPanelInfo.OverallScrollCount - 1;
						}
						this._isLastScrollableRecordFullyInView = (scrollPositionOfLastVisibleRecord >= num7 && scrollPositionOfLastVisibleRecord >= this.GetLastAbsoluteScrollableRecordScrollPos());
					}
					else
					{
						this._isLastScrollableRecordFullyInView = false;
					}
					global::System.Windows.Size viewport2;
					if (flag)
					{
						int num8 = global::System.Math.Max(1, scrollPositionOfLastVisibleRecord - effectiveScrollPosition + 1);
						if (rect2.Height > finalSize.Height && (double)scrollPositionOfLastVisibleRecord < this._cachedScrollDataFromMeasure._viewport.Height - 1.0)
						{
							num8--;
						}
						if (this._cachedRemainingAvailableExtentFromMeasure > 0.0)
						{
							num8 = global::System.Math.Max(num8, this._lastViewportHeight);
						}
						this._lastViewportHeight = num8;
						viewport2 = new global::System.Windows.Size(this._cachedScrollDataFromMeasure._viewport.Width, (double)num8);
					}
					else
					{
						int num9 = global::System.Math.Max(1, scrollPositionOfLastVisibleRecord - effectiveScrollPosition + 1);
						if (rect2.Width > finalSize.Width && (double)scrollPositionOfLastVisibleRecord < this._cachedScrollDataFromMeasure._viewport.Width - 1.0)
						{
							num9--;
						}
						if (this._cachedRemainingAvailableExtentFromMeasure > 0.0)
						{
							num9 = global::System.Math.Max(num9, this._lastViewportWidth);
						}
						this._lastViewportWidth = num9;
						viewport2 = new global::System.Windows.Size((double)num9, this._cachedScrollDataFromMeasure._viewport.Height);
					}
					this.VerifyScrollData(this._cachedScrollDataFromMeasure._extent, viewport2, this._cachedScrollDataFromMeasure._offset, size);
					if (record != null)
					{
						this.PostBottomRecordVerification(size);
					}
				}
				else if (flag2)
				{
					int scrollPositionOfLastVisibleRecord2 = this._scrollPositionOfLastVisibleRecord;
					int num10;
					if (countOfFixedRecordsOnBottom > 0)
					{
						num10 = viewableRecords[count - (1 + num2)].OverallScrollPosition;
					}
					else
					{
						num10 = base.ViewPanelInfo.OverallScrollCount - 1;
					}
					this._isScrollPositionCandidateFullyInView = (scrollPositionOfLastVisibleRecord2 >= num10 && scrollPositionOfLastVisibleRecord2 >= this.GetLastAbsoluteScrollableRecordScrollPos());
				}
				else
				{
					this._isScrollPositionCandidateFullyInView = false;
				}
			}
			else if (isRootPanel && this._cachedScrollDataFromMeasure != null && count2 < 1)
			{
				global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData scrollingData2 = base.ScrollingData;
				global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData cachedScrollDataFromMeasure = this._cachedScrollDataFromMeasure;
				if (flag)
				{
					scrollingData2._viewportForScrollbar.Height = 1.0;
					scrollingData2._viewport.Height = 1.0;
					scrollingData2._extentForScrollbar.Height = 1.0;
					scrollingData2._extent.Height = 1.0;
					scrollingData2._extentForScrollbar.Width = cachedScrollDataFromMeasure._extent.Width;
					scrollingData2._extent.Width = cachedScrollDataFromMeasure._extent.Width;
					scrollingData2._viewportForScrollbar.Width = cachedScrollDataFromMeasure._viewport.Width;
					scrollingData2._viewport.Width = cachedScrollDataFromMeasure._viewport.Width;
					if (scrollingData2._extent.Width <= scrollingData2._viewport.Width)
					{
						scrollingData2._offset = new global::System.Windows.Vector(0.0, 0.0);
					}
				}
				else
				{
					scrollingData2._viewportForScrollbar.Width = 1.0;
					scrollingData2._extentForScrollbar.Width = 1.0;
					scrollingData2._extentForScrollbar.Height = cachedScrollDataFromMeasure._extent.Height;
					scrollingData2._extent.Height = cachedScrollDataFromMeasure._extent.Height;
					scrollingData2._viewportForScrollbar.Height = cachedScrollDataFromMeasure._viewport.Height;
					scrollingData2._viewport.Height = cachedScrollDataFromMeasure._viewport.Height;
					if (scrollingData2._extent.Height <= scrollingData2._viewport.Height)
					{
						scrollingData2._offset = new global::System.Windows.Vector(0.0, 0.0);
					}
				}
				base.VerifyFixedFieldInfo();
				base.OnScrollInfoChange();
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

		// Token: 0x0600142B RID: 5163 RVA: 0x00057618 File Offset: 0x00055818
		internal override bool EnsureRecordIsVisible(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return this.EnsureRecordIsVisibleHelper(record, true);
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00057624 File Offset: 0x00055824
		private bool EnsureRecordIsVisibleHelper(global::Infragistics.Windows.DataPresenter.Record record, bool firstPass)
		{
			if (record == null)
			{
				throw new global::System.ArgumentNullException("record");
			}
			if (!this.IsRootPanel)
			{
				return this.RootPanel.EnsureRecordIsVisible(record);
			}
			if (!base.CanRecordsBeScrolled)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.GridViewSettings viewSettings = base.ViewSettings;
			if (viewSettings == null)
			{
				return false;
			}
			if (record.VisibilityResolved == global::System.Windows.Visibility.Collapsed)
			{
				return false;
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
			int overallScrollPositionForRecord = viewPanelInfo.GetOverallScrollPositionForRecord(record);
			if (overallScrollPositionForRecord < 0)
			{
				return true;
			}
			int num = overallScrollPositionForRecord;
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
			if (viewableRecords == null)
			{
				return false;
			}
			num -= viewableRecords.CountOfFixedRecordsOnTop;
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords2 = record.ParentCollection.ViewableRecords;
			bool flag = record.IsFixed && record.IsOnTopWhenFixed;
			while (viewableRecords2 != viewableRecords)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					num -= viewableRecords2.CountOfFixedRecordsOnTop;
				}
				global::Infragistics.Windows.DataPresenter.Record parentRecord = viewableRecords2.RecordCollection.ParentRecord;
				if (parentRecord == null)
				{
					break;
				}
				viewableRecords2 = parentRecord.ParentCollection.ViewableRecords;
			}
			num = global::System.Math.Max(0, num);
			int effectiveScrollPosition = this.EffectiveScrollPosition;
			int scrollPositionOfLastVisibleRecord = this._scrollPositionOfLastVisibleRecord;
			while (num == scrollPositionOfLastVisibleRecord + 1)
			{
				int num2 = effectiveScrollPosition;
				if (viewSettings.Orientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					base.LineDown();
				}
				else
				{
					base.LineRight();
				}
				base.UpdateLayout();
				scrollPositionOfLastVisibleRecord = this._scrollPositionOfLastVisibleRecord;
				effectiveScrollPosition = this.EffectiveScrollPosition;
				if (num2 == effectiveScrollPosition)
				{
					break;
				}
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
			if (!viewPanelInfo.IsOkToScroll())
			{
				return false;
			}
			if (num < effectiveScrollPosition)
			{
				if (viewSettings.Orientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					base.SetVerticalOffset((double)num);
				}
				else
				{
					base.SetHorizontalOffset((double)num);
				}
				if (record.ParentRecord != null && !record.ParentRecord.IsExpanded)
				{
					record.ParentRecord.IsExpanded = true;
				}
				return true;
			}
			global::Infragistics.Windows.DataPresenter.Record record2 = null;
			double num3 = (double)(num - this._visibleItemCount);
			int targetScrollIndexForLastVisibleRecord = overallScrollPositionForRecord;
			global::Infragistics.Windows.DataPresenter.RecordPresenter associatedRecordPresenter = record.AssociatedRecordPresenter;
			global::System.Windows.FrameworkElement frameworkElement = (associatedRecordPresenter != null && associatedRecordPresenter.IsVisible && associatedRecordPresenter.ShouldDisplayRecordContent) ? associatedRecordPresenter.GetRecordContentSite() : null;
			if (frameworkElement != null && base.IsAncestorOf(frameworkElement))
			{
				global::System.Windows.Rect rect = new global::System.Windows.Rect(base.RenderSize);
				global::System.Windows.Rect rect2 = frameworkElement.TransformToAncestor(this).TransformBounds(new global::System.Windows.Rect(frameworkElement.RenderSize));
				if (associatedRecordPresenter is global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter || viewSettings.Orientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					if (rect2.Y >= rect.Y && rect2.Bottom <= rect.Bottom)
					{
						return true;
					}
				}
				else if (rect2.X >= rect.X && rect2.Right <= rect.Right)
				{
					return true;
				}
			}
			if (firstPass)
			{
				this.DetermineTopRecordForGivenBottomRecordIndex(ref record2, ref num3, targetScrollIndexForLastVisibleRecord);
				if (viewSettings.Orientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					base.SetVerticalOffset(num3);
				}
				else
				{
					base.SetHorizontalOffset(num3);
				}
				base.UpdateLayout();
				return this.EnsureRecordIsVisibleHelper(record, false);
			}
			return true;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00057908 File Offset: 0x00055B08
		protected override bool GetCanCleanupItem(int itemIndex)
		{
			global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = base.RecordListControl;
			int count = recordListControl.Items.Count;
			if (itemIndex < 0 || itemIndex >= count)
			{
				return true;
			}
			if (itemIndex >= this._offsetWithinListForScrollableRecords && itemIndex < this._offsetWithinListForScrollableRecords + this.TotalVisibleGeneratedItems)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.Record record = recordListControl.Items[itemIndex] as global::Infragistics.Windows.DataPresenter.Record;
			return !record.IsFixed && !record.IsSpecialRecord;
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00057974 File Offset: 0x00055B74
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			if (this._scrollPositionWhenNoChildrenAbovePresent >= 0)
			{
				this._scrollPositionWhenNoChildrenAbovePresent = -1;
				this._rcdsInViewTracker = null;
			}
			global::Infragistics.Windows.DataPresenter.GridViewSettings viewSettings = base.ViewSettings;
			if (viewSettings == null)
			{
				return new global::System.Windows.Size(1.0, 1.0);
			}
			if (availableSize.Width < 1.0 || availableSize.Height < 1.0)
			{
				return new global::System.Windows.Size(1.0, 1.0);
			}
			if (this._gridViewPanelAdorner == null)
			{
				this.InitializeAdorner();
			}
			global::System.Windows.Size size = availableSize;
			bool flag = viewSettings.Orientation == global::System.Windows.Controls.Orientation.Vertical;
			bool isRootPanel = this.IsRootPanel;
			this._isRootPanelInInfiniteContainer = false;
			if (isRootPanel)
			{
				if (double.IsInfinity(availableSize.Width))
				{
					this._widthInInfiniteContainer = base.WidthInfiniteContainersResolved;
					if (!flag)
					{
						this._isRootPanelInInfiniteContainer = true;
					}
				}
				else
				{
					this._widthInInfiniteContainer = 0.0;
				}
				if (double.IsInfinity(availableSize.Height))
				{
					this._heightInInfiniteContainer = base.HeightInfiniteContainersResolved;
					if (flag)
					{
						this._isRootPanelInInfiniteContainer = true;
					}
				}
				else
				{
					this._heightInInfiniteContainer = 0.0;
				}
			}
			else if (this.RootPanel == null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
				if (dataPresenter != null)
				{
					dataPresenter.WireLayoutUpdated(new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnLayoutUpdated));
				}
				return new global::System.Windows.Size(1.0, 1.0);
			}
			double width = double.IsInfinity(availableSize.Width) ? base.WidthInfiniteContainersResolved : availableSize.Width;
			double height = double.IsInfinity(availableSize.Height) ? base.HeightInfiniteContainersResolved : availableSize.Height;
			availableSize = new global::System.Windows.Size(width, height);
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = base.ViewPanelInfo;
			global::System.Windows.Size size2 = isRootPanel ? availableSize : ((global::Infragistics.Windows.DataPresenter.GridViewPanelNested)this.RootPanel)._lastMeasureConstraint;
			global::System.Windows.Size size3 = size2;
			if (this.ViewableRecords != null)
			{
				int count = this.ViewableRecords.Count;
			}
			int num = (base.RecordListControl != null && base.RecordListControl.HasItems) ? base.RecordListControl.Items.Count : 0;
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
			if (viewableRecords == null)
			{
				return new global::System.Windows.Size(1.0, 1.0);
			}
			global::Infragistics.Windows.DataPresenter.Record parentRecord = viewableRecords.RecordCollection.ParentRecord;
			if (parentRecord != null && parentRecord.HasCollapsedAncestor)
			{
				return new global::System.Windows.Size(1.0, 1.0);
			}
			if (num > 0)
			{
				global::Infragistics.Windows.DataPresenter.Record record = viewableRecords[0];
				num = viewableRecords.Count;
			}
			int overallScrollCount = viewPanelInfo.OverallScrollCount;
			if (isRootPanel)
			{
				this._lastMeasureConstraint = availableSize;
				if (!this._useScrollPositionCandidate)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter2 = base.DataPresenter;
					int num2 = (dataPresenter2 != null) ? dataPresenter2.OverallSortVersion : 0;
					if (this._lastOverallScrollCount != overallScrollCount || num2 != this._lastOverallSortVersion || this._isProcessingBottomRecordVerification)
					{
						this._scrollPositionOfLastVisibleRecord = -1;
						if (num2 != this._lastOverallSortVersion)
						{
							this._lastOverallSortVersion = num2;
							global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter3 = base.DataPresenter;
							if (dataPresenter3 != null)
							{
								dataPresenter3.WireLayoutUpdated(new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnLayoutUpdated));
							}
						}
					}
				}
			}
			if (overallScrollCount != this._lastOverallScrollCount)
			{
				this._lastOverallScrollCount = overallScrollCount;
				this._lastBottomRecordVerificationScrollPos = 0.0;
			}
			int num3;
			double num4;
			if (flag)
			{
				size3.Height = double.PositiveInfinity;
				if (this.RootPanel.IsScrolling && this.RootPanel.CanHorizontallyScroll)
				{
					size3.Width = double.PositiveInfinity;
				}
				num3 = (base.IsScrolling ? base.NormalizeScrollOffset(base.ScrollingData._offset.Y, overallScrollCount - 1) : 0);
				num4 = size2.Height;
			}
			else
			{
				size3.Width = double.PositiveInfinity;
				if (this.RootPanel.IsScrolling && this.RootPanel.CanVerticallyScroll)
				{
					size3.Height = double.PositiveInfinity;
				}
				num3 = (base.IsScrolling ? base.NormalizeScrollOffset(base.ScrollingData._offset.X, overallScrollCount - 1) : 0);
				num4 = size2.Width;
			}
			int offsetWithinListForTopFixedRecords = this._offsetWithinListForTopFixedRecords;
			int offsetWithinListForBottomFixedRecords = this._offsetWithinListForBottomFixedRecords;
			int offsetWithinListForScrollableRecords = this._offsetWithinListForScrollableRecords;
			int numberOfScrollableRecordsToLayout = this._numberOfScrollableRecordsToLayout;
			this._offsetWithinListForTopFixedRecords = 0;
			this._offsetWithinListForBottomFixedRecords = 0;
			this._offsetWithinListForScrollableRecords = 0;
			this._extentUsedByHeaderRecords = 0.0;
			this._fieldLayoutForHeaderRecordInAdorner = null;
			this._firstVisualBottomFixedItemIndex = 0;
			this._firstVisualTopFixedItemIndex = 0;
			this._firstVisualScrollableItemIndex = 0;
			this._visibleItemCount = 0;
			this._numberOfScrollableRecordsToLayout = 0;
			global::System.Windows.Size size4 = default(global::System.Windows.Size);
			int num5 = -1;
			bool flag2 = true;
			bool flag3 = true;
			double num6 = 0.0;
			int count2 = viewableRecords.Count;
			int countOfFixedRecordsOnTop = viewableRecords.CountOfFixedRecordsOnTop;
			int countOfFixedRecordsOnBottom = viewableRecords.CountOfFixedRecordsOnBottom;
			int num7 = count2 - (countOfFixedRecordsOnBottom + countOfFixedRecordsOnTop);
			int num8 = this.EffectiveScrollPosition;
			if (isRootPanel && num > 0 && !this._useScrollPositionCandidate && this._lastVerifiedFiltersVersion != viewableRecords._verifiedFiltersVersion)
			{
				this._lastVerifiedFiltersVersion = viewableRecords._verifiedFiltersVersion;
				global::Infragistics.Windows.DataPresenter.Record record2 = this.GetTopRecordFromScrollOffset(num8);
				if (record2 != null && num8 == this._lastOverallScrollPosition && num8 > 0 && base.DataPresenter != null && base.DataPresenter.ScrollBehaviorOnListChange == global::Infragistics.Windows.DataPresenter.ScrollBehaviorOnListChange.Default && record2 != this._lastRecordAtOverallScrollPosition && this._lastRecordAtOverallScrollPosition != null && this._lastRecordAtOverallScrollPosition.IsStillValid)
				{
					int scrollOffsetFromRecord = this.GetScrollOffsetFromRecord(this._lastRecordAtOverallScrollPosition);
					if (scrollOffsetFromRecord != this._lastOverallScrollPosition)
					{
						record2 = this._lastRecordAtOverallScrollPosition;
						num8 = scrollOffsetFromRecord;
						viewPanelInfo.OverallScrollPosition = num8;
					}
				}
				this._lastRecordAtOverallScrollPosition = record2;
			}
			global::Infragistics.Windows.Selection.ScrollDirection scrollDirection = (num8 < this._lastOverallScrollPosition) ? global::Infragistics.Windows.Selection.ScrollDirection.Decrement : global::Infragistics.Windows.Selection.ScrollDirection.Increment;
			base.BeginGeneration(scrollDirection, this.GetRecordsExpectedToBeGenerated(num8, numberOfScrollableRecordsToLayout, scrollDirection));
			this._lastMeasureScrollPosition = num8;
			this._lastOverallScrollPosition = num8;
			double num9 = 0.0;
			if (num > 0)
			{
				int rootTopFixedAdjustment = 0;
				if (isRootPanel)
				{
					rootTopFixedAdjustment = countOfFixedRecordsOnTop;
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.GridViewPanelNested gridViewPanelNested = this.RootPanel as global::Infragistics.Windows.DataPresenter.GridViewPanelNested;
					if (gridViewPanelNested != null)
					{
						global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords2 = gridViewPanelNested.ViewableRecords;
						if (viewableRecords2 != null)
						{
							rootTopFixedAdjustment = viewableRecords2.CountOfFixedRecordsOnTop;
						}
					}
				}
				int num10 = global::Infragistics.Windows.DataPresenter.GridViewPanelNested.CalculateLogicalListOffset(isRootPanel, viewPanelInfo, viewableRecords, countOfFixedRecordsOnTop, num8, rootTopFixedAdjustment);
				int num11;
				if (isRootPanel)
				{
					num11 = count2;
				}
				else
				{
					num11 = count2 - num10;
					if (num11 < 1)
					{
						if (!isRootPanel || (viewableRecords.FieldLayout != null && viewableRecords.FieldLayout.ChildRecordsDisplayOrderResolved != global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.AfterParent))
						{
							this._scrollPositionWhenNoChildrenAbovePresent = viewPanelInfo.OverallScrollPosition;
							if (this._rcdsInViewTracker == null)
							{
								this._rcdsInViewTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(base.DataPresenter, global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsInViewVersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnDataPresenterRecordsInViewChanged));
							}
						}
						base.EndGeneration();
						return new global::System.Windows.Size(1.0, 1.0);
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = viewableRecords[0].FieldLayout;
				global::Infragistics.Windows.DataPresenter.HeaderPlacement headerPlacement = (fieldLayout != null) ? fieldLayout.HeaderPlacementResolved : global::Infragistics.Windows.DataPresenter.HeaderPlacement.OnTopOnly;
				global::Infragistics.Windows.DataPresenter.Record record3 = null;
				global::Infragistics.Windows.DataPresenter.Record record4 = null;
				global::Infragistics.Windows.DataPresenter.Record record5 = null;
				global::Infragistics.Windows.DataPresenter.Record record6 = null;
				int numberOfScrollableRecordsToLayout2;
				global::System.Windows.Size size5 = this.GenerateRecordPresenters(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity), true, false, rootTopFixedAdjustment, headerPlacement, num11, ref record3, ref record6, ref fieldLayout, ref num5, out numberOfScrollableRecordsToLayout2);
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = fieldLayout;
				global::System.Windows.Size size6;
				if (num <= countOfFixedRecordsOnTop + num7)
				{
					size6 = default(global::System.Windows.Size);
				}
				else
				{
					fieldLayout = viewableRecords[countOfFixedRecordsOnTop + num7].FieldLayout;
					global::Infragistics.Windows.DataPresenter.Record record7 = null;
					size6 = this.GenerateRecordPresenters(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity), false, true, rootTopFixedAdjustment, headerPlacement, num11, ref record4, ref record7, ref fieldLayout, ref num5, out numberOfScrollableRecordsToLayout2);
				}
				num5 = -1;
				if (flag)
				{
					this._extentUsedByFixedRecordsOnTop = size5.Height;
					this._extentUsedByFixedRecordsOnBottom = size6.Height;
				}
				else
				{
					this._extentUsedByFixedRecordsOnTop = size5.Width;
					this._extentUsedByFixedRecordsOnBottom = size6.Width;
				}
				if (isRootPanel)
				{
					flag2 = (num4 >= this._extentUsedByFixedRecordsOnTop);
					flag3 = (num4 >= this._extentUsedByFixedRecordsOnTop + this._extentUsedByFixedRecordsOnBottom);
				}
				global::Infragistics.Windows.DataPresenter.Record record8 = null;
				if (isRootPanel)
				{
					num3 = num8;
				}
				if (num10 < 1)
				{
					if (count2 > countOfFixedRecordsOnTop)
					{
						record8 = viewableRecords[countOfFixedRecordsOnTop];
					}
				}
				else if (isRootPanel)
				{
					if (num4 <= 0.0)
					{
						this._offsetWithinListForScrollableRecords = count2;
						if (num10 < countOfFixedRecordsOnTop)
						{
							this._offsetWithinListForTopFixedRecords = num10;
							record8 = viewableRecords[num10];
						}
						else
						{
							this._offsetWithinListForTopFixedRecords = countOfFixedRecordsOnTop;
							record8 = viewableRecords[count2 - (countOfFixedRecordsOnBottom + 1)];
							if (num10 >= count2 - countOfFixedRecordsOnBottom)
							{
								this._offsetWithinListForBottomFixedRecords = num10 - (count2 - countOfFixedRecordsOnBottom);
							}
						}
					}
					else
					{
						this._offsetWithinListForScrollableRecords = global::System.Math.Max(0, global::System.Math.Min(num10, count2 - (countOfFixedRecordsOnTop + countOfFixedRecordsOnBottom + 1)));
						if (countOfFixedRecordsOnTop > 0)
						{
							record8 = viewableRecords[0];
						}
						else
						{
							record8 = viewableRecords[this._offsetWithinListForScrollableRecords + countOfFixedRecordsOnTop];
						}
					}
				}
				else
				{
					int num12 = num10;
					this._offsetWithinListForScrollableRecords = num10;
					if (num10 < num7)
					{
						record8 = viewableRecords[this._offsetWithinListForScrollableRecords + countOfFixedRecordsOnTop];
					}
					else
					{
						num12 -= num7;
					}
					if (record8 == null)
					{
						if (num12 < countOfFixedRecordsOnTop)
						{
							record8 = viewableRecords[this._offsetWithinListForTopFixedRecords];
						}
						else
						{
							num12 -= countOfFixedRecordsOnTop;
						}
					}
					if (record8 == null)
					{
						this._offsetWithinListForBottomFixedRecords = global::System.Math.Max(0, global::System.Math.Min(num12, countOfFixedRecordsOnBottom - 1));
						if (countOfFixedRecordsOnBottom > 0)
						{
							record8 = viewableRecords[this._offsetWithinListForBottomFixedRecords + count2 - countOfFixedRecordsOnBottom];
						}
						else if (countOfFixedRecordsOnTop > 0)
						{
							record8 = viewableRecords[global::System.Math.Max(0, countOfFixedRecordsOnTop + num7 + 1 - this._offsetWithinListForScrollableRecords)];
						}
					}
				}
				bool flag4 = false;
				if (record3 != null)
				{
					record8 = record3;
				}
				else if (record8 == null)
				{
					record8 = record4;
				}
				if (record8 != null && record8.FieldLayout != null && record8.FieldLayout.StyleGenerator == null && base.DataPresenter != null && base.DataPresenter.CurrentViewInternal != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator fieldLayoutTemplateGenerator = base.DataPresenter.CurrentViewInternal.GetFieldLayoutTemplateGenerator(record8.FieldLayout);
					if (fieldLayoutTemplateGenerator != null)
					{
						record8.FieldLayout.Initialize(fieldLayoutTemplateGenerator);
					}
				}
				if (record8 != null && record8.FieldLayout != null && record8.FieldLayout.LabelLocationResolved == global::Infragistics.Windows.DataPresenter.LabelLocation.SeparateHeader)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout3 = record8.FieldLayout;
					switch (record8.ParentCollection.RecordsType)
					{
					case global::Infragistics.Windows.DataPresenter.RecordType.DataRecord:
						if (!fieldLayout3.HasGroupBySortFields || fieldLayout3.HeaderPlacementInGroupByResolved == global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.WithDataRecords)
						{
							flag4 = true;
						}
						break;
					case global::Infragistics.Windows.DataPresenter.RecordType.GroupByField:
					case global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout:
						if (!(record8.ParentCollection.ParentRecord is global::Infragistics.Windows.DataPresenter.GroupByRecord) && (record8 is global::Infragistics.Windows.DataPresenter.FilterRecord || record8 is global::Infragistics.Windows.DataPresenter.SummaryRecord || fieldLayout3.HeaderPlacementInGroupByResolved == global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.OnTopOnly))
						{
							flag4 = true;
						}
						break;
					}
				}
				if (record8 is global::Infragistics.Windows.DataPresenter.HeaderRecord)
				{
					flag4 = false;
				}
				if (flag4)
				{
					this._fieldLayoutForHeaderRecordInAdorner = record8.FieldLayout;
					global::System.Windows.Size size7 = this._gridViewPanelAdorner.CreateAndMeasureHeaderRecordPresenter(record8, size3, flag, flag ? (-1.0 * base.ScrollingData._offset.X) : (-1.0 * base.ScrollingData._offset.Y));
					if (flag)
					{
						this._extentUsedByHeaderRecords = size7.Height;
						num9 = size7.Width;
					}
					else
					{
						this._extentUsedByHeaderRecords = size7.Width;
						num9 = size7.Height;
					}
				}
				num6 = this._extentUsedByFixedRecordsOnTop + this._extentUsedByFixedRecordsOnBottom + this._extentUsedByHeaderRecords;
				global::System.Windows.Size size8;
				if (num7 == 0 || this._offsetWithinListForScrollableRecords >= num7)
				{
					size8 = default(global::System.Windows.Size);
				}
				else
				{
					global::System.Windows.Size adjustedConstraint = size3;
					if (flag)
					{
						adjustedConstraint.Height = global::System.Math.Max(num4 - num6, 0.0);
					}
					else
					{
						adjustedConstraint.Width = global::System.Math.Max(num4 - num6, 0.0);
					}
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout4;
					if (countOfFixedRecordsOnTop == 0)
					{
						if (this._fieldLayoutForHeaderRecordInAdorner != null)
						{
							fieldLayout4 = this._fieldLayoutForHeaderRecordInAdorner;
						}
						else
						{
							fieldLayout4 = fieldLayout;
						}
					}
					else
					{
						fieldLayout4 = fieldLayout2;
					}
					size8 = this.GenerateRecordPresenters(adjustedConstraint, false, false, rootTopFixedAdjustment, headerPlacement, num11, ref record5, ref record6, ref fieldLayout4, ref num5, out numberOfScrollableRecordsToLayout2);
					this._numberOfScrollableRecordsToLayout = numberOfScrollableRecordsToLayout2;
					if (flag)
					{
						num6 += size8.Height;
					}
					else
					{
						num6 += size8.Width;
					}
				}
				this._firstVisualTopFixedItemIndex = this._offsetWithinListForTopFixedRecords;
				this._firstVisualScrollableItemIndex = countOfFixedRecordsOnTop + this._offsetWithinListForScrollableRecords;
				this._firstVisualBottomFixedItemIndex = countOfFixedRecordsOnTop + num7 + this._offsetWithinListForBottomFixedRecords;
				if (flag)
				{
					size4.Width = global::System.Math.Max(num9, global::System.Math.Max(global::System.Math.Max(size5.Width, size6.Width), size8.Width));
					size4.Height = num6;
				}
				else
				{
					size4.Width = num6;
					size4.Height = global::System.Math.Max(num9, global::System.Math.Max(global::System.Math.Max(size5.Height, size6.Height), size8.Height));
				}
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollection = viewableRecords.RecordCollection;
				if (!(recordCollection is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection))
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout5 = null;
					if (recordCollection.ParentRecord is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord)
					{
						if (((global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord)recordCollection.ParentRecord).CheckHasChildData())
						{
							fieldLayout5 = recordCollection.ParentRecordManager.FieldLayout;
						}
					}
					else if (recordCollection.ParentDataRecord == null)
					{
						global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = recordCollection.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord;
						if (groupByRecord != null)
						{
							fieldLayout5 = groupByRecord.FieldLayout;
						}
						else
						{
							fieldLayout5 = recordCollection.ParentRecordManager.FieldLayout;
						}
					}
					if (fieldLayout5 != null && fieldLayout5.LabelLocationResolved == global::Infragistics.Windows.DataPresenter.LabelLocation.SeparateHeader)
					{
						this._fieldLayoutForHeaderRecordInAdorner = fieldLayout5;
						global::System.Windows.Size size9 = this._gridViewPanelAdorner.CreateAndMeasureHeaderRecordPresenter(fieldLayout5.TemplateDataRecord, size3, flag, flag ? (-1.0 * base.ScrollingData._offset.X) : (-1.0 * base.ScrollingData._offset.Y));
						if (flag)
						{
							this._extentUsedByHeaderRecords = size9.Height;
							num9 = size9.Width;
							size4.Height = this._extentUsedByHeaderRecords;
						}
						else
						{
							this._extentUsedByHeaderRecords = size9.Width;
							num9 = size9.Height;
							size4.Width = this._extentUsedByHeaderRecords;
						}
						num6 = this._extentUsedByHeaderRecords;
					}
				}
			}
			this._nonPrimaryExtentUsedByHeaderRecords = num9;
			if (!this._useScrollPositionCandidate && (offsetWithinListForTopFixedRecords != this._offsetWithinListForTopFixedRecords || offsetWithinListForBottomFixedRecords != this._offsetWithinListForBottomFixedRecords || offsetWithinListForScrollableRecords != this._offsetWithinListForScrollableRecords || numberOfScrollableRecordsToLayout != this._numberOfScrollableRecordsToLayout))
			{
				this._recordsInViewChanged = true;
			}
			this._lastOrientationWasVertical = flag;
			if (this._fieldLayoutForHeaderRecordInAdorner == null && this._gridViewPanelAdorner != null)
			{
				this._gridViewPanelAdorner.ClearHeaderRecordPresenters();
			}
			if (flag)
			{
				if (size4.Width == 0.0)
				{
					size4.Width = num9;
				}
			}
			else if (size4.Height == 0.0)
			{
				size4.Height = num9;
			}
			if (base.IsScrolling || !isRootPanel)
			{
				global::System.Windows.Vector offset = base.ScrollingData._offset;
				global::System.Windows.Size viewport = size2;
				global::System.Windows.Size extent = size4;
				int num13 = this._numberOfScrollableRecordsToLayout;
				bool flag5 = false;
				if (isRootPanel)
				{
					if (flag)
					{
						flag5 = (size4.Height > size2.Height);
					}
					else
					{
						flag5 = (size4.Width > size2.Width);
					}
				}
				if (flag)
				{
					size4.Height = global::System.Math.Min(size4.Height, size2.Height);
				}
				else
				{
					size4.Width = global::System.Math.Min(size4.Width, size2.Width);
				}
				if (!flag3)
				{
					if (isRootPanel)
					{
						num7 = overallScrollCount - (countOfFixedRecordsOnTop + countOfFixedRecordsOnBottom);
					}
					num7 += countOfFixedRecordsOnBottom;
					num13 += countOfFixedRecordsOnBottom - this._offsetWithinListForBottomFixedRecords;
					if (!flag2)
					{
						num7 += countOfFixedRecordsOnTop;
						num13 += countOfFixedRecordsOnTop - this._offsetWithinListForTopFixedRecords;
					}
				}
				if ((isRootPanel && num7 > num13) || (flag3 && (flag5 || num3 > 0)))
				{
					num7 = overallScrollCount - (countOfFixedRecordsOnTop + countOfFixedRecordsOnBottom);
					if (num7 == num13)
					{
						num13--;
					}
				}
				num13 = global::System.Math.Max(1, num13);
				int num14 = global::System.Math.Max(1, num7);
				if (isRootPanel)
				{
					int overallScrollCount2 = viewPanelInfo.OverallScrollCount;
					if (overallScrollCount2 > num14)
					{
						num14 = global::System.Math.Max(num14, global::System.Math.Min(overallScrollCount2, overallScrollCount2 + num14 - count2));
					}
				}
				if (flag)
				{
					viewport.Height = (double)num13;
					extent.Height = (double)num14;
					offset.Y = (double)num3;
					offset.X = global::System.Math.Max(global::System.Math.Min(offset.X, extent.Width - viewport.Width), 0.0);
					viewport.Width = global::System.Math.Min(viewport.Width, extent.Width);
				}
				else
				{
					viewport.Width = (double)num13;
					extent.Width = (double)num14;
					offset.X = (double)num3;
					offset.Y = global::System.Math.Max(global::System.Math.Min(offset.Y, extent.Height - viewport.Height), 0.0);
					viewport.Height = global::System.Math.Min(viewport.Height, extent.Height);
				}
				if (isRootPanel)
				{
					if (this._widthInInfiniteContainer > 1.0)
					{
						if (offset.X > 0.0001)
						{
							size4.Width = global::System.Math.Max(this._widthInInfiniteContainer, size4.Width);
						}
						this._widthInInfiniteContainer = size4.Width;
					}
					if (this._heightInInfiniteContainer > 1.0)
					{
						if (offset.Y > 0.0001)
						{
							size4.Height = global::System.Math.Max(this._heightInInfiniteContainer, size4.Height);
						}
						this._heightInInfiniteContainer = size4.Height;
					}
				}
				if (base.IsScrolling)
				{
					this._cachedScrollDataFromMeasure = new global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData();
					this._cachedScrollDataFromMeasure._extent = extent;
					this._cachedScrollDataFromMeasure._viewport = viewport;
					this._cachedScrollDataFromMeasure._offset = offset;
					this._cachedRemainingAvailableExtentFromMeasure = global::System.Math.Max(num4 - num6, 0.0);
				}
			}
			this.SetBoundaryRecordFlags();
			size4.Width = global::System.Math.Max(size4.Width, 1.0);
			size4.Height = global::System.Math.Max(size4.Height, 1.0);
			base.EndGeneration();
			if (isRootPanel && num8 > 0)
			{
				if (flag)
				{
					if (!double.IsInfinity(size.Height))
					{
						size4.Height = size.Height;
					}
				}
				else if (!double.IsInfinity(size.Width))
				{
					size4.Width = size.Width;
				}
			}
			if (!isRootPanel && this._tracker == null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter4 = base.DataPresenter;
				if (dataPresenter4 != null)
				{
					this._tracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(dataPresenter4, global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollVersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnScrollVersionChanged));
				}
			}
			if (!isRootPanel && this._renderVersionTracker == null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter5 = base.DataPresenter;
				if (dataPresenter5 != null)
				{
					this._renderVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(dataPresenter5, global::Infragistics.Windows.DataPresenter.DataPresenterBase.RenderVersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnScrollVersionChanged));
				}
			}
			return size4;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00058B76 File Offset: 0x00056D76
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			if (base.IsHidingRecord)
			{
				return;
			}
			base.OnChildDesiredSizeChanged(child);
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x00058B88 File Offset: 0x00056D88
		protected override void OnClearChildren()
		{
			base.OnClearChildren();
			this._firstVisualBottomFixedItemIndex = 0;
			this._firstVisualScrollableItemIndex = 0;
			this._firstVisualTopFixedItemIndex = 0;
			this._numberOfScrollableRecordsToLayout = 0;
			this._visibleItemCount = 0;
			this._offsetWithinListForTopFixedRecords = 0;
			this._offsetWithinListForBottomFixedRecords = 0;
			this._offsetWithinListForScrollableRecords = 0;
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00058BC8 File Offset: 0x00056DC8
		protected override void OnItemsChanged(object sender, global::System.Windows.Controls.Primitives.ItemsChangedEventArgs args)
		{
			base.OnItemsChanged(sender, args);
			if (!this._useScrollPositionCandidate)
			{
				this._lastOverallScrollCount = -1;
				this._recordsInViewChanged = true;
			}
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00058BE8 File Offset: 0x00056DE8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("GridViewPanelNested: ");
			if (this.IsRootPanel)
			{
				stringBuilder.Append("Root");
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
				if (viewableRecords != null && viewableRecords.RecordCollection != null)
				{
					global::Infragistics.Windows.DataPresenter.Record parentRecord = viewableRecords.RecordCollection.ParentRecord;
					if (parentRecord != null)
					{
						stringBuilder.Append("Parent Record is ");
						stringBuilder.Append(parentRecord.ToString());
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00058C60 File Offset: 0x00056E60
		internal override void SetBoundaryRecordFlags()
		{
			if (this._visibleItemCount > 0)
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
				if (viewableRecords == null)
				{
					return;
				}
				int countOfFixedRecordsOnTop = viewableRecords.CountOfFixedRecordsOnTop;
				int countOfFixedRecordsOnBottom = viewableRecords.CountOfFixedRecordsOnBottom;
				int num = viewableRecords.Count - (countOfFixedRecordsOnTop + countOfFixedRecordsOnBottom);
				global::Infragistics.Windows.DataPresenter.Record record = viewableRecords[global::System.Math.Max(0, global::System.Math.Min(countOfFixedRecordsOnTop + num - 1, countOfFixedRecordsOnTop + this._offsetWithinListForScrollableRecords))];
				global::Infragistics.Windows.DataPresenter.Record record2 = null;
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
				int num2 = global::System.Math.Max(0, countOfFixedRecordsOnTop + num - 1);
				if (dataRecord != null)
				{
					int count = dataRecord.ParentCollection.Count;
					if (count > 0 && dataRecord.ParentCollection.SparseArray.GetItem(count - 1, false) == null)
					{
						num2 = -1;
					}
				}
				if (num2 >= 0)
				{
					record2 = viewableRecords[num2];
				}
				global::System.Collections.IList childElements = base.ChildElements;
				int count2 = childElements.Count;
				for (int i = 0; i < count2; i++)
				{
					global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(childElements[i] as global::System.Windows.DependencyObject);
					if (recordPresenterFromContainer != null)
					{
						global::Infragistics.Windows.DataPresenter.Record record3 = recordPresenterFromContainer.Record;
						recordPresenterFromContainer.IsBoundaryRecord = (record3 == record || record3 == record2);
					}
				}
			}
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x00058D74 File Offset: 0x00056F74
		internal override void SetOffsetInternal(double newOffset, double oldOffset, bool isSettingVerticalOffset)
		{
			try
			{
				global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData scrollingData = base.ScrollingData;
				bool flag = this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical;
				bool flag2 = flag == isSettingVerticalOffset;
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
								bool flag3 = flag2 && num2 > oldOffset + 1.0;
								global::Infragistics.Windows.DataPresenter.Record record = null;
								if (!flag2 && this._cachedScrollDataFromMeasure != null)
								{
									if (isSettingVerticalOffset)
									{
										if (this._cachedScrollDataFromMeasure._extent.Height <= this._cachedScrollDataFromMeasure._viewport.Height)
										{
											return;
										}
									}
									else if (this._cachedScrollDataFromMeasure._extent.Width <= this._cachedScrollDataFromMeasure._viewport.Width)
									{
										return;
									}
								}
								if (base.SetOffsetTriggeredByPageBack && flag2)
								{
									int overallScrollPosition = viewPanelInfo.OverallScrollPosition;
									if (overallScrollPosition > 0)
									{
										this.DetermineTopRecordForGivenBottomRecordIndex(ref record, ref num2, overallScrollPosition - 1);
									}
								}
								if (flag2)
								{
									bool flag4 = !scrollingData._isInDeferredDrag || scrollingData._scrollTip != null;
									if (flag4)
									{
										record = this.GetTopRecordFromScrollOffset((int)num2);
									}
									scrollingData.InitializeScrollTip(record);
									if (scrollingData._isInDeferredDrag)
									{
										scrollingData._deferredDragOffset = num2;
										return;
									}
									if (num2 == (double)viewPanelInfo.OverallScrollPosition)
									{
										return;
									}
									if (flag3 && num2 > 0.0 && scrollingData._averageHeightOfRecords >= 1.0)
									{
										double num3;
										if (isSettingVerticalOffset)
										{
											num3 = base.ActualHeight;
										}
										else
										{
											num3 = base.ActualWidth;
										}
										double num4 = 1.0 + num3 / global::System.Math.Max(15.0, scrollingData._averageHeightOfRecords / 2.0);
										int num5 = base.ViewPanelInfo.OverallScrollCount - 1;
										if ((double)num5 <= num2 + num4)
										{
											int num6 = (int)num2;
											int num7 = num6;
											while (num7 >= 0 && (double)num7 > oldOffset && this.WillLastRecordBeVisibleForGivenTopRecordIndex(num7))
											{
												num2 = (double)num7;
												num7--;
											}
											if ((double)num6 > num2)
											{
												record = this.GetTopRecordFromScrollOffset((int)num2);
											}
										}
									}
									this._recordsInViewChanged = true;
								}
								if (record != null)
								{
									global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
									if (viewableRecords == null)
									{
										return;
									}
									num2 = global::System.Math.Max(global::System.Math.Min(num2, (double)(viewPanelInfo.OverallScrollCount - (1 + viewableRecords.CountOfFixedRecordsOnTop + viewableRecords.CountOfFixedRecordsOnBottom))), 0.0);
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

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x00059120 File Offset: 0x00057320
		internal global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableRecords
		{
			get
			{
				return base.RecordListControl.ViewableRecords;
			}
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00059130 File Offset: 0x00057330
		private double ArrangeHelper(global::System.Windows.UIElement visualChildElement, bool orientationIsVertical, bool isReverseLayoutForBottomFixed, double extentUsedByLastItem, double clipExtent, global::System.Windows.Size arrangeSize, ref global::System.Windows.Rect arrangeRect)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(visualChildElement);
			if (recordPresenterFromContainer != null)
			{
				recordPresenterFromContainer.TreatAsCollapsed = false;
				if (recordPresenterFromContainer.ShouldDisplayRecordContent)
				{
					recordPresenterFromContainer.IsArrangedInView = true;
				}
			}
			if (orientationIsVertical)
			{
				arrangeRect.Height = visualChildElement.DesiredSize.Height;
				arrangeRect.Width = global::System.Math.Max(arrangeSize.Width, visualChildElement.DesiredSize.Width);
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
				arrangeRect.Width = visualChildElement.DesiredSize.Width;
				arrangeRect.Height = global::System.Math.Max(arrangeSize.Height, visualChildElement.DesiredSize.Height);
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
			bool shouldClip = !double.IsInfinity(clipExtent);
			global::Infragistics.Windows.DataPresenter.GridViewPanel.SetRecordPresenterClip(orientationIsVertical, extentUsedByLastItem, clipExtent, arrangeRect, shouldClip, recordPresenterFromContainer);
			visualChildElement.Arrange(arrangeRect);
			return extentUsedByLastItem;
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x000592A8 File Offset: 0x000574A8
		private static int CalculateLogicalListOffset(bool isRootPanel, global::Infragistics.Windows.DataPresenter.IViewPanelInfo info, global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords, int topFixedCount, int overallScrollPosition, int rootTopFixedAdjustment)
		{
			int overallScrollPosition2 = viewableRecords[0].OverallScrollPosition;
			int result = 0;
			int num = rootTopFixedAdjustment;
			if (!isRootPanel)
			{
				num += topFixedCount;
			}
			if (overallScrollPosition + num >= overallScrollPosition2)
			{
				global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition = info.GetRecordAtOverallScrollPosition(overallScrollPosition + num);
				global::Infragistics.Windows.DataPresenter.Record recordInThisCollectionFromDescendant = viewableRecords.GetRecordInThisCollectionFromDescendant(recordAtOverallScrollPosition);
				if (recordInThisCollectionFromDescendant != null)
				{
					result = viewableRecords.IndexOf(recordInThisCollectionFromDescendant) - topFixedCount;
				}
				else
				{
					result = overallScrollPosition + rootTopFixedAdjustment - overallScrollPosition2;
				}
			}
			return result;
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00059304 File Offset: 0x00057504
		private void DetermineTopRecordForGivenBottomRecordIndex(ref global::Infragistics.Windows.DataPresenter.Record newTopRecord, ref double newOffsetNormalized, int targetScrollIndexForLastVisibleRecord)
		{
			int num = -1;
			global::Infragistics.Windows.DataPresenter.Record record = this.GetTopRecordFromScrollOffset((int)newOffsetNormalized);
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = base.ViewPanelInfo;
			int num2 = 0;
			global::Infragistics.Windows.DataPresenter.GridViewPanelNested gridViewPanelNested = this.RootPanel as global::Infragistics.Windows.DataPresenter.GridViewPanelNested;
			try
			{
				this._useScrollPositionCandidate = true;
				global::Infragistics.Windows.DataPresenter.Record record2 = null;
				int num3 = -1;
				int num4 = 0;
				bool? flag = null;
				while (num != targetScrollIndexForLastVisibleRecord)
				{
					if (record != null)
					{
						this._scrollPositionCandidate = record.OverallScrollPosition;
						dataPresenter.BumpRecordsInViewVersion();
					}
					base.InvalidateMeasure();
					base.InvalidateArrange();
					base.UpdateLayout();
					int overallScrollPositionForRecord = viewPanelInfo.GetOverallScrollPositionForRecord(record);
					num = gridViewPanelNested._scrollPositionOfLastVisibleRecord;
					if (num == targetScrollIndexForLastVisibleRecord)
					{
						newTopRecord = record;
						newOffsetNormalized = (double)overallScrollPositionForRecord;
						break;
					}
					bool flag2 = num < targetScrollIndexForLastVisibleRecord;
					if (flag != null && flag.Value != flag2)
					{
						if (flag.Value)
						{
							newTopRecord = record;
							newOffsetNormalized = (double)overallScrollPositionForRecord;
							break;
						}
						newTopRecord = record2;
						newOffsetNormalized = (double)num3;
						break;
					}
					else
					{
						flag = new bool?(flag2);
						global::Infragistics.Windows.DataPresenter.Record record3;
						if (flag2)
						{
							record3 = viewPanelInfo.GetRecordAtOverallScrollPosition(overallScrollPositionForRecord + 1);
						}
						else if (overallScrollPositionForRecord > 0)
						{
							record3 = viewPanelInfo.GetRecordAtOverallScrollPosition(overallScrollPositionForRecord - 1);
						}
						else
						{
							record3 = null;
						}
						if (record3 == null)
						{
							newTopRecord = record;
							newOffsetNormalized = (double)overallScrollPositionForRecord;
							break;
						}
						if (record3 == record2 && num4 > 0)
						{
							if (global::System.Math.Abs(targetScrollIndexForLastVisibleRecord - num) < global::System.Math.Abs(targetScrollIndexForLastVisibleRecord - num3))
							{
								newTopRecord = record;
								newOffsetNormalized = (double)overallScrollPositionForRecord;
								break;
							}
							newTopRecord = record2;
							newOffsetNormalized = (double)viewPanelInfo.GetOverallScrollPositionForRecord(record2);
							break;
						}
						else
						{
							if (record3 == record2)
							{
								num4++;
							}
							record2 = record;
							num3 = overallScrollPositionForRecord;
							record = record3;
							num2++;
						}
					}
				}
			}
			finally
			{
				this._useScrollPositionCandidate = false;
			}
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x000594A4 File Offset: 0x000576A4
		private global::System.Windows.Size GenerateRecordPresenters(global::System.Windows.Size adjustedConstraint, bool topFixedRecordsOnly, bool bottomFixedRecordsOnly, int rootTopFixedAdjustment, global::Infragistics.Windows.DataPresenter.HeaderPlacement headerPlacement, int maxRecordsToGenerate, ref global::Infragistics.Windows.DataPresenter.Record topRecordDisplayed, ref global::Infragistics.Windows.DataPresenter.Record lastRecordDisplayed, ref global::Infragistics.Windows.DataPresenter.FieldLayout lastFieldLayout, ref int highestItemIndexProcessed, out int numberOfRecordsGenerated)
		{
			global::System.Windows.Size result = default(global::System.Windows.Size);
			numberOfRecordsGenerated = 0;
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
			if (viewableRecords == null)
			{
				return result;
			}
			int count = viewableRecords.Count;
			int num = 0;
			int num2 = -1;
			global::Infragistics.Windows.DataPresenter.GridViewSettings viewSettings = base.ViewSettings;
			if (viewSettings == null)
			{
				return result;
			}
			if (topFixedRecordsOnly)
			{
				int countOfFixedRecordsOnTop = viewableRecords.CountOfFixedRecordsOnTop;
				num = 0;
				if (countOfFixedRecordsOnTop > 0)
				{
					num2 = num + countOfFixedRecordsOnTop - 1;
				}
				if (countOfFixedRecordsOnTop > maxRecordsToGenerate)
				{
					num += countOfFixedRecordsOnTop - maxRecordsToGenerate;
				}
			}
			else if (bottomFixedRecordsOnly)
			{
				int countOfFixedRecordsOnBottom = viewableRecords.CountOfFixedRecordsOnBottom;
				num = viewableRecords.Count - countOfFixedRecordsOnBottom;
				if (countOfFixedRecordsOnBottom > 0)
				{
					num2 = num + countOfFixedRecordsOnBottom - 1;
				}
			}
			else
			{
				int countOfFixedRecordsOnTop2 = viewableRecords.CountOfFixedRecordsOnTop;
				int countOfFixedRecordsOnBottom2 = viewableRecords.CountOfFixedRecordsOnBottom;
				int num3 = count - (countOfFixedRecordsOnTop2 + countOfFixedRecordsOnBottom2);
				if (this._offsetWithinListForScrollableRecords < num3)
				{
					num = countOfFixedRecordsOnTop2 + this._offsetWithinListForScrollableRecords;
					num2 = countOfFixedRecordsOnTop2 + num3 - 1;
				}
			}
			if (num2 < num)
			{
				return result;
			}
			int num4 = 0;
			global::System.Windows.Controls.Primitives.GeneratorPosition generatorPositionFromItemIndex = base.GetGeneratorPositionFromItemIndex(num, out num4);
			int num5 = -1;
			int num6 = 0;
			global::Infragistics.Windows.DataPresenter.GridViewPanelNested gridViewPanelNested = this.RootPanel as global::Infragistics.Windows.DataPresenter.GridViewPanelNested;
			if (count > 0)
			{
				global::System.Windows.Controls.Primitives.IItemContainerGenerator generator = base.GetGenerator();
				using (generator.StartAt(generatorPositionFromItemIndex, global::System.Windows.Controls.Primitives.GeneratorDirection.Forward, true))
				{
					int num7 = num;
					int num8 = base.ChildElements.Count;
					bool flag = viewSettings.Orientation == global::System.Windows.Controls.Orientation.Vertical;
					double num9;
					if (flag)
					{
						num9 = adjustedConstraint.Height;
					}
					else
					{
						num9 = adjustedConstraint.Width;
					}
					bool flag2 = false;
					if (!topFixedRecordsOnly && !bottomFixedRecordsOnly && this == gridViewPanelNested)
					{
						global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Hidden;
						global::System.Windows.Controls.ScrollViewer scrollOwner = base.ScrollOwner;
						if (scrollOwner != null)
						{
							if (flag)
							{
								visibility = scrollOwner.ComputedHorizontalScrollBarVisibility;
							}
							else
							{
								visibility = scrollOwner.ComputedVerticalScrollBarVisibility;
							}
						}
						if (visibility == global::System.Windows.Visibility.Visible && num9 < this._lastScrollableExtentUsedInMeasureOnRootPanel)
						{
							num9 = this._lastScrollableExtentUsedInMeasureOnRootPanel;
							flag2 = true;
						}
						else if (visibility == global::System.Windows.Visibility.Collapsed)
						{
							this._lastScrollableExtentUsedInMeasureOnRootPanel = num9;
						}
					}
					while (num7 < count && num7 <= num2)
					{
						double num10 = 0.0;
						bool flag3;
						global::System.Windows.UIElement uielement = generator.GenerateNext(out flag3) as global::System.Windows.UIElement;
						if (uielement == null)
						{
							break;
						}
						if (flag3)
						{
							if (num5 < 0)
							{
								num5 = base.FindSlotForNewlyRealizedRecordPresenter(num7);
							}
							if (num5 >= num8)
							{
								base.AddInternalChild(uielement);
							}
							else
							{
								base.InsertInternalChild(num5, uielement);
							}
							num8++;
							generator.PrepareItemContainer(uielement);
						}
						global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenterFromContainer = global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(uielement);
						if (recordPresenterFromContainer != null)
						{
							global::Infragistics.Windows.DataPresenter.Record record = recordPresenterFromContainer.Record;
							if (record == null || record.VisibilityResolved == global::System.Windows.Visibility.Collapsed)
							{
								continue;
							}
							if (topRecordDisplayed == null)
							{
								topRecordDisplayed = record;
							}
							bool addHeader = false;
							if (record.ParentCollection.RecordsType == global::Infragistics.Windows.DataPresenter.RecordType.DataRecord && recordPresenterFromContainer.Visibility == global::System.Windows.Visibility.Visible && recordPresenterFromContainer.FieldLayout.LabelLocationResolved == global::Infragistics.Windows.DataPresenter.LabelLocation.SeparateHeader)
							{
								if (recordPresenterFromContainer.FieldLayout != lastFieldLayout)
								{
									addHeader = true;
								}
								else if (headerPlacement == global::Infragistics.Windows.DataPresenter.HeaderPlacement.OnRecordBreak && lastRecordDisplayed != null && lastRecordDisplayed.IsExpanded && lastRecordDisplayed.HasChildren && lastRecordDisplayed.ScrollCountInternal > 1)
								{
									addHeader = true;
								}
							}
							lastRecordDisplayed = record;
							recordPresenterFromContainer.InitializeHeaderContent(addHeader);
							recordPresenterFromContainer.TreatAsCollapsed = false;
							recordPresenterFromContainer.IsArrangedInView = true;
						}
						numberOfRecordsGenerated++;
						if (recordPresenterFromContainer != null)
						{
							global::Infragistics.Windows.DataPresenter.Record childsAncestorRecordInCollection = this.GetChildsAncestorRecordInCollection(this.EffectiveScrollPosition + rootTopFixedAdjustment, viewableRecords);
							bool flag4 = !recordPresenterFromContainer.Record.AreChildrenAfterParent || childsAncestorRecordInCollection != recordPresenterFromContainer.Record;
							if (!flag4)
							{
								flag4 = recordPresenterFromContainer.Record.IsFixed;
							}
							recordPresenterFromContainer.InitializeRecordContentVisibility(flag4);
							recordPresenterFromContainer.InitializeExpandableRecordContentVisibility(flag4);
							recordPresenterFromContainer.InitializeGroupByRecordContentVisibility(flag4);
							if (!flag3)
							{
								recordPresenterFromContainer.InitializeIsAlternate(true);
							}
							if (flag4 && !bottomFixedRecordsOnly)
							{
								num6 = global::System.Math.Max(num6, recordPresenterFromContainer.Record.OverallScrollPosition);
							}
						}
						lastFieldLayout = recordPresenterFromContainer.FieldLayout;
						if (num5 >= 0)
						{
							num5++;
						}
						this._visibleItemCount++;
						if (!flag3 && (flag2 || this._lastOrientationWasVertical != flag))
						{
							uielement.InvalidateMeasure();
						}
						uielement.Measure(adjustedConstraint);
						global::System.Windows.Size desiredSize = uielement.DesiredSize;
						if (flag)
						{
							num10 += desiredSize.Height;
							result.Width = global::System.Math.Max(result.Width, desiredSize.Width);
							result.Height += num10;
						}
						else
						{
							num10 += desiredSize.Width;
							result.Width += num10;
							result.Height = global::System.Math.Max(result.Height, desiredSize.Height);
						}
						num9 -= num10;
						num9 = global::System.Math.Max(num9, 0.0);
						if (num9 <= 0.0)
						{
							highestItemIndexProcessed = num7;
							break;
						}
						num7++;
					}
				}
			}
			if (!bottomFixedRecordsOnly)
			{
				int num11 = global::System.Math.Max(gridViewPanelNested._scrollPositionOfLastVisibleRecord, num6);
				if (this.IsRootPanel && !this._useScrollPositionCandidate && this._lastOverallScrollCount != base.ViewPanelInfo.OverallScrollCount)
				{
					num11 = highestItemIndexProcessed;
					this._lastOverallScrollCount = base.ViewPanelInfo.OverallScrollCount;
				}
				if (num11 != gridViewPanelNested._scrollPositionOfLastVisibleRecord)
				{
					gridViewPanelNested._scrollPositionOfLastVisibleRecord = num11;
					gridViewPanelNested.InvalidateArrange();
				}
			}
			return result;
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00059994 File Offset: 0x00057B94
		private global::Infragistics.Windows.DataPresenter.Record GetChildsAncestorRecordInCollection(int overallScrollPosition, global::Infragistics.Windows.DataPresenter.ViewableRecordCollection collection)
		{
			if (collection == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = base.ViewPanelInfo;
			global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition = viewPanelInfo.GetRecordAtOverallScrollPosition(overallScrollPosition);
			if (recordAtOverallScrollPosition == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Record recordInThisCollectionFromDescendant = collection.GetRecordInThisCollectionFromDescendant(recordAtOverallScrollPosition);
			if (recordInThisCollectionFromDescendant == recordAtOverallScrollPosition)
			{
				return null;
			}
			return recordInThisCollectionFromDescendant;
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x000599CC File Offset: 0x00057BCC
		internal global::Infragistics.Windows.DataPresenter.Record GetLastAbsoluteScrollableRecord()
		{
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
			if (viewableRecords == null)
			{
				return null;
			}
			for (int i = viewableRecords.ScrollCount - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.DataPresenter.Record recordAtScrollPosition = viewableRecords.GetRecordAtScrollPosition(i);
				if (recordAtScrollPosition != null && !recordAtScrollPosition.IsFixed)
				{
					return recordAtScrollPosition;
				}
			}
			return null;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00059A10 File Offset: 0x00057C10
		internal int GetLastAbsoluteScrollableRecordScrollPos()
		{
			global::Infragistics.Windows.DataPresenter.Record lastAbsoluteScrollableRecord = this.GetLastAbsoluteScrollableRecord();
			if (lastAbsoluteScrollableRecord == null)
			{
				return -1;
			}
			return lastAbsoluteScrollableRecord.OverallScrollPosition;
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00059A30 File Offset: 0x00057C30
		private global::System.Collections.IEnumerable GetRecordsExpectedToBeGenerated(int overallScrollPosition, int lastNumberOfScrollableRcds, global::Infragistics.Windows.Selection.ScrollDirection scrollDirection)
		{
			if (!this.IsRootPanel || base.ItemContainerGenerationModeResolved != global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
			if (viewableRecords == null)
			{
				return null;
			}
			int count = viewableRecords.Count;
			int countOfFixedRecordsOnTop = viewableRecords.CountOfFixedRecordsOnTop;
			int countOfFixedRecordsOnBottom = viewableRecords.CountOfFixedRecordsOnBottom;
			int num = 0;
			global::Infragistics.Windows.DataPresenter.Record topRecordFromScrollOffset = this.GetTopRecordFromScrollOffset(overallScrollPosition);
			int num2 = (topRecordFromScrollOffset != null) ? viewableRecords.IndexOf(topRecordFromScrollOffset) : -1;
			if (num2 >= 0)
			{
				int num3 = count - (countOfFixedRecordsOnTop + countOfFixedRecordsOnBottom);
				int num4 = (scrollDirection == global::Infragistics.Windows.Selection.ScrollDirection.Increment) ? 10 : -1;
				num = global::System.Math.Max(global::System.Math.Min(num3 - num2, lastNumberOfScrollableRcds + num4), 0);
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>(countOfFixedRecordsOnTop + countOfFixedRecordsOnBottom + num);
			for (int i = 0; i < countOfFixedRecordsOnTop; i++)
			{
				list.Add(viewableRecords[i]);
			}
			for (int j = 0; j < countOfFixedRecordsOnBottom; j++)
			{
				list.Add(viewableRecords[count - (j + 1)]);
			}
			for (int k = 0; k < num; k++)
			{
				list.Add(viewableRecords[num2 + k]);
			}
			return list;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00059B30 File Offset: 0x00057D30
		private void InitializeAdorner()
		{
			if (this._gridViewPanelAdorner != null)
			{
				return;
			}
			this._gridViewPanelAdorner = new global::Infragistics.Windows.DataPresenter.GridViewPanelAdorner(this);
			global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this);
			if (adornerLayer != null)
			{
				adornerLayer.Add(this._gridViewPanelAdorner);
			}
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00059B68 File Offset: 0x00057D68
		internal void OnHeaderExtentChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fl, double newExtent, double nonPrimaryExtent)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (!global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(nonPrimaryExtent, this._nonPrimaryExtentUsedByHeaderRecords))
			{
				base.InvalidateMeasure();
			}
			if (this._fieldLayoutForHeaderRecordInAdorner == null || this._fieldLayoutForHeaderRecordInAdorner != fl || fl.LabelLocationResolved != global::Infragistics.Windows.DataPresenter.LabelLocation.SeparateHeader)
			{
				return;
			}
			if (newExtent == this._extentUsedByHeaderRecords)
			{
				return;
			}
			this._extentUsedByHeaderRecords = newExtent;
			base.InvalidateArrange();
			base.InvalidateMeasure();
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00059BC8 File Offset: 0x00057DC8
		private void OnLayoutUpdated()
		{
			if (this.RootPanel != null)
			{
				base.InvalidateMeasure();
			}
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00059BD8 File Offset: 0x00057DD8
		private void OnLayoutUpdatedForArrange(object sender, global::System.EventArgs e)
		{
			base.LayoutUpdated -= this.OnLayoutUpdatedForArrange;
			base.InvalidateArrange();
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00059BF4 File Offset: 0x00057DF4
		private void OnDataPresenterRecordsInViewChanged()
		{
			if (base.DataPresenter == null)
			{
				this._rcdsInViewTracker = null;
				return;
			}
			if (this._scrollPositionWhenNoChildrenAbovePresent >= 0)
			{
				global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = base.ViewPanelInfo;
				if (viewPanelInfo != null && viewPanelInfo.OverallScrollPosition < this._scrollPositionWhenNoChildrenAbovePresent)
				{
					base.InvalidateMeasure();
				}
			}
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00059C3A File Offset: 0x00057E3A
		private void OnScrollVersionChanged()
		{
			if (base.IsVisible)
			{
				base.InvalidateMeasure();
			}
			this._tracker = null;
			this._renderVersionTracker = null;
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00059C58 File Offset: 0x00057E58
		private void PostBottomRecordVerification(global::System.Windows.Size availableScrollSize)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (dataPresenter == null || dataPresenter.IsReportControl)
			{
				return;
			}
			if (!this._useScrollPositionCandidate && this._isLastScrollableRecordFullyInView && this._queuedBottomRecordVerification == null)
			{
				this._queuedBottomRecordVerification = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::System.Windows.Threading.DispatcherOperationCallback(this.ProcessQueuedBottomRecordVerification), availableScrollSize);
			}
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00059CB8 File Offset: 0x00057EB8
		private object ProcessQueuedBottomRecordVerification(object args)
		{
			try
			{
				if (this._isProcessingBottomRecordVerification || !this._isLastScrollableRecordFullyInView || this._useScrollPositionCandidate)
				{
					return null;
				}
				int num = this.EffectiveScrollPosition;
				if (num == 0)
				{
					return null;
				}
				if ((global::System.Windows.Size)args == this._lastBottomRecordVerificationAvailableSize && (double)num == this._lastBottomRecordVerificationScrollPos)
				{
					return null;
				}
				this._lastBottomRecordVerificationAvailableSize = (global::System.Windows.Size)args;
				this._lastBottomRecordVerificationScrollPos = (double)this.EffectiveScrollPosition;
				this._isProcessingBottomRecordVerification = true;
				this._queuedBottomRecordVerification = null;
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
				if (viewableRecords == null)
				{
					return null;
				}
				bool flag = this.VerifyScrollPositionOfLastVisibleRecord(new global::System.Windows.Size(base.ActualWidth, base.ActualHeight));
				int scrollPositionOfLastVisibleRecord = this._scrollPositionOfLastVisibleRecord;
				int effectiveScrollPosition = this.EffectiveScrollPosition;
				int countOfFixedRecordsOnBottom = viewableRecords.CountOfFixedRecordsOnBottom;
				int count = viewableRecords.Count;
				int num2 = global::System.Math.Max(0, countOfFixedRecordsOnBottom - this._offsetWithinListForBottomFixedRecords);
				if (flag)
				{
					int num3;
					if (countOfFixedRecordsOnBottom > 0)
					{
						num3 = viewableRecords[count - (1 + num2)].OverallScrollPosition;
					}
					else
					{
						num3 = base.ViewPanelInfo.OverallScrollCount - 1;
					}
					this._isLastScrollableRecordFullyInView = (scrollPositionOfLastVisibleRecord >= num3 && scrollPositionOfLastVisibleRecord >= this.GetLastAbsoluteScrollableRecordScrollPos());
				}
				else
				{
					this._isLastScrollableRecordFullyInView = false;
				}
				if (!this._isLastScrollableRecordFullyInView)
				{
					global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData scrollingData = base.ScrollingData;
					this.VerifyScrollData(scrollingData._extent, scrollingData._viewport, scrollingData._offset, (global::System.Windows.Size)args);
					return null;
				}
				num = this.EffectiveScrollPosition;
				int num4 = num;
				int num5 = num;
				while (num >= 0 && this.WillLastRecordBeVisibleForGivenTopRecordIndex(num) && this.WillLastRecordBeVisibleForGivenTopRecordIndex(num))
				{
					num5 = num;
					num--;
				}
				if (num4 > num5)
				{
					if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
					{
						base.SetVerticalOffset((double)num5);
					}
					else
					{
						base.SetHorizontalOffset((double)num5);
					}
					base.UpdateLayout();
				}
				else
				{
					this.WillLastRecordBeVisibleForGivenTopRecordIndex(num4);
				}
			}
			finally
			{
				this._queuedBottomRecordVerification = null;
				this._isProcessingBottomRecordVerification = false;
			}
			return null;
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00059EB4 File Offset: 0x000580B4
		private bool VerifyScrollPositionOfLastVisibleRecord(global::System.Windows.Size panelSize)
		{
			global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = base.ViewPanelInfo;
			while (this._scrollPositionOfLastVisibleRecord > 0)
			{
				int num = this._scrollPositionOfLastVisibleRecord;
				global::Infragistics.Windows.DataPresenter.Record topRecordFromScrollOffset = this.GetTopRecordFromScrollOffset(num);
				if (topRecordFromScrollOffset != null)
				{
					while (topRecordFromScrollOffset != null && num > 0 && topRecordFromScrollOffset.ParentRecord == null && topRecordFromScrollOffset.IsFixed && !topRecordFromScrollOffset.IsOnTopWhenFixed)
					{
						num--;
						topRecordFromScrollOffset = this.GetTopRecordFromScrollOffset(num);
					}
					if (topRecordFromScrollOffset == null)
					{
						return true;
					}
					global::Infragistics.Windows.DataPresenter.RecordPresenter associatedRecordPresenter = topRecordFromScrollOffset.AssociatedRecordPresenter;
					if (associatedRecordPresenter != null && associatedRecordPresenter.IsVisible && associatedRecordPresenter.ShouldDisplayRecordContent)
					{
						global::System.Windows.FrameworkElement frameworkElement = associatedRecordPresenter.GetRecordContentSite();
						if (frameworkElement == null)
						{
							frameworkElement = associatedRecordPresenter;
						}
						global::System.Windows.Point point = frameworkElement.TranslatePoint(new global::System.Windows.Point(frameworkElement.ActualWidth, frameworkElement.ActualHeight), this);
						if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
						{
							if (panelSize.Height == 0.0 || (point.Y >= 0.0 && (point.Y <= panelSize.Height || global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(point.Y, panelSize.Height))))
							{
								return base.VerifyAllParentsAreInView(associatedRecordPresenter.Record, panelSize);
							}
						}
						else if (panelSize.Width == 0.0 || (point.X >= 0.0 && (point.X <= panelSize.Width || global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(point.X, panelSize.Width))))
						{
							return base.VerifyAllParentsAreInView(associatedRecordPresenter.Record, panelSize);
						}
					}
					if (associatedRecordPresenter == null)
					{
						int num2 = this._lastOverallScrollPosition;
						global::Infragistics.Windows.DataPresenter.Record record = this._lastRecordAtOverallScrollPosition;
						if (record != null && !this._useScrollPositionCandidate)
						{
							num2 = this.GetScrollOffsetFromRecord(record);
						}
						else
						{
							record = this.GetTopRecordFromScrollOffset(num2);
						}
						if (record == null)
						{
							return true;
						}
						int scrollPositionOfLastVisibleRecord = this._scrollPositionOfLastVisibleRecord;
						while (record != null)
						{
							record = this.GetTopRecordFromScrollOffset(num2);
							if (record != null && record.AssociatedRecordPresenter != null)
							{
								this._scrollPositionOfLastVisibleRecord = num2;
								if (num2 >= viewPanelInfo.OverallScrollCount)
								{
									return true;
								}
								num2++;
							}
							else
							{
								if (scrollPositionOfLastVisibleRecord > this._scrollPositionOfLastVisibleRecord)
								{
									this._scrollPositionOfLastVisibleRecord++;
									break;
								}
								return false;
							}
						}
					}
				}
				this._scrollPositionOfLastVisibleRecord--;
			}
			return false;
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x0005A0D4 File Offset: 0x000582D4
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
				double num5 = num4 / global::System.Math.Max(num2, 1.0);
				if (num == 0.0)
				{
					scrollingData._highestRecordDisplayed = num2;
					scrollingData._averageHeightOfRecords = num5;
				}
				else
				{
					double num6 = num + num2 - 1.0;
					if (num6 > scrollingData._highestRecordDisplayed)
					{
						scrollingData._averageHeightOfRecords = (scrollingData._averageHeightOfRecords * scrollingData._highestRecordDisplayed + (num6 - scrollingData._highestRecordDisplayed) * num5) / global::System.Math.Max(num6, 1.0);
						scrollingData._highestRecordDisplayed = num6;
					}
				}
				if (scrollingData._averageHeightOfRecords < 1.0)
				{
					scrollingData._averageHeightOfRecords = 1.0;
				}
				double num7 = global::System.Math.Max(num4 / scrollingData._averageHeightOfRecords - 1.0, 1.0);
				num7 = global::System.Math.Min(num7, global::System.Math.Max(num3 - (1.0 + num), 1.0));
				if (flag)
				{
					scrollingData._viewportForScrollbar.Height = num7;
					if (num7 < num3)
					{
						global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData scrollData = scrollingData;
						scrollData._extentForScrollbar.Height = scrollData._extentForScrollbar.Height + global::System.Math.Min(global::System.Math.Min(2.0, num3 - num7), num7);
					}
					if (this._isLastScrollableRecordFullyInView)
					{
						scrollingData._viewportForScrollbar.Height = global::System.Math.Max(scrollingData._extentForScrollbar.Height - scrollingData._offset.Y, 1.0);
					}
				}
				else
				{
					scrollingData._viewportForScrollbar.Width = num7;
					if (num7 < num3)
					{
						global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData scrollData2 = scrollingData;
						scrollData2._extentForScrollbar.Width = scrollData2._extentForScrollbar.Width + global::System.Math.Min(global::System.Math.Min(2.0, num3 - num7), num7);
					}
					if (this._isLastScrollableRecordFullyInView)
					{
						scrollingData._viewportForScrollbar.Width = global::System.Math.Max(scrollingData._extentForScrollbar.Width - scrollingData._offset.X, 1.0);
					}
				}
				if (!base.CanRecordsBeScrolled)
				{
					if (flag)
					{
						scrollingData._offset.Y = 0.0;
						scrollingData._extent.Height = 1.0;
						scrollingData._extentForScrollbar.Height = 1.0;
						scrollingData._viewport.Height = 2.0;
						scrollingData._viewportForScrollbar.Height = 2.0;
					}
					else
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

		// Token: 0x06001448 RID: 5192 RVA: 0x0005A48C File Offset: 0x0005868C
		private bool WillLastRecordBeVisibleForGivenTopRecordIndex(int scrollPositionCandidateForFirstVisibleRecord)
		{
			bool isScrollPositionCandidateFullyInView;
			try
			{
				this._useScrollPositionCandidate = true;
				this._isScrollPositionCandidateFullyInView = false;
				this._scrollPositionCandidate = scrollPositionCandidateForFirstVisibleRecord;
				base.DataPresenter.BumpRecordsInViewVersion();
				base.InvalidateMeasure();
				base.InvalidateArrange();
				base.UpdateLayout();
				isScrollPositionCandidateFullyInView = this._isScrollPositionCandidateFullyInView;
			}
			finally
			{
				this._useScrollPositionCandidate = false;
			}
			return isScrollPositionCandidateFullyInView;
		}

		// Token: 0x0400079C RID: 1948
		private global::Infragistics.Windows.DataPresenter.GridViewPanelNested _rootPanel;

		// Token: 0x0400079D RID: 1949
		private global::System.Windows.Threading.DispatcherOperation _queuedBottomRecordVerification;

		// Token: 0x0400079E RID: 1950
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayoutForHeaderRecordInAdorner;

		// Token: 0x0400079F RID: 1951
		private int _firstVisualScrollableItemIndex;

		// Token: 0x040007A0 RID: 1952
		private int _firstVisualTopFixedItemIndex;

		// Token: 0x040007A1 RID: 1953
		private int _firstVisualBottomFixedItemIndex;

		// Token: 0x040007A2 RID: 1954
		private int _visibleItemCount;

		// Token: 0x040007A3 RID: 1955
		private int _scrollPositionCandidate;

		// Token: 0x040007A4 RID: 1956
		private int _scrollPositionOfLastVisibleRecord;

		// Token: 0x040007A5 RID: 1957
		private global::System.Windows.Size _lastMeasureConstraint;

		// Token: 0x040007A6 RID: 1958
		private global::Infragistics.Windows.DataPresenter.GridViewPanel.ScrollData _cachedScrollDataFromMeasure;

		// Token: 0x040007A7 RID: 1959
		private double _cachedRemainingAvailableExtentFromMeasure;

		// Token: 0x040007A8 RID: 1960
		private int _lastViewportHeight;

		// Token: 0x040007A9 RID: 1961
		private int _lastViewportWidth;

		// Token: 0x040007AA RID: 1962
		private int _lastOverallScrollPosition;

		// Token: 0x040007AB RID: 1963
		private int _lastMeasureScrollPosition;

		// Token: 0x040007AC RID: 1964
		private global::Infragistics.Windows.DataPresenter.Record _lastRecordAtOverallScrollPosition;

		// Token: 0x040007AD RID: 1965
		private int _lastOverallScrollCount;

		// Token: 0x040007AE RID: 1966
		private int _offsetWithinListForTopFixedRecords;

		// Token: 0x040007AF RID: 1967
		private int _offsetWithinListForBottomFixedRecords;

		// Token: 0x040007B0 RID: 1968
		private int _offsetWithinListForScrollableRecords;

		// Token: 0x040007B1 RID: 1969
		private int _numberOfScrollableRecordsToLayout;

		// Token: 0x040007B2 RID: 1970
		private bool _useScrollPositionCandidate;

		// Token: 0x040007B3 RID: 1971
		private bool _recordsInViewChanged;

		// Token: 0x040007B4 RID: 1972
		private bool _lastOrientationWasVertical;

		// Token: 0x040007B5 RID: 1973
		private bool _isRootPanelInInfiniteContainer;

		// Token: 0x040007B6 RID: 1974
		private bool _isLastScrollableRecordFullyInView;

		// Token: 0x040007B7 RID: 1975
		private bool _isScrollPositionCandidateFullyInView;

		// Token: 0x040007B8 RID: 1976
		private bool _isProcessingBottomRecordVerification;

		// Token: 0x040007B9 RID: 1977
		private global::Infragistics.Windows.DataPresenter.GridViewPanelAdorner _gridViewPanelAdorner;

		// Token: 0x040007BA RID: 1978
		private double _extentUsedByFixedRecordsOnTop;

		// Token: 0x040007BB RID: 1979
		private double _extentUsedByFixedRecordsOnBottom;

		// Token: 0x040007BC RID: 1980
		private double _extentUsedByHeaderRecords;

		// Token: 0x040007BD RID: 1981
		private double _widthInInfiniteContainer;

		// Token: 0x040007BE RID: 1982
		private double _heightInInfiniteContainer;

		// Token: 0x040007BF RID: 1983
		private double _lastScrollableExtentUsedInMeasureOnRootPanel;

		// Token: 0x040007C0 RID: 1984
		private int _lastOverallSortVersion;

		// Token: 0x040007C1 RID: 1985
		private global::System.Windows.Size _lastBottomRecordVerificationAvailableSize = new global::System.Windows.Size(0.0, 0.0);

		// Token: 0x040007C2 RID: 1986
		private double _lastBottomRecordVerificationScrollPos;

		// Token: 0x040007C3 RID: 1987
		private double _nonPrimaryExtentUsedByHeaderRecords;

		// Token: 0x040007C4 RID: 1988
		private global::Infragistics.Windows.Internal.PropertyValueTracker _tracker;

		// Token: 0x040007C5 RID: 1989
		private global::Infragistics.Windows.Internal.PropertyValueTracker _renderVersionTracker;

		// Token: 0x040007C6 RID: 1990
		private int _lastVerifiedFiltersVersion;

		// Token: 0x040007C7 RID: 1991
		private int _scrollPositionWhenNoChildrenAbovePresent = -1;

		// Token: 0x040007C8 RID: 1992
		private global::Infragistics.Windows.Internal.PropertyValueTracker _rcdsInViewTracker;
	}
}
