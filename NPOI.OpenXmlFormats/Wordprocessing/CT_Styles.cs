using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000145 RID: 325
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("styles", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Styles
	{
		// Token: 0x060008CC RID: 2252 RVA: 0x0001F834 File Offset: 0x0001DA34
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles ct_Styles = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles();
			ct_Styles.style = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "docDefaults")
				{
					ct_Styles.docDefaults = global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocDefaults.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "latentStyles")
				{
					ct_Styles.latentStyles = global::NPOI.OpenXmlFormats.Wordprocessing.CT_LatentStyles.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "style")
				{
					ct_Styles.style.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Styles;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0001F904 File Offset: 0x0001DB04
		internal void Write(global::System.IO.StreamWriter sw)
		{
			sw.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
			sw.Write("<w:styles xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\">");
			if (this.docDefaults != null)
			{
				this.docDefaults.Write(sw, "docDefaults");
			}
			if (this.latentStyles != null)
			{
				this.latentStyles.Write(sw, "latentStyles");
			}
			if (this.style != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style ct_Style in this.style)
				{
					ct_Style.Write(sw, "style");
				}
			}
			sw.Write("</w:styles>");
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0001F9B8 File Offset: 0x0001DBB8
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x0001F9C0 File Offset: 0x0001DBC0
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocDefaults docDefaults
		{
			get
			{
				return this.docDefaultsField;
			}
			set
			{
				this.docDefaultsField = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x0001F9C9 File Offset: 0x0001DBC9
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x0001F9D1 File Offset: 0x0001DBD1
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_LatentStyles latentStyles
		{
			get
			{
				return this.latentStylesField;
			}
			set
			{
				this.latentStylesField = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x0001F9DA File Offset: 0x0001DBDA
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x0001F9E2 File Offset: 0x0001DBE2
		[global::System.Xml.Serialization.XmlElement("style", Order = 2)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style> style
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

		// Token: 0x060008D4 RID: 2260 RVA: 0x0001F9EB File Offset: 0x0001DBEB
		public global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style> GetStyleList()
		{
			if (this.styleField == null)
			{
				this.styleField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style>();
			}
			return this.style;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0001FA08 File Offset: 0x0001DC08
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style AddNewStyle()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style ct_Style = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style();
			if (this.styleField == null)
			{
				this.styleField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style>();
			}
			this.styleField.Add(ct_Style);
			return ct_Style;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0001FA3C File Offset: 0x0001DC3C
		public void SetStyleArray(int pos, global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style cT_Style)
		{
			lock (this)
			{
				this.styleField[pos] = cT_Style;
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0001FA80 File Offset: 0x0001DC80
		public bool IsSetDocDefaults()
		{
			return this.docDefaultsField != null;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0001FA8B File Offset: 0x0001DC8B
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocDefaults AddNewDocDefaults()
		{
			this.docDefaultsField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocDefaults();
			return this.docDefaultsField;
		}

		// Token: 0x04000822 RID: 2082
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocDefaults docDefaultsField;

		// Token: 0x04000823 RID: 2083
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_LatentStyles latentStylesField;

		// Token: 0x04000824 RID: 2084
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Style> styleField;
	}
}
