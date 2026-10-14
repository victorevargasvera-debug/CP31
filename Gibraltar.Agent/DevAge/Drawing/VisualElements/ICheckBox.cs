using System;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002CD RID: 717
	internal interface ICheckBox : global::DevAge.Drawing.VisualElements.IVisualElement, global::System.ICloneable
	{
		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x0600231B RID: 8987
		// (set) Token: 0x0600231C RID: 8988
		global::DevAge.Drawing.ControlDrawStyle Style { get; set; }

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x0600231D RID: 8989
		// (set) Token: 0x0600231E RID: 8990
		global::DevAge.Drawing.CheckBoxState CheckBoxState { get; set; }
	}
}
