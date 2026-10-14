using System;
using System.Globalization;
using Motorola.CommonCPS.Server.EntityModel;

namespace CommonUtility
{
	// Token: 0x02000033 RID: 51
	public class DataModelVersionUtility
	{
		// Token: 0x0600010F RID: 271 RVA: 0x0001C764 File Offset: 0x0001A964
		public static string GetLatestDataModelVersion()
		{
			short num = (short)1270796374;
			short num2 = num;
			num = (short)405852246;
			switch (num2 == num)
			{
			}
			num = (short)682098688;
			short num3 = num;
			num = (short)1931280385;
			if (num != 0)
			{
			}
			num = (short)1649082368;
			if (num != 0)
			{
			}
			return global::CommonUtility.DataModelVersionUtility.DataModelVersion.ToString();
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0001C818 File Offset: 0x0001AA18
		public static global::Motorola.CommonCPS.Server.EntityModel.BLVersion CovertConfigVersionToBLVersion(string versionString)
		{
			int a_ = 3;
			short num = (short)816373909;
			short num2 = num;
			num = (short)137420949;
			switch (num2 == num)
			{
			}
			num = (short)1894055936;
			short num3 = num;
			num = (short)860880897;
			if (num != 0)
			{
			}
			num = (short)262406144;
			if (num != 0)
			{
			}
			string arg = versionString.Substring(4, 2);
			string arg2 = versionString.Substring(7, 2);
			return new global::Motorola.CommonCPS.Server.EntityModel.BLVersion(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::CommonUtility.VersionUtility.b("伳ص䔷ᐹ䜻༽㴿汁瑃", a_), arg, arg2));
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0001C8F8 File Offset: 0x0001AAF8
		public static string CovertBLVersionToConfigurationVersionString(global::Motorola.CommonCPS.Server.EntityModel.BLVersion blVersion)
		{
			int a_ = 0;
			short num = (short)1644097162;
			short num2 = num;
			num = (short)1603595914;
			switch (num2 == num)
			{
			}
			num = (short)805961728;
			short num3 = num;
			num = (short)474873857;
			if (num != 0)
			{
			}
			num = (short)931135488;
			if (num != 0)
			{
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::CommonUtility.VersionUtility.b("䨰̲༴ܶस䘺ጼ䐾灀祂畄睆㑈", a_), blVersion.version.Major, blVersion.version.Minor);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0001C9F4 File Offset: 0x0001ABF4
		// Note: this type is marked as 'beforefieldinit'.
		static DataModelVersionUtility()
		{
			int a_ = 3;
			short num = (short)2072392167;
			short num2 = num;
			num = (short)80294375;
			switch (num2 == num)
			{
			}
			num = (short)1781596160;
			short num3 = num;
			num = (short)1075118081;
			if (num != 0)
			{
			}
			num = (short)1415249920;
			if (num != 0)
			{
			}
			global::CommonUtility.DataModelVersionUtility.DataModelVersion = new global::Motorola.CommonCPS.Server.EntityModel.BLVersion(global::CommonUtility.VersionUtility.b("سᠵष༹ሻ฽", a_));
		}

		// Token: 0x04000099 RID: 153
		public static global::Motorola.CommonCPS.Server.EntityModel.BLVersion DataModelVersion;
	}
}
