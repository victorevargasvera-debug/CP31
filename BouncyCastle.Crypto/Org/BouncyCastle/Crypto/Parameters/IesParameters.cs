using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003F0 RID: 1008
	public class IesParameters : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x06002813 RID: 10259 RVA: 0x000AC2C3 File Offset: 0x000AA4C3
		public IesParameters(byte[] derivation, byte[] encoding, int macKeySize)
		{
			this.derivation = derivation;
			this.encoding = encoding;
			this.macKeySize = macKeySize;
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x000AC2E0 File Offset: 0x000AA4E0
		public byte[] GetDerivationV()
		{
			return this.derivation;
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x000AC2E8 File Offset: 0x000AA4E8
		public byte[] GetEncodingV()
		{
			return this.encoding;
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06002816 RID: 10262 RVA: 0x000AC2F0 File Offset: 0x000AA4F0
		public int MacKeySize
		{
			get
			{
				return this.macKeySize;
			}
		}

		// Token: 0x04001038 RID: 4152
		private byte[] derivation;

		// Token: 0x04001039 RID: 4153
		private byte[] encoding;

		// Token: 0x0400103A RID: 4154
		private int macKeySize;
	}
}
