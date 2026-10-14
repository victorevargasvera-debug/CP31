using System;
using System.Windows;

namespace Infragistics.Windows.Internal
{
	// Token: 0x0200018B RID: 395
	internal class ModalWindowHelper : global::System.Windows.DependencyObject
	{
		// Token: 0x06000D30 RID: 3376 RVA: 0x00029FE0 File Offset: 0x000281E0
		public static int GetModalDialogWindowCount(global::System.Windows.DependencyObject d)
		{
			return (int)d.GetValue(global::Infragistics.Windows.Internal.ModalWindowHelper.ModalDialogWindowCountProperty);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00029FF2 File Offset: 0x000281F2
		public static void SetModalDialogWindowCount(global::System.Windows.DependencyObject d, int value)
		{
			d.SetValue(global::Infragistics.Windows.Internal.ModalWindowHelper.ModalDialogWindowCountProperty, value);
		}

		// Token: 0x040006CE RID: 1742
		public static readonly global::System.Windows.DependencyProperty ModalDialogWindowCountProperty = global::System.Windows.DependencyProperty.RegisterAttached("ModalDialogWindowCount", typeof(int), typeof(global::Infragistics.Windows.Internal.ModalWindowHelper), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));
	}
}
