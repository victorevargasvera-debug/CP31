using System;
using System.Drawing;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002DD RID: 733
	[global::System.Serializable]
	internal abstract class EditablePanelBase : global::DevAge.Drawing.VisualElements.IEditablePanel, global::DevAge.Drawing.IBorder, global::System.ICloneable
	{
		// Token: 0x0600237F RID: 9087 RVA: 0x0007C2FC File Offset: 0x0007A4FC
		public EditablePanelBase()
		{
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x0007C30C File Offset: 0x0007A50C
		public EditablePanelBase(global::DevAge.Drawing.VisualElements.EditablePanelBase other)
		{
			this.BorderStyle = other.BorderStyle;
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06002381 RID: 9089 RVA: 0x0007C328 File Offset: 0x0007A528
		// (set) Token: 0x06002382 RID: 9090 RVA: 0x0007C330 File Offset: 0x0007A530
		public virtual global::DevAge.Drawing.BorderStyle BorderStyle
		{
			get
			{
				return this.mBorderStyle;
			}
			set
			{
				this.mBorderStyle = value;
			}
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x0007C33C File Offset: 0x0007A53C
		protected virtual bool ShouldSerializeBorderStyle()
		{
			return this.BorderStyle != global::DevAge.Drawing.BorderStyle.System;
		}

		// Token: 0x06002384 RID: 9092
		public abstract global::System.Drawing.RectangleF GetContentRectangle(global::System.Drawing.RectangleF backGroundArea);

		// Token: 0x06002385 RID: 9093
		public abstract global::System.Drawing.SizeF GetExtent(global::System.Drawing.SizeF contentSize);

		// Token: 0x06002386 RID: 9094
		public abstract void Draw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area);

		// Token: 0x06002387 RID: 9095
		public abstract global::DevAge.Drawing.RectanglePartType GetPointPartType(global::System.Drawing.RectangleF area, global::System.Drawing.PointF point, out float distanceFromBorder);

		// Token: 0x06002388 RID: 9096
		public abstract object Clone();

		// Token: 0x04000C9E RID: 3230
		private global::DevAge.Drawing.BorderStyle mBorderStyle = global::DevAge.Drawing.BorderStyle.System;
	}
}
