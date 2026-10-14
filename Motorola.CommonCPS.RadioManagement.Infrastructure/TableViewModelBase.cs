using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Timers;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000041 RID: 65
	public abstract class TableViewModelBase<T> : global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewModelBase, global::System.IDisposable where T : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x0600017F RID: 383 RVA: 0x000160D4 File Offset: 0x000142D4
		public TableViewModelBase() : this(null)
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000160E8 File Offset: 0x000142E8
		public TableViewModelBase(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : this(eventAggregator, string.Empty)
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00016104 File Offset: 0x00014304
		public TableViewModelBase(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, string mainViewName) : base(eventAggregator)
		{
			this.d = mainViewName;
			this.f = new global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<T>();
			this.f.CollectionChanged += this.b;
			this.RefreshCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.Refresh));
			this.SaveItemCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>(new global::System.Action<object[]>(this.SaveItem));
			this.SearchCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>(new global::System.Action<object[]>(this.b), new global::System.Func<object[], bool>(this.a));
			this.UpdateSelectedItemsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>>(new global::System.Action<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>>(this.a));
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.RefreshDetailsViewRequestedEvent>().Subscribe(new global::System.Action<object>(this.a));
			base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.CleanViewCacheDataRequestedEvent>().Subscribe(new global::System.Action<string>(this.a));
			this.g = new global::System.Timers.Timer(500.0);
			this.g.Elapsed += this.a;
			this.g.Start();
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0001621C File Offset: 0x0001441C
		// (set) Token: 0x06000183 RID: 387 RVA: 0x000162CC File Offset: 0x000144CC
		public T ActiveItem
		{
			get
			{
				short num = (short)1799747582;
				short num2 = num;
				num = (short)1163458558;
				switch (num2 == num)
				{
				}
				num = (short)89194497;
				if (num != 0)
				{
				}
				num = (short)2075852800;
				if (num != 0)
				{
				}
				num = (short)479264768;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)1507655682;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.a = value;
						base.RaisePropertyChanged<T>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<T>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<T>)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<T>.get_ActiveItem())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1858273284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!value.Equals(this.a))
						{
							num = (short)976224256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
					{
						num = (short)346226688;
						short num3 = num;
						num = (short)144862892;
						short num4 = num;
						num = (short)884240044;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E1;
						default:
							num = (short)611516417;
							if (num != 0)
							{
							}
							num = (short)753467392;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_D6;
							}
							continue;
						}
						break;
					}
					case 3:
						num = (short)647954433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return;
					}
					goto IL_D6;
					IL_E1:
					num = (short)1950285827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D6:
					if (value != null)
					{
						goto IL_E1;
					}
					break;
				}
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00016478 File Offset: 0x00014678
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00016528 File Offset: 0x00014728
		public global::System.ComponentModel.ICollectionView Items
		{
			get
			{
				short num = (short)1892745217;
				if (num != 0)
				{
				}
				num = (short)1832108357;
				short num2 = num;
				num = (short)937869637;
				switch (num2 == num)
				{
				}
				num = (short)1839792128;
				if (num != 0)
				{
				}
				num = (short)537067520;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)1746403336;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_172;
					case 1:
						return;
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache = null;
						num = (short)1919352835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (this.c != null)
						{
							num = (short)1521745920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F4;
					case 4:
						goto IL_F4;
					case 5:
						if (this.c != null)
						{
							num = (short)922943499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_295;
					case 6:
					{
						global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache;
						if (viewCache != null)
						{
							num = (short)1486880775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 7:
					{
						num = (short)1066336256;
						short num3 = num;
						global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache;
						viewCache.Close();
						num = (short)1668087809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 9:
					{
						if (!(this.c.SourceCollection is global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache))
						{
							goto IL_F4;
						}
						num = (short)2131047190;
						short num4 = num;
						num = (short)124793622;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_172;
						default:
							num = (short)387055616;
							if (num != 0)
							{
							}
							num = (short)428212236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						goto IL_295;
					case 11:
						this.c.CollectionChanged -= this.a;
						this.c.CollectionChanged += this.a;
						num = (short)1430978570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache = this.c.SourceCollection as global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache;
						num = (short)1638793220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_59:
					num = (short)981598209;
					if (num != 0)
					{
					}
					if (value != this.c)
					{
						num = (short)1901592578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_F4:
					this.c = value;
					base.RaisePropertyChanged<global::System.ComponentModel.ICollectionView>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.ComponentModel.ICollectionView>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<T>)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<T>.get_Items())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)2122514437;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_172:
					num = (short)396099593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_295:
					num = (short)64749574;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00016830 File Offset: 0x00014A30
		// (set) Token: 0x06000187 RID: 391 RVA: 0x000168DC File Offset: 0x00014ADC
		public bool IsLoadingItemsFromViewCache
		{
			get
			{
				short num = (short)315196853;
				short num2 = num;
				num = (short)810976693;
				switch (num2 == num)
				{
				}
				num = (short)169148417;
				if (num != 0)
				{
				}
				num = (short)48889856;
				if (num != 0)
				{
				}
				num = (short)1313931264;
				short num3 = num;
				return this.h;
			}
			set
			{
				while (value != this.h)
				{
					short num = (short)1249355827;
					short num2 = num;
					num = (short)674015283;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2077491200;
						if (num != 0)
						{
						}
						num = (short)1928593409;
						if (num != 0)
						{
						}
						num = (short)1121124352;
						short num3 = num;
						this.h = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<T>)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<T>.get_IsLoadingItemsFromViewCache())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						return;
					}
					}
				}
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000169D0 File Offset: 0x00014BD0
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00016A80 File Offset: 0x00014C80
		public global::System.Collections.ObjectModel.ObservableCollection<T> SelectedItems
		{
			get
			{
				short num = (short)110615499;
				short num2 = num;
				num = (short)1408555979;
				switch (num2 == num)
				{
				}
				num = (short)1276313601;
				if (num != 0)
				{
				}
				num = (short)1562443776;
				if (num != 0)
				{
				}
				num = (short)2018836480;
				short num3 = num;
				return this.f;
			}
			set
			{
				short num = (short)64487425;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_101;
					case 1:
					{
						num = (short)453771264;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_5B;
						}
						continue;
					}
					case 2:
						this.f = value;
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<T>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<T>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<T>)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<T>.get_SelectedItems())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)527958017;
						if (num != 0)
						{
						}
						num = (short)1537409024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5B:
					if (value != this.f)
					{
						num = (short)1332346882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_101:
					num = (short)1136029443;
					short num4 = num;
					num = (short)908160771;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_136;
					}
				}
				IL_136:
				num = (short)937689088;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00016BD8 File Offset: 0x00014DD8
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00016C8C File Offset: 0x00014E8C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand RefreshCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)862927989;
				short num2 = num;
				num = (short)1913404533;
				switch (num2 == num)
				{
				}
				num = (short)1872429057;
				if (num != 0)
				{
				}
				num = (short)1126105088;
				if (num != 0)
				{
				}
				num = (short)378535936;
				short num3 = num;
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1261013967;
				short num2 = num;
				num = (short)498305999;
				switch (num2 == num)
				{
				}
				num = (short)60555264;
				if (num != 0)
				{
				}
				num = (short)863240193;
				if (num != 0)
				{
				}
				num = (short)1121910784;
				short num3 = num;
				this.i = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00016D3C File Offset: 0x00014F3C
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00016DEC File Offset: 0x00014FEC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> SaveItemCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1548395077;
				short num2 = num;
				num = (short)7447109;
				switch (num2 == num)
				{
				}
				num = (short)1131479040;
				if (num != 0)
				{
				}
				num = (short)618921985;
				if (num != 0)
				{
				}
				num = (short)2110521344;
				short num3 = num;
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)208447738;
				short num2 = num;
				num = (short)1571203322;
				switch (num2 == num)
				{
				}
				num = (short)95748097;
				if (num != 0)
				{
				}
				num = (short)644874240;
				if (num != 0)
				{
				}
				num = (short)501415936;
				short num3 = num;
				this.j = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00016E9C File Offset: 0x0001509C
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00016F4C File Offset: 0x0001514C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> SearchCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)636022609;
				short num2 = num;
				num = (short)1088745297;
				switch (num2 == num)
				{
				}
				num = (short)2133196801;
				if (num != 0)
				{
				}
				num = (short)1544749056;
				if (num != 0)
				{
				}
				num = (short)26476544;
				short num3 = num;
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)211750376;
				short num2 = num;
				num = (short)693308904;
				switch (num2 == num)
				{
				}
				num = (short)1071644673;
				if (num != 0)
				{
				}
				num = (short)110821376;
				if (num != 0)
				{
				}
				num = (short)660668416;
				short num3 = num;
				this.k = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00016FFC File Offset: 0x000151FC
		// (set) Token: 0x06000191 RID: 401 RVA: 0x000170A8 File Offset: 0x000152A8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>> UpdateSelectedItemsCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)681789186;
				short num2 = num;
				num = (short)435373826;
				switch (num2 == num)
				{
				}
				num = (short)899153921;
				if (num != 0)
				{
				}
				num = (short)165019648;
				if (num != 0)
				{
				}
				num = (short)488177664;
				short num3 = num;
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2092258724;
				short num2 = num;
				num = (short)803296676;
				switch (num2 == num)
				{
				}
				num = (short)596312065;
				if (num != 0)
				{
				}
				num = (short)2079326208;
				if (num != 0)
				{
				}
				num = (short)261423104;
				short num3 = num;
				this.l = value;
			}
		}

		// Token: 0x06000192 RID: 402
		protected abstract void Refresh();

		// Token: 0x06000193 RID: 403
		protected abstract void SaveItem(object[] parameters);

		// Token: 0x06000194 RID: 404 RVA: 0x00017158 File Offset: 0x00015358
		private void b(object[] A_0)
		{
			short num = (short)1281724438;
			short num2 = num;
			num = (short)2034077718;
			switch (num2 == num)
			{
			}
			num = (short)67502081;
			if (num != 0)
			{
			}
			num = (short)1107623936;
			if (num != 0)
			{
			}
			num = (short)1608187904;
			short num3 = num;
			base.ServiceProxy.CommandHandler.FilterCommand.Execute(A_0);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00017214 File Offset: 0x00015414
		private void a(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> A_0)
		{
			short num = (short)1591607296;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)856225751;
				short num3 = num;
				num = (short)1369438167;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2081095680;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8B;
					}
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<T> observableCollectionFast;
					for (;;)
					{
						IL_74:
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator;
						switch (num2)
						{
						case 0:
							goto IL_217;
						case 1:
						{
							if (observableCollectionFast == null)
							{
								num = (short)1793589250;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<T>.a a = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<T>.a();
							a.a = new global::System.Collections.Generic.List<T>();
							A_0.ForEach(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>(a.b));
							observableCollectionFast.Reset(a.a);
							num = (short)1888550912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_1A0;
						case 3:
							try
							{
								num = (short)1031929858;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_18D;
									case 1:
										num = (short)1056571392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_109;
										}
										continue;
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)337444865;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase = enumerator.Current;
										this.f.Add((T)((object)uimodelBase));
										num = (short)121372675;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_13B:
									num = (short)2099052548;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_109:
									goto IL_13B;
								}
								IL_18D:
								return;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_1A0;
						}
						goto IL_8B;
						IL_1A0:
						this.f.Clear();
						enumerator = A_0.GetEnumerator();
						num = (short)1128792067;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_217:
					num = (short)671547392;
					short num4 = num;
					num = (short)1330184193;
					if (num != 0)
					{
					}
					break;
					IL_8B:
					observableCollectionFast = (this.f as global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<T>);
					num = (short)2110849025;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_74;
				}
				}
				return;
			}
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0001749C File Offset: 0x0001569C
		private bool a(object[] A_0)
		{
			short num = (short)984630139;
			short num2 = num;
			num = (short)980370299;
			switch (num2 == num)
			{
			}
			num = (short)1407123457;
			if (num != 0)
			{
			}
			num = (short)1072824320;
			if (num != 0)
			{
			}
			num = (short)387579904;
			short num3 = num;
			return true;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00017548 File Offset: 0x00015748
		private void a(object A_0)
		{
			while (!(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView != this.d))
			{
				short num = (short)750577665;
				short num2 = num;
				num = (short)1224140801;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1085997057;
					if (num != 0)
					{
					}
					num = (short)1121779712;
					if (num != 0)
					{
					}
					num = (short)1970339840;
					short num3 = num;
					this.Refresh();
					return;
				}
				}
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0001760C File Offset: 0x0001580C
		private void b(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)1688862720;
			short num2 = num;
			this.OnSelectedItemsCollectionChanged();
			global::System.Collections.Generic.IEnumerator<T> enumerator = this.SelectedItems.GetEnumerator();
			try
			{
				num = (short)1861550082;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_14F;
					case 1:
						num = (short)2052390912;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					case 4:
					{
						T t;
						if (t != null)
						{
							num = (short)1552482309;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
					{
						T t;
						t.PropertyChanged -= this.a;
						t.PropertyChanged += this.a;
						num = (short)1695416323;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)23724033;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						T t = enumerator.Current;
						num = (short)294518788;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_BA:
					num = (short)583401478;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E:
					goto IL_BA;
				}
				IL_14F:;
			}
			finally
			{
				num = (short)1086193665;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_1BC;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_185;
						}
						continue;
					case 2:
						enumerator.Dispose();
						num = (short)1345257472;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_185:
					if (enumerator != null)
					{
						num = (short)299827202;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1BC:
					num = (short)2122028991;
					short num4 = num;
					num = (short)1319540671;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_1F3;
					}
				}
				IL_1F3:
				num = (short)2105475073;
				if (num != 0)
				{
				}
				num = (short)98369536;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00017868 File Offset: 0x00015A68
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)375720525;
			short num2 = num;
			num = (short)1621822029;
			switch (num2 == num)
			{
			}
			num = (short)233963520;
			if (num != 0)
			{
			}
			num = (short)444334081;
			if (num != 0)
			{
			}
			num = (short)1741160448;
			short num3 = num;
			this.b = true;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00017918 File Offset: 0x00015B18
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			short num = (short)1989225432;
			short num2 = num;
			num = (short)441134040;
			switch (num2 == num)
			{
			}
			num = (short)1031274497;
			if (num != 0)
			{
			}
			num = (short)222494720;
			if (num != 0)
			{
			}
			num = (short)1407451136;
			short num3 = num;
			this.b = true;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000179CC File Offset: 0x00015BCC
		private void a(object A_0, global::System.Timers.ElapsedEventArgs A_1)
		{
			short num = (short)2109341697;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C2;
				case 1:
				{
					num = (short)244973568;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				}
				case 2:
					this.b = false;
					this.OnSelectedItemsCollectionChanged();
					num = (short)1459290112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5B:
				num = (short)428605441;
				if (num != 0)
				{
				}
				if (this.b)
				{
					num = (short)1589706754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C2:
				num = (short)960316052;
				short num4 = num;
				num = (short)1002848916;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_F8;
				}
			}
			IL_F8:
			num = (short)1067384832;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00017AE8 File Offset: 0x00015CE8
		private void a(string A_0)
		{
			short num = (short)590151681;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C3;
				case 1:
				{
					num = (short)994639872;
					short num3 = num;
					num = (short)113639425;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_82;
					}
					continue;
				}
				case 2:
					this.ClearCacheData();
					num = (short)1702625280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_82:
				if (A_0 == this.e)
				{
					num = (short)131792898;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C3:
				num = (short)1297546606;
				short num4 = num;
				num = (short)1916075374;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_F8;
				}
			}
			IL_F8:
			num = (short)1773469696;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00017C04 File Offset: 0x00015E04
		protected override void OnPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_13:
				num = (short)78708736;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_D5;
				case 1:
					if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("漥尧伩䄫崭", a_))
					{
						num = (short)583467010;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D5;
				case 2:
					IL_9D:
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveDataContext = this.c;
					base.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ActiveDataContextChangedEvent>().Publish(null);
					num = (short)2140405760;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4D;
				IL_D5:
				num = (short)190549326;
				short num4 = num;
				num = (short)1423150414;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_9D;
				default:
					goto IL_10B;
				}
			}
			IL_10B:
			num = (short)1502281729;
			if (num != 0)
			{
			}
			num = (short)1942618112;
			if (num != 0)
			{
			}
			return;
			IL_4D:
			base.OnPropertyChanged(sender, e);
			num = (short)422903809;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00017D58 File Offset: 0x00015F58
		public void ClearCacheData()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache;
					viewCache.Close();
					num2 = (short)261554181;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache;
					if (viewCache == null)
					{
						goto IL_69;
					}
					num2 = (short)1940324352;
					short num3 = num2;
					num2 = (short)1103103009;
					short num4 = num2;
					num2 = (short)1283195937;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1941176320;
						if (num2 != 0)
						{
						}
						num2 = (short)1749417985;
						if (num2 != 0)
						{
						}
						num2 = (short)1218838529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (this.c != null)
					{
						num2 = (short)364642308;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
				{
					global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache = this.c.SourceCollection as global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache;
					num2 = (short)1950416898;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_69;
				}
				goto IL_28;
				IL_69:
				this.c = null;
				num2 = (short)382664704;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_28:
			this.f.Clear();
			num2 = (short)1877999619;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00017EF4 File Offset: 0x000160F4
		protected virtual void OnSelectedItemsCollectionChanged()
		{
			short num = (short)1752231569;
			short num2 = num;
			num = (short)1788210833;
			switch (num2 == num)
			{
			}
			num = (short)1673003008;
			short num3 = num;
			num = (short)1812529153;
			if (num != 0)
			{
			}
			num = (short)1913782272;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00017FA0 File Offset: 0x000161A0
		protected virtual bool IsGoingToDetail(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			short num = (short)1168441345;
			if (num != 0)
			{
			}
			num = (short)495342101;
			short num2 = num;
			num = (short)1995788821;
			switch (num2 == num)
			{
			default:
			{
				num = (short)757858304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)869859328;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0001804C File Offset: 0x0001624C
		protected virtual bool IsComingBackFromDetail(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			short num = (short)1671757825;
			if (num != 0)
			{
			}
			num = (short)1409557786;
			short num2 = num;
			num = (short)929309978;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1667563520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)31195136;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000180F8 File Offset: 0x000162F8
		public override void OnNavigatedFrom(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)177075790;
						short num3 = num2;
						num2 = (short)1548482126;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5D;
						default:
							num2 = (short)494534656;
							if (num2 != 0)
							{
							}
							goto IL_EB;
						}
						break;
					}
					case 1:
						goto IL_102;
					case 2:
						goto IL_EB;
					case 3:
						if (!this.IsGoingToDetail(navigationContext))
						{
							num2 = (short)1417478148;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.CachedDataContext = this.c;
						num2 = (short)1955528704;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						goto IL_5D;
					}
					goto IL_24;
					IL_5D:
					this.ClearCacheData();
					num2 = (short)455016450;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_EB:
					num2 = (short)1988689921;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_102:
				num2 = (short)1081933825;
				if (num2 != 0)
				{
				}
				goto IL_12E;
				IL_24:
				base.OnNavigatedFrom(navigationContext);
				num2 = (short)811204611;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			catch
			{
			}
			IL_12E:
			num2 = (short)506593280;
			short num4 = num2;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00018278 File Offset: 0x00016478
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			global::Microsoft.Practices.Prism.Regions.IRegion region;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1057297907;
					short num3 = num2;
					num2 = (short)2118391283;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6E;
					case 1:
						goto IL_F5;
					}
					goto Block_2;
				}
				case 1:
					this.e = region.Name;
					num2 = (short)1583022080;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (region.Name.EndsWith(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("攧䬩䔫䀭戯圱匳張圷吹", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)1164574721;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					if (region != null)
					{
						num2 = (short)606994436;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					goto IL_6E;
				}
				goto IL_2D;
				IL_6E:
				num2 = (short)571408386;
				num = (int)((global::System.IntPtr)num2);
			}
			Block_2:
			num2 = (short)190709760;
			short num4 = num2;
			IL_F5:
			num2 = (short)1860960257;
			if (num2 != 0)
			{
			}
			num2 = (short)60817408;
			if (num2 != 0)
			{
			}
			return;
			IL_2D:
			base.OnNavigatedTo(navigationContext);
			region = navigationContext.NavigationService.Region;
			num2 = (short)619708419;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00018408 File Offset: 0x00016608
		public void Dispose()
		{
			short num = (short)837025792;
			short num2 = num;
			num = (short)1361182721;
			if (num != 0)
			{
			}
			num = (short)179571571;
			short num3 = num;
			num = (short)1209469811;
			switch (num3 == num)
			{
			}
			num = (short)767950848;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000184C0 File Offset: 0x000166C0
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)952172546;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1799028737;
					if (num != 0)
					{
					}
					if (disposing)
					{
						num = (short)2019033089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19C;
				case 1:
					num = (short)1660813316;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1143996416;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_6B;
					}
					continue;
				}
				case 3:
					this.g.Dispose();
					this.g = null;
					num = (short)200540165;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (this.g != null)
					{
						num = (short)704315395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19C;
				case 5:
					goto IL_100;
				case 6:
				{
					num = (short)1849397790;
					short num4 = num;
					num = (short)299930142;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_76;
					default:
						num = (short)1278214144;
						if (num != 0)
						{
						}
						num = (short)1198522368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_6B;
				IL_76:
				num = (short)1063256070;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6B:
				if (!this.m)
				{
					goto IL_76;
				}
				break;
			}
			IL_100:
			IL_19C:
			this.m = true;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00018670 File Offset: 0x00016870
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1328387970;
				short num2 = num;
				num = (short)261592962;
				switch (num2 == num)
				{
				}
				num = (short)1388183552;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				num = (short)1197735937;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)1691418624;
			short num3 = num;
		}

		// Token: 0x040000B9 RID: 185
		private T a;

		// Token: 0x040000BA RID: 186
		private bool b;

		// Token: 0x040000BB RID: 187
		private global::System.ComponentModel.ICollectionView c;

		// Token: 0x040000BC RID: 188
		private string d;

		// Token: 0x040000BD RID: 189
		private string e;

		// Token: 0x040000BE RID: 190
		private global::System.Collections.ObjectModel.ObservableCollection<T> f;

		// Token: 0x040000BF RID: 191
		private global::System.Timers.Timer g;

		// Token: 0x040000C0 RID: 192
		private bool h;

		// Token: 0x040000C1 RID: 193
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand i;

		// Token: 0x040000C2 RID: 194
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> j;

		// Token: 0x040000C3 RID: 195
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> k;

		// Token: 0x040000C4 RID: 196
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>> l;

		// Token: 0x040000C5 RID: 197
		private bool m;

		// Token: 0x0200004A RID: 74
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x060001FB RID: 507 RVA: 0x0001CB1C File Offset: 0x0001AD1C
			internal void b(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase A_0)
			{
				short num = (short)752812032;
				short num2 = num;
				num = (short)519477374;
				short num3 = num;
				num = (short)170694782;
				switch (num3 == num)
				{
				}
				num = (short)144113665;
				if (num != 0)
				{
				}
				num = (short)2049114112;
				if (num != 0)
				{
				}
				this.a.Add((a)((object)A_0));
			}

			// Token: 0x040000DC RID: 220
			public global::System.Collections.Generic.List<a> a;
		}
	}
}
