using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000319 RID: 793
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_InnerShadowEffect
	{
		// Token: 0x06001F8B RID: 8075 RVA: 0x0005456C File Offset: 0x0005276C
		public static global::NPOI.OpenXmlFormats.Dml.CT_InnerShadowEffect Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_InnerShadowEffect ct_InnerShadowEffect = new global::NPOI.OpenXmlFormats.Dml.CT_InnerShadowEffect();
			ct_InnerShadowEffect.blurRad = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["blurRad"]);
			ct_InnerShadowEffect.dist = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["dist"]);
			ct_InnerShadowEffect.dir = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["dir"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "scrgbClr")
				{
					ct_InnerShadowEffect.scrgbClr = global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "srgbClr")
				{
					ct_InnerShadowEffect.srgbClr = global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hslClr")
				{
					ct_InnerShadowEffect.hslClr = global::NPOI.OpenXmlFormats.Dml.CT_HslColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sysClr")
				{
					ct_InnerShadowEffect.sysClr = global::NPOI.OpenXmlFormats.Dml.CT_SystemColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "schemeClr")
				{
					ct_InnerShadowEffect.schemeClr = global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "prstClr")
				{
					ct_InnerShadowEffect.prstClr = global::NPOI.OpenXmlFormats.Dml.CT_PresetColor.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_InnerShadowEffect;
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x000546EC File Offset: 0x000528EC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "blurRad", (double)this.blurRad);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dist", (double)this.dist);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dir", this.dir);
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

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06001F8E RID: 8078 RVA: 0x000547F1 File Offset: 0x000529F1
		// (set) Token: 0x06001F8F RID: 8079 RVA: 0x000547F9 File Offset: 0x000529F9
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

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06001F90 RID: 8080 RVA: 0x00054802 File Offset: 0x00052A02
		// (set) Token: 0x06001F91 RID: 8081 RVA: 0x0005480A File Offset: 0x00052A0A
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

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06001F92 RID: 8082 RVA: 0x00054813 File Offset: 0x00052A13
		// (set) Token: 0x06001F93 RID: 8083 RVA: 0x0005481B File Offset: 0x00052A1B
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

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06001F94 RID: 8084 RVA: 0x00054824 File Offset: 0x00052A24
		// (set) Token: 0x06001F95 RID: 8085 RVA: 0x0005482C File Offset: 0x00052A2C
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

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06001F96 RID: 8086 RVA: 0x00054835 File Offset: 0x00052A35
		// (set) Token: 0x06001F97 RID: 8087 RVA: 0x0005483D File Offset: 0x00052A3D
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

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06001F98 RID: 8088 RVA: 0x00054846 File Offset: 0x00052A46
		// (set) Token: 0x06001F99 RID: 8089 RVA: 0x0005484E File Offset: 0x00052A4E
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

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06001F9A RID: 8090 RVA: 0x00054857 File Offset: 0x00052A57
		// (set) Token: 0x06001F9B RID: 8091 RVA: 0x0005485F File Offset: 0x00052A5F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(long), "0")]
		public long blurRad
		{
			get
			{
				return this.blurRadField;
			}
			set
			{
				this.blurRadField = value;
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06001F9C RID: 8092 RVA: 0x00054868 File Offset: 0x00052A68
		// (set) Token: 0x06001F9D RID: 8093 RVA: 0x00054870 File Offset: 0x00052A70
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(long), "0")]
		public long dist
		{
			get
			{
				return this.distField;
			}
			set
			{
				this.distField = value;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06001F9E RID: 8094 RVA: 0x00054879 File Offset: 0x00052A79
		// (set) Token: 0x06001F9F RID: 8095 RVA: 0x00054881 File Offset: 0x00052A81
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int dir
		{
			get
			{
				return this.dirField;
			}
			set
			{
				this.dirField = value;
			}
		}

		// Token: 0x0400188D RID: 6285
		private global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClrField;

		// Token: 0x0400188E RID: 6286
		private global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClrField;

		// Token: 0x0400188F RID: 6287
		private global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClrField;

		// Token: 0x04001890 RID: 6288
		private global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClrField;

		// Token: 0x04001891 RID: 6289
		private global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClrField;

		// Token: 0x04001892 RID: 6290
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClrField;

		// Token: 0x04001893 RID: 6291
		private long blurRadField;

		// Token: 0x04001894 RID: 6292
		private long distField;

		// Token: 0x04001895 RID: 6293
		private int dirField;
	}
}
