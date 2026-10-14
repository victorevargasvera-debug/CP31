using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000344 RID: 836
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ColorMapping
	{
		// Token: 0x060020E6 RID: 8422 RVA: 0x000569FC File Offset: 0x00054BFC
		public static global::NPOI.OpenXmlFormats.Dml.CT_ColorMapping Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_ColorMapping ct_ColorMapping = new global::NPOI.OpenXmlFormats.Dml.CT_ColorMapping();
			if (node.Attributes["bg1"] != null)
			{
				ct_ColorMapping.bg1 = (global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex), node.Attributes["bg1"].Value);
			}
			if (node.Attributes["tx1"] != null)
			{
				ct_ColorMapping.tx1 = (global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex), node.Attributes["tx1"].Value);
			}
			if (node.Attributes["bg2"] != null)
			{
				ct_ColorMapping.bg2 = (global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex), node.Attributes["bg2"].Value);
			}
			if (node.Attributes["tx2"] != null)
			{
				ct_ColorMapping.tx2 = (global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex), node.Attributes["tx2"].Value);
			}
			if (node.Attributes["accent1"] != null)
			{
				ct_ColorMapping.accent1 = (global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex), node.Attributes["accent1"].Value);
			}
			if (node.Attributes["accent2"] != null)
			{
				ct_ColorMapping.accent2 = (global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex), node.Attributes["accent2"].Value);
			}
			if (node.Attributes["accent3"] != null)
			{
				ct_ColorMapping.accent3 = (global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex), node.Attributes["accent3"].Value);
			}
			if (node.Attributes["accent4"] != null)
			{
				ct_ColorMapping.accent4 = (global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex), node.Attributes["accent4"].Value);
			}
			if (node.Attributes["accent5"] != null)
			{
				ct_ColorMapping.accent5 = (global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex), node.Attributes["accent5"].Value);
			}
			if (node.Attributes["accent6"] != null)
			{
				ct_ColorMapping.accent6 = (global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex), node.Attributes["accent6"].Value);
			}
			if (node.Attributes["hlink"] != null)
			{
				ct_ColorMapping.hlink = (global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex), node.Attributes["hlink"].Value);
			}
			if (node.Attributes["folHlink"] != null)
			{
				ct_ColorMapping.folHlink = (global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex), node.Attributes["folHlink"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "extLst")
				{
					ct_ColorMapping.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ColorMapping;
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x00056D88 File Offset: 0x00054F88
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "bg1", this.bg1.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "tx1", this.tx1.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "bg2", this.bg2.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "tx2", this.tx2.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "accent1", this.accent1.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "accent2", this.accent2.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "accent3", this.accent3.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "accent4", this.accent4.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "accent5", this.accent5.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "accent6", this.accent6.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hlink", this.hlink.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "folHlink", this.folHlink.ToString());
			sw.Write(">");
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x00056F4F File Offset: 0x0005514F
		// (set) Token: 0x060020EA RID: 8426 RVA: 0x00056F57 File Offset: 0x00055157
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x060020EB RID: 8427 RVA: 0x00056F60 File Offset: 0x00055160
		// (set) Token: 0x060020EC RID: 8428 RVA: 0x00056F68 File Offset: 0x00055168
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex bg1
		{
			get
			{
				return this.bg1Field;
			}
			set
			{
				this.bg1Field = value;
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x060020ED RID: 8429 RVA: 0x00056F71 File Offset: 0x00055171
		// (set) Token: 0x060020EE RID: 8430 RVA: 0x00056F79 File Offset: 0x00055179
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex tx1
		{
			get
			{
				return this.tx1Field;
			}
			set
			{
				this.tx1Field = value;
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x00056F82 File Offset: 0x00055182
		// (set) Token: 0x060020F0 RID: 8432 RVA: 0x00056F8A File Offset: 0x0005518A
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex bg2
		{
			get
			{
				return this.bg2Field;
			}
			set
			{
				this.bg2Field = value;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x060020F1 RID: 8433 RVA: 0x00056F93 File Offset: 0x00055193
		// (set) Token: 0x060020F2 RID: 8434 RVA: 0x00056F9B File Offset: 0x0005519B
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex tx2
		{
			get
			{
				return this.tx2Field;
			}
			set
			{
				this.tx2Field = value;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x060020F3 RID: 8435 RVA: 0x00056FA4 File Offset: 0x000551A4
		// (set) Token: 0x060020F4 RID: 8436 RVA: 0x00056FAC File Offset: 0x000551AC
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex accent1
		{
			get
			{
				return this.accent1Field;
			}
			set
			{
				this.accent1Field = value;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x00056FB5 File Offset: 0x000551B5
		// (set) Token: 0x060020F6 RID: 8438 RVA: 0x00056FBD File Offset: 0x000551BD
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex accent2
		{
			get
			{
				return this.accent2Field;
			}
			set
			{
				this.accent2Field = value;
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x00056FC6 File Offset: 0x000551C6
		// (set) Token: 0x060020F8 RID: 8440 RVA: 0x00056FCE File Offset: 0x000551CE
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex accent3
		{
			get
			{
				return this.accent3Field;
			}
			set
			{
				this.accent3Field = value;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x00056FD7 File Offset: 0x000551D7
		// (set) Token: 0x060020FA RID: 8442 RVA: 0x00056FDF File Offset: 0x000551DF
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex accent4
		{
			get
			{
				return this.accent4Field;
			}
			set
			{
				this.accent4Field = value;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x00056FE8 File Offset: 0x000551E8
		// (set) Token: 0x060020FC RID: 8444 RVA: 0x00056FF0 File Offset: 0x000551F0
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex accent5
		{
			get
			{
				return this.accent5Field;
			}
			set
			{
				this.accent5Field = value;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x00056FF9 File Offset: 0x000551F9
		// (set) Token: 0x060020FE RID: 8446 RVA: 0x00057001 File Offset: 0x00055201
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex accent6
		{
			get
			{
				return this.accent6Field;
			}
			set
			{
				this.accent6Field = value;
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x060020FF RID: 8447 RVA: 0x0005700A File Offset: 0x0005520A
		// (set) Token: 0x06002100 RID: 8448 RVA: 0x00057012 File Offset: 0x00055212
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex hlink
		{
			get
			{
				return this.hlinkField;
			}
			set
			{
				this.hlinkField = value;
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06002101 RID: 8449 RVA: 0x0005701B File Offset: 0x0005521B
		// (set) Token: 0x06002102 RID: 8450 RVA: 0x00057023 File Offset: 0x00055223
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex folHlink
		{
			get
			{
				return this.folHlinkField;
			}
			set
			{
				this.folHlinkField = value;
			}
		}

		// Token: 0x0400195F RID: 6495
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001960 RID: 6496
		private global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex bg1Field;

		// Token: 0x04001961 RID: 6497
		private global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex tx1Field;

		// Token: 0x04001962 RID: 6498
		private global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex bg2Field;

		// Token: 0x04001963 RID: 6499
		private global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex tx2Field;

		// Token: 0x04001964 RID: 6500
		private global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex accent1Field;

		// Token: 0x04001965 RID: 6501
		private global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex accent2Field;

		// Token: 0x04001966 RID: 6502
		private global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex accent3Field;

		// Token: 0x04001967 RID: 6503
		private global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex accent4Field;

		// Token: 0x04001968 RID: 6504
		private global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex accent5Field;

		// Token: 0x04001969 RID: 6505
		private global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex accent6Field;

		// Token: 0x0400196A RID: 6506
		private global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex hlinkField;

		// Token: 0x0400196B RID: 6507
		private global::NPOI.OpenXmlFormats.Dml.ST_ColorSchemeIndex folHlinkField;
	}
}
