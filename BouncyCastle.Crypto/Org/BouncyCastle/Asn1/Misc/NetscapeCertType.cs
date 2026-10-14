using System;

namespace Org.BouncyCastle.Asn1.Misc
{
	// Token: 0x020006E0 RID: 1760
	public class NetscapeCertType : global::Org.BouncyCastle.Asn1.DerBitString
	{
		// Token: 0x0600400C RID: 16396 RVA: 0x00122A75 File Offset: 0x00120C75
		public NetscapeCertType(int usage) : base(usage)
		{
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x00122A7E File Offset: 0x00120C7E
		public NetscapeCertType(global::Org.BouncyCastle.Asn1.DerBitString usage) : base(usage.GetBytes(), usage.PadBits)
		{
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x00122A94 File Offset: 0x00120C94
		public override string ToString()
		{
			byte[] data = this.GetBytes();
			return "NetscapeCertType: 0x" + ((int)(data[0] & byte.MaxValue)).ToString("X");
		}

		// Token: 0x04001E34 RID: 7732
		public const int SslClient = 128;

		// Token: 0x04001E35 RID: 7733
		public const int SslServer = 64;

		// Token: 0x04001E36 RID: 7734
		public const int Smime = 32;

		// Token: 0x04001E37 RID: 7735
		public const int ObjectSigning = 16;

		// Token: 0x04001E38 RID: 7736
		public const int Reserved = 8;

		// Token: 0x04001E39 RID: 7737
		public const int SslCA = 4;

		// Token: 0x04001E3A RID: 7738
		public const int SmimeCA = 2;

		// Token: 0x04001E3B RID: 7739
		public const int ObjectSigningCA = 1;
	}
}
