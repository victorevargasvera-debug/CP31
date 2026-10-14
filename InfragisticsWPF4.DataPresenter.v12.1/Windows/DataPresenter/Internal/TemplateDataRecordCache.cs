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
	// Token: 0x020002C1 RID: 705
	internal class TemplateDataRecordCache
	{
		// Token: 0x06002159 RID: 8537 RVA: 0x0008F918 File Offset: 0x0008DB18
		internal TemplateDataRecordCache(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			this._fieldLayout = fieldLayout;
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x0600215A RID: 8538 RVA: 0x0008F9E1 File Offset: 0x0008DBE1
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> AllFields
		{
			get
			{
				this.VerifyCache();
				return this._allFields;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x0008F9EF File Offset: 0x0008DBEF
		internal int CacheVersion
		{
			get
			{
				return this._cacheVersion;
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x0008F9F8 File Offset: 0x0008DBF8
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

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x0008FA89 File Offset: 0x0008DC89
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

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x0008FA9F File Offset: 0x0008DC9F
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

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x0008FAB5 File Offset: 0x0008DCB5
		internal bool IsInitializingCache
		{
			get
			{
				return this._isInitializingCache;
			}
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x0008FABD File Offset: 0x0008DCBD
		private static bool GetIsTemplateRecordPanel(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.IsTemplateRecordPanelProperty);
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x0008FACF File Offset: 0x0008DCCF
		private static void SetIsTemplateRecordPanel(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.IsTemplateRecordPanelProperty, value);
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x0008FAE4 File Offset: 0x0008DCE4
		private static void OnIsTemplateRecordPanelChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (true.Equals(e.NewValue))
			{
				d.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::System.Windows.Threading.DispatcherOperationCallback(global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.VerifyTemplateCache), d);
			}
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x0008FB20 File Offset: 0x0008DD20
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

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06002164 RID: 8548 RVA: 0x0008FB6C File Offset: 0x0008DD6C
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> NonVirtualizedCellFields
		{
			get
			{
				this.VerifyCache();
				return this._unVirtualizedCellFields;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x0008FB7A File Offset: 0x0008DD7A
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> NonVirtualizedFilterCellFields
		{
			get
			{
				this.VerifyCache();
				return this._unVirtualizedFilterCellFields;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x0008FB88 File Offset: 0x0008DD88
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> NonVirtualizedLabelFields
		{
			get
			{
				this.VerifyCache();
				return this._unVirtualizedLabelFields;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x0008FB96 File Offset: 0x0008DD96
		internal global::System.Windows.Size TemplateGridSize
		{
			get
			{
				if (this._rowLayoutItems == null)
				{
					this.InitializeGridDefinitionItems();
				}
				return this._templateGridSize;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x0008FBAC File Offset: 0x0008DDAC
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> VirtualizedCellFields
		{
			get
			{
				this.VerifyCache();
				return this._virtualizedCellFields;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x0008FBBA File Offset: 0x0008DDBA
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> VirtualizedFilterCellFields
		{
			get
			{
				this.VerifyCache();
				return this._virtualizedFilterCellFields;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x0008FBC8 File Offset: 0x0008DDC8
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> VirtualizedLabelFields
		{
			get
			{
				this.VerifyCache();
				return this._virtualizedLabelFields;
			}
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x0008FBD6 File Offset: 0x0008DDD6
		internal void BumpCacheVersion(bool releaseCache)
		{
			if (releaseCache)
			{
				this.ReleaseCache();
				return;
			}
			this._cacheVersion++;
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x0008FBF0 File Offset: 0x0008DDF0
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

		// Token: 0x0600216D RID: 8557 RVA: 0x0008FC54 File Offset: 0x0008DE54
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

		// Token: 0x0600216E RID: 8558 RVA: 0x0008FCF8 File Offset: 0x0008DEF8
		internal double? GetCachedAutoFitHeight(global::Infragistics.Windows.DataPresenter.Record rcd)
		{
			double naN = double.NaN;
			if (this._autoFitCellAreaHeightCache != null && this._autoFitCellAreaHeightCache.TryGetValue(rcd.NestingDepth, out naN) && !double.IsNaN(naN))
			{
				return new double?(naN);
			}
			return null;
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x0008FD44 File Offset: 0x0008DF44
		internal double? GetCachedAutoFitWidth(global::Infragistics.Windows.DataPresenter.Record rcd)
		{
			double naN = double.NaN;
			if (this._autoFitCellAreaWidthCache != null && this._autoFitCellAreaWidthCache.TryGetValue(rcd.NestingDepth, out naN) && !double.IsNaN(naN))
			{
				return new double?(naN);
			}
			return null;
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x0008FD90 File Offset: 0x0008DF90
		internal int GetCellCount()
		{
			this.VerifyCache();
			if (this._cellPlaceHolders == null)
			{
				return 0;
			}
			return this._cellPlaceHolders.Count;
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x0008FDAD File Offset: 0x0008DFAD
		internal global::System.Windows.Controls.Control GetCellElement(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this.GetCellElement(field, false);
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x0008FDB8 File Offset: 0x0008DFB8
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

		// Token: 0x06002173 RID: 8563 RVA: 0x0008FE0B File Offset: 0x0008E00B
		internal global::Infragistics.Windows.DataPresenter.CellPlaceholder GetCellPlaceHolder(int index)
		{
			this.VerifyCache();
			return this._cellPlaceHolders[index];
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x0008FE1F File Offset: 0x0008E01F
		internal global::Infragistics.Windows.DataPresenter.CellValuePresenter GetCellValuePresenter(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this.GetCellValuePresenter(field, false);
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x0008FE2C File Offset: 0x0008E02C
		internal global::Infragistics.Windows.DataPresenter.CellValuePresenter GetCellValuePresenter(global::Infragistics.Windows.DataPresenter.Field field, bool createIfNull)
		{
			this.VerifyCache();
			global::System.Windows.FrameworkElement cellElement = this.GetCellElement(field);
			if (createIfNull && cellElement == null && this._lastCellPanel != null && field != null && field.Index >= 0)
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

		// Token: 0x06002176 RID: 8566 RVA: 0x0008FEB0 File Offset: 0x0008E0B0
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

		// Token: 0x06002177 RID: 8567 RVA: 0x0008FEF8 File Offset: 0x0008E0F8
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

		// Token: 0x06002178 RID: 8568 RVA: 0x0008FF44 File Offset: 0x0008E144
		internal double GetCellValuePresenterHeight(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::System.Windows.Size size;
			if (this.GetCellValuePresenterDesiredSize(field, out size))
			{
				return size.Height;
			}
			return double.NaN;
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x0008FF70 File Offset: 0x0008E170
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

		// Token: 0x0600217A RID: 8570 RVA: 0x0008FFA4 File Offset: 0x0008E1A4
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

		// Token: 0x0600217B RID: 8571 RVA: 0x0008FFE7 File Offset: 0x0008E1E7
		internal global::Infragistics.Windows.DataPresenter.Field GetField(int index)
		{
			return this.GetCellPlaceHolder(index).Field;
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x0008FFF5 File Offset: 0x0008E1F5
		internal int GetFieldIndex(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.VerifyCache();
			return field.TemplateCellIndex;
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x00090004 File Offset: 0x0008E204
		internal global::Infragistics.Windows.DataPresenter.Field GetFilterFieldToMeasure(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.VerifyCache();
			global::Infragistics.Windows.DataPresenter.Field result;
			this._filterCellFieldMap.TryGetValue(field.FilterCellElementKey, out result);
			return result;
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x0009002C File Offset: 0x0008E22C
		internal double GetLabelPresenterHeight(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::System.Windows.Size size;
			if (this.GetLabelPresenterDesiredSize(field, out size))
			{
				return size.Height;
			}
			return double.NaN;
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x00090058 File Offset: 0x0008E258
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

		// Token: 0x06002180 RID: 8576 RVA: 0x000900B0 File Offset: 0x0008E2B0
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

		// Token: 0x06002181 RID: 8577 RVA: 0x00090124 File Offset: 0x0008E324
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

		// Token: 0x06002182 RID: 8578 RVA: 0x00090368 File Offset: 0x0008E568
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

		// Token: 0x06002183 RID: 8579 RVA: 0x000903E0 File Offset: 0x0008E5E0
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

		// Token: 0x06002184 RID: 8580 RVA: 0x0009041C File Offset: 0x0008E61C
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

		// Token: 0x06002185 RID: 8581 RVA: 0x00090454 File Offset: 0x0008E654
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

		// Token: 0x06002186 RID: 8582 RVA: 0x00090570 File Offset: 0x0008E770
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

		// Token: 0x06002187 RID: 8583 RVA: 0x0009073C File Offset: 0x0008E93C
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
			int num2 = (record != null) ? record.NestingDepth : 0;
			double num3;
			if (recordOffset != null)
			{
				num3 = recordOffset.Value;
				if (num2 == 0)
				{
					global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.s_lastZeroIndentOffset = num3;
				}
			}
			else if (num2 > 0 && this._reportLayoutNestingDepthOffsetCache != null && this._reportLayoutNestingDepthOffsetCache.ContainsKey(num2))
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

		// Token: 0x06002188 RID: 8584 RVA: 0x0009092B File Offset: 0x0008EB2B
		internal bool IsTemplateRecordPresenter(global::Infragistics.Windows.DataPresenter.DataRecordPresenter rp)
		{
			return rp != null && rp == this._lastRecordPresenter;
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x0009093C File Offset: 0x0008EB3C
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

		// Token: 0x0600218A RID: 8586 RVA: 0x00090980 File Offset: 0x0008EB80
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

		// Token: 0x0600218B RID: 8587 RVA: 0x000909B8 File Offset: 0x0008EBB8
		internal void ReleaseCache()
		{
			if (this._lastRecordPresenter != null)
			{
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
				lastRecordPresenter.ClearValue(global::System.Windows.FrameworkElement.DataContextProperty);
				lastGroupByPresenter.ClearValue(global::System.Windows.FrameworkElement.DataContextProperty);
			}
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00090B89 File Offset: 0x0008ED89
		internal void SetCachedAutoFitHeight(global::Infragistics.Windows.DataPresenter.Record rcd, double height)
		{
			if (this._autoFitCellAreaHeightCache == null)
			{
				this._autoFitCellAreaHeightCache = new global::System.Collections.Generic.Dictionary<int, double>();
			}
			this._autoFitCellAreaHeightCache[rcd.NestingDepth] = height;
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00090BB0 File Offset: 0x0008EDB0
		internal void SetCachedAutoFitWidth(global::Infragistics.Windows.DataPresenter.Record rcd, double width)
		{
			if (this._autoFitCellAreaWidthCache == null)
			{
				this._autoFitCellAreaWidthCache = new global::System.Collections.Generic.Dictionary<int, double>();
			}
			this._autoFitCellAreaWidthCache[rcd.NestingDepth] = width;
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x00090BD7 File Offset: 0x0008EDD7
		internal void Verify()
		{
			this.VerifyCache();
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00090BE0 File Offset: 0x0008EDE0
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

		// Token: 0x06002190 RID: 8592 RVA: 0x00090C48 File Offset: 0x0008EE48
		internal global::System.Windows.Controls.Panel GetCellPanel()
		{
			this.VerifyCache();
			return this._lastCellPanel;
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x00090C68 File Offset: 0x0008EE68
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
									this._nearOffsetVirtualizingPanel = (isHorizontal ? point3.Y : point3.X);
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

		// Token: 0x06002192 RID: 8594 RVA: 0x000910B8 File Offset: 0x0008F2B8
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
				int num2 = (field5 != null) ? field5.Index : -1;
				int value2 = (field6 != null) ? field6.Index : -1;
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
			global::System.Comparison<global::Infragistics.Windows.DataPresenter.Field> comparison2 = (global::Infragistics.Windows.DataPresenter.Field f1, global::Infragistics.Windows.DataPresenter.Field f2) => f1.Index.CompareTo(f2.Index);
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

		// Token: 0x06002193 RID: 8595 RVA: 0x000915B4 File Offset: 0x0008F7B4
		private void InitializeCellPanel(global::System.Windows.Controls.Panel placeholderPanel, bool isLabelPanel)
		{
			if (placeholderPanel == null)
			{
				return;
			}
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fieldLayout.Fields)
			{
				if (field.IsInLayout)
				{
					this.AddPlaceholder(placeholderPanel, field, isLabelPanel);
				}
			}
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x00091618 File Offset: 0x0008F818
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
			int num = 0;
			int count5 = this._fieldLayout.Fields.Count;
			while (num < count5)
			{
				global::Infragistics.Windows.DataPresenter.Field field = this._fieldLayout.Fields[num];
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
				num++;
			}
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x000919EC File Offset: 0x0008FBEC
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

		// Token: 0x06002196 RID: 8598 RVA: 0x00091B60 File Offset: 0x0008FD60
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

		// Token: 0x06002197 RID: 8599 RVA: 0x00091BC8 File Offset: 0x0008FDC8
		private void VerifyCache()
		{
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

		// Token: 0x06002198 RID: 8600 RVA: 0x00091C28 File Offset: 0x0008FE28
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
						if (fieldFromControl == null || fieldFromControl.Index < 0 || !fieldFromControl.IsInLayout)
						{
							cellPanel.Children.RemoveAt(i);
							goto IL_AE;
						}
						if (fieldFromControl == field)
						{
							this.CacheCellElement(field, cellPlaceholder.ChildCellElement, isLabel);
						}
					}
					dictionary3[field] = cellPlaceholder;
				}
				IL_AE:;
			}
			foreach (global::Infragistics.Windows.DataPresenter.Field field2 in this._fieldLayout.Fields)
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

		// Token: 0x06002199 RID: 8601 RVA: 0x00091D98 File Offset: 0x0008FF98
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

		// Token: 0x04001038 RID: 4152
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04001039 RID: 4153
		private global::Infragistics.Windows.DataPresenter.DataRecordPresenter _lastRecordPresenter;

		// Token: 0x0400103A RID: 4154
		private global::Infragistics.Windows.DataPresenter.DataRecordCellArea _lastCellArea;

		// Token: 0x0400103B RID: 4155
		private global::System.Windows.Controls.Panel _lastCellPanel;

		// Token: 0x0400103C RID: 4156
		private global::System.Windows.Controls.Panel _lastLabelPanel;

		// Token: 0x0400103D RID: 4157
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellPlaceholder> _cellPlaceHolders;

		// Token: 0x0400103E RID: 4158
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.CellElementKey, global::System.Windows.Controls.Control> _cellElements;

		// Token: 0x0400103F RID: 4159
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.LabelElementKey, global::System.Windows.Controls.Control> _labelElements;

		// Token: 0x04001040 RID: 4160
		private bool _isInitializingCache;

		// Token: 0x04001041 RID: 4161
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _virtualizedCellFields;

		// Token: 0x04001042 RID: 4162
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _unVirtualizedCellFields;

		// Token: 0x04001043 RID: 4163
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _virtualizedFilterCellFields;

		// Token: 0x04001044 RID: 4164
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _unVirtualizedFilterCellFields;

		// Token: 0x04001045 RID: 4165
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FilterCellElementKey, global::Infragistics.Windows.DataPresenter.Field> _filterCellFieldMap;

		// Token: 0x04001046 RID: 4166
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _virtualizedLabelFields;

		// Token: 0x04001047 RID: 4167
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _unVirtualizedLabelFields;

		// Token: 0x04001048 RID: 4168
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem> _rowLayoutItems;

		// Token: 0x04001049 RID: 4169
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem> _colLayoutItems;

		// Token: 0x0400104A RID: 4170
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::System.Windows.Size> _gridDefinitionSizes;

		// Token: 0x0400104B RID: 4171
		internal static readonly global::System.Windows.Size NaNSize = new global::System.Windows.Size(double.NaN, double.NaN);

		// Token: 0x0400104C RID: 4172
		private global::System.Windows.Size _templateGridSize = global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.NaNSize;

		// Token: 0x0400104D RID: 4173
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _allFields;

		// Token: 0x0400104E RID: 4174
		private double _nearOffsetDataRecord;

		// Token: 0x0400104F RID: 4175
		private double _nearOffsetGroupByRecord = double.NaN;

		// Token: 0x04001050 RID: 4176
		private double _nearOffsetExpandableFieldRecord = double.NaN;

		// Token: 0x04001051 RID: 4177
		private double _farOffsetDataRecord;

		// Token: 0x04001052 RID: 4178
		private double _farOffsetGroupByRecord = double.NaN;

		// Token: 0x04001053 RID: 4179
		private double _farOffsetExpandableFieldRecord = double.NaN;

		// Token: 0x04001054 RID: 4180
		private double _nearOffsetVirtualizingPanel;

		// Token: 0x04001055 RID: 4181
		private double _farOffsetVirtualizingPanel;

		// Token: 0x04001056 RID: 4182
		private double _nearOffsetGroupByChrome = double.NaN;

		// Token: 0x04001057 RID: 4183
		private double _nearOffsetExpandableFieldChrome = double.NaN;

		// Token: 0x04001058 RID: 4184
		private double _nearOffsetDataRecordChrome = double.NaN;

		// Token: 0x04001059 RID: 4185
		private double _farOffsetDataRecordChrome = double.NaN;

		// Token: 0x0400105A RID: 4186
		private double _farOffsetGroupByChrome = double.NaN;

		// Token: 0x0400105B RID: 4187
		private double _farOffsetExpandableFieldChrome = double.NaN;

		// Token: 0x0400105C RID: 4188
		private global::System.Collections.Generic.List<global::System.Windows.Controls.Control> _cellElementsInReportOrder;

		// Token: 0x0400105D RID: 4189
		private global::System.Collections.Generic.Dictionary<double, global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo> _reportLayoutInfos;

		// Token: 0x0400105E RID: 4190
		private global::System.Collections.Generic.Dictionary<int, double> _reportLayoutNestingDepthOffsetCache;

		// Token: 0x0400105F RID: 4191
		private double _lastPanelExtent;

		// Token: 0x04001060 RID: 4192
		private bool _lastIsHorizontal;

		// Token: 0x04001061 RID: 4193
		private global::Infragistics.Windows.DataPresenter.CellPageSpanStrategy _lastCellPageSpanStrategy;

		// Token: 0x04001062 RID: 4194
		[global::System.ThreadStatic]
		private static double s_lastZeroIndentOffset = 20.0;

		// Token: 0x04001063 RID: 4195
		private int _cacheVersion = 1;

		// Token: 0x04001064 RID: 4196
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.CellElementKey, global::System.Windows.Thickness> _cellPresenterMargins;

		// Token: 0x04001065 RID: 4197
		private int _verifiedCacheVersion = -1;

		// Token: 0x04001066 RID: 4198
		private global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter _lastGroupByPresenter;

		// Token: 0x04001067 RID: 4199
		private global::System.Collections.Generic.Dictionary<int, double> _autoFitCellAreaWidthCache;

		// Token: 0x04001068 RID: 4200
		private global::System.Collections.Generic.Dictionary<int, double> _autoFitCellAreaHeightCache;

		// Token: 0x04001069 RID: 4201
		internal static readonly global::System.Windows.DependencyProperty IsTemplateRecordPanelProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsTemplateRecordPanel", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.OnIsTemplateRecordPanelChanged)));

		// Token: 0x020002C2 RID: 706
		private class ReportElementComparer : global::System.Collections.IComparer
		{
			// Token: 0x0600219E RID: 8606 RVA: 0x00091E40 File Offset: 0x00090040
			internal ReportElementComparer(bool isVertical)
			{
				this._isVertical = isVertical;
			}

			// Token: 0x0600219F RID: 8607 RVA: 0x00091E50 File Offset: 0x00090050
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

			// Token: 0x0400106D RID: 4205
			private bool _isVertical;
		}
	}
}
