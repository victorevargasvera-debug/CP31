using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000121 RID: 289
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType7
	{
		// Token: 0x04000705 RID: 1797
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x04000706 RID: 1798
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x04000707 RID: 1799
		altChunk,
		// Token: 0x04000708 RID: 1800
		bookmarkEnd,
		// Token: 0x04000709 RID: 1801
		bookmarkStart,
		// Token: 0x0400070A RID: 1802
		commentRangeEnd,
		// Token: 0x0400070B RID: 1803
		commentRangeStart,
		// Token: 0x0400070C RID: 1804
		customXml,
		// Token: 0x0400070D RID: 1805
		customXmlDelRangeEnd,
		// Token: 0x0400070E RID: 1806
		customXmlDelRangeStart,
		// Token: 0x0400070F RID: 1807
		customXmlInsRangeEnd,
		// Token: 0x04000710 RID: 1808
		customXmlInsRangeStart,
		// Token: 0x04000711 RID: 1809
		customXmlMoveFromRangeEnd,
		// Token: 0x04000712 RID: 1810
		customXmlMoveFromRangeStart,
		// Token: 0x04000713 RID: 1811
		customXmlMoveToRangeEnd,
		// Token: 0x04000714 RID: 1812
		customXmlMoveToRangeStart,
		// Token: 0x04000715 RID: 1813
		del,
		// Token: 0x04000716 RID: 1814
		ins,
		// Token: 0x04000717 RID: 1815
		moveFrom,
		// Token: 0x04000718 RID: 1816
		moveFromRangeEnd,
		// Token: 0x04000719 RID: 1817
		moveFromRangeStart,
		// Token: 0x0400071A RID: 1818
		moveTo,
		// Token: 0x0400071B RID: 1819
		moveToRangeEnd,
		// Token: 0x0400071C RID: 1820
		moveToRangeStart,
		// Token: 0x0400071D RID: 1821
		p,
		// Token: 0x0400071E RID: 1822
		permEnd,
		// Token: 0x0400071F RID: 1823
		permStart,
		// Token: 0x04000720 RID: 1824
		proofErr,
		// Token: 0x04000721 RID: 1825
		sdt,
		// Token: 0x04000722 RID: 1826
		tbl
	}
}
