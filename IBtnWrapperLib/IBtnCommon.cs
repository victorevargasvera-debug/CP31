using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using AcpCryptoLib;
using AcpUtility;

namespace IBtnWrapperLib
{
	// Token: 0x02000010 RID: 16
	public class IBtnCommon
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000021BC File Offset: 0x000003BC
		static IBtnCommon()
		{
			short num = (short)15030140;
			short num2 = num;
			num = (short)344217468;
			switch (num2 == num)
			{
			}
			num = (short)2002714624;
			short num3 = num;
			num = (short)1716846592;
			if (num != 0)
			{
			}
			num = (short)1181417473;
			if (num != 0)
			{
			}
			global::IBtnWrapperLib.IBtnCommon.g = new byte[15360];
			global::IBtnWrapperLib.IBtnCommon.h = new byte[2];
			global::IBtnWrapperLib.IBtnCommon.i = new short[]
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
				int num3;
				switch (num)
				{
				case 0:
					if (hSession <= 0)
					{
						num2 = (short)504692744;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18F;
				case 1:
					goto IL_207;
				case 2:
					if (hSession < 0)
					{
						num2 = (short)1758527505;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					goto IL_18F;
				case 4:
					num2 = (short)250740738;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (global::IBtnWrapperLib.TMEXAPI.TMValidSession(hSession) == 1)
					{
						num2 = (short)1868496909;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_169;
				case 6:
					goto IL_BB;
				case 7:
					goto IL_18F;
				case 8:
					num2 = (short)706740233;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (hSession == 0)
					{
						num2 = (short)1154678807;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)864419856;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (hSession <= 0)
					{
						num2 = (short)407961622;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.d = true;
					num2 = (short)1289748501;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num2 = (short)304676883;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (num3 >= (int)this.c)
					{
						goto IL_22B;
					}
					hSession = global::IBtnWrapperLib.TMEXAPI.TMExtendedStartSession(this.a, this.b, enhancedOptions);
					num2 = (short)712179712;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					num2 = (short)1251868687;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					num2 = (short)451346435;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (hSession != 0)
					{
						num2 = (short)1577975812;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_169;
				case 16:
					if (hSession != -201)
					{
						num2 = (short)1837826054;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18F;
				case 17:
					goto IL_169;
				case 18:
					if (hSession <= 0)
					{
						num2 = (short)932970507;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18F;
				case 19:
					if (hSession == 0)
					{
						num2 = (short)1457717262;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BB;
				case 20:
					goto IL_207;
				case 21:
					return;
				case 22:
					goto IL_1C6;
				case 23:
					global::System.Threading.Thread.Sleep(6000);
					hSession = global::IBtnWrapperLib.TMEXAPI.TMExtendedStartSession(this.a, this.b, enhancedOptions);
					num2 = (short)1193869330;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_70;
				IL_BB:
				num3++;
				num2 = (short)1037216730;
				short num4 = num2;
				num2 = (short)122923994;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_22B:
					num2 = (short)398065664;
					short num5 = num2;
					num2 = (short)1097269255;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				default:
					num2 = (short)1065549824;
					if (num2 != 0)
					{
					}
					num2 = (short)70844417;
					if (num2 != 0)
					{
					}
					num2 = (short)1683619841;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_169:
				global::IBtnWrapperLib.TMEXAPI.TMEndSession(hSession);
				hSession = 0;
				num3 = 0;
				num2 = (short)1871970324;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_18F:
				num2 = (short)662175754;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_207:
				num2 = (short)914227212;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1C6:
			global::IBtnWrapperLib.TMEXException.a((short)hSession, global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMExtendedStartSession, null);
			return;
			IL_70:
			enhancedOptions = new int[]
			{
				2
			};
			num2 = (short)1183318021;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002718 File Offset: 0x00000918
		public void EndSession(int hSession)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num;
			short num2;
			int num4;
			short num5;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_18A;
				case 1:
				{
					num2 = (short)260177920;
					short num3 = num2;
					hSession = 0;
					global::System.Diagnostics.Trace.WriteLine(global::IBtnWrapperLib.TMEXException.g("簼Ἶ㝀≂⥄⹆ⵈ歊㹌⩎≐⁒㱔㡖㝘筚㕜㹞འݢ।ɦ䥨ᱪ౬ᱮ兰ᕲᩴɶ᝸ὺ嵼ᵾꖄꮊﮌ﶐朗랖ﺚ좠첢쮤螦좨\udfaa\ud9ac캮튰\udbb2킴펶", a_));
					num2 = (short)593952782;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (num4 > (int)this.c)
					{
						num2 = (short)1477443591;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num5 = global::IBtnWrapperLib.TMEXAPI.TMEndSession(hSession);
					num2 = (short)684326922;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return;
				case 4:
					goto IL_18F;
				case 5:
					if (num5 != 0)
					{
						num2 = (short)1763901452;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					if (1 != num5)
					{
						num2 = (short)1327824907;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
					goto IL_77;
				case 8:
					goto IL_77;
				case 9:
					if (num5 == 0)
					{
						num2 = (short)661389313;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num4++;
					num2 = (short)1530593281;
					if (num2 != 0)
					{
					}
					num2 = (short)779747341;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
				{
					if (1 == num5)
					{
						num2 = (short)144113664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)509982864;
					short num6 = num2;
					num2 = (short)1917040784;
					switch ((num6 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18A;
					default:
						num2 = (short)1630797824;
						if (num2 != 0)
						{
						}
						num2 = (short)999030793;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 11:
					num2 = (short)565706757;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					global::IBtnWrapperLib.TMEXException.a(num5, global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMEndSession, null);
					num2 = (short)640548867;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_18F;
				case 14:
					goto IL_77;
				}
				goto IL_55;
				IL_77:
				num2 = (short)5242886;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_18A:
				hSession = 0;
				num2 = (short)2096234504;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_18F:
				num2 = (short)1872560130;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_55:
			num5 = 255;
			num4 = 0;
			num2 = (short)704839684;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000029FC File Offset: 0x00000BFC
		public bool DoTMSetup(int hSession)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_71;
			}
			int num;
			bool result;
			short num2;
			short num4;
			for (;;)
			{
				IL_13:
				int num6;
				switch (num)
				{
				case 0:
				{
					result = true;
					this.d = false;
					num2 = (short)1054801920;
					short num3 = num2;
					num2 = (short)1479213076;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return result;
				case 2:
					goto IL_1FE;
				case 3:
					if (this.d)
					{
						num2 = (short)1067384843;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = true;
					num2 = (short)1807876097;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (num4 < 1)
					{
						num2 = (short)712245263;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 5:
					num2 = (short)732889089;
					if (num2 != 0)
					{
					}
					if (1 == num4)
					{
						num2 = (short)1146880000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)293077006;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_B6;
				case 7:
					return result;
				case 8:
				{
					global::System.Diagnostics.Trace.WriteLine(global::IBtnWrapperLib.TMEXException.g("氾⑀㝂い㝆楈╊≌㭎煐⁒⁔❖⥘㑚⽜⭞Ѡݢ", a_));
					num2 = (short)1840940021;
					short num5 = num2;
					num2 = (short)1391494133;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_196;
					default:
						num2 = (short)1342373888;
						if (num2 != 0)
						{
						}
						num2 = (short)27394060;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 9:
					goto IL_1FE;
				case 10:
					global::System.Diagnostics.Trace.WriteLine(global::IBtnWrapperLib.TMEXException.g("氾⑀㝂い㝆楈⑊♌潎㍐♒⅔睖桘癚ੜ㙞፠٢䕤०౨ὪᩬnͰᡲ啴Ѷᅸᑺོ୾", a_));
					num2 = (short)297664533;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num6 = 0;
					num2 = (short)1548877833;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_B6;
				case 13:
					global::System.Diagnostics.Trace.WriteLine(global::IBtnWrapperLib.TMEXException.g("฾汀ᑂⱄ㕆ⱈ歊⍌⩎═⑒㩔╖㉘筚㥜ぞѠၢ䕤०٨Ὢ䵬੮॰ᩲٴͶ", a_));
					num2 = (short)1639251974;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (2 == num4)
					{
						num2 = (short)303038474;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)225181712;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					global::IBtnWrapperLib.TMEXException.a(num4, global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMSetup, null);
					num2 = (short)1644101639;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (3 == num4)
					{
						num2 = (short)1740439565;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1655439378;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					goto IL_15B;
				case 18:
					if (4 == num4)
					{
						num2 = (short)687210504;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B6;
				case 19:
					if (num6 > (int)this.c)
					{
						num2 = (short)417595409;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_196;
				case 20:
					goto IL_15B;
				case 21:
					goto IL_B6;
				}
				goto IL_71;
				IL_B6:
				num6++;
				num2 = (short)1158545410;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_15B:
				num2 = (short)229834756;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_196:
				num4 = global::IBtnWrapperLib.TMEXAPI.TMSetup(hSession);
				num2 = (short)1298071557;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1FE:
				num2 = (short)335085587;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_71:
			result = false;
			num4 = 255;
			num2 = (short)127598595;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002DFC File Offset: 0x00000FFC
		public void InitMicroLan(int options, byte iBtnFamilyType)
		{
			int a_ = 6;
			short num = (short)1946812416;
			short num2 = num;
			num = (short)1165923603;
			short num3 = num;
			num = (short)692688147;
			byte b;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_218:
				if (this.f[0] == b)
				{
					goto IL_2FF;
				}
				num = (short)91881484;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)32243712;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_D9;
				}
				break;
			}
			int num5;
			for (;;)
			{
				IL_87:
				switch (num4)
				{
				case 0:
					if (num5 == 0)
					{
						num = (short)2006843399;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_381;
				case 1:
					num = (short)1180631041;
					if (num != 0)
					{
					}
					this.DoTMSetup(num5);
					this.d = false;
					num = (short)1878654986;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1065549839;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_218;
				case 4:
					goto IL_334;
				case 5:
					this.a += 1;
					num = (short)1662910477;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (num5 <= 0)
					{
						num = (short)384630789;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_381;
				case 7:
					this.a = 1;
					num = (short)591790089;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_1E9;
				case 9:
					goto IL_2BE;
				case 10:
					if (b != 255)
					{
						num = (short)1864564754;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E9;
				case 11:
					if (this.a > 15)
					{
						num = (short)905183248;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.GetSessionHandle(ref num5);
					num = (short)187301894;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_23E;
				case 13:
					goto IL_2BE;
				case 14:
					if (num5 > 0)
					{
						num = (short)973209604;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 15:
					if (this.d)
					{
						num = (short)1492910081;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FF;
				case 16:
					goto IL_381;
				case 17:
					if (num5 > 0)
					{
						num = (short)529334274;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_243;
				case 18:
					this.DoFamilySearchSetup(num5, (short)b);
					num = (short)598933512;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_D9;
				IL_1E9:
				this.FindDevice(num5, ref b);
				this.a(num5, out this.f);
				num = (short)3670019;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_2BE:
				num = (short)1701904395;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_381:
				num = (short)1039400977;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_23E:
			throw new global::IBtnWrapperLib.TMEXException(global::IBtnWrapperLib.TMEXException.g("搾Հ牂畄ᩆ楈ཊ⡌㥎㡐げご睖㽘㑚⡜ㅞՠ䍢Ťࡦ౨ᡪ䵬ŮṰݲ啴᩶ᡸེṼ᝾ꆀ떔ﺖ\udb98캠춢薤솦좨욪쒬쎮좰鎲솴캶즸\udeba鎼", a_));
			IL_243:
			throw new global::IBtnWrapperLib.TMEXException(global::IBtnWrapperLib.TMEXException.g("笾础Ṃ敄ቆ❈⩊⽌⍎㑐獒⅔㡖祘⡚⥜㹞፠ᝢ䕤٦䥨ᡪ࡬ᱮɰᩲᩴ᥶奸ᑺ፼彾Ꞇ麗ﾌﮎ뾐", a_));
			IL_334:
			this.EndSession(num5);
			num5 = 0;
			return;
			IL_D9:
			num5 = 0;
			b = iBtnFamilyType;
			num = (short)749666304;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_87;
			IL_2FF:
			num = (short)561577998;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_87;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000031C4 File Offset: 0x000013C4
		public void DoFamilySearchSetup(int hSession, short iBtnFamilyType)
		{
			switch (0)
			{
			case 0:
				goto IL_AC;
			}
			short num;
			int num3;
			short num5;
			int num6;
			for (;;)
			{
				IL_0A:
				num = (short)772304610;
				short num2 = num;
				num = (short)1296002786;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AC;
				default:
					num = (short)1554776064;
					if (num != 0)
					{
					}
					num = (short)119603201;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_CE;
					case 1:
					{
						num = (short)1772748800;
						short num4 = num;
						num = (short)194576387;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_1F5;
					case 3:
						if (num5 != 0)
						{
							num = (short)1591148550;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CE;
					case 4:
						goto IL_1F5;
					case 5:
						if (num5 != 1)
						{
							num = (short)1254162442;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						num6++;
						num = (short)1551237124;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (num5 != 1)
						{
							num = (short)2102198273;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CE;
					case 8:
						return;
					case 9:
						if (num6 > (int)this.c)
						{
							num = (short)692322304;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = global::IBtnWrapperLib.TMEXAPI.TMFamilySearchSetup(hSession, global::IBtnWrapperLib.IBtnCommon.g, iBtnFamilyType);
						num = (short)1426128903;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						global::IBtnWrapperLib.TMEXException.a(num5, global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMFamilySearchSetup, null);
						num = (short)731512840;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AC;
					IL_CE:
					num = (short)566296581;
					num3 = (int)((global::System.IntPtr)num);
					break;
					IL_1F5:
					num = (short)1713373193;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return;
			IL_AC:
			num5 = 0;
			num6 = 0;
			num = (short)1980104706;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003408 File Offset: 0x00001608
		public bool FindDevice(int hSession, ref byte piBtnFamilyType)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_7D;
			}
			int num;
			bool result;
			short num2;
			short num4;
			byte b;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					result = true;
					num2 = (short)727121929;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
				{
					num2 = (short)1323809446;
					short num3 = num2;
					num2 = (short)486980262;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_27F;
					default:
						num2 = (short)1502871552;
						if (num2 != 0)
						{
						}
						global::System.Diagnostics.Trace.WriteLine(global::IBtnWrapperLib.TMEXException.g("Ṅ͆筈罊၌潎ὐ㱒畔㍖㱘ⵚ㑜㱞Ѡၢ䕤Ŧ٨Ṫͬ୮兰ᱲ᭴坶൸፺᡼彾첀잊뾐", a_));
						num2 = (short)703856642;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_27F;
				case 5:
					goto IL_3DA;
				case 6:
					num2 = (short)1189019655;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (this.f[0] == 12)
					{
						num2 = (short)651034636;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_33B;
				case 8:
					if (num4 < 0)
					{
						num2 = (short)2054815758;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1239547928;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					return result;
				case 10:
					goto IL_27F;
				case 11:
					if ((short)b >= this.c)
					{
						num2 = (short)2004287506;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3DA;
				case 12:
					goto IL_D2;
				case 13:
					if (this.f[0] != 24)
					{
						num2 = (short)1042939910;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D2;
				case 14:
					global::System.Diagnostics.Trace.WriteLine(global::IBtnWrapperLib.TMEXException.g("Ṅ͆筈罊၌潎ὐ㱒畔㍖㱘ⵚ㑜㱞Ѡၢ䕤Ŧ٨Ṫͬ୮兰ᱲ᭴坶൸፺᡼彾첀잊뾐", a_));
					b += 1;
					num2 = (short)2044329988;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (piBtnFamilyType == 255)
					{
						num2 = (short)327876629;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)503447574;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					num2 = (short)1907228685;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
				{
					num2 = (short)1712455680;
					short num5 = num2;
					result = true;
					num2 = (short)1993015315;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 18:
					return result;
				case 19:
					return result;
				case 20:
					if (piBtnFamilyType == 0)
					{
						num2 = (short)1585184768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.a(hSession, out this.f);
					num2 = (short)1048444943;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					num2 = (short)633798679;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (this.f[0] == piBtnFamilyType)
					{
						num2 = (short)2057830417;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_33B;
				case 23:
					if (this.f[0] != 4)
					{
						num2 = (short)1682636816;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D2;
				case 24:
					if (num4 == 0)
					{
						num2 = (short)1371865091;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)306053140;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_7D;
				IL_D2:
				piBtnFamilyType = this.f[0];
				result = true;
				num2 = (short)226099201;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_27F:
				num2 = (short)792985611;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_33B:
				num4 = global::IBtnWrapperLib.TMEXAPI.TMNext(hSession, global::IBtnWrapperLib.IBtnCommon.g);
				num2 = (short)890634250;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3DA:
				num2 = (short)868941832;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_7D:
			num2 = (short)607387649;
			if (num2 != 0)
			{
			}
			result = false;
			num4 = 0;
			b = 0;
			num4 = global::IBtnWrapperLib.TMEXAPI.TMFirst(hSession, global::IBtnWrapperLib.IBtnCommon.g);
			num2 = (short)1151467525;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000388C File Offset: 0x00001A8C
		public bool FindDevice(int hSession, byte[] serialNum)
		{
			int a_ = 1;
			short num = (short)65273856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				bool result;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_1AC;
					case 1:
					{
						short num3;
						if (num3 == 0)
						{
							num = (short)917635074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 2:
						global::System.Diagnostics.Trace.WriteLine(global::IBtnWrapperLib.TMEXException.g("愹砻ఽ琿ὁ摃ࡅ❇橉⡋⭍♏㭑㝓㍕⭗穙㩛ㅝᕟౡc䙥ݧѩ䱫ᩭᡯ᝱味㭵ᅷ᥹๻ᅽ챿ꢅ", a_));
						num = (short)642908167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_23F;
					case 4:
						goto IL_1C5;
					case 5:
						this.f = serialNum;
						this.e = serialNum[0];
						result = true;
						num = (short)838139907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						short num3 = global::IBtnWrapperLib.TMEXAPI.TMStrongAccess(hSession, global::IBtnWrapperLib.IBtnCommon.g);
						num = (short)1685520385;
						if (num != 0)
						{
						}
						num = (short)1376714763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						return result;
					case 8:
					{
						short[] array;
						short num3 = global::IBtnWrapperLib.TMEXAPI.TMRom(hSession, global::IBtnWrapperLib.IBtnCommon.g, array);
						num = (short)320602122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_1AC;
					case 10:
					{
						short num3;
						if (num3 == 1)
						{
							num = (short)45350918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 11:
					{
						short num3;
						if (num3 == 1)
						{
							num = (short)1175453701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23F;
					}
					}
					goto IL_67;
					IL_1AC:
					num = (short)1035468804;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23F:
					num = (short)258867201;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_67:
				num = (short)391938573;
				short num4 = num;
				num = (short)987202061;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_1C5:
					int num5;
					if (num5 >= 8)
					{
						num = (short)831651848;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_30;
					}
					short[] array;
					array[num5] = (short)serialNum[num5];
					num5++;
					num = (short)382861321;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				default:
				{
					num = (short)1970601984;
					if (num != 0)
					{
					}
					num = (short)2145320960;
					short num6 = num;
					result = false;
					short num3 = 0;
					short[] array = new short[8];
					int num5 = 0;
					num = (short)1027473408;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
				break;
			}
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003B5C File Offset: 0x00001D5C
		public bool FindFirst(int hSession, short family)
		{
			int a_ = 10;
			short num = (short)472383488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B8;
				}
				short[] array;
				short num3;
				bool result;
				for (;;)
				{
					IL_31:
					int num6;
					switch (num2)
					{
					case 0:
						num = (short)1059323905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if ((family & 127) != (array[0] & 127))
						{
							num = (short)1561853975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_237;
					case 2:
						if ((array[0] & 127) != 1)
						{
							num = (short)1965686787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_257;
					case 3:
						goto IL_237;
					case 4:
						goto IL_458;
					case 5:
						num = (short)775421976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						global::IBtnWrapperLib.TMEXAPI.TMFamilySearchSetup(hSession, global::IBtnWrapperLib.IBtnCommon.g, family);
						num3 = global::IBtnWrapperLib.TMEXAPI.TMNext(hSession, global::IBtnWrapperLib.IBtnCommon.g);
						num = (short)608567314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)1851517756;
						short num4 = num;
						num = (short)680520508;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4E8;
						default:
							goto IL_42F;
						}
						break;
					}
					case 8:
						if (family == 255)
						{
							num = (short)1170210832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_257;
					case 9:
					{
						if (global::IBtnWrapperLib.TMEXAPI.TMRom(hSession, global::IBtnWrapperLib.IBtnCommon.g, array) != 1)
						{
							num = (short)973668359;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2 = new byte[7];
						int num5 = 0;
						num = (short)335609887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_2EB;
					case 11:
						goto IL_1AE;
					case 12:
						if (family != 255)
						{
							num = (short)1031471110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = global::IBtnWrapperLib.TMEXAPI.TMFirst(hSession, global::IBtnWrapperLib.IBtnCommon.g);
						num = (short)2048524318;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_2E6;
					case 14:
						if (array[0] != 0)
						{
							num = (short)988938268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27E;
					case 15:
						if (num6 >= 8)
						{
							num = (short)920846362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.f[num6] = (byte)array[num6];
						num6++;
						goto IL_4E8;
					case 16:
						num = (short)95289346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						short num7;
						if (num7 >= 0)
						{
							num = (short)421855237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27E;
					}
					case 18:
						goto IL_2EB;
					case 19:
						if (num3 <= 0)
						{
							num = (short)956432409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[0] = 0;
						num = (short)817430537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (family != 255)
						{
							num = (short)549060608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_505;
					case 21:
					{
						int num5;
						if (num5 >= 7)
						{
							num = (short)2072379421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2;
						array2[num5] = (byte)array[num5];
						num5++;
						num = (short)1931542532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_584;
					case 23:
						goto IL_505;
					case 24:
					{
						short num7;
						if (array[7] != num7)
						{
							num = (short)1823539222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1801846804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_34A;
					case 26:
						this.e = (byte)array[0];
						result = true;
						num = (short)2016477197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_1AE;
					case 28:
					{
						num = (short)692846592;
						short num8 = num;
						num = (short)1279131665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
					{
						byte[] array2;
						short num7 = global::IBtnWrapperLib.TMEXAPI.TMCRC(7, array2, 0, 0);
						num = (short)1142095886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						goto IL_2EB;
					case 31:
						goto IL_458;
					}
					goto IL_B8;
					IL_1AE:
					num = (short)1505034255;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_237:
					num6 = 0;
					num = (short)456785931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_257:
					num3 = global::IBtnWrapperLib.TMEXAPI.TMNext(hSession, global::IBtnWrapperLib.IBtnCommon.g);
					num = (short)1564868618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EB:
					num = (short)1246822401;
					if (num != 0)
					{
					}
					num = (short)1639776275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_458:
					num = (short)522453013;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E8:
					num = (short)617938971;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_505:
					num = (short)606863368;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_27E:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ੂ⭄ㅆ⡈❊⑌⭎煐㩒᝔≖ⵘ⽚㉜ㅞ䅠ㅢ⩤⩦", a_));
				IL_2E6:
				IL_34A:
				return result;
				IL_42F:
				num = (short)1193541632;
				if (num != 0)
				{
				}
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ᙂ⭄♆⭈❊⡌潎═㱒畔╖㱘㩚㥜罞ࡠⅢၤ፦ᵨѪͬ佮⍰㱲㡴", a_));
				IL_584:
				goto IL_27E;
				IL_B8:
				result = false;
				array = new short[8];
				num3 = -1;
				num = (short)414515212;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00004164 File Offset: 0x00002364
		public bool FindNext(int hSession)
		{
			int a_ = 0;
			short num = (short)1385103360;
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
				short[] array;
				short num7;
				bool result;
				for (;;)
				{
					IL_32:
					short num6;
					int num8;
					switch (num2)
					{
					case 0:
						goto IL_2A8;
					case 1:
					{
						if (array[0] == 24)
						{
							goto IL_DA;
						}
						num = (short)1677996142;
						short num3 = num;
						num = (short)1853173870;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_483;
						default:
							num = (short)1268121600;
							if (num != 0)
							{
							}
							num = (short)1197932559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
					{
						int num4;
						if (num4 >= 7)
						{
							num = (short)950730761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2;
						array2[num4] = (byte)array[num4];
						num4++;
						num = (short)355729426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)1110573075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_30E;
					case 5:
						goto IL_DA;
					case 6:
						num = (short)2003697680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_30E;
					case 8:
						goto IL_3CD;
					case 9:
					{
						num = (short)48496640;
						short num5 = num;
						byte[] array2;
						num6 = global::IBtnWrapperLib.TMEXAPI.TMCRC(7, array2, 0, 0);
						num = (short)2082340874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (array[0] != 0)
						{
							num = (short)994770950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_255;
					case 11:
						num = (short)430047253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (num7 <= 0)
						{
							num = (short)199622679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[0] = 0;
						num = (short)1892417560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_2A8;
					case 14:
						if (num8 >= 8)
						{
							num = (short)910950420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.f[num8] = (byte)array[num8];
						num8++;
						num = (short)792395789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)202440729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (num6 >= 0)
						{
							num = (short)108396547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_255;
					case 17:
						goto IL_4A5;
					case 18:
						goto IL_269;
					case 19:
						goto IL_483;
					case 20:
						num = (short)53280769;
						if (num != 0)
						{
						}
						this.e = (byte)array[0];
						result = true;
						num = (short)133824538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (array[0] == 12)
						{
							num = (short)719388677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num7 = global::IBtnWrapperLib.TMEXAPI.TMNext(hSession, global::IBtnWrapperLib.IBtnCommon.g);
						num = (short)1921122308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_269;
					case 23:
						goto IL_346;
					case 24:
					{
						if (global::IBtnWrapperLib.TMEXAPI.TMRom(hSession, global::IBtnWrapperLib.IBtnCommon.g, array) != 1)
						{
							num = (short)410255368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2 = new byte[7];
						int num4 = 0;
						num = (short)2034958358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						if (array[0] != 4)
						{
							num = (short)42205195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DA;
					case 26:
						goto IL_1D6;
					}
					goto IL_A5;
					IL_DA:
					num8 = 0;
					num = (short)1983709184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_483:
					if (array[7] != num6)
					{
						num = (short)410779665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1082458113;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_269:
					num = (short)2117795842;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A8:
					num = (short)987693070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30E:
					num = (short)360579084;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1D6:
				return result;
				IL_255:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("瀸唺䬼帾ⵀ⩂⅄杆⁈ॊ㡌㭎═㱒㭔睖୘ᑚၜ", a_));
				IL_346:
				return result;
				IL_3CD:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("永唺尼崾ⵀ♂敄㍆♈歊㽌⩎ぐ㝒畔㹖᭘⹚⥜⭞๠ൢ䕤㕦♨♪", a_));
				IL_4A5:
				goto IL_255;
				IL_A5:
				result = false;
				array = new short[8];
				num7 = -1;
				num7 = global::IBtnWrapperLib.TMEXAPI.TMNext(hSession, global::IBtnWrapperLib.IBtnCommon.g);
				num = (short)318570503;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000468C File Offset: 0x0000288C
		public void FormatButton(int hSession)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			int num2;
			short num3;
			short num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (num2 > (int)this.c)
					{
						num3 = (short)1178796040;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num4 = global::IBtnWrapperLib.TMEXAPI.TMFormat(hSession, global::IBtnWrapperLib.IBtnCommon.g);
					num3 = (short)928251911;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					num3 = (short)2047410177;
					if (num3 != 0)
					{
					}
					goto IL_FF;
				case 2:
					global::IBtnWrapperLib.TMEXException.a(num4, global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMFormat, null);
					goto IL_189;
				case 3:
				{
					if (num4 == 1)
					{
						return;
					}
					num3 = (short)1507852288;
					short num5 = num3;
					num3 = (short)1118953580;
					short num6 = num3;
					num3 = (short)1559421036;
					switch ((num6 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_189;
					default:
						num3 = (short)1794048000;
						if (num3 != 0)
						{
						}
						num3 = (short)1354498050;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 4:
					return;
				case 5:
					goto IL_FF;
				case 6:
					num2++;
					num3 = (short)1280638977;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 7:
					if (num4 != 1)
					{
						num3 = (short)1509294086;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_51;
				case 8:
					goto IL_51;
				}
				goto IL_34;
				IL_51:
				num3 = (short)619380739;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_FF:
				num3 = (short)806748160;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_189:
				num3 = (short)1544749060;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_34:
			num4 = -1;
			num2 = 0;
			num3 = (short)1265958917;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00004884 File Offset: 0x00002A84
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
					num2++;
					num3 = (short)1360134157;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					goto IL_342;
				case 2:
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
						goto IL_260;
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
						num3 = (short)2126315535;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 3:
					if (hFile <= -1)
					{
						num3 = (short)640417797;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_100;
				case 4:
					goto IL_100;
				case 5:
				{
					short num4 = hFile;
					num3 = (short)899612684;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 6:
					goto IL_FB;
				case 7:
					if (hFile <= -1)
					{
						num3 = (short)629276680;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return;
				case 8:
				{
					num3 = (short)886308864;
					short num5 = num3;
					global::IBtnWrapperLib.TMEXException.a(hFile, global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMCreateFile, null);
					num3 = (short)1102184464;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 9:
					goto IL_342;
				case 10:
					if (!flag)
					{
						num3 = (short)436076544;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_100;
				case 11:
					goto IL_9D;
				case 12:
				{
					short num4;
					if (num4 - -201 > 1)
					{
						num3 = (short)582221830;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_260;
				}
				case 13:
					goto IL_1FB;
				case 14:
					goto IL_1FB;
				case 15:
					num3 = (short)1224081419;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 16:
					return;
				case 17:
				{
					if (num2 > (int)this.c)
					{
						num3 = (short)497483780;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					hFile = global::IBtnWrapperLib.TMEXAPI.TMCreateFile(hSession, global::IBtnWrapperLib.IBtnCommon.g, out maxBytes, fentry);
					num3 = (short)829100934;
					short num6 = num3;
					num3 = (short)626791302;
					switch ((num6 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FB;
					default:
						num3 = (short)1705508864;
						if (num3 != 0)
						{
						}
						num3 = (short)1068040195;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				}
				goto IL_58;
				IL_9D:
				flag = false;
				num3 = (short)1815805961;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_FB:
				num3 = (short)1525481474;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_100:
				num3 = (short)1684406279;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1FB:
				num3 = (short)852361233;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_260:
				num3 = (short)2105802753;
				if (num3 != 0)
				{
				}
				flag = true;
				num3 = (short)150798337;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_342:
				num3 = (short)1037697034;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_58:
			flag = false;
			maxBytes = 0;
			hFile = -1;
			num2 = 0;
			num3 = (short)114819086;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00004C2C File Offset: 0x00002E2C
		public byte[] GetROMSerialNum(int hSession, bool bForceRead)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			byte[] result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (bForceRead)
					{
						goto IL_61;
					}
					result = this.f;
					num2 = (short)213254147;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_B9;
				case 2:
					this.a(hSession, out result);
					num2 = (short)597819393;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_B9;
				}
				goto IL_20;
				IL_61:
				num2 = (short)1737687042;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_B9:
				num2 = (short)26516287;
				short num3 = num2;
				num2 = (short)1011129151;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_61;
				default:
					goto IL_EE;
				}
			}
			IL_EE:
			num2 = (short)1971388416;
			short num4 = num2;
			num2 = (short)1352597504;
			if (num2 != 0)
			{
			}
			return result;
			IL_20:
			result = null;
			num2 = (short)1046085633;
			if (num2 != 0)
			{
			}
			num2 = (short)2138701824;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00004D68 File Offset: 0x00002F68
		private void a(int A_0, out byte[] A_1)
		{
			short num = (short)517013504;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				int num3;
				short[] array;
				short num4;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_274;
					case 1:
						goto IL_1A9;
					case 2:
						goto IL_2B0;
					case 3:
						if (num3 > (int)this.c)
						{
							num = (short)1395720192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = global::IBtnWrapperLib.TMEXAPI.TMRom(A_0, global::IBtnWrapperLib.IBtnCommon.g, array);
						num = (short)629080071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_97;
					case 5:
					{
						int num5;
						if (num5 >= 8)
						{
							num = (short)1186463752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						short num6;
						this.f[num5] = (byte)(array[num5] & num6);
						num5++;
						num = (short)1939013633;
						if (num != 0)
						{
						}
						num = (short)110821388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_272;
					case 7:
						if (num4 != 1)
						{
							num = (short)379387917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_274;
					case 8:
						num = (short)1652883457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						short num6 = 255;
						int num5 = 0;
						num = (short)66191364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_2B0;
					case 11:
						if (num4 == 1)
						{
							num = (short)2038038537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::IBtnWrapperLib.TMEXException.a(num4, global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMRom, null);
						num = (short)1938554886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_97;
					case 13:
					{
						for (;;)
						{
							num3++;
							num = (short)583612784;
							short num7 = num;
							num = (short)380254576;
							switch ((num7 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_133;
							}
						}
						IL_133:
						num = (short)1892220928;
						if (num != 0)
						{
						}
						num = (short)1145438208;
						short num8 = num;
						num = (short)1955397634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_66;
					IL_97:
					num = (short)1028259845;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_274:
					num = (short)1239351307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B0:
					num = (short)273285123;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A9:
				IL_272:
				global::System.Array.Copy(this.f, A_1, this.f.Length);
				return;
				IL_66:
				num4 = 0;
				A_1 = new byte[8];
				array = new short[8];
				array[0] = 0;
				num3 = 0;
				num = (short)225771530;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000507C File Offset: 0x0000327C
		public void OpenFile(int hSession, out short hFile, byte[] fentry, bool bOkIfNotFound)
		{
			int a_ = 19;
			short num = (short)1182400512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B8;
				}
				bool flag;
				int num5;
				bool flag2;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						flag = false;
						global::System.Diagnostics.Trace.WriteLine(global::IBtnWrapperLib.TMEXException.g("ੋ❍㱏㝑瑓㡕㝗⹙籛ᡝཟᝡ੣ɥ䡧䭩", a_));
						num = (short)361824279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1490419712;
						short num3 = num;
						goto IL_DF;
					}
					case 2:
						goto IL_20C;
					case 3:
						num = (short)1884094477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (hFile > -1)
						{
							num = (short)1947860999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1471938576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_DF;
					case 6:
						global::IBtnWrapperLib.TMEXException.a(hFile, global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMOpenFile, null);
						num = (short)1611792396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						flag = true;
						num = (short)43122717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_50D;
					case 9:
						num = (short)450428958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (!bOkIfNotFound)
						{
							num = (short)282984454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
					{
						short num4;
						if (num4 - -201 > 1)
						{
							num = (short)675610633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50D;
					}
					case 12:
						return;
					case 13:
					{
						short num4;
						if (num4 != -5)
						{
							num = (short)684916756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50D;
					}
					case 14:
						if (num5 > (int)this.c)
						{
							num = (short)417529882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						hFile = global::IBtnWrapperLib.TMEXAPI.TMOpenFile(hSession, global::IBtnWrapperLib.IBtnCommon.g, fentry);
						num = (short)1008533508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1912012810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						if (hFile == -6)
						{
							num = (short)2069364736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						short num4 = hFile;
						num = (short)496304149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_18D;
					case 18:
					{
						short num4;
						if (num4 == -2)
						{
							num = (short)1186922504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20C;
					}
					case 19:
						goto IL_4CF;
					case 20:
						num = (short)1090650130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						short num4;
						if (num4 <= -26)
						{
							num = (short)405995542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1544945689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						num = (short)2111328156;
						short num6 = num;
						num = (short)1632784284;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4CF;
						default:
							num = (short)1630928897;
							if (num != 0)
							{
							}
							num = (short)34537472;
							if (num != 0)
							{
							}
							num = (short)482017291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 23:
						goto IL_385;
					case 24:
						goto IL_18D;
					case 25:
					{
						short num4;
						switch (num4)
						{
						case -18:
						case -16:
						case -14:
						case -13:
						case -9:
						case -8:
							goto IL_50D;
						case -17:
						case -15:
						case -12:
						case -11:
						case -10:
							goto IL_20C;
						default:
							num = (short)1252261891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 26:
						goto IL_385;
					case 27:
						num5++;
						num = (short)1575354385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (!flag2)
						{
							num = (short)586416155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_385;
					case 29:
						goto IL_385;
					case 30:
					{
						short num4;
						if (num4 != -26)
						{
							num = (short)474218515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50D;
					}
					case 31:
						if (!flag)
						{
							num = (short)937033743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_B8;
					IL_DF:
					num = (short)2015756316;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18D:
					num = (short)1371275278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20C:
					flag2 = false;
					num = (short)1667825665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_385:
					num = (short)460390431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CF:
					num = (short)2050293762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_50D:
					flag2 = true;
					num = (short)545783813;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_B8:
				flag2 = false;
				flag = false;
				hFile = -1;
				num5 = 0;
				num = (short)324534296;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00005624 File Offset: 0x00003824
		public void CloseFile(int hSession, ref short hFile)
		{
			switch (0)
			{
			case 0:
				goto IL_B0;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				bool flag;
				switch (num)
				{
				case 0:
					goto IL_254;
				case 1:
					num2 = (short)330170383;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)257949720;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (!flag)
					{
						num2 = (short)53411861;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23C;
				case 4:
					num2 = (short)269287451;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1476132899;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					int num3;
					if (num3 > (int)this.c)
					{
						num2 = (short)302252046;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					short num4 = global::IBtnWrapperLib.TMEXAPI.TMCloseFile(hSession, global::IBtnWrapperLib.IBtnCommon.g, hFile);
					num2 = (short)1725693980;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					goto IL_5F3;
				case 8:
				{
					short num4;
					if (num4 <= -16)
					{
						num2 = (short)1983250463;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1305149450;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
				{
					short num4;
					if (num4 != -16)
					{
						num2 = (short)1155006482;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_144;
				}
				case 10:
				{
					short num4;
					if (num4 <= -8)
					{
						num2 = (short)1486684179;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)61079589;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 11:
				{
					short num4;
					if (num4 <= -26)
					{
						num2 = (short)957677573;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2069889062;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 12:
					goto IL_350;
				case 13:
				{
					short num4;
					if (num4 != -26)
					{
						num2 = (short)1999372289;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_144;
				}
				case 14:
					goto IL_23C;
				case 15:
					goto IL_5F3;
				case 16:
					goto IL_497;
				case 17:
					num2 = (short)1900478471;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					num2 = (short)536150039;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					num2 = (short)177405974;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					goto IL_2ED;
				case 21:
				{
					int num3;
					num3++;
					num2 = (short)1196883988;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 22:
				{
					short num4;
					if (num4 != -13)
					{
						num2 = (short)661520386;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_144;
				}
				case 23:
					goto IL_5F3;
				case 24:
				{
					short num4;
					if (num4 != -8)
					{
						num2 = (short)216662033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					hFile = -1;
					flag = true;
					num2 = (short)1502806032;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 25:
					goto IL_23C;
				case 26:
					num2 = (short)2130116621;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
				{
					short num4;
					if (num4 == -2)
					{
						num2 = (short)14483485;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5F3;
				}
				case 28:
				{
					short num4;
					if (1 == num4)
					{
						num2 = (short)1430126631;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)127991816;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 29:
					goto IL_144;
				case 30:
					goto IL_497;
				case 31:
					num2 = (short)2028404747;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					goto IL_2ED;
				case 33:
					num2 = (short)140705793;
					if (num2 != 0)
					{
					}
					num2 = (short)713883657;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
				{
					short num4;
					global::System.Diagnostics.Trace.WriteLine(global::IBtnWrapperLib.TMEXException.f(num4, global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMCloseFile));
					num2 = (short)1414135820;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 35:
				{
					short num4;
					if (num4 - -201 > 1)
					{
						num2 = (short)1073020954;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_144;
				}
				case 36:
					goto IL_497;
				case 37:
				{
					short num4;
					if (num4 != -6)
					{
						num2 = (short)47251460;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_144;
				}
				case 38:
				{
					short num4;
					if (num4 != -18)
					{
						num2 = (short)639107105;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_144;
				}
				case 39:
					hFile = -1;
					num2 = (short)1535115289;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_B0;
				IL_144:
				hFile = -1;
				flag = true;
				num2 = (short)1781071908;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_23C:
				num2 = (short)1330446336;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2ED:
				num2 = (short)1942814726;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_497:
				num2 = (short)1183383555;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5F3:
				flag = false;
				num2 = (short)1329856542;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_350:
			return;
			IL_B0:
			num2 = (short)485336530;
			short num5 = num2;
			num2 = (short)1644275154;
			switch ((num5 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_254:
				short num4;
				if (num4 != 1)
				{
					num2 = (short)416219170;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			}
			default:
			{
				num2 = (short)296615936;
				short num6 = num2;
				num2 = (short)52297728;
				if (num2 != 0)
				{
				}
				short num4 = 0;
				int num3 = 0;
				num2 = (short)753270816;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00005C44 File Offset: 0x00003E44
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
					global::IBtnWrapperLib.TMEXException.a(num2, global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMDeleteFile, null);
					num3 = (short)1617428488;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					if (1 != num2)
					{
						num3 = (short)748421123;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_28F;
				case 2:
					goto IL_28F;
				case 3:
				{
					num3 = (short)1398210560;
					short num4 = num3;
					num3 = (short)781058068;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 4:
					goto IL_98;
				case 5:
					num3 = (short)882573322;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 6:
					num3 = (short)1151729681;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 7:
					num5++;
					num3 = (short)552468501;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 8:
					return;
				case 9:
					if (num2 != 1)
					{
						num3 = (short)40501248;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return;
				case 10:
					goto IL_1A2;
				case 11:
					if (num2 - -201 > 1)
					{
						num3 = (short)766836748;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_D1;
				case 12:
					num3 = (short)1649082386;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 13:
					goto IL_128;
				case 14:
					if (num5 > (int)this.c)
					{
						num3 = (short)731054082;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num2 = global::IBtnWrapperLib.TMEXAPI.TMDeleteFile(hSession, global::IBtnWrapperLib.IBtnCommon.g, fentry);
					num3 = (short)118882305;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 15:
					switch (num2)
					{
					case -18:
					case -16:
					case -15:
					case -14:
					case -13:
					case -12:
					case -8:
						goto IL_D1;
					case -17:
					case -11:
					case -10:
					case -9:
						goto IL_1A2;
					default:
						num3 = (short)462159878;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				case 16:
					if (num2 <= -26)
					{
						num3 = (short)635568150;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)360448015;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 17:
					if (num2 == -2)
					{
						num3 = (short)1712586771;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1A2;
				case 18:
					if (num2 != -26)
					{
						num3 = (short)35651589;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_D1;
				case 19:
					goto IL_D1;
				case 20:
					if (num2 != -6)
					{
						num3 = (short)2103246871;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_28F;
				case 21:
				{
					num3 = (short)1740570625;
					if (num3 != 0)
					{
					}
					num3 = (short)1417412658;
					short num6 = num3;
					num3 = (short)928972850;
					switch ((num6 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D3;
					default:
						num3 = (short)840761344;
						if (num3 != 0)
						{
						}
						goto IL_128;
					}
					break;
				}
				case 22:
					num3 = (short)1356988427;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 23:
					num3 = (short)1777008656;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 24:
					if (!flag)
					{
						num3 = (short)90374151;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_28F;
				case 25:
					goto IL_98;
				}
				goto IL_78;
				IL_98:
				num3 = (short)12845080;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_D3:
				num3 = (short)925958148;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_D1:
				flag = true;
				goto IL_D3;
				IL_128:
				num3 = (short)1651310606;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1A2:
				flag = false;
				num3 = (short)699465753;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_28F:
				num3 = (short)2042167305;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_78:
			num2 = 0;
			num5 = 0;
			num3 = (short)1281753101;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000060B4 File Offset: 0x000042B4
		public bool WriteFile(int hSession, byte[] fentry, byte[] ptrDataArr, int nFileLen, short startPage)
		{
			int a_ = 13;
			short num = (short)1286799360;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_208;
				}
				byte[] array;
				byte[] array2;
				bool flag;
				int num7;
				int num9;
				for (;;)
				{
					IL_31:
					ushort num11;
					byte b;
					byte[] array5;
					switch (num2)
					{
					case 0:
					{
						int num3;
						int num4;
						if (num3 >= ((num4 > 28) ? 28 : num4))
						{
							num = (short)1482883182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5;
						array[num3 + 1] = ptrDataArr[num5++];
						num3++;
						num = (short)1253179468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (fentry == null)
						{
							num = (short)899416111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33B;
					case 2:
					{
						int num3;
						ushort num6;
						if (!this.WriteScratch(hSession, num6, array2, num3))
						{
							num = (short)1236271199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1132;
					}
					case 3:
						if (flag)
						{
							num = (short)1210712151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1132;
					case 4:
						goto IL_971;
					case 5:
					{
						ushort num6;
						if (this.FormatUDP(num6, ref array2, ref num7))
						{
							num = (short)996212829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)1100480528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num7 = 32;
						num = (short)1392509030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (this.FindDevice(hSession, ref this.e))
						{
							num = (short)1584463960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)188022864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!this.EraseScratchSHA(hSession))
						{
							num = (short)1339424786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4B;
					case 9:
					{
						int num3;
						int num8;
						if (num3 >= num8)
						{
							num = (short)2080702571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array3;
						array3[num3] = (byte)((int)startPage + num3);
						num3++;
						num = (short)86638645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_7EE;
					case 11:
						goto IL_D14;
					case 12:
					{
						int num3;
						if (num3 >= num9)
						{
							num = (short)152961048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array4;
						array2[num3] = array4[num3];
						num3++;
						num = (short)1442250820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						ushort num6;
						int num3 = (int)(32 - (num6 & 31));
						num = (short)1798111246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_B7B;
					case 15:
					{
						ushort num6;
						if (num7 > (int)(32 - (num6 & 31)))
						{
							num = (short)1299841094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3 = num7;
						num = (short)1907097610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_BC1;
					case 17:
						goto IL_971;
					case 18:
						flag = false;
						num = (short)2083455089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						ushort num6;
						if (!this.CopyScratch(hSession, num6, num7))
						{
							num = (short)816054302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num10;
						num10++;
						num = (short)413401194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						num = (short)431816712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						int num3;
						if (num3 >= 5)
						{
							goto IL_7D0;
						}
						byte[] array4;
						array4[num3 + 8] = fentry[num3];
						num3++;
						num = (short)1179058259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						num = (short)1949892706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_A8F;
					case 24:
					{
						num7 = num9;
						ushort num6 = (ushort)(array2[0] << 5);
						int num3 = 1;
						num = (short)1819541547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						byte[] array3;
						byte[] array4;
						array4[13] = array3[0];
						int num8;
						array4[14] = (byte)num8;
						int num3 = 0;
						num = (short)860946494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						goto IL_7EE;
					case 27:
						goto IL_F8E;
					case 28:
						goto IL_BC1;
					case 29:
						flag = false;
						num = (short)468516929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						flag = false;
						num = (short)880017513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						flag = false;
						num = (short)2144796754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (this.ReadScratch(hSession, ref num11, ref b, out array5))
						{
							num = (short)403832884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)888537121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_E78;
					case 34:
					{
						ushort num6;
						if (!this.CopyScratch(hSession, num6, num7))
						{
							num = (short)1634926621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12EC;
					}
					case 35:
						goto IL_2A5;
					case 36:
						goto IL_A8F;
					case 37:
						num = (short)442302527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						flag = false;
						num = (short)669909050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						int num8 = nFileLen / 28 + ((nFileLen % 28 > 0) ? 1 : 0);
						byte[] array3 = new byte[num8];
						int num3 = 0;
						num = (short)1411842127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						flag = false;
						num = (short)763953261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_7AF;
					case 42:
						if (flag)
						{
							num = (short)1498021974;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12EC;
					case 43:
						goto IL_FFF;
					case 44:
						if (!this.EraseScratchSHA(hSession))
						{
							num = (short)897843304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED2;
					case 45:
						flag = false;
						num = (short)1675493453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						goto IL_F8E;
					case 47:
					{
						string s = global::IBtnWrapperLib.TMEXException.g("୅݇ṉੋ繍", a_);
						fentry = new global::System.Text.ASCIIEncoding().GetBytes(s);
						num = (short)1803223131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
					{
						int num3;
						if (num3 >= num9)
						{
							num = (short)50135118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array2[num3] = array[num3];
						num3++;
						num = (short)1289945134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
					{
						int num3;
						int num12;
						if (num12 >= num3)
						{
							num = (short)1581252693;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)596967536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
						num = (short)793903111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						goto IL_B7B;
					case 52:
					{
						int num12 = 0;
						num = (short)402587665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
						goto IL_366;
					case 54:
						goto IL_B3C;
					case 55:
						if (flag)
						{
							num = (short)1682505765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED2;
					case 56:
						goto IL_59A;
					case 57:
						goto IL_BC1;
					case 58:
						goto IL_6DB;
					case 59:
						if (flag)
						{
							num = (short)1506410565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12EC;
					case 60:
						goto IL_1132;
					case 61:
					{
						int num3;
						int num13;
						if (num13 >= num3)
						{
							num = (short)1026687077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)733151306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
						goto IL_2A5;
					case 63:
						if (this.e == 24)
						{
							num = (short)1920925786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED2;
					case 64:
						flag = false;
						num = (short)1539440743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						goto IL_11CD;
					case 66:
					{
						num = (short)1170803528;
						short num14 = num;
						num = (short)594479944;
						switch ((num14 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7D0;
						default:
						{
							num = (short)2079457280;
							if (num != 0)
							{
							}
							int num3;
							if (num3 > num7)
							{
								num = (short)1667498083;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array2[num3 - 1] = array2[num3];
							num3++;
							num = (short)1294532722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 67:
					{
						int num13 = 0;
						num = (short)1050279972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 68:
						goto IL_B3C;
					case 69:
						num = (short)293077026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
					{
						ushort num6;
						int num3 = (int)(32 - (num6 & 31));
						num = (short)1395851290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 71:
					{
						ushort num6;
						if (this.FormatUDP(num6, ref array2, ref num7))
						{
							num = (short)224985094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)288227409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 72:
					{
						int num3;
						int num8;
						if (num3 >= num8)
						{
							num = (short)767033394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array3;
						byte[] array4;
						this.a(1, 1, (int)array3[num3], ref array4, 4);
						num3++;
						num = (short)1840054307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 73:
						num7--;
						num = (short)1325203527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
					{
						int num13;
						byte[] array6;
						if (array6[num13] != array2[num13])
						{
							num = (short)1098514470;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num13++;
						num = (short)1103691799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 75:
					{
						byte b2;
						if ((b2 & 32) == 32)
						{
							num = (short)1297219648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)973602835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 76:
						goto IL_59A;
					case 77:
						goto IL_AD4;
					case 78:
					{
						num7 = num9;
						ushort num6 = (ushort)(array2[0] << 5);
						int num3 = 1;
						num = (short)1542520928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 79:
						goto IL_366;
					case 80:
						goto IL_54B;
					case 81:
						goto IL_67C;
					case 82:
						num = (short)845414401;
						if (num != 0)
						{
						}
						goto IL_E78;
					case 83:
						goto IL_7AF;
					case 84:
					{
						int num3;
						int num4;
						byte[] array3;
						int num10;
						array[num3 + 1] = ((num4 == 0) ? 0 : array3[num10 + 1]);
						num9 = num3 + 2;
						num3 = 0;
						num = (short)233570331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
						goto IL_AD4;
					case 86:
					{
						num9 = 16;
						int num3 = 0;
						num = (short)338952246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 87:
						num = (short)114688002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
					{
						int num4 = nFileLen;
						int num5 = 0;
						int num10 = 0;
						num = (short)581435403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 89:
					{
						int num4;
						if (num4 <= 0)
						{
							num = (short)45482012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array3;
						int num10;
						array[0] = array3[num10];
						int num3 = 0;
						num = (short)881328184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 90:
						num = (short)1763246124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						goto IL_33B;
					case 92:
					{
						ushort num6;
						if (num7 > (int)(32 - (num6 & 31)))
						{
							num = (short)1253834765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3 = num7;
						num = (short)1411383347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 93:
						num7 = 32;
						num = (short)543817750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 94:
					{
						int num3;
						ushort num6;
						if (!this.WriteScratch(hSession, num6, array2, num3))
						{
							num = (short)73728040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num15 = 0;
						byte b2 = 0;
						byte[] array6 = new byte[32];
						num = (short)327483507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 95:
						flag = false;
						num = (short)216006716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						goto IL_8E6;
					case 97:
						goto IL_FFF;
					case 98:
						if (this.e == 24)
						{
							num = (short)1213857812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4B;
					case 99:
						num7--;
						num = (short)732037125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 100:
						goto IL_ED2;
					case 101:
						goto IL_6DB;
					case 102:
						goto IL_67C;
					case 103:
						goto IL_BC1;
					case 104:
					{
						flag = false;
						num = (short)539951104;
						short num16 = num;
						num = (short)1321009252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 105:
						goto IL_BC1;
					case 106:
						goto IL_D14;
					case 107:
					{
						byte[] array4 = new byte[]
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
						int num3 = 0;
						num = (short)443875369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 108:
						if ((b & 32) == 32)
						{
							num = (short)1957429279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E78;
					case 109:
						goto IL_BC1;
					case 110:
					{
						int num3;
						int num4;
						num4 -= num3;
						num = (short)1911554132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 111:
					{
						int num3;
						if (num3 > num7)
						{
							num = (short)1159004233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array2[num3 - 1] = array2[num3];
						num3++;
						num = (short)543621217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 112:
					{
						int num12;
						if (array5[num12] != array2[num12])
						{
							num = (short)1774321709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num12++;
						num = (short)352583684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 113:
						goto IL_BC1;
					case 114:
						goto IL_8E6;
					case 115:
					{
						byte[] array6;
						byte b2;
						ushort num15;
						if (this.ReadScratch(hSession, ref num15, ref b2, out array6))
						{
							num = (short)64618563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)1040056377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_208;
					IL_2A5:
					num = (short)308084808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33B:
					num = (short)1655308327;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_366:
					num = (short)496435209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_59A:
					num = (short)1145241600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_67C:
					num = (short)1528823863;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6DB:
					num = (short)1930690635;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7AF:
					num = (short)66453525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7D0:
					num = (short)1204092953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7EE:
					num = (short)2110390275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8E6:
					num = (short)1917321282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_971:
					num = (short)1250689073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A8F:
					num = (short)848756797;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AD4:
					num = (short)1727529068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B3C:
					num = (short)806486028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B7B:
					num = (short)2110521438;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BC1:
					num = (short)1857486890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C4B:
					num = (short)1348468828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D14:
					num = (short)1181155417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E78:
					num = (short)595918907;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ED2:
					num = (short)1201864719;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F8E:
					num = (short)308215856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FFF:
					num = (short)2146369647;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1132:
					num11 = 0;
					b = 0;
					array5 = new byte[32];
					num = (short)48431136;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_54B:
				IL_11CD:
				IL_12EC:
				this.ResetSpeed(hSession);
				return flag;
				IL_208:
				flag = true;
				array = new byte[32];
				num9 = 0;
				num7 = 0;
				array2 = new byte[64];
				num = (short)822476801;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000073B8 File Offset: 0x000055B8
		public bool ReadFile(int hSession, byte[] fentry, ref short start_pg, ref short nNumBytesToRead, out byte[] ptrDataArr)
		{
			int a_ = 9;
			short num = (short)1875968000;
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
				byte[] array;
				int num3;
				byte b;
				int num4;
				bool flag;
				byte b2;
				byte[] array2;
				int num8;
				int num9;
				for (;;)
				{
					IL_30:
					int num7;
					switch (num2)
					{
					case 0:
						b = array[num3 - 1];
						num = (short)1332936758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_A75;
					case 2:
						goto IL_AB0;
					case 3:
						goto IL_AEA;
					case 4:
						goto IL_7A8;
					case 5:
						if (fentry[0] == array[num4])
						{
							num = (short)821690412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B7;
					case 6:
						num = (short)925106235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_A2C;
					case 8:
						b = array[num4 + 5];
						start_pg = (short)b;
						num = (short)1488715804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (fentry[3] == array[num4 + 3])
						{
							num = (short)407699462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B7;
					case 10:
						goto IL_9E0;
					case 11:
						if (b != 0)
						{
							num = (short)1506869251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)912916549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (b2 != 0)
						{
							num = (short)1009057855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB0;
					case 13:
						goto IL_3DB;
					case 14:
						goto IL_76A;
					case 15:
					{
						if (num4 < 28)
						{
							num = (short)1202716693;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)164675888;
						short num5 = num;
						num = (short)713474352;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_219;
						default:
							num = (short)677380096;
							if (num != 0)
							{
							}
							num = (short)94633988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 16:
					{
						num = (short)645726208;
						short num6 = num;
						flag = false;
						num = (short)1245904945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_8FD;
					case 18:
						num = (short)929169417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (!this.ReadUDP(hSession, (ushort)(b2 << 5), out array, ref num3))
						{
							num = (short)803536912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)348061757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num7 = 7;
						goto IL_789;
					case 21:
						if (array.Length >= num4 + 4)
						{
							num = (short)924450842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A8;
					case 22:
						if (num4 >= num3 - 1)
						{
							num = (short)1703739392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array2[num8++] = array[num4];
						num4++;
						num = (short)1305804858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (b != 0)
						{
							num = (short)263061506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A2C;
					case 24:
						goto IL_8FD;
					case 25:
						num = (short)570949665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)1000800261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)209977397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_7A8;
					case 29:
						if (num8 > (int)nNumBytesToRead)
						{
							num = (short)1375076417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						nNumBytesToRead = (short)num8;
						num = (short)462946328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (ptrDataArr != null)
						{
							num = (short)457179188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B56;
					case 31:
						if (!this.ReadUDP(hSession, (ushort)(b << 5), out array, ref num3))
						{
							num = (short)2136211495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1896480805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_97F;
					case 33:
						if (array[1] == 0)
						{
							num = (short)474808382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76A;
					case 34:
						num9 = 7057;
						array2 = new byte[7057];
						num = (short)199950368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (b2 != 0)
						{
							num = (short)1323434020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)96600084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)1837498432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (num3 + num8 - 1 > num9)
						{
							num = (short)1649279042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = 0;
						num = (short)496173123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (flag)
						{
							num = (short)1450901555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B56;
					case 39:
						flag = false;
						num = (short)374472705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (this.e == 12)
						{
							num = (short)904855553;
							if (num != 0)
							{
							}
							num = (short)2126577698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num9 = 420;
						array2 = new byte[420];
						num = (short)1443495984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (array[0] == 170)
						{
							num = (short)1196490777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76A;
					case 42:
						goto IL_A75;
					case 43:
					{
						string s = global::IBtnWrapperLib.TMEXException.g("ཁୃቅ็穉", a_);
						fentry = new global::System.Text.ASCIIEncoding().GetBytes(s);
						num = (short)500891655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
						num = (short)1187053614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						goto IL_21E;
					case 46:
						if (fentry[1] == array[num4 + 1])
						{
							num = (short)1211760667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B7;
					case 47:
						if (fentry == null)
						{
							num = (short)1660354603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A2C;
					case 48:
						goto IL_97F;
					case 49:
						goto IL_AB0;
					case 50:
						goto IL_21E;
					case 51:
						num = (short)1465188381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						global::System.Array.Copy(array2, ptrDataArr, (int)nNumBytesToRead);
						flag = true;
						num = (short)1075052554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						if (fentry[2] == array[num4 + 2])
						{
							num = (short)725811218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B7;
					case 54:
						if (b == 0)
						{
							num = (short)311885892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AEA;
					case 55:
						if ((num3 - 1) % 7 > 0)
						{
							num = (short)2097676302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1962606627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						num = (short)51970089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_AB0;
					case 58:
						goto IL_70F;
					case 59:
						if (fentry[4] == (array[num4 + 4] & 127))
						{
							num = (short)652541960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B7;
					case 60:
						if (num3 >= 7)
						{
							num = (short)336723981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76A;
					case 61:
						if (b2 == 0)
						{
							num = (short)542048312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DB;
					case 62:
						num = (short)1545207868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						num = (short)84410391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						num7 = 0;
						goto IL_789;
					case 65:
						num8 = (int)nNumBytesToRead;
						num = (short)1452081169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						goto IL_219;
					case 67:
						goto IL_70F;
					case 68:
						goto IL_A75;
					case 69:
						goto IL_479;
					}
					goto IL_14F;
					IL_219:
					flag = false;
					num = (short)108593194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21E:
					num = (short)548864015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B7:
					num4 += 7;
					num = (short)469368882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DB:
					num = (short)726138935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_70F:
					num = (short)1571094550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_76A:
					flag = false;
					num = (short)2102722617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_789:
					num4 = num7;
					num = (short)432865325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A8:
					b2 = array[num3 - 1];
					num = (short)2065301516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8FD:
					ptrDataArr = new byte[(int)nNumBytesToRead];
					num = (short)1264910366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_97F:
					num = (short)842989615;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A2C:
					num = (short)1613365267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A75:
					num = (short)1191837734;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB0:
					num = (short)122355723;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AEA:
					num = (short)1021050911;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_479:
				IL_9E0:
				IL_B56:
				this.ResetSpeed(hSession);
				return flag;
				IL_14F:
				flag = true;
				b2 = 0;
				b = 0;
				array = new byte[32];
				num8 = 0;
				num4 = 0;
				num3 = 0;
				ptrDataArr = null;
				num9 = 0;
				array2 = null;
				num = (short)146407464;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00007F24 File Offset: 0x00006124
		public void ResetSpeed(int hSession)
		{
			short num = (short)85721088;
			short num2 = num;
			num = (short)1671823360;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)508952577;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
				{
					num = (short)2024997028;
					short num4 = num;
					num = (short)2064973988;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)169213952;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_CE;
						}
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					global::IBtnWrapperLib.TMEXAPI.TMOneWireCom(hSession, 0, 0);
					global::IBtnWrapperLib.IBtnCommon.h[0] = global::System.Convert.ToByte(global::IBtnWrapperLib.TMEXAPI.TMOneWireCom(hSession, 1, 0) == 1);
					num = (short)780599297;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CE:
				if (global::IBtnWrapperLib.IBtnCommon.h[0] <= 0)
				{
					break;
				}
				num = (short)888078338;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000805C File Offset: 0x0000625C
		public void WriteFile(int hSession, short hFile, byte[] pFileData, short numBytes)
		{
			for (;;)
			{
				IL_00:
				short num = (short)616562688;
				short num2 = num;
				num = (short)1423310849;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_A9;
				}
				int num3;
				short num4;
				int num5;
				for (;;)
				{
					IL_5B:
					bool flag;
					switch (num3)
					{
					case 0:
						goto IL_335;
					case 1:
						if (num4 <= 0)
						{
							num = (short)503250957;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						goto IL_1C9;
					case 3:
						goto IL_E6;
					case 4:
						if (!flag)
						{
							num = (short)361627660;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_145;
					case 5:
						num = (short)1630666761;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_335;
					case 7:
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
							goto IL_279;
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
							goto IL_E6;
						default:
							num = (short)441057296;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 8:
						num = (short)1588985863;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (hFile - -201 > 1)
						{
							num = (short)1399717896;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					case 10:
						goto IL_1C9;
					case 11:
						goto IL_145;
					case 12:
						num5++;
						num = (short)1973420042;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						num = (short)1503082273;
						short num6 = num;
						num = (short)450246433;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1292173312;
							if (num != 0)
							{
							}
							global::IBtnWrapperLib.TMEXException.a(num4, global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMWriteFile, null);
							num = (short)719978513;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 14:
						if (num4 <= 0)
						{
							num = (short)867893253;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_145;
					case 15:
						if (num5 > (int)this.c)
						{
							num = (short)1687748619;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = global::IBtnWrapperLib.TMEXAPI.TMWriteFile(hSession, global::IBtnWrapperLib.IBtnCommon.g, hFile, pFileData, numBytes);
						num = (short)2021457934;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)273154051;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						return;
					}
					break;
					IL_E6:
					flag = false;
					num = (short)954073094;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_145:
					num = (short)1987444737;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C9:
					num = (short)1717436431;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_279:
					flag = true;
					num = (short)2033451008;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_335:
					num = (short)1676673028;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_A9:
				num4 = -1;
				num5 = 0;
				num = (short)1738342402;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5B;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000083F4 File Offset: 0x000065F4
		public void ReadFile(int hSession, short hFile, ref short pNumBytesToRead, out byte[] pFileData)
		{
			short num = (short)604045312;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)509083648;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_C4;
				}
				byte[] array;
				short buff_size;
				short num5;
				for (;;)
				{
					IL_51:
					int num4;
					bool flag;
					switch (num2)
					{
					case 0:
						num = (short)1302528008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)955252737;
						if (num != 0)
						{
						}
						num = (short)2004090901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num4++;
						num = (short)1115619345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_4D9;
					case 4:
						goto IL_41F;
					case 5:
						if (!flag)
						{
							num = (short)344457218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A0;
					case 6:
						if (num4 > (int)this.c)
						{
							num = (short)204472339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = global::IBtnWrapperLib.TMEXAPI.TMReadFile(hSession, global::IBtnWrapperLib.IBtnCommon.g, hFile, array, buff_size);
						num = (short)787218447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_10E;
					case 8:
						goto IL_154;
					case 9:
						if (this.e == 12)
						{
							num = (short)530645003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						buff_size = 420;
						array = new byte[420];
						goto IL_261;
					case 10:
						if (num5 != -26)
						{
							num = (short)689504281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C2;
					case 11:
						buff_size = 7057;
						array = new byte[7057];
						num = (short)410779668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)823328781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (num5 > pNumBytesToRead)
						{
							num = (short)710737944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						pNumBytesToRead = num5;
						num = (short)310247438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_2BD;
					case 15:
						if (num5 < 0)
						{
							num = (short)905707521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A0;
					case 16:
						num = (short)987561994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_10E;
					case 18:
						goto IL_24B;
					case 19:
						goto IL_4A0;
					case 20:
						goto IL_41F;
					case 21:
						if (num5 - -201 > 1)
						{
							num = (short)1372127248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C2;
					case 22:
						if (num5 >= 0)
						{
							num = (short)532217868;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_511;
					case 23:
						goto IL_4D9;
					case 24:
					{
						num5 = pNumBytesToRead;
						num = (short)390649656;
						short num6 = num;
						num = (short)287889208;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_261;
						default:
							num = (short)455868416;
							if (num != 0)
							{
							}
							num = (short)478019602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 25:
						num = (short)1511587866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						switch (num5)
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
							goto IL_2C2;
						case -17:
						case -15:
						case -12:
						case -11:
						case -10:
						case -7:
						case -5:
						case -3:
							goto IL_154;
						default:
							num = (short)741670912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					goto IL_C4;
					IL_10E:
					num = (short)1159725062;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_154:
					flag = false;
					num = (short)253624323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_261:
					num = (short)1518338052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C2:
					flag = true;
					num = (short)876478487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41F:
					pFileData = null;
					flag = false;
					num4 = 0;
					num = (short)114425863;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A0:
					num = (short)1601175574;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D9:
					num = (short)1836253189;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_24B:
				IL_2BD:
				pFileData = new byte[(int)num5];
				global::System.Array.Copy(array, pFileData, (int)num5);
				return;
				IL_511:
				global::IBtnWrapperLib.TMEXException.a(num5, global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMReadFile, null);
				return;
				IL_C4:
				array = null;
				buff_size = 0;
				num5 = -1;
				num = (short)1376265;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000891C File Offset: 0x00006B1C
		public bool ReadUDP(int hSession, ushort address, out byte[] page_data, ref int length)
		{
			bool result;
			for (;;)
			{
				IL_00:
				short num = (short)1805320192;
				short num2 = num;
				num = (short)305659904;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_9C;
					}
					byte[] array;
					short num4;
					for (;;)
					{
						IL_51:
						switch (num3)
						{
						case 0:
							if (global::IBtnWrapperLib.TMEXAPI.TMBlockStream(hSession, array, num4) == num4)
							{
								num = (short)829227019;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 1:
							if (this.Select(hSession))
							{
								num = (short)1326710793;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 2:
						{
							page_data = new byte[length];
							int num5 = 0;
							num5 = 0;
							num = (short)93913095;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							result = true;
							num = (short)324337680;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_32A;
						case 5:
						{
							int num5;
							if (num5 >= length)
							{
								num = (short)919863304;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							short num6;
							page_data[num5] = array[num5 + 1 + (int)num6];
							ushort num7 = this.a((ushort)page_data[num5], num7);
							num5++;
							num = (short)1017184270;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_32A;
						case 7:
							goto IL_EB;
						case 8:
						{
							int num5;
							short num6;
							ushort num7 = this.a((ushort)array[num5 + 1 + (int)num6], num7);
							num7 = this.a((ushort)array[num5 + 2 + (int)num6], num7);
							num = (short)974389261;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							byte[] array2 = array;
							short num8 = num4;
							num4 = num8 + 1;
							array2[(int)num8] = 240;
							byte[] array3 = array;
							short num9 = num4;
							num4 = num9 + 1;
							array3[(int)num9] = (byte)(address & 255);
							byte[] array4 = array;
							short num10 = num4;
							num4 = num10 + 1;
							array4[(int)num10] = (byte)(address >> 8 & 255);
							short num6 = num4;
							int num11 = 0;
							num = (short)1982267396;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							num = (short)599392256;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							ushort num7 = (ushort)(address >> 5);
							short num6;
							length = (int)array[(int)num6];
							num7 = this.a((ushort)length, num7);
							num = (short)833028108;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							num = (short)1625817089;
							if (num != 0)
							{
							}
							if (length <= 29)
							{
								num = (short)681508866;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 13:
						{
							ushort num7;
							if (num7 == 45057)
							{
								num = (short)364249091;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						case 14:
							goto IL_EB;
						case 15:
						{
							int num11;
							if (num11 >= 32)
							{
								num = (short)1962475530;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] array5 = array;
							short num12 = num4;
							num4 = num12 + 1;
							array5[(int)num12] = 255;
							num11++;
							num = (short)1764337827;
							short num13 = num;
							num = (short)1803856035;
							switch ((num13 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)795344896;
								if (num != 0)
								{
								}
								num = (short)2092040198;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 16:
							return result;
						}
						break;
						IL_EB:
						num = (short)788201477;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_32A:
						num = (short)1545666575;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_9C:
					result = false;
					array = new byte[50];
					num4 = 0;
					page_data = null;
					num = (short)199294977;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_51;
				}
				}
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00008D14 File Offset: 0x00006F14
		public bool FormatUDP(ushort address, ref byte[] write_buf, ref int write_len)
		{
			short num = (short)1544880128;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_84;
				}
				int num3;
				byte[] array;
				bool result;
				for (;;)
				{
					IL_27:
					num = (short)220397569;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						write_len = num3;
						num = (short)829292549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_222;
					case 2:
					{
						num = (short)1168788233;
						short num4 = num;
						num = (short)1194412809;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_25D;
						default:
						{
							num = (short)1010368512;
							short num5 = num;
							num = (short)65863680;
							if (num != 0)
							{
							}
							ushort num6;
							array[num3++] = (byte)(~(byte)(num6 & 255));
							array[num3++] = (byte)(~(byte)((num6 & 65280) >> 8));
							int num7 = 0;
							num = (short)516554759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						result = false;
						num = (short)1030684681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (write_len > 29)
						{
							num = (short)256704515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num6 = (ushort)(address >> 5);
						array[num3++] = (byte)write_len;
						num6 = this.a((ushort)write_len, num6);
						int num8 = 0;
						num = (short)257228808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						return result;
					case 6:
						goto IL_25D;
					case 7:
						goto IL_222;
					case 8:
						goto IL_25D;
					case 9:
						return result;
					case 10:
					{
						int num8;
						if (num8 >= write_len)
						{
							num = (short)1897136130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num6 = this.a((ushort)write_buf[num8], num6);
						array[num3++] = write_buf[num8];
						num8++;
						num = (short)565182470;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						int num7;
						if (num7 >= num3)
						{
							num = (short)1468661760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						write_buf[num7] = array[num7];
						num7++;
						num = (short)451018753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_84;
					IL_222:
					num = (short)1900675083;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25D:
					num = (short)2080047114;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_84:
				array = new byte[32];
				num3 = 0;
				result = true;
				num = (short)1796276228;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00008FF8 File Offset: 0x000071F8
		private ushort a(ushort A_0, ushort A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if ((global::IBtnWrapperLib.IBtnCommon.i[(int)(A_0 & 15)] ^ global::IBtnWrapperLib.IBtnCommon.i[A_0 >> 4]) > 0)
					{
						num2 = (short)118751234;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13A;
				case 1:
					goto IL_C3;
				case 2:
					A_1 ^= 49153;
					num2 = (short)715980801;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_C3:
			num2 = (short)40894464;
			short num3 = num2;
			num2 = (short)1466362446;
			short num4 = num2;
			num2 = (short)172550734;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1C:
				num2 = (short)822870017;
				if (num2 != 0)
				{
				}
				A_0 = ((A_0 ^ (A_1 & 255)) & 255);
				A_1 = (ushort)(A_1 >> 8);
				num2 = (short)1508966400;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)872022016;
				if (num2 != 0)
				{
				}
				break;
			}
			IL_13A:
			A_0 = (ushort)(A_0 << 6);
			A_1 ^= A_0;
			A_0 = (ushort)(A_0 << 1);
			A_1 ^= A_0;
			return A_1;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00009158 File Offset: 0x00007358
		public bool Select(int hSession)
		{
			bool result;
			for (;;)
			{
				IL_00:
				short num = (short)1619197952;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_94;
				}
				int num3;
				int num4;
				int num6;
				for (;;)
				{
					IL_32:
					switch (num3)
					{
					case 0:
						if (num4 == 0)
						{
							num = (short)1556611080;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						num = (short)457375758;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return result;
					case 3:
						if (num4 != 1)
						{
							num = (short)182648852;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_171;
					case 4:
						if (num4 != 1)
						{
							num = (short)80216086;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1855455241;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						global::IBtnWrapperLib.IBtnCommon.h[0] = global::System.Convert.ToByte(global::IBtnWrapperLib.TMEXAPI.TMOneWireCom(hSession, 1, 0) == 1);
						num = (short)1725497348;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						num = (short)1550323081;
						short num5 = num;
						num = (short)2093550985;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1971716096;
							if (num != 0)
							{
							}
							global::IBtnWrapperLib.TMEXAPI.TMOneWireCom(hSession, 0, 0);
							num = (short)59047948;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_222;
					case 8:
						num = (short)154533889;
						if (num != 0)
						{
						}
						result = false;
						num = (short)1282605058;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (global::IBtnWrapperLib.IBtnCommon.h[0] == 0)
						{
							num = (short)1277952016;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_171;
					case 10:
						goto IL_171;
					case 11:
						if (this.e == 24)
						{
							num = (short)1857683461;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B4;
					case 12:
						goto IL_B4;
					case 13:
						goto IL_36D;
					case 14:
						if (global::IBtnWrapperLib.TMEXAPI.TMTouchByte(hSession, 60) == 60)
						{
							num = (short)704970770;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_222;
					case 15:
						if (num6++ >= 3)
						{
							num = (short)1439563786;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36D;
					case 16:
						num = (short)1775501331;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_B4;
					case 18:
						global::IBtnWrapperLib.TMEXAPI.TMOneWireCom(hSession, 0, 1);
						num = (short)1050935303;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (global::IBtnWrapperLib.TMEXAPI.TMTouchReset(hSession) == 1)
						{
							num = (short)2083651585;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_222;
					case 20:
						num = (short)2086141967;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (global::IBtnWrapperLib.IBtnCommon.h[0] > 0)
						{
							num = (short)635895814;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B4;
					case 22:
						num = (short)973144085;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_B4:
					num = (short)1118896131;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_171:
					num = (short)537788416;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_222:
					num4 = 0;
					num = (short)1199177745;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_36D:
					num4 = (int)global::IBtnWrapperLib.TMEXAPI.TMStrongAccess(hSession, global::IBtnWrapperLib.IBtnCommon.g);
					num = (short)1635319819;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_94:
				result = true;
				num4 = 0;
				num6 = 0;
				num = (short)1670709261;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00009564 File Offset: 0x00007764
		public bool EraseScratchSHA(int hSession)
		{
			short num = (short)1516437504;
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
				byte[] array2;
				short num6;
				bool result;
				for (;;)
				{
					IL_27:
					int num3;
					int num4;
					int num7;
					switch (num2)
					{
					case 0:
					{
						if (num3 >= 2 + num4)
						{
							num = (short)2017984518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array = array2;
						short num5 = num6;
						num6 = num5 + 1;
						array[(int)num5] = 255;
						num3++;
						num = (short)220594187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_2F4;
					case 2:
						num = (short)553779208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_2AC;
					case 4:
						return result;
					case 5:
						if (global::IBtnWrapperLib.TMEXAPI.TMBlockStream(hSession, array2, num6) == num6)
						{
							num = (short)869466113;
							if (num != 0)
							{
							}
							num = (short)1336344578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 6:
						num = (short)1242628101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (this.Select(hSession))
						{
							num = (short)678559758;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 8:
						if ((array2[(int)(num6 - 1)] & 240) != 80)
						{
							num = (short)358547471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AC;
					case 9:
						num = (short)2070872074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num7 = 2;
						goto IL_2CB;
					case 11:
						goto IL_106;
					case 12:
						num7 = 6;
						goto IL_2CB;
					case 13:
						if (global::IBtnWrapperLib.IBtnCommon.h[0] <= 0)
						{
							num = (short)1463549961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1535770636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						num = (short)649012345;
						short num8 = num;
						num = (short)518464633;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2F4;
						default:
							num = (short)1700790272;
							if (num != 0)
							{
							}
							num = (short)768147469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 15:
						num = (short)284426256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if ((array2[(int)(num6 - 1)] & 240) == 160)
						{
							num = (short)1968177155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_72;
					IL_106:
					num = (short)510066688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F4:
					num = (short)1277886464;
					short num9 = num;
					goto IL_106;
					IL_2AC:
					result = true;
					num = (short)500432900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CB:
					num4 = num7;
					byte[] array3 = array2;
					short num10 = num6;
					num6 = num10 + 1;
					array3[(int)num10] = 195;
					num3 = 0;
					num = (short)1011941377;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_72:
				array2 = new byte[50];
				num6 = 0;
				result = false;
				num = (short)1046151175;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000098E0 File Offset: 0x00007AE0
		public bool ReadScratch(int hSession, ref ushort address, ref byte es, out byte[] data)
		{
			short num = (short)102105088;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_96;
				}
				byte[] array;
				bool result;
				short num8;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_2DC;
					case 1:
						goto IL_2DC;
					case 2:
					{
						int num3;
						if (num3 < 32)
						{
							data[num3] = array[4 + num3];
							num3++;
							num = (short)1739456524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2041091119;
						short num4 = num;
						num = (short)1328714799;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2DC;
						default:
							num = (short)801243136;
							if (num != 0)
							{
							}
							num = (short)712310809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_3FE;
					case 4:
					{
						ushort num5;
						if (num5 == 45057)
						{
							num = (short)1581187093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 5:
					{
						num = (short)257032192;
						short num6 = num;
						address = global::System.Convert.ToUInt16((int)array[2] << 8 | (int)array[1]);
						es = array[3];
						data = new byte[32];
						num = (short)1858666509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						byte[] array2 = array;
						short num7 = num8;
						num8 = num7 + 1;
						array2[(int)num7] = 170;
						int num3 = 0;
						num = (short)1309343762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						return result;
					case 8:
						result = true;
						num = (short)1449197577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return result;
					case 10:
						num = (short)1645019160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_E9;
					case 12:
						goto IL_250;
					case 13:
					{
						if (this.e == 24)
						{
							num = (short)1044643862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3 = 0;
						num = (short)112459790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_250;
					case 15:
					{
						int num3;
						if (num3 >= 37)
						{
							num = (short)1690959882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array3 = array;
						short num9 = num8;
						num8 = num9 + 1;
						array3[(int)num9] = 255;
						num3++;
						num = (short)1293090819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (this.Select(hSession))
						{
							num = (short)102301702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 17:
						goto IL_E9;
					case 18:
						goto IL_3FE;
					case 19:
					{
						int num3;
						if (num3 >= (int)num8)
						{
							num = (short)988807188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num5 = this.a((ushort)array[num3], num5);
						num3++;
						num = (short)12255232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						num = (short)918880260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						int num3 = 0;
						num = (short)1187708945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						ushort num5 = 0;
						int num3 = 0;
						num = (short)2052587521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						int num3;
						if (num3 >= 32)
						{
							num = (short)869662728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						data[num3] = array[4 + num3];
						num3++;
						num = (short)1442971659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						if (global::IBtnWrapperLib.TMEXAPI.TMBlockStream(hSession, array, num8) == num8)
						{
							num = (short)1284046849;
							if (num != 0)
							{
							}
							num = (short)1307508741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 25:
						result = true;
						num = (short)417660935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_96;
					IL_E9:
					num = (short)1375404055;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_250:
					num = (short)2128936962;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DC:
					num = (short)1747255315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FE:
					num = (short)1704787983;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_96:
				result = false;
				num8 = 0;
				array = new byte[50];
				data = null;
				num = (short)2111766544;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00009DC4 File Offset: 0x00007FC4
		public bool WriteScratch(int hSession, ushort address, byte[] data, int data_len)
		{
			short num = (short)215154688;
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
				byte[] array2;
				short num4;
				bool result;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (this.e == 24)
						{
							num = (short)2109931523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_111;
					case 1:
						num = (short)1419051028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)2028994560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						byte[] array = array2;
						short num3 = num4;
						num4 = num3 + 1;
						array[(int)num3] = 255;
						byte[] array3 = array2;
						short num5 = num4;
						num4 = num5 + 1;
						array3[(int)num5] = 255;
						num = (short)1931935768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						num = (short)1032126464;
						short num6 = num;
						goto IL_367;
					}
					case 5:
					{
						ushort num7 = 0;
						array2[(int)num4] = 15;
						byte[] array4 = array2;
						short num8 = num4;
						num4 = num8 + 1;
						num7 = this.a(array4[(int)num8], num7);
						array2[(int)num4] = (byte)(address & 255);
						byte[] array5 = array2;
						short num9 = num4;
						num4 = num9 + 1;
						num7 = this.a(array5[(int)num9], num7);
						array2[(int)num4] = (byte)(address >> 8 & 255);
						byte[] array6 = array2;
						short num10 = num4;
						num4 = num10 + 1;
						num7 = this.a(array6[(int)num10], num7);
						int num11 = 0;
						num = (short)1973157900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						result = true;
						num = (short)1479213077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)70975499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_308;
					case 9:
						goto IL_3A7;
					case 10:
						return result;
					case 11:
					{
						ushort num7;
						if (num7 == 45057)
						{
							num = (short)1043660806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 12:
						goto IL_45C;
					case 13:
					{
						int num12;
						if (num12 >= (int)num4)
						{
							num = (short)10223623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ushort num7 = this.a((ushort)array2[num12], num7);
						num12++;
						num = (short)1935409174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						int num13;
						if (num13 >= 31 - ((int)address + data_len - 1 & 31))
						{
							num = (short)1186856962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array2[(int)num4] = byte.MaxValue;
						byte[] array7 = array2;
						short num14 = num4;
						num4 = num14 + 1;
						ushort num7 = this.a(array7[(int)num14], num7);
						num13++;
						num = (short)2147287049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if (this.Select(hSession))
						{
							num = (short)1367736325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 16:
						if (global::IBtnWrapperLib.TMEXAPI.TMBlockStream(hSession, array2, num4) == num4)
						{
							num = (short)991821825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 17:
					{
						int num11;
						if (num11 >= data_len)
						{
							num = (short)1989607443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1067239928;
						short num15 = num;
						num = (short)836159992;
						switch ((num15 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_45C;
						default:
						{
							num = (short)969801728;
							if (num != 0)
							{
							}
							array2[(int)num4] = data[num11];
							byte[] array8 = array2;
							short num16 = num4;
							num4 = num16 + 1;
							ushort num7 = this.a(array8[(int)num16], num7);
							num11++;
							num = (short)1681391624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 18:
					{
						int num12 = (int)(num4 - 2);
						num = (short)723714052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						int num13 = 0;
						num = (short)810876951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (this.e == 24)
						{
							num = (short)907280402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						num = (short)144900097;
						if (num != 0)
						{
						}
						num = (short)1738539018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						return result;
					case 22:
						goto IL_367;
					case 23:
						goto IL_3A7;
					case 24:
						goto IL_111;
					}
					goto IL_92;
					IL_111:
					num = (short)1800470544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_308:
					num = (short)1215430673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45C:
					goto IL_308;
					IL_367:
					num = (short)748748813;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A7:
					num = (short)1591738382;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_92:
				array2 = new byte[50];
				num4 = 0;
				result = false;
				num = (short)1013448719;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000A2F4 File Offset: 0x000084F4
		public bool CopyScratch(int hSession, ushort address, int len)
		{
			short num = (short)1799421952;
			short num2 = num;
			num = (short)677707776;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AE;
				}
				byte[] array;
				short num4;
				bool result;
				for (;;)
				{
					IL_4F:
					int num5;
					int num11;
					int num12;
					switch (num3)
					{
					case 0:
						if (global::IBtnWrapperLib.TMEXAPI.TMBlockStream(hSession, array, num4) == num4)
						{
							num = (short)991035402;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						num5 = 2;
						goto IL_441;
					case 2:
						num5 = 4;
						goto IL_441;
					case 3:
						if (this.e == 24)
						{
							num = (short)1518993416;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1577648135;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)1304579310;
						short num6 = num;
						num = (short)1909345518;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_22B;
						default:
						{
							num = (short)1916469248;
							if (num != 0)
							{
							}
							byte[] array2 = array;
							short num7 = num4;
							num4 = num7 + 1;
							array2[(int)num7] = 85;
							byte[] array3 = array;
							short num8 = num4;
							num4 = num8 + 1;
							array3[(int)num8] = (byte)(address & 255);
							byte[] array4 = array;
							short num9 = num4;
							num4 = num9 + 1;
							array4[(int)num9] = (byte)(address >> 8 & 255);
							byte[] array5 = array;
							short num10 = num4;
							num4 = num10 + 1;
							array5[(int)num10] = global::System.Convert.ToByte((int)address + len - 1 & 31);
							num = (short)675938307;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 5:
						result = true;
						num = (short)1814822918;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return result;
					case 7:
						if (global::IBtnWrapperLib.TMEXAPI.TMBlockStream(hSession, array, num4) == num4)
						{
							num = (short)822149125;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 8:
						num = (short)766705679;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return result;
					case 10:
						num = (short)1532035088;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_14C;
					case 12:
						if (this.Select(hSession))
						{
							num = (short)1020002308;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 13:
						goto IL_30E;
					case 14:
						goto IL_14C;
					case 15:
						if (global::IBtnWrapperLib.IBtnCommon.h[0] <= 0)
						{
							num = (short)1543503893;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2054553602;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if ((array[(int)(num4 - 1)] & 240) != 80)
						{
							num = (short)651034642;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30E;
					case 17:
					{
						if (num11 >= num12)
						{
							num = (short)391512084;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)312934401;
						if (num != 0)
						{
						}
						byte[] array6 = array;
						short num13 = num4;
						num4 = num13 + 1;
						array6[(int)num13] = 255;
						num11++;
						num = (short)1025703947;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						num = (short)1080098835;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if ((array[(int)(num4 - 1)] & 240) == 160)
						{
							num = (short)664469517;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 20:
						num = (short)1941504000;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_22B;
					}
					goto IL_AE;
					IL_14C:
					num = (short)811532305;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_22B:
					num = (short)170655745;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_30E:
					result = true;
					num = (short)450232329;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_441:
					num12 = num5;
					num11 = 0;
					num = (short)354156558;
					num3 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_AE:
				num4 = 0;
				array = new byte[80];
				result = false;
				num = (short)1366622220;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000A764 File Offset: 0x00008964
		internal int a(int A_0, uint A_1)
		{
			short num = (short)768409600;
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
				byte addrLSB;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_1C4;
					case 1:
						goto IL_22E;
					case 2:
						goto IL_20D;
					case 3:
						switch (A_1)
						{
						case 8U:
							addrLSB = 96;
							num = (short)373620742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9U:
							addrLSB = 100;
							num = (short)437714951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10U:
							addrLSB = 104;
							num = (short)481361921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11U:
							addrLSB = 108;
							num = (short)266534916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12U:
							addrLSB = 112;
							num = (short)2046296069;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13U:
							addrLSB = 116;
							num = (short)1668022272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14U:
							addrLSB = 120;
							num = (short)1916403722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15U:
							addrLSB = 124;
							num = (short)941948939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1192296457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 4:
						goto IL_268;
					case 5:
						goto IL_FB;
					case 6:
						goto IL_11B;
					case 7:
						goto IL_24B;
					case 8:
					{
						num = (short)1027866624;
						short num3 = num;
						addrLSB = 96;
						num = (short)1808203778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)2091515912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_DA;
					case 11:
						goto IL_189;
					}
					goto IL_5F;
				}
				IL_DA:
				IL_FB:
				goto IL_292;
				IL_11B:
				num = (short)1786456771;
				short num4 = num;
				num = (short)1156655811;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)780468224;
					if (num != 0)
					{
					}
					break;
				}
				IL_189:
				IL_1C4:
				IL_20D:
				IL_22E:
				IL_24B:
				goto IL_292;
				IL_268:
				num = (short)200081409;
				if (num != 0)
				{
				}
				IL_292:
				byte[] array = new byte[4];
				byte addrMSB;
				short numBytesRequested;
				this.ReadMemoryData(A_0, addrLSB, addrMSB, numBytesRequested, array);
				return global::System.BitConverter.ToInt32(array, 0);
				IL_5F:
				addrMSB = 2;
				addrLSB = 0;
				numBytesRequested = 4;
				num = (short)1680474115;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000AA1C File Offset: 0x00008C1C
		public void GetMAPFFieldData(int hSession, ref byte[] pFieldData, short fieldStartByteOffset, short fieldLen)
		{
			int a_ = 0;
			short num = (short)103153666;
			int num2 = (int)((global::System.IntPtr)num);
			byte[] sourceArray;
			for (;;)
			{
				num = (short)488505344;
				short num3 = num;
				int num4;
				switch (num2)
				{
				case 0:
					goto IL_C1;
				case 1:
				{
					if ((int)(fieldStartByteOffset + fieldLen) > num4)
					{
						num = (short)1381957632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)311499491;
					short num5 = num;
					num = (short)556276451;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_134;
					default:
						goto IL_1A3;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_6F;
					}
					continue;
				case 3:
					goto IL_8A;
				case 4:
					goto IL_169;
				case 5:
					if ((int)fieldStartByteOffset >= num4)
					{
						num = (short)1059192836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1094385665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6F:
				if (pFieldData == null)
				{
					num = (short)1599602691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num4 = 0;
				sourceArray = null;
				this.a(hSession, ref num4, ref sourceArray);
				IL_134:
				num = (short)260636677;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_8A:
			num = (short)1864237057;
			if (num != 0)
			{
			}
			throw new global::IBtnWrapperLib.TMEXException(global::IBtnWrapperLib.TMEXException.g("縸帺䤼爾@ፂ̈́ņ⁈⹊⅌⭎ᕐ㉒⅔㙖捘筚ᑜㅞᝠɢ।๦൨䭪౬ᵮᙰٲᡴቶ᝸ེ", a_));
			IL_C1:
			throw new global::IBtnWrapperLib.TMEXException(global::IBtnWrapperLib.TMEXException.g("戸缺఼฾᱀捂̈́⹆ⱈ❊⥌潎㹐╒ご╖⭘⹚㍜ⱞ䅠⹢⑤㝦⽨䭪ཬnѰᵲᅴᙶ୸ɺ卼", a_));
			IL_169:
			throw new global::IBtnWrapperLib.TMEXException(global::IBtnWrapperLib.TMEXException.g("戸缺఼฾᱀捂̈́⹆ⱈ❊⥌潎≐❒㑔╖ⵘ筚㽜♞ᕠ٢⩤Ŧཨᡪ࡬᭮兰ᱲtͶ੸ቺ᥼᩾ꆀ캂쒄힆쾈ꮊﶒ뎜", a_));
			IL_1A3:
			num = (short)87031808;
			if (num != 0)
			{
			}
			global::System.Array.Copy(sourceArray, (int)fieldStartByteOffset, pFieldData, 0, (int)fieldLen);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		private void a(int A_0, ref int A_1, ref byte[] A_2)
		{
			int a_ = 4;
			short num = (short)381886632;
			short num2 = num;
			num = (short)378675368;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1469841408;
				if (num != 0)
				{
				}
				num = (short)1296433152;
				short num3 = num;
				num = (short)1796014080;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			num = (short)2041577473;
			if (num != 0)
			{
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
					goto IL_111;
				}
				int num4;
				for (;;)
				{
					IL_F6:
					switch (num4)
					{
					case 0:
						A_1 = 7057;
						num = (short)1493893121;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_195;
					case 2:
						if (this.e == 12)
						{
							num = (short)427360256;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_1 = 420;
						num = (short)1043333123;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_195;
					case 4:
						goto IL_20B;
					}
					goto IL_111;
					IL_195:
					byte[] sourceArray = null;
					short num5 = (short)A_1;
					this.ReadFile(A_0, hFile, ref num5, out sourceArray);
					A_1 = (int)num5;
					byte[] a_2 = null;
					A_1 -= 6;
					byte[] array2 = new byte[A_1];
					global::System.Array.Copy(sourceArray, 6, array2, 0, A_1);
					new global::AcpCryptoLib.AcpIBtnEncyptDecrpt().Decrypt(array2, out a_2);
					A_2 = new byte[58];
					global::System.Array.Copy(sourceArray, A_2, 6);
					this.a(A_2, a_2, ref A_1);
					num = (short)524550148;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_20B:
				return;
				IL_111:
				this.OpenFile(A_0, out hFile, array, false);
				A_1 = 0;
				num = (short)761856002;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_F6;
			}
			catch (global::IBtnWrapperLib.TMEXException innerException)
			{
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("吼紾㑀㝂ㅄ⡆❈歊Ɍ㽎㑐㉒❔⍖じ㑚㍜罞①ᅢᝤࡦ᭨䕪䵬㱮ᑰᙲ啴㹶᝸ᕺ᡼ൾ쒀ﮂ麗ﾊﾐ뎒뮚列爵햠슢첤쮦\udaa8", a_), innerException);
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			finally
			{
				this.CloseFile(A_0, ref hFile);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000AE7C File Offset: 0x0000907C
		private void a(byte[] A_0, byte[] A_1, ref int A_2)
		{
			int a_ = 12;
			short num = (short)1598160904;
			int num2 = (int)((global::System.IntPtr)num);
			int num3;
			int num4;
			for (;;)
			{
				int num5;
				switch (num2)
				{
				case 0:
					goto IL_136;
				case 1:
					num = (short)1395130373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_FF;
				case 3:
					goto IL_FF;
				case 4:
					goto IL_1E2;
				case 5:
				{
					if (A_1 != null)
					{
						A_2 = 0;
						num3 = 6;
						num4 = global::IBtnWrapperLib.TMEXException.g("♄ቆ݈", a_).Length;
						num5 = 0;
						num = (short)889651202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1000764214;
					short num6 = num;
					num = (short)1985508150;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_136;
					default:
						num = (short)1921581057;
						if (num != 0)
						{
						}
						num = (short)601686016;
						if (num != 0)
						{
						}
						num = (short)91750404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					if (num5 >= 8)
					{
						num = (short)1132527616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)883163147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_1E7;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					continue;
				case 9:
					goto IL_1E7;
				case 10:
					A_0[num3] = ~A_1[num4];
					num = (short)879689735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (num5 == 5)
					{
						num = (short)2056257546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					A_0[num3] = A_1[num4];
					num = (short)54001673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5E:
				if (A_0 != null)
				{
					num = (short)897253377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_FF:
				num = (short)1216086022;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E7:
				num5++;
				num3++;
				num4++;
				num = (short)1402339331;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C1:
			num = (short)1899102208;
			short num7 = num;
			throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ౄ⥆㽈⩊⅌♎㕐獒㑔╖㹘⹚ぜ㩞འᝢ䵤ᑦ䁨䩪", a_));
			IL_136:
			A_0[num3++] = A_1[num4++];
			num4 += global::IBtnWrapperLib.TMEXException.g("ф㽆ࡈ", a_).Length;
			A_0[num3++] = A_1[num4++];
			global::System.Array.Copy(A_1, num4, A_0, num3, 10);
			num3 += 10;
			num4 += 10;
			global::System.Array.Copy(A_1, num4, A_0, num3, 8);
			num3 += 8;
			A_2 = num3;
			return;
			IL_1E2:
			goto IL_C1;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000B168 File Offset: 0x00009368
		private void a(int A_0, byte[] A_1, byte[] A_2, string A_3, string A_4)
		{
			int a_ = 5;
			short num = (short)612171776;
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
				int num4;
				byte[] romserialNum;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						num = (short)1104936961;
						if (num != 0)
						{
						}
						num = (short)1971716102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						num = (short)707067933;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)362807296;
						short num3 = num;
						goto IL_171;
					}
					case 4:
						goto IL_622;
					case 5:
						goto IL_107;
					case 6:
						goto IL_107;
					case 7:
					{
						int num5;
						if (num4 >= num5)
						{
							num = (short)773128192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6;
						byte[] bytes;
						A_1[num6++] = bytes[num4];
						num4++;
						num = (short)1117323268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						int num6;
						A_1[num6++] = A_2[0];
						int num5 = global::IBtnWrapperLib.TMEXException.g("缽㠿́", a_).Length;
						global::System.Array.Copy(global::System.Text.Encoding.UTF8.GetBytes(global::IBtnWrapperLib.TMEXException.g("缽㠿́", a_)), 0, A_1, num6, num5);
						num6 += num5;
						A_1[num6++] = A_2[1];
						byte[] bytes2 = global::System.Text.Encoding.UTF8.GetBytes(A_3);
						byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(A_4);
						num5 = bytes2.Length;
						num4 = 0;
						num = (short)101908502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_295;
					case 10:
					{
						int num6 = 0;
						int num5 = global::IBtnWrapperLib.TMEXException.g("崽ᔿు", a_).Length;
						global::System.Array.Copy(global::System.Text.Encoding.UTF8.GetBytes(global::IBtnWrapperLib.TMEXException.g("崽ᔿు", a_)), A_1, num5);
						num6 += num5;
						num4 = 0;
						num = (short)1958739983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						num = (short)1969824720;
						short num7 = num;
						num = (short)1064641488;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_295;
						default:
							num = (short)1290928128;
							if (num != 0)
							{
							}
							if (num4 >= 8)
							{
								num = (short)2136408072;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)287047700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						goto IL_4AE;
					case 13:
					{
						if (num4 >= 10)
						{
							num = (short)174129168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6;
						A_1[num6++] = 32;
						num4++;
						num = (short)945094680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_4AE;
					case 15:
						goto IL_3C1;
					case 16:
					{
						byte[] bytes;
						int num5 = bytes.Length;
						num4 = 0;
						num = (short)1673658377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_236;
					case 18:
					{
						int num6;
						A_1[num6++] = 32;
						num = (short)1244790798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						int num6;
						int num8 = 58 - (num6 + 6);
						num4 = 0;
						num = (short)977469457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						if (num4 == 5)
						{
							num = (short)55640087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6;
						A_1[num6++] = romserialNum[num4];
						num = (short)1443561500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						if (romserialNum != null)
						{
							num = (short)386007050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_685;
					case 22:
						goto IL_472;
					case 23:
					{
						int num6;
						A_1[num6++] = ~romserialNum[num4];
						num = (short)1128595459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_520;
					case 25:
						goto IL_3C1;
					case 26:
					{
						int num5;
						if (num4 >= num5)
						{
							num = (short)1483210754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6;
						byte[] bytes2;
						A_1[num6++] = bytes2[num4];
						num4++;
						num = (short)727121953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_236;
					case 28:
						goto IL_171;
					case 29:
						goto IL_520;
					case 30:
					{
						if (num4 >= 8)
						{
							num = (short)1180303379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6;
						A_1[num6++] = 32;
						num4++;
						num = (short)1963130885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						int num8;
						if (num4 >= num8)
						{
							num = (short)299761665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)152633376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
					{
						if (num4 % 3 == 0)
						{
							num = (short)2137391122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6;
						A_1[num6++] = 3;
						num = (short)1391198220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						goto IL_472;
					}
					goto IL_C0;
					IL_107:
					num = (short)1247871006;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_171:
					num4++;
					num = (short)880607257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_236:
					num = (short)2002518047;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C1:
					num = (short)1509097483;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_472:
					num = (short)1143865370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4AE:
					num4++;
					num = (short)660340763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_520:
					num = (short)1071579149;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_622:
					num = (short)1512046599;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_295:
					goto IL_622;
				}
				return;
				IL_685:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("稽┿㑁ⵃ╅ⵇ橉Ὃ⭍≏㭑㕓㩕硗ᑙ⥛㍝ɟݡᙣ䙥୧թᥫɭᑯ剱ᩳ᥵౷婹ṻ᭽ꁿ", a_));
				IL_C0:
				num4 = 0;
				romserialNum = this.GetROMSerialNum(A_0, true);
				num = (short)411697173;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000B810 File Offset: 0x00009A10
		public void WriteMapfFile(int hSession, byte[] version, byte[] communityCode, string userid, string password, string authCode)
		{
			int a_ = 15;
			short num = (short)2144796672;
			switch (num)
			{
			default:
			{
				int num3;
				for (;;)
				{
					IL_28:
					num = (short)1543569408;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_5B;
							}
							continue;
						case 1:
							num3 = 52;
							num = (short)429260802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_136;
						}
						IL_5B:
						if (!this.a(authCode))
						{
							goto IL_138;
						}
						num = (short)43797543;
						short num4 = num;
						num = (short)189221927;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_28;
						default:
						{
							num = (short)953876481;
							if (num != 0)
							{
							}
							num = (short)501415936;
							if (num != 0)
							{
							}
							num = (short)2146893824;
							short num5 = num;
							num = (short)1887698945;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
				}
				IL_136:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_185;
					}
					int num2;
					int num6;
					byte[] array2;
					for (;;)
					{
						IL_156:
						switch (num2)
						{
						case 0:
							goto IL_2DE;
						case 1:
							goto IL_299;
						case 2:
						{
							byte[] array;
							if (array.Length + 6 > 58)
							{
								num = (short)534970369;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.a(hSession, array, num3, version);
							num = (short)1179582464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_29E;
						case 4:
							num = (short)565510146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (num6 >= array2.Length)
							{
								num = (short)2086469641;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array2[num6] = 0;
							num6++;
							num = (short)343474179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_29E;
						case 7:
						{
							byte[] array;
							if (array != null)
							{
								num = (short)340328452;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2DE;
						}
						case 8:
							goto IL_2F6;
						case 9:
						{
							this.a(hSession, array2, communityCode, userid, password);
							byte[] array = null;
							new global::AcpCryptoLib.AcpIBtnEncyptDecrpt().Encrypt(array2, out array);
							num = (short)655753223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_185;
						IL_29E:
						num = (short)1197473797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2DE:
						num = (short)1601110024;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_299:
					throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("േ⑉⽋㱍⥏≑⁓㍕㱗穙ᅛὝた䉡⁣ݥᱧ୩䱫ݭͯ剱s᥵塷ᙹᵻ౽ꒃꪉ늑ﺕﶗ몙톛\udf9d芡슣쾥쒧쾩", a_));
					IL_2F6:
					return;
					IL_185:
					array2 = new byte[num3];
					num6 = 0;
					num = (short)775749638;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_156;
				}
				catch (global::IBtnWrapperLib.TMEXException innerException)
				{
					throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ⅇࡉ㥋㩍⑏㵑㩓癕᝗⩙㥛ⱝşᙡൣ॥٧䩩⥫ᱭɯᵱٳ噵啷婹ཻ᭽ꊁ춃ﺋ쮍肟쒡쮣풥袧캩즫\udaad톯\udbb1\ud8b3억", a_), innerException);
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
				return;
				IL_138:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ፇ้繋籍൏牑ᕓ㕕㭗㽙⽛ⵝ䁟ᙡୣ䙥╧⭩㱫⡭偯ᑱᵳ᩵ᵷ婹ᕻൽꁿﲇ뢕", a_));
			}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000BB64 File Offset: 0x00009D64
		private bool a(string A_0)
		{
			int a_ = 17;
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
					num2 = (short)2050883584;
					short num3 = num2;
					num2 = (short)1972633601;
					if (num2 != 0)
					{
					}
					num2 = (short)1340348730;
					short num4 = num2;
					num2 = (short)1491015994;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1400307712;
						if (num2 != 0)
						{
						}
						if (string.Compare(global::IBtnWrapperLib.TMEXException.g("ॉ絋్ᅏᑑᙓ᝕桗≙㹛㡝剟⁡❣啥⥧幩๫൭䍯፱䑳๵䱷᡹᩻᭽륿삁욃쒅뢇쾉뾍ꂑ뢓ꪙ궝钟鎡鞥邧鶫骭螯花첳풵\ud9b7\udcb9\udebb螽ꊿ", a_), A_0) == 0)
						{
							num2 = (short)77398017;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 1:
					result = true;
					num2 = (short)536870914;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				}
				goto IL_25;
			}
			return result;
			IL_25:
			result = false;
			num2 = (short)2005270528;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000BC94 File Offset: 0x00009E94
		private void a(int A_0, byte[] A_1, int A_2, byte[] A_3)
		{
			int a_ = 2;
			short num = (short)1397987551;
			short num2 = num;
			num = (short)1521588447;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1117650944;
				if (num != 0)
				{
				}
				num = (short)1402798080;
				short num3 = num;
				num = (short)309657600;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			short num5 = -1;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_C5;
				}
				int num4;
				int num6;
				byte[] array;
				for (;;)
				{
					IL_AA:
					switch (num4)
					{
					case 0:
						goto IL_109;
					case 1:
						if (num6 >= array.Length)
						{
							num = (short)2106327043;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num6] = 0;
						num6++;
						num = (short)1932591104;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_109;
					case 3:
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
						short num7 = 58;
						this.CreateFile(A_0, out num5, array2, out num7);
						this.WriteFile(A_0, num5, array, 58);
						num = (short)538836996;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_1A9;
					}
					goto IL_C5;
					IL_109:
					num = (short)1229586433;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1A9:
				goto IL_238;
				IL_C5:
				array = new byte[58];
				num6 = 0;
				num = (short)1085931522;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_AA;
			}
			catch (global::IBtnWrapperLib.TMEXException innerException)
			{
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("刺缼䨾㕀㝂⩄⥆楈ъ㵌⩎⍐㉒⅔㹖㙘㕚絜ᩞ፠ᅢ੤ᕦ䥨䙪䵬ᱮᑰᙲ啴㹶᝸ᕺ᡼ൾ쒀ﮂ麗ﾊﾐ뎒뮚列爵햠슢첤쮦\udaa8", a_), innerException);
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			finally
			{
				num = (short)1483735040;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_1FA;
						}
						continue;
					case 1:
						this.CloseFile(A_0, ref num5);
						num = (short)491651074;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_235;
					}
					IL_1FA:
					if (num5 == -1)
					{
						break;
					}
					num = (short)803340289;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_235:;
			}
			IL_238:
			num = (short)1911488513;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000BF4C File Offset: 0x0000A14C
		public byte[] LoadFileName(string fileName)
		{
			int a_ = 15;
			short num = (short)1643839488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_69;
				}
				string text;
				string text2;
				char[] separator;
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
						goto IL_246;
					case 1:
						if (text.Length >= 1)
						{
							num = (short)284098569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B7;
					case 2:
						num = (short)1975910405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (text.Length > 3)
						{
							num = (short)425263115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)459538432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1740046337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (text2.Length <= 4)
						{
							num = (short)1459355652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B7;
					case 6:
						goto IL_14E;
					case 7:
					{
						string[] array;
						if (array.Length != 2)
						{
							num = (short)708837382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)22170570;
						short num3 = num;
						num = (short)1005210570;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B7;
						default:
							num = (short)989659136;
							if (num != 0)
							{
							}
							text2 = array[0];
							text = array[1];
							num = (short)186187777;
							if (num != 0)
							{
							}
							num = (short)1109458954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
					{
						string text3 = fileName.ToUpper();
						if (text3.CompareTo(global::IBtnWrapperLib.TMEXException.g("ᝇ้Kɍ繏歑浓", a_)) == 0)
						{
							goto Block_1;
						}
						string[] array = text3.Split(separator);
						num = (short)860225543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)638713859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)1410465792;
						short num4 = num;
						if (text2.Length >= 1)
						{
							num = (short)1197539330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B7;
					}
					case 11:
						goto IL_2DE;
					}
					goto IL_69;
				}
				Block_1:
				goto IL_219;
				IL_B7:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("Ň⑉㩋⽍㱏㭑こ癕㹗㍙せ㭝䁟ౡգ୥൧", a_));
				IL_14E:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("Ň⑉㩋⽍㱏㭑こ癕㹗㍙せ㭝䁟ౡգ୥൧", a_));
				IL_219:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ፇ้繋繍൏牑୓ቕᑗᙙ牛杝奟䉡ൣᕥ䡧୩䱫ᱭᕯűᅳѵ๷ό᡻幽ꢇ벑", a_));
				IL_246:
				byte[] array2;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_178;
					}
					int num5;
					for (;;)
					{
						IL_15D:
						switch (num2)
						{
						case 0:
							goto IL_1BE;
						case 1:
							if (num5 >= 4)
							{
								num = (short)1315373059;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array2[num5] = (byte)text2[num5];
							num5++;
							num = (short)1279066112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1BE;
						case 3:
							array2[4] = byte.Parse(text);
							num = (short)935723012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_213;
						}
						goto IL_178;
						IL_1BE:
						num = (short)1921646593;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_213:
					return array2;
					IL_178:
					num5 = 0;
					num = (short)2000289794;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_15D;
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
				goto IL_219;
				IL_2DE:
				goto IL_B7;
				IL_69:
				array2 = new byte[40];
				text2 = null;
				text = null;
				separator = new char[]
				{
					'.'
				};
				num = (short)1637154824;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000C334 File Offset: 0x0000A534
		public void GetNumDaysLeft(int hSession, global::IBtnWrapperLib.TimerType t_type, ref short pNumDaysLeft)
		{
			int a_ = 1;
			short num = (short)468647936;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_9E;
				}
				for (;;)
				{
					IL_30:
					num = (short)2069913349;
					short num3 = num;
					num = (short)1700617989;
					int num7;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1585184768;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_312;
						case 1:
							goto IL_274;
						case 2:
							if (t_type == global::IBtnWrapperLib.TimerType.realTime)
							{
								num = (short)237109251;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1048580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::IBtnWrapperLib.RegisterType a_2 = global::IBtnWrapperLib.RegisterType.RTCAlarm;
							global::IBtnWrapperLib.RegisterType a_3 = global::IBtnWrapperLib.RegisterType.RTCCntr;
							num = (short)2096365568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							if (t_type == global::IBtnWrapperLib.TimerType.interval)
							{
								num = (short)1712193542;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_317;
						case 5:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_12E;
								}
								uint num4;
								int num5;
								for (;;)
								{
									IL_10F:
									switch (num2)
									{
									case 0:
										goto IL_23E;
									case 1:
										if (num4 >= 86400U)
										{
											num = (short)294125573;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_23E;
									case 2:
										if (num4 - (uint)num5 >= 86400U)
										{
											num = (short)622002180;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_23E;
									case 3:
										goto IL_256;
									case 4:
										num4 -= (uint)num5;
										num = (short)2098921473;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
									{
										decimal num6 = num4 / 86400m;
										pNumDaysLeft = (short)global::System.Math.Round(num6, 1, global::System.MidpointRounding.AwayFromZero);
										num = (short)1876623360;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_12E;
									IL_23E:
									num = (short)1107820547;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_256:
								return;
								IL_12E:
								global::IBtnWrapperLib.RegisterType a_2;
								this.a(hSession, a_2, ref num7);
								int num8 = 0;
								global::IBtnWrapperLib.RegisterType a_3;
								this.a(hSession, a_3, ref num8);
								num4 = (uint)(num7 - num8);
								global::System.DateTime now = global::System.DateTime.Now;
								num5 = 86400 - (now.Hour * 60 * 60 + now.Minute * 60 + now.Second);
								num = (short)665190402;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_10F;
							}
							catch (global::IBtnWrapperLib.TMEXException innerException)
							{
								throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("匹縻䬽㐿㙁⭃⡅桇Չ㱋⭍≏㍑⁓㽕㝗㑙籛᭝቟ၡୣᑥ䙧䩩㽫୭ᕯ剱㵳ᡵᙷό๻㭽ﲇ낏ﮓ뢗ﺙ鍊솟쮡좣향", a_), innerException);
							}
							catch (global::System.Exception ex)
							{
								throw ex;
							}
							goto IL_274;
						case 6:
						{
							global::IBtnWrapperLib.RegisterType a_2 = global::IBtnWrapperLib.RegisterType.IntervalAlarm;
							global::IBtnWrapperLib.RegisterType a_3 = global::IBtnWrapperLib.RegisterType.IntervalCntr;
							num = (short)6750209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_9E;
					}
					IL_274:
					num7 = 0;
					num = (short)1863188480;
					short num9 = num;
					num = (short)217645061;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_312:
					goto IL_274;
				}
				IL_317:
				throw new global::IBtnWrapperLib.TMEXException(global::IBtnWrapperLib.TMEXException.g("愹砻༽礿ὁ摃ፅ♇⭉⹋≍㕏牑⁓㥕硗㵙㥛⩝䁟ၡţťŧᥩᡫ୭ɯ剱ᵳᡵṷᕹ屻卽ꁿﶇ憎ﲋ뢗캙얟킡蒣튥톧\udaa9즫躭쎯슱톳햵톷\udcb9햻\udbbd꒿", a_));
				IL_9E:
				num = (short)1826488321;
				if (num != 0)
				{
				}
				pNumDaysLeft = 0;
				num = (short)1796538370;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000C6C4 File Offset: 0x0000A8C4
		private void a(int A_0, global::IBtnWrapperLib.RegisterType A_1, ref int A_2)
		{
			int a_ = 3;
			short num = (short)1865875456;
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
						if (flag)
						{
							num = (short)567607299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_1B5;
					case 2:
						goto IL_1B5;
					case 3:
					{
						byte b;
						b -= 1;
						byte b2;
						b2 += 1;
						byte[] array = new byte[(int)b];
						byte addrMSB;
						this.ReadMemoryData(A_0, b2, addrMSB, (short)b, array);
						int num3 = 0;
						num = (short)1484652553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						switch (A_1)
						{
						case global::IBtnWrapperLib.RegisterType.RTCCntr:
						{
							byte b = 5;
							byte b2 = 2;
							byte addrMSB = 2;
							num = (short)1100021766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::IBtnWrapperLib.RegisterType.RTCAlarm:
						{
							byte b = 5;
							byte b2 = 16;
							byte addrMSB = 2;
							num = (short)1417019393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::IBtnWrapperLib.RegisterType.IntervalCntr:
						{
							byte b = 5;
							byte b2 = 7;
							byte addrMSB = 2;
							num = (short)2000617474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::IBtnWrapperLib.RegisterType.IntervalAlarm:
						{
							num = (short)718551099;
							short num4 = num;
							num = (short)395655227;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_FF;
							default:
							{
								num = (short)27656192;
								if (num != 0)
								{
								}
								num = (short)960626688;
								short num5 = num;
								byte b = 5;
								byte b2 = 21;
								byte addrMSB = 2;
								num = (short)660865034;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						default:
							num = (short)631046149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 5:
						num = (short)996409351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1182597121;
						if (num != 0)
						{
						}
						goto IL_1B5;
					case 7:
						goto IL_1B0;
					case 8:
						return;
					case 9:
						goto IL_1F0;
					case 10:
						goto IL_1B5;
					case 11:
						goto IL_1F0;
					case 12:
					{
						int num3;
						if (num3 >= 4)
						{
							num = (short)912588808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						int num6 = (int)array[num3];
						num6 <<= 8 * num3;
						A_2 |= num6;
						num3++;
						num = (short)1418854411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6C;
					IL_1B5:
					num = (short)1218969600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F0:
					num = (short)1652097036;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FF:
				flag = false;
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("朻稽焿筁᥃晅ᵇ⑉ⵋⱍ㱏㝑瑓≕㝗穙㭛㭝ᑟ䉡ᙣͥཧͩὫᩭᕯq味ήᙷᱹ፻幽굿ꊁﮇﾉﲋﺍﾏﲗ몙좛춟잡횣蚥\udca7펩\udcab쮭邯솱쒳펵\udbb7펹\udabbힽꖿꛁ", a_));
				IL_1B0:
				goto IL_FF;
				IL_6C:
				flag = true;
				A_2 = 0;
				num = (short)673447940;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000C9DC File Offset: 0x0000ABDC
		private bool a(ref global::IBtnWrapperLib.Cntr_Alarm A_0, global::IBtnWrapperLib.TimerType A_1, short A_2, char A_3)
		{
			int a_ = 7;
			short num = (short)1676673024;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_60;
				}
				bool flag2;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						double totalSeconds;
						double totalSeconds2;
						bool flag;
						A_0.timerVal = (uint)(totalSeconds - totalSeconds2 + (double)(flag ? 3600 : 0));
						num = (short)182714372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						flag2 = this.a(A_2, A_3, ref A_0);
						num = (short)267452423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (A_1 == global::IBtnWrapperLib.TimerType.realTime)
						{
							num = (short)1656356869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)244842502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_222;
					case 4:
					{
						num = (short)155451392;
						short num3 = num;
						goto IL_222;
					}
					case 5:
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
						bool flag = currentTimeZone.IsDaylightSavingTime(now);
						num = (short)120389632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (A_1 == global::IBtnWrapperLib.TimerType.interval)
						{
							num = (short)871104520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D2;
					case 7:
						goto IL_2CD;
					case 8:
					{
						num = (short)1482948609;
						if (num != 0)
						{
						}
						A_0.cntrRegSz = 5;
						A_0.cntrRegOffset = 7;
						A_0.alarmRegSz = 5;
						A_0.alarmRegOffset = 21;
						A_0.statusRegByte = 40;
						A_0.timerVal = 0U;
						num = (short)648957489;
						short num4 = num;
						num = (short)1556696625;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)683802624;
							if (num != 0)
							{
							}
							num = (short)25427971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						if (flag2)
						{
							num = (short)1454243841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					}
					goto IL_60;
					IL_222:
					num = (short)1731330057;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2CD:
				return flag2;
				IL_2D2:
				flag2 = false;
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ᬿف畃煅ᕇ橉ੋ⽍㥏㹑ㅓ㉕硗⹙㍛繝፟ݡၣ䙥ᱧͩū୭ɯ剱女噵൷ᑹཻ୽ﲇ꺍쒏ﮑ煉몙얟송춣삥솧쾩좫肭", a_));
				IL_60:
				flag2 = true;
				num = (short)1138884610;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000CCD4 File Offset: 0x0000AED4
		private void a(ref byte[] A_0, ref global::IBtnWrapperLib.Cntr_Alarm A_1, char A_2)
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
					goto IL_E1;
				case 1:
					if (num2 < num3)
					{
						A_0[num2] = (byte)(A_1.alarmVal & 255U);
						A_1.alarmVal >>= 8;
						num2++;
						num4 = (short)428797900;
						short num5 = num4;
						num4 = (short)2025189324;
						switch ((num5 == num4) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num4 = (short)1300561920;
							if (num4 != 0)
							{
							}
							num4 = (short)1581121541;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
					}
					num4 = (short)1796538379;
					num = (int)((global::System.IntPtr)num4);
					continue;
				case 2:
				{
					short alarmRegOffset = A_1.alarmRegOffset;
					num3 = (int)(alarmRegOffset + A_1.alarmRegSz);
					num2 = (int)(alarmRegOffset + 1);
					num4 = (short)684851208;
					num = (int)((global::System.IntPtr)num4);
					continue;
				}
				case 3:
				{
					if (A_2 == 'B')
					{
						num4 = (short)655032324;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					byte[] array = A_0;
					int num6 = 1;
					array[num6] |= 8;
					num4 = (short)241696774;
					num = (int)((global::System.IntPtr)num4);
					continue;
				}
				case 4:
				{
					num4 = (short)2119434241;
					if (num4 != 0)
					{
					}
					byte[] array2 = A_0;
					int num7 = 1;
					array2[num7] &= 247;
					num4 = (short)2035548167;
					num = (int)((global::System.IntPtr)num4);
					continue;
				}
				case 5:
					goto IL_144;
				case 6:
					goto IL_26E;
				case 7:
					goto IL_26E;
				case 8:
					goto IL_144;
				case 9:
					goto IL_E1;
				case 10:
					if (num2 >= num3)
					{
						num4 = (short)554106882;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					A_0[num2] = (byte)(A_1.timerVal & 255U);
					A_1.timerVal >>= 8;
					num2++;
					num4 = (short)224460800;
					num = (int)((global::System.IntPtr)num4);
					continue;
				case 11:
					return;
				}
				goto IL_40;
				IL_E1:
				num4 = (short)1581318154;
				num = (int)((global::System.IntPtr)num4);
				continue;
				IL_144:
				num4 = (short)195952641;
				num = (int)((global::System.IntPtr)num4);
				continue;
				IL_26E:
				num4 = (short)771948544;
				short num8 = num4;
				short cntrRegOffset = A_1.cntrRegOffset;
				num3 = (int)(cntrRegOffset + A_1.cntrRegSz);
				num2 = (int)(cntrRegOffset + 1);
				num4 = (short)243793929;
				num = (int)((global::System.IntPtr)num4);
			}
			return;
			IL_40:
			A_0 = new byte[30];
			A_0[0] = A_1.statusRegByte;
			A_0[1] = 80;
			num4 = (short)1446510595;
			num = (int)((global::System.IntPtr)num4);
			goto IL_0A;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		private bool a(short A_0, char A_1, ref global::IBtnWrapperLib.Cntr_Alarm A_2)
		{
			int a_ = 3;
			short num = (short)52953088;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_51;
				}
				global::System.DateTime dateTime;
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
					{
						dateTime = dateTime.AddMonths((int)A_0);
						num = (short)264437760;
						short num3 = num;
						num = (short)975634433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_14A;
					case 2:
						if (A_1 == 'D')
						{
							num = (short)1028980740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)985661445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1D3;
					case 4:
					{
						num = (short)282225975;
						short num4 = num;
						num = (short)1301966135;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14A;
						default:
							num = (short)1276510208;
							if (num != 0)
							{
							}
							dateTime = dateTime.AddDays((double)A_0);
							num = (short)1138950147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						num = (short)1591410689;
						if (num != 0)
						{
						}
						if (A_1 == 'M')
						{
							num = (short)128188416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D5;
					}
					goto IL_51;
				}
				IL_14A:
				IL_1D3:
				goto IL_1F6;
				IL_1D5:
				throw new global::System.Exception(string.Format(global::IBtnWrapperLib.TMEXException.g("画倽㘿⍁⡃⽅ⱇ橉㡋❍㵏㝑♓癕㝗㱙㩛ⵝ՟ᙡ䑣eݧᡩū཭ѯ剱即൵䡷ݹ孻幽벑뒓킕ﾝ풟芡즣펥\udba7\udea9貫청햯銱ힵ솷즹鲻隽蛁ꗉ뻋鷏뷑뫓ꋕ냗꧙ﳛ쟟꿡쏣쿥", a_), A_1));
				IL_1F6:
				global::System.DateTime now;
				uint num5 = (uint)dateTime.Subtract(now).TotalSeconds;
				A_2.alarmVal = A_2.timerVal + num5;
				return true;
				IL_51:
				now = global::System.DateTime.Now;
				dateTime = new global::System.DateTime(now.Year, now.Month, now.Day, 23, 59, 59, global::System.DateTimeKind.Local);
				num = (short)183042050;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		public void SetTimer(int hSession, short offset, global::IBtnWrapperLib.TimerType t_type, char offsetFormat, char alarmExpAction, bool bWPTimer)
		{
			int a_ = 9;
			short num;
			for (;;)
			{
				num = (short)1605763072;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1721171969;
					if (num != 0)
					{
					}
					short num3 = 2;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_AA;
						}
						byte[] array;
						bool flag2;
						for (;;)
						{
							IL_5B:
							bool flag;
							switch (num2)
							{
							case 0:
								num = (short)437321729;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								if (t_type == global::IBtnWrapperLib.TimerType.interval && flag)
								{
									num = (short)698089483;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::IBtnWrapperLib.Cntr_Alarm cntr_Alarm = default(global::IBtnWrapperLib.Cntr_Alarm);
								num = (short)1096286213;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								flag = true;
								num = (short)1181286415;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if ((array[1] & 2) > 0)
								{
									num = (short)1972895746;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								flag = false;
								num = (short)236126216;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_1EC;
							case 5:
							{
								global::IBtnWrapperLib.Cntr_Alarm cntr_Alarm;
								if (this.a(ref cntr_Alarm, t_type, offset, offsetFormat))
								{
									num = (short)1050017809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_198;
							}
							case 6:
								flag2 = true;
								num = (short)1988624388;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								goto IL_365;
							case 8:
								goto IL_1AC;
							case 9:
								if ((array[1] & 1) > 0)
								{
									num = (short)344391686;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								flag2 = false;
								num = (short)1615396878;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								if (bWPTimer)
								{
									num = (short)307363853;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_34C;
							case 11:
								goto IL_347;
							case 12:
								goto IL_34C;
							case 13:
								this.b(hSession, alarmExpAction);
								this.a(hSession, alarmExpAction);
								num = (short)652214284;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								goto IL_1EC;
							case 15:
								goto IL_1AC;
							case 16:
								if (t_type != global::IBtnWrapperLib.TimerType.realTime || !flag2)
								{
									num = (short)2068971520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_184;
							case 17:
							{
								byte[] a_2 = new byte[30];
								global::IBtnWrapperLib.Cntr_Alarm cntr_Alarm;
								this.a(ref a_2, ref cntr_Alarm, alarmExpAction);
								this.a(hSession, 0, 2, 30, a_2);
								this.a(hSession, 0, 2, 30, 29);
								num = (short)1012793354;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							goto IL_AA;
							IL_1AC:
							num = (short)455082000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1EC:
							flag = false;
							num = (short)1912471555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_34C:
							num = (short)1368981511;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_184:
						throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("᥁C睅灇ᝉ汋ࡍㅏ㭑㡓㍕㱗穙⡛ㅝ䁟ᅡţብ䡧ṩիͭᕯq味孵塷๹ᕻ፽ꒃﮇꪉﮋﲍ憐뮕얟송킣쎥첧蒩", a_));
						IL_198:
						throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("Ձ⅃㉅桇ᡉ⥋⥍㥏⅑⁓㍕⩗穙ᕛそٟൡ䑣e१ͩk୭ᑯ山", a_));
						IL_347:
						goto IL_184;
						IL_365:
						goto IL_380;
						IL_AA:
						array = new byte[(int)num3];
						this.ReadMemoryData(hSession, 0, 2, num3, array);
						flag2 = false;
						num = (short)110624777;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_5B;
					}
					catch (global::IBtnWrapperLib.TMEXException innerException)
					{
						throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("⭁ك㍅㱇㹉⍋⁍灏㵑⑓㍕⩗㭙⡛㝝ཟౡ䑣ͥᩧᡩͫᱭ偯影味յᵷό屻㝽춇ﶓ秊몙瀞튟芡삣쎥\udca7쮩얫슭쎯", a_), innerException);
					}
					catch (global::System.Exception ex)
					{
						throw ex;
					}
					IL_380:
					num = (short)2015122642;
					short num4 = num;
					num = (short)459232466;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_3B5;
					}
					break;
				}
				}
			}
			IL_3B5:
			num = (short)672071680;
			short num5 = num;
			num = (short)69206016;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000D608 File Offset: 0x0000B808
		private void a(int A_0, byte A_1, byte A_2, int A_3, byte A_4)
		{
			short num = (short)1002133726;
			short num2 = num;
			num = (short)1529239774;
			switch (num2 == num)
			{
			}
			num = (short)934674433;
			if (num != 0)
			{
			}
			num = (short)124059648;
			if (num != 0)
			{
			}
			num = (short)1172635648;
			short num3 = num;
			this.a(A_0, new byte[]
			{
				85,
				A_1,
				A_2,
				A_4
			}, 4);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000D6D4 File Offset: 0x0000B8D4
		private void a(int A_0, byte[] A_1, int A_2)
		{
			int a_ = 15;
			short num = (short)1252982784;
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
				short num3;
				int num5;
				string text;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						int num4;
						if ((num3 = global::IBtnWrapperLib.TMEXAPI.TMTouchByte(A_0, (short)A_1[num4])) < 0)
						{
							num = (short)1523449860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12B;
					}
					case 1:
						goto IL_166;
					case 2:
						goto IL_212;
					case 3:
						if (num5 > (int)this.c)
						{
							num = (short)1952907265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2088501272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_3F1;
					case 5:
						goto IL_24C;
					case 6:
					{
						if (num3 < 0)
						{
							num = (short)299040781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4;
						num4++;
						num = (short)1236336656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_420;
					case 8:
						goto IL_36F;
					case 9:
						goto IL_284;
					case 10:
						goto IL_420;
					case 11:
						goto IL_12B;
					case 12:
						if (num5 > (int)this.c)
						{
							num = (short)92602379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1321074688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						text = global::IBtnWrapperLib.TMEXException.g("᱇݉ᡋ⅍╏ㅑ㱓ᑕ⅗⹙㥛", a_);
						num = (short)1711865861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (text != null)
						{
							num = (short)705822729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 15:
						goto IL_36F;
					case 16:
						goto IL_212;
					case 17:
						num = (short)1804075009;
						if (num != 0)
						{
						}
						if (num3 == 1)
						{
							num = (short)1828257812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = global::IBtnWrapperLib.TMEXException.g("᱇݉Ὃ㩍≏㵑㩓ㅕᥗ㥙㽛㭝፟ᅡ", a_);
						num = (short)723976213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1115750419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_24C;
					case 20:
					{
						int num4 = 0;
						num = (short)1593966594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_24C;
					case 22:
						num5++;
						num = (short)823984143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						int num4;
						if (num4 >= A_2)
						{
							num = (short)1869283346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = 0;
						num = (short)895352842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						if ((num3 = global::IBtnWrapperLib.TMEXAPI.TMStrongAccess(A_0, global::IBtnWrapperLib.IBtnCommon.g)) != 1)
						{
							num = (short)1657798678;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_166;
					}
					goto IL_9C;
					IL_12B:
					num = (short)2002124806;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_166:
					num = (short)1296695313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_212:
					num = (short)883425303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24C:
					num = (short)985399310;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36F:
					num = (short)1524170755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_420:
					num = (short)136380428;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_284:
				throw new global::IBtnWrapperLib.TMEXException(string.Format(global::IBtnWrapperLib.TMEXException.g("㍇穉ㅋ湍ᕏ⁑♓㥕⩗穙⭛ⱝय़ᙡൣࡥཧ䩩ᡫŭ偯᭱㙳͵౷๹፻ၽ깿ꊁﾃ랅ꪉ憐ﺑ뢗ﺙ즟첡쎣蚥얩\udcab힭톱욳ힵ첷\ud9b9풻캽ꆿꛁꟅ볇뻉꧋ꏍꃏꛑ䀘", a_), num3, text));
				IL_3F1:
				num = (short)1907425280;
				short num6 = num;
				num5++;
				goto IL_28A;
				IL_9C:
				num3 = -1;
				text = null;
				num5 = 0;
				num = (short)28107802;
				short num7 = num;
				num = (short)55829530;
				switch ((num7 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_28A:
					num = (short)1338966023;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				default:
					num = (short)606928896;
					if (num != 0)
					{
					}
					num = (short)1730740232;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				break;
			}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000DB70 File Offset: 0x0000BD70
		private void b(int A_0, char A_1)
		{
			int a_ = 15;
			short num = (short)1828323329;
			if (num != 0)
			{
			}
			num = (short)1176305664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_71;
				}
				int num3;
				byte[] array;
				for (;;)
				{
					IL_56:
					switch (num2)
					{
					case 0:
						if (num3 >= 30)
						{
							num = (short)1263337475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num3] = byte.MaxValue;
						num3++;
						num = (short)1697251330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_FB;
							}
							for (;;)
							{
								IL_C8:
								switch (num2)
								{
								case 0:
									num = (short)851771393;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (A_1 == 'B')
									{
										num = (short)456785926;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)505806853;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2CB;
								case 3:
								{
									byte b = array[1];
									num = (short)1815674884;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									num = (short)2139359981;
									short num4 = num;
									num = (short)452856557;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_11D;
									default:
									{
										num = (short)1817116672;
										if (num != 0)
										{
										}
										byte b;
										if ((b & 16) > 0)
										{
											num = (short)445775872;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1B4;
									}
									}
									break;
								}
								case 5:
								{
									byte b;
									if ((b & 8) == 0)
									{
										num = (short)583401479;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D0;
								}
								case 6:
									num = (short)1421344776;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_203;
								case 8:
								{
									byte b;
									if ((b & 8) != 0)
									{
										num = (short)1718747138;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D0;
								}
								case 9:
									goto IL_2EA;
								case 10:
									goto IL_11D;
								}
								goto IL_FB;
								IL_11D:
								if ((array[0] & 8) == 0)
								{
									num = (short)152961027;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
								IL_2D0:
								num = (short)452001801;
								num2 = (int)((global::System.IntPtr)num);
							}
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ፇ้祋ፍ灏QSᕕ硗ⵙ⹛㝝ᑟݡ䥣ᙥᩧթᡫ୭፯ٱ味ၵ᥷፹ၻ᭽ꊁꦃꚅ\udb87ﺉ揄뒓ﶗﶙ풟잡횣蚥욧얩\ud8ab躭쎯ힱ삳隵\udbb7햹캻첽ꖿꇁ냃꫅뇇", a_));
							IL_1B4:
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ፇ้硋ፍ灏QSᕕ硗ⵙ⹛㝝ᑟݡ䥣ᙥᩧթᡫ୭፯ٱ味ၵ᥷፹ၻ᭽ꊁꦃꚅ쮇揄﶑뚕ﾙﮛ펟횡솣풥袧쒩쎫\udaad邯솱톳습颷\ud9b9펻첽늿ꟁꟃ닅꓇돉", a_));
							IL_203:
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ፇ้硋ፍ灏QSᕕ硗ⵙ⹛㝝ᑟݡ䥣ᙥᩧթᡫ୭፯ٱ味ၵ᥷፹ၻ᭽ꊁꦃꚅ쮇揄﶑뚕ﾙﮛ펟횡솣풥袧쒩쎫\udaad邯솱톳습颷\ud9b9펻첽늿ꟁꟃ닅꓇돉", a_));
							IL_2CB:
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ፇ้罋ፍ灏QSᕕ硗ⵙ⹛㝝ᑟݡ䥣ᙥᩧթᡫ୭፯ٱ味ၵ᥷፹ၻ᭽ꊁꦃꚅ쮇揄﶑뚕ﾙﮛ펟횡솣풥袧쒩쎫\udaad邯솱톳습颷\ud9b9펻첽늿ꟁꟃ닅꓇돉", a_));
							IL_2EA:
							return;
							IL_FB:
							this.ReadMemoryData(A_0, 0, 2, 30, array);
							num = (short)756416522;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_C8;
						}
						catch (global::System.Exception innerException)
						{
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ፇ้硋ፍ灏QSᕕ硗ⵙ⹛㝝ᑟݡ䥣ᙥᩧթᡫ୭፯ٱ味ၵ᥷፹ၻ᭽ꊁꦃꚅ쮇揄﶑뚕ﾙﮛ펟횡솣풥袧쒩쎫\udaad邯솱톳습颷\ud9b9펻첽늿ꟁꟃ닅꓇돉", a_), innerException);
						}
						goto IL_305;
					case 2:
						goto IL_349;
					case 3:
						goto IL_305;
					case 4:
						goto IL_349;
					}
					goto IL_71;
					IL_305:
					num = (short)981794817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_349:
					num = (short)375521280;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_71:
				num = (short)1127874560;
				short num5 = num;
				array = new byte[30];
				num3 = 0;
				num = (short)1944059908;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_56;
			}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000DF1C File Offset: 0x0000C11C
		private void a(int A_0, char A_1)
		{
			int a_ = 2;
			short num = (short)2107113472;
			switch (num)
			{
			default:
			{
				num = (short)991297544;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					byte b;
					byte[] a_3;
					byte b2;
					switch (num2)
					{
					case 0:
						if (A_1 != 'R')
						{
							num = (short)1786183685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C6;
					case 1:
						if (A_1 != 'B')
						{
							num = (short)1104609287;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E4;
					case 2:
						num = (short)1251999744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_FA;
							}
							int num3;
							for (;;)
							{
								IL_C7:
								switch (num2)
								{
								case 0:
									goto IL_271;
								case 1:
									goto IL_184;
								case 2:
								{
									byte[] array = new byte[1];
									this.ReadMemoryData(A_0, 1, 2, 1, array);
									num = (short)1420165123;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									byte[] array;
									if (array[0] != b)
									{
										num = (short)1468661761;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1668284425;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_1FC;
								case 5:
								{
									if (num3 == 0)
									{
										num = (short)1939144711;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									byte a_2 = 129;
									num = (short)586088454;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_1FC;
								case 7:
								{
									byte a_2 = 1;
									num = (short)1437532164;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									if (num3 >= 3)
									{
										num = (short)1182859266;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1193213957;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_2C9;
								case 10:
									goto IL_271;
								}
								goto IL_FA;
								IL_1FC:
								num = (short)1743952197;
								short num4 = num;
								num = (short)906598725;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
								{
									num = (short)948633600;
									if (num != 0)
									{
									}
									byte a_2;
									this.a(A_0, 0, 2, 3, a_2);
									num3++;
									num = (short)1785921536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_271:
								num = (short)117768200;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_184:
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("氺似嘾㕀♂ᕄ㕆♈㽊⡌ⱎ═ŒŔᑖ祘㵚㱜㙞ൠ٢Ť䙦", a_));
							IL_2C9:
							return;
							IL_FA:
							this.a(A_0, 0, 2, 2, a_3);
							num3 = 0;
							num = (short)1359347722;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_C7;
						}
						catch (global::IBtnWrapperLib.TMEXException)
						{
							throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("氺似嘾㕀♂ᕄ㕆♈㽊⡌ⱎ═ŒŔᑖ祘㵚㱜㙞ൠ٢Ť䙦䥨䙪䵬ᱮᑰᙲ啴㹶᝸ᕺ᡼ൾ쒀ﮂ麗ﾊﾐ뎒뮚列爵햠슢첤쮦\udaa8", a_));
						}
						catch (global::System.Exception ex)
						{
							throw ex;
						}
						goto IL_2E4;
					case 4:
						b2 = 81;
						goto IL_350;
					case 5:
						goto IL_34E;
					case 6:
					{
						num = (short)1723531264;
						short num5 = num;
						b2 = 89;
						goto IL_350;
					}
					case 7:
						num = (short)398458886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1599012865;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_9B;
						}
						continue;
					}
					IL_9B:
					if (A_1 != 'B')
					{
						num = (short)368181250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C6;
					IL_2E4:
					num = (short)2142699524;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_350:
					b = b2;
					a_3 = new byte[]
					{
						48,
						b
					};
					num = (short)783613955;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C6:
					num = (short)1700134913;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_34E:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("爺匼䤾⁀⽂ⱄ⍆楈⩊㽌⡎⑐㹒ご㥖ⵘ筚灜罞①᭢ᕤ๦᭨੪ᥬٮṰᵲ啴ᙶེ᩸ᑼၾꎂꦈﺐ滛뎜", a_));
			}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000E364 File Offset: 0x0000C564
		private void a(byte A_0)
		{
			int a_ = 1;
			short num = (short)2099314693;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_DB;
				case 1:
					if ((A_0 & 64) > 0)
					{
						num = (short)2109734916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1142620162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if ((A_0 & 32) > 0)
					{
						num = (short)1885405187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_115;
				case 4:
					goto IL_1B5;
				case 5:
					goto IL_1D;
				}
				goto IL_45;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_45:
					if ((A_0 & 128) > 0)
					{
						num = (short)1406811837;
						short num3 = num;
						num = (short)1216364221;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D;
						default:
							num = (short)1776615425;
							if (num != 0)
							{
							}
							num = (short)2082865152;
							if (num != 0)
							{
							}
							num = (short)1727135744;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					else
					{
						num = (short)1698037761;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_DB:
			num = (short)1185939456;
			short num4 = num;
			throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("愹砻༽爿ὁ摃ᕅⵇ㹉汋ᩍ㥏㽑ㅓ⑕硗㱙㵛㝝౟ݡc䙥౧Ὡ५乭ѯᵱ味᝵൷๹ᑻᅽﺃﲇ낏ﾙ肟쒡얣쾥쒧\udfa9\udeab쮭麯", a_));
			IL_115:
			throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("愹砻༽琿ὁ摃ᕅⵇ㹉汋ᩍ㥏㽑ㅓ⑕硗㱙㵛㝝౟ᝡᙣͥ䡧䝩䱫ṭᅯqsή᥷ᙹ屻ᱽ勵ꚅﾇ揄望뢕", a_));
			IL_1B5:
			throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("愹砻༽猿ὁ摃ᕅⵇ㹉汋ᩍ㥏㽑ㅓ⑕硗㱙㵛㝝౟ݡc䙥౧Ὡ५乭ѯᵱ味ት᥷๹ᵻ幽轢뺏", a_));
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000E52C File Offset: 0x0000C72C
		private void a(int A_0, byte A_1, byte A_2, byte[] A_3, int A_4)
		{
			int a_ = 8;
			short num = (short)2141192192;
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
				short num7;
				string text;
				short num8;
				int num9;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						goto IL_417;
					case 1:
					{
						num = (short)1277231104;
						short num3 = num;
						goto IL_220;
					}
					case 2:
					{
						byte[] array;
						if (array != null)
						{
							num = (short)2021982212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_220;
					}
					case 3:
						num = (short)32243722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						int num4 = 0;
						num = (short)1896546304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						byte[] array;
						if (array[2] == A_3[2])
						{
							num = (short)1581907971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_220;
					}
					case 6:
						goto IL_220;
					case 7:
						goto IL_417;
					case 8:
					{
						byte[] array;
						int num5;
						if (A_3[num5] != array[num5 + 1])
						{
							num = (short)1205207041;
							if (num != 0)
							{
							}
							num = (short)1508376588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5++;
						num = (short)1911816217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_220;
					case 10:
					{
						byte[] array;
						if (array[3] != 29)
						{
							num = (short)1204289559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5 = 3;
						num = (short)1880621087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						num = (short)1908810229;
						short num6 = num;
						num = (short)2078679541;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_347;
						default:
							num = (short)409337856;
							if (num != 0)
							{
							}
							num = (short)1548091406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						goto IL_4DC;
					case 13:
						num = (short)1152647173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						byte[] array;
						if (array[1] == A_3[1])
						{
							num = (short)195428365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_220;
					}
					case 15:
					{
						byte[] array = new byte[(int)num7];
						num = (short)1062404098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (text != null)
						{
							num = (short)1600192536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 17:
						goto IL_220;
					case 18:
						if ((num8 = global::IBtnWrapperLib.TMEXAPI.TMStrongAccess(A_0, global::IBtnWrapperLib.IBtnCommon.g)) != 1)
						{
							num = (short)1146486806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3AE;
					case 19:
					{
						byte[] array;
						array[0] = 170;
						array[1] = A_1;
						array[2] = A_2;
						num = (short)187564061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						int num5;
						if (num5 >= 33)
						{
							num = (short)491847712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)483524616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_3AE;
					case 22:
						num9++;
						num = (short)1317011484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						byte[] array;
						this.a(array[3]);
						num = (short)1949368321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_257;
					case 25:
						goto IL_5F3;
					case 26:
						if (num9 > (int)this.c)
						{
							num = (short)791609365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)207945746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (num8 == 1)
						{
							num = (short)1487732751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = global::IBtnWrapperLib.TMEXException.g("ᕀโᙄ㍆㭈⑊⍌⡎ၐげ㙔㉖⩘⡚", a_);
						num = (short)1498546193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_1CB;
					case 29:
					{
						byte[] array;
						if (global::IBtnWrapperLib.TMEXAPI.TMBlockStream(A_0, array, num7) >= 0)
						{
							goto IL_347;
						}
						text = global::IBtnWrapperLib.TMEXException.g("ᕀโ݄⭆♈⡊♌ᱎ═⅒ご㙖㑘", a_);
						num = (short)1451098121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
					{
						int num4;
						if (num4 >= A_4)
						{
							num = (short)615579667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						array[num4] = byte.MaxValue;
						num4++;
						num = (short)1183514631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_5F3;
					case 32:
						num = (short)1587412998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_1CB;
					}
					goto IL_C0;
					IL_1CB:
					num = (short)1123614746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_220:
					num = (short)1257635856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_347:
					num = (short)1647640587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3AE:
					num = (short)245825563;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_417:
					num = (short)2130313246;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F3:
					num = (short)125304852;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_257:
				throw new global::IBtnWrapperLib.TMEXException(string.Format(global::IBtnWrapperLib.TMEXException.g("㩀獂㡄杆ై㥊㽌⁎⍐獒≔╖じ⽚㑜ㅞ٠䍢ᅤࡦ䥨ɪ⽬ᩮհݲᩴ᥶奸ᙺ᡼ቾﲄꦆꦈ벌놐ﺖﺚ列뾞얠횢힤캦잨첪趬\ud9ae풰솲\udcb4톶킸\ud8ba\udcbc쮾ꣀ곂ꯄꛈ귊ꋐ냒꟔뛖귘룚뗜连胠蟢엤郦鯨苪駬諮훰\uddf2", a_), num8, text));
				IL_4DC:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ᩀ݂瑄煆ᑈ歊Ṍ⩎═獒Ŕ㹖㑘㹚⽜罞ݠɢ౤୦౨ཪ䍬佮⍰ᙲᑴ፶⩸᡺ོṾ힆권ﶎﮖ붜ﮞ좠잢쮤肦\udda8讪사캮얰킲\uddb4鞶춸펺튼첾꓀꫄ꇆ鳊뿌ꛎꗐ뛒蛔듖ꯘ뫚꧜볞觠돢蓤菦", a_));
				IL_C0:
				num8 = -1;
				text = null;
				num7 = (short)(A_4 + 1);
				num9 = 0;
				num = (short)618332193;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000EB6C File Offset: 0x0000CD6C
		private void a(int A_0, byte A_1, byte A_2, int A_3, byte[] A_4)
		{
			int a_ = 17;
			short num = (short)1619525632;
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
				string text;
				int num9;
				short num10;
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
					{
						byte[] array;
						int num3;
						if (global::IBtnWrapperLib.TMEXAPI.TMBlockStream(A_0, array, (short)num3) >= 0)
						{
							num = (short)756809737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = global::IBtnWrapperLib.TMEXException.g("ṉŋ్㱏㵑㝓㵕ୗ⹙⹛㭝şཡ", a_);
						num = (short)2054750209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)243775596;
						short num4 = num;
						num = (short)1007401068;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_251;
						default:
							num = (short)1789919232;
							if (num != 0)
							{
							}
							goto IL_1A0;
						}
						break;
					}
					case 2:
					{
						num = (short)1895235584;
						short num5 = num;
						if (text != null)
						{
							num = (short)447086606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 3:
						goto IL_1A0;
					case 4:
					{
						int num6 = 3;
						int num3 = A_3 + num6;
						byte[] array = new byte[num3];
						array[0] = 15;
						array[1] = A_1;
						array[2] = A_2;
						int num7 = num6;
						int num8 = 0;
						num = (short)1317339153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_1A0;
					case 6:
					{
						int num3;
						int num7;
						if (num7 >= num3)
						{
							num = (short)1035272203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						int num8;
						array[num7] = A_4[num8];
						num7++;
						num8++;
						num = (short)1053097997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_29E;
					case 8:
						if (num9 > (int)this.c)
						{
							num = (short)2077753351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)97517584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						byte[] array;
						int num3;
						this.a(A_0, A_1, A_2, array, num3);
						num = (short)1362165763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num9++;
						num = (short)1047461900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)864813056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_15D;
					case 13:
						goto IL_11F;
					case 14:
						goto IL_201;
					case 15:
						if (num10 == 1)
						{
							num = (short)847446020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = global::IBtnWrapperLib.TMEXException.g("ṉŋᵍ⑏⁑㭓㡕㽗᭙㽛㵝՟ᅡᝣ", a_);
						num = (short)1721171973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1163526145;
						if (num != 0)
						{
						}
						if ((num10 = global::IBtnWrapperLib.TMEXAPI.TMStrongAccess(A_0, global::IBtnWrapperLib.IBtnCommon.g)) != 1)
						{
							num = (short)170197002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29E;
					case 17:
						goto IL_11F;
					case 18:
						goto IL_15D;
					}
					goto IL_85;
					IL_11F:
					num = (short)1881210886;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15D:
					num = (short)164298760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A0:
					num = (short)1815150594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29E:
					num = (short)1725956111;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_201:
				IL_251:
				throw new global::IBtnWrapperLib.TMEXException(string.Format(global::IBtnWrapperLib.TMEXException.g("ㅉ籋㍍灏ᝑ♓⑕㝗⡙籛⥝቟ୡၣཥ٧൩䱫ᩭὯ剱ᵳ㑵൷๹ࡻᅽꊁﺋ뺏늑ꞕ몙瀞ﾝ즟캡솣슥袧캩\ud9ab\udcad\ud9af\udcb1펳隵쾷좹햻쪽ꖿ냃꧅막꿋볍뇏ꛑ럓뻕꣗믙룛ﻝ臟雡郣菥藧髩飫샭", a_), num10, text));
				IL_85:
				num10 = -1;
				text = null;
				num9 = 0;
				num = (short)2032533522;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000EF7C File Offset: 0x0000D17C
		public void ReadMemoryData(int hSession, byte addrLSB, byte addrMSB, short numBytesRequested, byte[] data)
		{
			int a_ = 0;
			short num = (short)1537802240;
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
				short num4;
				bool flag;
				string text;
				int num8;
				for (;;)
				{
					IL_30:
					byte[] array;
					short length;
					int num9;
					switch (num2)
					{
					case 0:
						goto IL_4D1;
					case 1:
					{
						int num3;
						if (num3 >= (int)numBytesRequested)
						{
							num = (short)1082523655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						data[num3] = 0;
						num3++;
						num = (short)465633284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_4D1;
					case 3:
						if (num4 != 1)
						{
							num = (short)1596653581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12C;
					case 4:
						goto IL_EB;
					case 5:
						goto IL_197;
					case 6:
						if (num4 == 1)
						{
							num = (short)243204115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						text = global::IBtnWrapperLib.TMEXException.g("洸瘺渼䬾㍀ⱂ⭄⁆ࡈ⡊⹌⩎≐⁒", a_);
						num = (short)1316290569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)350289941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)48133981;
						short num5 = num;
						num = (short)798783325;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4D1;
						default:
						{
							num = (short)1962409984;
							if (num != 0)
							{
							}
							short num6;
							if (num6 >= 0)
							{
								num = (short)1364721679;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag = false;
							text = global::IBtnWrapperLib.TMEXException.g("洸瘺缼匾⹀⁂⹄ᑆ㵈㥊⡌⹎㱐", a_);
							num = (short)360579089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 9:
						goto IL_1F9;
					case 10:
						goto IL_12C;
					case 11:
						if (!flag)
						{
							num = (short)335806486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
					{
						int num7;
						if (num7 >= array.Length)
						{
							num = (short)322174999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num7] = byte.MaxValue;
						num7++;
						num = (short)966393870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num8++;
						num = (short)1024131077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_358;
					case 15:
					{
						int num3 = 0;
						num = (short)1261830169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (num8 > (int)this.c)
						{
							num = (short)1096220682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = global::IBtnWrapperLib.TMEXAPI.TMStrongAccess(hSession, global::IBtnWrapperLib.IBtnCommon.g);
						num = (short)527106051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_1F9;
					case 18:
						length = numBytesRequested;
						num = (short)1801125888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						num9 = 3;
						short num10 = (short)((int)numBytesRequested + num9);
						array = new byte[(int)num10];
						int num7 = 0;
						num = (short)148570132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_358;
					case 21:
					{
						short num6;
						if (numBytesRequested <= num6)
						{
							num = (short)1585381394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						length = num6;
						num = (short)1750335490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_231;
					case 23:
					{
						array[0] = 240;
						array[1] = addrLSB;
						array[2] = addrMSB;
						short num10;
						short num6 = global::IBtnWrapperLib.TMEXAPI.TMBlockStream(hSession, array, num10);
						num = (short)195297288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_1F9;
					case 25:
						goto IL_EB;
					case 26:
						goto IL_197;
					}
					goto IL_A3;
					IL_EB:
					num = (short)1504378881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12C:
					num = (short)899416070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_197:
					num = (short)1147600912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F9:
					num = (short)113311755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_358:
					num = (short)1828388876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D1:
					global::System.Array.Copy(array, num9, data, 0, (int)length);
					num = (short)1591214104;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_231:
				num = (short)247922688;
				short num11 = num;
				num = (short)1492516865;
				if (num != 0)
				{
				}
				throw new global::IBtnWrapperLib.TMEXException(string.Format(global::IBtnWrapperLib.TMEXException.g("戸町䘼༾㱀Ṃ敄Ɇ㭈㥊≌㵎煐⅒ご㙖㵘㉚㍜㡞䅠੢❤ቦᵨὪɬŮ兰Ṳၴ᩶ᙸॺѼ兾ꆀ뒄惘ꦈ﶐랖ﺚﲜﮞ좠춢스螦쒨캪사삮쎰쪲閴횶춸鮺\udcbc\udbbeꗀ뇂ꃄ듆뫈﷌럎꫐꿖ꛚꛜ\udbe0鯢ퟤ髦", a_), new object[]
				{
					num4,
					text,
					addrMSB,
					addrLSB
				}));
				IL_A3:
				flag = true;
				num4 = -1;
				num8 = 0;
				text = null;
				num8 = 0;
				num = (short)408027162;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
		private int a(int A_0, int A_1, int A_2, ref byte[] A_3, int A_4)
		{
			short num = (short)1203765248;
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
				int num4;
				int num5;
				int num6;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						byte[] array = array2;
						int num3 = num4;
						array[num3] |= (byte)(num5 << num6);
						num = (short)721616900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)951648258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (A_1 > 0)
						{
							num = (short)457965568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array3 = array2;
						int num7 = num4;
						array3[num7] &= (byte)(~(byte)(num5 << num6));
						num = (short)1077215237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						for (;;)
						{
							num = (short)1391067136;
							short num8 = num;
							if (A_0 != 1)
							{
								goto IL_1C8;
							}
							num = (short)1325015246;
							short num9 = num;
							num = (short)1190469838;
							switch ((num9 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_EE;
							}
						}
						IL_EE:
						num = (short)1295450112;
						if (num != 0)
						{
						}
						num = (short)285409281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_178;
					case 5:
						goto IL_14B;
					}
					goto IL_46;
				}
				IL_14B:
				IL_178:
				global::System.Array.Copy(array2, 0, A_3, A_4, A_3.Length - A_4);
				return 1;
				IL_1C8:
				num = (short)329908225;
				if (num != 0)
				{
				}
				int result = array2[num4] >> num6 & 1;
				global::System.Array.Copy(array2, 0, A_3, A_4, A_3.Length - A_4);
				return result;
				IL_46:
				num5 = 1;
				array2 = new byte[A_3.Length - A_4];
				global::System.Array.Copy(A_3, A_4, array2, 0, A_3.Length - A_4);
				num4 = A_2 / 8;
				num6 = A_2 - num4 * 8;
				num = (short)1993474051;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000F704 File Offset: 0x0000D904
		public bool ValidateBtnInitTimerArgs(char offsetFormat, char expirationAction)
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int num;
			char c;
			short num2;
			bool result;
			char c2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					if (c == 'R')
					{
						num2 = (short)564920330;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)926915104;
					short num3 = num2;
					num2 = (short)1200069152;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_1F2;
					}
					break;
				}
				case 1:
					return result;
				case 2:
					if (c != 'B')
					{
						num2 = (short)169934854;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8B;
				case 3:
					num2 = (short)1170866180;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (c2 == 'N')
					{
						num2 = (short)1603141637;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_170;
				case 5:
					goto IL_21B;
				case 6:
					num2 = (short)1562050560;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (c2 != 'M')
					{
						num2 = (short)33751048;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_21B;
				case 8:
					num2 = 9;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (c2 != 'D')
					{
						num2 = (short)119799811;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_21B;
				case 10:
					goto IL_8B;
				}
				goto IL_45;
				IL_8B:
				num2 = (short)963313665;
				if (num2 != 0)
				{
				}
				num2 = (short)897974272;
				short num4 = num2;
				result = true;
				num2 = (short)929169409;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_21B:
				num2 = (short)134807554;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_170:
			throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ፇ้繋ፍ灏᭑㩓⁕㥗㙙㕛㩝䁟ⵡɣe᭧ཀྵᡫ⡭Ὧqᥳ᝵౷婹ཻ๽ꂍ", a_));
			IL_1F2:
			num2 = (short)61931520;
			if (num2 != 0)
			{
			}
			throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ፇ้繋ፍ灏᭑㩓⁕㥗㙙㕛㩝䁟❡ᱣᙥŧᡩ൫ᩭ᥯ᵱᩳ㝵᭷๹ᕻᅽꊁ憐뢕", a_));
			IL_45:
			result = false;
			c2 = char.ToUpper(offsetFormat);
			c = char.ToUpper(expirationAction);
			num2 = (short)2017329159;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000F96C File Offset: 0x0000DB6C
		public bool ValidateBtnInitUserArgs(byte[] version, byte[] communityCode, string userid, string password)
		{
			int a_ = 6;
			short num = (short)1990918144;
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
					int num4;
					switch (num2)
					{
					case 0:
						num = (short)30408729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (communityCode[0] != 1)
						{
							num = (short)1035599902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B3;
					case 2:
						goto IL_133;
					case 3:
						if (communityCode[1] == 2)
						{
							num = (short)607846428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B8;
					case 4:
					{
						short num3;
						if (num3 > 0)
						{
							num = (short)2082668544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_350;
					}
					case 5:
						if (communityCode[1] == 0)
						{
							num = (short)617807889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B8;
					case 6:
						num = (short)141164553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						byte[] array;
						if (version[num4] != array[num4])
						{
							num = (short)917897228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_52E;
					}
					case 8:
						goto IL_52E;
					case 9:
					{
						if (communityCode == null)
						{
							num = (short)1451687950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						short num3 = (short)userid.Length;
						num = (short)1570308100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						num = (short)1498415104;
						short num5 = num;
						num = (short)38338561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)271646735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						for (;;)
						{
							bool flag = false;
							num = (short)942047300;
							short num6 = num;
							num = (short)1126268996;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_2CC;
							}
						}
						IL_2CC:
						num = (short)1953890304;
						if (num != 0)
						{
						}
						num = (short)352976904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						byte[] array2 = new byte[6];
						array2[4] = 1;
						byte[] array = array2;
						bool flag = true;
						num = (short)1417674776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_3BD;
					case 15:
					{
						short num3;
						if (num3 <= 8)
						{
							num = (short)589758477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27F;
					}
					case 16:
						goto IL_551;
					case 17:
						result = true;
						num = (short)2098331666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						return result;
					case 19:
						if (num4 >= version.Length)
						{
							num = (short)987103253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1996554247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						bool flag;
						if (flag)
						{
							num = (short)479002634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33C;
					}
					case 21:
						goto IL_551;
					case 22:
						if (version != null)
						{
							num = (short)1091829766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58C;
					case 23:
					{
						short num3;
						if (num3 >= 0)
						{
							num = (short)421593099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27F;
					}
					case 24:
					{
						num = (short)1913323521;
						if (num != 0)
						{
						}
						byte[] array;
						if (version.Length != array.Length)
						{
							num = (short)1417216029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = 0;
						num = (short)1032388610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						short num3;
						if (num3 <= 10)
						{
							num = (short)1575878682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_350;
					}
					case 26:
					{
						short num3 = (short)password.Length;
						num = (short)653787159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_133;
					case 28:
						goto IL_4B3;
					case 29:
					{
						bool flag = false;
						num = (short)1336410128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						num = (short)281673731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B4;
					IL_133:
					num = (short)1867972627;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B3:
					num = (short)1859977221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_52E:
					num4++;
					num = (short)752680987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_551:
					num = (short)1932460052;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B8:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("搾Հ煂ᡄ杆H╊㭌⹎㵐㩒ㅔ睖ᩘ㑚ぜ㉞ᑠൢ౤፦ၨ⡪ɬ୮ᑰ卲ٴݶᱸ᡺ᑼ᥾ꦆ", a_));
				IL_27F:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("搾Հ煂ᡄ杆H╊㭌⹎㵐㩒ㅔ睖⥘㩚⹜ⱞᙠౢᝤͦ䥨ᡪᵬ੮ተᩲ፴Ṷᱸὺ卼", a_));
				IL_33C:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("搾Հ煂ᡄ杆H╊㭌⹎㵐㩒ㅔ睖⽘㹚⽜ⱞࡠౢ୤䝦ᩨ᭪࡬౮ᡰᕲᱴቶᵸ啺", a_));
				IL_350:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("搾Հ煂ᡄ杆H╊㭌⹎㵐㩒ㅔ睖ⱘ⡚㡜ⵞࡠݢ䕤ᑦᥨ๪๬ٮᝰᩲၴ፶坸", a_));
				IL_3BD:
				IL_58C:
				throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("搾Հ煂ᡄ杆㥈⑊⑌ⅎ═㙒❔睖⥘㩚⽜㹞ౠ٢ᅤɦ᭨ᡪ䵬౮ၰᵲ᭴ᡶ൸孺ὼ᩾ꆀ춂킄쮆얈ꖊ", a_));
				IL_B4:
				result = false;
				num = (short)1261830166;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000FF1C File Offset: 0x0000E11C
		public void GetMaxFileSpaceAvailable(int hSession, string fileName, out short pMaxBytes)
		{
			int a_ = 9;
			short num = (short)1613627392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)555876353;
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
				short num3 = -1;
				short num4 = 58;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_B7;
					}
					for (;;)
					{
						IL_84:
						switch (num2)
						{
						case 0:
						{
							array = this.LoadFileName(fileName);
							num = (short)1019085623;
							short num5 = num;
							num = (short)385221431;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)1411186688;
								if (num != 0)
								{
								}
								num = (short)1238499331;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							if (fileName.Length > 3)
							{
								num = (short)1819082752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17F;
						case 2:
							num = (short)1631584261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (array != null)
							{
								num = (short)1011810306;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_100;
						case 4:
							goto IL_271;
						case 5:
							if (this.b(hSession, array, true))
							{
								num = (short)1932722185;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_271;
						case 6:
							goto IL_28A;
						case 7:
							if (fileName != null)
							{
								num = (short)359989256;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17F;
						case 8:
							num = (short)496631809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							pMaxBytes = num4 + (short)(array[6] * 29);
							num = (short)453574666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_271;
						}
						goto IL_B7;
						IL_17F:
						pMaxBytes = num4;
						num = (short)1636368388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_271:
						num = (short)263127046;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_100:
					throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("ୁ⩃ぅ⥇♉╋⩍灏㍑♓ㅕⵗ㝙㥛そᑟᅡ䩣䙥⹧ͩk୭㕯ᱱsѵŷ婹ύώꢇ꺍ﺏ歹뢗뮙", a_));
					IL_28A:
					goto IL_2A3;
					IL_B7:
					this.CreateFile(hSession, out num3, array, out num4);
					this.CloseFile(hSession, ref num3);
					num = (short)393223;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_84;
				}
				catch (global::IBtnWrapperLib.TMEXException innerException)
				{
					throw new global::System.Exception(global::IBtnWrapperLib.TMEXException.g("⭁ك㍅㱇㹉⍋⁍灏㵑⑓㍕⩗㭙⡛㝝ཟౡ䑣ͥၧ३५ṭѯ᭱᭳ᡵ塷坹屻ൽꒃ쾅ﲍ햏캟芡슣즥\udaa7誩좫쮭쒯펱\uddb3\udab5쮷", a_), innerException);
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
				IL_2A3:
				num = (short)1718091776;
				short num6 = num;
				return;
			}
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00010228 File Offset: 0x0000E428
		private bool b(int A_0, byte[] A_1, bool A_2)
		{
			short num = (short)863698944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_83;
				}
				bool result;
				byte[] array;
				short num4;
				for (;;)
				{
					IL_28:
					int num3;
					global::IBtnWrapperLib.TMEX_API_CODE a_;
					switch (num2)
					{
					case 0:
						goto IL_256;
					case 1:
					{
						bool flag = false;
						num = (short)135069696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_27A;
					case 3:
					{
						bool flag = true;
						num3 = 0;
						num = (short)356515857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						bool flag;
						result = flag;
						global::System.Array.Copy(array, A_1, 40);
						num = (short)961282064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (num4 == 0)
						{
							num = (short)33554434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::IBtnWrapperLib.TMEXException.a(num4, a_, null);
						num = (short)1497432073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						bool flag;
						if (flag)
						{
							num = (short)2053701636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = this.b(A_0, A_1, false);
						num = (short)539885581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_165;
					case 8:
						a_ = global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMFirstFile;
						num = (short)565051410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return result;
					case 10:
						num = (short)1688797190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						return result;
					case 12:
					{
						if (num4 > 0)
						{
							num = (short)1333133315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1789788160;
						short num5 = num;
						num = (short)2087387155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						return result;
					case 14:
						goto IL_307;
					case 15:
						if (num3 >= 5)
						{
							num = (short)1200488458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1029242900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						return result;
					case 17:
						goto IL_307;
					case 18:
						num = (short)1939406849;
						if (num != 0)
						{
						}
						goto IL_165;
					case 19:
						if (A_2)
						{
							num = (short)538837000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_ = global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMNextFile;
						num = (short)979369991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (array[num3] != A_1[num3])
						{
							num = (short)1401552897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_256;
					}
					goto IL_83;
					IL_165:
					num = (short)220594181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_256:
					num3++;
					num = (short)714539022;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27A:
					global::System.Diagnostics.Trace.WriteLine(global::IBtnWrapperLib.TMEXException.f(num4, a_));
					num = (short)98238475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_307:
					num = (short)387018118;
					short num6 = num;
					num = (short)1393454470;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_27A;
					default:
						num = (short)777125888;
						if (num != 0)
						{
						}
						num = (short)1892614159;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				return result;
				IL_83:
				result = false;
				array = new byte[40];
				num4 = this.a(A_0, array, A_2);
				num = (short)1661927436;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00010624 File Offset: 0x0000E824
		private short a(int A_0, byte[] A_1, bool A_2)
		{
			short num = (short)1571684352;
			short num2 = num;
			num = (short)754162087;
			short num3 = num;
			num = (short)961845671;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1AD:
				num = (short)897318916;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1324089344;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_AB;
				}
				break;
			}
			short num5;
			int num6;
			for (;;)
			{
				IL_7D:
				switch (num4)
				{
				case 0:
					goto IL_167;
				case 1:
					if (num5 < 0)
					{
						num = (short)796721158;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return num5;
				case 2:
					if (A_2)
					{
						num = (short)1125056519;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num5 = global::IBtnWrapperLib.TMEXAPI.TMNextFile(A_0, global::IBtnWrapperLib.IBtnCommon.g, A_1);
					num = (short)551223305;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (num6 > (int)this.c)
					{
						num = (short)1061355525;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1117847554;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1C7;
				case 5:
					return num5;
				case 6:
					num6++;
					num = (short)2058027016;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_165;
				case 8:
					goto IL_167;
				case 9:
					goto IL_1C7;
				}
				goto IL_AB;
				IL_167:
				num = (short)200540163;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C7:
				num = (short)109182977;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_165:
			num5 = global::IBtnWrapperLib.TMEXAPI.TMFirstFile(A_0, global::IBtnWrapperLib.IBtnCommon.g, A_1);
			goto IL_1AD;
			IL_AB:
			num = (short)1142751233;
			if (num != 0)
			{
			}
			num5 = -1;
			num6 = 0;
			num = (short)925630464;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7D;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00010830 File Offset: 0x0000EA30
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000108DC File Offset: 0x0000EADC
		public short Port
		{
			get
			{
				short num = (short)135694218;
				short num2 = num;
				num = (short)899123082;
				switch (num2 == num)
				{
				}
				num = (short)245891072;
				short num3 = num;
				num = (short)1028915201;
				if (num != 0)
				{
				}
				num = (short)187301888;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)2011122280;
				short num2 = num;
				num = (short)397298280;
				switch (num2 == num)
				{
				}
				num = (short)1120862208;
				short num3 = num;
				num = (short)553254913;
				if (num != 0)
				{
				}
				num = (short)613875712;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0001098C File Offset: 0x0000EB8C
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00010A3C File Offset: 0x0000EC3C
		public short PortType
		{
			get
			{
				short num = (short)1548625526;
				short num2 = num;
				num = (short)485893750;
				switch (num2 == num)
				{
				}
				num = (short)1518600192;
				short num3 = num;
				num = (short)589168640;
				if (num != 0)
				{
				}
				num = (short)1766719489;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1508161556;
				short num2 = num;
				num = (short)1063958548;
				switch (num2 == num)
				{
				}
				num = (short)1274937344;
				short num3 = num;
				num = (short)1114963968;
				if (num != 0)
				{
				}
				num = (short)544145409;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00010AF0 File Offset: 0x0000ECF0
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00010BA0 File Offset: 0x0000EDA0
		public short MaxRetryCount
		{
			get
			{
				short num = (short)1727831630;
				short num2 = num;
				num = (short)499278;
				switch (num2 == num)
				{
				}
				num = (short)1758134272;
				short num3 = num;
				num = (short)262537216;
				if (num != 0)
				{
				}
				num = (short)583073793;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1410139562;
				short num2 = num;
				num = (short)1971717546;
				switch (num2 == num)
				{
				}
				num = (short)944504832;
				short num3 = num;
				num = (short)1658781697;
				if (num != 0)
				{
				}
				num = (short)201457664;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x040000AA RID: 170
		private short a;

		// Token: 0x040000AB RID: 171
		private short b;

		// Token: 0x040000AC RID: 172
		private short c;

		// Token: 0x040000AD RID: 173
		private bool d;

		// Token: 0x040000AE RID: 174
		private byte e;

		// Token: 0x040000AF RID: 175
		private byte[] f;

		// Token: 0x040000B0 RID: 176
		private static byte[] g;

		// Token: 0x040000B1 RID: 177
		private static byte[] h;

		// Token: 0x040000B2 RID: 178
		private static short[] i;
	}
}
