using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000286 RID: 646
	public class FieldPositionChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001DDF RID: 7647 RVA: 0x0008137D File Offset: 0x0007F57D
		internal FieldPositionChangedEventArgs(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._field = field;
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x0008138C File Offset: 0x0007F58C
		internal FieldPositionChangedEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason changeReason) : this(field)
		{
			this._changeReason = changeReason;
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x0008139C File Offset: 0x0007F59C
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x000813A4 File Offset: 0x0007F5A4
		public global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason ChangeReason
		{
			get
			{
				return this._changeReason;
			}
		}

		// Token: 0x04000EB0 RID: 3760
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000EB1 RID: 3761
		private global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason _changeReason;
	}
}
