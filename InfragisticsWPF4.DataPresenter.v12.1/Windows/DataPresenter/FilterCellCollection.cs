using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000116 RID: 278
	public class FilterCellCollection : global::Infragistics.Windows.DataPresenter.CellCollection
	{
		// Token: 0x06000EBB RID: 3771 RVA: 0x0003F287 File Offset: 0x0003D487
		internal FilterCellCollection(global::Infragistics.Windows.DataPresenter.FilterRecord record) : base(record)
		{
		}

		// Token: 0x17000331 RID: 817
		public global::Infragistics.Windows.DataPresenter.FilterCell this[int index]
		{
			get
			{
				return base[index] as global::Infragistics.Windows.DataPresenter.FilterCell;
			}
		}

		// Token: 0x17000332 RID: 818
		public global::Infragistics.Windows.DataPresenter.FilterCell this[global::Infragistics.Windows.DataPresenter.Field field]
		{
			get
			{
				return base[field] as global::Infragistics.Windows.DataPresenter.FilterCell;
			}
		}

		// Token: 0x17000333 RID: 819
		public global::Infragistics.Windows.DataPresenter.FilterCell this[string fieldName]
		{
			get
			{
				return base[fieldName] as global::Infragistics.Windows.DataPresenter.FilterCell;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x0003F2BA File Offset: 0x0003D4BA
		public new global::Infragistics.Windows.DataPresenter.FilterRecord Record
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FilterRecord)base.Record;
			}
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x0003F2C7 File Offset: 0x0003D4C7
		internal override global::Infragistics.Windows.DataPresenter.Cell CreateCell(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return new global::Infragistics.Windows.DataPresenter.FilterCell(this.Record, field);
		}
	}
}
