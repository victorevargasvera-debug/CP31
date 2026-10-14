using System;
using System.Drawing;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002E7 RID: 743
	internal interface IContainer : global::DevAge.Drawing.VisualElements.IVisualElement, global::System.ICloneable
	{
		// Token: 0x060023BF RID: 9151
		global::System.Drawing.RectangleF GetContentRectangle(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF backGroundArea);

		// Token: 0x060023C0 RID: 9152
		global::System.Drawing.SizeF GetExtent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF contentSize);
	}
}
