using System;
using System.Text;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.Record.CF
{
	// Token: 0x020004C6 RID: 1222
	public abstract class Threshold
	{
		// Token: 0x06002DEF RID: 11759 RVA: 0x00087C09 File Offset: 0x00085E09
		protected Threshold()
		{
			this.type = (byte)global::NPOI.SS.UserModel.RangeType.NUMBER.id;
			this.formula = global::NPOI.SS.Formula.Formula.Create(null);
			this.value = new double?(0.0);
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x00087C44 File Offset: 0x00085E44
		protected Threshold(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.type = (byte)in1.ReadByte();
			short num = in1.ReadShort();
			if (num > 0)
			{
				this.formula = global::NPOI.SS.Formula.Formula.Read((int)num, in1);
			}
			else
			{
				this.formula = global::NPOI.SS.Formula.Formula.Create(null);
			}
			if (num == 0 && (int)this.type != global::NPOI.SS.UserModel.RangeType.MIN.id && (int)this.type != global::NPOI.SS.UserModel.RangeType.MAX.id && (int)this.type != global::NPOI.SS.UserModel.RangeType.AUTOMIN.id && (int)this.type != global::NPOI.SS.UserModel.RangeType.AUTOMAX.id)
			{
				this.value = new double?(in1.ReadDouble());
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06002DF1 RID: 11761 RVA: 0x00087CE6 File Offset: 0x00085EE6
		// (set) Token: 0x06002DF2 RID: 11762 RVA: 0x00087CF0 File Offset: 0x00085EF0
		public byte Type
		{
			get
			{
				return this.type;
			}
			set
			{
				this.type = value;
				if ((int)this.type == global::NPOI.SS.UserModel.RangeType.MIN.id || (int)this.type == global::NPOI.SS.UserModel.RangeType.MAX.id || (int)this.type == global::NPOI.SS.UserModel.RangeType.FORMULA.id || (int)this.type == global::NPOI.SS.UserModel.RangeType.AUTOMIN.id || (int)this.type == global::NPOI.SS.UserModel.RangeType.AUTOMAX.id)
				{
					this.value = null;
					return;
				}
				if (this.value == null)
				{
					this.value = new double?(0.0);
				}
			}
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x00087D8C File Offset: 0x00085F8C
		public void SetType(int type)
		{
			this.type = (byte)type;
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002DF4 RID: 11764 RVA: 0x00087D96 File Offset: 0x00085F96
		protected global::NPOI.SS.Formula.Formula Formula
		{
			get
			{
				return this.formula;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x00087D9E File Offset: 0x00085F9E
		// (set) Token: 0x06002DF6 RID: 11766 RVA: 0x00087DAB File Offset: 0x00085FAB
		public global::NPOI.SS.Formula.PTG.Ptg[] ParsedExpression
		{
			get
			{
				return this.formula.Tokens;
			}
			set
			{
				this.formula = global::NPOI.SS.Formula.Formula.Create(value);
				if (value.Length != 0)
				{
					this.value = null;
				}
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002DF7 RID: 11767 RVA: 0x00087DC9 File Offset: 0x00085FC9
		// (set) Token: 0x06002DF8 RID: 11768 RVA: 0x00087DD1 File Offset: 0x00085FD1
		public double? Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.value = value;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06002DF9 RID: 11769 RVA: 0x00087DDC File Offset: 0x00085FDC
		public virtual int DataLength
		{
			get
			{
				int num = 1 + this.formula.EncodedSize;
				if (this.value != null)
				{
					num += 8;
				}
				return num;
			}
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x00087E0C File Offset: 0x0008600C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("    [CF Threshold]\n");
			stringBuilder.Append("          .type    = ").Append(global::NPOI.Util.HexDump.ToHex(this.type)).Append("\n");
			global::System.Text.StringBuilder stringBuilder2 = stringBuilder.Append("          .Formula = ");
			object[] tokens = this.formula.Tokens;
			stringBuilder2.Append(global::NPOI.Util.Arrays.ToString(tokens)).Append("\n");
			stringBuilder.Append("          .value   = ").Append(this.value).Append("\n");
			stringBuilder.Append("    [/CF Threshold]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x00087EB4 File Offset: 0x000860B4
		public void CopyTo(global::NPOI.HSSF.Record.CF.Threshold rec)
		{
			rec.type = this.type;
			rec.formula = this.formula;
			rec.value = this.value;
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x00087EDC File Offset: 0x000860DC
		public virtual void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)this.type);
			if (this.formula.Tokens.Length == 0)
			{
				out1.WriteShort(0);
			}
			else
			{
				this.formula.Serialize(out1);
			}
			if (this.value != null)
			{
				out1.WriteDouble(this.value.Value);
			}
		}

		// Token: 0x04001424 RID: 5156
		private byte type;

		// Token: 0x04001425 RID: 5157
		private global::NPOI.SS.Formula.Formula formula;

		// Token: 0x04001426 RID: 5158
		private double? value;
	}
}
