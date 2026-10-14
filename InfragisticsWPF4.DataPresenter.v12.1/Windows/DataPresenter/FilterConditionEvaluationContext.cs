using System;
using System.Collections.Generic;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000141 RID: 321
	internal class FilterConditionEvaluationContext : global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase
	{
		// Token: 0x0600113B RID: 4411 RVA: 0x0004AB59 File Offset: 0x00048D59
		internal FilterConditionEvaluationContext(global::Infragistics.Windows.DataPresenter.Field field, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> allValuesRecords) : base(field, allValuesRecords)
		{
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x0004AB63 File Offset: 0x00048D63
		public override global::Infragistics.Windows.Controls.ValueEntry CurrentValue
		{
			get
			{
				if (this._currentValue == null)
				{
					this._currentValue = new global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.FilterValueEntry(base.Field, this._record, base.CurrentCellValueForFilterComparison);
				}
				return this._currentValue;
			}
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x0004AB90 File Offset: 0x00048D90
		internal void Initialize(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this._record = record;
			this._currentValue = null;
			base.CurrentCellValueForFilterComparison = base.GetCellValueForFilterComparison(record);
		}

		// Token: 0x040006CD RID: 1741
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x040006CE RID: 1742
		private global::Infragistics.Windows.Controls.ValueEntry _currentValue;
	}
}
