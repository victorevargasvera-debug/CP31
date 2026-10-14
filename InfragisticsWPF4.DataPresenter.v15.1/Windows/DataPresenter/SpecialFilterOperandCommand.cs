using System;
using System.ComponentModel;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000138 RID: 312
	public class SpecialFilterOperandCommand : global::Infragistics.Windows.DataPresenter.RecordFilterCommandBase
	{
		// Token: 0x060012B8 RID: 4792 RVA: 0x00052204 File Offset: 0x00050404
		protected override global::Infragistics.Windows.Controls.ICondition GetCondition(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			global::Infragistics.Windows.Controls.SpecialFilterOperandBase registeredOperand = global::Infragistics.Windows.Controls.SpecialFilterOperands.GetRegisteredOperand(this._operandName);
			return new global::Infragistics.Windows.Controls.ComparisonCondition(this.ComparisonOperator, registeredOperand);
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x00052229 File Offset: 0x00050429
		// (set) Token: 0x060012BA RID: 4794 RVA: 0x00052231 File Offset: 0x00050431
		public global::Infragistics.Windows.Controls.ComparisonOperator ComparisonOperator
		{
			get
			{
				return this._operator;
			}
			set
			{
				base.SetField<global::Infragistics.Windows.Controls.ComparisonOperator>(ref this._operator, value, "ComparisonOperator");
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x00052246 File Offset: 0x00050446
		// (set) Token: 0x060012BC RID: 4796 RVA: 0x0005224E File Offset: 0x0005044E
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperandTypeConverter))]
		public string OperandName
		{
			get
			{
				return this._operandName;
			}
			set
			{
				base.SetField<string>(ref this._operandName, value, "OperandName");
			}
		}

		// Token: 0x04000780 RID: 1920
		internal const global::Infragistics.Windows.Controls.ComparisonOperator DefaultOperator = global::Infragistics.Windows.Controls.ComparisonOperator.Equals;

		// Token: 0x04000781 RID: 1921
		private string _operandName;

		// Token: 0x04000782 RID: 1922
		private global::Infragistics.Windows.Controls.ComparisonOperator _operator;
	}
}
