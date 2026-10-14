using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200032F RID: 815
	public abstract class ExporterLabel
	{
		// Token: 0x04000D36 RID: 3382
		public const string client_finished = "client finished";

		// Token: 0x04000D37 RID: 3383
		public const string server_finished = "server finished";

		// Token: 0x04000D38 RID: 3384
		public const string master_secret = "master secret";

		// Token: 0x04000D39 RID: 3385
		public const string key_expansion = "key expansion";

		// Token: 0x04000D3A RID: 3386
		public const string client_EAP_encryption = "client EAP encryption";

		// Token: 0x04000D3B RID: 3387
		public const string ttls_keying_material = "ttls keying material";

		// Token: 0x04000D3C RID: 3388
		public const string ttls_challenge = "ttls challenge";

		// Token: 0x04000D3D RID: 3389
		public const string dtls_srtp = "EXTRACTOR-dtls_srtp";

		// Token: 0x04000D3E RID: 3390
		public static readonly string extended_master_secret = "extended master secret";
	}
}
