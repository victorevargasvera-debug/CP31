using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Manoli.Utils.CSharpFormat
{
	// Token: 0x0200047C RID: 1148
	internal class HtmlFormat : global::Manoli.Utils.CSharpFormat.SourceFormat
	{
		// Token: 0x060032B0 RID: 12976 RVA: 0x000B9100 File Offset: 0x000B7300
		public HtmlFormat()
		{
			string pattern = "((?<=&lt;script(?:\\s.*?)?&gt;).+?(?=&lt;/script&gt;))|(&lt;!--.*?--&gt;)|(&lt;%@.*?%&gt;|&lt;%|%&gt;)|((?<=&lt;%).*?(?=%&gt;))|((?:&lt;/?!?\\??(?!%)|(?<!%)/?&gt;)+)|((?<=&lt;/?!?\\??(?!%))[\\w\\.:-]+(?=.*&gt;))|((?<=&lt;(?!%)/?!?\\??[\\w:-]+).*?(?=(?<!%)/?&gt;))|(&amp;\\w+;)";
			base.CodeRegex = new global::System.Text.RegularExpressions.Regex(pattern, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Singleline);
			this.attribRegex = new global::System.Text.RegularExpressions.Regex("(=?\".*?\"|=?'.*?')|([\\w:-]+)", global::System.Text.RegularExpressions.RegexOptions.Singleline);
			this.csf = new global::Manoli.Utils.CSharpFormat.CSharpFormat();
			this.jsf = new global::Manoli.Utils.CSharpFormat.JavaScriptFormat();
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x000B9154 File Offset: 0x000B7354
		private string AttributeMatchEval(global::System.Text.RegularExpressions.Match match)
		{
			if (match.Groups[1].Success)
			{
				return "<span class=\"kwrd\">" + match.ToString() + "</span>";
			}
			if (match.Groups[2].Success)
			{
				return "<span class=\"attr\">" + match.ToString() + "</span>";
			}
			return match.ToString();
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x000B91C4 File Offset: 0x000B73C4
		protected override string MatchEval(global::System.Text.RegularExpressions.Match match)
		{
			if (match.Groups[1].Success)
			{
				match.ToString();
				return this.jsf.FormatSubCode(match.ToString());
			}
			if (match.Groups[2].Success)
			{
				global::System.IO.StringReader stringReader = new global::System.IO.StringReader(match.ToString());
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				string value;
				while ((value = stringReader.ReadLine()) != null)
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append("\n");
					}
					stringBuilder.Append("<span class=\"rem\">");
					stringBuilder.Append(value);
					stringBuilder.Append("</span>");
				}
				return stringBuilder.ToString();
			}
			if (match.Groups[3].Success)
			{
				return "<span class=\"asp\">" + match.ToString() + "</span>";
			}
			if (match.Groups[4].Success)
			{
				return this.csf.FormatSubCode(match.ToString());
			}
			if (match.Groups[5].Success)
			{
				return "<span class=\"kwrd\">" + match.ToString() + "</span>";
			}
			if (match.Groups[6].Success)
			{
				return "<span class=\"html\">" + match.ToString() + "</span>";
			}
			if (match.Groups[7].Success)
			{
				return this.attribRegex.Replace(match.ToString(), new global::System.Text.RegularExpressions.MatchEvaluator(this.AttributeMatchEval));
			}
			if (match.Groups[8].Success)
			{
				return "<span class=\"attr\">" + match.ToString() + "</span>";
			}
			return match.ToString();
		}

		// Token: 0x040012DB RID: 4827
		private global::Manoli.Utils.CSharpFormat.CSharpFormat csf;

		// Token: 0x040012DC RID: 4828
		private global::Manoli.Utils.CSharpFormat.JavaScriptFormat jsf;

		// Token: 0x040012DD RID: 4829
		private global::System.Text.RegularExpressions.Regex attribRegex;
	}
}
