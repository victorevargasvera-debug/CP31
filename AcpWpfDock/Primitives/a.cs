using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using DevComponents.WpfDock.Converters;

namespace DevComponents.WpfDock.Primitives
{
	// Token: 0x02000054 RID: 84
	internal class a : global::System.Windows.Documents.Adorner
	{
		// Token: 0x06000305 RID: 773 RVA: 0x0004B50C File Offset: 0x0004970C
		static a()
		{
			int a_ = 10;
			short num = (short)534921474;
			short num2 = num;
			num = (short)1367687426;
			switch (num2 == num)
			{
			default:
			{
				num = (short)641728512;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1250361345;
			if (num != 0)
			{
			}
			num = (short)1714618368;
			if (num != 0)
			{
			}
			global::DevComponents.WpfDock.Primitives.a.a = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("藈껊ꯌ믎", a_), typeof(double), typeof(global::DevComponents.WpfDock.Primitives.d), new global::System.Windows.FrameworkPropertyMetadata(double.PositiveInfinity, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.Primitives.a.b)));
			global::DevComponents.WpfDock.Primitives.a.b = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鷈꓊뷌", a_), typeof(double), typeof(global::DevComponents.WpfDock.Primitives.d), new global::System.Windows.FrameworkPropertyMetadata(double.PositiveInfinity, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.Primitives.a.b)));
			global::DevComponents.WpfDock.Primitives.a.d = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("诈꓊만믎뻐뻒", a_), typeof(double), typeof(global::DevComponents.WpfDock.Primitives.d), new global::System.Windows.FrameworkPropertyMetadata(double.PositiveInfinity, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.Primitives.a.b)));
			global::DevComponents.WpfDock.Primitives.a.c = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鯈ꋊ꫌꟎ꗐ", a_), typeof(double), typeof(global::DevComponents.WpfDock.Primitives.d), new global::System.Windows.FrameworkPropertyMetadata(double.PositiveInfinity, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.Primitives.a.b)));
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0004B6EC File Offset: 0x000498EC
		public a(global::DevComponents.WpfDock.DockSite A_0) : base(A_0)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0004B700 File Offset: 0x00049900
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)1281228801;
			if (num != 0)
			{
			}
			num = (short)1694302208;
			short num2 = num;
			global::System.Windows.Size availableSize = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);
			global::System.Collections.IEnumerator enumerator = this.b().GetEnumerator();
			try
			{
				num = (short)797638660;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 1:
						num = (short)356974595;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1854734337;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::System.Windows.UIElement)enumerator.Current).Measure(availableSize);
						num = (short)1117346727;
						short num4 = num;
						num = (short)2057264039;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1101725696;
							if (num != 0)
							{
							}
							num = (short)83623936;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_17B;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_AF;
						}
						continue;
					}
					IL_126:
					num = (short)289144834;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_AF:
					goto IL_126;
				}
				IL_17B:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_199;
				}
				int num3;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_187:
					switch (num3)
					{
					case 0:
						disposable.Dispose();
						num = (short)181141505;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1E9;
					case 2:
						if (disposable != null)
						{
							num = (short)1434779648;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EB;
					}
					goto IL_199;
				}
				IL_1E9:
				IL_1EB:
				goto EndFinally_5;
				IL_199:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)1540489218;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_187;
				EndFinally_5:;
			}
			global::DevComponents.WpfDock.i.a(ref constraint);
			return constraint;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0004B920 File Offset: 0x00049B20
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)1013055488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Windows.Rect finalRect = global::System.Windows.Rect.Empty;
				global::System.Collections.IEnumerator enumerator = this.b().GetEnumerator();
				try
				{
					num = (short)1039466511;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Windows.UIElement uielement;
						double num3;
						switch (num2)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)1658716165;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							uielement = (global::System.Windows.UIElement)enumerator.Current;
							finalRect = new global::System.Windows.Rect(uielement.DesiredSize);
							num3 = global::DevComponents.WpfDock.Primitives.a.d(uielement);
							num = (short)1673003017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_E7;
						case 2:
							finalRect.Height = global::System.Math.Max(0.0, num3 - finalRect.Y);
							num = (short)3670017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (global::DevComponents.WpfDock.Primitives.a.b(num3))
							{
								num = (short)1074003982;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_12D;
						case 4:
							if (global::DevComponents.WpfDock.Primitives.a.b(num3))
							{
								num = (short)592773122;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E7;
						case 5:
							num = (short)159776781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_A2;
						case 7:
							finalRect.X = num3;
							num = (short)1530593286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_12D;
						case 9:
							if (global::DevComponents.WpfDock.Primitives.a.b(num3))
							{
								num = (short)615383047;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A2;
						case 10:
							finalRect.Y = num3;
							num = (short)1548877836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_1B4;
						case 13:
							goto IL_358;
						case 14:
							finalRect.Width = global::System.Math.Max(0.0, num3 - finalRect.X);
							num = (short)565706760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							switch (0)
							{
							case 0:
								goto IL_9D;
							}
							continue;
						case 16:
							if (global::DevComponents.WpfDock.Primitives.a.b(num3))
							{
								num = (short)1929248778;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B4;
						}
						goto IL_9D;
						IL_A9:
						num = (short)749338640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1B4:
						num3 = global::DevComponents.WpfDock.Primitives.a.c(uielement);
						num = (short)480496434;
						short num4 = num;
						num = (short)913034034;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A9;
						default:
							num = (short)2134704128;
							if (num != 0)
							{
							}
							num = (short)1227685891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_A2:
						num3 = global::DevComponents.WpfDock.Primitives.a.e(uielement);
						goto IL_A9;
						IL_E7:
						uielement.Arrange(finalRect);
						num = (short)16121867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_12D:
						num3 = global::DevComponents.WpfDock.Primitives.a.b(uielement);
						num = (short)1526071300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_173:
						num = (short)909508608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_9D:
						goto IL_173;
					}
					IL_358:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_377;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_364:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)1252261889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_3CB;
						case 2:
							if (disposable != null)
							{
								num = (short)1761804288;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3CD;
						}
						goto IL_377;
					}
					IL_3CB:
					IL_3CD:
					goto EndFinally_9;
					IL_377:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1857814530;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_364;
					EndFinally_9:;
				}
				num = (short)1918631936;
				short num5 = num;
				num = (short)226951169;
				if (num != 0)
				{
				}
				return finalSize;
			}
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0004BD68 File Offset: 0x00049F68
		public global::System.Windows.Controls.UIElementCollection b()
		{
			for (;;)
			{
				IL_00:
				short num = (short)717946880;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)717089600;
					short num3 = num;
					num = (short)1325525824;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
					{
						num = (short)298844160;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							num = (short)111804417;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_A3;
							}
							continue;
						case 1:
							goto IL_113;
						case 2:
							this.e = new global::System.Windows.Controls.UIElementCollection(this, this);
							num = (short)324468737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_A3:
						num = (short)1830813696;
						short num4 = num;
						if (this.e != null)
						{
							goto IL_115;
						}
						num = (short)1029308418;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
			IL_113:
			IL_115:
			return this.e;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0004BE90 File Offset: 0x0004A090
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			short num = (short)442761216;
			short num2 = num;
			num = (short)2040877193;
			short num3 = num;
			num = (short)193089673;
			switch (num3 == num)
			{
			}
			num = (short)1012858880;
			if (num != 0)
			{
			}
			num = (short)1500643329;
			if (num != 0)
			{
			}
			return this.b()[index];
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0004BF44 File Offset: 0x0004A144
		protected override int get_VisualChildrenCount()
		{
			short num = (short)2027290624;
			short num2 = num;
			num = (short)457352879;
			short num3 = num;
			num = (short)153659055;
			switch (num3 == num)
			{
			}
			num = (short)1724121089;
			if (num != 0)
			{
			}
			num = (short)1227227136;
			if (num != 0)
			{
			}
			return this.b().Count;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0004BFF8 File Offset: 0x0004A1F8
		internal static bool b(object A_0)
		{
			short num = (short)349765632;
			short num2 = num;
			num = (short)1373867183;
			short num3 = num;
			num = (short)1585286319;
			switch (num3 == num)
			{
			}
			num = (short)1374093313;
			if (num != 0)
			{
			}
			num = (short)1481179136;
			if (num != 0)
			{
			}
			return !double.IsInfinity((double)A_0);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0004C0B0 File Offset: 0x0004A2B0
		internal static bool b(double A_0)
		{
			short num = (short)1215102976;
			short num2 = num;
			num = (short)1748068369;
			short num3 = num;
			num = (short)1699112977;
			switch (num3 == num)
			{
			}
			num = (short)926875649;
			if (num != 0)
			{
			}
			num = (short)1816068096;
			if (num != 0)
			{
			}
			return !double.IsInfinity(A_0);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0004C164 File Offset: 0x0004A364
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)2143682560;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num3;
			global::System.Windows.UIElement uielement;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
				{
					if (uielement == null)
					{
						return;
					}
					num = (short)1390955531;
					short num4 = num;
					num = (short)1676233739;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D9;
					default:
						num = (short)1763901440;
						if (num != 0)
						{
						}
						num = (short)278986753;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
				{
					global::DevComponents.WpfDock.Primitives.a a = global::System.Windows.Media.VisualTreeHelper.GetParent(uielement) as global::DevComponents.WpfDock.Primitives.a;
					num = (short)947781634;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					global::DevComponents.WpfDock.Primitives.a a;
					if (a != null)
					{
						num = (short)893255683;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
				{
					global::DevComponents.WpfDock.Primitives.a a;
					a.InvalidateArrange();
					goto IL_D9;
				}
				case 4:
					goto IL_F2;
				}
				goto IL_4C;
				IL_D9:
				num = (short)880410628;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_F2:
			num = (short)541851649;
			if (num != 0)
			{
			}
			return;
			IL_4C:
			uielement = (A_0 as global::System.Windows.UIElement);
			num = (short)632881152;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0004C2D4 File Offset: 0x0004A4D4
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static double e(global::System.Windows.UIElement A_0)
		{
			int a_ = 6;
			short num = (short)1346176218;
			short num2 = num;
			num = (short)1931281626;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1746796544;
				if (num != 0)
				{
				}
				if (A_0 == null)
				{
					num = (short)1661927425;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("ꃄꯆ곈ꛊ꣌ꇎꗐ", a_));
				}
				break;
			}
			num = (short)1626734592;
			short num3 = num;
			return (double)A_0.GetValue(global::DevComponents.WpfDock.Primitives.a.b);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0004C3B0 File Offset: 0x0004A5B0
		public static void e(global::System.Windows.UIElement A_0, double A_1)
		{
			int a_ = 0;
			short num = (short)1662893311;
			short num2 = num;
			num = (short)1629469951;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)398721025;
				if (num != 0)
				{
				}
				num = (short)1981349888;
				if (num != 0)
				{
				}
				if (A_0 == null)
				{
					throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("\udabe귀ꛂ꣄ꋆꟈ뿊", a_));
				}
				break;
			}
			num = (short)2055405568;
			short num3 = num;
			A_0.SetValue(global::DevComponents.WpfDock.Primitives.a.b, A_1);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0004C48C File Offset: 0x0004A68C
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static double d(global::System.Windows.UIElement A_0)
		{
			int a_ = 6;
			short num = (short)1483338257;
			short num2 = num;
			num = (short)686158353;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1339228161;
				if (num != 0)
				{
				}
				num = (short)1382154240;
				if (num != 0)
				{
				}
				if (A_0 == null)
				{
					throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("ꃄꯆ곈ꛊ꣌ꇎꗐ", a_));
				}
				break;
			}
			num = (short)1997209600;
			short num3 = num;
			return (double)A_0.GetValue(global::DevComponents.WpfDock.Primitives.a.a);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0004C568 File Offset: 0x0004A768
		public static void d(global::System.Windows.UIElement A_0, double A_1)
		{
			int a_ = 18;
			short num = (short)1687134101;
			short num2 = num;
			num = (short)2040766357;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1073545217;
				if (num != 0)
				{
				}
				num = (short)414908416;
				if (num != 0)
				{
				}
				if (A_0 == null)
				{
					throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("듐뿒냔뫖볘뗚꧜", a_));
				}
				break;
			}
			num = (short)1077018624;
			short num3 = num;
			A_0.SetValue(global::DevComponents.WpfDock.Primitives.a.a, A_1);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0004C648 File Offset: 0x0004A848
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static double c(global::System.Windows.UIElement A_0)
		{
			int a_ = 12;
			short num = (short)1211337347;
			short num2 = num;
			num = (short)1869318787;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)596770816;
				if (num != 0)
				{
				}
				num = (short)100007937;
				if (num != 0)
				{
				}
				if (A_0 == null)
				{
					throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("껊ꇌ꫎볐뛒믔ꏖ", a_));
				}
				break;
			}
			num = (short)2024079360;
			short num3 = num;
			return (double)A_0.GetValue(global::DevComponents.WpfDock.Primitives.a.c);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0004C724 File Offset: 0x0004A924
		public static void c(global::System.Windows.UIElement A_0, double A_1)
		{
			int a_ = 0;
			short num = (short)155231253;
			short num2 = num;
			num = (short)94348309;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)487981057;
				if (num != 0)
				{
				}
				num = (short)601161728;
				if (num != 0)
				{
				}
				if (A_0 == null)
				{
					throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("\udabe귀ꛂ꣄ꋆꟈ뿊", a_));
				}
				break;
			}
			num = (short)909312000;
			short num3 = num;
			A_0.SetValue(global::DevComponents.WpfDock.Primitives.a.c, A_1);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0004C800 File Offset: 0x0004AA00
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static double b(global::System.Windows.UIElement A_0)
		{
			int a_ = 9;
			short num = (short)1843789825;
			if (num != 0)
			{
			}
			num = (short)1173592027;
			short num2 = num;
			num = (short)936482779;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1958477824;
				if (num != 0)
				{
				}
				if (A_0 == null)
				{
					throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("귇ꛉ꧋ꏍ뗏병ꃓ", a_));
				}
				break;
			}
			num = (short)1640562688;
			short num3 = num;
			return (double)A_0.GetValue(global::DevComponents.WpfDock.Primitives.a.d);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0004C8E0 File Offset: 0x0004AAE0
		public static void b(global::System.Windows.UIElement A_0, double A_1)
		{
			int a_ = 3;
			short num = (short)1433299029;
			short num2 = num;
			num = (short)1758095445;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)876544001;
				if (num != 0)
				{
				}
				num = (short)506068992;
				if (num != 0)
				{
				}
				if (A_0 == null)
				{
					throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("ꟁꣃꏅꗇ꿉ꋋ뫍", a_));
				}
				break;
			}
			num = (short)415956992;
			short num3 = num;
			A_0.SetValue(global::DevComponents.WpfDock.Primitives.a.d, A_1);
		}

		// Token: 0x040001F2 RID: 498
		public static readonly global::System.Windows.DependencyProperty a;

		// Token: 0x040001F3 RID: 499
		public static readonly global::System.Windows.DependencyProperty b;

		// Token: 0x040001F4 RID: 500
		public static readonly global::System.Windows.DependencyProperty c;

		// Token: 0x040001F5 RID: 501
		public static readonly global::System.Windows.DependencyProperty d;

		// Token: 0x040001F6 RID: 502
		private global::System.Windows.Controls.UIElementCollection e;
	}
}
