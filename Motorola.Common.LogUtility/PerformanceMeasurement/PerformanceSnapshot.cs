using System;
using System.Runtime.CompilerServices;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x02000031 RID: 49
	internal class PerformanceSnapshot
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00016BC8 File Offset: 0x00014DC8
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00016C74 File Offset: 0x00014E74
		public byte? SystemCpuAvailablePercentage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1379598337;
				if (num != 0)
				{
				}
				num = (short)1305956028;
				short num2 = num;
				num = (short)408899260;
				switch (num2 == num)
				{
				}
				num = (short)709951488;
				if (num != 0)
				{
				}
				num = (short)1297088512;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2004722951;
				short num2 = num;
				num = (short)1783604487;
				switch (num2 == num)
				{
				}
				num = (short)49807361;
				if (num != 0)
				{
				}
				num = (short)1820524544;
				if (num != 0)
				{
				}
				num = (short)82903040;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00016D28 File Offset: 0x00014F28
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00016DD8 File Offset: 0x00014FD8
		public ushort SystemMemoryAvailableMb
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1063675507;
				short num2 = num;
				num = (short)1570596467;
				switch (num2 == num)
				{
				}
				num = (short)1442250752;
				if (num != 0)
				{
				}
				num = (short)59768833;
				if (num != 0)
				{
				}
				num = (short)106823680;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)852174158;
				short num2 = num;
				num = (short)715662670;
				switch (num2 == num)
				{
				}
				num = (short)1232011265;
				if (num != 0)
				{
				}
				num = (short)1176829952;
				if (num != 0)
				{
				}
				num = (short)1578565632;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00016E88 File Offset: 0x00015088
		public string SystemInfo
		{
			get
			{
				int a_ = 10;
				string text;
				for (;;)
				{
					IL_09:
					switch (0)
					{
					case 0:
						goto IL_25;
					}
					int num;
					short num2;
					byte? systemCpuAvailablePercentage;
					for (;;)
					{
						IL_13:
						switch (num)
						{
						case 0:
							goto IL_150;
						case 1:
						{
							num2 = (short)1370698980;
							short num3 = num2;
							num2 = (short)2145989860;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							case 1:
								break;
							default:
							{
								num2 = (short)1490485248;
								short num4 = num2;
								break;
							}
							}
							num2 = (short)1792868352;
							if (num2 != 0)
							{
							}
							systemCpuAvailablePercentage = this.SystemCpuAvailablePercentage;
							text = systemCpuAvailablePercentage.ToString() + global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("筝", a_);
							num2 = (short)1361313792;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						case 2:
							num2 = (short)1416691713;
							if (num2 != 0)
							{
							}
							if (systemCpuAvailablePercentage != null)
							{
								num2 = (short)2055012353;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_152;
						}
						break;
					}
					IL_25:
					text = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ၝşⱡ", a_);
					systemCpuAvailablePercentage = this.SystemCpuAvailablePercentage;
					num2 = (short)274137090;
					num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				IL_150:
				IL_152:
				return string.Concat(new string[]
				{
					global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᵝた㝡䑣❥ṧ୩իɭᅯၱᡳ፵䉷婹", a_),
					text,
					global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("敝䁟⽡ţ୥ݧᡩᕫ乭ㅯѱᕳήᑷ᭹ṻችꊁ", a_),
					this.SystemMemoryAvailableMb.ToString(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ၝ偟", a_), global::Motorola.Common.LogUtility.PredefinedName.DefaultCulture),
					global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("繝ⵟ⁡", a_)
				});
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00017050 File Offset: 0x00015250
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00017100 File Offset: 0x00015300
		public uint CpuTimeMs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1068040193;
				if (num != 0)
				{
				}
				num = (short)1767414983;
				short num2 = num;
				num = (short)644324551;
				switch (num2 == num)
				{
				default:
				{
					num = (short)327548928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1659699200;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)176201865;
				short num2 = num;
				num = (short)1198039177;
				switch (num2 == num)
				{
				}
				num = (short)752746496;
				short num3 = num;
				num = (short)818610177;
				if (num != 0)
				{
				}
				num = (short)962068480;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000171B0 File Offset: 0x000153B0
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00017264 File Offset: 0x00015464
		public uint KernelCpuTimeMs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)452385854;
				short num2 = num;
				num = (short)762633278;
				switch (num2 == num)
				{
				}
				num = (short)1568276480;
				short num3 = num;
				num = (short)81723393;
				if (num != 0)
				{
				}
				num = (short)844234752;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)798593326;
				short num2 = num;
				num = (short)1758236974;
				switch (num2 == num)
				{
				}
				num = (short)685965312;
				short num3 = num;
				num = (short)1964310529;
				if (num != 0)
				{
				}
				num = (short)1305083904;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00017314 File Offset: 0x00015514
		// (set) Token: 0x06000189 RID: 393 RVA: 0x000173C8 File Offset: 0x000155C8
		public uint UserCpuTimeMs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)769475643;
				short num2 = num;
				num = (short)1422345275;
				switch (num2 == num)
				{
				}
				num = (short)25886720;
				short num3 = num;
				num = (short)711131137;
				if (num != 0)
				{
				}
				num = (short)177471488;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1275593653;
				short num2 = num;
				num = (short)261030837;
				switch (num2 == num)
				{
				}
				num = (short)78577664;
				short num3 = num;
				num = (short)600178689;
				if (num != 0)
				{
				}
				num = (short)1745223680;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0001747C File Offset: 0x0001567C
		// (set) Token: 0x0600018B RID: 395 RVA: 0x0001752C File Offset: 0x0001572C
		public ushort MemoryMb
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)808255489;
				if (num != 0)
				{
				}
				num = (short)1227365941;
				short num2 = num;
				num = (short)583409205;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1324023808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1634205696;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1531383529;
				short num2 = num;
				num = (short)341642985;
				switch (num2 == num)
				{
				}
				num = (short)99483648;
				short num3 = num;
				num = (short)1295056897;
				if (num != 0)
				{
				}
				num = (short)483459072;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000175DC File Offset: 0x000157DC
		// (set) Token: 0x0600018D RID: 397 RVA: 0x0001768C File Offset: 0x0001588C
		public ushort MemoryPeakMb
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)816910321;
				short num2 = num;
				num = (short)1595084785;
				switch (num2 == num)
				{
				}
				num = (short)333119488;
				short num3 = num;
				num = (short)929038337;
				if (num != 0)
				{
				}
				num = (short)817364992;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)847302424;
				short num2 = num;
				num = (short)772984600;
				switch (num2 == num)
				{
				}
				num = (short)1508769792;
				short num3 = num;
				num = (short)90374145;
				if (num != 0)
				{
				}
				num = (short)1360986112;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x040000D5 RID: 213
		public readonly global::System.DateTime TimeStamp = global::System.DateTime.Now;

		// Token: 0x040000D6 RID: 214
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte? a;

		// Token: 0x040000D7 RID: 215
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private ushort b;

		// Token: 0x040000D8 RID: 216
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private uint c;

		// Token: 0x040000D9 RID: 217
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private uint d;

		// Token: 0x040000DA RID: 218
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private uint e;

		// Token: 0x040000DB RID: 219
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private ushort f;

		// Token: 0x040000DC RID: 220
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private ushort g;
	}
}
