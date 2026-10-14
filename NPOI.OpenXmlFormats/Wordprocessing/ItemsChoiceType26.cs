using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200006A RID: 106
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType26
	{
		// Token: 0x0400027F RID: 639
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x04000280 RID: 640
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x04000281 RID: 641
		bookmarkEnd,
		// Token: 0x04000282 RID: 642
		bookmarkStart,
		// Token: 0x04000283 RID: 643
		commentRangeEnd,
		// Token: 0x04000284 RID: 644
		commentRangeStart,
		// Token: 0x04000285 RID: 645
		customXml,
		// Token: 0x04000286 RID: 646
		customXmlDelRangeEnd,
		// Token: 0x04000287 RID: 647
		customXmlDelRangeStart,
		// Token: 0x04000288 RID: 648
		customXmlInsRangeEnd,
		// Token: 0x04000289 RID: 649
		customXmlInsRangeStart,
		// Token: 0x0400028A RID: 650
		customXmlMoveFromRangeEnd,
		// Token: 0x0400028B RID: 651
		customXmlMoveFromRangeStart,
		// Token: 0x0400028C RID: 652
		customXmlMoveToRangeEnd,
		// Token: 0x0400028D RID: 653
		customXmlMoveToRangeStart,
		// Token: 0x0400028E RID: 654
		del,
		// Token: 0x0400028F RID: 655
		ins,
		// Token: 0x04000290 RID: 656
		moveFrom,
		// Token: 0x04000291 RID: 657
		moveFromRangeEnd,
		// Token: 0x04000292 RID: 658
		moveFromRangeStart,
		// Token: 0x04000293 RID: 659
		moveTo,
		// Token: 0x04000294 RID: 660
		moveToRangeEnd,
		// Token: 0x04000295 RID: 661
		moveToRangeStart,
		// Token: 0x04000296 RID: 662
		p,
		// Token: 0x04000297 RID: 663
		permEnd,
		// Token: 0x04000298 RID: 664
		permStart,
		// Token: 0x04000299 RID: 665
		proofErr,
		// Token: 0x0400029A RID: 666
		sdt,
		// Token: 0x0400029B RID: 667
		tbl
	}
}
