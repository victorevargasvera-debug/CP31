using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x0200003A RID: 58
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class EmbeddedTextBox : global::System.Windows.Controls.TextBox
	{
		// Token: 0x0600027A RID: 634 RVA: 0x0000AAF7 File Offset: 0x00008CF7
		static EmbeddedTextBox()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Primitives.EmbeddedTextBox), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Primitives.EmbeddedTextBox)));
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000AB1C File Offset: 0x00008D1C
		public EmbeddedTextBox()
		{
			base.AddHandler(global::System.Windows.Input.CommandManager.CanExecuteEvent, new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.OnCanExecuteEvent), true);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000AB3C File Offset: 0x00008D3C
		private void OnCanExecuteEvent(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
		}
	}
}
