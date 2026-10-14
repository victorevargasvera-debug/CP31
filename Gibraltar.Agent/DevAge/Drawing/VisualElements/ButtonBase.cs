using System;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002D3 RID: 723
	[global::System.Serializable]
	internal abstract class ButtonBase : global::DevAge.Drawing.VisualElements.BackgroundBase, global::DevAge.Drawing.VisualElements.IButton, global::DevAge.Drawing.VisualElements.IBackground, global::DevAge.Drawing.VisualElements.IVisualElement, global::System.ICloneable
	{
		// Token: 0x0600233E RID: 9022 RVA: 0x0007B758 File Offset: 0x00079958
		public ButtonBase()
		{
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x0007B768 File Offset: 0x00079968
		public ButtonBase(global::DevAge.Drawing.VisualElements.ButtonBase other) : base(other)
		{
			this.Style = other.Style;
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x0007B784 File Offset: 0x00079984
		// (set) Token: 0x06002341 RID: 9025 RVA: 0x0007B78C File Offset: 0x0007998C
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

		// Token: 0x06002342 RID: 9026 RVA: 0x0007B798 File Offset: 0x00079998
		protected virtual bool ShouldSerializeStyle()
		{
			return this.Style != global::DevAge.Drawing.ButtonStyle.Normal;
		}

		// Token: 0x04000C91 RID: 3217
		private global::DevAge.Drawing.ButtonStyle mControlDrawStyle = global::DevAge.Drawing.ButtonStyle.Normal;
	}
}
