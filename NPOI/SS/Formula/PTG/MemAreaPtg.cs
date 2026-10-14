using System;
using System.Text;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000111 RID: 273
	public class MemAreaPtg : global::NPOI.SS.Formula.PTG.OperandPtg
	{
		// Token: 0x06000914 RID: 2324 RVA: 0x000186D6 File Offset: 0x000168D6
		public MemAreaPtg(int subexLen)
		{
			this.field_1_reserved = 0;
			this.field_2_subex_len = subexLen;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x000186EC File Offset: 0x000168EC
		public MemAreaPtg(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.field_1_reserved = in1.ReadInt();
			this.field_2_subex_len = (int)in1.ReadShort();
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x0001870C File Offset: 0x0001690C
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x00018714 File Offset: 0x00016914
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

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x0001871D File Offset: 0x0001691D
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x00018725 File Offset: 0x00016925
		public int LenRefSubexpression
		{
			get
			{
				return this.field_2_subex_len;
			}
			set
			{
				this.field_2_subex_len = value;
			}
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0001872E File Offset: 0x0001692E
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(38 + base.PtgClass));
			out1.WriteInt(this.field_1_reserved);
			out1.WriteShort(this.field_2_subex_len);
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00017F33 File Offset: 0x00016133
		public override int Size
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00018757 File Offset: 0x00016957
		public override string ToFormulaString()
		{
			return "";
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x000162C8 File Offset: 0x000144C8
		public override byte DefaultOperandClass
		{
			get
			{
				return 32;
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00018760 File Offset: 0x00016960
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [len=");
			stringBuilder.Append(this.field_2_subex_len);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x040004AC RID: 1196
		public const short sid = 38;

		// Token: 0x040004AD RID: 1197
		private const int SIZE = 7;

		// Token: 0x040004AE RID: 1198
		private int field_1_reserved;

		// Token: 0x040004AF RID: 1199
		private int field_2_subex_len;
	}
}
