using System;
using System.Windows;
using System.Windows.Interactivity;

namespace Microsoft.Expression.Interactivity.Core
{
	// Token: 0x02000010 RID: 16
	public class PropertyChangedTrigger : global::System.Windows.Interactivity.TriggerBase<global::System.Windows.DependencyObject>
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00003A91 File Offset: 0x00001C91
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00003A9E File Offset: 0x00001C9E
		public object Binding
		{
			get
			{
				return base.GetValue(global::Microsoft.Expression.Interactivity.Core.PropertyChangedTrigger.BindingProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.PropertyChangedTrigger.BindingProperty, value);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003AAC File Offset: 0x00001CAC
		protected virtual void EvaluateBindingChange(object args)
		{
			base.InvokeActions(args);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003AB5 File Offset: 0x00001CB5
		protected override void OnAttached()
		{
			base.OnAttached();
			base.PreviewInvoke += this.OnPreviewInvoke;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003ACF File Offset: 0x00001CCF
		protected override void OnDetaching()
		{
			base.PreviewInvoke -= this.OnPreviewInvoke;
			this.OnDetaching();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003AE9 File Offset: 0x00001CE9
		private void OnPreviewInvoke(object sender, global::System.Windows.Interactivity.PreviewInvokeEventArgs e)
		{
			global::Microsoft.Expression.Interactivity.DataBindingHelper.EnsureDataBindingOnActionsUpToDate(this);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003AF4 File Offset: 0x00001CF4
		private static void OnBindingChanged(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Microsoft.Expression.Interactivity.Core.PropertyChangedTrigger propertyChangedTrigger = (global::Microsoft.Expression.Interactivity.Core.PropertyChangedTrigger)sender;
			propertyChangedTrigger.EvaluateBindingChange(args);
		}

		// Token: 0x04000023 RID: 35
		public static readonly global::System.Windows.DependencyProperty BindingProperty = global::System.Windows.DependencyProperty.Register("Binding", typeof(object), typeof(global::Microsoft.Expression.Interactivity.Core.PropertyChangedTrigger), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Core.PropertyChangedTrigger.OnBindingChanged)));
	}
}
