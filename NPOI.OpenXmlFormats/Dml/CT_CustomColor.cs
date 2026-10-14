using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200027C RID: 636
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CustomColor
	{
		// Token: 0x06001A53 RID: 6739 RVA: 0x000475CC File Offset: 0x000457CC
		public static global::NPOI.OpenXmlFormats.Dml.CT_CustomColor Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_CustomColor ct_CustomColor = new global::NPOI.OpenXmlFormats.Dml.CT_CustomColor();
			ct_CustomColor.name = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["name"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "scrgbClr")
				{
					ct_CustomColor.scrgbClr = global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "srgbClr")
				{
					ct_CustomColor.srgbClr = global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hslClr")
				{
					ct_CustomColor.hslClr = global::NPOI.OpenXmlFormats.Dml.CT_HslColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sysClr")
				{
					ct_CustomColor.sysClr = global::NPOI.OpenXmlFormats.Dml.CT_SystemColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "schemeClr")
				{
					ct_CustomColor.schemeClr = global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "prstClr")
				{
					ct_CustomColor.prstClr = global::NPOI.OpenXmlFormats.Dml.CT_PresetColor.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_CustomColor;
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00047718 File Offset: 0x00045918
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "name", this.name);
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

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x000477F9 File Offset: 0x000459F9
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x00047801 File Offset: 0x00045A01
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

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x0004780A File Offset: 0x00045A0A
		// (set) Token: 0x06001A59 RID: 6745 RVA: 0x00047812 File Offset: 0x00045A12
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

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x0004781B File Offset: 0x00045A1B
		// (set) Token: 0x06001A5B RID: 6747 RVA: 0x00047823 File Offset: 0x00045A23
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

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x0004782C File Offset: 0x00045A2C
		// (set) Token: 0x06001A5D RID: 6749 RVA: 0x00047834 File Offset: 0x00045A34
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

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x0004783D File Offset: 0x00045A3D
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x00047845 File Offset: 0x00045A45
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

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x0004784E File Offset: 0x00045A4E
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x00047856 File Offset: 0x00045A56
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

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0004785F File Offset: 0x00045A5F
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x00047867 File Offset: 0x00045A67
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x040013B6 RID: 5046
		private global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClrField;

		// Token: 0x040013B7 RID: 5047
		private global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClrField;

		// Token: 0x040013B8 RID: 5048
		private global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClrField;

		// Token: 0x040013B9 RID: 5049
		private global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClrField;

		// Token: 0x040013BA RID: 5050
		private global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClrField;

		// Token: 0x040013BB RID: 5051
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClrField;

		// Token: 0x040013BC RID: 5052
		private string nameField;
	}
}
