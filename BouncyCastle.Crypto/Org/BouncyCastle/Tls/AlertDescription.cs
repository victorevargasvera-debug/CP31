using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200008C RID: 140
	public abstract class AlertDescription
	{
		// Token: 0x060005F8 RID: 1528 RVA: 0x00019594 File Offset: 0x00017794
		public static string GetName(short alertDescription)
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
				switch (alertDescription)
				{
				case 100:
					return "no_renegotiation";
				case 101:
				case 102:
				case 103:
				case 104:
				case 105:
				case 106:
				case 107:
				case 108:
					break;
				case 109:
					return "missing_extension";
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
				case 116:
					return "certificate_required";
				default:
					if (alertDescription == 120)
					{
						return "no_application_protocol";
					}
					break;
				}
			}
			return "UNKNOWN";
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000197A1 File Offset: 0x000179A1
		public static string GetText(short alertDescription)
		{
			return global::Org.BouncyCastle.Tls.AlertDescription.GetName(alertDescription) + "(" + alertDescription.ToString() + ")";
		}

		// Token: 0x04000306 RID: 774
		public const short close_notify = 0;

		// Token: 0x04000307 RID: 775
		public const short unexpected_message = 10;

		// Token: 0x04000308 RID: 776
		public const short bad_record_mac = 20;

		// Token: 0x04000309 RID: 777
		public const short decryption_failed = 21;

		// Token: 0x0400030A RID: 778
		public const short record_overflow = 22;

		// Token: 0x0400030B RID: 779
		public const short decompression_failure = 30;

		// Token: 0x0400030C RID: 780
		public const short handshake_failure = 40;

		// Token: 0x0400030D RID: 781
		public const short no_certificate = 41;

		// Token: 0x0400030E RID: 782
		public const short bad_certificate = 42;

		// Token: 0x0400030F RID: 783
		public const short unsupported_certificate = 43;

		// Token: 0x04000310 RID: 784
		public const short certificate_revoked = 44;

		// Token: 0x04000311 RID: 785
		public const short certificate_expired = 45;

		// Token: 0x04000312 RID: 786
		public const short certificate_unknown = 46;

		// Token: 0x04000313 RID: 787
		public const short illegal_parameter = 47;

		// Token: 0x04000314 RID: 788
		public const short unknown_ca = 48;

		// Token: 0x04000315 RID: 789
		public const short access_denied = 49;

		// Token: 0x04000316 RID: 790
		public const short decode_error = 50;

		// Token: 0x04000317 RID: 791
		public const short decrypt_error = 51;

		// Token: 0x04000318 RID: 792
		public const short export_restriction = 60;

		// Token: 0x04000319 RID: 793
		public const short protocol_version = 70;

		// Token: 0x0400031A RID: 794
		public const short insufficient_security = 71;

		// Token: 0x0400031B RID: 795
		public const short internal_error = 80;

		// Token: 0x0400031C RID: 796
		public const short user_canceled = 90;

		// Token: 0x0400031D RID: 797
		public const short no_renegotiation = 100;

		// Token: 0x0400031E RID: 798
		public const short unsupported_extension = 110;

		// Token: 0x0400031F RID: 799
		public const short certificate_unobtainable = 111;

		// Token: 0x04000320 RID: 800
		public const short unrecognized_name = 112;

		// Token: 0x04000321 RID: 801
		public const short bad_certificate_status_response = 113;

		// Token: 0x04000322 RID: 802
		public const short bad_certificate_hash_value = 114;

		// Token: 0x04000323 RID: 803
		public const short unknown_psk_identity = 115;

		// Token: 0x04000324 RID: 804
		public const short no_application_protocol = 120;

		// Token: 0x04000325 RID: 805
		public const short inappropriate_fallback = 86;

		// Token: 0x04000326 RID: 806
		public const short missing_extension = 109;

		// Token: 0x04000327 RID: 807
		public const short certificate_required = 116;
	}
}
