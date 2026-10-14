using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Interactivity;

namespace Microsoft.Expression.Interactivity.Core
{
	// Token: 0x02000021 RID: 33
	public class LaunchUriOrFileAction : global::System.Windows.Interactivity.TriggerAction<global::System.Windows.DependencyObject>
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00007A41 File Offset: 0x00005C41
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00007A53 File Offset: 0x00005C53
		public string Path
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Expression.Interactivity.Core.LaunchUriOrFileAction.PathProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.LaunchUriOrFileAction.PathProperty, value);
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00007A61 File Offset: 0x00005C61
		protected override void Invoke(object parameter)
		{
			if (base.AssociatedObject != null && !string.IsNullOrEmpty(this.Path))
			{
				global::System.Diagnostics.Process.Start(this.Path);
			}
		}

		// Token: 0x0400006A RID: 106
		public static readonly global::System.Windows.DependencyProperty PathProperty = global::System.Windows.DependencyProperty.Register("Path", typeof(string), typeof(global::Microsoft.Expression.Interactivity.Core.LaunchUriOrFileAction));
	}
}
