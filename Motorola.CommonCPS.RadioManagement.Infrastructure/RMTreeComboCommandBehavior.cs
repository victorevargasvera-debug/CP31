using System;
using System.Windows;
using Infragistics.Windows.DataPresenter;
using Microsoft.Practices.Prism.Commands;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000017 RID: 23
	public class RMTreeComboCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor>
	{
		// Token: 0x06000045 RID: 69 RVA: 0x0000627C File Offset: 0x0000447C
		public RMTreeComboCommandBehavior(global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor editor) : base(editor)
		{
			editor.SelectedItemChanged += this.a;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000062A4 File Offset: 0x000044A4
		private void a(object A_0, global::System.Windows.RoutedPropertyChangedEventArgs<object> A_1)
		{
			short num = (short)1688141825;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B5;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 2:
				{
					num = (short)829034056;
					short num3 = num;
					num = (short)53743176;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_141;
					default:
						num = (short)2123628544;
						if (num != 0)
						{
						}
						if ((A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor).IsKeyboardFocusWithin)
						{
							num = (short)1101987844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16C;
					}
					break;
				}
				case 3:
					num = (short)1464664066;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_141;
				}
				IL_38:
				if (!(A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor).IsMouseCaptureWithin)
				{
					num = (short)2048983043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5D:
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = ((global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor)A_0).DataContext as global::Infragistics.Windows.DataPresenter.DataRecord;
				object[] commandParameter = new object[]
				{
					dataRecord.DataItem,
					A_1.OldValue,
					A_1.NewValue
				};
				base.CommandParameter = commandParameter;
				this.ExecuteCommand();
				num = (short)548274176;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_141:
				num = (short)1104019457;
				if (num != 0)
				{
				}
				goto IL_5D;
			}
			IL_B5:
			IL_16C:
			num = (short)1722089472;
			short num4 = num;
		}
	}
}
