using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000032 RID: 50
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class NoteTabBorder : global::System.Windows.Controls.Decorator
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00047558 File Offset: 0x00045758
		// (set) Token: 0x06000392 RID: 914 RVA: 0x00047614 File Offset: 0x00045814
		public global::System.Windows.Controls.Dock TabStripPlacement
		{
			get
			{
				short num = (short)533565995;
				short num2 = num;
				num = (short)1029214763;
				switch (num2 == num)
				{
				}
				num = (short)580517889;
				if (num != 0)
				{
				}
				num = (short)1035337728;
				short num3 = num;
				num = (short)1200488448;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.Dock)base.GetValue(global::DevComponents.WpfEditors.NoteTabBorder.TabStripPlacementProperty);
			}
			set
			{
				short num = (short)1548698736;
				short num2 = num;
				num = (short)293291120;
				switch (num2 == num)
				{
				}
				num = (short)2007367681;
				if (num != 0)
				{
				}
				num = (short)964820992;
				short num3 = num;
				num = (short)1656291328;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.NoteTabBorder.TabStripPlacementProperty, value);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000393 RID: 915 RVA: 0x000476D0 File Offset: 0x000458D0
		// (set) Token: 0x06000394 RID: 916 RVA: 0x0004778C File Offset: 0x0004598C
		public double VerticalTabArrangementSlant
		{
			get
			{
				short num = (short)2011036736;
				short num2 = num;
				num = (short)1319500864;
				switch (num2 == num)
				{
				}
				num = (short)31326208;
				if (num != 0)
				{
				}
				num = (short)352321536;
				short num3 = num;
				num = (short)1428422657;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfEditors.NoteTabBorder.VerticalTabArrangementSlantProperty);
			}
			set
			{
				short num = (short)1819944993;
				short num2 = num;
				num = (short)883304481;
				switch (num2 == num)
				{
				}
				num = (short)1109262337;
				if (num != 0)
				{
				}
				num = (short)1564409856;
				short num3 = num;
				num = (short)588382208;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.NoteTabBorder.VerticalTabArrangementSlantProperty, value);
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00047844 File Offset: 0x00045A44
		static NoteTabBorder()
		{
			int a_ = 10;
			short num = (short)1544537794;
			short num2 = num;
			num = (short)158844610;
			switch (num2 == num)
			{
			}
			num = (short)206897152;
			if (num != 0)
			{
			}
			num = (short)1094647808;
			short num3 = num;
			num = (short)253755393;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.NoteTabBorder.TabStripPlacementProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("菖룘맚軜ꯞ鏠諢闤럦藨諪軬諮鳰雲鯴菶", a_), typeof(global::System.Windows.Controls.Dock), typeof(global::DevComponents.WpfEditors.NoteTabBorder), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Dock.Top, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));
			global::DevComponents.WpfEditors.NoteTabBorder.VerticalTabArrangementSlantProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("臖볘꧚꧜뛞苠苢觤돦裨觪곬鷮菰鋲鯴郶鳸雺飼釾甀倂椄昆月缊", a_), typeof(double), typeof(global::DevComponents.WpfEditors.NoteTabBorder), new global::System.Windows.UIPropertyMetadata(20.0));
			global::DevComponents.WpfEditors.NoteTabBorder.BorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闖뛘꧚맜뫞鏠ꇢ韤鋦髨菪", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.NoteTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfEditors.NoteTabBorder.BorderInnerBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闖뛘꧚맜뫞鏠ꫢ诤触賨駪꿬鷮蓰胲鷴", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.NoteTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfEditors.NoteTabBorder.BackgroundProperty = global::System.Windows.Controls.Panel.BackgroundProperty.AddOwner(typeof(global::DevComponents.WpfEditors.NoteTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfEditors.NoteTabBorder.BottomBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闖뛘꿚꧜냞賠ꇢ諤闦跨軪鿬귮菰蛲蛴鿶", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.NoteTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00047A38 File Offset: 0x00045C38
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)541196306;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Size desiredSize;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_307;
				case 1:
					if (this.TabStripPlacement != global::System.Windows.Controls.Dock.Top)
					{
						goto IL_4C1;
					}
					goto IL_4DF;
				case 2:
					desiredSize.Width = constraint.Width;
					num = (short)553123850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)844693516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return desiredSize;
				case 5:
					num = (short)89915418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (this.TabStripPlacement == global::System.Windows.Controls.Dock.Bottom)
					{
						num = (short)2056912915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					desiredSize.Height += this.VerticalTabArrangementSlant + 2.0;
					num = (short)762839040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (this.TabStripPlacement == global::System.Windows.Controls.Dock.Right)
					{
						num = (short)1412104213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return desiredSize;
				case 8:
					return desiredSize;
				case 9:
					if (desiredSize.Height > constraint.Height)
					{
						num = (short)1363083269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return desiredSize;
				case 10:
					goto IL_57D;
				case 11:
				{
					global::System.Windows.Size availableSize = constraint;
					availableSize.Width = global::System.Math.Max(0.0, availableSize.Width - 4.0);
					availableSize.Height = global::System.Math.Max(0.0, availableSize.Height - 4.0);
					this.Child.Measure(availableSize);
					desiredSize = this.Child.DesiredSize;
					desiredSize.Width += 4.0;
					desiredSize.Height += 4.0;
					num = (short)2118975489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					if (this.TabStripPlacement == global::System.Windows.Controls.Dock.Bottom)
					{
						num = (short)1843462158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5AC;
				case 13:
					return desiredSize;
				case 14:
					goto IL_2B7;
				case 15:
					if (constraint.Height > this.VerticalTabArrangementSlant + 10.0)
					{
						num = (short)1955659800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					desiredSize.Height = this.VerticalTabArrangementSlant + 10.0;
					num = (short)264044548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_307;
				case 17:
					num = (short)1834811399;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					switch (0)
					{
					case 0:
						goto IL_94;
					}
					continue;
				case 19:
					goto IL_4DF;
				case 20:
					num = (short)1314848774;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_37A;
				case 22:
					if (this.TabStripPlacement != global::System.Windows.Controls.Dock.Top)
					{
						num = (short)131727363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B7;
				case 23:
					if (desiredSize.Width > constraint.Width)
					{
						num = (short)1872560153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5AC;
				case 24:
					desiredSize.Height = constraint.Height;
					num = (short)670367757;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					num = (short)353239062;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
				{
					num = (short)97053699;
					short num3 = num;
					num = (short)1255140355;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4C1;
					default:
						num = (short)311427072;
						if (num != 0)
						{
						}
						if (this.TabStripPlacement != global::System.Windows.Controls.Dock.Left)
						{
							num = (short)1774977041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37A;
					}
					break;
				}
				case 27:
					if (constraint.Width > this.VerticalTabArrangementSlant + 10.0)
					{
						num = (short)1297743874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)983695361;
					if (num != 0)
					{
					}
					desiredSize.Width = this.VerticalTabArrangementSlant + 10.0;
					num = (short)623640584;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_94:
				if (this.Child != null)
				{
					num = (short)2036400139;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_5F3;
				IL_2B7:
				num = (short)2031812635;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_307:
				global::DevComponents.WpfEditors.d.a(ref desiredSize);
				desiredSize.Width = global::System.Math.Ceiling(desiredSize.Width);
				desiredSize.Height = global::System.Math.Ceiling(desiredSize.Height);
				num = (short)715194391;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_37A:
				num = (short)1556021263;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4C1:
				num = (short)1064894484;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4DF:
				desiredSize.Width += desiredSize.Height + 2.0;
				num = (short)312737808;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5AC:
				num = (short)1033240585;
				num2 = (int)((global::System.IntPtr)num);
			}
			return desiredSize;
			IL_57D:
			num = (short)706019328;
			short num4 = num;
			return desiredSize;
			IL_5F3:
			return base.MeasureOverride(constraint);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00048040 File Offset: 0x00046240
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeSize)
		{
			short num = (short)1610612736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_90;
				}
				global::System.Windows.Rect finalRect;
				global::System.Windows.Controls.Dock tabStripPlacement;
				for (;;)
				{
					IL_29:
					double verticalTabArrangementSlant;
					double verticalTabArrangementSlant2;
					switch (num2)
					{
					case 0:
						num = (short)1497366529;
						if (num != 0)
						{
						}
						this.Child.Arrange(finalRect);
						num = (short)1902510090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_12A;
					case 2:
						if (this.Child != null)
						{
							num = (short)2125201417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12A;
					case 3:
						return arrangeSize;
					case 4:
						verticalTabArrangementSlant = this.VerticalTabArrangementSlant;
						finalRect.Height = global::System.Math.Max(0.0, arrangeSize.Height - 2.0 - verticalTabArrangementSlant);
						finalRect.Width = global::System.Math.Max(0.0, arrangeSize.Width - 4.0);
						finalRect.Y = 2.0;
						finalRect.X = global::System.Math.Min(2.0, arrangeSize.Width);
						num = (short)1051787279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						finalRect.Width = global::System.Math.Max(0.0, arrangeSize.Width - 2.0 - arrangeSize.Height);
						finalRect.Height = global::System.Math.Max(0.0, arrangeSize.Height - 4.0);
						finalRect.X = 2.0;
						finalRect.Y = global::System.Math.Min(2.0, arrangeSize.Height);
						num = (short)892600327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						this.Child.Arrange(finalRect);
						num = (short)388956180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (this.Child != null)
						{
							num = (short)1960771596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_413;
					case 8:
						verticalTabArrangementSlant2 = this.VerticalTabArrangementSlant;
						finalRect.Height = global::System.Math.Max(0.0, arrangeSize.Height - 2.0 - verticalTabArrangementSlant2);
						finalRect.Width = global::System.Math.Max(0.0, arrangeSize.Width - 4.0);
						finalRect.Y = 2.0;
						finalRect.X = global::System.Math.Min(2.0, arrangeSize.Width);
						num = (short)1392771074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						this.Child.Arrange(finalRect);
						num = (short)1943470081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_9F1;
					case 11:
						if (tabStripPlacement == global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)1610809365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)437125133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						this.Child.Arrange(finalRect);
						num = (short)1715929088;
						short num3 = num;
						num = (short)884473873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (tabStripPlacement == global::System.Windows.Controls.Dock.Left)
						{
							num = (short)985202696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)47841298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						if (tabStripPlacement != global::System.Windows.Controls.Dock.Top)
						{
							num = (short)1907032075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1863097329;
						short num4 = num;
						num = (short)337878001;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)888209408;
							if (num != 0)
							{
							}
							num = (short)1558970373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 15:
						if (this.Child != null)
						{
							num = (short)591331334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_784;
					case 16:
						if (this.Child != null)
						{
							num = (short)199032832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9F1;
					case 17:
						goto IL_413;
					case 18:
						if (tabStripPlacement == global::System.Windows.Controls.Dock.Right)
						{
							num = (short)2052390916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return arrangeSize;
					case 19:
						return arrangeSize;
					case 20:
						goto IL_784;
					case 21:
						finalRect.Width = global::System.Math.Max(0.0, arrangeSize.Width - 2.0 - arrangeSize.Height);
						finalRect.Height = global::System.Math.Max(0.0, arrangeSize.Height - 4.0);
						finalRect.X = 2.0;
						finalRect.Y = global::System.Math.Min(2.0, arrangeSize.Height);
						num = (short)108986384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						return arrangeSize;
					case 23:
						return arrangeSize;
					}
					goto IL_90;
					IL_12A:
					this.a = new global::System.Windows.Media.PathGeometry();
					this.a.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(arrangeSize.Width, 0.5), new global::System.Windows.Media.PathSegment[]
					{
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(3.0, 0.5), true),
						new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(3.0, 0.5), new global::System.Windows.Size(3.5, 3.5), 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(0.5, 3.5), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(0.5, arrangeSize.Height - verticalTabArrangementSlant2), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width, arrangeSize.Height), true)
					}, false));
					this.b = new global::System.Windows.Media.PathGeometry();
					this.b.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(arrangeSize.Width, 1.5), new global::System.Windows.Media.PathSegment[]
					{
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(4.0, 1.5), true),
						new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(4.0, 1.5), new global::System.Windows.Size(3.5, 3.5), 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(1.5, 4.5), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(1.5, arrangeSize.Height - verticalTabArrangementSlant2 - 1.0), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width, arrangeSize.Height - 1.0), true)
					}, false));
					num = (short)199426070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_413:
					this.a = new global::System.Windows.Media.PathGeometry();
					this.a.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(0.5, arrangeSize.Height), new global::System.Windows.Media.PathSegment[]
					{
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(0.5, 3.0), true),
						new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(0.5, 3.0), new global::System.Windows.Size(3.5, 3.5), 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(3.5, 0.5), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - arrangeSize.Height, 0.5), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width, arrangeSize.Height), true)
					}, false));
					this.b = new global::System.Windows.Media.PathGeometry();
					this.b.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(1.5, arrangeSize.Height), new global::System.Windows.Media.PathSegment[]
					{
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(1.5, 4.0), true),
						new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(1.5, 4.0), new global::System.Windows.Size(3.5, 3.5), 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(4.5, 1.5), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - arrangeSize.Height - 1.0, 1.5), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 1.0, arrangeSize.Height), true)
					}, false));
					num = (short)338100227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_784:
					this.a = new global::System.Windows.Media.PathGeometry();
					this.a.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(0.0, 0.5), new global::System.Windows.Media.PathSegment[]
					{
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 3.0, 0.5), true),
						new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(arrangeSize.Width - 3.0, 0.5), new global::System.Windows.Size(3.5, 3.5), 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 0.5, 3.5), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 0.5, arrangeSize.Height - verticalTabArrangementSlant), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(0.0, arrangeSize.Height), true)
					}, false));
					this.b = new global::System.Windows.Media.PathGeometry();
					this.b.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(0.0, 1.5), new global::System.Windows.Media.PathSegment[]
					{
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 4.0, 1.5), true),
						new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(arrangeSize.Width - 4.0, 1.5), new global::System.Windows.Size(3.5, 3.5), 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 1.5, 4.5), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 1.5, arrangeSize.Height - verticalTabArrangementSlant - 1.0), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(0.0, arrangeSize.Height - 1.0), true)
					}, false));
					num = (short)93061143;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9F1:
					this.a = new global::System.Windows.Media.PathGeometry();
					this.a.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(0.5, 0.0), new global::System.Windows.Media.PathSegment[]
					{
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(0.5, arrangeSize.Height - 3.0), true),
						new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(0.5, arrangeSize.Height - 3.0), new global::System.Windows.Size(3.5, 3.5), 0.0, false, global::System.Windows.Media.SweepDirection.Counterclockwise, true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(3.5, arrangeSize.Height - 0.5), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - arrangeSize.Height, arrangeSize.Height - 0.5), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width, 0.0), true)
					}, false));
					this.b = new global::System.Windows.Media.PathGeometry();
					this.b.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(1.5, 0.0), new global::System.Windows.Media.PathSegment[]
					{
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(1.5, arrangeSize.Height - 4.0), true),
						new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(1.5, arrangeSize.Height - 4.0), new global::System.Windows.Size(3.5, 3.5), 0.0, false, global::System.Windows.Media.SweepDirection.Counterclockwise, true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(4.5, arrangeSize.Height - 1.5), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - arrangeSize.Height - 1.0, arrangeSize.Height - 1.5), true),
						new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - 1.0, 0.0), true)
					}, false));
					num = (short)650313747;
					num2 = (int)((global::System.IntPtr)num);
				}
				return arrangeSize;
				IL_90:
				finalRect = default(global::System.Windows.Rect);
				tabStripPlacement = this.TabStripPlacement;
				num = (short)544866318;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00048F70 File Offset: 0x00047170
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
					goto IL_216;
				case 1:
					drawingContext.DrawLine(new global::System.Windows.Media.Pen(this.BottomBorderBrush, 1.2), new global::System.Windows.Point(0.0, base.ActualHeight - 0.5), new global::System.Windows.Point(base.ActualWidth - 1.0, base.ActualHeight - 0.5));
					num2 = (short)1176436750;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1424228353;
					if (num2 != 0)
					{
					}
					pen = new global::System.Windows.Media.Pen(this.BorderBrush, 1.0);
					num2 = (short)434241542;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					base.VisualXSnappingGuidelines = new global::System.Windows.Media.DoubleCollection(new double[]
					{
						0.0,
						base.ActualWidth
					});
					num2 = (short)803667987;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					base.VisualYSnappingGuidelines = new global::System.Windows.Media.DoubleCollection(new double[]
					{
						0.0,
						base.ActualHeight
					});
					num2 = (short)728825866;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1799553033;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_2CE;
				case 7:
					goto IL_3BE;
				case 8:
					if (this.a != null)
					{
						num2 = (short)883032069;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 9:
					if (this.Background == null)
					{
						num2 = (short)1367277586;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_320;
				case 10:
					return;
				case 11:
					if (this.BorderInnerBrush != null)
					{
						num2 = (short)1991704591;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3BE;
				case 12:
					if (base.VisualYSnappingGuidelines == null)
					{
						num2 = (short)1571880964;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 13:
				{
					num2 = (short)1073843783;
					short num3 = num2;
					num2 = (short)1891601991;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E3;
					default:
					{
						num2 = (short)1274740736;
						short num4 = num2;
						num2 = (short)1150091264;
						if (num2 != 0)
						{
						}
						if (this.BorderBrush == null)
						{
							num2 = (short)1189937152;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_320;
					}
					}
					break;
				}
				case 14:
					goto IL_A7;
				case 15:
					goto IL_E3;
				case 16:
					if (this.BorderBrush != null)
					{
						num2 = (short)1382154242;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2CE;
				case 17:
					if (base.VisualXSnappingGuidelines == null)
					{
						num2 = (short)1178927107;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_125;
				case 18:
					num2 = (short)901644301;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					goto IL_125;
				case 20:
					if (this.BottomBorderBrush != null)
					{
						num2 = (short)1672216577;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A7;
				}
				goto IL_64;
				IL_A7:
				num2 = (short)834535441;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_E3:
				pen = new global::System.Windows.Media.Pen(this.BorderInnerBrush, 1.0);
				drawingContext.DrawGeometry(null, pen, this.b);
				num2 = (short)1691680775;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_125:
				num2 = (short)36175884;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2CE:
				drawingContext.DrawGeometry(this.Background, pen, this.a);
				num2 = (short)2137587723;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_320:
				pen = null;
				num2 = (short)1583153168;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3BE:
				num2 = (short)2038366228;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_216:
			return;
			IL_64:
			base.OnRender(drawingContext);
			num2 = (short)1039532040;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000399 RID: 921 RVA: 0x000493EC File Offset: 0x000475EC
		// (set) Token: 0x0600039A RID: 922 RVA: 0x000494A4 File Offset: 0x000476A4
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush Background
		{
			get
			{
				short num = (short)1201149064;
				short num2 = num;
				num = (short)912528520;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1367539712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1994129408;
				if (num != 0)
				{
				}
				num = (short)1972371457;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.NoteTabBorder.BackgroundProperty);
			}
			set
			{
				short num = (short)454110817;
				short num2 = num;
				num = (short)197275233;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1967128576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)393805825;
				if (num != 0)
				{
				}
				num = (short)1048444928;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.NoteTabBorder.BackgroundProperty, value);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00049558 File Offset: 0x00047758
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00049614 File Offset: 0x00047814
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderBrush
		{
			get
			{
				short num = (short)334083884;
				short num2 = num;
				num = (short)1322235692;
				switch (num2 == num)
				{
				default:
				{
					num = (short)191889408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1855455233;
				if (num != 0)
				{
				}
				num = (short)1420492800;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.NoteTabBorder.BorderBrushProperty);
			}
			set
			{
				short num = (short)1984492289;
				short num2 = num;
				num = (short)1623520001;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1983709184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1758134273;
				if (num != 0)
				{
				}
				num = (short)1873215488;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.NoteTabBorder.BorderBrushProperty, value);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600039D RID: 925 RVA: 0x000496CC File Offset: 0x000478CC
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00049788 File Offset: 0x00047988
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderInnerBrush
		{
			get
			{
				short num = (short)1098219695;
				short num2 = num;
				num = (short)1746501807;
				switch (num2 == num)
				{
				default:
				{
					num = (short)233766912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)704249857;
				if (num != 0)
				{
				}
				num = (short)417136640;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.NoteTabBorder.BorderInnerBrushProperty);
			}
			set
			{
				short num = (short)1550404334;
				short num2 = num;
				num = (short)178801390;
				switch (num2 == num)
				{
				default:
				{
					num = (short)927072256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1932394496;
				if (num != 0)
				{
				}
				num = (short)2023424001;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.NoteTabBorder.BorderInnerBrushProperty, value);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0004983C File Offset: 0x00047A3C
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x000498F8 File Offset: 0x00047AF8
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BottomBorderBrush
		{
			get
			{
				short num = (short)1076625409;
				if (num != 0)
				{
				}
				num = (short)1265172480;
				short num2 = num;
				num = (short)1149276251;
				short num3 = num;
				num = (short)2065731675;
				switch (num3 == num)
				{
				}
				num = (short)1471610880;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.NoteTabBorder.BottomBorderBrushProperty);
			}
			set
			{
				short num = (short)336448088;
				short num2 = num;
				num = (short)1141951064;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1497038848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1830027265;
				if (num != 0)
				{
				}
				num = (short)1189543936;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.NoteTabBorder.BottomBorderBrushProperty, value);
			}
		}

		// Token: 0x040001C0 RID: 448
		public static readonly global::System.Windows.DependencyProperty BackgroundProperty;

		// Token: 0x040001C1 RID: 449
		public static readonly global::System.Windows.DependencyProperty BorderBrushProperty;

		// Token: 0x040001C2 RID: 450
		public static readonly global::System.Windows.DependencyProperty BorderInnerBrushProperty;

		// Token: 0x040001C3 RID: 451
		public static readonly global::System.Windows.DependencyProperty BottomBorderBrushProperty;

		// Token: 0x040001C4 RID: 452
		public static readonly global::System.Windows.DependencyProperty TabStripPlacementProperty;

		// Token: 0x040001C5 RID: 453
		public static readonly global::System.Windows.DependencyProperty VerticalTabArrangementSlantProperty;

		// Token: 0x040001C6 RID: 454
		private global::System.Windows.Media.PathGeometry a;

		// Token: 0x040001C7 RID: 455
		private global::System.Windows.Media.PathGeometry b;
	}
}
