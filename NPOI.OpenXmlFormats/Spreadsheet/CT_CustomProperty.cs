using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005AC RID: 1452
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_CustomProperty
	{
		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x06004004 RID: 16388 RVA: 0x0009B4E4 File Offset: 0x000996E4
		// (set) Token: 0x06004005 RID: 16389 RVA: 0x0009B4EC File Offset: 0x000996EC
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

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06004006 RID: 16390 RVA: 0x0009B4F5 File Offset: 0x000996F5
		// (set) Token: 0x06004007 RID: 16391 RVA: 0x0009B4FD File Offset: 0x000996FD
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

		// Token: 0x06004008 RID: 16392 RVA: 0x0009B508 File Offset: 0x00099708
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomProperty Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomProperty
			{
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]),
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id", "http://schemas.openxmlformats.org/officeDocument/2006/relationships"])
			};
		}

		// Token: 0x06004009 RID: 16393 RVA: 0x0009B55C File Offset: 0x0009975C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040028AE RID: 10414
		private string nameField;

		// Token: 0x040028AF RID: 10415
		private string idField;
	}
}
