using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000336 RID: 822
	public abstract class HeartbeatMessageType
	{
		// Token: 0x06002231 RID: 8753 RVA: 0x000977AA File Offset: 0x000959AA
		public static bool IsValid(byte heartbeatMessageType)
		{
			return heartbeatMessageType >= 1 && heartbeatMessageType <= 2;
		}

		// Token: 0x04000D7C RID: 3452
		public const byte heartbeat_request = 1;

		// Token: 0x04000D7D RID: 3453
		public const byte heartbeat_response = 2;
	}
}
