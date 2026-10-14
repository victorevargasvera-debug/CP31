using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000123 RID: 291
	public class CT_Endnotes
	{
		// Token: 0x060007EA RID: 2026 RVA: 0x0001ABD8 File Offset: 0x00018DD8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Endnotes Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Endnotes ct_Endnotes = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Endnotes();
			ct_Endnotes.endnote = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "endnote")
				{
					ct_Endnotes.endnote.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Endnotes;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0001AC68 File Offset: 0x00018E68
		internal void Write(global::System.IO.StreamWriter sw)
		{
			sw.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
			sw.Write("<w:endnotes xmlns:ve=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" xmlns:o=\"urn:schemas-microsoft-com:office:office\" ");
			sw.Write("xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\" xmlns:m=\"http://schemas.openxmlformats.org/officeDocument/2006/math\" ");
			sw.Write("xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:wp=\"http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing\" ");
			sw.Write("xmlns:w10=\"urn:schemas-microsoft-com:office:word\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" ");
			sw.Write("xmlns:wne=\"http://schemas.microsoft.com/office/word/2006/wordml\">");
			if (this.endnote != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn ct_FtnEdn in this.endnote)
				{
					ct_FtnEdn.Write(sw, "endnote");
				}
			}
			sw.Write("</w:endnotes>");
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0001AD14 File Offset: 0x00018F14
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x0001AD1C File Offset: 0x00018F1C
		[global::System.Xml.Serialization.XmlElement("endnote", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn> endnote
		{
			get
			{
				return this.endnoteField;
			}
			set
			{
				this.endnoteField = value;
			}
		}

		// Token: 0x04000728 RID: 1832
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn> endnoteField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn>();
	}
}
