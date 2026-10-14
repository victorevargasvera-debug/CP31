using System;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002DA RID: 730
	[global::System.Serializable]
	internal abstract class HeaderBase : global::DevAge.Drawing.VisualElements.BackgroundBase, global::DevAge.Drawing.VisualElements.IHeader, global::DevAge.Drawing.VisualElements.IBackground, global::DevAge.Drawing.VisualElements.IVisualElement, global::System.ICloneable
	{
		// Token: 0x06002374 RID: 9076 RVA: 0x0007C2AC File Offset: 0x0007A4AC
		public HeaderBase()
		{
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x0007C2BC File Offset: 0x0007A4BC
		public HeaderBase(global::DevAge.Drawing.VisualElements.HeaderBase other) : base(other)
		{
			this.Style = other.Style;
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002376 RID: 9078 RVA: 0x0007C2D8 File Offset: 0x0007A4D8
		// (set) Token: 0x06002377 RID: 9079 RVA: 0x0007C2E0 File Offset: 0x0007A4E0
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

		// Token: 0x06002378 RID: 9080 RVA: 0x0007C2EC File Offset: 0x0007A4EC
		protected virtual bool ShouldSerializeStyle()
		{
			return this.Style != global::DevAge.Drawing.ControlDrawStyle.Normal;
		}

		// Token: 0x04000C9D RID: 3229
		private global::DevAge.Drawing.ControlDrawStyle mControlDrawStyle = global::DevAge.Drawing.ControlDrawStyle.Normal;
	}
}
