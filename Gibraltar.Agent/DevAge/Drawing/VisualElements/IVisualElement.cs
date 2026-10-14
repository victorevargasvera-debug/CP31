using System;
using System.Drawing;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002CC RID: 716
	internal interface IVisualElement : global::System.ICloneable
	{
		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002314 RID: 8980
		// (set) Token: 0x06002315 RID: 8981
		global::DevAge.Drawing.AnchorArea AnchorArea { get; set; }

		// Token: 0x06002316 RID: 8982
		global::System.Drawing.RectangleF GetDrawingArea(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF area);

		// Token: 0x06002317 RID: 8983
		global::System.Drawing.SizeF Measure(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF minSize, global::System.Drawing.SizeF maxSize);

		// Token: 0x06002318 RID: 8984
		void Draw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area);

		// Token: 0x06002319 RID: 8985
		void Draw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area, out global::System.Drawing.RectangleF drawingArea);

		// Token: 0x0600231A RID: 8986
		global::DevAge.Drawing.VisualElements.VisualElementList GetElementsAtPoint(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF area, global::System.Drawing.PointF point);
	}
}
