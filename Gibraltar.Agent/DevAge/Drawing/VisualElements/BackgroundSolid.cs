using System;
using System.Drawing;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002EE RID: 750
	[global::System.Serializable]
	internal class BackgroundSolid : global::DevAge.Drawing.VisualElements.VisualElementBase
	{
		// Token: 0x0600241C RID: 9244 RVA: 0x0007DC40 File Offset: 0x0007BE40
		public BackgroundSolid()
		{
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x0007DC54 File Offset: 0x0007BE54
		public BackgroundSolid(global::System.Drawing.Color backcolor)
		{
			this.BackColor = backcolor;
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x0007DC70 File Offset: 0x0007BE70
		public BackgroundSolid(global::DevAge.Drawing.VisualElements.BackgroundSolid other) : base(other)
		{
			this.BackColor = other.BackColor;
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x0007DC90 File Offset: 0x0007BE90
		// (set) Token: 0x06002420 RID: 9248 RVA: 0x0007DC98 File Offset: 0x0007BE98
		public virtual global::System.Drawing.Color BackColor
		{
			get
			{
				return this.mBackColor;
			}
			set
			{
				this.mBackColor = value;
			}
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x0007DCA4 File Offset: 0x0007BEA4
		protected virtual bool ShouldSerializeBackColor()
		{
			return this.BackColor != global::System.Drawing.Color.Empty;
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x0007DCB8 File Offset: 0x0007BEB8
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			if (this.BackColor != global::System.Drawing.Color.Empty)
			{
				global::System.Drawing.SolidBrush brush = graphics.BrushsCache.GetBrush(this.BackColor);
				graphics.Graphics.FillRectangle(brush, area);
			}
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x0007DD00 File Offset: 0x0007BF00
		protected override global::System.Drawing.SizeF OnMeasureContent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF maxSize)
		{
			return global::System.Drawing.SizeF.Empty;
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x0007DD08 File Offset: 0x0007BF08
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.BackgroundSolid(this);
		}

		// Token: 0x04000CB9 RID: 3257
		private global::System.Drawing.Color mBackColor = global::System.Drawing.Color.Empty;
	}
}
