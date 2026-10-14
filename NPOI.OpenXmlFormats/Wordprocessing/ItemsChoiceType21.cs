using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000063 RID: 99
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType21
	{
		// Token: 0x040001F4 RID: 500
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x040001F5 RID: 501
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x040001F6 RID: 502
		bookmarkEnd,
		// Token: 0x040001F7 RID: 503
		bookmarkStart,
		// Token: 0x040001F8 RID: 504
		commentRangeEnd,
		// Token: 0x040001F9 RID: 505
		commentRangeStart,
		// Token: 0x040001FA RID: 506
		customXml,
		// Token: 0x040001FB RID: 507
		customXmlDelRangeEnd,
		// Token: 0x040001FC RID: 508
		customXmlDelRangeStart,
		// Token: 0x040001FD RID: 509
		customXmlInsRangeEnd,
		// Token: 0x040001FE RID: 510
		customXmlInsRangeStart,
		// Token: 0x040001FF RID: 511
		customXmlMoveFromRangeEnd,
		// Token: 0x04000200 RID: 512
		customXmlMoveFromRangeStart,
		// Token: 0x04000201 RID: 513
		customXmlMoveToRangeEnd,
		// Token: 0x04000202 RID: 514
		customXmlMoveToRangeStart,
		// Token: 0x04000203 RID: 515
		del,
		// Token: 0x04000204 RID: 516
		ins,
		// Token: 0x04000205 RID: 517
		moveFrom,
		// Token: 0x04000206 RID: 518
		moveFromRangeEnd,
		// Token: 0x04000207 RID: 519
		moveFromRangeStart,
		// Token: 0x04000208 RID: 520
		moveTo,
		// Token: 0x04000209 RID: 521
		moveToRangeEnd,
		// Token: 0x0400020A RID: 522
		moveToRangeStart,
		// Token: 0x0400020B RID: 523
		permEnd,
		// Token: 0x0400020C RID: 524
		permStart,
		// Token: 0x0400020D RID: 525
		proofErr,
		// Token: 0x0400020E RID: 526
		sdt,
		// Token: 0x0400020F RID: 527
		tr
	}
}
