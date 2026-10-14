using System;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.CF;
using NPOI.HSSF.UserModel;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000396 RID: 918
	public abstract class CFRuleBase : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06001F66 RID: 8038 RVA: 0x00060C6D File Offset: 0x0005EE6D
		private static global::NPOI.Util.BitField bf(long i)
		{
			return global::NPOI.Util.BitFieldFactory.GetInstance((int)i);
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00060C76 File Offset: 0x0005EE76
		protected CFRuleBase(byte conditionType, byte comparisonOperation)
		{
			this.ConditionType = conditionType;
			this.ComparisonOperation = comparisonOperation;
			this.formula1 = global::NPOI.SS.Formula.Formula.Create(global::NPOI.SS.Formula.PTG.Ptg.EMPTY_PTG_ARRAY);
			this.formula2 = global::NPOI.SS.Formula.Formula.Create(global::NPOI.SS.Formula.PTG.Ptg.EMPTY_PTG_ARRAY);
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x00060CAC File Offset: 0x0005EEAC
		protected CFRuleBase(byte conditionType, byte comparisonOperation, global::NPOI.SS.Formula.PTG.Ptg[] formula1, global::NPOI.SS.Formula.PTG.Ptg[] formula2) : this(conditionType, comparisonOperation)
		{
			this.formula1 = global::NPOI.SS.Formula.Formula.Create(formula1);
			this.formula2 = global::NPOI.SS.Formula.Formula.Create(formula2);
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x0005FE49 File Offset: 0x0005E049
		protected CFRuleBase()
		{
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00060CD0 File Offset: 0x0005EED0
		protected int ReadFormatOptions(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.formatting_options = in1.ReadInt();
			this.formatting_not_used = in1.ReadShort();
			int num = 6;
			if (this.ContainsFontFormattingBlock)
			{
				this._fontFormatting = new global::NPOI.HSSF.Record.CF.FontFormatting(in1);
				num += this._fontFormatting.DataLength;
			}
			if (this.ContainsBorderFormattingBlock)
			{
				this._borderFormatting = new global::NPOI.HSSF.Record.CF.BorderFormatting(in1);
				num += this._borderFormatting.DataLength;
			}
			if (this.ContainsPatternFormattingBlock)
			{
				this._patternFormatting = new global::NPOI.HSSF.Record.CF.PatternFormatting(in1);
				num += this._patternFormatting.DataLength;
			}
			return num;
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x00060D5E File Offset: 0x0005EF5E
		// (set) Token: 0x06001F6C RID: 8044 RVA: 0x00060D66 File Offset: 0x0005EF66
		public byte ConditionType
		{
			get
			{
				return this.condition_type;
			}
			set
			{
				if (this is global::NPOI.HSSF.Record.CFRuleRecord && value != 1 && value != 2)
				{
					throw new global::System.ArgumentException("CFRuleRecord only accepts Value-Is and Formula types");
				}
				this.condition_type = value;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x00060D8A File Offset: 0x0005EF8A
		// (set) Token: 0x06001F6E RID: 8046 RVA: 0x00060D92 File Offset: 0x0005EF92
		public byte ComparisonOperation
		{
			get
			{
				return this.comparison_operator;
			}
			set
			{
				if (value < 0 || value > global::NPOI.HSSF.Record.CFRuleBase.ComparisonOperator.max_operator)
				{
					throw new global::System.ArgumentException("Valid operators are only in the range 0 to " + global::NPOI.HSSF.Record.CFRuleBase.ComparisonOperator.max_operator.ToString());
				}
				this.comparison_operator = value;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x00060DC1 File Offset: 0x0005EFC1
		public bool ContainsFontFormattingBlock
		{
			get
			{
				return this.GetOptionFlag(global::NPOI.HSSF.Record.CFRuleBase.font);
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001F70 RID: 8048 RVA: 0x00060DCE File Offset: 0x0005EFCE
		// (set) Token: 0x06001F71 RID: 8049 RVA: 0x00060DE0 File Offset: 0x0005EFE0
		public global::NPOI.HSSF.Record.CF.FontFormatting FontFormatting
		{
			get
			{
				if (this.ContainsFontFormattingBlock)
				{
					return this._fontFormatting;
				}
				return null;
			}
			set
			{
				this._fontFormatting = value;
				this.SetOptionFlag(value != null, global::NPOI.HSSF.Record.CFRuleBase.font);
			}
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00060DF8 File Offset: 0x0005EFF8
		public bool ContainsAlignFormattingBlock()
		{
			return this.GetOptionFlag(global::NPOI.HSSF.Record.CFRuleBase.align);
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x00060E05 File Offset: 0x0005F005
		public void SetAlignFormattingUnChanged()
		{
			this.SetOptionFlag(false, global::NPOI.HSSF.Record.CFRuleBase.align);
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x00060E13 File Offset: 0x0005F013
		public bool ContainsBorderFormattingBlock
		{
			get
			{
				return this.GetOptionFlag(global::NPOI.HSSF.Record.CFRuleBase.bord);
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001F75 RID: 8053 RVA: 0x00060E20 File Offset: 0x0005F020
		// (set) Token: 0x06001F76 RID: 8054 RVA: 0x00060E32 File Offset: 0x0005F032
		public global::NPOI.HSSF.Record.CF.BorderFormatting BorderFormatting
		{
			get
			{
				if (this.ContainsBorderFormattingBlock)
				{
					return this._borderFormatting;
				}
				return null;
			}
			set
			{
				this._borderFormatting = value;
				this.SetOptionFlag(value != null, global::NPOI.HSSF.Record.CFRuleBase.bord);
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x00060E4A File Offset: 0x0005F04A
		public bool ContainsPatternFormattingBlock
		{
			get
			{
				return this.GetOptionFlag(global::NPOI.HSSF.Record.CFRuleBase.patt);
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001F78 RID: 8056 RVA: 0x00060E57 File Offset: 0x0005F057
		// (set) Token: 0x06001F79 RID: 8057 RVA: 0x00060E69 File Offset: 0x0005F069
		public global::NPOI.HSSF.Record.CF.PatternFormatting PatternFormatting
		{
			get
			{
				if (this.ContainsPatternFormattingBlock)
				{
					return this._patternFormatting;
				}
				return null;
			}
			set
			{
				this._patternFormatting = value;
				this.SetOptionFlag(value != null, global::NPOI.HSSF.Record.CFRuleBase.patt);
			}
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x00060E81 File Offset: 0x0005F081
		public bool ContainsProtectionFormattingBlock()
		{
			return this.GetOptionFlag(global::NPOI.HSSF.Record.CFRuleBase.prot);
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x00060E8E File Offset: 0x0005F08E
		public void SetProtectionFormattingUnChanged()
		{
			this.SetOptionFlag(false, global::NPOI.HSSF.Record.CFRuleBase.prot);
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x00060E9C File Offset: 0x0005F09C
		public int Options
		{
			get
			{
				return this.formatting_options;
			}
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x00060EA4 File Offset: 0x0005F0A4
		private bool IsModified(global::NPOI.Util.BitField field)
		{
			return !field.IsSet(this.formatting_options);
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x00060EB5 File Offset: 0x0005F0B5
		private void SetModified(bool modified, global::NPOI.Util.BitField field)
		{
			this.formatting_options = field.SetBoolean(this.formatting_options, !modified);
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x00060ECD File Offset: 0x0005F0CD
		// (set) Token: 0x06001F80 RID: 8064 RVA: 0x00060EDA File Offset: 0x0005F0DA
		public bool IsLeftBorderModified
		{
			get
			{
				return this.IsModified(global::NPOI.HSSF.Record.CFRuleBase.bordLeft);
			}
			set
			{
				this.SetModified(value, global::NPOI.HSSF.Record.CFRuleBase.bordLeft);
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x00060EE8 File Offset: 0x0005F0E8
		// (set) Token: 0x06001F82 RID: 8066 RVA: 0x00060EF5 File Offset: 0x0005F0F5
		public bool IsRightBorderModified
		{
			get
			{
				return this.IsModified(global::NPOI.HSSF.Record.CFRuleBase.bordRight);
			}
			set
			{
				this.SetModified(value, global::NPOI.HSSF.Record.CFRuleBase.bordRight);
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x00060F03 File Offset: 0x0005F103
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x00060F10 File Offset: 0x0005F110
		public bool IsTopBorderModified
		{
			get
			{
				return this.IsModified(global::NPOI.HSSF.Record.CFRuleBase.bordTop);
			}
			set
			{
				this.SetModified(value, global::NPOI.HSSF.Record.CFRuleBase.bordTop);
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x00060F1E File Offset: 0x0005F11E
		// (set) Token: 0x06001F86 RID: 8070 RVA: 0x00060F2B File Offset: 0x0005F12B
		public bool IsBottomBorderModified
		{
			get
			{
				return this.IsModified(global::NPOI.HSSF.Record.CFRuleBase.bordBot);
			}
			set
			{
				this.SetModified(value, global::NPOI.HSSF.Record.CFRuleBase.bordBot);
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x00060F39 File Offset: 0x0005F139
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x00060F46 File Offset: 0x0005F146
		public bool IsTopLeftBottomRightBorderModified
		{
			get
			{
				return this.IsModified(global::NPOI.HSSF.Record.CFRuleBase.bordTlBr);
			}
			set
			{
				this.SetModified(value, global::NPOI.HSSF.Record.CFRuleBase.bordTlBr);
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x00060F54 File Offset: 0x0005F154
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x00060F61 File Offset: 0x0005F161
		public bool IsBottomLeftTopRightBorderModified
		{
			get
			{
				return this.IsModified(global::NPOI.HSSF.Record.CFRuleBase.bordBlTr);
			}
			set
			{
				this.SetModified(value, global::NPOI.HSSF.Record.CFRuleBase.bordBlTr);
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x00060F6F File Offset: 0x0005F16F
		// (set) Token: 0x06001F8C RID: 8076 RVA: 0x00060F7C File Offset: 0x0005F17C
		public bool IsPatternStyleModified
		{
			get
			{
				return this.IsModified(global::NPOI.HSSF.Record.CFRuleBase.pattStyle);
			}
			set
			{
				this.SetModified(value, global::NPOI.HSSF.Record.CFRuleBase.pattStyle);
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x00060F8A File Offset: 0x0005F18A
		// (set) Token: 0x06001F8E RID: 8078 RVA: 0x00060F97 File Offset: 0x0005F197
		public bool IsPatternColorModified
		{
			get
			{
				return this.IsModified(global::NPOI.HSSF.Record.CFRuleBase.pattCol);
			}
			set
			{
				this.SetModified(value, global::NPOI.HSSF.Record.CFRuleBase.pattCol);
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x00060FA5 File Offset: 0x0005F1A5
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x00060FB2 File Offset: 0x0005F1B2
		public bool IsPatternBackgroundColorModified
		{
			get
			{
				return this.IsModified(global::NPOI.HSSF.Record.CFRuleBase.pattBgCol);
			}
			set
			{
				this.SetModified(value, global::NPOI.HSSF.Record.CFRuleBase.pattBgCol);
			}
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x00060FC0 File Offset: 0x0005F1C0
		private bool GetOptionFlag(global::NPOI.Util.BitField field)
		{
			return field.IsSet(this.formatting_options);
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00060FCE File Offset: 0x0005F1CE
		private void SetOptionFlag(bool flag, global::NPOI.Util.BitField field)
		{
			this.formatting_options = field.SetBoolean(this.formatting_options, flag);
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x00060FE3 File Offset: 0x0005F1E3
		protected int FormattingBlockSize
		{
			get
			{
				return 6 + (this.ContainsFontFormattingBlock ? this._fontFormatting.RawRecord.Length : 0) + (this.ContainsBorderFormattingBlock ? 8 : 0) + (this.ContainsPatternFormattingBlock ? 4 : 0);
			}
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x0006101C File Offset: 0x0005F21C
		protected void SerializeFormattingBlock(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.formatting_options);
			out1.WriteShort((int)this.formatting_not_used);
			if (this.ContainsFontFormattingBlock)
			{
				byte[] rawRecord = this._fontFormatting.RawRecord;
				out1.Write(rawRecord);
			}
			if (this.ContainsBorderFormattingBlock)
			{
				this._borderFormatting.Serialize(out1);
			}
			if (this.ContainsPatternFormattingBlock)
			{
				this._patternFormatting.Serialize(out1);
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x00061084 File Offset: 0x0005F284
		// (set) Token: 0x06001F96 RID: 8086 RVA: 0x00061091 File Offset: 0x0005F291
		public global::NPOI.SS.Formula.PTG.Ptg[] ParsedExpression1
		{
			get
			{
				return this.formula1.Tokens;
			}
			set
			{
				this.formula1 = global::NPOI.SS.Formula.Formula.Create(value);
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x0006109F File Offset: 0x0005F29F
		// (set) Token: 0x06001F98 RID: 8088 RVA: 0x000610A7 File Offset: 0x0005F2A7
		protected global::NPOI.SS.Formula.Formula Formula1
		{
			get
			{
				return this.formula1;
			}
			set
			{
				this.formula1 = value;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x000610B0 File Offset: 0x0005F2B0
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x000610BD File Offset: 0x0005F2BD
		public global::NPOI.SS.Formula.PTG.Ptg[] ParsedExpression2
		{
			get
			{
				return this.formula2.Tokens;
			}
			set
			{
				this.formula2 = global::NPOI.SS.Formula.Formula.Create(value);
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x000610CB File Offset: 0x0005F2CB
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x000610D3 File Offset: 0x0005F2D3
		protected global::NPOI.SS.Formula.Formula Formula2
		{
			get
			{
				return this.formula2;
			}
			set
			{
				this.formula2 = value;
			}
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x000610DC File Offset: 0x0005F2DC
		protected static int GetFormulaSize(global::NPOI.SS.Formula.Formula formula)
		{
			return formula.EncodedTokenSize;
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x000610E4 File Offset: 0x0005F2E4
		public static global::NPOI.SS.Formula.PTG.Ptg[] ParseFormula(string formula, global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			if (formula == null)
			{
				return null;
			}
			int sheetIndex = sheet.Workbook.GetSheetIndex(sheet);
			return global::NPOI.HSSF.Model.HSSFFormulaParser.Parse(formula, sheet.Workbook as global::NPOI.HSSF.UserModel.HSSFWorkbook, global::NPOI.SS.Formula.FormulaType.Cell, sheetIndex);
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x00061118 File Offset: 0x0005F318
		protected void CopyTo(global::NPOI.HSSF.Record.CFRuleBase rec)
		{
			rec.condition_type = this.condition_type;
			rec.comparison_operator = this.comparison_operator;
			rec.formatting_options = this.formatting_options;
			rec.formatting_not_used = this.formatting_not_used;
			if (this.ContainsFontFormattingBlock)
			{
				rec._fontFormatting = (global::NPOI.HSSF.Record.CF.FontFormatting)this._fontFormatting.Clone();
			}
			if (this.ContainsBorderFormattingBlock)
			{
				rec._borderFormatting = (global::NPOI.HSSF.Record.CF.BorderFormatting)this._borderFormatting.Clone();
			}
			if (this.ContainsPatternFormattingBlock)
			{
				rec._patternFormatting = (global::NPOI.HSSF.Record.CF.PatternFormatting)this._patternFormatting.Clone();
			}
			rec.formula1 = this.formula1.Copy();
			rec.formula2 = this.formula2.Copy();
		}

		// Token: 0x04000BE1 RID: 3041
		private byte condition_type;

		// Token: 0x04000BE2 RID: 3042
		public const byte CONDITION_TYPE_CELL_VALUE_IS = 1;

		// Token: 0x04000BE3 RID: 3043
		public const byte CONDITION_TYPE_FORMULA = 2;

		// Token: 0x04000BE4 RID: 3044
		public const byte CONDITION_TYPE_COLOR_SCALE = 3;

		// Token: 0x04000BE5 RID: 3045
		public const byte CONDITION_TYPE_DATA_BAR = 4;

		// Token: 0x04000BE6 RID: 3046
		public const byte CONDITION_TYPE_FILTER = 5;

		// Token: 0x04000BE7 RID: 3047
		public const byte CONDITION_TYPE_ICON_SET = 6;

		// Token: 0x04000BE8 RID: 3048
		private byte comparison_operator;

		// Token: 0x04000BE9 RID: 3049
		public static int TEMPLATE_CELL_VALUE = 0;

		// Token: 0x04000BEA RID: 3050
		public static int TEMPLATE_FORMULA = 1;

		// Token: 0x04000BEB RID: 3051
		public static int TEMPLATE_COLOR_SCALE_FORMATTING = 2;

		// Token: 0x04000BEC RID: 3052
		public static int TEMPLATE_DATA_BAR_FORMATTING = 3;

		// Token: 0x04000BED RID: 3053
		public static int TEMPLATE_ICON_SET_FORMATTING = 4;

		// Token: 0x04000BEE RID: 3054
		public static int TEMPLATE_FILTER = 5;

		// Token: 0x04000BEF RID: 3055
		public static int TEMPLATE_UNIQUE_VALUES = 7;

		// Token: 0x04000BF0 RID: 3056
		public static int TEMPLATE_CONTAINS_TEXT = 8;

		// Token: 0x04000BF1 RID: 3057
		public static int TEMPLATE_CONTAINS_BLANKS = 9;

		// Token: 0x04000BF2 RID: 3058
		public static int TEMPLATE_CONTAINS_NO_BLANKS = 10;

		// Token: 0x04000BF3 RID: 3059
		public static int TEMPLATE_CONTAINS_ERRORS = 11;

		// Token: 0x04000BF4 RID: 3060
		public static int TEMPLATE_CONTAINS_NO_ERRORS = 12;

		// Token: 0x04000BF5 RID: 3061
		public static int TEMPLATE_TODAY = 15;

		// Token: 0x04000BF6 RID: 3062
		public static int TEMPLATE_TOMORROW = 16;

		// Token: 0x04000BF7 RID: 3063
		public static int TEMPLATE_YESTERDAY = 17;

		// Token: 0x04000BF8 RID: 3064
		public static int TEMPLATE_LAST_7_DAYS = 18;

		// Token: 0x04000BF9 RID: 3065
		public static int TEMPLATE_LAST_MONTH = 19;

		// Token: 0x04000BFA RID: 3066
		public static int TEMPLATE_NEXT_MONTH = 20;

		// Token: 0x04000BFB RID: 3067
		public static int TEMPLATE_THIS_WEEK = 21;

		// Token: 0x04000BFC RID: 3068
		public static int TEMPLATE_NEXT_WEEK = 22;

		// Token: 0x04000BFD RID: 3069
		public static int TEMPLATE_LAST_WEEK = 23;

		// Token: 0x04000BFE RID: 3070
		public static int TEMPLATE_THIS_MONTH = 24;

		// Token: 0x04000BFF RID: 3071
		public static int TEMPLATE_ABOVE_AVERAGE = 25;

		// Token: 0x04000C00 RID: 3072
		public static int TEMPLATE_BELOW_AVERAGE = 26;

		// Token: 0x04000C01 RID: 3073
		public static int TEMPLATE_DUPLICATE_VALUES = 27;

		// Token: 0x04000C02 RID: 3074
		public static int TEMPLATE_ABOVE_OR_EQUAL_TO_AVERAGE = 29;

		// Token: 0x04000C03 RID: 3075
		public static int TEMPLATE_BELOW_OR_EQUAL_TO_AVERAGE = 30;

		// Token: 0x04000C04 RID: 3076
		internal static global::NPOI.Util.BitField modificationBits = global::NPOI.HSSF.Record.CFRuleBase.bf(4194303L);

		// Token: 0x04000C05 RID: 3077
		internal static global::NPOI.Util.BitField alignHor = global::NPOI.HSSF.Record.CFRuleBase.bf(1L);

		// Token: 0x04000C06 RID: 3078
		internal static global::NPOI.Util.BitField alignVer = global::NPOI.HSSF.Record.CFRuleBase.bf(2L);

		// Token: 0x04000C07 RID: 3079
		internal static global::NPOI.Util.BitField alignWrap = global::NPOI.HSSF.Record.CFRuleBase.bf(4L);

		// Token: 0x04000C08 RID: 3080
		internal static global::NPOI.Util.BitField alignRot = global::NPOI.HSSF.Record.CFRuleBase.bf(8L);

		// Token: 0x04000C09 RID: 3081
		internal static global::NPOI.Util.BitField alignJustLast = global::NPOI.HSSF.Record.CFRuleBase.bf(16L);

		// Token: 0x04000C0A RID: 3082
		internal static global::NPOI.Util.BitField alignIndent = global::NPOI.HSSF.Record.CFRuleBase.bf(32L);

		// Token: 0x04000C0B RID: 3083
		internal static global::NPOI.Util.BitField alignShrin = global::NPOI.HSSF.Record.CFRuleBase.bf(64L);

		// Token: 0x04000C0C RID: 3084
		internal static global::NPOI.Util.BitField mergeCell = global::NPOI.HSSF.Record.CFRuleBase.bf(128L);

		// Token: 0x04000C0D RID: 3085
		internal static global::NPOI.Util.BitField protLocked = global::NPOI.HSSF.Record.CFRuleBase.bf(256L);

		// Token: 0x04000C0E RID: 3086
		internal static global::NPOI.Util.BitField protHidden = global::NPOI.HSSF.Record.CFRuleBase.bf(512L);

		// Token: 0x04000C0F RID: 3087
		internal static global::NPOI.Util.BitField bordLeft = global::NPOI.HSSF.Record.CFRuleBase.bf(1024L);

		// Token: 0x04000C10 RID: 3088
		internal static global::NPOI.Util.BitField bordRight = global::NPOI.HSSF.Record.CFRuleBase.bf(2048L);

		// Token: 0x04000C11 RID: 3089
		internal static global::NPOI.Util.BitField bordTop = global::NPOI.HSSF.Record.CFRuleBase.bf(4096L);

		// Token: 0x04000C12 RID: 3090
		internal static global::NPOI.Util.BitField bordBot = global::NPOI.HSSF.Record.CFRuleBase.bf(8192L);

		// Token: 0x04000C13 RID: 3091
		internal static global::NPOI.Util.BitField bordTlBr = global::NPOI.HSSF.Record.CFRuleBase.bf(16384L);

		// Token: 0x04000C14 RID: 3092
		internal static global::NPOI.Util.BitField bordBlTr = global::NPOI.HSSF.Record.CFRuleBase.bf(32768L);

		// Token: 0x04000C15 RID: 3093
		internal static global::NPOI.Util.BitField pattStyle = global::NPOI.HSSF.Record.CFRuleBase.bf(65536L);

		// Token: 0x04000C16 RID: 3094
		internal static global::NPOI.Util.BitField pattCol = global::NPOI.HSSF.Record.CFRuleBase.bf(131072L);

		// Token: 0x04000C17 RID: 3095
		internal static global::NPOI.Util.BitField pattBgCol = global::NPOI.HSSF.Record.CFRuleBase.bf(262144L);

		// Token: 0x04000C18 RID: 3096
		internal static global::NPOI.Util.BitField notUsed2 = global::NPOI.HSSF.Record.CFRuleBase.bf(3670016L);

		// Token: 0x04000C19 RID: 3097
		internal static global::NPOI.Util.BitField undocumented = global::NPOI.HSSF.Record.CFRuleBase.bf(62914560L);

		// Token: 0x04000C1A RID: 3098
		internal static global::NPOI.Util.BitField fmtBlockBits = global::NPOI.HSSF.Record.CFRuleBase.bf(2080374784L);

		// Token: 0x04000C1B RID: 3099
		internal static global::NPOI.Util.BitField font = global::NPOI.HSSF.Record.CFRuleBase.bf(67108864L);

		// Token: 0x04000C1C RID: 3100
		internal static global::NPOI.Util.BitField align = global::NPOI.HSSF.Record.CFRuleBase.bf(134217728L);

		// Token: 0x04000C1D RID: 3101
		internal static global::NPOI.Util.BitField bord = global::NPOI.HSSF.Record.CFRuleBase.bf(268435456L);

		// Token: 0x04000C1E RID: 3102
		internal static global::NPOI.Util.BitField patt = global::NPOI.HSSF.Record.CFRuleBase.bf(536870912L);

		// Token: 0x04000C1F RID: 3103
		internal static global::NPOI.Util.BitField prot = global::NPOI.HSSF.Record.CFRuleBase.bf(1073741824L);

		// Token: 0x04000C20 RID: 3104
		internal static global::NPOI.Util.BitField alignTextDir = global::NPOI.HSSF.Record.CFRuleBase.bf((long)((ulong)int.MinValue));

		// Token: 0x04000C21 RID: 3105
		protected int formatting_options;

		// Token: 0x04000C22 RID: 3106
		protected short formatting_not_used;

		// Token: 0x04000C23 RID: 3107
		protected global::NPOI.HSSF.Record.CF.FontFormatting _fontFormatting;

		// Token: 0x04000C24 RID: 3108
		protected global::NPOI.HSSF.Record.CF.BorderFormatting _borderFormatting;

		// Token: 0x04000C25 RID: 3109
		protected global::NPOI.HSSF.Record.CF.PatternFormatting _patternFormatting;

		// Token: 0x04000C26 RID: 3110
		private global::NPOI.SS.Formula.Formula formula1;

		// Token: 0x04000C27 RID: 3111
		private global::NPOI.SS.Formula.Formula formula2;

		// Token: 0x02000607 RID: 1543
		public static class ComparisonOperator
		{
			// Token: 0x04001A50 RID: 6736
			public static byte NO_COMPARISON = 0;

			// Token: 0x04001A51 RID: 6737
			public static byte BETWEEN = 1;

			// Token: 0x04001A52 RID: 6738
			public static byte NOT_BETWEEN = 2;

			// Token: 0x04001A53 RID: 6739
			public static byte EQUAL = 3;

			// Token: 0x04001A54 RID: 6740
			public static byte NOT_EQUAL = 4;

			// Token: 0x04001A55 RID: 6741
			public static byte GT = 5;

			// Token: 0x04001A56 RID: 6742
			public static byte LT = 6;

			// Token: 0x04001A57 RID: 6743
			public static byte GE = 7;

			// Token: 0x04001A58 RID: 6744
			public static byte LE = 8;

			// Token: 0x04001A59 RID: 6745
			public static byte max_operator = 8;
		}
	}
}
