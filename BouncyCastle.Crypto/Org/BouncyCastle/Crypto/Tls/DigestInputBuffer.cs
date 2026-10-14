using System;
using System.IO;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200031F RID: 799
	internal class DigestInputBuffer : global::System.IO.MemoryStream
	{
		// Token: 0x060021A3 RID: 8611 RVA: 0x000942CD File Offset: 0x000924CD
		internal void UpdateDigest(global::Org.BouncyCastle.Crypto.IDigest d)
		{
			global::Org.BouncyCastle.Utilities.IO.Streams.WriteBufTo(this, new global::Org.BouncyCastle.Crypto.IO.DigestSink(d));
		}
	}
}
