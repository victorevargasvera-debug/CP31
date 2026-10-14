using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002F8 RID: 760
	[global::System.Serializable]
	internal class ColumnHeaderThemed : global::DevAge.Drawing.VisualElements.ColumnHeaderBase
	{
		// Token: 0x0600245D RID: 9309 RVA: 0x0007E6B4 File Offset: 0x0007C8B4
		public ColumnHeaderThemed()
		{
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x0007E6C8 File Offset: 0x0007C8C8
		public ColumnHeaderThemed(global::DevAge.Drawing.VisualElements.ColumnHeaderThemed other) : base(other)
		{
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x0007E6DC File Offset: 0x0007C8DC
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.ColumnHeaderThemed(this);
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x0007E6E4 File Offset: 0x0007C8E4
		// (set) Token: 0x06002461 RID: 9313 RVA: 0x0007E6EC File Offset: 0x0007C8EC
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

		// Token: 0x06002462 RID: 9314 RVA: 0x0007E704 File Offset: 0x0007C904
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

		// Token: 0x06002463 RID: 9315 RVA: 0x0007E730 File Offset: 0x0007C930
		protected global::System.Windows.Forms.VisualStyles.VisualStyleRenderer GetRenderer(global::System.Windows.Forms.VisualStyles.VisualStyleElement element)
		{
			return new global::System.Windows.Forms.VisualStyles.VisualStyleRenderer(element);
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x0007E738 File Offset: 0x0007C938
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

		// Token: 0x06002465 RID: 9317 RVA: 0x0007E798 File Offset: 0x0007C998
		public override global::System.Drawing.RectangleF GetBackgroundContentRectangle(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF backGroundArea)
		{
			backGroundArea = base.GetBackgroundContentRectangle(measure, backGroundArea);
			if (global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetBackgroundElement()))
			{
				return this.GetRenderer(this.GetBackgroundElement()).GetBackgroundContentRectangle(measure.Graphics, global::System.Drawing.Rectangle.Round(backGroundArea));
			}
			return this.mStandardHeader.GetBackgroundContentRectangle(measure, backGroundArea);
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0007E800 File Offset: 0x0007CA00
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

		// Token: 0x04000CC9 RID: 3273
		private global::DevAge.Drawing.VisualElements.ColumnHeader mStandardHeader = new global::DevAge.Drawing.VisualElements.ColumnHeader();
	}
}
