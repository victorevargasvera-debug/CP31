using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x0200002A RID: 42
	public class SelectRunningRadiosViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x060001DA RID: 474 RVA: 0x00021E68 File Offset: 0x00020068
		public SelectRunningRadiosViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRunningRadiosContext selectRunningRadiosContext) : base(eventAggregator, commandHandler)
		{
			this.SelectRunningRadiosContext = selectRunningRadiosContext;
			this.SelectRunningRadiosContext.SelectRunningRadios.CollectionChanged += this.a;
			this.SelectRunningRadiosCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.FieldCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>(new global::System.Action<object[]>(this.a));
			this.SelectedAllCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object>(new global::System.Action<object>(this.a));
			this.SelectRunningRadiosContext.PropertyChanged += this.a;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00021F08 File Offset: 0x00020108
		private void b()
		{
			short num;
			try
			{
				num = (short)177092252;
				short num2 = num;
				num = (short)1494038172;
				switch (num2 == num)
				{
				}
				num = (short)1317535744;
				if (num != 0)
				{
				}
				base.CommandHandler.CancelRunningJobsCommand.Execute(new object[]
				{
					this.SelectRunningRadiosContext
				});
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.SelectRunningRadiosContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)279379968;
			short num3 = num;
			num = (short)144965633;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00022004 File Offset: 0x00020204
		private void a(object[] A_0)
		{
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase;
			if (!(bool)A_0[1])
			{
				short num = (short)1049731653;
				short num2 = num;
				num = (short)399680069;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)748814337;
					if (num != 0)
					{
					}
					num = (short)1892941824;
					short num3 = num;
					num = (short)1905065984;
					if (num != 0)
					{
					}
					this.SelectRunningRadiosContext.SelectRunningRadios.Add(item);
					return;
				}
				}
			}
			this.SelectRunningRadiosContext.SelectRunningRadios.Remove(item);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000220E8 File Offset: 0x000202E8
		private void a(object A_0)
		{
			short num = (short)1144979456;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				object[] array;
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator2;
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
						num = (short)26214404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_2F2;
					case 2:
						if (array == null)
						{
							num = (short)2112815111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_168;
					case 3:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1196949504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.SelectRunningRadiosContext.SelectRunningRadios.Clear();
						num = (short)1601830913;
						if (num != 0)
						{
						}
						num = (short)340393985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						try
						{
							num = (short)2000224259;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_155;
								case 1:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)607387650;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase = enumerator.Current;
									this.SelectRunningRadiosContext.SelectRunningRadios.Add(uimodelBase as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase);
									num = (short)621871108;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)697303040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_CA;
									}
									continue;
								}
								IL_CC:
								num = (short)920387585;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CA:
								goto IL_CC;
							}
							IL_155:
							return;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_168;
					case 5:
						goto IL_1F8;
					case 6:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1849032712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_475;
					case 7:
					{
						flag = (bool?)A_0;
						flag2 = true;
						num = (short)1884749824;
						short num3 = num;
						num = (short)1899298822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						enumerator2 = this.SelectRunningRadiosContext.RunningRadios.GetEnumerator();
						num = (short)48365573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_52;
					IL_168:
					bool? flag3 = (bool?)array[0];
					list = (array[1] as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>);
					flag = flag3;
					flag2 = true;
					num = (short)1519714307;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F8:
				try
				{
					num = (short)1490616323;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_3B5;
						case 2:
						{
							if (!enumerator2.MoveNext())
							{
								num = (short)1801650180;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = enumerator2.Current;
							this.SelectRunningRadiosContext.SelectRunningRadios.Add(item);
							num = (short)283377665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_331;
							}
							continue;
						case 4:
							num = (short)2025914368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_364:
						num = (short)1465384962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_331:
						goto IL_364;
					}
					IL_3B5:
					return;
				}
				finally
				{
					num = (short)398524417;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							for (;;)
							{
								enumerator2.Dispose();
								num = (short)1182391003;
								short num4 = num;
								num = (short)292215515;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_443;
								}
							}
							IL_443:
							num = (short)456720384;
							if (num != 0)
							{
							}
							num = (short)1180106754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_3EC;
							}
							continue;
						case 2:
							goto IL_472;
						}
						IL_3EC:
						if (enumerator2 == null)
						{
							break;
						}
						num = (short)1714749440;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_472:;
				}
				goto IL_475;
				IL_2F2:
				return;
				IL_475:
				this.SelectRunningRadiosContext.SelectRunningRadios.Clear();
				return;
				IL_52:
				array = (A_0 as object[]);
				num = (short)26148866;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00022598 File Offset: 0x00020798
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)1488307952;
				short num2 = num;
				num = (short)1723516656;
				switch (num2 == num)
				{
				}
				num = (short)129695745;
				if (num != 0)
				{
				}
				num = (short)1081147392;
				if (num != 0)
				{
				}
				result = base.CommandHandler.CancelRunningJobsCommand.CanExecute(new object[]
				{
					this.SelectRunningRadiosContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1947729920;
			short num3 = num;
			return result;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00022680 File Offset: 0x00020880
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00022730 File Offset: 0x00020930
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRunningRadiosContext SelectRunningRadiosContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)454071448;
				short num2 = num;
				num = (short)870683800;
				switch (num2 == num)
				{
				}
				num = (short)1571422209;
				if (num != 0)
				{
				}
				num = (short)969801728;
				if (num != 0)
				{
				}
				num = (short)1814757376;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)209858292;
				short num2 = num;
				num = (short)451751668;
				switch (num2 == num)
				{
				}
				num = (short)204406785;
				if (num != 0)
				{
				}
				num = (short)1911357440;
				if (num != 0)
				{
				}
				num = (short)1185021952;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x000227E0 File Offset: 0x000209E0
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00022890 File Offset: 0x00020A90
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> FieldCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2117905598;
				short num2 = num;
				num = (short)1583131838;
				switch (num2 == num)
				{
				}
				num = (short)1638334465;
				if (num != 0)
				{
				}
				num = (short)1891172352;
				if (num != 0)
				{
				}
				num = (short)1561001984;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)46001;
				short num2 = num;
				num = (short)88388529;
				switch (num2 == num)
				{
				}
				num = (short)596180993;
				if (num != 0)
				{
				}
				num = (short)906887168;
				if (num != 0)
				{
				}
				num = (short)462028800;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00022940 File Offset: 0x00020B40
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x000229F4 File Offset: 0x00020BF4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SelectRunningRadiosCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2071801176;
				short num2 = num;
				num = (short)1744907608;
				switch (num2 == num)
				{
				}
				num = (short)1641283584;
				if (num != 0)
				{
				}
				num = (short)1757413377;
				if (num != 0)
				{
				}
				num = (short)893517824;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1954250121;
				short num2 = num;
				num = (short)244153737;
				switch (num2 == num)
				{
				}
				num = (short)211681281;
				if (num != 0)
				{
				}
				num = (short)1929904128;
				if (num != 0)
				{
				}
				num = (short)257228800;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00022AA8 File Offset: 0x00020CA8
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00022B58 File Offset: 0x00020D58
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> SelectedAllCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)179545449;
				short num2 = num;
				num = (short)1817355625;
				switch (num2 == num)
				{
				}
				num = (short)1924071425;
				if (num != 0)
				{
				}
				num = (short)514457600;
				if (num != 0)
				{
				}
				num = (short)1572995072;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1976164264;
				short num2 = num;
				num = (short)454483880;
				switch (num2 == num)
				{
				}
				num = (short)219873281;
				if (num != 0)
				{
				}
				num = (short)387842048;
				if (num != 0)
				{
				}
				num = (short)567083008;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00022C08 File Offset: 0x00020E08
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)905707000;
			short num2 = num;
			num = (short)1824849400;
			switch (num2 == num)
			{
			}
			num = (short)1050935297;
			if (num != 0)
			{
			}
			num = (short)1135804416;
			if (num != 0)
			{
			}
			num = (short)205389824;
			short num3 = num;
			this.SelectRunningRadiosContext.ExceptionMessage = string.Empty;
			this.SelectRunningRadiosCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00022CCC File Offset: 0x00020ECC
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 9;
			if (!(A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("잾ꋀꛂ뗄돆ꃈ꓊ꏌ苎듐ꃒꛔ뛖뻘뻚", a_)))
			{
				short num = (short)457244672;
				short num2 = num;
				num = (short)1124776466;
				short num3 = num;
				num = (short)1239530002;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1453457409;
					if (num != 0)
					{
					}
					num = (short)1055457280;
					if (num != 0)
					{
					}
					this.SelectRunningRadiosContext.ExceptionMessage = string.Empty;
					this.SelectRunningRadiosCommand.RaiseCanExecuteChanged();
					return;
				}
			}
		}

		// Token: 0x040000DA RID: 218
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRunningRadiosContext a;

		// Token: 0x040000DB RID: 219
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> b;

		// Token: 0x040000DC RID: 220
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x040000DD RID: 221
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> d;
	}
}
