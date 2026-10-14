using System;
using System.Drawing;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002D0 RID: 720
	internal interface IBackground : global::DevAge.Drawing.VisualElements.IVisualElement, global::System.ICloneable
	{
		// Token: 0x06002334 RID: 9012
		global::System.Drawing.RectangleF GetBackgroundContentRectangle(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF backGroundArea);

		// Token: 0x06002335 RID: 9013
		global::System.Drawing.SizeF GetBackgroundExtent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF contentSize);
	}
}
