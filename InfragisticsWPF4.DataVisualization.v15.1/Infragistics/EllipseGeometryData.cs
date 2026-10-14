using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Infragistics
{
	// Token: 0x020000DD RID: 221
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class EllipseGeometryData : global::Infragistics.GeometryData
	{
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00028E7E File Offset: 0x0002707E
		public override string Type
		{
			get
			{
				return "Ellipse";
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00028E85 File Offset: 0x00027085
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x00028E8D File Offset: 0x0002708D
		public double CenterX { get; set; }

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00028E96 File Offset: 0x00027096
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x00028E9E File Offset: 0x0002709E
		public double CenterY { get; set; }

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00028EA7 File Offset: 0x000270A7
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x00028EAF File Offset: 0x000270AF
		public double RadiusX { get; set; }

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00028EB8 File Offset: 0x000270B8
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x00028EC0 File Offset: 0x000270C0
		public double RadiusY { get; set; }

		// Token: 0x06000931 RID: 2353 RVA: 0x00028ECC File Offset: 0x000270CC
		protected override string SerializeOverride()
		{
			return string.Concat(new object[]
			{
				"centerX: ",
				this.CenterX,
				", centerY: ",
				this.CenterY,
				", radiusX: ",
				this.RadiusX,
				", radiusY: ",
				this.RadiusY
			});
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00028F40 File Offset: 0x00027140
		public override void ScaleByViewport(global::System.Windows.Rect viewport)
		{
			this.CenterX = (this.CenterX - viewport.Left) / viewport.Width;
			this.CenterX = (this.CenterY - viewport.Top) / viewport.Height;
			this.RadiusX /= viewport.Width;
			this.RadiusY /= viewport.Height;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00028FB0 File Offset: 0x000271B0
		public override void GetPointsOverride(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Windows.Point>> points, global::Infragistics.GetPointsSettings settings)
		{
			global::System.Collections.Generic.List<global::System.Windows.Point> list = new global::System.Collections.Generic.List<global::System.Windows.Point>();
			points.Add(list);
			list.Add(new global::System.Windows.Point(this.CenterX, this.CenterY));
		}
	}
}
