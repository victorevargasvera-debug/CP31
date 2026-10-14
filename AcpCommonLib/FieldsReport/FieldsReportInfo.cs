using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AcpCommonLib.FieldsReport
{
	// Token: 0x02000045 RID: 69
	[global::System.Diagnostics.DebuggerDisplay("Name={Field.Name}")]
	public class FieldsReportInfo : global::AcpCommonLib.FieldInfo
	{
		// Token: 0x0600027A RID: 634 RVA: 0x000187BC File Offset: 0x000169BC
		internal FieldsReportInfo(global::AcpCommonLib.IAcpField A_0, string A_1) : base(A_0)
		{
			this.Message = A_1;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000187D8 File Offset: 0x000169D8
		internal FieldsReportInfo(global::AcpCommonLib.IAcpFeatureNode A_0, string A_1) : base(A_0)
		{
			this.Message = A_1;
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600027C RID: 636 RVA: 0x000187F4 File Offset: 0x000169F4
		// (set) Token: 0x0600027D RID: 637 RVA: 0x000188A4 File Offset: 0x00016AA4
		public string Message
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)428687035;
				short num2 = num;
				num = (short)1923694267;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1498021888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)777453569;
				if (num != 0)
				{
				}
				num = (short)681181184;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1429873204;
				short num2 = num;
				num = (short)1304175156;
				switch (num2 == num)
				{
				default:
				{
					num = (short)18087936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2024210433;
				if (num != 0)
				{
				}
				num = (short)2129788928;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x040000CE RID: 206
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
