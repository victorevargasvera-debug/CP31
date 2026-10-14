using System;
using System.Data.Entity.Resources;
using System.Globalization;
using System.Text.RegularExpressions;

namespace System.Data.Entity.Utilities
{
	// Token: 0x0200008A RID: 138
	internal class DatabaseName
	{
		// Token: 0x06000469 RID: 1129 RVA: 0x0000F69C File Offset: 0x0000D89C
		public static global::System.Data.Entity.Utilities.DatabaseName Parse(string name)
		{
			global::System.Text.RegularExpressions.Match match = global::System.Data.Entity.Utilities.DatabaseName._partExtractor.Match(name.Trim());
			if (!match.Success)
			{
				throw global::System.Data.Entity.Resources.Error.InvalidDatabaseName(name);
			}
			string text = match.Groups["part1"].Value.Replace("]]", "]");
			string text2 = match.Groups["part2"].Value.Replace("]]", "]");
			if (string.IsNullOrWhiteSpace(text2))
			{
				return new global::System.Data.Entity.Utilities.DatabaseName(text);
			}
			return new global::System.Data.Entity.Utilities.DatabaseName(text2, text);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000F727 File Offset: 0x0000D927
		public DatabaseName(string name) : this(name, null)
		{
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0000F731 File Offset: 0x0000D931
		public DatabaseName(string name, string schema)
		{
			this._name = name;
			this._schema = ((!string.IsNullOrEmpty(schema)) ? schema : null);
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0000F752 File Offset: 0x0000D952
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0000F75A File Offset: 0x0000D95A
		public string Schema
		{
			get
			{
				return this._schema;
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0000F764 File Offset: 0x0000D964
		public override string ToString()
		{
			string text = global::System.Data.Entity.Utilities.DatabaseName.Escape(this._name);
			if (this._schema != null)
			{
				text = global::System.Data.Entity.Utilities.DatabaseName.Escape(this._schema) + "." + text;
			}
			return text;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000F79D File Offset: 0x0000D99D
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

		// Token: 0x06000470 RID: 1136 RVA: 0x0000F7DA File Offset: 0x0000D9DA
		public bool Equals(global::System.Data.Entity.Utilities.DatabaseName other)
		{
			return other != null && (this == other || (string.Equals(other._name, this._name, global::System.StringComparison.Ordinal) && string.Equals(other._schema, this._schema, global::System.StringComparison.Ordinal)));
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0000F80F File Offset: 0x0000DA0F
		public override bool Equals(object obj)
		{
			return obj != null && (this == obj || (obj.GetType() == typeof(global::System.Data.Entity.Utilities.DatabaseName) && this.Equals((global::System.Data.Entity.Utilities.DatabaseName)obj)));
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0000F841 File Offset: 0x0000DA41
		public override int GetHashCode()
		{
			return this._name.GetHashCode() * 397 ^ ((this._schema != null) ? this._schema.GetHashCode() : 0);
		}

		// Token: 0x04000114 RID: 276
		private const string NamePartRegex = "(?:(?:\\[(?<part{0}>(?:(?:\\]\\])|[^\\]])+)\\])|(?<part{0}>[^\\.\\[\\]]+))";

		// Token: 0x04000115 RID: 277
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

		// Token: 0x04000116 RID: 278
		private readonly string _name;

		// Token: 0x04000117 RID: 279
		private readonly string _schema;
	}
}
