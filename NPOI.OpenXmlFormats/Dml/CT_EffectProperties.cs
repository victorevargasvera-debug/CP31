using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000342 RID: 834
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_EffectProperties
	{
		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x000569DA File Offset: 0x00054BDA
		// (set) Token: 0x060020E2 RID: 8418 RVA: 0x000569E2 File Offset: 0x00054BE2
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
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

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x000569EB File Offset: 0x00054BEB
		// (set) Token: 0x060020E4 RID: 8420 RVA: 0x000569F3 File Offset: 0x00054BF3
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x0400195D RID: 6493
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectList effectLstField;

		// Token: 0x0400195E RID: 6494
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer effectDagField;
	}
}
