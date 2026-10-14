using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000582 RID: 1410
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Index
	{
		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x06003DCD RID: 15821 RVA: 0x000960AF File Offset: 0x000942AF
		// (set) Token: 0x06003DCE RID: 15822 RVA: 0x000960B7 File Offset: 0x000942B7
		public uint v
		{
			get
			{
				return this.vField;
			}
			set
			{
				this.vField = value;
			}
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x000960C0 File Offset: 0x000942C0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Index
			{
				v = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["v"])
			};
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x000960E8 File Offset: 0x000942E8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "v", this.v, false);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002755 RID: 10069
		private uint vField;
	}
}
