using System;

namespace Org.BouncyCastle.X509.Store
{
	// Token: 0x0200002D RID: 45
	[global::System.Serializable]
	public class X509StoreException : global::System.Exception
	{
		// Token: 0x06000212 RID: 530 RVA: 0x0000AFC4 File Offset: 0x000091C4
		public X509StoreException()
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000AFCC File Offset: 0x000091CC
		public X509StoreException(string message) : base(message)
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000AFD5 File Offset: 0x000091D5
		public X509StoreException(string message, global::System.Exception e) : base(message, e)
		{
		}
	}
}
