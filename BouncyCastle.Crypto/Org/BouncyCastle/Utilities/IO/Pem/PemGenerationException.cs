using System;

namespace Org.BouncyCastle.Utilities.IO.Pem
{
	// Token: 0x02000057 RID: 87
	[global::System.Serializable]
	public class PemGenerationException : global::System.Exception
	{
		// Token: 0x060003D1 RID: 977 RVA: 0x000140D3 File Offset: 0x000122D3
		public PemGenerationException()
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000140DB File Offset: 0x000122DB
		public PemGenerationException(string message) : base(message)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000140E4 File Offset: 0x000122E4
		public PemGenerationException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
