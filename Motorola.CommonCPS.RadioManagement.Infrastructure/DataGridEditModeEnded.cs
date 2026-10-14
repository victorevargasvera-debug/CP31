using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x0200000A RID: 10
	public class DataGridEditModeEnded
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00003DA0 File Offset: 0x00001FA0
		public static global::System.Windows.Input.ICommand GetCommand(global::Infragistics.Windows.DataPresenter.XamDataGrid grid)
		{
			short num = (short)1492629279;
			short num2 = num;
			num = (short)162117407;
			switch (num2 == num)
			{
			}
			num = (short)340197377;
			if (num != 0)
			{
			}
			num = (short)1335361536;
			if (num != 0)
			{
			}
			num = (short)72351744;
			short num3 = num;
			return grid.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnded.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003E58 File Offset: 0x00002058
		public static void SetCommand(global::Infragistics.Windows.DataPresenter.XamDataGrid grid, global::System.Windows.Input.ICommand command)
		{
			short num = (short)375669134;
			short num2 = num;
			num = (short)1062879630;
			switch (num2 == num)
			{
			}
			num = (short)166526976;
			if (num != 0)
			{
			}
			num = (short)1229586433;
			if (num != 0)
			{
			}
			num = (short)924516352;
			short num3 = num;
			grid.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnded.CommandProperty, command);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003F0C File Offset: 0x0000210C
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)848232449;
			if (num != 0)
			{
			}
			num = (short)1564530846;
			short num2 = num;
			num = (short)511367326;
			switch (num2 == num)
			{
			}
			num = (short)416546816;
			if (num != 0)
			{
			}
			num = (short)1150353408;
			short num3 = num;
			global::Infragistics.Windows.DataPresenter.XamDataGrid xamDataGrid = A_0 as global::Infragistics.Windows.DataPresenter.XamDataGrid;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEndedCommandBehavior dataGridEditModeEndedCommandBehavior = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEndedCommandBehavior(xamDataGrid);
			xamDataGrid.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnded.a, dataGridEditModeEndedCommandBehavior);
			dataGridEditModeEndedCommandBehavior.Command = (A_1.NewValue as global::System.Windows.Input.ICommand);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003FF4 File Offset: 0x000021F4
		// Note: this type is marked as 'beforefieldinit'.
		static DataGridEditModeEnded()
		{
			int a_ = 7;
			short num = (short)1258157702;
			short num2 = num;
			num = (short)1207891590;
			switch (num2 == num)
			{
			}
			num = (short)78053377;
			if (num != 0)
			{
			}
			num = (short)1015152640;
			if (num != 0)
			{
			}
			num = (short)1518731264;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnded.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("尞丠丢䠤䘦䜨伪", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnded), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnded.a)));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnded.a = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("嬞䀠圢䐤怦嬨䈪䤬樮唰娲䄴稶嘸强堼稾⽀❂⁄⍆ੈ⑊⁌≎ぐ㵒ㅔᕖ㱘㍚㱜⥞ࡠౢᝤ", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEndedCommandBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnded), null);
		}

		// Token: 0x04000008 RID: 8
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x04000009 RID: 9
		private static readonly global::System.Windows.DependencyProperty a;
	}
}
