using System;
using System.Drawing;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002FC RID: 764
	internal interface IImage : global::DevAge.Drawing.VisualElements.IVisualElement, global::System.ICloneable
	{
		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06002488 RID: 9352
		// (set) Token: 0x06002489 RID: 9353
		global::System.Drawing.Image Value { get; set; }
	}
}
