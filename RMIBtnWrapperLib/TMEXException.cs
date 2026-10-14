using System;

namespace RMIBtnWrapperLib
{
	// Token: 0x02000019 RID: 25
	public class TMEXException : global::System.ApplicationException
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00017B10 File Offset: 0x00015D10
		internal TMEXException()
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00017B30 File Offset: 0x00015D30
		internal TMEXException(string A_0) : base(A_0)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00017B50 File Offset: 0x00015D50
		internal TMEXException(string A_0, short A_1, global::RMIBtnWrapperLib.TMEX_API_CODE A_2) : this(A_0, A_1, A_2, null)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00017B68 File Offset: 0x00015D68
		internal TMEXException(string A_0, short A_1, global::RMIBtnWrapperLib.TMEX_API_CODE A_2, global::System.Exception A_3) : base(A_0, A_3)
		{
			this.a = A_1;
			this.b = A_2;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00017C4C File Offset: 0x00015E4C
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00017B98 File Offset: 0x00015D98
		public short ErrorCode
		{
			get
			{
				short num = (short)152346381;
				short num2 = num;
				num = (short)443916045;
				switch (num2 == num)
				{
				default:
				{
					num = (short)581566464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1944256513;
				if (num != 0)
				{
				}
				num = (short)768540672;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1734541313;
				if (num != 0)
				{
				}
				num = (short)1185873920;
				short num2 = num;
				num = (short)1301011817;
				short num3 = num;
				num = (short)85450089;
				switch (num3 == num)
				{
				}
				num = (short)860880896;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00017DB0 File Offset: 0x00015FB0
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00017D00 File Offset: 0x00015F00
		internal global::RMIBtnWrapperLib.TMEX_API_CODE MethodCode
		{
			get
			{
				short num = (short)1091066553;
				short num2 = num;
				num = (short)61823673;
				switch (num2 == num)
				{
				}
				num = (short)1871839232;
				short num3 = num;
				num = (short)305922049;
				if (num != 0)
				{
				}
				num = (short)1173487616;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)298057729;
				if (num != 0)
				{
				}
				num = (short)607256576;
				short num2 = num;
				num = (short)800051445;
				short num3 = num;
				num = (short)309383413;
				switch (num3 == num)
				{
				}
				num = (short)63635456;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00017E5C File Offset: 0x0001605C
		internal static void a(short A_0, global::RMIBtnWrapperLib.TMEX_API_CODE A_1, global::System.Exception A_2)
		{
			short num = (short)430919148;
			short num2 = num;
			num = (short)1268993516;
			switch (num2 == num)
			{
			}
			num = (short)126615552;
			short num3 = num;
			num = (short)572129281;
			if (num != 0)
			{
			}
			num = (short)1232142336;
			if (num != 0)
			{
			}
			throw new global::RMIBtnWrapperLib.TMEXException(global::RMIBtnWrapperLib.TMEXException.f(A_0, global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMExtendedStartSession), A_0, global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMExtendedStartSession, A_2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00017F14 File Offset: 0x00016114
		internal static string f(short A_0, global::RMIBtnWrapperLib.TMEX_API_CODE A_1)
		{
			int a_ = 13;
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
					return result;
				case 2:
				{
					num2 = (short)1493762049;
					if (num2 != 0)
					{
					}
					num2 = (short)1665400832;
					short num3 = num2;
					result = global::RMIBtnWrapperLib.TMEXException.g("\ude8aﾐﲒ練릘\ude9a캠톢蒤", a_);
					num2 = (short)981864408;
					short num4 = num2;
					num2 = (short)1854607320;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11E;
					default:
						num2 = (short)1034354688;
						if (num2 != 0)
						{
						}
						num2 = (short)572391424;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					return result;
				case 4:
					num2 = (short)1814233090;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					return result;
				case 6:
					return result;
				case 7:
					return result;
				case 8:
					switch (A_1)
					{
					case global::RMIBtnWrapperLib.TMEX_API_CODE.DLL_METHOD:
						return result;
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMExtendedStartSession:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMEndSession:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMValidSession:
						result = global::RMIBtnWrapperLib.TMEXException.e(A_0, A_1);
						num2 = (short)2032533509;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMFirstFile:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMNextFile:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMOpenFile:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMCreateFile:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMCloseFile:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMReadFile:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMWriteFile:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMDeleteFile:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMFormat:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMAttribute:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMReNameFile:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMChangeDirectory:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMDirectoryMR:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMCreateProgramJob:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMDoProgramJob:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMWriteAddFile:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMTerminateAddFile:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_GetVersion:
						result = global::RMIBtnWrapperLib.TMEXException.d(A_0, A_1);
						num2 = (short)1084030977;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMReadPacket:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMWritePacket:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMBlockIO:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMExtendedReadPage:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMProgramByte:
						result = global::RMIBtnWrapperLib.TMEXException.c(A_0, A_1);
						num2 = (short)1495859207;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMFirst:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMNext:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMAccess:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMStrongAccess:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMStrongAlarmAccess:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMOverAccess:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMRom:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMFirstAlarm:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMNextAlarm:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMFamilySearchSetup:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMSkipFamily:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMAutoOverDrive:
						result = global::RMIBtnWrapperLib.TMEXException.b(A_0, A_1);
						num2 = (short)1673068550;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMSetup:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMTouchByte:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMTouchReset:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMTouchBit:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMProgramPulse:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMClose:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMOneWireCom:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMOneWireLevel:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMGetTypeVersion:
					case global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMBlockStream:
						result = global::RMIBtnWrapperLib.TMEXException.a(A_0, A_1);
						num2 = (short)568262659;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11E;
				}
				goto IL_3D;
				IL_11E:
				num2 = (short)382926852;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_3D:
			result = null;
			num2 = (short)1668087816;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000181F0 File Offset: 0x000163F0
		private static string e(short A_0, global::RMIBtnWrapperLib.TMEX_API_CODE A_1)
		{
			int a_ = 12;
			short num = (short)1765867521;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_5D;
			}
			int num2;
			string result;
			for (;;)
			{
				IL_3B:
				switch (num2)
				{
				case 0:
				{
					num = (short)232674173;
					short num3 = num;
					num = (short)2048283517;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_92;
					default:
						num = (short)1616248832;
						if (num != 0)
						{
						}
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("톉\udf8bꂏ즓뚕쮗ﾙ즟춡쪣蚥욧얩\ud8ab躭욯펱\ud8b3\udfb5\udcb7钹", a_), A_0);
						num = (short)840957955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
				{
					num = (short)800325632;
					short num4 = num;
					if (A_0 == -200)
					{
						num = (short)1601765376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::RMIBtnWrapperLib.TMEXException.a(A_0, 'S');
					num = (short)1259732994;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return result;
				case 3:
					return result;
				case 4:
					goto IL_92;
				case 5:
					return result;
				case 6:
					if (A_0 != -201)
					{
						num = (short)587661316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("톉\udf8bꂏ즓뚕킗ﮙ瞧힟쎡횣쎥囹\udcab쮭펯\udbb1튳\udfb5\udbb7骹\ud8bb첽ꦿ듁ꇃ듅꓉ꏋ뫍듑믓ꏕ뛗뻙ﳛ뿝軟蛡쓣迥鯧쫩黫语臯蟱鷳蓵鷷黹틻", a_), A_0);
					num = (short)507772933;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_5D;
				IL_92:
				num = (short)1334312961;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_5D:
			result = null;
			num = (short)1535705094;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_3B;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000183DC File Offset: 0x000165DC
		private static string d(short A_0, global::RMIBtnWrapperLib.TMEX_API_CODE A_1)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_89;
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
					return result;
				case 3:
					return result;
				case 4:
					return result;
				case 5:
					result = global::RMIBtnWrapperLib.TMEXException.a(A_0, 'F');
					num2 = (short)476774426;
					num = (int)((global::System.IntPtr)num2);
					continue;
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
					num2 = (short)1875705856;
					short num3 = num2;
					switch (A_0)
					{
					case -24:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛쪝좟잡蒣첧캩잭\udcafힱ钳\udfb5쮷骹좻\udbbd늿꿁귃ꣅ꧇뻉꧋꫍돑뫓닕맙뷛냝軟跡郣웥諧迩쳫迭胯英釳飵鳷鿹飻\udefd瓿洁⨃", a_), A_0);
						num2 = (short)1626472464;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -23:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛쪝좟잡횣쎥袧쮩\udeab쮭邯\udcb1\udbb3\ud8b5閷ﾹ辿迁뛅꧇룉룋뷍뷑뫓곗닙맛ﻝ귟诡蟣铥蟧ꛩ跫胭탯雱至蓵釷铹鯻\udefd懿氁␃朅簇縉椋挍怏昑㐓戕眗㨙氛氝伟䔡嘣䜥䔧Щ", a_), A_0);
						num2 = (short)1218183183;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -22:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛\uda9d얟풡춣얥춧誩얫\uddad邯얱욳\udfb5첷\udfb9醻캽늿귁냃ꏅꯇ뻉꧋꫍ﻏ", a_), A_0);
						num2 = (short)1340604419;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -21:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛쪝좟잡횣쎥袧쎩\udfab躭\udeaf\uddb1钳욵쪷햹\udbbb첽ꆿ꿁곅Ꟈ꣉뷍꓏돑ꛓꋕ뷗뻙", a_), A_0);
						num2 = (short)711065601;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -20:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛펝솟\udaa1춣쮥\udda7잩貫쪭햯슱삳\udeb5颷햹\udabb麽뗅뷇꣉꫍맏ꃑ뇓뗕곗뗙껛럝藟釡쓣迥鯧쫩黫语釯釱鳳鏵鳷퓹", a_), A_0);
						num2 = (short)678297621;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -19:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛\uda9d즟킡솣얥\udca7얩\udeab힭邯\udfb1솳억첷骹\udebb\udbbdꟁ꧃뛅볇돉뫍뿏냓돕듗뿙꣛믝샟诡郣죥", a_), A_0);
						num2 = (short)522125336;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -18:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛춝킟잡잣쾥캧쎩즫쪭邯횱\uddb3쒵\uddb7\ud9b9좻톽늿믁꿅믇ꗋꃍꛏ돑룓뿕볗", a_), A_0);
						num2 = (short)336265236;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -17:
					{
						num2 = (short)679193907;
						short num4 = num2;
						num2 = (short)588033331;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						default:
							num2 = (short)437977088;
							if (num2 != 0)
							{
							}
							result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛\udb9d튟킡쮣풥袧쎩슫躭쒯\udab1톳隵펹\udfbb첽꾿軁ꗃꣅ臋ꟍ돏ꃑ믓髕맗듙ﳛ돝臟鯡쓣裥蟧黩쳫賭闯틱蟳鏵賷迹賻\udefd痿焁洃栅漇⨉堋䌍䌏眑怓挕栗㐙", a_), A_0);
							num2 = (short)1067384857;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case -16:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛\ud89d즟캡솣蚥삧쮩슫쪭\udcafힱ钳튵ힷ\udfb9쾻麽꺿귁냃귇닉ꗋ뷍꓏ﳑ", a_), A_0);
						num2 = (short)2003632139;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -15:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛쪝튟\udba1춣좥쾧誩\ud8ab솭邯횱톳\udab5\uddb7캹\ud9bb麽늿ꟁꗃꋅꗉꋋꋍꧏ닓뿕듗뿙", a_), A_0);
						num2 = (short)2034761741;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -14:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛힝첟캡솣솥즧용貫좭\ud9af\udeb1톳馵\udcb7펹캻\udbbdꎿ뛁ꯃ듅뇇ꋋ꿍뷏럑䀘", a_), A_0);
						num2 = (short)35979272;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -13:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛\ud89d햟첡잣튥솧얩슫躭\udeaf\uddb1삳隵쮷쾹첻캽꾿냁냃ꏅ곇", a_), A_0);
						num2 = (short)1639645193;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -12:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛쪝튟\udba1춣좥쾧誩\ud8ab솭邯얱욳\udfb5첷\udfb9鲻\udfbd냁ꇃꟅ곇꫋ꟍ볏럑뻕맗듙룛닝藟쳡", a_), A_0);
						num2 = (short)103415825;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -11:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛증튟쮡킣쎥袧쾩\udeab\udcad\udfaf삱颳隵좷\udbb9캻쪽꿁ꗃ뿅ꋉ귋룍뗏뇓껕꣗동껛믝蓟쳡", a_), A_0);
						num2 = (short)146931726;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -10:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛킝쾟횡蒣쎥욧얩\ud9ab즭\ud8af銱욳\ud9b5ힷힹ鲻톽꺿ꃃꏅ뻇ꏉ꿋ꯍꛑ믓꿗꣙뗛ꫝ藟쳡", a_), A_0);
						num2 = (short)829882372;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -9:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛쪝튟\udba1춣좥쾧誩\ud8ab솭邯삱톳ힵ\udcb7骹\uddbb麽랿냁귃닅귇꫋ꟍ볏럑뻕맗듙룛닝藟쳡", a_), A_0);
						num2 = (short)863633415;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -8:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛\ud99d즟풡솣좥袧첩얫슭햯銱\udcb3ힵ횷\udeb9킻\udbbdꯁ럃ꛇꗉ룋뇏ꇑꟓ뿕뿗듙맛뫝샟菡쓣胥臧蛩觫샭", a_), A_0);
						num2 = (short)666632192;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -7:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛\ud89d즟캡솣蚥\udfa7쎩\ud8ab욭邯솱쒳펵\udbb7펹\udabbힽꖿꛁꣅ꧇Ꟊ꧋뇏뻑ꛓ돕맗뻙ꗛﻝ藟髡跣闥鳧駩싫", a_), A_0);
						num2 = (short)993984531;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -6:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛\ud89d즟캡솣蚥\udba7\udaa9즫춭\ud9af풱\uddb3펵\udcb7骹햻춽곁ꯃ닅ꏉꋋ꓏뫑뇓믗꿙껛곝藟賡郣웥賧菩黫语鏯蛱鯳蓵臷퓹", a_), A_0);
						num2 = (short)1936523270;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -5:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛\udf9d첟캡蒣삥솧용즫躭\ud8af펱\udab3튵풷\udfb9쾻麽ꆿ냁ꇃꇇ꓉믍ꏏ럑䀘", a_), A_0);
						num2 = (short)1844576258;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -4:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛\udc9d햟쒡슣쎥\udaa7誩얫\uddad邯솱\ud9b3ힵ풷횹\ud9bb첽뛁곃Ʂꛇ룋ꛍ뗏닓뿕듗뿙ﳛꫝ迟싡難菥觧軩싫", a_), A_0);
						num2 = (short)215875602;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -3:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛\ud89d즟캡솣覥첧쎩\udeab쮭펯욱\udbb3쒵솷骹캻\udbbdꆿꛁꏅ뫇룉ꏋ볍ﻏ", a_), A_0);
						num2 = (short)1376124940;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -2:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛증튟춡쪣솥袧\udea9햫\udead햯銱\udbb3킵颷\udeb9\ud9bb좽ꦿꇁꇃ껇ꗉ뻋ꏏꋑ뇓뗕뇗볙뗛믝蓟싡诣雥跧飩跫髭駯鷱髳\ud8f5", a_), A_0);
						num2 = (short)895614999;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -1:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("쮏풑ꚕ잙벛킝쾟芡삣쎥\udea7쎩쾫쮭邯풱\udbb3쎵횷\udeb9鲻톽꺿觃꿅ꯇ룉ꏋ苍뇏병䀘", a_), A_0);
						num2 = (short)1294204950;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)1728118811;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 11:
					return result;
				case 12:
					return result;
				case 13:
					return result;
				case 14:
					return result;
				case 15:
					return result;
				case 16:
					return result;
				case 17:
					return result;
				case 18:
					return result;
				case 19:
					return result;
				case 20:
					goto IL_183;
				case 21:
					return result;
				case 22:
					return result;
				case 23:
					return result;
				case 24:
					return result;
				case 25:
					return result;
				case 26:
					return result;
				case 27:
					num2 = (short)1238171653;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_89;
			}
			IL_183:
			num2 = (short)2054881281;
			if (num2 != 0)
			{
			}
			return result;
			IL_89:
			result = null;
			num2 = (short)15138826;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00018B08 File Offset: 0x00016D08
		private static string c(short A_0, global::RMIBtnWrapperLib.TMEX_API_CODE A_1)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_49;
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
					goto IL_142;
				case 1:
					goto IL_10C;
				case 2:
					goto IL_218;
				case 3:
				{
					num2 = (short)108134400;
					short num3 = num2;
					num2 = (short)1413808136;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					num2 = (short)951898670;
					short num4 = num2;
					num2 = (short)838455854;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_21D;
					default:
						goto IL_318;
					}
					break;
				}
				case 5:
					goto IL_23E;
				case 6:
					goto IL_2AC;
				case 7:
					goto IL_274;
				case 8:
					num2 = (short)2087780353;
					if (num2 != 0)
					{
					}
					goto IL_21D;
				case 9:
					goto IL_D6;
				case 10:
					goto IL_178;
				case 11:
					switch (A_0)
					{
					case -11:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("╽푿女뒃ﮅ햇ꪉ좋ﮑ뢗蓮ﶛ캟춡킣蚥쪧쾩貫쎭\udfaf횱\uddb3킵톷\udfb9\ud8bb邽", a_), A_0);
						num2 = (short)1973551114;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -10:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("╽푿女뒃ﮅ햇ꪉ\udc8b뒓ﶗ劣肟킡솣장첧誩얫\uddad邯삱톳튵톷좹\ud9bb\uddbd뒿ꟁꃃ", a_), A_0);
						num2 = (short)1990656009;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -9:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("╽푿女뒃ﮅ햇ꪉ쪋ﮍﺏﾕ벛쾟횡蒣향\udda7\udaa9\udcab솭슯욱톳튵颷햹튻麽뒿꫁귃뗅껉꧋룍맏뇑뇓", a_), A_0);
						num2 = (short)128712706;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -8:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("╽푿女뒃ﮅ햇ꪉ캋ﾏﾓ뚕ﶛ펟쒡솣풥袧\udea9쎫솭邯킱\uddb3통隷", a_), A_0);
						num2 = (short)658767873;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -7:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("╽푿女뒃ﮅ햇ꪉ좋ﮑ뢗肟쒡쮣펥욧캩芫", a_), A_0);
						num2 = (short)239534084;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -6:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("╽푿女뒃ﮅ햇ꪉ\udc8b撚뢗肟캡얣풥쾧쾩芫", a_), A_0);
						num2 = (short)2129199111;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -5:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("╽푿女뒃ﮅ햇ꪉ\udc8b撚뢗ﶛ잟잡횣蚥\udca7슩춫삭邯킱솳킵\udeb7\udfb9캻邽", a_), A_0);
						num2 = (short)1124466694;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -4:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("╽푿女뒃ﮅ햇ꪉ즋ﲍ﶑뚕ﾙﶛ瞧즟첡쎣蚥\ud8a7쮩쾫얭햯욱骳", a_), A_0);
						num2 = (short)521404416;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)702087171;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				goto IL_49;
				IL_21D:
				result = global::RMIBtnWrapperLib.TMEXException.a(A_0, 'T');
				num2 = (short)347799557;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D6:
			IL_10C:
			IL_142:
			IL_178:
			IL_218:
			IL_23E:
			IL_274:
			IL_2AC:
			return result;
			IL_318:
			num2 = (short)1063190528;
			if (num2 != 0)
			{
			}
			return result;
			IL_49:
			result = null;
			num2 = (short)247070731;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00018E48 File Offset: 0x00017048
		private static string b(short A_0, global::RMIBtnWrapperLib.TMEX_API_CODE A_1)
		{
			int a_ = 9;
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
					result = global::RMIBtnWrapperLib.TMEXException.g("펆쒈춊ﾒ쒖ﲘ漢ﲞ즠삤펦\udca8\udbaa鞬辮ﶲ薴馸펼즾ꃀ꿂계ꏆ跊곌ꋎ룐뿒곔跘ꋚ규뫞쿠", a_);
					num2 = (short)2005204992;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (A_0 == 0)
					{
						goto IL_173;
					}
					goto IL_DE;
				case 3:
				{
					num2 = (short)1412956160;
					short num3 = num2;
					num2 = (short)1500310890;
					short num4 = num2;
					num2 = (short)2067524970;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_173;
					default:
						num2 = (short)76742656;
						if (num2 != 0)
						{
						}
						num2 = (short)1619132417;
						if (num2 != 0)
						{
						}
						num2 = (short)698089474;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					return result;
				case 5:
					if (A_1 == global::RMIBtnWrapperLib.TMEX_API_CODE.TMEX_TMFamilySearchSetup)
					{
						num2 = (short)1078591491;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DE;
				}
				goto IL_31;
				IL_DE:
				result = global::RMIBtnWrapperLib.TMEXException.a(A_0, 'N');
				num2 = (short)37748740;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_173:
				num2 = (short)1711210497;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_31:
			result = null;
			num2 = (short)438304773;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00018FE8 File Offset: 0x000171E8
		private static string a(short A_0, global::RMIBtnWrapperLib.TMEX_API_CODE A_1)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_35;
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
				{
					num2 = (short)2142281826;
					short num3 = num2;
					num2 = (short)476487778;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_67;
					default:
						num2 = (short)181862400;
						if (num2 != 0)
						{
						}
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("\ud981첃ﶅ뢇톋꺍횏ﶓ歹鍊뺝풟춡蒣얥잧잩솫\udbad\udeaf\udbb1ힳힵ첷\udfb9鲻즽ꦿ뛁곃ꃇꯉ뻋꫍꟏돑ꛓ돕믙룛뿝郟雡臣铥웧", a_), A_0);
						num2 = (short)1862402051;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (A_0 == -12)
					{
						num2 = (short)390725632;
						short num4 = num2;
						num2 = (short)1357709312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::RMIBtnWrapperLib.TMEXException.a(A_0, 'H');
					num2 = (short)2000945154;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_1A6;
				case 3:
					goto IL_11F;
				case 4:
					goto IL_67;
				case 5:
					goto IL_9D;
				case 6:
					if (A_0 != -13)
					{
						num2 = (short)1275133956;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("\ud981첃ﶅ뢇톋꺍톏ﲑ뒓즟송춣튥춧캩貫쮭욯ힱ\udab3습颷햹\udfbb\uddbd떿냁뛃ꏅ곇ꏋꃍꛑ볓돕觝觟郡臣죥", a_), A_0);
					num2 = (short)188743685;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_35;
				IL_67:
				num2 = (short)1675624449;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_9D:
			IL_11F:
			return result;
			IL_1A6:
			num2 = (short)530513921;
			if (num2 != 0)
			{
			}
			return result;
			IL_35:
			result = null;
			num2 = (short)857669638;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000191C8 File Offset: 0x000173C8
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
				{
					if (A_0 != -200)
					{
						num2 = (short)9175043;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)397618830;
					short num3 = num2;
					num2 = (short)1628515982;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)2102263808;
						if (num2 != 0)
						{
						}
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("힋ꂏꞕ잙벛춝얟톡힣쾥잧쒩貫삭\udfaf욱钳삵\ud9b7횹햻\udabd", a_), A_1, A_0);
						num2 = (short)569835539;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_E7;
				case 2:
					if (A_0 != -13)
					{
						num2 = (short)1142882308;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("힋ꂏꞕ잙벛쮝캟톡쮣쪥솧즩얫\udaad햯횱钳펵캷\udfb9튻쪽귁ꟃꗅ뷇룉뻋ꯍ듏믓룕꧝觟郡臣죥", a_), A_1, A_0);
					num2 = (short)55640082;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)565248017;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)2107310089;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					return result;
				case 6:
				{
					num2 = (short)1043136512;
					short num4 = num2;
					num2 = (short)607780876;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					goto IL_125;
				case 8:
					num2 = (short)1314586634;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (A_0 != -12)
					{
						num2 = (short)109379592;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("힋ꂏꞕ잙벛쮝캟쎡욣쪥춧誩\ud8ab솭邯톱\udbb3\udbb5햷쾹튻ힽꎿꏁ냃ꏅ뷉ꗋ뫍룏볓럕꫗뻙ꯛ뿝鋟蟡쓣蟥賧诩鳫髭闯胱\udaf3", a_), A_1, A_0);
					num2 = (short)913178625;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					switch (A_0)
					{
					case -3:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("힋ꂏꞕ잙벛\ud89d햟첡잣튥솧얩슫躭\udeaf\uddb1삳隵쮷쾹첻캽꾿냁냃ꏅ곇", a_), A_1, A_0);
						num2 = (short)398852107;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -2:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("힋ꂏꞕ잙벛캝쾟킡킣蚥첧얩즫\uddad邯\udcb1\udbb3습颷\udfb9쒻ힽ뎿뛁", a_), A_1, A_0);
						num2 = (short)351993863;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case -1:
						result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("힋ꂏꞕ잙벛캝쾟킡킣蚥솧\ud9a9貫삭\udfaf욱钳\udfb5횷펹좻ힽꆿ껁귃볅귇껉", a_), A_1, A_0);
						num2 = (short)1348075525;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)270336006;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 11:
					goto IL_247;
				case 12:
					goto IL_24C;
				case 13:
					if (A_0 != -201)
					{
						num2 = (short)1610940432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("힋ꂏꞕ잙벛횝솟킡삣톥즧\ud8a9즫躭슱톳햵톷\udcb9햻\uddbdꛁ뛃꿅뻇꿉뻋뻏뷑ꃓ뻗뗙꧛냝蓟싡藣裥賧쫩藫鷭탯胱釳蟵跷鏹軻鯽擿Ⰱ", a_), A_1, A_0);
					num2 = (short)466550799;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					num2 = (short)1796538381;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					return result;
				case 16:
					num2 = (short)997195776;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					goto IL_24C;
				case 18:
					return result;
				case 19:
					goto IL_1CB;
				case 20:
					goto IL_284;
				case 21:
					if (A_0 <= -200)
					{
						num2 = (short)605093902;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)781582338;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_71;
				IL_24C:
				result = string.Format(global::RMIBtnWrapperLib.TMEXException.g("힋ꂏꞕ잙벛쮝캟즡쪣즥\udfa7쒩貫쮭슯삱\udbb3쒵颷햹\udfbb\uddbd떿냁뛃ꏅ곇ꗋꃍ뻑뗓꿕뷗꣙ﳛꗝ퇟鿡", a_), A_1, A_0);
				num2 = (short)1178796052;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E7:
			IL_125:
			IL_1CB:
			IL_247:
			return result;
			IL_284:
			num2 = (short)1710882817;
			if (num2 != 0)
			{
			}
			return result;
			IL_71:
			result = null;
			num2 = (short)205127701;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0001967C File Offset: 0x0001787C
		internal static string g(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1610890414 + A_1) + (global::System.IntPtr)74 + (global::System.IntPtr)22 + (global::System.IntPtr)47 + (global::System.IntPtr)48 + (global::System.IntPtr)16);
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

		// Token: 0x04000102 RID: 258
		private short a = -9999;

		// Token: 0x04000103 RID: 259
		private global::RMIBtnWrapperLib.TMEX_API_CODE b;
	}
}
