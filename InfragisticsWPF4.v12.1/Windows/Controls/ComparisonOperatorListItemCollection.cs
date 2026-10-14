using System;
using System.Collections.ObjectModel;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000142 RID: 322
	public class ComparisonOperatorListItemCollection : global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.Controls.ComparisonOperatorListItem>
	{
		// Token: 0x06000B0D RID: 2829 RVA: 0x0002445E File Offset: 0x0002265E
		internal ComparisonOperatorListItemCollection(global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.Controls.ComparisonOperatorListItem> list) : base(list)
		{
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00024468 File Offset: 0x00022668
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
