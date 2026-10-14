using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevAge.Drawing;
using DevAge.Drawing.VisualElements;
using DevAge.Windows.Forms;
using SourceGrid.Cells.Models;

namespace SourceGrid.Cells.Views
{
	// Token: 0x02000344 RID: 836
	[global::System.Serializable]
	internal class Cell : global::SourceGrid.Cells.Views.ViewBase
	{
		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06002883 RID: 10371 RVA: 0x0008C670 File Offset: 0x0008A870
		public static global::SourceGrid.Cells.Views.Cell Default
		{
			get
			{
				if (global::SourceGrid.Cells.Views.Cell.t_DefaultCell == null)
				{
					global::SourceGrid.Cells.Views.Cell.t_DefaultCell = new global::SourceGrid.Cells.Views.Cell();
				}
				return global::SourceGrid.Cells.Views.Cell.t_DefaultCell;
			}
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x0008C68C File Offset: 0x0008A88C
		public Cell()
		{
			base.ElementsDrawMode = global::DevAge.Drawing.ElementsDrawMode.Align;
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x0008C6B4 File Offset: 0x0008A8B4
		public Cell(global::SourceGrid.Cells.Views.Cell p_Source) : base(p_Source)
		{
			this.ElementImage = (global::DevAge.Drawing.VisualElements.IImage)p_Source.ElementImage.Clone();
			this.ElementText = (global::DevAge.Drawing.VisualElements.IText)p_Source.ElementText.Clone();
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x0008C710 File Offset: 0x0008A910
		public override object Clone()
		{
			return new global::SourceGrid.Cells.Views.Cell(this);
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x0008C718 File Offset: 0x0008A918
		protected override global::System.Collections.Generic.IEnumerable<global::DevAge.Drawing.VisualElements.IVisualElement> GetElements()
		{
			if (this.ElementImage != null)
			{
				yield return this.ElementImage;
			}
			if (this.ElementText != null)
			{
				yield return this.ElementText;
			}
			yield break;
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x0008C73C File Offset: 0x0008A93C
		protected override void PrepareView(global::SourceGrid.CellContext context)
		{
			base.PrepareView(context);
			this.PrepareVisualElementText(context);
			this.PrepareVisualElementImage(context);
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06002889 RID: 10377 RVA: 0x0008C754 File Offset: 0x0008A954
		// (set) Token: 0x0600288A RID: 10378 RVA: 0x0008C75C File Offset: 0x0008A95C
		public global::DevAge.Drawing.VisualElements.IText ElementText
		{
			get
			{
				return this.mElementText;
			}
			set
			{
				this.mElementText = value;
			}
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x0008C768 File Offset: 0x0008A968
		protected virtual void PrepareVisualElementText(global::SourceGrid.CellContext context)
		{
			if (this.ElementText is global::DevAge.Drawing.VisualElements.TextRenderer)
			{
				global::DevAge.Drawing.VisualElements.TextRenderer textRenderer = (global::DevAge.Drawing.VisualElements.TextRenderer)this.ElementText;
				textRenderer.TextFormatFlags = global::System.Windows.Forms.TextFormatFlags.NoPrefix;
				if (base.WordWrap)
				{
					textRenderer.TextFormatFlags |= global::System.Windows.Forms.TextFormatFlags.WordBreak;
				}
				if (base.TrimmingMode == global::SourceGrid.TrimmingMode.Char)
				{
					textRenderer.TextFormatFlags |= global::System.Windows.Forms.TextFormatFlags.EndEllipsis;
				}
				else if (base.TrimmingMode == global::SourceGrid.TrimmingMode.Word)
				{
					textRenderer.TextFormatFlags |= global::System.Windows.Forms.TextFormatFlags.WordEllipsis;
				}
				textRenderer.TextFormatFlags |= global::DevAge.Windows.Forms.Utilities.ContentAligmentToTextFormatFlags(base.TextAlignment);
			}
			else if (this.ElementText is global::DevAge.Drawing.VisualElements.TextGDI)
			{
				global::DevAge.Drawing.VisualElements.TextGDI textGDI = (global::DevAge.Drawing.VisualElements.TextGDI)this.ElementText;
				if (base.WordWrap)
				{
					textGDI.StringFormat.FormatFlags = (global::System.Drawing.StringFormatFlags)0;
				}
				else
				{
					textGDI.StringFormat.FormatFlags = global::System.Drawing.StringFormatFlags.NoWrap;
				}
				if (base.TrimmingMode == global::SourceGrid.TrimmingMode.Char)
				{
					textGDI.StringFormat.Trimming = global::System.Drawing.StringTrimming.EllipsisCharacter;
				}
				else if (base.TrimmingMode == global::SourceGrid.TrimmingMode.Word)
				{
					textGDI.StringFormat.Trimming = global::System.Drawing.StringTrimming.EllipsisWord;
				}
				else
				{
					textGDI.StringFormat.Trimming = global::System.Drawing.StringTrimming.None;
				}
				textGDI.Alignment = base.TextAlignment;
			}
			this.ElementText.Font = this.GetDrawingFont(context.Grid);
			this.ElementText.ForeColor = base.ForeColor;
			this.ElementText.Value = context.DisplayText;
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
		// (set) Token: 0x0600288D RID: 10381 RVA: 0x0008C8F8 File Offset: 0x0008AAF8
		public global::DevAge.Drawing.VisualElements.IImage ElementImage
		{
			get
			{
				return this.mElementImage;
			}
			set
			{
				this.mElementImage = value;
			}
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x0008C904 File Offset: 0x0008AB04
		protected virtual void PrepareVisualElementImage(global::SourceGrid.CellContext context)
		{
			this.ElementImage.AnchorArea = new global::DevAge.Drawing.AnchorArea(base.ImageAlignment, base.ImageStretch);
			global::System.Drawing.Image value = null;
			global::SourceGrid.Cells.Models.IImage image = (global::SourceGrid.Cells.Models.IImage)context.Cell.Model.FindModel(typeof(global::SourceGrid.Cells.Models.IImage));
			if (image != null)
			{
				value = image.GetImage(context);
			}
			this.ElementImage.Value = value;
		}

		// Token: 0x04000DFF RID: 3583
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Views.Cell t_DefaultCell;

		// Token: 0x04000E00 RID: 3584
		private global::DevAge.Drawing.VisualElements.IText mElementText = new global::DevAge.Drawing.VisualElements.TextGDI();

		// Token: 0x04000E01 RID: 3585
		private global::DevAge.Drawing.VisualElements.IImage mElementImage = new global::DevAge.Drawing.VisualElements.Image();
	}
}
