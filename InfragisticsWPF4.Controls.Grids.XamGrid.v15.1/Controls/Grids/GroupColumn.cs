using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using Infragistics.Collections;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000250 RID: 592
	public class GroupColumn : global::Infragistics.Controls.Grids.Column
	{
		// Token: 0x060012BA RID: 4794 RVA: 0x00045D92 File Offset: 0x00043F92
		public GroupColumn()
		{
			base.HeaderTextHorizontalAlignment = new global::System.Windows.HorizontalAlignment?(global::System.Windows.HorizontalAlignment.Center);
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x00045DA8 File Offset: 0x00043FA8
		protected internal override global::Infragistics.Controls.Grids.Column ResizeColumnResolved
		{
			get
			{
				global::Infragistics.Controls.Grids.Column result = this;
				if (this.Columns.Count > 0)
				{
					bool flag = false;
					if (this.Columns.Count > 0)
					{
						global::Infragistics.Controls.Grids.Column column = null;
						foreach (global::Infragistics.Controls.Grids.Column column2 in this.Columns)
						{
							if (column2.WidthResolved.WidthType == global::Infragistics.Controls.Grids.ColumnWidthType.Star)
							{
								flag = true;
							}
							if (column2.Visibility == global::System.Windows.Visibility.Visible && column2.IsResizable)
							{
								column = column2;
							}
						}
						if (!flag && column != null)
						{
							result = column.ResizeColumnResolved;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x00045E4C File Offset: 0x0004404C
		protected internal override bool RequiresBoundDataKey
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x00045E4F File Offset: 0x0004404F
		protected internal override bool IsEditable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x00045E52 File Offset: 0x00044052
		// (set) Token: 0x060012BF RID: 4799 RVA: 0x00045E55 File Offset: 0x00044055
		public override bool IsFilterable
		{
			get
			{
				return false;
			}
			set
			{
				base.IsFilterable = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x00045E5E File Offset: 0x0004405E
		// (set) Token: 0x060012C1 RID: 4801 RVA: 0x00045E61 File Offset: 0x00044061
		public override bool IsSortable
		{
			get
			{
				return false;
			}
			set
			{
				base.IsSortable = value;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x00045E6A File Offset: 0x0004406A
		// (set) Token: 0x060012C3 RID: 4803 RVA: 0x00045E6D File Offset: 0x0004406D
		public override bool IsSummable
		{
			get
			{
				return false;
			}
			set
			{
				base.IsSummable = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x00045E76 File Offset: 0x00044076
		// (set) Token: 0x060012C5 RID: 4805 RVA: 0x00045E79 File Offset: 0x00044079
		public override bool IsGroupable
		{
			get
			{
				return false;
			}
			set
			{
				base.IsGroupable = value;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x00045E82 File Offset: 0x00044082
		protected internal override bool CanBeGroupedBy
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00045E85 File Offset: 0x00044085
		protected internal override bool CanBeSorted
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x00045E88 File Offset: 0x00044088
		protected internal override bool CanBeFiltered
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x00045E8C File Offset: 0x0004408C
		protected override void OnColumnLayoutChanged()
		{
			base.OnColumnLayoutChanged();
			foreach (global::Infragistics.Controls.Grids.Column column in this.Columns)
			{
				column.ColumnLayout = base.ColumnLayout;
			}
			this.Columns.ColumnLayout = base.ColumnLayout;
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x00045EF8 File Offset: 0x000440F8
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return null;
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x00045EFB File Offset: 0x000440FB
		protected override global::Infragistics.Controls.Grids.CellBase GenerateDataCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			return new global::Infragistics.Controls.Grids.Primitives.GroupCell(row, this);
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x00045F04 File Offset: 0x00044104
		protected override global::Infragistics.Controls.Grids.CellBase GenerateHeaderCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			return new global::Infragistics.Controls.Grids.Primitives.GroupHeaderCell(row, this);
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00045F0D File Offset: 0x0004410D
		protected override global::Infragistics.Controls.Grids.CellBase GenerateFooterCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			return new global::Infragistics.Controls.Grids.Primitives.GroupFooterCell(row, this);
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00045F16 File Offset: 0x00044116
		protected internal override global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Grids.Column> ResolveChildColumns()
		{
			return this.Columns;
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x00045F20 File Offset: 0x00044120
		public override global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> AllColumns
		{
			get
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
				foreach (global::Infragistics.Controls.Grids.Column column in this.Columns)
				{
					list.Add(column);
					list.AddRange(column.AllColumns);
				}
				return new global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column>(list);
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x00045F88 File Offset: 0x00044188
		public override global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> AllVisibleChildColumns
		{
			get
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
				foreach (global::Infragistics.Controls.Grids.Column column in this.Columns)
				{
					if (column.Visibility == global::System.Windows.Visibility.Visible)
					{
						global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allVisibleChildColumns = column.AllVisibleChildColumns;
						if (allVisibleChildColumns.Count == 0)
						{
							list.Add(column);
						}
						else
						{
							list.AddRange(allVisibleChildColumns);
						}
					}
				}
				return new global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column>(list);
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x00046004 File Offset: 0x00044204
		protected internal override bool SupportsActivationAndSelection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x00046007 File Offset: 0x00044207
		public override global::System.Windows.Style HeaderStyleResolved
		{
			get
			{
				return base.HeaderStyle;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x0004600F File Offset: 0x0004420F
		public global::Infragistics.Controls.Grids.GroupColumnsCollection Columns
		{
			get
			{
				if (this._columns == null)
				{
					this._columns = new global::Infragistics.Controls.Grids.GroupColumnsCollection();
					this._columns.CollectionChanged += this.Columns_CollectionChanged;
				}
				return this._columns;
			}
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00046044 File Offset: 0x00044244
		private void Columns_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.NewItems != null)
			{
				foreach (object obj in e.NewItems)
				{
					global::Infragistics.Controls.Grids.Column column = (global::Infragistics.Controls.Grids.Column)obj;
					if (!column.IsMoving)
					{
						column.ColumnLayout = base.ColumnLayout;
						column.ParentColumn = this;
						column.PropertyChanged += this.Col_PropertyChanged;
					}
				}
			}
			if (e.OldItems != null)
			{
				bool flag = false;
				foreach (object obj2 in e.OldItems)
				{
					global::Infragistics.Controls.Grids.Column column2 = (global::Infragistics.Controls.Grids.Column)obj2;
					if (!column2.IsMoving)
					{
						column2.PropertyChanged -= this.Col_PropertyChanged;
						column2.ParentColumn = null;
						flag = true;
					}
				}
				if (flag && base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					base.ColumnLayout.Grid.ResetPanelRows(true);
				}
			}
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00046170 File Offset: 0x00044370
		private void Col_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnPropertyChanged(e.PropertyName);
		}

		// Token: 0x040005D8 RID: 1496
		private global::Infragistics.Controls.Grids.GroupColumnsCollection _columns;
	}
}
