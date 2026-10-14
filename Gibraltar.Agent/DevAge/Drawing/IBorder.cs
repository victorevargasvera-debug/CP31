using System;
using System.Drawing;

namespace DevAge.Drawing
{
	// Token: 0x020002DB RID: 731
	internal interface IBorder : global::System.ICloneable
	{
		// Token: 0x06002379 RID: 9081
		global::System.Drawing.RectangleF GetContentRectangle(global::System.Drawing.RectangleF backGroundArea);

		// Token: 0x0600237A RID: 9082
		global::System.Drawing.SizeF GetExtent(global::System.Drawing.SizeF contentSize);

		// Token: 0x0600237B RID: 9083
		void Draw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area);

		// Token: 0x0600237C RID: 9084
		global::DevAge.Drawing.RectanglePartType GetPointPartType(global::System.Drawing.RectangleF area, global::System.Drawing.PointF point, out float distanceFromBorder);
	}
}
