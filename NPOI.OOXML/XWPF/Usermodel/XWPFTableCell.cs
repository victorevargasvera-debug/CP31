using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000050 RID: 80
	public class XWPFTableCell : global::NPOI.XWPF.UserModel.IBody, global::NPOI.XWPF.UserModel.ICell
	{
		// Token: 0x06000391 RID: 913 RVA: 0x0000E4E0 File Offset: 0x0000C6E0
		static XWPFTableCell()
		{
			global::NPOI.XWPF.UserModel.XWPFTableCell.alignMap.Add(global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign.TOP, global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc.top);
			global::NPOI.XWPF.UserModel.XWPFTableCell.alignMap.Add(global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign.CENTER, global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc.center);
			global::NPOI.XWPF.UserModel.XWPFTableCell.alignMap.Add(global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign.BOTH, global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc.both);
			global::NPOI.XWPF.UserModel.XWPFTableCell.alignMap.Add(global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign.BOTTOM, global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc.bottom);
			global::NPOI.XWPF.UserModel.XWPFTableCell.stVertAlignTypeMap = new global::System.Collections.Generic.Dictionary<global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc, global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign>();
			global::NPOI.XWPF.UserModel.XWPFTableCell.stVertAlignTypeMap.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc.top, global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign.TOP);
			global::NPOI.XWPF.UserModel.XWPFTableCell.stVertAlignTypeMap.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc.center, global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign.CENTER);
			global::NPOI.XWPF.UserModel.XWPFTableCell.stVertAlignTypeMap.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc.both, global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign.BOTH);
			global::NPOI.XWPF.UserModel.XWPFTableCell.stVertAlignTypeMap.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc.bottom, global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign.BOTTOM);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000E564 File Offset: 0x0000C764
		public XWPFTableCell(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc cell, global::NPOI.XWPF.UserModel.XWPFTableRow tableRow, global::NPOI.XWPF.UserModel.IBody part)
		{
			this.ctTc = cell;
			this.part = part;
			this.tableRow = tableRow;
			if (cell.GetPList().Count < 1)
			{
				cell.AddNewP();
			}
			this.bodyElements = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IBodyElement>();
			this.paragraphs = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFParagraph>();
			this.tables = new global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTable>();
			foreach (object obj in this.ctTc.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_P)
				{
					global::NPOI.XWPF.UserModel.XWPFParagraph item = new global::NPOI.XWPF.UserModel.XWPFParagraph((global::NPOI.OpenXmlFormats.Wordprocessing.CT_P)obj, this);
					this.paragraphs.Add(item);
					this.bodyElements.Add(item);
				}
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)
				{
					global::NPOI.XWPF.UserModel.XWPFTable item2 = new global::NPOI.XWPF.UserModel.XWPFTable((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl)obj, this);
					this.tables.Add(item2);
					this.bodyElements.Add(item2);
				}
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock)
				{
					global::NPOI.XWPF.UserModel.XWPFSDT item3 = new global::NPOI.XWPF.UserModel.XWPFSDT((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtBlock)obj, this);
					this.bodyElements.Add(item3);
				}
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRun)
				{
					global::NPOI.XWPF.UserModel.XWPFSDT item4 = new global::NPOI.XWPF.UserModel.XWPFSDT((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtRun)obj, this);
					this.bodyElements.Add(item4);
				}
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000E6B0 File Offset: 0x0000C8B0
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc GetCTTc()
		{
			return this.ctTc;
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.IBodyElement> BodyElements
		{
			get
			{
				return this.bodyElements.AsReadOnly();
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000E6C5 File Offset: 0x0000C8C5
		public void SetParagraph(global::NPOI.XWPF.UserModel.XWPFParagraph p)
		{
			if (this.ctTc.SizeOfPArray() == 0)
			{
				this.ctTc.AddNewP();
			}
			this.ctTc.SetPArray(0, p.GetCTP());
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0000E6F2 File Offset: 0x0000C8F2
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFParagraph> Paragraphs
		{
			get
			{
				return this.paragraphs;
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000E6FC File Offset: 0x0000C8FC
		public global::NPOI.XWPF.UserModel.XWPFParagraph AddParagraph()
		{
			global::NPOI.XWPF.UserModel.XWPFParagraph xwpfparagraph = new global::NPOI.XWPF.UserModel.XWPFParagraph(this.ctTc.AddNewP(), this);
			this.AddParagraph(xwpfparagraph);
			return xwpfparagraph;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000E723 File Offset: 0x0000C923
		public void AddParagraph(global::NPOI.XWPF.UserModel.XWPFParagraph p)
		{
			this.paragraphs.Add(p);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000E731 File Offset: 0x0000C931
		public void RemoveParagraph(int pos)
		{
			this.paragraphs.RemoveAt(pos);
			this.ctTc.RemoveP(pos);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000E74C File Offset: 0x0000C94C
		public global::NPOI.XWPF.UserModel.XWPFParagraph GetParagraph(global::NPOI.OpenXmlFormats.Wordprocessing.CT_P p)
		{
			foreach (global::NPOI.XWPF.UserModel.XWPFParagraph xwpfparagraph in this.paragraphs)
			{
				if (p.Equals(xwpfparagraph.GetCTP()))
				{
					return xwpfparagraph;
				}
			}
			return null;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000E7B0 File Offset: 0x0000C9B0
		public void SetBorderBottom(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType type, int size, int space, string rgbColor)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr ct_TcPr = this.GetCTTc().IsSetTcPr() ? this.GetCTTc().tcPr : this.GetCTTc().AddNewTcPr();
			((ct_TcPr.tcBorders == null) ? ct_TcPr.AddNewTcBorders() : ct_TcPr.tcBorders).bottom = global::NPOI.XWPF.UserModel.XWPFTableCell.CreateBorder(type, size, space, rgbColor);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000E808 File Offset: 0x0000CA08
		public void SetBorderTop(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType type, int size, int space, string rgbColor)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr ct_TcPr = this.GetCTTc().IsSetTcPr() ? this.GetCTTc().tcPr : this.GetCTTc().AddNewTcPr();
			((ct_TcPr.tcBorders == null) ? ct_TcPr.AddNewTcBorders() : ct_TcPr.tcBorders).top = global::NPOI.XWPF.UserModel.XWPFTableCell.CreateBorder(type, size, space, rgbColor);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000E860 File Offset: 0x0000CA60
		public void SetBorderLeft(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType type, int size, int space, string rgbColor)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr ct_TcPr = this.GetCTTc().IsSetTcPr() ? this.GetCTTc().tcPr : this.GetCTTc().AddNewTcPr();
			((ct_TcPr.tcBorders == null) ? ct_TcPr.AddNewTcBorders() : ct_TcPr.tcBorders).left = global::NPOI.XWPF.UserModel.XWPFTableCell.CreateBorder(type, size, space, rgbColor);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000E8B8 File Offset: 0x0000CAB8
		public void SetBorderRight(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType type, int size, int space, string rgbColor)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr ct_TcPr = this.GetCTTc().IsSetTcPr() ? this.GetCTTc().tcPr : this.GetCTTc().AddNewTcPr();
			((ct_TcPr.tcBorders == null) ? ct_TcPr.AddNewTcBorders() : ct_TcPr.tcBorders).right = global::NPOI.XWPF.UserModel.XWPFTableCell.CreateBorder(type, size, space, rgbColor);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000E910 File Offset: 0x0000CB10
		private static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border CreateBorder(global::NPOI.XWPF.UserModel.XWPFTable.XWPFBorderType type, int size, int space, string rgbColor)
		{
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border
			{
				val = global::NPOI.XWPF.UserModel.XWPFTable.xwpfBorderTypeMap[type],
				sz = new ulong?((ulong)((long)size)),
				space = new ulong?((ulong)((long)space)),
				color = rgbColor
			};
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000E949 File Offset: 0x0000CB49
		public void SetText(string text)
		{
			new global::NPOI.XWPF.UserModel.XWPFParagraph((this.ctTc.SizeOfPArray() == 0) ? this.ctTc.AddNewP() : this.ctTc.GetPArray(0), this).CreateRun().AppendText(text);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000E982 File Offset: 0x0000CB82
		public global::NPOI.XWPF.UserModel.XWPFTableRow GetTableRow()
		{
			return this.tableRow;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000E98C File Offset: 0x0000CB8C
		public void SetColor(string rgbStr)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr ct_TcPr = this.ctTc.IsSetTcPr() ? this.ctTc.tcPr : this.ctTc.AddNewTcPr();
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd ct_Shd = ct_TcPr.IsSetShd() ? ct_TcPr.shd : ct_TcPr.AddNewShd();
			ct_Shd.color = "auto";
			ct_Shd.val = global::NPOI.OpenXmlFormats.Wordprocessing.ST_Shd.clear;
			ct_Shd.fill = rgbStr;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000E9F0 File Offset: 0x0000CBF0
		public string GetColor()
		{
			string result = null;
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr tcPr = this.ctTc.tcPr;
			if (tcPr != null)
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd shd = tcPr.shd;
				if (shd != null)
				{
					result = shd.fill;
				}
			}
			return result;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000EA20 File Offset: 0x0000CC20
		public void SetVerticalAlignment(global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign vAlign)
		{
			(this.ctTc.IsSetTcPr() ? this.ctTc.tcPr : this.ctTc.AddNewTcPr()).AddNewVAlign().val = new global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc?(global::NPOI.XWPF.UserModel.XWPFTableCell.alignMap[vAlign]);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000EA6C File Offset: 0x0000CC6C
		public global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign? GetVerticalAlignment()
		{
			global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign? result = null;
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TcPr tcPr = this.ctTc.tcPr;
			if (tcPr != null)
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalJc vAlign = tcPr.vAlign;
				if (vAlign != null)
				{
					result = new global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign?(global::NPOI.XWPF.UserModel.XWPFTableCell.stVertAlignTypeMap[vAlign.val.Value]);
				}
				else
				{
					result = new global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign?(global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign.TOP);
				}
				if (vAlign != null && vAlign.val != null)
				{
					result = new global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign?(global::NPOI.XWPF.UserModel.XWPFTableCell.stVertAlignTypeMap[vAlign.val.Value]);
				}
			}
			return result;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.XWPF.UserModel.XWPFParagraph InsertNewParagraph(global::System.Xml.XmlDocument cursor)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.XWPF.UserModel.XWPFTable InsertNewTbl(global::System.Xml.XmlDocument cursor)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000065E4 File Offset: 0x000047E4
		private bool IsCursorInTableCell(global::System.Xml.XmlDocument cursor)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000EAF6 File Offset: 0x0000CCF6
		public global::NPOI.XWPF.UserModel.XWPFParagraph GetParagraphArray(int pos)
		{
			if (pos >= 0 && pos < this.paragraphs.Count)
			{
				return this.paragraphs[pos];
			}
			return null;
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0000EB18 File Offset: 0x0000CD18
		public global::NPOI.POIXMLDocumentPart Part
		{
			get
			{
				return this.tableRow.GetTable().Part;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0000EB2A File Offset: 0x0000CD2A
		public global::NPOI.XWPF.UserModel.BodyType PartType
		{
			get
			{
				return global::NPOI.XWPF.UserModel.BodyType.TABLECELL;
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000EB30 File Offset: 0x0000CD30
		public global::NPOI.XWPF.UserModel.XWPFTable GetTable(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tbl ctTable)
		{
			for (int i = 0; i < this.tables.Count; i++)
			{
				if (this.Tables[i].GetCTTbl() == ctTable)
				{
					return this.Tables[i];
				}
			}
			return null;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000EB75 File Offset: 0x0000CD75
		public global::NPOI.XWPF.UserModel.XWPFTable GetTableArray(int pos)
		{
			if (pos >= 0 && pos < this.tables.Count)
			{
				return this.tables[pos];
			}
			return null;
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0000EB97 File Offset: 0x0000CD97
		public global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.XWPFTable> Tables
		{
			get
			{
				return this.tables.AsReadOnly();
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000EBA4 File Offset: 0x0000CDA4
		public void InsertTable(int pos, global::NPOI.XWPF.UserModel.XWPFTable table)
		{
			this.bodyElements.Insert(pos, table);
			int num = 0;
			while (num < this.ctTc.GetTblList().Count && this.ctTc.GetTblArray(num) != table.GetCTTbl())
			{
				num++;
			}
			this.tables.Insert(num, table);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000EBFC File Offset: 0x0000CDFC
		public string GetText()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (global::NPOI.XWPF.UserModel.XWPFParagraph xwpfparagraph in this.paragraphs)
			{
				stringBuilder.Append(xwpfparagraph.Text);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000EC64 File Offset: 0x0000CE64
		public string GetTextRecursively()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < this.bodyElements.Count; i++)
			{
				bool isLast = i == this.bodyElements.Count - 1;
				this.AppendBodyElementText(stringBuilder, this.bodyElements[i], isLast);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000ECBC File Offset: 0x0000CEBC
		private void AppendBodyElementText(global::System.Text.StringBuilder text, global::NPOI.XWPF.UserModel.IBodyElement e, bool isLast)
		{
			if (e is global::NPOI.XWPF.UserModel.XWPFParagraph)
			{
				text.Append(((global::NPOI.XWPF.UserModel.XWPFParagraph)e).Text);
				if (!isLast)
				{
					text.Append('\t');
					return;
				}
			}
			else if (e is global::NPOI.XWPF.UserModel.XWPFTable)
			{
				foreach (global::NPOI.XWPF.UserModel.XWPFTableRow xwpftableRow in ((global::NPOI.XWPF.UserModel.XWPFTable)e).Rows)
				{
					foreach (global::NPOI.XWPF.UserModel.XWPFTableCell xwpftableCell in xwpftableRow.GetTableCells())
					{
						global::System.Collections.Generic.IList<global::NPOI.XWPF.UserModel.IBodyElement> list = xwpftableCell.BodyElements;
						for (int i = 0; i < list.Count; i++)
						{
							bool isLast2 = i == list.Count - 1;
							this.AppendBodyElementText(text, list[i], isLast2);
						}
					}
				}
				if (!isLast)
				{
					text.Append('\n');
					return;
				}
			}
			else if (e is global::NPOI.XWPF.UserModel.XWPFSDT)
			{
				text.Append(((global::NPOI.XWPF.UserModel.XWPFSDT)e).Content.Text);
				if (!isLast)
				{
					text.Append('\t');
				}
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000EDEC File Offset: 0x0000CFEC
		public global::NPOI.XWPF.UserModel.XWPFTableCell GetTableCell(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc cell)
		{
			if (!(cell.Parent is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row))
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row ct_Row = (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Row)cell.Parent;
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

		// Token: 0x060003B4 RID: 948 RVA: 0x0000EE50 File Offset: 0x0000D050
		public global::NPOI.XWPF.UserModel.XWPFDocument GetXWPFDocument()
		{
			return this.part.GetXWPFDocument();
		}

		// Token: 0x0400022F RID: 559
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Tc ctTc;

		// Token: 0x04000230 RID: 560
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFParagraph> paragraphs;

		// Token: 0x04000231 RID: 561
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.XWPFTable> tables;

		// Token: 0x04000232 RID: 562
		protected global::System.Collections.Generic.List<global::NPOI.XWPF.UserModel.IBodyElement> bodyElements;

		// Token: 0x04000233 RID: 563
		protected global::NPOI.XWPF.UserModel.IBody part;

		// Token: 0x04000234 RID: 564
		private global::NPOI.XWPF.UserModel.XWPFTableRow tableRow;

		// Token: 0x04000235 RID: 565
		private static global::System.Collections.Generic.Dictionary<global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign, global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc> alignMap = new global::System.Collections.Generic.Dictionary<global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign, global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc>();

		// Token: 0x04000236 RID: 566
		private static global::System.Collections.Generic.Dictionary<global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc, global::NPOI.XWPF.UserModel.XWPFTableCell.XWPFVertAlign> stVertAlignTypeMap;

		// Token: 0x02000121 RID: 289
		public enum XWPFVertAlign
		{
			// Token: 0x040004FE RID: 1278
			TOP,
			// Token: 0x040004FF RID: 1279
			CENTER,
			// Token: 0x04000500 RID: 1280
			BOTH,
			// Token: 0x04000501 RID: 1281
			BOTTOM
		}
	}
}
