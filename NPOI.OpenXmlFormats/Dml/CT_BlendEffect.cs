using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000332 RID: 818
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BlendEffect
	{
		// Token: 0x0600208C RID: 8332 RVA: 0x000562BA File Offset: 0x000544BA
		public CT_BlendEffect()
		{
			this.contField = new global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer();
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x000562CD File Offset: 0x000544CD
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x000562D5 File Offset: 0x000544D5
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

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x000562DE File Offset: 0x000544DE
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x000562E6 File Offset: 0x000544E6
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_BlendMode blend
		{
			get
			{
				return this.blendField;
			}
			set
			{
				this.blendField = value;
			}
		}

		// Token: 0x04001934 RID: 6452
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer contField;

		// Token: 0x04001935 RID: 6453
		private global::NPOI.OpenXmlFormats.Dml.ST_BlendMode blendField;
	}
}
