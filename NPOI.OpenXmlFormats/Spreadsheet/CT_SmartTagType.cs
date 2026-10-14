using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000528 RID: 1320
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_SmartTagType
	{
		// Token: 0x06003A10 RID: 14864 RVA: 0x00090358 File Offset: 0x0008E558
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SmartTagType
			{
				namespaceUri = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["namespaceUri"]),
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]),
				url = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["url"])
			};
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x000903C0 File Offset: 0x0008E5C0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "namespaceUri", this.namespaceUri);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "url", this.url);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06003A12 RID: 14866 RVA: 0x0009042D File Offset: 0x0008E62D
		// (set) Token: 0x06003A13 RID: 14867 RVA: 0x00090435 File Offset: 0x0008E635
		public string namespaceUri
		{
			get
			{
				return this.namespaceUriField;
			}
			set
			{
				this.namespaceUriField = value;
			}
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x06003A14 RID: 14868 RVA: 0x0009043E File Offset: 0x0008E63E
		// (set) Token: 0x06003A15 RID: 14869 RVA: 0x00090446 File Offset: 0x0008E646
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06003A16 RID: 14870 RVA: 0x0009044F File Offset: 0x0008E64F
		// (set) Token: 0x06003A17 RID: 14871 RVA: 0x00090457 File Offset: 0x0008E657
		public string url
		{
			get
			{
				return this.urlField;
			}
			set
			{
				this.urlField = value;
			}
		}

		// Token: 0x04002508 RID: 9480
		private string namespaceUriField;

		// Token: 0x04002509 RID: 9481
		private string nameField;

		// Token: 0x0400250A RID: 9482
		private string urlField;
	}
}
