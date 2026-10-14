using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000061 RID: 97
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CustomXmlPr
	{
		// Token: 0x060002F9 RID: 761 RVA: 0x000069DC File Offset: 0x00004BDC
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlPr ct_CustomXmlPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_CustomXmlPr();
			ct_CustomXmlPr.attr = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Attr>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "placeholder")
				{
					ct_CustomXmlPr.placeholder = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "attr")
				{
					ct_CustomXmlPr.attr.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Attr.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CustomXmlPr;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00006A8C File Offset: 0x00004C8C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.placeholder != null)
			{
				this.placeholder.Write(sw, "placeholder");
			}
			if (this.attr != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Attr ct_Attr in this.attr)
				{
					ct_Attr.Write(sw, "attr");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00006B30 File Offset: 0x00004D30
		// (set) Token: 0x060002FC RID: 764 RVA: 0x00006B38 File Offset: 0x00004D38
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String placeholder
		{
			get
			{
				return this.placeholderField;
			}
			set
			{
				this.placeholderField = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00006B41 File Offset: 0x00004D41
		// (set) Token: 0x060002FE RID: 766 RVA: 0x00006B49 File Offset: 0x00004D49
		[global::System.Xml.Serialization.XmlElement("attr", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Attr> attr
		{
			get
			{
				return this.attrField;
			}
			set
			{
				this.attrField = value;
			}
		}

		// Token: 0x040001EE RID: 494
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String placeholderField;

		// Token: 0x040001EF RID: 495
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Attr> attrField;
	}
}
