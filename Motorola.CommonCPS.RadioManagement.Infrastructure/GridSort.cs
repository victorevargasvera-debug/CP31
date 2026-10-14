using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000014 RID: 20
	public class GridSort
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00005AA8 File Offset: 0x00003CA8
		public static global::System.Windows.Input.ICommand GetCommand(global::Infragistics.Windows.DataPresenter.XamDataGrid grid)
		{
			short num = (short)224599877;
			short num2 = num;
			num = (short)233905989;
			switch (num2 == num)
			{
			}
			num = (short)1944649728;
			short num3 = num;
			num = (short)1535377408;
			if (num != 0)
			{
			}
			num = (short)381616129;
			if (num != 0)
			{
			}
			return grid.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.GridSort.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005B60 File Offset: 0x00003D60
		public static void SetCommand(global::Infragistics.Windows.DataPresenter.XamDataGrid grid, global::System.Windows.Input.ICommand command)
		{
			short num = (short)1552313065;
			short num2 = num;
			num = (short)36727529;
			switch (num2 == num)
			{
			}
			num = (short)2138308608;
			short num3 = num;
			num = (short)240189441;
			if (num != 0)
			{
			}
			num = (short)1544355840;
			if (num != 0)
			{
			}
			grid.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.GridSort.CommandProperty, command);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005C18 File Offset: 0x00003E18
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)444727297;
			if (num != 0)
			{
			}
			num = (short)1419439917;
			short num2 = num;
			num = (short)1367207725;
			switch (num2 == num)
			{
			default:
			{
				num = (short)751239168;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1805582336;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.DataPresenter.XamDataGrid xamDataGrid = A_0 as global::Infragistics.Windows.DataPresenter.XamDataGrid;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.GridSortByColumnBehavior gridSortByColumnBehavior = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.GridSortByColumnBehavior(xamDataGrid);
			xamDataGrid.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.GridSort.a, gridSortByColumnBehavior);
			gridSortByColumnBehavior.Command = (A_1.NewValue as global::System.Windows.Input.ICommand);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005D00 File Offset: 0x00003F00
		// Note: this type is marked as 'beforefieldinit'.
		static GridSort()
		{
			int a_ = 12;
			short num = (short)782660183;
			short num2 = num;
			num = (short)1603498583;
			switch (num2 == num)
			{
			}
			num = (short)1716781056;
			short num3 = num;
			num = (short)294322177;
			if (num != 0)
			{
			}
			num = (short)325779456;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.GridSort.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("朣䤥䔧䜩䴫䀭启", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.GridSort), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.GridSort.a)));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.GridSort.a = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("挣吥䄧丩缫䄭䈯䘱瘳伵笷唹倻䬽ⴿⱁك⍅⁇⭉㩋❍㽏⁑", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.GridSortByColumnBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.GridSort), null);
		}

		// Token: 0x04000011 RID: 17
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x04000012 RID: 18
		private static readonly global::System.Windows.DependencyProperty a;
	}
}
