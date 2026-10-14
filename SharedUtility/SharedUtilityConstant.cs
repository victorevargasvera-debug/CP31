using System;
using System.Text.RegularExpressions;
using SharedUtility.Arguments;

namespace SharedUtility
{
	// Token: 0x02000003 RID: 3
	public class SharedUtilityConstant
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002130 File Offset: 0x00000330
		// Note: this type is marked as 'beforefieldinit'.
		static SharedUtilityConstant()
		{
			int a_ = 17;
			short num = (short)1042153473;
			if (num != 0)
			{
			}
			num = (short)2132503105;
			short num2 = num;
			num = (short)414149185;
			switch (num2 == num)
			{
			}
			num = (short)1576796160;
			short num3 = num;
			num = (short)1085603840;
			if (num != 0)
			{
			}
			global::SharedUtility.SharedUtilityConstant.IPRegex = new global::System.Text.RegularExpressions.Regex(global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("튋ꚍ뢏즑꒓뮕ꆗ잙얝醟辡鶣ﮥ骩膫鞭캱薳袷鞹薻뮿맃뫅難釉ﳋ近迓臛ꋝ틟ퟡ뿣훥엧\udfe9뇫쟭곯\udcf1\uddf3践쯷蟹퓻ꗽヿ⼁㴃嬅琇儉㴋⌍⤏休伓☕㔗⌙䄛戝ᄟ礡ᐣଥᄧ眩圫ᰭ䴯丱س洵࠷᜹࠻挽ᬿ牁楃罅ᕇ㙉繋筍୏扑祓捕՗獙硛", a_), global::System.Text.RegularExpressions.RegexOptions.Compiled);
			global::SharedUtility.SharedUtilityConstant.UserNameRegex = new global::System.Text.RegularExpressions.Regex(global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("튋햍ꂏ뾑궓힕떗삙ﶛ뎝\uda9fﺡ힣貥螧覩莫読龯钱鮳鎵鞷邹鎻麽黁跏꧑𥉉ꇛ﫝", a_), global::System.Text.RegularExpressions.RegexOptions.Compiled);
			global::SharedUtility.SharedUtilityConstant.UserPinRegex = new global::System.Text.RegularExpressions.Regex(global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("튋햍ꂏ뾑궓힕떗삙ﶛ뎝\uda9fﺡ힣貥螧覩莫読龯钱鮳鎵鞷邹鎻麽黁跏꧑𥉉ꇛ﫝", a_), global::System.Text.RegularExpressions.RegexOptions.Compiled);
			global::SharedUtility.SharedUtilityConstant.UserLoginUnitIDRegex = new global::System.Text.RegularExpressions.Regex(global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("튋햍ꂏ뾑궓힕떗삙ﶛ뎝\uda9fﺡ힣貥螧覩莫読龯钱鮳鎵鞷邹鎻麽黁跏꧑𥉉ꇛ﫝", a_), global::System.Text.RegularExpressions.RegexOptions.Compiled);
		}

		// Token: 0x04000003 RID: 3
		public const string REG_IP = "^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";

		// Token: 0x04000004 RID: 4
		public const string MAXIP = "255.255.255.255";

		// Token: 0x04000005 RID: 5
		public const string MINIP = "0.0.0.0";

		// Token: 0x04000006 RID: 6
		public const int MINOTARID = 0;

		// Token: 0x04000007 RID: 7
		public const int MAXOTARID = 9999999;

		// Token: 0x04000008 RID: 8
		public const int MINVALUE = 1;

		// Token: 0x04000009 RID: 9
		public const int MAXCAI = 126;

		// Token: 0x0400000A RID: 10
		public const int MAXPCRRADIOID = 16776415;

		// Token: 0x0400000B RID: 11
		public const int CALLID_SITECALL = 16777213;

		// Token: 0x0400000C RID: 12
		public const int CALLID_MULTISITECALL = 16777214;

		// Token: 0x0400000D RID: 13
		public const int CALLID_DGTLALLSYSCALL = 16777215;

		// Token: 0x0400000E RID: 14
		public const int CALLID_UNADRESSEDCALL_MIN = 16777184;

		// Token: 0x0400000F RID: 15
		public const int CALLID_UNADRESSEDCALL_MAX = 16777199;

		// Token: 0x04000010 RID: 16
		public const string REG_USERNAME = "^[0-9A-Za-z\\s*/#/$/&/%/*/ /\\-/+///]{0,20}$";

		// Token: 0x04000011 RID: 17
		public const string REG_USERPIN = "^[0-9A-Za-z\\s*/#/$/&/%/*/ /\\-/+///]{0,20}$";

		// Token: 0x04000012 RID: 18
		public const string REG_USERLOGINUNITID = "^[0-9A-Za-z\\s*/#/$/&/%/*/ /\\-/+///]{0,20}$";

		// Token: 0x04000013 RID: 19
		public static readonly global::System.Text.RegularExpressions.Regex IPRegex;

		// Token: 0x04000014 RID: 20
		public static readonly global::System.Text.RegularExpressions.Regex UserNameRegex;

		// Token: 0x04000015 RID: 21
		public static readonly global::System.Text.RegularExpressions.Regex UserPinRegex;

		// Token: 0x04000016 RID: 22
		public static readonly global::System.Text.RegularExpressions.Regex UserLoginUnitIDRegex;
	}
}
