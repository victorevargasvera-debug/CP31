using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Infragistics.Windows.DataPresenter.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200030A RID: 778
	public abstract class FieldLayoutTemplateGenerator
	{
		// Token: 0x06002591 RID: 9617 RVA: 0x000A6FFA File Offset: 0x000A51FA
		protected FieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			this._fieldLayout = fieldLayout;
			global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator._nextGeneratorId++;
			this._templateVersion = global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator._nextGeneratorId << 24;
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x000A7031 File Offset: 0x000A5231
		public virtual global::Infragistics.Windows.DataPresenter.CellContentAlignment DefaultCellContentAlignment
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueStretch;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06002593 RID: 9619
		public abstract global::Infragistics.Windows.DataPresenter.AutoArrangeCells DefaultAutoArrangeCells { get; }

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x000A7034 File Offset: 0x000A5234
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x000A703C File Offset: 0x000A523C
		public global::System.Windows.DataTemplate GeneratedHeaderTemplate
		{
			get
			{
				this.GenerateTemplates();
				return this._generatedHeaderTemplate;
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x000A704A File Offset: 0x000A524A
		[global::System.Obsolete("The 'GeneratedRecordContentAreaTemplate' is no longer created. The 'GeneratedVirtualRecordContentAreaTemplate' will be used instead.")]
		public global::System.Windows.DataTemplate GeneratedRecordContentAreaTemplate
		{
			get
			{
				return this.GeneratedVirtualRecordContentAreaTemplate;
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x000A7052 File Offset: 0x000A5252
		public global::System.Windows.DataTemplate GeneratedVirtualRecordContentAreaTemplate
		{
			get
			{
				this.GenerateTemplates();
				return this._generatedVirtualizedRecordContentAreaTemplate;
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x000A7060 File Offset: 0x000A5260
		public global::System.Windows.DataTemplate GeneratedSummaryRecordContentAreaTemplate
		{
			get
			{
				this.GenerateTemplates();
				return this._generatedSummaryRecordContentAreaTemplate;
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002599 RID: 9625 RVA: 0x000A706E File Offset: 0x000A526E
		[global::System.Obsolete("The 'GeneratedSummaryCellAreaTemplate' is no longer created. The 'GeneratedSummaryVirtualCellAreaTemplate' will be used instead.")]
		public global::System.Windows.DataTemplate GeneratedSummaryCellAreaTemplate
		{
			get
			{
				return this.GeneratedSummaryVirtualCellAreaTemplate;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x0600259A RID: 9626 RVA: 0x000A7076 File Offset: 0x000A5276
		public global::System.Windows.DataTemplate GeneratedSummaryVirtualCellAreaTemplate
		{
			get
			{
				this.GenerateTemplates();
				return this._generatedSummaryVirtualCellAreaTemplate;
			}
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x000A7084 File Offset: 0x000A5284
		public virtual global::Infragistics.Windows.DataPresenter.PanelNavigationDirection GetRecordNavigationDirectionFromCellNavigationDirection(global::Infragistics.Windows.DataPresenter.PanelNavigationDirection cellNavigationDirection)
		{
			return cellNavigationDirection;
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x0600259C RID: 9628 RVA: 0x000A7087 File Offset: 0x000A5287
		internal global::Infragistics.Windows.DataPresenter.GridFieldMap GridFieldMap
		{
			get
			{
				if (this._gridFieldMap == null)
				{
					this._gridFieldMap = new global::Infragistics.Windows.DataPresenter.GridFieldMap(this, false, null, null);
				}
				return this._gridFieldMap;
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x000A70A6 File Offset: 0x000A52A6
		public virtual global::System.Windows.Controls.Orientation LogicalOrientation
		{
			get
			{
				return global::System.Windows.Controls.Orientation.Vertical;
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x000A70A9 File Offset: 0x000A52A9
		public virtual bool HasLogicalOrientation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x000A70AC File Offset: 0x000A52AC
		public bool HasSeparateHeader
		{
			get
			{
				return this._separateHeader;
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x060025A0 RID: 9632
		public abstract global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation { get; }

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x060025A1 RID: 9633 RVA: 0x000A70B4 File Offset: 0x000A52B4
		public virtual global::Infragistics.Windows.DataPresenter.CellContentAlignment PrimaryFieldDefaultCellContentAlignment
		{
			get
			{
				return this.DefaultCellContentAlignment;
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x000A70BC File Offset: 0x000A52BC
		public virtual bool SupportsLabelHeaders
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x060025A3 RID: 9635 RVA: 0x000A70BF File Offset: 0x000A52BF
		internal virtual bool AreRecordsArrangedInRowsAndCols
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x060025A4 RID: 9636 RVA: 0x000A70C2 File Offset: 0x000A52C2
		internal global::System.Windows.Controls.ColumnDefinition DefaultColumnDefinition
		{
			get
			{
				return this._defaultColumnDefinition;
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x060025A5 RID: 9637 RVA: 0x000A70CA File Offset: 0x000A52CA
		internal global::System.Windows.Controls.RowDefinition DefaultRowDefinition
		{
			get
			{
				return this._defaultRowDefinition;
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x000A70D2 File Offset: 0x000A52D2
		internal bool IsDirty
		{
			get
			{
				return this._stylesAreDirty;
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x060025A7 RID: 9639 RVA: 0x000A70DA File Offset: 0x000A52DA
		internal global::System.Windows.DataTemplate TemplateDataRecordContentAreaTemplate
		{
			get
			{
				this.GenerateTemplates();
				return this._generatedTemplateDataRecordContentAreaTemplate;
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x000A70E8 File Offset: 0x000A52E8
		internal global::System.Windows.DataTemplate TemplateDataRecordHeaderAreaTemplate
		{
			get
			{
				this.GenerateTemplates();
				return this._generatedTemplateDataRecordHeaderAreaTemplate;
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x000A70F6 File Offset: 0x000A52F6
		internal bool IsGeneratingTemplates
		{
			get
			{
				return this._isGeneratingTemplates;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x000A70FE File Offset: 0x000A52FE
		internal global::System.Windows.Controls.Grid TemplateGrid
		{
			get
			{
				return this._templateGrid;
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x000A7106 File Offset: 0x000A5306
		internal int TemplateVersion
		{
			get
			{
				return this._templateVersion;
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x000A710E File Offset: 0x000A530E
		internal bool UseCellPresenters
		{
			get
			{
				return this._labelLocation == global::Infragistics.Windows.DataPresenter.LabelLocation.InCells;
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x000A7119 File Offset: 0x000A5319
		internal int Version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x000A7121 File Offset: 0x000A5321
		protected virtual global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation DefaultAutoArrangePrimaryFieldReservation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.ReserveFirstRow;
			}
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x000A7124 File Offset: 0x000A5324
		public void InvalidateGeneratedTemplates()
		{
			this.InvalidateGeneratedTemplates(true);
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x000A7130 File Offset: 0x000A5330
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

		// Token: 0x060025B1 RID: 9649 RVA: 0x000A7180 File Offset: 0x000A5380
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

		// Token: 0x060025B2 RID: 9650 RVA: 0x000A7238 File Offset: 0x000A5438
		private void GenerateSummaryRecordContentAreaTemplate()
		{
			global::System.Windows.FrameworkElementFactory visualTree = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordContentArea));
			this._generatedSummaryRecordContentAreaTemplate = new global::System.Windows.DataTemplate();
			this._generatedSummaryRecordContentAreaTemplate.VisualTree = visualTree;
			this._generatedSummaryVirtualCellAreaTemplate = new global::System.Windows.DataTemplate();
			this._generatedSummaryVirtualCellAreaTemplate.VisualTree = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.DataPresenter.VirtualizingSummaryCellPanel));
			this._generatedSummaryVirtualCellAreaTemplate.Seal();
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x000A729C File Offset: 0x000A549C
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

		// Token: 0x060025B4 RID: 9652 RVA: 0x000A77F2 File Offset: 0x000A59F2
		internal global::System.Windows.Controls.ColumnDefinition[] GetCellAreaColumnDefinitions()
		{
			if (this._cellAreaColumnDefinitions == null)
			{
				return new global::System.Windows.Controls.ColumnDefinition[0];
			}
			return (global::System.Windows.Controls.ColumnDefinition[])this._cellAreaColumnDefinitions.Clone();
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x000A7813 File Offset: 0x000A5A13
		internal global::System.Windows.Controls.RowDefinition[] GetCellAreaRowDefinitions()
		{
			if (this._cellAreaRowDefinitions == null)
			{
				return new global::System.Windows.Controls.RowDefinition[0];
			}
			return (global::System.Windows.Controls.RowDefinition[])this._cellAreaRowDefinitions.Clone();
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x000A7834 File Offset: 0x000A5A34
		private void BindContentSiteMargin(global::System.Windows.FrameworkElementFactory fefContentSite, bool isHeader)
		{
			fefContentSite.SetBinding(global::System.Windows.FrameworkElement.MarginProperty, global::Infragistics.Windows.DataPresenter.GridUtilities.CreateRecordContentMarginBinding(this._fieldLayout, isHeader, fefContentSite.Type));
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x000A7854 File Offset: 0x000A5A54
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

		// Token: 0x060025B8 RID: 9656 RVA: 0x000A7990 File Offset: 0x000A5B90
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

		// Token: 0x060025B9 RID: 9657 RVA: 0x000A79BC File Offset: 0x000A5BBC
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

		// Token: 0x060025BA RID: 9658 RVA: 0x000A7A28 File Offset: 0x000A5C28
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

		// Token: 0x060025BB RID: 9659 RVA: 0x000A7A94 File Offset: 0x000A5C94
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
			bool isWidth = false;
			switch (selectorLocation)
			{
			case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.LeftOfCellArea:
			case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.RightOfCellArea:
				isWidth = true;
				break;
			}
			global::System.Windows.Data.BindingBase binding;
			if (this._fieldLayout.RecordSelectorNumberTypeResolved != global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType.None)
			{
				binding = global::Infragistics.Windows.DataPresenter.GridUtilities.CreateRecordSelectorExtentBinding(this._fieldLayout, isWidth, frameworkElementFactory2.Type);
			}
			else
			{
				binding = global::Infragistics.Windows.Utilities.CreateBindingObject("RecordSelectorExtentResolved", global::System.Windows.Data.BindingMode.OneWay, this._fieldLayout);
			}
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

		// Token: 0x060025BC RID: 9660 RVA: 0x000A7D08 File Offset: 0x000A5F08
		private void InitializeGridFieldMap()
		{
			this.GridFieldMap.ResetMap();
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x000A7D28 File Offset: 0x000A5F28
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
			else
			{
				this._fieldLayout._autoGeneratedPositions.RemoveDeletedFields();
			}
			global::Infragistics.Windows.DataPresenter.LayoutInfo autoGeneratedPositions = this._fieldLayout._autoGeneratedPositions;
			global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = null;
			global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo = null;
			global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.ArrangeHelper arrangeHelper = new global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.ArrangeHelper(this._fieldLayout, this._autoArrangeCells, primaryField, this._reservation, this._maxGridRows, this._maxGridColumns);
			bool flag = this._fieldLayout.AlignmentFieldLayout != null;
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fieldLayout.GetAllFields(true))
			{
				if (flag)
				{
					field.IsInLayout = (field.IsFieldMapped && field.MappedTreeField.IsInLayout);
				}
				else
				{
					field.IsInLayout = arrangeHelper.IsInLayout(field);
				}
				if (!field.IsInLayout)
				{
					if (autoGeneratedPositions != null)
					{
						global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo2;
						if (global::Infragistics.Windows.DataPresenter.AutoArrangeCells.Never == this._autoArrangeCells)
						{
							itemLayoutInfo2 = ((itemLayoutInfo != null) ? itemLayoutInfo.Clone() : new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(field.Column, field.Row, field.ColumnSpan, field.RowSpan));
						}
						else
						{
							itemLayoutInfo2 = ((itemLayoutInfo != null) ? itemLayoutInfo.Clone() : new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(0, 0, 1, 1));
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
						}
						itemLayoutInfo2.IsCollapsed = true;
						if (layoutInfo == null)
						{
							layoutInfo = new global::Infragistics.Windows.DataPresenter.LayoutInfo(this._fieldLayout);
						}
						layoutInfo[field] = itemLayoutInfo2;
					}
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.SpanInfo spanInfo;
					global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.RowColInfo rowColInfo;
					if (flag)
					{
						global::Infragistics.Windows.DataPresenter.FieldPosition actualPosition = field.ActualPosition;
						spanInfo = new global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.SpanInfo
						{
							RowSpan = actualPosition.RowSpan,
							ColumnSpan = actualPosition.ColumnSpan
						};
						rowColInfo = new global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator.RowColInfo
						{
							Row = actualPosition.Row,
							Column = actualPosition.Column
						};
					}
					else
					{
						spanInfo = arrangeHelper.GetSpanInfo(field);
						rowColInfo = arrangeHelper.GetRowColumn(field);
					}
					if (autoGeneratedPositions != null)
					{
						itemLayoutInfo = new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(rowColInfo.Column, rowColInfo.Row, spanInfo.ColumnSpan, spanInfo.RowSpan);
						itemLayoutInfo._fixedLocation = field.FixedLocation;
						itemLayoutInfo.Visibility = field.VisibilityInCellArea;
						autoGeneratedPositions[field] = itemLayoutInfo;
					}
					field.SetGridPositions(ref rowColInfo, ref spanInfo);
				}
			}
			if (layoutInfo != null && autoGeneratedPositions != null && !flag)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field field2 in layoutInfo.Keys)
				{
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo3 = layoutInfo[field2];
					global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo4 = new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(field2.Column, field2.Row, field2.ColumnSpan, field2.RowSpan);
					if (!autoGeneratedPositions.DoesItemOverlap(itemLayoutInfo4, null))
					{
						itemLayoutInfo3.SetPosition(itemLayoutInfo4.Column, itemLayoutInfo4.Row, itemLayoutInfo4.ColumnSpan, itemLayoutInfo4.RowSpan);
					}
					autoGeneratedPositions[field2] = itemLayoutInfo3;
				}
			}
			this.FieldLayout.SetHasSeparateHeader(this._separateHeader);
			this._fieldLayout.SetGridCounts(arrangeHelper.ColumnCount, arrangeHelper.RowCount);
		}

		// Token: 0x040012AF RID: 4783
		internal const string CellAreaItemGridName = "ContentItemGrid";

		// Token: 0x040012B0 RID: 4784
		internal const string HeaderAreaItemGridName = "HeaderItemGrid";

		// Token: 0x040012B1 RID: 4785
		private const int AutoArrangeMaxColumnsSupported = 4096;

		// Token: 0x040012B2 RID: 4786
		private bool _stylesAreDirty = true;

		// Token: 0x040012B3 RID: 4787
		private bool _separateHeader;

		// Token: 0x040012B4 RID: 4788
		private global::System.Windows.Controls.Grid _templateGrid;

		// Token: 0x040012B5 RID: 4789
		private global::System.Windows.Controls.ColumnDefinition _defaultColumnDefinition;

		// Token: 0x040012B6 RID: 4790
		private global::System.Windows.Controls.RowDefinition _defaultRowDefinition;

		// Token: 0x040012B7 RID: 4791
		private global::System.Windows.Controls.ColumnDefinition[] _cellAreaColumnDefinitions;

		// Token: 0x040012B8 RID: 4792
		private global::System.Windows.Controls.RowDefinition[] _cellAreaRowDefinitions;

		// Token: 0x040012B9 RID: 4793
		private global::System.Windows.DataTemplate _generatedHeaderTemplate;

		// Token: 0x040012BA RID: 4794
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x040012BB RID: 4795
		private global::Infragistics.Windows.DataPresenter.LabelLocation _labelLocation;

		// Token: 0x040012BC RID: 4796
		private global::Infragistics.Windows.DataPresenter.AutoArrangeCells _autoArrangeCells;

		// Token: 0x040012BD RID: 4797
		private global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation _reservation;

		// Token: 0x040012BE RID: 4798
		private int _maxGridRows;

		// Token: 0x040012BF RID: 4799
		private int _maxGridColumns;

		// Token: 0x040012C0 RID: 4800
		private global::Infragistics.Windows.DataPresenter.GridFieldMap _gridFieldMap;

		// Token: 0x040012C1 RID: 4801
		private global::System.Windows.DataTemplate _generatedVirtualizedRecordContentAreaTemplate;

		// Token: 0x040012C2 RID: 4802
		private global::System.Windows.DataTemplate _generatedSummaryRecordContentAreaTemplate;

		// Token: 0x040012C3 RID: 4803
		private global::System.Windows.DataTemplate _generatedSummaryVirtualCellAreaTemplate;

		// Token: 0x040012C4 RID: 4804
		private bool _isGeneratingTemplates;

		// Token: 0x040012C5 RID: 4805
		private global::System.Windows.DataTemplate _generatedTemplateDataRecordContentAreaTemplate;

		// Token: 0x040012C6 RID: 4806
		private global::System.Windows.DataTemplate _generatedTemplateDataRecordHeaderAreaTemplate;

		// Token: 0x040012C7 RID: 4807
		private bool _templatesAreDirty = true;

		// Token: 0x040012C8 RID: 4808
		private int _version;

		// Token: 0x040012C9 RID: 4809
		private int _templateVersion;

		// Token: 0x040012CA RID: 4810
		[global::System.ThreadStatic]
		private static int _nextGeneratorId;

		// Token: 0x0200030B RID: 779
		internal struct SpanInfo
		{
			// Token: 0x040012CC RID: 4812
			internal int RowSpan;

			// Token: 0x040012CD RID: 4813
			internal int ColumnSpan;
		}

		// Token: 0x0200030C RID: 780
		internal struct RowColInfo
		{
			// Token: 0x040012CE RID: 4814
			internal int Row;

			// Token: 0x040012CF RID: 4815
			internal int Column;
		}

		// Token: 0x0200030D RID: 781
		internal class GridSlotComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Field>
		{
			// Token: 0x060025BF RID: 9663 RVA: 0x000A816C File Offset: 0x000A636C
			internal GridSlotComparer(bool isWidth)
			{
				this._isWidth = isWidth;
			}

			// Token: 0x060025C0 RID: 9664 RVA: 0x000A817C File Offset: 0x000A637C
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
				int indexForCompare = x.IndexForCompare;
				int indexForCompare2 = y.IndexForCompare;
				if (indexForCompare < indexForCompare2)
				{
					return -1;
				}
				return 1;
			}

			// Token: 0x040012D0 RID: 4816
			private bool _isWidth;
		}

		// Token: 0x0200030E RID: 782
		private class ArrangeHelper
		{
			// Token: 0x060025C1 RID: 9665 RVA: 0x000A8240 File Offset: 0x000A6440
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

			// Token: 0x17000B46 RID: 2886
			// (get) Token: 0x060025C2 RID: 9666 RVA: 0x000A82CB File Offset: 0x000A64CB
			internal int ColumnCount
			{
				get
				{
					return this._totalColumns;
				}
			}

			// Token: 0x17000B47 RID: 2887
			// (get) Token: 0x060025C3 RID: 9667 RVA: 0x000A82D3 File Offset: 0x000A64D3
			internal int RowCount
			{
				get
				{
					return this._totalRows;
				}
			}

			// Token: 0x060025C4 RID: 9668 RVA: 0x000A82DC File Offset: 0x000A64DC
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

			// Token: 0x060025C5 RID: 9669 RVA: 0x000A8378 File Offset: 0x000A6578
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

			// Token: 0x060025C6 RID: 9670 RVA: 0x000A8418 File Offset: 0x000A6618
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

			// Token: 0x060025C7 RID: 9671 RVA: 0x000A849C File Offset: 0x000A669C
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

			// Token: 0x060025C8 RID: 9672 RVA: 0x000A85AC File Offset: 0x000A67AC
			internal bool IsInLayout(global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo;
				return this._layoutInfo.TryGetValue(field, out itemLayoutInfo) && !itemLayoutInfo.IsCollapsed && field.IsVisibleInCellArea;
			}

			// Token: 0x060025C9 RID: 9673 RVA: 0x000A85DC File Offset: 0x000A67DC
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

			// Token: 0x060025CA RID: 9674 RVA: 0x000A8614 File Offset: 0x000A6814
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

			// Token: 0x060025CB RID: 9675 RVA: 0x000A869C File Offset: 0x000A689C
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

			// Token: 0x060025CC RID: 9676 RVA: 0x000A86E0 File Offset: 0x000A68E0
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

			// Token: 0x060025CD RID: 9677 RVA: 0x000A8724 File Offset: 0x000A6924
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

			// Token: 0x060025CE RID: 9678 RVA: 0x000A8904 File Offset: 0x000A6B04
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

			// Token: 0x060025CF RID: 9679 RVA: 0x000A8D00 File Offset: 0x000A6F00
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

			// Token: 0x060025D0 RID: 9680 RVA: 0x000A8DB1 File Offset: 0x000A6FB1
			private static void Trim<T>(global::System.Collections.Generic.List<T> items, int maxCount)
			{
				if (items.Count > maxCount)
				{
					items.RemoveRange(maxCount, items.Count - maxCount);
				}
			}

			// Token: 0x040012D1 RID: 4817
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _fixedNearFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();

			// Token: 0x040012D2 RID: 4818
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _fixedFarFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();

			// Token: 0x040012D3 RID: 4819
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _scrollableFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();

			// Token: 0x040012D4 RID: 4820
			private readonly global::Infragistics.Windows.DataPresenter.Field _primaryField;

			// Token: 0x040012D5 RID: 4821
			private readonly global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation _primaryFieldReservation;

			// Token: 0x040012D6 RID: 4822
			private readonly global::Infragistics.Windows.DataPresenter.AutoArrangeCells _autoArrange;

			// Token: 0x040012D7 RID: 4823
			private readonly global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

			// Token: 0x040012D8 RID: 4824
			private readonly int _maxRows;

			// Token: 0x040012D9 RID: 4825
			private readonly int _maxColumns;

			// Token: 0x040012DA RID: 4826
			private global::Infragistics.Windows.DataPresenter.LayoutInfo _layoutInfo;

			// Token: 0x040012DB RID: 4827
			private int _totalRows;

			// Token: 0x040012DC RID: 4828
			private int _totalColumns;
		}
	}
}
