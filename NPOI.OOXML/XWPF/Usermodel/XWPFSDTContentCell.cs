using System;
using System.IO;
using System.Text;
using System.Xml;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x0200004B RID: 75
	public class XWPFSDTContentCell : global::NPOI.XWPF.UserModel.ISDTContent
	{
		// Token: 0x06000320 RID: 800 RVA: 0x0000CA2C File Offset: 0x0000AC2C
		public XWPFSDTContentCell(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtContentCell sdtContentCell, global::NPOI.XWPF.UserModel.XWPFTableRow xwpfTableRow, global::NPOI.XWPF.UserModel.IBody part)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int num = 0;
			int num2 = 0;
			int num3 = 1;
			using (global::System.IO.StringReader stringReader = new global::System.IO.StringReader(sdtContentCell.ToString()))
			{
				global::System.Xml.XmlParserContext inputContext = new global::System.Xml.XmlParserContext(null, global::NPOI.POIXMLDocumentPart.NamespaceManager, null, global::System.Xml.XmlSpace.Preserve);
				using (global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(stringReader, null, inputContext))
				{
					while (xmlReader.Read() && num3 > 0)
					{
						if (xmlReader.NodeType == global::System.Xml.XmlNodeType.Text)
						{
							stringBuilder.Append(xmlReader.ReadContentAsString());
						}
						else if (this.IsStartToken(xmlReader, "tr"))
						{
							num = 0;
							num2 = 0;
						}
						else if (this.IsStartToken(xmlReader, "tc"))
						{
							if (num++ > 0)
							{
								stringBuilder.Append("\t");
							}
							num2 = 0;
						}
						else if (this.IsStartToken(xmlReader, "p") || this.IsStartToken(xmlReader, "tbl") || this.IsStartToken(xmlReader, "sdt"))
						{
							if (num2 > 0)
							{
								stringBuilder.Append("\n");
							}
							num2++;
						}
					}
				}
			}
			this.text = stringBuilder.ToString();
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000CB6C File Offset: 0x0000AD6C
		private bool IsStartToken(global::System.Xml.XmlReader cursor, string string1)
		{
			return cursor.IsStartElement() && cursor.LocalName == string1;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000065E4 File Offset: 0x000047E4
		private bool IsStartToken(object cursor, string string1)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0000CB89 File Offset: 0x0000AD89
		public string Text
		{
			get
			{
				return this.text;
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000CB91 File Offset: 0x0000AD91
		public override string ToString()
		{
			return this.Text;
		}

		// Token: 0x04000220 RID: 544
		private string text = "";
	}
}
