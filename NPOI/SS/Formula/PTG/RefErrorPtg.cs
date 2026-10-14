using System;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000123 RID: 291
	public class RefErrorPtg : global::NPOI.SS.Formula.PTG.OperandPtg
	{
		// Token: 0x0600099D RID: 2461 RVA: 0x000193D6 File Offset: 0x000175D6
		public RefErrorPtg()
		{
			this.field_1_reserved = 0;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x000193E5 File Offset: 0x000175E5
		public RefErrorPtg(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.field_1_reserved = in1.ReadInt();
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000193F9 File Offset: 0x000175F9
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("[RefError]\n");
			stringBuilder.Append("reserved = ").Append(this.Reserved).Append("\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0001942B File Offset: 0x0001762B
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(42 + base.PtgClass));
			out1.WriteInt(this.field_1_reserved);
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00019448 File Offset: 0x00017648
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x00019450 File Offset: 0x00017650
		public int Reserved
		{
			get
			{
				return this.field_1_reserved;
			}
			set
			{
				this.field_1_reserved = value;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x000181D5 File Offset: 0x000163D5
		public override int Size
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00016D99 File Offset: 0x00014F99
		public override string ToFormulaString()
		{
			return global::NPOI.SS.UserModel.FormulaError.REF.String;
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override byte DefaultOperandClass
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x040004E2 RID: 1250
		private const int SIZE = 5;

		// Token: 0x040004E3 RID: 1251
		public const byte sid = 42;

		// Token: 0x040004E4 RID: 1252
		private int field_1_reserved;
	}
}
