using System;
using AcpCommonLib;

namespace AcpUI.Common
{
	// Token: 0x020000AB RID: 171
	public class FieldReportUpdatedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000689 RID: 1673 RVA: 0x00082D94 File Offset: 0x00080F94
		internal FieldReportUpdatedEventArgs(global::AcpCommonLib.FieldReportType A_0)
		{
			this.a = A_0;
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x00082DB0 File Offset: 0x00080FB0
		internal global::AcpCommonLib.FieldReportType FieldReportType
		{
			get
			{
				short num = (short)538247168;
				short num2 = num;
				num = (short)1535967233;
				if (num != 0)
				{
				}
				num = (short)1034111434;
				short num3 = num;
				num = (short)269568458;
				switch (num3 == num)
				{
				}
				num = (short)119209984;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x0400033D RID: 829
		private global::AcpCommonLib.FieldReportType a;
	}
}
