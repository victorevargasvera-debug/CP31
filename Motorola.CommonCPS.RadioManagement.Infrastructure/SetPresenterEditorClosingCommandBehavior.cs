using System;
using System.Windows;
using Microsoft.Practices.Prism.Commands;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x0200001E RID: 30
	public class SetPresenterEditorClosingCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter>
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00007424 File Offset: 0x00005624
		public SetPresenterEditorClosingCommandBehavior(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter setPresenter) : base(setPresenter)
		{
			setPresenter.EditorClosing += this.a;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000744C File Offset: 0x0000564C
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1836705548;
			short num2 = num;
			num = (short)1399383820;
			switch (num2 == num)
			{
			}
			num = (short)276037633;
			if (num != 0)
			{
			}
			num = (short)99155968;
			if (num != 0)
			{
			}
			num = (short)61210624;
			short num3 = num;
			base.CommandParameter = A_1;
			this.ExecuteCommand();
		}
	}
}
