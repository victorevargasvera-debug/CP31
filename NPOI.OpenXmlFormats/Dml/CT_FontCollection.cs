using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200027F RID: 639
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FontCollection
	{
		// Token: 0x06001A6E RID: 6766 RVA: 0x00047954 File Offset: 0x00045B54
		public static global::NPOI.OpenXmlFormats.Dml.CT_FontCollection Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_FontCollection ct_FontCollection = new global::NPOI.OpenXmlFormats.Dml.CT_FontCollection();
			ct_FontCollection.font = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_SupplementalFont>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "latin")
				{
					ct_FontCollection.latin = global::NPOI.OpenXmlFormats.Dml.CT_TextFont.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ea")
				{
					ct_FontCollection.ea = global::NPOI.OpenXmlFormats.Dml.CT_TextFont.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cs")
				{
					ct_FontCollection.cs = global::NPOI.OpenXmlFormats.Dml.CT_TextFont.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_FontCollection.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "font")
				{
					ct_FontCollection.font.Add(global::NPOI.OpenXmlFormats.Dml.CT_SupplementalFont.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_FontCollection;
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00047A70 File Offset: 0x00045C70
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.latin != null)
			{
				this.latin.Write(sw, "latin");
			}
			if (this.ea != null)
			{
				this.ea.Write(sw, "ea");
			}
			if (this.cs != null)
			{
				this.cs.Write(sw, "cs");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			if (this.font != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.CT_SupplementalFont ct_SupplementalFont in this.font)
				{
					ct_SupplementalFont.Write(sw, "font");
				}
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001A71 RID: 6769 RVA: 0x00047B60 File Offset: 0x00045D60
		// (set) Token: 0x06001A72 RID: 6770 RVA: 0x00047B68 File Offset: 0x00045D68
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextFont latin
		{
			get
			{
				return this.latinField;
			}
			set
			{
				this.latinField = value;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001A73 RID: 6771 RVA: 0x00047B71 File Offset: 0x00045D71
		// (set) Token: 0x06001A74 RID: 6772 RVA: 0x00047B79 File Offset: 0x00045D79
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextFont ea
		{
			get
			{
				return this.eaField;
			}
			set
			{
				this.eaField = value;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06001A75 RID: 6773 RVA: 0x00047B82 File Offset: 0x00045D82
		// (set) Token: 0x06001A76 RID: 6774 RVA: 0x00047B8A File Offset: 0x00045D8A
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextFont cs
		{
			get
			{
				return this.csField;
			}
			set
			{
				this.csField = value;
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06001A77 RID: 6775 RVA: 0x00047B93 File Offset: 0x00045D93
		// (set) Token: 0x06001A78 RID: 6776 RVA: 0x00047B9B File Offset: 0x00045D9B
		[global::System.Xml.Serialization.XmlElement("font", Order = 3)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_SupplementalFont> font
		{
			get
			{
				return this.fontField;
			}
			set
			{
				this.fontField = value;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06001A79 RID: 6777 RVA: 0x00047BA4 File Offset: 0x00045DA4
		// (set) Token: 0x06001A7A RID: 6778 RVA: 0x00047BAC File Offset: 0x00045DAC
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

		// Token: 0x040013C0 RID: 5056
		private global::NPOI.OpenXmlFormats.Dml.CT_TextFont latinField;

		// Token: 0x040013C1 RID: 5057
		private global::NPOI.OpenXmlFormats.Dml.CT_TextFont eaField;

		// Token: 0x040013C2 RID: 5058
		private global::NPOI.OpenXmlFormats.Dml.CT_TextFont csField;

		// Token: 0x040013C3 RID: 5059
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_SupplementalFont> fontField;

		// Token: 0x040013C4 RID: 5060
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
