using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace Infragistics
{
	// Token: 0x020000DF RID: 223
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public abstract class SegmentData : global::Infragistics.IVisualData
	{
		// Token: 0x1700023F RID: 575
		// (get) Token: 0x0600093E RID: 2366
		public abstract string Type { get; }

		// Token: 0x0600093F RID: 2367
		public abstract void ScaleByViewport(global::System.Windows.Rect viewport);

		// Token: 0x06000940 RID: 2368
		public abstract void GetPointsOverride(global::System.Collections.Generic.List<global::System.Windows.Point> current, global::Infragistics.GetPointsSettings settings);

		// Token: 0x06000941 RID: 2369 RVA: 0x000292C4 File Offset: 0x000274C4
		public string Serialize()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine("{");
			stringBuilder.AppendLine("type: '" + this.Type + "', ");
			stringBuilder.AppendLine(this.SerializeOverride());
			stringBuilder.AppendLine("}");
			return stringBuilder.ToString();
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0002931E File Offset: 0x0002751E
		protected virtual string SerializeOverride()
		{
			return "";
		}
	}
}
