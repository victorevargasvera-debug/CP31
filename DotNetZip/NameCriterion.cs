using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x02000008 RID: 8
	internal class NameCriterion : global::Ionic.SelectionCriterion
	{
		// Token: 0x17000002 RID: 2
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002360 File Offset: 0x00000560
		internal virtual string MatchingFileSpec
		{
			set
			{
				if (global::System.IO.Directory.Exists(value))
				{
					this._MatchingFileSpec = string.Concat(new string[]
					{
						".",
						global::System.IO.Path.DirectorySeparatorChar.ToString(),
						value,
						global::System.IO.Path.DirectorySeparatorChar.ToString(),
						"*.*"
					});
				}
				else
				{
					this._MatchingFileSpec = value;
				}
				this._regexString = "^" + global::System.Text.RegularExpressions.Regex.Escape(this._MatchingFileSpec).Replace("\\\\\\*\\.\\*", "\\\\([^\\.]+|.*\\.[^\\\\\\.]*)").Replace("\\.\\*", "\\.[^\\\\\\.]*").Replace("\\*", ".*").Replace("\\?", "[^\\\\\\.]") + "$";
				this._re = new global::System.Text.RegularExpressions.Regex(this._regexString, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002434 File Offset: 0x00000634
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("name ").Append(global::Ionic.EnumUtil.GetDescription(this.Operator)).Append(" '").Append(this._MatchingFileSpec).Append("'");
			return stringBuilder.ToString();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000248B File Offset: 0x0000068B
		internal override bool Evaluate(string filename)
		{
			return this._Evaluate(filename);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002494 File Offset: 0x00000694
		private bool _Evaluate(string fullpath)
		{
			string input = (this._MatchingFileSpec.IndexOf(global::System.IO.Path.DirectorySeparatorChar) == -1) ? global::System.IO.Path.GetFileName(fullpath) : fullpath;
			bool flag = this._re.IsMatch(input);
			if (this.Operator != global::Ionic.ComparisonOperator.EqualTo)
			{
				flag = !flag;
			}
			return flag;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000024DC File Offset: 0x000006DC
		internal override bool Evaluate(global::Ionic.Zip.ZipEntry entry)
		{
			string fullpath = entry.FileName.Replace((global::System.IO.Path.DirectorySeparatorChar == '/') ? '\\' : '/', global::System.IO.Path.DirectorySeparatorChar);
			return this._Evaluate(fullpath);
		}

		// Token: 0x04000017 RID: 23
		private global::System.Text.RegularExpressions.Regex _re;

		// Token: 0x04000018 RID: 24
		private string _regexString;

		// Token: 0x04000019 RID: 25
		internal global::Ionic.ComparisonOperator Operator;

		// Token: 0x0400001A RID: 26
		private string _MatchingFileSpec;
	}
}
