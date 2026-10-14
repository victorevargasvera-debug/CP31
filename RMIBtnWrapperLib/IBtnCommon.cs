using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using AcpCryptoLib;
using AcpUtility;

namespace RMIBtnWrapperLib
{
	// Token: 0x0200000F RID: 15
	public class IBtnCommon
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000021BC File Offset: 0x000003BC
		static IBtnCommon()
		{
			short num = (short)1871639811;
			short num2 = num;
			num = (short)8058115;
			switch (num2 == num)
			{
			}
			num = (short)593690625;
			if (num != 0)
			{
			}
			num = (short)1828192256;
			if (num != 0)
			{
			}
			num = (short)1184301056;
			short num3 = num;
			global::RMIBtnWrapperLib.IBtnCommon.g = new byte[15360];
			global::RMIBtnWrapperLib.IBtnCommon.h = new byte[2];
			global::RMIBtnWrapperLib.IBtnCommon.i = new short[]
			{
				0,
				1,
				1,
				0,
				1,
				0,
				0,
				1,
				1,
				0,
				0,
				1,
				0,
				1,
				1,
				0
			};
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000229C File Offset: 0x0000049C
		public IBtnCommon()
		{
			this.a = 1;
			this.b = 2;
			this.f = new byte[8];
			this.c = 5;
			this.d = true;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022D8 File Offset: 0x000004D8
		public void GetSessionHandle(ref int hSession)
		{
			switch (0)
			{
			case 0:
				goto IL_70;
			}
			int num;
			short num2;
			int[] enhancedOptions;
			for (;;)
			{
				IL_0A:
				int num4;
				switch (num)
				{
				case 0:
					goto IL_17C;
				case 1:
					goto IL_1BD;
				case 2:
					goto IL_11F;
				case 3:
					goto IL_1BD;
				case 4:
					num2 = (short)157876244;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (hSession < 0)
					{
						num2 = (short)1685061634;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					if (hSession != -201)
					{
						num2 = (short)562167821;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_145;
				case 7:
					num2 = (short)625016837;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (hSession <= 0)
					{
						num2 = (short)3670039;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_145;
				case 9:
					return;
				case 10:
				{
					if (hSession <= 0)
					{
						num2 = (short)1576992768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)339605004;
					short num3 = num2;
					num2 = (short)1269560844;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)394199040;
						if (num2 != 0)
						{
						}
						this.d = true;
						num2 = (short)40239113;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 11:
					global::System.Threading.Thread.Sleep(6000);
					hSession = global::RMIBtnWrapperLib.TMEXAPI.TMExtendedStartSession(this.a, this.b, enhancedOptions);
					num2 = (short)2125791240;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (num4 >= (int)this.c)
					{
						num2 = (short)608436243;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					hSession = global::RMIBtnWrapperLib.TMEXAPI.TMExtendedStartSession(this.a, this.b, enhancedOptions);
					num2 = (short)1426522126;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_E3;
				case 14:
					if (hSession <= 0)
					{
						num2 = (short)1700003856;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_145;
				case 15:
					if (global::RMIBtnWrapperLib.TMEXAPI.TMValidSession(hSession) == 1)
					{
						num2 = (short)1949564946;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11F;
				case 16:
				{
					num2 = (short)1205338112;
					short num5 = num2;
					num2 = (short)373489685;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 17:
					if (hSession == 0)
					{
						num2 = (short)1332215812;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E3;
				case 18:
					num2 = (short)1202061313;
					if (num2 != 0)
					{
					}
					num2 = (short)113836054;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					goto IL_145;
				case 20:
					goto IL_145;
				case 21:
					if (hSession == 0)
					{
						num2 = (short)1188298763;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1124925446;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (hSession != 0)
					{
						num2 = (short)1210515463;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11F;
				case 23:
					num2 = (short)821690385;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_70;
				IL_E3:
				num4++;
				num2 = (short)340066307;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_11F:
				global::RMIBtnWrapperLib.TMEXAPI.TMEndSession(hSession);
				hSession = 0;
				num4 = 0;
				num2 = (short)188874753;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_145:
				num2 = (short)563478538;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1BD:
				num2 = (short)1641676812;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_17C:
			global::RMIBtnWrapperLib.TMEXException.a((short)hSession, global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMExtendedStartSession, null);
			return;
			IL_70:
			enhancedOptions = new int[]
			{
				2
			};
			num2 = (short)1179713551;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002718 File Offset: 0x00000918
		public void EndSession(int hSession)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num;
			short num2;
			int num3;
			short num4;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					hSession = 0;
					num2 = (short)1024327684;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (num3 > (int)this.c)
					{
						num2 = (short)762118156;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num4 = global::RMIBtnWrapperLib.TMEXAPI.TMEndSession(hSession);
					num2 = (short)2040922119;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_1B0;
				case 3:
				{
					num2 = (short)169028319;
					short num5 = num2;
					num2 = (short)479079135;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18C;
					default:
						num2 = (short)547160064;
						if (num2 != 0)
						{
						}
						num2 = (short)1381892106;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_76;
				case 5:
					if (num4 == 0)
					{
						num2 = (short)1926823950;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num3++;
					num2 = (short)1244266498;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_1B0;
				case 7:
					goto IL_18C;
				case 8:
					global::RMIBtnWrapperLib.TMEXException.a(num4, global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMEndSession, null);
					num2 = (short)1408630793;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_20D;
				case 10:
					if (num4 != 0)
					{
						num2 = (short)649592840;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					if (1 != num4)
					{
						num2 = (short)1307639811;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 12:
					goto IL_76;
				case 13:
					goto IL_76;
				case 14:
					hSession = 0;
					global::System.Diagnostics.Trace.WriteLine(global::RMIBtnWrapperLib.TMEXException.g("얃ꚅﺇ늑캟芡첣장욧캩삫쮭邯얱햳억颷\udcb9펻쮽꺿ꛁ꓅뷇뻉ꃍ뿏ꋓ럕듗동룛ﻝ鏟蟡韣闥臧藩苫컭釯蛱胳韵鯷鋹駻髽", a_));
					num2 = (short)828309517;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_55;
				IL_76:
				num2 = (short)1152385035;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_18C:
				if (1 == num4)
				{
					num2 = (short)113246208;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				num2 = (short)1606221829;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1B0:
				num2 = (short)492175361;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_20D:
			num2 = (short)1858994177;
			if (num2 != 0)
			{
			}
			num2 = (short)1285881856;
			short num6 = num2;
			return;
			IL_55:
			num4 = 255;
			num3 = 0;
			num2 = (short)414580742;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000029F0 File Offset: 0x00000BF0
		public bool DoTMSetup(int hSession)
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_71;
			}
			int num;
			short num2;
			short num3;
			bool result;
			for (;;)
			{
				IL_13:
				int num5;
				switch (num)
				{
				case 0:
					if (4 == num2)
					{
						num3 = (short)795934728;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_E0;
				case 1:
					if (num2 < 1)
					{
						num3 = (short)742522883;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return result;
				case 2:
					goto IL_15B;
				case 3:
					global::RMIBtnWrapperLib.TMEXException.a(num2, global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMSetup, null);
					num3 = (short)205914131;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 4:
					if (2 == num2)
					{
						num3 = (short)1696071680;
						short num4 = num3;
						num3 = (short)1235550217;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)161415173;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 5:
					if (3 == num2)
					{
						num3 = (short)1339883541;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1139343360;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 6:
					goto IL_E0;
				case 7:
					goto IL_E0;
				case 8:
					global::System.Diagnostics.Trace.WriteLine(global::RMIBtnWrapperLib.TMEXException.g("횄ﶈﺊﶌ꾎ﾐﲒ랖캠톢톤슦춨", a_));
					num3 = (short)396689415;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 9:
					global::System.Diagnostics.Trace.WriteLine(global::RMIBtnWrapperLib.TMEXException.g("횄ﶈﺊﶌ꾎ﺐ떔붜꺞負첤햦첨讪쎬쪮얰쒲\udab4얶트鮺캼ힾ껀뇂뇄ꋆ귈", a_));
					num3 = (short)205127686;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 10:
					if (1 == num2)
					{
						num3 = (short)916193297;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)857145348;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 11:
					if (num5 > (int)this.c)
					{
						num3 = (short)1212219407;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num2 = global::RMIBtnWrapperLib.TMEXAPI.TMSetup(hSession);
					num3 = (short)1898774538;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 12:
					return result;
				case 13:
					if (this.d)
					{
						num3 = (short)144179216;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					result = true;
					num3 = (short)1338048524;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 14:
					goto IL_E0;
				case 15:
					goto IL_15B;
				case 16:
					goto IL_DB;
				case 17:
					result = true;
					this.d = false;
					num3 = (short)703987714;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 18:
					goto IL_1DB;
				case 19:
					return result;
				case 20:
				{
					num3 = (short)795374865;
					short num6 = num3;
					num3 = (short)439055633;
					switch ((num6 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DB;
					default:
						num3 = (short)1059782656;
						if (num3 != 0)
						{
						}
						goto IL_1DB;
					}
					break;
				}
				case 21:
					global::System.Diagnostics.Trace.WriteLine(global::RMIBtnWrapperLib.TMEXException.g("뒄ꪆ\ude88ﾌ놐ﶒ膠잢쪤슦\udaa8讪쎬삮얰鎲킴쾶킸좺즼", a_));
					num3 = (short)207814670;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				goto IL_71;
				IL_DB:
				num5 = 0;
				num3 = (short)1126629396;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_E0:
				num5++;
				num3 = (short)333971474;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_15B:
				num3 = (short)499253249;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1DB:
				num3 = (short)1523122187;
				num = (int)((global::System.IntPtr)num3);
			}
			return result;
			IL_71:
			num3 = (short)452329473;
			if (num3 != 0)
			{
			}
			result = false;
			num2 = 255;
			num3 = (short)1740111885;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002DF0 File Offset: 0x00000FF0
		public void InitMicroLan(int options, byte iBtnFamilyType)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_65;
			}
			int num;
			short num2;
			int num4;
			byte b;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_2C7;
				case 1:
					goto IL_225;
				case 2:
				{
					num2 = (short)2046492672;
					short num3 = num2;
					if (this.a > 15)
					{
						num2 = (short)612761609;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.GetSessionHandle(ref num4);
					num2 = (short)752943111;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (num4 > 0)
					{
						num2 = (short)154730514;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D0;
				case 4:
					goto IL_177;
				case 5:
				{
					this.DoFamilySearchSetup(num4, (short)b);
					num2 = (short)1639841921;
					short num5 = num2;
					num2 = (short)93782145;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B3;
					default:
						num2 = (short)2084175873;
						if (num2 != 0)
						{
						}
						num2 = (short)1044185088;
						if (num2 != 0)
						{
						}
						num2 = (short)736296964;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					this.a += 1;
					num2 = (short)1956577281;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (num4 <= 0)
					{
						num2 = (short)564199430;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_386;
				case 8:
					if (this.f[0] != b)
					{
						num2 = (short)671940622;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_290;
				case 9:
					goto IL_386;
				case 10:
					if (num4 == 0)
					{
						num2 = (short)696647693;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_386;
				case 11:
					goto IL_B3;
				case 12:
					if (this.d)
					{
						num2 = (short)1432551435;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_290;
				case 13:
					this.a = 1;
					num2 = (short)1499463697;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					goto IL_1CB;
				case 15:
					if (b != 255)
					{
						num2 = (short)1921515525;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_177;
				case 16:
					if (num4 > 0)
					{
						num2 = (short)507379712;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 17:
					goto IL_225;
				case 18:
					num2 = (short)1726545932;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_65;
				IL_B3:
				this.DoTMSetup(num4);
				this.d = false;
				num2 = (short)1386741775;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_177:
				this.FindDevice(num4, ref b);
				this.a(num4, out this.f);
				num2 = (short)537919496;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_225:
				num2 = (short)1367998466;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_290:
				num2 = (short)1983709200;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_386:
				num2 = (short)672661507;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1CB:
			throw new global::RMIBtnWrapperLib.TMEXException(global::RMIBtnWrapperLib.TMEXException.g("쮏횑ꖓꚕ얗몙\ud89bﮝ횟쮡잣쎥袧첩쎫\udbad\udeaf횱钳튵ힷ\udfb9쾻麽꺿귁냃ꗇꯉ룋귍룏ꟓꛕ뷗맙뗛룝觟蟡胣웥臧꣩駫髭蓯鷱髳훵黷鯹釻韽泿笁␃爅焇稉椋‍", a_));
			IL_1D0:
			throw new global::RMIBtnWrapperLib.TMEXException(global::RMIBtnWrapperLib.TMEXException.g("풏ꮑ즓뚕춗ﶛﲝ첟잡蒣튥잧誩\udfab\udaad톯삱삳隵\ud9b7骹쾻\udbbd뎿뇁귃꧅ꛇꏋꃍꛑ볓돕꫙돛곝铟쳡", a_));
			IL_2C7:
			this.EndSession(num4);
			num4 = 0;
			return;
			IL_65:
			num4 = 0;
			b = iBtnFamilyType;
			num2 = (short)1021181962;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000031C0 File Offset: 0x000013C0
		public void DoFamilySearchSetup(int hSession, short iBtnFamilyType)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			short num3;
			int num6;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					global::RMIBtnWrapperLib.TMEXException.a(num2, global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMFamilySearchSetup, null);
					num3 = (short)41943044;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					goto IL_94;
				case 2:
					num3 = (short)1242955784;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					if (num2 != 1)
					{
						num3 = (short)2065170434;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_5A;
				case 4:
					return;
				case 5:
					goto IL_1F2;
				case 6:
				{
					num3 = (short)1801417200;
					short num4 = num3;
					num3 = (short)1512862192;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_94;
					default:
					{
						num3 = (short)1296236544;
						if (num3 != 0)
						{
						}
						num3 = (short)1989017600;
						short num5 = num3;
						goto IL_1F2;
					}
					}
					break;
				}
				case 7:
					if (num2 != 1)
					{
						num3 = (short)201261056;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return;
				case 8:
					num3 = (short)1691680769;
					if (num3 != 0)
					{
					}
					if (num2 != 0)
					{
						num3 = (short)1534394369;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_5A;
				case 9:
					if (num6 > (int)this.c)
					{
						num3 = (short)1780744202;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num2 = global::RMIBtnWrapperLib.TMEXAPI.TMFamilySearchSetup(hSession, global::RMIBtnWrapperLib.IBtnCommon.g, iBtnFamilyType);
					num3 = (short)2101805059;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 10:
					goto IL_5A;
				}
				goto IL_3C;
				IL_5A:
				num3 = (short)590348295;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_94:
				num6++;
				num3 = (short)1731788806;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1F2:
				num3 = (short)1393754121;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_3C:
			num2 = 0;
			num6 = 0;
			num3 = (short)1578434565;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003400 File Offset: 0x00001600
		public bool FindDevice(int hSession, ref byte piBtnFamilyType)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_7D;
			}
			int num;
			bool result;
			short num2;
			short num3;
			byte b;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_20D;
				case 1:
					return result;
				case 2:
					if (num2 == 0)
					{
						num3 = (short)291176458;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1138819094;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					return result;
				case 4:
					goto IL_D5;
				case 5:
					num3 = (short)1901592577;
					if (num3 != 0)
					{
					}
					result = true;
					num3 = (short)1439105027;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 6:
					if (this.f[0] == 12)
					{
						num3 = (short)668729348;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_2C8;
				case 7:
					result = true;
					num3 = (short)224264203;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 8:
					return result;
				case 9:
					if (this.f[0] != 4)
					{
						num3 = (short)1489371160;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_D5;
				case 10:
					global::System.Diagnostics.Trace.WriteLine(global::RMIBtnWrapperLib.TMEXException.g("\ud981삃뒅벇힉겋삍ﾏ늑ﾛﮝ펟芡슣즥\udda7쒩좫躭\udfaf\udcb1钳습킷\udfb9鲻ꦿꇁ뛃꧅蓇ꯉꋋ", a_));
					num3 = (short)452526081;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 11:
					return result;
				case 12:
					if (num2 < 0)
					{
						num3 = (short)697106455;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1666318338;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 13:
					if ((short)b >= this.c)
					{
						num3 = (short)1630535700;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_3DE;
				case 14:
					if (piBtnFamilyType == 255)
					{
						num3 = (short)935067666;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)2040659985;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 15:
					goto IL_20D;
				case 16:
					goto IL_3DE;
				case 17:
					if (this.f[0] == piBtnFamilyType)
					{
						num3 = (short)186646535;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_2C8;
				case 18:
					num3 = (short)1803419657;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 19:
					if (this.f[0] != 24)
					{
						num3 = (short)962592789;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_D5;
				case 20:
					return result;
				case 21:
					num3 = (short)1863647238;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 22:
					if (piBtnFamilyType == 0)
					{
						num3 = (short)1876623365;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					this.a(hSession, out this.f);
					num3 = (short)299237390;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 23:
					global::System.Diagnostics.Trace.WriteLine(global::RMIBtnWrapperLib.TMEXException.g("\ud981삃뒅벇힉겋삍ﾏ늑ﾛﮝ펟芡슣즥\udda7쒩좫躭\udfaf\udcb1钳습킷\udfb9鲻ꦿꇁ뛃꧅蓇ꯉꋋ", a_));
					b += 1;
					num3 = (short)229900288;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 24:
					num3 = (short)2073231379;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				goto IL_7D;
				IL_D5:
				piBtnFamilyType = this.f[0];
				result = true;
				num3 = (short)1122566152;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_20D:
				num3 = (short)1298989069;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_2C8:
				num2 = global::RMIBtnWrapperLib.TMEXAPI.TMNext(hSession, global::RMIBtnWrapperLib.IBtnCommon.g);
				num3 = (short)1309191383;
				short num4 = num3;
				num3 = (short)388148439;
				switch ((num4 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				default:
					num3 = (short)1631715328;
					if (num3 != 0)
					{
					}
					num3 = (short)177340431;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				IL_3DE:
				num3 = (short)2089549836;
				num = (int)((global::System.IntPtr)num3);
			}
			return result;
			IL_7D:
			result = false;
			num2 = 0;
			b = 0;
			num2 = global::RMIBtnWrapperLib.TMEXAPI.TMFirst(hSession, global::RMIBtnWrapperLib.IBtnCommon.g);
			num3 = (short)1389625344;
			short num5 = num3;
			num3 = (short)862191632;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003884 File Offset: 0x00001A84
		public bool FindDevice(int hSession, byte[] serialNum)
		{
			int a_ = 1;
			short num = (short)1219624960;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1902992855;
				short num3 = num;
				num = (short)540564951;
				short[] array;
				short num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_23F:
					num4 = global::RMIBtnWrapperLib.TMEXAPI.TMRom(hSession, global::RMIBtnWrapperLib.IBtnCommon.g, array);
					num = (short)1727791105;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1163788288;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_B0;
					}
					break;
				}
				bool result;
				int num6;
				for (;;)
				{
					IL_79:
					switch (num2)
					{
					case 0:
						this.f = serialNum;
						this.e = serialNum[0];
						result = true;
						num = (short)1104740360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)99024896;
						short num5 = num;
						if (num4 == 1)
						{
							num = (short)2105540619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 2:
						if (num4 == 1)
						{
							num = (short)1779367936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_204;
					case 3:
						return result;
					case 4:
						goto IL_1A7;
					case 5:
						goto IL_149;
					case 6:
						goto IL_149;
					case 7:
						num = (short)217907201;
						if (num != 0)
						{
						}
						if (num6 >= 8)
						{
							num = (short)1459683332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num6] = (short)serialNum[num6];
						num6++;
						num = (short)213057541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_204;
					case 9:
						if (num4 == 0)
						{
							num = (short)2061762570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 10:
						global::System.Diagnostics.Trace.WriteLine(global::RMIBtnWrapperLib.TMEXException.g("⑾얀놂놄\uda86ꦈ얊꾎ﺖ滛ﺚ뾞잠첢키즦춨讪슬솮醰잲\uddb4튶馸풼\udcbe돀곂规ꛆꟈ", a_));
						num = (short)1649672195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num4 = global::RMIBtnWrapperLib.TMEXAPI.TMStrongAccess(hSession, global::RMIBtnWrapperLib.IBtnCommon.g);
						num = (short)1652424706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B0;
					IL_149:
					num = (short)1004535815;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_204:
					num = (short)1769799689;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A7:
				goto IL_23F;
				IL_B0:
				result = false;
				num4 = 0;
				array = new short[8];
				num6 = 0;
				num = (short)420282374;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_79;
			}
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003B44 File Offset: 0x00001D44
		public bool FindFirst(int hSession, short family)
		{
			int a_ = 3;
			short num = (short)1234370560;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B9;
				}
				short num3;
				short[] array;
				bool result;
				for (;;)
				{
					IL_32:
					int num5;
					switch (num2)
					{
					case 0:
						global::RMIBtnWrapperLib.TMEXAPI.TMFamilySearchSetup(hSession, global::RMIBtnWrapperLib.IBtnCommon.g, family);
						num3 = global::RMIBtnWrapperLib.TMEXAPI.TMNext(hSession, global::RMIBtnWrapperLib.IBtnCommon.g);
						num = (short)91357206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1D8;
					case 2:
						num = (short)188612623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1D8;
					case 4:
						this.e = (byte)array[0];
						result = true;
						num = (short)1563623445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1130823706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						int num4;
						if (num4 >= 7)
						{
							num = (short)830341147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2;
						array2[num4] = (byte)array[num4];
						num4++;
						num = (short)1992032267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_507;
					case 8:
						goto IL_28C;
					case 9:
						num = (short)538247178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_5CD;
					case 11:
						goto IL_45B;
					case 12:
						if (num5 >= 8)
						{
							num = (short)1242693636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.f[num5] = (byte)array[num5];
						num5++;
						num = (short)404357123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						if (global::RMIBtnWrapperLib.TMEXAPI.TMRom(hSession, global::RMIBtnWrapperLib.IBtnCommon.g, array) != 1)
						{
							num = (short)1945960479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2 = new byte[7];
						int num4 = 0;
						num = (short)1316683792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (num3 <= 0)
						{
							num = (short)2021457948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[0] = 0;
						num = (short)977469453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						short num6;
						if (array[7] != num6)
						{
							num = (short)1833369618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)885260308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						num = (short)239599617;
						if (num != 0)
						{
						}
						goto IL_45B;
					case 17:
						goto IL_33D;
					case 18:
						goto IL_586;
					case 19:
						if (array[0] != 0)
						{
							num = (short)1206648862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D4;
					case 20:
						if (family != 255)
						{
							num = (short)1729101833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_507;
					case 21:
						goto IL_338;
					case 22:
						goto IL_33D;
					case 23:
						goto IL_33D;
					case 24:
						if (family == 255)
						{
							num = (short)1475674117;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AD;
					case 25:
					{
						short num6;
						if (num6 >= 0)
						{
							num = (short)1338966018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D4;
					}
					case 26:
						if ((array[0] & 127) != 1)
						{
							num = (short)1889206280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AD;
					case 27:
					{
						byte[] array2;
						short num6 = global::RMIBtnWrapperLib.TMEXAPI.TMCRC(7, array2, 0, 0);
						num = (short)1023148051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						goto IL_376;
					case 29:
						if (family != 255)
						{
							num = (short)1622540288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = global::RMIBtnWrapperLib.TMEXAPI.TMFirst(hSession, global::RMIBtnWrapperLib.IBtnCommon.g);
						num = (short)152829975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)27263001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						num = (short)236200922;
						short num7 = num;
						num = (short)436937690;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5CD;
						default:
							goto IL_432;
						}
						break;
					}
					}
					goto IL_B9;
					IL_1D8:
					num = (short)696385536;
					short num8 = num;
					num = (short)29949964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28C:
					num5 = 0;
					num = (short)567934977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5CD:
					if ((family & 127) != (array[0] & 127))
					{
						num = (short)694550535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28C;
					IL_2AD:
					num3 = global::RMIBtnWrapperLib.TMEXAPI.TMNext(hSession, global::RMIBtnWrapperLib.IBtnCommon.g);
					num = (short)1425604625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33D:
					num = (short)1125253134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45B:
					num = (short)1081409542;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_507:
					num = (short)165806104;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2D4:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("좀꾎톒뾞", a_));
				IL_338:
				IL_376:
				return result;
				IL_432:
				num = (short)187039744;
				if (num != 0)
				{
				}
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("풀권ﮎﺐ뎒ﾚ붜횢톤펦욨얪趬ﶮﺰﺲ", a_));
				IL_586:
				goto IL_2D4;
				IL_B9:
				result = false;
				array = new short[8];
				num3 = -1;
				num = (short)261816349;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000414C File Offset: 0x0000234C
		public bool FindNext(int hSession)
		{
			int a_ = 7;
			short num = (short)825819136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A3;
				}
				short[] array;
				short num5;
				bool result;
				for (;;)
				{
					IL_30:
					int num7;
					switch (num2)
					{
					case 0:
						goto IL_28B;
					case 1:
						if (array[0] != 12)
						{
							num = (short)2015813276;
							short num3 = num;
							num = (short)969399964;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)898957312;
								short num4 = num;
								num = (short)1830813696;
								if (num != 0)
								{
								}
								num5 = global::RMIBtnWrapperLib.TMEXAPI.TMNext(hSession, global::RMIBtnWrapperLib.IBtnCommon.g);
								num = (short)446234630;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
						}
						num = (short)1286340610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_D7;
					case 3:
						num = (short)202113049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (array[0] != 24)
						{
							num = (short)912457743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D7;
					case 5:
					{
						short num6;
						if (array[7] != num6)
						{
							num = (short)1057882121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1777532932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_32C;
					case 7:
						if (num7 >= 8)
						{
							num = (short)1963327502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.f[num7] = (byte)array[num7];
						num7++;
						num = (short)1066663954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_185;
					case 9:
						goto IL_49C;
					case 10:
						num = (short)1490878469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_28B;
					case 12:
						num = (short)596705281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_364;
					case 14:
						num = (short)1600847873;
						if (num != 0)
						{
						}
						this.e = (byte)array[0];
						result = true;
						num = (short)254935048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1043529745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						byte[] array2;
						short num6 = global::RMIBtnWrapperLib.TMEXAPI.TMCRC(7, array2, 0, 0);
						num = (short)1029373971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (array[0] != 4)
						{
							num = (short)1561722892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D7;
					case 18:
						goto IL_2C8;
					case 19:
						if (array[0] != 0)
						{
							num = (short)1006370819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_277;
					case 20:
						goto IL_3EB;
					case 21:
						goto IL_2C8;
					case 22:
					{
						if (global::RMIBtnWrapperLib.TMEXAPI.TMRom(hSession, global::RMIBtnWrapperLib.IBtnCommon.g, array) != 1)
						{
							num = (short)1694302228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2 = new byte[7];
						int num8 = 0;
						num = (short)908525568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						if (num5 <= 0)
						{
							num = (short)741081101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[0] = 0;
						num = (short)1426194454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_32C;
					case 25:
					{
						short num6;
						if (num6 >= 0)
						{
							num = (short)113180682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_277;
					}
					case 26:
					{
						int num8;
						if (num8 >= 7)
						{
							num = (short)475660304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2;
						array2[num8] = (byte)array[num8];
						num8++;
						num = (short)1058930699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_A3;
					IL_D7:
					num7 = 0;
					num = (short)1549467669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28B:
					num = (short)194248730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C8:
					num = (short)1129512967;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32C:
					num = (short)1345847319;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_185:
				return result;
				IL_277:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("첄ﾈ뎒ﲔ햖쾠莢", a_));
				IL_364:
				return result;
				IL_3EB:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("킄놐杖랖ﺚﲜﮞ膠쪢튦\udda8\udfaa슬솮醰華襁", a_));
				IL_49C:
				goto IL_277;
				IL_A3:
				result = false;
				array = new short[8];
				num5 = -1;
				num5 = global::RMIBtnWrapperLib.TMEXAPI.TMNext(hSession, global::RMIBtnWrapperLib.IBtnCommon.g);
				num = (short)1137770520;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00004670 File Offset: 0x00002870
		public void FormatButton(int hSession)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			short num3;
			int num5;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (num2 != 1)
					{
						num3 = (short)86573058;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return;
				case 2:
					global::RMIBtnWrapperLib.TMEXException.a(num2, global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMFormat, null);
					num3 = (short)1783562240;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
				{
					IL_157:
					num3 = (short)2066415617;
					if (num3 != 0)
					{
					}
					num3 = (short)797835264;
					short num4 = num3;
					num5++;
					num3 = (short)1604845573;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 4:
					if (num2 != 1)
					{
						num3 = (short)623509507;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_51;
				case 5:
					goto IL_D6;
				case 6:
					goto IL_D6;
				case 7:
					goto IL_51;
				case 8:
					if (num5 > (int)this.c)
					{
						num3 = (short)1341915143;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num2 = global::RMIBtnWrapperLib.TMEXAPI.TMFormat(hSession, global::RMIBtnWrapperLib.IBtnCommon.g);
					num3 = (short)1796472836;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				goto IL_34;
				IL_51:
				num3 = (short)780324208;
				short num6 = num3;
				num3 = (short)2094976368;
				switch ((num6 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_157;
				default:
					num3 = (short)1870200832;
					if (num3 != 0)
					{
					}
					num3 = (short)849149953;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				IL_D6:
				num3 = (short)1128792072;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_34:
			num2 = -1;
			num5 = 0;
			num3 = (short)608174086;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000486C File Offset: 0x00002A6C
		public void CreateFile(int hSession, out short hFile, byte[] fentry, out short maxBytes)
		{
			switch (0)
			{
			case 0:
				goto IL_58;
			}
			int num;
			int num2;
			short num3;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (num2 > (int)this.c)
					{
						num3 = (short)1947467792;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					hFile = global::RMIBtnWrapperLib.TMEXAPI.TMCreateFile(hSession, global::RMIBtnWrapperLib.IBtnCommon.g, out maxBytes, fentry);
					num3 = (short)1023016968;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
				{
					short num4;
					if (num4 - -201 > 1)
					{
						num3 = (short)783286276;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_25F;
				}
				case 2:
					goto IL_9D;
				case 3:
				{
					num3 = (short)21289161;
					short num5 = num3;
					num3 = (short)845273289;
					switch ((num5 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_77;
					default:
						num3 = (short)251068416;
						if (num3 != 0)
						{
						}
						goto IL_31A;
					}
					break;
				}
				case 4:
					num3 = (short)379191307;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 5:
					num3 = (short)1115160578;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 6:
					goto IL_31A;
				case 7:
					if (hFile <= -1)
					{
						num3 = (short)1695744017;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return;
				case 8:
					if (hFile <= -1)
					{
						num3 = (short)737280001;
						if (num3 != 0)
						{
						}
						num3 = (short)121634830;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_149;
				case 9:
					if (!flag)
					{
						num3 = (short)1738801165;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_149;
				case 10:
					return;
				case 11:
				{
					short num4;
					switch (num4)
					{
					case -26:
					case -18:
					case -16:
					case -15:
					case -14:
					case -13:
					case -12:
					case -10:
					case -9:
					case -8:
					case -7:
					case -5:
					case -2:
						goto IL_25F;
					case -25:
					case -24:
					case -23:
					case -22:
					case -21:
					case -20:
					case -19:
					case -17:
					case -11:
					case -6:
					case -4:
					case -3:
						goto IL_9D;
					default:
						num3 = (short)280952837;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 12:
					goto IL_1F9;
				case 13:
					num2++;
					num3 = (short)1870069772;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 14:
				{
					short num4 = hFile;
					num3 = (short)1344536577;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 15:
					goto IL_77;
				case 16:
					goto IL_149;
				case 17:
					global::RMIBtnWrapperLib.TMEXException.a(hFile, global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMCreateFile, null);
					num3 = (short)372572170;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				goto IL_58;
				IL_9D:
				flag = false;
				num3 = (short)1350762499;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_149:
				num3 = (short)1822425095;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1F9:
				num3 = (short)1638727680;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_77:
				goto IL_1F9;
				IL_25F:
				flag = true;
				num3 = (short)1247084550;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_31A:
				num3 = (short)1839792128;
				short num6 = num3;
				num3 = (short)1150418953;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_58:
			flag = false;
			maxBytes = 0;
			hFile = -1;
			num2 = 0;
			num3 = (short)1344995343;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00004C18 File Offset: 0x00002E18
		public byte[] GetROMSerialNum(int hSession, bool bForceRead)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			byte[] result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_E4;
				case 1:
					if (bForceRead)
					{
						num2 = (short)1728118787;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = this.f;
					num2 = (short)128843776;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_106;
				case 3:
				{
					num2 = (short)1402404864;
					short num3 = num2;
					this.a(hSession, out result);
					num2 = (short)237895682;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_20;
			}
			IL_E4:
			return result;
			IL_106:
			num2 = (short)241827841;
			if (num2 != 0)
			{
			}
			return result;
			IL_20:
			result = null;
			num2 = (short)1098071774;
			short num4 = num2;
			num2 = (short)1815166686;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)508166144;
				if (num2 != 0)
				{
				}
				num2 = (short)165347329;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00004D58 File Offset: 0x00002F58
		private void a(int A_0, out byte[] A_1)
		{
			short num = (short)653328384;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1242038273;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				short[] array;
				short num5;
				int num7;
				for (;;)
				{
					IL_50:
					switch (num2)
					{
					case 0:
						goto IL_EB;
					case 1:
					{
						int num3;
						if (num3 >= 8)
						{
							num = (short)1513226243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						short num4;
						this.f[num3] = (byte)(array[num3] & num4);
						num3++;
						num = (short)819855365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_188;
					case 3:
						num = (short)1424228354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_22D;
					case 5:
						goto IL_EB;
					case 6:
						if (num5 == 1)
						{
							num = (short)1910767624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::RMIBtnWrapperLib.TMEXException.a(num5, global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMRom, null);
						num = (short)129302535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_228;
					case 8:
					{
						short num4 = 255;
						int num3 = 0;
						num = (short)281673728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						num = (short)360073773;
						short num6 = num;
						num = (short)958024237;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2017918976;
							if (num != 0)
							{
							}
							if (num7 > (int)this.c)
							{
								num = (short)1760231428;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num5 = global::RMIBtnWrapperLib.TMEXAPI.TMRom(A_0, global::RMIBtnWrapperLib.IBtnCommon.g, array);
							num = (short)177471498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						if (num5 != 1)
						{
							num = (short)636878860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22D;
					case 11:
					{
						num = (short)114556928;
						short num8 = num;
						goto IL_267;
					}
					case 12:
						num7++;
						num = (short)720502797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_267;
					}
					goto IL_8F;
					IL_EB:
					num = (short)1464008705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22D:
					num = (short)1312030726;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_267:
					num = (short)1230897161;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_188:
				IL_228:
				global::System.Array.Copy(this.f, A_1, this.f.Length);
				return;
				IL_8F:
				num5 = 0;
				A_1 = new byte[8];
				array = new short[8];
				array[0] = 0;
				num7 = 0;
				num = (short)1503461387;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00005074 File Offset: 0x00003274
		public void OpenFile(int hSession, out short hFile, byte[] fentry, bool bOkIfNotFound)
		{
			int a_ = 0;
			short num = (short)1970077696;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B7;
				}
				int num3;
				bool flag;
				bool flag2;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_18C;
					case 1:
					{
						if (num3 > (int)this.c)
						{
							num = (short)1475543045;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						hFile = global::RMIBtnWrapperLib.TMEXAPI.TMOpenFile(hSession, global::RMIBtnWrapperLib.IBtnCommon.g, fentry);
						num = (short)958021827;
						short num4 = num;
						num = (short)1646936259;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)327680000;
							if (num != 0)
							{
							}
							num = (short)1928003612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
					{
						short num5;
						if (num5 - -201 > 1)
						{
							num = (short)1733361685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E5;
					}
					case 3:
						goto IL_DE;
					case 4:
						num = (short)1604583426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_312;
					case 6:
					{
						short num5;
						if (num5 != -5)
						{
							num = (short)535953437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E5;
					}
					case 7:
						num3++;
						num = (short)1060175872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_312;
					case 9:
					{
						short num5;
						switch (num5)
						{
						case -18:
						case -16:
						case -14:
						case -13:
						case -9:
						case -8:
							goto IL_4E5;
						case -17:
						case -15:
						case -12:
						case -11:
						case -10:
							goto IL_210;
						default:
							num = (short)1115029530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						goto IL_210;
					case 11:
						flag = false;
						global::System.Diagnostics.Trace.WriteLine(global::RMIBtnWrapperLib.TMEXException.g("㡽ꚅ꺍횏﶑ﲗ몙붛", a_));
						num = (short)1524629535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_4E5;
					case 13:
						if (!flag2)
						{
							num = (short)1040646151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_312;
					case 14:
						num = (short)2027814922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (!flag)
						{
							num = (short)59375632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						num = (short)972357656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						flag = true;
						num = (short)760021000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						global::RMIBtnWrapperLib.TMEXException.a(hFile, global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMOpenFile, null);
						num = (short)896073748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						short num5;
						if (num5 == -2)
						{
							num = (short)802422796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_210;
					}
					case 20:
						return;
					case 21:
						num = (short)1776746519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						if (hFile == -6)
						{
							num = (short)348192779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						short num5 = hFile;
						num = (short)808648729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						short num5;
						if (num5 != -26)
						{
							num = (short)2029649934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E5;
					}
					case 24:
						if (!bOkIfNotFound)
						{
							num = (short)1397358610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 25:
					{
						short num5;
						if (num5 <= -26)
						{
							num = (short)1894580228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1608974345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						num = (short)682426369;
						if (num != 0)
						{
						}
						num = (short)1871839238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_DE;
					case 28:
						if (hFile > -1)
						{
							num = (short)1940979729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1701511190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						num = (short)1010302976;
						short num6 = num;
						num = (short)1433665555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						goto IL_18C;
					case 31:
						goto IL_312;
					}
					goto IL_B7;
					IL_DE:
					num = (short)1652817933;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18C:
					num = (short)1285488641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_210:
					flag2 = false;
					num = (short)20447235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_312:
					num = (short)413597711;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E5:
					flag2 = true;
					num = (short)481230875;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_B7:
				flag2 = false;
				flag = false;
				hFile = -1;
				num3 = 0;
				num = (short)2061172766;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00005618 File Offset: 0x00003818
		public void CloseFile(int hSession, ref short hFile)
		{
			switch (0)
			{
			case 0:
				goto IL_B0;
			}
			int num;
			short num2;
			short num3;
			int num5;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
					num2 = (short)20578313;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (num3 != 1)
					{
						num2 = (short)167641104;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (num3 != -26)
					{
						num2 = (short)85196832;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D1;
				case 3:
					goto IL_5F8;
				case 4:
					num2 = (short)271253534;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (num3 != -6)
					{
						num2 = (short)674889728;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D1;
				case 6:
					goto IL_217;
				case 7:
					num2 = (short)1737752600;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_499;
				case 9:
					if (num3 == -2)
					{
						num2 = (short)1536688140;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5F8;
				case 10:
				{
					num2 = (short)1671495680;
					short num4 = num2;
					num2 = (short)1105723393;
					if (num2 != 0)
					{
					}
					num2 = (short)1196228645;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 11:
					num2 = (short)930807811;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_D1;
				case 13:
					goto IL_217;
				case 14:
					if (num3 - -201 > 1)
					{
						num2 = (short)289341467;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D1;
				case 15:
					num2 = (short)1145765902;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					global::System.Diagnostics.Trace.WriteLine(global::RMIBtnWrapperLib.TMEXException.f(num3, global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMCloseFile));
					num2 = (short)911671322;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					hFile = -1;
					num2 = (short)342818829;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					goto IL_5F8;
				case 19:
					if (num5 > (int)this.c)
					{
						num2 = (short)1468334086;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num3 = global::RMIBtnWrapperLib.TMEXAPI.TMCloseFile(hSession, global::RMIBtnWrapperLib.IBtnCommon.g, hFile);
					num2 = (short)720502817;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					goto IL_499;
				case 21:
					goto IL_499;
				case 22:
					if (num3 <= -26)
					{
						num2 = (short)571277327;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1235681303;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					if (num3 != -18)
					{
						goto IL_453;
					}
					goto IL_D1;
				case 24:
					if (num3 != -13)
					{
						num2 = (short)1692729348;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D1;
				case 25:
					goto IL_2C8;
				case 26:
					return;
				case 27:
					num2 = (short)1042939906;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					if (num3 <= -8)
					{
						num2 = (short)1729953799;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2003632133;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					goto IL_5F8;
				case 30:
					if (num3 != -8)
					{
						num2 = (short)940507147;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					hFile = -1;
					flag = true;
					num2 = (short)317325320;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					if (!flag)
					{
						num2 = (short)857210916;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_217;
				case 32:
					num2 = (short)1098907666;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
					if (1 == num3)
					{
						num2 = (short)686227473;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1057357858;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
				{
					if (num3 > -16)
					{
						num2 = (short)448921628;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1483003839;
					short num6 = num2;
					num2 = (short)1288099775;
					switch ((num6 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_453;
					default:
						num2 = (short)867893248;
						if (num2 != 0)
						{
						}
						num2 = (short)1154285607;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 35:
					num2 = (short)943128605;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 36:
					num5++;
					num2 = (short)1141243929;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 37:
					if (num3 != -16)
					{
						num2 = (short)2140078115;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D1;
				case 38:
					goto IL_2C8;
				case 39:
					num2 = (short)807075862;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_B0;
				IL_D1:
				hFile = -1;
				flag = true;
				num2 = (short)1541406741;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_217:
				num2 = (short)1207369729;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2C8:
				num2 = (short)359464979;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_453:
				num2 = (short)50659338;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_499:
				num2 = (short)502595615;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5F8:
				flag = false;
				num2 = (short)480182292;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_B0:
			num3 = 0;
			num5 = 0;
			num2 = (short)1142489126;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00005C40 File Offset: 0x00003E40
		public void DeleteFile(int hSession, byte[] fentry)
		{
			switch (0)
			{
			case 0:
				goto IL_78;
			}
			int num;
			short num2;
			short num3;
			int num5;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
					if (num2 != 1)
					{
						num3 = (short)71696406;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return;
				case 1:
					goto IL_98;
				case 2:
					num3 = (short)497680398;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					goto IL_308;
				case 4:
					if (!flag)
					{
						num3 = (short)647102477;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_308;
				case 5:
					num3 = (short)743505941;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 6:
				{
					num3 = (short)1030748441;
					short num4 = num3;
					num3 = (short)405862681;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_104;
					default:
						num3 = (short)246218752;
						if (num3 != 0)
						{
						}
						goto IL_98;
					}
					break;
				}
				case 7:
					if (num2 == -2)
					{
						num3 = (short)1431437332;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1D2;
				case 8:
					num3 = (short)370475033;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 9:
					num3 = (short)148570130;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 10:
					switch (num2)
					{
					case -18:
					case -16:
					case -15:
					case -14:
					case -13:
					case -12:
					case -8:
						goto IL_D2;
					case -17:
					case -11:
					case -10:
					case -9:
						goto IL_1D2;
					default:
						num3 = (short)688259083;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				case 11:
					num3 = (short)674234375;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 12:
					goto IL_155;
				case 13:
					num5++;
					num3 = (short)1639251980;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 14:
					if (num2 - -201 > 1)
					{
						num3 = (short)1210581009;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_D2;
				case 15:
					if (num2 != -26)
					{
						num3 = (short)900399109;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_D2;
				case 16:
					if (num5 > (int)this.c)
					{
						num3 = (short)1312882691;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num2 = global::RMIBtnWrapperLib.TMEXAPI.TMDeleteFile(hSession, global::RMIBtnWrapperLib.IBtnCommon.g, fentry);
					num3 = (short)1666842643;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 17:
					num3 = (short)1506476047;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 18:
					if (num2 != -6)
					{
						num3 = (short)2127822856;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_308;
				case 19:
					if (1 != num2)
					{
						num3 = (short)788135945;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_308;
				case 20:
					num3 = (short)167378945;
					if (num3 != 0)
					{
					}
					goto IL_D2;
				case 21:
					goto IL_1D2;
				case 22:
					global::RMIBtnWrapperLib.TMEXException.a(num2, global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMDeleteFile, null);
					num3 = (short)1831206935;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 23:
					return;
				case 24:
					goto IL_155;
				case 25:
					goto IL_104;
				}
				goto IL_78;
				IL_98:
				num3 = (short)1973157892;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_D2:
				flag = true;
				num3 = (short)1112932353;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_104:
				if (num2 <= -26)
				{
					num3 = (short)538902528;
					short num6 = num3;
					num3 = (short)2021982210;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				num3 = (short)902234122;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_155:
				num3 = (short)1559691280;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1D2:
				flag = false;
				num3 = (short)1025835014;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_308:
				num3 = (short)554827776;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_78:
			num2 = 0;
			num5 = 0;
			num3 = (short)349241368;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000060B4 File Offset: 0x000042B4
		public bool WriteFile(int hSession, byte[] fentry, byte[] ptrDataArr, int nFileLen, short startPage)
		{
			int a_ = 19;
			short num = (short)1035141120;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_207;
				}
				bool flag;
				byte[] array2;
				byte[] array6;
				int num10;
				int num12;
				for (;;)
				{
					IL_30:
					byte[] array4;
					ushort num16;
					byte b2;
					switch (num2)
					{
					case 0:
						goto IL_93E;
					case 1:
						num = (short)614793276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						int num3 = nFileLen / 28 + ((nFileLen % 28 > 0) ? 1 : 0);
						byte[] array = new byte[num3];
						int num4 = 0;
						num = (short)802750562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						byte b;
						if ((b & 32) == 32)
						{
							num = (short)19333151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)35323976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						flag = false;
						num = (short)523632653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_E7C;
					case 6:
					{
						int num4;
						ushort num5;
						if (!this.WriteScratch(hSession, num5, array2, num4))
						{
							num = (short)2057568290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num6 = 0;
						byte b = 0;
						byte[] array3 = new byte[32];
						num = (short)418381840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						int num7;
						if (array4[num7] != array2[num7])
						{
							num = (short)188743684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num7++;
						num = (short)625868873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_11CF;
					case 9:
						goto IL_BA9;
					case 10:
					{
						byte[] array5 = new byte[]
						{
							0,
							170,
							0,
							128,
							1,
							0,
							0,
							0,
							32,
							32,
							32,
							32,
							0,
							1,
							1,
							0
						};
						int num4 = 0;
						num = (short)973471802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						byte[] array;
						int num4;
						int num8;
						int num9;
						array6[num4 + 1] = ((num8 == 0) ? 0 : array[num9 + 1]);
						num10 = num4 + 2;
						num4 = 0;
						num = (short)1864433769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_732;
					case 13:
						goto IL_AB9;
					case 14:
						goto IL_F90;
					case 15:
					{
						string s = global::RMIBtnWrapperLib.TMEXException.g("\udc90\udc92솔톖ꦘ", a_);
						fentry = new global::System.Text.ASCIIEncoding().GetBytes(s);
						num = (short)1564868669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						byte b;
						ushort num6;
						byte[] array3;
						if (this.ReadScratch(hSession, ref num6, ref b, out array3))
						{
							num = (short)1665204328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)1665925229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						num = (short)1428447109;
						short num11 = num;
						num = (short)1277321093;
						switch ((num11 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F1A;
						default:
						{
							num = (short)1961754624;
							if (num != 0)
							{
							}
							ushort num5;
							if (this.FormatUDP(num5, ref array2, ref num12))
							{
								num = (short)648020019;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag = false;
							num = (short)1421672484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 18:
						num = (short)1793261622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						int num4;
						if (num4 >= num10)
						{
							num = (short)1046741037;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array5;
						array2[num4] = array5[num4];
						num4++;
						num = (short)318177372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_FFF;
					case 21:
						flag = false;
						num = (short)1437990920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_D47;
					case 23:
					{
						int num4;
						int num8;
						num8 -= num4;
						num = (short)844890123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						ushort num5;
						int num4 = (int)(32 - (num5 & 31));
						num = (short)419561587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						int num4;
						if (num4 >= 5)
						{
							num = (short)708837439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array5;
						array5[num4 + 8] = fentry[num4];
						num4++;
						num = (short)1541931057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (this.e == 24)
						{
							num = (short)1747189760;
							short num13 = num;
							num = (short)1475674113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED4;
					case 27:
					{
						int num4;
						int num7;
						if (num7 >= num4)
						{
							num = (short)647757932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1271332871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
					{
						int num7 = 0;
						num = (short)500105273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
					{
						int num4;
						int num14;
						if (num14 >= num4)
						{
							num = (short)2142633996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1000407142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						goto IL_1130;
					case 31:
						flag = false;
						num = (short)837156940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						int num4;
						int num8;
						if (num4 >= ((num8 > 28) ? 28 : num8))
						{
							num = (short)1482686487;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num15;
						array6[num4 + 1] = ptrDataArr[num15++];
						num4++;
						num = (short)591790187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
					{
						int num3;
						int num4;
						if (num4 >= num3)
						{
							num = (short)1383137327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						byte[] array5;
						this.a(1, 1, (int)array[num4], ref array5, 4);
						num4++;
						num = (short)174391380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						flag = false;
						num = (short)1708130363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_6D1;
					case 36:
						goto IL_6D1;
					case 37:
					{
						int num4;
						if (num4 > num12)
						{
							num = (short)1547173985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array2[num4 - 1] = array2[num4];
						num4++;
						num = (short)1263534080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
						goto IL_BA9;
					case 39:
					{
						int num4;
						if (num4 >= num10)
						{
							num = (short)1371340874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array2[num4] = array6[num4];
						num4++;
						num = (short)176947214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						num = (short)1974140981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						flag = false;
						num = (short)164954223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						goto IL_38F;
					case 43:
						flag = false;
						num = (short)346095698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						flag = false;
						num = (short)1968767063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
					{
						num12 = num10;
						ushort num5 = (ushort)(array2[0] << 5);
						int num4 = 1;
						num = (short)433389648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
						goto IL_D47;
					case 47:
						num = (short)660734046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
					{
						int num8 = nFileLen;
						int num15 = 0;
						int num9 = 0;
						num = (short)159514646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
						goto IL_806;
					case 50:
						goto IL_845;
					case 51:
						num12 = 32;
						num = (short)1393885219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						if (flag)
						{
							num = (short)617807951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12EE;
					case 53:
					{
						int num4;
						ushort num5;
						if (!this.WriteScratch(hSession, num5, array2, num4))
						{
							num = (short)2076704846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1130;
					}
					case 54:
						if (!this.EraseScratchSHA(hSession))
						{
							num = (short)1076625504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7D;
					case 55:
						goto IL_A73;
					case 56:
						goto IL_B22;
					case 57:
						goto IL_97E;
					case 58:
						goto IL_806;
					case 59:
						goto IL_BA9;
					case 60:
						if (!this.EraseScratchSHA(hSession))
						{
							num = (short)914948137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED4;
					case 61:
						goto IL_33E;
					case 62:
						goto IL_5EC;
					case 63:
					{
						byte[] array;
						byte[] array5;
						array5[13] = array[0];
						int num3;
						array5[14] = (byte)num3;
						int num4 = 0;
						num = (short)315687005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 64:
						num = (short)443678746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						goto IL_BA9;
					case 66:
						if (this.ReadScratch(hSession, ref num16, ref b2, out array4))
						{
							num = (short)827654172;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)286654469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
					{
						ushort num5;
						if (!this.CopyScratch(hSession, num5, num12))
						{
							num = (short)23068693;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12EE;
					}
					case 68:
						goto IL_F1A;
					case 69:
						if (flag)
						{
							num = (short)80412736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED4;
					case 70:
						num12--;
						num = (short)1991770129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						goto IL_BA9;
					case 72:
					{
						ushort num5;
						if (!this.CopyScratch(hSession, num5, num12))
						{
							num = (short)395051098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num9;
						num9++;
						num = (short)815464494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 73:
						goto IL_97E;
					case 74:
					{
						num12 = num10;
						ushort num5 = (ushort)(array2[0] << 5);
						int num4 = 1;
						num = (short)407633995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 75:
						goto IL_93E;
					case 76:
						goto IL_BA9;
					case 77:
						if (flag)
						{
							num = (short)2142568516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12EE;
					case 78:
						flag = false;
						num = (short)1384251422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
					{
						num10 = 16;
						int num4 = 0;
						num = (short)1519583288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 80:
						goto IL_FFF;
					case 81:
					{
						ushort num5;
						int num4 = (int)(32 - (num5 & 31));
						num = (short)357105778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 82:
						goto IL_E7C;
					case 83:
					{
						ushort num5;
						if (num12 > (int)(32 - (num5 & 31)))
						{
							num = (short)1476722769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4 = num12;
						num = (short)93192283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 84:
						goto IL_2A7;
					case 85:
						if ((b2 & 32) == 32)
						{
							num = (short)978452523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E7C;
					case 86:
						if (fentry == null)
						{
							num = (short)947519503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33E;
					case 87:
						goto IL_732;
					case 88:
						goto IL_A73;
					case 89:
					{
						int num3;
						int num4;
						if (num4 >= num3)
						{
							num = (short)716505098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						array[num4] = (byte)((int)startPage + num4);
						num4++;
						num = (short)1206583338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 90:
						flag = false;
						num = (short)202506278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						goto IL_B61;
					case 92:
						goto IL_B22;
					case 93:
						goto IL_2A7;
					case 94:
						if (this.FindDevice(hSession, ref this.e))
						{
							num = (short)911409200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)168558704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
					{
						ushort num5;
						if (num12 > (int)(32 - (num5 & 31)))
						{
							num = (short)1906835480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4 = num12;
						num = (short)2137194546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 96:
						flag = false;
						num = (short)464060487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						num12--;
						num = (short)1300234343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						goto IL_38F;
					case 99:
					{
						int num4;
						if (num4 > num12)
						{
							num = (short)1686110278;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array2[num4 - 1] = array2[num4];
						num4++;
						num = (short)951386132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 100:
						if (this.e == 24)
						{
							num = (short)1115422738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7D;
					case 101:
						if (flag)
						{
							num = (short)1422589992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1130;
					case 102:
					{
						byte[] array3;
						int num14;
						if (array3[num14] != array2[num14])
						{
							num = (short)2004090924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num14++;
						num = (short)1966473271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 103:
					{
						ushort num5;
						if (this.FormatUDP(num5, ref array2, ref num12))
						{
							num = (short)570097774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)2009268233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 104:
					{
						int num14 = 0;
						num = (short)1170866264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 105:
						goto IL_F90;
					case 106:
						num = (short)1834221668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 107:
						goto IL_5EC;
					case 108:
						goto IL_AB9;
					case 109:
						goto IL_BA9;
					case 110:
						num12 = 32;
						num = (short)2019885162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
						goto IL_ED4;
					case 112:
						goto IL_59F;
					case 113:
					{
						int num8;
						if (num8 <= 0)
						{
							num = (short)159514689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						int num9;
						array6[0] = array[num9];
						int num4 = 0;
						num = (short)762183742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 114:
						goto IL_B61;
					case 115:
						goto IL_845;
					}
					goto IL_207;
					IL_2A7:
					num = (short)434896929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33E:
					num = (short)1063452673;
					if (num != 0)
					{
					}
					num = (short)1377304578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38F:
					num = (short)854720601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5EC:
					num = (short)1015414816;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D1:
					num = (short)1611268165;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_732:
					num = (short)1688600579;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_806:
					num = (short)1405288473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_845:
					num = (short)1063714917;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_93E:
					num = (short)112590885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_97E:
					num = (short)2052980763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A73:
					num = (short)590086173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB9:
					num = (short)1000996949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B22:
					num = (short)456589331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B61:
					num = (short)936181766;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BA9:
					num = (short)136577076;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C7D:
					num = (short)1390149715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D47:
					num = (short)473759857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E7C:
					num = (short)1045626957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ED4:
					num = (short)1473183839;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F1A:
					num = (short)1609891907;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F90:
					num = (short)930742311;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FFF:
					num = (short)1848770659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1130:
					num16 = 0;
					b2 = 0;
					array4 = new byte[32];
					num = (short)1671036994;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_59F:
				IL_11CF:
				IL_12EE:
				this.ResetSpeed(hSession);
				return flag;
				IL_207:
				flag = true;
				array6 = new byte[32];
				num10 = 0;
				num12 = 0;
				array2 = new byte[64];
				num = (short)998768726;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000073B8 File Offset: 0x000055B8
		public bool ReadFile(int hSession, byte[] fentry, ref short start_pg, ref short nNumBytesToRead, out byte[] ptrDataArr)
		{
			int a_ = 17;
			short num = (short)1597177856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_14F;
				}
				byte b;
				int num3;
				byte[] array;
				byte[] array2;
				int num4;
				byte b2;
				bool flag;
				int num6;
				int num7;
				for (;;)
				{
					IL_30:
					int num5;
					switch (num2)
					{
					case 0:
						goto IL_A8F;
					case 1:
						num = (short)1770455102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (b == 0)
						{
							num = (short)200343573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33D;
					case 3:
						goto IL_A53;
					case 4:
						num3 = 7057;
						array = new byte[7057];
						num = (short)1980694582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1472462909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_95D;
					case 7:
						goto IL_69D;
					case 8:
						num = (short)1477509121;
						if (num != 0)
						{
						}
						goto IL_3E1;
					case 9:
						b2 = array2[num4 + 5];
						start_pg = (short)b2;
						num = (short)323354675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (array2.Length >= num4 + 4)
						{
							num = (short)1070071816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_739;
					case 11:
						if (b2 == 0)
						{
							num = (short)1874919479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC7;
					case 12:
						num5 = 7;
						goto IL_719;
					case 13:
						if (fentry[4] == (array2[num4 + 4] & 127))
						{
							num = (short)404357129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31A;
					case 14:
						flag = false;
						num = (short)487063555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						string s = global::RMIBtnWrapperLib.TMEXException.g("슎\ude90잒펔Ꞗ", a_);
						fentry = new global::System.Text.ASCIIEncoding().GetBytes(s);
						num = (short)305725484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (!this.ReadUDP(hSession, (ushort)(b << 5), out array2, ref num6))
						{
							num = (short)137363485;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1897332738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (array2[0] == 170)
						{
							num = (short)229834788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6FA;
					case 18:
						goto IL_69D;
					case 19:
						global::System.Array.Copy(array, ptrDataArr, (int)nNumBytesToRead);
						flag = true;
						num = (short)1410465857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (num7 > (int)nNumBytesToRead)
						{
							num = (short)936771626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						nNumBytesToRead = (short)num7;
						num = (short)1130168354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)1266024465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (b != 0)
						{
							num = (short)1041760291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1357578252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (array2[1] == 0)
						{
							num = (short)1965555738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6FA;
					case 24:
						if (num4 >= num6 - 1)
						{
							num = (short)725352480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num7++] = array2[num4];
						num4++;
						num = (short)553648135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_739;
					case 26:
						num = (short)1078067253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)1614544944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (num4 >= 28)
						{
							num = (short)486408217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)576782346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						flag = false;
						num = (short)1642004519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (flag)
						{
							num = (short)1114636347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5B;
					case 31:
						flag = false;
						num = (short)614858793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						b2 = array2[num6 - 1];
						num = (short)971440139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (this.e == 12)
						{
							num = (short)1169555460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = 420;
						array = new byte[420];
						num = (short)1930100742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_8DB;
					case 35:
						num = (short)736100416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)897318935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_1F6;
					case 38:
						if (b2 != 0)
						{
							num = (short)354353197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)1235419186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						goto IL_A8F;
					case 40:
						num = (short)1324351534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_A53;
					case 42:
						num7 = (int)nNumBytesToRead;
						num = (short)345047097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (num6 + num7 - 1 > num3)
						{
							num = (short)222560270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = 0;
						num = (short)769916946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						goto IL_A0A;
					case 45:
						goto IL_AC7;
					case 46:
						if (fentry[2] == array2[num4 + 2])
						{
							num = (short)1270939675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31A;
					case 47:
						if (!this.ReadUDP(hSession, (ushort)(b2 << 5), out array2, ref num6))
						{
							num = (short)1845887007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1480654891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (fentry[3] == array2[num4 + 3])
						{
							num = (short)1789984826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31A;
					case 49:
						if (b != 0)
						{
							num = (short)1616773121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A8F;
					case 50:
						goto IL_3DC;
					case 51:
					{
						num = (short)1060715849;
						short num8 = num;
						num = (short)1125924169;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3E1;
						default:
							num = (short)826212352;
							if (num != 0)
							{
							}
							goto IL_739;
						}
						break;
					}
					case 52:
						goto IL_1F6;
					case 53:
						if (num6 >= 7)
						{
							num = (short)1654652994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6FA;
					case 54:
						goto IL_95D;
					case 55:
						goto IL_A53;
					case 56:
						if (fentry == null)
						{
							num = (short)2044133391;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A0A;
					case 57:
						goto IL_8DB;
					case 58:
						num = (short)1212612621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						num = (short)815071252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						if (fentry[0] == array2[num4])
						{
							num = (short)1119813637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31A;
					case 61:
						if (fentry[1] == array2[num4 + 1])
						{
							num = (short)1147011112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31A;
					case 62:
						if (b2 != 0)
						{
							num = (short)2011037696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A0A;
					case 63:
						goto IL_A8F;
					case 64:
						num5 = 0;
						goto IL_719;
					case 65:
						goto IL_9BF;
					case 66:
						goto IL_33D;
					case 67:
						goto IL_6FA;
					case 68:
						if (ptrDataArr != null)
						{
							num = (short)932380691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5B;
					case 69:
						if ((num6 - 1) % 7 > 0)
						{
							num = (short)1676673091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2031222806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14F;
					IL_1F6:
					num = (short)219349020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_31A:
					num4 += 7;
					num = (short)2051538996;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33D:
					num = (short)589365317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E1:
					num = (short)549519420;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_69D:
					num = (short)391512088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6FA:
					flag = false;
					num = (short)645070911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_719:
					num4 = num5;
					num = (short)990511141;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_739:
					b = array2[num6 - 1];
					num = (short)128122929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8DB:
					ptrDataArr = new byte[(int)nNumBytesToRead];
					num = (short)2122514500;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_95D:
					num = (short)1756561464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A0A:
					num = (short)109510672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A53:
					num = (short)248709150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A8F:
					num = (short)823197734;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AC7:
					num = (short)1337327616;
					short num9 = num;
					num = (short)729022511;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3DC:
				IL_9BF:
				IL_B5B:
				this.ResetSpeed(hSession);
				return flag;
				IL_14F:
				flag = true;
				b = 0;
				b2 = 0;
				array2 = new byte[32];
				num7 = 0;
				num4 = 0;
				num6 = 0;
				ptrDataArr = null;
				num3 = 0;
				array = null;
				num = (short)1210449953;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00007F28 File Offset: 0x00006128
		public void ResetSpeed(int hSession)
		{
			short num = (short)1950089217;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1548091392;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_DC;
				case 1:
					num = (short)91881473;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_81;
					}
					continue;
				case 2:
					global::RMIBtnWrapperLib.TMEXAPI.TMOneWireCom(hSession, 0, 0);
					global::RMIBtnWrapperLib.IBtnCommon.h[0] = global::System.Convert.ToByte(global::RMIBtnWrapperLib.TMEXAPI.TMOneWireCom(hSession, 1, 0) == 1);
					num = (short)1936850944;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_81:
				if (global::RMIBtnWrapperLib.IBtnCommon.h[0] <= 0)
				{
					return;
				}
				num = (short)1376583682;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DC:
			num = (short)1291087006;
			short num4 = num;
			num = (short)1474849950;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)484376576;
				if (num != 0)
				{
				}
				break;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000805C File Offset: 0x0000625C
		public void WriteFile(int hSession, short hFile, byte[] pFileData, short numBytes)
		{
			switch (0)
			{
			case 0:
				goto IL_58;
			}
			int num;
			short num2;
			short num3;
			int num4;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
					if (num2 <= 0)
					{
						num3 = (short)1412759567;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return;
				case 1:
					goto IL_17C;
				case 2:
					goto IL_312;
				case 3:
					if (num4 > (int)this.c)
					{
						num3 = (short)1286078481;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_131;
				case 4:
					num4++;
					num3 = (short)631701517;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 5:
					return;
				case 6:
					goto IL_312;
				case 7:
					if (hFile - -201 > 1)
					{
						num3 = (short)1449656329;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_22F;
				case 8:
					switch (hFile)
					{
					case -26:
					case -18:
					case -16:
					case -15:
					case -14:
					case -13:
					case -12:
					case -10:
					case -8:
					case -7:
					case -6:
					case -4:
					case -2:
						goto IL_22F;
					case -25:
					case -24:
					case -23:
					case -22:
					case -21:
					case -20:
					case -19:
					case -17:
					case -11:
					case -9:
					case -5:
					case -3:
						goto IL_96;
					default:
						num3 = (short)1450770446;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				case 9:
					num3 = (short)546504712;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 10:
					if (!flag)
					{
						num3 = (short)1630273540;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_F7;
				case 11:
					goto IL_96;
				case 12:
					if (num2 <= 0)
					{
						num3 = (short)1726808080;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_F7;
				case 13:
					goto IL_17C;
				case 14:
				{
					num3 = (short)378994688;
					short num5 = num3;
					num3 = (short)1411907595;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 15:
					global::RMIBtnWrapperLib.TMEXException.a(num2, global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMWriteFile, null);
					num3 = (short)727384069;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 16:
					num3 = (short)1237123079;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 17:
				{
					num3 = (short)82599346;
					short num6 = num3;
					num3 = (short)191192498;
					switch ((num6 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_131;
					default:
						num3 = (short)808583168;
						if (num3 != 0)
						{
						}
						goto IL_F7;
					}
					break;
				}
				}
				goto IL_58;
				IL_96:
				flag = false;
				num3 = (short)902103046;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_F7:
				num3 = (short)1734475776;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_131:
				num2 = global::RMIBtnWrapperLib.TMEXAPI.TMWriteFile(hSession, global::RMIBtnWrapperLib.IBtnCommon.g, hFile, pFileData, numBytes);
				num3 = (short)1018822668;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_17C:
				num3 = (short)1782251523;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_22F:
				num3 = (short)429522945;
				if (num3 != 0)
				{
				}
				flag = true;
				num3 = (short)1604321282;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_312:
				num3 = (short)539754506;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_58:
			num2 = -1;
			num4 = 0;
			num3 = (short)1489567745;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000083FC File Offset: 0x000065FC
		public void ReadFile(int hSession, short hFile, ref short pNumBytesToRead, out byte[] pFileData)
		{
			short num = (short)910819328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9B;
				}
				short num3;
				short buff_size;
				byte[] array;
				for (;;)
				{
					IL_28:
					int num4;
					bool flag;
					switch (num2)
					{
					case 0:
						goto IL_14F;
					case 1:
						if (num3 > pNumBytesToRead)
						{
							num = (short)2016673818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						pNumBytesToRead = num3;
						num = (short)324993048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_3DE;
					case 3:
						goto IL_3DE;
					case 4:
						switch (num3)
						{
						case -18:
						case -16:
						case -14:
						case -13:
						case -9:
						case -8:
						case -6:
						case -4:
						case -2:
							goto IL_27A;
						case -17:
						case -15:
						case -12:
						case -11:
						case -10:
						case -7:
						case -5:
						case -3:
							goto IL_14F;
						default:
							num = (short)93716500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 5:
						num4++;
						num = (short)1760100370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (this.e == 12)
						{
							num = (short)1209925641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						buff_size = 420;
						array = new byte[420];
						num = (short)1609957379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1332019201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (num3 != -26)
						{
							num = (short)1019150347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27A;
					case 9:
						buff_size = 7057;
						array = new byte[7057];
						num = (short)1127219202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_10C;
					case 11:
						num = (short)306774020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1813446664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_4EB;
					case 14:
						goto IL_203;
					case 15:
						num = (short)1370750977;
						if (num != 0)
						{
						}
						if (num3 < 0)
						{
							num = (short)236126224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_461;
					case 16:
						num = (short)876085273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_14A;
					case 18:
						goto IL_10C;
					case 19:
						goto IL_4EB;
					case 20:
						num = (short)2025652224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (!flag)
						{
							num = (short)212074501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_461;
					case 22:
						if (num4 > (int)this.c)
						{
							num = (short)1403191313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = global::RMIBtnWrapperLib.TMEXAPI.TMReadFile(hSession, global::RMIBtnWrapperLib.IBtnCommon.g, hFile, array, buff_size);
						num = (short)826474511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						if (num3 < 0)
						{
							goto IL_527;
						}
						num = (short)1323700261;
						short num5 = num;
						num = (short)2093682725;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14A;
						default:
							num = (short)1168769024;
							if (num != 0)
							{
							}
							num = (short)1394933767;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 24:
						goto IL_275;
					case 25:
						if (num3 - -201 > 1)
						{
							num = (short)1916010508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27A;
					case 26:
						num3 = pNumBytesToRead;
						num = (short)741605390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9B;
					IL_10C:
					num = (short)1963655190;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14F:
					flag = false;
					num = (short)314376205;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27A:
					flag = true;
					num = (short)865927187;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DE:
					pFileData = null;
					flag = false;
					num4 = 0;
					num = (short)1047724042;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_461:
					num = (short)439353367;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14A:
					goto IL_461;
					IL_4EB:
					num = (short)1533149205;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_203:
				IL_275:
				pFileData = new byte[(int)num3];
				global::System.Array.Copy(array, pFileData, (int)num3);
				return;
				IL_527:
				global::RMIBtnWrapperLib.TMEXException.a(num3, global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMReadFile, null);
				return;
				IL_9B:
				num = (short)448069632;
				short num6 = num;
				array = null;
				buff_size = 0;
				num3 = -1;
				num = (short)189792262;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000893C File Offset: 0x00006B3C
		public bool ReadUDP(int hSession, ushort address, out byte[] page_data, ref int length)
		{
			short num = (short)609222656;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				bool result;
				byte[] array;
				short num6;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_326;
					case 1:
						if (this.Select(hSession))
						{
							num = (short)1379926028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
					{
						int num4;
						short num5;
						ushort num3 = this.a((ushort)array[num4 + 1 + (int)num5], num3);
						num3 = this.a((ushort)array[num4 + 2 + (int)num5], num3);
						num = (short)203948046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						return result;
					case 4:
						if (global::RMIBtnWrapperLib.TMEXAPI.TMBlockStream(hSession, array, num6) == num6)
						{
							num = (short)198246407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 5:
						if (length <= 29)
						{
							num = (short)217120768;
							short num7 = num;
							num = (short)348585994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 6:
					{
						int num4;
						if (num4 >= length)
						{
							num = (short)928710658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						short num5;
						page_data[num4] = array[num4 + 1 + (int)num5];
						ushort num3 = this.a((ushort)page_data[num4], num3);
						num4++;
						num = (short)911147024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						ushort num3 = (ushort)(address >> 5);
						short num5;
						length = (int)array[(int)num5];
						num3 = this.a((ushort)length, num3);
						goto IL_37D;
					}
					case 8:
						goto IL_E9;
					case 9:
						goto IL_326;
					case 10:
					{
						page_data = new byte[length];
						int num4 = 0;
						num4 = 0;
						num = (short)22806536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)872284164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						byte[] array2 = array;
						short num8 = num6;
						num6 = num8 + 1;
						array2[(int)num8] = 240;
						byte[] array3 = array;
						short num9 = num6;
						num6 = num9 + 1;
						array3[(int)num9] = (byte)(address & 255);
						byte[] array4 = array;
						short num10 = num6;
						num6 = num10 + 1;
						array4[(int)num10] = (byte)(address >> 8 & 255);
						short num5 = num6;
						int num11 = 0;
						num = (short)1399586816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						int num11;
						if (num11 >= 32)
						{
							num = (short)1954480139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)146669444;
						short num12 = num;
						num = (short)1544290180;
						switch ((num12 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_37D;
						default:
						{
							num = (short)1065549824;
							if (num != 0)
							{
							}
							byte[] array5 = array;
							short num13 = num6;
							num6 = num13 + 1;
							array5[(int)num13] = 255;
							num11++;
							num = (short)1413021705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 14:
					{
						ushort num3;
						if (num3 == 45057)
						{
							num = (short)1532690447;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 15:
						result = true;
						num = (short)944635907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_E9;
					}
					goto IL_72;
					IL_E9:
					num = (short)1965883398;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_326:
					num = (short)860749837;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37D:
					num = (short)1507333;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_72:
				num = (short)738000897;
				if (num != 0)
				{
				}
				result = false;
				array = new byte[50];
				num6 = 0;
				page_data = null;
				num = (short)1993605121;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00008D30 File Offset: 0x00006F30
		public bool FormatUDP(ushort address, ref byte[] write_buf, ref int write_len)
		{
			short num = (short)1057292288;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				byte[] array;
				int num6;
				bool result;
				for (;;)
				{
					IL_28:
					int num8;
					switch (num2)
					{
					case 0:
					{
						num = (short)320077824;
						short num3 = num;
						goto IL_217;
					}
					case 1:
						goto IL_1F4;
					case 2:
					{
						int num4;
						if (num4 < write_len)
						{
							ushort num5 = this.a((ushort)write_buf[num4], num5);
							array[num6++] = write_buf[num4];
							num4++;
							num = (short)1092485131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)796530605;
						short num7 = num;
						num = (short)1233852333;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1F4;
						default:
							num = (short)99811328;
							if (num != 0)
							{
							}
							num = (short)2132869123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
					{
						ushort num5;
						array[num6++] = (byte)(~(byte)(num5 & 255));
						array[num6++] = (byte)(~(byte)((num5 & 65280) >> 8));
						num8 = 0;
						num = (short)1763115009;
						if (num != 0)
						{
						}
						num = (short)1789853704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return result;
					case 5:
					{
						if (write_len > 29)
						{
							num = (short)1628831754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num5 = (ushort)(address >> 5);
						array[num6++] = (byte)write_len;
						num5 = this.a((ushort)write_len, num5);
						int num4 = 0;
						num = (short)1235681280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						write_len = num6;
						num = (short)1296629769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_1DC;
					case 8:
						goto IL_1DC;
					case 9:
						return result;
					case 10:
						result = false;
						num = (short)1800929284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_217;
					}
					goto IL_5F;
					IL_1F4:
					if (num8 >= num6)
					{
						num = (short)2145845254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					write_buf[num8] = array[num8];
					num8++;
					num = (short)1829699591;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DC:
					num = (short)748027905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_217:
					num = (short)1291190274;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_5F:
				array = new byte[32];
				num6 = 0;
				result = true;
				num = (short)1613365253;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000901C File Offset: 0x0000721C
		private ushort a(ushort A_0, ushort A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
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
					A_1 ^= 49153;
					num2 = (short)2039102245;
					short num3 = num2;
					num2 = (short)777403173;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_49;
					default:
					{
						num2 = (short)873791488;
						if (num2 != 0)
						{
						}
						num2 = (short)1518731265;
						if (num2 != 0)
						{
						}
						num2 = (short)910163968;
						short num4 = num2;
						num2 = (short)1901002754;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_49;
				case 2:
					goto IL_135;
				}
				goto IL_1C;
				IL_49:
				if ((global::RMIBtnWrapperLib.IBtnCommon.i[(int)(A_0 & 15)] ^ global::RMIBtnWrapperLib.IBtnCommon.i[A_0 >> 4]) <= 0)
				{
					break;
				}
				num2 = (short)1829961728;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_135:
			A_0 = (ushort)(A_0 << 6);
			A_1 ^= A_0;
			A_0 = (ushort)(A_0 << 1);
			A_1 ^= A_0;
			return A_1;
			IL_1C:
			A_0 = ((A_0 ^ (A_1 & 255)) & 255);
			A_1 = (ushort)(A_1 >> 8);
			num2 = (short)696844289;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000917C File Offset: 0x0000737C
		public bool Select(int hSession)
		{
			switch (0)
			{
			case 0:
				goto IL_6C;
			}
			int num;
			short num2;
			int num4;
			int num6;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1444624642;
					short num3 = num2;
					num2 = (short)1231042818;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2E6;
					default:
						num2 = (short)1044447232;
						if (num2 != 0)
						{
						}
						num2 = (short)1771044885;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_8B;
				case 2:
					if (this.e == 24)
					{
						num2 = (short)880541703;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8B;
				case 3:
					global::RMIBtnWrapperLib.TMEXAPI.TMOneWireCom(hSession, 0, 1);
					num2 = (short)1512439817;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)666959878;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (num4++ >= 3)
					{
						num2 = (short)2029977615;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_378;
				case 6:
					if (global::RMIBtnWrapperLib.TMEXAPI.TMTouchReset(hSession) == 1)
					{
						num2 = (short)372047872;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1FE;
				case 7:
					global::RMIBtnWrapperLib.IBtnCommon.h[0] = global::System.Convert.ToByte(global::RMIBtnWrapperLib.TMEXAPI.TMOneWireCom(hSession, 1, 0) == 1);
					num2 = (short)994181121;
					if (num2 != 0)
					{
					}
					num2 = (short)481689617;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1519321098;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_1FE;
				case 10:
					if (global::RMIBtnWrapperLib.IBtnCommon.h[0] > 0)
					{
						num2 = (short)1670840338;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8B;
				case 11:
					goto IL_2E6;
				case 12:
				{
					num2 = (short)1900871680;
					short num5 = num2;
					num2 = (short)2138177541;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
					if (num6 != 1)
					{
						num2 = (short)1343946764;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14B;
				case 14:
					if (num6 == 0)
					{
						num2 = (short)2033778707;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 15:
					goto IL_14B;
				case 16:
					goto IL_378;
				case 17:
					if (num6 != 1)
					{
						num2 = (short)893059080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)642187286;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					global::RMIBtnWrapperLib.TMEXAPI.TMOneWireCom(hSession, 0, 0);
					num2 = (short)1668284427;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					result = false;
					num2 = (short)1313865748;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					return result;
				case 21:
					if (global::RMIBtnWrapperLib.TMEXAPI.TMTouchByte(hSession, 60) == 60)
					{
						num2 = (short)252313603;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1FE;
				case 22:
					if (global::RMIBtnWrapperLib.IBtnCommon.h[0] == 0)
					{
						num2 = (short)1137836036;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14B;
				}
				goto IL_6C;
				IL_8B:
				num2 = (short)1724841997;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_14B:
				num2 = (short)1034551310;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1FE:
				num6 = 0;
				num2 = (short)1346174977;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_378:
				num6 = (int)global::RMIBtnWrapperLib.TMEXAPI.TMStrongAccess(hSession, global::RMIBtnWrapperLib.IBtnCommon.g);
				num2 = (short)813957122;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2E6:
				goto IL_8B;
			}
			return result;
			IL_6C:
			result = true;
			num6 = 0;
			num4 = 0;
			num2 = (short)1601044496;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00009590 File Offset: 0x00007790
		public bool EraseScratchSHA(int hSession)
		{
			short num = (short)814678016;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				byte[] array;
				short num3;
				bool result;
				for (;;)
				{
					IL_28:
					int num4;
					int num5;
					int num6;
					switch (num2)
					{
					case 0:
						num = (short)205127681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if ((array[(int)(num3 - 1)] & 240) == 160)
						{
							num = (short)677117966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						if (global::RMIBtnWrapperLib.IBtnCommon.h[0] <= 0)
						{
							num = (short)195362823;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1371996176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return result;
					case 4:
						goto IL_178;
					case 5:
						goto IL_178;
					case 6:
						num = (short)1798701057;
						if (num != 0)
						{
						}
						num = (short)1795096578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1234173963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1171849231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (global::RMIBtnWrapperLib.TMEXAPI.TMBlockStream(hSession, array, num3) == num3)
						{
							num = (short)2092236808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 10:
						if (this.Select(hSession))
						{
							num = (short)710279174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 11:
						num4 = 2;
						goto IL_2CA;
					case 12:
					{
						if (num5 >= 2 + num6)
						{
							num = (short)977862669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2 = array;
						short num7 = num3;
						num3 = num7 + 1;
						array2[(int)num7] = 255;
						num5++;
						num = (short)1219690500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num = (short)1518141449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_2AA;
					case 15:
					{
						if ((array[(int)(num3 - 1)] & 240) == 80)
						{
							goto IL_2AA;
						}
						num = (short)333713606;
						short num8 = num;
						num = (short)1880363206;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2AA;
						default:
							num = (short)1328414720;
							if (num != 0)
							{
							}
							num = (short)434700288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 16:
					{
						num = (short)1893269504;
						short num9 = num;
						num4 = 6;
						goto IL_2CA;
					}
					}
					goto IL_73;
					IL_178:
					num = (short)1518796812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AA:
					result = true;
					num = (short)2023358467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CA:
					num6 = num4;
					byte[] array3 = array;
					short num10 = num3;
					num3 = num10 + 1;
					array3[(int)num10] = 195;
					num5 = 0;
					num = (short)2131034117;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_73:
				array = new byte[50];
				num3 = 0;
				result = false;
				num = (short)2065563658;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000990C File Offset: 0x00007B0C
		public bool ReadScratch(int hSession, ref ushort address, ref byte es, out byte[] data)
		{
			short num = (short)582287360;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_98;
				}
				bool result;
				byte[] array;
				short num6;
				for (;;)
				{
					IL_29:
					int num4;
					ushort num5;
					switch (num2)
					{
					case 0:
						num = (short)487391238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						result = true;
						num = (short)1815543830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1764537983;
						short num3 = num;
						num = (short)33011327;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_33F;
						default:
							num = (short)1551106048;
							if (num != 0)
							{
							}
							goto IL_267;
						}
						break;
					}
					case 3:
						goto IL_33F;
					case 4:
						if (num4 >= 32)
						{
							num = (short)438435860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						data[num4] = array[4 + num4];
						num4++;
						num = (short)1726611477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)2138243073;
						if (num != 0)
						{
						}
						if (num5 == 45057)
						{
							num = (short)115605529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 6:
						if (global::RMIBtnWrapperLib.TMEXAPI.TMBlockStream(hSession, array, num6) == num6)
						{
							num = (short)1217003533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 7:
						goto IL_267;
					case 8:
						goto IL_38A;
					case 9:
						goto IL_22A;
					case 10:
						goto IL_EA;
					case 11:
						num = (short)322895877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						return result;
					case 13:
					{
						num = (short)217645056;
						short num7 = num;
						address = global::System.Convert.ToUInt16((int)array[2] << 8 | (int)array[1]);
						es = array[3];
						data = new byte[32];
						num = (short)2109276183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (num4 >= (int)num6)
						{
							num = (short)1894842379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = this.a((ushort)array[num4], num5);
						num4++;
						num = (short)710934530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (num4 >= 32)
						{
							num = (short)632094721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						data[num4] = array[4 + num4];
						num4++;
						num = (short)820445194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						byte[] array2 = array;
						short num8 = num6;
						num6 = num8 + 1;
						array2[(int)num8] = 170;
						num4 = 0;
						num = (short)1575813128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_38A;
					case 18:
					{
						if (num4 >= 37)
						{
							num = (short)1092550656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array3 = array;
						short num9 = num6;
						num6 = num9 + 1;
						array3[(int)num9] = 255;
						num4++;
						num = (short)2028208145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (this.Select(hSession))
						{
							num = (short)962789392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 20:
						result = true;
						num = (short)1156841484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_22A;
					case 22:
						return result;
					case 23:
						if (this.e == 24)
						{
							num = (short)1068236803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = 0;
						num = (short)1471414281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_EA;
					case 25:
						num4 = 0;
						num = (short)466616344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_98;
					IL_EA:
					num = (short)284622863;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22A:
					num = (short)1647181828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_267:
					num = (short)1392443406;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33F:
					num5 = 0;
					num4 = 0;
					num = (short)12124167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38A:
					num = (short)635240466;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_98:
				result = false;
				num6 = 0;
				array = new byte[50];
				data = null;
				num = (short)1610743827;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00009DEC File Offset: 0x00007FEC
		public bool WriteScratch(int hSession, ushort address, byte[] data, int data_len)
		{
			short num = (short)280559616;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_92;
				}
				byte[] array;
				short num4;
				bool result;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						int num3;
						if (num3 >= 31 - ((int)address + data_len - 1 & 31))
						{
							num = (short)863633415;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[(int)num4] = byte.MaxValue;
						byte[] array2 = array;
						short num5 = num4;
						num4 = num5 + 1;
						ushort num6 = this.a(array2[(int)num5], num6);
						num3++;
						goto IL_450;
					}
					case 1:
						num = (short)35520524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return result;
					case 3:
						goto IL_33A;
					case 4:
					{
						byte[] array3 = array;
						short num7 = num4;
						num4 = num7 + 1;
						array3[(int)num7] = 255;
						byte[] array4 = array;
						short num8 = num4;
						num4 = num8 + 1;
						array4[(int)num8] = 255;
						num = (short)589627405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						int num9 = (int)(num4 - 2);
						num = (short)1770389507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_379;
					case 7:
					{
						num = (short)898629632;
						short num10 = num;
						num = (short)1673330704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						int num9;
						if (num9 >= (int)num4)
						{
							num = (short)1638531073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num6 = this.a((ushort)array[num9], num6);
						num9++;
						num = (short)558039054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (global::RMIBtnWrapperLib.TMEXAPI.TMBlockStream(hSession, array, num4) == num4)
						{
							num = (short)848101399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 10:
					{
						int num11;
						if (num11 >= data_len)
						{
							num = (short)316801046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[(int)num4] = data[num11];
						byte[] array5 = array;
						short num12 = num4;
						num4 = num12 + 1;
						ushort num6 = this.a(array5[(int)num12], num6);
						num11++;
						num = (short)1474101269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_379;
					case 12:
					{
						num = (short)1266508151;
						short num13 = num;
						num = (short)1015112055;
						switch ((num13 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_450;
						default:
						{
							num = (short)1743781888;
							if (num != 0)
							{
							}
							ushort num6;
							if (num6 == 45057)
							{
								num = (short)307232788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						}
						break;
					}
					case 13:
						num = (short)1626996737;
						if (num != 0)
						{
						}
						goto IL_111;
					case 14:
						goto IL_33A;
					case 15:
					{
						ushort num6 = 0;
						array[(int)num4] = 15;
						byte[] array6 = array;
						short num14 = num4;
						num4 = num14 + 1;
						num6 = this.a(array6[(int)num14], num6);
						array[(int)num4] = (byte)(address & 255);
						byte[] array7 = array;
						short num15 = num4;
						num4 = num15 + 1;
						num6 = this.a(array7[(int)num15], num6);
						array[(int)num4] = (byte)(address >> 8 & 255);
						byte[] array8 = array;
						short num16 = num4;
						num4 = num16 + 1;
						num6 = this.a(array8[(int)num16], num6);
						int num11 = 0;
						num = (short)213516305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (this.e == 24)
						{
							num = (short)1054474244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_111;
					case 17:
						goto IL_2DB;
					case 18:
						if (this.Select(hSession))
						{
							num = (short)402194447;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 19:
						return result;
					case 20:
						result = true;
						num = (short)997982210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_2DB;
					case 22:
					{
						int num3 = 0;
						num = (short)1355350022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						num = (short)1508966424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (this.e == 24)
						{
							num = (short)553254917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						num = (short)636289043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_92;
					IL_111:
					num = (short)622460937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DB:
					num = (short)1377370122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33A:
					num = (short)371982344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_379:
					num = (short)790888448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_450:
					num = (short)2046951435;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_92:
				array = new byte[50];
				num4 = 0;
				result = false;
				num = (short)1934295058;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000A31C File Offset: 0x0000851C
		public bool CopyScratch(int hSession, ushort address, int len)
		{
			short num = (short)926351360;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1478033408;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_AE;
				}
				bool result;
				byte[] array;
				short num5;
				for (;;)
				{
					IL_4F:
					int num4;
					int num6;
					int num7;
					switch (num2)
					{
					case 0:
						num4 = 2;
						goto IL_43F;
					case 1:
						if (global::RMIBtnWrapperLib.IBtnCommon.h[0] <= 0)
						{
							num = (short)1217003536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2077425669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return result;
					case 3:
						if (global::RMIBtnWrapperLib.TMEXAPI.TMBlockStream(hSession, array, num5) == num5)
						{
							num = (short)1564672012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						goto IL_148;
					case 5:
						num4 = 4;
						goto IL_43F;
					case 6:
						goto IL_148;
					case 7:
						if (this.Select(hSession))
						{
							num = (short)2145779731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 8:
						goto IL_30C;
					case 9:
						num = (short)1274150923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1155137550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if ((array[(int)(num5 - 1)] & 240) == 160)
						{
							num = (short)379518984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 12:
						num = (short)1107034113;
						if (num != 0)
						{
						}
						result = true;
						num = (short)604504066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						if (num6 >= num7)
						{
							num = (short)271319050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2 = array;
						short num8 = num5;
						num5 = num8 + 1;
						array2[(int)num8] = 255;
						num6++;
						num = (short)1842413572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (global::RMIBtnWrapperLib.TMEXAPI.TMBlockStream(hSession, array, num5) == num5)
						{
							num = (short)1316290575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 15:
						num = (short)1580400660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)387055616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (this.e == 24)
						{
							num = (short)208470034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1690566659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)2093744129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						for (;;)
						{
							num = (short)244703610;
							short num9 = num;
							num = (short)457695610;
							switch ((num9 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_3A5;
							}
						}
						IL_3A5:
						num = (short)1900478464;
						if (num != 0)
						{
						}
						byte[] array3 = array;
						short num10 = num5;
						num5 = num10 + 1;
						array3[(int)num10] = 85;
						byte[] array4 = array;
						short num11 = num5;
						num5 = num11 + 1;
						array4[(int)num11] = (byte)(address & 255);
						byte[] array5 = array;
						short num12 = num5;
						num5 = num12 + 1;
						array5[(int)num12] = (byte)(address >> 8 & 255);
						byte[] array6 = array;
						short num13 = num5;
						num5 = num13 + 1;
						array6[(int)num13] = global::System.Convert.ToByte((int)address + len - 1 & 31);
						num = (short)566951953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if ((array[(int)(num5 - 1)] & 240) != 80)
						{
							num = (short)789118985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30C;
					case 21:
						return result;
					}
					goto IL_AE;
					IL_148:
					num = (short)2119499789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30C:
					result = true;
					num = (short)152698901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43F:
					num7 = num4;
					num6 = 0;
					num = (short)76087302;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_AE:
				num5 = 0;
				array = new byte[80];
				result = false;
				num = (short)2028470279;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000A78C File Offset: 0x0000898C
		internal int a(int A_0, uint A_1)
		{
			short num = (short)1276903424;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				byte addrLSB;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_107;
					case 1:
						goto IL_212;
					case 2:
						goto IL_129;
					case 3:
						num = (short)1420230666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_1F1;
					case 5:
						goto IL_278;
					case 6:
						goto IL_14A;
					case 7:
						goto IL_296;
					case 8:
					{
						num = (short)1227449417;
						short num3 = num;
						num = (short)1146315849;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_25F;
						default:
							goto IL_19F;
						}
						break;
					}
					case 9:
						switch (A_1)
						{
						case 8U:
							addrLSB = 96;
							num = (short)549388294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9U:
							addrLSB = 100;
							goto IL_25F;
						case 10U:
							num = (short)1815019521;
							if (num != 0)
							{
							}
							addrLSB = 104;
							num = (short)1950679051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11U:
							addrLSB = 108;
							num = (short)2087059463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12U:
							addrLSB = 112;
							num = (short)596901890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13U:
							addrLSB = 116;
							num = (short)278396932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14U:
							addrLSB = 120;
							num = (short)1070989312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15U:
							addrLSB = 124;
							num = (short)2012938248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
						{
							num = (short)1004208128;
							short num4 = num;
							num = (short)2060910595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					case 10:
						addrLSB = 96;
						num = (short)2019426305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_25A;
					}
					goto IL_5E;
					IL_25F:
					num = (short)1760296965;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_107:
				IL_129:
				IL_14A:
				goto IL_298;
				IL_19F:
				num = (short)2097479680;
				if (num != 0)
				{
				}
				IL_1F1:
				IL_212:
				IL_25A:
				IL_278:
				IL_296:
				IL_298:
				byte[] array = new byte[4];
				byte addrMSB;
				short numBytesRequested;
				this.ReadMemoryData(A_0, addrLSB, addrMSB, numBytesRequested, array);
				return global::System.BitConverter.ToInt32(array, 0);
				IL_5E:
				addrMSB = 2;
				addrLSB = 0;
				numBytesRequested = 4;
				num = (short)1816199177;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000AA4C File Offset: 0x00008C4C
		public void GetMAPFFieldData(int hSession, ref byte[] pFieldData, short fieldStartByteOffset, short fieldLen)
		{
			int a_ = 4;
			short num = (short)32309251;
			int num2 = (int)((global::System.IntPtr)num);
			byte[] sourceArray;
			for (;;)
			{
				int num4;
				switch (num2)
				{
				case 0:
				{
					num = (short)625422302;
					short num3 = num;
					num = (short)441921502;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_77;
					default:
						goto IL_175;
					}
					break;
				}
				case 1:
					goto IL_95;
				case 2:
					goto IL_60;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 4:
					goto IL_77;
				case 5:
					if ((int)fieldStartByteOffset >= num4)
					{
						num = (short)27983872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)511115268;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_45:
				if (pFieldData == null)
				{
					num = (short)971833346;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num4 = 0;
				sourceArray = null;
				this.a(hSession, ref num4, ref sourceArray);
				num = (short)2119368709;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_77:
				if ((int)(fieldStartByteOffset + fieldLen) <= num4)
				{
					goto IL_18F;
				}
				num = (short)646447105;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_60:
			throw new global::RMIBtnWrapperLib.TMEXException(global::RMIBtnWrapperLib.TMEXException.g("얁얇쮉\udc8b좍횏ﮑ歹ﲗ\ude99ﶛ솟颡蒣욧\udca9춫슭\ud9af횱钳ힵ쪷\uddb9즻펽ꖿ곁냃", a_));
			IL_95:
			throw new global::RMIBtnWrapperLib.TMEXException(global::RMIBtnWrapperLib.TMEXException.g("\ud981삃랅릇힉겋좍憐뢗ﮝ튟킡톣좥\udba7誩钳풵ힷ쾹튻\udabdꆿ냁뷃", a_));
			IL_175:
			num = (short)1428750336;
			if (num != 0)
			{
			}
			num = (short)1516830721;
			if (num != 0)
			{
			}
			throw new global::RMIBtnWrapperLib.TMEXException(global::RMIBtnWrapperLib.TMEXException.g("\ud981삃랅릇힉겋좍憐뢗ﾝ튟횡蒣쒥톧\udea9즫횯풱잳펵첷骹펻쮽뒿뇁귃ꋅ귇臋迍胏铑듕럗꿙닛뫝臟郡鷣죥", a_));
			IL_18F:
			num = (short)28901376;
			short num5 = num;
			global::System.Array.Copy(sourceArray, (int)fieldStartByteOffset, pFieldData, 0, (int)fieldLen);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000AC20 File Offset: 0x00008E20
		private void a(int A_0, ref int A_1, ref byte[] A_2)
		{
			int a_ = 13;
			short num = (short)1684463472;
			short num2 = num;
			num = (short)1865277296;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)595066881;
				if (num != 0)
				{
				}
				num = (short)1700593664;
				if (num != 0)
				{
				}
				num = (short)746389504;
				int num3 = (int)num;
				switch (num3)
				{
				}
				break;
			}
			}
			A_2 = null;
			A_1 = 0;
			byte[] array = new byte[40];
			array[0] = 77;
			array[1] = 65;
			array[2] = 80;
			array[3] = 70;
			array[4] = 0;
			short hFile = -1;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_E7;
				}
				int num3;
				for (;;)
				{
					IL_CC:
					switch (num3)
					{
					case 0:
						goto IL_1E2;
					case 1:
						A_1 = 7057;
						num = (short)548995075;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.e == 12)
						{
							num = (short)245039105;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_1 = 420;
						num = (short)71761924;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_16B;
					case 4:
						goto IL_16B;
					}
					goto IL_E7;
					IL_16B:
					byte[] sourceArray = null;
					short num4 = (short)A_1;
					this.ReadFile(A_0, hFile, ref num4, out sourceArray);
					A_1 = (int)num4;
					byte[] a_2 = null;
					A_1 -= 6;
					byte[] array2 = new byte[A_1];
					global::System.Array.Copy(sourceArray, 6, array2, 0, A_1);
					new global::AcpCryptoLib.AcpIBtnEncyptDecrpt().Decrypt(array2, out a_2);
					A_2 = new byte[58];
					global::System.Array.Copy(sourceArray, A_2, 6);
					this.a(A_2, a_2, ref A_1);
					num = (short)1588527104;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1E2:
				goto IL_207;
				IL_E7:
				this.OpenFile(A_0, out hFile, array, false);
				A_1 = 0;
				num = (short)1006567426;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_CC;
			}
			catch (global::RMIBtnWrapperLib.TMEXException innerException)
			{
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쾌搜杖練릘풚爵삠톢톤캦욨얪趬쎰솲\udab4얶鞸鮺\udabe꓀賄꧆ꟈ껊뿌諎꧐냒냔Ꟗ귘닚닜뇞쇠藢諤闦짨迪裬鯮郰髲駴蓶", a_), innerException);
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			finally
			{
				this.CloseFile(A_0, ref hFile);
			}
			IL_207:
			num = (short)1664679936;
			short num5 = num;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000AEAC File Offset: 0x000090AC
		private void a(byte[] A_0, byte[] A_1, ref int A_2)
		{
			int a_ = 2;
			short num = (short)47906825;
			int num2 = (int)((global::System.IntPtr)num);
			int num3;
			int num4;
			for (;;)
			{
				int num6;
				switch (num2)
				{
				case 0:
					goto IL_19A;
				case 1:
					goto IL_D2;
				case 2:
					goto IL_19A;
				case 3:
					num = (short)9502730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_195;
				case 5:
					A_0[num3] = ~A_1[num4];
					num = (short)232062978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)1854930944;
					short num5 = num;
					num = (short)218824705;
					if (num != 0)
					{
					}
					if (num6 >= 8)
					{
						num = (short)1438777352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1709244427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					goto IL_D2;
				case 8:
					goto IL_15A;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 10:
					if (A_1 == null)
					{
						num = (short)824639492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					A_2 = 0;
					num3 = 6;
					num4 = global::RMIBtnWrapperLib.TMEXException.g("힁쪃", a_).Length;
					num6 = 0;
					num = (short)1707671559;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					num = (short)1063600423;
					short num7 = num;
					num = (short)1367359783;
					switch ((num7 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_60;
					default:
						num = (short)1006370816;
						if (num != 0)
						{
						}
						if (num6 == 5)
						{
							num = (short)148307973;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_0[num3] = A_1[num4];
						num = (short)523370496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_5D;
				IL_60:
				num = (short)2098069507;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5D:
				if (A_0 != null)
				{
					goto IL_60;
				}
				break;
				IL_D2:
				num = (short)1392312326;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_19A:
				num6++;
				num3++;
				num4++;
				num = (short)1526595585;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BE:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쥿꺍ﾙ袟톡趣螥", a_));
			IL_15A:
			A_0[num3++] = A_1[num4++];
			num4 += global::RMIBtnWrapperLib.TMEXException.g("셿嬨얃", a_).Length;
			A_0[num3++] = A_1[num4++];
			global::System.Array.Copy(A_1, num4, A_0, num3, 10);
			num3 += 10;
			num4 += 10;
			global::System.Array.Copy(A_1, num4, A_0, num3, 8);
			num3 += 8;
			A_2 = num3;
			return;
			IL_195:
			goto IL_BE;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000B194 File Offset: 0x00009394
		private void a(int A_0, byte[] A_1, byte[] A_2, string A_3, string A_4)
		{
			int a_ = 4;
			short num = (short)988807168;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C1;
				}
				byte[] romserialNum;
				int num3;
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
						if (romserialNum != null)
						{
							num = (short)1095172115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_67C;
					case 1:
						goto IL_421;
					case 2:
						goto IL_4CF;
					case 3:
						num = (short)1318322177;
						if (num != 0)
						{
						}
						goto IL_3BE;
					case 4:
						goto IL_20B;
					case 5:
					{
						if (num3 == 5)
						{
							num = (short)2086010906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4;
						A_1[num4++] = romserialNum[num3];
						num = (short)92995616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_172;
					case 7:
						return;
					case 8:
						goto IL_63F;
					case 9:
						goto IL_63F;
					case 10:
						goto IL_4CF;
					case 11:
						goto IL_109;
					case 12:
					{
						if (num3 >= 10)
						{
							num = (short)1564803105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4;
						A_1[num4++] = 32;
						num3++;
						num = (short)1739390978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						int num5;
						if (num3 >= num5)
						{
							num = (short)1435303963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1712062464;
						short num6 = num;
						int num4;
						byte[] bytes;
						A_1[num4++] = bytes[num3];
						num3++;
						num = (short)1888616449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_20B;
					case 15:
					{
						int num4;
						A_1[num4++] = 32;
						num = (short)444727312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_45D;
					case 17:
						num = (short)1766981643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_45D;
					case 19:
					{
						int num4 = 0;
						int num5 = global::RMIBtnWrapperLib.TMEXException.g("톃종", a_).Length;
						global::System.Array.Copy(global::System.Text.Encoding.UTF8.GetBytes(global::RMIBtnWrapperLib.TMEXException.g("톃종", a_)), A_1, num5);
						num4 += num5;
						num3 = 0;
						num = (short)1163198467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						int num7;
						if (num3 >= num7)
						{
							num = (short)949485575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)370737180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						int num4;
						A_1[num4++] = A_2[0];
						int num5 = global::RMIBtnWrapperLib.TMEXException.g("쎁ﲃ입", a_).Length;
						global::System.Array.Copy(global::System.Text.Encoding.UTF8.GetBytes(global::RMIBtnWrapperLib.TMEXException.g("쎁ﲃ입", a_)), 0, A_1, num4, num5);
						num4 += num5;
						A_1[num4++] = A_2[1];
						byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(A_3);
						byte[] bytes2 = global::System.Text.Encoding.UTF8.GetBytes(A_4);
						num5 = bytes.Length;
						num3 = 0;
						num = (short)1400045590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_421;
					case 23:
						goto IL_3BE;
					case 24:
					{
						if (num3 >= 8)
						{
							num = (short)159580181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1390766633;
						short num8 = num;
						num = (short)125397545;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_621;
						default:
							num = (short)747962368;
							if (num != 0)
							{
							}
							num = (short)1836056581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 25:
						goto IL_109;
					case 26:
					{
						int num4;
						A_1[num4++] = ~romserialNum[num3];
						num = (short)594345990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						num = (short)158990346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
					{
						if (num3 % 3 == 0)
						{
							goto IL_621;
						}
						int num4;
						A_1[num4++] = 3;
						num = (short)1296171026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
					{
						int num4;
						int num7 = 58 - (num4 + 6);
						num3 = 0;
						num = (short)864944132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
					{
						int num5;
						if (num3 >= num5)
						{
							num = (short)688128017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4;
						byte[] bytes2;
						A_1[num4++] = bytes2[num3];
						num3++;
						num = (short)1719074825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						if (num3 >= 8)
						{
							num = (short)1903362077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4;
						A_1[num4++] = 32;
						num3++;
						num = (short)3670041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						goto IL_172;
					case 33:
					{
						byte[] bytes2;
						int num5 = bytes2.Length;
						num3 = 0;
						num = (short)233504776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_C1;
					IL_109:
					num = (short)750845983;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_172:
					num3++;
					num = (short)63897623;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20B:
					num = (short)1822097428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BE:
					num = (short)1707606040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_421:
					num = (short)237240333;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45D:
					num3++;
					num = (short)133431310;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CF:
					num = (short)592510988;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_621:
					num = (short)1147928591;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_63F:
					num = (short)946274334;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_67C:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("욁꺍쎏ﾕ聯벛킝햟쾡욣쎥\udaa7誩쾫솭얯\udeb1킳隵횷햹좻麽ꊿꟁ듅귇ꯉ꣋", a_));
				IL_C1:
				num3 = 0;
				romserialNum = this.GetROMSerialNum(A_0, true);
				num = (short)1285947392;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000B830 File Offset: 0x00009A30
		public void WriteMapfFile(int hSession, byte[] version, byte[] communityCode, string userid, string password, string authCode)
		{
			int a_ = 13;
			short num = (short)1529479168;
			switch (num)
			{
			default:
			{
				num = (short)330235905;
				if (num != 0)
				{
				}
				num = (short)1068892162;
				int num2 = (int)((global::System.IntPtr)num);
				int num4;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)148242432;
						short num3 = num;
						num4 = 52;
						num = (short)362545153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_E5;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					}
					IL_81:
					if (!this.a(authCode))
					{
						goto IL_E7;
					}
					num = (short)936050688;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E5:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_134;
					}
					int num5;
					byte[] array2;
					for (;;)
					{
						IL_105:
						switch (num2)
						{
						case 0:
						{
							byte[] array;
							if (array.Length + 6 > 58)
							{
								num = (short)591396866;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.a(hSession, array, num4, version);
							num = (short)639041545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							if (num5 >= array2.Length)
							{
								num = (short)1192230919;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)755823791;
							short num6 = num;
							num = (short)1275458735;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_255;
							default:
								num = (short)1574371328;
								if (num != 0)
								{
								}
								array2[num5] = 0;
								num5++;
								num = (short)61800451;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_292;
						case 3:
							goto IL_297;
						case 4:
							goto IL_255;
						case 5:
							goto IL_2F1;
						case 6:
							goto IL_297;
						case 7:
						{
							this.a(hSession, array2, communityCode, userid, password);
							byte[] array = null;
							new global::AcpCryptoLib.AcpIBtnEncyptDecrpt().Encrypt(array2, out array);
							num = (short)473169928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							byte[] array;
							if (array != null)
							{
								num = (short)1603928068;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2D7;
						}
						case 9:
							goto IL_2D7;
						}
						goto IL_134;
						IL_255:
						num = (short)735772672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_297:
						num = (short)440401921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2D7:
						num = (short)1010106373;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_292:
					throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("캊ﲘﾚ붜튞薤좨\udfaa첬辮\ud8b0삲閴쎶횸鮺톼\udebe돀꓂ꃄ뷈꓊꧎룐꟒ꏖ뇘뻚﷜鋞ꃠ돢엤臦胨蟪裬", a_));
					IL_2F1:
					return;
					IL_134:
					array2 = new byte[num4];
					num5 = 0;
					num = (short)1211236358;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_105;
				}
				catch (global::RMIBtnWrapperLib.TMEXException innerException)
				{
					throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쾌搜杖練릘풚爵펠슢톤캦욨얪趬쎰솲\udab4얶馸隺鶼첾꓀ꛂ軆ꟈꗊ꣌뷎铐ꯒ뛔닖꧘꿚드냞迠쏢菤裦鯨쯪觬諮藰鋲鳴鯶諸", a_), innerException);
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
				return;
				IL_E7:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("킊즌붎ꎐ캒떔횖滛튠莢톤좦覨ﾮ鎲펴\udeb6햸\udeba鶼횾닀럄ꋆ뫈뿊뿌ꛎ닐꟒냔돖", a_));
			}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000BB80 File Offset: 0x00009D80
		private bool a(string A_0)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1096576396;
					short num3 = num2;
					num2 = (short)191917452;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1298726912;
						if (num2 != 0)
						{
						}
						result = true;
						num2 = (short)472449025;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_FE;
				case 2:
					if (string.Compare(global::RMIBtnWrapperLib.TMEXException.g("펏ꎑ횓힕\ude97\ud899\udd9b꺝\ud89f삡슣钥龫蒯킱ힳ薵\ud9b7誹쒻誽ꊿ꓁ꇃￅ談裉軋ﻍ闏뇑럕맛ꗝ탟髡ퟣ틥\ud9e7ꯩ\uddeb훭뗯쏱샳쇵죷苹黻鿽替态㴃搅", a_), A_0) == 0)
					{
						num2 = (short)1927086080;
						short num4 = num2;
						num2 = (short)2059206656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_25;
			}
			IL_FE:
			num2 = (short)1309933569;
			if (num2 != 0)
			{
			}
			return result;
			IL_25:
			result = false;
			num2 = (short)507838466;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		private void a(int A_0, byte[] A_1, int A_2, byte[] A_3)
		{
			int a_ = 9;
			short num = (short)1643839488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)2012217344;
				short num3 = num;
				num = (short)211550209;
				if (num != 0)
				{
				}
				short num4 = -1;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_A3;
					}
					byte[] array;
					int num6;
					for (;;)
					{
						IL_88:
						switch (num2)
						{
						case 0:
						{
							global::System.Array.Copy(A_3, array, 6);
							int destinationIndex = 6;
							global::System.Array.Copy(A_1, 0, array, destinationIndex, A_2);
							byte[] array2 = new byte[40];
							array2[0] = 77;
							array2[1] = 65;
							array2[2] = 80;
							array2[3] = 70;
							array2[4] = 0;
							short num5 = 58;
							this.CreateFile(A_0, out num4, array2, out num5);
							this.WriteFile(A_0, num4, array, 58);
							num = (short)1031798786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							if (num6 >= array.Length)
							{
								num = (short)1406402560;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)627666884;
							short num7 = num;
							num = (short)741633988;
							switch ((num7 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_135;
							default:
								num = (short)1029701632;
								if (num != 0)
								{
								}
								array[num6] = 0;
								num6++;
								num = (short)1554382851;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_1DB;
						case 3:
							goto IL_135;
						case 4:
							goto IL_137;
						}
						goto IL_A3;
						IL_137:
						num = (short)1474560001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_135:
						goto IL_137;
					}
					IL_1DB:
					return;
					IL_A3:
					array = new byte[58];
					num6 = 0;
					num = (short)804978692;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_88;
				}
				catch (global::RMIBtnWrapperLib.TMEXException innerException)
				{
					throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쮈ﺊ歷ﮎﺐﶒ떔\ud896ﺚﺞ햠쪢쪤즦覨\udfac\uddae\udeb0솲閴骶馸좺\ud8bc\udabe諂ꯄ꧆곈맊裌럎닐뛒ꗔꏖ냘듚돜￞蟠賢韤쟦跨軪駬軮飰鿲蛴", a_), innerException);
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
				finally
				{
					num = (short)1553465346;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							this.CloseFile(A_0, ref num4);
							num = (short)1965490177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_267;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_22C;
							}
							continue;
						}
						IL_22C:
						if (num4 == -1)
						{
							break;
						}
						num = (short)2109800448;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_267:;
				}
				return;
			}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000BF7C File Offset: 0x0000A17C
		public byte[] LoadFileName(string fileName)
		{
			int a_ = 19;
			short num = (short)1481048064;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				string text;
				string text2;
				char[] separator;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						num = (short)241500160;
						short num3 = num;
						num = (short)1379926027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (text.Length <= 4)
						{
							num = (short)1420623872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B9;
					case 2:
					{
						string[] array;
						if (array.Length != 2)
						{
							num = (short)661979142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = array[0];
						text2 = array[1];
						num = (short)437387273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)891617281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (text2.Length > 3)
						{
							num = (short)852623367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)77201413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_2C5;
					case 6:
						goto IL_17A;
					case 7:
						goto IL_386;
					case 8:
					{
						string text3 = fileName.ToUpper();
						if (text3.CompareTo(global::RMIBtnWrapperLib.TMEXException.g("캐힒\ud994\udb96래ꊚ꒜", a_)) == 0)
						{
							goto Block_1;
						}
						string[] array = text3.Split(separator);
						num = (short)2123235330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (text.Length >= 1)
						{
							num = (short)361234435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B9;
					case 10:
						num = (short)1142292484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (text2.Length >= 1)
						{
							num = (short)21692426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B9;
					}
					goto IL_68;
				}
				Block_1:
				goto IL_298;
				IL_B9:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\ud890ﶒ列뾞잠쪢즤슦覨얪첬슮풰", a_));
				IL_17A:
				num = (short)656080897;
				if (num != 0)
				{
				}
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\ud890ﶒ列뾞잠쪢즤슦覨얪첬슮풰", a_));
				IL_298:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쪐힒ꞔꞖ쒘뮚슜\udb9e认麦邨讪쒬\udcae醰튲閴얶\udcb8좺\ud8bc춾럀ꛂꇄ꿈ꋊꇌ꫎뷒듔뫖볘", a_));
				IL_2C5:
				byte[] array2;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_1A4;
					}
					int num4;
					for (;;)
					{
						IL_189:
						switch (num2)
						{
						case 0:
							array2[4] = byte.Parse(text2);
							num = (short)702283778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							if (num4 >= 4)
							{
								num = (short)276299776;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)595246312;
							short num5 = num;
							num = (short)1978776808;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_233;
							default:
								num = (short)1146224640;
								if (num != 0)
								{
								}
								array2[num4] = (byte)text[num4];
								num4++;
								num = (short)1473314819;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_292;
						case 3:
							goto IL_233;
						case 4:
							goto IL_235;
						}
						goto IL_1A4;
						IL_235:
						num = (short)1771765761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_233:
						goto IL_235;
					}
					IL_292:
					return array2;
					IL_1A4:
					num4 = 0;
					num = (short)88145924;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_189;
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
				goto IL_298;
				IL_386:
				goto IL_B9;
				IL_68:
				array2 = new byte[40];
				text = null;
				text2 = null;
				separator = new char[]
				{
					'.'
				};
				num = (short)1150222344;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000C380 File Offset: 0x0000A580
		public void GetNumDaysLeft(int hSession, global::RMIBtnWrapperLib.TimerType t_type, ref short pNumDaysLeft)
		{
			int a_ = 17;
			short num = (short)46268416;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_54;
				}
				for (;;)
				{
					IL_31:
					int num7;
					switch (num2)
					{
					case 0:
						num = (short)211091457;
						if (num != 0)
						{
						}
						try
						{
							switch (0)
							{
							case 0:
								goto IL_B5;
							}
							uint num4;
							int num5;
							for (;;)
							{
								IL_96:
								switch (num2)
								{
								case 0:
								{
									decimal num3 = num4 / 86400m;
									pNumDaysLeft = (short)global::System.Math.Round(num3, 1, global::System.MidpointRounding.AwayFromZero);
									num = (short)2228227;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									if (num4 >= 86400U)
									{
										goto IL_1B1;
									}
									goto IL_20E;
								case 2:
									goto IL_227;
								case 3:
									goto IL_20E;
								case 4:
								{
									num4 -= (uint)num5;
									num = (short)429614626;
									short num6 = num;
									num = (short)1966892578;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1B1;
									default:
										num = (short)353370112;
										if (num != 0)
										{
										}
										num = (short)1509359617;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									if (num4 - (uint)num5 >= 86400U)
									{
										num = (short)607584260;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_20E;
								}
								goto IL_B5;
								IL_1B1:
								num = (short)1657864192;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_20E:
								num = (short)978780162;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_227:
							return;
							IL_B5:
							global::RMIBtnWrapperLib.RegisterType a_2;
							this.a(hSession, a_2, ref num7);
							int num8 = 0;
							global::RMIBtnWrapperLib.RegisterType a_3;
							this.a(hSession, a_3, ref num8);
							num4 = (uint)(num7 - num8);
							global::System.DateTime now = global::System.DateTime.Now;
							num5 = 86400 - (now.Hour * 60 * 60 + now.Minute * 60 + now.Second);
							num = (short)218693637;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_96;
						}
						catch (global::RMIBtnWrapperLib.TMEXException innerException)
						{
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("펐붜킞토욢힤욦\udda8슪슬솮醰잴얶횸즺鎼龾鋀ꛂꃄ胈ꗊꏌ꫎ꏐ雒귔듖볘ꯚ꧜뛞軠跢엤臦蛨駪췬诮铰蟲铴黶闸裺", a_), innerException);
						}
						catch (global::System.Exception ex)
						{
							throw ex;
						}
						goto IL_245;
					case 1:
					{
						global::RMIBtnWrapperLib.RegisterType a_2 = global::RMIBtnWrapperLib.RegisterType.IntervalAlarm;
						global::RMIBtnWrapperLib.RegisterType a_3 = global::RMIBtnWrapperLib.RegisterType.IntervalCntr;
						num = (short)2033254403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (t_type == global::RMIBtnWrapperLib.TimerType.interval)
						{
							num = (short)45416449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30E;
					case 3:
						goto IL_245;
					case 4:
						goto IL_245;
					case 5:
					{
						global::RMIBtnWrapperLib.RegisterType a_2 = global::RMIBtnWrapperLib.RegisterType.RTCAlarm;
						global::RMIBtnWrapperLib.RegisterType a_3 = global::RMIBtnWrapperLib.RegisterType.RTCCntr;
						num = (short)1218772996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						if (t_type == global::RMIBtnWrapperLib.TimerType.realTime)
						{
							num = (short)838008837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)755105792;
						short num9 = num;
						num = (short)926023682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_54;
					IL_245:
					num7 = 0;
					num = (short)1227489280;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_30E:
				throw new global::RMIBtnWrapperLib.TMEXException(global::RMIBtnWrapperLib.TMEXException.g("풎햐ꊒ겔쪖릘캚ﺞ쎠쾢삤螦\udda8쒪趬좮풰잲閴얶\udcb8\udcba풼첾뗀ꛂ럄ꃈꗊꯌꃎﻒꋖ럘꣚꣜꿞釠賢韤鏦賨迪췬믮飰黲郴藶\ud9f8迺蓼迾搀⌂瘄眆氈栊搌椎砐瘒焔㤖", a_));
				IL_54:
				pNumDaysLeft = 0;
				num = (short)1803223046;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000C704 File Offset: 0x0000A904
		private void a(int A_0, global::RMIBtnWrapperLib.RegisterType A_1, ref int A_2)
		{
			int a_ = 2;
			short num = (short)1774321664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				bool flag;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						byte b;
						b -= 1;
						byte b2;
						b2 += 1;
						byte[] array = new byte[(int)b];
						byte addrMSB;
						this.ReadMemoryData(A_0, b2, addrMSB, (short)b, array);
						int num3 = 0;
						num = (short)1187905546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_1B8;
					case 2:
						goto IL_1B3;
					case 3:
					{
						int num3;
						if (num3 >= 4)
						{
							num = (short)1236926469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						int num4 = (int)array[num3];
						num4 <<= 8 * num3;
						A_2 |= num4;
						num3++;
						num = (short)247988224;
						short num5 = num;
						num = (short)1293287431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_1B8;
					case 5:
						return;
					case 6:
					{
						if (!flag)
						{
							return;
						}
						num = (short)1751136965;
						short num6 = num;
						num = (short)2093955781;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_240;
						default:
							num = (short)147849216;
							if (num != 0)
							{
							}
							num = (short)1480458240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_240;
					case 8:
						goto IL_1B8;
					case 9:
						switch (A_1)
						{
						case global::RMIBtnWrapperLib.RegisterType.RTCCntr:
						{
							byte b = 5;
							byte b2 = 2;
							byte addrMSB = 2;
							num = (short)570753035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::RMIBtnWrapperLib.RegisterType.RTCAlarm:
						{
							byte b = 5;
							byte b2 = 16;
							byte addrMSB = 2;
							num = (short)323092481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::RMIBtnWrapperLib.RegisterType.IntervalCntr:
						{
							byte b = 5;
							byte b2 = 7;
							byte addrMSB = 2;
							num = (short)1069613064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::RMIBtnWrapperLib.RegisterType.IntervalAlarm:
						{
							byte b = 5;
							byte b2 = 21;
							byte addrMSB = 2;
							num = (short)1335492609;
							if (num != 0)
							{
							}
							num = (short)1150877700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						default:
							num = (short)1882849292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 10:
						goto IL_240;
					case 11:
						goto IL_1B8;
					case 12:
						num = (short)279117826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6C;
					IL_1B8:
					num = (short)1489305606;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_240:
					num = (short)1939013635;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B3:
				flag = false;
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\udb7f욁떃뾅햇ꪉ\ud98b뢗뺝잟잡킣蚥\udaa7쾩쮫잭쎯욱톳쒵颷펹튻\ud8bd꾿뷇꓉뿋믍ꃏꋑ믓ꓕ곗뿙룛ﻝ듟诡解菥髧쫩飫韭胯韱퓳藵裷鿹鿻韽替欁愃戅☇", a_));
				IL_6C:
				flag = true;
				A_2 = 0;
				num = (short)1531576329;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000CA28 File Offset: 0x0000AC28
		private bool a(ref global::RMIBtnWrapperLib.Cntr_Alarm A_0, global::RMIBtnWrapperLib.TimerType A_1, short A_2, char A_3)
		{
			int a_ = 11;
			short num = (short)1018560512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				bool flag;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_226;
					case 1:
						flag = this.a(A_2, A_3, ref A_0);
						num = (short)2067529733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (flag)
						{
							num = (short)930086913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 3:
					{
						double totalSeconds;
						double totalSeconds2;
						bool flag2;
						A_0.timerVal = (uint)(totalSeconds - totalSeconds2 + (double)(flag2 ? 3600 : 0));
						num = (short)968228871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						A_0.cntrRegSz = 5;
						A_0.cntrRegOffset = 7;
						A_0.alarmRegSz = 5;
						A_0.alarmRegOffset = 21;
						A_0.statusRegByte = 40;
						A_0.timerVal = 0U;
						num = (short)298057728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_2A7;
					case 6:
					{
						num = (short)253296641;
						if (num != 0)
						{
						}
						num = (short)423681240;
						short num3 = num;
						num = (short)853204184;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_124;
						default:
							num = (short)766181376;
							if (num != 0)
							{
							}
							if (A_1 == global::RMIBtnWrapperLib.TimerType.realTime)
							{
								num = (short)420872201;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)692453384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_226;
					case 8:
						goto IL_124;
					case 9:
					{
						A_0.cntrRegSz = 5;
						A_0.cntrRegOffset = 2;
						A_0.alarmRegSz = 5;
						A_0.alarmRegOffset = 16;
						A_0.statusRegByte = 48;
						global::System.DateTime now = global::System.DateTime.Now;
						global::System.DateTime value = new global::System.DateTime(1970, 1, 1);
						double totalSeconds = now.Subtract(value).TotalSeconds;
						global::System.TimeZone currentTimeZone = global::System.TimeZone.CurrentTimeZone;
						double totalSeconds2 = currentTimeZone.GetUtcOffset(now).TotalSeconds;
						bool flag2 = currentTimeZone.IsDaylightSavingTime(now);
						num = (short)1684537347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_5F;
					IL_124:
					if (A_1 == global::RMIBtnWrapperLib.TimerType.interval)
					{
						num = (short)1999568900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D5;
					IL_226:
					num = (short)1935933442;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2A7:
				num = (short)1694695424;
				short num4 = num;
				return flag;
				IL_2D5:
				flag = false;
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("튈쾊벌뢎첐뎒펔ﮞ膠힢쪤螦\udaa8캪\ud9ac辮얰\udab2\ud8b4튶쮸鮺邼龾듀귂뛄닆마믊ꋌ뷎ꗐ뛒뇔跘닚냜뫞鏠쏢雤韦賨裪蓬觮飰雲釴\ud9f6", a_));
				IL_5F:
				flag = true;
				num = (short)1666580486;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000CD24 File Offset: 0x0000AF24
		private void a(ref byte[] A_0, ref global::RMIBtnWrapperLib.Cntr_Alarm A_1, char A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num4;
			for (;;)
			{
				IL_0A:
				int num2;
				int num3;
				switch (num)
				{
				case 0:
					goto IL_1C8;
				case 1:
					if (num2 >= num3)
					{
						num4 = (short)610140160;
						short num5 = num4;
						num4 = (short)147259392;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					A_0[num2] = (byte)(A_1.alarmVal & 255U);
					A_1.alarmVal >>= 8;
					num2++;
					num4 = (short)1411383303;
					num = (int)((global::System.IntPtr)num4);
					continue;
				case 2:
					if (num2 >= num3)
					{
						num4 = (short)141819910;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					A_0[num2] = (byte)(A_1.timerVal & 255U);
					A_1.timerVal >>= 8;
					num2++;
					num4 = (short)1773862921;
					num = (int)((global::System.IntPtr)num4);
					continue;
				case 3:
					goto IL_104;
				case 4:
					goto IL_272;
				case 5:
					goto IL_272;
				case 6:
				{
					num4 = (short)621777403;
					short num6 = num4;
					num4 = (short)555782651;
					switch ((num6 == num4) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C8;
					default:
					{
						num4 = (short)1657864192;
						if (num4 != 0)
						{
						}
						short alarmRegOffset = A_1.alarmRegOffset;
						num3 = (int)(alarmRegOffset + A_1.alarmRegSz);
						num2 = (int)(alarmRegOffset + 1);
						num4 = (short)65208330;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					}
					break;
				}
				case 7:
					goto IL_169;
				case 8:
				{
					if (A_2 == 'B')
					{
						num4 = (short)1349779467;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					byte[] array = A_0;
					int num7 = 1;
					array[num7] |= 8;
					num4 = (short)16449541;
					num = (int)((global::System.IntPtr)num4);
					continue;
				}
				case 9:
					goto IL_104;
				case 10:
					goto IL_169;
				case 11:
				{
					byte[] array2 = A_0;
					int num8 = 1;
					array2[num8] &= 247;
					num4 = (short)556400644;
					num = (int)((global::System.IntPtr)num4);
					continue;
				}
				}
				goto IL_40;
				IL_104:
				num4 = (short)933363714;
				num = (int)((global::System.IntPtr)num4);
				continue;
				IL_169:
				num4 = (short)1729626113;
				num = (int)((global::System.IntPtr)num4);
				continue;
				IL_272:
				short cntrRegOffset = A_1.cntrRegOffset;
				num3 = (int)(cntrRegOffset + A_1.cntrRegSz);
				num2 = (int)(cntrRegOffset + 1);
				num4 = (short)629080067;
				num = (int)((global::System.IntPtr)num4);
			}
			IL_1C8:
			num4 = (short)588906497;
			if (num4 != 0)
			{
			}
			return;
			IL_40:
			A_0 = new byte[30];
			A_0[0] = A_1.statusRegByte;
			A_0[1] = 80;
			num4 = (short)1125580808;
			num = (int)((global::System.IntPtr)num4);
			goto IL_0A;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000CFFC File Offset: 0x0000B1FC
		private bool a(short A_0, char A_1, ref global::RMIBtnWrapperLib.Cntr_Alarm A_2)
		{
			int a_ = 18;
			short num = (short)1636171776;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				global::System.DateTime dateTime;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						dateTime = dateTime.AddDays((double)A_0);
						num = (short)828243973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						dateTime = dateTime.AddMonths((int)A_0);
						num = (short)447021059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						while (A_1 != 'D')
						{
							num = (short)947062419;
							short num3 = num;
							num = (short)741148307;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)557056001;
								if (num != 0)
								{
								}
								num = (short)1802305536;
								if (num != 0)
								{
								}
								num = (short)928186372;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_31;
							}
						}
						num = (short)548208640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_D2;
					case 4:
						if (A_1 == 'M')
						{
							num = (short)1255211009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D2;
					case 5:
						goto IL_1D0;
					}
					goto IL_50;
				}
				IL_D2:
				num = (short)1014824960;
				short num4 = num;
				IL_1D0:
				goto IL_1F3;
				IL_1D2:
				throw new global::System.Exception(string.Format(global::RMIBtnWrapperLib.TMEXException.g("\ud98fﲑ뺝풟쮡즣쎥\udaa7誩쎫좭횯솱톳습颷\udcb9펻첽궿ꏁ냃뇉ﳋ돍ꟓꛕ뷗맙뗛룝觟蟡胣죥죧곩菫鳭鷯鏱胳훵闷迹迻諽⃿态愃★䰇欉甋納』㨑㌓刕㼗㌙㰛焝刟ȡ椣䤥䘧帩䐫崭ုᨱጳ笵ἷጹ", a_), A_1));
				IL_1F3:
				global::System.DateTime now;
				uint num5 = (uint)dateTime.Subtract(now).TotalSeconds;
				A_2.alarmVal = A_2.timerVal + num5;
				return true;
				IL_50:
				now = global::System.DateTime.Now;
				dateTime = new global::System.DateTime(now.Year, now.Month, now.Day, 23, 59, 59, global::System.DateTimeKind.Local);
				num = (short)2133590018;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000D224 File Offset: 0x0000B424
		public void SetTimer(int hSession, short offset, global::RMIBtnWrapperLib.TimerType t_type, char offsetFormat, char alarmExpAction, bool bWPTimer)
		{
			int a_ = 18;
			short num = (short)338548935;
			short num2 = num;
			num = (short)1463670983;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)222560256;
				short num3 = num;
				num = (short)1404960768;
				if (num != 0)
				{
				}
				num = (short)1929838593;
				if (num != 0)
				{
				}
				num = (short)712441856;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			short num5 = 2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_11F;
				}
				int num4;
				bool flag;
				byte[] array;
				for (;;)
				{
					IL_D0:
					bool flag2;
					switch (num4)
					{
					case 0:
						goto IL_224;
					case 1:
						goto IL_262;
					case 2:
						num = (short)436142090;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_224;
					case 4:
						if (bWPTimer)
						{
							num = (short)2046165006;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C4;
					case 5:
					{
						global::RMIBtnWrapperLib.Cntr_Alarm cntr_Alarm;
						if (this.a(ref cntr_Alarm, t_type, offset, offsetFormat))
						{
							num = (short)70582288;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_210;
					}
					case 6:
						if (t_type != global::RMIBtnWrapperLib.TimerType.realTime || !flag)
						{
							num = (short)1645150210;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FC;
					case 7:
						flag2 = true;
						num = (short)761790464;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if ((array[1] & 1) > 0)
						{
							num = (short)652279821;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)755171329;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_262;
					case 10:
					{
						if (t_type == global::RMIBtnWrapperLib.TimerType.interval && flag2)
						{
							num = (short)1553334287;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::RMIBtnWrapperLib.Cntr_Alarm cntr_Alarm = default(global::RMIBtnWrapperLib.Cntr_Alarm);
						num = (short)907149317;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if ((array[1] & 2) > 0)
						{
							num = (short)1173225479;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag2 = false;
						num = (short)1969356803;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_3C4;
					case 13:
						flag = true;
						num = (short)1499463689;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						this.b(hSession, alarmExpAction);
						this.a(hSession, alarmExpAction);
						num = (short)146735116;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_3BF;
					case 16:
					{
						byte[] a_2 = new byte[30];
						global::RMIBtnWrapperLib.Cntr_Alarm cntr_Alarm;
						this.a(ref a_2, ref cntr_Alarm, alarmExpAction);
						this.a(hSession, 0, 2, 30, a_2);
						this.a(hSession, 0, 2, 30, 29);
						num = (short)1703084036;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_3DC;
					}
					goto IL_11F;
					IL_224:
					num = (short)297205766;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_262:
					flag2 = false;
					num = (short)30343179;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C4:
					num = (short)1051394065;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1FC:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쮏횑ꖓ꺕얗몙\uda9bﾝ즟캡솣슥袧\udea9쎫躭쎯ힱ삳隵첷펹톻\udbbd늿볇ꏉꇋꯍꋏ뷓ꗕ귙껛럝铟蟡짣雥髧藩飫语鏯蛱釳鋵훷", a_));
				IL_210:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("힏뚕쪗ﾙﮛ펟횡솣풥袧슫좭\udfaf銱튳ힵ톷횹\ud9bb\udabd", a_));
				IL_3BF:
				goto IL_1FC;
				IL_3DC:
				return;
				IL_11F:
				array = new byte[(int)num5];
				this.ReadMemoryData(hSession, 0, 2, num5, array);
				flag = false;
				num = (short)31260680;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_D0;
			}
			catch (global::RMIBtnWrapperLib.TMEXException innerException)
			{
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("憐킑뺝쾟튡솣풥즧\udea9얫솭\udeaf銱톳쒵쪷햹캻麽럃ꏅ귇藋ꃍ뻏럑ꛓ鏕ꃗ맙맛껝铟诡诣裥죧賩菫鳭탯雱釳苵駷鏹郻跽", a_), innerException);
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000D65C File Offset: 0x0000B85C
		private void a(int A_0, byte A_1, byte A_2, int A_3, byte A_4)
		{
			short num = (short)353835711;
			short num2 = num;
			num = (short)923474623;
			switch (num2 == num)
			{
			default:
			{
				num = (short)453574656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)409141249;
			if (num != 0)
			{
			}
			num = (short)1506213888;
			if (num != 0)
			{
			}
			this.a(A_0, new byte[]
			{
				85,
				A_1,
				A_2,
				A_4
			}, 4);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000D724 File Offset: 0x0000B924
		private void a(int A_0, byte[] A_1, int A_2)
		{
			int a_ = 0;
			short num = (short)1553137664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9C;
				}
				short num5;
				int num6;
				string text;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						int num3 = 0;
						num = (short)97255431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)2132246155;
						short num4 = num;
						num = (short)1402502795;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_115;
						default:
							num = (short)1948844032;
							if (num != 0)
							{
							}
							if ((num5 = global::RMIBtnWrapperLib.TMEXAPI.TMStrongAccess(A_0, global::RMIBtnWrapperLib.IBtnCommon.g)) != 1)
							{
								num = (short)2037317654;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_11A;
						}
						break;
					}
					case 2:
						goto IL_36C;
					case 3:
						if (num6 > (int)this.c)
						{
							num = (short)59703308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2490369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (num6 > (int)this.c)
						{
							num = (short)1511260184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1780482064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_115;
					case 6:
						num = (short)1123155987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_19D;
					case 8:
					{
						num = (short)250019840;
						short num7 = num;
						num6++;
						num = (short)927399953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_36C;
					case 10:
					{
						int num3;
						if (num3 >= A_2)
						{
							num = (short)212729862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6 = 0;
						num = (short)1985806359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_1DA;
					case 12:
						goto IL_11A;
					case 13:
						if (text != null)
						{
							num = (short)1886715922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 14:
						goto IL_1DA;
					case 15:
						goto IL_19D;
					case 16:
					{
						int num3;
						if ((num5 = global::RMIBtnWrapperLib.TMEXAPI.TMTouchByte(A_0, (short)A_1[num3])) < 0)
						{
							num = (short)560201736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0;
					}
					case 17:
						goto IL_41D;
					case 18:
						goto IL_213;
					case 19:
						goto IL_1DA;
					case 20:
					{
						if (num5 < 0)
						{
							num = (short)2017329157;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3;
						num3++;
						num = (short)1529151503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						if (num5 == 1)
						{
							num = (short)1542782976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = global::RMIBtnWrapperLib.TMEXException.g("⩽쵿톁쾍", a_);
						num = (short)1732771851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num6++;
						num = (short)1460797442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_41D;
					case 24:
						goto IL_E0;
					}
					goto IL_9C;
					IL_E0:
					num = (short)1967783956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_115:
					text = global::RMIBtnWrapperLib.TMEXException.g("⩽쵿횁캋", a_);
					num = (short)826671118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11A:
					num = (short)195690517;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19D:
					num = (short)943652874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DA:
					num = (short)1902575629;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36C:
					num = (short)1937244163;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41D:
					num = (short)673447940;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_213:
				num = (short)518389761;
				if (num != 0)
				{
				}
				throw new global::RMIBtnWrapperLib.TMEXException(string.Format(global::RMIBtnWrapperLib.TMEXException.g("ս끿ﾁꒃ쎅慎ﲍ낏ﾕ劣肟횡쮣蚥솧\ud9ab\udaad쒯\uddb1\udab3颵颷솹趻쎽꓁ꗃ꿅꓇꿉꣋듏ꟑꛓ뿕뛗뷙ﳛ鷝迟鋡鷣뗥诧飩跫髭鏯髱蓳韵鳷\udaf9鷻諽瓿朁椃瘅簇␉", a_), num5, text));
				IL_9C:
				num5 = -1;
				text = null;
				num6 = 0;
				num = (short)480247817;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000DBBC File Offset: 0x0000BDBC
		private void b(int A_0, char A_1)
		{
			int a_ = 18;
			short num = (short)873725952;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				byte[] array;
				int num3;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_D4;
							}
							for (;;)
							{
								IL_A1:
								switch (num2)
								{
								case 0:
									num = (short)1636499459;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1DA;
								case 2:
								{
									byte b;
									if ((b & 8) != 0)
									{
										num = (short)1756692488;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_25B;
								}
								case 3:
									if (A_1 == 'B')
									{
										num = (short)1011154948;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)505020421;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1777467394;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									byte b;
									if ((b & 8) == 0)
									{
										num = (short)1801781249;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_25B;
								}
								case 6:
									if ((array[0] & 8) == 0)
									{
										num = (short)1394606087;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_12A;
								case 7:
								{
									byte b = array[1];
									num = (short)1592328201;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_256;
								case 9:
								{
									byte b;
									if ((b & 16) > 0)
									{
										num = (short)387383296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18E;
								}
								case 10:
									goto IL_273;
								}
								goto IL_D4;
								IL_25B:
								num = (short)22151178;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_12A:
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쮏횑ꆓ쮕뢗좙좛\udd9d肟햡횣쾥\udca7쾩膫\udead슯\uddb1삳펵\udbb7캹鲻\ud8bdꆿꯁꣃꏅ곇菏ꛑ뗓ꋕ귗꧙ﳛ곝藟藡跣闥鳧迩黫컭黯鷱胳훵请鿹裻\udefd揿洁瘃琅洇椉砋戍椏㰑", a_));
							IL_18E:
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쮏횑ꂓ쮕뢗좙좛\udd9d肟햡횣쾥\udca7쾩膫\udead슯\uddb1삳펵\udbb7캹鲻\ud8bdꆿꯁꣃꏅ곇鏏뷑뫓ꋕ꫗뗙냛ﻝ鋟蟡菣迥鯧黩觫鳭탯鳱鯳苵\ud8f7觹駻諽⃿愁欃琅稇漉漋稍簏欑㨓", a_));
							IL_1DA:
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쮏횑ꂓ쮕뢗좙좛\udd9d肟햡횣쾥\udca7쾩膫\udead슯\uddb1삳펵\udbb7캹鲻\ud8bdꆿꯁꣃꏅ곇鏏뷑뫓ꋕ꫗뗙냛ﻝ鋟蟡菣迥鯧黩觫鳭탯鳱鯳苵\ud8f7觹駻諽⃿愁欃琅稇漉漋稍簏欑㨓", a_));
							IL_256:
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쮏횑ꞓ쮕뢗좙좛\udd9d肟햡횣쾥\udca7쾩膫\udead슯\uddb1삳펵\udbb7캹鲻\ud8bdꆿꯁꣃꏅ곇鏏뷑뫓ꋕ꫗뗙냛ﻝ鋟蟡菣迥鯧黩觫鳭탯鳱鯳苵\ud8f7觹駻諽⃿愁欃琅稇漉漋稍簏欑㨓", a_));
							IL_273:
							return;
							IL_D4:
							this.ReadMemoryData(A_0, 0, 2, 30, array);
							num = (short)1550188550;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_A1;
						}
						catch (global::System.Exception innerException)
						{
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쮏횑ꂓ쮕뢗좙좛\udd9d肟햡횣쾥\udca7쾩膫\udead슯\uddb1삳펵\udbb7캹鲻\ud8bdꆿꯁꣃꏅ곇鏏뷑뫓ꋕ꫗뗙냛ﻝ鋟蟡菣迥鯧黩觫鳭탯鳱鯳苵\ud8f7觹駻諽⃿愁欃琅稇漉漋稍簏欑㨓", a_), innerException);
						}
						goto IL_28E;
					case 1:
						goto IL_92;
					case 2:
					{
						if (num3 < 30)
						{
							array[num3] = byte.MaxValue;
							num3++;
							num = (short)955318275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)689690829;
						short num4 = num;
						num = (short)747690189;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_92;
						default:
							num = (short)833028097;
							if (num != 0)
							{
							}
							num = (short)1559756800;
							if (num != 0)
							{
							}
							num = (short)1394343940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_2D3;
					case 4:
						goto IL_28E;
					}
					goto IL_4B;
					IL_28E:
					num = (short)1061617664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D3:
					num = (short)461438978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_92:
					goto IL_2D3;
				}
				return;
				IL_4B:
				num = (short)139722752;
				short num5 = num;
				array = new byte[30];
				num3 = 0;
				num = (short)470155265;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000DF64 File Offset: 0x0000C164
		private void a(int A_0, char A_1)
		{
			int a_ = 13;
			short num = (short)1865678848;
			switch (num)
			{
			default:
			{
				num = (short)2140340228;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					byte b;
					byte b2;
					byte[] a_3;
					switch (num2)
					{
					case 0:
						goto IL_352;
					case 1:
						if (A_1 != 'R')
						{
							num = (short)99811328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C8;
					case 2:
						b = 89;
						goto IL_354;
					case 3:
						b = 81;
						goto IL_354;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_70;
						}
						continue;
					case 5:
						num = (short)1991835649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (A_1 != 'B')
						{
							num = (short)694878216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E6;
					case 7:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_F9;
							}
							int num3;
							for (;;)
							{
								IL_C6:
								byte a_2;
								switch (num2)
								{
								case 0:
									goto IL_274;
								case 1:
									a_2 = 1;
									num = (short)1402404873;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (num3 >= 3)
									{
										num = (short)143196168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1027080197;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_182;
								case 4:
								{
									num = (short)671518934;
									short num4 = num;
									num = (short)93229270;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_184;
									default:
										num = (short)222953472;
										if (num != 0)
										{
										}
										goto IL_248;
									}
									break;
								}
								case 5:
									if (num3 == 0)
									{
										num = (short)1057226753;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_184;
								case 6:
									goto IL_274;
								case 7:
								{
									byte[] array;
									if (array[0] != b2)
									{
										num = (short)1385693187;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2094661642;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									byte[] array = new byte[1];
									this.ReadMemoryData(A_0, 1, 2, 1, array);
									num = (short)1229193223;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_248;
								case 10:
									goto IL_2CB;
								}
								goto IL_F9;
								IL_184:
								a_2 = 129;
								num = (short)359202820;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_248:
								this.a(A_0, 0, 2, 3, a_2);
								num3++;
								num = (short)2686976;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_274:
								num = (short)1927741442;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_182:
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\udc8aﾌ얔ﲞ햠覨춪첬욮\uddb0횲톴隶", a_));
							IL_2CB:
							return;
							IL_F9:
							this.a(A_0, 0, 2, 2, a_3);
							num3 = 0;
							num = (short)566362118;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_C6;
						}
						catch (global::RMIBtnWrapperLib.TMEXException)
						{
							throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\udc8aﾌ얔ﲞ햠覨춪첬욮\uddb0횲톴隶馸隺鶼첾꓀ꛂ軆ꟈꗊ꣌뷎铐ꯒ뛔닖꧘꿚드냞迠쏢菤裦鯨쯪觬諮藰鋲鳴鯶諸", a_));
						}
						catch (global::System.Exception ex)
						{
							throw ex;
						}
						goto IL_2E6;
					case 8:
						num = (short)1789001730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_70:
					num = (short)1854341120;
					short num5 = num;
					if (A_1 != 'B')
					{
						num = (short)998375429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C8;
					IL_2E6:
					num = (short)1292304387;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_354:
					b2 = b;
					a_3 = new byte[]
					{
						48,
						b2
					};
					num = (short)118620161;
					if (num != 0)
					{
					}
					num = (short)431161351;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C8:
					num = (short)92602374;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_352:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("슊年ﾒﲔ릘漢풠캢삤즦\udda8讪肬辮쮲어\udeb6쮸\udaba즼횾껀귂ꛆ꫈뿊꓌ꃎ뿐볔ꓖ律닚돜볞軠釢韤苦諨鿪쏬", a_));
			}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000E3AC File Offset: 0x0000C5AC
		private void a(byte A_0)
		{
			int a_ = 18;
			short num = (short)967049217;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if ((A_0 & 32) > 0)
					{
						num = (short)1001717763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 2:
					if ((A_0 & 64) > 0)
					{
						num = (short)641597444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1493303296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_FA;
				case 4:
				{
					num = (short)2035992939;
					short num3 = num;
					num = (short)1648413035;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_131;
					}
					break;
				}
				case 5:
					goto IL_BB;
				}
				IL_45:
				num = (short)1392574464;
				short num4 = num;
				if ((A_0 & 128) > 0)
				{
					num = (short)568393729;
					if (num != 0)
					{
					}
					num = (short)2101215237;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1439301634;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_BB:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쮏횑ꖓ꒕얗몙쾛ﮝ풟芡쾥얧쾩\udeab躭횯펱\uddb3\udab5\uddb7\udeb9鲻\udabd떿ꟁ닅Ꟈ귋믍꓏뫑믓ꓕ뇗ꃙ뷛ꫝ觟跡諣웥飧诩飫髭闯胱髳훵黷鯹闻鋽痿瀁愃⠅", a_));
			IL_FA:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쮏횑ꖓꊕ얗몙쾛ﮝ풟芡쾥얧쾩\udeab躭횯펱\uddb3\udab5춷좹\ud9bb麽듃Ʂ뫇뻉ꗋ꿍볏뛓꿕곗뿙ﳛ꧝鋟诡郣鋥跧蓩싫", a_));
			IL_131:
			num = (short)240844800;
			if (num != 0)
			{
			}
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("쮏횑ꖓꖕ얗몙쾛ﮝ풟芡쾥얧쾩\udeab躭횯펱\uddb3\udab5\uddb7\udeb9鲻\udabd떿ꟁ닅Ꟈ꣋꿍꓏돑맕껗뿙껛룝賟跡鏣죥", a_));
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000E57C File Offset: 0x0000C77C
		private void a(int A_0, byte A_1, byte A_2, byte[] A_3, int A_4)
		{
			int a_ = 13;
			short num = (short)1208418304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C0;
				}
				string text;
				short num3;
				int num4;
				short num5;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						num = (short)1170866195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (text != null)
						{
							num = (short)247136285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						if ((num3 = global::RMIBtnWrapperLib.TMEXAPI.TMStrongAccess(A_0, global::RMIBtnWrapperLib.IBtnCommon.g)) != 1)
						{
							num = (short)1628438531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F7;
					case 3:
						num4++;
						num = (short)1665007632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						byte[] array;
						if (global::RMIBtnWrapperLib.TMEXAPI.TMBlockStream(A_0, array, num5) >= 0)
						{
							num = (short)1676148737;
							if (num != 0)
							{
							}
							num = (short)612237312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = global::RMIBtnWrapperLib.TMEXException.g("\udf8a삌춎﶐ﲒﲖ쪘爵삠캢", a_);
						num = (short)25690134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)348782602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						int num6 = 0;
						num = (short)424476681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (num4 > (int)this.c)
						{
							num = (short)778108943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1973944322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_1F9;
					case 9:
						goto IL_45E;
					case 10:
						goto IL_1F9;
					case 11:
						num = (short)1133445143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_1A2;
					case 13:
					{
						byte[] array;
						array[0] = 170;
						array[1] = A_1;
						array[2] = A_2;
						num = (short)1352824182;
						short num7 = num;
						num = (short)159413622;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5E9;
						default:
							num = (short)1182334976;
							if (num != 0)
							{
							}
							num = (short)492896260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 14:
					{
						int num8;
						if (num8 >= 33)
						{
							num = (short)636485637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1526595584;
						short num9 = num;
						num = (short)1318191128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_3F7;
					case 16:
						goto IL_5E9;
					case 17:
						goto IL_526;
					case 18:
						goto IL_5EE;
					case 19:
					{
						byte[] array;
						if (array[1] == A_3[1])
						{
							num = (short)1442054155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F9;
					}
					case 20:
						if (num3 == 1)
						{
							num = (short)995885086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = global::RMIBtnWrapperLib.TMEXException.g("\udf8a삌\udc8e杖練ﺘ\uda9aﺜﲞ쒠킢횤", a_);
						num = (short)27656200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_1F9;
					case 22:
						goto IL_1F9;
					case 23:
					{
						byte[] array;
						if (array[2] == A_3[2])
						{
							num = (short)1405222943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F9;
					}
					case 24:
					{
						byte[] array;
						int num8;
						if (A_3[num8] != array[num8 + 1])
						{
							num = (short)2025127953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num8++;
						num = (short)185335826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						byte[] array;
						if (array != null)
						{
							num = (short)2124283910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F9;
					}
					case 26:
						goto IL_5EE;
					case 27:
					{
						int num6;
						if (num6 >= A_4)
						{
							num = (short)243335181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						array[num6] = byte.MaxValue;
						num6++;
						num = (short)300154908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						goto IL_45E;
					case 29:
						goto IL_232;
					case 30:
					{
						byte[] array = new byte[(int)num5];
						num = (short)2026569753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						num = (short)818544673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						byte[] array;
						this.a(array[3]);
						num = (short)1752039445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
					{
						byte[] array;
						if (array[3] != 29)
						{
							num = (short)734789664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num8 = 3;
						num = (short)421265434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_C0;
					IL_1A2:
					num = (short)418054151;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E9:
					goto IL_1A2;
					IL_1F9:
					num = (short)561184769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F7:
					num = (short)1342570516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45E:
					num = (short)749076507;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5EE:
					num = (short)172294158;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_232:
				throw new global::RMIBtnWrapperLib.TMEXException(string.Format(global::RMIBtnWrapperLib.TMEXException.g("붌놐횒붜펠쪢톤캦잨첪趬\udbae\udeb0鎲\udcb4첸쾺즼킾꿀꣄ꋆ꓈꓊뿌뛎￐껔ꓘﯚ믜뻞裠迢胤菦짨迪飬鷮飰鷲鋴ퟶ迸黺迼雾最樂昄昆紈戊戌愎ㄐ簒猔㜖㸘栚縜洞䀠圢䘤伦礨䨪䤬༮䘰䄲尴䌶尸᰺ጼ", a_), num3, text));
				IL_526:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("킊즌뺎Ꞑ캒떔쒖ﲘ붜쮞좠캢삤햦覨춪첬욮\uddb0횲톴馶馸\ud8bc\udebeꗀ郂ꛄ뗆꣈뿊껌꟎臐닒뇔ꯘ뻚껜꫞跠韢雤쟦跨苪觬臮훰蟲헴髶飸迺黼韾℀眂洄栆稈渊ⴌ怎眐㌒䈔攖瀘漚砜䰞䈠儢䐤匦䨨䌪紬丮唰", a_));
				IL_C0:
				num3 = -1;
				text = null;
				num5 = (short)(A_4 + 1);
				num4 = 0;
				num = (short)1885405196;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000EBB8 File Offset: 0x0000CDB8
		private void a(int A_0, byte A_1, byte A_2, int A_3, byte[] A_4)
		{
			int a_ = 5;
			short num = (short)371916800;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_85;
				}
				short num6;
				string text;
				int num8;
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
					{
						int num3;
						int num4;
						if (num3 >= num4)
						{
							num = (short)330366978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						int num5;
						array[num3] = A_4[num5];
						num3++;
						num5++;
						num = (short)1070465039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						if (num6 == 1)
						{
							num = (short)1366556679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1798857005;
						short num7 = num;
						num = (short)1084055853;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)833093632;
							if (num != 0)
							{
							}
							text = global::RMIBtnWrapperLib.TMEXException.g("힂좄풆ﶈ力튒ﲘ", a_);
							break;
						}
						num = (short)2142437385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)2555908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num8++;
						num = (short)1734475787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						int num4;
						byte[] array;
						if (global::RMIBtnWrapperLib.TMEXAPI.TMBlockStream(A_0, array, (short)num4) >= 0)
						{
							num = (short)809762817;
							if (num != 0)
							{
							}
							num = (short)1113128976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = global::RMIBtnWrapperLib.TMEXException.g("힂좄얆슐", a_);
						num = (short)421527562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_D1;
					case 6:
						goto IL_10F;
					case 7:
					{
						int num9 = 3;
						int num4 = A_3 + num9;
						byte[] array = new byte[num4];
						array[0] = 15;
						array[1] = A_1;
						array[2] = A_2;
						int num3 = num9;
						int num5 = 0;
						num = (short)228851717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_18A;
					case 9:
						goto IL_152;
					case 10:
						goto IL_152;
					case 11:
						goto IL_10F;
					case 12:
						if ((num6 = global::RMIBtnWrapperLib.TMEXAPI.TMStrongAccess(A_0, global::RMIBtnWrapperLib.IBtnCommon.g)) != 1)
						{
							num = (short)609419267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_227;
					case 13:
						goto IL_152;
					case 14:
						if (num8 > (int)this.c)
						{
							num = (short)810614802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1673068556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_D1;
					case 16:
					{
						int num4;
						byte[] array;
						this.a(A_0, A_1, A_2, array, num4);
						num = (short)1823604749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (text != null)
						{
							num = (short)1671036936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
						goto IL_227;
					}
					goto IL_85;
					IL_D1:
					num = (short)1316421632;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10F:
					num = (short)369950734;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_152:
					num = (short)860291089;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_227:
					num = (short)380567552;
					short num10 = num;
					num = (short)1860370433;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_18A:
				throw new global::RMIBtnWrapperLib.TMEXException(string.Format(global::RMIBtnWrapperLib.TMEXException.g("떄惘ꦈ캊ﾌﶎﺐ떔쾠쒢薤펦욨讪쒬쒰잲솴\ud8b6ힸ鮺킼\udabe곀곂럄뻆뛌ﻎ곐돔뛖냘럚룜믞쇠蟢郤闦胨藪諬쿮蛰臲鳴菶鳸\udbfa觼郾℀瀂昄甆栈缊渌朎愐爒焔㜖砘漚検稞䰠匢儤द", a_), num6, text));
				IL_85:
				num6 = -1;
				text = null;
				num8 = 0;
				num = (short)1427374086;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000EFC8 File Offset: 0x0000D1C8
		public void ReadMemoryData(int hSession, byte addrLSB, byte addrMSB, short numBytesRequested, byte[] data)
		{
			int a_ = 8;
			short num = (short)951844864;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A5;
				}
				bool flag;
				string text;
				short num7;
				int num11;
				for (;;)
				{
					IL_32:
					short length;
					int num8;
					byte[] array;
					switch (num2)
					{
					case 0:
					{
						int num3 = 0;
						num = (short)1401290753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)190934965;
						short num4 = num;
						num = (short)1263431605;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_373;
						default:
							num = (short)1341128704;
							if (num != 0)
							{
							}
							goto IL_F0;
						}
						break;
					}
					case 2:
					{
						short num5;
						if (num5 >= 0)
						{
							num = (short)683147264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						text = global::RMIBtnWrapperLib.TMEXException.g("튅얇좉撚잓ﾙﶛ", a_);
						num = (short)563937287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						length = numBytesRequested;
						num = (short)805306393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_286;
					case 5:
						goto IL_1C0;
					case 6:
					{
						num = (short)1218904064;
						short num6 = num;
						if (!flag)
						{
							num = (short)1109393412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 7:
						goto IL_224;
					case 8:
						num = (short)272760833;
						if (num != 0)
						{
						}
						if (num7 == 1)
						{
							num = (short)575864841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						text = global::RMIBtnWrapperLib.TMEXException.g("튅얇\ud989ﲍﾏﲑ힕ﮗ蓮鍊펟", a_);
						num = (short)736428051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						num8 = 3;
						short num9 = (short)((int)numBytesRequested + num8);
						array = new byte[(int)num9];
						int num10 = 0;
						num = (short)1568342028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num11++;
						num = (short)723124235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_1C0;
					case 12:
						goto IL_352;
					case 13:
						goto IL_F0;
					case 14:
						goto IL_482;
					case 15:
						num = (short)803995669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_352;
					case 17:
						if (num7 != 1)
						{
							num = (short)1159593994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_130;
					case 18:
					{
						int num3;
						if (num3 >= (int)numBytesRequested)
						{
							num = (short)1179451407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						data[num3] = 0;
						num3++;
						num = (short)931004429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_224;
					case 20:
					{
						array[0] = 240;
						array[1] = addrLSB;
						array[2] = addrMSB;
						short num9;
						short num5 = global::RMIBtnWrapperLib.TMEXAPI.TMBlockStream(hSession, array, num9);
						num = (short)564920322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						short num5;
						if (numBytesRequested <= num5)
						{
							num = (short)1211170819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						length = num5;
						num = (short)1226178574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						if (num11 > (int)this.c)
						{
							num = (short)957874202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num7 = global::RMIBtnWrapperLib.TMEXAPI.TMStrongAccess(hSession, global::RMIBtnWrapperLib.IBtnCommon.g);
						num = (short)2108030993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						int num10;
						if (num10 >= array.Length)
						{
							goto IL_373;
						}
						array[num10] = byte.MaxValue;
						num10++;
						num = (short)590544912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_224;
					case 25:
						goto IL_482;
					case 26:
						goto IL_130;
					}
					goto IL_A5;
					IL_F0:
					num = (short)1822687250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_130:
					num = (short)122421256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C0:
					num = (short)1391984662;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_224:
					num = (short)221839366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_352:
					num = (short)1180303383;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_373:
					num = (short)1311375380;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_482:
					global::System.Array.Copy(array, num8, data, 0, (int)length);
					num = (short)1956577304;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_286:
				throw new global::RMIBtnWrapperLib.TMEXException(string.Format(global::RMIBtnWrapperLib.TMEXException.g("\udd85욇벋춏늑톓뺝튟잡얣슥솧쒩쮫躭\ud9af솳습첷햹튻麽궿ꟁ꧃꧅뫇돉ꯏ꧓뻗믙뗛닝藟蛡쓣铥跧诩裫蟭黯闱퓳鯵鷷韹鏻賽秿∁攃爅⠇欉栋樍戏眑朓攕㠗⨙搛攝ሟᠡ尣ᐥ唧儩Ἣᐭ䠯1䤳", a_), new object[]
				{
					num7,
					text,
					addrMSB,
					addrLSB
				}));
				IL_A5:
				flag = true;
				num7 = -1;
				num11 = 0;
				text = null;
				num11 = 0;
				num = (short)1577713669;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000F52C File Offset: 0x0000D72C
		private int a(int A_0, int A_1, int A_2, ref byte[] A_3, int A_4)
		{
			short num = (short)1009188864;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				byte[] array2;
				int num5;
				int num6;
				int num7;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_14F;
					case 1:
						num = (short)1521745925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_17F;
					case 3:
						goto IL_1B6;
					case 4:
					{
						num = (short)1287061504;
						short num3 = num;
						if (A_0 == 1)
						{
							num = (short)1993605121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FA;
					}
					case 5:
					{
						if (A_1 > 0)
						{
							num = (short)807796739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array = array2;
						int num4 = num5;
						array[num4] &= (byte)(~(byte)(num6 << num7));
						num = (short)2088370176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_46;
				}
				IL_14F:
				IL_17F:
				global::System.Array.Copy(array2, 0, A_3, A_4, A_3.Length - A_4);
				return 1;
				IL_1FA:
				int result = array2[num5] >> num7 & 1;
				global::System.Array.Copy(array2, 0, A_3, A_4, A_3.Length - A_4);
				return result;
				IL_46:
				num6 = 1;
				array2 = new byte[A_3.Length - A_4];
				global::System.Array.Copy(A_3, A_4, array2, 0, A_3.Length - A_4);
				num5 = A_2 / 8;
				num7 = A_2 - num5 * 8;
				num = (short)970818852;
				short num8 = num;
				num = (short)154371364;
				switch ((num8 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_1B6:
					num = (short)362741761;
					if (num != 0)
					{
					}
					byte[] array3 = array2;
					int num9 = num5;
					array3[num9] |= (byte)(num6 << num7);
					num = (short)96010242;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				default:
					num = (short)1367343104;
					if (num != 0)
					{
					}
					num = (short)243466244;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				break;
			}
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000F754 File Offset: 0x0000D954
		public bool ValidateBtnInitTimerArgs(char offsetFormat, char expirationAction)
		{
			int a_ = 4;
			short num = (short)1692013670;
			short num2 = num;
			num = (short)930681958;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_17E:
				num = (short)48824324;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1561788416;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				break;
			}
			bool result;
			char c;
			char c2;
			for (;;)
			{
				IL_5C:
				switch (num3)
				{
				case 0:
					goto IL_211;
				case 1:
					goto IL_1FB;
				case 2:
					num = (short)696385542;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return result;
				case 4:
					if (c == 'N')
					{
						num = (short)1144061952;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B4;
				case 5:
					goto IL_FE;
				case 6:
					if (c2 == 'R')
					{
						num = (short)560070661;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FD;
				case 7:
					if (c2 != 'B')
					{
						num = (short)716570626;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FE;
				case 8:
					num = (short)1819213834;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)49807361;
					if (num != 0)
					{
					}
					if (c != 'M')
					{
						num = (short)1359413256;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_211;
				case 10:
					if (c != 'D')
					{
						num = (short)1743519745;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_211;
				}
				goto IL_8E;
				IL_FE:
				result = true;
				num = (short)1607073792;
				short num4 = num;
				num = (short)1595670531;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_211:
				num = (short)1692991495;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_1B4:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\ud981삃뒅햇ꪉ얋ﾕﲗ몙펛욟톡솣튥얩\udeab쎭톯욱钳억좷\udfb9\udfbbힽꚿꯁꇃꋅ", a_));
			IL_1FB:
			goto IL_17E;
			IL_1FD:
			throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("\ud981삃뒅햇ꪉ얋ﾕﲗ몙\ud99b킟쮡횣장\udca7쎩쎫삭톱삳\udfb5ힷ풹鲻춽낿ꟁꟃ꿅껇ꏉ꧋꫍ﻏ", a_));
			IL_8E:
			result = false;
			c = char.ToUpper(offsetFormat);
			c2 = char.ToUpper(expirationAction);
			num = (short)2147090441;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_5C;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000F9B4 File Offset: 0x0000DBB4
		public bool ValidateBtnInitUserArgs(byte[] version, byte[] communityCode, string userid, string password)
		{
			int a_ = 11;
			short num = (short)287440896;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B4;
				}
				bool result;
				for (;;)
				{
					IL_31:
					short num3;
					int num4;
					switch (num2)
					{
					case 0:
						num = (short)1266810900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (version != null)
						{
							num = (short)878575645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_582;
					case 2:
						goto IL_131;
					case 3:
						if (communityCode == null)
						{
							num = (short)874840087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (short)userid.Length;
						num = (short)1474887688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (communityCode[1] == 0)
						{
							num = (short)1043857424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E1;
					case 5:
						if (communityCode[0] != 1)
						{
							num = (short)1952186380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A5;
					case 6:
						if (num4 >= version.Length)
						{
							num = (short)584581130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)801964051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						bool flag = false;
						num = (short)2105737234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_215;
					case 9:
						num = (short)568852505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_546;
					case 11:
						goto IL_521;
					case 12:
						num = (short)501088278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (num3 >= 0)
						{
							num = (short)1500839937;
							if (num != 0)
							{
							}
							num = (short)761331712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_278;
					case 14:
						num = (short)1160708101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						bool flag = false;
						num = (short)2085552139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						result = true;
						num = (short)1695285272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_131;
					case 18:
						goto IL_546;
					case 19:
					{
						byte[] array;
						if (version[num4] != array[num4])
						{
							num = (short)1514995727;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_521;
					}
					case 20:
						if (num3 <= 8)
						{
							num = (short)1204158490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_278;
					case 21:
					{
						num = (short)1495917790;
						short num5 = num;
						num = (short)230745310;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_215;
						default:
							num = (short)970260480;
							if (num != 0)
							{
							}
							num3 = (short)password.Length;
							num = (short)452329485;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 22:
						if (communityCode[1] == 2)
						{
							num = (short)1780023324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E1;
					case 23:
						goto IL_38E;
					case 24:
						return result;
					case 25:
						if (num3 <= 10)
						{
							num = (short)2108948501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FB;
					case 26:
					{
						byte[] array2 = new byte[6];
						array2[4] = 1;
						byte[] array = array2;
						bool flag = true;
						num = (short)250413086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
					{
						bool flag;
						if (flag)
						{
							num = (short)582483982;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E7;
					}
					case 28:
						goto IL_4A5;
					case 29:
						num = (short)850067459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						byte[] array;
						if (version.Length != array.Length)
						{
							num = (short)849674247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = 0;
						num = (short)944242688;
						short num6 = num;
						num = (short)254672898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_B4;
					IL_131:
					num = (short)286130182;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_215:
					if (num3 > 0)
					{
						num = (short)1679294473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FB;
					IL_4A5:
					num = (short)1850802180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_521:
					num4++;
					num = (short)188940305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_546:
					num = (short)1869348891;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1E1:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("튈쾊뾌튎놐\uda92ﮔﮞ膠쪤쪦쒨\udeaa쎬욮얰쪲\ud8b6\uddb8\udeba鶼첾뇀ꛂꛄ껆꿈ꋊ꣌ꯎ￐", a_));
				IL_278:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("튈쾊뾌튎놐\uda92ﮔﮞ膠펢쒤풦\udaa8\udcaa슬\uddae햰鎲운잶\udcb8\ud8ba풼\ud9beꣀꛂꇄ", a_));
				IL_2E7:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("튈쾊뾌튎놐\uda92ﮔﮞ膠햢삤햦\udaa8슪슬솮醰삲어튶\udab8튺\udbbc횾꓀Ꟃ", a_));
				IL_2FB:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("튈쾊뾌튎놐\uda92ﮔﮞ膠횢횤슦\udba8슪즬辮슰쎲킴풶킸\uddba풼\udabeꗀ", a_));
				IL_38E:
				IL_582:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("튈쾊뾌튎놐杖ﺖ膠펢쒤햦좨욪좬\udbae풰솲운鞶\udab8\udaba펼톾껀럂ꗆ곈菌髎鷐鿒ﯔ", a_));
				IL_B4:
				result = false;
				num = (short)1955069953;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000FF58 File Offset: 0x0000E158
		public void GetMaxFileSpaceAvailable(int hSession, string fileName, out short pMaxBytes)
		{
			int a_ = 1;
			short num;
			for (;;)
			{
				num = (short)1258553345;
				if (num != 0)
				{
				}
				num = (short)796852224;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)36304519;
					short num3 = num;
					num = (short)94566023;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_AD;
					}
					goto Block_1;
				}
				}
			}
			Block_1:
			num = (short)1582563328;
			short num4 = num;
			IL_AD:
			num = (short)326434816;
			if (num != 0)
			{
			}
			pMaxBytes = -1;
			byte[] array = new byte[40];
			array[0] = 95;
			array[1] = 68;
			array[2] = 76;
			array[3] = 76;
			array[4] = 99;
			short num5 = -1;
			short num6 = 58;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_12B;
				}
				int num2;
				for (;;)
				{
					IL_F8:
					switch (num2)
					{
					case 0:
						if (this.b(hSession, array, true))
						{
							num = (short)598147082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_294;
					case 1:
						if (array != null)
						{
							num = (short)1760952327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_173;
					case 2:
						goto IL_2AC;
					case 3:
						if (fileName.Length > 3)
						{
							num = (short)411500550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1ED;
					case 4:
						goto IL_294;
					case 5:
						goto IL_294;
					case 6:
						array = this.LoadFileName(fileName);
						num = (short)2098135041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1452474368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1225523203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (fileName != null)
						{
							num = (short)2115174408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1ED;
					case 10:
						pMaxBytes = num6 + (short)(array[6] * 29);
						num = (short)1094844421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12B;
					IL_1ED:
					pMaxBytes = num6;
					num = (short)173867012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_294:
					num = (short)94306306;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_173:
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("㙾권殺ﲘ辠莢캦얨캪솮얰솲체鞶\udab8\udaba펼톾껀럂ꗆ곈ꏌ뫎뷐뿒", a_));
				IL_2AC:
				return;
				IL_12B:
				this.CreateFile(hSession, out num5, array, out num6);
				this.CloseFile(hSession, ref num5);
				num = (short)317915145;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_F8;
			}
			catch (global::RMIBtnWrapperLib.TMEXException innerException)
			{
				throw new global::System.Exception(global::RMIBtnWrapperLib.TMEXException.g("ᙾ쎀권膠욢\udda4쒦첨\udbaa\ud9ac욮\udeb0\uddb2閴骶馸좺\ud8bc\udabe諂ꯄ꧆곈맊裌럎닐뛒ꗔꏖ냘듚돜￞蟠賢韤쟦跨軪駬軮飰鿲蛴", a_), innerException);
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00010260 File Offset: 0x0000E460
		private bool b(int A_0, byte[] A_1, bool A_2)
		{
			short num = (short)1477312512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_82;
				}
				short num3;
				bool result;
				byte[] array;
				for (;;)
				{
					IL_27:
					int num5;
					switch (num2)
					{
					case 0:
					{
						if (num3 == 0)
						{
							num = (short)478347267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::RMIBtnWrapperLib.TMEX_API_CODE a_;
						global::RMIBtnWrapperLib.TMEXException.a(num3, a_, null);
						num = (short)402915341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return result;
					case 2:
						goto IL_34C;
					case 3:
					{
						global::RMIBtnWrapperLib.TMEX_API_CODE a_;
						global::System.Diagnostics.Trace.WriteLine(global::RMIBtnWrapperLib.TMEXException.f(num3, a_));
						num = (short)495124491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_2C5;
					case 5:
					{
						num = (short)142934016;
						short num4 = num;
						bool flag = false;
						goto IL_165;
					}
					case 6:
						if (num5 >= 5)
						{
							num = (short)784269320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)13172746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_34C;
					case 8:
						num = (short)842924044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::RMIBtnWrapperLib.TMEX_API_CODE a_ = global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMFirstFile;
						num = (short)1547763730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (array[num5] != A_1[num5])
						{
							num = (short)731840513;
							if (num != 0)
							{
							}
							num = (short)935526405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C5;
					case 11:
						return result;
					case 12:
					{
						bool flag;
						if (flag)
						{
							num = (short)1988165646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = this.b(A_0, A_1, false);
						num = (short)594285362;
						short num6 = num;
						num = (short)963449650;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_165;
						default:
							num = (short)81723392;
							if (num != 0)
							{
							}
							num = (short)233701377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 13:
						return result;
					case 14:
					{
						bool flag;
						result = flag;
						global::System.Array.Copy(array, A_1, 40);
						num = (short)2028142607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						return result;
					case 16:
						goto IL_182;
					case 17:
						if (num3 > 0)
						{
							num = (short)2027749395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)129171476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_182;
					case 19:
					{
						bool flag = true;
						num5 = 0;
						num = (short)2112618498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						if (A_2)
						{
							num = (short)17891337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::RMIBtnWrapperLib.TMEX_API_CODE a_ = global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMNextFile;
						num = (short)239271952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_82;
					IL_165:
					num = (short)1518272516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_182:
					num = (short)1633812480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C5:
					num5++;
					num = (short)1713373191;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34C:
					num = (short)686555142;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_82:
				result = false;
				array = new byte[40];
				num3 = this.a(A_0, array, A_2);
				num = (short)777322513;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00010654 File Offset: 0x0000E854
		private short a(int A_0, byte[] A_1, bool A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			int num4;
			short num5;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)37093376;
					short num3 = num2;
					num2 = (short)492175361;
					if (num2 != 0)
					{
					}
					goto IL_125;
				}
				case 1:
					num4++;
					num2 = (short)562626560;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_1CF;
				case 3:
					num5 = global::RMIBtnWrapperLib.TMEXAPI.TMFirstFile(A_0, global::RMIBtnWrapperLib.IBtnCommon.g, A_1);
					num2 = (short)1770586118;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					if (num4 <= (int)this.c)
					{
						num2 = (short)2056126469;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1712536043;
					short num6 = num2;
					num2 = (short)1783380459;
					switch ((num6 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1CF;
					default:
						num2 = (short)97648640;
						if (num2 != 0)
						{
						}
						num2 = (short)1669726217;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					if (A_2)
					{
						num2 = (short)1231093763;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num5 = global::RMIBtnWrapperLib.TMEXAPI.TMNextFile(A_0, global::RMIBtnWrapperLib.IBtnCommon.g, A_1);
					num2 = (short)2013200386;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_1CF;
				case 7:
					if (num5 < 0)
					{
						num2 = (short)1547108353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return num5;
				case 8:
					goto IL_125;
				case 9:
					return num5;
				}
				goto IL_38;
				IL_125:
				num2 = (short)566034436;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1CF:
				num2 = (short)1155006471;
				num = (int)((global::System.IntPtr)num2);
			}
			return num5;
			IL_38:
			num5 = -1;
			num4 = 0;
			num2 = (short)943325192;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0001086C File Offset: 0x0000EA6C
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00010920 File Offset: 0x0000EB20
		public short Port
		{
			get
			{
				short num = (short)827508606;
				short num2 = num;
				num = (short)1507706750;
				switch (num2 == num)
				{
				}
				num = (short)1064435713;
				if (num != 0)
				{
				}
				num = (short)850001920;
				if (num != 0)
				{
				}
				num = (short)516423680;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)759259433;
				short num2 = num;
				num = (short)1443586345;
				switch (num2 == num)
				{
				}
				num = (short)400097281;
				if (num != 0)
				{
				}
				num = (short)1827078144;
				if (num != 0)
				{
				}
				num = (short)64225280;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000109CC File Offset: 0x0000EBCC
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00010A78 File Offset: 0x0000EC78
		public short PortType
		{
			get
			{
				short num = (short)1956378199;
				short num2 = num;
				num = (short)2116810327;
				switch (num2 == num)
				{
				}
				num = (short)1966866432;
				if (num != 0)
				{
				}
				num = (short)1895563265;
				if (num != 0)
				{
				}
				num = (short)1646395392;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)231013472;
				short num2 = num;
				num = (short)1415773280;
				switch (num2 == num)
				{
				}
				num = (short)1133445120;
				if (num != 0)
				{
				}
				num = (short)609353729;
				if (num != 0)
				{
				}
				num = (short)1156972544;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00010B28 File Offset: 0x0000ED28
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00010BD8 File Offset: 0x0000EDD8
		public short MaxRetryCount
		{
			get
			{
				short num = (short)1915503199;
				short num2 = num;
				num = (short)347882079;
				switch (num2 == num)
				{
				}
				num = (short)422182912;
				if (num != 0)
				{
				}
				num = (short)798490625;
				if (num != 0)
				{
				}
				num = (short)1431568384;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)1165589075;
				short num2 = num;
				num = (short)1471117907;
				switch (num2 == num)
				{
				}
				num = (short)635240448;
				if (num != 0)
				{
				}
				num = (short)63307777;
				if (num != 0)
				{
				}
				num = (short)735182848;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x040000A3 RID: 163
		private short a;

		// Token: 0x040000A4 RID: 164
		private short b;

		// Token: 0x040000A5 RID: 165
		private short c;

		// Token: 0x040000A6 RID: 166
		private bool d;

		// Token: 0x040000A7 RID: 167
		private byte e;

		// Token: 0x040000A8 RID: 168
		private byte[] f;

		// Token: 0x040000A9 RID: 169
		private static byte[] g;

		// Token: 0x040000AA RID: 170
		private static byte[] h;

		// Token: 0x040000AB RID: 171
		private static short[] i;
	}
}
