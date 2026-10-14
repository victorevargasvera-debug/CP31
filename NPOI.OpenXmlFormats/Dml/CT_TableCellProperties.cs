using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200024E RID: 590
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TableCellProperties
	{
		// Token: 0x060017DC RID: 6108 RVA: 0x00043594 File Offset: 0x00041794
		public CT_TableCellProperties()
		{
			this.marLField = 91440;
			this.marRField = 91440;
			this.marTField = 45720;
			this.marBField = 45720;
			this.vertField = global::NPOI.OpenXmlFormats.Dml.ST_TextVerticalType.horz;
			this.anchorField = global::NPOI.OpenXmlFormats.Dml.ST_TextAnchoringType.t;
			this.anchorCtrField = false;
			this.horzOverflowField = global::NPOI.OpenXmlFormats.Dml.ST_TextHorzOverflowType.clip;
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x000435EF File Offset: 0x000417EF
		// (set) Token: 0x060017DE RID: 6110 RVA: 0x000435F7 File Offset: 0x000417F7
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnL
		{
			get
			{
				return this.lnLField;
			}
			set
			{
				this.lnLField = value;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x00043600 File Offset: 0x00041800
		// (set) Token: 0x060017E0 RID: 6112 RVA: 0x00043608 File Offset: 0x00041808
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnR
		{
			get
			{
				return this.lnRField;
			}
			set
			{
				this.lnRField = value;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060017E1 RID: 6113 RVA: 0x00043611 File Offset: 0x00041811
		// (set) Token: 0x060017E2 RID: 6114 RVA: 0x00043619 File Offset: 0x00041819
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnT
		{
			get
			{
				return this.lnTField;
			}
			set
			{
				this.lnTField = value;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060017E3 RID: 6115 RVA: 0x00043622 File Offset: 0x00041822
		// (set) Token: 0x060017E4 RID: 6116 RVA: 0x0004362A File Offset: 0x0004182A
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnB
		{
			get
			{
				return this.lnBField;
			}
			set
			{
				this.lnBField = value;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x060017E5 RID: 6117 RVA: 0x00043633 File Offset: 0x00041833
		// (set) Token: 0x060017E6 RID: 6118 RVA: 0x0004363B File Offset: 0x0004183B
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnTlToBr
		{
			get
			{
				return this.lnTlToBrField;
			}
			set
			{
				this.lnTlToBrField = value;
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x060017E7 RID: 6119 RVA: 0x00043644 File Offset: 0x00041844
		// (set) Token: 0x060017E8 RID: 6120 RVA: 0x0004364C File Offset: 0x0004184C
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnBlToTr
		{
			get
			{
				return this.lnBlToTrField;
			}
			set
			{
				this.lnBlToTrField = value;
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x00043655 File Offset: 0x00041855
		// (set) Token: 0x060017EA RID: 6122 RVA: 0x0004365D File Offset: 0x0004185D
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Cell3D cell3D
		{
			get
			{
				return this.cell3DField;
			}
			set
			{
				this.cell3DField = value;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x00043666 File Offset: 0x00041866
		// (set) Token: 0x060017EC RID: 6124 RVA: 0x0004366E File Offset: 0x0004186E
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFill
		{
			get
			{
				return this.noFillField;
			}
			set
			{
				this.noFillField = value;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x00043677 File Offset: 0x00041877
		// (set) Token: 0x060017EE RID: 6126 RVA: 0x0004367F File Offset: 0x0004187F
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFill
		{
			get
			{
				return this.solidFillField;
			}
			set
			{
				this.solidFillField = value;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x00043688 File Offset: 0x00041888
		// (set) Token: 0x060017F0 RID: 6128 RVA: 0x00043690 File Offset: 0x00041890
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFill
		{
			get
			{
				return this.gradFillField;
			}
			set
			{
				this.gradFillField = value;
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x00043699 File Offset: 0x00041899
		// (set) Token: 0x060017F2 RID: 6130 RVA: 0x000436A1 File Offset: 0x000418A1
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFill
		{
			get
			{
				return this.blipFillField;
			}
			set
			{
				this.blipFillField = value;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x000436AA File Offset: 0x000418AA
		// (set) Token: 0x060017F4 RID: 6132 RVA: 0x000436B2 File Offset: 0x000418B2
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFill
		{
			get
			{
				return this.pattFillField;
			}
			set
			{
				this.pattFillField = value;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x000436BB File Offset: 0x000418BB
		// (set) Token: 0x060017F6 RID: 6134 RVA: 0x000436C3 File Offset: 0x000418C3
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFill
		{
			get
			{
				return this.grpFillField;
			}
			set
			{
				this.grpFillField = value;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x000436CC File Offset: 0x000418CC
		// (set) Token: 0x060017F8 RID: 6136 RVA: 0x000436D4 File Offset: 0x000418D4
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
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

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x000436DD File Offset: 0x000418DD
		// (set) Token: 0x060017FA RID: 6138 RVA: 0x000436E5 File Offset: 0x000418E5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(91440)]
		public int marL
		{
			get
			{
				return this.marLField;
			}
			set
			{
				this.marLField = value;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x000436EE File Offset: 0x000418EE
		// (set) Token: 0x060017FC RID: 6140 RVA: 0x000436F6 File Offset: 0x000418F6
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(91440)]
		public int marR
		{
			get
			{
				return this.marRField;
			}
			set
			{
				this.marRField = value;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x000436FF File Offset: 0x000418FF
		// (set) Token: 0x060017FE RID: 6142 RVA: 0x00043707 File Offset: 0x00041907
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(45720)]
		public int marT
		{
			get
			{
				return this.marTField;
			}
			set
			{
				this.marTField = value;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00043710 File Offset: 0x00041910
		// (set) Token: 0x06001800 RID: 6144 RVA: 0x00043718 File Offset: 0x00041918
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(45720)]
		public int marB
		{
			get
			{
				return this.marBField;
			}
			set
			{
				this.marBField = value;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x00043721 File Offset: 0x00041921
		// (set) Token: 0x06001802 RID: 6146 RVA: 0x00043729 File Offset: 0x00041929
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.ST_TextVerticalType.horz)]
		public global::NPOI.OpenXmlFormats.Dml.ST_TextVerticalType vert
		{
			get
			{
				return this.vertField;
			}
			set
			{
				this.vertField = value;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x00043732 File Offset: 0x00041932
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x0004373A File Offset: 0x0004193A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.ST_TextAnchoringType.t)]
		public global::NPOI.OpenXmlFormats.Dml.ST_TextAnchoringType anchor
		{
			get
			{
				return this.anchorField;
			}
			set
			{
				this.anchorField = value;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x00043743 File Offset: 0x00041943
		// (set) Token: 0x06001806 RID: 6150 RVA: 0x0004374B File Offset: 0x0004194B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool anchorCtr
		{
			get
			{
				return this.anchorCtrField;
			}
			set
			{
				this.anchorCtrField = value;
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x00043754 File Offset: 0x00041954
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x0004375C File Offset: 0x0004195C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.ST_TextHorzOverflowType.clip)]
		public global::NPOI.OpenXmlFormats.Dml.ST_TextHorzOverflowType horzOverflow
		{
			get
			{
				return this.horzOverflowField;
			}
			set
			{
				this.horzOverflowField = value;
			}
		}

		// Token: 0x04001270 RID: 4720
		private global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnLField;

		// Token: 0x04001271 RID: 4721
		private global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnRField;

		// Token: 0x04001272 RID: 4722
		private global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnTField;

		// Token: 0x04001273 RID: 4723
		private global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnBField;

		// Token: 0x04001274 RID: 4724
		private global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnTlToBrField;

		// Token: 0x04001275 RID: 4725
		private global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnBlToTrField;

		// Token: 0x04001276 RID: 4726
		private global::NPOI.OpenXmlFormats.Dml.CT_Cell3D cell3DField;

		// Token: 0x04001277 RID: 4727
		private global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFillField;

		// Token: 0x04001278 RID: 4728
		private global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFillField;

		// Token: 0x04001279 RID: 4729
		private global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFillField;

		// Token: 0x0400127A RID: 4730
		private global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFillField;

		// Token: 0x0400127B RID: 4731
		private global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFillField;

		// Token: 0x0400127C RID: 4732
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFillField;

		// Token: 0x0400127D RID: 4733
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x0400127E RID: 4734
		private int marLField;

		// Token: 0x0400127F RID: 4735
		private int marRField;

		// Token: 0x04001280 RID: 4736
		private int marTField;

		// Token: 0x04001281 RID: 4737
		private int marBField;

		// Token: 0x04001282 RID: 4738
		private global::NPOI.OpenXmlFormats.Dml.ST_TextVerticalType vertField;

		// Token: 0x04001283 RID: 4739
		private global::NPOI.OpenXmlFormats.Dml.ST_TextAnchoringType anchorField;

		// Token: 0x04001284 RID: 4740
		private bool anchorCtrField;

		// Token: 0x04001285 RID: 4741
		private global::NPOI.OpenXmlFormats.Dml.ST_TextHorzOverflowType horzOverflowField;
	}
}
