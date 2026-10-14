using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.OpenXmlFormats.Vml;
using NPOI.OpenXmlFormats.Vml.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;
using NPOI.XSSF.Model;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000071 RID: 113
	public class XSSFComment : global::NPOI.SS.UserModel.IComment
	{
		// Token: 0x06000585 RID: 1413 RVA: 0x00014F68 File Offset: 0x00013168
		public XSSFComment(global::NPOI.XSSF.Model.CommentsTable comments, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment comment, global::NPOI.OpenXmlFormats.Vml.CT_Shape vmlShape)
		{
			this._comment = comment;
			this._comments = comments;
			this._vmlShape = vmlShape;
			if (vmlShape != null && vmlShape.SizeOfClientDataArray() > 0)
			{
				global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(comment.@ref);
				global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData clientDataArray = vmlShape.GetClientDataArray(0);
				clientDataArray.SetRowArray(0, cellReference.Row);
				clientDataArray.SetColumnArray(0, (int)cellReference.Col);
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x00014FC8 File Offset: 0x000131C8
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x00014FE1 File Offset: 0x000131E1
		public string Author
		{
			get
			{
				return this._comments.GetAuthor((long)this._comment.authorId);
			}
			set
			{
				this._comment.authorId = (uint)this._comments.FindAuthor(value);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00014FFA File Offset: 0x000131FA
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x0001500C File Offset: 0x0001320C
		public global::NPOI.SS.Util.CellAddress Address
		{
			get
			{
				return new global::NPOI.SS.Util.CellAddress(this._comment.@ref);
			}
			set
			{
				global::NPOI.SS.Util.CellAddress cellAddress = new global::NPOI.SS.Util.CellAddress(this._comment.@ref);
				if (value.Equals(cellAddress))
				{
					return;
				}
				this._comment.@ref = value.FormatAsString();
				this._comments.ReferenceUpdated(cellAddress, this._comment);
				if (this._vmlShape != null)
				{
					global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData clientDataArray = this._vmlShape.GetClientDataArray(0);
					clientDataArray.SetRowArray(0, value.Row);
					clientDataArray.SetColumnArray(0, value.Column);
				}
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00015084 File Offset: 0x00013284
		public void SetAddress(int row, int col)
		{
			this.Address = new global::NPOI.SS.Util.CellAddress(row, col);
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00015093 File Offset: 0x00013293
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x000150A0 File Offset: 0x000132A0
		public int Column
		{
			get
			{
				return this.Address.Column;
			}
			set
			{
				this.SetAddress(this.Row, value);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x000150AF File Offset: 0x000132AF
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x000150BC File Offset: 0x000132BC
		public int Row
		{
			get
			{
				return this.Address.Row;
			}
			set
			{
				this.SetAddress(value, this.Column);
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x000150CC File Offset: 0x000132CC
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x0001512C File Offset: 0x0001332C
		public bool Visible
		{
			get
			{
				bool result = false;
				if (this._vmlShape != null)
				{
					string style = this._vmlShape.style;
					if (style != null)
					{
						result = (style.IndexOf("visibility:visible") != -1);
					}
					else
					{
						if (this._vmlShape.GetClientDataArray(0) == null)
						{
							return false;
						}
						result = this._vmlShape.GetClientDataArray(0).visibleSpecified;
					}
				}
				return result;
			}
			set
			{
				if (this._vmlShape != null)
				{
					string style;
					if (value)
					{
						style = "position:absolute;visibility:visible";
						this._vmlShape.GetClientDataArray(0).visible = global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.@true;
						this._vmlShape.GetClientDataArray(0).visibleSpecified = true;
					}
					else
					{
						style = "position:absolute;visibility:hidden";
						this._vmlShape.GetClientDataArray(0).visible = global::NPOI.OpenXmlFormats.Vml.Spreadsheet.ST_TrueFalseBlank.@false;
						this._vmlShape.GetClientDataArray(0).visibleSpecified = false;
					}
					this._vmlShape.style = style;
				}
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x000151A6 File Offset: 0x000133A6
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x000151D9 File Offset: 0x000133D9
		public global::NPOI.SS.UserModel.IRichTextString String
		{
			get
			{
				if (this._str == null && this._comment.text != null)
				{
					this._str = new global::NPOI.XSSF.UserModel.XSSFRichTextString(this._comment.text);
				}
				return this._str;
			}
			set
			{
				if (!(value is global::NPOI.XSSF.UserModel.XSSFRichTextString))
				{
					throw new global::System.ArgumentException("Only XSSFRichTextString argument is supported");
				}
				this._str = (global::NPOI.XSSF.UserModel.XSSFRichTextString)value;
				this._comment.text = this._str.GetCTRst();
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00015210 File Offset: 0x00013410
		public void SetString(string str)
		{
			this.String = new global::NPOI.XSSF.UserModel.XSSFRichTextString(str);
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00015220 File Offset: 0x00013420
		public global::NPOI.SS.UserModel.IClientAnchor ClientAnchor
		{
			get
			{
				string anchorArray = this._vmlShape.GetClientDataArray(0).GetAnchorArray(0);
				int[] array = new int[8];
				int num = 0;
				foreach (string text in anchorArray.Split(",".ToCharArray()))
				{
					array[num++] = int.Parse(text.Trim());
				}
				return new global::NPOI.XSSF.UserModel.XSSFClientAnchor(array[1] * global::NPOI.Util.Units.EMU_PER_PIXEL, array[3] * global::NPOI.Util.Units.EMU_PER_PIXEL, array[5] * global::NPOI.Util.Units.EMU_PER_PIXEL, array[7] * global::NPOI.Util.Units.EMU_PER_PIXEL, array[0], array[2], array[4], array[6]);
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000152B3 File Offset: 0x000134B3
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment GetCTComment()
		{
			return this._comment;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000152BB File Offset: 0x000134BB
		internal global::NPOI.OpenXmlFormats.Vml.CT_Shape GetCTShape()
		{
			return this._vmlShape;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x000152C4 File Offset: 0x000134C4
		public override bool Equals(object obj)
		{
			if (!(obj is global::NPOI.XSSF.UserModel.XSSFComment))
			{
				return false;
			}
			global::NPOI.XSSF.UserModel.XSSFComment xssfcomment = (global::NPOI.XSSF.UserModel.XSSFComment)obj;
			return this.GetCTComment() == xssfcomment.GetCTComment() && this.GetCTShape() == xssfcomment.GetCTShape();
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00015300 File Offset: 0x00013500
		public override int GetHashCode()
		{
			return (this.Row * 17 + this.Column) * 31;
		}

		// Token: 0x040002B0 RID: 688
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment _comment;

		// Token: 0x040002B1 RID: 689
		private global::NPOI.XSSF.Model.CommentsTable _comments;

		// Token: 0x040002B2 RID: 690
		private global::NPOI.OpenXmlFormats.Vml.CT_Shape _vmlShape;

		// Token: 0x040002B3 RID: 691
		private global::NPOI.XSSF.UserModel.XSSFRichTextString _str;
	}
}
