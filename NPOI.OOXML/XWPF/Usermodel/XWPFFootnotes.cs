using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000039 RID: 57
	public class XWPFFootnotes : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x00007728 File Offset: 0x00005928
		public XWPFFootnotes(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000773C File Offset: 0x0000593C
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public XWPFFootnotes(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00007745 File Offset: 0x00005945
		public XWPFFootnotes()
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00007758 File Offset: 0x00005958
		internal override void OnDocumentRead()
		{
			global::System.IO.Stream stream = null;
			try
			{
				stream = base.GetPackagePart().GetInputStream();
				global::NPOI.OpenXmlFormats.Wordprocessing.FootnotesDocument footnotesDocument = global::NPOI.OpenXmlFormats.Wordprocessing.FootnotesDocument.Parse(global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(stream), global::NPOI.POIXMLDocumentPart.NamespaceManager);
				this.ctFootnotes = footnotesDocument.Footnotes;
			}
			catch (global::System.Xml.XmlException)
			{
				throw new global::NPOI.POIXMLException();
			}
			finally
			{
				if (stream != null)
				{
					stream.Close();
				}
			}
			if (this.ctFootnotes.footnote != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn note in this.ctFootnotes.footnote)
				{
					this.listFootnote.Add(new global::NPOI.XWPF.UserModel.XWPFFootnote(note, this));
				}
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00007820 File Offset: 0x00005A20
		protected internal override void Commit()
		{
			using (global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream())
			{
				new global::NPOI.OpenXmlFormats.Wordprocessing.FootnotesDocument(this.ctFootnotes).Save(outputStream);
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00007868 File Offset: 0x00005A68
		public global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFFootnote> GetFootnotesList()
		{
			return this.listFootnote;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00007870 File Offset: 0x00005A70
		public global::NPOI.XWPF.UserModel.XWPFFootnote GetFootnoteById(int id)
		{
			foreach (global::NPOI.XWPF.UserModel.XWPFFootnote xwpffootnote in this.listFootnote)
			{
				if (xwpffootnote.GetCTFtnEdn().id == id.ToString())
				{
					return xwpffootnote;
				}
			}
			return null;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000078DC File Offset: 0x00005ADC
		public void SetFootnotes(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Footnotes footnotes)
		{
			this.ctFootnotes = footnotes;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000078E5 File Offset: 0x00005AE5
		public void AddFootnote(global::NPOI.XWPF.UserModel.XWPFFootnote footnote)
		{
			this.listFootnote.Add(footnote);
			this.ctFootnotes.AddNewFootnote().Set(footnote.GetCTFtnEdn());
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000790C File Offset: 0x00005B0C
		public global::NPOI.XWPF.UserModel.XWPFFootnote AddFootnote(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn note)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn ct_FtnEdn = this.ctFootnotes.AddNewFootnote();
			ct_FtnEdn.Set(note);
			global::NPOI.XWPF.UserModel.XWPFFootnote xwpffootnote = new global::NPOI.XWPF.UserModel.XWPFFootnote(ct_FtnEdn, this);
			this.listFootnote.Add(xwpffootnote);
			return xwpffootnote;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000793F File Offset: 0x00005B3F
		public void SetXWPFDocument(global::NPOI.XWPF.UserModel.XWPFDocument doc)
		{
			this.document = doc;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00007948 File Offset: 0x00005B48
		public global::NPOI.XWPF.UserModel.XWPFDocument GetXWPFDocument()
		{
			if (this.document != null)
			{
				return this.document;
			}
			return (global::NPOI.XWPF.UserModel.XWPFDocument)base.GetParent();
		}

		// Token: 0x040001D0 RID: 464
		private global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFFootnote> listFootnote = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFFootnote>();

		// Token: 0x040001D1 RID: 465
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Footnotes ctFootnotes;

		// Token: 0x040001D2 RID: 466
		protected global::NPOI.XWPF.UserModel.XWPFDocument document;
	}
}
