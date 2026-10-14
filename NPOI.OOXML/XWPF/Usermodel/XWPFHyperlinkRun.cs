using System;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x0200003D RID: 61
	public class XWPFHyperlinkRun : global::NPOI.XWPF.UserModel.XWPFRun
	{
		// Token: 0x06000229 RID: 553 RVA: 0x000082C6 File Offset: 0x000064C6
		public XWPFHyperlinkRun(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1 hyperlink, global::NPOI.OpenXmlFormats.Wordprocessing.CT_R Run, global::NPOI.XWPF.UserModel.IRunBody p) : base(Run, p)
		{
			this.hyperlink = hyperlink;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000082D7 File Offset: 0x000064D7
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1 GetCTHyperlink()
		{
			return this.hyperlink;
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600022B RID: 555 RVA: 0x000082DF File Offset: 0x000064DF
		public string Anchor
		{
			get
			{
				return this.hyperlink.anchor;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600022C RID: 556 RVA: 0x000082EC File Offset: 0x000064EC
		// (set) Token: 0x0600022D RID: 557 RVA: 0x000082F9 File Offset: 0x000064F9
		public string HyperlinkId
		{
			get
			{
				return this.hyperlink.id;
			}
			set
			{
				this.hyperlink.id = value;
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00008308 File Offset: 0x00006508
		public global::NPOI.XWPF.UserModel.XWPFHyperlink GetHyperlink(global::NPOI.XWPF.UserModel.XWPFDocument document)
		{
			string hyperlinkId = this.HyperlinkId;
			if (hyperlinkId == null)
			{
				return null;
			}
			return document.GetHyperlinkByID(hyperlinkId);
		}

		// Token: 0x040001DB RID: 475
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hyperlink1 hyperlink;
	}
}
