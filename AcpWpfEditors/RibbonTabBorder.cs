using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000033 RID: 51
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class RibbonTabBorder : global::System.Windows.Controls.Decorator
	{
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x000499C0 File Offset: 0x00047BC0
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00049A78 File Offset: 0x00047C78
		public global::System.Windows.Controls.Dock TabStripPlacement
		{
			get
			{
				short num = (short)1611156951;
				short num2 = num;
				num = (short)1975602647;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1256062976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2016608256;
				if (num != 0)
				{
				}
				num = (short)1384054785;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.Dock)base.GetValue(global::DevComponents.WpfEditors.RibbonTabBorder.TabStripPlacementProperty);
			}
			set
			{
				short num = (short)995819521;
				if (num != 0)
				{
				}
				num = (short)1240727552;
				short num2 = num;
				num = (short)885942800;
				short num3 = num;
				num = (short)965241360;
				switch (num3 == num)
				{
				}
				num = (short)1675886592;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.RibbonTabBorder.TabStripPlacementProperty, value);
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00049B34 File Offset: 0x00047D34
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00049BEC File Offset: 0x00047DEC
		public double CornerSize
		{
			get
			{
				short num = (short)1138288903;
				short num2 = num;
				num = (short)713746695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1197146112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)430112769;
				if (num != 0)
				{
				}
				num = (short)2110783488;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfEditors.RibbonTabBorder.CornerSizeProperty);
			}
			set
			{
				short num = (short)166351278;
				short num2 = num;
				num = (short)484200878;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1888747520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)628883457;
				if (num != 0)
				{
				}
				num = (short)1372651520;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.RibbonTabBorder.CornerSizeProperty, value);
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00049CA8 File Offset: 0x00047EA8
		static RibbonTabBorder()
		{
			int a_ = 17;
			short num = (short)1833504511;
			short num2 = num;
			num = (short)1332743935;
			switch (num2 == num)
			{
			default:
			{
				num = (short)976683008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1944911873;
			if (num != 0)
			{
			}
			num = (short)1082589184;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.RibbonTabBorder.TabStripPlacementProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("諝臟胡럣鋥髧菩鳫뻭鳯鏱音鏵闷鿹鋻諽", a_), typeof(global::System.Windows.Controls.Dock), typeof(global::DevComponents.WpfEditors.RibbonTabBorder), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Dock.Top, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));
			global::DevComponents.WpfEditors.RibbonTabBorder.CornerSizeProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝迟郡諣菥髧맩藫铭闯", a_), typeof(double), typeof(global::DevComponents.WpfEditors.RibbonTabBorder), new global::System.Windows.FrameworkPropertyMetadata(3.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfEditors.RibbonTabBorder.BorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鳝迟郡胣菥髧꣩黫鯭華髱", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.RibbonTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfEditors.RibbonTabBorder.BorderInnerBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鳝迟郡胣菥髧ꏩ苫胭闯胱뛳蓵跷觹铻", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.RibbonTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfEditors.RibbonTabBorder.BackgroundProperty = global::System.Windows.Controls.Panel.BackgroundProperty.AddOwner(typeof(global::DevComponents.WpfEditors.RibbonTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00049E64 File Offset: 0x00048064
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			switch (0)
			{
			case 0:
				goto IL_80;
			}
			int num;
			global::System.Windows.Size desiredSize;
			short num2;
			double cornerSize;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					desiredSize.Width = constraint.Width;
					num2 = (short)393871371;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1123549201;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (this.TabStripPlacement == global::System.Windows.Controls.Dock.Right)
					{
						num2 = (short)570490900;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return desiredSize;
				case 3:
					num2 = (short)481689601;
					if (num2 != 0)
					{
					}
					if (this.TabStripPlacement == global::System.Windows.Controls.Dock.Bottom)
					{
						num2 = (short)1330774035;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15F;
				case 4:
					return desiredSize;
				case 5:
				{
					global::System.Windows.Size availableSize = constraint;
					availableSize.Width = global::System.Math.Max(0.0, availableSize.Width - cornerSize * 4.0);
					availableSize.Height = global::System.Math.Max(0.0, availableSize.Height - cornerSize * 4.0);
					this.Child.Measure(availableSize);
					desiredSize = this.Child.DesiredSize;
					desiredSize.Width += cornerSize * 2.0;
					desiredSize.Height += cornerSize * 2.0;
					num2 = (short)1372389401;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					goto IL_2E5;
				case 7:
				{
					if (constraint.Width > cornerSize * 6.0)
					{
						num2 = (short)789053440;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					desiredSize.Width = cornerSize * 6.0;
					num2 = (short)351141888;
					short num3 = num2;
					num2 = (short)135856132;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					goto IL_331;
				case 9:
					return desiredSize;
				case 10:
					return desiredSize;
				case 11:
					goto IL_5A2;
				case 12:
					num2 = (short)1573584898;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (desiredSize.Height > constraint.Height)
					{
						num2 = (short)691208210;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return desiredSize;
				case 14:
				{
					if (constraint.Height > cornerSize * 6.0)
					{
						num2 = (short)427360278;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1454641858;
					short num4 = num2;
					num2 = (short)396104386;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15F;
					default:
						num2 = (short)1122893824;
						if (num2 != 0)
						{
						}
						desiredSize.Height = cornerSize * 6.0;
						num2 = (short)77135882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 15:
					if (this.Child != null)
					{
						num2 = (short)224395269;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5EE;
				case 16:
					if (this.TabStripPlacement == global::System.Windows.Controls.Dock.Bottom)
					{
						num2 = (short)750845958;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5A7;
				case 17:
					if (this.TabStripPlacement != global::System.Windows.Controls.Dock.Top)
					{
						num2 = (short)320077847;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E5;
				case 18:
					num2 = (short)1096155160;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					goto IL_50B;
				case 20:
					goto IL_3A3;
				case 21:
					if (desiredSize.Width > constraint.Width)
					{
						num2 = (short)592642049;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5A7;
				case 22:
					desiredSize.Height = constraint.Height;
					num2 = (short)2144927753;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					num2 = (short)498270224;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					if (this.TabStripPlacement != global::System.Windows.Controls.Dock.Left)
					{
						num2 = (short)347275276;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3A3;
				case 25:
					if (this.TabStripPlacement != global::System.Windows.Controls.Dock.Top)
					{
						num2 = (short)889192474;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_50B;
				case 26:
					num2 = (short)1315897347;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					goto IL_331;
				}
				goto IL_80;
				IL_15F:
				desiredSize.Height += cornerSize * 2.0;
				num2 = (short)1565589512;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2E5:
				num2 = (short)681246727;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_331:
				global::DevComponents.WpfEditors.d.a(ref desiredSize);
				desiredSize.Width = global::System.Math.Ceiling(desiredSize.Width);
				desiredSize.Height = global::System.Math.Ceiling(desiredSize.Height);
				num2 = (short)1269301269;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3A3:
				num2 = (short)475660302;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_50B:
				desiredSize.Width += cornerSize * 2.0;
				num2 = (short)1463877659;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5A7:
				num2 = (short)480378893;
				num = (int)((global::System.IntPtr)num2);
			}
			return desiredSize;
			IL_5A2:
			return desiredSize;
			IL_5EE:
			return base.MeasureOverride(constraint);
			IL_80:
			cornerSize = this.CornerSize;
			num2 = (short)1016528911;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0004A468 File Offset: 0x00048668
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeSize)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			global::System.Windows.Rect finalRect;
			global::System.Windows.Controls.Dock tabStripPlacement;
			double cornerSize;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1469054979;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					this.Child.Arrange(finalRect);
					num2 = (short)1606680586;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_2A5;
				case 3:
					num2 = (short)1040711681;
					if (num2 != 0)
					{
					}
					if (tabStripPlacement != global::System.Windows.Controls.Dock.Left)
					{
						num2 = (short)1074855940;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_400;
				case 4:
				{
					num2 = (short)382926848;
					short num3 = num2;
					num2 = (short)1511915529;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_400;
				case 6:
					if (this.Child != null)
					{
						num2 = (short)42598401;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E7;
				case 7:
					if (tabStripPlacement == global::System.Windows.Controls.Dock.Top)
					{
						num2 = (short)32112642;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)428539912;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (tabStripPlacement != global::System.Windows.Controls.Dock.Bottom)
					{
						num2 = (short)1891565568;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_400;
				case 9:
					goto IL_400;
				case 10:
					goto IL_E7;
				}
				goto IL_3C;
				IL_E7:
				this.a = new global::System.Windows.Media.PathGeometry();
				this.a.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(0.0, arrangeSize.Height), new global::System.Windows.Media.PathSegment[]
				{
					new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(0.0, arrangeSize.Height), new global::System.Windows.Size(cornerSize, cornerSize), 0.0, false, global::System.Windows.Media.SweepDirection.Counterclockwise, true),
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(cornerSize, arrangeSize.Height - cornerSize), true),
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(cornerSize, cornerSize), true),
					new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(cornerSize, cornerSize), new global::System.Windows.Size(cornerSize, cornerSize), 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true),
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(cornerSize, 0.0), true),
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - cornerSize * 2.0, 0.0), true),
					new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(arrangeSize.Width - cornerSize * 2.0, 0.0), new global::System.Windows.Size(cornerSize, cornerSize), 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true),
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - cornerSize, cornerSize), true),
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(arrangeSize.Width - cornerSize, arrangeSize.Height - cornerSize), true),
					new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(arrangeSize.Width - cornerSize, arrangeSize.Height - cornerSize), new global::System.Windows.Size(cornerSize, cornerSize), 0.0, false, global::System.Windows.Media.SweepDirection.Counterclockwise, true)
				}, false));
				num2 = (short)542769157;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2A5:
				finalRect.Width = global::System.Math.Max(0.0, arrangeSize.Width - cornerSize * 4.0);
				finalRect.Height = global::System.Math.Max(0.0, arrangeSize.Height - cornerSize * 2.0);
				finalRect.X += cornerSize * 2.0;
				finalRect.Y += cornerSize;
				num2 = (short)779681798;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_400:
				num2 = (short)645751157;
				short num4 = num2;
				num2 = (short)2078761333;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2A5;
				default:
					goto IL_435;
				}
			}
			IL_435:
			num2 = (short)932118528;
			if (num2 != 0)
			{
			}
			return arrangeSize;
			IL_3C:
			finalRect = default(global::System.Windows.Rect);
			tabStripPlacement = this.TabStripPlacement;
			cornerSize = this.CornerSize;
			num2 = (short)807337991;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0004A8C0 File Offset: 0x00048AC0
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			switch (0)
			{
			case 0:
				goto IL_74;
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
					if (base.VisualXSnappingGuidelines == null)
					{
						num2 = (short)172163093;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2EA;
				case 1:
					drawingContext.DrawGeometry(this.Background, pen, this.a);
					num2 = (short)955318285;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_1A7;
				case 3:
					if (this.Background == null)
					{
						num2 = (short)900202506;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2A9;
				case 4:
					if (base.VisualYSnappingGuidelines == null)
					{
						num2 = (short)1379729432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					if (this.b != null)
					{
						num2 = (short)1701380116;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_375;
				case 6:
					goto IL_375;
				case 7:
				{
					num2 = (short)1754529792;
					short num3 = num2;
					num2 = (short)69599237;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					goto IL_425;
				case 9:
					num2 = (short)32768016;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)781451287;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (this.a != null)
					{
						num2 = (short)1030619145;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F8;
				case 12:
					if (this.BorderInnerBrush != null)
					{
						num2 = (short)102432775;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_375;
				case 13:
					goto IL_F8;
				case 14:
					goto IL_243;
				case 15:
					IL_167:
					goto IL_2EA;
				case 16:
					if (pen != null)
					{
						num2 = (short)2000224257;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F8;
				case 17:
					pen = new global::System.Windows.Media.Pen(this.BorderBrush, 1.0);
					num2 = (short)1115881480;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					if (this.BorderBrush != null)
					{
						num2 = (short)1022951441;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_425;
				case 19:
					num2 = (short)33030147;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					pen = new global::System.Windows.Media.Pen(this.BorderInnerBrush, 1.0);
					drawingContext.DrawGeometry(null, pen, this.b);
					num2 = (short)1245315078;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					base.VisualXSnappingGuidelines = new global::System.Windows.Media.DoubleCollection(new double[]
					{
						0.0,
						base.ActualWidth
					});
					num2 = (short)489029647;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (this.a != null)
					{
						num2 = (short)195428371;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 23:
					if (this.BorderBrush == null)
					{
						num2 = (short)1429405698;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2A9;
				case 24:
					base.VisualYSnappingGuidelines = new global::System.Windows.Media.DoubleCollection(new double[]
					{
						0.0,
						base.ActualHeight
					});
					num2 = (short)1713504270;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_74;
				IL_F8:
				num2 = (short)2022506508;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2A9:
				pen = null;
				num2 = (short)1194917906;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2EA:
				num2 = (short)2105204409;
				short num4 = num2;
				num2 = (short)1983831737;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_167;
				default:
					num2 = (short)774242304;
					if (num2 != 0)
					{
					}
					num2 = (short)1556545540;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_375:
				num2 = (short)1800536064;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_425:
				num2 = (short)1508245515;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1A7:
			return;
			IL_243:
			num2 = (short)1842282497;
			if (num2 != 0)
			{
			}
			return;
			IL_74:
			base.OnRender(drawingContext);
			num2 = (short)2072641558;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0004AD64 File Offset: 0x00048F64
		// (set) Token: 0x060003AB RID: 939 RVA: 0x0004AE20 File Offset: 0x00049020
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush Background
		{
			get
			{
				short num = (short)834469889;
				if (num != 0)
				{
				}
				num = (short)480432852;
				short num2 = num;
				num = (short)361616084;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1702297600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1000996864;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.RibbonTabBorder.BackgroundProperty);
			}
			set
			{
				short num = (short)1828323582;
				short num2 = num;
				num = (short)2002714878;
				switch (num2 == num)
				{
				}
				num = (short)629866496;
				short num3 = num;
				num = (short)803209217;
				if (num != 0)
				{
				}
				num = (short)1306132480;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.RibbonTabBorder.BackgroundProperty, value);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0004AED8 File Offset: 0x000490D8
		// (set) Token: 0x060003AD RID: 941 RVA: 0x0004AF90 File Offset: 0x00049190
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderBrush
		{
			get
			{
				short num = (short)2023601748;
				short num2 = num;
				num = (short)1964226132;
				switch (num2 == num)
				{
				}
				num = (short)830210048;
				short num3 = num;
				num = (short)793509888;
				if (num != 0)
				{
				}
				num = (short)876675073;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.RibbonTabBorder.BorderBrushProperty);
			}
			set
			{
				short num = (short)1073479681;
				if (num != 0)
				{
				}
				num = (short)1012425776;
				short num2 = num;
				num = (short)1307075632;
				switch (num2 == num)
				{
				default:
				{
					num = (short)79167488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2103640064;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.RibbonTabBorder.BorderBrushProperty, value);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0004B048 File Offset: 0x00049248
		// (set) Token: 0x060003AF RID: 943 RVA: 0x0004B104 File Offset: 0x00049304
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderInnerBrush
		{
			get
			{
				short num = (short)1327975872;
				short num2 = num;
				num = (short)1066159552;
				switch (num2 == num)
				{
				}
				num = (short)973996032;
				short num3 = num;
				num = (short)174129152;
				if (num != 0)
				{
				}
				num = (short)72351745;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.RibbonTabBorder.BorderInnerBrushProperty);
			}
			set
			{
				short num = (short)1358984046;
				short num2 = num;
				num = (short)307196782;
				switch (num2 == num)
				{
				}
				num = (short)1734868992;
				short num3 = num;
				num = (short)2104688641;
				if (num != 0)
				{
				}
				num = (short)1092812800;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.RibbonTabBorder.BorderInnerBrushProperty, value);
			}
		}

		// Token: 0x040001C8 RID: 456
		public static readonly global::System.Windows.DependencyProperty BackgroundProperty;

		// Token: 0x040001C9 RID: 457
		public static readonly global::System.Windows.DependencyProperty BorderBrushProperty;

		// Token: 0x040001CA RID: 458
		public static readonly global::System.Windows.DependencyProperty BorderInnerBrushProperty;

		// Token: 0x040001CB RID: 459
		public static readonly global::System.Windows.DependencyProperty TabStripPlacementProperty;

		// Token: 0x040001CC RID: 460
		public static readonly global::System.Windows.DependencyProperty CornerSizeProperty;

		// Token: 0x040001CD RID: 461
		private global::System.Windows.Media.PathGeometry a;

		// Token: 0x040001CE RID: 462
		private global::System.Windows.Media.PathGeometry b;
	}
}
