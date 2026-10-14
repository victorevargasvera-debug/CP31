using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using AcpUI.Common;

namespace AcpUI
{
	// Token: 0x0200003D RID: 61
	public class AcpUIDialogWindow<T> : global::System.Windows.Navigation.NavigationWindow
	{
		// Token: 0x060003B1 RID: 945 RVA: 0x0003FE20 File Offset: 0x0003E020
		public AcpUIDialogWindow(global::System.Windows.Navigation.PageFunction<T> page, T dialogData)
		{
			global::AcpUI.Common.Utility.SetDirection(this);
			this.a = dialogData;
			base.Title = page.Title;
			base.ShowsNavigationUI = false;
			base.SizeToContent = global::System.Windows.SizeToContent.WidthAndHeight;
			global::System.Windows.Media.Brush brush = (global::System.Windows.Media.Brush)base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::System.Windows.Controls.Frame), global::AcpUI.AcpColorKeys.FrameContentAreaBackground));
			if (brush != null)
			{
				base.Background = brush;
			}
			global::AcpUI.AcpUIDialogLauncher<T> acpUIDialogLauncher = new global::AcpUI.AcpUIDialogLauncher<T>(page);
			acpUIDialogLauncher.a(new global::AcpUI.AcpUIDialogLauncherReturnEventHandler(this.LauncherReturn));
			base.Navigate(acpUIDialogLauncher);
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0003FEAC File Offset: 0x0003E0AC
		public object DialogData
		{
			get
			{
				short num = (short)1180844656;
				short num2 = num;
				num = (short)1652769392;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1400111104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)502333441;
				if (num != 0)
				{
				}
				num = (short)1106706432;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0003FF60 File Offset: 0x0003E160
		private void LauncherReturn(object A_0, global::AcpUI.PageReturnEventArgs A_1)
		{
			short num = (short)1603075801;
			short num2 = num;
			num = (short)2040725209;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1996029952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2028339201;
			if (num != 0)
			{
			}
			num = (short)212795392;
			if (num != 0)
			{
			}
			this.a = (T)((object)A_1.Data);
		}

		// Token: 0x0400022F RID: 559
		private T a;
	}
}
