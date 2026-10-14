using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Interop;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200008E RID: 142
	public class PopupNonTopmost : global::System.Windows.Controls.Primitives.Popup
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000356 RID: 854 RVA: 0x000378F4 File Offset: 0x00035AF4
		// (set) Token: 0x06000357 RID: 855 RVA: 0x000379B0 File Offset: 0x00035BB0
		public bool Topmost
		{
			get
			{
				short num = (short)1354366977;
				if (num != 0)
				{
				}
				num = (short)1846673408;
				short num2 = num;
				num = (short)2084396010;
				short num3 = num;
				num = (short)603216874;
				switch (num3 == num)
				{
				}
				num = (short)1913978880;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PopupNonTopmost.TopmostProperty);
			}
			set
			{
				short num = (short)1444085761;
				if (num != 0)
				{
				}
				num = (short)1057882112;
				short num2 = num;
				num = (short)1502219632;
				short num3 = num;
				num = (short)1619791216;
				switch (num3 == num)
				{
				}
				num = (short)1897529344;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.PopupNonTopmost.TopmostProperty, value);
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00037A6C File Offset: 0x00035C6C
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1263196551;
			short num2 = num;
			num = (short)659085703;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1134100480;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1165754369;
			if (num != 0)
			{
			}
			num = (short)672530432;
			if (num != 0)
			{
			}
			(A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.PopupNonTopmost).a();
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00037B24 File Offset: 0x00035D24
		protected override void OnOpened(global::System.EventArgs e)
		{
			short num = (short)837033495;
			short num2 = num;
			num = (short)70655511;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1497759744;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1315962880;
			if (num != 0)
			{
			}
			num = (short)2006384641;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00037BD4 File Offset: 0x00035DD4
		private void a()
		{
			short num = (short)2081751043;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1697185792;
				short num3 = num;
				global::System.IntPtr handle;
				switch (num2)
				{
				case 0:
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.PopupNonTopmost.UnsafeNativeMethods.RECT rect;
					global::Motorola.CommonCPS.RadioManagement.Controls.PopupNonTopmost.UnsafeNativeMethods.SetWindowPos(handle, this.Topmost ? new global::System.IntPtr(-1) : new global::System.IntPtr(-2), rect.a, rect.b, (int)base.Width, (int)base.Height, 0U);
					num = (short)461570050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.PopupNonTopmost.UnsafeNativeMethods.RECT rect;
					if (!global::Motorola.CommonCPS.RadioManagement.Controls.PopupNonTopmost.UnsafeNativeMethods.GetWindowRect(handle, out rect))
					{
						return;
					}
					num = (short)1425469482;
					short num4 = num;
					num = (short)630911018;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D4;
					default:
						num = (short)425721856;
						if (num != 0)
						{
						}
						num = (short)1380581381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 4:
					num = (short)1168637953;
					if (num != 0)
					{
					}
					goto IL_D4;
				case 5:
					num = (short)989069312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_64:
				if (!global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.IsGlueWindowWorkingNow)
				{
					num = (short)1651572740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_D4:
				handle = ((global::System.Windows.Interop.HwndSource)global::System.Windows.PresentationSource.FromVisual(base.Child)).Handle;
				num = (short)271843329;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00037DB8 File Offset: 0x00035FB8
		// Note: this type is marked as 'beforefieldinit'.
		static PopupNonTopmost()
		{
			short num = (short)2084661302;
			short num2 = num;
			num = (short)184576054;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1063387136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2029387777;
			if (num != 0)
			{
			}
			num = (short)1459486720;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.PopupNonTopmost.TopmostProperty = global::System.Windows.Window.TopmostProperty.AddOwner(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.PopupNonTopmost), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.PopupNonTopmost.a)));
		}

		// Token: 0x04000110 RID: 272
		public static global::System.Windows.DependencyProperty TopmostProperty;

		// Token: 0x0200008F RID: 143
		[global::System.Security.SuppressUnmanagedCodeSecurity]
		internal static class UnsafeNativeMethods
		{
			// Token: 0x0600035D RID: 861
			[global::System.Runtime.InteropServices.DllImport("user32.dll")]
			[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
			internal static extern bool GetWindowRect(global::System.IntPtr A_0, out global::Motorola.CommonCPS.RadioManagement.Controls.PopupNonTopmost.UnsafeNativeMethods.RECT A_1);

			// Token: 0x0600035E RID: 862
			[global::System.Runtime.InteropServices.DllImport("user32")]
			internal static extern int SetWindowPos(global::System.IntPtr A_0, global::System.IntPtr A_1, int A_2, int A_3, int A_4, int A_5, uint A_6);

			// Token: 0x02000090 RID: 144
			public struct RECT
			{
				// Token: 0x04000111 RID: 273
				public int a;

				// Token: 0x04000112 RID: 274
				public int b;

				// Token: 0x04000113 RID: 275
				public int c;

				// Token: 0x04000114 RID: 276
				public int d;
			}
		}
	}
}
