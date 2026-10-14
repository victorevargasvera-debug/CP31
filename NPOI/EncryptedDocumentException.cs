using System;

namespace NPOI
{
	// Token: 0x02000004 RID: 4
	[global::System.Serializable]
	public class EncryptedDocumentException : global::System.InvalidOperationException
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002070 File Offset: 0x00000270
		public EncryptedDocumentException(string message) : base(message)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002079 File Offset: 0x00000279
		public EncryptedDocumentException(string message, global::System.Exception cause) : base(message, cause)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002083 File Offset: 0x00000283
		public EncryptedDocumentException(global::System.Exception cause) : base(cause.Message)
		{
		}
	}
}
