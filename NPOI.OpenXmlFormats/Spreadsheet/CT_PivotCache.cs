using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000526 RID: 1318
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_PivotCache
	{
		// Token: 0x06003A04 RID: 14852 RVA: 0x00090154 File Offset: 0x0008E354
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache
			{
				cacheId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["cacheId"]),
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id", "http://schemas.openxmlformats.org/officeDocument/2006/relationships"])
			};
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x000901A8 File Offset: 0x0008E3A8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cacheId", this.cacheId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06003A06 RID: 14854 RVA: 0x00090205 File Offset: 0x0008E405
		// (set) Token: 0x06003A07 RID: 14855 RVA: 0x0009020D File Offset: 0x0008E40D
		[global::System.Xml.Serialization.XmlAttribute]
		public uint cacheId
		{
			get
			{
				return this.cacheIdField;
			}
			set
			{
				this.cacheIdField = value;
			}
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x06003A08 RID: 14856 RVA: 0x00090216 File Offset: 0x0008E416
		// (set) Token: 0x06003A09 RID: 14857 RVA: 0x0009021E File Offset: 0x0008E41E
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

		// Token: 0x04002505 RID: 9477
		private uint cacheIdField;

		// Token: 0x04002506 RID: 9478
		private string idField;
	}
}
