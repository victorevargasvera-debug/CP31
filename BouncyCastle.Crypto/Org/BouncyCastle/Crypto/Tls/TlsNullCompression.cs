using System;
using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000378 RID: 888
	public class TlsNullCompression : global::Org.BouncyCastle.Crypto.Tls.TlsCompression
	{
		// Token: 0x0600240D RID: 9229 RVA: 0x0009CE56 File Offset: 0x0009B056
		public virtual global::System.IO.Stream Compress(global::System.IO.Stream output)
		{
			return output;
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x0009CE59 File Offset: 0x0009B059
		public virtual global::System.IO.Stream Decompress(global::System.IO.Stream output)
		{
			return output;
		}
	}
}
