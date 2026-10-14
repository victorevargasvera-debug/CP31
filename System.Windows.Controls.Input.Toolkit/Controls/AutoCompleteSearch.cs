using System;

namespace System.Windows.Controls
{
	// Token: 0x02000012 RID: 18
	internal static class AutoCompleteSearch
	{
		// Token: 0x06000115 RID: 277 RVA: 0x00005B7C File Offset: 0x00003D7C
		public static global::System.Windows.Controls.AutoCompleteFilterPredicate<string> GetFilter(global::System.Windows.Controls.AutoCompleteFilterMode FilterMode)
		{
			switch (FilterMode)
			{
			case global::System.Windows.Controls.AutoCompleteFilterMode.StartsWith:
				return new global::System.Windows.Controls.AutoCompleteFilterPredicate<string>(global::System.Windows.Controls.AutoCompleteSearch.StartsWith);
			case global::System.Windows.Controls.AutoCompleteFilterMode.StartsWithCaseSensitive:
				return new global::System.Windows.Controls.AutoCompleteFilterPredicate<string>(global::System.Windows.Controls.AutoCompleteSearch.StartsWithCaseSensitive);
			case global::System.Windows.Controls.AutoCompleteFilterMode.StartsWithOrdinal:
				return new global::System.Windows.Controls.AutoCompleteFilterPredicate<string>(global::System.Windows.Controls.AutoCompleteSearch.StartsWithOrdinal);
			case global::System.Windows.Controls.AutoCompleteFilterMode.StartsWithOrdinalCaseSensitive:
				return new global::System.Windows.Controls.AutoCompleteFilterPredicate<string>(global::System.Windows.Controls.AutoCompleteSearch.StartsWithOrdinalCaseSensitive);
			case global::System.Windows.Controls.AutoCompleteFilterMode.Contains:
				return new global::System.Windows.Controls.AutoCompleteFilterPredicate<string>(global::System.Windows.Controls.AutoCompleteSearch.Contains);
			case global::System.Windows.Controls.AutoCompleteFilterMode.ContainsCaseSensitive:
				return new global::System.Windows.Controls.AutoCompleteFilterPredicate<string>(global::System.Windows.Controls.AutoCompleteSearch.ContainsCaseSensitive);
			case global::System.Windows.Controls.AutoCompleteFilterMode.ContainsOrdinal:
				return new global::System.Windows.Controls.AutoCompleteFilterPredicate<string>(global::System.Windows.Controls.AutoCompleteSearch.ContainsOrdinal);
			case global::System.Windows.Controls.AutoCompleteFilterMode.ContainsOrdinalCaseSensitive:
				return new global::System.Windows.Controls.AutoCompleteFilterPredicate<string>(global::System.Windows.Controls.AutoCompleteSearch.ContainsOrdinalCaseSensitive);
			case global::System.Windows.Controls.AutoCompleteFilterMode.Equals:
				return new global::System.Windows.Controls.AutoCompleteFilterPredicate<string>(global::System.Windows.Controls.AutoCompleteSearch.Equals);
			case global::System.Windows.Controls.AutoCompleteFilterMode.EqualsCaseSensitive:
				return new global::System.Windows.Controls.AutoCompleteFilterPredicate<string>(global::System.Windows.Controls.AutoCompleteSearch.EqualsCaseSensitive);
			case global::System.Windows.Controls.AutoCompleteFilterMode.EqualsOrdinal:
				return new global::System.Windows.Controls.AutoCompleteFilterPredicate<string>(global::System.Windows.Controls.AutoCompleteSearch.EqualsOrdinal);
			case global::System.Windows.Controls.AutoCompleteFilterMode.EqualsOrdinalCaseSensitive:
				return new global::System.Windows.Controls.AutoCompleteFilterPredicate<string>(global::System.Windows.Controls.AutoCompleteSearch.EqualsOrdinalCaseSensitive);
			}
			return null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00005C6B File Offset: 0x00003E6B
		public static bool StartsWith(string text, string value)
		{
			return value.StartsWith(text, global::System.StringComparison.CurrentCultureIgnoreCase);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00005C75 File Offset: 0x00003E75
		public static bool StartsWithCaseSensitive(string text, string value)
		{
			return value.StartsWith(text, global::System.StringComparison.CurrentCulture);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005C7F File Offset: 0x00003E7F
		public static bool StartsWithOrdinal(string text, string value)
		{
			return value.StartsWith(text, global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00005C89 File Offset: 0x00003E89
		public static bool StartsWithOrdinalCaseSensitive(string text, string value)
		{
			return value.StartsWith(text, global::System.StringComparison.Ordinal);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00005C93 File Offset: 0x00003E93
		public static bool Contains(string text, string value)
		{
			return value.Contains(text, global::System.StringComparison.CurrentCultureIgnoreCase);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00005C9D File Offset: 0x00003E9D
		public static bool ContainsCaseSensitive(string text, string value)
		{
			return value.Contains(text, global::System.StringComparison.CurrentCulture);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00005CA7 File Offset: 0x00003EA7
		public static bool ContainsOrdinal(string text, string value)
		{
			return value.Contains(text, global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00005CB1 File Offset: 0x00003EB1
		public static bool ContainsOrdinalCaseSensitive(string text, string value)
		{
			return value.Contains(text, global::System.StringComparison.Ordinal);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00005CBB File Offset: 0x00003EBB
		public static bool Equals(string text, string value)
		{
			return value.Equals(text, global::System.StringComparison.CurrentCultureIgnoreCase);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00005CC5 File Offset: 0x00003EC5
		public static bool EqualsCaseSensitive(string text, string value)
		{
			return value.Equals(text, global::System.StringComparison.CurrentCulture);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00005CCF File Offset: 0x00003ECF
		public static bool EqualsOrdinal(string text, string value)
		{
			return value.Equals(text, global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005CD9 File Offset: 0x00003ED9
		public static bool EqualsOrdinalCaseSensitive(string text, string value)
		{
			return value.Equals(text, global::System.StringComparison.Ordinal);
		}
	}
}
