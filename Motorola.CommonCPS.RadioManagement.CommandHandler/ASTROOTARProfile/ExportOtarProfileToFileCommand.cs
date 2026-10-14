using System;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.ASTROOTARProfile
{
	// Token: 0x0200000B RID: 11
	internal class ExportOtarProfileToFileCommand : global::Motorola.CommonCPS.RadioManagement.Command.ExportGridToFileCommandBase<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00003CEC File Offset: 0x00001EEC
		protected override global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo GetDataGridInfo()
		{
			short num = (short)1224935465;
			short num2 = num;
			num = (short)1200293929;
			switch (num2 == num)
			{
			default:
			{
				num = (short)19005440;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)856686593;
			if (num != 0)
			{
			}
			num = (short)726728704;
			if (num != 0)
			{
			}
			return base.Interaction.GetDataGridInfoForOtarProfile();
		}
	}
}
