using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200008C RID: 140
	[global::System.Serializable]
	public class RPVersionInfo : global::System.ICloneable
	{
		// Token: 0x0600036A RID: 874 RVA: 0x0003B03C File Offset: 0x0003923C
		public RPVersionInfo()
		{
			this._protocolVer = global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_UNKNOWN;
			this._terminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			this._portableCPChanged = false;
			this._mobileCHCPChanged = false;
			this._mobileTransCPChanged = false;
			this._portableFwVer = 0;
			this._mobileCHFwVer = 0;
			this._mobileTransFwVer = 0;
			this._opResult = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0003B090 File Offset: 0x00039290
		// (set) Token: 0x0600036C RID: 876 RVA: 0x0003B144 File Offset: 0x00039344
		public global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion ProtocolVersion
		{
			get
			{
				short num = (short)1473567215;
				short num2 = num;
				num = (short)225434095;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1338048512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1014824960;
				if (num != 0)
				{
				}
				num = (short)1482358785;
				if (num != 0)
				{
				}
				return this._protocolVer;
			}
			set
			{
				short num = (short)361982458;
				short num2 = num;
				num = (short)481454586;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1526202368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1269825537;
				if (num != 0)
				{
				}
				num = (short)1134493696;
				if (num != 0)
				{
				}
				this._protocolVer = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0003B1F4 File Offset: 0x000393F4
		// (set) Token: 0x0600036E RID: 878 RVA: 0x0003B2A8 File Offset: 0x000394A8
		public global::Motorola.Common.Communication.CommonUtil.RPTerminalType TerminalType
		{
			get
			{
				short num = (short)1601905507;
				short num2 = num;
				num = (short)1674453859;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1342177280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1022754817;
				if (num != 0)
				{
				}
				num = (short)892076032;
				if (num != 0)
				{
				}
				return this._terminalType;
			}
			set
			{
				short num = (short)1260080028;
				short num2 = num;
				num = (short)1790725020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1873936384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1240268800;
				if (num != 0)
				{
				}
				num = (short)1204420609;
				if (num != 0)
				{
				}
				this._terminalType = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0003B358 File Offset: 0x00039558
		// (set) Token: 0x06000370 RID: 880 RVA: 0x0003B408 File Offset: 0x00039608
		public bool PortableCPChanged
		{
			get
			{
				short num = (short)1006478591;
				short num2 = num;
				num = (short)1715250431;
				switch (num2 == num)
				{
				default:
				{
					num = (short)745209856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2145058817;
				if (num != 0)
				{
				}
				num = (short)462749696;
				if (num != 0)
				{
				}
				return this._portableCPChanged;
			}
			set
			{
				short num = (short)452540199;
				short num2 = num;
				num = (short)1873032999;
				switch (num2 == num)
				{
				default:
				{
					num = (short)351928320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1691615233;
				if (num != 0)
				{
				}
				num = (short)1114439680;
				if (num != 0)
				{
				}
				this._portableCPChanged = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000371 RID: 881 RVA: 0x0003B4B8 File Offset: 0x000396B8
		// (set) Token: 0x06000372 RID: 882 RVA: 0x0003B568 File Offset: 0x00039768
		public bool MobileControlHeadCPChanged
		{
			get
			{
				short num = (short)1629271081;
				short num2 = num;
				num = (short)1886762025;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1345191936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)874577920;
				if (num != 0)
				{
				}
				num = (short)1992228865;
				if (num != 0)
				{
				}
				return this._mobileCHCPChanged;
			}
			set
			{
				short num = (short)1936889003;
				short num2 = num;
				num = (short)1716425899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)68616192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2144075777;
				if (num != 0)
				{
				}
				num = (short)461570048;
				if (num != 0)
				{
				}
				this._mobileCHCPChanged = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000373 RID: 883 RVA: 0x0003B618 File Offset: 0x00039818
		// (set) Token: 0x06000374 RID: 884 RVA: 0x0003B6C8 File Offset: 0x000398C8
		public bool MobileTransCPChanged
		{
			get
			{
				short num = (short)197644265;
				short num2 = num;
				num = (short)783405033;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1443233792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1577451521;
				if (num != 0)
				{
				}
				num = (short)261226496;
				if (num != 0)
				{
				}
				return this._mobileTransCPChanged;
			}
			set
			{
				short num = (short)1901260439;
				short num2 = num;
				num = (short)1481961111;
				switch (num2 == num)
				{
				default:
				{
					num = (short)704708608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1904410625;
				if (num != 0)
				{
				}
				num = (short)1396113408;
				if (num != 0)
				{
				}
				this._mobileTransCPChanged = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0003B778 File Offset: 0x00039978
		// (set) Token: 0x06000376 RID: 886 RVA: 0x0003B828 File Offset: 0x00039A28
		public ushort PortableFwVersion
		{
			get
			{
				short num = (short)1734284913;
				short num2 = num;
				num = (short)319952497;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1424359424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)565968896;
				if (num != 0)
				{
				}
				num = (short)43384833;
				if (num != 0)
				{
				}
				return this._portableFwVer;
			}
			set
			{
				short num = (short)1222705153;
				if (num != 0)
				{
				}
				num = (short)1795489792;
				short num2 = num;
				num = (short)121528229;
				short num3 = num;
				num = (short)87908261;
				switch (num3 == num)
				{
				}
				num = (short)993722368;
				if (num != 0)
				{
				}
				this._portableFwVer = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0003B8DC File Offset: 0x00039ADC
		// (set) Token: 0x06000378 RID: 888 RVA: 0x0003B98C File Offset: 0x00039B8C
		public ushort MobileControlHeadFwVersion
		{
			get
			{
				short num = (short)1284273297;
				short num2 = num;
				num = (short)1308193937;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2078539776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1143799809;
				if (num != 0)
				{
				}
				num = (short)986841088;
				if (num != 0)
				{
				}
				return this._mobileCHFwVer;
			}
			set
			{
				short num = (short)1162297010;
				short num2 = num;
				num = (short)329531058;
				switch (num2 == num)
				{
				default:
				{
					num = (short)431751168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1951203329;
				if (num != 0)
				{
				}
				num = (short)1976631296;
				if (num != 0)
				{
				}
				this._mobileCHFwVer = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0003BA3C File Offset: 0x00039C3C
		// (set) Token: 0x0600037A RID: 890 RVA: 0x0003BAEC File Offset: 0x00039CEC
		public ushort MobileTransFwVersion
		{
			get
			{
				short num = (short)60615943;
				short num2 = num;
				num = (short)1087040775;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1559887872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2045640704;
				if (num != 0)
				{
				}
				num = (short)39976961;
				if (num != 0)
				{
				}
				return this._mobileTransFwVer;
			}
			set
			{
				short num = (short)2045061746;
				short num2 = num;
				num = (short)541731442;
				switch (num2 == num)
				{
				}
				num = (short)196542465;
				if (num != 0)
				{
				}
				num = (short)1296826368;
				short num3 = num;
				num = (short)683016192;
				if (num != 0)
				{
				}
				this._mobileTransFwVer = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0003BB9C File Offset: 0x00039D9C
		// (set) Token: 0x0600037C RID: 892 RVA: 0x0003BC4C File Offset: 0x00039E4C
		public byte[] FlashPacket
		{
			get
			{
				short num = (short)1866269747;
				short num2 = num;
				num = (short)514327603;
				switch (num2 == num)
				{
				}
				num = (short)686817281;
				if (num != 0)
				{
				}
				num = (short)1596129280;
				short num3 = num;
				num = (short)866516992;
				if (num != 0)
				{
				}
				return this._falshPacket;
			}
			set
			{
				short num = (short)244598507;
				short num2 = num;
				num = (short)1752188651;
				switch (num2 == num)
				{
				}
				num = (short)795148288;
				if (num != 0)
				{
				}
				num = (short)830144512;
				short num3 = num;
				num = (short)1741946881;
				if (num != 0)
				{
				}
				this._falshPacket = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600037D RID: 893 RVA: 0x0003BCFC File Offset: 0x00039EFC
		// (set) Token: 0x0600037E RID: 894 RVA: 0x0003BDAC File Offset: 0x00039FAC
		public int FlashPacketNumber
		{
			get
			{
				short num = (short)1174821329;
				short num2 = num;
				num = (short)2040617425;
				switch (num2 == num)
				{
				}
				num = (short)1515192320;
				if (num != 0)
				{
				}
				num = (short)116195328;
				short num3 = num;
				num = (short)81395713;
				if (num != 0)
				{
				}
				return this._flashPacketNum;
			}
			set
			{
				short num = (short)1057947649;
				if (num != 0)
				{
				}
				num = (short)1750028802;
				short num2 = num;
				num = (short)1647858178;
				switch (num2 == num)
				{
				}
				num = (short)500170752;
				short num3 = num;
				num = (short)26673152;
				if (num != 0)
				{
				}
				this._flashPacketNum = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0003BE60 File Offset: 0x0003A060
		// (set) Token: 0x06000380 RID: 896 RVA: 0x0003BF10 File Offset: 0x0003A110
		public global::Motorola.Common.Communication.CommonUtil.CommRC OperationResult
		{
			get
			{
				short num = (short)1898996430;
				short num2 = num;
				num = (short)1859019470;
				switch (num2 == num)
				{
				}
				num = (short)440467456;
				if (num != 0)
				{
				}
				num = (short)437059584;
				short num3 = num;
				num = (short)1970405377;
				if (num != 0)
				{
				}
				return this._opResult;
			}
			set
			{
				short num = (short)1083850802;
				short num2 = num;
				num = (short)1686585394;
				switch (num2 == num)
				{
				}
				num = (short)1229848577;
				if (num != 0)
				{
				}
				num = (short)342097920;
				short num3 = num;
				num = (short)1586757632;
				if (num != 0)
				{
				}
				this._opResult = value;
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0003BFBC File Offset: 0x0003A1BC
		public object Clone()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.CommonUtil.RPVersionInfo rpversionInfo;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_111;
				case 1:
					if (this.FlashPacket != null)
					{
						goto IL_48;
					}
					goto IL_113;
				case 2:
				{
					num2 = (short)557393095;
					short num3 = num2;
					num2 = (short)1564681415;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_48;
					default:
						num2 = (short)371785729;
						if (num2 != 0)
						{
						}
						num2 = (short)1897988096;
						if (num2 != 0)
						{
						}
						rpversionInfo.FlashPacket = new byte[this.FlashPacket.Length];
						global::System.Array.Copy(this.FlashPacket, rpversionInfo.FlashPacket, this.FlashPacket.Length);
						num2 = (short)225378304;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
				IL_48:
				num2 = (short)879165442;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_111:
			IL_113:
			num2 = (short)1416495104;
			short num4 = num2;
			rpversionInfo.FlashPacketNumber = this.FlashPacketNumber;
			rpversionInfo.MobileTransFwVersion = this.MobileTransFwVersion;
			rpversionInfo.MobileControlHeadFwVersion = this.MobileControlHeadFwVersion;
			rpversionInfo.PortableFwVersion = this.PortableFwVersion;
			rpversionInfo.MobileTransCPChanged = this.MobileTransCPChanged;
			rpversionInfo.MobileControlHeadCPChanged = this.MobileControlHeadCPChanged;
			rpversionInfo.PortableCPChanged = this.PortableCPChanged;
			rpversionInfo.TerminalType = this.TerminalType;
			rpversionInfo.ProtocolVersion = this.ProtocolVersion;
			rpversionInfo.OperationResult = this.OperationResult;
			return rpversionInfo;
			IL_1C:
			rpversionInfo = (base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.RPVersionInfo);
			num2 = (short)681574401;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000476 RID: 1142
		private global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion _protocolVer;

		// Token: 0x04000477 RID: 1143
		private global::Motorola.Common.Communication.CommonUtil.RPTerminalType _terminalType;

		// Token: 0x04000478 RID: 1144
		private bool _portableCPChanged;

		// Token: 0x04000479 RID: 1145
		private bool _mobileCHCPChanged;

		// Token: 0x0400047A RID: 1146
		private bool _mobileTransCPChanged;

		// Token: 0x0400047B RID: 1147
		private ushort _portableFwVer;

		// Token: 0x0400047C RID: 1148
		private ushort _mobileCHFwVer;

		// Token: 0x0400047D RID: 1149
		private ushort _mobileTransFwVer;

		// Token: 0x0400047E RID: 1150
		private byte[] _falshPacket;

		// Token: 0x0400047F RID: 1151
		private int _flashPacketNum;

		// Token: 0x04000480 RID: 1152
		private global::Motorola.Common.Communication.CommonUtil.CommRC _opResult;
	}
}
