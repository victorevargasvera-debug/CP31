using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200011A RID: 282
	public class RecordFilterFieldInfo : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06000F3C RID: 3900 RVA: 0x000411A7 File Offset: 0x0003F3A7
		public RecordFilterFieldInfo(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			this._field = field;
			this._recordManager = recordManager;
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x000411BD File Offset: 0x0003F3BD
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x000411C5 File Offset: 0x0003F3C5
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

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x000411E2 File Offset: 0x0003F3E2
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x000411EA File Offset: 0x0003F3EA
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

		// Token: 0x040005DB RID: 1499
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x040005DC RID: 1500
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;
	}
}
