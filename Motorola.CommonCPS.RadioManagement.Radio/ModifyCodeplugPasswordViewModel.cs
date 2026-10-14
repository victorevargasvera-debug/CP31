using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000017 RID: 23
	public class ModifyCodeplugPasswordViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00008E74 File Offset: 0x00007074
		public ModifyCodeplugPasswordViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext modifyContext) : base(eventAggregator, commandHandler)
		{
			this.ModifyContext = modifyContext;
			this.ModifyContext.PropertyChanged += this.a;
			this.AddModifyCodeplugPasswordCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.ClearBlankPasswordCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<string>(new global::System.Action<string>(this.ClearBlankPasswordAction));
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00008EE4 File Offset: 0x000070E4
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00008F94 File Offset: 0x00007194
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext ModifyContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1472083090;
				short num2 = num;
				num = (short)1276720274;
				switch (num2 == num)
				{
				default:
				{
					num = (short)117964800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)892731393;
				if (num != 0)
				{
				}
				num = (short)441450496;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)440499223;
				short num2 = num;
				num = (short)859864087;
				switch (num2 == num)
				{
				default:
				{
					num = (short)448593920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1310785537;
				if (num != 0)
				{
				}
				num = (short)1698693120;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00009044 File Offset: 0x00007244
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000090F8 File Offset: 0x000072F8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand AddModifyCodeplugPasswordCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1464747447;
				short num2 = num;
				num = (short)1309558199;
				switch (num2 == num)
				{
				default:
				{
					num = (short)316080128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)116260865;
				if (num != 0)
				{
				}
				num = (short)477495296;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1345263881;
				short num2 = num;
				num = (short)510793993;
				switch (num2 == num)
				{
				default:
				{
					num = (short)640745472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)917962752;
				if (num != 0)
				{
				}
				num = (short)1105592321;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000091A4 File Offset: 0x000073A4
		private void b()
		{
			short num;
			try
			{
				num = (short)1125534203;
				short num2 = num;
				num = (short)386025979;
				switch (num2 == num)
				{
				}
				num = (short)1083310080;
				if (num != 0)
				{
				}
				num = (short)668729345;
				if (num != 0)
				{
				}
				base.CommandHandler.ModifyCodeplugPasswordCommand.Execute(new object[]
				{
					this.ModifyContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::Motorola.Common.CustomException.CommonException exception)
			{
				this.ModifyContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)873201664;
			short num3 = num;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000092A0 File Offset: 0x000074A0
		public void ClearBlankPasswordAction(string p)
		{
			int a_ = 10;
			short num = (short)2011824133;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (p == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("薿闁", a_))
					{
						num = (short)1521025024;
						short num3 = num;
						num = (short)613023750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					num = (short)1280753994;
					short num4 = num;
					num = (short)1950531914;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_222;
					default:
						num = (short)1008336896;
						if (num != 0)
						{
						}
						this.ModifyContext.NewRadioPassword = string.Empty;
						num = (short)1670709255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					num = (short)1162280961;
					if (num != 0)
					{
					}
					if (string.IsNullOrWhiteSpace(this.ModifyContext.NewRadioPassword))
					{
						num = (short)1576599553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					if (string.IsNullOrWhiteSpace(this.ModifyContext.OldPasswordForValidate))
					{
						num = (short)1462697992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					num = (short)2005204995;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 6:
					num = (short)1622605826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_220;
				case 8:
					goto IL_1AD;
				}
				IL_51:
				if (p == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("貿蛁", a_))
				{
					num = (short)269287428;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)2032271360;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_1AD:
			goto IL_222;
			IL_220:
			return;
			IL_222:
			this.ModifyContext.OldPasswordForValidate = string.Empty;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000094E0 File Offset: 0x000076E0
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00009590 File Offset: 0x00007790
		public global::System.Windows.Input.ICommand ClearBlankPasswordCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1427461046;
				short num2 = num;
				num = (short)1697338294;
				switch (num2 == num)
				{
				default:
				{
					num = (short)313458688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)753008641;
				if (num != 0)
				{
				}
				num = (short)1674706944;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1117167818;
				short num2 = num;
				num = (short)715497674;
				switch (num2 == num)
				{
				default:
				{
					num = (short)585170944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)526974977;
				if (num != 0)
				{
				}
				num = (short)2137194496;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00009644 File Offset: 0x00007844
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)686963525;
				short num2 = num;
				num = (short)2086681413;
				switch (num2 == num)
				{
				}
				num = (short)431226880;
				if (num != 0)
				{
				}
				num = (short)701693953;
				if (num != 0)
				{
				}
				result = base.CommandHandler.ModifyCodeplugPasswordCommand.CanExecute(new object[]
				{
					this.ModifyContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)821297152;
			short num3 = num;
			return result;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000972C File Offset: 0x0000792C
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 7;
			short num = (short)1466774782;
			short num2 = num;
			num = (short)1263351038;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)450297856;
				short num3 = num;
				num = (short)1963130880;
				if (num != 0)
				{
				}
				num = (short)860225537;
				if (num != 0)
				{
				}
				if (!(A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ﺺ얼\udcbe꓀돂뇄껆ꛈꗊ背꫎ꋐꃒ듔냖볘", a_)))
				{
					this.ModifyContext.ExceptionMessage = string.Empty;
					this.AddModifyCodeplugPasswordCommand.RaiseCanExecuteChanged();
					return;
				}
				break;
			}
			}
		}

		// Token: 0x04000056 RID: 86
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext a;

		// Token: 0x04000057 RID: 87
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;

		// Token: 0x04000058 RID: 88
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.Input.ICommand c;
	}
}
