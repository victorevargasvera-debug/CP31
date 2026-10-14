using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.WordProcessing
{
	// Token: 0x0200034E RID: 846
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")]
	[global::System.Xml.Serialization.XmlRoot("inline", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing", IsNullable = false)]
	[global::System.Serializable]
	public class CT_NonVisualGraphicFrameProperties
	{
		// Token: 0x06002152 RID: 8530 RVA: 0x00057B28 File Offset: 0x00055D28
		public static global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualGraphicFrameProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualGraphicFrameProperties ct_NonVisualGraphicFrameProperties = new global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_NonVisualGraphicFrameProperties();
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

		// Token: 0x06002153 RID: 8531 RVA: 0x00057BC8 File Offset: 0x00055DC8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<wp:{0}", nodeName));
			sw.Write(">");
			if (this.graphicFrameLocks != null)
			{
				this.graphicFrameLocks.Write(sw, "graphicFrameLocks");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</wp:{0}>", nodeName));
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x00057C34 File Offset: 0x00055E34
		// (set) Token: 0x06002155 RID: 8533 RVA: 0x00057C3C File Offset: 0x00055E3C
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

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x00057C45 File Offset: 0x00055E45
		// (set) Token: 0x06002157 RID: 8535 RVA: 0x00057C4D File Offset: 0x00055E4D
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

		// Token: 0x04001986 RID: 6534
		private global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectFrameLocking graphicFrameLocksField;

		// Token: 0x04001987 RID: 6535
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
