using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002F5 RID: 757
	[global::System.Serializable]
	internal class RowHeaderThemed : global::DevAge.Drawing.VisualElements.RowHeaderBase
	{
		// Token: 0x0600244F RID: 9295 RVA: 0x0007E3E0 File Offset: 0x0007C5E0
		public RowHeaderThemed()
		{
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x0007E408 File Offset: 0x0007C608
		public RowHeaderThemed(global::DevAge.Drawing.VisualElements.RowHeaderThemed other) : base(other)
		{
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x0007E430 File Offset: 0x0007C630
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.RowHeaderThemed(this);
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06002452 RID: 9298 RVA: 0x0007E438 File Offset: 0x0007C638
		// (set) Token: 0x06002453 RID: 9299 RVA: 0x0007E440 File Offset: 0x0007C640
		public override global::DevAge.Drawing.ControlDrawStyle Style
		{
			get
			{
				return base.Style;
			}
			set
			{
				base.Style = value;
				this.mStandardRowHeader.Style = value;
				this.mColHeaderThemed.Style = value;
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06002454 RID: 9300 RVA: 0x0007E464 File Offset: 0x0007C664
		// (set) Token: 0x06002455 RID: 9301 RVA: 0x0007E46C File Offset: 0x0007C66C
		public virtual bool RotateColHeaderIfNotDefined
		{
			get
			{
				return this.mRotateColHeaderIfNotDefined;
			}
			set
			{
				this.mRotateColHeaderIfNotDefined = value;
			}
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x0007E478 File Offset: 0x0007C678
		protected global::System.Windows.Forms.VisualStyles.VisualStyleElement GetBackgroundElement()
		{
			if (this.Style == global::DevAge.Drawing.ControlDrawStyle.Hot)
			{
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Header.ItemLeft.Hot;
			}
			if (this.Style == global::DevAge.Drawing.ControlDrawStyle.Pressed)
			{
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Header.ItemLeft.Pressed;
			}
			return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Header.ItemLeft.Normal;
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x0007E4A4 File Offset: 0x0007C6A4
		protected global::System.Windows.Forms.VisualStyles.VisualStyleRenderer GetRenderer(global::System.Windows.Forms.VisualStyles.VisualStyleElement element)
		{
			return new global::System.Windows.Forms.VisualStyles.VisualStyleRenderer(element);
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x0007E4AC File Offset: 0x0007C6AC
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			base.OnDraw(graphics, area);
			if (global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetBackgroundElement()))
			{
				this.GetRenderer(this.GetBackgroundElement()).DrawBackground(graphics.Graphics, global::System.Drawing.Rectangle.Round(area));
				return;
			}
			if (this.RotateColHeaderIfNotDefined)
			{
				global::System.Drawing.Bitmap bitmap = new global::System.Drawing.Bitmap((int)area.Height, (int)area.Width);
				global::System.Drawing.Graphics graphics2 = global::System.Drawing.Graphics.FromImage(bitmap);
				try
				{
					global::System.Drawing.Rectangle r = new global::System.Drawing.Rectangle(0, 0, (int)area.Height, (int)area.Width);
					using (global::DevAge.Drawing.GraphicsCache graphicsCache = new global::DevAge.Drawing.GraphicsCache(graphics2))
					{
						this.mColHeaderThemed.Draw(graphicsCache, r);
					}
					bitmap.RotateFlip(global::System.Drawing.RotateFlipType.Rotate90FlipX);
					graphics.Graphics.DrawImage(bitmap, area);
					return;
				}
				finally
				{
					graphics2.Dispose();
					bitmap.Dispose();
				}
			}
			this.mStandardRowHeader.Draw(graphics, area);
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x0007E5B4 File Offset: 0x0007C7B4
		public override global::System.Drawing.RectangleF GetBackgroundContentRectangle(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF backGroundArea)
		{
			backGroundArea = base.GetBackgroundContentRectangle(measure, backGroundArea);
			if (global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetBackgroundElement()))
			{
				return this.GetRenderer(this.GetBackgroundElement()).GetBackgroundContentRectangle(measure.Graphics, global::System.Drawing.Rectangle.Round(backGroundArea));
			}
			return this.mStandardRowHeader.GetBackgroundContentRectangle(measure, backGroundArea);
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x0007E61C File Offset: 0x0007C81C
		public override global::System.Drawing.SizeF GetBackgroundExtent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF contentSize)
		{
			if (global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetBackgroundElement()))
			{
				global::System.Drawing.Rectangle contentBounds = new global::System.Drawing.Rectangle(new global::System.Drawing.Point(0, 0), global::System.Drawing.Size.Ceiling(contentSize));
				contentSize = this.GetRenderer(this.GetBackgroundElement()).GetBackgroundExtent(measure.Graphics, contentBounds).Size;
			}
			else
			{
				contentSize = this.mStandardRowHeader.GetBackgroundExtent(measure, contentSize);
			}
			return base.GetBackgroundExtent(measure, contentSize);
		}

		// Token: 0x04000CC6 RID: 3270
		private global::DevAge.Drawing.VisualElements.RowHeader mStandardRowHeader = new global::DevAge.Drawing.VisualElements.RowHeader();

		// Token: 0x04000CC7 RID: 3271
		private global::DevAge.Drawing.VisualElements.ColumnHeaderThemed mColHeaderThemed = new global::DevAge.Drawing.VisualElements.ColumnHeaderThemed();

		// Token: 0x04000CC8 RID: 3272
		private bool mRotateColHeaderIfNotDefined = true;
	}
}
