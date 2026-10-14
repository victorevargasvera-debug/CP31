using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace Infragistics
{
	// Token: 0x020000D2 RID: 210
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public abstract class PrimitiveVisualData : global::Infragistics.IVisualData
	{
		// Token: 0x060008BE RID: 2238 RVA: 0x00027EB9 File Offset: 0x000260B9
		protected PrimitiveVisualData()
		{
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00027EC1 File Offset: 0x000260C1
		protected PrimitiveVisualData(string name)
		{
			this.Name = name;
			this.Tags = new global::Infragistics.ShapeTags();
			this.Appearance = new global::Infragistics.PrimitiveAppearanceData();
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00027EE6 File Offset: 0x000260E6
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x00027EEE File Offset: 0x000260EE
		public global::Infragistics.PrimitiveAppearanceData Appearance { get; set; }

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00027EF7 File Offset: 0x000260F7
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00027EFF File Offset: 0x000260FF
		public global::Infragistics.ShapeTags Tags { get; set; }

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060008C4 RID: 2244
		public abstract string Type { get; }

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00027F08 File Offset: 0x00026108
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x00027F10 File Offset: 0x00026110
		public string Name { get; set; }

		// Token: 0x060008C7 RID: 2247 RVA: 0x00027F19 File Offset: 0x00026119
		public virtual void ScaleByViewport(global::System.Windows.Rect viewport)
		{
			this.Appearance.ScaleByViewport(viewport);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00027F28 File Offset: 0x00026128
		public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Windows.Point>> GetPoints(global::Infragistics.GetPointsSettings settings)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Windows.Point>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Windows.Point>>();
			this.GetPointsOverride(list, settings);
			return list;
		}

		// Token: 0x060008C9 RID: 2249
		public abstract void GetPointsOverride(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Windows.Point>> points, global::Infragistics.GetPointsSettings settings);

		// Token: 0x060008CA RID: 2250 RVA: 0x00027F44 File Offset: 0x00026144
		public string Serialize()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine("{");
			stringBuilder.AppendLine("appearance: " + ((this.Appearance != null) ? this.Appearance.Serialize() : "null") + ", ");
			stringBuilder.AppendLine("tags: [");
			for (int i = 0; i < this.Tags.Count; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("'" + this.Tags[i] + "'");
			}
			stringBuilder.AppendLine("],");
			stringBuilder.AppendLine("type: '" + this.Type + "', ");
			stringBuilder.AppendLine("name: '" + this.Name + "', ");
			stringBuilder.AppendLine(this.SerializeOverride());
			stringBuilder.AppendLine("}");
			return stringBuilder.ToString();
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00028049 File Offset: 0x00026249
		protected virtual string SerializeOverride()
		{
			return "";
		}
	}
}
