using System;
using System.Text;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003CE RID: 974
	public class DVRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x0600223F RID: 8767 RVA: 0x000679A0 File Offset: 0x00065BA0
		public DVRecord()
		{
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x00067A38 File Offset: 0x00065C38
		public DVRecord(int validationType, int operator1, int errorStyle, bool emptyCellAllowed, bool suppressDropDownArrow, bool isExplicitList, bool showPromptBox, string promptTitle, string promptText, bool showErrorBox, string errorTitle, string errorText, global::NPOI.SS.Formula.PTG.Ptg[] formula1, global::NPOI.SS.Formula.PTG.Ptg[] formula2, global::NPOI.SS.Util.CellRangeAddressList regions)
		{
			int num = 0;
			num = this.opt_data_type.SetValue(num, validationType);
			num = this.opt_condition_operator.SetValue(num, operator1);
			num = this.opt_error_style.SetValue(num, errorStyle);
			num = this.opt_empty_cell_allowed.SetBoolean(num, emptyCellAllowed);
			num = this.opt_suppress_dropdown_arrow.SetBoolean(num, suppressDropDownArrow);
			num = this.opt_string_list_formula.SetBoolean(num, isExplicitList);
			num = this.opt_show_prompt_on_cell_selected.SetBoolean(num, showPromptBox);
			num = this.opt_show_error_on_invalid_value.SetBoolean(num, showErrorBox);
			this._option_flags = num;
			this._promptTitle = global::NPOI.HSSF.Record.DVRecord.ResolveTitleText(promptTitle);
			this._promptText = global::NPOI.HSSF.Record.DVRecord.ResolveTitleText(promptText);
			this._errorTitle = global::NPOI.HSSF.Record.DVRecord.ResolveTitleText(errorTitle);
			this._errorText = global::NPOI.HSSF.Record.DVRecord.ResolveTitleText(errorText);
			this._formula1 = global::NPOI.SS.Formula.Formula.Create(formula1);
			this._formula2 = global::NPOI.SS.Formula.Formula.Create(formula2);
			this._regions = regions;
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x00067BA4 File Offset: 0x00065DA4
		public DVRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._option_flags = in1.ReadInt();
			this._promptTitle = global::NPOI.HSSF.Record.DVRecord.ReadUnicodeString(in1);
			this._errorTitle = global::NPOI.HSSF.Record.DVRecord.ReadUnicodeString(in1);
			this._promptText = global::NPOI.HSSF.Record.DVRecord.ReadUnicodeString(in1);
			this._errorText = global::NPOI.HSSF.Record.DVRecord.ReadUnicodeString(in1);
			int encodedTokenLen = in1.ReadUShort();
			this._not_used_1 = in1.ReadShort();
			this._formula1 = global::NPOI.SS.Formula.Formula.Read(encodedTokenLen, in1);
			int encodedTokenLen2 = in1.ReadUShort();
			this._not_used_2 = in1.ReadShort();
			this._formula2 = global::NPOI.SS.Formula.Formula.Read(encodedTokenLen2, in1);
			this._regions = new global::NPOI.SS.Util.CellRangeAddressList(in1);
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00067CC4 File Offset: 0x00065EC4
		private static global::NPOI.HSSF.Record.UnicodeString ResolveTitleText(string str)
		{
			if (str == null || str.Length < 1)
			{
				return global::NPOI.HSSF.Record.DVRecord.NULL_TEXT_STRING;
			}
			return new global::NPOI.HSSF.Record.UnicodeString(str);
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x00067CDE File Offset: 0x00065EDE
		private static string ResolveTitleString(global::NPOI.HSSF.Record.UnicodeString us)
		{
			if (us == null || us.Equals(global::NPOI.HSSF.Record.DVRecord.NULL_TEXT_STRING))
			{
				return null;
			}
			return us.String;
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x00067CF8 File Offset: 0x00065EF8
		private static global::NPOI.HSSF.Record.UnicodeString ReadUnicodeString(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			return new global::NPOI.HSSF.Record.UnicodeString(in1);
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x00067D00 File Offset: 0x00065F00
		// (set) Token: 0x06002246 RID: 8774 RVA: 0x00067D13 File Offset: 0x00065F13
		public int DataType
		{
			get
			{
				return this.opt_data_type.GetValue(this._option_flags);
			}
			set
			{
				this._option_flags = this.opt_data_type.SetValue(this._option_flags, value);
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x00067D2D File Offset: 0x00065F2D
		// (set) Token: 0x06002248 RID: 8776 RVA: 0x00067D40 File Offset: 0x00065F40
		public int ErrorStyle
		{
			get
			{
				return this.opt_error_style.GetValue(this._option_flags);
			}
			set
			{
				this._option_flags = this.opt_error_style.SetValue(this._option_flags, value);
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x00067D5A File Offset: 0x00065F5A
		// (set) Token: 0x0600224A RID: 8778 RVA: 0x00067D6D File Offset: 0x00065F6D
		public bool ListExplicitFormula
		{
			get
			{
				return this.opt_string_list_formula.IsSet(this._option_flags);
			}
			set
			{
				this._option_flags = this.opt_string_list_formula.SetBoolean(this._option_flags, value);
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x00067D87 File Offset: 0x00065F87
		// (set) Token: 0x0600224C RID: 8780 RVA: 0x00067D9A File Offset: 0x00065F9A
		public bool EmptyCellAllowed
		{
			get
			{
				return this.opt_empty_cell_allowed.IsSet(this._option_flags);
			}
			set
			{
				this._option_flags = this.opt_empty_cell_allowed.SetBoolean(this._option_flags, value);
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x00067DB4 File Offset: 0x00065FB4
		public bool SuppressDropdownArrow
		{
			get
			{
				return this.opt_suppress_dropdown_arrow.IsSet(this._option_flags);
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x00067DC7 File Offset: 0x00065FC7
		public bool ShowPromptOnCellSelected
		{
			get
			{
				return this.opt_show_prompt_on_cell_selected.IsSet(this._option_flags);
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x00067DDA File Offset: 0x00065FDA
		// (set) Token: 0x06002250 RID: 8784 RVA: 0x00067DED File Offset: 0x00065FED
		public bool ShowErrorOnInvalidValue
		{
			get
			{
				return this.opt_show_error_on_invalid_value.IsSet(this._option_flags);
			}
			set
			{
				this._option_flags = this.opt_show_error_on_invalid_value.SetBoolean(this._option_flags, value);
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x00067E07 File Offset: 0x00066007
		// (set) Token: 0x06002252 RID: 8786 RVA: 0x00067E1A File Offset: 0x0006601A
		public int ConditionOperator
		{
			get
			{
				return this.opt_condition_operator.GetValue(this._option_flags);
			}
			set
			{
				this._option_flags = this.opt_condition_operator.SetValue(this._option_flags, value);
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06002253 RID: 8787 RVA: 0x00067E34 File Offset: 0x00066034
		public string PromptTitle
		{
			get
			{
				return global::NPOI.HSSF.Record.DVRecord.ResolveTitleString(this._promptTitle);
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x00067E41 File Offset: 0x00066041
		public string ErrorTitle
		{
			get
			{
				return global::NPOI.HSSF.Record.DVRecord.ResolveTitleString(this._errorTitle);
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06002255 RID: 8789 RVA: 0x00067E4E File Offset: 0x0006604E
		public string PromptText
		{
			get
			{
				return global::NPOI.HSSF.Record.DVRecord.ResolveTitleString(this._promptText);
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x00067E5B File Offset: 0x0006605B
		public string ErrorText
		{
			get
			{
				return global::NPOI.HSSF.Record.DVRecord.ResolveTitleString(this._errorText);
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06002257 RID: 8791 RVA: 0x00067E68 File Offset: 0x00066068
		public global::NPOI.SS.Formula.PTG.Ptg[] Formula1
		{
			get
			{
				return global::NPOI.SS.Formula.Formula.GetTokens(this._formula1);
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06002258 RID: 8792 RVA: 0x00067E75 File Offset: 0x00066075
		public global::NPOI.SS.Formula.PTG.Ptg[] Formula2
		{
			get
			{
				return global::NPOI.SS.Formula.Formula.GetTokens(this._formula2);
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x00067E82 File Offset: 0x00066082
		// (set) Token: 0x0600225A RID: 8794 RVA: 0x00067E8A File Offset: 0x0006608A
		public global::NPOI.SS.Util.CellRangeAddressList CellRangeAddress
		{
			get
			{
				return this._regions;
			}
			set
			{
				this._regions = value;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x00067E93 File Offset: 0x00066093
		public int OptionFlags
		{
			get
			{
				return this._option_flags;
			}
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00067E9B File Offset: 0x0006609B
		public override string ToString()
		{
			return new global::System.Text.StringBuilder().ToString();
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x00067EA8 File Offset: 0x000660A8
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this._option_flags);
			global::NPOI.HSSF.Record.DVRecord.SerializeUnicodeString(this._promptTitle, out1);
			global::NPOI.HSSF.Record.DVRecord.SerializeUnicodeString(this._errorTitle, out1);
			global::NPOI.HSSF.Record.DVRecord.SerializeUnicodeString(this._promptText, out1);
			global::NPOI.HSSF.Record.DVRecord.SerializeUnicodeString(this._errorText, out1);
			out1.WriteShort(this._formula1.EncodedTokenSize);
			out1.WriteShort((int)this._not_used_1);
			this._formula1.SerializeTokens(out1);
			out1.WriteShort(this._formula2.EncodedTokenSize);
			out1.WriteShort((int)this._not_used_2);
			this._formula2.SerializeTokens(out1);
			this._regions.Serialize(out1);
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x00067F4F File Offset: 0x0006614F
		private static void SerializeUnicodeString(global::NPOI.HSSF.Record.UnicodeString us, global::NPOI.Util.ILittleEndianOutput out1)
		{
			global::NPOI.Util.StringUtil.WriteUnicodeString(out1, us.String);
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x00067F60 File Offset: 0x00066160
		private static int GetUnicodeStringSize(global::NPOI.HSSF.Record.UnicodeString us)
		{
			string @string = us.String;
			return 3 + @string.Length * (global::NPOI.Util.StringUtil.HasMultibyte(@string) ? 2 : 1);
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x00067F8C File Offset: 0x0006618C
		protected override int DataSize
		{
			get
			{
				return 12 + global::NPOI.HSSF.Record.DVRecord.GetUnicodeStringSize(this._promptTitle) + global::NPOI.HSSF.Record.DVRecord.GetUnicodeStringSize(this._errorTitle) + global::NPOI.HSSF.Record.DVRecord.GetUnicodeStringSize(this._promptText) + global::NPOI.HSSF.Record.DVRecord.GetUnicodeStringSize(this._errorText) + this._formula1.EncodedTokenSize + this._formula2.EncodedTokenSize + this._regions.Size;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06002261 RID: 8801 RVA: 0x00067FEF File Offset: 0x000661EF
		public override short Sid
		{
			get
			{
				return 446;
			}
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x00062BA1 File Offset: 0x00060DA1
		public override object Clone()
		{
			return base.CloneViaReserialise();
		}

		// Token: 0x04000D6A RID: 3434
		private static readonly global::NPOI.HSSF.Record.UnicodeString NULL_TEXT_STRING = new global::NPOI.HSSF.Record.UnicodeString("\0");

		// Token: 0x04000D6B RID: 3435
		public const short sid = 446;

		// Token: 0x04000D6C RID: 3436
		private int _option_flags;

		// Token: 0x04000D6D RID: 3437
		private global::NPOI.HSSF.Record.UnicodeString _promptTitle;

		// Token: 0x04000D6E RID: 3438
		private global::NPOI.HSSF.Record.UnicodeString _errorTitle;

		// Token: 0x04000D6F RID: 3439
		private global::NPOI.HSSF.Record.UnicodeString _promptText;

		// Token: 0x04000D70 RID: 3440
		private global::NPOI.HSSF.Record.UnicodeString _errorText;

		// Token: 0x04000D71 RID: 3441
		private short _not_used_1 = 16352;

		// Token: 0x04000D72 RID: 3442
		private global::NPOI.SS.Formula.Formula _formula1;

		// Token: 0x04000D73 RID: 3443
		private short _not_used_2;

		// Token: 0x04000D74 RID: 3444
		private global::NPOI.SS.Formula.Formula _formula2;

		// Token: 0x04000D75 RID: 3445
		private global::NPOI.SS.Util.CellRangeAddressList _regions;

		// Token: 0x04000D76 RID: 3446
		public const int STRING_PROMPT_TITLE = 0;

		// Token: 0x04000D77 RID: 3447
		public const int STRING_ERROR_TITLE = 1;

		// Token: 0x04000D78 RID: 3448
		public const int STRING_PROMPT_TEXT = 2;

		// Token: 0x04000D79 RID: 3449
		public const int STRING_ERROR_TEXT = 3;

		// Token: 0x04000D7A RID: 3450
		private global::NPOI.Util.BitField opt_data_type = new global::NPOI.Util.BitField(15);

		// Token: 0x04000D7B RID: 3451
		private global::NPOI.Util.BitField opt_error_style = new global::NPOI.Util.BitField(112);

		// Token: 0x04000D7C RID: 3452
		private global::NPOI.Util.BitField opt_string_list_formula = new global::NPOI.Util.BitField(128);

		// Token: 0x04000D7D RID: 3453
		private global::NPOI.Util.BitField opt_empty_cell_allowed = new global::NPOI.Util.BitField(256);

		// Token: 0x04000D7E RID: 3454
		private global::NPOI.Util.BitField opt_suppress_dropdown_arrow = new global::NPOI.Util.BitField(512);

		// Token: 0x04000D7F RID: 3455
		private global::NPOI.Util.BitField opt_show_prompt_on_cell_selected = new global::NPOI.Util.BitField(262144);

		// Token: 0x04000D80 RID: 3456
		private global::NPOI.Util.BitField opt_show_error_on_invalid_value = new global::NPOI.Util.BitField(524288);

		// Token: 0x04000D81 RID: 3457
		private global::NPOI.Util.BitField opt_condition_operator = new global::NPOI.Util.BitField(15728640);
	}
}
