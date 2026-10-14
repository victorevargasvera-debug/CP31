using System;
using System.IO;
using Org.BouncyCastle.Crypto.IO;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x0200042C RID: 1068
	public class DefaultSignatureCalculator : global::Org.BouncyCastle.Crypto.IStreamCalculator
	{
		// Token: 0x06002931 RID: 10545 RVA: 0x000AEF18 File Offset: 0x000AD118
		public DefaultSignatureCalculator(global::Org.BouncyCastle.Crypto.ISigner signer)
		{
			this.mSignerSink = new global::Org.BouncyCastle.Crypto.IO.SignerSink(signer);
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06002932 RID: 10546 RVA: 0x000AEF2C File Offset: 0x000AD12C
		public global::System.IO.Stream Stream
		{
			get
			{
				return this.mSignerSink;
			}
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x000AEF34 File Offset: 0x000AD134
		public object GetResult()
		{
			return new global::Org.BouncyCastle.Crypto.Operators.DefaultSignatureResult(this.mSignerSink.Signer);
		}

		// Token: 0x040010B3 RID: 4275
		private readonly global::Org.BouncyCastle.Crypto.IO.SignerSink mSignerSink;
	}
}
