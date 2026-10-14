using System;
using Gibraltar.Agent.Data;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent.Internal
{
	// Token: 0x02000037 RID: 55
	internal class LogMessageInfo : global::Gibraltar.Agent.Data.ILogMessage, global::System.IComparable<global::Gibraltar.Agent.Data.ILogMessage>, global::System.IEquatable<global::Gibraltar.Agent.Data.ILogMessage>, global::Loupe.Extensibility.Data.ILogMessage, global::System.IComparable<global::Loupe.Extensibility.Data.ILogMessage>, global::System.IEquatable<global::Loupe.Extensibility.Data.ILogMessage>
	{
		// Token: 0x0600031C RID: 796 RVA: 0x0000AB14 File Offset: 0x00008D14
		internal LogMessageInfo(global::Loupe.Extensibility.Data.ILogMessage message)
		{
			this.m_Message = message;
			this.m_Exception = global::Gibraltar.Agent.Internal.LogMessageInfo.ConvertExceptionInfo(message);
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0000AB30 File Offset: 0x00008D30
		public global::Loupe.Extensibility.Data.ISession Session
		{
			get
			{
				throw new global::System.NotSupportedException("Access the current session summary information from the Gibraltar.Agent.Log object.");
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0000AB3C File Offset: 0x00008D3C
		public global::System.Guid Id
		{
			get
			{
				return this.m_Message.Id;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0000AB4C File Offset: 0x00008D4C
		public long Sequence
		{
			get
			{
				return this.m_Message.Sequence;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000AB5C File Offset: 0x00008D5C
		public global::System.DateTimeOffset Timestamp
		{
			get
			{
				return this.m_Message.Timestamp;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0000AB6C File Offset: 0x00008D6C
		public global::System.DateTimeOffset DisplayTimestamp
		{
			get
			{
				return this.Timestamp;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0000AB74 File Offset: 0x00008D74
		public global::Gibraltar.Agent.LogMessageSeverity Severity
		{
			get
			{
				return (global::Gibraltar.Agent.LogMessageSeverity)this.m_Message.Severity;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0000AB84 File Offset: 0x00008D84
		global::Loupe.Extensibility.Data.LogMessageSeverity global::Loupe.Extensibility.Data.ILogMessage.Severity
		{
			get
			{
				return this.m_Message.Severity;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0000AB94 File Offset: 0x00008D94
		public string LogSystem
		{
			get
			{
				return this.m_Message.LogSystem;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000ABA4 File Offset: 0x00008DA4
		public string CategoryName
		{
			get
			{
				return this.m_Message.CategoryName;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000ABB4 File Offset: 0x00008DB4
		public string UserName
		{
			get
			{
				return this.m_Message.UserName;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000ABC4 File Offset: 0x00008DC4
		public string Caption
		{
			get
			{
				return this.m_Message.Caption;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0000ABD4 File Offset: 0x00008DD4
		public string Description
		{
			get
			{
				return this.m_Message.Description;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000ABE4 File Offset: 0x00008DE4
		public string Details
		{
			get
			{
				return this.m_Message.Details;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0000ABF4 File Offset: 0x00008DF4
		public string MethodName
		{
			get
			{
				return this.m_Message.MethodName;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0000AC04 File Offset: 0x00008E04
		public string ClassName
		{
			get
			{
				return this.m_Message.ClassName;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000AC14 File Offset: 0x00008E14
		public string FileName
		{
			get
			{
				return this.m_Message.FileName;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0000AC24 File Offset: 0x00008E24
		public int LineNumber
		{
			get
			{
				return this.m_Message.LineNumber;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000AC34 File Offset: 0x00008E34
		public bool HasException
		{
			get
			{
				return this.m_Message.HasException;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0000AC44 File Offset: 0x00008E44
		global::Loupe.Extensibility.Data.IExceptionInfo global::Loupe.Extensibility.Data.ILogMessage.Exception
		{
			get
			{
				throw new global::System.NotSupportedException("Use the agent-specific IExceptionInfo interface to access exception information");
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000AC50 File Offset: 0x00008E50
		public global::Gibraltar.Agent.Data.IExceptionInfo Exception
		{
			get
			{
				return this.m_Exception;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0000AC58 File Offset: 0x00008E58
		public int ThreadId
		{
			get
			{
				return this.m_Message.ThreadId;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000AC68 File Offset: 0x00008E68
		public string ThreadName
		{
			get
			{
				return this.m_Message.ThreadName;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0000AC78 File Offset: 0x00008E78
		public int DomainId
		{
			get
			{
				return this.m_Message.DomainId;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000AC88 File Offset: 0x00008E88
		public string DomainName
		{
			get
			{
				return this.m_Message.DomainName;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000335 RID: 821 RVA: 0x0000AC98 File Offset: 0x00008E98
		public bool IsBackground
		{
			get
			{
				return this.m_Message.IsBackground;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000ACA8 File Offset: 0x00008EA8
		public bool IsThreadPoolThread
		{
			get
			{
				return this.m_Message.IsThreadPoolThread;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000337 RID: 823 RVA: 0x0000ACB8 File Offset: 0x00008EB8
		public bool HasThreadInfo
		{
			get
			{
				return this.m_Message.HasThreadInfo;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		public bool HasMethodInfo
		{
			get
			{
				return this.m_Message.HasMethodInfo;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0000ACD8 File Offset: 0x00008ED8
		public bool HasSourceLocation
		{
			get
			{
				return this.m_Message.HasSourceLocation;
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000ACE8 File Offset: 0x00008EE8
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			global::Gibraltar.Agent.Data.ILogMessage logMessage = obj as global::Gibraltar.Agent.Data.ILogMessage;
			if (logMessage != null)
			{
				return this.Equals(logMessage);
			}
			global::Loupe.Extensibility.Data.ILogMessage other = obj as global::Loupe.Extensibility.Data.ILogMessage;
			return logMessage != null && this.Equals(other);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000AD2C File Offset: 0x00008F2C
		public bool Equals(global::Gibraltar.Agent.Data.ILogMessage other)
		{
			return other != null && this.Id.Equals(other.Id);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000AD5C File Offset: 0x00008F5C
		public bool Equals(global::Loupe.Extensibility.Data.ILogMessage other)
		{
			return other != null && this.Id.Equals(other.Id);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000AD8C File Offset: 0x00008F8C
		public int CompareTo(global::Gibraltar.Agent.Data.ILogMessage other)
		{
			int num = this.Timestamp.CompareTo(other.Timestamp);
			if (num == 0)
			{
				num = this.Sequence.CompareTo(other.Sequence);
			}
			if (num == 0)
			{
				num = this.Id.CompareTo(other.Id);
			}
			return num;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000ADEC File Offset: 0x00008FEC
		public int CompareTo(global::Loupe.Extensibility.Data.ILogMessage other)
		{
			int num = this.Timestamp.CompareTo(other.Timestamp);
			if (num == 0)
			{
				num = this.Sequence.CompareTo(other.Sequence);
			}
			if (num == 0)
			{
				num = this.Id.CompareTo(other.Id);
			}
			return num;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000AE4C File Offset: 0x0000904C
		public override int GetHashCode()
		{
			return this.Id.GetHashCode();
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000AE74 File Offset: 0x00009074
		private static global::Gibraltar.Agent.Internal.ExceptionInfo ConvertExceptionInfo(global::Loupe.Extensibility.Data.ILogMessage message)
		{
			if (!message.HasException)
			{
				return null;
			}
			return new global::Gibraltar.Agent.Internal.ExceptionInfo(message.Exception);
		}

		// Token: 0x040000BA RID: 186
		private readonly global::Loupe.Extensibility.Data.ILogMessage m_Message;

		// Token: 0x040000BB RID: 187
		private readonly global::Gibraltar.Agent.Internal.ExceptionInfo m_Exception;
	}
}
