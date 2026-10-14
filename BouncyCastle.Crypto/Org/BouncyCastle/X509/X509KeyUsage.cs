using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200001B RID: 27
	public class X509KeyUsage : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06000130 RID: 304 RVA: 0x000087EA File Offset: 0x000069EA
		public X509KeyUsage(int usage)
		{
			this.usage = usage;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000087F9 File Offset: 0x000069F9
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.X509.KeyUsage(this.usage);
		}

		// Token: 0x040000A1 RID: 161
		public const int DigitalSignature = 128;

		// Token: 0x040000A2 RID: 162
		public const int NonRepudiation = 64;

		// Token: 0x040000A3 RID: 163
		public const int KeyEncipherment = 32;

		// Token: 0x040000A4 RID: 164
		public const int DataEncipherment = 16;

		// Token: 0x040000A5 RID: 165
		public const int KeyAgreement = 8;

		// Token: 0x040000A6 RID: 166
		public const int KeyCertSign = 4;

		// Token: 0x040000A7 RID: 167
		public const int CrlSign = 2;

		// Token: 0x040000A8 RID: 168
		public const int EncipherOnly = 1;

		// Token: 0x040000A9 RID: 169
		public const int DecipherOnly = 32768;

		// Token: 0x040000AA RID: 170
		private readonly int usage;
	}
}
