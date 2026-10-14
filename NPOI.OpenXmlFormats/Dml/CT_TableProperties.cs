using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200024A RID: 586
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TableProperties
	{
		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x00043352 File Offset: 0x00041552
		// (set) Token: 0x060017A0 RID: 6048 RVA: 0x0004335A File Offset: 0x0004155A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
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

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x00043363 File Offset: 0x00041563
		// (set) Token: 0x060017A2 RID: 6050 RVA: 0x0004336B File Offset: 0x0004156B
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x00043374 File Offset: 0x00041574
		// (set) Token: 0x060017A4 RID: 6052 RVA: 0x0004337C File Offset: 0x0004157C
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x00043385 File Offset: 0x00041585
		// (set) Token: 0x060017A6 RID: 6054 RVA: 0x0004338D File Offset: 0x0004158D
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x00043396 File Offset: 0x00041596
		// (set) Token: 0x060017A8 RID: 6056 RVA: 0x0004339E File Offset: 0x0004159E
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x000433A7 File Offset: 0x000415A7
		// (set) Token: 0x060017AA RID: 6058 RVA: 0x000433AF File Offset: 0x000415AF
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
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

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x000433B8 File Offset: 0x000415B8
		// (set) Token: 0x060017AC RID: 6060 RVA: 0x000433C0 File Offset: 0x000415C0
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.CT_EffectList effectLst
		{
			get
			{
				return this.effectLstField;
			}
			set
			{
				this.effectLstField = value;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x000433C9 File Offset: 0x000415C9
		// (set) Token: 0x060017AE RID: 6062 RVA: 0x000433D1 File Offset: 0x000415D1
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer effectDag
		{
			get
			{
				return this.effectDagField;
			}
			set
			{
				this.effectDagField = value;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x060017AF RID: 6063 RVA: 0x000433DA File Offset: 0x000415DA
		// (set) Token: 0x060017B0 RID: 6064 RVA: 0x000433E2 File Offset: 0x000415E2
		[global::System.Xml.Serialization.XmlElement("tableStyle", typeof(global::NPOI.OpenXmlFormats.Dml.CT_TableStyle), Order = 8)]
		[global::System.Xml.Serialization.XmlElement("tableStyleId", typeof(string), DataType = "token", Order = 8)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x000433EB File Offset: 0x000415EB
		// (set) Token: 0x060017B2 RID: 6066 RVA: 0x000433F3 File Offset: 0x000415F3
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
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

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x000433FC File Offset: 0x000415FC
		// (set) Token: 0x060017B4 RID: 6068 RVA: 0x00043404 File Offset: 0x00041604
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool rtl
		{
			get
			{
				return this.rtlField;
			}
			set
			{
				this.rtlField = value;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x0004340D File Offset: 0x0004160D
		// (set) Token: 0x060017B6 RID: 6070 RVA: 0x00043415 File Offset: 0x00041615
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool firstRow
		{
			get
			{
				return this.firstRowField;
			}
			set
			{
				this.firstRowField = value;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x060017B7 RID: 6071 RVA: 0x0004341E File Offset: 0x0004161E
		// (set) Token: 0x060017B8 RID: 6072 RVA: 0x00043426 File Offset: 0x00041626
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool firstCol
		{
			get
			{
				return this.firstColField;
			}
			set
			{
				this.firstColField = value;
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x060017B9 RID: 6073 RVA: 0x0004342F File Offset: 0x0004162F
		// (set) Token: 0x060017BA RID: 6074 RVA: 0x00043437 File Offset: 0x00041637
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool lastRow
		{
			get
			{
				return this.lastRowField;
			}
			set
			{
				this.lastRowField = value;
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x00043440 File Offset: 0x00041640
		// (set) Token: 0x060017BC RID: 6076 RVA: 0x00043448 File Offset: 0x00041648
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool lastCol
		{
			get
			{
				return this.lastColField;
			}
			set
			{
				this.lastColField = value;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x00043451 File Offset: 0x00041651
		// (set) Token: 0x060017BE RID: 6078 RVA: 0x00043459 File Offset: 0x00041659
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool bandRow
		{
			get
			{
				return this.bandRowField;
			}
			set
			{
				this.bandRowField = value;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x060017BF RID: 6079 RVA: 0x00043462 File Offset: 0x00041662
		// (set) Token: 0x060017C0 RID: 6080 RVA: 0x0004346A File Offset: 0x0004166A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool bandCol
		{
			get
			{
				return this.bandColField;
			}
			set
			{
				this.bandColField = value;
			}
		}

		// Token: 0x04001253 RID: 4691
		private global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFillField;

		// Token: 0x04001254 RID: 4692
		private global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFillField;

		// Token: 0x04001255 RID: 4693
		private global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFillField;

		// Token: 0x04001256 RID: 4694
		private global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFillField;

		// Token: 0x04001257 RID: 4695
		private global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFillField;

		// Token: 0x04001258 RID: 4696
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFillField;

		// Token: 0x04001259 RID: 4697
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectList effectLstField;

		// Token: 0x0400125A RID: 4698
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer effectDagField;

		// Token: 0x0400125B RID: 4699
		private object itemField;

		// Token: 0x0400125C RID: 4700
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x0400125D RID: 4701
		private bool rtlField;

		// Token: 0x0400125E RID: 4702
		private bool firstRowField;

		// Token: 0x0400125F RID: 4703
		private bool firstColField;

		// Token: 0x04001260 RID: 4704
		private bool lastRowField;

		// Token: 0x04001261 RID: 4705
		private bool lastColField;

		// Token: 0x04001262 RID: 4706
		private bool bandRowField;

		// Token: 0x04001263 RID: 4707
		private bool bandColField;
	}
}
