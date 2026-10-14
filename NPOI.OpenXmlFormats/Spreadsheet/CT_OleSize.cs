using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200061E RID: 1566
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_OleSize
	{
		// Token: 0x06004423 RID: 17443 RVA: 0x000A1FAE File Offset: 0x000A01AE
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleSize Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleSize
			{
				@ref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["ref"])
			};
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x000A1FD5 File Offset: 0x000A01D5
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ref", this.@ref);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x06004425 RID: 17445 RVA: 0x000A2015 File Offset: 0x000A0215
		// (set) Token: 0x06004426 RID: 17446 RVA: 0x000A201D File Offset: 0x000A021D
		[global::System.Xml.Serialization.XmlAttribute]
		public string @ref
		{
			get
			{
				return this.refField;
			}
			set
			{
				this.refField = value;
			}
		}

		// Token: 0x04002ACD RID: 10957
		private string refField;
	}
}
