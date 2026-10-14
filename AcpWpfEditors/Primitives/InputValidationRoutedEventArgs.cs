using System;
using System.Windows;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000065 RID: 101
	public class InputValidationRoutedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060006B7 RID: 1719 RVA: 0x0008BBB8 File Offset: 0x00089DB8
		public InputValidationRoutedEventArgs(string input)
		{
			this.Input = input;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0008BBE4 File Offset: 0x00089DE4
		public InputValidationRoutedEventArgs(global::System.Windows.RoutedEvent e, string input) : base(e)
		{
			this.Input = input;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0008BC14 File Offset: 0x00089E14
		public InputValidationRoutedEventArgs(global::System.Windows.RoutedEvent e, object source, string input) : base(e, source)
		{
			this.Input = input;
		}

		// Token: 0x040002D5 RID: 725
		public readonly string Input = "";

		// Token: 0x040002D6 RID: 726
		public bool AcceptInput = true;
	}
}
