using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000132 RID: 306
	public class FilterCellCollection : global::Infragistics.Windows.DataPresenter.CellCollection
	{
		// Token: 0x0600121C RID: 4636 RVA: 0x0004FD8B File Offset: 0x0004DF8B
		internal FilterCellCollection(global::Infragistics.Windows.DataPresenter.FilterRecord record) : base(record)
		{
		}

		// Token: 0x17000470 RID: 1136
		public global::Infragistics.Windows.DataPresenter.FilterCell this[int index]
		{
			get
			{
				return base[index] as global::Infragistics.Windows.DataPresenter.FilterCell;
			}
		}

		// Token: 0x17000471 RID: 1137
		public global::Infragistics.Windows.DataPresenter.FilterCell this[global::Infragistics.Windows.DataPresenter.Field field]
		{
			get
			{
				return base[field] as global::Infragistics.Windows.DataPresenter.FilterCell;
			}
		}

		// Token: 0x17000472 RID: 1138
		public global::Infragistics.Windows.DataPresenter.FilterCell this[string fieldName]
		{
			get
			{
				return base[fieldName] as global::Infragistics.Windows.DataPresenter.FilterCell;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x0004FDBE File Offset: 0x0004DFBE
		public new global::Infragistics.Windows.DataPresenter.FilterRecord Record
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FilterRecord)base.Record;
			}
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x0004FDCB File Offset: 0x0004DFCB
		internal override global::Infragistics.Windows.DataPresenter.Cell CreateCell(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return new global::Infragistics.Windows.DataPresenter.FilterCell(this.Record, field);
		}
	}
}
