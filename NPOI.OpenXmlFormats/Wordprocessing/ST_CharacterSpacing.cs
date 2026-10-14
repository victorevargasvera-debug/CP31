using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000191 RID: 401
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_CharacterSpacing
	{
		// Token: 0x04000C21 RID: 3105
		doNotCompress,
		// Token: 0x04000C22 RID: 3106
		compressPunctuation,
		// Token: 0x04000C23 RID: 3107
		compressPunctuationAndJapaneseKana
	}
}
