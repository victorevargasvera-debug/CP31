using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000026 RID: 38
	public class MoveGroupViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x060001BD RID: 445 RVA: 0x0001FD90 File Offset: 0x0001DF90
		public MoveGroupViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.MoveDeviceContext moveDeviceContext, bool setFocus) : base(eventAggregator, commandHandler, setFocus)
		{
			this.MoveDeviceContext = moveDeviceContext;
			this.MoveDeviceContext.PropertyChanged += this.a;
			this.MoveDeviceBatchCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.MoveDeviceContext.TargetGroup = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.FindGroup(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastGroup);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0001FE0C File Offset: 0x0001E00C
		private void b()
		{
			short num;
			try
			{
				num = (short)1295485373;
				short num2 = num;
				num = (short)1967622589;
				switch (num2 == num)
				{
				}
				num = (short)381419521;
				if (num != 0)
				{
				}
				num = (short)137822208;
				if (num != 0)
				{
				}
				base.CommandHandler.MoveDeviceBatchCommand.Execute(new object[]
				{
					this.MoveDeviceContext
				});
			}
			catch (global::System.Exception exception)
			{
				this.MoveDeviceContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1474494464;
			short num3 = num;
			base.CloseCommand.Execute();
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0001FF08 File Offset: 0x0001E108
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)1254522127;
				short num2 = num;
				num = (short)2134146319;
				switch (num2 == num)
				{
				}
				num = (short)278986752;
				if (num != 0)
				{
				}
				result = base.CommandHandler.MoveDeviceBatchCommand.CanExecute(new object[]
				{
					this.MoveDeviceContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)333250561;
			if (num != 0)
			{
			}
			num = (short)1616183296;
			short num3 = num;
			return result;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0001FFF0 File Offset: 0x0001E1F0
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x000200A0 File Offset: 0x0001E2A0
		public global::Motorola.CommonCPS.RadioManagement.UIModels.MoveDeviceContext MoveDeviceContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1616132924;
				short num2 = num;
				num = (short)1733376828;
				switch (num2 == num)
				{
				}
				num = (short)1444282368;
				short num3 = num;
				num = (short)930938881;
				if (num != 0)
				{
				}
				num = (short)220659712;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)567397492;
				short num2 = num;
				num = (short)1653525620;
				switch (num2 == num)
				{
				}
				num = (short)1062469632;
				short num3 = num;
				num = (short)755564544;
				if (num != 0)
				{
				}
				num = (short)803667969;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00020150 File Offset: 0x0001E350
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x000201FC File Offset: 0x0001E3FC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand MoveDeviceBatchCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)345672713;
				short num2 = num;
				num = (short)1995738121;
				switch (num2 == num)
				{
				}
				num = (short)1197604864;
				short num3 = num;
				num = (short)288620545;
				if (num != 0)
				{
				}
				num = (short)1345388544;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)938462116;
				short num2 = num;
				num = (short)404409252;
				switch (num2 == num)
				{
				}
				num = (short)861470720;
				short num3 = num;
				num = (short)34209792;
				if (num != 0)
				{
				}
				num = (short)1733689345;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000202B0 File Offset: 0x0001E4B0
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 8;
			short num = (short)1067299786;
			short num2 = num;
			num = (short)1076081610;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1120075777;
				if (num != 0)
				{
				}
				num = (short)93126656;
				if (num != 0)
				{
				}
				if (!(A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("僚욽ꎿꟁ듃닅ꇇꗉꋋ菍뗏ꇑꟓ럕뿗뿙", a_)))
				{
					this.MoveDeviceContext.ExceptionMessage = string.Empty;
					this.MoveDeviceBatchCommand.RaiseCanExecuteChanged();
					return;
				}
				num = (short)1859584000;
				short num3 = num;
				break;
			}
			}
		}

		// Token: 0x040000CB RID: 203
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.MoveDeviceContext a;

		// Token: 0x040000CC RID: 204
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;
	}
}
