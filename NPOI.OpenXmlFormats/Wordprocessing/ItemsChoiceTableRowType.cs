using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001CC RID: 460
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceTableRowType
	{
		// Token: 0x04000DA1 RID: 3489
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x04000DA2 RID: 3490
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x04000DA3 RID: 3491
		bookmarkEnd,
		// Token: 0x04000DA4 RID: 3492
		bookmarkStart,
		// Token: 0x04000DA5 RID: 3493
		commentRangeEnd,
		// Token: 0x04000DA6 RID: 3494
		commentRangeStart,
		// Token: 0x04000DA7 RID: 3495
		customXml,
		// Token: 0x04000DA8 RID: 3496
		customXmlDelRangeEnd,
		// Token: 0x04000DA9 RID: 3497
		customXmlDelRangeStart,
		// Token: 0x04000DAA RID: 3498
		customXmlInsRangeEnd,
		// Token: 0x04000DAB RID: 3499
		customXmlInsRangeStart,
		// Token: 0x04000DAC RID: 3500
		customXmlMoveFromRangeEnd,
		// Token: 0x04000DAD RID: 3501
		customXmlMoveFromRangeStart,
		// Token: 0x04000DAE RID: 3502
		customXmlMoveToRangeEnd,
		// Token: 0x04000DAF RID: 3503
		customXmlMoveToRangeStart,
		// Token: 0x04000DB0 RID: 3504
		del,
		// Token: 0x04000DB1 RID: 3505
		ins,
		// Token: 0x04000DB2 RID: 3506
		moveFrom,
		// Token: 0x04000DB3 RID: 3507
		moveFromRangeEnd,
		// Token: 0x04000DB4 RID: 3508
		moveFromRangeStart,
		// Token: 0x04000DB5 RID: 3509
		moveTo,
		// Token: 0x04000DB6 RID: 3510
		moveToRangeEnd,
		// Token: 0x04000DB7 RID: 3511
		moveToRangeStart,
		// Token: 0x04000DB8 RID: 3512
		permEnd,
		// Token: 0x04000DB9 RID: 3513
		permStart,
		// Token: 0x04000DBA RID: 3514
		proofErr,
		// Token: 0x04000DBB RID: 3515
		sdt,
		// Token: 0x04000DBC RID: 3516
		tc
	}
}
