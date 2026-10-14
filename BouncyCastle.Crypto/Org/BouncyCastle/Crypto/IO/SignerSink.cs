using System;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.IO
{
	// Token: 0x0200045F RID: 1119
	public class SignerSink : global::Org.BouncyCastle.Utilities.IO.BaseOutputStream
	{
		// Token: 0x06002B6F RID: 11119 RVA: 0x000BA343 File Offset: 0x000B8543
		public SignerSink(global::Org.BouncyCastle.Crypto.ISigner signer)
		{
			this.mSigner = signer;
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06002B70 RID: 11120 RVA: 0x000BA352 File Offset: 0x000B8552
		public virtual global::Org.BouncyCastle.Crypto.ISigner Signer
		{
			get
			{
				return this.mSigner;
			}
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x000BA35A File Offset: 0x000B855A
		public override void WriteByte(byte b)
		{
			this.mSigner.Update(b);
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x000BA368 File Offset: 0x000B8568
		public override void Write(byte[] buf, int off, int len)
		{
			if (len > 0)
			{
				this.mSigner.BlockUpdate(buf, off, len);
			}
		}

		// Token: 0x040011FB RID: 4603
		private readonly global::Org.BouncyCastle.Crypto.ISigner mSigner;
	}
}
