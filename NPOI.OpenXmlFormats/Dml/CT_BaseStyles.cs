using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000287 RID: 647
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BaseStyles
	{
		// Token: 0x06001AC6 RID: 6854 RVA: 0x00048BCC File Offset: 0x00046DCC
		public static global::NPOI.OpenXmlFormats.Dml.CT_BaseStyles Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_BaseStyles ct_BaseStyles = new global::NPOI.OpenXmlFormats.Dml.CT_BaseStyles();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "clrScheme")
				{
					ct_BaseStyles.clrScheme = global::NPOI.OpenXmlFormats.Dml.CT_ColorScheme.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fontScheme")
				{
					ct_BaseStyles.fontScheme = global::NPOI.OpenXmlFormats.Dml.CT_FontScheme.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fmtScheme")
				{
					ct_BaseStyles.fmtScheme = global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrix.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_BaseStyles.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_BaseStyles;
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x00048CB4 File Offset: 0x00046EB4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.clrScheme != null)
			{
				this.clrScheme.Write(sw, "clrScheme");
			}
			if (this.fontScheme != null)
			{
				this.fontScheme.Write(sw, "fontScheme");
			}
			if (this.fmtScheme != null)
			{
				this.fmtScheme.Write(sw, "fmtScheme");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x00048D52 File Offset: 0x00046F52
		// (set) Token: 0x06001ACA RID: 6858 RVA: 0x00048D5A File Offset: 0x00046F5A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ColorScheme clrScheme
		{
			get
			{
				return this.clrSchemeField;
			}
			set
			{
				this.clrSchemeField = value;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x00048D63 File Offset: 0x00046F63
		// (set) Token: 0x06001ACC RID: 6860 RVA: 0x00048D6B File Offset: 0x00046F6B
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_FontScheme fontScheme
		{
			get
			{
				return this.fontSchemeField;
			}
			set
			{
				this.fontSchemeField = value;
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x00048D74 File Offset: 0x00046F74
		// (set) Token: 0x06001ACE RID: 6862 RVA: 0x00048D7C File Offset: 0x00046F7C
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrix fmtScheme
		{
			get
			{
				return this.fmtSchemeField;
			}
			set
			{
				this.fmtSchemeField = value;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x00048D85 File Offset: 0x00046F85
		// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x00048D8D File Offset: 0x00046F8D
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x040013E0 RID: 5088
		private global::NPOI.OpenXmlFormats.Dml.CT_ColorScheme clrSchemeField;

		// Token: 0x040013E1 RID: 5089
		private global::NPOI.OpenXmlFormats.Dml.CT_FontScheme fontSchemeField;

		// Token: 0x040013E2 RID: 5090
		private global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrix fmtSchemeField;

		// Token: 0x040013E3 RID: 5091
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
