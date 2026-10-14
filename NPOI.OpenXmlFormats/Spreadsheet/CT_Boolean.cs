using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200048D RID: 1165
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Boolean
	{
		// Token: 0x06002EEA RID: 12010 RVA: 0x00075C90 File Offset: 0x00073E90
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Boolean Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Boolean ct_Boolean = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Boolean();
			if (node.Attributes["v"] != null)
			{
				ct_Boolean.v = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["v"]);
			}
			if (node.Attributes["u"] != null)
			{
				ct_Boolean.u = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["u"]);
			}
			if (node.Attributes["f"] != null)
			{
				ct_Boolean.f = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["f"]);
			}
			ct_Boolean.c = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["c"]);
			if (node.Attributes["cp"] != null)
			{
				ct_Boolean.cp = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["cp"]);
			}
			ct_Boolean.x = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "x")
				{
					ct_Boolean.x.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_X.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Boolean;
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x00075DEC File Offset: 0x00073FEC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "v", this.v);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "u", this.u);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "f", this.f);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "c", this.c);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cp", this.cp, false);
			sw.Write(">");
			if (this.x != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_X ct_X in this.x)
				{
					ct_X.Write(sw, "x");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x00075ED0 File Offset: 0x000740D0
		public CT_Boolean()
		{
			this.xField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X>();
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06002EED RID: 12013 RVA: 0x00075EE3 File Offset: 0x000740E3
		// (set) Token: 0x06002EEE RID: 12014 RVA: 0x00075EEB File Offset: 0x000740EB
		[global::System.Xml.Serialization.XmlElement("x", Order = 0)]
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

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x06002EEF RID: 12015 RVA: 0x00075EF4 File Offset: 0x000740F4
		// (set) Token: 0x06002EF0 RID: 12016 RVA: 0x00075EFC File Offset: 0x000740FC
		[global::System.Xml.Serialization.XmlAttribute]
		public bool v
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

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x06002EF1 RID: 12017 RVA: 0x00075F05 File Offset: 0x00074105
		// (set) Token: 0x06002EF2 RID: 12018 RVA: 0x00075F0D File Offset: 0x0007410D
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

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x06002EF3 RID: 12019 RVA: 0x00075F16 File Offset: 0x00074116
		// (set) Token: 0x06002EF4 RID: 12020 RVA: 0x00075F1E File Offset: 0x0007411E
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

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x06002EF5 RID: 12021 RVA: 0x00075F27 File Offset: 0x00074127
		// (set) Token: 0x06002EF6 RID: 12022 RVA: 0x00075F2F File Offset: 0x0007412F
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

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06002EF7 RID: 12023 RVA: 0x00075F38 File Offset: 0x00074138
		// (set) Token: 0x06002EF8 RID: 12024 RVA: 0x00075F40 File Offset: 0x00074140
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

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06002EF9 RID: 12025 RVA: 0x00075F49 File Offset: 0x00074149
		// (set) Token: 0x06002EFA RID: 12026 RVA: 0x00075F51 File Offset: 0x00074151
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

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06002EFB RID: 12027 RVA: 0x00075F5A File Offset: 0x0007415A
		// (set) Token: 0x06002EFC RID: 12028 RVA: 0x00075F62 File Offset: 0x00074162
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

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06002EFD RID: 12029 RVA: 0x00075F6B File Offset: 0x0007416B
		// (set) Token: 0x06002EFE RID: 12030 RVA: 0x00075F73 File Offset: 0x00074173
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

		// Token: 0x0400203C RID: 8252
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X> xField;

		// Token: 0x0400203D RID: 8253
		private bool vField;

		// Token: 0x0400203E RID: 8254
		private bool uField;

		// Token: 0x0400203F RID: 8255
		private bool uFieldSpecified;

		// Token: 0x04002040 RID: 8256
		private bool fField;

		// Token: 0x04002041 RID: 8257
		private bool fFieldSpecified;

		// Token: 0x04002042 RID: 8258
		private string cField;

		// Token: 0x04002043 RID: 8259
		private uint cpField;

		// Token: 0x04002044 RID: 8260
		private bool cpFieldSpecified;
	}
}
