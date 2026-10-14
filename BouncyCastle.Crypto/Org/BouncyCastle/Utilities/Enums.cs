using System;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Utilities
{
	// Token: 0x02000035 RID: 53
	internal abstract class Enums
	{
		// Token: 0x0600027B RID: 635 RVA: 0x0000C478 File Offset: 0x0000A678
		internal static global::System.Enum GetEnumValue(global::System.Type enumType, string s)
		{
			if (!global::Org.BouncyCastle.Utilities.Enums.IsEnumType(enumType))
			{
				throw new global::System.ArgumentException("Not an enumeration type", "enumType");
			}
			if (s.Length > 0 && char.IsLetter(s[0]) && s.IndexOf(',') < 0)
			{
				s = s.Replace('-', '_');
				s = s.Replace('/', '_');
				return (global::System.Enum)global::System.Enum.Parse(enumType, s, false);
			}
			throw new global::System.ArgumentException();
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000C4EA File Offset: 0x0000A6EA
		internal static global::System.Array GetEnumValues(global::System.Type enumType)
		{
			if (!global::Org.BouncyCastle.Utilities.Enums.IsEnumType(enumType))
			{
				throw new global::System.ArgumentException("Not an enumeration type", "enumType");
			}
			return global::System.Enum.GetValues(enumType);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000C50C File Offset: 0x0000A70C
		internal static global::System.Enum GetArbitraryValue(global::System.Type enumType)
		{
			global::System.Array values = global::Org.BouncyCastle.Utilities.Enums.GetEnumValues(enumType);
			int pos = (int)(global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs() & 2147483647L) % values.Length;
			return (global::System.Enum)values.GetValue(pos);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000C541 File Offset: 0x0000A741
		internal static bool IsEnumType(global::System.Type t)
		{
			return t.IsEnum;
		}
	}
}
