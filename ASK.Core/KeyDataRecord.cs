using System;

namespace ASK.Core
{
	// Token: 0x0200001E RID: 30
	[global::System.Serializable]
	public class KeyDataRecord : global::ASK.Core.IKeyDataRecord
	{
		// Token: 0x0600013E RID: 318 RVA: 0x00024D20 File Offset: 0x00022F20
		public KeyDataRecord(byte uKeyType, int sysID, global::ASK.Core.AccessRecord acclvl)
		{
			this.m_keyType = uKeyType;
			this.id = sysID;
			this.m_Accesslevel = acclvl;
			if (acclvl != null)
			{
				this.uForiegnKey = (byte)acclvl.ID;
			}
			this.m_packedData = new byte[5];
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00024D68 File Offset: 0x00022F68
		public KeyDataRecord(byte uKeyType, int sysID, byte uFKey)
		{
			this.m_keyType = uKeyType;
			this.id = sysID;
			this.m_Accesslevel = null;
			this.uForiegnKey = uFKey;
			this.m_packedData = new byte[5];
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00024DA4 File Offset: 0x00022FA4
		internal KeyDataRecord(byte A_0, byte[] A_1, byte A_2, bool A_3)
		{
			this.m_keyType = A_0;
			this.uForiegnKey = A_2;
			this.bOTAPState = A_3;
			this.m_Accesslevel = null;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00024DD4 File Offset: 0x00022FD4
		public static int GetAccessLevelType(byte[] pResult)
		{
			switch (0)
			{
			case 0:
				goto IL_7C;
			}
			int num;
			short num2;
			int num4;
			int num5;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_206;
				case 1:
					goto IL_41F;
				case 2:
					num2 = (short)815005711;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_41F;
				case 4:
				{
					num2 = (short)241762304;
					short num3 = num2;
					if (num4 != 10)
					{
						num2 = (short)939589648;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DF;
				}
				case 5:
					num5 = 0;
					num2 = (short)831455249;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num5 = 1;
					num2 = (short)1661272077;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)94896139;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num5 = 2;
					num2 = (short)1125711890;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)1687683091;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (num4 >= pResult.Length)
					{
						num2 = (short)434372608;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)182190084;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (pResult[num4] != 255)
					{
						num2 = (short)915603479;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DF;
				case 12:
					if (num4 == 3)
					{
						num2 = (short)1546518554;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2FA;
				case 13:
					return num5;
				case 14:
					if (num4 != 3)
					{
						num2 = (short)362741767;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DF;
				case 15:
					if (pResult[num4] != 255)
					{
						num2 = (short)600440837;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2FA;
				case 16:
					num2 = (short)1295319052;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					goto IL_206;
				case 18:
					return num5;
				case 19:
					if (pResult[10] == 247)
					{
						num2 = (short)742588424;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1756626965;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (num5 != 0)
					{
						num2 = (short)940900361;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return num5;
				case 21:
				{
					num2 = (short)208708154;
					short num6 = num2;
					num2 = (short)438542906;
					switch ((num6 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_206;
					default:
						num2 = (short)70909952;
						if (num2 != 0)
						{
						}
						if (pResult[10] == 255)
						{
							num2 = (short)320405510;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num5 = 0;
						num2 = (short)1157627928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 22:
					goto IL_206;
				case 23:
					num2 = (short)1910112257;
					if (num2 != 0)
					{
					}
					num5 = 0;
					num2 = (short)373555222;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					return num5;
				case 25:
					if (pResult[num4] != 239)
					{
						num2 = (short)334233602;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2FA;
				case 26:
					num2 = (short)342884377;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_7C;
				IL_DF:
				num4++;
				num2 = (short)1513291777;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_206:
				num2 = (short)1974927380;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2FA:
				num2 = (short)1076822030;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_41F:
				num2 = (short)2009595914;
				num = (int)((global::System.IntPtr)num2);
			}
			return num5;
			IL_7C:
			num5 = 1;
			num4 = 0;
			num2 = (short)1249837059;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00025240 File Offset: 0x00023440
		private void a()
		{
			short num = (short)707133440;
			short num2 = num;
			num = (short)1809135041;
			short num3 = num;
			num = (short)329463233;
			switch (num3 == num)
			{
			}
			num = (short)961544192;
			if (num != 0)
			{
			}
			num = (short)1952579585;
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
			global::ASK.Core.Global.a(this.m_packedData, null, null);
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00025368 File Offset: 0x00023568
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00025418 File Offset: 0x00023618
		public byte KeyType
		{
			get
			{
				short num = (short)1915486208;
				short num2 = num;
				num = (short)955067754;
				short num3 = num;
				num = (short)1552952682;
				switch (num3 == num)
				{
				}
				num = (short)1842610177;
				if (num != 0)
				{
				}
				num = (short)1550581760;
				if (num != 0)
				{
				}
				return this.m_keyType;
			}
			set
			{
				short num = (short)1698693120;
				short num2 = num;
				num = (short)513379103;
				short num3 = num;
				num = (short)1517849375;
				switch (num3 == num)
				{
				}
				num = (short)2080309249;
				if (num != 0)
				{
				}
				num = (short)276561920;
				if (num != 0)
				{
				}
				this.m_keyType = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000254C8 File Offset: 0x000236C8
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00025578 File Offset: 0x00023778
		public int SystemID
		{
			get
			{
				short num = (short)277741568;
				short num2 = num;
				num = (short)36069371;
				short num3 = num;
				num = (short)1957388283;
				switch (num3 == num)
				{
				}
				num = (short)507838465;
				if (num != 0)
				{
				}
				num = (short)248446976;
				if (num != 0)
				{
				}
				return this.id;
			}
			set
			{
				short num = (short)1286012928;
				short num2 = num;
				num = (short)1945745342;
				short num3 = num;
				num = (short)76593086;
				switch (num3 == num)
				{
				}
				num = (short)1669529601;
				if (num != 0)
				{
				}
				num = (short)1107361792;
				if (num != 0)
				{
				}
				this.id = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00025624 File Offset: 0x00023824
		// (set) Token: 0x06000148 RID: 328 RVA: 0x000256D4 File Offset: 0x000238D4
		public byte ForiegnKey
		{
			get
			{
				short num = (short)1779695616;
				short num2 = num;
				num = (short)602029623;
				short num3 = num;
				num = (short)1673543223;
				switch (num3 == num)
				{
				}
				num = (short)1592262657;
				if (num != 0)
				{
				}
				num = (short)1066532864;
				if (num != 0)
				{
				}
				return this.uForiegnKey;
			}
			set
			{
				short num = (short)406650880;
				short num2 = num;
				num = (short)235245350;
				short num3 = num;
				num = (short)788959014;
				switch (num3 == num)
				{
				}
				num = (short)2006384640;
				if (num != 0)
				{
				}
				num = (short)111476737;
				if (num != 0)
				{
				}
				this.uForiegnKey = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00025784 File Offset: 0x00023984
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00025838 File Offset: 0x00023A38
		public bool OTAPState
		{
			get
			{
				short num = (short)1876230144;
				short num2 = num;
				num = (short)1843658753;
				if (num != 0)
				{
				}
				num = (short)1276226461;
				short num3 = num;
				num = (short)877964189;
				switch (num3 == num)
				{
				}
				num = (short)625082368;
				if (num != 0)
				{
				}
				return this.bOTAPState;
			}
			set
			{
				short num = (short)544276480;
				short num2 = num;
				num = (short)941131877;
				short num3 = num;
				num = (short)1151109221;
				switch (num3 == num)
				{
				}
				num = (short)2101215233;
				if (num != 0)
				{
				}
				num = (short)1469382656;
				if (num != 0)
				{
				}
				this.bOTAPState = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600014B RID: 331 RVA: 0x000258EC File Offset: 0x00023AEC
		// (set) Token: 0x0600014C RID: 332 RVA: 0x0002599C File Offset: 0x00023B9C
		public bool Editable
		{
			get
			{
				short num = (short)1618870272;
				short num2 = num;
				num = (short)439091201;
				if (num != 0)
				{
				}
				num = (short)1408589497;
				short num3 = num;
				num = (short)26828473;
				switch (num3 == num)
				{
				}
				num = (short)679739392;
				if (num != 0)
				{
				}
				return this.bEditable;
			}
			set
			{
				short num = (short)691273728;
				short num2 = num;
				num = (short)1753901502;
				short num3 = num;
				num = (short)1308715454;
				switch (num3 == num)
				{
				}
				num = (short)861011969;
				if (num != 0)
				{
				}
				num = (short)1841168384;
				if (num != 0)
				{
				}
				this.bEditable = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00025A4C File Offset: 0x00023C4C
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00025AFC File Offset: 0x00023CFC
		public bool IsSelected
		{
			get
			{
				short num = (short)1846083584;
				short num2 = num;
				num = (short)368795406;
				short num3 = num;
				num = (short)1187143438;
				switch (num3 == num)
				{
				}
				num = (short)1068433409;
				if (num != 0)
				{
				}
				num = (short)476250112;
				if (num != 0)
				{
				}
				return this.bSeleceted;
			}
			set
			{
				short num = (short)958922752;
				short num2 = num;
				num = (short)2009801344;
				short num3 = num;
				num = (short)2014716544;
				switch (num3 == num)
				{
				}
				num = (short)1415577601;
				if (num != 0)
				{
				}
				num = (short)1698889728;
				if (num != 0)
				{
				}
				this.bSeleceted = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00025BAC File Offset: 0x00023DAC
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00025C5C File Offset: 0x00023E5C
		public global::ASK.Core.AccessRecord AccessLevel
		{
			get
			{
				short num = (short)1780678656;
				short num2 = num;
				num = (short)1947645617;
				short num3 = num;
				num = (short)597931697;
				switch (num3 == num)
				{
				}
				num = (short)563740672;
				if (num != 0)
				{
				}
				num = (short)677183489;
				if (num != 0)
				{
				}
				return this.m_Accesslevel;
			}
			set
			{
				short num = (short)1963065344;
				short num2 = num;
				num = (short)514344827;
				short num3 = num;
				num = (short)422135675;
				switch (num3 == num)
				{
				}
				num = (short)676986881;
				if (num != 0)
				{
				}
				num = (short)1109983232;
				if (num != 0)
				{
				}
				this.m_Accesslevel = value;
			}
		}

		// Token: 0x040000A7 RID: 167
		private byte m_keyType;

		// Token: 0x040000A8 RID: 168
		private int id;

		// Token: 0x040000A9 RID: 169
		private bool bOTAPState;

		// Token: 0x040000AA RID: 170
		private bool bEditable;

		// Token: 0x040000AB RID: 171
		private bool bSeleceted;

		// Token: 0x040000AC RID: 172
		private byte uForiegnKey;

		// Token: 0x040000AD RID: 173
		private global::ASK.Core.AccessRecord m_Accesslevel;

		// Token: 0x040000AE RID: 174
		private byte[] m_packedData;
	}
}
