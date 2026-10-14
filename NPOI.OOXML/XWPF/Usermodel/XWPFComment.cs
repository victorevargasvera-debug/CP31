using System;
using System.Text;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000031 RID: 49
	public class XWPFComment
	{
		// Token: 0x0600015A RID: 346 RVA: 0x000056E0 File Offset: 0x000038E0
		public XWPFComment(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comment comment, global::NPOI.XWPF.UserModel.XWPFDocument document)
		{
			this.text = new global::System.Text.StringBuilder();
			this.id = comment.id.ToString();
			this.author = comment.author;
			foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_P prgrph in comment.GetPList())
			{
				global::NPOI.XWPF.UserModel.XWPFParagraph xwpfparagraph = new global::NPOI.XWPF.UserModel.XWPFParagraph(prgrph, document);
				this.text.Append(xwpfparagraph.Text);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000576C File Offset: 0x0000396C
		public string Id
		{
			get
			{
				return this.id;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00005774 File Offset: 0x00003974
		public string Author
		{
			get
			{
				return this.author;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0000577C File Offset: 0x0000397C
		public string Text
		{
			get
			{
				return this.text.ToString();
			}
		}

		// Token: 0x040001AF RID: 431
		protected string id;

		// Token: 0x040001B0 RID: 432
		protected string author;

		// Token: 0x040001B1 RID: 433
		protected global::System.Text.StringBuilder text;
	}
}
