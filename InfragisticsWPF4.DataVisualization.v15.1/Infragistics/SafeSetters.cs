using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x020000B2 RID: 178
	public static class SafeSetters
	{
		// Token: 0x060007BE RID: 1982 RVA: 0x00024DB1 File Offset: 0x00022FB1
		public static void SetSetters(global::System.Windows.DependencyObject target, global::Infragistics.SafeSetterCollection setters)
		{
			target.SetValue(global::Infragistics.SafeSetters.SettersProperty, setters);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00024DBF File Offset: 0x00022FBF
		public static global::Infragistics.SafeSetterCollection GetSetters(global::System.Windows.DependencyObject target)
		{
			return (global::Infragistics.SafeSetterCollection)target.GetValue(global::Infragistics.SafeSetters.SettersProperty);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00024DD1 File Offset: 0x00022FD1
		private static void OnSettersChanged(global::System.Windows.DependencyObject o, global::Infragistics.SafeSetterCollection oldValue, global::Infragistics.SafeSetterCollection newValue)
		{
			if (newValue != null)
			{
				newValue.Apply(o);
			}
		}

		// Token: 0x040002CF RID: 719
		public static readonly global::System.Windows.DependencyProperty SettersProperty = global::System.Windows.DependencyProperty.RegisterAttached("Setters", typeof(global::Infragistics.SafeSetterCollection), typeof(global::Infragistics.SafeSetters), new global::System.Windows.PropertyMetadata(null, delegate(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.SafeSetters.OnSettersChanged(o, e.OldValue as global::Infragistics.SafeSetterCollection, e.NewValue as global::Infragistics.SafeSetterCollection);
		}));
	}
}
