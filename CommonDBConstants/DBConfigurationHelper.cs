using System;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000036 RID: 54
	public static class DBConfigurationHelper
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00003374 File Offset: 0x00001574
		public static string AgencyDBName
		{
			get
			{
				int a_ = 16;
				short num = (short)1360770588;
				short num2 = num;
				num = (short)970569244;
				switch (num2 == num)
				{
				}
				num = (short)384958465;
				if (num != 0)
				{
				}
				num = (short)2009464832;
				short num3 = num;
				num = (short)32178176;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACTypeAttribute.b("椺瀼氾⑀ㅂ㍄≆㭈", a_);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003438 File Offset: 0x00001638
		public static string AgencyDBAuthName
		{
			get
			{
				int a_ = 11;
				short num = (short)1206335412;
				short num2 = num;
				num = (short)1489319860;
				switch (num2 == num)
				{
				}
				num = (short)83427328;
				if (num != 0)
				{
				}
				num = (short)1090191360;
				short num3 = num;
				num = (short)123404289;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACTypeAttribute.b("搵男笹䤻䨽⠿ⵁ㙃⽅㉇⭉㡋❍㽏㱑ݓ≕㝗⡙㥛", a_);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000034F8 File Offset: 0x000016F8
		public static bool DBOnCloud
		{
			get
			{
				short num = (short)1517908811;
				short num2 = num;
				num = (short)694580043;
				switch (num2 == num)
				{
				}
				num = (short)2050752513;
				if (num != 0)
				{
				}
				num = (short)616497152;
				short num3 = num;
				num = (short)2064842752;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.DBConfigurationHelper.a();
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000035A4 File Offset: 0x000017A4
		private static bool a()
		{
			int a_ = 7;
			short num = (short)1205815802;
			short num2 = num;
			num = (short)672287226;
			switch (num2 == num)
			{
			}
			num = (short)1221525504;
			if (num != 0)
			{
			}
			num = (short)1288962048;
			short num3 = num;
			num = (short)2111111169;
			if (num != 0)
			{
			}
			bool result;
			bool.TryParse(global::System.Environment.GetEnvironmentVariable(global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACTypeAttribute.b("瘱瘳椵眷琹挻紽ిുᅃɅ", a_)), out result);
			return result;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003670 File Offset: 0x00001870
		public static string GetOnPremDataSourceConnectionString(string sqlservername)
		{
			short num = (short)813498369;
			if (num != 0)
			{
			}
			num = (short)478867169;
			short num2 = num;
			num = (short)880996065;
			switch (num2 == num)
			{
			}
			num = (short)98500608;
			short num3 = num;
			num = (short)1349189632;
			if (num != 0)
			{
			}
			return string.Format(global::Motorola.CommonCPS.Server.CommonDBConstants.DBConfigurationHelper.b, sqlservername);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003724 File Offset: 0x00001924
		public static string GetOnPremDataSourceConnectionStringToDB(string sqlservername, string dbname)
		{
			short num = (short)2091185850;
			short num2 = num;
			num = (short)542242490;
			switch (num2 == num)
			{
			}
			num = (short)433258496;
			if (num != 0)
			{
			}
			num = (short)1668677632;
			short num3 = num;
			num = (short)982056961;
			if (num != 0)
			{
			}
			return string.Format(global::Motorola.CommonCPS.Server.CommonDBConstants.DBConfigurationHelper.c, sqlservername, dbname);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000037DC File Offset: 0x000019DC
		public static string GetOnPremConnectionString(string sqlservername, string dbname)
		{
			short num = (short)1225945489;
			short num2 = num;
			num = (short)1439920529;
			switch (num2 == num)
			{
			}
			num = (short)2113208320;
			if (num != 0)
			{
			}
			num = (short)1732968448;
			short num3 = num;
			num = (short)459603969;
			if (num != 0)
			{
			}
			return string.Format(global::Motorola.CommonCPS.Server.CommonDBConstants.DBConfigurationHelper.d, sqlservername, dbname);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003890 File Offset: 0x00001A90
		// Note: this type is marked as 'beforefieldinit'.
		static DBConfigurationHelper()
		{
			int a_ = 13;
			short num = (short)1740814127;
			short num2 = num;
			num = (short)2143663919;
			switch (num2 == num)
			{
			}
			num = (short)1826947073;
			if (num != 0)
			{
			}
			num = (short)500957184;
			short num3 = num;
			num = (short)761724928;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.CommonDBConstants.DBConfigurationHelper.b = global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACTypeAttribute.b("簷嬹䠻弽怿ᅁ⭃㍅㩇⥉⥋湍浏牑⽓晕╗慙ᕛそᑟݡͣᑥ१ṩ५੭偯ⅱᅳᕵ൷ࡹᕻ੽勵뾁힃햅\ud887쎉랋\uda8d望ﮙﮝ캟횡쎥\udca7\udda9쎫\udcad\udbafﮱ\uddb7즹펻튽떿뛁귃꧅ꛇ請꿍볏ꇑ뇓", a_);
			global::Motorola.CommonCPS.Server.CommonDBConstants.DBConfigurationHelper.c = global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACTypeAttribute.b("簷嬹䠻弽怿ᅁ⭃㍅㩇⥉⥋湍浏牑⽓晕╗慙ᕛそय़ᙡൣݥѧ䩩⽫཭ѯ፱ᡳ᥵ί䝹ݻ佽ﵿ릁춃ﲇﲍ뢗즙鍊ﶝ햟킡춣튥톧鞩ﾫﶭﮱ辳쪷\udbb9튻춽낿ꏁ뛃ꏅꛇ뻉苋ꯍ꓏ꗑ믓ꓕ돗鏙賛賝藟釡诣諥鷧黩藫臭黯쿱닳韵铷觹駻엽", a_);
			global::Motorola.CommonCPS.Server.CommonDBConstants.DBConfigurationHelper.d = global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACTypeAttribute.b("䬷弹主䠽┿ぁ祃桅ᑇㅉ籋㍍歏㙑㕓≕㥗㡙㵛ⵝ՟彡ὣ坥ᕧ兩╫mѯ᝱፳ѵ᥷๹᥻᩽ꁿ톁ﶇ揄꾑잓얕좗펙ꞛ쪝튟쎡쪣향\ud8a7쮩\udeab쮭\udeaf욱荒펵첷춹펻첽ꮿ证铃铅귇막ꏋꋍꗏꛑ뷓맕뛗髛뿝賟釡臣\udde5ꯧ藩苫胭闯釱胳鿵韷铹\udcfb꫽槿漁愃椅紇縉ㄋ㠍‏", a_);
		}

		// Token: 0x04000191 RID: 401
		private const string a = "DB_ON_CLOUD";

		// Token: 0x04000192 RID: 402
		private static string b;

		// Token: 0x04000193 RID: 403
		private static string c;

		// Token: 0x04000194 RID: 404
		private static string d;
	}
}
