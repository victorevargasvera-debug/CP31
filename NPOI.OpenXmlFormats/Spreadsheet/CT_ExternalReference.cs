using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000521 RID: 1313
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_ExternalReference
	{
		// Token: 0x060039C3 RID: 14787 RVA: 0x0008F7E1 File Offset: 0x0008D9E1
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalReference Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalReference
			{
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id", "http://schemas.openxmlformats.org/officeDocument/2006/relationships"])
			};
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x0008F80D File Offset: 0x0008DA0D
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x060039C5 RID: 14789 RVA: 0x0008F84D File Offset: 0x0008DA4D
		// (set) Token: 0x060039C6 RID: 14790 RVA: 0x0008F855 File Offset: 0x0008DA55
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

		// Token: 0x040024EF RID: 9455
		private string idField;
	}
}
