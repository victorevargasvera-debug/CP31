using System;
using System.Text;
using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.XWPF.UserModel;

namespace NPOI.XWPF.Model
{
	// Token: 0x02000053 RID: 83
	public class XWPFCommentsDecorator : global::NPOI.XWPF.Model.XWPFParagraphDecorator
	{
		// Token: 0x060003CA RID: 970 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		public XWPFCommentsDecorator(global::NPOI.XWPF.Model.XWPFParagraphDecorator nextDecorator) : this(nextDecorator.paragraph, nextDecorator)
		{
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000F2C8 File Offset: 0x0000D4C8
		public XWPFCommentsDecorator(global::NPOI.XWPF.UserModel.XWPFParagraph paragraph, global::NPOI.XWPF.Model.XWPFParagraphDecorator nextDecorator) : base(paragraph, nextDecorator)
		{
			this.commentText = new global::System.Text.StringBuilder();
			foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_MarkupRange ct_MarkupRange in paragraph.GetCTP().GetCommentRangeStartList())
			{
				global::NPOI.XWPF.UserModel.XWPFComment commentByID;
				if ((commentByID = paragraph.Document.GetCommentByID(ct_MarkupRange.id)) != null)
				{
					this.commentText.Append("\tComment by " + commentByID.Author + ": " + commentByID.Text);
				}
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000F364 File Offset: 0x0000D564
		public string GetCommentText()
		{
			return this.commentText.ToString();
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0000F371 File Offset: 0x0000D571
		public override string Text
		{
			get
			{
				string text = base.Text;
				global::System.Text.StringBuilder stringBuilder = this.commentText;
				return text + ((stringBuilder != null) ? stringBuilder.ToString() : null);
			}
		}

		// Token: 0x0400023B RID: 571
		private global::System.Text.StringBuilder commentText;
	}
}
