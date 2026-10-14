using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Vml.Presentation;
using NPOI.OpenXmlFormats.Vml.Spreadsheet;
using NPOI.OpenXmlFormats.Vml.Wordprocessing;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001E9 RID: 489
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Arc
	{
		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x0003F8B0 File Offset: 0x0003DAB0
		// (set) Token: 0x060013B6 RID: 5046 RVA: 0x0003F8B8 File Offset: 0x0003DAB8
		[global::System.Xml.Serialization.XmlElement("path")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Path> path
		{
			get
			{
				return this.pathField;
			}
			set
			{
				this.pathField = value;
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x0003F8C1 File Offset: 0x0003DAC1
		// (set) Token: 0x060013B8 RID: 5048 RVA: 0x0003F8C9 File Offset: 0x0003DAC9
		[global::System.Xml.Serialization.XmlElement("formulas")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Formulas> formulas
		{
			get
			{
				return this.formulasField;
			}
			set
			{
				this.formulasField = value;
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x0003F8D2 File Offset: 0x0003DAD2
		// (set) Token: 0x060013BA RID: 5050 RVA: 0x0003F8DA File Offset: 0x0003DADA
		[global::System.Xml.Serialization.XmlElement("handles")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Handles> handles
		{
			get
			{
				return this.handlesField;
			}
			set
			{
				this.handlesField = value;
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x0003F8E3 File Offset: 0x0003DAE3
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x0003F8EB File Offset: 0x0003DAEB
		[global::System.Xml.Serialization.XmlElement("fill")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Fill> fill
		{
			get
			{
				return this.fillField;
			}
			set
			{
				this.fillField = value;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x0003F8F4 File Offset: 0x0003DAF4
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x0003F8FC File Offset: 0x0003DAFC
		[global::System.Xml.Serialization.XmlElement("stroke")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Stroke> stroke
		{
			get
			{
				return this.strokeField;
			}
			set
			{
				this.strokeField = value;
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x0003F905 File Offset: 0x0003DB05
		// (set) Token: 0x060013C0 RID: 5056 RVA: 0x0003F90D File Offset: 0x0003DB0D
		[global::System.Xml.Serialization.XmlElement("shadow")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Shadow> shadow
		{
			get
			{
				return this.shadowField;
			}
			set
			{
				this.shadowField = value;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x0003F916 File Offset: 0x0003DB16
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x0003F91E File Offset: 0x0003DB1E
		[global::System.Xml.Serialization.XmlElement("textbox")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Textbox> textbox
		{
			get
			{
				return this.textboxField;
			}
			set
			{
				this.textboxField = value;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x0003F927 File Offset: 0x0003DB27
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x0003F92F File Offset: 0x0003DB2F
		[global::System.Xml.Serialization.XmlElement("textpath")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_TextPath> textpath
		{
			get
			{
				return this.textpathField;
			}
			set
			{
				this.textpathField = value;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x0003F938 File Offset: 0x0003DB38
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x0003F940 File Offset: 0x0003DB40
		[global::System.Xml.Serialization.XmlElement("imagedata")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_ImageData> imagedata
		{
			get
			{
				return this.imagedataField;
			}
			set
			{
				this.imagedataField = value;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x0003F949 File Offset: 0x0003DB49
		// (set) Token: 0x060013C8 RID: 5064 RVA: 0x0003F951 File Offset: 0x0003DB51
		[global::System.Xml.Serialization.XmlElement("wrap", Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap> wrap
		{
			get
			{
				return this.wrapField;
			}
			set
			{
				this.wrapField = value;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x0003F95A File Offset: 0x0003DB5A
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x0003F962 File Offset: 0x0003DB62
		[global::System.Xml.Serialization.XmlElement("anchorlock", Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_AnchorLock> anchorlock
		{
			get
			{
				return this.anchorlockField;
			}
			set
			{
				this.anchorlockField = value;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x0003F96B File Offset: 0x0003DB6B
		// (set) Token: 0x060013CC RID: 5068 RVA: 0x0003F973 File Offset: 0x0003DB73
		[global::System.Xml.Serialization.XmlElement("bordertop", Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> bordertop
		{
			get
			{
				return this.bordertopField;
			}
			set
			{
				this.bordertopField = value;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x0003F97C File Offset: 0x0003DB7C
		// (set) Token: 0x060013CE RID: 5070 RVA: 0x0003F984 File Offset: 0x0003DB84
		[global::System.Xml.Serialization.XmlElement("borderbottom", Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderbottom
		{
			get
			{
				return this.borderbottomField;
			}
			set
			{
				this.borderbottomField = value;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x0003F98D File Offset: 0x0003DB8D
		// (set) Token: 0x060013D0 RID: 5072 RVA: 0x0003F995 File Offset: 0x0003DB95
		[global::System.Xml.Serialization.XmlElement("borderleft", Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderleft
		{
			get
			{
				return this.borderleftField;
			}
			set
			{
				this.borderleftField = value;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x0003F99E File Offset: 0x0003DB9E
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x0003F9A6 File Offset: 0x0003DBA6
		[global::System.Xml.Serialization.XmlElement("borderright", Namespace = "urn:schemas-microsoft-com:office:word")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderright
		{
			get
			{
				return this.borderrightField;
			}
			set
			{
				this.borderrightField = value;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x0003F9AF File Offset: 0x0003DBAF
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x0003F9B7 File Offset: 0x0003DBB7
		[global::System.Xml.Serialization.XmlElement("ClientData", Namespace = "urn:schemas-microsoft-com:office:excel")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData> ClientData
		{
			get
			{
				return this.clientDataField;
			}
			set
			{
				this.clientDataField = value;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x0003F9C0 File Offset: 0x0003DBC0
		// (set) Token: 0x060013D6 RID: 5078 RVA: 0x0003F9C8 File Offset: 0x0003DBC8
		[global::System.Xml.Serialization.XmlElement("textdata", Namespace = "urn:schemas-microsoft-com:office:powerpoint")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel> textdata
		{
			get
			{
				return this.textdataField;
			}
			set
			{
				this.textdataField = value;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0003F9D1 File Offset: 0x0003DBD1
		// (set) Token: 0x060013D8 RID: 5080 RVA: 0x0003F9D9 File Offset: 0x0003DBD9
		[global::System.Xml.Serialization.XmlAttribute]
		public decimal startAngle
		{
			get
			{
				return this.startAngleField;
			}
			set
			{
				this.startAngleField = value;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x0003F9E2 File Offset: 0x0003DBE2
		// (set) Token: 0x060013DA RID: 5082 RVA: 0x0003F9EA File Offset: 0x0003DBEA
		[global::System.Xml.Serialization.XmlIgnore]
		public bool startAngleSpecified
		{
			get
			{
				return this.startAngleFieldSpecified;
			}
			set
			{
				this.startAngleFieldSpecified = value;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x0003F9F3 File Offset: 0x0003DBF3
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x0003F9FB File Offset: 0x0003DBFB
		[global::System.Xml.Serialization.XmlAttribute]
		public decimal endAngle
		{
			get
			{
				return this.endAngleField;
			}
			set
			{
				this.endAngleField = value;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x0003FA04 File Offset: 0x0003DC04
		// (set) Token: 0x060013DE RID: 5086 RVA: 0x0003FA0C File Offset: 0x0003DC0C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool endAngleSpecified
		{
			get
			{
				return this.endAngleFieldSpecified;
			}
			set
			{
				this.endAngleFieldSpecified = value;
			}
		}

		// Token: 0x04000EE7 RID: 3815
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Path> pathField;

		// Token: 0x04000EE8 RID: 3816
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Formulas> formulasField;

		// Token: 0x04000EE9 RID: 3817
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Handles> handlesField;

		// Token: 0x04000EEA RID: 3818
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Fill> fillField;

		// Token: 0x04000EEB RID: 3819
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Stroke> strokeField;

		// Token: 0x04000EEC RID: 3820
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Shadow> shadowField;

		// Token: 0x04000EED RID: 3821
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Textbox> textboxField;

		// Token: 0x04000EEE RID: 3822
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_TextPath> textpathField;

		// Token: 0x04000EEF RID: 3823
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_ImageData> imagedataField;

		// Token: 0x04000EF0 RID: 3824
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap> wrapField;

		// Token: 0x04000EF1 RID: 3825
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_AnchorLock> anchorlockField;

		// Token: 0x04000EF2 RID: 3826
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> bordertopField;

		// Token: 0x04000EF3 RID: 3827
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderbottomField;

		// Token: 0x04000EF4 RID: 3828
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderleftField;

		// Token: 0x04000EF5 RID: 3829
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderrightField;

		// Token: 0x04000EF6 RID: 3830
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData> clientDataField;

		// Token: 0x04000EF7 RID: 3831
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel> textdataField;

		// Token: 0x04000EF8 RID: 3832
		private decimal startAngleField;

		// Token: 0x04000EF9 RID: 3833
		private bool startAngleFieldSpecified;

		// Token: 0x04000EFA RID: 3834
		private decimal endAngleField;

		// Token: 0x04000EFB RID: 3835
		private bool endAngleFieldSpecified;
	}
}
