using System;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.UI.CellRangeFill;
using Motorola.CommonCPS.UI.CellRangeSelect;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000008 RID: 8
	internal class a : global::Motorola.CommonCPS.RadioManagement.Radio.SetDeviceValueTaskBase
	{
		// Token: 0x06000019 RID: 25 RVA: 0x0000488B File Offset: 0x00002A8B
		public a(global::Infragistics.Windows.DataPresenter.DataRecordCollection A_0, global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition A_1, global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter A_2, object A_3, global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation A_4, global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange A_5, bool A_6) : base(A_0, A_1, A_2, A_3, A_4, A_5, A_6)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000048A0 File Offset: 0x00002AA0
		protected override global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase CreateDevice()
		{
			short num = (short)1714729441;
			short num2 = num;
			num = (short)707834337;
			switch (num2 == num)
			{
			}
			num = (short)1150484481;
			if (num != 0)
			{
			}
			num = (short)30670848;
			short num3 = num;
			num = (short)916586496;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio();
		}
	}
}
