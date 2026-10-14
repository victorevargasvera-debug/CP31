using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200003A RID: 58
	public abstract class StringConditionalFormatRule : global::Infragistics.Controls.Grids.DiscreetRuleBase
	{
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000C6D3 File Offset: 0x0000A8D3
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0000C6E5 File Offset: 0x0000A8E5
		public string Value
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.StringConditionalFormatRule.ValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.StringConditionalFormatRule.ValueProperty, value);
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000C6F4 File Offset: 0x0000A8F4
		private static void ValueChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.StringConditionalFormatRule stringConditionalFormatRule = (global::Infragistics.Controls.Grids.StringConditionalFormatRule)obj;
			stringConditionalFormatRule.OnPropertyChanged("Value");
		}

		// Token: 0x040000A6 RID: 166
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(string), typeof(global::Infragistics.Controls.Grids.StringConditionalFormatRule), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.StringConditionalFormatRule.ValueChanged)));
	}
}
