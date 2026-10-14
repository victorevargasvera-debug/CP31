using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Reporting;

namespace Infragistics.Windows.DataPresenter.Internal
{
	// Token: 0x02000300 RID: 768
	internal class TemplateDataRecordCache
	{
		// Token: 0x060024E1 RID: 9441 RVA: 0x000A206C File Offset: 0x000A026C
		internal TemplateDataRecordCache(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			this._fieldLayout = fieldLayout;
			this._virtualizedSummaryFieldCache = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext, global::System.Tuple<global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field>, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field>>>();
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x060024E2 RID: 9442 RVA: 0x000A2147 File Offset: 0x000A0347
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> AllFields
		{
			get
			{
				this.VerifyCache();
				return this._allFields;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x060024E3 RID: 9443 RVA: 0x000A2155 File Offset: 0x000A0355
		internal int CacheVersion
		{
			get
			{
				return this._cacheVersion;
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x000A2160 File Offset: 0x000A0360
		public global::System.Collections.Generic.List<global::System.Windows.Controls.Control> CellElementsInReportOrder
		{
			get
			{
				if (this._cellElementsInReportOrder == null && this._fieldLayout.DataPresenter.IsReportControl)
				{
					this.VerifyCache();
					global::System.Windows.Controls.Control[] array = new global::System.Windows.Controls.Control[this._cellElements.Count];
					if (array.Length > 0)
					{
						this._cellElements.Values.CopyTo(array, 0);
						if (array.Length > 1)
						{
							global::Infragistics.CoreUtilities.SortMerge(array, new global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.ReportElementComparer(this._fieldLayout.DataPresenter.CurrentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical));
						}
					}
					this._cellElementsInReportOrder = new global::System.Collections.Generic.List<global::System.Windows.Controls.Control>(array);
				}
				return this._cellElementsInReportOrder;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x060024E5 RID: 9445 RVA: 0x000A21F1 File Offset: 0x000A03F1
		internal global::Infragistics.Windows.DataPresenter.GridFieldMap CellFieldMap
		{
			get
			{
				if (this._cellFieldMap == null)
				{
					this._cellFieldMap = this.InitializeCompressedFieldMap(false);
				}
				return this._cellFieldMap;
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x000A220E File Offset: 0x000A040E
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem> GridColumnLayoutItems
		{
			get
			{
				if (this._colLayoutItems == null)
				{
					this.InitializeGridDefinitionItems();
				}
				return this._colLayoutItems;
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060024E7 RID: 9447 RVA: 0x000A2224 File Offset: 0x000A0424
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem> GridRowLayoutItems
		{
			get
			{
				if (this._rowLayoutItems == null)
				{
					this.InitializeGridDefinitionItems();
				}
				return this._rowLayoutItems;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x000A223A File Offset: 0x000A043A
		internal bool IsInitializingCache
		{
			get
			{
				return this._isInitializingCache;
			}
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x000A2242 File Offset: 0x000A0442
		private static bool GetIsTemplateRecordPanel(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.IsTemplateRecordPanelProperty);
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x000A2254 File Offset: 0x000A0454
		private static void SetIsTemplateRecordPanel(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.IsTemplateRecordPanelProperty, value);
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x000A2268 File Offset: 0x000A0468
		private static void OnIsTemplateRecordPanelChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (true.Equals(e.NewValue))
			{
				d.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::System.Windows.Threading.DispatcherOperationCallback(global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.VerifyTemplateCache), d);
			}
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x000A22A4 File Offset: 0x000A04A4
		private static object VerifyTemplateCache(object param)
		{
			global::System.Windows.Controls.Panel panel = param as global::System.Windows.Controls.Panel;
			if (panel != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(panel, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true) as global::Infragistics.Windows.DataPresenter.RecordPresenter;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (recordPresenter != null) ? recordPresenter.FieldLayout : null;
				if (fieldLayout != null)
				{
					fieldLayout.TemplateDataRecordCache.VerifyTemplateRecordPanel(panel, recordPresenter);
				}
			}
			return null;
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060024ED RID: 9453 RVA: 0x000A22F0 File Offset: 0x000A04F0
		internal global::Infragistics.Windows.DataPresenter.GridFieldMap LabelFieldMap
		{
			get
			{
				if (this._labelFieldMap == null)
				{
					this._labelFieldMap = this.InitializeCompressedFieldMap(true);
				}
				return this._labelFieldMap;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x000A230D File Offset: 0x000A050D
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> NonVirtualizedCellFields
		{
			get
			{
				this.VerifyCache();
				return this._unVirtualizedCellFields;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x060024EF RID: 9455 RVA: 0x000A231B File Offset: 0x000A051B
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> NonVirtualizedFilterCellFields
		{
			get
			{
				this.VerifyCache();
				return this._unVirtualizedFilterCellFields;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x000A2329 File Offset: 0x000A0529
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> NonVirtualizedLabelFields
		{
			get
			{
				this.VerifyCache();
				return this._unVirtualizedLabelFields;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x060024F1 RID: 9457 RVA: 0x000A2338 File Offset: 0x000A0538
		internal global::System.Windows.Size TemplateGridSize
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this._fieldLayout.AlignmentFieldLayout;
				if (alignmentFieldLayout != null)
				{
					return alignmentFieldLayout.TemplateDataRecordCache.TemplateGridSize;
				}
				if (this._rowLayoutItems == null)
				{
					this.InitializeGridDefinitionItems();
				}
				return this._templateGridSize;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x000A2374 File Offset: 0x000A0574
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> VirtualizedCellFields
		{
			get
			{
				this.VerifyCache();
				return this._virtualizedCellFields;
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x060024F3 RID: 9459 RVA: 0x000A2382 File Offset: 0x000A0582
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> VirtualizedFilterCellFields
		{
			get
			{
				this.VerifyCache();
				return this._virtualizedFilterCellFields;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x000A2390 File Offset: 0x000A0590
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> VirtualizedLabelFields
		{
			get
			{
				this.VerifyCache();
				return this._virtualizedLabelFields;
			}
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x000A239E File Offset: 0x000A059E
		internal void BumpCacheVersion(bool releaseCache)
		{
			this._cellFieldMap = null;
			this._labelFieldMap = null;
			this._virtualizedSummaryFieldCache.Clear();
			if (releaseCache)
			{
				this.ReleaseCache();
				return;
			}
			this._cacheVersion++;
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x000A23D4 File Offset: 0x000A05D4
		internal void CacheCellElement(global::Infragistics.Windows.DataPresenter.Field field, global::System.Windows.Controls.Control control, bool label)
		{
			if (label)
			{
				if (this._labelElements == null)
				{
					this._labelElements = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.LabelElementKey, global::System.Windows.Controls.Control>();
				}
				this._labelElements[field.LabelElementKey] = control;
				return;
			}
			if (this._cellElements == null)
			{
				this._cellElements = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.CellElementKey, global::System.Windows.Controls.Control>();
			}
			this._cellElements[field.CellElementKey] = control;
			this._cellElementsInReportOrder = null;
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x000A2438 File Offset: 0x000A0638
		internal bool EditorAllowsVirtualization(global::Infragistics.Windows.DataPresenter.Field field, global::System.Windows.Controls.Orientation? orientation)
		{
			this.VerifyCache();
			global::System.Windows.Controls.Control cellElement = this.GetCellElement(field);
			if (cellElement == null)
			{
				return true;
			}
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
			if (cellElement is global::Infragistics.Windows.DataPresenter.CellValuePresenter)
			{
				cellValuePresenter = (global::Infragistics.Windows.DataPresenter.CellValuePresenter)cellElement;
			}
			else if (cellElement is global::Infragistics.Windows.DataPresenter.CellPresenter)
			{
				cellValuePresenter = ((global::Infragistics.Windows.DataPresenter.CellPresenter)cellElement).CellValuePresenter;
			}
			else
			{
				cellValuePresenter = null;
			}
			if (cellValuePresenter != null)
			{
				cellValuePresenter.ApplyTemplate();
			}
			if (cellValuePresenter != null && cellValuePresenter.Editor != null)
			{
				orientation = new global::System.Windows.Controls.Orientation?(orientation ?? (this._fieldLayout.IsHorizontal ? global::System.Windows.Controls.Orientation.Horizontal : global::System.Windows.Controls.Orientation.Vertical));
				return !cellValuePresenter.Editor.IsExtentBasedOnValue(orientation.Value);
			}
			return false;
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x000A24DC File Offset: 0x000A06DC
		internal double? GetCachedAutoFitHeight(global::Infragistics.Windows.DataPresenter.Record rcd)
		{
			double naN = double.NaN;
			if (this._autoFitCellAreaHeightCache != null && this._autoFitCellAreaHeightCache.TryGetValue(rcd.NestingDepth, out naN) && !double.IsNaN(naN))
			{
				return new double?(naN);
			}
			return null;
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x000A2528 File Offset: 0x000A0728
		internal double? GetCachedAutoFitWidth(global::Infragistics.Windows.DataPresenter.Record rcd)
		{
			double naN = double.NaN;
			if (this._autoFitCellAreaWidthCache != null && this._autoFitCellAreaWidthCache.TryGetValue(rcd.NestingDepth, out naN) && !double.IsNaN(naN))
			{
				return new double?(naN);
			}
			return null;
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x000A2574 File Offset: 0x000A0774
		internal int GetCellCount()
		{
			this.VerifyCache();
			global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this._fieldLayout.AlignmentFieldLayout;
			if (alignmentFieldLayout != null)
			{
				return alignmentFieldLayout.TemplateDataRecordCache.GetCellCount();
			}
			if (this._cellPlaceHolders == null)
			{
				return 0;
			}
			return this._cellPlaceHolders.Count;
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x000A25B7 File Offset: 0x000A07B7
		internal global::System.Windows.Controls.Control GetCellElement(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this.GetCellElement(field, false);
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x000A25C4 File Offset: 0x000A07C4
		internal global::System.Windows.Controls.Control GetCellElement(global::Infragistics.Windows.DataPresenter.Field field, bool label)
		{
			if ((!label && this._cellElements == null) || (label && this._labelElements == null))
			{
				return null;
			}
			global::System.Windows.Controls.Control result;
			if (label)
			{
				this._labelElements.TryGetValue(field.LabelElementKey, out result);
			}
			else
			{
				this._cellElements.TryGetValue(field.CellElementKey, out result);
			}
			return result;
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x000A2617 File Offset: 0x000A0817
		internal global::Infragistics.Windows.DataPresenter.CellPlaceholder GetCellPlaceHolder(int index)
		{
			this.VerifyCache();
			return this._cellPlaceHolders[index];
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x000A262B File Offset: 0x000A082B
		internal global::Infragistics.Windows.DataPresenter.CellValuePresenter GetCellValuePresenter(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this.GetCellValuePresenter(field, false);
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x000A2638 File Offset: 0x000A0838
		internal global::Infragistics.Windows.DataPresenter.CellValuePresenter GetCellValuePresenter(global::Infragistics.Windows.DataPresenter.Field field, bool createIfNull)
		{
			this.VerifyCache();
			global::System.Windows.FrameworkElement cellElement = this.GetCellElement(field);
			if (createIfNull && cellElement == null && this._lastCellPanel != null && field != null && field.IsValid)
			{
				global::Infragistics.Windows.DataPresenter.CellPlaceholder cellPlaceholder = this.AddPlaceholder(this._lastCellPanel, field, false);
				cellPlaceholder.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
				return this.GetCellValuePresenter(field, false);
			}
			if (cellElement is global::Infragistics.Windows.DataPresenter.CellPresenter)
			{
				return ((global::Infragistics.Windows.DataPresenter.CellPresenter)cellElement).CellValuePresenter;
			}
			return cellElement as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x000A26BC File Offset: 0x000A08BC
		private global::Infragistics.Windows.DataPresenter.LabelPresenter GetLabelPresenter(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.VerifyCache();
			global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = this.GetCellElement(field, true) as global::Infragistics.Windows.DataPresenter.LabelPresenter;
			if (labelPresenter != null)
			{
				return labelPresenter;
			}
			global::System.Windows.FrameworkElement cellElement = this.GetCellElement(field);
			if (cellElement is global::Infragistics.Windows.DataPresenter.CellPresenter)
			{
				return ((global::Infragistics.Windows.DataPresenter.CellPresenter)cellElement).LabelPresenter;
			}
			return cellElement as global::Infragistics.Windows.DataPresenter.LabelPresenter;
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x000A2704 File Offset: 0x000A0904
		internal global::System.Windows.Thickness GetCellPresenterMargin(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._cellPresenterMargins == null && !this._isInitializingCache)
			{
				this.VerifyCache();
			}
			global::System.Windows.Thickness result;
			if (this._cellPresenterMargins == null || !this._cellPresenterMargins.TryGetValue(field.CellElementKey, out result))
			{
				result = default(global::System.Windows.Thickness);
			}
			return result;
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x000A2750 File Offset: 0x000A0950
		internal double GetCellValuePresenterHeight(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::System.Windows.Size size;
			if (this.GetCellValuePresenterDesiredSize(field, out size))
			{
				return size.Height;
			}
			return double.NaN;
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x000A277C File Offset: 0x000A097C
		internal bool GetCellValuePresenterDesiredSize(global::Infragistics.Windows.DataPresenter.Field field, out global::System.Windows.Size size)
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = this.GetCellValuePresenter(field);
			if (cellValuePresenter != null)
			{
				size = cellValuePresenter.DesiredSize;
				return true;
			}
			size = global::System.Windows.Size.Empty;
			return false;
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x000A27B0 File Offset: 0x000A09B0
		internal double GetDefaultCellWidth(global::Infragistics.Windows.DataPresenter.Field field, double extent)
		{
			if (this._gridDefinitionSizes == null)
			{
				this.InitializeGridDefinitionItems();
			}
			global::System.Windows.Size size;
			if (this._gridDefinitionSizes.TryGetValue(field, out size) && !double.IsNaN(size.Width))
			{
				extent = size.Width;
			}
			return extent;
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x000A27F3 File Offset: 0x000A09F3
		internal global::Infragistics.Windows.DataPresenter.Field GetField(int index)
		{
			return this.GetCellPlaceHolder(index).Field;
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x000A2801 File Offset: 0x000A0A01
		internal int GetFieldIndex(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.VerifyCache();
			return field.TemplateCellIndex;
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x000A2810 File Offset: 0x000A0A10
		internal global::Infragistics.Windows.DataPresenter.Field GetFilterFieldToMeasure(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.VerifyCache();
			global::Infragistics.Windows.DataPresenter.Field result;
			this._filterCellFieldMap.TryGetValue(field.FilterCellElementKey, out result);
			return result;
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x000A2838 File Offset: 0x000A0A38
		internal double GetLabelPresenterHeight(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::System.Windows.Size size;
			if (this.GetLabelPresenterDesiredSize(field, out size))
			{
				return size.Height;
			}
			return double.NaN;
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x000A2864 File Offset: 0x000A0A64
		private bool GetLabelPresenterDesiredSize(global::Infragistics.Windows.DataPresenter.Field field, out global::System.Windows.Size size)
		{
			global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = this.GetLabelPresenter(field);
			if (labelPresenter != null)
			{
				if (!labelPresenter.IsMeasureValid)
				{
					labelPresenter.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
				}
				size = labelPresenter.DesiredSize;
				return true;
			}
			size = global::System.Windows.Size.Empty;
			return false;
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x000A28BC File Offset: 0x000A0ABC
		internal double GetLabelPresenterWidth(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.CellPlaceholder placeHolder = this.GetPlaceHolder(field, true, true);
			if (placeHolder != null)
			{
				global::System.Windows.Controls.Control childCellElement = placeHolder.ChildCellElement;
				if (!childCellElement.IsMeasureValid)
				{
					global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.ApplyTemplateRecursively(childCellElement);
					childCellElement.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
				}
				global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetCellElement(childCellElement, true) as global::Infragistics.Windows.DataPresenter.LabelPresenter;
				if (labelPresenter != null)
				{
					return labelPresenter.DesiredSize.Width;
				}
			}
			return double.NaN;
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x000A2930 File Offset: 0x000A0B30
		internal double GetNestedContentChrome(global::Infragistics.Windows.DataPresenter.Record record, bool near)
		{
			double num;
			if (record is global::Infragistics.Windows.DataPresenter.DataRecord)
			{
				num = (near ? this._nearOffsetDataRecordChrome : this._farOffsetDataRecordChrome);
			}
			else if (record is global::Infragistics.Windows.DataPresenter.GroupByRecord)
			{
				num = (near ? this._nearOffsetGroupByChrome : this._farOffsetGroupByChrome);
			}
			else
			{
				if (!(record is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord))
				{
					return 0.0;
				}
				num = (near ? this._nearOffsetExpandableFieldChrome : this._farOffsetExpandableFieldChrome);
			}
			if (!double.IsNaN(num))
			{
				return num;
			}
			global::Infragistics.Windows.DataPresenter.RecordPresenter associatedRecordPresenter = record.AssociatedRecordPresenter;
			if (associatedRecordPresenter == null || associatedRecordPresenter.NestedContent == null)
			{
				return 0.0;
			}
			global::System.Windows.FrameworkElement nestedContentSite = associatedRecordPresenter.GetNestedContentSite();
			double num2 = 0.0;
			double num3 = 0.0;
			if (nestedContentSite != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = associatedRecordPresenter.NestedContent as global::Infragistics.Windows.DataPresenter.RecordListControl;
				global::System.Windows.Controls.ItemsPresenter itemsPresenter = (recordListControl != null) ? (global::Infragistics.Windows.Utilities.GetDescendantFromType(recordListControl, typeof(global::System.Windows.Controls.ItemsPresenter), true) as global::System.Windows.Controls.ItemsPresenter) : null;
				if (itemsPresenter != null && itemsPresenter.IsArrangeValid && nestedContentSite.IsArrangeValid)
				{
					global::System.Windows.Size desiredSize = itemsPresenter.DesiredSize;
					global::System.Windows.Size desiredSize2 = nestedContentSite.DesiredSize;
					global::System.Windows.Point point = itemsPresenter.TranslatePoint(default(global::System.Windows.Point), nestedContentSite);
					global::System.Windows.Point point2 = itemsPresenter.TranslatePoint(new global::System.Windows.Point(desiredSize.Width, desiredSize.Height), nestedContentSite);
					global::System.Windows.Media.GeneralTransform renderTransform = nestedContentSite.RenderTransform;
					if (renderTransform != global::System.Windows.Media.Transform.Identity && renderTransform != null)
					{
						point = renderTransform.Transform(point);
						point2 = renderTransform.Transform(point2);
					}
					if (this._fieldLayout.IsHorizontal)
					{
						num2 = point.Y;
						num3 = desiredSize2.Height - point2.Y;
					}
					else
					{
						num2 = point.X;
						num3 = desiredSize2.Width - point2.X;
					}
					if (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(0.0, num2))
					{
						num2 = 0.0;
					}
					if (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(0.0, num3))
					{
						num3 = 0.0;
					}
					if (record is global::Infragistics.Windows.DataPresenter.DataRecord)
					{
						this._nearOffsetDataRecordChrome = num2;
						this._farOffsetDataRecordChrome = num3;
					}
					else if (record is global::Infragistics.Windows.DataPresenter.GroupByRecord)
					{
						this._nearOffsetGroupByChrome = num2;
						this._farOffsetGroupByChrome = num3;
					}
					else
					{
						this._nearOffsetExpandableFieldChrome = num2;
						this._farOffsetExpandableFieldChrome = num3;
					}
					this._fieldLayout.BumpRecordIndentVersion();
				}
			}
			if (!near)
			{
				return num3;
			}
			return num2;
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x000A2B74 File Offset: 0x000A0D74
		internal global::Infragistics.Windows.DataPresenter.CellPlaceholder GetPlaceHolder(global::Infragistics.Windows.DataPresenter.Field f, bool label, bool requireMatchingField)
		{
			if (this._lastCellArea == null)
			{
				this.InitializeCachedCellArea();
			}
			global::Infragistics.Windows.DataPresenter.CellPlaceholder cellPlaceholder = null;
			if (label && this._lastLabelPanel != null)
			{
				cellPlaceholder = global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.GetPlacedholder(this._lastLabelPanel, f);
			}
			if (cellPlaceholder == null && f.TemplateCellIndex >= 0)
			{
				cellPlaceholder = this._cellPlaceHolders[f.TemplateCellIndex];
			}
			if (cellPlaceholder != null && cellPlaceholder.ChildCellElement != null && requireMatchingField && f != global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldFromControl(cellPlaceholder.ChildCellElement))
			{
				cellPlaceholder.EnsureHasOwnControl();
			}
			return cellPlaceholder;
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x000A2BEC File Offset: 0x000A0DEC
		private static global::Infragistics.Windows.DataPresenter.CellPlaceholder GetPlacedholder(global::System.Windows.Controls.Panel parent, global::Infragistics.Windows.DataPresenter.Field field)
		{
			int i = 0;
			int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(parent);
			while (i < childrenCount)
			{
				global::Infragistics.Windows.DataPresenter.CellPlaceholder cellPlaceholder = global::System.Windows.Media.VisualTreeHelper.GetChild(parent, i) as global::Infragistics.Windows.DataPresenter.CellPlaceholder;
				if (cellPlaceholder != null && cellPlaceholder.Field == field)
				{
					return cellPlaceholder;
				}
				i++;
			}
			return null;
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x000A2C28 File Offset: 0x000A0E28
		internal double GetVirtPanelOffset(bool near, bool far)
		{
			this.VerifyCache();
			double num = 0.0;
			if (near)
			{
				num += this._nearOffsetVirtualizingPanel;
			}
			if (far)
			{
				num += this._farOffsetVirtualizingPanel;
			}
			return num;
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x000A2C60 File Offset: 0x000A0E60
		internal double GetVirtPanelOffsetToRecordPresenter(bool near, bool far)
		{
			this.VerifyCache();
			double num = 0.0;
			if (near)
			{
				num += this._nearOffsetVirtualizingPanelToRP;
			}
			if (far)
			{
				num += this._farOffsetVirtualizingPanelToRP;
			}
			return num;
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x000A2C98 File Offset: 0x000A0E98
		internal void GetVirtualizedSummaryFields(global::Infragistics.Windows.DataPresenter.SummaryRecord record, out global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> virtualizedFields, out global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> nonVirtualizedFields)
		{
			this.VerifyCache();
			int num = this._fieldLayout.SummaryDefinitions.SummariesVersion + this._fieldLayout.Fields.Version + this._fieldLayout.LayoutItemVersion + this._cacheVersion;
			if (this._verifiedSummaryFieldsVersion != num)
			{
				this._verifiedSummaryFieldsVersion = num;
				this._virtualizedSummaryFieldCache.Clear();
			}
			global::System.Tuple<global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field>, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field>> tuple;
			if (!this._virtualizedSummaryFieldCache.TryGetValue(record.SummaryDisplayAreaContext, out tuple))
			{
				global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.CreateVirtualizedSummaryFieldList(record, out virtualizedFields, out nonVirtualizedFields);
				tuple = (this._virtualizedSummaryFieldCache[record.SummaryDisplayAreaContext] = global::System.Tuple.Create<global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field>, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field>>(virtualizedFields, nonVirtualizedFields));
				return;
			}
			virtualizedFields = tuple.Item1;
			nonVirtualizedFields = tuple.Item2;
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x000A2D48 File Offset: 0x000A0F48
		internal double GetRecordOffset(global::Infragistics.Windows.DataPresenter.Record record, bool near)
		{
			if (record == null)
			{
				return 0.0;
			}
			this.VerifyCache();
			double num;
			if (near)
			{
				num = this._nearOffsetDataRecord;
			}
			else
			{
				num = this._farOffsetDataRecord;
			}
			if (record is global::Infragistics.Windows.DataPresenter.DataRecord || record is global::Infragistics.Windows.DataPresenter.SummaryRecord)
			{
				return num;
			}
			if (record is global::Infragistics.Windows.DataPresenter.GroupByRecord)
			{
				if (!double.IsNaN(this._nearOffsetGroupByRecord))
				{
					if (near)
					{
						return this._nearOffsetGroupByRecord;
					}
					return this._farOffsetGroupByRecord;
				}
			}
			else
			{
				if (!(record is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord))
				{
					return num;
				}
				if (!double.IsNaN(this._nearOffsetExpandableFieldRecord))
				{
					if (near)
					{
						return this._nearOffsetExpandableFieldRecord;
					}
					return this._farOffsetExpandableFieldRecord;
				}
			}
			global::Infragistics.Windows.DataPresenter.RecordPresenter associatedRecordPresenter = record.AssociatedRecordPresenter;
			if (associatedRecordPresenter == null || !associatedRecordPresenter.IsInitialized || !associatedRecordPresenter.IsArrangeValid)
			{
				return num;
			}
			num = 0.0;
			double num2;
			double num3;
			if (global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.GetRecordOffset(associatedRecordPresenter, out num2, out num3) && (num2 != 0.0 || num3 != 0.0))
			{
				if (record is global::Infragistics.Windows.DataPresenter.GroupByRecord)
				{
					this._nearOffsetGroupByRecord = num2;
					this._farOffsetGroupByRecord = num3;
				}
				else
				{
					this._nearOffsetExpandableFieldRecord = num2;
					this._farOffsetExpandableFieldRecord = num3;
				}
				this._fieldLayout.BumpRecordIndentVersion();
				num += (near ? num2 : num3);
			}
			return num;
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x000A2E64 File Offset: 0x000A1064
		private static bool GetRecordOffset(global::Infragistics.Windows.DataPresenter.RecordPresenter rp, out double nearOffset, out double farOffset)
		{
			nearOffset = double.NaN;
			farOffset = double.NaN;
			global::System.Windows.FrameworkElement frameworkElement = (rp == null) ? null : rp.GetRecordContentSite();
			if (frameworkElement == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = rp.FieldLayout;
			if (fieldLayout == null)
			{
				return false;
			}
			global::System.Windows.Size desiredSize = frameworkElement.DesiredSize;
			global::System.Windows.FrameworkElement nestedContentSite = rp.GetNestedContentSite();
			global::System.Windows.Size size;
			if (nestedContentSite != null)
			{
				size = nestedContentSite.DesiredSize;
			}
			else
			{
				size = global::System.Windows.Size.Empty;
			}
			global::System.Windows.Point point;
			global::System.Windows.Point point2;
			if (nestedContentSite != null && rp is global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter)
			{
				point = nestedContentSite.TranslatePoint(default(global::System.Windows.Point), rp);
				point2 = nestedContentSite.TranslatePoint(new global::System.Windows.Point(global::System.Math.Max(desiredSize.Width, size.Width), global::System.Math.Max(desiredSize.Height, size.Height)), rp);
			}
			else
			{
				point = frameworkElement.TranslatePoint(default(global::System.Windows.Point), rp);
				point2 = frameworkElement.TranslatePoint(new global::System.Windows.Point(global::System.Math.Max(desiredSize.Width, size.Width), global::System.Math.Max(desiredSize.Height, size.Height)), rp);
			}
			if (fieldLayout.IsHorizontal)
			{
				nearOffset = point.Y + desiredSize.Height;
				farOffset = rp.DesiredSize.Height - point2.Y;
				if (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(farOffset, 0.0))
				{
					farOffset = 0.0;
				}
				if (nearOffset != 0.0 || farOffset != 0.0)
				{
					global::System.Windows.Thickness margin = rp.Margin;
					nearOffset += margin.Top + margin.Bottom;
				}
			}
			else
			{
				nearOffset = point.X;
				farOffset = rp.DesiredSize.Width - point2.X;
				if (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(farOffset, 0.0))
				{
					farOffset = 0.0;
				}
			}
			return true;
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x000A3030 File Offset: 0x000A1230
		internal global::System.Windows.Size GetRecordSelectorNumberSize(global::Infragistics.Windows.DataPresenter.Record rcd)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this._fieldLayout.AlignmentFieldLayout;
			if (alignmentFieldLayout != null)
			{
				return alignmentFieldLayout.TemplateDataRecordCache.GetRecordSelectorNumberSize(rcd);
			}
			if (!this._fieldLayout.IsTreeView && rcd != null && this._levelRecordNumberSizes != null)
			{
				int nestingDepthOfDataRcds = rcd.NestingDepthOfDataRcds;
				if (nestingDepthOfDataRcds < this._levelRecordNumberSizes.Count)
				{
					return this._levelRecordNumberSizes[nestingDepthOfDataRcds];
				}
			}
			return this._largestRecordNumberSize;
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x000A309C File Offset: 0x000A129C
		internal global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo GetReportLayoutInfoForRecord(global::Infragistics.Windows.DataPresenter.Record record, double? recordOffset)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterReportControl dataPresenterReportControl = this._fieldLayout.DataPresenter as global::Infragistics.Windows.DataPresenter.DataPresenterReportControl;
			global::Infragistics.Windows.DataPresenter.ReportViewBase reportViewBase = null;
			global::Infragistics.Windows.Reporting.ReportSection reportSection = null;
			if (dataPresenterReportControl != null)
			{
				reportViewBase = (dataPresenterReportControl.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.ReportViewBase);
				reportSection = dataPresenterReportControl.Section;
			}
			if (dataPresenterReportControl == null || reportViewBase == null || reportSection == null || dataPresenterReportControl.CurrentPanel == null || this._fieldLayout.IsAutoFit || reportSection.Report.ReportSettings.HorizontalPaginationMode == global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Scale || reportViewBase.CellPageSpanStrategy == global::Infragistics.Windows.DataPresenter.CellPageSpanStrategy.Continue)
			{
				this._reportLayoutInfos = null;
				this._reportLayoutNestingDepthOffsetCache = null;
				return null;
			}
			global::Infragistics.Windows.DataPresenter.CellPageSpanStrategy cellPageSpanStrategy = reportViewBase.CellPageSpanStrategy;
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			double num;
			if (isHorizontal)
			{
				num = dataPresenterReportControl.CurrentPanel.ActualHeight;
			}
			else
			{
				num = dataPresenterReportControl.CurrentPanel.ActualWidth;
			}
			if (num != this._lastPanelExtent || isHorizontal != this._lastIsHorizontal || cellPageSpanStrategy != this._lastCellPageSpanStrategy)
			{
				this._lastPanelExtent = num;
				this._lastIsHorizontal = isHorizontal;
				this._lastCellPageSpanStrategy = cellPageSpanStrategy;
				this._reportLayoutInfos = null;
				this._reportLayoutNestingDepthOffsetCache = null;
			}
			int num2 = this._fieldLayout.IsTreeView ? 0 : ((record != null) ? record.NestingDepth : 0);
			double num3;
			if (recordOffset != null)
			{
				num3 = recordOffset.Value;
				if (num2 == 0)
				{
					global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.s_lastZeroIndentOffset = num3;
				}
			}
			else if (num2 > 0 && !this._fieldLayout.IsTreeView && this._reportLayoutNestingDepthOffsetCache != null && this._reportLayoutNestingDepthOffsetCache.ContainsKey(num2))
			{
				num3 = this._reportLayoutNestingDepthOffsetCache[num2];
			}
			else
			{
				double num4;
				if (reportViewBase is global::Infragistics.Windows.DataPresenter.TabularReportView)
				{
					num4 = ((global::Infragistics.Windows.DataPresenter.TabularReportView)reportViewBase).LevelIndentation;
				}
				else
				{
					num4 = 10.0;
				}
				num3 = (double)num2 * num4 + global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.s_lastZeroIndentOffset;
			}
			global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo reportLayoutInfo = null;
			if (this._reportLayoutInfos == null)
			{
				this._reportLayoutInfos = new global::System.Collections.Generic.Dictionary<double, global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo>();
			}
			else
			{
				this._reportLayoutInfos.TryGetValue(num3, out reportLayoutInfo);
			}
			if (reportLayoutInfo == null)
			{
				reportLayoutInfo = new global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo(num3, num, this._fieldLayout);
				this._reportLayoutInfos[num3] = reportLayoutInfo;
			}
			if (this._reportLayoutNestingDepthOffsetCache == null)
			{
				this._reportLayoutNestingDepthOffsetCache = new global::System.Collections.Generic.Dictionary<int, double>();
			}
			this._reportLayoutNestingDepthOffsetCache[num2] = num3;
			return reportLayoutInfo;
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x000A32AC File Offset: 0x000A14AC
		internal bool IsTemplateRecordPresenter(global::Infragistics.Windows.DataPresenter.DataRecordPresenter rp)
		{
			return rp != null && rp == this._lastRecordPresenter;
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x000A32BC File Offset: 0x000A14BC
		internal void OnFieldLayoutRemoved()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
			if (dataPresenter != null)
			{
				if (this._lastRecordPresenter != null)
				{
					dataPresenter.InternalRemoveLogicalChild(this._lastRecordPresenter);
				}
				if (this._lastGroupByPresenter != null)
				{
					dataPresenter.InternalRemoveLogicalChild(this._lastGroupByPresenter);
				}
			}
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x000A3300 File Offset: 0x000A1500
		internal bool OnRecordSelectorNumberMeasure(global::Infragistics.Windows.DataPresenter.Record rcd, global::System.Windows.Size desiredSize)
		{
			bool flag = false;
			try
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this._fieldLayout.AlignmentFieldLayout;
				if (alignmentFieldLayout != null)
				{
					flag = alignmentFieldLayout.TemplateDataRecordCache.OnRecordSelectorNumberMeasure(rcd, desiredSize);
				}
				else
				{
					global::System.Windows.Size size = new global::System.Windows.Size
					{
						Width = global::System.Math.Max(this._largestRecordNumberSize.Width, desiredSize.Width),
						Height = global::System.Math.Max(this._largestRecordNumberSize.Height, desiredSize.Height)
					};
					if (size != this._largestRecordNumberSize)
					{
						flag = true;
						this._largestRecordNumberSize = size;
					}
					if (rcd == null)
					{
						return false;
					}
					int nestingDepthOfDataRcds = rcd.NestingDepthOfDataRcds;
					if (this._levelRecordNumberSizes == null)
					{
						this._levelRecordNumberSizes = new global::System.Collections.Generic.List<global::System.Windows.Size>();
					}
					while (this._levelRecordNumberSizes.Count <= nestingDepthOfDataRcds)
					{
						this._levelRecordNumberSizes.Add(desiredSize);
					}
					size = this._levelRecordNumberSizes[nestingDepthOfDataRcds];
					size.Width = global::System.Math.Max(size.Width, desiredSize.Width);
					size.Height = global::System.Math.Max(size.Height, desiredSize.Height);
					if (size != this._levelRecordNumberSizes[nestingDepthOfDataRcds])
					{
						flag = true;
						this._levelRecordNumberSizes[nestingDepthOfDataRcds] = size;
					}
				}
			}
			finally
			{
				if (flag)
				{
					this._fieldLayout.BumpRecordSelectorNumberSizeVersionAsync();
				}
			}
			return flag;
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x000A3464 File Offset: 0x000A1664
		internal void OnTemplateRecordTemplateChanged(global::System.Windows.FrameworkElement fe)
		{
			if (this.IsInitializingCache)
			{
				return;
			}
			bool flag = false;
			if (fe == this._lastGroupByPresenter)
			{
				flag = true;
			}
			if (flag)
			{
				this.ReleaseCache();
				this._fieldLayout.BumpLayoutItemVersion();
			}
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x000A349C File Offset: 0x000A169C
		internal void ReleaseCache()
		{
			if (this._lastRecordPresenter != null)
			{
				this._cellFieldMap = null;
				this._labelFieldMap = null;
				this._cacheVersion++;
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
				if (dataPresenter != null)
				{
					dataPresenter.InternalRemoveLogicalChild(this._lastRecordPresenter);
					dataPresenter.InternalRemoveLogicalChild(this._lastGroupByPresenter);
				}
				global::Infragistics.Windows.DataPresenter.DataRecordPresenter lastRecordPresenter = this._lastRecordPresenter;
				global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter lastGroupByPresenter = this._lastGroupByPresenter;
				this._lastRecordPresenter = null;
				this._lastCellArea = null;
				this._cellPlaceHolders = null;
				this._lastGroupByPresenter = null;
				this._cellElements = null;
				this._labelElements = null;
				this._virtualizedCellFields = null;
				this._unVirtualizedCellFields = null;
				this._virtualizedSummaryFieldCache.Clear();
				this._virtualizedFilterCellFields = null;
				this._unVirtualizedFilterCellFields = null;
				this._filterCellFieldMap = null;
				this._rowLayoutItems = null;
				this._colLayoutItems = null;
				this._gridDefinitionSizes = null;
				this._templateGridSize = global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.NaNSize;
				this._virtualizedLabelFields = null;
				this._unVirtualizedLabelFields = null;
				this._allFields = null;
				this._cellPresenterMargins = null;
				this._lastCellPanel = null;
				this._lastLabelPanel = null;
				this._nearOffsetGroupByRecord = double.NaN;
				this._nearOffsetExpandableFieldRecord = double.NaN;
				this._farOffsetGroupByRecord = double.NaN;
				this._farOffsetExpandableFieldRecord = double.NaN;
				this._nearOffsetGroupByChrome = double.NaN;
				this._nearOffsetExpandableFieldChrome = double.NaN;
				this._nearOffsetDataRecordChrome = double.NaN;
				this._farOffsetDataRecordChrome = double.NaN;
				this._farOffsetGroupByChrome = double.NaN;
				this._farOffsetExpandableFieldChrome = double.NaN;
				global::Infragistics.Windows.DataPresenter.FieldCollection fields = this._fieldLayout.Fields;
				int i = 0;
				int count = fields.Count;
				while (i < count)
				{
					fields[i].TemplateCellIndex = -1;
					i++;
				}
				if (lastRecordPresenter != null)
				{
					lastRecordPresenter.ClearValue(global::System.Windows.FrameworkElement.DataContextProperty);
				}
				if (lastGroupByPresenter != null)
				{
					lastGroupByPresenter.ClearValue(global::System.Windows.FrameworkElement.DataContextProperty);
				}
			}
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x000A368C File Offset: 0x000A188C
		internal void SetCachedAutoFitHeight(global::Infragistics.Windows.DataPresenter.Record rcd, double height)
		{
			if (this._autoFitCellAreaHeightCache == null)
			{
				this._autoFitCellAreaHeightCache = new global::System.Collections.Generic.Dictionary<int, double>();
			}
			this._autoFitCellAreaHeightCache[rcd.NestingDepth] = height;
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x000A36B3 File Offset: 0x000A18B3
		internal void SetCachedAutoFitWidth(global::Infragistics.Windows.DataPresenter.Record rcd, double width)
		{
			if (this._autoFitCellAreaWidthCache == null)
			{
				this._autoFitCellAreaWidthCache = new global::System.Collections.Generic.Dictionary<int, double>();
			}
			this._autoFitCellAreaWidthCache[rcd.NestingDepth] = width;
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x000A36DA File Offset: 0x000A18DA
		internal void Verify()
		{
			this.VerifyCache();
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x000A36E4 File Offset: 0x000A18E4
		private global::Infragistics.Windows.DataPresenter.CellPlaceholder AddPlaceholder(global::System.Windows.Controls.Panel placeholderPanel, global::Infragistics.Windows.DataPresenter.Field field, bool isLabel)
		{
			bool alwaysCreateElement = this._fieldLayout.CellPresentation == global::Infragistics.Windows.DataPresenter.CellPresentation.CardView && this._fieldLayout.UseCellPresenters;
			global::Infragistics.Windows.DataPresenter.CellPlaceholder cellPlaceholder = new global::Infragistics.Windows.DataPresenter.CellPlaceholder(alwaysCreateElement);
			cellPlaceholder.BeginInit();
			cellPlaceholder.SetValue(global::Infragistics.Windows.DataPresenter.CellPlaceholder.IsLabelProperty, isLabel);
			cellPlaceholder.SetValue(global::Infragistics.Windows.DataPresenter.CellPlaceholder.FieldProperty, field);
			placeholderPanel.Children.Add(cellPlaceholder);
			cellPlaceholder.EndInit();
			return cellPlaceholder;
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x000A37BC File Offset: 0x000A19BC
		private static void CreateVirtualizedSummaryFieldList(global::Infragistics.Windows.DataPresenter.SummaryRecord record, out global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> virtualizedFields, out global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> nonVirtualizedFields)
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, int> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, int>();
			foreach (global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult in record.SummaryResults)
			{
				global::Infragistics.Windows.DataPresenter.Field positionFieldResolved = summaryResult.PositionFieldResolved;
				if (positionFieldResolved != null && positionFieldResolved.VisibilityResolved != global::System.Windows.Visibility.Collapsed && positionFieldResolved.TemplateCellIndex >= 0 && positionFieldResolved.IsInLayout)
				{
					int num;
					dictionary.TryGetValue(positionFieldResolved, out num);
					num = (dictionary[positionFieldResolved] = num + 1);
				}
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = record.DataPresenter;
			global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Field> comparer = global::Infragistics.CoreUtilities.CreateComparer<global::Infragistics.Windows.DataPresenter.Field>((global::Infragistics.Windows.DataPresenter.Field f1, global::Infragistics.Windows.DataPresenter.Field f2) => f1.IndexForCompare.CompareTo(f2.IndexForCompare));
			if (dataPresenter == null || dataPresenter.SummaryCellContainerGenerationMode == global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode.PreLoad)
			{
				global::Infragistics.Windows.DataPresenter.Field[] array = new global::Infragistics.Windows.DataPresenter.Field[dictionary.Count];
				dictionary.Keys.CopyTo(array, 0);
				global::Infragistics.Windows.DataPresenter.Field[] array2 = new global::Infragistics.Windows.DataPresenter.Field[0];
				global::Infragistics.Windows.DataPresenter.Field[] array3 = array;
				global::System.Array.Sort<global::Infragistics.Windows.DataPresenter.Field>(array2, comparer);
				global::System.Array.Sort<global::Infragistics.Windows.DataPresenter.Field>(array3, comparer);
				virtualizedFields = array2;
				nonVirtualizedFields = array3;
				return;
			}
			global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, int>>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, int>>>();
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, int> item in dictionary)
			{
				global::Infragistics.Windows.DataPresenter.FieldPosition actualPosition = item.Key.ActualPosition;
				while (list.Count <= actualPosition.Row)
				{
					list.Add(new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, int>>());
				}
				list[actualPosition.Row].Add(item);
			}
			global::System.Collections.Generic.IComparer<global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, int>> comparer2 = global::Infragistics.CoreUtilities.CreateComparer<global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, int>>(delegate(global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, int> p1, global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, int> p2)
			{
				int num2 = p2.Value.CompareTo(p1.Value);
				if (num2 == 0)
				{
					num2 = p1.Key.IndexForCompare.CompareTo(p2.Key.IndexForCompare);
				}
				return num2;
			});
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list3 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			for (int i = list.Count - 1; i >= 0; i--)
			{
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.Field, int>> list4 = list[i];
				if (list4.Count > 0)
				{
					list4.Sort(comparer2);
					list2.Add(list4[0].Key);
					int j = 1;
					int count = list4.Count;
					while (j < count)
					{
						list3.Add(list4[j].Key);
						j++;
					}
				}
			}
			list2.Sort(comparer);
			list3.Sort(comparer);
			virtualizedFields = list3;
			nonVirtualizedFields = list2;
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x000A3A10 File Offset: 0x000A1C10
		internal global::System.Windows.Controls.Panel GetCellPanel()
		{
			this.VerifyCache();
			return this._lastCellPanel;
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x000A3A30 File Offset: 0x000A1C30
		private void InitializeCachedCellArea()
		{
			if (this._lastCellArea == null)
			{
				this._verifiedCacheVersion = this._cacheVersion;
				bool isInitializingCache = this._isInitializingCache;
				try
				{
					this._isInitializingCache = true;
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
					if (dataPresenter != null)
					{
						global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = this._fieldLayout.StyleGenerator;
						if (styleGenerator != null)
						{
							global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = new global::Infragistics.Windows.DataPresenter.DataRecordPresenter();
							this._lastRecordPresenter = dataRecordPresenter;
							global::System.Windows.Input.CanExecuteRoutedEventHandler handler = delegate(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
							{
								e.CanExecute = true;
								e.Handled = true;
							};
							global::System.Windows.Input.CommandManager.AddCanExecuteHandler(dataRecordPresenter, handler);
							dataRecordPresenter.Tag = global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateRecordPresenterId;
							global::Infragistics.Windows.DataPresenter.DataRecord templateDataRecord = this._fieldLayout.TemplateDataRecord;
							dataRecordPresenter.DataContext = templateDataRecord;
							if (this._fieldLayout.WasRemovedFromCollection)
							{
								global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerWarning("Should not be initializing a TemplateDataRecordCache for a FieldLayout that was removed from the FieldLayouts collection.");
							}
							dataPresenter.InternalAddLogicalChild(dataRecordPresenter);
							dataRecordPresenter.PrepareContainerForItem(templateDataRecord);
							dataRecordPresenter.InitializeHeaderContent(true);
							global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.ApplyTemplateRecursively(dataRecordPresenter);
							global::Infragistics.Windows.Controls.ExpansionIndicator expansionIndicator = global::Infragistics.Windows.DataPresenter.GridUtilities.GetExpansionIndicator(this._lastRecordPresenter);
							if (expansionIndicator != null)
							{
								expansionIndicator.Visibility = global::System.Windows.Visibility.Visible;
								expansionIndicator.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
								expansionIndicator.Arrange(new global::System.Windows.Rect(expansionIndicator.DesiredSize));
								global::System.Windows.Size desiredSize = expansionIndicator.DesiredSize;
								if (!desiredSize.IsEmpty)
								{
									this._fieldLayout.ExpansionIndicatorSize = desiredSize;
								}
							}
							global::Infragistics.Windows.DataPresenter.HeaderLabelArea descendantFromType = global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.DataPresenter.HeaderLabelArea>(dataRecordPresenter, true, null);
							if (descendantFromType != null)
							{
								this._lastLabelPanel = (global::Infragistics.Windows.Utilities.GetDescendantFromName(descendantFromType, "HeaderItemGrid") as global::System.Windows.Controls.Panel);
								this.InitializeCellPanel(this._lastLabelPanel, true);
							}
							this._lastCellArea = global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.DataPresenter.DataRecordCellArea>(dataRecordPresenter, true, null);
							if (this._lastCellArea != null)
							{
								this._lastCellPanel = (global::Infragistics.Windows.Utilities.GetDescendantFromName(this._lastCellArea, "ContentItemGrid") as global::System.Windows.Controls.Panel);
								this.InitializeCellPanel(this._lastCellPanel, false);
							}
							this._lastRecordPresenter.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
							this._lastRecordPresenter.Arrange(new global::System.Windows.Rect(dataRecordPresenter.DesiredSize));
							if (this._lastCellPanel != null)
							{
								this.InitializeCellInfo();
							}
							global::System.Windows.FrameworkElement recordContentSite = this._lastRecordPresenter.GetRecordContentSite();
							if (recordContentSite != null)
							{
								bool isHorizontal = this._fieldLayout.IsHorizontal;
								global::System.Windows.Size renderSize = recordContentSite.RenderSize;
								global::System.Windows.Size size = (descendantFromType != null) ? descendantFromType.RenderSize : default(global::System.Windows.Size);
								global::System.Windows.Point point = recordContentSite.TranslatePoint(default(global::System.Windows.Point), dataRecordPresenter);
								global::System.Windows.Point point2 = recordContentSite.TranslatePoint(new global::System.Windows.Point(global::System.Math.Max(renderSize.Width, size.Width), global::System.Math.Max(renderSize.Height, size.Height)), dataRecordPresenter);
								global::System.Windows.FrameworkElement descendantFromName = global::Infragistics.Windows.Utilities.GetDescendantFromName(recordContentSite, "ContentItemGrid");
								if (descendantFromName != null)
								{
									global::System.Windows.Size renderSize2 = descendantFromName.RenderSize;
									global::System.Windows.Size renderSize3 = recordContentSite.RenderSize;
									global::System.Windows.Point point3 = descendantFromName.TranslatePoint(default(global::System.Windows.Point), recordContentSite);
									global::System.Windows.Point point4 = descendantFromName.TranslatePoint(new global::System.Windows.Point(renderSize2.Width, renderSize2.Height), recordContentSite);
									if (isHorizontal)
									{
										this._nearOffsetVirtualizingPanel = point3.Y;
										this._farOffsetVirtualizingPanel = renderSize3.Height - point4.Y;
									}
									else
									{
										this._nearOffsetVirtualizingPanel = point3.X;
										this._farOffsetVirtualizingPanel = renderSize3.Width - point4.X;
									}
									point3 = descendantFromName.TranslatePoint(default(global::System.Windows.Point), this._lastRecordPresenter);
									point4 = descendantFromName.TranslatePoint(new global::System.Windows.Point(renderSize2.Width, renderSize2.Height), this._lastRecordPresenter);
									if (isHorizontal)
									{
										this._nearOffsetVirtualizingPanelToRP = point3.Y;
										this._farOffsetVirtualizingPanelToRP = this._lastRecordPresenter.RenderSize.Height - point4.Y;
									}
									else
									{
										this._nearOffsetVirtualizingPanelToRP = point3.X;
										this._farOffsetVirtualizingPanelToRP = this._lastRecordPresenter.RenderSize.Width - point4.X;
									}
								}
								if (isHorizontal)
								{
									this._nearOffsetDataRecord = point.Y;
									this._farOffsetDataRecord = this._lastRecordPresenter.RenderSize.Height - point2.Y;
								}
								else
								{
									this._nearOffsetDataRecord = point.X;
									this._farOffsetDataRecord = this._lastRecordPresenter.RenderSize.Width - point2.X;
								}
							}
							this.InitializeGroupByRecordCache();
							global::System.Windows.Input.CommandManager.RemoveCanExecuteHandler(dataRecordPresenter, handler);
						}
					}
				}
				finally
				{
					this._isInitializingCache = isInitializingCache;
					this._fieldLayout.BumpLayoutItemVersion();
				}
			}
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x000A3F04 File Offset: 0x000A2104
		private void InitializeCellInfo()
		{
			global::System.Windows.Controls.Panel cellPanel = this.GetCellPanel();
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellPlaceholder> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellPlaceholder>();
			this._virtualizedCellFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			this._unVirtualizedCellFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			this._virtualizedFilterCellFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			this._unVirtualizedFilterCellFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			this._filterCellFieldMap = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FilterCellElementKey, global::Infragistics.Windows.DataPresenter.Field>();
			this._virtualizedLabelFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			this._unVirtualizedLabelFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			this._allFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			this._cellPresenterMargins = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.CellElementKey, global::System.Windows.Thickness>();
			bool flag = this._fieldLayout.DataPresenter != null && this._fieldLayout.DataPresenter.CellContainerGenerationMode == global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode.PreLoad;
			bool useCellPresenters = this._fieldLayout.UseCellPresenters;
			int i = 0;
			int count = cellPanel.Children.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.CellPlaceholder cellPlaceholder = cellPanel.Children[i] as global::Infragistics.Windows.DataPresenter.CellPlaceholder;
				if (cellPlaceholder != null)
				{
					list.Add(cellPlaceholder);
				}
				i++;
			}
			global::System.Comparison<global::Infragistics.Windows.DataPresenter.CellPlaceholder> comparison = delegate(global::Infragistics.Windows.DataPresenter.CellPlaceholder c1, global::Infragistics.Windows.DataPresenter.CellPlaceholder c2)
			{
				global::Infragistics.Windows.DataPresenter.Field field5 = c1.Field;
				global::Infragistics.Windows.DataPresenter.Field field6 = c2.Field;
				int num2 = (field5 != null) ? field5.IndexForCompare : -1;
				int value2 = (field6 != null) ? field6.IndexForCompare : -1;
				return num2.CompareTo(value2);
			};
			list.Sort(global::Infragistics.CoreUtilities.CreateComparer<global::Infragistics.Windows.DataPresenter.CellPlaceholder>(comparison));
			int num = 0;
			int j = 0;
			int count2 = list.Count;
			while (j < count2)
			{
				global::Infragistics.Windows.DataPresenter.CellPlaceholder cellPlaceholder2 = list[j];
				if (cellPlaceholder2 != null)
				{
					global::Infragistics.Windows.DataPresenter.Field field = cellPlaceholder2.Field;
					field.TemplateCellIndex = num;
					num++;
					bool flag2 = !flag && field.AllowCellVirtualizationResolved && (!useCellPresenters || field.AllowLabelVirtualizationResolved);
					field.IsCellVirtualized = flag2;
					if (flag2)
					{
						this._virtualizedCellFields.Add(field);
					}
					else
					{
						this._unVirtualizedFilterCellFields.Add(field);
						field.IsFilterCellVirtualized = false;
						this._unVirtualizedCellFields.Add(field);
					}
					bool flag3 = useCellPresenters ? flag2 : (!flag && field.AllowLabelVirtualizationResolved);
					field.IsLabelVirtualized = flag3;
					if (flag3)
					{
						this._virtualizedLabelFields.Add(field);
					}
					else
					{
						this._unVirtualizedLabelFields.Add(field);
					}
				}
				j++;
			}
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			foreach (global::Infragistics.Windows.DataPresenter.Field field2 in this._virtualizedCellFields)
			{
				if (field2.FilterOperandUITypeResolved == global::Infragistics.Windows.DataPresenter.FilterOperandUIType.None)
				{
					field2.IsFilterCellVirtualized = false;
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.Field field3;
					this._filterCellFieldMap.TryGetValue(field2.FilterCellElementKey, out field3);
					if (field3 == null)
					{
						this._filterCellFieldMap[field2.FilterCellElementKey] = field2;
						field2.IsFilterCellVirtualized = false;
						this._unVirtualizedFilterCellFields.Add(field2);
					}
					else
					{
						field2.IsFilterCellVirtualized = true;
						this._virtualizedFilterCellFields.Add(field2);
					}
				}
			}
			for (int k = this._unVirtualizedFilterCellFields.Count - 1; k >= 0; k--)
			{
				if (this._unVirtualizedFilterCellFields[k].FilterOperandUITypeResolved == global::Infragistics.Windows.DataPresenter.FilterOperandUIType.None)
				{
					this._unVirtualizedFilterCellFields.RemoveAt(k);
				}
			}
			this._allFields.AddRange(this._unVirtualizedCellFields);
			this._allFields.AddRange(this._virtualizedCellFields);
			global::System.Comparison<global::Infragistics.Windows.DataPresenter.Field> comparison2 = (global::Infragistics.Windows.DataPresenter.Field f1, global::Infragistics.Windows.DataPresenter.Field f2) => f1.IndexForCompare.CompareTo(f2.IndexForCompare);
			global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Field> comparer = global::Infragistics.CoreUtilities.CreateComparer<global::Infragistics.Windows.DataPresenter.Field>(comparison2);
			this._allFields.Sort(comparer);
			this._virtualizedCellFields.Sort(comparer);
			this._virtualizedFilterCellFields.Sort(comparer);
			this._virtualizedLabelFields.Sort(comparer);
			this._unVirtualizedCellFields.Sort(comparer);
			this._unVirtualizedFilterCellFields.Sort(comparer);
			this._unVirtualizedLabelFields.Sort(comparer);
			this._cellPlaceHolders = list;
			int l = 0;
			int count3 = list.Count;
			while (l < count3)
			{
				global::Infragistics.Windows.DataPresenter.CellPlaceholder cellPlaceholder3 = list[l];
				if (cellPlaceholder3 != null)
				{
					global::Infragistics.Windows.DataPresenter.Field field4 = cellPlaceholder3.Field;
					if (useCellPresenters && !this._cellPresenterMargins.ContainsKey(field4.CellElementKey) && global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(cellPlaceholder3) > 0)
					{
						global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter = global::System.Windows.Media.VisualTreeHelper.GetChild(cellPlaceholder3, 0) as global::Infragistics.Windows.DataPresenter.CellPresenter;
						if (cellPresenter != null)
						{
							cellPresenter.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
							cellPresenter.Arrange(new global::System.Windows.Rect(cellPresenter.DesiredSize));
							global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase cellPresenterLayoutElementBase = global::Infragistics.Windows.Utilities.GetDescendantFromType(cellPresenter, typeof(global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase), true) as global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase;
							if (cellPresenterLayoutElementBase != null)
							{
								global::System.Windows.Size renderSize = cellPresenterLayoutElementBase.RenderSize;
								global::System.Windows.Point point = cellPresenterLayoutElementBase.TranslatePoint(default(global::System.Windows.Point), cellPresenter);
								global::System.Windows.Point point2 = cellPresenterLayoutElementBase.TranslatePoint(new global::System.Windows.Point(renderSize.Width, renderSize.Height), cellPresenter);
								global::System.Windows.Thickness value = new global::System.Windows.Thickness(point.X, point.Y, cellPresenter.ActualWidth - point2.X, cellPresenter.ActualHeight - point2.Y);
								this._cellPresenterMargins[field4.CellElementKey] = value;
								cellPresenter.InvalidateLayoutElement();
								cellPresenter.InvalidateMeasure();
							}
						}
					}
				}
				l++;
			}
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x000A4400 File Offset: 0x000A2600
		private void InitializeCellPanel(global::System.Windows.Controls.Panel placeholderPanel, bool isLabelPanel)
		{
			if (placeholderPanel == null)
			{
				return;
			}
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fieldLayout.GetAllFields(false))
			{
				if (field.IsInLayout)
				{
					this.AddPlaceholder(placeholderPanel, field, isLabelPanel);
				}
			}
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x000A4464 File Offset: 0x000A2664
		private global::Infragistics.Windows.DataPresenter.GridFieldMap InitializeCompressedFieldMap(bool header)
		{
			global::Infragistics.Windows.DataPresenter.Internal.ExportLayoutInformation exportLayoutInformation = new global::Infragistics.Windows.DataPresenter.Internal.ExportLayoutInformation(this._fieldLayout, header);
			global::Infragistics.Windows.DataPresenter.FieldCollection fields = this._fieldLayout.Fields;
			int count = fields.Count;
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.FieldPosition? fieldPosition = exportLayoutInformation.GetFieldPosition(fields[i], header);
				if (fieldPosition != null)
				{
					num = global::System.Math.Max(fieldPosition.Value.Row + fieldPosition.Value.RowSpan, num);
					num2 = global::System.Math.Max(fieldPosition.Value.Column + fieldPosition.Value.ColumnSpan, num2);
				}
			}
			global::Infragistics.Windows.DataPresenter.GridFieldMap result;
			if (num == 0 || num2 == 0)
			{
				result = this._fieldLayout.StyleGenerator.GridFieldMap;
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.Field[,] array = new global::Infragistics.Windows.DataPresenter.Field[num, num2];
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num2; k++)
					{
						array[j, k] = null;
					}
				}
				for (int l = 0; l < count; l++)
				{
					global::Infragistics.Windows.DataPresenter.Field field = fields[l];
					global::Infragistics.Windows.DataPresenter.FieldPosition? fieldPosition2 = exportLayoutInformation.GetFieldPosition(field, header);
					if (fieldPosition2 != null)
					{
						int row = fieldPosition2.Value.Row;
						int num3 = row + fieldPosition2.Value.RowSpan - 1;
						int column = fieldPosition2.Value.Column;
						int num4 = column + fieldPosition2.Value.ColumnSpan - 1;
						for (int m = row; m <= num3; m++)
						{
							for (int n = column; n <= num4; n++)
							{
								array[m, n] = field;
							}
						}
					}
				}
				result = new global::Infragistics.Windows.DataPresenter.GridFieldMap(this._fieldLayout.StyleGenerator, header, array, exportLayoutInformation);
			}
			return result;
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x000A463C File Offset: 0x000A283C
		private void InitializeGridDefinitionItems()
		{
			this._colLayoutItems = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem>();
			this._rowLayoutItems = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem>();
			this._gridDefinitionSizes = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::System.Windows.Size>();
			global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = this._fieldLayout.StyleGenerator;
			if (styleGenerator == null)
			{
				return;
			}
			if (!styleGenerator.IsGeneratingTemplates)
			{
				styleGenerator.GenerateTemplates();
			}
			global::System.Windows.Controls.ColumnDefinition defaultColumnDefinition = styleGenerator.DefaultColumnDefinition;
			global::System.Windows.Controls.RowDefinition defaultRowDefinition = styleGenerator.DefaultRowDefinition;
			global::System.Windows.Controls.Grid templateGrid = styleGenerator.TemplateGrid;
			bool useCellPresenters = this._fieldLayout.UseCellPresenters;
			if (templateGrid != null)
			{
				this._templateGridSize = new global::System.Windows.Size(templateGrid.Width, templateGrid.Height);
			}
			global::System.Collections.Generic.List<global::System.Windows.Controls.ColumnDefinition> list = new global::System.Collections.Generic.List<global::System.Windows.Controls.ColumnDefinition>();
			global::System.Collections.Generic.List<global::System.Windows.Controls.RowDefinition> list2 = new global::System.Collections.Generic.List<global::System.Windows.Controls.RowDefinition>();
			int i = 0;
			int totalColumnsGenerated = this._fieldLayout.TotalColumnsGenerated;
			while (i < totalColumnsGenerated)
			{
				global::System.Windows.Controls.ColumnDefinition item = (templateGrid == null || i >= templateGrid.ColumnDefinitions.Count) ? defaultColumnDefinition : templateGrid.ColumnDefinitions[i];
				list.Add(item);
				i++;
			}
			int j = 0;
			int totalRowsGenerated = this._fieldLayout.TotalRowsGenerated;
			while (j < totalRowsGenerated)
			{
				global::System.Windows.Controls.RowDefinition item2 = (templateGrid == null || j >= templateGrid.RowDefinitions.Count) ? defaultRowDefinition : templateGrid.RowDefinitions[j];
				list2.Add(item2);
				j++;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
			bool isAutoFitWidth = this._fieldLayout.IsAutoFitWidth;
			bool isAutoFitHeight = this._fieldLayout.IsAutoFitHeight;
			bool flag = false;
			bool flag2 = false;
			if (isAutoFitWidth)
			{
				int k = 0;
				int count = list.Count;
				while (k < count)
				{
					if (!list[k].Width.IsStar || !global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(1.0, list[k].Width.Value))
					{
						flag = true;
						break;
					}
					k++;
				}
			}
			else
			{
				flag = true;
			}
			if (isAutoFitHeight)
			{
				int l = 0;
				int count2 = list2.Count;
				while (l < count2)
				{
					if (!list2[l].Height.IsStar || !global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(1.0, list2[l].Height.Value))
					{
						flag2 = true;
						break;
					}
					l++;
				}
			}
			else
			{
				flag2 = true;
			}
			if (flag)
			{
				int m = 0;
				int count3 = list.Count;
				while (m < count3)
				{
					global::System.Windows.Controls.ColumnDefinition col = list[m];
					if (global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem.IsItemNeeded(col))
					{
						this._colLayoutItems.Add(new global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem(col, m, useCellPresenters));
					}
					m++;
				}
			}
			if (flag2)
			{
				int n = 0;
				int count4 = list2.Count;
				while (n < count4)
				{
					global::System.Windows.Controls.RowDefinition row = list2[n];
					if (global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem.IsItemNeeded(row))
					{
						this._rowLayoutItems.Add(new global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem(row, n, useCellPresenters));
					}
					n++;
				}
			}
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fieldLayout.GetAllFields(false))
			{
				if (field.IsInLayout)
				{
					global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition = field.GridPosition;
					global::System.Windows.Size value = new global::System.Windows.Size(double.NaN, double.NaN);
					if (gridPosition.ColumnSpan == 1)
					{
						global::System.Windows.Controls.ColumnDefinition columnDefinition = list[gridPosition.Column];
						if (columnDefinition.Width.IsAbsolute)
						{
							value.Width = columnDefinition.Width.Value;
						}
					}
					if (gridPosition.RowSpan == 1)
					{
						global::System.Windows.Controls.RowDefinition rowDefinition = list2[gridPosition.Row];
						if (rowDefinition.Height.IsAbsolute)
						{
							value.Height = rowDefinition.Height.Value;
						}
					}
					if (!double.IsNaN(value.Width) || !double.IsNaN(value.Height))
					{
						this._gridDefinitionSizes.Add(field, value);
					}
				}
			}
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x000A4A20 File Offset: 0x000A2C20
		private void InitializeGroupByRecordCache()
		{
			global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter groupByRecordPresenter = new global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter();
			this._lastGroupByPresenter = groupByRecordPresenter;
			groupByRecordPresenter.Tag = global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateRecordPresenterId;
			this._fieldLayout.DataPresenter.InternalAddLogicalChild(groupByRecordPresenter);
			groupByRecordPresenter.PrepareContainerForItem(this._fieldLayout.TemplateGroupByRecord);
			groupByRecordPresenter.DataContext = this._fieldLayout.TemplateGroupByRecord;
			groupByRecordPresenter.InitializeGroupByRecordContentVisibility(true);
			global::System.Windows.FrameworkElement frameworkElement = new global::System.Windows.FrameworkElement();
			groupByRecordPresenter.InitializeNestedContent(frameworkElement);
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.ApplyTemplateRecursively(groupByRecordPresenter);
			global::Infragistics.Windows.Controls.ExpansionIndicator expansionIndicator = global::Infragistics.Windows.DataPresenter.GridUtilities.GetExpansionIndicator(groupByRecordPresenter);
			if (expansionIndicator != null)
			{
				expansionIndicator.Visibility = global::System.Windows.Visibility.Visible;
			}
			groupByRecordPresenter.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
			groupByRecordPresenter.Arrange(new global::System.Windows.Rect(this._lastGroupByPresenter.DesiredSize));
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			global::System.Windows.FrameworkElement nestedContentSite = groupByRecordPresenter.GetNestedContentSite();
			if (nestedContentSite != null)
			{
				global::System.Windows.Size desiredSize = frameworkElement.DesiredSize;
				global::System.Windows.Size desiredSize2 = nestedContentSite.DesiredSize;
				global::System.Windows.Point point = frameworkElement.TranslatePoint(default(global::System.Windows.Point), nestedContentSite);
				global::System.Windows.Point point2 = frameworkElement.TranslatePoint(new global::System.Windows.Point(desiredSize.Width, desiredSize.Height), nestedContentSite);
				if (isHorizontal)
				{
					this._nearOffsetGroupByChrome = point.Y;
					this._farOffsetGroupByChrome = desiredSize2.Height - point2.Y;
				}
				else
				{
					this._nearOffsetGroupByChrome = point.X;
					this._farOffsetGroupByChrome = desiredSize2.Width - point2.X;
				}
			}
			global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.GetRecordOffset(this._lastGroupByPresenter, out this._nearOffsetGroupByRecord, out this._farOffsetGroupByRecord);
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x000A4B94 File Offset: 0x000A2D94
		private void ReinitializeCellInfo()
		{
			bool isInitializingCache = this._isInitializingCache;
			try
			{
				this._isInitializingCache = true;
				this.VerifyCellPanel(this._lastCellPanel, false);
				this.VerifyCellPanel(this._lastLabelPanel, true);
				this.InitializeCellInfo();
			}
			finally
			{
				this._isInitializingCache = isInitializingCache;
				if (!this._isInitializingCache)
				{
					this._fieldLayout.BumpLayoutItemVersion();
				}
			}
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x000A4BFC File Offset: 0x000A2DFC
		private void VerifyCache()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this._fieldLayout.AlignmentFieldLayout;
			if (alignmentFieldLayout != null)
			{
				alignmentFieldLayout.TemplateDataRecordCache.VerifyCache();
			}
			if (this._lastCellArea == null)
			{
				this.InitializeCachedCellArea();
				return;
			}
			if (this._cacheVersion != this._verifiedCacheVersion)
			{
				if (global::Infragistics.Windows.DataPresenter.CellPlaceholder.IsInMeasure)
				{
					return;
				}
				this._verifiedCacheVersion = this._cacheVersion;
				this._fieldLayout.VerifyStyleGeneratorTemplates();
				if (this._lastCellArea == null)
				{
					this.InitializeCachedCellArea();
					return;
				}
				this.ReinitializeCellInfo();
			}
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x000A4C74 File Offset: 0x000A2E74
		private void VerifyCellPanel(global::System.Windows.Controls.Panel cellPanel, bool isLabel)
		{
			if (cellPanel == null)
			{
				return;
			}
			global::System.Collections.IDictionary dictionary;
			if (!isLabel)
			{
				global::System.Collections.IDictionary cellElements = this._cellElements;
				dictionary = cellElements;
			}
			else
			{
				dictionary = this._labelElements;
			}
			global::System.Collections.IDictionary dictionary2 = dictionary;
			if (dictionary2 != null)
			{
				dictionary2.Clear();
			}
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.CellPlaceholder> dictionary3 = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.CellPlaceholder>();
			for (int i = cellPanel.Children.Count - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.DataPresenter.CellPlaceholder cellPlaceholder = cellPanel.Children[i] as global::Infragistics.Windows.DataPresenter.CellPlaceholder;
				if (cellPlaceholder != null)
				{
					global::Infragistics.Windows.DataPresenter.Field field = cellPlaceholder.Field;
					if (cellPlaceholder.ChildCellElement != null)
					{
						global::Infragistics.Windows.DataPresenter.Field fieldFromControl = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldFromControl(cellPlaceholder.ChildCellElement);
						if (fieldFromControl == null || !fieldFromControl.IsValid || !fieldFromControl.IsInLayout)
						{
							cellPanel.Children.RemoveAt(i);
							goto IL_AD;
						}
						if (fieldFromControl == field)
						{
							this.CacheCellElement(field, cellPlaceholder.ChildCellElement, isLabel);
						}
					}
					dictionary3[field] = cellPlaceholder;
				}
				IL_AD:;
			}
			foreach (global::Infragistics.Windows.DataPresenter.Field field2 in this._fieldLayout.GetAllFields(true))
			{
				global::Infragistics.Windows.DataPresenter.CellPlaceholder element;
				if (!dictionary3.TryGetValue(field2, out element))
				{
					if (!field2.IsInLayout)
					{
						field2.TemplateCellIndex = -1;
					}
					else
					{
						this.AddPlaceholder(cellPanel, field2, isLabel);
					}
				}
				else if (!field2.IsInLayout)
				{
					field2.TemplateCellIndex = -1;
					cellPanel.Children.Remove(element);
				}
			}
			cellPanel.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x000A4DE4 File Offset: 0x000A2FE4
		internal void VerifyTemplateRecordPanel(global::System.Windows.Controls.Panel panel, global::Infragistics.Windows.DataPresenter.RecordPresenter rp)
		{
			if (rp == this._lastRecordPresenter)
			{
				if (this.IsInitializingCache)
				{
					return;
				}
				if (panel == this._lastCellPanel || panel == this._lastLabelPanel)
				{
					return;
				}
				this.ReleaseCache();
				this._fieldLayout.BumpLayoutItemVersion();
			}
		}

		// Token: 0x04001241 RID: 4673
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04001242 RID: 4674
		private global::Infragistics.Windows.DataPresenter.DataRecordPresenter _lastRecordPresenter;

		// Token: 0x04001243 RID: 4675
		private global::Infragistics.Windows.DataPresenter.DataRecordCellArea _lastCellArea;

		// Token: 0x04001244 RID: 4676
		private global::System.Windows.Controls.Panel _lastCellPanel;

		// Token: 0x04001245 RID: 4677
		private global::System.Windows.Controls.Panel _lastLabelPanel;

		// Token: 0x04001246 RID: 4678
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellPlaceholder> _cellPlaceHolders;

		// Token: 0x04001247 RID: 4679
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.CellElementKey, global::System.Windows.Controls.Control> _cellElements;

		// Token: 0x04001248 RID: 4680
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.LabelElementKey, global::System.Windows.Controls.Control> _labelElements;

		// Token: 0x04001249 RID: 4681
		private bool _isInitializingCache;

		// Token: 0x0400124A RID: 4682
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _virtualizedCellFields;

		// Token: 0x0400124B RID: 4683
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _unVirtualizedCellFields;

		// Token: 0x0400124C RID: 4684
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _virtualizedFilterCellFields;

		// Token: 0x0400124D RID: 4685
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _unVirtualizedFilterCellFields;

		// Token: 0x0400124E RID: 4686
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FilterCellElementKey, global::Infragistics.Windows.DataPresenter.Field> _filterCellFieldMap;

		// Token: 0x0400124F RID: 4687
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _virtualizedLabelFields;

		// Token: 0x04001250 RID: 4688
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _unVirtualizedLabelFields;

		// Token: 0x04001251 RID: 4689
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem> _rowLayoutItems;

		// Token: 0x04001252 RID: 4690
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem> _colLayoutItems;

		// Token: 0x04001253 RID: 4691
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::System.Windows.Size> _gridDefinitionSizes;

		// Token: 0x04001254 RID: 4692
		internal static readonly global::System.Windows.Size NaNSize = new global::System.Windows.Size(double.NaN, double.NaN);

		// Token: 0x04001255 RID: 4693
		private global::System.Windows.Size _templateGridSize = global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.NaNSize;

		// Token: 0x04001256 RID: 4694
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _allFields;

		// Token: 0x04001257 RID: 4695
		private double _nearOffsetDataRecord;

		// Token: 0x04001258 RID: 4696
		private double _nearOffsetGroupByRecord = double.NaN;

		// Token: 0x04001259 RID: 4697
		private double _nearOffsetExpandableFieldRecord = double.NaN;

		// Token: 0x0400125A RID: 4698
		private double _farOffsetDataRecord;

		// Token: 0x0400125B RID: 4699
		private double _farOffsetGroupByRecord = double.NaN;

		// Token: 0x0400125C RID: 4700
		private double _farOffsetExpandableFieldRecord = double.NaN;

		// Token: 0x0400125D RID: 4701
		private double _nearOffsetVirtualizingPanel;

		// Token: 0x0400125E RID: 4702
		private double _farOffsetVirtualizingPanel;

		// Token: 0x0400125F RID: 4703
		private double _nearOffsetVirtualizingPanelToRP;

		// Token: 0x04001260 RID: 4704
		private double _farOffsetVirtualizingPanelToRP;

		// Token: 0x04001261 RID: 4705
		private double _nearOffsetGroupByChrome = double.NaN;

		// Token: 0x04001262 RID: 4706
		private double _nearOffsetExpandableFieldChrome = double.NaN;

		// Token: 0x04001263 RID: 4707
		private double _nearOffsetDataRecordChrome = double.NaN;

		// Token: 0x04001264 RID: 4708
		private double _farOffsetDataRecordChrome = double.NaN;

		// Token: 0x04001265 RID: 4709
		private double _farOffsetGroupByChrome = double.NaN;

		// Token: 0x04001266 RID: 4710
		private double _farOffsetExpandableFieldChrome = double.NaN;

		// Token: 0x04001267 RID: 4711
		private global::System.Collections.Generic.List<global::System.Windows.Size> _levelRecordNumberSizes;

		// Token: 0x04001268 RID: 4712
		private global::System.Windows.Size _largestRecordNumberSize;

		// Token: 0x04001269 RID: 4713
		private global::System.Collections.Generic.List<global::System.Windows.Controls.Control> _cellElementsInReportOrder;

		// Token: 0x0400126A RID: 4714
		private global::System.Collections.Generic.Dictionary<double, global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo> _reportLayoutInfos;

		// Token: 0x0400126B RID: 4715
		private global::System.Collections.Generic.Dictionary<int, double> _reportLayoutNestingDepthOffsetCache;

		// Token: 0x0400126C RID: 4716
		private double _lastPanelExtent;

		// Token: 0x0400126D RID: 4717
		private bool _lastIsHorizontal;

		// Token: 0x0400126E RID: 4718
		private global::Infragistics.Windows.DataPresenter.CellPageSpanStrategy _lastCellPageSpanStrategy;

		// Token: 0x0400126F RID: 4719
		[global::System.ThreadStatic]
		private static double s_lastZeroIndentOffset = 20.0;

		// Token: 0x04001270 RID: 4720
		private int _cacheVersion = 1;

		// Token: 0x04001271 RID: 4721
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.CellElementKey, global::System.Windows.Thickness> _cellPresenterMargins;

		// Token: 0x04001272 RID: 4722
		private int _verifiedCacheVersion = -1;

		// Token: 0x04001273 RID: 4723
		private global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter _lastGroupByPresenter;

		// Token: 0x04001274 RID: 4724
		private global::System.Collections.Generic.Dictionary<int, double> _autoFitCellAreaWidthCache;

		// Token: 0x04001275 RID: 4725
		private global::System.Collections.Generic.Dictionary<int, double> _autoFitCellAreaHeightCache;

		// Token: 0x04001276 RID: 4726
		private global::Infragistics.Windows.DataPresenter.GridFieldMap _cellFieldMap;

		// Token: 0x04001277 RID: 4727
		private global::Infragistics.Windows.DataPresenter.GridFieldMap _labelFieldMap;

		// Token: 0x04001278 RID: 4728
		private int _verifiedSummaryFieldsVersion = -1;

		// Token: 0x04001279 RID: 4729
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.SummaryDisplayAreaContext, global::System.Tuple<global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field>, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field>>> _virtualizedSummaryFieldCache;

		// Token: 0x0400127A RID: 4730
		internal static readonly global::System.Windows.DependencyProperty IsTemplateRecordPanelProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsTemplateRecordPanel", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.OnIsTemplateRecordPanelChanged)));

		// Token: 0x02000301 RID: 769
		private class ReportElementComparer : global::System.Collections.IComparer
		{
			// Token: 0x06002530 RID: 9520 RVA: 0x000A4E8C File Offset: 0x000A308C
			internal ReportElementComparer(bool isVertical)
			{
				this._isVertical = isVertical;
			}

			// Token: 0x06002531 RID: 9521 RVA: 0x000A4E9C File Offset: 0x000A309C
			public int Compare(object x, object y)
			{
				global::System.Windows.Controls.Control control = x as global::System.Windows.Controls.Control;
				global::System.Windows.Controls.Control control2 = y as global::System.Windows.Controls.Control;
				if (control == control2)
				{
					return 0;
				}
				if (control2 == null)
				{
					return 1;
				}
				if (control == null)
				{
					return -1;
				}
				global::Infragistics.Windows.DataPresenter.Field fieldFromControl = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldFromControl(control);
				global::Infragistics.Windows.DataPresenter.Field fieldFromControl2 = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldFromControl(control2);
				if (fieldFromControl == fieldFromControl2)
				{
					return 0;
				}
				if (fieldFromControl2 == null)
				{
					return 1;
				}
				if (fieldFromControl == null)
				{
					return -1;
				}
				global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition = fieldFromControl.GridPosition;
				global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition2 = fieldFromControl2.GridPosition;
				int num;
				int num2;
				int num3;
				int num4;
				if (this._isVertical)
				{
					num = gridPosition.Column;
					num2 = gridPosition.ColumnSpan;
					num3 = gridPosition2.Column;
					num4 = gridPosition2.ColumnSpan;
				}
				else
				{
					num = gridPosition.Row;
					num2 = gridPosition.RowSpan;
					num3 = gridPosition2.Row;
					num4 = gridPosition2.RowSpan;
				}
				int num5 = num + num2;
				int num6 = num3 + num4;
				if (num < num3)
				{
					return -1;
				}
				if (num > num3)
				{
					return 1;
				}
				if (num5 < num6)
				{
					return -1;
				}
				if (num5 > num6)
				{
					return 1;
				}
				return 0;
			}

			// Token: 0x04001280 RID: 4736
			private bool _isVertical;
		}
	}
}
