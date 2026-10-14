using System;
using System.Windows;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.Editors;
using Microsoft.Practices.Prism.Commands;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x0200000F RID: 15
	public class FieldCheckChangedCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Infragistics.Windows.Editors.XamCheckEditor>
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00004C3C File Offset: 0x00002E3C
		public FieldCheckChangedCommandBehavior(global::Infragistics.Windows.Editors.XamCheckEditor checkBox) : base(checkBox)
		{
			checkBox.ValueChanged += this.a;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004C64 File Offset: 0x00002E64
		private void a(object A_0, global::System.Windows.RoutedPropertyChangedEventArgs<object> A_1)
		{
			short num = (short)2131689475;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)855048192;
				short num3 = num;
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
				object[] commandParameter;
				switch (num2)
				{
				case 0:
				{
					num = (short)1751992160;
					short num4 = num;
					num = (short)73090912;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						goto IL_EF;
					}
					break;
				}
				case 1:
					num = (short)2110521349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (dataRecord.Index != -1)
					{
						num = (short)477888516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_15;
				case 4:
					num = (short)1136328705;
					if (num != 0)
					{
					}
					base.CommandParameter = commandParameter;
					this.ExecuteCommand();
					num = (short)711917568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if ((A_0 as global::Infragistics.Windows.Editors.XamCheckEditor).IsKeyboardFocusWithin)
					{
						num = (short)1431306246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					goto IL_10A;
				}
				goto IL_6A;
				IL_15:
				switch (0)
				{
				case 0:
					IL_6A:
					if ((A_0 as global::Infragistics.Windows.Editors.XamCheckEditor).IsMouseCaptureWithin)
					{
						goto IL_10A;
					}
					num = (short)459341825;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_10A:
				dataRecord = (((global::Infragistics.Windows.Editors.XamCheckEditor)A_0).DataContext as global::Infragistics.Windows.DataPresenter.DataRecord);
				commandParameter = new object[]
				{
					dataRecord.DataItem,
					A_1.OldValue,
					A_1.NewValue
				};
				num = (short)1579483138;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EF:
			num = (short)2081816576;
			if (num != 0)
			{
			}
		}
	}
}
