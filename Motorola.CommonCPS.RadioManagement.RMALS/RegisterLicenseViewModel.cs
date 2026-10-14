using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.ApplicationLicense
{
	// Token: 0x02000007 RID: 7
	public class RegisterLicenseViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x0600001E RID: 30 RVA: 0x0000341C File Offset: 0x0000161C
		public RegisterLicenseViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext registerApplicationLicenseContext) : base(eventAggregator, commandHandler)
		{
			this.RegisterApplicationLicenseContext = registerApplicationLicenseContext;
			this.ChooseLicenseFileCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.f));
			this.GetHostIdCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.d));
			this.QueryEidCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.e), new global::System.Func<bool>(this.b));
			this.RegisterApplicationLicenseCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.c), new global::System.Func<bool>(this.a));
			this.RegisterApplicationLicenseContext.PropertyChanged += this.a;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000034C4 File Offset: 0x000016C4
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00003574 File Offset: 0x00001774
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext RegisterApplicationLicenseContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2139947008;
				short num2 = num;
				num = (short)1931804673;
				if (num != 0)
				{
				}
				num = (short)1224969784;
				short num3 = num;
				num = (short)1792970296;
				switch (num3 == num)
				{
				}
				num = (short)1748631552;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1345650688;
				short num2 = num;
				num = (short)1848179604;
				short num3 = num;
				num = (short)1138621332;
				switch (num3 == num)
				{
				}
				num = (short)1703215105;
				if (num != 0)
				{
				}
				num = (short)780599296;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00003624 File Offset: 0x00001824
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000036D4 File Offset: 0x000018D4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ChooseLicenseFileCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1737621504;
				short num2 = num;
				num = (short)1179868981;
				short num3 = num;
				num = (short)1995792181;
				switch (num3 == num)
				{
				}
				num = (short)1804861440;
				if (num != 0)
				{
				}
				num = (short)799539201;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)966131712;
				short num2 = num;
				num = (short)34930689;
				if (num != 0)
				{
				}
				num = (short)452309399;
				short num3 = num;
				num = (short)459780503;
				switch (num3 == num)
				{
				}
				num = (short)786169856;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00003788 File Offset: 0x00001988
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00003838 File Offset: 0x00001A38
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand GetHostIdCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1672609792;
				short num2 = num;
				num = (short)850067457;
				if (num != 0)
				{
				}
				num = (short)1263787866;
				short num3 = num;
				num = (short)801431386;
				switch (num3 == num)
				{
				}
				num = (short)671612928;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1563754496;
				short num2 = num;
				num = (short)1496251709;
				short num3 = num;
				num = (short)1037565245;
				switch (num3 == num)
				{
				}
				num = (short)3866625;
				if (num != 0)
				{
				}
				num = (short)1970667520;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000038E8 File Offset: 0x00001AE8
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00003998 File Offset: 0x00001B98
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand QueryEidCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1023082496;
				short num2 = num;
				num = (short)1521131350;
				short num3 = num;
				num = (short)71802710;
				switch (num3 == num)
				{
				}
				num = (short)1425145857;
				if (num != 0)
				{
				}
				num = (short)62324736;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)631308288;
				short num2 = num;
				num = (short)861157035;
				short num3 = num;
				num = (short)847918763;
				switch (num3 == num)
				{
				}
				num = (short)1060306945;
				if (num != 0)
				{
				}
				num = (short)1544814592;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003A48 File Offset: 0x00001C48
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00003AF8 File Offset: 0x00001CF8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand RegisterApplicationLicenseCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1230045184;
				short num2 = num;
				num = (short)2063203998;
				short num3 = num;
				num = (short)2130771614;
				switch (num3 == num)
				{
				}
				num = (short)214171649;
				if (num != 0)
				{
				}
				num = (short)1037565952;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)741539840;
				short num2 = num;
				num = (short)229727209;
				short num3 = num;
				num = (short)1592941545;
				switch (num3 == num)
				{
				}
				num = (short)860880897;
				if (num != 0)
				{
				}
				num = (short)1840840704;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003BA8 File Offset: 0x00001DA8
		private void f()
		{
			short num;
			try
			{
				num = (short)2041206542;
				short num2 = num;
				num = (short)968185614;
				switch (num2 == num)
				{
				}
				num = (short)55377920;
				if (num != 0)
				{
				}
				base.CommandHandler.ChooseLicenseFileCommand.Execute(new object[]
				{
					this.RegisterApplicationLicenseContext
				});
			}
			catch (global::System.Exception exception)
			{
				this.RegisterApplicationLicenseContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1993801728;
			short num3 = num;
			num = (short)1805778945;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003CA0 File Offset: 0x00001EA0
		private void e()
		{
			short num;
			try
			{
				num = (short)2026209111;
				short num2 = num;
				num = (short)328105815;
				switch (num2 == num)
				{
				}
				num = (short)782499840;
				if (num != 0)
				{
				}
				base.CommandHandler.QueryApplicationLicenseEIDCommand.Execute(new object[]
				{
					this.RegisterApplicationLicenseContext
				});
			}
			catch (global::System.Exception exception)
			{
				this.RegisterApplicationLicenseContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1930559488;
			short num3 = num;
			num = (short)1434451969;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003D94 File Offset: 0x00001F94
		private void d()
		{
			short num;
			try
			{
				num = (short)1095935253;
				short num2 = num;
				num = (short)340567317;
				switch (num2 == num)
				{
				}
				num = (short)28442624;
				if (num != 0)
				{
				}
				base.CommandHandler.GetHostIDCommand.Execute(new object[]
				{
					this.RegisterApplicationLicenseContext
				});
			}
			catch (global::System.Exception exception)
			{
				this.RegisterApplicationLicenseContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1690632192;
			short num3 = num;
			num = (short)30081025;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003E84 File Offset: 0x00002084
		private void c()
		{
			short num;
			try
			{
				num = (short)896540294;
				short num2 = num;
				num = (short)814620294;
				switch (num2 == num)
				{
				}
				num = (short)1696464896;
				if (num != 0)
				{
				}
				base.CommandHandler.RegisterApplicationLicenseCommand.Execute(new object[]
				{
					this.RegisterApplicationLicenseContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.RegisterApplicationLicenseContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1371996160;
			short num3 = num;
			num = (short)869335041;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003F84 File Offset: 0x00002184
		private bool b()
		{
			short num;
			bool result;
			try
			{
				num = (short)1344941612;
				short num2 = num;
				num = (short)259730988;
				switch (num2 == num)
				{
				}
				num = (short)200933376;
				if (num != 0)
				{
				}
				result = base.CommandHandler.QueryApplicationLicenseEIDCommand.CanExecute(new object[]
				{
					this.RegisterApplicationLicenseContext
				});
			}
			catch (global::System.Exception exception)
			{
				this.RegisterApplicationLicenseContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)300351488;
			short num3 = num;
			num = (short)531955713;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004078 File Offset: 0x00002278
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)2126839809;
				if (num != 0)
				{
				}
				num = (short)1821415688;
				short num2 = num;
				num = (short)1040226568;
				switch (num2 == num)
				{
				}
				num = (short)910491648;
				if (num != 0)
				{
				}
				result = base.CommandHandler.RegisterApplicationLicenseCommand.CanExecute(new object[]
				{
					this.RegisterApplicationLicenseContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)538640384;
			short num3 = num;
			return result;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004160 File Offset: 0x00002360
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 12;
			short num = (short)1452148538;
			short num2 = num;
			num = (short)880346938;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)725352448;
				short num3 = num;
				num = (short)211156992;
				if (num != 0)
				{
				}
				if (!(A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.ApplicationLicense.RegisterLicenseViewModel.g("횭펯ힱ쒳습톷햹튻ꖿ뇁럃Ʂ꿇꿉", a_)))
				{
					this.RegisterApplicationLicenseContext.ExceptionMessage = string.Empty;
					this.ChooseLicenseFileCommand.RaiseCanExecuteChanged();
					this.RegisterApplicationLicenseCommand.RaiseCanExecuteChanged();
					this.GetHostIdCommand.RaiseCanExecuteChanged();
					this.QueryEidCommand.RaiseCanExecuteChanged();
					return;
				}
				break;
			}
			}
			num = (short)1760559105;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000426C File Offset: 0x0000246C
		internal static string g(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1652006385 + A_1) + (global::System.IntPtr)37 + (global::System.IntPtr)60 + (global::System.IntPtr)43 + (global::System.IntPtr)34);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
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
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}

		// Token: 0x0400001A RID: 26
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterApplicationLicenseContext a;

		// Token: 0x0400001B RID: 27
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;

		// Token: 0x0400001C RID: 28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x0400001D RID: 29
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand d;

		// Token: 0x0400001E RID: 30
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand e;
	}
}
