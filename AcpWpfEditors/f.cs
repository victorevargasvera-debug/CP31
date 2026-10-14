using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000042 RID: 66
	internal class f : global::System.Windows.Documents.Adorner
	{
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0005DCE8 File Offset: 0x0005BEE8
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x0005DDA0 File Offset: 0x0005BFA0
		public global::System.Windows.Media.Brush a
		{
			get
			{
				short num = (short)1311901450;
				short num2 = num;
				num = (short)1651640074;
				switch (num2 == num)
				{
				}
				num = (short)810549248;
				if (num != 0)
				{
				}
				num = (short)1618804737;
				if (num != 0)
				{
				}
				num = (short)2089287680;
				short num3 = num;
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.f.aProperty);
			}
			set
			{
				short num = (short)303169537;
				if (num != 0)
				{
				}
				num = (short)406811313;
				short num2 = num;
				num = (short)1548513969;
				switch (num2 == num)
				{
				}
				num = (short)37486592;
				if (num != 0)
				{
				}
				num = (short)868155392;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.f.aProperty, value);
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0005DE58 File Offset: 0x0005C058
		public f(global::DevComponents.WpfEditors.SuperTabItem A_0)
		{
			int a_ = 2;
			base..ctor(A_0);
			this.b = new global::System.Windows.Media.PathGeometry();
			base.SetResourceReference(global::DevComponents.WpfEditors.f.aProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfEditors.SuperTabItem), global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("蛎뿐ꃒ냔ꗖ귘雚볜귞諠蛢韤", a_)));
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0005DEA8 File Offset: 0x0005C0A8
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			short num = (short)1061617665;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					drawingContext.DrawGeometry(this.a, null, this.b);
					num = (short)803995650;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)497418241;
					if (num != 0)
					{
					}
					num = (short)1926479466;
					short num3 = num;
					num = (short)1299889770;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B7;
					default:
						num = (short)546701312;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					}
					break;
				}
				case 2:
					goto IL_125;
				case 3:
				{
					num = (short)788332544;
					short num4 = num;
					num = (short)372310020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (this.a != null)
					{
						num = (short)2049769472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_162;
				}
				goto IL_AC;
				IL_B7:
				num = (short)1547370499;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AC:
				if (this.b != null)
				{
					goto IL_B7;
				}
				break;
			}
			IL_125:
			IL_162:
			base.OnRender(drawingContext);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0005E020 File Offset: 0x0005C220
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)690094088;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Point point;
				global::DevComponents.WpfEditors.SuperTabItem superTabItem;
				global::System.Windows.Point point2;
				switch (num2)
				{
				case 0:
					point = new global::System.Windows.Point(finalSize.Width - 11.0, 0.0);
					goto IL_54E;
				case 1:
					goto IL_509;
				case 2:
					num = (short)423690240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_130;
				case 4:
					if (superTabItem.TabStripPlacement != global::System.Windows.Controls.Dock.Top)
					{
						num = (short)1621426182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_130;
				case 5:
					point = new global::System.Windows.Point(3.0, 0.0);
					goto IL_54E;
				case 6:
					num = (short)641400833;
					if (num != 0)
					{
					}
					num = (short)1255145484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					point2 = new global::System.Windows.Point(0.0, finalSize.Height - 5.0);
					goto IL_38D;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 9:
					point2 = new global::System.Windows.Point(0.0, -3.0);
					goto IL_38D;
				case 10:
					if (!this.c)
					{
						num = (short)2126577677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)849215497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_2AA;
				case 12:
					if (superTabItem.TabStripPlacement == global::System.Windows.Controls.Dock.Bottom)
					{
						num = (short)2144927747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)621084682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
				{
					num = (short)1731133440;
					short num3 = num;
					num = (short)2144538825;
					short num4 = num;
					num = (short)796397769;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2AF;
					default:
						num = (short)2088632320;
						if (num != 0)
						{
						}
						num = (short)299106311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_5D:
				if (!this.c)
				{
					num = (short)981008386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2AF;
				IL_130:
				global::System.Windows.Point point3;
				this.b.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(point3.X + 3.0, point3.Y + 0.0), new global::System.Windows.Media.PathSegment[]
				{
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(point3.X + 3.0, point3.Y + 5.0), true),
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(point3.X + 0.0, point3.Y + 5.0), true),
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(point3.X + 5.0, point3.Y + 10.0), true),
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(point3.X + 10.0, point3.Y + 5.0), true),
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(point3.X + 7.0, point3.Y + 5.0), true),
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(point3.X + 7.0, point3.Y + 0.0), true)
				}, true));
				num = (short)582025227;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2AF:
				num = (short)2069757957;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_38D:
				point3 = point2;
				this.b.Figures.Add(new global::System.Windows.Media.PathFigure(new global::System.Windows.Point(point3.X + 0.0, point3.Y + 3.0), new global::System.Windows.Media.PathSegment[]
				{
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(point3.X + 5.0, point3.Y + 3.0), true),
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(point3.X + 5.0, point3.Y + 0.0), true),
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(point3.X + 10.0, point3.Y + 5.0), true),
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(point3.X + 5.0, point3.Y + 10.0), true),
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(point3.X + 5.0, point3.Y + 7.0), true),
					new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(point3.X + 0.0, point3.Y + 7.0), true)
				}, true));
				num = (short)500105217;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_54E:
				point3 = point;
				this.b = new global::System.Windows.Media.PathGeometry();
				superTabItem = this.e();
				num = (short)1148780548;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2AA:
			IL_509:
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0005E5FC File Offset: 0x0005C7FC
		public global::DevComponents.WpfEditors.SuperTabItem e()
		{
			short num = (short)417857537;
			if (num != 0)
			{
			}
			num = (short)1375701395;
			short num2 = num;
			num = (short)612338067;
			switch (num2 == num)
			{
			}
			num = (short)1875705856;
			if (num != 0)
			{
			}
			num = (short)48824320;
			short num3 = num;
			return (global::DevComponents.WpfEditors.SuperTabItem)base.AdornedElement;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0005E6B0 File Offset: 0x0005C8B0
		public bool f()
		{
			short num = (short)2030494408;
			short num2 = num;
			num = (short)2011620040;
			switch (num2 == num)
			{
			}
			num = (short)752549889;
			if (num != 0)
			{
			}
			num = (short)207552512;
			if (num != 0)
			{
			}
			num = (short)1415380992;
			short num3 = num;
			return this.c;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0005E760 File Offset: 0x0005C960
		public void d(bool A_0)
		{
			short num = (short)1439760384;
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
					goto IL_A8;
				case 2:
				{
					num = (short)2072510464;
					short num3 = num;
					this.c = A_0;
					base.InvalidateArrange();
					base.InvalidateVisual();
					num = (short)757923841;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_30:
				if (this.c == A_0)
				{
					return;
				}
				num = (short)865337346;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A8:
			num = (short)2010679110;
			short num4 = num;
			num = (short)1615497030;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1598881792;
				if (num != 0)
				{
				}
				num = (short)1493303297;
				if (num != 0)
				{
				}
				break;
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0005E888 File Offset: 0x0005CA88
		// Note: this type is marked as 'beforefieldinit'.
		static f()
		{
			int a_ = 7;
			short num = (short)886057970;
			short num2 = num;
			num = (short)1831021554;
			switch (num2 == num)
			{
			}
			num = (short)561184769;
			if (num != 0)
			{
			}
			num = (short)627376128;
			if (num != 0)
			{
			}
			num = (short)1648361472;
			short num3 = num;
			global::DevComponents.WpfEditors.f.aProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("뗓", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.f), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x04000240 RID: 576
		public static readonly global::System.Windows.DependencyProperty aProperty;

		// Token: 0x04000241 RID: 577
		private global::System.Windows.Media.PathGeometry b;

		// Token: 0x04000242 RID: 578
		private bool c;
	}
}
