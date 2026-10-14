using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000314 RID: 788
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ReflectionEffect
	{
		// Token: 0x06001F31 RID: 7985 RVA: 0x000538A8 File Offset: 0x00051AA8
		public static global::NPOI.OpenXmlFormats.Dml.CT_ReflectionEffect Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_ReflectionEffect ct_ReflectionEffect = new global::NPOI.OpenXmlFormats.Dml.CT_ReflectionEffect();
			ct_ReflectionEffect.blurRad = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["blurRad"]);
			ct_ReflectionEffect.stA = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["stA"]);
			ct_ReflectionEffect.stPos = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["stPos"]);
			ct_ReflectionEffect.endA = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["endA"]);
			ct_ReflectionEffect.endPos = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["endPos"]);
			ct_ReflectionEffect.dist = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["dist"]);
			ct_ReflectionEffect.dir = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["dir"]);
			ct_ReflectionEffect.fadeDir = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["fadeDir"]);
			ct_ReflectionEffect.sx = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["sx"]);
			ct_ReflectionEffect.sy = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["sy"]);
			ct_ReflectionEffect.kx = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["kx"]);
			ct_ReflectionEffect.ky = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["ky"]);
			if (node.Attributes["algn"] != null)
			{
				ct_ReflectionEffect.algn = (global::NPOI.OpenXmlFormats.Dml.ST_RectAlignment)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_RectAlignment), node.Attributes["algn"].Value);
			}
			ct_ReflectionEffect.rotWithShape = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["rotWithShape"]);
			return ct_ReflectionEffect;
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00053A64 File Offset: 0x00051C64
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "blurRad", (double)this.blurRad);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "stA", this.stA);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "stPos", this.stPos);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "endA", this.endA);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "endPos", this.endPos);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dist", (double)this.dist);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dir", this.dir);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fadeDir", this.fadeDir);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sx", this.sx);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sy", this.sy);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "kx", this.kx);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ky", this.ky);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "algn", this.algn.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rotWithShape", this.rotWithShape);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x00053B9C File Offset: 0x00051D9C
		public CT_ReflectionEffect()
		{
			this.blurRadField = 0L;
			this.stAField = 100000;
			this.stPosField = 0;
			this.endAField = 0;
			this.endPosField = 100000;
			this.distField = 0L;
			this.dirField = 0;
			this.fadeDirField = 5400000;
			this.sxField = 100000;
			this.syField = 100000;
			this.kxField = 0;
			this.kyField = 0;
			this.algnField = global::NPOI.OpenXmlFormats.Dml.ST_RectAlignment.b;
			this.rotWithShapeField = true;
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06001F34 RID: 7988 RVA: 0x00053C27 File Offset: 0x00051E27
		// (set) Token: 0x06001F35 RID: 7989 RVA: 0x00053C2F File Offset: 0x00051E2F
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

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06001F36 RID: 7990 RVA: 0x00053C38 File Offset: 0x00051E38
		// (set) Token: 0x06001F37 RID: 7991 RVA: 0x00053C40 File Offset: 0x00051E40
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(100000)]
		public int stA
		{
			get
			{
				return this.stAField;
			}
			set
			{
				this.stAField = value;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06001F38 RID: 7992 RVA: 0x00053C49 File Offset: 0x00051E49
		// (set) Token: 0x06001F39 RID: 7993 RVA: 0x00053C51 File Offset: 0x00051E51
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int stPos
		{
			get
			{
				return this.stPosField;
			}
			set
			{
				this.stPosField = value;
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x00053C5A File Offset: 0x00051E5A
		// (set) Token: 0x06001F3B RID: 7995 RVA: 0x00053C62 File Offset: 0x00051E62
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(0)]
		public int endA
		{
			get
			{
				return this.endAField;
			}
			set
			{
				this.endAField = value;
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06001F3C RID: 7996 RVA: 0x00053C6B File Offset: 0x00051E6B
		// (set) Token: 0x06001F3D RID: 7997 RVA: 0x00053C73 File Offset: 0x00051E73
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(100000)]
		public int endPos
		{
			get
			{
				return this.endPosField;
			}
			set
			{
				this.endPosField = value;
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x00053C7C File Offset: 0x00051E7C
		// (set) Token: 0x06001F3F RID: 7999 RVA: 0x00053C84 File Offset: 0x00051E84
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

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x00053C8D File Offset: 0x00051E8D
		// (set) Token: 0x06001F41 RID: 8001 RVA: 0x00053C95 File Offset: 0x00051E95
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

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06001F42 RID: 8002 RVA: 0x00053C9E File Offset: 0x00051E9E
		// (set) Token: 0x06001F43 RID: 8003 RVA: 0x00053CA6 File Offset: 0x00051EA6
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(5400000)]
		public int fadeDir
		{
			get
			{
				return this.fadeDirField;
			}
			set
			{
				this.fadeDirField = value;
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x00053CAF File Offset: 0x00051EAF
		// (set) Token: 0x06001F45 RID: 8005 RVA: 0x00053CB7 File Offset: 0x00051EB7
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

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x00053CC0 File Offset: 0x00051EC0
		// (set) Token: 0x06001F47 RID: 8007 RVA: 0x00053CC8 File Offset: 0x00051EC8
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

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06001F48 RID: 8008 RVA: 0x00053CD1 File Offset: 0x00051ED1
		// (set) Token: 0x06001F49 RID: 8009 RVA: 0x00053CD9 File Offset: 0x00051ED9
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

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06001F4A RID: 8010 RVA: 0x00053CE2 File Offset: 0x00051EE2
		// (set) Token: 0x06001F4B RID: 8011 RVA: 0x00053CEA File Offset: 0x00051EEA
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

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06001F4C RID: 8012 RVA: 0x00053CF3 File Offset: 0x00051EF3
		// (set) Token: 0x06001F4D RID: 8013 RVA: 0x00053CFB File Offset: 0x00051EFB
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

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x00053D04 File Offset: 0x00051F04
		// (set) Token: 0x06001F4F RID: 8015 RVA: 0x00053D0C File Offset: 0x00051F0C
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

		// Token: 0x04001850 RID: 6224
		private long blurRadField;

		// Token: 0x04001851 RID: 6225
		private int stAField;

		// Token: 0x04001852 RID: 6226
		private int stPosField;

		// Token: 0x04001853 RID: 6227
		private int endAField;

		// Token: 0x04001854 RID: 6228
		private int endPosField;

		// Token: 0x04001855 RID: 6229
		private long distField;

		// Token: 0x04001856 RID: 6230
		private int dirField;

		// Token: 0x04001857 RID: 6231
		private int fadeDirField;

		// Token: 0x04001858 RID: 6232
		private int sxField;

		// Token: 0x04001859 RID: 6233
		private int syField;

		// Token: 0x0400185A RID: 6234
		private int kxField;

		// Token: 0x0400185B RID: 6235
		private int kyField;

		// Token: 0x0400185C RID: 6236
		private global::NPOI.OpenXmlFormats.Dml.ST_RectAlignment algnField;

		// Token: 0x0400185D RID: 6237
		private bool rotWithShapeField;
	}
}
