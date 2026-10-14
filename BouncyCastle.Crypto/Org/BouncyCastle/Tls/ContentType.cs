using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000A9 RID: 169
	public abstract class ContentType
	{
		// Token: 0x0600068B RID: 1675 RVA: 0x0001B220 File Offset: 0x00019420
		public static string GetName(short contentType)
		{
			switch (contentType)
			{
			case 20:
				return "change_cipher_spec";
			case 21:
				return "alert";
			case 22:
				return "handshake";
			case 23:
				return "application_data";
			case 24:
				return "heartbeat";
			default:
				return "UNKNOWN";
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0001B26F File Offset: 0x0001946F
		public static string GetText(short contentType)
		{
			return global::Org.BouncyCastle.Tls.ContentType.GetName(contentType) + "(" + contentType.ToString() + ")";
		}

		// Token: 0x040004C0 RID: 1216
		public const short change_cipher_spec = 20;

		// Token: 0x040004C1 RID: 1217
		public const short alert = 21;

		// Token: 0x040004C2 RID: 1218
		public const short handshake = 22;

		// Token: 0x040004C3 RID: 1219
		public const short application_data = 23;

		// Token: 0x040004C4 RID: 1220
		public const short heartbeat = 24;
	}
}
