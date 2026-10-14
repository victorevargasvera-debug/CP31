using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000038 RID: 56
	public class XWPFFootnote : global::System.Collections.Generic.IEnumerator<global::NPOI.XWPF.UserModel.XWPFParagraph>, global::System.IDisposable, global::System.Collections.IEnumerator, global::NPOI.XWPF.UserModel.IBody
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x00007310 File Offset: 0x00005510
		public XWPFFootnote(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn note, global::NPOI.XWPF.UserModel.XWPFFootnotes xFootnotes)
		{
			this.footnotes = xFootnotes;
			this.ctFtnEdn = note;
			this.document = xFootnotes.GetXWPFDocument();
			this.Init();
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00007370 File Offset: 0x00005570
		public XWPFFootnote(global::NPOI.XWPF.UserModel.XWPFDocument document, global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn body)
		{
			this.ctFtnEdn = body;
			this.document = document;
			this.Init();
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000073C4 File Offset: 0x000055C4
		private void Init()
		{
			foreach (object obj in this.ctFtnEdn.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_P)
				{
					global::NPOI.XWPF.UserModel.XWPFParagraph item = new global::NPOI.XWPF.UserModel.XWPFParagraph((global::NPOI.OpenXmlFormats.Wordprocessing.CT_P)obj, this);
					this.bodyElements.Add(item);
					this.paragraphs.Add(item);
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)
				{
					global::NPOI.XWPF.UserModel.XWPFTable item2 = new global::NPOI.XWPF.UserModel.XWPFTable((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)obj, this);
					this.bodyElements.Add(item2);
					this.tables.Add(item2);
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock)
				{
					global::NPOI.XWPF.UserModel.XWPFSDT item3 = new global::NPOI.XWPF.UserModel.XWPFSDT((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock)obj, this);
					this.bodyElements.Add(item3);
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000074A0 File Offset: 0x000056A0
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFParagraph> Paragraphs
		{
			get
			{
				return this.paragraphs;
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000074A8 File Offset: 0x000056A8
		public global::System.Collections.Generic.IEnumerator<global::NPOI.XWPF.UserModel.XWPFParagraph> GetEnumerator()
		{
			return this.paragraphs.GetEnumerator();
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001DA RID: 474 RVA: 0x000074BA File Offset: 0x000056BA
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFTable> Tables
		{
			get
			{
				return this.tables;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000074C2 File Offset: 0x000056C2
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFPictureData> Pictures
		{
			get
			{
				return this.pictures;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001DC RID: 476 RVA: 0x000074CA File Offset: 0x000056CA
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.IBodyElement> BodyElements
		{
			get
			{
				return this.bodyElements;
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000074D2 File Offset: 0x000056D2
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn GetCTFtnEdn()
		{
			return this.ctFtnEdn;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000074DA File Offset: 0x000056DA
		public void SetCTFtnEdn(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn footnote)
		{
			this.ctFtnEdn = footnote;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000074E3 File Offset: 0x000056E3
		public global::NPOI.XWPF.UserModel.XWPFTable GetTableArray(int pos)
		{
			if (pos >= 0 && pos < this.tables.Count)
			{
				return this.tables[pos];
			}
			return null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00007508 File Offset: 0x00005708
		public void InsertTable(int pos, global::NPOI.XWPF.UserModel.XWPFTable table)
		{
			this.bodyElements.Insert(pos, table);
			int num = 0;
			while (num < this.ctFtnEdn.GetTblList().Count && this.ctFtnEdn.GetTblArray(num) != table.GetCTTbl())
			{
				num++;
			}
			this.tables.Insert(num, table);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00007560 File Offset: 0x00005760
		public global::NPOI.XWPF.UserModel.XWPFTable GetTable(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl ctTable)
		{
			foreach (global::NPOI.XWPF.UserModel.XWPFTable xwpftable in this.tables)
			{
				if (xwpftable == null)
				{
					return null;
				}
				if (xwpftable.GetCTTbl().Equals(ctTable))
				{
					return xwpftable;
				}
			}
			return null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000075C8 File Offset: 0x000057C8
		public global::NPOI.XWPF.UserModel.XWPFParagraph GetParagraph(global::NPOI.OpenXmlFormats.Wordprocessing.CT_P p)
		{
			foreach (global::NPOI.XWPF.UserModel.XWPFParagraph xwpfparagraph in this.paragraphs)
			{
				if (xwpfparagraph.GetCTP().Equals(p))
				{
					return xwpfparagraph;
				}
			}
			return null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000762C File Offset: 0x0000582C
		public global::NPOI.XWPF.UserModel.XWPFParagraph GetParagraphArray(int pos)
		{
			if (pos >= 0 && pos < this.paragraphs.Count)
			{
				return this.paragraphs[pos];
			}
			return null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00007650 File Offset: 0x00005850
		public global::NPOI.XWPF.UserModel.XWPFTableCell GetTableCell(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc cell)
		{
			object parent = cell.Parent;
			if (!(parent is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row))
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row ct_Row = (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row)parent;
			if (!(ct_Row.Parent is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl))
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl ctTable = (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)ct_Row.Parent;
			global::NPOI.XWPF.UserModel.XWPFTable table = this.GetTable(ctTable);
			if (table == null)
			{
				return null;
			}
			global::NPOI.XWPF.UserModel.XWPFTableRow row = table.GetRow(ct_Row);
			if (row == null)
			{
				return null;
			}
			return row.GetTableCell(cell);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000065E4 File Offset: 0x000047E4
		private bool IsCursorInFtn(global::System.Xml.XmlDocument cursor)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x000076B4 File Offset: 0x000058B4
		public global::NPOI.POIXMLDocumentPart Owner
		{
			get
			{
				return this.footnotes;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.XWPF.UserModel.XWPFTable InsertNewTbl(global::System.Xml.XmlDocument cursor)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.XWPF.UserModel.XWPFParagraph InsertNewParagraph(global::System.Xml.XmlDocument cursor)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000076BC File Offset: 0x000058BC
		public global::NPOI.XWPF.UserModel.XWPFTable AddNewTbl(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl table)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl ct_Tbl = this.ctFtnEdn.AddNewTbl();
			ct_Tbl.Set(table);
			global::NPOI.XWPF.UserModel.XWPFTable xwpftable = new global::NPOI.XWPF.UserModel.XWPFTable(ct_Tbl, this);
			this.tables.Add(xwpftable);
			return xwpftable;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000076F0 File Offset: 0x000058F0
		public global::NPOI.XWPF.UserModel.XWPFParagraph AddNewParagraph(global::NPOI.OpenXmlFormats.Wordprocessing.CT_P paragraph)
		{
			global::NPOI.XWPF.UserModel.XWPFParagraph xwpfparagraph = new global::NPOI.XWPF.UserModel.XWPFParagraph(this.ctFtnEdn.AddNewP(paragraph), this);
			this.paragraphs.Add(xwpfparagraph);
			return xwpfparagraph;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000771D File Offset: 0x0000591D
		public global::NPOI.XWPF.UserModel.XWPFDocument GetXWPFDocument()
		{
			return this.document;
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000076B4 File Offset: 0x000058B4
		public global::NPOI.POIXMLDocumentPart Part
		{
			get
			{
				return this.footnotes;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00007725 File Offset: 0x00005925
		public global::NPOI.XWPF.UserModel.BodyType PartType
		{
			get
			{
				return global::NPOI.XWPF.UserModel.BodyType.FOOTNOTE;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.XWPF.UserModel.XWPFParagraph Current
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000065E4 File Offset: 0x000047E4
		public void Dispose()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x000065E4 File Offset: 0x000047E4
		object global::System.Collections.IEnumerator.Current
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000065E4 File Offset: 0x000047E4
		public bool MoveNext()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000065E4 File Offset: 0x000047E4
		public void Reset()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040001C9 RID: 457
		private global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFParagraph> paragraphs = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFParagraph>();

		// Token: 0x040001CA RID: 458
		private global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTable> tables = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTable>();

		// Token: 0x040001CB RID: 459
		private global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPictureData> pictures = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFPictureData>();

		// Token: 0x040001CC RID: 460
		private global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IBodyElement> bodyElements = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IBodyElement>();

		// Token: 0x040001CD RID: 461
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdn ctFtnEdn;

		// Token: 0x040001CE RID: 462
		private global::NPOI.XWPF.UserModel.XWPFFootnotes footnotes;

		// Token: 0x040001CF RID: 463
		private global::NPOI.XWPF.UserModel.XWPFDocument document;
	}
}
