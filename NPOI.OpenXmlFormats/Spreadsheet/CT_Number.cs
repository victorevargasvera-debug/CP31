using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000494 RID: 1172
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Number
	{
		// Token: 0x06002F7B RID: 12155 RVA: 0x000770EC File Offset: 0x000752EC
		public CT_Number()
		{
			this.xField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X>();
			this.tplsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples>();
			this.iField = false;
			this.unField = false;
			this.stField = false;
			this.bField = false;
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x06002F7C RID: 12156 RVA: 0x00077126 File Offset: 0x00075326
		// (set) Token: 0x06002F7D RID: 12157 RVA: 0x0007712E File Offset: 0x0007532E
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

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x06002F7E RID: 12158 RVA: 0x00077137 File Offset: 0x00075337
		// (set) Token: 0x06002F7F RID: 12159 RVA: 0x0007713F File Offset: 0x0007533F
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

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x06002F80 RID: 12160 RVA: 0x00077148 File Offset: 0x00075348
		// (set) Token: 0x06002F81 RID: 12161 RVA: 0x00077150 File Offset: 0x00075350
		[global::System.Xml.Serialization.XmlAttribute]
		public double v
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

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x06002F82 RID: 12162 RVA: 0x00077159 File Offset: 0x00075359
		// (set) Token: 0x06002F83 RID: 12163 RVA: 0x00077161 File Offset: 0x00075361
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

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x06002F84 RID: 12164 RVA: 0x0007716A File Offset: 0x0007536A
		// (set) Token: 0x06002F85 RID: 12165 RVA: 0x00077172 File Offset: 0x00075372
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

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x06002F86 RID: 12166 RVA: 0x0007717B File Offset: 0x0007537B
		// (set) Token: 0x06002F87 RID: 12167 RVA: 0x00077183 File Offset: 0x00075383
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

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x06002F88 RID: 12168 RVA: 0x0007718C File Offset: 0x0007538C
		// (set) Token: 0x06002F89 RID: 12169 RVA: 0x00077194 File Offset: 0x00075394
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

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x06002F8A RID: 12170 RVA: 0x0007719D File Offset: 0x0007539D
		// (set) Token: 0x06002F8B RID: 12171 RVA: 0x000771A5 File Offset: 0x000753A5
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

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x06002F8C RID: 12172 RVA: 0x000771AE File Offset: 0x000753AE
		// (set) Token: 0x06002F8D RID: 12173 RVA: 0x000771B6 File Offset: 0x000753B6
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

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x06002F8E RID: 12174 RVA: 0x000771BF File Offset: 0x000753BF
		// (set) Token: 0x06002F8F RID: 12175 RVA: 0x000771C7 File Offset: 0x000753C7
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

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x06002F90 RID: 12176 RVA: 0x000771D0 File Offset: 0x000753D0
		// (set) Token: 0x06002F91 RID: 12177 RVA: 0x000771D8 File Offset: 0x000753D8
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

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x06002F92 RID: 12178 RVA: 0x000771E1 File Offset: 0x000753E1
		// (set) Token: 0x06002F93 RID: 12179 RVA: 0x000771E9 File Offset: 0x000753E9
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

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x06002F94 RID: 12180 RVA: 0x000771F2 File Offset: 0x000753F2
		// (set) Token: 0x06002F95 RID: 12181 RVA: 0x000771FA File Offset: 0x000753FA
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

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x06002F96 RID: 12182 RVA: 0x00077203 File Offset: 0x00075403
		// (set) Token: 0x06002F97 RID: 12183 RVA: 0x0007720B File Offset: 0x0007540B
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

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x06002F98 RID: 12184 RVA: 0x00077214 File Offset: 0x00075414
		// (set) Token: 0x06002F99 RID: 12185 RVA: 0x0007721C File Offset: 0x0007541C
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

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x06002F9A RID: 12186 RVA: 0x00077225 File Offset: 0x00075425
		// (set) Token: 0x06002F9B RID: 12187 RVA: 0x0007722D File Offset: 0x0007542D
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

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x06002F9C RID: 12188 RVA: 0x00077236 File Offset: 0x00075436
		// (set) Token: 0x06002F9D RID: 12189 RVA: 0x0007723E File Offset: 0x0007543E
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

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x06002F9E RID: 12190 RVA: 0x00077247 File Offset: 0x00075447
		// (set) Token: 0x06002F9F RID: 12191 RVA: 0x0007724F File Offset: 0x0007544F
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

		// Token: 0x06002FA0 RID: 12192 RVA: 0x00077258 File Offset: 0x00075458
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number ct_Number = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Number();
			if (node.Attributes["v"] != null)
			{
				ct_Number.v = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["v"]);
			}
			if (node.Attributes["u"] != null)
			{
				ct_Number.u = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["u"]);
			}
			if (node.Attributes["f"] != null)
			{
				ct_Number.f = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["f"]);
			}
			ct_Number.c = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["c"]);
			if (node.Attributes["cp"] != null)
			{
				ct_Number.cp = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["cp"]);
			}
			if (node.Attributes["in"] != null)
			{
				ct_Number.@in = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["in"]);
			}
			ct_Number.bc = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["bc"]);
			ct_Number.fc = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["fc"]);
			if (node.Attributes["i"] != null)
			{
				ct_Number.i = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["i"]);
			}
			if (node.Attributes["un"] != null)
			{
				ct_Number.un = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["un"]);
			}
			if (node.Attributes["st"] != null)
			{
				ct_Number.st = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["st"]);
			}
			if (node.Attributes["b"] != null)
			{
				ct_Number.b = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["b"]);
			}
			ct_Number.tpls = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples>();
			ct_Number.x = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tpls")
				{
					ct_Number.tpls.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "x")
				{
					ct_Number.x.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_X.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Number;
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x000774FC File Offset: 0x000756FC
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

		// Token: 0x0400207A RID: 8314
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples> tplsField;

		// Token: 0x0400207B RID: 8315
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X> xField;

		// Token: 0x0400207C RID: 8316
		private double vField;

		// Token: 0x0400207D RID: 8317
		private bool uField;

		// Token: 0x0400207E RID: 8318
		private bool uFieldSpecified;

		// Token: 0x0400207F RID: 8319
		private bool fField;

		// Token: 0x04002080 RID: 8320
		private bool fFieldSpecified;

		// Token: 0x04002081 RID: 8321
		private string cField;

		// Token: 0x04002082 RID: 8322
		private uint cpField;

		// Token: 0x04002083 RID: 8323
		private bool cpFieldSpecified;

		// Token: 0x04002084 RID: 8324
		private uint inField;

		// Token: 0x04002085 RID: 8325
		private bool inFieldSpecified;

		// Token: 0x04002086 RID: 8326
		private byte[] bcField;

		// Token: 0x04002087 RID: 8327
		private byte[] fcField;

		// Token: 0x04002088 RID: 8328
		private bool iField;

		// Token: 0x04002089 RID: 8329
		private bool unField;

		// Token: 0x0400208A RID: 8330
		private bool stField;

		// Token: 0x0400208B RID: 8331
		private bool bField;
	}
}
