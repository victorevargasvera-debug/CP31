using System;
using System.Collections.Generic;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200008A RID: 138
	public class XSSFIconMultiStateFormatting : global::NPOI.SS.UserModel.IIconMultiStateFormatting
	{
		// Token: 0x06000724 RID: 1828 RVA: 0x000184CD File Offset: 0x000166CD
		internal XSSFIconMultiStateFormatting(global::NPOI.OpenXmlFormats.Spreadsheet.CT_IconSet iconset)
		{
			this._iconset = iconset;
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x000184DC File Offset: 0x000166DC
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00018508 File Offset: 0x00016708
		public global::NPOI.SS.UserModel.IconSet IconSet
		{
			get
			{
				return global::NPOI.SS.UserModel.IconSet.ByOOXMLName(this._iconset.iconSet.ToString());
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType iconSet = global::NPOI.XSSF.Util.XmlEnumParser<global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType>.ForName(value.name, global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType.Item3TrafficLights1);
				this._iconset.iconSet = iconSet;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x0001852E File Offset: 0x0001672E
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x0001854D File Offset: 0x0001674D
		public bool IsIconOnly
		{
			get
			{
				return this._iconset.IsSetShowValue() && !this._iconset.showValue;
			}
			set
			{
				this._iconset.showValue = !value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x0001855E File Offset: 0x0001675E
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x0001857A File Offset: 0x0001677A
		public bool IsReversed
		{
			get
			{
				return this._iconset.reverse && this._iconset.reverse;
			}
			set
			{
				this._iconset.reverse = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00018588 File Offset: 0x00016788
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x000185CC File Offset: 0x000167CC
		public global::NPOI.SS.UserModel.IConditionalFormattingThreshold[] Thresholds
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo[] array = this._iconset.cfvo.ToArray();
				global::NPOI.XSSF.UserModel.XSSFConditionalFormattingThreshold[] array2 = new global::NPOI.XSSF.UserModel.XSSFConditionalFormattingThreshold[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array2[i] = new global::NPOI.XSSF.UserModel.XSSFConditionalFormattingThreshold(array[i]);
				}
				return array2;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo[] array = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo[value.Length];
				for (int i = 0; i < value.Length; i++)
				{
					array[i] = ((global::NPOI.XSSF.UserModel.XSSFConditionalFormattingThreshold)value[i]).CTCfvo;
				}
				this._iconset.cfvo = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo>(array);
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00018611 File Offset: 0x00016811
		public global::NPOI.SS.UserModel.IConditionalFormattingThreshold CreateThreshold()
		{
			return new global::NPOI.XSSF.UserModel.XSSFConditionalFormattingThreshold(this._iconset.AddNewCfvo());
		}

		// Token: 0x040002E6 RID: 742
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_IconSet _iconset;
	}
}
