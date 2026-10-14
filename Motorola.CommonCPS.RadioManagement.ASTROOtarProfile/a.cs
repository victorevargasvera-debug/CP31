using System;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.ASTROOtarProfile
{
	// Token: 0x02000004 RID: 4
	internal class a : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandCellValueSetter
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000024E8 File Offset: 0x000006E8
		public a(global::System.Windows.Input.ICommand A_0, global::System.Windows.Input.ICommand A_1, global::Motorola.CommonCPS.UI.CellRangeFill.ICellEditabilityResolver A_2) : base(A_0, A_1, A_2)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002500 File Offset: 0x00000700
		protected override object GetCommandParameter(global::Infragistics.Windows.DataPresenter.Cell cell, object value, bool supressNotification, bool commit, bool refresh)
		{
			short num = (short)1168179201;
			if (num != 0)
			{
			}
			num = (short)80478815;
			short num2 = num;
			num = (short)554304095;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1731002368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)828243968;
			if (num != 0)
			{
			}
			object[] array = (object[])base.GetCommandParameter(cell, value, supressNotification, commit, refresh);
			global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile astrootarProfile = (global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)array[0];
			global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile cachedNewProfile = global::Motorola.CommonCPS.RadioManagement.LocalService.NewASTROOtarProfileCache.Instance.GetCachedNewProfile(astrootarProfile.ID.Value);
			if (cachedNewProfile != null)
			{
				astrootarProfile.CopyFrom(cachedNewProfile);
			}
			return array;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000025F0 File Offset: 0x000007F0
		public override void SetValue(global::Infragistics.Windows.DataPresenter.Cell cell, object value, bool supressNotification, bool commit, bool refresh)
		{
			int a_ = 19;
			short num = (short)709689345;
			if (num != 0)
			{
			}
			if (cell == null)
			{
				num = (short)1061597854;
				short num2 = num;
				num = (short)1712370334;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)207093760;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ݣͥѧ٩", a_));
				}
			}
			num = (short)731774976;
			short num3 = num;
			base.CheckSettability(cell, value);
			object commandParameter = this.GetCommandParameter(cell, value, supressNotification, commit, refresh);
			base.EditModeStartedCommand.Execute(commandParameter);
			base.EditModeEndedCommand.Execute(commandParameter);
		}
	}
}
