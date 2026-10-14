using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace DevComponents.WpfDock.Primitives
{
	// Token: 0x02000057 RID: 87
	internal class d : global::System.Windows.Documents.Adorner
	{
		// Token: 0x0600032A RID: 810 RVA: 0x0004DFA8 File Offset: 0x0004C1A8
		public d(global::System.Windows.UIElement A_0) : base(A_0)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0004DFCC File Offset: 0x0004C1CC
		public global::System.Windows.UIElement i()
		{
			short num = (short)1894802480;
			short num2 = num;
			num = (short)705389616;
			switch (num2 == num)
			{
			}
			num = (short)497811456;
			short num3 = num;
			num = (short)1639317504;
			if (num != 0)
			{
			}
			num = (short)1664221185;
			if (num != 0)
			{
			}
			return this.i;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0004E07C File Offset: 0x0004C27C
		public void i(global::System.Windows.UIElement A_0)
		{
			short num = (short)800742926;
			short num2 = num;
			num = (short)1047813646;
			switch (num2 == num)
			{
			}
			num = (short)2078605312;
			short num3 = num;
			num = (short)289275905;
			if (num != 0)
			{
			}
			num = (short)1727922176;
			if (num != 0)
			{
			}
			this.i = A_0;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0004E12C File Offset: 0x0004C32C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			global::System.Windows.Size availableSize = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);
			global::System.Collections.IEnumerator enumerator = this.p().GetEnumerator();
			short num;
			try
			{
				num = (short)145948674;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!enumerator.MoveNext())
						{
							num = (short)573833220;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::System.Windows.UIElement)enumerator.Current).Measure(availableSize);
						num = (short)1450967043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_128;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 3:
					{
						num = (short)813018139;
						short num3 = num;
						num = (short)1861987355;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10F;
						default:
							num = (short)1900150784;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					case 4:
						goto IL_10F;
					}
					IL_D3:
					num = (short)1120468992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_60:
					goto IL_D3;
					IL_10F:
					num = (short)1921646593;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_128:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_146;
				}
				int num2;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_134:
					switch (num2)
					{
					case 0:
						disposable.Dispose();
						num = (short)1303707650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (disposable != null)
						{
							num = (short)348323840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_199;
					case 2:
						goto IL_197;
					}
					goto IL_146;
				}
				IL_197:
				IL_199:
				goto EndFinally_5;
				IL_146:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)945225729;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_134;
				EndFinally_5:;
			}
			num = (short)1515126784;
			short num4 = num;
			num = (short)311164929;
			if (num != 0)
			{
			}
			global::DevComponents.WpfDock.i.a(ref constraint);
			return constraint;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0004E348 File Offset: 0x0004C548
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)1666908160;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8B;
				}
				global::System.Windows.Rect rect2;
				global::System.Windows.Rect finalRect;
				for (;;)
				{
					IL_28:
					global::System.Windows.Rect rect;
					global::System.Windows.Size desiredSize2;
					switch (num2)
					{
					case 0:
						if (this.k() != null)
						{
							num = (short)1157496839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F9;
					case 1:
						goto IL_44F;
					case 2:
						goto IL_2AD;
					case 3:
						goto IL_5F9;
					case 4:
						rect = this.g;
						goto IL_498;
					case 5:
						goto IL_16D;
					case 6:
						num = (short)1106575375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::System.Windows.Size desiredSize = this.k().DesiredSize;
						finalRect = this.i(new global::System.Windows.Rect(rect2.X + (rect2.Width - desiredSize.Width) / 2.0, rect2.Y + this.h, desiredSize.Width, desiredSize.Height));
						this.k().Arrange(finalRect);
						num = (short)919797763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (this.i() is global::DevComponents.WpfDock.DockSite)
						{
							num = (short)880279572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AD;
					case 9:
						goto IL_34A;
					case 10:
						return finalSize;
					case 11:
						if (this.m() != null)
						{
							num = (short)510263313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0;
					case 12:
					{
						num = (short)113913718;
						short num3 = num;
						num = (short)1402023798;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_498;
						default:
							num = (short)1968832512;
							if (num != 0)
							{
							}
							if (this.n() != null)
							{
								num = (short)1787297806;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return finalSize;
						}
						break;
					}
					case 13:
						if (this.g.Width > 0.0)
						{
							num = (short)492503046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34A;
					case 14:
						desiredSize2 = this.n().DesiredSize;
						rect = rect2;
						num = (short)321060877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						num = (short)344784896;
						short num4 = num;
						if (this.g.Height > 0.0)
						{
							num = (short)569638916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34A;
					}
					case 16:
					{
						global::System.Windows.Size desiredSize3 = this.j().DesiredSize;
						finalRect = this.i(new global::System.Windows.Rect(rect2.X + (rect2.Width - desiredSize3.Width) / 2.0, rect2.Bottom - desiredSize3.Height - this.h, desiredSize3.Width, desiredSize3.Height));
						this.j().Arrange(finalRect);
						num = (short)934346753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::System.Windows.Size desiredSize4 = this.m().DesiredSize;
						finalRect = this.i(new global::System.Windows.Rect(rect2.Right - desiredSize4.Width - this.h, rect2.Y + (rect2.Height - desiredSize4.Height) / 2.0, desiredSize4.Width, desiredSize4.Height));
						this.m().Arrange(finalRect);
						num = (short)1386479638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (this.l() != null)
						{
							num = (short)703266835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16D;
					case 19:
					{
						num = (short)366215169;
						if (num != 0)
						{
						}
						global::System.Windows.Size desiredSize5 = this.l().DesiredSize;
						finalRect = this.i(new global::System.Windows.Rect(rect2.X + this.h, rect2.Y + (rect2.Height - desiredSize5.Height) / 2.0, desiredSize5.Width, desiredSize5.Height));
						this.l().Arrange(finalRect);
						num = (short)1476329477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						rect2 = global::DevComponents.WpfDock.i.a(this.i() as global::DevComponents.WpfDock.DockSite, this);
						rect2.Y = 0.0;
						num = (short)1793589250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (this.j() != null)
						{
							num = (short)2123694096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44F;
					case 22:
						goto IL_E0;
					}
					goto IL_8B;
					IL_E0:
					num = (short)1637154828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16D:
					num = (short)1082720267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AD:
					num = (short)1248264213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34A:
					finalRect = this.i(new global::System.Windows.Rect(rect.X + (rect.Width - desiredSize2.Width) / 2.0, rect.Y + (rect.Height - desiredSize2.Height) / 2.0, desiredSize2.Width, desiredSize2.Height));
					this.n().Arrange(finalRect);
					num = (short)2127429642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44F:
					num = (short)1991835648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_498:
					num = (short)311951369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F9:
					num = (short)1679360018;
					num2 = (int)((global::System.IntPtr)num);
				}
				return finalSize;
				IL_8B:
				finalRect = global::System.Windows.Rect.Empty;
				rect2 = new global::System.Windows.Rect(finalSize);
				num = (short)1216741384;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0004E9B8 File Offset: 0x0004CBB8
		private global::System.Windows.Rect i(global::System.Windows.Rect A_0)
		{
			short num = (short)1646264321;
			if (num != 0)
			{
			}
			num = (short)1001740360;
			short num2 = num;
			num = (short)785078344;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2112946176;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1392967680;
			if (num != 0)
			{
			}
			A_0.X = global::System.Math.Round(A_0.X);
			A_0.Y = global::System.Math.Round(A_0.Y);
			return A_0;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0004EA88 File Offset: 0x0004CC88
		public global::System.Windows.UIElement j()
		{
			short num = (short)282645103;
			short num2 = num;
			num = (short)1843450479;
			switch (num2 == num)
			{
			}
			num = (short)754188288;
			short num3 = num;
			num = (short)1528758273;
			if (num != 0)
			{
			}
			num = (short)1683161088;
			if (num != 0)
			{
			}
			return this.b;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0004EB38 File Offset: 0x0004CD38
		public void j(global::System.Windows.UIElement A_0)
		{
			short num = (short)62858145;
			short num2 = num;
			num = (short)1107633057;
			switch (num2 == num)
			{
			}
			num = (short)814415872;
			short num3 = num;
			num = (short)1636302848;
			if (num != 0)
			{
			}
			num = (short)922812417;
			if (num != 0)
			{
			}
			this.i(A_0, ref this.b);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0004EBF0 File Offset: 0x0004CDF0
		public global::System.Windows.UIElement k()
		{
			short num = (short)2112890756;
			short num2 = num;
			num = (short)1132930948;
			switch (num2 == num)
			{
			}
			num = (short)464781312;
			short num3 = num;
			num = (short)643170305;
			if (num != 0)
			{
			}
			num = (short)290586624;
			if (num != 0)
			{
			}
			return this.c;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0004ECA0 File Offset: 0x0004CEA0
		public void k(global::System.Windows.UIElement A_0)
		{
			short num = (short)615790463;
			short num2 = num;
			num = (short)2092382079;
			switch (num2 == num)
			{
			}
			num = (short)1679425536;
			short num3 = num;
			num = (short)974913537;
			if (num != 0)
			{
			}
			num = (short)321388544;
			if (num != 0)
			{
			}
			this.i(A_0, ref this.c);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0004ED58 File Offset: 0x0004CF58
		public global::System.Windows.UIElement l()
		{
			short num = (short)1000885393;
			short num2 = num;
			num = (short)2095533201;
			switch (num2 == num)
			{
			}
			num = (short)1563754496;
			short num3 = num;
			num = (short)202113025;
			if (num != 0)
			{
			}
			num = (short)1458307072;
			if (num != 0)
			{
			}
			return this.d;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0004EE08 File Offset: 0x0004D008
		public void l(global::System.Windows.UIElement A_0)
		{
			short num = (short)1548134227;
			short num2 = num;
			num = (short)1331603283;
			switch (num2 == num)
			{
			}
			num = (short)214237184;
			short num3 = num;
			num = (short)278724609;
			if (num != 0)
			{
			}
			num = (short)1496645632;
			if (num != 0)
			{
			}
			this.i(A_0, ref this.d);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0004EEC0 File Offset: 0x0004D0C0
		public global::System.Windows.UIElement m()
		{
			short num = (short)1639282871;
			short num2 = num;
			num = (short)527268023;
			switch (num2 == num)
			{
			}
			num = (short)460849152;
			short num3 = num;
			num = (short)1880031233;
			if (num != 0)
			{
			}
			num = (short)519241728;
			if (num != 0)
			{
			}
			return this.e;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0004EF70 File Offset: 0x0004D170
		public void m(global::System.Windows.UIElement A_0)
		{
			short num = (short)1804468818;
			short num2 = num;
			num = (short)511181394;
			switch (num2 == num)
			{
			}
			num = (short)1929248768;
			short num3 = num;
			num = (short)1746141184;
			if (num != 0)
			{
			}
			num = (short)312016897;
			if (num != 0)
			{
			}
			this.i(A_0, ref this.e);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0004F024 File Offset: 0x0004D224
		public global::System.Windows.UIElement n()
		{
			short num = (short)205690320;
			short num2 = num;
			num = (short)1757517264;
			switch (num2 == num)
			{
			}
			num = (short)1929641984;
			short num3 = num;
			num = (short)1722417153;
			if (num != 0)
			{
			}
			num = (short)1202388992;
			if (num != 0)
			{
			}
			return this.f;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0004F0D0 File Offset: 0x0004D2D0
		public void n(global::System.Windows.UIElement A_0)
		{
			short num = (short)2039506481;
			short num2 = num;
			num = (short)1327851057;
			switch (num2 == num)
			{
			}
			num = (short)499646464;
			short num3 = num;
			num = (short)406650881;
			if (num != 0)
			{
			}
			num = (short)1849950208;
			if (num != 0)
			{
			}
			this.i(A_0, ref this.f);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0004F188 File Offset: 0x0004D388
		public global::System.Windows.Rect o()
		{
			short num = (short)2070565161;
			short num2 = num;
			num = (short)2027770153;
			switch (num2 == num)
			{
			}
			num = (short)998244352;
			short num3 = num;
			num = (short)1043922944;
			if (num != 0)
			{
			}
			num = (short)1571225601;
			if (num != 0)
			{
			}
			return this.g;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0004F238 File Offset: 0x0004D438
		public void j(global::System.Windows.Rect A_0)
		{
			short num = (short)1794048001;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)440139777;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					this.g = A_0;
					base.InvalidateArrange();
					base.InvalidateVisual();
					num = (short)991887360;
					short num3 = num;
					num = (short)845217794;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 2:
					goto IL_D6;
				}
				IL_59:
				if (!(this.g != A_0))
				{
					return;
				}
				num = (short)1906769920;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D6:
			num = (short)1457324319;
			short num4 = num;
			num = (short)297730335;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)459735040;
				if (num != 0)
				{
				}
				break;
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0004F36C File Offset: 0x0004D56C
		private void i(global::System.Windows.UIElement A_0, ref global::System.Windows.UIElement A_1)
		{
			short num = (short)1853095938;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1872429057;
					if (num != 0)
					{
					}
					this.p().Remove(A_1);
					num = (short)20512768;
					short num3 = num;
					num = (short)950534145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_D7;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 3:
					goto IL_D2;
				case 4:
				{
					num = (short)2112063796;
					short num4 = num;
					num = (short)1708951860;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F9;
					default:
						num = (short)1369309184;
						if (num != 0)
						{
						}
						this.p().Add(A_1);
						num = (short)663420931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (A_1 != null)
					{
						goto IL_F9;
					}
					goto IL_190;
				}
				IL_3E:
				if (A_1 != null)
				{
					num = (short)2041774080;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_D7:
				A_1 = A_0;
				num = (short)1968898053;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F9:
				num = (short)1535311876;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D2:
			IL_190:
			base.InvalidateMeasure();
			base.InvalidateVisual();
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0004F518 File Offset: 0x0004D718
		public global::System.Windows.Controls.UIElementCollection p()
		{
			short num = (short)1337065472;
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
					goto IL_114;
				case 2:
					this.a = new global::System.Windows.Controls.UIElementCollection(this, this);
					num = (short)2108686337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				num = (short)798591489;
				short num3 = num;
				num = (short)1769179649;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_116;
				default:
				{
					num = (short)421003265;
					if (num != 0)
					{
					}
					num = (short)533200896;
					if (num != 0)
					{
					}
					num = (short)1117454336;
					short num4 = num;
					if (this.a != null)
					{
						goto IL_116;
					}
					num = (short)359006210;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_114:
			IL_116:
			return this.a;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0004F644 File Offset: 0x0004D844
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			short num = (short)830160161;
			short num2 = num;
			num = (short)1016413473;
			switch (num2 == num)
			{
			}
			num = (short)173735936;
			short num3 = num;
			num = (short)769589249;
			if (num != 0)
			{
			}
			num = (short)856424448;
			if (num != 0)
			{
			}
			return this.p()[index];
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0004F6FC File Offset: 0x0004D8FC
		protected override int get_VisualChildrenCount()
		{
			short num = (short)825195718;
			short num2 = num;
			num = (short)1956609222;
			switch (num2 == num)
			{
			}
			num = (short)2070806528;
			short num3 = num;
			num = (short)1199833089;
			if (num != 0)
			{
			}
			num = (short)324665344;
			if (num != 0)
			{
			}
			return this.p().Count;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0004F7AC File Offset: 0x0004D9AC
		internal void i(object A_0, global::System.EventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::System.Windows.Documents.AdornerLayer adornerLayer;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (adornerLayer != null)
					{
						goto IL_68;
					}
					goto IL_E8;
				case 1:
				{
					num2 = (short)892987713;
					short num3 = num2;
					num2 = (short)461629761;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_68;
					default:
						goto IL_D1;
					}
					break;
				}
				case 2:
					adornerLayer.Remove(this);
					num2 = (short)495255553;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
				IL_68:
				num2 = (short)1787494402;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D1:
			num2 = (short)1029111808;
			if (num2 != 0)
			{
			}
			IL_E8:
			num2 = (short)327680000;
			short num4 = num2;
			return;
			IL_1C:
			num2 = (short)1595604993;
			if (num2 != 0)
			{
			}
			adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(base.AdornedElement);
			num2 = (short)1421279232;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040001FA RID: 506
		private global::System.Windows.Controls.UIElementCollection a;

		// Token: 0x040001FB RID: 507
		private global::System.Windows.UIElement b;

		// Token: 0x040001FC RID: 508
		private global::System.Windows.UIElement c;

		// Token: 0x040001FD RID: 509
		private global::System.Windows.UIElement d;

		// Token: 0x040001FE RID: 510
		private global::System.Windows.UIElement e;

		// Token: 0x040001FF RID: 511
		private global::System.Windows.UIElement f;

		// Token: 0x04000200 RID: 512
		private global::System.Windows.Rect g;

		// Token: 0x04000201 RID: 513
		private double h = 12.0;

		// Token: 0x04000202 RID: 514
		private global::System.Windows.UIElement i;
	}
}
