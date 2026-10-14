using System;
using System.Collections.ObjectModel;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000C8 RID: 200
	public class FilterOperandCollection : global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Controls.Grids.FilterOperand>
	{
		// Token: 0x060006F4 RID: 1780 RVA: 0x0001DFD8 File Offset: 0x0001C1D8
		public void Remove(global::Infragistics.ComparisonOperator condition)
		{
			int num = base.Count - 1;
			for (int i = num; i >= 0; i--)
			{
				global::Infragistics.Controls.Grids.FilterOperand filterOperand = base.Items[i];
				if (filterOperand.ComparisonOperatorValue.Value == condition)
				{
					base.Remove(this[i]);
				}
			}
		}

		// Token: 0x17000219 RID: 537
		public global::Infragistics.Controls.Grids.FilterOperand this[global::Infragistics.ComparisonOperator op]
		{
			get
			{
				int num = base.Count - 1;
				for (int i = 0; i < num; i++)
				{
					global::Infragistics.Controls.Grids.FilterOperand filterOperand = base.Items[i];
					if (filterOperand.ComparisonOperatorValue.Value == op)
					{
						return filterOperand;
					}
				}
				return null;
			}
		}

		// Token: 0x1700021A RID: 538
		public global::Infragistics.Controls.Grids.FilterOperand this[global::System.Type type]
		{
			get
			{
				int num = base.Count - 1;
				for (int i = 0; i < num; i++)
				{
					global::Infragistics.Controls.Grids.FilterOperand filterOperand = base.Items[i];
					if (filterOperand.GetType() == type)
					{
						return filterOperand;
					}
				}
				return null;
			}
		}

		// Token: 0x1700021B RID: 539
		public new global::Infragistics.Controls.Grids.FilterOperand this[int index]
		{
			get
			{
				return base.Items[index];
			}
		}
	}
}
