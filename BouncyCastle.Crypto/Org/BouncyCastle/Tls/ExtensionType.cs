using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000C7 RID: 199
	public abstract class ExtensionType
	{
		// Token: 0x06000768 RID: 1896 RVA: 0x0001FC1C File Offset: 0x0001DE1C
		public static string GetName(int extensionType)
		{
			switch (extensionType)
			{
			case 0:
				return "server_name";
			case 1:
				return "max_fragment_length";
			case 2:
				return "client_certificate_url";
			case 3:
				return "trusted_ca_keys";
			case 4:
				return "truncated_hmac";
			case 5:
				return "status_request";
			case 6:
				return "user_mapping";
			case 7:
				return "client_authz";
			case 8:
				return "server_authz";
			case 9:
				return "cert_type";
			case 10:
				return "supported_groups";
			case 11:
				return "ec_point_formats";
			case 12:
				return "srp";
			case 13:
				return "signature_algorithms";
			case 14:
				return "use_srtp";
			case 15:
				return "heartbeat";
			case 16:
				return "application_layer_protocol_negotiation";
			case 17:
				return "status_request_v2";
			case 18:
				return "signed_certificate_timestamp";
			case 19:
				return "client_certificate_type";
			case 20:
				return "server_certificate_type";
			case 21:
				return "padding";
			case 22:
				return "encrypt_then_mac";
			case 23:
				return "extended_master_secret";
			case 24:
				return "token_binding";
			case 25:
				return "cached_info";
			case 26:
			case 27:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 36:
			case 37:
			case 38:
			case 39:
			case 40:
			case 46:
				break;
			case 28:
				return "record_size_limit";
			case 35:
				return "session_ticket";
			case 41:
				return "pre_shared_key";
			case 42:
				return "early_data";
			case 43:
				return "supported_versions";
			case 44:
				return "cookie";
			case 45:
				return "psk_key_exchange_modes";
			case 47:
				return "certificate_authorities";
			case 48:
				return "oid_filters";
			case 49:
				return "post_handshake_auth";
			case 50:
				return "signature_algorithms_cert";
			case 51:
				return "key_share";
			default:
				if (extensionType == 65281)
				{
					return "renegotiation_info";
				}
				break;
			}
			return "UNKNOWN";
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0001FDFE File Offset: 0x0001DFFE
		public static string GetText(int extensionType)
		{
			return global::Org.BouncyCastle.Tls.ExtensionType.GetName(extensionType) + "(" + extensionType.ToString() + ")";
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0001FE1C File Offset: 0x0001E01C
		public static bool IsRecognized(int extensionType)
		{
			switch (extensionType)
			{
			case 0:
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
			case 11:
			case 12:
			case 13:
			case 14:
			case 15:
			case 16:
			case 17:
			case 18:
			case 19:
			case 20:
			case 21:
			case 22:
			case 23:
			case 24:
			case 25:
			case 28:
			case 35:
			case 41:
			case 42:
			case 43:
			case 44:
			case 45:
			case 47:
			case 48:
			case 49:
			case 50:
			case 51:
				break;
			case 26:
			case 27:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 36:
			case 37:
			case 38:
			case 39:
			case 40:
			case 46:
				return false;
			default:
				if (extensionType != 65281)
				{
					return false;
				}
				break;
			}
			return true;
		}

		// Token: 0x04000546 RID: 1350
		public const int server_name = 0;

		// Token: 0x04000547 RID: 1351
		public const int max_fragment_length = 1;

		// Token: 0x04000548 RID: 1352
		public const int client_certificate_url = 2;

		// Token: 0x04000549 RID: 1353
		public const int trusted_ca_keys = 3;

		// Token: 0x0400054A RID: 1354
		public const int truncated_hmac = 4;

		// Token: 0x0400054B RID: 1355
		public const int status_request = 5;

		// Token: 0x0400054C RID: 1356
		public const int user_mapping = 6;

		// Token: 0x0400054D RID: 1357
		public const int client_authz = 7;

		// Token: 0x0400054E RID: 1358
		public const int server_authz = 8;

		// Token: 0x0400054F RID: 1359
		public const int cert_type = 9;

		// Token: 0x04000550 RID: 1360
		public const int supported_groups = 10;

		// Token: 0x04000551 RID: 1361
		public const int ec_point_formats = 11;

		// Token: 0x04000552 RID: 1362
		public const int srp = 12;

		// Token: 0x04000553 RID: 1363
		public const int signature_algorithms = 13;

		// Token: 0x04000554 RID: 1364
		public const int use_srtp = 14;

		// Token: 0x04000555 RID: 1365
		public const int heartbeat = 15;

		// Token: 0x04000556 RID: 1366
		public const int application_layer_protocol_negotiation = 16;

		// Token: 0x04000557 RID: 1367
		public const int status_request_v2 = 17;

		// Token: 0x04000558 RID: 1368
		public const int signed_certificate_timestamp = 18;

		// Token: 0x04000559 RID: 1369
		public const int client_certificate_type = 19;

		// Token: 0x0400055A RID: 1370
		public const int server_certificate_type = 20;

		// Token: 0x0400055B RID: 1371
		public const int padding = 21;

		// Token: 0x0400055C RID: 1372
		public const int encrypt_then_mac = 22;

		// Token: 0x0400055D RID: 1373
		public const int extended_master_secret = 23;

		// Token: 0x0400055E RID: 1374
		public const int token_binding = 24;

		// Token: 0x0400055F RID: 1375
		public const int cached_info = 25;

		// Token: 0x04000560 RID: 1376
		public const int record_size_limit = 28;

		// Token: 0x04000561 RID: 1377
		public const int session_ticket = 35;

		// Token: 0x04000562 RID: 1378
		public const int pre_shared_key = 41;

		// Token: 0x04000563 RID: 1379
		public const int early_data = 42;

		// Token: 0x04000564 RID: 1380
		public const int supported_versions = 43;

		// Token: 0x04000565 RID: 1381
		public const int cookie = 44;

		// Token: 0x04000566 RID: 1382
		public const int psk_key_exchange_modes = 45;

		// Token: 0x04000567 RID: 1383
		public const int certificate_authorities = 47;

		// Token: 0x04000568 RID: 1384
		public const int oid_filters = 48;

		// Token: 0x04000569 RID: 1385
		public const int post_handshake_auth = 49;

		// Token: 0x0400056A RID: 1386
		public const int signature_algorithms_cert = 50;

		// Token: 0x0400056B RID: 1387
		public const int key_share = 51;

		// Token: 0x0400056C RID: 1388
		public const int renegotiation_info = 65281;
	}
}
