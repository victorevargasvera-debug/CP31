using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200036B RID: 875
	public class HSSFCellStyle : global::NPOI.SS.UserModel.ICellStyle
	{
		// Token: 0x06001AE9 RID: 6889 RVA: 0x00053068 File Offset: 0x00051268
		public HSSFCellStyle(short index, global::NPOI.HSSF.Record.ExtendedFormatRecord rec, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook) : this(index, rec, workbook.Workbook)
		{
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x00053078 File Offset: 0x00051278
		public HSSFCellStyle(short index, global::NPOI.HSSF.Record.ExtendedFormatRecord rec, global::NPOI.HSSF.Model.InternalWorkbook workbook)
		{
			this._workbook = workbook;
			this.index = index;
			this._format = rec;
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x00053095 File Offset: 0x00051295
		public short Index
		{
			get
			{
				return this.index;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x000530A0 File Offset: 0x000512A0
		public global::NPOI.HSSF.UserModel.HSSFCellStyle ParentStyle
		{
			get
			{
				short parentIndex = this._format.ParentIndex;
				if (parentIndex == 0 || parentIndex == 4095)
				{
					return null;
				}
				return new global::NPOI.HSSF.UserModel.HSSFCellStyle(parentIndex, this._workbook.GetExFormatAt((int)parentIndex), this._workbook);
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x000530DE File Offset: 0x000512DE
		// (set) Token: 0x06001AEE RID: 6894 RVA: 0x000530EB File Offset: 0x000512EB
		public short DataFormat
		{
			get
			{
				return this._format.FormatIndex;
			}
			set
			{
				this._format.FormatIndex = value;
			}
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x000530FC File Offset: 0x000512FC
		public string GetDataFormatString()
		{
			if (global::NPOI.HSSF.UserModel.HSSFCellStyle.getDataFormatStringCache != null && global::NPOI.HSSF.UserModel.HSSFCellStyle.lastDateFormat == this.DataFormat && this._workbook.Formats.Equals(global::NPOI.HSSF.UserModel.HSSFCellStyle.lastFormats))
			{
				return global::NPOI.HSSF.UserModel.HSSFCellStyle.getDataFormatStringCache;
			}
			global::NPOI.HSSF.UserModel.HSSFCellStyle.lastFormats = this._workbook.Formats;
			global::NPOI.HSSF.UserModel.HSSFCellStyle.lastDateFormat = this.DataFormat;
			global::NPOI.HSSF.UserModel.HSSFCellStyle.getDataFormatStringCache = this.GetDataFormatString(this._workbook);
			return global::NPOI.HSSF.UserModel.HSSFCellStyle.getDataFormatStringCache;
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0005316C File Offset: 0x0005136C
		public string GetDataFormatString(global::NPOI.SS.UserModel.IWorkbook workbook)
		{
			global::NPOI.HSSF.UserModel.HSSFDataFormat hssfdataFormat = new global::NPOI.HSSF.UserModel.HSSFDataFormat(((global::NPOI.HSSF.UserModel.HSSFWorkbook)workbook).Workbook);
			if (this.DataFormat != -1)
			{
				return hssfdataFormat.GetFormat(this.DataFormat);
			}
			return "General";
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x000531A5 File Offset: 0x000513A5
		public string GetDataFormatString(global::NPOI.HSSF.Model.InternalWorkbook workbook)
		{
			return new global::NPOI.HSSF.UserModel.HSSFDataFormat(workbook).GetFormat(this.DataFormat);
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x000531B8 File Offset: 0x000513B8
		public void SetFont(global::NPOI.SS.UserModel.IFont font)
		{
			this._format.IsIndentNotParentFont = true;
			short fontIndex = font.Index;
			this._format.FontIndex = fontIndex;
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x000531E4 File Offset: 0x000513E4
		public short FontIndex
		{
			get
			{
				return this._format.FontIndex;
			}
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x000531F1 File Offset: 0x000513F1
		public global::NPOI.SS.UserModel.IFont GetFont(global::NPOI.SS.UserModel.IWorkbook parentWorkbook)
		{
			return ((global::NPOI.HSSF.UserModel.HSSFWorkbook)parentWorkbook).GetFontAt(this.FontIndex);
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x00053204 File Offset: 0x00051404
		// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x00053211 File Offset: 0x00051411
		public bool IsHidden
		{
			get
			{
				return this._format.IsHidden;
			}
			set
			{
				this._format.IsIndentNotParentCellOptions = true;
				this._format.IsHidden = value;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x0005322B File Offset: 0x0005142B
		// (set) Token: 0x06001AF8 RID: 6904 RVA: 0x00053238 File Offset: 0x00051438
		public bool IsLocked
		{
			get
			{
				return this._format.IsLocked;
			}
			set
			{
				this._format.IsIndentNotParentCellOptions = true;
				this._format.IsLocked = value;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x00053252 File Offset: 0x00051452
		// (set) Token: 0x06001AFA RID: 6906 RVA: 0x0005325F File Offset: 0x0005145F
		public global::NPOI.SS.UserModel.HorizontalAlignment Alignment
		{
			get
			{
				return (global::NPOI.SS.UserModel.HorizontalAlignment)this._format.Alignment;
			}
			set
			{
				this._format.IsIndentNotParentAlignment = true;
				this._format.Alignment = (short)value;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x0005327A File Offset: 0x0005147A
		// (set) Token: 0x06001AFC RID: 6908 RVA: 0x00053287 File Offset: 0x00051487
		public bool WrapText
		{
			get
			{
				return this._format.WrapText;
			}
			set
			{
				this._format.IsIndentNotParentAlignment = true;
				this._format.WrapText = value;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x000532A1 File Offset: 0x000514A1
		// (set) Token: 0x06001AFE RID: 6910 RVA: 0x000532AE File Offset: 0x000514AE
		public global::NPOI.SS.UserModel.VerticalAlignment VerticalAlignment
		{
			get
			{
				return (global::NPOI.SS.UserModel.VerticalAlignment)this._format.VerticalAlignment;
			}
			set
			{
				this._format.VerticalAlignment = (short)value;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x000532C0 File Offset: 0x000514C0
		// (set) Token: 0x06001B00 RID: 6912 RVA: 0x000532F0 File Offset: 0x000514F0
		public short Rotation
		{
			get
			{
				short num = this._format.Rotation;
				if (num == 255)
				{
					return num;
				}
				if (num > 90)
				{
					num = 90 - num;
				}
				return num;
			}
			set
			{
				short num = value;
				if (num != 255)
				{
					if (value < 0 && value >= -90)
					{
						num = 90 - value;
					}
					else if ((num <= 90 || num > 180) && (value < -90 || value > 90))
					{
						throw new global::System.ArgumentException("The rotation must be between -90 and 90 degrees, or 0xff");
					}
				}
				this._format.Rotation = num;
			}
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x00053346 File Offset: 0x00051546
		public void VerifyBelongsToWorkbook(global::NPOI.HSSF.UserModel.HSSFWorkbook wb)
		{
			if (wb.Workbook != this._workbook)
			{
				throw new global::System.ArgumentException("This Style does not belong to the supplied Workbook. Are you trying to assign a style from one workbook to the cell of a different workbook?");
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x00053361 File Offset: 0x00051561
		// (set) Token: 0x06001B03 RID: 6915 RVA: 0x0005336E File Offset: 0x0005156E
		public short Indention
		{
			get
			{
				return this._format.Indent;
			}
			set
			{
				this._format.Indent = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x0005337C File Offset: 0x0005157C
		// (set) Token: 0x06001B05 RID: 6917 RVA: 0x00053389 File Offset: 0x00051589
		public global::NPOI.SS.UserModel.BorderStyle BorderLeft
		{
			get
			{
				return (global::NPOI.SS.UserModel.BorderStyle)this._format.BorderLeft;
			}
			set
			{
				this._format.IsIndentNotParentBorder = true;
				this._format.BorderLeft = (short)value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x000533A3 File Offset: 0x000515A3
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x000533B0 File Offset: 0x000515B0
		public global::NPOI.SS.UserModel.BorderStyle BorderRight
		{
			get
			{
				return (global::NPOI.SS.UserModel.BorderStyle)this._format.BorderRight;
			}
			set
			{
				this._format.IsIndentNotParentBorder = true;
				this._format.BorderRight = (short)value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x000533CA File Offset: 0x000515CA
		// (set) Token: 0x06001B09 RID: 6921 RVA: 0x000533D7 File Offset: 0x000515D7
		public global::NPOI.SS.UserModel.BorderStyle BorderTop
		{
			get
			{
				return (global::NPOI.SS.UserModel.BorderStyle)this._format.BorderTop;
			}
			set
			{
				this._format.IsIndentNotParentBorder = true;
				this._format.BorderTop = (short)value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x000533F1 File Offset: 0x000515F1
		// (set) Token: 0x06001B0B RID: 6923 RVA: 0x000533FE File Offset: 0x000515FE
		public global::NPOI.SS.UserModel.BorderStyle BorderBottom
		{
			get
			{
				return (global::NPOI.SS.UserModel.BorderStyle)this._format.BorderBottom;
			}
			set
			{
				this._format.IsIndentNotParentBorder = true;
				this._format.BorderBottom = (short)value;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x00053418 File Offset: 0x00051618
		// (set) Token: 0x06001B0D RID: 6925 RVA: 0x00053425 File Offset: 0x00051625
		public short LeftBorderColor
		{
			get
			{
				return this._format.LeftBorderPaletteIdx;
			}
			set
			{
				this._format.LeftBorderPaletteIdx = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x00053433 File Offset: 0x00051633
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x00053440 File Offset: 0x00051640
		public short RightBorderColor
		{
			get
			{
				return this._format.RightBorderPaletteIdx;
			}
			set
			{
				this._format.RightBorderPaletteIdx = value;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x0005344E File Offset: 0x0005164E
		// (set) Token: 0x06001B11 RID: 6929 RVA: 0x0005345B File Offset: 0x0005165B
		public short TopBorderColor
		{
			get
			{
				return this._format.TopBorderPaletteIdx;
			}
			set
			{
				this._format.TopBorderPaletteIdx = value;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x00053469 File Offset: 0x00051669
		// (set) Token: 0x06001B13 RID: 6931 RVA: 0x00053476 File Offset: 0x00051676
		public short BottomBorderColor
		{
			get
			{
				return this._format.BottomBorderPaletteIdx;
			}
			set
			{
				this._format.BottomBorderPaletteIdx = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x00053484 File Offset: 0x00051684
		// (set) Token: 0x06001B15 RID: 6933 RVA: 0x00053491 File Offset: 0x00051691
		public short BorderDiagonalColor
		{
			get
			{
				return this._format.AdtlDiagBorderPaletteIdx;
			}
			set
			{
				this._format.AdtlDiagBorderPaletteIdx = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x0005349F File Offset: 0x0005169F
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x000534AC File Offset: 0x000516AC
		public global::NPOI.SS.UserModel.BorderStyle BorderDiagonalLineStyle
		{
			get
			{
				return (global::NPOI.SS.UserModel.BorderStyle)this._format.AdtlDiagLineStyle;
			}
			set
			{
				this._format.AdtlDiagLineStyle = (short)value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x000534BA File Offset: 0x000516BA
		// (set) Token: 0x06001B19 RID: 6937 RVA: 0x000534C7 File Offset: 0x000516C7
		public global::NPOI.SS.UserModel.BorderDiagonal BorderDiagonal
		{
			get
			{
				return (global::NPOI.SS.UserModel.BorderDiagonal)this._format.Diagonal;
			}
			set
			{
				this._format.Diagonal = (short)value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001B1A RID: 6938 RVA: 0x000534D6 File Offset: 0x000516D6
		// (set) Token: 0x06001B1B RID: 6939 RVA: 0x000534E3 File Offset: 0x000516E3
		public bool ShrinkToFit
		{
			get
			{
				return this._format.ShrinkToFit;
			}
			set
			{
				this._format.ShrinkToFit = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001B1C RID: 6940 RVA: 0x000534F1 File Offset: 0x000516F1
		// (set) Token: 0x06001B1D RID: 6941 RVA: 0x000534FE File Offset: 0x000516FE
		public short ReadingOrder
		{
			get
			{
				return this._format.ReadingOrder;
			}
			set
			{
				this._format.ReadingOrder = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001B1E RID: 6942 RVA: 0x0005350C File Offset: 0x0005170C
		// (set) Token: 0x06001B1F RID: 6943 RVA: 0x00053519 File Offset: 0x00051719
		public global::NPOI.SS.UserModel.FillPattern FillPattern
		{
			get
			{
				return (global::NPOI.SS.UserModel.FillPattern)this._format.AdtlFillPattern;
			}
			set
			{
				this._format.AdtlFillPattern = (short)value;
			}
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x00053528 File Offset: 0x00051728
		private void CheckDefaultBackgroundFills()
		{
			if (this._format.FillForeground == 64)
			{
				if (this._format.FillBackground != 65)
				{
					this.FillBackgroundColor = 65;
					return;
				}
			}
			else if (this._format.FillBackground == 65 && this._format.FillForeground != 64)
			{
				this.FillBackgroundColor = 64;
			}
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x00053582 File Offset: 0x00051782
		public void CloneStyleFrom(global::NPOI.SS.UserModel.ICellStyle source)
		{
			if (source is global::NPOI.HSSF.UserModel.HSSFCellStyle)
			{
				this.CloneStyleFrom((global::NPOI.HSSF.UserModel.HSSFCellStyle)source);
				return;
			}
			throw new global::System.ArgumentException("Can only clone from one HSSFCellStyle to another, not between HSSFCellStyle and XSSFCellStyle");
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x000535A4 File Offset: 0x000517A4
		public void CloneStyleFrom(global::NPOI.HSSF.UserModel.HSSFCellStyle source)
		{
			this._format.CloneStyleFrom(source._format);
			if (this._workbook != source._workbook)
			{
				global::NPOI.HSSF.UserModel.HSSFCellStyle.lastDateFormat = short.MinValue;
				global::NPOI.HSSF.UserModel.HSSFCellStyle.lastFormats = null;
				global::NPOI.HSSF.UserModel.HSSFCellStyle.getDataFormatStringCache = null;
				short dataFormat = (short)this._workbook.CreateFormat(source.GetDataFormatString());
				this.DataFormat = dataFormat;
				global::NPOI.HSSF.Record.FontRecord fontRecord = this._workbook.CreateNewFont();
				fontRecord.CloneStyleFrom(source._workbook.GetFontRecordAt((int)source.FontIndex));
				global::NPOI.HSSF.UserModel.HSSFFont font = new global::NPOI.HSSF.UserModel.HSSFFont((short)this._workbook.GetFontIndex(fontRecord), fontRecord);
				this.SetFont(font);
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x00053640 File Offset: 0x00051840
		// (set) Token: 0x06001B24 RID: 6948 RVA: 0x00053662 File Offset: 0x00051862
		public short FillBackgroundColor
		{
			get
			{
				short fillBackground = this._format.FillBackground;
				if (fillBackground == 65)
				{
					return 64;
				}
				return fillBackground;
			}
			set
			{
				this._format.FillBackground = value;
				this.CheckDefaultBackgroundFills();
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x00053676 File Offset: 0x00051876
		public global::NPOI.SS.UserModel.IColor FillBackgroundColorColor
		{
			get
			{
				return new global::NPOI.HSSF.UserModel.HSSFPalette(this._workbook.CustomPalette).GetColor(this.FillBackgroundColor);
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x00053693 File Offset: 0x00051893
		// (set) Token: 0x06001B27 RID: 6951 RVA: 0x000536A0 File Offset: 0x000518A0
		public short FillForegroundColor
		{
			get
			{
				return this._format.FillForeground;
			}
			set
			{
				this._format.FillForeground = value;
				this.CheckDefaultBackgroundFills();
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001B28 RID: 6952 RVA: 0x000536B4 File Offset: 0x000518B4
		public global::NPOI.SS.UserModel.IColor FillForegroundColorColor
		{
			get
			{
				return new global::NPOI.HSSF.UserModel.HSSFPalette(this._workbook.CustomPalette).GetColor(this.FillForegroundColor);
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x000536D4 File Offset: 0x000518D4
		// (set) Token: 0x06001B2A RID: 6954 RVA: 0x00053708 File Offset: 0x00051908
		public string UserStyleName
		{
			get
			{
				global::NPOI.HSSF.Record.StyleRecord styleRecord = this._workbook.GetStyleRecord((int)this.index);
				if (styleRecord == null)
				{
					return null;
				}
				if (styleRecord.IsBuiltin)
				{
					return null;
				}
				return styleRecord.Name;
			}
			set
			{
				global::NPOI.HSSF.Record.StyleRecord styleRecord = this._workbook.GetStyleRecord((int)this.index);
				if (styleRecord == null)
				{
					styleRecord = this._workbook.CreateStyleRecord((int)this.index);
				}
				if (styleRecord.IsBuiltin && this.index <= 20)
				{
					throw new global::System.ArgumentException("Unable to set user specified style names for built in styles!");
				}
				styleRecord.Name = value;
			}
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x00053760 File Offset: 0x00051960
		public override int GetHashCode()
		{
			int num = 31;
			int num2 = 1;
			num2 = num * num2 + ((this._format == null) ? 0 : this._format.GetHashCode());
			return num * num2 + (int)this.index;
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x00053798 File Offset: 0x00051998
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			if (obj == null)
			{
				return false;
			}
			if (obj is global::NPOI.HSSF.UserModel.HSSFCellStyle)
			{
				global::NPOI.HSSF.UserModel.HSSFCellStyle hssfcellStyle = (global::NPOI.HSSF.UserModel.HSSFCellStyle)obj;
				if (this._format == null)
				{
					if (hssfcellStyle._format != null)
					{
						return false;
					}
				}
				else if (!this._format.Equals(hssfcellStyle._format))
				{
					return false;
				}
				return this.index == hssfcellStyle.index;
			}
			return false;
		}

		// Token: 0x04000B2D RID: 2861
		private global::NPOI.HSSF.Record.ExtendedFormatRecord _format;

		// Token: 0x04000B2E RID: 2862
		private short index;

		// Token: 0x04000B2F RID: 2863
		private global::NPOI.HSSF.Model.InternalWorkbook _workbook;

		// Token: 0x04000B30 RID: 2864
		private static short lastDateFormat = short.MinValue;

		// Token: 0x04000B31 RID: 2865
		private static global::System.Collections.Generic.List<global::NPOI.HSSF.Record.FormatRecord> lastFormats = null;

		// Token: 0x04000B32 RID: 2866
		private static string getDataFormatStringCache = null;
	}
}
