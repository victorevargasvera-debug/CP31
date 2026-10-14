using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Util;
using NPOI.OpenXmlFormats.Vml.Office;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001DA RID: 474
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Path
	{
		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x0003CF0B File Offset: 0x0003B10B
		// (set) Token: 0x06001295 RID: 4757 RVA: 0x0003CF13 File Offset: 0x0003B113
		[global::System.Xml.Serialization.XmlAttribute]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x0003CF1C File Offset: 0x0003B11C
		// (set) Token: 0x06001297 RID: 4759 RVA: 0x0003CF24 File Offset: 0x0003B124
		[global::System.Xml.Serialization.XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_ConnectType connecttype
		{
			get
			{
				return this.connecttypeField;
			}
			set
			{
				this.connecttypeField = value;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x0003CF2D File Offset: 0x0003B12D
		// (set) Token: 0x06001299 RID: 4761 RVA: 0x0003CF35 File Offset: 0x0003B135
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

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x0003CF3E File Offset: 0x0003B13E
		// (set) Token: 0x0600129B RID: 4763 RVA: 0x0003CF46 File Offset: 0x0003B146
		[global::System.Xml.Serialization.XmlAttribute]
		public string limo
		{
			get
			{
				return this.limoField;
			}
			set
			{
				this.limoField = value;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x0003CF4F File Offset: 0x0003B14F
		// (set) Token: 0x0600129D RID: 4765 RVA: 0x0003CF57 File Offset: 0x0003B157
		[global::System.Xml.Serialization.XmlAttribute]
		public string textboxrect
		{
			get
			{
				return this.textboxrectField;
			}
			set
			{
				this.textboxrectField = value;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x0003CF60 File Offset: 0x0003B160
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x0003CF68 File Offset: 0x0003B168
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse fillok
		{
			get
			{
				return this.fillokField;
			}
			set
			{
				this.fillokField = value;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x0003CF71 File Offset: 0x0003B171
		// (set) Token: 0x060012A1 RID: 4769 RVA: 0x0003CF79 File Offset: 0x0003B179
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fillokSpecified
		{
			get
			{
				return this.fillokFieldSpecified;
			}
			set
			{
				this.fillokFieldSpecified = value;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x0003CF82 File Offset: 0x0003B182
		// (set) Token: 0x060012A3 RID: 4771 RVA: 0x0003CF8A File Offset: 0x0003B18A
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse strokeok
		{
			get
			{
				return this.strokeokField;
			}
			set
			{
				this.strokeokField = value;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x0003CF93 File Offset: 0x0003B193
		// (set) Token: 0x060012A5 RID: 4773 RVA: 0x0003CF9B File Offset: 0x0003B19B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool strokeokSpecified
		{
			get
			{
				return this.strokeokFieldSpecified;
			}
			set
			{
				this.strokeokFieldSpecified = value;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x0003CFA4 File Offset: 0x0003B1A4
		// (set) Token: 0x060012A7 RID: 4775 RVA: 0x0003CFAC File Offset: 0x0003B1AC
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse shadowok
		{
			get
			{
				return this.shadowokField;
			}
			set
			{
				this.shadowokField = value;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x0003CFB5 File Offset: 0x0003B1B5
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x0003CFBD File Offset: 0x0003B1BD
		[global::System.Xml.Serialization.XmlIgnore]
		public bool shadowokSpecified
		{
			get
			{
				return this.shadowokFieldSpecified;
			}
			set
			{
				this.shadowokFieldSpecified = value;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x0003CFC6 File Offset: 0x0003B1C6
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x0003CFCE File Offset: 0x0003B1CE
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse arrowok
		{
			get
			{
				return this.arrowokField;
			}
			set
			{
				this.arrowokField = value;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x0003CFD7 File Offset: 0x0003B1D7
		// (set) Token: 0x060012AD RID: 4781 RVA: 0x0003CFDF File Offset: 0x0003B1DF
		[global::System.Xml.Serialization.XmlIgnore]
		public bool arrowokSpecified
		{
			get
			{
				return this.arrowokFieldSpecified;
			}
			set
			{
				this.arrowokFieldSpecified = value;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x0003CFE8 File Offset: 0x0003B1E8
		// (set) Token: 0x060012AF RID: 4783 RVA: 0x0003CFF0 File Offset: 0x0003B1F0
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse gradientshapeok
		{
			get
			{
				return this.gradientshapeokField;
			}
			set
			{
				this.gradientshapeokField = value;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x0003CFF9 File Offset: 0x0003B1F9
		// (set) Token: 0x060012B1 RID: 4785 RVA: 0x0003D001 File Offset: 0x0003B201
		[global::System.Xml.Serialization.XmlIgnore]
		public bool gradientshapeokSpecified
		{
			get
			{
				return this.gradientshapeokFieldSpecified;
			}
			set
			{
				this.gradientshapeokFieldSpecified = value;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x0003D00A File Offset: 0x0003B20A
		// (set) Token: 0x060012B3 RID: 4787 RVA: 0x0003D012 File Offset: 0x0003B212
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse textpathok
		{
			get
			{
				return this.textpathokField;
			}
			set
			{
				this.textpathokField = value;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x0003D01B File Offset: 0x0003B21B
		// (set) Token: 0x060012B5 RID: 4789 RVA: 0x0003D023 File Offset: 0x0003B223
		[global::System.Xml.Serialization.XmlIgnore]
		public bool textpathokSpecified
		{
			get
			{
				return this.textpathokFieldSpecified;
			}
			set
			{
				this.textpathokFieldSpecified = value;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x0003D02C File Offset: 0x0003B22C
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x0003D034 File Offset: 0x0003B234
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse insetpenok
		{
			get
			{
				return this.insetpenokField;
			}
			set
			{
				this.insetpenokField = value;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x0003D03D File Offset: 0x0003B23D
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x0003D045 File Offset: 0x0003B245
		[global::System.Xml.Serialization.XmlIgnore]
		public bool insetpenokSpecified
		{
			get
			{
				return this.insetpenokFieldSpecified;
			}
			set
			{
				this.insetpenokFieldSpecified = value;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x0003D04E File Offset: 0x0003B24E
		// (set) Token: 0x060012BB RID: 4795 RVA: 0x0003D056 File Offset: 0x0003B256
		[global::System.Xml.Serialization.XmlAttribute]
		public string connectlocs
		{
			get
			{
				return this.connectlocsField;
			}
			set
			{
				this.connectlocsField = value;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x0003D05F File Offset: 0x0003B25F
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x0003D067 File Offset: 0x0003B267
		[global::System.Xml.Serialization.XmlIgnore]
		public bool connectlocsSpecified
		{
			get
			{
				return this.connectlocsFieldSpecified;
			}
			set
			{
				this.connectlocsFieldSpecified = value;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x0003D070 File Offset: 0x0003B270
		// (set) Token: 0x060012BF RID: 4799 RVA: 0x0003D078 File Offset: 0x0003B278
		[global::System.Xml.Serialization.XmlAttribute]
		public string connectangles
		{
			get
			{
				return this.connectanglesField;
			}
			set
			{
				this.connectanglesField = value;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x0003D081 File Offset: 0x0003B281
		// (set) Token: 0x060012C1 RID: 4801 RVA: 0x0003D089 File Offset: 0x0003B289
		[global::System.Xml.Serialization.XmlIgnore]
		public bool connectanglesSpecified
		{
			get
			{
				return this.connectanglesFieldSpecified;
			}
			set
			{
				this.connectanglesFieldSpecified = value;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x0003D092 File Offset: 0x0003B292
		// (set) Token: 0x060012C3 RID: 4803 RVA: 0x0003D09A File Offset: 0x0003B29A
		[global::System.Xml.Serialization.XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse extrusionok
		{
			get
			{
				return this.extrusionokField;
			}
			set
			{
				this.extrusionokField = value;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x0003D0A3 File Offset: 0x0003B2A3
		// (set) Token: 0x060012C5 RID: 4805 RVA: 0x0003D0AB File Offset: 0x0003B2AB
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extrusionokSpecified
		{
			get
			{
				return this.extrusionokFieldSpecified;
			}
			set
			{
				this.extrusionokFieldSpecified = value;
			}
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0003D0B4 File Offset: 0x0003B2B4
		public static global::NPOI.OpenXmlFormats.Vml.CT_Path Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.CT_Path ct_Path = new global::NPOI.OpenXmlFormats.Vml.CT_Path();
			ct_Path.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id"]);
			if (node.Attributes["o:connecttype"] != null)
			{
				ct_Path.connecttype = (global::NPOI.OpenXmlFormats.Vml.Office.ST_ConnectType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.Office.ST_ConnectType), node.Attributes["o:connecttype"].Value);
			}
			ct_Path.v = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["v"]);
			ct_Path.limo = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["limo"]);
			ct_Path.textboxrect = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["textboxrect"]);
			if (node.Attributes["fillok"] != null)
			{
				ct_Path.fillok = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["fillok"]);
			}
			if (node.Attributes["strokeok"] != null)
			{
				ct_Path.strokeok = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["strokeok"]);
			}
			if (node.Attributes["shadowok"] != null)
			{
				ct_Path.shadowok = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["shadowok"]);
			}
			if (node.Attributes["arrowok"] != null)
			{
				ct_Path.arrowok = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["arrowok"]);
			}
			if (node.Attributes["gradientshapeok"] != null)
			{
				ct_Path.gradientshapeok = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["gradientshapeok"]);
			}
			if (node.Attributes["textpathok"] != null)
			{
				ct_Path.textpathok = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["textpathok"]);
			}
			if (node.Attributes["insetpenok"] != null)
			{
				ct_Path.insetpenok = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["insetpenok"]);
			}
			ct_Path.connectlocs = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["connectlocs"]);
			ct_Path.connectangles = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["connectangles"]);
			if (node.Attributes["o:extrusionok"] != null)
			{
				ct_Path.extrusionok = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["o:extrusionok"]);
			}
			return ct_Path;
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0003D318 File Offset: 0x0003B518
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<v:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "o:connecttype", this.connecttype.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "v", this.v);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "limo", this.limo);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "textboxrect", this.textboxrect);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "fillok", this.fillok);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "strokeok", this.strokeok);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "shadowok", this.shadowok);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "arrowok", this.arrowok);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "gradientshapeok", this.gradientshapeok);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "textpathok", this.textpathok);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "insetpenok", this.insetpenok);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "connectlocs", this.connectlocs);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "connectangles", this.connectangles);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "o:extrusionok", this.extrusionok, false);
			sw.Write(">");
			sw.Write(string.Format("</v:{0}>", nodeName));
		}

		// Token: 0x04000E33 RID: 3635
		private string idField;

		// Token: 0x04000E34 RID: 3636
		private string vField;

		// Token: 0x04000E35 RID: 3637
		private string limoField;

		// Token: 0x04000E36 RID: 3638
		private string textboxrectField;

		// Token: 0x04000E37 RID: 3639
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse fillokField;

		// Token: 0x04000E38 RID: 3640
		private bool fillokFieldSpecified;

		// Token: 0x04000E39 RID: 3641
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse strokeokField;

		// Token: 0x04000E3A RID: 3642
		private bool strokeokFieldSpecified;

		// Token: 0x04000E3B RID: 3643
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse shadowokField;

		// Token: 0x04000E3C RID: 3644
		private bool shadowokFieldSpecified;

		// Token: 0x04000E3D RID: 3645
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse arrowokField;

		// Token: 0x04000E3E RID: 3646
		private bool arrowokFieldSpecified;

		// Token: 0x04000E3F RID: 3647
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse gradientshapeokField;

		// Token: 0x04000E40 RID: 3648
		private bool gradientshapeokFieldSpecified;

		// Token: 0x04000E41 RID: 3649
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse textpathokField;

		// Token: 0x04000E42 RID: 3650
		private bool textpathokFieldSpecified;

		// Token: 0x04000E43 RID: 3651
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse insetpenokField;

		// Token: 0x04000E44 RID: 3652
		private bool insetpenokFieldSpecified;

		// Token: 0x04000E45 RID: 3653
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_ConnectType connecttypeField;

		// Token: 0x04000E46 RID: 3654
		private string connectlocsField;

		// Token: 0x04000E47 RID: 3655
		private bool connectlocsFieldSpecified;

		// Token: 0x04000E48 RID: 3656
		private string connectanglesField;

		// Token: 0x04000E49 RID: 3657
		private bool connectanglesFieldSpecified;

		// Token: 0x04000E4A RID: 3658
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse extrusionokField;

		// Token: 0x04000E4B RID: 3659
		private bool extrusionokFieldSpecified;
	}
}
