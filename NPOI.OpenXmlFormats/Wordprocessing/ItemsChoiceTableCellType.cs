using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001BC RID: 444
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceTableCellType
	{
		// Token: 0x04000D3B RID: 3387
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x04000D3C RID: 3388
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x04000D3D RID: 3389
		altChunk,
		// Token: 0x04000D3E RID: 3390
		bookmarkEnd,
		// Token: 0x04000D3F RID: 3391
		bookmarkStart,
		// Token: 0x04000D40 RID: 3392
		commentRangeEnd,
		// Token: 0x04000D41 RID: 3393
		commentRangeStart,
		// Token: 0x04000D42 RID: 3394
		customXml,
		// Token: 0x04000D43 RID: 3395
		customXmlDelRangeEnd,
		// Token: 0x04000D44 RID: 3396
		customXmlDelRangeStart,
		// Token: 0x04000D45 RID: 3397
		customXmlInsRangeEnd,
		// Token: 0x04000D46 RID: 3398
		customXmlInsRangeStart,
		// Token: 0x04000D47 RID: 3399
		customXmlMoveFromRangeEnd,
		// Token: 0x04000D48 RID: 3400
		customXmlMoveFromRangeStart,
		// Token: 0x04000D49 RID: 3401
		customXmlMoveToRangeEnd,
		// Token: 0x04000D4A RID: 3402
		customXmlMoveToRangeStart,
		// Token: 0x04000D4B RID: 3403
		del,
		// Token: 0x04000D4C RID: 3404
		ins,
		// Token: 0x04000D4D RID: 3405
		moveFrom,
		// Token: 0x04000D4E RID: 3406
		moveFromRangeEnd,
		// Token: 0x04000D4F RID: 3407
		moveFromRangeStart,
		// Token: 0x04000D50 RID: 3408
		moveTo,
		// Token: 0x04000D51 RID: 3409
		moveToRangeEnd,
		// Token: 0x04000D52 RID: 3410
		moveToRangeStart,
		// Token: 0x04000D53 RID: 3411
		p,
		// Token: 0x04000D54 RID: 3412
		permEnd,
		// Token: 0x04000D55 RID: 3413
		permStart,
		// Token: 0x04000D56 RID: 3414
		proofErr,
		// Token: 0x04000D57 RID: 3415
		sdt,
		// Token: 0x04000D58 RID: 3416
		tbl
	}
}
