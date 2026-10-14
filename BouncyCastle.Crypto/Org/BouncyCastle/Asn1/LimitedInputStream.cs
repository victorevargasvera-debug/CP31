using System;
using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200062B RID: 1579
	internal abstract class LimitedInputStream : global::Org.BouncyCastle.Utilities.IO.BaseInputStream
	{
		// Token: 0x06003AB6 RID: 15030 RVA: 0x0010F658 File Offset: 0x0010D858
		internal LimitedInputStream(global::System.IO.Stream inStream, int limit)
		{
			this._in = inStream;
			this._limit = limit;
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06003AB7 RID: 15031 RVA: 0x0010F66E File Offset: 0x0010D86E
		internal virtual int Limit
		{
			get
			{
				return this._limit;
			}
		}

		// Token: 0x06003AB8 RID: 15032 RVA: 0x0010F676 File Offset: 0x0010D876
		protected virtual void SetParentEofDetect(bool on)
		{
			if (this._in is global::Org.BouncyCastle.Asn1.IndefiniteLengthInputStream)
			{
				((global::Org.BouncyCastle.Asn1.IndefiniteLengthInputStream)this._in).SetEofOn00(on);
			}
		}

		// Token: 0x040019B7 RID: 6583
		protected readonly global::System.IO.Stream _in;

		// Token: 0x040019B8 RID: 6584
		private int _limit;
	}
}
