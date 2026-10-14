using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005BB RID: 1467
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_TablePart
	{
		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x0600408B RID: 16523 RVA: 0x0009C910 File Offset: 0x0009AB10
		// (set) Token: 0x0600408C RID: 16524 RVA: 0x0009C918 File Offset: 0x0009AB18
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x0009C921 File Offset: 0x0009AB21
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_TablePart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_TablePart
			{
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id", "http://schemas.openxmlformats.org/officeDocument/2006/relationships"])
			};
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x0009C94D File Offset: 0x0009AB4D
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040028ED RID: 10477
		private string idField;
	}
}
