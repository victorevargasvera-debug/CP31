using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Template
{
	// Token: 0x0200000C RID: 12
	public class SelectFirmwareViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00008458 File Offset: 0x00006658
		public SelectFirmwareViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext) : base(eventAggregator, commandHandler)
		{
			this.SelectFirmwareContext = selectFirmwareContext;
			this.SelectFirmwareContext.PropertyChanged += this.a;
			this.SelectFirmwareCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000084B0 File Offset: 0x000066B0
		private void b()
		{
			short num;
			try
			{
				num = (short)213912214;
				short num2 = num;
				num = (short)134613654;
				switch (num2 == num)
				{
				}
				num = (short)596312064;
				if (num != 0)
				{
				}
				base.CommandHandler.SelectFirmwareForUpgradeCommand.Execute(new object[]
				{
					this.SelectFirmwareContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.SelectFirmwareContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)271384577;
			if (num != 0)
			{
			}
			num = (short)935460864;
			short num3 = num;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000085AC File Offset: 0x000067AC
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)696555081;
				short num2 = num;
				num = (short)131896905;
				switch (num2 == num)
				{
				}
				num = (short)1743126528;
				if (num != 0)
				{
				}
				num = (short)612958209;
				if (num != 0)
				{
				}
				result = base.CommandHandler.SelectFirmwareForUpgradeCommand.CanExecute(new object[]
				{
					this.SelectFirmwareContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1256194048;
			short num3 = num;
			return result;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00008694 File Offset: 0x00006894
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00008740 File Offset: 0x00006940
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext SelectFirmwareContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)708694156;
				short num2 = num;
				num = (short)779669644;
				switch (num2 == num)
				{
				default:
				{
					num = (short)42270720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)971767809;
				if (num != 0)
				{
				}
				num = (short)86966272;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)760159894;
				short num2 = num;
				num = (short)2070879894;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1397817344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1448542208;
				if (num != 0)
				{
				}
				num = (short)1160380417;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000087F4 File Offset: 0x000069F4
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000088A0 File Offset: 0x00006AA0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SelectFirmwareCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1876108700;
				short num2 = num;
				num = (short)291317148;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1443692544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)964100097;
				if (num != 0)
				{
				}
				num = (short)676986880;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1936234942;
				short num2 = num;
				num = (short)440572350;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1625292800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)208535553;
				if (num != 0)
				{
				}
				num = (short)599916544;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00008950 File Offset: 0x00006B50
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 14;
			short num = (short)1214447618;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_107;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				num = (short)673251329;
				if (num != 0)
				{
				}
				num = (short)1029218363;
				short num3 = num;
				num = (short)856727611;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_107:
					this.SelectFirmwareCommand.RaiseCanExecuteChanged();
					num = (short)898760704;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)504168448;
					if (num != 0)
					{
					}
					num = (short)1014562816;
					short num4 = num;
					if (!(A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("䜁簃攅洇稉砋服缏簑夓猕欗椙紛礝䔟", a_)))
					{
						return;
					}
					num = (short)1967063041;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x0400002F RID: 47
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext a;

		// Token: 0x04000030 RID: 48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;
	}
}
