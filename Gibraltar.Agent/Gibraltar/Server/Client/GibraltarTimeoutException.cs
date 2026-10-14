using System;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000122 RID: 290
	[global::System.Serializable]
	internal class GibraltarTimeoutException : global::Gibraltar.GibraltarException
	{
		// Token: 0x06000BD5 RID: 3029 RVA: 0x0001DED0 File Offset: 0x0001C0D0
		public GibraltarTimeoutException()
		{
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0001DED8 File Offset: 0x0001C0D8
		public GibraltarTimeoutException(string message) : base(message)
		{
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0001DEE4 File Offset: 0x0001C0E4
		public GibraltarTimeoutException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
