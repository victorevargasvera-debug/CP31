using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand
{
	// Token: 0x02000051 RID: 81
	public class CompositeCommandBuilder : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.ICompositeCommandBuilder
	{
		// Token: 0x06000227 RID: 551 RVA: 0x00020F10 File Offset: 0x0001F110
		public CompositeCommandBuilder()
		{
			this.a = new global::Microsoft.Practices.Prism.Commands.CompositeCommand();
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00020F30 File Offset: 0x0001F130
		public global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.ICompositeCommandBuilder RegisterCommand(global::System.Windows.Input.ICommand command)
		{
			short num = (short)2090532865;
			if (num != 0)
			{
			}
			num = (short)1002065754;
			short num2 = num;
			num = (short)1234915162;
			switch (num2 == num)
			{
			default:
			{
				num = (short)483655680;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)95092736;
			if (num != 0)
			{
			}
			this.a.RegisterCommand(command);
			return this;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00020FE8 File Offset: 0x0001F1E8
		public global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.ICompositeCommandBuilder RegisterCommands(global::System.Collections.Generic.List<global::System.Windows.Input.ICommand> commandList)
		{
			short num = (short)1095347206;
			short num2 = num;
			num = (short)962374662;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1291124736;
				short num3 = num;
				num = (short)643825665;
				if (num != 0)
				{
				}
				num = (short)673316864;
				if (num != 0)
				{
				}
				using (global::System.Collections.Generic.List<global::System.Windows.Input.ICommand>.Enumerator enumerator = commandList.GetEnumerator())
				{
					num = (short)1470496770;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)260833281;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.Input.ICommand command = enumerator.Current;
							this.a.RegisterCommand(command);
							num = (short)1789526019;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)480641028;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_E0;
							}
							continue;
						case 4:
							goto IL_158;
						}
						IL_10D:
						num = (short)1240727552;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_E0:
						goto IL_10D;
					}
					IL_158:;
				}
				break;
			}
			}
			return this;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00021170 File Offset: 0x0001F370
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand BuildDelegateCommand()
		{
			short num = (short)103338786;
			short num2 = num;
			num = (short)1060295458;
			switch (num2 == num)
			{
			}
			num = (short)42401792;
			short num3 = num;
			num = (short)1317404673;
			if (num != 0)
			{
			}
			num = (short)1514274816;
			if (num != 0)
			{
			}
			return new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00021238 File Offset: 0x0001F438
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b()
		{
			short num;
			try
			{
				num = (short)718602241;
				if (num != 0)
				{
				}
				num = (short)1384329251;
				short num2 = num;
				num = (short)1632317475;
				switch (num2 == num)
				{
				}
				num = (short)1055588352;
				if (num != 0)
				{
				}
				this.a.Execute(null);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)221446144;
			short num3 = num;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0002130C File Offset: 0x0001F50C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a()
		{
			bool result;
			try
			{
				result = this.a.CanExecute(null);
				goto IL_1B;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			return false;
			IL_1B:
			short num = (short)2026175414;
			short num2 = num;
			num = (short)1720712118;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			case 1:
				break;
			default:
			{
				num = (short)442499072;
				short num3 = num;
				break;
			}
			}
			num = (short)267583488;
			if (num != 0)
			{
			}
			num = (short)1223032833;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x040000E9 RID: 233
		private readonly global::Microsoft.Practices.Prism.Commands.CompositeCommand a;
	}
}
