using System;
using ASK.Core;
using ASK.Interface;
using Motorola.CommonCPS.ResourceRepository;

namespace ASKLib
{
	// Token: 0x0200000C RID: 12
	public class SystemKeyData : global::ASK.Interface.ISystemKeyData
	{
		// Token: 0x06000046 RID: 70 RVA: 0x0000AF74 File Offset: 0x00009174
		public SystemKeyData(global::ASK.Interface.KeySource src, string serialNum, int id, global::ASK.Interface.KeyType type, bool otapEnabled, bool bWriteProtected, global::ASK.Core.AccessRecord aclvl)
		{
			this.a = serialNum;
			this.b = id;
			this.c = otapEnabled;
			this.d = bWriteProtected;
			this.e = type;
			this.f = aclvl;
			this.g = src;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000AFBC File Offset: 0x000091BC
		public int SystemID
		{
			get
			{
				short num = (short)1766064128;
				short num2 = num;
				num = (short)1852134459;
				short num3 = num;
				num = (short)347755579;
				switch (num3 == num)
				{
				}
				num = (short)1609760769;
				if (num != 0)
				{
				}
				num = (short)1027211264;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000B06C File Offset: 0x0000926C
		public global::ASK.Interface.KeyType Type
		{
			get
			{
				short num = (short)2022834176;
				short num2 = num;
				num = (short)908695650;
				short num3 = num;
				num = (short)730830946;
				switch (num3 == num)
				{
				}
				num = (short)65601537;
				if (num != 0)
				{
				}
				num = (short)502988800;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000B11C File Offset: 0x0000931C
		public bool OtapEnabled
		{
			get
			{
				short num = (short)1974730752;
				short num2 = num;
				num = (short)1351861754;
				short num3 = num;
				num = (short)145606138;
				switch (num3 == num)
				{
				}
				num = (short)1502871552;
				if (num != 0)
				{
				}
				num = (short)1473183745;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000B1CC File Offset: 0x000093CC
		public bool WriteProtectEnabled
		{
			get
			{
				short num = (short)1886781440;
				short num2 = num;
				num = (short)1589175477;
				short num3 = num;
				num = (short)312534197;
				switch (num3 == num)
				{
				}
				num = (short)308477952;
				if (num != 0)
				{
				}
				num = (short)232128513;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000B27C File Offset: 0x0000947C
		public string iBtnSerialNum
		{
			get
			{
				short num = (short)1845952512;
				short num2 = num;
				num = (short)741195236;
				short num3 = num;
				num = (short)858373604;
				switch (num3 == num)
				{
				}
				num = (short)1378811905;
				if (num != 0)
				{
				}
				num = (short)1056309248;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0000B32C File Offset: 0x0000952C
		public global::ASK.Core.AccessRecord AccessLevel
		{
			get
			{
				short num = (short)1068630016;
				short num2 = num;
				num = (short)1725378222;
				short num3 = num;
				num = (short)2105159342;
				switch (num3 == num)
				{
				}
				num = (short)960167937;
				if (num != 0)
				{
				}
				num = (short)508297216;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000B3D8 File Offset: 0x000095D8
		public global::ASK.Interface.KeyAccessLevelType AccessLevelType
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				short num2;
				global::ASK.Interface.KeyAccessLevelType result;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						if (this.g == global::ASK.Interface.KeySource.LEGACY_KEY_FILE)
						{
							goto IL_BB;
						}
						num2 = (short)69009413;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
					{
						num2 = (short)2056912896;
						short num3 = num2;
						result = this.AccessLevel.GetKeyAccessLevelType();
						num2 = (short)843644930;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						goto IL_124;
					case 3:
						result = global::ASK.Interface.KeyAccessLevelType.UNLM_ACC;
						num2 = (short)1453326340;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						goto IL_17B;
					case 5:
						if (this.AccessLevel != null)
						{
							num2 = (short)1202782209;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_17D;
					}
					goto IL_28;
				}
				IL_124:
				IL_17B:
				return result;
				IL_17D:
				throw new global::System.Exception(global::Motorola.CommonCPS.ResourceRepository.Resources.RMSU_Error_Retrieve_Access_Level_Type);
				IL_28:
				result = global::ASK.Interface.KeyAccessLevelType.LIMITED_ACC;
				num2 = (short)109901420;
				short num4 = num2;
				num2 = (short)1830090348;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_BB:
					num2 = (short)839122947;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				default:
				{
					num2 = (short)437911553;
					if (num2 != 0)
					{
					}
					num2 = (short)23134208;
					if (num2 != 0)
					{
					}
					num2 = (short)698482688;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0000B570 File Offset: 0x00009770
		public global::ASK.Interface.KeySource Source
		{
			get
			{
				short num = (short)1364459520;
				short num2 = num;
				num = (short)1471558594;
				short num3 = num;
				num = (short)579220418;
				switch (num3 == num)
				{
				}
				num = (short)117243905;
				if (num != 0)
				{
				}
				num = (short)1542848512;
				if (num != 0)
				{
				}
				return this.g;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000B620 File Offset: 0x00009820
		public string SystemIDHex
		{
			get
			{
				int a_ = 15;
				short num = (short)1665204224;
				short num2 = num;
				num = (short)1136101401;
				short num3 = num;
				num = (short)1674217497;
				switch (num3 == num)
				{
				}
				num = (short)1915158529;
				if (num != 0)
				{
				}
				num = (short)914554880;
				if (num != 0)
				{
				}
				return this.b.ToString(global::ASKLib.SystemKeyManager.b("볣", a_));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0000B6E8 File Offset: 0x000098E8
		public string UuId
		{
			get
			{
				short num = (short)1433665536;
				short num2 = num;
				num = (short)1521156770;
				short num3 = num;
				num = (short)1344930466;
				switch (num3 == num)
				{
				}
				num = (short)354156544;
				if (num != 0)
				{
				}
				num = (short)1477640193;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x04000023 RID: 35
		private string a;

		// Token: 0x04000024 RID: 36
		private int b;

		// Token: 0x04000025 RID: 37
		private bool c;

		// Token: 0x04000026 RID: 38
		private bool d;

		// Token: 0x04000027 RID: 39
		private global::ASK.Interface.KeyType e;

		// Token: 0x04000028 RID: 40
		private global::ASK.Core.AccessRecord f;

		// Token: 0x04000029 RID: 41
		private global::ASK.Interface.KeySource g;
	}
}
