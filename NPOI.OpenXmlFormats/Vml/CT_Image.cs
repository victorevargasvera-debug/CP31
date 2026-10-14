using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Vml.Presentation;
using NPOI.OpenXmlFormats.Vml.Spreadsheet;
using NPOI.OpenXmlFormats.Vml.Wordprocessing;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001EB RID: 491
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Image
	{
		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x0003FB7A File Offset: 0x0003DD7A
		// (set) Token: 0x0600140C RID: 5132 RVA: 0x0003FB82 File Offset: 0x0003DD82
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

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x0003FB8B File Offset: 0x0003DD8B
		// (set) Token: 0x0600140E RID: 5134 RVA: 0x0003FB93 File Offset: 0x0003DD93
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

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x0003FB9C File Offset: 0x0003DD9C
		// (set) Token: 0x06001410 RID: 5136 RVA: 0x0003FBA4 File Offset: 0x0003DDA4
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

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x0003FBAD File Offset: 0x0003DDAD
		// (set) Token: 0x06001412 RID: 5138 RVA: 0x0003FBB5 File Offset: 0x0003DDB5
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

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x0003FBBE File Offset: 0x0003DDBE
		// (set) Token: 0x06001414 RID: 5140 RVA: 0x0003FBC6 File Offset: 0x0003DDC6
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

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x0003FBCF File Offset: 0x0003DDCF
		// (set) Token: 0x06001416 RID: 5142 RVA: 0x0003FBD7 File Offset: 0x0003DDD7
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

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x0003FBE0 File Offset: 0x0003DDE0
		// (set) Token: 0x06001418 RID: 5144 RVA: 0x0003FBE8 File Offset: 0x0003DDE8
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

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x0003FBF1 File Offset: 0x0003DDF1
		// (set) Token: 0x0600141A RID: 5146 RVA: 0x0003FBF9 File Offset: 0x0003DDF9
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

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x0003FC02 File Offset: 0x0003DE02
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x0003FC0A File Offset: 0x0003DE0A
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

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x0003FC13 File Offset: 0x0003DE13
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x0003FC1B File Offset: 0x0003DE1B
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

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x0003FC24 File Offset: 0x0003DE24
		// (set) Token: 0x06001420 RID: 5152 RVA: 0x0003FC2C File Offset: 0x0003DE2C
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

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0003FC35 File Offset: 0x0003DE35
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x0003FC3D File Offset: 0x0003DE3D
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

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x0003FC46 File Offset: 0x0003DE46
		// (set) Token: 0x06001424 RID: 5156 RVA: 0x0003FC4E File Offset: 0x0003DE4E
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

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x0003FC57 File Offset: 0x0003DE57
		// (set) Token: 0x06001426 RID: 5158 RVA: 0x0003FC5F File Offset: 0x0003DE5F
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

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0003FC68 File Offset: 0x0003DE68
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x0003FC70 File Offset: 0x0003DE70
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

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x0003FC79 File Offset: 0x0003DE79
		// (set) Token: 0x0600142A RID: 5162 RVA: 0x0003FC81 File Offset: 0x0003DE81
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

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x0003FC8A File Offset: 0x0003DE8A
		// (set) Token: 0x0600142C RID: 5164 RVA: 0x0003FC92 File Offset: 0x0003DE92
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

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x0003FC9B File Offset: 0x0003DE9B
		// (set) Token: 0x0600142E RID: 5166 RVA: 0x0003FCA3 File Offset: 0x0003DEA3
		[global::System.Xml.Serialization.XmlAttribute]
		public string src
		{
			get
			{
				return this.srcField;
			}
			set
			{
				this.srcField = value;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x0003FCAC File Offset: 0x0003DEAC
		// (set) Token: 0x06001430 RID: 5168 RVA: 0x0003FCB4 File Offset: 0x0003DEB4
		[global::System.Xml.Serialization.XmlAttribute]
		public string cropleft
		{
			get
			{
				return this.cropleftField;
			}
			set
			{
				this.cropleftField = value;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x0003FCBD File Offset: 0x0003DEBD
		// (set) Token: 0x06001432 RID: 5170 RVA: 0x0003FCC5 File Offset: 0x0003DEC5
		[global::System.Xml.Serialization.XmlAttribute]
		public string croptop
		{
			get
			{
				return this.croptopField;
			}
			set
			{
				this.croptopField = value;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x0003FCCE File Offset: 0x0003DECE
		// (set) Token: 0x06001434 RID: 5172 RVA: 0x0003FCD6 File Offset: 0x0003DED6
		[global::System.Xml.Serialization.XmlAttribute]
		public string cropright
		{
			get
			{
				return this.croprightField;
			}
			set
			{
				this.croprightField = value;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x0003FCDF File Offset: 0x0003DEDF
		// (set) Token: 0x06001436 RID: 5174 RVA: 0x0003FCE7 File Offset: 0x0003DEE7
		[global::System.Xml.Serialization.XmlAttribute]
		public string cropbottom
		{
			get
			{
				return this.cropbottomField;
			}
			set
			{
				this.cropbottomField = value;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x0003FCF0 File Offset: 0x0003DEF0
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x0003FCF8 File Offset: 0x0003DEF8
		[global::System.Xml.Serialization.XmlAttribute]
		public string gain
		{
			get
			{
				return this.gainField;
			}
			set
			{
				this.gainField = value;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x0003FD01 File Offset: 0x0003DF01
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x0003FD09 File Offset: 0x0003DF09
		[global::System.Xml.Serialization.XmlAttribute]
		public string blacklevel
		{
			get
			{
				return this.blacklevelField;
			}
			set
			{
				this.blacklevelField = value;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x0003FD12 File Offset: 0x0003DF12
		// (set) Token: 0x0600143C RID: 5180 RVA: 0x0003FD1A File Offset: 0x0003DF1A
		[global::System.Xml.Serialization.XmlAttribute]
		public string gamma
		{
			get
			{
				return this.gammaField;
			}
			set
			{
				this.gammaField = value;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x0003FD23 File Offset: 0x0003DF23
		// (set) Token: 0x0600143E RID: 5182 RVA: 0x0003FD2B File Offset: 0x0003DF2B
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse grayscale
		{
			get
			{
				return this.grayscaleField;
			}
			set
			{
				this.grayscaleField = value;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x0003FD34 File Offset: 0x0003DF34
		// (set) Token: 0x06001440 RID: 5184 RVA: 0x0003FD3C File Offset: 0x0003DF3C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool grayscaleSpecified
		{
			get
			{
				return this.grayscaleFieldSpecified;
			}
			set
			{
				this.grayscaleFieldSpecified = value;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x0003FD45 File Offset: 0x0003DF45
		// (set) Token: 0x06001442 RID: 5186 RVA: 0x0003FD4D File Offset: 0x0003DF4D
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse bilevel
		{
			get
			{
				return this.bilevelField;
			}
			set
			{
				this.bilevelField = value;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x0003FD56 File Offset: 0x0003DF56
		// (set) Token: 0x06001444 RID: 5188 RVA: 0x0003FD5E File Offset: 0x0003DF5E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool bilevelSpecified
		{
			get
			{
				return this.bilevelFieldSpecified;
			}
			set
			{
				this.bilevelFieldSpecified = value;
			}
		}

		// Token: 0x04000F11 RID: 3857
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Path> pathField;

		// Token: 0x04000F12 RID: 3858
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Formulas> formulasField;

		// Token: 0x04000F13 RID: 3859
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Handles> handlesField;

		// Token: 0x04000F14 RID: 3860
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Fill> fillField;

		// Token: 0x04000F15 RID: 3861
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Stroke> strokeField;

		// Token: 0x04000F16 RID: 3862
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Shadow> shadowField;

		// Token: 0x04000F17 RID: 3863
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_Textbox> textboxField;

		// Token: 0x04000F18 RID: 3864
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_TextPath> textpathField;

		// Token: 0x04000F19 RID: 3865
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.CT_ImageData> imagedataField;

		// Token: 0x04000F1A RID: 3866
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap> wrapField;

		// Token: 0x04000F1B RID: 3867
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_AnchorLock> anchorlockField;

		// Token: 0x04000F1C RID: 3868
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> bordertopField;

		// Token: 0x04000F1D RID: 3869
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderbottomField;

		// Token: 0x04000F1E RID: 3870
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderleftField;

		// Token: 0x04000F1F RID: 3871
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border> borderrightField;

		// Token: 0x04000F20 RID: 3872
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData> clientDataField;

		// Token: 0x04000F21 RID: 3873
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel> textdataField;

		// Token: 0x04000F22 RID: 3874
		private string srcField;

		// Token: 0x04000F23 RID: 3875
		private string cropleftField;

		// Token: 0x04000F24 RID: 3876
		private string croptopField;

		// Token: 0x04000F25 RID: 3877
		private string croprightField;

		// Token: 0x04000F26 RID: 3878
		private string cropbottomField;

		// Token: 0x04000F27 RID: 3879
		private string gainField;

		// Token: 0x04000F28 RID: 3880
		private string blacklevelField;

		// Token: 0x04000F29 RID: 3881
		private string gammaField;

		// Token: 0x04000F2A RID: 3882
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse grayscaleField;

		// Token: 0x04000F2B RID: 3883
		private bool grayscaleFieldSpecified;

		// Token: 0x04000F2C RID: 3884
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse bilevelField;

		// Token: 0x04000F2D RID: 3885
		private bool bilevelFieldSpecified;
	}
}
