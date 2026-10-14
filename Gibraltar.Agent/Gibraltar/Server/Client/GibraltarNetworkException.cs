using System;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000120 RID: 288
	[global::System.Serializable]
	internal class GibraltarNetworkException : global::Gibraltar.GibraltarException
	{
		// Token: 0x06000BCB RID: 3019 RVA: 0x0001DE04 File Offset: 0x0001C004
		public GibraltarNetworkException()
		{
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0001DE0C File Offset: 0x0001C00C
		public GibraltarNetworkException(string message) : base(message)
		{
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0001DE18 File Offset: 0x0001C018
		public GibraltarNetworkException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
