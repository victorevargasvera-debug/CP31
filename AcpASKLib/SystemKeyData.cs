using System;

namespace AcpASKLib
{
	// Token: 0x02000038 RID: 56
	public class SystemKeyData
	{
		// Token: 0x0600017A RID: 378 RVA: 0x00029300 File Offset: 0x00027500
		public SystemKeyData(global::AcpASKLib.KeySource src, string serialNum, int id, global::AcpASKLib.KeyType type, bool otapEnabled, bool bWriteProtected, global::AcpASKLib.AccessRecord aclvl)
		{
			this.a = serialNum;
			this.b = id;
			this.c = otapEnabled;
			this.d = bWriteProtected;
			this.e = type;
			this.f = aclvl;
			this.g = src;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00029348 File Offset: 0x00027548
		public int SystemID
		{
			get
			{
				short num = (short)1506338089;
				short num2 = num;
				num = (short)704374057;
				switch (num2 == num)
				{
				}
				num = (short)641859584;
				short num3 = num;
				num = (short)1994915841;
				if (num != 0)
				{
				}
				num = (short)382730240;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000293F8 File Offset: 0x000275F8
		public global::AcpASKLib.KeyType Type
		{
			get
			{
				short num = (short)1432292341;
				short num2 = num;
				num = (short)789253109;
				switch (num2 == num)
				{
				}
				num = (short)1224409088;
				short num3 = num;
				num = (short)918421505;
				if (num != 0)
				{
				}
				num = (short)417660928;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600017D RID: 381 RVA: 0x000294A4 File Offset: 0x000276A4
		public bool OtapEnabled
		{
			get
			{
				short num = (short)2050230540;
				short num2 = num;
				num = (short)168560908;
				switch (num2 == num)
				{
				}
				num = (short)786628608;
				if (num != 0)
				{
				}
				num = (short)2096300032;
				short num3 = num;
				num = (short)1925382145;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00029554 File Offset: 0x00027754
		public bool WriteProtectEnabled
		{
			get
			{
				short num = (short)1049284265;
				short num2 = num;
				num = (short)1141427881;
				switch (num2 == num)
				{
				}
				num = (short)852754432;
				if (num != 0)
				{
				}
				num = (short)468647936;
				short num3 = num;
				num = (short)1183711233;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00029604 File Offset: 0x00027804
		public string iBtnSerialNum
		{
			get
			{
				short num = (short)1180062233;
				short num2 = num;
				num = (short)718098969;
				switch (num2 == num)
				{
				}
				num = (short)2068119553;
				if (num != 0)
				{
				}
				num = (short)1832386560;
				short num3 = num;
				num = (short)1270087680;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000180 RID: 384 RVA: 0x000296B4 File Offset: 0x000278B4
		public global::AcpASKLib.AccessRecord AccessLevel
		{
			get
			{
				short num = (short)1365829338;
				short num2 = num;
				num = (short)1944053466;
				switch (num2 == num)
				{
				}
				num = (short)282984448;
				if (num != 0)
				{
				}
				num = (short)2021588992;
				short num3 = num;
				num = (short)356253697;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00029764 File Offset: 0x00027964
		public global::AcpASKLib.KeyAccessLevelType AccessLevelType
		{
			get
			{
				int a_ = 1;
				switch (0)
				{
				case 0:
					goto IL_31;
				}
				int num;
				global::AcpASKLib.KeyAccessLevelType result;
				short num2;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						result = global::AcpASKLib.KeyAccessLevelType.UNLM_ACC;
						num2 = (short)141950981;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_6A;
					case 2:
						goto IL_B5;
					case 3:
					{
						if (this.AccessLevel == null)
						{
							goto IL_189;
						}
						num2 = (short)378832083;
						short num3 = num2;
						num2 = (short)1046512851;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6A;
						default:
						{
							num2 = (short)1988624384;
							if (num2 != 0)
							{
							}
							num2 = (short)1212547072;
							short num4 = num2;
							num2 = (short)794624001;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 4:
						if (this.g == global::AcpASKLib.KeySource.LEGACY_KEY_FILE)
						{
							num2 = (short)425197568;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1364787203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						goto IL_187;
					}
					goto IL_31;
					IL_6A:
					result = this.AccessLevel.GetKeyAccessLevelType();
					num2 = (short)1475215361;
					if (num2 != 0)
					{
					}
					num2 = (short)1522728962;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_B5:
				IL_187:
				return result;
				IL_189:
				throw new global::System.Exception(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ᵝཟᝡࡣɥ䡧ѩͫᩭ偯qᅳɵ੷፹᥻ࡽꊁ얃ﾋﶍ\udc8f캙얟莡蒣쮧즩즫\uddad쎯ﺱ톳삵\uddb7횹鲻킽꾿뛁ꋅ귇곉ꗋꃍ뗏뛑냕럗꣙ﳛꫝ裟诡韣웥믧鏩鿫髭闯鿱퓳뷵鷷菹", a_));
				IL_31:
				result = global::AcpASKLib.KeyAccessLevelType.LIMITED_ACC;
				num2 = (short)645660676;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00029910 File Offset: 0x00027B10
		public global::AcpASKLib.KeySource Source
		{
			get
			{
				short num = (short)288358401;
				if (num != 0)
				{
				}
				num = (short)2125491590;
				short num2 = num;
				num = (short)1254518150;
				switch (num2 == num)
				{
				}
				num = (short)1627586560;
				short num3 = num;
				num = (short)386007040;
				if (num != 0)
				{
				}
				return this.g;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000299BC File Offset: 0x00027BBC
		public string SystemIDHex
		{
			get
			{
				int a_ = 15;
				short num = (short)185589216;
				short num2 = num;
				num = (short)1635114464;
				switch (num2 == num)
				{
				}
				num = (short)1030422529;
				if (num != 0)
				{
				}
				num = (short)2037055488;
				short num3 = num;
				num = (short)1153433600;
				if (num != 0)
				{
				}
				return this.b.ToString(global::AcpASKLib.SystemKeyLoadedEventArgs.b("㑫", a_));
			}
		}

		// Token: 0x040001C2 RID: 450
		private string a;

		// Token: 0x040001C3 RID: 451
		private int b;

		// Token: 0x040001C4 RID: 452
		private bool c;

		// Token: 0x040001C5 RID: 453
		private bool d;

		// Token: 0x040001C6 RID: 454
		private global::AcpASKLib.KeyType e;

		// Token: 0x040001C7 RID: 455
		private global::AcpASKLib.AccessRecord f;

		// Token: 0x040001C8 RID: 456
		private global::AcpASKLib.KeySource g;
	}
}
