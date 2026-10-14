using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000482 RID: 1154
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_PageItem
	{
		// Token: 0x06002E34 RID: 11828 RVA: 0x000740AA File Offset: 0x000722AA
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageItem Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PageItem
			{
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"])
			};
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x000740D1 File Offset: 0x000722D1
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x06002E36 RID: 11830 RVA: 0x00074111 File Offset: 0x00072311
		// (set) Token: 0x06002E37 RID: 11831 RVA: 0x00074119 File Offset: 0x00072319
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

		// Token: 0x04001FED RID: 8173
		private string nameField;
	}
}
