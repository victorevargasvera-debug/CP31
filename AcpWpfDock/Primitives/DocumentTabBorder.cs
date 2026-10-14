using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DevComponents.WpfDock.Converters;

namespace DevComponents.WpfDock.Primitives
{
	// Token: 0x0200005A RID: 90
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DocumentTabBorder : global::System.Windows.Controls.Decorator
	{
		// Token: 0x0600035F RID: 863 RVA: 0x00051F1C File Offset: 0x0005011C
		static DocumentTabBorder()
		{
			int a_ = 14;
			short num = (short)1661534208;
			short num2 = num;
			num = (short)971388787;
			short num3 = num;
			num = (short)19085171;
			switch (num3 == num)
			{
			}
			num = (short)2001010688;
			if (num != 0)
			{
			}
			num = (short)1931739137;
			if (num != 0)
			{
			}
			global::DevComponents.WpfDock.Primitives.DocumentTabBorder.BorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("迌ꃎꏐ럒냔ꗖ鯘꧚꣜곞觠", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfDock.Primitives.DocumentTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfDock.Primitives.DocumentTabBorder.BorderInnerBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("迌ꃎꏐ럒냔ꗖ郘뗚돜뫞鏠ꇢ韤鋦髨菪", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfDock.Primitives.DocumentTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfDock.Primitives.DocumentTabBorder.BackgroundProperty = global::System.Windows.Controls.Panel.BackgroundProperty.AddOwner(typeof(global::DevComponents.WpfDock.Primitives.DocumentTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfDock.Primitives.DocumentTabBorder.BottomBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("迌ꃎꗐ꟒뫔뫖鯘듚꿜믞蓠釢꟤闦鳨飪藬", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfDock.Primitives.DocumentTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00052098 File Offset: 0x00050298
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)2002825756;
			short num2 = num;
			num = (short)25342492;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)653590528;
				if (num != 0)
				{
				}
				num = (short)314376193;
				if (num != 0)
				{
				}
				if (this.Child == null)
				{
					return base.MeasureOverride(constraint);
				}
				num = (short)1925775360;
				short num3 = num;
				break;
			}
			}
			global::System.Windows.Size availableSize = constraint;
			availableSize.Width = global::System.Math.Max(0.0, availableSize.Width - 4.0);
			availableSize.Height = global::System.Math.Max(0.0, availableSize.Height - 4.0);
			this.Child.Measure(availableSize);
			global::System.Windows.Size desiredSize = this.Child.DesiredSize;
			desiredSize.Width += 4.0;
			desiredSize.Height += 4.0;
			desiredSize.Width += desiredSize.Height + 2.0;
			global::DevComponents.WpfDock.i.a(ref desiredSize);
			return desiredSize;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00052218 File Offset: 0x00050418
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeSize)
		{
			switch (0)
			{
			case 0:
				goto IL_8E;
			}
			short num;
			int num3;
			global::System.Windows.Rect finalRect;
			for (;;)
			{
				IL_0A:
				num = (short)1181560754;
				short num2 = num;
				num = (short)700395442;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)427425793;
					if (num != 0)
					{
					}
					num = (short)1134690304;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
					{
						num = (short)2098593792;
						short num4 = num;
						if (this.Child != null)
						{
							num = (short)1611399169;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A8;
					}
					case 1:
						goto IL_183;
					case 2:
						goto IL_1A6;
					}
					goto IL_8E;
				}
				IL_183:
				this.Child.Arrange(finalRect);
				num = (short)1231224834;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_1A6:
			IL_1A8:
			this.a = new global::System.Windows.Media.PathGeometry();
			this.a.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(0.0, arrangeSize.Height), new global::System.Windows.Media.PathSegment[]
			{
				new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Height - 3.0, 3.0), true),
				new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Height, 1.5), true),
				new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Height + 3.0, 0.5), true),
				new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 4.0, 0.5), true),
				new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(arrangeSize.Width - 0.5, 4.0), new global::System.Windows.Size(3.5, 3.5), 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true),
				new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 0.5, arrangeSize.Height), true)
			}, false));
			this.b = new global::System.Windows.Media.PathGeometry();
			this.b.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(1.0, arrangeSize.Height), new global::System.Windows.Media.PathSegment[]
			{
				new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Height - 3.0, 4.0), true),
				new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Height, 2.5), true),
				new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Height + 3.0, 1.5), true),
				new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 5.0, 1.5), true),
				new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(arrangeSize.Width - 1.5, 5.0), new global::System.Windows.Size(3.5, 3.5), 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true),
				new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 1.5, arrangeSize.Height), true)
			}, false));
			return arrangeSize;
			IL_8E:
			finalRect = default(global::System.Windows.Rect);
			finalRect.Width = global::System.Math.Max(0.0, arrangeSize.Width - 2.0 - arrangeSize.Height);
			finalRect.Height = global::System.Math.Max(0.0, arrangeSize.Height - 4.0);
			finalRect.X = global::System.Math.Min(arrangeSize.Height, arrangeSize.Width);
			finalRect.Y = global::System.Math.Min(2.0, arrangeSize.Height);
			num = (short)1918238720;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00052654 File Offset: 0x00050854
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			switch (0)
			{
			case 0:
				goto IL_64;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Windows.Media.Pen pen;
				switch (num)
				{
				case 0:
					goto IL_3BA;
				case 1:
					pen = new global::System.Windows.Media.Pen(this.BorderInnerBrush, 1.0);
					drawingContext.DrawGeometry(null, pen, this.b);
					num2 = (short)208928768;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					drawingContext.DrawLine(new global::System.Windows.Media.Pen(this.BottomBorderBrush, 1.2), new global::System.Windows.Point(0.0, base.ActualHeight - 0.5), new global::System.Windows.Point(base.ActualWidth - 1.0, base.ActualHeight - 0.5));
					num2 = (short)1934622727;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (this.BorderInnerBrush != null)
					{
						num2 = (short)400752641;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3BA;
				case 4:
				{
					num2 = (short)47084440;
					short num3 = num2;
					num2 = (short)2118022040;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_467;
					default:
						num2 = (short)1846542336;
						if (num2 != 0)
						{
						}
						if (base.VisualXSnappingGuidelines == null)
						{
							num2 = (short)1764360203;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_197;
					}
					break;
				}
				case 5:
					if (this.BottomBorderBrush != null)
					{
						num2 = (short)922222594;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CF;
				case 6:
					pen = new global::System.Windows.Media.Pen(this.BorderBrush, 1.0);
					num2 = (short)1113718804;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_CF;
				case 8:
					goto IL_197;
				case 9:
					if (base.VisualYSnappingGuidelines == null)
					{
						num2 = (short)2131755023;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 10:
					num2 = (short)554958849;
					if (num2 != 0)
					{
					}
					if (this.a != null)
					{
						num2 = (short)1048117260;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					base.VisualXSnappingGuidelines = new global::System.Windows.Media.DoubleCollection(new double[]
					{
						0.0,
						base.ActualWidth
					});
					num2 = (short)103874568;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					num2 = (short)248053773;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (this.Background == null)
					{
						num2 = (short)925630481;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_344;
				case 14:
					if (this.BorderBrush == null)
					{
						num2 = (short)836239376;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_344;
				case 15:
				{
					base.VisualYSnappingGuidelines = new global::System.Windows.Media.DoubleCollection(new double[]
					{
						0.0,
						base.ActualHeight
					});
					num2 = (short)1512374272;
					short num4 = num2;
					num2 = (short)213778451;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 16:
					goto IL_213;
				case 17:
					num2 = (short)1578106894;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					if (this.BorderBrush != null)
					{
						num2 = (short)299040774;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2F2;
				case 19:
					return;
				case 20:
					goto IL_467;
				}
				goto IL_64;
				IL_CF:
				num2 = (short)1770520580;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_197:
				num2 = (short)775094281;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2F2:
				drawingContext.DrawGeometry(this.Background, pen, this.a);
				num2 = (short)752156675;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_467:
				goto IL_2F2;
				IL_344:
				pen = null;
				num2 = (short)1861550098;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3BA:
				num2 = (short)51576837;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_213:
			return;
			IL_64:
			base.OnRender(drawingContext);
			num2 = (short)1040121866;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00052AD0 File Offset: 0x00050CD0
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00052B88 File Offset: 0x00050D88
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush Background
		{
			get
			{
				short num = (short)650641408;
				short num2 = num;
				num = (short)790429697;
				if (num != 0)
				{
				}
				num = (short)203261342;
				short num3 = num;
				num = (short)1533642142;
				switch (num3 == num)
				{
				}
				num = (short)525664256;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfDock.Primitives.DocumentTabBorder.BackgroundProperty);
			}
			set
			{
				short num = (short)1430650880;
				short num2 = num;
				num = (short)1897757422;
				short num3 = num;
				num = (short)974093038;
				switch (num3 == num)
				{
				}
				num = (short)932380673;
				if (num != 0)
				{
				}
				num = (short)1533870080;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.Primitives.DocumentTabBorder.BackgroundProperty, value);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00052C40 File Offset: 0x00050E40
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00052CF8 File Offset: 0x00050EF8
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderBrush
		{
			get
			{
				short num = (short)1286406144;
				short num2 = num;
				num = (short)281541662;
				short num3 = num;
				num = (short)1946942494;
				switch (num3 == num)
				{
				}
				num = (short)1754791937;
				if (num != 0)
				{
				}
				num = (short)1347223552;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfDock.Primitives.DocumentTabBorder.BorderBrushProperty);
			}
			set
			{
				short num = (short)1171259392;
				short num2 = num;
				num = (short)186732153;
				short num3 = num;
				num = (short)307318393;
				switch (num3 == num)
				{
				}
				num = (short)1681981441;
				if (num != 0)
				{
				}
				num = (short)865665024;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.Primitives.DocumentTabBorder.BorderBrushProperty, value);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00052DAC File Offset: 0x00050FAC
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00052E68 File Offset: 0x00051068
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderInnerBrush
		{
			get
			{
				short num = (short)1639645184;
				short num2 = num;
				num = (short)2079916033;
				if (num != 0)
				{
				}
				num = (short)524647748;
				short num3 = num;
				num = (short)1407679812;
				switch (num3 == num)
				{
				}
				num = (short)1028849664;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfDock.Primitives.DocumentTabBorder.BorderInnerBrushProperty);
			}
			set
			{
				short num = (short)1138819072;
				short num2 = num;
				num = (short)50335829;
				short num3 = num;
				num = (short)127471701;
				switch (num3 == num)
				{
				}
				num = (short)982515712;
				if (num != 0)
				{
				}
				num = (short)1951072257;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.Primitives.DocumentTabBorder.BorderInnerBrushProperty, value);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00052F20 File Offset: 0x00051120
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00052FD8 File Offset: 0x000511D8
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BottomBorderBrush
		{
			get
			{
				short num = (short)1031929856;
				short num2 = num;
				num = (short)1448907653;
				short num3 = num;
				num = (short)2103546757;
				switch (num3 == num)
				{
				}
				num = (short)2016280577;
				if (num != 0)
				{
				}
				num = (short)586809344;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfDock.Primitives.DocumentTabBorder.BottomBorderBrushProperty);
			}
			set
			{
				short num = (short)388825088;
				short num2 = num;
				num = (short)993591297;
				if (num != 0)
				{
				}
				num = (short)1467234390;
				short num3 = num;
				num = (short)1415264342;
				switch (num3 == num)
				{
				}
				num = (short)733937664;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.Primitives.DocumentTabBorder.BottomBorderBrushProperty, value);
			}
		}

		// Token: 0x0400020E RID: 526
		public static readonly global::System.Windows.DependencyProperty BackgroundProperty;

		// Token: 0x0400020F RID: 527
		public static readonly global::System.Windows.DependencyProperty BorderBrushProperty;

		// Token: 0x04000210 RID: 528
		public static readonly global::System.Windows.DependencyProperty BorderInnerBrushProperty;

		// Token: 0x04000211 RID: 529
		public static readonly global::System.Windows.DependencyProperty BottomBorderBrushProperty;

		// Token: 0x04000212 RID: 530
		private global::System.Windows.Media.PathGeometry a;

		// Token: 0x04000213 RID: 531
		private global::System.Windows.Media.PathGeometry b;
	}
}
