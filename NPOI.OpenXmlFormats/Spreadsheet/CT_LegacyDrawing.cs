using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005C4 RID: 1476
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_LegacyDrawing
	{
		// Token: 0x06004102 RID: 16642 RVA: 0x0009DD41 File Offset: 0x0009BF41
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_LegacyDrawing
			{
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id", "http://schemas.openxmlformats.org/officeDocument/2006/relationships"])
			};
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x0009DD6D File Offset: 0x0009BF6D
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write("/>");
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x06004104 RID: 16644 RVA: 0x0009DD9C File Offset: 0x0009BF9C
		// (set) Token: 0x06004105 RID: 16645 RVA: 0x0009DDA4 File Offset: 0x0009BFA4
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

		// Token: 0x0400291B RID: 10523
		private string idField = string.Empty;
	}
}
