using System;
using System.IO;
using System.Text;
using System.Xml;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005F8 RID: 1528
	public class SstDocument
	{
		// Token: 0x06004323 RID: 17187 RVA: 0x0000205F File Offset: 0x0000025F
		public SstDocument()
		{
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x0009FE3E File Offset: 0x0009E03E
		public SstDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sst sst)
		{
			this.sst = sst;
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x0009FE4D File Offset: 0x0009E04D
		public void AddNewSst()
		{
			this.sst = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sst();
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x0009FE5A File Offset: 0x0009E05A
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sst GetSst()
		{
			return this.sst;
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x0009FE64 File Offset: 0x0009E064
		public static global::NPOI.OpenXmlFormats.Spreadsheet.SstDocument Parse(global::System.Xml.XmlDocument xml, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.SstDocument result;
			try
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.SstDocument sstDocument = new global::NPOI.OpenXmlFormats.Spreadsheet.SstDocument();
				sstDocument.AddNewSst();
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sst ct_Sst = sstDocument.GetSst();
				ct_Sst.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(xml.DocumentElement.Attributes["count"]);
				ct_Sst.uniqueCount = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(xml.DocumentElement.Attributes["uniqueCount"]);
				global::System.Xml.XmlNodeList xmlNodeList = xml.SelectNodes("//d:sst/d:si", namespaceManager);
				if (xmlNodeList != null)
				{
					foreach (object obj in xmlNodeList)
					{
						global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst item = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst.Parse((global::System.Xml.XmlNode)obj, namespaceManager);
						sstDocument.sst.si.Add(item);
					}
				}
				result = sstDocument;
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::System.IO.IOException(ex.Message);
			}
			return result;
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x0009FF4C File Offset: 0x0009E14C
		public void Save(global::System.IO.Stream stream)
		{
			global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream, global::System.Text.Encoding.UTF8);
			streamWriter.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\" ?><sst xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\" count=\"{0}\" uniqueCount=\"{1}\">", this.GetSst().count, this.GetSst().uniqueCount);
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst ct_Rst in this.GetSst().si)
			{
				ct_Rst.Write(streamWriter, "si");
			}
			streamWriter.Write("</sst>");
			streamWriter.Flush();
		}

		// Token: 0x04002A5F RID: 10847
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sst sst;
	}
}
