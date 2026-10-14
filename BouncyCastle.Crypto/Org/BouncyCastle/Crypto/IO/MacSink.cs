using System;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.IO
{
	// Token: 0x0200045D RID: 1117
	public class MacSink : global::Org.BouncyCastle.Utilities.IO.BaseOutputStream
	{
		// Token: 0x06002B5A RID: 11098 RVA: 0x000BA197 File Offset: 0x000B8397
		public MacSink(global::Org.BouncyCastle.Crypto.IMac mac)
		{
			this.mMac = mac;
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06002B5B RID: 11099 RVA: 0x000BA1A6 File Offset: 0x000B83A6
		public virtual global::Org.BouncyCastle.Crypto.IMac Mac
		{
			get
			{
				return this.mMac;
			}
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x000BA1AE File Offset: 0x000B83AE
		public override void WriteByte(byte b)
		{
			this.mMac.Update(b);
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x000BA1BC File Offset: 0x000B83BC
		public override void Write(byte[] buf, int off, int len)
		{
			if (len > 0)
			{
				this.mMac.BlockUpdate(buf, off, len);
			}
		}

		// Token: 0x040011F7 RID: 4599
		private readonly global::Org.BouncyCastle.Crypto.IMac mMac;
	}
}
