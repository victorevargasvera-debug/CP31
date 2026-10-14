using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004DC RID: 1244
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Member
	{
		// Token: 0x06003402 RID: 13314 RVA: 0x000828EC File Offset: 0x00080AEC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Member Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Member
			{
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"])
			};
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x00082913 File Offset: 0x00080B13
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x06003404 RID: 13316 RVA: 0x00082953 File Offset: 0x00080B53
		// (set) Token: 0x06003405 RID: 13317 RVA: 0x0008295B File Offset: 0x00080B5B
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x0400228E RID: 8846
		private string nameField;
	}
}
