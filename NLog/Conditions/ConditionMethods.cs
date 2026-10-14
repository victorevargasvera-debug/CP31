using System;
using System.Text.RegularExpressions;

namespace NLog.Conditions
{
	// Token: 0x0200017F RID: 383
	[global::NLog.Conditions.ConditionMethods]
	public static class ConditionMethods
	{
		// Token: 0x06001071 RID: 4209 RVA: 0x0002B739 File Offset: 0x00029939
		[global::NLog.Conditions.ConditionMethod("equals")]
		public static bool Equals2(object firstValue, object secondValue)
		{
			return firstValue.Equals(secondValue);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0002B744 File Offset: 0x00029944
		[global::NLog.Conditions.ConditionMethod("strequals")]
		public static bool Equals2(string firstValue, string secondValue, bool ignoreCase = false)
		{
			return firstValue.Equals(secondValue, ignoreCase ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0002B764 File Offset: 0x00029964
		[global::NLog.Conditions.ConditionMethod("contains")]
		public static bool Contains(string haystack, string needle, bool ignoreCase = true)
		{
			return haystack.IndexOf(needle, ignoreCase ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal) >= 0;
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0002B788 File Offset: 0x00029988
		[global::NLog.Conditions.ConditionMethod("starts-with")]
		public static bool StartsWith(string haystack, string needle, bool ignoreCase = true)
		{
			return haystack.StartsWith(needle, ignoreCase ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal);
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0002B7A8 File Offset: 0x000299A8
		[global::NLog.Conditions.ConditionMethod("ends-with")]
		public static bool EndsWith(string haystack, string needle, bool ignoreCase = true)
		{
			return haystack.EndsWith(needle, ignoreCase ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0002B7C5 File Offset: 0x000299C5
		[global::NLog.Conditions.ConditionMethod("length")]
		public static int Length(string text)
		{
			return text.Length;
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x0002B7D0 File Offset: 0x000299D0
		[global::NLog.Conditions.ConditionMethod("regex-matches")]
		public static bool RegexMatches(string input, string pattern, string options = "")
		{
			global::System.Text.RegularExpressions.RegexOptions options2 = global::NLog.Conditions.ConditionMethods.ParseRegexOptions(options);
			return global::System.Text.RegularExpressions.Regex.IsMatch(input, pattern, options2);
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0002B7EC File Offset: 0x000299EC
		private static global::System.Text.RegularExpressions.RegexOptions ParseRegexOptions(string options)
		{
			if (string.IsNullOrEmpty(options))
			{
				return global::System.Text.RegularExpressions.RegexOptions.None;
			}
			return (global::System.Text.RegularExpressions.RegexOptions)global::System.Enum.Parse(typeof(global::System.Text.RegularExpressions.RegexOptions), options, true);
		}
	}
}
