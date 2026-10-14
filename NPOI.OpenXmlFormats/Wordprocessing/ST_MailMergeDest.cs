using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000186 RID: 390
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_MailMergeDest
	{
		// Token: 0x04000BD9 RID: 3033
		newDocument,
		// Token: 0x04000BDA RID: 3034
		printer,
		// Token: 0x04000BDB RID: 3035
		email,
		// Token: 0x04000BDC RID: 3036
		fax
	}
}
