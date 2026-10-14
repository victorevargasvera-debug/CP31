using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000CA RID: 202
	public abstract class HandshakeType
	{
		// Token: 0x06000777 RID: 1911 RVA: 0x000200B8 File Offset: 0x0001E2B8
		public static string GetName(short handshakeType)
		{
			switch (handshakeType)
			{
			case 0:
				return "hello_request";
			case 1:
				return "client_hello";
			case 2:
				return "server_hello";
			case 3:
				return "hello_verify_request";
			case 4:
				return "new_session_ticket";
			case 5:
				return "end_of_early_data";
			case 6:
				return "hello_retry_request";
			case 7:
			case 9:
			case 10:
			case 17:
			case 18:
			case 19:
				break;
			case 8:
				return "encrypted_extensions";
			case 11:
				return "certificate";
			case 12:
				return "server_key_exchange";
			case 13:
				return "certificate_request";
			case 14:
				return "server_hello_done";
			case 15:
				return "certificate_verify";
			case 16:
				return "client_key_exchange";
			case 20:
				return "finished";
			case 21:
				return "certificate_url";
			case 22:
				return "certificate_status";
			case 23:
				return "supplemental_data";
			case 24:
				return "key_update";
			default:
				if (handshakeType == 254)
				{
					return "message_hash";
				}
				break;
			}
			return "UNKNOWN";
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x000201B6 File Offset: 0x0001E3B6
		public static string GetText(short handshakeType)
		{
			return global::Org.BouncyCastle.Tls.HandshakeType.GetName(handshakeType) + "(" + handshakeType.ToString() + ")";
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x000201D4 File Offset: 0x0001E3D4
		public static bool IsRecognized(short handshakeType)
		{
			switch (handshakeType)
			{
			case 0:
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 8:
			case 11:
			case 12:
			case 13:
			case 14:
			case 15:
			case 16:
			case 20:
			case 21:
			case 22:
			case 23:
			case 24:
				break;
			case 7:
			case 9:
			case 10:
			case 17:
			case 18:
			case 19:
				return false;
			default:
				if (handshakeType != 254)
				{
					return false;
				}
				break;
			}
			return true;
		}

		// Token: 0x0400056E RID: 1390
		public const short hello_request = 0;

		// Token: 0x0400056F RID: 1391
		public const short client_hello = 1;

		// Token: 0x04000570 RID: 1392
		public const short server_hello = 2;

		// Token: 0x04000571 RID: 1393
		public const short certificate = 11;

		// Token: 0x04000572 RID: 1394
		public const short server_key_exchange = 12;

		// Token: 0x04000573 RID: 1395
		public const short certificate_request = 13;

		// Token: 0x04000574 RID: 1396
		public const short server_hello_done = 14;

		// Token: 0x04000575 RID: 1397
		public const short certificate_verify = 15;

		// Token: 0x04000576 RID: 1398
		public const short client_key_exchange = 16;

		// Token: 0x04000577 RID: 1399
		public const short finished = 20;

		// Token: 0x04000578 RID: 1400
		public const short certificate_url = 21;

		// Token: 0x04000579 RID: 1401
		public const short certificate_status = 22;

		// Token: 0x0400057A RID: 1402
		public const short hello_verify_request = 3;

		// Token: 0x0400057B RID: 1403
		public const short supplemental_data = 23;

		// Token: 0x0400057C RID: 1404
		public const short new_session_ticket = 4;

		// Token: 0x0400057D RID: 1405
		public const short end_of_early_data = 5;

		// Token: 0x0400057E RID: 1406
		public const short hello_retry_request = 6;

		// Token: 0x0400057F RID: 1407
		public const short encrypted_extensions = 8;

		// Token: 0x04000580 RID: 1408
		public const short key_update = 24;

		// Token: 0x04000581 RID: 1409
		public const short message_hash = 254;
	}
}
