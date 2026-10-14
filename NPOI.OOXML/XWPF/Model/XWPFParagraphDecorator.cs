using System;
using NPOI.XWPF.UserModel;

namespace NPOI.XWPF.Model
{
	// Token: 0x02000055 RID: 85
	public abstract class XWPFParagraphDecorator
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x0000FC39 File Offset: 0x0000DE39
		public XWPFParagraphDecorator(global::NPOI.XWPF.UserModel.XWPFParagraph paragraph) : this(paragraph, null)
		{
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000FC43 File Offset: 0x0000DE43
		public XWPFParagraphDecorator(global::NPOI.XWPF.UserModel.XWPFParagraph paragraph, global::NPOI.XWPF.Model.XWPFParagraphDecorator nextDecorator)
		{
			this.paragraph = paragraph;
			this.nextDecorator = nextDecorator;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0000FC59 File Offset: 0x0000DE59
		public virtual string Text
		{
			get
			{
				if (this.nextDecorator != null)
				{
					return this.nextDecorator.Text;
				}
				return this.paragraph.Text;
			}
		}

		// Token: 0x04000246 RID: 582
		internal global::NPOI.XWPF.UserModel.XWPFParagraph paragraph;

		// Token: 0x04000247 RID: 583
		internal global::NPOI.XWPF.Model.XWPFParagraphDecorator nextDecorator;
	}
}
