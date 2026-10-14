using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Manoli.Utils.CSharpFormat
{
	// Token: 0x02000479 RID: 1145
	internal abstract class CodeFormat : global::Manoli.Utils.CSharpFormat.SourceFormat
	{
		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x060032A3 RID: 12963
		protected abstract string Keywords { get; }

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x060032A4 RID: 12964 RVA: 0x000B8E94 File Offset: 0x000B7094
		protected virtual string Preprocessors
		{
			get
			{
				return "";
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x060032A5 RID: 12965
		protected abstract string StringRegEx { get; }

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x060032A6 RID: 12966
		protected abstract string CommentRegEx { get; }

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x060032A7 RID: 12967 RVA: 0x000B8E9C File Offset: 0x000B709C
		public virtual bool CaseSensitive
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x000B8EA0 File Offset: 0x000B70A0
		protected CodeFormat()
		{
			global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("\\w+|-\\w+|#\\w+|@@\\w+|#(?:\\\\(?:s|w)(?:\\*|\\+)?\\w+)+|@\\\\w\\*+");
			string text = regex.Replace(this.Keywords, "(?<=^|\\W)$0(?=\\W)");
			string text2 = regex.Replace(this.Preprocessors, "(?<=^|\\s)$0(?=\\s|$)");
			regex = new global::System.Text.RegularExpressions.Regex(" +");
			text = regex.Replace(text, "|");
			text2 = regex.Replace(text2, "|");
			if (text2.Length == 0)
			{
				text2 = "(?!.*)_{37}(?<!.*)";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("(");
			stringBuilder.Append(this.CommentRegEx);
			stringBuilder.Append(")|(");
			stringBuilder.Append(this.StringRegEx);
			if (text2.Length > 0)
			{
				stringBuilder.Append(")|(");
				stringBuilder.Append(text2);
			}
			stringBuilder.Append(")|(");
			stringBuilder.Append(text);
			stringBuilder.Append(")");
			global::System.Text.RegularExpressions.RegexOptions regexOptions = this.CaseSensitive ? global::System.Text.RegularExpressions.RegexOptions.None : global::System.Text.RegularExpressions.RegexOptions.IgnoreCase;
			base.CodeRegex = new global::System.Text.RegularExpressions.Regex(stringBuilder.ToString(), global::System.Text.RegularExpressions.RegexOptions.Singleline | regexOptions);
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x000B8FC0 File Offset: 0x000B71C0
		protected override string MatchEval(global::System.Text.RegularExpressions.Match match)
		{
			if (match.Groups[1].Success)
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
			if (match.Groups[2].Success)
			{
				return "<span class=\"str\">" + match.ToString() + "</span>";
			}
			if (match.Groups[3].Success)
			{
				return "<span class=\"preproc\">" + match.ToString() + "</span>";
			}
			if (match.Groups[4].Success)
			{
				return "<span class=\"kwrd\">" + match.ToString() + "</span>";
			}
			return "";
		}
	}
}
