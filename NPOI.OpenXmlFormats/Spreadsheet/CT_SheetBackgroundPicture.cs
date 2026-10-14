using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000626 RID: 1574
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_SheetBackgroundPicture
	{
		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x0600448D RID: 17549 RVA: 0x000A2D58 File Offset: 0x000A0F58
		// (set) Token: 0x0600448E RID: 17550 RVA: 0x000A2D60 File Offset: 0x000A0F60
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

		// Token: 0x0600448F RID: 17551 RVA: 0x000A2D69 File Offset: 0x000A0F69
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetBackgroundPicture Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetBackgroundPicture
			{
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id", "http://schemas.openxmlformats.org/officeDocument/2006/relationships"])
			};
		}

		// Token: 0x06004490 RID: 17552 RVA: 0x000A2D95 File Offset: 0x000A0F95
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002B05 RID: 11013
		private string idField;
	}
}
