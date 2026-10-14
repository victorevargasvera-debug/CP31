using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200006C RID: 108
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType27
	{
		// Token: 0x040002A2 RID: 674
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x040002A3 RID: 675
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x040002A4 RID: 676
		bookmarkEnd,
		// Token: 0x040002A5 RID: 677
		bookmarkStart,
		// Token: 0x040002A6 RID: 678
		commentRangeEnd,
		// Token: 0x040002A7 RID: 679
		commentRangeStart,
		// Token: 0x040002A8 RID: 680
		customXml,
		// Token: 0x040002A9 RID: 681
		customXmlDelRangeEnd,
		// Token: 0x040002AA RID: 682
		customXmlDelRangeStart,
		// Token: 0x040002AB RID: 683
		customXmlInsRangeEnd,
		// Token: 0x040002AC RID: 684
		customXmlInsRangeStart,
		// Token: 0x040002AD RID: 685
		customXmlMoveFromRangeEnd,
		// Token: 0x040002AE RID: 686
		customXmlMoveFromRangeStart,
		// Token: 0x040002AF RID: 687
		customXmlMoveToRangeEnd,
		// Token: 0x040002B0 RID: 688
		customXmlMoveToRangeStart,
		// Token: 0x040002B1 RID: 689
		del,
		// Token: 0x040002B2 RID: 690
		ins,
		// Token: 0x040002B3 RID: 691
		moveFrom,
		// Token: 0x040002B4 RID: 692
		moveFromRangeEnd,
		// Token: 0x040002B5 RID: 693
		moveFromRangeStart,
		// Token: 0x040002B6 RID: 694
		moveTo,
		// Token: 0x040002B7 RID: 695
		moveToRangeEnd,
		// Token: 0x040002B8 RID: 696
		moveToRangeStart,
		// Token: 0x040002B9 RID: 697
		permEnd,
		// Token: 0x040002BA RID: 698
		permStart,
		// Token: 0x040002BB RID: 699
		proofErr,
		// Token: 0x040002BC RID: 700
		sdt,
		// Token: 0x040002BD RID: 701
		tc
	}
}
