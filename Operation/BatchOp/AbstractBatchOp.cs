using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x0200000C RID: 12
	public abstract class AbstractBatchOp<T> : global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp
	{
		// Token: 0x0600002F RID: 47 RVA: 0x000043AC File Offset: 0x000025AC
		protected AbstractBatchOp()
		{
			this.Status = global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.PENDING;
			this.i = global::System.Guid.NewGuid();
			this.IsVisible = true;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000030 RID: 48 RVA: 0x000043E4 File Offset: 0x000025E4
		// (remove) Token: 0x06000031 RID: 49 RVA: 0x0000451C File Offset: 0x0000271C
		public event global::System.ComponentModel.ProgressChangedEventHandler ProgressChanged
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
				global::System.ComponentModel.ProgressChangedEventHandler progressChangedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.ProgressChangedEventHandler progressChangedEventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (progressChangedEventHandler == progressChangedEventHandler2)
						{
							goto IL_111;
						}
						goto IL_63;
					case 2:
					{
						num2 = (short)1758855168;
						short num3 = num2;
						goto IL_63;
					}
					}
					goto IL_1C;
					IL_63:
					progressChangedEventHandler2 = progressChangedEventHandler;
					global::System.ComponentModel.ProgressChangedEventHandler value2 = (global::System.ComponentModel.ProgressChangedEventHandler)global::System.Delegate.Combine(progressChangedEventHandler2, value);
					progressChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.ProgressChangedEventHandler>(ref this.d, value2, progressChangedEventHandler2);
					num2 = (short)926875649;
					if (num2 != 0)
					{
					}
					num2 = (short)958400505;
					short num4 = num2;
					num2 = (short)2144536569;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_111:
						num2 = (short)261226496;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
						num2 = (short)202899456;
						if (num2 != 0)
						{
						}
						num2 = (short)257949697;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				return;
				IL_1C:
				progressChangedEventHandler = this.d;
				num2 = (short)1488191490;
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
				short num2;
				global::System.ComponentModel.ProgressChangedEventHandler progressChangedEventHandler;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.ProgressChangedEventHandler progressChangedEventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						num2 = (short)2074345473;
						if (num2 != 0)
						{
						}
						if (progressChangedEventHandler == progressChangedEventHandler2)
						{
							goto IL_112;
						}
						goto IL_64;
					case 2:
					{
						num2 = (short)989528064;
						short num3 = num2;
						goto IL_64;
					}
					}
					goto IL_1C;
					IL_64:
					progressChangedEventHandler2 = progressChangedEventHandler;
					global::System.ComponentModel.ProgressChangedEventHandler value2 = (global::System.ComponentModel.ProgressChangedEventHandler)global::System.Delegate.Remove(progressChangedEventHandler2, value);
					progressChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.ProgressChangedEventHandler>(ref this.d, value2, progressChangedEventHandler2);
					num2 = (short)1694818678;
					short num4 = num2;
					num2 = (short)402186614;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_112:
						num2 = (short)699400192;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
						num2 = (short)2050883584;
						if (num2 != 0)
						{
						}
						num2 = (short)542441473;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				return;
				IL_1C:
				progressChangedEventHandler = this.d;
				num2 = (short)290586626;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000032 RID: 50 RVA: 0x00004658 File Offset: 0x00002858
		// (remove) Token: 0x06000033 RID: 51 RVA: 0x00004790 File Offset: 0x00002990
		public event global::System.ComponentModel.RunWorkerCompletedEventHandler RunWorkerCompleted
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
				global::System.ComponentModel.RunWorkerCompletedEventHandler runWorkerCompletedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.RunWorkerCompletedEventHandler runWorkerCompletedEventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (runWorkerCompletedEventHandler == runWorkerCompletedEventHandler2)
						{
							goto IL_110;
						}
						goto IL_64;
					case 2:
					{
						num2 = (short)1827799040;
						short num3 = num2;
						goto IL_64;
					}
					}
					goto IL_1C;
					IL_64:
					runWorkerCompletedEventHandler2 = runWorkerCompletedEventHandler;
					global::System.ComponentModel.RunWorkerCompletedEventHandler value2 = (global::System.ComponentModel.RunWorkerCompletedEventHandler)global::System.Delegate.Combine(runWorkerCompletedEventHandler2, value);
					runWorkerCompletedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.RunWorkerCompletedEventHandler>(ref this.e, value2, runWorkerCompletedEventHandler2);
					num2 = (short)977900286;
					short num4 = num2;
					num2 = (short)379491070;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_110:
						num2 = (short)2046558208;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
						num2 = (short)1990328321;
						if (num2 != 0)
						{
						}
						num2 = (short)795803648;
						if (num2 != 0)
						{
						}
						num2 = (short)632684545;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				return;
				IL_1C:
				runWorkerCompletedEventHandler = this.e;
				num2 = (short)1698693122;
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
				global::System.ComponentModel.RunWorkerCompletedEventHandler runWorkerCompletedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.RunWorkerCompletedEventHandler runWorkerCompletedEventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (runWorkerCompletedEventHandler == runWorkerCompletedEventHandler2)
						{
							goto IL_110;
						}
						goto IL_62;
					case 2:
					{
						num2 = (short)1531707392;
						short num3 = num2;
						goto IL_62;
					}
					}
					goto IL_1C;
					IL_62:
					num2 = (short)1028849665;
					if (num2 != 0)
					{
					}
					runWorkerCompletedEventHandler2 = runWorkerCompletedEventHandler;
					global::System.ComponentModel.RunWorkerCompletedEventHandler value2 = (global::System.ComponentModel.RunWorkerCompletedEventHandler)global::System.Delegate.Remove(runWorkerCompletedEventHandler2, value);
					runWorkerCompletedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.RunWorkerCompletedEventHandler>(ref this.e, value2, runWorkerCompletedEventHandler2);
					num2 = (short)2040464268;
					short num4 = num2;
					num2 = (short)1597506444;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_110:
						num2 = (short)390332416;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
						num2 = (short)1894383616;
						if (num2 != 0)
						{
						}
						num2 = (short)1184956417;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				return;
				IL_1C:
				runWorkerCompletedEventHandler = this.e;
				num2 = (short)252051458;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000048C8 File Offset: 0x00002AC8
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00004978 File Offset: 0x00002B78
		public global::System.Guid JobContainerGuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1162446568;
				short num2 = num;
				num = (short)1651148520;
				switch (num2 == num)
				{
				}
				num = (short)1434124289;
				if (num != 0)
				{
				}
				num = (short)1449394176;
				if (num != 0)
				{
				}
				num = (short)294453248;
				short num3 = num;
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)229293467;
				short num2 = num;
				num = (short)670678427;
				switch (num2 == num)
				{
				}
				num = (short)1791098881;
				if (num != 0)
				{
				}
				num = (short)333447168;
				if (num != 0)
				{
				}
				num = (short)46596096;
				short num3 = num;
				this.f = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00004A28 File Offset: 0x00002C28
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00004AD8 File Offset: 0x00002CD8
		public global::System.DateTime CreatedTime
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1099363384;
				short num2 = num;
				num = (short)1045560;
				switch (num2 == num)
				{
				}
				num = (short)304414721;
				if (num != 0)
				{
				}
				num = (short)2025914368;
				if (num != 0)
				{
				}
				num = (short)1710227456;
				short num3 = num;
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1564599079;
				short num2 = num;
				num = (short)1658053415;
				switch (num2 == num)
				{
				}
				num = (short)1166475264;
				if (num != 0)
				{
				}
				num = (short)89522177;
				if (num != 0)
				{
				}
				num = (short)1387200512;
				short num3 = num;
				this.g = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000038 RID: 56
		public abstract global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type { get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00004B88 File Offset: 0x00002D88
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00004C38 File Offset: 0x00002E38
		public string Error
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)767865571;
				short num2 = num;
				num = (short)673034979;
				switch (num2 == num)
				{
				}
				num = (short)208928769;
				if (num != 0)
				{
				}
				num = (short)1167261696;
				if (num != 0)
				{
				}
				num = (short)364052480;
				short num3 = num;
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1325763975;
				short num2 = num;
				num = (short)1647152519;
				switch (num2 == num)
				{
				}
				num = (short)1906114561;
				if (num != 0)
				{
				}
				num = (short)1375141888;
				if (num != 0)
				{
				}
				num = (short)1422524416;
				short num3 = num;
				this.h = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00004CEC File Offset: 0x00002EEC
		public global::System.Guid ID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2142696082;
				short num2 = num;
				num = (short)659616402;
				switch (num2 == num)
				{
				}
				num = (short)826540033;
				if (num != 0)
				{
				}
				num = (short)128188416;
				if (num != 0)
				{
				}
				num = (short)31391744;
				short num3 = num;
				return this.i;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003C RID: 60
		public abstract string JobName { get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00004D9C File Offset: 0x00002F9C
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00004E4C File Offset: 0x0000304C
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus Status
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)683208417;
				short num2 = num;
				num = (short)1983377121;
				switch (num2 == num)
				{
				}
				num = (short)1448214528;
				if (num != 0)
				{
				}
				num = (short)390397953;
				if (num != 0)
				{
				}
				num = (short)2066677760;
				short num3 = num;
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)622037335;
				short num2 = num;
				num = (short)551061847;
				switch (num2 == num)
				{
				}
				num = (short)1852243968;
				if (num != 0)
				{
				}
				num = (short)330432513;
				if (num != 0)
				{
				}
				num = (short)1383530496;
				short num3 = num;
				this.j = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00004EFC File Offset: 0x000030FC
		public bool IsBusy
		{
			get
			{
				short num = (short)623884372;
				short num2 = num;
				num = (short)901232724;
				switch (num2 == num)
				{
				}
				num = (short)47579137;
				if (num != 0)
				{
				}
				num = (short)1100087296;
				if (num != 0)
				{
				}
				num = (short)413990912;
				short num3 = num;
				return this.BackGroundWorkerInternal.IsBusy;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00004FB0 File Offset: 0x000031B0
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00005060 File Offset: 0x00003260
		public bool Completed
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1979252737;
				if (num != 0)
				{
				}
				num = (short)415007926;
				short num2 = num;
				num = (short)178554038;
				switch (num2 == num)
				{
				}
				num = (short)237699072;
				if (num != 0)
				{
				}
				num = (short)2061434880;
				short num3 = num;
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1918394845;
				short num2 = num;
				num = (short)1635869149;
				switch (num2 == num)
				{
				}
				num = (short)1929248769;
				if (num != 0)
				{
				}
				num = (short)1538981888;
				if (num != 0)
				{
				}
				num = (short)1303314432;
				short num3 = num;
				this.k = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00005114 File Offset: 0x00003314
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000051C4 File Offset: 0x000033C4
		public string InitializationError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)51038500;
				short num2 = num;
				num = (short)756140324;
				switch (num2 == num)
				{
				}
				num = (short)1302593536;
				if (num != 0)
				{
				}
				num = (short)1504641025;
				if (num != 0)
				{
				}
				num = (short)1442381824;
				short num3 = num;
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1845988596;
				short num2 = num;
				num = (short)907840756;
				switch (num2 == num)
				{
				}
				num = (short)78577665;
				if (num != 0)
				{
				}
				num = (short)1346699264;
				if (num != 0)
				{
				}
				num = (short)2072182784;
				short num3 = num;
				this.l = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00005274 File Offset: 0x00003474
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00005324 File Offset: 0x00003524
		public int TotalItemCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)233256600;
				short num2 = num;
				num = (short)417674904;
				switch (num2 == num)
				{
				}
				num = (short)1266876417;
				if (num != 0)
				{
				}
				num = (short)1928003584;
				if (num != 0)
				{
				}
				num = (short)31981568;
				short num3 = num;
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)1568247070;
				short num2 = num;
				num = (short)204639518;
				switch (num2 == num)
				{
				}
				num = (short)1065287681;
				if (num != 0)
				{
				}
				num = (short)581566464;
				if (num != 0)
				{
				}
				num = (short)1851326464;
				short num3 = num;
				this.m = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000053D4 File Offset: 0x000035D4
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00005480 File Offset: 0x00003680
		public int CurrentItemIndex
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)517205923;
				short num2 = num;
				num = (short)349106083;
				switch (num2 == num)
				{
				}
				num = (short)2127036417;
				if (num != 0)
				{
				}
				num = (short)296878080;
				if (num != 0)
				{
				}
				num = (short)1777991680;
				short num3 = num;
				return this.n;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)759763971;
				short num2 = num;
				num = (short)237507587;
				switch (num2 == num)
				{
				}
				num = (short)107282433;
				if (num != 0)
				{
				}
				num = (short)2024407040;
				if (num != 0)
				{
				}
				num = (short)1537998848;
				short num3 = num;
				this.n = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00005530 File Offset: 0x00003730
		public virtual bool IsSafe
		{
			get
			{
				short num = (short)1582542026;
				short num2 = num;
				num = (short)1637919946;
				switch (num2 == num)
				{
				}
				num = (short)1674313729;
				if (num != 0)
				{
				}
				num = (short)1971781632;
				if (num != 0)
				{
				}
				num = (short)1257504768;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000055DC File Offset: 0x000037DC
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00005690 File Offset: 0x00003890
		public bool IsVisible
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1628383391;
				short num2 = num;
				num = (short)1840720031;
				switch (num2 == num)
				{
				}
				num = (short)340262913;
				if (num != 0)
				{
				}
				num = (short)400097280;
				if (num != 0)
				{
				}
				num = (short)1703411712;
				short num3 = num;
				return this.o;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)728891393;
				if (num != 0)
				{
				}
				num = (short)910307502;
				short num2 = num;
				num = (short)1923690670;
				switch (num2 == num)
				{
				}
				num = (short)549060608;
				if (num != 0)
				{
				}
				num = (short)1594556416;
				short num3 = num;
				this.o = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00005740 File Offset: 0x00003940
		// (set) Token: 0x0600004C RID: 76 RVA: 0x000057F0 File Offset: 0x000039F0
		protected global::System.Collections.Generic.IList<T> SelectedItems
		{
			get
			{
				short num = (short)821872504;
				short num2 = num;
				num = (short)1556465528;
				switch (num2 == num)
				{
				}
				num = (short)1569783809;
				if (num != 0)
				{
				}
				num = (short)1217396736;
				if (num != 0)
				{
				}
				num = (short)270598144;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)1468858370;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1442906113;
					if (num != 0)
					{
					}
					num = (short)799866880;
					short num3 = num;
					global::System.Collections.Generic.IEnumerator<T> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)405340167;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									T t;
									this.c.Add(t);
									num = (short)688259072;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase;
									if (uimodelBase == null)
									{
										num = (short)1076035585;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.c.Add((T)((object)uimodelBase.Clone()));
									num = (short)1381367813;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_21D;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)323158022;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									T t = enumerator.Current;
									global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase = t as global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase;
									num = (short)765788162;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1523777539;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_130;
									}
									continue;
								}
								IL_175:
								num = (short)293863428;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_130:
								goto IL_175;
							}
							IL_21D:
							goto IL_2C0;
						}
						finally
						{
							num = (short)193265664;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_253;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1171718146;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_287;
								}
								IL_253:
								if (enumerator == null)
								{
									break;
								}
								num = (short)576061441;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_287:;
						}
						goto IL_28A;
					case 1:
					{
						num = (short)1255698524;
						short num4 = num;
						num = (short)1576497244;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15;
						default:
							goto IL_D2;
						}
						break;
					}
					case 2:
						goto IL_15;
					}
					goto IL_83;
					IL_15:
					switch (0)
					{
					case 0:
						IL_83:
						if (value != null)
						{
							goto IL_28A;
						}
						num = (short)1372389377;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_28A:
					this.c = new global::System.Collections.Generic.List<T>();
					enumerator = value.GetEnumerator();
					num = (short)8323072;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D2:
				num = (short)1407254528;
				if (num != 0)
				{
				}
				this.c = null;
				return;
				IL_2C0:
				this.TotalItemCount = this.c.Count;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00005AEC File Offset: 0x00003CEC
		protected global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService LocalService
		{
			get
			{
				short num = (short)546897920;
				short num2 = num;
				num = (short)94497643;
				short num3 = num;
				num = (short)1513089899;
				switch (num3 == num)
				{
				}
				num = (short)1137508353;
				if (num != 0)
				{
				}
				num = (short)1173487616;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00005BA0 File Offset: 0x00003DA0
		protected global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory ValidationServiceFactory
		{
			get
			{
				short num = (short)1003814912;
				short num2 = num;
				num = (short)531731912;
				short num3 = num;
				num = (short)766285256;
				switch (num3 == num)
				{
				}
				num = (short)516751360;
				if (num != 0)
				{
				}
				num = (short)1881931777;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory.Instance;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00005C50 File Offset: 0x00003E50
		protected global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier ViewCacheNotifier
		{
			get
			{
				short num = (short)1975582720;
				short num2 = num;
				num = (short)2076246017;
				if (num != 0)
				{
				}
				num = (short)808160777;
				short num3 = num;
				num = (short)782470665;
				switch (num3 == num)
				{
				}
				num = (short)56950784;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.Instance;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00005D00 File Offset: 0x00003F00
		protected bool CancellationPending
		{
			get
			{
				while (this.BackGroundWorkerInternal != null)
				{
					short num = (short)1025638400;
					short num2 = num;
					num = (short)1104684714;
					short num3 = num;
					num = (short)924067498;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)186580992;
						if (num != 0)
						{
						}
						num = (short)1369767937;
						if (num != 0)
						{
						}
						return this.BackGroundWorkerInternal.CancellationPending;
					}
				}
				return false;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00005DC4 File Offset: 0x00003FC4
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00005E7C File Offset: 0x0000407C
		private global::System.ComponentModel.BackgroundWorker BackGroundWorkerInternal
		{
			get
			{
				short num = (short)296812544;
				short num2 = num;
				num = (short)602097426;
				short num3 = num;
				num = (short)1344292626;
				switch (num3 == num)
				{
				}
				num = (short)238485505;
				if (num != 0)
				{
				}
				num = (short)123404288;
				if (num != 0)
				{
				}
				return this.b as global::System.ComponentModel.BackgroundWorker;
			}
			set
			{
				short num = (short)901709824;
				short num2 = num;
				num = (short)182242452;
				short num3 = num;
				num = (short)656592020;
				switch (num3 == num)
				{
				}
				num = (short)1744240640;
				if (num != 0)
				{
				}
				num = (short)1704656897;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00005F2C File Offset: 0x0000412C
		public void CancelAsync()
		{
			short num = (short)1150353408;
			short num2 = num;
			num = (short)381938067;
			short num3 = num;
			num = (short)469559699;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1710161921;
				if (num != 0)
				{
				}
				num = (short)1285160960;
				if (num != 0)
				{
				}
				object obj = this.a;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_F2;
					}
					int num4;
					for (;;)
					{
						IL_B0:
						switch (num4)
						{
						case 0:
							num = (short)1972371470;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (this.Status != global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.SCHEDULED)
							{
								num = (short)1124990985;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_25F;
						case 2:
							num = (short)1047920644;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (this.Status == global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.RUNNING)
							{
								num = (short)1904738304;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2DB;
						case 4:
							if (this.BackGroundWorkerInternal.WorkerSupportsCancellation)
							{
								num = (short)533528581;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2DB;
						case 5:
							this.BackGroundWorkerInternal.CancelAsync();
							this.Status = global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.CANCELED;
							num = (short)1709899788;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (this.Status != global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.PENDING)
							{
								num = (short)1115947015;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_25F;
						case 7:
							num = (short)1193279489;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_2F3;
						case 9:
							num = (short)970653699;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							if (this.BackGroundWorkerInternal != null)
							{
								num = (short)1804075010;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.Status = global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.CANCELED;
							this.Completed = true;
							global::System.ComponentModel.RunWorkerCompletedEventArgs a_ = new global::System.ComponentModel.RunWorkerCompletedEventArgs(null, null, true);
							this.a(a_);
							num = (short)1096679435;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							goto IL_2DB;
						case 12:
							goto IL_19C;
						case 13:
							goto IL_25F;
						case 14:
							if (this.TotalItemCount - this.CurrentItemIndex > 1)
							{
								num = (short)920190989;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2DB;
						}
						goto IL_F2;
						IL_25F:
						num = (short)160104458;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_2DB:
						num = (short)187039752;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_19C:
					IL_2F3:
					break;
					IL_F2:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)694943750;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_B0;
				}
				finally
				{
					num = (short)553910272;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_326;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)358416386;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_359;
						}
						IL_326:
						if (!flag)
						{
							break;
						}
						num = (short)22282241;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_359:;
				}
				break;
			}
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000062B4 File Offset: 0x000044B4
		public void RunWorkerAsync()
		{
			short num = (short)1189347328;
			short num2 = num;
			num = (short)181834861;
			short num3 = num;
			num = (short)1873646701;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)534904832;
				if (num != 0)
				{
				}
				object obj = this.a;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_9F;
					}
					int num4;
					for (;;)
					{
						IL_89:
						switch (num4)
						{
						case 0:
							this.BackGroundWorkerInternal = this.a();
							this.Status = global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.RUNNING;
							this.BackGroundWorkerInternal.RunWorkerAsync();
							num = (short)1101463554;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							if (this.Status == global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.PENDING)
							{
								num = (short)1663762432;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.Completed = true;
							global::System.ComponentModel.RunWorkerCompletedEventArgs a_ = new global::System.ComponentModel.RunWorkerCompletedEventArgs(null, null, true);
							this.a(a_);
							num = (short)1131872259;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_111;
						case 3:
							goto IL_145;
						}
						goto IL_9F;
					}
					IL_111:
					IL_145:
					break;
					IL_9F:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)724500481;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_89;
				}
				finally
				{
					num = (short)1003421696;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_178;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)528351234;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1AC;
						}
						IL_178:
						if (!flag)
						{
							break;
						}
						num = (short)1732902913;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1AC:;
				}
				break;
			}
			}
			num = (short)1182662657;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000064A8 File Offset: 0x000046A8
		protected void ReportProgress(int currentIdex)
		{
			short num;
			try
			{
				num = (short)813091158;
				short num2 = num;
				num = (short)41208150;
				switch (num2 == num)
				{
				}
				num = (short)1799946240;
				if (num != 0)
				{
				}
				this.CurrentItemIndex = currentIdex;
				string a_ = this.b();
				this.a(currentIdex * 100 / this.SelectedItems.Count, a_);
			}
			catch (global::System.Exception)
			{
			}
			num = (short)2056912896;
			short num3 = num;
			num = (short)1704656897;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000056 RID: 86
		protected abstract void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e);

		// Token: 0x06000057 RID: 87 RVA: 0x0000658C File Offset: 0x0000478C
		protected void CreateFailJob(global::Motorola.Common.CustomException.CommonException exp, string discription)
		{
			short num = (short)94765056;
			short num2 = num;
			num = (short)1080360961;
			if (num != 0)
			{
			}
			num = (short)691396132;
			short num3 = num;
			num = (short)603184676;
			switch (num3 == num)
			{
			}
			num = (short)1016659968;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob
			{
				JobDescription = discription,
				ErrorCode = new int?((int)exp.ErrorCode),
				ErrorMessage = exp.Message,
				JobStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED,
				JobContainerUuid = new global::System.Guid?(this.JobContainerGuid),
				Parameters = ((exp.CommonExceptionData != null) ? global::Motorola.CommonCPS.Common.CommonUtility.JobErrorParameterConverter.ConverterParameterArrayToString(exp.CommonExceptionData.Paramters) : null)
			};
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).AddBatchJob(job);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000066AC File Offset: 0x000048AC
		protected global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer AddBatchJobContainer()
		{
			int a_ = 13;
			short num = (short)1430913024;
			short num2 = num;
			num = (short)1747617242;
			short num3 = num;
			num = (short)923567578;
			global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer batchOperationJobContainer;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)774242305;
				if (num != 0)
				{
				}
				num = (short)694812672;
				if (num != 0)
				{
				}
				batchOperationJobContainer = new global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer
				{
					JobType = this.Type,
					JobsCount = new int?(this.SelectedItems.Count),
					JobName = this.JobName
				};
				try
				{
					batchOperationJobContainer = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).AddBatchJobContainer(batchOperationJobContainer);
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鏑냓닕룙뷛ꫝ菟諡쓣觥飧쫩蛫臭鋯틱音駵雷軹鷻韽滿朁瘃★渇欉攋戍甏瘑⸓㘕", a_) + ex.Message);
					this.InitializationError = ex.Message;
					throw;
				}
				break;
			}
			this.JobContainerGuid = batchOperationJobContainer.Uuid;
			return batchOperationJobContainer;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000067F8 File Offset: 0x000049F8
		private string b()
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					if (this.Error == null)
					{
						return text;
					}
					num2 = (short)455182320;
					short num3 = num2;
					num2 = (short)365594608;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)438632449;
						if (num2 != 0)
						{
						}
						num2 = (short)1946091520;
						if (num2 != 0)
						{
						}
						num2 = (short)299237377;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					text = text + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + this.Error;
					num2 = (short)1199702018;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return text;
				}
				goto IL_25;
			}
			return text;
			IL_25:
			text = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("뛌ￎ곐껔ꓘﯚ닜맞쇠飢ퟤ髦쟨쯪雬\udcee賰", a_), new object[]
			{
				this.Type,
				this.CurrentItemIndex,
				this.TotalItemCount,
				this.Status
			});
			num2 = (short)2073952256;
			short num4 = num2;
			num2 = (short)59310080;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00006990 File Offset: 0x00004B90
		private global::System.ComponentModel.BackgroundWorker a()
		{
			short num = (short)554893312;
			short num2 = num;
			num = (short)1617186684;
			short num3 = num;
			num = (short)1089687420;
			switch (num3 == num)
			{
			}
			num = (short)1889665025;
			if (num != 0)
			{
			}
			num = (short)1537212416;
			if (num != 0)
			{
			}
			global::System.ComponentModel.BackgroundWorker backgroundWorker = new global::System.ComponentModel.BackgroundWorker
			{
				WorkerSupportsCancellation = true,
				WorkerReportsProgress = true
			};
			backgroundWorker.DoWork += this.a;
			backgroundWorker.ProgressChanged += this.a;
			backgroundWorker.RunWorkerCompleted += this.a;
			backgroundWorker.RunWorkerCompleted += delegate(object sender, global::System.ComponentModel.RunWorkerCompletedEventArgs e)
			{
				short num4 = (short)138763596;
				short num5 = num4;
				num4 = (short)2062114124;
				switch (num5 == num4)
				{
				}
				num4 = (short)405995521;
				if (num4 != 0)
				{
				}
				num4 = (short)325058560;
				short num6 = num4;
				num4 = (short)1041629184;
				if (num4 != 0)
				{
				}
				backgroundWorker.Dispose();
			};
			return backgroundWorker;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00006ABC File Offset: 0x00004CBC
		private void a(object A_0, global::System.ComponentModel.DoWorkEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
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
					if (this.CancellationPending)
					{
						return;
					}
					num2 = (short)866776919;
					short num3 = num2;
					num2 = (short)602863447;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E4;
					default:
						num2 = (short)218693632;
						if (num2 != 0)
						{
						}
						num2 = (short)663355398;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).CancelBatchJobContainerByUser(this.JobContainerGuid);
					num2 = (short)1622999048;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (this.CancellationPending)
					{
						num2 = (short)45547523;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E9;
				case 3:
					num2 = (short)1211367429;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_E4;
				case 5:
					if (this.Status == global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.CANCELED)
					{
						num2 = (short)572522496;
						short num4 = num2;
						num2 = (short)640221185;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E9;
				case 6:
					num2 = (short)153288711;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).HasJobFailed(this.JobContainerGuid))
					{
						num2 = (short)1214578692;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 8:
					num2 = (short)493355009;
					if (num2 != 0)
					{
					}
					goto IL_E9;
				case 9:
					return;
				}
				goto IL_38;
				IL_E4:
				this.Status = global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.FAILED;
				num2 = (short)1377632265;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_E9:
				num2 = (short)281935872;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_38:
			this.Measurer = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.StartNew(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.BatchOperation, this.JobName), null);
			this.AddBatchJobContainer();
			this.a(0, null);
			this.OnDoWork(A_1);
			num2 = (short)379060226;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00006D1C File Offset: 0x00004F1C
		private void a(object A_0, global::System.ComponentModel.RunWorkerCompletedEventArgs A_1)
		{
			int a_ = 19;
			short num = (short)188612613;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1578631169;
					if (num != 0)
					{
					}
					goto IL_169;
				case 1:
					goto IL_EB;
				case 2:
					if (this.Status == global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.RUNNING)
					{
						num = (short)962068490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_169;
				case 3:
					this.Status = global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.FAILED;
					num = (short)1275265037;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_169;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 6:
				{
					this.Status = global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.CANCELED;
					num = (short)1554384147;
					short num3 = num;
					num = (short)1111491859;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2E7;
					default:
						num = (short)830668800;
						if (num != 0)
						{
						}
						num = (short)1837694980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					goto IL_169;
				case 8:
					goto IL_195;
				case 9:
					goto IL_EB;
				case 10:
					this.CurrentItemIndex = global::System.Math.Max(this.TotalItemCount, this.CurrentItemIndex);
					this.Status = global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.PERFORMED;
					num = (short)384303104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (A_1.Error != null)
					{
						num = (short)143392771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1121124354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					this.Error = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID((A_1.Error as global::Motorola.Common.CustomException.CommonException).ErrorCode.ToString(), null);
					num = (short)104923145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (A_1.Error is global::Motorola.Common.CustomException.CommonException)
					{
						num = (short)1221459980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E7;
				}
				IL_66:
				if (A_1.Cancelled)
				{
					num = (short)1482358790;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)137035787;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EB:
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(A_1.Error, global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("뫗믙꣛뷝裟싡诣雥跧飩跫髭駯鷱髳훵闷鿹駻諽⃿朁瘃琅朇砉", a_));
				num = (short)331218951;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_169:
				this.SelectedItems = null;
				this.Completed = true;
				this.a(A_1);
				num = (short)2035875848;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E7:
				this.Error = A_1.Error.ToString();
				num = (short)1258684416;
				short num4 = num;
				num = (short)1740767233;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_195:
			global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer measurer = this.Measurer;
			if (measurer == null)
			{
				return;
			}
			measurer.Stop();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000706C File Offset: 0x0000526C
		private void a(object A_0, global::System.ComponentModel.ProgressChangedEventArgs A_1)
		{
			short num = (short)1446117376;
			short num2 = num;
			num = (short)1003667796;
			short num3 = num;
			num = (short)1430372692;
			switch (num3 == num)
			{
			}
			num = (short)413794305;
			if (num != 0)
			{
			}
			num = (short)790233088;
			if (num != 0)
			{
			}
			global::System.ComponentModel.ProgressChangedEventHandler progressChangedEventHandler = this.d;
			if (progressChangedEventHandler == null)
			{
				return;
			}
			progressChangedEventHandler(this, A_1);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00007128 File Offset: 0x00005328
		private void a(int A_0, object A_1)
		{
			short num;
			try
			{
				num = (short)2074738688;
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
					{
						num = (short)1768610636;
						short num3 = num;
						num = (short)272882508;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C7;
						default:
							num = (short)260636672;
							if (num != 0)
							{
							}
							num = (short)1719468034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_C7;
					case 3:
						if (!this.BackGroundWorkerInternal.IsBusy)
						{
							num = (short)963051521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.BackGroundWorkerInternal.ReportProgress(A_0, A_1);
						num = (short)1224736773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)65339398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_14C;
					case 6:
						goto IL_125;
					}
					IL_41:
					if (this.BackGroundWorkerInternal == null)
					{
						num = (short)726794244;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1353515011;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_C7:
				IL_125:
				IL_14C:;
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1934622720;
			short num4 = num;
			num = (short)261947393;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000072F4 File Offset: 0x000054F4
		private void a(global::System.ComponentModel.RunWorkerCompletedEventArgs A_0)
		{
			short num = (short)1598357505;
			if (num != 0)
			{
			}
			num = (short)12871530;
			short num2 = num;
			num = (short)111699818;
			switch (num2 == num)
			{
			}
			num = (short)1428357120;
			short num3 = num;
			num = (short)892272640;
			if (num != 0)
			{
			}
			global::System.ComponentModel.RunWorkerCompletedEventHandler runWorkerCompletedEventHandler = this.e;
			if (runWorkerCompletedEventHandler == null)
			{
				return;
			}
			runWorkerCompletedEventHandler(this, A_0);
		}

		// Token: 0x0400000A RID: 10
		protected global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer Measurer;

		// Token: 0x0400000B RID: 11
		private readonly object a = new object();

		// Token: 0x0400000C RID: 12
		private object b;

		// Token: 0x0400000D RID: 13
		private global::System.Collections.Generic.IList<T> c;

		// Token: 0x0400000E RID: 14
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.ProgressChangedEventHandler d;

		// Token: 0x0400000F RID: 15
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.RunWorkerCompletedEventHandler e;

		// Token: 0x04000010 RID: 16
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Guid f;

		// Token: 0x04000011 RID: 17
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.DateTime g;

		// Token: 0x04000012 RID: 18
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string h;

		// Token: 0x04000013 RID: 19
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::System.Guid i;

		// Token: 0x04000014 RID: 20
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus j;

		// Token: 0x04000015 RID: 21
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool k;

		// Token: 0x04000016 RID: 22
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string l;

		// Token: 0x04000017 RID: 23
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int m;

		// Token: 0x04000018 RID: 24
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int n;

		// Token: 0x04000019 RID: 25
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool o;
	}
}
