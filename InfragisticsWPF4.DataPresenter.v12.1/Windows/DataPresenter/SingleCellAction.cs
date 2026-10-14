using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000065 RID: 101
	internal abstract class SingleCellAction : global::Infragistics.Windows.DataPresenter.DataRecordAction
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x00014647 File Offset: 0x00012847
		internal SingleCellAction(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field) : base(record)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
			this._field = field;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0001465D File Offset: 0x0001285D
		protected internal override bool CanPerform(object context)
		{
			return base.CanPerform(context) && base.Record.FieldLayout == this._field.Owner && global::Infragistics.Windows.DataPresenter.DataPresenterAction.IsValid(this._field);
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0001468F File Offset: 0x0001288F
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x04000190 RID: 400
		private global::Infragistics.Windows.DataPresenter.Field _field;
	}
}
