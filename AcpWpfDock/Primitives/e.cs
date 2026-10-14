using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace DevComponents.WpfDock.Primitives
{
	// Token: 0x02000058 RID: 88
	internal class e : global::System.Windows.Documents.Adorner
	{
		// Token: 0x06000341 RID: 833 RVA: 0x0004F8CC File Offset: 0x0004DACC
		public e(global::DevComponents.WpfDock.DockSplitter A_0) : base(A_0)
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0004F8E0 File Offset: 0x0004DAE0
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			short num = (short)68157441;
			if (num != 0)
			{
			}
			num = (short)642802159;
			short num2 = num;
			num = (short)1032348143;
			switch (num2 == num)
			{
			default:
			{
				num = (short)899088384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1681981440;
			if (num != 0)
			{
			}
			global::System.Windows.Rect rectangle = this.c();
			global::System.Windows.Media.Brush brush = this.d();
			dc.DrawRectangle(brush, null, rectangle);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0004F9A0 File Offset: 0x0004DBA0
		public global::System.Windows.Media.Brush d()
		{
			short num = (short)948109313;
			if (num != 0)
			{
			}
			num = (short)1155292577;
			short num2 = num;
			num = (short)883121569;
			switch (num2 == num)
			{
			default:
			{
				num = (short)324796416;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1223294976;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0004FA54 File Offset: 0x0004DC54
		public void c(global::System.Windows.Media.Brush A_0)
		{
			short num = (short)851423793;
			short num2 = num;
			num = (short)216183345;
			switch (num2 == num)
			{
			}
			num = (short)1867710464;
			short num3 = num;
			num = (short)140247040;
			if (num != 0)
			{
			}
			num = (short)734330881;
			if (num != 0)
			{
			}
			this.a = A_0;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0004FB04 File Offset: 0x0004DD04
		private global::System.Windows.Rect c()
		{
			short num = (short)690898930;
			short num2 = num;
			num = (short)1260013554;
			global::DevComponents.WpfDock.DockSplitter dockSplitter;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1590493184;
				short num3 = num;
				num = (short)916520961;
				if (num != 0)
				{
				}
				num = (short)432406528;
				if (num != 0)
				{
				}
				dockSplitter = (global::DevComponents.WpfDock.DockSplitter)base.AdornedElement;
				if (dockSplitter.Orientation != global::System.Windows.Controls.Orientation.Horizontal)
				{
					return new global::System.Windows.Rect(this.b, 0.0, dockSplitter.ActualWidth, dockSplitter.ActualHeight);
				}
				break;
			}
			}
			return new global::System.Windows.Rect(0.0, this.b, dockSplitter.ActualWidth, dockSplitter.ActualHeight);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0004FC04 File Offset: 0x0004DE04
		public double e()
		{
			short num = (short)167263977;
			short num2 = num;
			num = (short)1138966249;
			switch (num2 == num)
			{
			}
			num = (short)1919614976;
			short num3 = num;
			num = (short)472252416;
			if (num != 0)
			{
			}
			num = (short)341377025;
			if (num != 0)
			{
			}
			return this.b;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0004FCB4 File Offset: 0x0004DEB4
		public void c(double A_0)
		{
			short num = (short)2102067200;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					return;
				case 2:
					this.b = A_0;
					base.InvalidateVisual();
					num = (short)1106182145;
					if (num != 0)
					{
					}
					num = (short)1249837057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				num = (short)564521802;
				short num3 = num;
				num = (short)1863576394;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)1305804800;
					if (num != 0)
					{
					}
					if (this.b == A_0)
					{
						return;
					}
					num = (short)771227648;
					short num4 = num;
					num = (short)1859125250;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x04000203 RID: 515
		private global::System.Windows.Media.Brush a;

		// Token: 0x04000204 RID: 516
		private double b;
	}
}
