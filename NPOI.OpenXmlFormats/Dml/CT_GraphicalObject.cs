using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002D9 RID: 729
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GraphicalObject
	{
		// Token: 0x06001C8F RID: 7311 RVA: 0x0004E1C7 File Offset: 0x0004C3C7
		public global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectData AddNewGraphicData()
		{
			this.graphicDataField = new global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectData();
			return this.graphicDataField;
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0004E1DC File Offset: 0x0004C3DC
		public static global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject ct_GraphicalObject = new global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObject();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "graphicData")
				{
					ct_GraphicalObject.graphicData = global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectData.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_GraphicalObject;
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x0004E25C File Offset: 0x0004C45C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0} xmlns:a=\"http://schemas.openxmlformats.org/drawingml/2006/main\">", nodeName));
			if (this.graphicData != null)
			{
				this.graphicData.Write(sw, "graphicData");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06001C92 RID: 7314 RVA: 0x0004E299 File Offset: 0x0004C499
		// (set) Token: 0x06001C93 RID: 7315 RVA: 0x0004E2A1 File Offset: 0x0004C4A1
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectData graphicData
		{
			get
			{
				return this.graphicDataField;
			}
			set
			{
				this.graphicDataField = value;
			}
		}

		// Token: 0x04001649 RID: 5705
		private global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectData graphicDataField;
	}
}
