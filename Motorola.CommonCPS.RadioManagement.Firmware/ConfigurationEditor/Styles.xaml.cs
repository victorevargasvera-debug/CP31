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
		// Token: 0x0600001A RID: 26 RVA: 0x00002FCC File Offset: 0x000011CC
		private void c(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1917064766;
			short num2 = num;
			num = (short)234165822;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1688338432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)504758273;
			if (num != 0)
			{
			}
			num = (short)1077280768;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000307C File Offset: 0x0000127C
		private void b(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)248053761;
			if (num != 0)
			{
			}
			num = (short)1249705984;
			short num2 = num;
			num = (short)472726548;
			short num3 = num;
			num = (short)332807188;
			switch (num3 == num)
			{
			}
			num = (short)1494745088;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000312C File Offset: 0x0000132C
		private void a(object A_0)
		{
			short num = (short)2115106355;
			short num2 = num;
			num = (short)708113971;
			switch (num2 == num)
			{
			default:
			{
				num = (short)119734272;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1392050177;
			if (num != 0)
			{
			}
			num = (short)123600896;
			if (num != 0)
			{
			}
			ContextMenu contextMenu = (ContextMenu)A_0;
			contextMenu.DataContext = this.a<UserControl>(contextMenu.PlacementTarget).DataContext;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000031F4 File Offset: 0x000013F4
		private void a(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1213263011;
			short num2 = num;
			num = (short)322956451;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1162870784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2076114945;
			if (num != 0)
			{
			}
			num = (short)806682624;
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

		// Token: 0x0600001E RID: 30 RVA: 0x000032CC File Offset: 0x000014CC
		private void b(object A_0, MouseButtonEventArgs A_1)
		{
			short num = (short)161641656;
			short num2 = num;
			num = (short)548172984;
			switch (num2 == num)
			{
			default:
			{
				num = (short)27328512;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1571422209;
			if (num != 0)
			{
			}
			num = (short)1176240128;
			if (num != 0)
			{
			}
			A_1.Handled = true;
			((RMLinkButton)A_0).ContextMenu.Visibility = Visibility.Collapsed;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003390 File Offset: 0x00001590
		private void a(object A_0, MouseButtonEventArgs A_1)
		{
			short num = (short)1369738703;
			short num2 = num;
			num = (short)1279823311;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2016477184;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)515112961;
			if (num != 0)
			{
			}
			num = (short)643760128;
			if (num != 0)
			{
			}
			ContextMenu contextMenu = ((TextBlock)A_0).ContextMenu;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003444 File Offset: 0x00001644
		private a a<a>(DependencyObject A_0) where a : FrameworkElement
		{
			DependencyObject parent;
			short num;
			for (;;)
			{
				parent = VisualTreeHelper.GetParent(A_0);
				a a = parent as a;
				if (a != null)
				{
					return a;
				}
				num = (short)114819073;
				if (num != 0)
				{
				}
				num = (short)32964608;
				short num2 = num;
				num = (short)1857108007;
				short num3 = num;
				num = (short)268843047;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A8;
				}
			}
			IL_A8:
			num = (short)2015232000;
			if (num != 0)
			{
			}
			return this.a<a>(parent);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003530 File Offset: 0x00001730
		internal static string d(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((IntPtr)(1830501059 + A_1) + (IntPtr)49 + (IntPtr)83 + (IntPtr)71 + (IntPtr)70);
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
