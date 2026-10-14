using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000066 RID: 102
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType24
	{
		// Token: 0x04000233 RID: 563
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x04000234 RID: 564
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x04000235 RID: 565
		bookmarkEnd,
		// Token: 0x04000236 RID: 566
		bookmarkStart,
		// Token: 0x04000237 RID: 567
		commentRangeEnd,
		// Token: 0x04000238 RID: 568
		commentRangeStart,
		// Token: 0x04000239 RID: 569
		customXml,
		// Token: 0x0400023A RID: 570
		customXmlDelRangeEnd,
		// Token: 0x0400023B RID: 571
		customXmlDelRangeStart,
		// Token: 0x0400023C RID: 572
		customXmlInsRangeEnd,
		// Token: 0x0400023D RID: 573
		customXmlInsRangeStart,
		// Token: 0x0400023E RID: 574
		customXmlMoveFromRangeEnd,
		// Token: 0x0400023F RID: 575
		customXmlMoveFromRangeStart,
		// Token: 0x04000240 RID: 576
		customXmlMoveToRangeEnd,
		// Token: 0x04000241 RID: 577
		customXmlMoveToRangeStart,
		// Token: 0x04000242 RID: 578
		del,
		// Token: 0x04000243 RID: 579
		fldSimple,
		// Token: 0x04000244 RID: 580
		hyperlink,
		// Token: 0x04000245 RID: 581
		ins,
		// Token: 0x04000246 RID: 582
		moveFrom,
		// Token: 0x04000247 RID: 583
		moveFromRangeEnd,
		// Token: 0x04000248 RID: 584
		moveFromRangeStart,
		// Token: 0x04000249 RID: 585
		moveTo,
		// Token: 0x0400024A RID: 586
		moveToRangeEnd,
		// Token: 0x0400024B RID: 587
		moveToRangeStart,
		// Token: 0x0400024C RID: 588
		permEnd,
		// Token: 0x0400024D RID: 589
		permStart,
		// Token: 0x0400024E RID: 590
		proofErr,
		// Token: 0x0400024F RID: 591
		r,
		// Token: 0x04000250 RID: 592
		sdt,
		// Token: 0x04000251 RID: 593
		smartTag,
		// Token: 0x04000252 RID: 594
		subDoc
	}
}
