using System;
using System.Drawing;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x0200031A RID: 794
	[global::System.Serializable]
	internal class RowHeader : global::DevAge.Drawing.VisualElements.RowHeaderBase
	{
		// Token: 0x06002584 RID: 9604 RVA: 0x00082DD8 File Offset: 0x00080FD8
		public RowHeader()
		{
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x00082DF0 File Offset: 0x00080FF0
		public RowHeader(global::DevAge.Drawing.VisualElements.RowHeader other) : base(other)
		{
			this.mBackground = (global::DevAge.Drawing.VisualElements.Header)other.mBackground.Clone();
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x00082E20 File Offset: 0x00081020
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.RowHeader(this);
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x00082E28 File Offset: 0x00081028
		// (set) Token: 0x06002588 RID: 9608 RVA: 0x00082E30 File Offset: 0x00081030
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

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06002589 RID: 9609 RVA: 0x00082E48 File Offset: 0x00081048
		// (set) Token: 0x0600258A RID: 9610 RVA: 0x00082E58 File Offset: 0x00081058
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

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x00082E68 File Offset: 0x00081068
		// (set) Token: 0x0600258C RID: 9612 RVA: 0x00082E78 File Offset: 0x00081078
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

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x00082E88 File Offset: 0x00081088
		// (set) Token: 0x0600258E RID: 9614 RVA: 0x00082E98 File Offset: 0x00081098
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

		// Token: 0x0600258F RID: 9615 RVA: 0x00082EA8 File Offset: 0x000810A8
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			base.OnDraw(graphics, area);
			this.mBackground.Draw(graphics, area);
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x00082EC0 File Offset: 0x000810C0
		public override global::System.Drawing.RectangleF GetBackgroundContentRectangle(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF backGroundArea)
		{
			backGroundArea = base.GetBackgroundContentRectangle(measure, backGroundArea);
			return this.mBackground.GetBackgroundContentRectangle(measure, backGroundArea);
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x00082EDC File Offset: 0x000810DC
		public override global::System.Drawing.SizeF GetBackgroundExtent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF contentSize)
		{
			contentSize = this.mBackground.GetBackgroundExtent(measure, contentSize);
			return base.GetBackgroundExtent(measure, contentSize);
		}

		// Token: 0x04000D40 RID: 3392
		private global::DevAge.Drawing.VisualElements.Header mBackground = new global::DevAge.Drawing.VisualElements.Header(0f);
	}
}
