using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Infragistics
{
	// Token: 0x020000D9 RID: 217
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public abstract class GeometryData : global::Infragistics.IVisualData
	{
		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000901 RID: 2305
		public abstract string Type { get; }

		// Token: 0x06000902 RID: 2306
		public abstract void ScaleByViewport(global::System.Windows.Rect viewport);

		// Token: 0x06000903 RID: 2307
		public abstract void GetPointsOverride(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Windows.Point>> points, global::Infragistics.GetPointsSettings settings);

		// Token: 0x06000904 RID: 2308 RVA: 0x000289A8 File Offset: 0x00026BA8
		public string Serialize()
		{
			return string.Concat(new string[]
			{
				"{ type: '",
				this.Type,
				"', ",
				this.SerializeOverride(),
				"}"
			});
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000289EC File Offset: 0x00026BEC
		protected virtual string SerializeOverride()
		{
			return "";
		}
	}
}
