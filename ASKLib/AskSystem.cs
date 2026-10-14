using System;
using ASK.Interface;

namespace ASKLib
{
	// Token: 0x02000009 RID: 9
	public class AskSystem : global::ASK.Interface.IAskSystem
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00003678 File Offset: 0x00001878
		public AskSystem(string systemUuid, string systemRadioName, int systemId, int systemWacnId, int systemradioID, global::ASK.Interface.AskSystemType systemType, global::ASK.Interface.AskSystemSubType systemSubType, global::ASK.Interface.AskTrkSysCoverageType coverageType, bool shuffledBandPlanEnabled, bool expandedMDCIDRangeEnabled)
		{
			this.a = systemUuid;
			this.j = systemRadioName;
			this.b = systemId;
			this.c = systemWacnId;
			this.i = systemradioID;
			this.d = systemType;
			this.e = systemSubType;
			this.f = coverageType;
			this.g = shuffledBandPlanEnabled;
			this.h = expandedMDCIDRangeEnabled;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000036D8 File Offset: 0x000018D8
		public string SystemUuid
		{
			get
			{
				short num = (short)392737879;
				short num2 = num;
				num = (short)90944599;
				switch (num2 == num)
				{
				}
				num = (short)511246336;
				short num3 = num;
				num = (short)997195777;
				if (num != 0)
				{
				}
				num = (short)273416192;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00003788 File Offset: 0x00001988
		public int SystemId
		{
			get
			{
				short num = (short)750747077;
				short num2 = num;
				num = (short)474119621;
				switch (num2 == num)
				{
				}
				num = (short)1932722176;
				short num3 = num;
				num = (short)1050804224;
				if (num != 0)
				{
				}
				num = (short)962199553;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003834 File Offset: 0x00001A34
		public int WacnId
		{
			get
			{
				short num = (short)1216348161;
				if (num != 0)
				{
				}
				num = (short)1667243150;
				short num2 = num;
				num = (short)217128078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1901461504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1469644800;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000038E4 File Offset: 0x00001AE4
		public global::ASK.Interface.AskSystemType SystemType
		{
			get
			{
				short num = (short)313065473;
				if (num != 0)
				{
				}
				num = (short)1454349097;
				short num2 = num;
				num = (short)57776937;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1915551744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)704315392;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003994 File Offset: 0x00001B94
		public global::ASK.Interface.AskSystemSubType SystemSubType
		{
			get
			{
				short num = (short)1761673217;
				if (num != 0)
				{
				}
				num = (short)1283926458;
				short num2 = num;
				num = (short)54536634;
				switch (num2 == num)
				{
				default:
				{
					num = (short)241041408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)837222400;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00003A44 File Offset: 0x00001C44
		public global::ASK.Interface.AskTrkSysCoverageType CoverageType
		{
			get
			{
				short num = (short)1030684673;
				if (num != 0)
				{
				}
				num = (short)912976073;
				short num2 = num;
				num = (short)2035738825;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1037959168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1218641920;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003AF8 File Offset: 0x00001CF8
		public global::ASK.Interface.KeyType SystemKeyType
		{
			get
			{
				short num = (short)689569796;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1438646277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return global::ASK.Interface.KeyType.ADVANCED_CONV_SYSTEM_KEY;
					case 2:
						return global::ASK.Interface.KeyType.ADVANCED_WACN_KEY;
					case 3:
						if (this.d == global::ASK.Interface.AskSystemType.CONVENTIONAL)
						{
							num = (short)1408172033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::ASK.Interface.KeyType.UNDEFINED_KEY;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 5:
						if (this.f == global::ASK.Interface.AskTrkSysCoverageType.IntraWACNRoaming)
						{
							num = (short)607715330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_110;
					}
					IL_3C:
					if (this.d == global::ASK.Interface.AskSystemType.TRUNCKING)
					{
						num = (short)379605125;
						short num3 = num;
						num = (short)424169605;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)447938560;
							if (num != 0)
							{
							}
							num = (short)604897280;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					else
					{
						num = (short)236978177;
						if (num != 0)
						{
						}
						num = (short)228196355;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return global::ASK.Interface.KeyType.ADVANCED_CONV_SYSTEM_KEY;
				IL_110:
				num = (short)351338496;
				short num4 = num;
				return global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003C84 File Offset: 0x00001E84
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00003D34 File Offset: 0x00001F34
		public bool ShuffledBandPlan
		{
			get
			{
				short num = (short)1132174725;
				short num2 = num;
				num = (short)1105239429;
				switch (num2 == num)
				{
				}
				num = (short)69664768;
				short num3 = num;
				num = (short)381550593;
				if (num != 0)
				{
				}
				num = (short)1030619136;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)1772728200;
				short num2 = num;
				num = (short)578858888;
				switch (num2 == num)
				{
				}
				num = (short)1514536960;
				short num3 = num;
				num = (short)1889075201;
				if (num != 0)
				{
				}
				num = (short)102367232;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003DE8 File Offset: 0x00001FE8
		public string Name
		{
			get
			{
				short num = (short)1962593366;
				short num2 = num;
				num = (short)1374211158;
				switch (num2 == num)
				{
				}
				num = (short)1449590784;
				short num3 = num;
				num = (short)749273089;
				if (num != 0)
				{
				}
				num = (short)1596456960;
				if (num != 0)
				{
				}
				return this.j;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003E98 File Offset: 0x00002098
		public int RadioId
		{
			get
			{
				short num = (short)1218247960;
				short num2 = num;
				num = (short)2025520408;
				switch (num2 == num)
				{
				}
				num = (short)408158208;
				short num3 = num;
				num = (short)144834561;
				if (num != 0)
				{
				}
				num = (short)2111176704;
				if (num != 0)
				{
				}
				return this.i;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003F48 File Offset: 0x00002148
		public bool ExpandedMDCIDRange
		{
			get
			{
				short num = (short)353309014;
				short num2 = num;
				num = (short)15339862;
				switch (num2 == num)
				{
				}
				num = (short)882900992;
				short num3 = num;
				num = (short)1932722176;
				if (num != 0)
				{
				}
				num = (short)1382940673;
				if (num != 0)
				{
				}
				return this.h;
			}
		}

		// Token: 0x0400000E RID: 14
		private string a;

		// Token: 0x0400000F RID: 15
		private int b;

		// Token: 0x04000010 RID: 16
		private int c;

		// Token: 0x04000011 RID: 17
		private global::ASK.Interface.AskSystemType d;

		// Token: 0x04000012 RID: 18
		private global::ASK.Interface.AskSystemSubType e;

		// Token: 0x04000013 RID: 19
		private global::ASK.Interface.AskTrkSysCoverageType f;

		// Token: 0x04000014 RID: 20
		private bool g;

		// Token: 0x04000015 RID: 21
		private bool h;

		// Token: 0x04000016 RID: 22
		private int i;

		// Token: 0x04000017 RID: 23
		private string j;
	}
}
