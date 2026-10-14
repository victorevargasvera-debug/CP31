using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000337 RID: 823
	public abstract class HeartbeatMode
	{
		// Token: 0x06002233 RID: 8755 RVA: 0x000977C1 File Offset: 0x000959C1
		public static bool IsValid(byte heartbeatMode)
		{
			return heartbeatMode >= 1 && heartbeatMode <= 2;
		}

		// Token: 0x04000D7E RID: 3454
		public const byte peer_allowed_to_send = 1;

		// Token: 0x04000D7F RID: 3455
		public const byte peer_not_allowed_to_send = 2;
	}
}
