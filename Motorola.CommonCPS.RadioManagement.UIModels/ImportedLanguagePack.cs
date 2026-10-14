using System;
using System.Globalization;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000A9 RID: 169
	public class ImportedLanguagePack : global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<global::Motorola.CommonCPS.Server.EntityModel.Package>
	{
		// Token: 0x0600063B RID: 1595 RVA: 0x0005A4D0 File Offset: 0x000586D0
		public ImportedLanguagePack(global::Motorola.CommonCPS.Server.EntityModel.Package package) : base(package)
		{
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x0005A4E4 File Offset: 0x000586E4
		public string URL
		{
			get
			{
				if (base.Entity.RMFile != null)
				{
					short num = (short)1324509366;
					short num2 = num;
					num = (short)77686966;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C0;
					case 1:
						break;
					default:
					{
						num = (short)380108800;
						short num3 = num;
						break;
					}
					}
					num = (short)1074855936;
					if (num != 0)
					{
					}
					num = (short)815071233;
					if (num != 0)
					{
					}
					return base.Entity.RMFile.Url;
				}
				IL_C0:
				return string.Empty;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x0005A5B8 File Offset: 0x000587B8
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x0005A808 File Offset: 0x00058A08
		public string Name
		{
			get
			{
				short num = (short)1554710537;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)143130624;
						short num3 = num;
						string packageName = (base.Entity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack).PackageName;
						num = (short)1289879557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (base.Entity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack)
						{
							goto IL_E3;
						}
						num = (short)428015624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						string packageName;
						return packageName;
					}
					case 3:
					{
						string packageLanguage = (base.Entity as global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack).PackageLanguage;
						num = (short)1670447108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						string packageLanguage;
						if (!string.IsNullOrEmpty(packageLanguage))
						{
							num = (short)1682112519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B9;
					}
					case 5:
					{
						string packageName;
						if (!string.IsNullOrEmpty(packageName))
						{
							num = (short)931135490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E6;
					}
					case 6:
						goto IL_6A;
					case 7:
					{
						string packageLanguage;
						return packageLanguage;
					}
					case 8:
					{
						num = (short)1185415169;
						if (num != 0)
						{
						}
						if (!(base.Entity is global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack))
						{
							goto IL_23D;
						}
						num = (short)1781206176;
						short num4 = num;
						num = (short)952175776;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E3;
						default:
							num = (short)2093154304;
							if (num != 0)
							{
							}
							num = (short)1391001600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						switch (0)
						{
						case 0:
							goto IL_4C;
						}
						continue;
					}
					IL_4C:
					if (base.Entity == null)
					{
						num = (short)265355270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1576796161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E3:
					num = (short)651493379;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_6A:
				return string.Empty;
				IL_B9:
				return string.Empty;
				IL_1E6:
				return string.Empty;
				IL_23D:
				return string.Empty;
			}
			set
			{
				short num = (short)1816133642;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					switch (num2)
					{
					case 0:
					{
						num = (short)1415818734;
						short num3 = num;
						num = (short)1908977134;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_238;
						default:
							num = (short)291241984;
							if (num != 0)
							{
							}
							(base.Entity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack).PackageName = value;
							num = (short)1479409667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						text = value;
						goto IL_1F6;
					case 2:
						if (base.Entity is global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack)
						{
							num = (short)1859059712;
							short num4 = num;
							num = (short)468123648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_FD;
					case 4:
						if (base.Entity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack)
						{
							num = (short)351141896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2034368514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return;
					case 6:
						num = (short)1022951425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)431489025;
						if (num != 0)
						{
						}
						if (!string.IsNullOrEmpty(value))
						{
							num = (short)1822818310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)90046473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_236;
					case 9:
						text = string.Empty;
						goto IL_1F6;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_50;
						}
						continue;
					}
					IL_50:
					if (base.Entity == null)
					{
						num = (short)807927813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2062548999;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F6:
					value = text;
					num = (short)1651638276;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_FD:
				return;
				IL_236:
				IL_238:
				(base.Entity as global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack).PackageLanguage = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x0005AA60 File Offset: 0x00058C60
		public string ImportTime
		{
			get
			{
				int a_ = 16;
				if (base.Entity.CreatedDate != null)
				{
					short num = (short)1295941690;
					short num2 = num;
					num = (short)1405059130;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F4;
					case 1:
						break;
					default:
					{
						num = (short)731709440;
						short num3 = num;
						break;
					}
					}
					num = (short)392167425;
					if (num != 0)
					{
					}
					num = (short)1961426944;
					if (num != 0)
					{
					}
					return base.Entity.CreatedDate.Value.ToLocalTime().ToString(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ొ", a_), global::System.Globalization.CultureInfo.InvariantCulture);
				}
				IL_F4:
				return string.Empty;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x0005AB68 File Offset: 0x00058D68
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x0005ADAC File Offset: 0x00058FAC
		public string Locale
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_38;
				}
				int num;
				string result;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack pcrlanguagePack;
						result = pcrlanguagePack.PackageID;
						num2 = (short)713883655;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						if (base.Entity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack)
						{
							num2 = (short)419364867;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 2:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack;
						result = astrolanguagePack.LpID;
						num2 = (short)2086338564;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
					{
						num2 = (short)1115553792;
						short num3 = num2;
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack = base.Entity as global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack;
						num2 = (short)1497104389;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
						return result;
					case 5:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack;
						if (!string.IsNullOrEmpty(astrolanguagePack.LpID))
						{
							num2 = (short)846069762;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					case 6:
					{
						num2 = (short)81738619;
						short num4 = num2;
						num2 = (short)1925266299;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						default:
						{
							num2 = (short)878903296;
							if (num2 != 0)
							{
							}
							global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack pcrlanguagePack = base.Entity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack;
							num2 = (short)236781576;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 7:
						return result;
					case 8:
					{
						global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack pcrlanguagePack;
						if (!string.IsNullOrEmpty(pcrlanguagePack.PackageID))
						{
							num2 = (short)724631552;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					case 9:
						if (base.Entity is global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack)
						{
							num2 = (short)611450886;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)975699969;
						if (num2 != 0)
						{
						}
						num2 = (short)1318453249;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_38;
				}
				return result;
				IL_38:
				result = string.Empty;
				num2 = (short)625999881;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				short num = (short)1869283332;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_59;
					case 1:
					{
						num = (short)823328769;
						if (num != 0)
						{
						}
						num = (short)163708928;
						short num3 = num;
						if (base.Entity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack)
						{
							num = (short)884146178;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
						goto IL_5E;
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					}
					IL_38:
					if (base.Entity is global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack)
					{
						num = (short)1919352832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)741781948;
					short num4 = num;
					num = (short)1378726332;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)243335168;
						if (num != 0)
						{
						}
						num = (short)2028666881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5E:
					(base.Entity as global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack).LpID = value;
					num = (short)744620035;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_59:
				(base.Entity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack).PackageID = value;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x0005AF30 File Offset: 0x00059130
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x0005B174 File Offset: 0x00059374
		public string Version
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_38;
				}
				int num;
				string result;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack pcrlanguagePack;
						result = pcrlanguagePack.PackageVersion;
						num2 = (short)1993932807;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						num2 = (short)872939521;
						if (num2 != 0)
						{
						}
						if (base.Entity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack)
						{
							num2 = (short)1932656643;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 2:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack;
						result = astrolanguagePack.PackageVersion;
						num2 = (short)844562436;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
					{
						num2 = (short)1164378112;
						short num3 = num2;
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack = base.Entity as global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack;
						num2 = (short)1424949253;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
						return result;
					case 5:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack;
						if (!string.IsNullOrEmpty(astrolanguagePack.LpID))
						{
							num2 = (short)585629698;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					case 6:
					{
						num2 = (short)546484083;
						short num4 = num2;
						num2 = (short)2059054963;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						default:
						{
							num2 = (short)1642201088;
							if (num2 != 0)
							{
							}
							global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack pcrlanguagePack = base.Entity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack;
							num2 = (short)6094856;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 7:
						return result;
					case 8:
					{
						global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack pcrlanguagePack;
						if (!string.IsNullOrEmpty(pcrlanguagePack.PackageID))
						{
							num2 = (short)1197932544;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					case 9:
						if (base.Entity is global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack)
						{
							num2 = (short)619905030;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)701825025;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_38;
				}
				return result;
				IL_38:
				result = string.Empty;
				num2 = (short)766377993;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				short num = (short)403177473;
				if (num != 0)
				{
				}
				num = (short)1630011399;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (base.Entity is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack)
						{
							num = (short)1028063233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						(base.Entity as global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack).PackageVersion = value;
						num = (short)651034630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (base.Entity is global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack)
						{
							num = (short)1013121029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1207173120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_16C;
					case 4:
						goto IL_87;
					case 5:
						goto IL_1AB;
					case 6:
					{
						num = (short)474170549;
						short num3 = num;
						num = (short)1146242229;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_87;
						default:
							goto IL_154;
						}
						break;
					}
					case 7:
						switch (0)
						{
						case 0:
							goto IL_6C;
						}
						continue;
					}
					IL_6C:
					if (value == null)
					{
						num = (short)1683095556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16C;
					IL_87:
					value = string.Empty;
					num = (short)753205251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16C:
					num = (short)885915650;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_154:
				num = (short)838336512;
				if (num != 0)
				{
				}
				return;
				IL_1AB:
				num = (short)1399521280;
				short num4 = num;
				(base.Entity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack).PackageVersion = value;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x0005B35C File Offset: 0x0005955C
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x0005B518 File Offset: 0x00059718
		public int Size
		{
			get
			{
				short num = (short)1057879483;
				short num2 = num;
				num = (short)288421307;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1811480576;
					if (num != 0)
					{
					}
					num = (short)1325268995;
					int num3 = (int)((global::System.IntPtr)num);
					int? length;
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_F2;
						case 1:
							goto IL_A3;
						case 2:
							if (base.Entity.RMFile != null)
							{
								num = (short)986906624;
								short num4 = num;
								num = (short)770768900;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return 0;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_87;
							}
							continue;
						case 4:
							length = base.Entity.RMFile.Length;
							num = (short)839057413;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (length != null)
							{
								num = (short)44171264;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return 0;
						}
						IL_87:
						if (base.Entity == null)
						{
							num = (short)1077215233;
							num3 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)1235681282;
							num3 = (int)((global::System.IntPtr)num);
						}
					}
					IL_A3:
					break;
					IL_F2:
					num = (short)475332609;
					if (num != 0)
					{
					}
					length = base.Entity.RMFile.Length;
					return (length.Value + 1023) / 1024;
				}
				}
				return 0;
			}
			set
			{
				short num = (short)631898114;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)712900609;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)1547436032;
						short num3 = num;
						base.Entity.RMFile.Length = new int?(value * 1024 - 1023);
						num = (short)1685258244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (base.Entity.RMFile != null)
						{
							num = (short)860749824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 3:
						return;
					case 4:
						return;
					}
					IL_60:
					if (base.Entity == null)
					{
						num = (short)335347715;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1802072643;
						short num4 = num;
						num = (short)1894937155;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)99614720;
							if (num != 0)
							{
							}
							num = (short)50135041;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x0005B69C File Offset: 0x0005989C
		public string LanguageFamily
		{
			get
			{
				short num;
				while (base.Entity is global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack)
				{
					num = (short)1119867990;
					short num2 = num;
					num = (short)1495716950;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)554631168;
						short num3 = num;
						num = (short)1217069056;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack pcrlanguagePack = base.Entity as global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack;
						return this.a(pcrlanguagePack.LanguagePackFamily);
					}
					}
				}
				num = (short)1877278721;
				if (num != 0)
				{
				}
				return string.Empty;
			}
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0005B778 File Offset: 0x00059978
		public override global::Motorola.CommonCPS.Server.EntityModel.Package ToEntity()
		{
			short num = (short)776256856;
			short num2 = num;
			num = (short)2139864408;
			switch (num2 == num)
			{
			}
			num = (short)718209025;
			if (num != 0)
			{
			}
			num = (short)378601472;
			if (num != 0)
			{
			}
			num = (short)592183296;
			short num3 = num;
			return base.Entity;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0005B828 File Offset: 0x00059A28
		private string a(int? A_0)
		{
			short num = (short)1829699585;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)771162113;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)1069537550;
					short num3 = num;
					num = (short)1312807182;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_85;
					default:
					{
						num = (short)1880358912;
						if (num != 0)
						{
						}
						int valueOrDefault = A_0.GetValueOrDefault();
						num = (short)1377370115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					continue;
				case 2:
				{
					num = (short)933363712;
					short num4 = num;
					num = (short)1588133893;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					int valueOrDefault;
					switch (valueOrDefault)
					{
					case 0:
						goto IL_E9;
					case 1:
						goto IL_F5;
					case 2:
						goto IL_87;
					default:
						num = (short)478150658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_85;
				case 5:
					goto IL_A5;
				case 6:
					if (A_0 != null)
					{
						num = (short)1861156864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BD;
				}
				IL_67:
				if (A_0 == null)
				{
					num = (short)2115371012;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)954204166;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_85:
			return string.Empty;
			IL_87:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.LanguagePackFamily_Malta;
			IL_A5:
			goto IL_1BD;
			IL_E9:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.LanguagePackFamily_Trbo;
			IL_F5:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.LanguagePackFamily_Paradise;
			IL_1BD:
			return string.Empty;
		}
	}
}
