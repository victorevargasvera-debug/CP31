using System;
using System.Windows.Input;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.UI.CellRangeFill;
using Motorola.CommonCPS.UI.CellRangeFill.Constraints;

namespace Motorola.CommonCPS.RadioManagement.ASTROOtarProfile
{
	// Token: 0x02000006 RID: 6
	internal static class b
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000028BC File Offset: 0x00000ABC
		public static global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager a(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid A_0)
		{
			int a_ = 2;
			short num;
			global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager result;
			for (;;)
			{
				num = (short)1203830785;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.LocalService.NewASTROOtarProfileCache.Instance.Clear();
				global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager cellRangeFillManager = new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager(new global::Motorola.CommonCPS.RadioManagement.Infrastructure.GridSorting<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>(A_0), typeof(global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.c), new global::Motorola.CommonCPS.RadioManagement.Infrastructure.PostFillActionResolver());
				try
				{
					global::System.Windows.Input.ICommand command = global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeStarted.GetCommand(A_0);
					global::System.Windows.Input.ICommand command2 = global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnding.GetCommand(A_0);
					global::Motorola.CommonCPS.UI.CellRangeFill.ICellEditabilityResolver a_2 = new global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.CellEditabilityResolver();
					global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter valueSetter = new global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.a(command, command2, a_2);
					global::Motorola.CommonCPS.UI.CellRangeFill.ICellRangeFiller filler = new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeCopyFiller(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_FillOperation_CopyCells);
					global::Motorola.CommonCPS.UI.CellRangeFill.ICellRangeFiller filler2 = new global::Motorola.CommonCPS.UI.CellRangeFill.Int32CellRangeSeriesFiller(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_FillOperation_FillSeries, false);
					string name = A_0.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("᱒⅔㙖⭘ቚᥜ", a_)].Name;
					global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.Int32CellValueRangeConstraint constraint = new global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.Int32CellValueRangeConstraint(0, 9999999);
					cellRangeFillManager.CellValueConstraintBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.CellValueConstraintBinding(name, constraint));
					cellRangeFillManager.CellValueSetterBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBinding(name, valueSetter));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler2));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler2));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler));
					cellRangeFillManager.ProcessFieldLayout(A_0.DefaultFieldLayout);
					result = cellRangeFillManager;
				}
				catch
				{
					cellRangeFillManager.Dispose();
					throw;
				}
				num = (short)1714110719;
				short num2 = num;
				num = (short)1069433087;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_1B6;
				}
				break;
			}
			num = (short)1378418688;
			short num3 = num;
			IL_1B6:
			num = (short)433455104;
			if (num != 0)
			{
			}
			return result;
		}
	}
}
