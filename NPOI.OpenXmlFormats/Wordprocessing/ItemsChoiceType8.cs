using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000119 RID: 281
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType8
	{
		// Token: 0x040006D1 RID: 1745
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x040006D2 RID: 1746
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x040006D3 RID: 1747
		altChunk,
		// Token: 0x040006D4 RID: 1748
		bookmarkEnd,
		// Token: 0x040006D5 RID: 1749
		bookmarkStart,
		// Token: 0x040006D6 RID: 1750
		commentRangeEnd,
		// Token: 0x040006D7 RID: 1751
		commentRangeStart,
		// Token: 0x040006D8 RID: 1752
		customXml,
		// Token: 0x040006D9 RID: 1753
		customXmlDelRangeEnd,
		// Token: 0x040006DA RID: 1754
		customXmlDelRangeStart,
		// Token: 0x040006DB RID: 1755
		customXmlInsRangeEnd,
		// Token: 0x040006DC RID: 1756
		customXmlInsRangeStart,
		// Token: 0x040006DD RID: 1757
		customXmlMoveFromRangeEnd,
		// Token: 0x040006DE RID: 1758
		customXmlMoveFromRangeStart,
		// Token: 0x040006DF RID: 1759
		customXmlMoveToRangeEnd,
		// Token: 0x040006E0 RID: 1760
		customXmlMoveToRangeStart,
		// Token: 0x040006E1 RID: 1761
		del,
		// Token: 0x040006E2 RID: 1762
		ins,
		// Token: 0x040006E3 RID: 1763
		moveFrom,
		// Token: 0x040006E4 RID: 1764
		moveFromRangeEnd,
		// Token: 0x040006E5 RID: 1765
		moveFromRangeStart,
		// Token: 0x040006E6 RID: 1766
		moveTo,
		// Token: 0x040006E7 RID: 1767
		moveToRangeEnd,
		// Token: 0x040006E8 RID: 1768
		moveToRangeStart,
		// Token: 0x040006E9 RID: 1769
		p,
		// Token: 0x040006EA RID: 1770
		permEnd,
		// Token: 0x040006EB RID: 1771
		permStart,
		// Token: 0x040006EC RID: 1772
		proofErr,
		// Token: 0x040006ED RID: 1773
		sdt,
		// Token: 0x040006EE RID: 1774
		tbl
	}
}
