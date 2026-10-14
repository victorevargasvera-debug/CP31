using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000088 RID: 136
	internal static class ByteExtensions
	{
		// Token: 0x06000464 RID: 1124 RVA: 0x0000F5F0 File Offset: 0x0000D7F0
		public static string ToHexString(this global::System.Collections.Generic.IEnumerable<byte> bytes)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (byte b in bytes)
			{
				stringBuilder.Append(b.ToString("X2", global::System.Globalization.CultureInfo.InvariantCulture));
			}
			return stringBuilder.ToString();
		}
	}
}
