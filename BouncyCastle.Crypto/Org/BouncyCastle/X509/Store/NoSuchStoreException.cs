using System;

namespace Org.BouncyCastle.X509.Store
{
	// Token: 0x02000026 RID: 38
	[global::System.Serializable]
	public class NoSuchStoreException : global::Org.BouncyCastle.X509.Store.X509StoreException
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x0000A054 File Offset: 0x00008254
		public NoSuchStoreException()
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000A05C File Offset: 0x0000825C
		public NoSuchStoreException(string message) : base(message)
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000A065 File Offset: 0x00008265
		public NoSuchStoreException(string message, global::System.Exception e) : base(message, e)
		{
		}
	}
}
