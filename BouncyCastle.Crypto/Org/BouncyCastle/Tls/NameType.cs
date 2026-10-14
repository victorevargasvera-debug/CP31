using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000D8 RID: 216
	public abstract class NameType
	{
		// Token: 0x060007C4 RID: 1988 RVA: 0x00020DD0 File Offset: 0x0001EFD0
		public static string GetName(short nameType)
		{
			if (nameType == 0)
			{
				return "host_name";
			}
			return "UNKNOWN";
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00020DE1 File Offset: 0x0001EFE1
		public static string GetText(short nameType)
		{
			return global::Org.BouncyCastle.Tls.NameType.GetName(nameType) + "(" + nameType.ToString() + ")";
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00020DFF File Offset: 0x0001EFFF
		public static bool IsRecognized(short nameType)
		{
			return nameType == 0;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00020E05 File Offset: 0x0001F005
		public static bool IsValid(short nameType)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint8(nameType);
		}

		// Token: 0x040005F5 RID: 1525
		public const short host_name = 0;
	}
}
