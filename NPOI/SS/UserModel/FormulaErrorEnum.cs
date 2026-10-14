using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200006E RID: 110
	public enum FormulaErrorEnum : long
	{
		// Token: 0x040001FB RID: 507
		NO_ERROR = -1L,
		// Token: 0x040001FC RID: 508
		NULL,
		// Token: 0x040001FD RID: 509
		DIV_0 = 7L,
		// Token: 0x040001FE RID: 510
		VALUE = 15L,
		// Token: 0x040001FF RID: 511
		REF = 23L,
		// Token: 0x04000200 RID: 512
		NAME = 29L,
		// Token: 0x04000201 RID: 513
		NUM = 36L,
		// Token: 0x04000202 RID: 514
		NA = 42L,
		// Token: 0x04000203 RID: 515
		CIRCULAR_REF = 4294967236L,
		// Token: 0x04000204 RID: 516
		FUNCTION_NOT_IMPLEMENTED = 4294967266L
	}
}
