using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x020005FF RID: 1535
	internal class TrailingSpaceComparer : global::System.Collections.Generic.IEqualityComparer<object>
	{
		// Token: 0x06004B43 RID: 19267 RVA: 0x001096A2 File Offset: 0x001078A2
		private TrailingSpaceComparer()
		{
		}

		// Token: 0x06004B44 RID: 19268 RVA: 0x001096AC File Offset: 0x001078AC
		bool global::System.Collections.Generic.IEqualityComparer<object>.Equals(object x, object y)
		{
			string text = x as string;
			if (text != null)
			{
				string text2 = y as string;
				if (text2 != null)
				{
					return global::System.Data.Entity.Core.Common.Utils.TrailingSpaceStringComparer.Instance.Equals(text, text2);
				}
			}
			return global::System.Data.Entity.Core.Common.Utils.TrailingSpaceComparer._template.Equals(x, y);
		}

		// Token: 0x06004B45 RID: 19269 RVA: 0x001096E8 File Offset: 0x001078E8
		int global::System.Collections.Generic.IEqualityComparer<object>.GetHashCode(object obj)
		{
			string text = obj as string;
			if (text != null)
			{
				return global::System.Data.Entity.Core.Common.Utils.TrailingSpaceStringComparer.Instance.GetHashCode(text);
			}
			return global::System.Data.Entity.Core.Common.Utils.TrailingSpaceComparer._template.GetHashCode(obj);
		}

		// Token: 0x04001A52 RID: 6738
		internal static readonly global::System.Data.Entity.Core.Common.Utils.TrailingSpaceComparer Instance = new global::System.Data.Entity.Core.Common.Utils.TrailingSpaceComparer();

		// Token: 0x04001A53 RID: 6739
		private static readonly global::System.Collections.Generic.IEqualityComparer<object> _template = global::System.Collections.Generic.EqualityComparer<object>.Default;
	}
}
