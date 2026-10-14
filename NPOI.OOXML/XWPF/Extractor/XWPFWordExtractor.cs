using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.XWPF.Model;
using NPOI.XWPF.UserModel;

namespace NPOI.XWPF.Extractor
{
	// Token: 0x02000056 RID: 86
	public class XWPFWordExtractor : global::NPOI.POIXMLTextExtractor
	{
		// Token: 0x060003ED RID: 1005 RVA: 0x0000FC7A File Offset: 0x0000DE7A
		public XWPFWordExtractor(global::NPOI.OpenXml4Net.OPC.OPCPackage Container) : this(new global::NPOI.XWPF.UserModel.XWPFDocument(Container))
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000FC88 File Offset: 0x0000DE88
		public XWPFWordExtractor(global::NPOI.XWPF.UserModel.XWPFDocument document) : base(document)
		{
			this.document = document;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000FC98 File Offset: 0x0000DE98
		public void SetFetchHyperlinks(bool fetch)
		{
			this.fetchHyperlinks = fetch;
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0000FCA4 File Offset: 0x0000DEA4
		public override string Text
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				global::NPOI.XWPF.Model.XWPFHeaderFooterPolicy headerFooterPolicy = this.document.GetHeaderFooterPolicy();
				this.ExtractHeaders(stringBuilder, headerFooterPolicy);
				foreach (global::NPOI.XWPF.UserModel.IBodyElement e in this.document.BodyElements)
				{
					this.AppendBodyElementText(stringBuilder, e);
					stringBuilder.Append('\n');
				}
				this.ExtractFooters(stringBuilder, headerFooterPolicy);
				return stringBuilder.ToString();
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000FD28 File Offset: 0x0000DF28
		public void AppendBodyElementText(global::System.Text.StringBuilder text, global::NPOI.XWPF.UserModel.IBodyElement e)
		{
			if (e is global::NPOI.XWPF.UserModel.XWPFParagraph)
			{
				this.AppendParagraphText(text, (global::NPOI.XWPF.UserModel.XWPFParagraph)e);
				return;
			}
			if (e is global::NPOI.XWPF.UserModel.XWPFTable)
			{
				this.AppendTableText(text, (global::NPOI.XWPF.UserModel.XWPFTable)e);
				return;
			}
			if (e is global::NPOI.XWPF.UserModel.XWPFSDT)
			{
				text.Append(((global::NPOI.XWPF.UserModel.XWPFSDT)e).Content.Text);
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000FD80 File Offset: 0x0000DF80
		public void AppendParagraphText(global::System.Text.StringBuilder text, global::NPOI.XWPF.UserModel.XWPFParagraph paragraph)
		{
			try
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectPr ct_SectPr = null;
				if (paragraph.GetCTP().pPr != null)
				{
					ct_SectPr = paragraph.GetCTP().pPr.sectPr;
				}
				global::NPOI.XWPF.Model.XWPFHeaderFooterPolicy hfPolicy = null;
				if (ct_SectPr != null)
				{
					hfPolicy = new global::NPOI.XWPF.Model.XWPFHeaderFooterPolicy(this.document, ct_SectPr);
					this.ExtractHeaders(text, hfPolicy);
				}
				foreach (global::NPOI.XWPF.UserModel.IRunElement runElement in paragraph.Runs)
				{
					text.Append(runElement.ToString());
					if (runElement is global::NPOI.XWPF.UserModel.XWPFHyperlinkRun && this.fetchHyperlinks)
					{
						global::NPOI.XWPF.UserModel.XWPFHyperlink hyperlink = ((global::NPOI.XWPF.UserModel.XWPFHyperlinkRun)runElement).GetHyperlink(this.document);
						if (hyperlink != null)
						{
							text.Append(" <" + hyperlink.URL + ">");
						}
					}
				}
				string commentText = new global::NPOI.XWPF.Model.XWPFCommentsDecorator(paragraph, null).GetCommentText();
				if (commentText.Length > 0)
				{
					text.Append(commentText).Append('\n');
				}
				string footnoteText = paragraph.FootnoteText;
				if (footnoteText != null && footnoteText.Length > 0)
				{
					text.Append(footnoteText + "\n");
				}
				if (ct_SectPr != null)
				{
					this.ExtractFooters(text, hfPolicy);
				}
			}
			catch (global::System.IO.IOException ex)
			{
				throw new global::NPOI.POIXMLException(ex);
			}
			catch (global::System.Xml.XmlException ex2)
			{
				throw new global::NPOI.POIXMLException(ex2);
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000FEFC File Offset: 0x0000E0FC
		private void AppendTableText(global::System.Text.StringBuilder text, global::NPOI.XWPF.UserModel.XWPFTable table)
		{
			foreach (global::NPOI.XWPF.UserModel.XWPFTableRow xwpftableRow in table.Rows)
			{
				global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.ICell> tableICells = xwpftableRow.GetTableICells();
				for (int i = 0; i < tableICells.Count; i++)
				{
					global::NPOI.XWPF.UserModel.ICell cell = tableICells[i];
					if (cell is global::NPOI.XWPF.UserModel.XWPFTableCell)
					{
						text.Append(((global::NPOI.XWPF.UserModel.XWPFTableCell)cell).GetTextRecursively());
					}
					else if (cell is global::NPOI.XWPF.UserModel.XWPFSDTCell)
					{
						text.Append(((global::NPOI.XWPF.UserModel.XWPFSDTCell)cell).Content.Text);
					}
					if (i < tableICells.Count - 1)
					{
						text.Append("\t");
					}
				}
				text.Append('\n');
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000FFC8 File Offset: 0x0000E1C8
		private void ExtractFooters(global::System.Text.StringBuilder text, global::NPOI.XWPF.Model.XWPFHeaderFooterPolicy hfPolicy)
		{
			if (hfPolicy == null)
			{
				return;
			}
			if (hfPolicy.GetFirstPageFooter() != null)
			{
				text.Append(hfPolicy.GetFirstPageFooter().Text);
			}
			if (hfPolicy.GetEvenPageFooter() != null)
			{
				text.Append(hfPolicy.GetEvenPageFooter().Text);
			}
			if (hfPolicy.GetDefaultFooter() != null)
			{
				text.Append(hfPolicy.GetDefaultFooter().Text);
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00010028 File Offset: 0x0000E228
		private void ExtractHeaders(global::System.Text.StringBuilder text, global::NPOI.XWPF.Model.XWPFHeaderFooterPolicy hfPolicy)
		{
			if (hfPolicy == null)
			{
				return;
			}
			if (hfPolicy.GetFirstPageHeader() != null)
			{
				text.Append(hfPolicy.GetFirstPageHeader().Text);
			}
			if (hfPolicy.GetEvenPageHeader() != null)
			{
				text.Append(hfPolicy.GetEvenPageHeader().Text);
			}
			if (hfPolicy.GetDefaultHeader() != null)
			{
				text.Append(hfPolicy.GetDefaultHeader().Text);
			}
		}

		// Token: 0x04000248 RID: 584
		public static global::NPOI.XWPF.UserModel.XWPFRelation[] SUPPORTED_TYPES = new global::NPOI.XWPF.UserModel.XWPFRelation[]
		{
			global::NPOI.XWPF.UserModel.XWPFRelation.DOCUMENT,
			global::NPOI.XWPF.UserModel.XWPFRelation.TEMPLATE,
			global::NPOI.XWPF.UserModel.XWPFRelation.MACRO_DOCUMENT,
			global::NPOI.XWPF.UserModel.XWPFRelation.MACRO_TEMPLATE_DOCUMENT
		};

		// Token: 0x04000249 RID: 585
		private global::NPOI.XWPF.UserModel.XWPFDocument document;

		// Token: 0x0400024A RID: 586
		private bool fetchHyperlinks;
	}
}
