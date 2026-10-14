using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003FA RID: 1018
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ExternalData
	{
		// Token: 0x060028D0 RID: 10448 RVA: 0x00066C78 File Offset: 0x00064E78
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_ExternalData Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ExternalData ct_ExternalData = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ExternalData();
			ct_ExternalData.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "autoUpdate")
				{
					ct_ExternalData.autoUpdate = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ExternalData;
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x00066D10 File Offset: 0x00064F10
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.id);
			sw.Write(">");
			if (this.autoUpdate != null)
			{
				this.autoUpdate.Write(sw, "autoUpdate");
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x060028D2 RID: 10450 RVA: 0x00066D74 File Offset: 0x00064F74
		// (set) Token: 0x060028D3 RID: 10451 RVA: 0x00066D7C File Offset: 0x00064F7C
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean autoUpdate
		{
			get
			{
				return this.autoUpdateField;
			}
			set
			{
				this.autoUpdateField = value;
			}
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x060028D4 RID: 10452 RVA: 0x00066D85 File Offset: 0x00064F85
		// (set) Token: 0x060028D5 RID: 10453 RVA: 0x00066D8D File Offset: 0x00064F8D
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

		// Token: 0x04001D98 RID: 7576
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean autoUpdateField;

		// Token: 0x04001D99 RID: 7577
		private string idField;
	}
}
