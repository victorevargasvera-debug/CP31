using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000508 RID: 1288
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_NumFmt
	{
		// Token: 0x06003740 RID: 14144 RVA: 0x00089E9C File Offset: 0x0008809C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmt Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_NumFmt
			{
				numFmtId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["numFmtId"]),
				formatCode = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["formatCode"])
			};
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x00089EEC File Offset: 0x000880EC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "numFmtId", this.numFmtId, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "formatCode", this.formatCode);
			sw.Write("/>");
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06003742 RID: 14146 RVA: 0x00089F38 File Offset: 0x00088138
		// (set) Token: 0x06003743 RID: 14147 RVA: 0x00089F40 File Offset: 0x00088140
		[global::System.Xml.Serialization.XmlAttribute]
		public uint numFmtId
		{
			get
			{
				return this.numFmtIdField;
			}
			set
			{
				this.numFmtIdField = value;
			}
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x06003744 RID: 14148 RVA: 0x00089F49 File Offset: 0x00088149
		// (set) Token: 0x06003745 RID: 14149 RVA: 0x00089F51 File Offset: 0x00088151
		[global::System.Xml.Serialization.XmlAttribute]
		public string formatCode
		{
			get
			{
				return this.formatCodeField;
			}
			set
			{
				this.formatCodeField = value;
			}
		}

		// Token: 0x0400240B RID: 9227
		private uint numFmtIdField;

		// Token: 0x0400240C RID: 9228
		private string formatCodeField;
	}
}
