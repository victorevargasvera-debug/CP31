using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Spreadsheet
{
	// Token: 0x02000203 RID: 515
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:excel")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:excel", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_TrueFalseBlank
	{
		// Token: 0x04001052 RID: 4178
		NONE,
		// Token: 0x04001053 RID: 4179
		[global::System.Xml.Serialization.XmlEnum("True")]
		@true,
		// Token: 0x04001054 RID: 4180
		t,
		// Token: 0x04001055 RID: 4181
		[global::System.Xml.Serialization.XmlEnum("False")]
		@false,
		// Token: 0x04001056 RID: 4182
		f
	}
}
