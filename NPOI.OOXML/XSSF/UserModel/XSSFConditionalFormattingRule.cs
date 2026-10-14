using System;
using System.Collections.Generic;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.Model;
using NPOI.XSSF.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000073 RID: 115
	public class XSSFConditionalFormattingRule : global::NPOI.SS.UserModel.IConditionalFormattingRule
	{
		// Token: 0x060005A2 RID: 1442 RVA: 0x00015430 File Offset: 0x00013630
		static XSSFConditionalFormattingRule()
		{
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.cellIs, global::NPOI.SS.UserModel.ConditionType.CellValueIs);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.expression, global::NPOI.SS.UserModel.ConditionType.Formula);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.colorScale, global::NPOI.SS.UserModel.ConditionType.ColorScale);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.dataBar, global::NPOI.SS.UserModel.ConditionType.DataBar);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.iconSet, global::NPOI.SS.UserModel.ConditionType.IconSet);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.top10, global::NPOI.SS.UserModel.ConditionType.Filter);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.uniqueValues, global::NPOI.SS.UserModel.ConditionType.Filter);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.duplicateValues, global::NPOI.SS.UserModel.ConditionType.Filter);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.containsText, global::NPOI.SS.UserModel.ConditionType.Filter);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.notContainsText, global::NPOI.SS.UserModel.ConditionType.Filter);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.beginsWith, global::NPOI.SS.UserModel.ConditionType.Filter);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.endsWith, global::NPOI.SS.UserModel.ConditionType.Filter);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.containsBlanks, global::NPOI.SS.UserModel.ConditionType.Filter);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.notContainsBlanks, global::NPOI.SS.UserModel.ConditionType.Filter);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.containsErrors, global::NPOI.SS.UserModel.ConditionType.Filter);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.notContainsErrors, global::NPOI.SS.UserModel.ConditionType.Filter);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.timePeriod, global::NPOI.SS.UserModel.ConditionType.Filter);
			global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.aboveAverage, global::NPOI.SS.UserModel.ConditionType.Filter);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00015570 File Offset: 0x00013770
		public XSSFConditionalFormattingRule(global::NPOI.XSSF.UserModel.XSSFSheet sh)
		{
			this._cfRule = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule();
			this._sh = sh;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0001558A File Offset: 0x0001378A
		internal XSSFConditionalFormattingRule(global::NPOI.XSSF.UserModel.XSSFSheet sh, global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule cfRule)
		{
			this._cfRule = cfRule;
			this._sh = sh;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000155A0 File Offset: 0x000137A0
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule GetCTCfRule()
		{
			return this._cfRule;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x000155A8 File Offset: 0x000137A8
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf GetDxf(bool create)
		{
			global::NPOI.XSSF.Model.StylesTable stylesSource = ((global::NPOI.XSSF.UserModel.XSSFWorkbook)this._sh.Workbook).GetStylesSource();
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf ct_Dxf = null;
			if (stylesSource.DXfsSize > 0 && this._cfRule.IsSetDxfId())
			{
				int dxfId = (int)this._cfRule.dxfId;
				ct_Dxf = stylesSource.GetDxfAt(dxfId);
			}
			if (create && ct_Dxf == null)
			{
				ct_Dxf = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf();
				int num = stylesSource.PutDxf(ct_Dxf);
				this._cfRule.dxfId = (uint)(num - 1);
			}
			return ct_Dxf;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0001561C File Offset: 0x0001381C
		public global::NPOI.SS.UserModel.IBorderFormatting CreateBorderFormatting()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf dxf = this.GetDxf(true);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Border border;
			if (!dxf.IsSetBorder())
			{
				border = dxf.AddNewBorder();
			}
			else
			{
				border = dxf.border;
			}
			return new global::NPOI.XSSF.UserModel.XSSFBorderFormatting(border);
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00015650 File Offset: 0x00013850
		public global::NPOI.SS.UserModel.IBorderFormatting BorderFormatting
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf dxf = this.GetDxf(false);
				if (dxf == null || !dxf.IsSetBorder())
				{
					return null;
				}
				return new global::NPOI.XSSF.UserModel.XSSFBorderFormatting(dxf.border);
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00015680 File Offset: 0x00013880
		public global::NPOI.SS.UserModel.IFontFormatting CreateFontFormatting()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf dxf = this.GetDxf(true);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Font font;
			if (!dxf.IsSetFont())
			{
				font = dxf.AddNewFont();
			}
			else
			{
				font = dxf.font;
			}
			return new global::NPOI.XSSF.UserModel.XSSFFontFormatting(font);
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x000156B4 File Offset: 0x000138B4
		public global::NPOI.SS.UserModel.IFontFormatting FontFormatting
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf dxf = this.GetDxf(false);
				if (dxf == null || !dxf.IsSetFont())
				{
					return null;
				}
				return new global::NPOI.XSSF.UserModel.XSSFFontFormatting(dxf.font);
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x000156E4 File Offset: 0x000138E4
		public global::NPOI.SS.UserModel.IPatternFormatting CreatePatternFormatting()
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf dxf = this.GetDxf(true);
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Fill fill;
			if (!dxf.IsSetFill())
			{
				fill = dxf.AddNewFill();
			}
			else
			{
				fill = dxf.fill;
			}
			return new global::NPOI.XSSF.UserModel.XSSFPatternFormatting(fill);
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00015718 File Offset: 0x00013918
		public global::NPOI.SS.UserModel.IPatternFormatting PatternFormatting
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dxf dxf = this.GetDxf(false);
				if (dxf == null || !dxf.IsSetFill())
				{
					return null;
				}
				return new global::NPOI.XSSF.UserModel.XSSFPatternFormatting(dxf.fill);
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00015748 File Offset: 0x00013948
		public global::NPOI.XSSF.UserModel.XSSFDataBarFormatting CreateDataBarFormatting(global::NPOI.XSSF.UserModel.XSSFColor color)
		{
			if (this._cfRule.IsSetDataBar() && this._cfRule.type == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.dataBar)
			{
				return this.DataBarFormatting as global::NPOI.XSSF.UserModel.XSSFDataBarFormatting;
			}
			this._cfRule.type = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.dataBar;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_DataBar ct_DataBar;
			if (this._cfRule.IsSetDataBar())
			{
				ct_DataBar = this._cfRule.dataBar;
			}
			else
			{
				ct_DataBar = this._cfRule.AddNewDataBar();
			}
			ct_DataBar.color = color.GetCTColor();
			ct_DataBar.AddNewCfvo().type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType), global::NPOI.SS.UserModel.RangeType.MIN.name);
			ct_DataBar.AddNewCfvo().type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType), global::NPOI.SS.UserModel.RangeType.MAX.name);
			return new global::NPOI.XSSF.UserModel.XSSFDataBarFormatting(ct_DataBar);
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x00015815 File Offset: 0x00013A15
		public global::NPOI.SS.UserModel.IDataBarFormatting DataBarFormatting
		{
			get
			{
				if (this._cfRule.IsSetDataBar())
				{
					return new global::NPOI.XSSF.UserModel.XSSFDataBarFormatting(this._cfRule.dataBar);
				}
				return null;
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00015838 File Offset: 0x00013A38
		public global::NPOI.XSSF.UserModel.XSSFIconMultiStateFormatting CreateMultiStateFormatting(global::NPOI.SS.UserModel.IconSet iconSet)
		{
			if (this._cfRule.IsSetIconSet() && this._cfRule.type == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.iconSet)
			{
				return this.MultiStateFormatting as global::NPOI.XSSF.UserModel.XSSFIconMultiStateFormatting;
			}
			this._cfRule.type = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.iconSet;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_IconSet ct_IconSet;
			if (this._cfRule.IsSetIconSet())
			{
				ct_IconSet = this._cfRule.iconSet;
			}
			else
			{
				ct_IconSet = this._cfRule.AddNewIconSet();
			}
			if (iconSet.name != null)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType iconSet2 = global::NPOI.XSSF.Util.XmlEnumParser<global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType>.ForName(iconSet.name, global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType.Item3TrafficLights1);
				ct_IconSet.iconSet = iconSet2;
			}
			int num = 100 / iconSet.num;
			global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType), global::NPOI.SS.UserModel.RangeType.PERCENT.name);
			for (int i = 0; i < iconSet.num; i++)
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo ct_Cfvo = ct_IconSet.AddNewCfvo();
				ct_Cfvo.type = type;
				ct_Cfvo.val = (i * num).ToString();
			}
			return new global::NPOI.XSSF.UserModel.XSSFIconMultiStateFormatting(ct_IconSet);
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00015920 File Offset: 0x00013B20
		public global::NPOI.SS.UserModel.IIconMultiStateFormatting MultiStateFormatting
		{
			get
			{
				if (this._cfRule.IsSetIconSet())
				{
					return new global::NPOI.XSSF.UserModel.XSSFIconMultiStateFormatting(this._cfRule.iconSet);
				}
				return null;
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00015944 File Offset: 0x00013B44
		public global::NPOI.XSSF.UserModel.XSSFColorScaleFormatting CreateColorScaleFormatting()
		{
			if (this._cfRule.IsSetColorScale() && this._cfRule.type == global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.colorScale)
			{
				return this.ColorScaleFormatting as global::NPOI.XSSF.UserModel.XSSFColorScaleFormatting;
			}
			this._cfRule.type = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType.colorScale;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColorScale ct_ColorScale;
			if (this._cfRule.IsSetColorScale())
			{
				ct_ColorScale = this._cfRule.colorScale;
			}
			else
			{
				ct_ColorScale = this._cfRule.AddNewColorScale();
			}
			if (ct_ColorScale.SizeOfCfvoArray() == 0)
			{
				ct_ColorScale.AddNewCfvo().type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType), global::NPOI.SS.UserModel.RangeType.MIN.name);
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Cfvo ct_Cfvo = ct_ColorScale.AddNewCfvo();
				ct_Cfvo.type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType), global::NPOI.SS.UserModel.RangeType.PERCENTILE.name);
				ct_Cfvo.val = "50";
				ct_ColorScale.AddNewCfvo().type = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfvoType), global::NPOI.SS.UserModel.RangeType.MAX.name);
				for (int i = 0; i < 3; i++)
				{
					ct_ColorScale.AddNewColor();
				}
			}
			return new global::NPOI.XSSF.UserModel.XSSFColorScaleFormatting(ct_ColorScale);
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x00015A57 File Offset: 0x00013C57
		public global::NPOI.SS.UserModel.IColorScaleFormatting ColorScaleFormatting
		{
			get
			{
				if (this._cfRule.IsSetColorScale())
				{
					return new global::NPOI.XSSF.UserModel.XSSFColorScaleFormatting(this._cfRule.colorScale);
				}
				return null;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00015A78 File Offset: 0x00013C78
		public global::NPOI.SS.UserModel.ConditionType ConditionType
		{
			get
			{
				return global::NPOI.XSSF.UserModel.XSSFConditionalFormattingRule.typeLookup[this._cfRule.type];
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x00015A90 File Offset: 0x00013C90
		public global::NPOI.SS.UserModel.ComparisonOperator ComparisonOperation
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator? @operator = this._cfRule.@operator;
				if (@operator == null)
				{
					return global::NPOI.SS.UserModel.ComparisonOperator.NoComparison;
				}
				if (@operator != null)
				{
					switch (@operator.GetValueOrDefault())
					{
					case global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator.lessThan:
						return global::NPOI.SS.UserModel.ComparisonOperator.LessThan;
					case global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator.lessThanOrEqual:
						return global::NPOI.SS.UserModel.ComparisonOperator.LessThanOrEqual;
					case global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator.equal:
						return global::NPOI.SS.UserModel.ComparisonOperator.Equal;
					case global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator.notEqual:
						return global::NPOI.SS.UserModel.ComparisonOperator.NotEqual;
					case global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator.greaterThanOrEqual:
						return global::NPOI.SS.UserModel.ComparisonOperator.GreaterThanOrEqual;
					case global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator.greaterThan:
						return global::NPOI.SS.UserModel.ComparisonOperator.GreaterThan;
					case global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator.between:
						return global::NPOI.SS.UserModel.ComparisonOperator.Between;
					case global::NPOI.OpenXmlFormats.Spreadsheet.ST_ConditionalFormattingOperator.notBetween:
						return global::NPOI.SS.UserModel.ComparisonOperator.NotBetween;
					}
				}
				return global::NPOI.SS.UserModel.ComparisonOperator.NoComparison;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00015AFE File Offset: 0x00013CFE
		public string Formula1
		{
			get
			{
				if (this._cfRule.SizeOfFormulaArray() <= 0)
				{
					return null;
				}
				return this._cfRule.GetFormulaArray(0);
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00015B1C File Offset: 0x00013D1C
		public string Formula2
		{
			get
			{
				if (this._cfRule.SizeOfFormulaArray() != 2)
				{
					return null;
				}
				return this._cfRule.GetFormulaArray(1);
			}
		}

		// Token: 0x040002B6 RID: 694
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CfRule _cfRule;

		// Token: 0x040002B7 RID: 695
		private global::NPOI.XSSF.UserModel.XSSFSheet _sh;

		// Token: 0x040002B8 RID: 696
		private static global::System.Collections.Generic.Dictionary<global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType, global::NPOI.SS.UserModel.ConditionType> typeLookup = new global::System.Collections.Generic.Dictionary<global::NPOI.OpenXmlFormats.Spreadsheet.ST_CfType, global::NPOI.SS.UserModel.ConditionType>();
	}
}
