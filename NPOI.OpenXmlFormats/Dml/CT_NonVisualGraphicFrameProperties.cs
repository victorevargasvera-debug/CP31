using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002FE RID: 766
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NonVisualGraphicFrameProperties
	{
		// Token: 0x06001DDE RID: 7646 RVA: 0x00050E70 File Offset: 0x0004F070
		public static global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGraphicFrameProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGraphicFrameProperties ct_NonVisualGraphicFrameProperties = new global::NPOI.OpenXmlFormats.Dml.CT_NonVisualGraphicFrameProperties();
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

		// Token: 0x06001DDF RID: 7647 RVA: 0x00050F10 File Offset: 0x0004F110
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.graphicFrameLocks != null)
			{
				this.graphicFrameLocks.Write(sw, "graphicFrameLocks");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x00050F7C File Offset: 0x0004F17C
		// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x00050F84 File Offset: 0x0004F184
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

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x00050F8D File Offset: 0x0004F18D
		// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x00050F95 File Offset: 0x0004F195
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

		// Token: 0x040017B7 RID: 6071
		private global::NPOI.OpenXmlFormats.Dml.CT_GraphicalObjectFrameLocking graphicFrameLocksField;

		// Token: 0x040017B8 RID: 6072
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
