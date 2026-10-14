using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x02000326 RID: 806
	[global::System.Serializable]
	internal class SortIndicatorThemed : global::DevAge.Drawing.VisualElements.SortIndicator
	{
		// Token: 0x06002611 RID: 9745 RVA: 0x00084020 File Offset: 0x00082220
		public SortIndicatorThemed()
		{
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x00084028 File Offset: 0x00082228
		public SortIndicatorThemed(global::DevAge.Drawing.VisualElements.SortIndicatorThemed other) : base(other)
		{
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x00084034 File Offset: 0x00082234
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.SortIndicatorThemed(this);
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x0008403C File Offset: 0x0008223C
		protected global::System.Windows.Forms.VisualStyles.VisualStyleElement GetSortElement()
		{
			if (this.SortStyle == global::DevAge.Drawing.HeaderSortStyle.Ascending)
			{
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Header.SortArrow.SortedUp;
			}
			if (this.SortStyle == global::DevAge.Drawing.HeaderSortStyle.Descending)
			{
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Header.SortArrow.SortedDown;
			}
			return null;
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x00084064 File Offset: 0x00082264
		public global::System.Windows.Forms.VisualStyles.VisualStyleRenderer GetRenderer(global::System.Windows.Forms.VisualStyles.VisualStyleElement element)
		{
			return new global::System.Windows.Forms.VisualStyles.VisualStyleRenderer(element);
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x0008406C File Offset: 0x0008226C
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			if (this.SortStyle != global::DevAge.Drawing.HeaderSortStyle.None && global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetSortElement()))
			{
				global::System.Drawing.Rectangle bounds = global::System.Drawing.Rectangle.Round(area);
				global::System.Windows.Forms.VisualStyles.VisualStyleRenderer renderer = this.GetRenderer(this.GetSortElement());
				global::System.Drawing.Size partSize = renderer.GetPartSize(graphics.Graphics, bounds, global::System.Windows.Forms.VisualStyles.ThemeSizeType.Draw);
				bounds = new global::System.Drawing.Rectangle(bounds.Right - partSize.Width, bounds.Top, partSize.Width, partSize.Height);
				renderer.DrawBackground(graphics.Graphics, bounds);
				return;
			}
			base.OnDraw(graphics, area);
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x00084108 File Offset: 0x00082308
		protected override global::System.Drawing.SizeF OnMeasureContent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF maxSize)
		{
			if (this.SortStyle != global::DevAge.Drawing.HeaderSortStyle.None && global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetSortElement()))
			{
				global::System.Windows.Forms.VisualStyles.VisualStyleRenderer renderer = this.GetRenderer(this.GetSortElement());
				return renderer.GetPartSize(measure.Graphics, global::System.Windows.Forms.VisualStyles.ThemeSizeType.Draw);
			}
			return base.OnMeasureContent(measure, maxSize);
		}
	}
}
