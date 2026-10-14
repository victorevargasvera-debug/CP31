using System;
using System.Text;
using NPOI.HSSF.Record.CF;
using NPOI.HSSF.Record.Common;
using NPOI.HSSF.UserModel;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000395 RID: 917
	public class CFRule12Record : global::NPOI.HSSF.Record.CFRuleBase, global::NPOI.HSSF.Record.Common.IFutureRecord, global::System.ICloneable
	{
		// Token: 0x06001F48 RID: 8008 RVA: 0x0006016B File Offset: 0x0005E36B
		private CFRule12Record(byte conditionType, byte comparisonOperation) : base(conditionType, comparisonOperation)
		{
			this.SetDefaults();
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x0006017B File Offset: 0x0005E37B
		private CFRule12Record(byte conditionType, byte comparisonOperation, global::NPOI.SS.Formula.PTG.Ptg[] formula1, global::NPOI.SS.Formula.PTG.Ptg[] formula2, global::NPOI.SS.Formula.PTG.Ptg[] formulaScale) : base(conditionType, comparisonOperation, formula1, formula2)
		{
			this.SetDefaults();
			this.formula_scale = global::NPOI.SS.Formula.Formula.Create(formulaScale);
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x0006019C File Offset: 0x0005E39C
		private void SetDefaults()
		{
			this.futureHeader = new global::NPOI.HSSF.Record.Common.FtrHeader();
			this.futureHeader.RecordType = global::NPOI.HSSF.Record.CFRule12Record.sid;
			this.ext_formatting_length = 0;
			this.ext_formatting_data = new byte[4];
			this.formula_scale = global::NPOI.SS.Formula.Formula.Create(global::NPOI.SS.Formula.PTG.Ptg.EMPTY_PTG_ARRAY);
			this.ext_opts = 0;
			this.priority = 0;
			this.template_type = (int)base.ConditionType;
			this.template_param_length = 16;
			this.template_params = new byte[(int)this.template_param_length];
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x0006021C File Offset: 0x0005E41C
		public static global::NPOI.HSSF.Record.CFRule12Record Create(global::NPOI.HSSF.UserModel.HSSFSheet sheet, string formulaText)
		{
			global::NPOI.SS.Formula.PTG.Ptg[] formula = global::NPOI.HSSF.Record.CFRuleBase.ParseFormula(formulaText, sheet);
			return new global::NPOI.HSSF.Record.CFRule12Record(2, global::NPOI.HSSF.Record.CFRuleBase.ComparisonOperator.NO_COMPARISON, formula, null, null);
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x00060240 File Offset: 0x0005E440
		public static global::NPOI.HSSF.Record.CFRule12Record Create(global::NPOI.HSSF.UserModel.HSSFSheet sheet, byte comparisonOperation, string formulaText1, string formulaText2)
		{
			global::NPOI.SS.Formula.PTG.Ptg[] formula = global::NPOI.HSSF.Record.CFRuleBase.ParseFormula(formulaText1, sheet);
			global::NPOI.SS.Formula.PTG.Ptg[] formula2 = global::NPOI.HSSF.Record.CFRuleBase.ParseFormula(formulaText2, sheet);
			return new global::NPOI.HSSF.Record.CFRule12Record(1, comparisonOperation, formula, formula2, null);
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x00060268 File Offset: 0x0005E468
		public static global::NPOI.HSSF.Record.CFRule12Record Create(global::NPOI.HSSF.UserModel.HSSFSheet sheet, byte comparisonOperation, string formulaText1, string formulaText2, string formulaTextScale)
		{
			global::NPOI.SS.Formula.PTG.Ptg[] formula = global::NPOI.HSSF.Record.CFRuleBase.ParseFormula(formulaText1, sheet);
			global::NPOI.SS.Formula.PTG.Ptg[] formula2 = global::NPOI.HSSF.Record.CFRuleBase.ParseFormula(formulaText2, sheet);
			global::NPOI.SS.Formula.PTG.Ptg[] formulaScale = global::NPOI.HSSF.Record.CFRuleBase.ParseFormula(formulaTextScale, sheet);
			return new global::NPOI.HSSF.Record.CFRule12Record(1, comparisonOperation, formula, formula2, formulaScale);
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x00060298 File Offset: 0x0005E498
		public static global::NPOI.HSSF.Record.CFRule12Record Create(global::NPOI.HSSF.UserModel.HSSFSheet sheet, global::NPOI.HSSF.Record.Common.ExtendedColor color)
		{
			global::NPOI.HSSF.Record.CFRule12Record cfrule12Record = new global::NPOI.HSSF.Record.CFRule12Record(4, global::NPOI.HSSF.Record.CFRuleBase.ComparisonOperator.NO_COMPARISON);
			global::NPOI.HSSF.Record.CF.DataBarFormatting dataBarFormatting = cfrule12Record.CreateDataBarFormatting();
			dataBarFormatting.Color = color;
			dataBarFormatting.PercentMin = 0;
			dataBarFormatting.PercentMax = 100;
			global::NPOI.HSSF.Record.CF.DataBarThreshold dataBarThreshold = new global::NPOI.HSSF.Record.CF.DataBarThreshold();
			dataBarThreshold.SetType(global::NPOI.SS.UserModel.RangeType.MIN.id);
			dataBarFormatting.ThresholdMin = dataBarThreshold;
			global::NPOI.HSSF.Record.CF.DataBarThreshold dataBarThreshold2 = new global::NPOI.HSSF.Record.CF.DataBarThreshold();
			dataBarThreshold2.SetType(global::NPOI.SS.UserModel.RangeType.MAX.id);
			dataBarFormatting.ThresholdMax = dataBarThreshold2;
			return cfrule12Record;
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00060308 File Offset: 0x0005E508
		public static global::NPOI.HSSF.Record.CFRule12Record Create(global::NPOI.HSSF.UserModel.HSSFSheet sheet, global::NPOI.SS.UserModel.IconSet iconSet)
		{
			global::NPOI.HSSF.Record.CF.Threshold[] array = new global::NPOI.HSSF.Record.CF.Threshold[iconSet.num];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new global::NPOI.HSSF.Record.CF.IconMultiStateThreshold();
			}
			global::NPOI.HSSF.Record.CFRule12Record cfrule12Record = new global::NPOI.HSSF.Record.CFRule12Record(6, global::NPOI.HSSF.Record.CFRuleBase.ComparisonOperator.NO_COMPARISON);
			global::NPOI.HSSF.Record.CF.IconMultiStateFormatting iconMultiStateFormatting = cfrule12Record.CreateMultiStateFormatting();
			iconMultiStateFormatting.IconSet = iconSet;
			iconMultiStateFormatting.Thresholds = array;
			return cfrule12Record;
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x00060358 File Offset: 0x0005E558
		public static global::NPOI.HSSF.Record.CFRule12Record CreateColorScale(global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			int num = 3;
			global::NPOI.HSSF.Record.Common.ExtendedColor[] array = new global::NPOI.HSSF.Record.Common.ExtendedColor[num];
			global::NPOI.HSSF.Record.CF.ColorGradientThreshold[] array2 = new global::NPOI.HSSF.Record.CF.ColorGradientThreshold[num];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = new global::NPOI.HSSF.Record.CF.ColorGradientThreshold();
				array[i] = new global::NPOI.HSSF.Record.Common.ExtendedColor();
			}
			global::NPOI.HSSF.Record.CFRule12Record cfrule12Record = new global::NPOI.HSSF.Record.CFRule12Record(3, global::NPOI.HSSF.Record.CFRuleBase.ComparisonOperator.NO_COMPARISON);
			global::NPOI.HSSF.Record.CF.ColorGradientFormatting colorGradientFormatting = cfrule12Record.CreateColorGradientFormatting();
			colorGradientFormatting.NumControlPoints = num;
			colorGradientFormatting.Thresholds = array2;
			colorGradientFormatting.Colors = array;
			return cfrule12Record;
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x000603B8 File Offset: 0x0005E5B8
		public CFRule12Record(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.futureHeader = new global::NPOI.HSSF.Record.Common.FtrHeader(in1);
			base.ConditionType = (byte)in1.ReadByte();
			base.ComparisonOperation = (byte)in1.ReadByte();
			int encodedTokenLen = in1.ReadUShort();
			int encodedTokenLen2 = in1.ReadUShort();
			this.ext_formatting_length = in1.ReadInt();
			this.ext_formatting_data = new byte[0];
			if (this.ext_formatting_length == 0)
			{
				in1.ReadUShort();
			}
			else
			{
				int num = base.ReadFormatOptions(in1);
				if (num < this.ext_formatting_length)
				{
					this.ext_formatting_data = new byte[this.ext_formatting_length - num];
					in1.ReadFully(this.ext_formatting_data);
				}
			}
			base.Formula1 = global::NPOI.SS.Formula.Formula.Read(encodedTokenLen, in1);
			base.Formula2 = global::NPOI.SS.Formula.Formula.Read(encodedTokenLen2, in1);
			int encodedTokenLen3 = in1.ReadUShort();
			this.formula_scale = global::NPOI.SS.Formula.Formula.Read(encodedTokenLen3, in1);
			this.ext_opts = (byte)in1.ReadByte();
			this.priority = in1.ReadUShort();
			this.template_type = in1.ReadUShort();
			this.template_param_length = (byte)in1.ReadByte();
			if (this.template_param_length == 0 || this.template_param_length == 16)
			{
				this.template_params = new byte[(int)this.template_param_length];
				in1.ReadFully(this.template_params);
			}
			else
			{
				in1.ReadRemainder();
			}
			byte conditionType = base.ConditionType;
			if (conditionType == 3)
			{
				this.color_gradient = new global::NPOI.HSSF.Record.CF.ColorGradientFormatting(in1);
				return;
			}
			if (conditionType == 4)
			{
				this.data_bar = new global::NPOI.HSSF.Record.CF.DataBarFormatting(in1);
				return;
			}
			if (conditionType == 5)
			{
				this.filter_data = in1.ReadRemainder();
				return;
			}
			if (conditionType == 6)
			{
				this.multistate = new global::NPOI.HSSF.Record.CF.IconMultiStateFormatting(in1);
			}
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x0006053D File Offset: 0x0005E73D
		public bool ContainsDataBarBlock()
		{
			return this.data_bar != null;
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x00060548 File Offset: 0x0005E748
		public global::NPOI.HSSF.Record.CF.DataBarFormatting DataBarFormatting
		{
			get
			{
				return this.data_bar;
			}
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00060550 File Offset: 0x0005E750
		public global::NPOI.HSSF.Record.CF.DataBarFormatting CreateDataBarFormatting()
		{
			if (this.data_bar != null)
			{
				return this.data_bar;
			}
			base.ConditionType = 4;
			this.data_bar = new global::NPOI.HSSF.Record.CF.DataBarFormatting();
			return this.data_bar;
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00060579 File Offset: 0x0005E779
		public bool ContainsMultiStateBlock()
		{
			return this.multistate != null;
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x00060584 File Offset: 0x0005E784
		public global::NPOI.HSSF.Record.CF.IconMultiStateFormatting MultiStateFormatting
		{
			get
			{
				return this.multistate;
			}
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x0006058C File Offset: 0x0005E78C
		public global::NPOI.HSSF.Record.CF.IconMultiStateFormatting CreateMultiStateFormatting()
		{
			if (this.multistate != null)
			{
				return this.multistate;
			}
			base.ConditionType = 6;
			this.multistate = new global::NPOI.HSSF.Record.CF.IconMultiStateFormatting();
			return this.multistate;
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x000605B5 File Offset: 0x0005E7B5
		public bool ContainsColorGradientBlock()
		{
			return this.color_gradient != null;
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x000605C0 File Offset: 0x0005E7C0
		public global::NPOI.HSSF.Record.CF.ColorGradientFormatting ColorGradientFormatting
		{
			get
			{
				return this.color_gradient;
			}
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x000605C8 File Offset: 0x0005E7C8
		public global::NPOI.HSSF.Record.CF.ColorGradientFormatting CreateColorGradientFormatting()
		{
			if (this.color_gradient != null)
			{
				return this.color_gradient;
			}
			base.ConditionType = 3;
			this.color_gradient = new global::NPOI.HSSF.Record.CF.ColorGradientFormatting();
			return this.color_gradient;
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x000605F1 File Offset: 0x0005E7F1
		// (set) Token: 0x06001F5C RID: 8028 RVA: 0x000605FE File Offset: 0x0005E7FE
		public global::NPOI.SS.Formula.PTG.Ptg[] ParsedExpressionScale
		{
			get
			{
				return this.formula_scale.Tokens;
			}
			set
			{
				this.formula_scale = global::NPOI.SS.Formula.Formula.Create(value);
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001F5D RID: 8029 RVA: 0x0006060C File Offset: 0x0005E80C
		public override short Sid
		{
			get
			{
				return global::NPOI.HSSF.Record.CFRule12Record.sid;
			}
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x00060614 File Offset: 0x0005E814
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			this.futureHeader.Serialize(out1);
			int formulaSize = global::NPOI.HSSF.Record.CFRuleBase.GetFormulaSize(base.Formula1);
			int formulaSize2 = global::NPOI.HSSF.Record.CFRuleBase.GetFormulaSize(base.Formula2);
			out1.WriteByte((int)base.ConditionType);
			out1.WriteByte((int)base.ComparisonOperation);
			out1.WriteShort(formulaSize);
			out1.WriteShort(formulaSize2);
			if (this.ext_formatting_length == 0)
			{
				out1.WriteInt(0);
				out1.WriteShort(0);
			}
			else
			{
				out1.WriteInt(this.ext_formatting_length);
				base.SerializeFormattingBlock(out1);
				out1.Write(this.ext_formatting_data);
			}
			base.Formula1.SerializeTokens(out1);
			base.Formula2.SerializeTokens(out1);
			out1.WriteShort(global::NPOI.HSSF.Record.CFRuleBase.GetFormulaSize(this.formula_scale));
			this.formula_scale.SerializeTokens(out1);
			out1.WriteByte((int)this.ext_opts);
			out1.WriteShort(this.priority);
			out1.WriteShort(this.template_type);
			out1.WriteByte((int)this.template_param_length);
			out1.Write(this.template_params);
			byte conditionType = base.ConditionType;
			if (conditionType == 3)
			{
				this.color_gradient.Serialize(out1);
				return;
			}
			if (conditionType == 4)
			{
				this.data_bar.Serialize(out1);
				return;
			}
			if (conditionType == 5)
			{
				out1.Write(this.filter_data);
				return;
			}
			if (conditionType == 6)
			{
				this.multistate.Serialize(out1);
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x00060760 File Offset: 0x0005E960
		protected override int DataSize
		{
			get
			{
				int num = global::NPOI.HSSF.Record.Common.FtrHeader.GetDataSize() + 6;
				if (this.ext_formatting_length == 0)
				{
					num += 6;
				}
				else
				{
					num += 4 + base.FormattingBlockSize + this.ext_formatting_data.Length;
				}
				num += global::NPOI.HSSF.Record.CFRuleBase.GetFormulaSize(base.Formula1);
				num += global::NPOI.HSSF.Record.CFRuleBase.GetFormulaSize(base.Formula2);
				num += 2 + global::NPOI.HSSF.Record.CFRuleBase.GetFormulaSize(this.formula_scale);
				num += 6 + this.template_params.Length;
				byte conditionType = base.ConditionType;
				if (conditionType == 3)
				{
					num += this.color_gradient.DataLength;
				}
				else if (conditionType == 4)
				{
					num += this.data_bar.DataLength;
				}
				else if (conditionType == 5)
				{
					num += this.filter_data.Length;
				}
				else if (conditionType == 6)
				{
					num += this.multistate.DataLength;
				}
				return num;
			}
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x00060824 File Offset: 0x0005EA24
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[CFRULE12]\n");
			stringBuilder.Append("    .condition_type=").Append(base.ConditionType).Append("\n");
			stringBuilder.Append("    .dxfn12_length =0x").Append(global::NPOI.Util.HexDump.ToHex(this.ext_formatting_length)).Append("\n");
			stringBuilder.Append("    .option_flags  =0x").Append(global::NPOI.Util.HexDump.ToHex(base.Options)).Append("\n");
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
			stringBuilder.Append("    .dxfn12_ext=").Append(global::NPOI.Util.HexDump.ToHex(this.ext_formatting_data)).Append("\n");
			global::System.Text.StringBuilder stringBuilder2 = stringBuilder.Append("    .Formula_1 =");
			object[] tokens = base.Formula1.Tokens;
			stringBuilder2.Append(global::NPOI.Util.Arrays.ToString(tokens)).Append("\n");
			global::System.Text.StringBuilder stringBuilder3 = stringBuilder.Append("    .Formula_2 =");
			tokens = base.Formula2.Tokens;
			stringBuilder3.Append(global::NPOI.Util.Arrays.ToString(tokens)).Append("\n");
			global::System.Text.StringBuilder stringBuilder4 = stringBuilder.Append("    .Formula_S =");
			tokens = this.formula_scale.Tokens;
			stringBuilder4.Append(global::NPOI.Util.Arrays.ToString(tokens)).Append("\n");
			stringBuilder.Append("    .ext_opts  =").Append(this.ext_opts).Append("\n");
			stringBuilder.Append("    .priority  =").Append(this.priority).Append("\n");
			stringBuilder.Append("    .template_type  =").Append(this.template_type).Append("\n");
			stringBuilder.Append("    .template_params=").Append(global::NPOI.Util.HexDump.ToHex(this.template_params)).Append("\n");
			stringBuilder.Append("    .filter_data    =").Append(global::NPOI.Util.HexDump.ToHex(this.filter_data)).Append("\n");
			if (this.color_gradient != null)
			{
				stringBuilder.Append(this.color_gradient);
			}
			if (this.multistate != null)
			{
				stringBuilder.Append(this.multistate);
			}
			if (this.data_bar != null)
			{
				stringBuilder.Append(this.data_bar);
			}
			stringBuilder.Append("[/CFRULE12]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x00060ACC File Offset: 0x0005ECCC
		public override object Clone()
		{
			global::NPOI.HSSF.Record.CFRule12Record cfrule12Record = new global::NPOI.HSSF.Record.CFRule12Record(base.ConditionType, base.ComparisonOperation);
			cfrule12Record.futureHeader.AssociatedRange = this.futureHeader.AssociatedRange.Copy();
			base.CopyTo(cfrule12Record);
			cfrule12Record.ext_formatting_length = this.ext_formatting_length;
			cfrule12Record.ext_formatting_data = new byte[this.ext_formatting_length];
			global::System.Array.Copy(this.ext_formatting_data, 0, cfrule12Record.ext_formatting_data, 0, this.ext_formatting_length);
			cfrule12Record.formula_scale = this.formula_scale.Copy();
			cfrule12Record.ext_opts = this.ext_opts;
			cfrule12Record.priority = this.priority;
			cfrule12Record.template_type = this.template_type;
			cfrule12Record.template_param_length = this.template_param_length;
			cfrule12Record.template_params = new byte[(int)this.template_param_length];
			global::System.Array.Copy(this.template_params, 0, cfrule12Record.template_params, 0, (int)this.template_param_length);
			if (this.color_gradient != null)
			{
				cfrule12Record.color_gradient = (global::NPOI.HSSF.Record.CF.ColorGradientFormatting)this.color_gradient.Clone();
			}
			if (this.multistate != null)
			{
				cfrule12Record.multistate = (global::NPOI.HSSF.Record.CF.IconMultiStateFormatting)this.multistate.Clone();
			}
			if (this.data_bar != null)
			{
				cfrule12Record.data_bar = (global::NPOI.HSSF.Record.CF.DataBarFormatting)this.data_bar.Clone();
			}
			if (this.filter_data != null)
			{
				cfrule12Record.filter_data = new byte[this.filter_data.Length];
				global::System.Array.Copy(this.filter_data, 0, cfrule12Record.filter_data, 0, this.filter_data.Length);
			}
			return cfrule12Record;
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x00060C3F File Offset: 0x0005EE3F
		public short GetFutureRecordType()
		{
			return this.futureHeader.RecordType;
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x00060C4C File Offset: 0x0005EE4C
		public global::NPOI.HSSF.Record.Common.FtrHeader GetFutureHeader()
		{
			return this.futureHeader;
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x00060C54 File Offset: 0x0005EE54
		public global::NPOI.SS.Util.CellRangeAddress GetAssociatedRange()
		{
			return this.futureHeader.AssociatedRange;
		}

		// Token: 0x04000BD3 RID: 3027
		public static short sid = 2170;

		// Token: 0x04000BD4 RID: 3028
		private global::NPOI.HSSF.Record.Common.FtrHeader futureHeader;

		// Token: 0x04000BD5 RID: 3029
		private int ext_formatting_length;

		// Token: 0x04000BD6 RID: 3030
		private byte[] ext_formatting_data;

		// Token: 0x04000BD7 RID: 3031
		private global::NPOI.SS.Formula.Formula formula_scale;

		// Token: 0x04000BD8 RID: 3032
		private byte ext_opts;

		// Token: 0x04000BD9 RID: 3033
		private int priority;

		// Token: 0x04000BDA RID: 3034
		private int template_type;

		// Token: 0x04000BDB RID: 3035
		private byte template_param_length;

		// Token: 0x04000BDC RID: 3036
		private byte[] template_params;

		// Token: 0x04000BDD RID: 3037
		private global::NPOI.HSSF.Record.CF.DataBarFormatting data_bar;

		// Token: 0x04000BDE RID: 3038
		private global::NPOI.HSSF.Record.CF.IconMultiStateFormatting multistate;

		// Token: 0x04000BDF RID: 3039
		private global::NPOI.HSSF.Record.CF.ColorGradientFormatting color_gradient;

		// Token: 0x04000BE0 RID: 3040
		private byte[] filter_data;
	}
}
