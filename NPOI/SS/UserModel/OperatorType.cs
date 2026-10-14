using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200005F RID: 95
	public static class OperatorType
	{
		// Token: 0x0600038A RID: 906 RVA: 0x0000C301 File Offset: 0x0000A501
		public static void ValidateSecondArg(int comparisonOperator, string paramValue)
		{
			if (comparisonOperator != 0)
			{
				if (comparisonOperator != 1)
				{
					return;
				}
				if (paramValue == null)
				{
					throw new global::System.ArgumentException("expr2 must be supplied for 'between' comparisons");
				}
			}
			else if (paramValue == null)
			{
				throw new global::System.ArgumentException("expr2 must be supplied for 'between' comparisons");
			}
		}

		// Token: 0x0400019F RID: 415
		public const int BETWEEN = 0;

		// Token: 0x040001A0 RID: 416
		public const int NOT_BETWEEN = 1;

		// Token: 0x040001A1 RID: 417
		public const int EQUAL = 2;

		// Token: 0x040001A2 RID: 418
		public const int NOT_EQUAL = 3;

		// Token: 0x040001A3 RID: 419
		public const int GREATER_THAN = 4;

		// Token: 0x040001A4 RID: 420
		public const int LESS_THAN = 5;

		// Token: 0x040001A5 RID: 421
		public const int GREATER_OR_EQUAL = 6;

		// Token: 0x040001A6 RID: 422
		public const int LESS_OR_EQUAL = 7;

		// Token: 0x040001A7 RID: 423
		public const int IGNORED = 0;
	}
}
