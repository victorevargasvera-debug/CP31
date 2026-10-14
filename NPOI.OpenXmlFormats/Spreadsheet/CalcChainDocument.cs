using System;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000548 RID: 1352
	public class CalcChainDocument
	{
		// Token: 0x06003B01 RID: 15105 RVA: 0x00091D6F File Offset: 0x0008FF6F
		public CalcChainDocument()
		{
			this.calcChain = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcChain();
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x00091D82 File Offset: 0x0008FF82
		internal CalcChainDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcChain calcChain)
		{
			this.calcChain = calcChain;
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x00091D91 File Offset: 0x0008FF91
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcChain GetCalcChain()
		{
			return this.calcChain;
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x00091D99 File Offset: 0x0008FF99
		public void SetCalcChain(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcChain calcchain)
		{
			this.calcChain = calcchain;
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x00091DA4 File Offset: 0x0008FFA4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CalcChainDocument Parse(global::System.Xml.XmlDocument xmlDoc, global::System.Xml.XmlNamespaceManager NameSpaceManager)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CalcChainDocument calcChainDocument = new global::NPOI.OpenXmlFormats.Spreadsheet.CalcChainDocument();
			foreach (object obj in xmlDoc.SelectNodes("//d:c", NameSpaceManager))
			{
				global::System.Xml.XmlElement xmlElement = (global::System.Xml.XmlElement)obj;
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcCell ct_CalcCell = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcCell();
				if (xmlElement.GetAttributeNode("i") != null)
				{
					ct_CalcCell.i = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(xmlElement.GetAttributeNode("i"));
					ct_CalcCell.iSpecified = true;
				}
				ct_CalcCell.r = xmlElement.GetAttribute("r");
				ct_CalcCell.t = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(xmlElement.GetAttributeNode("t"));
				ct_CalcCell.s = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(xmlElement.GetAttributeNode("s"));
				ct_CalcCell.l = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(xmlElement.GetAttributeNode("l"));
				calcChainDocument.calcChain.AddC(ct_CalcCell);
			}
			return calcChainDocument;
		}

		// Token: 0x06003B06 RID: 15110 RVA: 0x00091E9C File Offset: 0x0009009C
		public void Save(global::System.IO.Stream stream)
		{
			global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream);
			streamWriter.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\" ?>");
			streamWriter.Write("<calcChain xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\">");
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcCell ct_CalcCell in this.calcChain.c)
			{
				streamWriter.Write("<c");
				streamWriter.Write(" r=\"" + ct_CalcCell.r + "\"");
				if (ct_CalcCell.i > 0)
				{
					streamWriter.Write(" i=\"" + ct_CalcCell.i.ToString() + "\"");
				}
				if (ct_CalcCell.s)
				{
					streamWriter.Write(" s=\"" + (ct_CalcCell.s ? 1 : 0).ToString() + "\"");
				}
				if (ct_CalcCell.t)
				{
					streamWriter.Write(" t=\"" + (ct_CalcCell.t ? 1 : 0).ToString() + "\"");
				}
				if (ct_CalcCell.l)
				{
					streamWriter.Write(" l=\"" + (ct_CalcCell.l ? 1 : 0).ToString() + "\"");
				}
				streamWriter.Write("/>");
			}
			streamWriter.Write("</calcChain>");
			streamWriter.Flush();
		}

		// Token: 0x040025C5 RID: 9669
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcChain calcChain;
	}
}
