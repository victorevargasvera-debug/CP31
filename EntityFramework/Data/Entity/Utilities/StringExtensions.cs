using System;
using System.Data.Entity.Resources;
using System.Globalization;
using System.Text.RegularExpressions;

namespace System.Data.Entity.Utilities
{
	// Token: 0x0200008F RID: 143
	internal static class StringExtensions
	{
		// Token: 0x06000491 RID: 1169 RVA: 0x0000FEC8 File Offset: 0x0000E0C8
		public static bool EqualsIgnoreCase(this string s1, string s2)
		{
			return string.Equals(s1, s2, global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0000FED2 File Offset: 0x0000E0D2
		internal static bool EqualsOrdinal(this string s1, string s2)
		{
			return string.Equals(s1, s2, global::System.StringComparison.Ordinal);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0000FEDC File Offset: 0x0000E0DC
		public static string MigrationName(this string migrationId)
		{
			return migrationId.Substring(16);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0000FEE6 File Offset: 0x0000E0E6
		public static string RestrictTo(this string s, int size)
		{
			if (string.IsNullOrEmpty(s) || s.Length <= size)
			{
				return s;
			}
			return s.Substring(0, size);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0000FF03 File Offset: 0x0000E103
		public static void EachLine(this string s, global::System.Action<string> action)
		{
			s.Split(global::System.Data.Entity.Utilities.StringExtensions._lineEndings, global::System.StringSplitOptions.None).Each(action);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000FF17 File Offset: 0x0000E117
		public static bool IsValidMigrationId(this string migrationId)
		{
			return global::System.Data.Entity.Utilities.StringExtensions._migrationIdPattern.IsMatch(migrationId) || migrationId == "0";
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000FF33 File Offset: 0x0000E133
		public static bool IsAutomaticMigration(this string migrationId)
		{
			return migrationId.EndsWith(global::System.Data.Entity.Resources.Strings.AutomaticMigration, global::System.StringComparison.Ordinal);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0000FF44 File Offset: 0x0000E144
		public static string ToAutomaticMigrationId(this string migrationId)
		{
			return (global::System.Convert.ToInt64(migrationId.Substring(0, 15), global::System.Globalization.CultureInfo.InvariantCulture) - 1L).ToString() + migrationId.Substring(15) + "_" + global::System.Data.Entity.Resources.Strings.AutomaticMigration;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000FF86 File Offset: 0x0000E186
		public static bool IsValidUndottedName(this string name)
		{
			return !string.IsNullOrEmpty(name) && global::System.Data.Entity.Utilities.StringExtensions._undottedNameValidator.IsMatch(name);
		}

		// Token: 0x04000118 RID: 280
		private const string StartCharacterExp = "[\\p{L}\\p{Nl}_]";

		// Token: 0x04000119 RID: 281
		private const string OtherCharacterExp = "[\\p{L}\\p{Nl}\\p{Nd}\\p{Mn}\\p{Mc}\\p{Pc}\\p{Cf}]";

		// Token: 0x0400011A RID: 282
		private const string NameExp = "[\\p{L}\\p{Nl}_][\\p{L}\\p{Nl}\\p{Nd}\\p{Mn}\\p{Mc}\\p{Pc}\\p{Cf}]{0,}";

		// Token: 0x0400011B RID: 283
		private static readonly global::System.Text.RegularExpressions.Regex _undottedNameValidator = new global::System.Text.RegularExpressions.Regex("^[\\p{L}\\p{Nl}_][\\p{L}\\p{Nl}\\p{Nd}\\p{Mn}\\p{Mc}\\p{Pc}\\p{Cf}]{0,}$", global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.Singleline);

		// Token: 0x0400011C RID: 284
		private static readonly global::System.Text.RegularExpressions.Regex _migrationIdPattern = new global::System.Text.RegularExpressions.Regex("\\d{15}_.+");

		// Token: 0x0400011D RID: 285
		private static readonly string[] _lineEndings = new string[]
		{
			"\r\n",
			"\n"
		};
	}
}
