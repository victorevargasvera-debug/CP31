using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.Linq;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.ViewCache
{
	// Token: 0x02000006 RID: 6
	public class ViewCache<T> : global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<T>, global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache where T : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::Motorola.CommonCPS.RadioManagement.UIModels.ICopyable
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000016 RID: 22 RVA: 0x00002190 File Offset: 0x00000390
		// (remove) Token: 0x06000017 RID: 23 RVA: 0x000022C8 File Offset: 0x000004C8
		public event global::System.EventHandler ProcessingCompleted
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1189740545;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3B;
					case 1:
					{
						num2 = (short)1916714571;
						short num3 = num2;
						num2 = (short)161660491;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							goto IL_114;
						}
						goto Block_2;
					}
					case 2:
						goto IL_3B;
					}
					goto IL_1C;
					IL_3B:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.a, value2, eventHandler2);
					num2 = (short)1540816897;
					if (num2 != 0)
					{
					}
					num2 = (short)132317184;
					num = (int)((global::System.IntPtr)num2);
				}
				Block_2:
				num2 = (short)1671168000;
				short num4 = num2;
				IL_114:
				num2 = (short)193396736;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.a;
				num2 = (short)1422852098;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)710410241;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_5F;
					case 1:
					{
						num2 = (short)37710795;
						short num3 = num2;
						num2 = (short)1503488971;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							goto IL_10E;
						}
						goto Block_2;
					}
					case 2:
						num2 = (short)2061828097;
						if (num2 != 0)
						{
						}
						goto IL_5F;
					}
					goto IL_1C;
					IL_5F:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.a, value2, eventHandler2);
					num2 = (short)848232448;
					num = (int)((global::System.IntPtr)num2);
				}
				Block_2:
				num2 = (short)777191424;
				short num4 = num2;
				IL_10E:
				num2 = (short)563806208;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.a;
				num2 = (short)1060634626;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000023FC File Offset: 0x000005FC
		protected ViewCache(global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<T> itemsProvider, global::Motorola.CommonCPS.RadioManagement.ViewCache.IFilter<T> filter = null, int initialPageSize = 500)
		{
			this.b = itemsProvider;
			this.c = filter;
			this.c(initialPageSize);
			global::System.Windows.Application.Current.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Action(this.f));
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000019 RID: 25 RVA: 0x00002474 File Offset: 0x00000674
		// (remove) Token: 0x0600001A RID: 26 RVA: 0x000025AC File Offset: 0x000007AC
		public override event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num;
				for (;;)
				{
					num = (short)737607681;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					int num2;
					global::System.Collections.Specialized.NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler;
					for (;;)
					{
						IL_32:
						global::System.Collections.Specialized.NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
						switch (num2)
						{
						case 0:
							goto IL_DC;
						case 1:
							if (notifyCollectionChangedEventHandler == notifyCollectionChangedEventHandler2)
							{
								num = (short)703725568;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_8A;
						case 2:
							goto IL_8A;
						}
						goto IL_44;
						IL_8A:
						notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
						global::System.Collections.Specialized.NotifyCollectionChangedEventHandler value2 = (global::System.Collections.Specialized.NotifyCollectionChangedEventHandler)global::System.Delegate.Combine(notifyCollectionChangedEventHandler2, value);
						notifyCollectionChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.Collections.Specialized.NotifyCollectionChangedEventHandler>(ref this.aa, value2, notifyCollectionChangedEventHandler2);
						num = (short)751501313;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_DC:
					num = (short)592021262;
					short num3 = num;
					num = (short)1533445902;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_113;
					}
					IL_44:
					num = (short)30539776;
					short num4 = num;
					notifyCollectionChangedEventHandler = this.aa;
					num = (short)751501314;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				IL_113:
				num = (short)32571392;
				if (num != 0)
				{
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num2;
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.Collections.Specialized.NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler;
					for (;;)
					{
						IL_0A:
						global::System.Collections.Specialized.NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
						switch (num)
						{
						case 0:
							goto IL_D9;
						case 1:
							if (notifyCollectionChangedEventHandler == notifyCollectionChangedEventHandler2)
							{
								num2 = (short)1270808576;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_88;
						case 2:
							goto IL_88;
						}
						goto IL_1C;
						IL_88:
						notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
						global::System.Collections.Specialized.NotifyCollectionChangedEventHandler value2 = (global::System.Collections.Specialized.NotifyCollectionChangedEventHandler)global::System.Delegate.Remove(notifyCollectionChangedEventHandler2, value);
						notifyCollectionChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.Collections.Specialized.NotifyCollectionChangedEventHandler>(ref this.aa, value2, notifyCollectionChangedEventHandler2);
						num2 = (short)934477825;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_D9:
					num2 = (short)1432330236;
					short num3 = num2;
					num2 = (short)330473468;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_110;
					}
					IL_1C:
					notifyCollectionChangedEventHandler = this.aa;
					num2 = (short)855179264;
					short num4 = num2;
					num2 = (short)410910721;
					if (num2 != 0)
					{
					}
					num2 = (short)1945042946;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_110:
				num2 = (short)954400768;
				if (num2 != 0)
				{
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000026E0 File Offset: 0x000008E0
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002790 File Offset: 0x00000990
		public int LoadingState
		{
			get
			{
				short num = (short)484769793;
				if (num != 0)
				{
				}
				num = (short)1747260625;
				short num2 = num;
				num = (short)1627722961;
				switch (num2 == num)
				{
				}
				num = (short)1445986304;
				if (num != 0)
				{
				}
				num = (short)1496711168;
				short num3 = num;
				return this.p;
			}
			private set
			{
				int a_ = 1;
				short num2;
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_25;
					}
					int num;
					for (;;)
					{
						IL_13:
						switch (num)
						{
						case 0:
							goto IL_A6;
						case 1:
							this.i.c();
							num2 = (short)726859776;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							if (value == 5)
							{
								num2 = (short)1052508161;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_A8;
						}
						goto IL_25;
					}
					IL_A8:
					num2 = (short)993753165;
					short num3 = num2;
					num2 = (short)710768717;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_DD;
					}
					IL_A6:
					goto IL_A8;
					IL_25:
					this.p = value;
					num2 = (short)1481113600;
					short num4 = num2;
					num2 = (short)2067595266;
					num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				IL_DD:
				num2 = (short)2067464193;
				if (num2 != 0)
				{
				}
				num2 = (short)611647488;
				if (num2 != 0)
				{
				}
				this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::<Module>.b("춡얣슥솧쒩쮫ﶭ쒯펱삳펵", a_)));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000028D0 File Offset: 0x00000AD0
		public bool EndLoadingToGui
		{
			get
			{
				short num = (short)1808072711;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)47382532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_117;
					case 2:
						if (!this.x)
						{
							goto IL_FF;
						}
						goto IL_1A0;
					case 3:
						num = (short)119537669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this.m.IsEmpty)
						{
							num = (short)549519366;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A0;
					case 5:
						if (this.n.IsEmpty)
						{
							num = (short)1319305216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A0;
					case 6:
						num = (short)652607490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_44;
						}
						continue;
					}
					IL_44:
					if (this.LoadingState != 2)
					{
						goto IL_1A0;
					}
					num = (short)1896512528;
					short num3 = num;
					num = (short)2112125968;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1938161665;
						if (num != 0)
						{
						}
						num = (short)24969216;
						if (num != 0)
						{
						}
						num = (short)733544451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_FF:
					num = (short)632553473;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_117:
				return !this.y;
				IL_1A0:
				num = (short)1378222080;
				short num4 = num;
				return false;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002AA8 File Offset: 0x00000CA8
		public bool NoRefreshEventInCache
		{
			get
			{
				short num = (short)1665073157;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1888672480;
					short num3 = num;
					num = (short)1910364896;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1318912000;
						short num4 = num;
						num = (short)1809055744;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							num = (short)63897604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1271267330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (this.n.IsEmpty)
							{
								num = (short)1215168515;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 3:
							goto IL_148;
						case 4:
							if (this.m.IsEmpty)
							{
								num = (short)1171390465;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_B0;
							}
							continue;
						}
						IL_B0:
						if (!this.l.IsEmpty)
						{
							return false;
						}
						break;
					}
					}
					num = (short)141557760;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_148:
				num = (short)1197867009;
				if (num != 0)
				{
				}
				return !this.x;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002C40 File Offset: 0x00000E40
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002CF0 File Offset: 0x00000EF0
		public int Speed
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)460712595;
				short num2 = num;
				num = (short)1318185619;
				switch (num2 == num)
				{
				}
				num = (short)1194655745;
				if (num != 0)
				{
				}
				num = (short)818675712;
				if (num != 0)
				{
				}
				num = (short)719454208;
				short num3 = num;
				return this.ab;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)276114956;
				short num2 = num;
				num = (short)202583564;
				switch (num2 == num)
				{
				}
				num = (short)921370624;
				if (num != 0)
				{
				}
				num = (short)719192065;
				if (num != 0)
				{
				}
				num = (short)594214912;
				short num3 = num;
				this.ab = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002DA0 File Offset: 0x00000FA0
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002E4C File Offset: 0x0000104C
		public global::System.TimeSpan? RemainTime
		{
			get
			{
				short num = (short)1998716929;
				if (num != 0)
				{
				}
				num = (short)157740386;
				short num2 = num;
				num = (short)1057549666;
				switch (num2 == num)
				{
				}
				num = (short)818413568;
				if (num != 0)
				{
				}
				num = (short)653852672;
				short num3 = num;
				return this.u;
			}
			private set
			{
				int a_ = 18;
				switch (0)
				{
				case 0:
					goto IL_3D;
				}
				int num;
				short num2;
				global::System.TimeSpan? timeSpan;
				global::System.TimeSpan? timeSpan2;
				for (;;)
				{
					IL_13:
					bool flag;
					switch (num)
					{
					case 0:
						num2 = (short)2012348417;
						if (num2 != 0)
						{
						}
						num2 = (short)1641021443;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_150;
					case 2:
						this.u = value;
						this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::<Module>.b("횲\ud8b4횶킸햺횾곀ꛂ", a_)));
						num2 = (short)1390215172;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						flag = false;
						goto IL_16C;
					case 4:
						return;
					case 5:
						flag = true;
						goto IL_16C;
					case 6:
					{
						if (timeSpan == null)
						{
							num2 = (short)1925644288;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)455081984;
						short num3 = num2;
						num2 = (short)1145962503;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 7:
						flag = (timeSpan.GetValueOrDefault() != timeSpan2.GetValueOrDefault());
						goto IL_16C;
					case 8:
					{
						num2 = (short)1672177118;
						short num4 = num2;
						num2 = (short)392193502;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_150;
						default:
							num2 = (short)866779136;
							if (num2 != 0)
							{
							}
							if (timeSpan != null != (timeSpan2 != null))
							{
								num2 = (short)1769865217;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)613416966;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_3D;
					IL_150:
					num2 = (short)1092812805;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_16C:
					if (!flag)
					{
						break;
					}
					num2 = (short)1668743170;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_3D:
				timeSpan = this.u;
				timeSpan2 = value;
				num2 = (short)2085683208;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0000307C File Offset: 0x0000127C
		// (set) Token: 0x06000024 RID: 36 RVA: 0x0000312C File Offset: 0x0000132C
		public string LoadingError
		{
			get
			{
				short num = (short)1307371986;
				short num2 = num;
				num = (short)1273162194;
				switch (num2 == num)
				{
				}
				num = (short)618004481;
				if (num != 0)
				{
				}
				num = (short)1619656704;
				if (num != 0)
				{
				}
				num = (short)1331101696;
				short num3 = num;
				return this.t;
			}
			private set
			{
				int a_ = 17;
				short num = (short)1328480258;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_BC;
					case 1:
						goto IL_86;
					case 2:
						num = (short)89260033;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					}
					IL_62:
					if (this.t != value)
					{
						num = (short)1721565185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BC;
					IL_86:
					this.t = value;
					this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::<Module>.b("ﲯ\uddb1햳튵톷풹\udbbb﮽늿냁ꯃ듅", a_)));
					num = (short)968556544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BC:
					num = (short)1278621857;
					short num3 = num;
					num = (short)248068257;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_86;
					case 1:
						goto IL_11C;
					}
					break;
				}
				num = (short)799801344;
				short num4 = num;
				IL_11C:
				num = (short)209387520;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000025 RID: 37 RVA: 0x0000326C File Offset: 0x0000146C
		public int TotalCount
		{
			get
			{
				short num = (short)172294146;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_9F;
					case 1:
						goto IL_50;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					if (this.z == -1)
					{
						num = (short)1219362817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9F;
					IL_50:
					this.z = this.b.GetTotalCount();
					num = (short)1073872897;
					if (num != 0)
					{
					}
					num = (short)1011941376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9F:
					num = (short)1272904338;
					short num3 = num;
					num = (short)2083060370;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_50;
					case 1:
						goto IL_FF;
					}
					break;
				}
				num = (short)467599360;
				short num4 = num;
				IL_FF:
				num = (short)1448935424;
				if (num != 0)
				{
				}
				return this.z;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003394 File Offset: 0x00001594
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00003444 File Offset: 0x00001644
		public int LoadedCount
		{
			get
			{
				short num = (short)1517402210;
				short num2 = num;
				num = (short)1070053474;
				switch (num2 == num)
				{
				}
				num = (short)1700265984;
				if (num != 0)
				{
				}
				num = (short)922288129;
				if (num != 0)
				{
				}
				num = (short)1202061312;
				short num3 = num;
				return this.s;
			}
			private set
			{
				int a_ = 0;
				short num = (short)1041235970;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_B7;
					case 1:
						goto IL_80;
					case 2:
						num = (short)548012033;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					}
					IL_61:
					if (this.s != value)
					{
						num = (short)1343750145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B7;
					IL_80:
					this.s = value;
					this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::<Module>.b("펞캠슢솤슦춨슬\udaae\udfb0잲", a_)));
					num = (short)757202944;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B7:
					num = (short)558316528;
					short num3 = num;
					num = (short)1052720112;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_80;
					case 1:
						goto IL_116;
					}
					break;
				}
				num = (short)1417478144;
				short num4 = num;
				IL_116:
				num = (short)362283008;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003580 File Offset: 0x00001780
		public virtual void ItemChanged<TV>(global::System.Data.Linq.ChangeAction operationType, global::System.Collections.Generic.List<TV> changedItem, global::System.Collections.Generic.List<global::System.Guid> legacyGuidList = null, params object[] otherParameters) where TV : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
		{
			short num = (short)1268776966;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)287472616;
				short num3 = num;
				num = (short)129465320;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_F2;
				case 1:
					break;
				default:
				{
					num = (short)1899102208;
					short num4 = num;
					break;
				}
				}
				num = (short)1814691840;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					num = (short)701235203;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_123;
				case 2:
					num = (short)1638793221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_141;
				case 4:
					if (changedItem != null)
					{
						num = (short)257425408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1486356481;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return;
				case 6:
					num = (short)1863647233;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_DD;
					}
					continue;
				}
				IL_DD:
				if (this.IsTypeMatchViewCache(typeof(TV)))
				{
					num = (short)321912836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F2:
				num = (short)1369899010;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_123:
			global::System.Collections.Generic.List<T> list = null;
			goto IL_1C3;
			IL_141:
			list = changedItem.Select(new global::System.Func<TV, T>(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.<>c__54<TV>.<>9.a)).ToList<T>();
			IL_1C3:
			global::System.Collections.Generic.List<T> items = list;
			this.NotifyItemsChanged(operationType, items, legacyGuidList);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000375C File Offset: 0x0000195C
		public void PauseDownloading()
		{
			short num = (short)1968300787;
			short num2 = num;
			num = (short)410247923;
			switch (num2 == num)
			{
			}
			num = (short)1078591489;
			if (num != 0)
			{
			}
			num = (short)1248133120;
			if (num != 0)
			{
			}
			num = (short)1823014912;
			short num3 = num;
			this.LoadingState = 3;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000380C File Offset: 0x00001A0C
		public bool CanStopDownloading()
		{
			short num = (short)2027814915;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)872415232;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_10B;
				case 1:
					num = (short)895025154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (this.LoadingState != 3)
					{
						num = (short)327483392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					continue;
				}
				IL_5E:
				if (this.LoadingState == 1)
				{
					return true;
				}
				num = (short)1977024513;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10B:
			num = (short)1369833473;
			if (num != 0)
			{
			}
			num = (short)1386422257;
			short num4 = num;
			num = (short)116072433;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
				num = (short)740950016;
				if (num != 0)
				{
				}
				return this.LoadingState == 4;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003954 File Offset: 0x00001B54
		public void StopDownloading()
		{
			short num = (short)324468738;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A6;
				case 1:
					goto IL_77;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (this.CanStopDownloading())
				{
					num = (short)665649153;
					if (num != 0)
					{
					}
					num = (short)1713176577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_A6;
				IL_77:
				this.RemainTime = null;
				this.LoadingState = 5;
				num = (short)1122959360;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A6:
				num = (short)2063966976;
				short num3 = num;
				num = (short)2069340928;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_77;
				case 1:
					goto IL_105;
				}
				break;
			}
			num = (short)282656768;
			short num4 = num;
			IL_105:
			num = (short)1761738752;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003A7C File Offset: 0x00001C7C
		public bool CanResumeDownloading()
		{
			short num = (short)951917212;
			short num2 = num;
			num = (short)1569004188;
			switch (num2 == num)
			{
			}
			num = (short)2039873537;
			if (num != 0)
			{
			}
			num = (short)302579712;
			if (num != 0)
			{
			}
			num = (short)1326579712;
			short num3 = num;
			return this.LoadingState == 4;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003B30 File Offset: 0x00001D30
		public bool ResumeDownloading()
		{
			if (this.LoadingState != 4)
			{
				short num = (short)1733999402;
				short num2 = num;
				num = (short)1109310250;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1022754817;
					if (num != 0)
					{
					}
					num = (short)624623616;
					if (num != 0)
					{
					}
					num = (short)1611268096;
					short num3 = num;
					return false;
				}
				}
			}
			this.LoadingState = 1;
			return true;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003BF0 File Offset: 0x00001DF0
		public bool PeerContainsItem(global::System.Guid id)
		{
			short num = (short)1967815933;
			short num2 = num;
			num = (short)1032223997;
			switch (num2 == num)
			{
			}
			num = (short)1553989633;
			if (num != 0)
			{
			}
			num = (short)2067529728;
			if (num != 0)
			{
			}
			num = (short)385613824;
			short num3 = num;
			return this.w.ContainsKey(id);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003CA4 File Offset: 0x00001EA4
		public void Close()
		{
			short num = (short)1297370576;
			short num2 = num;
			num = (short)15224272;
			switch (num2 == num)
			{
			}
			num = (short)1844051969;
			if (num != 0)
			{
			}
			num = (short)395968512;
			if (num != 0)
			{
			}
			num = (short)1539375104;
			short num3 = num;
			this.Close(true);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003D54 File Offset: 0x00001F54
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)638386176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)397869057;
				if (num != 0)
				{
				}
				global::System.IDisposable disposable = base.BlockReentrancy();
				try
				{
					switch (0)
					{
					case 0:
						goto IL_92;
					}
					global::System.Collections.Specialized.NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;
					for (;;)
					{
						IL_57:
						int num3;
						global::System.Collections.Specialized.NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler;
						switch (num2)
						{
						case 0:
						{
							global::System.Windows.Threading.DispatcherObject dispatcherObject;
							if (dispatcherObject != null)
							{
								num = (short)1206190085;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_15E;
						}
						case 1:
						{
							global::System.Delegate[] invocationList;
							if (num3 >= invocationList.Length)
							{
								num = (short)925368329;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							notifyCollectionChangedEventHandler = (global::System.Collections.Specialized.NotifyCollectionChangedEventHandler)invocationList[num3];
							global::System.Windows.Threading.DispatcherObject dispatcherObject = notifyCollectionChangedEventHandler.Target as global::System.Windows.Threading.DispatcherObject;
							num = (short)338493440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_24D;
						case 3:
							if (notifyCollectionChangedEventHandler2 != null)
							{
								num = (short)2129330188;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_235;
						case 4:
						{
							global::System.Windows.Threading.DispatcherObject dispatcherObject;
							if (!dispatcherObject.CheckAccess())
							{
								num = (short)1640890378;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_15E;
						}
						case 5:
							num = (short)1601503236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_181;
						case 7:
							goto IL_11D;
						case 8:
							goto IL_181;
						case 9:
							goto IL_235;
						case 10:
						{
							global::System.Windows.Threading.DispatcherObject dispatcherObject;
							dispatcherObject.Dispatcher.Invoke(global::System.Windows.Threading.DispatcherPriority.SystemIdle, notifyCollectionChangedEventHandler, this, new object[]
							{
								e
							});
							num = (short)1278148619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							goto IL_11D;
						case 12:
						{
							global::System.Delegate[] invocationList = notifyCollectionChangedEventHandler2.GetInvocationList();
							num3 = 0;
							num = (short)896139270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_92;
						IL_11D:
						num3++;
						num = (short)843448328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_15E:
						notifyCollectionChangedEventHandler(this, e);
						num = (short)965672967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_181:
						num = (short)198705153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_235:
						num = (short)1800208386;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_24D:
					goto IL_307;
					IL_92:
					notifyCollectionChangedEventHandler2 = this.aa;
					num = (short)1603403779;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_57;
				}
				finally
				{
					num = (short)1199374338;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_2BB;
						case 1:
							goto IL_29E;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_284;
							}
							continue;
						}
						IL_284:
						if (disposable != null)
						{
							num = (short)279511041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BB;
						IL_29E:
						disposable.Dispose();
						num = (short)1835335680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2BB:
						num = (short)874727954;
						short num4 = num;
						num = (short)1051150866;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_29E;
						default:
							goto IL_2F0;
						}
					}
					IL_2F0:
					num = (short)17170432;
					if (num != 0)
					{
					}
				}
				IL_307:
				num = (short)1069875200;
				short num5 = num;
				return;
			}
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000040B0 File Offset: 0x000022B0
		public bool IsTypeMatchViewCache(global::System.Type type)
		{
			while (!(type == typeof(T)))
			{
				short num = (short)1260978177;
				if (num != 0)
				{
				}
				num = (short)1986946807;
				short num2 = num;
				num = (short)817325815;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1658257408;
					short num3 = num;
					num = (short)518258688;
					if (num != 0)
					{
					}
					return type.IsSubclassOf(typeof(T));
				}
				}
			}
			return true;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004184 File Offset: 0x00002384
		protected void NotifyItemsChanged(global::System.Data.Linq.ChangeAction operationType, global::System.Collections.Generic.List<T> items, global::System.Collections.Generic.List<global::System.Guid> guidList)
		{
			short num = (short)1567621126;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (operationType == global::System.Data.Linq.ChangeAction.Insert)
					{
						num = (short)463208449;
						if (num != 0)
						{
						}
						num = (short)1226964995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1440677896;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1108410370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					if (guidList == null)
					{
						goto IL_83;
					}
					this.NotifyReplaceItems(guidList, items);
					num = (short)2025324544;
					short num3 = num;
					num = (short)246480903;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_131;
				case 4:
				{
					num = (short)743573399;
					short num4 = num;
					num = (short)151193495;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_83;
					default:
						goto IL_1BE;
					}
					break;
				}
				case 5:
					goto IL_64;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 7:
					goto IL_17D;
				case 8:
					if (operationType == global::System.Data.Linq.ChangeAction.Update)
					{
						num = (short)283574273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_49:
				if (operationType == global::System.Data.Linq.ChangeAction.Delete)
				{
					num = (short)1799421957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1189740544;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_83:
				num = (short)1150156804;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_64:
			this.NotifyRemoveItems(guidList);
			return;
			IL_131:
			this.NotifyAddItems(items);
			return;
			IL_17D:
			return;
			IL_1BE:
			num = (short)386138112;
			if (num != 0)
			{
			}
			this.NotifyModifyOrAddItems(items);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004374 File Offset: 0x00002574
		protected void NotifyRemoveItems(global::System.Collections.Generic.List<global::System.Guid> ids)
		{
			short num = (short)1048855083;
			short num2 = num;
			num = (short)1322205739;
			switch (num2 == num)
			{
			default:
			{
				num = (short)562364416;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)631177216;
			if (num != 0)
			{
			}
			num = (short)856162305;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.b a_ = new global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.b(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.c.a, ids);
			this.l.a(a_);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004430 File Offset: 0x00002630
		protected void NotifyAddItems(global::System.Collections.Generic.List<T> items)
		{
			short num = (short)299761665;
			if (num != 0)
			{
			}
			num = (short)108789760;
			short num2 = num;
			num = (short)72114444;
			short num3 = num;
			num = (short)820273420;
			switch (num3 == num)
			{
			}
			num = (short)810811392;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.b a_ = new global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.b(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.c.b, items);
			this.l.a(a_);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000044EC File Offset: 0x000026EC
		protected void NotifyModifyOrAddItems(global::System.Collections.Generic.List<T> items)
		{
			short num = (short)930310973;
			short num2 = num;
			num = (short)471821117;
			switch (num2 == num)
			{
			default:
			{
				num = (short)121634816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1831665665;
			if (num != 0)
			{
			}
			num = (short)874315776;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.b a_ = new global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.b(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.c.c, items);
			this.l.a(a_);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000045A8 File Offset: 0x000027A8
		protected void NotifyModifyItems(global::System.Collections.Generic.List<T> items)
		{
			short num = (short)1020409519;
			short num2 = num;
			num = (short)654390959;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1034485760;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1056374785;
			if (num != 0)
			{
			}
			num = (short)2058813440;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.b a_ = new global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.b(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.c.f, items);
			this.l.a(a_);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004664 File Offset: 0x00002864
		protected void NotifyReplaceItems(global::System.Collections.Generic.List<global::System.Guid> ids, global::System.Collections.Generic.List<T> items)
		{
			short num = (short)1785333721;
			short num2 = num;
			num = (short)1872562137;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1281622016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)177340417;
			if (num != 0)
			{
			}
			num = (short)1974468608;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.b a_ = new global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.b(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.c.d, ids, items);
			this.l.a(a_);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004724 File Offset: 0x00002924
		protected void NotifyRefreshAll()
		{
			short num = (short)400949249;
			if (num != 0)
			{
			}
			num = (short)1968766976;
			short num2 = num;
			num = (short)1926424082;
			short num3 = num;
			num = (short)1873077778;
			switch (num3 == num)
			{
			}
			num = (short)1663893504;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.b a_ = new global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.b(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.c.e);
			this.l.a(a_);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000047E0 File Offset: 0x000029E0
		protected void Add(T item, bool notifyUi)
		{
			short num = (short)1183383552;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.Dictionary<global::System.Guid, T> obj;
				bool flag;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 1:
					IL_2BF:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_83;
						}
						for (;;)
						{
							IL_61:
							switch (num2)
							{
							case 0:
								base.Add(item);
								num = (short)1454964742;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								num = (short)1119879169;
								if (num != 0)
								{
								}
								global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.a(this.w[item.ID.Value], item);
								num = (short)1414987778;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_13C;
							case 3:
								if (notifyUi)
								{
									num = (short)391708672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								base.Items.Insert(base.Items.Count, item);
								num = (short)88145925;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								if (this.w.ContainsKey(item.ID.Value))
								{
									num = (short)1220804609;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								this.w.Add(item.ID.Value, item);
								num = (short)323747843;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_1E5;
							case 6:
								goto IL_15F;
							}
							goto IL_83;
						}
						IL_13C:
						IL_15F:
						IL_1E5:
						return;
						IL_83:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num = (short)1547501572;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_61;
					}
					finally
					{
						num = (short)814219264;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_21B;
								}
								continue;
							case 1:
								goto IL_24F;
							case 2:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1795096577;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_21B:
							if (!flag)
							{
								break;
							}
							num = (short)85262338;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_24F:;
					}
					goto IL_252;
				case 2:
					goto IL_52;
				}
				IL_32:
				if (item == null)
				{
					num = (short)287571970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_252:
				obj = this.w;
				flag = false;
				num = (short)1155397826;
				short num3 = num;
				num = (short)959445186;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2BF;
				default:
					num = (short)277020672;
					if (num != 0)
					{
					}
					num = (short)710934529;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_52:
			num = (short)492961792;
			short num4 = num;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004AF8 File Offset: 0x00002CF8
		protected virtual void Close(bool disposing)
		{
			short num = (short)1869283331;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)264896513;
					if (num != 0)
					{
					}
					num = (short)1425231956;
					short num3 = num;
					num = (short)626741332;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1357250560;
						if (num != 0)
						{
						}
						if (disposing)
						{
							num = (short)917241860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62;
					}
					break;
				}
				case 1:
					num = (short)2045116416;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_62;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 4:
				{
					num = (short)270467072;
					short num4 = num;
					this.i.c();
					this.j.c();
					this.k.c();
					this.m = new global::System.Collections.Concurrent.ConcurrentBag<T>();
					this.w = new global::System.Collections.Generic.Dictionary<global::System.Guid, T>();
					this.aa = null;
					base.Clear();
					this.e = null;
					this.f = null;
					this.g = null;
					this.h = null;
					num = (short)967180290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					return;
				}
				IL_3D:
				if (!this.d)
				{
					num = (short)1546190849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_62:
				this.d = true;
				num = (short)1037172741;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004CDC File Offset: 0x00002EDC
		private static int a(global::System.Guid A_0, int A_1, int A_2, global::System.Collections.Generic.IList<T> A_3)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			int num4;
			for (;;)
			{
				IL_0A:
				global::System.Guid guid;
				global::System.Guid guid2;
				switch (num)
				{
				case 0:
				{
					num2 = (short)1474683705;
					short num3 = num2;
					num2 = (short)263906105;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1619787776;
						if (num2 != 0)
						{
						}
						num2 = (short)355991558;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					if (num4 > A_2)
					{
						num2 = (short)170917891;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.Guid? id = A_3[num4].ID;
					num2 = (short)349241346;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					global::System.Guid? id;
					if (id == null)
					{
						num2 = (short)983236608;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1911095300;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_A3;
				case 4:
				{
					global::System.Guid? id;
					guid = id.GetValueOrDefault();
					goto IL_186;
				}
				case 5:
					if (guid2.Equals(A_0))
					{
						num2 = (short)707002376;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num4++;
					num2 = (short)416219145;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					guid = global::System.Guid.Empty;
					goto IL_186;
				case 7:
					goto IL_73;
				case 8:
					goto IL_1C3;
				case 9:
					goto IL_73;
				}
				goto IL_38;
				IL_73:
				num2 = (short)816054273;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_186:
				guid2 = guid;
				num2 = (short)86769669;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_A3:
			num2 = (short)1810169856;
			short num5 = num2;
			return -1;
			IL_1C3:
			num2 = (short)1483800577;
			if (num2 != 0)
			{
			}
			return num4;
			IL_38:
			num4 = A_1;
			num2 = (short)1713307655;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004F04 File Offset: 0x00003104
		private static int a(int A_0, int A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (A_1 > 0)
					{
						num2 = (short)2133655557;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return num3;
				case 1:
					goto IL_D3;
				case 2:
					goto IL_F1;
				case 3:
					num3 = 1;
					num2 = (short)2130771970;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)2102284460;
					short num4 = num2;
					num2 = (short)1314672812;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D3;
					default:
					{
						num2 = (short)2128478208;
						if (num2 != 0)
						{
						}
						num2 = (short)283836416;
						short num5 = num2;
						if (A_0 > 0)
						{
							num2 = (short)1091174401;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return num3;
					}
					}
					break;
				}
				case 5:
					num3 = A_0 * 1000 / A_1;
					num2 = (short)864681990;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (num3 == 0)
					{
						num2 = (short)1259601923;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return num3;
				}
				goto IL_2C;
				IL_D3:
				num2 = (short)819920896;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F1:
			num2 = (short)1417674753;
			if (num2 != 0)
			{
			}
			return num3;
			IL_2C:
			num3 = 1;
			num2 = (short)68157444;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000050A4 File Offset: 0x000032A4
		private static void a(T A_0, T A_1)
		{
			short num = (short)728236032;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					goto IL_FA;
				case 2:
				{
					A_0.CopyFrom(A_1);
					num = (short)1067346490;
					short num3 = num;
					num = (short)1439722042;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1508245505;
						if (num != 0)
						{
						}
						num = (short)938606592;
						if (num != 0)
						{
						}
						num = (short)1835794433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_31:
				if (!A_0.IsNewVersion(A_1))
				{
					return;
				}
				num = (short)821952514;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FA:
			num = (short)16842752;
			short num4 = num;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000051D8 File Offset: 0x000033D8
		private void a(global::System.Collections.Generic.List<global::System.Guid> A_0, bool A_1)
		{
			short num = (short)304939009;
			if (num != 0)
			{
			}
			num = (short)1753657109;
			short num2 = num;
			num = (short)1957342997;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1172504576;
				if (num != 0)
				{
				}
				num = (short)1533542400;
				switch (num)
				{
				default:
				{
					num = (short)77135872;
					short num3 = num;
					global::System.Collections.Generic.Dictionary<global::System.Guid, T> obj = this.w;
					bool flag = false;
					try
					{
						global::System.Threading.Monitor.Enter(obj, ref flag);
						using (global::System.Collections.Generic.List<global::System.Guid>.Enumerator enumerator = A_0.Where(new global::System.Func<global::System.Guid, bool>(this.a)).ToList<global::System.Guid>().GetEnumerator())
						{
							num = (short)1740505093;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 1:
									num = (short)1212809222;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									int index;
									base.RemoveAt(index);
									num = (short)489488384;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									if (A_1)
									{
										num = (short)1647050755;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									int index;
									base.Items.RemoveAt(index);
									num = (short)681050114;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_131;
									}
									continue;
								case 6:
									goto IL_22A;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)396099585;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Guid guid = enumerator.Current;
									this.w.Remove(guid);
									int index = global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.a(guid, 0, base.Count - 1, this);
									num = (short)681902084;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_189:
								num = (short)221642759;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_131:
								goto IL_189;
							}
							IL_22A:;
						}
					}
					finally
					{
						num = (short)47251456;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_26C;
								}
								continue;
							case 1:
								goto IL_2A2;
							case 2:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1435303937;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_26C:
							if (!flag)
							{
								break;
							}
							num = (short)1874591746;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_2A2:;
					}
					break;
				}
				}
				break;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000054C0 File Offset: 0x000036C0
		private void c(int A_0)
		{
			short num = (short)1648341904;
			short num2 = num;
			num = (short)1268495248;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1681915904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)788463617;
			if (num != 0)
			{
			}
			num = (short)634519552;
			if (num != 0)
			{
			}
			this.o = A_0;
			this.p = 0;
			this.q = -1;
			this.r = 0;
			this.s = 0;
			this.l = new global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.a();
			this.m = new global::System.Collections.Concurrent.ConcurrentBag<T>();
			this.n = new global::System.Collections.Concurrent.ConcurrentBag<T>();
			this.i = new global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.d();
			this.j = new global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.d();
			this.k = new global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.d();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000055CC File Offset: 0x000037CC
		private void e(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.e A_0)
		{
			int a_ = 5;
			short num = (short)2040463361;
			if (num != 0)
			{
			}
			num = (short)1316945920;
			short num2 = num;
			num = (short)964231168;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				bool flag = false;
				this.LoadingState = 1;
				global::System.Diagnostics.Process currentProcess = global::System.Diagnostics.Process.GetCurrentProcess();
				try
				{
					switch (0)
					{
					case 0:
						goto IL_118;
					}
					int num6;
					for (;;)
					{
						IL_95:
						global::System.TimeSpan? a_2;
						int num4;
						global::System.TimeSpan value;
						switch (num3)
						{
						case 0:
							num = (short)454557714;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (a_2 != null)
							{
								num = (short)909967363;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_412;
						case 2:
							goto IL_588;
						case 3:
							goto IL_18D;
						case 4:
							if ((double)currentProcess.PrivateMemorySize64 >= 1181116006.4)
							{
								num = (short)845938708;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_51D;
						case 5:
						{
							if (num4 > this.o)
							{
								num = (short)1602027543;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)719096727;
							short num5 = num;
							num = (short)2026867607;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_18D;
							default:
								num = (short)655032320;
								if (num != 0)
								{
								}
								num6 += num4;
								num = (short)684982280;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							if (A_0.b())
							{
								num = (short)1004994573;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1781465117;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_412;
						case 8:
							goto IL_2BF;
						case 9:
						{
							global::Motorola.Common.LogUtility.ILog logger = global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName);
							string format = global::<Module>.b("쎥얧쮩얫삭邯\uddb3\udbb5\uddb7骹햻춽ꏁꣅ귇귉귋뫍맏ꓑ뇓뛗꿙뇛볝藟郡쫣웥럧黩菫髭釯黱럳駵跷铹裻쓽⃿礁㐃笅␇⨉漋愍攏簑怓Ⱅ㠗愙ⴛ挝టȡ眣嘥䴧伩䠫ᐭု䤱س䬵ᐷᨹ儻圽ⰿ⹁ⵃᕅⵇ⥉癋湍⭏慑⥓穕硗ख़㥛㵝ཟౡcᕥ剧䩩ᝫ婭൯幱味≵᝷๹ᵻች퍿ﾋ뒍낏ꆓ", a_);
							object[] array = new object[6];
							array[0] = this.z;
							array[1] = num6;
							array[2] = this.Speed;
							int num7;
							array[3] = num7;
							int num8 = 4;
							a_2 = this.RemainTime;
							value = a_2.Value;
							array[num8] = value.Seconds;
							int num9 = 5;
							a_2 = this.RemainTime;
							value = a_2.Value;
							array[num9] = value.TotalSeconds;
							logger.Error(format, array);
							num = (short)223281159;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
						{
							int num7 = (this.z - num6) * 1000 / this.Speed;
							num = (short)406519834;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							global::System.GC.Collect();
							currentProcess.Refresh();
							num = (short)605224964;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							if (flag)
							{
								num = (short)1212022801;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)927334406;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							num = (short)1820786707;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							if (this.z != -1)
							{
								num = (short)755236864;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_412;
						case 15:
							num = (short)117637147;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							goto IL_412;
						case 17:
							a_2 = null;
							this.RemainTime = a_2;
							this.LoadingState = 2;
							num = (short)99549206;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							if (this.z > num6)
							{
								num = (short)643891210;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_28F;
						case 19:
							goto IL_6FB;
						case 20:
							goto IL_188;
						case 21:
							if (A_0.b())
							{
								num = (short)408289305;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1462435845;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							goto IL_730;
						case 23:
							num6 += this.o;
							num = (short)838336542;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							if (value.Seconds < 0)
							{
								num = (short)1906376713;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_412;
						case 25:
							num = (short)962592770;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							try
							{
								int num7;
								this.RemainTime = new global::System.TimeSpan?(global::System.TimeSpan.FromMilliseconds((double)num7));
								goto IL_58D;
							}
							catch (global::System.Exception ex)
							{
								int num7;
								global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::<Module>.b("쾥얧쾩ﾫ\udead톯\udcb1骳쪷햹톻ꦿ껁ꣃ꿅믇꿉꿋ꇍ뻏뛑ꟓﻕꏗꇛ샟雡賣铥蟧鷩쳫语裯釱釳蛵賷鏹鏻都㫿∁缃㜅甇", a_), new object[]
								{
									num7,
									ex.Message
								});
								this.RemainTime = new global::System.TimeSpan?(new global::System.TimeSpan(0, 0, 0, 0, num7));
								goto IL_58D;
							}
							goto IL_28F;
							IL_58D:
							a_2 = this.RemainTime;
							num = (short)1117192193;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							if ((double)currentProcess.PrivateMemorySize64 >= 1181116006.4)
							{
								num = (short)170197003;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_51D;
						case 28:
							goto IL_412;
						case 29:
							if (global::System.IntPtr.Size == 4)
							{
								num = (short)1898577935;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_51D;
						case 30:
							goto IL_2BF;
						}
						goto IL_118;
						IL_18D:
						a_2 = this.RemainTime;
						value = a_2.Value;
						num = (short)1744437272;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_28F:
						this.RemainTime = new global::System.TimeSpan?(new global::System.TimeSpan(1L));
						num = (short)927465500;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2BF:
						int a_3;
						this.b(a_3);
						num = (short)337641486;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_412:
						num = (short)2112552972;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_51D:
						num4 = 0;
						flag = this.a(num6, this.o, out a_3, out num4);
						num = (short)382992405;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_188:
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::<Module>.b("誩삫솭톯횱钳튵\ud9b7캹\uddbb麽ꎿꏁ뇃뗅귇룋ꛍ뗏뇓껕믗뿙곛ꫝ觟跡諣웥蟧賩쳫臭藯蛱퓳駵黷\udaf9釻鯽淿洁瘃缅␇⨉漋笍戏怑焓砕気㨙椛洝䔟䘡У䬥䴧䜩䌫尭䤯࠱ᐳ䴵࠷䜹笻", a_), new object[]
					{
						currentProcess.PrivateMemorySize64 / 1024L / 1024L / 1024L
					});
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_LoadingTooMuchDataRecords, global::<Module>.b("誩\udeab잭쎯\ud9b1钳\ud9b5\udeb7骹펻쮽뒿꧃ꏅꗇꗉ뻋럍ﳏꟓꋕ럗꫙ﳛ뫝迟闡諣諥蟧诩裫蟭黯闱", a_));
					IL_588:
					IL_6FB:
					IL_730:
					return;
					IL_118:
					num6 = 0;
					num = (short)983498768;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_95;
				}
				catch (global::Motorola.Common.CustomException.CommonException ex2)
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(ex2, global::Motorola.Common.LogUtility.LoggingLevel.EventError);
					this.LoadingError = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex2.ErrorCode.ToString(), null);
				}
				catch (global::System.Exception ex3)
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(ex3, global::Motorola.Common.LogUtility.LoggingLevel.EventError);
					this.LoadingError = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.GenericError.ToString(), null);
				}
				finally
				{
					num = (short)605290497;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							this.LoadingState = 2;
							num = (short)962461698;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_7D4;
							}
							continue;
						case 2:
							goto IL_812;
						}
						IL_7D4:
						if (this.LoadingState != 1)
						{
							break;
						}
						num = (short)2038235136;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_812:;
				}
				return;
			}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005E54 File Offset: 0x00004054
		private void h()
		{
			short num = (short)1894458549;
			short num2 = num;
			num = (short)124462261;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1231552513;
				if (num != 0)
				{
				}
				num = (short)67895296;
				if (num != 0)
				{
				}
				this.StopDownloading();
				this.m = new global::System.Collections.Concurrent.ConcurrentBag<T>();
				this.n = new global::System.Collections.Concurrent.ConcurrentBag<T>();
				global::System.Collections.Generic.Dictionary<global::System.Guid, T> obj = this.w;
				bool flag = false;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					this.ClearItems();
					this.w.Clear();
				}
				finally
				{
					num = (short)1333395457;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1451163650;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_E6;
							}
							continue;
						case 2:
							goto IL_119;
						}
						IL_E6:
						if (!flag)
						{
							break;
						}
						num = (short)526909440;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_119:;
				}
				break;
			}
			}
			num = (short)352714752;
			short num4 = num;
			this.i = new global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.d();
			this.LoadedCount = 0;
			this.e = global::System.Threading.Tasks.Task.Run(new global::System.Action(this.a));
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005FE4 File Offset: 0x000041E4
		private void d(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.e A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_64;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_230;
				case 1:
				{
					num2 = (short)1728249856;
					short num3 = num2;
					goto IL_314;
				}
				case 2:
					return;
				case 3:
				{
					global::System.EventHandler eventHandler = this.a;
					if (eventHandler == null)
					{
						num2 = (short)606797829;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					eventHandler(this, global::System.EventArgs.Empty);
					goto IL_383;
				}
				case 4:
				{
					if (flag)
					{
						goto IL_314;
					}
					num2 = (short)1195424449;
					short num4 = num2;
					num2 = (short)2072885953;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_383;
					default:
						num2 = (short)1561198592;
						if (num2 != 0)
						{
						}
						num2 = (short)385155085;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					goto IL_314;
				case 6:
					goto IL_314;
				case 7:
					num2 = (short)2037383183;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					T t;
					this.Add(t, flag);
					num2 = (short)271843328;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					num2 = (short)1163919361;
					if (num2 != 0)
					{
					}
					num2 = (short)1458503690;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (this.m.Count == 0)
					{
						num2 = (short)472252432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_314;
				case 11:
					if (!flag)
					{
						num2 = (short)607125521;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					flag = (this.LoadingState != 2);
					num2 = (short)435617812;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
				{
					if (A_0.b())
					{
						num2 = (short)327745538;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					T t;
					this.x = this.n.TryTake(out t);
					num2 = (short)596508690;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
					num2 = (short)69599246;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (this.n.Count == 0)
					{
						num2 = (short)2078736393;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_314;
				case 15:
				{
					T t;
					if (!this.b(t))
					{
						num2 = (short)1039728648;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_230;
				}
				case 16:
					flag = true;
					num2 = (short)1464795139;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					this.g();
					num2 = (short)254672915;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					if (this.x)
					{
						num2 = (short)1284898823;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.Threading.Thread.Sleep(50);
					num2 = (short)166264836;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					goto IL_314;
				case 20:
					goto IL_314;
				}
				goto IL_64;
				IL_230:
				num2 = (short)829161483;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_314:
				num2 = (short)1788739596;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_383:
				num2 = (short)1217200129;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_64:
			flag = true;
			num2 = (short)1401094150;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000063BC File Offset: 0x000045BC
		private void c(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.e A_0)
		{
			for (;;)
			{
				short num = (short)704708612;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_192;
					case 1:
						goto IL_88;
					case 2:
					{
						if (this.y)
						{
							num = (short)156172293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2079440825;
						short num3 = num;
						num = (short)1317650361;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D6;
						case 1:
							break;
						default:
						{
							num = (short)1711210496;
							short num4 = num;
							break;
						}
						}
						num = (short)1943994369;
						if (num != 0)
						{
						}
						num = (short)56623104;
						if (num != 0)
						{
						}
						global::System.Threading.Thread.Sleep(50);
						num = (short)432275456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 5:
						goto IL_D6;
					}
					IL_3C:
					if (A_0.b())
					{
						num = (short)2086993923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					T t;
					this.y = this.m.TryTake(out t);
					num = (short)1305804802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D6:
					this.b.SetValidator(t);
					this.n.Add(t);
					num = (short)633077761;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_88:
				IL_192:;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00006560 File Offset: 0x00004760
		private void g()
		{
			short num = (short)656015360;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 1:
					for (;;)
					{
						num = (short)991252115;
						short num3 = num;
						num = (short)103304851;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_9C;
						}
					}
					IL_9C:
					num = (short)928448513;
					if (num != 0)
					{
					}
					num = (short)1776877568;
					if (num != 0)
					{
					}
					num = (short)719126530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (this.m.Count != 0)
					{
						num = (short)1418985477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)360841222;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1A5;
				case 4:
					goto IL_17F;
				case 5:
					return;
				case 6:
				{
					num = (short)1418985472;
					short num4 = num;
					global::System.EventHandler eventHandler = this.a;
					if (eventHandler == null)
					{
						num = (short)836763652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					eventHandler(this, global::System.EventArgs.Empty);
					num = (short)1303445507;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_41:
				if (this.n.Count != 0)
				{
					break;
				}
				num = (short)808976385;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_17F:
			IL_1A5:
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00006720 File Offset: 0x00004920
		private void b(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.e A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2109227640;
					short num3 = num2;
					num2 = (short)1631011448;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_20;
					case 1:
						break;
					default:
					{
						num2 = (short)968949760;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)642514944;
					if (num2 != 0)
					{
					}
					goto IL_B6;
				}
				case 1:
					goto IL_B6;
				case 2:
					if (A_0.b())
					{
						num2 = (short)1910767619;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)166199297;
					if (num2 != 0)
					{
					}
					this.a(A_0);
					global::System.Threading.Thread.Sleep(500);
					num2 = (short)1109786625;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return;
				}
				goto IL_20;
				IL_B6:
				num2 = (short)1701838850;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			global::System.Threading.Thread.Sleep(3000);
			num2 = (short)1323106304;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00006870 File Offset: 0x00004A70
		private void c(global::System.Collections.Generic.List<T> A_0)
		{
			short num = (short)1394016256;
			short num2 = num;
			num = (short)1550076260;
			short num3 = num;
			num = (short)1133005156;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)137166849;
				if (num != 0)
				{
				}
				num = (short)1638400000;
				if (num != 0)
				{
				}
				if (this.m == null)
				{
					return;
				}
				break;
			}
			this.LoadedCount += A_0.Count;
			A_0.ForEach(new global::System.Action<T>(this.a));
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000694C File Offset: 0x00004B4C
		private void a(global::System.Collections.Generic.List<global::System.Guid> A_0, global::System.Collections.Generic.List<T> A_1)
		{
			short num = (short)857997312;
			short num2 = num;
			num = (short)1940193829;
			short num3 = num;
			num = (short)39453221;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)230162432;
				if (num != 0)
				{
				}
				num = (short)903282688;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					global::System.Collections.Generic.Dictionary<global::System.Guid, T> obj = this.w;
					bool flag = false;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_D8;
						}
						int num5;
						for (;;)
						{
							IL_A5:
							switch (num4)
							{
							case 0:
								goto IL_205;
							case 1:
								num = (short)1991639044;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								if (num5 >= A_0.Count)
								{
									num = (short)1858207745;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Guid key = A_0[num5];
								T t = A_1[num5];
								num = (short)2077753350;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_169;
							case 4:
								goto IL_2DC;
							case 5:
							{
								T t;
								global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.a(this.w[t.ID.Value], t);
								num = (short)1985609738;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								global::System.Guid key;
								if (this.w.ContainsKey(key))
								{
									num = (short)1293746185;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)934608903;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								T t;
								if (this.w.ContainsKey(t.ID.Value))
								{
									num = (short)454098949;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_205;
							}
							case 8:
								goto IL_169;
							case 9:
							{
								global::System.Guid key;
								T t2 = this.w[key];
								this.w.Remove(key);
								T t;
								t2.CopyFrom(t);
								this.w.Add(t2.ID.Value, t2);
								num = (short)1775501312;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 10:
								goto IL_205;
							}
							goto IL_D8;
							IL_169:
							num = (short)479526914;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_205:
							num5++;
							num = (short)170983432;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_2DC:
						break;
						IL_D8:
						global::System.Threading.Monitor.Enter(obj, ref flag);
						num5 = 0;
						num = (short)2054815747;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_A5;
					}
					finally
					{
						num = (short)1452015616;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_311;
								}
								continue;
							case 1:
								goto IL_346;
							case 2:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)1093468161;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_311:
							if (!flag)
							{
								break;
							}
							num = (short)691208194;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_346:;
					}
					break;
				}
				}
				break;
			}
			}
			num = (short)1073545217;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006CE8 File Offset: 0x00004EE8
		private void b(global::System.Collections.Generic.List<T> A_0)
		{
			short num = (short)518979584;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_65;
				}
				global::System.Collections.Generic.List<T> list;
				global::System.Collections.Generic.Dictionary<global::System.Guid, T> obj;
				bool flag;
				for (;;)
				{
					IL_28:
					num = (short)469172225;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_8A;
					case 1:
					{
						num = (short)1063334721;
						short num3 = num;
						num = (short)1582379841;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8A;
						default:
							goto IL_33D;
						}
						break;
					}
					case 2:
						if (list.Count > 0)
						{
							num = (short)630587395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_2E2;
					}
					goto IL_65;
					IL_8A:
					num = (short)1593245696;
					short num4 = num;
					try
					{
						global::System.Threading.Monitor.Enter(obj, ref flag);
						using (global::System.Collections.Generic.List<T>.Enumerator enumerator = A_0.GetEnumerator())
						{
							num = (short)416546816;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_150;
									}
									continue;
								case 1:
								{
									T t;
									if (this.w.ContainsKey(t.ID.Value))
									{
										num = (short)1151336451;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									list.Add(t);
									num = (short)772800519;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)423165958;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									T t = enumerator.Current;
									num = (short)2048327681;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									T t;
									global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.a(this.w[t.ID.Value], t);
									num = (short)2088239109;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_265;
								case 6:
									num = (short)1999241220;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1AB:
								num = (short)1461583874;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_150:
								goto IL_1AB;
							}
							IL_265:
							goto IL_B5;
						}
					}
					finally
					{
						num = (short)275644416;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2AA;
								}
								continue;
							case 1:
								goto IL_2DF;
							case 2:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)957415425;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2AA:
							if (!flag)
							{
								break;
							}
							num = (short)1975582722;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2DF:;
					}
					goto IL_2E2;
					IL_B5:
					num = (short)1629159426;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E2:
					this.ItemChanged<T>(global::System.Data.Linq.ChangeAction.Insert, list, null, global::System.Array.Empty<object>());
					num = (short)268697601;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_33D:
				num = (short)993460224;
				if (num != 0)
				{
				}
				return;
				IL_65:
				list = new global::System.Collections.Generic.List<T>();
				obj = this.w;
				flag = false;
				num = (short)2129592320;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00007080 File Offset: 0x00005280
		private void a(global::System.Collections.Generic.List<T> A_0)
		{
			short num = (short)240910336;
			short num2 = num;
			num = (short)557948957;
			short num3 = num;
			num = (short)913088541;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1435172864;
				if (num != 0)
				{
				}
				num = (short)1990852609;
				if (num != 0)
				{
				}
				num = (short)1799553024;
				switch (num)
				{
				default:
				{
					global::System.Collections.Generic.Dictionary<global::System.Guid, T> obj = this.w;
					bool flag = false;
					try
					{
						global::System.Threading.Monitor.Enter(obj, ref flag);
						using (global::System.Collections.Generic.List<T>.Enumerator enumerator = A_0.GetEnumerator())
						{
							num = (short)1217069056;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_117;
									}
									continue;
								case 1:
								{
									T t;
									if (this.w.ContainsKey(t.ID.Value))
									{
										num = (short)615448578;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									T t;
									global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.a(this.w[t.ID.Value], t);
									num = (short)1569193988;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_202;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1287061510;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									T t = enumerator.Current;
									num = (short)1621884929;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)449314819;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_16F:
								num = (short)1678835717;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_117:
								goto IL_16F;
							}
							IL_202:;
						}
					}
					finally
					{
						num = (short)393543680;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_244;
								}
								continue;
							case 1:
								goto IL_27C;
							case 2:
								global::System.Threading.Monitor.Exit(obj);
								num = (short)425394177;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_244:
							if (!flag)
							{
								break;
							}
							num = (short)1311965186;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_27C:;
					}
					break;
				}
				}
				break;
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00007340 File Offset: 0x00005540
		private void a(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.e A_0)
		{
			for (;;)
			{
				IL_00:
				short num = (short)512425984;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 1:
						return;
					case 2:
						num = (short)1323696129;
						if (num != 0)
						{
						}
						goto IL_33E;
					case 3:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_11E;
							}
							global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.c c;
							global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.b b;
							for (;;)
							{
								IL_E0:
								switch (num2)
								{
								case 0:
									goto IL_30B;
								case 1:
									if (this.l.Count == 0)
									{
										num = (short)245825545;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_30B;
								case 2:
									goto IL_30B;
								case 3:
									switch (c)
									{
									case global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.c.a:
										this.a(b.e(), false);
										num = (short)1936457729;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.c.b:
										this.c(b.f());
										num = (short)1296760832;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.c.c:
										this.b(b.f());
										num = (short)678625285;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.c.d:
										this.a(b.e(), b.f());
										num = (short)1305739268;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.c.e:
										goto IL_23E;
									case global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.c.f:
										this.a(b.f());
										num = (short)1470234637;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									default:
										num = (short)1722351622;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									goto IL_30B;
								case 5:
									goto IL_30B;
								case 6:
									num = (short)13303816;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_30B;
								case 8:
									goto IL_30B;
								case 9:
									this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
									num = (short)1487208455;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_322;
								case 11:
									this.h();
									num = (short)1860042754;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									if (this.l.a() == null)
									{
										num = (short)88539147;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_23E;
								case 13:
									goto IL_30B;
								}
								goto IL_11E;
								IL_23E:
								num = (short)102694924;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_30B:
								num = (short)947716106;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_322:
							goto IL_00;
							IL_11E:
							c = b.d();
							num = (short)462028803;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_E0;
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(ex, global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							goto IL_00;
						}
						goto IL_33E;
					case 4:
					{
						global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.b b;
						if (b != null)
						{
							num = (short)485425154;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					IL_38:
					if (!A_0.b())
					{
						global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.b b = this.l.a();
						num = (short)1767571460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)376941135;
					short num3 = num;
					num = (short)507947599;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)958005248;
						short num4 = num;
						num = (short)1210253312;
						if (num != 0)
						{
						}
						num = (short)1121386497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_33E:
					num = (short)465043459;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00007734 File Offset: 0x00005934
		private void b(int A_0)
		{
			short num = (short)2031091713;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_D8;
			}
			int num4;
			for (;;)
			{
				IL_32:
				num = (short)2050293760;
				short num2 = num;
				num = (short)1577137600;
				short num3 = num;
				num = (short)333133248;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)105709568;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						num = (short)1603665922;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_179;
					case 2:
						if (A_0 < 3000)
						{
							num = (short)1888616452;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17E;
					case 3:
						goto IL_195;
					case 4:
						goto IL_277;
					case 5:
						this.o = this.v / this.Speed;
						num = (short)1593573385;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (2000 <= A_0)
						{
							num = (short)1533411328;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17E;
					case 7:
						goto IL_124;
					case 8:
						goto IL_217;
					case 9:
						if (this.o < 100)
						{
							num = (short)803667969;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						if (A_0 < 2000)
						{
							num = (short)1090519047;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)674234374;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D8;
					IL_17E:
					num = (short)1973551107;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_195:
				if (A_0 > this.v)
				{
					num = (short)1336279045;
					num4 = (int)((global::System.IntPtr)num);
				}
				else
				{
					this.o = 500;
					num = (short)2066284552;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
			IL_124:
			this.a(A_0);
			return;
			IL_179:
			this.o = 100;
			return;
			IL_217:
			return;
			IL_277:
			this.o += 200;
			return;
			IL_D8:
			this.Speed = global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.a(this.o, A_0);
			num = (short)1959395338;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000079BC File Offset: 0x00005BBC
		private void a(int A_0)
		{
			short num = (short)654573576;
			int num2 = (int)((global::System.IntPtr)num);
			int num5;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (this.r <= 0)
					{
						goto IL_21F;
					}
					num = (short)1677031102;
					short num3 = num;
					num = (short)1301051070;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D4;
					default:
						num = (short)607911936;
						if (num != 0)
						{
						}
						num = (short)396820486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (this.q < A_0)
					{
						num = (short)1057226754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21F;
				case 2:
				{
					int num4 = A_0 - this.q;
					num5 = (3000 - A_0) / num4 * this.r;
					goto IL_D4;
				}
				case 3:
					num = (short)124715009;
					if (num != 0)
					{
					}
					if (num5 > 5000)
					{
						num = (short)1330642948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C2;
				case 4:
					num5 = 5000;
					num = (short)82313223;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1621491712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)982253569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_B5;
				case 8:
				{
					num = (short)470155264;
					short num6 = num;
					switch (0)
					{
					case 0:
						goto IL_75;
					}
					continue;
				}
				}
				IL_75:
				if (this.q > 0)
				{
					num = (short)1260519429;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_21F;
				IL_D4:
				num = (short)821559299;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B5:
			IL_1C2:
			this.o += num5;
			this.r = num5;
			this.q = A_0;
			return;
			IL_21F:
			this.q = A_0;
			this.r = this.o;
			this.o *= 2;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00007C0C File Offset: 0x00005E0C
		private bool a(int A_0, int A_1, out int A_2, out int A_3)
		{
			global::System.Collections.Generic.IList<T> list = this.b.FetchRange(A_0, A_1, out A_2);
			A_3 = list.Count;
			if (list.Count <= 0)
			{
				short num;
				for (;;)
				{
					num = (short)1682833409;
					if (num != 0)
					{
					}
					num = (short)996441523;
					short num2 = num;
					num = (short)543522227;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_AB;
					}
					break;
				}
				num = (short)309329920;
				short num3 = num;
				IL_AB:
				num = (short)381878272;
				if (num != 0)
				{
				}
				return true;
			}
			this.c(list.ToList<T>());
			return list.Count < A_1;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00007CF4 File Offset: 0x00005EF4
		private bool b(T A_0)
		{
			if (this.c != null)
			{
				short num;
				for (;;)
				{
					num = (short)140026798;
					short num2 = num;
					num = (short)1856873390;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_41;
					}
				}
				IL_41:
				num = (short)1747517440;
				short num3 = num;
				num = (short)519438337;
				if (num != 0)
				{
				}
				num = (short)2041511936;
				if (num != 0)
				{
				}
				return this.c.IsFilterOut(A_0);
			}
			return false;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00007DB8 File Offset: 0x00005FB8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void f()
		{
			short num;
			for (;;)
			{
				this.e = global::System.Threading.Tasks.Task.Run(new global::System.Action(this.e));
				try
				{
					this.TotalCount.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
				}
				catch
				{
					this.i.c();
					throw;
				}
				num = (short)869773473;
				short num2 = num;
				num = (short)480096417;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_9D;
				}
				break;
			}
			num = (short)1075380224;
			short num3 = num;
			IL_9D:
			num = (short)264175617;
			if (num != 0)
			{
			}
			num = (short)786497536;
			if (num != 0)
			{
			}
			this.f = global::System.Threading.Tasks.Task.Run(new global::System.Action(this.d));
			this.g = global::System.Threading.Tasks.Task.Run(new global::System.Action(this.c));
			this.h = global::System.Threading.Tasks.Task.Run(new global::System.Action(this.b));
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00007EF4 File Offset: 0x000060F4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void e()
		{
			short num = (short)828899329;
			if (num != 0)
			{
			}
			num = (short)1105594897;
			short num2 = num;
			num = (short)642189841;
			switch (num2 == num)
			{
			}
			num = (short)1854210048;
			short num3 = num;
			num = (short)1970208768;
			if (num != 0)
			{
			}
			this.e(this.i.b());
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00007FB0 File Offset: 0x000061B0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void d()
		{
			short num = (short)1681216044;
			short num2 = num;
			num = (short)372658732;
			switch (num2 == num)
			{
			}
			num = (short)412549121;
			if (num != 0)
			{
			}
			num = (short)493551616;
			short num3 = num;
			num = (short)1907032064;
			if (num != 0)
			{
			}
			this.d(this.k.b());
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000806C File Offset: 0x0000626C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void c()
		{
			short num = (short)934791870;
			short num2 = num;
			num = (short)1951320766;
			switch (num2 == num)
			{
			}
			num = (short)1646264321;
			if (num != 0)
			{
			}
			num = (short)368377856;
			short num3 = num;
			num = (short)123011072;
			if (num != 0)
			{
			}
			this.c(this.k.b());
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00008124 File Offset: 0x00006324
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b()
		{
			short num = (short)830607701;
			short num2 = num;
			num = (short)788730197;
			switch (num2 == num)
			{
			}
			num = (short)854065153;
			if (num != 0)
			{
			}
			num = (short)1124401152;
			short num3 = num;
			num = (short)1316552704;
			if (num != 0)
			{
			}
			this.b(this.j.b());
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000081E0 File Offset: 0x000063E0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a(global::System.Guid A_0)
		{
			short num = (short)1556903032;
			short num2 = num;
			num = (short)967734392;
			switch (num2 == num)
			{
			}
			num = (short)2135162881;
			if (num != 0)
			{
			}
			num = (short)1783562240;
			short num3 = num;
			num = (short)1074659328;
			if (num != 0)
			{
			}
			return this.w.ContainsKey(A_0);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00008294 File Offset: 0x00006494
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a()
		{
			short num = (short)1876924596;
			short num2 = num;
			num = (short)956733620;
			switch (num2 == num)
			{
			}
			num = (short)832110593;
			if (num != 0)
			{
			}
			num = (short)342032384;
			short num3 = num;
			num = (short)1169424384;
			if (num != 0)
			{
			}
			this.e(this.i.b());
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00008350 File Offset: 0x00006550
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(T A_0)
		{
			short num = (short)976128391;
			short num2 = num;
			num = (short)137922951;
			switch (num2 == num)
			{
			}
			num = (short)319881217;
			if (num != 0)
			{
			}
			num = (short)1396703232;
			short num3 = num;
			num = (short)865075200;
			if (num != 0)
			{
			}
			this.m.Add(A_0);
		}

		// Token: 0x04000003 RID: 3
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler a;

		// Token: 0x04000004 RID: 4
		private readonly global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<T> b;

		// Token: 0x04000005 RID: 5
		private readonly global::Motorola.CommonCPS.RadioManagement.ViewCache.IFilter<T> c;

		// Token: 0x04000006 RID: 6
		private bool d;

		// Token: 0x04000007 RID: 7
		private global::System.Threading.Tasks.Task e;

		// Token: 0x04000008 RID: 8
		private global::System.Threading.Tasks.Task f;

		// Token: 0x04000009 RID: 9
		private global::System.Threading.Tasks.Task g;

		// Token: 0x0400000A RID: 10
		private global::System.Threading.Tasks.Task h;

		// Token: 0x0400000B RID: 11
		private global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.d i;

		// Token: 0x0400000C RID: 12
		private global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.d j;

		// Token: 0x0400000D RID: 13
		private global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.d k;

		// Token: 0x0400000E RID: 14
		private global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T>.a l;

		// Token: 0x0400000F RID: 15
		private global::System.Collections.Concurrent.ConcurrentBag<T> m;

		// Token: 0x04000010 RID: 16
		private global::System.Collections.Concurrent.ConcurrentBag<T> n;

		// Token: 0x04000011 RID: 17
		private int o;

		// Token: 0x04000012 RID: 18
		private int p;

		// Token: 0x04000013 RID: 19
		private int q = -1;

		// Token: 0x04000014 RID: 20
		private int r;

		// Token: 0x04000015 RID: 21
		private int s;

		// Token: 0x04000016 RID: 22
		private string t;

		// Token: 0x04000017 RID: 23
		private global::System.TimeSpan? u;

		// Token: 0x04000018 RID: 24
		private int v = 10000;

		// Token: 0x04000019 RID: 25
		private global::System.Collections.Generic.Dictionary<global::System.Guid, T> w = new global::System.Collections.Generic.Dictionary<global::System.Guid, T>();

		// Token: 0x0400001A RID: 26
		private bool x = true;

		// Token: 0x0400001B RID: 27
		private bool y = true;

		// Token: 0x0400001C RID: 28
		private int z = -1;

		// Token: 0x0400001D RID: 29
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler aa;

		// Token: 0x0400001E RID: 30
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int ab;

		// Token: 0x02000007 RID: 7
		private class a : global::System.Collections.Concurrent.ConcurrentBag<global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<a>.b>
		{
			// Token: 0x06000057 RID: 87 RVA: 0x00008408 File Offset: 0x00006608
			public void a(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<a>.b A_0)
			{
				short num = (short)1118421710;
				short num2 = num;
				num = (short)1631109838;
				switch (num2 == num)
				{
				}
				num = (short)821821440;
				if (num != 0)
				{
				}
				num = (short)888537088;
				short num3 = num;
				num = (short)786890753;
				if (num != 0)
				{
				}
				base.Add(A_0);
			}

			// Token: 0x06000058 RID: 88 RVA: 0x000084B4 File Offset: 0x000066B4
			public global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<a>.b a()
			{
				global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<a>.b result;
				if (!base.TryTake(out result))
				{
					short num;
					for (;;)
					{
						num = (short)388806323;
						short num2 = num;
						num = (short)2126362291;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_43;
						}
					}
					IL_43:
					num = (short)191692800;
					short num3 = num;
					num = (short)151781377;
					if (num != 0)
					{
					}
					num = (short)1798832128;
					if (num != 0)
					{
					}
					return null;
				}
				return result;
			}
		}

		// Token: 0x02000008 RID: 8
		private class b
		{
			// Token: 0x0600005A RID: 90 RVA: 0x00008584 File Offset: 0x00006784
			public b(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<a>.c A_0)
			{
				this.d(A_0);
			}

			// Token: 0x0600005B RID: 91 RVA: 0x000085A0 File Offset: 0x000067A0
			public b(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<a>.c A_0, global::System.Collections.Generic.List<global::System.Guid> A_1)
			{
				this.d(A_0);
				this.d(A_1);
			}

			// Token: 0x0600005C RID: 92 RVA: 0x000085C4 File Offset: 0x000067C4
			public b(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<a>.c A_0, global::System.Collections.Generic.List<a> A_1)
			{
				this.d(A_0);
				this.d(A_1);
			}

			// Token: 0x0600005D RID: 93 RVA: 0x000085E8 File Offset: 0x000067E8
			public b(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<a>.c A_0, global::System.Collections.Generic.List<global::System.Guid> A_1, global::System.Collections.Generic.List<a> A_2)
			{
				this.d(A_0);
				this.d(A_1);
				this.d(A_2);
			}

			// Token: 0x0600005E RID: 94 RVA: 0x00008610 File Offset: 0x00006810
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			public global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<a>.c d()
			{
				short num = (short)769220101;
				short num2 = num;
				num = (short)570580485;
				switch (num2 == num)
				{
				}
				num = (short)1666580481;
				if (num != 0)
				{
				}
				num = (short)1954742272;
				short num3 = num;
				num = (short)1494614016;
				if (num != 0)
				{
				}
				return this.a;
			}

			// Token: 0x0600005F RID: 95 RVA: 0x000086C0 File Offset: 0x000068C0
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			public void d(global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<a>.c A_0)
			{
				short num = (short)796918720;
				short num2 = num;
				num = (short)344458176;
				switch (num2 == num)
				{
				}
				num = (short)381485057;
				if (num != 0)
				{
				}
				num = (short)1304625152;
				short num3 = num;
				num = (short)911540224;
				if (num != 0)
				{
				}
				this.a = A_0;
			}

			// Token: 0x06000060 RID: 96 RVA: 0x00008770 File Offset: 0x00006970
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			public global::System.Collections.Generic.List<global::System.Guid> e()
			{
				short num = (short)1217937375;
				short num2 = num;
				num = (short)1748123615;
				switch (num2 == num)
				{
				}
				num = (short)1822425089;
				if (num != 0)
				{
				}
				num = (short)429391872;
				short num3 = num;
				num = (short)365494272;
				if (num != 0)
				{
				}
				return this.b;
			}

			// Token: 0x06000061 RID: 97 RVA: 0x0000881C File Offset: 0x00006A1C
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			public void d(global::System.Collections.Generic.List<global::System.Guid> A_0)
			{
				short num = (short)290433597;
				short num2 = num;
				num = (short)1851697725;
				switch (num2 == num)
				{
				}
				num = (short)1414791169;
				if (num != 0)
				{
				}
				num = (short)1632960512;
				short num3 = num;
				num = (short)880476160;
				if (num != 0)
				{
				}
				this.b = A_0;
			}

			// Token: 0x06000062 RID: 98 RVA: 0x000088CC File Offset: 0x00006ACC
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			public global::System.Collections.Generic.List<a> f()
			{
				short num = (short)1719599105;
				if (num != 0)
				{
				}
				num = (short)1444205864;
				short num2 = num;
				num = (short)1321588008;
				switch (num2 == num)
				{
				}
				num = (short)2038759424;
				short num3 = num;
				num = (short)1226178560;
				if (num != 0)
				{
				}
				return this.c;
			}

			// Token: 0x06000063 RID: 99 RVA: 0x0000897C File Offset: 0x00006B7C
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private void d(global::System.Collections.Generic.List<a> A_0)
			{
				short num = (short)1433398083;
				short num2 = num;
				num = (short)1900538691;
				switch (num2 == num)
				{
				}
				num = (short)705298433;
				if (num != 0)
				{
				}
				num = (short)1742798848;
				short num3 = num;
				num = (short)1524563968;
				if (num != 0)
				{
				}
				this.c = A_0;
			}

			// Token: 0x0400001F RID: 31
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<a>.c a;

			// Token: 0x04000020 RID: 32
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private global::System.Collections.Generic.List<global::System.Guid> b;

			// Token: 0x04000021 RID: 33
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private global::System.Collections.Generic.List<a> c;
		}

		// Token: 0x02000009 RID: 9
		private enum c
		{
			// Token: 0x04000023 RID: 35
			a,
			// Token: 0x04000024 RID: 36
			b,
			// Token: 0x04000025 RID: 37
			c,
			// Token: 0x04000026 RID: 38
			d,
			// Token: 0x04000027 RID: 39
			e,
			// Token: 0x04000028 RID: 40
			f
		}

		// Token: 0x0200000A RID: 10
		private class d
		{
			// Token: 0x06000064 RID: 100 RVA: 0x00008A2C File Offset: 0x00006C2C
			public global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<a>.e b()
			{
				short num = (short)1537610158;
				short num2 = num;
				num = (short)180883886;
				switch (num2 == num)
				{
				}
				num = (short)1773862913;
				if (num != 0)
				{
				}
				num = (short)2039414784;
				short num3 = num;
				num = (short)145883136;
				if (num != 0)
				{
				}
				return this.a;
			}

			// Token: 0x06000065 RID: 101 RVA: 0x00008ADC File Offset: 0x00006CDC
			public void c()
			{
				short num = (short)531706845;
				short num2 = num;
				num = (short)1319973853;
				switch (num2 == num)
				{
				}
				num = (short)1856700416;
				if (num != 0)
				{
				}
				num = (short)1412366336;
				short num3 = num;
				num = (short)2129788929;
				if (num != 0)
				{
				}
				this.a.b(true);
			}

			// Token: 0x04000029 RID: 41
			private readonly global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<a>.e a = new global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<a>.e();
		}

		// Token: 0x0200000B RID: 11
		private class e
		{
			// Token: 0x06000067 RID: 103 RVA: 0x00008BB4 File Offset: 0x00006DB4
			public e()
			{
				this.b(false);
			}

			// Token: 0x06000068 RID: 104 RVA: 0x00008BD0 File Offset: 0x00006DD0
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			public bool b()
			{
				short num = (short)1705471072;
				short num2 = num;
				num = (short)1464101984;
				switch (num2 == num)
				{
				}
				num = (short)2009595905;
				if (num != 0)
				{
				}
				num = (short)278790144;
				short num3 = num;
				num = (short)625344512;
				if (num != 0)
				{
				}
				return this.a;
			}

			// Token: 0x06000069 RID: 105 RVA: 0x00008C80 File Offset: 0x00006E80
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			public void b(bool A_0)
			{
				short num = (short)1925120001;
				if (num != 0)
				{
				}
				num = (short)117643112;
				short num2 = num;
				num = (short)1224742760;
				switch (num2 == num)
				{
				}
				num = (short)969605120;
				short num3 = num;
				num = (short)1748959232;
				if (num != 0)
				{
				}
				this.a = A_0;
			}

			// Token: 0x0400002A RID: 42
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private bool a;
		}
	}
}
