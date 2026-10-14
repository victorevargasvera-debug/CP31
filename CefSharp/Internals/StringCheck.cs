using System;
using System.Text.RegularExpressions;

namespace CefSharp.Internals
{
	// Token: 0x020000F2 RID: 242
	public static class StringCheck
	{
		// Token: 0x06000733 RID: 1843 RVA: 0x0000BB1C File Offset: 0x00009D1C
		public static bool IsLettersAndNumbers(string stringToCheck)
		{
			return !string.IsNullOrWhiteSpace(stringToCheck) && global::System.Text.RegularExpressions.Regex.IsMatch(stringToCheck, "^\\w+$");
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0000BB33 File Offset: 0x00009D33
		public static bool IsFirstCharacterLowercase(string str)
		{
			return !string.IsNullOrEmpty(str) && char.IsLetter(str[0]) && char.IsLower(str[0]);
		}
	}
}
