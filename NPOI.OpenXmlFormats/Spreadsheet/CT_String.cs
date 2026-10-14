using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000495 RID: 1173
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_String
	{
		// Token: 0x06002FA2 RID: 12194 RVA: 0x000776A4 File Offset: 0x000758A4
		public CT_String()
		{
			this.xField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X>();
			this.tplsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples>();
			this.iField = false;
			this.unField = false;
			this.stField = false;
			this.bField = false;
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x000776DE File Offset: 0x000758DE
		// (set) Token: 0x06002FA4 RID: 12196 RVA: 0x000776E6 File Offset: 0x000758E6
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

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x000776EF File Offset: 0x000758EF
		// (set) Token: 0x06002FA6 RID: 12198 RVA: 0x000776F7 File Offset: 0x000758F7
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

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x06002FA7 RID: 12199 RVA: 0x00077700 File Offset: 0x00075900
		// (set) Token: 0x06002FA8 RID: 12200 RVA: 0x00077708 File Offset: 0x00075908
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

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x06002FA9 RID: 12201 RVA: 0x00077711 File Offset: 0x00075911
		// (set) Token: 0x06002FAA RID: 12202 RVA: 0x00077719 File Offset: 0x00075919
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

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x06002FAB RID: 12203 RVA: 0x00077722 File Offset: 0x00075922
		// (set) Token: 0x06002FAC RID: 12204 RVA: 0x0007772A File Offset: 0x0007592A
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

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x06002FAD RID: 12205 RVA: 0x00077733 File Offset: 0x00075933
		// (set) Token: 0x06002FAE RID: 12206 RVA: 0x0007773B File Offset: 0x0007593B
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

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x06002FAF RID: 12207 RVA: 0x00077744 File Offset: 0x00075944
		// (set) Token: 0x06002FB0 RID: 12208 RVA: 0x0007774C File Offset: 0x0007594C
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

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x06002FB1 RID: 12209 RVA: 0x00077755 File Offset: 0x00075955
		// (set) Token: 0x06002FB2 RID: 12210 RVA: 0x0007775D File Offset: 0x0007595D
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

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x00077766 File Offset: 0x00075966
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x0007776E File Offset: 0x0007596E
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

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x06002FB5 RID: 12213 RVA: 0x00077777 File Offset: 0x00075977
		// (set) Token: 0x06002FB6 RID: 12214 RVA: 0x0007777F File Offset: 0x0007597F
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

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x00077788 File Offset: 0x00075988
		// (set) Token: 0x06002FB8 RID: 12216 RVA: 0x00077790 File Offset: 0x00075990
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

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x06002FB9 RID: 12217 RVA: 0x00077799 File Offset: 0x00075999
		// (set) Token: 0x06002FBA RID: 12218 RVA: 0x000777A1 File Offset: 0x000759A1
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

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06002FBB RID: 12219 RVA: 0x000777AA File Offset: 0x000759AA
		// (set) Token: 0x06002FBC RID: 12220 RVA: 0x000777B2 File Offset: 0x000759B2
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

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x06002FBD RID: 12221 RVA: 0x000777BB File Offset: 0x000759BB
		// (set) Token: 0x06002FBE RID: 12222 RVA: 0x000777C3 File Offset: 0x000759C3
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

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x06002FBF RID: 12223 RVA: 0x000777CC File Offset: 0x000759CC
		// (set) Token: 0x06002FC0 RID: 12224 RVA: 0x000777D4 File Offset: 0x000759D4
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

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x06002FC1 RID: 12225 RVA: 0x000777DD File Offset: 0x000759DD
		// (set) Token: 0x06002FC2 RID: 12226 RVA: 0x000777E5 File Offset: 0x000759E5
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

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x06002FC3 RID: 12227 RVA: 0x000777EE File Offset: 0x000759EE
		// (set) Token: 0x06002FC4 RID: 12228 RVA: 0x000777F6 File Offset: 0x000759F6
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

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x000777FF File Offset: 0x000759FF
		// (set) Token: 0x06002FC6 RID: 12230 RVA: 0x00077807 File Offset: 0x00075A07
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

		// Token: 0x06002FC7 RID: 12231 RVA: 0x00077810 File Offset: 0x00075A10
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_String Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_String ct_String = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_String();
			ct_String.v = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["v"]);
			if (node.Attributes["u"] != null)
			{
				ct_String.u = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["u"]);
			}
			if (node.Attributes["f"] != null)
			{
				ct_String.f = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["f"]);
			}
			ct_String.c = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["c"]);
			if (node.Attributes["cp"] != null)
			{
				ct_String.cp = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["cp"]);
			}
			if (node.Attributes["in"] != null)
			{
				ct_String.@in = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["in"]);
			}
			ct_String.bc = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["bc"]);
			ct_String.fc = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["fc"]);
			if (node.Attributes["i"] != null)
			{
				ct_String.i = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["i"]);
			}
			if (node.Attributes["un"] != null)
			{
				ct_String.un = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["un"]);
			}
			if (node.Attributes["st"] != null)
			{
				ct_String.st = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["st"]);
			}
			if (node.Attributes["b"] != null)
			{
				ct_String.b = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["b"]);
			}
			ct_String.tpls = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples>();
			ct_String.x = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tpls")
				{
					ct_String.tpls.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "x")
				{
					ct_String.x.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_X.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_String;
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x00077AA4 File Offset: 0x00075CA4
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

		// Token: 0x0400208C RID: 8332
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Tuples> tplsField;

		// Token: 0x0400208D RID: 8333
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X> xField;

		// Token: 0x0400208E RID: 8334
		private string vField;

		// Token: 0x0400208F RID: 8335
		private bool uField;

		// Token: 0x04002090 RID: 8336
		private bool uFieldSpecified;

		// Token: 0x04002091 RID: 8337
		private bool fField;

		// Token: 0x04002092 RID: 8338
		private bool fFieldSpecified;

		// Token: 0x04002093 RID: 8339
		private string cField;

		// Token: 0x04002094 RID: 8340
		private uint cpField;

		// Token: 0x04002095 RID: 8341
		private bool cpFieldSpecified;

		// Token: 0x04002096 RID: 8342
		private uint inField;

		// Token: 0x04002097 RID: 8343
		private bool inFieldSpecified;

		// Token: 0x04002098 RID: 8344
		private byte[] bcField;

		// Token: 0x04002099 RID: 8345
		private byte[] fcField;

		// Token: 0x0400209A RID: 8346
		private bool iField;

		// Token: 0x0400209B RID: 8347
		private bool unField;

		// Token: 0x0400209C RID: 8348
		private bool stField;

		// Token: 0x0400209D RID: 8349
		private bool bField;
	}
}
