using System;
using System.Collections.Generic;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000070 RID: 112
	public class XSSFColorScaleFormatting : global::NPOI.SS.UserModel.IColorScaleFormatting
	{
		// Token: 0x0600057C RID: 1404 RVA: 0x00014D96 File Offset: 0x00012F96
		public XSSFColorScaleFormatting(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColorScale scale)
		{
			this._scale = scale;
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00014DA5 File Offset: 0x00012FA5
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00014DB4 File Offset: 0x00012FB4
		public int NumControlPoints
		{
			get
			{
				return this._scale.SizeOfCfvoArray();
			}
			set
			{
				while (value < this._scale.SizeOfCfvoArray())
				{
					this._scale.RemoveCfvo(this._scale.SizeOfCfvoArray() - 1);
					this._scale.RemoveColor(this._scale.SizeOfColorArray() - 1);
				}
				while (value > this._scale.SizeOfCfvoArray())
				{
					this._scale.AddNewCfvo();
					this._scale.AddNewColor();
				}
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00014E2C File Offset: 0x0001302C
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00014E70 File Offset: 0x00013070
		public global::NPOI.SS.UserModel.IColor[] Colors
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color[] array = this._scale.color.ToArray();
				global::NPOI.XSSF.UserModel.XSSFColor[] array2 = new global::NPOI.XSSF.UserModel.XSSFColor[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array2[i] = new global::NPOI.XSSF.UserModel.XSSFColor(array[i]);
				}
				return array2;
			}
			set
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color[] array = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color[value.Length];
				for (int i = 0; i < value.Length; i++)
				{
					array[i] = ((global::NPOI.XSSF.UserModel.XSSFColor)value[i]).GetCTColor();
				}
				this._scale.color = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color>(array);
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00014EB8 File Offset: 0x000130B8
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00014EFC File Offset: 0x000130FC
		public global::NPOI.SS.UserModel.IConditionalFormattingThreshold[] Thresholds
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo[] array = this._scale.cfvo.ToArray();
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
				this._scale.cfvo = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo>(array);
			}
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00014F41 File Offset: 0x00013141
		public global::NPOI.XSSF.UserModel.XSSFColor CreateColor()
		{
			return new global::NPOI.XSSF.UserModel.XSSFColor(this._scale.AddNewColor());
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00014F53 File Offset: 0x00013153
		public global::NPOI.SS.UserModel.IConditionalFormattingThreshold CreateThreshold()
		{
			return new global::NPOI.XSSF.UserModel.XSSFConditionalFormattingThreshold(this._scale.AddNewCfvo());
		}

		// Token: 0x040002AF RID: 687
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColorScale _scale;
	}
}
