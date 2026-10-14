using System;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002CF RID: 719
	[global::System.Serializable]
	internal abstract class CheckBoxBase : global::DevAge.Drawing.VisualElements.VisualElementBase, global::DevAge.Drawing.VisualElements.ICheckBox, global::DevAge.Drawing.VisualElements.IVisualElement, global::System.ICloneable
	{
		// Token: 0x0600232C RID: 9004 RVA: 0x0007B658 File Offset: 0x00079858
		public CheckBoxBase()
		{
			this.AnchorArea = new global::DevAge.Drawing.AnchorArea(float.NaN, float.NaN, float.NaN, float.NaN, true, true);
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x0007B698 File Offset: 0x00079898
		public CheckBoxBase(global::DevAge.Drawing.VisualElements.CheckBoxBase other) : base(other)
		{
			this.Style = other.Style;
			this.CheckBoxState = other.CheckBoxState;
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x0007B6D0 File Offset: 0x000798D0
		// (set) Token: 0x0600232F RID: 9007 RVA: 0x0007B6D8 File Offset: 0x000798D8
		public virtual global::DevAge.Drawing.ControlDrawStyle Style
		{
			get
			{
				return this.mControlDrawStyle;
			}
			set
			{
				this.mControlDrawStyle = value;
			}
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x0007B6E4 File Offset: 0x000798E4
		protected virtual bool ShouldSerializeStyle()
		{
			return this.Style != global::DevAge.Drawing.ControlDrawStyle.Normal;
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x0007B6F4 File Offset: 0x000798F4
		// (set) Token: 0x06002332 RID: 9010 RVA: 0x0007B6FC File Offset: 0x000798FC
		public virtual global::DevAge.Drawing.CheckBoxState CheckBoxState
		{
			get
			{
				return this.mCheckBoxState;
			}
			set
			{
				this.mCheckBoxState = value;
			}
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x0007B708 File Offset: 0x00079908
		protected virtual bool ShouldSerializeCheckBoxState()
		{
			return this.CheckBoxState != global::DevAge.Drawing.CheckBoxState.Undefined;
		}

		// Token: 0x04000C8F RID: 3215
		private global::DevAge.Drawing.ControlDrawStyle mControlDrawStyle = global::DevAge.Drawing.ControlDrawStyle.Normal;

		// Token: 0x04000C90 RID: 3216
		private global::DevAge.Drawing.CheckBoxState mCheckBoxState;
	}
}
