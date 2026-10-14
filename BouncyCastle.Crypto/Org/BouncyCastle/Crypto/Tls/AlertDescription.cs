using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002FD RID: 765
	public abstract class AlertDescription
	{
		// Token: 0x060020C6 RID: 8390 RVA: 0x00091D6C File Offset: 0x0008FF6C
		public static string GetName(byte alertDescription)
		{
			if (alertDescription <= 70)
			{
				if (alertDescription <= 22)
				{
					if (alertDescription == 0)
					{
						return "close_notify";
					}
					if (alertDescription == 10)
					{
						return "unexpected_message";
					}
					switch (alertDescription)
					{
					case 20:
						return "bad_record_mac";
					case 21:
						return "decryption_failed";
					case 22:
						return "record_overflow";
					}
				}
				else
				{
					switch (alertDescription)
					{
					case 30:
						return "decompression_failure";
					case 31:
					case 32:
					case 33:
					case 34:
					case 35:
					case 36:
					case 37:
					case 38:
					case 39:
						break;
					case 40:
						return "handshake_failure";
					case 41:
						return "no_certificate";
					case 42:
						return "bad_certificate";
					case 43:
						return "unsupported_certificate";
					case 44:
						return "certificate_revoked";
					case 45:
						return "certificate_expired";
					case 46:
						return "certificate_unknown";
					case 47:
						return "illegal_parameter";
					case 48:
						return "unknown_ca";
					case 49:
						return "access_denied";
					case 50:
						return "decode_error";
					case 51:
						return "decrypt_error";
					default:
						if (alertDescription == 60)
						{
							return "export_restriction";
						}
						if (alertDescription == 70)
						{
							return "protocol_version";
						}
						break;
					}
				}
			}
			else if (alertDescription <= 86)
			{
				if (alertDescription == 71)
				{
					return "insufficient_security";
				}
				if (alertDescription == 80)
				{
					return "internal_error";
				}
				if (alertDescription == 86)
				{
					return "inappropriate_fallback";
				}
			}
			else
			{
				if (alertDescription == 90)
				{
					return "user_canceled";
				}
				if (alertDescription == 100)
				{
					return "no_renegotiation";
				}
				switch (alertDescription)
				{
				case 110:
					return "unsupported_extension";
				case 111:
					return "certificate_unobtainable";
				case 112:
					return "unrecognized_name";
				case 113:
					return "bad_certificate_status_response";
				case 114:
					return "bad_certificate_hash_value";
				case 115:
					return "unknown_psk_identity";
				}
			}
			return "UNKNOWN";
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x00091F3B File Offset: 0x0009013B
		public static string GetText(byte alertDescription)
		{
			return global::Org.BouncyCastle.Crypto.Tls.AlertDescription.GetName(alertDescription) + "(" + alertDescription.ToString() + ")";
		}

		// Token: 0x04000B64 RID: 2916
		public const byte close_notify = 0;

		// Token: 0x04000B65 RID: 2917
		public const byte unexpected_message = 10;

		// Token: 0x04000B66 RID: 2918
		public const byte bad_record_mac = 20;

		// Token: 0x04000B67 RID: 2919
		public const byte decryption_failed = 21;

		// Token: 0x04000B68 RID: 2920
		public const byte record_overflow = 22;

		// Token: 0x04000B69 RID: 2921
		public const byte decompression_failure = 30;

		// Token: 0x04000B6A RID: 2922
		public const byte handshake_failure = 40;

		// Token: 0x04000B6B RID: 2923
		public const byte no_certificate = 41;

		// Token: 0x04000B6C RID: 2924
		public const byte bad_certificate = 42;

		// Token: 0x04000B6D RID: 2925
		public const byte unsupported_certificate = 43;

		// Token: 0x04000B6E RID: 2926
		public const byte certificate_revoked = 44;

		// Token: 0x04000B6F RID: 2927
		public const byte certificate_expired = 45;

		// Token: 0x04000B70 RID: 2928
		public const byte certificate_unknown = 46;

		// Token: 0x04000B71 RID: 2929
		public const byte illegal_parameter = 47;

		// Token: 0x04000B72 RID: 2930
		public const byte unknown_ca = 48;

		// Token: 0x04000B73 RID: 2931
		public const byte access_denied = 49;

		// Token: 0x04000B74 RID: 2932
		public const byte decode_error = 50;

		// Token: 0x04000B75 RID: 2933
		public const byte decrypt_error = 51;

		// Token: 0x04000B76 RID: 2934
		public const byte export_restriction = 60;

		// Token: 0x04000B77 RID: 2935
		public const byte protocol_version = 70;

		// Token: 0x04000B78 RID: 2936
		public const byte insufficient_security = 71;

		// Token: 0x04000B79 RID: 2937
		public const byte internal_error = 80;

		// Token: 0x04000B7A RID: 2938
		public const byte user_canceled = 90;

		// Token: 0x04000B7B RID: 2939
		public const byte no_renegotiation = 100;

		// Token: 0x04000B7C RID: 2940
		public const byte unsupported_extension = 110;

		// Token: 0x04000B7D RID: 2941
		public const byte certificate_unobtainable = 111;

		// Token: 0x04000B7E RID: 2942
		public const byte unrecognized_name = 112;

		// Token: 0x04000B7F RID: 2943
		public const byte bad_certificate_status_response = 113;

		// Token: 0x04000B80 RID: 2944
		public const byte bad_certificate_hash_value = 114;

		// Token: 0x04000B81 RID: 2945
		public const byte unknown_psk_identity = 115;

		// Token: 0x04000B82 RID: 2946
		public const byte inappropriate_fallback = 86;
	}
}
