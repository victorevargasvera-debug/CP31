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
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x0200001E RID: 30
	public class SelectWarningRadiosViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0001B284 File Offset: 0x00019484
		public string JobNotice
		{
			get
			{
				short num;
				while (!this.SelectWarningRadiostoScheduleJobContext.IsNeedConfirm)
				{
					num = (short)528738740;
					short num2 = num;
					num = (short)1920461236;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1949040640;
						short num3 = num;
						num = (short)1545404416;
						if (num != 0)
						{
						}
						return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_SelectWarningRadios;
					}
					}
				}
				num = (short)82706433;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_SelectWarningRadiosWithRequired;
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0001B344 File Offset: 0x00019544
		public SelectWarningRadiosViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext selectWarningRadiostoScheduleJobContext) : base(eventAggregator, commandHandler)
		{
			this.SelectWarningRadiostoScheduleJobContext = selectWarningRadiostoScheduleJobContext;
			this.SelectWarningRadiostoScheduleJobContext.SelectWarningRadios.CollectionChanged += this.a;
			this.FieldCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>(new global::System.Action<object[]>(this.a));
			this.SelectWarningRadiosCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.SelectedAllCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object>(new global::System.Action<object>(this.a));
			this.SelectWarningRadiostoScheduleJobContext.PropertyChanged += this.a;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0001B3E4 File Offset: 0x000195E4
		private void a(object[] A_0)
		{
			global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio item;
			short num;
			for (;;)
			{
				item = (A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio);
				if ((bool)A_0[1])
				{
					break;
				}
				num = (short)553189377;
				if (num != 0)
				{
				}
				num = (short)376285476;
				short num2 = num;
				num = (short)2000857380;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_85;
				}
			}
			this.SelectWarningRadiostoScheduleJobContext.SelectWarningRadios.Remove(item);
			return;
			IL_85:
			num = (short)747765760;
			short num3 = num;
			num = (short)126877696;
			if (num != 0)
			{
			}
			this.SelectWarningRadiostoScheduleJobContext.SelectWarningRadios.Add(item);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0001B4C8 File Offset: 0x000196C8
		private void b()
		{
			short num;
			try
			{
				num = (short)1555431425;
				if (num != 0)
				{
				}
				num = (short)56399077;
				short num2 = num;
				num = (short)339317989;
				switch (num2 == num)
				{
				}
				num = (short)1423769600;
				if (num != 0)
				{
				}
				base.CloseCommand.Execute();
				base.CommandHandler.SelectWarningRadiostoScheduleJobCommand.Execute(new object[]
				{
					this.SelectWarningRadiostoScheduleJobContext
				});
				this.SelectWarningRadiostoScheduleJobContext.IsCancelled = false;
			}
			catch (global::System.Exception exception)
			{
				this.SelectWarningRadiostoScheduleJobContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)2109341696;
			short num3 = num;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0001B5D0 File Offset: 0x000197D0
		private void a(bool? A_0)
		{
			short num = (short)1091698688;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				bool? flag;
				bool flag2;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_28F;
					case 1:
					{
						num = (short)1661337600;
						short num3 = num;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)289931266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.SelectWarningRadiostoScheduleJobContext.SelectWarningRadios.Clear();
						num = (short)841744384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_237;
					case 3:
						try
						{
							num = (short)13697026;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)601489412;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio item = enumerator.Current;
									this.SelectWarningRadiostoScheduleJobContext.SelectWarningRadios.Add(item);
									num = (short)296615939;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_173;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_F0;
									}
									continue;
								case 4:
									num = (short)1008336897;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_123:
								num = (short)799670272;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F0:
								goto IL_123;
							}
							IL_173:
							goto IL_291;
						}
						finally
						{
							num = (short)1608908801;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_234;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1AC;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)680394752;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1AC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)167415441;
								short num4 = num;
								num = (short)915246737;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_234;
								default:
									num = (short)67764224;
									if (num != 0)
									{
									}
									num = (short)344326146;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_234:;
						}
						goto IL_237;
					}
					goto IL_3E;
					IL_237:
					enumerator = this.SelectWarningRadiostoScheduleJobContext.WarningRadios.GetEnumerator();
					num = (short)1489633283;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_28F:
				IL_291:
				num = (short)309133313;
				if (num != 0)
				{
				}
				return;
				IL_3E:
				flag = A_0;
				flag2 = true;
				num = (short)1350565889;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0001B8A8 File Offset: 0x00019AA8
		private void a(object A_0)
		{
			short num = (short)909574144;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio> enumerator2;
				object[] array;
				for (;;)
				{
					IL_28:
					bool? flag;
					bool flag2;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> list;
					switch (num2)
					{
					case 0:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1185742855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.SelectWarningRadiostoScheduleJobContext.SelectWarningRadios.Clear();
						num = (short)856227845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						try
						{
							num = (short)882049026;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)30146561;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_17C;
								case 2:
									num = (short)772800513;
									if (num != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_F2;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1853554688;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase = enumerator.Current;
									this.SelectWarningRadiostoScheduleJobContext.SelectWarningRadios.Add(uimodelBase as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio);
									num = (short)584187908;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_F4:
								num = (short)313262083;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F2:
								goto IL_F4;
							}
							IL_17C:
							return;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_18F;
					case 2:
						enumerator2 = this.SelectWarningRadiostoScheduleJobContext.WarningRadios.GetEnumerator();
						num = (short)932970500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						flag = (bool?)A_0;
						flag2 = true;
						num = (short)829489160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_21F;
					case 5:
						goto IL_2C8;
					case 6:
						if (array == null)
						{
							num = (short)1838088195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18F;
					case 7:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator = list.GetEnumerator();
						num = (short)1162739713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1146355714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_451;
					}
					goto IL_53;
					IL_18F:
					bool? flag3 = (bool?)array[0];
					list = (array[1] as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>);
					flag = flag3;
					flag2 = true;
					num = (short)573046784;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_21F:
				try
				{
					num = (short)1211170818;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator2.MoveNext())
							{
								num = (short)545062916;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext.WarningRadio item = enumerator2.Current;
							this.SelectWarningRadiostoScheduleJobContext.SelectWarningRadios.Add(item);
							num = (short)779157507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_390;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_309;
							}
							continue;
						case 4:
							num = (short)1997471745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_33E:
						num = (short)99942400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_309:
						goto IL_33E;
					}
					IL_390:
					return;
				}
				finally
				{
					num = (short)265420801;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_44E;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_3C7;
							}
							continue;
						case 2:
							enumerator2.Dispose();
							num = (short)808910848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_3C7:
						if (enumerator2 == null)
						{
							break;
						}
						num = (short)97799790;
						short num3 = num;
						num = (short)1057115758;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_44E;
						default:
							num = (short)1927151616;
							if (num != 0)
							{
							}
							num = (short)59768834;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_44E:;
				}
				goto IL_451;
				IL_2C8:
				return;
				IL_451:
				num = (short)228261888;
				short num4 = num;
				this.SelectWarningRadiostoScheduleJobContext.SelectWarningRadios.Clear();
				return;
				IL_53:
				array = (A_0 as object[]);
				num = (short)1992622086;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0001BD5C File Offset: 0x00019F5C
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)769412839;
				short num2 = num;
				num = (short)2096844519;
				switch (num2 == num)
				{
				}
				num = (short)173539328;
				if (num != 0)
				{
				}
				result = base.CommandHandler.SelectWarningRadiostoScheduleJobCommand.CanExecute(new object[]
				{
					this.SelectWarningRadiostoScheduleJobContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)654573569;
			if (num != 0)
			{
			}
			num = (short)1677131776;
			short num3 = num;
			return result;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0001BE44 File Offset: 0x0001A044
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0001BEF4 File Offset: 0x0001A0F4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext SelectWarningRadiostoScheduleJobContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)773795918;
				short num2 = num;
				num = (short)385495118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1992687616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1921515521;
				if (num != 0)
				{
				}
				num = (short)852295680;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)153698854;
				short num2 = num;
				num = (short)1421165094;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1913323520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)665321473;
				if (num != 0)
				{
				}
				num = (short)366936064;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0001BFA4 File Offset: 0x0001A1A4
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0001C054 File Offset: 0x0001A254
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> FieldCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)763166721;
				if (num != 0)
				{
				}
				num = (short)357695488;
				short num2 = num;
				num = (short)1217405495;
				short num3 = num;
				num = (short)1571430967;
				switch (num3 == num)
				{
				}
				num = (short)1139867648;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1770127361;
				if (num != 0)
				{
				}
				num = (short)1229324288;
				short num2 = num;
				num = (short)766278569;
				short num3 = num;
				num = (short)53574569;
				switch (num3 == num)
				{
				}
				num = (short)1987772416;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0001C104 File Offset: 0x0001A304
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0001C1B8 File Offset: 0x0001A3B8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SelectWarningRadiosCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)888947690;
				short num2 = num;
				num = (short)76694506;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1847590912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1540161536;
				if (num != 0)
				{
				}
				num = (short)1780744193;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)519337697;
				short num2 = num;
				num = (short)536835809;
				switch (num2 == num)
				{
				default:
				{
					num = (short)606339072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)208142336;
				if (num != 0)
				{
				}
				num = (short)871563265;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0001C268 File Offset: 0x0001A468
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0001C314 File Offset: 0x0001A514
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> SelectedAllCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)859963393;
				if (num != 0)
				{
				}
				num = (short)369295360;
				short num2 = num;
				num = (short)461833007;
				short num3 = num;
				num = (short)919733039;
				switch (num3 == num)
				{
				}
				num = (short)1176371200;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1578917524;
				short num2 = num;
				num = (short)1455578772;
				switch (num2 == num)
				{
				default:
				{
					num = (short)313982976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1121648641;
				if (num != 0)
				{
				}
				num = (short)1595670528;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0001C3C8 File Offset: 0x0001A5C8
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)1750184583;
			short num2 = num;
			num = (short)2121183879;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1035993088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1149698048;
			if (num != 0)
			{
			}
			num = (short)1123090433;
			if (num != 0)
			{
			}
			this.SelectWarningRadiostoScheduleJobContext.ExceptionMessage = string.Empty;
			this.SelectWarningRadiosCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0001C48C File Offset: 0x0001A68C
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 11;
			if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("諭맀ꃂꃄ럆뷈ꋊꋌꇎ鳐뛒ꛔꓖ룘볚룜", a_))
			{
				short num = (short)1368978265;
				short num2 = num;
				num = (short)1913189209;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1242759168;
					short num3 = num;
					num = (short)1463746560;
					if (num != 0)
					{
					}
					num = (short)2094006273;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this.SelectWarningRadiostoScheduleJobContext.ExceptionMessage = string.Empty;
			this.SelectWarningRadiosCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x040000A9 RID: 169
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.SelectWarningRadiostoScheduleJobContext a;

		// Token: 0x040000AA RID: 170
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> b;

		// Token: 0x040000AB RID: 171
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x040000AC RID: 172
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> d;
	}
}
