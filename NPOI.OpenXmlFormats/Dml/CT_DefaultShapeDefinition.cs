using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200025A RID: 602
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DefaultShapeDefinition
	{
		// Token: 0x06001881 RID: 6273 RVA: 0x00043D1C File Offset: 0x00041F1C
		public static global::NPOI.OpenXmlFormats.Dml.CT_DefaultShapeDefinition Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_DefaultShapeDefinition ct_DefaultShapeDefinition = new global::NPOI.OpenXmlFormats.Dml.CT_DefaultShapeDefinition();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "spPr")
				{
					ct_DefaultShapeDefinition.spPr = global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bodyPr")
				{
					ct_DefaultShapeDefinition.bodyPr = global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lstStyle")
				{
					ct_DefaultShapeDefinition.lstStyle = global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "style")
				{
					ct_DefaultShapeDefinition.style = global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_DefaultShapeDefinition.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_DefaultShapeDefinition;
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00043E28 File Offset: 0x00042028
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "a:spPr");
			}
			if (this.bodyPr != null)
			{
				this.bodyPr.Write(sw, "bodyPr");
			}
			if (this.lstStyle != null)
			{
				this.lstStyle.Write(sw, "lstStyle");
			}
			if (this.style != null)
			{
				this.style.Write(sw, "style");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x00043EDF File Offset: 0x000420DF
		// (set) Token: 0x06001885 RID: 6277 RVA: 0x00043EE7 File Offset: 0x000420E7
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties spPr
		{
			get
			{
				return this.spPrField;
			}
			set
			{
				this.spPrField = value;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x00043EF0 File Offset: 0x000420F0
		// (set) Token: 0x06001887 RID: 6279 RVA: 0x00043EF8 File Offset: 0x000420F8
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPr
		{
			get
			{
				return this.bodyPrField;
			}
			set
			{
				this.bodyPrField = value;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x00043F01 File Offset: 0x00042101
		// (set) Token: 0x06001889 RID: 6281 RVA: 0x00043F09 File Offset: 0x00042109
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle lstStyle
		{
			get
			{
				return this.lstStyleField;
			}
			set
			{
				this.lstStyleField = value;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x00043F12 File Offset: 0x00042112
		// (set) Token: 0x0600188B RID: 6283 RVA: 0x00043F1A File Offset: 0x0004211A
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle style
		{
			get
			{
				return this.styleField;
			}
			set
			{
				this.styleField = value;
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x00043F23 File Offset: 0x00042123
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x00043F2B File Offset: 0x0004212B
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x040012C1 RID: 4801
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeProperties spPrField;

		// Token: 0x040012C2 RID: 4802
		private global::NPOI.OpenXmlFormats.Dml.CT_TextBodyProperties bodyPrField;

		// Token: 0x040012C3 RID: 4803
		private global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle lstStyleField;

		// Token: 0x040012C4 RID: 4804
		private global::NPOI.OpenXmlFormats.Dml.CT_ShapeStyle styleField;

		// Token: 0x040012C5 RID: 4805
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
