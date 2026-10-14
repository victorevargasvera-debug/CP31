using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000064 RID: 100
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType22
	{
		// Token: 0x04000211 RID: 529
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x04000212 RID: 530
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x04000213 RID: 531
		bookmarkEnd,
		// Token: 0x04000214 RID: 532
		bookmarkStart,
		// Token: 0x04000215 RID: 533
		commentRangeEnd,
		// Token: 0x04000216 RID: 534
		commentRangeStart,
		// Token: 0x04000217 RID: 535
		customXml,
		// Token: 0x04000218 RID: 536
		customXmlDelRangeEnd,
		// Token: 0x04000219 RID: 537
		customXmlDelRangeStart,
		// Token: 0x0400021A RID: 538
		customXmlInsRangeEnd,
		// Token: 0x0400021B RID: 539
		customXmlInsRangeStart,
		// Token: 0x0400021C RID: 540
		customXmlMoveFromRangeEnd,
		// Token: 0x0400021D RID: 541
		customXmlMoveFromRangeStart,
		// Token: 0x0400021E RID: 542
		customXmlMoveToRangeEnd,
		// Token: 0x0400021F RID: 543
		customXmlMoveToRangeStart,
		// Token: 0x04000220 RID: 544
		del,
		// Token: 0x04000221 RID: 545
		ins,
		// Token: 0x04000222 RID: 546
		moveFrom,
		// Token: 0x04000223 RID: 547
		moveFromRangeEnd,
		// Token: 0x04000224 RID: 548
		moveFromRangeStart,
		// Token: 0x04000225 RID: 549
		moveTo,
		// Token: 0x04000226 RID: 550
		moveToRangeEnd,
		// Token: 0x04000227 RID: 551
		moveToRangeStart,
		// Token: 0x04000228 RID: 552
		permEnd,
		// Token: 0x04000229 RID: 553
		permStart,
		// Token: 0x0400022A RID: 554
		proofErr,
		// Token: 0x0400022B RID: 555
		sdt,
		// Token: 0x0400022C RID: 556
		tr
	}
}
