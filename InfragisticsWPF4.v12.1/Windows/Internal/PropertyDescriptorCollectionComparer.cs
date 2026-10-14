using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001D1 RID: 465
	internal class PropertyDescriptorCollectionComparer : global::System.Collections.Generic.IEqualityComparer<global::System.ComponentModel.PropertyDescriptorCollection>
	{
		// Token: 0x0600112B RID: 4395 RVA: 0x0003E470 File Offset: 0x0003C670
		public bool Equals(global::System.ComponentModel.PropertyDescriptorCollection x, global::System.ComponentModel.PropertyDescriptorCollection y)
		{
			if (x == y)
			{
				return true;
			}
			if (x == null || y == null)
			{
				return false;
			}
			int count = x.Count;
			if (count != y.Count || count == 0)
			{
				return false;
			}
			for (int i = 0; i < count; i++)
			{
				if (x[i] != y[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0003E4BF File Offset: 0x0003C6BF
		public int GetHashCode(global::System.ComponentModel.PropertyDescriptorCollection obj)
		{
			return obj.Count + 1;
		}

		// Token: 0x04000886 RID: 2182
		internal static readonly global::Infragistics.Windows.Internal.PropertyDescriptorCollectionComparer Instance = new global::Infragistics.Windows.Internal.PropertyDescriptorCollectionComparer();
	}
}
