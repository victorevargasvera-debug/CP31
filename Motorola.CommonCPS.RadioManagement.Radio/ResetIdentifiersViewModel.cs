using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x0200001C RID: 28
	public class ResetIdentifiersViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x0600015F RID: 351 RVA: 0x00019A90 File Offset: 0x00017C90
		public ResetIdentifiersViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext resetIdentifiersContext) : base(eventAggregator, commandHandler)
		{
			this.ResetIdentifiersContext = resetIdentifiersContext;
			resetIdentifiersContext.PropertyChanged += this.a;
			this.ResetIdentifiersCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.ClearBlankPasswordCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<string>(new global::System.Action<string>(this.ClearBlankPasswordAction));
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00019AF8 File Offset: 0x00017CF8
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00019BA4 File Offset: 0x00017DA4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext ResetIdentifiersContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)582270105;
				short num2 = num;
				num = (short)297254041;
				switch (num2 == num)
				{
				}
				num = (short)1658126337;
				if (num != 0)
				{
				}
				num = (short)1842216960;
				if (num != 0)
				{
				}
				num = (short)117047296;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2067541917;
				short num2 = num;
				num = (short)1216360349;
				switch (num2 == num)
				{
				}
				num = (short)501022721;
				if (num != 0)
				{
				}
				num = (short)1273102336;
				if (num != 0)
				{
				}
				num = (short)791085056;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00019C54 File Offset: 0x00017E54
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00019D04 File Offset: 0x00017F04
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ResetIdentifiersCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1084437615;
				short num2 = num;
				num = (short)784413807;
				switch (num2 == num)
				{
				}
				num = (short)915472385;
				if (num != 0)
				{
				}
				num = (short)84213760;
				if (num != 0)
				{
				}
				num = (short)2076770304;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)379219366;
				short num2 = num;
				num = (short)2073849254;
				switch (num2 == num)
				{
				}
				num = (short)1162936320;
				if (num != 0)
				{
				}
				num = (short)1901068289;
				if (num != 0)
				{
				}
				num = (short)42729472;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00019DB4 File Offset: 0x00017FB4
		private void b()
		{
			short num;
			try
			{
				num = (short)425286141;
				short num2 = num;
				num = (short)183785981;
				switch (num2 == num)
				{
				}
				num = (short)814219264;
				if (num != 0)
				{
				}
				num = (short)160038913;
				if (num != 0)
				{
				}
				base.CommandHandler.ResetIndentifiersCommand.Execute(new object[]
				{
					this.ResetIdentifiersContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.ResetIdentifiersContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)159383552;
			short num3 = num;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00019EB0 File Offset: 0x000180B0
		public void ClearBlankPasswordAction(string p)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1254293506;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.ResetIdentifiersContext.Password = string.Empty;
						num = (short)851509249;
						if (num != 0)
						{
						}
						num = (short)1874853888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1195507712;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					}
					}
					IL_59:
					if (!string.IsNullOrWhiteSpace(this.ResetIdentifiersContext.Password))
					{
						return;
					}
					num = (short)1250321888;
					short num4 = num;
					num = (short)1433691616;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)69795840;
						if (num != 0)
						{
						}
						num = (short)127926273;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00019FE4 File Offset: 0x000181E4
		// (set) Token: 0x06000167 RID: 359 RVA: 0x0001A094 File Offset: 0x00018294
		public global::System.Windows.Input.ICommand ClearBlankPasswordCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)47448065;
				if (num != 0)
				{
				}
				num = (short)378765209;
				short num2 = num;
				num = (short)1345879961;
				switch (num2 == num)
				{
				}
				num = (short)1493696512;
				if (num != 0)
				{
				}
				num = (short)1363017728;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)618490501;
				short num2 = num;
				num = (short)1014524549;
				switch (num2 == num)
				{
				}
				num = (short)587202561;
				if (num != 0)
				{
				}
				num = (short)1790771200;
				if (num != 0)
				{
				}
				num = (short)1754202112;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0001A144 File Offset: 0x00018344
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)1868188465;
				short num2 = num;
				num = (short)402213681;
				switch (num2 == num)
				{
				}
				num = (short)117243904;
				if (num != 0)
				{
				}
				num = (short)2140078081;
				if (num != 0)
				{
				}
				result = base.CommandHandler.ResetIndentifiersCommand.CanExecute(new object[]
				{
					this.ResetIdentifiersContext
				});
			}
			catch (global::System.Exception exception)
			{
				this.ResetIdentifiersContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1848246272;
			short num3 = num;
			return result;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0001A238 File Offset: 0x00018438
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			short num = (short)724277595;
			short num2 = num;
			num = (short)733911387;
			switch (num2 == num)
			{
			}
			num = (short)772538369;
			if (num != 0)
			{
			}
			num = (short)1312096256;
			if (num != 0)
			{
			}
			num = (short)327942144;
			short num3 = num;
			this.ResetIdentifiersCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x040000A0 RID: 160
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext a;

		// Token: 0x040000A1 RID: 161
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;

		// Token: 0x040000A2 RID: 162
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.Input.ICommand c;
	}
}
