using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002C8 RID: 712
	public class FieldPositionChangingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06002263 RID: 8803 RVA: 0x00097ADF File Offset: 0x00095CDF
		internal FieldPositionChangingEventArgs(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._field = field;
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x00097AEE File Offset: 0x00095CEE
		internal FieldPositionChangingEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason changeReason) : this(field)
		{
			this._changeReason = changeReason;
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06002265 RID: 8805 RVA: 0x00097AFE File Offset: 0x00095CFE
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x00097B06 File Offset: 0x00095D06
		public global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason ChangeReason
		{
			get
			{
				return this._changeReason;
			}
		}

		// Token: 0x04001118 RID: 4376
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04001119 RID: 4377
		private global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason _changeReason;
	}
}
