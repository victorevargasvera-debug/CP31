using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x0200041E RID: 1054
	internal class NameCriterion : global::Ionic.SelectionCriterion
	{
		// Token: 0x17000D52 RID: 3410
		// (set) Token: 0x06002DB4 RID: 11700 RVA: 0x00099810 File Offset: 0x00097A10
		internal virtual string MatchingFileSpec
		{
			set
			{
				if (global::System.IO.Directory.Exists(value))
				{
					this._MatchingFileSpec = ".\\" + value + "\\*.*";
				}
				else
				{
					this._MatchingFileSpec = value;
				}
				this._regexString = "^" + global::System.Text.RegularExpressions.Regex.Escape(this._MatchingFileSpec).Replace("\\\\\\*\\.\\*", "\\\\([^\\.]+|.*\\.[^\\\\\\.]*)").Replace("\\.\\*", "\\.[^\\\\\\.]*").Replace("\\*", ".*").Replace("\\?", "[^\\\\\\.]") + "$";
				this._re = new global::System.Text.RegularExpressions.Regex(this._regexString, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase);
			}
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x000998BC File Offset: 0x00097ABC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("name ").Append(global::Ionic.EnumUtil.GetDescription(this.Operator)).Append(" '").Append(this._MatchingFileSpec).Append("'");
			return stringBuilder.ToString();
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x00099918 File Offset: 0x00097B18
		internal override bool Evaluate(string filename)
		{
			return this._Evaluate(filename);
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x00099924 File Offset: 0x00097B24
		private bool _Evaluate(string fullpath)
		{
			string input = (this._MatchingFileSpec.IndexOf('\\') == -1) ? global::System.IO.Path.GetFileName(fullpath) : fullpath;
			bool flag = this._re.IsMatch(input);
			if (this.Operator != global::Ionic.ComparisonOperator.EqualTo)
			{
				flag = !flag;
			}
			return flag;
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x00099974 File Offset: 0x00097B74
		internal override bool Evaluate(global::Ionic.Zip.ZipEntry entry)
		{
			string fullpath = entry.FileName.Replace("/", "\\");
			return this._Evaluate(fullpath);
		}

		// Token: 0x04000F82 RID: 3970
		private global::System.Text.RegularExpressions.Regex _re;

		// Token: 0x04000F83 RID: 3971
		private string _regexString;

		// Token: 0x04000F84 RID: 3972
		internal global::Ionic.ComparisonOperator Operator;

		// Token: 0x04000F85 RID: 3973
		private string _MatchingFileSpec;
	}
}
