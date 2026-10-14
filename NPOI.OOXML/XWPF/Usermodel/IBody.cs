using System;
using System.Collections.Generic;
using System.Xml;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x0200001F RID: 31
	public interface IBody
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000118 RID: 280
		global::NPOI.POIXMLDocumentPart Part { get; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000119 RID: 281
		global::NPOI.XWPF.UserModel.BodyType PartType { get; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600011A RID: 282
		global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.IBodyElement> BodyElements { get; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600011B RID: 283
		global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFParagraph> Paragraphs { get; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600011C RID: 284
		global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFTable> Tables { get; }

		// Token: 0x0600011D RID: 285
		global::NPOI.XWPF.UserModel.XWPFParagraph GetParagraph(global::NPOI.OpenXmlFormats.Wordprocessing.CT_P p);

		// Token: 0x0600011E RID: 286
		global::NPOI.XWPF.UserModel.XWPFTable GetTable(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl ctTable);

		// Token: 0x0600011F RID: 287
		global::NPOI.XWPF.UserModel.XWPFParagraph GetParagraphArray(int pos);

		// Token: 0x06000120 RID: 288
		global::NPOI.XWPF.UserModel.XWPFTable GetTableArray(int pos);

		// Token: 0x06000121 RID: 289
		global::NPOI.XWPF.UserModel.XWPFParagraph InsertNewParagraph(global::System.Xml.XmlDocument cursor);

		// Token: 0x06000122 RID: 290
		global::NPOI.XWPF.UserModel.XWPFTable InsertNewTbl(global::System.Xml.XmlDocument cursor);

		// Token: 0x06000123 RID: 291
		void InsertTable(int pos, global::NPOI.XWPF.UserModel.XWPFTable table);

		// Token: 0x06000124 RID: 292
		global::NPOI.XWPF.UserModel.XWPFTableCell GetTableCell(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc cell);

		// Token: 0x06000125 RID: 293
		global::NPOI.XWPF.UserModel.XWPFDocument GetXWPFDocument();
	}
}
