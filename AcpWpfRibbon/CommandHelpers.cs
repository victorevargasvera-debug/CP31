using System;
using System.Windows;
using System.Windows.Input;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000025 RID: 37
	internal static class CommandHelpers
	{
		// Token: 0x060002BC RID: 700 RVA: 0x0003E1D8 File Offset: 0x0003C3D8
		internal static void ExecuteCommand(global::System.Windows.Input.ICommand command, object parameter, global::System.Windows.IInputElement target)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			global::System.Windows.Input.RoutedCommand routedCommand;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_110;
				case 1:
					if (routedCommand != null)
					{
						num2 = (short)1941831684;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)154468354;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (command.CanExecute(parameter))
					{
						num2 = (short)1184956421;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					if (routedCommand.CanExecute(parameter, target))
					{
						num2 = (short)2076639232;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					num2 = (short)1957494787;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)2088370177;
					if (num2 != 0)
					{
					}
					command.Execute(parameter);
					num2 = (short)1879506950;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_1A7;
				}
				goto IL_2C;
			}
			IL_110:
			num2 = (short)990187990;
			short num3 = num2;
			num2 = (short)922358230;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num2 = (short)175570944;
				if (num2 != 0)
				{
				}
				num2 = (short)1188691968;
				short num4 = num2;
				routedCommand.Execute(parameter, target);
				return;
			}
			}
			IL_1A7:
			return;
			IL_2C:
			routedCommand = (command as global::System.Windows.Input.RoutedCommand);
			num2 = (short)9830401;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
