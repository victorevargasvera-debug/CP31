using System;
using System.Collections.Generic;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;
using Infragistics.Windows.DataPresenter.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200018F RID: 399
	internal class FieldGridBagLayoutManager : global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager
	{
		// Token: 0x0600192C RID: 6444 RVA: 0x000740E0 File Offset: 0x000722E0
		internal FieldGridBagLayoutManager(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.LayoutManagerType type)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(fieldLayout);
			this._fieldLayout = fieldLayout;
			this._type = type;
			this._fieldItemMap = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey, global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase>();
			this._cachedDimensions = new global::System.Collections.Generic.Dictionary<global::System.Windows.Rect, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection>();
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x00074134 File Offset: 0x00072334
		public override void InvalidateLayout()
		{
			this.InvalidateLayoutCount++;
			this._cachedDimensions.Clear();
			global::System.Windows.Size? cachedPreferredSize = null;
			this._cachedPreferredSize = cachedPreferredSize;
			this._cachedMaxSize = (this._cachedMinSize = (this._cachedPreferredSize = cachedPreferredSize));
			this._cachedSizingMode = null;
			base.InvalidateLayout();
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x00074194 File Offset: 0x00072394
		internal global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel CellPanel
		{
			get
			{
				return this._cellPanel;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x0007419C File Offset: 0x0007239C
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x000741A4 File Offset: 0x000723A4
		public global::Infragistics.Windows.DataPresenter.DataRecordSizingMode RecordSizingMode
		{
			get
			{
				if (this._cachedSizingMode == null)
				{
					this._cachedSizingMode = new global::Infragistics.Windows.DataPresenter.DataRecordSizingMode?(this.CalculateSizingMode());
				}
				return this._cachedSizingMode.Value;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x000741CF File Offset: 0x000723CF
		// (set) Token: 0x06001932 RID: 6450 RVA: 0x000741D7 File Offset: 0x000723D7
		internal global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
			set
			{
				this._record = value;
				this._cachedSizingMode = null;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x000741EC File Offset: 0x000723EC
		internal global::Infragistics.Windows.DataPresenter.LayoutManagerType Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x000741F4 File Offset: 0x000723F4
		internal void CalculateCellPresenterRects(global::Infragistics.Windows.DataPresenter.FieldRectsLayoutContainer lcRects, global::System.Windows.Size containerSize, global::System.Windows.Rect[] cellRects)
		{
			for (int i = 0; i < cellRects.Length; i++)
			{
				cellRects[i] = default(global::System.Windows.Rect);
			}
			global::System.Windows.Rect value = default(global::System.Windows.Rect);
			this.LayoutContainer(lcRects, new global::System.Windows.Rect(containerSize));
			global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache templateDataRecordCache = this._fieldLayout.TemplateDataRecordCache;
			foreach (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)base.LayoutItems))
			{
				global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase = layoutItem as global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase;
				if (fieldLayoutItemBase != null && ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)fieldLayoutItemBase).Visibility != global::System.Windows.Visibility.Collapsed)
				{
					global::System.Windows.Rect rect = lcRects[fieldLayoutItemBase];
					global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gridBagConstraint = (global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)base.LayoutItems.GetConstraint(fieldLayoutItemBase);
					global::System.Windows.Thickness cellPresenterMargin = templateDataRecordCache.GetCellPresenterMargin(fieldLayoutItemBase.Field);
					global::System.Windows.Rect value2 = rect;
					value2.Offset(-cellPresenterMargin.Left, -cellPresenterMargin.Top);
					lcRects[fieldLayoutItemBase] = value2;
					global::System.Windows.Thickness margin = gridBagConstraint.Margin;
					rect.Offset(-margin.Left, -margin.Top);
					rect.Width = global::System.Math.Max(rect.Width + margin.Left + margin.Right, 0.0);
					rect.Height = global::System.Math.Max(rect.Height + margin.Top + margin.Bottom, 0.0);
					if (!rect.Equals(value))
					{
						int templateCellIndex = fieldLayoutItemBase.Field.TemplateCellIndex;
						global::System.Windows.Rect rect2 = cellRects[templateCellIndex];
						if (rect2.Equals(value))
						{
							rect2 = rect;
						}
						else
						{
							rect2 = global::Infragistics.Windows.DataPresenter.GridUtilities.Union(ref rect2, ref rect);
						}
						cellRects[templateCellIndex] = rect2;
					}
				}
			}
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x000743CC File Offset: 0x000725CC
		internal global::System.Windows.Size CalculateMaximumSize()
		{
			if (this._cachedMaxSize == null)
			{
				this._cachedMaxSize = new global::System.Windows.Size?(this.CalculateMaximumSize(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.InfiniteRect));
			}
			return this._cachedMaxSize.Value;
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00074401 File Offset: 0x00072601
		internal global::System.Windows.Size CalculateMinimumSize()
		{
			if (this._cachedMinSize == null)
			{
				this._cachedMinSize = new global::System.Windows.Size?(this.CalculateMinimumSize(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.InfiniteRect));
			}
			return this._cachedMinSize.Value;
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00074436 File Offset: 0x00072636
		internal global::System.Windows.Size CalculatePreferredSize()
		{
			if (this._cachedPreferredSize == null)
			{
				this._cachedPreferredSize = new global::System.Windows.Size?(this.CalculatePreferredSize(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.InfiniteRect));
			}
			return this._cachedPreferredSize.Value;
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x0007446C File Offset: 0x0007266C
		internal global::Infragistics.Windows.DataPresenter.DataRecordSizingMode CalculateSizingMode()
		{
			global::Infragistics.Windows.DataPresenter.Record record = this._record;
			if (record == null && this._cellPanel != null)
			{
				record = this._cellPanel.Record;
			}
			return global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.CalculateSizingMode(record, this._fieldLayout, (this._cellPanel != null) ? this._cellPanel.IsHeaderArea : (this._type == global::Infragistics.Windows.DataPresenter.LayoutManagerType.Header));
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x000744C4 File Offset: 0x000726C4
		internal static global::Infragistics.Windows.DataPresenter.DataRecordSizingMode CalculateSizingMode(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool isHeaderArea)
		{
			if (isHeaderArea || record is global::Infragistics.Windows.DataPresenter.SummaryRecord)
			{
				return global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizedToContentAndFixed;
			}
			global::Infragistics.Windows.DataPresenter.DataRecordSizingMode dataRecordSizingModeResolved = fieldLayout.DataRecordSizingModeResolved;
			global::Infragistics.Windows.DataPresenter.FilterRecord filterRecord = record as global::Infragistics.Windows.DataPresenter.FilterRecord;
			if (filterRecord != null && dataRecordSizingModeResolved == global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizableSynchronized)
			{
				return global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.IndividuallySizable;
			}
			return dataRecordSizingModeResolved;
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x000744F6 File Offset: 0x000726F6
		internal global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager Clone()
		{
			return this.Clone(null);
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00074500 File Offset: 0x00072700
		internal global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager Clone(global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo)
		{
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager fieldGridBagLayoutManager = global::Infragistics.Windows.DataPresenter.GridUtilities.CreateGridBagLayoutManager(this._fieldLayout, this._type);
			fieldGridBagLayoutManager._sourceManager = this;
			fieldGridBagLayoutManager._layoutInfo = layoutInfo;
			return fieldGridBagLayoutManager;
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00074530 File Offset: 0x00072730
		internal static global::System.Collections.Generic.IList<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> ConvertLayoutItems(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase> items)
		{
			if (items == null)
			{
				return null;
			}
			global::Infragistics.Controls.Layouts.Primitives.ILayoutItem[] array = new global::Infragistics.Controls.Layouts.Primitives.ILayoutItem[items.Count];
			int i = 0;
			int count = items.Count;
			while (i < count)
			{
				array[i] = items[i];
				i++;
			}
			return array;
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x0007456C File Offset: 0x0007276C
		internal global::Infragistics.Windows.DataPresenter.LayoutInfo CreateLayoutInfo(bool useFieldConstraint)
		{
			global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo = new global::Infragistics.Windows.DataPresenter.LayoutInfo(this._fieldLayout);
			foreach (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)base.LayoutItems))
			{
				global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase = layoutItem as global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase;
				if (fieldLayoutItemBase != null)
				{
					global::Infragistics.Windows.DataPresenter.Field field = fieldLayoutItemBase.Field;
					global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gridBagConstraint = useFieldConstraint ? field.LayoutConstraint : (base.LayoutItems.GetConstraint(fieldLayoutItemBase) as global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint);
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo;
					if (!layoutInfo.TryGetValue(field, out itemLayoutInfo))
					{
						itemLayoutInfo = new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(gridBagConstraint.Column, gridBagConstraint.Row, gridBagConstraint.ColumnSpan, gridBagConstraint.RowSpan);
						itemLayoutInfo._fixedLocation = fieldLayoutItemBase.FixedLocation;
						itemLayoutInfo.Visibility = field.VisibilityInCellArea;
						layoutInfo[field] = itemLayoutInfo;
					}
					else if (!useFieldConstraint)
					{
						int num = global::System.Math.Min(itemLayoutInfo.Column, gridBagConstraint.Column);
						itemLayoutInfo.ColumnSpan = global::System.Math.Max(itemLayoutInfo.Column + itemLayoutInfo.ColumnSpan, gridBagConstraint.Column + gridBagConstraint.ColumnSpan) - num;
						itemLayoutInfo.Column = num;
						int num2 = global::System.Math.Min(itemLayoutInfo.Row, gridBagConstraint.Row);
						itemLayoutInfo.RowSpan = global::System.Math.Max(itemLayoutInfo.Row + itemLayoutInfo.RowSpan, gridBagConstraint.Row + gridBagConstraint.RowSpan) - num2;
						itemLayoutInfo.Row = num2;
					}
				}
			}
			return layoutInfo;
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x000746FC File Offset: 0x000728FC
		internal void CreateUndoSnapshot(bool resizeInXAxis, global::Infragistics.Windows.DataPresenter.Record targetRecord)
		{
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
			if (dataPresenter == null || !dataPresenter.IsUndoEnabled)
			{
				return;
			}
			if (targetRecord == null)
			{
				global::Infragistics.Windows.DataPresenter.FieldResizeInfoAction fieldResizeInfoAction = global::Infragistics.Windows.DataPresenter.FieldResizeInfoAction.Create(this._fieldLayout, resizeInXAxis);
				if (fieldResizeInfoAction != null)
				{
					dataPresenter.History.AddUndoActionInternal(fieldResizeInfoAction);
					return;
				}
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.ResizeRecordAction resizeRecordAction = global::Infragistics.Windows.DataPresenter.ResizeRecordAction.Create(targetRecord, resizeInXAxis);
				if (resizeRecordAction != null)
				{
					dataPresenter.History.AddUndoActionInternal(resizeRecordAction);
				}
			}
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00074764 File Offset: 0x00072964
		internal double GetPreferredExtent(int origin, int span, bool column)
		{
			if (this._fieldLayout.UseCellPresenters)
			{
				origin *= 2;
				span *= 2;
			}
			global::System.Windows.Size size = this.CalculatePreferredSize();
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection layoutItemDimensionsCached = this.GetLayoutItemDimensionsCached(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, new global::System.Windows.Rect(size));
			double[] array = column ? layoutItemDimensionsCached.ColumnDims : layoutItemDimensionsCached.RowDims;
			return array[origin + span] - array[origin];
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x000747C4 File Offset: 0x000729C4
		internal global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase GetLayoutItem(global::Infragistics.Windows.DataPresenter.Field field, bool isLabel)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase result = null;
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey key = new global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey(field, isLabel);
			this._fieldItemMap.TryGetValue(key, out result);
			return result;
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x000747EC File Offset: 0x000729EC
		internal global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection GetLayoutItemDimensionsCached(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer layoutContainer, object containerContext)
		{
			global::System.Windows.Rect bounds = layoutContainer.GetBounds(containerContext);
			return this.GetLayoutItemDimsCachedHelper(layoutContainer, containerContext, bounds);
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x0007480C File Offset: 0x00072A0C
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection GetLayoutItemDimsCachedHelper(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer layoutContainer, object containerContext, global::System.Windows.Rect rect)
		{
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection layoutItemDimensions;
			if (this._cachedDimensions.TryGetValue(rect, out layoutItemDimensions))
			{
				return layoutItemDimensions;
			}
			layoutItemDimensions = base.GetLayoutItemDimensions(layoutContainer, containerContext);
			this._cachedDimensions[rect] = layoutItemDimensions;
			return layoutItemDimensions;
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00074844 File Offset: 0x00072A44
		private void Initialize()
		{
			if (this._fieldLayout.AlignmentFieldLayout != null)
			{
				this.InitializeFromAlignmentFieldLayout();
				return;
			}
			this._fieldLayout.VerifyStyleGeneratorTemplates();
			bool useCellPresenters = this._fieldLayout.UseCellPresenters;
			base.LayoutItems.Clear();
			bool flag = this._type == global::Infragistics.Windows.DataPresenter.LayoutManagerType.Header;
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fieldLayout.GetAllFields(false))
			{
				if (flag || useCellPresenters)
				{
					base.LayoutItems.Add(field.LabelLayoutItem, field.LabelLayoutConstraint);
				}
				if (!flag)
				{
					base.LayoutItems.Add(field.CellLayoutItem, field.CellLayoutConstraint);
				}
			}
			this.InitializeItemMap();
			foreach (global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem gridDefinitionLayoutItem in this._fieldLayout.TemplateDataRecordCache.GridColumnLayoutItems)
			{
				base.LayoutItems.Add(gridDefinitionLayoutItem, gridDefinitionLayoutItem);
			}
			foreach (global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem gridDefinitionLayoutItem2 in this._fieldLayout.TemplateDataRecordCache.GridRowLayoutItems)
			{
				base.LayoutItems.Add(gridDefinitionLayoutItem2, gridDefinitionLayoutItem2);
			}
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x000749B8 File Offset: 0x00072BB8
		private void InitializeFrom(global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager sourceManager)
		{
			sourceManager.VerifyLayout();
			global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>();
			bool flag = false;
			switch (this.RecordSizingMode)
			{
			case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.IndividuallySizable:
			case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizedToContentAndIndividuallySizable:
				flag = true;
				break;
			}
			int i = 0;
			int count = base.LayoutItems.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem wrapperLayoutItem = base.LayoutItems[i] as global::Infragistics.Windows.DataPresenter.IWrapperLayoutItem;
				if (wrapperLayoutItem != null)
				{
					dictionary[wrapperLayoutItem.InnerLayoutItem] = base.LayoutItems[i];
					global::Infragistics.Windows.DataPresenter.CellLayoutItem cellLayoutItem = wrapperLayoutItem as global::Infragistics.Windows.DataPresenter.CellLayoutItem;
					if (cellLayoutItem != null)
					{
						cellLayoutItem.ForceUnfixed = false;
					}
					if (!flag)
					{
						wrapperLayoutItem.ExplicitWidth = null;
						wrapperLayoutItem.ExplicitHeight = null;
					}
				}
				i++;
			}
			base.LayoutItems.Clear();
			int j = 0;
			int count2 = sourceManager.LayoutItems.Count;
			while (j < count2)
			{
				global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem = sourceManager.LayoutItems[j];
				global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gridBagConstraint = sourceManager.LayoutItems.GetConstraint(layoutItem) as global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint;
				global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem2;
				if (!dictionary.TryGetValue(layoutItem, out layoutItem2))
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase = layoutItem as global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase;
					if (fieldLayoutItemBase != null)
					{
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = null;
						if (this._layoutInfo != null)
						{
							itemLayoutInfo = this._layoutInfo[fieldLayoutItemBase.Field];
						}
						global::Infragistics.Windows.DataPresenter.CellLayoutItem cellLayoutItem2;
						if (itemLayoutInfo == null)
						{
							cellLayoutItem2 = new global::Infragistics.Windows.DataPresenter.CellLayoutItem(fieldLayoutItemBase);
						}
						else
						{
							cellLayoutItem2 = new global::Infragistics.Windows.DataPresenter.ItemLayoutInfoLayoutItem(fieldLayoutItemBase, gridBagConstraint, itemLayoutInfo);
						}
						cellLayoutItem2.LayoutManager = this;
						layoutItem2 = cellLayoutItem2;
					}
					else if (layoutItem is global::Infragistics.Windows.DataPresenter.LayoutItem)
					{
						layoutItem2 = new global::Infragistics.Windows.DataPresenter.WrapperLayoutItem((global::Infragistics.Windows.DataPresenter.LayoutItem)layoutItem);
					}
					else
					{
						layoutItem2 = layoutItem;
					}
				}
				if (layoutItem2 is global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)
				{
					gridBagConstraint = (global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint)layoutItem2;
				}
				base.LayoutItems.Add(layoutItem2, gridBagConstraint);
				j++;
			}
			this.InitializeItemMap();
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00074B70 File Offset: 0x00072D70
		private void InitializeFromAlignmentFieldLayout()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this._fieldLayout.AlignmentFieldLayout;
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager fieldGridBagLayoutManager;
			if (this._type == global::Infragistics.Windows.DataPresenter.LayoutManagerType.Header)
			{
				fieldGridBagLayoutManager = alignmentFieldLayout.LabelLayoutManager;
			}
			else
			{
				fieldGridBagLayoutManager = alignmentFieldLayout.CellLayoutManager;
			}
			this._cachedMaxSize = fieldGridBagLayoutManager._cachedMaxSize;
			this._cachedMinSize = fieldGridBagLayoutManager._cachedMinSize;
			this._cachedPreferredSize = fieldGridBagLayoutManager._cachedPreferredSize;
			this._cachedSizingMode = new global::Infragistics.Windows.DataPresenter.DataRecordSizingMode?(this.CalculateSizingMode());
			this._cachedDimensions.Clear();
			this._fieldItemMap.Clear();
			global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection layoutItems = base.LayoutItems;
			layoutItems.Clear();
			global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection layoutItems2 = fieldGridBagLayoutManager.LayoutItems;
			int count = layoutItems2.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase = layoutItems2[i] as global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase;
				if (fieldLayoutItemBase != null)
				{
					global::Infragistics.Windows.DataPresenter.Field fieldFromMappedField = this._fieldLayout.GetFieldFromMappedField(fieldLayoutItemBase.FieldForPositioning);
					if (fieldFromMappedField != null)
					{
						global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint constraint = layoutItems2.GetConstraint(fieldLayoutItemBase) as global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint;
						global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase2 = fieldLayoutItemBase.Clone(fieldFromMappedField);
						layoutItems.Add(fieldLayoutItemBase2, constraint);
						global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey key = new global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey(fieldFromMappedField, fieldLayoutItemBase.IsLabel);
						global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase value = fieldLayoutItemBase2;
						this._fieldItemMap.Add(key, value);
					}
				}
			}
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00074C8C File Offset: 0x00072E8C
		private void InitializeItemMap()
		{
			this._fieldItemMap.Clear();
			int i = 0;
			int count = base.LayoutItems.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase = base.LayoutItems[i] as global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase;
				if (fieldLayoutItemBase != null)
				{
					this._fieldItemMap.Add(new global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey(fieldLayoutItemBase), fieldLayoutItemBase);
				}
				i++;
			}
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00074CE3 File Offset: 0x00072EE3
		internal void InitializePanelReference(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel owningPanel)
		{
			this._cellPanel = owningPanel;
			this._cachedSizingMode = null;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00074CF8 File Offset: 0x00072EF8
		internal bool ResizeItems(global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> newExtents, bool resizeInXAxis, global::Infragistics.Windows.DataPresenter.Record targetRecord, bool addToUndo, global::Infragistics.Windows.DataPresenter.ItemSizeType sizeType, global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> autoSizeStates)
		{
			if (newExtents == null || newExtents.Count == 0)
			{
				return false;
			}
			if (addToUndo && newExtents != null && newExtents.Count > 0)
			{
				this.CreateUndoSnapshot(resizeInXAxis, targetRecord);
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> keyValuePair in newExtents)
			{
				global::Infragistics.Windows.DataPresenter.LayoutItem layoutItem = keyValuePair.Key as global::Infragistics.Windows.DataPresenter.LayoutItem;
				if (layoutItem != null)
				{
					global::Infragistics.Windows.DataPresenter.ItemSizeType itemSizeType = sizeType;
					bool flag;
					if (!autoSizeStates.TryGetValue(layoutItem, out flag))
					{
						itemSizeType = (resizeInXAxis ? layoutItem.SizeTypeWidth : layoutItem.SizeTypeHeight);
					}
					else if (!flag)
					{
						itemSizeType = global::Infragistics.Windows.DataPresenter.ItemSizeType.Explicit;
					}
					else if (itemSizeType == global::Infragistics.Windows.DataPresenter.ItemSizeType.ExplicitAutoSize)
					{
						global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase = layoutItem as global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase;
						if (fieldLayoutItemBase != null && fieldLayoutItemBase.Field.GetWidthOrHeight(resizeInXAxis).IsAnyAuto)
						{
							itemSizeType = global::Infragistics.Windows.DataPresenter.ItemSizeType.AutoMode;
						}
					}
					if (resizeInXAxis)
					{
						layoutItem.SetPreferredWidth(keyValuePair.Value.Width, itemSizeType);
					}
					else
					{
						layoutItem.SetPreferredHeight(keyValuePair.Value.Height, itemSizeType);
					}
				}
			}
			return true;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00074E08 File Offset: 0x00073008
		internal bool ShouldPreventResizeField(global::Infragistics.Windows.DataPresenter.Field field, bool resizeLabel, bool resizeInXAxis)
		{
			if (this._sourceManager != null)
			{
				return this._sourceManager.ShouldPreventResizeField(field, resizeLabel, resizeInXAxis);
			}
			if (resizeInXAxis == this._fieldLayout.IsHorizontal)
			{
				return false;
			}
			float[] array = resizeInXAxis ? base.ColumnWeights : base.RowWeights;
			if (array == null)
			{
				return false;
			}
			int num = -1;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] > 0f)
				{
					if (num >= 0)
					{
						return false;
					}
					num = i;
				}
			}
			if (num < 0)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem = this.GetLayoutItem(field, resizeLabel);
			if (layoutItem != null)
			{
				global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gridBagConstraint = base.LayoutItems.GetConstraint(layoutItem) as global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint;
				int num2 = (resizeInXAxis ? (gridBagConstraint.Column + gridBagConstraint.ColumnSpan) : (gridBagConstraint.Row + gridBagConstraint.RowSpan)) - 1;
				return num2 == num;
			}
			return false;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00074EC8 File Offset: 0x000730C8
		private void UpdateWeights()
		{
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			global::Infragistics.Windows.DataPresenter.AutoFitMode autoFitModeResolved = this._fieldLayout.AutoFitModeResolved;
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fieldLayout.Fields)
			{
				global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.UpdateWeights(field, field.GetAutoFitWeight(false, true, autoFitModeResolved), field.GetAutoFitWeight(false, false, autoFitModeResolved), field.GetAutoFitWeight(true, true, autoFitModeResolved), field.GetAutoFitWeight(true, false, autoFitModeResolved));
			}
			if (autoFitModeResolved == global::Infragistics.Windows.DataPresenter.AutoFitMode.ExtendLastField)
			{
				global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection layoutItems = base.LayoutItems;
				int num = -1;
				global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase = null;
				bool flag = false;
				foreach (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)layoutItems))
				{
					if (layoutItem.Visibility != global::System.Windows.Visibility.Collapsed)
					{
						global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gridBagConstraint = layoutItems.GetConstraint(layoutItem) as global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint;
						float num2 = (!isHorizontal) ? gridBagConstraint.ColumnWeight : gridBagConstraint.RowWeight;
						if (num2 > 0f)
						{
							flag = true;
							break;
						}
						if (!(layoutItem is global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem))
						{
							int num3 = (!isHorizontal) ? gridBagConstraint.Column : gridBagConstraint.Row;
							if (num3 > num)
							{
								num = num3;
								fieldLayoutItemBase = (layoutItem as global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase);
							}
						}
					}
				}
				if (!flag && fieldLayoutItemBase != null)
				{
					global::Infragistics.Windows.DataPresenter.Field field2 = fieldLayoutItemBase.Field;
					global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.UpdateWeights(field2, isHorizontal ? field2.GetAutoFitWeight(false, true) : 1f, isHorizontal ? 1f : field2.GetAutoFitWeight(false, false), isHorizontal ? field2.GetAutoFitWeight(true, true) : 1f, isHorizontal ? 1f : field2.GetAutoFitWeight(true, false));
				}
			}
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00075078 File Offset: 0x00073278
		private static void UpdateWeights(global::Infragistics.Windows.DataPresenter.Field f, float labelWeightX, float labelWeightY, float cellWeightX, float cellWeightY)
		{
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.UpdateWeights(f.LayoutConstraint, global::System.Math.Max(labelWeightX, cellWeightX), global::System.Math.Max(labelWeightY, cellWeightY));
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.UpdateWeights(f.CellLayoutItem.CellPresenterConstraint, cellWeightX, cellWeightY);
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.UpdateWeights(f.LabelLayoutItem.CellPresenterConstraint, labelWeightX, labelWeightY);
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x000750C4 File Offset: 0x000732C4
		private static void UpdateWeights(global::Infragistics.Windows.DataPresenter.GridBagConstraint gc, float x, float y)
		{
			gc.ColumnWeight = x;
			gc.RowWeight = y;
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x000750D4 File Offset: 0x000732D4
		internal void VerifyLayout()
		{
			if (this._layoutManagerVersion != this._fieldLayout.LayoutManagerVersion)
			{
				if (this._sourceManager != null)
				{
					this.InitializeFrom(this._sourceManager);
				}
				else
				{
					this.Initialize();
				}
				this._layoutManagerVersion = this._fieldLayout.LayoutManagerVersion;
				if (this._sourceManager == null)
				{
					this.UpdateWeights();
				}
				this.InvalidateLayout();
			}
			if (this._layoutItemVersion != this._fieldLayout.GridColumnWidthVersion)
			{
				this._layoutItemVersion = this._fieldLayout.GridColumnWidthVersion;
				this.InvalidateLayout();
			}
		}

		// Token: 0x04000A4D RID: 2637
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000A4E RID: 2638
		private int _layoutItemVersion = -2;

		// Token: 0x04000A4F RID: 2639
		private int _layoutManagerVersion = -2;

		// Token: 0x04000A50 RID: 2640
		private global::Infragistics.Windows.DataPresenter.LayoutManagerType _type;

		// Token: 0x04000A51 RID: 2641
		private global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager _sourceManager;

		// Token: 0x04000A52 RID: 2642
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey, global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase> _fieldItemMap;

		// Token: 0x04000A53 RID: 2643
		internal static readonly object InfiniteRect = new global::System.Windows.Rect(0.0, 0.0, double.PositiveInfinity, double.PositiveInfinity);

		// Token: 0x04000A54 RID: 2644
		private global::Infragistics.Windows.DataPresenter.LayoutInfo _layoutInfo;

		// Token: 0x04000A55 RID: 2645
		private global::Infragistics.Windows.DataPresenter.Record _record;

		// Token: 0x04000A56 RID: 2646
		private global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel _cellPanel;

		// Token: 0x04000A57 RID: 2647
		private global::System.Collections.Generic.Dictionary<global::System.Windows.Rect, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection> _cachedDimensions;

		// Token: 0x04000A58 RID: 2648
		internal int InvalidateLayoutCount = 1;

		// Token: 0x04000A59 RID: 2649
		private global::System.Windows.Size? _cachedPreferredSize;

		// Token: 0x04000A5A RID: 2650
		private global::System.Windows.Size? _cachedMinSize;

		// Token: 0x04000A5B RID: 2651
		private global::System.Windows.Size? _cachedMaxSize;

		// Token: 0x04000A5C RID: 2652
		private global::Infragistics.Windows.DataPresenter.DataRecordSizingMode? _cachedSizingMode;

		// Token: 0x02000190 RID: 400
		private struct FieldLabelKey : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey>
		{
			// Token: 0x0600194F RID: 6479 RVA: 0x00075194 File Offset: 0x00073394
			internal FieldLabelKey(global::Infragistics.Windows.DataPresenter.Field field, bool isLabel)
			{
				this.Field = field;
				this.IsLabel = isLabel;
			}

			// Token: 0x06001950 RID: 6480 RVA: 0x000751A4 File Offset: 0x000733A4
			internal FieldLabelKey(global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem)
			{
				this = new global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey(layoutItem.Field, layoutItem.IsLabel);
			}

			// Token: 0x06001951 RID: 6481 RVA: 0x000751B8 File Offset: 0x000733B8
			public override bool Equals(object obj)
			{
				return obj is global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey && this.Equals((global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey)obj);
			}

			// Token: 0x06001952 RID: 6482 RVA: 0x000751D0 File Offset: 0x000733D0
			public override int GetHashCode()
			{
				return this.Field.GetHashCode();
			}

			// Token: 0x06001953 RID: 6483 RVA: 0x000751DD File Offset: 0x000733DD
			public bool Equals(global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey other)
			{
				return other.Field == this.Field && other.IsLabel == this.IsLabel;
			}

			// Token: 0x04000A5D RID: 2653
			internal global::Infragistics.Windows.DataPresenter.Field Field;

			// Token: 0x04000A5E RID: 2654
			internal bool IsLabel;
		}
	}
}
