using System;
using System.IO;
using Motorola.Security.SamlCommonUtility.DMHttpClients;

namespace Motorola.Security.SamlCommonUtility
{
	// Token: 0x02000013 RID: 19
	public class EnvironmentUtility
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00004E70 File Offset: 0x00003070
		public static string GetCurrentStorePath(string pac, string currentUserType)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_5D;
			}
			int num;
			short num2;
			string path;
			string text;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (currentUserType.Equals(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("킪鮬鲮薲薴視袺邼誾﯂﷈﯊﯌﷎ﳐꋠꗢ\udde4ꛦ꿨\udfea\udaec귮짰쟲裴", a_)))
					{
						num2 = (short)494862345;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1471021057;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1648014593;
					short num3 = num2;
					num2 = (short)398308609;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)245628928;
						if (num2 != 0)
						{
						}
						if (!(pac == global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("ﺬﮮﲲ", a_)))
						{
							num2 = (short)1925120005;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1CB;
					}
					break;
				}
				case 2:
					num2 = (short)1045037068;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					text = global::System.IO.Path.Combine(path, global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("슬슮\udcb0\udcb2\udbb4", a_), global::Motorola.Security.SamlCommonUtility.EnvironmentUtility.a(pac), global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("첬\udbae킰솴\ud8b6쮸\udaba\udabc\udabe", a_));
					num2 = (short)1839529990;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return text;
				case 5:
					num2 = (short)1998192655;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (!global::System.IO.File.Exists(text))
					{
						num2 = (short)1836843015;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 7:
					text = global::System.IO.Path.Combine(path, global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("슬슮\udcb0\udcb2\udbb4", a_), global::Motorola.Security.SamlCommonUtility.EnvironmentUtility.a(), global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("첬\udbae킰솴\ud8b6쮸\udaba\udabc\udabe", a_));
					num2 = (short)1489567755;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)826671118;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					text = global::System.IO.Path.Combine(path, global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("슬슮\udcb0\udcb2\udbb4賀迄꣆ꯈ鷌뷎뻐냒냔ꓖ꫘듚꿜", a_), global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("첬\udbae킰솴\ud8b6쮸\udaba\udabc\udabe", a_));
					num2 = (short)1916600336;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (currentUserType.Equals(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("킪讲ﲸ躺邼趾燎藂﷈﯎ﳐ鋒铖黜틠\udbe2\udde4ꇦ골꣪꯬ꧮ쟰닲裴", a_)))
					{
						num2 = (short)741081091;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)393740288;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					return text;
				case 12:
					return text;
				case 13:
					return text;
				case 14:
					if (!(pac == global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("ﮪﶮ", a_)))
					{
						num2 = (short)15269890;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text = global::System.IO.Path.Combine(path, global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("ﮮﺰ鮺ﺼ鋀", a_), global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("첬\udbae킰솴\ud8b6쮸\udaba\udabc\udabe", a_));
					num2 = (short)743637005;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (!(pac == global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("寧횲잴솶\udcb8즺", a_)))
					{
						num2 = (short)459407368;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1CB;
				case 16:
					return text;
				}
				goto IL_5D;
				IL_1CB:
				text = global::System.IO.Path.Combine(path, global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("슬슮\udcb0\udcb2\udbb4賀郂ꃄ뗆뿈껊뿌", a_), global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("첬\udbae킰솴\ud8b6쮸\udaba\udabc\udabe", a_));
				num2 = (short)108527620;
				num = (int)((global::System.IntPtr)num2);
			}
			return text;
			IL_5D:
			num2 = (short)1618739201;
			if (num2 != 0)
			{
			}
			path = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData), global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("슬\udbae\udeb0솲\udab4\udbb6\ud8b8", a_));
			text = string.Empty;
			num2 = (short)1637089280;
			short num4 = num2;
			num2 = (short)1377107978;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000529C File Offset: 0x0000349C
		public static string[] GetUserTypeList()
		{
			int a_ = 14;
			short num = (short)35221099;
			short num2 = num;
			num = (short)485781099;
			switch (num2 == num)
			{
			}
			num = (short)1827274753;
			if (num != 0)
			{
			}
			num = (short)1457913856;
			if (num != 0)
			{
			}
			num = (short)1643839488;
			short num3 = num;
			return new string[]
			{
				global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("첶膸辺覼趾胀蛂胄ﻆ裊﯌ﻎﻒ釖鳘駚퓠퓢틤쫦\udbe8틪\udaec\ud8ee닰쫲췴듶쿸뿺룼췾簀", a_),
				global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("첶ﾸ了螾藀苂胄流觎ﻒ點ퟠꃢ폤쫦ꫨ\udaea\udeecퟮ짰뗲냴듶뿸뷺쯼뻾簀", a_),
				global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("첶辸袺﮼覾藂蛄ﻊￌﻒ폠탢헤쫦\udee8폪껬ꧮ짰닲돴쏶컸맺염쯾簀", a_),
				global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("첶覸ﶺ誼袾﷊ￌﻒ鷞퓠ꇢꇤ쫦꿨귪\udaec\uddee뗰쓲쓴쇶죸뿺염맾簀", a_),
				global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("첶袸ﺺﲼ螾蛆頻﯎郐ﻒ\ud9e0폢ꓤ쫦\udee8\udbea꯬\udbee쟰싲싴뇶쳸죺룼짾簀", a_),
				global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("첶肸趼达苀臂蛄﯊賌硫ﻒ雖鷞틠\udae2폤쫦ꫨ폪꯬훮쟰쇲쓴쿶본맺짼췾簀", a_),
				global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("첶貸誺誼袾胀ﷄ﷊軌ﻒ闖駚點ꗠ퓢탤쫦\udee8꣪\ud8ec\ud8ee닰뗲쟴듶쳸췺볼쳾簀", a_),
				global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("첶袸辺躾蟀ￆ觊ﻎﻒ闖ꋠ탢꟤쫦꿨\udeeaꧬ\udfee돰쓲쟴웶쫸쳺뿼죾簀", a_)
			};
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000053DC File Offset: 0x000035DC
		public static string GetClientTypeFromCurrentUserTypeName(string name)
		{
			int a_ = 17;
			short num = (short)1615659015;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_26D;
				case 1:
					if (name.Contains(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("솹誻趽蚿胅诇柳﯍ﯕ췟\udbe1훣헥\ud8e7쟩\udbeb훭돯등쳳럵뻷컹쯻볽㣿㘁礃", a_)))
					{
						num = (short)714539008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)28835850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_312;
				case 3:
				{
					num = (short)973799424;
					short num3 = num;
					if (name.Contains(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("솹趻誽薿苃難賍ﯕ飙췟\udae1꟣헥ꫧ쟩ꫫ\udbed듯싱뛳쇵쫷쯹쿻짽䋿㔁礃", a_)))
					{
						num = (short)502136836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_35C;
				}
				case 4:
					goto IL_170;
				case 5:
					if (name.Contains(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("솹薻ﶽ蟃蓅诇韛ﻍ量ﯕ鯙췟ꃡퟣ\udfe5\udee7쟩꿫훭뛯쯱싳쓵짷싹맻볽㓿、礃", a_)))
					{
						num = (short)2107834370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)69337100;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (name.Contains(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("솹請ﲽ薿贈胃蟅跇￉ﳍ铑ﯕ췟ꏡ틣ꗥ\udee7쟩꿫\udfed쏯쫱쳳냵뷷맹뫻룽㛿䌁礃", a_)))
					{
						num = (short)1961164811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)156893185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 8:
					goto IL_DC;
				case 9:
					goto IL_93;
				case 10:
					if (name.Contains(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("솹費ﷃﻉﯕ췟ꃡ퇣ꓥ곧쟩ꫫ꣭쟯샱냳쇵짷쳹췻뫽㣿䐁礃", a_)))
					{
						num = (short)1248067597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1455685637;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_1B9;
				case 12:
					if (name.Contains(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("솹趻﮽膿贈劉诉﷍闓ﯕ췟\udae1\udce3훥ꧧ쟩\udbeb\udeed뛯웱싳쟵쿷볹짻췽䗿㐁礃", a_)))
					{
						num = (short)1474560008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1152909315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_223;
				}
				IL_66:
				if (name.Contains(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("솹蒻誽藃菅跇跍ﯕ鳙駛鳝췟\udae1퇣퇥\udfe7쟩\udeebퟭ쟯엱럳쿵샷맹쫻뫽䗿、礃", a_)))
				{
					num = (short)615448585;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)738066438;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_93:
			num = (short)592904193;
			if (num != 0)
			{
			}
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("ﶽ", a_);
			IL_DC:
			num = (short)1389644366;
			short num4 = num;
			num = (short)948259406;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_35C:
				return null;
			default:
				num = (short)1216086016;
				if (num != 0)
				{
				}
				return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("ꖿ냁닃ꏅ뫇鿉룋ꟍ볏믑ꃓ꿕", a_);
			}
			IL_170:
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("ﾽ邿证", a_);
			IL_1B9:
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("ﺹ", a_);
			IL_223:
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("ꖿ냁닃ꏅ뫇", a_);
			IL_26D:
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("", a_);
			IL_312:
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("펻\udcbd鎿ꟁ뛃냅귇룉", a_);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00005748 File Offset: 0x00003948
		private static string a(string pac)
		{
			int a_ = 9;
			short num = (short)1952972803;
			int num2 = (int)((global::System.IntPtr)num);
			string str;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_146;
				case 1:
					str = string.Empty;
					num = (short)1378549762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1E1;
				case 3:
				{
					num = (short)465118450;
					short num3 = num;
					num = (short)565257458;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15A;
					case 1:
						break;
					default:
					{
						num = (short)767885312;
						short num4 = num;
						break;
					}
					}
					num = (short)1059651584;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_C9;
					}
					continue;
				}
				case 4:
					if (!(pac == global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("", a_)))
					{
						num = (short)1291649031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					str = global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("ﺱ閷햻麽", a_);
					num = (short)169082881;
					if (num != 0)
					{
					}
					num = (short)907935744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_173;
				case 6:
					num = (short)851836932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)1692663809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C9:
				if (!(pac == global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("", a_)))
				{
					num = (short)1652948998;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				str = global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("颷", a_);
				IL_15A:
				num = (short)1146028037;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_146:
			IL_173:
			IL_1E1:
			return str + global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("靈隵ﲷ\udfb9쪻ힽꎿꟁ雅뫇ꗉꯋ볍뇏뿑맓돕꫗", a_);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005968 File Offset: 0x00003B68
		private static string a()
		{
			int a_ = 19;
			short num = (short)71233247;
			short num2 = num;
			num = (short)910814943;
			switch (num2 == num)
			{
			}
			num = (short)1463549953;
			if (num != 0)
			{
			}
			num = (short)151322624;
			if (num != 0)
			{
			}
			num = (short)1969946624;
			short num3 = num;
			return global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("ﶻ춽뒿냁ꯃ飇藉鳋ﳍ蛓鯕黙맛꣝觟臡臣웥룧飩菫觭苯鏱駳鯵鷷裹", a_);
		}
	}
}
