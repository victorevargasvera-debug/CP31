using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000327 RID: 807
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TileInfoProperties
	{
		// Token: 0x06002034 RID: 8244 RVA: 0x00055B50 File Offset: 0x00053D50
		public static global::NPOI.OpenXmlFormats.Dml.CT_TileInfoProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TileInfoProperties ct_TileInfoProperties = new global::NPOI.OpenXmlFormats.Dml.CT_TileInfoProperties();
			ct_TileInfoProperties.tx = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["tx"]);
			ct_TileInfoProperties.ty = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["ty"]);
			ct_TileInfoProperties.sx = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["sx"]);
			ct_TileInfoProperties.sy = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["sy"]);
			if (node.Attributes["flip"] != null)
			{
				ct_TileInfoProperties.flip = (global::NPOI.OpenXmlFormats.Dml.ST_TileFlipMode)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_TileFlipMode), node.Attributes["flip"].Value);
			}
			if (node.Attributes["algn"] != null)
			{
				ct_TileInfoProperties.algn = (global::NPOI.OpenXmlFormats.Dml.ST_RectAlignment)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_RectAlignment), node.Attributes["algn"].Value);
			}
			return ct_TileInfoProperties;
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x00055C58 File Offset: 0x00053E58
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "tx", (double)this.tx);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ty", (double)this.ty);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sx", this.sx);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sy", this.sy);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "flip", this.flip.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "algn", this.algn.ToString());
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x00055D16 File Offset: 0x00053F16
		// (set) Token: 0x06002037 RID: 8247 RVA: 0x00055D1E File Offset: 0x00053F1E
		[global::System.Xml.Serialization.XmlAttribute]
		public long tx
		{
			get
			{
				return this.txField;
			}
			set
			{
				this.txField = value;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x00055D27 File Offset: 0x00053F27
		// (set) Token: 0x06002039 RID: 8249 RVA: 0x00055D2F File Offset: 0x00053F2F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool txSpecified
		{
			get
			{
				return this.txFieldSpecified;
			}
			set
			{
				this.txFieldSpecified = value;
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x0600203A RID: 8250 RVA: 0x00055D38 File Offset: 0x00053F38
		// (set) Token: 0x0600203B RID: 8251 RVA: 0x00055D40 File Offset: 0x00053F40
		[global::System.Xml.Serialization.XmlAttribute]
		public long ty
		{
			get
			{
				return this.tyField;
			}
			set
			{
				this.tyField = value;
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x00055D49 File Offset: 0x00053F49
		// (set) Token: 0x0600203D RID: 8253 RVA: 0x00055D51 File Offset: 0x00053F51
		[global::System.Xml.Serialization.XmlIgnore]
		public bool tySpecified
		{
			get
			{
				return this.tyFieldSpecified;
			}
			set
			{
				this.tyFieldSpecified = value;
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x0600203E RID: 8254 RVA: 0x00055D5A File Offset: 0x00053F5A
		// (set) Token: 0x0600203F RID: 8255 RVA: 0x00055D62 File Offset: 0x00053F62
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06002040 RID: 8256 RVA: 0x00055D6B File Offset: 0x00053F6B
		// (set) Token: 0x06002041 RID: 8257 RVA: 0x00055D73 File Offset: 0x00053F73
		[global::System.Xml.Serialization.XmlIgnore]
		public bool sxSpecified
		{
			get
			{
				return this.sxFieldSpecified;
			}
			set
			{
				this.sxFieldSpecified = value;
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06002042 RID: 8258 RVA: 0x00055D7C File Offset: 0x00053F7C
		// (set) Token: 0x06002043 RID: 8259 RVA: 0x00055D84 File Offset: 0x00053F84
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06002044 RID: 8260 RVA: 0x00055D8D File Offset: 0x00053F8D
		// (set) Token: 0x06002045 RID: 8261 RVA: 0x00055D95 File Offset: 0x00053F95
		[global::System.Xml.Serialization.XmlIgnore]
		public bool sySpecified
		{
			get
			{
				return this.syFieldSpecified;
			}
			set
			{
				this.syFieldSpecified = value;
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06002046 RID: 8262 RVA: 0x00055D9E File Offset: 0x00053F9E
		// (set) Token: 0x06002047 RID: 8263 RVA: 0x00055DA6 File Offset: 0x00053FA6
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_TileFlipMode flip
		{
			get
			{
				return this.flipField;
			}
			set
			{
				this.flipField = value;
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x00055DAF File Offset: 0x00053FAF
		// (set) Token: 0x06002049 RID: 8265 RVA: 0x00055DB7 File Offset: 0x00053FB7
		[global::System.Xml.Serialization.XmlIgnore]
		public bool flipSpecified
		{
			get
			{
				return this.flipFieldSpecified;
			}
			set
			{
				this.flipFieldSpecified = value;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x0600204A RID: 8266 RVA: 0x00055DC0 File Offset: 0x00053FC0
		// (set) Token: 0x0600204B RID: 8267 RVA: 0x00055DC8 File Offset: 0x00053FC8
		[global::System.Xml.Serialization.XmlAttribute]
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

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x0600204C RID: 8268 RVA: 0x00055DD1 File Offset: 0x00053FD1
		// (set) Token: 0x0600204D RID: 8269 RVA: 0x00055DD9 File Offset: 0x00053FD9
		[global::System.Xml.Serialization.XmlIgnore]
		public bool algnSpecified
		{
			get
			{
				return this.algnFieldSpecified;
			}
			set
			{
				this.algnFieldSpecified = value;
			}
		}

		// Token: 0x040018D4 RID: 6356
		private long txField;

		// Token: 0x040018D5 RID: 6357
		private bool txFieldSpecified;

		// Token: 0x040018D6 RID: 6358
		private long tyField;

		// Token: 0x040018D7 RID: 6359
		private bool tyFieldSpecified;

		// Token: 0x040018D8 RID: 6360
		private int sxField;

		// Token: 0x040018D9 RID: 6361
		private bool sxFieldSpecified;

		// Token: 0x040018DA RID: 6362
		private int syField;

		// Token: 0x040018DB RID: 6363
		private bool syFieldSpecified;

		// Token: 0x040018DC RID: 6364
		private global::NPOI.OpenXmlFormats.Dml.ST_TileFlipMode flipField;

		// Token: 0x040018DD RID: 6365
		private bool flipFieldSpecified;

		// Token: 0x040018DE RID: 6366
		private global::NPOI.OpenXmlFormats.Dml.ST_RectAlignment algnField;

		// Token: 0x040018DF RID: 6367
		private bool algnFieldSpecified;
	}
}
