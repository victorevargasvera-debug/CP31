using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x0200020B RID: 523
	[global::System.Xml.Serialization.XmlType(TypeName = "ST_TrueFalse", Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot("ST_TrueFalse", Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_TrueFalse
	{
		// Token: 0x040010D3 RID: 4307
		f,
		// Token: 0x040010D4 RID: 4308
		t,
		// Token: 0x040010D5 RID: 4309
		@true,
		// Token: 0x040010D6 RID: 4310
		@false
	}
}
