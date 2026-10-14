using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000031 RID: 49
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DocumentTabBorder : global::System.Windows.Controls.Decorator
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00044F20 File Offset: 0x00043120
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00044FDC File Offset: 0x000431DC
		public global::System.Windows.Controls.Dock TabStripPlacement
		{
			get
			{
				short num = (short)1237025771;
				short num2 = num;
				num = (short)528253931;
				switch (num2 == num)
				{
				}
				num = (short)1941962752;
				short num3 = num;
				num = (short)97583105;
				if (num != 0)
				{
				}
				num = (short)1635909632;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.Dock)base.GetValue(global::DevComponents.WpfEditors.DocumentTabBorder.TabStripPlacementProperty);
			}
			set
			{
				short num = (short)1111564987;
				short num2 = num;
				num = (short)1611014843;
				switch (num2 == num)
				{
				}
				num = (short)141033472;
				short num3 = num;
				num = (short)447676416;
				if (num != 0)
				{
				}
				num = (short)1456209921;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DocumentTabBorder.TabStripPlacementProperty, value);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00045098 File Offset: 0x00043298
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00045150 File Offset: 0x00043350
		public double VerticalTabArrangementSlant
		{
			get
			{
				short num = (short)1845460814;
				short num2 = num;
				num = (short)358252366;
				switch (num2 == num)
				{
				}
				num = (short)806486016;
				short num3 = num;
				num = (short)1639317504;
				if (num != 0)
				{
				}
				num = (short)1550516225;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfEditors.DocumentTabBorder.VerticalTabArrangementSlantProperty);
			}
			set
			{
				short num = (short)1862729566;
				short num2 = num;
				num = (short)1851195230;
				switch (num2 == num)
				{
				}
				num = (short)252903424;
				short num3 = num;
				num = (short)736690176;
				if (num != 0)
				{
				}
				num = (short)535691265;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DocumentTabBorder.VerticalTabArrangementSlantProperty, value);
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00045208 File Offset: 0x00043408
		static DocumentTabBorder()
		{
			int a_ = 12;
			short num = (short)1816579260;
			short num2 = num;
			num = (short)608947388;
			switch (num2 == num)
			{
			}
			num = (short)1455947776;
			short num3 = num;
			num = (short)2145648641;
			if (num != 0)
			{
			}
			num = (short)1663172608;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.DocumentTabBorder.TabStripPlacementProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跘뫚뿜賞闠釢賤韦맨蟪賬賮铰黲郴駶跸", a_), typeof(global::System.Windows.Controls.Dock), typeof(global::DevComponents.WpfEditors.DocumentTabBorder), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Dock.Top, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));
			global::DevComponents.WpfEditors.DocumentTabBorder.VerticalTabArrangementSlantProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("还뻚꿜ꯞ裠胢蓤详뷨諪迬껮菰臲铴駶黸黺郼髾漀眂嘄欆栈攊礌", a_), typeof(double), typeof(global::DevComponents.WpfEditors.DocumentTabBorder), new global::System.Windows.UIPropertyMetadata(20.0));
			global::DevComponents.WpfEditors.DocumentTabBorder.BorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鯘듚꿜믞蓠釢꟤闦鳨飪藬", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.DocumentTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfEditors.DocumentTabBorder.BorderInnerBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鯘듚꿜믞蓠釢곤触蟨軪鿬귮菰蛲蛴鿶", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.DocumentTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfEditors.DocumentTabBorder.BackgroundProperty = global::System.Windows.Controls.Panel.BackgroundProperty.AddOwner(typeof(global::DevComponents.WpfEditors.DocumentTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfEditors.DocumentTabBorder.BottomBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鯘듚꧜ꯞ軠転꟤裦鯨迪裬鷮돰臲胴蓶釸", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.DocumentTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
		}

		// Token: 0x06000385 RID: 901 RVA: 0x000453F8 File Offset: 0x000435F8
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)1226375183;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Size desiredSize;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1005322240;
					short num3 = num;
					num = (short)2122317846;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (constraint.Height > desiredSize.Width + 4.0)
					{
						num = (short)1234567177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					desiredSize.Height = desiredSize.Width + 4.0;
					num = (short)803405849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)980156432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_563;
				case 4:
					num = (short)1906049048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_2C6;
				case 6:
					num = (short)108331009;
					if (num != 0)
					{
					}
					if (constraint.Width > desiredSize.Height + 4.0)
					{
						num = (short)2025521166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					desiredSize.Width = desiredSize.Height + 4.0;
					num = (short)290717707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (desiredSize.Height > constraint.Height)
					{
						num = (short)1623261202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return desiredSize;
				case 8:
					goto IL_2C6;
				case 9:
					goto IL_383;
				case 10:
				{
					global::System.Windows.Size availableSize = constraint;
					availableSize.Width = global::System.Math.Max(0.0, availableSize.Width - 4.0);
					availableSize.Height = global::System.Math.Max(0.0, availableSize.Height - 4.0);
					this.Child.Measure(availableSize);
					desiredSize = this.Child.DesiredSize;
					desiredSize.Width += 4.0;
					desiredSize.Height += 4.0;
					num = (short)117309459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					return desiredSize;
				case 12:
					if (desiredSize.Width > constraint.Width)
					{
						num = (short)640090112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_568;
				case 13:
					num = (short)1680605204;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					desiredSize.Width = constraint.Width;
					num = (short)1555759107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_95;
					}
					continue;
				case 16:
					if (this.TabStripPlacement == global::System.Windows.Controls.Dock.Bottom)
					{
						num = (short)1721565201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_568;
				case 17:
					goto IL_24F;
				case 18:
					num = (short)781385755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (this.TabStripPlacement != global::System.Windows.Controls.Dock.Top)
					{
						num = (short)270925828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4C6;
				case 20:
					if (this.TabStripPlacement == global::System.Windows.Controls.Dock.Right)
					{
						num = (short)130351130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return desiredSize;
				case 21:
					return desiredSize;
				case 22:
					if (this.TabStripPlacement != global::System.Windows.Controls.Dock.Top)
					{
						num = (short)1497759746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24F;
				case 23:
					goto IL_4C6;
				case 24:
					if (this.TabStripPlacement == global::System.Windows.Controls.Dock.Bottom)
					{
						num = (short)2048262167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					desiredSize.Height += this.VerticalTabArrangementSlant + 2.0;
					num = (short)42270725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					return desiredSize;
				case 26:
					goto IL_337;
				case 27:
					if (this.TabStripPlacement != global::System.Windows.Controls.Dock.Left)
					{
						num = (short)138543117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_337;
				}
				IL_95:
				if (this.Child != null)
				{
					num = (short)1015545866;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)571851654;
				short num4 = num;
				num = (short)1695728518;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_383;
				default:
					goto IL_5E4;
				}
				IL_24F:
				num = (short)650772486;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C6:
				global::DevComponents.WpfEditors.d.a(ref desiredSize);
				desiredSize.Width = global::System.Math.Ceiling(desiredSize.Width);
				desiredSize.Height = global::System.Math.Ceiling(desiredSize.Height);
				num = (short)794034188;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_337:
				num = (short)114360321;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_383:
				desiredSize.Height = constraint.Height;
				num = (short)287834133;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4C6:
				desiredSize.Width += desiredSize.Height + 2.0;
				num = (short)380764168;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_568:
				num = (short)1383792647;
				num2 = (int)((global::System.IntPtr)num);
			}
			return desiredSize;
			IL_563:
			return desiredSize;
			IL_5E4:
			num = (short)1446707200;
			if (num != 0)
			{
			}
			return base.MeasureOverride(constraint);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00045A08 File Offset: 0x00043C08
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeSize)
		{
			short num = (short)812318720;
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
				global::System.Windows.Rect finalRect;
				global::System.Windows.Controls.Dock tabStripPlacement;
				for (;;)
				{
					IL_27:
					double verticalTabArrangementSlant;
					double verticalTabArrangementSlant2;
					switch (num2)
					{
					case 0:
						this.Child.Arrange(finalRect);
						num = (short)142671882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_42C;
					case 2:
					{
						finalRect.Width = global::System.Math.Max(0.0, arrangeSize.Width - 2.0 - arrangeSize.Height);
						finalRect.Height = global::System.Math.Max(0.0, arrangeSize.Height - 4.0);
						finalRect.X = global::System.Math.Min(arrangeSize.Height, arrangeSize.Width);
						finalRect.Y = global::System.Math.Min(2.0, arrangeSize.Height);
						num = (short)661716992;
						short num3 = num;
						num = (short)1126301709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (tabStripPlacement == global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)751108098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)514916373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)417923073;
						if (num != 0)
						{
						}
						goto IL_7E7;
					case 5:
						this.Child.Arrange(finalRect);
						num = (short)339738646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return arrangeSize;
					case 7:
						if (this.Child != null)
						{
							goto IL_40E;
						}
						goto IL_DC;
					case 8:
						return arrangeSize;
					case 9:
						return arrangeSize;
					case 10:
						goto IL_ABD;
					case 11:
						if (tabStripPlacement == global::System.Windows.Controls.Dock.Top)
						{
							num = (short)1551630359;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)805109763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (this.Child != null)
						{
							num = (short)1226702867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E7;
					case 13:
						if (this.Child != null)
						{
							num = (short)1961230336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ABD;
					case 14:
						verticalTabArrangementSlant = this.VerticalTabArrangementSlant;
						finalRect.Height = global::System.Math.Max(0.0, arrangeSize.Height - 2.0 - verticalTabArrangementSlant);
						finalRect.Width = global::System.Math.Max(0.0, arrangeSize.Width - 4.0);
						finalRect.Y = global::System.Math.Min(arrangeSize.Width, verticalTabArrangementSlant);
						finalRect.X = global::System.Math.Min(2.0, arrangeSize.Width);
						num = (short)474087431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						verticalTabArrangementSlant2 = this.VerticalTabArrangementSlant;
						finalRect.Height = global::System.Math.Max(0.0, arrangeSize.Height - 2.0 - verticalTabArrangementSlant2);
						finalRect.Width = global::System.Math.Max(0.0, arrangeSize.Width - 4.0);
						finalRect.Y = global::System.Math.Min(arrangeSize.Width, verticalTabArrangementSlant2);
						finalRect.X = global::System.Math.Min(2.0, arrangeSize.Width);
						num = (short)1844707340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (this.Child != null)
						{
							num = (short)811663377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42C;
					case 17:
						this.Child.Arrange(finalRect);
						num = (short)2110521345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						num = (short)69647324;
						short num4 = num;
						num = (short)70171612;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_40E;
						default:
							num = (short)575602688;
							if (num != 0)
							{
							}
							if (tabStripPlacement == global::System.Windows.Controls.Dock.Right)
							{
								num = (short)174915599;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return arrangeSize;
						}
						break;
					}
					case 19:
						this.Child.Arrange(finalRect);
						num = (short)1401618436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						return arrangeSize;
					case 21:
						if (tabStripPlacement == global::System.Windows.Controls.Dock.Left)
						{
							num = (short)1632632846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1349255186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_DC;
					case 23:
						finalRect.Width = global::System.Math.Max(0.0, arrangeSize.Width - 2.0 - arrangeSize.Height);
						finalRect.Height = global::System.Math.Max(0.0, arrangeSize.Height - 4.0);
						finalRect.X = global::System.Math.Min(arrangeSize.Height, arrangeSize.Width);
						finalRect.Y = global::System.Math.Min(2.0, arrangeSize.Height);
						num = (short)1824063504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8E;
					IL_DC:
					this.a = new global::System.Windows.Media.PathGeometry();
					this.a.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(arrangeSize.Width, 0.0), new global::System.Windows.Media.PathSegment[]
					{
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(3.0, verticalTabArrangementSlant - 3.0), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(1.5, verticalTabArrangementSlant), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(0.5, verticalTabArrangementSlant + 3.0), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(0.5, arrangeSize.Height - 3.5), true),
						new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(4.0, arrangeSize.Height - 0.5), new global::System.Windows.Size(3.5, 3.5), 0.0, false, global::System.Windows.Media.SweepDirection.Counterclockwise, true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width, arrangeSize.Height - 0.5), true)
					}, false));
					this.b = new global::System.Windows.Media.PathGeometry();
					this.b.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(arrangeSize.Width - 0.5, 1.5), new global::System.Windows.Media.PathSegment[]
					{
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(4.5, verticalTabArrangementSlant - 3.0), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(2.5, verticalTabArrangementSlant), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(1.5, verticalTabArrangementSlant + 3.0), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(1.5, arrangeSize.Height - 4.5), true),
						new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(5.0, arrangeSize.Height - 1.5), new global::System.Windows.Size(3.5, 3.5), 0.0, false, global::System.Windows.Media.SweepDirection.Counterclockwise, true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width, arrangeSize.Height - 1.5), true)
					}, false));
					num = (short)1707212809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40E:
					num = (short)1020919813;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_42C:
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
					num = (short)1493106708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E7:
					this.a = new global::System.Windows.Media.PathGeometry();
					this.a.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(0.0, 0.0), new global::System.Windows.Media.PathSegment[]
					{
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 3.0, verticalTabArrangementSlant2 - 3.0), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 1.5, verticalTabArrangementSlant2), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 0.5, verticalTabArrangementSlant2 + 3.0), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 0.5, arrangeSize.Height - 4.0), true),
						new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(arrangeSize.Width - 4.0, arrangeSize.Height - 0.5), new global::System.Windows.Size(3.5, 3.5), 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(0.0, arrangeSize.Height - 0.5), true)
					}, false));
					this.b = new global::System.Windows.Media.PathGeometry();
					this.b.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(0.0, 1.0), new global::System.Windows.Media.PathSegment[]
					{
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 4.0, verticalTabArrangementSlant2 - 3.0), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 2.5, verticalTabArrangementSlant2), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 1.5, verticalTabArrangementSlant2 + 3.0), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 1.5, arrangeSize.Height - 5.0), true),
						new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(arrangeSize.Width - 5.0, arrangeSize.Height - 1.5), new global::System.Windows.Size(3.5, 3.5), 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(0.0, arrangeSize.Height - 1.5), true)
					}, false));
					num = (short)669974536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ABD:
					this.a = new global::System.Windows.Media.PathGeometry();
					this.a.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(0.0, 0.0), new global::System.Windows.Media.PathSegment[]
					{
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Height - 3.0, arrangeSize.Height - 3.0), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Height, arrangeSize.Height - 1.5), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Height + 3.0, arrangeSize.Height - 0.5), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 4.0, arrangeSize.Height - 0.5), true),
						new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(arrangeSize.Width - 0.5, arrangeSize.Height - 4.0), new global::System.Windows.Size(3.5, 3.5), 0.0, false, global::System.Windows.Media.SweepDirection.Counterclockwise, true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 0.5, 0.0), true)
					}, false));
					this.b = new global::System.Windows.Media.PathGeometry();
					this.b.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(1.0, 0.0), new global::System.Windows.Media.PathSegment[]
					{
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Height - 3.0, arrangeSize.Height - 4.0), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Height, arrangeSize.Height - 2.5), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Height + 3.0, arrangeSize.Height - 1.5), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 5.0, arrangeSize.Height - 1.5), true),
						new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(arrangeSize.Width - 1.5, arrangeSize.Height - 5.0), new global::System.Windows.Size(3.5, 3.5), 0.0, false, global::System.Windows.Media.SweepDirection.Counterclockwise, true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 1.5, 0.0), true)
					}, false));
					num = (short)1974534150;
					num2 = (int)((global::System.IntPtr)num);
				}
				return arrangeSize;
				IL_8E:
				finalRect = default(global::System.Windows.Rect);
				tabStripPlacement = this.TabStripPlacement;
				num = (short)281870347;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00046B0C File Offset: 0x00044D0C
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
					goto IL_1C0;
				case 1:
				{
					num2 = (short)1839136768;
					short num3 = num2;
					if (base.VisualXSnappingGuidelines == null)
					{
						num2 = (short)394526726;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C0;
				}
				case 2:
					if (this.BorderBrush != null)
					{
						num2 = (short)1902837765;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2ED;
				case 3:
					goto IL_3B5;
				case 4:
					goto IL_238;
				case 5:
					pen = new global::System.Windows.Media.Pen(this.BorderBrush, 1.0);
					num2 = (short)1497694216;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					base.VisualXSnappingGuidelines = new global::System.Windows.Media.DoubleCollection(new double[]
					{
						0.0,
						base.ActualWidth
					});
					num2 = (short)1208287232;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (this.BottomBorderBrush != null)
					{
						num2 = (short)2018377743;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11B;
				case 8:
					goto IL_2ED;
				case 9:
					if (this.Background == null)
					{
						num2 = (short)135790602;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_33F;
				case 10:
					num2 = (short)94502926;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (this.a != null)
					{
						num2 = (short)1659371539;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 12:
					if (base.VisualYSnappingGuidelines == null)
					{
						num2 = (short)970588173;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 13:
					base.VisualYSnappingGuidelines = new global::System.Windows.Media.DoubleCollection(new double[]
					{
						0.0,
						base.ActualHeight
					});
					num2 = (short)1473380368;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (this.BorderBrush == null)
					{
						num2 = (short)1279655940;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_33F;
				case 15:
					drawingContext.DrawLine(new global::System.Windows.Media.Pen(this.BottomBorderBrush, 1.2), new global::System.Windows.Point(0.0, base.ActualHeight - 0.5), new global::System.Windows.Point(base.ActualWidth - 1.0, base.ActualHeight - 0.5));
					num2 = (short)1226965012;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					return;
				case 17:
					pen = new global::System.Windows.Media.Pen(this.BorderInnerBrush, 1.0);
					drawingContext.DrawGeometry(null, pen, this.b);
					num2 = (short)2087780355;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					if (this.BorderInnerBrush != null)
					{
						num2 = (short)1579417617;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B5;
				case 19:
				{
					num2 = (short)1882840139;
					short num4 = num2;
					num2 = (short)68082763;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)1793589249;
						if (num2 != 0)
						{
						}
						num2 = (short)1623195648;
						if (num2 != 0)
						{
						}
						num2 = (short)1649606665;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 20:
					goto IL_11B;
				}
				goto IL_64;
				IL_11B:
				num2 = (short)1467351041;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1C0:
				num2 = (short)234684428;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2ED:
				drawingContext.DrawGeometry(this.Background, pen, this.a);
				num2 = (short)321716242;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_33F:
				pen = null;
				num2 = (short)1531248642;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3B5:
				num2 = (short)850264071;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_238:
			return;
			IL_64:
			base.OnRender(drawingContext);
			num2 = (short)732299275;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00046F80 File Offset: 0x00045180
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00047038 File Offset: 0x00045238
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush Background
		{
			get
			{
				short num = (short)1313336325;
				short num2 = num;
				num = (short)1589636101;
				switch (num2 == num)
				{
				}
				num = (short)1716584448;
				if (num != 0)
				{
				}
				num = (short)1692925952;
				short num3 = num;
				num = (short)1661599745;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.DocumentTabBorder.BackgroundProperty);
			}
			set
			{
				short num = (short)521230269;
				short num2 = num;
				num = (short)228087741;
				switch (num2 == num)
				{
				}
				num = (short)830734337;
				if (num != 0)
				{
				}
				num = (short)769589248;
				short num3 = num;
				num = (short)424017920;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DocumentTabBorder.BackgroundProperty, value);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600038A RID: 906 RVA: 0x000470F0 File Offset: 0x000452F0
		// (set) Token: 0x0600038B RID: 907 RVA: 0x000471A8 File Offset: 0x000453A8
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderBrush
		{
			get
			{
				short num = (short)2077818881;
				if (num != 0)
				{
				}
				num = (short)568273000;
				short num2 = num;
				num = (short)307964008;
				switch (num2 == num)
				{
				}
				num = (short)212074496;
				short num3 = num;
				num = (short)214040576;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.DocumentTabBorder.BorderBrushProperty);
			}
			set
			{
				short num = (short)970393788;
				short num2 = num;
				num = (short)503580860;
				switch (num2 == num)
				{
				}
				num = (short)311689217;
				if (num != 0)
				{
				}
				num = (short)791543808;
				short num3 = num;
				num = (short)593100800;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DocumentTabBorder.BorderBrushProperty, value);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00047260 File Offset: 0x00045460
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00047318 File Offset: 0x00045518
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderInnerBrush
		{
			get
			{
				short num = (short)1377507749;
				short num2 = num;
				num = (short)202906021;
				switch (num2 == num)
				{
				}
				num = (short)83361793;
				if (num != 0)
				{
				}
				num = (short)255983616;
				short num3 = num;
				num = (short)1561067520;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.DocumentTabBorder.BorderInnerBrushProperty);
			}
			set
			{
				short num = (short)457280306;
				short num2 = num;
				num = (short)1812695858;
				switch (num2 == num)
				{
				}
				num = (short)995885057;
				if (num != 0)
				{
				}
				num = (short)932577280;
				short num3 = num;
				num = (short)1129316352;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DocumentTabBorder.BorderInnerBrushProperty, value);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600038E RID: 910 RVA: 0x000473D4 File Offset: 0x000455D4
		// (set) Token: 0x0600038F RID: 911 RVA: 0x0004748C File Offset: 0x0004568C
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BottomBorderBrush
		{
			get
			{
				short num = (short)1084948481;
				if (num != 0)
				{
				}
				num = (short)646420389;
				short num2 = num;
				num = (short)1250924453;
				switch (num2 == num)
				{
				}
				num = (short)860356608;
				short num3 = num;
				num = (short)1419575296;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.DocumentTabBorder.BottomBorderBrushProperty);
			}
			set
			{
				short num = (short)683762811;
				short num2 = num;
				num = (short)317744251;
				switch (num2 == num)
				{
				}
				num = (short)535101441;
				if (num != 0)
				{
				}
				num = (short)952762368;
				short num3 = num;
				num = (short)1143275520;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DocumentTabBorder.BottomBorderBrushProperty, value);
			}
		}

		// Token: 0x040001B8 RID: 440
		public static readonly global::System.Windows.DependencyProperty BackgroundProperty;

		// Token: 0x040001B9 RID: 441
		public static readonly global::System.Windows.DependencyProperty BorderBrushProperty;

		// Token: 0x040001BA RID: 442
		public static readonly global::System.Windows.DependencyProperty BorderInnerBrushProperty;

		// Token: 0x040001BB RID: 443
		public static readonly global::System.Windows.DependencyProperty BottomBorderBrushProperty;

		// Token: 0x040001BC RID: 444
		public static readonly global::System.Windows.DependencyProperty TabStripPlacementProperty;

		// Token: 0x040001BD RID: 445
		public static readonly global::System.Windows.DependencyProperty VerticalTabArrangementSlantProperty;

		// Token: 0x040001BE RID: 446
		private global::System.Windows.Media.PathGeometry a;

		// Token: 0x040001BF RID: 447
		private global::System.Windows.Media.PathGeometry b;
	}
}
