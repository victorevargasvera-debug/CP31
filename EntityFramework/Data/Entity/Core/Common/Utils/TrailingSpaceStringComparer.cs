using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x02000600 RID: 1536
	internal class TrailingSpaceStringComparer : global::System.Collections.Generic.IEqualityComparer<string>
	{
		// Token: 0x06004B47 RID: 19271 RVA: 0x0010972C File Offset: 0x0010792C
		private TrailingSpaceStringComparer()
		{
		}

		// Token: 0x06004B48 RID: 19272 RVA: 0x00109734 File Offset: 0x00107934
		public bool Equals(string x, string y)
		{
			return global::System.StringComparer.OrdinalIgnoreCase.Equals(global::System.Data.Entity.Core.Common.Utils.TrailingSpaceStringComparer.NormalizeString(x), global::System.Data.Entity.Core.Common.Utils.TrailingSpaceStringComparer.NormalizeString(y));
		}

		// Token: 0x06004B49 RID: 19273 RVA: 0x0010974C File Offset: 0x0010794C
		public int GetHashCode(string obj)
		{
			return global::System.StringComparer.OrdinalIgnoreCase.GetHashCode(global::System.Data.Entity.Core.Common.Utils.TrailingSpaceStringComparer.NormalizeString(obj));
		}

		// Token: 0x06004B4A RID: 19274 RVA: 0x0010975E File Offset: 0x0010795E
		internal static string NormalizeString(string value)
		{
			if (value == null || !value.EndsWith(" ", global::System.StringComparison.Ordinal))
			{
				return value;
			}
			return value.TrimEnd(new char[]
			{
				' '
			});
		}

		// Token: 0x04001A54 RID: 6740
		internal static readonly global::System.Data.Entity.Core.Common.Utils.TrailingSpaceStringComparer Instance = new global::System.Data.Entity.Core.Common.Utils.TrailingSpaceStringComparer();
	}
}
