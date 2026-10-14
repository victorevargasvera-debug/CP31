using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000044 RID: 68
	public class DragWindow : global::System.Windows.Window
	{
		// Token: 0x060000EB RID: 235 RVA: 0x0000F76C File Offset: 0x0000D96C
		public DragWindow(global::System.Windows.Media.Visual dragItem)
		{
			global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.SetWindowAsTransparent(this);
			base.WindowStyle = global::System.Windows.WindowStyle.None;
			base.AllowsTransparency = true;
			base.AllowDrop = false;
			base.Background = null;
			base.IsHitTestVisible = false;
			base.SizeToContent = global::System.Windows.SizeToContent.WidthAndHeight;
			base.Topmost = true;
			base.ShowInTaskbar = false;
			base.Width = ((global::System.Windows.FrameworkElement)dragItem).ActualWidth;
			base.Height = ((global::System.Windows.FrameworkElement)dragItem).ActualHeight;
			base.Content = new global::System.Windows.Shapes.Rectangle
			{
				Width = ((global::System.Windows.FrameworkElement)dragItem).ActualWidth,
				Height = ((global::System.Windows.FrameworkElement)dragItem).ActualHeight,
				Fill = new global::System.Windows.Media.VisualBrush(dragItem)
				{
					Opacity = 0.8
				}
			};
			global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.InstallMouseHook();
			global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.MouseLeftButtonUp += this.InterceptMouse_MouseLeftButtonUp;
			this.timer = new global::System.Windows.Threading.DispatcherTimer(new global::System.TimeSpan(0, 0, 0, 0, 10), global::System.Windows.Threading.DispatcherPriority.Send, delegate(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1430887178;
				short num2 = num;
				num = (short)933534474;
				switch (num2 == num)
				{
				}
				num = (short)165675009;
				if (num != 0)
				{
				}
				num = (short)733937664;
				short num3 = num;
				num = (short)643629056;
				if (num != 0)
				{
				}
				this.UpdateWindowLocation();
			}, base.Dispatcher);
			this.timer.Start();
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000F874 File Offset: 0x0000DA74
		private void InterceptMouse_MouseLeftButtonUp(object A_0, global::System.EventArgs A_1)
		{
			short num;
			try
			{
				num = (short)880112464;
				short num2 = num;
				num = (short)1760785232;
				switch (num2 == num)
				{
				}
				num = (short)766181376;
				if (num != 0)
				{
				}
				base.Close();
			}
			catch
			{
			}
			num = (short)2000158720;
			short num3 = num;
			num = (short)1201340417;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000F938 File Offset: 0x0000DB38
		protected override void OnClosed(global::System.EventArgs e)
		{
			short num = (short)1679872006;
			short num2 = num;
			num = (short)703123462;
			switch (num2 == num)
			{
			}
			num = (short)116064257;
			if (num != 0)
			{
			}
			num = (short)1315897344;
			short num3 = num;
			num = (short)645922816;
			if (num != 0)
			{
			}
			base.OnClosed(e);
			global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.UninstallMouseHook();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000F9EC File Offset: 0x0000DBEC
		public void UpdateWindowLocation()
		{
			short num = (short)1382734903;
			short num2 = num;
			num = (short)522771511;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1841627137;
				if (num != 0)
				{
				}
				num = (short)754188288;
				if (num != 0)
				{
				}
				num = (short)1993932801;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)995033088;
					short num4 = num;
					base.Left = global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.CurrentMouseLocation.X - base.ActualWidth / 2.0;
					base.Top = global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.CurrentMouseLocation.Y - base.ActualHeight / 2.0;
					num = (short)758841346;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_A4;
					}
					continue;
				case 2:
					return;
				}
				IL_A4:
				if (!base.IsVisible)
				{
					break;
				}
				num = (short)493748224;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Threading.DispatcherTimer timer;
	}
}
