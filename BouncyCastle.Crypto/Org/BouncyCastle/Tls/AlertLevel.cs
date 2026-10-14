using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200008D RID: 141
	public abstract class AlertLevel
	{
		// Token: 0x060005FB RID: 1531 RVA: 0x000197C7 File Offset: 0x000179C7
		public static string GetName(short alertDescription)
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

		// Token: 0x060005FC RID: 1532 RVA: 0x000197E4 File Offset: 0x000179E4
		public static string GetText(short alertDescription)
		{
			return global::Org.BouncyCastle.Tls.AlertLevel.GetName(alertDescription) + "(" + alertDescription.ToString() + ")";
		}

		// Token: 0x04000328 RID: 808
		public const short warning = 1;

		// Token: 0x04000329 RID: 809
		public const short fatal = 2;
	}
}
