using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Infrastructure.Pluralization
{
	// Token: 0x0200026D RID: 621
	internal static class PluralizationServiceUtil
	{
		// Token: 0x06001F78 RID: 8056 RVA: 0x00058E14 File Offset: 0x00057014
		internal static bool DoesWordContainSuffix(string word, global::System.Collections.Generic.IEnumerable<string> suffixes, global::System.Globalization.CultureInfo culture)
		{
			return suffixes.Any((string s) => word.EndsWith(s, true, culture));
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x00058E48 File Offset: 0x00057048
		internal static bool TryGetMatchedSuffixForWord(string word, global::System.Collections.Generic.IEnumerable<string> suffixes, global::System.Globalization.CultureInfo culture, out string matchedSuffix)
		{
			matchedSuffix = null;
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.DoesWordContainSuffix(word, suffixes, culture))
			{
				matchedSuffix = suffixes.First((string s) => word.EndsWith(s, true, culture));
				return true;
			}
			return false;
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x00058E98 File Offset: 0x00057098
		internal static bool TryInflectOnSuffixInWord(string word, global::System.Collections.Generic.IEnumerable<string> suffixes, global::System.Func<string, string> operationOnWord, global::System.Globalization.CultureInfo culture, out string newWord)
		{
			newWord = null;
			string text;
			if (global::System.Data.Entity.Infrastructure.Pluralization.PluralizationServiceUtil.TryGetMatchedSuffixForWord(word, suffixes, culture, out text))
			{
				newWord = operationOnWord(word);
				return true;
			}
			return false;
		}
	}
}
