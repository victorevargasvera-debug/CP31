using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003F4 RID: 1012
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot("chart", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = false)]
	[global::System.Serializable]
	public class CT_RelId
	{
		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06002883 RID: 10371 RVA: 0x00066083 File Offset: 0x00064283
		// (set) Token: 0x06002884 RID: 10372 RVA: 0x0006608B File Offset: 0x0006428B
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

		// Token: 0x06002885 RID: 10373 RVA: 0x00066094 File Offset: 0x00064294
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_RelId Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.Chart.CT_RelId
			{
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"])
			};
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x000660BB File Offset: 0x000642BB
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x04001D77 RID: 7543
		private string idField;
	}
}
