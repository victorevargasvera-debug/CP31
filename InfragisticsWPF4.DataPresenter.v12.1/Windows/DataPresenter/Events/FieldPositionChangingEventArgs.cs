using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000285 RID: 645
	public class FieldPositionChangingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001DDB RID: 7643 RVA: 0x0008134E File Offset: 0x0007F54E
		internal FieldPositionChangingEventArgs(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._field = field;
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x0008135D File Offset: 0x0007F55D
		internal FieldPositionChangingEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason changeReason) : this(field)
		{
			this._changeReason = changeReason;
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x0008136D File Offset: 0x0007F56D
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x00081375 File Offset: 0x0007F575
		public global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason ChangeReason
		{
			get
			{
				return this._changeReason;
			}
		}

		// Token: 0x04000EAE RID: 3758
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000EAF RID: 3759
		private global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason _changeReason;
	}
}
