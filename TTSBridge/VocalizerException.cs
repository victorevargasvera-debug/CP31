using System;

namespace TTSBridge
{
	// Token: 0x0200000C RID: 12
	internal class VocalizerException : global::System.Exception
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00002DCA File Offset: 0x00000FCA
		public VocalizerException(string message) : base(message)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002DD3 File Offset: 0x00000FD3
		public VocalizerException(string message, uint err) : base(message)
		{
			this.mErrCode = err;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002DE3 File Offset: 0x00000FE3
		public uint getErrorCode()
		{
			return this.mErrCode;
		}

		// Token: 0x04000023 RID: 35
		private uint mErrCode;
	}
}
