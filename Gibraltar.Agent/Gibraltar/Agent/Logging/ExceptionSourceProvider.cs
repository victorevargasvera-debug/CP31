using System;

namespace Gibraltar.Agent.Logging
{
	// Token: 0x02000032 RID: 50
	public class ExceptionSourceProvider : global::Gibraltar.Agent.IMessageSourceProvider
	{
		// Token: 0x060002F0 RID: 752 RVA: 0x0000A7CC File Offset: 0x000089CC
		public ExceptionSourceProvider(global::System.Exception exception)
		{
			global::Gibraltar.CommonCentralLogic.FindMessageSource(0, true, exception, out this.m_ClassName, out this.m_MethodName, out this.m_FileName, out this.m_LineNumber);
			this.OnMessageSourceCalculate(ref this.m_ClassName, ref this.m_MethodName, ref this.m_FileName, ref this.m_LineNumber);
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000A824 File Offset: 0x00008A24
		public string MethodName
		{
			get
			{
				return this.m_MethodName;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x0000A82C File Offset: 0x00008A2C
		public string ClassName
		{
			get
			{
				return this.m_ClassName;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000A834 File Offset: 0x00008A34
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000A83C File Offset: 0x00008A3C
		public int LineNumber
		{
			get
			{
				return this.m_LineNumber;
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000A844 File Offset: 0x00008A44
		protected virtual void OnMessageSourceCalculate(ref string className, ref string methodName, ref string fileName, ref int lineNumber)
		{
		}

		// Token: 0x040000AF RID: 175
		private readonly string m_MethodName;

		// Token: 0x040000B0 RID: 176
		private readonly string m_ClassName;

		// Token: 0x040000B1 RID: 177
		private readonly string m_FileName;

		// Token: 0x040000B2 RID: 178
		private readonly int m_LineNumber;
	}
}
