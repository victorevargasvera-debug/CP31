using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000D3 RID: 211
	public abstract class KeyUpdateRequest
	{
		// Token: 0x060007A1 RID: 1953 RVA: 0x00020719 File Offset: 0x0001E919
		public static string GetName(short keyUpdateRequest)
		{
			if (keyUpdateRequest == 0)
			{
				return "update_not_requested";
			}
			if (keyUpdateRequest != 1)
			{
				return "UNKNOWN";
			}
			return "update_requested";
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00020735 File Offset: 0x0001E935
		public static string GetText(short keyUpdateRequest)
		{
			return global::Org.BouncyCastle.Tls.KeyUpdateRequest.GetName(keyUpdateRequest) + "(" + keyUpdateRequest.ToString() + ")";
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00020753 File Offset: 0x0001E953
		public static bool IsValid(short keyUpdateRequest)
		{
			return keyUpdateRequest >= 0 && keyUpdateRequest <= 1;
		}

		// Token: 0x040005B2 RID: 1458
		public const short update_not_requested = 0;

		// Token: 0x040005B3 RID: 1459
		public const short update_requested = 1;
	}
}
