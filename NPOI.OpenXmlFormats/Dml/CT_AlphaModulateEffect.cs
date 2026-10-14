using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000337 RID: 823
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AlphaModulateEffect
	{
		// Token: 0x060020A9 RID: 8361 RVA: 0x00056487 File Offset: 0x00054687
		public CT_AlphaModulateEffect()
		{
			this.contField = new global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer();
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x0005649A File Offset: 0x0005469A
		// (set) Token: 0x060020AB RID: 8363 RVA: 0x000564A2 File Offset: 0x000546A2
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer cont
		{
			get
			{
				return this.contField;
			}
			set
			{
				this.contField = value;
			}
		}

		// Token: 0x0400193F RID: 6463
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer contField;
	}
}
