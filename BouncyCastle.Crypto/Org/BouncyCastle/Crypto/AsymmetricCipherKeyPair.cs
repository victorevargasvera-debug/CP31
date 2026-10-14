using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002B4 RID: 692
	public class AsymmetricCipherKeyPair
	{
		// Token: 0x06001EE6 RID: 7910 RVA: 0x0008F144 File Offset: 0x0008D344
		public AsymmetricCipherKeyPair(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicParameter, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateParameter)
		{
			if (publicParameter.IsPrivate)
			{
				throw new global::System.ArgumentException("Expected a public key", "publicParameter");
			}
			if (!privateParameter.IsPrivate)
			{
				throw new global::System.ArgumentException("Expected a private key", "privateParameter");
			}
			this.publicParameter = publicParameter;
			this.privateParameter = privateParameter;
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x0008F195 File Offset: 0x0008D395
		public global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter Public
		{
			get
			{
				return this.publicParameter;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x0008F19D File Offset: 0x0008D39D
		public global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter Private
		{
			get
			{
				return this.privateParameter;
			}
		}

		// Token: 0x04000B1A RID: 2842
		private readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicParameter;

		// Token: 0x04000B1B RID: 2843
		private readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateParameter;
	}
}
