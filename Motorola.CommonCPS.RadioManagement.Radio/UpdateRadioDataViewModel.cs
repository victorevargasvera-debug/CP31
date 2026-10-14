using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x0200003B RID: 59
	public class UpdateRadioDataViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000243 RID: 579 RVA: 0x00027DFC File Offset: 0x00025FFC
		public UpdateRadioDataViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext updateRadioContext) : base(eventAggregator, commandHandler)
		{
			this.UpdateRadioContext = updateRadioContext;
			this.UpdateRadioContext.PropertyChanged += this.a;
			this.UpdateRadioDataCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a), new global::System.Func<bool>(this.b));
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00027E54 File Offset: 0x00026054
		private bool b()
		{
			short num;
			bool result;
			try
			{
				num = (short)1308121496;
				short num2 = num;
				num = (short)1135630744;
				switch (num2 == num)
				{
				}
				num = (short)672923649;
				if (num != 0)
				{
				}
				num = (short)963706880;
				if (num != 0)
				{
				}
				result = base.CommandHandler.ASTROQueryUpdateRadioCommand.CanExecute(new object[]
				{
					this.UpdateRadioContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1339031552;
			short num3 = num;
			return result;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00027F3C File Offset: 0x0002613C
		private void a()
		{
			short num;
			try
			{
				num = (short)1091388491;
				short num2 = num;
				num = (short)1452098635;
				switch (num2 == num)
				{
				}
				num = (short)1894842368;
				if (num != 0)
				{
				}
				num = (short)52494337;
				if (num != 0)
				{
				}
				base.CommandHandler.ASTROQueryUpdateRadioCommand.Execute(new object[]
				{
					this.UpdateRadioContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::Motorola.Common.CustomException.CommonException exception)
			{
				this.UpdateRadioContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1844772864;
			short num3 = num;
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00028038 File Offset: 0x00026238
		// (set) Token: 0x06000247 RID: 583 RVA: 0x000280E8 File Offset: 0x000262E8
		public global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext UpdateRadioContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2115175514;
				short num2 = num;
				num = (short)1684800602;
				switch (num2 == num)
				{
				}
				num = (short)1672740864;
				short num3 = num;
				num = (short)1359085568;
				if (num != 0)
				{
				}
				num = (short)418840577;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1192173148;
				short num2 = num;
				num = (short)2109283932;
				switch (num2 == num)
				{
				}
				num = (short)1700659200;
				short num3 = num;
				num = (short)1090191361;
				if (num != 0)
				{
				}
				num = (short)213712896;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00028198 File Offset: 0x00026398
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0002824C File Offset: 0x0002644C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand UpdateRadioDataCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1960509441;
				if (num != 0)
				{
				}
				num = (short)159634524;
				short num2 = num;
				num = (short)922604636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1075838976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1017970688;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)552781916;
				short num2 = num;
				num = (short)1889781852;
				switch (num2 == num)
				{
				}
				num = (short)2116091904;
				short num3 = num;
				num = (short)1557987329;
				if (num != 0)
				{
				}
				num = (short)1579876352;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000282FC File Offset: 0x000264FC
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			short num = (short)1812594215;
			short num2 = num;
			num = (short)763821607;
			switch (num2 == num)
			{
			}
			num = (short)772669440;
			short num3 = num;
			num = (short)695795713;
			if (num != 0)
			{
			}
			num = (short)456785920;
			if (num != 0)
			{
			}
			this.UpdateRadioContext.ExceptionMessage = string.Empty;
			this.UpdateRadioDataCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x04000136 RID: 310
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext a;

		// Token: 0x04000137 RID: 311
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;
	}
}
