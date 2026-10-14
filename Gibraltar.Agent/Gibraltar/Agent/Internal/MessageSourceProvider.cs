using System;
using Gibraltar.Monitor;

namespace Gibraltar.Agent.Internal
{
	// Token: 0x02000038 RID: 56
	internal class MessageSourceProvider : global::Gibraltar.Monitor.IMessageSourceProvider, global::Gibraltar.Agent.IMessageSourceProvider
	{
		// Token: 0x06000341 RID: 833 RVA: 0x0000AE90 File Offset: 0x00009090
		public MessageSourceProvider(global::Gibraltar.Agent.IMessageSourceProvider callingProvider)
		{
			this.m_CallingProvider = callingProvider;
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0000AEA0 File Offset: 0x000090A0
		public string MethodName
		{
			get
			{
				return this.m_CallingProvider.MethodName;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0000AEB0 File Offset: 0x000090B0
		public string ClassName
		{
			get
			{
				return this.m_CallingProvider.ClassName;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0000AEC0 File Offset: 0x000090C0
		public string FileName
		{
			get
			{
				return this.m_CallingProvider.FileName;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0000AED0 File Offset: 0x000090D0
		public int LineNumber
		{
			get
			{
				return this.m_CallingProvider.LineNumber;
			}
		}

		// Token: 0x040000BC RID: 188
		private readonly global::Gibraltar.Agent.IMessageSourceProvider m_CallingProvider;
	}
}
