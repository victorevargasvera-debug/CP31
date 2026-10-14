using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002C9 RID: 713
	public class FieldPositionChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06002267 RID: 8807 RVA: 0x00097B0E File Offset: 0x00095D0E
		internal FieldPositionChangedEventArgs(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._field = field;
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x00097B1D File Offset: 0x00095D1D
		internal FieldPositionChangedEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason changeReason) : this(field)
		{
			this._changeReason = changeReason;
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06002269 RID: 8809 RVA: 0x00097B2D File Offset: 0x00095D2D
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x00097B35 File Offset: 0x00095D35
		public global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason ChangeReason
		{
			get
			{
				return this._changeReason;
			}
		}

		// Token: 0x0400111A RID: 4378
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x0400111B RID: 4379
		private global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason _changeReason;
	}
}
