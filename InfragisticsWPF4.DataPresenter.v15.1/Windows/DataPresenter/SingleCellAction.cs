using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200006A RID: 106
	internal abstract class SingleCellAction : global::Infragistics.Windows.DataPresenter.DataRecordAction
	{
		// Token: 0x06000604 RID: 1540 RVA: 0x00016A17 File Offset: 0x00014C17
		internal SingleCellAction(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field) : base(record)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
			this._field = field;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00016A2D File Offset: 0x00014C2D
		protected internal override bool CanPerform(object context)
		{
			return base.CanPerform(context) && base.Record.FieldLayout == this._field.Owner && global::Infragistics.Windows.DataPresenter.DataPresenterAction.IsValid(this._field);
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x00016A5F File Offset: 0x00014C5F
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x040001C8 RID: 456
		private global::Infragistics.Windows.DataPresenter.Field _field;
	}
}
