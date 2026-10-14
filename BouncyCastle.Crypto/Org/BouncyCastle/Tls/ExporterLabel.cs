using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000C6 RID: 198
	public abstract class ExporterLabel
	{
		// Token: 0x0400053C RID: 1340
		public const string client_finished = "client finished";

		// Token: 0x0400053D RID: 1341
		public const string server_finished = "server finished";

		// Token: 0x0400053E RID: 1342
		public const string master_secret = "master secret";

		// Token: 0x0400053F RID: 1343
		public const string key_expansion = "key expansion";

		// Token: 0x04000540 RID: 1344
		public const string client_EAP_encryption = "client EAP encryption";

		// Token: 0x04000541 RID: 1345
		public const string ttls_keying_material = "ttls keying material";

		// Token: 0x04000542 RID: 1346
		public const string ttls_challenge = "ttls challenge";

		// Token: 0x04000543 RID: 1347
		public const string dtls_srtp = "EXTRACTOR-dtls_srtp";

		// Token: 0x04000544 RID: 1348
		public const string extended_master_secret = "extended master secret";

		// Token: 0x04000545 RID: 1349
		public const string token_binding = "EXPORTER-Token-Binding";
	}
}
