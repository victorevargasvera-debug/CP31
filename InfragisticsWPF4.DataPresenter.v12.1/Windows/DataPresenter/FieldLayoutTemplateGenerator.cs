using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Infragistics.Windows.DataPresenter.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002CB RID: 715
	public abstract class FieldLayoutTemplateGenerator
	{
		// Token: 0x060021FD RID: 8701 RVA: 0x00093DF6 File Offset: 0x00091FF6
		protected FieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			this._fieldLayout = fieldLayout;
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x00093E13 File Offset: 0x00092013
		public virtual global::Infragistics.Windows.DataPresenter.CellContentAlignment DefaultCellContentAlignment
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueStretch;
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060021FF RID: 8703
		public abstract global::Infragistics.Windows.DataPresenter.AutoArrangeCells DefaultAutoArrangeCells { get; }

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x00093E16 File Offset: 0x00092016
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x00093E1E File Offset: 0x0009201E
		public global::System.Windows.DataTemplate GeneratedHeaderTemplate
		{
			get
			{
				this.GenerateTemplates();
				return this._generatedHeaderTemplate;
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x00093E2C File Offset: 0x0009202C
		[global::System.Obsolete("The 'GeneratedRecordContentAreaTemplate' is no longer created. The 'GeneratedVirtualRecordContentAreaTemplate' will be used instead.")]
		public global::System.Windows.DataTemplate GeneratedRecordContentAreaTemplate
		{
			get
			{
				return this.GeneratedVirtualRecordContentAreaTemplate;
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x00093E34 File Offset: 0x00092034
		public global::System.Windows.DataTemplate GeneratedVirtualRecordContentAreaTemplate
		{
			get
			{
				this.GenerateTemplates();
				return this._generatedVirtualizedRecordContentAreaTemplate;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06002204 RID: 8708 RVA: 0x00093E42 File Offset: 0x00092042
		public global::System.Windows.DataTemplate GeneratedSummaryRecordContentAreaTemplate
		{
			get
			{
				this.GenerateTemplates();
				return this._generatedSummaryRecordContentAreaTemplate;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x00093E50 File Offset: 0x00092050
		[global::System.Obsolete("The 'GeneratedSummaryCellAreaTemplate' is no longer created. The 'GeneratedSummaryVirtualCellAreaTemplate' will be used instead.")]
		public global::System.Windows.DataTemplate GeneratedSummaryCellAreaTemplate
		{
			get
			{
				return this.GeneratedSummaryVirtualCellAreaTemplate;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06002206 RID: 8710 RVA: 0x00093E58 File Offset: 0x00092058
		public global::System.Windows.DataTemplate GeneratedSummaryVirtualCellAreaTemplate
		{
			get
			{
				this.GenerateTemplates();
				return this._generatedSummaryVirtualCellAreaTemplate;
			}
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x00093E66 File Offset: 0x00092066
		public virtual global::Infragistics.Windows.DataPresenter.PanelNavigationDirection GetRecordNavigationDirectionFromCellNavigationDirection(global::Infragistics.Windows.DataPresenter.PanelNavigationDirection cellNavigationDirection)
		{
			return cellNavigationDirection;
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06002208 RID: 8712 RVA: 0x00093E69 File Offset: 0x00092069
		internal global::Infragistics.Windows.DataPresenter.GridFieldMap GridFieldMap
		{
			get
			{
				if (this._gridFieldMap == null)
				{
					this._gridFieldMap = new global::Infragistics.Windows.DataPresenter.GridFieldMap(this);
				}
				return this._gridFieldMap;
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x00093E85 File Offset: 0x00092085
		public virtual global::System.Windows.Controls.Orientation LogicalOrientation
		{
			get
			{
				return global::System.Windows.Controls.Orientation.Vertical;
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x0600220A RID: 8714 RVA: 0x00093E88 File Offset: 0x00092088
		public virtual bool HasLogicalOrientation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x00093E8B File Offset: 0x0009208B
		public bool HasSeparateHeader
		{
			get
			{
				return this._separateHeader;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x0600220C RID: 8716
		public abstract global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation { get; }

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x00093E93 File Offset: 0x00092093
		public virtual global::Infragistics.Windows.DataPresenter.CellContentAlignment PrimaryFieldDefaultCellContentAlignment
		{
			get
			{
				return this.DefaultCellContentAlignment;
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x00093E9B File Offset: 0x0009209B
		public virtual bool SupportsLabelHeaders
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x00093E9E File Offset: 0x0009209E
		internal virtual bool AreRecordsArrangedInRowsAndCols
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x00093EA1 File Offset: 0x000920A1
		internal global::System.Windows.Controls.ColumnDefinition DefaultColumnDefinition
		{
			get
			{
				return this._defaultColumnDefinition;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06002211 RID: 8721 RVA: 0x00093EA9 File Offset: 0x000920A9
		internal global::System.Windows.Controls.RowDefinition DefaultRowDefinition
		{
			get
			{
				return this._defaultRowDefinition;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06002212 RID: 8722 RVA: 0x00093EB1 File Offset: 0x000920B1
		internal bool IsDirty
		{
			get
			{
				return this._stylesAreDirty;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06002213 RID: 8723 RVA: 0x00093EB9 File Offset: 0x000920B9
		internal global::System.Windows.DataTemplate TemplateDataRecordContentAreaTemplate
		{
			get
			{
				this.GenerateTemplates();
				return this._generatedTemplateDataRecordContentAreaTemplate;
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x00093EC7 File Offset: 0x000920C7
		internal global::System.Windows.DataTemplate TemplateDataRecordHeaderAreaTemplate
		{
			get
			{
				this.GenerateTemplates();
				return this._generatedTemplateDataRecordHeaderAreaTemplate;
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x00093ED5 File Offset: 0x000920D5
		internal bool IsGeneratingTemplates
		{
			get
			{
				return this._isGeneratingTemplates;
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x00093EDD File Offset: 0x000920DD
		internal global::System.Windows.Controls.Grid TemplateGrid
		{
			get
			{
				return this._templateGrid;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06002217 RID: 8727 RVA: 0x00093EE5 File Offset: 0x000920E5
		internal int TemplateVersion
		{
			get
			{
				return this._templateVersion;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x00093EED File Offset: 0x000920ED
		internal bool UseCellPresenters
		{
			get
			{
				return this._labelLocation == global::Infragistics.Windows.DataPresenter.LabelLocation.InCells;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06002219 RID: 8729 RVA: 0x00093EF8 File Offset: 0x000920F8
		internal int Version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x00093F00 File Offset: 0x00092100
		protected virtual global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation DefaultAutoArrangePrimaryFieldReservation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.ReserveFirstRow;
			}
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x00093F03 File Offset: 0x00092103
		public void InvalidateGeneratedTemplates()
		{
			this.InvalidateGeneratedTemplates(true);
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x00093F0C File Offset: 0x0009210C
		internal void InvalidateGeneratedTemplates(bool invalidateTemplates)
		{
			this._stylesAreDirty = true;
			if (this._fieldLayout != null)
			{
				this._fieldLayout.BumpTemplateVersion(invalidateTemplates);
			}
			this._version++;
			if (invalidateTemplates)
			{
				this._templatesAreDirty = true;
				this._templateVersion++;
			}
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x00093F5C File Offset: 0x0009215C
		public void GenerateTemplates()
		{
			if (!this._stylesAreDirty && this._generatedVirtualizedRecordContentAreaTemplate != null)
			{
				return;
			}
			bool isGeneratingTemplates = this._isGeneratingTemplates;
			try
			{
				this._isGeneratingTemplates = true;
				this.GenerateTemplatesImpl();
				if (this._fieldLayout != null)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
					if (dataPresenter != null)
					{
						dataPresenter.OnFieldLayoutTemplateGeneration();
					}
				}
			}
			finally
			{
				this._isGeneratingTemplates = isGeneratingTemplates;
				if (this._fieldLayout != null)
				{
					this._templateGrid = this._fieldLayout.DataRecordCellAreaTemplateGridResolved;
					this._defaultColumnDefinition = this._fieldLayout.DefaultColumnDefinitionResolved;
					this._defaultRowDefinition = this._fieldLayout.DefaultRowDefinitionResolved;
				}
				if (this._fieldLayout != null)
				{
					this._fieldLayout.OnTemplatesGenerated();
				}
			}
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x00094014 File Offset: 0x00092214
		private void GenerateSummaryRecordContentAreaTemplate()
		{
			global::System.Windows.FrameworkElementFactory visualTree = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea));
			this._generatedSummaryRecordContentAreaTemplate = new global::System.Windows.DataTemplate();
			this._generatedSummaryRecordContentAreaTemplate.VisualTree = visualTree;
			this._generatedSummaryVirtualCellAreaTemplate = new global::System.Windows.DataTemplate();
			this._generatedSummaryVirtualCellAreaTemplate.VisualTree = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.DataPresenter.VirtualizingSummaryCellPanel));
			this._generatedSummaryVirtualCellAreaTemplate.Seal();
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x00094078 File Offset: 0x00092278
		private void GenerateTemplatesImpl()
		{
			bool templatesAreDirty = this._templatesAreDirty;
			if (templatesAreDirty)
			{
				this._generatedHeaderTemplate = null;
				this._cellAreaColumnDefinitions = null;
				this._cellAreaRowDefinitions = null;
				this._generatedVirtualizedRecordContentAreaTemplate = null;
				this._generatedTemplateDataRecordContentAreaTemplate = null;
				this._generatedTemplateDataRecordHeaderAreaTemplate = null;
			}
			if (this._fieldLayout == null || this._fieldLayout.DataPresenter == null)
			{
				return;
			}
			this._stylesAreDirty = false;
			this._templatesAreDirty = false;
			global::Infragistics.Windows.DataPresenter.Field primaryField = this._fieldLayout.PrimaryField;
			if (templatesAreDirty)
			{
				global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea));
				frameworkElementFactory.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.FieldLayoutProperty, this._fieldLayout);
				frameworkElementFactory.SetBinding(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.InternalVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.InternalVersionProperty, global::System.Windows.Data.BindingMode.OneWay, this._fieldLayout));
				frameworkElementFactory.SetBinding(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.ScrollableRecordCountVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollableRecordCountVersionProperty, global::System.Windows.Data.BindingMode.OneWay, this.FieldLayout.DataPresenter));
				frameworkElementFactory.SetBinding(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.SortOperationVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.SortOperationVersionProperty, global::System.Windows.Data.BindingMode.OneWay, this.FieldLayout));
				global::System.Windows.FrameworkElementFactory frameworkElementFactory2 = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel));
				frameworkElementFactory2.SetValue(global::System.Windows.FrameworkElement.NameProperty, "ContentItemGrid");
				frameworkElementFactory.AppendChild(frameworkElementFactory2);
				this._generatedVirtualizedRecordContentAreaTemplate = new global::System.Windows.DataTemplate();
				this._generatedVirtualizedRecordContentAreaTemplate.VisualTree = frameworkElementFactory;
			}
			if (templatesAreDirty)
			{
				this.GenerateSummaryRecordContentAreaTemplate();
			}
			global::System.Windows.FrameworkElementFactory frameworkElementFactory3 = null;
			global::System.Windows.FrameworkElementFactory frameworkElementFactory4 = null;
			if (templatesAreDirty)
			{
				frameworkElementFactory4 = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.StackPanel));
				frameworkElementFactory4.SetValue(global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.IsTemplateRecordPanelProperty, global::Infragistics.KnownBoxes.TrueBox);
				global::System.Windows.FrameworkElementFactory frameworkElementFactory5 = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea));
				frameworkElementFactory4.SetValue(global::System.Windows.FrameworkElement.NameProperty, "ContentItemGrid");
				frameworkElementFactory5.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.FieldLayoutProperty, this._fieldLayout);
				frameworkElementFactory5.SetBinding(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.InternalVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.InternalVersionProperty, global::System.Windows.Data.BindingMode.OneWay, this._fieldLayout));
				frameworkElementFactory5.SetBinding(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.ScrollableRecordCountVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollableRecordCountVersionProperty, global::System.Windows.Data.BindingMode.OneWay, this.FieldLayout.DataPresenter));
				frameworkElementFactory5.SetBinding(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.SortOperationVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.SortOperationVersionProperty, global::System.Windows.Data.BindingMode.OneWay, this.FieldLayout));
				frameworkElementFactory5.AppendChild(frameworkElementFactory4);
				this._generatedTemplateDataRecordContentAreaTemplate = new global::System.Windows.DataTemplate();
				this._generatedTemplateDataRecordContentAreaTemplate.VisualTree = frameworkElementFactory5;
				this._separateHeader = false;
				this._labelLocation = this._fieldLayout.LabelLocationResolved;
				if (this.SupportsLabelHeaders && this._fieldLayout.GetDefaultCellContentAlignment(null) != global::Infragistics.Windows.DataPresenter.CellContentAlignment.ValueOnly)
				{
					switch (this._labelLocation)
					{
					case global::Infragistics.Windows.DataPresenter.LabelLocation.Default:
					case global::Infragistics.Windows.DataPresenter.LabelLocation.SeparateHeader:
					{
						global::System.Windows.FrameworkElementFactory frameworkElementFactory6 = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea));
						frameworkElementFactory6.SetValue(global::Infragistics.Windows.DataPresenter.HeaderLabelArea.FieldLayoutProperty, this._fieldLayout);
						frameworkElementFactory6.SetBinding(global::Infragistics.Windows.DataPresenter.HeaderLabelArea.InternalVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.InternalVersionProperty, global::System.Windows.Data.BindingMode.OneWay, this._fieldLayout));
						global::System.Windows.FrameworkElementFactory frameworkElementFactory7 = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea));
						frameworkElementFactory7.SetValue(global::Infragistics.Windows.DataPresenter.HeaderLabelArea.FieldLayoutProperty, this._fieldLayout);
						frameworkElementFactory7.SetBinding(global::Infragistics.Windows.DataPresenter.HeaderLabelArea.InternalVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.InternalVersionProperty, global::System.Windows.Data.BindingMode.OneWay, this._fieldLayout));
						frameworkElementFactory3 = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.StackPanel));
						frameworkElementFactory3.SetValue(global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache.IsTemplateRecordPanelProperty, global::Infragistics.KnownBoxes.TrueBox);
						frameworkElementFactory3.SetValue(global::System.Windows.FrameworkElement.NameProperty, "HeaderItemGrid");
						frameworkElementFactory7.AppendChild(frameworkElementFactory3);
						this._generatedTemplateDataRecordHeaderAreaTemplate = new global::System.Windows.DataTemplate();
						this._generatedTemplateDataRecordHeaderAreaTemplate.VisualTree = frameworkElementFactory7;
						global::System.Windows.FrameworkElementFactory child = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel));
						frameworkElementFactory6.AppendChild(child);
						this._generatedHeaderTemplate = new global::System.Windows.DataTemplate();
						this._generatedHeaderTemplate.VisualTree = frameworkElementFactory6;
						this._separateHeader = true;
						break;
					}
					}
				}
			}
			if (templatesAreDirty)
			{
				global::Infragistics.Windows.DataPresenter.RecordSelectorLocation recordSelectorLocationResolved = this._fieldLayout.RecordSelectorLocationResolved;
				if (recordSelectorLocationResolved != global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.None)
				{
					this.InitializePrefixArea(this._generatedVirtualizedRecordContentAreaTemplate, false, recordSelectorLocationResolved, false);
					if (this._generatedSummaryRecordContentAreaTemplate != null)
					{
						this.InitializePrefixArea(this._generatedSummaryRecordContentAreaTemplate, false, recordSelectorLocationResolved, true);
					}
					if (this._generatedHeaderTemplate != null)
					{
						this.InitializePrefixArea(this._generatedHeaderTemplate, true, recordSelectorLocationResolved, false);
					}
				}
				else
				{
					this.BindContentSiteMargin(this._generatedVirtualizedRecordContentAreaTemplate.VisualTree, false);
					if (this._generatedHeaderTemplate != null)
					{
						this.BindContentSiteMargin(this._generatedHeaderTemplate.VisualTree, true);
					}
				}
			}
			if (this._fieldLayout.Fields.Count < 1)
			{
				return;
			}
			this._autoArrangeCells = ((this._fieldLayout.GetFieldLayoutInfo(false, false) != null) ? global::Infragistics.Windows.DataPresenter.AutoArrangeCells.Never : this._fieldLayout.AutoArrangeCellsResolved);
			if (this._autoArrangeCells == global::Infragistics.Windows.DataPresenter.AutoArrangeCells.Never)
			{
				this._reservation = global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.None;
			}
			else
			{
				this._reservation = global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.Default;
				if (this._fieldLayout.HasSettings)
				{
					this._reservation = this._fieldLayout.Settings.AutoArrangePrimaryFieldReservation;
				}
				if (this._reservation == global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.Default && this._fieldLayout.DataPresenter.HasFieldLayoutSettings)
				{
					this._reservation = this._fieldLayout.DataPresenter.FieldLayoutSettings.AutoArrangePrimaryFieldReservation;
				}
				if (this._reservation == global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.Default)
				{
					this._reservation = this.DefaultAutoArrangePrimaryFieldReservation;
				}
				if (this._reservation == global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.ReserveFirstRowOrColumnBasedOnFlow)
				{
					if (this._autoArrangeCells == global::Infragistics.Windows.DataPresenter.AutoArrangeCells.LeftToRight)
					{
						this._reservation = global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.ReserveFirstRow;
					}
					else
					{
						this._reservation = global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.ReserveFirstColumn;
					}
				}
				if (primaryField == null || !primaryField.IsVisibleInCellArea)
				{
					this._reservation = global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.None;
				}
			}
			this.CalculateMaxGridRowsAndColumns();
			this.ProcessFields(primaryField, frameworkElementFactory4, frameworkElementFactory3);
			if (templatesAreDirty)
			{
				this._generatedTemplateDataRecordContentAreaTemplate.Seal();
				this._generatedVirtualizedRecordContentAreaTemplate.Seal();
				this._generatedSummaryRecordContentAreaTemplate.Seal();
				if (this._generatedHeaderTemplate != null)
				{
					this._generatedHeaderTemplate.Seal();
				}
				if (this._generatedTemplateDataRecordHeaderAreaTemplate != null)
				{
					this._generatedTemplateDataRecordHeaderAreaTemplate.Seal();
				}
			}
			this.InitializeGridFieldMap();
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x000945CE File Offset: 0x000927CE
		internal global::System.Windows.Controls.ColumnDefinition[] GetCellAreaColumnDefinitions()
		{
			if (this._cellAreaColumnDefinitions == null)
			{
				return new global::System.Windows.Controls.ColumnDefinition[0];
			}
			return (global::System.Windows.Controls.ColumnDefinition[])this._cellAreaColumnDefinitions.Clone();
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x000945EF File Offset: 0x000927EF
		internal global::System.Windows.Controls.RowDefinition[] GetCellAreaRowDefinitions()
		{
			if (this._cellAreaRowDefinitions == null)
			{
				return new global::System.Windows.Controls.RowDefinition[0];
			}
			return (global::System.Windows.Controls.RowDefinition[])this._cellAreaRowDefinitions.Clone();
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x00094610 File Offset: 0x00092810
		private void BindContentSiteMargin(global::System.Windows.FrameworkElementFactory fefContentSite, bool isHeader)
		{
			fefContentSite.SetBinding(global::System.Windows.FrameworkElement.MarginProperty, global::Infragistics.Windows.DataPresenter.GridUtilities.CreateRecordContentMarginBinding(this._fieldLayout, isHeader, fefContentSite.Type));
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x00094630 File Offset: 0x00092830
		private void CalculateMaxGridRowsAndColumns()
		{
			this._maxGridRows = -1;
			this._maxGridColumns = -1;
			if (this._autoArrangeCells == global::Infragistics.Windows.DataPresenter.AutoArrangeCells.Never)
			{
				return;
			}
			if (this._fieldLayout.HasSettings)
			{
				this._maxGridColumns = this._fieldLayout.Settings.AutoArrangeMaxColumns;
				this._maxGridRows = this._fieldLayout.Settings.AutoArrangeMaxRows;
			}
			if (this._maxGridColumns < 0)
			{
				if (this._fieldLayout.DataPresenter.HasFieldLayoutSettings)
				{
					this._maxGridColumns = this._fieldLayout.DataPresenter.FieldLayoutSettings.AutoArrangeMaxColumns;
				}
				if (this._maxGridColumns < 0)
				{
					this._maxGridColumns = this._fieldLayout.DataPresenter.CurrentViewInternal.DefaultAutoArrangeMaxColumns;
				}
			}
			if (this._maxGridRows < 0)
			{
				if (this._fieldLayout.DataPresenter.HasFieldLayoutSettings)
				{
					this._maxGridRows = this._fieldLayout.DataPresenter.FieldLayoutSettings.AutoArrangeMaxRows;
				}
				if (this._maxGridRows < 0)
				{
					this._maxGridRows = this._fieldLayout.DataPresenter.CurrentViewInternal.DefaultAutoArrangeMaxRows;
				}
			}
			if (this._autoArrangeCells == global::Infragistics.Windows.DataPresenter.AutoArrangeCells.LeftToRight)
			{
				if (this._maxGridColumns < 1)
				{
					this._maxGridColumns = 0;
					return;
				}
			}
			else if (this._maxGridRows < 1)
			{
				this._maxGridRows = 0;
			}
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x0009476C File Offset: 0x0009296C
		private global::Infragistics.Windows.DataPresenter.CellTemplateType GetTemplateType(global::Infragistics.Windows.DataPresenter.CellContentAlignment cellContentAlignment)
		{
			global::Infragistics.Windows.DataPresenter.CellTemplateType result;
			switch (cellContentAlignment)
			{
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelOnly:
				result = global::Infragistics.Windows.DataPresenter.CellTemplateType.LabelOnly;
				break;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.ValueOnly:
				result = global::Infragistics.Windows.DataPresenter.CellTemplateType.ValueOnly;
				break;
			default:
				result = global::Infragistics.Windows.DataPresenter.CellTemplateType.ValueAndLabel;
				break;
			}
			return result;
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x00094798 File Offset: 0x00092998
		internal static global::System.Windows.HorizontalAlignment GetHorizontalAlignmentLabel(global::Infragistics.Windows.DataPresenter.CellContentAlignment cellContentAlignment)
		{
			switch (cellContentAlignment)
			{
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelOnly:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.ValueOnly:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueStretch:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueStretch:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueStretch:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueStretch:
				return global::System.Windows.HorizontalAlignment.Stretch;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignLeft:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignLeft:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignTop:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignMiddle:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignBottom:
				return global::System.Windows.HorizontalAlignment.Left;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignCenter:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignCenter:
				return global::System.Windows.HorizontalAlignment.Center;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignRight:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignRight:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignTop:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignMiddle:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignBottom:
				return global::System.Windows.HorizontalAlignment.Right;
			default:
				return global::System.Windows.HorizontalAlignment.Stretch;
			}
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x00094804 File Offset: 0x00092A04
		internal static global::System.Windows.VerticalAlignment GetVerticalAlignmentLabel(global::Infragistics.Windows.DataPresenter.CellContentAlignment cellContentAlignment)
		{
			switch (cellContentAlignment)
			{
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelOnly:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.ValueOnly:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueStretch:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueStretch:
				return global::System.Windows.VerticalAlignment.Stretch;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignLeft:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignCenter:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignRight:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueStretch:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignBottom:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignBottom:
				return global::System.Windows.VerticalAlignment.Bottom;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignLeft:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignCenter:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignRight:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueStretch:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignTop:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignTop:
				return global::System.Windows.VerticalAlignment.Top;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignMiddle:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignMiddle:
				return global::System.Windows.VerticalAlignment.Center;
			default:
				return global::System.Windows.VerticalAlignment.Stretch;
			}
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x00094870 File Offset: 0x00092A70
		private global::System.Windows.Controls.Dock? InitializePrefixArea(global::System.Windows.DataTemplate template, bool isHeaderTemplate, global::Infragistics.Windows.DataPresenter.RecordSelectorLocation selectorLocation, bool isSummaryTemplate)
		{
			if (!this._fieldLayout.DataPresenter.CurrentViewInternal.ShouldDisplayRecordSelectors)
			{
				return null;
			}
			bool flag = true;
			switch (selectorLocation)
			{
			case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.AboveCellArea:
			case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.BelowCellArea:
				if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					flag = false;
				}
				break;
			case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.LeftOfCellArea:
			case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.RightOfCellArea:
				if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					flag = false;
				}
				break;
			}
			if (!flag && (isHeaderTemplate || isSummaryTemplate))
			{
				return null;
			}
			global::System.Windows.FrameworkElementFactory visualTree = template.VisualTree;
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.DockPanel));
			this.BindContentSiteMargin(frameworkElementFactory, isHeaderTemplate);
			global::System.Windows.FrameworkElementFactory frameworkElementFactory2;
			global::System.Windows.DependencyProperty fieldLayoutProperty;
			global::System.Windows.DependencyProperty internalVersionProperty;
			if (isHeaderTemplate)
			{
				frameworkElementFactory2 = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.DataPresenter.HeaderPrefixArea));
				fieldLayoutProperty = global::Infragistics.Windows.DataPresenter.RecordPrefixArea.FieldLayoutProperty;
				internalVersionProperty = global::Infragistics.Windows.DataPresenter.RecordPrefixArea.InternalVersionProperty;
			}
			else if (isSummaryTemplate)
			{
				frameworkElementFactory2 = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPrefixArea));
				fieldLayoutProperty = global::Infragistics.Windows.DataPresenter.RecordPrefixArea.FieldLayoutProperty;
				internalVersionProperty = global::Infragistics.Windows.DataPresenter.RecordPrefixArea.InternalVersionProperty;
			}
			else
			{
				frameworkElementFactory2 = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.DataPresenter.RecordSelector));
				fieldLayoutProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.FieldLayoutProperty;
				internalVersionProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.InternalVersionProperty;
			}
			frameworkElementFactory2.SetValue(fieldLayoutProperty, this._fieldLayout);
			frameworkElementFactory2.SetBinding(internalVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.InternalVersionProperty, global::System.Windows.Data.BindingMode.OneWay, this._fieldLayout));
			if (flag)
			{
				global::System.Windows.Data.RelativeSource relativeSource = new global::System.Windows.Data.RelativeSource(global::System.Windows.Data.RelativeSourceMode.FindAncestor, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), 1);
				global::System.Windows.DependencyProperty dp;
				if (selectorLocation == global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.AboveCellArea || selectorLocation == global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.LeftOfCellArea)
				{
					dp = global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedNearElementTransformProperty;
				}
				else
				{
					dp = global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFarElementTransformProperty;
				}
				frameworkElementFactory2.SetBinding(global::System.Windows.UIElement.RenderTransformProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(dp, global::System.Windows.Data.BindingMode.OneWay, relativeSource));
			}
			global::System.Windows.Data.Binding binding = global::Infragistics.Windows.Utilities.CreateBindingObject("RecordSelectorExtentResolved", global::System.Windows.Data.BindingMode.OneWay, this._fieldLayout);
			global::System.Windows.Controls.Dock? result = null;
			switch (selectorLocation)
			{
			case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.AboveCellArea:
				frameworkElementFactory2.SetBinding(global::System.Windows.FrameworkElement.HeightProperty, binding);
				result = new global::System.Windows.Controls.Dock?(global::System.Windows.Controls.Dock.Top);
				break;
			case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.BelowCellArea:
				frameworkElementFactory2.SetBinding(global::System.Windows.FrameworkElement.HeightProperty, binding);
				result = new global::System.Windows.Controls.Dock?(global::System.Windows.Controls.Dock.Bottom);
				break;
			case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.LeftOfCellArea:
				frameworkElementFactory2.SetBinding(global::System.Windows.FrameworkElement.WidthProperty, binding);
				result = new global::System.Windows.Controls.Dock?(global::System.Windows.Controls.Dock.Left);
				break;
			case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.RightOfCellArea:
				frameworkElementFactory2.SetBinding(global::System.Windows.FrameworkElement.WidthProperty, binding);
				result = new global::System.Windows.Controls.Dock?(global::System.Windows.Controls.Dock.Right);
				break;
			}
			if (result != null)
			{
				frameworkElementFactory2.SetValue(global::System.Windows.Controls.DockPanel.DockProperty, result.Value);
			}
			frameworkElementFactory.AppendChild(frameworkElementFactory2);
			frameworkElementFactory.AppendChild(visualTree);
			template.VisualTree = frameworkElementFactory;
			return result;
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x00094AA3 File Offset: 0x00092CA3
		private void InitializeGridFieldMap()
		{
			this.GridFieldMap.ResetMap();
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x00094AC4 File Offset: 0x00092CC4
		private void ProcessFields(global::Infragistics.Windows.DataPresenter.Field primaryField, global::System.Windows.FrameworkElementFactory fefItemGrid, global::System.Windows.FrameworkElementFactory fefHeaderGrid)
		{
			int count = this._fieldLayout.Fields.Count;
			global::Infragistics.Windows.DataPresenter.Field[] array = new global::Infragistics.Windows.DataPresenter.Field[count];
			this._fieldLayout.Fields.CopyTo(array, 0);
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
			if (dataPresenter != null && dataPresenter.IsFixedFieldsSupportedResolved)
			{
				global::System.Comparison<global::Infragistics.Windows.DataPresenter.Field> comparison = (global::Infragistics.Windows.DataPresenter.Field x, global::Infragistics.Windows.DataPresenter.Field y) => global::Infragistics.Windows.DataPresenter.GridUtilities.Compare(x.FixedLocation, y.FixedLocation);
				global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Field> comparer = global::Infragistics.CoreUtilities.CreateComparer<global::Infragistics.Windows.DataPresenter.Field>(comparison);
				global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Windows.DataPresenter.Field>(array, comparer);
			}
			global::Infragistics.Windows.DataPresenter.LayoutInfo fieldLayoutInfo = this._fieldLayout.GetFieldLayoutInfo(false, false);
			if (fieldLayoutInfo != null)
			{
				fieldLayoutInfo.EnsureNewItemsDontOverlapHelper();
				this._fieldLayout._autoGeneratedPositions = null;
			}
			else if (this._fieldLayout._autoGeneratedPositions == null)
			{
				this._fieldLayout._autoGeneratedPositions = new global::Infragistics.Windows.DataPresenter.LayoutInfo(this._fieldLayout);
			}
			global::Infragistics.Windows.DataPresenter.LayoutInfo autoGeneratedPositions = this._fieldLayout._autoGeneratedPositions;
			global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = null;
			global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.ArrangeHelper arrangeHelper = new global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.ArrangeHelper(this._fieldLayout, this._autoArrangeCells, primaryField, this._reservation, this._maxGridRows, this._maxGridColumns);
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.Field field = array[i];
				field.IsInLayout = arrangeHelper.IsInLayout(field);
				if (!field.IsInLayout)
				{
					if (autoGeneratedPositions != null)
					{
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo2 = (itemLayoutInfo != null) ? itemLayoutInfo.Clone() : new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(0, 0, 1, 1);
						if (itemLayoutInfo != null)
						{
							if (global::Infragistics.Windows.DataPresenter.AutoArrangeCells.TopToBottom == this._autoArrangeCells)
							{
								itemLayoutInfo2.Row += itemLayoutInfo.RowSpan;
							}
							else
							{
								itemLayoutInfo2.Column += itemLayoutInfo.ColumnSpan;
							}
						}
						itemLayoutInfo2._fixedLocation = field.FixedLocation;
						itemLayoutInfo2.IsCollapsed = true;
						autoGeneratedPositions[field] = itemLayoutInfo2;
					}
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.SpanInfo spanInfo = arrangeHelper.GetSpanInfo(field);
					global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.RowColInfo rowColumn = arrangeHelper.GetRowColumn(field);
					if (autoGeneratedPositions != null)
					{
						itemLayoutInfo = new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(rowColumn.Column, rowColumn.Row, spanInfo.ColumnSpan, spanInfo.RowSpan);
						itemLayoutInfo._fixedLocation = field.FixedLocation;
						itemLayoutInfo.Visibility = field.VisibilityInCellArea;
						autoGeneratedPositions[field] = itemLayoutInfo;
					}
					field.SetGridPositions(ref rowColumn, ref spanInfo);
				}
			}
			this.FieldLayout.SetHasSeparateHeader(this._separateHeader);
			this._fieldLayout.SetGridCounts(arrangeHelper.ColumnCount, arrangeHelper.RowCount);
		}

		// Token: 0x0400109A RID: 4250
		internal const string CellAreaItemGridName = "ContentItemGrid";

		// Token: 0x0400109B RID: 4251
		internal const string HeaderAreaItemGridName = "HeaderItemGrid";

		// Token: 0x0400109C RID: 4252
		private const int AutoArrangeMaxColumnsSupported = 4096;

		// Token: 0x0400109D RID: 4253
		private bool _stylesAreDirty = true;

		// Token: 0x0400109E RID: 4254
		private bool _separateHeader;

		// Token: 0x0400109F RID: 4255
		private global::System.Windows.Controls.Grid _templateGrid;

		// Token: 0x040010A0 RID: 4256
		private global::System.Windows.Controls.ColumnDefinition _defaultColumnDefinition;

		// Token: 0x040010A1 RID: 4257
		private global::System.Windows.Controls.RowDefinition _defaultRowDefinition;

		// Token: 0x040010A2 RID: 4258
		private global::System.Windows.Controls.ColumnDefinition[] _cellAreaColumnDefinitions;

		// Token: 0x040010A3 RID: 4259
		private global::System.Windows.Controls.RowDefinition[] _cellAreaRowDefinitions;

		// Token: 0x040010A4 RID: 4260
		private global::System.Windows.DataTemplate _generatedHeaderTemplate;

		// Token: 0x040010A5 RID: 4261
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x040010A6 RID: 4262
		private global::Infragistics.Windows.DataPresenter.LabelLocation _labelLocation;

		// Token: 0x040010A7 RID: 4263
		private global::Infragistics.Windows.DataPresenter.AutoArrangeCells _autoArrangeCells;

		// Token: 0x040010A8 RID: 4264
		private global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation _reservation;

		// Token: 0x040010A9 RID: 4265
		private int _maxGridRows;

		// Token: 0x040010AA RID: 4266
		private int _maxGridColumns;

		// Token: 0x040010AB RID: 4267
		private global::Infragistics.Windows.DataPresenter.GridFieldMap _gridFieldMap;

		// Token: 0x040010AC RID: 4268
		private global::System.Windows.DataTemplate _generatedVirtualizedRecordContentAreaTemplate;

		// Token: 0x040010AD RID: 4269
		private global::System.Windows.DataTemplate _generatedSummaryRecordContentAreaTemplate;

		// Token: 0x040010AE RID: 4270
		private global::System.Windows.DataTemplate _generatedSummaryVirtualCellAreaTemplate;

		// Token: 0x040010AF RID: 4271
		private bool _isGeneratingTemplates;

		// Token: 0x040010B0 RID: 4272
		private global::System.Windows.DataTemplate _generatedTemplateDataRecordContentAreaTemplate;

		// Token: 0x040010B1 RID: 4273
		private global::System.Windows.DataTemplate _generatedTemplateDataRecordHeaderAreaTemplate;

		// Token: 0x040010B2 RID: 4274
		private bool _templatesAreDirty = true;

		// Token: 0x040010B3 RID: 4275
		private int _version;

		// Token: 0x040010B4 RID: 4276
		private int _templateVersion;

		// Token: 0x020002CC RID: 716
		internal struct SpanInfo
		{
			// Token: 0x040010B6 RID: 4278
			internal int RowSpan;

			// Token: 0x040010B7 RID: 4279
			internal int ColumnSpan;
		}

		// Token: 0x020002CD RID: 717
		internal struct RowColInfo
		{
			// Token: 0x040010B8 RID: 4280
			internal int Row;

			// Token: 0x040010B9 RID: 4281
			internal int Column;
		}

		// Token: 0x020002CE RID: 718
		internal class GridSlotComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Field>
		{
			// Token: 0x0600222B RID: 8747 RVA: 0x00094D0A File Offset: 0x00092F0A
			internal GridSlotComparer(bool isWidth)
			{
				this._isWidth = isWidth;
			}

			// Token: 0x0600222C RID: 8748 RVA: 0x00094D1C File Offset: 0x00092F1C
			int global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Field>.Compare(global::Infragistics.Windows.DataPresenter.Field x, global::Infragistics.Windows.DataPresenter.Field y)
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
				global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition = x.GridPosition;
				global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition2 = y.GridPosition;
				int num = this._isWidth ? gridPosition.ColumnSpan : gridPosition.RowSpan;
				int num2 = this._isWidth ? gridPosition2.ColumnSpan : gridPosition2.RowSpan;
				if (num < num2)
				{
					return -1;
				}
				if (num > num2)
				{
					return 1;
				}
				int num3 = num + (this._isWidth ? gridPosition.Column : gridPosition.Row);
				int num4 = num2 + (this._isWidth ? gridPosition2.Column : gridPosition2.Row);
				if (num3 < num4)
				{
					return -1;
				}
				if (num3 > num4)
				{
					return 1;
				}
				int index = x.Index;
				int index2 = y.Index;
				if (index < index2)
				{
					return -1;
				}
				return 1;
			}

			// Token: 0x040010BA RID: 4282
			private bool _isWidth;
		}

		// Token: 0x020002CF RID: 719
		private class ArrangeHelper
		{
			// Token: 0x0600222D RID: 8749 RVA: 0x00094DE0 File Offset: 0x00092FE0
			internal ArrangeHelper(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.AutoArrangeCells autoArrange, global::Infragistics.Windows.DataPresenter.Field primaryField, global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation primaryFieldReservation, int maxRows, int maxColumns)
			{
				this._fieldLayout = fieldLayout;
				this._autoArrange = autoArrange;
				this._primaryField = primaryField;
				if (primaryField == null || !primaryField.IsVisibleInCellArea)
				{
					primaryFieldReservation = global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.None;
				}
				this._primaryFieldReservation = primaryFieldReservation;
				if (autoArrange == global::Infragistics.Windows.DataPresenter.AutoArrangeCells.Never)
				{
					this._maxRows = (this._maxColumns = 0);
				}
				else
				{
					this._maxRows = maxRows;
					this._maxColumns = maxColumns;
				}
				this.Initialize();
			}

			// Token: 0x17000A1B RID: 2587
			// (get) Token: 0x0600222E RID: 8750 RVA: 0x00094E6B File Offset: 0x0009306B
			internal int ColumnCount
			{
				get
				{
					return this._totalColumns;
				}
			}

			// Token: 0x17000A1C RID: 2588
			// (get) Token: 0x0600222F RID: 8751 RVA: 0x00094E73 File Offset: 0x00093073
			internal int RowCount
			{
				get
				{
					return this._totalRows;
				}
			}

			// Token: 0x06002230 RID: 8752 RVA: 0x00094E7C File Offset: 0x0009307C
			private void AddAutoArrange(global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo, global::System.Collections.IEnumerator enumerator, int row, int column, int maxRow, int maxColumn)
			{
				if (this._autoArrange == global::Infragistics.Windows.DataPresenter.AutoArrangeCells.LeftToRight)
				{
					if (row >= maxRow)
					{
						return;
					}
				}
				else if (column >= maxColumn)
				{
					return;
				}
				int num = row;
				int num2 = column;
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					global::Infragistics.Windows.DataPresenter.Field field = (global::Infragistics.Windows.DataPresenter.Field)obj;
					if (field != null)
					{
						layoutInfo.Add(field, new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(column, row)
						{
							_fixedLocation = field.FixedLocation
						});
					}
					if (this._autoArrange == global::Infragistics.Windows.DataPresenter.AutoArrangeCells.LeftToRight)
					{
						column++;
						if (column >= maxColumn)
						{
							column = num2;
							row++;
							if (row >= maxRow)
							{
								return;
							}
						}
					}
					else
					{
						row++;
						if (row >= maxRow)
						{
							row = num;
							column++;
							if (column >= maxColumn)
							{
								return;
							}
						}
					}
				}
			}

			// Token: 0x06002231 RID: 8753 RVA: 0x00094F18 File Offset: 0x00093118
			private static void AddAreaExtents(int nearItemCount, int farItemCount, int scrollableItemCount, int remainingExtent, ref int nearCount, ref int farCount, ref int scrollableCount)
			{
				bool flag = nearItemCount > 0;
				bool flag2 = farItemCount > 0;
				bool flag3 = scrollableItemCount > 0;
				for (int i = 0; i < remainingExtent; i++)
				{
					int num = flag ? ((nearItemCount - 1) / nearCount + 1) : 0;
					int num2 = flag2 ? ((farItemCount - 1) / farCount + 1) : 0;
					int num3 = flag3 ? ((scrollableItemCount - 1) / scrollableCount + 1) : 0;
					if (num3 > global::System.Math.Max(num2, num))
					{
						scrollableCount++;
					}
					else if (num2 > num)
					{
						farCount++;
					}
					else if (flag)
					{
						nearCount++;
					}
					else if (flag2)
					{
						farCount++;
					}
					else
					{
						scrollableCount++;
					}
				}
			}

			// Token: 0x06002232 RID: 8754 RVA: 0x00094FB8 File Offset: 0x000931B8
			private static void AddFields(global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> fields, int offsetX, int offsetY)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field field in fields)
				{
					layoutInfo[field] = new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(field.Column + offsetX, field.Row + offsetY, global::System.Math.Max(1, field.ColumnSpan), global::System.Math.Max(1, field.RowSpan))
					{
						_fixedLocation = field.FixedLocation
					};
				}
			}

			// Token: 0x06002233 RID: 8755 RVA: 0x0009503C File Offset: 0x0009323C
			private void ArrangeArea(global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo, bool isLeftToRight, bool isHorizontal, ref int row, ref int column, int colCount, int rowCount, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> fields, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> primaryFieldList, int primaryColumnCount, int primaryRowCount, int totalLogicalRowSpan, int totalLogicalColSpan)
			{
				if (fields == primaryFieldList)
				{
					if (primaryColumnCount > 0)
					{
						int column2 = isHorizontal ? (column - primaryColumnCount) : column;
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(column2, row, primaryColumnCount, isHorizontal ? rowCount : totalLogicalRowSpan);
						itemLayoutInfo._fixedLocation = this._primaryField.FixedLocation;
						layoutInfo.Add(this._primaryField, itemLayoutInfo);
						if (!isHorizontal)
						{
							column += primaryColumnCount;
						}
					}
					else if (primaryRowCount > 0)
					{
						int row2 = (!isHorizontal) ? (row - primaryRowCount) : row;
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo2 = new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(column, row2, isHorizontal ? colCount : totalLogicalColSpan, primaryRowCount);
						itemLayoutInfo2._fixedLocation = this._primaryField.FixedLocation;
						layoutInfo.Add(this._primaryField, itemLayoutInfo2);
						if (isHorizontal)
						{
							row += primaryRowCount;
						}
					}
				}
				this.AddAutoArrange(layoutInfo, fields.GetEnumerator(), row, column, row + rowCount, column + colCount);
				if (isLeftToRight != isHorizontal)
				{
					if (isLeftToRight)
					{
						column += colCount;
						return;
					}
					row += rowCount;
					return;
				}
				else
				{
					if (isLeftToRight)
					{
						row += rowCount;
						return;
					}
					column += colCount;
					return;
				}
			}

			// Token: 0x06002234 RID: 8756 RVA: 0x0009514C File Offset: 0x0009334C
			internal bool IsInLayout(global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo;
				return this._layoutInfo.TryGetValue(field, out itemLayoutInfo) && !itemLayoutInfo.IsCollapsed && field.IsVisibleInCellArea;
			}

			// Token: 0x06002235 RID: 8757 RVA: 0x0009517C File Offset: 0x0009337C
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> GetList(global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation)
			{
				switch (fixedLocation)
				{
				default:
					return this._scrollableFields;
				case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge:
					return this._fixedNearFields;
				case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge:
					return this._fixedFarFields;
				}
			}

			// Token: 0x06002236 RID: 8758 RVA: 0x000951B4 File Offset: 0x000933B4
			private static void GetLogicalRowColCount(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> fields, out int maxCol, out int maxRow)
			{
				maxCol = 0;
				maxRow = 0;
				foreach (global::Infragistics.Windows.DataPresenter.Field field in fields)
				{
					if (field.IsVisibleInCellArea)
					{
						maxCol = global::System.Math.Max(maxCol, field.Column + global::System.Math.Max(1, field.ColumnSpan));
						maxRow = global::System.Math.Max(maxRow, field.Row + global::System.Math.Max(1, field.RowSpan));
					}
				}
			}

			// Token: 0x06002237 RID: 8759 RVA: 0x0009523C File Offset: 0x0009343C
			internal global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.RowColInfo GetRowColumn(global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo;
				this._layoutInfo.TryGetValue(field, out itemLayoutInfo);
				global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.RowColInfo result = default(global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.RowColInfo);
				if (itemLayoutInfo != null)
				{
					result.Row = itemLayoutInfo.Row;
					result.Column = itemLayoutInfo.Column;
				}
				return result;
			}

			// Token: 0x06002238 RID: 8760 RVA: 0x00095280 File Offset: 0x00093480
			internal global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.SpanInfo GetSpanInfo(global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo;
				this._layoutInfo.TryGetValue(field, out itemLayoutInfo);
				global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.SpanInfo result = default(global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.SpanInfo);
				if (itemLayoutInfo != null)
				{
					result.RowSpan = itemLayoutInfo.RowSpan;
					result.ColumnSpan = itemLayoutInfo.ColumnSpan;
				}
				return result;
			}

			// Token: 0x06002239 RID: 8761 RVA: 0x000952C4 File Offset: 0x000934C4
			private void Initialize()
			{
				global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo = null;
				layoutInfo = this._fieldLayout.GetFieldLayoutInfo(false, false);
				if (layoutInfo != null)
				{
					this._fieldLayout.ShouldCreateDragFieldLayout = false;
					layoutInfo.VerifyTemplateGeneratorLayout();
				}
				else
				{
					bool flag = this._fieldLayout.DataPresenter != null && this._fieldLayout.DataPresenter.IsFixedFieldsSupportedResolved;
					layoutInfo = new global::Infragistics.Windows.DataPresenter.LayoutInfo(this._fieldLayout);
					bool isHorizontal = this._fieldLayout.IsHorizontal;
					foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fieldLayout.Fields)
					{
						if (field.IsVisibleInCellArea)
						{
							global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedFieldLocation;
							if (!flag)
							{
								fixedFieldLocation = global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable;
							}
							else
							{
								fixedFieldLocation = field.FixedLocation;
							}
							switch (fixedFieldLocation)
							{
							case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable:
								this._scrollableFields.Add(field);
								break;
							case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge:
								this._fixedNearFields.Add(field);
								break;
							case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge:
								this._fixedFarFields.Add(field);
								break;
							}
						}
					}
					if (this._autoArrange == global::Infragistics.Windows.DataPresenter.AutoArrangeCells.Never)
					{
						this.ProcessAutoArrangeNever(layoutInfo);
					}
					else
					{
						this.ProcessAutoArrange(layoutInfo, flag, isHorizontal);
					}
					if (this._fieldLayout.ShouldCreateDragFieldLayout)
					{
						this._fieldLayout.ShouldCreateDragFieldLayout = false;
						this._fieldLayout.SetFieldLayoutInfo(layoutInfo, true, false);
					}
				}
				int num = 0;
				int num2 = 0;
				foreach (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo in layoutInfo.Values)
				{
					if (!itemLayoutInfo.IsCollapsed)
					{
						num = global::System.Math.Max(num, itemLayoutInfo.Column + itemLayoutInfo.ColumnSpan);
						num2 = global::System.Math.Max(num2, itemLayoutInfo.Row + itemLayoutInfo.RowSpan);
					}
				}
				this._totalColumns = num;
				this._totalRows = num2;
				this._layoutInfo = layoutInfo;
			}

			// Token: 0x0600223A RID: 8762 RVA: 0x000954A4 File Offset: 0x000936A4
			private void ProcessAutoArrange(global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo, bool isFixedSupported, bool isHorizontal)
			{
				bool flag = this._autoArrange == global::Infragistics.Windows.DataPresenter.AutoArrangeCells.LeftToRight;
				int num = this._maxColumns;
				int num2 = this._maxRows;
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = null;
				global::Infragistics.Windows.DataPresenter.FixedFieldLocation? fixedFieldLocation = null;
				int num3 = 0;
				int num4 = 0;
				if (this._primaryFieldReservation != global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.None)
				{
					fixedFieldLocation = new global::Infragistics.Windows.DataPresenter.FixedFieldLocation?(isFixedSupported ? this._primaryField.FixedLocation : global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable);
					list = this.GetList(fixedFieldLocation.Value);
					list.Remove(this._primaryField);
					if (this._primaryFieldReservation == global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.ReserveFirstCell)
					{
						list.Insert(0, this._primaryField);
						list = null;
					}
					else if (this._primaryFieldReservation == global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.ReserveFirstColumn)
					{
						num3++;
					}
					else
					{
						num4++;
					}
				}
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				int num9 = 0;
				int num10 = 0;
				if ((this._maxColumns <= 0 || this._maxColumns > num3) && (this._maxRows <= 0 || this._maxRows > num4))
				{
					int count = this._fixedNearFields.Count;
					int count2 = this._fixedFarFields.Count;
					int count3 = this._scrollableFields.Count;
					if (num == 0)
					{
						num = int.MaxValue;
					}
					else
					{
						num -= num3;
					}
					if (num2 == 0)
					{
						num2 = int.MaxValue;
					}
					else
					{
						num2 -= num4;
					}
					if (!flag)
					{
						global::Infragistics.Windows.DataPresenter.GridUtilities.SwapValues(ref num2, ref num);
					}
					int num11 = (isHorizontal != flag) ? (count + count2 + count3) : global::System.Math.Max(count, global::System.Math.Max(count2, count3));
					if (num11 <= num)
					{
						num5 = count2;
						num7 = count;
						num9 = count3;
						num6 = global::System.Math.Min(count2, 1);
						num8 = global::System.Math.Min(count, 1);
						num10 = global::System.Math.Min(count3, 1);
					}
					else if (isHorizontal != flag)
					{
						num5 = ((count2 > 0) ? 1 : 0);
						num7 = ((count > 0) ? 1 : 0);
						num9 = ((count3 > 0) ? 1 : 0);
						int remainingExtent = num - (num7 + num5 + num9);
						global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.ArrangeHelper.AddAreaExtents(count, count2, count3, remainingExtent, ref num7, ref num5, ref num9);
						num6 = ((count2 == 0) ? 0 : global::System.Math.Min(num2, (count2 - 1) / num5 + 1));
						num8 = ((count == 0) ? 0 : global::System.Math.Min(num2, (count - 1) / num7 + 1));
						num10 = ((count3 == 0) ? 0 : global::System.Math.Min(num2, (count3 - 1) / num9 + 1));
					}
					else
					{
						num6 = ((count2 > 0) ? 1 : 0);
						num8 = ((count > 0) ? 1 : 0);
						num10 = ((count3 > 0) ? 1 : 0);
						num2 = global::System.Math.Min(num2, ((num6 == 0) ? 0 : ((count2 - 1) / num + 1)) + ((num8 == 0) ? 0 : ((count - 1) / num + 1)) + ((num10 == 0) ? 0 : ((count3 - 1) / num + 1)));
						int remainingExtent2 = num2 - (num6 + num8 + num10);
						global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.ArrangeHelper.AddAreaExtents(count, count2, count3, remainingExtent2, ref num8, ref num6, ref num10);
						num5 = global::System.Math.Min(num, count2);
						num7 = global::System.Math.Min(num, count);
						num9 = global::System.Math.Min(num, count3);
					}
					if (!flag)
					{
						global::Infragistics.Windows.DataPresenter.GridUtilities.SwapValues(ref num8, ref num7);
						global::Infragistics.Windows.DataPresenter.GridUtilities.SwapValues(ref num5, ref num6);
						global::Infragistics.Windows.DataPresenter.GridUtilities.SwapValues(ref num9, ref num10);
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.ArrangeHelper.Trim<global::Infragistics.Windows.DataPresenter.Field>(this._fixedNearFields, num7 * num8);
				global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.ArrangeHelper.Trim<global::Infragistics.Windows.DataPresenter.Field>(this._fixedFarFields, num5 * num6);
				global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.ArrangeHelper.Trim<global::Infragistics.Windows.DataPresenter.Field>(this._scrollableFields, num9 * num10);
				int num12 = (!isHorizontal) ? num4 : 0;
				int num13 = isHorizontal ? num3 : 0;
				if (fixedFieldLocation != null)
				{
					switch (fixedFieldLocation.Value)
					{
					case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable:
						num9 = global::System.Math.Max(1, num9);
						num10 = global::System.Math.Max(1, num10);
						break;
					case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge:
						num7 = global::System.Math.Max(1, num7);
						num8 = global::System.Math.Max(1, num8);
						break;
					case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge:
						num5 = global::System.Math.Max(1, num5);
						num6 = global::System.Math.Max(1, num6);
						break;
					}
				}
				int totalLogicalRowSpan = global::System.Math.Max(num6, global::System.Math.Max(num8, num10));
				int totalLogicalColSpan = global::System.Math.Max(num5, global::System.Math.Max(num7, num9));
				this.ArrangeArea(layoutInfo, flag, isHorizontal, ref num12, ref num13, num7, num8, this._fixedNearFields, list, num3, num4, totalLogicalRowSpan, totalLogicalColSpan);
				this.ArrangeArea(layoutInfo, flag, isHorizontal, ref num12, ref num13, num9, num10, this._scrollableFields, list, num3, num4, totalLogicalRowSpan, totalLogicalColSpan);
				this.ArrangeArea(layoutInfo, flag, isHorizontal, ref num12, ref num13, num5, num6, this._fixedFarFields, list, num3, num4, totalLogicalRowSpan, totalLogicalColSpan);
			}

			// Token: 0x0600223B RID: 8763 RVA: 0x000958A0 File Offset: 0x00093AA0
			private void ProcessAutoArrangeNever(global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo)
			{
				int num;
				int num2;
				global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.ArrangeHelper.GetLogicalRowColCount(this._fieldLayout.Fields, out num, out num2);
				if (this._fieldLayout.IsHorizontal)
				{
					num = 0;
				}
				else
				{
					num2 = 0;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.ArrangeHelper.AddFields(layoutInfo, this._fixedNearFields, 0, 0);
				if (this._fixedNearFields.Count > 0)
				{
					if (this._scrollableFields.Count > 0)
					{
						global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.ArrangeHelper.AddFields(layoutInfo, this._scrollableFields, num, num2);
						num *= 2;
						num2 *= 2;
					}
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.ArrangeHelper.AddFields(layoutInfo, this._scrollableFields, 0, 0);
				}
				if (layoutInfo.Count > 0)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.ArrangeHelper.AddFields(layoutInfo, this._fixedFarFields, num, num2);
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.ArrangeHelper.AddFields(layoutInfo, this._fixedFarFields, 0, 0);
				}
				layoutInfo.PackLayout();
			}

			// Token: 0x0600223C RID: 8764 RVA: 0x00095951 File Offset: 0x00093B51
			private static void Trim<T>(global::System.Collections.Generic.List<T> items, int maxCount)
			{
				if (items.Count > maxCount)
				{
					items.RemoveRange(maxCount, items.Count - maxCount);
				}
			}

			// Token: 0x040010BB RID: 4283
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _fixedNearFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();

			// Token: 0x040010BC RID: 4284
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _fixedFarFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();

			// Token: 0x040010BD RID: 4285
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _scrollableFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();

			// Token: 0x040010BE RID: 4286
			private readonly global::Infragistics.Windows.DataPresenter.Field _primaryField;

			// Token: 0x040010BF RID: 4287
			private readonly global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation _primaryFieldReservation;

			// Token: 0x040010C0 RID: 4288
			private readonly global::Infragistics.Windows.DataPresenter.AutoArrangeCells _autoArrange;

			// Token: 0x040010C1 RID: 4289
			private readonly global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

			// Token: 0x040010C2 RID: 4290
			private readonly int _maxRows;

			// Token: 0x040010C3 RID: 4291
			private readonly int _maxColumns;

			// Token: 0x040010C4 RID: 4292
			private global::Infragistics.Windows.DataPresenter.LayoutInfo _layoutInfo;

			// Token: 0x040010C5 RID: 4293
			private int _totalRows;

			// Token: 0x040010C6 RID: 4294
			private int _totalColumns;
		}
	}
}
