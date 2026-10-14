using System;
using System.Drawing;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002D7 RID: 727
	internal interface IText : global::DevAge.Drawing.VisualElements.IVisualElement, global::System.ICloneable
	{
		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x0600235C RID: 9052
		// (set) Token: 0x0600235D RID: 9053
		string Value { get; set; }

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x0600235E RID: 9054
		// (set) Token: 0x0600235F RID: 9055
		global::System.Drawing.Color ForeColor { get; set; }

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06002360 RID: 9056
		// (set) Token: 0x06002361 RID: 9057
		global::System.Drawing.Font Font { get; set; }
	}
}
