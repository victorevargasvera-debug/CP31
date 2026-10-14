using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000680 RID: 1664
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType8
	{
		// Token: 0x04002C4B RID: 11339
		acc,
		// Token: 0x04002C4C RID: 11340
		bar,
		// Token: 0x04002C4D RID: 11341
		borderBox,
		// Token: 0x04002C4E RID: 11342
		box,
		// Token: 0x04002C4F RID: 11343
		d,
		// Token: 0x04002C50 RID: 11344
		eqArr,
		// Token: 0x04002C51 RID: 11345
		f,
		// Token: 0x04002C52 RID: 11346
		func,
		// Token: 0x04002C53 RID: 11347
		groupChr,
		// Token: 0x04002C54 RID: 11348
		limLow,
		// Token: 0x04002C55 RID: 11349
		limUpp,
		// Token: 0x04002C56 RID: 11350
		m,
		// Token: 0x04002C57 RID: 11351
		nary,
		// Token: 0x04002C58 RID: 11352
		oMath,
		// Token: 0x04002C59 RID: 11353
		oMathPara,
		// Token: 0x04002C5A RID: 11354
		phant,
		// Token: 0x04002C5B RID: 11355
		r,
		// Token: 0x04002C5C RID: 11356
		rad,
		// Token: 0x04002C5D RID: 11357
		sPre,
		// Token: 0x04002C5E RID: 11358
		sSub,
		// Token: 0x04002C5F RID: 11359
		sSubSup,
		// Token: 0x04002C60 RID: 11360
		sSup,
		// Token: 0x04002C61 RID: 11361
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:bookmarkEnd")]
		bookmarkEnd,
		// Token: 0x04002C62 RID: 11362
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:bookmarkStart")]
		bookmarkStart,
		// Token: 0x04002C63 RID: 11363
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:commentRangeEnd")]
		commentRangeEnd,
		// Token: 0x04002C64 RID: 11364
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:commentRangeStart")]
		commentRangeStart,
		// Token: 0x04002C65 RID: 11365
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:customXmlDelRangeEnd")]
		customXmlDelRangeEnd,
		// Token: 0x04002C66 RID: 11366
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:customXmlDelRangeStart")]
		customXmlDelRangeStart,
		// Token: 0x04002C67 RID: 11367
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:customXmlInsRangeEnd")]
		customXmlInsRangeEnd,
		// Token: 0x04002C68 RID: 11368
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:customXmlInsRangeStart")]
		customXmlInsRangeStart,
		// Token: 0x04002C69 RID: 11369
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:customXmlMoveFromRangeEnd")]
		customXmlMoveFromRangeEnd,
		// Token: 0x04002C6A RID: 11370
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:customXmlMoveFromRangeStart")]
		customXmlMoveFromRangeStart,
		// Token: 0x04002C6B RID: 11371
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:customXmlMoveToRangeEnd")]
		customXmlMoveToRangeEnd,
		// Token: 0x04002C6C RID: 11372
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:customXmlMoveToRangeStart")]
		customXmlMoveToRangeStart,
		// Token: 0x04002C6D RID: 11373
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:del")]
		del,
		// Token: 0x04002C6E RID: 11374
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:ins")]
		ins,
		// Token: 0x04002C6F RID: 11375
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:moveFrom")]
		moveFrom,
		// Token: 0x04002C70 RID: 11376
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:moveFromRangeEnd")]
		moveFromRangeEnd,
		// Token: 0x04002C71 RID: 11377
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:moveFromRangeStart")]
		moveFromRangeStart,
		// Token: 0x04002C72 RID: 11378
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:moveTo")]
		moveTo,
		// Token: 0x04002C73 RID: 11379
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:moveToRangeEnd")]
		moveToRangeEnd,
		// Token: 0x04002C74 RID: 11380
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:moveToRangeStart")]
		moveToRangeStart,
		// Token: 0x04002C75 RID: 11381
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:permEnd")]
		permEnd,
		// Token: 0x04002C76 RID: 11382
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:permStart")]
		permStart,
		// Token: 0x04002C77 RID: 11383
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/wordprocessingml/2006/main:proofErr")]
		proofErr
	}
}
