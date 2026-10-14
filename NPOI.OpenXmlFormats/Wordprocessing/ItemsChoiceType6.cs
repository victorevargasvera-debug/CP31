using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000144 RID: 324
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType6
	{
		// Token: 0x040007F1 RID: 2033
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:acc")]
		acc,
		// Token: 0x040007F2 RID: 2034
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:bar")]
		bar,
		// Token: 0x040007F3 RID: 2035
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:borderBox")]
		borderBox,
		// Token: 0x040007F4 RID: 2036
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:box")]
		box,
		// Token: 0x040007F5 RID: 2037
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:d")]
		d,
		// Token: 0x040007F6 RID: 2038
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:eqArr")]
		eqArr,
		// Token: 0x040007F7 RID: 2039
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:f")]
		f,
		// Token: 0x040007F8 RID: 2040
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:func")]
		func,
		// Token: 0x040007F9 RID: 2041
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:groupChr")]
		groupChr,
		// Token: 0x040007FA RID: 2042
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:limLow")]
		limLow,
		// Token: 0x040007FB RID: 2043
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:limUpp")]
		limUpp,
		// Token: 0x040007FC RID: 2044
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:m")]
		m,
		// Token: 0x040007FD RID: 2045
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:nary")]
		nary,
		// Token: 0x040007FE RID: 2046
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x040007FF RID: 2047
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x04000800 RID: 2048
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:phant")]
		phant,
		// Token: 0x04000801 RID: 2049
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:r")]
		r,
		// Token: 0x04000802 RID: 2050
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:rad")]
		rad,
		// Token: 0x04000803 RID: 2051
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:sPre")]
		sPre,
		// Token: 0x04000804 RID: 2052
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:sSub")]
		sSub,
		// Token: 0x04000805 RID: 2053
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:sSubSup")]
		sSubSup,
		// Token: 0x04000806 RID: 2054
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:sSup")]
		sSup,
		// Token: 0x04000807 RID: 2055
		bookmarkEnd,
		// Token: 0x04000808 RID: 2056
		bookmarkStart,
		// Token: 0x04000809 RID: 2057
		commentRangeEnd,
		// Token: 0x0400080A RID: 2058
		commentRangeStart,
		// Token: 0x0400080B RID: 2059
		customXml,
		// Token: 0x0400080C RID: 2060
		customXmlDelRangeEnd,
		// Token: 0x0400080D RID: 2061
		customXmlDelRangeStart,
		// Token: 0x0400080E RID: 2062
		customXmlInsRangeEnd,
		// Token: 0x0400080F RID: 2063
		customXmlInsRangeStart,
		// Token: 0x04000810 RID: 2064
		customXmlMoveFromRangeEnd,
		// Token: 0x04000811 RID: 2065
		customXmlMoveFromRangeStart,
		// Token: 0x04000812 RID: 2066
		customXmlMoveToRangeEnd,
		// Token: 0x04000813 RID: 2067
		customXmlMoveToRangeStart,
		// Token: 0x04000814 RID: 2068
		del,
		// Token: 0x04000815 RID: 2069
		ins,
		// Token: 0x04000816 RID: 2070
		moveFrom,
		// Token: 0x04000817 RID: 2071
		moveFromRangeEnd,
		// Token: 0x04000818 RID: 2072
		moveFromRangeStart,
		// Token: 0x04000819 RID: 2073
		moveTo,
		// Token: 0x0400081A RID: 2074
		moveToRangeEnd,
		// Token: 0x0400081B RID: 2075
		moveToRangeStart,
		// Token: 0x0400081C RID: 2076
		permEnd,
		// Token: 0x0400081D RID: 2077
		permStart,
		// Token: 0x0400081E RID: 2078
		proofErr,
		// Token: 0x0400081F RID: 2079
		[global::System.Xml.Serialization.XmlEnum("r")]
		r1,
		// Token: 0x04000820 RID: 2080
		sdt,
		// Token: 0x04000821 RID: 2081
		smartTag
	}
}
