using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002FE RID: 766
	public abstract class AlertLevel
	{
		// Token: 0x060020C9 RID: 8393 RVA: 0x00091F61 File Offset: 0x00090161
		public static string GetName(byte alertDescription)
		{
			if (alertDescription == 1)
			{
				return "warning";
			}
			if (alertDescription != 2)
			{
				return "UNKNOWN";
			}
			return "fatal";
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00091F7E File Offset: 0x0009017E
		public static string GetText(byte alertDescription)
		{
			return global::Org.BouncyCastle.Crypto.Tls.AlertLevel.GetName(alertDescription) + "(" + alertDescription.ToString() + ")";
		}

		// Token: 0x04000B83 RID: 2947
		public const byte warning = 1;

		// Token: 0x04000B84 RID: 2948
		public const byte fatal = 2;
	}
}
