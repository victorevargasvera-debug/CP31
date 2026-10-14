using System;
using System.Globalization;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000049 RID: 73
	public class EqualToConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.DiscreetRuleBaseProxy
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0000DCEE File Offset: 0x0000BEEE
		// (set) Token: 0x060002EC RID: 748 RVA: 0x0000DCF6 File Offset: 0x0000BEF6
		public object Value
		{
			get
			{
				return this._valueResolved;
			}
			set
			{
				if (this._valueResolved != value)
				{
					this._valueResolvedExecuted = false;
					this._valueResolved = value;
				}
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000DD10 File Offset: 0x0000BF10
		protected object ResolvedValue
		{
			get
			{
				if (this._valueResolvedExecuted)
				{
					return this._valueResolved;
				}
				object value = this.Value;
				if (base.Parent.Column != null)
				{
					if (value != null && value.GetType() == base.Parent.Column.DataType)
					{
						this._valueResolved = this.Value;
						this._valueResolvedExecuted = true;
					}
					try
					{
						this._valueResolved = base.Parent.Column.ResolveValue(value, global::System.Globalization.CultureInfo.InvariantCulture);
						this._valueResolvedExecuted = true;
						goto IL_85;
					}
					catch
					{
						goto IL_85;
					}
				}
				this._valueResolved = value;
				IL_85:
				return this._valueResolved;
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		protected override global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			object resolvedValue = this.ResolvedValue;
			if (sourceDataValue == resolvedValue)
			{
				return ((global::Infragistics.Controls.Grids.DiscreetRuleBase)base.Parent).StyleToApply;
			}
			if (sourceDataValue != null && sourceDataValue.Equals(resolvedValue))
			{
				return ((global::Infragistics.Controls.Grids.DiscreetRuleBase)base.Parent).StyleToApply;
			}
			return null;
		}

		// Token: 0x040000B9 RID: 185
		private object _valueResolved;

		// Token: 0x040000BA RID: 186
		private bool _valueResolvedExecuted;
	}
}
