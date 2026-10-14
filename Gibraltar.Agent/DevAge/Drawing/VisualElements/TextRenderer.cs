using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x02000307 RID: 775
	[global::System.Serializable]
	internal class TextRenderer : global::DevAge.Drawing.VisualElements.Text
	{
		// Token: 0x060024F4 RID: 9460 RVA: 0x00081488 File Offset: 0x0007F688
		public TextRenderer()
		{
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x0008149C File Offset: 0x0007F69C
		public TextRenderer(string value)
		{
			this.Value = value;
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x000814B8 File Offset: 0x0007F6B8
		public TextRenderer(global::DevAge.Drawing.VisualElements.TextRenderer other) : base(other)
		{
			this.TextFormatFlags = other.TextFormatFlags;
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x000814D8 File Offset: 0x0007F6D8
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.TextRenderer(this);
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x000814E0 File Offset: 0x0007F6E0
		// (set) Token: 0x060024F9 RID: 9465 RVA: 0x000814E8 File Offset: 0x0007F6E8
		public virtual global::System.Windows.Forms.TextFormatFlags TextFormatFlags
		{
			get
			{
				return this.mTextFormatFlags;
			}
			set
			{
				this.mTextFormatFlags = value;
			}
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x000814F4 File Offset: 0x0007F6F4
		protected virtual bool ShouldSerializeTextFormatFlags()
		{
			return this.TextFormatFlags != global::System.Windows.Forms.TextFormatFlags.NoPrefix;
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x00081508 File Offset: 0x0007F708
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			if (this.Value == null || this.Value.Length == 0)
			{
				return;
			}
			if (base.Enabled)
			{
				global::System.Windows.Forms.TextRenderer.DrawText(graphics.Graphics, this.Value, this.Font, global::System.Drawing.Rectangle.Round(area), this.ForeColor, this.TextFormatFlags);
				return;
			}
			global::System.Windows.Forms.TextRenderer.DrawText(graphics.Graphics, this.Value, this.Font, global::System.Drawing.Rectangle.Round(area), global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.GrayText), this.TextFormatFlags);
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x00081594 File Offset: 0x0007F794
		protected override global::System.Drawing.SizeF OnMeasureContent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF maxSize)
		{
			global::System.Drawing.Size proposedSize;
			if (maxSize != global::System.Drawing.SizeF.Empty)
			{
				proposedSize = global::System.Drawing.Size.Ceiling(maxSize);
				if (proposedSize.Width == 0)
				{
					proposedSize.Width = int.MaxValue;
				}
				if (proposedSize.Height == 0)
				{
					proposedSize.Height = int.MaxValue;
				}
			}
			else
			{
				proposedSize = new global::System.Drawing.Size(int.MaxValue, int.MaxValue);
			}
			return global::System.Windows.Forms.TextRenderer.MeasureText(measure.Graphics, this.Value, this.Font, proposedSize, this.TextFormatFlags);
		}

		// Token: 0x04000CE8 RID: 3304
		private global::System.Windows.Forms.TextFormatFlags mTextFormatFlags = global::System.Windows.Forms.TextFormatFlags.NoPrefix;
	}
}
