using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x02000403 RID: 1027
	public class RC2Parameters : global::Org.BouncyCastle.Crypto.Parameters.KeyParameter
	{
		// Token: 0x06002866 RID: 10342 RVA: 0x000ACA33 File Offset: 0x000AAC33
		public RC2Parameters(byte[] key) : this(key, (key.Length > 128) ? 1024 : (key.Length * 8))
		{
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x000ACA52 File Offset: 0x000AAC52
		public RC2Parameters(byte[] key, int keyOff, int keyLen) : this(key, keyOff, keyLen, (keyLen > 128) ? 1024 : (keyLen * 8))
		{
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x000ACA6F File Offset: 0x000AAC6F
		public RC2Parameters(byte[] key, int bits) : base(key)
		{
			this.bits = bits;
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x000ACA7F File Offset: 0x000AAC7F
		public RC2Parameters(byte[] key, int keyOff, int keyLen, int bits) : base(key, keyOff, keyLen)
		{
			this.bits = bits;
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600286A RID: 10346 RVA: 0x000ACA92 File Offset: 0x000AAC92
		public int EffectiveKeyBits
		{
			get
			{
				return this.bits;
			}
		}

		// Token: 0x04001066 RID: 4198
		private readonly int bits;
	}
}
