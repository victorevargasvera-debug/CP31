using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000073 RID: 115
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum DocumentBodyItemChoiceType
	{
		// Token: 0x040002E3 RID: 739
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x040002E4 RID: 740
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x040002E5 RID: 741
		altChunk,
		// Token: 0x040002E6 RID: 742
		bookmarkEnd,
		// Token: 0x040002E7 RID: 743
		bookmarkStart,
		// Token: 0x040002E8 RID: 744
		commentRangeEnd,
		// Token: 0x040002E9 RID: 745
		commentRangeStart,
		// Token: 0x040002EA RID: 746
		customXml,
		// Token: 0x040002EB RID: 747
		customXmlDelRangeEnd,
		// Token: 0x040002EC RID: 748
		customXmlDelRangeStart,
		// Token: 0x040002ED RID: 749
		customXmlInsRangeEnd,
		// Token: 0x040002EE RID: 750
		customXmlInsRangeStart,
		// Token: 0x040002EF RID: 751
		customXmlMoveFromRangeEnd,
		// Token: 0x040002F0 RID: 752
		customXmlMoveFromRangeStart,
		// Token: 0x040002F1 RID: 753
		customXmlMoveToRangeEnd,
		// Token: 0x040002F2 RID: 754
		customXmlMoveToRangeStart,
		// Token: 0x040002F3 RID: 755
		del,
		// Token: 0x040002F4 RID: 756
		ins,
		// Token: 0x040002F5 RID: 757
		moveFrom,
		// Token: 0x040002F6 RID: 758
		moveFromRangeEnd,
		// Token: 0x040002F7 RID: 759
		moveFromRangeStart,
		// Token: 0x040002F8 RID: 760
		moveTo,
		// Token: 0x040002F9 RID: 761
		moveToRangeEnd,
		// Token: 0x040002FA RID: 762
		moveToRangeStart,
		// Token: 0x040002FB RID: 763
		p,
		// Token: 0x040002FC RID: 764
		permEnd,
		// Token: 0x040002FD RID: 765
		permStart,
		// Token: 0x040002FE RID: 766
		proofErr,
		// Token: 0x040002FF RID: 767
		sdt,
		// Token: 0x04000300 RID: 768
		tbl
	}
}
