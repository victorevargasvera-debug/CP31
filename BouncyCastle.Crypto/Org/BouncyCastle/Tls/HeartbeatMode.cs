using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000CF RID: 207
	public abstract class HeartbeatMode
	{
		// Token: 0x06000793 RID: 1939 RVA: 0x000205A3 File Offset: 0x0001E7A3
		public static string GetName(short heartbeatMode)
		{
			if (heartbeatMode == 1)
			{
				return "peer_allowed_to_send";
			}
			if (heartbeatMode != 2)
			{
				return "UNKNOWN";
			}
			return "peer_not_allowed_to_send";
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000205C0 File Offset: 0x0001E7C0
		public static string GetText(short heartbeatMode)
		{
			return global::Org.BouncyCastle.Tls.HeartbeatMode.GetName(heartbeatMode) + "(" + heartbeatMode.ToString() + ")";
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000205DE File Offset: 0x0001E7DE
		public static bool IsValid(short heartbeatMode)
		{
			return heartbeatMode >= 1 && heartbeatMode <= 2;
		}

		// Token: 0x04000590 RID: 1424
		public const short peer_allowed_to_send = 1;

		// Token: 0x04000591 RID: 1425
		public const short peer_not_allowed_to_send = 2;
	}
}
