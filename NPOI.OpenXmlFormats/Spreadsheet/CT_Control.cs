using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005B6 RID: 1462
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Control
	{
		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x0600405C RID: 16476 RVA: 0x0009C211 File Offset: 0x0009A411
		// (set) Token: 0x0600405D RID: 16477 RVA: 0x0009C219 File Offset: 0x0009A419
		public uint shapeId
		{
			get
			{
				return this.shapeIdField;
			}
			set
			{
				this.shapeIdField = value;
			}
		}

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x0600405E RID: 16478 RVA: 0x0009C222 File Offset: 0x0009A422
		// (set) Token: 0x0600405F RID: 16479 RVA: 0x0009C22A File Offset: 0x0009A42A
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

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x06004060 RID: 16480 RVA: 0x0009C233 File Offset: 0x0009A433
		// (set) Token: 0x06004061 RID: 16481 RVA: 0x0009C23B File Offset: 0x0009A43B
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

		// Token: 0x06004062 RID: 16482 RVA: 0x0009C244 File Offset: 0x0009A444
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Control Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Control
			{
				shapeId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["shapeId"]),
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id", "http://schemas.openxmlformats.org/officeDocument/2006/relationships"]),
				name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"])
			};
		}

		// Token: 0x06004063 RID: 16483 RVA: 0x0009C2B4 File Offset: 0x0009A4B4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "shapeId", this.shapeId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x040028D3 RID: 10451
		private uint shapeIdField;

		// Token: 0x040028D4 RID: 10452
		private string idField;

		// Token: 0x040028D5 RID: 10453
		private string nameField;
	}
}
