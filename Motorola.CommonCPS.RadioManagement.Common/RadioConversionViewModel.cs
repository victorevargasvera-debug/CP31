using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200001D RID: 29
	public class RadioConversionViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000C8F8 File Offset: 0x0000AAF8
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000C9AC File Offset: 0x0000ABAC
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioConversionContext RadioConversionContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)367929513;
				short num2 = num;
				num = (short)1641556137;
				switch (num2 == num)
				{
				default:
				{
					num = (short)196280320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)275775489;
				if (num != 0)
				{
				}
				num = (short)1133707264;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)615435481;
				short num2 = num;
				num = (short)242011353;
				switch (num2 == num)
				{
				default:
				{
					num = (short)854589440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)297402369;
				if (num != 0)
				{
				}
				num = (short)371982336;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000CA5C File Offset: 0x0000AC5C
		public RadioConversionViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioConversionContext context) : base(eventAggregator, commandHandler)
		{
			this.RadioConversionContext = context;
			this.ConvertRadioCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.FieldCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>(new global::System.Action<object[]>(this.a));
			this.SelectedAllCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object>(new global::System.Action<object>(this.a));
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000CACC File Offset: 0x0000ACCC
		private void b()
		{
			short num;
			try
			{
				num = (short)132163293;
				short num2 = num;
				num = (short)556574429;
				switch (num2 == num)
				{
				}
				num = (short)1320812544;
				if (num != 0)
				{
				}
				num = (short)1236336641;
				if (num != 0)
				{
				}
				base.CommandHandler.ConvertRadioInBatchCommand.Execute(new object[]
				{
					this.RadioConversionContext.SelectedRadios
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)698023936;
			short num3 = num;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000CBC4 File Offset: 0x0000ADC4
		private void a(object[] A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					this.RadioConversionContext.SelectedRadios.Add(item);
					num2 = (short)1605379890;
					short num3 = num2;
					num2 = (short)1150494514;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_86;
					default:
						num2 = (short)134807552;
						if (num2 != 0)
						{
						}
						num2 = (short)361037826;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)2030305281;
					if (num2 != 0)
					{
					}
					if ((bool)A_0[2])
					{
						num2 = (short)1946681344;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_86;
				case 2:
					goto IL_14E;
				case 3:
					goto IL_D7;
				}
				goto IL_20;
				IL_86:
				this.RadioConversionContext.SelectedRadios.Remove(item);
				num2 = (short)979566592;
				short num4 = num2;
				num2 = (short)1703149571;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D7:
			IL_14E:
			this.ConvertRadioCommand.RaiseCanExecuteChanged();
			return;
			IL_20:
			item = (A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase);
			num2 = (short)1053622273;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000CD2C File Offset: 0x0000AF2C
		private void a(object A_0)
		{
			short num = (short)2066153472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				object[] array;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> list;
					bool? flag;
					bool flag2;
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator = list.GetEnumerator();
						num = (short)418906115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)1027145730;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1650262020;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = enumerator2.Current;
									this.RadioConversionContext.SelectedRadios.Add(item);
									num = (short)675151872;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_357;
									}
									continue;
								case 3:
									goto IL_3DC;
								case 4:
									num = (short)1878065155;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_38B:
								num = (short)1205338113;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_357:
								goto IL_38B;
							}
							IL_3DC:
							goto IL_4A2;
						}
						finally
						{
							num = (short)308346880;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator2;
								switch (num2)
								{
								case 0:
									num = (short)1340801025;
									if (num != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_43B;
									}
									continue;
								case 1:
									goto IL_471;
								case 2:
									enumerator2.Dispose();
									num = (short)1835728897;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_43B:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)375717890;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_471:;
						}
						goto IL_474;
					case 2:
						goto IL_49D;
					case 3:
						try
						{
							num = (short)1968439298;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										goto IL_F0;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase = enumerator.Current;
									this.RadioConversionContext.SelectedRadios.Add(uimodelBase as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase);
									num = (short)1312489476;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)685506563;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_CF;
									}
									continue;
								case 3:
								{
									num = (short)92584081;
									short num3 = num;
									num = (short)641841297;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_F0;
									default:
										goto IL_18F;
									}
									break;
								}
								}
								IL_D1:
								num = (short)1491664896;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CF:
								goto IL_D1;
								IL_F0:
								num = (short)1442381825;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_18F:
							num = (short)1509687296;
							if (num != 0)
							{
							}
							goto IL_4A2;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1B7;
					case 4:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)354746377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_474;
					case 5:
						flag = (bool?)A_0;
						flag2 = true;
						num = (short)1863647236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (array == null)
						{
							num = (short)1928331269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B7;
					case 7:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)2071920640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.RadioConversionContext.SelectedRadios.Clear();
						num = (short)606863368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_318;
					case 9:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator2 = this.RadioConversionContext.Radios.GetEnumerator();
						num = (short)1796276224;
						short num4 = num;
						num = (short)31653889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_56;
					IL_1B7:
					bool? flag3 = (bool?)array[0];
					list = (array[1] as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>);
					flag = flag3;
					flag2 = true;
					num = (short)1148387335;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_474:
					this.RadioConversionContext.SelectedRadios.Clear();
					num = (short)693567490;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_318:
				IL_49D:
				IL_4A2:
				this.ConvertRadioCommand.RaiseCanExecuteChanged();
				return;
				IL_56:
				array = (A_0 as object[]);
				num = (short)1326710790;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000D21C File Offset: 0x0000B41C
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)1382626733;
				short num2 = num;
				num = (short)1805071789;
				switch (num2 == num)
				{
				}
				num = (short)342163457;
				if (num != 0)
				{
				}
				num = (short)95420416;
				if (num != 0)
				{
				}
				result = base.CommandHandler.ConvertRadioInBatchCommand.CanExecute(new object[]
				{
					this.RadioConversionContext.SelectedRadios
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)203227136;
			short num3 = num;
			return result;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000D308 File Offset: 0x0000B508
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0000D3B8 File Offset: 0x0000B5B8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> FieldCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1737394823;
				short num2 = num;
				num = (short)615615111;
				switch (num2 == num)
				{
				default:
				{
					num = (short)709165056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)882114560;
				if (num != 0)
				{
				}
				num = (short)1656422401;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)162353256;
				short num2 = num;
				num = (short)464146536;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1134100480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1626669057;
				if (num != 0)
				{
				}
				num = (short)988086272;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000D468 File Offset: 0x0000B668
		// (set) Token: 0x060000AE RID: 174 RVA: 0x0000D51C File Offset: 0x0000B71C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ConvertRadioCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1404764161;
				if (num != 0)
				{
				}
				num = (short)2136145920;
				short num2 = num;
				num = (short)1539621333;
				short num3 = num;
				num = (short)6013397;
				switch (num3 == num)
				{
				}
				num = (short)7471104;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1454348115;
				short num2 = num;
				num = (short)1880856403;
				switch (num2 == num)
				{
				default:
				{
					num = (short)170459136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)891486209;
				if (num != 0)
				{
				}
				num = (short)984219648;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000D5CC File Offset: 0x0000B7CC
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000D67C File Offset: 0x0000B87C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> SelectedAllCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)362807297;
				if (num != 0)
				{
				}
				num = (short)2077687808;
				short num2 = num;
				num = (short)1581156375;
				short num3 = num;
				num = (short)1262323735;
				switch (num3 == num)
				{
				}
				num = (short)1833435136;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1904306788;
				short num2 = num;
				num = (short)1389914724;
				switch (num2 == num)
				{
				default:
				{
					num = (short)195231744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)188416001;
				if (num != 0)
				{
				}
				num = (short)461504512;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x0400009E RID: 158
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioConversionContext a;

		// Token: 0x0400009F RID: 159
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> b;

		// Token: 0x040000A0 RID: 160
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x040000A1 RID: 161
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> d;
	}
}
