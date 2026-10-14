using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000182 RID: 386
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_MailMergeDocType
	{
		// Token: 0x04000BC9 RID: 3017
		catalog,
		// Token: 0x04000BCA RID: 3018
		envelopes,
		// Token: 0x04000BCB RID: 3019
		mailingLabels,
		// Token: 0x04000BCC RID: 3020
		formLetters,
		// Token: 0x04000BCD RID: 3021
		email,
		// Token: 0x04000BCE RID: 3022
		fax
	}
}
