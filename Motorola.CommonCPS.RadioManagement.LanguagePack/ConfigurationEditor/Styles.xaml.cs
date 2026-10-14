using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.ConfigurationEditor
{
	// Token: 0x0200000B RID: 11
	public partial class Styles
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00005188 File Offset: 0x00003388
		private void c(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1274011791;
			short num2 = num;
			num = (short)1878384783;
			switch (num2 == num)
			{
			}
			num = (short)406257665;
			if (num != 0)
			{
			}
			num = (short)2124677120;
			if (num != 0)
			{
			}
			num = (short)1514012672;
			short num3 = num;
			this.a(A_0);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005234 File Offset: 0x00003434
		private void b(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)890065135;
			short num2 = num;
			num = (short)828920047;
			switch (num2 == num)
			{
			}
			num = (short)441647105;
			if (num != 0)
			{
			}
			num = (short)1941766144;
			if (num != 0)
			{
			}
			num = (short)542507008;
			short num3 = num;
			this.a(A_0);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000052E4 File Offset: 0x000034E4
		private void a(object A_0)
		{
			short num = (short)933783305;
			short num2 = num;
			num = (short)1599432457;
			switch (num2 == num)
			{
			}
			num = (short)1562443777;
			if (num != 0)
			{
			}
			num = (short)1214775296;
			if (num != 0)
			{
			}
			num = (short)1142947840;
			short num3 = num;
			ContextMenu contextMenu = (ContextMenu)A_0;
			contextMenu.DataContext = this.a<UserControl>(contextMenu.PlacementTarget).DataContext;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000053AC File Offset: 0x000035AC
		private void a(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1695148887;
			short num2 = num;
			num = (short)1165683543;
			switch (num2 == num)
			{
			}
			num = (short)1057619969;
			if (num != 0)
			{
			}
			num = (short)1632436224;
			if (num != 0)
			{
			}
			num = (short)793116672;
			short num3 = num;
			RMLinkButton rmlinkButton = (RMLinkButton)A_0;
			ContextMenu contextMenu = rmlinkButton.ContextMenu;
			contextMenu.PlacementTarget = rmlinkButton;
			contextMenu.Visibility = Visibility.Visible;
			contextMenu.IsOpen = true;
			this.a<ListBoxItem>(rmlinkButton).IsSelected = true;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005484 File Offset: 0x00003684
		private void b(object A_0, MouseButtonEventArgs A_1)
		{
			short num = (short)1057048245;
			short num2 = num;
			num = (short)1677084341;
			switch (num2 == num)
			{
			}
			num = (short)801177601;
			if (num != 0)
			{
			}
			num = (short)2098724864;
			if (num != 0)
			{
			}
			num = (short)1910505472;
			short num3 = num;
			A_1.Handled = true;
			((RMLinkButton)A_0).ContextMenu.Visibility = Visibility.Collapsed;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005548 File Offset: 0x00003748
		private void a(object A_0, MouseButtonEventArgs A_1)
		{
			short num = (short)1742937164;
			short num2 = num;
			num = (short)551361612;
			switch (num2 == num)
			{
			}
			num = (short)1512243200;
			if (num != 0)
			{
			}
			num = (short)2038628353;
			if (num != 0)
			{
			}
			num = (short)1071841280;
			short num3 = num;
			ContextMenu contextMenu = ((TextBlock)A_0).ContextMenu;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000055FC File Offset: 0x000037FC
		private a a<a>(DependencyObject A_0) where a : FrameworkElement
		{
			DependencyObject parent;
			a a;
			short num;
			for (;;)
			{
				parent = VisualTreeHelper.GetParent(A_0);
				a = (parent as a);
				if (a == null)
				{
					break;
				}
				num = (short)1595473921;
				if (num != 0)
				{
				}
				num = (short)1305870336;
				short num2 = num;
				num = (short)1422469968;
				short num3 = num;
				num = (short)1492593488;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_AB;
				}
			}
			return this.a<a>(parent);
			IL_AB:
			num = (short)1409024000;
			if (num != 0)
			{
			}
			return a;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000056E0 File Offset: 0x000038E0
		internal static string d(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((IntPtr)(218476067 + A_1) + (IntPtr)23 + (IntPtr)29);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
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
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}
	}
}
