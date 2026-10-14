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

namespace SpecialFeatures.DepotLabtool
{
	// Token: 0x02000140 RID: 320
	public partial class MessageWindow : Window
	{
		// Token: 0x0600108D RID: 4237 RVA: 0x0000356E File Offset: 0x0000176E
		public MessageWindow()
		{
			this.InitializeComponent();
			Utility.SetDirection(this);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00003582 File Offset: 0x00001782
		public MessageWindow(string messageText)
		{
			this.InitializeComponent();
			this.ProgText.Text = messageText;
			Utility.SetDirection(this);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x000035A2 File Offset: 0x000017A2
		public MessageWindow(string messageText, string title)
		{
			this.InitializeComponent();
			this.ProgText.Text = messageText;
			this.operationLabel.Content = title;
			Utility.SetDirection(this);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x001721BC File Offset: 0x001703BC
		private void Window_MouseLeftButtonDown(object A_0, MouseButtonEventArgs A_1)
		{
			short num = (short)1220935681;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C5;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					return;
				}
				IL_30:
				if (A_1.ChangedButton != MouseButton.Left)
				{
					break;
				}
				num = (short)1873345751;
				short num3 = num;
				num = (short)134675671;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1431699456;
					if (num != 0)
					{
					}
					num = (short)1764229121;
					if (num != 0)
					{
					}
					num = (short)1946157056;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_C5:
				num = (short)1871511552;
				short num4 = num;
				base.OnMouseLeftButtonDown(A_1);
				base.DragMove();
				num = (short)1581907970;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x001722E0 File Offset: 0x001704E0
		private void ObButtonClick_Close(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)573584940;
			short num2 = num;
			num = (short)1752970796;
			switch (num2 == num)
			{
			}
			num = (short)162201600;
			if (num != 0)
			{
			}
			num = (short)1223426048;
			short num3 = num;
			num = (short)114229249;
			if (num != 0)
			{
			}
		}
	}
}
