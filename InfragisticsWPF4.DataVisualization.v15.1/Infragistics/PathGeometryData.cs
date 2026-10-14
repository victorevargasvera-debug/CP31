using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace Infragistics
{
	// Token: 0x020000DA RID: 218
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class PathGeometryData : global::Infragistics.GeometryData
	{
		// Token: 0x06000907 RID: 2311 RVA: 0x000289FB File Offset: 0x00026BFB
		public PathGeometryData()
		{
			this.Figures = new global::System.Collections.Generic.List<global::Infragistics.PathFigureData>();
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x00028A0E File Offset: 0x00026C0E
		public override string Type
		{
			get
			{
				return "Path";
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00028A15 File Offset: 0x00026C15
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x00028A1D File Offset: 0x00026C1D
		public global::System.Collections.Generic.List<global::Infragistics.PathFigureData> Figures { get; set; }

		// Token: 0x0600090B RID: 2315 RVA: 0x00028A28 File Offset: 0x00026C28
		protected override string SerializeOverride()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine("figures: [");
			for (int i = 0; i < this.Figures.Count; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(this.Figures[i].Serialize());
			}
			stringBuilder.AppendLine("]");
			return stringBuilder.ToString();
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00028A98 File Offset: 0x00026C98
		public override void ScaleByViewport(global::System.Windows.Rect viewport)
		{
			foreach (global::Infragistics.PathFigureData pathFigureData in this.Figures)
			{
				pathFigureData.ScaleByViewport(viewport);
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00028AEC File Offset: 0x00026CEC
		public override void GetPointsOverride(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Windows.Point>> points, global::Infragistics.GetPointsSettings settings)
		{
			for (int i = 0; i < this.Figures.Count; i++)
			{
				global::Infragistics.PathFigureData pathFigureData = this.Figures[i];
				pathFigureData.GetPointsOverride(points, settings);
			}
		}
	}
}
