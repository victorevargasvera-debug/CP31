using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x0200003D RID: 61
	internal class ValueHolder : global::System.Windows.DependencyObject
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000ADCB File Offset: 0x00008FCB
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0000ADD8 File Offset: 0x00008FD8
		public object Value
		{
			get
			{
				return base.GetValue(global::Infragistics.ValueHolder.ValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.ValueHolder.ValueProperty, value);
			}
		}

		// Token: 0x040000C6 RID: 198
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Infragistics.ValueHolder), null);
	}
}
