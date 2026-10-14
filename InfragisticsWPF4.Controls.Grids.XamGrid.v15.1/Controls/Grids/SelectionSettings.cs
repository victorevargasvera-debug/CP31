using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200012C RID: 300
	public class SelectionSettings : global::Infragistics.Controls.Grids.SettingsBase, global::System.IDisposable, global::Infragistics.IProvidePropertyPersistenceSettings
	{
		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x00026604 File Offset: 0x00024804
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x00026616 File Offset: 0x00024816
		public global::Infragistics.Controls.Grids.SelectionType CellSelection
		{
			get
			{
				return (global::Infragistics.Controls.Grids.SelectionType)base.GetValue(global::Infragistics.Controls.Grids.SelectionSettings.CellSelectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SelectionSettings.CellSelectionProperty, value);
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0002662C File Offset: 0x0002482C
		private static void CellSelectionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SelectionSettings selectionSettings = (global::Infragistics.Controls.Grids.SelectionSettings)obj;
			selectionSettings.OnPropertyChanged("CellSelection");
			if (selectionSettings.Grid != null && selectionSettings.CellSelection == global::Infragistics.Controls.Grids.SelectionType.None)
			{
				selectionSettings.Grid.SelectionSettings.SelectedCells.Clear();
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00026670 File Offset: 0x00024870
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x00026682 File Offset: 0x00024882
		public global::Infragistics.Controls.Grids.SelectionType RowSelection
		{
			get
			{
				return (global::Infragistics.Controls.Grids.SelectionType)base.GetValue(global::Infragistics.Controls.Grids.SelectionSettings.RowSelectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SelectionSettings.RowSelectionProperty, value);
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00026698 File Offset: 0x00024898
		private static void RowSelectionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SelectionSettings selectionSettings = (global::Infragistics.Controls.Grids.SelectionSettings)obj;
			selectionSettings.OnPropertyChanged("RowSelection");
			if (selectionSettings.Grid != null && selectionSettings.RowSelection == global::Infragistics.Controls.Grids.SelectionType.None)
			{
				selectionSettings.Grid.SelectionSettings.SelectedRows.Clear();
			}
			selectionSettings.OnPropertyChanged("RowSelection");
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x000266E7 File Offset: 0x000248E7
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x000266F9 File Offset: 0x000248F9
		public global::Infragistics.Controls.Grids.SelectionType ColumnSelection
		{
			get
			{
				return (global::Infragistics.Controls.Grids.SelectionType)base.GetValue(global::Infragistics.Controls.Grids.SelectionSettings.ColumnSelectionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SelectionSettings.ColumnSelectionProperty, value);
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0002670C File Offset: 0x0002490C
		private static void ColumnSelectionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SelectionSettings selectionSettings = (global::Infragistics.Controls.Grids.SelectionSettings)obj;
			selectionSettings.OnPropertyChanged("ColumnSelection");
			if (selectionSettings.Grid != null && selectionSettings.ColumnSelection == global::Infragistics.Controls.Grids.SelectionType.None)
			{
				selectionSettings.Grid.SelectionSettings.SelectedColumns.Clear();
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00026750 File Offset: 0x00024950
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x00026762 File Offset: 0x00024962
		public global::Infragistics.Controls.Grids.CellSelectionAction CellClickAction
		{
			get
			{
				return (global::Infragistics.Controls.Grids.CellSelectionAction)base.GetValue(global::Infragistics.Controls.Grids.SelectionSettings.CellClickActionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.SelectionSettings.CellClickActionProperty, value);
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00026778 File Offset: 0x00024978
		private static void CellSelectionActionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.SelectionSettings selectionSettings = (global::Infragistics.Controls.Grids.SelectionSettings)obj;
			selectionSettings.OnPropertyChanged("CellClickAction");
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x00026797 File Offset: 0x00024997
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.SelectedRowsCollection SelectedRows
		{
			get
			{
				if (this._selectedRows == null)
				{
					this._selectedRows = new global::Infragistics.Controls.Grids.SelectedRowsCollection();
					this._selectedRows.Grid = base.Grid;
				}
				return this._selectedRows;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x000267C3 File Offset: 0x000249C3
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.SelectedCellsCollection SelectedCells
		{
			get
			{
				if (this._selectedCells == null)
				{
					this._selectedCells = new global::Infragistics.Controls.Grids.SelectedCellsCollection();
					this._selectedCells.Grid = base.Grid;
				}
				return this._selectedCells;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x000267EF File Offset: 0x000249EF
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.SelectedColumnsCollection SelectedColumns
		{
			get
			{
				if (this._selectedColumns == null)
				{
					this._selectedColumns = new global::Infragistics.Controls.Grids.SelectedColumnsCollection();
					this._selectedColumns.Grid = base.Grid;
				}
				return this._selectedColumns;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0002681C File Offset: 0x00024A1C
		protected virtual global::System.Collections.Generic.List<string> PropertiesToIgnore
		{
			get
			{
				if (this._propertiesThatShouldntBePersisted == null)
				{
					this._propertiesThatShouldntBePersisted = new global::System.Collections.Generic.List<string>
					{
						"SelectedRows",
						"SelectedCells"
					};
				}
				return this._propertiesThatShouldntBePersisted;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0002685A File Offset: 0x00024A5A
		protected virtual global::System.Collections.Generic.List<string> PriorityProperties
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0002685D File Offset: 0x00024A5D
		protected virtual void FinishedLoadingPersistence()
		{
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0002685F File Offset: 0x00024A5F
		protected virtual void Dispose(bool disposing)
		{
			if (this._selectedCells != null)
			{
				this._selectedCells.Dispose();
			}
			if (this._selectedRows != null)
			{
				this._selectedRows.Dispose();
			}
			if (this._selectedColumns != null)
			{
				this._selectedColumns.Dispose();
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0002689A File Offset: 0x00024A9A
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x000268A9 File Offset: 0x00024AA9
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PropertiesToIgnore
		{
			get
			{
				return this.PropertiesToIgnore;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x000268B1 File Offset: 0x00024AB1
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PriorityProperties
		{
			get
			{
				return this.PriorityProperties;
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x000268B9 File Offset: 0x00024AB9
		void global::Infragistics.IProvidePropertyPersistenceSettings.FinishedLoadingPersistence()
		{
			this.FinishedLoadingPersistence();
		}

		// Token: 0x0400026A RID: 618
		private global::Infragistics.Controls.Grids.SelectedRowsCollection _selectedRows;

		// Token: 0x0400026B RID: 619
		private global::Infragistics.Controls.Grids.SelectedCellsCollection _selectedCells;

		// Token: 0x0400026C RID: 620
		private global::Infragistics.Controls.Grids.SelectedColumnsCollection _selectedColumns;

		// Token: 0x0400026D RID: 621
		private global::System.Collections.Generic.List<string> _propertiesThatShouldntBePersisted;

		// Token: 0x0400026E RID: 622
		public static readonly global::System.Windows.DependencyProperty CellSelectionProperty = global::System.Windows.DependencyProperty.Register("CellSelection", typeof(global::Infragistics.Controls.Grids.SelectionType), typeof(global::Infragistics.Controls.Grids.SelectionSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.SelectionType.Single, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SelectionSettings.CellSelectionChanged)));

		// Token: 0x0400026F RID: 623
		public static readonly global::System.Windows.DependencyProperty RowSelectionProperty = global::System.Windows.DependencyProperty.Register("RowSelection", typeof(global::Infragistics.Controls.Grids.SelectionType), typeof(global::Infragistics.Controls.Grids.SelectionSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.SelectionType.Single, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SelectionSettings.RowSelectionChanged)));

		// Token: 0x04000270 RID: 624
		public static readonly global::System.Windows.DependencyProperty ColumnSelectionProperty = global::System.Windows.DependencyProperty.Register("ColumnSelection", typeof(global::Infragistics.Controls.Grids.SelectionType), typeof(global::Infragistics.Controls.Grids.SelectionSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.SelectionType.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SelectionSettings.ColumnSelectionChanged)));

		// Token: 0x04000271 RID: 625
		public static readonly global::System.Windows.DependencyProperty CellClickActionProperty = global::System.Windows.DependencyProperty.Register("CellClickAction", typeof(global::Infragistics.Controls.Grids.CellSelectionAction), typeof(global::Infragistics.Controls.Grids.SelectionSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.CellSelectionAction.SelectCell, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.SelectionSettings.CellSelectionActionChanged)));
	}
}
