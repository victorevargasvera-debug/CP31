using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000498 RID: 1176
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	public enum ST_GroupBy
	{
		// Token: 0x040020B2 RID: 8370
		range,
		// Token: 0x040020B3 RID: 8371
		seconds,
		// Token: 0x040020B4 RID: 8372
		minutes,
		// Token: 0x040020B5 RID: 8373
		hours,
		// Token: 0x040020B6 RID: 8374
		days,
		// Token: 0x040020B7 RID: 8375
		months,
		// Token: 0x040020B8 RID: 8376
		quarters,
		// Token: 0x040020B9 RID: 8377
		years
	}
}
