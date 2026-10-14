using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000315 RID: 789
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PresetShadowEffect
	{
		// Token: 0x06001F50 RID: 8016 RVA: 0x00053D18 File Offset: 0x00051F18
		public static global::NPOI.OpenXmlFormats.Dml.CT_PresetShadowEffect Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_PresetShadowEffect ct_PresetShadowEffect = new global::NPOI.OpenXmlFormats.Dml.CT_PresetShadowEffect();
			if (node.Attributes["prst"] != null)
			{
				ct_PresetShadowEffect.prst = (global::NPOI.OpenXmlFormats.Dml.ST_PresetShadowVal)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_PresetShadowVal), node.Attributes["prst"].Value);
			}
			ct_PresetShadowEffect.dist = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["dist"]);
			ct_PresetShadowEffect.dir = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["dir"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "scrgbClr")
				{
					ct_PresetShadowEffect.scrgbClr = global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "srgbClr")
				{
					ct_PresetShadowEffect.srgbClr = global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hslClr")
				{
					ct_PresetShadowEffect.hslClr = global::NPOI.OpenXmlFormats.Dml.CT_HslColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sysClr")
				{
					ct_PresetShadowEffect.sysClr = global::NPOI.OpenXmlFormats.Dml.CT_SystemColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "schemeClr")
				{
					ct_PresetShadowEffect.schemeClr = global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "prstClr")
				{
					ct_PresetShadowEffect.prstClr = global::NPOI.OpenXmlFormats.Dml.CT_PresetColor.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_PresetShadowEffect;
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x00053EC0 File Offset: 0x000520C0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "prst", this.prst.ToString());
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

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x00053FD2 File Offset: 0x000521D2
		// (set) Token: 0x06001F54 RID: 8020 RVA: 0x00053FDA File Offset: 0x000521DA
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

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x00053FE3 File Offset: 0x000521E3
		// (set) Token: 0x06001F56 RID: 8022 RVA: 0x00053FEB File Offset: 0x000521EB
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

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x00053FF4 File Offset: 0x000521F4
		// (set) Token: 0x06001F58 RID: 8024 RVA: 0x00053FFC File Offset: 0x000521FC
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

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x00054005 File Offset: 0x00052205
		// (set) Token: 0x06001F5A RID: 8026 RVA: 0x0005400D File Offset: 0x0005220D
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

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x00054016 File Offset: 0x00052216
		// (set) Token: 0x06001F5C RID: 8028 RVA: 0x0005401E File Offset: 0x0005221E
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

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06001F5D RID: 8029 RVA: 0x00054027 File Offset: 0x00052227
		// (set) Token: 0x06001F5E RID: 8030 RVA: 0x0005402F File Offset: 0x0005222F
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

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x00054038 File Offset: 0x00052238
		// (set) Token: 0x06001F60 RID: 8032 RVA: 0x00054040 File Offset: 0x00052240
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_PresetShadowVal prst
		{
			get
			{
				return this.prstField;
			}
			set
			{
				this.prstField = value;
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x00054049 File Offset: 0x00052249
		// (set) Token: 0x06001F62 RID: 8034 RVA: 0x00054051 File Offset: 0x00052251
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

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06001F63 RID: 8035 RVA: 0x0005405A File Offset: 0x0005225A
		// (set) Token: 0x06001F64 RID: 8036 RVA: 0x00054062 File Offset: 0x00052262
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

		// Token: 0x0400185E RID: 6238
		private global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClrField;

		// Token: 0x0400185F RID: 6239
		private global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClrField;

		// Token: 0x04001860 RID: 6240
		private global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClrField;

		// Token: 0x04001861 RID: 6241
		private global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClrField;

		// Token: 0x04001862 RID: 6242
		private global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClrField;

		// Token: 0x04001863 RID: 6243
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClrField;

		// Token: 0x04001864 RID: 6244
		private global::NPOI.OpenXmlFormats.Dml.ST_PresetShadowVal prstField;

		// Token: 0x04001865 RID: 6245
		private long distField;

		// Token: 0x04001866 RID: 6246
		private int dirField;
	}
}
