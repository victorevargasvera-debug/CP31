using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace ASK.Core
{
	// Token: 0x0200001B RID: 27
	public partial class IBtnAccessPasswordWnd : Window
	{
		// Token: 0x06000130 RID: 304 RVA: 0x000242A4 File Offset: 0x000224A4
		public IBtnAccessPasswordWnd()
		{
			this.InitializeComponent();
			if (CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft)
			{
				base.FlowDirection = FlowDirection.RightToLeft;
			}
			else
			{
				base.FlowDirection = FlowDirection.LeftToRight;
			}
			this.b.Focus();
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000242F0 File Offset: 0x000224F0
		private void b(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)983433216;
			short num2 = num;
			num = (short)1401913647;
			short num3 = num;
			num = (short)1298956591;
			switch (num3 == num)
			{
			}
			num = (short)1404370944;
			if (num != 0)
			{
			}
			num = (short)658898945;
			if (num != 0)
			{
			}
			base.DialogResult = new bool?(true);
			base.Close();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000243AC File Offset: 0x000225AC
		private void a(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)779288576;
			short num2 = num;
			num = (short)1917179024;
			short num3 = num;
			num = (short)783930512;
			switch (num3 == num)
			{
			}
			num = (short)1644101632;
			if (num != 0)
			{
			}
			num = (short)537788417;
			if (num != 0)
			{
			}
			base.DialogResult = new bool?(false);
			base.Close();
		}
	}
}
