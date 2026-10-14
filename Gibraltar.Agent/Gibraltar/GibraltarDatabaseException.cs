using System;

namespace Gibraltar
{
	// Token: 0x02000169 RID: 361
	[global::System.Serializable]
	internal class GibraltarDatabaseException : global::Gibraltar.GibraltarException
	{
		// Token: 0x06000EED RID: 3821 RVA: 0x0002688C File Offset: 0x00024A8C
		public GibraltarDatabaseException()
		{
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00026894 File Offset: 0x00024A94
		public GibraltarDatabaseException(string message) : base(message)
		{
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x000268A0 File Offset: 0x00024AA0
		public GibraltarDatabaseException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x000268AC File Offset: 0x00024AAC
		public GibraltarDatabaseException(int code, string message, global::System.Exception innerException) : base(message, innerException)
		{
			this.m_Code = code;
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x000268C0 File Offset: 0x00024AC0
		public int Code
		{
			get
			{
				return this.m_Code;
			}
		}

		// Token: 0x04000500 RID: 1280
		private readonly int m_Code;
	}
}
