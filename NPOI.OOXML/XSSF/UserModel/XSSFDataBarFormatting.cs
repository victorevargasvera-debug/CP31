using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000077 RID: 119
	public class XSSFDataBarFormatting : global::NPOI.SS.UserModel.IDataBarFormatting
	{
		// Token: 0x060005CC RID: 1484 RVA: 0x00015E54 File Offset: 0x00014054
		public XSSFDataBarFormatting(global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataBar databar)
		{
			this._databar = databar;
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00015E63 File Offset: 0x00014063
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x00015E82 File Offset: 0x00014082
		public bool IsIconOnly
		{
			get
			{
				return this._databar.IsSetShowValue() && !this._databar.showValue;
			}
			set
			{
				this._databar.showValue = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00006FBA File Offset: 0x000051BA
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x000029BF File Offset: 0x00000BBF
		public bool IsLeftToRight
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00005008 File Offset: 0x00003208
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x000029BF File Offset: 0x00000BBF
		public int WidthMin
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00015E90 File Offset: 0x00014090
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x000029BF File Offset: 0x00000BBF
		public int WidthMax
		{
			get
			{
				return 100;
			}
			set
			{
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00015E94 File Offset: 0x00014094
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00015EA6 File Offset: 0x000140A6
		public global::NPOI.SS.UserModel.IColor Color
		{
			get
			{
				return new global::NPOI.XSSF.UserModel.XSSFColor(this._databar.color);
			}
			set
			{
				this._databar.color = ((global::NPOI.XSSF.UserModel.XSSFColor)value).GetCTColor();
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00015EBE File Offset: 0x000140BE
		public global::NPOI.SS.UserModel.IConditionalFormattingThreshold MinThreshold
		{
			get
			{
				return new global::NPOI.XSSF.UserModel.XSSFConditionalFormattingThreshold(this._databar.cfvo[0]);
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00015ED6 File Offset: 0x000140D6
		public global::NPOI.SS.UserModel.IConditionalFormattingThreshold MaxThreshold
		{
			get
			{
				return new global::NPOI.XSSF.UserModel.XSSFConditionalFormattingThreshold(this._databar.cfvo[1]);
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00015EEE File Offset: 0x000140EE
		public global::NPOI.XSSF.UserModel.XSSFConditionalFormattingThreshold CreateThreshold()
		{
			return new global::NPOI.XSSF.UserModel.XSSFConditionalFormattingThreshold(this._databar.AddNewCfvo());
		}

		// Token: 0x040002BD RID: 701
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataBar _databar;
	}
}
