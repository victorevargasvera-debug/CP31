using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DevComponents.WpfDock.Primitives
{
	// Token: 0x0200005B RID: 91
	internal class g : global::System.Windows.Controls.Image
	{
		// Token: 0x0600036D RID: 877 RVA: 0x000530B8 File Offset: 0x000512B8
		public void a(global::System.Windows.UIElement A_0)
		{
			short num = (short)281280512;
			short num2 = num;
			num = (short)1696932870;
			short num3 = num;
			num = (short)869409798;
			switch (num3 == num)
			{
			}
			num = (short)805306369;
			if (num != 0)
			{
			}
			num = (short)1727922176;
			if (num != 0)
			{
			}
			global::System.Windows.Media.Imaging.RenderTargetBitmap renderTargetBitmap = new global::System.Windows.Media.Imaging.RenderTargetBitmap((int)A_0.RenderSize.Width, (int)A_0.RenderSize.Height, 96.0, 96.0, global::System.Windows.Media.PixelFormats.Default);
			renderTargetBitmap.Render(A_0);
			base.Source = renderTargetBitmap;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000531AC File Offset: 0x000513AC
		public void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1094647808;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 1:
					goto IL_5D;
				case 2:
					goto IL_F6;
				case 3:
				{
					num = (short)1919648519;
					short num3 = num;
					num = (short)7308039;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F6;
					default:
						goto IL_C3;
					}
					break;
				}
				case 4:
				{
					num = (short)1933246464;
					short num4 = num;
					num = (short)1392574465;
					if (num != 0)
					{
					}
					(base.Parent as global::System.Windows.Controls.Panel).Children.Remove(this);
					num = (short)565116931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_38:
				if (base.Parent is global::DevComponents.WpfDock.Primitives.a)
				{
					num = (short)195231745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)71434242;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F6:
				if (!(base.Parent is global::System.Windows.Controls.Panel))
				{
					return;
				}
				num = (short)1239810052;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5D:
			(base.Parent as global::DevComponents.WpfDock.Primitives.a).b().Remove(this);
			return;
			IL_C3:
			num = (short)1714946048;
			if (num != 0)
			{
			}
		}
	}
}
