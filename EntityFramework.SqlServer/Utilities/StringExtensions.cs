using System;
using System.Data.Entity.SqlServer.Resources;
using System.Globalization;
using System.Text.RegularExpressions;

namespace System.Data.Entity.SqlServer.Utilities
{
	// Token: 0x0200002B RID: 43
	internal static class StringExtensions
	{
		// Token: 0x0600043A RID: 1082 RVA: 0x0001054E File Offset: 0x0000E74E
		public static bool EqualsIgnoreCase(this string s1, string s2)
		{
			return string.Equals(s1, s2, global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00010558 File Offset: 0x0000E758
		internal static bool EqualsOrdinal(this string s1, string s2)
		{
			return string.Equals(s1, s2, global::System.StringComparison.Ordinal);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00010562 File Offset: 0x0000E762
		public static string MigrationName(this string migrationId)
		{
			return migrationId.Substring(16);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0001056C File Offset: 0x0000E76C
		public static string RestrictTo(this string s, int size)
		{
			if (string.IsNullOrEmpty(s) || s.Length <= size)
			{
				return s;
			}
			return s.Substring(0, size);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00010589 File Offset: 0x0000E789
		public static void EachLine(this string s, global::System.Action<string> action)
		{
			s.Split(global::System.Data.Entity.SqlServer.Utilities.StringExtensions._lineEndings, global::System.StringSplitOptions.None).Each(action);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0001059D File Offset: 0x0000E79D
		public static bool IsValidMigrationId(this string migrationId)
		{
			return global::System.Data.Entity.SqlServer.Utilities.StringExtensions._migrationIdPattern.IsMatch(migrationId) || migrationId == "0";
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000105B9 File Offset: 0x0000E7B9
		public static bool IsAutomaticMigration(this string migrationId)
		{
			return migrationId.EndsWith(global::System.Data.Entity.SqlServer.Resources.Strings.AutomaticMigration, global::System.StringComparison.Ordinal);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000105C8 File Offset: 0x0000E7C8
		public static string ToAutomaticMigrationId(this string migrationId)
		{
			return (global::System.Convert.ToInt64(migrationId.Substring(0, 15), global::System.Globalization.CultureInfo.InvariantCulture) - 1L).ToString() + migrationId.Substring(15) + "_" + global::System.Data.Entity.SqlServer.Resources.Strings.AutomaticMigration;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0001060A File Offset: 0x0000E80A
		public static bool IsValidUndottedName(this string name)
		{
			return !string.IsNullOrEmpty(name) && global::System.Data.Entity.SqlServer.Utilities.StringExtensions._undottedNameValidator.IsMatch(name);
		}

		// Token: 0x040000D2 RID: 210
		private const string StartCharacterExp = "[\\p{L}\\p{Nl}_]";

		// Token: 0x040000D3 RID: 211
		private const string OtherCharacterExp = "[\\p{L}\\p{Nl}\\p{Nd}\\p{Mn}\\p{Mc}\\p{Pc}\\p{Cf}]";

		// Token: 0x040000D4 RID: 212
		private const string NameExp = "[\\p{L}\\p{Nl}_][\\p{L}\\p{Nl}\\p{Nd}\\p{Mn}\\p{Mc}\\p{Pc}\\p{Cf}]{0,}";

		// Token: 0x040000D5 RID: 213
		private static readonly global::System.Text.RegularExpressions.Regex _undottedNameValidator = new global::System.Text.RegularExpressions.Regex("^[\\p{L}\\p{Nl}_][\\p{L}\\p{Nl}\\p{Nd}\\p{Mn}\\p{Mc}\\p{Pc}\\p{Cf}]{0,}$", global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.Singleline);

		// Token: 0x040000D6 RID: 214
		private static readonly global::System.Text.RegularExpressions.Regex _migrationIdPattern = new global::System.Text.RegularExpressions.Regex("\\d{15}_.+");

		// Token: 0x040000D7 RID: 215
		private static readonly string[] _lineEndings = new string[]
		{
			"\r\n",
			"\n"
		};
	}
}
