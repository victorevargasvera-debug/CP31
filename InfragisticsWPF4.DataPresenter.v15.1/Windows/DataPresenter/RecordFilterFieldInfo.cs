using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000136 RID: 310
	public class RecordFilterFieldInfo : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x060012A2 RID: 4770 RVA: 0x00051DC3 File Offset: 0x0004FFC3
		public RecordFilterFieldInfo(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			this._field = field;
			this._recordManager = recordManager;
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x00051DD9 File Offset: 0x0004FFD9
		// (set) Token: 0x060012A4 RID: 4772 RVA: 0x00051DE1 File Offset: 0x0004FFE1
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
			internal set
			{
				if (value != this._field)
				{
					this._field = value;
					this.OnPropertyChanged("Field");
				}
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x00051DFE File Offset: 0x0004FFFE
		// (set) Token: 0x060012A6 RID: 4774 RVA: 0x00051E06 File Offset: 0x00050006
		public global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				return this._recordManager;
			}
			internal set
			{
				if (value != this._recordManager)
				{
					this._recordManager = value;
					this.OnPropertyChanged("RecordManager");
				}
			}
		}

		// Token: 0x0400077D RID: 1917
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x0400077E RID: 1918
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;
	}
}
