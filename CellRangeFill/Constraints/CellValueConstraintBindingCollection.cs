using System;
using System.Collections.ObjectModel;

namespace Motorola.CommonCPS.UI.CellRangeFill.Constraints
{
	// Token: 0x0200002B RID: 43
	public class CellValueConstraintBindingCollection : global::System.Collections.ObjectModel.KeyedCollection<string, global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.CellValueConstraintBinding>
	{
		// Token: 0x060000FA RID: 250 RVA: 0x0000EA44 File Offset: 0x0000CC44
		protected override string GetKeyForItem(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.CellValueConstraintBinding item)
		{
			short num = (short)70951750;
			short num2 = num;
			num = (short)1055433542;
			switch (num2 == num)
			{
			}
			num = (short)484179968;
			short num3 = num;
			num = (short)1886715905;
			if (num != 0)
			{
			}
			num = (short)229441536;
			if (num != 0)
			{
			}
			return item.ColumnName;
		}
	}
}
