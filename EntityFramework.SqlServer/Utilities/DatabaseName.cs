using System;
using System.Data.Entity.SqlServer.Resources;
using System.Globalization;
using System.Text.RegularExpressions;

namespace System.Data.Entity.SqlServer.Utilities
{
	// Token: 0x02000028 RID: 40
	internal class DatabaseName
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x00010134 File Offset: 0x0000E334
		public static global::System.Data.Entity.SqlServer.Utilities.DatabaseName Parse(string name)
		{
			global::System.Text.RegularExpressions.Match match = global::System.Data.Entity.SqlServer.Utilities.DatabaseName._partExtractor.Match(name.Trim());
			if (!match.Success)
			{
				throw global::System.Data.Entity.SqlServer.Resources.Error.InvalidDatabaseName(name);
			}
			string text = match.Groups["part1"].Value.Replace("]]", "]");
			string text2 = match.Groups["part2"].Value.Replace("]]", "]");
			if (string.IsNullOrWhiteSpace(text2))
			{
				return new global::System.Data.Entity.SqlServer.Utilities.DatabaseName(text);
			}
			return new global::System.Data.Entity.SqlServer.Utilities.DatabaseName(text2, text);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000101BF File Offset: 0x0000E3BF
		public DatabaseName(string name) : this(name, null)
		{
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000101C9 File Offset: 0x0000E3C9
		public DatabaseName(string name, string schema)
		{
			this._name = name;
			this._schema = ((!string.IsNullOrEmpty(schema)) ? schema : null);
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x000101EA File Offset: 0x0000E3EA
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x000101F2 File Offset: 0x0000E3F2
		public string Schema
		{
			get
			{
				return this._schema;
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000101FC File Offset: 0x0000E3FC
		public override string ToString()
		{
			string text = global::System.Data.Entity.SqlServer.Utilities.DatabaseName.Escape(this._name);
			if (this._schema != null)
			{
				text = global::System.Data.Entity.SqlServer.Utilities.DatabaseName.Escape(this._schema) + "." + text;
			}
			return text;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00010235 File Offset: 0x0000E435
		private static string Escape(string name)
		{
			if (name.IndexOfAny(new char[]
			{
				']',
				'[',
				'.'
			}) == -1)
			{
				return name;
			}
			return "[" + name.Replace("]", "]]") + "]";
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00010272 File Offset: 0x0000E472
		public bool Equals(global::System.Data.Entity.SqlServer.Utilities.DatabaseName other)
		{
			return other != null && (this == other || (string.Equals(other._name, this._name, global::System.StringComparison.Ordinal) && string.Equals(other._schema, this._schema, global::System.StringComparison.Ordinal)));
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000102A7 File Offset: 0x0000E4A7
		public override bool Equals(object obj)
		{
			return obj != null && (this == obj || (obj.GetType() == typeof(global::System.Data.Entity.SqlServer.Utilities.DatabaseName) && this.Equals((global::System.Data.Entity.SqlServer.Utilities.DatabaseName)obj)));
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000102D9 File Offset: 0x0000E4D9
		public override int GetHashCode()
		{
			return this._name.GetHashCode() * 397 ^ ((this._schema != null) ? this._schema.GetHashCode() : 0);
		}

		// Token: 0x040000CE RID: 206
		private const string NamePartRegex = "(?:(?:\\[(?<part{0}>(?:(?:\\]\\])|[^\\]])+)\\])|(?<part{0}>[^\\.\\[\\]]+))";

		// Token: 0x040000CF RID: 207
		private static readonly global::System.Text.RegularExpressions.Regex _partExtractor = new global::System.Text.RegularExpressions.Regex(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "^{0}(?:\\.{1})?$", new object[]
		{
			string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "(?:(?:\\[(?<part{0}>(?:(?:\\]\\])|[^\\]])+)\\])|(?<part{0}>[^\\.\\[\\]]+))", new object[]
			{
				1
			}),
			string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "(?:(?:\\[(?<part{0}>(?:(?:\\]\\])|[^\\]])+)\\])|(?<part{0}>[^\\.\\[\\]]+))", new object[]
			{
				2
			})
		}), global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x040000D0 RID: 208
		private readonly string _name;

		// Token: 0x040000D1 RID: 209
		private readonly string _schema;
	}
}
