using System;
using System.IO;
using Org.BouncyCastle.Crypto.IO;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x0200042E RID: 1070
	public class DefaultVerifierCalculator : global::Org.BouncyCastle.Crypto.IStreamCalculator
	{
		// Token: 0x06002937 RID: 10551 RVA: 0x000AEF74 File Offset: 0x000AD174
		public DefaultVerifierCalculator(global::Org.BouncyCastle.Crypto.ISigner signer)
		{
			this.mSignerSink = new global::Org.BouncyCastle.Crypto.IO.SignerSink(signer);
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06002938 RID: 10552 RVA: 0x000AEF88 File Offset: 0x000AD188
		public global::System.IO.Stream Stream
		{
			get
			{
				return this.mSignerSink;
			}
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x000AEF90 File Offset: 0x000AD190
		public object GetResult()
		{
			return new global::Org.BouncyCastle.Crypto.Operators.DefaultVerifierResult(this.mSignerSink.Signer);
		}

		// Token: 0x040010B5 RID: 4277
		private readonly global::Org.BouncyCastle.Crypto.IO.SignerSink mSignerSink;
	}
}
