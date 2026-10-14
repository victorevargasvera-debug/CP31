using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000039 RID: 57
	internal static class EditUtilities
	{
		// Token: 0x06000277 RID: 631 RVA: 0x0000AA8D File Offset: 0x00008C8D
		internal static bool? GetIsInEditMode(global::System.Windows.DependencyObject d)
		{
			return (bool?)d.GetValue(global::Infragistics.EditUtilities.IsInEditModeProperty);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000AA9F File Offset: 0x00008C9F
		internal static void SetIsInEditMode(global::System.Windows.DependencyObject d, bool? value)
		{
			d.SetValue(global::Infragistics.EditUtilities.IsInEditModeProperty, value);
		}

		// Token: 0x040000BF RID: 191
		internal static readonly global::System.Windows.DependencyProperty IsInEditModeProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsInEditMode", typeof(bool?), typeof(global::Infragistics.EditUtilities), new global::System.Windows.PropertyMetadata(null));
	}
}
