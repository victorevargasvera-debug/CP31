using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x020000B9 RID: 185
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class WindowBorder : global::System.Windows.Controls.Border
	{
		// Token: 0x0600086B RID: 2155 RVA: 0x000C1570 File Offset: 0x000BF770
		static WindowBorder()
		{
			int a_ = 7;
			short num = (short)1632501761;
			if (num != 0)
			{
			}
			num = (short)1312172586;
			short num2 = num;
			num = (short)1948265002;
			switch (num2 == num)
			{
			}
			num = (short)1858797568;
			short num3 = num;
			num = (short)535625728;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.WindowBorder.TransparentMarginProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("୞፠ɢ୤ᑦᥨ੪Ὤ੮ὰݲ㡴ᙶ୸ᱺᑼᅾ", a_), typeof(global::System.Windows.Thickness), typeof(global::DevComponents.WpfRibbon.WindowBorder), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x000C1664 File Offset: 0x000BF864
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_48;
				}
				short num;
				int num2;
				global::System.Windows.Rect rect;
				for (;;)
				{
					IL_0A:
					num = (short)1040318465;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						try
						{
							base.OnRender(dc);
							return;
						}
						finally
						{
							dc.Pop();
						}
						goto IL_A5;
					case 1:
						return;
					case 2:
					{
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(this.TransparentMargin))
						{
							num = (short)843907075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)552271872;
						short num3 = num;
						base.OnRender(dc);
						num = (short)1327497217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_A5;
					}
					break;
					IL_A5:
					num = (short)808595465;
					short num4 = num;
					num = (short)275001353;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)2054684672;
						if (num != 0)
						{
						}
						rect = global::DevComponents.WpfRibbon.LayoutHelpers.DeflateRect(rect, this.TransparentMargin);
						dc.PushClip(new global::System.Windows.Media.RectangleGeometry(rect));
						num = (short)1199374336;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_48:
				rect = new global::System.Windows.Rect(base.RenderSize);
				num = (short)1080164354;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x000C17F0 File Offset: 0x000BF9F0
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x000C18AC File Offset: 0x000BFAAC
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Thickness TransparentMargin
		{
			get
			{
				short num = (short)637695346;
				short num2 = num;
				num = (short)1482847602;
				switch (num2 == num)
				{
				}
				num = (short)489947137;
				if (num != 0)
				{
				}
				num = (short)1122762752;
				short num3 = num;
				num = (short)354680832;
				if (num != 0)
				{
				}
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfRibbon.WindowBorder.TransparentMarginProperty);
			}
			set
			{
				short num = (short)1489370506;
				short num2 = num;
				num = (short)1675754890;
				switch (num2 == num)
				{
				}
				num = (short)77856769;
				if (num != 0)
				{
				}
				num = (short)1094975488;
				short num3 = num;
				num = (short)1693712384;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.WindowBorder.TransparentMarginProperty, value);
			}
		}

		// Token: 0x04000742 RID: 1858
		public static readonly global::System.Windows.DependencyProperty TransparentMarginProperty;
	}
}
