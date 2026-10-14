using System;
using System.IO;
using Org.BouncyCastle.Crypto.IO;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x0200041D RID: 1053
	public class BufferedCipherWrapper : global::Org.BouncyCastle.Crypto.ICipher
	{
		// Token: 0x060028F1 RID: 10481 RVA: 0x000ADD62 File Offset: 0x000ABF62
		public BufferedCipherWrapper(global::Org.BouncyCastle.Crypto.IBufferedCipher bufferedCipher, global::System.IO.Stream source)
		{
			this.bufferedCipher = bufferedCipher;
			this.stream = new global::Org.BouncyCastle.Crypto.IO.CipherStream(source, bufferedCipher, bufferedCipher);
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x000ADD7F File Offset: 0x000ABF7F
		public int GetMaxOutputSize(int inputLen)
		{
			return this.bufferedCipher.GetOutputSize(inputLen);
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x000ADD8D File Offset: 0x000ABF8D
		public int GetUpdateOutputSize(int inputLen)
		{
			return this.bufferedCipher.GetUpdateOutputSize(inputLen);
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060028F4 RID: 10484 RVA: 0x000ADD9B File Offset: 0x000ABF9B
		public global::System.IO.Stream Stream
		{
			get
			{
				return this.stream;
			}
		}

		// Token: 0x04001098 RID: 4248
		private readonly global::Org.BouncyCastle.Crypto.IBufferedCipher bufferedCipher;

		// Token: 0x04001099 RID: 4249
		private readonly global::Org.BouncyCastle.Crypto.IO.CipherStream stream;
	}
}
