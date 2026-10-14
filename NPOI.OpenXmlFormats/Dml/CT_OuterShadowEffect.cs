using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000317 RID: 791
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OuterShadowEffect
	{
		// Token: 0x06001F65 RID: 8037 RVA: 0x0005406C File Offset: 0x0005226C
		public static global::NPOI.OpenXmlFormats.Dml.CT_OuterShadowEffect Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_OuterShadowEffect ct_OuterShadowEffect = new global::NPOI.OpenXmlFormats.Dml.CT_OuterShadowEffect();
			ct_OuterShadowEffect.blurRad = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["blurRad"]);
			ct_OuterShadowEffect.dist = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["dist"]);
			ct_OuterShadowEffect.dir = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["dir"]);
			ct_OuterShadowEffect.sx = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["sx"]);
			ct_OuterShadowEffect.sy = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["sy"]);
			ct_OuterShadowEffect.kx = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["kx"]);
			ct_OuterShadowEffect.ky = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["ky"]);
			if (node.Attributes["algn"] != null)
			{
				ct_OuterShadowEffect.algn = (global::NPOI.OpenXmlFormats.Dml.ST_RectAlignment)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_RectAlignment), node.Attributes["algn"].Value);
			}
			ct_OuterShadowEffect.rotWithShape = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["rotWithShape"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "scrgbClr")
				{
					ct_OuterShadowEffect.scrgbClr = global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "srgbClr")
				{
					ct_OuterShadowEffect.srgbClr = global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hslClr")
				{
					ct_OuterShadowEffect.hslClr = global::NPOI.OpenXmlFormats.Dml.CT_HslColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sysClr")
				{
					ct_OuterShadowEffect.sysClr = global::NPOI.OpenXmlFormats.Dml.CT_SystemColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "schemeClr")
				{
					ct_OuterShadowEffect.schemeClr = global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "prstClr")
				{
					ct_OuterShadowEffect.prstClr = global::NPOI.OpenXmlFormats.Dml.CT_PresetColor.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_OuterShadowEffect;
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x000542B4 File Offset: 0x000524B4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "blurRad", (double)this.blurRad);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dist", (double)this.dist);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dir", this.dir);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sx", this.sx);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sy", this.sy);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "kx", this.kx);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ky", this.ky);
			if (this.algn != global::NPOI.OpenXmlFormats.Dml.ST_RectAlignment.tl)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "algn", this.algn.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rotWithShape", this.rotWithShape);
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

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x00054435 File Offset: 0x00052635
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x0005443D File Offset: 0x0005263D
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

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x00054446 File Offset: 0x00052646
		// (set) Token: 0x06001F6B RID: 8043 RVA: 0x0005444E File Offset: 0x0005264E
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

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x00054457 File Offset: 0x00052657
		// (set) Token: 0x06001F6D RID: 8045 RVA: 0x0005445F File Offset: 0x0005265F
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

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x00054468 File Offset: 0x00052668
		// (set) Token: 0x06001F6F RID: 8047 RVA: 0x00054470 File Offset: 0x00052670
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

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06001F70 RID: 8048 RVA: 0x00054479 File Offset: 0x00052679
		// (set) Token: 0x06001F71 RID: 8049 RVA: 0x00054481 File Offset: 0x00052681
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

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06001F72 RID: 8050 RVA: 0x0005448A File Offset: 0x0005268A
		// (set) Token: 0x06001F73 RID: 8051 RVA: 0x00054492 File Offset: 0x00052692
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

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x0005449B File Offset: 0x0005269B
		// (set) Token: 0x06001F75 RID: 8053 RVA: 0x000544A3 File Offset: 0x000526A3
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

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06001F76 RID: 8054 RVA: 0x000544AC File Offset: 0x000526AC
		// (set) Token: 0x06001F77 RID: 8055 RVA: 0x000544B4 File Offset: 0x000526B4
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

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06001F78 RID: 8056 RVA: 0x000544BD File Offset: 0x000526BD
		// (set) Token: 0x06001F79 RID: 8057 RVA: 0x000544C5 File Offset: 0x000526C5
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

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x000544CE File Offset: 0x000526CE
		// (set) Token: 0x06001F7B RID: 8059 RVA: 0x000544D6 File Offset: 0x000526D6
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(100000)]
		public int sx
		{
			get
			{
				return this.sxField;
			}
			set
			{
				this.sxField = value;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x000544DF File Offset: 0x000526DF
		// (set) Token: 0x06001F7D RID: 8061 RVA: 0x000544E7 File Offset: 0x000526E7
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(100000)]
		public int sy
		{
			get
			{
				return this.syField;
			}
			set
			{
				this.syField = value;
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x000544F0 File Offset: 0x000526F0
		// (set) Token: 0x06001F7F RID: 8063 RVA: 0x000544F8 File Offset: 0x000526F8
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int kx
		{
			get
			{
				return this.kxField;
			}
			set
			{
				this.kxField = value;
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06001F80 RID: 8064 RVA: 0x00054501 File Offset: 0x00052701
		// (set) Token: 0x06001F81 RID: 8065 RVA: 0x00054509 File Offset: 0x00052709
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int ky
		{
			get
			{
				return this.kyField;
			}
			set
			{
				this.kyField = value;
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06001F82 RID: 8066 RVA: 0x00054512 File Offset: 0x00052712
		// (set) Token: 0x06001F83 RID: 8067 RVA: 0x0005451A File Offset: 0x0005271A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.ST_RectAlignment.b)]
		public global::NPOI.OpenXmlFormats.Dml.ST_RectAlignment algn
		{
			get
			{
				return this.algnField;
			}
			set
			{
				this.algnField = value;
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06001F84 RID: 8068 RVA: 0x00054523 File Offset: 0x00052723
		// (set) Token: 0x06001F85 RID: 8069 RVA: 0x0005452B File Offset: 0x0005272B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool rotWithShape
		{
			get
			{
				return this.rotWithShapeField;
			}
			set
			{
				this.rotWithShapeField = value;
			}
		}

		// Token: 0x0400187C RID: 6268
		private global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClrField;

		// Token: 0x0400187D RID: 6269
		private global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClrField;

		// Token: 0x0400187E RID: 6270
		private global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClrField;

		// Token: 0x0400187F RID: 6271
		private global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClrField;

		// Token: 0x04001880 RID: 6272
		private global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClrField;

		// Token: 0x04001881 RID: 6273
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClrField;

		// Token: 0x04001882 RID: 6274
		private long blurRadField;

		// Token: 0x04001883 RID: 6275
		private long distField;

		// Token: 0x04001884 RID: 6276
		private int dirField;

		// Token: 0x04001885 RID: 6277
		private int sxField;

		// Token: 0x04001886 RID: 6278
		private int syField;

		// Token: 0x04001887 RID: 6279
		private int kxField;

		// Token: 0x04001888 RID: 6280
		private int kyField;

		// Token: 0x04001889 RID: 6281
		private global::NPOI.OpenXmlFormats.Dml.ST_RectAlignment algnField;

		// Token: 0x0400188A RID: 6282
		private bool rotWithShapeField;
	}
}
