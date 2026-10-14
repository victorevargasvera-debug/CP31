using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001A1 RID: 417
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AutoCaptions
	{
		// Token: 0x06000FB7 RID: 4023 RVA: 0x00032C58 File Offset: 0x00030E58
		public CT_AutoCaptions()
		{
			this.autoCaptionField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_AutoCaption>();
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x00032C6B File Offset: 0x00030E6B
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00032C73 File Offset: 0x00030E73
		[global::System.Xml.Serialization.XmlElement("autoCaption", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_AutoCaption> autoCaption
		{
			get
			{
				return this.autoCaptionField;
			}
			set
			{
				this.autoCaptionField = value;
			}
		}

		// Token: 0x04000CBC RID: 3260
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_AutoCaption> autoCaptionField;
	}
}
