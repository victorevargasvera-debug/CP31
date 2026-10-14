using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200006E RID: 110
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum Items1ChoiceType
	{
		// Token: 0x040002C0 RID: 704
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x040002C1 RID: 705
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x040002C2 RID: 706
		bookmarkEnd,
		// Token: 0x040002C3 RID: 707
		bookmarkStart,
		// Token: 0x040002C4 RID: 708
		commentRangeEnd,
		// Token: 0x040002C5 RID: 709
		commentRangeStart,
		// Token: 0x040002C6 RID: 710
		customXml,
		// Token: 0x040002C7 RID: 711
		customXmlDelRangeEnd,
		// Token: 0x040002C8 RID: 712
		customXmlDelRangeStart,
		// Token: 0x040002C9 RID: 713
		customXmlInsRangeEnd,
		// Token: 0x040002CA RID: 714
		customXmlInsRangeStart,
		// Token: 0x040002CB RID: 715
		customXmlMoveFromRangeEnd,
		// Token: 0x040002CC RID: 716
		customXmlMoveFromRangeStart,
		// Token: 0x040002CD RID: 717
		customXmlMoveToRangeEnd,
		// Token: 0x040002CE RID: 718
		customXmlMoveToRangeStart,
		// Token: 0x040002CF RID: 719
		del,
		// Token: 0x040002D0 RID: 720
		ins,
		// Token: 0x040002D1 RID: 721
		moveFrom,
		// Token: 0x040002D2 RID: 722
		moveFromRangeEnd,
		// Token: 0x040002D3 RID: 723
		moveFromRangeStart,
		// Token: 0x040002D4 RID: 724
		moveTo,
		// Token: 0x040002D5 RID: 725
		moveToRangeEnd,
		// Token: 0x040002D6 RID: 726
		moveToRangeStart,
		// Token: 0x040002D7 RID: 727
		permEnd,
		// Token: 0x040002D8 RID: 728
		permStart,
		// Token: 0x040002D9 RID: 729
		proofErr,
		// Token: 0x040002DA RID: 730
		sdt,
		// Token: 0x040002DB RID: 731
		tr
	}
}
