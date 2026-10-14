using System;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002E2 RID: 738
	[global::System.Serializable]
	internal abstract class DropDownButtonBase : global::DevAge.Drawing.VisualElements.VisualElementBase, global::DevAge.Drawing.VisualElements.IDropDownButton, global::DevAge.Drawing.VisualElements.IVisualElement, global::System.ICloneable
	{
		// Token: 0x0600239D RID: 9117 RVA: 0x0007C5D8 File Offset: 0x0007A7D8
		public DropDownButtonBase()
		{
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x0007C5E8 File Offset: 0x0007A7E8
		public DropDownButtonBase(global::DevAge.Drawing.VisualElements.DropDownButtonBase other) : base(other)
		{
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x0600239F RID: 9119 RVA: 0x0007C5F8 File Offset: 0x0007A7F8
		// (set) Token: 0x060023A0 RID: 9120 RVA: 0x0007C600 File Offset: 0x0007A800
		public virtual global::DevAge.Drawing.ButtonStyle Style
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

		// Token: 0x060023A1 RID: 9121 RVA: 0x0007C60C File Offset: 0x0007A80C
		protected virtual bool ShouldSerializeStyle()
		{
			return this.Style != global::DevAge.Drawing.ButtonStyle.Normal;
		}

		// Token: 0x04000CA7 RID: 3239
		private global::DevAge.Drawing.ButtonStyle mControlDrawStyle = global::DevAge.Drawing.ButtonStyle.Normal;
	}
}
