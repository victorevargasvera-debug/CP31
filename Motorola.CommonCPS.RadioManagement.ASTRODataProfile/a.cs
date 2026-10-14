using System;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x02000004 RID: 4
	internal class a : global::Motorola.CommonCPS.RadioManagement.Infrastructure.IPAddressFieldSetter
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000024F0 File Offset: 0x000006F0
		public a(global::System.Windows.Input.ICommand A_0, global::System.Windows.Input.ICommand A_1, global::Motorola.CommonCPS.UI.CellRangeFill.ICellEditabilityResolver A_2) : base(A_0, A_1, A_2)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002508 File Offset: 0x00000708
		protected override object GetCommandParameter(global::Infragistics.Windows.DataPresenter.Cell cell, object value, bool supressNotification, bool commit, bool refresh)
		{
			short num = (short)1505781757;
			short num2 = num;
			num = (short)720857085;
			switch (num2 == num)
			{
			}
			num = (short)1836187649;
			if (num != 0)
			{
			}
			num = (short)1723990016;
			short num3 = num;
			num = (short)11665408;
			if (num != 0)
			{
			}
			object[] array = (object[])base.GetCommandParameter(cell, value, supressNotification, commit, refresh);
			global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile = (global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)array[0];
			global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile cachedNewSystem = global::Motorola.CommonCPS.RadioManagement.LocalService.NewDataProfileCache.Instance.GetCachedNewSystem(astroDataProfile.ID.Value);
			if (cachedNewSystem != null)
			{
				astroDataProfile.CopyFrom(cachedNewSystem);
			}
			return array;
		}
	}
}
