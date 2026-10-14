using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
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
	// Token: 0x0200002F RID: 47
	public class UserLoginViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600013E RID: 318 RVA: 0x000169C8 File Offset: 0x00014BC8
		// (remove) Token: 0x0600013F RID: 319 RVA: 0x00016AFC File Offset: 0x00014CFC
		public event global::System.EventHandler CloseWindow
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler eventHandler2;
					switch (num)
					{
					case 0:
						goto IL_37;
					case 1:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)37486594;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_63;
					case 2:
					{
						num2 = (short)1042259481;
						short num3 = num2;
						num2 = (short)878222873;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_37;
						default:
							goto IL_E9;
						}
						break;
					}
					}
					goto IL_1C;
					IL_63:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.a, value2, eventHandler2);
					num2 = (short)1103233025;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_37:
					num2 = (short)992608256;
					short num4 = num2;
					goto IL_63;
				}
				IL_E9:
				num2 = (short)1904934912;
				if (num2 != 0)
				{
				}
				num2 = (short)270336001;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.a;
				num2 = (short)1631584256;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler eventHandler;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler eventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)306123873;
						short num3 = num2;
						num2 = (short)1528960097;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7C;
						default:
							num2 = (short)1686503424;
							if (num2 != 0)
							{
							}
							if (eventHandler == eventHandler2)
							{
								num2 = (short)1566441473;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_5F;
						}
						break;
					}
					case 1:
						goto IL_FE;
					case 2:
						goto IL_5F;
					}
					goto IL_1C;
					IL_7C:
					num2 = (short)362610688;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_5F:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.a, value2, eventHandler2);
					goto IL_7C;
				}
				IL_FE:
				num2 = (short)2100887552;
				short num4 = num2;
				return;
				IL_1C:
				num2 = (short)1853816833;
				if (num2 != 0)
				{
				}
				eventHandler = this.a;
				num2 = (short)1223032834;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00016C34 File Offset: 0x00014E34
		public UserLoginViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext userLoginContext) : base(eventAggregator, commandHandler)
		{
			if (global::Motorola.CommonCPS.RadioManagement.Common.UserLoginViewModel.RaiseCleanUserLoginFormEvt != null)
			{
				global::System.EventArgs e = new global::System.EventArgs();
				global::Motorola.CommonCPS.RadioManagement.Common.UserLoginViewModel.RaiseCleanUserLoginFormEvt(e);
			}
			this.UserLoginContext = userLoginContext;
			this.UserLoginContext.PropertyChanged += this.a;
			this.LoginCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object>(new global::System.Action<object>(this.b), new global::System.Func<object, bool>(this.a));
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00016CA8 File Offset: 0x00014EA8
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00016D58 File Offset: 0x00014F58
		public global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext UserLoginContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1457954959;
				short num2 = num;
				num = (short)1592762511;
				switch (num2 == num)
				{
				}
				num = (short)1955201025;
				if (num != 0)
				{
				}
				num = (short)154927104;
				short num3 = num;
				num = (short)1807024128;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)849947220;
				short num2 = num;
				num = (short)2108172884;
				switch (num2 == num)
				{
				}
				num = (short)1475018753;
				if (num != 0)
				{
				}
				num = (short)1783103488;
				short num3 = num;
				num = (short)1530134528;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00016E08 File Offset: 0x00015008
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00016EB8 File Offset: 0x000150B8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> LoginCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)748350198;
				short num2 = num;
				num = (short)958786294;
				switch (num2 == num)
				{
				}
				num = (short)497745920;
				if (num != 0)
				{
				}
				num = (short)1443299328;
				short num3 = num;
				num = (short)1712848897;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1803387142;
				short num2 = num;
				num = (short)728137990;
				switch (num2 == num)
				{
				}
				num = (short)2053373953;
				if (num != 0)
				{
				}
				num = (short)712179712;
				short num3 = num;
				num = (short)470351872;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00016F68 File Offset: 0x00015168
		private void b(object A_0)
		{
			short num;
			try
			{
				num = (short)870907910;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_14F;
					case 1:
						this.UserLoginContext.SubmitSuccess = true;
						base.CloseCommand.Execute();
						num = (short)1476395008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)169476099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (A_0.GetType().Equals(typeof(global::System.Windows.Controls.PasswordBox)))
						{
							goto IL_136;
						}
						goto IL_5E;
					case 4:
						goto IL_167;
					case 5:
						goto IL_14F;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_42;
						}
						continue;
					}
					IL_42:
					if (A_0 != null)
					{
						num = (short)2086600706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5E:
					this.UserLoginContext.ExceptionMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.Unknown_Error_For_User_Login;
					num = (short)304363602;
					short num3 = num;
					num = (short)81279058;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_136:
						num = (short)1908867073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)1039925248;
						if (num != 0)
						{
						}
						num = (short)805240837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_14F:
					num = (short)1381040132;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_167:;
			}
			catch (global::Motorola.Common.CustomException.CommonException exception)
			{
				this.UserLoginContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1187250177;
			if (num != 0)
			{
			}
			num = (short)2038890496;
			short num4 = num;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00017160 File Offset: 0x00015360
		private bool a(object A_0)
		{
			short num = (short)1584922629;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1230766081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1750139732;
					short num3 = num;
					num = (short)494601044;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)1953038336;
						if (num != 0)
						{
						}
						if (((global::System.Windows.Controls.PasswordBox)A_0).Password.Length != 0)
						{
							num = (short)445710339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				case 2:
					goto IL_103;
				case 3:
					num = (short)1021116420;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (this.UserLoginContext.UserName.Length == 0)
					{
						num = (short)430964736;
						short num4 = num;
						num = (short)1098776578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				}
				IL_3C:
				if (!A_0.GetType().Equals(typeof(global::System.Windows.Controls.PasswordBox)))
				{
					return true;
				}
				num = (short)195100673;
				if (num != 0)
				{
				}
				num = (short)1543503872;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_103:
			return false;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0001730C File Offset: 0x0001550C
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 17;
			if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ꛢ鷤蓦賨鯪駬蛮黰鷲룴鋶諸裺鳼飾搀", a_))
			{
				short num = (short)1066729473;
				if (num != 0)
				{
				}
				num = (short)1679101705;
				short num2 = num;
				num = (short)554307337;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C2;
				case 1:
					break;
				default:
				{
					num = (short)403046400;
					short num3 = num;
					break;
				}
				}
				num = (short)1717567488;
				if (num != 0)
				{
				}
				return;
			}
			IL_C2:
			this.UserLoginContext.ExceptionMessage = string.Empty;
			this.LoginCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000173F8 File Offset: 0x000155F8
		// (set) Token: 0x06000149 RID: 329 RVA: 0x000174A8 File Offset: 0x000156A8
		public static global::Motorola.CommonCPS.RadioManagement.Common.UserLoginViewModel.CleanUserLoginFormEvt RaiseCleanUserLoginFormEvt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)543668789;
				short num2 = num;
				num = (short)1540012597;
				switch (num2 == num)
				{
				}
				num = (short)1002635264;
				if (num != 0)
				{
				}
				num = (short)73072640;
				short num3 = num;
				num = (short)1465057281;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Common.UserLoginViewModel.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)341729038;
				short num2 = num;
				num = (short)1902731022;
				switch (num2 == num)
				{
				}
				num = (short)1249705984;
				if (num != 0)
				{
				}
				num = (short)1348993024;
				short num3 = num;
				num = (short)1411186689;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Common.UserLoginViewModel.d = value;
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00017558 File Offset: 0x00015758
		protected virtual void OnCloseWindow(global::System.EventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::System.EventHandler eventHandler;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					for (;;)
					{
						num2 = (short)2066777669;
						short num3 = num2;
						num2 = (short)657294917;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_B1;
						}
					}
					IL_B1:
					num2 = (short)1252065280;
					if (num2 != 0)
					{
					}
					eventHandler(this, e);
					num2 = (short)1121714177;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_E7;
				case 2:
					if (eventHandler != null)
					{
						num2 = (short)1877934080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E9;
				}
				goto IL_1C;
			}
			IL_E7:
			IL_E9:
			num2 = (short)59047936;
			short num4 = num2;
			return;
			IL_1C:
			num2 = (short)2102460417;
			if (num2 != 0)
			{
			}
			eventHandler = this.a;
			num2 = (short)445841410;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040000EE RID: 238
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler a;

		// Token: 0x040000EF RID: 239
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext b;

		// Token: 0x040000F0 RID: 240
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> c;

		// Token: 0x040000F1 RID: 241
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::Motorola.CommonCPS.RadioManagement.Common.UserLoginViewModel.CleanUserLoginFormEvt d;

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600014C RID: 332
		public delegate void CleanUserLoginFormEvt(global::System.EventArgs e);
	}
}
