using System;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Microsoft.Practices.Prism.Commands;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x0200000B RID: 11
	public class DataGridEditModeEndedCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Infragistics.Windows.DataPresenter.XamDataGrid>
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00004110 File Offset: 0x00002310
		public DataGridEditModeEndedCommandBehavior(global::Infragistics.Windows.DataPresenter.XamDataGrid grid) : base(grid)
		{
			grid.EditModeEnded += this.a;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004138 File Offset: 0x00002338
		private void a(object A_0, global::Infragistics.Windows.DataPresenter.Events.EditModeEndedEventArgs A_1)
		{
			short num = (short)566951939;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				object dataItem;
				string name;
				switch (num2)
				{
				case 0:
				{
					object[] commandParameter = new object[]
					{
						dataItem,
						name
					};
					base.CommandParameter = commandParameter;
					this.ExecuteCommand();
					goto IL_A3;
				}
				case 1:
				{
					num = (short)1624756217;
					short num3 = num;
					num = (short)671207417;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A3;
					case 1:
						goto IL_17B;
					}
					goto Block_3;
				}
				case 2:
					goto IL_BB;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 4:
					if (dataItem != null)
					{
						num = (short)1776549888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_38:
				if (!A_1.Cell.IsDataChanged)
				{
					num = (short)702087169;
					if (num != 0)
					{
					}
					num = (short)1757478913;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				name = A_1.Cell.Field.Name;
				dataItem = A_1.Cell.Record.DataItem;
				num = (short)384303108;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A3:
				num = (short)1923350530;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BB:
			return;
			Block_3:
			num = (short)19136512;
			short num4 = num;
			IL_17B:
			num = (short)1028128768;
			if (num != 0)
			{
			}
		}
	}
}
