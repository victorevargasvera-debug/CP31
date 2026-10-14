using System;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200012F RID: 303
	public abstract class ValueOperatorPtg : global::NPOI.SS.Formula.PTG.OperationPtg
	{
		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool IsBaseToken
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x000162C8 File Offset: 0x000144C8
		public override byte DefaultOperandClass
		{
			get
			{
				return 32;
			}
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00019A97 File Offset: 0x00017C97
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(this.Sid + base.PtgClass));
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060009F7 RID: 2551
		protected abstract byte Sid { get; }

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x00008875 File Offset: 0x00006A75
		public override int Size
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00019AAC File Offset: 0x00017CAC
		public override string ToFormulaString()
		{
			throw new global::System.NotImplementedException("ToFormulaString(String[] operands) should be used for subclasses of OperationPtgs");
		}
	}
}
