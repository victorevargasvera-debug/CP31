using System;
using System.IO;
using Org.BouncyCastle.Crypto.IO;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x0200041F RID: 1055
	internal class DfDigestStream : global::Org.BouncyCastle.Crypto.IStreamCalculator
	{
		// Token: 0x060028FB RID: 10491 RVA: 0x000ADE11 File Offset: 0x000AC011
		public DfDigestStream(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.mStream = new global::Org.BouncyCastle.Crypto.IO.DigestSink(digest);
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060028FC RID: 10492 RVA: 0x000ADE25 File Offset: 0x000AC025
		public global::System.IO.Stream Stream
		{
			get
			{
				return this.mStream;
			}
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x000ADE30 File Offset: 0x000AC030
		public object GetResult()
		{
			byte[] result = new byte[this.mStream.Digest.GetDigestSize()];
			this.mStream.Digest.DoFinal(result, 0);
			return new global::Org.BouncyCastle.Crypto.SimpleBlockResult(result);
		}

		// Token: 0x0400109C RID: 4252
		private readonly global::Org.BouncyCastle.Crypto.IO.DigestSink mStream;
	}
}
