using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000009 RID: 9
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ColorContrast : global::System.Windows.Controls.Control
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00007030 File Offset: 0x00005230
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000070EC File Offset: 0x000052EC
		public global::System.Windows.Media.Color? SelectedColor
		{
			get
			{
				short num = (short)1178683392;
				short num2 = num;
				num = (short)2032224256;
				switch (num2 == num)
				{
				}
				num = (short)1929773057;
				if (num != 0)
				{
				}
				num = (short)1656029184;
				short num3 = num;
				num = (short)226099200;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Color?)base.GetValue(global::DevComponents.WpfEditors.ColorContrast.SelectedColorProperty);
			}
			set
			{
				short num = (short)176319386;
				short num2 = num;
				num = (short)1041001370;
				switch (num2 == num)
				{
				}
				num = (short)384303105;
				if (num != 0)
				{
				}
				num = (short)1547436032;
				short num3 = num;
				num = (short)368902144;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.ColorContrast.SelectedColorProperty, value);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000071A8 File Offset: 0x000053A8
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.ColorContrast colorContrast;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_FF;
				case 1:
					colorContrast.OnSelectedColorChanged((global::System.Windows.Media.Color?)A_1.OldValue, (global::System.Windows.Media.Color?)A_1.NewValue);
					num2 = (short)1540947968;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1227346029;
					short num3 = num2;
					num2 = (short)2121060461;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)2098987008;
						short num4 = num2;
						num2 = (short)503971840;
						if (num2 != 0)
						{
						}
						if (colorContrast != null)
						{
							num2 = (short)728432641;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_101;
					}
					}
					break;
				}
				}
				goto IL_1C;
			}
			IL_FF:
			IL_101:
			num2 = (short)1860763649;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			colorContrast = (A_0 as global::DevComponents.WpfEditors.ColorContrast);
			num2 = (short)1403518978;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000072E0 File Offset: 0x000054E0
		protected virtual void OnSelectedColorChanged(global::System.Windows.Media.Color? oldValue, global::System.Windows.Media.Color? newValue)
		{
			short num = (short)1565026719;
			short num2 = num;
			num = (short)1046243743;
			switch (num2 == num)
			{
			}
			num = (short)823263232;
			if (num != 0)
			{
			}
			num = (short)1029046272;
			short num3 = num;
			num = (short)123731969;
			if (num != 0)
			{
			}
			this.OnSelectedColorChanged();
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600003F RID: 63 RVA: 0x00007394 File Offset: 0x00005594
		// (remove) Token: 0x06000040 RID: 64 RVA: 0x0000744C File Offset: 0x0000564C
		public event global::System.Windows.RoutedEventHandler SelectedColorChanged
		{
			add
			{
				short num = (short)81743247;
				short num2 = num;
				num = (short)206392719;
				switch (num2 == num)
				{
				}
				num = (short)1251213313;
				if (num != 0)
				{
				}
				num = (short)942866432;
				short num3 = num;
				num = (short)1220411392;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.ColorContrast.SelectedColorChangedEvent, value);
			}
			remove
			{
				short num = (short)1713357850;
				short num2 = num;
				num = (short)1703789594;
				switch (num2 == num)
				{
				}
				num = (short)3670016;
				if (num != 0)
				{
				}
				num = (short)930283520;
				short num3 = num;
				num = (short)211812353;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.ColorContrast.SelectedColorChangedEvent, value);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00007500 File Offset: 0x00005700
		protected virtual void OnSelectedColorChanged()
		{
			short num = (short)1739249217;
			short num2 = num;
			num = (short)915396161;
			switch (num2 == num)
			{
			}
			num = (short)549322752;
			if (num != 0)
			{
			}
			num = (short)1103298560;
			short num3 = num;
			num = (short)86835201;
			if (num != 0)
			{
			}
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.ColorContrast.SelectedColorChangedEvent);
			base.RaiseEvent(e);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000075BC File Offset: 0x000057BC
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00007674 File Offset: 0x00005874
		public global::System.Windows.Media.Color BaseColor
		{
			get
			{
				short num = (short)643942436;
				short num2 = num;
				num = (short)1340131364;
				switch (num2 == num)
				{
				}
				num = (short)459800576;
				if (num != 0)
				{
				}
				num = (short)1201864704;
				short num3 = num;
				num = (short)1130364929;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Color)base.GetValue(global::DevComponents.WpfEditors.ColorContrast.BaseColorProperty);
			}
			set
			{
				short num = (short)2104757413;
				short num2 = num;
				num = (short)447417509;
				switch (num2 == num)
				{
				}
				num = (short)2015166465;
				if (num != 0)
				{
				}
				num = (short)663289856;
				short num3 = num;
				num = (short)1355415552;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.ColorContrast.BaseColorProperty, value);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00007730 File Offset: 0x00005930
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.ColorContrast colorContrast;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					num2 = (short)544014337;
					if (num2 != 0)
					{
					}
					colorContrast.OnBaseColorChanged((global::System.Windows.Media.Color)A_1.OldValue, (global::System.Windows.Media.Color)A_1.NewValue);
					num2 = (short)1220673536;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1446539197;
					short num3 = num2;
					num2 = (short)1317105597;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1532362752;
						short num4 = num2;
						num2 = (short)346095616;
						if (num2 != 0)
						{
						}
						if (colorContrast != null)
						{
							num2 = (short)1086717953;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			colorContrast = (A_0 as global::DevComponents.WpfEditors.ColorContrast);
			num2 = (short)1677262850;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00007864 File Offset: 0x00005A64
		protected virtual void OnBaseColorChanged(global::System.Windows.Media.Color oldValue, global::System.Windows.Media.Color newValue)
		{
			short num = (short)1824100665;
			short num2 = num;
			num = (short)1455526201;
			switch (num2 == num)
			{
			}
			num = (short)1311703041;
			if (num != 0)
			{
			}
			num = (short)1996750848;
			short num3 = num;
			num = (short)1445724160;
			if (num != 0)
			{
			}
			double num4 = 0.0;
			double num5 = 0.0;
			double a_ = 0.0;
			this.a(this.BaseColor, ref num4, ref num5, ref a_);
			this.a(a_);
			this.OnSelectedColorChanged();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000794C File Offset: 0x00005B4C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::System.Windows.Size result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_102;
				case 1:
					result.Width = 19.0;
					num2 = (short)1546452992;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)663028875;
					short num3 = num2;
					num2 = (short)1381958795;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1815674880;
						short num4 = num2;
						num2 = (short)1024327680;
						if (num2 != 0)
						{
						}
						if (result.Width < 19.0)
						{
							num2 = (short)825360385;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				}
				goto IL_1C;
			}
			IL_102:
			num2 = (short)143196161;
			if (num2 != 0)
			{
			}
			return result;
			IL_1C:
			result = base.MeasureOverride(constraint);
			num2 = (short)72220674;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00007A84 File Offset: 0x00005C84
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			short num = (short)1997602816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				global::System.Windows.Rect rectangle2;
				double num3;
				double num4;
				double num6;
				double num7;
				double a_2;
				double a_3;
				int num8;
				for (;;)
				{
					IL_27:
					num = (short)649723905;
					if (num != 0)
					{
					}
					global::System.Windows.Rect rectangle;
					global::System.Windows.Media.SolidColorBrush brush;
					switch (num2)
					{
					case 0:
						rectangle.Height -= rectangle.Bottom - rectangle2.Bottom;
						num = (short)1507131393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_456;
					case 2:
						num = (short)1170800647;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (rectangle.Bottom > rectangle2.Bottom)
						{
							num = (short)1853358080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_456;
					case 4:
						goto IL_4BE;
					case 5:
						goto IL_4BE;
					case 6:
						if (this.a == null)
						{
							num = (short)371392523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DD;
					case 7:
						if (this.b >= 0.0)
						{
							num = (short)1701773324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_503;
					case 8:
						try
						{
							num3 = rectangle2.Height * (1.0 - this.b);
							num4 = rectangle2.Width - 6.0;
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext;
							streamGeometryContext.BeginFigure(new global::System.Windows.Point(num4, num3), true, true);
							streamGeometryContext.LineTo(new global::System.Windows.Point(num4 + 7.0, num3 - 4.0), true, true);
							streamGeometryContext.LineTo(new global::System.Windows.Point(num4 + 7.0, num3 + 4.0), true, true);
							streamGeometryContext.Close();
							goto IL_325;
						}
						finally
						{
							num = (short)1111162882;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.Media.StreamGeometryContext streamGeometryContext;
								switch (num2)
								{
								case 0:
									goto IL_2A7;
								case 1:
									((global::System.IDisposable)streamGeometryContext).Dispose();
									num = (short)983564288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_221;
									}
									continue;
								}
								IL_221:
								num = (short)2118902566;
								short num5 = num;
								num = (short)2008474406;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2A9;
								default:
									num = (short)718012416;
									if (num != 0)
									{
									}
									if (streamGeometryContext == null)
									{
										goto IL_2A9;
									}
									num = (short)995819521;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_2A7:
							IL_2A9:;
						}
						goto IL_2AA;
						IL_325:
						this.a.Freeze();
						num = (short)2019426317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_408;
					case 10:
					{
						if (num6 > rectangle2.Height - num7)
						{
							num = (short)1710358530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						double a_ = 1.0 - num6 / rectangle2.Height;
						brush = new global::System.Windows.Media.SolidColorBrush(this.a(a_2, a_3, a_));
						rectangle = new global::System.Windows.Rect(num4, num3, (double)num8, num7 + 0.5);
						num = (short)1177616387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						this.a = new global::System.Windows.Media.StreamGeometry();
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext = this.a.Open();
						num = (short)973537288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_2AA;
					case 13:
						goto IL_3DD;
					}
					goto IL_8E;
					IL_2AA:
					num = (short)1008533510;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DD:
					drawingContext.DrawGeometry(global::System.Windows.Media.Brushes.Black, null, this.a);
					num = (short)575930377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_456:
					drawingContext.DrawRectangle(brush, null, rectangle);
					num3 += num7;
					num6 += num7;
					num = (short)1181679620;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4BE:
					num = (short)2061762570;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_408:
				IL_503:
				num = (short)1040187392;
				short num9 = num;
				return;
				IL_8E:
				base.OnRender(drawingContext);
				rectangle2 = new global::System.Windows.Rect(base.RenderSize);
				drawingContext.DrawRectangle(global::System.Windows.Media.Brushes.Transparent, null, rectangle2);
				global::System.Windows.Media.Color baseColor = this.BaseColor;
				byte r = baseColor.R;
				byte g = baseColor.G;
				byte b = baseColor.B;
				num7 = rectangle2.Height / global::System.Math.Floor(rectangle2.Height / 4.0);
				num8 = 12;
				num4 = rectangle2.X;
				num3 = rectangle2.Y;
				a_2 = 0.0;
				a_3 = 0.0;
				double num10 = 0.0;
				this.a(baseColor, ref a_2, ref a_3, ref num10);
				num6 = rectangle2.Y;
				num = (short)366084101;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00007FD0 File Offset: 0x000061D0
		private void a(global::System.Windows.Media.Color A_0, ref double A_1, ref double A_2, ref double A_3)
		{
			short num = (short)1463536836;
			short num2 = num;
			num = (short)1946078404;
			switch (num2 == num)
			{
			}
			num = (short)292683777;
			if (num != 0)
			{
			}
			num = (short)2031288320;
			short num3 = num;
			num = (short)822214656;
			if (num != 0)
			{
			}
			A_1 = (double)global::DevComponents.WpfEditors.c.c(A_0) / 360.0;
			A_3 = (double)global::DevComponents.WpfEditors.c.b(A_0);
			A_2 = (double)global::DevComponents.WpfEditors.c.a(A_0);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000809C File Offset: 0x0000629C
		private global::System.Windows.Media.Color a(double A_0, double A_1, double A_2)
		{
			short num = (short)1205403648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AA;
				}
				double num6;
				double num5;
				double num4;
				for (;;)
				{
					IL_27:
					double[] array;
					int num3;
					double[] array2;
					double num7;
					double num8;
					double num9;
					switch (num2)
					{
					case 0:
						if (array[num3] < 0.0)
						{
							num = (short)1759707147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_587;
					case 1:
						if (2.0 * array[num3] < 1.0)
						{
							num = (short)2021851160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)249692170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (array[num3] > 1.0)
						{
							num = (short)1317470215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_133;
					case 3:
						goto IL_375;
					case 4:
						goto IL_133;
					case 5:
						num4 = (num5 = (num6 = 0.0));
						num = (short)1093468174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						array2[num3] = num7 + (num8 - num7) * array[num3] * 6.0;
						num = (short)1046020097;
						if (num != 0)
						{
						}
						num = (short)396099605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						array[num3] -= 1.0;
						num = (short)1052311556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num6 = A_2;
						num4 = A_2;
						num5 = A_2;
						num = (short)1054670873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_32A;
					case 10:
						if (3.0 * array[num3] < 2.0)
						{
							num = (short)596705310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array2[num3] = num7;
						num = (short)756744201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						array[num3] += 1.0;
						num = (short)439353373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num9 = A_2 * (1.0 + A_1);
						goto IL_434;
					case 13:
					{
						if (num3 < 3)
						{
							num = (short)887619584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1263766185;
						short num10 = num;
						num = (short)1381993129;
						switch ((num10 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_50C;
						default:
							num = (short)355532800;
							if (num != 0)
							{
							}
							num = (short)1229520912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 14:
						goto IL_3EA;
					case 15:
						if (A_2 > 0.5)
						{
							num = (short)525860881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1979973644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num5 = array2[0];
						num4 = array2[1];
						num6 = array2[2];
						num = (short)1198260227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)2073559068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_32A;
					case 19:
						goto IL_244;
					case 20:
						if (A_2 == 0.0)
						{
							num = (short)56819717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)549584919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_32A;
					case 22:
						if (6.0 * array[num3] < 1.0)
						{
							num = (short)1542586374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50C;
					case 23:
						if (A_1 == 0.0)
						{
							num = (short)1293811720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)951779343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						num = (short)235995136;
						short num11 = num;
						array2[num3] = num8;
						num = (short)2025127954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_1EF;
					case 26:
						goto IL_244;
					case 27:
						goto IL_32A;
					case 28:
						num9 = A_2 + A_1 - A_2 * A_1;
						goto IL_434;
					case 29:
						goto IL_587;
					case 30:
						array2[num3] = num7 + (num8 - num7) * (0.6666666666666666 - array[num3]) * 6.0;
						num = (short)1935147035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AA;
					IL_133:
					num = (short)1325400086;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_244:
					num = (short)1604059149;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32A:
					num3++;
					num = (short)1928069139;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_434:
					num8 = num9;
					num7 = 2.0 * A_2 - num8;
					array = new double[]
					{
						A_0 + 0.3333333333333333,
						A_0,
						A_0 - 0.3333333333333333
					};
					array2 = new double[3];
					num3 = 0;
					num = (short)363462682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_50C:
					num = (short)875757569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_587:
					num = (short)1735458818;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1EF:
				IL_375:
				IL_3EA:
				return global::System.Windows.Media.Color.FromArgb(byte.MaxValue, (byte)(255.0 * num5), (byte)(255.0 * num4), (byte)(255.0 * num6));
				IL_AA:
				num5 = 0.0;
				num4 = 0.0;
				num6 = 0.0;
				num = (short)1707474964;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000874C File Offset: 0x0000694C
		private void a(double A_0)
		{
			short num = (short)1860501504;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_40;
				}
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						goto IL_190;
					case 1:
					{
						num = (short)1242461485;
						short num3 = num;
						num = (short)755856685;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D9;
						default:
							num = (short)691535872;
							if (num != 0)
							{
							}
							if (this.b >= 0.0)
							{
								num = (short)322830338;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.SelectedColor = null;
							num = (short)948436995;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_D9;
					case 3:
						goto IL_103;
					}
					goto IL_40;
					IL_D9:
					num = (short)32768001;
					if (num != 0)
					{
					}
					double a_ = 0.0;
					double a_2 = 0.0;
					double num4 = 0.0;
					this.a(this.BaseColor, ref a_, ref a_2, ref num4);
					this.SelectedColor = new global::System.Windows.Media.Color?(this.a(a_, a_2, this.b));
					num = (short)1059389440;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_103:
				IL_190:
				num = (short)130088960;
				short num5 = num;
				base.InvalidateVisual();
				return;
				IL_40:
				this.b = A_0;
				this.a = null;
				num = (short)1639645185;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000891C File Offset: 0x00006B1C
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			global::System.Windows.Size renderSize;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_1A6;
				case 1:
				{
					global::System.Windows.Point position;
					if (position.Y >= 0.0)
					{
						num2 = (short)1843527688;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23A;
				}
				case 2:
					if (e.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
					{
						num2 = (short)207355907;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23A;
				case 3:
				{
					num2 = (short)1769105634;
					short num3 = num2;
					num2 = (short)20998370;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1449000960;
						if (num2 != 0)
						{
						}
						break;
					}
					num2 = (short)257294337;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					if (renderSize.Height == 0.0)
					{
						num2 = (short)1281228805;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.Windows.Point position = e.GetPosition(this);
					num2 = (short)1487142914;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_7C;
				case 6:
				{
					global::System.Windows.Point position;
					double y = position.Y;
					renderSize = base.RenderSize;
					if (y < renderSize.Height)
					{
						num2 = (short)962527239;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23A;
				}
				case 7:
				{
					double num4 = 1.0;
					global::System.Windows.Point position;
					double y2 = position.Y;
					renderSize = base.RenderSize;
					double a_ = num4 - y2 / renderSize.Height;
					this.a(a_);
					num2 = (short)965345280;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					num2 = (short)733216774;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_34;
			}
			IL_7C:
			num2 = (short)939065345;
			if (num2 != 0)
			{
			}
			num2 = (short)909443072;
			short num5 = num2;
			return;
			IL_1A6:
			IL_23A:
			base.OnMouseMove(e);
			return;
			IL_34:
			renderSize = base.RenderSize;
			num2 = (short)1840971780;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00008B6C File Offset: 0x00006D6C
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			while (base.RenderSize.Height != 0.0)
			{
				short num = (short)331260044;
				short num2 = num;
				num = (short)271491212;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)444203008;
					short num3 = num;
					break;
				}
				}
				num = (short)1914503169;
				if (num != 0)
				{
				}
				num = (short)1476001792;
				if (num != 0)
				{
				}
				double a_ = 1.0 - e.GetPosition(this).Y / base.RenderSize.Height;
				this.a(a_);
				base.CaptureMouse();
				base.OnMouseLeftButtonDown(e);
				return;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00008C74 File Offset: 0x00006E74
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1219428353;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1711540860;
					short num3 = num;
					num = (short)1997539964;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7E;
					default:
						goto IL_C8;
					}
					break;
				}
				case 1:
					num = (short)1566375937;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				case 2:
					base.ReleaseMouseCapture();
					goto IL_7E;
				}
				IL_57:
				if (base.IsMouseCaptured)
				{
					num = (short)871038978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_108;
				IL_7E:
				num = (short)810680320;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C8:
			num = (short)213581824;
			short num4 = num;
			num = (short)1016791040;
			if (num != 0)
			{
			}
			IL_108:
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00008DB4 File Offset: 0x00006FB4
		// Note: this type is marked as 'beforefieldinit'.
		static ColorContrast()
		{
			int a_ = 19;
			short num = (short)54367500;
			short num2 = num;
			num = (short)1015584012;
			switch (num2 == num)
			{
			}
			num = (short)1971060736;
			short num3 = num;
			num = (short)1891565569;
			if (num != 0)
			{
			}
			num = (short)1232338944;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.ColorContrast.SelectedColorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("돟蟡裣菥诧黩觫諭돯鷱飳駵諷", a_), typeof(global::System.Windows.Media.Color?), typeof(global::DevComponents.WpfEditors.ColorContrast), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.ColorContrast.b)));
			global::DevComponents.WpfEditors.ColorContrast.SelectedColorChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("돟蟡裣菥诧黩觫諭돯鷱飳駵諷맹铻鿽滿攁愃戅", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.ColorContrast));
			global::DevComponents.WpfEditors.ColorContrast.BaseColorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꋟ菡韣菥ꯧ藩胫臭苯", a_), typeof(global::System.Windows.Media.Color), typeof(global::DevComponents.WpfEditors.ColorContrast), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Media.Colors.White, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.ColorContrast.a)));
		}

		// Token: 0x04000014 RID: 20
		public static readonly global::System.Windows.DependencyProperty SelectedColorProperty;

		// Token: 0x04000016 RID: 22
		public static readonly global::System.Windows.DependencyProperty BaseColorProperty;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Media.StreamGeometry a;

		// Token: 0x04000018 RID: 24
		private double b = -1.0;
	}
}
