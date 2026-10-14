using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000006 RID: 6
	[global::System.ComponentModel.DesignTimeVisible(true)]
	public class ColorComb : global::System.Windows.Controls.Canvas
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00003E30 File Offset: 0x00002030
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.ColorComb colorComb;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_12A;
				case 1:
					num2 = (short)1735262209;
					if (num2 != 0)
					{
					}
					colorComb.OnSelectedColorChanged((global::System.Windows.Media.Color?)A_1.OldValue, (global::System.Windows.Media.Color?)A_1.NewValue);
					num2 = (short)1015349248;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (colorComb != null)
					{
						num2 = (short)1112145921;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				break;
			}
			IL_1C:
			colorComb = (A_0 as global::DevComponents.WpfEditors.ColorComb);
			num2 = (short)1573444613;
			short num3 = num2;
			num2 = (short)236706821;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_12A:
				return;
			case 1:
				break;
			default:
			{
				num2 = (short)1699414016;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)139395072;
			if (num2 != 0)
			{
			}
			num2 = (short)1983381506;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003F6C File Offset: 0x0000216C
		protected virtual void OnSelectedColorChanged(global::System.Windows.Media.Color? oldValue, global::System.Windows.Media.Color? newValue)
		{
			short num = (short)208470016;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				bool flag;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						num = (short)50855936;
						short num3 = num;
						try
						{
							num = (short)243269640;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Windows.Media.Color color;
									if (color.Equals(newValue))
									{
										num = (short)316407815;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)786169862;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfEditors.CombCell combCell = ((global::System.Windows.UIElement)enumerator.Current) as global::DevComponents.WpfEditors.CombCell;
									num = (short)1184759812;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::DevComponents.WpfEditors.CombCell combCell;
									global::System.Windows.Media.Color color = combCell.Color;
									num = (short)1992753152;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_2B6;
								case 4:
								{
									global::DevComponents.WpfEditors.CombCell combCell;
									if (combCell != null)
									{
										num = (short)386924546;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_1C1;
								case 6:
									num = (short)1181548547;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::DevComponents.WpfEditors.CombCell combCell;
									combCell.IsSelected = true;
									flag = true;
									num = (short)541392901;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_1A0;
									}
									continue;
								}
								IL_1C6:
								num = (short)846266369;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A0:
								goto IL_1C6;
							}
							IL_1C1:
							IL_2B6:
							goto IL_7F;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2D8;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2C5:
								switch (num2)
								{
								case 0:
									goto IL_381;
								case 1:
									disposable.Dispose();
									num = (short)1669791744;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)643235841;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_383;
								}
								break;
							}
							IL_2D8:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)269358957;
							short num4 = num;
							num = (short)706090861;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_381:
								break;
							default:
								num = (short)1756299264;
								if (num != 0)
								{
								}
								num = (short)481689602;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_2C5;
							}
							IL_383:;
						}
						goto IL_384;
					}
					case 1:
					{
						num = (short)1855455233;
						if (num != 0)
						{
						}
						global::System.Collections.IEnumerator enumerator = base.Children.GetEnumerator();
						num = (short)1971847168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_150;
					case 3:
						if (!flag)
						{
							num = (short)905052164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_384;
					case 4:
						this.Selection.g();
						num = (short)641728514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (newValue != null)
						{
							num = (short)1570963457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7F;
					}
					goto IL_47;
					IL_7F:
					num = (short)2005794819;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_150:
				IL_384:
				this.OnSelectedColorChanged();
				return;
				IL_47:
				flag = false;
				num = (short)1711603717;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00004320 File Offset: 0x00002520
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000043DC File Offset: 0x000025DC
		[global::System.ComponentModel.Category("Appearance")]
		public global::System.Windows.Media.Color? SelectedColor
		{
			get
			{
				short num = (short)214815641;
				short num2 = num;
				num = (short)29938585;
				switch (num2 == num)
				{
				}
				num = (short)906625025;
				if (num != 0)
				{
				}
				num = (short)637665280;
				short num3 = num;
				num = (short)123469824;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Color?)base.GetValue(global::DevComponents.WpfEditors.ColorComb.SelectedColorProperty);
			}
			set
			{
				short num = (short)1057213888;
				short num2 = num;
				num = (short)2136919488;
				switch (num2 == num)
				{
				}
				num = (short)1014562817;
				if (num != 0)
				{
				}
				num = (short)1159004160;
				short num3 = num;
				num = (short)488112128;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.ColorComb.SelectedColorProperty, value);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600001A RID: 26 RVA: 0x00004498 File Offset: 0x00002698
		// (remove) Token: 0x0600001B RID: 27 RVA: 0x00004548 File Offset: 0x00002748
		public event global::System.Windows.RoutedEventHandler SelectedColorChanged
		{
			add
			{
				short num = (short)386340754;
				short num2 = num;
				num = (short)497817490;
				switch (num2 == num)
				{
				}
				num = (short)986644481;
				if (num != 0)
				{
				}
				num = (short)1694760960;
				short num3 = num;
				num = (short)1401815040;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.ColorComb.SelectedColorChangedEvent, value);
			}
			remove
			{
				short num = (short)1513991011;
				short num2 = num;
				num = (short)134458211;
				switch (num2 == num)
				{
				}
				num = (short)637468673;
				if (num != 0)
				{
				}
				num = (short)333512704;
				short num3 = num;
				num = (short)723976192;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.ColorComb.SelectedColorChangedEvent, value);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00004600 File Offset: 0x00002800
		protected virtual void OnSelectedColorChanged()
		{
			short num = (short)1080838632;
			short num2 = num;
			num = (short)496912872;
			switch (num2 == num)
			{
			}
			num = (short)2102722561;
			if (num != 0)
			{
			}
			num = (short)1813512192;
			short num3 = num;
			num = (short)1356464128;
			if (num != 0)
			{
			}
			global::System.Windows.RoutedEventArgs routedEventArgs = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.ColorComb.SelectedColorChangedEvent);
			base.RaiseEvent(routedEventArgs);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000046B8 File Offset: 0x000028B8
		public ColorComb()
		{
			for (int i = 0; i < 142; i++)
			{
				base.Children.Add(new global::DevComponents.WpfEditors.CombCell());
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004730 File Offset: 0x00002930
		static ColorComb()
		{
			int a_ = 16;
			short num = (short)19701061;
			short num2 = num;
			num = (short)442146117;
			switch (num2 == num)
			{
			}
			num = (short)1635450881;
			if (num != 0)
			{
			}
			num = (short)1400373248;
			short num3 = num;
			num = (short)602406912;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.ColorComb.SelectedColorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("軜뫞跠蛢蛤鏦賨迪껬胮鷰鳲蟴", a_), typeof(global::System.Windows.Media.Color?), typeof(global::DevComponents.WpfEditors.ColorComb), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.ColorComb.a)));
			global::DevComponents.WpfEditors.ColorComb.SelectedColorChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("軜뫞跠蛢蛤鏦賨迪껬胮鷰鳲蟴듶釸髺鏼飾搀朂", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.ColorComb));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfEditors.ColorComb), global::System.Windows.Controls.Primitives.Selector.SelectedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfEditors.ColorComb.b));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfEditors.ColorComb), global::System.Windows.Controls.Primitives.Selector.UnselectedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfEditors.ColorComb.a));
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004894 File Offset: 0x00002A94
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_28D;
				case 1:
					if (constraint.Width == double.PositiveInfinity)
					{
						num2 = (short)2106130436;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B9;
				case 2:
					goto IL_140;
				case 3:
					num2 = (short)2017722369;
					if (num2 != 0)
					{
					}
					if (!double.IsNaN(base.Width))
					{
						num2 = (short)814022669;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2066677765;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1370882054;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (!double.IsNaN(base.Height))
					{
						goto IL_324;
					}
					num2 = (short)1084555265;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (constraint.Height == double.PositiveInfinity)
					{
						num2 = (short)1364000770;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B9;
				case 7:
					goto IL_F9;
				case 8:
					goto IL_33B;
				case 9:
					goto IL_1E3;
				case 10:
					if (double.IsPositiveInfinity(constraint.Width))
					{
						num2 = (short)934805511;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)283443211;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (double.IsPositiveInfinity(constraint.Height))
					{
						num2 = (short)357171209;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_340;
				case 12:
				{
					if (!double.IsNaN(base.Height))
					{
						num2 = (short)1914634240;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1853471642;
					short num3 = num2;
					num2 = (short)880524186;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_324;
					default:
						goto IL_17B;
					}
					break;
				}
				case 13:
					num2 = (short)892338188;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_48;
				IL_B9:
				num2 = (short)472645642;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_324:
				num2 = (short)1264386056;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F9:
			double num4 = this.a(constraint.Height);
			return new global::System.Windows.Size((double)this.d * num4, constraint.Height);
			IL_140:
			return new global::System.Windows.Size(164.0, 164.0);
			IL_17B:
			num2 = (short)384499712;
			if (num2 != 0)
			{
			}
			return new global::System.Windows.Size(base.Width, base.Width);
			IL_1E3:
			double num5 = this.a(constraint.Width) * 2.0;
			return new global::System.Windows.Size(constraint.Width, num5 * (double)this.d);
			IL_28D:
			return new global::System.Windows.Size(base.Width, base.Height);
			IL_33B:
			return new global::System.Windows.Size(base.Height, base.Height);
			IL_340:
			num2 = (short)379781120;
			short num6 = num2;
			return new global::System.Windows.Size(global::System.Math.Min(constraint.Width, constraint.Height), global::System.Math.Min(constraint.Width, constraint.Height));
			IL_48:
			base.MeasureOverride(constraint);
			num2 = (short)391577603;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004C38 File Offset: 0x00002E38
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeSize)
		{
			short num = (short)696057856;
			short num2 = num;
			num = (short)223413392;
			short num3 = num;
			num = (short)1089012880;
			switch (num3 == num)
			{
			}
			num = (short)665255937;
			if (num != 0)
			{
			}
			num = (short)1813446656;
			if (num != 0)
			{
			}
			return base.ArrangeOverride(arrangeSize);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004CE8 File Offset: 0x00002EE8
		protected override void OnRenderSizeChanged(global::System.Windows.SizeChangedInfo sizeInfo)
		{
			short num = (short)1444872192;
			short num2 = num;
			num = (short)1957999264;
			short num3 = num;
			num = (short)357544608;
			switch (num3 == num)
			{
			}
			num = (short)1427439617;
			if (num != 0)
			{
			}
			num = (short)1357774848;
			if (num != 0)
			{
			}
			this.a(new global::System.Windows.Rect(base.RenderSize));
			base.OnRenderSizeChanged(sizeInfo);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004DA8 File Offset: 0x00002FA8
		private double a(double A_0)
		{
			short num = (short)1799421952;
			short num2 = num;
			num = (short)322568193;
			if (num != 0)
			{
			}
			num = (short)1962049567;
			short num3 = num;
			num = (short)538214431;
			switch (num3 == num)
			{
			}
			num = (short)961806336;
			if (num != 0)
			{
			}
			double val = A_0 / (double)(2 * this.d - 1);
			return global::System.Math.Max(1.0, val);
		}

		// Token: 0x17000005 RID: 5
		private global::DevComponents.WpfEditors.CombCell this[int A_0]
		{
			get
			{
				short num = (short)1746599936;
				short num2 = num;
				num = (short)214595245;
				short num3 = num;
				num = (short)1698592429;
				switch (num3 == num)
				{
				}
				num = (short)112001024;
				if (num != 0)
				{
				}
				num = (short)590282753;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfEditors.CombCell)base.Children[A_0];
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004F28 File Offset: 0x00003128
		private static void a(global::DevComponents.WpfEditors.CombCell A_0, global::System.Windows.Media.Color A_1, double A_2, double A_3, double A_4)
		{
			short num = (short)1841889280;
			short num2 = num;
			num = (short)1259535419;
			short num3 = num;
			num = (short)782892091;
			switch (num3 == num)
			{
			}
			num = (short)350420993;
			if (num != 0)
			{
			}
			num = (short)1132658688;
			if (num != 0)
			{
			}
			A_0.Color = A_1;
			A_0.Width = A_2;
			A_0.Height = A_2;
			global::System.Windows.Controls.Canvas.SetTop(A_0, A_4);
			global::System.Windows.Controls.Canvas.SetLeft(A_0, A_3);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004FF8 File Offset: 0x000031F8
		private void a(global::System.Windows.Rect A_0)
		{
			short num = (short)1610416128;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Windows.Rect rect;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_28:
						int num4;
						double num6;
						double num5;
						double num7;
						int num9;
						int num13;
						int num17;
						int num18;
						switch (num2)
						{
						case 0:
							goto IL_5BF;
						case 1:
							goto IL_28A;
						case 2:
						{
							int num3;
							num3++;
							num = (short)1958805523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (num4 == 7)
							{
								num = (short)851836933;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3E6;
						case 4:
							goto IL_3E6;
						case 5:
							num = (short)1636696065;
							if (num != 0)
							{
							}
							num5 = rect.X + num6 * 3.0;
							num7 += num6 * 0.6800000071525574;
							num = (short)583401476;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_148;
						case 7:
						{
							int num8;
							if (num8 >= num9)
							{
								num = (short)1116274690;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							double num11;
							double num12;
							float num10 = this.a(num11 - num5, num12 - num7);
							double a_ = 0.936 * (double)(this.d - num9) / (double)this.d + 0.12;
							global::DevComponents.WpfEditors.ColorComb.a(this[num13], this.a((double)num10, a_, 1.0), num6, num11, num12);
							num13++;
							double num14;
							num11 += num14;
							double num15;
							num12 += num15;
							num8++;
							num = (short)1124597760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							rect.Inflate(-(rect.Width - rect.Height) / 2.0, 0.0);
							num = (short)274595851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_2CE;
						case 10:
						{
							if (num9 >= this.d)
							{
								num = (short)1078460432;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)803678751;
							short num16 = num;
							num = (short)672803359;
							switch ((num16 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_A6;
							default:
							{
								num = (short)231800832;
								if (num != 0)
								{
								}
								double num11 = num5 + num6 * (double)num9;
								double num12 = num7;
								int num3 = 0;
								num = (short)2017460230;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 11:
							goto IL_331;
						case 12:
							goto IL_28A;
						case 13:
							goto IL_5BF;
						case 14:
							num9++;
							num = (short)2018443265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							return;
						case 16:
							num17 = 15;
							num18 = 255 - num17;
							num5 = rect.X + num6 * 2.5;
							num7 = (double)this.d * (num6 * 1.5);
							num4 = 0;
							num = (short)1108082697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
						{
							int num3;
							if (num3 >= this.d - 1)
							{
								num = (short)748224526;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							double num14 = num6 * (double)this.b[num3];
							double num15 = num6 * (double)this.c[num3];
							int num8 = 0;
							num = (short)1813577741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
							if (rect.Height < rect.Width)
							{
								num = (short)624295944;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							rect.Inflate(0.0, -(rect.Height - rect.Width) / 2.0);
							num = (short)1949237269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							goto IL_148;
						case 20:
							goto IL_2CE;
						case 21:
							goto IL_331;
						case 22:
						{
							if (num4 >= 15)
							{
								num = (short)2061303823;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.Media.Color a_2 = global::System.Windows.Media.Color.FromArgb(byte.MaxValue, (byte)num18, (byte)num18, (byte)num18);
							global::DevComponents.WpfEditors.ColorComb.a(this[num13], a_2, num6, num5, num7);
							num5 += num6;
							num13++;
							num = (short)1712062467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_8B;
						IL_148:
						num = (short)1334706193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_28A:
						num = (short)1336541194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2CE:
						num = (short)399245334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_331:
						num6 = this.a(global::System.Math.Min(rect.Height, rect.Width));
						num5 = rect.Left + rect.Width / 2.0 - num6 / 2.0;
						num7 = (double)this.d * (num6 / 1.5);
						global::DevComponents.WpfEditors.ColorComb.a(this[0], global::System.Windows.Media.Colors.White, num6, num5, num7);
						num13 = 1;
						num9 = 1;
						num = (short)1572601856;
						short num19 = num;
						num = (short)315883532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3E6:
						num18 -= num17;
						num4++;
						num = (short)1004339220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5BF:
						num = (short)736755719;
						num2 = (int)((global::System.IntPtr)num);
					}
					return;
				}
				IL_8B:
				rect = A_0;
				rect.Inflate(-3.0, -3.0);
				IL_A6:
				num = (short)1189216274;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00005628 File Offset: 0x00003828
		private global::System.Windows.Media.Color a(double A_0, double A_1, double A_2)
		{
			short num = (short)147652608;
			switch (num)
			{
			default:
			{
				num = (short)1859649539;
				int num2 = (int)((global::System.IntPtr)num);
				int num6;
				int num5;
				int num4;
				for (;;)
				{
					float num3;
					switch (num2)
					{
					case 0:
						if (A_1 <= 0.5)
						{
							num = (short)2120351748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (float)(A_1 + A_2 - A_1 * A_2);
						goto IL_97;
					case 1:
						num4 = (num5 = (num6 = (int)(A_1 * 255.0)));
						num = (short)1411973125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_200;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_64;
						}
						continue;
					case 4:
						num3 = (float)(A_1 + A_1 * A_2);
						num = (short)1247608839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_14A;
					case 6:
						goto IL_176;
					case 7:
					{
						num = (short)669000246;
						short num7 = num;
						num = (short)1972511286;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_97;
						default:
							num = (short)792199168;
							if (num != 0)
							{
							}
							goto IL_176;
						}
						break;
					}
					}
					IL_64:
					if (A_2 == 0.0)
					{
						num = (short)393216001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1718616064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_97:
					num = (short)1135083526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_176:
					num = (short)1440940032;
					short num8 = num;
					float a_ = (float)(2.0 * A_1 - (double)num3);
					num5 = this.a(a_, num3, (float)(A_0 + 120.0));
					num4 = this.a(a_, num3, (float)A_0);
					num6 = this.a(a_, num3, (float)(A_0 - 120.0));
					num = (short)125829122;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_14A:
				num = (short)815202305;
				if (num != 0)
				{
				}
				IL_200:
				return global::System.Windows.Media.Color.FromArgb(byte.MaxValue, (byte)num5, (byte)num4, (byte)num6);
			}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00005890 File Offset: 0x00003A90
		private float a(double A_0, double A_1)
		{
			short num = (short)769785856;
			short num2 = num;
			num = (short)1979877623;
			short num3 = num;
			num = (short)537561335;
			switch (num3 == num)
			{
			}
			num = (short)1607598081;
			if (num != 0)
			{
			}
			num = (short)843317248;
			if (num != 0)
			{
			}
			return (float)(global::System.Math.Atan2(A_1, A_0) * 180.0 / 3.141592653589793);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00005958 File Offset: 0x00003B58
		private int a(float A_0, float A_1, float A_2)
		{
			short num = (short)882311178;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_2 < 180f)
					{
						num = (short)1636499459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)244776974;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_140;
				case 2:
					goto IL_24E;
				case 3:
					A_0 = A_1;
					num = (short)1183186950;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					A_0 += (A_1 - A_0) * A_2 / 60f;
					num = (short)277544961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_24C;
				case 6:
					goto IL_EF;
				case 7:
					if (A_2 < 60f)
					{
						num = (short)1108803588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)498008064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					A_2 += 360f;
					num = (short)44433410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					A_2 -= 360f;
					num = (short)1719795724;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 11:
					A_0 += (A_1 - A_0) * (240f - A_2) / 60f;
					num = (short)1495597061;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_24E;
				case 13:
					if (A_2 < 0f)
					{
						num = (short)337969160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24E;
				case 14:
					if (A_2 < 240f)
					{
						num = (short)238616587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B0;
				}
				IL_61:
				num = (short)1784979745;
				short num3 = num;
				num = (short)1192534305;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					num = (short)1047658496;
					if (num != 0)
					{
					}
					if (A_2 > 360f)
					{
						num = (short)1140654089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)825425933;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_24E:
				num = (short)2043871239;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EF:
			num = (short)1436418049;
			if (num != 0)
			{
			}
			IL_140:
			IL_24C:
			IL_2B0:
			num = (short)658636800;
			short num4 = num;
			return (int)(A_0 * 255f);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00005C48 File Offset: 0x00003E48
		private static void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)107347968;
			short num2 = num;
			num = (short)1472160375;
			short num3 = num;
			num = (short)502686327;
			switch (num3 == num)
			{
			}
			num = (short)352059392;
			if (num != 0)
			{
			}
			num = (short)1385693185;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfEditors.ColorComb)A_0).a(A_1.OriginalSource as global::System.Windows.FrameworkElement, true, A_1);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00005D08 File Offset: 0x00003F08
		private static void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1375666176;
			short num2 = num;
			num = (short)698293002;
			short num3 = num;
			num = (short)153819914;
			switch (num3 == num)
			{
			}
			num = (short)249036801;
			if (num != 0)
			{
			}
			num = (short)2051735552;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfEditors.ColorComb)A_0).a(A_1.OriginalSource as global::System.Windows.FrameworkElement, false, A_1);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00005DC8 File Offset: 0x00003FC8
		internal void a(global::System.Windows.FrameworkElement A_0, bool A_1, global::System.Windows.RoutedEventArgs A_2)
		{
			short num = (short)1936523269;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1885405193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_133;
				case 2:
					this.Selection.d(A_0);
					num = (short)329449480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_8E;
				case 4:
					if (A_1)
					{
						num = (short)1165623298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.Selection.c(A_0);
					num = (short)1820459014;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 6:
					goto IL_203;
				case 7:
				{
					num = (short)1569928765;
					short num3 = num;
					num = (short)2115974717;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_203;
					default:
						num = (short)243793921;
						if (num != 0)
						{
						}
						num = (short)1106640896;
						if (num != 0)
						{
						}
						num = (short)1976827908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					goto IL_72;
				case 9:
				{
					num = (short)1771241472;
					short num4 = num;
					if (A_0 != null)
					{
						num = (short)705888263;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_114;
				}
				}
				IL_4C:
				if (!this.Selection.e())
				{
					num = (short)1853816832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_114;
				IL_72:
				A_2.Handled = true;
				num = (short)444989443;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_203:
				goto IL_72;
				IL_114:
				A_2.Handled = true;
				num = (short)2104557569;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_8E:
			IL_133:
			this.OnSelectionChanged(A_0, A_1);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00005FE8 File Offset: 0x000041E8
		protected virtual void OnSelectionChanged(global::System.Windows.FrameworkElement selectedElement, bool isSelected)
		{
			short num = (short)1535799090;
			short num2 = num;
			num = (short)1808166706;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)777977856;
				if (num != 0)
				{
				}
				if (!(selectedElement is global::DevComponents.WpfEditors.CombCell))
				{
					this.SelectedColor = null;
					return;
				}
				break;
			}
			num = (short)1406205953;
			if (num != 0)
			{
			}
			num = (short)1353252864;
			short num3 = num;
			this.SelectedColor = new global::System.Windows.Media.Color?(((global::DevComponents.WpfEditors.CombCell)selectedElement).Color);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000060C4 File Offset: 0x000042C4
		private global::DevComponents.WpfEditors.ColorComb.a Selection
		{
			get
			{
				short num = (short)2009071616;
				short num2 = num;
				num = (short)1429864449;
				if (num != 0)
				{
				}
				num = (short)105135566;
				short num3 = num;
				num = (short)793591246;
				switch (num3 == num)
				{
				}
				num = (short)131727360;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x0400000A RID: 10
		public static readonly global::System.Windows.DependencyProperty SelectedColorProperty;

		// Token: 0x0400000C RID: 12
		private const float a = 0.68f;

		// Token: 0x0400000D RID: 13
		private float[] b = new float[]
		{
			-0.5f,
			-1f,
			-0.5f,
			0.5f,
			1f,
			0.5f
		};

		// Token: 0x0400000E RID: 14
		private float[] c = new float[]
		{
			0.68f,
			0f,
			-0.68f,
			-0.68f,
			0f,
			0.68f
		};

		// Token: 0x0400000F RID: 15
		private int d = 7;

		// Token: 0x04000010 RID: 16
		private global::DevComponents.WpfEditors.ColorComb.a e = new global::DevComponents.WpfEditors.ColorComb.a();

		// Token: 0x02000007 RID: 7
		private class a
		{
			// Token: 0x0600002E RID: 46 RVA: 0x00006174 File Offset: 0x00004374
			public bool e()
			{
				short num = (short)1827799040;
				short num2 = num;
				num = (short)730393559;
				short num3 = num;
				num = (short)2086267863;
				switch (num3 == num)
				{
				}
				num = (short)698155008;
				if (num != 0)
				{
				}
				num = (short)1772617729;
				if (num != 0)
				{
				}
				return this.a > 0;
			}

			// Token: 0x0600002F RID: 47 RVA: 0x00006224 File Offset: 0x00004424
			public bool f()
			{
				short num = (short)1357643776;
				short num2 = num;
				num = (short)262074092;
				short num3 = num;
				num = (short)835841772;
				switch (num3 == num)
				{
				}
				num = (short)1819803649;
				if (num != 0)
				{
				}
				num = (short)79495168;
				if (num != 0)
				{
				}
				return this.c;
			}

			// Token: 0x06000030 RID: 48 RVA: 0x000062D4 File Offset: 0x000044D4
			public void c(bool A_0)
			{
				short num = (short)350158848;
				short num2 = num;
				num = (short)1314794441;
				short num3 = num;
				num = (short)1800022985;
				switch (num3 == num)
				{
				}
				num = (short)351666177;
				if (num != 0)
				{
				}
				num = (short)1860108288;
				if (num != 0)
				{
				}
				this.c = A_0;
			}

			// Token: 0x06000031 RID: 49 RVA: 0x00006384 File Offset: 0x00004584
			public void c(global::System.Windows.FrameworkElement A_0)
			{
				this.d();
				short num;
				try
				{
					num = (short)687144962;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							A_0.SetValue(global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty, false);
							num = (short)822738949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							if (this.b.Contains(A_0))
							{
								goto IL_150;
							}
							num = (short)1906422255;
							short num3 = num;
							num = (short)1787081199;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_C4;
							default:
								num = (short)2078998528;
								if (num != 0)
								{
								}
								num = (short)552534019;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_49;
							}
							continue;
						case 3:
							this.b.Remove(A_0);
							num = (short)461176838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_168;
						case 5:
							goto IL_C4;
						case 6:
							goto IL_150;
						}
						IL_49:
						if ((bool)A_0.GetValue(global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty))
						{
							num = (short)970391552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_C4:
						num = (short)1295384577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_150:
						num = (short)1029832708;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_168:
					num = (short)166526977;
					if (num != 0)
					{
					}
				}
				finally
				{
					this.c();
				}
				num = (short)2098003968;
				short num4 = num;
			}

			// Token: 0x06000032 RID: 50 RVA: 0x00006570 File Offset: 0x00004770
			public void d(global::System.Windows.FrameworkElement A_0)
			{
				short num = (short)465174529;
				if (num != 0)
				{
				}
				this.d();
				try
				{
					num = (short)1774125061;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							this.g();
							num = (short)15597575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (!this.b.Contains(A_0))
							{
								num = (short)880803844;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E4;
						case 2:
							goto IL_179;
						case 3:
							if (!(bool)A_0.GetValue(global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty))
							{
								num = (short)1295581192;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_179;
						case 4:
							this.b.Add(A_0);
							num = (short)1460076553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_7C;
							}
							continue;
						case 6:
							goto IL_1FD;
						case 7:
							goto IL_9D;
						case 8:
						{
							num = (short)1287538518;
							short num3 = num;
							num = (short)1804814166;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)470548480;
								if (num != 0)
								{
								}
								A_0.SetValue(global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty, true);
								break;
							}
							num = (short)1563361282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							goto IL_1E4;
						}
						IL_7C:
						if (!this.c)
						{
							num = (short)2036334592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_9D:
						num = (short)1474560003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_179:
						num = (short)320733185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E4:
						num = (short)518848518;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1FD:;
				}
				finally
				{
					this.c();
				}
				num = (short)221446144;
				short num4 = num;
			}

			// Token: 0x06000033 RID: 51 RVA: 0x000067CC File Offset: 0x000049CC
			public void g()
			{
				this.d();
				short num;
				try
				{
					using (global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>.Enumerator enumerator = this.b.GetEnumerator())
					{
						num = (short)1768423424;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_50;
								}
								continue;
							case 1:
								num = (short)1878720514;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								num = (short)1824962325;
								short num3 = num;
								num = (short)1370994453;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_94;
								default:
									goto IL_FF;
								}
								break;
							}
							case 4:
								goto IL_94;
							}
							goto IL_50;
							IL_94:
							if (!enumerator.MoveNext())
							{
								num = (short)363134977;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.SetValue(global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty, false);
							num = (short)1336279043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_7F:
							num = (short)1151664132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_50:
							goto IL_7F;
						}
						IL_FF:
						num = (short)2043871232;
						if (num != 0)
						{
						}
					}
					this.b.Clear();
				}
				finally
				{
					this.c();
				}
				num = (short)23003137;
				if (num != 0)
				{
				}
				num = (short)813432832;
				short num4 = num;
			}

			// Token: 0x06000034 RID: 52 RVA: 0x00006998 File Offset: 0x00004B98
			private void d()
			{
				short num = (short)2052754282;
				short num2 = num;
				num = (short)1877314410;
				switch (num2 == num)
				{
				}
				num = (short)1152909313;
				if (num != 0)
				{
				}
				num = (short)255721472;
				short num3 = num;
				num = (short)1082195968;
				if (num != 0)
				{
				}
				this.a++;
			}

			// Token: 0x06000035 RID: 53 RVA: 0x00006A50 File Offset: 0x00004C50
			private void c()
			{
				int a_ = 12;
				short num;
				for (;;)
				{
					num = (short)1689321473;
					if (num != 0)
					{
					}
					this.a--;
					if (this.a < 0)
					{
						break;
					}
					num = (short)203542182;
					short num2 = num;
					num = (short)266718886;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_91;
					}
				}
				throw new global::System.InvalidOperationException(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鳘뗚맜賞蓠迢胤蓦鷨苪苬臮퇰郲铴鯶闸黺駼\udffe瘀樂焄漆昈縊礌⼎爐簒朔攖簘栚洜瀞传䜢䰤䤦丨ପ漬䨮嘰娲嬴搶尸场堼尾㕀⩂⩄⥆", a_));
				IL_91:
				num = (short)117637120;
				short num3 = num;
				num = (short)1264254976;
				if (num != 0)
				{
				}
			}

			// Token: 0x06000036 RID: 54 RVA: 0x00006B30 File Offset: 0x00004D30
			public global::System.Windows.FrameworkElement[] h()
			{
				short num = (short)1646667409;
				short num2 = num;
				num = (short)99165841;
				switch (num2 == num)
				{
				}
				num = (short)1453719552;
				if (num != 0)
				{
				}
				num = (short)1687683072;
				short num3 = num;
				num = (short)1454833665;
				if (num != 0)
				{
				}
				global::System.Windows.FrameworkElement[] array = new global::System.Windows.FrameworkElement[this.b.Count];
				this.b.CopyTo(array);
				return array;
			}

			// Token: 0x04000011 RID: 17
			private int a;

			// Token: 0x04000012 RID: 18
			private global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> b = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();

			// Token: 0x04000013 RID: 19
			private bool c;
		}
	}
}
