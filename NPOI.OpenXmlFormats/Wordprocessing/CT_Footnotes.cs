using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200011F RID: 287
	public class CT_Footnotes
	{
		// Token: 0x060007CC RID: 1996 RVA: 0x00019A6C File Offset: 0x00017C6C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Footnotes Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Footnotes ct_Footnotes = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Footnotes();
			ct_Footnotes.footnote = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "footnote")
				{
					ct_Footnotes.footnote.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Footnotes;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00019AFC File Offset: 0x00017CFC
		internal void Write(global::System.IO.StreamWriter sw)
		{
			sw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
			sw.Write("<w:footnotes xmlns:wpc=\"http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas\" xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" ");
			sw.Write("xmlns:o=\"urn:schemas-microsoft-com:office:office\" ");
			sw.Write("xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\" xmlns:m=\"http://schemas.openxmlformats.org/officeDocument/2006/math\" ");
			sw.Write("xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:wp14=\"http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing\" ");
			sw.Write("xmlns:wp=\"http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" ");
			sw.Write("xmlns:w14=\"http://schemas.microsoft.com/office/word/2010/wordml\" xmlns:w15=\"http://schemas.microsoft.com/office/word/2012/wordml\" xmlns:w10=\"urn:schemas-microsoft-com:office:word\" ");
			sw.Write("xmlns:wpg=\"http://schemas.microsoft.com/office/word/2010/wordprocessingGroup\" xmlns:wpi=\"http://schemas.microsoft.com/office/word/2010/wordprocessingInk\" ");
			sw.Write("xmlns:wne=\"http://schemas.microsoft.com/office/word/2006/wordml\" xmlns:wps=\"http://schemas.microsoft.com/office/word/2010/wordprocessingShape\" ");
			sw.Write("mc:Ignorable=\"w14 w15 wp14\">");
			if (this.footnote != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn ct_FtnEdn in this.footnote)
				{
					ct_FtnEdn.Write(sw, "footnote");
				}
			}
			sw.Write("</w:footnotes>");
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x00019BD4 File Offset: 0x00017DD4
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x00019BDC File Offset: 0x00017DDC
		[global::System.Xml.Serialization.XmlElement("footnote", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn> footnote
		{
			get
			{
				return this.footnoteField;
			}
			set
			{
				this.footnoteField = value;
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00019BE8 File Offset: 0x00017DE8
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn AddNewFootnote()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn ct_FtnEdn = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn();
			if (this.footnoteField == null)
			{
				this.footnoteField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn>();
			}
			this.footnoteField.Add(ct_FtnEdn);
			return ct_FtnEdn;
		}

		// Token: 0x040006FE RID: 1790
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn> footnoteField;
	}
}
