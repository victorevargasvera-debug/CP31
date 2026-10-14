using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x02000032 RID: 50
	internal class PerformanceWatch : global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceWatch
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00017760 File Offset: 0x00015960
		public static global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceWatch NullWatch
		{
			get
			{
				short num = (short)42161378;
				short num2 = num;
				num = (short)680285410;
				switch (num2 == num)
				{
				}
				num = (short)1842348033;
				if (num != 0)
				{
				}
				num = (short)783613952;
				if (num != 0)
				{
				}
				num = (short)1148977152;
				short num3 = num;
				return new global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceWatch.NullWatchImpl();
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00017810 File Offset: 0x00015A10
		// (set) Token: 0x06000191 RID: 401 RVA: 0x000178C4 File Offset: 0x00015AC4
		private global::System.Diagnostics.Stopwatch Timer
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)871366657;
				if (num != 0)
				{
				}
				num = (short)324375582;
				short num2 = num;
				num = (short)1885639710;
				switch (num2 == num)
				{
				}
				num = (short)1636040704;
				if (num != 0)
				{
				}
				num = (short)1875574784;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)430619111;
				short num2 = num;
				num = (short)1498397159;
				switch (num2 == num)
				{
				}
				num = (short)1067057152;
				if (num != 0)
				{
				}
				num = (short)981663745;
				if (num != 0)
				{
				}
				num = (short)1513029632;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00017974 File Offset: 0x00015B74
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00017A24 File Offset: 0x00015C24
		public global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails OverallState
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1749417985;
				if (num != 0)
				{
				}
				num = (short)741177422;
				short num2 = num;
				num = (short)1156347982;
				switch (num2 == num)
				{
				}
				num = (short)2030960640;
				if (num != 0)
				{
				}
				num = (short)758448128;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)971827433;
				short num2 = num;
				num = (short)821684457;
				switch (num2 == num)
				{
				}
				num = (short)1444085761;
				if (num != 0)
				{
				}
				num = (short)1376911360;
				if (num != 0)
				{
				}
				num = (short)477102080;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00017AD4 File Offset: 0x00015CD4
		public global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails> Steps
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1980074129;
				short num2 = num;
				num = (short)1794214033;
				switch (num2 == num)
				{
				}
				num = (short)1905065984;
				if (num != 0)
				{
				}
				num = (short)1228144641;
				if (num != 0)
				{
				}
				num = (short)1293811712;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00017B84 File Offset: 0x00015D84
		public global::Motorola.Common.LogUtility.PerformanceMeasurement.SystemState SystemState
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1123942147;
				short num2 = num;
				num = (short)1768095491;
				switch (num2 == num)
				{
				}
				num = (short)1400438785;
				if (num != 0)
				{
				}
				num = (short)474021888;
				if (num != 0)
				{
				}
				num = (short)1871183872;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00017C34 File Offset: 0x00015E34
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00017CE8 File Offset: 0x00015EE8
		private global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot Snapshot
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)768681736;
				short num2 = num;
				num = (short)1065232136;
				switch (num2 == num)
				{
				}
				num = (short)511574016;
				if (num != 0)
				{
				}
				num = (short)2132803585;
				if (num != 0)
				{
				}
				num = (short)1525809152;
				short num3 = num;
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1577530099;
				short num2 = num;
				num = (short)509162227;
				switch (num2 == num)
				{
				}
				num = (short)944963585;
				if (num != 0)
				{
				}
				num = (short)202506240;
				if (num != 0)
				{
				}
				num = (short)826605568;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00017D98 File Offset: 0x00015F98
		public string Duration
		{
			get
			{
				int a_ = 9;
				short num = (short)1827143680;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.DateTime timeStamp;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 1:
					{
						num = (short)1367798977;
						short num3 = num;
						num = (short)297202881;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_B1;
						}
						break;
					}
					case 2:
						goto IL_5A;
					}
					IL_39:
					global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot performanceSnapshot = this.FirstSnapshot;
					if (performanceSnapshot == null)
					{
						num = (short)2030174210;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						timeStamp = performanceSnapshot.TimeStamp;
						num = (short)1702952961;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_5A:
				string str = null;
				goto IL_133;
				IL_B1:
				num = (short)2023161857;
				if (num != 0)
				{
				}
				num = (short)1607729152;
				if (num != 0)
				{
				}
				num = (short)2070151168;
				short num4 = num;
				str = timeStamp.ToString(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᩜ", a_), global::Motorola.Common.LogUtility.PredefinedName.DefaultCulture);
				IL_133:
				string str2 = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("絜⅞䅠", a_);
				global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot performanceSnapshot2 = this.LastSnapshot;
				string str3;
				if (performanceSnapshot2 == null)
				{
					str3 = null;
				}
				else
				{
					timeStamp = performanceSnapshot2.TimeStamp;
					str3 = timeStamp.ToString(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᩜ", a_), global::Motorola.Common.LogUtility.PredefinedName.DefaultCulture);
				}
				return str + str2 + str3;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00017F1C File Offset: 0x0001611C
		private global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot FirstSnapshot
		{
			get
			{
				short num = (short)654180353;
				if (num != 0)
				{
				}
				num = (short)2101044174;
				short num2 = num;
				num = (short)245195726;
				switch (num2 == num)
				{
				}
				num = (short)1591869440;
				if (num != 0)
				{
				}
				num = (short)1372127232;
				short num3 = num;
				global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot> list = this.f;
				if (list == null)
				{
					return null;
				}
				return list.FirstOrDefault<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot>();
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00017FD8 File Offset: 0x000161D8
		private global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot LastSnapshot
		{
			get
			{
				short num = (short)1375600641;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)865861635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)379912192;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_5F;
						}
						continue;
					}
					case 2:
						goto IL_B7;
					case 3:
					{
						if (this.f.Count <= 1)
						{
							num = (short)1795751938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1455836512;
						short num4 = num;
						num = (short)1006194016;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_ED;
						}
						break;
					}
					}
					IL_5F:
					if (this.f == null)
					{
						break;
					}
					num = (short)717357056;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_7D:
				return null;
				IL_B7:
				goto IL_7D;
				IL_ED:
				num = (short)1234042881;
				if (num != 0)
				{
				}
				num = (short)1244069888;
				if (num != 0)
				{
				}
				return this.f[this.f.Count - 1];
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0001812C File Offset: 0x0001632C
		public PerformanceWatch(global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMonitor performanceMonitor)
		{
			int a_ = 11;
			this.c = new global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails>();
			this.d = new global::Motorola.Common.LogUtility.PerformanceMeasurement.SystemState
			{
				{
					global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ၞ㉠", a_),
					global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ਫ਼འၢၤᝦᥨѪὬ᭮ᑰᝲ", a_)
				}
			};
			this.f = new global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot>();
			this.g = true;
			base..ctor();
			this.h = performanceMonitor;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0001819C File Offset: 0x0001639C
		public void Init()
		{
			short num = (short)2114421016;
			short num2 = num;
			num = (short)723484952;
			switch (num2 == num)
			{
			}
			num = (short)1101725697;
			if (num != 0)
			{
			}
			num = (short)1702035456;
			if (num != 0)
			{
			}
			num = (short)512557056;
			short num3 = num;
			this.Snapshot = this.h.GetSnapshot(false);
			this.Start();
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00018264 File Offset: 0x00016464
		public void Start()
		{
			short num = (short)1147535361;
			if (num != 0)
			{
			}
			num = (short)1147338757;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot snapshot;
				switch (num2)
				{
				case 0:
					if (this.Timer == null)
					{
						goto IL_1B6;
					}
					this.Timer.Start();
					num = (short)686948355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_194;
				case 2:
					return;
				case 3:
					goto IL_95;
				case 4:
					if (snapshot != null)
					{
						num = (short)461897734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FA;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_71;
					}
					continue;
				case 6:
				{
					num = (short)997326848;
					short num3 = num;
					this.f.Add(snapshot);
					num = (short)1168834561;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					this.Timer = global::System.Diagnostics.Stopwatch.StartNew();
					num = (short)1607464752;
					short num4 = num;
					num = (short)1419310896;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B6;
					default:
						num = (short)23134208;
						if (num != 0)
						{
						}
						num = (short)1434124296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					goto IL_95;
				}
				IL_71:
				if (!this.g)
				{
					num = (short)1394737154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1657208832;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_95:
				snapshot = this.h.GetSnapshot(true);
				num = (short)1893597188;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B6:
				num = (short)1448607751;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_194:
			IL_1FA:
			this.g = false;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00018474 File Offset: 0x00016674
		public bool Stop()
		{
			short num = (short)1384120321;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot snapshot;
				switch (num2)
				{
				case 0:
					this.f.Add(snapshot);
					num = (short)1004470276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1020374274;
					short num3 = num;
					num = (short)1552133378;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_148;
					default:
					{
						num = (short)1004666880;
						short num4 = num;
						num = (short)1327759360;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B0;
						}
						continue;
					}
					}
					break;
				}
				case 2:
					return false;
				case 3:
					goto IL_148;
				case 4:
					goto IL_115;
				}
				IL_B0:
				num = (short)1597898753;
				if (num != 0)
				{
				}
				if (this.g)
				{
					num = (short)2021916674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.Timer.Stop();
				snapshot = this.h.GetSnapshot(true);
				num = (short)1542586371;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_148:
				if (snapshot == null)
				{
					goto IL_167;
				}
				num = (short)1833304064;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_115:
			IL_167:
			this.c();
			this.g = true;
			return true;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000185F8 File Offset: 0x000167F8
		private void c()
		{
			short num = (short)533594112;
			short num2 = num;
			num = (short)728367104;
			switch (num)
			{
			default:
			{
				num = (short)671875076;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int count;
					switch (num3)
					{
					case 0:
						return;
					case 1:
						num = (short)142802951;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
					{
						num = (short)1927086081;
						if (num != 0)
						{
						}
						global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot performanceSnapshot = this.f[count - 2];
						global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot performanceSnapshot2 = this.f[count - 1];
						global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails item = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceWatch.a(performanceSnapshot, performanceSnapshot2);
						this.Steps.Add(item);
						global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot> source = new global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot>
						{
							this.Snapshot,
							performanceSnapshot,
							performanceSnapshot2
						};
						goto IL_1F4;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_8E;
						}
						continue;
					case 5:
						if (count > 1)
						{
							num = (short)647561217;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
					{
						global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot performanceSnapshot3 = this.Snapshot;
						global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot> source;
						global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot performanceSnapshot4 = source.Where(delegate(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot s)
						{
							short num5 = (short)1880686593;
							if (num5 != 0)
							{
							}
							num5 = (short)1156920404;
							short num6 = num5;
							num5 = (short)1029256276;
							switch (num6 == num5)
							{
							default:
							{
								num5 = (short)1532362752;
								short num7 = num5;
								break;
							}
							case true:
								break;
							}
							num5 = (short)1679294464;
							if (num5 != 0)
							{
							}
							return s.SystemCpuAvailablePercentage != null;
						}).OrderBy(delegate(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot s)
						{
							short num5 = (short)1911265496;
							short num6 = num5;
							num5 = (short)1552783576;
							switch (num6 == num5)
							{
							}
							num5 = (short)297074688;
							short num7 = num5;
							num5 = (short)584122369;
							if (num5 != 0)
							{
							}
							num5 = (short)1344208896;
							if (num5 != 0)
							{
							}
							return s.SystemCpuAvailablePercentage;
						}).FirstOrDefault<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot>();
						performanceSnapshot3.SystemCpuAvailablePercentage = ((performanceSnapshot4 != null) ? performanceSnapshot4.SystemCpuAvailablePercentage : null);
						global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot performanceSnapshot;
						global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot performanceSnapshot2;
						this.Snapshot.SystemMemoryAvailableMb = global::System.Math.Min(this.Snapshot.SystemMemoryAvailableMb, global::System.Math.Min(performanceSnapshot2.SystemMemoryAvailableMb, performanceSnapshot.SystemMemoryAvailableMb));
						this.Snapshot.CpuTimeMs += performanceSnapshot2.CpuTimeMs - performanceSnapshot.CpuTimeMs;
						this.Snapshot.KernelCpuTimeMs += performanceSnapshot2.KernelCpuTimeMs - performanceSnapshot.KernelCpuTimeMs;
						this.Snapshot.UserCpuTimeMs += performanceSnapshot2.UserCpuTimeMs - performanceSnapshot.UserCpuTimeMs;
						this.Snapshot.MemoryMb = (this.Snapshot.MemoryPeakMb = global::System.Math.Max(this.Snapshot.MemoryPeakMb, global::System.Math.Max(performanceSnapshot2.MemoryMb, performanceSnapshot.MemoryMb)));
						this.b();
						this.a();
						num = (short)1893793792;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						if ((count & 1) != 0)
						{
							return;
						}
						num = (short)1658770652;
						short num4 = num;
						num = (short)238539996;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1F4;
						default:
							num = (short)1004797952;
							if (num != 0)
							{
							}
							num = (short)1398210563;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_8E:
					if (this.Snapshot == null)
					{
						num = (short)1949433858;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					count = this.f.Count;
					num = (short)128843781;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F4:
					num = (short)423231494;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00018978 File Offset: 0x00016B78
		private void b()
		{
			short num = (short)382401428;
			short num2 = num;
			num = (short)396819348;
			switch (num2 == num)
			{
			}
			num = (short)116588545;
			if (num != 0)
			{
			}
			num = (short)617152512;
			short num3 = num;
			num = (short)465108992;
			if (num != 0)
			{
			}
			this.SystemState.Clear();
			this.SystemState.CpuAvailablePercentage = this.Snapshot.SystemCpuAvailablePercentage;
			this.SystemState.MemoryAvailableMB = this.Snapshot.SystemMemoryAvailableMb;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00018A58 File Offset: 0x00016C58
		private static global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails a(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot A_0, global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot A_1)
		{
			int a_ = 6;
			long num4;
			for (;;)
			{
				IL_09:
				short num = (short)1475018754;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1986881568;
						short num3 = num;
						num = (short)844654624;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num = (short)581566464;
							if (num != 0)
							{
							}
							if (A_1 == null)
							{
								num = (short)976617473;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4 = (long)global::System.Math.Round((A_1.TimeStamp - A_0.TimeStamp).TotalMilliseconds);
							num = (short)1992818688;
							short num5 = num;
							num = (short)1903034373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						goto IL_198;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 3:
						goto IL_10F;
					case 4:
						num = (short)1066795009;
						if (num != 0)
						{
						}
						num = (short)869335040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (num4 < 0L)
						{
							num = (short)1180041219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A3;
					}
					IL_45:
					if (A_0 == null)
					{
						goto IL_114;
					}
					num = (short)1385824260;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_10F:
			return new global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails();
			IL_114:
			return new global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails();
			IL_198:
			goto IL_114;
			IL_1A3:
			return new global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails
			{
				CycleTime = A_1.TimeStamp - A_0.TimeStamp,
				Duration = A_0.TimeStamp.ToString(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᵙ", a_), global::Motorola.Common.LogUtility.PredefinedName.DefaultCulture) + global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("穙≛繝", a_) + A_1.TimeStamp.ToString(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᵙ", a_), global::Motorola.Common.LogUtility.PredefinedName.DefaultCulture),
				CpuTotalUsagePercentage = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceWatch.a(A_0.CpuTimeMs, A_1.CpuTimeMs, num4),
				CpuKernelUsagePercentage = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceWatch.a(A_0.KernelCpuTimeMs, A_1.KernelCpuTimeMs, num4),
				CpuUserUsagePercentage = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceWatch.a(A_0.UserCpuTimeMs, A_1.UserCpuTimeMs, num4),
				MemoryDeltaMB = (short)(A_1.MemoryMb - A_0.MemoryMb),
				MemoryPeakMB = global::System.Math.Max(A_1.MemoryMb, A_0.MemoryMb)
			};
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00018CF4 File Offset: 0x00016EF4
		private void a()
		{
			global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot performanceSnapshot;
			short num2;
			global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot performanceSnapshot2;
			long elapsedMilliseconds;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (performanceSnapshot != null)
						{
							num2 = (short)1538850817;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1FA;
					case 1:
						num2 = (short)635305989;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (performanceSnapshot2 != null)
						{
							num2 = (short)549978116;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1FA;
					case 3:
						goto IL_196;
					case 4:
						num2 = (short)905773056;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						if (elapsedMilliseconds > 0L)
						{
							num2 = (short)954793987;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1FA;
					}
					goto IL_28;
				}
				IL_196:
				num2 = (short)335478785;
				if (num2 != 0)
				{
				}
				num2 = (short)1525848641;
				short num3 = num2;
				num2 = (short)1963301441;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_AE;
				}
				IL_28:
				performanceSnapshot2 = this.FirstSnapshot;
				performanceSnapshot = this.Snapshot;
				elapsedMilliseconds = this.Timer.ElapsedMilliseconds;
				num2 = (short)1937506306;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_AE:
			num2 = (short)1071841280;
			short num4 = num2;
			num2 = (short)1003683840;
			if (num2 != 0)
			{
			}
			this.OverallState = new global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails
			{
				CycleTime = this.Timer.Elapsed,
				CpuTotalUsagePercentage = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceWatch.a(0U, performanceSnapshot.CpuTimeMs, elapsedMilliseconds),
				CpuKernelUsagePercentage = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceWatch.a(0U, performanceSnapshot.KernelCpuTimeMs, elapsedMilliseconds),
				CpuUserUsagePercentage = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceWatch.a(0U, performanceSnapshot.UserCpuTimeMs, elapsedMilliseconds),
				MemoryDeltaMB = (short)(performanceSnapshot.MemoryMb - performanceSnapshot2.MemoryMb),
				MemoryPeakMB = performanceSnapshot.MemoryMb
			};
			return;
			IL_1FA:
			this.OverallState = new global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00018F08 File Offset: 0x00017108
		private static byte a(uint A_0, uint A_1, long A_2)
		{
			short num = (short)107915419;
			short num2 = num;
			num = (short)2111613083;
			switch (num2 == num)
			{
			}
			num = (short)1977745409;
			if (num != 0)
			{
			}
			num = (short)1183973376;
			short num3 = num;
			num = (short)913178624;
			if (num != 0)
			{
			}
			return (byte)global::System.Math.Ceiling(100.0 * (double)global::System.Math.Abs((long)((ulong)(A_1 - A_0))) / (double)global::System.Environment.ProcessorCount / (double)A_2);
		}

		// Token: 0x040000DD RID: 221
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Diagnostics.Stopwatch a;

		// Token: 0x040000DE RID: 222
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails b;

		// Token: 0x040000DF RID: 223
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails> c;

		// Token: 0x040000E0 RID: 224
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.Common.LogUtility.PerformanceMeasurement.SystemState d;

		// Token: 0x040000E1 RID: 225
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot e;

		// Token: 0x040000E2 RID: 226
		private readonly global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot> f;

		// Token: 0x040000E3 RID: 227
		private bool g;

		// Token: 0x040000E4 RID: 228
		private readonly global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMonitor h;

		// Token: 0x02000033 RID: 51
		private class NullWatchImpl : global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceWatch
		{
			// Token: 0x17000071 RID: 113
			// (get) Token: 0x060001A4 RID: 420 RVA: 0x00018FD4 File Offset: 0x000171D4
			public string Duration
			{
				get
				{
					short num = (short)166006312;
					short num2 = num;
					num = (short)738790952;
					switch (num2 == num)
					{
					}
					num = (short)918552577;
					if (num != 0)
					{
					}
					num = (short)632684544;
					short num3 = num;
					num = (short)1370947584;
					if (num != 0)
					{
					}
					return string.Empty;
				}
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060001A5 RID: 421 RVA: 0x00019084 File Offset: 0x00017284
			public global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails OverallState
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)615040682;
					short num2 = num;
					num = (short)1913374378;
					switch (num2 == num)
					{
					}
					num = (short)295239680;
					if (num != 0)
					{
					}
					num = (short)711000064;
					short num3 = num;
					num = (short)1069940737;
					if (num != 0)
					{
					}
					return this.a;
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x060001A6 RID: 422 RVA: 0x00019130 File Offset: 0x00017330
			public global::Motorola.Common.LogUtility.PerformanceMeasurement.SystemState SystemState
			{
				get
				{
					short num = (short)693868682;
					short num2 = num;
					num = (short)1944623242;
					switch (num2 == num)
					{
					}
					num = (short)81985536;
					short num3 = num;
					num = (short)1498939392;
					if (num != 0)
					{
					}
					num = (short)129040385;
					if (num != 0)
					{
					}
					return null;
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060001A7 RID: 423 RVA: 0x000191D8 File Offset: 0x000173D8
			public global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot Snapshot
			{
				get
				{
					short num = (short)350289921;
					if (num != 0)
					{
					}
					num = (short)492591793;
					short num2 = num;
					num = (short)1230789297;
					switch (num2 == num)
					{
					default:
					{
						num = (short)1543569408;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)495321088;
					if (num != 0)
					{
					}
					return null;
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x060001A8 RID: 424 RVA: 0x00019284 File Offset: 0x00017484
			public global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails> Steps
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)539870903;
					short num2 = num;
					num = (short)735561399;
					switch (num2 == num)
					{
					}
					num = (short)1413742592;
					short num3 = num;
					num = (short)168689664;
					if (num != 0)
					{
					}
					num = (short)1790771201;
					if (num != 0)
					{
					}
					return this.b;
				}
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00019338 File Offset: 0x00017538
			public void Init()
			{
				short num = (short)1346046350;
				short num2 = num;
				num = (short)186517902;
				switch (num2 == num)
				{
				}
				num = (short)1705639936;
				short num3 = num;
				num = (short)375062528;
				if (num != 0)
				{
				}
				num = (short)1781858305;
				if (num != 0)
				{
				}
			}

			// Token: 0x060001AA RID: 426 RVA: 0x000193E4 File Offset: 0x000175E4
			public void Start()
			{
				short num;
				while (!this.c)
				{
					num = (short)432048979;
					short num2 = num;
					num = (short)452561747;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num = (short)523829248;
						short num3 = num;
						break;
					}
					}
					num = (short)1141243904;
					if (num != 0)
					{
					}
					return;
				}
				num = (short)1131216897;
				if (num != 0)
				{
				}
				this.c = false;
			}

			// Token: 0x060001AB RID: 427 RVA: 0x000194A4 File Offset: 0x000176A4
			public bool Stop()
			{
				while (this.c)
				{
					short num = (short)413270017;
					if (num != 0)
					{
					}
					num = (short)1871577088;
					short num2 = num;
					num = (short)229597100;
					short num3 = num;
					num = (short)254238636;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1192230912;
						if (num != 0)
						{
						}
						return false;
					}
				}
				this.c = true;
				return true;
			}

			// Token: 0x040000E5 RID: 229
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private readonly global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails a = new global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails();

			// Token: 0x040000E6 RID: 230
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private readonly global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails> b = new global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails>();

			// Token: 0x040000E7 RID: 231
			private bool c;
		}
	}
}
