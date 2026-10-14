using System;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x02000006 RID: 6
	internal static class b
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000029F0 File Offset: 0x00000BF0
		public static global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager a(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid A_0)
		{
			int a_ = 16;
			global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager result;
			short num;
			for (;;)
			{
				global::Motorola.CommonCPS.RadioManagement.LocalService.NewDataProfileCache.Instance.Clear();
				global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager cellRangeFillManager = new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager(new global::Motorola.CommonCPS.RadioManagement.Infrastructure.GridSorting<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>(A_0), typeof(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.c), new global::Motorola.CommonCPS.RadioManagement.Infrastructure.PostFillActionResolver());
				try
				{
					global::System.Windows.Input.ICommand command = global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeStarted.GetCommand(A_0);
					global::System.Windows.Input.ICommand command2 = global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnding.GetCommand(A_0);
					global::Motorola.CommonCPS.UI.CellRangeFill.ICellEditabilityResolver a_2 = new global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.CellEditabilityResolver();
					global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter valueSetter = new global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.a(command, command2, a_2);
					global::Motorola.CommonCPS.UI.CellRangeFill.ICellRangeFiller filler = new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeCopyFiller(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_FillOperation_CopyCells);
					new global::Motorola.CommonCPS.UI.CellRangeFill.Int32CellRangeSeriesFiller(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_FillOperation_FillSeries, false);
					global::Motorola.CommonCPS.UI.CellRangeFill.ICellRangeFiller filler2 = new global::Motorola.CommonCPS.UI.CellRangeFill.IPAddressCellRangeSeriesFiller(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_FillOperation_FillSeries, false);
					global::Infragistics.Windows.DataPresenter.FieldCollection fields = A_0.FieldLayouts[0].Fields;
					string name = fields[global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﺬ\udaae펰삲횴얶킸\ud9ba\ud8bc춾裀鏂", a_)].Name;
					cellRangeFillManager.CellValueSetterBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBinding(name, valueSetter));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler2));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler2));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler));
					name = fields[global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﶬ쪮풰솲ﲴ", a_)].Name;
					cellRangeFillManager.CellValueSetterBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBinding(name, valueSetter));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler2));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler2));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler));
					name = fields[global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("쎮쒰횲솴\ud8b6횸쾺햼﮾铀跂雄닆ꯈ룊껌뷎룐뇒냔ꗖ郘诚", a_)].Name;
					cellRangeFillManager.CellValueSetterBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBinding(name, valueSetter));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler2));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler2));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler));
					name = fields[global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("쎮쒰횲솴\ud8b6횸쾺햼﮾铀跂闄ꋆ곈맊蓌鿎", a_)].Name;
					cellRangeFillManager.CellValueSetterBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBinding(name, valueSetter));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler2));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler2));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler));
					cellRangeFillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler));
					name = fields[global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("욮쎰者\udbb4쎶\udcb8즺\udbbc\udebeꋀꛂ賄韆", a_)].Name;
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
				num = (short)1549336576;
				short num2 = num;
				num = (short)683308880;
				short num3 = num;
				num = (short)864581456;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_382;
				}
			}
			IL_382:
			num = (short)638713856;
			if (num != 0)
			{
			}
			num = (short)775684097;
			if (num != 0)
			{
			}
			return result;
		}
	}
}
