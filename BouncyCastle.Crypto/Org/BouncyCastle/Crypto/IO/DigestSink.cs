using System;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.IO
{
	// Token: 0x0200045B RID: 1115
	public class DigestSink : global::Org.BouncyCastle.Utilities.IO.BaseOutputStream
	{
		// Token: 0x06002B45 RID: 11077 RVA: 0x000B9FEC File Offset: 0x000B81EC
		public DigestSink(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.mDigest = digest;
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x000B9FFB File Offset: 0x000B81FB
		public virtual global::Org.BouncyCastle.Crypto.IDigest Digest
		{
			get
			{
				return this.mDigest;
			}
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x000BA003 File Offset: 0x000B8203
		public override void WriteByte(byte b)
		{
			this.mDigest.Update(b);
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x000BA011 File Offset: 0x000B8211
		public override void Write(byte[] buf, int off, int len)
		{
			if (len > 0)
			{
				this.mDigest.BlockUpdate(buf, off, len);
			}
		}

		// Token: 0x040011F3 RID: 4595
		private readonly global::Org.BouncyCastle.Crypto.IDigest mDigest;
	}
}
