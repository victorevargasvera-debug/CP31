using System;

namespace SpecialFeatures.Security
{
	// Token: 0x02000057 RID: 87
	public class TrkSysBandPlan
	{
		// Token: 0x06000836 RID: 2102 RVA: 0x00002906 File Offset: 0x00000B06
		public TrkSysBandPlan(int sysType, int sysId, bool shuffledBandPlan)
		{
			this.a = sysType;
			this.b = sysId;
			this.c = shuffledBandPlan;
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x00087D58 File Offset: 0x00085F58
		internal int SystemType
		{
			get
			{
				short num = (short)1301885256;
				short num2 = num;
				num = (short)616968520;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1978007552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)586678273;
				if (num != 0)
				{
				}
				num = (short)338624512;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x00087E08 File Offset: 0x00086008
		internal int SystemId
		{
			get
			{
				short num = (short)1432855583;
				short num2 = num;
				num = (short)63218719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1331625984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1982464001;
				if (num != 0)
				{
				}
				num = (short)193724416;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00087EB8 File Offset: 0x000860B8
		internal bool ShuffledBandPlan
		{
			get
			{
				short num = (short)282787841;
				if (num != 0)
				{
				}
				num = (short)1763835904;
				short num2 = num;
				num = (short)509675834;
				short num3 = num;
				num = (short)401344826;
				switch (num3 == num)
				{
				}
				num = (short)287571968;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x04000331 RID: 817
		private int a;

		// Token: 0x04000332 RID: 818
		private int b;

		// Token: 0x04000333 RID: 819
		private bool c;
	}
}
