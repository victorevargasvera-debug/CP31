using System;
using System.Reflection;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Microsoft.Practices.Prism.Commands;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000022 RID: 34
	public class DataGridEditModeEndingCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Infragistics.Windows.DataPresenter.XamDataGrid>
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00007D28 File Offset: 0x00005F28
		public DataGridEditModeEndingCommandBehavior(global::Infragistics.Windows.DataPresenter.XamDataGrid dataGrid) : base(dataGrid)
		{
			dataGrid.EditModeEnding += this.a;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007D50 File Offset: 0x00005F50
		private void a(object A_0, global::Infragistics.Windows.DataPresenter.Events.EditModeEndingEventArgs A_1)
		{
			short num = (short)2051276801;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 2:
				{
					num = (short)2127476058;
					short num3 = num;
					num = (short)465155418;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D6;
					default:
						goto IL_122;
					}
					break;
				}
				case 3:
					goto IL_156;
				case 4:
					if (base.CommandParameter == null)
					{
						goto IL_D6;
					}
					num = (short)1386414083;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_38:
				if (!A_1.Cell.IsDataChanged)
				{
					num = (short)2025259008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.CommandParameter = global::Motorola.CommonCPS.RadioManagement.Infrastructure.a.a(A_1);
				num = (short)952041476;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D6:
				num = (short)468123650;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_122:
			num = (short)128122880;
			if (num != 0)
			{
			}
			return;
			IL_156:
			num = (short)1933312000;
			short num4 = num;
			num = (short)388104193;
			if (num != 0)
			{
			}
			try
			{
				this.ExecuteCommand();
				object[] array = (object[])base.CommandParameter;
				global::System.Reflection.PropertyInfo property = array[0].GetType().GetProperty((string)array[1]);
				A_1.Editor.Value = property.GetValue(array[0]);
				return;
			}
			catch
			{
				A_1.AcceptChanges = false;
				return;
			}
		}
	}
}
