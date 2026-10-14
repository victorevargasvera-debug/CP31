using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Template
{
	// Token: 0x02000007 RID: 7
	public class ImportTemplatesViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x0600002D RID: 45 RVA: 0x0000519C File Offset: 0x0000339C
		public ImportTemplatesViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext importTemplatesContext) : base(eventAggregator, commandHandler)
		{
			this.ImportTemplatesContext = importTemplatesContext;
			this.ImportTemplatesContext.PropertyChanged += this.a;
			this.ImportTemplatesCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.SwitchPasswordModeCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<string>(new global::System.Action<string>(this.a));
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0000520C File Offset: 0x0000340C
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000052BC File Offset: 0x000034BC
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext ImportTemplatesContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1834680320;
				short num2 = num;
				num = (short)1826988391;
				short num3 = num;
				num = (short)1749590375;
				switch (num3 == num)
				{
				}
				num = (short)2071986177;
				if (num != 0)
				{
				}
				num = (short)602603520;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)233267371;
				short num2 = num;
				num = (short)1405509803;
				switch (num2 == num)
				{
				}
				num = (short)1045430273;
				if (num != 0)
				{
				}
				num = (short)880541696;
				if (num != 0)
				{
				}
				num = (short)1295843328;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000536C File Offset: 0x0000356C
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00005418 File Offset: 0x00003618
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ImportTemplatesCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1574106026;
				short num2 = num;
				num = (short)1680536490;
				switch (num2 == num)
				{
				}
				num = (short)1817706497;
				if (num != 0)
				{
				}
				num = (short)286785536;
				if (num != 0)
				{
				}
				num = (short)433258496;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1370442335;
				short num2 = num;
				num = (short)1693796959;
				switch (num2 == num)
				{
				}
				num = (short)78774272;
				if (num != 0)
				{
				}
				num = (short)986775553;
				if (num != 0)
				{
				}
				num = (short)1047789568;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000054C8 File Offset: 0x000036C8
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00005578 File Offset: 0x00003778
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> SwitchPasswordModeCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1616524884;
				short num2 = num;
				num = (short)989804116;
				switch (num2 == num)
				{
				}
				num = (short)1611792385;
				if (num != 0)
				{
				}
				num = (short)1687945216;
				if (num != 0)
				{
				}
				num = (short)2142633984;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)188769802;
				short num2 = num;
				num = (short)45377034;
				switch (num2 == num)
				{
				}
				num = (short)1262616577;
				if (num != 0)
				{
				}
				num = (short)779223040;
				if (num != 0)
				{
				}
				num = (short)429719552;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005628 File Offset: 0x00003828
		private void b()
		{
			short num;
			try
			{
				num = (short)487629168;
				short num2 = num;
				num = (short)1907138928;
				switch (num2 == num)
				{
				}
				num = (short)406061056;
				if (num != 0)
				{
				}
				base.CommandHandler.ImportTemplatesCommand.Execute(new object[]
				{
					this.ImportTemplatesContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.ImportTemplatesContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)579928064;
			short num3 = num;
			num = (short)405471233;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005724 File Offset: 0x00003924
		private void a(string mode)
		{
			int a_ = 5;
			short num = (short)2141716482;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> enumerator;
				switch (num2)
				{
				case 0:
					try
					{
						num = (short)1238564867;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1C8;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1169096708;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1041696239;
								short num3 = num;
								num = (short)1905788399;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1B1;
								default:
									num = (short)864092160;
									if (num != 0)
									{
									}
									enumerator.Current.Password = string.Empty;
									num = (short)506855425;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_FD;
								}
								continue;
							case 4:
								goto IL_1B1;
							}
							IL_174:
							num = (short)1458569218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_FD:
							goto IL_174;
							IL_1B1:
							num = (short)295370752;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1C8:
						return;
					}
					finally
					{
						num = (short)1260781569;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)676659202;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1FD;
								}
								continue;
							case 2:
								goto IL_231;
							}
							IL_1FD:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1611792384;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_231:;
					}
					goto IL_234;
				case 1:
					goto IL_234;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 3:
					return;
				}
				IL_3E:
				num = (short)1798832129;
				if (num != 0)
				{
				}
				if (mode == global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("鯸髺軼雾戀", a_))
				{
					num = (short)1197867008;
					short num4 = num;
					num = (short)1144061953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.ImportTemplatesContext.Password = string.Empty;
				num = (short)1390215171;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_234:
				enumerator = this.ImportTemplatesContext.FilePasswords.GetEnumerator();
				num = (short)597295104;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000059DC File Offset: 0x00003BDC
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)1352144200;
				short num2 = num;
				num = (short)710088008;
				switch (num2 == num)
				{
				}
				num = (short)97648640;
				if (num != 0)
				{
				}
				result = base.CommandHandler.ImportTemplatesCommand.CanExecute(new object[]
				{
					this.ImportTemplatesContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)2120810496;
			short num3 = num;
			num = (short)1913716737;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005AC4 File Offset: 0x00003CC4
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 2;
			short num;
			if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("돵胷駹駻軽瓿欁欃栅䔇漉缋納焏甑焓", a_))
			{
				for (;;)
				{
					num = (short)1690160649;
					short num2 = num;
					num = (short)1887030793;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_5C;
					}
				}
				IL_5C:
				num = (short)1952972801;
				if (num != 0)
				{
				}
				num = (short)1568276480;
				if (num != 0)
				{
				}
				return;
			}
			num = (short)1114767360;
			short num3 = num;
			this.ImportTemplatesContext.ExceptionMessage = string.Empty;
			this.ImportTemplatesCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0400001D RID: 29
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext a;

		// Token: 0x0400001E RID: 30
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;

		// Token: 0x0400001F RID: 31
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> c;
	}
}
