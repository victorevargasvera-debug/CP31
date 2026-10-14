using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000056 RID: 86
	public class PackageHandler
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000288CC File Offset: 0x00026ACC
		// (set) Token: 0x0600020D RID: 525 RVA: 0x0002897C File Offset: 0x00026B7C
		public string Title
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1984743672;
				short num2 = num;
				num = (short)963889400;
				switch (num2 == num)
				{
				}
				num = (short)1346502657;
				if (num != 0)
				{
				}
				num = (short)2130313216;
				short num3 = num;
				num = (short)197197824;
				if (num != 0)
				{
				}
				return this.u;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)638380859;
				short num2 = num;
				num = (short)1292823355;
				switch (num2 == num)
				{
				}
				num = (short)2068840449;
				if (num != 0)
				{
				}
				num = (short)884015104;
				short num3 = num;
				num = (short)2096955392;
				if (num != 0)
				{
				}
				this.u = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00028A2C File Offset: 0x00026C2C
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00028ADC File Offset: 0x00026CDC
		public string Type
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)864739950;
				short num2 = num;
				num = (short)1149493870;
				switch (num2 == num)
				{
				}
				num = (short)1162084353;
				if (num != 0)
				{
				}
				num = (short)1688010752;
				short num3 = num;
				num = (short)1032912896;
				if (num != 0)
				{
				}
				return this.v;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)156715773;
				short num2 = num;
				num = (short)104286973;
				switch (num2 == num)
				{
				}
				num = (short)906362880;
				if (num != 0)
				{
				}
				num = (short)703070208;
				short num3 = num;
				num = (short)1703215105;
				if (num != 0)
				{
				}
				this.v = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00028B90 File Offset: 0x00026D90
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00028C40 File Offset: 0x00026E40
		public string RDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1716339111;
				short num2 = num;
				num = (short)1237860775;
				switch (num2 == num)
				{
				}
				num = (short)1800667137;
				if (num != 0)
				{
				}
				num = (short)1051262976;
				short num3 = num;
				num = (short)944963584;
				if (num != 0)
				{
				}
				return this.w;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)291123097;
				short num2 = num;
				num = (short)572796825;
				switch (num2 == num)
				{
				}
				num = (short)1065549825;
				if (num != 0)
				{
				}
				num = (short)289406976;
				short num3 = num;
				num = (short)1518927872;
				if (num != 0)
				{
				}
				this.w = value;
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00028CF0 File Offset: 0x00026EF0
		public PackageHandler(string title, string type, string rDate)
		{
			this.Title = title;
			this.Type = type;
			this.RDate = rDate;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00028D18 File Offset: 0x00026F18
		public bool IsProperPackage()
		{
			short num = (short)1922760704;
			short num2 = num;
			num = (short)844431362;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)996212739;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)657925677;
					short num4 = num;
					num = (short)1354769965;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)628293632;
						if (num != 0)
						{
						}
						if (!this.g())
						{
							return false;
						}
						break;
					}
					num = (short)1524367360;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 3:
					num = (short)325648385;
					if (num != 0)
					{
					}
					if (this.a())
					{
						num = (short)1193607173;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
					num = (short)302120961;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_E4;
				}
				IL_66:
				if (!this.g())
				{
					break;
				}
				num = (short)1929510916;
				num3 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_E4:
			return true;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00028E94 File Offset: 0x00027094
		private bool g()
		{
			short num = (short)1964572684;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.b())
					{
						num = (short)1045561345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D6;
				case 1:
					num = (short)1513750542;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)539951115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_25B;
				case 4:
					if (this.c())
					{
						num = (short)1653342209;
						if (num != 0)
						{
						}
						num = (short)2041380866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					goto IL_D6;
				case 6:
					if (this.f() < 12)
					{
						num = (short)1199964173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 7:
					num = (short)1175191558;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)927531018;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (this.d())
					{
						num = (short)708902919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25D;
				case 10:
					if (this.f() < 15)
					{
						num = (short)1936785423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 11:
					if (this.f() >= 7)
					{
						num = (short)1952251907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 13:
					goto IL_25D;
				case 14:
				{
					num = (short)1884553216;
					short num3 = num;
					if (this.f() < 20)
					{
						num = (short)546373637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 15:
					goto IL_1A3;
				}
				IL_64:
				num = (short)47475577;
				short num4 = num;
				num = (short)1171221369;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					num = (short)177537024;
					if (num != 0)
					{
					}
					if (this.e())
					{
						num = (short)1101463560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A3;
				}
				IL_D6:
				num = (short)1300365316;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A3:
				num = (short)968556553;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_25D:
				num = (short)609288192;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_25B:
			return true;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0002917C File Offset: 0x0002737C
		private int f()
		{
			short num = (short)567869443;
			int num2 = (int)((global::System.IntPtr)num);
			int result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)961750713;
					short num3 = num;
					num = (short)1906910905;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10B;
					default:
						goto IL_17F;
					}
					break;
				}
				case 1:
					int.TryParse(string.Concat<char>(this.Title.SkipWhile(new global::System.Func<char, bool>(global::Motorola.Common.Communication.CommonUtil.PackageHandler.<>c.<>9.a)).Take(3)).TrimStart(new char[]
					{
						'_'
					}), out result);
					goto IL_10B;
				case 2:
					num = (short)916258817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)243335168;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				}
				case 4:
					goto IL_DE;
				}
				IL_62:
				if (this.Title.Contains('_'))
				{
					num = (short)602079234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				int.TryParse(string.Concat<char>(this.Title.Take(2)), out result);
				num = (short)624427012;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10B:
				num = (short)16252929;
				if (num != 0)
				{
				}
				num = (short)609484800;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DE:
			return result;
			IL_17F:
			num = (short)1894776832;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00029340 File Offset: 0x00027540
		private bool e()
		{
			int a_ = 12;
			short num = (short)1859715074;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)620625921;
					if (num != 0)
					{
					}
					if (!this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䀏猑易眕䨗缙稛氝䔟儡䰣", a_)))
					{
						num = (short)1151336463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					if (!this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("吏眑礓礕気甙", a_)))
					{
						num = (short)278986766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_6E;
					}
					continue;
				case 3:
					if (!this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䀏猑易眕簗猙漛笝", a_)))
					{
						num = (short)1029963780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					num = (short)499253248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("崏猑砓戕礗", a_)))
					{
						num = (short)1054539785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					goto IL_1BC;
				case 7:
				{
					if (this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("崏猑砓䐕紗簙減笝匟䨡", a_)))
					{
						return true;
					}
					num = (short)483447757;
					short num3 = num;
					num = (short)782226381;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_229;
					default:
						num = (short)1688141824;
						if (num != 0)
						{
						}
						num = (short)68419595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
				{
					num = (short)1550647296;
					short num4 = num;
					if (!this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䀏帑紓焕瀗渙䰛爝唟儡", a_)))
					{
						num = (short)1623326732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 9:
					num = (short)1221132295;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_229;
				case 11:
					num = (short)1928462344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)1548222465;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("小笑猓縕気", a_)))
					{
						num = (short)1374879750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 14:
					goto IL_2C9;
				case 15:
					num = (short)1899560965;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6E:
				if (this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䀏紑易戕礗砙瀛笝", a_)))
				{
					num = (short)652738570;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1BC:
				num = (short)2029256707;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_229:
				num = (short)2055208973;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2C9:
			return this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("吏眑礓礕気甙丛笝䘟倡䄣唥䀧", a_));
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000296E4 File Offset: 0x000278E4
		private bool d()
		{
			int a_ = 17;
			short num = (short)170262530;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)702414849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (!this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("夔縖縘猚検", a_)))
					{
						num = (short)889389057;
						if (num != 0)
						{
						}
						num = (short)1128464389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 3:
					if (!this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䔔瘖欘稚儜瘞䘠䬢儤", a_)))
					{
						num = (short)928382980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					goto IL_107;
				case 5:
				{
					num = (short)620750600;
					short num3 = num;
					num = (short)1688987400;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_107;
					default:
						num = (short)1425342464;
						if (num != 0)
						{
						}
						goto IL_BA;
					}
					break;
				}
				}
				IL_46:
				num = (short)643891200;
				short num4 = num;
				if (this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䔔砖欘漚簜紞䴠䘢", a_)))
				{
					num = (short)542310400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BA:
				num = (short)251330563;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_107:
			return this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䄔砖眘簚簜", a_));
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000298C0 File Offset: 0x00027AC0
		private bool c()
		{
			int a_ = 15;
			short num = (short)2048589623;
			short num2 = num;
			num = (short)2095185719;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F9:
				num = (short)460259330;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1239351296;
				if (num != 0)
				{
				}
				num = (short)1726676992;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_87;
					}
					continue;
				case 1:
					goto IL_DD;
				case 2:
					if (!this.Type.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("帒娔䌖嘘会伜崞渠̢ᜤदᤨ", a_)))
					{
						num = (short)1180368899;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					goto IL_143;
				}
				IL_87:
				if (!this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䄒瀔朖簘稚検稞匠", a_)))
				{
					goto IL_DF;
				}
				num = (short)1615200257;
				if (num != 0)
				{
				}
				num = (short)101777409;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_DD:
			goto IL_F9;
			IL_DF:
			return this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("儒琔编砘瘚簜", a_));
			IL_143:
			num = (short)1869807616;
			short num4 = num;
			goto IL_DF;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00029A40 File Offset: 0x00027C40
		private bool b()
		{
			int a_ = 11;
			short num = (short)755433474;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1334902785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.Type.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䈎帐䜒娔䌖䬘多刜㼞ጠഢᔤ", a_)))
					{
						num = (short)496041989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 3:
					if (!this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䈎瀐朒朔縖愘", a_)))
					{
						num = (short)1200029700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					goto IL_109;
				case 5:
				{
					num = (short)937164801;
					if (num != 0)
					{
					}
					num = (short)869084171;
					short num3 = num;
					num = (short)854993931;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_109;
					default:
						num = (short)2077360128;
						if (num != 0)
						{
						}
						goto IL_BA;
					}
					break;
				}
				}
				IL_46:
				num = (short)1169031168;
				short num4 = num;
				if (this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("崎琐挒瀔瘖洘縚漜", a_)))
				{
					num = (short)1673330688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BA:
				num = (short)825688067;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_109:
			return this.Title.Contains(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䴎瀐紒焔縖洘", a_));
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00029C1C File Offset: 0x00027E1C
		private bool a()
		{
			short num = (short)345557857;
			short num2 = num;
			num = (short)1561512801;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)376111104;
				if (num != 0)
				{
				}
				num = (short)2068905984;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					case 1:
						num = (short)526909442;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (num4 >= 0)
						{
							num = (short)1333657603;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						goto IL_139;
					}
					IL_7E:
					num = (short)904265728;
					short num5 = num;
					num = (short)529268737;
					if (num != 0)
					{
					}
					if (!int.TryParse(this.RDate, out num4))
					{
						return false;
					}
					num = (short)1462501377;
					num3 = (int)((global::System.IntPtr)num);
				}
				return false;
			}
			}
			IL_139:
			return num4 <= 255;
		}

		// Token: 0x040001FF RID: 511
		private const string a = "Light";

		// Token: 0x04000200 RID: 512
		private const string b = "ParaLight";

		// Token: 0x04000201 RID: 513
		private const string c = "Tonga";

		// Token: 0x04000202 RID: 514
		private const string d = "ParaRefresh";

		// Token: 0x04000203 RID: 515
		private const string e = "Malta";

		// Token: 0x04000204 RID: 516
		private const string f = "MalRefresh";

		// Token: 0x04000205 RID: 517
		private const string g = "PLightPlus";

		// Token: 0x04000206 RID: 518
		private const string h = "Demoto";

		// Token: 0x04000207 RID: 519
		private const string i = "DemotoRefresh";

		// Token: 0x04000208 RID: 520
		private const string j = "Paradise";

		// Token: 0x04000209 RID: 521
		private const string k = "Repeater";

		// Token: 0x0400020A RID: 522
		private const string l = "MOTOTRBO 2.0";

		// Token: 0x0400020B RID: 523
		private const string m = "Portable";

		// Token: 0x0400020C RID: 524
		private const string n = "Bahama";

		// Token: 0x0400020D RID: 525
		private const string o = "Matrix";

		// Token: 0x0400020E RID: 526
		private const string p = "Bandit";

		// Token: 0x0400020F RID: 527
		private const int q = 15;

		// Token: 0x04000210 RID: 528
		private const int r = 12;

		// Token: 0x04000211 RID: 529
		private const int s = 20;

		// Token: 0x04000212 RID: 530
		private const int t = 7;

		// Token: 0x04000213 RID: 531
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string u;

		// Token: 0x04000214 RID: 532
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string v;

		// Token: 0x04000215 RID: 533
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string w;
	}
}
