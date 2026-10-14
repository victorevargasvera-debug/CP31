using System;
using System.Windows;
using Microsoft.Practices.Prism.Commands;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x0200001A RID: 26
	public class SetPresenterSelectSetRequestedCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter>
	{
		// Token: 0x0600004F RID: 79 RVA: 0x00006B08 File Offset: 0x00004D08
		public SetPresenterSelectSetRequestedCommandBehavior(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter setPresenter) : base(setPresenter)
		{
			setPresenter.SelectSetRequested += this.a;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00006B30 File Offset: 0x00004D30
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)307861002;
			short num2 = num;
			num = (short)348952074;
			switch (num2 == num)
			{
			}
			num = (short)1151598593;
			if (num != 0)
			{
			}
			num = (short)152371200;
			if (num != 0)
			{
			}
			num = (short)1252196352;
			short num3 = num;
			base.CommandParameter = A_1.OriginalSource;
			this.ExecuteCommand();
		}
	}
}
