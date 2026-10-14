using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x0200002E RID: 46
	internal class ValueHolder : global::System.Windows.DependencyObject
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0000985B File Offset: 0x00007A5B
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00009868 File Offset: 0x00007A68
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

		// Token: 0x0400007A RID: 122
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Infragistics.ValueHolder), null);
	}
}
