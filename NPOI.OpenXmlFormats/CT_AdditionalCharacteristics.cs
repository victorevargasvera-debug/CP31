using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200001B RID: 27
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/characteristics")]
	[global::System.Serializable]
	public class CT_AdditionalCharacteristics
	{
		// Token: 0x06000127 RID: 295 RVA: 0x0000315C File Offset: 0x0000135C
		public CT_AdditionalCharacteristics()
		{
			this.characteristicField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_Characteristic>();
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000316F File Offset: 0x0000136F
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00003177 File Offset: 0x00001377
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_Characteristic> characteristic
		{
			get
			{
				return this.characteristicField;
			}
			set
			{
				this.characteristicField = value;
			}
		}

		// Token: 0x040000BB RID: 187
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_Characteristic> characteristicField;
	}
}
