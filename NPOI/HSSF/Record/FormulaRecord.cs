using System;
using System.Text;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003E2 RID: 994
	[global::System.Serializable]
	public class FormulaRecord : global::NPOI.HSSF.Record.CellRecord, global::System.ICloneable
	{
		// Token: 0x060023A9 RID: 9129 RVA: 0x0006BB48 File Offset: 0x00069D48
		public FormulaRecord()
		{
			this.field_8_parsed_expr = global::NPOI.SS.Formula.Formula.Create(global::NPOI.SS.Formula.PTG.Ptg.EMPTY_PTG_ARRAY);
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x0006BB84 File Offset: 0x00069D84
		public FormulaRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : base(in1)
		{
			long num = in1.ReadLong();
			this.field_5_options = in1.ReadShort();
			this.specialCachedValue = global::NPOI.HSSF.Record.SpecialCachedValue.Create(num);
			if (this.specialCachedValue == null)
			{
				this.field_4_value = global::System.BitConverter.Int64BitsToDouble(num);
			}
			this.field_6_zero = in1.ReadInt();
			int encodedTokenLen = (int)in1.ReadShort();
			this.field_8_parsed_expr = global::NPOI.SS.Formula.Formula.Read(encodedTokenLen, in1, in1.Available());
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060023AB RID: 9131 RVA: 0x0006BC15 File Offset: 0x00069E15
		public bool HasCachedResultString
		{
			get
			{
				return this.specialCachedValue != null && this.specialCachedValue.GetTypeCode() == 0;
			}
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x0006BC2F File Offset: 0x00069E2F
		public void SetParsedExpression(global::NPOI.SS.Formula.PTG.Ptg[] ptgs)
		{
			this.field_8_parsed_expr = global::NPOI.SS.Formula.Formula.Create(ptgs);
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x0006BC3D File Offset: 0x00069E3D
		public void SetSharedFormula(bool flag)
		{
			this.field_5_options = this.sharedFormula.SetShortBoolean(this.field_5_options, flag);
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x0006BC57 File Offset: 0x00069E57
		// (set) Token: 0x060023AF RID: 9135 RVA: 0x0006BC5F File Offset: 0x00069E5F
		public double Value
		{
			get
			{
				return this.field_4_value;
			}
			set
			{
				this.field_4_value = value;
				this.specialCachedValue = null;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x0006BC6F File Offset: 0x00069E6F
		// (set) Token: 0x060023B1 RID: 9137 RVA: 0x0006BC77 File Offset: 0x00069E77
		public short Options
		{
			get
			{
				return this.field_5_options;
			}
			set
			{
				this.field_5_options = value;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x0006BC80 File Offset: 0x00069E80
		// (set) Token: 0x060023B3 RID: 9139 RVA: 0x0006BC3D File Offset: 0x00069E3D
		public bool IsSharedFormula
		{
			get
			{
				return this.sharedFormula.IsSet((int)this.field_5_options);
			}
			set
			{
				this.field_5_options = this.sharedFormula.SetShortBoolean(this.field_5_options, value);
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x0006BC93 File Offset: 0x00069E93
		// (set) Token: 0x060023B5 RID: 9141 RVA: 0x0006BCA6 File Offset: 0x00069EA6
		public bool IsAlwaysCalc
		{
			get
			{
				return this.alwaysCalc.IsSet((int)this.field_5_options);
			}
			set
			{
				this.field_5_options = this.alwaysCalc.SetShortBoolean(this.field_5_options, value);
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x0006BCC0 File Offset: 0x00069EC0
		// (set) Token: 0x060023B7 RID: 9143 RVA: 0x0006BCD3 File Offset: 0x00069ED3
		public bool IsCalcOnLoad
		{
			get
			{
				return this.calcOnLoad.IsSet((int)this.field_5_options);
			}
			set
			{
				this.field_5_options = this.calcOnLoad.SetShortBoolean(this.field_5_options, value);
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x0006BCED File Offset: 0x00069EED
		// (set) Token: 0x060023B9 RID: 9145 RVA: 0x0006BC2F File Offset: 0x00069E2F
		public global::NPOI.SS.Formula.PTG.Ptg[] ParsedExpression
		{
			get
			{
				return this.field_8_parsed_expr.Tokens;
			}
			set
			{
				this.field_8_parsed_expr = global::NPOI.SS.Formula.Formula.Create(value);
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x0006BCFA File Offset: 0x00069EFA
		public global::NPOI.SS.Formula.Formula Formula
		{
			get
			{
				return this.field_8_parsed_expr;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x060023BB RID: 9147 RVA: 0x0006BD02 File Offset: 0x00069F02
		protected override string RecordName
		{
			get
			{
				return "FORMULA";
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x0006BD09 File Offset: 0x00069F09
		protected override int ValueDataSize
		{
			get
			{
				return 14 + this.field_8_parsed_expr.EncodedSize;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x00017F5F File Offset: 0x0001615F
		public override short Sid
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x0006BD19 File Offset: 0x00069F19
		public void SetCachedResultTypeEmptyString()
		{
			this.specialCachedValue = global::NPOI.HSSF.Record.SpecialCachedValue.CreateCachedEmptyValue();
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x0006BD26 File Offset: 0x00069F26
		public void SetCachedResultTypeString()
		{
			this.specialCachedValue = global::NPOI.HSSF.Record.SpecialCachedValue.CreateForString();
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x0006BD33 File Offset: 0x00069F33
		public void SetCachedResultErrorCode(int errorCode)
		{
			this.specialCachedValue = global::NPOI.HSSF.Record.SpecialCachedValue.CreateCachedErrorCode(errorCode);
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x0006BD41 File Offset: 0x00069F41
		public void SetCachedResultBoolean(bool value)
		{
			this.specialCachedValue = global::NPOI.HSSF.Record.SpecialCachedValue.CreateCachedBoolean(value);
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x060023C2 RID: 9154 RVA: 0x0006BD4F File Offset: 0x00069F4F
		public bool CachedBooleanValue
		{
			get
			{
				return this.specialCachedValue.GetBooleanValue();
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x060023C3 RID: 9155 RVA: 0x0006BD5C File Offset: 0x00069F5C
		public int CachedErrorValue
		{
			get
			{
				return this.specialCachedValue.GetErrorValue();
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x060023C4 RID: 9156 RVA: 0x0006BD69 File Offset: 0x00069F69
		public global::NPOI.SS.UserModel.CellType CachedResultType
		{
			get
			{
				if (this.specialCachedValue == null)
				{
					return global::NPOI.SS.UserModel.CellType.Numeric;
				}
				return this.specialCachedValue.GetValueType();
			}
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x0006BD80 File Offset: 0x00069F80
		public override bool Equals(object obj)
		{
			if (!(obj is global::NPOI.HSSF.Record.CellValueRecordInterface))
			{
				return false;
			}
			global::NPOI.HSSF.Record.CellValueRecordInterface cellValueRecordInterface = (global::NPOI.HSSF.Record.CellValueRecordInterface)obj;
			return base.Row == cellValueRecordInterface.Row && base.Column == cellValueRecordInterface.Column;
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x00064909 File Offset: 0x00062B09
		public override int GetHashCode()
		{
			return base.Row ^ base.Column;
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x0006BDC0 File Offset: 0x00069FC0
		protected override void SerializeValue(global::NPOI.Util.ILittleEndianOutput out1)
		{
			if (this.specialCachedValue == null)
			{
				out1.WriteDouble(this.field_4_value);
			}
			else
			{
				this.specialCachedValue.Serialize(out1);
			}
			out1.WriteShort((int)this.Options);
			out1.WriteInt(this.field_6_zero);
			this.field_8_parsed_expr.Serialize(out1);
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x0006BE14 File Offset: 0x0006A014
		protected override void AppendValueText(global::System.Text.StringBuilder buffer)
		{
			buffer.Append("    .value           = ");
			if (this.specialCachedValue == null)
			{
				buffer.Append(this.field_4_value).Append("\n");
			}
			else
			{
				buffer.Append(this.specialCachedValue.FormatDebugString).Append("\n");
			}
			buffer.Append("    .options         = ").Append(this.Options).Append("\n");
			buffer.Append("      .alwaysCalc         = ").Append(this.alwaysCalc.IsSet((int)this.Options)).Append("\n");
			buffer.Append("      .CalcOnLoad         = ").Append(this.calcOnLoad.IsSet((int)this.Options)).Append("\n");
			buffer.Append("      .sharedFormula         = ").Append(this.sharedFormula.IsSet((int)this.Options)).Append("\n");
			buffer.Append("    .zero            = ").Append(this.field_6_zero).Append("\n");
			global::NPOI.SS.Formula.PTG.Ptg[] tokens = this.field_8_parsed_expr.Tokens;
			for (int i = 0; i < tokens.Length; i++)
			{
				buffer.Append("\t Ptg[").Append(i).Append("]=");
				global::NPOI.SS.Formula.PTG.Ptg ptg = tokens[i];
				buffer.Append(ptg.ToString()).Append(ptg.RVAType).Append("\n");
			}
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x0006BF8C File Offset: 0x0006A18C
		public override object Clone()
		{
			global::NPOI.HSSF.Record.FormulaRecord formulaRecord = new global::NPOI.HSSF.Record.FormulaRecord();
			base.CopyBaseFields(formulaRecord);
			formulaRecord.field_4_value = this.field_4_value;
			formulaRecord.field_5_options = this.field_5_options;
			formulaRecord.field_6_zero = this.field_6_zero;
			formulaRecord.field_8_parsed_expr = this.field_8_parsed_expr.Copy();
			formulaRecord.specialCachedValue = this.specialCachedValue;
			return formulaRecord;
		}

		// Token: 0x04000F03 RID: 3843
		public const short sid = 6;

		// Token: 0x04000F04 RID: 3844
		private const int FIXED_SIZE = 14;

		// Token: 0x04000F05 RID: 3845
		private double field_4_value;

		// Token: 0x04000F06 RID: 3846
		private short field_5_options;

		// Token: 0x04000F07 RID: 3847
		private global::NPOI.Util.BitField alwaysCalc = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04000F08 RID: 3848
		private global::NPOI.Util.BitField calcOnLoad = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x04000F09 RID: 3849
		private global::NPOI.Util.BitField sharedFormula = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x04000F0A RID: 3850
		private int field_6_zero;

		// Token: 0x04000F0B RID: 3851
		[global::System.NonSerialized]
		private global::NPOI.SS.Formula.Formula field_8_parsed_expr;

		// Token: 0x04000F0C RID: 3852
		[global::System.NonSerialized]
		private global::NPOI.HSSF.Record.SpecialCachedValue specialCachedValue;
	}
}
