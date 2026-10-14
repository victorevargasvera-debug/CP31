using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x0200002B RID: 43
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class EmbeddedTextBox : global::System.Windows.Controls.TextBox
	{
		// Token: 0x06000202 RID: 514 RVA: 0x00009629 File Offset: 0x00007829
		static EmbeddedTextBox()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Primitives.EmbeddedTextBox), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Primitives.EmbeddedTextBox)));
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000964E File Offset: 0x0000784E
		public EmbeddedTextBox()
		{
			base.AddHandler(global::System.Windows.Input.CommandManager.CanExecuteEvent, new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.OnCanExecuteEvent), true);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000966E File Offset: 0x0000786E
		private void OnCanExecuteEvent(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			if (e.OriginalSource == this && !e.Handled)
			{
				e.CanExecute = true;
				e.ContinueRouting = true;
			}
		}
	}
}
