using System;

namespace AcpASKLib
{
	// Token: 0x0200002C RID: 44
	[global::System.Serializable]
	public class KeyDataRecord : global::AcpASKLib.IKeyDataRecord
	{
		// Token: 0x0600013D RID: 317 RVA: 0x00023958 File Offset: 0x00021B58
		internal KeyDataRecord(byte A_0, int A_1, global::AcpASKLib.AccessRecord A_2)
		{
			this.m_keyType = A_0;
			this.id = A_1;
			this.m_Accesslevel = A_2;
			if (A_2 != null)
			{
				this.uForiegnKey = (byte)A_2.ID;
			}
			this.m_packedData = new byte[5];
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000239A0 File Offset: 0x00021BA0
		internal KeyDataRecord(byte A_0, int A_1, byte A_2)
		{
			this.m_keyType = A_0;
			this.id = A_1;
			this.m_Accesslevel = null;
			this.uForiegnKey = A_2;
			this.m_packedData = new byte[5];
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000239DC File Offset: 0x00021BDC
		internal KeyDataRecord(byte A_0, byte[] A_1, byte A_2, bool A_3)
		{
			this.m_keyType = A_0;
			this.uForiegnKey = A_2;
			this.bOTAPState = A_3;
			this.m_Accesslevel = null;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00023A0C File Offset: 0x00021C0C
		internal static int a(byte[] A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_7C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				int num3;
				switch (num)
				{
				case 0:
					goto IL_22E;
				case 1:
					num2 = (short)1062010890;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (num3 == 3)
					{
						num2 = (short)1349648385;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_347;
				case 3:
				{
					int num4 = 0;
					num2 = (short)314114048;
					short num5 = num2;
					num2 = (short)1942749205;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					int num4;
					return num4;
				}
				case 5:
					if (A_0[num3] != 255)
					{
						num2 = (short)1584726019;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_151;
				case 6:
					if (num3 != 3)
					{
						num2 = (short)49545236;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_151;
				case 7:
					if (A_0[num3] != 255)
					{
						num2 = (short)1434714124;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_347;
				case 8:
					num2 = (short)1333985299;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					if (A_0[10] == 255)
					{
						num2 = (short)1791164433;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					int num4 = 0;
					num2 = (short)1623392260;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					if (A_0[num3] != 239)
					{
						num2 = (short)1929445401;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_347;
				case 11:
					goto IL_22E;
				case 12:
				{
					int num4 = 0;
					num2 = (short)1049886731;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
				{
					int num4;
					return num4;
				}
				case 14:
				{
					int num4;
					if (num4 != 0)
					{
						num2 = (short)1283981320;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return num4;
				}
				case 15:
				{
					int num4;
					return num4;
				}
				case 16:
					goto IL_41E;
				case 17:
					goto IL_1EE;
				case 18:
					goto IL_41E;
				case 19:
					if (A_0[10] == 247)
					{
						num2 = (short)945422360;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)440664073;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					num2 = (short)211550213;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					goto IL_22E;
				case 22:
					if (num3 >= A_0.Length)
					{
						num2 = (short)1399980032;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1234829338;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					num2 = (short)560332802;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
				{
					num2 = (short)163250177;
					if (num2 != 0)
					{
					}
					int num4 = 2;
					num2 = (short)1293221901;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 25:
					num2 = (short)737411079;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					if (num3 != 10)
					{
						num2 = (short)1301020695;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_151;
				}
				goto IL_7C;
				IL_151:
				num3++;
				num2 = (short)61603856;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_22E:
				num2 = (short)1653014542;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_347:
				num2 = (short)1519648774;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_41E:
				num2 = (short)1228996630;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1EE:
			goto IL_30B;
			IL_7C:
			num2 = (short)1504413397;
			short num6 = num2;
			num2 = (short)185501397;
			switch ((num6 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_30B:
				int num4 = 1;
				num2 = (short)50003983;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)420937728;
				if (num2 != 0)
				{
				}
				int num4 = 1;
				int num3 = 0;
				num2 = (short)1115029522;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00023E78 File Offset: 0x00022078
		private void a()
		{
			short num = (short)1243953841;
			short num2 = num;
			num = (short)1617181361;
			switch (num2 == num)
			{
			}
			num = (short)1457848320;
			if (num != 0)
			{
			}
			num = (short)1114112;
			short num3 = num;
			num = (short)1705508865;
			if (num != 0)
			{
			}
			int num4 = 0;
			byte b = (byte)(this.m_keyType << 4);
			byte b2 = (byte)(this.id >> 16);
			b2 |= b;
			this.m_packedData[num4++] = b2;
			b2 = (byte)(this.id >> 8);
			this.m_packedData[num4++] = b2;
			b2 = (byte)this.id;
			this.m_packedData[num4++] = b2;
			b2 = (byte)this.m_Accesslevel.ID;
			this.m_packedData[num4++] = b2;
			global::AcpASKLib.Global.a(this.m_packedData, null, null);
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00023F9C File Offset: 0x0002219C
		// (set) Token: 0x06000143 RID: 323 RVA: 0x0002404C File Offset: 0x0002224C
		public byte KeyType
		{
			get
			{
				short num = (short)1025540432;
				short num2 = num;
				num = (short)1895924048;
				switch (num2 == num)
				{
				}
				num = (short)1473576960;
				if (num != 0)
				{
				}
				num = (short)1418592256;
				short num3 = num;
				num = (short)688783361;
				if (num != 0)
				{
				}
				return this.m_keyType;
			}
			set
			{
				short num = (short)163193743;
				short num2 = num;
				num = (short)741024655;
				switch (num2 == num)
				{
				}
				num = (short)1038876673;
				if (num != 0)
				{
				}
				num = (short)1724973056;
				short num3 = num;
				num = (short)831455232;
				if (num != 0)
				{
				}
				this.m_keyType = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000240FC File Offset: 0x000222FC
		// (set) Token: 0x06000145 RID: 325 RVA: 0x000241AC File Offset: 0x000223AC
		public int SystemID
		{
			get
			{
				short num = (short)1674549362;
				short num2 = num;
				num = (short)265721970;
				switch (num2 == num)
				{
				}
				num = (short)2069299201;
				if (num != 0)
				{
				}
				num = (short)117178368;
				short num3 = num;
				num = (short)80216064;
				if (num != 0)
				{
				}
				return this.id;
			}
			set
			{
				short num = (short)637111405;
				short num2 = num;
				num = (short)691309677;
				switch (num2 == num)
				{
				}
				num = (short)2057633793;
				if (num != 0)
				{
				}
				num = (short)1591869440;
				short num3 = num;
				num = (short)224985088;
				if (num != 0)
				{
				}
				this.id = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0002425C File Offset: 0x0002245C
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0002430C File Offset: 0x0002250C
		internal byte ForiegnKey
		{
			get
			{
				short num = (short)165718374;
				short num2 = num;
				num = (short)1531816294;
				switch (num2 == num)
				{
				}
				num = (short)1779367936;
				if (num != 0)
				{
				}
				num = (short)328400896;
				short num3 = num;
				num = (short)900726785;
				if (num != 0)
				{
				}
				return this.uForiegnKey;
			}
			set
			{
				short num = (short)900302449;
				short num2 = num;
				num = (short)526616177;
				switch (num2 == num)
				{
				}
				num = (short)1852440576;
				if (num != 0)
				{
				}
				num = (short)206438400;
				short num3 = num;
				num = (short)255328257;
				if (num != 0)
				{
				}
				this.uForiegnKey = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000243BC File Offset: 0x000225BC
		// (set) Token: 0x06000149 RID: 329 RVA: 0x0002446C File Offset: 0x0002266C
		internal bool OTAPState
		{
			get
			{
				short num = (short)481449603;
				short num2 = num;
				num = (short)1852921475;
				switch (num2 == num)
				{
				}
				num = (short)401604609;
				if (num != 0)
				{
				}
				num = (short)571342848;
				short num3 = num;
				num = (short)1491402752;
				if (num != 0)
				{
				}
				return this.bOTAPState;
			}
			set
			{
				short num = (short)936145921;
				short num2 = num;
				num = (short)1810985985;
				switch (num2 == num)
				{
				}
				num = (short)1606221825;
				if (num != 0)
				{
				}
				num = (short)1888813056;
				short num3 = num;
				num = (short)1377304576;
				if (num != 0)
				{
				}
				this.bOTAPState = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00024520 File Offset: 0x00022720
		// (set) Token: 0x0600014B RID: 331 RVA: 0x000245D0 File Offset: 0x000227D0
		public bool Editable
		{
			get
			{
				short num = (short)298367875;
				short num2 = num;
				num = (short)607501187;
				switch (num2 == num)
				{
				}
				num = (short)293142529;
				if (num != 0)
				{
				}
				num = (short)1410334720;
				short num3 = num;
				num = (short)573374464;
				if (num != 0)
				{
				}
				return this.bEditable;
			}
			set
			{
				short num = (short)1262448362;
				short num2 = num;
				num = (short)1433759466;
				switch (num2 == num)
				{
				}
				num = (short)1869086721;
				if (num != 0)
				{
				}
				num = (short)460259328;
				short num3 = num;
				num = (short)1595539456;
				if (num != 0)
				{
				}
				this.bEditable = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00024680 File Offset: 0x00022880
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00024730 File Offset: 0x00022930
		public bool IsSelected
		{
			get
			{
				short num = (short)921180212;
				short num2 = num;
				num = (short)518461492;
				switch (num2 == num)
				{
				}
				num = (short)276824065;
				if (num != 0)
				{
				}
				num = (short)1221525504;
				short num3 = num;
				num = (short)1337524224;
				if (num != 0)
				{
				}
				return this.bSeleceted;
			}
			set
			{
				short num = (short)482713211;
				short num2 = num;
				num = (short)1350278779;
				switch (num2 == num)
				{
				}
				num = (short)1359872000;
				if (num != 0)
				{
				}
				num = (short)1173159936;
				short num3 = num;
				num = (short)2146631681;
				if (num != 0)
				{
				}
				this.bSeleceted = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600014E RID: 334 RVA: 0x000247E4 File Offset: 0x000229E4
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00024894 File Offset: 0x00022A94
		public global::AcpASKLib.AccessRecord AccessLevel
		{
			get
			{
				short num = (short)474742785;
				if (num != 0)
				{
				}
				num = (short)404574782;
				short num2 = num;
				num = (short)495407678;
				switch (num2 == num)
				{
				}
				num = (short)108068864;
				short num3 = num;
				num = (short)1560870912;
				if (num != 0)
				{
				}
				return this.m_Accesslevel;
			}
			set
			{
				short num = (short)11505796;
				short num2 = num;
				num = (short)1801752708;
				switch (num2 == num)
				{
				}
				num = (short)1513095169;
				if (num != 0)
				{
				}
				num = (short)869466112;
				short num3 = num;
				num = (short)2122514432;
				if (num != 0)
				{
				}
				this.m_Accesslevel = value;
			}
		}

		// Token: 0x04000190 RID: 400
		private byte m_keyType;

		// Token: 0x04000191 RID: 401
		private int id;

		// Token: 0x04000192 RID: 402
		private bool bOTAPState;

		// Token: 0x04000193 RID: 403
		private bool bEditable;

		// Token: 0x04000194 RID: 404
		private bool bSeleceted;

		// Token: 0x04000195 RID: 405
		private byte uForiegnKey;

		// Token: 0x04000196 RID: 406
		private global::AcpASKLib.AccessRecord m_Accesslevel;

		// Token: 0x04000197 RID: 407
		private byte[] m_packedData;
	}
}
