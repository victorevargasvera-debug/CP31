using System;
using System.Windows.Controls;
using Microsoft.Practices.Prism.Commands;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000016 RID: 22
	public class ListBoxSelectionChangedCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::System.Windows.Controls.ListBox>
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00006184 File Offset: 0x00004384
		public ListBoxSelectionChangedCommandBehavior(global::System.Windows.Controls.ListBox listBox) : base(listBox)
		{
			listBox.SelectionChanged += this.a;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000061AC File Offset: 0x000043AC
		private void a(object A_0, global::System.Windows.Controls.SelectionChangedEventArgs A_1)
		{
			short num = (short)612696065;
			if (num != 0)
			{
			}
			num = (short)959923236;
			short num2 = num;
			num = (short)731726884;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1128923136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)255393792;
			if (num != 0)
			{
			}
			object[] commandParameter = new object[]
			{
				A_1.AddedItems,
				A_1.RemovedItems
			};
			base.CommandParameter = commandParameter;
			this.ExecuteCommand();
		}
	}
}
