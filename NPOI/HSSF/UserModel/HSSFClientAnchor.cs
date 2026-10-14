using System;
using NPOI.DDF;
using NPOI.SS;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200036D RID: 877
	public class HSSFClientAnchor : global::NPOI.HSSF.UserModel.HSSFAnchor, global::NPOI.SS.UserModel.IClientAnchor
	{
		// Token: 0x06001B40 RID: 6976 RVA: 0x000539F5 File Offset: 0x00051BF5
		public HSSFClientAnchor(global::NPOI.DDF.EscherClientAnchorRecord escherClientAnchorRecord)
		{
			this._escherClientAnchor = escherClientAnchorRecord;
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00053A04 File Offset: 0x00051C04
		public HSSFClientAnchor()
		{
			this._escherClientAnchor = new global::NPOI.DDF.EscherClientAnchorRecord();
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00053A18 File Offset: 0x00051C18
		public HSSFClientAnchor(int dx1, int dy1, int dx2, int dy2, int col1, int row1, int col2, int row2) : base(dx1, dy1, dx2, dy2)
		{
			this.CheckRange(dx1, 0, 1023, "dx1");
			this.CheckRange(dx2, 0, 1023, "dx2");
			this.CheckRange(dy1, 0, 255, "dy1");
			this.CheckRange(dy2, 0, 255, "dy2");
			this.CheckRange(col1, 0, global::NPOI.HSSF.UserModel.HSSFClientAnchor.MAX_COL, "col1");
			this.CheckRange(col2, 0, global::NPOI.HSSF.UserModel.HSSFClientAnchor.MAX_COL, "col2");
			this.CheckRange(row1, 0, global::NPOI.HSSF.UserModel.HSSFClientAnchor.MAX_ROW, "row1");
			this.CheckRange(row2, 0, global::NPOI.HSSF.UserModel.HSSFClientAnchor.MAX_ROW, "row2");
			this.Col1 = (int)((short)global::System.Math.Min(col1, col2));
			this.Col2 = (int)((short)global::System.Math.Max(col1, col2));
			this.Row1 = global::System.Math.Min(row1, row2);
			this.Row2 = global::System.Math.Max(row1, row2);
			if (col1 > col2)
			{
				this._isHorizontallyFlipped = true;
			}
			if (row1 > row2)
			{
				this._isVerticallyFlipped = true;
			}
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00053B20 File Offset: 0x00051D20
		public float GetAnchorHeightInPoints(global::NPOI.SS.UserModel.ISheet sheet)
		{
			int dy = this.Dy1;
			int dy2 = this.Dy2;
			int num = global::System.Math.Min(this.Row1, this.Row2);
			int num2 = global::System.Math.Max(this.Row1, this.Row2);
			float num3 = 0f;
			if (num == num2)
			{
				num3 = (float)(dy2 - dy) / 256f * this.GetRowHeightInPoints(sheet, num2);
			}
			else
			{
				num3 += (256f - (float)dy) / 256f * this.GetRowHeightInPoints(sheet, num);
				for (int i = num + 1; i < num2; i++)
				{
					num3 += this.GetRowHeightInPoints(sheet, i);
				}
				num3 += (float)dy2 / 256f * this.GetRowHeightInPoints(sheet, num2);
			}
			return num3;
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00053BD8 File Offset: 0x00051DD8
		private float GetRowHeightInPoints(global::NPOI.SS.UserModel.ISheet sheet, int rowNum)
		{
			global::NPOI.SS.UserModel.IRow row = sheet.GetRow(rowNum);
			if (row == null)
			{
				return sheet.DefaultRowHeightInPoints;
			}
			return row.HeightInPoints;
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x00053BFD File Offset: 0x00051DFD
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x00053C0A File Offset: 0x00051E0A
		public int Col1
		{
			get
			{
				return (int)this._escherClientAnchor.Col1;
			}
			set
			{
				this.CheckRange(value, 0, global::NPOI.HSSF.UserModel.HSSFClientAnchor.MAX_COL, "col1");
				this._escherClientAnchor.Col1 = (short)value;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x00053C2B File Offset: 0x00051E2B
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x00053C38 File Offset: 0x00051E38
		public int Col2
		{
			get
			{
				return (int)this._escherClientAnchor.Col2;
			}
			set
			{
				this.CheckRange(value, 0, global::NPOI.HSSF.UserModel.HSSFClientAnchor.MAX_COL, "col2");
				this._escherClientAnchor.Col2 = (short)value;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x00053C59 File Offset: 0x00051E59
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x00053C6B File Offset: 0x00051E6B
		public int Row1
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HSSFClientAnchor.unsignedValue(this._escherClientAnchor.Row1);
			}
			set
			{
				this.CheckRange(value, 0, global::NPOI.HSSF.UserModel.HSSFClientAnchor.MAX_ROW, "row1");
				this._escherClientAnchor.Row1 = (short)value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x00053C8C File Offset: 0x00051E8C
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x00053C9E File Offset: 0x00051E9E
		public int Row2
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HSSFClientAnchor.unsignedValue(this._escherClientAnchor.Row2);
			}
			set
			{
				this.CheckRange(value, 0, global::NPOI.HSSF.UserModel.HSSFClientAnchor.MAX_ROW, "row2");
				this._escherClientAnchor.Row2 = (short)value;
			}
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00053CC0 File Offset: 0x00051EC0
		public void SetAnchor(short col1, int row1, int x1, int y1, short col2, int row2, int x2, int y2)
		{
			this.CheckRange(x1, 0, 1023, "dx1");
			this.CheckRange(x2, 0, 1023, "dx2");
			this.CheckRange(y1, 0, 255, "dy1");
			this.CheckRange(y2, 0, 255, "dy2");
			this.CheckRange((int)col1, 0, global::NPOI.HSSF.UserModel.HSSFClientAnchor.MAX_COL, "col1");
			this.CheckRange((int)col2, 0, global::NPOI.HSSF.UserModel.HSSFClientAnchor.MAX_COL, "col2");
			this.CheckRange(row1, 0, global::NPOI.HSSF.UserModel.HSSFClientAnchor.MAX_ROW, "row1");
			this.CheckRange(row2, 0, global::NPOI.HSSF.UserModel.HSSFClientAnchor.MAX_ROW, "row2");
			this.Col1 = (int)col1;
			this.Row1 = row1;
			this.Dx1 = x1;
			this.Dy1 = y1;
			this.Col2 = (int)col2;
			this.Row2 = row2;
			this.Dx2 = x2;
			this.Dy2 = y2;
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x000538A8 File Offset: 0x00051AA8
		public override bool IsHorizontallyFlipped
		{
			get
			{
				return this._isHorizontallyFlipped;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x000538B0 File Offset: 0x00051AB0
		public override bool IsVerticallyFlipped
		{
			get
			{
				return this._isVerticallyFlipped;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x00053D9F File Offset: 0x00051F9F
		// (set) Token: 0x06001B51 RID: 6993 RVA: 0x00053DAC File Offset: 0x00051FAC
		public global::NPOI.SS.UserModel.AnchorType AnchorType
		{
			get
			{
				return (global::NPOI.SS.UserModel.AnchorType)this._escherClientAnchor.Flag;
			}
			set
			{
				this._escherClientAnchor.Flag = (short)value;
			}
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00053DBC File Offset: 0x00051FBC
		private void CheckRange(int value, int minRange, int maxRange, string varName)
		{
			if (value < minRange || value > maxRange)
			{
				throw new global::System.ArgumentOutOfRangeException(string.Concat(new string[]
				{
					varName,
					" must be between ",
					minRange.ToString(),
					" and ",
					maxRange.ToString(),
					", but was: ",
					value.ToString()
				}));
			}
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x00053E1D File Offset: 0x0005201D
		internal override global::NPOI.DDF.EscherRecord GetEscherAnchor()
		{
			return this._escherClientAnchor;
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x00053E25 File Offset: 0x00052025
		protected override void CreateEscherAnchor()
		{
			this._escherClientAnchor = new global::NPOI.DDF.EscherClientAnchorRecord();
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x00053E32 File Offset: 0x00052032
		private static int unsignedValue(short s)
		{
			if (s >= 0)
			{
				return (int)s;
			}
			return 65536 + (int)s;
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x00053E44 File Offset: 0x00052044
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (obj == this)
			{
				return true;
			}
			if (obj.GetType() != base.GetType())
			{
				return false;
			}
			global::NPOI.HSSF.UserModel.HSSFClientAnchor hssfclientAnchor = (global::NPOI.HSSF.UserModel.HSSFClientAnchor)obj;
			return hssfclientAnchor.Col1 == this.Col1 && hssfclientAnchor.Col2 == this.Col2 && hssfclientAnchor.Dx1 == this.Dx1 && hssfclientAnchor.Dx2 == this.Dx2 && hssfclientAnchor.Dy1 == this.Dy1 && hssfclientAnchor.Dy2 == this.Dy2 && hssfclientAnchor.Row1 == this.Row1 && hssfclientAnchor.Row2 == this.Row2 && hssfclientAnchor.AnchorType == this.AnchorType;
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x00053EF8 File Offset: 0x000520F8
		public override int GetHashCode()
		{
			return this.Col1.GetHashCode() ^ this.Col2.GetHashCode() ^ this.Dx1.GetHashCode() ^ this.Dx2.GetHashCode() ^ this.Dy1.GetHashCode() ^ this.Dy2.GetHashCode() ^ this.Row1.GetHashCode() ^ this.Row2.GetHashCode() ^ this.AnchorType.GetHashCode();
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x00053F91 File Offset: 0x00052191
		// (set) Token: 0x06001B59 RID: 7001 RVA: 0x00053F9E File Offset: 0x0005219E
		public override int Dx1
		{
			get
			{
				return (int)this._escherClientAnchor.Dx1;
			}
			set
			{
				this._escherClientAnchor.Dx1 = (short)value;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x00053FAD File Offset: 0x000521AD
		// (set) Token: 0x06001B5B RID: 7003 RVA: 0x00053FBA File Offset: 0x000521BA
		public override int Dx2
		{
			get
			{
				return (int)this._escherClientAnchor.Dx2;
			}
			set
			{
				this._escherClientAnchor.Dx2 = (short)value;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x00053FC9 File Offset: 0x000521C9
		// (set) Token: 0x06001B5D RID: 7005 RVA: 0x00053FD6 File Offset: 0x000521D6
		public override int Dy1
		{
			get
			{
				return (int)this._escherClientAnchor.Dy1;
			}
			set
			{
				this._escherClientAnchor.Dy1 = (short)value;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x00053FE5 File Offset: 0x000521E5
		// (set) Token: 0x06001B5F RID: 7007 RVA: 0x00053FF2 File Offset: 0x000521F2
		public override int Dy2
		{
			get
			{
				return (int)this._escherClientAnchor.Dy2;
			}
			set
			{
				this._escherClientAnchor.Dy2 = (short)value;
			}
		}

		// Token: 0x04000B34 RID: 2868
		public static int MAX_COL = global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastColumnIndex;

		// Token: 0x04000B35 RID: 2869
		public static int MAX_ROW = global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastRowIndex;

		// Token: 0x04000B36 RID: 2870
		private global::NPOI.DDF.EscherClientAnchorRecord _escherClientAnchor;
	}
}
