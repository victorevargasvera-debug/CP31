using System;
using System.Text;
using NPOI.HSSF.UserModel;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003B6 RID: 950
	public class CFRuleRecord : global::NPOI.HSSF.Record.CFRuleBase, global::System.ICloneable
	{
		// Token: 0x060020F3 RID: 8435 RVA: 0x00064977 File Offset: 0x00062B77
		private CFRuleRecord(byte conditionType, byte comparisonOperation) : base(conditionType, comparisonOperation)
		{
			this.SetDefaults();
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00064987 File Offset: 0x00062B87
		private CFRuleRecord(byte conditionType, byte comparisonOperation, global::NPOI.SS.Formula.PTG.Ptg[] formula1, global::NPOI.SS.Formula.PTG.Ptg[] formula2) : base(conditionType, comparisonOperation, formula1, formula2)
		{
			this.SetDefaults();
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x0006499C File Offset: 0x00062B9C
		private void SetDefaults()
		{
			this.formatting_options = global::NPOI.HSSF.Record.CFRuleBase.modificationBits.SetValue(this.formatting_options, -1);
			this.formatting_options = global::NPOI.HSSF.Record.CFRuleBase.fmtBlockBits.SetValue(this.formatting_options, 0);
			this.formatting_options = global::NPOI.HSSF.Record.CFRuleBase.undocumented.Clear(this.formatting_options);
			this.formatting_not_used = -32766;
			this._fontFormatting = null;
			this._borderFormatting = null;
			this._patternFormatting = null;
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00064A10 File Offset: 0x00062C10
		public static global::NPOI.HSSF.Record.CFRuleRecord Create(global::NPOI.HSSF.UserModel.HSSFSheet sheet, string formulaText)
		{
			global::NPOI.SS.Formula.PTG.Ptg[] formula = global::NPOI.HSSF.Record.CFRuleBase.ParseFormula(formulaText, sheet);
			return new global::NPOI.HSSF.Record.CFRuleRecord(2, global::NPOI.HSSF.Record.CFRuleBase.ComparisonOperator.NO_COMPARISON, formula, null);
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x00064A34 File Offset: 0x00062C34
		public static global::NPOI.HSSF.Record.CFRuleRecord Create(global::NPOI.HSSF.UserModel.HSSFSheet sheet, byte comparisonOperation, string formulaText1, string formulaText2)
		{
			global::NPOI.SS.Formula.PTG.Ptg[] formula = global::NPOI.HSSF.Record.CFRuleBase.ParseFormula(formulaText1, sheet);
			global::NPOI.SS.Formula.PTG.Ptg[] formula2 = global::NPOI.HSSF.Record.CFRuleBase.ParseFormula(formulaText2, sheet);
			return new global::NPOI.HSSF.Record.CFRuleRecord(1, comparisonOperation, formula, formula2);
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00064A5C File Offset: 0x00062C5C
		public CFRuleRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			base.ConditionType = (byte)in1.ReadByte();
			base.ComparisonOperation = (byte)in1.ReadByte();
			int encodedTokenLen = in1.ReadUShort();
			int encodedTokenLen2 = in1.ReadUShort();
			base.ReadFormatOptions(in1);
			base.Formula1 = global::NPOI.SS.Formula.Formula.Read(encodedTokenLen, in1);
			base.Formula2 = global::NPOI.SS.Formula.Formula.Read(encodedTokenLen2, in1);
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x00064AB9 File Offset: 0x00062CB9
		public override short Sid
		{
			get
			{
				return global::NPOI.HSSF.Record.CFRuleRecord.sid;
			}
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x00064AC0 File Offset: 0x00062CC0
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			int formulaSize = global::NPOI.HSSF.Record.CFRuleBase.GetFormulaSize(base.Formula1);
			int formulaSize2 = global::NPOI.HSSF.Record.CFRuleBase.GetFormulaSize(base.Formula2);
			out1.WriteByte((int)base.ConditionType);
			out1.WriteByte((int)base.ComparisonOperation);
			out1.WriteShort(formulaSize);
			out1.WriteShort(formulaSize2);
			base.SerializeFormattingBlock(out1);
			base.Formula1.SerializeTokens(out1);
			base.Formula2.SerializeTokens(out1);
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x00064B2A File Offset: 0x00062D2A
		protected override int DataSize
		{
			get
			{
				return 6 + base.FormattingBlockSize + global::NPOI.HSSF.Record.CFRuleBase.GetFormulaSize(base.Formula1) + global::NPOI.HSSF.Record.CFRuleBase.GetFormulaSize(base.Formula2);
			}
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00064B4C File Offset: 0x00062D4C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[CFRULE]\n");
			stringBuilder.Append("    .condition_type   =").Append(base.ConditionType).Append("\n");
			stringBuilder.Append("    OPTION FLAGS=0x").Append(global::NPOI.Util.HexDump.ToHex(base.Options)).Append("\n");
			if (base.ContainsFontFormattingBlock)
			{
				stringBuilder.Append(this._fontFormatting.ToString()).Append("\n");
			}
			if (base.ContainsBorderFormattingBlock)
			{
				stringBuilder.Append(this._borderFormatting.ToString()).Append("\n");
			}
			if (base.ContainsPatternFormattingBlock)
			{
				stringBuilder.Append(this._patternFormatting.ToString()).Append("\n");
			}
			global::System.Text.StringBuilder stringBuilder2 = stringBuilder.Append("    Formula 1 =");
			object[] tokens = base.Formula1.Tokens;
			stringBuilder2.Append(global::NPOI.Util.Arrays.ToString(tokens)).Append("\n");
			global::System.Text.StringBuilder stringBuilder3 = stringBuilder.Append("    Formula 2 =");
			tokens = base.Formula2.Tokens;
			stringBuilder3.Append(global::NPOI.Util.Arrays.ToString(tokens)).Append("\n");
			stringBuilder.Append("[/CFRULE]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x00064C8C File Offset: 0x00062E8C
		public override object Clone()
		{
			global::NPOI.HSSF.Record.CFRuleRecord cfruleRecord = new global::NPOI.HSSF.Record.CFRuleRecord(base.ConditionType, base.ComparisonOperation);
			base.CopyTo(cfruleRecord);
			return cfruleRecord;
		}

		// Token: 0x04000CD2 RID: 3282
		public static short sid = 433;
	}
}
