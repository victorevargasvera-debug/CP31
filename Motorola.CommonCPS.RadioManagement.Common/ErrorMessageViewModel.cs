using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000017 RID: 23
	public class ErrorMessageViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00008E0C File Offset: 0x0000700C
		public ErrorMessageViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ErrorMessageContext errorMsgContext) : base(eventAggregator, commandHandler)
		{
			this.ErrorMessageContext = errorMsgContext;
			this.ErrorMessageContext.PropertyChanged += this.a;
			this.b = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.a), new global::System.Func<bool>(this.CanDisplayErrorMessage));
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00008E64 File Offset: 0x00007064
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00008F18 File Offset: 0x00007118
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ErrorMessageContext ErrorMessageContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)692794857;
				short num2 = num;
				num = (short)1828664809;
				switch (num2 == num)
				{
				}
				num = (short)1390411776;
				if (num != 0)
				{
				}
				num = (short)204734465;
				if (num != 0)
				{
				}
				num = (short)989528064;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)39058189;
				short num2 = num;
				num = (short)1536621325;
				switch (num2 == num)
				{
				}
				num = (short)1721303041;
				if (num != 0)
				{
				}
				num = (short)1694629888;
				if (num != 0)
				{
				}
				num = (short)2008154112;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00008FC8 File Offset: 0x000071C8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ErrorMessageCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)883882261;
				short num2 = num;
				num = (short)540670229;
				switch (num2 == num)
				{
				}
				num = (short)439877633;
				if (num != 0)
				{
				}
				num = (short)1749417984;
				if (num != 0)
				{
				}
				num = (short)1982005248;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00009074 File Offset: 0x00007274
		private void a()
		{
			short num;
			try
			{
				num = (short)656784383;
				short num2 = num;
				num = (short)1710603263;
				switch (num2 == num)
				{
				}
				num = (short)1342308352;
				if (num != 0)
				{
				}
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.ErrorMessageContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)898433025;
			if (num != 0)
			{
			}
			num = (short)599719936;
			short num3 = num;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00009150 File Offset: 0x00007350
		public bool CanDisplayErrorMessage()
		{
			short num = (short)1700397057;
			if (num != 0)
			{
			}
			num = (short)177123913;
			short num2 = num;
			num = (short)513847881;
			switch (num2 == num)
			{
			}
			num = (short)735313920;
			if (num != 0)
			{
			}
			num = (short)736821248;
			short num3 = num;
			return true;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000091FC File Offset: 0x000073FC
		protected override void OnWindowClosed()
		{
			short num = (short)133997902;
			short num2 = num;
			num = (short)1926604110;
			switch (num2 == num)
			{
			}
			num = (short)940113921;
			if (num != 0)
			{
			}
			num = (short)851312640;
			if (num != 0)
			{
			}
			num = (short)424345600;
			short num3 = num;
			base.OnWindowClosed();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000092B0 File Offset: 0x000074B0
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 3;
			short num = (short)2135692904;
			short num2 = num;
			num = (short)1981355624;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)602865664;
				short num3 = num;
				num = (short)1569849344;
				if (num != 0)
				{
				}
				if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("郔꿖뫘뻚규ꯞ裠賢诤ꫦ賨飪黬軮雰雲", a_))
				{
					num = (short)1749024769;
					if (num != 0)
					{
					}
					return;
				}
				break;
			}
			}
			this.ErrorMessageContext.ExceptionMessage = string.Empty;
			this.ErrorMessageCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0400005E RID: 94
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ErrorMessageContext a;

		// Token: 0x0400005F RID: 95
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand b;
	}
}
