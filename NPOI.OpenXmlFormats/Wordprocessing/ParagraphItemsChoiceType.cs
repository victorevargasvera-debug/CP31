using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200015B RID: 347
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ParagraphItemsChoiceType
	{
		// Token: 0x04000991 RID: 2449
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x04000992 RID: 2450
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x04000993 RID: 2451
		bookmarkEnd,
		// Token: 0x04000994 RID: 2452
		bookmarkStart,
		// Token: 0x04000995 RID: 2453
		commentRangeEnd,
		// Token: 0x04000996 RID: 2454
		commentRangeStart,
		// Token: 0x04000997 RID: 2455
		customXml,
		// Token: 0x04000998 RID: 2456
		customXmlDelRangeEnd,
		// Token: 0x04000999 RID: 2457
		customXmlDelRangeStart,
		// Token: 0x0400099A RID: 2458
		customXmlInsRangeEnd,
		// Token: 0x0400099B RID: 2459
		customXmlInsRangeStart,
		// Token: 0x0400099C RID: 2460
		customXmlMoveFromRangeEnd,
		// Token: 0x0400099D RID: 2461
		customXmlMoveFromRangeStart,
		// Token: 0x0400099E RID: 2462
		customXmlMoveToRangeEnd,
		// Token: 0x0400099F RID: 2463
		customXmlMoveToRangeStart,
		// Token: 0x040009A0 RID: 2464
		del,
		// Token: 0x040009A1 RID: 2465
		fldSimple,
		// Token: 0x040009A2 RID: 2466
		hyperlink,
		// Token: 0x040009A3 RID: 2467
		ins,
		// Token: 0x040009A4 RID: 2468
		moveFrom,
		// Token: 0x040009A5 RID: 2469
		moveFromRangeEnd,
		// Token: 0x040009A6 RID: 2470
		moveFromRangeStart,
		// Token: 0x040009A7 RID: 2471
		moveTo,
		// Token: 0x040009A8 RID: 2472
		moveToRangeEnd,
		// Token: 0x040009A9 RID: 2473
		moveToRangeStart,
		// Token: 0x040009AA RID: 2474
		permEnd,
		// Token: 0x040009AB RID: 2475
		permStart,
		// Token: 0x040009AC RID: 2476
		proofErr,
		// Token: 0x040009AD RID: 2477
		r,
		// Token: 0x040009AE RID: 2478
		sdt,
		// Token: 0x040009AF RID: 2479
		smartTag,
		// Token: 0x040009B0 RID: 2480
		subDoc
	}
}
