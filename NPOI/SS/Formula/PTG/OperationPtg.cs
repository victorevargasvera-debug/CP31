using System;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200011B RID: 283
	[global::System.Serializable]
	public abstract class OperationPtg : global::NPOI.SS.Formula.PTG.Ptg
	{
		// Token: 0x06000955 RID: 2389
		public abstract string ToFormulaString(string[] operands);

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000956 RID: 2390
		public abstract int NumberOfOperands { get; }

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x000162C8 File Offset: 0x000144C8
		public override byte DefaultOperandClass
		{
			get
			{
				return 32;
			}
		}

		// Token: 0x040004C8 RID: 1224
		public const int TYPE_UNARY = 0;

		// Token: 0x040004C9 RID: 1225
		public const int TYPE_BINARY = 1;

		// Token: 0x040004CA RID: 1226
		public const int TYPE_FUNCTION = 2;
	}
}
