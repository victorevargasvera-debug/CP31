using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000068 RID: 104
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType25
	{
		// Token: 0x04000259 RID: 601
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x0400025A RID: 602
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x0400025B RID: 603
		bookmarkEnd,
		// Token: 0x0400025C RID: 604
		bookmarkStart,
		// Token: 0x0400025D RID: 605
		commentRangeEnd,
		// Token: 0x0400025E RID: 606
		commentRangeStart,
		// Token: 0x0400025F RID: 607
		customXml,
		// Token: 0x04000260 RID: 608
		customXmlDelRangeEnd,
		// Token: 0x04000261 RID: 609
		customXmlDelRangeStart,
		// Token: 0x04000262 RID: 610
		customXmlInsRangeEnd,
		// Token: 0x04000263 RID: 611
		customXmlInsRangeStart,
		// Token: 0x04000264 RID: 612
		customXmlMoveFromRangeEnd,
		// Token: 0x04000265 RID: 613
		customXmlMoveFromRangeStart,
		// Token: 0x04000266 RID: 614
		customXmlMoveToRangeEnd,
		// Token: 0x04000267 RID: 615
		customXmlMoveToRangeStart,
		// Token: 0x04000268 RID: 616
		del,
		// Token: 0x04000269 RID: 617
		fldSimple,
		// Token: 0x0400026A RID: 618
		hyperlink,
		// Token: 0x0400026B RID: 619
		ins,
		// Token: 0x0400026C RID: 620
		moveFrom,
		// Token: 0x0400026D RID: 621
		moveFromRangeEnd,
		// Token: 0x0400026E RID: 622
		moveFromRangeStart,
		// Token: 0x0400026F RID: 623
		moveTo,
		// Token: 0x04000270 RID: 624
		moveToRangeEnd,
		// Token: 0x04000271 RID: 625
		moveToRangeStart,
		// Token: 0x04000272 RID: 626
		permEnd,
		// Token: 0x04000273 RID: 627
		permStart,
		// Token: 0x04000274 RID: 628
		proofErr,
		// Token: 0x04000275 RID: 629
		r,
		// Token: 0x04000276 RID: 630
		sdt,
		// Token: 0x04000277 RID: 631
		smartTag,
		// Token: 0x04000278 RID: 632
		subDoc
	}
}
