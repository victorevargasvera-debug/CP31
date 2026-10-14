using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000308 RID: 776
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextListStyle
	{
		// Token: 0x06001E5D RID: 7773 RVA: 0x0005211C File Offset: 0x0005031C
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle ct_TextListStyle = new global::NPOI.OpenXmlFormats.Dml.CT_TextListStyle();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "defPPr")
				{
					ct_TextListStyle.defPPr = global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvl1pPr")
				{
					ct_TextListStyle.lvl1pPr = global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvl2pPr")
				{
					ct_TextListStyle.lvl2pPr = global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvl3pPr")
				{
					ct_TextListStyle.lvl3pPr = global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvl4pPr")
				{
					ct_TextListStyle.lvl4pPr = global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvl5pPr")
				{
					ct_TextListStyle.lvl5pPr = global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvl6pPr")
				{
					ct_TextListStyle.lvl6pPr = global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvl7pPr")
				{
					ct_TextListStyle.lvl7pPr = global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvl8pPr")
				{
					ct_TextListStyle.lvl8pPr = global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lvl9pPr")
				{
					ct_TextListStyle.lvl9pPr = global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_TextListStyle.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TextListStyle;
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x0005230C File Offset: 0x0005050C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.defPPr != null)
			{
				this.defPPr.Write(sw, "defPPr");
			}
			if (this.lvl1pPr != null)
			{
				this.lvl1pPr.Write(sw, "lvl1pPr");
			}
			if (this.lvl2pPr != null)
			{
				this.lvl2pPr.Write(sw, "lvl2pPr");
			}
			if (this.lvl3pPr != null)
			{
				this.lvl3pPr.Write(sw, "lvl3pPr");
			}
			if (this.lvl4pPr != null)
			{
				this.lvl4pPr.Write(sw, "lvl4pPr");
			}
			if (this.lvl5pPr != null)
			{
				this.lvl5pPr.Write(sw, "lvl5pPr");
			}
			if (this.lvl6pPr != null)
			{
				this.lvl6pPr.Write(sw, "lvl6pPr");
			}
			if (this.lvl7pPr != null)
			{
				this.lvl7pPr.Write(sw, "lvl7pPr");
			}
			if (this.lvl8pPr != null)
			{
				this.lvl8pPr.Write(sw, "lvl8pPr");
			}
			if (this.lvl9pPr != null)
			{
				this.lvl9pPr.Write(sw, "lvl9pPr");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06001E5F RID: 7775 RVA: 0x00052459 File Offset: 0x00050659
		// (set) Token: 0x06001E60 RID: 7776 RVA: 0x00052461 File Offset: 0x00050661
		public global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties defPPr
		{
			get
			{
				return this.defPPrField;
			}
			set
			{
				this.defPPrField = value;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x0005246A File Offset: 0x0005066A
		// (set) Token: 0x06001E62 RID: 7778 RVA: 0x00052472 File Offset: 0x00050672
		public global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl1pPr
		{
			get
			{
				return this.lvl1pPrField;
			}
			set
			{
				this.lvl1pPrField = value;
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06001E63 RID: 7779 RVA: 0x0005247B File Offset: 0x0005067B
		// (set) Token: 0x06001E64 RID: 7780 RVA: 0x00052483 File Offset: 0x00050683
		public global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl2pPr
		{
			get
			{
				return this.lvl2pPrField;
			}
			set
			{
				this.lvl2pPrField = value;
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x0005248C File Offset: 0x0005068C
		// (set) Token: 0x06001E66 RID: 7782 RVA: 0x00052494 File Offset: 0x00050694
		public global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl3pPr
		{
			get
			{
				return this.lvl3pPrField;
			}
			set
			{
				this.lvl3pPrField = value;
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x0005249D File Offset: 0x0005069D
		// (set) Token: 0x06001E68 RID: 7784 RVA: 0x000524A5 File Offset: 0x000506A5
		public global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl4pPr
		{
			get
			{
				return this.lvl4pPrField;
			}
			set
			{
				this.lvl4pPrField = value;
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x000524AE File Offset: 0x000506AE
		// (set) Token: 0x06001E6A RID: 7786 RVA: 0x000524B6 File Offset: 0x000506B6
		public global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl5pPr
		{
			get
			{
				return this.lvl5pPrField;
			}
			set
			{
				this.lvl5pPrField = value;
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06001E6B RID: 7787 RVA: 0x000524BF File Offset: 0x000506BF
		// (set) Token: 0x06001E6C RID: 7788 RVA: 0x000524C7 File Offset: 0x000506C7
		public global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl6pPr
		{
			get
			{
				return this.lvl6pPrField;
			}
			set
			{
				this.lvl6pPrField = value;
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06001E6D RID: 7789 RVA: 0x000524D0 File Offset: 0x000506D0
		// (set) Token: 0x06001E6E RID: 7790 RVA: 0x000524D8 File Offset: 0x000506D8
		public global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl7pPr
		{
			get
			{
				return this.lvl7pPrField;
			}
			set
			{
				this.lvl7pPrField = value;
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06001E6F RID: 7791 RVA: 0x000524E1 File Offset: 0x000506E1
		// (set) Token: 0x06001E70 RID: 7792 RVA: 0x000524E9 File Offset: 0x000506E9
		public global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl8pPr
		{
			get
			{
				return this.lvl8pPrField;
			}
			set
			{
				this.lvl8pPrField = value;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x000524F2 File Offset: 0x000506F2
		// (set) Token: 0x06001E72 RID: 7794 RVA: 0x000524FA File Offset: 0x000506FA
		public global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl9pPr
		{
			get
			{
				return this.lvl9pPrField;
			}
			set
			{
				this.lvl9pPrField = value;
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x00052503 File Offset: 0x00050703
		// (set) Token: 0x06001E74 RID: 7796 RVA: 0x0005250B File Offset: 0x0005070B
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

		// Token: 0x04001802 RID: 6146
		private global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties defPPrField;

		// Token: 0x04001803 RID: 6147
		private global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl1pPrField;

		// Token: 0x04001804 RID: 6148
		private global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl2pPrField;

		// Token: 0x04001805 RID: 6149
		private global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl3pPrField;

		// Token: 0x04001806 RID: 6150
		private global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl4pPrField;

		// Token: 0x04001807 RID: 6151
		private global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl5pPrField;

		// Token: 0x04001808 RID: 6152
		private global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl6pPrField;

		// Token: 0x04001809 RID: 6153
		private global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl7pPrField;

		// Token: 0x0400180A RID: 6154
		private global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl8pPrField;

		// Token: 0x0400180B RID: 6155
		private global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties lvl9pPrField;

		// Token: 0x0400180C RID: 6156
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
