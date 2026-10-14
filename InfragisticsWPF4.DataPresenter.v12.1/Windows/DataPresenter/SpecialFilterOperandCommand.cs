using System;
using System.ComponentModel;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200011C RID: 284
	public class SpecialFilterOperandCommand : global::Infragistics.Windows.DataPresenter.RecordFilterCommandBase
	{
		// Token: 0x06000F52 RID: 3922 RVA: 0x000415E8 File Offset: 0x0003F7E8
		protected override global::Infragistics.Windows.Controls.ICondition GetCondition(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			global::Infragistics.Windows.Controls.SpecialFilterOperandBase registeredOperand = global::Infragistics.Windows.Controls.SpecialFilterOperands.GetRegisteredOperand(this._operandName);
			return new global::Infragistics.Windows.Controls.ComparisonCondition(this.ComparisonOperator, registeredOperand);
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x0004160D File Offset: 0x0003F80D
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x00041615 File Offset: 0x0003F815
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

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x0004162A File Offset: 0x0003F82A
		// (set) Token: 0x06000F56 RID: 3926 RVA: 0x00041632 File Offset: 0x0003F832
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

		// Token: 0x040005DE RID: 1502
		internal const global::Infragistics.Windows.Controls.ComparisonOperator DefaultOperator = global::Infragistics.Windows.Controls.ComparisonOperator.Equals;

		// Token: 0x040005DF RID: 1503
		private string _operandName;

		// Token: 0x040005E0 RID: 1504
		private global::Infragistics.Windows.Controls.ComparisonOperator _operator;
	}
}
