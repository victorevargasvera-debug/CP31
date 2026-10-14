using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001FF RID: 511
	internal class PropertyDescriptorCollectionComparer : global::System.Collections.Generic.IEqualityComparer<global::System.ComponentModel.PropertyDescriptorCollection>
	{
		// Token: 0x060012FC RID: 4860 RVA: 0x00043BB0 File Offset: 0x00041DB0
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

		// Token: 0x060012FD RID: 4861 RVA: 0x00043BFF File Offset: 0x00041DFF
		public int GetHashCode(global::System.ComponentModel.PropertyDescriptorCollection obj)
		{
			return obj.Count + 1;
		}

		// Token: 0x040009C7 RID: 2503
		internal static readonly global::Infragistics.Windows.Internal.PropertyDescriptorCollectionComparer Instance = new global::Infragistics.Windows.Internal.PropertyDescriptorCollectionComparer();
	}
}
