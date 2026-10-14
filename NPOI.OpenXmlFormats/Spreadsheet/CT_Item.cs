using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004BE RID: 1214
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Item
	{
		// Token: 0x060032D0 RID: 13008 RVA: 0x0007F48C File Offset: 0x0007D68C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Item Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Item ct_Item = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Item();
			ct_Item.n = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["n"]);
			if (node.Attributes["t"] != null)
			{
				ct_Item.t = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_ItemType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_ItemType), node.Attributes["t"].Value);
			}
			if (node.Attributes["h"] != null)
			{
				ct_Item.h = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["h"]);
			}
			if (node.Attributes["s"] != null)
			{
				ct_Item.s = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["s"]);
			}
			if (node.Attributes["sd"] != null)
			{
				ct_Item.sd = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["sd"]);
			}
			if (node.Attributes["f"] != null)
			{
				ct_Item.f = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["f"]);
			}
			if (node.Attributes["m"] != null)
			{
				ct_Item.m = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["m"]);
			}
			if (node.Attributes["c"] != null)
			{
				ct_Item.c = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["c"]);
			}
			if (node.Attributes["x"] != null)
			{
				ct_Item.x = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["x"]);
			}
			if (node.Attributes["d"] != null)
			{
				ct_Item.d = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["d"]);
			}
			if (node.Attributes["e"] != null)
			{
				ct_Item.e = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["e"]);
			}
			return ct_Item;
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x0007F698 File Offset: 0x0007D898
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "n", this.n);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "t", this.t.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "h", this.h);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "s", this.s);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sd", this.sd);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "f", this.f);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m", this.m);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "c", this.c);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "x", this.x, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "d", this.d);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "e", this.e);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x0007F79C File Offset: 0x0007D99C
		public CT_Item()
		{
			this.tField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_ItemType.data;
			this.hField = false;
			this.sField = false;
			this.sdField = true;
			this.fField = false;
			this.mField = false;
			this.cField = false;
			this.dField = false;
			this.eField = true;
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x060032D3 RID: 13011 RVA: 0x0007F7EE File Offset: 0x0007D9EE
		// (set) Token: 0x060032D4 RID: 13012 RVA: 0x0007F7F6 File Offset: 0x0007D9F6
		[global::System.Xml.Serialization.XmlAttribute]
		public string n
		{
			get
			{
				return this.nField;
			}
			set
			{
				this.nField = value;
			}
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x060032D5 RID: 13013 RVA: 0x0007F7FF File Offset: 0x0007D9FF
		// (set) Token: 0x060032D6 RID: 13014 RVA: 0x0007F807 File Offset: 0x0007DA07
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_ItemType.data)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_ItemType t
		{
			get
			{
				return this.tField;
			}
			set
			{
				this.tField = value;
			}
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x060032D7 RID: 13015 RVA: 0x0007F810 File Offset: 0x0007DA10
		// (set) Token: 0x060032D8 RID: 13016 RVA: 0x0007F818 File Offset: 0x0007DA18
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool h
		{
			get
			{
				return this.hField;
			}
			set
			{
				this.hField = value;
			}
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x060032D9 RID: 13017 RVA: 0x0007F821 File Offset: 0x0007DA21
		// (set) Token: 0x060032DA RID: 13018 RVA: 0x0007F829 File Offset: 0x0007DA29
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool s
		{
			get
			{
				return this.sField;
			}
			set
			{
				this.sField = value;
			}
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x060032DB RID: 13019 RVA: 0x0007F832 File Offset: 0x0007DA32
		// (set) Token: 0x060032DC RID: 13020 RVA: 0x0007F83A File Offset: 0x0007DA3A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool sd
		{
			get
			{
				return this.sdField;
			}
			set
			{
				this.sdField = value;
			}
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x060032DD RID: 13021 RVA: 0x0007F843 File Offset: 0x0007DA43
		// (set) Token: 0x060032DE RID: 13022 RVA: 0x0007F84B File Offset: 0x0007DA4B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
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

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x060032DF RID: 13023 RVA: 0x0007F854 File Offset: 0x0007DA54
		// (set) Token: 0x060032E0 RID: 13024 RVA: 0x0007F85C File Offset: 0x0007DA5C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool m
		{
			get
			{
				return this.mField;
			}
			set
			{
				this.mField = value;
			}
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x060032E1 RID: 13025 RVA: 0x0007F865 File Offset: 0x0007DA65
		// (set) Token: 0x060032E2 RID: 13026 RVA: 0x0007F86D File Offset: 0x0007DA6D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool c
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

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x060032E3 RID: 13027 RVA: 0x0007F876 File Offset: 0x0007DA76
		// (set) Token: 0x060032E4 RID: 13028 RVA: 0x0007F87E File Offset: 0x0007DA7E
		[global::System.Xml.Serialization.XmlAttribute]
		public uint x
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

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x060032E5 RID: 13029 RVA: 0x0007F887 File Offset: 0x0007DA87
		// (set) Token: 0x060032E6 RID: 13030 RVA: 0x0007F88F File Offset: 0x0007DA8F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool xSpecified
		{
			get
			{
				return this.xFieldSpecified;
			}
			set
			{
				this.xFieldSpecified = value;
			}
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x060032E7 RID: 13031 RVA: 0x0007F898 File Offset: 0x0007DA98
		// (set) Token: 0x060032E8 RID: 13032 RVA: 0x0007F8A0 File Offset: 0x0007DAA0
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool d
		{
			get
			{
				return this.dField;
			}
			set
			{
				this.dField = value;
			}
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x060032E9 RID: 13033 RVA: 0x0007F8A9 File Offset: 0x0007DAA9
		// (set) Token: 0x060032EA RID: 13034 RVA: 0x0007F8B1 File Offset: 0x0007DAB1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool e
		{
			get
			{
				return this.eField;
			}
			set
			{
				this.eField = value;
			}
		}

		// Token: 0x040021F2 RID: 8690
		private string nField;

		// Token: 0x040021F3 RID: 8691
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_ItemType tField;

		// Token: 0x040021F4 RID: 8692
		private bool hField;

		// Token: 0x040021F5 RID: 8693
		private bool sField;

		// Token: 0x040021F6 RID: 8694
		private bool sdField;

		// Token: 0x040021F7 RID: 8695
		private bool fField;

		// Token: 0x040021F8 RID: 8696
		private bool mField;

		// Token: 0x040021F9 RID: 8697
		private bool cField;

		// Token: 0x040021FA RID: 8698
		private uint xField;

		// Token: 0x040021FB RID: 8699
		private bool xFieldSpecified;

		// Token: 0x040021FC RID: 8700
		private bool dField;

		// Token: 0x040021FD RID: 8701
		private bool eField;
	}
}
