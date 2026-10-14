using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using AcpUI.Common;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.FileOperations
{
	// Token: 0x02000117 RID: 279
	public partial class MessageWindow : Window
	{
		// Token: 0x06000F36 RID: 3894 RVA: 0x000033E0 File Offset: 0x000015E0
		public MessageWindow()
		{
			this.InitializeComponent();
			Utility.SetDirection(this);
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x000033F4 File Offset: 0x000015F4
		public MessageWindow(string messageText)
		{
			this.InitializeComponent();
			this.ProgText.Text = messageText;
			Utility.SetDirection(this);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00003414 File Offset: 0x00001614
		internal MessageWindow(string messageText, string title)
		{
			this.InitializeComponent();
			this.ProgText.Text = messageText;
			this.operationLabel.Content = title;
			Utility.SetDirection(this);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00150E60 File Offset: 0x0014F060
		private void Window_MouseLeftButtonDown(object A_0, MouseButtonEventArgs A_1)
		{
			short num = (short)230293505;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				num = (short)2106585755;
				short num3 = num;
				num = (short)373879451;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2023948289;
					if (num != 0)
					{
					}
					num = (short)837484544;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						base.OnMouseLeftButtonDown(A_1);
						base.DragMove();
						goto IL_FB;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					case 2:
						return;
					}
					IL_A3:
					if (A_1.ChangedButton == MouseButton.Left)
					{
						num = (short)2108424192;
						short num4 = num;
						num = (short)579403776;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				}
				IL_FB:
				num = (short)177668098;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00150F84 File Offset: 0x0014F184
		private void ObButtonClick_Close(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1167622482;
			short num2 = num;
			num = (short)1357742418;
			switch (num2 == num)
			{
			}
			num = (short)1902247937;
			if (num != 0)
			{
			}
			num = (short)1280901120;
			if (num != 0)
			{
			}
			num = (short)367394816;
			short num3 = num;
		}
	}
}
