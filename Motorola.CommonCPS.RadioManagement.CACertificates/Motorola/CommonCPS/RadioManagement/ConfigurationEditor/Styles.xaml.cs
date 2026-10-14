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
		// Token: 0x06000018 RID: 24 RVA: 0x00002DC8 File Offset: 0x00000FC8
		private void c(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1119347118;
			short num2 = num;
			num = (short)1969152430;
			switch (num2 == num)
			{
			}
			num = (short)694026240;
			short num3 = num;
			num = (short)420216833;
			if (num != 0)
			{
			}
			num = (short)2095841280;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002E78 File Offset: 0x00001078
		private void b(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)871038977;
			if (num != 0)
			{
			}
			num = (short)404636385;
			short num2 = num;
			num = (short)846349025;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1475084288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1620180992;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002F28 File Offset: 0x00001128
		private void a(object A_0)
		{
			short num = (short)412942337;
			if (num != 0)
			{
			}
			num = (short)1743635088;
			short num2 = num;
			num = (short)1566950032;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1970274304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1939144704;
			if (num != 0)
			{
			}
			ContextMenu contextMenu = (ContextMenu)A_0;
			contextMenu.DataContext = this.a<UserControl>(contextMenu.PlacementTarget).DataContext;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002FF0 File Offset: 0x000011F0
		private void a(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1644822529;
			if (num != 0)
			{
			}
			num = (short)1806243363;
			short num2 = num;
			num = (short)107943459;
			switch (num2 == num)
			{
			default:
			{
				num = (short)144179200;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1283719168;
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

		// Token: 0x0600001C RID: 28 RVA: 0x000030C8 File Offset: 0x000012C8
		private void b(object A_0, MouseButtonEventArgs A_1)
		{
			short num = (short)1359068087;
			short num2 = num;
			num = (short)1536932791;
			switch (num2 == num)
			{
			}
			num = (short)1503526912;
			short num3 = num;
			num = (short)2094661632;
			if (num != 0)
			{
			}
			num = (short)812580865;
			if (num != 0)
			{
			}
			A_1.Handled = true;
			((RMLinkButton)A_0).ContextMenu.Visibility = Visibility.Collapsed;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000318C File Offset: 0x0000138C
		private void a(object A_0, MouseButtonEventArgs A_1)
		{
			short num = (short)639628618;
			short num2 = num;
			num = (short)1856632138;
			switch (num2 == num)
			{
			}
			num = (short)2105475072;
			short num3 = num;
			num = (short)1242890240;
			if (num != 0)
			{
			}
			num = (short)1217593345;
			if (num != 0)
			{
			}
			ContextMenu contextMenu = ((TextBlock)A_0).ContextMenu;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003240 File Offset: 0x00001440
		private a a<a>(DependencyObject A_0) where a : FrameworkElement
		{
			DependencyObject parent = VisualTreeHelper.GetParent(A_0);
			a a = parent as a;
			if (a == null)
			{
				short num = (short)715583048;
				short num2 = num;
				num = (short)1902702152;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2024079360;
					if (num != 0)
					{
					}
					break;
				}
				num = (short)765001729;
				if (num != 0)
				{
				}
				num = (short)1155006464;
				short num3 = num;
				return this.a<a>(parent);
			}
			return a;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003324 File Offset: 0x00001524
		internal static string d(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((IntPtr)(108389893 + A_1) + (IntPtr)73 + (IntPtr)14 + (IntPtr)69 + (IntPtr)11);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
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
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}
	}
}
