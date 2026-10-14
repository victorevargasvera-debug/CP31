using System;
using System.Windows;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001B0 RID: 432
	internal class ModalWindowHelper : global::System.Windows.DependencyObject
	{
		// Token: 0x06000E7B RID: 3707 RVA: 0x0002E6E1 File Offset: 0x0002C8E1
		public static int GetModalDialogWindowCount(global::System.Windows.DependencyObject d)
		{
			return (int)d.GetValue(global::Infragistics.Windows.Internal.ModalWindowHelper.ModalDialogWindowCountProperty);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x0002E6F3 File Offset: 0x0002C8F3
		public static void SetModalDialogWindowCount(global::System.Windows.DependencyObject d, int value)
		{
			d.SetValue(global::Infragistics.Windows.Internal.ModalWindowHelper.ModalDialogWindowCountProperty, value);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0002E706 File Offset: 0x0002C906
		public static bool GetIsDisabledByModalDialog(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Internal.ModalWindowHelper.IsDisabledByModalDialogProperty);
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x0002E718 File Offset: 0x0002C918
		public static void SetIsDisabledByModalDialog(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.Internal.ModalWindowHelper.IsDisabledByModalDialogProperty, value);
		}

		// Token: 0x040007F4 RID: 2036
		public static readonly global::System.Windows.DependencyProperty ModalDialogWindowCountProperty = global::System.Windows.DependencyProperty.RegisterAttached("ModalDialogWindowCount", typeof(int), typeof(global::Infragistics.Windows.Internal.ModalWindowHelper), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x040007F5 RID: 2037
		public static readonly global::System.Windows.DependencyProperty IsDisabledByModalDialogProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsDisabledByModalDialog", typeof(bool), typeof(global::Infragistics.Windows.Internal.ModalWindowHelper), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));
	}
}
