using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Vml.Presentation;
using NPOI.OpenXmlFormats.Vml.Spreadsheet;
using NPOI.OpenXmlFormats.Vml.Wordprocessing;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001EC RID: 492
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Line
	{
		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0003FD67 File Offset: 0x0003DF67
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x0003FD6F File Offset: 0x0003DF6F
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

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x0003FD78 File Offset: 0x0003DF78
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x0003FD80 File Offset: 0x0003DF80
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

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x0003FD89 File Offset: 0x0003DF89
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x0003FD91 File Offset: 0x0003DF91
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

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x0003FD9A File Offset: 0x0003DF9A
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x0003FDA2 File Offset: 0x0003DFA2
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

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0003FDAB File Offset: 0x0003DFAB
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x0003FDB3 File Offset: 0x0003DFB3
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

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x0003FDBC File Offset: 0x0003DFBC
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x0003FDC4 File Offset: 0x0003DFC4
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

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x0003FDCD File Offset: 0x0003DFCD
		// (set) Token: 0x06001453 RID: 5203 RVA: 0x0003FDD5 File Offset: 0x0003DFD5
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

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x0003FDDE File Offset: 0x0003DFDE
		// (set) Token: 0x06001455 RID: 5205 RVA: 0x0003FDE6 File Offset: 0x0003DFE6
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

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x0003FDEF File Offset: 0x0003DFEF
		// (set) Token: 0x06001457 RID: 5207 RVA: 0x0003FDF7 File Offset: 0x0003DFF7
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

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x0003FE00 File Offset: 0x0003E000
		// (set) Token: 0x06001459 RID: 5209 RVA: 0x0003FE08 File Offset: 0x0003E008
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

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x0003FE11 File Offset: 0x0003E011
		// (set) Token: 0x0600145B RID: 5211 RVA: 0x0003FE19 File Offset: 0x0003E019
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

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x0003FE22 File Offset: 0x0003E022
		// (set) Token: 0x0600145D RID: 5213 RVA: 0x0003FE2A File Offset: 0x0003E02A
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

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x0003FE33 File Offset: 0x0003E033
		// (set) Token: 0x0600145F RID: 5215 RVA: 0x0003FE3B File Offset: 0x0003E03B
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

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0003FE44 File Offset: 0x0003E044
		// (set) Token: 0x06001461 RID: 5217 RVA: 0x0003FE4C File Offset: 0x0003E04C
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

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0003FE55 File Offset: 0x0003E055
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x0003FE5D File Offset: 0x0003E05D
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

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x0003FE66 File Offset: 0x0003E066
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x0003FE6E File Offset: 0x0003E06E
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

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x0003FE77 File Offset: 0x0003E077
		// (set) Token: 0x06001467 RID: 5223 RVA: 0x0003FE7F File Offset: 0x0003E07F
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

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0003FE88 File Offset: 0x0003E088
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x0003FE90 File Offset: 0x0003E090
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

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x0003FE99 File Offset: 0x0003E099
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x0003FEA1 File Offset: 0x0003E0A1
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

		// Token: 0x04000F2E RID: 3886
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Path> pathField;

		// Token: 0x04000F2F RID: 3887
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Formulas> formulasField;

		// Token: 0x04000F30 RID: 3888
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Handles> handlesField;

		// Token: 0x04000F31 RID: 3889
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Fill> fillField;

		// Token: 0x04000F32 RID: 3890
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Stroke> strokeField;

		// Token: 0x04000F33 RID: 3891
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Shadow> shadowField;

		// Token: 0x04000F34 RID: 3892
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Textbox> textboxField;

		// Token: 0x04000F35 RID: 3893
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_TextPath> textpathField;

		// Token: 0x04000F36 RID: 3894
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_ImageData> imagedataField;

		// Token: 0x04000F37 RID: 3895
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap> wrapField;

		// Token: 0x04000F38 RID: 3896
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_AnchorLock> anchorlockField;

		// Token: 0x04000F39 RID: 3897
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> bordertopField;

		// Token: 0x04000F3A RID: 3898
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderbottomField;

		// Token: 0x04000F3B RID: 3899
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderleftField;

		// Token: 0x04000F3C RID: 3900
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderrightField;

		// Token: 0x04000F3D RID: 3901
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData> clientDataField;

		// Token: 0x04000F3E RID: 3902
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel> textdataField;

		// Token: 0x04000F3F RID: 3903
		private string fromField;

		// Token: 0x04000F40 RID: 3904
		private string toField;
	}
}
