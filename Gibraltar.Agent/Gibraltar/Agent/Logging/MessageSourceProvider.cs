using System;
using System.Runtime.CompilerServices;

namespace Gibraltar.Agent.Logging
{
	// Token: 0x02000033 RID: 51
	public class MessageSourceProvider : global::Gibraltar.Agent.IMessageSourceProvider
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x0000A848 File Offset: 0x00008A48
		protected MessageSourceProvider()
		{
			this.m_MethodName = null;
			this.m_ClassName = null;
			this.m_FileName = null;
			this.m_LineNumber = 0;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000A86C File Offset: 0x00008A6C
		public MessageSourceProvider(string className, string methodName)
		{
			this.m_MethodName = methodName;
			this.m_ClassName = className;
			this.m_FileName = null;
			this.m_LineNumber = 0;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000A890 File Offset: 0x00008A90
		public MessageSourceProvider(string className, string methodName, string fileName, int lineNumber)
		{
			this.m_MethodName = methodName;
			this.m_ClassName = className;
			this.m_FileName = fileName;
			this.m_LineNumber = lineNumber;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000A8B8 File Offset: 0x00008AB8
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public MessageSourceProvider(int skipFrames)
		{
			global::Gibraltar.CommonCentralLogic.FindMessageSource(skipFrames + 1, true, null, out this.m_ClassName, out this.m_MethodName, out this.m_FileName, out this.m_LineNumber);
			this.OnMessageSourceCalculate(ref this.m_ClassName, ref this.m_MethodName, ref this.m_FileName, ref this.m_LineNumber);
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0000A910 File Offset: 0x00008B10
		public string MethodName
		{
			get
			{
				return this.m_MethodName;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002FB RID: 763 RVA: 0x0000A918 File Offset: 0x00008B18
		public string ClassName
		{
			get
			{
				return this.m_ClassName;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0000A920 File Offset: 0x00008B20
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002FD RID: 765 RVA: 0x0000A928 File Offset: 0x00008B28
		public int LineNumber
		{
			get
			{
				return this.m_LineNumber;
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000A930 File Offset: 0x00008B30
		protected virtual void OnMessageSourceCalculate(ref string className, ref string methodName, ref string fileName, ref int lineNumber)
		{
		}

		// Token: 0x040000B3 RID: 179
		private readonly string m_MethodName;

		// Token: 0x040000B4 RID: 180
		private readonly string m_ClassName;

		// Token: 0x040000B5 RID: 181
		private readonly string m_FileName;

		// Token: 0x040000B6 RID: 182
		private readonly int m_LineNumber;
	}
}
