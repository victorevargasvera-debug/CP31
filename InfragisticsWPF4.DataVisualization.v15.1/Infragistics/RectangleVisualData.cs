using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Shapes;

namespace Infragistics
{
	// Token: 0x020000D3 RID: 211
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class RectangleVisualData : global::Infragistics.PrimitiveVisualData
	{
		// Token: 0x060008CC RID: 2252 RVA: 0x00028050 File Offset: 0x00026250
		public RectangleVisualData() : base("rect1")
		{
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x0002805D File Offset: 0x0002625D
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x00028065 File Offset: 0x00026265
		public double Width { get; set; }

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x0002806E File Offset: 0x0002626E
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x00028076 File Offset: 0x00026276
		public double Height { get; set; }

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x0002807F File Offset: 0x0002627F
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x00028087 File Offset: 0x00026287
		public double RadiusX { get; set; }

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00028090 File Offset: 0x00026290
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x00028098 File Offset: 0x00026298
		public double RadiusY { get; set; }

		// Token: 0x060008D5 RID: 2261 RVA: 0x000280A4 File Offset: 0x000262A4
		protected override string SerializeOverride()
		{
			return string.Concat(new object[]
			{
				"width: ",
				this.Width,
				", height: ",
				this.Height,
				", radiusX: ",
				this.RadiusX,
				", radiusY: ",
				this.RadiusY
			});
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00028118 File Offset: 0x00026318
		public RectangleVisualData(string name, global::System.Windows.Shapes.Rectangle rect) : base(name)
		{
			this.Width = rect.Width;
			this.Height = rect.Height;
			this.RadiusX = rect.RadiusX;
			this.RadiusY = rect.RadiusY;
			global::Infragistics.AppearanceHelper.GetShapeAppearance(base.Appearance, rect);
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x00028168 File Offset: 0x00026368
		public override string Type
		{
			get
			{
				return "Rectangle";
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0002816F File Offset: 0x0002636F
		public override void ScaleByViewport(global::System.Windows.Rect viewport)
		{
			base.ScaleByViewport(viewport);
			this.Width /= viewport.Width;
			this.Height /= viewport.Height;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x000281A0 File Offset: 0x000263A0
		public override void GetPointsOverride(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Windows.Point>> points, global::Infragistics.GetPointsSettings settings)
		{
			global::System.Collections.Generic.List<global::System.Windows.Point> list = new global::System.Collections.Generic.List<global::System.Windows.Point>();
			points.Add(list);
			list.Add(new global::System.Windows.Point(base.Appearance.CanvasLeft, base.Appearance.CanvasTop));
			list.Add(new global::System.Windows.Point(base.Appearance.CanvasLeft + this.Width, base.Appearance.CanvasTop));
			list.Add(new global::System.Windows.Point(base.Appearance.CanvasLeft + this.Width, base.Appearance.CanvasTop + this.Height));
			list.Add(new global::System.Windows.Point(base.Appearance.CanvasLeft, base.Appearance.CanvasTop + this.Height));
		}
	}
}
