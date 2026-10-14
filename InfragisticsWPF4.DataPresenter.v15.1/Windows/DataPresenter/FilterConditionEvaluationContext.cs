using System;
using System.Collections.Generic;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200015D RID: 349
	internal class FilterConditionEvaluationContext : global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase
	{
		// Token: 0x060014A5 RID: 5285 RVA: 0x0005BFD9 File Offset: 0x0005A1D9
		internal FilterConditionEvaluationContext(global::Infragistics.Windows.DataPresenter.Field field, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> allValuesRecords) : base(field, allValuesRecords)
		{
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x0005BFE3 File Offset: 0x0005A1E3
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

		// Token: 0x060014A7 RID: 5287 RVA: 0x0005C010 File Offset: 0x0005A210
		internal void Initialize(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this._record = record;
			this._currentValue = null;
			base.CurrentCellValueForFilterComparison = base.GetCellValueForFilterComparison(record);
		}

		// Token: 0x04000875 RID: 2165
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x04000876 RID: 2166
		private global::Infragistics.Windows.Controls.ValueEntry _currentValue;
	}
}
