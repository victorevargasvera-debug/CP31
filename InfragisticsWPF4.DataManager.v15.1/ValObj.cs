using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000014 RID: 20
	internal class ValObj : global::System.Windows.FrameworkElement
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000072EC File Offset: 0x000054EC
		// (set) Token: 0x0600010D RID: 269 RVA: 0x000072FE File Offset: 0x000054FE
		public string Value
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.ValObj.ValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.ValObj.ValueProperty, value);
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000730C File Offset: 0x0000550C
		private static void ValueChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x0400004B RID: 75
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(string), typeof(global::Infragistics.ValObj), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.ValObj.ValueChanged)));
	}
}
