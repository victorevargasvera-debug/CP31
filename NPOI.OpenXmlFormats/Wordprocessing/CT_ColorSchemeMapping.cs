using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000197 RID: 407
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ColorSchemeMapping
	{
		// Token: 0x06000F29 RID: 3881 RVA: 0x00031C68 File Offset: 0x0002FE68
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_ColorSchemeMapping Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_ColorSchemeMapping ct_ColorSchemeMapping = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_ColorSchemeMapping();
			if (node.Attributes["w:bg1"] != null)
			{
				ct_ColorSchemeMapping.bg1 = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex), node.Attributes["w:bg1"].Value);
			}
			if (node.Attributes["w:t1"] != null)
			{
				ct_ColorSchemeMapping.t1 = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex), node.Attributes["w:t1"].Value);
			}
			if (node.Attributes["w:bg2"] != null)
			{
				ct_ColorSchemeMapping.bg2 = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex), node.Attributes["w:bg2"].Value);
			}
			if (node.Attributes["w:t2"] != null)
			{
				ct_ColorSchemeMapping.t2 = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex), node.Attributes["w:t2"].Value);
			}
			if (node.Attributes["w:accent1"] != null)
			{
				ct_ColorSchemeMapping.accent1 = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex), node.Attributes["w:accent1"].Value);
			}
			if (node.Attributes["w:accent2"] != null)
			{
				ct_ColorSchemeMapping.accent2 = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex), node.Attributes["w:accent2"].Value);
			}
			if (node.Attributes["w:accent3"] != null)
			{
				ct_ColorSchemeMapping.accent3 = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex), node.Attributes["w:accent3"].Value);
			}
			if (node.Attributes["w:accent4"] != null)
			{
				ct_ColorSchemeMapping.accent4 = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex), node.Attributes["w:accent4"].Value);
			}
			if (node.Attributes["w:accent5"] != null)
			{
				ct_ColorSchemeMapping.accent5 = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex), node.Attributes["w:accent5"].Value);
			}
			if (node.Attributes["w:accent6"] != null)
			{
				ct_ColorSchemeMapping.accent6 = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex), node.Attributes["w:accent6"].Value);
			}
			if (node.Attributes["w:hyperlink"] != null)
			{
				ct_ColorSchemeMapping.hyperlink = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex), node.Attributes["w:hyperlink"].Value);
			}
			if (node.Attributes["w:followedHyperlink"] != null)
			{
				ct_ColorSchemeMapping.followedHyperlink = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex), node.Attributes["w:followedHyperlink"].Value);
			}
			return ct_ColorSchemeMapping;
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00031F90 File Offset: 0x00030190
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:bg1", this.bg1.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:t1", this.t1.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:bg2", this.bg2.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:t2", this.t2.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:accent1", this.accent1.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:accent2", this.accent2.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:accent3", this.accent3.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:accent4", this.accent4.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:accent5", this.accent5.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:accent6", this.accent6.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:hyperlink", this.hyperlink.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:followedHyperlink", this.followedHyperlink.ToString());
			sw.Write("/>");
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x0003212D File Offset: 0x0003032D
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x00032135 File Offset: 0x00030335
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex bg1
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

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x0003213E File Offset: 0x0003033E
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x00032146 File Offset: 0x00030346
		[global::System.Xml.Serialization.XmlIgnore]
		public bool bg1Specified
		{
			get
			{
				return this.bg1FieldSpecified;
			}
			set
			{
				this.bg1FieldSpecified = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x0003214F File Offset: 0x0003034F
		// (set) Token: 0x06000F30 RID: 3888 RVA: 0x00032157 File Offset: 0x00030357
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex t1
		{
			get
			{
				return this.t1Field;
			}
			set
			{
				this.t1Field = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00032160 File Offset: 0x00030360
		// (set) Token: 0x06000F32 RID: 3890 RVA: 0x00032168 File Offset: 0x00030368
		[global::System.Xml.Serialization.XmlIgnore]
		public bool t1Specified
		{
			get
			{
				return this.t1FieldSpecified;
			}
			set
			{
				this.t1FieldSpecified = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00032171 File Offset: 0x00030371
		// (set) Token: 0x06000F34 RID: 3892 RVA: 0x00032179 File Offset: 0x00030379
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex bg2
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

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x00032182 File Offset: 0x00030382
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x0003218A File Offset: 0x0003038A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool bg2Specified
		{
			get
			{
				return this.bg2FieldSpecified;
			}
			set
			{
				this.bg2FieldSpecified = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x00032193 File Offset: 0x00030393
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x0003219B File Offset: 0x0003039B
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex t2
		{
			get
			{
				return this.t2Field;
			}
			set
			{
				this.t2Field = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x000321A4 File Offset: 0x000303A4
		// (set) Token: 0x06000F3A RID: 3898 RVA: 0x000321AC File Offset: 0x000303AC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool t2Specified
		{
			get
			{
				return this.t2FieldSpecified;
			}
			set
			{
				this.t2FieldSpecified = value;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x000321B5 File Offset: 0x000303B5
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x000321BD File Offset: 0x000303BD
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex accent1
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

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x000321C6 File Offset: 0x000303C6
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x000321CE File Offset: 0x000303CE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool accent1Specified
		{
			get
			{
				return this.accent1FieldSpecified;
			}
			set
			{
				this.accent1FieldSpecified = value;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x000321D7 File Offset: 0x000303D7
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x000321DF File Offset: 0x000303DF
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex accent2
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

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x000321E8 File Offset: 0x000303E8
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x000321F0 File Offset: 0x000303F0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool accent2Specified
		{
			get
			{
				return this.accent2FieldSpecified;
			}
			set
			{
				this.accent2FieldSpecified = value;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x000321F9 File Offset: 0x000303F9
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x00032201 File Offset: 0x00030401
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex accent3
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

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x0003220A File Offset: 0x0003040A
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x00032212 File Offset: 0x00030412
		[global::System.Xml.Serialization.XmlIgnore]
		public bool accent3Specified
		{
			get
			{
				return this.accent3FieldSpecified;
			}
			set
			{
				this.accent3FieldSpecified = value;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x0003221B File Offset: 0x0003041B
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x00032223 File Offset: 0x00030423
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex accent4
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

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x0003222C File Offset: 0x0003042C
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x00032234 File Offset: 0x00030434
		[global::System.Xml.Serialization.XmlIgnore]
		public bool accent4Specified
		{
			get
			{
				return this.accent4FieldSpecified;
			}
			set
			{
				this.accent4FieldSpecified = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x0003223D File Offset: 0x0003043D
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x00032245 File Offset: 0x00030445
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex accent5
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

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x0003224E File Offset: 0x0003044E
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x00032256 File Offset: 0x00030456
		[global::System.Xml.Serialization.XmlIgnore]
		public bool accent5Specified
		{
			get
			{
				return this.accent5FieldSpecified;
			}
			set
			{
				this.accent5FieldSpecified = value;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x0003225F File Offset: 0x0003045F
		// (set) Token: 0x06000F50 RID: 3920 RVA: 0x00032267 File Offset: 0x00030467
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex accent6
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

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x00032270 File Offset: 0x00030470
		// (set) Token: 0x06000F52 RID: 3922 RVA: 0x00032278 File Offset: 0x00030478
		[global::System.Xml.Serialization.XmlIgnore]
		public bool accent6Specified
		{
			get
			{
				return this.accent6FieldSpecified;
			}
			set
			{
				this.accent6FieldSpecified = value;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x00032281 File Offset: 0x00030481
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x00032289 File Offset: 0x00030489
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex hyperlink
		{
			get
			{
				return this.hyperlinkField;
			}
			set
			{
				this.hyperlinkField = value;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x00032292 File Offset: 0x00030492
		// (set) Token: 0x06000F56 RID: 3926 RVA: 0x0003229A File Offset: 0x0003049A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hyperlinkSpecified
		{
			get
			{
				return this.hyperlinkFieldSpecified;
			}
			set
			{
				this.hyperlinkFieldSpecified = value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x000322A3 File Offset: 0x000304A3
		// (set) Token: 0x06000F58 RID: 3928 RVA: 0x000322AB File Offset: 0x000304AB
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex followedHyperlink
		{
			get
			{
				return this.followedHyperlinkField;
			}
			set
			{
				this.followedHyperlinkField = value;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x000322B4 File Offset: 0x000304B4
		// (set) Token: 0x06000F5A RID: 3930 RVA: 0x000322BC File Offset: 0x000304BC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool followedHyperlinkSpecified
		{
			get
			{
				return this.followedHyperlinkFieldSpecified;
			}
			set
			{
				this.followedHyperlinkFieldSpecified = value;
			}
		}

		// Token: 0x04000C6D RID: 3181
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex bg1Field;

		// Token: 0x04000C6E RID: 3182
		private bool bg1FieldSpecified;

		// Token: 0x04000C6F RID: 3183
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex t1Field;

		// Token: 0x04000C70 RID: 3184
		private bool t1FieldSpecified;

		// Token: 0x04000C71 RID: 3185
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex bg2Field;

		// Token: 0x04000C72 RID: 3186
		private bool bg2FieldSpecified;

		// Token: 0x04000C73 RID: 3187
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex t2Field;

		// Token: 0x04000C74 RID: 3188
		private bool t2FieldSpecified;

		// Token: 0x04000C75 RID: 3189
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex accent1Field;

		// Token: 0x04000C76 RID: 3190
		private bool accent1FieldSpecified;

		// Token: 0x04000C77 RID: 3191
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex accent2Field;

		// Token: 0x04000C78 RID: 3192
		private bool accent2FieldSpecified;

		// Token: 0x04000C79 RID: 3193
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex accent3Field;

		// Token: 0x04000C7A RID: 3194
		private bool accent3FieldSpecified;

		// Token: 0x04000C7B RID: 3195
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex accent4Field;

		// Token: 0x04000C7C RID: 3196
		private bool accent4FieldSpecified;

		// Token: 0x04000C7D RID: 3197
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex accent5Field;

		// Token: 0x04000C7E RID: 3198
		private bool accent5FieldSpecified;

		// Token: 0x04000C7F RID: 3199
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex accent6Field;

		// Token: 0x04000C80 RID: 3200
		private bool accent6FieldSpecified;

		// Token: 0x04000C81 RID: 3201
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex hyperlinkField;

		// Token: 0x04000C82 RID: 3202
		private bool hyperlinkFieldSpecified;

		// Token: 0x04000C83 RID: 3203
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_ColorSchemeIndex followedHyperlinkField;

		// Token: 0x04000C84 RID: 3204
		private bool followedHyperlinkFieldSpecified;
	}
}
