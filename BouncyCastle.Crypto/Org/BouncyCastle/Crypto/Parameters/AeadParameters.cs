using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003C5 RID: 965
	public class AeadParameters : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x060026F8 RID: 9976 RVA: 0x000A9F52 File Offset: 0x000A8152
		public AeadParameters(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key, int macSize, byte[] nonce) : this(key, macSize, nonce, null)
		{
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x000A9F5E File Offset: 0x000A815E
		public AeadParameters(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key, int macSize, byte[] nonce, byte[] associatedText)
		{
			this.key = key;
			this.nonce = nonce;
			this.macSize = macSize;
			this.associatedText = associatedText;
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060026FA RID: 9978 RVA: 0x000A9F83 File Offset: 0x000A8183
		public virtual global::Org.BouncyCastle.Crypto.Parameters.KeyParameter Key
		{
			get
			{
				return this.key;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x000A9F8B File Offset: 0x000A818B
		public virtual int MacSize
		{
			get
			{
				return this.macSize;
			}
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x000A9F93 File Offset: 0x000A8193
		public virtual byte[] GetAssociatedText()
		{
			return this.associatedText;
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x000A9F9B File Offset: 0x000A819B
		public virtual byte[] GetNonce()
		{
			return this.nonce;
		}

		// Token: 0x04000FD4 RID: 4052
		private readonly byte[] associatedText;

		// Token: 0x04000FD5 RID: 4053
		private readonly byte[] nonce;

		// Token: 0x04000FD6 RID: 4054
		private readonly global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key;

		// Token: 0x04000FD7 RID: 4055
		private readonly int macSize;
	}
}
