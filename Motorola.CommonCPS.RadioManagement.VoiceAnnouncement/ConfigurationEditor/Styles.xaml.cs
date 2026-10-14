using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.ConfigurationEditor
{
	// Token: 0x02000009 RID: 9
	public partial class Styles
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002DD4 File Offset: 0x00000FD4
		private void c(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1700921344;
			short num2 = num;
			num = (short)954510928;
			short num3 = num;
			num = (short)163360336;
			switch (num3 == num)
			{
			}
			num = (short)726859777;
			if (num != 0)
			{
			}
			num = (short)1215037440;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002E84 File Offset: 0x00001084
		private void b(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)197656576;
			short num2 = num;
			num = (short)1249086917;
			short num3 = num;
			num = (short)2049740229;
			switch (num3 == num)
			{
			}
			num = (short)1565851648;
			if (num != 0)
			{
			}
			num = (short)1926103041;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002F38 File Offset: 0x00001138
		private void a(object A_0)
		{
			short num = (short)420085760;
			short num2 = num;
			num = (short)2039487111;
			short num3 = num;
			num = (short)1391729287;
			switch (num3 == num)
			{
			}
			num = (short)1186725889;
			if (num != 0)
			{
			}
			num = (short)239271936;
			if (num != 0)
			{
			}
			ContextMenu contextMenu = (ContextMenu)A_0;
			contextMenu.DataContext = this.a<UserControl>(contextMenu.PlacementTarget).DataContext;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003000 File Offset: 0x00001200
		private void a(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)2090991616;
			short num2 = num;
			num = (short)1375620220;
			short num3 = num;
			num = (short)1444170876;
			switch (num3 == num)
			{
			}
			num = (short)172490752;
			if (num != 0)
			{
			}
			num = (short)1606942721;
			if (num != 0)
			{
			}
			RMLinkButton rmlinkButton = (RMLinkButton)A_0;
			ContextMenu contextMenu = rmlinkButton.ContextMenu;
			contextMenu.PlacementTarget = rmlinkButton;
			contextMenu.Visibility = Visibility.Visible;
			contextMenu.IsOpen = true;
			this.a<ListBoxItem>(rmlinkButton).IsSelected = true;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000030D4 File Offset: 0x000012D4
		private void b(object A_0, MouseButtonEventArgs A_1)
		{
			short num = (short)771489792;
			short num2 = num;
			num = (short)1472869701;
			short num3 = num;
			num = (short)1413821765;
			switch (num3 == num)
			{
			}
			num = (short)297795584;
			if (num != 0)
			{
			}
			num = (short)1771700225;
			if (num != 0)
			{
			}
			A_1.Handled = true;
			((RMLinkButton)A_0).ContextMenu.Visibility = Visibility.Collapsed;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003198 File Offset: 0x00001398
		private void a(object A_0, MouseButtonEventArgs A_1)
		{
			short num = (short)1167982592;
			short num2 = num;
			num = (short)559066449;
			short num3 = num;
			num = (short)1552657745;
			switch (num3 == num)
			{
			}
			num = (short)339869697;
			if (num != 0)
			{
			}
			num = (short)1080885248;
			if (num != 0)
			{
			}
			ContextMenu contextMenu = ((TextBlock)A_0).ContextMenu;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000324C File Offset: 0x0000144C
		private a a<a>(DependencyObject A_0) where a : FrameworkElement
		{
			DependencyObject parent = VisualTreeHelper.GetParent(A_0);
			a a = parent as a;
			if (a != null)
			{
				short num = (short)1694564353;
				if (num != 0)
				{
				}
				num = (short)1461101520;
				short num2 = num;
				num = (short)1423025104;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2048786432;
					if (num != 0)
					{
					}
					num = (short)1655439360;
					short num3 = num;
					return a;
				}
				}
			}
			return this.a<a>(parent);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003330 File Offset: 0x00001530
		internal static string d(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((IntPtr)(1045031533 + A_1) + (IntPtr)95 + (IntPtr)33 + (IntPtr)73 + (IntPtr)17 + (IntPtr)31);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}
	}
}
