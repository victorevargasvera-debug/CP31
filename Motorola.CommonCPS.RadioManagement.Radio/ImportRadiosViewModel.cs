using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x0200002E RID: 46
	public class ImportRadiosViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x060001FB RID: 507 RVA: 0x00023CB4 File Offset: 0x00021EB4
		public ImportRadiosViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ImportRadiosContext importRadiosContext) : base(eventAggregator, commandHandler)
		{
			this.ImportRadiosContext = importRadiosContext;
			this.ImportRadiosContext.PropertyChanged += this.a;
			this.SwitchPasswordModeCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<string>(new global::System.Action<string>(this.a));
			this.ImportRadiosCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00023D24 File Offset: 0x00021F24
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00023DD8 File Offset: 0x00021FD8
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ImportRadiosContext ImportRadiosContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)768490340;
				short num2 = num;
				num = (short)703085412;
				switch (num2 == num)
				{
				default:
				{
					num = (short)451280896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1405157377;
				if (num != 0)
				{
				}
				num = (short)1519190016;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)646675625;
				short num2 = num;
				num = (short)471366825;
				switch (num2 == num)
				{
				default:
				{
					num = (short)456392704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1470824448;
				if (num != 0)
				{
				}
				num = (short)1577779201;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00023E88 File Offset: 0x00022088
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00023F38 File Offset: 0x00022138
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> SwitchPasswordModeCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1966121905;
				short num2 = num;
				num = (short)954770353;
				switch (num2 == num)
				{
				default:
				{
					num = (short)432275456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)384892929;
				if (num != 0)
				{
				}
				num = (short)620560384;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1924084125;
				short num2 = num;
				num = (short)873738653;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1225719808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1204748289;
				if (num != 0)
				{
				}
				num = (short)995950592;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00023FE8 File Offset: 0x000221E8
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00024094 File Offset: 0x00022294
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ImportRadiosCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1708591554;
				short num2 = num;
				num = (short)1222248898;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1872691200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1584136193;
				if (num != 0)
				{
				}
				num = (short)1576861696;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)344872301;
				short num2 = num;
				num = (short)1384207725;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1946419200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2059665408;
				if (num != 0)
				{
				}
				num = (short)1796931585;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00024144 File Offset: 0x00022344
		private void b()
		{
			short num;
			try
			{
				num = (short)281028959;
				short num2 = num;
				num = (short)1906583903;
				switch (num2 == num)
				{
				}
				num = (short)940900353;
				if (num != 0)
				{
				}
				num = (short)113508352;
				if (num != 0)
				{
				}
				base.CommandHandler.ImportRadiosCommand.Execute(new object[]
				{
					this.ImportRadiosContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.ImportRadiosContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)123404288;
			short num3 = num;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00024244 File Offset: 0x00022444
		private void a(string A_0)
		{
			int a_ = 6;
			short num = (short)60489731;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FilePassword> enumerator;
				switch (num2)
				{
				case 0:
					goto IL_25B;
				case 1:
					goto IL_206;
				case 2:
					try
					{
						num = (short)1507332;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_145;
							case 2:
								if (!enumerator.MoveNext())
								{
									num = (short)1064697859;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator.Current.Password = string.Empty;
								num = (short)412418048;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)587005953;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_D2;
								}
								continue;
							}
							IL_FB:
							num = (short)1776812034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_D2:
							goto IL_FB;
						}
						IL_145:
						return;
					}
					finally
					{
						num = (short)573243394;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_203;
							case 1:
							{
								num = (short)1606736111;
								short num3 = num;
								num = (short)584702191;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_181;
								default:
									num = (short)225902592;
									if (num != 0)
									{
									}
									enumerator.Dispose();
									num = (short)598212608;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_17B;
								}
								continue;
							}
							goto IL_17B;
							IL_181:
							num = (short)1666777089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_17B:
							if (enumerator != null)
							{
								goto IL_181;
							}
							break;
						}
						IL_203:;
					}
					goto IL_206;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				}
				IL_3D:
				num = (short)1022296064;
				short num4 = num;
				if (A_0 == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\ud8b9\uddbb춽ꦿꇁ", a_))
				{
					num = (short)350814209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.ImportRadiosContext.Password = string.Empty;
				num = (short)1374683136;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_206:
				enumerator = this.ImportRadiosContext.FilePasswords.GetEnumerator();
				num = (short)1121386498;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_25B:
			num = (short)81133569;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000244E8 File Offset: 0x000226E8
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)254054581;
				short num2 = num;
				num = (short)1201770677;
				switch (num2 == num)
				{
				}
				num = (short)1494220800;
				if (num != 0)
				{
				}
				result = base.CommandHandler.ImportRadiosCommand.CanExecute(new object[]
				{
					this.ImportRadiosContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1204027392;
			short num3 = num;
			num = (short)502857729;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000245D4 File Offset: 0x000227D4
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 4;
			if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ﶷ승\udfbb\udbbd낿뛁귃꧅ꛇ蟉꧋뷍ꏏ돑돓돕", a_))
			{
				short num = (short)195415329;
				short num2 = num;
				num = (short)1364184353;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1536229376;
					short num3 = num;
					num = (short)824311809;
					if (num != 0)
					{
					}
					num = (short)917635072;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			this.ImportRadiosContext.ExceptionMessage = string.Empty;
			this.ImportRadiosCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x040000F5 RID: 245
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ImportRadiosContext a;

		// Token: 0x040000F6 RID: 246
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<string> b;

		// Token: 0x040000F7 RID: 247
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand c;
	}
}
