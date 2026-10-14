using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000369 RID: 873
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_NonVisualGraphicFrameProperties
	{
		// Token: 0x060022B1 RID: 8881 RVA: 0x0005A7C0 File Offset: 0x000589C0
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualGraphicFrameProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualGraphicFrameProperties ct_NonVisualGraphicFrameProperties = new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_NonVisualGraphicFrameProperties();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "graphicFrameLocks")
				{
					ct_NonVisualGraphicFrameProperties.graphicFrameLocks = global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectFrameLocking.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_NonVisualGraphicFrameProperties.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_NonVisualGraphicFrameProperties;
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x0005A860 File Offset: 0x00058A60
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
			sw.Write(">");
			if (this.graphicFrameLocks != null)
			{
				this.graphicFrameLocks.Write(sw, "graphicFrameLocks");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</xdr:{0}>", nodeName));
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x0005A8CC File Offset: 0x00058ACC
		// (set) Token: 0x060022B4 RID: 8884 RVA: 0x0005A8D4 File Offset: 0x00058AD4
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectFrameLocking graphicFrameLocks
		{
			get
			{
				return this.graphicFrameLocksField;
			}
			set
			{
				this.graphicFrameLocksField = value;
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x0005A8DD File Offset: 0x00058ADD
		// (set) Token: 0x060022B6 RID: 8886 RVA: 0x0005A8E5 File Offset: 0x00058AE5
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x04001A2E RID: 6702
		private global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectFrameLocking graphicFrameLocksField;

		// Token: 0x04001A2F RID: 6703
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
