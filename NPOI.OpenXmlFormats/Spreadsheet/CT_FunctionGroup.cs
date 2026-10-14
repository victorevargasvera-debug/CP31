using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000572 RID: 1394
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_FunctionGroup
	{
		// Token: 0x06003CC1 RID: 15553 RVA: 0x00093A34 File Offset: 0x00091C34
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_FunctionGroup Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_FunctionGroup
			{
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"])
			};
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x00093A5B File Offset: 0x00091C5B
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x06003CC3 RID: 15555 RVA: 0x00093A9B File Offset: 0x00091C9B
		// (set) Token: 0x06003CC4 RID: 15556 RVA: 0x00093AA3 File Offset: 0x00091CA3
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

		// Token: 0x040026E0 RID: 9952
		private string nameField;
	}
}
