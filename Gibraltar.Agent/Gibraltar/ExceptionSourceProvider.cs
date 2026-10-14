using System;
using Gibraltar.Monitor;

namespace Gibraltar
{
	// Token: 0x02000168 RID: 360
	internal class ExceptionSourceProvider : global::Gibraltar.Monitor.IMessageSourceProvider
	{
		// Token: 0x06000EE8 RID: 3816 RVA: 0x00026834 File Offset: 0x00024A34
		public ExceptionSourceProvider(global::System.Exception exception)
		{
			global::Gibraltar.CommonCentralLogic.FindMessageSource(0, true, exception, out this.m_ClassName, out this.m_MethodName, out this.m_FileName, out this.m_LineNumber);
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x0002686C File Offset: 0x00024A6C
		public string MethodName
		{
			get
			{
				return this.m_MethodName;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x00026874 File Offset: 0x00024A74
		public string ClassName
		{
			get
			{
				return this.m_ClassName;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x0002687C File Offset: 0x00024A7C
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x00026884 File Offset: 0x00024A84
		public int LineNumber
		{
			get
			{
				return this.m_LineNumber;
			}
		}

		// Token: 0x040004FC RID: 1276
		private readonly string m_MethodName;

		// Token: 0x040004FD RID: 1277
		private readonly string m_ClassName;

		// Token: 0x040004FE RID: 1278
		private readonly string m_FileName;

		// Token: 0x040004FF RID: 1279
		private readonly int m_LineNumber;
	}
}
