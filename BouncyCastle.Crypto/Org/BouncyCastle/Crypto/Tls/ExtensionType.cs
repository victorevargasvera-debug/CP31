using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000330 RID: 816
	public abstract class ExtensionType
	{
		// Token: 0x04000D3F RID: 3391
		public const int server_name = 0;

		// Token: 0x04000D40 RID: 3392
		public const int max_fragment_length = 1;

		// Token: 0x04000D41 RID: 3393
		public const int client_certificate_url = 2;

		// Token: 0x04000D42 RID: 3394
		public const int trusted_ca_keys = 3;

		// Token: 0x04000D43 RID: 3395
		public const int truncated_hmac = 4;

		// Token: 0x04000D44 RID: 3396
		public const int status_request = 5;

		// Token: 0x04000D45 RID: 3397
		public const int user_mapping = 6;

		// Token: 0x04000D46 RID: 3398
		public const int client_authz = 7;

		// Token: 0x04000D47 RID: 3399
		public const int server_authz = 8;

		// Token: 0x04000D48 RID: 3400
		public const int cert_type = 9;

		// Token: 0x04000D49 RID: 3401
		public const int supported_groups = 10;

		// Token: 0x04000D4A RID: 3402
		[global::System.Obsolete("Use 'supported_groups' instead")]
		public const int elliptic_curves = 10;

		// Token: 0x04000D4B RID: 3403
		public const int ec_point_formats = 11;

		// Token: 0x04000D4C RID: 3404
		public const int srp = 12;

		// Token: 0x04000D4D RID: 3405
		public const int signature_algorithms = 13;

		// Token: 0x04000D4E RID: 3406
		public const int use_srtp = 14;

		// Token: 0x04000D4F RID: 3407
		public const int heartbeat = 15;

		// Token: 0x04000D50 RID: 3408
		public const int application_layer_protocol_negotiation = 16;

		// Token: 0x04000D51 RID: 3409
		public const int status_request_v2 = 17;

		// Token: 0x04000D52 RID: 3410
		public const int signed_certificate_timestamp = 18;

		// Token: 0x04000D53 RID: 3411
		public const int client_certificate_type = 19;

		// Token: 0x04000D54 RID: 3412
		public const int server_certificate_type = 20;

		// Token: 0x04000D55 RID: 3413
		public const int padding = 21;

		// Token: 0x04000D56 RID: 3414
		public const int encrypt_then_mac = 22;

		// Token: 0x04000D57 RID: 3415
		public const int extended_master_secret = 23;

		// Token: 0x04000D58 RID: 3416
		public static readonly int DRAFT_token_binding = 24;

		// Token: 0x04000D59 RID: 3417
		public const int cached_info = 25;

		// Token: 0x04000D5A RID: 3418
		public const int session_ticket = 35;

		// Token: 0x04000D5B RID: 3419
		public static readonly int negotiated_ff_dhe_groups = 101;

		// Token: 0x04000D5C RID: 3420
		public const int renegotiation_info = 65281;
	}
}
