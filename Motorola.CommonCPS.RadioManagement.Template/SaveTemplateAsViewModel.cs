using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Template
{
	// Token: 0x02000004 RID: 4
	public class SaveTemplateAsViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00003284 File Offset: 0x00001484
		public SaveTemplateAsViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.SaveTemplateAsContext saveTemplateAsContext) : base(eventAggregator, commandHandler)
		{
			this.a = saveTemplateAsContext;
			this.SaveTemplateAsContext.PropertyChanged += this.a;
			this.SaveTemplateAsContext.RadioOptions.CollectionChanged += this.a;
			this.CancelSaveTemplateAsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.c));
			this.c = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.FieldCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>(new global::System.Action<object[]>(this.a));
			this.SelectedAllCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object>(new global::System.Action<object>(this.a));
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000333C File Offset: 0x0000153C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SaveTemplateAsContext SaveTemplateAsContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1045568498;
				short num2 = num;
				num = (short)1528306674;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1413021696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)691666945;
				if (num != 0)
				{
				}
				num = (short)1681653760;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000033F0 File Offset: 0x000015F0
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000034A0 File Offset: 0x000016A0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CancelSaveTemplateAsCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1138508187;
				short num2 = num;
				num = (short)1245856155;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1942683648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1835728897;
				if (num != 0)
				{
				}
				num = (short)1564016640;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)259980788;
				short num2 = num;
				num = (short)1600847348;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1553072128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1027604480;
				if (num != 0)
				{
				}
				num = (short)1118830593;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00003550 File Offset: 0x00001750
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SaveTemplateAsCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1363054903;
				short num2 = num;
				num = (short)2078642487;
				switch (num2 == num)
				{
				default:
				{
					num = (short)536870912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1743781889;
				if (num != 0)
				{
				}
				num = (short)274399232;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00003600 File Offset: 0x00001800
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000036B0 File Offset: 0x000018B0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> FieldCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)976380651;
				short num2 = num;
				num = (short)195519211;
				switch (num2 == num)
				{
				default:
				{
					num = (short)598540288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1277624321;
				if (num != 0)
				{
				}
				num = (short)88342528;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)32899073;
				if (num != 0)
				{
				}
				num = (short)784859136;
				short num2 = num;
				num = (short)1658248658;
				short num3 = num;
				num = (short)509664722;
				switch (num3 == num)
				{
				}
				num = (short)72220672;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00003760 File Offset: 0x00001960
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00003810 File Offset: 0x00001A10
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> SelectedAllCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1008876396;
				short num2 = num;
				num = (short)1721514860;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1471348736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1740177408;
				if (num != 0)
				{
				}
				num = (short)1916993537;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1360267940;
				short num2 = num;
				num = (short)864291492;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1964048384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)668663809;
				if (num != 0)
				{
				}
				num = (short)1967259648;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000038C0 File Offset: 0x00001AC0
		private void c()
		{
			short num;
			try
			{
				num = (short)1817597133;
				short num2 = num;
				num = (short)2113557709;
				switch (num2 == num)
				{
				}
				num = (short)792395776;
				if (num != 0)
				{
				}
				base.CommandHandler.CancelSaveTemplateAsCommand.Execute(new object[]
				{
					this.SaveTemplateAsContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1392836608;
			short num3 = num;
			num = (short)673316865;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000039B0 File Offset: 0x00001BB0
		private void b()
		{
			short num;
			try
			{
				num = (short)1840438814;
				short num2 = num;
				num = (short)71884318;
				switch (num2 == num)
				{
				}
				num = (short)571277312;
				if (num != 0)
				{
				}
				this.SaveTemplateAsContext.ShowingRadioOptions = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption>(this.SaveTemplateAsContext.RadioOptions);
				base.CommandHandler.SaveTemplateAsCommand.Execute(new object[]
				{
					this.SaveTemplateAsContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.SaveTemplateAsContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1769603072;
			short num3 = num;
			num = (short)564002817;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003AC4 File Offset: 0x00001CC4
		private void a(object[] A_0)
		{
			short num = (short)1523580935;
			int num2 = (int)((global::System.IntPtr)num);
			int num3;
			for (;;)
			{
				bool flag;
				global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption radioOption;
				switch (num2)
				{
				case 0:
					goto IL_79;
				case 1:
					num = (short)120389638;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1FA;
				case 3:
					num = (short)224067589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_F4;
				case 5:
					if (flag)
					{
						num = (short)827785218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3--;
					num = (short)998899716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (radioOption.Option != flag)
					{
						num = (short)1595146243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_229;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 8:
					if (radioOption != null)
					{
						num = (short)380502017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_229;
				}
				IL_49:
				num3 = ((global::System.Collections.Generic.ICollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption>)this.SaveTemplateAsContext.RadioOptions.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption, bool>(global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsViewModel.<>c.<>9.a)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption>()).Count;
				radioOption = (A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption);
				flag = (bool)A_0[2];
				num = (short)21282153;
				short num4 = num;
				num = (short)1112849769;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_1FA:
					num = (short)1400438784;
					short num5 = num;
					num3++;
					num = (short)2039676928;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)1002176512;
					if (num != 0)
					{
					}
					num = (short)775094273;
					if (num != 0)
					{
					}
					num = (short)1414070280;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_79:
			IL_F4:
			IL_229:
			this.SaveTemplateAsContext.SelectedRadiosCount = num3;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003D08 File Offset: 0x00001F08
		private void a(object A_0)
		{
			short num = (short)1760690176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				object[] array;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_48B;
					case 1:
						goto IL_247;
					case 2:
						enumerator = this.SaveTemplateAsContext.RadioOptions.GetEnumerator();
						num = (short)690946048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)504954882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5AC;
					}
					case 4:
						try
						{
							num = (short)1136721923;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_1D2;
								case 2:
									num = (short)229834753;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_106;
									}
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)1799618562;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_108;
								}
								goto IL_106;
								IL_108:
								enumerator.Current.Option = false;
								num = (short)447938560;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12E:
								num = (short)1229387739;
								short num3 = num;
								num = (short)983365595;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_108;
								default:
									num = (short)252968960;
									if (num != 0)
									{
									}
									num = (short)1637154820;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_106:
								goto IL_12E;
							}
							IL_1D2:
							goto IL_98;
						}
						finally
						{
							num = (short)376569857;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_244;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_20A;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1730084864;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_20A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)406585346;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_244:;
						}
						goto Block_4;
					case 5:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1559625738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)850198528;
						short num4 = num;
						enumerator = this.SaveTemplateAsContext.RadioOptions.GetEnumerator();
						num = (short)1651703812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_36A;
					case 7:
					{
						bool? flag = (bool?)A_0;
						bool flag2 = true;
						num = (short)46530563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_B0;
					case 9:
					{
						if (array == null)
						{
							num = (short)1883242503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool? flag = (bool?)array[0];
						bool flag2 = true;
						num = (short)1127284741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						enumerator = this.SaveTemplateAsContext.RadioOptions.GetEnumerator();
						num = (short)1482948609;
						if (num != 0)
						{
						}
						num = (short)1047199750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5B;
					IL_98:
					num = (short)2014707720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_5:
					try
					{
						IL_36A:
						num = (short)2090795008;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_3A5;
								}
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num = (short)756416515;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator.Current.Option = true;
								num = (short)1242103809;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)1769144324;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_419;
							}
							IL_3A7:
							num = (short)1525219330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3A5:
							goto IL_3A7;
						}
						IL_419:
						goto IL_98;
					}
					finally
					{
						num = (short)1772748800;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_450;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1815019522;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_488;
							}
							IL_450:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1988820993;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_488:;
					}
					goto Block_6;
					Block_4:
					try
					{
						IL_247:
						num = (short)689504259;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_2F9;
							case 2:
								num = (short)1663369217;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_281;
								}
								continue;
							case 4:
								if (!enumerator.MoveNext())
								{
									num = (short)854786050;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator.Current.Option = false;
								num = (short)857407488;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2A9:
							num = (short)666107908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_281:
							goto IL_2A9;
						}
						IL_2F9:
						goto IL_98;
					}
					finally
					{
						num = (short)1614479360;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_330;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1878196226;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_367;
							}
							IL_330:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1279524865;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_367:;
					}
					goto Block_5;
					IL_5AC:
					enumerator = this.SaveTemplateAsContext.RadioOptions.GetEnumerator();
					num = (short)673841153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_6:
					try
					{
						IL_48B:
						num = (short)1543897088;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_4C5;
								}
								continue;
							case 1:
								num = (short)2105147396;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (!enumerator.MoveNext())
								{
									num = (short)770179073;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator.Current.Option = true;
								num = (short)650117122;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_53A;
							}
							IL_4EB:
							num = (short)1955004419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_4C5:
							goto IL_4EB;
						}
						IL_53A:
						goto IL_98;
					}
					finally
					{
						num = (short)500826112;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_571;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)97976322;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_5A9;
							}
							IL_571:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1959198721;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_5A9:;
					}
					goto IL_5AC;
				}
				IL_B0:
				global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption> list = this.SaveTemplateAsContext.RadioOptions.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption, bool>(global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsViewModel.<>c.<>9.b)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption>();
				this.SaveTemplateAsContext.SelectedRadiosCount = list.Count;
				return;
				IL_5B:
				array = (A_0 as object[]);
				num = (short)1903886345;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00004518 File Offset: 0x00002718
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)1774849066;
				short num2 = num;
				num = (short)91229226;
				switch (num2 == num)
				{
				}
				num = (short)1565589504;
				if (num != 0)
				{
				}
				result = base.CommandHandler.SaveTemplateAsCommand.CanExecute(new object[]
				{
					this.SaveTemplateAsContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1715994624;
			short num3 = num;
			num = (short)1558249473;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004604 File Offset: 0x00002804
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 17;
			while (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("䀄缆樈渊紌笎砐簒笔娖簘栚渜縞䘠䘢", a_))
			{
				short num = (short)1292107776;
				short num2 = num;
				num = (short)591790081;
				if (num != 0)
				{
				}
				num = (short)1739730466;
				short num3 = num;
				num = (short)50998818;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)607191040;
					if (num != 0)
					{
					}
					return;
				}
			}
			this.SaveTemplateAsContext.ExceptionMessage = string.Empty;
			this.SaveTemplateAsCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000046F4 File Offset: 0x000028F4
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)168296448;
			short num2 = num;
			num = (short)990989596;
			short num3 = num;
			num = (short)179260700;
			switch (num3 == num)
			{
			}
			num = (short)1454571520;
			if (num != 0)
			{
			}
			num = (short)738000897;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption> list = this.SaveTemplateAsContext.RadioOptions.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption, bool>(global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsViewModel.<>c.<>9.c)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption>();
			this.SaveTemplateAsContext.SelectedRadiosCount = list.Count;
		}

		// Token: 0x0400000B RID: 11
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.CommonCPS.RadioManagement.UIModels.SaveTemplateAsContext a;

		// Token: 0x0400000C RID: 12
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;

		// Token: 0x0400000D RID: 13
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x0400000E RID: 14
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> d;

		// Token: 0x0400000F RID: 15
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> e;
	}
}
