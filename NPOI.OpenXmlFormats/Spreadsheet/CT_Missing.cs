using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000493 RID: 1171
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Missing
	{
		// Token: 0x06002F56 RID: 12118 RVA: 0x00076B80 File Offset: 0x00074D80
		public CT_Missing()
		{
			this.xField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X>();
			this.tplsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples>();
			this.iField = false;
			this.unField = false;
			this.stField = false;
			this.bField = false;
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06002F57 RID: 12119 RVA: 0x00076BBA File Offset: 0x00074DBA
		// (set) Token: 0x06002F58 RID: 12120 RVA: 0x00076BC2 File Offset: 0x00074DC2
		[global::System.Xml.Serialization.XmlElement("tpls", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples> tpls
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

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06002F59 RID: 12121 RVA: 0x00076BCB File Offset: 0x00074DCB
		// (set) Token: 0x06002F5A RID: 12122 RVA: 0x00076BD3 File Offset: 0x00074DD3
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

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x06002F5B RID: 12123 RVA: 0x00076BDC File Offset: 0x00074DDC
		// (set) Token: 0x06002F5C RID: 12124 RVA: 0x00076BE4 File Offset: 0x00074DE4
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

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06002F5D RID: 12125 RVA: 0x00076BED File Offset: 0x00074DED
		// (set) Token: 0x06002F5E RID: 12126 RVA: 0x00076BF5 File Offset: 0x00074DF5
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

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x00076BFE File Offset: 0x00074DFE
		// (set) Token: 0x06002F60 RID: 12128 RVA: 0x00076C06 File Offset: 0x00074E06
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

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x06002F61 RID: 12129 RVA: 0x00076C0F File Offset: 0x00074E0F
		// (set) Token: 0x06002F62 RID: 12130 RVA: 0x00076C17 File Offset: 0x00074E17
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

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x06002F63 RID: 12131 RVA: 0x00076C20 File Offset: 0x00074E20
		// (set) Token: 0x06002F64 RID: 12132 RVA: 0x00076C28 File Offset: 0x00074E28
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

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x06002F65 RID: 12133 RVA: 0x00076C31 File Offset: 0x00074E31
		// (set) Token: 0x06002F66 RID: 12134 RVA: 0x00076C39 File Offset: 0x00074E39
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

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x06002F67 RID: 12135 RVA: 0x00076C42 File Offset: 0x00074E42
		// (set) Token: 0x06002F68 RID: 12136 RVA: 0x00076C4A File Offset: 0x00074E4A
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

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x06002F69 RID: 12137 RVA: 0x00076C53 File Offset: 0x00074E53
		// (set) Token: 0x06002F6A RID: 12138 RVA: 0x00076C5B File Offset: 0x00074E5B
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

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x06002F6B RID: 12139 RVA: 0x00076C64 File Offset: 0x00074E64
		// (set) Token: 0x06002F6C RID: 12140 RVA: 0x00076C6C File Offset: 0x00074E6C
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

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x06002F6D RID: 12141 RVA: 0x00076C75 File Offset: 0x00074E75
		// (set) Token: 0x06002F6E RID: 12142 RVA: 0x00076C7D File Offset: 0x00074E7D
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

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x06002F6F RID: 12143 RVA: 0x00076C86 File Offset: 0x00074E86
		// (set) Token: 0x06002F70 RID: 12144 RVA: 0x00076C8E File Offset: 0x00074E8E
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

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x06002F71 RID: 12145 RVA: 0x00076C97 File Offset: 0x00074E97
		// (set) Token: 0x06002F72 RID: 12146 RVA: 0x00076C9F File Offset: 0x00074E9F
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

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x06002F73 RID: 12147 RVA: 0x00076CA8 File Offset: 0x00074EA8
		// (set) Token: 0x06002F74 RID: 12148 RVA: 0x00076CB0 File Offset: 0x00074EB0
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

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x06002F75 RID: 12149 RVA: 0x00076CB9 File Offset: 0x00074EB9
		// (set) Token: 0x06002F76 RID: 12150 RVA: 0x00076CC1 File Offset: 0x00074EC1
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

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x06002F77 RID: 12151 RVA: 0x00076CCA File Offset: 0x00074ECA
		// (set) Token: 0x06002F78 RID: 12152 RVA: 0x00076CD2 File Offset: 0x00074ED2
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

		// Token: 0x06002F79 RID: 12153 RVA: 0x00076CDC File Offset: 0x00074EDC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing ct_Missing = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Missing();
			if (node.Attributes["u"] != null)
			{
				ct_Missing.u = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["u"]);
			}
			if (node.Attributes["f"] != null)
			{
				ct_Missing.f = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["f"]);
			}
			ct_Missing.c = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["c"]);
			if (node.Attributes["cp"] != null)
			{
				ct_Missing.cp = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["cp"]);
			}
			if (node.Attributes["in"] != null)
			{
				ct_Missing.@in = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["in"]);
			}
			ct_Missing.bc = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["bc"]);
			ct_Missing.fc = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["fc"]);
			if (node.Attributes["i"] != null)
			{
				ct_Missing.i = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["i"]);
			}
			if (node.Attributes["un"] != null)
			{
				ct_Missing.un = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["un"]);
			}
			if (node.Attributes["st"] != null)
			{
				ct_Missing.st = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["st"]);
			}
			if (node.Attributes["b"] != null)
			{
				ct_Missing.b = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["b"]);
			}
			ct_Missing.tpls = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples>();
			ct_Missing.x = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tpls")
				{
					ct_Missing.tpls.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "x")
				{
					ct_Missing.x.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_X.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Missing;
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x00076F54 File Offset: 0x00075154
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
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
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples ct_Tuples in this.tpls)
				{
					ct_Tuples.Write(sw, "tpls");
				}
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

		// Token: 0x04002069 RID: 8297
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples> tplsField;

		// Token: 0x0400206A RID: 8298
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X> xField;

		// Token: 0x0400206B RID: 8299
		private bool uField;

		// Token: 0x0400206C RID: 8300
		private bool uFieldSpecified;

		// Token: 0x0400206D RID: 8301
		private bool fField;

		// Token: 0x0400206E RID: 8302
		private bool fFieldSpecified;

		// Token: 0x0400206F RID: 8303
		private string cField;

		// Token: 0x04002070 RID: 8304
		private uint cpField;

		// Token: 0x04002071 RID: 8305
		private bool cpFieldSpecified;

		// Token: 0x04002072 RID: 8306
		private uint inField;

		// Token: 0x04002073 RID: 8307
		private bool inFieldSpecified;

		// Token: 0x04002074 RID: 8308
		private byte[] bcField;

		// Token: 0x04002075 RID: 8309
		private byte[] fcField;

		// Token: 0x04002076 RID: 8310
		private bool iField;

		// Token: 0x04002077 RID: 8311
		private bool unField;

		// Token: 0x04002078 RID: 8312
		private bool stField;

		// Token: 0x04002079 RID: 8313
		private bool bField;
	}
}
