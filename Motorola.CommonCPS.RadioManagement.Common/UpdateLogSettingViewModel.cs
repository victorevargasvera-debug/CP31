using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200000D RID: 13
	public class UpdateLogSettingViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00004730 File Offset: 0x00002930
		public UpdateLogSettingViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting logSetting) : base(eventAggregator, commandHandler)
		{
			this.a = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object>(new global::System.Action<object>(this.a));
			this.b = logSetting;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00004764 File Offset: 0x00002964
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> UpdateLogSettingCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)482550960;
				short num2 = num;
				num = (short)1690510512;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1203896320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)583860225;
				if (num != 0)
				{
				}
				num = (short)875233280;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00004810 File Offset: 0x00002A10
		public global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting LogSetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)364165002;
				short num2 = num;
				num = (short)876328842;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1262026752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1468203008;
				if (num != 0)
				{
				}
				num = (short)628883457;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000048C0 File Offset: 0x00002AC0
		private void a(object A_0)
		{
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_2C;
				}
				int num;
				bool flag;
				for (;;)
				{
					IL_0A:
					bool flag2;
					switch (num)
					{
					case 0:
						goto IL_1D7;
					case 1:
						goto IL_E6;
					case 2:
						if (flag != flag2)
						{
							num2 = (short)911867909;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1D7;
					case 3:
						goto IL_1FB;
					case 4:
					{
						bool flag3 = (bool)base.CommandHandler.ChangeShowDialogCommand.Execute(new object[]
						{
							new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility>
							{
								new global::Motorola.CommonCPS.RadioManagement.UIModels.DialogVisibility
								{
									Operation = global::Motorola.CommonCPS.RadioManagement.UIModels.UserOperationType.ChangeLogSetting,
									Show = false
								}
							}
						});
						num2 = (short)410255361;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
						this.LogSetting.UploadToServer = flag;
						base.CommandHandler.UpdateLogSettingCommand.Execute(new object[]
						{
							this.LogSetting
						});
						num2 = (short)444661761;
						if (num2 != 0)
						{
						}
						num2 = (short)1026359296;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						if (this.LogSetting.HideDialogChecked)
						{
							num2 = (short)572915716;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_E6;
					}
					goto IL_2C;
					IL_E6:
					bool.TryParse(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.UploadLogToServer, out flag2);
					num2 = (short)503548838;
					short num3 = num2;
					num2 = (short)556501926;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)755367936;
						if (num2 != 0)
						{
						}
						num2 = (short)1946943490;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					IL_1D7:
					base.CloseCommand.Execute();
					num2 = (short)663814147;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1FB:
				goto IL_207;
				IL_2C:
				flag = bool.Parse((string)A_0);
				num2 = (short)1876033542;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			IL_207:
			num2 = (short)1209794560;
			short num4 = num2;
		}

		// Token: 0x04000031 RID: 49
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> a;

		// Token: 0x04000032 RID: 50
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting b;
	}
}
