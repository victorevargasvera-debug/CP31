using System;
using System.Windows.Data;

namespace System.Windows.Controls
{
	// Token: 0x02000008 RID: 8
	internal class BindingEvaluator<T> : global::System.Windows.FrameworkElement
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002D94 File Offset: 0x00000F94
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002DA6 File Offset: 0x00000FA6
		public T Value
		{
			get
			{
				return (T)((object)base.GetValue(global::System.Windows.Controls.BindingEvaluator<T>.ValueProperty));
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.BindingEvaluator<T>.ValueProperty, value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002DB9 File Offset: 0x00000FB9
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002DC1 File Offset: 0x00000FC1
		public global::System.Windows.Data.Binding ValueBinding
		{
			get
			{
				return this._binding;
			}
			set
			{
				this._binding = value;
				base.SetBinding(global::System.Windows.Controls.BindingEvaluator<T>.ValueProperty, this._binding);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002DDC File Offset: 0x00000FDC
		public BindingEvaluator()
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002DE4 File Offset: 0x00000FE4
		public BindingEvaluator(global::System.Windows.Data.Binding binding)
		{
			base.SetBinding(global::System.Windows.Controls.BindingEvaluator<T>.ValueProperty, binding);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002DF9 File Offset: 0x00000FF9
		public void ClearDataContext()
		{
			base.DataContext = null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002E04 File Offset: 0x00001004
		public T GetDynamicValue(object o, bool clearDataContext)
		{
			base.DataContext = o;
			T value = this.Value;
			if (clearDataContext)
			{
				base.DataContext = null;
			}
			return value;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002E2A File Offset: 0x0000102A
		public T GetDynamicValue(object o)
		{
			base.DataContext = o;
			return this.Value;
		}

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Data.Binding _binding;

		// Token: 0x04000014 RID: 20
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(T), typeof(global::System.Windows.Controls.BindingEvaluator<T>), new global::System.Windows.PropertyMetadata(default(T)));
	}
}
