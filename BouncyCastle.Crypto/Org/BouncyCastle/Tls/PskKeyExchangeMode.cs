using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000E0 RID: 224
	public abstract class PskKeyExchangeMode
	{
		// Token: 0x06000814 RID: 2068 RVA: 0x00021E8F File Offset: 0x0002008F
		public static string GetName(short pskKeyExchangeMode)
		{
			if (pskKeyExchangeMode == 0)
			{
				return "psk_ke";
			}
			if (pskKeyExchangeMode != 1)
			{
				return "UNKNOWN";
			}
			return "psk_dhe_ke";
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00021EAB File Offset: 0x000200AB
		public static string GetText(short pskKeyExchangeMode)
		{
			return global::Org.BouncyCastle.Tls.PskKeyExchangeMode.GetName(pskKeyExchangeMode) + "(" + pskKeyExchangeMode.ToString() + ")";
		}

		// Token: 0x04000629 RID: 1577
		public const short psk_ke = 0;

		// Token: 0x0400062A RID: 1578
		public const short psk_dhe_ke = 1;
	}
}
