using System;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;

namespace Org.BouncyCastle.Crmf
{
	// Token: 0x02000512 RID: 1298
	internal class PKMacStreamCalculator : global::Org.BouncyCastle.Crypto.IStreamCalculator
	{
		// Token: 0x060032A3 RID: 12963 RVA: 0x000F267D File Offset: 0x000F087D
		public PKMacStreamCalculator(global::Org.BouncyCastle.Crypto.IMac mac)
		{
			this._stream = new global::Org.BouncyCastle.Crypto.IO.MacSink(mac);
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060032A4 RID: 12964 RVA: 0x000F2691 File Offset: 0x000F0891
		public global::System.IO.Stream Stream
		{
			get
			{
				return this._stream;
			}
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x000F2699 File Offset: 0x000F0899
		public object GetResult()
		{
			return new global::Org.BouncyCastle.Crmf.DefaultPKMacResult(this._stream.Mac);
		}

		// Token: 0x0400167F RID: 5759
		private readonly global::Org.BouncyCastle.Crypto.IO.MacSink _stream;
	}
}
