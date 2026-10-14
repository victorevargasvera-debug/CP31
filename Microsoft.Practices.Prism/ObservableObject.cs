using System;
using System.ComponentModel;
using System.Windows;

namespace Microsoft.Practices.Prism
{
	// Token: 0x02000048 RID: 72
	public class ObservableObject<T> : global::System.Windows.FrameworkElement, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060001CD RID: 461 RVA: 0x00006510 File Offset: 0x00004710
		// (remove) Token: 0x060001CE RID: 462 RVA: 0x00006548 File Offset: 0x00004748
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000657D File Offset: 0x0000477D
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x0000658F File Offset: 0x0000478F
		public T Value
		{
			get
			{
				return (T)((object)base.GetValue(global::Microsoft.Practices.Prism.ObservableObject<T>.ValueProperty));
			}
			set
			{
				base.SetValue(global::Microsoft.Practices.Prism.ObservableObject<T>.ValueProperty, value);
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000065A4 File Offset: 0x000047A4
		private static void ValueChangedCallback(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Practices.Prism.ObservableObject<T> observableObject = (global::Microsoft.Practices.Prism.ObservableObject<T>)d;
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = observableObject.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(observableObject, new global::System.ComponentModel.PropertyChangedEventArgs("Value"));
			}
		}

		// Token: 0x04000076 RID: 118
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(T), typeof(global::Microsoft.Practices.Prism.ObservableObject<T>), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Practices.Prism.ObservableObject<T>.ValueChangedCallback)));
	}
}
