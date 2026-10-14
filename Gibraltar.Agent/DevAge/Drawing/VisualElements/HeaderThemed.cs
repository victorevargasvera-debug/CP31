using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x02000327 RID: 807
	[global::System.Serializable]
	internal class HeaderThemed : global::DevAge.Drawing.VisualElements.HeaderBase
	{
		// Token: 0x06002618 RID: 9752 RVA: 0x00084168 File Offset: 0x00082368
		public HeaderThemed()
		{
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x0008417C File Offset: 0x0008237C
		public HeaderThemed(global::DevAge.Drawing.VisualElements.HeaderThemed other) : base(other)
		{
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x00084190 File Offset: 0x00082390
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.HeaderThemed(this);
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x0600261B RID: 9755 RVA: 0x00084198 File Offset: 0x00082398
		// (set) Token: 0x0600261C RID: 9756 RVA: 0x000841A0 File Offset: 0x000823A0
		public override global::DevAge.Drawing.ControlDrawStyle Style
		{
			get
			{
				return base.Style;
			}
			set
			{
				base.Style = value;
				this.mStandardHeader.Style = value;
			}
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x000841B8 File Offset: 0x000823B8
		protected global::System.Windows.Forms.VisualStyles.VisualStyleElement GetBackgroundElement()
		{
			if (this.Style == global::DevAge.Drawing.ControlDrawStyle.Hot)
			{
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Header.Item.Hot;
			}
			if (this.Style == global::DevAge.Drawing.ControlDrawStyle.Pressed)
			{
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Header.Item.Pressed;
			}
			return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Header.Item.Normal;
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x000841E4 File Offset: 0x000823E4
		protected global::System.Windows.Forms.VisualStyles.VisualStyleRenderer GetRenderer(global::System.Windows.Forms.VisualStyles.VisualStyleElement element)
		{
			return new global::System.Windows.Forms.VisualStyles.VisualStyleRenderer(element);
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x000841EC File Offset: 0x000823EC
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			base.OnDraw(graphics, area);
			if (global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetBackgroundElement()))
			{
				this.GetRenderer(this.GetBackgroundElement()).DrawBackground(graphics.Graphics, global::System.Drawing.Rectangle.Round(area));
				return;
			}
			this.mStandardHeader.Draw(graphics, area);
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x0008424C File Offset: 0x0008244C
		public override global::System.Drawing.RectangleF GetBackgroundContentRectangle(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF backGroundArea)
		{
			backGroundArea = base.GetBackgroundContentRectangle(measure, backGroundArea);
			if (global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetBackgroundElement()))
			{
				return this.GetRenderer(this.GetBackgroundElement()).GetBackgroundContentRectangle(measure.Graphics, global::System.Drawing.Rectangle.Round(backGroundArea));
			}
			return this.mStandardHeader.GetBackgroundContentRectangle(measure, backGroundArea);
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x000842B4 File Offset: 0x000824B4
		public override global::System.Drawing.SizeF GetBackgroundExtent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF contentSize)
		{
			if (global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetBackgroundElement()))
			{
				global::System.Drawing.Rectangle contentBounds = new global::System.Drawing.Rectangle(new global::System.Drawing.Point(0, 0), global::System.Drawing.Size.Ceiling(contentSize));
				contentSize = this.GetRenderer(this.GetBackgroundElement()).GetBackgroundExtent(measure.Graphics, contentBounds).Size;
			}
			else
			{
				contentSize = this.mStandardHeader.GetBackgroundExtent(measure, contentSize);
			}
			return base.GetBackgroundExtent(measure, contentSize);
		}

		// Token: 0x04000D6D RID: 3437
		private global::DevAge.Drawing.VisualElements.Header mStandardHeader = new global::DevAge.Drawing.VisualElements.Header();
	}
}
