using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace AcpASKLib
{
	// Token: 0x02000029 RID: 41
	public partial class IBtnAccessPasswordWnd : Window
	{
		// Token: 0x0600012F RID: 303 RVA: 0x00023524 File Offset: 0x00021724
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

		// Token: 0x06000130 RID: 304 RVA: 0x00023570 File Offset: 0x00021770
		private void b(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1117157177;
			short num2 = num;
			num = (short)1163491129;
			switch (num2 == num)
			{
			}
			num = (short)1896939521;
			if (num != 0)
			{
			}
			num = (short)985595904;
			if (num != 0)
			{
			}
			num = (short)1577713664;
			short num3 = num;
			base.DialogResult = new bool?(true);
			base.Close();
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0002362C File Offset: 0x0002182C
		private void a(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1342881930;
			short num2 = num;
			num = (short)469418122;
			switch (num2 == num)
			{
			}
			num = (short)719388673;
			if (num != 0)
			{
			}
			num = (short)443809792;
			if (num != 0)
			{
			}
			num = (short)196608;
			short num3 = num;
			base.DialogResult = new bool?(false);
			base.Close();
		}
	}
}
