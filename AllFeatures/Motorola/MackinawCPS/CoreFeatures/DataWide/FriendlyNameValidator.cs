using System;
using System.Text.RegularExpressions;
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004E1 RID: 1249
	internal static class FriendlyNameValidator
	{
		// Token: 0x0600A48A RID: 42122 RVA: 0x00998AE0 File Offset: 0x00996CE0
		public static bool IsFriendlyNameValid(string friendlyName)
		{
			int a_ = 11;
			short num = (short)651153352;
			short num2 = num;
			num = (short)1739444168;
			switch (num2 == num)
			{
			default:
			{
				num = (short)566493184;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)321060865;
			if (num != 0)
			{
			}
			num = (short)1632632832;
			if (num != 0)
			{
			}
			return new global::System.Text.RegularExpressions.Regex(global::AllFeatures.CodeplugGuid.b("鋋闍￑꫓试ꏗ틟\udae1駣싥", a_)).IsMatch(friendlyName);
		}
	}
}
