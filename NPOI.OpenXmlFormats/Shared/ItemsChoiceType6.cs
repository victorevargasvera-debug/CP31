using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200064E RID: 1614
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType6
	{
		// Token: 0x04002B72 RID: 11122
		t,
		// Token: 0x04002B73 RID: 11123
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:annotationRef")]
		annotationRef,
		// Token: 0x04002B74 RID: 11124
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:br")]
		br,
		// Token: 0x04002B75 RID: 11125
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:commentReference")]
		commentReference,
		// Token: 0x04002B76 RID: 11126
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:continuationSeparator")]
		continuationSeparator,
		// Token: 0x04002B77 RID: 11127
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:cr")]
		cr,
		// Token: 0x04002B78 RID: 11128
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:dayLong")]
		dayLong,
		// Token: 0x04002B79 RID: 11129
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:dayShort")]
		dayShort,
		// Token: 0x04002B7A RID: 11130
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:delInstrText")]
		delInstrText,
		// Token: 0x04002B7B RID: 11131
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:delText")]
		delText,
		// Token: 0x04002B7C RID: 11132
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:drawing")]
		drawing,
		// Token: 0x04002B7D RID: 11133
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:endnoteRef")]
		endnoteRef,
		// Token: 0x04002B7E RID: 11134
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:endnoteReference")]
		endnoteReference,
		// Token: 0x04002B7F RID: 11135
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:fldChar")]
		fldChar,
		// Token: 0x04002B80 RID: 11136
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:footnoteRef")]
		footnoteRef,
		// Token: 0x04002B81 RID: 11137
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:footnoteReference")]
		footnoteReference,
		// Token: 0x04002B82 RID: 11138
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:instrText")]
		instrText,
		// Token: 0x04002B83 RID: 11139
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:lastRenderedPageBreak")]
		lastRenderedPageBreak,
		// Token: 0x04002B84 RID: 11140
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:monthLong")]
		monthLong,
		// Token: 0x04002B85 RID: 11141
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:monthShort")]
		monthShort,
		// Token: 0x04002B86 RID: 11142
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:noBreakHyphen")]
		noBreakHyphen,
		// Token: 0x04002B87 RID: 11143
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:object")]
		@object,
		// Token: 0x04002B88 RID: 11144
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:pgNum")]
		pgNum,
		// Token: 0x04002B89 RID: 11145
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:pict")]
		pict,
		// Token: 0x04002B8A RID: 11146
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:ptab")]
		ptab,
		// Token: 0x04002B8B RID: 11147
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:ruby")]
		ruby,
		// Token: 0x04002B8C RID: 11148
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:separator")]
		separator,
		// Token: 0x04002B8D RID: 11149
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:softHyphen")]
		softHyphen,
		// Token: 0x04002B8E RID: 11150
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:sym")]
		sym,
		// Token: 0x04002B8F RID: 11151
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:t")]
		t1,
		// Token: 0x04002B90 RID: 11152
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:tab")]
		tab,
		// Token: 0x04002B91 RID: 11153
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:yearLong")]
		yearLong,
		// Token: 0x04002B92 RID: 11154
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:yearShort")]
		yearShort
	}
}
