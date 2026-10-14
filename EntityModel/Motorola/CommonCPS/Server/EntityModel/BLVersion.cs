using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001AD RID: 429
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class BLVersion : global::System.IComparable
	{
		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x000EE29C File Offset: 0x000EC49C
		public char ReleaseChar
		{
			get
			{
				short num = (short)543358976;
				short num2 = num;
				num = (short)1336302349;
				short num3 = num;
				num = (short)311646989;
				switch (num3 == num)
				{
				}
				num = (short)1969291265;
				if (num != 0)
				{
				}
				num = (short)904396800;
				if (num != 0)
				{
				}
				return this._releaseChar;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x000EE350 File Offset: 0x000EC550
		public static global::System.Version DefaultVersion
		{
			get
			{
				int a_ = 7;
				short num = (short)2114387968;
				short num2 = num;
				num = (short)870018435;
				short num3 = num;
				num = (short)290876803;
				switch (num3 == num)
				{
				}
				num = (short)2033188864;
				if (num != 0)
				{
				}
				num = (short)1511194625;
				if (num != 0)
				{
				}
				return new global::System.Version(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("㔄㜆✈㬊㴌ℎℐ⌒", a_));
			}
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x000EE414 File Offset: 0x000EC614
		public BLVersion()
		{
			int a_ = 17;
			this..ctor(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("㼎ℐ㴒└✖㜘⬚ⴜ", a_));
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x000EE440 File Offset: 0x000EC640
		public BLVersion(string strVersion)
		{
			int a_ = 13;
			this._releaseChar = 'R';
			base..ctor();
			if (string.IsNullOrEmpty(strVersion))
			{
				strVersion = global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("㬊㴌ℎℐ⌒㬔✖⤘", a_);
			}
			if (global::Motorola.CommonCPS.Server.EntityModel.BLVersion.RXCPVersion == null)
			{
				global::Motorola.CommonCPS.Server.EntityModel.BLVersion.RXCPVersion = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("⌊㈌㌎挐瘒礔爖砘栚砜℞稠戢夤甦唨漪儬洮氰లᰴἶظܺ䬼娾㍀あⱄ⡆❈畊ᅌ⭎⩐扒祔敖⑘獚Ŝ煞㵠ݢṤ噦䕨奪ၬ䙮ੰ䉲ࡴ彶╸啺ⅼ᭾婢늂ꦄ뒆ꊊ뾎붐ꊒ뾖얘떚솜ﮞ\udaa0銢覤閦풨芪횬龮鶰芲좴麶", a_), global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.Singleline);
			}
			global::System.Text.RegularExpressions.Match match = global::Motorola.CommonCPS.Server.EntityModel.BLVersion.RXCPVersion.Match(strVersion);
			if (!string.IsNullOrEmpty(match.Groups[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("礊栌挎琐爒昔爖", a_)].Value))
			{
				this._releaseChar = match.Groups[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("礊栌挎琐爒昔爖", a_)].Value[0];
			}
			if (!string.IsNullOrEmpty(match.Groups[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("紊栌紎成稒稔礖", a_)].Value))
			{
				this.version = new global::System.Version(match.Groups[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("紊栌紎成稒稔礖", a_)].Value);
				if (this.version.Build == -1)
				{
					this.version = new global::System.Version(match.Groups[global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("紊栌紎成稒稔礖", a_)].Value + global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("┊㴌㼎", a_));
					return;
				}
			}
			else
			{
				this.version = new global::System.Version(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("㬊㴌ℎℐ⌒㬔✖⤘", a_));
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x000EE5D0 File Offset: 0x000EC7D0
		public override string ToString()
		{
			int a_ = 14;
			short num = (short)758317056;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 1:
					goto IL_FE;
				case 2:
					if (this.version.Major >= 0)
					{
						num = (short)1289945089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B1;
				case 3:
					if (this.version.Major >= 0 & this.version.Minor >= 0)
					{
						num = (short)211746820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)496893954;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_2AC;
				case 5:
					goto IL_94;
				}
				IL_46:
				if (this.version.Major >= 0 & this.version.Minor >= 0 & this.version.Build >= 0)
				{
					num = (short)1687552005;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)366215171;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_94:
			num = (short)1875050497;
			if (num != 0)
			{
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("看㸍洏椑┓Ⱅ⠗⨙愛〝嬟အḣᘥᠧ圩ȫ唭̯࠱гص䔷", a_), new object[]
			{
				this._releaseChar,
				this.version.Major,
				this.version.Minor,
				this.version.Build
			});
			IL_FE:
			num = (short)1949365170;
			short num3 = num;
			num = (short)1746858930;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_2B1:
				return this._releaseChar.ToString() + this.version.ToString();
			default:
			{
				num = (short)1968766976;
				short num4 = num;
				num = (short)92012544;
				if (num != 0)
				{
				}
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("看㸍洏椑┓Ⱅ⠗⨙愛", a_), this._releaseChar, this.version.Major);
			}
			}
			IL_2AC:
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("看㸍洏椑┓Ⱅ⠗⨙愛〝嬟အḣᘥᠧ圩", a_), this._releaseChar, this.version.Major, this.version.Minor);
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x000EE8AC File Offset: 0x000ECAAC
		public string ToStandVersionString()
		{
			int a_ = 1;
			short num = (short)927006720;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 1:
					goto IL_D9;
				case 2:
					if (this.version.Major >= 0)
					{
						num = (short)1557004289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_280;
				case 3:
					if (this.version.Major >= 0 & this.version.Minor >= 0)
					{
						num = (short)1803878404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)892993538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_27B;
				case 5:
					goto IL_94;
				}
				IL_45:
				if (this.version.Major >= 0 & this.version.Minor >= 0 & this.version.Build >= 0)
				{
					num = (short)1581514757;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)739049473;
					if (num != 0)
					{
					}
					num = (short)887619587;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_94:
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("蓾㄀縂⬄簆㠈瘊⌌琎⌐渒", a_), this.version.Major, this.version.Minor, this.version.Build);
			IL_D9:
			num = (short)109878307;
			short num3 = num;
			num = (short)1240898595;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_280:
				return this.version.ToString();
			default:
			{
				num = (short)1328349184;
				if (num != 0)
				{
				}
				num = (short)1093337088;
				short num4 = num;
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("蓾㄀縂", a_), this.version.Major);
			}
			}
			IL_27B:
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("蓾㄀縂⬄簆㠈瘊", a_), this.version.Major, this.version.Minor);
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x000EEB44 File Offset: 0x000ECD44
		public static bool operator ==(global::Motorola.CommonCPS.Server.EntityModel.BLVersion v1, global::Motorola.CommonCPS.Server.EntityModel.BLVersion v2)
		{
			short num = (short)352124928;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 1:
					num = (short)1593835525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)49283079;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (v1 != null)
					{
						num = (short)244252674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
					goto IL_BC;
				case 5:
				{
					if (v2 != null)
					{
						goto IL_C1;
					}
					num = (short)1606950511;
					short num3 = num;
					num = (short)246161007;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
					{
						num = (short)1571291136;
						short num4 = num;
						num = (short)1739849728;
						if (num != 0)
						{
						}
						num = (short)1631977478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 6:
					return true;
				case 7:
					if (v2 == null)
					{
						num = (short)2052653060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A3;
				}
				IL_45:
				if (v1 == null)
				{
					num = (short)862126081;
					if (num != 0)
					{
					}
					num = (short)174915585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C1:
				num = (short)1312292867;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BC:
			return false;
			IL_1A3:
			return v1.version == v2.version;
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x000EED08 File Offset: 0x000ECF08
		public static bool operator !=(global::Motorola.CommonCPS.Server.EntityModel.BLVersion v1, global::Motorola.CommonCPS.Server.EntityModel.BLVersion v2)
		{
			short num = (short)1740505088;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 1:
					num = (short)1228996613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)2088370177;
					if (num != 0)
					{
					}
					num = (short)1067778055;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (v1 != null)
					{
						num = (short)1335558146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					goto IL_91;
				case 5:
				{
					if (v2 != null)
					{
						goto IL_96;
					}
					num = (short)1101060104;
					short num3 = num;
					num = (short)1458231304;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
					{
						num = (short)235143168;
						short num4 = num;
						num = (short)1496383488;
						if (num != 0)
						{
						}
						num = (short)412090374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 6:
					return false;
				case 7:
					if (v2 == null)
					{
						num = (short)1415839748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A6;
				}
				IL_45:
				if (v1 == null)
				{
					num = (short)1051066369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_96:
				num = (short)492175363;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_91:
			return true;
			IL_1A6:
			return v1.version != v2.version;
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x000EEECC File Offset: 0x000ED0CC
		public static bool operator <(global::Motorola.CommonCPS.Server.EntityModel.BLVersion v1, global::Motorola.CommonCPS.Server.EntityModel.BLVersion v2)
		{
			short num = (short)778436608;
			short num2 = num;
			num = (short)506208618;
			short num3 = num;
			num = (short)2059084138;
			switch (num3 == num)
			{
			}
			num = (short)1808793600;
			if (num != 0)
			{
			}
			num = (short)1120403457;
			if (num != 0)
			{
			}
			return v1.version < v2.version;
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x000EEF88 File Offset: 0x000ED188
		public static bool operator <=(global::Motorola.CommonCPS.Server.EntityModel.BLVersion v1, global::Motorola.CommonCPS.Server.EntityModel.BLVersion v2)
		{
			short num = (short)995622912;
			short num2 = num;
			num = (short)537767746;
			short num3 = num;
			num = (short)1816964930;
			switch (num3 == num)
			{
			}
			num = (short)165937153;
			if (num != 0)
			{
			}
			num = (short)1046216704;
			if (num != 0)
			{
			}
			return v1.version <= v2.version;
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x000EF040 File Offset: 0x000ED240
		public static bool operator >(global::Motorola.CommonCPS.Server.EntityModel.BLVersion v1, global::Motorola.CommonCPS.Server.EntityModel.BLVersion v2)
		{
			short num = (short)527630336;
			short num2 = num;
			num = (short)252557091;
			short num3 = num;
			num = (short)173651747;
			switch (num3 == num)
			{
			}
			num = (short)980615169;
			if (num != 0)
			{
			}
			num = (short)60817408;
			if (num != 0)
			{
			}
			return v1.version > v2.version;
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x000EF0F8 File Offset: 0x000ED2F8
		public static bool operator >=(global::Motorola.CommonCPS.Server.EntityModel.BLVersion v1, global::Motorola.CommonCPS.Server.EntityModel.BLVersion v2)
		{
			short num = (short)2121269248;
			short num2 = num;
			num = (short)1118699521;
			if (num != 0)
			{
			}
			num = (short)1354669907;
			short num3 = num;
			num = (short)1225432915;
			switch (num3 == num)
			{
			}
			num = (short)323026944;
			if (num != 0)
			{
			}
			return v1.version >= v2.version;
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x000EF1B0 File Offset: 0x000ED3B0
		public override bool Equals(object obj)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::Motorola.CommonCPS.Server.EntityModel.BLVersion blversion;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (blversion == null)
					{
						num2 = (short)1470955525;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)977469443;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1582937892;
					short num3 = num2;
					num2 = (short)1221375780;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C0;
					default:
						goto IL_10C;
					}
					break;
				}
				case 2:
					if (!this.version.Equals(blversion.version))
					{
						goto IL_C0;
					}
					return true;
				case 3:
					if (this._releaseChar != blversion._releaseChar)
					{
						num2 = (short)66256900;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2105933826;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return false;
				case 5:
					return false;
				}
				goto IL_28;
				IL_C0:
				num2 = (short)606339073;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_10C:
			num2 = (short)960561152;
			short num4 = num2;
			num2 = (short)767033344;
			if (num2 != 0)
			{
			}
			return false;
			IL_28:
			num2 = (short)1984430081;
			if (num2 != 0)
			{
			}
			blversion = (global::Motorola.CommonCPS.Server.EntityModel.BLVersion)obj;
			num2 = (short)1093730304;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x000EF358 File Offset: 0x000ED558
		public bool EqualsMajMid(global::Motorola.CommonCPS.Server.EntityModel.BLVersion other)
		{
			short num = (short)1851719680;
			short num2 = num;
			if (this.version.Major == other.version.Major)
			{
				num = (short)371982337;
				if (num != 0)
				{
				}
			}
			else
			{
				num = (short)620118310;
				short num3 = num;
				num = (short)815218982;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)598867968;
					if (num != 0)
					{
					}
					return false;
				}
			}
			return this.version.Minor == other.version.Minor;
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x000EF434 File Offset: 0x000ED634
		public override int GetHashCode()
		{
			short num = (short)861208576;
			short num2 = num;
			num = (short)336464668;
			short num3 = num;
			num = (short)1729301276;
			switch (num3 == num)
			{
			}
			num = (short)1219690496;
			if (num != 0)
			{
			}
			num = (short)1431568385;
			if (num != 0)
			{
			}
			return this.version.GetHashCode();
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x000EF4E8 File Offset: 0x000ED6E8
		public int CompareTo(object obj)
		{
			int a_ = 9;
			short num = (short)1418264576;
			short num2 = num;
			num = (short)1730740224;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				num = (short)444399617;
				if (num != 0)
				{
				}
				int result = 0;
				int result2;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_B7;
					}
					global::Motorola.CommonCPS.Server.EntityModel.BLVersion blversion;
					for (;;)
					{
						IL_88:
						switch (num3)
						{
						case 0:
							result = 1;
							num = (short)1516109828;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							if (!(this == blversion))
							{
								goto IL_23C;
							}
							num = (short)2018770704;
							short num4 = num;
							num = (short)1433141008;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_254;
							default:
								num = (short)2010710016;
								if (num != 0)
								{
								}
								num = (short)1317339142;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							if (this > blversion)
							{
								num = (short)101974016;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)634716163;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (this < blversion)
							{
								num = (short)819527687;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1033699329;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_23C;
						case 5:
							goto IL_23C;
						case 6:
						{
							string strA = this._releaseChar.ToString();
							string strB = blversion._releaseChar.ToString();
							result2 = string.Compare(strA, strB, global::System.StringComparison.Ordinal);
							num = (short)416088073;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							result = -1;
							num = (short)971898885;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_254;
						case 9:
							goto IL_12F;
						}
						goto IL_B7;
						IL_23C:
						num = (short)929955848;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_12F:
					return result2;
					IL_254:
					return result;
					IL_B7:
					blversion = (obj as global::Motorola.CommonCPS.Server.EntityModel.BLVersion);
					num = (short)135593986;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_88;
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.Exception(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䐆昈昊紌渎挐瘒㔔爖愘砚砜漞唠䨢䨤䤦", a_), ex.InnerException);
				}
				return result2;
			}
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000EF788 File Offset: 0x000ED988
		public int CompareTo_Descending(object obj)
		{
			int a_ = 11;
			short num = (short)1082654720;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)817692673;
				if (num != 0)
				{
				}
				int result = 0;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_AD;
					}
					global::Motorola.CommonCPS.Server.EntityModel.BLVersion blversion;
					for (;;)
					{
						IL_5E:
						switch (num2)
						{
						case 0:
							if (this < blversion)
							{
								num = (short)1738866694;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)289800202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (this > blversion)
							{
								num = (short)203948049;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1730674688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							result = 1;
							num = (short)1610743823;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							string text;
							string text2;
							if (string.Compare(text, text2, global::System.StringComparison.Ordinal) > 0)
							{
								num = (short)2073427980;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)770179080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							result = 0;
							num = (short)1928593421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							string text = this._releaseChar.ToString();
							string text2 = blversion._releaseChar.ToString();
							num = (short)1876754435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							result = 1;
							num = (short)1695809543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_337;
						case 8:
						{
							string text;
							string text2;
							if (string.Compare(text, text2, global::System.StringComparison.Ordinal) >= 0)
							{
								num = (short)906887179;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1062175729;
							short num3 = num;
							num = (short)540312561;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_EE;
							default:
								num = (short)2119172096;
								if (num != 0)
								{
								}
								num = (short)850001922;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							goto IL_350;
						case 10:
							if (this == blversion)
							{
								num = (short)1472069637;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_337;
						case 11:
						{
							string text;
							string text2;
							if (string.Equals(text, text2, global::System.StringComparison.Ordinal))
							{
								num = (short)89915396;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_337;
						}
						case 12:
							result = -1;
							num = (short)1626341390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_337;
						case 14:
							goto IL_337;
						case 15:
							goto IL_337;
						case 16:
							goto IL_337;
						case 17:
							goto IL_EE;
						}
						goto IL_AD;
						IL_EE:
						result = -1;
						num = (short)1903820816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_337:
						num = (short)1721434121;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_350:
					goto IL_36F;
					IL_AD:
					blversion = (obj as global::Motorola.CommonCPS.Server.EntityModel.BLVersion);
					num = (short)1503330305;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_5E;
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.Exception(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䨈搊怌缎瀐愒瀔㜖簘挚縜稞儠圢䰤䠦䜨", a_), ex.InnerException);
				}
				IL_36F:
				num = (short)592117760;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x000EFB4C File Offset: 0x000EDD4C
		public int ToInt()
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (this.version.Build > 999)
					{
						num2 = (short)164102148;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num3 += this.version.Major * 100000;
					num3 += this.version.Minor * 1000;
					num3 += this.version.Build;
					num2 = (short)207421443;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)2034428676;
					short num4 = num2;
					num2 = (short)1655106308;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C7;
					default:
						num2 = (short)1882324992;
						if (num2 != 0)
						{
						}
						num2 = (short)925630471;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_248;
				case 3:
					goto IL_184;
				case 4:
					goto IL_10A;
				case 5:
					goto IL_1EE;
				case 6:
					if (this.version.Minor > 99)
					{
						num2 = (short)781058050;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)511639552;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_1C7;
				case 8:
					if (this.version != null)
					{
						num2 = (short)1962016769;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24D;
				}
				goto IL_3D;
				IL_1C7:
				if (this.version.Major > 99)
				{
					num2 = (short)509935621;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)1308098566;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_10A:
			throw new global::System.Exception(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("下笍礏縑瀓㘕渗缙減洝䤟䴡䨣إ䔧弩弫娭ု帱儳䔵䬷ᨹ഻฽瀿牁", a_));
			IL_184:
			num2 = (short)1782054913;
			if (num2 != 0)
			{
			}
			goto IL_24D;
			IL_1EE:
			throw new global::System.Exception(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䄋漍稏紑易㘕渗缙減洝䤟䴡䨣إ䔧弩弫娭ု帱儳䔵䬷ᨹ഻฽瀿", a_));
			IL_248:
			throw new global::System.Exception(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䄋服縏紑易㘕渗缙減洝䤟䴡䨣إ䔧弩弫娭ု帱儳䔵䬷ᨹ഻฽瀿", a_));
			IL_24D:
			num2 = (short)683999232;
			short num5 = num2;
			return num3;
			IL_3D:
			num3 = 0;
			num2 = (short)1198784520;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x000EFDD4 File Offset: 0x000EDFD4
		// Note: this type is marked as 'beforefieldinit'.
		static BLVersion()
		{
			int a_ = 2;
			short num = (short)872529985;
			short num2 = num;
			num = (short)278184001;
			switch (num2 == num)
			{
			}
			num = (short)1373110272;
			if (num != 0)
			{
			}
			num = (short)1141571585;
			if (num != 0)
			{
			}
			num = (short)1708261376;
			short num3 = num;
			global::Motorola.CommonCPS.Server.EntityModel.BLVersion.DefaultBLVersion = new global::Motorola.CommonCPS.Server.EntityModel.BLVersion(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("ヿ㈁⨃㘅㠇␉㰋㸍", a_));
		}

		// Token: 0x04000A8D RID: 2701
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Version version;

		// Token: 0x04000A8E RID: 2702
		[global::System.Runtime.Serialization.DataMember]
		private char _releaseChar;

		// Token: 0x04000A8F RID: 2703
		private const string GrpReleaseChar = "release";

		// Token: 0x04000A90 RID: 2704
		private const string GrpVersion = "version";

		// Token: 0x04000A91 RID: 2705
		private const string DefaultCPVersion = "00.00.00";

		// Token: 0x04000A92 RID: 2706
		public static global::Motorola.CommonCPS.Server.EntityModel.BLVersion DefaultBLVersion;

		// Token: 0x04000A93 RID: 2707
		private static global::System.Text.RegularExpressions.Regex RXCPVersion;
	}
}
