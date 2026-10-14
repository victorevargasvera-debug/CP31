using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000248 RID: 584
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_WholeE2oFormatting
	{
		// Token: 0x06001790 RID: 6032 RVA: 0x0004329A File Offset: 0x0004149A
		public CT_WholeE2oFormatting()
		{
			this.effectDagField = new global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer();
			this.effectLstField = new global::NPOI.OpenXmlFormats.Dml.CT_EffectList();
			this.lnField = new global::NPOI.OpenXmlFormats.Dml.CT_LineProperties();
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x000432C3 File Offset: 0x000414C3
		// (set) Token: 0x06001792 RID: 6034 RVA: 0x000432CB File Offset: 0x000414CB
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LineProperties ln
		{
			get
			{
				return this.lnField;
			}
			set
			{
				this.lnField = value;
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x000432D4 File Offset: 0x000414D4
		// (set) Token: 0x06001794 RID: 6036 RVA: 0x000432DC File Offset: 0x000414DC
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x000432E5 File Offset: 0x000414E5
		// (set) Token: 0x06001796 RID: 6038 RVA: 0x000432ED File Offset: 0x000414ED
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x0400124D RID: 4685
		private global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnField;

		// Token: 0x0400124E RID: 4686
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectList effectLstField;

		// Token: 0x0400124F RID: 4687
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer effectDagField;
	}
}
