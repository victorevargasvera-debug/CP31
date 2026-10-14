using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000005 RID: 5
	public class AddRadioViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002710 File Offset: 0x00000910
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000027C0 File Offset: 0x000009C0
		public bool IsOtarIdVisible
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)649497513;
				short num2 = num;
				num = (short)581340073;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1086586880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1981612032;
				if (num != 0)
				{
				}
				num = (short)209190913;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)396882240;
				short num2 = num;
				num = (short)1190523200;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1639710720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)136708097;
				if (num != 0)
				{
				}
				num = (short)890568704;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002870 File Offset: 0x00000A70
		public AddRadioViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService localService, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.AddRadioContext addRadioContext) : base(eventAggregator, commandHandler)
		{
			this.a = localService;
			this.AddRadioContext = addRadioContext;
			this.AddRadioContext.Radio.PropertyChanged += this.a;
			this.AddRadioCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.d();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000028DC File Offset: 0x00000ADC
		private void d()
		{
			if (this.c())
			{
				short num = (short)2008533629;
				short num2 = num;
				num = (short)251316861;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)296484864;
					short num3 = num;
					num = (short)1005584384;
					if (num != 0)
					{
					}
					num = (short)792133633;
					if (num != 0)
					{
					}
					this.IsOtarIdVisible = false;
					return;
				}
				}
			}
			this.IsOtarIdVisible = true;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000029A0 File Offset: 0x00000BA0
		private bool c()
		{
			short num = (short)462088342;
			short num2 = num;
			num = (short)301590678;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1145700352;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)196149249;
			if (num != 0)
			{
			}
			num = (short)1494810624;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002A50 File Offset: 0x00000C50
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002B00 File Offset: 0x00000D00
		public global::Motorola.CommonCPS.RadioManagement.UIModels.AddRadioContext AddRadioContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)490342586;
				short num2 = num;
				num = (short)220924090;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1417347072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1300234241;
				if (num != 0)
				{
				}
				num = (short)1400963072;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1421291725;
				short num2 = num;
				num = (short)655306957;
				switch (num2 == num)
				{
				default:
				{
					num = (short)670498816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)326696960;
				if (num != 0)
				{
				}
				num = (short)1251999745;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002BB0 File Offset: 0x00000DB0
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002C64 File Offset: 0x00000E64
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand AddRadioCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)636899167;
				short num2 = num;
				num = (short)1518554975;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1197604864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)576454657;
				if (num != 0)
				{
				}
				num = (short)1143209984;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)8587302;
				short num2 = num;
				num = (short)662964262;
				switch (num2 == num)
				{
				default:
				{
					num = (short)628162560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)647430145;
				if (num != 0)
				{
				}
				num = (short)223674368;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002D18 File Offset: 0x00000F18
		private void b()
		{
			short num;
			try
			{
				num = (short)755607549;
				short num2 = num;
				num = (short)1993385981;
				switch (num2 == num)
				{
				}
				num = (short)147652608;
				if (num != 0)
				{
				}
				num = (short)235667457;
				if (num != 0)
				{
				}
				base.CommandHandler.AddRadioCommand.Execute(new object[]
				{
					this.AddRadioContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::Motorola.Common.CustomException.CommonException exception)
			{
				this.AddRadioContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)28704768;
			short num3 = num;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002E18 File Offset: 0x00001018
		private bool a()
		{
			short num;
			bool result;
			try
			{
				for (;;)
				{
					num = (short)347865090;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CommunicationServerNotAvailabe, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CantConnectWebService.ToString(), null)), true, false);
							result = false;
							num = (short)2121072643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_D8;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_36;
							}
							continue;
						case 3:
							goto IL_9C;
						}
						IL_36:
						if (!this.a.IsConnected)
						{
							num = (short)1461977088;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							result = base.CommandHandler.AddRadioCommand.CanExecute(new object[]
							{
								this.AddRadioContext
							});
							num = (short)1311375361;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_D8:
					num = (short)293625223;
					short num3 = num;
					num = (short)848321927;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_10D;
					}
				}
				IL_9C:
				goto IL_15A;
				IL_10D:
				num = (short)1725628416;
				if (num != 0)
				{
				}
				num = (short)1444020225;
				if (num != 0)
				{
				}
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			IL_15A:
			num = (short)680460288;
			short num4 = num;
			return result;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002FC8 File Offset: 0x000011C8
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 11;
			if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("諭맀ꃂꃄ럆뷈ꋊꋌꇎ鳐뛒ꛔꓖ룘볚룜", a_))
			{
				short num = (short)1574976646;
				short num2 = num;
				num = (short)892288134;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2136801280;
					short num3 = num;
					num = (short)1904279553;
					if (num != 0)
					{
					}
					num = (short)28770304;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this.AddRadioContext.ExceptionMessage = string.Empty;
			this.AddRadioCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0400001A RID: 26
		private readonly global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService a;

		// Token: 0x0400001B RID: 27
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b;

		// Token: 0x0400001C RID: 28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.AddRadioContext c;

		// Token: 0x0400001D RID: 29
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand d;
	}
}
