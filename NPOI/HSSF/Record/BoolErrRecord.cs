using System;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003AE RID: 942
	public class BoolErrRecord : global::NPOI.HSSF.Record.CellRecord, global::System.ICloneable
	{
		// Token: 0x06002098 RID: 8344 RVA: 0x00064026 File Offset: 0x00062226
		public BoolErrRecord()
		{
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00064030 File Offset: 0x00062230
		public BoolErrRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : base(in1)
		{
			int remaining = in1.Remaining;
			if (remaining != 2)
			{
				if (remaining != 3)
				{
					throw new global::NPOI.Util.RecordFormatException("Unexpected size (" + in1.Remaining.ToString() + ") for BOOLERR record.");
				}
				this._value = in1.ReadUShort();
			}
			else
			{
				this._value = in1.ReadByte();
			}
			int num = in1.ReadUByte();
			if (num == 0)
			{
				this._isError = false;
				return;
			}
			if (num != 1)
			{
				throw new global::NPOI.Util.RecordFormatException("Unexpected isError flag (" + num.ToString() + ") for BOOLERR record.");
			}
			this._isError = true;
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x000640CF File Offset: 0x000622CF
		public void SetValue(bool value)
		{
			this._value = (value ? 1 : 0);
			this._isError = false;
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x000640E5 File Offset: 0x000622E5
		public void SetValue(byte value)
		{
			this.SetValue(global::NPOI.SS.UserModel.FormulaError.ForInt(value));
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x000640F4 File Offset: 0x000622F4
		public void SetValue(global::NPOI.SS.UserModel.FormulaError value)
		{
			global::NPOI.SS.UserModel.FormulaErrorEnum formulaErrorEnum = (global::NPOI.SS.UserModel.FormulaErrorEnum)((ulong)value.Code);
			if (formulaErrorEnum <= global::NPOI.SS.UserModel.FormulaErrorEnum.VALUE)
			{
				if (formulaErrorEnum != global::NPOI.SS.UserModel.FormulaErrorEnum.NULL && formulaErrorEnum != global::NPOI.SS.UserModel.FormulaErrorEnum.DIV_0 && formulaErrorEnum != global::NPOI.SS.UserModel.FormulaErrorEnum.VALUE)
				{
					goto IL_52;
				}
			}
			else if (formulaErrorEnum <= global::NPOI.SS.UserModel.FormulaErrorEnum.NAME)
			{
				if (formulaErrorEnum != global::NPOI.SS.UserModel.FormulaErrorEnum.REF && formulaErrorEnum != global::NPOI.SS.UserModel.FormulaErrorEnum.NAME)
				{
					goto IL_52;
				}
			}
			else if (formulaErrorEnum != global::NPOI.SS.UserModel.FormulaErrorEnum.NUM && formulaErrorEnum != global::NPOI.SS.UserModel.FormulaErrorEnum.NA)
			{
				goto IL_52;
			}
			this._value = (int)value.Code;
			this._isError = true;
			return;
			IL_52:
			throw new global::System.ArgumentException("Error Value can only be 0,7,15,23,29,36 or 42. It cannot be " + ((value != null) ? value.ToString() : null));
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x0006416F File Offset: 0x0006236F
		public bool BooleanValue
		{
			get
			{
				return this._value != 0;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x0006417A File Offset: 0x0006237A
		public byte ErrorValue
		{
			get
			{
				return (byte)this._value;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x00064183 File Offset: 0x00062383
		public bool IsBoolean
		{
			get
			{
				return !this._isError;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x0006418E File Offset: 0x0006238E
		public bool IsError
		{
			get
			{
				return this._isError;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x00064196 File Offset: 0x00062396
		protected override string RecordName
		{
			get
			{
				return "BOOLERR";
			}
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x000641A0 File Offset: 0x000623A0
		protected override void AppendValueText(global::System.Text.StringBuilder buffer)
		{
			if (this.IsBoolean)
			{
				buffer.Append("    .boolValue   = ").Append(this.BooleanValue).Append("\n");
				return;
			}
			buffer.Append("    .errCode     = ").Append(global::NPOI.SS.UserModel.FormulaError.ForInt(this.ErrorValue).String).Append("\n");
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x00064202 File Offset: 0x00062402
		protected override void SerializeValue(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte(this._value);
			out1.WriteByte(this._isError ? 1 : 0);
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int ValueDataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x00064222 File Offset: 0x00062422
		public override short Sid
		{
			get
			{
				return 517;
			}
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x0006422C File Offset: 0x0006242C
		public override object Clone()
		{
			global::NPOI.HSSF.Record.BoolErrRecord boolErrRecord = new global::NPOI.HSSF.Record.BoolErrRecord();
			base.CopyBaseFields(boolErrRecord);
			boolErrRecord._value = this._value;
			boolErrRecord._isError = this._isError;
			return boolErrRecord;
		}

		// Token: 0x04000CBB RID: 3259
		public const short sid = 517;

		// Token: 0x04000CBC RID: 3260
		private int _value;

		// Token: 0x04000CBD RID: 3261
		private bool _isError;
	}
}
