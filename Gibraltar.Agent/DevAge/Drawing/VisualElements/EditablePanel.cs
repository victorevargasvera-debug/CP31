using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002EC RID: 748
	[global::System.Serializable]
	internal class EditablePanel : global::DevAge.Drawing.VisualElements.EditablePanelBase
	{
		// Token: 0x06002410 RID: 9232 RVA: 0x0007DA68 File Offset: 0x0007BC68
		public EditablePanel()
		{
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x0007DA8C File Offset: 0x0007BC8C
		public EditablePanel(global::DevAge.Drawing.VisualElements.EditablePanel other) : base(other)
		{
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x0007DAB0 File Offset: 0x0007BCB0
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.EditablePanel(this);
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x0007DAB8 File Offset: 0x0007BCB8
		public override void Draw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			if (this.BorderStyle == global::DevAge.Drawing.BorderStyle.System)
			{
				global::System.Windows.Forms.ControlPaint.DrawBorder3D(graphics.Graphics, global::System.Drawing.Rectangle.Round(area), global::System.Windows.Forms.Border3DStyle.Flat, global::System.Windows.Forms.Border3DSide.All);
			}
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x0007DAE4 File Offset: 0x0007BCE4
		public override global::System.Drawing.RectangleF GetContentRectangle(global::System.Drawing.RectangleF backGroundArea)
		{
			if (this.BorderStyle == global::DevAge.Drawing.BorderStyle.System)
			{
				return this.mEquivalentPadding.GetContentRectangle(backGroundArea);
			}
			return backGroundArea;
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x0007DB00 File Offset: 0x0007BD00
		public override global::System.Drawing.SizeF GetExtent(global::System.Drawing.SizeF contentSize)
		{
			if (this.BorderStyle == global::DevAge.Drawing.BorderStyle.System)
			{
				return this.mEquivalentPadding.GetExtent(contentSize);
			}
			return contentSize;
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x0007DB1C File Offset: 0x0007BD1C
		public override global::DevAge.Drawing.RectanglePartType GetPointPartType(global::System.Drawing.RectangleF area, global::System.Drawing.PointF point, out float distanceFromBorder)
		{
			if (this.BorderStyle == global::DevAge.Drawing.BorderStyle.System)
			{
				return this.mEquivalentPadding.GetPointPartType(area, point, out distanceFromBorder);
			}
			distanceFromBorder = 0f;
			return global::DevAge.Drawing.RectanglePartType.ContentArea;
		}

		// Token: 0x04000CB8 RID: 3256
		private global::DevAge.Drawing.RectangleBorder mEquivalentPadding = new global::DevAge.Drawing.RectangleBorder(new global::DevAge.Drawing.BorderLine(global::System.Drawing.Color.Empty, 2f));
	}
}
