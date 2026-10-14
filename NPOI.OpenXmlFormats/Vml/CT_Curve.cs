using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Vml.Presentation;
using NPOI.OpenXmlFormats.Vml.Spreadsheet;
using NPOI.OpenXmlFormats.Vml.Wordprocessing;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001EA RID: 490
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Curve
	{
		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x0003FA15 File Offset: 0x0003DC15
		// (set) Token: 0x060013E1 RID: 5089 RVA: 0x0003FA1D File Offset: 0x0003DC1D
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

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x0003FA26 File Offset: 0x0003DC26
		// (set) Token: 0x060013E3 RID: 5091 RVA: 0x0003FA2E File Offset: 0x0003DC2E
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

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x0003FA37 File Offset: 0x0003DC37
		// (set) Token: 0x060013E5 RID: 5093 RVA: 0x0003FA3F File Offset: 0x0003DC3F
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

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x0003FA48 File Offset: 0x0003DC48
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x0003FA50 File Offset: 0x0003DC50
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

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x0003FA59 File Offset: 0x0003DC59
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x0003FA61 File Offset: 0x0003DC61
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

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x0003FA6A File Offset: 0x0003DC6A
		// (set) Token: 0x060013EB RID: 5099 RVA: 0x0003FA72 File Offset: 0x0003DC72
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

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x0003FA7B File Offset: 0x0003DC7B
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x0003FA83 File Offset: 0x0003DC83
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

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x0003FA8C File Offset: 0x0003DC8C
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x0003FA94 File Offset: 0x0003DC94
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

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0003FA9D File Offset: 0x0003DC9D
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x0003FAA5 File Offset: 0x0003DCA5
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

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x0003FAAE File Offset: 0x0003DCAE
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x0003FAB6 File Offset: 0x0003DCB6
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

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x0003FABF File Offset: 0x0003DCBF
		// (set) Token: 0x060013F5 RID: 5109 RVA: 0x0003FAC7 File Offset: 0x0003DCC7
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

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0003FAD0 File Offset: 0x0003DCD0
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x0003FAD8 File Offset: 0x0003DCD8
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

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x0003FAE1 File Offset: 0x0003DCE1
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x0003FAE9 File Offset: 0x0003DCE9
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

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x0003FAF2 File Offset: 0x0003DCF2
		// (set) Token: 0x060013FB RID: 5115 RVA: 0x0003FAFA File Offset: 0x0003DCFA
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

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x0003FB03 File Offset: 0x0003DD03
		// (set) Token: 0x060013FD RID: 5117 RVA: 0x0003FB0B File Offset: 0x0003DD0B
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

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0003FB14 File Offset: 0x0003DD14
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x0003FB1C File Offset: 0x0003DD1C
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

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x0003FB25 File Offset: 0x0003DD25
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x0003FB2D File Offset: 0x0003DD2D
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

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x0003FB36 File Offset: 0x0003DD36
		// (set) Token: 0x06001403 RID: 5123 RVA: 0x0003FB3E File Offset: 0x0003DD3E
		[global::System.Xml.Serialization.XmlAttribute]
		public string from
		{
			get
			{
				return this.fromField;
			}
			set
			{
				this.fromField = value;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x0003FB47 File Offset: 0x0003DD47
		// (set) Token: 0x06001405 RID: 5125 RVA: 0x0003FB4F File Offset: 0x0003DD4F
		[global::System.Xml.Serialization.XmlAttribute]
		public string control1
		{
			get
			{
				return this.control1Field;
			}
			set
			{
				this.control1Field = value;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x0003FB58 File Offset: 0x0003DD58
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x0003FB60 File Offset: 0x0003DD60
		[global::System.Xml.Serialization.XmlAttribute]
		public string control2
		{
			get
			{
				return this.control2Field;
			}
			set
			{
				this.control2Field = value;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x0003FB69 File Offset: 0x0003DD69
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x0003FB71 File Offset: 0x0003DD71
		[global::System.Xml.Serialization.XmlAttribute]
		public string to
		{
			get
			{
				return this.toField;
			}
			set
			{
				this.toField = value;
			}
		}

		// Token: 0x04000EFC RID: 3836
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Path> pathField;

		// Token: 0x04000EFD RID: 3837
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Formulas> formulasField;

		// Token: 0x04000EFE RID: 3838
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Handles> handlesField;

		// Token: 0x04000EFF RID: 3839
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Fill> fillField;

		// Token: 0x04000F00 RID: 3840
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Stroke> strokeField;

		// Token: 0x04000F01 RID: 3841
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Shadow> shadowField;

		// Token: 0x04000F02 RID: 3842
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Textbox> textboxField;

		// Token: 0x04000F03 RID: 3843
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_TextPath> textpathField;

		// Token: 0x04000F04 RID: 3844
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_ImageData> imagedataField;

		// Token: 0x04000F05 RID: 3845
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap> wrapField;

		// Token: 0x04000F06 RID: 3846
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_AnchorLock> anchorlockField;

		// Token: 0x04000F07 RID: 3847
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> bordertopField;

		// Token: 0x04000F08 RID: 3848
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderbottomField;

		// Token: 0x04000F09 RID: 3849
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderleftField;

		// Token: 0x04000F0A RID: 3850
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderrightField;

		// Token: 0x04000F0B RID: 3851
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData> clientDataField;

		// Token: 0x04000F0C RID: 3852
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel> textdataField;

		// Token: 0x04000F0D RID: 3853
		private string fromField;

		// Token: 0x04000F0E RID: 3854
		private string control1Field;

		// Token: 0x04000F0F RID: 3855
		private string control2Field;

		// Token: 0x04000F10 RID: 3856
		private string toField;
	}
}
