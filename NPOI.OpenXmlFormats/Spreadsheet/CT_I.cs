using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004C5 RID: 1221
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_I
	{
		// Token: 0x06003309 RID: 13065 RVA: 0x0007FDC4 File Offset: 0x0007DFC4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_I Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_I ct_I = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_I();
			if (node.Attributes["t"] != null)
			{
				ct_I.t = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_ItemType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_ItemType), node.Attributes["t"].Value);
			}
			if (node.Attributes["r"] != null)
			{
				ct_I.r = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["r"]);
			}
			if (node.Attributes["i"] != null)
			{
				ct_I.i = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["i"]);
			}
			ct_I.x = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "x")
				{
					ct_I.x.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_X.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_I;
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x0007FEEC File Offset: 0x0007E0EC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "t", this.t.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r", this.r, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "i", this.i, false);
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

		// Token: 0x0600330B RID: 13067 RVA: 0x0007FFBC File Offset: 0x0007E1BC
		public CT_I()
		{
			this.xField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X>();
			this.tField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_ItemType.data;
			this.rField = 0U;
			this.iField = 0U;
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x0600330C RID: 13068 RVA: 0x0007FFE4 File Offset: 0x0007E1E4
		// (set) Token: 0x0600330D RID: 13069 RVA: 0x0007FFEC File Offset: 0x0007E1EC
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

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x0600330E RID: 13070 RVA: 0x0007FFF5 File Offset: 0x0007E1F5
		// (set) Token: 0x0600330F RID: 13071 RVA: 0x0007FFFD File Offset: 0x0007E1FD
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

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06003310 RID: 13072 RVA: 0x00080006 File Offset: 0x0007E206
		// (set) Token: 0x06003311 RID: 13073 RVA: 0x0008000E File Offset: 0x0007E20E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint r
		{
			get
			{
				return this.rField;
			}
			set
			{
				this.rField = value;
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x06003312 RID: 13074 RVA: 0x00080017 File Offset: 0x0007E217
		// (set) Token: 0x06003313 RID: 13075 RVA: 0x0008001F File Offset: 0x0007E21F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint i
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

		// Token: 0x04002219 RID: 8729
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_X> xField;

		// Token: 0x0400221A RID: 8730
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_ItemType tField;

		// Token: 0x0400221B RID: 8731
		private uint rField;

		// Token: 0x0400221C RID: 8732
		private uint iField;
	}
}
