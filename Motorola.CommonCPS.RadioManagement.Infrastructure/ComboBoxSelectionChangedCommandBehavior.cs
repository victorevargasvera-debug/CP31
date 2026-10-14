using System;
using System.Windows.Controls;
using Microsoft.Practices.Prism.Commands;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000006 RID: 6
	public class ComboBoxSelectionChangedCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::System.Windows.Controls.ComboBox>
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002E34 File Offset: 0x00001034
		public ComboBoxSelectionChangedCommandBehavior(global::System.Windows.Controls.ComboBox comboBox) : base(comboBox)
		{
			comboBox.SelectionChanged += this.a;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002E5C File Offset: 0x0000105C
		private void a(object A_0, global::System.Windows.Controls.SelectionChangedEventArgs A_1)
		{
			short num = (short)83034113;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)606339072;
					short num3 = num;
					goto IL_B3;
				}
				case 1:
					IL_14:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					base.CommandParameter = A_1.AddedItems[0].ToString();
					this.ExecuteCommand();
					num = (short)2055864320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				if (A_1.AddedItems.Count > 0)
				{
					num = (short)1004208130;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B3:
				num = (short)1534656513;
				if (num != 0)
				{
				}
				num = (short)636201215;
				short num4 = num;
				num = (short)597207295;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_14;
				default:
					goto IL_113;
				}
			}
			IL_113:
			num = (short)953548800;
			if (num != 0)
			{
			}
		}
	}
}
