using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Util;
using NPOI.OpenXmlFormats.Vml.Spreadsheet;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001D8 RID: 472
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Serializable]
	public class CT_H
	{
		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x0003C6D8 File Offset: 0x0003A8D8
		// (set) Token: 0x0600124B RID: 4683 RVA: 0x0003C6E0 File Offset: 0x0003A8E0
		[global::System.Xml.Serialization.XmlAttribute]
		public string position
		{
			get
			{
				return this.positionField;
			}
			set
			{
				this.positionField = value;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x0003C6E9 File Offset: 0x0003A8E9
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x0003C6F1 File Offset: 0x0003A8F1
		[global::System.Xml.Serialization.XmlAttribute]
		public string polar
		{
			get
			{
				return this.polarField;
			}
			set
			{
				this.polarField = value;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x0003C6FA File Offset: 0x0003A8FA
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x0003C702 File Offset: 0x0003A902
		[global::System.Xml.Serialization.XmlAttribute]
		public string map
		{
			get
			{
				return this.mapField;
			}
			set
			{
				this.mapField = value;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x0003C70B File Offset: 0x0003A90B
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x0003C713 File Offset: 0x0003A913
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse invx
		{
			get
			{
				return this.invxField;
			}
			set
			{
				this.invxField = value;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x0003C71C File Offset: 0x0003A91C
		// (set) Token: 0x06001253 RID: 4691 RVA: 0x0003C724 File Offset: 0x0003A924
		[global::System.Xml.Serialization.XmlIgnore]
		public bool invxSpecified
		{
			get
			{
				return this.invxFieldSpecified;
			}
			set
			{
				this.invxFieldSpecified = value;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x0003C72D File Offset: 0x0003A92D
		// (set) Token: 0x06001255 RID: 4693 RVA: 0x0003C735 File Offset: 0x0003A935
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse invy
		{
			get
			{
				return this.invyField;
			}
			set
			{
				this.invyField = value;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x0003C73E File Offset: 0x0003A93E
		// (set) Token: 0x06001257 RID: 4695 RVA: 0x0003C746 File Offset: 0x0003A946
		[global::System.Xml.Serialization.XmlIgnore]
		public bool invySpecified
		{
			get
			{
				return this.invyFieldSpecified;
			}
			set
			{
				this.invyFieldSpecified = value;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x0003C74F File Offset: 0x0003A94F
		// (set) Token: 0x06001259 RID: 4697 RVA: 0x0003C757 File Offset: 0x0003A957
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank @switch
		{
			get
			{
				return this.switchField;
			}
			set
			{
				this.switchField = value;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x0003C760 File Offset: 0x0003A960
		// (set) Token: 0x0600125B RID: 4699 RVA: 0x0003C768 File Offset: 0x0003A968
		[global::System.Xml.Serialization.XmlIgnore]
		public bool switchSpecified
		{
			get
			{
				return this.switchFieldSpecified;
			}
			set
			{
				this.switchFieldSpecified = value;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x0003C771 File Offset: 0x0003A971
		// (set) Token: 0x0600125D RID: 4701 RVA: 0x0003C779 File Offset: 0x0003A979
		[global::System.Xml.Serialization.XmlAttribute]
		public string xrange
		{
			get
			{
				return this.xrangeField;
			}
			set
			{
				this.xrangeField = value;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x0003C782 File Offset: 0x0003A982
		// (set) Token: 0x0600125F RID: 4703 RVA: 0x0003C78A File Offset: 0x0003A98A
		[global::System.Xml.Serialization.XmlAttribute]
		public string yrange
		{
			get
			{
				return this.yrangeField;
			}
			set
			{
				this.yrangeField = value;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x0003C793 File Offset: 0x0003A993
		// (set) Token: 0x06001261 RID: 4705 RVA: 0x0003C79B File Offset: 0x0003A99B
		[global::System.Xml.Serialization.XmlAttribute]
		public string radiusrange
		{
			get
			{
				return this.radiusrangeField;
			}
			set
			{
				this.radiusrangeField = value;
			}
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x0003C7A4 File Offset: 0x0003A9A4
		public static global::NPOI.OpenXmlFormats.Vml.CT_H Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.CT_H ct_H = new global::NPOI.OpenXmlFormats.Vml.CT_H();
			ct_H.position = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["position"]);
			ct_H.polar = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["polar"]);
			ct_H.map = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["map"]);
			if (node.Attributes["invx"] != null)
			{
				ct_H.invx = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["invx"]);
			}
			if (node.Attributes["invy"] != null)
			{
				ct_H.invy = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["invy"]);
			}
			if (node.Attributes["switch"] != null)
			{
				ct_H.@switch = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalseBlank(node.Attributes["switch"]);
			}
			ct_H.xrange = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["xrange"]);
			ct_H.yrange = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["yrange"]);
			ct_H.radiusrange = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["radiusrange"]);
			return ct_H;
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x0003C8E8 File Offset: 0x0003AAE8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<v:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "position", this.position);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "polar", this.polar);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "map", this.map);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "invx", this.invx);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "invy", this.invy);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "switch", this.@switch);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "xrange", this.xrange);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "yrange", this.yrange);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "radiusrange", this.radiusrange);
			sw.Write(">");
			sw.Write(string.Format("</v:{0}>", nodeName));
		}

		// Token: 0x04000E11 RID: 3601
		private string positionField;

		// Token: 0x04000E12 RID: 3602
		private string polarField;

		// Token: 0x04000E13 RID: 3603
		private string mapField;

		// Token: 0x04000E14 RID: 3604
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse invxField;

		// Token: 0x04000E15 RID: 3605
		private bool invxFieldSpecified;

		// Token: 0x04000E16 RID: 3606
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse invyField;

		// Token: 0x04000E17 RID: 3607
		private bool invyFieldSpecified;

		// Token: 0x04000E18 RID: 3608
		private global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank switchField;

		// Token: 0x04000E19 RID: 3609
		private bool switchFieldSpecified;

		// Token: 0x04000E1A RID: 3610
		private string xrangeField;

		// Token: 0x04000E1B RID: 3611
		private string yrangeField;

		// Token: 0x04000E1C RID: 3612
		private string radiusrangeField;
	}
}
