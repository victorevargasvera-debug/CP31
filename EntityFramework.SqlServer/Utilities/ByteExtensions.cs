using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System.Data.Entity.SqlServer.Utilities
{
	// Token: 0x02000024 RID: 36
	internal static class ByteExtensions
	{
		// Token: 0x060003D7 RID: 983 RVA: 0x0000F360 File Offset: 0x0000D560
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
