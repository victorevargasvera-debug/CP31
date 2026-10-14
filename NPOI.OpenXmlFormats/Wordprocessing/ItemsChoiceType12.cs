using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000111 RID: 273
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType12
	{
		// Token: 0x04000688 RID: 1672
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
		oMath,
		// Token: 0x04000689 RID: 1673
		[global::System.Xml.Serialization.XmlEnum("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
		oMathPara,
		// Token: 0x0400068A RID: 1674
		bookmarkEnd,
		// Token: 0x0400068B RID: 1675
		bookmarkStart,
		// Token: 0x0400068C RID: 1676
		commentRangeEnd,
		// Token: 0x0400068D RID: 1677
		commentRangeStart,
		// Token: 0x0400068E RID: 1678
		customXml,
		// Token: 0x0400068F RID: 1679
		customXmlDelRangeEnd,
		// Token: 0x04000690 RID: 1680
		customXmlDelRangeStart,
		// Token: 0x04000691 RID: 1681
		customXmlInsRangeEnd,
		// Token: 0x04000692 RID: 1682
		customXmlInsRangeStart,
		// Token: 0x04000693 RID: 1683
		customXmlMoveFromRangeEnd,
		// Token: 0x04000694 RID: 1684
		customXmlMoveFromRangeStart,
		// Token: 0x04000695 RID: 1685
		customXmlMoveToRangeEnd,
		// Token: 0x04000696 RID: 1686
		customXmlMoveToRangeStart,
		// Token: 0x04000697 RID: 1687
		del,
		// Token: 0x04000698 RID: 1688
		fldSimple,
		// Token: 0x04000699 RID: 1689
		hyperlink,
		// Token: 0x0400069A RID: 1690
		ins,
		// Token: 0x0400069B RID: 1691
		moveFrom,
		// Token: 0x0400069C RID: 1692
		moveFromRangeEnd,
		// Token: 0x0400069D RID: 1693
		moveFromRangeStart,
		// Token: 0x0400069E RID: 1694
		moveTo,
		// Token: 0x0400069F RID: 1695
		moveToRangeEnd,
		// Token: 0x040006A0 RID: 1696
		moveToRangeStart,
		// Token: 0x040006A1 RID: 1697
		permEnd,
		// Token: 0x040006A2 RID: 1698
		permStart,
		// Token: 0x040006A3 RID: 1699
		proofErr,
		// Token: 0x040006A4 RID: 1700
		r,
		// Token: 0x040006A5 RID: 1701
		sdt,
		// Token: 0x040006A6 RID: 1702
		smartTag,
		// Token: 0x040006A7 RID: 1703
		subDoc
	}
}
