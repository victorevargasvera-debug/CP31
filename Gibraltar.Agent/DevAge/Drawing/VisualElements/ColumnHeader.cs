using System;
using System.Drawing;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002FE RID: 766
	[global::System.Serializable]
	internal class ColumnHeader : global::DevAge.Drawing.VisualElements.ColumnHeaderBase
	{
		// Token: 0x06002494 RID: 9364 RVA: 0x0007F78C File Offset: 0x0007D98C
		public ColumnHeader()
		{
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x0007F7A4 File Offset: 0x0007D9A4
		public ColumnHeader(global::DevAge.Drawing.VisualElements.ColumnHeader other) : base(other)
		{
			this.mBackground = (global::DevAge.Drawing.VisualElements.Header)other.mBackground.Clone();
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x0007F7D4 File Offset: 0x0007D9D4
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.ColumnHeader(this);
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x0007F7DC File Offset: 0x0007D9DC
		// (set) Token: 0x06002498 RID: 9368 RVA: 0x0007F7E4 File Offset: 0x0007D9E4
		public override global::DevAge.Drawing.ControlDrawStyle Style
		{
			get
			{
				return base.Style;
			}
			set
			{
				base.Style = value;
				this.mBackground.Style = value;
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x0007F7FC File Offset: 0x0007D9FC
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x0007F80C File Offset: 0x0007DA0C
		public global::System.Drawing.Color BackColor
		{
			get
			{
				return this.mBackground.BackColor;
			}
			set
			{
				this.mBackground.BackColor = value;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x0007F81C File Offset: 0x0007DA1C
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x0007F82C File Offset: 0x0007DA2C
		public global::DevAge.Drawing.BackgroundColorStyle BackgroundColorStyle
		{
			get
			{
				return this.mBackground.BackgroundColorStyle;
			}
			set
			{
				this.mBackground.BackgroundColorStyle = value;
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x0007F83C File Offset: 0x0007DA3C
		// (set) Token: 0x0600249E RID: 9374 RVA: 0x0007F84C File Offset: 0x0007DA4C
		public global::DevAge.Drawing.RectangleBorder Border
		{
			get
			{
				return this.mBackground.Border;
			}
			set
			{
				this.mBackground.Border = value;
			}
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x0007F85C File Offset: 0x0007DA5C
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			base.OnDraw(graphics, area);
			this.mBackground.Draw(graphics, area);
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x0007F874 File Offset: 0x0007DA74
		public override global::System.Drawing.RectangleF GetBackgroundContentRectangle(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF backGroundArea)
		{
			backGroundArea = base.GetBackgroundContentRectangle(measure, backGroundArea);
			return this.mBackground.GetBackgroundContentRectangle(measure, backGroundArea);
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x0007F890 File Offset: 0x0007DA90
		public override global::System.Drawing.SizeF GetBackgroundExtent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF contentSize)
		{
			contentSize = this.mBackground.GetBackgroundExtent(measure, contentSize);
			return base.GetBackgroundExtent(measure, contentSize);
		}

		// Token: 0x04000CDB RID: 3291
		private global::DevAge.Drawing.VisualElements.Header mBackground = new global::DevAge.Drawing.VisualElements.Header(90f);
	}
}
