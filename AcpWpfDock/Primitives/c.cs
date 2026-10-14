using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using DevComponents.WpfDock.Converters;

namespace DevComponents.WpfDock.Primitives
{
	// Token: 0x02000056 RID: 86
	internal class c : global::System.Windows.Documents.Adorner
	{
		// Token: 0x0600031F RID: 799 RVA: 0x0004D5D4 File Offset: 0x0004B7D4
		public c(global::System.Windows.UIElement A_0) : base(A_0)
		{
			this.a = new global::DevComponents.WpfDock.DockWindowSelector();
			base.AddVisualChild(this.a);
			base.AddLogicalChild(this.a);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0004D60C File Offset: 0x0004B80C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1445789696;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_4B;
					}
					int num4;
					int visualChildrenCount;
					global::System.Windows.Size availableSize;
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
							goto IL_19F;
						case 1:
							goto IL_1D4;
						case 2:
							num = (short)649396225;
							if (num != 0)
							{
							}
							goto IL_19F;
						case 3:
						{
							num = (short)731199758;
							short num3 = num;
							num = (short)222640398;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)117374976;
								if (num != 0)
								{
								}
								goto IL_C2;
							}
							break;
						}
						case 4:
						{
							if (num4 >= visualChildrenCount)
							{
								num = (short)1338310657;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = this.GetVisualChild(num4) as global::System.Windows.UIElement;
							num = (short)2102919174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::System.Windows.UIElement uielement;
							uielement.Measure(availableSize);
							num = (short)1739390979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							global::System.Windows.UIElement uielement;
							if (uielement != null)
							{
								num = (short)1155530757;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C2;
						}
						}
						break;
						IL_C2:
						num4++;
						num = (short)686227456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_19F:
						num = (short)2081357828;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4B:
					num = (short)1019478016;
					short num5 = num;
					availableSize = constraint;
					visualChildrenCount = this.VisualChildrenCount;
					num4 = 0;
					num = (short)1091567618;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
			IL_1D4:
			global::DevComponents.WpfDock.i.a(ref constraint);
			return constraint;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0004D7F8 File Offset: 0x0004B9F8
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			short num = (short)1037828096;
			short num2 = num;
			num = (short)1240336534;
			short num3 = num;
			num = (short)81725590;
			switch (num3 == num)
			{
			}
			num = (short)805109761;
			if (num != 0)
			{
			}
			num = (short)532414464;
			if (num != 0)
			{
			}
			global::System.Windows.Media.Brush brush = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Color.FromArgb(128, 0, 0, 0));
			dc.DrawRectangle(brush, null, new global::System.Windows.Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight));
			base.OnRender(dc);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0004D8E8 File Offset: 0x0004BAE8
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)2090270720;
			short num2 = num;
			num = (short)1119446981;
			short num3 = num;
			num = (short)1965123525;
			switch (num3 == num)
			{
			}
			num = (short)1718157313;
			if (num != 0)
			{
			}
			num = (short)1771962368;
			if (num != 0)
			{
			}
			global::System.Windows.Rect finalRect = new global::System.Windows.Rect((finalSize.Width - this.a.DesiredSize.Width) / 2.0, (finalSize.Height - this.a.DesiredSize.Height) / 2.0, this.a.DesiredSize.Width, this.a.DesiredSize.Height);
			this.a.Arrange(finalRect);
			return finalSize;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0004DA18 File Offset: 0x0004BC18
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public global::System.Windows.UIElement b()
		{
			short num = (short)987168768;
			short num2 = num;
			num = (short)1249681765;
			short num3 = num;
			num = (short)133341541;
			switch (num3 == num)
			{
			}
			num = (short)735510528;
			if (num != 0)
			{
			}
			num = (short)765263873;
			if (num != 0)
			{
			}
			return this.b;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0004DAC8 File Offset: 0x0004BCC8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public void b(global::System.Windows.UIElement A_0)
		{
			short num = (short)78643200;
			short num2 = num;
			num = (short)1091824848;
			short num3 = num;
			num = (short)563735760;
			switch (num3 == num)
			{
			}
			num = (short)1366228993;
			if (num != 0)
			{
			}
			num = (short)1063911424;
			if (num != 0)
			{
			}
			this.b = A_0;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0004DB78 File Offset: 0x0004BD78
		protected override int get_VisualChildrenCount()
		{
			short num = (short)1585250304;
			short num2 = num;
			num = (short)804847617;
			if (num != 0)
			{
			}
			num = (short)730413202;
			short num3 = num;
			num = (short)858929298;
			switch (num3 == num)
			{
			}
			num = (short)1900937216;
			if (num != 0)
			{
			}
			return 1;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0004DC24 File Offset: 0x0004BE24
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			int a_ = 15;
			for (;;)
			{
				IL_09:
				short num = (short)1010696192;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3E;
						}
						continue;
					case 1:
						goto IL_152;
					case 2:
						if (index > 0)
						{
							num = (short)1695219713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_154;
					case 3:
						num = (short)1148780546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3E:
					num = (short)1106525008;
					short num3 = num;
					num = (short)440941392;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_09;
					default:
					{
						num = (short)1255669760;
						short num4 = num;
						num = (short)1941504000;
						if (num != 0)
						{
						}
						if (index < 0)
						{
							goto IL_F6;
						}
						num = (short)655294465;
						if (num != 0)
						{
						}
						num = (short)1328414723;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
			IL_F6:
			throw new global::System.ArgumentOutOfRangeException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("ꟍ뻏뛑뇓껕", a_), index, global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("迍ꋏ뗑ꇓ믕뷗듙꣛ﻝ蛟跡難웥뻧菩鿫鯭釯黱퓳闵郷鏹郻髽⃿欁眃★朇缉砋⸍缏琑㐓搕礗琙笛笝", a_));
			IL_152:
			goto IL_F6;
			IL_154:
			return this.a;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0004DD8C File Offset: 0x0004BF8C
		protected override global::System.Collections.IEnumerator get_LogicalChildren()
		{
			short num = (short)1935474688;
			short num2 = num;
			num = (short)1242479027;
			short num3 = num;
			num = (short)297646515;
			switch (num3 == num)
			{
			}
			num = (short)1664745473;
			if (num != 0)
			{
			}
			num = (short)1089536000;
			if (num != 0)
			{
			}
			return new global::System.Collections.Generic.List<global::System.Windows.UIElement>(1)
			{
				this.a
			}.GetEnumerator();
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0004DE50 File Offset: 0x0004C050
		public global::DevComponents.WpfDock.DockWindowSelector c()
		{
			short num = (short)1562423481;
			short num2 = num;
			num = (short)590459065;
			switch (num2 == num)
			{
			}
			num = (short)453902336;
			short num3 = num;
			num = (short)2077163521;
			if (num != 0)
			{
			}
			num = (short)279642112;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0004DEFC File Offset: 0x0004C0FC
		public override global::System.Windows.Media.GeneralTransform GetDesiredTransform(global::System.Windows.Media.GeneralTransform transform)
		{
			short num = (short)1031471716;
			short num2 = num;
			num = (short)687211108;
			switch (num2 == num)
			{
			}
			num = (short)61865984;
			short num3 = num;
			num = (short)1129119745;
			if (num != 0)
			{
			}
			num = (short)442171392;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x040001F8 RID: 504
		private global::DevComponents.WpfDock.DockWindowSelector a;

		// Token: 0x040001F9 RID: 505
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.UIElement b;
	}
}
