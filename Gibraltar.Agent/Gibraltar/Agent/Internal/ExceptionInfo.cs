using System;
using Gibraltar.Agent.Data;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent.Internal
{
	// Token: 0x02000035 RID: 53
	internal class ExceptionInfo : global::Gibraltar.Agent.Data.IExceptionInfo
	{
		// Token: 0x06000310 RID: 784 RVA: 0x0000AA44 File Offset: 0x00008C44
		internal ExceptionInfo(global::Loupe.Extensibility.Data.IExceptionInfo wrappedExceptionInfo)
		{
			this.m_WrappedExceptionInfo = wrappedExceptionInfo;
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0000AA54 File Offset: 0x00008C54
		public string TypeName
		{
			get
			{
				return this.m_WrappedExceptionInfo.TypeName;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0000AA64 File Offset: 0x00008C64
		public string Message
		{
			get
			{
				return this.m_WrappedExceptionInfo.Message;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0000AA74 File Offset: 0x00008C74
		public string Source
		{
			get
			{
				return this.m_WrappedExceptionInfo.Source;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0000AA84 File Offset: 0x00008C84
		public string StackTrace
		{
			get
			{
				return this.m_WrappedExceptionInfo.StackTrace;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000315 RID: 789 RVA: 0x0000AA94 File Offset: 0x00008C94
		public global::Gibraltar.Agent.Data.IExceptionInfo InnerException
		{
			get
			{
				if (this.m_WrappedExceptionInfo.InnerException == null)
				{
					return null;
				}
				if (this.m_InnerException == null)
				{
					this.m_InnerException = new global::Gibraltar.Agent.Internal.ExceptionInfo(this.m_WrappedExceptionInfo.InnerException);
				}
				return this.m_InnerException;
			}
		}

		// Token: 0x040000B8 RID: 184
		private readonly global::Loupe.Extensibility.Data.IExceptionInfo m_WrappedExceptionInfo;

		// Token: 0x040000B9 RID: 185
		private global::Gibraltar.Agent.Internal.ExceptionInfo m_InnerException;
	}
}
