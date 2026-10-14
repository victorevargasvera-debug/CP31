using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000B5 RID: 181
	internal class DigestInputBuffer : global::System.IO.MemoryStream
	{
		// Token: 0x060006DA RID: 1754 RVA: 0x0001BD0A File Offset: 0x00019F0A
		internal void UpdateDigest(global::Org.BouncyCastle.Tls.Crypto.TlsHash hash)
		{
			global::Org.BouncyCastle.Utilities.IO.Streams.WriteBufTo(this, new global::Org.BouncyCastle.Tls.Crypto.TlsHashSink(hash));
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0001BD18 File Offset: 0x00019F18
		internal new void CopyTo(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Utilities.IO.Streams.WriteBufTo(this, output);
		}
	}
}
