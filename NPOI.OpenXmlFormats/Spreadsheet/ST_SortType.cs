using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004AA RID: 1194
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	public enum ST_SortType
	{
		// Token: 0x0400211B RID: 8475
		none,
		// Token: 0x0400211C RID: 8476
		ascending,
		// Token: 0x0400211D RID: 8477
		descending,
		// Token: 0x0400211E RID: 8478
		ascendingAlpha,
		// Token: 0x0400211F RID: 8479
		descendingAlpha,
		// Token: 0x04002120 RID: 8480
		ascendingNatural,
		// Token: 0x04002121 RID: 8481
		descendingNatural
	}
}
