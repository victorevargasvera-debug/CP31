using System;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.ASTROSystem
{
	// Token: 0x02000004 RID: 4
	internal class a : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandCellValueSetter
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000024EC File Offset: 0x000006EC
		public a(global::System.Windows.Input.ICommand A_0, global::System.Windows.Input.ICommand A_1, global::Motorola.CommonCPS.UI.CellRangeFill.ICellEditabilityResolver A_2) : base(A_0, A_1, A_2)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002504 File Offset: 0x00000704
		protected override object GetCommandParameter(global::Infragistics.Windows.DataPresenter.Cell cell, object value, bool supressNotification, bool commit, bool refresh)
		{
			short num = (short)1556414465;
			if (num != 0)
			{
			}
			num = (short)2020828664;
			short num2 = num;
			num = (short)310142456;
			switch (num2 == num)
			{
			}
			num = (short)1751515136;
			short num3 = num;
			num = (short)1400111104;
			if (num != 0)
			{
			}
			object[] array = (object[])base.GetCommandParameter(cell, value, supressNotification, commit, refresh);
			global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem astroSystem = (global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)array[0];
			global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem cachedNewSystem = global::Motorola.CommonCPS.RadioManagement.LocalService.NewSystemCache.Instance.GetCachedNewSystem(astroSystem.ID.Value);
			if (cachedNewSystem != null)
			{
				astroSystem.CopyFrom(cachedNewSystem);
			}
			return array;
		}
	}
}
