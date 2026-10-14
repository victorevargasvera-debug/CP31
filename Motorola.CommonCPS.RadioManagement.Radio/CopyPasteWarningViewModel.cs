using System;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x0200000B RID: 11
	public class CopyPasteWarningViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00005150 File Offset: 0x00003350
		public CopyPasteWarningViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteWarningContext copyPasteWarningContext) : base(eventAggregator, commandHandler)
		{
			this.CopyPasteWarningContext = copyPasteWarningContext;
			this.SubmitPasteValueCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00005190 File Offset: 0x00003390
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00005240 File Offset: 0x00003440
		public global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteWarningContext CopyPasteWarningContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1624228942;
				short num2 = num;
				num = (short)531285070;
				switch (num2 == num)
				{
				}
				num = (short)1103429633;
				if (num != 0)
				{
				}
				num = (short)2054946816;
				if (num != 0)
				{
				}
				num = (short)1396637696;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1820545913;
				short num2 = num;
				num = (short)1065636729;
				switch (num2 == num)
				{
				}
				num = (short)7667713;
				if (num != 0)
				{
				}
				num = (short)708313088;
				if (num != 0)
				{
				}
				num = (short)556990464;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000052F0 File Offset: 0x000034F0
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000053A4 File Offset: 0x000035A4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SubmitPasteValueCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)425360537;
				short num2 = num;
				num = (short)1173781657;
				switch (num2 == num)
				{
				}
				num = (short)309788673;
				if (num != 0)
				{
				}
				num = (short)1513619456;
				if (num != 0)
				{
				}
				num = (short)1871446016;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1588415258;
				short num2 = num;
				num = (short)1520913178;
				switch (num2 == num)
				{
				}
				num = (short)1326055424;
				if (num != 0)
				{
				}
				num = (short)71499777;
				if (num != 0)
				{
				}
				num = (short)146604032;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00005458 File Offset: 0x00003658
		private void b()
		{
			short num;
			try
			{
				num = (short)441805018;
				short num2 = num;
				num = (short)45312218;
				switch (num2 == num)
				{
				}
				num = (short)748421120;
				if (num != 0)
				{
				}
				base.CloseCommand.Execute();
				base.CommandHandler.SubmitPasteValueCommand.Execute(new object[]
				{
					this.CopyPasteWarningContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)1919025153;
			if (num != 0)
			{
			}
			num = (short)103350272;
			short num3 = num;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000554C File Offset: 0x0000374C
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)926545129;
				short num2 = num;
				num = (short)2103047401;
				switch (num2 == num)
				{
				}
				num = (short)858521600;
				if (num != 0)
				{
				}
				result = base.CommandHandler.SubmitPasteValueCommand.CanExecute(new object[]
				{
					this.CopyPasteWarningContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
				result = false;
			}
			num = (short)329646081;
			if (num != 0)
			{
			}
			num = (short)463273984;
			short num3 = num;
			return result;
		}

		// Token: 0x04000026 RID: 38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteWarningContext a;

		// Token: 0x04000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;
	}
}
