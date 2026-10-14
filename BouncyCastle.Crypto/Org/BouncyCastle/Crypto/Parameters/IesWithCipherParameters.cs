using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003F1 RID: 1009
	public class IesWithCipherParameters : global::Org.BouncyCastle.Crypto.Parameters.IesParameters
	{
		// Token: 0x06002817 RID: 10263 RVA: 0x000AC2F8 File Offset: 0x000AA4F8
		public IesWithCipherParameters(byte[] derivation, byte[] encoding, int macKeySize, int cipherKeySize) : base(derivation, encoding, macKeySize)
		{
			this.cipherKeySize = cipherKeySize;
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06002818 RID: 10264 RVA: 0x000AC30B File Offset: 0x000AA50B
		public int CipherKeySize
		{
			get
			{
				return this.cipherKeySize;
			}
		}

		// Token: 0x0400103B RID: 4155
		private int cipherKeySize;
	}
}
