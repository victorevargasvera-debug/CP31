using System;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000040 RID: 64
	public class WiFiPasswordValidationViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000252 RID: 594 RVA: 0x00028A9C File Offset: 0x00026C9C
		public WiFiPasswordValidationViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext wiFiPasswordValidationContext) : base(eventAggregator, commandHandler)
		{
			this.WiFiPasswordValidationContext = wiFiPasswordValidationContext;
			this.WiFiPasswordValidationCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00028ADC File Offset: 0x00026CDC
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00028B90 File Offset: 0x00026D90
		public global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext WiFiPasswordValidationContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)260374529;
				if (num != 0)
				{
				}
				num = (short)1467481799;
				short num2 = num;
				num = (short)1340145351;
				switch (num2 == num)
				{
				default:
				{
					num = (short)955318272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)238485504;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)360810180;
				short num2 = num;
				num = (short)973637316;
				switch (num2 == num)
				{
				}
				num = (short)1492189184;
				short num3 = num;
				num = (short)1040973825;
				if (num != 0)
				{
				}
				num = (short)457506816;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00028C3C File Offset: 0x00026E3C
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00028CEC File Offset: 0x00026EEC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand WiFiPasswordValidationCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1522337829;
				short num2 = num;
				num = (short)1461651493;
				switch (num2 == num)
				{
				}
				num = (short)1527382016;
				short num3 = num;
				num = (short)2080178176;
				if (num != 0)
				{
				}
				num = (short)644743169;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)205455361;
				if (num != 0)
				{
				}
				num = (short)994758848;
				short num2 = num;
				num = (short)478400704;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1664417792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1758134272;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00028D9C File Offset: 0x00026F9C
		private void b()
		{
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						goto IL_F8;
					case 1:
						goto IL_111;
					case 2:
						base.CloseCommand.Execute();
						num2 = (short)1592459264;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (this.WiFiPasswordValidationContext.IsValidationPass)
						{
							num2 = (short)1635254274;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F8;
					}
					break;
					IL_F8:
					num2 = (short)391118849;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_20:
				base.CommandHandler.WiFiPasswordValidationCommand.Execute(new object[]
				{
					this.WiFiPasswordValidationContext
				});
				this.WiFiPasswordValidationContext.IsCancel = false;
				num2 = (short)303109437;
				short num3 = num2;
				num2 = (short)992941373;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_111:
					break;
				default:
				{
					num2 = (short)952696832;
					if (num2 != 0)
					{
					}
					num2 = (short)444661763;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
			catch (global::System.Exception exception)
			{
				this.WiFiPasswordValidationContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num2 = (short)827981825;
			if (num2 != 0)
			{
			}
			num2 = (short)1776418816;
			short num4 = num2;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00028F40 File Offset: 0x00027140
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)90225061;
				short num2 = num;
				num = (short)904182181;
				switch (num2 == num)
				{
				}
				num = (short)1888616448;
				if (num != 0)
				{
				}
				result = base.CommandHandler.WiFiPasswordValidationCommand.CanExecute(new object[]
				{
					this.WiFiPasswordValidationContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1709965313;
			if (num != 0)
			{
			}
			num = (short)250871808;
			short num3 = num;
			return result;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00029028 File Offset: 0x00027228
		internal static string c(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(883630832 + A_1) + (global::System.IntPtr)96 + (global::System.IntPtr)99);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}

		// Token: 0x04000142 RID: 322
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext a;

		// Token: 0x04000143 RID: 323
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;
	}
}
