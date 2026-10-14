using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Gibraltar.Monitor
{
	// Token: 0x0200019E RID: 414
	internal class MessageSourceProvider : global::Gibraltar.Monitor.IMessageSourceProvider
	{
		// Token: 0x0600120D RID: 4621 RVA: 0x00033DF4 File Offset: 0x00031FF4
		protected MessageSourceProvider()
		{
			this.m_MethodName = null;
			this.m_ClassName = null;
			this.m_FileName = null;
			this.m_LineNumber = 0;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x00033E18 File Offset: 0x00032018
		public MessageSourceProvider(string className, string methodName)
		{
			this.m_MethodName = methodName;
			this.m_ClassName = className;
			this.m_FileName = null;
			this.m_LineNumber = 0;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x00033E3C File Offset: 0x0003203C
		public MessageSourceProvider(string className, string methodName, string fileName, int lineNumber)
		{
			this.m_MethodName = methodName;
			this.m_ClassName = className;
			this.m_FileName = fileName;
			this.m_LineNumber = lineNumber;
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x00033E64 File Offset: 0x00032064
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public MessageSourceProvider(int skipFrames, bool localOrigin)
		{
			this.m_SelectedStackFrame = global::Gibraltar.CommonCentralLogic.FindMessageSource(skipFrames + 1, localOrigin || true, null, out this.m_ClassName, out this.m_MethodName, out this.m_FileName, out this.m_LineNumber);
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x00033EB0 File Offset: 0x000320B0
		public string StackTrace
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				lock (this)
				{
					if (string.IsNullOrEmpty(this.m_FormattedStackTrace))
					{
						try
						{
							this.m_FormattedStackTrace = new global::System.Diagnostics.StackTrace(this.m_SelectedStackFrame + 1, true).ToString();
						}
						catch
						{
							this.m_FormattedStackTrace = null;
						}
					}
				}
				return this.m_FormattedStackTrace;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x00033F30 File Offset: 0x00032130
		public string MethodName
		{
			get
			{
				return this.m_MethodName;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x00033F38 File Offset: 0x00032138
		public string ClassName
		{
			get
			{
				return this.m_ClassName;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x00033F40 File Offset: 0x00032140
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00033F48 File Offset: 0x00032148
		public int LineNumber
		{
			get
			{
				return this.m_LineNumber;
			}
		}

		// Token: 0x04000617 RID: 1559
		private string m_MethodName;

		// Token: 0x04000618 RID: 1560
		private string m_ClassName;

		// Token: 0x04000619 RID: 1561
		private string m_FileName;

		// Token: 0x0400061A RID: 1562
		private int m_LineNumber;

		// Token: 0x0400061B RID: 1563
		private string m_FormattedStackTrace;

		// Token: 0x0400061C RID: 1564
		private int m_SelectedStackFrame;
	}
}
