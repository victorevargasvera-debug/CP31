using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002C6 RID: 710
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Color
	{
		// Token: 0x06001C32 RID: 7218 RVA: 0x0004D7E4 File Offset: 0x0004B9E4
		public static global::NPOI.OpenXmlFormats.Dml.CT_Color Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_Color ct_Color = new global::NPOI.OpenXmlFormats.Dml.CT_Color();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "scrgbClr")
				{
					ct_Color.scrgbClr = global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "srgbClr")
				{
					ct_Color.srgbClr = global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hslClr")
				{
					ct_Color.hslClr = global::NPOI.OpenXmlFormats.Dml.CT_HslColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sysClr")
				{
					ct_Color.sysClr = global::NPOI.OpenXmlFormats.Dml.CT_SystemColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "schemeClr")
				{
					ct_Color.schemeClr = global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "prstClr")
				{
					ct_Color.prstClr = global::NPOI.OpenXmlFormats.Dml.CT_PresetColor.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Color;
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x0004D914 File Offset: 0x0004BB14
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			sw.Write(">");
			if (this.scrgbClr != null)
			{
				this.scrgbClr.Write(sw, "scrgbClr");
			}
			if (this.srgbClr != null)
			{
				this.srgbClr.Write(sw, "srgbClr");
			}
			if (this.hslClr != null)
			{
				this.hslClr.Write(sw, "hslClr");
			}
			if (this.sysClr != null)
			{
				this.sysClr.Write(sw, "sysClr");
			}
			if (this.schemeClr != null)
			{
				this.schemeClr.Write(sw, "schemeClr");
			}
			if (this.prstClr != null)
			{
				this.prstClr.Write(sw, "prstClr");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x0004D9E4 File Offset: 0x0004BBE4
		// (set) Token: 0x06001C36 RID: 7222 RVA: 0x0004D9EC File Offset: 0x0004BBEC
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClr
		{
			get
			{
				return this.scrgbClrField;
			}
			set
			{
				this.scrgbClrField = value;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x0004D9F5 File Offset: 0x0004BBF5
		// (set) Token: 0x06001C38 RID: 7224 RVA: 0x0004D9FD File Offset: 0x0004BBFD
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClr
		{
			get
			{
				return this.srgbClrField;
			}
			set
			{
				this.srgbClrField = value;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x0004DA06 File Offset: 0x0004BC06
		// (set) Token: 0x06001C3A RID: 7226 RVA: 0x0004DA0E File Offset: 0x0004BC0E
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClr
		{
			get
			{
				return this.hslClrField;
			}
			set
			{
				this.hslClrField = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x0004DA17 File Offset: 0x0004BC17
		// (set) Token: 0x06001C3C RID: 7228 RVA: 0x0004DA1F File Offset: 0x0004BC1F
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClr
		{
			get
			{
				return this.sysClrField;
			}
			set
			{
				this.sysClrField = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x0004DA28 File Offset: 0x0004BC28
		// (set) Token: 0x06001C3E RID: 7230 RVA: 0x0004DA30 File Offset: 0x0004BC30
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClr
		{
			get
			{
				return this.schemeClrField;
			}
			set
			{
				this.schemeClrField = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x0004DA39 File Offset: 0x0004BC39
		// (set) Token: 0x06001C40 RID: 7232 RVA: 0x0004DA41 File Offset: 0x0004BC41
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClr
		{
			get
			{
				return this.prstClrField;
			}
			set
			{
				this.prstClrField = value;
			}
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x0004DA4A File Offset: 0x0004BC4A
		public bool IsSetSrgbClr()
		{
			return this.srgbClrField != null;
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x0004DA55 File Offset: 0x0004BC55
		public bool IsSetSysClr()
		{
			return this.sysClrField != null;
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x0004DA60 File Offset: 0x0004BC60
		public global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor AddNewSrgbClr()
		{
			this.srgbClrField = new global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor();
			return this.srgbClrField;
		}

		// Token: 0x040015FB RID: 5627
		private global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClrField;

		// Token: 0x040015FC RID: 5628
		private global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClrField;

		// Token: 0x040015FD RID: 5629
		private global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClrField;

		// Token: 0x040015FE RID: 5630
		private global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClrField;

		// Token: 0x040015FF RID: 5631
		private global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClrField;

		// Token: 0x04001600 RID: 5632
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClrField;
	}
}
