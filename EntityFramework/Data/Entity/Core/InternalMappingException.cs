using System;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core
{
	// Token: 0x020002D8 RID: 728
	[global::System.Serializable]
	internal class InternalMappingException : global::System.Data.Entity.Core.EntityException
	{
		// Token: 0x0600231E RID: 8990 RVA: 0x00062629 File Offset: 0x00060829
		internal InternalMappingException()
		{
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x00062631 File Offset: 0x00060831
		internal InternalMappingException(string message) : base(message)
		{
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x0006263A File Offset: 0x0006083A
		internal InternalMappingException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00062644 File Offset: 0x00060844
		protected InternalMappingException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x0006264E File Offset: 0x0006084E
		internal InternalMappingException(string message, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog) : base(message)
		{
			this.m_errorLog = errorLog;
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x0006265E File Offset: 0x0006085E
		internal InternalMappingException(string message, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record) : base(message)
		{
			this.m_errorLog = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog();
			this.m_errorLog.AddEntry(record);
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x0006267E File Offset: 0x0006087E
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog ErrorLog
		{
			get
			{
				return this.m_errorLog;
			}
		}

		// Token: 0x04000C0B RID: 3083
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog m_errorLog;
	}
}
