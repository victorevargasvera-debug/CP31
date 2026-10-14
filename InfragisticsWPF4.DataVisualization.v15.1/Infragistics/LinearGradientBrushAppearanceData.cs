using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Infragistics
{
	// Token: 0x020000CE RID: 206
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class LinearGradientBrushAppearanceData : global::Infragistics.BrushAppearanceData
	{
		// Token: 0x0600088D RID: 2189 RVA: 0x000279ED File Offset: 0x00025BED
		public LinearGradientBrushAppearanceData()
		{
			this.Stops = new global::System.Collections.Generic.List<global::Infragistics.GradientStopAppearanceData>();
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x00027A00 File Offset: 0x00025C00
		public override string Type
		{
			get
			{
				return "linear";
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00027A07 File Offset: 0x00025C07
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00027A0F File Offset: 0x00025C0F
		public double StartX { get; set; }

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00027A18 File Offset: 0x00025C18
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x00027A20 File Offset: 0x00025C20
		public double StartY { get; set; }

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x00027A29 File Offset: 0x00025C29
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x00027A31 File Offset: 0x00025C31
		public double EndX { get; set; }

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00027A3A File Offset: 0x00025C3A
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x00027A42 File Offset: 0x00025C42
		public double EndY { get; set; }

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x00027A4B File Offset: 0x00025C4B
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x00027A53 File Offset: 0x00025C53
		public global::System.Collections.Generic.List<global::Infragistics.GradientStopAppearanceData> Stops { get; set; }

		// Token: 0x06000899 RID: 2201 RVA: 0x00027A5C File Offset: 0x00025C5C
		protected override string SerializeOverride()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(string.Concat(new object[]
			{
				"startX: ",
				this.StartX,
				", endX: ",
				this.EndX,
				", startY: ",
				this.StartY,
				", endY: ",
				this.EndY
			}));
			stringBuilder.Append(", stops: [");
			for (int i = 0; i < this.Stops.Count; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(this.Stops[i].Serialize());
			}
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}
	}
}
