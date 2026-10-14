using System;
using System.Collections.Generic;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;
using Infragistics.Windows.DataPresenter.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000173 RID: 371
	internal class FieldGridBagLayoutManager : global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager
	{
		// Token: 0x060015AA RID: 5546 RVA: 0x00061F8C File Offset: 0x0006018C
		internal FieldGridBagLayoutManager(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.LayoutManagerType type)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(fieldLayout);
			this._fieldLayout = fieldLayout;
			this._type = type;
			this._fieldItemMap = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey, global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase>();
			this._cachedDimensions = new global::System.Collections.Generic.Dictionary<global::System.Windows.Rect, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection>();
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00061FE0 File Offset: 0x000601E0
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

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x00062040 File Offset: 0x00060240
		internal global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel CellPanel
		{
			get
			{
				return this._cellPanel;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x00062048 File Offset: 0x00060248
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x00062050 File Offset: 0x00060250
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

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x0006207B File Offset: 0x0006027B
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x00062083 File Offset: 0x00060283
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

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x00062098 File Offset: 0x00060298
		internal global::Infragistics.Windows.DataPresenter.LayoutManagerType Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000620A0 File Offset: 0x000602A0
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

		// Token: 0x060015B3 RID: 5555 RVA: 0x00062278 File Offset: 0x00060478
		internal global::System.Windows.Size CalculateMaximumSize()
		{
			if (this._cachedMaxSize == null)
			{
				this._cachedMaxSize = new global::System.Windows.Size?(this.CalculateMaximumSize(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.InfiniteRect));
			}
			return this._cachedMaxSize.Value;
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x000622AD File Offset: 0x000604AD
		internal global::System.Windows.Size CalculateMinimumSize()
		{
			if (this._cachedMinSize == null)
			{
				this._cachedMinSize = new global::System.Windows.Size?(this.CalculateMinimumSize(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.InfiniteRect));
			}
			return this._cachedMinSize.Value;
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x000622E2 File Offset: 0x000604E2
		internal global::System.Windows.Size CalculatePreferredSize()
		{
			if (this._cachedPreferredSize == null)
			{
				this._cachedPreferredSize = new global::System.Windows.Size?(this.CalculatePreferredSize(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.InfiniteRect));
			}
			return this._cachedPreferredSize.Value;
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00062318 File Offset: 0x00060518
		internal global::Infragistics.Windows.DataPresenter.DataRecordSizingMode CalculateSizingMode()
		{
			global::Infragistics.Windows.DataPresenter.Record record = this._record;
			if (record == null && this._cellPanel != null)
			{
				record = this._cellPanel.Record;
			}
			return global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.CalculateSizingMode(record, this._fieldLayout, (this._cellPanel != null) ? this._cellPanel.IsHeaderArea : (this._type == global::Infragistics.Windows.DataPresenter.LayoutManagerType.Header));
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00062370 File Offset: 0x00060570
		internal static global::Infragistics.Windows.DataPresenter.DataRecordSizingMode CalculateSizingMode(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool isHeaderArea)
		{
			if (isHeaderArea)
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

		// Token: 0x060015B8 RID: 5560 RVA: 0x0006239A File Offset: 0x0006059A
		internal global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager Clone()
		{
			return this.Clone(null);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x000623A4 File Offset: 0x000605A4
		internal global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager Clone(global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo)
		{
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager fieldGridBagLayoutManager = global::Infragistics.Windows.DataPresenter.GridUtilities.CreateGridBagLayoutManager(this._fieldLayout, this._type);
			fieldGridBagLayoutManager._sourceManager = this;
			fieldGridBagLayoutManager._layoutInfo = layoutInfo;
			return fieldGridBagLayoutManager;
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x000623D4 File Offset: 0x000605D4
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

		// Token: 0x060015BB RID: 5563 RVA: 0x00062410 File Offset: 0x00060610
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

		// Token: 0x060015BC RID: 5564 RVA: 0x000625A0 File Offset: 0x000607A0
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

		// Token: 0x060015BD RID: 5565 RVA: 0x00062608 File Offset: 0x00060808
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

		// Token: 0x060015BE RID: 5566 RVA: 0x00062668 File Offset: 0x00060868
		internal global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase GetLayoutItem(global::Infragistics.Windows.DataPresenter.Field field, bool isLabel)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase result = null;
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey key = new global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey(field, isLabel);
			this._fieldItemMap.TryGetValue(key, out result);
			return result;
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00062690 File Offset: 0x00060890
		internal global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection GetLayoutItemDimensionsCached(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer layoutContainer, object containerContext)
		{
			global::System.Windows.Rect bounds = layoutContainer.GetBounds(containerContext);
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection layoutItemDimensions;
			if (this._cachedDimensions.TryGetValue(bounds, out layoutItemDimensions))
			{
				return layoutItemDimensions;
			}
			layoutItemDimensions = base.GetLayoutItemDimensions(layoutContainer, containerContext);
			this._cachedDimensions[bounds] = layoutItemDimensions;
			return layoutItemDimensions;
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x000626D0 File Offset: 0x000608D0
		private void Initialize()
		{
			bool useCellPresenters = this._fieldLayout.UseCellPresenters;
			base.LayoutItems.Clear();
			bool flag = this._type == global::Infragistics.Windows.DataPresenter.LayoutManagerType.Header;
			int i = 0;
			int count = this._fieldLayout.Fields.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.Field field = this._fieldLayout.Fields[i];
				if (field.IsInLayout)
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
				i++;
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

		// Token: 0x060015C1 RID: 5569 RVA: 0x00062824 File Offset: 0x00060A24
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

		// Token: 0x060015C2 RID: 5570 RVA: 0x000629DC File Offset: 0x00060BDC
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

		// Token: 0x060015C3 RID: 5571 RVA: 0x00062A33 File Offset: 0x00060C33
		internal void InitializePanelReference(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel owningPanel)
		{
			this._cellPanel = owningPanel;
			this._cachedSizingMode = null;
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00062A48 File Offset: 0x00060C48
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

		// Token: 0x060015C5 RID: 5573 RVA: 0x00062B58 File Offset: 0x00060D58
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

		// Token: 0x060015C6 RID: 5574 RVA: 0x00062C18 File Offset: 0x00060E18
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

		// Token: 0x060015C7 RID: 5575 RVA: 0x00062DC8 File Offset: 0x00060FC8
		private static void UpdateWeights(global::Infragistics.Windows.DataPresenter.Field f, float labelWeightX, float labelWeightY, float cellWeightX, float cellWeightY)
		{
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.UpdateWeights(f.LayoutConstraint, global::System.Math.Max(labelWeightX, cellWeightX), global::System.Math.Max(labelWeightY, cellWeightY));
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.UpdateWeights(f.CellLayoutItem.CellPresenterConstraint, cellWeightX, cellWeightY);
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.UpdateWeights(f.LabelLayoutItem.CellPresenterConstraint, labelWeightX, labelWeightY);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00062E14 File Offset: 0x00061014
		private static void UpdateWeights(global::Infragistics.Windows.DataPresenter.GridBagConstraint gc, float x, float y)
		{
			gc.ColumnWeight = x;
			gc.RowWeight = y;
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00062E24 File Offset: 0x00061024
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

		// Token: 0x04000897 RID: 2199
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000898 RID: 2200
		private int _layoutItemVersion = -2;

		// Token: 0x04000899 RID: 2201
		private int _layoutManagerVersion = -2;

		// Token: 0x0400089A RID: 2202
		private global::Infragistics.Windows.DataPresenter.LayoutManagerType _type;

		// Token: 0x0400089B RID: 2203
		private global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager _sourceManager;

		// Token: 0x0400089C RID: 2204
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey, global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase> _fieldItemMap;

		// Token: 0x0400089D RID: 2205
		internal static readonly object InfiniteRect = new global::System.Windows.Rect(0.0, 0.0, double.PositiveInfinity, double.PositiveInfinity);

		// Token: 0x0400089E RID: 2206
		private global::Infragistics.Windows.DataPresenter.LayoutInfo _layoutInfo;

		// Token: 0x0400089F RID: 2207
		private global::Infragistics.Windows.DataPresenter.Record _record;

		// Token: 0x040008A0 RID: 2208
		private global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel _cellPanel;

		// Token: 0x040008A1 RID: 2209
		private global::System.Collections.Generic.Dictionary<global::System.Windows.Rect, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection> _cachedDimensions;

		// Token: 0x040008A2 RID: 2210
		internal int InvalidateLayoutCount = 1;

		// Token: 0x040008A3 RID: 2211
		private global::System.Windows.Size? _cachedPreferredSize;

		// Token: 0x040008A4 RID: 2212
		private global::System.Windows.Size? _cachedMinSize;

		// Token: 0x040008A5 RID: 2213
		private global::System.Windows.Size? _cachedMaxSize;

		// Token: 0x040008A6 RID: 2214
		private global::Infragistics.Windows.DataPresenter.DataRecordSizingMode? _cachedSizingMode;

		// Token: 0x02000174 RID: 372
		private struct FieldLabelKey : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey>
		{
			// Token: 0x060015CB RID: 5579 RVA: 0x00062EE4 File Offset: 0x000610E4
			internal FieldLabelKey(global::Infragistics.Windows.DataPresenter.Field field, bool isLabel)
			{
				this.Field = field;
				this.IsLabel = isLabel;
			}

			// Token: 0x060015CC RID: 5580 RVA: 0x00062EF4 File Offset: 0x000610F4
			internal FieldLabelKey(global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem)
			{
				this = new global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey(layoutItem.Field, layoutItem.IsLabel);
			}

			// Token: 0x060015CD RID: 5581 RVA: 0x00062F08 File Offset: 0x00061108
			public override bool Equals(object obj)
			{
				return obj is global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey && this.Equals((global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey)obj);
			}

			// Token: 0x060015CE RID: 5582 RVA: 0x00062F20 File Offset: 0x00061120
			public override int GetHashCode()
			{
				return this.Field.GetHashCode();
			}

			// Token: 0x060015CF RID: 5583 RVA: 0x00062F2D File Offset: 0x0006112D
			public bool Equals(global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.FieldLabelKey other)
			{
				return other.Field == this.Field && other.IsLabel == this.IsLabel;
			}

			// Token: 0x040008A7 RID: 2215
			internal global::Infragistics.Windows.DataPresenter.Field Field;

			// Token: 0x040008A8 RID: 2216
			internal bool IsLabel;
		}
	}
}
