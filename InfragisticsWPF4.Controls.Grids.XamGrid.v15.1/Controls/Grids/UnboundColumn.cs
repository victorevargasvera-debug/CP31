using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000253 RID: 595
	public class UnboundColumn : global::Infragistics.Controls.Grids.EditableColumn
	{
		// Token: 0x060012F7 RID: 4855 RVA: 0x00047B77 File Offset: 0x00045D77
		public UnboundColumn()
		{
			this.IsFilterable = false;
			this.IsSummable = false;
			this.DataType = typeof(object);
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x00047B9D File Offset: 0x00045D9D
		protected internal override global::Infragistics.Controls.Grids.FilterOperand DefaultFilterOperand
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00047BA0 File Offset: 0x00045DA0
		protected internal override bool UseReadOnlyFlag
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x00047BA3 File Offset: 0x00045DA3
		protected internal override bool IsEditable
		{
			get
			{
				return base.IsEditable && (this.EditorTemplate != null || base.AddNewRowEditorTemplate != null);
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x00047BC5 File Offset: 0x00045DC5
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x00047BCD File Offset: 0x00045DCD
		internal int EditorTemplateDirtyFlag { get; set; }

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x00047BD6 File Offset: 0x00045DD6
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x00047BE8 File Offset: 0x00045DE8
		public global::System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.UnboundColumn.ItemTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.UnboundColumn.ItemTemplateProperty, value);
			}
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00047BF6 File Offset: 0x00045DF6
		private static void ItemTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x00047BF8 File Offset: 0x00045DF8
		// (set) Token: 0x06001301 RID: 4865 RVA: 0x00047C0A File Offset: 0x00045E0A
		public global::System.Windows.DataTemplate EditorTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.UnboundColumn.EditorTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.UnboundColumn.EditorTemplateProperty, value);
			}
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00047C18 File Offset: 0x00045E18
		private static void EditorTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.UnboundColumn unboundColumn = (global::Infragistics.Controls.Grids.UnboundColumn)obj;
			unboundColumn.EditorTemplateDirtyFlag++;
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x00047C3A File Offset: 0x00045E3A
		// (set) Token: 0x06001304 RID: 4868 RVA: 0x00047C4C File Offset: 0x00045E4C
		public global::System.Windows.DataTemplate FilterItemTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.UnboundColumn.FilterItemTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.UnboundColumn.FilterItemTemplateProperty, value);
			}
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00047C5C File Offset: 0x00045E5C
		private static void FilterItemTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.UnboundColumn unboundColumn = (global::Infragistics.Controls.Grids.UnboundColumn)obj;
			unboundColumn.OnPropertyChanged("FilterItemTemplate");
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x00047C7B File Offset: 0x00045E7B
		// (set) Token: 0x06001307 RID: 4871 RVA: 0x00047C8D File Offset: 0x00045E8D
		public global::System.Windows.DataTemplate FilterEditorTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.UnboundColumn.FilterEditorTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.UnboundColumn.FilterEditorTemplateProperty, value);
			}
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00047C9C File Offset: 0x00045E9C
		private static void FilterEditorTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.UnboundColumn unboundColumn = (global::Infragistics.Controls.Grids.UnboundColumn)obj;
			unboundColumn.OnPropertyChanged("FilterEditorTemplate");
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x00047CBB File Offset: 0x00045EBB
		protected internal override bool ResetCellValueObjectAfterEditing
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x00047CBE File Offset: 0x00045EBE
		protected internal override bool RequiresBoundDataKey
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x00047CC1 File Offset: 0x00045EC1
		// (set) Token: 0x0600130C RID: 4876 RVA: 0x00047CE3 File Offset: 0x00045EE3
		public override bool IsSortable
		{
			get
			{
				return base.IsSortable && (base.ValueConverter != null || base.SortComparer != null);
			}
			set
			{
				base.IsSortable = value;
			}
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00047CEC File Offset: 0x00045EEC
		protected override global::Infragistics.Controls.Grids.CellBase GenerateDataCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (row.RowType == global::Infragistics.Controls.Grids.RowType.AddNewRow)
			{
				return new global::Infragistics.Controls.Grids.Primitives.AddNewRowCell(row, this);
			}
			if (row.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow)
			{
				return new global::Infragistics.Controls.Grids.Primitives.FilterRowCell(row, this);
			}
			if (row.RowType == global::Infragistics.Controls.Grids.RowType.SummaryRow)
			{
				return new global::Infragistics.Controls.Grids.Primitives.SummaryRowCell(row, this);
			}
			if (row.RowType == global::Infragistics.Controls.Grids.RowType.MergedSummaryRow)
			{
				return new global::Infragistics.Controls.Grids.Primitives.MergedSummaryCell(row, this);
			}
			if (base.ColumnLayout.Grid.ConditionalFormattingSettings.AllowConditionalFormatting)
			{
				return new global::Infragistics.Controls.Grids.Primitives.ConditionalFormattingUnboundCell(row, this);
			}
			return new global::Infragistics.Controls.Grids.Primitives.UnboundCell(row, this);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00047D65 File Offset: 0x00045F65
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return new global::Infragistics.Controls.Grids.Primitives.UnboundColumnContentProvider();
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00047D6C File Offset: 0x00045F6C
		protected internal override void FillAvailableFilters(global::Infragistics.Controls.Grids.FilterOperandCollection availableFilters)
		{
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00047D6E File Offset: 0x00045F6E
		protected internal override void FillAvailableSummaries(global::Infragistics.SummaryOperandCollection availableSummaries)
		{
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00047D70 File Offset: 0x00045F70
		protected override void ValidateSortComparer()
		{
			if (base.SortComparer != null && base.ColumnLayout != null && base.ColumnLayout.ObjectDataType != null)
			{
				global::System.Type type = typeof(global::System.Collections.Generic.IComparer<>).MakeGenericType(new global::System.Type[]
				{
					base.ColumnLayout.ObjectDataType
				});
				if (!type.IsAssignableFrom(base.SortComparer.GetType()))
				{
					global::System.Globalization.CultureInfo currentCulture = global::System.Threading.Thread.CurrentThread.CurrentCulture;
					throw new global::System.TypeLoadException(string.Format(currentCulture, global::Infragistics.SRGrid.GetString("TypeMismatchException"), new object[]
					{
						base.SortComparer.GetType().Name,
						type.Name
					}));
				}
			}
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00047E24 File Offset: 0x00046024
		protected override void ValidateGroupByComparer()
		{
			if (base.GroupByComparer != null && base.ColumnLayout != null && base.ColumnLayout.ObjectDataType != null)
			{
				global::System.Type type = typeof(global::System.Collections.Generic.IEqualityComparer<>).MakeGenericType(new global::System.Type[]
				{
					base.ColumnLayout.ObjectDataType
				});
				if (!type.IsAssignableFrom(base.GroupByComparer.GetType()))
				{
					global::System.Globalization.CultureInfo currentCulture = global::System.Threading.Thread.CurrentThread.CurrentCulture;
					throw new global::System.TypeLoadException(string.Format(currentCulture, global::Infragistics.SRGrid.GetString("TypeMismatchException"), new object[]
					{
						base.GroupByComparer.GetType().Name,
						type.Name
					}));
				}
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001313 RID: 4883 RVA: 0x00047ED8 File Offset: 0x000460D8
		protected internal override bool UniqueColumnContent
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040005DF RID: 1503
		public static readonly global::System.Windows.DependencyProperty ItemTemplateProperty = global::System.Windows.DependencyProperty.Register("ItemTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.UnboundColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.UnboundColumn.ItemTemplateChanged)));

		// Token: 0x040005E0 RID: 1504
		public static readonly global::System.Windows.DependencyProperty EditorTemplateProperty = global::System.Windows.DependencyProperty.Register("EditorTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.UnboundColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.UnboundColumn.EditorTemplateChanged)));

		// Token: 0x040005E1 RID: 1505
		public static readonly global::System.Windows.DependencyProperty FilterItemTemplateProperty = global::System.Windows.DependencyProperty.Register("FilterItemTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.UnboundColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.UnboundColumn.FilterItemTemplateChanged)));

		// Token: 0x040005E2 RID: 1506
		public static readonly global::System.Windows.DependencyProperty FilterEditorTemplateProperty = global::System.Windows.DependencyProperty.Register("FilterEditorTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.UnboundColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.UnboundColumn.FilterEditorTemplateChanged)));
	}
}
