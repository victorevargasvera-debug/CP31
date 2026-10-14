using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Shapes;

namespace Infragistics
{
	// Token: 0x020000D8 RID: 216
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class PathVisualData : global::Infragistics.PrimitiveVisualData
	{
		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x0002883A File Offset: 0x00026A3A
		public override string Type
		{
			get
			{
				return "Path";
			}
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00028841 File Offset: 0x00026A41
		public PathVisualData() : base("path1")
		{
			this.Data = new global::System.Collections.Generic.List<global::Infragistics.GeometryData>();
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00028859 File Offset: 0x00026A59
		public PathVisualData(string name, global::System.Windows.Shapes.Path path) : base(name)
		{
			this.Data = global::Infragistics.AppearanceHelper.FromGeometry(path.Data);
			global::Infragistics.AppearanceHelper.GetShapeAppearance(base.Appearance, path);
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0002887F File Offset: 0x00026A7F
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x00028887 File Offset: 0x00026A87
		public global::System.Collections.Generic.List<global::Infragistics.GeometryData> Data { get; set; }

		// Token: 0x060008FE RID: 2302 RVA: 0x00028890 File Offset: 0x00026A90
		protected override string SerializeOverride()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine("data: [");
			for (int i = 0; i < this.Data.Count; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append((this.Data[i] != null) ? this.Data[i].Serialize() : "null");
			}
			stringBuilder.AppendLine("]");
			return stringBuilder.ToString();
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00028914 File Offset: 0x00026B14
		public override void ScaleByViewport(global::System.Windows.Rect viewport)
		{
			base.ScaleByViewport(viewport);
			foreach (global::Infragistics.GeometryData geometryData in this.Data)
			{
				geometryData.ScaleByViewport(viewport);
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00028970 File Offset: 0x00026B70
		public override void GetPointsOverride(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Windows.Point>> points, global::Infragistics.GetPointsSettings settings)
		{
			for (int i = 0; i < this.Data.Count; i++)
			{
				global::Infragistics.GeometryData geometryData = this.Data[i];
				geometryData.GetPointsOverride(points, settings);
			}
		}
	}
}
