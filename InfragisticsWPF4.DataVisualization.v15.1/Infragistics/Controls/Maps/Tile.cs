using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Maps
{
	// Token: 0x020000EB RID: 235
	internal class Tile
	{
		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0002B194 File Offset: 0x00029394
		public global::System.Windows.Rect Rect
		{
			get
			{
				double num = global::System.Math.Pow(2.0, (double)(-(double)this.Z));
				double num2 = global::System.Math.Pow(2.0, (double)(-(double)this.Z));
				return new global::System.Windows.Rect((double)this.X * num, (double)this.Y * num2, num, num2);
			}
		}

		// Token: 0x0400037B RID: 891
		public int X;

		// Token: 0x0400037C RID: 892
		public int Y;

		// Token: 0x0400037D RID: 893
		public int Z;

		// Token: 0x0400037E RID: 894
		public global::System.Windows.Controls.Image Image;

		// Token: 0x0400037F RID: 895
		public global::System.Windows.Controls.Image GhostImage;

		// Token: 0x04000380 RID: 896
		public global::System.DateTime FadeStart;
	}
}
