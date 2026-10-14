using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000F7 RID: 247
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType
	{
		// Token: 0x040005DD RID: 1501
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x040005DE RID: 1502
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x040005DF RID: 1503
		altChunk,
		// Token: 0x040005E0 RID: 1504
		bookmarkEnd,
		// Token: 0x040005E1 RID: 1505
		bookmarkStart,
		// Token: 0x040005E2 RID: 1506
		commentRangeEnd,
		// Token: 0x040005E3 RID: 1507
		commentRangeStart,
		// Token: 0x040005E4 RID: 1508
		customXml,
		// Token: 0x040005E5 RID: 1509
		customXmlDelRangeEnd,
		// Token: 0x040005E6 RID: 1510
		customXmlDelRangeStart,
		// Token: 0x040005E7 RID: 1511
		customXmlInsRangeEnd,
		// Token: 0x040005E8 RID: 1512
		customXmlInsRangeStart,
		// Token: 0x040005E9 RID: 1513
		customXmlMoveFromRangeEnd,
		// Token: 0x040005EA RID: 1514
		customXmlMoveFromRangeStart,
		// Token: 0x040005EB RID: 1515
		customXmlMoveToRangeEnd,
		// Token: 0x040005EC RID: 1516
		customXmlMoveToRangeStart,
		// Token: 0x040005ED RID: 1517
		del,
		// Token: 0x040005EE RID: 1518
		ins,
		// Token: 0x040005EF RID: 1519
		moveFrom,
		// Token: 0x040005F0 RID: 1520
		moveFromRangeEnd,
		// Token: 0x040005F1 RID: 1521
		moveFromRangeStart,
		// Token: 0x040005F2 RID: 1522
		moveTo,
		// Token: 0x040005F3 RID: 1523
		moveToRangeEnd,
		// Token: 0x040005F4 RID: 1524
		moveToRangeStart,
		// Token: 0x040005F5 RID: 1525
		p,
		// Token: 0x040005F6 RID: 1526
		permEnd,
		// Token: 0x040005F7 RID: 1527
		permStart,
		// Token: 0x040005F8 RID: 1528
		proofErr,
		// Token: 0x040005F9 RID: 1529
		sdt,
		// Token: 0x040005FA RID: 1530
		tbl
	}
}
