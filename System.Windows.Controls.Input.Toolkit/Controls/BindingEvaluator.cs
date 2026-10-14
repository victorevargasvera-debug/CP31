using System;
using System.Windows.Data;

namespace System.Windows.Controls
{
	// Token: 0x0200000A RID: 10
	internal class BindingEvaluator<T> : global::System.Windows.FrameworkElement
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005B RID: 91 RVA: 0x0000350C File Offset: 0x0000170C
		// (set) Token: 0x0600005C RID: 92 RVA: 0x0000351E File Offset: 0x0000171E
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

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00003531 File Offset: 0x00001731
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00003539 File Offset: 0x00001739
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

		// Token: 0x0600005F RID: 95 RVA: 0x00003554 File Offset: 0x00001754
		public BindingEvaluator()
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000355C File Offset: 0x0000175C
		public BindingEvaluator(global::System.Windows.Data.Binding binding)
		{
			base.SetBinding(global::System.Windows.Controls.BindingEvaluator<T>.ValueProperty, binding);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003571 File Offset: 0x00001771
		public void ClearDataContext()
		{
			base.DataContext = null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000357C File Offset: 0x0000177C
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

		// Token: 0x06000063 RID: 99 RVA: 0x000035A2 File Offset: 0x000017A2
		public T GetDynamicValue(object o)
		{
			base.DataContext = o;
			return this.Value;
		}

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Data.Binding _binding;

		// Token: 0x04000016 RID: 22
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(T), typeof(global::System.Windows.Controls.BindingEvaluator<T>), new global::System.Windows.PropertyMetadata(default(T)));
	}
}
