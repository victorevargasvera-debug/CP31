using System;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Microsoft.Practices.Prism.Commands;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x0200000D RID: 13
	public class DataGridEditModeStartedCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Infragistics.Windows.DataPresenter.XamDataGrid>
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00004648 File Offset: 0x00002848
		public DataGridEditModeStartedCommandBehavior(global::Infragistics.Windows.DataPresenter.XamDataGrid grid) : base(grid)
		{
			grid.EditModeStarted += this.a;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004670 File Offset: 0x00002870
		private void a(object A_0, global::Infragistics.Windows.DataPresenter.Events.EditModeStartedEventArgs A_1)
		{
			short num = (short)936509443;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string text;
				switch (num2)
				{
				case 0:
					if (A_1.Cell != null)
					{
						num = (short)530907141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B7;
				case 1:
					if (A_1.Cell.Field != null)
					{
						num = (short)1020264450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B7;
				case 2:
					text = A_1.Cell.Field.Name;
					num = (short)1639972868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 4:
					goto IL_1B7;
				case 5:
					goto IL_22E;
				case 6:
					return;
				case 7:
					if (A_1 != null)
					{
						num = (short)470745097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B7;
				case 8:
					text = string.Empty;
					num = (short)347013127;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					num = (short)2082144256;
					short num3 = num;
					num = (short)167706624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_4D:
				num = (short)375487145;
				short num4 = num;
				num = (short)38959785;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_22E:
					num = (short)220921857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)1626472448;
					if (num != 0)
					{
					}
					num = (short)243662849;
					if (num != 0)
					{
					}
					if (base.TargetObject.ActiveDataItem != null)
					{
						num = (short)357629960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_1B7:
				object[] commandParameter = new object[]
				{
					base.TargetObject.ActiveDataItem,
					text
				};
				base.CommandParameter = commandParameter;
				this.ExecuteCommand();
				num = (short)1112342534;
				num2 = (int)((global::System.IntPtr)num);
			}
		}
	}
}
