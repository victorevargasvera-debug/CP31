using System;
using System.Windows;

namespace Microsoft.Expression.Interactivity.Core
{
	// Token: 0x02000012 RID: 18
	public class DataTrigger : global::Microsoft.Expression.Interactivity.Core.PropertyChangedTrigger
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00003B5A File Offset: 0x00001D5A
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00003B67 File Offset: 0x00001D67
		public object Value
		{
			get
			{
				return base.GetValue(global::Microsoft.Expression.Interactivity.Core.DataTrigger.ValueProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.DataTrigger.ValueProperty, value);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00003B75 File Offset: 0x00001D75
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00003B87 File Offset: 0x00001D87
		public global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType Comparison
		{
			get
			{
				return (global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType)base.GetValue(global::Microsoft.Expression.Interactivity.Core.DataTrigger.ComparisonProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.DataTrigger.ComparisonProperty, value);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003BA2 File Offset: 0x00001DA2
		protected override void EvaluateBindingChange(object args)
		{
			if (this.Compare())
			{
				base.InvokeActions(args);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003BB4 File Offset: 0x00001DB4
		private static void OnValueChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Microsoft.Expression.Interactivity.Core.DataTrigger dataTrigger = (global::Microsoft.Expression.Interactivity.Core.DataTrigger)sender;
			dataTrigger.EvaluateBindingChange(args);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003BD4 File Offset: 0x00001DD4
		private static void OnComparisonChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Microsoft.Expression.Interactivity.Core.DataTrigger dataTrigger = (global::Microsoft.Expression.Interactivity.Core.DataTrigger)sender;
			dataTrigger.EvaluateBindingChange(args);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003BF4 File Offset: 0x00001DF4
		private bool Compare()
		{
			return base.AssociatedObject != null && global::Microsoft.Expression.Interactivity.ComparisonLogic.EvaluateImpl(base.Binding, this.Comparison, this.Value);
		}

		// Token: 0x04000024 RID: 36
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Microsoft.Expression.Interactivity.Core.DataTrigger), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Core.DataTrigger.OnValueChanged)));

		// Token: 0x04000025 RID: 37
		public static readonly global::System.Windows.DependencyProperty ComparisonProperty = global::System.Windows.DependencyProperty.Register("Comparison", typeof(global::Microsoft.Expression.Interactivity.Core.ComparisonConditionType), typeof(global::Microsoft.Expression.Interactivity.Core.DataTrigger), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Core.DataTrigger.OnComparisonChanged)));
	}
}
