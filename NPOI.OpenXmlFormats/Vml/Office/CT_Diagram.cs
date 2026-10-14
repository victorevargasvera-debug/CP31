using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000221 RID: 545
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Diagram
	{
		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x0004287A File Offset: 0x00040A7A
		// (set) Token: 0x06001659 RID: 5721 RVA: 0x00042882 File Offset: 0x00040A82
		public global::NPOI.OpenXmlFormats.Vml.Office.CT_RelationTable relationtable
		{
			get
			{
				return this.relationtableField;
			}
			set
			{
				this.relationtableField = value;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x0004288B File Offset: 0x00040A8B
		// (set) Token: 0x0600165B RID: 5723 RVA: 0x00042893 File Offset: 0x00040A93
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:vml")]
		public global::NPOI.OpenXmlFormats.Vml.ST_Ext ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x0004289C File Offset: 0x00040A9C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x000428A7 File Offset: 0x00040AA7
		// (set) Token: 0x0600165E RID: 5726 RVA: 0x000428AF File Offset: 0x00040AAF
		[global::System.Xml.Serialization.XmlAttribute(DataType = "integer")]
		public string dgmstyle
		{
			get
			{
				return this.dgmstyleField;
			}
			set
			{
				this.dgmstyleField = value;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x000428B8 File Offset: 0x00040AB8
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x000428C0 File Offset: 0x00040AC0
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse autoformat
		{
			get
			{
				return this.autoformatField;
			}
			set
			{
				this.autoformatField = value;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x000428C9 File Offset: 0x00040AC9
		// (set) Token: 0x06001662 RID: 5730 RVA: 0x000428D1 File Offset: 0x00040AD1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool autoformatSpecified
		{
			get
			{
				return this.autoformatFieldSpecified;
			}
			set
			{
				this.autoformatFieldSpecified = value;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001663 RID: 5731 RVA: 0x000428DA File Offset: 0x00040ADA
		// (set) Token: 0x06001664 RID: 5732 RVA: 0x000428E2 File Offset: 0x00040AE2
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse reverse
		{
			get
			{
				return this.reverseField;
			}
			set
			{
				this.reverseField = value;
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x000428EB File Offset: 0x00040AEB
		// (set) Token: 0x06001666 RID: 5734 RVA: 0x000428F3 File Offset: 0x00040AF3
		[global::System.Xml.Serialization.XmlIgnore]
		public bool reverseSpecified
		{
			get
			{
				return this.reverseFieldSpecified;
			}
			set
			{
				this.reverseFieldSpecified = value;
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001667 RID: 5735 RVA: 0x000428FC File Offset: 0x00040AFC
		// (set) Token: 0x06001668 RID: 5736 RVA: 0x00042904 File Offset: 0x00040B04
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse autolayout
		{
			get
			{
				return this.autolayoutField;
			}
			set
			{
				this.autolayoutField = value;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x0004290D File Offset: 0x00040B0D
		// (set) Token: 0x0600166A RID: 5738 RVA: 0x00042915 File Offset: 0x00040B15
		[global::System.Xml.Serialization.XmlIgnore]
		public bool autolayoutSpecified
		{
			get
			{
				return this.autolayoutFieldSpecified;
			}
			set
			{
				this.autolayoutFieldSpecified = value;
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x0004291E File Offset: 0x00040B1E
		// (set) Token: 0x0600166C RID: 5740 RVA: 0x00042926 File Offset: 0x00040B26
		[global::System.Xml.Serialization.XmlAttribute(DataType = "integer")]
		public string dgmscalex
		{
			get
			{
				return this.dgmscalexField;
			}
			set
			{
				this.dgmscalexField = value;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x0004292F File Offset: 0x00040B2F
		// (set) Token: 0x0600166E RID: 5742 RVA: 0x00042937 File Offset: 0x00040B37
		[global::System.Xml.Serialization.XmlAttribute(DataType = "integer")]
		public string dgmscaley
		{
			get
			{
				return this.dgmscaleyField;
			}
			set
			{
				this.dgmscaleyField = value;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x00042940 File Offset: 0x00040B40
		// (set) Token: 0x06001670 RID: 5744 RVA: 0x00042948 File Offset: 0x00040B48
		[global::System.Xml.Serialization.XmlAttribute(DataType = "integer")]
		public string dgmfontsize
		{
			get
			{
				return this.dgmfontsizeField;
			}
			set
			{
				this.dgmfontsizeField = value;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001671 RID: 5745 RVA: 0x00042951 File Offset: 0x00040B51
		// (set) Token: 0x06001672 RID: 5746 RVA: 0x00042959 File Offset: 0x00040B59
		[global::System.Xml.Serialization.XmlAttribute]
		public string constrainbounds
		{
			get
			{
				return this.constrainboundsField;
			}
			set
			{
				this.constrainboundsField = value;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x00042962 File Offset: 0x00040B62
		// (set) Token: 0x06001674 RID: 5748 RVA: 0x0004296A File Offset: 0x00040B6A
		[global::System.Xml.Serialization.XmlAttribute(DataType = "integer")]
		public string dgmbasetextscale
		{
			get
			{
				return this.dgmbasetextscaleField;
			}
			set
			{
				this.dgmbasetextscaleField = value;
			}
		}

		// Token: 0x04001182 RID: 4482
		private global::NPOI.OpenXmlFormats.Vml.Office.CT_RelationTable relationtableField;

		// Token: 0x04001183 RID: 4483
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;

		// Token: 0x04001184 RID: 4484
		private string dgmstyleField;

		// Token: 0x04001185 RID: 4485
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse autoformatField;

		// Token: 0x04001186 RID: 4486
		private bool autoformatFieldSpecified;

		// Token: 0x04001187 RID: 4487
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse reverseField;

		// Token: 0x04001188 RID: 4488
		private bool reverseFieldSpecified;

		// Token: 0x04001189 RID: 4489
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse autolayoutField;

		// Token: 0x0400118A RID: 4490
		private bool autolayoutFieldSpecified;

		// Token: 0x0400118B RID: 4491
		private string dgmscalexField;

		// Token: 0x0400118C RID: 4492
		private string dgmscaleyField;

		// Token: 0x0400118D RID: 4493
		private string dgmfontsizeField;

		// Token: 0x0400118E RID: 4494
		private string constrainboundsField;

		// Token: 0x0400118F RID: 4495
		private string dgmbasetextscaleField;
	}
}
