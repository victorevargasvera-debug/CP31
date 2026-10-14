using System;
using System.Text;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003A7 RID: 935
	public class ArrayRecord : global::NPOI.HSSF.Record.SharedValueRecordBase, global::System.ICloneable
	{
		// Token: 0x06002057 RID: 8279 RVA: 0x000637B4 File Offset: 0x000619B4
		public ArrayRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : base(in1)
		{
			this._options = in1.ReadUShort();
			this._field3notUsed = in1.ReadInt();
			int encodedTokenLen = in1.ReadUShort();
			int totalEncodedLen = in1.Available();
			this._formula = global::NPOI.SS.Formula.Formula.Read(encodedTokenLen, in1, totalEncodedLen);
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x000637FC File Offset: 0x000619FC
		public ArrayRecord(global::NPOI.SS.Formula.Formula formula, global::NPOI.SS.Util.CellRangeAddress8Bit range) : base(range)
		{
			this._options = 0;
			this._field3notUsed = 0;
			this._formula = formula;
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x0006381A File Offset: 0x00061A1A
		public bool IsAlwaysRecalculate
		{
			get
			{
				return (this._options & 1) != 0;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x00063827 File Offset: 0x00061A27
		public bool IsCalculateOnOpen
		{
			get
			{
				return (this._options & 2) != 0;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x00063834 File Offset: 0x00061A34
		public global::NPOI.SS.Formula.PTG.Ptg[] FormulaTokens
		{
			get
			{
				return this._formula.Tokens;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x00063841 File Offset: 0x00061A41
		protected override int ExtraDataSize
		{
			get
			{
				return 6 + this._formula.EncodedSize;
			}
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x00063850 File Offset: 0x00061A50
		protected override void SerializeExtraData(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this._options);
			out1.WriteInt(this._field3notUsed);
			this._formula.Serialize(out1);
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x00063876 File Offset: 0x00061A76
		public override short Sid
		{
			get
			{
				return 545;
			}
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x00063880 File Offset: 0x00061A80
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name).Append(" [ARRAY]\n");
			stringBuilder.Append(" range=").Append(base.Range.ToString()).Append("\n");
			stringBuilder.Append(" options=").Append(global::NPOI.Util.HexDump.ShortToHex(this._options)).Append("\n");
			stringBuilder.Append(" notUsed=").Append(global::NPOI.Util.HexDump.IntToHex(this._field3notUsed)).Append("\n");
			stringBuilder.Append(" formula:").Append("\n");
			foreach (global::NPOI.SS.Formula.PTG.Ptg ptg in this._formula.Tokens)
			{
				stringBuilder.Append(ptg.ToString()).Append(ptg.RVAType).Append("\n");
			}
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x00063989 File Offset: 0x00061B89
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.ArrayRecord(this._formula.Copy(), base.Range)
			{
				_options = this._options,
				_field3notUsed = this._field3notUsed
			};
		}

		// Token: 0x04000C97 RID: 3223
		public const short sid = 545;

		// Token: 0x04000C98 RID: 3224
		private const int OPT_ALWAYS_RECALCULATE = 1;

		// Token: 0x04000C99 RID: 3225
		private const int OPT_CALCULATE_ON_OPEN = 2;

		// Token: 0x04000C9A RID: 3226
		private int _options;

		// Token: 0x04000C9B RID: 3227
		private int _field3notUsed;

		// Token: 0x04000C9C RID: 3228
		private global::NPOI.SS.Formula.Formula _formula;
	}
}
