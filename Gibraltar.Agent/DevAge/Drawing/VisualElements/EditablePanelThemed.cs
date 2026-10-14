using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002DE RID: 734
	[global::System.Serializable]
	internal class EditablePanelThemed : global::DevAge.Drawing.VisualElements.EditablePanelBase
	{
		// Token: 0x06002389 RID: 9097 RVA: 0x0007C34C File Offset: 0x0007A54C
		public EditablePanelThemed()
		{
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x0007C37C File Offset: 0x0007A57C
		public EditablePanelThemed(global::DevAge.Drawing.VisualElements.EditablePanelThemed other) : base(other)
		{
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x0007C3AC File Offset: 0x0007A5AC
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.EditablePanelThemed(this);
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x0007C3B4 File Offset: 0x0007A5B4
		protected global::System.Windows.Forms.VisualStyles.VisualStyleElement GetBackgroundElement()
		{
			return global::System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox.TextEdit.Normal;
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x0007C3BC File Offset: 0x0007A5BC
		protected global::System.Windows.Forms.VisualStyles.VisualStyleRenderer GetRenderer(global::System.Windows.Forms.VisualStyles.VisualStyleElement element)
		{
			return new global::System.Windows.Forms.VisualStyles.VisualStyleRenderer(element);
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x0600238E RID: 9102 RVA: 0x0007C3C4 File Offset: 0x0007A5C4
		// (set) Token: 0x0600238F RID: 9103 RVA: 0x0007C3CC File Offset: 0x0007A5CC
		public override global::DevAge.Drawing.BorderStyle BorderStyle
		{
			get
			{
				return base.BorderStyle;
			}
			set
			{
				base.BorderStyle = value;
				this.mStandard.BorderStyle = value;
			}
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x0007C3E4 File Offset: 0x0007A5E4
		public override void Draw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			if (global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetBackgroundElement()))
			{
				if (this.BorderStyle == global::DevAge.Drawing.BorderStyle.System)
				{
					this.GetRenderer(this.GetBackgroundElement()).DrawBackground(graphics.Graphics, global::System.Drawing.Rectangle.Round(area));
					return;
				}
			}
			else
			{
				this.mStandard.Draw(graphics, area);
			}
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x0007C448 File Offset: 0x0007A648
		public override global::System.Drawing.RectangleF GetContentRectangle(global::System.Drawing.RectangleF backGroundArea)
		{
			if (this.BorderStyle == global::DevAge.Drawing.BorderStyle.System)
			{
				return this.mEquivalentPadding.GetContentRectangle(backGroundArea);
			}
			return backGroundArea;
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x0007C464 File Offset: 0x0007A664
		public override global::System.Drawing.SizeF GetExtent(global::System.Drawing.SizeF contentSize)
		{
			if (this.BorderStyle == global::DevAge.Drawing.BorderStyle.System)
			{
				return this.mEquivalentPadding.GetExtent(contentSize);
			}
			return contentSize;
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x0007C480 File Offset: 0x0007A680
		public override global::DevAge.Drawing.RectanglePartType GetPointPartType(global::System.Drawing.RectangleF area, global::System.Drawing.PointF point, out float distanceFromBorder)
		{
			if (this.BorderStyle == global::DevAge.Drawing.BorderStyle.System)
			{
				return this.mEquivalentPadding.GetPointPartType(area, point, out distanceFromBorder);
			}
			distanceFromBorder = 0f;
			return global::DevAge.Drawing.RectanglePartType.ContentArea;
		}

		// Token: 0x04000C9F RID: 3231
		private global::DevAge.Drawing.VisualElements.EditablePanel mStandard = new global::DevAge.Drawing.VisualElements.EditablePanel();

		// Token: 0x04000CA0 RID: 3232
		private global::DevAge.Drawing.RectangleBorder mEquivalentPadding = new global::DevAge.Drawing.RectangleBorder(new global::DevAge.Drawing.BorderLine(global::System.Drawing.Color.Empty, 2f));
	}
}
