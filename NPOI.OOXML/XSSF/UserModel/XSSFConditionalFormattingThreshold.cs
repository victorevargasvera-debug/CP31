using System;
using System.Globalization;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000074 RID: 116
	public class XSSFConditionalFormattingThreshold : global::NPOI.SS.UserModel.IConditionalFormattingThreshold
	{
		// Token: 0x060005B7 RID: 1463 RVA: 0x00015B3A File Offset: 0x00013D3A
		protected internal XSSFConditionalFormattingThreshold(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo cfvo)
		{
			this.cfvo = cfvo;
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00015B49 File Offset: 0x00013D49
		protected internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo CTCfvo
		{
			get
			{
				return this.cfvo;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00015B54 File Offset: 0x00013D54
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00015B80 File Offset: 0x00013D80
		public global::NPOI.SS.UserModel.RangeType RangeType
		{
			get
			{
				return global::NPOI.SS.UserModel.RangeType.ByName(this.cfvo.type.ToString());
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType), value.name);
				this.cfvo.type = type;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x00015BB4 File Offset: 0x00013DB4
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x00015BD1 File Offset: 0x00013DD1
		public string Formula
		{
			get
			{
				if (this.cfvo.type == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType.formula)
				{
					return this.cfvo.val;
				}
				return null;
			}
			set
			{
				this.cfvo.val = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x00015BE0 File Offset: 0x00013DE0
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x00015C70 File Offset: 0x00013E70
		public double? Value
		{
			get
			{
				if (this.cfvo.type == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType.formula || this.cfvo.type == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType.min || this.cfvo.type == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType.max || this.cfvo.type == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType.autoMax || this.cfvo.type == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType.autoMin)
				{
					return null;
				}
				if (this.cfvo.IsSetVal())
				{
					return new double?(double.Parse(this.cfvo.val, global::System.Globalization.CultureInfo.InvariantCulture));
				}
				return null;
			}
			set
			{
				if (value == null)
				{
					this.cfvo.UnsetVal();
					return;
				}
				this.cfvo.val = value.Value.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			}
		}

		// Token: 0x040002B9 RID: 697
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo cfvo;
	}
}
