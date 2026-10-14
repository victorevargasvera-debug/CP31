using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200048F RID: 1167
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_DateTime
	{
		// Token: 0x06002F04 RID: 12036 RVA: 0x00076024 File Offset: 0x00074224
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateTime Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateTime ct_DateTime = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateTime();
			if (node.Attributes["v"] != null)
			{
				ct_DateTime.v = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDateTime(node.Attributes["v"]);
			}
			if (node.Attributes["u"] != null)
			{
				ct_DateTime.u = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["u"]);
			}
			if (node.Attributes["f"] != null)
			{
				ct_DateTime.f = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["f"]);
			}
			ct_DateTime.c = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["c"]);
			if (node.Attributes["cp"] != null)
			{
				ct_DateTime.cp = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["cp"]);
			}
			ct_DateTime.x = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "x")
				{
					ct_DateTime.x.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_X.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_DateTime;
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x00076180 File Offset: 0x00074380
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

		// Token: 0x06002F06 RID: 12038 RVA: 0x00076264 File Offset: 0x00074464
		public CT_DateTime()
		{
			this.xField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X>();
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x00076277 File Offset: 0x00074477
		// (set) Token: 0x06002F08 RID: 12040 RVA: 0x0007627F File Offset: 0x0007447F
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

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x06002F09 RID: 12041 RVA: 0x00076288 File Offset: 0x00074488
		// (set) Token: 0x06002F0A RID: 12042 RVA: 0x00076290 File Offset: 0x00074490
		[global::System.Xml.Serialization.XmlAttribute]
		public global::System.DateTime? v
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

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x06002F0B RID: 12043 RVA: 0x00076299 File Offset: 0x00074499
		// (set) Token: 0x06002F0C RID: 12044 RVA: 0x000762A1 File Offset: 0x000744A1
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

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06002F0D RID: 12045 RVA: 0x000762AA File Offset: 0x000744AA
		// (set) Token: 0x06002F0E RID: 12046 RVA: 0x000762B2 File Offset: 0x000744B2
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

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x000762BB File Offset: 0x000744BB
		// (set) Token: 0x06002F10 RID: 12048 RVA: 0x000762C3 File Offset: 0x000744C3
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

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x000762CC File Offset: 0x000744CC
		// (set) Token: 0x06002F12 RID: 12050 RVA: 0x000762D4 File Offset: 0x000744D4
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

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x000762DD File Offset: 0x000744DD
		// (set) Token: 0x06002F14 RID: 12052 RVA: 0x000762E5 File Offset: 0x000744E5
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

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x000762EE File Offset: 0x000744EE
		// (set) Token: 0x06002F16 RID: 12054 RVA: 0x000762F6 File Offset: 0x000744F6
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

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06002F17 RID: 12055 RVA: 0x000762FF File Offset: 0x000744FF
		// (set) Token: 0x06002F18 RID: 12056 RVA: 0x00076307 File Offset: 0x00074507
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

		// Token: 0x04002046 RID: 8262
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X> xField;

		// Token: 0x04002047 RID: 8263
		private global::System.DateTime? vField;

		// Token: 0x04002048 RID: 8264
		private bool uField;

		// Token: 0x04002049 RID: 8265
		private bool uFieldSpecified;

		// Token: 0x0400204A RID: 8266
		private bool fField;

		// Token: 0x0400204B RID: 8267
		private bool fFieldSpecified;

		// Token: 0x0400204C RID: 8268
		private string cField;

		// Token: 0x0400204D RID: 8269
		private uint cpField;

		// Token: 0x0400204E RID: 8270
		private bool cpFieldSpecified;
	}
}
