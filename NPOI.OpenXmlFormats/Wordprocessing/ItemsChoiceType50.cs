using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200005C RID: 92
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType50
	{
		// Token: 0x040001C5 RID: 453
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x040001C6 RID: 454
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x040001C7 RID: 455
		altChunk,
		// Token: 0x040001C8 RID: 456
		bookmarkEnd,
		// Token: 0x040001C9 RID: 457
		bookmarkStart,
		// Token: 0x040001CA RID: 458
		commentRangeEnd,
		// Token: 0x040001CB RID: 459
		commentRangeStart,
		// Token: 0x040001CC RID: 460
		customXml,
		// Token: 0x040001CD RID: 461
		customXmlDelRangeEnd,
		// Token: 0x040001CE RID: 462
		customXmlDelRangeStart,
		// Token: 0x040001CF RID: 463
		customXmlInsRangeEnd,
		// Token: 0x040001D0 RID: 464
		customXmlInsRangeStart,
		// Token: 0x040001D1 RID: 465
		customXmlMoveFromRangeEnd,
		// Token: 0x040001D2 RID: 466
		customXmlMoveFromRangeStart,
		// Token: 0x040001D3 RID: 467
		customXmlMoveToRangeEnd,
		// Token: 0x040001D4 RID: 468
		customXmlMoveToRangeStart,
		// Token: 0x040001D5 RID: 469
		del,
		// Token: 0x040001D6 RID: 470
		ins,
		// Token: 0x040001D7 RID: 471
		moveFrom,
		// Token: 0x040001D8 RID: 472
		moveFromRangeEnd,
		// Token: 0x040001D9 RID: 473
		moveFromRangeStart,
		// Token: 0x040001DA RID: 474
		moveTo,
		// Token: 0x040001DB RID: 475
		moveToRangeEnd,
		// Token: 0x040001DC RID: 476
		moveToRangeStart,
		// Token: 0x040001DD RID: 477
		p,
		// Token: 0x040001DE RID: 478
		permEnd,
		// Token: 0x040001DF RID: 479
		permStart,
		// Token: 0x040001E0 RID: 480
		proofErr,
		// Token: 0x040001E1 RID: 481
		sdt,
		// Token: 0x040001E2 RID: 482
		tbl
	}
}
