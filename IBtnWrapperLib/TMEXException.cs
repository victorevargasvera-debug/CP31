using System;

namespace IBtnWrapperLib
{
	// Token: 0x02000018 RID: 24
	public class TMEXException : global::System.ApplicationException
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x00016B74 File Offset: 0x00014D74
		internal TMEXException()
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00016B94 File Offset: 0x00014D94
		internal TMEXException(string A_0) : base(A_0)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00016BB4 File Offset: 0x00014DB4
		internal TMEXException(string A_0, short A_1, global::IBtnWrapperLib.TMEX_API_CODE A_2) : this(A_0, A_1, A_2, null)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00016BCC File Offset: 0x00014DCC
		internal TMEXException(string A_0, short A_1, global::IBtnWrapperLib.TMEX_API_CODE A_2, global::System.Exception A_3) : base(A_0, A_3)
		{
			this.a = A_1;
			this.b = A_2;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00016CA8 File Offset: 0x00014EA8
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00016BFC File Offset: 0x00014DFC
		public short ErrorCode
		{
			get
			{
				short num = (short)1450636035;
				short num2 = num;
				num = (short)698217219;
				switch (num2 == num)
				{
				}
				num = (short)2112880641;
				if (num != 0)
				{
				}
				num = (short)947912704;
				if (num != 0)
				{
				}
				num = (short)650838016;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)1278681601;
				short num2 = num;
				num = (short)334373377;
				switch (num2 == num)
				{
				}
				num = (short)1247084545;
				if (num != 0)
				{
				}
				num = (short)1411776512;
				if (num != 0)
				{
				}
				num = (short)385155072;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00016E04 File Offset: 0x00015004
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00016D58 File Offset: 0x00014F58
		internal global::IBtnWrapperLib.TMEX_API_CODE MethodCode
		{
			get
			{
				short num = (short)1115488257;
				if (num != 0)
				{
				}
				num = (short)591557139;
				short num2 = num;
				num = (short)434467347;
				switch (num2 == num)
				{
				}
				num = (short)1179516928;
				if (num != 0)
				{
				}
				num = (short)326434816;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)1998737139;
				short num2 = num;
				num = (short)479153907;
				switch (num2 == num)
				{
				}
				num = (short)1079640064;
				if (num != 0)
				{
				}
				num = (short)1279000577;
				if (num != 0)
				{
				}
				num = (short)324009984;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00016EB4 File Offset: 0x000150B4
		internal static void a(short A_0, global::IBtnWrapperLib.TMEX_API_CODE A_1, global::System.Exception A_2)
		{
			short num = (short)1877326468;
			short num2 = num;
			num = (short)593803908;
			switch (num2 == num)
			{
			}
			num = (short)1267335169;
			if (num != 0)
			{
			}
			num = (short)1391132672;
			if (num != 0)
			{
			}
			num = (short)1198587904;
			short num3 = num;
			throw new global::IBtnWrapperLib.TMEXException(global::IBtnWrapperLib.TMEXException.f(A_0, global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMExtendedStartSession), A_0, global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMExtendedStartSession, A_2);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00016F6C File Offset: 0x0001516C
		internal static string f(short A_0, global::IBtnWrapperLib.TMEX_API_CODE A_1)
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int num;
			string result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					switch (A_1)
					{
					case global::IBtnWrapperLib.TMEX_API_CODE.DLL_METHOD:
						return result;
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMExtendedStartSession:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMEndSession:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMValidSession:
						result = global::IBtnWrapperLib.TMEXException.e(A_0, A_1);
						num2 = (short)170852359;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMFirstFile:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMNextFile:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMOpenFile:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMCreateFile:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMCloseFile:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMReadFile:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMWriteFile:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMDeleteFile:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMFormat:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMAttribute:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMReNameFile:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMChangeDirectory:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMDirectoryMR:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMCreateProgramJob:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMDoProgramJob:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMWriteAddFile:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMTerminateAddFile:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_GetVersion:
						result = global::IBtnWrapperLib.TMEXException.d(A_0, A_1);
						num2 = (short)93847552;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMReadPacket:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMWritePacket:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMBlockIO:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMExtendedReadPage:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMProgramByte:
					{
						result = global::IBtnWrapperLib.TMEXException.c(A_0, A_1);
						num2 = (short)441901285;
						short num3 = num2;
						num2 = (short)266330341;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num2 = (short)275120129;
							if (num2 != 0)
							{
							}
							num2 = (short)570949632;
							if (num2 != 0)
							{
							}
							num2 = (short)90898435;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMFirst:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMNext:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMAccess:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMStrongAccess:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMStrongAlarmAccess:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMOverAccess:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMRom:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMFirstAlarm:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMNextAlarm:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMFamilySearchSetup:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMSkipFamily:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMAutoOverDrive:
						result = global::IBtnWrapperLib.TMEXException.b(A_0, A_1);
						num2 = (short)183500802;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMSetup:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMTouchByte:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMTouchReset:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMTouchBit:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMProgramPulse:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMClose:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMOneWireCom:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMOneWireLevel:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMGetTypeVersion:
					case global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMBlockStream:
						result = global::IBtnWrapperLib.TMEXException.a(A_0, A_1);
						num2 = (short)82640902;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)2122973192;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 2:
					return result;
				case 3:
					return result;
				case 4:
					return result;
				case 5:
				{
					result = global::IBtnWrapperLib.TMEXException.g("Ὁ≋╍㹏㵑⍓㡕硗Ὑ⹛ⱝཟၡ䕣", a_);
					num2 = (short)241893376;
					short num4 = num2;
					num2 = (short)858849284;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					return result;
				case 7:
					return result;
				case 8:
					num2 = (short)1531707397;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_3D;
			}
			return result;
			IL_3D:
			result = null;
			num2 = (short)1283915777;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00017244 File Offset: 0x00015444
		private static string e(short A_0, global::IBtnWrapperLib.TMEX_API_CODE A_1)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			string result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					num2 = (short)336068611;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_C7;
				case 3:
				{
					num2 = (short)706570266;
					short num3 = num2;
					num2 = (short)482240538;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1174405120;
						if (num2 != 0)
						{
						}
						if (A_0 == -200)
						{
							num2 = (short)284360708;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = global::IBtnWrapperLib.TMEXException.a(A_0, 'S');
						num2 = (short)1406533632;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					result = string.Format(global::IBtnWrapperLib.TMEXException.g("၊Ṍ㑎慐⹒ࡔ睖੘㹚⹜ⱞࡠౢ୤䝦ݨѪᥬ佮ݰቲᥴṶᵸ啺", a_), A_0);
					num2 = (short)321585157;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					return result;
				case 6:
					if (A_0 != -201)
					{
						num2 = (short)788135937;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = string.Format(global::IBtnWrapperLib.TMEXException.g("၊Ṍ㑎慐⹒ࡔ睖ᅘ㩚⽜㭞ᙠɢᝤɦ㙨㡪ᵬ੮ተᩲ፴Ṷ᩸孺᥼ൾꦈﮎ놐杖ﾚ붜ﺞ쾠잢薤캦\udaa8讪\udfac쪮산욲\udcb4얶\udcb8\udfba鎼", a_), A_0);
					num2 = (short)1556021250;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_35;
			}
			IL_C7:
			num2 = (short)807731201;
			if (num2 != 0)
			{
			}
			return result;
			IL_35:
			result = null;
			num2 = (short)1187381248;
			short num4 = num2;
			num2 = (short)929431558;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00017428 File Offset: 0x00015628
		private static string d(short A_0, global::IBtnWrapperLib.TMEX_API_CODE A_1)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_89;
			}
			int num;
			short num2;
			string result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_36D;
				case 1:
					num2 = (short)1807679493;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_235;
				case 3:
					goto IL_1C9;
				case 4:
					goto IL_1FF;
				case 5:
					result = global::IBtnWrapperLib.TMEXException.a(A_0, 'F');
					num2 = (short)2039021585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_337;
				case 7:
					goto IL_4EB;
				case 8:
					goto IL_592;
				case 9:
					return result;
				case 10:
					goto IL_600;
				case 11:
				{
					num2 = (short)1439038270;
					short num3 = num2;
					num2 = (short)1812069182;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_21E;
					default:
						goto IL_6D9;
					}
					break;
				}
				case 12:
					goto IL_26B;
				case 13:
					goto IL_2D9;
				case 14:
					goto IL_637;
				case 15:
					goto IL_448;
				case 16:
					goto IL_15C;
				case 17:
					goto IL_394;
				case 18:
					switch (A_0)
					{
					case -24:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌᭎㥐㙒畔ᙖ㵘㽚᭜㙞ൠ٢䕤๦ᩨ䭪ᥬ੮ͰṲᱴ᥶ᡸེ᡼᭾ꆀꦈﾐﲒ랖ﮘﺚ붜ﺞ토펢삤즦춨캪즬辮얰\udcb2鮴", a_), A_0);
						num2 = (short)1665662996;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -23:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌᭎㥐㙒❔㉖祘㩚⽜㩞䅠ൢ੤०䑨⹪㵬㵮㹰㹲啴ݶᡸॺॼ౾ꆀꞆﶈ꾎\udc90朗힚ﲜ膠잢키햦삨얪쪬辮킰\uddb2閴횶춸쾺\ud8bc튾뇀럂돆ꛈ뷌뷎뻐듒꟔뛖듘", a_), A_0);
						num2 = (short)1252327445;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -22:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌୎㑐╒㱔㑖㱘筚㑜ⱞ䅠ᑢᝤ๦ᵨ๪䁬ὮͰᱲŴቶེ᩸᡼᭾꾀", a_), A_0);
						num2 = (short)311033856;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -21:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌᭎㥐㙒❔㉖祘㉚⹜罞འౢ䕤ᝦ᭨Ѫ੬ᵮၰṲ啴ᵶᙸ᥺嵼౾ꎌ", a_), A_0);
						num2 = (short)1944190980;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -20:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌Ɏぐ⭒㱔㩖ⱘ㙚絜㭞Ѡ።ᅤས䥨Ѫ୬佮䁰䍲啴Ѷ౸᥺偼᭾ﶈﾌ떔ﺖ뮚爵삠삢춤슦춨薪", a_), A_0);
						num2 = (short)915931143;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -19:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌୎㡐⅒ご㑖ⵘ㑚⽜♞䅠๢ၤᑦᵨ䭪ཬ੮兰ᙲᡴݶ൸ɺ嵼୾ꎂ歷놐朗릖", a_), A_0);
						num2 = (short)816709656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -18:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌ᱎ⅐㙒㙔㹖㽘㉚㡜㭞䅠ݢ౤ᕦ౨ࡪᥬnͰੲ啴Ṷ੸孺ᑼᅾꖊ", a_), A_0);
						num2 = (short)2066612240;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -17:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌੎⍐⅒㩔╖祘㉚㍜罞ᕠୢd䝦⑨ɪ๬ᵮṰ㽲ᑴ᥶啸孺ぼᙾ쮆권떔練붜ﶞ쒠莢횤슦\udda8\udeaa\uddac辮쒰삲\udcb4\ud9b6\udeb8鮺鋀ꛂ뇄닆마", a_), A_0);
						num2 = (short)329580556;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -16:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌ॎ㡐㽒ご睖ㅘ㩚㍜㭞ൠ٢䕤ͦ٨๪Ṭ佮ὰᱲŴ坶ᱸͺᑼ౾궂", a_), A_0);
						num2 = (short)109641737;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -15:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌᭎⍐⩒㱔㥖㹘筚⥜ぞ䅠ݢd୦౨Ὢ࡬佮Ͱᙲᑴ፶奸ᑺ፼፾ꎂꎌ", a_), A_0);
						num2 = (short)891617303;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -14:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌َ㵐㽒ござ㡘㝚絜㥞ࡠརd䡦൨ɪὬ੮ተݲᩴնx孺፼Ṿꮄ", a_), A_0);
						num2 = (short)1070530587;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -13:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌ॎ⑐㵒㙔⍖じ㑚㍜罞འౢᅤ䝦ᩨṪᵬὮṰŲŴቶᵸ啺", a_), A_0);
						num2 = (short)1669595149;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -12:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌᭎⍐⩒㱔㥖㹘筚⥜ぞ䅠ᑢᝤ๦ᵨ๪䵬๮兰Ųၴᙶᵸ孺᭼ᙾꖄ붒", a_), A_0);
						num2 = (short)1700462603;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -11:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌ᡎ⍐㩒⅔㉖祘㹚⽜ⵞ๠ᅢ䥤䝦ᥨ੪Ὤ᭮兰Ṳᑴ๶奸፺ᱼॾꎂﾆ麗ﾌ붒", a_), A_0);
						num2 = (short)1206124566;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -10:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌Ŏ㹐❒畔㉖㝘㑚⡜㡞ॠ䍢ᝤࡦ٨٪䵬nὰ卲ᅴቶླྀቺṼ᩾ꆀꞆﺈ力ﮎ붒", a_), A_0);
						num2 = (short)579862536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -9:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌᭎⍐⩒㱔㥖㹘筚⥜ぞ䅠ᅢd٦൨䭪౬佮ٰŲᱴͶᱸ孺᭼ᙾꖄ붒", a_), A_0);
						num2 = (short)1039400979;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -8:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌ࡎ㡐╒ご㥖祘㵚㑜㍞Ѡ䍢൤٦ݨཪŬ੮兰ᩲٴ坶᝸ᑺॼ彾놐떔놞", a_), A_0);
						num2 = (short)1735131161;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -7:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌ॎ㡐㽒ご睖⹘㉚⥜㝞䅠ၢᕤɦ੨ɪ୬ٮᑰᝲ啴᥶ᡸᙺ᡼彾꾎ﲔ뎜", a_), A_0);
						num2 = (short)366280714;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -6:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌ॎ㡐㽒ご睖⩘⭚㡜㱞ࡠբ౤ɦ൨䭪Ѭᱮ兰ᵲᩴͶ奸ቺ፼彾Ꞇﺊﾌﶎﶒ랖ﶘ爵슠힢쪤햦킨薪", a_), A_0);
						num2 = (short)1192755206;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -5:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌๎㵐㽒畔ㅖじ㝚㡜罞ॠɢ୤ͦը๪Ṭ佮ၰŲၴ坶ၸᕺ嵼੾ꮄ", a_), A_0);
						num2 = (short)352976899;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -4:
					{
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌ൎ⑐㕒㍔㉖⭘筚㑜ⱞ䅠ၢࡤ٦ըݪ࡬ᵮ兰ݲᵴᙶ᝸孺ॼ᝾ꎂ권ﮎﺐ뎒ﾚ뎜", a_), A_0);
						num2 = (short)151846912;
						short num4 = num2;
						num2 = (short)1334050831;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case -3:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌ॎ㡐㽒ご硖㵘㉚⽜㩞ɠᝢ੤ᕦၨ䭪Ὤ੮ၰᝲ啴ቶ୸ॺቼൾ꾀", a_), A_0);
						num2 = (short)1583611930;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -2:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌ᡎ⍐㱒㭔ざ祘⽚⑜⽞Ѡ䍢੤Ŧ䥨ཪ࡬᥮ᡰၲၴ坶ὸᑺོ彾뎒杖ﲘﲜ좠첢쮤覦", a_), A_0);
						goto IL_21E;
					case -1:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ᩀՂ㹄睆㑈ᙊ浌Ŏ㹐獒ㅔ㉖⽘㉚㹜㩞䅠բ੤ቦݨཪ䵬nὰ卲㡴Ṷ᩸ॺቼ㍾ꮄ", a_), A_0);
						num2 = (short)1487732750;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)1646067713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 19:
					goto IL_3CB;
				case 20:
					goto IL_2A3;
				case 21:
					goto IL_66E;
				case 22:
					goto IL_55B;
				case 23:
					goto IL_5C8;
				case 24:
					goto IL_523;
				case 25:
					goto IL_4B5;
				case 26:
					goto IL_47F;
				case 27:
					goto IL_192;
				}
				goto IL_89;
				IL_21E:
				num2 = (short)37355522;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_15C:
			IL_192:
			IL_1C9:
			IL_1FF:
			IL_235:
			IL_26B:
			IL_2A3:
			return result;
			IL_2D9:
			num2 = (short)237305857;
			if (num2 != 0)
			{
			}
			IL_337:
			IL_36D:
			IL_394:
			IL_3CB:
			IL_448:
			IL_47F:
			IL_4B5:
			IL_4EB:
			IL_523:
			IL_55B:
			IL_592:
			IL_5C8:
			IL_600:
			IL_637:
			IL_66E:
			return result;
			IL_6D9:
			num2 = (short)2134245376;
			if (num2 != 0)
			{
			}
			return result;
			IL_89:
			result = null;
			num2 = (short)17825810;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00017B60 File Offset: 0x00015D60
		private static string c(short A_0, global::IBtnWrapperLib.TMEX_API_CODE A_1)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			string result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					return result;
				case 2:
					switch (A_0)
					{
					case -11:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ὃቅ㍇穉ㅋፍ灏ᙑㅓ⁕ㅗ㥙㥛繝͟͡੣ࡥݧṩ䱫౭ᕯ剱ᥳ᥵ᱷ፹᩻᝽ꪃ", a_), A_0);
						num2 = (short)1331560451;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -10:
					{
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ὃቅ㍇穉ㅋፍ灏ɑ㕓ㅕ㵗穙㹛㭝य़ౡͣ䙥ᩧཀྵ൫੭偯᭱ݳ噵੷ό᡻᝽ꊋ", a_), A_0);
						num2 = (short)2071134208;
						short num3 = num2;
						num2 = (short)1096089604;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case -9:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ὃቅ㍇穉ㅋፍ灏ᑑ⅓㡕㭗⹙㕛ㅝ๟䉡੣॥ᱧ䩩Ὣ᭭oɱ᭳ѵ౷ό᡻幽ꒃﾋ꺍ﾕﮗﾙ늛", a_), A_0);
						num2 = (short)1054801927;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -8:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ὃቅ㍇穉ㅋፍ灏ၑ㡓㥕㭗ㅙ籛⩝቟͡੣ᕥ๧ཀྵṫ乭ѯᵱ᭳噵᩷፹᭻偽", a_), A_0);
						num2 = (short)348585984;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -7:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ὃቅ㍇穉ㅋፍ灏ᙑㅓ⁕ㅗ㥙㥛繝๟ൡၣ䙥๧թᥫmᑯ山", a_), A_0);
						num2 = (short)1368195073;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -6:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ὃቅ㍇穉ㅋፍ灏ɑ㕓㕕㍗㽙⡛繝ᑟൡୣ䙥ѧ୩ṫ७ᕯ山", a_), A_0);
						num2 = (short)949878792;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -5:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ὃቅ㍇穉ㅋፍ灏ɑ㕓㕕㍗㽙⡛繝౟͡ᙣť൧ᡩ䱫ᩭᡯ፱ᩳ噵᩷ཹ᩻᡽ꪃ", a_), A_0);
						num2 = (short)1938554889;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -4:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("ὃቅ㍇穉ㅋፍ灏ᝑ♓⑕㝗⡙籛ⱝ՟͡cཥ٧൩䱫ṭᅯᅱέ፵౷呹", a_), A_0);
						num2 = (short)1645281285;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)3473419;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 3:
					return result;
				case 4:
					return result;
				case 5:
					return result;
				case 6:
					return result;
				case 7:
					return result;
				case 8:
					return result;
				case 9:
					return result;
				case 10:
				{
					result = global::IBtnWrapperLib.TMEXException.a(A_0, 'T');
					num2 = (short)1021332878;
					short num4 = num2;
					num2 = (short)522472846;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)394199040;
						if (num2 != 0)
						{
						}
						num2 = (short)1335361542;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 11:
					num2 = (short)1023279114;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_49;
			}
			return result;
			IL_49:
			num2 = (short)1130758145;
			if (num2 != 0)
			{
			}
			result = null;
			num2 = (short)963903490;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00017EA0 File Offset: 0x000160A0
		private static string b(short A_0, global::IBtnWrapperLib.TMEX_API_CODE A_1)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			string result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return result;
				case 1:
				{
					num2 = (short)726532096;
					short num3 = num2;
					num2 = (short)1721630723;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					return result;
				case 3:
					if (A_0 == 0)
					{
						num2 = (short)899481605;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D6;
				case 4:
				{
					num2 = (short)934739969;
					if (num2 != 0)
					{
					}
					num2 = (short)1004254884;
					short num4 = num2;
					num2 = (short)1353430692;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D6;
					default:
						num2 = (short)1631059968;
						if (num2 != 0)
						{
						}
						if (A_1 == global::IBtnWrapperLib.TMEX_API_CODE.TMEX_TMFamilySearchSetup)
						{
							num2 = (short)1858863105;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_D6;
					}
					break;
				}
				case 5:
					result = global::IBtnWrapperLib.TMEXException.g("渹焻砽ℿ⽁ⵃ⩅ㅇ᥉⥋⽍≏ㅑ㱓Օ㵗⹙⥛⹝婟䉡㽣⡥塧㝩䱫❭ṯѱᕳ᩵ᅷṹ屻㡽ꪉ\ud88b몓", a_);
					num2 = (short)1378156544;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_31;
				IL_D6:
				result = global::IBtnWrapperLib.TMEXException.a(A_0, 'N');
				num2 = (short)264175618;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_31:
			result = null;
			num2 = (short)1677328388;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00018038 File Offset: 0x00016238
		private static string a(short A_0, global::IBtnWrapperLib.TMEX_API_CODE A_1)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			short num2;
			string result;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					if (A_0 == -12)
					{
						num2 = (short)317259780;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1217986561;
					if (num2 != 0)
					{
					}
					result = global::IBtnWrapperLib.TMEXException.a(A_0, 'H');
					num2 = (short)2036596742;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1949630464;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
					return result;
				case 4:
					goto IL_182;
				case 5:
				{
					if (A_0 != -13)
					{
						num2 = (short)1056964609;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)141754368;
					short num3 = num2;
					result = string.Format(global::IBtnWrapperLib.TMEXException.g("Ṅཆ㉈筊が቎煐ቒ㭔睖ⱘ㕚⹜ぞൠ੢٤๦ᵨ๪६佮ᑰղၴ᥶൸孺ቼ᱾권ﾐ뎒ﾖﲘ뮚겜늞쪢힤슦螨", a_), A_0);
					num2 = (short)621150210;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					return result;
				}
				goto IL_35;
			}
			return result;
			IL_35:
			result = null;
			num2 = (short)1805996753;
			short num4 = num2;
			num2 = (short)1447973585;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_182:
				result = string.Format(global::IBtnWrapperLib.TMEXException.g("Ṅཆ㉈筊が቎煐ᕒ㑔㹖㕘⹚⽜㩞䅠ᝢ੤䝦੨ѪlɮѰᵲᱴᑶᡸེ᡼彾ꦈﶎﲘ뮚ﲜﮞ삠펢톤슦\udba8薪", a_), A_0);
				num2 = (short)1353187331;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)1857552384;
				if (num2 != 0)
				{
				}
				num2 = (short)1099628549;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00018214 File Offset: 0x00016414
		private static string a(short A_0, char A_1)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_71;
			}
			int num;
			short num2;
			string result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (A_0 != -201)
					{
						num2 = (short)371064850;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = string.Format(global::IBtnWrapperLib.TMEXException.g("᱆㉈筊が㑎恐⹒ࡔ睖ᅘ㩚⽜㭞ᙠɢᝤɦ䥨㡪ᵬ੮ተᩲ፴Ṷ᩸孺᥼ൾꦈﮎ놐杖ﾚ붜ﺞ쾠잢薤캦\udaa8讪\udfac쪮산욲\udcb4얶\udcb8\udfba鎼", a_), A_1, A_0);
					num2 = (short)1555234828;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_227;
				case 2:
					goto IL_227;
				case 3:
					return result;
				case 4:
					return result;
				case 5:
					return result;
				case 6:
					return result;
				case 7:
					num2 = (short)24444928;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					num2 = (short)477429760;
					short num3 = num2;
					if (A_0 != -200)
					{
						num2 = (short)641269775;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = string.Format(global::IBtnWrapperLib.TMEXException.g("᱆㉈筊が㑎恐⹒ࡔ睖੘㹚⹜ⱞࡠౢ୤䝦ݨѪᥬ佮ݰቲᥴṶᵸ啺", a_), A_1, A_0);
					num2 = (short)343343107;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					switch (A_0)
					{
					case -3:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("᱆㉈筊が㑎恐⹒ࡔ睖὘⹚㍜㱞ᕠ੢੤०䥨ժɬ᭮兰rtݶॸᑺོ୾ꮄ", a_), A_1, A_0);
						num2 = (short)1736966150;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -2:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("᱆㉈筊が㑎恐⹒ࡔ睖क़㑚⽜⭞䅠ݢ੤ɦᩨ䭪ͬnհ卲ၴྲྀၸࡺॼ兾", a_), A_1, A_0);
						goto IL_10B;
					case -1:
						result = string.Format(global::IBtnWrapperLib.TMEXException.g("᱆㉈筊が㑎恐⹒ࡔ睖क़㑚⽜⭞䅠੢ᙤ䝦ݨѪᥬ佮ᡰᵲᱴͶၸ᩺ᅼᙾﮀꦆ", a_), A_1, A_0);
						num2 = (short)345571332;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)2044067861;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 10:
					if (A_0 != -13)
					{
						num2 = (short)212598801;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = string.Format(global::IBtnWrapperLib.TMEXException.g("᱆㉈筊が㑎恐⹒ࡔ睖ౘ㕚⹜ぞൠ੢٤๦ᵨ๪६佮ᑰղၴ᥶൸孺ቼ᱾권ﾐ뎒꒔몖爵辠", a_), A_1, A_0);
					num2 = (short)164691982;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					return result;
				case 12:
					return result;
				case 13:
					if (A_0 != -12)
					{
						num2 = (short)1431896080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = string.Format(global::IBtnWrapperLib.TMEXException.g("᱆㉈筊が㑎恐⹒ࡔ睖ౘ㕚㱜㵞ൠ٢䕤፦٨䭪๬nᱰṲt᥶ၸ᡺ᱼ୾ꎂﶈ권뾞삠잢쒤힦\udda8캪\udfac膮", a_), A_1, A_0);
					num2 = (short)748093459;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					return result;
				case 15:
					num2 = (short)1269694465;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
				{
					num2 = (short)649041390;
					short num4 = num2;
					num2 = (short)434345454;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10B;
					default:
						num2 = (short)1702625281;
						if (num2 != 0)
						{
						}
						num2 = (short)1075052544;
						if (num2 != 0)
						{
						}
						num2 = (short)792264713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 17:
					num2 = (short)113246221;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					num2 = (short)797310984;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					return result;
				case 20:
					if (A_0 <= -200)
					{
						num2 = (short)299368455;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)117833738;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					num2 = (short)560005122;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_71;
				IL_10B:
				num2 = (short)2125791237;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_227:
				result = string.Format(global::IBtnWrapperLib.TMEXException.g("᱆㉈筊が㑎恐⹒ࡔ睖ౘ㕚㙜ㅞ๠ᑢ୤䝦౨ᥪὬnͰ卲ᩴᑶ᩸๺ོൾꖄꮊ랖ꪚ", a_), A_1, A_0);
				num2 = (short)1125711883;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_71:
			result = null;
			num2 = (short)1564213268;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000186C8 File Offset: 0x000168C8
		internal static string g(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1823846080 + A_1) + (global::System.IntPtr)62 + (global::System.IntPtr)61 + (global::System.IntPtr)99 + (global::System.IntPtr)99 + (global::System.IntPtr)55);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}

		// Token: 0x04000109 RID: 265
		private short a = -9999;

		// Token: 0x0400010A RID: 266
		private global::IBtnWrapperLib.TMEX_API_CODE b;
	}
}
