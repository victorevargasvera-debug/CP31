using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200000A RID: 10
	public class ChangePasswordViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000012 RID: 18 RVA: 0x000038E8 File Offset: 0x00001AE8
		public ChangePasswordViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext changePasswordContext) : base(eventAggregator, commandHandler)
		{
			if (global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordViewModel.RaiseCleanPasswordEvt != null)
			{
				global::System.EventArgs e = new global::System.EventArgs();
				global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordViewModel.RaiseCleanPasswordEvt(e);
			}
			this.PasswordChangeContext = changePasswordContext;
			this.PasswordChangeContext.PropertyChanged += this.a;
			this.ChangePasswordCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object>(new global::System.Action<object>(this.b), new global::System.Func<object, bool>(this.a));
			this.Close = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a));
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00003974 File Offset: 0x00001B74
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00003A20 File Offset: 0x00001C20
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> ChangePasswordCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2022612748;
				short num2 = num;
				num = (short)38838028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)598802432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)94306304;
				if (num != 0)
				{
				}
				num = (short)1838022657;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)797638657;
				if (num != 0)
				{
				}
				num = (short)1762328576;
				short num2 = num;
				num = (short)37064402;
				short num3 = num;
				num = (short)916819666;
				switch (num3 == num)
				{
				}
				num = (short)1545928704;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00003AD0 File Offset: 0x00001CD0
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00003B80 File Offset: 0x00001D80
		public new global::Microsoft.Practices.Prism.Commands.DelegateCommand Close
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)348955416;
				short num2 = num;
				num = (short)374448920;
				switch (num2 == num)
				{
				default:
				{
					num = (short)97255424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1855455232;
				if (num != 0)
				{
				}
				num = (short)272367617;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)350748673;
				if (num != 0)
				{
				}
				num = (short)544210944;
				short num2 = num;
				num = (short)339245044;
				short num3 = num;
				num = (short)388528116;
				switch (num3 == num)
				{
				}
				num = (short)715128832;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00003C30 File Offset: 0x00001E30
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00003CE0 File Offset: 0x00001EE0
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext PasswordChangeContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)869447486;
				short num2 = num;
				num = (short)1150334782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)164102144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1198915584;
				if (num != 0)
				{
				}
				num = (short)1521483777;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)770600049;
				short num2 = num;
				num = (short)1509977201;
				switch (num2 == num)
				{
				default:
				{
					num = (short)380960768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)366739457;
				if (num != 0)
				{
				}
				num = (short)97386496;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00003D8C File Offset: 0x00001F8C
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00003E3C File Offset: 0x0000203C
		public static global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordViewModel.CleanPasswordEvt RaiseCleanPasswordEvt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)345514780;
				short num2 = num;
				num = (short)435299100;
				switch (num2 == num)
				{
				default:
				{
					num = (short)573374464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)325451777;
				if (num != 0)
				{
				}
				num = (short)896204800;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordViewModel.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2045646850;
				short num2 = num;
				num = (short)1016666114;
				switch (num2 == num)
				{
				default:
				{
					num = (short)403243008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)438173697;
				if (num != 0)
				{
				}
				num = (short)608829440;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordViewModel.d = value;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003EE8 File Offset: 0x000020E8
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 15;
			if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꓠ鯢蛤苦駨鿪蓬胮鿰뻲郴蓶諸髺髼髾", a_))
			{
				short num = (short)1192012291;
				short num2 = num;
				num = (short)1552067075;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1214513153;
					if (num != 0)
					{
					}
					num = (short)694943744;
					if (num != 0)
					{
					}
					num = (short)1866334208;
					short num3 = num;
					return;
				}
				}
			}
			this.PasswordChangeContext.ExceptionMessage = string.Empty;
			this.ChangePasswordCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003FDC File Offset: 0x000021DC
		private void b(object A_0)
		{
			short num;
			try
			{
				num = (short)1505099782;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1530929521;
						short num3 = num;
						num = (short)2064130417;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_152;
						default:
							num = (short)1114374144;
							if (num != 0)
							{
							}
							goto IL_170;
						}
						break;
					}
					case 1:
						this.PasswordChangeContext.ExceptionMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ChangeRMUserPassword_PasswordNotSame;
						num = (short)116195330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_10C;
					case 3:
						goto IL_192;
					case 4:
					{
						global::System.Collections.Generic.List<global::System.Windows.Controls.PasswordBox> list = (global::System.Collections.Generic.List<global::System.Windows.Controls.PasswordBox>)A_0;
						num = (short)2077622277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::System.Collections.Generic.List<global::System.Windows.Controls.PasswordBox> list;
						if (!string.Equals(list[1].Password, list[2].Password, global::System.StringComparison.Ordinal))
						{
							goto IL_152;
						}
						this.PasswordChangeContext.SubmitSuccess = true;
						num = (short)1286406144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						switch (0)
						{
						case 0:
							goto IL_41;
						}
						continue;
					}
					IL_41:
					if (A_0.GetType().Equals(typeof(global::System.Collections.Generic.List<global::System.Windows.Controls.PasswordBox>)))
					{
						num = (short)2125856772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_170;
					IL_152:
					num = (short)66453505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_170:
					base.CloseCommand.Execute();
					num = (short)684261379;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10C:
				IL_192:;
			}
			catch (global::Motorola.Common.CustomException.CommonException exception)
			{
				this.PasswordChangeContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)524877825;
			if (num != 0)
			{
			}
			num = (short)1805320192;
			short num4 = num;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00004204 File Offset: 0x00002404
		private void a()
		{
			short num = (short)38176460;
			short num2 = num;
			num = (short)9078476;
			switch (num2 == num)
			{
			default:
			{
				num = (short)239665152;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)88801281;
			if (num != 0)
			{
			}
			num = (short)2016739328;
			if (num != 0)
			{
			}
			base.CloseCommand.Execute();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000042BC File Offset: 0x000024BC
		private bool a(object A_0)
		{
			short num = (short)169803783;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)302120960;
					short num3 = num;
					num = (short)26804226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					return false;
				case 2:
				{
					global::System.Collections.Generic.List<global::System.Windows.Controls.PasswordBox> list;
					if (list[2].Password.Length == 0)
					{
						num = (short)857669633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 3:
				{
					global::System.Collections.Generic.List<global::System.Windows.Controls.PasswordBox> list;
					if (list[0].Password.Length != 0)
					{
						num = (short)418643972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 4:
					num = (short)293470214;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					global::System.Collections.Generic.List<global::System.Windows.Controls.PasswordBox> list = (global::System.Collections.Generic.List<global::System.Windows.Controls.PasswordBox>)A_0;
					num = (short)1296760835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
				{
					num = (short)433717249;
					if (num != 0)
					{
					}
					num = (short)2007566343;
					short num4 = num;
					num = (short)849217543;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
					{
						num = (short)1752301568;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.List<global::System.Windows.Controls.PasswordBox> list;
						if (list[1].Password.Length != 0)
						{
							num = (short)2091843584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					}
					break;
				}
				case 7:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				}
				IL_46:
				if (!A_0.GetType().Equals(typeof(global::System.Collections.Generic.List<global::System.Windows.Controls.PasswordBox>)))
				{
					return true;
				}
				num = (short)1785856005;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
		}

		// Token: 0x0400002A RID: 42
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> a;

		// Token: 0x0400002B RID: 43
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;

		// Token: 0x0400002C RID: 44
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext c;

		// Token: 0x0400002D RID: 45
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::Motorola.CommonCPS.RadioManagement.Common.ChangePasswordViewModel.CleanPasswordEvt d;

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000020 RID: 32
		public delegate void CleanPasswordEvt(global::System.EventArgs e);
	}
}
