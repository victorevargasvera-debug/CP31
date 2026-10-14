using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000654 RID: 1620
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType7
	{
		// Token: 0x04002BA0 RID: 11168
		acc,
		// Token: 0x04002BA1 RID: 11169
		bar,
		// Token: 0x04002BA2 RID: 11170
		borderBox,
		// Token: 0x04002BA3 RID: 11171
		box,
		// Token: 0x04002BA4 RID: 11172
		d,
		// Token: 0x04002BA5 RID: 11173
		eqArr,
		// Token: 0x04002BA6 RID: 11174
		f,
		// Token: 0x04002BA7 RID: 11175
		func,
		// Token: 0x04002BA8 RID: 11176
		groupChr,
		// Token: 0x04002BA9 RID: 11177
		limLow,
		// Token: 0x04002BAA RID: 11178
		limUpp,
		// Token: 0x04002BAB RID: 11179
		m,
		// Token: 0x04002BAC RID: 11180
		nary,
		// Token: 0x04002BAD RID: 11181
		oMath,
		// Token: 0x04002BAE RID: 11182
		oMathPara,
		// Token: 0x04002BAF RID: 11183
		phant,
		// Token: 0x04002BB0 RID: 11184
		r,
		// Token: 0x04002BB1 RID: 11185
		rad,
		// Token: 0x04002BB2 RID: 11186
		sPre,
		// Token: 0x04002BB3 RID: 11187
		sSub,
		// Token: 0x04002BB4 RID: 11188
		sSubSup,
		// Token: 0x04002BB5 RID: 11189
		sSup,
		// Token: 0x04002BB6 RID: 11190
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:bookmarkEnd")]
		bookmarkEnd,
		// Token: 0x04002BB7 RID: 11191
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:bookmarkStart")]
		bookmarkStart,
		// Token: 0x04002BB8 RID: 11192
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:commentRangeEnd")]
		commentRangeEnd,
		// Token: 0x04002BB9 RID: 11193
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:commentRangeStart")]
		commentRangeStart,
		// Token: 0x04002BBA RID: 11194
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:customXmlDelRangeEnd")]
		customXmlDelRangeEnd,
		// Token: 0x04002BBB RID: 11195
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:customXmlDelRangeStart")]
		customXmlDelRangeStart,
		// Token: 0x04002BBC RID: 11196
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:customXmlInsRangeEnd")]
		customXmlInsRangeEnd,
		// Token: 0x04002BBD RID: 11197
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:customXmlInsRangeStart")]
		customXmlInsRangeStart,
		// Token: 0x04002BBE RID: 11198
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:customXmlMoveFromRangeEnd")]
		customXmlMoveFromRangeEnd,
		// Token: 0x04002BBF RID: 11199
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:customXmlMoveFromRangeStart")]
		customXmlMoveFromRangeStart,
		// Token: 0x04002BC0 RID: 11200
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:customXmlMoveToRangeEnd")]
		customXmlMoveToRangeEnd,
		// Token: 0x04002BC1 RID: 11201
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:customXmlMoveToRangeStart")]
		customXmlMoveToRangeStart,
		// Token: 0x04002BC2 RID: 11202
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:del")]
		del,
		// Token: 0x04002BC3 RID: 11203
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:ins")]
		ins,
		// Token: 0x04002BC4 RID: 11204
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:moveFrom")]
		moveFrom,
		// Token: 0x04002BC5 RID: 11205
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:moveFromRangeEnd")]
		moveFromRangeEnd,
		// Token: 0x04002BC6 RID: 11206
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:moveFromRangeStart")]
		moveFromRangeStart,
		// Token: 0x04002BC7 RID: 11207
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:moveTo")]
		moveTo,
		// Token: 0x04002BC8 RID: 11208
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:moveToRangeEnd")]
		moveToRangeEnd,
		// Token: 0x04002BC9 RID: 11209
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:moveToRangeStart")]
		moveToRangeStart,
		// Token: 0x04002BCA RID: 11210
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:permEnd")]
		permEnd,
		// Token: 0x04002BCB RID: 11211
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:permStart")]
		permStart,
		// Token: 0x04002BCC RID: 11212
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:proofErr")]
		proofErr
	}
}
