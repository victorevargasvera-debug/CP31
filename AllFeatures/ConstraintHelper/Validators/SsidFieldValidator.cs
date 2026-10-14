using System;
using System.Text.RegularExpressions;
using AllFeatures;

namespace ConstraintHelper.Validators
{
	// Token: 0x02000603 RID: 1539
	internal class SsidFieldValidator
	{
		// Token: 0x0600D114 RID: 53524 RVA: 0x00C3E58C File Offset: 0x00C3C78C
		public static bool IsSsidNameValid(ref string ssid)
		{
			int a_ = 0;
			short num;
			global::System.Text.RegularExpressions.Regex regex;
			for (;;)
			{
				num = (short)1901527040;
				short num2 = num;
				regex = new global::System.Text.RegularExpressions.Regex(global::AllFeatures.CodeplugGuid.b("鿀飂럈雊", a_));
				if (string.IsNullOrEmpty(ssid))
				{
					return false;
				}
				num = (short)405009966;
				short num3 = num;
				num = (short)880408110;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8A;
				}
			}
			IL_8A:
			num = (short)609353729;
			if (num != 0)
			{
			}
			num = (short)1711734784;
			if (num != 0)
			{
			}
			return regex.IsMatch(ssid);
		}
	}
}
