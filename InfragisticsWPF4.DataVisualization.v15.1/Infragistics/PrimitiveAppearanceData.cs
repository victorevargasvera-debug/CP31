using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000D0 RID: 208
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class PrimitiveAppearanceData : global::Infragistics.IVisualData
	{
		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x00027BB9 File Offset: 0x00025DB9
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x00027BC1 File Offset: 0x00025DC1
		public global::System.Windows.Media.Color Stroke { get; set; }

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00027BCA File Offset: 0x00025DCA
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x00027BD2 File Offset: 0x00025DD2
		public global::Infragistics.BrushAppearanceData StrokeExtended { get; set; }

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00027BDB File Offset: 0x00025DDB
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00027BE3 File Offset: 0x00025DE3
		public global::System.Windows.Media.Color Fill { get; set; }

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00027BEC File Offset: 0x00025DEC
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00027BF4 File Offset: 0x00025DF4
		public global::Infragistics.BrushAppearanceData FillExtended { get; set; }

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00027BFD File Offset: 0x00025DFD
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x00027C05 File Offset: 0x00025E05
		public double StrokeThickness { get; set; }

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x00027C0E File Offset: 0x00025E0E
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x00027C16 File Offset: 0x00025E16
		public global::System.Windows.Visibility Visibility { get; set; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x00027C1F File Offset: 0x00025E1F
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x00027C27 File Offset: 0x00025E27
		public double Opacity { get; set; }

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x00027C30 File Offset: 0x00025E30
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x00027C38 File Offset: 0x00025E38
		public double CanvasLeft { get; set; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00027C41 File Offset: 0x00025E41
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x00027C49 File Offset: 0x00025E49
		public double CanvasTop { get; set; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00027C52 File Offset: 0x00025E52
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x00027C5A File Offset: 0x00025E5A
		public int CanvaZIndex { get; set; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00027C63 File Offset: 0x00025E63
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x00027C6B File Offset: 0x00025E6B
		public global::System.Collections.Generic.List<double> DashArray { get; set; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00027C74 File Offset: 0x00025E74
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00027C7C File Offset: 0x00025E7C
		public int DashCap { get; set; }

		// Token: 0x060008B8 RID: 2232 RVA: 0x00027C85 File Offset: 0x00025E85
		internal void ScaleByViewport(global::System.Windows.Rect viewport)
		{
			this.CanvasLeft = (this.CanvasLeft - viewport.Left) / viewport.Width;
			this.CanvasTop = (this.CanvasTop - viewport.Top) / viewport.Height;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00027CC0 File Offset: 0x00025EC0
		public string Serialize()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine("{");
			global::System.Text.StringBuilder stringBuilder2 = stringBuilder;
			string str = "stroke: ";
			global::System.Windows.Media.Color stroke = this.Stroke;
			stringBuilder2.AppendLine(str + global::Infragistics.AppearanceHelper.SerializeColor(this.Stroke) + ", ");
			global::System.Text.StringBuilder stringBuilder3 = stringBuilder;
			string str2 = "fill: ";
			global::System.Windows.Media.Color fill = this.Fill;
			stringBuilder3.AppendLine(str2 + global::Infragistics.AppearanceHelper.SerializeColor(this.Fill) + ", ");
			stringBuilder.AppendLine("strokeExtended: " + ((this.StrokeExtended != null) ? this.StrokeExtended.Serialize() : "null") + ", ");
			stringBuilder.AppendLine("fillExtended: " + ((this.FillExtended != null) ? this.FillExtended.Serialize() : "null") + ", ");
			stringBuilder.AppendLine("strokeThickness: " + this.StrokeThickness + ", ");
			stringBuilder.AppendLine("visibility: " + ((this.Visibility == global::System.Windows.Visibility.Visible) ? "true" : "false") + ", ");
			stringBuilder.AppendLine("opacity: " + this.Opacity + ", ");
			stringBuilder.AppendLine("canvasLeft: " + this.CanvasLeft + ", ");
			stringBuilder.AppendLine("canvasTop: " + this.CanvasTop + ", ");
			stringBuilder.AppendLine("canvasZIndex: " + this.CanvaZIndex + ", ");
			stringBuilder.AppendLine("dashArray: null, ");
			stringBuilder.AppendLine("dashCap: " + this.DashCap);
			stringBuilder.AppendLine("}");
			return stringBuilder.ToString();
		}
	}
}
