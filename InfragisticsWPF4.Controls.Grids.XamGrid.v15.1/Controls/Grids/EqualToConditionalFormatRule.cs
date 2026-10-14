using System;
using System.Globalization;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000048 RID: 72
	public class EqualToConditionalFormatRule : global::Infragistics.Controls.Grids.DiscreetRuleBase
	{
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000DBB0 File Offset: 0x0000BDB0
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x0000DBBD File Offset: 0x0000BDBD
		public object Value
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Grids.EqualToConditionalFormatRule.ValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EqualToConditionalFormatRule.ValueProperty, value);
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000DBCC File Offset: 0x0000BDCC
		private static void ValueChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.EqualToConditionalFormatRule equalToConditionalFormatRule = (global::Infragistics.Controls.Grids.EqualToConditionalFormatRule)obj;
			equalToConditionalFormatRule._valueResolvedExecuted = false;
			equalToConditionalFormatRule.OnPropertyChanged("Value");
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000DBF4 File Offset: 0x0000BDF4
		protected object ResolvedValue
		{
			get
			{
				if (this._valueResolvedExecuted)
				{
					return this._valueResolved;
				}
				object value = this.Value;
				if (base.Column != null)
				{
					if (value != null && value.GetType() == base.Column.DataType)
					{
						this._valueResolved = this.Value;
						this._valueResolvedExecuted = true;
					}
					try
					{
						this._valueResolved = base.Column.ResolveValue(value, global::System.Globalization.CultureInfo.InvariantCulture);
						this._valueResolvedExecuted = true;
						goto IL_76;
					}
					catch
					{
						goto IL_76;
					}
				}
				this._valueResolved = value;
				IL_76:
				return this._valueResolved;
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000DC90 File Offset: 0x0000BE90
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.EqualToConditionalFormatRuleProxy
			{
				Value = this.Value
			};
		}

		// Token: 0x040000B6 RID: 182
		private object _valueResolved;

		// Token: 0x040000B7 RID: 183
		private bool _valueResolvedExecuted;

		// Token: 0x040000B8 RID: 184
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Infragistics.Controls.Grids.EqualToConditionalFormatRule), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.EqualToConditionalFormatRule.ValueChanged)));
	}
}
