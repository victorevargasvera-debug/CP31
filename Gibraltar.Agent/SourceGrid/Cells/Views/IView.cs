using System;
using System.Drawing;
using DevAge.Drawing;

namespace SourceGrid.Cells.Views
{
	// Token: 0x02000342 RID: 834
	internal interface IView : global::System.ICloneable
	{
		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x0600284A RID: 10314
		// (set) Token: 0x0600284B RID: 10315
		global::System.Drawing.Font Font { get; set; }

		// Token: 0x0600284C RID: 10316
		global::System.Drawing.Font GetDrawingFont(global::SourceGrid.GridVirtual grid);

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x0600284D RID: 10317
		// (set) Token: 0x0600284E RID: 10318
		bool WordWrap { get; set; }

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x0600284F RID: 10319
		// (set) Token: 0x06002850 RID: 10320
		global::DevAge.Drawing.ContentAlignment TextAlignment { get; set; }

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06002851 RID: 10321
		// (set) Token: 0x06002852 RID: 10322
		global::DevAge.Drawing.IBorder Border { get; set; }

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06002853 RID: 10323
		// (set) Token: 0x06002854 RID: 10324
		global::System.Drawing.Color BackColor { get; set; }

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06002855 RID: 10325
		// (set) Token: 0x06002856 RID: 10326
		global::System.Drawing.Color ForeColor { get; set; }

		// Token: 0x06002857 RID: 10327
		void DrawCell(global::SourceGrid.CellContext cellContext, global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF rectangle);

		// Token: 0x06002858 RID: 10328
		global::System.Drawing.Size Measure(global::SourceGrid.CellContext cellContext, global::System.Drawing.Size maxLayoutArea);
	}
}
