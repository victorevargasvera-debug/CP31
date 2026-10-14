using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000020 RID: 32
	public class SelectCodeplugVersionViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000189 RID: 393 RVA: 0x0001C8A8 File Offset: 0x0001AAA8
		public SelectCodeplugVersionViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.SelectCodeplugVersionContext selectCodeplugVersionContext) : base(eventAggregator, commandHandler)
		{
			this.SelectCodeplugVersionContext = selectCodeplugVersionContext;
			this.SelectCodeplugVersionContext.PropertyChanged += this.a;
			this.SelectCodeplugVersionCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0001C900 File Offset: 0x0001AB00
		private void b()
		{
			short num;
			try
			{
				num = (short)1411218046;
				short num2 = num;
				num = (short)1481603710;
				switch (num2 == num)
				{
				}
				num = (short)1179844608;
				if (num != 0)
				{
				}
				base.CommandHandler.SelectCodeplugVersionCommand.Execute(new object[]
				{
					this.SelectCodeplugVersionContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.SelectCodeplugVersionContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1088552961;
			if (num != 0)
			{
			}
			num = (short)1604255744;
			short num3 = num;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0001C9FC File Offset: 0x0001ABFC
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)1063086688;
				short num2 = num;
				num = (short)934373984;
				switch (num2 == num)
				{
				}
				num = (short)983302144;
				if (num != 0)
				{
				}
				result = base.CommandHandler.SelectCodeplugVersionCommand.CanExecute(new object[]
				{
					this.SelectCodeplugVersionContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)72876033;
			if (num != 0)
			{
			}
			num = (short)918749184;
			short num3 = num;
			return result;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0001CAE4 File Offset: 0x0001ACE4
		// (set) Token: 0x0600018D RID: 397 RVA: 0x0001CB94 File Offset: 0x0001AD94
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SelectCodeplugVersionContext SelectCodeplugVersionContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1510349383;
				short num2 = num;
				num = (short)579541575;
				switch (num2 == num)
				{
				}
				num = (short)1408827393;
				if (num != 0)
				{
				}
				num = (short)1544814592;
				if (num != 0)
				{
				}
				num = (short)1972895744;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)635681091;
				short num2 = num;
				num = (short)963033411;
				switch (num2 == num)
				{
				}
				num = (short)51576832;
				if (num != 0)
				{
				}
				num = (short)1057751041;
				if (num != 0)
				{
				}
				num = (short)1589313536;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0001CC44 File Offset: 0x0001AE44
		// (set) Token: 0x0600018F RID: 399 RVA: 0x0001CCF8 File Offset: 0x0001AEF8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SelectCodeplugVersionCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1141116790;
				short num2 = num;
				num = (short)332730230;
				switch (num2 == num)
				{
				}
				num = (short)54788097;
				if (num != 0)
				{
				}
				num = (short)2052325376;
				if (num != 0)
				{
				}
				num = (short)1521156096;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)535152737;
				short num2 = num;
				num = (short)1928120417;
				switch (num2 == num)
				{
				}
				num = (short)1869742080;
				if (num != 0)
				{
				}
				num = (short)1717370881;
				if (num != 0)
				{
				}
				num = (short)898105344;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0001CDA8 File Offset: 0x0001AFA8
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 14;
			if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("蟁볃ꗅ귇뫉룋ꟍ뿏병駓돕ꯗ꧙뷛망藟", a_))
			{
				short num = (short)1048248320;
				short num2 = num;
			}
			else
			{
				short num = (short)2120101725;
				short num3 = num;
				num = (short)1044721501;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)319094784;
					if (num != 0)
					{
					}
					num = (short)2082144257;
					if (num != 0)
					{
					}
					this.SelectCodeplugVersionContext.ExceptionMessage = string.Empty;
					this.SelectCodeplugVersionCommand.RaiseCanExecuteChanged();
					return;
				}
			}
		}

		// Token: 0x040000B2 RID: 178
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.SelectCodeplugVersionContext a;

		// Token: 0x040000B3 RID: 179
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;
	}
}
