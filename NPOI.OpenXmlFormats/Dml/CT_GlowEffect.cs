using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200031C RID: 796
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GlowEffect
	{
		// Token: 0x06001FA8 RID: 8104 RVA: 0x000548DC File Offset: 0x00052ADC
		public static global::NPOI.OpenXmlFormats.Dml.CT_GlowEffect Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_GlowEffect ct_GlowEffect = new global::NPOI.OpenXmlFormats.Dml.CT_GlowEffect();
			ct_GlowEffect.rad = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["rad"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "scrgbClr")
				{
					ct_GlowEffect.scrgbClr = global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "srgbClr")
				{
					ct_GlowEffect.srgbClr = global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hslClr")
				{
					ct_GlowEffect.hslClr = global::NPOI.OpenXmlFormats.Dml.CT_HslColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sysClr")
				{
					ct_GlowEffect.sysClr = global::NPOI.OpenXmlFormats.Dml.CT_SystemColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "schemeClr")
				{
					ct_GlowEffect.schemeClr = global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "prstClr")
				{
					ct_GlowEffect.prstClr = global::NPOI.OpenXmlFormats.Dml.CT_PresetColor.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_GlowEffect;
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x00054A28 File Offset: 0x00052C28
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rad", (double)this.rad);
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

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x00054B0A File Offset: 0x00052D0A
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x00054B12 File Offset: 0x00052D12
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

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x00054B1B File Offset: 0x00052D1B
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x00054B23 File Offset: 0x00052D23
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

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x00054B2C File Offset: 0x00052D2C
		// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x00054B34 File Offset: 0x00052D34
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

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x00054B3D File Offset: 0x00052D3D
		// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x00054B45 File Offset: 0x00052D45
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

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x00054B4E File Offset: 0x00052D4E
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x00054B56 File Offset: 0x00052D56
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

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x00054B5F File Offset: 0x00052D5F
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x00054B67 File Offset: 0x00052D67
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

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x00054B70 File Offset: 0x00052D70
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x00054B78 File Offset: 0x00052D78
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(long), "0")]
		public long rad
		{
			get
			{
				return this.radField;
			}
			set
			{
				this.radField = value;
			}
		}

		// Token: 0x04001899 RID: 6297
		private global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClrField;

		// Token: 0x0400189A RID: 6298
		private global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClrField;

		// Token: 0x0400189B RID: 6299
		private global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClrField;

		// Token: 0x0400189C RID: 6300
		private global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClrField;

		// Token: 0x0400189D RID: 6301
		private global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClrField;

		// Token: 0x0400189E RID: 6302
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClrField;

		// Token: 0x0400189F RID: 6303
		private long radField;
	}
}
