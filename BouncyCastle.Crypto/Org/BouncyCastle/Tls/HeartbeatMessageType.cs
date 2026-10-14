using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000CE RID: 206
	public abstract class HeartbeatMessageType
	{
		// Token: 0x0600078F RID: 1935 RVA: 0x00020551 File Offset: 0x0001E751
		public static string GetName(short heartbeatMessageType)
		{
			if (heartbeatMessageType == 1)
			{
				return "heartbeat_request";
			}
			if (heartbeatMessageType != 2)
			{
				return "UNKNOWN";
			}
			return "heartbeat_response";
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0002056E File Offset: 0x0001E76E
		public static string GetText(short heartbeatMessageType)
		{
			return global::Org.BouncyCastle.Tls.HeartbeatMessageType.GetName(heartbeatMessageType) + "(" + heartbeatMessageType.ToString() + ")";
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0002058C File Offset: 0x0001E78C
		public static bool IsValid(short heartbeatMessageType)
		{
			return heartbeatMessageType >= 1 && heartbeatMessageType <= 2;
		}

		// Token: 0x0400058E RID: 1422
		public const short heartbeat_request = 1;

		// Token: 0x0400058F RID: 1423
		public const short heartbeat_response = 2;
	}
}
