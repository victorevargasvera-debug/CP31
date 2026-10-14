using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000490 RID: 1168
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Error
	{
		// Token: 0x06002F19 RID: 12057 RVA: 0x00076310 File Offset: 0x00074510
		public CT_Error()
		{
			this.xField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X>();
			this.tplsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples();
			this.iField = false;
			this.unField = false;
			this.stField = false;
			this.bField = false;
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x06002F1A RID: 12058 RVA: 0x0007634A File Offset: 0x0007454A
		// (set) Token: 0x06002F1B RID: 12059 RVA: 0x00076352 File Offset: 0x00074552
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples tpls
		{
			get
			{
				return this.tplsField;
			}
			set
			{
				this.tplsField = value;
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x06002F1C RID: 12060 RVA: 0x0007635B File Offset: 0x0007455B
		// (set) Token: 0x06002F1D RID: 12061 RVA: 0x00076363 File Offset: 0x00074563
		[global::System.Xml.Serialization.XmlElement("x", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X> x
		{
			get
			{
				return this.xField;
			}
			set
			{
				this.xField = value;
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x06002F1E RID: 12062 RVA: 0x0007636C File Offset: 0x0007456C
		// (set) Token: 0x06002F1F RID: 12063 RVA: 0x00076374 File Offset: 0x00074574
		[global::System.Xml.Serialization.XmlAttribute]
		public string v
		{
			get
			{
				return this.vField;
			}
			set
			{
				this.vField = value;
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x06002F20 RID: 12064 RVA: 0x0007637D File Offset: 0x0007457D
		// (set) Token: 0x06002F21 RID: 12065 RVA: 0x00076385 File Offset: 0x00074585
		[global::System.Xml.Serialization.XmlAttribute]
		public bool u
		{
			get
			{
				return this.uField;
			}
			set
			{
				this.uField = value;
			}
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x06002F22 RID: 12066 RVA: 0x0007638E File Offset: 0x0007458E
		// (set) Token: 0x06002F23 RID: 12067 RVA: 0x00076396 File Offset: 0x00074596
		[global::System.Xml.Serialization.XmlIgnore]
		public bool uSpecified
		{
			get
			{
				return this.uFieldSpecified;
			}
			set
			{
				this.uFieldSpecified = value;
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x06002F24 RID: 12068 RVA: 0x0007639F File Offset: 0x0007459F
		// (set) Token: 0x06002F25 RID: 12069 RVA: 0x000763A7 File Offset: 0x000745A7
		[global::System.Xml.Serialization.XmlAttribute]
		public bool f
		{
			get
			{
				return this.fField;
			}
			set
			{
				this.fField = value;
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x000763B0 File Offset: 0x000745B0
		// (set) Token: 0x06002F27 RID: 12071 RVA: 0x000763B8 File Offset: 0x000745B8
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fSpecified
		{
			get
			{
				return this.fFieldSpecified;
			}
			set
			{
				this.fFieldSpecified = value;
			}
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06002F28 RID: 12072 RVA: 0x000763C1 File Offset: 0x000745C1
		// (set) Token: 0x06002F29 RID: 12073 RVA: 0x000763C9 File Offset: 0x000745C9
		[global::System.Xml.Serialization.XmlAttribute]
		public string c
		{
			get
			{
				return this.cField;
			}
			set
			{
				this.cField = value;
			}
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06002F2A RID: 12074 RVA: 0x000763D2 File Offset: 0x000745D2
		// (set) Token: 0x06002F2B RID: 12075 RVA: 0x000763DA File Offset: 0x000745DA
		[global::System.Xml.Serialization.XmlAttribute]
		public uint cp
		{
			get
			{
				return this.cpField;
			}
			set
			{
				this.cpField = value;
			}
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x06002F2C RID: 12076 RVA: 0x000763E3 File Offset: 0x000745E3
		// (set) Token: 0x06002F2D RID: 12077 RVA: 0x000763EB File Offset: 0x000745EB
		[global::System.Xml.Serialization.XmlIgnore]
		public bool cpSpecified
		{
			get
			{
				return this.cpFieldSpecified;
			}
			set
			{
				this.cpFieldSpecified = value;
			}
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x06002F2E RID: 12078 RVA: 0x000763F4 File Offset: 0x000745F4
		// (set) Token: 0x06002F2F RID: 12079 RVA: 0x000763FC File Offset: 0x000745FC
		[global::System.Xml.Serialization.XmlAttribute]
		public uint @in
		{
			get
			{
				return this.inField;
			}
			set
			{
				this.inField = value;
			}
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x06002F30 RID: 12080 RVA: 0x00076405 File Offset: 0x00074605
		// (set) Token: 0x06002F31 RID: 12081 RVA: 0x0007640D File Offset: 0x0007460D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool inSpecified
		{
			get
			{
				return this.inFieldSpecified;
			}
			set
			{
				this.inFieldSpecified = value;
			}
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x06002F32 RID: 12082 RVA: 0x00076416 File Offset: 0x00074616
		// (set) Token: 0x06002F33 RID: 12083 RVA: 0x0007641E File Offset: 0x0007461E
		[global::System.Xml.Serialization.XmlAttribute(DataType = "hexBinary")]
		public byte[] bc
		{
			get
			{
				return this.bcField;
			}
			set
			{
				this.bcField = value;
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x06002F34 RID: 12084 RVA: 0x00076427 File Offset: 0x00074627
		// (set) Token: 0x06002F35 RID: 12085 RVA: 0x0007642F File Offset: 0x0007462F
		[global::System.Xml.Serialization.XmlAttribute(DataType = "hexBinary")]
		public byte[] fc
		{
			get
			{
				return this.fcField;
			}
			set
			{
				this.fcField = value;
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x06002F36 RID: 12086 RVA: 0x00076438 File Offset: 0x00074638
		// (set) Token: 0x06002F37 RID: 12087 RVA: 0x00076440 File Offset: 0x00074640
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool i
		{
			get
			{
				return this.iField;
			}
			set
			{
				this.iField = value;
			}
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x06002F38 RID: 12088 RVA: 0x00076449 File Offset: 0x00074649
		// (set) Token: 0x06002F39 RID: 12089 RVA: 0x00076451 File Offset: 0x00074651
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool un
		{
			get
			{
				return this.unField;
			}
			set
			{
				this.unField = value;
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06002F3A RID: 12090 RVA: 0x0007645A File Offset: 0x0007465A
		// (set) Token: 0x06002F3B RID: 12091 RVA: 0x00076462 File Offset: 0x00074662
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool st
		{
			get
			{
				return this.stField;
			}
			set
			{
				this.stField = value;
			}
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06002F3C RID: 12092 RVA: 0x0007646B File Offset: 0x0007466B
		// (set) Token: 0x06002F3D RID: 12093 RVA: 0x00076473 File Offset: 0x00074673
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool b
		{
			get
			{
				return this.bField;
			}
			set
			{
				this.bField = value;
			}
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x0007647C File Offset: 0x0007467C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error ct_Error = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Error();
			ct_Error.v = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["v"]);
			if (node.Attributes["u"] != null)
			{
				ct_Error.u = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["u"]);
			}
			if (node.Attributes["f"] != null)
			{
				ct_Error.f = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["f"]);
			}
			ct_Error.c = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["c"]);
			if (node.Attributes["cp"] != null)
			{
				ct_Error.cp = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["cp"]);
			}
			if (node.Attributes["in"] != null)
			{
				ct_Error.@in = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["in"]);
			}
			ct_Error.bc = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["bc"]);
			ct_Error.fc = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["fc"]);
			if (node.Attributes["i"] != null)
			{
				ct_Error.i = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["i"]);
			}
			if (node.Attributes["un"] != null)
			{
				ct_Error.un = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["un"]);
			}
			if (node.Attributes["st"] != null)
			{
				ct_Error.st = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["st"]);
			}
			if (node.Attributes["b"] != null)
			{
				ct_Error.b = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["b"]);
			}
			ct_Error.x = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tpls")
				{
					ct_Error.tpls = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "x")
				{
					ct_Error.x.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_X.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Error;
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x00076700 File Offset: 0x00074900
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "v", this.v);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "u", this.u);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "f", this.f);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "c", this.c);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cp", this.cp, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "in", this.@in, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "bc", this.bc);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fc", this.fc);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "i", this.i);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "un", this.un);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "st", this.st);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "b", this.b);
			sw.Write(">");
			if (this.tpls != null)
			{
				this.tpls.Write(sw, "tpls");
			}
			if (this.x != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_X ct_X in this.x)
				{
					ct_X.Write(sw, "x");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0400204F RID: 8271
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples tplsField;

		// Token: 0x04002050 RID: 8272
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X> xField;

		// Token: 0x04002051 RID: 8273
		private string vField;

		// Token: 0x04002052 RID: 8274
		private bool uField;

		// Token: 0x04002053 RID: 8275
		private bool uFieldSpecified;

		// Token: 0x04002054 RID: 8276
		private bool fField;

		// Token: 0x04002055 RID: 8277
		private bool fFieldSpecified;

		// Token: 0x04002056 RID: 8278
		private string cField;

		// Token: 0x04002057 RID: 8279
		private uint cpField;

		// Token: 0x04002058 RID: 8280
		private bool cpFieldSpecified;

		// Token: 0x04002059 RID: 8281
		private uint inField;

		// Token: 0x0400205A RID: 8282
		private bool inFieldSpecified;

		// Token: 0x0400205B RID: 8283
		private byte[] bcField;

		// Token: 0x0400205C RID: 8284
		private byte[] fcField;

		// Token: 0x0400205D RID: 8285
		private bool iField;

		// Token: 0x0400205E RID: 8286
		private bool unField;

		// Token: 0x0400205F RID: 8287
		private bool stField;

		// Token: 0x04002060 RID: 8288
		private bool bField;
	}
}
