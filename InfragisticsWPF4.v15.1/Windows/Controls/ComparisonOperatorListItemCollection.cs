using System;
using System.Collections.ObjectModel;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000160 RID: 352
	public class ComparisonOperatorListItemCollection : global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.Controls.ComparisonOperatorListItem>
	{
		// Token: 0x06000C10 RID: 3088 RVA: 0x00028022 File Offset: 0x00026222
		internal ComparisonOperatorListItemCollection(global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.Controls.ComparisonOperatorListItem> list) : base(list)
		{
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0002802C File Offset: 0x0002622C
		internal int IndexOfOperator(global::Infragistics.Windows.Controls.ComparisonOperator item)
		{
			int count = base.Count;
			for (int i = 0; i < count; i++)
			{
				if (base[i].Operator == item)
				{
					return i;
				}
			}
			return -1;
		}
	}
}
