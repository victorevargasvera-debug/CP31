using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000247 RID: 583
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BackgroundFormatting
	{
		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x00043212 File Offset: 0x00041412
		// (set) Token: 0x06001781 RID: 6017 RVA: 0x0004321A File Offset: 0x0004141A
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

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x00043223 File Offset: 0x00041423
		// (set) Token: 0x06001783 RID: 6019 RVA: 0x0004322B File Offset: 0x0004142B
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

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x00043234 File Offset: 0x00041434
		// (set) Token: 0x06001785 RID: 6021 RVA: 0x0004323C File Offset: 0x0004143C
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

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x00043245 File Offset: 0x00041445
		// (set) Token: 0x06001787 RID: 6023 RVA: 0x0004324D File Offset: 0x0004144D
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

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x00043256 File Offset: 0x00041456
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x0004325E File Offset: 0x0004145E
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

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x00043267 File Offset: 0x00041467
		// (set) Token: 0x0600178B RID: 6027 RVA: 0x0004326F File Offset: 0x0004146F
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

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x00043278 File Offset: 0x00041478
		// (set) Token: 0x0600178D RID: 6029 RVA: 0x00043280 File Offset: 0x00041480
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

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x00043289 File Offset: 0x00041489
		// (set) Token: 0x0600178F RID: 6031 RVA: 0x00043291 File Offset: 0x00041491
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

		// Token: 0x04001245 RID: 4677
		private global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFillField;

		// Token: 0x04001246 RID: 4678
		private global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFillField;

		// Token: 0x04001247 RID: 4679
		private global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFillField;

		// Token: 0x04001248 RID: 4680
		private global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFillField;

		// Token: 0x04001249 RID: 4681
		private global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFillField;

		// Token: 0x0400124A RID: 4682
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFillField;

		// Token: 0x0400124B RID: 4683
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectList effectLstField;

		// Token: 0x0400124C RID: 4684
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer effectDagField;
	}
}
